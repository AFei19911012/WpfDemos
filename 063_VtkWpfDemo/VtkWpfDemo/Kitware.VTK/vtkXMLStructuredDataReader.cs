using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLStructuredDataReader
/// </summary>
/// <remarks>
///    Superclass for structured data XML readers.
///
/// vtkXMLStructuredDataReader provides functionality common to all
/// structured data format readers.
///
/// </remarks>
/// <seealso>
///
/// vtkXMLImageDataReader vtkXMLStructuredGridReader
/// vtkXMLRectilinearGridReader
/// </seealso>
public abstract class vtkXMLStructuredDataReader : vtkXMLDataReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLStructuredDataReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLStructuredDataReader()
	{
		MRClassNameKey = "class vtkXMLStructuredDataReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLStructuredDataReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLStructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkXMLStructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

	/// <summary>
	/// For the specified port, copy the information this reader sets up in
	/// SetupOutputInformation to outInfo
	/// </summary>
	public override void CopyOutputInformation(vtkInformation outInfo, int port)
	{
		vtkXMLStructuredDataReader_CopyOutputInformation_01(GetCppThis(), outInfo?.GetCppThis() ?? default(HandleRef), port);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLStructuredDataReader_GetNumberOfCells_02(HandleRef pThis);

	/// <summary>
	/// Get the number of cells in the output.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkXMLStructuredDataReader_GetNumberOfCells_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLStructuredDataReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLStructuredDataReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLStructuredDataReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLStructuredDataReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLStructuredDataReader_GetNumberOfPoints_05(HandleRef pThis);

	/// <summary>
	/// Get the number of points in the output.
	/// </summary>
	public override long GetNumberOfPoints()
	{
		return vtkXMLStructuredDataReader_GetNumberOfPoints_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLStructuredDataReader_GetWholeSlices_06(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the reader gets a whole slice from disk when only
	/// a rectangle inside it is needed.  This mode reads more data than
	/// necessary, but prevents many short reads from interacting poorly
	/// with the compression and encoding schemes.
	/// </summary>
	public virtual int GetWholeSlices()
	{
		return vtkXMLStructuredDataReader_GetWholeSlices_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLStructuredDataReader_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLStructuredDataReader_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLStructuredDataReader_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLStructuredDataReader_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLStructuredDataReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLStructuredDataReader NewInstance()
	{
		vtkXMLStructuredDataReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLStructuredDataReader_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLStructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLStructuredDataReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLStructuredDataReader SafeDownCast(vtkObjectBase o)
	{
		vtkXMLStructuredDataReader vtkXMLStructuredDataReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLStructuredDataReader_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLStructuredDataReader2 = (vtkXMLStructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLStructuredDataReader2.Register(null);
			}
		}
		return vtkXMLStructuredDataReader2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataReader_SetWholeSlices_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set whether the reader gets a whole slice from disk when only
	/// a rectangle inside it is needed.  This mode reads more data than
	/// necessary, but prevents many short reads from interacting poorly
	/// with the compression and encoding schemes.
	/// </summary>
	public virtual void SetWholeSlices(int _arg)
	{
		vtkXMLStructuredDataReader_SetWholeSlices_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataReader_WholeSlicesOff_12(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the reader gets a whole slice from disk when only
	/// a rectangle inside it is needed.  This mode reads more data than
	/// necessary, but prevents many short reads from interacting poorly
	/// with the compression and encoding schemes.
	/// </summary>
	public virtual void WholeSlicesOff()
	{
		vtkXMLStructuredDataReader_WholeSlicesOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLStructuredDataReader_WholeSlicesOn_13(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the reader gets a whole slice from disk when only
	/// a rectangle inside it is needed.  This mode reads more data than
	/// necessary, but prevents many short reads from interacting poorly
	/// with the compression and encoding schemes.
	/// </summary>
	public virtual void WholeSlicesOn()
	{
		vtkXMLStructuredDataReader_WholeSlicesOn_13(GetCppThis());
	}
}
