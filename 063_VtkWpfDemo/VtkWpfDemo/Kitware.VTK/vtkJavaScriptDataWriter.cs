using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkJavaScriptDataWriter
/// </summary>
/// <remarks>
///    A Javascript data writer for vtkTable
/// Writes a vtkTable into a Javascript data format.
/// </remarks>
public class vtkJavaScriptDataWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkJavaScriptDataWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkJavaScriptDataWriter()
	{
		MRClassNameKey = "class vtkJavaScriptDataWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkJavaScriptDataWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkJavaScriptDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJavaScriptDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJavaScriptDataWriter New()
	{
		vtkJavaScriptDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJavaScriptDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJavaScriptDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkJavaScriptDataWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkJavaScriptDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJavaScriptDataWriter_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the filename for the file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkJavaScriptDataWriter_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkJavaScriptDataWriter_GetIncludeFieldNames_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the whether or not to include field names
	/// When field names are on you will get data output
	/// that looks like this:
	/// var data=[
	/// {foo:3,time:"2009-11-04 16:09:42",bar:1 },
	/// {foo:5,time:"2009-11-04 16:11:22",bar:0 },
	/// without field names the data will be an array
	/// of arrays like this:
	/// var data=[
	/// [3,"2009-11-04 16:09:42",1],
	/// [5,"2009-11-04 16:11:22",0],
	///
	/// Default is ON (true)
	/// </summary>
	public virtual bool GetIncludeFieldNames()
	{
		return (vtkJavaScriptDataWriter_GetIncludeFieldNames_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJavaScriptDataWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkJavaScriptDataWriter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJavaScriptDataWriter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkJavaScriptDataWriter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJavaScriptDataWriter_GetVariableName_05(HandleRef pThis);

	/// <summary>
	/// Get/set the name of the Javascript variable that the dataset will be assigned to.
	/// The default value is "data", so the javascript code generated by the filter will
	/// look like this: "var data = [ ... ];". If VariableName is set to nullptr, then no
	/// assignment statement will be generated (i.e., only "[ ... ];" will be generated).
	/// </summary>
	public virtual string GetVariableName()
	{
		return Marshal.PtrToStringAnsi(vtkJavaScriptDataWriter_GetVariableName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJavaScriptDataWriter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkJavaScriptDataWriter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJavaScriptDataWriter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkJavaScriptDataWriter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJavaScriptDataWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkJavaScriptDataWriter NewInstance()
	{
		vtkJavaScriptDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJavaScriptDataWriter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJavaScriptDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJavaScriptDataWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJavaScriptDataWriter SafeDownCast(vtkObjectBase o)
	{
		vtkJavaScriptDataWriter vtkJavaScriptDataWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJavaScriptDataWriter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkJavaScriptDataWriter2 = (vtkJavaScriptDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkJavaScriptDataWriter2.Register(null);
			}
		}
		return vtkJavaScriptDataWriter2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJavaScriptDataWriter_SetFileName_11(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the filename for the file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkJavaScriptDataWriter_SetFileName_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJavaScriptDataWriter_SetIncludeFieldNames_12(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set the whether or not to include field names
	/// When field names are on you will get data output
	/// that looks like this:
	/// var data=[
	/// {foo:3,time:"2009-11-04 16:09:42",bar:1 },
	/// {foo:5,time:"2009-11-04 16:11:22",bar:0 },
	/// without field names the data will be an array
	/// of arrays like this:
	/// var data=[
	/// [3,"2009-11-04 16:09:42",1],
	/// [5,"2009-11-04 16:11:22",0],
	///
	/// Default is ON (true)
	/// </summary>
	public virtual void SetIncludeFieldNames(bool _arg)
	{
		vtkJavaScriptDataWriter_SetIncludeFieldNames_12(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJavaScriptDataWriter_SetVariableName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/set the name of the Javascript variable that the dataset will be assigned to.
	/// The default value is "data", so the javascript code generated by the filter will
	/// look like this: "var data = [ ... ];". If VariableName is set to nullptr, then no
	/// assignment statement will be generated (i.e., only "[ ... ];" will be generated).
	/// </summary>
	public virtual void SetVariableName(string _arg)
	{
		vtkJavaScriptDataWriter_SetVariableName_13(GetCppThis(), _arg);
	}
}
