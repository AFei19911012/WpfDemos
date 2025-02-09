using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtentRCBPartitioner
/// </summary>
/// <remarks>
///    This method partitions a global extent to N partitions where N is a user
///  supplied parameter.
/// </remarks>
public class vtkExtentRCBPartitioner : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtentRCBPartitioner";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtentRCBPartitioner()
	{
		MRClassNameKey = "class vtkExtentRCBPartitioner";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtentRCBPartitioner"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtentRCBPartitioner(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentRCBPartitioner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtentRCBPartitioner New()
	{
		vtkExtentRCBPartitioner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentRCBPartitioner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtentRCBPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtentRCBPartitioner()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtentRCBPartitioner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtentRCBPartitioner_DuplicateNodesOff_01(HandleRef pThis);

	/// <summary>
	/// On/Off DuplicateNodes between partitions. Default is On.
	/// </summary>
	public virtual void DuplicateNodesOff()
	{
		vtkExtentRCBPartitioner_DuplicateNodesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentRCBPartitioner_DuplicateNodesOn_02(HandleRef pThis);

	/// <summary>
	/// On/Off DuplicateNodes between partitions. Default is On.
	/// </summary>
	public virtual void DuplicateNodesOn()
	{
		vtkExtentRCBPartitioner_DuplicateNodesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentRCBPartitioner_GetDuplicateNodes_03(HandleRef pThis);

	/// <summary>
	/// On/Off DuplicateNodes between partitions. Default is On.
	/// </summary>
	public virtual int GetDuplicateNodes()
	{
		return vtkExtentRCBPartitioner_GetDuplicateNodes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentRCBPartitioner_GetNumExtents_04(HandleRef pThis);

	/// <summary>
	/// Returns the number of extents.
	/// </summary>
	public virtual int GetNumExtents()
	{
		return vtkExtentRCBPartitioner_GetNumExtents_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtentRCBPartitioner_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtentRCBPartitioner_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtentRCBPartitioner_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtentRCBPartitioner_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentRCBPartitioner_GetNumberOfGhostLayers_07(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual int GetNumberOfGhostLayers()
	{
		return vtkExtentRCBPartitioner_GetNumberOfGhostLayers_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentRCBPartitioner_GetPartitionExtent_08(HandleRef pThis, int idx, IntPtr ext);

	/// <summary>
	/// Returns the extent of the partition corresponding to the given ID.
	/// </summary>
	public void GetPartitionExtent(int idx, IntPtr ext)
	{
		vtkExtentRCBPartitioner_GetPartitionExtent_08(GetCppThis(), idx, ext);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentRCBPartitioner_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtentRCBPartitioner_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtentRCBPartitioner_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtentRCBPartitioner_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentRCBPartitioner_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtentRCBPartitioner NewInstance()
	{
		vtkExtentRCBPartitioner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentRCBPartitioner_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtentRCBPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentRCBPartitioner_Partition_13(HandleRef pThis);

	/// <summary>
	/// Partitions the extent
	/// </summary>
	public void Partition()
	{
		vtkExtentRCBPartitioner_Partition_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtentRCBPartitioner_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtentRCBPartitioner SafeDownCast(vtkObjectBase o)
	{
		vtkExtentRCBPartitioner vtkExtentRCBPartitioner2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtentRCBPartitioner_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtentRCBPartitioner2 = (vtkExtentRCBPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtentRCBPartitioner2.Register(null);
			}
		}
		return vtkExtentRCBPartitioner2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentRCBPartitioner_SetDuplicateNodes_15(HandleRef pThis, int _arg);

	/// <summary>
	/// On/Off DuplicateNodes between partitions. Default is On.
	/// </summary>
	public virtual void SetDuplicateNodes(int _arg)
	{
		vtkExtentRCBPartitioner_SetDuplicateNodes_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentRCBPartitioner_SetGlobalExtent_16(HandleRef pThis, int imin, int imax, int jmin, int jmax, int kmin, int kmax);

	/// <summary>
	/// Set/Get the global extent array to be partitioned.
	/// The global extent is packed as follows:
	/// [imin,imax,jmin,jmax,kmin,kmax]
	/// </summary>
	public void SetGlobalExtent(int imin, int imax, int jmin, int jmax, int kmin, int kmax)
	{
		vtkExtentRCBPartitioner_SetGlobalExtent_16(GetCppThis(), imin, imax, jmin, jmax, kmin, kmax);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentRCBPartitioner_SetGlobalExtent_17(HandleRef pThis, IntPtr ext);

	/// <summary>
	/// Set/Get the global extent array to be partitioned.
	/// The global extent is packed as follows:
	/// [imin,imax,jmin,jmax,kmin,kmax]
	/// </summary>
	public void SetGlobalExtent(IntPtr ext)
	{
		vtkExtentRCBPartitioner_SetGlobalExtent_17(GetCppThis(), ext);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentRCBPartitioner_SetNumberOfGhostLayers_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void SetNumberOfGhostLayers(int _arg)
	{
		vtkExtentRCBPartitioner_SetNumberOfGhostLayers_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtentRCBPartitioner_SetNumberOfPartitions_19(HandleRef pThis, int N);

	/// <summary>
	/// Set/Get the number of requested partitions
	/// </summary>
	public void SetNumberOfPartitions(int N)
	{
		vtkExtentRCBPartitioner_SetNumberOfPartitions_19(GetCppThis(), N);
	}
}
