using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSphereTree
/// </summary>
/// <remarks>
///    class to build and traverse sphere trees
///
/// vtkSphereTree is a helper class used to build and traverse sphere
/// trees. Various types of trees can be constructed for different VTK
/// dataset types, as well well as different approaches to organize
/// the tree into hierarchies.
///
/// Typically building a complete sphere tree consists of two parts: 1)
/// creating spheres for each cell in the dataset, then 2) creating an
/// organizing hierarchy. The structure of the hierarchy varies depending on
/// the topological characteristics of the dataset.
///
/// Once the tree is constructed, various geometric operations are available
/// for quickly selecting cells based on sphere tree operations; for example,
/// process all cells intersecting a plane (i.e., use the sphere tree to identify
/// candidate cells for plane intersection).
///
/// This class does not necessarily create optimal sphere trees because
/// some of its requirements (fast build time, provide simple reference
/// code, a single bounding sphere per cell, etc.) precludes optimal
/// performance. It is also oriented to computing on cells versus the
/// classic problem of collision detection for polygonal models. For
/// more information you want to read Gareth Bradshaw's PhD thesis
/// "Bounding Volume Hierarchies for Level-of-Detail Collision
/// Handling" which does a nice job of laying out the challenges and
/// important algorithms relative to sphere trees and BVH (bounding
/// volume hierarchies).
///
/// </remarks>
/// <seealso>
///
/// vtkSphereTreeFilter vtkPlaneCutter
/// </seealso>
public class vtkSphereTree : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphereTree";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphereTree()
	{
		MRClassNameKey = "class vtkSphereTree";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereTree"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphereTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the sphere tree.
	/// </summary>
	public new static vtkSphereTree New()
	{
		vtkSphereTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the sphere tree.
	/// </summary>
	public vtkSphereTree()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphereTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSphereTree_Build_01(HandleRef pThis);

	/// <summary>
	/// Build the sphere tree (if necessary) from the data set specified. The
	/// build time is recorded so the sphere tree will only build if something has
	/// changed. An alternative method is available to both set the dataset and
	/// then build the sphere tree.
	/// </summary>
	public void Build()
	{
		vtkSphereTree_Build_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_Build_02(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Build the sphere tree (if necessary) from the data set specified. The
	/// build time is recorded so the sphere tree will only build if something has
	/// changed. An alternative method is available to both set the dataset and
	/// then build the sphere tree.
	/// </summary>
	public void Build(vtkDataSet input)
	{
		vtkSphereTree_Build_02(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_BuildHierarchyOff_03(HandleRef pThis);

	/// <summary>
	/// Control whether the tree hierarchy is built. If not, then just
	/// cell spheres are created (one for each cell).
	/// </summary>
	public virtual void BuildHierarchyOff()
	{
		vtkSphereTree_BuildHierarchyOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_BuildHierarchyOn_04(HandleRef pThis);

	/// <summary>
	/// Control whether the tree hierarchy is built. If not, then just
	/// cell spheres are created (one for each cell).
	/// </summary>
	public virtual void BuildHierarchyOn()
	{
		vtkSphereTree_BuildHierarchyOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSphereTree_GetBuildHierarchy_05(HandleRef pThis);

	/// <summary>
	/// Control whether the tree hierarchy is built. If not, then just
	/// cell spheres are created (one for each cell).
	/// </summary>
	public virtual bool GetBuildHierarchy()
	{
		return (vtkSphereTree_GetBuildHierarchy_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTree_GetCellSpheres_06(HandleRef pThis);

	/// <summary>
	/// Special methods to retrieve the sphere tree data. This is
	/// generally used for debugging or with filters like
	/// vtkSphereTreeFilter. Both methods return an array of double*
	/// where four doubles represent a sphere (center + radius). In the
	/// first method a sphere per cell is returned. In the second method
	/// the user must also specify a level in the sphere tree (used to
	/// retrieve the hierarchy of the tree). Note that null pointers can
	/// be returned if the request is not consistent with the state of
	/// the sphere tree.
	/// </summary>
	public IntPtr GetCellSpheres()
	{
		return vtkSphereTree_GetCellSpheres_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTree_GetDataSet_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the dataset from which to build the sphere tree.
	/// </summary>
	public virtual vtkDataSet GetDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereTree_GetDataSet_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTree_GetMaxLevel_08(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of levels for the tree. By default, the
	/// number of levels is set to ten. If the number of levels is set to one or
	/// less, then no hierarchy is built (i.e., just the spheres for each cell
	/// are created). Note that the actual level of the tree may be less than
	/// this value depending on the number of cells and Resolution factor.
	/// </summary>
	public virtual int GetMaxLevel()
	{
		return vtkSphereTree_GetMaxLevel_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTree_GetMaxLevelMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of levels for the tree. By default, the
	/// number of levels is set to ten. If the number of levels is set to one or
	/// less, then no hierarchy is built (i.e., just the spheres for each cell
	/// are created). Note that the actual level of the tree may be less than
	/// this value depending on the number of cells and Resolution factor.
	/// </summary>
	public virtual int GetMaxLevelMaxValue()
	{
		return vtkSphereTree_GetMaxLevelMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTree_GetMaxLevelMinValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of levels for the tree. By default, the
	/// number of levels is set to ten. If the number of levels is set to one or
	/// less, then no hierarchy is built (i.e., just the spheres for each cell
	/// are created). Note that the actual level of the tree may be less than
	/// this value depending on the number of cells and Resolution factor.
	/// </summary>
	public virtual int GetMaxLevelMinValue()
	{
		return vtkSphereTree_GetMaxLevelMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereTree_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphereTree_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereTree_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphereTree_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTree_GetNumberOfLevels_13(HandleRef pThis);

	/// <summary>
	/// Get the current depth of the sphere tree. This value may change each
	/// time the sphere tree is built and the branching factor (i.e.,
	/// resolution) changes. Note that after building the sphere tree there are
	/// [0,this-&gt;NumberOfLevels) defined levels.
	/// </summary>
	public virtual int GetNumberOfLevels()
	{
		return vtkSphereTree_GetNumberOfLevels_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTree_GetResolution_14(HandleRef pThis);

	/// <summary>
	/// Sphere tree creation requires gathering spheres into groups. The
	/// Resolution variable is a rough guide to the size of each group (the size
	/// different meanings depending on the type of data (structured versus
	/// unstructured). For example, in 3D structured data, blocks of resolution
	/// Resolution^3 are created. By default the Resolution is three.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkSphereTree_GetResolution_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTree_GetResolutionMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Sphere tree creation requires gathering spheres into groups. The
	/// Resolution variable is a rough guide to the size of each group (the size
	/// different meanings depending on the type of data (structured versus
	/// unstructured). For example, in 3D structured data, blocks of resolution
	/// Resolution^3 are created. By default the Resolution is three.
	/// </summary>
	public virtual int GetResolutionMaxValue()
	{
		return vtkSphereTree_GetResolutionMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTree_GetResolutionMinValue_16(HandleRef pThis);

	/// <summary>
	/// Sphere tree creation requires gathering spheres into groups. The
	/// Resolution variable is a rough guide to the size of each group (the size
	/// different meanings depending on the type of data (structured versus
	/// unstructured). For example, in 3D structured data, blocks of resolution
	/// Resolution^3 are created. By default the Resolution is three.
	/// </summary>
	public virtual int GetResolutionMinValue()
	{
		return vtkSphereTree_GetResolutionMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTree_GetTreeSpheres_17(HandleRef pThis, int level, ref long numSpheres);

	/// <summary>
	/// Special methods to retrieve the sphere tree data. This is
	/// generally used for debugging or with filters like
	/// vtkSphereTreeFilter. Both methods return an array of double*
	/// where four doubles represent a sphere (center + radius). In the
	/// first method a sphere per cell is returned. In the second method
	/// the user must also specify a level in the sphere tree (used to
	/// retrieve the hierarchy of the tree). Note that null pointers can
	/// be returned if the request is not consistent with the state of
	/// the sphere tree.
	/// </summary>
	public IntPtr GetTreeSpheres(int level, ref long numSpheres)
	{
		return vtkSphereTree_GetTreeSpheres_17(GetCppThis(), level, ref numSpheres);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTree_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphereTree_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereTree_IsTypeOf_19(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphereTree_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTree_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new vtkSphereTree NewInstance()
	{
		vtkSphereTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereTree_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTree_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static vtkSphereTree SafeDownCast(vtkObjectBase o)
	{
		vtkSphereTree vtkSphereTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereTree_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereTree2 = (vtkSphereTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereTree2.Register(null);
			}
		}
		return vtkSphereTree2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTree_SelectLine_23(HandleRef pThis, IntPtr origin, IntPtr ray, ref long numSelected);

	/// <summary>
	/// Methods for cell selection based on a geometric query. Internally
	/// different methods are used depending on the dataset type. The array
	/// returned is set to non-zero for each cell that intersects the geometric
	/// entity. SelectPoint marks all cells with a non-zero value that may
	/// contain a point. SelectLine marks all cells that may intersect an
	/// infinite line. SelectPlane marks all cells that may intersect with an
	/// infinite plane.
	/// </summary>
	public IntPtr SelectLine(IntPtr origin, IntPtr ray, ref long numSelected)
	{
		return vtkSphereTree_SelectLine_23(GetCppThis(), origin, ray, ref numSelected);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_SelectLine_24(HandleRef pThis, IntPtr origin, IntPtr ray, HandleRef cellIds);

	/// <summary>
	/// Methods for cell selection based on a geometric query. Internally
	/// different methods are used depending on the dataset type. The method
	/// pupulates an vtkIdList with cell ids that may satisfy the geometric
	/// query (the user must provide a vtkLdList which the methods fill in).
	/// SelectPoint lists all cells with a non-zero value that may contain a
	/// point. SelectLine lists all cells that may intersect an infinite
	/// line. SelectPlane lists all cells that may intersect with an infinite
	/// plane.
	/// </summary>
	public void SelectLine(IntPtr origin, IntPtr ray, vtkIdList cellIds)
	{
		vtkSphereTree_SelectLine_24(GetCppThis(), origin, ray, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTree_SelectPlane_25(HandleRef pThis, IntPtr origin, IntPtr normal, ref long numSelected);

	/// <summary>
	/// Methods for cell selection based on a geometric query. Internally
	/// different methods are used depending on the dataset type. The array
	/// returned is set to non-zero for each cell that intersects the geometric
	/// entity. SelectPoint marks all cells with a non-zero value that may
	/// contain a point. SelectLine marks all cells that may intersect an
	/// infinite line. SelectPlane marks all cells that may intersect with an
	/// infinite plane.
	/// </summary>
	public IntPtr SelectPlane(IntPtr origin, IntPtr normal, ref long numSelected)
	{
		return vtkSphereTree_SelectPlane_25(GetCppThis(), origin, normal, ref numSelected);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_SelectPlane_26(HandleRef pThis, IntPtr origin, IntPtr normal, HandleRef cellIds);

	/// <summary>
	/// Methods for cell selection based on a geometric query. Internally
	/// different methods are used depending on the dataset type. The method
	/// pupulates an vtkIdList with cell ids that may satisfy the geometric
	/// query (the user must provide a vtkLdList which the methods fill in).
	/// SelectPoint lists all cells with a non-zero value that may contain a
	/// point. SelectLine lists all cells that may intersect an infinite
	/// line. SelectPlane lists all cells that may intersect with an infinite
	/// plane.
	/// </summary>
	public void SelectPlane(IntPtr origin, IntPtr normal, vtkIdList cellIds)
	{
		vtkSphereTree_SelectPlane_26(GetCppThis(), origin, normal, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereTree_SelectPoint_27(HandleRef pThis, IntPtr point, ref long numSelected);

	/// <summary>
	/// Methods for cell selection based on a geometric query. Internally
	/// different methods are used depending on the dataset type. The array
	/// returned is set to non-zero for each cell that intersects the geometric
	/// entity. SelectPoint marks all cells with a non-zero value that may
	/// contain a point. SelectLine marks all cells that may intersect an
	/// infinite line. SelectPlane marks all cells that may intersect with an
	/// infinite plane.
	/// </summary>
	public IntPtr SelectPoint(IntPtr point, ref long numSelected)
	{
		return vtkSphereTree_SelectPoint_27(GetCppThis(), point, ref numSelected);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_SelectPoint_28(HandleRef pThis, IntPtr point, HandleRef cellIds);

	/// <summary>
	/// Methods for cell selection based on a geometric query. Internally
	/// different methods are used depending on the dataset type. The method
	/// pupulates an vtkIdList with cell ids that may satisfy the geometric
	/// query (the user must provide a vtkLdList which the methods fill in).
	/// SelectPoint lists all cells with a non-zero value that may contain a
	/// point. SelectLine lists all cells that may intersect an infinite
	/// line. SelectPlane lists all cells that may intersect with an infinite
	/// plane.
	/// </summary>
	public void SelectPoint(IntPtr point, vtkIdList cellIds)
	{
		vtkSphereTree_SelectPoint_28(GetCppThis(), point, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_SetBuildHierarchy_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Control whether the tree hierarchy is built. If not, then just
	/// cell spheres are created (one for each cell).
	/// </summary>
	public virtual void SetBuildHierarchy(bool _arg)
	{
		vtkSphereTree_SetBuildHierarchy_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_SetDataSet_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the dataset from which to build the sphere tree.
	/// </summary>
	public virtual void SetDataSet(vtkDataSet arg0)
	{
		vtkSphereTree_SetDataSet_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_SetMaxLevel_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the maximum number of levels for the tree. By default, the
	/// number of levels is set to ten. If the number of levels is set to one or
	/// less, then no hierarchy is built (i.e., just the spheres for each cell
	/// are created). Note that the actual level of the tree may be less than
	/// this value depending on the number of cells and Resolution factor.
	/// </summary>
	public virtual void SetMaxLevel(int _arg)
	{
		vtkSphereTree_SetMaxLevel_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereTree_SetResolution_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Sphere tree creation requires gathering spheres into groups. The
	/// Resolution variable is a rough guide to the size of each group (the size
	/// different meanings depending on the type of data (structured versus
	/// unstructured). For example, in 3D structured data, blocks of resolution
	/// Resolution^3 are created. By default the Resolution is three.
	/// </summary>
	public virtual void SetResolution(int _arg)
	{
		vtkSphereTree_SetResolution_32(GetCppThis(), _arg);
	}
}
