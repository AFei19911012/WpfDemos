using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPOpenFOAMReader
/// </summary>
/// <remarks>
///    reads a decomposed dataset in OpenFOAM format
///
/// vtkPOpenFOAMReader creates a multiblock dataset. It reads
/// parallel-decomposed mesh information and time dependent data.  The
/// polyMesh folders contain mesh information. The time folders contain
/// transient data for the cells. Each folder can contain any number of
/// data files.
///
/// @par Thanks:
/// This class was developed by Takuya Oshima at Niigata University,
/// Japan (oshima@eng.niigata-u.ac.jp).
/// </remarks>
public class vtkPOpenFOAMReader : vtkOpenFOAMReader
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum caseType
	{
		/// <summary>enum member</summary>
		DECOMPOSED_CASE,
		/// <summary>enum member</summary>
		RECONSTRUCTED_CASE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPOpenFOAMReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPOpenFOAMReader()
	{
		MRClassNameKey = "class vtkPOpenFOAMReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOpenFOAMReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPOpenFOAMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPOpenFOAMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPOpenFOAMReader New()
	{
		vtkPOpenFOAMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPOpenFOAMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPOpenFOAMReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPOpenFOAMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern caseType vtkPOpenFOAMReader_GetCaseType_01(HandleRef pThis);

	/// <summary>
	/// Set and get case type. 0 = decomposed case, 1 = reconstructed case.
	/// </summary>
	public virtual caseType GetCaseType()
	{
		return vtkPOpenFOAMReader_GetCaseType_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPOpenFOAMReader_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and get the controller.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPOpenFOAMReader_GetController_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPOpenFOAMReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPOpenFOAMReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPOpenFOAMReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPOpenFOAMReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPOpenFOAMReader_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPOpenFOAMReader_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPOpenFOAMReader_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPOpenFOAMReader_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPOpenFOAMReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPOpenFOAMReader NewInstance()
	{
		vtkPOpenFOAMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPOpenFOAMReader_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPOpenFOAMReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPOpenFOAMReader SafeDownCast(vtkObjectBase o)
	{
		vtkPOpenFOAMReader vtkPOpenFOAMReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPOpenFOAMReader_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPOpenFOAMReader2 = (vtkPOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPOpenFOAMReader2.Register(null);
			}
		}
		return vtkPOpenFOAMReader2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPOpenFOAMReader_SetCaseType_10(HandleRef pThis, int t);

	/// <summary>
	/// Set and get case type. 0 = decomposed case, 1 = reconstructed case.
	/// </summary>
	public void SetCaseType(int t)
	{
		vtkPOpenFOAMReader_SetCaseType_10(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPOpenFOAMReader_SetController_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set and get the controller.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkPOpenFOAMReader_SetController_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
