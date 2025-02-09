using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSpherePuzzle
/// </summary>
/// <remarks>
///    create a polygonal sphere centered at the origin
///
/// vtkSpherePuzzle creates
/// </remarks>
public class vtkSpherePuzzle : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSpherePuzzle";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSpherePuzzle()
	{
		MRClassNameKey = "class vtkSpherePuzzle";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpherePuzzle"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSpherePuzzle(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpherePuzzle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSpherePuzzle New()
	{
		vtkSpherePuzzle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpherePuzzle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpherePuzzle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSpherePuzzle()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSpherePuzzle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpherePuzzle_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSpherePuzzle_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpherePuzzle_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSpherePuzzle_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpherePuzzle_GetState_03(HandleRef pThis);

	/// <summary>
	/// For drawing state as arrows.
	/// </summary>
	public IntPtr GetState()
	{
		return vtkSpherePuzzle_GetState_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpherePuzzle_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSpherePuzzle_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpherePuzzle_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSpherePuzzle_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpherePuzzle_MoveHorizontal_06(HandleRef pThis, int section, int percentage, int rightFlag);

	/// <summary>
	/// Move the top/bottom half one segment either direction.
	/// </summary>
	public void MoveHorizontal(int section, int percentage, int rightFlag)
	{
		vtkSpherePuzzle_MoveHorizontal_06(GetCppThis(), section, percentage, rightFlag);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpherePuzzle_MovePoint_07(HandleRef pThis, int percentage);

	/// <summary>
	/// Move actually implements the pending move. When percentage
	/// is 100, the pending move becomes inactive, and SetPoint
	/// will have to be called again to setup another move.
	/// </summary>
	public void MovePoint(int percentage)
	{
		vtkSpherePuzzle_MovePoint_07(GetCppThis(), percentage);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpherePuzzle_MoveVertical_08(HandleRef pThis, int section, int percentage, int rightFlag);

	/// <summary>
	/// Rotate vertical half of sphere along one of the longitude lines.
	/// </summary>
	public void MoveVertical(int section, int percentage, int rightFlag)
	{
		vtkSpherePuzzle_MoveVertical_08(GetCppThis(), section, percentage, rightFlag);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpherePuzzle_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSpherePuzzle NewInstance()
	{
		vtkSpherePuzzle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpherePuzzle_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpherePuzzle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpherePuzzle_Reset_11(HandleRef pThis);

	/// <summary>
	/// Reset the state of this puzzle back to its original state.
	/// </summary>
	public void Reset()
	{
		vtkSpherePuzzle_Reset_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpherePuzzle_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSpherePuzzle SafeDownCast(vtkObjectBase o)
	{
		vtkSpherePuzzle vtkSpherePuzzle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpherePuzzle_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpherePuzzle2 = (vtkSpherePuzzle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpherePuzzle2.Register(null);
			}
		}
		return vtkSpherePuzzle2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpherePuzzle_SetPoint_13(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// SetPoint will be called as the mouse moves over the screen.
	/// The output will change to indicate the pending move.
	/// SetPoint returns zero if move is not activated by point.
	/// Otherwise it encodes the move into a unique integer so that
	/// the caller can determine if the move state has changed.
	/// This will answer the question, "Should I render."
	/// </summary>
	public int SetPoint(double x, double y, double z)
	{
		return vtkSpherePuzzle_SetPoint_13(GetCppThis(), x, y, z);
	}
}
