using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkReverseSense
/// </summary>
/// <remarks>
///    reverse the ordering of polygonal cells and/or vertex normals
///
///
/// vtkReverseSense is a filter that reverses the order of polygonal cells
/// and/or reverses the direction of point and cell normals. Two flags are
/// used to control these operations. Cell reversal means reversing the order
/// of indices in the cell connectivity list. Normal reversal means
/// multiplying the normal vector by -1 (both point and cell normals,
/// if present).
///
/// @warning
/// Normals can be operated on only if they are present in the data.
/// </remarks>
public class vtkReverseSense : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkReverseSense";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkReverseSense()
	{
		MRClassNameKey = "class vtkReverseSense";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkReverseSense"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkReverseSense(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReverseSense_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object so that behavior is to reverse cell ordering and
	/// leave normal orientation as is.
	/// </summary>
	public new static vtkReverseSense New()
	{
		vtkReverseSense result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReverseSense_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReverseSense)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object so that behavior is to reverse cell ordering and
	/// leave normal orientation as is.
	/// </summary>
	public vtkReverseSense()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkReverseSense_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReverseSense_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkReverseSense_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReverseSense_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkReverseSense_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReverseSense_GetReverseCells_03(HandleRef pThis);

	/// <summary>
	/// Flag controls whether to reverse cell ordering.
	/// </summary>
	public virtual int GetReverseCells()
	{
		return vtkReverseSense_GetReverseCells_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReverseSense_GetReverseNormals_04(HandleRef pThis);

	/// <summary>
	/// Flag controls whether to reverse normal orientation.
	/// </summary>
	public virtual int GetReverseNormals()
	{
		return vtkReverseSense_GetReverseNormals_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReverseSense_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkReverseSense_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReverseSense_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkReverseSense_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReverseSense_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkReverseSense NewInstance()
	{
		vtkReverseSense result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReverseSense_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReverseSense)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReverseSense_ReverseCellsOff_09(HandleRef pThis);

	/// <summary>
	/// Flag controls whether to reverse cell ordering.
	/// </summary>
	public virtual void ReverseCellsOff()
	{
		vtkReverseSense_ReverseCellsOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReverseSense_ReverseCellsOn_10(HandleRef pThis);

	/// <summary>
	/// Flag controls whether to reverse cell ordering.
	/// </summary>
	public virtual void ReverseCellsOn()
	{
		vtkReverseSense_ReverseCellsOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReverseSense_ReverseNormalsOff_11(HandleRef pThis);

	/// <summary>
	/// Flag controls whether to reverse normal orientation.
	/// </summary>
	public virtual void ReverseNormalsOff()
	{
		vtkReverseSense_ReverseNormalsOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReverseSense_ReverseNormalsOn_12(HandleRef pThis);

	/// <summary>
	/// Flag controls whether to reverse normal orientation.
	/// </summary>
	public virtual void ReverseNormalsOn()
	{
		vtkReverseSense_ReverseNormalsOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReverseSense_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReverseSense SafeDownCast(vtkObjectBase o)
	{
		vtkReverseSense vtkReverseSense2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReverseSense_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkReverseSense2 = (vtkReverseSense)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkReverseSense2.Register(null);
			}
		}
		return vtkReverseSense2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReverseSense_SetReverseCells_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Flag controls whether to reverse cell ordering.
	/// </summary>
	public virtual void SetReverseCells(int _arg)
	{
		vtkReverseSense_SetReverseCells_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReverseSense_SetReverseNormals_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Flag controls whether to reverse normal orientation.
	/// </summary>
	public virtual void SetReverseNormals(int _arg)
	{
		vtkReverseSense_SetReverseNormals_15(GetCppThis(), _arg);
	}
}
