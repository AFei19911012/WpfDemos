using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLUnstructuredDataWriter
/// </summary>
/// <remarks>
///    Superclass for VTK XML unstructured data writers.
///
/// vtkXMLUnstructuredDataWriter provides VTK XML writing functionality
/// that is common among all the unstructured data formats.
/// </remarks>
public abstract class vtkXMLUnstructuredDataWriter : vtkXMLWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUnstructuredDataWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLUnstructuredDataWriter()
	{
		MRClassNameKey = "class vtkXMLUnstructuredDataWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUnstructuredDataWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLUnstructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkXMLUnstructuredDataWriter_GetGhostLevel_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the ghost level used to pad each piece.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkXMLUnstructuredDataWriter_GetGhostLevel_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUnstructuredDataWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLUnstructuredDataWriter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUnstructuredDataWriter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLUnstructuredDataWriter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUnstructuredDataWriter_GetNumberOfPieces_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of pieces used to stream the image through the
	/// pipeline while writing to the file.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkXMLUnstructuredDataWriter_GetNumberOfPieces_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUnstructuredDataWriter_GetWritePiece_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the piece to write to the file.  If this is
	/// negative or equal to the NumberOfPieces, all pieces will be written.
	/// </summary>
	public virtual int GetWritePiece()
	{
		return vtkXMLUnstructuredDataWriter_GetWritePiece_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUnstructuredDataWriter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLUnstructuredDataWriter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUnstructuredDataWriter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLUnstructuredDataWriter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUnstructuredDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLUnstructuredDataWriter NewInstance()
	{
		vtkXMLUnstructuredDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUnstructuredDataWriter_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUnstructuredDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLUnstructuredDataWriter SafeDownCast(vtkObjectBase o)
	{
		vtkXMLUnstructuredDataWriter vtkXMLUnstructuredDataWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUnstructuredDataWriter_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLUnstructuredDataWriter2 = (vtkXMLUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLUnstructuredDataWriter2.Register(null);
			}
		}
		return vtkXMLUnstructuredDataWriter2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLUnstructuredDataWriter_SetGhostLevel_10(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the ghost level used to pad each piece.
	/// </summary>
	public virtual void SetGhostLevel(int _arg)
	{
		vtkXMLUnstructuredDataWriter_SetGhostLevel_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLUnstructuredDataWriter_SetNumberOfPieces_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of pieces used to stream the image through the
	/// pipeline while writing to the file.
	/// </summary>
	public virtual void SetNumberOfPieces(int _arg)
	{
		vtkXMLUnstructuredDataWriter_SetNumberOfPieces_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLUnstructuredDataWriter_SetWritePiece_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the piece to write to the file.  If this is
	/// negative or equal to the NumberOfPieces, all pieces will be written.
	/// </summary>
	public virtual void SetWritePiece(int _arg)
	{
		vtkXMLUnstructuredDataWriter_SetWritePiece_12(GetCppThis(), _arg);
	}
}
