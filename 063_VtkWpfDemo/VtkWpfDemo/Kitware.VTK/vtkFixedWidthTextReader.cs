using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFixedWidthTextReader
/// </summary>
/// <remarks>
///    reader for pulling in text files with fixed-width fields
///
///
///
/// vtkFixedWidthTextReader reads in a table from a text file where
/// each column occupies a certain number of characters.
///
/// This class emits ProgressEvent for every 100 lines it reads.
///
///
/// @warning
/// This first version of the reader will assume that all fields have
/// the same width.  It also assumes that the first line in the file
/// has at least as many fields (i.e. at least as many characters) as
/// any other line in the file.
///
/// @par Thanks:
/// Thanks to Andy Wilson from Sandia National Laboratories for
/// implementing this class.
/// </remarks>
public class vtkFixedWidthTextReader : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFixedWidthTextReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFixedWidthTextReader()
	{
		MRClassNameKey = "class vtkFixedWidthTextReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedWidthTextReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFixedWidthTextReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedWidthTextReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedWidthTextReader New()
	{
		vtkFixedWidthTextReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedWidthTextReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedWidthTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFixedWidthTextReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFixedWidthTextReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedWidthTextReader_GetFieldWidth_01(HandleRef pThis);

	/// <summary>
	/// Set/get the field width
	/// </summary>
	public virtual int GetFieldWidth()
	{
		return vtkFixedWidthTextReader_GetFieldWidth_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedWidthTextReader_GetFileName_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkFixedWidthTextReader_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFixedWidthTextReader_GetHaveHeaders_03(HandleRef pThis);

	/// <summary>
	/// Set/get whether to treat the first line of the file as headers.
	/// </summary>
	public virtual bool GetHaveHeaders()
	{
		return (vtkFixedWidthTextReader_GetHaveHeaders_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedWidthTextReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFixedWidthTextReader_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedWidthTextReader_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFixedWidthTextReader_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFixedWidthTextReader_GetStripWhiteSpace_06(HandleRef pThis);

	/// <summary>
	/// If set, this flag will cause the reader to strip whitespace from
	/// the beginning and ending of each field.  Defaults to off.
	/// </summary>
	public virtual bool GetStripWhiteSpace()
	{
		return (vtkFixedWidthTextReader_GetStripWhiteSpace_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedWidthTextReader_GetTableErrorObserver_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the ErrorObserver for the internal vtkTable
	/// This is useful for applications that want to catch error messages.
	/// </summary>
	public virtual vtkCommand GetTableErrorObserver()
	{
		vtkCommand vtkCommand2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedWidthTextReader_GetTableErrorObserver_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCommand2 = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCommand2.Register(null);
			}
		}
		return vtkCommand2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedWidthTextReader_HaveHeadersOff_08(HandleRef pThis);

	/// <summary>
	/// Set/get whether to treat the first line of the file as headers.
	/// </summary>
	public virtual void HaveHeadersOff()
	{
		vtkFixedWidthTextReader_HaveHeadersOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedWidthTextReader_HaveHeadersOn_09(HandleRef pThis);

	/// <summary>
	/// Set/get whether to treat the first line of the file as headers.
	/// </summary>
	public virtual void HaveHeadersOn()
	{
		vtkFixedWidthTextReader_HaveHeadersOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedWidthTextReader_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFixedWidthTextReader_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedWidthTextReader_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFixedWidthTextReader_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedWidthTextReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFixedWidthTextReader NewInstance()
	{
		vtkFixedWidthTextReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedWidthTextReader_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedWidthTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedWidthTextReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedWidthTextReader SafeDownCast(vtkObjectBase o)
	{
		vtkFixedWidthTextReader vtkFixedWidthTextReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedWidthTextReader_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedWidthTextReader2 = (vtkFixedWidthTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedWidthTextReader2.Register(null);
			}
		}
		return vtkFixedWidthTextReader2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedWidthTextReader_SetFieldWidth_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the field width
	/// </summary>
	public virtual void SetFieldWidth(int _arg)
	{
		vtkFixedWidthTextReader_SetFieldWidth_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedWidthTextReader_SetFileName_16(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkFixedWidthTextReader_SetFileName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedWidthTextReader_SetHaveHeaders_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get whether to treat the first line of the file as headers.
	/// </summary>
	public virtual void SetHaveHeaders(bool _arg)
	{
		vtkFixedWidthTextReader_SetHaveHeaders_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedWidthTextReader_SetStripWhiteSpace_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set, this flag will cause the reader to strip whitespace from
	/// the beginning and ending of each field.  Defaults to off.
	/// </summary>
	public virtual void SetStripWhiteSpace(bool _arg)
	{
		vtkFixedWidthTextReader_SetStripWhiteSpace_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedWidthTextReader_SetTableErrorObserver_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get the ErrorObserver for the internal vtkTable
	/// This is useful for applications that want to catch error messages.
	/// </summary>
	public void SetTableErrorObserver(vtkCommand arg0)
	{
		vtkFixedWidthTextReader_SetTableErrorObserver_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedWidthTextReader_StripWhiteSpaceOff_20(HandleRef pThis);

	/// <summary>
	/// If set, this flag will cause the reader to strip whitespace from
	/// the beginning and ending of each field.  Defaults to off.
	/// </summary>
	public virtual void StripWhiteSpaceOff()
	{
		vtkFixedWidthTextReader_StripWhiteSpaceOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedWidthTextReader_StripWhiteSpaceOn_21(HandleRef pThis);

	/// <summary>
	/// If set, this flag will cause the reader to strip whitespace from
	/// the beginning and ending of each field.  Defaults to off.
	/// </summary>
	public virtual void StripWhiteSpaceOn()
	{
		vtkFixedWidthTextReader_StripWhiteSpaceOn_21(GetCppThis());
	}
}
