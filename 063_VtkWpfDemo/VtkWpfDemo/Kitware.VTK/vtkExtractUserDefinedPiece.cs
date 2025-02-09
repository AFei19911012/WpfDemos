using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractUserDefinedPiece
/// </summary>
/// <remarks>
///    Return user specified piece with ghost cells
///
///
/// Provided a function that determines which cells are zero-level
/// cells ("the piece"), this class outputs the piece with the
/// requested number of ghost levels.  The only difference between
/// this class and the class it is derived from is that the
/// zero-level cells are specified by a function you provide,
/// instead of determined by dividing up the cells based on cell Id.
///
/// </remarks>
/// <seealso>
///
/// vtkExtractUnstructuredGridPiece
/// </seealso>
public class vtkExtractUserDefinedPiece : vtkExtractUnstructuredGridPiece
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public delegate int UserDefFunc(long arg0, IntPtr arg1, IntPtr arg2);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractUserDefinedPiece";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractUserDefinedPiece()
	{
		MRClassNameKey = "class vtkExtractUserDefinedPiece";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractUserDefinedPiece"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractUserDefinedPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractUserDefinedPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractUserDefinedPiece New()
	{
		vtkExtractUserDefinedPiece result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractUserDefinedPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractUserDefinedPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractUserDefinedPiece()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractUserDefinedPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUserDefinedPiece_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractUserDefinedPiece_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUserDefinedPiece_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractUserDefinedPiece_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractUserDefinedPiece_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractUserDefinedPiece_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractUserDefinedPiece_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractUserDefinedPiece_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractUserDefinedPiece_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractUserDefinedPiece NewInstance()
	{
		vtkExtractUserDefinedPiece result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractUserDefinedPiece_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractUserDefinedPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractUserDefinedPiece_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractUserDefinedPiece SafeDownCast(vtkObjectBase o)
	{
		vtkExtractUserDefinedPiece vtkExtractUserDefinedPiece2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractUserDefinedPiece_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractUserDefinedPiece2 = (vtkExtractUserDefinedPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractUserDefinedPiece2.Register(null);
			}
		}
		return vtkExtractUserDefinedPiece2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUserDefinedPiece_SetConstantData_08(HandleRef pThis, IntPtr data, int len);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetConstantData(IntPtr data, int len)
	{
		vtkExtractUserDefinedPiece_SetConstantData_08(GetCppThis(), data, len);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUserDefinedPiece_SetPieceFunction_09(HandleRef pThis, UserDefFunc func);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetPieceFunction(UserDefFunc func)
	{
		vtkExtractUserDefinedPiece_SetPieceFunction_09(GetCppThis(), func);
	}
}
