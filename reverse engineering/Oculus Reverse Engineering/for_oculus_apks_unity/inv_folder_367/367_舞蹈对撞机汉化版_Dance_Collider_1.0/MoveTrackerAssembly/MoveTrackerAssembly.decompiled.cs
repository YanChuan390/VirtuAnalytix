using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("PadTrackerAssembly")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("PadTrackerAssembly")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2014")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("816ae558-fd8d-46f8-a901-8f55c9f9d60e")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyVersion("1.0.0.0")]
namespace UnityEngine.PS4.Engines;

public struct SceMoveButtonData
{
	public ushort digitalButtons;

	public ushort analogT;
}
public struct SceMoveExtensionPortData
{
	public ushort status;

	public ushort digital1;

	public ushort digital2;

	public ushort analogRightX;

	public ushort analogRightY;

	public ushort analogLeftX;

	public ushort analogLeftY;

	public byte custom0;

	public byte custom1;

	public byte custom2;

	public byte custom3;

	public byte custom4;
}
[Serializable]
public struct SceMoveTrackerState
{
	public Vector3 position;

	public Vector3 velocity;

	public Vector3 acceleration;

	public Quaternion orientation;

	public Vector3 angularVelocity;

	public Vector3 angularAcceleration;

	public Vector3 accelerometerPosition;

	public Vector3 accelerometerVelocity;

	public Vector3 accelerometerAcceleration;

	public float cameraPitchAngle;

	public float cameraRollAngle;

	public SceMoveButtonData pad;

	public SceMoveExtensionPortData ext;

	public ulong timestamp;

	public uint flags;
}
public class MoveTracker
{
	[DllImport("MoveTrackerPlugin")]
	private static extern int PrxMoveTrackerInitialise();

	[DllImport("MoveTrackerPlugin")]
	private static extern int PrxMoveTrackerShutdown();

	[DllImport("MoveTrackerPlugin")]
	private static extern int PrxMoveTrackerCalibrate();

	[DllImport("MoveTrackerPlugin")]
	private static extern int PrxMoveTrackerUpdate(ulong cameraFrameHandle, int[] controllerHandles, IntPtr controllerInputs);

	[DllImport("MoveTrackerPlugin")]
	private static extern int PrxMoveTrackerQueueUpdate(ulong cameraFrameHandle, int[] controllerHandles, IntPtr controllerInputs);

	[DllImport("MoveTrackerPlugin")]
	private static extern int PrxMoveTrackerReadState(int handle, out SceMoveTrackerState data);

	[DllImport("MoveTrackerPlugin")]
	private static extern int PrxMoveTrackerReadState(int handle, IntPtr ptr);

	public static int Init()
	{
		return PrxMoveTrackerInitialise();
	}

	public static int Term()
	{
		return PrxMoveTrackerShutdown();
	}

	public static int Calibrate()
	{
		return PrxMoveTrackerCalibrate();
	}

	public static int QueueUpdate(ulong cameraFrameHandle, int[] controllerHandles, IntPtr controllerInputs)
	{
		return PrxMoveTrackerQueueUpdate(cameraFrameHandle, controllerHandles, controllerInputs);
	}

	public static int Update(ulong cameraFrameHandle, int[] controllerHandles, IntPtr controllerInputs)
	{
		return PrxMoveTrackerUpdate(cameraFrameHandle, controllerHandles, controllerInputs);
	}

	public static int ReadState(int controllerhandle, out SceMoveTrackerState data)
	{
		return PrxMoveTrackerReadState(controllerhandle, out data);
	}
}
