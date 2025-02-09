using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// Get vtkDataArraySelection instance to select cell arrays to read.
/// </summary>
public class vtkVeraOutReader : vtkRectilinearGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVeraOutReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVeraOutReader()
	{
		MRClassNameKey = "class vtkVeraOutReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVeraOutReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVeraOutReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVeraOutReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkVeraOutReader New()
	{
		vtkVeraOutReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVeraOutReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVeraOutReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkVeraOutReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVeraOutReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVeraOutReader_GetCellDataArraySelection_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get vtkDataArraySelection instance to select cell arrays to read.
	/// </summary>
	public vtkDataArraySelection GetCellDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVeraOutReader_GetCellDataArraySelection_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVeraOutReader_GetFieldDataArraySelection_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get vtkDataArraySelection instance to select field arrays to read.
	/// </summary>
	public vtkDataArraySelection GetFieldDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVeraOutReader_GetFieldDataArraySelection_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVeraOutReader_GetFileName_03(HandleRef pThis);

	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkVeraOutReader_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVeraOutReader_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Override GetMTime because of array selector.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkVeraOutReader_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVeraOutReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVeraOutReader_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVeraOutReader_GetNumberOfGenerationsFromBaseType_06(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVeraOutReader_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVeraOutReader_IsA_07(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkVeraOutReader_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVeraOutReader_IsTypeOf_08(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkVeraOutReader_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVeraOutReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkVeraOutReader NewInstance()
	{
		vtkVeraOutReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVeraOutReader_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVeraOutReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVeraOutReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkVeraOutReader SafeDownCast(vtkObjectBase o)
	{
		vtkVeraOutReader vtkVeraOutReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVeraOutReader_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVeraOutReader2 = (vtkVeraOutReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVeraOutReader2.Register(null);
			}
		}
		return vtkVeraOutReader2;
	}

	[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVeraOutReader_SetFileName_12(HandleRef pThis, string _arg);

	public virtual void SetFileName(string _arg)
	{
		vtkVeraOutReader_SetFileName_12(GetCppThis(), _arg);
	}
}
