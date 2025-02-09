using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPNGWriter
/// </summary>
/// <remarks>
///    Writes PNG files.
///
/// vtkPNGWriter writes PNG files. It supports 1 to 4 component data of
/// unsigned char or unsigned short
///
/// </remarks>
/// <seealso>
///
/// vtkPNGReader
/// </seealso>
public class vtkPNGWriter : vtkImageWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPNGWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPNGWriter()
	{
		MRClassNameKey = "class vtkPNGWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPNGWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPNGWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPNGWriter New()
	{
		vtkPNGWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPNGWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPNGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPNGWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPNGWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPNGWriter_AddText_01(HandleRef pThis, string key, string value);

	/// <summary>
	/// Adds a text chunk to the PNG. More than one text chunk with the same key is permissible.
	/// There are a number of predefined keywords that should be used
	/// when appropriate. See
	/// http://www.libpng.org/pub/png/spec/1.2/PNG-Chunks.html
	/// for more information.
	/// </summary>
	public void AddText(string key, string value)
	{
		vtkPNGWriter_AddText_01(GetCppThis(), key, value);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGWriter_ClearText_02(HandleRef pThis);

	/// <summary>
	/// Clear out any key/value pairs added through the AddText() member function.
	/// </summary>
	public void ClearText()
	{
		vtkPNGWriter_ClearText_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPNGWriter_GetCompressionLevel_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the zlib compression level.
	/// The range is 0-9, with 0 meaning no compression
	/// corresponding to the largest file size, and 9 meaning
	/// best compression, corresponding to the smallest file size.
	/// The default is 5.
	/// </summary>
	public virtual int GetCompressionLevel()
	{
		return vtkPNGWriter_GetCompressionLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPNGWriter_GetCompressionLevelMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the zlib compression level.
	/// The range is 0-9, with 0 meaning no compression
	/// corresponding to the largest file size, and 9 meaning
	/// best compression, corresponding to the smallest file size.
	/// The default is 5.
	/// </summary>
	public virtual int GetCompressionLevelMaxValue()
	{
		return vtkPNGWriter_GetCompressionLevelMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPNGWriter_GetCompressionLevelMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the zlib compression level.
	/// The range is 0-9, with 0 meaning no compression
	/// corresponding to the largest file size, and 9 meaning
	/// best compression, corresponding to the smallest file size.
	/// The default is 5.
	/// </summary>
	public virtual int GetCompressionLevelMinValue()
	{
		return vtkPNGWriter_GetCompressionLevelMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPNGWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPNGWriter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPNGWriter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPNGWriter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGWriter_GetResult_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When writing to memory this is the result, it will be nullptr until the
	/// data is written the first time
	/// </summary>
	public virtual vtkUnsignedCharArray GetResult()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPNGWriter_GetResult_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPNGWriter_GetWriteToMemory_09(HandleRef pThis);

	/// <summary>
	/// Write the image to memory (a vtkUnsignedCharArray)
	/// </summary>
	public virtual uint GetWriteToMemory()
	{
		return vtkPNGWriter_GetWriteToMemory_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPNGWriter_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPNGWriter_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPNGWriter_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPNGWriter_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGWriter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPNGWriter NewInstance()
	{
		vtkPNGWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPNGWriter_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPNGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGWriter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPNGWriter SafeDownCast(vtkObjectBase o)
	{
		vtkPNGWriter vtkPNGWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPNGWriter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPNGWriter2 = (vtkPNGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPNGWriter2.Register(null);
			}
		}
		return vtkPNGWriter2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGWriter_SetCompressionLevel_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the zlib compression level.
	/// The range is 0-9, with 0 meaning no compression
	/// corresponding to the largest file size, and 9 meaning
	/// best compression, corresponding to the smallest file size.
	/// The default is 5.
	/// </summary>
	public virtual void SetCompressionLevel(int _arg)
	{
		vtkPNGWriter_SetCompressionLevel_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGWriter_SetResult_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// When writing to memory this is the result, it will be nullptr until the
	/// data is written the first time
	/// </summary>
	public virtual void SetResult(vtkUnsignedCharArray arg0)
	{
		vtkPNGWriter_SetResult_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGWriter_SetWriteToMemory_17(HandleRef pThis, uint _arg);

	/// <summary>
	/// Write the image to memory (a vtkUnsignedCharArray)
	/// </summary>
	public virtual void SetWriteToMemory(uint _arg)
	{
		vtkPNGWriter_SetWriteToMemory_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGWriter_Write_18(HandleRef pThis);

	/// <summary>
	/// The main interface which triggers the writer to start.
	/// </summary>
	public override void Write()
	{
		vtkPNGWriter_Write_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGWriter_WriteToMemoryOff_19(HandleRef pThis);

	/// <summary>
	/// Write the image to memory (a vtkUnsignedCharArray)
	/// </summary>
	public virtual void WriteToMemoryOff()
	{
		vtkPNGWriter_WriteToMemoryOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGWriter_WriteToMemoryOn_20(HandleRef pThis);

	/// <summary>
	/// Write the image to memory (a vtkUnsignedCharArray)
	/// </summary>
	public virtual void WriteToMemoryOn()
	{
		vtkPNGWriter_WriteToMemoryOn_20(GetCppThis());
	}
}
