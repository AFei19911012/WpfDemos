using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLStructuredDataWriter
/// </summary>
/// <remarks>
///    Superclass for VTK XML structured data writers.
///
/// vtkXMLStructuredDataWriter provides VTK XML writing functionality that
/// is common among all the structured data formats.
/// </remarks>
public abstract class vtkXMLStructuredDataWriter : vtkXMLWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLStructuredDataWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLStructuredDataWriter()
	{
		MRClassNameKey = "class vtkXMLStructuredDataWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLStructuredDataWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLStructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLStructuredDataWriter_GetGhostLevel_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the ghost level used to pad each piece.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkXMLStructuredDataWriter_GetGhostLevel_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLStructuredDataWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLStructuredDataWriter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLStructuredDataWriter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLStructuredDataWriter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLStructuredDataWriter_GetNumberOfPieces_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of pieces used to stream the image through the
	/// pipeline while writing to the file.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkXMLStructuredDataWriter_GetNumberOfPieces_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLStructuredDataWriter_GetWriteExtent_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the extent of the input that should be treated as the
	/// WholeExtent in the output file.  The default is the WholeExtent
	/// of the input.
	/// </summary>
	public virtual int[] GetWriteExtent()
	{
		IntPtr intPtr = vtkXMLStructuredDataWriter_GetWriteExtent_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataWriter_GetWriteExtent_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Get/Set the extent of the input that should be treated as the
	/// WholeExtent in the output file.  The default is the WholeExtent
	/// of the input.
	/// </summary>
	public virtual void GetWriteExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkXMLStructuredDataWriter_GetWriteExtent_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataWriter_GetWriteExtent_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the extent of the input that should be treated as the
	/// WholeExtent in the output file.  The default is the WholeExtent
	/// of the input.
	/// </summary>
	public virtual void GetWriteExtent(IntPtr _arg)
	{
		vtkXMLStructuredDataWriter_GetWriteExtent_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLStructuredDataWriter_GetWritePiece_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the piece to write to the file.  If this is
	/// negative, all pieces will be written.
	/// </summary>
	public virtual int GetWritePiece()
	{
		return vtkXMLStructuredDataWriter_GetWritePiece_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLStructuredDataWriter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLStructuredDataWriter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLStructuredDataWriter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLStructuredDataWriter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLStructuredDataWriter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLStructuredDataWriter NewInstance()
	{
		vtkXMLStructuredDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLStructuredDataWriter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLStructuredDataWriter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLStructuredDataWriter SafeDownCast(vtkObjectBase o)
	{
		vtkXMLStructuredDataWriter vtkXMLStructuredDataWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLStructuredDataWriter_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLStructuredDataWriter2 = (vtkXMLStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLStructuredDataWriter2.Register(null);
			}
		}
		return vtkXMLStructuredDataWriter2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataWriter_SetGhostLevel_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the ghost level used to pad each piece.
	/// </summary>
	public virtual void SetGhostLevel(int _arg)
	{
		vtkXMLStructuredDataWriter_SetGhostLevel_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataWriter_SetNumberOfPieces_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of pieces used to stream the image through the
	/// pipeline while writing to the file.
	/// </summary>
	public virtual void SetNumberOfPieces(int _arg)
	{
		vtkXMLStructuredDataWriter_SetNumberOfPieces_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataWriter_SetWriteExtent_15(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Get/Set the extent of the input that should be treated as the
	/// WholeExtent in the output file.  The default is the WholeExtent
	/// of the input.
	/// </summary>
	public virtual void SetWriteExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkXMLStructuredDataWriter_SetWriteExtent_15(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataWriter_SetWriteExtent_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the extent of the input that should be treated as the
	/// WholeExtent in the output file.  The default is the WholeExtent
	/// of the input.
	/// </summary>
	public virtual void SetWriteExtent(IntPtr _arg)
	{
		vtkXMLStructuredDataWriter_SetWriteExtent_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataWriter_SetWritePiece_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the piece to write to the file.  If this is
	/// negative, all pieces will be written.
	/// </summary>
	public virtual void SetWritePiece(int _arg)
	{
		vtkXMLStructuredDataWriter_SetWritePiece_17(GetCppThis(), _arg);
	}
}
