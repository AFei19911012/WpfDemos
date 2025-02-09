using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkTestingObjectFactory : vtkObjectFactory
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTestingObjectFactory";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTestingObjectFactory()
	{
		MRClassNameKey = "class vtkTestingObjectFactory";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTestingObjectFactory"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTestingObjectFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTestingObjectFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTestingObjectFactory New()
	{
		vtkTestingObjectFactory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTestingObjectFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTestingObjectFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTestingObjectFactory()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTestingObjectFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTestingObjectFactory_GetDescription_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override string GetDescription()
	{
		return Marshal.PtrToStringAnsi(vtkTestingObjectFactory_GetDescription_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTestingObjectFactory_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTestingObjectFactory_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTestingObjectFactory_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTestingObjectFactory_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTestingObjectFactory_GetVTKSourceVersion_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override string GetVTKSourceVersion()
	{
		return Marshal.PtrToStringAnsi(vtkTestingObjectFactory_GetVTKSourceVersion_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTestingObjectFactory_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTestingObjectFactory_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTestingObjectFactory_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTestingObjectFactory_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTestingObjectFactory_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTestingObjectFactory NewInstance()
	{
		vtkTestingObjectFactory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTestingObjectFactory_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTestingObjectFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTestingObjectFactory_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTestingObjectFactory SafeDownCast(vtkObjectBase o)
	{
		vtkTestingObjectFactory vtkTestingObjectFactory2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTestingObjectFactory_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTestingObjectFactory2 = (vtkTestingObjectFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTestingObjectFactory2.Register(null);
			}
		}
		return vtkTestingObjectFactory2;
	}
}
