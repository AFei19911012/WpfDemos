using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericCellTessellator
/// </summary>
/// <remarks>
///    helper class to perform cell tessellation
///
/// vtkGenericCellTessellator is a helper class to perform adaptive tessellation
/// of particular cell topologies. The major purpose for this class is to
/// transform higher-order cell types (e.g., higher-order finite elements)
/// into linear cells that can then be easily visualized by VTK. This class
/// works in conjunction with the vtkGenericDataSet and vtkGenericAdaptorCell
/// classes.
///
/// This algorithm is based on edge subdivision. An error metric along each
/// edge is evaluated, and if the error is greater than some tolerance, the
/// edge is subdivided (as well as all connected 2D and 3D cells). The process
/// repeats until the error metric is satisfied.
///
/// A significant issue addressed by this algorithm is to ensure face
/// compatibility across neighboring cells. That is, diagonals due to face
/// triangulation must match to ensure that the mesh is compatible. The
/// algorithm employs a precomputed table to accelerate the tessellation
/// process. The table was generated with the help of vtkOrderedTriangulator;
/// the basic idea is that the choice of diagonal is made by considering the
/// relative value of the point ids.
/// </remarks>
public abstract class vtkGenericCellTessellator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCellTessellator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericCellTessellator()
	{
		MRClassNameKey = "class vtkGenericCellTessellator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCellTessellator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericCellTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkGenericCellTessellator_GetErrorMetrics_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the list of error metrics used to decide if an edge has to be
	/// split or not. It is a collection of vtkGenericSubdivisionErrorMetric-s.
	/// </summary>
	public virtual vtkCollection GetErrorMetrics()
	{
		vtkCollection vtkCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCellTessellator_GetErrorMetrics_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCollection2 = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCollection2.Register(null);
			}
		}
		return vtkCollection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellTessellator_GetMaxErrors_02(HandleRef pThis, IntPtr errors);

	/// <summary>
	/// Get the maximum error measured after the fixed subdivision.
	/// \pre errors_exists: errors!=0
	/// \pre valid_size: sizeof(errors)==GetErrorMetrics()-&gt;GetNumberOfItems()
	/// </summary>
	public void GetMaxErrors(IntPtr errors)
	{
		vtkGenericCellTessellator_GetMaxErrors_02(GetCppThis(), errors);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCellTessellator_GetMeasurement_03(HandleRef pThis);

	/// <summary>
	/// If true, measure the quality of the fixed subdivision.
	/// </summary>
	public virtual int GetMeasurement()
	{
		return vtkGenericCellTessellator_GetMeasurement_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericCellTessellator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericCellTessellator_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericCellTessellator_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericCellTessellator_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellTessellator_InitErrorMetrics_06(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Init the error metric with the dataset. Should be called in each filter
	/// before any tessellation of any cell.
	/// </summary>
	public void InitErrorMetrics(vtkGenericDataSet ds)
	{
		vtkGenericCellTessellator_InitErrorMetrics_06(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellTessellator_Initialize_07(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Initialize the tessellator with a data set `ds'.
	/// </summary>
	public virtual void Initialize(vtkGenericDataSet ds)
	{
		vtkGenericCellTessellator_Initialize_07(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCellTessellator_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericCellTessellator_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCellTessellator_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericCellTessellator_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCellTessellator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericCellTessellator NewInstance()
	{
		vtkGenericCellTessellator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCellTessellator_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCellTessellator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericCellTessellator SafeDownCast(vtkObjectBase o)
	{
		vtkGenericCellTessellator vtkGenericCellTessellator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCellTessellator_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericCellTessellator2 = (vtkGenericCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericCellTessellator2.Register(null);
			}
		}
		return vtkGenericCellTessellator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellTessellator_SetErrorMetrics_12(HandleRef pThis, HandleRef someErrorMetrics);

	/// <summary>
	/// Specify the list of error metrics used to decide if an edge has to be
	/// split or not. It is a collection of vtkGenericSubdivisionErrorMetric-s.
	/// </summary>
	public virtual void SetErrorMetrics(vtkCollection someErrorMetrics)
	{
		vtkGenericCellTessellator_SetErrorMetrics_12(GetCppThis(), someErrorMetrics?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellTessellator_SetMeasurement_13(HandleRef pThis, int _arg);

	/// <summary>
	/// If true, measure the quality of the fixed subdivision.
	/// </summary>
	public virtual void SetMeasurement(int _arg)
	{
		vtkGenericCellTessellator_SetMeasurement_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellTessellator_Tessellate_14(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

	/// <summary>
	/// Tessellate a 3D `cell'. The result is a set of smaller linear
	/// tetrahedra in `cellArray' with `points' and point data `internalPd'.
	/// \pre cell_exists: cell!=0
	/// \pre valid_dimension: cell-&gt;GetDimension()==3
	/// \pre att_exists: att!=0
	/// \pre points_exists: points!=0
	/// \pre cellArray_exists: cellArray!=0
	/// \pre internalPd_exists: internalPd!=0
	/// </summary>
	public virtual void Tessellate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
	{
		vtkGenericCellTessellator_Tessellate_14(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), att?.GetCppThis() ?? default(HandleRef), points?.GetCppThis() ?? default(HandleRef), cellArray?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellTessellator_TessellateFace_15(HandleRef pThis, HandleRef cell, HandleRef att, long index, HandleRef points, HandleRef cellArray, HandleRef internalPd);

	/// <summary>
	/// Tessellate a face of a 3D `cell'. The face is specified by the
	/// index value.
	/// The result is a set of smaller linear triangles in `cellArray' with
	/// `points' and point data `internalPd'.
	/// \pre cell_exists: cell!=0
	/// \pre valid_dimension: cell-&gt;GetDimension()==3
	/// \pre valid_index_range: (index&gt;=0) &amp;&amp; (index&lt;cell-&gt;GetNumberOfBoundaries(2))
	/// \pre att_exists: att!=0
	/// \pre points_exists: points!=0
	/// \pre cellArray_exists: cellArray!=0
	/// \pre internalPd_exists: internalPd!=0
	/// </summary>
	public virtual void TessellateFace(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, long index, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
	{
		vtkGenericCellTessellator_TessellateFace_15(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), att?.GetCppThis() ?? default(HandleRef), index, points?.GetCppThis() ?? default(HandleRef), cellArray?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellTessellator_Triangulate_16(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

	/// <summary>
	/// Triangulate a 2D `cell'. The result is a set of smaller linear triangles
	/// in `cellArray' with `points' and point data `internalPd'.
	/// \pre cell_exists: cell!=0
	/// \pre valid_dimension: cell-&gt;GetDimension()==2
	/// \pre att_exists: att!=0
	/// \pre points_exists: points!=0
	/// \pre cellArray_exists: cellArray!=0
	/// \pre internalPd_exists: internalPd!=0
	/// </summary>
	public virtual void Triangulate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
	{
		vtkGenericCellTessellator_Triangulate_16(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), att?.GetCppThis() ?? default(HandleRef), points?.GetCppThis() ?? default(HandleRef), cellArray?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef));
	}
}
