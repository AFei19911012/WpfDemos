using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCPExodusIIElementBlock
/// </summary>
/// <remarks>
///    Uses an Exodus II element block as a
///  vtkMappedUnstructuredGrid's implementation.
///
///
/// This class allows raw data arrays returned by the Exodus II library to be
/// used directly in VTK without repacking the data into the vtkUnstructuredGrid
/// memory layout. Use the vtkCPExodusIIInSituReader to read an Exodus II file's
/// data into this structure.
/// </remarks>
public class vtkCPExodusIIElementBlock : vtkUnstructuredGridBase
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCPExodusIIElementBlock";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCPExodusIIElementBlock()
	{
		MRClassNameKey = "class vtkCPExodusIIElementBlock";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCPExodusIIElementBlock"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCPExodusIIElementBlock(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCPExodusIIElementBlock_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCPExodusIIElementBlock New()
	{
		vtkCPExodusIIElementBlock result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCPExodusIIElementBlock_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCPExodusIIElementBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCPExodusIIElementBlock()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCPExodusIIElementBlock_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCPExodusIIElementBlock_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCPExodusIIElementBlock_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCPExodusIIElementBlock_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCPExodusIIElementBlock_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCPExodusIIElementBlock_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCPExodusIIElementBlock_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCPExodusIIElementBlock_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCPExodusIIElementBlock_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCPExodusIIElementBlock_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCPExodusIIElementBlock NewInstance()
	{
		vtkCPExodusIIElementBlock result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCPExodusIIElementBlock_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCPExodusIIElementBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCPExodusIIElementBlock_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCPExodusIIElementBlock SafeDownCast(vtkObjectBase o)
	{
		vtkCPExodusIIElementBlock vtkCPExodusIIElementBlock2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCPExodusIIElementBlock_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCPExodusIIElementBlock2 = (vtkCPExodusIIElementBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCPExodusIIElementBlock2.Register(null);
			}
		}
		return vtkCPExodusIIElementBlock2;
	}
}
