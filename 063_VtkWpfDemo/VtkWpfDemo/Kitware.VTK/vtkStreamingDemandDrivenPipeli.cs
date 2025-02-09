using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStreamingDemandDrivenPipeline
/// </summary>
/// <remarks>
///    Executive supporting partial updates.
///
/// vtkStreamingDemandDrivenPipeline is an executive that supports
/// updating only a portion of the data set in the pipeline.  This is
/// the style of pipeline update that is provided by the old-style VTK
/// 4.x pipeline.  Instead of always updating an entire data set, this
/// executive supports asking for pieces or sub-extents.
/// </remarks>
public class vtkStreamingDemandDrivenPipeline : vtkDemandDrivenPipeline
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStreamingDemandDrivenPipeline";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStreamingDemandDrivenPipeline()
	{
		MRClassNameKey = "class vtkStreamingDemandDrivenPipeline";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamingDemandDrivenPipeline"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStreamingDemandDrivenPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStreamingDemandDrivenPipeline New()
	{
		vtkStreamingDemandDrivenPipeline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStreamingDemandDrivenPipeline()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStreamingDemandDrivenPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_BOUNDS_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// key to record the bounds of a dataset.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationDoubleVectorKey BOUNDS()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_BOUNDS_01(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_COMBINED_UPDATE_EXTENT_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key for combining the update extents requested by all consumers,
	/// so that the final extent that is produced satisfies all consumers.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerVectorKey COMBINED_UPDATE_EXTENT()
	{
		vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_COMBINED_UPDATE_EXTENT_02(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerVectorKey2 = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerVectorKey2.Register(null);
			}
		}
		return vtkInformationIntegerVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_CONTINUE_EXECUTING_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key for an algorithm to store in a request to tell this executive
	/// to keep executing it.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey CONTINUE_EXECUTING()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_CONTINUE_EXECUTING_03(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_EXACT_EXTENT_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key to specify the request for exact extent in pipeline information.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey EXACT_EXTENT()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_EXACT_EXTENT_04(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_GetRequestExactExtent_07(HandleRef pThis, int port);

	/// <summary>
	/// This request flag indicates whether the requester can handle more
	/// data than requested for the given port.  Right now it is used in
	/// vtkImageData.  Image filters can return more data than requested.
	/// The consumer cannot handle this (i.e. DataSetToDataSetfilter)
	/// the image will crop itself.  This functionality used to be in
	/// ImageToStructuredPoints.
	/// </summary>
	public int GetRequestExactExtent(int port)
	{
		return vtkStreamingDemandDrivenPipeline_GetRequestExactExtent_07(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamingDemandDrivenPipeline_GetUpdateExtent_08(HandleRef arg0, IntPtr extent);

	/// <summary>
	/// Get/Set the update extent for output ports that use 3D extents.
	/// </summary>
	public static void GetUpdateExtent(vtkInformation arg0, IntPtr extent)
	{
		vtkStreamingDemandDrivenPipeline_GetUpdateExtent_08(arg0?.GetCppThis() ?? default(HandleRef), extent);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetUpdateExtent_09(HandleRef arg0);

	/// <summary>
	/// Get/Set the update extent for output ports that use 3D extents.
	/// </summary>
	public static IntPtr GetUpdateExtent(vtkInformation arg0)
	{
		return vtkStreamingDemandDrivenPipeline_GetUpdateExtent_09(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_GetUpdateGhostLevel_10(HandleRef arg0);

	/// <summary>
	/// Set/Get the update piece, update number of pieces, and update
	/// number of ghost levels for an output port.  Similar to update
	/// extent in 3D.
	/// </summary>
	public static int GetUpdateGhostLevel(vtkInformation arg0)
	{
		return vtkStreamingDemandDrivenPipeline_GetUpdateGhostLevel_10(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_GetUpdateNumberOfPieces_11(HandleRef arg0);

	/// <summary>
	/// Set/Get the update piece, update number of pieces, and update
	/// number of ghost levels for an output port.  Similar to update
	/// extent in 3D.
	/// </summary>
	public static int GetUpdateNumberOfPieces(vtkInformation arg0)
	{
		return vtkStreamingDemandDrivenPipeline_GetUpdateNumberOfPieces_11(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_GetUpdatePiece_12(HandleRef arg0);

	/// <summary>
	/// Set/Get the update piece, update number of pieces, and update
	/// number of ghost levels for an output port.  Similar to update
	/// extent in 3D.
	/// </summary>
	public static int GetUpdatePiece(vtkInformation arg0)
	{
		return vtkStreamingDemandDrivenPipeline_GetUpdatePiece_12(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamingDemandDrivenPipeline_GetWholeExtent_13(HandleRef arg0, IntPtr extent);

	/// <summary>
	/// Set/Get the whole extent of an output port.  The whole extent is
	/// meta data for structured data sets.  It gets set by the algorithm
	/// during the update information pass.
	/// </summary>
	public static void GetWholeExtent(vtkInformation arg0, IntPtr extent)
	{
		vtkStreamingDemandDrivenPipeline_GetWholeExtent_13(arg0?.GetCppThis() ?? default(HandleRef), extent);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetWholeExtent_14(HandleRef arg0);

	/// <summary>
	/// Set/Get the whole extent of an output port.  The whole extent is
	/// meta data for structured data sets.  It gets set by the algorithm
	/// during the update information pass.
	/// </summary>
	public static int[] GetWholeExtent(vtkInformation arg0)
	{
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_GetWholeExtent_14(arg0?.GetCppThis() ?? default(HandleRef));
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStreamingDemandDrivenPipeline_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStreamingDemandDrivenPipeline_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStreamingDemandDrivenPipeline NewInstance()
	{
		vtkStreamingDemandDrivenPipeline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_PropagateTime_19(HandleRef pThis, int outputPort);

	/// <summary>
	/// Propagate time through the pipeline. this is a special pass
	/// only necessary if there is temporal meta data that must be updated
	/// </summary>
	public int PropagateTime(int outputPort)
	{
		return vtkStreamingDemandDrivenPipeline_PropagateTime_19(GetCppThis(), outputPort);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_PropagateUpdateExtent_20(HandleRef pThis, int outputPort);

	/// <summary>
	/// Propagate the update request from the given output port back
	/// through the pipeline.  Should be called only when information is
	/// up to date.
	/// </summary>
	public int PropagateUpdateExtent(int outputPort)
	{
		return vtkStreamingDemandDrivenPipeline_PropagateUpdateExtent_20(GetCppThis(), outputPort);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REQUEST_TIME_DEPENDENT_INFORMATION_21(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key defining a request to make sure the meta information is up to date.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationRequestKey REQUEST_TIME_DEPENDENT_INFORMATION()
	{
		vtkInformationRequestKey vtkInformationRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_REQUEST_TIME_DEPENDENT_INFORMATION_21(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationRequestKey2 = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationRequestKey2.Register(null);
			}
		}
		return vtkInformationRequestKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_EXTENT_22(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key defining a request to propagate the update extent upstream.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationRequestKey REQUEST_UPDATE_EXTENT()
	{
		vtkInformationRequestKey vtkInformationRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_EXTENT_22(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationRequestKey2 = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationRequestKey2.Register(null);
			}
		}
		return vtkInformationRequestKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_TIME_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key defining a request to propagate the update extent upstream.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationRequestKey REQUEST_UPDATE_TIME()
	{
		vtkInformationRequestKey vtkInformationRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_TIME_23(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationRequestKey2 = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationRequestKey2.Register(null);
			}
		}
		return vtkInformationRequestKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStreamingDemandDrivenPipeline SafeDownCast(vtkObjectBase o)
	{
		vtkStreamingDemandDrivenPipeline vtkStreamingDemandDrivenPipeline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStreamingDemandDrivenPipeline2 = (vtkStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStreamingDemandDrivenPipeline2.Register(null);
			}
		}
		return vtkStreamingDemandDrivenPipeline2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_SetRequestExactExtent_25(HandleRef pThis, int port, int flag);

	/// <summary>
	/// This request flag indicates whether the requester can handle more
	/// data than requested for the given port.  Right now it is used in
	/// vtkImageData.  Image filters can return more data than requested.
	/// The consumer cannot handle this (i.e. DataSetToDataSetfilter)
	/// the image will crop itself.  This functionality used to be in
	/// ImageToStructuredPoints.
	/// </summary>
	public int SetRequestExactExtent(int port, int flag)
	{
		return vtkStreamingDemandDrivenPipeline_SetRequestExactExtent_25(GetCppThis(), port, flag);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_SetWholeExtent_26(HandleRef arg0, IntPtr extent);

	/// <summary>
	/// Set/Get the whole extent of an output port.  The whole extent is
	/// meta data for structured data sets.  It gets set by the algorithm
	/// during the update information pass.
	/// </summary>
	public static int SetWholeExtent(vtkInformation arg0, IntPtr extent)
	{
		return vtkStreamingDemandDrivenPipeline_SetWholeExtent_26(arg0?.GetCppThis() ?? default(HandleRef), extent);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_TIME_DEPENDENT_INFORMATION_27(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Whether there are time dependent meta information
	/// if there is, the pipeline will perform two extra passes
	/// to gather the time dependent information
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey TIME_DEPENDENT_INFORMATION()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_TIME_DEPENDENT_INFORMATION_27(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_TIME_RANGE_28(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key to store available time range for continuous sources.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationDoubleVectorKey TIME_RANGE()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_TIME_RANGE_28(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_TIME_STEPS_29(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key to store available time steps.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationDoubleVectorKey TIME_STEPS()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_TIME_STEPS_29(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UNRESTRICTED_UPDATE_EXTENT_30(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is set if the update extent is not restricted to the
	/// whole extent, for sources that can generate an extent of
	/// any requested size.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey UNRESTRICTED_UPDATE_EXTENT()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_UNRESTRICTED_UPDATE_EXTENT_30(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_31(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerVectorKey UPDATE_EXTENT()
	{
		vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_31(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerVectorKey2 = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerVectorKey2.Register(null);
			}
		}
		return vtkInformationIntegerVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_INITIALIZED_32(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Keys to store an update request in pipeline information.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey UPDATE_EXTENT_INITIALIZED()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_INITIALIZED_32(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_GHOST_LEVELS_33(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey UPDATE_NUMBER_OF_GHOST_LEVELS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_GHOST_LEVELS_33(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_PIECES_34(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey UPDATE_NUMBER_OF_PIECES()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_PIECES_34(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_PIECE_NUMBER_35(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey UPDATE_PIECE_NUMBER()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_UPDATE_PIECE_NUMBER_35(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_TIME_STEP_36(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Update time steps requested by the pipeline.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationDoubleKey UPDATE_TIME_STEP()
	{
		vtkInformationDoubleKey vtkInformationDoubleKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_UPDATE_TIME_STEP_36(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleKey2 = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleKey2.Register(null);
			}
		}
		return vtkInformationDoubleKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_Update_37(HandleRef pThis);

	/// <summary>
	/// Bring the outputs up-to-date.
	/// </summary>
	public override int Update()
	{
		return vtkStreamingDemandDrivenPipeline_Update_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_Update_38(HandleRef pThis, int port);

	/// <summary>
	/// Bring the outputs up-to-date.
	/// </summary>
	public override int Update(int port)
	{
		return vtkStreamingDemandDrivenPipeline_Update_38(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_Update_39(HandleRef pThis, int port, HandleRef requests);

	/// <summary>
	/// This method enables the passing of data requests to the algorithm
	/// to be used during execution (in addition to bringing a particular
	/// port up-to-date). The requests argument should contain an information
	/// object for each port that requests need to be passed. For each
	/// of those, the pipeline will copy all keys to the output information
	/// before execution. This is equivalent to:
	/// \verbatim
	/// executive-&gt;UpdateInformation();
	/// for (int i=0; i&lt;executive-&gt;GetNumberOfOutputPorts(); i++)
	/// {
	/// vtkInformation* portRequests = requests-&gt;GetInformationObject(i);
	/// if (portRequests)
	/// {
	/// executive-&gt;GetOutputInformation(i)-&gt;Append(portRequests);
	/// }
	/// }
	/// executive-&gt;Update();
	/// \endverbatim
	/// Available requests include UPDATE_PIECE_NUMBER(), UPDATE_NUMBER_OF_PIECES()
	/// UPDATE_EXTENT() etc etc.
	/// </summary>
	public virtual int Update(int port, vtkInformationVector requests)
	{
		return vtkStreamingDemandDrivenPipeline_Update_39(GetCppThis(), port, requests?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_UpdateTimeDependentInformation_40(HandleRef pThis, int outputPort);

	/// <summary>
	/// Propagate time through the pipeline. this is a special pass
	/// only necessary if there is temporal meta data that must be updated
	/// </summary>
	public int UpdateTimeDependentInformation(int outputPort)
	{
		return vtkStreamingDemandDrivenPipeline_UpdateTimeDependentInformation_40(GetCppThis(), outputPort);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamingDemandDrivenPipeline_UpdateWholeExtent_41(HandleRef pThis);

	/// <summary>
	/// Bring the outputs up-to-date.
	/// </summary>
	public virtual int UpdateWholeExtent()
	{
		return vtkStreamingDemandDrivenPipeline_UpdateWholeExtent_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamingDemandDrivenPipeline_WHOLE_EXTENT_42(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key to store the whole extent provided in pipeline information.
	/// \ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerVectorKey WHOLE_EXTENT()
	{
		vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamingDemandDrivenPipeline_WHOLE_EXTENT_42(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerVectorKey2 = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerVectorKey2.Register(null);
			}
		}
		return vtkInformationIntegerVectorKey2;
	}
}
