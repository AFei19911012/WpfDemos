using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCell3D
/// </summary>
/// <remarks>
///    abstract class to specify 3D cell interface
///
/// vtkCell3D is an abstract class that extends the interfaces for 3D data
/// cells, and implements methods needed to satisfy the vtkCell API. The
/// 3D cells include hexehedra, tetrahedra, wedge, pyramid, and voxel.
///
/// </remarks>
/// <seealso>
///
/// vtkTetra vtkHexahedron vtkVoxel vtkWedge vtkPyramid
/// </seealso>
public abstract class vtkCell3D : vtkCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCell3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCell3D()
	{
		MRClassNameKey = "class vtkCell3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCell3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCell3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkCell3D_Clip_01(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// Cut (or clip) the cell based on the input cellScalars and the specified
	/// value. The output of the clip operation will be one or more cells of the
	/// same topological dimension as the original cell.  The flag insideOut
	/// controls what part of the cell is considered inside - normally cell
	/// points whose scalar value is greater than "value" are considered
	/// inside. If insideOut is on, this is reversed. Also, if the output cell
	/// data is non-nullptr, the cell data from the clipped cell is passed to the
	/// generated contouring primitives. (Note: the CopyAllocate() method must
	/// be invoked on both the output cell and point data. The cellId refers to
	/// the cell from which the cell data is copied.)  (Satisfies vtkCell API.)
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkCell3D_Clip_01(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell3D_Contour_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// Computes the centroid of the cell.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkCell3D_Contour_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell3D_GetCellDimension_03(HandleRef pThis);

	/// <summary>
	/// The topological dimension of the cell. (Satisfies vtkCell API.)
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkCell3D_GetCellDimension_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCell3D_GetCentroid_04(HandleRef pThis, IntPtr centroid);

	/// <summary>
	/// Computes the centroid of the cell.
	/// </summary>
	public virtual bool GetCentroid(IntPtr centroid)
	{
		return (vtkCell3D_GetCentroid_04(GetCppThis(), centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCell3D_GetMergeTolerance_05(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate tetrahedra during clipping.
	/// </summary>
	public virtual double GetMergeTolerance()
	{
		return vtkCell3D_GetMergeTolerance_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCell3D_GetMergeToleranceMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate tetrahedra during clipping.
	/// </summary>
	public virtual double GetMergeToleranceMaxValue()
	{
		return vtkCell3D_GetMergeToleranceMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCell3D_GetMergeToleranceMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate tetrahedra during clipping.
	/// </summary>
	public virtual double GetMergeToleranceMinValue()
	{
		return vtkCell3D_GetMergeToleranceMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCell3D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCell3D_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCell3D_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCell3D_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell3D_Inflate_10(HandleRef pThis, double dist);

	/// <summary>
	/// Inflates the cell. Each face is displaced following its normal by a
	/// distance of value `dist`. If dist is negative, then the cell shrinks.
	/// The resulting cell edges / faces are colinear / coplanar to their previous
	/// self.
	///
	/// Degenerate parts of the 3D cell are unchanged. This happens a points to
	/// which incident faces are homogeneous to a plane, to a line, or to a point.
	///
	/// \return 1 if inflation was successful, 0 if no inflation was performed
	/// </summary>
	public override int Inflate(double dist)
	{
		return vtkCell3D_Inflate_10(GetCppThis(), dist);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell3D_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCell3D_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCell3D_IsInsideOut_12(HandleRef pThis);

	/// <summary>
	/// Returns true if the normals of the vtkCell3D point inside the cell.
	///
	/// @warning This flag is not precomputed. It is advised for the return result of
	/// this method to be stored in a local boolean by the user if needed multiple times.
	/// </summary>
	public virtual bool IsInsideOut()
	{
		return (vtkCell3D_IsInsideOut_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell3D_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCell3D_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell3D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCell3D NewInstance()
	{
		vtkCell3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCell3D_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCell3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell3D_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCell3D SafeDownCast(vtkObjectBase o)
	{
		vtkCell3D vtkCell3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCell3D_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell3D2 = (vtkCell3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell3D2.Register(null);
			}
		}
		return vtkCell3D2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell3D_SetMergeTolerance_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate tetrahedra during clipping.
	/// </summary>
	public virtual void SetMergeTolerance(double _arg)
	{
		vtkCell3D_SetMergeTolerance_16(GetCppThis(), _arg);
	}
}
