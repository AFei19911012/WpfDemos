using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLinearCellExtrusionFilter
/// </summary>
/// <remarks>
///    extrude polygonal data to create 3D cells from 2D cells
///
/// vtkLinearCellExtrusionFilter is a modeling filter. It takes polygonal data as
/// input and generates an unstructured grid data on output. The input dataset is swept
/// according to the input cell data array value along the cell normal and creates
/// new 3D primitives.
/// Triangles will become Wedges, Quads will become Hexahedrons,
/// and Polygons will become Polyhedrons.
/// This filter currently takes into account only polys and discard vertices, lines and strips.
/// Unlike the vtkLinearExtrusionFilter, this filter is designed to extrude each cell independently
/// using its normal and its scalar value.
///
/// </remarks>
/// <seealso>
///
/// vtkLinearExtrusionFilter
/// </seealso>
public class vtkLinearCellExtrusionFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLinearCellExtrusionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLinearCellExtrusionFilter()
	{
		MRClassNameKey = "class vtkLinearCellExtrusionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearCellExtrusionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLinearCellExtrusionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearCellExtrusionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLinearCellExtrusionFilter New()
	{
		vtkLinearCellExtrusionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearCellExtrusionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearCellExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLinearCellExtrusionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLinearCellExtrusionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified. The
	/// locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkLinearCellExtrusionFilter_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearCellExtrusionFilter_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a spatial locator for merging points.
	/// By default, an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearCellExtrusionFilter_GetLocator_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLinearCellExtrusionFilter_GetMergeDuplicatePoints_03(HandleRef pThis);

	/// <summary>
	/// Specify if the algorithm should merge duplicate points.
	/// Default is false
	/// </summary>
	public virtual bool GetMergeDuplicatePoints()
	{
		return (vtkLinearCellExtrusionFilter_GetMergeDuplicatePoints_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearCellExtrusionFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLinearCellExtrusionFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearCellExtrusionFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLinearCellExtrusionFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLinearCellExtrusionFilter_GetScaleFactor_06(HandleRef pThis);

	/// <summary>
	/// Specify the scale factor applied on the cell value during extrusion.
	/// Default is 1.0
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkLinearCellExtrusionFilter_GetScaleFactor_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLinearCellExtrusionFilter_GetUseUserVector_07(HandleRef pThis);

	/// <summary>
	/// Specify if the algorithm should use the specified vector instead of cell normals.
	/// Default is false
	/// </summary>
	public virtual bool GetUseUserVector()
	{
		return (vtkLinearCellExtrusionFilter_GetUseUserVector_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearCellExtrusionFilter_GetUserVector_08(HandleRef pThis);

	/// <summary>
	/// Specify the scale factor applied on the cell value during extrusion.
	/// </summary>
	public virtual double[] GetUserVector()
	{
		IntPtr intPtr = vtkLinearCellExtrusionFilter_GetUserVector_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_GetUserVector_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify the scale factor applied on the cell value during extrusion.
	/// </summary>
	public virtual void GetUserVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkLinearCellExtrusionFilter_GetUserVector_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_GetUserVector_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the scale factor applied on the cell value during extrusion.
	/// </summary>
	public virtual void GetUserVector(IntPtr _arg)
	{
		vtkLinearCellExtrusionFilter_GetUserVector_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearCellExtrusionFilter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLinearCellExtrusionFilter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearCellExtrusionFilter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLinearCellExtrusionFilter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_MergeDuplicatePointsOff_13(HandleRef pThis);

	/// <summary>
	/// Specify if the algorithm should merge duplicate points.
	/// Default is false
	/// </summary>
	public virtual void MergeDuplicatePointsOff()
	{
		vtkLinearCellExtrusionFilter_MergeDuplicatePointsOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_MergeDuplicatePointsOn_14(HandleRef pThis);

	/// <summary>
	/// Specify if the algorithm should merge duplicate points.
	/// Default is false
	/// </summary>
	public virtual void MergeDuplicatePointsOn()
	{
		vtkLinearCellExtrusionFilter_MergeDuplicatePointsOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearCellExtrusionFilter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLinearCellExtrusionFilter NewInstance()
	{
		vtkLinearCellExtrusionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearCellExtrusionFilter_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearCellExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearCellExtrusionFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLinearCellExtrusionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkLinearCellExtrusionFilter vtkLinearCellExtrusionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearCellExtrusionFilter_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinearCellExtrusionFilter2 = (vtkLinearCellExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinearCellExtrusionFilter2.Register(null);
			}
		}
		return vtkLinearCellExtrusionFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_SetLocator_18(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Specify a spatial locator for merging points.
	/// By default, an instance of vtkMergePoints is used.
	/// </summary>
	public virtual void SetLocator(vtkIncrementalPointLocator _arg)
	{
		vtkLinearCellExtrusionFilter_SetLocator_18(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_SetMergeDuplicatePoints_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if the algorithm should merge duplicate points.
	/// Default is false
	/// </summary>
	public virtual void SetMergeDuplicatePoints(bool _arg)
	{
		vtkLinearCellExtrusionFilter_SetMergeDuplicatePoints_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_SetScaleFactor_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the scale factor applied on the cell value during extrusion.
	/// Default is 1.0
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkLinearCellExtrusionFilter_SetScaleFactor_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_SetUseUserVector_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if the algorithm should use the specified vector instead of cell normals.
	/// Default is false
	/// </summary>
	public virtual void SetUseUserVector(bool _arg)
	{
		vtkLinearCellExtrusionFilter_SetUseUserVector_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_SetUserVector_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the scale factor applied on the cell value during extrusion.
	/// </summary>
	public virtual void SetUserVector(double _arg1, double _arg2, double _arg3)
	{
		vtkLinearCellExtrusionFilter_SetUserVector_22(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_SetUserVector_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the scale factor applied on the cell value during extrusion.
	/// </summary>
	public virtual void SetUserVector(IntPtr _arg)
	{
		vtkLinearCellExtrusionFilter_SetUserVector_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_UseUserVectorOff_24(HandleRef pThis);

	/// <summary>
	/// Specify if the algorithm should use the specified vector instead of cell normals.
	/// Default is false
	/// </summary>
	public virtual void UseUserVectorOff()
	{
		vtkLinearCellExtrusionFilter_UseUserVectorOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearCellExtrusionFilter_UseUserVectorOn_25(HandleRef pThis);

	/// <summary>
	/// Specify if the algorithm should use the specified vector instead of cell normals.
	/// Default is false
	/// </summary>
	public virtual void UseUserVectorOn()
	{
		vtkLinearCellExtrusionFilter_UseUserVectorOn_25(GetCppThis());
	}
}
