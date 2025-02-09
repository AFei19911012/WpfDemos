using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMaskPointsFilter
/// </summary>
/// <remarks>
///    extract points within an image/volume mask
///
/// vtkMaskPointsFilter extracts points that are inside an image mask. The
/// image mask is a second input to the filter. Points that are inside a voxel
/// marked "inside" are copied to the output. The image mask can be generated
/// by vtkPointOccupancyFilter, with optional image processing steps performed
/// on the mask. Thus vtkPointOccupancyFilter and vtkMaskPointsFilter are
/// generally used together, with a pipeline of image processing algorithms
/// in between the two filters.
///
/// Note also that this filter is a subclass of vtkPointCloudFilter which has
/// the ability to produce an output mask indicating which points were
/// selected for output. It also has an optional second output containing the
/// points that were masked out (i.e., outliers) during processing.
///
/// Finally, the mask value indicating non-selection of points (i.e., the
/// empty value) may be specified. The second input, masking image, is
/// typically of type unsigned char so the empty value is of this type as
/// well.
///
/// @warning
/// During processing, points not within the masking image/volume are
/// considered outside and never extracted.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkPointOccupancyFilter vtkPointCloudFilter
/// </seealso>
public class vtkMaskPointsFilter : vtkPointCloudFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMaskPointsFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMaskPointsFilter()
	{
		MRClassNameKey = "class vtkMaskPointsFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskPointsFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMaskPointsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskPointsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkMaskPointsFilter New()
	{
		vtkMaskPointsFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskPointsFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMaskPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkMaskPointsFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMaskPointsFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMaskPointsFilter_GetEmptyValue_01(HandleRef pThis);

	/// <summary>
	/// Set / get the values indicating whether a voxel is empty. By default, an
	/// empty voxel is marked with a zero value. Any point inside a voxel marked
	/// empty is not selected for output. All other voxels with a value that is
	/// not equal to the empty value are selected for output.
	/// </summary>
	public virtual byte GetEmptyValue()
	{
		return vtkMaskPointsFilter_GetEmptyValue_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskPointsFilter_GetMask_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the masking image. It must be of type vtkImageData.
	/// </summary>
	public vtkDataObject GetMask()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskPointsFilter_GetMask_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPointsFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMaskPointsFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPointsFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMaskPointsFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPointsFilter_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMaskPointsFilter_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPointsFilter_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMaskPointsFilter_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskPointsFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkMaskPointsFilter NewInstance()
	{
		vtkMaskPointsFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskPointsFilter_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMaskPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskPointsFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkMaskPointsFilter SafeDownCast(vtkObjectBase o)
	{
		vtkMaskPointsFilter vtkMaskPointsFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskPointsFilter_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMaskPointsFilter2 = (vtkMaskPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMaskPointsFilter2.Register(null);
			}
		}
		return vtkMaskPointsFilter2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPointsFilter_SetEmptyValue_10(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set / get the values indicating whether a voxel is empty. By default, an
	/// empty voxel is marked with a zero value. Any point inside a voxel marked
	/// empty is not selected for output. All other voxels with a value that is
	/// not equal to the empty value are selected for output.
	/// </summary>
	public virtual void SetEmptyValue(byte _arg)
	{
		vtkMaskPointsFilter_SetEmptyValue_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPointsFilter_SetMaskConnection_11(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the masking image. It is vtkImageData output from an algorithm.
	/// </summary>
	public void SetMaskConnection(vtkAlgorithmOutput algOutput)
	{
		vtkMaskPointsFilter_SetMaskConnection_11(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPointsFilter_SetMaskData_12(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the masking image. It must be of type vtkImageData.
	/// </summary>
	public void SetMaskData(vtkDataObject source)
	{
		vtkMaskPointsFilter_SetMaskData_12(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}
}
