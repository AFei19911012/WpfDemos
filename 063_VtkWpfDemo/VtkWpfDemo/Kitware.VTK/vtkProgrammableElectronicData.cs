using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProgrammableElectronicData
/// </summary>
/// <remarks>
///    Provides access to and storage of
/// user-generated vtkImageData that describes electrons.
/// </remarks>
public class vtkProgrammableElectronicData : vtkAbstractElectronicData
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableElectronicData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProgrammableElectronicData()
	{
		MRClassNameKey = "class vtkProgrammableElectronicData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableElectronicData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProgrammableElectronicData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableElectronicData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableElectronicData New()
	{
		vtkProgrammableElectronicData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableElectronicData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableElectronicData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProgrammableElectronicData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProgrammableElectronicData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkProgrammableElectronicData_DeepCopy_01(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// Deep copies the data object into this.
	/// </summary>
	public override void DeepCopy(vtkDataObject obj)
	{
		vtkProgrammableElectronicData_DeepCopy_01(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableElectronicData_GetElectronDensity_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the vtkImageData for the molecule's electron density.
	/// </summary>
	public override vtkImageData GetElectronDensity()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableElectronicData_GetElectronDensity_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableElectronicData_GetMO_03(HandleRef pThis, long orbitalNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the vtkImageData for the requested molecular orbital.
	/// </summary>
	public override vtkImageData GetMO(long orbitalNumber)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableElectronicData_GetMO_03(GetCppThis(), orbitalNumber, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableElectronicData_GetNumberOfElectrons_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of electrons in the molecule. Needed for HOMO/LUMO
	/// convenience functions
	/// </summary>
	public override long GetNumberOfElectrons()
	{
		return vtkProgrammableElectronicData_GetNumberOfElectrons_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableElectronicData_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProgrammableElectronicData_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableElectronicData_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProgrammableElectronicData_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableElectronicData_GetNumberOfMOs_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of molecular orbitals. Setting this will resize this
	/// internal array of MOs.
	/// </summary>
	public override long GetNumberOfMOs()
	{
		return vtkProgrammableElectronicData_GetNumberOfMOs_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableElectronicData_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProgrammableElectronicData_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableElectronicData_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProgrammableElectronicData_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableElectronicData_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProgrammableElectronicData NewInstance()
	{
		vtkProgrammableElectronicData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableElectronicData_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableElectronicData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableElectronicData_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableElectronicData SafeDownCast(vtkObjectBase o)
	{
		vtkProgrammableElectronicData vtkProgrammableElectronicData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableElectronicData_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProgrammableElectronicData2 = (vtkProgrammableElectronicData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProgrammableElectronicData2.Register(null);
			}
		}
		return vtkProgrammableElectronicData2;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableElectronicData_SetElectronDensity_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the vtkImageData for the molecule's electron density.
	/// </summary>
	public virtual void SetElectronDensity(vtkImageData arg0)
	{
		vtkProgrammableElectronicData_SetElectronDensity_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableElectronicData_SetMO_14(HandleRef pThis, long orbitalNumber, HandleRef data);

	/// <summary>
	/// Get/Set the vtkImageData for the requested molecular orbital.
	/// </summary>
	public void SetMO(long orbitalNumber, vtkImageData data)
	{
		vtkProgrammableElectronicData_SetMO_14(GetCppThis(), orbitalNumber, data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableElectronicData_SetNumberOfElectrons_15(HandleRef pThis, long _arg);

	/// <summary>
	/// Get/Set the number of electrons in the molecule. Needed for HOMO/LUMO
	/// convenience functions
	/// </summary>
	public virtual void SetNumberOfElectrons(long _arg)
	{
		vtkProgrammableElectronicData_SetNumberOfElectrons_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableElectronicData_SetNumberOfMOs_16(HandleRef pThis, long arg0);

	/// <summary>
	/// Get/Set the number of molecular orbitals. Setting this will resize this
	/// internal array of MOs.
	/// </summary>
	public virtual void SetNumberOfMOs(long arg0)
	{
		vtkProgrammableElectronicData_SetNumberOfMOs_16(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableElectronicData_SetPadding_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the padding around the molecule to which the cube extends. This
	/// is used to determine the dataset bounds.
	/// </summary>
	public virtual void SetPadding(double _arg)
	{
		vtkProgrammableElectronicData_SetPadding_17(GetCppThis(), _arg);
	}
}
