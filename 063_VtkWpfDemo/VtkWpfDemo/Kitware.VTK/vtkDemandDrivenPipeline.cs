using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDemandDrivenPipeline
/// </summary>
/// <remarks>
///    Executive supporting on-demand execution.
///
/// vtkDemandDrivenPipeline is an executive that will execute an
/// algorithm only when its outputs are out-of-date with respect to its
/// inputs.
/// </remarks>
public class vtkDemandDrivenPipeline : vtkExecutive
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDemandDrivenPipeline";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDemandDrivenPipeline()
	{
		MRClassNameKey = "class vtkDemandDrivenPipeline";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDemandDrivenPipeline"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDemandDrivenPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDemandDrivenPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDemandDrivenPipeline New()
	{
		vtkDemandDrivenPipeline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDemandDrivenPipeline()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDemandDrivenPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDemandDrivenPipeline_DATA_NOT_GENERATED_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key to store a mark for an output that will not be generated.
	/// Algorithms use this to tell the executive that they will not
	/// generate certain outputs for a REQUEST_DATA.
	/// @ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey DATA_NOT_GENERATED()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_DATA_NOT_GENERATED_01(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDemandDrivenPipeline_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDemandDrivenPipeline_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDemandDrivenPipeline_GetPipelineMTime_04(HandleRef pThis);

	/// <summary>
	/// Get the PipelineMTime for this exective.
	/// </summary>
	public virtual ulong GetPipelineMTime()
	{
		return vtkDemandDrivenPipeline_GetPipelineMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_GetReleaseDataFlag_05(HandleRef pThis, int port);

	/// <summary>
	/// Get whether the given output port releases data when it is consumed.
	/// </summary>
	public virtual int GetReleaseDataFlag(int port)
	{
		return vtkDemandDrivenPipeline_GetReleaseDataFlag_05(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDemandDrivenPipeline_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDemandDrivenPipeline_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDemandDrivenPipeline_NewDataObject_09(string type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create (New) and return a data object of the given type.
	/// This is here for backwards compatibility. Use
	/// vtkDataObjectTypes::NewDataObject() instead.
	/// </summary>
	public static vtkDataObject NewDataObject(string type)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_NewDataObject_09(type, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDemandDrivenPipeline_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDemandDrivenPipeline NewInstance()
	{
		vtkDemandDrivenPipeline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDemandDrivenPipeline_RELEASE_DATA_11(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key to specify in pipeline information the request that data be
	/// released after it is used.
	/// @ingroup InformationKeys
	/// </summary>
	public static vtkInformationIntegerKey RELEASE_DATA()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_RELEASE_DATA_11(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_DATA_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key defining a request to make sure the output data are up to date.
	/// @ingroup InformationKeys
	/// </summary>
	public static vtkInformationRequestKey REQUEST_DATA()
	{
		vtkInformationRequestKey vtkInformationRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_REQUEST_DATA_12(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_DATA_NOT_GENERATED_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key defining a request to mark outputs that will NOT be generated
	/// during a REQUEST_DATA.
	/// @ingroup InformationKeys
	/// </summary>
	public static vtkInformationRequestKey REQUEST_DATA_NOT_GENERATED()
	{
		vtkInformationRequestKey vtkInformationRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_REQUEST_DATA_NOT_GENERATED_13(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_DATA_OBJECT_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key defining a request to make sure the output data objects exist.
	/// @ingroup InformationKeys
	/// </summary>
	public static vtkInformationRequestKey REQUEST_DATA_OBJECT()
	{
		vtkInformationRequestKey vtkInformationRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_REQUEST_DATA_OBJECT_14(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_INFORMATION_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key defining a request to make sure the output information is up to date.
	/// @ingroup InformationKeys
	/// </summary>
	public static vtkInformationRequestKey REQUEST_INFORMATION()
	{
		vtkInformationRequestKey vtkInformationRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_REQUEST_INFORMATION_15(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDemandDrivenPipeline_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDemandDrivenPipeline SafeDownCast(vtkObjectBase o)
	{
		vtkDemandDrivenPipeline vtkDemandDrivenPipeline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDemandDrivenPipeline_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDemandDrivenPipeline2 = (vtkDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDemandDrivenPipeline2.Register(null);
			}
		}
		return vtkDemandDrivenPipeline2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_SetReleaseDataFlag_17(HandleRef pThis, int port, int n);

	/// <summary>
	/// Set whether the given output port releases data when it is
	/// consumed.  Returns 1 if the value changes and 0 otherwise.
	/// </summary>
	public virtual int SetReleaseDataFlag(int port, int n)
	{
		return vtkDemandDrivenPipeline_SetReleaseDataFlag_17(GetCppThis(), port, n);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_Update_18(HandleRef pThis);

	/// <summary>
	/// Bring the algorithm's outputs up-to-date.  Returns 1 for success
	/// and 0 for failure.
	/// </summary>
	public override int Update()
	{
		return vtkDemandDrivenPipeline_Update_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_Update_19(HandleRef pThis, int port);

	/// <summary>
	/// Bring the algorithm's outputs up-to-date.  Returns 1 for success
	/// and 0 for failure.
	/// </summary>
	public override int Update(int port)
	{
		return vtkDemandDrivenPipeline_Update_19(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_UpdateData_20(HandleRef pThis, int outputPort);

	/// <summary>
	/// Bring the output data up to date.  This should be called only
	/// when information is up to date.  Use the Update method if it is
	/// not known that the information is up to date.
	/// </summary>
	public virtual int UpdateData(int outputPort)
	{
		return vtkDemandDrivenPipeline_UpdateData_20(GetCppThis(), outputPort);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_UpdateDataObject_21(HandleRef pThis);

	/// <summary>
	/// Bring the output data object's existence up to date.  This does
	/// not actually produce data, but does create the data object that
	/// will store data produced during the UpdateData step.
	/// </summary>
	public virtual int UpdateDataObject()
	{
		return vtkDemandDrivenPipeline_UpdateDataObject_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_UpdateInformation_22(HandleRef pThis);

	/// <summary>
	/// Bring the output information up to date.
	/// </summary>
	public override int UpdateInformation()
	{
		return vtkDemandDrivenPipeline_UpdateInformation_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDemandDrivenPipeline_UpdatePipelineMTime_23(HandleRef pThis);

	/// <summary>
	/// Bring the PipelineMTime up to date.
	/// </summary>
	public virtual int UpdatePipelineMTime()
	{
		return vtkDemandDrivenPipeline_UpdatePipelineMTime_23(GetCppThis());
	}
}
