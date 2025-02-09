using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStructuredGridPartitioner
///
///
///  A concrete implementation of vtkMultiBlockDataSetAlgorithm that provides
///  functionality for partitioning a VTK structured grid dataset. The partition-
///  ing method used is Recursive Coordinate Bisection (RCB) where each time the
///  longest dimension is split.
///
/// </summary>
/// <seealso>
///
///  vtkUniformGridPartitioner vtkRectilinearGridPartitioner
/// </seealso>
public class vtkStructuredGridPartitioner : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridPartitioner";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStructuredGridPartitioner()
	{
		MRClassNameKey = "class vtkStructuredGridPartitioner";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridPartitioner"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStructuredGridPartitioner(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridPartitioner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredGridPartitioner New()
	{
		vtkStructuredGridPartitioner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridPartitioner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredGridPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStructuredGridPartitioner()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStructuredGridPartitioner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridPartitioner_DuplicateNodesOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get &amp; boolean macro for the DuplicateNodes property.
	/// </summary>
	public virtual void DuplicateNodesOff()
	{
		vtkStructuredGridPartitioner_DuplicateNodesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridPartitioner_DuplicateNodesOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get &amp; boolean macro for the DuplicateNodes property.
	/// </summary>
	public virtual void DuplicateNodesOn()
	{
		vtkStructuredGridPartitioner_DuplicateNodesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridPartitioner_GetDuplicateNodes_03(HandleRef pThis);

	/// <summary>
	/// Set/Get &amp; boolean macro for the DuplicateNodes property.
	/// </summary>
	public virtual int GetDuplicateNodes()
	{
		return vtkStructuredGridPartitioner_GetDuplicateNodes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGridPartitioner_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStructuredGridPartitioner_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGridPartitioner_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStructuredGridPartitioner_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridPartitioner_GetNumberOfGhostLayers_06(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual int GetNumberOfGhostLayers()
	{
		return vtkStructuredGridPartitioner_GetNumberOfGhostLayers_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridPartitioner_GetNumberOfPartitions_07(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of subdivisions.
	/// </summary>
	public virtual int GetNumberOfPartitions()
	{
		return vtkStructuredGridPartitioner_GetNumberOfPartitions_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridPartitioner_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStructuredGridPartitioner_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridPartitioner_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStructuredGridPartitioner_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridPartitioner_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStructuredGridPartitioner NewInstance()
	{
		vtkStructuredGridPartitioner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridPartitioner_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredGridPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridPartitioner_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredGridPartitioner SafeDownCast(vtkObjectBase o)
	{
		vtkStructuredGridPartitioner vtkStructuredGridPartitioner2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridPartitioner_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGridPartitioner2 = (vtkStructuredGridPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGridPartitioner2.Register(null);
			}
		}
		return vtkStructuredGridPartitioner2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridPartitioner_SetDuplicateNodes_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get &amp; boolean macro for the DuplicateNodes property.
	/// </summary>
	public virtual void SetDuplicateNodes(int _arg)
	{
		vtkStructuredGridPartitioner_SetDuplicateNodes_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridPartitioner_SetNumberOfGhostLayers_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void SetNumberOfGhostLayers(int _arg)
	{
		vtkStructuredGridPartitioner_SetNumberOfGhostLayers_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridPartitioner_SetNumberOfPartitions_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get macro for the number of subdivisions.
	/// </summary>
	public virtual void SetNumberOfPartitions(int _arg)
	{
		vtkStructuredGridPartitioner_SetNumberOfPartitions_15(GetCppThis(), _arg);
	}
}
