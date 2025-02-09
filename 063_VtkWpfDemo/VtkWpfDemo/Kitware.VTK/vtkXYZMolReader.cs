using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXYZMolReader
/// </summary>
/// <remarks>
///    read Molecular Data files
///
/// vtkXYZMolReader is a source object that reads Molecule files
/// The FileName must be specified
///
/// @par Thanks:
/// Dr. Jean M. Favre who developed and contributed this class
/// </remarks>
public class vtkXYZMolReader : vtkMoleculeReaderBase
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXYZMolReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXYZMolReader()
	{
		MRClassNameKey = "class vtkXYZMolReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXYZMolReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXYZMolReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXYZMolReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXYZMolReader New()
	{
		vtkXYZMolReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXYZMolReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXYZMolReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXYZMolReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXYZMolReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXYZMolReader_CanReadFile_01(HandleRef pThis, string name);

	/// <summary>
	/// Test whether the file with the given name can be read by this
	/// reader.
	/// </summary>
	public virtual int CanReadFile(string name)
	{
		return vtkXYZMolReader_CanReadFile_01(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXYZMolReader_GetMaxTimeStep_02(HandleRef pThis);

	/// <summary>
	/// Get the maximum time step.
	/// </summary>
	public virtual int GetMaxTimeStep()
	{
		return vtkXYZMolReader_GetMaxTimeStep_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXYZMolReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXYZMolReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXYZMolReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXYZMolReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXYZMolReader_GetTimeStep_05(HandleRef pThis);

	/// <summary>
	/// Set the current time step. It should be greater than 0 and smaller than
	/// MaxTimeStep.
	/// </summary>
	public virtual int GetTimeStep()
	{
		return vtkXYZMolReader_GetTimeStep_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXYZMolReader_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXYZMolReader_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXYZMolReader_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXYZMolReader_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXYZMolReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXYZMolReader NewInstance()
	{
		vtkXYZMolReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXYZMolReader_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXYZMolReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXYZMolReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXYZMolReader SafeDownCast(vtkObjectBase o)
	{
		vtkXYZMolReader vtkXYZMolReader3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXYZMolReader_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXYZMolReader3 = (vtkXYZMolReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXYZMolReader3.Register(null);
			}
		}
		return vtkXYZMolReader3;
	}

	[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXYZMolReader_SetTimeStep_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the current time step. It should be greater than 0 and smaller than
	/// MaxTimeStep.
	/// </summary>
	public virtual void SetTimeStep(int _arg)
	{
		vtkXYZMolReader_SetTimeStep_11(GetCppThis(), _arg);
	}
}
