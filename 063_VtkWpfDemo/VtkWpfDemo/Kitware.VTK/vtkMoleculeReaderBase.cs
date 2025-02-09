using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMoleculeReaderBase
/// </summary>
/// <remarks>
///    Read molecular data files
///
/// vtkMoleculeReaderBase is a source object that reads molecule files.
/// The FileName must be specified
///
/// @par Thanks:
/// Dr. Jean M. Favre who originally developed and contributed this class
/// Angelos Angelopoulos and Spiros Tsalikis for revisions
/// </remarks>
public abstract class vtkMoleculeReaderBase : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeReaderBase";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMoleculeReaderBase()
	{
		MRClassNameKey = "class vtkMoleculeReaderBase";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeReaderBase"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMoleculeReaderBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMoleculeReaderBase_GetBScale_01(HandleRef pThis);

	/// <summary>
	/// A scaling factor to compute bonds between non-hydrogen atoms
	/// </summary>
	public virtual double GetBScale()
	{
		return vtkMoleculeReaderBase_GetBScale_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeReaderBase_GetFileName_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMoleculeReaderBase_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMoleculeReaderBase_GetHBScale_03(HandleRef pThis);

	/// <summary>
	/// A scaling factor to compute bonds with hydrogen atoms.
	/// </summary>
	public virtual double GetHBScale()
	{
		return vtkMoleculeReaderBase_GetHBScale_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMoleculeReaderBase_GetNumberOfAtoms_04(HandleRef pThis);

	/// <summary>
	/// Number of atoms in the molecule.
	/// </summary>
	public virtual long GetNumberOfAtoms()
	{
		return vtkMoleculeReaderBase_GetNumberOfAtoms_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMoleculeReaderBase_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMoleculeReaderBase_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMoleculeReaderBase_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMoleculeReaderBase_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkMoleculeReaderBase_GetNumberOfModels_07(HandleRef pThis);

	/// <summary>
	/// Number of models that make up the molecule.
	/// </summary>
	public virtual uint GetNumberOfModels()
	{
		return vtkMoleculeReaderBase_GetNumberOfModels_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeReaderBase_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMoleculeReaderBase_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeReaderBase_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMoleculeReaderBase_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeReaderBase_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMoleculeReaderBase NewInstance()
	{
		vtkMoleculeReaderBase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeReaderBase_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMoleculeReaderBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeReaderBase_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMoleculeReaderBase SafeDownCast(vtkObjectBase o)
	{
		vtkMoleculeReaderBase vtkMoleculeReaderBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeReaderBase_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMoleculeReaderBase2 = (vtkMoleculeReaderBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMoleculeReaderBase2.Register(null);
			}
		}
		return vtkMoleculeReaderBase2;
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeReaderBase_SetBScale_12(HandleRef pThis, double _arg);

	/// <summary>
	/// A scaling factor to compute bonds between non-hydrogen atoms
	/// </summary>
	public virtual void SetBScale(double _arg)
	{
		vtkMoleculeReaderBase_SetBScale_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeReaderBase_SetFileName_13(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkMoleculeReaderBase_SetFileName_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeReaderBase_SetHBScale_14(HandleRef pThis, double _arg);

	/// <summary>
	/// A scaling factor to compute bonds with hydrogen atoms.
	/// </summary>
	public virtual void SetHBScale(double _arg)
	{
		vtkMoleculeReaderBase_SetHBScale_14(GetCppThis(), _arg);
	}
}
