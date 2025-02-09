using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVideoSource
/// </summary>
/// <remarks>
///    Superclass of video input devices for VTK
///
/// vtkVideoSource is a superclass for video input interfaces for VTK.
/// The goal is to provide an interface which is very similar to the
/// interface of a VCR, where the 'tape' is an internal frame buffer
/// capable of holding a preset number of video frames.  Specialized
/// versions of this class record input from various video input sources.
/// This base class records input from a noise source.
/// @warning
/// You must call the ReleaseSystemResources() method before the application
/// exits.  Otherwise the application might hang while trying to exit.
/// </remarks>
/// <seealso>
///
/// vtkWin32VideoSource vtkMILVideoSource
/// </seealso>
public class vtkVideoSource : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVideoSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVideoSource()
	{
		MRClassNameKey = "class vtkVideoSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVideoSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVideoSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVideoSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVideoSource New()
	{
		vtkVideoSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVideoSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVideoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVideoSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVideoSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_AutoAdvanceOff_01(HandleRef pThis);

	/// <summary>
	/// Set whether to automatically advance the buffer before each grab.
	/// Default: on
	/// </summary>
	public virtual void AutoAdvanceOff()
	{
		vtkVideoSource_AutoAdvanceOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_AutoAdvanceOn_02(HandleRef pThis);

	/// <summary>
	/// Set whether to automatically advance the buffer before each grab.
	/// Default: on
	/// </summary>
	public virtual void AutoAdvanceOn()
	{
		vtkVideoSource_AutoAdvanceOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_FastForward_03(HandleRef pThis);

	/// <summary>
	/// FastForward to the last frame that was recorded (i.e. to the frame
	/// that has the most recent timestamp).
	/// </summary>
	public virtual void FastForward()
	{
		vtkVideoSource_FastForward_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_GetAutoAdvance_04(HandleRef pThis);

	/// <summary>
	/// Set whether to automatically advance the buffer before each grab.
	/// Default: on
	/// </summary>
	public virtual int GetAutoAdvance()
	{
		return vtkVideoSource_GetAutoAdvance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVideoSource_GetClipRegion_05(HandleRef pThis);

	/// <summary>
	/// Set the clip rectangle for the frames.  The video will be clipped
	/// before it is copied into the framebuffer.  Changing the ClipRegion
	/// will destroy the current contents of the framebuffer.
	/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
	/// </summary>
	public virtual int[] GetClipRegion()
	{
		IntPtr intPtr = vtkVideoSource_GetClipRegion_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetClipRegion_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the clip rectangle for the frames.  The video will be clipped
	/// before it is copied into the framebuffer.  Changing the ClipRegion
	/// will destroy the current contents of the framebuffer.
	/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
	/// </summary>
	public virtual void GetClipRegion(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkVideoSource_GetClipRegion_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetClipRegion_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the clip rectangle for the frames.  The video will be clipped
	/// before it is copied into the framebuffer.  Changing the ClipRegion
	/// will destroy the current contents of the framebuffer.
	/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
	/// </summary>
	public virtual void GetClipRegion(IntPtr _arg)
	{
		vtkVideoSource_GetClipRegion_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVideoSource_GetDataOrigin_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the coordinates of the lower, left corner of the frame.
	/// Default: (0.0,0.0,0.0)
	/// </summary>
	public virtual double[] GetDataOrigin()
	{
		IntPtr intPtr = vtkVideoSource_GetDataOrigin_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetDataOrigin_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the coordinates of the lower, left corner of the frame.
	/// Default: (0.0,0.0,0.0)
	/// </summary>
	public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkVideoSource_GetDataOrigin_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetDataOrigin_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the coordinates of the lower, left corner of the frame.
	/// Default: (0.0,0.0,0.0)
	/// </summary>
	public virtual void GetDataOrigin(IntPtr _arg)
	{
		vtkVideoSource_GetDataOrigin_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVideoSource_GetDataSpacing_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// Default: (1.0,1.0,1.0)
	/// </summary>
	public virtual double[] GetDataSpacing()
	{
		IntPtr intPtr = vtkVideoSource_GetDataSpacing_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetDataSpacing_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// Default: (1.0,1.0,1.0)
	/// </summary>
	public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkVideoSource_GetDataSpacing_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetDataSpacing_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// Default: (1.0,1.0,1.0)
	/// </summary>
	public virtual void GetDataSpacing(IntPtr _arg)
	{
		vtkVideoSource_GetDataSpacing_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_GetFrameBufferSize_14(HandleRef pThis);

	/// <summary>
	/// Set size of the frame buffer, i.e. the number of frames that
	/// the 'tape' can store.
	/// </summary>
	public virtual int GetFrameBufferSize()
	{
		return vtkVideoSource_GetFrameBufferSize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_GetFrameCount_15(HandleRef pThis);

	/// <summary>
	/// This value is incremented each time a frame is grabbed.
	/// reset it to zero (or any other value) at any time.
	/// </summary>
	public virtual int GetFrameCount()
	{
		return vtkVideoSource_GetFrameCount_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_GetFrameIndex_16(HandleRef pThis);

	/// <summary>
	/// Get the frame index relative to the 'beginning of the tape'.  This
	/// value wraps back to zero if it increases past the FrameBufferSize.
	/// </summary>
	public virtual int GetFrameIndex()
	{
		return vtkVideoSource_GetFrameIndex_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkVideoSource_GetFrameRate_17(HandleRef pThis);

	/// <summary>
	/// Request a particular frame rate (default 30 frames per second).
	/// </summary>
	public virtual float GetFrameRate()
	{
		return vtkVideoSource_GetFrameRate_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVideoSource_GetFrameSize_18(HandleRef pThis);

	/// <summary>
	/// Set the full-frame size.  This must be an allowed size for the device,
	/// the device may either refuse a request for an illegal frame size or
	/// automatically choose a new frame size.
	/// The default is usually 320x240x1, but can be device specific.
	/// The 'depth' should always be 1 (unless you have a device that
	/// can handle 3D acquisition).
	/// </summary>
	public virtual int[] GetFrameSize()
	{
		IntPtr intPtr = vtkVideoSource_GetFrameSize_18(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetFrameSize_19(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set the full-frame size.  This must be an allowed size for the device,
	/// the device may either refuse a request for an illegal frame size or
	/// automatically choose a new frame size.
	/// The default is usually 320x240x1, but can be device specific.
	/// The 'depth' should always be 1 (unless you have a device that
	/// can handle 3D acquisition).
	/// </summary>
	public virtual void GetFrameSize(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkVideoSource_GetFrameSize_19(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetFrameSize_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the full-frame size.  This must be an allowed size for the device,
	/// the device may either refuse a request for an illegal frame size or
	/// automatically choose a new frame size.
	/// The default is usually 320x240x1, but can be device specific.
	/// The 'depth' should always be 1 (unless you have a device that
	/// can handle 3D acquisition).
	/// </summary>
	public virtual void GetFrameSize(IntPtr _arg)
	{
		vtkVideoSource_GetFrameSize_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVideoSource_GetFrameTimeStamp_21(HandleRef pThis, int frame);

	/// <summary>
	/// Get a time stamp in seconds (resolution of milliseconds) for
	/// a video frame.   Time began on Jan 1, 1970.  You can specify
	/// a number (negative or positive) to specify the position of the
	/// video frame relative to the current frame.
	/// </summary>
	public virtual double GetFrameTimeStamp(int frame)
	{
		return vtkVideoSource_GetFrameTimeStamp_21(GetCppThis(), frame);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVideoSource_GetFrameTimeStamp_22(HandleRef pThis);

	/// <summary>
	/// Get a time stamp in seconds (resolution of milliseconds) for
	/// the Output.  Time began on Jan 1, 1970.  This timestamp is only
	/// valid after the Output has been Updated.
	/// </summary>
	public double GetFrameTimeStamp()
	{
		return vtkVideoSource_GetFrameTimeStamp_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_GetInitialized_23(HandleRef pThis);

	/// <summary>
	/// Initialize the hardware.  This is called automatically
	/// on the first Update or Grab.
	/// </summary>
	public virtual int GetInitialized()
	{
		return vtkVideoSource_GetInitialized_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVideoSource_GetNumberOfGenerationsFromBase_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVideoSource_GetNumberOfGenerationsFromBase_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVideoSource_GetNumberOfGenerationsFromBaseType_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVideoSource_GetNumberOfGenerationsFromBaseType_25(type);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_GetNumberOfOutputFrames_26(HandleRef pThis);

	/// <summary>
	/// Set the number of frames to copy to the output on each execute.
	/// The frames will be concatenated along the Z dimension, with the
	/// most recent frame first.
	/// Default: 1
	/// </summary>
	public virtual int GetNumberOfOutputFrames()
	{
		return vtkVideoSource_GetNumberOfOutputFrames_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkVideoSource_GetOpacity_27(HandleRef pThis);

	/// <summary>
	/// For RGBA output only (4 scalar components), set the opacity.  This
	/// will not modify the existing contents of the framebuffer, only
	/// subsequently grabbed frames.
	/// </summary>
	public virtual float GetOpacity()
	{
		return vtkVideoSource_GetOpacity_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_GetOutputFormat_28(HandleRef pThis);

	/// <summary>
	/// Set the output format.  This must be appropriate for device,
	/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
	/// </summary>
	public virtual int GetOutputFormat()
	{
		return vtkVideoSource_GetOutputFormat_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVideoSource_GetOutputWholeExtent_29(HandleRef pThis);

	/// <summary>
	/// Get/Set the WholeExtent of the output.  This can be used to either
	/// clip or pad the video frame.  This clipping/padding is done when
	/// the frame is copied to the output, and does not change the contents
	/// of the framebuffer.  This is useful e.g. for expanding
	/// the output size to a power of two for texture mapping.  The
	/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
	/// copied to the output.
	/// </summary>
	public virtual int[] GetOutputWholeExtent()
	{
		IntPtr intPtr = vtkVideoSource_GetOutputWholeExtent_29(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetOutputWholeExtent_30(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Get/Set the WholeExtent of the output.  This can be used to either
	/// clip or pad the video frame.  This clipping/padding is done when
	/// the frame is copied to the output, and does not change the contents
	/// of the framebuffer.  This is useful e.g. for expanding
	/// the output size to a power of two for texture mapping.  The
	/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
	/// copied to the output.
	/// </summary>
	public virtual void GetOutputWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkVideoSource_GetOutputWholeExtent_30(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_GetOutputWholeExtent_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the WholeExtent of the output.  This can be used to either
	/// clip or pad the video frame.  This clipping/padding is done when
	/// the frame is copied to the output, and does not change the contents
	/// of the framebuffer.  This is useful e.g. for expanding
	/// the output size to a power of two for texture mapping.  The
	/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
	/// copied to the output.
	/// </summary>
	public virtual void GetOutputWholeExtent(IntPtr _arg)
	{
		vtkVideoSource_GetOutputWholeExtent_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_GetPlaying_32(HandleRef pThis);

	/// <summary>
	/// Are we in play mode? (record mode and play mode are mutually
	/// exclusive).
	/// </summary>
	public virtual int GetPlaying()
	{
		return vtkVideoSource_GetPlaying_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_GetRecording_33(HandleRef pThis);

	/// <summary>
	/// Are we in record mode? (record mode and play mode are mutually
	/// exclusive).
	/// </summary>
	public virtual int GetRecording()
	{
		return vtkVideoSource_GetRecording_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVideoSource_GetStartTimeStamp_34(HandleRef pThis);

	/// <summary>
	/// And internal variable which marks the beginning of a Record session.
	/// These methods are for internal use only.
	/// </summary>
	public double GetStartTimeStamp()
	{
		return vtkVideoSource_GetStartTimeStamp_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_Grab_35(HandleRef pThis);

	/// <summary>
	/// Grab a single video frame.
	/// </summary>
	public virtual void Grab()
	{
		vtkVideoSource_Grab_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_Initialize_36(HandleRef pThis);

	/// <summary>
	/// Initialize the hardware.  This is called automatically
	/// on the first Update or Grab.
	/// </summary>
	public virtual void Initialize()
	{
		vtkVideoSource_Initialize_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_InternalGrab_37(HandleRef pThis);

	/// <summary>
	/// The internal function which actually does the grab.  You will
	/// definitely want to override this if you develop a vtkVideoSource
	/// subclass.
	/// </summary>
	public virtual void InternalGrab()
	{
		vtkVideoSource_InternalGrab_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_IsA_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVideoSource_IsA_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVideoSource_IsTypeOf_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVideoSource_IsTypeOf_39(type);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVideoSource_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVideoSource NewInstance()
	{
		vtkVideoSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVideoSource_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVideoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_Play_42(HandleRef pThis);

	/// <summary>
	/// Play through the 'tape' sequentially at the specified frame rate.
	/// If you have just finished Recoding, you should call Rewind() first.
	/// </summary>
	public virtual void Play()
	{
		vtkVideoSource_Play_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_Record_43(HandleRef pThis);

	/// <summary>
	/// Record incoming video at the specified FrameRate.  The recording
	/// continues indefinitely until Stop() is called.
	/// </summary>
	public virtual void Record()
	{
		vtkVideoSource_Record_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_ReleaseSystemResources_44(HandleRef pThis);

	/// <summary>
	/// Release the video driver.  This method must be called before
	/// application exit, or else the application might hang during
	/// exit.
	/// </summary>
	public virtual void ReleaseSystemResources()
	{
		vtkVideoSource_ReleaseSystemResources_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_Rewind_45(HandleRef pThis);

	/// <summary>
	/// Rewind to the frame with the earliest timestamp.  Record operations
	/// will start on the following frame, therefore if you want to re-record
	/// over this frame you must call Seek(-1) before calling Grab() or Record().
	/// </summary>
	public virtual void Rewind()
	{
		vtkVideoSource_Rewind_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVideoSource_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVideoSource SafeDownCast(vtkObjectBase o)
	{
		vtkVideoSource vtkVideoSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVideoSource_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVideoSource2 = (vtkVideoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVideoSource2.Register(null);
			}
		}
		return vtkVideoSource2;
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_Seek_47(HandleRef pThis, int n);

	/// <summary>
	/// Seek forwards or backwards by the specified number of frames
	/// (positive is forward, negative is backward).
	/// </summary>
	public virtual void Seek(int n)
	{
		vtkVideoSource_Seek_47(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetAutoAdvance_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to automatically advance the buffer before each grab.
	/// Default: on
	/// </summary>
	public virtual void SetAutoAdvance(int _arg)
	{
		vtkVideoSource_SetAutoAdvance_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetClipRegion_49(HandleRef pThis, IntPtr r);

	/// <summary>
	/// Set the clip rectangle for the frames.  The video will be clipped
	/// before it is copied into the framebuffer.  Changing the ClipRegion
	/// will destroy the current contents of the framebuffer.
	/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
	/// </summary>
	public virtual void SetClipRegion(IntPtr r)
	{
		vtkVideoSource_SetClipRegion_49(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetClipRegion_50(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

	/// <summary>
	/// Set the clip rectangle for the frames.  The video will be clipped
	/// before it is copied into the framebuffer.  Changing the ClipRegion
	/// will destroy the current contents of the framebuffer.
	/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
	/// </summary>
	public virtual void SetClipRegion(int x0, int x1, int y0, int y1, int z0, int z1)
	{
		vtkVideoSource_SetClipRegion_50(GetCppThis(), x0, x1, y0, y1, z0, z1);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetDataOrigin_51(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the coordinates of the lower, left corner of the frame.
	/// Default: (0.0,0.0,0.0)
	/// </summary>
	public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkVideoSource_SetDataOrigin_51(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetDataOrigin_52(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the coordinates of the lower, left corner of the frame.
	/// Default: (0.0,0.0,0.0)
	/// </summary>
	public virtual void SetDataOrigin(IntPtr _arg)
	{
		vtkVideoSource_SetDataOrigin_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetDataSpacing_53(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// Default: (1.0,1.0,1.0)
	/// </summary>
	public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkVideoSource_SetDataSpacing_53(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetDataSpacing_54(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the pixel spacing.
	/// Default: (1.0,1.0,1.0)
	/// </summary>
	public virtual void SetDataSpacing(IntPtr _arg)
	{
		vtkVideoSource_SetDataSpacing_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetFrameBufferSize_55(HandleRef pThis, int FrameBufferSize);

	/// <summary>
	/// Set size of the frame buffer, i.e. the number of frames that
	/// the 'tape' can store.
	/// </summary>
	public virtual void SetFrameBufferSize(int FrameBufferSize)
	{
		vtkVideoSource_SetFrameBufferSize_55(GetCppThis(), FrameBufferSize);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetFrameCount_56(HandleRef pThis, int _arg);

	/// <summary>
	/// This value is incremented each time a frame is grabbed.
	/// reset it to zero (or any other value) at any time.
	/// </summary>
	public virtual void SetFrameCount(int _arg)
	{
		vtkVideoSource_SetFrameCount_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetFrameRate_57(HandleRef pThis, float rate);

	/// <summary>
	/// Request a particular frame rate (default 30 frames per second).
	/// </summary>
	public virtual void SetFrameRate(float rate)
	{
		vtkVideoSource_SetFrameRate_57(GetCppThis(), rate);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetFrameSize_58(HandleRef pThis, int x, int y, int z);

	/// <summary>
	/// Set the full-frame size.  This must be an allowed size for the device,
	/// the device may either refuse a request for an illegal frame size or
	/// automatically choose a new frame size.
	/// The default is usually 320x240x1, but can be device specific.
	/// The 'depth' should always be 1 (unless you have a device that
	/// can handle 3D acquisition).
	/// </summary>
	public virtual void SetFrameSize(int x, int y, int z)
	{
		vtkVideoSource_SetFrameSize_58(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetFrameSize_59(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set the full-frame size.  This must be an allowed size for the device,
	/// the device may either refuse a request for an illegal frame size or
	/// automatically choose a new frame size.
	/// The default is usually 320x240x1, but can be device specific.
	/// The 'depth' should always be 1 (unless you have a device that
	/// can handle 3D acquisition).
	/// </summary>
	public virtual void SetFrameSize(IntPtr dim)
	{
		vtkVideoSource_SetFrameSize_59(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetNumberOfOutputFrames_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of frames to copy to the output on each execute.
	/// The frames will be concatenated along the Z dimension, with the
	/// most recent frame first.
	/// Default: 1
	/// </summary>
	public virtual void SetNumberOfOutputFrames(int _arg)
	{
		vtkVideoSource_SetNumberOfOutputFrames_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetOpacity_61(HandleRef pThis, float _arg);

	/// <summary>
	/// For RGBA output only (4 scalar components), set the opacity.  This
	/// will not modify the existing contents of the framebuffer, only
	/// subsequently grabbed frames.
	/// </summary>
	public virtual void SetOpacity(float _arg)
	{
		vtkVideoSource_SetOpacity_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetOutputFormat_62(HandleRef pThis, int format);

	/// <summary>
	/// Set the output format.  This must be appropriate for device,
	/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
	/// </summary>
	public virtual void SetOutputFormat(int format)
	{
		vtkVideoSource_SetOutputFormat_62(GetCppThis(), format);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetOutputFormatToLuminance_63(HandleRef pThis);

	/// <summary>
	/// Set the output format.  This must be appropriate for device,
	/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
	/// </summary>
	public void SetOutputFormatToLuminance()
	{
		vtkVideoSource_SetOutputFormatToLuminance_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetOutputFormatToRGB_64(HandleRef pThis);

	/// <summary>
	/// Set the output format.  This must be appropriate for device,
	/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
	/// </summary>
	public void SetOutputFormatToRGB()
	{
		vtkVideoSource_SetOutputFormatToRGB_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetOutputFormatToRGBA_65(HandleRef pThis);

	/// <summary>
	/// Set the output format.  This must be appropriate for device,
	/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
	/// </summary>
	public void SetOutputFormatToRGBA()
	{
		vtkVideoSource_SetOutputFormatToRGBA_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetOutputWholeExtent_66(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Get/Set the WholeExtent of the output.  This can be used to either
	/// clip or pad the video frame.  This clipping/padding is done when
	/// the frame is copied to the output, and does not change the contents
	/// of the framebuffer.  This is useful e.g. for expanding
	/// the output size to a power of two for texture mapping.  The
	/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
	/// copied to the output.
	/// </summary>
	public virtual void SetOutputWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkVideoSource_SetOutputWholeExtent_66(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetOutputWholeExtent_67(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the WholeExtent of the output.  This can be used to either
	/// clip or pad the video frame.  This clipping/padding is done when
	/// the frame is copied to the output, and does not change the contents
	/// of the framebuffer.  This is useful e.g. for expanding
	/// the output size to a power of two for texture mapping.  The
	/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
	/// copied to the output.
	/// </summary>
	public virtual void SetOutputWholeExtent(IntPtr _arg)
	{
		vtkVideoSource_SetOutputWholeExtent_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_SetStartTimeStamp_68(HandleRef pThis, double t);

	/// <summary>
	/// And internal variable which marks the beginning of a Record session.
	/// These methods are for internal use only.
	/// </summary>
	public void SetStartTimeStamp(double t)
	{
		vtkVideoSource_SetStartTimeStamp_68(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVideoSource_Stop_69(HandleRef pThis);

	/// <summary>
	/// Stop recording or playing.
	/// </summary>
	public virtual void Stop()
	{
		vtkVideoSource_Stop_69(GetCppThis());
	}
}
