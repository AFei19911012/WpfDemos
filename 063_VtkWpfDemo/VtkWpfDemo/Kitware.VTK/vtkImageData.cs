using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageData
/// </summary>
/// <remarks>
///    topologically and geometrically regular array of data
///
/// vtkImageData is a data object that is a concrete implementation of
/// vtkDataSet. vtkImageData represents a geometric structure that is
/// a topological and geometrical regular array of points. Examples include
/// volumes (voxel data) and pixmaps. This representation supports images
/// up to three dimensions. The image may also be oriented (see the
/// DirectionMatrices and related transformation methods). Note however,
/// that not all filters support oriented images.
///
/// </remarks>
/// <seealso>
///
/// vtkImageTransform
/// </seealso>
 [System.Runtime.Versioning.SupportedOSPlatform("windows")]
public class vtkImageData : vtkDataSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageData()
	{
		MRClassNameKey = "class vtkImageData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageData New()
	{
		vtkImageData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_AllocateScalars_01(HandleRef pThis, int dataType, int numComponents);

	/// <summary>
	/// Allocate the point scalars for this dataset. The data type determines
	/// the type of the array (VTK_FLOAT, VTK_INT etc.) where as numComponents
	/// determines its number of components.
	/// </summary>
	public virtual void AllocateScalars(int dataType, int numComponents)
	{
		vtkImageData_AllocateScalars_01(GetCppThis(), dataType, numComponents);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_AllocateScalars_02(HandleRef pThis, HandleRef pipeline_info);

	/// <summary>
	/// Allocate the point scalars for this dataset. The data type and the
	/// number of components of the array is determined by the meta-data in
	/// the pipeline information. This is usually produced by a reader/filter
	/// upstream in the pipeline.
	/// </summary>
	public virtual void AllocateScalars(vtkInformation pipeline_info)
	{
		vtkImageData_AllocateScalars_02(GetCppThis(), pipeline_info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_ComputeBounds_03(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override void ComputeBounds()
	{
		vtkImageData_ComputeBounds_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_ComputeCellId_04(HandleRef pThis, IntPtr ijk);

	/// <summary>
	/// Given a location in structured coordinates (i-j-k), return the cell id.
	/// </summary>
	public virtual long ComputeCellId(IntPtr ijk)
	{
		return vtkImageData_ComputeCellId_04(GetCppThis(), ijk);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_ComputeIndexToPhysicalMatrix_05(IntPtr origin, IntPtr spacing, IntPtr direction, IntPtr result);

	/// <summary>
	/// Convert coordinates from physical space (xyz) to index space (ijk).
	/// </summary>
	public static void ComputeIndexToPhysicalMatrix(IntPtr origin, IntPtr spacing, IntPtr direction, IntPtr result)
	{
		vtkImageData_ComputeIndexToPhysicalMatrix_05(origin, spacing, direction, result);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_ComputeInternalExtent_06(HandleRef pThis, IntPtr intExt, IntPtr tgtExt, IntPtr bnds);

	/// <summary>
	/// Given how many pixel are required on a side for boundary conditions (in
	/// bnds), the target extent to traverse, compute the internal extent (the
	/// extent for this ImageData that does not suffer from any boundary
	/// conditions) and place it in intExt
	/// </summary>
	public void ComputeInternalExtent(IntPtr intExt, IntPtr tgtExt, IntPtr bnds)
	{
		vtkImageData_ComputeInternalExtent_06(GetCppThis(), intExt, tgtExt, bnds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_ComputePointId_07(HandleRef pThis, IntPtr ijk);

	/// <summary>
	/// Given a location in structured coordinates (i-j-k), return the point id.
	/// </summary>
	public virtual long ComputePointId(IntPtr ijk)
	{
		return vtkImageData_ComputePointId_07(GetCppThis(), ijk);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_ComputeStructuredCoordinates_08(HandleRef pThis, IntPtr x, IntPtr ijk, IntPtr pcoords);

	/// <summary>
	/// Convenience function computes the structured coordinates for a point x[3].
	/// The voxel is specified by the array ijk[3], and the parametric coordinates
	/// in the cell are specified with pcoords[3]. The function returns a 0 if the
	/// point x is outside of the volume, and a 1 if inside the volume.
	/// </summary>
	public virtual int ComputeStructuredCoordinates(IntPtr x, IntPtr ijk, IntPtr pcoords)
	{
		return vtkImageData_ComputeStructuredCoordinates_08(GetCppThis(), x, ijk, pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_CopyAndCastFrom_09(HandleRef pThis, HandleRef inData, IntPtr extent);

	/// <summary>
	/// This method is passed a input and output region, and executes the filter
	/// algorithm to fill the output from the input.
	/// It just executes a switch statement to call the correct function for
	/// the regions data types.
	/// </summary>
	public virtual void CopyAndCastFrom(vtkImageData inData, IntPtr extent)
	{
		vtkImageData_CopyAndCastFrom_09(GetCppThis(), inData?.GetCppThis() ?? default(HandleRef), extent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_CopyAndCastFrom_10(HandleRef pThis, HandleRef inData, int x0, int x1, int y0, int y1, int z0, int z1);

	/// <summary>
	/// This method is passed a input and output region, and executes the filter
	/// algorithm to fill the output from the input.
	/// It just executes a switch statement to call the correct function for
	/// the regions data types.
	/// </summary>
	public virtual void CopyAndCastFrom(vtkImageData inData, int x0, int x1, int y0, int y1, int z0, int z1)
	{
		vtkImageData_CopyAndCastFrom_10(GetCppThis(), inData?.GetCppThis() ?? default(HandleRef), x0, x1, y0, y1, z0, z1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_CopyInformationFromPipeline_11(HandleRef pThis, HandleRef information);

	/// <summary>
	/// Override these to handle origin, spacing, scalar type, and scalar
	/// number of components.  See vtkDataObject for details.
	/// </summary>
	public override void CopyInformationFromPipeline(vtkInformation information)
	{
		vtkImageData_CopyInformationFromPipeline_11(GetCppThis(), information?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_CopyInformationToPipeline_12(HandleRef pThis, HandleRef information);

	/// <summary>
	/// Copy information from this data object to the pipeline information.
	/// This is used by the vtkTrivialProducer that is created when someone
	/// calls SetInputData() to connect the image to a pipeline.
	/// </summary>
	public override void CopyInformationToPipeline(vtkInformation information)
	{
		vtkImageData_CopyInformationToPipeline_12(GetCppThis(), information?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_CopyStructure_13(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Copy the geometric and topological structure of an input image data
	/// object.
	/// </summary>
	public override void CopyStructure(vtkDataSet ds)
	{
		vtkImageData_CopyStructure_13(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_Crop_14(HandleRef pThis, IntPtr updateExtent);

	/// <summary>
	/// Reallocates and copies to set the Extent to updateExtent.
	/// This is used internally when the exact extent is requested,
	/// and the source generated more than the update extent.
	/// </summary>
	public override void Crop(IntPtr updateExtent)
	{
		vtkImageData_Crop_14(GetCppThis(), updateExtent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_DeepCopy_15(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkImageData_DeepCopy_15(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_ExtendedNew_16(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkImageData ExtendedNew()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_ExtendedNew_16(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_FindAndGetCell_17(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_FindAndGetCell_17(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_FindCell_18(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkImageData_FindCell_18(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_FindCell_19(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkImageData_FindCell_19(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), gencell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_FindPoint_20(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public new virtual long FindPoint(double x, double y, double z)
	{
		return vtkImageData_FindPoint_20(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_FindPoint_21(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override long FindPoint(IntPtr x)
	{
		return vtkImageData_FindPoint_21(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkImageData_GetActualMemorySize_22(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kibibytes (1024 bytes). This number
	/// is valid only after the pipeline has updated. The memory size
	/// returned is guaranteed to be greater than or equal to the
	/// memory required to represent the data (e.g., extra space in
	/// arrays, etc. are not included in the return value). THIS METHOD
	/// IS THREAD SAFE.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkImageData_GetActualMemorySize_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetArrayIncrements_23(HandleRef pThis, HandleRef array, IntPtr increments);

	/// <summary>
	/// Since various arrays have different number of components,
	/// the will have different increments.
	/// </summary>
	public void GetArrayIncrements(vtkDataArray array, IntPtr increments)
	{
		vtkImageData_GetArrayIncrements_23(GetCppThis(), array?.GetCppThis() ?? default(HandleRef), increments);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetArrayPointer_24(HandleRef pThis, HandleRef array, IntPtr coordinates);

	/// <summary>
	/// These are convenience methods for getting a pointer
	/// from any filed array.  It is a start at expanding image filters
	/// to process any array (not just scalars).
	/// </summary>
	public IntPtr GetArrayPointer(vtkDataArray array, IntPtr coordinates)
	{
		return vtkImageData_GetArrayPointer_24(GetCppThis(), array?.GetCppThis() ?? default(HandleRef), coordinates);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetArrayPointerForExtent_25(HandleRef pThis, HandleRef array, IntPtr extent);

	/// <summary>
	/// These are convenience methods for getting a pointer
	/// from any filed array.  It is a start at expanding image filters
	/// to process any array (not just scalars).
	/// </summary>
	public IntPtr GetArrayPointerForExtent(vtkDataArray array, IntPtr extent)
	{
		return vtkImageData_GetArrayPointerForExtent_25(GetCppThis(), array?.GetCppThis() ?? default(HandleRef), extent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetAxisUpdateExtent_26(HandleRef pThis, int axis, ref int min, ref int max, IntPtr updateExtent);

	/// <summary>
	/// Set / Get the extent on just one axis
	/// </summary>
	public virtual void GetAxisUpdateExtent(int axis, ref int min, ref int max, IntPtr updateExtent)
	{
		vtkImageData_GetAxisUpdateExtent_26(GetCppThis(), axis, ref min, ref max, updateExtent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetCell_27(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override vtkCell GetCell(long cellId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_GetCell_27(GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetCell_28(HandleRef pThis, int i, int j, int k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override vtkCell GetCell(int i, int j, int k)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_GetCell_28(GetCppThis(), i, j, k, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetCell_29(HandleRef pThis, long cellId, HandleRef cell);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override void GetCell(long cellId, vtkGenericCell cell)
	{
		vtkImageData_GetCell_29(GetCppThis(), cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetCellBounds_30(HandleRef pThis, long cellId, IntPtr bounds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override void GetCellBounds(long cellId, IntPtr bounds)
	{
		vtkImageData_GetCellBounds_30(GetCppThis(), cellId, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetCellDims_31(HandleRef pThis, IntPtr cellDims);

	/// <summary>
	/// Given the node dimensions of this grid instance, this method computes the
	/// node dimensions. The value in each dimension can will have a lowest value
	/// of "1" such that computing the total number of cells can be achieved by
	/// simply by cellDims[0]*cellDims[1]*cellDims[2].
	/// </summary>
	public void GetCellDims(IntPtr cellDims)
	{
		vtkImageData_GetCellDims_31(GetCppThis(), cellDims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetCellNeighbors_32(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
	{
		vtkImageData_GetCellNeighbors_32(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetCellNeighbors_33(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr seedLoc);

	/// <summary>
	/// Get cell neighbors around cell located at `seedloc`, except cell of id `cellId`.
	///
	/// @warning `seedloc` is the position in the grid with the origin shifted to (0, 0, 0).
	/// This is because the backend of this method is shared with `vtkRectilinearGrid` and
	/// `vtkStructuredGrid`.
	/// </summary>
	public void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr seedLoc)
	{
		vtkImageData_GetCellNeighbors_33(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), seedLoc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetCellPoints_34(HandleRef pThis, long cellId, HandleRef ptIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override void GetCellPoints(long cellId, vtkIdList ptIds)
	{
		vtkImageData_GetCellPoints_34(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_GetCellSize_35(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override long GetCellSize(long cellId)
	{
		return vtkImageData_GetCellSize_35(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetCellType_36(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override int GetCellType(long cellId)
	{
		return vtkImageData_GetCellType_36(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetContinuousIncrements_37(HandleRef pThis, IntPtr extent, ref long incX, ref long incY, ref long incZ);

	/// <summary>
	/// Different ways to get the increments for moving around the data.
	/// incX is always returned with 0.  incY is returned with the
	/// increment needed to move from the end of one X scanline of data
	/// to the start of the next line.  incZ is filled in with the
	/// increment needed to move from the end of one image to the start
	/// of the next.  The proper way to use these values is to for a loop
	/// over Z, Y, X, C, incrementing the pointer by 1 after each
	/// component.  When the end of the component is reached, the pointer
	/// is set to the beginning of the next pixel, thus incX is properly set to 0.
	/// The first form of GetContinuousIncrements uses the active scalar field
	/// while the second form allows the scalar array to be passed in.
	/// </summary>
	public virtual void GetContinuousIncrements(IntPtr extent, ref long incX, ref long incY, ref long incZ)
	{
		vtkImageData_GetContinuousIncrements_37(GetCppThis(), extent, ref incX, ref incY, ref incZ);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetContinuousIncrements_38(HandleRef pThis, HandleRef scalars, IntPtr extent, ref long incX, ref long incY, ref long incZ);

	/// <summary>
	/// Different ways to get the increments for moving around the data.
	/// incX is always returned with 0.  incY is returned with the
	/// increment needed to move from the end of one X scanline of data
	/// to the start of the next line.  incZ is filled in with the
	/// increment needed to move from the end of one image to the start
	/// of the next.  The proper way to use these values is to for a loop
	/// over Z, Y, X, C, incrementing the pointer by 1 after each
	/// component.  When the end of the component is reached, the pointer
	/// is set to the beginning of the next pixel, thus incX is properly set to 0.
	/// The first form of GetContinuousIncrements uses the active scalar field
	/// while the second form allows the scalar array to be passed in.
	/// </summary>
	public virtual void GetContinuousIncrements(vtkDataArray scalars, IntPtr extent, ref long incX, ref long incY, ref long incZ)
	{
		vtkImageData_GetContinuousIncrements_38(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), extent, ref incX, ref incY, ref incZ);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetData_39(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkImageData GetData(vtkInformation info)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_GetData_39(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetData_40(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkImageData GetData(vtkInformationVector v, int i)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_GetData_40(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetDataDimension_41(HandleRef pThis);

	/// <summary>
	/// Return the dimensionality of the data.
	/// </summary>
	public virtual int GetDataDimension()
	{
		return vtkImageData_GetDataDimension_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetDataObjectType_42(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkImageData_GetDataObjectType_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetDimensions_43(HandleRef pThis);

	/// <summary>
	/// Get dimensions of this structured points dataset.
	/// It is the number of points on each axis.
	/// Dimensions are computed from Extents during this call.
	/// \warning Non thread-safe, use second signature if you want it to be.
	/// </summary>
	public virtual int[] GetDimensions()
	{
		IntPtr intPtr = vtkImageData_GetDimensions_43(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetDimensions_44(HandleRef pThis, IntPtr dims);

	/// <summary>
	/// Get dimensions of this structured points dataset.
	/// It is the number of points on each axis.
	/// This method is thread-safe.
	/// \warning The Dimensions member variable is not updated during this call.
	/// </summary>
	public virtual void GetDimensions(IntPtr dims)
	{
		vtkImageData_GetDimensions_44(GetCppThis(), dims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetDirectionMatrix_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the direction transform of the dataset. The direction matrix is
	/// a 3x3 transformation matrix supporting scaling and rotation.
	/// </summary>
	public virtual vtkMatrix3x3 GetDirectionMatrix()
	{
		vtkMatrix3x3 vtkMatrix3x4 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_GetDirectionMatrix_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix3x4 = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix3x4.Register(null);
			}
		}
		return vtkMatrix3x4;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetExtent_46(HandleRef pThis);

	/// <summary>
	/// Set/Get the extent. On each axis, the extent is defined by the index
	/// of the first point and the index of the last point.  The extent should
	/// be set before the "Scalars" are set or allocated.  The Extent is
	/// stored in the order (X, Y, Z).
	/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
	/// extent of the origin.
	/// The first point (the one with Id=0) is at extent
	/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
	/// data starts at Id=0.
	/// </summary>
	public virtual int[] GetExtent()
	{
		IntPtr intPtr = vtkImageData_GetExtent_46(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetExtent_47(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set/Get the extent. On each axis, the extent is defined by the index
	/// of the first point and the index of the last point.  The extent should
	/// be set before the "Scalars" are set or allocated.  The Extent is
	/// stored in the order (X, Y, Z).
	/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
	/// extent of the origin.
	/// The first point (the one with Id=0) is at extent
	/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
	/// data starts at Id=0.
	/// </summary>
	public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageData_GetExtent_47(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetExtent_48(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the extent. On each axis, the extent is defined by the index
	/// of the first point and the index of the last point.  The extent should
	/// be set before the "Scalars" are set or allocated.  The Extent is
	/// stored in the order (X, Y, Z).
	/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
	/// extent of the origin.
	/// The first point (the one with Id=0) is at extent
	/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
	/// data starts at Id=0.
	/// </summary>
	public virtual void GetExtent(IntPtr _arg)
	{
		vtkImageData_GetExtent_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetExtentType_49(HandleRef pThis);

	/// <summary>
	/// The extent type is a 3D extent
	/// </summary>
	public override int GetExtentType()
	{
		return vtkImageData_GetExtentType_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetIncrements_50(HandleRef pThis);

	/// <summary>
	/// Different ways to get the increments for moving around the data.
	/// GetIncrements() calls ComputeIncrements() to ensure the increments are
	/// up to date.  The first three methods compute the increments based on the
	/// active scalar field while the next three, the scalar field is passed in.
	///
	/// Note that all methods which do not have the increments passed in are not
	/// thread-safe. When working on a given `vtkImageData` instance on multiple
	/// threads, each thread should use the `inc*` overloads to compute the
	/// increments to avoid racing with other threads.
	/// </summary>
	public virtual IntPtr GetIncrements()
	{
		return vtkImageData_GetIncrements_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetIncrements_51(HandleRef pThis, ref long incX, ref long incY, ref long incZ);

	/// <summary>
	/// Different ways to get the increments for moving around the data.
	/// GetIncrements() calls ComputeIncrements() to ensure the increments are
	/// up to date.  The first three methods compute the increments based on the
	/// active scalar field while the next three, the scalar field is passed in.
	///
	/// Note that all methods which do not have the increments passed in are not
	/// thread-safe. When working on a given `vtkImageData` instance on multiple
	/// threads, each thread should use the `inc*` overloads to compute the
	/// increments to avoid racing with other threads.
	/// </summary>
	public virtual void GetIncrements(ref long incX, ref long incY, ref long incZ)
	{
		vtkImageData_GetIncrements_51(GetCppThis(), ref incX, ref incY, ref incZ);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetIncrements_52(HandleRef pThis, IntPtr inc);

	/// <summary>
	/// Different ways to get the increments for moving around the data.
	/// GetIncrements() calls ComputeIncrements() to ensure the increments are
	/// up to date.  The first three methods compute the increments based on the
	/// active scalar field while the next three, the scalar field is passed in.
	///
	/// Note that all methods which do not have the increments passed in are not
	/// thread-safe. When working on a given `vtkImageData` instance on multiple
	/// threads, each thread should use the `inc*` overloads to compute the
	/// increments to avoid racing with other threads.
	/// </summary>
	public virtual void GetIncrements(IntPtr inc)
	{
		vtkImageData_GetIncrements_52(GetCppThis(), inc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetIncrements_53(HandleRef pThis, HandleRef scalars);

	/// <summary>
	/// Different ways to get the increments for moving around the data.
	/// GetIncrements() calls ComputeIncrements() to ensure the increments are
	/// up to date.  The first three methods compute the increments based on the
	/// active scalar field while the next three, the scalar field is passed in.
	///
	/// Note that all methods which do not have the increments passed in are not
	/// thread-safe. When working on a given `vtkImageData` instance on multiple
	/// threads, each thread should use the `inc*` overloads to compute the
	/// increments to avoid racing with other threads.
	/// </summary>
	public virtual IntPtr GetIncrements(vtkDataArray scalars)
	{
		return vtkImageData_GetIncrements_53(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetIncrements_54(HandleRef pThis, HandleRef scalars, ref long incX, ref long incY, ref long incZ);

	/// <summary>
	/// Different ways to get the increments for moving around the data.
	/// GetIncrements() calls ComputeIncrements() to ensure the increments are
	/// up to date.  The first three methods compute the increments based on the
	/// active scalar field while the next three, the scalar field is passed in.
	///
	/// Note that all methods which do not have the increments passed in are not
	/// thread-safe. When working on a given `vtkImageData` instance on multiple
	/// threads, each thread should use the `inc*` overloads to compute the
	/// increments to avoid racing with other threads.
	/// </summary>
	public virtual void GetIncrements(vtkDataArray scalars, ref long incX, ref long incY, ref long incZ)
	{
		vtkImageData_GetIncrements_54(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), ref incX, ref incY, ref incZ);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetIncrements_55(HandleRef pThis, HandleRef scalars, IntPtr inc);

	/// <summary>
	/// Different ways to get the increments for moving around the data.
	/// GetIncrements() calls ComputeIncrements() to ensure the increments are
	/// up to date.  The first three methods compute the increments based on the
	/// active scalar field while the next three, the scalar field is passed in.
	///
	/// Note that all methods which do not have the increments passed in are not
	/// thread-safe. When working on a given `vtkImageData` instance on multiple
	/// threads, each thread should use the `inc*` overloads to compute the
	/// increments to avoid racing with other threads.
	/// </summary>
	public virtual void GetIncrements(vtkDataArray scalars, IntPtr inc)
	{
		vtkImageData_GetIncrements_55(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), inc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetIndexToPhysicalMatrix_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the transformation matrix from the index space to the physical space
	/// coordinate system of the dataset. The transform is a 4 by 4 matrix.
	/// </summary>
	public virtual vtkMatrix4x4 GetIndexToPhysicalMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_GetIndexToPhysicalMatrix_56(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetMaxCellSize_57(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkImageData_GetMaxCellSize_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_GetNumberOfCells_58(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkImageData_GetNumberOfCells_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_GetNumberOfGenerationsFromBase_59(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageData_GetNumberOfGenerationsFromBase_59(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_GetNumberOfGenerationsFromBaseType_60(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageData_GetNumberOfGenerationsFromBaseType_60(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_GetNumberOfPoints_61(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override long GetNumberOfPoints()
	{
		return vtkImageData_GetNumberOfPoints_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetNumberOfScalarComponents_62(HandleRef meta_data);

	/// <summary>
	/// Set/Get the number of scalar components for points. As with the
	/// SetScalarType method this is setting pipeline info.
	/// </summary>
	public static int GetNumberOfScalarComponents(vtkInformation meta_data)
	{
		return vtkImageData_GetNumberOfScalarComponents_62(meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetNumberOfScalarComponents_63(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of scalar components for points. As with the
	/// SetScalarType method this is setting pipeline info.
	/// </summary>
	public int GetNumberOfScalarComponents()
	{
		return vtkImageData_GetNumberOfScalarComponents_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetOrigin_64(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the dataset. The origin is the position in world
	/// coordinates of the point of extent (0,0,0). This point does not have to be
	/// part of the dataset, in other words, the dataset extent does not have to
	/// start at (0,0,0) and the origin can be outside of the dataset bounding
	/// box.
	/// The origin plus spacing determine the position in space of the points.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkImageData_GetOrigin_64(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetOrigin_65(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the origin of the dataset. The origin is the position in world
	/// coordinates of the point of extent (0,0,0). This point does not have to be
	/// part of the dataset, in other words, the dataset extent does not have to
	/// start at (0,0,0) and the origin can be outside of the dataset bounding
	/// box.
	/// The origin plus spacing determine the position in space of the points.
	/// </summary>
	public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageData_GetOrigin_65(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetOrigin_66(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the dataset. The origin is the position in world
	/// coordinates of the point of extent (0,0,0). This point does not have to be
	/// part of the dataset, in other words, the dataset extent does not have to
	/// start at (0,0,0) and the origin can be outside of the dataset bounding
	/// box.
	/// The origin plus spacing determine the position in space of the points.
	/// </summary>
	public virtual void GetOrigin(IntPtr _arg)
	{
		vtkImageData_GetOrigin_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetPhysicalToIndexMatrix_67(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the transformation matrix from the physical space to the index space
	/// coordinate system of the dataset. The transform is a 4 by 4 matrix.
	/// </summary>
	public virtual vtkMatrix4x4 GetPhysicalToIndexMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_GetPhysicalToIndexMatrix_67(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetPoint_68(HandleRef pThis, long ptId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override double[] GetPoint(long ptId)
	{
		IntPtr intPtr = vtkImageData_GetPoint_68(GetCppThis(), ptId);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetPoint_69(HandleRef pThis, long id, IntPtr x);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override void GetPoint(long id, IntPtr x)
	{
		vtkImageData_GetPoint_69(GetCppThis(), id, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetPointCells_70(HandleRef pThis, long ptId, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// \warning If GetCell(int,int,int) gets overridden in a subclass, it is
	/// necessary to override GetCell(vtkIdType) in that class as well since
	/// vtkImageData::GetCell(vtkIdType) will always call
	/// vkImageData::GetCell(int,int,int)
	/// </summary>
	public override void GetPointCells(long ptId, vtkIdList cellIds)
	{
		vtkImageData_GetPointCells_70(GetCppThis(), ptId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetPointGradient_71(HandleRef pThis, int i, int j, int k, HandleRef s, IntPtr g);

	/// <summary>
	/// Given structured coordinates (i,j,k) for a point in a structured point
	/// dataset, compute the gradient vector from the scalar data at that point.
	/// The scalars s are the scalars from which the gradient is to be computed.
	/// This method will treat structured point datasets of any dimension.
	/// </summary>
	public virtual void GetPointGradient(int i, int j, int k, vtkDataArray s, IntPtr g)
	{
		vtkImageData_GetPointGradient_71(GetCppThis(), i, j, k, s?.GetCppThis() ?? default(HandleRef), g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageData_GetScalarComponentAsDouble_72(HandleRef pThis, int x, int y, int z, int component);

	/// <summary>
	/// For access to data from wrappers
	/// </summary>
	public virtual double GetScalarComponentAsDouble(int x, int y, int z, int component)
	{
		return vtkImageData_GetScalarComponentAsDouble_72(GetCppThis(), x, y, z, component);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkImageData_GetScalarComponentAsFloat_73(HandleRef pThis, int x, int y, int z, int component);

	/// <summary>
	/// For access to data from wrappers
	/// </summary>
	public virtual float GetScalarComponentAsFloat(int x, int y, int z, int component)
	{
		return vtkImageData_GetScalarComponentAsFloat_73(GetCppThis(), x, y, z, component);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_GetScalarIndex_74(HandleRef pThis, IntPtr coordinates);

	/// <summary>
	/// Access the index for the scalar data
	/// </summary>
	public virtual long GetScalarIndex(IntPtr coordinates)
	{
		return vtkImageData_GetScalarIndex_74(GetCppThis(), coordinates);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_GetScalarIndex_75(HandleRef pThis, int x, int y, int z);

	/// <summary>
	/// Access the index for the scalar data
	/// </summary>
	public virtual long GetScalarIndex(int x, int y, int z)
	{
		return vtkImageData_GetScalarIndex_75(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_GetScalarIndexForExtent_76(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Access the index for the scalar data
	/// </summary>
	public virtual long GetScalarIndexForExtent(IntPtr extent)
	{
		return vtkImageData_GetScalarIndexForExtent_76(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetScalarPointer_77(HandleRef pThis, IntPtr coordinates);

	/// <summary>
	/// Access the native pointer for the scalar data
	/// </summary>
	public virtual IntPtr GetScalarPointer(IntPtr coordinates)
	{
		return vtkImageData_GetScalarPointer_77(GetCppThis(), coordinates);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetScalarPointer_78(HandleRef pThis, int x, int y, int z);

	/// <summary>
	/// Access the native pointer for the scalar data
	/// </summary>
	public virtual IntPtr GetScalarPointer(int x, int y, int z)
	{
		return vtkImageData_GetScalarPointer_78(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetScalarPointer_79(HandleRef pThis);

	/// <summary>
	/// Access the native pointer for the scalar data
	/// </summary>
	public virtual IntPtr GetScalarPointer()
	{
		return vtkImageData_GetScalarPointer_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetScalarPointerForExtent_80(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Access the native pointer for the scalar data
	/// </summary>
	public virtual IntPtr GetScalarPointerForExtent(IntPtr extent)
	{
		return vtkImageData_GetScalarPointerForExtent_80(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetScalarSize_81(HandleRef pThis, HandleRef meta_data);

	/// <summary>
	/// Get the size of the scalar type in bytes.
	/// </summary>
	public virtual int GetScalarSize(vtkInformation meta_data)
	{
		return vtkImageData_GetScalarSize_81(GetCppThis(), meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetScalarSize_82(HandleRef pThis);

	/// <summary>
	/// Get the size of the scalar type in bytes.
	/// </summary>
	public virtual int GetScalarSize()
	{
		return vtkImageData_GetScalarSize_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetScalarType_83(HandleRef meta_data);

	/// <summary>
	/// Convert a plane from physical to a continuous index. The plane is represented as
	/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
	/// </summary>
	public static int GetScalarType(vtkInformation meta_data)
	{
		return vtkImageData_GetScalarType_83(meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_GetScalarType_84(HandleRef pThis);

	/// <summary>
	/// Convert a plane from physical to a continuous index. The plane is represented as
	/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
	/// </summary>
	public int GetScalarType()
	{
		return vtkImageData_GetScalarType_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetScalarTypeAsString_85(HandleRef pThis);

	/// <summary>
	/// Convert a plane from physical to a continuous index. The plane is represented as
	/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
	/// </summary>
	public string GetScalarTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageData_GetScalarTypeAsString_85(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageData_GetScalarTypeMax_86(HandleRef pThis, HandleRef meta_data);

	/// <summary>
	/// These returns the minimum and maximum values the ScalarType can hold
	/// without overflowing.
	/// </summary>
	public virtual double GetScalarTypeMax(vtkInformation meta_data)
	{
		return vtkImageData_GetScalarTypeMax_86(GetCppThis(), meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageData_GetScalarTypeMax_87(HandleRef pThis);

	/// <summary>
	/// These returns the minimum and maximum values the ScalarType can hold
	/// without overflowing.
	/// </summary>
	public virtual double GetScalarTypeMax()
	{
		return vtkImageData_GetScalarTypeMax_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageData_GetScalarTypeMin_88(HandleRef pThis, HandleRef meta_data);

	/// <summary>
	/// These returns the minimum and maximum values the ScalarType can hold
	/// without overflowing.
	/// </summary>
	public virtual double GetScalarTypeMin(vtkInformation meta_data)
	{
		return vtkImageData_GetScalarTypeMin_88(GetCppThis(), meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageData_GetScalarTypeMin_89(HandleRef pThis);

	/// <summary>
	/// These returns the minimum and maximum values the ScalarType can hold
	/// without overflowing.
	/// </summary>
	public virtual double GetScalarTypeMin()
	{
		return vtkImageData_GetScalarTypeMin_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_GetSpacing_90(HandleRef pThis);

	/// <summary>
	/// Set the spacing (width,height,length) of the cubical cells that
	/// compose the data set.
	/// </summary>
	public virtual double[] GetSpacing()
	{
		IntPtr intPtr = vtkImageData_GetSpacing_90(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetSpacing_91(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the spacing (width,height,length) of the cubical cells that
	/// compose the data set.
	/// </summary>
	public virtual void GetSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageData_GetSpacing_91(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetSpacing_92(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the spacing (width,height,length) of the cubical cells that
	/// compose the data set.
	/// </summary>
	public virtual void GetSpacing(IntPtr _arg)
	{
		vtkImageData_GetSpacing_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageData_GetTupleIndex_93(HandleRef pThis, HandleRef array, IntPtr coordinates);

	/// <summary>
	/// Given a data array and a coordinate, return the index of the tuple in the
	/// array corresponding to that coordinate.
	///
	/// This method is analogous to GetArrayPointer(), but it conforms to the API
	/// of vtkGenericDataArray.
	/// </summary>
	public long GetTupleIndex(vtkDataArray array, IntPtr coordinates)
	{
		return vtkImageData_GetTupleIndex_93(GetCppThis(), array?.GetCppThis() ?? default(HandleRef), coordinates);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_GetVoxelGradient_94(HandleRef pThis, int i, int j, int k, HandleRef s, HandleRef g);

	/// <summary>
	/// Given structured coordinates (i,j,k) for a voxel cell, compute the eight
	/// gradient values for the voxel corners. The order in which the gradient
	/// vectors are arranged corresponds to the ordering of the voxel points.
	/// Gradient vector is computed by central differences (except on edges of
	/// volume where forward difference is used). The scalars s are the scalars
	/// from which the gradient is to be computed. This method will treat
	/// only 3D structured point datasets (i.e., volumes).
	/// </summary>
	public virtual void GetVoxelGradient(int i, int j, int k, vtkDataArray s, vtkDataArray g)
	{
		vtkImageData_GetVoxelGradient_94(GetCppThis(), i, j, k, s?.GetCppThis() ?? default(HandleRef), g?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageData_HasAnyBlankCells_95(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there is any visibility constraint on the cells,
	/// 0 otherwise.
	/// </summary>
	public override bool HasAnyBlankCells()
	{
		return (vtkImageData_HasAnyBlankCells_95(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageData_HasAnyBlankPoints_96(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there is any visibility constraint on the points,
	/// 0 otherwise.
	/// </summary>
	public override bool HasAnyBlankPoints()
	{
		return (vtkImageData_HasAnyBlankPoints_96(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageData_HasNumberOfScalarComponents_97(HandleRef meta_data);

	/// <summary>
	/// Set/Get the number of scalar components for points. As with the
	/// SetScalarType method this is setting pipeline info.
	/// </summary>
	public static bool HasNumberOfScalarComponents(vtkInformation meta_data)
	{
		return (vtkImageData_HasNumberOfScalarComponents_97(meta_data?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageData_HasScalarType_98(HandleRef meta_data);

	/// <summary>
	/// Convert a plane from physical to a continuous index. The plane is represented as
	/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
	/// </summary>
	public static bool HasScalarType(vtkInformation meta_data)
	{
		return (vtkImageData_HasScalarType_98(meta_data?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_Initialize_99(HandleRef pThis);

	/// <summary>
	/// Restore data object to initial state.
	/// </summary>
	public override void Initialize()
	{
		vtkImageData_Initialize_99(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_IsA_100(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageData_IsA_100(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageData_IsCellVisible_101(HandleRef pThis, long cellId);

	/// <summary>
	/// Return non-zero value if specified point is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public byte IsCellVisible(long cellId)
	{
		return vtkImageData_IsCellVisible_101(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageData_IsPointVisible_102(HandleRef pThis, long ptId);

	/// <summary>
	/// Return non-zero value if specified point is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public byte IsPointVisible(long ptId)
	{
		return vtkImageData_IsPointVisible_102(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageData_IsTypeOf_103(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageData_IsTypeOf_103(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_NewInstance_105(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageData NewInstance()
	{
		vtkImageData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_NewInstance_105(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_PrepareForNewData_106(HandleRef pThis);

	/// <summary>
	/// make the output data ready for new data to be inserted. For most
	/// objects we just call Initialize. But for image data we leave the old
	/// data in case the memory can be reused.
	/// </summary>
	public override void PrepareForNewData()
	{
		vtkImageData_PrepareForNewData_106(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageData_SafeDownCast_107(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageData SafeDownCast(vtkObjectBase o)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageData_SafeDownCast_107(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetAxisUpdateExtent_108(HandleRef pThis, int axis, int min, int max, IntPtr updateExtent, IntPtr axisUpdateExtent);

	/// <summary>
	/// Set / Get the extent on just one axis
	/// </summary>
	public virtual void SetAxisUpdateExtent(int axis, int min, int max, IntPtr updateExtent, IntPtr axisUpdateExtent)
	{
		vtkImageData_SetAxisUpdateExtent_108(GetCppThis(), axis, min, max, updateExtent, axisUpdateExtent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetDimensions_109(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Same as SetExtent(0, i-1, 0, j-1, 0, k-1)
	/// </summary>
	public virtual void SetDimensions(int i, int j, int k)
	{
		vtkImageData_SetDimensions_109(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetDimensions_110(HandleRef pThis, IntPtr dims);

	/// <summary>
	/// Same as SetExtent(0, dims[0]-1, 0, dims[1]-1, 0, dims[2]-1)
	/// </summary>
	public virtual void SetDimensions(IntPtr dims)
	{
		vtkImageData_SetDimensions_110(GetCppThis(), dims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetDirectionMatrix_111(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Set/Get the direction transform of the dataset. The direction matrix is
	/// a 3x3 transformation matrix supporting scaling and rotation.
	/// </summary>
	public virtual void SetDirectionMatrix(vtkMatrix3x3 m)
	{
		vtkImageData_SetDirectionMatrix_111(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetDirectionMatrix_112(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Set/Get the direction transform of the dataset. The direction matrix is
	/// a 3x3 transformation matrix supporting scaling and rotation.
	/// </summary>
	public virtual void SetDirectionMatrix(IntPtr elements)
	{
		vtkImageData_SetDirectionMatrix_112(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetDirectionMatrix_113(HandleRef pThis, double e00, double e01, double e02, double e10, double e11, double e12, double e20, double e21, double e22);

	/// <summary>
	/// Set/Get the direction transform of the dataset. The direction matrix is
	/// a 3x3 transformation matrix supporting scaling and rotation.
	/// </summary>
	public virtual void SetDirectionMatrix(double e00, double e01, double e02, double e10, double e11, double e12, double e20, double e21, double e22)
	{
		vtkImageData_SetDirectionMatrix_113(GetCppThis(), e00, e01, e02, e10, e11, e12, e20, e21, e22);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetExtent_114(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set/Get the extent. On each axis, the extent is defined by the index
	/// of the first point and the index of the last point.  The extent should
	/// be set before the "Scalars" are set or allocated.  The Extent is
	/// stored in the order (X, Y, Z).
	/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
	/// extent of the origin.
	/// The first point (the one with Id=0) is at extent
	/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
	/// data starts at Id=0.
	/// </summary>
	public virtual void SetExtent(IntPtr extent)
	{
		vtkImageData_SetExtent_114(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetExtent_115(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

	/// <summary>
	/// Set/Get the extent. On each axis, the extent is defined by the index
	/// of the first point and the index of the last point.  The extent should
	/// be set before the "Scalars" are set or allocated.  The Extent is
	/// stored in the order (X, Y, Z).
	/// The dataset extent does not have to start at (0,0,0). (0,0,0) is just the
	/// extent of the origin.
	/// The first point (the one with Id=0) is at extent
	/// (Extent[0],Extent[2],Extent[4]). As for any dataset, a data array on point
	/// data starts at Id=0.
	/// </summary>
	public virtual void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
	{
		vtkImageData_SetExtent_115(GetCppThis(), x1, x2, y1, y2, z1, z2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetNumberOfScalarComponents_116(int n, HandleRef meta_data);

	/// <summary>
	/// Set/Get the number of scalar components for points. As with the
	/// SetScalarType method this is setting pipeline info.
	/// </summary>
	public static void SetNumberOfScalarComponents(int n, vtkInformation meta_data)
	{
		vtkImageData_SetNumberOfScalarComponents_116(n, meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetOrigin_117(HandleRef pThis, double i, double j, double k);

	/// <summary>
	/// Set/Get the origin of the dataset. The origin is the position in world
	/// coordinates of the point of extent (0,0,0). This point does not have to be
	/// part of the dataset, in other words, the dataset extent does not have to
	/// start at (0,0,0) and the origin can be outside of the dataset bounding
	/// box.
	/// The origin plus spacing determine the position in space of the points.
	/// </summary>
	public virtual void SetOrigin(double i, double j, double k)
	{
		vtkImageData_SetOrigin_117(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetOrigin_118(HandleRef pThis, IntPtr ijk);

	/// <summary>
	/// Set/Get the origin of the dataset. The origin is the position in world
	/// coordinates of the point of extent (0,0,0). This point does not have to be
	/// part of the dataset, in other words, the dataset extent does not have to
	/// start at (0,0,0) and the origin can be outside of the dataset bounding
	/// box.
	/// The origin plus spacing determine the position in space of the points.
	/// </summary>
	public virtual void SetOrigin(IntPtr ijk)
	{
		vtkImageData_SetOrigin_118(GetCppThis(), ijk);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetScalarComponentFromDouble_119(HandleRef pThis, int x, int y, int z, int component, double v);

	/// <summary>
	/// For access to data from wrappers
	/// </summary>
	public virtual void SetScalarComponentFromDouble(int x, int y, int z, int component, double v)
	{
		vtkImageData_SetScalarComponentFromDouble_119(GetCppThis(), x, y, z, component, v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetScalarComponentFromFloat_120(HandleRef pThis, int x, int y, int z, int component, float v);

	/// <summary>
	/// For access to data from wrappers
	/// </summary>
	public virtual void SetScalarComponentFromFloat(int x, int y, int z, int component, float v)
	{
		vtkImageData_SetScalarComponentFromFloat_120(GetCppThis(), x, y, z, component, v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetScalarType_121(int arg0, HandleRef meta_data);

	/// <summary>
	/// Convert a plane from physical to a continuous index. The plane is represented as
	/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
	/// </summary>
	public static void SetScalarType(int arg0, vtkInformation meta_data)
	{
		vtkImageData_SetScalarType_121(arg0, meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetSpacing_122(HandleRef pThis, double i, double j, double k);

	/// <summary>
	/// Set the spacing (width,height,length) of the cubical cells that
	/// compose the data set.
	/// </summary>
	public virtual void SetSpacing(double i, double j, double k)
	{
		vtkImageData_SetSpacing_122(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_SetSpacing_123(HandleRef pThis, IntPtr ijk);

	/// <summary>
	/// Set the spacing (width,height,length) of the cubical cells that
	/// compose the data set.
	/// </summary>
	public virtual void SetSpacing(IntPtr ijk)
	{
		vtkImageData_SetSpacing_123(GetCppThis(), ijk);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_ShallowCopy_124(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkImageData_ShallowCopy_124(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_TransformContinuousIndexToPhysicalPoint_125(HandleRef pThis, double i, double j, double k, IntPtr xyz);

	/// <summary>
	/// Convert coordinates from index space (ijk) to physical space (xyz).
	/// </summary>
	public virtual void TransformContinuousIndexToPhysicalPoint(double i, double j, double k, IntPtr xyz)
	{
		vtkImageData_TransformContinuousIndexToPhysicalPoint_125(GetCppThis(), i, j, k, xyz);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_TransformContinuousIndexToPhysicalPoint_126(HandleRef pThis, IntPtr ijk, IntPtr xyz);

	/// <summary>
	/// Convert coordinates from index space (ijk) to physical space (xyz).
	/// </summary>
	public virtual void TransformContinuousIndexToPhysicalPoint(IntPtr ijk, IntPtr xyz)
	{
		vtkImageData_TransformContinuousIndexToPhysicalPoint_126(GetCppThis(), ijk, xyz);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_TransformContinuousIndexToPhysicalPoint_127(double i, double j, double k, IntPtr origin, IntPtr spacing, IntPtr direction, IntPtr xyz);

	/// <summary>
	/// Convert coordinates from index space (ijk) to physical space (xyz).
	/// </summary>
	public static void TransformContinuousIndexToPhysicalPoint(double i, double j, double k, IntPtr origin, IntPtr spacing, IntPtr direction, IntPtr xyz)
	{
		vtkImageData_TransformContinuousIndexToPhysicalPoint_127(i, j, k, origin, spacing, direction, xyz);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_TransformIndexToPhysicalPoint_128(HandleRef pThis, int i, int j, int k, IntPtr xyz);

	/// <summary>
	/// Convert coordinates from index space (ijk) to physical space (xyz).
	/// </summary>
	public virtual void TransformIndexToPhysicalPoint(int i, int j, int k, IntPtr xyz)
	{
		vtkImageData_TransformIndexToPhysicalPoint_128(GetCppThis(), i, j, k, xyz);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_TransformIndexToPhysicalPoint_129(HandleRef pThis, IntPtr ijk, IntPtr xyz);

	/// <summary>
	/// Convert coordinates from index space (ijk) to physical space (xyz).
	/// </summary>
	public virtual void TransformIndexToPhysicalPoint(IntPtr ijk, IntPtr xyz)
	{
		vtkImageData_TransformIndexToPhysicalPoint_129(GetCppThis(), ijk, xyz);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_TransformPhysicalNormalToContinuousIndex_130(HandleRef pThis, IntPtr xyz, IntPtr ijk);

	/// <summary>
	/// Convert normal from physical space (xyz) to index space (ijk).
	/// </summary>
	public virtual void TransformPhysicalNormalToContinuousIndex(IntPtr xyz, IntPtr ijk)
	{
		vtkImageData_TransformPhysicalNormalToContinuousIndex_130(GetCppThis(), xyz, ijk);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_TransformPhysicalPlaneToContinuousIndex_131(HandleRef pThis, IntPtr pplane, IntPtr iplane);

	/// <summary>
	/// Convert a plane from physical to a continuous index. The plane is represented as
	/// n(x-xo)=0; or using a four component normal: pplane=( nx,ny,nz,-(n(x0)) ).
	/// </summary>
	public virtual void TransformPhysicalPlaneToContinuousIndex(IntPtr pplane, IntPtr iplane)
	{
		vtkImageData_TransformPhysicalPlaneToContinuousIndex_131(GetCppThis(), pplane, iplane);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_TransformPhysicalPointToContinuousIndex_132(HandleRef pThis, double x, double y, double z, IntPtr ijk);

	/// <summary>
	/// Convert coordinates from physical space (xyz) to index space (ijk).
	/// </summary>
	public virtual void TransformPhysicalPointToContinuousIndex(double x, double y, double z, IntPtr ijk)
	{
		vtkImageData_TransformPhysicalPointToContinuousIndex_132(GetCppThis(), x, y, z, ijk);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageData_TransformPhysicalPointToContinuousIndex_133(HandleRef pThis, IntPtr xyz, IntPtr ijk);

	/// <summary>
	/// Convert coordinates from physical space (xyz) to index space (ijk).
	/// </summary>
	public virtual void TransformPhysicalPointToContinuousIndex(IntPtr xyz, IntPtr ijk)
	{
		vtkImageData_TransformPhysicalPointToContinuousIndex_133(GetCppThis(), xyz, ijk);
	}

	/// <summary>
	/// Creates a vtkImageData object from a System.Drawing.Image
	/// </summary>
	/// <param name="img">The System.Drawing.Image to convert</param>
	public static vtkImageData FromImage(Image img)
	{
		return FromImage(img, 4);
	}

	/// <summary>
	/// Creates a vtkImageData object from a System.Drawing.Image
	/// </summary>
	/// <param name="img">The System.Drawing.Image to convert</param>
	/// <param name="numberOfScalarComponents">3 for RGB and 4 for RGBA</param>
	public static vtkImageData FromImage(Image img, int numberOfScalarComponents)
	{
		Bitmap bitmap = new Bitmap(img);
		vtkUnsignedCharArray vtkUnsignedCharArray2 = vtkUnsignedCharArray.New();
		vtkUnsignedCharArray2.SetNumberOfComponents(numberOfScalarComponents);
		vtkUnsignedCharArray2.SetNumberOfTuples(img.Width * img.Height);
		byte[] array = new byte[img.Width * img.Height * numberOfScalarComponents];
		int num = 0;
		for (int num2 = img.Height - 1; num2 >= 0; num2--)
		{
			for (int i = 0; i < img.Width; i++)
			{
				array[num++] = bitmap.GetPixel(i, num2).R;
				array[num++] = bitmap.GetPixel(i, num2).G;
				array[num++] = bitmap.GetPixel(i, num2).B;
				if (numberOfScalarComponents > 3)
				{
					array[num++] = bitmap.GetPixel(i, num2).A;
				}
			}
		}
		Marshal.Copy(array, 0, vtkUnsignedCharArray2.GetVoidPointer(0L), array.Length);
		vtkImageData vtkImageData2 = New();
		vtkImageData2.SetDimensions(img.Width, img.Height, 1);
		vtkImageData2.GetPointData().SetScalars(vtkUnsignedCharArray2);
		return vtkImageData2;
	}

	/// <summary>
	/// Returns a System.Drawing.Bitmap created from a plane
	/// of the vtkImageData
	/// </summary>
	public Bitmap ToBitmap()
	{
		int num = (int)(GetBounds()[1] - GetBounds()[0]) + 1;
		int num2 = (int)(GetBounds()[3] - GetBounds()[2]) + 1;
		Bitmap bitmap = new Bitmap(num, num2);
		byte[] array = new byte[num * num2 * GetNumberOfScalarComponents()];
		Marshal.Copy(GetScalarPointer(), array, 0, num * num2 * GetNumberOfScalarComponents());
		int num3 = 0;
		for (int num4 = num2 - 1; num4 >= 0; num4--)
		{
			for (int i = 0; i < num; i++)
			{
				if (GetNumberOfScalarComponents() == 3)
				{
					bitmap.SetPixel(i, num4, Color.FromArgb(array[num3++], array[num3++], array[num3++]));
					continue;
				}
				if (GetNumberOfScalarComponents() == 4)
				{
					bitmap.SetPixel(i, num4, Color.FromArgb(array[num3++], array[num3++], array[num3++], array[num3++]));
					continue;
				}
				throw new Exception("Invalid Number of Scalar Components");
			}
		}
		return bitmap;
	}
}
