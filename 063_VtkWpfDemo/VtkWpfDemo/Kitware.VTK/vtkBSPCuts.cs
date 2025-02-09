using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBSPCuts
/// </summary>
/// <remarks>
///    This class represents an axis-aligned Binary Spatial
///    Partitioning of a 3D space.
///
///
///    This class converts between the vtkKdTree
///    representation of a tree of vtkKdNodes (used by vtkDistributedDataFilter)
///    and a compact array representation that might be provided by a
///    graph partitioning library like Zoltan.  Such a representation
///    could be used in message passing.
///
/// </remarks>
/// <seealso>
///
///      vtkKdTree vtkKdNode vtkDistributedDataFilter
/// </seealso>
public class vtkBSPCuts : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBSPCuts";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBSPCuts()
	{
		MRClassNameKey = "class vtkBSPCuts";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBSPCuts"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBSPCuts(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPCuts_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBSPCuts New()
	{
		vtkBSPCuts result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPCuts_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBSPCuts()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBSPCuts_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBSPCuts_CreateCuts_01(HandleRef pThis, IntPtr bounds, int ncuts, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints);

	/// <summary>
	/// Initialize the cuts with arrays of information.  This type of
	/// information would be obtained from a graph partitioning software
	/// package like Zoltan.
	///
	/// bounds - the bounds (xmin, xmax, ymin, ymax, zmin, zmax) of the
	/// space being partitioned
	/// ncuts - the number cuts, also the size of the following arrays
	/// dim   - the dimension along which the cut is made (x/y/z - 0/1/2)
	/// coord - the location of the cut along the axis
	/// lower - array index for the lower region bounded by the cut
	/// upper - array index for the upper region bounded by the cut
	/// lowerDataCoord - optional upper bound of the data in the lower region
	/// upperDataCoord - optional lower bound of the data in the upper region
	/// npoints - optional number of points in the spatial region
	/// </summary>
	public void CreateCuts(IntPtr bounds, int ncuts, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints)
	{
		vtkBSPCuts_CreateCuts_01(GetCppThis(), bounds, ncuts, dim, coord, lower, upper, lowerDataCoord, upperDataCoord, npoints);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSPCuts_CreateCuts_02(HandleRef pThis, HandleRef kd);

	/// <summary>
	/// Initialize the cuts from a tree of vtkKdNode's
	/// </summary>
	public void CreateCuts(vtkKdNode kd)
	{
		vtkBSPCuts_CreateCuts_02(GetCppThis(), kd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSPCuts_DeepCopy_03(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow copy.  These copy the data, but not any of the
	/// pipeline connections.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkBSPCuts_DeepCopy_03(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPCuts_Equals_04(HandleRef pThis, HandleRef other, double tolerance);

	/// <summary>
	/// Compare these cuts with those of the other tree.  Returns true if
	/// the two trees are the same.
	/// </summary>
	public int EqualsWrapper(vtkBSPCuts other, double tolerance)
	{
		return vtkBSPCuts_Equals_04(GetCppThis(), other?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPCuts_GetArrays_05(HandleRef pThis, int len, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints);

	/// <summary>
	/// Get the arrays representing the cuts in the partitioning.
	/// </summary>
	public int GetArrays(int len, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints)
	{
		return vtkBSPCuts_GetArrays_05(GetCppThis(), len, dim, coord, lower, upper, lowerDataCoord, upperDataCoord, npoints);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPCuts_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkBSPCuts GetData(vtkInformation info)
	{
		vtkBSPCuts vtkBSPCuts2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPCuts_GetData_06(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBSPCuts2 = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBSPCuts2.Register(null);
			}
		}
		return vtkBSPCuts2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPCuts_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkBSPCuts GetData(vtkInformationVector v, int i)
	{
		vtkBSPCuts vtkBSPCuts2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPCuts_GetData_07(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBSPCuts2 = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBSPCuts2.Register(null);
			}
		}
		return vtkBSPCuts2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPCuts_GetDataObjectType_08(HandleRef pThis);

	/// <summary>
	/// Returns VTK_BSP_CUTS.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkBSPCuts_GetDataObjectType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPCuts_GetKdNodeTree_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a tree of vtkKdNode's representing the cuts specified
	/// in this object.  This is our copy, don't delete it.
	/// </summary>
	public vtkKdNode GetKdNodeTree()
	{
		vtkKdNode vtkKdNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPCuts_GetKdNodeTree_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKdNode2 = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKdNode2.Register(null);
			}
		}
		return vtkKdNode2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPCuts_GetNumberOfCuts_10(HandleRef pThis);

	/// <summary>
	/// Get the number of cuts in the partitioning, which also the size of
	/// the arrays in the array representation of the partitioning.
	/// </summary>
	public virtual int GetNumberOfCuts()
	{
		return vtkBSPCuts_GetNumberOfCuts_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBSPCuts_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBSPCuts_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBSPCuts_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBSPCuts_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSPCuts_Initialize_13(HandleRef pThis);

	/// <summary>
	/// Restore data object to initial state,
	/// </summary>
	public override void Initialize()
	{
		vtkBSPCuts_Initialize_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPCuts_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBSPCuts_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPCuts_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBSPCuts_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPCuts_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBSPCuts NewInstance()
	{
		vtkBSPCuts result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPCuts_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSPCuts_PrintArrays_18(HandleRef pThis);

	/// <summary>
	/// Compare these cuts with those of the other tree.  Returns true if
	/// the two trees are the same.
	/// </summary>
	public void PrintArrays()
	{
		vtkBSPCuts_PrintArrays_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSPCuts_PrintTree_19(HandleRef pThis);

	/// <summary>
	/// Compare these cuts with those of the other tree.  Returns true if
	/// the two trees are the same.
	/// </summary>
	public void PrintTree()
	{
		vtkBSPCuts_PrintTree_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPCuts_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBSPCuts SafeDownCast(vtkObjectBase o)
	{
		vtkBSPCuts vtkBSPCuts2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPCuts_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBSPCuts2 = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBSPCuts2.Register(null);
			}
		}
		return vtkBSPCuts2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSPCuts_ShallowCopy_21(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow copy.  These copy the data, but not any of the
	/// pipeline connections.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkBSPCuts_ShallowCopy_21(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}
}
