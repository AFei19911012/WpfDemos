using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIntersectionPolyDataFilter
///
///
/// vtkIntersectionPolyDataFilter computes the intersection between two
/// vtkPolyData objects. The first output is a set of lines that marks
/// the intersection of the input vtkPolyData objects. This contains five
/// different attached data arrays:
///
/// SurfaceID: Point data array that contains information about the origin
/// surface of each point
///
/// Input0CellID: Cell data array that contains the original
/// cell ID number on the first input mesh
///
/// Input1CellID: Cell data array that contains the original
/// cell ID number on the second input mesh
///
/// NewCell0ID: Cell data array that contains information about which cells
/// of the remeshed first input surface it touches (If split)
///
/// NewCell1ID: Cell data array that contains information about which cells
/// on the remeshed second input surface it touches (If split)
///
/// The second and third outputs are the first and second input vtkPolyData,
/// respectively. Optionally, the two output vtkPolyData can be split
/// along the intersection lines by remeshing. Optionally, the surface
/// can be cleaned and checked at the end of the remeshing.
/// If the meshes are split, The output vtkPolyDatas contain three possible
/// data arrays:
///
/// IntersectionPoint: This is a boolean indicating whether or not the point is
/// on the boundary of the two input objects
///
/// BadTriangle: If the surface is cleaned and checked, this is a cell data array
/// indicating whether or not the cell has edges with multiple neighbors
/// A manifold surface will have 0 everywhere for this array!
///
/// FreeEdge: If the surface is cleaned and checked, this is a cell data array
/// indicating if the cell has any free edges. A watertight surface will have
/// 0 everywhere for this array!
///
/// @author Adam Updegrove updega2@gmail.com
///
/// @warning This filter is not designed to perform 2D boolean operations,
/// and in fact relies on the inputs having no co-planar, overlapping cells.
/// </summary>
public class vtkIntersectionPolyDataFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIntersectionPolyDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIntersectionPolyDataFilter()
	{
		MRClassNameKey = "class vtkIntersectionPolyDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIntersectionPolyDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIntersectionPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIntersectionPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIntersectionPolyDataFilter New()
	{
		vtkIntersectionPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIntersectionPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIntersectionPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIntersectionPolyDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIntersectionPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_CheckInputOff_01(HandleRef pThis);

	/// <summary>
	/// If on, the normals of the input will be checked. Default: OFF
	/// </summary>
	public virtual void CheckInputOff()
	{
		vtkIntersectionPolyDataFilter_CheckInputOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_CheckInputOn_02(HandleRef pThis);

	/// <summary>
	/// If on, the normals of the input will be checked. Default: OFF
	/// </summary>
	public virtual void CheckInputOn()
	{
		vtkIntersectionPolyDataFilter_CheckInputOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_CheckMeshOff_03(HandleRef pThis);

	/// <summary>
	/// If on, the output remeshed surfaces will be checked for bad cells and
	/// free edges. Default: ON
	/// </summary>
	public virtual void CheckMeshOff()
	{
		vtkIntersectionPolyDataFilter_CheckMeshOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_CheckMeshOn_04(HandleRef pThis);

	/// <summary>
	/// If on, the output remeshed surfaces will be checked for bad cells and
	/// free edges. Default: ON
	/// </summary>
	public virtual void CheckMeshOn()
	{
		vtkIntersectionPolyDataFilter_CheckMeshOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_CleanAndCheckInput_05(HandleRef pd, double tolerance);

	/// <summary>
	/// Function to clean and check the inputs
	/// </summary>
	public static void CleanAndCheckInput(vtkPolyData pd, double tolerance)
	{
		vtkIntersectionPolyDataFilter_CleanAndCheckInput_05(pd?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_CleanAndCheckSurface_06(HandleRef pd, IntPtr stats, double tolerance);

	/// <summary>
	/// Function to clean and check the output surfaces for bad triangles and
	/// free edges
	/// </summary>
	public static void CleanAndCheckSurface(vtkPolyData pd, IntPtr stats, double tolerance)
	{
		vtkIntersectionPolyDataFilter_CleanAndCheckSurface_06(pd?.GetCppThis() ?? default(HandleRef), stats, tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_ComputeIntersectionPointArrayOff_07(HandleRef pThis);

	/// <summary>
	/// If on, the output split surfaces will contain information about which
	/// points are on the intersection of the two inputs. Default: ON
	/// </summary>
	public virtual void ComputeIntersectionPointArrayOff()
	{
		vtkIntersectionPolyDataFilter_ComputeIntersectionPointArrayOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_ComputeIntersectionPointArrayOn_08(HandleRef pThis);

	/// <summary>
	/// If on, the output split surfaces will contain information about which
	/// points are on the intersection of the two inputs. Default: ON
	/// </summary>
	public virtual void ComputeIntersectionPointArrayOn()
	{
		vtkIntersectionPolyDataFilter_ComputeIntersectionPointArrayOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_GetCheckInput_09(HandleRef pThis);

	/// <summary>
	/// If on, the normals of the input will be checked. Default: OFF
	/// </summary>
	public virtual int GetCheckInput()
	{
		return vtkIntersectionPolyDataFilter_GetCheckInput_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_GetCheckMesh_10(HandleRef pThis);

	/// <summary>
	/// If on, the output remeshed surfaces will be checked for bad cells and
	/// free edges. Default: ON
	/// </summary>
	public virtual int GetCheckMesh()
	{
		return vtkIntersectionPolyDataFilter_GetCheckMesh_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_GetComputeIntersectionPointArray_11(HandleRef pThis);

	/// <summary>
	/// If on, the output split surfaces will contain information about which
	/// points are on the intersection of the two inputs. Default: ON
	/// </summary>
	public virtual int GetComputeIntersectionPointArray()
	{
		return vtkIntersectionPolyDataFilter_GetComputeIntersectionPointArray_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIntersectionPolyDataFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIntersectionPolyDataFilter_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIntersectionPolyDataFilter_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIntersectionPolyDataFilter_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_GetNumberOfIntersectionLines_14(HandleRef pThis);

	/// <summary>
	/// Integer describing the number of intersection points and lines
	/// </summary>
	public virtual int GetNumberOfIntersectionLines()
	{
		return vtkIntersectionPolyDataFilter_GetNumberOfIntersectionLines_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_GetNumberOfIntersectionPoints_15(HandleRef pThis);

	/// <summary>
	/// Integer describing the number of intersection points and lines
	/// </summary>
	public virtual int GetNumberOfIntersectionPoints()
	{
		return vtkIntersectionPolyDataFilter_GetNumberOfIntersectionPoints_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIntersectionPolyDataFilter_GetRelativeSubtriangleArea_16(HandleRef pThis);

	/// <summary>
	/// When discretizing polygons, the minimum ratio of the smallest acceptable
	/// triangle area w.r.t. the area of the polygon
	///
	/// </summary>
	public virtual double GetRelativeSubtriangleArea()
	{
		return vtkIntersectionPolyDataFilter_GetRelativeSubtriangleArea_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_GetSplitFirstOutput_17(HandleRef pThis);

	/// <summary>
	/// If on, the second output will be the first input mesh split by the
	/// intersection with the second input mesh. Defaults to on.
	/// </summary>
	public virtual int GetSplitFirstOutput()
	{
		return vtkIntersectionPolyDataFilter_GetSplitFirstOutput_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_GetSplitSecondOutput_18(HandleRef pThis);

	/// <summary>
	/// If on, the third output will be the second input mesh split by the
	/// intersection with the first input mesh. Defaults to on.
	/// </summary>
	public virtual int GetSplitSecondOutput()
	{
		return vtkIntersectionPolyDataFilter_GetSplitSecondOutput_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_GetStatus_19(HandleRef pThis);

	/// <summary>
	/// Check the status of the filter after update. If the status is zero,
	/// there was an error in the operation. If status is one, everything
	/// went smoothly
	/// </summary>
	public virtual int GetStatus()
	{
		return vtkIntersectionPolyDataFilter_GetStatus_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIntersectionPolyDataFilter_GetTolerance_20(HandleRef pThis);

	/// <summary>
	/// The tolerance for geometric tests in the filter
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkIntersectionPolyDataFilter_GetTolerance_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIntersectionPolyDataFilter_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIntersectionPolyDataFilter_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIntersectionPolyDataFilter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIntersectionPolyDataFilter NewInstance()
	{
		vtkIntersectionPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIntersectionPolyDataFilter_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIntersectionPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIntersectionPolyDataFilter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIntersectionPolyDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkIntersectionPolyDataFilter vtkIntersectionPolyDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIntersectionPolyDataFilter_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntersectionPolyDataFilter2 = (vtkIntersectionPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntersectionPolyDataFilter2.Register(null);
			}
		}
		return vtkIntersectionPolyDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SetCheckInput_26(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the normals of the input will be checked. Default: OFF
	/// </summary>
	public virtual void SetCheckInput(int _arg)
	{
		vtkIntersectionPolyDataFilter_SetCheckInput_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SetCheckMesh_27(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output remeshed surfaces will be checked for bad cells and
	/// free edges. Default: ON
	/// </summary>
	public virtual void SetCheckMesh(int _arg)
	{
		vtkIntersectionPolyDataFilter_SetCheckMesh_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SetComputeIntersectionPointArray_28(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output split surfaces will contain information about which
	/// points are on the intersection of the two inputs. Default: ON
	/// </summary>
	public virtual void SetComputeIntersectionPointArray(int _arg)
	{
		vtkIntersectionPolyDataFilter_SetComputeIntersectionPointArray_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SetRelativeSubtriangleArea_29(HandleRef pThis, double _arg);

	/// <summary>
	/// When discretizing polygons, the minimum ratio of the smallest acceptable
	/// triangle area w.r.t. the area of the polygon
	///
	/// </summary>
	public virtual void SetRelativeSubtriangleArea(double _arg)
	{
		vtkIntersectionPolyDataFilter_SetRelativeSubtriangleArea_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SetSplitFirstOutput_30(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the second output will be the first input mesh split by the
	/// intersection with the second input mesh. Defaults to on.
	/// </summary>
	public virtual void SetSplitFirstOutput(int _arg)
	{
		vtkIntersectionPolyDataFilter_SetSplitFirstOutput_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SetSplitSecondOutput_31(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the third output will be the second input mesh split by the
	/// intersection with the first input mesh. Defaults to on.
	/// </summary>
	public virtual void SetSplitSecondOutput(int _arg)
	{
		vtkIntersectionPolyDataFilter_SetSplitSecondOutput_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SetTolerance_32(HandleRef pThis, double _arg);

	/// <summary>
	/// The tolerance for geometric tests in the filter
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkIntersectionPolyDataFilter_SetTolerance_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SplitFirstOutputOff_33(HandleRef pThis);

	/// <summary>
	/// If on, the second output will be the first input mesh split by the
	/// intersection with the second input mesh. Defaults to on.
	/// </summary>
	public virtual void SplitFirstOutputOff()
	{
		vtkIntersectionPolyDataFilter_SplitFirstOutputOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SplitFirstOutputOn_34(HandleRef pThis);

	/// <summary>
	/// If on, the second output will be the first input mesh split by the
	/// intersection with the second input mesh. Defaults to on.
	/// </summary>
	public virtual void SplitFirstOutputOn()
	{
		vtkIntersectionPolyDataFilter_SplitFirstOutputOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SplitSecondOutputOff_35(HandleRef pThis);

	/// <summary>
	/// If on, the third output will be the second input mesh split by the
	/// intersection with the first input mesh. Defaults to on.
	/// </summary>
	public virtual void SplitSecondOutputOff()
	{
		vtkIntersectionPolyDataFilter_SplitSecondOutputOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionPolyDataFilter_SplitSecondOutputOn_36(HandleRef pThis);

	/// <summary>
	/// If on, the third output will be the second input mesh split by the
	/// intersection with the first input mesh. Defaults to on.
	/// </summary>
	public virtual void SplitSecondOutputOn()
	{
		vtkIntersectionPolyDataFilter_SplitSecondOutputOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionPolyDataFilter_TriangleTriangleIntersection_37(IntPtr p1, IntPtr q1, IntPtr r1, IntPtr p2, IntPtr q2, IntPtr r2, ref int coplanar, IntPtr pt1, IntPtr pt2, IntPtr surfaceid, double tolerance);

	/// <summary>
	/// Given two triangles defined by points (p1, q1, r1) and (p2, q2,
	/// r2), returns whether the two triangles intersect. If they do,
	/// the endpoints of the line forming the intersection are returned
	/// in pt1 and pt2. The parameter coplanar is set to 1 if the
	/// triangles are coplanar and 0 otherwise. The surfaceid array
	/// is filled with the surface on which the first and second
	/// intersection points resides, respectively. A geometric tolerance
	/// can be specified in the last argument.
	/// </summary>
	public static int TriangleTriangleIntersection(IntPtr p1, IntPtr q1, IntPtr r1, IntPtr p2, IntPtr q2, IntPtr r2, ref int coplanar, IntPtr pt1, IntPtr pt2, IntPtr surfaceid, double tolerance)
	{
		return vtkIntersectionPolyDataFilter_TriangleTriangleIntersection_37(p1, q1, r1, p2, q2, r2, ref coplanar, pt1, pt2, surfaceid, tolerance);
	}
}
