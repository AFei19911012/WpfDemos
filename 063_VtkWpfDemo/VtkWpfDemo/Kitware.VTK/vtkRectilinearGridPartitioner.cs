using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRectilinearGridPartitioner
///
///
///  A concrete implementation of vtkMultiBlockDataSetAlgorithm that provides
///  functionality for partitioning a VTK rectilinear dataset. The partitioning
///  method used is Recursive Coordinate Bisection (RCB) where each time the
///  longest dimension is split.
///
/// </summary>
/// <seealso>
///
///  vtkUniformGridPartitioner vtkStructuredGridPartitioner
/// </seealso>
public class vtkRectilinearGridPartitioner : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridPartitioner";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectilinearGridPartitioner()
	{
		MRClassNameKey = "class vtkRectilinearGridPartitioner";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridPartitioner"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectilinearGridPartitioner(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridPartitioner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGridPartitioner New()
	{
		vtkRectilinearGridPartitioner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridPartitioner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRectilinearGridPartitioner()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectilinearGridPartitioner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRectilinearGridPartitioner_DuplicateNodesOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void DuplicateNodesOff()
	{
		vtkRectilinearGridPartitioner_DuplicateNodesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridPartitioner_DuplicateNodesOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void DuplicateNodesOn()
	{
		vtkRectilinearGridPartitioner_DuplicateNodesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridPartitioner_GetDuplicateNodes_03(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual int GetDuplicateNodes()
	{
		return vtkRectilinearGridPartitioner_GetDuplicateNodes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGridPartitioner_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRectilinearGridPartitioner_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGridPartitioner_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRectilinearGridPartitioner_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridPartitioner_GetNumberOfGhostLayers_06(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual int GetNumberOfGhostLayers()
	{
		return vtkRectilinearGridPartitioner_GetNumberOfGhostLayers_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridPartitioner_GetNumberOfPartitions_07(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of subdivisions.
	/// </summary>
	public virtual int GetNumberOfPartitions()
	{
		return vtkRectilinearGridPartitioner_GetNumberOfPartitions_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridPartitioner_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRectilinearGridPartitioner_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridPartitioner_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRectilinearGridPartitioner_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridPartitioner_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRectilinearGridPartitioner NewInstance()
	{
		vtkRectilinearGridPartitioner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridPartitioner_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridPartitioner_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGridPartitioner SafeDownCast(vtkObjectBase o)
	{
		vtkRectilinearGridPartitioner vtkRectilinearGridPartitioner2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridPartitioner_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGridPartitioner2 = (vtkRectilinearGridPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGridPartitioner2.Register(null);
			}
		}
		return vtkRectilinearGridPartitioner2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridPartitioner_SetDuplicateNodes_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void SetDuplicateNodes(int _arg)
	{
		vtkRectilinearGridPartitioner_SetDuplicateNodes_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridPartitioner_SetNumberOfGhostLayers_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void SetNumberOfGhostLayers(int _arg)
	{
		vtkRectilinearGridPartitioner_SetNumberOfGhostLayers_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridPartitioner_SetNumberOfPartitions_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get macro for the number of subdivisions.
	/// </summary>
	public virtual void SetNumberOfPartitions(int _arg)
	{
		vtkRectilinearGridPartitioner_SetNumberOfPartitions_15(GetCppThis(), _arg);
	}
}
