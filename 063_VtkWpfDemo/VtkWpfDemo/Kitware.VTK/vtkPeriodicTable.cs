using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPeriodicTable
/// </summary>
/// <remarks>
///    Access to information about the elements.
///
///
/// Sourced from the Blue Obelisk Data Repository
///
/// </remarks>
/// <seealso>
///
/// vtkBlueObeliskData vtkBlueObeliskDataParser
/// </seealso>
public class vtkPeriodicTable : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPeriodicTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPeriodicTable()
	{
		MRClassNameKey = "class vtkPeriodicTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPeriodicTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPeriodicTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPeriodicTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPeriodicTable New()
	{
		vtkPeriodicTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPeriodicTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPeriodicTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPeriodicTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPeriodicTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkPeriodicTable_GetAtomicNumber_01(HandleRef pThis, string str);

	/// <summary>
	/// Given a case-insensitive string that contains the symbol or name
	/// of an element, return the corresponding atomic number.
	/// </summary>
	public ushort GetAtomicNumber(string str)
	{
		return vtkPeriodicTable_GetAtomicNumber_01(GetCppThis(), str);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPeriodicTable_GetCovalentRadius_02(HandleRef pThis, ushort atomicNum);

	/// <summary>
	/// Given an atomic number, return the covalent radius of the atom
	/// </summary>
	public float GetCovalentRadius(ushort atomicNum)
	{
		return vtkPeriodicTable_GetCovalentRadius_02(GetCppThis(), atomicNum);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPeriodicTable_GetDefaultLUT_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Fill the given vtkLookupTable to map atomic numbers to the
	/// familiar RGB tuples provided by the Blue Obelisk Data Repository
	/// </summary>
	public void GetDefaultLUT(vtkLookupTable arg0)
	{
		vtkPeriodicTable_GetDefaultLUT_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPeriodicTable_GetDefaultRGBTuple_04(HandleRef pThis, ushort atomicNum, IntPtr rgb);

	/// <summary>
	/// Given an atomic number, return the familiar RGB tuple provided by
	/// the Blue Obelisk Data Repository
	/// </summary>
	public void GetDefaultRGBTuple(ushort atomicNum, IntPtr rgb)
	{
		vtkPeriodicTable_GetDefaultRGBTuple_04(GetCppThis(), atomicNum, rgb);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPeriodicTable_GetDefaultRGBTuple_05(HandleRef pThis, ushort atomicNum, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given an atomic number, return the familiar RGB tuple provided by
	/// the Blue Obelisk Data Repository
	/// </summary>
	public vtkColor3f GetDefaultRGBTuple(ushort atomicNum)
	{
		vtkColor3f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPeriodicTable_GetDefaultRGBTuple_05(GetCppThis(), atomicNum, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor3f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPeriodicTable_GetElementName_06(HandleRef pThis, ushort atomicNum);

	/// <summary>
	/// Given an atomic number, returns the name of the element
	/// </summary>
	public string GetElementName(ushort atomicNum)
	{
		return Marshal.PtrToStringAnsi(vtkPeriodicTable_GetElementName_06(GetCppThis(), atomicNum));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPeriodicTable_GetMaxVDWRadius_07(HandleRef pThis);

	/// <summary>
	/// Given an atomic number, returns the van der Waals radius of the
	/// atom
	/// </summary>
	public float GetMaxVDWRadius()
	{
		return vtkPeriodicTable_GetMaxVDWRadius_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkPeriodicTable_GetNumberOfElements_08(HandleRef pThis);

	/// <summary>
	/// Returns the number of elements in the periodic table.
	/// </summary>
	public ushort GetNumberOfElements()
	{
		return vtkPeriodicTable_GetNumberOfElements_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPeriodicTable_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPeriodicTable_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPeriodicTable_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPeriodicTable_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPeriodicTable_GetSymbol_11(HandleRef pThis, ushort atomicNum);

	/// <summary>
	/// Given an atomic number, returns the symbol associated with the
	/// element
	/// </summary>
	public string GetSymbol(ushort atomicNum)
	{
		return Marshal.PtrToStringAnsi(vtkPeriodicTable_GetSymbol_11(GetCppThis(), atomicNum));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPeriodicTable_GetVDWRadius_12(HandleRef pThis, ushort atomicNum);

	/// <summary>
	/// Given an atomic number, returns the van der Waals radius of the
	/// atom
	/// </summary>
	public float GetVDWRadius(ushort atomicNum)
	{
		return vtkPeriodicTable_GetVDWRadius_12(GetCppThis(), atomicNum);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPeriodicTable_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPeriodicTable_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPeriodicTable_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPeriodicTable_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPeriodicTable_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPeriodicTable NewInstance()
	{
		vtkPeriodicTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPeriodicTable_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPeriodicTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPeriodicTable_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPeriodicTable SafeDownCast(vtkObjectBase o)
	{
		vtkPeriodicTable vtkPeriodicTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPeriodicTable_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPeriodicTable2 = (vtkPeriodicTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPeriodicTable2.Register(null);
			}
		}
		return vtkPeriodicTable2;
	}
}
