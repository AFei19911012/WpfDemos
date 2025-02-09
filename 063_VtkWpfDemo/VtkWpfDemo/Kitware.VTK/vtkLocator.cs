using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLocator
/// </summary>
/// <remarks>
///    abstract base class for objects that accelerate spatial searches
///
/// vtkLocator is an abstract base class for spatial search objects, or
/// locators. The principle behind locators is that they divide 3-space into
/// small regions (or "buckets") that can be quickly found in response to
/// queries about point location, line intersection, or object-object
/// intersection.
///
/// The purpose of this base class is to provide data members and methods
/// shared by all locators. The GenerateRepresentation() is one such
/// interesting method.  This method works in conjunction with
/// vtkLocatorFilter to create polygonal representations for the locator. For
/// example, if the locator is an OBB tree (i.e., vtkOBBTree.h), then the
/// representation is a set of one or more oriented bounding boxes, depending
/// upon the specified level.
///
/// Locators typically work as follows. One or more "entities", such as points
/// or cells, are inserted into the locator structure. These entities are
/// associated with one or more buckets. Then, when performing geometric
/// operations, the operations are performed first on the buckets, and then if
/// the operation tests positive, then on the entities in the bucket. For
/// example, during collision tests, the locators are collided first to
/// identify intersecting buckets. If an intersection is found, more expensive
/// operations are then carried out on the entities in the bucket.
///
/// To obtain good performance, locators are often organized in a tree
/// structure.  In such a structure, there are frequently multiple "levels"
/// corresponding to different nodes in the tree. So the word level (in the
/// context of the locator) can be used to specify a particular representation
/// in the tree.  For example, in an octree (which is a tree with 8 children),
/// level 0 is the bounding box, or root octant, and level 1 consists of its
/// eight children.
///
/// @warning
/// There is a concept of static and incremental locators. Static locators are
/// constructed one time, and then support appropriate queries. Incremental
/// locators may have data inserted into them over time (e.g., adding new
/// points during the process of isocontouring).
///
/// </remarks>
/// <seealso>
///
/// vtkPointLocator vtkCellLocator vtkOBBTree vtkMergePoints
/// </seealso>
public abstract class vtkLocator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLocator()
	{
		MRClassNameKey = "class vtkLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkLocator_AutomaticOff_01(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether locator depth/resolution of locator is computed
	/// automatically from average number of entities in bucket. If not set,
	/// there will be an explicit method to control the construction of the
	/// locator (found in the subclass).
	/// </summary>
	public virtual void AutomaticOff()
	{
		vtkLocator_AutomaticOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_AutomaticOn_02(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether locator depth/resolution of locator is computed
	/// automatically from average number of entities in bucket. If not set,
	/// there will be an explicit method to control the construction of the
	/// locator (found in the subclass).
	/// </summary>
	public virtual void AutomaticOn()
	{
		vtkLocator_AutomaticOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_BuildLocator_03(HandleRef pThis);

	/// <summary>
	/// Build the locator from the input dataset. This will NOT do anything if
	/// UseExistingSearchStructure is on.
	/// </summary>
	public virtual void BuildLocator()
	{
		vtkLocator_BuildLocator_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_ForceBuildLocator_04(HandleRef pThis);

	/// <summary>
	/// Build the locator from the input dataset (even if UseExistingSearchStructure is on).
	///
	/// This function is not pure virtual to maintain backwards compatibility.
	/// </summary>
	public virtual void ForceBuildLocator()
	{
		vtkLocator_ForceBuildLocator_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_FreeSearchStructure_05(HandleRef pThis);

	/// <summary>
	/// Free the memory required for the spatial data structure.
	/// </summary>
	public virtual void FreeSearchStructure()
	{
		vtkLocator_FreeSearchStructure_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_GenerateRepresentation_06(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Method to build a representation at a particular level. Note that the
	/// method GetLevel() returns the maximum number of levels available for
	/// the tree. You must provide a vtkPolyData object into which to place the
	/// data.
	/// </summary>
	public virtual void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkLocator_GenerateRepresentation_06(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLocator_GetAutomatic_07(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether locator depth/resolution of locator is computed
	/// automatically from average number of entities in bucket. If not set,
	/// there will be an explicit method to control the construction of the
	/// locator (found in the subclass).
	/// </summary>
	public virtual int GetAutomatic()
	{
		return vtkLocator_GetAutomatic_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkLocator_GetBuildTime_08(HandleRef pThis);

	/// <summary>
	/// Return the time of the last data structure build.
	/// </summary>
	public virtual ulong GetBuildTime()
	{
		return vtkLocator_GetBuildTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLocator_GetDataSet_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Build the locator from the points/cells defining this dataset.
	/// </summary>
	public virtual vtkDataSet GetDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLocator_GetDataSet_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLocator_GetLevel_10(HandleRef pThis);

	/// <summary>
	/// Get the level of the locator (determined automatically if Automatic is
	/// true). The value of this ivar may change each time the locator is built.
	/// Initial value is 8.
	/// </summary>
	public virtual int GetLevel()
	{
		return vtkLocator_GetLevel_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLocator_GetMaxLevel_11(HandleRef pThis);

	/// <summary>
	/// Set the maximum allowable level for the tree. If the Automatic ivar is
	/// off, this will be the target depth of the locator.
	/// Initial value is 8.
	/// </summary>
	public virtual int GetMaxLevel()
	{
		return vtkLocator_GetMaxLevel_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLocator_GetMaxLevelMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set the maximum allowable level for the tree. If the Automatic ivar is
	/// off, this will be the target depth of the locator.
	/// Initial value is 8.
	/// </summary>
	public virtual int GetMaxLevelMaxValue()
	{
		return vtkLocator_GetMaxLevelMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLocator_GetMaxLevelMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set the maximum allowable level for the tree. If the Automatic ivar is
	/// off, this will be the target depth of the locator.
	/// Initial value is 8.
	/// </summary>
	public virtual int GetMaxLevelMinValue()
	{
		return vtkLocator_GetMaxLevelMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLocator_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLocator_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLocator_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLocator_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLocator_GetTolerance_16(HandleRef pThis);

	/// <summary>
	/// Specify absolute tolerance (in world coordinates) for performing
	/// geometric operations.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkLocator_GetTolerance_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLocator_GetToleranceMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Specify absolute tolerance (in world coordinates) for performing
	/// geometric operations.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkLocator_GetToleranceMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLocator_GetToleranceMinValue_18(HandleRef pThis);

	/// <summary>
	/// Specify absolute tolerance (in world coordinates) for performing
	/// geometric operations.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkLocator_GetToleranceMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLocator_GetUseExistingSearchStructure_19(HandleRef pThis);

	/// <summary>
	/// Get/Set UseExistingSearchStructure, which when enabled it allows the locator to NOT be
	/// built again. This is useful when you have a dataset that either changes because
	/// the FieldData (PointData/CellData) changed or the actual dataset object changed
	/// but it's actually the same geometry (useful when a dataset has timesteps).
	///
	/// When this flag is on you need to use ForceBuildLocator() to rebuild the locator,
	/// if your dataset changes.
	///
	/// Default is off.
	/// </summary>
	public virtual int GetUseExistingSearchStructure()
	{
		return vtkLocator_GetUseExistingSearchStructure_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_Initialize_20(HandleRef pThis);

	/// <summary>
	/// Initialize locator. Frees memory and resets object as appropriate.
	/// </summary>
	public virtual void Initialize()
	{
		vtkLocator_Initialize_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLocator_IsA_21(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLocator_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLocator_IsTypeOf_22(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLocator_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLocator_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new vtkLocator NewInstance()
	{
		vtkLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLocator_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLocator_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static vtkLocator SafeDownCast(vtkObjectBase o)
	{
		vtkLocator vtkLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLocator_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLocator2 = (vtkLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLocator2.Register(null);
			}
		}
		return vtkLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_SetAutomatic_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether locator depth/resolution of locator is computed
	/// automatically from average number of entities in bucket. If not set,
	/// there will be an explicit method to control the construction of the
	/// locator (found in the subclass).
	/// </summary>
	public virtual void SetAutomatic(int _arg)
	{
		vtkLocator_SetAutomatic_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_SetDataSet_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Build the locator from the points/cells defining this dataset.
	/// </summary>
	public virtual void SetDataSet(vtkDataSet arg0)
	{
		vtkLocator_SetDataSet_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_SetMaxLevel_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the maximum allowable level for the tree. If the Automatic ivar is
	/// off, this will be the target depth of the locator.
	/// Initial value is 8.
	/// </summary>
	public virtual void SetMaxLevel(int _arg)
	{
		vtkLocator_SetMaxLevel_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_SetTolerance_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify absolute tolerance (in world coordinates) for performing
	/// geometric operations.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkLocator_SetTolerance_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_SetUseExistingSearchStructure_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set UseExistingSearchStructure, which when enabled it allows the locator to NOT be
	/// built again. This is useful when you have a dataset that either changes because
	/// the FieldData (PointData/CellData) changed or the actual dataset object changed
	/// but it's actually the same geometry (useful when a dataset has timesteps).
	///
	/// When this flag is on you need to use ForceBuildLocator() to rebuild the locator,
	/// if your dataset changes.
	///
	/// Default is off.
	/// </summary>
	public virtual void SetUseExistingSearchStructure(int _arg)
	{
		vtkLocator_SetUseExistingSearchStructure_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_Update_30(HandleRef pThis);

	/// <summary>
	/// Cause the locator to rebuild itself if it or its input dataset has
	/// changed.
	/// </summary>
	public virtual void Update()
	{
		vtkLocator_Update_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_UseExistingSearchStructureOff_31(HandleRef pThis);

	/// <summary>
	/// Get/Set UseExistingSearchStructure, which when enabled it allows the locator to NOT be
	/// built again. This is useful when you have a dataset that either changes because
	/// the FieldData (PointData/CellData) changed or the actual dataset object changed
	/// but it's actually the same geometry (useful when a dataset has timesteps).
	///
	/// When this flag is on you need to use ForceBuildLocator() to rebuild the locator,
	/// if your dataset changes.
	///
	/// Default is off.
	/// </summary>
	public virtual void UseExistingSearchStructureOff()
	{
		vtkLocator_UseExistingSearchStructureOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLocator_UseExistingSearchStructureOn_32(HandleRef pThis);

	/// <summary>
	/// Get/Set UseExistingSearchStructure, which when enabled it allows the locator to NOT be
	/// built again. This is useful when you have a dataset that either changes because
	/// the FieldData (PointData/CellData) changed or the actual dataset object changed
	/// but it's actually the same geometry (useful when a dataset has timesteps).
	///
	/// When this flag is on you need to use ForceBuildLocator() to rebuild the locator,
	/// if your dataset changes.
	///
	/// Default is off.
	/// </summary>
	public virtual void UseExistingSearchStructureOn()
	{
		vtkLocator_UseExistingSearchStructureOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLocator_UsesGarbageCollector_33(HandleRef pThis);

	/// <summary>
	/// Handle the PointSet &lt;-&gt; Locator loop.
	/// </summary>
	public override bool UsesGarbageCollector()
	{
		return (vtkLocator_UsesGarbageCollector_33(GetCppThis()) != 0) ? true : false;
	}
}
