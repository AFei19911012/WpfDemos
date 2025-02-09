using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractElectronicData
/// </summary>
/// <remarks>
///    Provides access to and storage of
/// chemical electronic data
///
/// </remarks>
public abstract class vtkAbstractElectronicData : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractElectronicData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractElectronicData()
	{
		MRClassNameKey = "class vtkAbstractElectronicData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractElectronicData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractElectronicData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractElectronicData_DeepCopy_01(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// Deep copies the data object into this.
	/// </summary>
	public override void DeepCopy(vtkDataObject obj)
	{
		vtkAbstractElectronicData_DeepCopy_01(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractElectronicData_GetDataObjectType_02(HandleRef pThis);

	/// <summary>
	/// Returns `VTK_ABSTRACT_ELECTRONIC_DATA`.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkAbstractElectronicData_GetDataObjectType_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractElectronicData_GetElectronDensity_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns vtkImageData for the molecule's electron density. The data
	/// will be calculated when first requested, and cached for later requests.
	/// </summary>
	public virtual vtkImageData GetElectronDensity()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractElectronicData_GetElectronDensity_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractElectronicData_GetHOMO_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns vtkImageData for the Highest Occupied Molecular Orbital.
	/// </summary>
	public vtkImageData GetHOMO()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractElectronicData_GetHOMO_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractElectronicData_GetHOMOOrbitalNumber_05(HandleRef pThis);

	/// <summary>
	/// Returns vtkImageData for the Lowest Unoccupied Molecular Orbital.
	/// </summary>
	public long GetHOMOOrbitalNumber()
	{
		return vtkAbstractElectronicData_GetHOMOOrbitalNumber_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractElectronicData_GetLUMO_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns vtkImageData for the Lowest Unoccupied Molecular Orbital.
	/// </summary>
	public vtkImageData GetLUMO()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractElectronicData_GetLUMO_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractElectronicData_GetLUMOOrbitalNumber_07(HandleRef pThis);

	/// <summary>
	/// Returns vtkImageData for the Lowest Unoccupied Molecular Orbital.
	/// </summary>
	public long GetLUMOOrbitalNumber()
	{
		return vtkAbstractElectronicData_GetLUMOOrbitalNumber_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractElectronicData_GetMO_08(HandleRef pThis, long orbitalNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the vtkImageData for the requested molecular orbital.
	/// </summary>
	public virtual vtkImageData GetMO(long orbitalNumber)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractElectronicData_GetMO_08(GetCppThis(), orbitalNumber, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractElectronicData_GetNumberOfElectrons_09(HandleRef pThis);

	/// <summary>
	/// Returns the number of electrons in the molecule.
	/// </summary>
	public virtual long GetNumberOfElectrons()
	{
		return vtkAbstractElectronicData_GetNumberOfElectrons_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractElectronicData_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractElectronicData_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractElectronicData_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractElectronicData_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractElectronicData_GetNumberOfMOs_12(HandleRef pThis);

	/// <summary>
	/// Returns the number of molecular orbitals available.
	/// </summary>
	public virtual long GetNumberOfMOs()
	{
		return vtkAbstractElectronicData_GetNumberOfMOs_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAbstractElectronicData_GetPadding_13(HandleRef pThis);

	/// <summary>
	/// Get the padding between the molecule and the cube boundaries. This is
	/// used to determine the dataset's bounds.
	/// </summary>
	public virtual double GetPadding()
	{
		return vtkAbstractElectronicData_GetPadding_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractElectronicData_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractElectronicData_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractElectronicData_IsHOMO_15(HandleRef pThis, long orbitalNumber);

	/// <summary>
	/// Returns true if the given orbital number is the Highest Occupied
	/// Molecular Orbital, false otherwise.
	/// </summary>
	public bool IsHOMO(long orbitalNumber)
	{
		return (vtkAbstractElectronicData_IsHOMO_15(GetCppThis(), orbitalNumber) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractElectronicData_IsLUMO_16(HandleRef pThis, long orbitalNumber);

	/// <summary>
	/// Returns true if the given orbital number is the Lowest Unoccupied
	/// Molecular Orbital, false otherwise.
	/// </summary>
	public bool IsLUMO(long orbitalNumber)
	{
		return (vtkAbstractElectronicData_IsLUMO_16(GetCppThis(), orbitalNumber) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractElectronicData_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractElectronicData_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractElectronicData_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractElectronicData NewInstance()
	{
		vtkAbstractElectronicData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractElectronicData_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractElectronicData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractElectronicData_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractElectronicData SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractElectronicData vtkAbstractElectronicData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractElectronicData_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractElectronicData2 = (vtkAbstractElectronicData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractElectronicData2.Register(null);
			}
		}
		return vtkAbstractElectronicData2;
	}
}
