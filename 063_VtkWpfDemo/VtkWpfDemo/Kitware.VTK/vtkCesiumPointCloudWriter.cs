using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCesiumPointCloudWriter
/// </summary>
/// <remarks>
///    export a vtkPointSet into a Cesium Point Cloud tile format
///
/// </remarks>
public class vtkCesiumPointCloudWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCesiumPointCloudWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCesiumPointCloudWriter()
	{
		MRClassNameKey = "class vtkCesiumPointCloudWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCesiumPointCloudWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCesiumPointCloudWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesiumPointCloudWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCesiumPointCloudWriter New()
	{
		vtkCesiumPointCloudWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCesiumPointCloudWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCesiumPointCloudWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCesiumPointCloudWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCesiumPointCloudWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesiumPointCloudWriter_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Name of the file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkCesiumPointCloudWriter_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCesiumPointCloudWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCesiumPointCloudWriter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCesiumPointCloudWriter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCesiumPointCloudWriter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesiumPointCloudWriter_GetPointIds_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// List of points to be saved.
	/// </summary>
	public virtual vtkIdList GetPointIds()
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCesiumPointCloudWriter_GetPointIds_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdList2 = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdList2.Register(null);
			}
		}
		return vtkIdList2;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCesiumPointCloudWriter_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCesiumPointCloudWriter_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCesiumPointCloudWriter_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCesiumPointCloudWriter_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesiumPointCloudWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCesiumPointCloudWriter NewInstance()
	{
		vtkCesiumPointCloudWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCesiumPointCloudWriter_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCesiumPointCloudWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesiumPointCloudWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCesiumPointCloudWriter SafeDownCast(vtkObjectBase o)
	{
		vtkCesiumPointCloudWriter vtkCesiumPointCloudWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCesiumPointCloudWriter_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCesiumPointCloudWriter2 = (vtkCesiumPointCloudWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCesiumPointCloudWriter2.Register(null);
			}
		}
		return vtkCesiumPointCloudWriter2;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesiumPointCloudWriter_SetFileName_10(HandleRef pThis, string _arg);

	/// <summary>
	/// Name of the file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkCesiumPointCloudWriter_SetFileName_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesiumPointCloudWriter_SetPointIds_11(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// List of points to be saved.
	/// </summary>
	public virtual void SetPointIds(vtkIdList _arg)
	{
		vtkCesiumPointCloudWriter_SetPointIds_11(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}
}
