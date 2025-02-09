using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSimpleCellTessellator
/// </summary>
/// <remarks>
///    helper class to perform cell tessellation
///
/// vtkSimpleCellTessellator is a helper class to perform adaptive tessellation
/// of particular cell topologies. The major purpose for this class is to
/// transform higher-order cell types (e.g., higher-order finite elements)
/// into linear cells that can then be easily visualized by VTK. This class
/// works in conjunction with the vtkGenericDataSet and vtkGenericAdaptorCell
/// classes.
///
/// This algorithm is based on edge subdivision. An error metric along each
/// edge is evaluated, and if the error is greater than some tolerance, the
/// edge is subdivided (as well as all connected 2D and 3D cells). The process
/// repeats until the error metric is satisfied. Since the algorithm is based
/// on edge subdivision it inherently avoid T-junctions.
///
/// A significant issue addressed by this algorithm is to ensure face
/// compatibility across neighboring cells. That is, diagonals due to face
/// triangulation must match to ensure that the mesh is compatible. The
/// algorithm employs a precomputed table to accelerate the tessellation
/// process. The table was generated with the help of vtkOrderedTriangulator
/// the basic idea is that the choice of diagonal is made only by considering the
/// relative value of the point ids.
///
/// </remarks>
/// <seealso>
///
/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric vtkAttributesErrorMetric
/// vtkGeometricErrorMetric vtkViewDependentErrorMetric
/// </seealso>
public class vtkSimpleCellTessellator : vtkGenericCellTessellator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleCellTessellator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSimpleCellTessellator()
	{
		MRClassNameKey = "class vtkSimpleCellTessellator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleCellTessellator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSimpleCellTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleCellTessellator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimpleCellTessellator New()
	{
		vtkSimpleCellTessellator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleCellTessellator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSimpleCellTessellator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSimpleCellTessellator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSimpleCellTessellator_GetFixedSubdivisions_01(HandleRef pThis);

	/// <summary>
	/// Return the number of fixed subdivisions. It is used to prevent from
	/// infinite loop in degenerated cases. For order 3 or higher, if the
	/// inflection point is exactly on the mid-point, error metric will not
	/// detect that a subdivision is required. 0 means no fixed subdivision:
	/// there will be only adaptive subdivisions.
	///
	/// The algorithm first performs `GetFixedSubdivisions' non adaptive
	/// subdivisions followed by at most `GetMaxAdaptiveSubdivisions' adaptive
	/// subdivisions. Hence, there are at most `GetMaxSubdivisionLevel'
	/// subdivisions.
	/// \post positive_result: result&gt;=0 &amp;&amp; result&lt;=GetMaxSubdivisionLevel()
	/// </summary>
	public int GetFixedSubdivisions()
	{
		return vtkSimpleCellTessellator_GetFixedSubdivisions_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleCellTessellator_GetGenericCell_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the higher order cell in order to access the evaluation function.
	/// </summary>
	public virtual vtkGenericAdaptorCell GetGenericCell()
	{
		vtkGenericAdaptorCell vtkGenericAdaptorCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleCellTessellator_GetGenericCell_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAdaptorCell2 = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAdaptorCell2.Register(null);
			}
		}
		return vtkGenericAdaptorCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleCellTessellator_GetMaxAdaptiveSubdivisions_03(HandleRef pThis);

	/// <summary>
	/// Return the maximum number of adaptive subdivisions.
	/// \post valid_result: result==GetMaxSubdivisionLevel()-GetFixedSubdivisions()
	/// </summary>
	public int GetMaxAdaptiveSubdivisions()
	{
		return vtkSimpleCellTessellator_GetMaxAdaptiveSubdivisions_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleCellTessellator_GetMaxSubdivisionLevel_04(HandleRef pThis);

	/// <summary>
	/// Return the maximum level of subdivision. It is used to prevent from
	/// infinite loop in degenerated cases. For order 3 or higher, if the
	/// inflection point is exactly on the mid-point, error metric will not
	/// detect that a subdivision is required. 0 means no subdivision,
	/// neither fixed nor adaptive.
	/// \post positive_result: result&gt;=GetFixedSubdivisions()
	/// </summary>
	public int GetMaxSubdivisionLevel()
	{
		return vtkSimpleCellTessellator_GetMaxSubdivisionLevel_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleCellTessellator_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSimpleCellTessellator_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleCellTessellator_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSimpleCellTessellator_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleCellTessellator_Initialize_07(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Initialize the tessellator with a data set `ds'.
	/// </summary>
	public override void Initialize(vtkGenericDataSet ds)
	{
		vtkSimpleCellTessellator_Initialize_07(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleCellTessellator_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSimpleCellTessellator_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleCellTessellator_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSimpleCellTessellator_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleCellTessellator_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSimpleCellTessellator NewInstance()
	{
		vtkSimpleCellTessellator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleCellTessellator_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleCellTessellator_Reset_12(HandleRef pThis);

	/// <summary>
	/// Reset the output for repeated use of this class.
	/// </summary>
	public void Reset()
	{
		vtkSimpleCellTessellator_Reset_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleCellTessellator_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimpleCellTessellator SafeDownCast(vtkObjectBase o)
	{
		vtkSimpleCellTessellator vtkSimpleCellTessellator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleCellTessellator_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSimpleCellTessellator2 = (vtkSimpleCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSimpleCellTessellator2.Register(null);
			}
		}
		return vtkSimpleCellTessellator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleCellTessellator_SetFixedSubdivisions_14(HandleRef pThis, int level);

	/// <summary>
	/// Set the number of fixed subdivisions. See GetFixedSubdivisions() for
	/// more explanations.
	/// \pre positive_level: level&gt;=0 &amp;&amp; level&lt;=GetMaxSubdivisionLevel()
	/// \post is_set: GetFixedSubdivisions()==level
	/// </summary>
	public void SetFixedSubdivisions(int level)
	{
		vtkSimpleCellTessellator_SetFixedSubdivisions_14(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleCellTessellator_SetMaxSubdivisionLevel_15(HandleRef pThis, int level);

	/// <summary>
	/// Set the maximum level of subdivision. See GetMaxSubdivisionLevel() for
	/// more explanations.
	/// \pre positive_level: level&gt;=GetFixedSubdivisions()
	/// \post is_set: level==GetMaxSubdivisionLevel()
	/// </summary>
	public void SetMaxSubdivisionLevel(int level)
	{
		vtkSimpleCellTessellator_SetMaxSubdivisionLevel_15(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleCellTessellator_SetSubdivisionLevels_16(HandleRef pThis, int arg0, int maxLevel);

	/// <summary>
	/// Set both the number of fixed subdivisions and the maximum level of
	/// subdivisions. See GetFixedSubdivisions(), GetMaxSubdivisionLevel() and
	/// GetMaxAdaptiveSubdivisions() for more explanations.
	/// \pre positive_fixed: fixed&gt;=0
	/// \pre valid_range: fixed&lt;=maxLevel
	/// \post fixed_is_set: fixed==GetFixedSubdivisions()
	/// \post maxLevel_is_set: maxLevel==GetMaxSubdivisionLevel()
	/// </summary>
	public void SetSubdivisionLevels(int arg0, int maxLevel)
	{
		vtkSimpleCellTessellator_SetSubdivisionLevels_16(GetCppThis(), arg0, maxLevel);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleCellTessellator_Tessellate_17(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

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
	public override void Tessellate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
	{
		vtkSimpleCellTessellator_Tessellate_17(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), att?.GetCppThis() ?? default(HandleRef), points?.GetCppThis() ?? default(HandleRef), cellArray?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleCellTessellator_TessellateFace_18(HandleRef pThis, HandleRef cell, HandleRef att, long index, HandleRef points, HandleRef cellArray, HandleRef internalPd);

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
	public override void TessellateFace(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, long index, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
	{
		vtkSimpleCellTessellator_TessellateFace_18(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), att?.GetCppThis() ?? default(HandleRef), index, points?.GetCppThis() ?? default(HandleRef), cellArray?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleCellTessellator_Triangulate_19(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

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
	public override void Triangulate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
	{
		vtkSimpleCellTessellator_Triangulate_19(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), att?.GetCppThis() ?? default(HandleRef), points?.GetCppThis() ?? default(HandleRef), cellArray?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef));
	}
}
