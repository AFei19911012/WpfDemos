using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompositeDataPipeline
/// </summary>
/// <remarks>
///    Executive supporting composite datasets.
///
/// vtkCompositeDataPipeline is an executive that supports the processing of
/// composite dataset. It supports algorithms that are aware of composite
/// dataset as well as those that are not. Type checking is performed at run
/// time. Algorithms that are not composite dataset-aware have to support
/// all dataset types contained in the composite dataset. The pipeline
/// execution can be summarized as follows:
///
/// * REQUEST_INFORMATION: The producers have to provide information about
/// the contents of the composite dataset in this pass.
/// Sources that can produce more than one piece (note that a piece is
/// different than a block; each piece consists of 0 or more blocks) should
/// set CAN_HANDLE_PIECE_REQUEST.
///
/// * REQUEST_UPDATE_EXTENT: This pass is identical to the one implemented
/// in vtkStreamingDemandDrivenPipeline
///
/// * REQUEST_DATA: This is where the algorithms execute. If the
/// vtkCompositeDataPipeline is assigned to a simple filter,
/// it will invoke the  vtkStreamingDemandDrivenPipeline passes in a loop,
/// passing a different block each time and will collect the results in a
/// composite dataset.
/// </remarks>
/// <seealso>
///
///  vtkCompositeDataSet
/// </seealso>
public class vtkCompositeDataPipeline : vtkStreamingDemandDrivenPipeline
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataPipeline";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositeDataPipeline()
	{
		MRClassNameKey = "class vtkCompositeDataPipeline";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataPipeline"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositeDataPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataPipeline New()
	{
		vtkCompositeDataPipeline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCompositeDataPipeline()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompositeDataPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCompositeDataPipeline_BLOCK_AMOUNT_OF_DETAIL_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// BLOCK_AMOUNT_OF_DETAIL is a key placed in the information about a multi-block
	/// dataset that indicates how complex the block is.  It is intended to work with
	/// multi-resolution streaming code.  For example in a multi-resolution dataset of
	/// points, this key might store the number of points.
	/// *** THIS IS AN EXPERIMENTAL FEATURE. IT MAY CHANGE WITHOUT NOTICE ***
	/// </summary>
	public static vtkInformationDoubleKey BLOCK_AMOUNT_OF_DETAIL()
	{
		vtkInformationDoubleKey vtkInformationDoubleKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataPipeline_BLOCK_AMOUNT_OF_DETAIL_01(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCompositeDataPipeline_COMPOSITE_DATA_META_DATA_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// COMPOSITE_DATA_META_DATA is a key placed in the output-port information by
	/// readers/sources producing composite datasets. This meta-data provides
	/// information about the structure of the composite dataset and things like
	/// data-bounds etc.
	/// *** THIS IS AN EXPERIMENTAL FEATURE. IT MAY CHANGE WITHOUT NOTICE ***
	/// </summary>
	public static vtkInformationObjectBaseKey COMPOSITE_DATA_META_DATA()
	{
		vtkInformationObjectBaseKey vtkInformationObjectBaseKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataPipeline_COMPOSITE_DATA_META_DATA_02(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseKey2 = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataPipeline_GetCompositeOutputData_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the data object stored with the DATA_OBJECT() in the
	/// output port
	/// </summary>
	public vtkDataObject GetCompositeOutputData(int port)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataPipeline_GetCompositeOutputData_03(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCompositeDataPipeline_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositeDataPipeline_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataPipeline_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositeDataPipeline_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataPipeline_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositeDataPipeline_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataPipeline_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositeDataPipeline_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataPipeline_LOAD_REQUESTED_BLOCKS_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// An integer key that indicates to the source to load all requested
	/// blocks specified in UPDATE_COMPOSITE_INDICES.
	/// </summary>
	public static vtkInformationIntegerKey LOAD_REQUESTED_BLOCKS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataPipeline_LOAD_REQUESTED_BLOCKS_08(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCompositeDataPipeline_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCompositeDataPipeline NewInstance()
	{
		vtkCompositeDataPipeline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataPipeline_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataPipeline_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataPipeline SafeDownCast(vtkObjectBase o)
	{
		vtkCompositeDataPipeline vtkCompositeDataPipeline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataPipeline_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataPipeline2 = (vtkCompositeDataPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataPipeline2.Register(null);
			}
		}
		return vtkCompositeDataPipeline2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataPipeline_UPDATE_COMPOSITE_INDICES_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// UPDATE_COMPOSITE_INDICES is a key placed in the request to request a set of
	/// composite indices from a reader/source producing composite dataset.
	/// Typically, the reader publishes its structure using
	/// COMPOSITE_DATA_META_DATA() and then the sink requests blocks of interest
	/// using UPDATE_COMPOSITE_INDICES().
	/// Note that UPDATE_COMPOSITE_INDICES has to be sorted vector with increasing
	/// indices.
	/// *** THIS IS AN EXPERIMENTAL FEATURE. IT MAY CHANGE WITHOUT NOTICE ***
	/// </summary>
	public static vtkInformationIntegerVectorKey UPDATE_COMPOSITE_INDICES()
	{
		vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataPipeline_UPDATE_COMPOSITE_INDICES_12(ref mteStatus, ref mteIndex, ref rawRefCount);
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
