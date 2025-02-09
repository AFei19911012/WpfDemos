using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageStencilData
/// </summary>
/// <remarks>
///    efficient description of an image stencil
///
/// vtkImageStencilData describes an image stencil in a manner which is
/// efficient both in terms of speed and storage space.  The stencil extents
/// are stored for each x-row across the image (multiple extents per row if
/// necessary) and can be retrieved via the GetNextExtent() method.
/// </remarks>
/// <seealso>
///
/// vtkImageStencilSource vtkImageStencil
/// </seealso>
public class vtkImageStencilData : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageStencilData()
	{
		MRClassNameKey = "class vtkImageStencilData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageStencilData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStencilData New()
	{
		vtkImageStencilData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageStencilData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageStencilData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_Add_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add merges the stencil supplied as argument into Self.
	/// </summary>
	public virtual void Add(vtkImageStencilData arg0)
	{
		vtkImageStencilData_Add_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_AllocateExtents_02(HandleRef pThis);

	/// <summary>
	/// Allocate space for the sub-extents.  This is called by
	/// vtkImageStencilSource.
	/// </summary>
	public void AllocateExtents()
	{
		vtkImageStencilData_AllocateExtents_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilData_Clip_03(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Clip the stencil with the supplied extents. In other words, discard data
	/// outside the specified extents. Return 1 if something changed.
	/// </summary>
	public virtual int Clip(IntPtr extent)
	{
		return vtkImageStencilData_Clip_03(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_CopyInformationFromPipeline_04(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Override these to handle origin, spacing, scalar type, and scalar
	/// number of components.  See vtkDataObject for details.
	/// </summary>
	public override void CopyInformationFromPipeline(vtkInformation info)
	{
		vtkImageStencilData_CopyInformationFromPipeline_04(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_CopyInformationToPipeline_05(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Override these to handle origin, spacing, scalar type, and scalar
	/// number of components.  See vtkDataObject for details.
	/// </summary>
	public override void CopyInformationToPipeline(vtkInformation info)
	{
		vtkImageStencilData_CopyInformationToPipeline_05(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_DeepCopy_06(HandleRef pThis, HandleRef o);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void DeepCopy(vtkDataObject o)
	{
		vtkImageStencilData_DeepCopy_06(GetCppThis(), o?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_Fill_07(HandleRef pThis);

	/// <summary>
	/// Fill the sub-extents.
	/// </summary>
	public void Fill()
	{
		vtkImageStencilData_Fill_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilData_GetData_08(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkImageStencilData GetData(vtkInformation info)
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilData_GetData_08(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilData_GetData_09(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkImageStencilData GetData(vtkInformationVector v, int i)
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilData_GetData_09(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilData_GetDataObjectType_10(HandleRef pThis);

	/// <summary>
	/// Returns `VTK_IMAGE_STENCIL_DATA`.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkImageStencilData_GetDataObjectType_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilData_GetExtent_11(HandleRef pThis);

	/// <summary>
	/// Set the extent of the data.  This is should be called only
	/// by vtkImageStencilSource, as it is part of the basic pipeline
	/// functionality.
	/// </summary>
	public virtual int[] GetExtent()
	{
		IntPtr intPtr = vtkImageStencilData_GetExtent_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_GetExtent_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the extent of the data.  This is should be called only
	/// by vtkImageStencilSource, as it is part of the basic pipeline
	/// functionality.
	/// </summary>
	public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageStencilData_GetExtent_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_GetExtent_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the extent of the data.  This is should be called only
	/// by vtkImageStencilSource, as it is part of the basic pipeline
	/// functionality.
	/// </summary>
	public virtual void GetExtent(IntPtr _arg)
	{
		vtkImageStencilData_GetExtent_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilData_GetExtentType_14(HandleRef pThis);

	/// <summary>
	/// The extent type is 3D, just like vtkImageData.
	/// </summary>
	public override int GetExtentType()
	{
		return vtkImageStencilData_GetExtentType_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilData_GetNextExtent_15(HandleRef pThis, ref int r1, ref int r2, int xMin, int xMax, int yIdx, int zIdx, ref int iter);

	/// <summary>
	/// Given the total output x extent [xMin,xMax] and the current y, z indices,
	/// return each sub-extent [r1,r2] that lies within within the unclipped
	/// region in sequence.  A value of '0' is returned if no more sub-extents
	/// are available.  The variable 'iter' must be initialized to zero before
	/// the first call, unless you want the complementary sub-extents in which
	/// case you must initialize 'iter' to -1.  The variable 'iter' is used
	/// internally to keep track of which sub-extent should be returned next.
	/// </summary>
	public int GetNextExtent(ref int r1, ref int r2, int xMin, int xMax, int yIdx, int zIdx, ref int iter)
	{
		return vtkImageStencilData_GetNextExtent_15(GetCppThis(), ref r1, ref r2, xMin, xMax, yIdx, zIdx, ref iter);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStencilData_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageStencilData_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStencilData_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageStencilData_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilData_GetOrigin_18(HandleRef pThis);

	/// <summary>
	/// Set the desired origin for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkImageStencilData_GetOrigin_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_GetOrigin_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the desired origin for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageStencilData_GetOrigin_19(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_GetOrigin_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the desired origin for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual void GetOrigin(IntPtr _arg)
	{
		vtkImageStencilData_GetOrigin_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilData_GetSpacing_21(HandleRef pThis);

	/// <summary>
	/// Set the desired spacing for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual double[] GetSpacing()
	{
		IntPtr intPtr = vtkImageStencilData_GetSpacing_21(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_GetSpacing_22(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the desired spacing for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual void GetSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageStencilData_GetSpacing_22(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_GetSpacing_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the desired spacing for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual void GetSpacing(IntPtr _arg)
	{
		vtkImageStencilData_GetSpacing_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_Initialize_24(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Initialize()
	{
		vtkImageStencilData_Initialize_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_InsertAndMergeExtent_25(HandleRef pThis, int r1, int r2, int yIdx, int zIdx);

	/// <summary>
	/// Similar to InsertNextExtent, except that the extent (r1,r2) at yIdx,
	/// zIdx is merged with other extents, (if any) on that row. So a
	/// unique extent may not necessarily be added. For instance, if an extent
	/// [5,11] already exists adding an extent, [7,9] will not affect the
	/// stencil. Likewise adding [10, 13] will replace the existing extent
	/// with [5,13].
	/// </summary>
	public void InsertAndMergeExtent(int r1, int r2, int yIdx, int zIdx)
	{
		vtkImageStencilData_InsertAndMergeExtent_25(GetCppThis(), r1, r2, yIdx, zIdx);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_InsertNextExtent_26(HandleRef pThis, int r1, int r2, int yIdx, int zIdx);

	/// <summary>
	/// This method is used by vtkImageStencilDataSource to add an x
	/// sub extent [r1,r2] for the x row (yIdx,zIdx).  The specified sub
	/// extent must not intersect any other sub extents along the same x row.
	/// As well, r1 and r2 must both be within the total x extent
	/// [Extent[0],Extent[1]].
	/// </summary>
	public void InsertNextExtent(int r1, int r2, int yIdx, int zIdx)
	{
		vtkImageStencilData_InsertNextExtent_26(GetCppThis(), r1, r2, yIdx, zIdx);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_InternalImageStencilDataCopy_27(HandleRef pThis, HandleRef s);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void InternalImageStencilDataCopy(vtkImageStencilData s)
	{
		vtkImageStencilData_InternalImageStencilDataCopy_27(GetCppThis(), s?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilData_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageStencilData_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilData_IsInside_29(HandleRef pThis, int xIdx, int yIdx, int zIdx);

	/// <summary>
	/// Checks if an image index is inside the stencil.
	/// Even though GetNextExtent and the vtkImageStencilIterator are faster
	/// if every voxel in the volume has to be checked, IsInside provides an
	/// efficient alternative for if just a single voxel has to be checked.
	/// </summary>
	public int IsInside(int xIdx, int yIdx, int zIdx)
	{
		return vtkImageStencilData_IsInside_29(GetCppThis(), xIdx, yIdx, zIdx);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilData_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageStencilData_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilData_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageStencilData NewInstance()
	{
		vtkImageStencilData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilData_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_RemoveExtent_33(HandleRef pThis, int r1, int r2, int yIdx, int zIdx);

	/// <summary>
	/// Remove the extent from (r1,r2) at yIdx, zIdx
	/// </summary>
	public void RemoveExtent(int r1, int r2, int yIdx, int zIdx)
	{
		vtkImageStencilData_RemoveExtent_33(GetCppThis(), r1, r2, yIdx, zIdx);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_Replace_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Replaces the portion of the stencil, supplied as argument,
	/// that lies within Self from Self.
	/// </summary>
	public virtual void Replace(vtkImageStencilData arg0)
	{
		vtkImageStencilData_Replace_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilData_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStencilData SafeDownCast(vtkObjectBase o)
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilData_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_SetExtent_36(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set the extent of the data.  This is should be called only
	/// by vtkImageStencilSource, as it is part of the basic pipeline
	/// functionality.
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkImageStencilData_SetExtent_36(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_SetExtent_37(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

	/// <summary>
	/// Set the extent of the data.  This is should be called only
	/// by vtkImageStencilSource, as it is part of the basic pipeline
	/// functionality.
	/// </summary>
	public void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
	{
		vtkImageStencilData_SetExtent_37(GetCppThis(), x1, x2, y1, y2, z1, z2);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_SetOrigin_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the desired origin for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkImageStencilData_SetOrigin_38(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_SetOrigin_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the desired origin for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkImageStencilData_SetOrigin_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_SetSpacing_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the desired spacing for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkImageStencilData_SetSpacing_40(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_SetSpacing_41(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the desired spacing for the stencil.
	/// This must be called before the stencil is Updated, ideally
	/// in the ExecuteInformation method of the imaging filter that
	/// is using the stencil.
	/// </summary>
	public virtual void SetSpacing(IntPtr _arg)
	{
		vtkImageStencilData_SetSpacing_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_ShallowCopy_42(HandleRef pThis, HandleRef f);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void ShallowCopy(vtkDataObject f)
	{
		vtkImageStencilData_ShallowCopy_42(GetCppThis(), f?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilData_Subtract_43(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Subtract removes the portion of the stencil, supplied as argument,
	/// that lies within Self from Self.
	/// </summary>
	public virtual void Subtract(vtkImageStencilData arg0)
	{
		vtkImageStencilData_Subtract_43(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
