using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///
/// Copyright (c) 2000 - 2009, Lawrence Livermore National Security, LLC
/// Produced at the Lawrence Livermore National Laboratory
/// LLNL-CODE-400124
/// All rights reserved.
///
/// This file was adapted from the ASCII Tecplot reader of VisIt. For details,
/// see https://visit.llnl.gov/.  The full copyright notice is contained in the
/// file COPYRIGHT located at the root of the VisIt distribution or at
/// http://www.llnl.gov/visit/copyright.html.
///
/// </summary>
public class vtkTecplotReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTecplotReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTecplotReader()
	{
		MRClassNameKey = "class vtkTecplotReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTecplotReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTecplotReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTecplotReader New()
	{
		vtkTecplotReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTecplotReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTecplotReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTecplotReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTecplotReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotReader_GetBlockName_01(HandleRef pThis, int blockIdx);

	/// <summary>
	/// Get the name of a block specified by a zero-based index. nullptr is returned
	/// for an invalid block index.
	/// </summary>
	public string GetBlockName(int blockIdx)
	{
		return Marshal.PtrToStringAnsi(vtkTecplotReader_GetBlockName_01(GetCppThis(), blockIdx));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotReader_GetDataArrayName_02(HandleRef pThis, int arrayIdx);

	/// <summary>
	/// Get the name of a data array specified by the zero-based index (arrayIdx).
	/// </summary>
	public string GetDataArrayName(int arrayIdx)
	{
		return Marshal.PtrToStringAnsi(vtkTecplotReader_GetDataArrayName_02(GetCppThis(), arrayIdx));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotReader_GetDataArrayStatus_03(HandleRef pThis, string arayName);

	/// <summary>
	/// Get the status of a specific data array (0: un-selected; 1: selected).
	/// </summary>
	public int GetDataArrayStatus(string arayName)
	{
		return vtkTecplotReader_GetDataArrayStatus_03(GetCppThis(), arayName);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotReader_GetDataAttributeName_04(HandleRef pThis, int attrIndx);

	/// <summary>
	/// Get the name of a zero-based data attribute (not 3D coordinates). nullptr is
	/// returned for an invalid attribute index.
	/// </summary>
	public string GetDataAttributeName(int attrIndx)
	{
		return Marshal.PtrToStringAnsi(vtkTecplotReader_GetDataAttributeName_04(GetCppThis(), attrIndx));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotReader_GetDataTitle_05(HandleRef pThis);

	/// <summary>
	/// Get the Tecplot data title.
	/// </summary>
	public string GetDataTitle()
	{
		return Marshal.PtrToStringAnsi(vtkTecplotReader_GetDataTitle_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotReader_GetNumberOfBlocks_06(HandleRef pThis);

	/// <summary>
	/// Get the number of blocks (i.e., zones in Tecplot terms).
	/// </summary>
	public int GetNumberOfBlocks()
	{
		return vtkTecplotReader_GetNumberOfBlocks_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotReader_GetNumberOfDataArrays_07(HandleRef pThis);

	/// <summary>
	/// Get the number of all data attributes (point data and cell data).
	/// </summary>
	public int GetNumberOfDataArrays()
	{
		return vtkTecplotReader_GetNumberOfDataArrays_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotReader_GetNumberOfDataAttributes_08(HandleRef pThis);

	/// <summary>
	/// Get the number of standard data attributes (node-based and cell-based),
	/// excluding 3D coordinates.
	/// </summary>
	public int GetNumberOfDataAttributes()
	{
		return vtkTecplotReader_GetNumberOfDataAttributes_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTecplotReader_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTecplotReader_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTecplotReader_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTecplotReader_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotReader_GetNumberOfVariables_11(HandleRef pThis);

	/// <summary>
	/// Get the number of all variables (including 3D coordinates).
	/// </summary>
	public virtual int GetNumberOfVariables()
	{
		return vtkTecplotReader_GetNumberOfVariables_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotReader_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTecplotReader_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotReader_IsDataAttributeCellBased_13(HandleRef pThis, string attrName);

	/// <summary>
	/// Get the type (0 for node-based and 1 for cell-based) of a specified data
	/// attribute (not 3D coordinates). -1 is returned for an invalid attribute
	/// name.
	/// </summary>
	public int IsDataAttributeCellBased(string attrName)
	{
		return vtkTecplotReader_IsDataAttributeCellBased_13(GetCppThis(), attrName);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotReader_IsDataAttributeCellBased_14(HandleRef pThis, int attrIndx);

	/// <summary>
	/// Get the type (0 for node-based and 1 for cell-based) of a specified data
	/// attribute (not 3D coordinates). -1 is returned for an invalid attribute
	/// index.
	/// </summary>
	public int IsDataAttributeCellBased(int attrIndx)
	{
		return vtkTecplotReader_IsDataAttributeCellBased_14(GetCppThis(), attrIndx);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotReader_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTecplotReader_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTecplotReader NewInstance()
	{
		vtkTecplotReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTecplotReader_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTecplotReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotReader_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTecplotReader SafeDownCast(vtkObjectBase o)
	{
		vtkTecplotReader vtkTecplotReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTecplotReader_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTecplotReader2 = (vtkTecplotReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTecplotReader2.Register(null);
			}
		}
		return vtkTecplotReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotReader_SetDataArrayStatus_19(HandleRef pThis, string arayName, int bChecked);

	/// <summary>
	/// Set the status of a specific data array (0: de-select; 1: select) specified
	/// by the name.
	/// </summary>
	public void SetDataArrayStatus(string arayName, int bChecked)
	{
		vtkTecplotReader_SetDataArrayStatus_19(GetCppThis(), arayName, bChecked);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotReader_SetFileName_20(HandleRef pThis, string fileName);

	/// <summary>
	/// Specify a Tecplot ASCII file for data loading.
	/// </summary>
	public void SetFileName(string fileName)
	{
		vtkTecplotReader_SetFileName_20(GetCppThis(), fileName);
	}
}
