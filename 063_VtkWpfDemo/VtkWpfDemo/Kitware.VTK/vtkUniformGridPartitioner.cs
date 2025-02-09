using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUniformGridPartitioner
///
///
///  A concrete implementation of vtkMultiBlockDataSetAlgorithm that provides
///  functionality for partitioning a uniform grid. The partitioning method
///  that is used is Recursive Coordinate Bisection (RCB) where each time
///  the longest dimension is split.
///
/// </summary>
/// <seealso>
///
/// vtkStructuredGridPartitioner vtkRectilinearGridPartitioner
/// </seealso>
public class vtkUniformGridPartitioner : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGridPartitioner";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUniformGridPartitioner()
	{
		MRClassNameKey = "class vtkUniformGridPartitioner";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGridPartitioner"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUniformGridPartitioner(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridPartitioner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUniformGridPartitioner New()
	{
		vtkUniformGridPartitioner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridPartitioner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniformGridPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUniformGridPartitioner()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUniformGridPartitioner_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkUniformGridPartitioner_DuplicateNodesOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void DuplicateNodesOff()
	{
		vtkUniformGridPartitioner_DuplicateNodesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridPartitioner_DuplicateNodesOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void DuplicateNodesOn()
	{
		vtkUniformGridPartitioner_DuplicateNodesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridPartitioner_GetDuplicateNodes_03(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual int GetDuplicateNodes()
	{
		return vtkUniformGridPartitioner_GetDuplicateNodes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniformGridPartitioner_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUniformGridPartitioner_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniformGridPartitioner_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUniformGridPartitioner_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridPartitioner_GetNumberOfGhostLayers_06(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual int GetNumberOfGhostLayers()
	{
		return vtkUniformGridPartitioner_GetNumberOfGhostLayers_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridPartitioner_GetNumberOfPartitions_07(HandleRef pThis);

	/// <summary>
	/// Set/Get macro for the number of subdivisions.
	/// </summary>
	public virtual int GetNumberOfPartitions()
	{
		return vtkUniformGridPartitioner_GetNumberOfPartitions_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridPartitioner_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUniformGridPartitioner_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridPartitioner_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUniformGridPartitioner_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridPartitioner_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUniformGridPartitioner NewInstance()
	{
		vtkUniformGridPartitioner result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridPartitioner_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniformGridPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridPartitioner_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUniformGridPartitioner SafeDownCast(vtkObjectBase o)
	{
		vtkUniformGridPartitioner vtkUniformGridPartitioner2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridPartitioner_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGridPartitioner2 = (vtkUniformGridPartitioner)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGridPartitioner2.Register(null);
			}
		}
		return vtkUniformGridPartitioner2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridPartitioner_SetDuplicateNodes_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void SetDuplicateNodes(int _arg)
	{
		vtkUniformGridPartitioner_SetDuplicateNodes_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridPartitioner_SetNumberOfGhostLayers_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get macro for the number of ghost layers.
	/// </summary>
	public virtual void SetNumberOfGhostLayers(int _arg)
	{
		vtkUniformGridPartitioner_SetNumberOfGhostLayers_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridPartitioner_SetNumberOfPartitions_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get macro for the number of subdivisions.
	/// </summary>
	public virtual void SetNumberOfPartitions(int _arg)
	{
		vtkUniformGridPartitioner_SetNumberOfPartitions_15(GetCppThis(), _arg);
	}
}
