using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMultiNewickTreeReader
/// </summary>
/// <remarks>
///    read multiple vtkTrees from Newick formatted file
///
/// vtkMultiNewickTreeReader is a source object that reads Newick tree format
/// files.
/// The output of this reader is a single vtkMultiPieceDataSet that contains multiple vtkTree
/// objects. The superclass of this class, vtkDataReader, provides many methods for controlling the
/// reading of the data file, see vtkDataReader for more information.
/// </remarks>
/// <seealso>
///
/// vtkTree vtkDataReader
/// </seealso>
public class vtkMultiNewickTreeReader : vtkDataReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiNewickTreeReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiNewickTreeReader()
	{
		MRClassNameKey = "class vtkMultiNewickTreeReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiNewickTreeReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiNewickTreeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiNewickTreeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiNewickTreeReader New()
	{
		vtkMultiNewickTreeReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiNewickTreeReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiNewickTreeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMultiNewickTreeReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMultiNewickTreeReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkMultiNewickTreeReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiNewickTreeReader_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiNewickTreeReader_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiNewickTreeReader_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiNewickTreeReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output of this reader.
	/// </summary>
	public vtkMultiPieceDataSet GetOutput()
	{
		vtkMultiPieceDataSet vtkMultiPieceDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiNewickTreeReader_GetOutput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiPieceDataSet2 = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiPieceDataSet2.Register(null);
			}
		}
		return vtkMultiPieceDataSet2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiNewickTreeReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output of this reader.
	/// </summary>
	public vtkMultiPieceDataSet GetOutput(int idx)
	{
		vtkMultiPieceDataSet vtkMultiPieceDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiNewickTreeReader_GetOutput_04(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiPieceDataSet2 = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiPieceDataSet2.Register(null);
			}
		}
		return vtkMultiPieceDataSet2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiNewickTreeReader_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiNewickTreeReader_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiNewickTreeReader_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiNewickTreeReader_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiNewickTreeReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMultiNewickTreeReader NewInstance()
	{
		vtkMultiNewickTreeReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiNewickTreeReader_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiNewickTreeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiNewickTreeReader_ReadMeshSimple_09(HandleRef pThis, string fname, HandleRef output);

	/// <summary>
	/// Actual reading happens here
	/// </summary>
	public override int ReadMeshSimple(string fname, vtkDataObject output)
	{
		return vtkMultiNewickTreeReader_ReadMeshSimple_09(GetCppThis(), fname, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiNewickTreeReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiNewickTreeReader SafeDownCast(vtkObjectBase o)
	{
		vtkMultiNewickTreeReader vtkMultiNewickTreeReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiNewickTreeReader_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiNewickTreeReader2 = (vtkMultiNewickTreeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiNewickTreeReader2.Register(null);
			}
		}
		return vtkMultiNewickTreeReader2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiNewickTreeReader_SetOutput_11(HandleRef pThis, HandleRef output);

	/// <summary>
	/// Get the output of this reader.
	/// </summary>
	public void SetOutput(vtkMultiPieceDataSet output)
	{
		vtkMultiNewickTreeReader_SetOutput_11(GetCppThis(), output?.GetCppThis() ?? default(HandleRef));
	}
}
