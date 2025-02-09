using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkJSONImageWriter
/// </summary>
/// <remarks>
///    Writes vtkImageData to a JSON file.
///
/// vtkJSONImageWriter writes a JSON file which will describe the
/// data inside a vtkImageData.
/// </remarks>
public class vtkJSONImageWriter : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkJSONImageWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkJSONImageWriter()
	{
		MRClassNameKey = "class vtkJSONImageWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkJSONImageWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkJSONImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJSONImageWriter New()
	{
		vtkJSONImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJSONImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkJSONImageWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkJSONImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONImageWriter_GetArrayName_01(HandleRef pThis);

	/// <summary>
	/// Specify ArrayName to export. By default nullptr which will dump ALL arrays.
	/// </summary>
	public virtual string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkJSONImageWriter_GetArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONImageWriter_GetFileName_02(HandleRef pThis);

	/// <summary>
	/// Specify file name for the image file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkJSONImageWriter_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJSONImageWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkJSONImageWriter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJSONImageWriter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkJSONImageWriter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJSONImageWriter_GetSlice_05(HandleRef pThis);

	/// <summary>
	/// Specify Slice in Z to export. By default -1 which will dump the full 3D domain.
	/// </summary>
	public virtual int GetSlice()
	{
		return vtkJSONImageWriter_GetSlice_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJSONImageWriter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkJSONImageWriter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJSONImageWriter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkJSONImageWriter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONImageWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkJSONImageWriter NewInstance()
	{
		vtkJSONImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONImageWriter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJSONImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONImageWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJSONImageWriter SafeDownCast(vtkObjectBase o)
	{
		vtkJSONImageWriter vtkJSONImageWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONImageWriter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkJSONImageWriter2 = (vtkJSONImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkJSONImageWriter2.Register(null);
			}
		}
		return vtkJSONImageWriter2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONImageWriter_SetArrayName_11(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify ArrayName to export. By default nullptr which will dump ALL arrays.
	/// </summary>
	public virtual void SetArrayName(string _arg)
	{
		vtkJSONImageWriter_SetArrayName_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONImageWriter_SetFileName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name for the image file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkJSONImageWriter_SetFileName_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONImageWriter_SetSlice_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify Slice in Z to export. By default -1 which will dump the full 3D domain.
	/// </summary>
	public virtual void SetSlice(int _arg)
	{
		vtkJSONImageWriter_SetSlice_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONImageWriter_Write_14(HandleRef pThis);

	/// <summary>
	/// The main interface which triggers the writer to start.
	/// </summary>
	public virtual void Write()
	{
		vtkJSONImageWriter_Write_14(GetCppThis());
	}
}
