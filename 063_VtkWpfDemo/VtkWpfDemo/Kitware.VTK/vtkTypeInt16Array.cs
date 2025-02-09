using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkTypeInt16Array : vtkShortArray
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTypeInt16Array";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTypeInt16Array()
	{
		MRClassNameKey = "class vtkTypeInt16Array";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeInt16Array"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTypeInt16Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTypeInt16Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkTypeInt16Array New()
	{
		vtkTypeInt16Array result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTypeInt16Array_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTypeInt16Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkTypeInt16Array()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTypeInt16Array_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTypeInt16Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkTypeInt16Array FastDownCast(vtkAbstractArray source)
	{
		vtkTypeInt16Array vtkTypeInt16Array2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTypeInt16Array_FastDownCast_01(source?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTypeInt16Array2 = (vtkTypeInt16Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTypeInt16Array2.Register(null);
			}
		}
		return vtkTypeInt16Array2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTypeInt16Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTypeInt16Array_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTypeInt16Array_GetNumberOfGenerationsFromBaseType_03(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTypeInt16Array_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTypeInt16Array_IsA_04(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkTypeInt16Array_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTypeInt16Array_IsTypeOf_05(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkTypeInt16Array_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTypeInt16Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkTypeInt16Array NewInstance()
	{
		vtkTypeInt16Array result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTypeInt16Array_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTypeInt16Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTypeInt16Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkTypeInt16Array SafeDownCast(vtkObjectBase o)
	{
		vtkTypeInt16Array vtkTypeInt16Array2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTypeInt16Array_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTypeInt16Array2 = (vtkTypeInt16Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTypeInt16Array2.Register(null);
			}
		}
		return vtkTypeInt16Array2;
	}
}
