using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIncrementalPointLocator
/// </summary>
/// <remarks>
///    Abstract class in support of both
///  point location and point insertion.
///
///
///  Compared to a static point locator for pure location functionalities
///  through some search structure established from a fixed set of points,
///  an incremental point locator allows for, in addition, point insertion
///  capabilities, with the search structure maintaining a dynamically
///  increasing number of points. There are two incremental point locators,
///  i.e., vtkPointLocator and vtkIncrementalOctreePointLocator. As opposed
///  to the uniform bin-based search structure (adopted in vtkPointLocator)
///  with a fixed spatial resolution, an octree mechanism (employed in
///  vtkIncrementalOctreePointlocator) resorts to a hierarchy of tree-like
///  sub-division of the 3D data domain. Thus it enables data-aware multi-
///  resolution and accordingly accelerated point location as well as point
///  insertion, particularly when handling a radically imbalanced layout of
///  points as not uncommon in datasets defined on adaptive meshes. In other
///  words, vtkIncrementalOctreePointLocator is an octree-based accelerated
///  implementation of all functionalities of vtkPointLocator.
///
/// </remarks>
/// <seealso>
///
///  vtkLocator, vtkIncrementalOctreePointLocator, vtkPointLocator,
///  vtkMergePoints vtkStaticPointLocator
/// </seealso>
public abstract class vtkIncrementalPointLocator : vtkAbstractPointLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalPointLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIncrementalPointLocator()
	{
		MRClassNameKey = "class vtkIncrementalPointLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalPointLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIncrementalPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkIncrementalPointLocator_FindClosestInsertedPoint_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a point x assumed to be covered by the search structure, return the
	/// index of the closest point (already inserted to the search structure)
	/// regardless of the associated minimum squared distance relative to the
	/// squared insertion-tolerance distance. This method is used when performing
	/// incremental point insertion. Note -1 indicates that no point is found.
	/// InitPointInsertion() should have been called in advance.
	/// </summary>
	public virtual long FindClosestInsertedPoint(IntPtr x)
	{
		return vtkIncrementalPointLocator_FindClosestInsertedPoint_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalPointLocator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIncrementalPointLocator_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalPointLocator_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIncrementalPointLocator_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalPointLocator_InitPointInsertion_04(HandleRef pThis, HandleRef newPts, IntPtr bounds);

	/// <summary>
	/// Initialize the point insertion process. newPts is an object, storing 3D
	/// point coordinates, to which incremental point insertion puts coordinates.
	/// It is created and provided by an external VTK class. Argument bounds
	/// represents the spatial bounding box, into which the points fall.
	/// </summary>
	public virtual int InitPointInsertion(vtkPoints newPts, IntPtr bounds)
	{
		return vtkIncrementalPointLocator_InitPointInsertion_04(GetCppThis(), newPts?.GetCppThis() ?? default(HandleRef), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalPointLocator_InitPointInsertion_05(HandleRef pThis, HandleRef newPts, IntPtr bounds, long estSize);

	/// <summary>
	/// Initialize the point insertion process. newPts is an object, storing 3D
	/// point coordinates, to which incremental point insertion puts coordinates.
	/// It is created and provided by an external VTK class. Argument bounds
	/// represents the spatial bounding box, into which the points fall.
	/// </summary>
	public virtual int InitPointInsertion(vtkPoints newPts, IntPtr bounds, long estSize)
	{
		return vtkIncrementalPointLocator_InitPointInsertion_05(GetCppThis(), newPts?.GetCppThis() ?? default(HandleRef), bounds, estSize);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalPointLocator_InsertNextPoint_06(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Insert a given point and return the point index. InitPointInsertion()
	/// should have been called prior to this function. Also, IsInsertedPoint()
	/// should have been called in advance to ensure that the given point has not
	/// been inserted unless point duplication is allowed.
	/// </summary>
	public virtual long InsertNextPoint(IntPtr x)
	{
		return vtkIncrementalPointLocator_InsertNextPoint_06(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalPointLocator_InsertPoint_07(HandleRef pThis, long ptId, IntPtr x);

	/// <summary>
	/// Insert a given point with a specified point index ptId. InitPointInsertion()
	/// should have been called prior to this function. Also, IsInsertedPoint()
	/// should have been called in advance to ensure that the given point has not
	/// been inserted unless point duplication is allowed.
	/// </summary>
	public virtual void InsertPoint(long ptId, IntPtr x)
	{
		vtkIncrementalPointLocator_InsertPoint_07(GetCppThis(), ptId, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalPointLocator_InsertUniquePoint_08(HandleRef pThis, IntPtr x, ref long ptId);

	/// <summary>
	/// Insert a point unless there has been a duplicate in the search structure.
	/// Return 0 if the point was already in the list, otherwise return 1. If the
	/// point was not in the list, it will be ADDED.  In either case, the id of
	/// the point (newly inserted or not) is returned in the ptId argument.
	/// This method is not thread safe.
	/// </summary>
	public virtual int InsertUniquePoint(IntPtr x, ref long ptId)
	{
		return vtkIncrementalPointLocator_InsertUniquePoint_08(GetCppThis(), x, ref ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalPointLocator_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIncrementalPointLocator_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalPointLocator_IsInsertedPoint_10(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Determine whether or not a given point has been inserted. Return the id of
	/// the already inserted point if true, else return -1. InitPointInsertion()
	/// should have been called in advance.
	/// </summary>
	public virtual long IsInsertedPoint(double x, double y, double z)
	{
		return vtkIncrementalPointLocator_IsInsertedPoint_10(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalPointLocator_IsInsertedPoint_11(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Determine whether or not a given point has been inserted. Return the id of
	/// the already inserted point if true, else return -1. InitPointInsertion()
	/// should have been called in advance.
	/// </summary>
	public virtual long IsInsertedPoint(IntPtr x)
	{
		return vtkIncrementalPointLocator_IsInsertedPoint_11(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalPointLocator_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIncrementalPointLocator_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalPointLocator_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIncrementalPointLocator NewInstance()
	{
		vtkIncrementalPointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalPointLocator_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalPointLocator_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIncrementalPointLocator SafeDownCast(vtkObjectBase o)
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalPointLocator_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
}
