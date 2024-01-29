using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using DarkTonic.MasterAudio;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyVersion("0.0.0.0")]
namespace DarkTonic.MasterAudio
{
	[AddComponentMenu("Dark Tonic/Master Audio/Ambient Sound")]
	[AudioScriptOrder(-20)]
	public class AmbientSound : MonoBehaviour
	{
		[SoundGroup]
		public string AmbientSoundGroup = "[None]";

		[Tooltip("This option is useful if your caller ever moves, as it will make the Audio Source follow to the location of the caller every frame.")]
		public bool FollowCaller;

		[Tooltip("Using this option, the Audio Source will be updated every frame to the closest position on the caller's collider, if any. This will override the Follow Caller option above and happen instead.")]
		public bool UseClosestColliderPosition;

		public bool UseTopCollider = true;

		public bool IncludeChildColliders;

		[Tooltip("This is for diagnostic purposes only. Do not change or assign this field.")]
		public Transform RuntimeFollower;

		private Transform _trans;

		public bool IsValidSoundGroup => !MasterAudio.SoundGroupHardCodedNames.Contains(AmbientSoundGroup);

		public Transform Trans
		{
			get
			{
				if (_trans == null)
				{
					_trans = base.transform;
				}
				return _trans;
			}
		}

		private void OnEnable()
		{
			StartTrackers();
		}

		private void OnDisable()
		{
			if (!MasterAudio.AppIsShuttingDown && IsValidSoundGroup && !(MasterAudio.SafeInstance == null))
			{
				MasterAudio.StopSoundGroupOfTransform(Trans, AmbientSoundGroup);
				RuntimeFollower = null;
			}
		}

		private void StartTrackers()
		{
			if (IsValidSoundGroup && AmbientUtil.InitListenerFollower())
			{
				if (!AmbientUtil.HasListenerFolowerRigidBody)
				{
					MasterAudio.LogWarning("Your Ambient Sound script on Game Object '" + base.name + "' will not function because you have turned off the Listener Follower RigidBody in Advanced Settings.");
				}
				string followerName = base.name + "_" + AmbientSoundGroup + "_" + UnityEngine.Random.Range(0, 9) + "_Follower";
				RuntimeFollower = AmbientUtil.InitAudioSourceFollower(Trans, followerName, AmbientSoundGroup, FollowCaller, UseClosestColliderPosition, UseTopCollider, IncludeChildColliders);
			}
		}
	}
	[AddComponentMenu("Dark Tonic/Master Audio/Button Clicker")]
	public class ButtonClicker : MonoBehaviour
	{
		public const float SmallSizeMultiplier = 0.9f;

		public const float LargeSizeMultiplier = 1.1f;

		public bool resizeOnClick = true;

		public bool resizeClickAllSiblings;

		public bool resizeOnHover;

		public bool resizeHoverAllSiblings;

		public string mouseDownSound = string.Empty;

		public string mouseUpSound = string.Empty;

		public string mouseClickSound = string.Empty;

		public string mouseOverSound = string.Empty;

		public string mouseOutSound = string.Empty;

		private Vector3 _originalSize;

		private Vector3 _smallerSize;

		private Vector3 _largerSize;

		private Transform _trans;

		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform = new Dictionary<Transform, Vector3>();

		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform = new Dictionary<Transform, Vector3>();

		private void Awake()
		{
			_trans = base.transform;
			_originalSize = _trans.localScale;
			_smallerSize = _originalSize * 0.9f;
			_largerSize = _originalSize * 1.1f;
			Transform parent = _trans.parent;
			if (resizeOnClick && resizeClickAllSiblings && parent != null)
			{
				for (int i = 0; i < parent.transform.childCount; i++)
				{
					Transform child = parent.transform.GetChild(i);
					_siblingClickScaleByTransform.Add(child, child.localScale);
				}
			}
			if (resizeOnHover && resizeHoverAllSiblings && !(parent == null))
			{
				for (int j = 0; j < parent.transform.childCount; j++)
				{
					Transform child2 = parent.transform.GetChild(j);
					_siblingHoverScaleByTransform.Add(child2, child2.localScale);
				}
			}
		}

		private void OnPress(bool isDown)
		{
			if (isDown)
			{
				if (!base.enabled)
				{
					return;
				}
				MasterAudio.PlaySoundAndForget(mouseDownSound);
				if (resizeOnClick)
				{
					_trans.localScale = _smallerSize;
					Dictionary<Transform, Vector3>.Enumerator enumerator = _siblingClickScaleByTransform.GetEnumerator();
					while (enumerator.MoveNext())
					{
						enumerator.Current.Key.localScale = enumerator.Current.Value * 0.9f;
					}
				}
				return;
			}
			if (base.enabled)
			{
				MasterAudio.PlaySoundAndForget(mouseUpSound);
			}
			if (resizeOnClick)
			{
				_trans.localScale = _originalSize;
				Dictionary<Transform, Vector3>.Enumerator enumerator2 = _siblingClickScaleByTransform.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Key.localScale = enumerator2.Current.Value;
				}
			}
		}

		private void OnClick()
		{
			if (base.enabled)
			{
				MasterAudio.PlaySoundAndForget(mouseClickSound);
			}
		}

		private void OnHover(bool isOver)
		{
			if (isOver)
			{
				if (!base.enabled)
				{
					return;
				}
				MasterAudio.PlaySoundAndForget(mouseOverSound);
				if (resizeOnHover)
				{
					_trans.localScale = _largerSize;
					Dictionary<Transform, Vector3>.Enumerator enumerator = _siblingHoverScaleByTransform.GetEnumerator();
					while (enumerator.MoveNext())
					{
						enumerator.Current.Key.localScale = enumerator.Current.Value * 1.1f;
					}
				}
				return;
			}
			if (base.enabled)
			{
				MasterAudio.PlaySoundAndForget(mouseOutSound);
			}
			if (resizeOnHover)
			{
				_trans.localScale = _originalSize;
				Dictionary<Transform, Vector3>.Enumerator enumerator2 = _siblingHoverScaleByTransform.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Key.localScale = enumerator2.Current.Value;
				}
			}
		}
	}
	[AudioScriptOrder(-30)]
	[AddComponentMenu("Dark Tonic/Master Audio/Event Sounds")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		public enum UnityUIVersion
		{
			Legacy,
			uGUI
		}

		public enum EventType
		{
			OnStart,
			OnVisible,
			OnInvisible,
			OnCollision,
			OnTriggerEnter,
			OnTriggerExit,
			OnMouseEnter,
			OnMouseClick,
			OnSpawned,
			OnDespawned,
			OnEnable,
			OnDisable,
			OnCollision2D,
			OnTriggerEnter2D,
			OnTriggerExit2D,
			OnParticleCollision,
			UserDefinedEvent,
			OnCollisionExit,
			OnCollisionExit2D,
			OnMouseUp,
			OnMouseExit,
			OnMouseDrag,
			NGUIOnClick,
			NGUIMouseDown,
			NGUIMouseUp,
			NGUIMouseEnter,
			NGUIMouseExit,
			MechanimStateChanged,
			UnitySliderChanged,
			UnityButtonClicked,
			UnityPointerDown,
			UnityPointerUp,
			UnityPointerEnter,
			UnityPointerExit,
			UnityDrag,
			UnityDrop,
			UnityScroll,
			UnityUpdateSelected,
			UnitySelect,
			UnityDeselect,
			UnityMove,
			UnityInitializePotentialDrag,
			UnityBeginDrag,
			UnityEndDrag,
			UnitySubmit,
			UnityCancel,
			UnityToggle,
			OnTriggerStay,
			OnTriggerStay2D
		}

		public enum GlidePitchType
		{
			None,
			RaisePitch,
			LowerPitch
		}

		public enum VariationType
		{
			PlaySpecific,
			PlayRandom
		}

		public enum PreviousSoundStopMode
		{
			None,
			Stop,
			FadeOut
		}

		public enum RetriggerLimMode
		{
			None,
			FrameBased,
			TimeBased
		}

		public bool showGizmo;

		public MasterAudio.SoundSpawnLocationMode soundSpawnMode = MasterAudio.SoundSpawnLocationMode.AttachToCaller;

		public bool disableSounds;

		public bool showPoolManager;

		public bool showNGUI;

		public UnityUIVersion unityUIMode = UnityUIVersion.uGUI;

		public bool logMissingEvents = true;

		public static List<string> LayerTagFilterEvents = new List<string>
		{
			EventType.OnCollision.ToString(),
			EventType.OnTriggerEnter.ToString(),
			EventType.OnTriggerExit.ToString(),
			EventType.OnCollision2D.ToString(),
			EventType.OnTriggerEnter2D.ToString(),
			EventType.OnTriggerExit2D.ToString(),
			EventType.OnParticleCollision.ToString(),
			EventType.OnCollisionExit.ToString(),
			EventType.OnCollisionExit2D.ToString()
		};

		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll = new List<MasterAudio.PlaylistCommand>
		{
			MasterAudio.PlaylistCommand.FadeToVolume,
			MasterAudio.PlaylistCommand.Pause,
			MasterAudio.PlaylistCommand.PlayNextSong,
			MasterAudio.PlaylistCommand.PlayRandomSong,
			MasterAudio.PlaylistCommand.Resume,
			MasterAudio.PlaylistCommand.Stop,
			MasterAudio.PlaylistCommand.Mute,
			MasterAudio.PlaylistCommand.Unmute,
			MasterAudio.PlaylistCommand.ToggleMute,
			MasterAudio.PlaylistCommand.Restart,
			MasterAudio.PlaylistCommand.StopLoopingCurrentSong,
			MasterAudio.PlaylistCommand.StopPlaylistAfterCurrentSong
		};

		public AudioEventGroup startSound;

		public AudioEventGroup visibleSound;

		public AudioEventGroup invisibleSound;

		public AudioEventGroup collisionSound;

		public AudioEventGroup collisionExitSound;

		public AudioEventGroup triggerSound;

		public AudioEventGroup triggerExitSound;

		public AudioEventGroup triggerStaySound;

		public AudioEventGroup mouseEnterSound;

		public AudioEventGroup mouseExitSound;

		public AudioEventGroup mouseClickSound;

		public AudioEventGroup mouseUpSound;

		public AudioEventGroup mouseDragSound;

		public AudioEventGroup spawnedSound;

		public AudioEventGroup despawnedSound;

		public AudioEventGroup enableSound;

		public AudioEventGroup disableSound;

		public AudioEventGroup collision2dSound;

		public AudioEventGroup collisionExit2dSound;

		public AudioEventGroup triggerEnter2dSound;

		public AudioEventGroup triggerStay2dSound;

		public AudioEventGroup triggerExit2dSound;

		public AudioEventGroup particleCollisionSound;

		public AudioEventGroup nguiOnClickSound;

		public AudioEventGroup nguiMouseDownSound;

		public AudioEventGroup nguiMouseUpSound;

		public AudioEventGroup nguiMouseEnterSound;

		public AudioEventGroup nguiMouseExitSound;

		public AudioEventGroup unitySliderChangedSound;

		public AudioEventGroup unityButtonClickedSound;

		public AudioEventGroup unityPointerDownSound;

		public AudioEventGroup unityDragSound;

		public AudioEventGroup unityPointerUpSound;

		public AudioEventGroup unityPointerEnterSound;

		public AudioEventGroup unityPointerExitSound;

		public AudioEventGroup unityDropSound;

		public AudioEventGroup unityScrollSound;

		public AudioEventGroup unityUpdateSelectedSound;

		public AudioEventGroup unitySelectSound;

		public AudioEventGroup unityDeselectSound;

		public AudioEventGroup unityMoveSound;

		public AudioEventGroup unityInitializePotentialDragSound;

		public AudioEventGroup unityBeginDragSound;

		public AudioEventGroup unityEndDragSound;

		public AudioEventGroup unitySubmitSound;

		public AudioEventGroup unityCancelSound;

		public AudioEventGroup unityToggleSound;

		public List<AudioEventGroup> userDefinedSounds = new List<AudioEventGroup>();

		public List<AudioEventGroup> mechanimStateChangedSounds = new List<AudioEventGroup>();

		public bool useStartSound;

		public bool useVisibleSound;

		public bool useInvisibleSound;

		public bool useCollisionSound;

		public bool useCollisionExitSound;

		public bool useTriggerEnterSound;

		public bool useTriggerExitSound;

		public bool useTriggerStaySound;

		public bool useMouseEnterSound;

		public bool useMouseExitSound;

		public bool useMouseClickSound;

		public bool useMouseUpSound;

		public bool useMouseDragSound;

		public bool useSpawnedSound;

		public bool useDespawnedSound;

		public bool useEnableSound;

		public bool useDisableSound;

		public bool useCollision2dSound;

		public bool useCollisionExit2dSound;

		public bool useTriggerEnter2dSound;

		public bool useTriggerStay2dSound;

		public bool useTriggerExit2dSound;

		public bool useParticleCollisionSound;

		public bool useNguiOnClickSound;

		public bool useNguiMouseDownSound;

		public bool useNguiMouseUpSound;

		public bool useNguiMouseEnterSound;

		public bool useNguiMouseExitSound;

		public bool useUnitySliderChangedSound;

		public bool useUnityButtonClickedSound;

		public bool useUnityPointerDownSound;

		public bool useUnityDragSound;

		public bool useUnityPointerUpSound;

		public bool useUnityPointerEnterSound;

		public bool useUnityPointerExitSound;

		public bool useUnityDropSound;

		public bool useUnityScrollSound;

		public bool useUnityUpdateSelectedSound;

		public bool useUnitySelectSound;

		public bool useUnityDeselectSound;

		public bool useUnityMoveSound;

		public bool useUnityInitializePotentialDragSound;

		public bool useUnityBeginDragSound;

		public bool useUnityEndDragSound;

		public bool useUnitySubmitSound;

		public bool useUnityCancelSound;

		public bool useUnityToggleSound;

		private Slider _slider;

		private Toggle _toggle;

		private Button _button;

		private bool _isVisible;

		private bool _needsCoroutine;

		private float? _triggerEnterTime;

		private float? _triggerEnter2dTime;

		private Transform _trans;

		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds = new List<AudioEventGroup>();

		private Animator _anim;

		private bool IsSetToUGUI => unityUIMode != UnityUIVersion.Legacy;

		private bool IsSetToLegacyUI => unityUIMode == UnityUIVersion.Legacy;

		private void Awake()
		{
			_trans = base.transform;
			_anim = GetComponent<Animator>();
			_slider = GetComponent<Slider>();
			_button = GetComponent<Button>();
			_toggle = GetComponent<Toggle>();
			if (IsSetToUGUI)
			{
				AddUGUIComponents();
			}
			SpawnedOrAwake();
		}

		protected virtual void SpawnedOrAwake()
		{
			_isVisible = false;
			_validMechanimStateChangedSounds.Clear();
			_needsCoroutine = false;
			if (disableSounds || _anim == null)
			{
				return;
			}
			for (int i = 0; i < mechanimStateChangedSounds.Count; i++)
			{
				AudioEventGroup audioEventGroup = mechanimStateChangedSounds[i];
				if (audioEventGroup.mechanimEventActive && !string.IsNullOrEmpty(audioEventGroup.mechanimStateName))
				{
					_needsCoroutine = true;
					_validMechanimStateChangedSounds.Add(audioEventGroup);
				}
			}
		}

		private IEnumerator CoUpdate()
		{
			while (true)
			{
				yield return MasterAudio.EndOfFrameDelay;
				for (int i = 0; i < _validMechanimStateChangedSounds.Count; i++)
				{
					AudioEventGroup audioEventGroup = _validMechanimStateChangedSounds[i];
					if (!_anim.GetCurrentAnimatorStateInfo(0).IsName(audioEventGroup.mechanimStateName))
					{
						audioEventGroup.mechEventPlayedForState = false;
					}
					else if (!audioEventGroup.mechEventPlayedForState)
					{
						audioEventGroup.mechEventPlayedForState = true;
						PlaySounds(audioEventGroup, EventType.MechanimStateChanged);
					}
				}
			}
		}

		private void Start()
		{
			CheckForIllegalCustomEvents();
			if (useStartSound)
			{
				PlaySounds(startSound, EventType.OnStart);
			}
		}

		private void OnBecameVisible()
		{
			if (useVisibleSound && !_isVisible)
			{
				_isVisible = true;
				PlaySounds(visibleSound, EventType.OnVisible);
			}
		}

		private void OnBecameInvisible()
		{
			if (useInvisibleSound)
			{
				_isVisible = false;
				PlaySounds(invisibleSound, EventType.OnInvisible);
			}
		}

		private void OnEnable()
		{
			if (_slider != null)
			{
				_slider.onValueChanged.AddListener(SliderChanged);
				RestorePersistentSliders();
			}
			if (_button != null)
			{
				_button.onClick.AddListener(ButtonClicked);
			}
			if (_toggle != null)
			{
				_toggle.onValueChanged.AddListener(ToggleChanged);
			}
			RegisterReceiver();
			if (_needsCoroutine)
			{
				StopAllCoroutines();
				StartCoroutine(CoUpdate());
			}
			if (useEnableSound)
			{
				PlaySounds(enableSound, EventType.OnEnable);
			}
		}

		private void RestorePersistentSliders()
		{
			if (!useUnitySliderChangedSound)
			{
				return;
			}
			foreach (AudioEvent soundEvent in unitySliderChangedSound.SoundEvents)
			{
				if (soundEvent.currentSoundFunctionType != MasterAudio.EventSoundFunctionType.PersistentSettingsControl || soundEvent.targetVolMode != 0)
				{
					continue;
				}
				switch (soundEvent.currentPersistentSettingsCommand)
				{
				case MasterAudio.PersistentSettingsCommand.SetMusicVolume:
				{
					float? musicVolume = PersistentAudioSettings.MusicVolume;
					if (musicVolume.HasValue)
					{
						_slider.value = musicVolume.Value;
					}
					break;
				}
				case MasterAudio.PersistentSettingsCommand.SetBusVolume:
					if (!soundEvent.allSoundTypesForBusCmd)
					{
						float? busVolume = PersistentAudioSettings.GetBusVolume(soundEvent.busName);
						if (busVolume.HasValue)
						{
							_slider.value = busVolume.Value;
						}
					}
					break;
				case MasterAudio.PersistentSettingsCommand.SetMixerVolume:
				{
					float? mixerVolume = PersistentAudioSettings.MixerVolume;
					if (mixerVolume.HasValue)
					{
						_slider.value = mixerVolume.Value;
					}
					break;
				}
				case MasterAudio.PersistentSettingsCommand.SetGroupVolume:
					if (!soundEvent.allSoundTypesForGroupCmd)
					{
						float? groupVolume = PersistentAudioSettings.GetGroupVolume(soundEvent.soundType);
						if (groupVolume.HasValue)
						{
							_slider.value = groupVolume.Value;
						}
					}
					break;
				}
			}
		}

		private void OnDisable()
		{
			if (!(MasterAudio.SafeInstance == null) && !MasterAudio.AppIsShuttingDown)
			{
				if (_slider != null)
				{
					_slider.onValueChanged.RemoveListener(SliderChanged);
				}
				if (_button != null)
				{
					_button.onClick.RemoveListener(ButtonClicked);
				}
				if (_toggle != null)
				{
					_toggle.onValueChanged.RemoveListener(ToggleChanged);
				}
				UnregisterReceiver();
				if (useDisableSound && !MasterAudio.AppIsShuttingDown)
				{
					PlaySounds(disableSound, EventType.OnDisable);
				}
			}
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			_triggerEnter2dTime = Time.realtimeSinceStartup;
			if (useTriggerEnter2dSound && (!triggerEnter2dSound.useLayerFilter || triggerEnter2dSound.matchingLayers.Contains(other.gameObject.layer)) && (!triggerEnter2dSound.useTagFilter || triggerEnter2dSound.matchingTags.Contains(other.gameObject.tag)))
			{
				PlaySounds(triggerEnter2dSound, EventType.OnTriggerEnter2D);
			}
		}

		private void OnTriggerStay2D(Collider2D other)
		{
			if (useTriggerStay2dSound)
			{
				float num = 0f;
				num = (_triggerEnter2dTime.HasValue ? (Time.realtimeSinceStartup - _triggerEnter2dTime.Value) : 0f);
				if (!(triggerStay2dSound.triggerStayForTime > num) && PlaySounds(triggerStay2dSound, EventType.OnTriggerStay2D) && triggerStay2dSound.doesTriggerStayRepeat)
				{
					_triggerEnter2dTime = Time.realtimeSinceStartup;
				}
			}
		}

		private void OnTriggerExit2D(Collider2D other)
		{
			_triggerEnter2dTime = null;
			if (useTriggerExit2dSound && (!triggerExit2dSound.useLayerFilter || triggerExit2dSound.matchingLayers.Contains(other.gameObject.layer)) && (!triggerExit2dSound.useTagFilter || triggerExit2dSound.matchingTags.Contains(other.gameObject.tag)))
			{
				PlaySounds(triggerExit2dSound, EventType.OnTriggerExit2D);
			}
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (useCollision2dSound && (!collision2dSound.useLayerFilter || collision2dSound.matchingLayers.Contains(collision.gameObject.layer)) && (!collision2dSound.useTagFilter || collision2dSound.matchingTags.Contains(collision.gameObject.tag)))
			{
				PlaySounds(collision2dSound, EventType.OnCollision2D);
			}
		}

		private void OnCollisionExit2D(Collision2D collision)
		{
			if (useCollisionExit2dSound && (!collisionExit2dSound.useLayerFilter || collisionExit2dSound.matchingLayers.Contains(collision.gameObject.layer)) && (!collisionExit2dSound.useTagFilter || collisionExit2dSound.matchingTags.Contains(collision.gameObject.tag)))
			{
				PlaySounds(collisionExit2dSound, EventType.OnCollisionExit2D);
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (useCollisionSound && (!collisionSound.useLayerFilter || collisionSound.matchingLayers.Contains(collision.gameObject.layer)) && (!collisionSound.useTagFilter || collisionSound.matchingTags.Contains(collision.gameObject.tag)))
			{
				PlaySounds(collisionSound, EventType.OnCollision);
			}
		}

		private void OnCollisionExit(Collision collision)
		{
			if (useCollisionExitSound && (!collisionExitSound.useLayerFilter || collisionExitSound.matchingLayers.Contains(collision.gameObject.layer)) && (!collisionExitSound.useTagFilter || collisionExitSound.matchingTags.Contains(collision.gameObject.tag)))
			{
				PlaySounds(collisionExitSound, EventType.OnCollisionExit);
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			_triggerEnterTime = Time.realtimeSinceStartup;
			if (useTriggerEnterSound && (!triggerSound.useLayerFilter || triggerSound.matchingLayers.Contains(other.gameObject.layer)) && (!triggerSound.useTagFilter || triggerSound.matchingTags.Contains(other.gameObject.tag)))
			{
				PlaySounds(triggerSound, EventType.OnTriggerEnter);
			}
		}

		private void OnTriggerStay(Collider other)
		{
			if (useTriggerStaySound)
			{
				float num = 0f;
				num = (_triggerEnterTime.HasValue ? (Time.realtimeSinceStartup - _triggerEnterTime.Value) : 0f);
				if (!(triggerStaySound.triggerStayForTime > num) && PlaySounds(triggerStaySound, EventType.OnTriggerStay) && triggerStaySound.doesTriggerStayRepeat)
				{
					_triggerEnterTime = Time.realtimeSinceStartup;
				}
			}
		}

		private void OnTriggerExit(Collider other)
		{
			_triggerEnterTime = null;
			if (useTriggerExitSound && (!triggerExitSound.useLayerFilter || triggerExitSound.matchingLayers.Contains(other.gameObject.layer)) && (!triggerExitSound.useTagFilter || triggerExitSound.matchingTags.Contains(other.gameObject.tag)))
			{
				PlaySounds(triggerExitSound, EventType.OnTriggerExit);
			}
		}

		private void OnParticleCollision(GameObject other)
		{
			if (useParticleCollisionSound && (!particleCollisionSound.useLayerFilter || particleCollisionSound.matchingLayers.Contains(other.gameObject.layer)) && (!particleCollisionSound.useTagFilter || particleCollisionSound.matchingTags.Contains(other.gameObject.tag)))
			{
				PlaySounds(particleCollisionSound, EventType.OnParticleCollision);
			}
		}

		public void OnPointerEnter(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityPointerEnterSound)
			{
				PlaySounds(unityPointerEnterSound, EventType.UnityPointerEnter);
			}
		}

		public void OnPointerExit(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityPointerExitSound)
			{
				PlaySounds(unityPointerExitSound, EventType.UnityPointerExit);
			}
		}

		public void OnPointerDown(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityPointerDownSound)
			{
				PlaySounds(unityPointerDownSound, EventType.UnityPointerDown);
			}
		}

		public void OnPointerUp(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityPointerUpSound)
			{
				PlaySounds(unityPointerUpSound, EventType.UnityPointerUp);
			}
		}

		private void OnDrag(Vector2 delta)
		{
		}

		public void OnDrag(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityDragSound)
			{
				PlaySounds(unityDragSound, EventType.UnityDrag);
			}
		}

		private void OnDrop(GameObject go)
		{
		}

		public void OnDrop(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityDropSound)
			{
				PlaySounds(unityDropSound, EventType.UnityDrop);
			}
		}

		public void OnScroll(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityScrollSound)
			{
				PlaySounds(unityScrollSound, EventType.UnityScroll);
			}
		}

		public void OnUpdateSelected(BaseEventData data)
		{
			if (IsSetToUGUI && useUnityUpdateSelectedSound)
			{
				PlaySounds(unityUpdateSelectedSound, EventType.UnityUpdateSelected);
			}
		}

		private void OnSelect(bool isSelected)
		{
		}

		public void OnSelect(BaseEventData data)
		{
			if (IsSetToUGUI && useUnitySelectSound)
			{
				PlaySounds(unitySelectSound, EventType.UnitySelect);
			}
		}

		public void OnDeselect(BaseEventData data)
		{
			if (IsSetToUGUI && useUnityDeselectSound)
			{
				PlaySounds(unityDeselectSound, EventType.UnityDeselect);
			}
		}

		public void OnMove(AxisEventData data)
		{
			if (IsSetToUGUI && useUnityMoveSound)
			{
				PlaySounds(unityMoveSound, EventType.UnityMove);
			}
		}

		public void OnInitializePotentialDrag(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityInitializePotentialDragSound)
			{
				PlaySounds(unityInitializePotentialDragSound, EventType.UnityInitializePotentialDrag);
			}
		}

		public void OnBeginDrag(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityBeginDragSound)
			{
				PlaySounds(unityBeginDragSound, EventType.UnityBeginDrag);
			}
		}

		public void OnEndDrag(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityEndDragSound)
			{
				PlaySounds(unityEndDragSound, EventType.UnityEndDrag);
			}
		}

		public void OnSubmit(BaseEventData data)
		{
			if (IsSetToUGUI && useUnitySubmitSound)
			{
				PlaySounds(unitySubmitSound, EventType.UnitySubmit);
			}
		}

		public void OnCancel(BaseEventData data)
		{
			if (IsSetToUGUI && useUnityCancelSound)
			{
				PlaySounds(unityCancelSound, EventType.UnityCancel);
			}
		}

		private void SliderChanged(float newValue)
		{
			if (useUnitySliderChangedSound)
			{
				unitySliderChangedSound.sliderValue = newValue;
				PlaySounds(unitySliderChangedSound, EventType.UnitySliderChanged);
			}
		}

		private void ToggleChanged(bool newValue)
		{
			if (useUnityToggleSound)
			{
				PlaySounds(unityToggleSound, EventType.UnityToggle);
			}
		}

		private void ButtonClicked()
		{
			if (useUnityButtonClickedSound)
			{
				PlaySounds(unityButtonClickedSound, EventType.UnityButtonClicked);
			}
		}

		private void OnPress(bool isDown)
		{
			if (!showNGUI)
			{
				return;
			}
			if (isDown)
			{
				if (useNguiMouseDownSound)
				{
					PlaySounds(nguiMouseDownSound, EventType.NGUIMouseDown);
				}
			}
			else if (useNguiMouseUpSound)
			{
				PlaySounds(nguiMouseUpSound, EventType.NGUIMouseUp);
			}
		}

		private void OnClick()
		{
			if (showNGUI && useNguiOnClickSound)
			{
				PlaySounds(nguiOnClickSound, EventType.NGUIOnClick);
			}
		}

		private void OnHover(bool isOver)
		{
			if (!showNGUI)
			{
				return;
			}
			if (isOver)
			{
				if (useNguiMouseEnterSound)
				{
					PlaySounds(nguiMouseEnterSound, EventType.NGUIMouseEnter);
				}
			}
			else if (useNguiMouseExitSound)
			{
				PlaySounds(nguiMouseExitSound, EventType.NGUIMouseExit);
			}
		}

		private void OnSpawned()
		{
			SpawnedOrAwake();
			if (showPoolManager && useSpawnedSound)
			{
				PlaySounds(spawnedSound, EventType.OnSpawned);
			}
		}

		private void OnDespawned()
		{
			if (showPoolManager && useDespawnedSound)
			{
				PlaySounds(despawnedSound, EventType.OnDespawned);
			}
		}

		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return _validMechanimStateChangedSounds.Find((AudioEventGroup grp) => grp.mechanimStateName == stateName);
		}

		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			if (!CheckForRetriggerLimit(eventGrp))
			{
				return false;
			}
			if (MasterAudio.SafeInstance == null)
			{
				return false;
			}
			switch (eventGrp.retriggerLimitMode)
			{
			case RetriggerLimMode.FrameBased:
				eventGrp.triggeredLastFrame = AudioUtil.FrameCount;
				break;
			case RetriggerLimMode.TimeBased:
				eventGrp.triggeredLastTime = AudioUtil.Time;
				break;
			}
			if (!MasterAudio.AppIsShuttingDown && MasterAudio.IsWarming)
			{
				AudioEvent aEvent = new AudioEvent();
				PerformSingleAction(eventGrp, aEvent, eType);
				return true;
			}
			for (int i = 0; i < eventGrp.SoundEvents.Count; i++)
			{
				PerformSingleAction(eventGrp, eventGrp.SoundEvents[i], eType);
			}
			return true;
		}

		private void OnDrawGizmos()
		{
			if (showGizmo)
			{
				Gizmos.DrawIcon(base.transform.position, "MasterAudio/MasterAudio Icon.png", allowScaling: true);
			}
		}

		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			switch (grp.retriggerLimitMode)
			{
			case RetriggerLimMode.FrameBased:
				if (grp.triggeredLastFrame > 0 && AudioUtil.FrameCount - grp.triggeredLastFrame < grp.limitPerXFrm)
				{
					return false;
				}
				break;
			case RetriggerLimMode.TimeBased:
				if (grp.triggeredLastTime > 0f && AudioUtil.Time - grp.triggeredLastTime < grp.limitPerXSec)
				{
					return false;
				}
				break;
			}
			return true;
		}

		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
			if (disableSounds || MasterAudio.AppIsShuttingDown || MasterAudio.SafeInstance == null)
			{
				return;
			}
			bool flag = eType == EventType.UnitySliderChanged && aEvent.targetVolMode == AudioEvent.TargetVolumeMode.UseSliderValue;
			float volumePercentage = aEvent.volume;
			string soundType = aEvent.soundType;
			float? pitch = aEvent.pitch;
			if (!aEvent.useFixedPitch)
			{
				pitch = null;
			}
			PlaySoundResult playSoundResult = null;
			MasterAudio.SoundSpawnLocationMode soundSpawnLocationMode = soundSpawnMode;
			if (eType == EventType.OnDisable || eType == EventType.OnDespawned)
			{
				soundSpawnLocationMode = MasterAudio.SoundSpawnLocationMode.CallerLocation;
			}
			bool flag2 = eType == EventType.OnMouseDrag || aEvent.glidePitchType != GlidePitchType.None;
			switch (aEvent.currentSoundFunctionType)
			{
			case MasterAudio.EventSoundFunctionType.PlaySound:
			{
				string variationName = null;
				if (aEvent.variationType == VariationType.PlaySpecific)
				{
					variationName = aEvent.variationName;
				}
				if (flag)
				{
					volumePercentage = grp.sliderValue;
				}
				switch (soundSpawnLocationMode)
				{
				case MasterAudio.SoundSpawnLocationMode.CallerLocation:
					if (flag2)
					{
						playSoundResult = MasterAudio.PlaySound3DAtTransform(soundType, _trans, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					break;
				case MasterAudio.SoundSpawnLocationMode.AttachToCaller:
					if (flag2)
					{
						playSoundResult = MasterAudio.PlaySound3DFollowTransform(soundType, _trans, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					else
					{
						MasterAudio.PlaySound3DFollowTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					break;
				case MasterAudio.SoundSpawnLocationMode.MasterAudioLocation:
					if (flag2)
					{
						playSoundResult = MasterAudio.PlaySound(soundType, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					else
					{
						MasterAudio.PlaySoundAndForget(soundType, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					break;
				}
				if (playSoundResult != null && playSoundResult.ActingVariation != null && aEvent.glidePitchType != 0)
				{
					switch (aEvent.glidePitchType)
					{
					case GlidePitchType.RaisePitch:
						playSoundResult.ActingVariation.GlideByPitch(aEvent.targetGlidePitch, aEvent.pitchGlideTime);
						break;
					case GlidePitchType.LowerPitch:
						playSoundResult.ActingVariation.GlideByPitch(0f - aEvent.targetGlidePitch, aEvent.pitchGlideTime);
						break;
					}
				}
				break;
			}
			case MasterAudio.EventSoundFunctionType.PlaylistControl:
			{
				PlaySoundResult playSoundResult2 = new PlaySoundResult();
				playSoundResult2.ActingVariation = null;
				playSoundResult2.SoundPlayed = true;
				playSoundResult2.SoundScheduled = false;
				playSoundResult = playSoundResult2;
				if (string.IsNullOrEmpty(aEvent.playlistControllerName))
				{
					aEvent.playlistControllerName = "~only~";
				}
				switch (aEvent.currentPlaylistCommand)
				{
				case MasterAudio.PlaylistCommand.None:
					playSoundResult.SoundPlayed = false;
					break;
				case MasterAudio.PlaylistCommand.Restart:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.RestartAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.RestartPlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Start:
					if (!(aEvent.playlistControllerName == "[None]") && !(aEvent.playlistName == "[None]"))
					{
						MasterAudio.StartPlaylist(aEvent.playlistControllerName, aEvent.playlistName);
					}
					break;
				case MasterAudio.PlaylistCommand.ChangePlaylist:
					if (string.IsNullOrEmpty(aEvent.playlistName))
					{
						UnityEngine.Debug.Log("You have not specified a Playlist name for Event Sounds on '" + _trans.name + "'.");
						playSoundResult.SoundPlayed = false;
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.ChangePlaylistByName(aEvent.playlistControllerName, aEvent.playlistName, aEvent.startPlaylist);
					}
					break;
				case MasterAudio.PlaylistCommand.StopLoopingCurrentSong:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.StopLoopingAllCurrentSongs();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.StopLoopingCurrentSong(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.StopPlaylistAfterCurrentSong:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.StopAllPlaylistsAfterCurrentSongs();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.StopPlaylistAfterCurrentSong(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.FadeToVolume:
				{
					float targetVolume = ((!flag) ? aEvent.fadeVolume : grp.sliderValue);
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.FadeAllPlaylistsToVolume(targetVolume, aEvent.fadeTime);
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.FadePlaylistToVolume(aEvent.playlistControllerName, targetVolume, aEvent.fadeTime);
					}
					break;
				}
				case MasterAudio.PlaylistCommand.Mute:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.MuteAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.MutePlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Unmute:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.UnmuteAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.UnmutePlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.ToggleMute:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.ToggleMuteAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.ToggleMutePlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.PlaySong:
					if (string.IsNullOrEmpty(aEvent.clipName))
					{
						UnityEngine.Debug.Log("You have not specified a song name for Event Sounds on '" + _trans.name + "'.");
						playSoundResult.SoundPlayed = false;
					}
					else if (!(aEvent.playlistControllerName == "[None]") && !MasterAudio.TriggerPlaylistClip(aEvent.playlistControllerName, aEvent.clipName))
					{
						playSoundResult.SoundPlayed = false;
					}
					break;
				case MasterAudio.PlaylistCommand.AddSongToQueue:
					playSoundResult.SoundPlayed = false;
					if (string.IsNullOrEmpty(aEvent.clipName))
					{
						UnityEngine.Debug.Log("You have not specified a song name for Event Sounds on '" + _trans.name + "'.");
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.QueuePlaylistClip(aEvent.playlistControllerName, aEvent.clipName);
						playSoundResult.SoundPlayed = true;
					}
					break;
				case MasterAudio.PlaylistCommand.PlayRandomSong:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.TriggerRandomClipAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.TriggerRandomPlaylistClip(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.PlayNextSong:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.TriggerNextClipAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.TriggerNextPlaylistClip(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Pause:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.PauseAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.PausePlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Stop:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.StopAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.StopPlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Resume:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.UnpauseAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.UnpausePlaylist(aEvent.playlistControllerName);
					}
					break;
				}
				break;
			}
			case MasterAudio.EventSoundFunctionType.GroupControl:
			{
				PlaySoundResult playSoundResult2 = new PlaySoundResult();
				playSoundResult2.ActingVariation = null;
				playSoundResult2.SoundPlayed = true;
				playSoundResult2.SoundScheduled = false;
				playSoundResult = playSoundResult2;
				List<string> list5 = new List<string>();
				if (!aEvent.allSoundTypesForGroupCmd || MasterAudio.GroupCommandsWithNoAllGroupSelector.Contains(aEvent.currentSoundGroupCommand))
				{
					list5.Add(aEvent.soundType);
				}
				else
				{
					list5.AddRange(MasterAudio.RuntimeSoundGroupNames);
				}
				for (int l = 0; l < list5.Count; l++)
				{
					string sType = list5[l];
					switch (aEvent.currentSoundGroupCommand)
					{
					case MasterAudio.SoundGroupCommand.None:
						playSoundResult.SoundPlayed = false;
						break;
					case MasterAudio.SoundGroupCommand.ToggleSoundGroup:
						if (MasterAudio.IsSoundGroupPlaying(sType))
						{
							MasterAudio.FadeOutAllOfSound(sType, aEvent.fadeTime);
							break;
						}
						switch (soundSpawnLocationMode)
						{
						case MasterAudio.SoundSpawnLocationMode.CallerLocation:
							MasterAudio.PlaySound3DAtTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound);
							break;
						case MasterAudio.SoundSpawnLocationMode.AttachToCaller:
							MasterAudio.PlaySound3DFollowTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound);
							break;
						case MasterAudio.SoundSpawnLocationMode.MasterAudioLocation:
							MasterAudio.PlaySoundAndForget(soundType, volumePercentage, pitch, aEvent.delaySound);
							break;
						}
						break;
					case MasterAudio.SoundGroupCommand.ToggleSoundGroupOfTransform:
						if (MasterAudio.IsTransformPlayingSoundGroup(sType, _trans))
						{
							MasterAudio.FadeOutSoundGroupOfTransform(_trans, sType, aEvent.fadeTime);
							break;
						}
						switch (soundSpawnLocationMode)
						{
						case MasterAudio.SoundSpawnLocationMode.CallerLocation:
							MasterAudio.PlaySound3DAtTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound);
							break;
						case MasterAudio.SoundSpawnLocationMode.AttachToCaller:
							MasterAudio.PlaySound3DFollowTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound);
							break;
						case MasterAudio.SoundSpawnLocationMode.MasterAudioLocation:
							MasterAudio.PlaySoundAndForget(soundType, volumePercentage, pitch, aEvent.delaySound);
							break;
						}
						break;
					case MasterAudio.SoundGroupCommand.RefillSoundGroupPool:
						MasterAudio.RefillSoundGroupPool(sType);
						break;
					case MasterAudio.SoundGroupCommand.FadeToVolume:
					{
						float newVolume = ((!flag) ? aEvent.fadeVolume : grp.sliderValue);
						MasterAudio.FadeSoundGroupToVolume(sType, newVolume, aEvent.fadeTime, null, aEvent.stopAfterFade, aEvent.restoreVolumeAfterFade);
						break;
					}
					case MasterAudio.SoundGroupCommand.FadeOutAllOfSound:
						MasterAudio.FadeOutAllOfSound(sType, aEvent.fadeTime);
						break;
					case MasterAudio.SoundGroupCommand.Mute:
						MasterAudio.MuteGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.Pause:
						MasterAudio.PauseSoundGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.Solo:
						MasterAudio.SoloGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.StopAllOfSound:
						MasterAudio.StopAllOfSound(sType);
						break;
					case MasterAudio.SoundGroupCommand.Unmute:
						MasterAudio.UnmuteGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.Unpause:
						MasterAudio.UnpauseSoundGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.Unsolo:
						MasterAudio.UnsoloGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.StopAllSoundsOfTransform:
						MasterAudio.StopAllSoundsOfTransform(_trans);
						break;
					case MasterAudio.SoundGroupCommand.StopSoundGroupOfTransform:
						MasterAudio.StopSoundGroupOfTransform(_trans, sType);
						break;
					case MasterAudio.SoundGroupCommand.PauseAllSoundsOfTransform:
						MasterAudio.PauseAllSoundsOfTransform(_trans);
						break;
					case MasterAudio.SoundGroupCommand.PauseSoundGroupOfTransform:
						MasterAudio.PauseSoundGroupOfTransform(_trans, sType);
						break;
					case MasterAudio.SoundGroupCommand.UnpauseAllSoundsOfTransform:
						MasterAudio.UnpauseAllSoundsOfTransform(_trans);
						break;
					case MasterAudio.SoundGroupCommand.UnpauseSoundGroupOfTransform:
						MasterAudio.UnpauseSoundGroupOfTransform(_trans, sType);
						break;
					case MasterAudio.SoundGroupCommand.FadeOutSoundGroupOfTransform:
						MasterAudio.FadeOutSoundGroupOfTransform(_trans, sType, aEvent.fadeTime);
						break;
					case MasterAudio.SoundGroupCommand.FadeOutAllSoundsOfTransform:
						MasterAudio.FadeOutAllSoundsOfTransform(_trans, aEvent.fadeTime);
						break;
					case MasterAudio.SoundGroupCommand.RouteToBus:
					{
						string text = aEvent.busName;
						if (text == "[None]")
						{
							text = null;
						}
						MasterAudio.RouteGroupToBus(sType, text);
						break;
					}
					case MasterAudio.SoundGroupCommand.GlideByPitch:
						switch (aEvent.glidePitchType)
						{
						case GlidePitchType.RaisePitch:
							MasterAudio.GlideSoundGroupByPitch(sType, aEvent.targetGlidePitch, aEvent.pitchGlideTime);
							break;
						case GlidePitchType.LowerPitch:
							MasterAudio.GlideSoundGroupByPitch(sType, 0f - aEvent.targetGlidePitch, aEvent.pitchGlideTime);
							break;
						}
						break;
					}
				}
				break;
			}
			case MasterAudio.EventSoundFunctionType.BusControl:
			{
				PlaySoundResult playSoundResult2 = new PlaySoundResult();
				playSoundResult2.ActingVariation = null;
				playSoundResult2.SoundPlayed = true;
				playSoundResult2.SoundScheduled = false;
				playSoundResult = playSoundResult2;
				List<string> list6 = new List<string>();
				if (!aEvent.allSoundTypesForBusCmd)
				{
					list6.Add(aEvent.busName);
				}
				else
				{
					list6.AddRange(MasterAudio.RuntimeBusNames);
				}
				for (int m = 0; m < list6.Count; m++)
				{
					string busName2 = list6[m];
					switch (aEvent.currentBusCommand)
					{
					case MasterAudio.BusCommand.None:
						playSoundResult.SoundPlayed = false;
						break;
					case MasterAudio.BusCommand.FadeToVolume:
					{
						float newVolume2 = ((!flag) ? aEvent.fadeVolume : grp.sliderValue);
						MasterAudio.FadeBusToVolume(busName2, newVolume2, aEvent.fadeTime, null, aEvent.stopAfterFade, aEvent.restoreVolumeAfterFade);
						break;
					}
					case MasterAudio.BusCommand.GlideByPitch:
						switch (aEvent.glidePitchType)
						{
						case GlidePitchType.RaisePitch:
							MasterAudio.GlideBusByPitch(busName2, aEvent.targetGlidePitch, aEvent.pitchGlideTime);
							break;
						case GlidePitchType.LowerPitch:
							MasterAudio.GlideBusByPitch(busName2, 0f - aEvent.targetGlidePitch, aEvent.pitchGlideTime);
							break;
						}
						break;
					case MasterAudio.BusCommand.Pause:
						MasterAudio.PauseBus(busName2);
						break;
					case MasterAudio.BusCommand.Stop:
						MasterAudio.StopBus(busName2);
						break;
					case MasterAudio.BusCommand.Unpause:
						MasterAudio.UnpauseBus(busName2);
						break;
					case MasterAudio.BusCommand.Mute:
						MasterAudio.MuteBus(busName2);
						break;
					case MasterAudio.BusCommand.Unmute:
						MasterAudio.UnmuteBus(busName2);
						break;
					case MasterAudio.BusCommand.ToggleMute:
						MasterAudio.ToggleMuteBus(busName2);
						break;
					case MasterAudio.BusCommand.Solo:
						MasterAudio.SoloBus(busName2);
						break;
					case MasterAudio.BusCommand.Unsolo:
						MasterAudio.UnsoloBus(busName2);
						break;
					case MasterAudio.BusCommand.ChangePitch:
						MasterAudio.ChangeBusPitch(busName2, aEvent.pitch);
						break;
					case MasterAudio.BusCommand.PauseBusOfTransform:
						MasterAudio.PauseBusOfTransform(_trans, aEvent.busName);
						break;
					case MasterAudio.BusCommand.UnpauseBusOfTransform:
						MasterAudio.UnpauseBusOfTransform(_trans, aEvent.busName);
						break;
					case MasterAudio.BusCommand.StopBusOfTransform:
						MasterAudio.StopBusOfTransform(_trans, aEvent.busName);
						break;
					}
				}
				break;
			}
			case MasterAudio.EventSoundFunctionType.CustomEventControl:
			{
				if (eType == EventType.UserDefinedEvent)
				{
					UnityEngine.Debug.LogError("Custom Event Receivers cannot fire events. Occured in Transform '" + base.name + "'.");
					break;
				}
				MasterAudio.CustomEventCommand currentCustomEventCommand = aEvent.currentCustomEventCommand;
				if (currentCustomEventCommand == MasterAudio.CustomEventCommand.FireEvent)
				{
					MasterAudio.FireCustomEvent(aEvent.theCustomEventName, _trans);
				}
				break;
			}
			case MasterAudio.EventSoundFunctionType.GlobalControl:
				switch (aEvent.currentGlobalCommand)
				{
				case MasterAudio.GlobalCommand.SetMasterMixerVolume:
				{
					float masterVolumeLevel = ((!flag) ? aEvent.volume : grp.sliderValue);
					MasterAudio.MasterVolumeLevel = masterVolumeLevel;
					break;
				}
				case MasterAudio.GlobalCommand.SetMasterPlaylistVolume:
				{
					float playlistMasterVolume = ((!flag) ? aEvent.volume : grp.sliderValue);
					MasterAudio.PlaylistMasterVolume = playlistMasterVolume;
					break;
				}
				case MasterAudio.GlobalCommand.PauseMixer:
					MasterAudio.PauseMixer();
					break;
				case MasterAudio.GlobalCommand.UnpauseMixer:
					MasterAudio.UnpauseMixer();
					break;
				case MasterAudio.GlobalCommand.StopMixer:
					MasterAudio.StopMixer();
					break;
				case MasterAudio.GlobalCommand.MuteEverything:
					MasterAudio.MuteEverything();
					break;
				case MasterAudio.GlobalCommand.UnmuteEverything:
					MasterAudio.UnmuteEverything();
					break;
				case MasterAudio.GlobalCommand.PauseEverything:
					MasterAudio.PauseEverything();
					break;
				case MasterAudio.GlobalCommand.UnpauseEverything:
					MasterAudio.UnpauseEverything();
					break;
				case MasterAudio.GlobalCommand.StopEverything:
					MasterAudio.StopEverything();
					break;
				}
				break;
			case MasterAudio.EventSoundFunctionType.UnityMixerControl:
				switch (aEvent.currentMixerCommand)
				{
				case MasterAudio.UnityMixerCommand.TransitionToSnapshot:
				{
					AudioMixerSnapshot snapshotToTransitionTo = aEvent.snapshotToTransitionTo;
					if (snapshotToTransitionTo != null)
					{
						snapshotToTransitionTo.audioMixer.TransitionToSnapshots(new AudioMixerSnapshot[1] { snapshotToTransitionTo }, new float[1] { 1f }, aEvent.snapshotTransitionTime);
					}
					break;
				}
				case MasterAudio.UnityMixerCommand.TransitionToSnapshotBlend:
				{
					List<AudioMixerSnapshot> list3 = new List<AudioMixerSnapshot>();
					List<float> list4 = new List<float>();
					AudioMixer audioMixer = null;
					for (int k = 0; k < aEvent.snapshotsToBlend.Count; k++)
					{
						AudioEvent.MA_SnapshotInfo mA_SnapshotInfo = aEvent.snapshotsToBlend[k];
						if (!(mA_SnapshotInfo.snapshot == null))
						{
							if (audioMixer == null)
							{
								audioMixer = mA_SnapshotInfo.snapshot.audioMixer;
							}
							else if (audioMixer != mA_SnapshotInfo.snapshot.audioMixer)
							{
								UnityEngine.Debug.LogError("Snapshot '" + mA_SnapshotInfo.snapshot.name + "' isn't in the same Audio Mixer as the previous snapshot in EventSounds on GameObject '" + base.name + "'. Please make sure all the Snapshots to blend are on the same mixer.");
								break;
							}
							list3.Add(mA_SnapshotInfo.snapshot);
							list4.Add(mA_SnapshotInfo.weight);
						}
					}
					if (list3.Count > 0)
					{
						UnityEngine.Debug.Log("trans");
						audioMixer.TransitionToSnapshots(list3.ToArray(), list4.ToArray(), aEvent.snapshotTransitionTime);
					}
					break;
				}
				}
				break;
			case MasterAudio.EventSoundFunctionType.PersistentSettingsControl:
				switch (aEvent.currentPersistentSettingsCommand)
				{
				case MasterAudio.PersistentSettingsCommand.SetBusVolume:
				{
					List<string> list2 = new List<string>();
					if (!aEvent.allSoundTypesForBusCmd)
					{
						list2.Add(aEvent.busName);
					}
					else
					{
						list2.AddRange(MasterAudio.RuntimeBusNames);
					}
					for (int j = 0; j < list2.Count; j++)
					{
						string busName = list2[j];
						float vol2 = ((!flag) ? aEvent.volume : grp.sliderValue);
						PersistentAudioSettings.SetBusVolume(busName, vol2);
					}
					break;
				}
				case MasterAudio.PersistentSettingsCommand.SetGroupVolume:
				{
					List<string> list = new List<string>();
					if (!aEvent.allSoundTypesForGroupCmd)
					{
						list.Add(aEvent.soundType);
					}
					else
					{
						list.AddRange(MasterAudio.RuntimeSoundGroupNames);
					}
					for (int i = 0; i < list.Count; i++)
					{
						string grpName = list[i];
						float vol = ((!flag) ? aEvent.volume : grp.sliderValue);
						PersistentAudioSettings.SetGroupVolume(grpName, vol);
					}
					break;
				}
				case MasterAudio.PersistentSettingsCommand.SetMixerVolume:
				{
					float value2 = ((!flag) ? aEvent.volume : grp.sliderValue);
					PersistentAudioSettings.MixerVolume = value2;
					break;
				}
				case MasterAudio.PersistentSettingsCommand.SetMusicVolume:
				{
					float value = ((!flag) ? aEvent.volume : grp.sliderValue);
					PersistentAudioSettings.MusicVolume = value;
					break;
				}
				case MasterAudio.PersistentSettingsCommand.MixerMuteToggle:
					if (PersistentAudioSettings.MixerMuted.HasValue)
					{
						PersistentAudioSettings.MixerMuted = !PersistentAudioSettings.MixerMuted.Value;
					}
					else
					{
						PersistentAudioSettings.MixerMuted = true;
					}
					break;
				case MasterAudio.PersistentSettingsCommand.MusicMuteToggle:
					if (PersistentAudioSettings.MusicMuted.HasValue)
					{
						PersistentAudioSettings.MusicMuted = !PersistentAudioSettings.MusicMuted.Value;
					}
					else
					{
						PersistentAudioSettings.MusicMuted = true;
					}
					break;
				}
				break;
			}
		}

		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
			if (!logMissingEvents || (eventGroup.isCustomEvent && (!eventGroup.customSoundActive || string.IsNullOrEmpty(eventGroup.customEventName))))
			{
				return;
			}
			for (int i = 0; i < eventGroup.SoundEvents.Count; i++)
			{
				AudioEvent audioEvent = eventGroup.SoundEvents[i];
				if (audioEvent.currentSoundFunctionType == MasterAudio.EventSoundFunctionType.CustomEventControl)
				{
					string theCustomEventName = audioEvent.theCustomEventName;
					if (!MasterAudio.CustomEventExists(theCustomEventName))
					{
						MasterAudio.LogWarning("Transform '" + base.name + "' is set up to receive or fire Custom Event '" + theCustomEventName + "', which does not exist in Master Audio.");
					}
				}
			}
		}

		public void CheckForIllegalCustomEvents()
		{
			if (useStartSound)
			{
				LogIfCustomEventMissing(startSound);
			}
			if (useVisibleSound)
			{
				LogIfCustomEventMissing(visibleSound);
			}
			if (useInvisibleSound)
			{
				LogIfCustomEventMissing(invisibleSound);
			}
			if (useCollisionSound)
			{
				LogIfCustomEventMissing(collisionSound);
			}
			if (useCollisionExitSound)
			{
				LogIfCustomEventMissing(collisionExitSound);
			}
			if (useTriggerEnterSound)
			{
				LogIfCustomEventMissing(triggerSound);
			}
			if (useTriggerExitSound)
			{
				LogIfCustomEventMissing(triggerExitSound);
			}
			if (useMouseEnterSound)
			{
				LogIfCustomEventMissing(mouseEnterSound);
			}
			if (useMouseExitSound)
			{
				LogIfCustomEventMissing(mouseExitSound);
			}
			if (useMouseClickSound)
			{
				LogIfCustomEventMissing(mouseClickSound);
			}
			if (useMouseDragSound)
			{
				LogIfCustomEventMissing(mouseDragSound);
			}
			if (useMouseUpSound)
			{
				LogIfCustomEventMissing(mouseUpSound);
			}
			if (useNguiMouseDownSound)
			{
				LogIfCustomEventMissing(nguiMouseDownSound);
			}
			if (useNguiMouseUpSound)
			{
				LogIfCustomEventMissing(nguiMouseUpSound);
			}
			if (useNguiOnClickSound)
			{
				LogIfCustomEventMissing(nguiOnClickSound);
			}
			if (useNguiMouseEnterSound)
			{
				LogIfCustomEventMissing(nguiMouseEnterSound);
			}
			if (useNguiMouseExitSound)
			{
				LogIfCustomEventMissing(nguiMouseExitSound);
			}
			if (useSpawnedSound)
			{
				LogIfCustomEventMissing(spawnedSound);
			}
			if (useDespawnedSound)
			{
				LogIfCustomEventMissing(despawnedSound);
			}
			if (useEnableSound)
			{
				LogIfCustomEventMissing(enableSound);
			}
			if (useDisableSound)
			{
				LogIfCustomEventMissing(disableSound);
			}
			if (useCollision2dSound)
			{
				LogIfCustomEventMissing(collision2dSound);
			}
			if (useCollisionExit2dSound)
			{
				LogIfCustomEventMissing(collisionExit2dSound);
			}
			if (useTriggerEnter2dSound)
			{
				LogIfCustomEventMissing(triggerEnter2dSound);
			}
			if (useTriggerExit2dSound)
			{
				LogIfCustomEventMissing(triggerExit2dSound);
			}
			if (useParticleCollisionSound)
			{
				LogIfCustomEventMissing(particleCollisionSound);
			}
			if (useUnitySliderChangedSound)
			{
				LogIfCustomEventMissing(unitySliderChangedSound);
			}
			if (useUnityButtonClickedSound)
			{
				LogIfCustomEventMissing(unityButtonClickedSound);
			}
			if (useUnityPointerDownSound)
			{
				LogIfCustomEventMissing(unityPointerDownSound);
			}
			if (useUnityDragSound)
			{
				LogIfCustomEventMissing(unityDragSound);
			}
			if (useUnityDropSound)
			{
				LogIfCustomEventMissing(unityDropSound);
			}
			if (useUnityPointerUpSound)
			{
				LogIfCustomEventMissing(unityPointerUpSound);
			}
			if (useUnityPointerEnterSound)
			{
				LogIfCustomEventMissing(unityPointerEnterSound);
			}
			if (useUnityPointerExitSound)
			{
				LogIfCustomEventMissing(unityPointerExitSound);
			}
			if (useUnityScrollSound)
			{
				LogIfCustomEventMissing(unityScrollSound);
			}
			if (useUnityUpdateSelectedSound)
			{
				LogIfCustomEventMissing(unityUpdateSelectedSound);
			}
			if (useUnitySelectSound)
			{
				LogIfCustomEventMissing(unitySelectSound);
			}
			if (useUnityDeselectSound)
			{
				LogIfCustomEventMissing(unityDeselectSound);
			}
			if (useUnityMoveSound)
			{
				LogIfCustomEventMissing(unityMoveSound);
			}
			if (useUnityInitializePotentialDragSound)
			{
				LogIfCustomEventMissing(unityInitializePotentialDragSound);
			}
			if (useUnityBeginDragSound)
			{
				LogIfCustomEventMissing(unityBeginDragSound);
			}
			if (useUnityEndDragSound)
			{
				LogIfCustomEventMissing(unityEndDragSound);
			}
			if (useUnitySubmitSound)
			{
				LogIfCustomEventMissing(unitySubmitSound);
			}
			if (useUnityCancelSound)
			{
				LogIfCustomEventMissing(unityCancelSound);
			}
			for (int i = 0; i < userDefinedSounds.Count; i++)
			{
				AudioEventGroup eventGroup = userDefinedSounds[i];
				LogIfCustomEventMissing(eventGroup);
			}
		}

		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
			for (int i = 0; i < userDefinedSounds.Count; i++)
			{
				AudioEventGroup audioEventGroup = userDefinedSounds[i];
				if (audioEventGroup.customSoundActive && !string.IsNullOrEmpty(audioEventGroup.customEventName) && audioEventGroup.customEventName.Equals(customEventName))
				{
					PlaySounds(audioEventGroup, EventType.UserDefinedEvent);
				}
			}
		}

		public bool SubscribesToEvent(string customEventName)
		{
			for (int i = 0; i < userDefinedSounds.Count; i++)
			{
				AudioEventGroup audioEventGroup = userDefinedSounds[i];
				if (audioEventGroup.customSoundActive && !string.IsNullOrEmpty(audioEventGroup.customEventName) && audioEventGroup.customEventName.Equals(customEventName))
				{
					return true;
				}
			}
			return false;
		}

		public void RegisterReceiver()
		{
			if (userDefinedSounds.Count > 0)
			{
				MasterAudio.AddCustomEventReceiver(this, _trans);
			}
		}

		public void UnregisterReceiver()
		{
			if (userDefinedSounds.Count > 0)
			{
				MasterAudio.RemoveCustomEventReceiver(this);
			}
		}

		public IList<AudioEventGroup> GetAllEvents()
		{
			return userDefinedSounds.AsReadOnly();
		}

		private void AddUGUIComponents()
		{
			AddUGUIHandler<EventSoundsPointerEnterHandler>(useUnityPointerEnterSound);
			AddUGUIHandler<EventSoundsPointerExitHandler>(useUnityPointerExitSound);
			AddUGUIHandler<EventSoundsPointerDownHandler>(useUnityPointerDownSound);
			AddUGUIHandler<EventSoundsPointerUpHandler>(useUnityPointerUpSound);
			AddUGUIHandler<EventSoundsDragHandler>(useUnityDragSound);
			AddUGUIHandler<EventSoundsDropHandler>(useUnityDropSound);
			AddUGUIHandler<EventSoundsScrollHandler>(useUnityScrollSound);
			AddUGUIHandler<EventSoundsUpdateSelectedHandler>(useUnityUpdateSelectedSound);
			AddUGUIHandler<EventSoundsSelectHandler>(useUnitySelectSound);
			AddUGUIHandler<EventSoundsDeselectHandler>(useUnityDeselectSound);
			AddUGUIHandler<EventSoundsMoveHandler>(useUnityMoveSound);
			AddUGUIHandler<EventSoundsInitializePotentialDragHandler>(useUnityInitializePotentialDragSound);
			AddUGUIHandler<EventSoundsBeginDragHandler>(useUnityBeginDragSound);
			AddUGUIHandler<EventSoundsEndDragHandler>(useUnityEndDragSound);
			AddUGUIHandler<EventSoundsSubmitHandler>(useUnitySubmitSound);
			AddUGUIHandler<EventSoundsCancelHandler>(useUnityCancelSound);
		}

		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
			if (useSound)
			{
				T val = base.gameObject.AddComponent<T>();
				val.eventSounds = this;
			}
		}
	}
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		public EventSounds eventSounds { get; set; }
	}
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		public void OnPointerEnter(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnPointerEnter(data);
			}
		}
	}
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		public void OnPointerExit(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnPointerExit(data);
			}
		}
	}
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		public void OnPointerDown(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnPointerDown(data);
			}
		}
	}
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		public void OnPointerUp(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnPointerUp(data);
			}
		}
	}
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		public void OnDrag(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnDrag(data);
			}
		}
	}
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		public void OnDrop(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnDrop(data);
			}
		}
	}
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		public void OnScroll(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnScroll(data);
			}
		}
	}
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		public void OnUpdateSelected(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnUpdateSelected(data);
			}
		}
	}
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		public void OnSelect(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnSelect(data);
			}
		}
	}
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		public void OnDeselect(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnDeselect(data);
			}
		}
	}
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		public void OnMove(AxisEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnMove(data);
			}
		}
	}
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		public void OnInitializePotentialDrag(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnInitializePotentialDrag(data);
			}
		}
	}
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		public void OnBeginDrag(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnBeginDrag(data);
			}
		}
	}
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		public void OnEndDrag(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnEndDrag(data);
			}
		}
	}
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		public void OnSubmit(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnSubmit(data);
			}
		}
	}
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		public void OnCancel(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnCancel(data);
			}
		}
	}
	[AddComponentMenu("Dark Tonic/Master Audio/Footstep Sounds")]
	public class FootstepSounds : MonoBehaviour
	{
		public enum FootstepTriggerMode
		{
			None,
			OnCollision,
			OnTriggerEnter,
			OnCollision2D,
			OnTriggerEnter2D
		}

		public MasterAudio.SoundSpawnLocationMode soundSpawnMode = MasterAudio.SoundSpawnLocationMode.AttachToCaller;

		public FootstepTriggerMode footstepEvent;

		public List<FootstepGroup> footstepGroups = new List<FootstepGroup>();

		public EventSounds.RetriggerLimMode retriggerLimitMode;

		public int limitPerXFrm;

		public float limitPerXSec;

		public int triggeredLastFrame = -100;

		public float triggeredLastTime = -100f;

		private Transform _trans;

		private Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (footstepEvent == FootstepTriggerMode.OnTriggerEnter)
			{
				PlaySoundsIfMatch(other.gameObject);
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (footstepEvent == FootstepTriggerMode.OnCollision)
			{
				PlaySoundsIfMatch(collision.gameObject);
			}
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (footstepEvent == FootstepTriggerMode.OnCollision2D)
			{
				PlaySoundsIfMatch(collision.gameObject);
			}
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (footstepEvent == FootstepTriggerMode.OnTriggerEnter2D)
			{
				PlaySoundsIfMatch(other.gameObject);
			}
		}

		private bool CheckForRetriggerLimit()
		{
			switch (retriggerLimitMode)
			{
			case EventSounds.RetriggerLimMode.FrameBased:
				if (triggeredLastFrame > 0 && AudioUtil.FrameCount - triggeredLastFrame < limitPerXFrm)
				{
					return false;
				}
				break;
			case EventSounds.RetriggerLimMode.TimeBased:
				if (triggeredLastTime > 0f && AudioUtil.Time - triggeredLastTime < limitPerXSec)
				{
					return false;
				}
				break;
			}
			return true;
		}

		private void PlaySoundsIfMatch(GameObject go)
		{
			if (!CheckForRetriggerLimit())
			{
				return;
			}
			switch (retriggerLimitMode)
			{
			case EventSounds.RetriggerLimMode.FrameBased:
				triggeredLastFrame = AudioUtil.FrameCount;
				break;
			case EventSounds.RetriggerLimMode.TimeBased:
				triggeredLastTime = AudioUtil.Time;
				break;
			}
			for (int i = 0; i < footstepGroups.Count; i++)
			{
				FootstepGroup footstepGroup = footstepGroups[i];
				if ((!footstepGroup.useLayerFilter || footstepGroup.matchingLayers.Contains(go.layer)) && (!footstepGroup.useTagFilter || footstepGroup.matchingTags.Contains(go.tag)))
				{
					float volume = footstepGroup.volume;
					float? pitch = footstepGroup.pitch;
					if (!footstepGroup.useFixedPitch)
					{
						pitch = null;
					}
					string variationName = null;
					if (footstepGroup.variationType == EventSounds.VariationType.PlaySpecific)
					{
						variationName = footstepGroup.variationName;
					}
					switch (soundSpawnMode)
					{
					case MasterAudio.SoundSpawnLocationMode.CallerLocation:
						MasterAudio.PlaySound3DAtTransform(footstepGroup.soundType, Trans, volume, pitch, footstepGroup.delaySound, variationName);
						break;
					case MasterAudio.SoundSpawnLocationMode.AttachToCaller:
						MasterAudio.PlaySound3DFollowTransform(footstepGroup.soundType, Trans, volume, pitch, footstepGroup.delaySound, variationName);
						break;
					case MasterAudio.SoundSpawnLocationMode.MasterAudioLocation:
						MasterAudio.PlaySound(footstepGroup.soundType, volume, pitch, footstepGroup.delaySound, variationName);
						break;
					}
				}
			}
		}
	}
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Tooltip("Select for event to re-fire each time animation loops without exiting state")]
		[Header("Retrigger Events Each Time Anim Loops w/o Exiting State")]
		public bool RetriggerWhenStateLoops;

		[Tooltip("Fire A Custom Event When State Is Entered")]
		[Header("Enter Custom Event")]
		public bool fireEnterEvent;

		[MasterCustomEvent]
		public string enterCustomEvent = "[None]";

		[Tooltip("Fire a Custom Event when state is Exited")]
		[Header("Exit Custom Event")]
		public bool fireExitEvent;

		[MasterCustomEvent]
		public string exitCustomEvent = "[None]";

		[Tooltip("Fire a Custom Event timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.")]
		[Header("Fire Custom EventTimed to Animation")]
		public bool fireAnimTimeEvent;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireEvent;

		[MasterCustomEvent]
		public string timedCustomEvent = "[None]";

		[Tooltip("Fire a Custom Event with timed to the animation.  This allows you to time your Custom Events to the actions in you animation. Select the number of Custom Events to be fired, up to 4. Then set the time you want each Custom Event to fire with each subsequent time greater than the previous time.")]
		[Header("Fire Multiple Custom Events Timed to Anim")]
		public bool fireMultiAnimTimeEvent;

		[Range(0f, 4f)]
		public int numOfMultiEventsToFire;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent1;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent2;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent3;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent4;

		[MasterCustomEvent]
		public string MultiTimedEvent = "[None]";

		private bool _playMultiEvent1 = true;

		private bool _playMultiEvent2 = true;

		private bool _playMultiEvent3 = true;

		private bool _playMultiEvent4 = true;

		private bool _fireTimedEvent = true;

		private Transform _actorTrans;

		private int _lastRepetition = -1;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			_lastRepetition = 0;
			_actorTrans = ActorTrans(animator);
			if (fireEnterEvent && !(enterCustomEvent == "[None]") && !string.IsNullOrEmpty(enterCustomEvent))
			{
				MasterAudio.FireCustomEvent(enterCustomEvent, _actorTrans);
			}
		}

		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			int num = (int)stateInfo.normalizedTime;
			float num2 = stateInfo.normalizedTime - (float)num;
			if (fireAnimTimeEvent)
			{
				if (!_fireTimedEvent && RetriggerWhenStateLoops && _lastRepetition >= 0 && num > _lastRepetition)
				{
					_fireTimedEvent = true;
				}
				if (_fireTimedEvent && num2 > whenToFireEvent)
				{
					_fireTimedEvent = false;
					MasterAudio.FireCustomEvent(timedCustomEvent, _actorTrans);
				}
			}
			if (fireMultiAnimTimeEvent)
			{
				if (RetriggerWhenStateLoops)
				{
					if (!_playMultiEvent1 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						_playMultiEvent1 = true;
					}
					if (!_playMultiEvent2 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						_playMultiEvent2 = true;
					}
					if (!_playMultiEvent3 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						_playMultiEvent3 = true;
					}
					if (!_playMultiEvent4 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						_playMultiEvent4 = true;
					}
				}
				if (_playMultiEvent1 && !(num2 < whenToFireMultiEvent1) && numOfMultiEventsToFire >= 1)
				{
					_playMultiEvent1 = false;
					MasterAudio.FireCustomEvent(MultiTimedEvent, _actorTrans);
				}
				if (_playMultiEvent2 && !(num2 < whenToFireMultiEvent2) && numOfMultiEventsToFire >= 2)
				{
					_playMultiEvent2 = false;
					MasterAudio.FireCustomEvent(MultiTimedEvent, _actorTrans);
				}
				if (_playMultiEvent3 && !(num2 < whenToFireMultiEvent3) && numOfMultiEventsToFire >= 3)
				{
					_playMultiEvent3 = false;
					MasterAudio.FireCustomEvent(MultiTimedEvent, _actorTrans);
				}
				if (_playMultiEvent4 && !(num2 < whenToFireMultiEvent4) && numOfMultiEventsToFire >= 4)
				{
					_playMultiEvent4 = false;
					MasterAudio.FireCustomEvent(MultiTimedEvent, _actorTrans);
				}
			}
			_lastRepetition = num;
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if (fireExitEvent && exitCustomEvent != "[None]" && !string.IsNullOrEmpty(exitCustomEvent))
			{
				MasterAudio.FireCustomEvent(exitCustomEvent, _actorTrans);
			}
			if (fireMultiAnimTimeEvent)
			{
				_playMultiEvent1 = true;
				_playMultiEvent2 = true;
				_playMultiEvent3 = true;
				_playMultiEvent4 = true;
			}
			if (fireAnimTimeEvent)
			{
				_fireTimedEvent = true;
			}
		}

		private Transform ActorTrans(Animator anim)
		{
			if (_actorTrans != null)
			{
				return _actorTrans;
			}
			_actorTrans = anim.transform;
			return _actorTrans;
		}
	}
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Header("Select For Sounds To Follow Object")]
		public bool SoundFollowsObject;

		[Tooltip("Select for sounds to retrigger each time animation loops without exiting state")]
		[Header("Retrigger Sounds Each Time Anim Loops w/o Exiting State")]
		public bool RetriggerWhenStateLoops;

		[Tooltip("Play a Sound Group when state is Entered")]
		[Header("Enter Sound Group")]
		public bool playEnterSound;

		public bool stopEnterSoundOnExit;

		[SoundGroup]
		public string enterSoundGroup = "[None]";

		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string enterVariationName;

		private bool wasEnterSoundPlayed;

		[Tooltip("Play a Sound Group when state is Exited")]
		[Header("Exit Sound Group")]
		public bool playExitSound;

		[SoundGroup]
		public string exitSoundGroup = "[None]";

		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string exitVariationName;

		[Tooltip("Play a Sound Group (Normal or Looped Chain Variation Mode) timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.  Select a stop time greater than the start time or leave stop time equals to zero and select Stop Anim Time Sound On Exit.  This can be used for Looped Chain Sound Groups since you have to define a stop time.")]
		[Header("Play Sound Group Timed to Animation")]
		public bool playAnimTimeSound;

		public bool stopAnimTimeSoundOnExit;

		[Tooltip("If selected, When To Stop Sound (below) will be used. Otherwise the sound will not be stopped unless you have Stop Anim Time Sound On Exit selected above.")]
		public bool useStopTime;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartSound;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStopSound;

		[SoundGroup]
		public string TimedSoundGroup = "[None]";

		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string timedVariationName;

		private bool playSoundStart = true;

		private bool playSoundStop = true;

		[Tooltip("Play a Sound Group with each variation timed to the animation.  This allows you to time your sounds to the actions in you animation.  Example: A sword swing combo where you want swoosh soundsor character grunts timed to the acceleration phase of the sword swing.  Select the number of sounds to be played, up to 4.  Then set the time you want each sound to start with each subsequent time greater than the previous time.")]
		[Header("Play Multiple Sounds Timed to Anim")]
		public bool playMultiAnimTimeSounds;

		public bool StopMultiAnimTimeSoundsOnExit;

		[Range(0f, 4f)]
		public int numOfMultiSoundsToPlay;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound1;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound2;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound3;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound4;

		[SoundGroup]
		public string MultiSoundsTimedGroup = "[None]";

		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string multiTimedVariationName;

		private bool playMultiSound1 = true;

		private bool playMultiSound2 = true;

		private bool playMultiSound3 = true;

		private bool playMultiSound4 = true;

		private Transform _actorTrans;

		private int _lastRepetition = -1;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			_lastRepetition = 0;
			_actorTrans = ActorTrans(animator);
			if (!playEnterSound)
			{
				return;
			}
			string variationName = GetVariationName(enterVariationName);
			if (SoundFollowsObject)
			{
				if (variationName == null)
				{
					MasterAudio.PlaySound3DFollowTransformAndForget(enterSoundGroup, _actorTrans);
				}
				else
				{
					MasterAudio.PlaySound3DFollowTransformAndForget(enterSoundGroup, _actorTrans, 1f, null, 0f, variationName);
				}
			}
			else if (variationName == null)
			{
				MasterAudio.PlaySound3DAtTransformAndForget(enterSoundGroup, _actorTrans);
			}
			else
			{
				MasterAudio.PlaySound3DAtTransformAndForget(enterSoundGroup, _actorTrans, 1f, null, 0f, variationName);
			}
			wasEnterSoundPlayed = true;
		}

		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			int num = (int)stateInfo.normalizedTime;
			float num2 = stateInfo.normalizedTime - (float)num;
			if (playAnimTimeSound)
			{
				if (!playSoundStart && RetriggerWhenStateLoops && _lastRepetition >= 0 && num > _lastRepetition)
				{
					playSoundStart = true;
				}
				if (playSoundStart && num2 > whenToStartSound)
				{
					playSoundStart = false;
					if (useStopTime && whenToStopSound < whenToStartSound)
					{
						UnityEngine.Debug.LogError("Stop time must be greater than start time when Use Stop Time is selected.");
					}
					else
					{
						string variationName = GetVariationName(timedVariationName);
						if (SoundFollowsObject)
						{
							if (variationName == null)
							{
								MasterAudio.PlaySound3DFollowTransformAndForget(TimedSoundGroup, _actorTrans);
							}
							else
							{
								MasterAudio.PlaySound3DFollowTransformAndForget(TimedSoundGroup, _actorTrans, 1f, null, 0f, variationName);
							}
						}
						else if (variationName == null)
						{
							MasterAudio.PlaySound3DAtTransformAndForget(TimedSoundGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DAtTransformAndForget(TimedSoundGroup, _actorTrans, 1f, null, 0f, variationName);
						}
					}
				}
				if (useStopTime && playSoundStop && num2 > whenToStartSound && !stopAnimTimeSoundOnExit && num2 > whenToStopSound)
				{
					playSoundStop = false;
					MasterAudio.StopSoundGroupOfTransform(_actorTrans, TimedSoundGroup);
				}
			}
			if (playMultiAnimTimeSounds)
			{
				if (RetriggerWhenStateLoops)
				{
					if (!playMultiSound1 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						playMultiSound1 = true;
					}
					if (!playMultiSound2 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						playMultiSound2 = true;
					}
					if (!playMultiSound3 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						playMultiSound3 = true;
					}
					if (!playMultiSound4 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						playMultiSound4 = true;
					}
				}
				string variationName2 = GetVariationName(multiTimedVariationName);
				if (playMultiSound1 && num2 > whenToStartMultiSound1 && numOfMultiSoundsToPlay >= 1)
				{
					playMultiSound1 = false;
					if (SoundFollowsObject)
					{
						if (variationName2 == null)
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
						}
					}
					else if (variationName2 == null)
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
					}
				}
				if (playMultiSound2 && num2 > whenToStartMultiSound2 && numOfMultiSoundsToPlay >= 2)
				{
					playMultiSound2 = false;
					if (SoundFollowsObject)
					{
						if (variationName2 == null)
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
						}
					}
					else if (variationName2 == null)
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
					}
				}
				if (playMultiSound3 && num2 > whenToStartMultiSound3 && numOfMultiSoundsToPlay >= 3)
				{
					playMultiSound3 = false;
					if (SoundFollowsObject)
					{
						if (variationName2 == null)
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
						}
					}
					else if (variationName2 == null)
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
					}
				}
				if (playMultiSound4 && num2 > whenToStartMultiSound4 && numOfMultiSoundsToPlay >= 4)
				{
					playMultiSound4 = false;
					if (SoundFollowsObject)
					{
						if (variationName2 == null)
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
						}
					}
					else if (variationName2 == null)
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
					}
				}
			}
			_lastRepetition = num;
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if (wasEnterSoundPlayed && stopEnterSoundOnExit)
			{
				MasterAudio.StopSoundGroupOfTransform(_actorTrans, enterSoundGroup);
			}
			wasEnterSoundPlayed = false;
			if (playExitSound)
			{
				string variationName = GetVariationName(exitVariationName);
				if (SoundFollowsObject)
				{
					if (variationName == null)
					{
						MasterAudio.PlaySound3DFollowTransformAndForget(exitSoundGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DFollowTransformAndForget(exitSoundGroup, _actorTrans, 1f, null, 0f, variationName);
					}
				}
				else if (variationName == null)
				{
					MasterAudio.PlaySound3DAtTransformAndForget(exitSoundGroup, _actorTrans);
				}
				else
				{
					MasterAudio.PlaySound3DAtTransformAndForget(exitSoundGroup, _actorTrans, 1f, null, 0f, variationName);
				}
			}
			if (playAnimTimeSound)
			{
				if (stopAnimTimeSoundOnExit)
				{
					MasterAudio.StopSoundGroupOfTransform(_actorTrans, TimedSoundGroup);
				}
				playSoundStart = true;
				playSoundStop = true;
			}
			if (playMultiAnimTimeSounds)
			{
				if (StopMultiAnimTimeSoundsOnExit)
				{
					MasterAudio.StopSoundGroupOfTransform(_actorTrans, MultiSoundsTimedGroup);
				}
				playMultiSound1 = true;
				playMultiSound2 = true;
				playMultiSound3 = true;
				playMultiSound4 = true;
			}
		}

		private Transform ActorTrans(Animator anim)
		{
			if (_actorTrans != null)
			{
				return _actorTrans;
			}
			_actorTrans = anim.transform;
			return _actorTrans;
		}

		private static string GetVariationName(string varName)
		{
			if (string.IsNullOrEmpty(varName))
			{
				return null;
			}
			varName = varName.Trim();
			if (string.IsNullOrEmpty(varName))
			{
				return null;
			}
			return varName;
		}
	}
	[SerializeField]
	public class PlaySoundResult
	{
		public bool SoundPlayed { get; set; }

		public bool SoundScheduled { get; set; }

		public SoundGroupVariation ActingVariation { get; set; }

		public PlaySoundResult()
		{
			SoundPlayed = false;
			SoundScheduled = false;
			ActingVariation = null;
		}
	}
	[Serializable]
	public class AudioEvent
	{
		public enum TargetVolumeMode
		{
			UseSliderValue,
			UseSpecificValue
		}

		[Serializable]
		public class MA_SnapshotInfo
		{
			public AudioMixerSnapshot snapshot;

			public float weight;

			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
				snapshot = snap;
				weight = wt;
			}
		}

		public string actionName = "Your action name";

		public bool isExpanded = true;

		public string soundType = "[None]";

		public bool allPlaylistControllersForGroupCmd;

		public bool allSoundTypesForGroupCmd;

		public bool allSoundTypesForBusCmd;

		public float volume = 1f;

		public bool useFixedPitch;

		public float pitch = 1f;

		public EventSounds.GlidePitchType glidePitchType;

		public float targetGlidePitch = 1f;

		public float pitchGlideTime = 1f;

		public float delaySound;

		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		public MasterAudio.BusCommand currentBusCommand;

		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		public MasterAudio.GlobalCommand currentGlobalCommand;

		public MasterAudio.UnityMixerCommand currentMixerCommand;

		public AudioMixerSnapshot snapshotToTransitionTo;

		public float snapshotTransitionTime = 1f;

		public List<MA_SnapshotInfo> snapshotsToBlend = new List<MA_SnapshotInfo>
		{
			new MA_SnapshotInfo(null, 1f)
		};

		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		public string busName = string.Empty;

		public string playlistName = string.Empty;

		public string playlistControllerName = string.Empty;

		public bool startPlaylist = true;

		public float fadeVolume;

		public float fadeTime = 1f;

		public bool stopAfterFade;

		public bool restoreVolumeAfterFade;

		public TargetVolumeMode targetVolMode;

		public string clipName = "[None]";

		public EventSounds.VariationType variationType = EventSounds.VariationType.PlayRandom;

		public string variationName = string.Empty;

		public string theCustomEventName = string.Empty;

		public bool IsFadeCommand
		{
			get
			{
				if (currentSoundFunctionType == MasterAudio.EventSoundFunctionType.PlaylistControl && currentPlaylistCommand == MasterAudio.PlaylistCommand.FadeToVolume)
				{
					return true;
				}
				if (currentSoundFunctionType == MasterAudio.EventSoundFunctionType.BusControl && currentBusCommand == MasterAudio.BusCommand.FadeToVolume)
				{
					return true;
				}
				if (currentSoundFunctionType == MasterAudio.EventSoundFunctionType.GroupControl && (currentSoundGroupCommand == MasterAudio.SoundGroupCommand.FadeToVolume || currentSoundGroupCommand == MasterAudio.SoundGroupCommand.FadeOutAllOfSound || currentSoundGroupCommand == MasterAudio.SoundGroupCommand.FadeOutSoundGroupOfTransform))
				{
					return true;
				}
				return false;
			}
		}
	}
	[Serializable]
	public class AudioEventGroup
	{
		public bool isExpanded = true;

		public bool allPlayersShouldHear;

		public bool useLayerFilter;

		public bool useTagFilter;

		public List<int> matchingLayers = new List<int> { 0 };

		public List<string> matchingTags = new List<string> { "Default" };

		public bool customSoundActive;

		public bool isCustomEvent;

		public string customEventName = string.Empty;

		public bool mechanimEventActive;

		public bool isMechanimStateCheckEvent;

		public string mechanimStateName = string.Empty;

		public bool mechEventPlayedForState;

		public List<AudioEvent> SoundEvents = new List<AudioEvent>();

		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		public float mouseDragFadeOutTime = 1f;

		public EventSounds.RetriggerLimMode retriggerLimitMode;

		public int limitPerXFrm;

		public float limitPerXSec;

		public int triggeredLastFrame = -100;

		public float triggeredLastTime = -100f;

		public float triggerStayForTime;

		public bool doesTriggerStayRepeat = true;

		public float sliderValue;
	}
	public class AudioScriptOrder : Attribute
	{
		public int Order;

		public AudioScriptOrder(int order)
		{
			Order = order;
		}
	}
	[Serializable]
	public class BusFadeInfo
	{
		public string NameOfBus;

		public GroupBus ActingBus;

		public float StartVolume;

		public float TargetVolume;

		public float StartTime;

		public float CompletionTime;

		public bool IsActive = true;

		public bool WillStopGroupAfterFade;

		public bool WillResetVolumeAfterFade;

		public Action completionAction;
	}
	[Serializable]
	public class BusPitchGlideInfo
	{
		public string NameOfBus;

		public float CompletionTime;

		public bool IsActive = true;

		public List<SoundGroupVariation> GlidingVariations;

		public Action completionAction;
	}
	[Serializable]
	public class CustomEvent
	{
		public string EventName;

		public string ProspectiveName;

		public bool IsEditing;

		public bool eventExpanded = true;

		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		public float distanceThreshold = 1f;

		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		public int filterModeQty = 1;

		public bool isTemporary;

		public int frameLastFired = -1;

		public string categoryName = "[Uncategorized]";

		public CustomEvent(string eventName)
		{
			EventName = eventName;
			ProspectiveName = eventName;
		}
	}
	[Serializable]
	public class CustomEventCategory
	{
		public string CatName = "[Uncategorized]";

		public bool IsExpanded = true;

		public bool IsEditing;

		public bool IsTemporary;

		public string ProspectiveName = "[Uncategorized]";
	}
	[Serializable]
	public class CustomEventToFireInfo
	{
		public string eventName;

		public Transform eventOrigin;
	}
	[Serializable]
	public class DuckGroupInfo
	{
		public string soundType = "[None]";

		public float riseVolStart = 0.5f;

		public float unduckTime = 1f;

		public float duckedVolumeCut = -6f;

		public bool isTemporary;
	}
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Range(0f, 1f)]
		public int probabilityToPlay = 100;

		public bool useLocalization;

		public bool useRandomPitch;

		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		public float randomPitchMin;

		public float randomPitchMax;

		public bool useRandomVolume;

		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		public float randomVolumeMin;

		public float randomVolumeMax;

		public int weight = 1;

		public MasterAudio.AudioLocation audLocation;

		public string resourceFileName;

		public string internetFileUrl;

		public bool isExpanded = true;

		public bool isChecked = true;

		public bool useFades;

		public float fadeInTime;

		public float fadeOutTime;

		public bool useCustomLooping;

		public int minCustomLoops = 1;

		public int maxCustomLoops = 5;

		public bool useIntroSilence;

		public float introSilenceMin;

		public float introSilenceMax;

		public bool useRandomStartTime;

		public float randomStartMinPercent;

		public float randomStartMaxPercent = 100f;

		public float randomEndPercent = 100f;

		private AudioDistortionFilter _distFilter;

		private AudioEchoFilter _echoFilter;

		private AudioHighPassFilter _hpFilter;

		private AudioLowPassFilter _lpFilter;

		private AudioReverbFilter _reverbFilter;

		private AudioChorusFilter _chorusFilter;

		private DynamicSoundGroup _parentGroupScript;

		private Transform _trans;

		private AudioSource _aud;

		public AudioDistortionFilter DistortionFilter
		{
			get
			{
				if (_distFilter != null)
				{
					return _distFilter;
				}
				_distFilter = GetComponent<AudioDistortionFilter>();
				return _distFilter;
			}
		}

		public AudioReverbFilter ReverbFilter
		{
			get
			{
				if (_reverbFilter != null)
				{
					return _reverbFilter;
				}
				_reverbFilter = GetComponent<AudioReverbFilter>();
				return _reverbFilter;
			}
		}

		public AudioChorusFilter ChorusFilter
		{
			get
			{
				if (_chorusFilter != null)
				{
					return _chorusFilter;
				}
				_chorusFilter = GetComponent<AudioChorusFilter>();
				return _chorusFilter;
			}
		}

		public AudioEchoFilter EchoFilter
		{
			get
			{
				if (_echoFilter != null)
				{
					return _echoFilter;
				}
				_echoFilter = GetComponent<AudioEchoFilter>();
				return _echoFilter;
			}
		}

		public AudioLowPassFilter LowPassFilter
		{
			get
			{
				if (_lpFilter != null)
				{
					return _lpFilter;
				}
				_lpFilter = GetComponent<AudioLowPassFilter>();
				return _lpFilter;
			}
		}

		public AudioHighPassFilter HighPassFilter
		{
			get
			{
				if (_hpFilter != null)
				{
					return _hpFilter;
				}
				_hpFilter = GetComponent<AudioHighPassFilter>();
				return _hpFilter;
			}
		}

		public DynamicSoundGroup ParentGroup
		{
			get
			{
				if (_parentGroupScript == null)
				{
					_parentGroupScript = Trans.parent.GetComponent<DynamicSoundGroup>();
				}
				if (_parentGroupScript == null)
				{
					UnityEngine.Debug.LogError("The Group that Dynamic Sound Variation '" + base.name + "' is in does not have a DynamicSoundGroup script in it!");
				}
				return _parentGroupScript;
			}
		}

		public Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		public bool HasActiveFXFilter
		{
			get
			{
				if (HighPassFilter != null && HighPassFilter.enabled)
				{
					return true;
				}
				if (LowPassFilter != null && LowPassFilter.enabled)
				{
					return true;
				}
				if (ReverbFilter != null && ReverbFilter.enabled)
				{
					return true;
				}
				if (DistortionFilter != null && DistortionFilter.enabled)
				{
					return true;
				}
				if (EchoFilter != null && EchoFilter.enabled)
				{
					return true;
				}
				if (ChorusFilter != null && ChorusFilter.enabled)
				{
					return true;
				}
				return false;
			}
		}

		public AudioSource VarAudio
		{
			get
			{
				if (_aud != null)
				{
					return _aud;
				}
				_aud = GetComponent<AudioSource>();
				return _aud;
			}
		}
	}
	public class DynamicSoundGroup : MonoBehaviour
	{
		public GameObject variationTemplate;

		public bool alwaysHighestPriority;

		public float groupMasterVolume = 1f;

		public int retriggerPercentage = 50;

		public MasterAudioGroup.VariationSequence curVariationSequence;

		public bool useNoRepeatRefill = true;

		public bool useInactivePeriodPoolRefill;

		public float inactivePeriodSeconds = 5f;

		public MasterAudioGroup.VariationMode curVariationMode;

		public MasterAudio.AudioLocation bulkVariationMode;

		public float chainLoopDelayMin;

		public float chainLoopDelayMax;

		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		public int chainLoopNumLoops;

		public bool useDialogFadeOut;

		public float dialogFadeOutTime = 0.5f;

		public bool resourceClipsAllLoadAsync = true;

		public bool logSound;

		public bool soundPlayedEventActive;

		public string soundPlayedCustomEvent = string.Empty;

		public int busIndex = -1;

		public MasterAudio.ItemSpatialBlendType spatialBlendType = MasterAudio.ItemSpatialBlendType.ForceTo3D;

		public float spatialBlend = 1f;

		public string busName = string.Empty;

		public bool isExistingBus;

		public bool isCopiedFromDGSC;

		public MasterAudioGroup.LimitMode limitMode;

		public int limitPerXFrames = 1;

		public float minimumTimeBetween = 0.1f;

		public bool limitPolyphony;

		public int voiceLimitCount = 1;

		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior = MasterAudioGroup.TargetDespawnedBehavior.FadeOut;

		public float despawnFadeTime = 0.3f;

		public bool isUsingOcclusion;

		public bool willOcclusionOverrideRaycastOffset;

		public float occlusionRayCastOffset;

		public bool willOcclusionOverrideFrequencies;

		public float occlusionMaxCutoffFreq;

		public float occlusionMinCutoffFreq = 22000f;

		public bool copySettingsExpanded;

		public int selectedVariationIndex;

		public bool expandLinkedGroups;

		public List<string> childSoundGroups = new List<string>();

		public List<string> endLinkedGroups = new List<string>();

		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		public List<DynamicGroupVariation> groupVariations = new List<DynamicGroupVariation>();
	}
	[Serializable]
	public class FootstepGroup
	{
		public bool isExpanded = true;

		public bool useLayerFilter;

		public bool useTagFilter;

		public List<int> matchingLayers = new List<int> { 0 };

		public List<string> matchingTags = new List<string> { "Default" };

		public string soundType = "[None]";

		public EventSounds.VariationType variationType = EventSounds.VariationType.PlayRandom;

		public string variationName = string.Empty;

		public float volume = 1f;

		public bool useFixedPitch;

		public float pitch = 1f;

		public float delaySound;
	}
	[Serializable]
	public class GroupBus
	{
		public string busName;

		public float volume = 1f;

		public bool isSoloed;

		public bool isMuted;

		public int voiceLimit = -1;

		public bool stopOldest;

		public bool isExisting;

		public bool isTemporary;

		public bool isUsingOcclusion;

		public AudioMixerGroup mixerChannel;

		public bool forceTo2D;

		private readonly List<int> _activeAudioSourcesIds = new List<int>(50);

		private float _originalVolume = 1f;

		public int ActiveVoices => _activeAudioSourcesIds.Count;

		public bool BusVoiceLimitReached
		{
			get
			{
				if (voiceLimit <= 0)
				{
					return false;
				}
				return _activeAudioSourcesIds.Count >= voiceLimit;
			}
		}

		public float OriginalVolume
		{
			get
			{
				return _originalVolume;
			}
			set
			{
				_originalVolume = value;
			}
		}

		public void AddActiveAudioSourceId(int id)
		{
			if (!_activeAudioSourcesIds.Contains(id))
			{
				_activeAudioSourcesIds.Add(id);
			}
		}

		public void RemoveActiveAudioSourceId(int id)
		{
			_activeAudioSourcesIds.Remove(id);
		}
	}
	[Serializable]
	public class GroupFadeInfo
	{
		public MasterAudioGroup ActingGroup;

		public string NameOfGroup;

		public float StartVolume;

		public float TargetVolume;

		public float StartTime;

		public float CompletionTime;

		public bool IsActive = true;

		public bool WillStopGroupAfterFade;

		public bool WillResetVolumeAfterFade;

		public Action completionAction;
	}
	[Serializable]
	public class GroupPitchGlideInfo
	{
		public MasterAudioGroup ActingGroup;

		public string NameOfGroup;

		public float CompletionTime;

		public bool IsActive = true;

		public List<SoundGroupVariation> GlidingVariations;

		public Action completionAction;
	}
	public interface ICustomEventReceiver
	{
		void CheckForIllegalCustomEvents();

		void ReceiveEvent(string customEventName, Vector3 originPoint);

		bool SubscribesToEvent(string customEventName);

		void RegisterReceiver();

		void UnregisterReceiver();

		IList<AudioEventGroup> GetAllEvents();
	}
	public class MasterAudioGroup : MonoBehaviour
	{
		public enum TargetDespawnedBehavior
		{
			None,
			Stop,
			FadeOut
		}

		public enum VariationSequence
		{
			Randomized,
			TopToBottom
		}

		public enum VariationMode
		{
			Normal,
			LoopedChain,
			Dialog
		}

		public enum ChainedLoopLoopMode
		{
			Endless,
			NumberOfLoops
		}

		public enum LimitMode
		{
			None,
			FrameBased,
			TimeBased
		}

		public const float UseCurveSpatialBlend = -99f;

		public const string NoBus = "[NO BUS]";

		public const int MinNoRepeatVariations = 3;

		public int busIndex = -1;

		public MasterAudio.ItemSpatialBlendType spatialBlendType = MasterAudio.ItemSpatialBlendType.ForceTo3D;

		public float spatialBlend = 1f;

		public bool isSelected;

		public bool isExpanded = true;

		public float groupMasterVolume = 1f;

		public int retriggerPercentage = 100;

		public VariationMode curVariationMode;

		public bool alwaysHighestPriority;

		public float chainLoopDelayMin;

		public float chainLoopDelayMax;

		public ChainedLoopLoopMode chainLoopMode;

		public int chainLoopNumLoops;

		public bool useDialogFadeOut;

		public float dialogFadeOutTime = 0.5f;

		public VariationSequence curVariationSequence;

		public bool useNoRepeatRefill = true;

		public bool useInactivePeriodPoolRefill;

		public float inactivePeriodSeconds = 5f;

		public List<SoundGroupVariation> groupVariations = new List<SoundGroupVariation>();

		public MasterAudio.AudioLocation bulkVariationMode;

		public bool resourceClipsAllLoadAsync = true;

		public bool logSound;

		public bool copySettingsExpanded;

		public int selectedVariationIndex;

		public bool expandLinkedGroups;

		public List<string> childSoundGroups = new List<string>();

		public List<string> endLinkedGroups = new List<string>();

		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		public LimitMode limitMode;

		public int limitPerXFrames = 1;

		public float minimumTimeBetween = 0.1f;

		public bool useClipAgePriority;

		public bool limitPolyphony;

		public int voiceLimitCount = 1;

		public TargetDespawnedBehavior targetDespawnedBehavior = TargetDespawnedBehavior.FadeOut;

		public float despawnFadeTime = 0.3f;

		public bool isUsingOcclusion;

		public bool willOcclusionOverrideRaycastOffset;

		public float occlusionRayCastOffset;

		public bool willOcclusionOverrideFrequencies;

		public float occlusionMaxCutoffFreq;

		public float occlusionMinCutoffFreq = 22000f;

		public bool isSoloed;

		public bool isMuted;

		public bool soundPlayedEventActive;

		public string soundPlayedCustomEvent = string.Empty;

		public bool willCleanUpDelegatesAfterStop = true;

		public int frames;

		private List<int> _activeAudioSourcesIds;

		private string _objectName = string.Empty;

		private Transform _trans;

		private float _originalVolume = 1f;

		public MasterAudio.InternetFileLoadStatus GroupLoadStatus
		{
			get
			{
				MasterAudio.InternetFileLoadStatus result = MasterAudio.InternetFileLoadStatus.Loaded;
				for (int i = 0; i < Trans.childCount; i++)
				{
					SoundGroupVariation component = Trans.GetChild(i).GetComponent<SoundGroupVariation>();
					if (component.audLocation == MasterAudio.AudioLocation.FileOnInternet)
					{
						if (component.internetFileLoadStatus == MasterAudio.InternetFileLoadStatus.Failed)
						{
							result = MasterAudio.InternetFileLoadStatus.Failed;
							break;
						}
						if (component.internetFileLoadStatus == MasterAudio.InternetFileLoadStatus.Loading)
						{
							result = MasterAudio.InternetFileLoadStatus.Loading;
						}
					}
				}
				return result;
			}
		}

		public float SpatialBlendForGroup => MasterAudio.Instance.mixerSpatialBlendType switch
		{
			MasterAudio.AllMixerSpatialBlendType.ForceAllTo2D => 0f, 
			MasterAudio.AllMixerSpatialBlendType.ForceAllTo3D => 1f, 
			MasterAudio.AllMixerSpatialBlendType.ForceAllToCustom => MasterAudio.Instance.mixerSpatialBlend, 
			_ => spatialBlendType switch
			{
				MasterAudio.ItemSpatialBlendType.ForceTo2D => 0f, 
				MasterAudio.ItemSpatialBlendType.ForceTo3D => 1f, 
				MasterAudio.ItemSpatialBlendType.ForceToCustom => spatialBlend, 
				_ => -99f, 
			}, 
		};

		public int ActiveVoices => ActiveAudioSourceIds.Count;

		public int TotalVoices => base.transform.childCount;

		public bool WillCleanUpDelegatesAfterStop
		{
			set
			{
				willCleanUpDelegatesAfterStop = value;
			}
		}

		public GroupBus BusForGroup
		{
			get
			{
				if (busIndex < 2)
				{
					return null;
				}
				int num = busIndex - 2;
				if (num >= MasterAudio.GroupBuses.Count)
				{
					return null;
				}
				return MasterAudio.GroupBuses[num];
			}
		}

		public float OriginalVolume
		{
			get
			{
				return _originalVolume;
			}
			set
			{
				_originalVolume = value;
			}
		}

		public bool LoggingEnabledForGroup => logSound || MasterAudio.LogSoundsEnabled;

		public int ChainLoopCount { get; set; }

		public string GameObjectName
		{
			get
			{
				if (string.IsNullOrEmpty(_objectName))
				{
					_objectName = base.name;
				}
				return _objectName;
			}
		}

		public bool UsesNoRepeat => curVariationSequence == VariationSequence.Randomized && groupVariations.Count >= 3 && useNoRepeatRefill;

		private Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		private List<int> ActiveAudioSourceIds
		{
			get
			{
				if (_activeAudioSourcesIds != null)
				{
					return _activeAudioSourcesIds;
				}
				_activeAudioSourcesIds = new List<int>(Trans.childCount);
				return _activeAudioSourcesIds;
			}
		}

		public event Action LastVariationFinishedPlay;

		private void Start()
		{
			_objectName = base.name;
			int count = ActiveAudioSourceIds.Count;
			if (count > 0)
			{
			}
			bool flag = false;
			if (Trans.parent != null)
			{
				base.gameObject.layer = Trans.parent.gameObject.layer;
			}
			for (int i = 0; i < Trans.childCount; i++)
			{
				SoundGroupVariation component = Trans.GetChild(i).GetComponent<SoundGroupVariation>();
				if (!(component == null))
				{
					SoundGroupVariationUpdater component2 = component.GetComponent<SoundGroupVariationUpdater>();
					if (!(component2 != null))
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				UnityEngine.Debug.LogError("One or more Variations of Sound Group '" + GameObjectName + "' do not have the SoundGroupVariationUpdater component and will not function properly. Please stop and fix this by opening the Master Audio Manager window and clicking the Upgrade MA Prefab button before continuing.");
			}
		}

		private void OnDisable()
		{
			for (int i = 0; i < Trans.childCount; i++)
			{
				SoundGroupVariation component = Trans.GetChild(i).GetComponent<SoundGroupVariation>();
				if (!(component == null) && component.audLocation == MasterAudio.AudioLocation.FileOnInternet)
				{
					AudioResourceOptimizer.RemoveLoadedInternetClip(component.internetFileUrl);
				}
			}
		}

		public void AddActiveAudioSourceId(int varInstanceId)
		{
			if (!ActiveAudioSourceIds.Contains(varInstanceId))
			{
				ActiveAudioSourceIds.Add(varInstanceId);
				BusForGroup?.AddActiveAudioSourceId(varInstanceId);
			}
		}

		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
			ActiveAudioSourceIds.Remove(varInstanceId);
			BusForGroup?.RemoveActiveAudioSourceId(varInstanceId);
		}

		public void FireLastVariationFinishedPlay()
		{
			if (this.LastVariationFinishedPlay != null)
			{
				this.LastVariationFinishedPlay();
			}
		}

		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
			this.LastVariationFinishedPlay = null;
			LastVariationFinishedPlay += finishedCallback;
		}

		public void UnsubscribeFromLastVariationFinishedPlay()
		{
			this.LastVariationFinishedPlay = null;
		}
	}
	public class MasterCustomEventAttribute : PropertyAttribute
	{
	}
	[Serializable]
	public class MusicSetting
	{
		public string alias = string.Empty;

		public MasterAudio.AudioLocation audLocation;

		public AudioClip clip;

		public string songName = string.Empty;

		public string resourceFileName = string.Empty;

		public float volume = 1f;

		public float pitch = 1f;

		public bool isExpanded = true;

		public bool isLoop;

		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		public float customStartTime;

		public float customStartTimeMax;

		public int lastKnownTimePoint;

		public bool wasLastKnownTimePointSet;

		public int songIndex;

		public bool songStartedEventExpanded;

		public string songStartedCustomEvent = string.Empty;

		public bool songChangedEventExpanded;

		public string songChangedCustomEvent = string.Empty;

		public float SongStartTime => songStartTimeMode switch
		{
			MasterAudio.CustomSongStartTimeMode.SpecificTime => customStartTime, 
			MasterAudio.CustomSongStartTimeMode.RandomTime => UnityEngine.Random.Range(customStartTime, customStartTimeMax), 
			_ => 0f, 
		};

		public MusicSetting()
		{
			songChangedEventExpanded = false;
		}

		public static MusicSetting Clone(MusicSetting mus)
		{
			MusicSetting musicSetting = new MusicSetting();
			musicSetting.alias = mus.alias;
			musicSetting.audLocation = mus.audLocation;
			musicSetting.clip = mus.clip;
			musicSetting.songName = mus.songName;
			musicSetting.resourceFileName = mus.resourceFileName;
			musicSetting.volume = mus.volume;
			musicSetting.pitch = mus.pitch;
			musicSetting.isExpanded = mus.isExpanded;
			musicSetting.isLoop = mus.isLoop;
			musicSetting.customStartTime = mus.customStartTime;
			musicSetting.songStartedEventExpanded = mus.songStartedEventExpanded;
			musicSetting.songStartedCustomEvent = mus.songStartedCustomEvent;
			musicSetting.songChangedEventExpanded = mus.songChangedEventExpanded;
			musicSetting.songChangedCustomEvent = mus.songChangedCustomEvent;
			return musicSetting;
		}
	}
	[Serializable]
	public class OcclusionFreqChangeInfo
	{
		public SoundGroupVariation ActingVariation;

		public float StartFrequency;

		public float TargetFrequency;

		public float StartTime;

		public float CompletionTime;

		public bool IsActive = true;
	}
	public class SoundGroupAttribute : PropertyAttribute
	{
	}
	[AudioScriptOrder(-40)]
	[RequireComponent(typeof(SoundGroupVariationUpdater))]
	public class SoundGroupVariation : MonoBehaviour
	{
		public delegate void SoundFinishedEventHandler();

		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		public class PlaySoundParams
		{
			public string SoundType;

			public float VolumePercentage;

			public float? Pitch;

			public double? TimeToSchedulePlay;

			public Transform SourceTrans;

			public bool AttachToSource;

			public float DelaySoundTime;

			public bool IsChainLoop;

			public bool IsSingleSubscribedPlay;

			public float GroupCalcVolume;

			public bool IsPlaying;

			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
				SoundType = soundType;
				VolumePercentage = volPercent;
				GroupCalcVolume = groupCalcVolume;
				Pitch = pitch;
				SourceTrans = sourceTrans;
				AttachToSource = attach;
				DelaySoundTime = delaySoundTime;
				TimeToSchedulePlay = timeToSchedulePlay;
				IsChainLoop = isChainLoop;
				IsSingleSubscribedPlay = isSingleSubscribedPlay;
				IsPlaying = false;
			}
		}

		public enum PitchMode
		{
			None,
			Gliding
		}

		public enum FadeMode
		{
			None,
			FadeInOut,
			FadeOutEarly,
			GradualFade
		}

		public enum RandomPitchMode
		{
			AddToClipPitch,
			IgnoreClipPitch
		}

		public enum RandomVolumeMode
		{
			AddToClipVolume,
			IgnoreClipVolume
		}

		public enum DetectEndMode
		{
			None,
			DetectEnd
		}

		public int weight = 1;

		[Range(0f, 1f)]
		public int probabilityToPlay = 100;

		public bool useLocalization;

		public bool useRandomPitch;

		public RandomPitchMode randomPitchMode;

		public float randomPitchMin;

		public float randomPitchMax;

		public bool useRandomVolume;

		public RandomVolumeMode randomVolumeMode;

		public float randomVolumeMin;

		public float randomVolumeMax;

		public MasterAudio.AudioLocation audLocation;

		public string resourceFileName;

		public string internetFileUrl;

		public MasterAudio.InternetFileLoadStatus internetFileLoadStatus;

		public float original_pitch;

		public float original_volume;

		public bool isExpanded = true;

		public bool isChecked = true;

		public bool useFades;

		public float fadeInTime;

		public float fadeOutTime;

		public bool useCustomLooping;

		public int minCustomLoops = 1;

		public int maxCustomLoops = 5;

		public bool useRandomStartTime;

		public float randomStartMinPercent;

		public float randomStartMaxPercent = 100f;

		public float randomEndPercent = 100f;

		public bool useIntroSilence;

		public float introSilenceMin;

		public float introSilenceMax;

		public float fadeMaxVolume;

		public FadeMode curFadeMode;

		public PitchMode curPitchMode;

		public DetectEndMode curDetectEndMode;

		public int frames;

		private AudioSource _audioSource;

		private readonly PlaySoundParams _playSndParam = new PlaySoundParams(string.Empty, 1f, 1f, 1f, null, attach: false, 0f, null, isChainLoop: false, isSingleSubscribedPlay: false);

		private AudioDistortionFilter _distFilter;

		private AudioEchoFilter _echoFilter;

		private AudioHighPassFilter _hpFilter;

		private AudioLowPassFilter _lpFilter;

		private AudioReverbFilter _reverbFilter;

		private AudioChorusFilter _chorusFilter;

		private float _maxVol = 1f;

		private int _instanceId = -1;

		private bool? _audioLoops;

		private int _maxLoops;

		private SoundGroupVariationUpdater _varUpdater;

		private int _previousSoundFinishedFrame = -1;

		private string _soundGroupName;

		private Transform _trans;

		private GameObject _go;

		private Transform _objectToFollow;

		private Transform _objectToTriggerFrom;

		private MasterAudioGroup _parentGroupScript;

		private bool _attachToSource;

		private string _resFileName = string.Empty;

		private bool _hasStartedEndLinkedGroups;

		public AudioDistortionFilter DistortionFilter
		{
			get
			{
				if (_distFilter != null)
				{
					return _distFilter;
				}
				_distFilter = GetComponent<AudioDistortionFilter>();
				return _distFilter;
			}
		}

		public AudioReverbFilter ReverbFilter
		{
			get
			{
				if (_reverbFilter != null)
				{
					return _reverbFilter;
				}
				_reverbFilter = GetComponent<AudioReverbFilter>();
				return _reverbFilter;
			}
		}

		public AudioChorusFilter ChorusFilter
		{
			get
			{
				if (_chorusFilter != null)
				{
					return _chorusFilter;
				}
				_chorusFilter = GetComponent<AudioChorusFilter>();
				return _chorusFilter;
			}
		}

		public AudioEchoFilter EchoFilter
		{
			get
			{
				if (_echoFilter != null)
				{
					return _echoFilter;
				}
				_echoFilter = GetComponent<AudioEchoFilter>();
				return _echoFilter;
			}
		}

		public AudioLowPassFilter LowPassFilter
		{
			get
			{
				return _lpFilter;
			}
			set
			{
				_lpFilter = value;
			}
		}

		public AudioHighPassFilter HighPassFilter
		{
			get
			{
				if (_hpFilter != null)
				{
					return _hpFilter;
				}
				_hpFilter = GetComponent<AudioHighPassFilter>();
				return _hpFilter;
			}
		}

		public Transform ObjectToFollow
		{
			get
			{
				return _objectToFollow;
			}
			set
			{
				_objectToFollow = value;
				UpdateTransformTracker(value);
			}
		}

		public Transform ObjectToTriggerFrom
		{
			get
			{
				return _objectToTriggerFrom;
			}
			set
			{
				_objectToTriggerFrom = value;
				UpdateTransformTracker(value);
			}
		}

		public bool HasActiveFXFilter
		{
			get
			{
				if (HighPassFilter != null && HighPassFilter.enabled)
				{
					return true;
				}
				if (LowPassFilter != null && LowPassFilter.enabled)
				{
					return true;
				}
				if (ReverbFilter != null && ReverbFilter.enabled)
				{
					return true;
				}
				if (DistortionFilter != null && DistortionFilter.enabled)
				{
					return true;
				}
				if (EchoFilter != null && EchoFilter.enabled)
				{
					return true;
				}
				if (ChorusFilter != null && ChorusFilter.enabled)
				{
					return true;
				}
				return false;
			}
		}

		public MasterAudioGroup ParentGroup
		{
			get
			{
				if (Trans.parent == null)
				{
					return null;
				}
				if (_parentGroupScript == null)
				{
					_parentGroupScript = Trans.parent.GetComponent<MasterAudioGroup>();
				}
				if (_parentGroupScript == null)
				{
					UnityEngine.Debug.LogError("The Group that Sound Variation '" + base.name + "' is in does not have a MasterAudioGroup script in it!");
				}
				return _parentGroupScript;
			}
		}

		public float OriginalPitch
		{
			get
			{
				if (original_pitch == 0f)
				{
					original_pitch = VarAudio.pitch;
				}
				return original_pitch;
			}
		}

		public float OriginalVolume
		{
			get
			{
				if (original_volume == 0f)
				{
					original_volume = VarAudio.volume;
				}
				return original_volume;
			}
		}

		public string SoundGroupName
		{
			get
			{
				if (_soundGroupName != null)
				{
					return _soundGroupName;
				}
				_soundGroupName = ParentGroup.GameObjectName;
				return _soundGroupName;
			}
		}

		public bool IsAvailableToPlay
		{
			get
			{
				if (weight == 0)
				{
					return false;
				}
				if (!_playSndParam.IsPlaying && VarAudio.time == 0f)
				{
					return true;
				}
				return AudioUtil.GetAudioPlayedPercentage(VarAudio) >= (float)ParentGroup.retriggerPercentage;
			}
		}

		public float LastTimePlayed { get; set; }

		public bool IsPlaying => _playSndParam.IsPlaying;

		public int InstanceId
		{
			get
			{
				if (_instanceId < 0)
				{
					_instanceId = GetInstanceID();
				}
				return _instanceId;
			}
		}

		public Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		public GameObject GameObj
		{
			get
			{
				if (_go != null)
				{
					return _go;
				}
				_go = base.gameObject;
				return _go;
			}
		}

		public AudioSource VarAudio
		{
			get
			{
				if (_audioSource != null)
				{
					return _audioSource;
				}
				_audioSource = GetComponent<AudioSource>();
				return _audioSource;
			}
		}

		public bool AudioLoops
		{
			get
			{
				if (!_audioLoops.HasValue)
				{
					_audioLoops = VarAudio.loop;
				}
				return _audioLoops.Value;
			}
		}

		public string ResFileName
		{
			get
			{
				if (string.IsNullOrEmpty(_resFileName))
				{
					_resFileName = AudioResourceOptimizer.GetLocalizedFileName(useLocalization, resourceFileName);
				}
				return _resFileName;
			}
		}

		public SoundGroupVariationUpdater VariationUpdater
		{
			get
			{
				if (_varUpdater != null)
				{
					return _varUpdater;
				}
				_varUpdater = GetComponent<SoundGroupVariationUpdater>();
				return _varUpdater;
			}
		}

		public PlaySoundParams PlaySoundParm => _playSndParam;

		public float SetGroupVolume
		{
			get
			{
				return _playSndParam.GroupCalcVolume;
			}
			set
			{
				_playSndParam.GroupCalcVolume = value;
			}
		}

		public int MaxLoops => _maxLoops;

		private bool Is2D => VarAudio.spatialBlend <= 0f;

		private bool ShouldLoadAsync
		{
			get
			{
				if (MasterAudio.Instance.resourceClipsAllLoadAsync)
				{
					return true;
				}
				return ParentGroup.resourceClipsAllLoadAsync;
			}
		}

		public bool UsesOcclusion
		{
			get
			{
				if (!VariationUpdater.MAThisFrame.useOcclusion)
				{
					return false;
				}
				if (Is2D)
				{
					return false;
				}
				MasterAudio.OcclusionSelectionType occlusionSelectType = VariationUpdater.MAThisFrame.occlusionSelectType;
				if (occlusionSelectType == MasterAudio.OcclusionSelectionType.AllGroups || occlusionSelectType != MasterAudio.OcclusionSelectionType.TurnOnPerBusOrGroup)
				{
					return true;
				}
				if (ParentGroup.isUsingOcclusion)
				{
					return true;
				}
				GroupBus busForGroup = ParentGroup.BusForGroup;
				if (busForGroup != null && busForGroup.isUsingOcclusion)
				{
					return true;
				}
				return false;
			}
		}

		public event SoundFinishedEventHandler SoundFinished;

		public event SoundLoopedEventHandler SoundLooped;

		private void Awake()
		{
			original_pitch = VarAudio.pitch;
			original_volume = VarAudio.volume;
			_audioLoops = VarAudio.loop;
			AudioClip clip = VarAudio.clip;
			GameObject gameObj = GameObj;
			if (clip != null || gameObj != null)
			{
			}
			if (VarAudio.playOnAwake)
			{
				UnityEngine.Debug.LogWarning("The 'Play on Awake' checkbox in the Audio Source for Sound Group '" + ParentGroup.name + "', Variation '" + base.name + "' is checked. This is not used in Master Audio and can lead to buggy behavior. Make sure to uncheck it before hitting Play next time. To play ambient sounds, use an EventSounds component and activate the Start event to play a Sound Group of your choice.");
			}
		}

		private void Start()
		{
			MasterAudioGroup parentGroup = ParentGroup;
			if (parentGroup == null)
			{
				UnityEngine.Debug.LogError("Sound Variation '" + base.name + "' has no parent!");
				return;
			}
			GameObj.layer = MasterAudio.Instance.gameObject.layer;
			MasterAudio.AudioLocation audioLocation = audLocation;
			if (audioLocation == MasterAudio.AudioLocation.FileOnInternet && internetFileLoadStatus == MasterAudio.InternetFileLoadStatus.Loading)
			{
				LoadInternetFile();
			}
			SetMixerGroup();
			SetSpatialBlend();
			SetPriority();
			SetOcclusion();
			SpatializerHelper.TurnOnSpatializerIfEnabled(VarAudio);
		}

		public void SetMixerGroup()
		{
			GroupBus busForGroup = ParentGroup.BusForGroup;
			if (busForGroup != null)
			{
				VarAudio.outputAudioMixerGroup = busForGroup.mixerChannel;
			}
			else
			{
				VarAudio.outputAudioMixerGroup = null;
			}
		}

		public void SetSpatialBlend()
		{
			float spatialBlendForGroup = ParentGroup.SpatialBlendForGroup;
			if (spatialBlendForGroup != -99f)
			{
				VarAudio.spatialBlend = spatialBlendForGroup;
			}
			GroupBus busForGroup = ParentGroup.BusForGroup;
			if (busForGroup != null && MasterAudio.Instance.mixerSpatialBlendType != 0 && busForGroup.forceTo2D)
			{
				VarAudio.spatialBlend = 0f;
			}
		}

		public void LoadInternetFile()
		{
			StartCoroutine(AudioResourceOptimizer.PopulateSourceWithInternetFile(internetFileUrl, this, InternetFileLoaded, InternetFileFailedToLoad));
		}

		private void SetOcclusion()
		{
			VariationUpdater.UpdateCachedObjects();
			if (!UsesOcclusion)
			{
				return;
			}
			if (LowPassFilter == null)
			{
				_lpFilter = GetComponent<AudioLowPassFilter>();
				if (_lpFilter == null)
				{
					_lpFilter = base.gameObject.AddComponent<AudioLowPassFilter>();
				}
			}
			else
			{
				_lpFilter = GetComponent<AudioLowPassFilter>();
			}
			LowPassFilter.cutoffFrequency = AudioUtil.MinCutoffFreq(VariationUpdater);
		}

		private void SetPriority()
		{
			if (MasterAudio.Instance.prioritizeOnDistance)
			{
				if (ParentGroup.alwaysHighestPriority)
				{
					AudioPrioritizer.Set2DSoundPriority(VarAudio);
				}
				else
				{
					AudioPrioritizer.SetSoundGroupInitialPriority(VarAudio);
				}
			}
		}

		public void DisableUpdater()
		{
			if (!(VariationUpdater == null))
			{
				VariationUpdater.enabled = false;
			}
		}

		private void OnDestroy()
		{
			StopSoundEarly();
		}

		private void OnDisable()
		{
			StopSoundEarly();
		}

		private void StopSoundEarly()
		{
			if (!MasterAudio.AppIsShuttingDown)
			{
				Stop();
			}
		}

		private void OnDrawGizmos()
		{
			if (MasterAudio.Instance.showGizmos && IsPlaying)
			{
				Gizmos.DrawIcon(base.transform.position, "MasterAudio/MasterAudio Icon.png", allowScaling: true);
			}
		}

		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
			if (!MasterAudio.IsWarming && audLocation == MasterAudio.AudioLocation.FileOnInternet)
			{
				switch (internetFileLoadStatus)
				{
				case MasterAudio.InternetFileLoadStatus.Loading:
					if (ParentGroup.LoggingEnabledForGroup)
					{
						MasterAudio.LogWarning("Cannot play Variation '" + base.name + "' because its Internet file has not been downloaded yet.");
					}
					return;
				case MasterAudio.InternetFileLoadStatus.Failed:
					if (ParentGroup.LoggingEnabledForGroup)
					{
						MasterAudio.LogWarning("Cannot play Variation '" + base.name + "' because its Internet file failed downloading.");
					}
					return;
				}
			}
			MaybeCleanupFinishedDelegate();
			_hasStartedEndLinkedGroups = false;
			SetPlaySoundParams(gameObjectName, volPercent, targetVol, targetPitch, sourceTrans, attach, delayTime, timeToSchedulePlay, isChaining, isSingleSubscribedPlay);
			SetPriority();
			if (MasterAudio.HasAsyncResourceLoaderFeature() && ShouldLoadAsync)
			{
				StopAllCoroutines();
			}
			if (pitch.HasValue)
			{
				VarAudio.pitch = pitch.Value;
			}
			else if (useRandomPitch)
			{
				float num = UnityEngine.Random.Range(randomPitchMin, randomPitchMax);
				if (randomPitchMode == RandomPitchMode.AddToClipPitch)
				{
					num += OriginalPitch;
				}
				VarAudio.pitch = num;
			}
			else
			{
				VarAudio.pitch = OriginalPitch;
			}
			SetSpatialBlend();
			curFadeMode = FadeMode.None;
			curPitchMode = PitchMode.None;
			curDetectEndMode = DetectEndMode.DetectEnd;
			_maxVol = maxVolume;
			if (maxCustomLoops == minCustomLoops)
			{
				_maxLoops = minCustomLoops;
			}
			else
			{
				_maxLoops = UnityEngine.Random.Range(minCustomLoops, maxCustomLoops + 1);
			}
			switch (audLocation)
			{
			case MasterAudio.AudioLocation.Clip:
				FinishSetupToPlay();
				break;
			case MasterAudio.AudioLocation.ResourceFile:
				if (MasterAudio.HasAsyncResourceLoaderFeature() && ShouldLoadAsync)
				{
					StartCoroutine(AudioResourceOptimizer.PopulateSourcesWithResourceClipAsync(ResFileName, this, FinishSetupToPlay, ResourceFailedToLoad));
				}
				else if (AudioResourceOptimizer.PopulateSourcesWithResourceClip(ResFileName, this))
				{
					FinishSetupToPlay();
				}
				break;
			case MasterAudio.AudioLocation.FileOnInternet:
				FinishSetupToPlay();
				break;
			}
		}

		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
			_playSndParam.SoundType = gameObjectName;
			_playSndParam.VolumePercentage = volPercent;
			_playSndParam.GroupCalcVolume = targetVol;
			_playSndParam.Pitch = targetPitch;
			_playSndParam.SourceTrans = sourceTrans;
			_playSndParam.AttachToSource = attach;
			_playSndParam.DelaySoundTime = delayTime;
			_playSndParam.TimeToSchedulePlay = timeToSchedulePlay;
			_playSndParam.IsChainLoop = isChaining || ParentGroup.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain;
			_playSndParam.IsSingleSubscribedPlay = isSingleSubscribedPlay;
			_playSndParam.IsPlaying = true;
		}

		private void InternetFileFailedToLoad()
		{
			internetFileLoadStatus = MasterAudio.InternetFileLoadStatus.Failed;
		}

		private void MaybeCleanupFinishedDelegate()
		{
			if (ParentGroup.willCleanUpDelegatesAfterStop)
			{
				ClearSubscribers();
			}
		}

		private void InternetFileLoaded()
		{
			if (ParentGroup.LoggingEnabledForGroup)
			{
				MasterAudio.LogWarning("Internet file: '" + internetFileUrl + "' loaded successfully.");
			}
			internetFileLoadStatus = MasterAudio.InternetFileLoadStatus.Loaded;
		}

		private void ResourceFailedToLoad()
		{
			Stop();
		}

		private void FinishSetupToPlay()
		{
			if ((VarAudio.isPlaying || !(VarAudio.time > 0f)) && useFades && (fadeInTime > 0f || fadeOutTime > 0f))
			{
				fadeMaxVolume = _maxVol;
				if (fadeInTime > 0f)
				{
					VarAudio.volume = 0f;
				}
				if (VariationUpdater != null)
				{
					EnableUpdater(waitForSoundFinish: false);
					VariationUpdater.FadeInOut();
				}
			}
			VarAudio.loop = AudioLoops;
			if (_playSndParam.IsPlaying && (_playSndParam.IsChainLoop || _playSndParam.IsSingleSubscribedPlay || useRandomStartTime))
			{
				VarAudio.loop = false;
			}
			if (!_playSndParam.IsPlaying)
			{
				return;
			}
			ParentGroup.AddActiveAudioSourceId(InstanceId);
			EnableUpdater();
			_attachToSource = false;
			bool flag = MasterAudio.Instance.prioritizeOnDistance && (MasterAudio.Instance.useClipAgePriority || ParentGroup.useClipAgePriority);
			if (_playSndParam.AttachToSource || flag)
			{
				_attachToSource = _playSndParam.AttachToSource;
				if (VariationUpdater != null)
				{
					VariationUpdater.FollowObject(_attachToSource, ObjectToFollow, flag);
				}
			}
		}

		public void JumpToTime(float timeToJumpTo)
		{
			if (_playSndParam.IsPlaying)
			{
				VarAudio.time = timeToJumpTo;
			}
		}

		public void GlideByPitch(float pitchAddition, float glideTime, Action completionCallback = null)
		{
			if (pitchAddition == 0f)
			{
				completionCallback?.Invoke();
				return;
			}
			float num = VarAudio.pitch + pitchAddition;
			if (num < -3f)
			{
				num = -3f;
			}
			if (num > 3f)
			{
				num = 3f;
			}
			if (!VarAudio.clip.IsClipReadyToPlay())
			{
				if (ParentGroup.LoggingEnabledForGroup)
				{
					MasterAudio.LogWarning("Cannot GlideToPitch Variation '" + base.name + "' because it is still loading.");
				}
			}
			else if (glideTime <= 0.1f)
			{
				if (VarAudio.pitch != num)
				{
					VarAudio.pitch = num;
				}
				completionCallback?.Invoke();
			}
			else if (VariationUpdater != null)
			{
				VariationUpdater.GlidePitch(num, glideTime, completionCallback);
			}
		}

		public void AdjustVolume(float volumePercentage)
		{
			if (!_playSndParam.IsPlaying)
			{
				return;
			}
			float volume = _playSndParam.GroupCalcVolume * volumePercentage;
			VarAudio.volume = volume;
			_playSndParam.VolumePercentage = volumePercentage;
			List<MasterAudio.AudioInfo> allVariationsOfGroup = MasterAudio.GetAllVariationsOfGroup(ParentGroup.name);
			for (int i = 0; i < allVariationsOfGroup.Count; i++)
			{
				MasterAudio.AudioInfo audioInfo = allVariationsOfGroup[i];
				if (!(audioInfo.Variation != this))
				{
					audioInfo.LastPercentageVolume = volumePercentage;
					break;
				}
			}
		}

		public void Pause()
		{
			if (!MasterAudio.Instance.resourceClipsPauseDoNotUnload)
			{
				switch (audLocation)
				{
				case MasterAudio.AudioLocation.ResourceFile:
					Stop();
					return;
				case MasterAudio.AudioLocation.Clip:
					if (!AudioUtil.AudioClipWillPreload(VarAudio.clip))
					{
						Stop();
						return;
					}
					break;
				}
			}
			VarAudio.Pause();
			if (VariationUpdater.enabled)
			{
				VariationUpdater.Pause();
			}
			curFadeMode = FadeMode.None;
			curPitchMode = PitchMode.None;
		}

		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
			EnableUpdater(waitForSoundFinish: false);
			SetPlaySoundParams(ParentGroup.GameObjectName, volumePercentage, volumePercentage, pitch, transActor, attach, 0f, null, isChaining: true, isSingleSubscribedPlay: false);
			VariationUpdater.MaybeChain();
			VariationUpdater.StopWaitingForFinish();
		}

		public void PlayEndLinkedGroups(double? timeToPlayClip = null)
		{
			if (MasterAudio.AppIsShuttingDown || MasterAudio.IsWarming || ParentGroup.endLinkedGroups.Count == 0 || _hasStartedEndLinkedGroups)
			{
				return;
			}
			_hasStartedEndLinkedGroups = true;
			if (VariationUpdater == null || VariationUpdater.FramesPlayed == 0)
			{
				return;
			}
			switch (ParentGroup.linkedStopGroupSelectionType)
			{
			case MasterAudio.LinkedGroupSelectionType.All:
			{
				for (int i = 0; i < ParentGroup.endLinkedGroups.Count; i++)
				{
					PlayEndLinkedGroup(ParentGroup.endLinkedGroups[i], timeToPlayClip);
				}
				break;
			}
			case MasterAudio.LinkedGroupSelectionType.OneAtRandom:
			{
				int index = UnityEngine.Random.Range(0, ParentGroup.endLinkedGroups.Count);
				PlayEndLinkedGroup(ParentGroup.endLinkedGroups[index], timeToPlayClip);
				break;
			}
			}
		}

		private void EnableUpdater(bool waitForSoundFinish = true)
		{
			if (VariationUpdater != null)
			{
				VariationUpdater.enabled = true;
				VariationUpdater.Initialize();
				if (waitForSoundFinish)
				{
					VariationUpdater.WaitForSoundFinish();
				}
			}
		}

		private void MaybeUnloadClip()
		{
			if (audLocation == MasterAudio.AudioLocation.ResourceFile)
			{
				AudioResourceOptimizer.UnloadClipIfUnused(_resFileName);
			}
			AudioUtil.UnloadNonPreloadedAudioData(VarAudio.clip, GameObj);
		}

		private void PlayEndLinkedGroup(string sType, double? timeToPlayClip = null)
		{
			if (_playSndParam.AttachToSource && _playSndParam.SourceTrans != null)
			{
				MasterAudio.PlaySound3DFollowTransformAndForget(sType, _playSndParam.SourceTrans, _playSndParam.VolumePercentage, _playSndParam.Pitch, 0f, null, timeToPlayClip);
			}
			else if (_playSndParam.SourceTrans != null)
			{
				MasterAudio.PlaySound3DAtTransformAndForget(sType, _playSndParam.SourceTrans, _playSndParam.VolumePercentage, _playSndParam.Pitch, 0f, null, timeToPlayClip);
			}
			else
			{
				MasterAudio.PlaySound3DAtVector3AndForget(sType, Trans.position, _playSndParam.VolumePercentage, _playSndParam.Pitch, 0f, null, timeToPlayClip);
			}
		}

		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
			bool flag = false;
			if (stopEndDetection && VariationUpdater != null)
			{
				VariationUpdater.StopWaitingForFinish();
				flag = true;
			}
			if (!skipLinked)
			{
				PlayEndLinkedGroups();
			}
			_objectToFollow = null;
			_objectToTriggerFrom = null;
			VarAudio.pitch = OriginalPitch;
			ParentGroup.RemoveActiveAudioSourceId(InstanceId);
			MasterAudio.StopTrackingOcclusionForSource(GameObj);
			VarAudio.Stop();
			VarAudio.time = 0f;
			if (VariationUpdater != null)
			{
				VariationUpdater.StopFollowing();
				VariationUpdater.StopFading();
				VariationUpdater.StopPitchGliding();
			}
			if (!flag && VariationUpdater != null)
			{
				VariationUpdater.StopWaitingForFinish();
			}
			_playSndParam.IsPlaying = false;
			if (this.SoundFinished != null)
			{
				bool flag2 = _previousSoundFinishedFrame == AudioUtil.FrameCount;
				_previousSoundFinishedFrame = AudioUtil.FrameCount;
				if (!flag2)
				{
					this.SoundFinished();
				}
				MaybeCleanupFinishedDelegate();
			}
			Trans.localPosition = Vector3.zero;
			MaybeUnloadClip();
		}

		public void FadeToVolume(float newVolume, float fadeTime)
		{
			if (newVolume < 0f || newVolume > 1f)
			{
				UnityEngine.Debug.LogError("Illegal volume passed to FadeToVolume: '" + newVolume + "'. Legal volumes are between 0 and 1.");
			}
			else if (!VarAudio.clip.IsClipReadyToPlay())
			{
				if (ParentGroup.LoggingEnabledForGroup)
				{
					MasterAudio.LogWarning("Cannot Fade Variation '" + base.name + "' because it is still loading.");
				}
			}
			else if (fadeTime <= 0.1f)
			{
				VarAudio.volume = newVolume;
				if (VarAudio.volume <= 0f)
				{
					Stop();
				}
			}
			else if (VariationUpdater != null)
			{
				VariationUpdater.FadeOverTimeToVolume(newVolume, fadeTime);
			}
		}

		public void FadeOutNow()
		{
			if (!MasterAudio.AppIsShuttingDown && IsPlaying && useFades && VariationUpdater != null)
			{
				VariationUpdater.FadeOutEarly(fadeOutTime);
			}
		}

		public void FadeOutNow(float fadeTime)
		{
			if (!MasterAudio.AppIsShuttingDown && IsPlaying && VariationUpdater != null)
			{
				VariationUpdater.FadeOutEarly(fadeTime);
			}
		}

		public bool WasTriggeredFromTransform(Transform trans)
		{
			if (ObjectToFollow == trans || ObjectToTriggerFrom == trans)
			{
				return true;
			}
			return false;
		}

		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			if (ObjectToFollow != null && transMap.Contains(ObjectToFollow))
			{
				return true;
			}
			if (ObjectToTriggerFrom != null && transMap.Contains(ObjectToTriggerFrom))
			{
				return true;
			}
			return false;
		}

		public void UpdateTransformTracker(Transform sourceTrans)
		{
			if (!(sourceTrans == null) && Application.isEditor && !MasterAudio.IsWarming && sourceTrans.GetComponent<AudioTransformTracker>() == null)
			{
				sourceTrans.gameObject.AddComponent<AudioTransformTracker>();
			}
		}

		public void SoundLoopStarted(int numberOfLoops)
		{
			if (this.SoundLooped != null)
			{
				this.SoundLooped(numberOfLoops);
			}
		}

		public void ClearSubscribers()
		{
			this.SoundFinished = null;
			this.SoundLooped = null;
		}
	}
	[AudioScriptOrder(-15)]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		private enum WaitForSoundFinishMode
		{
			None,
			Play,
			WaitForEnd,
			StopOrRepeat
		}

		private const float TimeEarlyToScheduleNextClip = 0.1f;

		private const float FakeNegativeFloatValue = -10f;

		private Transform _objectToFollow;

		private GameObject _objectToFollowGo;

		private bool _isFollowing;

		private SoundGroupVariation _variation;

		private float _priorityLastUpdated = -10f;

		private bool _useClipAgePriority;

		private WaitForSoundFinishMode _waitMode;

		private AudioSource _varAudio;

		private MasterAudioGroup _parentGrp;

		private Transform _trans;

		private int _frameNum = -1;

		private bool _inited;

		private float _fadeOutStartTime = -5f;

		private bool _fadeInOutWillFadeOut;

		private bool _hasFadeInOutSetMaxVolume;

		private float _fadeInOutInFactor;

		private float _fadeInOutOutFactor;

		private int _fadeOutEarlyTotalFrames;

		private float _fadeOutEarlyFrameVolChange;

		private int _fadeOutEarlyFrameNumber;

		private float _fadeOutEarlyOrigVol;

		private float _fadeToTargetFrameVolChange;

		private int _fadeToTargetFrameNumber;

		private float _fadeToTargetOrigVol;

		private int _fadeToTargetTotalFrames;

		private float _fadeToTargetVolume;

		private bool _fadeOutStarted;

		private float _lastFrameClipTime = -1f;

		private bool _isPlayingBackward;

		private int _pitchGlideToTargetTotalFrames;

		private float _pitchGlideToTargetFramePitchChange;

		private int _pitchGlideToTargetFrameNumber;

		private float _glideToTargetPitch;

		private float _glideToTargetOrigPitch;

		private Action _glideToPitchCompletionCallback;

		private bool _hasStartedNextInChain;

		private bool _isWaitingForQueuedOcclusionRay;

		private int _framesPlayed;

		private float? _clipStartPosition;

		private float? _clipEndPosition;

		private double? _clipSchedEndTime;

		private bool _hasScheduledNextClip;

		private bool _hasScheduledEndLinkedGroups;

		private int _lastFrameClipPosition = -1;

		private int _timesLooped;

		private bool _isPaused;

		private double _pauseTime;

		private static int _maCachedFromFrame = -1;

		private static MasterAudio _maThisFrame;

		private static Transform _listenerThisFrame;

		public float ClipStartPosition
		{
			get
			{
				if (_clipStartPosition.HasValue)
				{
					return _clipStartPosition.Value;
				}
				if (GrpVariation.useRandomStartTime)
				{
					_clipStartPosition = UnityEngine.Random.Range(GrpVariation.randomStartMinPercent, GrpVariation.randomStartMaxPercent) * 0.01f * VarAudio.clip.length;
				}
				else
				{
					_clipStartPosition = 0f;
				}
				return _clipStartPosition.Value;
			}
		}

		public float ClipEndPosition
		{
			get
			{
				if (_clipEndPosition.HasValue)
				{
					return _clipEndPosition.Value;
				}
				if (GrpVariation.useRandomStartTime)
				{
					_clipEndPosition = GrpVariation.randomEndPercent * 0.01f * VarAudio.clip.length;
				}
				else
				{
					_clipEndPosition = VarAudio.clip.length;
				}
				return _clipEndPosition.Value;
			}
		}

		public int FramesPlayed => _framesPlayed;

		public MasterAudio MAThisFrame => _maThisFrame;

		public float MaxOcclusionFreq
		{
			get
			{
				if (GrpVariation.UsesOcclusion && ParentGroup.willOcclusionOverrideFrequencies)
				{
					return ParentGroup.occlusionMaxCutoffFreq;
				}
				return _maThisFrame.occlusionMaxCutoffFreq;
			}
		}

		public float MinOcclusionFreq
		{
			get
			{
				if (GrpVariation.UsesOcclusion && ParentGroup.willOcclusionOverrideFrequencies)
				{
					return ParentGroup.occlusionMinCutoffFreq;
				}
				return _maThisFrame.occlusionMinCutoffFreq;
			}
		}

		private Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = GrpVariation.Trans;
				return _trans;
			}
		}

		private AudioSource VarAudio
		{
			get
			{
				if (_varAudio != null)
				{
					return _varAudio;
				}
				_varAudio = GrpVariation.VarAudio;
				return _varAudio;
			}
		}

		private MasterAudioGroup ParentGroup
		{
			get
			{
				if (_parentGrp != null)
				{
					return _parentGrp;
				}
				_parentGrp = GrpVariation.ParentGroup;
				return _parentGrp;
			}
		}

		private SoundGroupVariation GrpVariation
		{
			get
			{
				if (_variation != null)
				{
					return _variation;
				}
				_variation = GetComponent<SoundGroupVariation>();
				return _variation;
			}
		}

		private float RayCastOriginOffset
		{
			get
			{
				if (GrpVariation.UsesOcclusion && ParentGroup.willOcclusionOverrideRaycastOffset)
				{
					return ParentGroup.occlusionRayCastOffset;
				}
				return _maThisFrame.occlusionRayCastOffset;
			}
		}

		private bool IsOcclusionMeasuringPaused => _isWaitingForQueuedOcclusionRay || MasterAudio.IsOcclusionFreqencyTransitioning(GrpVariation);

		private bool HasEndLinkedGroups
		{
			get
			{
				if (GrpVariation.ParentGroup.endLinkedGroups.Count > 0)
				{
					return true;
				}
				return false;
			}
		}

		public void GlidePitch(float targetPitch, float glideTime, Action completionCallback = null)
		{
			GrpVariation.curPitchMode = SoundGroupVariation.PitchMode.Gliding;
			float num = targetPitch - VarAudio.pitch;
			_pitchGlideToTargetTotalFrames = (int)(glideTime / AudioUtil.FrameTime);
			_pitchGlideToTargetFramePitchChange = num / (float)_pitchGlideToTargetTotalFrames;
			_pitchGlideToTargetFrameNumber = 0;
			_glideToTargetPitch = targetPitch;
			_glideToTargetOrigPitch = VarAudio.pitch;
			_glideToPitchCompletionCallback = completionCallback;
		}

		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
			GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.GradualFade;
			float num = targetVolume - VarAudio.volume;
			float time = VarAudio.time;
			float clipEndPosition = ClipEndPosition;
			if (!VarAudio.loop && VarAudio.clip != null && fadeTime + time > clipEndPosition)
			{
				fadeTime = clipEndPosition - time;
			}
			_fadeToTargetTotalFrames = (int)(fadeTime / AudioUtil.FrameTime);
			_fadeToTargetFrameVolChange = num / (float)_fadeToTargetTotalFrames;
			_fadeToTargetFrameNumber = 0;
			_fadeToTargetOrigVol = VarAudio.volume;
			_fadeToTargetVolume = targetVolume;
		}

		public void FadeOutEarly(float fadeTime)
		{
			GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.FadeOutEarly;
			if (!VarAudio.loop && VarAudio.clip != null && VarAudio.time + fadeTime > ClipEndPosition)
			{
				fadeTime = ClipEndPosition - VarAudio.time;
			}
			float num = AudioUtil.FrameTime;
			if (num == 0f)
			{
				num = AudioUtil.FixedDeltaTime;
			}
			_fadeOutEarlyTotalFrames = (int)(fadeTime / num);
			_fadeOutEarlyFrameVolChange = (0f - VarAudio.volume) / (float)_fadeOutEarlyTotalFrames;
			_fadeOutEarlyFrameNumber = 0;
			_fadeOutEarlyOrigVol = VarAudio.volume;
		}

		public void Initialize()
		{
			if (!_inited)
			{
				_lastFrameClipPosition = -1;
				_timesLooped = 0;
				_isPaused = false;
				_pauseTime = -1.0;
				_clipStartPosition = null;
				_clipEndPosition = null;
				_clipSchedEndTime = null;
				_hasScheduledNextClip = false;
				_hasScheduledEndLinkedGroups = false;
				_inited = true;
			}
		}

		public void FadeInOut()
		{
			GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.FadeInOut;
			_fadeOutStartTime = ClipEndPosition - GrpVariation.fadeOutTime;
			if (GrpVariation.fadeInTime > 0f)
			{
				VarAudio.volume = 0f;
				_fadeInOutInFactor = GrpVariation.fadeMaxVolume / GrpVariation.fadeInTime;
			}
			else
			{
				_fadeInOutInFactor = 0f;
			}
			_fadeInOutWillFadeOut = GrpVariation.fadeOutTime > 0f && !VarAudio.loop;
			if (_fadeInOutWillFadeOut)
			{
				_fadeInOutOutFactor = GrpVariation.fadeMaxVolume / (ClipEndPosition - _fadeOutStartTime);
			}
			else
			{
				_fadeInOutOutFactor = 0f;
			}
		}

		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
			_isFollowing = follow;
			if (objToFollow != null)
			{
				_objectToFollow = objToFollow;
				_objectToFollowGo = objToFollow.gameObject;
			}
			_useClipAgePriority = clipAgePriority;
			UpdateCachedObjects();
			UpdateAudioLocationAndPriority(rePrioritize: false);
		}

		public void WaitForSoundFinish()
		{
			if (MasterAudio.IsWarming)
			{
				PlaySoundAndWait();
			}
			else
			{
				_waitMode = WaitForSoundFinishMode.Play;
			}
		}

		public void StopPitchGliding()
		{
			GrpVariation.curPitchMode = SoundGroupVariation.PitchMode.None;
			if (_glideToPitchCompletionCallback != null)
			{
				_glideToPitchCompletionCallback();
				_glideToPitchCompletionCallback = null;
			}
			DisableIfFinished();
		}

		public void StopFading()
		{
			GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.None;
			DisableIfFinished();
		}

		public void StopWaitingForFinish()
		{
			_waitMode = WaitForSoundFinishMode.None;
			GrpVariation.curDetectEndMode = SoundGroupVariation.DetectEndMode.None;
			DisableIfFinished();
		}

		public void StopFollowing()
		{
			_isFollowing = false;
			_useClipAgePriority = false;
			_objectToFollow = null;
			_objectToFollowGo = null;
			DisableIfFinished();
		}

		private void DisableIfFinished()
		{
			if (!_isFollowing && GrpVariation.curDetectEndMode != SoundGroupVariation.DetectEndMode.DetectEnd && GrpVariation.curFadeMode == SoundGroupVariation.FadeMode.None && GrpVariation.curPitchMode == SoundGroupVariation.PitchMode.None)
			{
				base.enabled = false;
			}
		}

		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
			if (_isFollowing && _objectToFollow != null)
			{
				Trans.position = _objectToFollow.position;
			}
			if (_maThisFrame.prioritizeOnDistance && rePrioritize && !ParentGroup.alwaysHighestPriority && !(Time.realtimeSinceStartup - _priorityLastUpdated <= MasterAudio.ReprioritizeTime))
			{
				AudioPrioritizer.Set3DPriority(GrpVariation, _useClipAgePriority);
				_priorityLastUpdated = AudioUtil.Time;
			}
		}

		private void ResetToNonOcclusionSetting()
		{
			AudioLowPassFilter lowPassFilter = GrpVariation.LowPassFilter;
			if (lowPassFilter != null)
			{
				lowPassFilter.cutoffFrequency = 22000f;
			}
		}

		private void UpdateOcclusion()
		{
			if (!GrpVariation.UsesOcclusion)
			{
				MasterAudio.StopTrackingOcclusionForSource(GrpVariation.GameObj);
				ResetToNonOcclusionSetting();
			}
			else if (!(_listenerThisFrame == null) && !IsOcclusionMeasuringPaused)
			{
				MasterAudio.AddToQueuedOcclusionRays(this);
				_isWaitingForQueuedOcclusionRay = true;
			}
		}

		private void DoneWithOcclusion()
		{
			_isWaitingForQueuedOcclusionRay = false;
			MasterAudio.RemoveFromOcclusionFrequencyTransitioning(GrpVariation);
		}

		public bool RayCastForOcclusion()
		{
			DoneWithOcclusion();
			Vector3 vector = Trans.position;
			float rayCastOriginOffset = RayCastOriginOffset;
			if (rayCastOriginOffset > 0f)
			{
				vector = Vector3.MoveTowards(vector, _listenerThisFrame.position, rayCastOriginOffset);
			}
			Vector3 vector2 = _listenerThisFrame.position - vector;
			float magnitude = vector2.magnitude;
			if (magnitude > VarAudio.maxDistance)
			{
				MasterAudio.AddToOcclusionOutOfRangeSources(GrpVariation.GameObj);
				ResetToNonOcclusionSetting();
				return false;
			}
			MasterAudio.AddToOcclusionInRangeSources(GrpVariation.GameObj);
			bool flag = _maThisFrame.occlusionRaycastMode == MasterAudio.RaycastMode.Physics2D;
			if (GrpVariation.LowPassFilter == null)
			{
				AudioLowPassFilter lowPassFilter = GrpVariation.gameObject.AddComponent<AudioLowPassFilter>();
				GrpVariation.LowPassFilter = lowPassFilter;
			}
			bool queriesStartInColliders = Physics2D.queriesStartInColliders;
			if (flag)
			{
				Physics2D.queriesStartInColliders = _maThisFrame.occlusionIncludeStartRaycast2DCollider;
			}
			bool flag2 = true;
			if (flag)
			{
				flag2 = Physics2D.queriesHitTriggers;
				Physics2D.queriesHitTriggers = _maThisFrame.occlusionRaycastsHitTriggers;
			}
			else
			{
				flag2 = Physics.queriesHitTriggers;
				Physics.queriesHitTriggers = _maThisFrame.occlusionRaycastsHitTriggers;
			}
			Vector3 vector3 = Vector3.zero;
			float? num = null;
			bool flag3 = false;
			if (_maThisFrame.occlusionUseLayerMask)
			{
				switch (_maThisFrame.occlusionRaycastMode)
				{
				case MasterAudio.RaycastMode.Physics3D:
				{
					if (Physics.Raycast(vector, vector2, out var hitInfo, magnitude, _maThisFrame.occlusionLayerMask.value))
					{
						flag3 = true;
						vector3 = hitInfo.point;
						num = hitInfo.distance;
					}
					break;
				}
				case MasterAudio.RaycastMode.Physics2D:
				{
					RaycastHit2D raycastHit2D = Physics2D.Raycast(vector, vector2, magnitude, _maThisFrame.occlusionLayerMask.value);
					if (raycastHit2D.transform != null)
					{
						flag3 = true;
						vector3 = raycastHit2D.point;
						num = raycastHit2D.distance;
					}
					break;
				}
				}
			}
			else
			{
				switch (_maThisFrame.occlusionRaycastMode)
				{
				case MasterAudio.RaycastMode.Physics3D:
				{
					if (Physics.Raycast(vector, vector2, out var hitInfo2, magnitude))
					{
						flag3 = true;
						vector3 = hitInfo2.point;
						num = hitInfo2.distance;
					}
					break;
				}
				case MasterAudio.RaycastMode.Physics2D:
				{
					RaycastHit2D raycastHit2D2 = Physics2D.Raycast(vector, vector2, magnitude);
					if (raycastHit2D2.transform != null)
					{
						flag3 = true;
						vector3 = raycastHit2D2.point;
						num = raycastHit2D2.distance;
					}
					break;
				}
				}
			}
			if (flag)
			{
				Physics2D.queriesStartInColliders = queriesStartInColliders;
				Physics2D.queriesHitTriggers = flag2;
			}
			else
			{
				Physics.queriesHitTriggers = flag2;
			}
			if (_maThisFrame.occlusionShowRaycasts)
			{
				Vector3 end = ((!flag3) ? _listenerThisFrame.position : vector3);
				Color color = ((!flag3) ? Color.green : Color.red);
				UnityEngine.Debug.DrawLine(vector, end, color, 0.1f);
			}
			if (!flag3)
			{
				MasterAudio.RemoveFromBlockedOcclusionSources(GrpVariation.GameObj);
				ResetToNonOcclusionSetting();
				return true;
			}
			MasterAudio.AddToBlockedOcclusionSources(GrpVariation.GameObj);
			float distRatio = num.Value / VarAudio.maxDistance;
			float occlusionCutoffFrequencyByDistanceRatio = AudioUtil.GetOcclusionCutoffFrequencyByDistanceRatio(distRatio, this);
			float occlusionFreqChangeSeconds = _maThisFrame.occlusionFreqChangeSeconds;
			if (occlusionFreqChangeSeconds <= 0.1f)
			{
				GrpVariation.LowPassFilter.cutoffFrequency = occlusionCutoffFrequencyByDistanceRatio;
				return true;
			}
			MasterAudio.GradualOcclusionFreqChange(GrpVariation, occlusionFreqChangeSeconds, occlusionCutoffFrequencyByDistanceRatio);
			return true;
		}

		private void PlaySoundAndWait()
		{
			if (!(VarAudio.clip == null))
			{
				double num = AudioSettings.dspTime;
				if (GrpVariation.PlaySoundParm.TimeToSchedulePlay.HasValue)
				{
					num = GrpVariation.PlaySoundParm.TimeToSchedulePlay.Value;
				}
				float num2 = 0f;
				if (GrpVariation.useIntroSilence && GrpVariation.introSilenceMax > 0f)
				{
					float num3 = UnityEngine.Random.Range(GrpVariation.introSilenceMin, GrpVariation.introSilenceMax);
					num2 += num3;
				}
				num2 += GrpVariation.PlaySoundParm.DelaySoundTime;
				if (num2 > 0f)
				{
					num += (double)num2;
				}
				VarAudio.PlayScheduled(num);
				AudioUtil.ClipPlayed(VarAudio.clip, GrpVariation.GameObj);
				if (GrpVariation.useRandomStartTime)
				{
					VarAudio.time = ClipStartPosition;
					float num4 = AudioUtil.AdjustAudioClipDurationForPitch(ClipEndPosition - ClipStartPosition, VarAudio);
					_clipSchedEndTime = num + (double)num4;
					VarAudio.SetScheduledEndTime(_clipSchedEndTime.Value);
				}
				GrpVariation.LastTimePlayed = AudioUtil.Time;
				MasterAudio.DuckSoundGroup(ParentGroup.GameObjectName, VarAudio);
				_isPlayingBackward = GrpVariation.OriginalPitch < 0f;
				_lastFrameClipTime = ((!_isPlayingBackward) ? (-1f) : (ClipEndPosition + 1f));
				_waitMode = WaitForSoundFinishMode.WaitForEnd;
			}
		}

		private void StopOrChain()
		{
			SoundGroupVariation.PlaySoundParams playSoundParm = GrpVariation.PlaySoundParm;
			bool flag = playSoundParm.IsPlaying && playSoundParm.IsChainLoop;
			if (!VarAudio.loop || flag)
			{
				GrpVariation.Stop();
			}
			if (flag)
			{
				StopWaitingForFinish();
				MaybeChain();
			}
		}

		public void Pause()
		{
			_isPaused = true;
			_pauseTime = AudioSettings.dspTime;
		}

		public void Unpause()
		{
			_isPaused = false;
			if (_clipSchedEndTime.HasValue)
			{
				_clipSchedEndTime += AudioSettings.dspTime - _pauseTime;
				VarAudio.SetScheduledEndTime(_clipSchedEndTime.Value);
			}
		}

		public void MaybeChain()
		{
			if (_hasStartedNextInChain)
			{
				return;
			}
			_hasStartedNextInChain = true;
			SoundGroupVariation.PlaySoundParams playSoundParm = GrpVariation.PlaySoundParm;
			int num = MasterAudio.RemainingClipsInGroup(ParentGroup.GameObjectName);
			int num2 = MasterAudio.VoicesForGroup(ParentGroup.GameObjectName);
			if (num == num2)
			{
				ParentGroup.FireLastVariationFinishedPlay();
			}
			if (ParentGroup.chainLoopMode == MasterAudioGroup.ChainedLoopLoopMode.NumberOfLoops && ParentGroup.ChainLoopCount >= ParentGroup.chainLoopNumLoops)
			{
				return;
			}
			float delaySoundTime = playSoundParm.DelaySoundTime;
			if (ParentGroup.chainLoopDelayMin > 0f || ParentGroup.chainLoopDelayMax > 0f)
			{
				delaySoundTime = UnityEngine.Random.Range(ParentGroup.chainLoopDelayMin, ParentGroup.chainLoopDelayMax);
			}
			if (playSoundParm.AttachToSource || playSoundParm.SourceTrans != null)
			{
				if (playSoundParm.AttachToSource)
				{
					MasterAudio.PlaySound3DFollowTransform(playSoundParm.SoundType, playSoundParm.SourceTrans, playSoundParm.VolumePercentage, playSoundParm.Pitch, delaySoundTime, null, _clipSchedEndTime, isChaining: true);
				}
				else
				{
					MasterAudio.PlaySound3DAtTransform(playSoundParm.SoundType, playSoundParm.SourceTrans, playSoundParm.VolumePercentage, playSoundParm.Pitch, delaySoundTime, null, _clipSchedEndTime, isChaining: true);
				}
			}
			else
			{
				MasterAudio.PlaySound(playSoundParm.SoundType, playSoundParm.VolumePercentage, playSoundParm.Pitch, delaySoundTime, null, _clipSchedEndTime, isChaining: true);
			}
		}

		private void UpdatePitch()
		{
			SoundGroupVariation.PitchMode curPitchMode = GrpVariation.curPitchMode;
			if (curPitchMode != 0 && curPitchMode == SoundGroupVariation.PitchMode.Gliding && VarAudio.isPlaying)
			{
				_pitchGlideToTargetFrameNumber++;
				if (_pitchGlideToTargetFrameNumber >= _pitchGlideToTargetTotalFrames)
				{
					VarAudio.pitch = _glideToTargetPitch;
					StopPitchGliding();
				}
				else
				{
					VarAudio.pitch = (float)_pitchGlideToTargetFrameNumber * _pitchGlideToTargetFramePitchChange + _glideToTargetOrigPitch;
				}
			}
		}

		private void PerformFading()
		{
			switch (GrpVariation.curFadeMode)
			{
			case SoundGroupVariation.FadeMode.None:
				break;
			case SoundGroupVariation.FadeMode.FadeInOut:
			{
				if (!VarAudio.isPlaying)
				{
					break;
				}
				float time = VarAudio.time;
				if (GrpVariation.fadeInTime > 0f && time < GrpVariation.fadeInTime)
				{
					VarAudio.volume = time * _fadeInOutInFactor;
				}
				else if (time >= GrpVariation.fadeInTime && !_hasFadeInOutSetMaxVolume)
				{
					VarAudio.volume = GrpVariation.fadeMaxVolume;
					_hasFadeInOutSetMaxVolume = true;
					if (!_fadeInOutWillFadeOut)
					{
						StopFading();
					}
				}
				else if (_fadeInOutWillFadeOut && time >= _fadeOutStartTime)
				{
					if (GrpVariation.PlaySoundParm.IsChainLoop && !_fadeOutStarted)
					{
						MaybeChain();
						_fadeOutStarted = true;
					}
					VarAudio.volume = (ClipEndPosition - time) * _fadeInOutOutFactor;
				}
				break;
			}
			case SoundGroupVariation.FadeMode.FadeOutEarly:
				if (VarAudio.isPlaying)
				{
					_fadeOutEarlyFrameNumber++;
					VarAudio.volume = (float)_fadeOutEarlyFrameNumber * _fadeOutEarlyFrameVolChange + _fadeOutEarlyOrigVol;
					if (_fadeOutEarlyFrameNumber >= _fadeOutEarlyTotalFrames)
					{
						GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.None;
						GrpVariation.Stop();
					}
				}
				break;
			case SoundGroupVariation.FadeMode.GradualFade:
				if (VarAudio.isPlaying)
				{
					_fadeToTargetFrameNumber++;
					if (_fadeToTargetFrameNumber >= _fadeToTargetTotalFrames)
					{
						VarAudio.volume = _fadeToTargetVolume;
						StopFading();
					}
					else
					{
						VarAudio.volume = (float)_fadeToTargetFrameNumber * _fadeToTargetFrameVolChange + _fadeToTargetOrigVol;
					}
				}
				break;
			}
		}

		private void OnEnable()
		{
			_inited = false;
			_fadeInOutWillFadeOut = false;
			_hasFadeInOutSetMaxVolume = false;
			_fadeOutStarted = false;
			_hasStartedNextInChain = false;
			_framesPlayed = 0;
			_clipStartPosition = null;
			_clipEndPosition = null;
			DoneWithOcclusion();
			MasterAudio.RegisterUpdaterForUpdates(this);
		}

		private void OnDisable()
		{
			if (!MasterAudio.AppIsShuttingDown)
			{
				_framesPlayed = 0;
				DoneWithOcclusion();
				MasterAudio.UnregisterUpdaterForUpdates(this);
			}
		}

		public void UpdateCachedObjects()
		{
			_frameNum = AudioUtil.FrameCount;
			if (_maCachedFromFrame < _frameNum)
			{
				_maCachedFromFrame = _frameNum;
				_maThisFrame = MasterAudio.Instance;
				_listenerThisFrame = MasterAudio.ListenerTrans;
			}
		}

		public void ManualUpdate()
		{
			UpdateCachedObjects();
			_framesPlayed++;
			if (VarAudio.loop)
			{
				if (VarAudio.timeSamples < _lastFrameClipPosition)
				{
					_timesLooped++;
					if (VarAudio.loop && GrpVariation.useCustomLooping && _timesLooped >= GrpVariation.MaxLoops)
					{
						GrpVariation.Stop();
					}
					else
					{
						GrpVariation.SoundLoopStarted(_timesLooped);
					}
				}
				_lastFrameClipPosition = VarAudio.timeSamples;
			}
			if (_isFollowing && ParentGroup.targetDespawnedBehavior != 0 && (_objectToFollowGo == null || !DTMonoHelper.IsActive(_objectToFollowGo)))
			{
				switch (ParentGroup.targetDespawnedBehavior)
				{
				case MasterAudioGroup.TargetDespawnedBehavior.Stop:
					GrpVariation.Stop();
					break;
				case MasterAudioGroup.TargetDespawnedBehavior.FadeOut:
					GrpVariation.FadeOutNow(ParentGroup.despawnFadeTime);
					break;
				}
				StopFollowing();
			}
			PerformFading();
			UpdateAudioLocationAndPriority(rePrioritize: true);
			UpdateOcclusion();
			UpdatePitch();
			switch (_waitMode)
			{
			case WaitForSoundFinishMode.None:
				break;
			case WaitForSoundFinishMode.Play:
				PlaySoundAndWait();
				break;
			case WaitForSoundFinishMode.WaitForEnd:
			{
				if (_isPaused)
				{
					break;
				}
				if (_clipSchedEndTime.HasValue && AudioSettings.dspTime + 0.10000000149011612 >= _clipSchedEndTime.Value)
				{
					if (GrpVariation.PlaySoundParm.IsChainLoop && !_hasScheduledNextClip)
					{
						MaybeChain();
						_hasScheduledNextClip = true;
					}
					if (HasEndLinkedGroups && !_hasScheduledEndLinkedGroups)
					{
						GrpVariation.PlayEndLinkedGroups(_clipSchedEndTime.Value);
						_hasScheduledEndLinkedGroups = true;
					}
				}
				bool flag = false;
				if (_isPlayingBackward)
				{
					if (VarAudio.time > _lastFrameClipTime)
					{
						flag = true;
					}
				}
				else if (VarAudio.time < _lastFrameClipTime)
				{
					flag = true;
				}
				_lastFrameClipTime = VarAudio.time;
				if (flag)
				{
					_waitMode = WaitForSoundFinishMode.StopOrRepeat;
				}
				break;
			}
			case WaitForSoundFinishMode.StopOrRepeat:
				StopOrChain();
				break;
			}
		}
	}
}
public static class AudioLoaderOptimizer
{
	private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName = new Dictionary<string, List<GameObject>>(StringComparer.OrdinalIgnoreCase);

	public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
		if (clip == null)
		{
			return;
		}
		string name = clip.name;
		if (!PlayingGameObjectsByClipName.ContainsKey(name))
		{
			PlayingGameObjectsByClipName.Add(name, new List<GameObject> { maHolderGameObject });
			return;
		}
		List<GameObject> list = PlayingGameObjectsByClipName[name];
		if (!list.Contains(maHolderGameObject))
		{
			list.Add(maHolderGameObject);
		}
	}

	public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
		if (clip == null)
		{
			return;
		}
		string name = clip.name;
		if (PlayingGameObjectsByClipName.ContainsKey(name))
		{
			List<GameObject> list = PlayingGameObjectsByClipName[name];
			list.Remove(maHolderGameObject);
			if (list.Count == 0)
			{
				PlayingGameObjectsByClipName.Remove(name);
			}
		}
	}

	public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
	{
		if (clip == null)
		{
			return false;
		}
		return PlayingGameObjectsByClipName.ContainsKey(clip.name);
	}
}
namespace DarkTonic.MasterAudio
{
	public static class AudioPrioritizer
	{
		private const int MaxPriority = 0;

		private const int HighestPriority = 16;

		private const int LowestPriority = 128;

		public static void Set2DSoundPriority(AudioSource audio)
		{
			audio.priority = 16;
		}

		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
			audio.priority = 128;
		}

		public static void SetPreviewPriority(AudioSource audio)
		{
			audio.priority = 0;
		}

		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
			if (MasterAudio.ListenerTrans == null)
			{
				return;
			}
			AudioSource varAudio = variation.VarAudio;
			if (varAudio.spatialBlend == 0f)
			{
				Set2DSoundPriority(variation.VarAudio);
				return;
			}
			float num = Vector3.Distance(varAudio.transform.position, MasterAudio.ListenerTrans.position);
			float num2 = varAudio.rolloffMode switch
			{
				AudioRolloffMode.Logarithmic => varAudio.volume / Mathf.Max(varAudio.minDistance, num - varAudio.minDistance), 
				AudioRolloffMode.Linear => Mathf.Lerp(varAudio.volume, 0f, Mathf.Max(0f, num - varAudio.minDistance) / (varAudio.maxDistance - varAudio.minDistance)), 
				_ => Mathf.Lerp(varAudio.volume, 0f, Mathf.Max(0f, num - varAudio.minDistance) / (varAudio.maxDistance - varAudio.minDistance)), 
			};
			if (useClipAgePriority && !varAudio.loop)
			{
				num2 = Mathf.Lerp(num2, num2 * 0.1f, AudioUtil.GetAudioPlayedPercentage(varAudio) * 0.01f);
			}
			varAudio.priority = (int)Mathf.Lerp(16f, 128f, Mathf.InverseLerp(1f, 0f, num2));
		}
	}
	public static class AudioResourceOptimizer
	{
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName = new Dictionary<string, List<AudioSource>>(StringComparer.OrdinalIgnoreCase);

		private static readonly Dictionary<string, AudioClip> AudioClipsByName = new Dictionary<string, AudioClip>(StringComparer.OrdinalIgnoreCase);

		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName = new Dictionary<string, List<AudioClip>>(5, StringComparer.OrdinalIgnoreCase);

		private static readonly List<string> InternetFilesStartedLoading = new List<string>();

		private static string _supportedLanguageFolder = string.Empty;

		public static void ClearAudioClips()
		{
			AudioClipsByName.Clear();
			AudioResourceTargetsByName.Clear();
		}

		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			if (!useLocalization)
			{
				return resourceFileName;
			}
			if (MasterAudio.Instance != null)
			{
				return GetLocalizedFileName(useLocalization, resourceFileName);
			}
			return localLanguage.ToString() + "/" + resourceFileName;
		}

		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return (!useLocalization) ? resourceFileName : (SupportedLanguageFolder() + "/" + resourceFileName);
		}

		public static void AddTargetForClip(string clipName, AudioSource source)
		{
			if (!AudioResourceTargetsByName.ContainsKey(clipName))
			{
				AudioResourceTargetsByName.Add(clipName, new List<AudioSource> { source });
				return;
			}
			List<AudioSource> list = AudioResourceTargetsByName[clipName];
			AudioClip audioClip = null;
			for (int i = 0; i < list.Count; i++)
			{
				AudioClip clip = list[i].clip;
				if (!(clip == null))
				{
					audioClip = clip;
					break;
				}
			}
			if (audioClip != null)
			{
				source.clip = audioClip;
				SoundGroupVariation component = source.GetComponent<SoundGroupVariation>();
				if (component != null)
				{
					component.internetFileLoadStatus = MasterAudio.InternetFileLoadStatus.Loaded;
				}
			}
			list.Add(source);
		}

		private static string SupportedLanguageFolder()
		{
			if (!string.IsNullOrEmpty(_supportedLanguageFolder))
			{
				return _supportedLanguageFolder;
			}
			SystemLanguage item = Application.systemLanguage;
			if (MasterAudio.Instance != null)
			{
				switch (MasterAudio.Instance.langMode)
				{
				case MasterAudio.LanguageMode.SpecificLanguage:
					item = MasterAudio.Instance.testLanguage;
					break;
				case MasterAudio.LanguageMode.DynamicallySet:
					item = MasterAudio.DynamicLanguage;
					break;
				}
			}
			if (MasterAudio.Instance.supportedLanguages.Contains(item))
			{
				_supportedLanguageFolder = item.ToString();
			}
			else
			{
				_supportedLanguageFolder = MasterAudio.Instance.defaultLanguage.ToString();
			}
			return _supportedLanguageFolder;
		}

		public static void ClearSupportLanguageFolder()
		{
			_supportedLanguageFolder = string.Empty;
		}

		public static AudioClip PopulateResourceSongToPlaylistController(string controllerName, string songResourceName, string playlistName)
		{
			AudioClip audioClip = Resources.Load(songResourceName) as AudioClip;
			if (audioClip == null)
			{
				MasterAudio.LogWarning("Resource file '" + songResourceName + "' could not be located from Playlist '" + playlistName + "'.");
				return null;
			}
			if (!AudioUtil.AudioClipWillPreload(audioClip))
			{
				MasterAudio.LogWarning("Audio Clip for Resource file '" + songResourceName + "' from Playlist '" + playlistName + "' has 'Preload Audio Data' turned off, which can cause audio glitches. Resource files should always Preload Audio Data. Please turn it on.");
			}
			FinishRecordingPlaylistClip(controllerName, audioClip);
			return audioClip;
		}

		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
			List<AudioClip> list;
			if (!PlaylistClipsByPlaylistName.ContainsKey(controllerName))
			{
				list = new List<AudioClip>(5);
				PlaylistClipsByPlaylistName.Add(controllerName, list);
			}
			else
			{
				list = PlaylistClipsByPlaylistName[controllerName];
			}
			list.Add(resAudioClip);
		}

		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			ResourceRequest asyncRes = Resources.LoadAsync(songResourceName, typeof(AudioClip));
			while (!asyncRes.isDone)
			{
				yield return MasterAudio.EndOfFrameDelay;
			}
			AudioClip resAudioClip = asyncRes.asset as AudioClip;
			if (resAudioClip == null)
			{
				MasterAudio.LogWarning("Resource file '" + songResourceName + "' could not be located from Playlist '" + playlistName + "'.");
				yield break;
			}
			if (!AudioUtil.AudioClipWillPreload(resAudioClip))
			{
				MasterAudio.LogWarning("Audio Clip for Resource file '" + songResourceName + "' from Playlist '" + playlistName + "' has 'Preload Audio Data' turned off, which can cause audio glitches. Resource files should always Preload Audio Data. Please turn it on.");
			}
			FinishRecordingPlaylistClip(controller.ControllerName, resAudioClip);
			controller.FinishLoadingNewSong(resAudioClip, playType);
		}

		public static IEnumerator PopulateSourceWithInternetFile(string fileUrl, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			if (AudioClipsByName.ContainsKey(fileUrl))
			{
				successAction?.Invoke();
			}
			else
			{
				if (InternetFilesStartedLoading.Contains(fileUrl))
				{
					yield break;
				}
				InternetFilesStartedLoading.Add(fileUrl);
				AudioClip internetClip;
				using (WWW fileRequest = new WWW(fileUrl))
				{
					yield return fileRequest;
					if (fileRequest.error != null)
					{
						if (string.IsNullOrEmpty(fileUrl))
						{
							MasterAudio.LogWarning("Internet file is EMPTY for a Variation of Sound Group '" + variation.ParentGroup.name + "' could not be loaded.");
						}
						else
						{
							MasterAudio.LogWarning("Internet file '" + fileUrl + "' in a Variation of Sound Group '" + variation.ParentGroup.name + "' could not be loaded. This can happen if the URL is incorrect or you are not online.");
						}
						failureAction?.Invoke();
						yield break;
					}
					internetClip = fileRequest.GetAudioClip();
					string[] urlParts = new Uri(fileUrl).Segments;
					internetClip.name = Path.GetFileNameWithoutExtension(urlParts[urlParts.Length - 1]);
				}
				if (!AudioResourceTargetsByName.ContainsKey(fileUrl))
				{
					MasterAudio.LogError("No Audio Sources found to add Internet File '" + fileUrl + "' to.");
					failureAction?.Invoke();
					yield break;
				}
				List<AudioSource> sources = AudioResourceTargetsByName[fileUrl];
				for (int i = 0; i < sources.Count; i++)
				{
					sources[i].clip = internetClip;
					SoundGroupVariation component = sources[i].GetComponent<SoundGroupVariation>();
					if (!(component == null))
					{
						component.internetFileLoadStatus = MasterAudio.InternetFileLoadStatus.Loaded;
					}
				}
				if (!AudioClipsByName.ContainsKey(fileUrl))
				{
					AudioClipsByName.Add(fileUrl, internetClip);
				}
				successAction?.Invoke();
			}
		}

		public static void RemoveLoadedInternetClip(string fileUrl)
		{
			if (!InternetFilesStartedLoading.Contains(fileUrl))
			{
				return;
			}
			InternetFilesStartedLoading.Remove(fileUrl);
			if (AudioResourceTargetsByName.ContainsKey(fileUrl))
			{
				List<AudioSource> list = AudioResourceTargetsByName[fileUrl];
				for (int i = 0; i < list.Count; i++)
				{
					UnityEngine.Object.Destroy(list[i].clip);
					list[i].clip = null;
				}
				AudioResourceTargetsByName.Remove(fileUrl);
			}
			if (AudioClipsByName.ContainsKey(fileUrl))
			{
				AudioClipsByName.Remove(fileUrl);
			}
		}

		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			if (AudioClipsByName.ContainsKey(clipName))
			{
				successAction?.Invoke();
				yield break;
			}
			ResourceRequest asyncRes = Resources.LoadAsync(clipName, typeof(AudioClip));
			while (!asyncRes.isDone)
			{
				yield return MasterAudio.EndOfFrameDelay;
			}
			AudioClip resAudioClip = asyncRes.asset as AudioClip;
			if (resAudioClip == null)
			{
				MasterAudio.LogError("Resource file '" + clipName + "' could not be located.");
				failureAction?.Invoke();
				yield break;
			}
			if (!AudioResourceTargetsByName.ContainsKey(clipName))
			{
				MasterAudio.LogError("No Audio Sources found to add Resource file '" + clipName + "'.");
				failureAction?.Invoke();
				yield break;
			}
			if (!AudioUtil.AudioClipWillPreload(resAudioClip))
			{
				MasterAudio.LogWarning("Audio Clip for Resource file '" + clipName + "' of Sound Group '" + variation.ParentGroup.name + "' has 'Preload Audio Data' turned off, which can cause audio glitches. Resource files should always Preload Audio Data. Please turn it on.");
			}
			List<AudioSource> sources = AudioResourceTargetsByName[clipName];
			for (int i = 0; i < sources.Count; i++)
			{
				sources[i].clip = resAudioClip;
			}
			if (!AudioClipsByName.ContainsKey(clipName))
			{
				AudioClipsByName.Add(clipName, resAudioClip);
			}
			successAction?.Invoke();
		}

		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
			if (clipToRemove == null || !PlaylistClipsByPlaylistName.ContainsKey(controllerName))
			{
				return;
			}
			List<AudioClip> list = PlaylistClipsByPlaylistName[controllerName];
			if (list.Contains(clipToRemove))
			{
				list.Remove(clipToRemove);
				if (!list.Contains(clipToRemove))
				{
					Resources.UnloadAsset(clipToRemove);
				}
			}
		}

		public static bool PopulateSourcesWithResourceClip(string clipName, SoundGroupVariation variation)
		{
			if (AudioClipsByName.ContainsKey(clipName))
			{
				return true;
			}
			AudioClip audioClip = Resources.Load(clipName) as AudioClip;
			if (audioClip == null)
			{
				MasterAudio.LogError("Resource file '" + clipName + "' could not be located.");
				return false;
			}
			if (!AudioResourceTargetsByName.ContainsKey(clipName))
			{
				MasterAudio.LogError("No Audio Sources found to add Resource file '" + clipName + "'.");
				return false;
			}
			List<AudioSource> list = AudioResourceTargetsByName[clipName];
			for (int i = 0; i < list.Count; i++)
			{
				list[i].clip = audioClip;
			}
			if (!AudioUtil.AudioClipWillPreload(audioClip))
			{
				MasterAudio.LogWarning("Audio Clip for Resource file '" + clipName + "' of Sound Group '" + variation.ParentGroup.name + "' has 'Preload Audio Data' turned off, which can cause audio glitches. Resource files should always Preload Audio Data. Please turn it on.");
			}
			AudioClipsByName.Add(clipName, audioClip);
			return true;
		}

		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
			if (!AudioResourceTargetsByName.ContainsKey(clipName))
			{
				MasterAudio.LogError("No Audio Sources found for Resource file '" + clipName + "'.");
				return;
			}
			List<AudioSource> list = AudioResourceTargetsByName[clipName];
			list.Remove(source);
			if (list.Count == 0)
			{
				AudioResourceTargetsByName.Remove(clipName);
			}
		}

		public static void UnloadClipIfUnused(string clipName)
		{
			if (!AudioClipsByName.ContainsKey(clipName))
			{
				return;
			}
			List<AudioSource> list = new List<AudioSource>();
			if (AudioResourceTargetsByName.ContainsKey(clipName))
			{
				list = AudioResourceTargetsByName[clipName];
				for (int i = 0; i < list.Count; i++)
				{
					AudioSource audioSource = list[i];
					SoundGroupVariation component = audioSource.GetComponent<SoundGroupVariation>();
					if (component.IsPlaying)
					{
						return;
					}
				}
			}
			AudioClip assetToUnload = AudioClipsByName[clipName];
			for (int j = 0; j < list.Count; j++)
			{
				list[j].clip = null;
			}
			AudioClipsByName.Remove(clipName);
			Resources.UnloadAsset(assetToUnload);
		}
	}
	[AudioScriptOrder(-50)]
	public class MasterAudio : MonoBehaviour
	{
		public enum VariationFollowerType
		{
			LateUpdate,
			FixedUpdate
		}

		public enum LinkedGroupSelectionType
		{
			All,
			OneAtRandom
		}

		public enum OcclusionSelectionType
		{
			AllGroups,
			TurnOnPerBusOrGroup
		}

		public enum RaycastMode
		{
			Physics3D,
			Physics2D
		}

		public enum AllMusicSpatialBlendType
		{
			ForceAllTo2D,
			ForceAllTo3D,
			ForceAllToCustom,
			AllowDifferentPerController
		}

		public enum AllMixerSpatialBlendType
		{
			ForceAllTo2D,
			ForceAllTo3D,
			ForceAllToCustom,
			AllowDifferentPerGroup
		}

		public enum ItemSpatialBlendType
		{
			ForceTo2D,
			ForceTo3D,
			ForceToCustom,
			UseCurveFromAudioSource
		}

		public enum InternetFileLoadStatus
		{
			Loading,
			Loaded,
			Failed
		}

		public enum MixerWidthMode
		{
			Narrow,
			Normal,
			Wide
		}

		public enum CustomEventReceiveMode
		{
			Always,
			WhenDistanceLessThan,
			WhenDistanceMoreThan,
			Never,
			OnSameGameObject,
			OnChildGameObject,
			OnParentGameObject,
			OnSameOrChildGameObject,
			OnSameOrParentGameObject
		}

		public enum EventReceiveFilter
		{
			All,
			Closest,
			Random
		}

		public enum AudioLocation
		{
			Clip,
			ResourceFile,
			FileOnInternet
		}

		public enum CustomSongStartTimeMode
		{
			Beginning,
			SpecificTime,
			RandomTime
		}

		public enum BusCommand
		{
			None,
			FadeToVolume,
			Mute,
			Pause,
			Solo,
			Unmute,
			Unpause,
			Unsolo,
			Stop,
			ChangePitch,
			ToggleMute,
			StopBusOfTransform,
			PauseBusOfTransform,
			UnpauseBusOfTransform,
			GlideByPitch
		}

		public enum DragGroupMode
		{
			OneGroupPerClip,
			OneGroupWithVariations
		}

		public enum EventSoundFunctionType
		{
			PlaySound,
			GroupControl,
			BusControl,
			PlaylistControl,
			CustomEventControl,
			GlobalControl,
			UnityMixerControl,
			PersistentSettingsControl
		}

		public enum LanguageMode
		{
			UseDeviceSetting,
			SpecificLanguage,
			DynamicallySet
		}

		public enum UnityMixerCommand
		{
			None,
			TransitionToSnapshot,
			TransitionToSnapshotBlend
		}

		public enum PlaylistCommand
		{
			None,
			ChangePlaylist,
			FadeToVolume,
			PlaySong,
			PlayRandomSong,
			PlayNextSong,
			Pause,
			Resume,
			Stop,
			Mute,
			Unmute,
			ToggleMute,
			Restart,
			Start,
			StopLoopingCurrentSong,
			StopPlaylistAfterCurrentSong,
			AddSongToQueue
		}

		public enum CustomEventCommand
		{
			None,
			FireEvent
		}

		public enum GlobalCommand
		{
			None,
			PauseMixer,
			UnpauseMixer,
			StopMixer,
			StopEverything,
			PauseEverything,
			UnpauseEverything,
			MuteEverything,
			UnmuteEverything,
			SetMasterMixerVolume,
			SetMasterPlaylistVolume
		}

		public enum SoundGroupCommand
		{
			None,
			FadeToVolume,
			FadeOutAllOfSound,
			Mute,
			Pause,
			Solo,
			StopAllOfSound,
			Unmute,
			Unpause,
			Unsolo,
			StopAllSoundsOfTransform,
			PauseAllSoundsOfTransform,
			UnpauseAllSoundsOfTransform,
			StopSoundGroupOfTransform,
			PauseSoundGroupOfTransform,
			UnpauseSoundGroupOfTransform,
			FadeOutSoundGroupOfTransform,
			RefillSoundGroupPool,
			RouteToBus,
			GlideByPitch,
			ToggleSoundGroup,
			ToggleSoundGroupOfTransform,
			FadeOutAllSoundsOfTransform
		}

		public enum PersistentSettingsCommand
		{
			None,
			SetBusVolume,
			SetGroupVolume,
			SetMixerVolume,
			SetMusicVolume,
			MixerMuteToggle,
			MusicMuteToggle
		}

		public enum SongFadeInPosition
		{
			NewClipFromBeginning = 1,
			NewClipFromLastKnownPosition = 3,
			SynchronizeClips = 5
		}

		public enum SoundSpawnLocationMode
		{
			MasterAudioLocation,
			CallerLocation,
			AttachToCaller
		}

		public enum VariationCommand
		{
			None,
			Stop,
			Pause,
			Unpause
		}

		public struct CustomEventCandidate
		{
			public float DistanceAway;

			public ICustomEventReceiver Receiver;

			public Transform Trans;

			public int RandomId;

			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
				DistanceAway = distance;
				Receiver = rec;
				Trans = trans;
				RandomId = randomId;
			}
		}

		[Serializable]
		public class AudioGroupInfo
		{
			public List<AudioInfo> Sources;

			public int LastFramePlayed;

			public float LastTimePlayed;

			public MasterAudioGroup Group;

			public bool PlayedForWarming;

			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
				Sources = sources;
				LastFramePlayed = -50;
				LastTimePlayed = -50f;
				Group = groupScript;
				PlayedForWarming = false;
			}
		}

		[Serializable]
		public class AudioInfo
		{
			public AudioSource Source;

			public float OriginalVolume;

			public float LastPercentageVolume;

			public float LastRandomVolume;

			public SoundGroupVariation Variation;

			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
				Variation = variation;
				Source = source;
				OriginalVolume = origVol;
				LastPercentageVolume = 1f;
				LastRandomVolume = 0f;
			}
		}

		[Serializable]
		public class Playlist
		{
			public enum CrossfadeTimeMode
			{
				UseMasterSetting,
				Override
			}

			public bool isExpanded = true;

			public string playlistName = "new playlist";

			public SongFadeInPosition songTransitionType = SongFadeInPosition.NewClipFromBeginning;

			public List<MusicSetting> MusicSettings;

			public AudioLocation bulkLocationMode;

			public CrossfadeTimeMode crossfadeMode;

			public float crossFadeTime = 1f;

			public bool fadeInFirstSong;

			public bool fadeOutLastSong;

			public bool resourceClipsAllLoadAsync = true;

			public bool isTemporary;

			public Playlist()
			{
				MusicSettings = new List<MusicSetting>();
			}
		}

		[Serializable]
		public class SoundGroupRefillInfo
		{
			public float LastTimePlayed;

			public float InactivePeriodSeconds;

			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
				LastTimePlayed = lastTimePlayed;
				InactivePeriodSeconds = inactivePeriodSeconds;
			}
		}

		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		public const string LoopDisabledCustomStartEnd = "Loop Clip is always OFF when using Custom Start/End Position";

		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		public const string NoCategory = "[Uncategorized]";

		public const float SemiTonePitchFactor = 1.05946f;

		public const float SpatialBlend_2DValue = 0f;

		public const float SpatialBlend_3DValue = 1f;

		public const float MaxCrossFadeTimeSeconds = 120f;

		public const float DefaultDuckVolCut = -6f;

		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		public static readonly YieldInstruction EndOfFrameDelay = new WaitForEndOfFrame();

		public static readonly List<string> ExemptChildNames = new List<string> { "_Followers" };

		public static Action NumberOfAudioSourcesChanged;

		public const string GizmoFileName = "MasterAudio/MasterAudio Icon.png";

		public const int HardCodedBusOptions = 2;

		public const string AllBusesName = "[All]";

		public const string NoGroupName = "[None]";

		public const string DynamicGroupName = "[Type In]";

		public const string NoPlaylistName = "[No Playlist]";

		public const string NoVoiceLimitName = "[NO LMT]";

		public const string OnlyPlaylistControllerName = "~only~";

		public const float InnerLoopCheckInterval = 0.1f;

		private const int MaxComponents = 20;

		public AudioLocation bulkLocationMode;

		public string groupTemplateName = "Default Single";

		public string audioSourceTemplateName = "Max Distance 500";

		public bool showGroupCreation = true;

		public bool useGroupTemplates;

		public DragGroupMode curDragGroupMode;

		public List<GameObject> groupTemplates = new List<GameObject>(10);

		public List<GameObject> audioSourceTemplates = new List<GameObject>(10);

		public bool mixerMuted;

		public bool playlistsMuted;

		public LanguageMode langMode;

		public SystemLanguage testLanguage = SystemLanguage.English;

		public SystemLanguage defaultLanguage = SystemLanguage.English;

		public List<SystemLanguage> supportedLanguages = new List<SystemLanguage> { SystemLanguage.English };

		public string busFilter = string.Empty;

		public bool useTextGroupFilter;

		public string textGroupFilter = string.Empty;

		public bool resourceClipsPauseDoNotUnload;

		public bool resourceClipsAllLoadAsync = true;

		public Transform playlistControllerPrefab;

		public bool persistBetweenScenes;

		public bool shouldLogDestroys;

		public bool areGroupsExpanded = true;

		public Transform soundGroupTemplate;

		public Transform soundGroupVariationTemplate;

		public List<GroupBus> groupBuses = new List<GroupBus>();

		public bool groupByBus = true;

		public bool showGizmos = true;

		public bool showAdvancedSettings = true;

		public bool showLocalization = true;

		public bool playListExpanded = true;

		public bool playlistsExpanded = true;

		public AllMusicSpatialBlendType musicSpatialBlendType;

		public float musicSpatialBlend;

		public AllMixerSpatialBlendType mixerSpatialBlendType = AllMixerSpatialBlendType.ForceAllTo3D;

		public float mixerSpatialBlend = 1f;

		public ItemSpatialBlendType newGroupSpatialType = ItemSpatialBlendType.ForceTo3D;

		public float newGroupSpatialBlend = 1f;

		public List<Playlist> musicPlaylists = new List<Playlist>
		{
			new Playlist()
		};

		public float _masterAudioVolume = 1f;

		public bool vrSettingsExpanded;

		public bool useSpatializer;

		public bool useSpatializerPostFX;

		public bool ignoreTimeScale;

		public bool useGaplessPlaylists;

		public bool saveRuntimeChanges;

		public bool prioritizeOnDistance;

		public int rePrioritizeEverySecIndex = 1;

		public bool useOcclusion;

		public float occlusionMaxCutoffFreq;

		public float occlusionMinCutoffFreq = 22000f;

		public float occlusionFreqChangeSeconds;

		public OcclusionSelectionType occlusionSelectType;

		public int occlusionMaxRayCastsPerFrame = 4;

		public float occlusionRayCastOffset;

		public bool occlusionUseLayerMask;

		public LayerMask occlusionLayerMask;

		public bool occlusionShowRaycasts = true;

		public bool occlusionShowCategories;

		public RaycastMode occlusionRaycastMode;

		public bool occlusionIncludeStartRaycast2DCollider = true;

		public bool occlusionRaycastsHitTriggers = true;

		public bool ambientAdvancedExpanded;

		public int ambientMaxRecalcsPerFrame = 4;

		public bool visualAdvancedExpanded = true;

		public bool logAdvancedExpanded = true;

		public bool listenerAdvancedExpanded;

		public bool listenerFollowerHasRigidBody = true;

		public VariationFollowerType variationFollowerType;

		public bool showFadingSettings;

		public bool stopZeroVolumeGroups;

		public bool stopZeroVolumeBuses;

		public bool stopZeroVolumePlaylists;

		public float stopOldestBusFadeTime = 0.3f;

		public bool resourceAdvancedExpanded = true;

		public bool useClipAgePriority;

		public bool logOutOfVoices = true;

		public bool LogSounds;

		public bool logCustomEvents;

		public bool disableLogging;

		public bool showMusicDucking;

		public bool enableMusicDucking = true;

		public List<DuckGroupInfo> musicDuckingSounds = new List<DuckGroupInfo>();

		public float defaultRiseVolStart = 0.5f;

		public float defaultUnduckTime = 1f;

		public float defaultDuckedVolumeCut = -6f;

		public float crossFadeTime = 1f;

		public float _masterPlaylistVolume = 1f;

		public bool showGroupSelect;

		public bool hideGroupsWithNoActiveVars;

		public string newEventName = "my event";

		public bool showCustomEvents = true;

		public string newCustomEventCategoryName = "New Category";

		public string addToCustomEventCategoryName = "New Category";

		public List<CustomEvent> customEvents = new List<CustomEvent>();

		public List<CustomEventCategory> customEventCategories = new List<CustomEventCategory>
		{
			new CustomEventCategory()
		};

		public Dictionary<string, DuckGroupInfo> duckingBySoundType = new Dictionary<string, DuckGroupInfo>(StringComparer.OrdinalIgnoreCase);

		public int frames;

		public bool showUnityMixerGroupAssignment = true;

		public static readonly PlaySoundResult AndForgetSuccessResult = new PlaySoundResult
		{
			SoundPlayed = true
		};

		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType = new Dictionary<string, AudioGroupInfo>(StringComparer.OrdinalIgnoreCase);

		private Dictionary<string, List<int>> _randomizer = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);

		private Dictionary<string, List<int>> _randomizerOrigin = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);

		private Dictionary<string, List<int>> _randomizerLeftovers = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);

		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);

		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters = new List<SoundGroupVariationUpdater>(32);

		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove = new List<SoundGroupVariationUpdater>();

		private readonly List<CustomEventCandidate> ValidReceivers = new List<CustomEventCandidate>(10);

		private readonly List<MasterAudioGroup> SoloedGroups = new List<MasterAudioGroup>();

		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire = new Queue<CustomEventToFireInfo>(32);

		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs = new Queue<TransformFollower>(32);

		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs = new List<TransformFollower>(32);

		private readonly List<BusFadeInfo> BusFades = new List<BusFadeInfo>();

		private readonly List<GroupFadeInfo> GroupFades = new List<GroupFadeInfo>();

		private readonly List<GroupPitchGlideInfo> GroupPitchGlides = new List<GroupPitchGlideInfo>();

		private readonly List<BusPitchGlideInfo> BusPitchGlides = new List<BusPitchGlideInfo>();

		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges = new List<OcclusionFreqChangeInfo>();

		private readonly List<AudioSource> AllAudioSources = new List<AudioSource>(100);

		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName = new Dictionary<string, Dictionary<ICustomEventReceiver, Transform>>(StringComparer.OrdinalIgnoreCase);

		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName = new Dictionary<string, PlaylistController>(StringComparer.OrdinalIgnoreCase);

		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed = new Dictionary<string, SoundGroupRefillInfo>(StringComparer.OrdinalIgnoreCase);

		private readonly List<GameObject> OcclusionSourcesInRange = new List<GameObject>(32);

		private readonly List<GameObject> OcclusionSourcesOutOfRange = new List<GameObject>(32);

		private readonly List<GameObject> OcclusionSourcesBlocked = new List<GameObject>(32);

		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays = new Queue<SoundGroupVariationUpdater>(32);

		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop = new List<SoundGroupVariation>(16);

		private bool _isStoppingMultiple;

		private float _repriTime = -1f;

		private List<string> _groupsToRemove;

		private bool _mustRescanGroups;

		private Transform _trans;

		private bool _soundsLoaded;

		private bool _warming;

		private static MasterAudio _instance;

		private static string _prospectiveMAFolder = string.Empty;

		private static Transform _listenerTrans;

		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector = new List<SoundGroupCommand>
		{
			SoundGroupCommand.None,
			SoundGroupCommand.PauseAllSoundsOfTransform,
			SoundGroupCommand.StopAllSoundsOfTransform,
			SoundGroupCommand.UnpauseAllSoundsOfTransform,
			SoundGroupCommand.FadeOutAllSoundsOfTransform
		};

		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector = new List<SoundGroupCommand>
		{
			SoundGroupCommand.None,
			SoundGroupCommand.FadeOutSoundGroupOfTransform,
			SoundGroupCommand.PauseSoundGroupOfTransform,
			SoundGroupCommand.UnpauseSoundGroupOfTransform,
			SoundGroupCommand.StopSoundGroupOfTransform,
			SoundGroupCommand.ToggleSoundGroupOfTransform,
			SoundGroupCommand.ToggleSoundGroup,
			SoundGroupCommand.FadeOutAllSoundsOfTransform
		};

		public static float PlaylistMasterVolume
		{
			get
			{
				return Instance._masterPlaylistVolume;
			}
			set
			{
				Instance._masterPlaylistVolume = value;
				List<PlaylistController> instances = PlaylistController.Instances;
				for (int i = 0; i < instances.Count; i++)
				{
					instances[i].UpdateMasterVolume();
				}
			}
		}

		public static bool LogSoundsEnabled
		{
			get
			{
				return Instance.LogSounds;
			}
			set
			{
				Instance.LogSounds = value;
			}
		}

		public static bool LogOutOfVoices
		{
			get
			{
				return Instance.logOutOfVoices;
			}
			set
			{
				Instance.logOutOfVoices = value;
			}
		}

		public static List<AudioSource> MasterAudioSources => Instance.AllAudioSources;

		public static Transform ListenerTrans
		{
			get
			{
				if (_listenerTrans == null || !DTMonoHelper.IsActive(_listenerTrans.gameObject))
				{
					_listenerTrans = null;
					AudioListener[] array = UnityEngine.Object.FindObjectsOfType<AudioListener>();
					foreach (AudioListener audioListener in array)
					{
						if (DTMonoHelper.IsActive(audioListener.gameObject))
						{
							_listenerTrans = audioListener.transform;
						}
					}
				}
				return _listenerTrans;
			}
		}

		public static PlaylistController OnlyPlaylistController
		{
			get
			{
				List<PlaylistController> instances = PlaylistController.Instances;
				if (instances.Count != 0)
				{
					return instances[0];
				}
				UnityEngine.Debug.LogError("There are no Playlist Controller in this Scene.");
				return null;
			}
		}

		public static bool IsWarming => SafeInstance != null && Instance._warming;

		public static bool MixerMuted
		{
			get
			{
				return Instance.mixerMuted;
			}
			set
			{
				Instance.mixerMuted = value;
				if (value)
				{
					foreach (string key in Instance.AudioSourcesBySoundType.Keys)
					{
						MuteGroup(Instance.AudioSourcesBySoundType[key].Group.GameObjectName, shouldCheckMuteStatus: false);
					}
				}
				else
				{
					foreach (string key2 in Instance.AudioSourcesBySoundType.Keys)
					{
						UnmuteGroup(Instance.AudioSourcesBySoundType[key2].Group.GameObjectName, shouldCheckMuteStatus: false);
					}
				}
				if (Application.isPlaying)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		public static bool PlaylistsMuted
		{
			get
			{
				return Instance.playlistsMuted;
			}
			set
			{
				Instance.playlistsMuted = value;
				List<PlaylistController> instances = PlaylistController.Instances;
				for (int i = 0; i < instances.Count; i++)
				{
					if (value)
					{
						instances[i].MutePlaylist();
					}
					else
					{
						instances[i].UnmutePlaylist();
					}
				}
			}
		}

		public bool EnableMusicDucking
		{
			get
			{
				return enableMusicDucking;
			}
			set
			{
				enableMusicDucking = value;
			}
		}

		public float MasterCrossFadeTime => crossFadeTime;

		public static List<Playlist> MusicPlaylists => Instance.musicPlaylists;

		public static List<GroupBus> GroupBuses => Instance.groupBuses;

		public static List<string> RuntimeSoundGroupNames
		{
			get
			{
				if (!Application.isPlaying)
				{
					return new List<string>();
				}
				return new List<string>(Instance.AudioSourcesBySoundType.Keys);
			}
		}

		public static List<string> RuntimeBusNames
		{
			get
			{
				if (!Application.isPlaying)
				{
					return new List<string>();
				}
				List<string> list = new List<string>();
				for (int i = 0; i < Instance.groupBuses.Count; i++)
				{
					list.Add(Instance.groupBuses[i].busName);
				}
				return list;
			}
		}

		public static MasterAudio SafeInstance
		{
			get
			{
				if (_instance != null)
				{
					return _instance;
				}
				_instance = (MasterAudio)UnityEngine.Object.FindObjectOfType(typeof(MasterAudio));
				return _instance;
			}
		}

		public static MasterAudio Instance
		{
			get
			{
				if (_instance != null)
				{
					return _instance;
				}
				_instance = (MasterAudio)UnityEngine.Object.FindObjectOfType(typeof(MasterAudio));
				if (_instance == null && Application.isPlaying)
				{
					UnityEngine.Debug.LogError("There is no Master Audio prefab in this Scene. Subsequent method calls will fail.");
				}
				return _instance;
			}
			set
			{
				_instance = null;
			}
		}

		public static bool SoundsReady => Instance != null && Instance._soundsLoaded;

		public static bool AppIsShuttingDown { get; set; }

		public List<string> GroupNames
		{
			get
			{
				List<string> soundGroupHardCodedNames = SoundGroupHardCodedNames;
				List<string> list = new List<string>(Trans.childCount);
				for (int i = 0; i < Trans.childCount; i++)
				{
					string item = Trans.GetChild(i).name;
					if (!ArrayListUtil.IsExcludedChildName(item))
					{
						list.Add(item);
					}
				}
				DynamicSoundGroupCreator[] array = UnityEngine.Object.FindObjectsOfType(typeof(DynamicSoundGroupCreator)) as DynamicSoundGroupCreator[];
				DynamicSoundGroupCreator[] array2 = array;
				foreach (DynamicSoundGroupCreator dynamicSoundGroupCreator in array2)
				{
					Transform transform = dynamicSoundGroupCreator.transform;
					for (int k = 0; k < transform.childCount; k++)
					{
						DynamicSoundGroup component = transform.GetChild(k).GetComponent<DynamicSoundGroup>();
						if (!(component == null) && !list.Contains(component.name))
						{
							list.Add(component.name);
						}
					}
				}
				list.Sort();
				soundGroupHardCodedNames.AddRange(list);
				return soundGroupHardCodedNames;
			}
		}

		public static List<string> SoundGroupHardCodedNames
		{
			get
			{
				List<string> list = new List<string>();
				list.Add("[Type In]");
				list.Add("[None]");
				return list;
			}
		}

		public List<string> BusNames
		{
			get
			{
				List<string> list = new List<string>();
				list.Add("[Type In]");
				list.Add("[None]");
				List<string> list2 = list;
				for (int i = 0; i < groupBuses.Count; i++)
				{
					list2.Add(groupBuses[i].busName);
				}
				return list2;
			}
		}

		public List<string> PlaylistNames
		{
			get
			{
				List<string> list = new List<string>();
				list.Add("[Type In]");
				list.Add("[No Playlist]");
				List<string> list2 = list;
				for (int i = 0; i < musicPlaylists.Count; i++)
				{
					list2.Add(musicPlaylists[i].playlistName);
				}
				return list2;
			}
		}

		public List<string> PlaylistNamesOnly
		{
			get
			{
				List<string> list = new List<string>(musicPlaylists.Count);
				for (int i = 0; i < musicPlaylists.Count; i++)
				{
					list.Add(musicPlaylists[i].playlistName);
				}
				return list;
			}
		}

		public Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = GetComponent<Transform>();
				return _trans;
			}
		}

		public bool ShouldShowUnityAudioMixerGroupAssignments => showUnityMixerGroupAssignment;

		public List<string> CustomEventNames
		{
			get
			{
				List<string> customEventHardCodedNames = CustomEventHardCodedNames;
				List<CustomEvent> list = Instance.customEvents;
				for (int i = 0; i < list.Count; i++)
				{
					customEventHardCodedNames.Add(list[i].EventName);
				}
				return customEventHardCodedNames;
			}
		}

		public List<string> CustomEventNamesOnly
		{
			get
			{
				List<string> list = new List<string>(customEvents.Count);
				List<CustomEvent> list2 = Instance.customEvents;
				for (int i = 0; i < list2.Count; i++)
				{
					list.Add(list2[i].EventName);
				}
				return list;
			}
		}

		public static List<string> CustomEventHardCodedNames
		{
			get
			{
				List<string> list = new List<string>();
				list.Add("[Type In]");
				list.Add("[None]");
				return list;
			}
		}

		public static float MasterVolumeLevel
		{
			get
			{
				return Instance._masterAudioVolume;
			}
			set
			{
				Instance._masterAudioVolume = value;
				if (Application.isPlaying)
				{
					Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
					while (enumerator.MoveNext())
					{
						MasterAudioGroup group = enumerator.Current.Value.Group;
						SetGroupVolume(group.GameObjectName, group.groupMasterVolume);
					}
				}
			}
		}

		private static bool SceneHasMasterAudio => Instance != null;

		public static bool IgnoreTimeScale => Instance.ignoreTimeScale;

		public static SystemLanguage DynamicLanguage
		{
			get
			{
				if (!PlayerPrefs.HasKey("~MA_Language_Key~") || string.IsNullOrEmpty(PlayerPrefs.GetString("~MA_Language_Key~")))
				{
					PlayerPrefs.SetString("~MA_Language_Key~", SystemLanguage.Unknown.ToString());
				}
				return (SystemLanguage)Enum.Parse(typeof(SystemLanguage), PlayerPrefs.GetString("~MA_Language_Key~"));
			}
			set
			{
				PlayerPrefs.SetString("~MA_Language_Key~", value.ToString());
				AudioResourceOptimizer.ClearSupportLanguageFolder();
			}
		}

		public static float ReprioritizeTime
		{
			get
			{
				if (Instance._repriTime < 0f)
				{
					Instance._repriTime = (float)(Instance.rePrioritizeEverySecIndex + 1) * 0.1f;
				}
				return Instance._repriTime;
			}
		}

		public static bool ShouldRescanGroups
		{
			get
			{
				if (SafeInstance == null)
				{
					return false;
				}
				return Instance._mustRescanGroups;
			}
		}

		public static string ProspectiveMAPath
		{
			get
			{
				return _prospectiveMAFolder;
			}
			set
			{
				_prospectiveMAFolder = value;
			}
		}

		private void Awake()
		{
			UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeof(MasterAudio));
			if (array.Length > 1)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				bool flag = false;
				for (int i = 0; i < array.Length; i++)
				{
					MasterAudio masterAudio = array[i] as MasterAudio;
					if (masterAudio.persistBetweenScenes && masterAudio.shouldLogDestroys)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					UnityEngine.Debug.Log("More than one Master Audio prefab exists in this Scene. Destroying the newer one called '" + base.name + "'. You may wish to set up a Bootstrapper Scene so this does not occur.");
				}
				return;
			}
			base.useGUILayout = false;
			_soundsLoaded = false;
			_mustRescanGroups = false;
			Transform listenerTrans = ListenerTrans;
			if (listenerTrans != null)
			{
				AudioSource component = listenerTrans.GetComponent<AudioSource>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
			AmbientUtil.InitFollowerHolder();
			AudioSourcesBySoundType.Clear();
			PlaylistControllersByName.Clear();
			LastTimeSoundGroupPlayed.Clear();
			AllAudioSources.Clear();
			OcclusionSourcesInRange.Clear();
			OcclusionSourcesOutOfRange.Clear();
			OcclusionSourcesBlocked.Clear();
			QueuedOcclusionRays.Clear();
			TransFollowerColliderPositionRecalcs.Clear();
			ProcessedColliderPositionRecalcs.Clear();
			ActiveVariationUpdaters.Clear();
			ActiveUpdatersToRemove.Clear();
			List<string> list = new List<string>();
			AudioResourceOptimizer.ClearAudioClips();
			PlaylistController.Instances = null;
			List<PlaylistController> instances = PlaylistController.Instances;
			for (int j = 0; j < instances.Count; j++)
			{
				PlaylistController playlistController = instances[j];
				if (list.Contains(playlistController.name))
				{
					UnityEngine.Debug.LogError("You have more than 1 Playlist Controller with the name '" + playlistController.name + "'. You must name them all uniquely or the same-named ones will be deleted once they awake.");
					continue;
				}
				list.Add(playlistController.name);
				PlaylistControllersByName.Add(playlistController.name, playlistController);
				if (persistBetweenScenes)
				{
					UnityEngine.Object.DontDestroyOnLoad(playlistController);
				}
			}
			if (persistBetweenScenes)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
			List<int> list2 = new List<int>();
			_randomizer = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
			_randomizerOrigin = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
			_randomizerLeftovers = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
			_clipsPlayedBySoundTypeOldestFirst = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
			string text = string.Empty;
			List<SoundGroupVariation> list3 = new List<SoundGroupVariation>();
			_groupsToRemove = new List<string>(Trans.childCount);
			List<string> list4 = new List<string>();
			for (int k = 0; k < Trans.childCount; k++)
			{
				Transform child = Trans.GetChild(k);
				List<AudioInfo> list5 = new List<AudioInfo>();
				MasterAudioGroup component2 = child.GetComponent<MasterAudioGroup>();
				if (component2 == null)
				{
					if (!ArrayListUtil.IsExcludedChildName(child.name))
					{
						UnityEngine.Debug.LogError("MasterAudio could not find 'MasterAudioGroup' script for group '" + child.name + "'. Skipping this group.");
					}
					continue;
				}
				string text2 = child.name;
				if (string.IsNullOrEmpty(text))
				{
					text = text2;
				}
				List<Transform> list6 = new List<Transform>();
				List<int> list7 = new List<int>();
				for (int l = 0; l < child.childCount; l++)
				{
					Transform child2 = child.GetChild(l);
					SoundGroupVariation component3 = child2.GetComponent<SoundGroupVariation>();
					AudioSource component4 = child2.GetComponent<AudioSource>();
					int weight = component3.weight;
					for (int m = 0; m < weight; m++)
					{
						if (m > 0)
						{
							GameObject gameObject = UnityEngine.Object.Instantiate(child2.gameObject, child.transform.position, Quaternion.identity);
							gameObject.transform.name = child2.gameObject.name;
							SoundGroupVariation component5 = gameObject.GetComponent<SoundGroupVariation>();
							component5.weight = 1;
							list6.Add(gameObject.transform);
							component4 = gameObject.GetComponent<AudioSource>();
							list5.Add(new AudioInfo(component5, component4, component4.volume));
							list3.Add(component5);
							switch (component5.audLocation)
							{
							case AudioLocation.ResourceFile:
								AudioResourceOptimizer.AddTargetForClip(component5.resourceFileName, component4);
								break;
							case AudioLocation.FileOnInternet:
								AudioResourceOptimizer.AddTargetForClip(component5.internetFileUrl, component4);
								break;
							}
						}
						else
						{
							list5.Add(new AudioInfo(component3, component4, component4.volume));
							list3.Add(component3);
							switch (component3.audLocation)
							{
							case AudioLocation.ResourceFile:
							{
								string localizedFileName = AudioResourceOptimizer.GetLocalizedFileName(component3.useLocalization, component3.resourceFileName);
								AudioResourceOptimizer.AddTargetForClip(localizedFileName, component4);
								break;
							}
							case AudioLocation.FileOnInternet:
								AudioResourceOptimizer.AddTargetForClip(component3.internetFileUrl, component4);
								break;
							}
						}
					}
				}
				for (int n = 0; n < list6.Count; n++)
				{
					list6[n].parent = child;
				}
				AudioGroupInfo audioGroupInfo = new AudioGroupInfo(list5, component2);
				if (component2.isSoloed)
				{
					SoloedGroups.Add(component2);
				}
				if (component2.isMuted)
				{
					if (list4.Contains(component2.name))
					{
						continue;
					}
					list4.Add(component2.name);
				}
				if (AudioSourcesBySoundType.ContainsKey(text2))
				{
					UnityEngine.Debug.LogError("You have more than one SoundGroup named '" + text2 + "'. Ignoring the 2nd one. Please rename it.");
					continue;
				}
				audioGroupInfo.Group.OriginalVolume = audioGroupInfo.Group.groupMasterVolume;
				float? groupVolume = PersistentAudioSettings.GetGroupVolume(text2);
				if (groupVolume.HasValue)
				{
					audioGroupInfo.Group.groupMasterVolume = groupVolume.Value;
				}
				AddRuntimeGroupInfo(text2, audioGroupInfo);
				for (int num = 0; num < list5.Count; num++)
				{
					list2.Add(num);
				}
				if (audioGroupInfo.Group.curVariationSequence == MasterAudioGroup.VariationSequence.Randomized)
				{
					ArrayListUtil.SortIntArray(ref list2);
				}
				_randomizer.Add(text2, list2);
				list7.Clear();
				list7.AddRange(list2);
				_randomizerOrigin.Add(text2, list7);
				_randomizerLeftovers.Add(text2, new List<int>(list2.Count));
				_randomizerLeftovers[text2].AddRange(list2);
				_clipsPlayedBySoundTypeOldestFirst.Add(text2, new List<int>());
				list2 = new List<int>();
			}
			GroupFades.Clear();
			BusFades.Clear();
			GroupPitchGlides.Clear();
			BusPitchGlides.Clear();
			VariationOcclusionFreqChanges.Clear();
			for (int num2 = 0; num2 < groupBuses.Count; num2++)
			{
				GroupBus groupBus = groupBuses[num2];
				groupBus.OriginalVolume = groupBus.volume;
				string busName = groupBus.busName;
				float? busVolume = PersistentAudioSettings.GetBusVolume(busName);
				if (busVolume.HasValue)
				{
					SetBusVolumeByName(busName, busVolume.Value);
				}
			}
			duckingBySoundType.Clear();
			for (int num3 = 0; num3 < musicDuckingSounds.Count; num3++)
			{
				DuckGroupInfo duckGroupInfo = musicDuckingSounds[num3];
				if (duckingBySoundType.ContainsKey(duckGroupInfo.soundType))
				{
					UnityEngine.Debug.LogWarning("You have more than one Duck Group set up with the Sound Group '" + duckGroupInfo.soundType + "'. Please delete the duplicates before running again.");
				}
				else
				{
					duckingBySoundType.Add(duckGroupInfo.soundType, duckGroupInfo);
				}
			}
			_soundsLoaded = true;
			_warming = true;
			if (!string.IsNullOrEmpty(text))
			{
				PlaySoundResult playSoundResult = PlaySound3DFollowTransform(text, Trans, 0f);
				if (playSoundResult != null && playSoundResult.SoundPlayed)
				{
					playSoundResult.ActingVariation.Stop();
				}
			}
			FireCustomEvent("FakeEvent", _trans);
			for (int num4 = 0; num4 < customEvents.Count; num4++)
			{
				customEvents[num4].frameLastFired = -1;
			}
			frames = 0;
			UnityEngine.Object[] array2 = UnityEngine.Object.FindObjectsOfType(typeof(EventSounds));
			if (array2.Length > 0)
			{
				EventSounds eventSounds = array2[0] as EventSounds;
				eventSounds.PlaySounds(eventSounds.particleCollisionSound, EventSounds.EventType.UserDefinedEvent);
			}
			for (int num5 = 0; num5 < list4.Count; num5++)
			{
				MuteGroup(list4[num5], shouldCheckMuteStatus: false);
			}
			_warming = false;
			for (int num6 = 0; num6 < list3.Count; num6++)
			{
				list3[num6].DisableUpdater();
			}
			AmbientUtil.InitListenerFollower();
			PersistentAudioSettings.RestoreMasterSettings();
		}

		private void Start()
		{
			if (musicPlaylists.Count > 0 && musicPlaylists[0].MusicSettings != null && musicPlaylists[0].MusicSettings.Count > 0 && musicPlaylists[0].MusicSettings[0].clip != null && PlaylistControllersByName.Count == 0)
			{
				UnityEngine.Debug.Log("No Playlist Controllers exist in the Scene. Music will not play.");
			}
		}

		private void OnDisable()
		{
			List<AudioSource> sources = GetComponentsInChildren<AudioSource>().ToList();
			StopTrackingRuntimeAudioSources(sources);
		}

		private void Update()
		{
			frames++;
			PerformOcclusionFrequencyChanges();
			PerformBusFades();
			PerformBusPitchGlides();
			PerformGroupFades();
			PerformGroupPitchGlides();
			RefillInactiveGroupPools();
			FireCustomEventsWaiting();
			RecalcClosestColliderPositions();
		}

		private void LateUpdate()
		{
			if (variationFollowerType == VariationFollowerType.LateUpdate)
			{
				UpdateActiveVariations();
			}
		}

		private void FixedUpdate()
		{
			if (variationFollowerType == VariationFollowerType.FixedUpdate)
			{
				UpdateActiveVariations();
			}
		}

		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
			if (!Instance.ActiveVariationUpdaters.Contains(updater))
			{
				Instance.ActiveVariationUpdaters.Add(updater);
			}
		}

		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
			Instance.ActiveVariationUpdaters.Remove(updater);
		}

		private void UpdateActiveVariations()
		{
			ActiveUpdatersToRemove.Clear();
			for (int i = 0; i < ActiveVariationUpdaters.Count; i++)
			{
				SoundGroupVariationUpdater soundGroupVariationUpdater = ActiveVariationUpdaters[i];
				if (soundGroupVariationUpdater == null || !soundGroupVariationUpdater.enabled)
				{
					ActiveUpdatersToRemove.Add(soundGroupVariationUpdater);
				}
				else
				{
					soundGroupVariationUpdater.ManualUpdate();
				}
			}
			for (int j = 0; j < ActiveUpdatersToRemove.Count; j++)
			{
				ActiveVariationUpdaters.Remove(ActiveUpdatersToRemove[j]);
			}
		}

		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
			if (!Instance.LastTimeSoundGroupPlayed.ContainsKey(sType))
			{
				Instance.LastTimeSoundGroupPlayed.Add(sType, new SoundGroupRefillInfo(Time.realtimeSinceStartup, inactivePeriodSeconds));
			}
			else
			{
				Instance.LastTimeSoundGroupPlayed[sType].LastTimePlayed = AudioUtil.Time;
			}
		}

		private static void RecalcClosestColliderPositions()
		{
			if (!AmbientUtil.HasListenerFollower)
			{
				AmbientUtil.InitListenerFollower();
			}
			Instance.ProcessedColliderPositionRecalcs.Clear();
			int num = 0;
			while (num < Instance.TransFollowerColliderPositionRecalcs.Count && Instance.TransFollowerColliderPositionRecalcs.Count != 0)
			{
				TransformFollower transformFollower = Instance.TransFollowerColliderPositionRecalcs.Dequeue();
				if (!(transformFollower == null) && transformFollower.enabled)
				{
					bool flag = transformFollower.RecalcClosestColliderPosition();
					Instance.ProcessedColliderPositionRecalcs.Add(transformFollower);
					if (flag)
					{
						num++;
					}
				}
			}
			for (int i = 0; i < Instance.ProcessedColliderPositionRecalcs.Count; i++)
			{
				Instance.TransFollowerColliderPositionRecalcs.Enqueue(Instance.ProcessedColliderPositionRecalcs[i]);
			}
		}

		private static void FireCustomEventsWaiting()
		{
			while (Instance.CustomEventsToFire.Count > 0)
			{
				CustomEventToFireInfo customEventToFireInfo = Instance.CustomEventsToFire.Dequeue();
				FireCustomEvent(customEventToFireInfo.eventName, customEventToFireInfo.eventOrigin);
			}
		}

		private static void RefillInactiveGroupPools()
		{
			Dictionary<string, SoundGroupRefillInfo>.Enumerator enumerator = Instance.LastTimeSoundGroupPlayed.GetEnumerator();
			if (Instance._groupsToRemove == null)
			{
				Instance._groupsToRemove = new List<string>();
			}
			Instance._groupsToRemove.Clear();
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, SoundGroupRefillInfo> current = enumerator.Current;
				if (current.Value.LastTimePlayed + current.Value.InactivePeriodSeconds < AudioUtil.Time)
				{
					RefillSoundGroupPool(current.Key);
					Instance._groupsToRemove.Add(current.Key);
				}
			}
			for (int i = 0; i < Instance._groupsToRemove.Count; i++)
			{
				Instance.LastTimeSoundGroupPlayed.Remove(Instance._groupsToRemove[i]);
			}
		}

		private static void PerformOcclusionFrequencyChanges()
		{
			if (!AmbientUtil.HasListenerFollower)
			{
				AmbientUtil.InitListenerFollower();
			}
			for (int i = 0; i < Instance.VariationOcclusionFreqChanges.Count; i++)
			{
				OcclusionFreqChangeInfo occlusionFreqChangeInfo = Instance.VariationOcclusionFreqChanges[i];
				if (occlusionFreqChangeInfo.IsActive)
				{
					float val = 1f - (occlusionFreqChangeInfo.CompletionTime - AudioUtil.Time) / (occlusionFreqChangeInfo.CompletionTime - occlusionFreqChangeInfo.StartTime);
					val = Math.Min(val, 1f);
					val = Math.Max(val, 0f);
					float val2 = occlusionFreqChangeInfo.StartFrequency + (occlusionFreqChangeInfo.TargetFrequency - occlusionFreqChangeInfo.StartFrequency) * val;
					val2 = ((!(occlusionFreqChangeInfo.TargetFrequency > occlusionFreqChangeInfo.StartFrequency)) ? Math.Max(val2, occlusionFreqChangeInfo.TargetFrequency) : Math.Min(val2, occlusionFreqChangeInfo.TargetFrequency));
					occlusionFreqChangeInfo.ActingVariation.LowPassFilter.cutoffFrequency = val2;
					if (!(AudioUtil.Time < occlusionFreqChangeInfo.CompletionTime))
					{
						occlusionFreqChangeInfo.IsActive = false;
					}
				}
			}
			Instance.VariationOcclusionFreqChanges.RemoveAll((OcclusionFreqChangeInfo obj) => !obj.IsActive);
		}

		private void PerformBusFades()
		{
			for (int i = 0; i < BusFades.Count; i++)
			{
				BusFadeInfo busFadeInfo = BusFades[i];
				if (!busFadeInfo.IsActive)
				{
					continue;
				}
				GroupBus actingBus = busFadeInfo.ActingBus;
				if (actingBus == null)
				{
					busFadeInfo.IsActive = false;
					continue;
				}
				float val = 1f - (busFadeInfo.CompletionTime - AudioUtil.Time) / (busFadeInfo.CompletionTime - busFadeInfo.StartTime);
				val = Math.Min(val, 1f);
				val = Math.Max(val, 0f);
				float val2 = busFadeInfo.StartVolume + (busFadeInfo.TargetVolume - busFadeInfo.StartVolume) * val;
				SetBusVolumeByName(newVolume: (!(busFadeInfo.TargetVolume > busFadeInfo.StartVolume)) ? Math.Max(val2, busFadeInfo.TargetVolume) : Math.Min(val2, busFadeInfo.TargetVolume), busName: actingBus.busName);
				if (!(AudioUtil.Time < busFadeInfo.CompletionTime))
				{
					busFadeInfo.IsActive = false;
					if (stopZeroVolumeBuses && busFadeInfo.TargetVolume == 0f)
					{
						StopBus(busFadeInfo.NameOfBus);
					}
					else if (busFadeInfo.WillStopGroupAfterFade)
					{
						StopBus(busFadeInfo.NameOfBus);
					}
					if (busFadeInfo.WillResetVolumeAfterFade)
					{
						SetBusVolumeByName(actingBus.busName, busFadeInfo.StartVolume);
					}
					if (busFadeInfo.completionAction != null)
					{
						busFadeInfo.completionAction();
					}
				}
			}
			BusFades.RemoveAll((BusFadeInfo obj) => !obj.IsActive);
		}

		private void PerformGroupFades()
		{
			for (int i = 0; i < GroupFades.Count; i++)
			{
				GroupFadeInfo groupFadeInfo = GroupFades[i];
				if (!groupFadeInfo.IsActive)
				{
					continue;
				}
				MasterAudioGroup actingGroup = groupFadeInfo.ActingGroup;
				if (actingGroup == null)
				{
					groupFadeInfo.IsActive = false;
					continue;
				}
				float val = 1f - (groupFadeInfo.CompletionTime - AudioUtil.Time) / (groupFadeInfo.CompletionTime - groupFadeInfo.StartTime);
				val = Math.Min(val, 1f);
				val = Math.Max(val, 0f);
				float val2 = groupFadeInfo.StartVolume + (groupFadeInfo.TargetVolume - groupFadeInfo.StartVolume) * val;
				SetGroupVolume(volumeLevel: (!(groupFadeInfo.TargetVolume > groupFadeInfo.StartVolume)) ? Math.Max(val2, groupFadeInfo.TargetVolume) : Math.Min(val2, groupFadeInfo.TargetVolume), sType: actingGroup.GameObjectName);
				if (!(AudioUtil.Time < groupFadeInfo.CompletionTime))
				{
					groupFadeInfo.IsActive = false;
					if (groupFadeInfo.completionAction != null)
					{
						groupFadeInfo.completionAction();
					}
					if (stopZeroVolumeGroups && groupFadeInfo.TargetVolume == 0f)
					{
						StopAllOfSound(groupFadeInfo.NameOfGroup);
					}
					else if (groupFadeInfo.WillStopGroupAfterFade)
					{
						StopAllOfSound(groupFadeInfo.NameOfGroup);
					}
					if (groupFadeInfo.WillResetVolumeAfterFade)
					{
						SetGroupVolume(actingGroup.GameObjectName, groupFadeInfo.StartVolume);
					}
				}
			}
			GroupFades.RemoveAll((GroupFadeInfo obj) => !obj.IsActive);
		}

		private void PerformGroupPitchGlides()
		{
			for (int i = 0; i < GroupPitchGlides.Count; i++)
			{
				GroupPitchGlideInfo groupPitchGlideInfo = GroupPitchGlides[i];
				if (!groupPitchGlideInfo.IsActive)
				{
					continue;
				}
				MasterAudioGroup actingGroup = groupPitchGlideInfo.ActingGroup;
				if (actingGroup == null)
				{
					groupPitchGlideInfo.IsActive = false;
				}
				else if (!(AudioUtil.Time < groupPitchGlideInfo.CompletionTime))
				{
					groupPitchGlideInfo.IsActive = false;
					if (groupPitchGlideInfo.completionAction != null)
					{
						groupPitchGlideInfo.completionAction();
						groupPitchGlideInfo.completionAction = null;
					}
				}
			}
			GroupPitchGlides.RemoveAll((GroupPitchGlideInfo obj) => !obj.IsActive);
		}

		private void PerformBusPitchGlides()
		{
			for (int i = 0; i < BusPitchGlides.Count; i++)
			{
				BusPitchGlideInfo busPitchGlideInfo = BusPitchGlides[i];
				if (!busPitchGlideInfo.IsActive)
				{
					continue;
				}
				int busIndex = GetBusIndex(busPitchGlideInfo.NameOfBus, alertMissing: true);
				if (busIndex < 0)
				{
					busPitchGlideInfo.IsActive = false;
				}
				else if (!(AudioUtil.Time < busPitchGlideInfo.CompletionTime))
				{
					busPitchGlideInfo.IsActive = false;
					if (busPitchGlideInfo.completionAction != null)
					{
						busPitchGlideInfo.completionAction();
						busPitchGlideInfo.completionAction = null;
					}
				}
			}
			BusPitchGlides.RemoveAll((BusPitchGlideInfo obj) => !obj.IsActive);
		}

		private void OnApplicationQuit()
		{
			AppIsShuttingDown = true;
		}

		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				return false;
			}
			PlaySoundResult psr = PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, null, variationName, attachToSource: false, delaySoundTime);
			return PSRAsSuccessBool(psr);
		}

		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			if (!SceneHasMasterAudio)
			{
				return null;
			}
			if (SoundsReady)
			{
				return PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, null, variationName, attachToSource: false, delaySoundTime, useVector3: false, makePlaySoundResult: true, isChaining, isSingleSubscribedPlay);
			}
			UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
			return null;
		}

		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				return false;
			}
			PlaySoundResult psr = PlaySoundAtVolume(sType, volumePercentage, sourcePosition, timeToSchedulePlay, pitch, null, variationName, attachToSource: false, delaySoundTime, useVector3: true);
			return PSRAsSuccessBool(psr);
		}

		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return null;
			}
			if (SoundsReady)
			{
				return PlaySoundAtVolume(sType, volumePercentage, sourcePosition, timeToSchedulePlay, pitch, null, variationName, attachToSource: false, delaySoundTime, useVector3: true, makePlaySoundResult: true);
			}
			UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
			return null;
		}

		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				return false;
			}
			PlaySoundResult psr = PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, sourceTrans, variationName, attachToSource: false, delaySoundTime);
			return PSRAsSuccessBool(psr);
		}

		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			if (!SceneHasMasterAudio)
			{
				return null;
			}
			if (SoundsReady)
			{
				return PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, sourceTrans, variationName, attachToSource: false, delaySoundTime, useVector3: false, makePlaySoundResult: true, isChaining, isSingleSubscribedPlay);
			}
			UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
			return null;
		}

		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				return false;
			}
			PlaySoundResult psr = PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, sourceTrans, variationName, attachToSource: true, delaySoundTime);
			return PSRAsSuccessBool(psr);
		}

		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			if (!SceneHasMasterAudio)
			{
				return null;
			}
			if (SoundsReady)
			{
				return PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, sourceTrans, variationName, attachToSource: true, delaySoundTime, useVector3: false, makePlaySoundResult: true, isChaining, isSingleSubscribedPlay);
			}
			UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
			return null;
		}

		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, Action completedAction = null)
		{
			if (!SceneHasMasterAudio)
			{
				yield break;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				yield break;
			}
			PlaySoundResult sound = PlaySound(sType, volumePercentage, pitch, delaySoundTime, variationName, null, isChaining: false, isSingleSubscribedPlay: true);
			bool done = false;
			if (sound != null && !(sound.ActingVariation == null))
			{
				sound.ActingVariation.SoundFinished += delegate
				{
					done = true;
				};
				while (!done)
				{
					yield return EndOfFrameDelay;
				}
				completedAction?.Invoke();
			}
		}

		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, Action completedAction = null)
		{
			if (!SceneHasMasterAudio)
			{
				yield break;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				yield break;
			}
			PlaySoundResult sound = PlaySound3DAtTransform(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName, timeToSchedulePlay, isChaining: false, isSingleSubscribedPlay: true);
			bool done = false;
			if (sound != null && !(sound.ActingVariation == null))
			{
				sound.ActingVariation.SoundFinished += delegate
				{
					done = true;
				};
				while (!done)
				{
					yield return EndOfFrameDelay;
				}
				completedAction?.Invoke();
			}
		}

		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, Action completedAction = null)
		{
			if (!SceneHasMasterAudio)
			{
				yield break;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				yield break;
			}
			PlaySoundResult sound = PlaySound3DFollowTransform(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName, timeToSchedulePlay, isChaining: false, isSingleSubscribedPlay: true);
			bool done = false;
			if (sound != null && !(sound.ActingVariation == null))
			{
				sound.ActingVariation.SoundFinished += delegate
				{
					done = true;
				};
				while (!done)
				{
					yield return EndOfFrameDelay;
				}
				completedAction?.Invoke();
			}
		}

		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return psr != null && (psr.SoundPlayed || psr.SoundScheduled);
		}

		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, float? pitch = null, Transform sourceTrans = null, string variationName = null, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			if (!SceneHasMasterAudio)
			{
				return null;
			}
			if (!SoundsReady || sType == string.Empty || sType == "[None]")
			{
				return null;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				string text = "MasterAudio could not find sound: " + sType + ". If your Scene just changed, this could happen when an OnDisable or OnInvisible event sound happened to a per-scene sound, which is expected.";
				if (sourceTrans != null)
				{
					text = text + " Triggered by prefab: " + sourceTrans.name;
				}
				LogWarning(text);
				return null;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			MasterAudioGroup group = audioGroupInfo.Group;
			bool flag = LoggingEnabledForGroup(group);
			if (Instance.mixerMuted)
			{
				if (flag)
				{
					LogMessage("MasterAudio playing sound: " + sType + " silently because the Mixer is muted.");
				}
			}
			else if (group.isMuted && flag)
			{
				LogMessage("MasterAudio playing sound: " + sType + " silently because the Group is muted.");
			}
			if (Instance.SoloedGroups.Count > 0 && !Instance.SoloedGroups.Contains(group) && flag)
			{
				LogMessage("MasterAudio playing sound: " + sType + " silently because there are one or more Groups soloed. This one is not.");
			}
			audioGroupInfo.PlayedForWarming = IsWarming;
			if (group.curVariationMode == MasterAudioGroup.VariationMode.Normal)
			{
				switch (group.limitMode)
				{
				case MasterAudioGroup.LimitMode.TimeBased:
					if (group.minimumTimeBetween > 0f && Time.realtimeSinceStartup < audioGroupInfo.LastTimePlayed + group.minimumTimeBetween)
					{
						if (flag)
						{
							LogMessage("MasterAudio skipped playing sound: " + sType + " due to Group's Min Seconds Between setting.");
						}
						return null;
					}
					break;
				case MasterAudioGroup.LimitMode.FrameBased:
					if (Time.frameCount - audioGroupInfo.LastFramePlayed < group.limitPerXFrames)
					{
						if (flag)
						{
							LogMessage("Master Audio skipped playing sound: " + sType + " due to Group's Per Frame Limit.");
						}
						return null;
					}
					break;
				}
			}
			SetLastPlayed(audioGroupInfo);
			List<AudioInfo> sources = audioGroupInfo.Sources;
			bool flag2 = string.IsNullOrEmpty(variationName);
			if (sources.Count == 0)
			{
				if (flag)
				{
					LogMessage("Sound Group {" + sType + "} has no active Variations.");
				}
				return null;
			}
			if (group.curVariationMode == MasterAudioGroup.VariationMode.Normal && audioGroupInfo.Group.limitPolyphony)
			{
				int voiceLimitCount = audioGroupInfo.Group.voiceLimitCount;
				int num = 0;
				for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
				{
					if (audioGroupInfo.Sources[i].Source == null || !audioGroupInfo.Sources[i].Source.isPlaying)
					{
						continue;
					}
					num++;
					if (num >= voiceLimitCount)
					{
						if (flag || LogOutOfVoices)
						{
							LogMessage("Polyphony limit of group: " + audioGroupInfo.Group.GameObjectName + " exceeded. Will not play this sound for this instance.");
						}
						return null;
					}
				}
			}
			GroupBus busForGroup = audioGroupInfo.Group.BusForGroup;
			if (busForGroup != null && busForGroup.BusVoiceLimitReached)
			{
				if (!busForGroup.stopOldest)
				{
					if (flag || LogOutOfVoices)
					{
						LogMessage("Bus voice limit has been reached. Cannot play the sound: " + audioGroupInfo.Group.GameObjectName + " until one voice has stopped playing. You can turn on the 'Stop Oldest' option for the bus to change ");
					}
					return null;
				}
				StopOldestSoundOnBus(busForGroup);
			}
			AudioInfo audioInfo = null;
			bool isSingleVarLoop = false;
			if (sources.Count == 1)
			{
				if (flag)
				{
					LogMessage("Cueing only child of " + sType);
				}
				audioInfo = sources[0];
				if (group.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain)
				{
					isSingleVarLoop = true;
				}
			}
			List<int> list = null;
			int? randomIndex = null;
			List<int> list2 = null;
			int num2 = -1;
			if (audioInfo == null)
			{
				if (!Instance._randomizer.ContainsKey(sType))
				{
					UnityEngine.Debug.Log("Sound Group '" + sType + "' has no active Variations.");
					return null;
				}
				if (flag2)
				{
					list = Instance._randomizer[sType];
					randomIndex = 0;
					num2 = list[randomIndex.Value];
					audioInfo = sources[num2];
					list2 = Instance._randomizerLeftovers[sType];
					list2.Remove(num2);
					if (flag)
					{
						LogMessage($"Cueing child {list[randomIndex.Value]} of {sType}");
					}
				}
				else
				{
					bool flag3 = false;
					int num3 = 0;
					for (int j = 0; j < sources.Count; j++)
					{
						AudioInfo audioInfo2 = sources[j];
						if (!(audioInfo2.Source.name != variationName))
						{
							num3++;
							if (audioInfo2.Variation.IsAvailableToPlay)
							{
								audioInfo = audioInfo2;
								flag3 = true;
								num2 = j;
								break;
							}
						}
					}
					if (!flag3)
					{
						if (num3 == 0)
						{
							if (flag)
							{
								LogMessage("Can't find variation {" + variationName + "} of " + sType);
							}
						}
						else if (flag || LogOutOfVoices)
						{
							LogMessage("Can't find non-busy variation {" + variationName + "} of " + sType);
						}
						return null;
					}
					if (flag)
					{
						LogMessage($"Cueing child named '{variationName}' of {sType}");
					}
				}
			}
			if (audioInfo.Variation == null)
			{
				if (AppIsShuttingDown || audioInfo.Source == null)
				{
					return null;
				}
				SoundGroupVariation component = audioInfo.Source.GetComponent<SoundGroupVariation>();
				if (component == null)
				{
					return null;
				}
				audioInfo.Variation = component;
			}
			if (audioInfo.Variation.audLocation == AudioLocation.Clip && audioInfo.Variation.VarAudio.clip == null)
			{
				if (flag)
				{
					LogMessage($"Child named '{audioInfo.Variation.name}' of {sType} has no audio assigned to it so nothing will be played.");
				}
				RemoveClipAndRefillIfEmpty(audioGroupInfo, flag2, randomIndex, list, sType, num2, flag, isSingleVarLoop: false);
				MaybeChainNextVar(isChaining, audioInfo.Variation, volumePercentage, pitch, sourceTrans, attachToSource);
				return null;
			}
			if (audioInfo.Variation.probabilityToPlay < 100 && UnityEngine.Random.Range(0, 100) >= audioInfo.Variation.probabilityToPlay)
			{
				if (flag)
				{
					LogMessage($"Child named '{audioInfo.Variation.name}' of {sType} failed its Random number check for 'Probability to Play' to it so nothing will be played this time.");
				}
				RemoveClipAndRefillIfEmpty(audioGroupInfo, flag2, randomIndex, list, sType, num2, flag, isSingleVarLoop: false);
				MaybeChainNextVar(isChaining, audioInfo.Variation, volumePercentage, pitch, sourceTrans, attachToSource);
				return null;
			}
			if (audioGroupInfo.Group.curVariationMode == MasterAudioGroup.VariationMode.Dialog)
			{
				if (audioGroupInfo.Group.useDialogFadeOut)
				{
					FadeOutAllOfSound(audioGroupInfo.Group.GameObjectName, audioGroupInfo.Group.dialogFadeOutTime);
				}
				else
				{
					StopAllOfSound(audioGroupInfo.Group.GameObjectName);
				}
			}
			bool flag4 = false;
			bool forgetSoundPlayed = false;
			bool flag5 = false;
			bool flag6;
			PlaySoundResult playSoundResult;
			bool flag9;
			do
			{
				flag6 = false;
				playSoundResult = PlaySoundIfAvailable(audioInfo, sourcePosition, volumePercentage, ref forgetSoundPlayed, pitch, audioGroupInfo, sourceTrans, attachToSource, delaySoundTime, useVector3, makePlaySoundResult, timeToSchedulePlay, isChaining, isSingleSubscribedPlay);
				bool flag7 = makePlaySoundResult && playSoundResult != null && (playSoundResult.SoundPlayed || playSoundResult.SoundScheduled);
				bool flag8 = !makePlaySoundResult && forgetSoundPlayed;
				flag9 = flag7 || flag8;
				if (flag9)
				{
					flag4 = true;
					if (!IsWarming)
					{
						RemoveClipAndRefillIfEmpty(audioGroupInfo, flag2, randomIndex, list, sType, num2, flag, isSingleVarLoop);
					}
				}
				else if (flag2)
				{
					if (list2 == null)
					{
						continue;
					}
					if (list2.Count <= 0)
					{
						if (flag5)
						{
							continue;
						}
						RefillSoundGroupPool(sType);
						flag5 = true;
						list2.Clear();
						list2.AddRange(list);
					}
					audioInfo = sources[list2[0]];
					if (audioInfo.Variation == null)
					{
						SoundGroupVariation component2 = audioInfo.Source.GetComponent<SoundGroupVariation>();
						if (component2 == null)
						{
							break;
						}
						audioInfo.Variation = component2;
					}
					if (flag)
					{
						LogMessage("Child was busy. Cueing child {" + audioInfo.Source.name + "} of " + sType);
					}
					list2.RemoveAt(0);
					if (flag5 && list2.Count == 0)
					{
						flag6 = true;
					}
				}
				else
				{
					if (flag)
					{
						LogMessage("Child was busy. Since you wanted a named Variation, no others to try. Aborting.");
					}
					list2?.Clear();
				}
			}
			while (!flag4 && list2 != null && (list2.Count > 0 || !flag5 || flag6));
			if (!flag9)
			{
				if (flag || LogOutOfVoices)
				{
					LogMessage("All children of " + sType + " were busy. Will not play this sound for this instance.");
				}
			}
			else
			{
				if (!triggeredAsChildGroup && !IsWarming)
				{
					switch (audioGroupInfo.Group.linkedStartGroupSelectionType)
					{
					case LinkedGroupSelectionType.All:
					{
						for (int k = 0; k < audioGroupInfo.Group.childSoundGroups.Count; k++)
						{
							string sType3 = audioGroupInfo.Group.childSoundGroups[k];
							PlaySoundAtVolume(sType3, volumePercentage, sourcePosition, timeToSchedulePlay, pitch, sourceTrans, null, attachToSource, delaySoundTime, useVector3, makePlaySoundResult: false, isChaining: false, isSingleSubscribedPlay: false, triggeredAsChildGroup: true);
						}
						break;
					}
					case LinkedGroupSelectionType.OneAtRandom:
					{
						int index = UnityEngine.Random.Range(0, audioGroupInfo.Group.childSoundGroups.Count);
						string sType2 = audioGroupInfo.Group.childSoundGroups[index];
						PlaySoundAtVolume(sType2, volumePercentage, sourcePosition, timeToSchedulePlay, pitch, sourceTrans, null, attachToSource, delaySoundTime, useVector3, makePlaySoundResult: false, isChaining: false, isSingleSubscribedPlay: false, triggeredAsChildGroup: true);
						break;
					}
					}
				}
				if (audioGroupInfo.Group.soundPlayedEventActive)
				{
					FireCustomEvent(audioGroupInfo.Group.soundPlayedCustomEvent, Instance._trans);
				}
			}
			if (!makePlaySoundResult && flag9)
			{
				return AndForgetSuccessResult;
			}
			return playSoundResult;
		}

		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
			if (isChaining)
			{
				variation.DoNextChain(volumePercentage, pitch, sourceTrans, attachToSource);
			}
		}

		private static void SetLastPlayed(AudioGroupInfo grp)
		{
			grp.LastTimePlayed = AudioUtil.Time;
			grp.LastFramePlayed = AudioUtil.FrameCount;
		}

		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
			if (isSingleVarLoop)
			{
				grp.Group.ChainLoopCount++;
				return;
			}
			if (isNonSpecific && randomIndex.HasValue)
			{
				choices.RemoveAt(randomIndex.Value);
				Instance._clipsPlayedBySoundTypeOldestFirst[sType].Add(pickedChoice);
				if (choices.Count == 0)
				{
					if (loggingEnabledForGrp)
					{
						LogMessage("Refilling Variation pool: " + sType);
					}
					RefillSoundGroupPool(sType);
				}
			}
			if (grp.Group.curVariationSequence == MasterAudioGroup.VariationSequence.TopToBottom && grp.Group.useInactivePeriodPoolRefill)
			{
				UpdateRefillTime(sType, grp.Group.inactivePeriodSeconds);
			}
		}

		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, float? pitch = null, AudioGroupInfo audioGroup = null, Transform sourceTrans = null, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, double? timeToSchedulePlay = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			if (info.Source == null)
			{
				return null;
			}
			MasterAudioGroup group = audioGroup.Group;
			if (group.curVariationMode == MasterAudioGroup.VariationMode.Normal && info.Source.isPlaying)
			{
				float audioPlayedPercentage = AudioUtil.GetAudioPlayedPercentage(info.Source);
				int retriggerPercentage = group.retriggerPercentage;
				if (audioPlayedPercentage < (float)retriggerPercentage)
				{
					return null;
				}
			}
			info.Variation.Stop(stopEndDetection: false, skipLinked: true);
			info.Variation.ObjectToFollow = null;
			bool flag = Instance.prioritizeOnDistance && (Instance.useClipAgePriority || info.Variation.ParentGroup.useClipAgePriority);
			if (useVector3)
			{
				info.Source.transform.position = sourcePosition;
				if (Instance.prioritizeOnDistance)
				{
					AudioPrioritizer.Set3DPriority(info.Variation, flag);
				}
			}
			else if (sourceTrans != null)
			{
				if (attachToSource)
				{
					info.Variation.ObjectToFollow = sourceTrans;
				}
				else
				{
					info.Source.transform.position = sourceTrans.position;
					info.Variation.ObjectToTriggerFrom = sourceTrans;
				}
				if (Instance.prioritizeOnDistance)
				{
					AudioPrioritizer.Set3DPriority(info.Variation, flag);
				}
			}
			else
			{
				if (Instance.prioritizeOnDistance)
				{
					AudioPrioritizer.Set2DSoundPriority(info.Source);
				}
				info.Source.transform.localPosition = Vector3.zero;
			}
			float groupMasterVolume = group.groupMasterVolume;
			float busVolume = GetBusVolume(group);
			float num = info.OriginalVolume;
			float num2 = 0f;
			if (info.Variation.useRandomVolume)
			{
				num2 = UnityEngine.Random.Range(info.Variation.randomVolumeMin, info.Variation.randomVolumeMax);
				switch (info.Variation.randomVolumeMode)
				{
				case SoundGroupVariation.RandomVolumeMode.AddToClipVolume:
					num += num2;
					break;
				case SoundGroupVariation.RandomVolumeMode.IgnoreClipVolume:
					num = num2;
					break;
				}
			}
			float num3 = num * groupMasterVolume * busVolume * Instance._masterAudioVolume;
			float num4 = num3 * volumePercentage;
			float num5 = num4;
			info.Source.volume = num5;
			info.LastPercentageVolume = volumePercentage;
			info.LastRandomVolume = num2;
			if (!info.Variation.GameObj.activeInHierarchy)
			{
				return null;
			}
			PlaySoundResult playSoundResult = null;
			if (makePlaySoundResult)
			{
				PlaySoundResult playSoundResult2 = new PlaySoundResult();
				playSoundResult2.ActingVariation = info.Variation;
				playSoundResult = playSoundResult2;
				if (delaySoundTime > 0f)
				{
					playSoundResult.SoundScheduled = true;
				}
				else
				{
					playSoundResult.SoundPlayed = true;
				}
			}
			else
			{
				forgetSoundPlayed = true;
			}
			string gameObjectName = group.GameObjectName;
			if (group.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain)
			{
				if (!isChaining)
				{
					group.ChainLoopCount = 0;
				}
				Transform objectToFollow = info.Variation.ObjectToFollow;
				if (group.ActiveVoices > 0 && !isChaining)
				{
					StopAllOfSound(gameObjectName);
				}
				info.Variation.ObjectToFollow = objectToFollow;
			}
			info.Variation.Play(pitch, num5, gameObjectName, volumePercentage, num3, pitch, sourceTrans, attachToSource, delaySoundTime, timeToSchedulePlay, isChaining, isSingleSubscribedPlay);
			if (Instance._isStoppingMultiple)
			{
				Instance.VariationsStartedDuringMultiStop.Add(info.Variation);
			}
			return playSoundResult;
		}

		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
			MasterAudio instance = Instance;
			if (instance.EnableMusicDucking && instance.duckingBySoundType.ContainsKey(soundGroupName) && !(aSource.clip == null))
			{
				DuckGroupInfo duckGroupInfo = instance.duckingBySoundType[soundGroupName];
				float length = aSource.clip.length;
				float pitch = aSource.pitch;
				List<PlaylistController> instances = PlaylistController.Instances;
				for (int i = 0; i < instances.Count; i++)
				{
					instances[i].DuckMusicForTime(length, duckGroupInfo.unduckTime, pitch, duckGroupInfo.riseVolStart, duckGroupInfo.duckedVolumeCut);
				}
			}
		}

		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
			MasterAudioGroup masterAudioGroup = null;
			for (int i = 0; i < varList.Count; i++)
			{
				SoundGroupVariation variation = varList[i].Variation;
				if (!variation.WasTriggeredFromTransform(trans))
				{
					continue;
				}
				if (masterAudioGroup == null)
				{
					string gameObjectName = variation.ParentGroup.GameObjectName;
					masterAudioGroup = GrabGroup(gameObjectName);
				}
				bool stopEndDetection = masterAudioGroup != null && masterAudioGroup.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain;
				switch (varCmd)
				{
				case VariationCommand.Stop:
					variation.Stop(stopEndDetection);
					break;
				case VariationCommand.Pause:
					variation.Pause();
					break;
				case VariationCommand.Unpause:
					if (AudioUtil.IsAudioPaused(variation.VarAudio))
					{
						variation.VarAudio.Play();
					}
					break;
				}
			}
		}

		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			Instance.VariationsStartedDuringMultiStop.Clear();
			Instance._isStoppingMultiple = true;
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Stop);
			}
			Instance._isStoppingMultiple = false;
		}

		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
			if (SceneHasMasterAudio)
			{
				if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
				{
					UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
					return;
				}
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Stop);
			}
		}

		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Pause);
			}
		}

		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
			if (SceneHasMasterAudio)
			{
				if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
				{
					UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
					return;
				}
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Pause);
			}
		}

		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Unpause);
			}
		}

		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
			if (SceneHasMasterAudio)
			{
				if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
				{
					UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
					return;
				}
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Unpause);
			}
		}

		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			List<SoundGroupVariation> allPlayingVariationsOfTransform = GetAllPlayingVariationsOfTransform(sourceTrans);
			HashSet<string> hashSet = new HashSet<string>();
			for (int i = 0; i < allPlayingVariationsOfTransform.Count; i++)
			{
				string text = allPlayingVariationsOfTransform[i].ParentGroup.name;
				if (!hashSet.Contains(text))
				{
					hashSet.Add(text);
					FadeOutSoundGroupOfTransform(sourceTrans, text, fadeTime);
				}
			}
		}

		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			for (int i = 0; i < sources.Count; i++)
			{
				SoundGroupVariation variation = sources[i].Variation;
				if (variation.WasTriggeredFromTransform(sourceTrans))
				{
					variation.FadeOutNow(fadeTime);
				}
			}
		}

		public static void StopAllOfSound(string sType)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			bool stopEndDetection = masterAudioGroup != null && masterAudioGroup.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain;
			foreach (AudioInfo item in sources)
			{
				if (!(item.Variation == null) && !IsLinkedGroupPlay(item.Variation))
				{
					item.Variation.Stop(stopEndDetection);
				}
			}
		}

		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			foreach (AudioInfo item in sources)
			{
				item.Variation.FadeOutNow(fadeTime);
			}
		}

		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(32);
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					SoundGroupVariation variation = sources[i].Variation;
					if (variation.IsPlaying)
					{
						list.Add(variation);
					}
				}
			}
			return list;
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(32);
			if (!SceneHasMasterAudio)
			{
				return list;
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					SoundGroupVariation variation = sources[i].Variation;
					if (variation.WasTriggeredFromTransform(sourceTrans))
					{
						list.Add(variation);
					}
				}
			}
			return list;
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(32);
			if (!SceneHasMasterAudio)
			{
				return list;
			}
			HashSet<Transform> hashSet = new HashSet<Transform>();
			for (int i = 0; i < sourceTransList.Count; i++)
			{
				hashSet.Add(sourceTransList[i]);
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				for (int j = 0; j < sources.Count; j++)
				{
					SoundGroupVariation variation = sources[j].Variation;
					if (variation.WasTriggeredFromAnyOfTransformMap(hashSet))
					{
						list.Add(variation);
					}
				}
			}
			return list;
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(32);
			int busIndex = GetBusIndex(busName, alertMissing: false);
			if (busIndex < 0)
			{
				return list;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex != busIndex)
				{
					continue;
				}
				for (int i = 0; i < value.Sources.Count; i++)
				{
					SoundGroupVariation variation = value.Sources[i].Variation;
					if (variation.IsPlaying)
					{
						list.Add(variation);
					}
				}
			}
			return list;
		}

		public static void DeleteGroupVariation(string sType, string variationName)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot delete Variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			List<AudioInfo> list = new List<AudioInfo>();
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				if (!(audioInfo.Variation.name != variationName))
				{
					list.Add(audioInfo);
				}
			}
			if (list.Count == 0)
			{
				LogWarning("Could not find Variation for '" + sType + "' Group named '" + variationName + "'.\nWill not delete any Variations.");
				return;
			}
			for (int j = 0; j < list.Count; j++)
			{
				AudioInfo audioInfo2 = list[j];
				SoundGroupVariation variation = audioInfo2.Variation;
				variation.Stop();
				variation.DisableUpdater();
				if (variation.audLocation == AudioLocation.ResourceFile)
				{
					string clipName = ((!(variation.VarAudio.clip == null)) ? variation.VarAudio.clip.name : string.Empty);
					AudioResourceOptimizer.DeleteAudioSourceFromList(clipName, variation.VarAudio);
				}
				int num = audioGroupInfo.Sources.IndexOf(audioInfo2);
				if (num >= 0)
				{
					Instance._randomizer[sType].Remove(num);
					for (int k = 0; k < Instance._randomizer[sType].Count; k++)
					{
						if (Instance._randomizer[sType][k] > num)
						{
							Instance._randomizer[sType][k]--;
						}
					}
					Instance._randomizerOrigin[sType].Remove(num);
					for (int l = 0; l < Instance._randomizerOrigin[sType].Count; l++)
					{
						if (Instance._randomizerOrigin[sType][l] > num)
						{
							Instance._randomizerOrigin[sType][l]--;
						}
					}
					Instance._randomizerLeftovers[sType].Remove(num);
					for (int m = 0; m < Instance._randomizerLeftovers[sType].Count; m++)
					{
						if (Instance._randomizerLeftovers[sType][m] > num)
						{
							Instance._randomizerLeftovers[sType][m]--;
						}
					}
					Instance._clipsPlayedBySoundTypeOldestFirst[sType].Remove(num);
					audioGroupInfo.Sources.RemoveAt(num);
				}
				Instance.OcclusionSourcesInRange.Remove(variation.GameObj);
				Instance.OcclusionSourcesOutOfRange.Remove(variation.GameObj);
				Instance.OcclusionSourcesBlocked.Remove(variation.GameObj);
				RemoveFromOcclusionFrequencyTransitioning(variation);
				Instance.AllAudioSources.Remove(variation.VarAudio);
				UnityEngine.Object.Destroy(variation.GameObj);
			}
		}

		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot create change variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			bool flag = false;
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				if (!(audioInfo.Variation.name != variationName))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				LogWarning("You already have a Variation for this Group named '" + variationName + "'. \n\nPlease rename these Variations when finished to be unique, or you may not be able to play them by name if you have a need to.");
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(Instance.soundGroupVariationTemplate.gameObject, audioGroupInfo.Group.transform.position, Quaternion.identity);
			gameObject.transform.name = variationName;
			gameObject.transform.parent = audioGroupInfo.Group.transform;
			AudioSource component = gameObject.GetComponent<AudioSource>();
			component.clip = clip;
			component.pitch = pitch;
			Instance.AllAudioSources.Add(component);
			SoundGroupVariation component2 = gameObject.GetComponent<SoundGroupVariation>();
			component2.DisableUpdater();
			AudioInfo item = new AudioInfo(component2, component2.VarAudio, volume);
			audioGroupInfo.Sources.Add(item);
			if (Instance._randomizer.ContainsKey(sType))
			{
				int item2 = audioGroupInfo.Sources.Count - 1;
				Instance._randomizer[sType].Add(item2);
				Instance._randomizerOrigin[sType].Add(item2);
				Instance._randomizerLeftovers[sType].Add(audioGroupInfo.Sources.Count - 1);
			}
		}

		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot change variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			int num = 0;
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				if (changeAllVariations || !(audioInfo.Source.transform.name != variationName))
				{
					audioInfo.Variation.original_pitch = pitch;
					AudioSource varAudio = audioInfo.Variation.VarAudio;
					if (varAudio != null)
					{
						varAudio.pitch = pitch;
					}
					num++;
				}
			}
			if (num == 0 && !changeAllVariations)
			{
				UnityEngine.Debug.Log("Could not find any matching variations of Sound Group '" + sType + "' to change the pitch of.");
			}
		}

		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot change variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			int num = 0;
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				if (changeAllVariations || !(audioInfo.Source.transform.name != variationName))
				{
					audioInfo.OriginalVolume = volume;
					num++;
				}
			}
			if (num == 0 && !changeAllVariations)
			{
				UnityEngine.Debug.Log("Could not find any matching variations of Sound Group '" + sType + "' to change the volume of.");
			}
		}

		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot create change variation clip yet.");
				return;
			}
			AudioClip audioClip = Resources.Load(resourceFileName) as AudioClip;
			if (audioClip == null)
			{
				LogWarning("Resource file '" + resourceFileName + "' could not be located.");
			}
			else
			{
				ChangeVariationClip(sType, changeAllVariations, variationName, audioClip);
			}
		}

		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot create change variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				if (changeAllVariations || audioInfo.Source.transform.name == variationName)
				{
					if (audioInfo.Variation.IsPlaying)
					{
						audioInfo.Variation.Stop();
					}
					audioInfo.Source.clip = clip;
				}
			}
		}

		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
			if (IsOcclusionFreqencyTransitioning(variation))
			{
				LogWarning("Occlusion is already fading for: " + variation.name + ". This is a bug.");
				return;
			}
			OcclusionFreqChangeInfo occlusionFreqChangeInfo = new OcclusionFreqChangeInfo();
			occlusionFreqChangeInfo.ActingVariation = variation;
			occlusionFreqChangeInfo.CompletionTime = Time.realtimeSinceStartup + fadeTime;
			occlusionFreqChangeInfo.IsActive = true;
			occlusionFreqChangeInfo.StartFrequency = variation.LowPassFilter.cutoffFrequency;
			occlusionFreqChangeInfo.StartTime = Time.realtimeSinceStartup;
			occlusionFreqChangeInfo.TargetFrequency = newCutoffFreq;
			OcclusionFreqChangeInfo item = occlusionFreqChangeInfo;
			Instance.VariationOcclusionFreqChanges.Add(item);
		}

		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, logIfMissing: false);
			if (masterAudioGroup == null || AppIsShuttingDown)
			{
				return null;
			}
			if (masterAudioGroup.curVariationSequence == MasterAudioGroup.VariationSequence.Randomized)
			{
				UnityEngine.Debug.LogWarning("Cannot determine the next Variation of randomly sequenced Sound Group '" + sType + "'.");
				return null;
			}
			if (!Instance._randomizer.ContainsKey(sType))
			{
				UnityEngine.Debug.Log("Sound Group '" + sType + "' has no active Variations.");
				return null;
			}
			List<int> list = Instance._randomizer[sType];
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			AudioInfo audioInfo = audioGroupInfo.Sources[list[0]];
			return audioInfo.Source;
		}

		public static bool IsSoundGroupPlaying(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, logIfMissing: false);
			if (masterAudioGroup == null || AppIsShuttingDown)
			{
				return false;
			}
			return masterAudioGroup.ActiveVoices > 0;
		}

		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return false;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			for (int i = 0; i < sources.Count; i++)
			{
				SoundGroupVariation variation = sources[i].Variation;
				if (variation.WasTriggeredFromTransform(sourceTrans))
				{
					return true;
				}
			}
			return false;
		}

		public static void RouteGroupToBus(string sType, string busName)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				LogError("Could not find Sound Group '" + sType + "'");
				return;
			}
			int num = 0;
			if (busName != null)
			{
				int num2 = GroupBuses.FindIndex((GroupBus x) => x.busName == busName);
				if (num2 < 0)
				{
					LogError("Could not find bus '" + busName + "' to assign to Sound Group '" + sType + "'");
					return;
				}
				num = 2 + num2;
			}
			GroupBus busByIndex = GetBusByIndex(masterAudioGroup.busIndex);
			masterAudioGroup.busIndex = num;
			GroupBus groupBus = null;
			bool flag = false;
			if (num > 0)
			{
				groupBus = GroupBuses.Find((GroupBus x) => x.busName == busName);
				if (groupBus.isMuted)
				{
					MuteGroup(masterAudioGroup.name, shouldCheckMuteStatus: false);
					flag = true;
				}
				else if (groupBus.isSoloed)
				{
					SoloGroup(masterAudioGroup.name, shouldCheckMuteStatus: false);
					flag = true;
				}
			}
			bool flag2 = false;
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			for (int i = 0; i < sources.Count; i++)
			{
				SoundGroupVariation variation = sources[i].Variation;
				variation.SetMixerGroup();
				variation.SetSpatialBlend();
				if (variation.IsPlaying)
				{
					groupBus?.AddActiveAudioSourceId(variation.InstanceId);
					busByIndex?.RemoveActiveAudioSourceId(variation.InstanceId);
					flag2 = true;
				}
			}
			if (flag2)
			{
				SetBusVolume(groupBus, groupBus?.volume ?? 0f);
			}
			if (Application.isPlaying && flag)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static float GetVariationLength(string sType, string variationName)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return -1f;
			}
			SoundGroupVariation soundGroupVariation = null;
			foreach (SoundGroupVariation groupVariation in masterAudioGroup.groupVariations)
			{
				if (groupVariation.name != variationName)
				{
					continue;
				}
				soundGroupVariation = groupVariation;
				break;
			}
			if (soundGroupVariation == null)
			{
				LogError("Could not find Variation '" + variationName + "' in Sound Group '" + sType + "'.");
				return -1f;
			}
			if (soundGroupVariation.audLocation == AudioLocation.ResourceFile)
			{
				LogError("Variation '" + variationName + "' in Sound Group '" + sType + "' length cannot be determined because it's a Resource Files.");
				return -1f;
			}
			if (soundGroupVariation.audLocation == AudioLocation.FileOnInternet)
			{
				LogError("Variation '" + variationName + "' in Sound Group '" + sType + "' length cannot be determined because it's an Internet File.");
				return -1f;
			}
			AudioClip clip = soundGroupVariation.VarAudio.clip;
			if (clip == null)
			{
				LogError("Variation '" + variationName + "' in Sound Group '" + sType + "' has no Audio Clip.");
				return -1f;
			}
			if (!(soundGroupVariation.VarAudio.pitch <= 0f))
			{
				return AudioUtil.AdjustAudioClipDurationForPitch(clip.length, soundGroupVariation.VarAudio);
			}
			LogError("Variation '" + variationName + "' in Sound Group '" + sType + "' has negative or zero pitch. Cannot compute length.");
			return -1f;
		}

		public static void RefillSoundGroupPool(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, logIfMissing: false);
			if (masterAudioGroup == null)
			{
				return;
			}
			List<int> list = Instance._randomizer[sType];
			List<int> list2 = Instance._clipsPlayedBySoundTypeOldestFirst[sType];
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					int item = list[i];
					if (!list2.Contains(item))
					{
						list2.Add(item);
					}
				}
			}
			List<int> list3 = Instance._randomizerOrigin[sType];
			if (list2.Count < list3.Count)
			{
				for (int j = 0; j < list3.Count; j++)
				{
					int item2 = list3[j];
					if (!list2.Contains(item2))
					{
						list2.Add(item2);
					}
				}
			}
			list.Clear();
			if (masterAudioGroup.curVariationSequence == MasterAudioGroup.VariationSequence.Randomized)
			{
				int? num = null;
				if (masterAudioGroup.UsesNoRepeat && list2.Count > 0)
				{
					num = list2[list2.Count - 1];
				}
				ArrayListUtil.SortIntArray(ref list2);
				if (num.HasValue && num.Value == list2[0])
				{
					int item3 = list2[0];
					list2.RemoveAt(0);
					list2.Insert(UnityEngine.Random.Range(1, list2.Count), item3);
				}
			}
			list.AddRange(list2);
			Instance._randomizerLeftovers[sType].AddRange(list2);
			list2.Clear();
			if (masterAudioGroup.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain)
			{
				masterAudioGroup.ChainLoopCount++;
			}
		}

		public static bool SoundGroupExists(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, logIfMissing: false);
			return masterAudioGroup != null;
		}

		public static void PauseSoundGroup(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					SoundGroupVariation variation = sources[i].Variation;
					variation.Pause();
				}
			}
		}

		public static void SetGroupSpatialBlend(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					SoundGroupVariation variation = sources[i].Variation;
					variation.SetSpatialBlend();
				}
			}
		}

		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
			if (!Application.isPlaying)
			{
				return;
			}
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, logIfMissing: false);
			if (!(masterAudioGroup == null))
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					SoundGroupVariation variation = sources[i].Variation;
					variation.VarAudio.outputAudioMixerGroup = mixerGroup;
				}
			}
		}

		public static void UnpauseSoundGroup(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			for (int i = 0; i < sources.Count; i++)
			{
				SoundGroupVariation variation = sources[i].Variation;
				if (AudioUtil.IsAudioPaused(variation.VarAudio))
				{
					variation.VarAudio.Play();
					if (variation.VariationUpdater != null)
					{
						variation.VariationUpdater.enabled = true;
						variation.VariationUpdater.Unpause();
					}
				}
			}
		}

		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, Action completionCallback = null, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
			if (newVolume < 0f || newVolume > 1f)
			{
				UnityEngine.Debug.LogError("Illegal volume passed to FadeSoundGroupToVolume: '" + newVolume + "'. Legal volumes are between 0 and 1");
				return;
			}
			if (fadeTime <= 0.1f)
			{
				SetGroupVolume(sType, newVolume);
				completionCallback?.Invoke();
				if (willStopAfterFade)
				{
					StopAllOfSound(sType);
				}
				return;
			}
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return;
			}
			if (newVolume < 0f || newVolume > 1f)
			{
				UnityEngine.Debug.Log("Cannot fade Sound Group '" + sType + "'. Invalid volume specified. Volume should be between 0 and 1.");
				return;
			}
			GroupFadeInfo groupFadeInfo = Instance.GroupFades.Find((GroupFadeInfo obj) => obj.NameOfGroup == sType);
			if (groupFadeInfo != null)
			{
				groupFadeInfo.IsActive = false;
			}
			GroupFadeInfo groupFadeInfo2 = new GroupFadeInfo();
			groupFadeInfo2.NameOfGroup = sType;
			groupFadeInfo2.ActingGroup = masterAudioGroup;
			groupFadeInfo2.StartTime = AudioUtil.Time;
			groupFadeInfo2.CompletionTime = AudioUtil.Time + fadeTime;
			groupFadeInfo2.StartVolume = masterAudioGroup.groupMasterVolume;
			groupFadeInfo2.TargetVolume = newVolume;
			groupFadeInfo2.WillStopGroupAfterFade = willStopAfterFade;
			groupFadeInfo2.WillResetVolumeAfterFade = willResetVolumeAfterFade;
			GroupFadeInfo groupFadeInfo3 = groupFadeInfo2;
			if (completionCallback != null)
			{
				groupFadeInfo3.completionAction = completionCallback;
			}
			Instance.GroupFades.Add(groupFadeInfo3);
		}

		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, Action completionCallback = null)
		{
			if (pitchAddition < -3f || pitchAddition > 3f)
			{
				UnityEngine.Debug.LogError("Illegal pitch passed to GlideSoundGroupByPitch: '" + pitchAddition + "'. Legal pitches are between -3 and 3");
				return;
			}
			if (pitchAddition == 0f)
			{
				completionCallback?.Invoke();
				return;
			}
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return;
			}
			GroupPitchGlideInfo groupPitchGlideInfo = Instance.GroupPitchGlides.Find((GroupPitchGlideInfo obj) => obj.NameOfGroup == sType);
			if (groupPitchGlideInfo != null)
			{
				groupPitchGlideInfo.IsActive = false;
				if (groupPitchGlideInfo.completionAction != null)
				{
					groupPitchGlideInfo.completionAction();
				}
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			if (glideTime <= 0.1f)
			{
				for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
				{
					SoundGroupVariation variation = audioGroupInfo.Sources[i].Variation;
					variation.GlideByPitch(pitchAddition, 0f);
				}
				completionCallback?.Invoke();
				return;
			}
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(audioGroupInfo.Sources.Count);
			for (int j = 0; j < audioGroupInfo.Sources.Count; j++)
			{
				SoundGroupVariation variation2 = audioGroupInfo.Sources[j].Variation;
				if (variation2.IsPlaying)
				{
					if (variation2.curPitchMode == SoundGroupVariation.PitchMode.Gliding)
					{
						variation2.VariationUpdater.StopPitchGliding();
					}
					variation2.GlideByPitch(pitchAddition, glideTime);
					list.Add(variation2);
				}
			}
			if (list.Count == 0 || completionCallback == null)
			{
				completionCallback?.Invoke();
				return;
			}
			GroupPitchGlideInfo groupPitchGlideInfo2 = new GroupPitchGlideInfo();
			groupPitchGlideInfo2.NameOfGroup = sType;
			groupPitchGlideInfo2.ActingGroup = masterAudioGroup;
			groupPitchGlideInfo2.CompletionTime = AudioUtil.Time + glideTime;
			groupPitchGlideInfo2.GlidingVariations = list;
			GroupPitchGlideInfo groupPitchGlideInfo3 = groupPitchGlideInfo2;
			if (completionCallback != null)
			{
				groupPitchGlideInfo3.completionAction = completionCallback;
			}
			Instance.GroupPitchGlides.Add(groupPitchGlideInfo3);
		}

		public static void DeleteSoundGroup(string sType)
		{
			if (SafeInstance == null)
			{
				return;
			}
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return;
			}
			StopAllOfSound(sType);
			Transform transform = masterAudioGroup.transform;
			MasterAudio instance = Instance;
			if (instance.duckingBySoundType.ContainsKey(sType))
			{
				instance.duckingBySoundType.Remove(sType);
			}
			Instance._randomizer.Remove(sType);
			Instance._randomizerLeftovers.Remove(sType);
			Instance._randomizerOrigin.Remove(sType);
			Instance._clipsPlayedBySoundTypeOldestFirst.Remove(sType);
			RemoveRuntimeGroupInfo(sType);
			Instance.LastTimeSoundGroupPlayed.Remove(sType);
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				AudioSource component = child.GetComponent<AudioSource>();
				SoundGroupVariation component2 = child.GetComponent<SoundGroupVariation>();
				switch (component2.audLocation)
				{
				case AudioLocation.ResourceFile:
					AudioResourceOptimizer.DeleteAudioSourceFromList(AudioResourceOptimizer.GetLocalizedFileName(component2.useLocalization, component2.resourceFileName), component);
					break;
				case AudioLocation.FileOnInternet:
					AudioResourceOptimizer.DeleteAudioSourceFromList(component2.internetFileUrl, component);
					break;
				}
			}
			transform.parent = null;
			UnityEngine.Object.Destroy(transform.gameObject);
			RescanGroupsNow();
		}

		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			if (!SceneHasMasterAudio)
			{
				return null;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot create new group yet.");
				return null;
			}
			string text = aGroup.transform.name;
			MasterAudio instance = Instance;
			if (Instance.Trans.GetChildTransform(text) != null)
			{
				if (errorOnExisting)
				{
					UnityEngine.Debug.LogError("Cannot add a new Sound Group named '" + text + "' because there is already a Sound Group of that name.");
				}
				return null;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(instance.soundGroupTemplate.gameObject, instance.Trans.position, Quaternion.identity);
			Transform transform = gameObject.transform;
			transform.name = UtilStrings.TrimSpace(text);
			transform.parent = Instance.Trans;
			transform.gameObject.layer = Instance.gameObject.layer;
			for (int i = 0; i < aGroup.groupVariations.Count; i++)
			{
				DynamicGroupVariation dynamicGroupVariation = aGroup.groupVariations[i];
				for (int j = 0; j < dynamicGroupVariation.weight; j++)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(dynamicGroupVariation.gameObject, transform.position, Quaternion.identity);
					gameObject2.transform.parent = transform;
					gameObject2.transform.gameObject.layer = transform.gameObject.layer;
					UnityEngine.Object.Destroy(gameObject2.GetComponent<DynamicGroupVariation>());
					gameObject2.AddComponent<SoundGroupVariation>();
					SoundGroupVariation component = gameObject2.GetComponent<SoundGroupVariation>();
					string text2 = component.name;
					int num = text2.IndexOf("(Clone)");
					if (num >= 0)
					{
						text2 = text2.Substring(0, num);
					}
					AudioSource component2 = dynamicGroupVariation.GetComponent<AudioSource>();
					switch (dynamicGroupVariation.audLocation)
					{
					case AudioLocation.Clip:
					{
						AudioClip clip = component2.clip;
						component.VarAudio.clip = clip;
						break;
					}
					case AudioLocation.ResourceFile:
					{
						string localizedFileName = AudioResourceOptimizer.GetLocalizedFileName(dynamicGroupVariation.useLocalization, dynamicGroupVariation.resourceFileName);
						AudioResourceOptimizer.AddTargetForClip(localizedFileName, component.VarAudio);
						component.resourceFileName = dynamicGroupVariation.resourceFileName;
						component.useLocalization = dynamicGroupVariation.useLocalization;
						break;
					}
					case AudioLocation.FileOnInternet:
						AudioResourceOptimizer.AddTargetForClip(dynamicGroupVariation.internetFileUrl, component.VarAudio);
						component.internetFileUrl = dynamicGroupVariation.internetFileUrl;
						break;
					}
					component.audLocation = dynamicGroupVariation.audLocation;
					component.original_pitch = component2.pitch;
					component.transform.name = text2;
					component.isExpanded = dynamicGroupVariation.isExpanded;
					component.probabilityToPlay = dynamicGroupVariation.probabilityToPlay;
					component.useRandomPitch = dynamicGroupVariation.useRandomPitch;
					component.randomPitchMode = dynamicGroupVariation.randomPitchMode;
					component.randomPitchMin = dynamicGroupVariation.randomPitchMin;
					component.randomPitchMax = dynamicGroupVariation.randomPitchMax;
					component.useRandomVolume = dynamicGroupVariation.useRandomVolume;
					component.randomVolumeMode = dynamicGroupVariation.randomVolumeMode;
					component.randomVolumeMin = dynamicGroupVariation.randomVolumeMin;
					component.randomVolumeMax = dynamicGroupVariation.randomVolumeMax;
					component.useCustomLooping = dynamicGroupVariation.useCustomLooping;
					component.minCustomLoops = dynamicGroupVariation.minCustomLoops;
					component.maxCustomLoops = dynamicGroupVariation.maxCustomLoops;
					component.useFades = dynamicGroupVariation.useFades;
					component.fadeInTime = dynamicGroupVariation.fadeInTime;
					component.fadeOutTime = dynamicGroupVariation.fadeOutTime;
					component.useIntroSilence = dynamicGroupVariation.useIntroSilence;
					component.introSilenceMin = dynamicGroupVariation.introSilenceMin;
					component.introSilenceMax = dynamicGroupVariation.introSilenceMax;
					component.useRandomStartTime = dynamicGroupVariation.useRandomStartTime;
					component.randomStartMinPercent = dynamicGroupVariation.randomStartMinPercent;
					component.randomStartMaxPercent = dynamicGroupVariation.randomStartMaxPercent;
					component.randomEndPercent = dynamicGroupVariation.randomEndPercent;
					if (component.LowPassFilter != null && !component.LowPassFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.LowPassFilter);
					}
					if (component.HighPassFilter != null && !component.HighPassFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.HighPassFilter);
					}
					if (component.DistortionFilter != null && !component.DistortionFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.DistortionFilter);
					}
					if (component.ChorusFilter != null && !component.ChorusFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.ChorusFilter);
					}
					if (component.EchoFilter != null && !component.EchoFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.EchoFilter);
					}
					if (component.ReverbFilter != null && !component.ReverbFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.ReverbFilter);
					}
				}
			}
			MasterAudioGroup component3 = gameObject.GetComponent<MasterAudioGroup>();
			component3.retriggerPercentage = aGroup.retriggerPercentage;
			float? groupVolume = PersistentAudioSettings.GetGroupVolume(aGroup.name);
			component3.OriginalVolume = aGroup.groupMasterVolume;
			if (groupVolume.HasValue)
			{
				component3.groupMasterVolume = groupVolume.Value;
			}
			else
			{
				component3.groupMasterVolume = aGroup.groupMasterVolume;
			}
			component3.limitMode = aGroup.limitMode;
			component3.limitPerXFrames = aGroup.limitPerXFrames;
			component3.minimumTimeBetween = aGroup.minimumTimeBetween;
			component3.limitPolyphony = aGroup.limitPolyphony;
			component3.voiceLimitCount = aGroup.voiceLimitCount;
			component3.curVariationSequence = aGroup.curVariationSequence;
			component3.useInactivePeriodPoolRefill = aGroup.useInactivePeriodPoolRefill;
			component3.inactivePeriodSeconds = aGroup.inactivePeriodSeconds;
			component3.curVariationMode = aGroup.curVariationMode;
			component3.useNoRepeatRefill = aGroup.useNoRepeatRefill;
			component3.useDialogFadeOut = aGroup.useDialogFadeOut;
			component3.dialogFadeOutTime = aGroup.dialogFadeOutTime;
			component3.isUsingOcclusion = aGroup.isUsingOcclusion;
			component3.willOcclusionOverrideRaycastOffset = aGroup.willOcclusionOverrideRaycastOffset;
			component3.occlusionRayCastOffset = aGroup.occlusionRayCastOffset;
			component3.willOcclusionOverrideFrequencies = aGroup.willOcclusionOverrideFrequencies;
			component3.occlusionMaxCutoffFreq = aGroup.occlusionMaxCutoffFreq;
			component3.occlusionMinCutoffFreq = aGroup.occlusionMinCutoffFreq;
			component3.chainLoopDelayMin = aGroup.chainLoopDelayMin;
			component3.chainLoopDelayMax = aGroup.chainLoopDelayMax;
			component3.chainLoopMode = aGroup.chainLoopMode;
			component3.chainLoopNumLoops = aGroup.chainLoopNumLoops;
			component3.expandLinkedGroups = aGroup.expandLinkedGroups;
			component3.childSoundGroups = aGroup.childSoundGroups;
			component3.endLinkedGroups = aGroup.endLinkedGroups;
			component3.linkedStartGroupSelectionType = aGroup.linkedStartGroupSelectionType;
			component3.linkedStopGroupSelectionType = aGroup.linkedStopGroupSelectionType;
			component3.soundPlayedEventActive = aGroup.soundPlayedEventActive;
			component3.soundPlayedCustomEvent = aGroup.soundPlayedCustomEvent;
			component3.targetDespawnedBehavior = aGroup.targetDespawnedBehavior;
			component3.despawnFadeTime = aGroup.despawnFadeTime;
			component3.resourceClipsAllLoadAsync = aGroup.resourceClipsAllLoadAsync;
			component3.logSound = aGroup.logSound;
			component3.alwaysHighestPriority = aGroup.alwaysHighestPriority;
			component3.spatialBlendType = aGroup.spatialBlendType;
			component3.spatialBlend = aGroup.spatialBlend;
			List<AudioInfo> list = new List<AudioInfo>();
			List<int> list2 = new List<int>();
			for (int k = 0; k < gameObject.transform.childCount; k++)
			{
				list2.Add(k);
				Transform child = gameObject.transform.GetChild(k);
				AudioSource component4 = child.GetComponent<AudioSource>();
				SoundGroupVariation component = child.GetComponent<SoundGroupVariation>();
				list.Add(new AudioInfo(component, component4, component4.volume));
				component.DisableUpdater();
			}
			AddRuntimeGroupInfo(text, new AudioGroupInfo(list, component3));
			if (component3.curVariationSequence == MasterAudioGroup.VariationSequence.Randomized)
			{
				ArrayListUtil.SortIntArray(ref list2);
			}
			Instance._randomizer.Add(text, list2);
			List<int> list3 = new List<int>(list2.Count);
			list3.AddRange(list2);
			Instance._randomizerOrigin.Add(text, list3);
			Instance._randomizerLeftovers.Add(text, new List<int>(list2.Count));
			Instance._randomizerLeftovers[text].AddRange(list2);
			Instance._clipsPlayedBySoundTypeOldestFirst.Add(text, new List<int>(list2.Count));
			RescanGroupsNow();
			if (string.IsNullOrEmpty(aGroup.busName))
			{
				return transform;
			}
			component3.busIndex = GetBusIndex(aGroup.busName, alertMissing: true);
			if (component3.BusForGroup != null && component3.BusForGroup.isMuted)
			{
				MuteGroup(component3.name, shouldCheckMuteStatus: false);
			}
			else if (Instance.mixerMuted)
			{
				MuteGroup(component3.name, shouldCheckMuteStatus: false);
			}
			return transform;
		}

		public static float GetGroupVolume(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return 0f;
			}
			return masterAudioGroup.groupMasterVolume;
		}

		public static void SetGroupVolume(string sType, float volumeLevel)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, Application.isPlaying);
			if (masterAudioGroup == null || AppIsShuttingDown)
			{
				return;
			}
			masterAudioGroup.groupMasterVolume = volumeLevel;
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			float busVolume = GetBusVolume(masterAudioGroup);
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				AudioSource source = audioInfo.Source;
				if (!(source == null))
				{
					float volume = ((audioInfo.Variation.randomVolumeMode != 0) ? (audioInfo.OriginalVolume * audioInfo.LastPercentageVolume * masterAudioGroup.groupMasterVolume * busVolume * Instance._masterAudioVolume) : (audioInfo.OriginalVolume * audioInfo.LastPercentageVolume * masterAudioGroup.groupMasterVolume * busVolume * Instance._masterAudioVolume + audioInfo.LastRandomVolume));
					source.volume = volume;
				}
			}
		}

		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				Instance.SoloedGroups.Remove(masterAudioGroup);
				masterAudioGroup.isSoloed = false;
				SetGroupMuteStatus(masterAudioGroup, sType, isMute: true);
				if (shouldCheckMuteStatus)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				SetGroupMuteStatus(masterAudioGroup, sType, isMute: false);
				if (shouldCheckMuteStatus)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
			Instance.AudioSourcesBySoundType.Add(groupName, groupInfo);
			List<AudioSource> list = new List<AudioSource>(groupInfo.Sources.Count);
			for (int i = 0; i < groupInfo.Sources.Count; i++)
			{
				list.Add(groupInfo.Sources[i].Source);
			}
			TrackRuntimeAudioSources(list);
		}

		private static void FireAudioSourcesNumberChangedEvent()
		{
			if (NumberOfAudioSourcesChanged != null)
			{
				NumberOfAudioSourcesChanged();
			}
		}

		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
			bool flag = false;
			for (int i = 0; i < sources.Count; i++)
			{
				AudioSource item = sources[i];
				if (!Instance.AllAudioSources.Contains(item))
				{
					Instance.AllAudioSources.Add(item);
					flag = true;
				}
			}
			if (flag)
			{
				FireAudioSourcesNumberChangedEvent();
			}
		}

		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
			if (AppIsShuttingDown || SafeInstance == null)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < sources.Count; i++)
			{
				AudioSource item = sources[i];
				if (Instance.AllAudioSources.Contains(item))
				{
					Instance.AllAudioSources.Remove(item);
					flag = true;
				}
			}
			if (flag)
			{
				FireAudioSourcesNumberChangedEvent();
			}
		}

		private static void RemoveRuntimeGroupInfo(string groupName)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(groupName);
			if (masterAudioGroup != null)
			{
				List<AudioSource> list = new List<AudioSource>(masterAudioGroup.groupVariations.Count);
				for (int i = 0; i < masterAudioGroup.groupVariations.Count; i++)
				{
					list.Add(masterAudioGroup.groupVariations[i].VarAudio);
				}
				StopTrackingRuntimeAudioSources(list);
			}
			Instance.AudioSourcesBySoundType.Remove(groupName);
		}

		private static void RescanChildren(MasterAudioGroup group)
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>();
			List<string> list2 = new List<string>();
			for (int i = 0; i < group.transform.childCount; i++)
			{
				Transform child = group.transform.GetChild(i);
				if (!list2.Contains(child.name))
				{
					list2.Add(child.name);
					SoundGroupVariation component = child.GetComponent<SoundGroupVariation>();
					list.Add(component);
				}
			}
			group.groupVariations = list;
		}

		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
			aGroup.isMuted = isMute;
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				AudioSource source = audioInfo.Source;
				source.mute = isMute;
			}
		}

		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				masterAudioGroup.isMuted = false;
				masterAudioGroup.isSoloed = true;
				Instance.SoloedGroups.Add(masterAudioGroup);
				SetGroupMuteStatus(masterAudioGroup, sType, isMute: false);
				if (shouldCheckMuteStatus)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
			if (Instance.SoloedGroups.Count > 0)
			{
				SilenceNonSoloedGroups();
			}
			else
			{
				UnsilenceNonSoloedGroups();
			}
		}

		private static void UnsilenceNonSoloedGroups()
		{
			foreach (AudioGroupInfo value in Instance.AudioSourcesBySoundType.Values)
			{
				if (!value.Group.isMuted)
				{
					UnsilenceGroup(value.Group.GameObjectName);
				}
			}
		}

		private static void UnsilenceGroup(string sType)
		{
			if (Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
				for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
				{
					audioGroupInfo.Sources[i].Source.mute = false;
				}
			}
		}

		private static void SilenceNonSoloedGroups()
		{
			foreach (AudioGroupInfo value in Instance.AudioSourcesBySoundType.Values)
			{
				if (!value.Group.isSoloed && !value.Group.isMuted)
				{
					SilenceGroup(value.Group.GameObjectName);
				}
			}
		}

		private static void SilenceGroup(string sType)
		{
			if (Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
				for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
				{
					audioGroupInfo.Sources[i].Source.mute = true;
				}
			}
		}

		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				masterAudioGroup.isSoloed = false;
				Instance.SoloedGroups.Remove(masterAudioGroup);
				if (shouldCheckMuteStatus)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				if (logIfMissing)
				{
					UnityEngine.Debug.LogError("Could not grab Sound Group '" + sType + "' because it does not exist in this scene.");
				}
				return null;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			if (audioGroupInfo.Group == null)
			{
				Transform childTransform = Instance.Trans.GetChildTransform(sType);
				if (!(childTransform != null))
				{
					return null;
				}
				MasterAudioGroup component = childTransform.GetComponent<MasterAudioGroup>();
				audioGroupInfo.Group = component;
			}
			MasterAudioGroup group = audioGroupInfo.Group;
			if (group.groupVariations.Count == 0)
			{
				RescanChildren(group);
			}
			return group;
		}

		public static int VoicesForGroup(string sType)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				return -1;
			}
			return Instance.AudioSourcesBySoundType[sType].Sources.Count;
		}

		public static Transform FindGroupTransform(string sType)
		{
			if (SafeInstance != null)
			{
				Transform childTransform = Instance.Trans.GetChildTransform(sType);
				if (childTransform != null)
				{
					return childTransform;
				}
			}
			DynamicSoundGroupCreator[] array = UnityEngine.Object.FindObjectsOfType<DynamicSoundGroupCreator>();
			for (int i = 0; i < array.Count(); i++)
			{
				DynamicSoundGroupCreator dynamicSoundGroupCreator = array[i];
				Transform childTransform = dynamicSoundGroupCreator.transform.GetChildTransform(sType);
				if (childTransform != null)
				{
					return childTransform;
				}
			}
			return null;
		}

		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				if (logIfMissing)
				{
					UnityEngine.Debug.LogError("Could not grab Sound Group '" + sType + "' because it does not exist in this scene.");
				}
				return null;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			return audioGroupInfo.Sources;
		}

		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				return null;
			}
			return Instance.AudioSourcesBySoundType[sType];
		}

		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogError("Could not grab Sound Group '" + sType + "' because it does not exist in this scene.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			audioGroupInfo.Group.SubscribeToLastVariationFinishedPlay(finishedCallback);
		}

		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
			if (Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
				audioGroupInfo.Group.UnsubscribeFromLastVariationFinishedPlay();
			}
		}

		public void SetSpatialBlendForMixer()
		{
			foreach (string key in AudioSourcesBySoundType.Keys)
			{
				SetGroupSpatialBlend(key);
			}
		}

		public static void PauseMixer()
		{
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				PauseSoundGroup(Instance.AudioSourcesBySoundType[key].Group.GameObjectName);
			}
		}

		public static void UnpauseMixer()
		{
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				UnpauseSoundGroup(Instance.AudioSourcesBySoundType[key].Group.GameObjectName);
			}
		}

		public static void StopMixer()
		{
			Instance.VariationsStartedDuringMultiStop.Clear();
			Instance._isStoppingMultiple = true;
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				StopAllOfSound(Instance.AudioSourcesBySoundType[key].Group.GameObjectName);
			}
			Instance._isStoppingMultiple = false;
		}

		public static void UnsubscribeFromAllVariations()
		{
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					sources[i].Variation.ClearSubscribers();
				}
			}
		}

		public static void StopEverything()
		{
			StopMixer();
			StopAllPlaylists();
		}

		public static void PauseEverything()
		{
			PauseMixer();
			PauseAllPlaylists();
		}

		public static void UnpauseEverything()
		{
			UnpauseMixer();
			UnpauseAllPlaylists();
		}

		public static void MuteEverything()
		{
			MixerMuted = true;
			MuteAllPlaylists();
		}

		public static void UnmuteEverything()
		{
			MixerMuted = false;
			UnmuteAllPlaylists();
		}

		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			List<string> list = new List<string>();
			for (int i = 0; i < Instance.transform.childCount; i++)
			{
				MasterAudioGroup component = Instance.transform.GetChild(i).GetComponent<MasterAudioGroup>();
				for (int j = 0; j < component.transform.childCount; j++)
				{
					SoundGroupVariation component2 = component.transform.GetChild(j).GetComponent<SoundGroupVariation>();
					string text = string.Empty;
					switch (component2.audLocation)
					{
					case AudioLocation.Clip:
					{
						AudioClip clip = component2.VarAudio.clip;
						if (clip != null)
						{
							text = clip.name;
						}
						break;
					}
					case AudioLocation.ResourceFile:
						text = component2.resourceFileName;
						break;
					case AudioLocation.FileOnInternet:
						text = component2.internetFileUrl;
						break;
					}
					if (!string.IsNullOrEmpty(text) && !list.Contains(text))
					{
						list.Add(text);
					}
				}
			}
			return list;
		}

		private static int GetBusIndex(string busName, bool alertMissing)
		{
			if (!SceneHasMasterAudio)
			{
				return -1;
			}
			for (int i = 0; i < GroupBuses.Count; i++)
			{
				if (GroupBuses[i].busName == busName)
				{
					return i + 2;
				}
			}
			if (alertMissing)
			{
				LogWarning("Could not find bus '" + busName + "'.");
			}
			return -1;
		}

		private static GroupBus GetBusByIndex(int busIndex)
		{
			if (busIndex < 2)
			{
				return null;
			}
			return GroupBuses[busIndex - 2];
		}

		public static void ChangeBusPitch(string busName, float pitch)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					ChangeVariationPitch(group.GameObjectName, changeAllVariations: true, string.Empty, pitch);
				}
			}
		}

		public static void MuteBus(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			GroupBus groupBus = GrabBusByName(busName);
			groupBus.isMuted = true;
			if (groupBus.isSoloed)
			{
				UnsoloBus(busName);
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					MuteGroup(group.GameObjectName, shouldCheckMuteStatus: false);
				}
			}
			if (Application.isPlaying)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			GroupBus groupBus = GrabBusByName(busName);
			groupBus.isMuted = false;
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					UnmuteGroup(group.GameObjectName, shouldCheckMuteStatus: false);
				}
			}
			if (shouldCheckMuteStatus)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static void ToggleMuteBus(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex >= 0)
			{
				GroupBus groupBus = GrabBusByName(busName);
				if (groupBus.isMuted)
				{
					UnmuteBus(busName);
				}
				else
				{
					MuteBus(busName);
				}
			}
		}

		public static void PauseBus(string busName)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					PauseSoundGroup(group.GameObjectName);
				}
			}
		}

		public static void SoloBus(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			GroupBus groupBus = GrabBusByName(busName);
			groupBus.isSoloed = true;
			if (groupBus.isMuted)
			{
				UnmuteBus(busName);
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					SoloGroup(group.GameObjectName, shouldCheckMuteStatus: false);
				}
			}
			if (Application.isPlaying)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			GroupBus groupBus = GrabBusByName(busName);
			groupBus.isSoloed = false;
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					UnsoloGroup(group.GameObjectName, shouldCheckMuteStatus: false);
				}
			}
			if (shouldCheckMuteStatus)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
			if (!Application.isPlaying)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					RouteGroupToUnityMixerGroup(group.name, mixerGroup);
				}
			}
		}

		private static void StopOldestSoundOnBus(GroupBus bus)
		{
			int busIndex = GetBusIndex(bus.busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			SoundGroupVariation soundGroupVariation = null;
			float num = -1f;
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex != busIndex || group.ActiveVoices == 0)
				{
					continue;
				}
				for (int i = 0; i < value.Sources.Count; i++)
				{
					SoundGroupVariation variation = value.Sources[i].Variation;
					if (variation.PlaySoundParm.IsPlaying)
					{
						if (variation.curFadeMode == SoundGroupVariation.FadeMode.FadeOutEarly)
						{
							variation.Stop();
						}
						else if (soundGroupVariation == null)
						{
							soundGroupVariation = variation;
							num = variation.LastTimePlayed;
						}
						else if (variation.LastTimePlayed < num)
						{
							soundGroupVariation = variation;
							num = variation.LastTimePlayed;
						}
					}
				}
			}
			if (soundGroupVariation != null)
			{
				soundGroupVariation.FadeOutNow(Instance.stopOldestBusFadeTime);
			}
		}

		public static void StopBus(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Instance.VariationsStartedDuringMultiStop.Clear();
			Instance._isStoppingMultiple = true;
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					StopAllOfSound(group.GameObjectName);
				}
			}
			Instance._isStoppingMultiple = false;
		}

		public static void UnpauseBus(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					UnpauseSoundGroup(group.GameObjectName);
				}
			}
		}

		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			List<GroupBus> list = GroupBuses.FindAll((GroupBus obj) => obj.busName == busName);
			if (list.Count > 0)
			{
				if (errorOnExisting)
				{
					LogError("You already have a bus named '" + busName + "'. Not creating a second one.");
				}
				return false;
			}
			GroupBus groupBus = new GroupBus();
			groupBus.busName = busName;
			groupBus.isTemporary = isTemporary;
			GroupBus item = groupBus;
			float? busVolume = PersistentAudioSettings.GetBusVolume(busName);
			GroupBuses.Add(item);
			if (busVolume.HasValue)
			{
				SetBusVolumeByName(busName, busVolume.Value);
			}
			return true;
		}

		public static void DeleteBusByName(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: false);
			if (busIndex > 0)
			{
				DeleteBusByIndex(busIndex);
			}
		}

		public static void DeleteBusByIndex(int busIndex)
		{
			int index = busIndex - 2;
			if (Application.isPlaying)
			{
				GroupBus groupBus = GroupBuses[index];
				if (groupBus.isSoloed)
				{
					UnsoloBus(groupBus.busName, shouldCheckMuteStatus: false);
				}
				else if (groupBus.isMuted)
				{
					UnmuteBus(groupBus.busName, shouldCheckMuteStatus: false);
				}
			}
			GroupBuses.RemoveAt(index);
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == -1)
				{
					continue;
				}
				if (group.busIndex == busIndex)
				{
					group.busIndex = -1;
					RouteGroupToUnityMixerGroup(group.name, null);
					for (int i = 0; i < value.Sources.Count; i++)
					{
						SoundGroupVariation variation = value.Sources[i].Variation;
						variation.SetSpatialBlend();
					}
					RecalculateGroupVolumes(value, null);
				}
				else if (group.busIndex > busIndex)
				{
					group.busIndex--;
				}
			}
		}

		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			float result = 1f;
			if (maGroup.busIndex >= 2)
			{
				result = GroupBuses[maGroup.busIndex - 2].volume;
			}
			return result;
		}

		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, Action completionCallback = null, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
			if (newVolume < 0f || newVolume > 1f)
			{
				UnityEngine.Debug.LogError("Illegal volume passed to FadeBusToVolume: '" + newVolume + "'. Legal volumes are between 0 and 1");
				return;
			}
			if (fadeTime <= 0.1f)
			{
				SetBusVolumeByName(busName, newVolume);
				completionCallback?.Invoke();
				if (willStopAfterFade)
				{
					StopBus(busName);
				}
				return;
			}
			GroupBus groupBus = GrabBusByName(busName);
			if (groupBus == null)
			{
				UnityEngine.Debug.Log("Could not find bus '" + busName + "' to fade it.");
				return;
			}
			BusFadeInfo busFadeInfo = Instance.BusFades.Find((BusFadeInfo obj) => obj.NameOfBus == busName);
			if (busFadeInfo != null)
			{
				busFadeInfo.IsActive = false;
			}
			BusFadeInfo busFadeInfo2 = new BusFadeInfo();
			busFadeInfo2.NameOfBus = busName;
			busFadeInfo2.ActingBus = groupBus;
			busFadeInfo2.StartVolume = groupBus.volume;
			busFadeInfo2.TargetVolume = newVolume;
			busFadeInfo2.StartTime = AudioUtil.Time;
			busFadeInfo2.CompletionTime = AudioUtil.Time + fadeTime;
			busFadeInfo2.WillStopGroupAfterFade = willStopAfterFade;
			busFadeInfo2.WillResetVolumeAfterFade = willResetVolumeAfterFade;
			BusFadeInfo busFadeInfo3 = busFadeInfo2;
			if (completionCallback != null)
			{
				busFadeInfo3.completionAction = completionCallback;
			}
			Instance.BusFades.Add(busFadeInfo3);
		}

		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, Action completionCallback = null)
		{
			if (pitchAddition < -3f || pitchAddition > 3f)
			{
				UnityEngine.Debug.LogError("Illegal pitch passed to GlideBusByPitch: '" + pitchAddition + "'. Legal pitches are between -3 and 3");
				return;
			}
			if (pitchAddition == 0f)
			{
				completionCallback?.Invoke();
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			if (glideTime <= 0.1f)
			{
				while (enumerator.MoveNext())
				{
					AudioGroupInfo value = enumerator.Current.Value;
					AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[value.Group.name];
					if (audioGroupInfo.Group.busIndex != busIndex)
					{
						continue;
					}
					for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
					{
						SoundGroupVariation variation = audioGroupInfo.Sources[i].Variation;
						if (variation.IsPlaying)
						{
							if (variation.curPitchMode == SoundGroupVariation.PitchMode.Gliding)
							{
								variation.VariationUpdater.StopPitchGliding();
							}
							variation.GlideByPitch(pitchAddition, 0f);
						}
					}
				}
				completionCallback?.Invoke();
				return;
			}
			BusPitchGlideInfo busPitchGlideInfo = Instance.BusPitchGlides.Find((BusPitchGlideInfo obj) => obj.NameOfBus == busName);
			if (busPitchGlideInfo != null)
			{
				busPitchGlideInfo.IsActive = false;
				if (busPitchGlideInfo.completionAction != null)
				{
					busPitchGlideInfo.completionAction();
					busPitchGlideInfo.completionAction = null;
				}
			}
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(16);
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				AudioGroupInfo audioGroupInfo2 = Instance.AudioSourcesBySoundType[value.Group.name];
				if (audioGroupInfo2.Group.busIndex != busIndex)
				{
					continue;
				}
				for (int j = 0; j < audioGroupInfo2.Sources.Count; j++)
				{
					SoundGroupVariation variation2 = audioGroupInfo2.Sources[j].Variation;
					if (variation2.IsPlaying)
					{
						if (variation2.curPitchMode == SoundGroupVariation.PitchMode.Gliding)
						{
							variation2.VariationUpdater.StopPitchGliding();
						}
						variation2.GlideByPitch(pitchAddition, glideTime);
						list.Add(variation2);
					}
				}
			}
			if (list.Count == 0)
			{
				completionCallback?.Invoke();
				return;
			}
			BusPitchGlideInfo busPitchGlideInfo2 = new BusPitchGlideInfo();
			busPitchGlideInfo2.NameOfBus = busName;
			busPitchGlideInfo2.CompletionTime = AudioUtil.Time + glideTime;
			busPitchGlideInfo2.GlidingVariations = list;
			BusPitchGlideInfo busPitchGlideInfo3 = busPitchGlideInfo2;
			if (completionCallback != null)
			{
				busPitchGlideInfo3.completionAction = completionCallback;
			}
			Instance.BusPitchGlides.Add(busPitchGlideInfo3);
		}

		public static void SetBusVolumeByName(string busName, float newVolume)
		{
			GroupBus groupBus = GrabBusByName(busName);
			if (groupBus == null)
			{
				UnityEngine.Debug.LogError("bus '" + busName + "' not found!");
			}
			else
			{
				SetBusVolume(groupBus, newVolume);
			}
		}

		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
			GroupBus busByIndex = GetBusByIndex(aGroup.Group.busIndex);
			bool flag = busByIndex != null && bus != null && busByIndex.busName == bus.busName;
			float num = 1f;
			if (flag)
			{
				num = bus.volume;
			}
			else if (busByIndex != null)
			{
				num = busByIndex.volume;
			}
			for (int i = 0; i < aGroup.Sources.Count; i++)
			{
				AudioInfo audioInfo = aGroup.Sources[i];
				AudioSource source = audioInfo.Source;
				if (audioInfo.Variation.IsPlaying)
				{
					float num2 = aGroup.Group.groupMasterVolume * num * Instance._masterAudioVolume;
					float volume = audioInfo.OriginalVolume * audioInfo.LastPercentageVolume * num2 + audioInfo.LastRandomVolume;
					source.volume = volume;
					SoundGroupVariation component = source.GetComponent<SoundGroupVariation>();
					component.SetGroupVolume = num2;
				}
			}
		}

		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
			if (bus != null)
			{
				bus.volume = newVolume;
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				AudioGroupInfo aGroup = Instance.AudioSourcesBySoundType[key];
				RecalculateGroupVolumes(aGroup, bus);
			}
		}

		public static GroupBus GrabBusByName(string busName)
		{
			for (int i = 0; i < GroupBuses.Count; i++)
			{
				GroupBus groupBus = GroupBuses[i];
				if (groupBus.busName == busName)
				{
					return groupBus;
				}
			}
			return null;
		}

		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					PauseSoundGroupOfTransform(sourceTrans, group.GameObjectName);
				}
			}
		}

		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					UnpauseSoundGroupOfTransform(sourceTrans, group.GameObjectName);
				}
			}
		}

		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			Instance.VariationsStartedDuringMultiStop.Clear();
			Instance._isStoppingMultiple = true;
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == busIndex)
				{
					StopSoundGroupOfTransform(sourceTrans, group.GameObjectName);
				}
			}
			Instance._isStoppingMultiple = false;
		}

		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
			MasterAudio instance = Instance;
			if (!instance.duckingBySoundType.ContainsKey(sType))
			{
				DuckGroupInfo duckGroupInfo = new DuckGroupInfo();
				duckGroupInfo.soundType = sType;
				duckGroupInfo.riseVolStart = riseVolumeStart;
				duckGroupInfo.duckedVolumeCut = duckedVolCut;
				duckGroupInfo.unduckTime = unduckTime;
				duckGroupInfo.isTemporary = isTemporary;
				DuckGroupInfo duckGroupInfo2 = duckGroupInfo;
				instance.duckingBySoundType.Add(sType, duckGroupInfo2);
				instance.musicDuckingSounds.Add(duckGroupInfo2);
			}
		}

		public static void RemoveSoundGroupFromDuckList(string sType)
		{
			MasterAudio instance = Instance;
			if (instance.duckingBySoundType.ContainsKey(sType))
			{
				DuckGroupInfo item = instance.duckingBySoundType[sType];
				instance.musicDuckingSounds.Remove(item);
				instance.duckingBySoundType.Remove(sType);
			}
		}

		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			if (playlistName == "[None]")
			{
				return null;
			}
			for (int i = 0; i < MusicPlaylists.Count; i++)
			{
				Playlist playlist = MusicPlaylists[i];
				if (playlist.playlistName == playlistName)
				{
					return playlist;
				}
			}
			if (logErrorIfNotFound)
			{
				UnityEngine.Debug.LogError("Could not find Playlist '" + playlistName + "'.");
			}
			return null;
		}

		public static void ChangePlaylistPitch(string playlistName, float pitch, string songName = null)
		{
			Playlist playlist = GrabPlaylist(playlistName);
			if (playlist == null)
			{
				return;
			}
			for (int i = 0; i < playlist.MusicSettings.Count; i++)
			{
				MusicSetting musicSetting = playlist.MusicSettings[i];
				if (string.IsNullOrEmpty(songName) || !(musicSetting.alias != songName) || !(musicSetting.songName != songName))
				{
					musicSetting.pitch = pitch;
				}
			}
		}

		public static void MutePlaylist()
		{
			MutePlaylist("~only~");
		}

		public static void MutePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "PausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			MutePlaylists(list);
		}

		public static void MuteAllPlaylists()
		{
			MutePlaylists(PlaylistController.Instances);
		}

		private static void MutePlaylists(List<PlaylistController> playlists)
		{
			if (playlists.Count == PlaylistController.Instances.Count)
			{
				PlaylistsMuted = true;
			}
			for (int i = 0; i < playlists.Count; i++)
			{
				PlaylistController playlistController = playlists[i];
				playlistController.MutePlaylist();
			}
		}

		public static void UnmutePlaylist()
		{
			UnmutePlaylist("~only~");
		}

		public static void UnmutePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "PausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			UnmutePlaylists(list);
		}

		public static void UnmuteAllPlaylists()
		{
			UnmutePlaylists(PlaylistController.Instances);
		}

		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
			if (playlists.Count == PlaylistController.Instances.Count)
			{
				PlaylistsMuted = false;
			}
			for (int i = 0; i < playlists.Count; i++)
			{
				PlaylistController playlistController = playlists[i];
				playlistController.UnmutePlaylist();
			}
		}

		public static void ToggleMutePlaylist()
		{
			ToggleMutePlaylist("~only~");
		}

		public static void ToggleMutePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "PausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			ToggleMutePlaylists(list);
		}

		public static void ToggleMuteAllPlaylists()
		{
			ToggleMutePlaylists(PlaylistController.Instances);
		}

		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				PlaylistController playlistController = playlists[i];
				playlistController.ToggleMutePlaylist();
			}
		}

		public static void PausePlaylist()
		{
			PausePlaylist("~only~");
		}

		public static void PausePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "PausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			PausePlaylists(list);
		}

		public static void PauseAllPlaylists()
		{
			PausePlaylists(PlaylistController.Instances);
		}

		private static void PausePlaylists(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				PlaylistController playlistController = playlists[i];
				playlistController.PausePlaylist();
			}
		}

		public static void UnpausePlaylist()
		{
			UnpausePlaylist("~only~");
		}

		public static void UnpausePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "UnpausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			UnpausePlaylists(list);
		}

		public static void UnpauseAllPlaylists()
		{
			UnpausePlaylists(PlaylistController.Instances);
		}

		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
			for (int i = 0; i < controllers.Count; i++)
			{
				PlaylistController playlistController = controllers[i];
				playlistController.UnpausePlaylist();
			}
		}

		public static void StopPlaylist()
		{
			StopPlaylist("~only~");
		}

		public static void StopPlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "StopPlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			StopPlaylists(list);
		}

		public static void StopAllPlaylists()
		{
			StopPlaylists(PlaylistController.Instances);
		}

		private static void StopPlaylists(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				PlaylistController playlistController = playlists[i];
				playlistController.StopPlaylist();
			}
		}

		public static void TriggerNextPlaylistClip()
		{
			TriggerNextPlaylistClip("~only~");
		}

		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "TriggerNextPlaylistClip"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			NextPlaylistClips(list);
		}

		public static void TriggerNextClipAllPlaylists()
		{
			NextPlaylistClips(PlaylistController.Instances);
		}

		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				PlaylistController playlistController = playlists[i];
				playlistController.PlayNextSong();
			}
		}

		public static void TriggerRandomPlaylistClip()
		{
			TriggerRandomPlaylistClip("~only~");
		}

		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "TriggerRandomPlaylistClip"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			RandomPlaylistClips(list);
		}

		public static void TriggerRandomClipAllPlaylists()
		{
			RandomPlaylistClips(PlaylistController.Instances);
		}

		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				PlaylistController playlistController = playlists[i];
				playlistController.PlayRandomSong();
			}
		}

		public static void RestartPlaylist()
		{
			RestartPlaylist("~only~");
		}

		public static void RestartPlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "RestartPlaylist"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				List<PlaylistController> list = new List<PlaylistController>();
				list.Add(playlistController);
				RestartPlaylists(list);
			}
		}

		public static void RestartAllPlaylists()
		{
			RestartPlaylists(PlaylistController.Instances);
		}

		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				PlaylistController playlistController = playlists[i];
				playlistController.RestartPlaylist();
			}
		}

		public static void StartPlaylist(string playlistName)
		{
			StartPlaylist("~only~", playlistName);
		}

		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "StartPlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].StartPlaylist(playlistName);
			}
		}

		public static void StopLoopingAllCurrentSongs()
		{
			StopLoopingCurrentSongs(PlaylistController.Instances);
		}

		public static void StopLoopingCurrentSong()
		{
			StopLoopingCurrentSong("~only~");
		}

		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "StopLoopingCurrentSong"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				List<PlaylistController> list = new List<PlaylistController>();
				list.Add(playlistController);
				StopLoopingCurrentSongs(list);
			}
		}

		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
			for (int i = 0; i < playlistControllers.Count; i++)
			{
				PlaylistController playlistController = playlistControllers[i];
				playlistController.StopLoopingCurrentSong();
			}
		}

		public static void StopAllPlaylistsAfterCurrentSongs()
		{
			StopPlaylistAfterCurrentSongs(PlaylistController.Instances);
		}

		public static void StopPlaylistAfterCurrentSong()
		{
			StopPlaylistAfterCurrentSong("~only~");
		}

		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "StopPlaylistAfterCurrentSong"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				List<PlaylistController> list = new List<PlaylistController>();
				list.Add(playlistController);
				StopPlaylistAfterCurrentSongs(list);
			}
		}

		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
			for (int i = 0; i < playlistControllers.Count; i++)
			{
				PlaylistController playlistController = playlistControllers[i];
				playlistController.StopPlaylistAfterCurrentSong();
			}
		}

		public static void QueuePlaylistClip(string clipName)
		{
			QueuePlaylistClip("~only~", clipName);
		}

		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "QueuePlaylistClip"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				playlistController.QueuePlaylistClip(clipName);
			}
		}

		public static bool TriggerPlaylistClip(string clipName)
		{
			return TriggerPlaylistClip("~only~", clipName);
		}

		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "TriggerPlaylistClip"))
				{
					return false;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return false;
				}
				playlistController = playlistController2;
			}
			if (playlistController == null)
			{
				return false;
			}
			return playlistController.TriggerPlaylistClip(clipName);
		}

		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
			ChangePlaylistByName("~only~", playlistName, playFirstClip);
		}

		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "ChangePlaylistByName"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				playlistController.ChangePlaylist(playlistName, playFirstClip);
			}
		}

		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
			FadePlaylistToVolume("~only~", targetVolume, fadeTime);
		}

		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "FadePlaylistToVolume"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			FadePlaylists(list, targetVolume, fadeTime);
		}

		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
			FadePlaylists(PlaylistController.Instances, targetVolume, fadeTime);
		}

		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
			if (targetVolume < 0f || targetVolume > 1f)
			{
				UnityEngine.Debug.LogError("Illegal volume passed to FadePlaylistToVolume: '" + targetVolume + "'. Legal volumes are between 0 and 1");
				return;
			}
			for (int i = 0; i < playlists.Count; i++)
			{
				PlaylistController playlistController = playlists[i];
				playlistController.FadeToVolume(targetVolume, fadeTime);
			}
		}

		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
			Playlist playlist2 = GrabPlaylist(playlist.playlistName, logErrorIfNotFound: false);
			if (playlist2 != null)
			{
				if (errorOnDuplicate)
				{
					UnityEngine.Debug.LogError("You already have a Playlist Controller with the name '" + playlist2.playlistName + "'. You must name them all uniquely. Not adding duplicate named Playlist.");
				}
			}
			else
			{
				MusicPlaylists.Add(playlist);
			}
		}

		public static void DeletePlaylist(string playlistName)
		{
			if (SafeInstance == null)
			{
				return;
			}
			Playlist playlist = GrabPlaylist(playlistName);
			if (playlist == null)
			{
				return;
			}
			for (int i = 0; i < PlaylistController.Instances.Count; i++)
			{
				PlaylistController playlistController = PlaylistController.Instances[i];
				if (!(playlistController.PlaylistName != playlistName))
				{
					playlistController.StopPlaylist();
					break;
				}
			}
			MusicPlaylists.Remove(playlist);
		}

		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
			Playlist playlist = GrabPlaylist(playlistName);
			if (playlist != null)
			{
				MusicSetting musicSetting = new MusicSetting();
				musicSetting.clip = song;
				musicSetting.isExpanded = true;
				musicSetting.isLoop = loopSong;
				musicSetting.pitch = songPitch;
				musicSetting.volume = songVolume;
				MusicSetting item = musicSetting;
				playlist.MusicSettings.Add(item);
			}
		}

		public static void ReDownloadAllInternetFiles()
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>();
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				for (int i = 0; i < Instance.AudioSourcesBySoundType[key].Sources.Count; i++)
				{
					AudioSource source = Instance.AudioSourcesBySoundType[key].Sources[i].Source;
					SoundGroupVariation component = source.GetComponent<SoundGroupVariation>();
					if (!(component == null) && component.audLocation == AudioLocation.FileOnInternet)
					{
						AudioResourceOptimizer.RemoveLoadedInternetClip(component.internetFileUrl);
						component.internetFileLoadStatus = InternetFileLoadStatus.Loading;
						list.Add(component);
					}
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				SoundGroupVariation soundGroupVariation = list[j];
				soundGroupVariation.Stop();
				AudioResourceOptimizer.AddTargetForClip(soundGroupVariation.internetFileUrl, soundGroupVariation.VarAudio);
				soundGroupVariation.LoadInternetFile();
			}
		}

		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
			if (!AppIsShuttingDown && !("[None]" == customEventName) && !string.IsNullOrEmpty(customEventName))
			{
				if (!CustomEventExists(customEventName) && !IsWarming)
				{
					UnityEngine.Debug.LogError("Custom Event '" + customEventName + "' was not found in Master Audio.");
					return;
				}
				Instance.CustomEventsToFire.Enqueue(new CustomEventToFireInfo
				{
					eventName = customEventName,
					eventOrigin = eventOrigin
				});
			}
		}

		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
			if (AppIsShuttingDown)
			{
				return;
			}
			IList<AudioEventGroup> allEvents = receiver.GetAllEvents();
			for (int i = 0; i < allEvents.Count; i++)
			{
				AudioEventGroup audioEventGroup = allEvents[i];
				if (!receiver.SubscribesToEvent(audioEventGroup.customEventName))
				{
					continue;
				}
				if (!Instance.ReceiversByEventName.ContainsKey(audioEventGroup.customEventName))
				{
					Instance.ReceiversByEventName.Add(audioEventGroup.customEventName, new Dictionary<ICustomEventReceiver, Transform> { { receiver, receiverTrans } });
					continue;
				}
				Dictionary<ICustomEventReceiver, Transform> dictionary = Instance.ReceiversByEventName[audioEventGroup.customEventName];
				if (!dictionary.ContainsKey(receiver))
				{
					dictionary.Add(receiver, receiverTrans);
				}
			}
		}

		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
			if (AppIsShuttingDown || SafeInstance == null)
			{
				if (!(SafeInstance != null))
				{
					return;
				}
				{
					foreach (string key in Instance.ReceiversByEventName.Keys)
					{
						Instance.ReceiversByEventName[key].Remove(receiver);
					}
					return;
				}
			}
			for (int i = 0; i < Instance.customEvents.Count; i++)
			{
				CustomEvent customEvent = Instance.customEvents[i];
				if (receiver.SubscribesToEvent(customEvent.EventName))
				{
					Dictionary<ICustomEventReceiver, Transform> dictionary = Instance.ReceiversByEventName[customEvent.EventName];
					dictionary.Remove(receiver);
				}
			}
		}

		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			List<Transform> list = new List<Transform>();
			if (!Instance.ReceiversByEventName.ContainsKey(customEventName))
			{
				return list;
			}
			Dictionary<ICustomEventReceiver, Transform> dictionary = Instance.ReceiversByEventName[customEventName];
			foreach (ICustomEventReceiver key in dictionary.Keys)
			{
				if (key.SubscribesToEvent(customEventName))
				{
					list.Add(dictionary[key]);
				}
			}
			return list;
		}

		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			if (AppIsShuttingDown)
			{
				return null;
			}
			if (Instance.customEventCategories.FindAll((CustomEventCategory cat) => cat.CatName == categoryName).Count > 0)
			{
				return null;
			}
			CustomEventCategory customEventCategory = new CustomEventCategory();
			customEventCategory.CatName = categoryName;
			customEventCategory.ProspectiveName = categoryName;
			customEventCategory.IsTemporary = isTemporary;
			CustomEventCategory customEventCategory2 = customEventCategory;
			Instance.customEventCategories.Add(customEventCategory2);
			return customEventCategory2;
		}

		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
			if (AppIsShuttingDown)
			{
				return;
			}
			if (Instance.customEvents.FindAll((CustomEvent obj) => obj.EventName == customEventName).Count > 0)
			{
				if (errorOnDuplicate)
				{
					UnityEngine.Debug.LogError("You already have a Custom Event named '" + customEventName + "'. No need to add it again.");
				}
				return;
			}
			if (string.IsNullOrEmpty(categoryName))
			{
				categoryName = Instance.customEventCategories[0].CatName;
			}
			CustomEvent customEvent = new CustomEvent(customEventName);
			customEvent.eventReceiveMode = eventReceiveMode;
			customEvent.distanceThreshold = distanceThreshold;
			customEvent.eventRcvFilterMode = receiveFilter;
			customEvent.filterModeQty = filterModeQty;
			customEvent.categoryName = categoryName;
			customEvent.isTemporary = isTemporary;
			CustomEvent item = customEvent;
			Instance.customEvents.Add(item);
		}

		public static void DeleteCustomEvent(string customEventName)
		{
			if (!AppIsShuttingDown && !(SafeInstance == null))
			{
				Instance.customEvents.RemoveAll((CustomEvent obj) => obj.EventName == customEventName);
			}
		}

		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			List<CustomEvent> list = Instance.customEvents.FindAll((CustomEvent obj) => obj.EventName == customEventName);
			return (list.Count <= 0) ? null : list[0];
		}

		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
			if (AppIsShuttingDown || "[None]" == customEventName || string.IsNullOrEmpty(customEventName))
			{
				return;
			}
			if (originObject == null)
			{
				UnityEngine.Debug.LogError("Custom Event '" + customEventName + "' cannot be fired without an originObject passed in.");
				return;
			}
			if (!CustomEventExists(customEventName) && !IsWarming)
			{
				UnityEngine.Debug.LogError("Custom Event '" + customEventName + "' was not found in Master Audio.");
				return;
			}
			CustomEvent customEventByName = GetCustomEventByName(customEventName);
			if (customEventByName == null)
			{
				return;
			}
			if (customEventByName.frameLastFired >= AudioUtil.FrameCount)
			{
				if (logDupe)
				{
					UnityEngine.Debug.LogWarning("Already fired Custom Event '" + customEventName + "' this frame or later. Cannot be fired twice in the same frame.");
				}
				return;
			}
			customEventByName.frameLastFired = AudioUtil.FrameCount;
			if (!Instance.disableLogging && Instance.logCustomEvents)
			{
				UnityEngine.Debug.Log("Firing Custom Event: " + customEventName);
			}
			if (!Instance.ReceiversByEventName.ContainsKey(customEventName))
			{
				return;
			}
			Vector3 position = originObject.position;
			float? num = null;
			Dictionary<ICustomEventReceiver, Transform> dictionary = Instance.ReceiversByEventName[customEventName];
			List<ICustomEventReceiver> list = null;
			switch (customEventByName.eventReceiveMode)
			{
			case CustomEventReceiveMode.Never:
				if (Instance.LogSounds)
				{
					UnityEngine.Debug.LogWarning("Custom Event '" + customEventName + "' not being transmitted because it is set to 'Never transmit'.");
				}
				return;
			case CustomEventReceiveMode.OnChildGameObject:
				list = GetChildReceivers(originObject, customEventName, includeSelf: false);
				break;
			case CustomEventReceiveMode.OnParentGameObject:
				list = GetParentReceivers(originObject, customEventName, includeSelf: false);
				break;
			case CustomEventReceiveMode.OnSameOrChildGameObject:
				list = GetChildReceivers(originObject, customEventName, includeSelf: true);
				break;
			case CustomEventReceiveMode.OnSameOrParentGameObject:
				list = GetParentReceivers(originObject, customEventName, includeSelf: true);
				break;
			case CustomEventReceiveMode.WhenDistanceLessThan:
			case CustomEventReceiveMode.WhenDistanceMoreThan:
				num = customEventByName.distanceThreshold * customEventByName.distanceThreshold;
				break;
			}
			if (list == null)
			{
				list = new List<ICustomEventReceiver>();
				foreach (ICustomEventReceiver key in dictionary.Keys)
				{
					switch (customEventByName.eventReceiveMode)
					{
					case CustomEventReceiveMode.WhenDistanceLessThan:
					{
						float sqrMagnitude2 = (dictionary[key].position - position).sqrMagnitude;
						if (num.HasValue && sqrMagnitude2 > num.GetValueOrDefault())
						{
							continue;
						}
						break;
					}
					case CustomEventReceiveMode.WhenDistanceMoreThan:
					{
						float sqrMagnitude = (dictionary[key].position - position).sqrMagnitude;
						if (num.HasValue && sqrMagnitude < num.GetValueOrDefault())
						{
							continue;
						}
						break;
					}
					case CustomEventReceiveMode.OnSameGameObject:
						if (originObject != dictionary[key])
						{
							continue;
						}
						break;
					}
					list.Add(key);
				}
			}
			if (customEventByName.eventRcvFilterMode == EventReceiveFilter.All || customEventByName.filterModeQty >= list.Count || list.Count <= 1)
			{
				for (int i = 0; i < list.Count; i++)
				{
					list[i].ReceiveEvent(customEventName, position);
				}
				return;
			}
			Instance.ValidReceivers.Clear();
			for (int j = 0; j < list.Count; j++)
			{
				ICustomEventReceiver customEventReceiver = list[j];
				Transform transform = dictionary[customEventReceiver];
				float distance = 0f;
				int randomId = 0;
				switch (customEventByName.eventRcvFilterMode)
				{
				case EventReceiveFilter.Random:
					randomId = UnityEngine.Random.Range(0, 1000);
					break;
				case EventReceiveFilter.Closest:
					distance = (transform.position - position).sqrMagnitude;
					break;
				}
				Instance.ValidReceivers.Add(new CustomEventCandidate(distance, customEventReceiver, transform, randomId));
			}
			switch (customEventByName.eventRcvFilterMode)
			{
			case EventReceiveFilter.Closest:
			{
				Instance.ValidReceivers.Sort((CustomEventCandidate x, CustomEventCandidate y) => x.DistanceAway.CompareTo(y.DistanceAway));
				int filterModeQty = customEventByName.filterModeQty;
				int count = Instance.ValidReceivers.Count - filterModeQty;
				Instance.ValidReceivers.RemoveRange(filterModeQty, count);
				break;
			}
			case EventReceiveFilter.Random:
			{
				Instance.ValidReceivers.Sort((CustomEventCandidate x, CustomEventCandidate y) => x.RandomId.CompareTo(y.RandomId));
				int filterModeQty = customEventByName.filterModeQty;
				int count = Instance.ValidReceivers.Count - filterModeQty;
				Instance.ValidReceivers.RemoveRange(filterModeQty, count);
				break;
			}
			}
			for (int k = 0; k < Instance.ValidReceivers.Count; k++)
			{
				Instance.ValidReceivers[k].Receiver.ReceiveEvent(customEventName, position);
			}
		}

		public static bool CustomEventExists(string customEventName)
		{
			if (AppIsShuttingDown)
			{
				return true;
			}
			return Instance.customEvents.FindAll((CustomEvent obj) => obj.EventName == customEventName).Count > 0;
		}

		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			List<ICustomEventReceiver> list = origin.GetComponentsInChildren<ICustomEventReceiver>().ToList();
			list.RemoveAll((ICustomEventReceiver rec) => !rec.SubscribesToEvent(eventName));
			if (includeSelf)
			{
				return list;
			}
			return FilterOutSelf(list, origin);
		}

		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			List<ICustomEventReceiver> list = origin.GetComponentsInParent<ICustomEventReceiver>().ToList();
			list.RemoveAll((ICustomEventReceiver rec) => !rec.SubscribesToEvent(eventName));
			if (includeSelf)
			{
				return list;
			}
			return FilterOutSelf(list, origin);
		}

		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			List<ICustomEventReceiver> list = new List<ICustomEventReceiver>();
			foreach (ICustomEventReceiver source in sourceList)
			{
				MonoBehaviour monoBehaviour = source as MonoBehaviour;
				if (!(monoBehaviour == null) && !(monoBehaviour.transform != origin))
				{
					list.Add(source);
				}
			}
			int num = 0;
			while (list.Count > 0 && num < 20)
			{
				sourceList.Remove(list[0]);
				list.RemoveAt(0);
				num++;
			}
			return sourceList;
		}

		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			if (IsWarming)
			{
				return false;
			}
			if (Instance.disableLogging)
			{
				return false;
			}
			if (grp != null && grp.logSound)
			{
				return true;
			}
			return Instance.LogSounds;
		}

		private static void LogMessage(string message)
		{
			if (!Instance.disableLogging)
			{
				UnityEngine.Debug.Log("T: " + Time.time + " - MasterAudio " + message);
			}
		}

		public static void LogWarning(string msg)
		{
			if (!Instance.disableLogging)
			{
				UnityEngine.Debug.LogWarning(msg);
			}
		}

		public static void LogError(string msg)
		{
			if (!Instance.disableLogging)
			{
				UnityEngine.Debug.LogError(msg);
			}
		}

		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
			LogWarning("There is currently no Playlist assigned to Playlist Controller '" + playlistControllerName + "'. Cannot call '" + methodName + "' method.");
		}

		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			if (pcs.Count == 0)
			{
				LogError($"You have no Playlist Controllers in the Scene. You cannot '{methodName}'.");
				return false;
			}
			if (pcs.Count > 1)
			{
				LogError($"You cannot call '{methodName}' without specifying a Playlist Controller name when you have more than one Playlist Controller.");
				return false;
			}
			return true;
		}

		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
			if (SafeInstance == null)
			{
				return;
			}
			foreach (TransformFollower transFollowerColliderPositionRecalc in Instance.TransFollowerColliderPositionRecalcs)
			{
				if (transFollowerColliderPositionRecalc == follower)
				{
					return;
				}
			}
			Instance.TransFollowerColliderPositionRecalcs.Enqueue(follower);
		}

		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
			if (SafeInstance == null)
			{
				return;
			}
			foreach (SoundGroupVariationUpdater queuedOcclusionRay in Instance.QueuedOcclusionRays)
			{
				if (queuedOcclusionRay == updater)
				{
					return;
				}
			}
			Instance.QueuedOcclusionRays.Enqueue(updater);
		}

		public static void AddToOcclusionInRangeSources(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories)
			{
				if (!Instance.OcclusionSourcesInRange.Contains(src))
				{
					Instance.OcclusionSourcesInRange.Add(src);
				}
				if (Instance.OcclusionSourcesOutOfRange.Contains(src))
				{
					Instance.OcclusionSourcesOutOfRange.Remove(src);
				}
			}
		}

		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories)
			{
				if (!Instance.OcclusionSourcesOutOfRange.Contains(src))
				{
					Instance.OcclusionSourcesOutOfRange.Add(src);
				}
				if (Instance.OcclusionSourcesInRange.Contains(src))
				{
					Instance.OcclusionSourcesInRange.Remove(src);
				}
				RemoveFromBlockedOcclusionSources(src);
			}
		}

		public static void AddToBlockedOcclusionSources(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories && !Instance.OcclusionSourcesBlocked.Contains(src))
			{
				Instance.OcclusionSourcesBlocked.Add(src);
			}
		}

		public static bool HasQueuedOcclusionRays()
		{
			return Instance.QueuedOcclusionRays.Count > 0;
		}

		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			if (SafeInstance == null)
			{
				return null;
			}
			return Instance.QueuedOcclusionRays.Dequeue();
		}

		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			for (int i = 0; i < Instance.VariationOcclusionFreqChanges.Count; i++)
			{
				if (Instance.VariationOcclusionFreqChanges[i].ActingVariation == variation)
				{
					return true;
				}
			}
			return false;
		}

		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
			for (int i = 0; i < Instance.VariationOcclusionFreqChanges.Count; i++)
			{
				if (!(Instance.VariationOcclusionFreqChanges[i].ActingVariation != variation))
				{
					Instance.VariationOcclusionFreqChanges.RemoveAt(i);
					break;
				}
			}
		}

		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories && Instance.OcclusionSourcesBlocked.Contains(src))
			{
				Instance.OcclusionSourcesBlocked.Remove(src);
			}
		}

		public static void StopTrackingOcclusionForSource(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories)
			{
				if (Instance.OcclusionSourcesOutOfRange.Contains(src))
				{
					Instance.OcclusionSourcesOutOfRange.Remove(src);
				}
				if (Instance.OcclusionSourcesInRange.Contains(src))
				{
					Instance.OcclusionSourcesInRange.Remove(src);
				}
				if (Instance.OcclusionSourcesBlocked.Contains(src))
				{
					Instance.OcclusionSourcesBlocked.Remove(src);
				}
			}
		}

		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			if (!Instance._isStoppingMultiple)
			{
				return false;
			}
			return Instance.VariationsStartedDuringMultiStop.Contains(variation);
		}

		public static int RemainingClipsInGroup(string sType)
		{
			if (!Instance._randomizer.ContainsKey(sType))
			{
				return 0;
			}
			return Instance._randomizer[sType].Count;
		}

		public static bool HasAsyncResourceLoaderFeature()
		{
			return true;
		}

		public static void RescanGroupsNow()
		{
			Instance._mustRescanGroups = true;
		}

		public static void DoneRescanningGroups()
		{
			Instance._mustRescanGroups = false;
		}

		public static GameObject CreateMasterAudio()
		{
			UnityEngine.Object @object = Resources.Load("Assets/Plugins/DarkTonic/MasterAudio/Prefabs/MasterAudio.prefab", typeof(GameObject));
			if (@object == null)
			{
				UnityEngine.Debug.LogError("Could not find MasterAudio prefab. Please update the Installation Path in the Master Audio Manager window if you have moved the folder from its default location, then try again.");
				return null;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(@object) as GameObject;
			gameObject.name = "MasterAudio";
			return gameObject;
		}

		public static GameObject CreatePlaylistController()
		{
			UnityEngine.Object @object = Resources.Load("Assets/Plugins/DarkTonic/MasterAudio/Prefabs/PlaylistController.prefab", typeof(GameObject));
			if (@object == null)
			{
				UnityEngine.Debug.LogError("Could not find PlaylistController prefab. Please update the Installation Path in the Master Audio Manager window if you have moved the folder from its default location, then try again.");
				return null;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(@object) as GameObject;
			gameObject.name = "PlaylistController";
			return gameObject;
		}

		public static GameObject CreateDynamicSoundGroupCreator()
		{
			UnityEngine.Object @object = Resources.Load("Assets/Plugins/DarkTonic/MasterAudio/Prefabs/DynamicSoundGroupCreator.prefab", typeof(GameObject));
			if (@object == null)
			{
				UnityEngine.Debug.LogError("Could not find DynamicSoundGroupCreator prefab. Please update the Installation Path in the Master Audio Manager window if you have moved the folder from its default location, then try again.");
				return null;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(@object) as GameObject;
			gameObject.name = "DynamicSoundGroupCreator";
			return gameObject;
		}

		public static GameObject CreateSoundGroupOrganizer()
		{
			UnityEngine.Object @object = Resources.Load("Assets/Plugins/DarkTonic/MasterAudio/Prefabs/SoundGroupOrganizer.prefab", typeof(GameObject));
			if (@object == null)
			{
				UnityEngine.Debug.LogError("Could not find SoundGroupOrganizer prefab. Please update the Installation Path in the Master Audio Manager window if you have moved the folder from its default location, then try again.");
				return null;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(@object) as GameObject;
			gameObject.name = "SoundGroupOrganizer";
			return gameObject;
		}
	}
	public static class PersistentAudioSettings
	{
		public const string SfxVolKey = "MA_sfxVolume";

		public const string MusicVolKey = "MA_musicVolume";

		public const string SfxMuteKey = "MA_sfxMute";

		public const string MusicMuteKey = "MA_musicMute";

		public const string BusVolKey = "MA_BusVolume_";

		public const string GroupVolKey = "MA_GroupVolume_";

		public const string BusKeysKey = "MA_BusKeys";

		public const string GroupKeysKey = "MA_GroupsKeys";

		public const string Separator = ";";

		public static string BusesUpdatedKeys
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_BusKeys"))
				{
					PlayerPrefs.SetString("MA_BusKeys", ";");
				}
				return PlayerPrefs.GetString("MA_BusKeys");
			}
			set
			{
				PlayerPrefs.SetString("MA_BusKeys", value);
			}
		}

		public static string GroupsUpdatedKeys
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_GroupsKeys"))
				{
					PlayerPrefs.SetString("MA_GroupsKeys", ";");
				}
				return PlayerPrefs.GetString("MA_GroupsKeys");
			}
			set
			{
				PlayerPrefs.SetString("MA_GroupsKeys", value);
			}
		}

		public static bool? MixerMuted
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_sfxMute"))
				{
					return null;
				}
				return PlayerPrefs.GetInt("MA_sfxMute") != 0;
			}
			set
			{
				if (!value.HasValue)
				{
					PlayerPrefs.DeleteKey("MA_sfxMute");
					return;
				}
				bool value2 = value.Value;
				PlayerPrefs.SetInt("MA_sfxMute", value2 ? 1 : 0);
				MasterAudio safeInstance = MasterAudio.SafeInstance;
				if (safeInstance != null)
				{
					MasterAudio.MixerMuted = value2;
				}
			}
		}

		public static float? MixerVolume
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_sfxVolume"))
				{
					return null;
				}
				return PlayerPrefs.GetFloat("MA_sfxVolume");
			}
			set
			{
				if (!value.HasValue)
				{
					PlayerPrefs.DeleteKey("MA_sfxVolume");
					return;
				}
				float value2 = value.Value;
				PlayerPrefs.SetFloat("MA_sfxVolume", value2);
				MasterAudio safeInstance = MasterAudio.SafeInstance;
				if (safeInstance != null)
				{
					MasterAudio.MasterVolumeLevel = value2;
				}
			}
		}

		public static bool? MusicMuted
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_musicMute"))
				{
					return null;
				}
				return PlayerPrefs.GetInt("MA_musicMute") != 0;
			}
			set
			{
				if (!value.HasValue)
				{
					PlayerPrefs.DeleteKey("MA_musicMute");
					return;
				}
				bool value2 = value.Value;
				PlayerPrefs.SetInt("MA_musicMute", value2 ? 1 : 0);
				MasterAudio safeInstance = MasterAudio.SafeInstance;
				if (safeInstance != null)
				{
					MasterAudio.PlaylistsMuted = value2;
				}
			}
		}

		public static float? MusicVolume
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_musicVolume"))
				{
					return null;
				}
				return PlayerPrefs.GetFloat("MA_musicVolume");
			}
			set
			{
				if (!value.HasValue)
				{
					PlayerPrefs.DeleteKey("MA_musicVolume");
					return;
				}
				float value2 = value.Value;
				PlayerPrefs.SetFloat("MA_musicVolume", value2);
				MasterAudio safeInstance = MasterAudio.SafeInstance;
				if (safeInstance != null)
				{
					MasterAudio.PlaylistMasterVolume = value2;
				}
			}
		}

		public static void SetBusVolume(string busName, float vol)
		{
			string key = MakeBusKey(busName);
			PlayerPrefs.SetFloat(key, vol);
			MasterAudio safeInstance = MasterAudio.SafeInstance;
			if (!(safeInstance == null))
			{
				if (MasterAudio.GrabBusByName(busName) != null)
				{
					MasterAudio.SetBusVolumeByName(busName, vol);
				}
				if (!BusesUpdatedKeys.Contains(";" + busName + ";"))
				{
					BusesUpdatedKeys = BusesUpdatedKeys + busName + ";";
				}
			}
		}

		public static string MakeBusKey(string busName)
		{
			return "MA_BusVolume_" + busName;
		}

		public static float? GetBusVolume(string busName)
		{
			string key = MakeBusKey(busName);
			if (!PlayerPrefs.HasKey(key))
			{
				return null;
			}
			return PlayerPrefs.GetFloat(key);
		}

		public static string GetGroupKey(string groupName)
		{
			return "MA_GroupVolume_" + groupName;
		}

		public static void SetGroupVolume(string grpName, float vol)
		{
			string groupKey = GetGroupKey(grpName);
			PlayerPrefs.SetFloat(groupKey, vol);
			MasterAudio safeInstance = MasterAudio.SafeInstance;
			if (!(safeInstance == null))
			{
				if (MasterAudio.GrabGroup(grpName, logIfMissing: false) != null)
				{
					MasterAudio.SetGroupVolume(grpName, vol);
				}
				if (!GroupsUpdatedKeys.Contains(";" + grpName + ";"))
				{
					GroupsUpdatedKeys = GroupsUpdatedKeys + grpName + ";";
				}
			}
		}

		public static float? GetGroupVolume(string grpName)
		{
			string groupKey = GetGroupKey(grpName);
			if (!PlayerPrefs.HasKey(groupKey))
			{
				return null;
			}
			return PlayerPrefs.GetFloat(groupKey);
		}

		public static void RestoreMasterSettings()
		{
			if (MixerVolume.HasValue)
			{
				MasterAudio.MasterVolumeLevel = MixerVolume.Value;
			}
			if (MixerMuted.HasValue)
			{
				MasterAudio.MixerMuted = MixerMuted.Value;
			}
			if (MusicVolume.HasValue)
			{
				MasterAudio.PlaylistMasterVolume = MusicVolume.Value;
			}
			if (MusicMuted.HasValue)
			{
				MasterAudio.PlaylistsMuted = MusicMuted.Value;
			}
		}
	}
	public class SoundGroupOrganizer : MonoBehaviour
	{
		public class CustomEventSelection
		{
			public CustomEvent Event;

			public bool IsSelected;

			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
				Event = cEvent;
				IsSelected = isSelected;
			}
		}

		public class SoundGroupSelection
		{
			public GameObject Go;

			public bool IsSelected;

			public SoundGroupSelection(GameObject go, bool isSelected)
			{
				Go = go;
				IsSelected = isSelected;
			}
		}

		public enum MAItemType
		{
			SoundGroups,
			CustomEvents
		}

		public enum TransferMode
		{
			None,
			Import,
			Export
		}

		public GameObject dynGroupTemplate;

		public GameObject dynVariationTemplate;

		public GameObject maGroupTemplate;

		public GameObject maVariationTemplate;

		public MasterAudio.DragGroupMode curDragGroupMode;

		public MasterAudio.AudioLocation bulkVariationMode;

		public SystemLanguage previewLanguage = SystemLanguage.English;

		public bool useTextGroupFilter;

		public string textGroupFilter = string.Empty;

		public TransferMode transMode;

		public GameObject sourceObject;

		public List<SoundGroupSelection> selectedSourceSoundGroups = new List<SoundGroupSelection>();

		public GameObject destObject;

		public List<SoundGroupSelection> selectedDestSoundGroups = new List<SoundGroupSelection>();

		public MAItemType itemType;

		public List<CustomEventSelection> selectedSourceCustomEvents = new List<CustomEventSelection>();

		public List<CustomEventSelection> selectedDestCustomEvents = new List<CustomEventSelection>();

		public List<CustomEvent> customEvents = new List<CustomEvent>();

		public List<CustomEventCategory> customEventCategories = new List<CustomEventCategory>
		{
			new CustomEventCategory()
		};

		public string newEventName = "my event";

		public string newCustomEventCategoryName = "New Category";

		public string addToCustomEventCategoryName = "New Category";

		private void Awake()
		{
			UnityEngine.Debug.LogError("You have a Sound Group Organizer prefab in this Scene. You should never play a Scene with that type of prefab as it could take up tremendous amounts of audio memory. Please use a Sandbox Scene for that, which is only used to make changes to that prefab and apply them. This Sandbox Scene should never be a Scene that is played in the game.");
		}
	}
	public static class AmbientUtil
	{
		public const string FollowerHolderName = "_Followers";

		public const string ListenerFollowerName = "~ListenerFollower~";

		public const float ListenerFollowerTrigRadius = 0.01f;

		private static Transform _followerHolder;

		private static ListenerFollower _listenerFollower;

		private static Rigidbody _listenerFollowerRB;

		public static ListenerFollower ListenerFollower
		{
			get
			{
				if (_listenerFollower != null)
				{
					return _listenerFollower;
				}
				if (FollowerHolder == null)
				{
					return null;
				}
				Transform transform = FollowerHolder.GetChildTransform("~ListenerFollower~");
				if (transform == null)
				{
					transform = new GameObject("~ListenerFollower~").transform;
					transform.parent = FollowerHolder;
					transform.gameObject.layer = FollowerHolder.gameObject.layer;
				}
				_listenerFollower = transform.GetComponent<ListenerFollower>();
				if (_listenerFollower == null)
				{
					_listenerFollower = transform.gameObject.AddComponent<ListenerFollower>();
				}
				if (MasterAudio.Instance.listenerFollowerHasRigidBody)
				{
					Rigidbody rigidbody = transform.gameObject.GetComponent<Rigidbody>();
					if (rigidbody == null)
					{
						rigidbody = transform.gameObject.AddComponent<Rigidbody>();
					}
					rigidbody.useGravity = false;
					_listenerFollowerRB = rigidbody;
				}
				return _listenerFollower;
			}
		}

		public static Transform FollowerHolder
		{
			get
			{
				if (!Application.isPlaying || MasterAudio.SafeInstance == null)
				{
					return null;
				}
				if (_followerHolder != null)
				{
					return _followerHolder;
				}
				Transform trans = MasterAudio.SafeInstance.Trans;
				_followerHolder = trans.GetChildTransform("_Followers");
				if (_followerHolder != null)
				{
					return _followerHolder;
				}
				_followerHolder = new GameObject("_Followers").transform;
				_followerHolder.parent = trans;
				_followerHolder.gameObject.layer = trans.gameObject.layer;
				return _followerHolder;
			}
		}

		public static bool HasListenerFollower => _listenerFollower != null;

		public static bool HasListenerFolowerRigidBody => _listenerFollowerRB != null;

		public static void InitFollowerHolder()
		{
			Transform followerHolder = FollowerHolder;
			if (followerHolder != null)
			{
				followerHolder.DestroyAllChildren();
			}
		}

		public static bool InitListenerFollower()
		{
			Transform listenerTrans = MasterAudio.ListenerTrans;
			if (listenerTrans == null)
			{
				return false;
			}
			ListenerFollower listenerFollower = ListenerFollower;
			if (listenerFollower == null)
			{
				return false;
			}
			listenerFollower.StartFollowing(listenerTrans, "[None]", 0.01f);
			return true;
		}

		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders)
		{
			if (ListenerFollower == null || FollowerHolder == null)
			{
				return null;
			}
			MasterAudioGroup masterAudioGroup = MasterAudio.GrabGroup(soundGroupName);
			if (masterAudioGroup == null)
			{
				return null;
			}
			if (masterAudioGroup.groupVariations.Count == 0)
			{
				return null;
			}
			float maxDistance = masterAudioGroup.groupVariations[0].VarAudio.maxDistance;
			GameObject gameObject = new GameObject(followerName);
			Transform childTransform = FollowerHolder.GetChildTransform(followerName);
			if (childTransform != null)
			{
				UnityEngine.Object.Destroy(childTransform.gameObject);
			}
			gameObject.transform.parent = FollowerHolder;
			gameObject.gameObject.layer = FollowerHolder.gameObject.layer;
			TransformFollower transformFollower = gameObject.gameObject.AddComponent<TransformFollower>();
			transformFollower.StartFollowing(transToFollow, soundGroupName, maxDistance, willFollowSource, willPositionOnClosestColliderPoint, useTopCollider, useChildColliders);
			return gameObject.transform;
		}
	}
	public static class ArrayListUtil
	{
		public static void SortIntArray(ref List<int> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				int value = list[i];
				int index = UnityEngine.Random.Range(i, list.Count);
				list[i] = list[index];
				list[index] = value;
			}
		}

		public static bool IsExcludedChildName(string name)
		{
			return MasterAudio.ExemptChildNames.Contains(name);
		}
	}
	public static class AudioTransformExtensions
	{
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
			MasterAudio.FadeOutSoundGroupOfTransform(sourceTrans, sType, fadeTime);
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return MasterAudio.GetAllPlayingVariationsOfTransform(sourceTrans);
		}

		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return MasterAudio.PlaySound3DAtTransformAndForget(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName);
		}

		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return MasterAudio.PlaySound3DAtTransform(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName);
		}

		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return MasterAudio.PlaySound3DFollowTransformAndForget(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName);
		}

		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return MasterAudio.PlaySound3DFollowTransform(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName);
		}

		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, Action completedAction = null)
		{
			return MasterAudio.PlaySound3DAtTransformAndWaitUntilFinished(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName, timeToSchedulePlay, completedAction);
		}

		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, Action completedAction = null)
		{
			return MasterAudio.PlaySound3DFollowTransformAndWaitUntilFinished(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName, timeToSchedulePlay, completedAction);
		}

		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
			MasterAudio.PauseAllSoundsOfTransform(sourceTrans);
		}

		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
			MasterAudio.PauseBusOfTransform(sourceTrans, busName);
		}

		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
			MasterAudio.PauseSoundGroupOfTransform(sourceTrans, sType);
		}

		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
			MasterAudio.StopAllSoundsOfTransform(sourceTrans);
		}

		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
			MasterAudio.StopBusOfTransform(sourceTrans, busName);
		}

		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
			MasterAudio.StopSoundGroupOfTransform(sourceTrans, sType);
		}

		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
			MasterAudio.UnpauseAllSoundsOfTransform(sourceTrans);
		}

		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
			MasterAudio.UnpauseBusOfTransform(sourceTrans, busName);
		}

		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
			MasterAudio.UnpauseSoundGroupOfTransform(sourceTrans, sType);
		}

		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return MasterAudio.IsTransformPlayingSoundGroup(sType, sourceTrans);
		}
	}
	public class AudioTransformTracker : MonoBehaviour
	{
		public int _frames;

		private Transform _trans;

		public Transform Trans
		{
			get
			{
				if (_trans == null)
				{
					_trans = base.transform;
				}
				return _trans;
			}
		}

		private void Update()
		{
			_frames++;
		}
	}
	public static class AudioUtil
	{
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		private const float SemitonePitchChangeAmt = 1.0594635f;

		public static float FixedDeltaTime => UnityEngine.Time.fixedDeltaTime;

		public static float FrameTime => UnityEngine.Time.unscaledDeltaTime;

		public static float Time => UnityEngine.Time.unscaledTime;

		public static int FrameCount => UnityEngine.Time.frameCount;

		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return updater.MinOcclusionFreq - updater.MaxOcclusionFreq;
		}

		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return updater.MaxOcclusionFreq;
		}

		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return updater.MinOcclusionFreq;
		}

		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return MaxCutoffFreq(updater) + distRatio * CutoffRange(updater);
		}

		public static float GetSemitonesFromPitch(float pitch)
		{
			if (pitch < 1f && pitch > 0f)
			{
				float f = 1f / pitch;
				return Mathf.Log(f, 1.0594635f) * -1f;
			}
			return Mathf.Log(pitch, 1.0594635f);
		}

		public static float GetPitchFromSemitones(float semitones)
		{
			if (semitones >= 0f)
			{
				return Mathf.Pow(1.0594635f, semitones);
			}
			return 1f / Mathf.Pow(1.0594635f, Mathf.Abs(semitones));
		}

		public static float GetDbFromFloatVolume(float vol)
		{
			return Mathf.Log10(vol) * 20f;
		}

		public static float GetFloatVolumeFromDb(float db)
		{
			return Mathf.Pow(10f, db / 20f);
		}

		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			if (source.clip == null || source.time == 0f)
			{
				return 0f;
			}
			return source.time / source.clip.length * 100f;
		}

		public static bool IsAudioPaused(AudioSource source)
		{
			return !source.isPlaying && GetAudioPlayedPercentage(source) > 0f;
		}

		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
			if (!AudioClipWillPreload(clip))
			{
				AudioLoaderOptimizer.AddNonPreloadedPlayingClip(clip, actor);
			}
		}

		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
			if (!(clip == null) && !AudioClipWillPreload(clip))
			{
				AudioLoaderOptimizer.RemoveNonPreloadedPlayingClip(clip, actor);
				if (!AudioLoaderOptimizer.IsAnyOfNonPreloadedClipPlaying(clip))
				{
					clip.UnloadAudioData();
				}
			}
		}

		public static bool AudioClipWillPreload(AudioClip clip)
		{
			if (clip == null)
			{
				return false;
			}
			return clip.preloadAudioData;
		}

		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return clip != null && clip.loadType != AudioClipLoadType.Streaming;
		}

		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return GetPositiveUsablePitch(source.pitch);
		}

		private static float GetPositiveUsablePitch(float pitch)
		{
			return (!(pitch > 0f)) ? 1f : pitch;
		}

		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return AdjustAudioClipDurationForPitch(duration, sourceWithPitch.pitch);
		}

		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return duration / GetPositiveUsablePitch(pitch);
		}

		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return duration * GetPositiveUsablePitch(sourceWithPitch);
		}
	}
	public static class CoroutineHelper
	{
		public static IEnumerator WaitForActualSeconds(float time)
		{
			float start = AudioUtil.Time;
			while (AudioUtil.Time < start + time)
			{
				yield return MasterAudio.EndOfFrameDelay;
			}
		}
	}
	public class DelayBetweenSongs : MonoBehaviour
	{
		public float minTimeToWait = 1f;

		public float maxTimeToWait = 2f;

		public string playlistControllerName = "PlaylistControllerBass";

		private PlaylistController _controller;

		private void Start()
		{
			_controller = PlaylistController.InstanceByName(playlistControllerName);
			_controller.SongEnded += SongEnded;
		}

		private void OnDisable()
		{
			_controller.SongEnded -= SongEnded;
		}

		private void SongEnded(string songName)
		{
			StopAllCoroutines();
			StartCoroutine(PlaySongWithDelay());
		}

		private IEnumerator PlaySongWithDelay()
		{
			float randomTime = UnityEngine.Random.Range(minTimeToWait, maxTimeToWait);
			if (MasterAudio.IgnoreTimeScale)
			{
				yield return StartCoroutine(CoroutineHelper.WaitForActualSeconds(randomTime));
			}
			else
			{
				yield return new WaitForSeconds(randomTime);
			}
			_controller.PlayNextSong();
		}
	}
	public static class DTMonoHelper
	{
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return transParent.Find(childName);
		}

		public static bool IsActive(GameObject go)
		{
			return go.activeInHierarchy;
		}

		public static void SetActive(GameObject go, bool isActive)
		{
			go.SetActive(isActive);
		}

		public static void DestroyAllChildren(this Transform tran)
		{
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < tran.childCount; i++)
			{
				list.Add(tran.GetChild(i).gameObject);
			}
			int num = 0;
			while (list.Count > 0 && num < 200)
			{
				GameObject gameObject = list[0];
				UnityEngine.Object.Destroy(gameObject);
				if (list[0] == gameObject)
				{
					list.RemoveAt(0);
				}
				num++;
			}
		}
	}
	[AudioScriptOrder(-35)]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		public enum CreateItemsWhen
		{
			FirstEnableOnly,
			EveryEnable
		}

		public const int ExtraHardCodedBusOptions = 1;

		public SystemLanguage previewLanguage = SystemLanguage.English;

		public MasterAudio.DragGroupMode curDragGroupMode;

		public GameObject groupTemplate;

		public GameObject variationTemplate;

		public bool errorOnDuplicates;

		public bool createOnAwake = true;

		public bool soundGroupsAreExpanded = true;

		public bool removeGroupsOnSceneChange = true;

		public CreateItemsWhen reUseMode;

		public bool showCustomEvents = true;

		public MasterAudio.AudioLocation bulkVariationMode;

		public List<CustomEvent> customEventsToCreate = new List<CustomEvent>();

		public List<CustomEventCategory> customEventCategories = new List<CustomEventCategory>
		{
			new CustomEventCategory()
		};

		public string newEventName = "my event";

		public string newCustomEventCategoryName = "New Category";

		public string addToCustomEventCategoryName = "New Category";

		public bool showMusicDucking = true;

		public List<DuckGroupInfo> musicDuckingSounds = new List<DuckGroupInfo>();

		public List<GroupBus> groupBuses = new List<GroupBus>();

		public bool playListExpanded;

		public bool playlistEditorExp = true;

		public List<MasterAudio.Playlist> musicPlaylists = new List<MasterAudio.Playlist>();

		public List<GameObject> audioSourceTemplates = new List<GameObject>(10);

		public string audioSourceTemplateName = "Max Distance 500";

		public bool groupByBus;

		public bool itemsCreatedEventExpanded;

		public string itemsCreatedCustomEvent = string.Empty;

		public bool showUnityMixerGroupAssignment = true;

		private bool _hasCreated;

		private readonly List<Transform> _groupsToRemove = new List<Transform>();

		private Transform _trans;

		private readonly List<DynamicSoundGroup> _groupsToCreate = new List<DynamicSoundGroup>();

		public static int HardCodedBusOptions => 3;

		public List<DynamicSoundGroup> GroupsToCreate => _groupsToCreate;

		public bool ShouldShowUnityAudioMixerGroupAssignments => showUnityMixerGroupAssignment;

		private void Awake()
		{
			_trans = base.transform;
			_hasCreated = false;
			AudioSource component = GetComponent<AudioSource>();
			if (component != null)
			{
				UnityEngine.Object.Destroy(component);
			}
		}

		private void OnEnable()
		{
			CreateItemsIfReady();
		}

		private void Start()
		{
			CreateItemsIfReady();
		}

		private void OnDisable()
		{
			if (!MasterAudio.AppIsShuttingDown && removeGroupsOnSceneChange && MasterAudio.SafeInstance != null)
			{
				RemoveItems();
			}
		}

		private void CreateItemsIfReady()
		{
			if (!(MasterAudio.SafeInstance == null) && createOnAwake && MasterAudio.SoundsReady && !_hasCreated)
			{
				CreateItems();
			}
		}

		public void RemoveItems()
		{
			for (int i = 0; i < groupBuses.Count; i++)
			{
				GroupBus groupBus = groupBuses[i];
				if (!groupBus.isExisting)
				{
					MasterAudio.DeleteBusByName(groupBus.busName);
				}
			}
			for (int j = 0; j < _groupsToRemove.Count; j++)
			{
				string sType = _groupsToRemove[j].name;
				MasterAudio.RemoveSoundGroupFromDuckList(sType);
				MasterAudio.DeleteSoundGroup(sType);
			}
			_groupsToRemove.Clear();
			for (int k = 0; k < customEventsToCreate.Count; k++)
			{
				CustomEvent customEvent = customEventsToCreate[k];
				MasterAudio.DeleteCustomEvent(customEvent.EventName);
			}
			for (int l = 0; l < customEventCategories.Count; l++)
			{
				CustomEventCategory aCat = customEventCategories[l];
				MasterAudio.Instance.customEventCategories.RemoveAll((CustomEventCategory cat) => cat.CatName == aCat.CatName && cat.IsTemporary);
			}
			for (int m = 0; m < musicPlaylists.Count; m++)
			{
				MasterAudio.Playlist playlist = musicPlaylists[m];
				MasterAudio.DeletePlaylist(playlist.playlistName);
			}
			if (reUseMode == CreateItemsWhen.EveryEnable)
			{
				_hasCreated = false;
			}
			MasterAudio.SilenceOrUnsilenceGroupsFromSoloChange();
		}

		public void CreateItems()
		{
			if (_hasCreated)
			{
				UnityEngine.Debug.LogWarning("DynamicSoundGroupCreator '" + base.transform.name + "' has already created its items. Cannot create again.");
				return;
			}
			MasterAudio instance = MasterAudio.Instance;
			if (instance == null)
			{
				return;
			}
			PopulateGroupData();
			for (int i = 0; i < groupBuses.Count; i++)
			{
				GroupBus groupBus = groupBuses[i];
				if (groupBus.isExisting)
				{
					GroupBus groupBus2 = MasterAudio.GrabBusByName(groupBus.busName);
					if (groupBus2 == null)
					{
						MasterAudio.LogWarning("Existing bus '" + groupBus.busName + "' was not found, specified in prefab '" + base.name + "'.");
					}
				}
				else
				{
					if (!MasterAudio.CreateBus(groupBus.busName, errorOnDuplicates, isTemporary: true))
					{
						continue;
					}
					GroupBus groupBus3 = MasterAudio.GrabBusByName(groupBus.busName);
					if (groupBus3 != null)
					{
						if (!PersistentAudioSettings.GetBusVolume(groupBus.busName).HasValue)
						{
							groupBus3.volume = groupBus.volume;
							groupBus3.OriginalVolume = groupBus3.volume;
						}
						groupBus3.voiceLimit = groupBus.voiceLimit;
						groupBus3.stopOldest = groupBus.stopOldest;
						groupBus3.forceTo2D = groupBus.forceTo2D;
						groupBus3.mixerChannel = groupBus.mixerChannel;
						groupBus3.isUsingOcclusion = groupBus.isUsingOcclusion;
					}
				}
			}
			for (int j = 0; j < _groupsToCreate.Count; j++)
			{
				DynamicSoundGroup dynamicSoundGroup = _groupsToCreate[j];
				string busName = string.Empty;
				int num = ((dynamicSoundGroup.busIndex != -1) ? dynamicSoundGroup.busIndex : 0);
				if (num >= HardCodedBusOptions)
				{
					GroupBus groupBus4 = groupBuses[num - HardCodedBusOptions];
					busName = groupBus4.busName;
				}
				dynamicSoundGroup.busName = busName;
				Transform transform = MasterAudio.CreateSoundGroup(dynamicSoundGroup, _trans.name, errorOnDuplicates);
				for (int k = 0; k < dynamicSoundGroup.groupVariations.Count; k++)
				{
					DynamicGroupVariation dynamicGroupVariation = dynamicSoundGroup.groupVariations[k];
					if (dynamicGroupVariation.LowPassFilter != null)
					{
						UnityEngine.Object.Destroy(dynamicGroupVariation.LowPassFilter);
					}
					if (dynamicGroupVariation.HighPassFilter != null)
					{
						UnityEngine.Object.Destroy(dynamicGroupVariation.HighPassFilter);
					}
					if (dynamicGroupVariation.DistortionFilter != null)
					{
						UnityEngine.Object.Destroy(dynamicGroupVariation.DistortionFilter);
					}
					if (dynamicGroupVariation.ChorusFilter != null)
					{
						UnityEngine.Object.Destroy(dynamicGroupVariation.ChorusFilter);
					}
					if (dynamicGroupVariation.EchoFilter != null)
					{
						UnityEngine.Object.Destroy(dynamicGroupVariation.EchoFilter);
					}
					if (dynamicGroupVariation.ReverbFilter != null)
					{
						UnityEngine.Object.Destroy(dynamicGroupVariation.ReverbFilter);
					}
				}
				if (!(transform == null))
				{
					_groupsToRemove.Add(transform);
				}
			}
			for (int l = 0; l < musicDuckingSounds.Count; l++)
			{
				DuckGroupInfo duckGroupInfo = musicDuckingSounds[l];
				if (!(duckGroupInfo.soundType == "[None]"))
				{
					MasterAudio.AddSoundGroupToDuckList(duckGroupInfo.soundType, duckGroupInfo.riseVolStart, duckGroupInfo.duckedVolumeCut, duckGroupInfo.unduckTime, isTemporary: true);
				}
			}
			for (int m = 0; m < customEventCategories.Count; m++)
			{
				CustomEventCategory customEventCategory = customEventCategories[m];
				MasterAudio.CreateCustomEventCategoryIfNotThere(customEventCategory.CatName, isTemporary: true);
			}
			for (int n = 0; n < customEventsToCreate.Count; n++)
			{
				CustomEvent customEvent = customEventsToCreate[n];
				MasterAudio.CreateCustomEvent(customEvent.EventName, customEvent.eventReceiveMode, customEvent.distanceThreshold, customEvent.eventRcvFilterMode, customEvent.filterModeQty, customEvent.categoryName, isTemporary: true, errorOnDuplicates);
			}
			for (int num2 = 0; num2 < musicPlaylists.Count; num2++)
			{
				MasterAudio.Playlist playlist = musicPlaylists[num2];
				playlist.isTemporary = true;
				MasterAudio.CreatePlaylist(playlist, errorOnDuplicates);
			}
			MasterAudio.SilenceOrUnsilenceGroupsFromSoloChange();
			_hasCreated = true;
			if (itemsCreatedEventExpanded)
			{
				FireEvents();
			}
		}

		private void FireEvents()
		{
			MasterAudio.FireCustomEventNextFrame(itemsCreatedCustomEvent, _trans);
		}

		public void PopulateGroupData()
		{
			if (_trans == null)
			{
				_trans = base.transform;
			}
			_groupsToCreate.Clear();
			for (int i = 0; i < _trans.childCount; i++)
			{
				DynamicSoundGroup component = _trans.GetChild(i).GetComponent<DynamicSoundGroup>();
				if (component == null)
				{
					continue;
				}
				component.groupVariations.Clear();
				for (int j = 0; j < component.transform.childCount; j++)
				{
					DynamicGroupVariation component2 = component.transform.GetChild(j).GetComponent<DynamicGroupVariation>();
					if (!(component2 == null))
					{
						component.groupVariations.Add(component2);
					}
				}
				_groupsToCreate.Add(component);
			}
		}
	}
}
[AudioScriptOrder(-10)]
public class ListenerFollower : MonoBehaviour
{
	private Transform _transToFollow;

	private GameObject _goToFollow;

	private Transform _trans;

	private GameObject _go;

	private SphereCollider _collider;

	public SphereCollider Trigger
	{
		get
		{
			if (_collider != null)
			{
				return _collider;
			}
			_collider = GameObj.AddComponent<SphereCollider>();
			_collider.isTrigger = true;
			return _collider;
		}
	}

	public GameObject GameObj
	{
		get
		{
			if (_go != null)
			{
				return _go;
			}
			_go = base.gameObject;
			return _go;
		}
	}

	public Transform Trans
	{
		get
		{
			if (_trans == null)
			{
				_trans = base.transform;
			}
			return _trans;
		}
	}

	private void Awake()
	{
		SphereCollider trigger = Trigger;
		if (!(trigger == null))
		{
		}
	}

	public void StartFollowing(Transform transToFollow, string soundType, float trigRadius)
	{
		_transToFollow = transToFollow;
		_goToFollow = transToFollow.gameObject;
		Trigger.radius = trigRadius;
	}

	private void LateUpdate()
	{
		BatchOcclusionRaycasts();
		if (!(_transToFollow == null) && DTMonoHelper.IsActive(_goToFollow))
		{
			Trans.position = _transToFollow.position;
		}
	}

	private void BatchOcclusionRaycasts()
	{
		if (!MasterAudio.Instance.useOcclusion)
		{
			return;
		}
		int num = 0;
		while (num < MasterAudio.Instance.occlusionMaxRayCastsPerFrame && MasterAudio.HasQueuedOcclusionRays())
		{
			SoundGroupVariationUpdater soundGroupVariationUpdater = MasterAudio.OldestQueuedOcclusionRay();
			if (!(soundGroupVariationUpdater == null) && soundGroupVariationUpdater.enabled && soundGroupVariationUpdater.RayCastForOcclusion())
			{
				num++;
			}
		}
	}
}
namespace DarkTonic.MasterAudio
{
	public static class FilePlayerPrefs
	{
		private static readonly Hashtable PlayerPrefsHashtable;

		private static bool _hashTableChanged;

		private static string _serializedOutput;

		private static readonly string SerializedInput;

		private const string ParametersSeperator = ";";

		private const string KeyValueSeperator = ":";

		private static readonly string FileName;

		static FilePlayerPrefs()
		{
			PlayerPrefsHashtable = new Hashtable();
			_serializedOutput = string.Empty;
			SerializedInput = string.Empty;
			FileName = Application.persistentDataPath + "/MAPlayerPrefs.txt";
			if (File.Exists(FileName))
			{
				StreamReader streamReader = new StreamReader(FileName);
				SerializedInput = streamReader.ReadLine();
				Deserialize();
				streamReader.Close();
			}
		}

		public static bool HasKey(string key)
		{
			return PlayerPrefsHashtable.ContainsKey(key);
		}

		public static void SetString(string key, string value)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				PlayerPrefsHashtable.Add(key, value);
			}
			else
			{
				PlayerPrefsHashtable[key] = value;
			}
			_hashTableChanged = true;
		}

		public static void SetInt(string key, int value)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				PlayerPrefsHashtable.Add(key, value);
			}
			else
			{
				PlayerPrefsHashtable[key] = value;
			}
			_hashTableChanged = true;
		}

		public static void SetFloat(string key, float value)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				PlayerPrefsHashtable.Add(key, value);
			}
			else
			{
				PlayerPrefsHashtable[key] = value;
			}
			_hashTableChanged = true;
		}

		public static void SetBool(string key, bool value)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				PlayerPrefsHashtable.Add(key, value);
			}
			else
			{
				PlayerPrefsHashtable[key] = value;
			}
			_hashTableChanged = true;
		}

		public static string GetString(string key)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return PlayerPrefsHashtable[key].ToString();
			}
			return null;
		}

		public static string GetString(string key, string defaultValue)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return PlayerPrefsHashtable[key].ToString();
			}
			PlayerPrefsHashtable.Add(key, defaultValue);
			_hashTableChanged = true;
			return defaultValue;
		}

		public static int GetInt(string key)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				return 0;
			}
			object obj = PlayerPrefsHashtable[key];
			if (obj is int)
			{
				return (int)obj;
			}
			int num = int.Parse(obj.ToString());
			PlayerPrefsHashtable[key] = num;
			obj = num;
			return (int)obj;
		}

		public static int GetInt(string key, int defaultValue)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return (int)PlayerPrefsHashtable[key];
			}
			PlayerPrefsHashtable.Add(key, defaultValue);
			_hashTableChanged = true;
			return defaultValue;
		}

		public static float GetFloat(string key)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				return 0f;
			}
			object obj = PlayerPrefsHashtable[key];
			if (obj is float)
			{
				return (float)obj;
			}
			float num = float.Parse(obj.ToString());
			PlayerPrefsHashtable[key] = num;
			obj = num;
			return (float)obj;
		}

		public static float GetFloat(string key, float defaultValue)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return (float)PlayerPrefsHashtable[key];
			}
			PlayerPrefsHashtable.Add(key, defaultValue);
			_hashTableChanged = true;
			return defaultValue;
		}

		public static bool GetBool(string key)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return (bool)PlayerPrefsHashtable[key];
			}
			return false;
		}

		public static bool GetBool(string key, bool defaultValue)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return (bool)PlayerPrefsHashtable[key];
			}
			PlayerPrefsHashtable.Add(key, defaultValue);
			_hashTableChanged = true;
			return defaultValue;
		}

		public static void DeleteKey(string key)
		{
			PlayerPrefsHashtable.Remove(key);
		}

		public static void DeleteAll()
		{
			PlayerPrefsHashtable.Clear();
		}

		public static void Flush()
		{
			if (_hashTableChanged)
			{
				Serialize();
				StreamWriter streamWriter = File.CreateText(FileName);
				if (streamWriter == null)
				{
					UnityEngine.Debug.LogWarning("PlayerPrefs::Flush() opening file for writing failed: " + FileName);
				}
				streamWriter.WriteLine(_serializedOutput);
				streamWriter.Close();
				_serializedOutput = string.Empty;
			}
		}

		private static void Serialize()
		{
			IDictionaryEnumerator enumerator = PlayerPrefsHashtable.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (_serializedOutput != string.Empty)
				{
					_serializedOutput += " ; ";
				}
				string serializedOutput = _serializedOutput;
				_serializedOutput = serializedOutput + EscapeNonSeperators(enumerator.Key.ToString()) + " : " + EscapeNonSeperators(enumerator.Value.ToString()) + " : " + enumerator.Value.GetType();
			}
		}

		private static void Deserialize()
		{
			string[] array = SerializedInput.Split(new string[1] { " ; " }, StringSplitOptions.None);
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = text.Split(new string[1] { " : " }, StringSplitOptions.None);
				PlayerPrefsHashtable.Add(DeEscapeNonSeperators(array3[0]), GetTypeValue(array3[2], DeEscapeNonSeperators(array3[1])));
				if (array3.Length > 3)
				{
					UnityEngine.Debug.LogWarning("PlayerPrefs::Deserialize() parameterContent has " + array3.Length + " elements");
				}
			}
		}

		private static string EscapeNonSeperators(string inputToEscape)
		{
			inputToEscape = inputToEscape.Replace(":", "\\:");
			inputToEscape = inputToEscape.Replace(";", "\\;");
			return inputToEscape;
		}

		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			inputToDeEscape = inputToDeEscape.Replace("\\:", ":");
			inputToDeEscape = inputToDeEscape.Replace("\\;", ";");
			return inputToDeEscape;
		}

		public static object GetTypeValue(string typeName, string value)
		{
			switch (typeName)
			{
			case "System.String":
				return value;
			case "System.Int32":
				return Convert.ToInt32(value);
			case "System.Boolean":
				return Convert.ToBoolean(value);
			case "System.Single":
				return Convert.ToSingle(value);
			default:
				UnityEngine.Debug.Log("Unsupported type: " + typeName);
				return null;
			}
		}
	}
	[AudioScriptOrder(-80)]
	[RequireComponent(typeof(AudioSource))]
	public class PlaylistController : MonoBehaviour
	{
		public enum AudioPlayType
		{
			PlayNow,
			Schedule,
			AlreadyScheduled
		}

		public enum PlaylistStates
		{
			NotInScene,
			Stopped,
			Playing,
			Paused,
			Crossfading
		}

		public enum FadeMode
		{
			None,
			GradualFade
		}

		public enum AudioDuckingMode
		{
			NotDucking,
			SetToDuck,
			Ducked
		}

		public delegate void SongChangedEventHandler(string newSongName);

		public delegate void SongEndedEventHandler(string songName);

		public delegate void SongLoopedEventHandler(string songName);

		public const float ScheduledSongMinBadOffset = 0.5f;

		public const int FramesEarlyToTrigger = 2;

		public const int FramesEarlyToBeSyncable = 10;

		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		private const float MinSongLength = 0.5f;

		private const float SlowestFrameTimeForCalc = 0.3f;

		public bool startPlaylistOnAwake = true;

		public bool isShuffle;

		public bool isAutoAdvance = true;

		public bool loopPlaylist = true;

		public float _playlistVolume = 1f;

		public bool isMuted;

		public string startPlaylistName = string.Empty;

		public int syncGroupNum = -1;

		public AudioMixerGroup mixerChannel;

		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		public float spatialBlend;

		public bool initializedEventExpanded;

		public string initializedCustomEvent = string.Empty;

		public bool crossfadeStartedExpanded;

		public string crossfadeStartedCustomEvent = string.Empty;

		public bool songChangedEventExpanded;

		public string songChangedCustomEvent = string.Empty;

		public bool songEndedEventExpanded;

		public string songEndedCustomEvent = string.Empty;

		public bool songLoopedEventExpanded;

		public string songLoopedCustomEvent = string.Empty;

		public bool playlistStartedEventExpanded;

		public string playlistStartedCustomEvent = string.Empty;

		public bool playlistEndedEventExpanded;

		public string playlistEndedCustomEvent = string.Empty;

		private AudioSource _activeAudio;

		private AudioSource _transitioningAudio;

		private float _activeAudioEndVolume;

		private float _transitioningAudioStartVolume;

		private float _crossFadeStartTime;

		private readonly List<int> _clipsRemaining = new List<int>(10);

		private int _currentSequentialClipIndex;

		private AudioDuckingMode _duckingMode;

		private float _timeToStartUnducking;

		private float _timeToFinishUnducking;

		private float _originalMusicVolume;

		private float _initialDuckVolume;

		private float _duckRange;

		private MusicSetting _currentSong;

		private GameObject _go;

		private string _name;

		private FadeMode _curFadeMode;

		private float _slowFadeStartTime;

		private float _slowFadeCompletionTime;

		private float _slowFadeStartVolume;

		private float _slowFadeTargetVolume;

		private MasterAudio.Playlist _currentPlaylist;

		private float _lastTimeMissingPlaylistLogged = -5f;

		private Action _fadeCompleteCallback;

		private readonly List<MusicSetting> _queuedSongs = new List<MusicSetting>(5);

		private bool _lostFocus;

		private bool _autoStartedPlaylist;

		private AudioSource _audioClip;

		private AudioSource _transClip;

		private MusicSetting _newSongSetting;

		private bool _nextSongRequested;

		private bool _nextSongScheduled;

		private int _lastRandomClipIndex = -1;

		private float _lastTimeSongRequested = -1f;

		private float _currentDuckVolCut;

		private int? _lastSongPosition;

		private double? _currentSchedSongDspStartTime;

		private double? _currentSchedSongDspEndTime;

		private int _lastFrameSongPosition = -1;

		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource = new Dictionary<AudioSource, double>(2);

		public int _frames;

		private static List<PlaylistController> _instances;

		private int _songsPlayedFromPlaylist;

		private AudioSource _audio1;

		private AudioSource _audio2;

		private Transform _trans;

		private bool _willPersist;

		private double? _songPauseTime;

		private int framesOfSongPlayed;

		private bool SongIsNonAdvancible => CurrentPlaylist != null && CurrentPlaylist.songTransitionType == MasterAudio.SongFadeInPosition.SynchronizeClips && CrossFadeTime > 0f;

		private bool ShouldLoadAsync
		{
			get
			{
				if (MasterAudio.Instance.resourceClipsAllLoadAsync)
				{
					return true;
				}
				return CurrentPlaylist.resourceClipsAllLoadAsync;
			}
		}

		public bool ControllerIsReady { get; private set; }

		public PlaylistStates PlaylistState
		{
			get
			{
				if (_activeAudio == null || _transitioningAudio == null)
				{
					return PlaylistStates.NotInScene;
				}
				if (!ActiveAudioSource.isPlaying)
				{
					if (ActiveAudioSource.time != 0f)
					{
						return PlaylistStates.Paused;
					}
					return PlaylistStates.Stopped;
				}
				if (IsCrossFading)
				{
					return PlaylistStates.Crossfading;
				}
				return PlaylistStates.Playing;
			}
		}

		public AudioSource ActiveAudioSource
		{
			get
			{
				if (_activeAudio != null && _activeAudio.clip == null)
				{
					return _transitioningAudio;
				}
				return _activeAudio;
			}
		}

		public static List<PlaylistController> Instances
		{
			get
			{
				if (_instances != null)
				{
					return _instances;
				}
				_instances = new List<PlaylistController>();
				UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeof(PlaylistController));
				for (int i = 0; i < array.Length; i++)
				{
					_instances.Add(array[i] as PlaylistController);
				}
				return _instances;
			}
			set
			{
				_instances = value;
			}
		}

		public GameObject PlaylistControllerGameObject => _go;

		public AudioSource CurrentPlaylistSource => _activeAudio;

		public AudioClip CurrentPlaylistClip
		{
			get
			{
				if (_activeAudio == null)
				{
					return null;
				}
				return _activeAudio.clip;
			}
		}

		public AudioClip FadingPlaylistClip
		{
			get
			{
				if (!IsCrossFading)
				{
					return null;
				}
				if (_transitioningAudio == null)
				{
					return null;
				}
				return _transitioningAudio.clip;
			}
		}

		public AudioSource FadingSource
		{
			get
			{
				if (!IsCrossFading)
				{
					return null;
				}
				return _transitioningAudio;
			}
		}

		public bool IsCrossFading { get; private set; }

		public bool IsFading => IsCrossFading || _curFadeMode != FadeMode.None;

		public float PlaylistVolume
		{
			get
			{
				return MasterAudio.PlaylistMasterVolume * _playlistVolume;
			}
			set
			{
				_playlistVolume = value;
				UpdateMasterVolume();
			}
		}

		public MasterAudio.Playlist CurrentPlaylist
		{
			get
			{
				if (_currentPlaylist != null || !(Time.realtimeSinceStartup - _lastTimeMissingPlaylistLogged > 2f))
				{
					return _currentPlaylist;
				}
				UnityEngine.Debug.LogWarning("Current Playlist is NULL. Subsequent calls will fail.");
				_lastTimeMissingPlaylistLogged = AudioUtil.Time;
				return _currentPlaylist;
			}
		}

		public bool HasPlaylist => _currentPlaylist != null;

		public string PlaylistName
		{
			get
			{
				if (CurrentPlaylist == null)
				{
					return string.Empty;
				}
				return CurrentPlaylist.playlistName;
			}
		}

		private bool IsMuted => isMuted;

		private bool PlaylistIsMuted
		{
			set
			{
				isMuted = value;
				if (Application.isPlaying)
				{
					if (_activeAudio != null)
					{
						_activeAudio.mute = value;
					}
					if (_transitioningAudio != null)
					{
						_transitioningAudio.mute = value;
					}
				}
				else
				{
					AudioSource[] components = GetComponents<AudioSource>();
					for (int i = 0; i < components.Length; i++)
					{
						components[i].mute = value;
					}
				}
			}
		}

		private float CrossFadeTime
		{
			get
			{
				if (_currentPlaylist != null)
				{
					return (_currentPlaylist.crossfadeMode != 0) ? _currentPlaylist.crossFadeTime : MasterAudio.Instance.MasterCrossFadeTime;
				}
				return MasterAudio.Instance.MasterCrossFadeTime;
			}
		}

		private bool IsAutoAdvance
		{
			get
			{
				if (SongIsNonAdvancible)
				{
					return false;
				}
				return isAutoAdvance;
			}
		}

		public GameObject GameObj
		{
			get
			{
				if (_go != null)
				{
					return _go;
				}
				_go = base.gameObject;
				return _go;
			}
		}

		public string ControllerName
		{
			get
			{
				if (_name != null)
				{
					return _name;
				}
				_name = GameObj.name;
				return _name;
			}
		}

		public bool CanSchedule => MasterAudio.Instance.useGaplessPlaylists && IsAutoAdvance;

		private bool IsFrameFastEnough => AudioUtil.FrameTime < 0.3f;

		private bool ShouldNotSwitchEarly => CrossFadeTime <= 0f && CanSchedule;

		private Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		public int ClipsRemainingInCurrentPlaylist => _clipsRemaining.Count;

		public event SongChangedEventHandler SongChanged;

		public event SongEndedEventHandler SongEnded;

		public event SongLoopedEventHandler SongLooped;

		private void Awake()
		{
			base.useGUILayout = false;
			if (ControllerIsReady)
			{
				return;
			}
			ControllerIsReady = false;
			PlaylistController[] array = (PlaylistController[])UnityEngine.Object.FindObjectsOfType(typeof(PlaylistController));
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].ControllerName == ControllerName)
				{
					num++;
				}
			}
			if (num > 1)
			{
				UnityEngine.Object.DestroyImmediate(base.gameObject);
				UnityEngine.Object[] array2 = UnityEngine.Object.FindObjectsOfType(typeof(MasterAudio));
				bool flag = false;
				for (int j = 0; j < array2.Length; j++)
				{
					MasterAudio masterAudio = array2[j] as MasterAudio;
					if (masterAudio.persistBetweenScenes && masterAudio.shouldLogDestroys)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					UnityEngine.Debug.Log("More than one Playlist Controller prefab exists in this Scene with the same name. Destroying the one called '" + ControllerName + "'. You may wish to set up a Bootstrapper Scene so this does not occur.");
				}
				return;
			}
			_autoStartedPlaylist = false;
			_duckingMode = AudioDuckingMode.NotDucking;
			_currentSong = null;
			_songsPlayedFromPlaylist = 0;
			AudioSource[] components = GetComponents<AudioSource>();
			if (components.Length < 2)
			{
				UnityEngine.Debug.LogError("This prefab should have exactly two Audio Source components. Please revert it.");
				return;
			}
			MasterAudio safeInstance = MasterAudio.SafeInstance;
			_willPersist = safeInstance != null && safeInstance.persistBetweenScenes;
			_audio1 = components[0];
			_audio2 = components[1];
			_audio1.clip = null;
			_audio2.clip = null;
			if (_audio1.playOnAwake || _audio2.playOnAwake)
			{
				UnityEngine.Debug.LogWarning("One or more 'Play on Awake' checkboxes in the Audio Sources on Playlist Controller '" + base.name + "' are checked. These are not used in Master Audio. Make sure to uncheck them before hitting Play next time. For Playlist Controllers, use the similarly named checkbox 'Start Playlist on Awake' in the Playlist Controller's Inspector.");
			}
			_activeAudio = _audio1;
			_transitioningAudio = _audio2;
			_audio1.outputAudioMixerGroup = mixerChannel;
			_audio2.outputAudioMixerGroup = mixerChannel;
			SetSpatialBlend();
			_curFadeMode = FadeMode.None;
			_fadeCompleteCallback = null;
			_lostFocus = false;
		}

		public void SetSpatialBlend()
		{
			if (MasterAudio.SafeInstance == null)
			{
				return;
			}
			switch (MasterAudio.Instance.musicSpatialBlendType)
			{
			case MasterAudio.AllMusicSpatialBlendType.ForceAllTo2D:
				SetAudioSpatialBlend(0f);
				break;
			case MasterAudio.AllMusicSpatialBlendType.ForceAllTo3D:
				SetAudioSpatialBlend(1f);
				break;
			case MasterAudio.AllMusicSpatialBlendType.ForceAllToCustom:
				SetAudioSpatialBlend(MasterAudio.Instance.musicSpatialBlend);
				break;
			case MasterAudio.AllMusicSpatialBlendType.AllowDifferentPerController:
				switch (spatialBlendType)
				{
				case MasterAudio.ItemSpatialBlendType.ForceTo2D:
					SetAudioSpatialBlend(0f);
					break;
				case MasterAudio.ItemSpatialBlendType.ForceTo3D:
					SetAudioSpatialBlend(1f);
					break;
				case MasterAudio.ItemSpatialBlendType.ForceToCustom:
					SetAudioSpatialBlend(spatialBlend);
					break;
				case MasterAudio.ItemSpatialBlendType.UseCurveFromAudioSource:
					break;
				}
				break;
			}
		}

		private void SetAudiosIfEmpty()
		{
			AudioSource[] components = GetComponents<AudioSource>();
			_audio1 = components[0];
			_audio2 = components[1];
		}

		private void SetAudioSpatialBlend(float blend)
		{
			if (_audio1 == null)
			{
				SetAudiosIfEmpty();
			}
			_audio1.spatialBlend = blend;
			_audio2.spatialBlend = blend;
		}

		private void Start()
		{
			if (ControllerIsReady)
			{
				return;
			}
			if (MasterAudio.SafeInstance == null)
			{
				UnityEngine.Debug.LogError("No Master Audio game object exists in the Hierarchy. Aborting Playlist Controller setup code.");
				return;
			}
			if (!string.IsNullOrEmpty(startPlaylistName) && _currentPlaylist == null)
			{
				InitializePlaylist();
			}
			ControllerIsReady = true;
			if (initializedEventExpanded && initializedCustomEvent != string.Empty && initializedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(initializedCustomEvent, Trans, logDupe: false);
			}
			AutoStartPlaylist();
			if (IsMuted)
			{
				MutePlaylist();
			}
		}

		private void AutoStartPlaylist()
		{
			if (_currentPlaylist != null && startPlaylistOnAwake && IsFrameFastEnough && !_autoStartedPlaylist)
			{
				PlayNextOrRandom(AudioPlayType.PlayNow);
				_autoStartedPlaylist = true;
			}
		}

		private void CoUpdate()
		{
			if (MasterAudio.SafeInstance == null || _curFadeMode != FadeMode.GradualFade || _activeAudio == null)
			{
				return;
			}
			float val = 1f - (_slowFadeCompletionTime - AudioUtil.Time) / (_slowFadeCompletionTime - _slowFadeStartTime);
			val = Math.Min(val, 1f);
			val = Math.Max(val, 0f);
			float val2 = _slowFadeStartVolume + (_slowFadeTargetVolume - _slowFadeStartVolume) * val;
			val2 = ((!(_slowFadeTargetVolume > _slowFadeStartVolume)) ? Math.Max(val2, _slowFadeTargetVolume) : Math.Min(val2, _slowFadeTargetVolume));
			_playlistVolume = val2;
			UpdateMasterVolume();
			if (!(AudioUtil.Time < _slowFadeCompletionTime))
			{
				if (MasterAudio.Instance.stopZeroVolumePlaylists && _slowFadeTargetVolume == 0f)
				{
					StopPlaylist();
				}
				if (_fadeCompleteCallback != null)
				{
					_fadeCompleteCallback();
					_fadeCompleteCallback = null;
				}
				_curFadeMode = FadeMode.None;
			}
		}

		private void OnEnable()
		{
			_instances = null;
			List<AudioSource> list = new List<AudioSource>();
			list.Add(_audio1);
			list.Add(_audio2);
			MasterAudio.TrackRuntimeAudioSources(list);
		}

		private void OnDisable()
		{
			_instances = null;
			if (!(MasterAudio.SafeInstance == null) && !MasterAudio.AppIsShuttingDown)
			{
				if (ActiveAudioSource != null && ActiveAudioSource.clip != null && !_willPersist)
				{
					StopPlaylist();
				}
				List<AudioSource> list = new List<AudioSource>();
				list.Add(_audio1);
				list.Add(_audio2);
				MasterAudio.StopTrackingRuntimeAudioSources(list);
			}
		}

		private void OnApplicationPause(bool pauseStatus)
		{
			_lostFocus = pauseStatus;
		}

		private void Update()
		{
			_frames++;
			CoUpdate();
			if (_lostFocus || !ControllerIsReady)
			{
				return;
			}
			AutoStartPlaylist();
			if (_activeAudio.isPlaying)
			{
				framesOfSongPlayed++;
			}
			if (IsCrossFading)
			{
				if (_activeAudio.volume >= _activeAudioEndVolume)
				{
					CeaseAudioSource(_transitioningAudio);
					IsCrossFading = false;
					if (CanSchedule && !_nextSongScheduled)
					{
						PlayNextOrRandom(AudioPlayType.Schedule);
					}
					SetDuckProperties();
				}
				float num = Math.Max(CrossFadeTime, 0.001f);
				float num2 = (Time.realtimeSinceStartup - _crossFadeStartTime) / num;
				_activeAudio.volume = num2 * _activeAudioEndVolume;
				_transitioningAudio.volume = _transitioningAudioStartVolume * (1f - num2);
			}
			if (!_activeAudio.loop && _activeAudio.clip != null)
			{
				if (AudioUtil.IsAudioPaused(_activeAudio))
				{
					goto IL_042f;
				}
				if (!_activeAudio.isPlaying)
				{
					if (!IsAutoAdvance)
					{
						FirePlaylistEndedEventIfAny();
						CeaseAudioSource(_activeAudio);
						return;
					}
					bool flag = false;
					flag = ((!isShuffle) ? (_currentSequentialClipIndex >= _currentPlaylist.MusicSettings.Count) : (_clipsRemaining.Count == 0));
					if (flag && !_activeAudio.isPlaying)
					{
						FirePlaylistEndedEventIfAny();
						CeaseAudioSource(_activeAudio);
						return;
					}
				}
				bool flag2 = false;
				if (ShouldNotSwitchEarly)
				{
					if (_currentSchedSongDspStartTime.HasValue && AudioSettings.dspTime > _currentSchedSongDspStartTime.Value)
					{
						flag2 = true;
					}
				}
				else if (PlaylistState == PlaylistStates.Stopped)
				{
					flag2 = true;
				}
				else if (IsFrameFastEnough)
				{
					float num3 = _activeAudio.clip.length - _activeAudio.time - AudioUtil.AdjustEndLeadTimeForPitch(CrossFadeTime, _activeAudio);
					float num4 = AudioUtil.AdjustEndLeadTimeForPitch(AudioUtil.FrameTime * 2f, _activeAudio);
					flag2 = num3 <= num4;
				}
				if (flag2)
				{
					if (_currentPlaylist.fadeOutLastSong)
					{
						if (isShuffle)
						{
							if (_clipsRemaining.Count == 0 || !IsAutoAdvance)
							{
								FadeOutPlaylist();
								return;
							}
						}
						else if (_currentSequentialClipIndex >= _currentPlaylist.MusicSettings.Count || _currentPlaylist.MusicSettings.Count == 1 || !IsAutoAdvance)
						{
							FadeOutPlaylist();
							return;
						}
					}
					if (IsAutoAdvance && !_nextSongRequested && _lastTimeSongRequested + 0.5f <= AudioUtil.Time)
					{
						_lastTimeSongRequested = AudioUtil.Time;
						if (CanSchedule)
						{
							_lastSongPosition = null;
							FadeInScheduledSong();
						}
						else
						{
							_lastSongPosition = 0;
							PlayNextOrRandom(AudioPlayType.PlayNow);
						}
					}
				}
			}
			if (_activeAudio.loop && _activeAudio.clip != null)
			{
				if (_activeAudio.timeSamples < _lastFrameSongPosition)
				{
					string text = _activeAudio.clip.name;
					if (this.SongLooped != null && !string.IsNullOrEmpty(text))
					{
						this.SongLooped(text);
					}
					if (songLoopedEventExpanded && songLoopedCustomEvent != string.Empty && songLoopedCustomEvent != "[None]")
					{
						MasterAudio.FireCustomEvent(songLoopedCustomEvent, Trans, logDupe: false);
					}
				}
				_lastFrameSongPosition = _activeAudio.timeSamples;
			}
			goto IL_042f;
			IL_042f:
			if (!IsCrossFading)
			{
				AudioDucking();
			}
		}

		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			PlaylistController playlistController = Instances.Find((PlaylistController obj) => obj != null && obj.ControllerName == playlistControllerName);
			if (playlistController != null)
			{
				return playlistController;
			}
			if (errorIfNotFound)
			{
				UnityEngine.Debug.LogError("Could not find Playlist Controller '" + playlistControllerName + "'.");
			}
			return null;
		}

		public bool IsSongPlaying(string songName)
		{
			if (!HasPlaylist)
			{
				return false;
			}
			if (ActiveAudioSource == null || ActiveAudioSource.clip == null)
			{
				return false;
			}
			return ActiveAudioSource.clip.name == songName;
		}

		public void ClearQueue()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				_queuedSongs.Clear();
			}
		}

		public void ToggleMutePlaylist()
		{
			if (Application.isPlaying && !ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (IsMuted)
			{
				UnmutePlaylist();
			}
			else
			{
				MutePlaylist();
			}
		}

		public void MutePlaylist()
		{
			PlaylistIsMuted = true;
		}

		public void UnmutePlaylist()
		{
			PlaylistIsMuted = false;
		}

		public void PausePlaylist()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (!(_activeAudio == null) && !(_transitioningAudio == null))
			{
				if (_activeAudio.clip != null)
				{
					_activeAudio.Pause();
				}
				if (!_songPauseTime.HasValue)
				{
					_songPauseTime = AudioSettings.dspTime;
				}
				if (_transitioningAudio.clip != null)
				{
					_transitioningAudio.Pause();
				}
			}
		}

		public bool UnpausePlaylist()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				_songPauseTime = null;
				return false;
			}
			if (PlaylistState == PlaylistStates.Playing || PlaylistState == PlaylistStates.Crossfading || PlaylistState == PlaylistStates.Stopped)
			{
				_songPauseTime = null;
				return false;
			}
			if (_activeAudio == null || _transitioningAudio == null)
			{
				_songPauseTime = null;
				return false;
			}
			if (_activeAudio.clip == null && _currentPlaylist != null)
			{
				FinishPlaylistInit();
				_songPauseTime = null;
				return true;
			}
			if (_activeAudio.clip == null)
			{
				_songPauseTime = null;
				return false;
			}
			if (!_scheduledSongOffsetByAudioSource.ContainsKey(_activeAudio))
			{
				_activeAudio.Play();
				framesOfSongPlayed = 0;
				AudioUtil.ClipPlayed(_activeAudio.clip, GameObj);
			}
			else if (_songPauseTime.HasValue && _currentSchedSongDspStartTime.HasValue)
			{
				double dspTime = AudioSettings.dspTime;
				double num = dspTime - _songPauseTime.Value;
				double scheduledPlayTimeOffset = _currentSchedSongDspStartTime.Value - AudioSettings.dspTime + num;
				_songPauseTime = null;
				_activeAudio.Stop();
				ScheduleClipPlay(scheduledPlayTimeOffset, _activeAudio, calledAfterPause: true);
			}
			if (!_scheduledSongOffsetByAudioSource.ContainsKey(_transitioningAudio))
			{
				_transitioningAudio.Play();
				AudioUtil.ClipPlayed(_transitioningAudio.clip, GameObj);
			}
			else if (_songPauseTime.HasValue && _currentSchedSongDspStartTime.HasValue)
			{
				double dspTime2 = AudioSettings.dspTime;
				double num2 = dspTime2 - _songPauseTime.Value;
				double scheduledPlayTimeOffset2 = _currentSchedSongDspStartTime.Value - AudioSettings.dspTime + num2;
				_songPauseTime = null;
				_transitioningAudio.Stop();
				ScheduleClipPlay(scheduledPlayTimeOffset2, _transitioningAudio, calledAfterPause: true);
			}
			return true;
		}

		public void StopPlaylist(bool onlyFadingClip = false)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				if (!Application.isPlaying)
				{
					return;
				}
				_currentSchedSongDspStartTime = null;
				_currentSchedSongDspEndTime = null;
				_currentSong = null;
				PlaylistStates playlistState = PlaylistState;
				if (playlistState != 0 && playlistState != PlaylistStates.Stopped)
				{
					if (!onlyFadingClip)
					{
						CeaseAudioSource(_activeAudio);
					}
					CeaseAudioSource(_transitioningAudio);
				}
			}
		}

		public void FadeToVolume(float targetVolume, float fadeTime, Action callback = null)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (fadeTime <= 0.1f)
			{
				_playlistVolume = targetVolume;
				UpdateMasterVolume();
				_curFadeMode = FadeMode.None;
				return;
			}
			_curFadeMode = FadeMode.GradualFade;
			if (_duckingMode == AudioDuckingMode.NotDucking)
			{
				_slowFadeStartVolume = _playlistVolume;
			}
			else
			{
				_slowFadeStartVolume = _activeAudio.volume;
			}
			_slowFadeTargetVolume = targetVolume;
			_slowFadeStartTime = AudioUtil.Time;
			_slowFadeCompletionTime = AudioUtil.Time + fadeTime;
			_fadeCompleteCallback = callback;
		}

		public void PlayRandomSong()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				PlayARandomSong(AudioPlayType.PlayNow);
			}
		}

		public void PlayARandomSong(AudioPlayType playType)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (_clipsRemaining.Count == 0)
			{
				UnityEngine.Debug.LogWarning("There are no clips left in this Playlist. Turn on Loop Playlist if you want to loop the entire song selection.");
			}
			else
			{
				if (IsCrossFading && playType == AudioPlayType.Schedule)
				{
					return;
				}
				if (framesOfSongPlayed > 0)
				{
					_nextSongScheduled = false;
				}
				int num = UnityEngine.Random.Range(0, _clipsRemaining.Count);
				int index = _clipsRemaining[num];
				switch (playType)
				{
				case AudioPlayType.PlayNow:
					RemoveRandomClip(num);
					break;
				case AudioPlayType.Schedule:
					_lastRandomClipIndex = num;
					break;
				case AudioPlayType.AlreadyScheduled:
					if (_lastRandomClipIndex >= 0)
					{
						RemoveRandomClip(_lastRandomClipIndex);
					}
					break;
				}
				PlaySong(_currentPlaylist.MusicSettings[index], playType);
			}
		}

		private void RemoveRandomClip(int randIndex)
		{
			_clipsRemaining.RemoveAt(randIndex);
			if (loopPlaylist && _clipsRemaining.Count == 0)
			{
				FillClips();
			}
		}

		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
			if (_queuedSongs.Count == 0)
			{
				UnityEngine.Debug.LogWarning("There are zero queued songs in PlaylistController '" + ControllerName + "'. Cannot play first queued song.");
				return;
			}
			MusicSetting musicSetting = _queuedSongs[0];
			_queuedSongs.RemoveAt(0);
			_currentSequentialClipIndex = musicSetting.songIndex;
			PlaySong(musicSetting, playType);
		}

		public void PlayNextSong()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				PlayTheNextSong(AudioPlayType.PlayNow);
			}
		}

		public void PlayTheNextSong(AudioPlayType playType)
		{
			if (_currentPlaylist == null || (IsCrossFading && playType == AudioPlayType.Schedule))
			{
				return;
			}
			if (playType != AudioPlayType.AlreadyScheduled && _songsPlayedFromPlaylist > 0 && !_nextSongScheduled)
			{
				AdvanceSongCounter();
			}
			if (_currentSequentialClipIndex >= _currentPlaylist.MusicSettings.Count)
			{
				UnityEngine.Debug.LogWarning("There are no clips left in this Playlist. Turn on Loop Playlist if you want to loop the entire song selection.");
				return;
			}
			if (framesOfSongPlayed > 0)
			{
				_nextSongScheduled = false;
				_lastSongPosition = ActiveAudioSource.timeSamples;
			}
			PlaySong(_currentPlaylist.MusicSettings[_currentSequentialClipIndex], playType);
		}

		private void AdvanceSongCounter()
		{
			_currentSequentialClipIndex++;
			if (_currentSequentialClipIndex >= _currentPlaylist.MusicSettings.Count && loopPlaylist)
			{
				_currentSequentialClipIndex = 0;
			}
		}

		public void StopPlaylistAfterCurrentSong()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (_currentPlaylist == null)
			{
				MasterAudio.LogNoPlaylist(ControllerName, "StopPlaylistAfterCurrentSong");
				return;
			}
			if (!_activeAudio.isPlaying)
			{
				UnityEngine.Debug.Log("No song is currently playing.");
				return;
			}
			_activeAudio.loop = false;
			_queuedSongs.Clear();
			isAutoAdvance = false;
			if (_scheduledSongOffsetByAudioSource.ContainsKey(_activeAudio))
			{
				CeaseAudioSource(_activeAudio);
			}
			if (_scheduledSongOffsetByAudioSource.ContainsKey(_transitioningAudio))
			{
				CeaseAudioSource(_transitioningAudio);
			}
		}

		public void StopLoopingCurrentSong()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (_currentPlaylist == null)
			{
				MasterAudio.LogNoPlaylist(ControllerName, "StopLoopingCurrentSong");
				return;
			}
			if (!_activeAudio.isPlaying)
			{
				UnityEngine.Debug.Log("No song is currently playing.");
				return;
			}
			_activeAudio.loop = false;
			if (CanSchedule && _queuedSongs.Count == 0)
			{
				ScheduleNextSong();
			}
		}

		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (_currentPlaylist == null)
			{
				MasterAudio.LogNoPlaylist(ControllerName, "QueuePlaylistClip");
				return;
			}
			if (!_activeAudio.isPlaying)
			{
				TriggerPlaylistClip(clipName);
				return;
			}
			MusicSetting musicSetting = _currentPlaylist.MusicSettings.Find((MusicSetting obj) => (obj.audLocation == MasterAudio.AudioLocation.Clip) ? (obj.clip != null && obj.clip.name == clipName) : (obj.resourceFileName == clipName));
			if (musicSetting == null)
			{
				UnityEngine.Debug.LogWarning("Could not find clip '" + clipName + "' in current Playlist in '" + ControllerName + "'.");
			}
			else
			{
				_activeAudio.loop = false;
				_queuedSongs.Add(musicSetting);
				if (CanSchedule && scheduleNow)
				{
					PlayNextOrRandom(AudioPlayType.Schedule);
				}
			}
		}

		public bool TriggerPlaylistClip(string clipName)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return false;
			}
			if (_currentPlaylist == null)
			{
				MasterAudio.LogNoPlaylist(ControllerName, "TriggerPlaylistClip");
				return false;
			}
			MusicSetting musicSetting = _currentPlaylist.MusicSettings.Find((MusicSetting obj) => obj.alias == clipName);
			if (musicSetting == null)
			{
				musicSetting = _currentPlaylist.MusicSettings.Find((MusicSetting obj) => (obj.audLocation == MasterAudio.AudioLocation.Clip) ? (obj.clip != null && obj.clip.name == clipName) : (obj.resourceFileName == clipName || obj.songName == clipName));
			}
			if (musicSetting == null)
			{
				UnityEngine.Debug.LogWarning("Could not find clip '" + clipName + "' in current Playlist in '" + ControllerName + "'.");
				return false;
			}
			_currentSequentialClipIndex = musicSetting.songIndex;
			PlaySong(musicSetting, AudioPlayType.PlayNow);
			return true;
		}

		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
			if (MasterAudio.IsWarming)
			{
				return;
			}
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (!IsCrossFading)
			{
				float num = AudioUtil.AdjustAudioClipDurationForPitch(duckLength, pitch);
				_currentDuckVolCut = duckedVolCut;
				float dbFromFloatVolume = AudioUtil.GetDbFromFloatVolume(_originalMusicVolume);
				float db = dbFromFloatVolume + duckedVolCut;
				float num2 = (_initialDuckVolume = AudioUtil.GetFloatVolumeFromDb(db));
				_duckRange = _originalMusicVolume - num2;
				_duckingMode = AudioDuckingMode.SetToDuck;
				_timeToStartUnducking = AudioUtil.Time + num * duckedTimePercentage;
				float num3 = _timeToStartUnducking + unduckTime;
				if (num3 > AudioUtil.Time + num)
				{
					num3 = AudioUtil.Time + num;
				}
				_timeToFinishUnducking = num3;
			}
		}

		private void InitControllerIfNot()
		{
			if (!ControllerIsReady)
			{
				Awake();
				Start();
			}
		}

		public void UpdateMasterVolume()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			InitControllerIfNot();
			if (_currentSong != null)
			{
				float num = _currentSong.volume * PlaylistVolume;
				if (!IsCrossFading)
				{
					if (_activeAudio != null)
					{
						_activeAudio.volume = num;
					}
					if (_transitioningAudio != null)
					{
						_transitioningAudio.volume = num;
					}
				}
				_activeAudioEndVolume = num;
			}
			SetDuckProperties();
		}

		public void StartPlaylist(string playlistName)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (_currentPlaylist != null && _currentPlaylist.playlistName == playlistName)
			{
				RestartPlaylist();
			}
			else
			{
				ChangePlaylist(playlistName);
			}
		}

		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
			InitControllerIfNot();
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (_currentPlaylist != null && _currentPlaylist.playlistName == playlistName)
			{
				UnityEngine.Debug.LogWarning("The Playlist '" + playlistName + "' is already loaded. Ignoring Change Playlist request.");
				return;
			}
			startPlaylistName = playlistName;
			FinishPlaylistInit(playFirstClip);
		}

		private void FinishPlaylistInit(bool playFirstClip = true)
		{
			if (IsCrossFading)
			{
				StopPlaylist(onlyFadingClip: true);
			}
			InitializePlaylist();
			if (Application.isPlaying)
			{
				_queuedSongs.Clear();
				if (playFirstClip)
				{
					PlayNextOrRandom(AudioPlayType.PlayNow);
				}
			}
		}

		public void RestartPlaylist()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				FinishPlaylistInit();
			}
		}

		private void CheckIfPlaylistStarted()
		{
			if (_songsPlayedFromPlaylist <= 0 && playlistStartedEventExpanded && playlistStartedCustomEvent != string.Empty && playlistStartedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(playlistStartedCustomEvent, Trans);
			}
		}

		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			if (syncGroupNum <= 0 || _currentPlaylist.songTransitionType != MasterAudio.SongFadeInPosition.SynchronizeClips)
			{
				return null;
			}
			return Instances.Find((PlaylistController obj) => obj != this && obj.syncGroupNum == syncGroupNum && obj.ActiveAudioSource != null && obj.ActiveAudioSource.isPlaying);
		}

		private void FadeOutPlaylist()
		{
			if (_curFadeMode != FadeMode.GradualFade)
			{
				float volumeBeforeFade = _playlistVolume;
				FadeToVolume(0f, CrossFadeTime, delegate
				{
					StopPlaylist();
					_playlistVolume = volumeBeforeFade;
				});
			}
		}

		private void InitializePlaylist()
		{
			FillClips();
			_songsPlayedFromPlaylist = 0;
			_currentSequentialClipIndex = 0;
			_nextSongScheduled = false;
			_lastRandomClipIndex = -1;
		}

		private void PlayNextOrRandom(AudioPlayType playType)
		{
			_nextSongRequested = true;
			if (_queuedSongs.Count > 0)
			{
				PlayFirstQueuedSong(playType);
			}
			else if (!isShuffle)
			{
				PlayTheNextSong(playType);
			}
			else
			{
				PlayARandomSong(playType);
			}
		}

		private void FirePlaylistEndedEventIfAny()
		{
			if (playlistEndedEventExpanded && playlistEndedCustomEvent != string.Empty && playlistStartedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(playlistEndedCustomEvent, Trans);
			}
		}

		private void FillClips()
		{
			_clipsRemaining.Clear();
			if (startPlaylistName == "[No Playlist]")
			{
				return;
			}
			_currentPlaylist = MasterAudio.GrabPlaylist(startPlaylistName);
			if (_currentPlaylist == null)
			{
				return;
			}
			for (int i = 0; i < _currentPlaylist.MusicSettings.Count; i++)
			{
				MusicSetting musicSetting = _currentPlaylist.MusicSettings[i];
				musicSetting.songIndex = i;
				if (musicSetting.audLocation != MasterAudio.AudioLocation.ResourceFile)
				{
					if (musicSetting.clip == null)
					{
						continue;
					}
				}
				else if (string.IsNullOrEmpty(musicSetting.resourceFileName))
				{
					continue;
				}
				_clipsRemaining.Add(i);
			}
		}

		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
			_newSongSetting = setting;
			if (_activeAudio == null)
			{
				UnityEngine.Debug.LogError("PlaylistController prefab is not in your scene. Cannot play a song.");
				return;
			}
			AudioClip audioClip = null;
			bool flag = playType == AudioPlayType.PlayNow || playType == AudioPlayType.AlreadyScheduled;
			if (flag)
			{
				_lastFrameSongPosition = -1;
			}
			if (flag && _currentSong != null && !CanSchedule && _currentSong.songChangedEventExpanded && _currentSong.songChangedCustomEvent != string.Empty && _currentSong.songChangedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(_currentSong.songChangedCustomEvent, Trans);
			}
			if (playType != AudioPlayType.AlreadyScheduled)
			{
				if (_activeAudio.clip != null)
				{
					string value = string.Empty;
					switch (setting.audLocation)
					{
					case MasterAudio.AudioLocation.Clip:
						if (setting.clip != null)
						{
							value = setting.clip.name;
						}
						break;
					case MasterAudio.AudioLocation.ResourceFile:
						value = setting.resourceFileName;
						break;
					}
					if (string.IsNullOrEmpty(value))
					{
						UnityEngine.Debug.LogWarning("The next song has no clip or Resource file assigned. Please fix. Ignoring song change request.");
						return;
					}
				}
				if (_activeAudio.clip == null)
				{
					_audioClip = _activeAudio;
					_transClip = _transitioningAudio;
				}
				else if (_transitioningAudio.clip == null)
				{
					_audioClip = _transitioningAudio;
					_transClip = _activeAudio;
				}
				else
				{
					_audioClip = _transitioningAudio;
					_transClip = _activeAudio;
				}
				_audioClip.loop = SongShouldLoop(setting);
				switch (setting.audLocation)
				{
				case MasterAudio.AudioLocation.Clip:
					if (setting.clip == null)
					{
						MasterAudio.LogWarning("MasterAudio will not play empty Playlist clip for PlaylistController '" + ControllerName + "'.");
						return;
					}
					audioClip = setting.clip;
					break;
				case MasterAudio.AudioLocation.ResourceFile:
					if (MasterAudio.HasAsyncResourceLoaderFeature() && ShouldLoadAsync)
					{
						StartCoroutine(AudioResourceOptimizer.PopulateResourceSongToPlaylistControllerAsync(setting.resourceFileName, CurrentPlaylist.playlistName, this, playType));
						break;
					}
					audioClip = AudioResourceOptimizer.PopulateResourceSongToPlaylistController(ControllerName, setting.resourceFileName, CurrentPlaylist.playlistName);
					if (audioClip == null)
					{
						return;
					}
					break;
				}
			}
			else
			{
				FinishLoadingNewSong(null, AudioPlayType.AlreadyScheduled);
			}
			if (audioClip != null)
			{
				FinishLoadingNewSong(audioClip, playType);
			}
		}

		public double? ScheduledGaplessNextSongStartTime()
		{
			if (!_scheduledSongOffsetByAudioSource.ContainsKey(_audioClip))
			{
				return null;
			}
			return _scheduledSongOffsetByAudioSource[_audioClip];
		}

		public void FinishLoadingNewSong(AudioClip clipToPlay, AudioPlayType playType)
		{
			_nextSongRequested = false;
			bool flag = playType == AudioPlayType.Schedule;
			bool flag2 = playType == AudioPlayType.PlayNow || flag;
			bool flag3 = playType == AudioPlayType.PlayNow || playType == AudioPlayType.AlreadyScheduled;
			if (flag2)
			{
				_audioClip.clip = clipToPlay;
				_audioClip.pitch = _newSongSetting.pitch;
			}
			if (_currentSong != null)
			{
				_currentSong.lastKnownTimePoint = _activeAudio.timeSamples;
				_currentSong.wasLastKnownTimePointSet = true;
			}
			if (flag3)
			{
				if (CrossFadeTime == 0f || _transClip.clip == null)
				{
					CeaseAudioSource(_transClip);
					_audioClip.volume = _newSongSetting.volume * PlaylistVolume;
					if (!ActiveAudioSource.isPlaying && _currentPlaylist != null && _currentPlaylist.fadeInFirstSong && CrossFadeTime > 0f)
					{
						CrossFadeNow(_audioClip);
					}
				}
				else
				{
					CrossFadeNow(_audioClip);
				}
				SetDuckProperties();
			}
			switch (playType)
			{
			case AudioPlayType.AlreadyScheduled:
				_nextSongScheduled = false;
				RemoveScheduledClip();
				break;
			case AudioPlayType.PlayNow:
				if (_audioClip.clip != null && _audioClip.timeSamples >= _audioClip.clip.samples - 1)
				{
					_audioClip.timeSamples = 0;
				}
				_audioClip.Play();
				framesOfSongPlayed = 0;
				AudioUtil.ClipPlayed(_activeAudio.clip, GameObj);
				CheckIfPlaylistStarted();
				_songsPlayedFromPlaylist++;
				break;
			case AudioPlayType.Schedule:
			{
				double scheduledPlayTimeOffset = CalculateNextTrackStartTimeOffset();
				ScheduleClipPlay(scheduledPlayTimeOffset, _audioClip, calledAfterPause: false);
				_nextSongScheduled = true;
				CheckIfPlaylistStarted();
				_songsPlayedFromPlaylist++;
				break;
			}
			}
			bool flag4 = false;
			if (playType == AudioPlayType.PlayNow)
			{
				PlaylistController playlistController = FindOtherControllerInSameSyncGroup();
				if (playlistController != null)
				{
					int timeSamples = playlistController._activeAudio.timeSamples;
					float time = playlistController._audioClip.time;
					bool flag5 = Math.Abs(_audioClip.clip.length - time) >= AudioUtil.FrameTime * 10f;
					if (_audioClip.clip != null && timeSamples < _audioClip.clip.samples && flag5)
					{
						_audioClip.timeSamples = timeSamples;
						flag4 = true;
					}
				}
			}
			if (_currentPlaylist != null)
			{
				if (_songsPlayedFromPlaylist <= 1 && !flag4)
				{
					_audioClip.timeSamples = 0;
				}
				else
				{
					switch (_currentPlaylist.songTransitionType)
					{
					case MasterAudio.SongFadeInPosition.SynchronizeClips:
						if (flag4)
						{
							break;
						}
						if (playType == AudioPlayType.PlayNow)
						{
							int num = ((!_lastSongPosition.HasValue) ? _activeAudio.timeSamples : _lastSongPosition.Value);
							if (_transitioningAudio.clip != null && num >= _transitioningAudio.clip.samples - 1)
							{
								num = 0;
							}
							_lastSongPosition = null;
							_transitioningAudio.timeSamples = num;
						}
						else if (!ShouldNotSwitchEarly)
						{
							_transitioningAudio.timeSamples = 0;
						}
						break;
					case MasterAudio.SongFadeInPosition.NewClipFromLastKnownPosition:
					{
						MusicSetting musicSetting = _currentPlaylist.MusicSettings.Find((MusicSetting obj) => obj == _newSongSetting);
						if (musicSetting != null)
						{
							int num2 = musicSetting.lastKnownTimePoint;
							if (_transitioningAudio.clip != null && num2 >= _transitioningAudio.clip.samples - 1)
							{
								num2 = 0;
							}
							_transitioningAudio.timeSamples = num2;
						}
						break;
					}
					case MasterAudio.SongFadeInPosition.NewClipFromBeginning:
						if (!ShouldNotSwitchEarly)
						{
							_audioClip.timeSamples = 0;
						}
						break;
					}
				}
				bool flag6 = _currentPlaylist.songTransitionType == MasterAudio.SongFadeInPosition.NewClipFromLastKnownPosition && !_newSongSetting.wasLastKnownTimePointSet;
				if (_currentPlaylist.songTransitionType == MasterAudio.SongFadeInPosition.NewClipFromBeginning || flag6)
				{
					float songStartTime = _newSongSetting.SongStartTime;
					if (songStartTime > 0f)
					{
						_audioClip.timeSamples = (int)(songStartTime * (float)_audioClip.clip.frequency);
					}
				}
			}
			if (flag)
			{
				UpdateMasterVolume();
			}
			if (flag3)
			{
				_activeAudio = _audioClip;
				_transitioningAudio = _transClip;
				if (songChangedCustomEvent != string.Empty && songChangedEventExpanded && songChangedCustomEvent != "[None]")
				{
					MasterAudio.FireCustomEvent(songChangedCustomEvent, Trans);
				}
				if (this.SongChanged != null)
				{
					string empty = string.Empty;
					if (_audioClip != null)
					{
						empty = _audioClip.clip.name;
					}
					this.SongChanged(empty);
				}
			}
			_activeAudioEndVolume = _newSongSetting.volume * PlaylistVolume;
			float volume = _transitioningAudio.volume;
			if (_currentSong != null)
			{
				volume = _currentSong.volume;
			}
			_transitioningAudioStartVolume = volume * PlaylistVolume;
			_currentSong = _newSongSetting;
			if (flag3 && _currentSong.songStartedEventExpanded && _currentSong.songStartedCustomEvent != string.Empty && _currentSong.songStartedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(_currentSong.songStartedCustomEvent, Trans);
			}
			if (CanSchedule && playType != AudioPlayType.Schedule && !_currentSong.isLoop)
			{
				ScheduleNextSong();
			}
		}

		private void RemoveScheduledClip()
		{
			if (_audioClip != null)
			{
				_scheduledSongOffsetByAudioSource.Remove(_audioClip);
			}
		}

		private void ScheduleNextSong()
		{
			PlayNextOrRandom(AudioPlayType.Schedule);
		}

		private void FadeInScheduledSong()
		{
			PlayNextOrRandom(AudioPlayType.AlreadyScheduled);
		}

		private double CalculateNextTrackStartTimeOffset()
		{
			PlaylistController playlistController = FindOtherControllerInSameSyncGroup();
			if (playlistController != null)
			{
				double? num = playlistController.ScheduledGaplessNextSongStartTime();
				if (num.HasValue)
				{
					return num.Value;
				}
			}
			return GetClipDuration(_activeAudio);
		}

		private double GetClipDuration(AudioSource src)
		{
			return AudioUtil.AdjustAudioClipDurationForPitch(src.clip.length - src.time, src) - CrossFadeTime;
		}

		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
			double num = AudioSettings.dspTime + scheduledPlayTimeOffset;
			if (ShouldNotSwitchEarly && _currentSchedSongDspEndTime.HasValue && !calledAfterPause)
			{
				num = _currentSchedSongDspEndTime.Value;
				scheduledPlayTimeOffset = num - AudioSettings.dspTime;
			}
			source.PlayScheduled(num);
			_currentSchedSongDspStartTime = num;
			_currentSchedSongDspEndTime = num + GetClipDuration(source);
			RemoveScheduledClip();
			_scheduledSongOffsetByAudioSource.Add(source, scheduledPlayTimeOffset);
		}

		private void CrossFadeNow(AudioSource audioClip)
		{
			audioClip.volume = 0f;
			IsCrossFading = true;
			_duckingMode = AudioDuckingMode.NotDucking;
			_crossFadeStartTime = AudioUtil.Time;
			if (crossfadeStartedExpanded && crossfadeStartedCustomEvent != string.Empty && crossfadeStartedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(crossfadeStartedCustomEvent, Trans, logDupe: false);
			}
		}

		private void CeaseAudioSource(AudioSource source)
		{
			if (source == null)
			{
				return;
			}
			if (source == _activeAudio)
			{
				framesOfSongPlayed = 0;
			}
			bool flag = source.clip != null;
			string text = ((!(source.clip == null)) ? source.clip.name : string.Empty);
			source.Stop();
			AudioUtil.UnloadNonPreloadedAudioData(source.clip, GameObj);
			AudioResourceOptimizer.UnloadPlaylistSongIfUnused(ControllerName, source.clip);
			source.clip = null;
			RemoveScheduledClip();
			if (flag)
			{
				if (!string.IsNullOrEmpty(text) && songEndedEventExpanded && songEndedCustomEvent != string.Empty && songEndedCustomEvent != "[None]")
				{
					MasterAudio.FireCustomEvent(songEndedCustomEvent, Trans, logDupe: false);
				}
				if (this.SongEnded != null && !string.IsNullOrEmpty(text))
				{
					this.SongEnded(text);
				}
			}
		}

		private void SetDuckProperties()
		{
			_originalMusicVolume = ((!(_activeAudio == null)) ? _activeAudio.volume : 1f);
			if (_currentSong != null)
			{
				_originalMusicVolume = _currentSong.volume * PlaylistVolume;
			}
			float dbFromFloatVolume = AudioUtil.GetDbFromFloatVolume(_originalMusicVolume);
			float db = dbFromFloatVolume - _currentDuckVolCut;
			float floatVolumeFromDb = AudioUtil.GetFloatVolumeFromDb(db);
			_duckRange = _originalMusicVolume - floatVolumeFromDb;
			_initialDuckVolume = floatVolumeFromDb;
			_duckingMode = AudioDuckingMode.NotDucking;
		}

		private void AudioDucking()
		{
			switch (_duckingMode)
			{
			case AudioDuckingMode.SetToDuck:
				_activeAudio.volume = _initialDuckVolume;
				_duckingMode = AudioDuckingMode.Ducked;
				break;
			case AudioDuckingMode.Ducked:
				if (Time.realtimeSinceStartup >= _timeToFinishUnducking)
				{
					_activeAudio.volume = _originalMusicVolume;
					_duckingMode = AudioDuckingMode.NotDucking;
				}
				else if (Time.realtimeSinceStartup >= _timeToStartUnducking)
				{
					_activeAudio.volume = _initialDuckVolume + (Time.realtimeSinceStartup - _timeToStartUnducking) / (_timeToFinishUnducking - _timeToStartUnducking) * _duckRange;
				}
				break;
			}
		}

		private bool SongShouldLoop(MusicSetting setting)
		{
			if (_queuedSongs.Count > 0)
			{
				return false;
			}
			if (SongIsNonAdvancible)
			{
				return true;
			}
			return setting.isLoop;
		}

		public void RouteToMixerChannel(AudioMixerGroup group)
		{
			_activeAudio.outputAudioMixerGroup = group;
			_transitioningAudio.outputAudioMixerGroup = group;
		}
	}
}
public static class ResonanceAudioHelper
{
	public static bool ResonanceAudioOptionExists => true;

	public static bool AddResonanceAudioSourceToAllVariations()
	{
		return false;
	}

	public static bool RemoveResonanceAudioSourceFromAllVariations()
	{
		return false;
	}

	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
namespace DarkTonic.MasterAudio
{
	public static class SpatializerHelper
	{
		private const string OculusSpatializer = "OculusSpatializer";

		private const string ResonanceAudioSpatializer = "Resonance Audio";

		public static bool IsSupportedSpatializer => SelectedSpatializer switch
		{
			"OculusSpatializer" => true, 
			"Resonance Audio" => true, 
			_ => false, 
		};

		public static bool IsResonanceAudioSpatializer => SelectedSpatializer == "Resonance Audio";

		public static string SelectedSpatializer => AudioSettings.GetSpatializerPluginName();

		public static bool SpatializerOptionExists => true;

		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
			if (SpatializerOptionExists && !(MasterAudio.SafeInstance == null) && MasterAudio.Instance.useSpatializer)
			{
				source.spatialize = true;
				if (ResonanceAudioHelper.ResonanceAudioOptionExists && MasterAudio.Instance.useSpatializerPostFX)
				{
					source.spatializePostEffects = true;
				}
			}
		}
	}
}
public class TransformFollower : MonoBehaviour
{
	[Tooltip("This is for diagnostic purposes only. Do not change or assign this field.")]
	public Transform RuntimeFollowingTransform;

	private GameObject _goToFollow;

	private Transform _trans;

	private GameObject _go;

	private SphereCollider _collider;

	private string _soundType;

	private bool _willFollowSource;

	private bool _isInsideTrigger;

	private bool _hasPlayedSound;

	private bool _groupLoadFailed;

	private MasterAudioGroup _groupToPlay;

	private bool _positionAtClosestColliderPoint;

	private readonly List<Collider> _actorColliders = new List<Collider>();

	private readonly List<Collider2D> _actorColliders2D = new List<Collider2D>();

	private Vector3 _lastListenerPos = new Vector3(float.MinValue, float.MinValue, float.MinValue);

	private readonly Dictionary<Collider, Vector3> _lastPositionByCollider = new Dictionary<Collider, Vector3>();

	private readonly Dictionary<Collider2D, Vector3> _lastPositionByCollider2D = new Dictionary<Collider2D, Vector3>();

	private PlaySoundResult playingVariation;

	public SphereCollider Trigger
	{
		get
		{
			if (_collider != null)
			{
				return _collider;
			}
			_collider = GameObj.AddComponent<SphereCollider>();
			_collider.isTrigger = true;
			return _collider;
		}
	}

	public GameObject GameObj
	{
		get
		{
			if (_go != null)
			{
				return _go;
			}
			_go = base.gameObject;
			return _go;
		}
	}

	public Transform Trans
	{
		get
		{
			if (_trans == null)
			{
				_trans = base.transform;
			}
			return _trans;
		}
	}

	private void Awake()
	{
		SphereCollider trigger = Trigger;
		if (!(trigger == null) && _actorColliders.Count != 0 && _actorColliders2D.Count != 0 && !_positionAtClosestColliderPoint && !(_lastListenerPos == Vector3.zero) && playingVariation == null)
		{
		}
	}

	private void Start()
	{
		_groupToPlay = MasterAudio.GrabGroup(_soundType, logIfMissing: false);
	}

	public void StartFollowing(Transform transToFollow, string soundType, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders)
	{
		RuntimeFollowingTransform = transToFollow;
		_goToFollow = transToFollow.gameObject;
		Trigger.radius = trigRadius;
		_soundType = soundType;
		_willFollowSource = willFollowSource;
		_lastPositionByCollider.Clear();
		_lastPositionByCollider2D.Clear();
		if (useTopCollider)
		{
			Collider component = transToFollow.GetComponent<Collider>();
			if (component != null)
			{
				_actorColliders.Add(component);
				_lastPositionByCollider.Add(component, transToFollow.position);
			}
			else
			{
				Collider2D component2 = transToFollow.GetComponent<Collider2D>();
				if (component2 != null)
				{
					_actorColliders2D.Add(component2);
					_lastPositionByCollider2D.Add(component2, transToFollow.position);
				}
			}
		}
		if (useChildColliders && transToFollow != null)
		{
			for (int i = 0; i < transToFollow.childCount; i++)
			{
				Transform child = transToFollow.GetChild(i);
				Collider component3 = child.GetComponent<Collider>();
				if (component3 != null)
				{
					_actorColliders.Add(component3);
					_lastPositionByCollider.Add(component3, transToFollow.position);
					continue;
				}
				Collider2D component4 = child.GetComponent<Collider2D>();
				if (component4 != null)
				{
					_actorColliders2D.Add(component4);
					_lastPositionByCollider2D.Add(component4, transToFollow.position);
				}
			}
		}
		_lastListenerPos = MasterAudio.ListenerTrans.position;
		if (_actorColliders.Count == 0 && _actorColliders2D.Count == 0 && positionAtClosestColliderPoint)
		{
			UnityEngine.Debug.Log("Can't follow collider of '" + transToFollow.name + "' because it doesn't have any colliders.");
			return;
		}
		_positionAtClosestColliderPoint = positionAtClosestColliderPoint;
		if (_positionAtClosestColliderPoint)
		{
			MasterAudio.QueueTransformFollowerForColliderPositionRecalc(this);
		}
	}

	private void StopFollowing()
	{
		RuntimeFollowingTransform = null;
		UnityEngine.Object.Destroy(GameObj);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (RuntimeFollowingTransform == null || other == null || base.name == "~ListenerFollower~" || other.name != "~ListenerFollower~")
		{
			return;
		}
		_isInsideTrigger = true;
		if (_groupToPlay != null)
		{
			switch (_groupToPlay.GroupLoadStatus)
			{
			case MasterAudio.InternetFileLoadStatus.Failed:
				if (MasterAudio.LogSoundsEnabled)
				{
					MasterAudio.LogWarning("TransformFollower: '" + base.name + "' not attempting to play Sound Group '" + _soundType + "' because the Sound Group failed to load.");
				}
				_groupLoadFailed = true;
				return;
			case MasterAudio.InternetFileLoadStatus.Loading:
				return;
			}
		}
		PlaySound();
	}

	private void PlaySound()
	{
		if (_willFollowSource)
		{
			if (_positionAtClosestColliderPoint)
			{
				playingVariation = MasterAudio.PlaySound3DFollowTransform(_soundType, RuntimeFollowingTransform);
			}
			else
			{
				MasterAudio.PlaySound3DFollowTransformAndForget(_soundType, RuntimeFollowingTransform);
			}
		}
		else if (_positionAtClosestColliderPoint)
		{
			playingVariation = MasterAudio.PlaySound3DAtTransform(_soundType, RuntimeFollowingTransform);
		}
		else
		{
			MasterAudio.PlaySound3DAtTransformAndForget(_soundType, RuntimeFollowingTransform);
		}
		_hasPlayedSound = true;
	}

	private void LateUpdate()
	{
		if (RuntimeFollowingTransform == null || !DTMonoHelper.IsActive(_goToFollow))
		{
			StopFollowing();
			return;
		}
		if (!_positionAtClosestColliderPoint)
		{
			Trans.position = RuntimeFollowingTransform.position;
		}
		if (!_isInsideTrigger || _hasPlayedSound || _groupLoadFailed)
		{
			return;
		}
		switch (_groupToPlay.GroupLoadStatus)
		{
		case MasterAudio.InternetFileLoadStatus.Loaded:
			PlaySound();
			break;
		case MasterAudio.InternetFileLoadStatus.Failed:
			if (MasterAudio.LogSoundsEnabled)
			{
				MasterAudio.LogWarning("TransformFollower: '" + base.name + "' not attempting to play Sound Group '" + _soundType + "' because the Sound Group failed to load.");
			}
			_groupLoadFailed = true;
			break;
		}
	}

	public bool RecalcClosestColliderPosition()
	{
		Vector3 position = MasterAudio.ListenerTrans.position;
		bool flag = _lastListenerPos != position;
		Vector3 position2 = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
		float num = float.MaxValue;
		bool flag2 = false;
		if (_actorColliders.Count > 0)
		{
			if (_actorColliders.Count == 1)
			{
				Collider collider = _actorColliders[0];
				Vector3 position3 = collider.transform.position;
				if (_lastPositionByCollider[collider] == position3 && !flag)
				{
					return false;
				}
				flag2 = true;
				position2 = collider.ClosestPoint(position);
				_lastPositionByCollider[collider] = position3;
			}
			else
			{
				for (int i = 0; i < _actorColliders.Count; i++)
				{
					Collider collider2 = _actorColliders[i];
					Vector3 position4 = collider2.transform.position;
					if (!(_lastPositionByCollider[collider2] == position4) || flag)
					{
						flag2 = true;
						Vector3 vector = collider2.ClosestPoint(position);
						float sqrMagnitude = (position - vector).sqrMagnitude;
						if (sqrMagnitude < num)
						{
							position2 = vector;
							num = sqrMagnitude;
						}
						_lastPositionByCollider[collider2] = position4;
					}
				}
			}
		}
		else
		{
			if (_actorColliders2D.Count <= 0)
			{
				return false;
			}
			if (_actorColliders2D.Count == 1)
			{
				Collider2D collider2D = _actorColliders2D[0];
				Vector3 position5 = collider2D.transform.position;
				if (_lastPositionByCollider2D[collider2D] == position5 && !flag)
				{
					return false;
				}
				flag2 = true;
				position2 = collider2D.bounds.ClosestPoint(position);
				_lastPositionByCollider2D[collider2D] = position5;
			}
			else
			{
				for (int j = 0; j < _actorColliders2D.Count; j++)
				{
					Collider2D collider2D2 = _actorColliders2D[j];
					Vector3 position6 = collider2D2.transform.position;
					if (!(_lastPositionByCollider2D[collider2D2] == position6) || flag)
					{
						flag2 = true;
						Vector3 vector2 = collider2D2.bounds.ClosestPoint(position);
						float sqrMagnitude2 = (position - vector2).sqrMagnitude;
						if (sqrMagnitude2 < num)
						{
							position2 = vector2;
							num = sqrMagnitude2;
						}
						_lastPositionByCollider2D[collider2D2] = position6;
					}
				}
			}
		}
		if (!flag2)
		{
			return false;
		}
		Trans.position = position2;
		Trans.LookAt(MasterAudio.ListenerTrans);
		if (playingVariation != null && playingVariation.ActingVariation != null)
		{
			playingVariation.ActingVariation.transform.position = position2;
		}
		_lastListenerPos = position;
		return true;
	}

	private void OnTriggerExit(Collider other)
	{
		if (!(RuntimeFollowingTransform == null) && !(other == null) && !(other.name != "~ListenerFollower~"))
		{
			_isInsideTrigger = false;
			_hasPlayedSound = false;
			MasterAudio.StopSoundGroupOfTransform(RuntimeFollowingTransform, _soundType);
			playingVariation = null;
		}
	}
}
namespace DarkTonic.MasterAudio
{
	public static class UtilStrings
	{
		public static string TrimSpace(string untrimmed)
		{
			if (string.IsNullOrEmpty(untrimmed))
			{
				return string.Empty;
			}
			return untrimmed.Trim();
		}

		public static string ReplaceUnsafeChars(string source)
		{
			source = source.Replace("'", "&apos;");
			source = source.Replace("\"", "&quot;");
			source = source.Replace("&", "&amp;");
			return source;
		}
	}
}
public class EnumFlagAttribute : PropertyAttribute
{
	public string enumName;

	public EnumFlagAttribute()
	{
	}

	public EnumFlagAttribute(string name)
	{
		enumName = name;
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[AttributeUsage(AttributeTargets.Class)]
	public class AutoBackendAttribute : Attribute
	{
	}
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatedAttribute : Attribute
	{
	}
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatingAttribute : Attribute
	{
	}
}
namespace UnityStandardAssets.Water
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class Displace : MonoBehaviour
	{
		public void Awake()
		{
			if (base.enabled)
			{
				OnEnable();
			}
			else
			{
				OnDisable();
			}
		}

		public void OnEnable()
		{
			Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
			Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
		}

		public void OnDisable()
		{
			Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
			Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class GerstnerDisplace : Displace
	{
	}
	public class MeshContainer
	{
		public Mesh mesh;

		public Vector3[] vertices;

		public Vector3[] normals;

		public MeshContainer(Mesh m)
		{
			mesh = m;
			vertices = m.vertices;
			normals = m.normals;
		}

		public void Update()
		{
			mesh.vertices = vertices;
			mesh.normals = normals;
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		public LayerMask reflectionMask;

		public bool reflectSkybox;

		public Color clearColor = Color.grey;

		public string reflectionSampler = "_ReflectionTex";

		public float clipPlaneOffset = 0.07f;

		private Vector3 m_Oldpos;

		private Camera m_ReflectionCamera;

		private Material m_SharedMaterial;

		private Dictionary<Camera, bool> m_HelperCameras;

		public void Start()
		{
			m_SharedMaterial = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		private Camera CreateReflectionCameraFor(Camera cam)
		{
			string text = base.gameObject.name + "Reflection" + cam.name;
			GameObject gameObject = GameObject.Find(text);
			if (!gameObject)
			{
				gameObject = new GameObject(text, typeof(Camera));
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = clearColor;
			component.clearFlags = (reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
			SetStandardCameraParameter(component, reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = CreateTextureFor(cam);
			}
			return component;
		}

		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
			cam.cullingMask = (int)mask & ~(1 << LayerMask.NameToLayer("Water"));
			cam.backgroundColor = Color.black;
			cam.enabled = false;
		}

		private RenderTexture CreateTextureFor(Camera cam)
		{
			RenderTexture renderTexture = new RenderTexture(Mathf.FloorToInt((float)cam.pixelWidth * 0.5f), Mathf.FloorToInt((float)cam.pixelHeight * 0.5f), 24);
			renderTexture.hideFlags = HideFlags.DontSave;
			return renderTexture;
		}

		public void RenderHelpCameras(Camera currentCam)
		{
			if (m_HelperCameras == null)
			{
				m_HelperCameras = new Dictionary<Camera, bool>();
			}
			if (!m_HelperCameras.ContainsKey(currentCam))
			{
				m_HelperCameras.Add(currentCam, value: false);
			}
			if (!m_HelperCameras[currentCam])
			{
				if (!m_ReflectionCamera)
				{
					m_ReflectionCamera = CreateReflectionCameraFor(currentCam);
				}
				RenderReflectionFor(currentCam, m_ReflectionCamera);
				m_HelperCameras[currentCam] = true;
			}
		}

		public void LateUpdate()
		{
			if (m_HelperCameras != null)
			{
				m_HelperCameras.Clear();
			}
		}

		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
			RenderHelpCameras(currentCam);
			if ((bool)m_ReflectionCamera && (bool)m_SharedMaterial)
			{
				m_SharedMaterial.SetTexture(reflectionSampler, m_ReflectionCamera.targetTexture);
			}
		}

		public void OnEnable()
		{
			Shader.EnableKeyword("WATER_REFLECTIVE");
			Shader.DisableKeyword("WATER_SIMPLE");
		}

		public void OnDisable()
		{
			Shader.EnableKeyword("WATER_SIMPLE");
			Shader.DisableKeyword("WATER_REFLECTIVE");
		}

		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
			if (!reflectCamera || ((bool)m_SharedMaterial && !m_SharedMaterial.HasProperty(reflectionSampler)))
			{
				return;
			}
			reflectCamera.cullingMask = (int)reflectionMask & ~(1 << LayerMask.NameToLayer("Water"));
			SaneCameraSettings(reflectCamera);
			reflectCamera.backgroundColor = clearColor;
			reflectCamera.clearFlags = (reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
			if (reflectSkybox && (bool)cam.gameObject.GetComponent(typeof(Skybox)))
			{
				Skybox skybox = (Skybox)reflectCamera.gameObject.GetComponent(typeof(Skybox));
				if (!skybox)
				{
					skybox = (Skybox)reflectCamera.gameObject.AddComponent(typeof(Skybox));
				}
				skybox.material = ((Skybox)cam.GetComponent(typeof(Skybox))).material;
			}
			GL.invertCulling = true;
			Transform transform = base.transform;
			Vector3 eulerAngles = cam.transform.eulerAngles;
			reflectCamera.transform.eulerAngles = new Vector3(0f - eulerAngles.x, eulerAngles.y, eulerAngles.z);
			reflectCamera.transform.position = cam.transform.position;
			Vector3 position = transform.transform.position;
			position.y = transform.position.y;
			Vector3 up = transform.transform.up;
			float w = 0f - Vector3.Dot(up, position) - clipPlaneOffset;
			Vector4 plane = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			zero = CalculateReflectionMatrix(zero, plane);
			m_Oldpos = cam.transform.position;
			Vector3 position2 = zero.MultiplyPoint(m_Oldpos);
			reflectCamera.worldToCameraMatrix = cam.worldToCameraMatrix * zero;
			Vector4 clipPlane = CameraSpacePlane(reflectCamera, position, up, 1f);
			Matrix4x4 projectionMatrix = cam.projectionMatrix;
			projectionMatrix = CalculateObliqueMatrix(projectionMatrix, clipPlane);
			reflectCamera.projectionMatrix = projectionMatrix;
			reflectCamera.transform.position = position2;
			Vector3 eulerAngles2 = cam.transform.eulerAngles;
			reflectCamera.transform.eulerAngles = new Vector3(0f - eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
			reflectCamera.Render();
			GL.invertCulling = false;
		}

		private void SaneCameraSettings(Camera helperCam)
		{
			helperCam.depthTextureMode = DepthTextureMode.None;
			helperCam.backgroundColor = Color.black;
			helperCam.clearFlags = CameraClearFlags.Color;
			helperCam.renderingPath = RenderingPath.Forward;
		}

		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			Vector4 b = projection.inverse * new Vector4(Sgn(clipPlane.x), Sgn(clipPlane.y), 1f, 1f);
			Vector4 vector = clipPlane * (2f / Vector4.Dot(clipPlane, b));
			projection[2] = vector.x - projection[3];
			projection[6] = vector.y - projection[7];
			projection[10] = vector.z - projection[11];
			projection[14] = vector.w - projection[15];
			return projection;
		}

		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			reflectionMat.m00 = 1f - 2f * plane[0] * plane[0];
			reflectionMat.m01 = -2f * plane[0] * plane[1];
			reflectionMat.m02 = -2f * plane[0] * plane[2];
			reflectionMat.m03 = -2f * plane[3] * plane[0];
			reflectionMat.m10 = -2f * plane[1] * plane[0];
			reflectionMat.m11 = 1f - 2f * plane[1] * plane[1];
			reflectionMat.m12 = -2f * plane[1] * plane[2];
			reflectionMat.m13 = -2f * plane[3] * plane[1];
			reflectionMat.m20 = -2f * plane[2] * plane[0];
			reflectionMat.m21 = -2f * plane[2] * plane[1];
			reflectionMat.m22 = 1f - 2f * plane[2] * plane[2];
			reflectionMat.m23 = -2f * plane[3] * plane[2];
			reflectionMat.m30 = 0f;
			reflectionMat.m31 = 0f;
			reflectionMat.m32 = 0f;
			reflectionMat.m33 = 1f;
			return reflectionMat;
		}

		private static float Sgn(float a)
		{
			if (a > 0f)
			{
				return 1f;
			}
			if (a < 0f)
			{
				return -1f;
			}
			return 0f;
		}

		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			Vector3 point = pos + normal * clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 rhs = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
			return new Vector4(rhs.x, rhs.y, rhs.z, 0f - Vector3.Dot(lhs, rhs));
		}
	}
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		public Transform specularLight;

		private WaterBase m_WaterBase;

		public void Start()
		{
			m_WaterBase = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		public void Update()
		{
			if (!m_WaterBase)
			{
				m_WaterBase = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if ((bool)specularLight && (bool)m_WaterBase.sharedMaterial)
			{
				m_WaterBase.sharedMaterial.SetVector("_WorldLightDir", specularLight.transform.forward);
			}
		}
	}
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		public enum WaterMode
		{
			Simple,
			Reflective,
			Refractive
		}

		public WaterMode waterMode = WaterMode.Refractive;

		public bool disablePixelLights = true;

		public int textureSize = 256;

		public float clipPlaneOffset = 0.07f;

		public LayerMask reflectLayers = -1;

		public LayerMask refractLayers = -1;

		private Dictionary<Camera, Camera> m_ReflectionCameras = new Dictionary<Camera, Camera>();

		private Dictionary<Camera, Camera> m_RefractionCameras = new Dictionary<Camera, Camera>();

		private RenderTexture m_ReflectionTexture;

		private RenderTexture m_RefractionTexture;

		private WaterMode m_HardwareWaterSupport = WaterMode.Refractive;

		private int m_OldReflectionTextureSize;

		private int m_OldRefractionTextureSize;

		private static bool s_InsideWater;

		public void OnWillRenderObject()
		{
			if (!base.enabled || !GetComponent<Renderer>() || !GetComponent<Renderer>().sharedMaterial || !GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if ((bool)current && !s_InsideWater)
			{
				s_InsideWater = true;
				m_HardwareWaterSupport = FindHardwareWaterSupport();
				WaterMode waterMode = GetWaterMode();
				CreateWaterObjects(current, out var reflectionCamera, out var refractionCamera);
				Vector3 position = base.transform.position;
				Vector3 up = base.transform.up;
				int pixelLightCount = QualitySettings.pixelLightCount;
				if (disablePixelLights)
				{
					QualitySettings.pixelLightCount = 0;
				}
				UpdateCameraModes(current, reflectionCamera);
				UpdateCameraModes(current, refractionCamera);
				if (waterMode >= WaterMode.Reflective)
				{
					float w = 0f - Vector3.Dot(up, position) - clipPlaneOffset;
					Vector4 plane = new Vector4(up.x, up.y, up.z, w);
					Matrix4x4 reflectionMat = Matrix4x4.zero;
					CalculateReflectionMatrix(ref reflectionMat, plane);
					Vector3 position2 = current.transform.position;
					Vector3 position3 = reflectionMat.MultiplyPoint(position2);
					reflectionCamera.worldToCameraMatrix = current.worldToCameraMatrix * reflectionMat;
					Vector4 clipPlane = CameraSpacePlane(reflectionCamera, position, up, 1f);
					reflectionCamera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
					reflectionCamera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
					reflectionCamera.cullingMask = -17 & reflectLayers.value;
					reflectionCamera.targetTexture = m_ReflectionTexture;
					bool invertCulling = GL.invertCulling;
					GL.invertCulling = !invertCulling;
					reflectionCamera.transform.position = position3;
					Vector3 eulerAngles = current.transform.eulerAngles;
					reflectionCamera.transform.eulerAngles = new Vector3(0f - eulerAngles.x, eulerAngles.y, eulerAngles.z);
					reflectionCamera.Render();
					reflectionCamera.transform.position = position2;
					GL.invertCulling = invertCulling;
					GetComponent<Renderer>().sharedMaterial.SetTexture("_ReflectionTex", m_ReflectionTexture);
				}
				if (waterMode >= WaterMode.Refractive)
				{
					refractionCamera.worldToCameraMatrix = current.worldToCameraMatrix;
					Vector4 clipPlane2 = CameraSpacePlane(refractionCamera, position, up, -1f);
					refractionCamera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
					refractionCamera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
					refractionCamera.cullingMask = -17 & refractLayers.value;
					refractionCamera.targetTexture = m_RefractionTexture;
					refractionCamera.transform.position = current.transform.position;
					refractionCamera.transform.rotation = current.transform.rotation;
					refractionCamera.Render();
					GetComponent<Renderer>().sharedMaterial.SetTexture("_RefractionTex", m_RefractionTexture);
				}
				if (disablePixelLights)
				{
					QualitySettings.pixelLightCount = pixelLightCount;
				}
				switch (waterMode)
				{
				case WaterMode.Simple:
					Shader.EnableKeyword("WATER_SIMPLE");
					Shader.DisableKeyword("WATER_REFLECTIVE");
					Shader.DisableKeyword("WATER_REFRACTIVE");
					break;
				case WaterMode.Reflective:
					Shader.DisableKeyword("WATER_SIMPLE");
					Shader.EnableKeyword("WATER_REFLECTIVE");
					Shader.DisableKeyword("WATER_REFRACTIVE");
					break;
				case WaterMode.Refractive:
					Shader.DisableKeyword("WATER_SIMPLE");
					Shader.DisableKeyword("WATER_REFLECTIVE");
					Shader.EnableKeyword("WATER_REFRACTIVE");
					break;
				}
				s_InsideWater = false;
			}
		}

		private void OnDisable()
		{
			if ((bool)m_ReflectionTexture)
			{
				UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
				m_ReflectionTexture = null;
			}
			if ((bool)m_RefractionTexture)
			{
				UnityEngine.Object.DestroyImmediate(m_RefractionTexture);
				m_RefractionTexture = null;
			}
			foreach (KeyValuePair<Camera, Camera> reflectionCamera in m_ReflectionCameras)
			{
				UnityEngine.Object.DestroyImmediate(reflectionCamera.Value.gameObject);
			}
			m_ReflectionCameras.Clear();
			foreach (KeyValuePair<Camera, Camera> refractionCamera in m_RefractionCameras)
			{
				UnityEngine.Object.DestroyImmediate(refractionCamera.Value.gameObject);
			}
			m_RefractionCameras.Clear();
		}

		private void Update()
		{
			if ((bool)GetComponent<Renderer>())
			{
				Material sharedMaterial = GetComponent<Renderer>().sharedMaterial;
				if ((bool)sharedMaterial)
				{
					Vector4 vector = sharedMaterial.GetVector("WaveSpeed");
					float @float = sharedMaterial.GetFloat("_WaveScale");
					Vector4 value = new Vector4(@float, @float, @float * 0.4f, @float * 0.45f);
					double num = (double)Time.timeSinceLevelLoad / 20.0;
					Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 1.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 1.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 1.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 1.0));
					sharedMaterial.SetVector("_WaveOffset", value2);
					sharedMaterial.SetVector("_WaveScale4", value);
				}
			}
		}

		private void UpdateCameraModes(Camera src, Camera dest)
		{
			if (dest == null)
			{
				return;
			}
			dest.clearFlags = src.clearFlags;
			dest.backgroundColor = src.backgroundColor;
			if (src.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = src.GetComponent<Skybox>();
				Skybox component2 = dest.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = false;
				}
				else
				{
					component2.enabled = true;
					component2.material = component.material;
				}
			}
			dest.farClipPlane = src.farClipPlane;
			dest.nearClipPlane = src.nearClipPlane;
			dest.orthographic = src.orthographic;
			dest.fieldOfView = src.fieldOfView;
			dest.aspect = src.aspect;
			dest.orthographicSize = src.orthographicSize;
		}

		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
			WaterMode waterMode = GetWaterMode();
			reflectionCamera = null;
			refractionCamera = null;
			if (waterMode >= WaterMode.Reflective)
			{
				if (!m_ReflectionTexture || m_OldReflectionTextureSize != textureSize)
				{
					if ((bool)m_ReflectionTexture)
					{
						UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
					}
					m_ReflectionTexture = new RenderTexture(textureSize, textureSize, 16);
					m_ReflectionTexture.name = "__WaterReflection" + GetInstanceID();
					m_ReflectionTexture.isPowerOfTwo = true;
					m_ReflectionTexture.hideFlags = HideFlags.DontSave;
					m_OldReflectionTextureSize = textureSize;
				}
				m_ReflectionCameras.TryGetValue(currentCamera, out reflectionCamera);
				if (!reflectionCamera)
				{
					GameObject gameObject = new GameObject("Water Refl Camera id" + GetInstanceID() + " for " + currentCamera.GetInstanceID(), typeof(Camera), typeof(Skybox));
					reflectionCamera = gameObject.GetComponent<Camera>();
					reflectionCamera.enabled = false;
					reflectionCamera.transform.position = base.transform.position;
					reflectionCamera.transform.rotation = base.transform.rotation;
					reflectionCamera.gameObject.AddComponent<FlareLayer>();
					gameObject.hideFlags = HideFlags.HideAndDontSave;
					m_ReflectionCameras[currentCamera] = reflectionCamera;
				}
			}
			if (waterMode < WaterMode.Refractive)
			{
				return;
			}
			if (!m_RefractionTexture || m_OldRefractionTextureSize != textureSize)
			{
				if ((bool)m_RefractionTexture)
				{
					UnityEngine.Object.DestroyImmediate(m_RefractionTexture);
				}
				m_RefractionTexture = new RenderTexture(textureSize, textureSize, 16);
				m_RefractionTexture.name = "__WaterRefraction" + GetInstanceID();
				m_RefractionTexture.isPowerOfTwo = true;
				m_RefractionTexture.hideFlags = HideFlags.DontSave;
				m_OldRefractionTextureSize = textureSize;
			}
			m_RefractionCameras.TryGetValue(currentCamera, out refractionCamera);
			if (!refractionCamera)
			{
				GameObject gameObject2 = new GameObject("Water Refr Camera id" + GetInstanceID() + " for " + currentCamera.GetInstanceID(), typeof(Camera), typeof(Skybox));
				refractionCamera = gameObject2.GetComponent<Camera>();
				refractionCamera.enabled = false;
				refractionCamera.transform.position = base.transform.position;
				refractionCamera.transform.rotation = base.transform.rotation;
				refractionCamera.gameObject.AddComponent<FlareLayer>();
				gameObject2.hideFlags = HideFlags.HideAndDontSave;
				m_RefractionCameras[currentCamera] = refractionCamera;
			}
		}

		private WaterMode GetWaterMode()
		{
			if (m_HardwareWaterSupport < waterMode)
			{
				return m_HardwareWaterSupport;
			}
			return waterMode;
		}

		private WaterMode FindHardwareWaterSupport()
		{
			if (!GetComponent<Renderer>())
			{
				return WaterMode.Simple;
			}
			Material sharedMaterial = GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return WaterMode.Simple;
			}
			string text = sharedMaterial.GetTag("WATERMODE", searchFallbacks: false);
			if (text == "Refractive")
			{
				return WaterMode.Refractive;
			}
			if (text == "Reflective")
			{
				return WaterMode.Reflective;
			}
			return WaterMode.Simple;
		}

		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			Vector3 point = pos + normal * clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 rhs = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
			return new Vector4(rhs.x, rhs.y, rhs.z, 0f - Vector3.Dot(lhs, rhs));
		}

		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
			reflectionMat.m00 = 1f - 2f * plane[0] * plane[0];
			reflectionMat.m01 = -2f * plane[0] * plane[1];
			reflectionMat.m02 = -2f * plane[0] * plane[2];
			reflectionMat.m03 = -2f * plane[3] * plane[0];
			reflectionMat.m10 = -2f * plane[1] * plane[0];
			reflectionMat.m11 = 1f - 2f * plane[1] * plane[1];
			reflectionMat.m12 = -2f * plane[1] * plane[2];
			reflectionMat.m13 = -2f * plane[3] * plane[1];
			reflectionMat.m20 = -2f * plane[2] * plane[0];
			reflectionMat.m21 = -2f * plane[2] * plane[1];
			reflectionMat.m22 = 1f - 2f * plane[2] * plane[2];
			reflectionMat.m23 = -2f * plane[3] * plane[2];
			reflectionMat.m30 = 0f;
			reflectionMat.m31 = 0f;
			reflectionMat.m32 = 0f;
			reflectionMat.m33 = 1f;
		}
	}
	public enum WaterQuality
	{
		High = 2,
		Medium = 1,
		Low = 0
	}
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		public Material sharedMaterial;

		public WaterQuality waterQuality = WaterQuality.High;

		public bool edgeBlend = true;

		public void UpdateShader()
		{
			if (waterQuality > WaterQuality.Medium)
			{
				sharedMaterial.shader.maximumLOD = 501;
			}
			else if (waterQuality > WaterQuality.Low)
			{
				sharedMaterial.shader.maximumLOD = 301;
			}
			else
			{
				sharedMaterial.shader.maximumLOD = 201;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				edgeBlend = false;
			}
			if (edgeBlend)
			{
				Shader.EnableKeyword("WATER_EDGEBLEND_ON");
				Shader.DisableKeyword("WATER_EDGEBLEND_OFF");
				if ((bool)Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
				}
			}
			else
			{
				Shader.EnableKeyword("WATER_EDGEBLEND_OFF");
				Shader.DisableKeyword("WATER_EDGEBLEND_ON");
			}
		}

		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
			if ((bool)currentCam && edgeBlend)
			{
				currentCam.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		public void Update()
		{
			if ((bool)sharedMaterial)
			{
				UpdateShader();
			}
		}
	}
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		public PlanarReflection reflection;

		public WaterBase waterBase;

		public void Start()
		{
			AcquireComponents();
		}

		private void AcquireComponents()
		{
			if (!reflection)
			{
				if ((bool)base.transform.parent)
				{
					reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!waterBase)
			{
				if ((bool)base.transform.parent)
				{
					waterBase = base.transform.parent.GetComponent<WaterBase>();
				}
				else
				{
					waterBase = base.transform.GetComponent<WaterBase>();
				}
			}
		}

		public void OnWillRenderObject()
		{
			if ((bool)reflection)
			{
				reflection.WaterTileBeingRendered(base.transform, Camera.current);
			}
			if ((bool)waterBase)
			{
				waterBase.WaterTileBeingRendered(base.transform, Camera.current);
			}
		}
	}
}
