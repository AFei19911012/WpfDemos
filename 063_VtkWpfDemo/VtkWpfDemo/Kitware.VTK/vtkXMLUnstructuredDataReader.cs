using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLUnstructuredDataReader
/// </summary>
/// <remarks>
///    Superclass for unstructured data XML readers.
///
/// vtkXMLUnstructuredDataReader provides functionality common to all
/// unstructured data format readers.
///
/// </remarks>
/// <seealso>
///
/// vtkXMLPolyDataReader vtkXMLUnstructuredGridReader
/// </seealso>
public abstract class vtkXMLUnstructuredDataReader : vtkXMLDataReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUnstructuredDataReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLUnstructuredDataReader()
	{
		MRClassNameKey = "class vtkXMLUnstructuredDataReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUnstructuredDataReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLUnstructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkXMLUnstructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

	/// <summary>
	/// Setup the reader as if the given update extent were requested by
	/// its output.  This can be used after an UpdateInformation to
	/// validate GetNumberOfPoints() and GetNumberOfCells() without
	/// actually reading data.
	/// </summary>
	public override void CopyOutputInformation(vtkInformation outInfo, int port)
	{
		vtkXMLUnstructuredDataReader_CopyOutputInformation_01(GetCppThis(), outInfo?.GetCppThis() ?? default(HandleRef), port);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfCells_02(HandleRef pThis);

	/// <summary>
	/// Get the number of cells in the output.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkXMLUnstructuredDataReader_GetNumberOfCells_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLUnstructuredDataReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLUnstructuredDataReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfPieces_05(HandleRef pThis);

	/// <summary>
	/// Get the number of pieces in the file
	/// </summary>
	public virtual long GetNumberOfPieces()
	{
		return vtkXMLUnstructuredDataReader_GetNumberOfPieces_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfPoints_06(HandleRef pThis);

	/// <summary>
	/// Get the number of points in the output.
	/// </summary>
	public override long GetNumberOfPoints()
	{
		return vtkXMLUnstructuredDataReader_GetNumberOfPoints_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUnstructuredDataReader_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLUnstructuredDataReader_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUnstructuredDataReader_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLUnstructuredDataReader_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUnstructuredDataReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLUnstructuredDataReader NewInstance()
	{
		vtkXMLUnstructuredDataReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUnstructuredDataReader_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUnstructuredDataReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLUnstructuredDataReader SafeDownCast(vtkObjectBase o)
	{
		vtkXMLUnstructuredDataReader vtkXMLUnstructuredDataReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUnstructuredDataReader_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLUnstructuredDataReader2 = (vtkXMLUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLUnstructuredDataReader2.Register(null);
			}
		}
		return vtkXMLUnstructuredDataReader2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLUnstructuredDataReader_SetupUpdateExtent_11(HandleRef pThis, int piece, int numberOfPieces, int ghostLevel);

	/// <summary>
	/// Setup the reader as if the given update extent were requested by
	/// its output.  This can be used after an UpdateInformation to
	/// validate GetNumberOfPoints() and GetNumberOfCells() without
	/// actually reading data.
	/// </summary>
	public void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
	{
		vtkXMLUnstructuredDataReader_SetupUpdateExtent_11(GetCppThis(), piece, numberOfPieces, ghostLevel);
	}
}
