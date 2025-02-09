using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDelimitedTextWriter
/// </summary>
/// <remarks>
///    Delimited text writer for vtkTable
/// Writes a vtkTable as a delimited text file (such as CSV).
/// </remarks>
public class vtkDelimitedTextWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDelimitedTextWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDelimitedTextWriter()
	{
		MRClassNameKey = "class vtkDelimitedTextWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelimitedTextWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDelimitedTextWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDelimitedTextWriter New()
	{
		vtkDelimitedTextWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelimitedTextWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDelimitedTextWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDelimitedTextWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDelimitedTextWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDelimitedTextWriter_GetFieldDelimiter_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the delimiter use to separate fields ("," by default.)
	/// </summary>
	public virtual string GetFieldDelimiter()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextWriter_GetFieldDelimiter_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextWriter_GetFileName_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the filename for the file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextWriter_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDelimitedTextWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDelimitedTextWriter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDelimitedTextWriter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDelimitedTextWriter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDelimitedTextWriter_GetString_05(HandleRef pThis, string arg0);

	/// <summary>
	/// Internal method: Returns the "string" with the "StringDelimiter" if
	/// UseStringDelimiter is true.
	/// </summary>
	public string GetString(string arg0)
	{
		return vtkDelimitedTextWriter_GetString_05(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextWriter_GetStringDelimiter_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the delimiter used for string data, if any
	/// eg. double quotes(").
	/// </summary>
	public virtual string GetStringDelimiter()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextWriter_GetStringDelimiter_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextWriter_GetUseStringDelimiter_07(HandleRef pThis);

	/// <summary>
	/// Get/Set if StringDelimiter must be used for string data.
	/// True by default.
	/// </summary>
	public virtual bool GetUseStringDelimiter()
	{
		return (vtkDelimitedTextWriter_GetUseStringDelimiter_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextWriter_GetWriteToOutputString_08(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual bool GetWriteToOutputString()
	{
		return (vtkDelimitedTextWriter_GetWriteToOutputString_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelimitedTextWriter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDelimitedTextWriter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelimitedTextWriter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDelimitedTextWriter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDelimitedTextWriter NewInstance()
	{
		vtkDelimitedTextWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelimitedTextWriter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDelimitedTextWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextWriter_RegisterAndGetOutputString_13(HandleRef pThis);

	/// <summary>
	/// This convenience method returns the string, sets the IVAR to nullptr,
	/// so that the user is responsible for deleting the string.
	/// </summary>
	public string RegisterAndGetOutputString()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextWriter_RegisterAndGetOutputString_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextWriter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDelimitedTextWriter SafeDownCast(vtkObjectBase o)
	{
		vtkDelimitedTextWriter vtkDelimitedTextWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelimitedTextWriter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDelimitedTextWriter2 = (vtkDelimitedTextWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDelimitedTextWriter2.Register(null);
			}
		}
		return vtkDelimitedTextWriter2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextWriter_SetFieldDelimiter_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the delimiter use to separate fields ("," by default.)
	/// </summary>
	public virtual void SetFieldDelimiter(string _arg)
	{
		vtkDelimitedTextWriter_SetFieldDelimiter_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextWriter_SetFileName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the filename for the file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkDelimitedTextWriter_SetFileName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextWriter_SetStringDelimiter_17(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the delimiter used for string data, if any
	/// eg. double quotes(").
	/// </summary>
	public virtual void SetStringDelimiter(string _arg)
	{
		vtkDelimitedTextWriter_SetStringDelimiter_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextWriter_SetUseStringDelimiter_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set if StringDelimiter must be used for string data.
	/// True by default.
	/// </summary>
	public virtual void SetUseStringDelimiter(bool _arg)
	{
		vtkDelimitedTextWriter_SetUseStringDelimiter_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextWriter_SetWriteToOutputString_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void SetWriteToOutputString(bool _arg)
	{
		vtkDelimitedTextWriter_SetWriteToOutputString_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextWriter_WriteToOutputStringOff_20(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void WriteToOutputStringOff()
	{
		vtkDelimitedTextWriter_WriteToOutputStringOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextWriter_WriteToOutputStringOn_21(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void WriteToOutputStringOn()
	{
		vtkDelimitedTextWriter_WriteToOutputStringOn_21(GetCppThis());
	}
}
