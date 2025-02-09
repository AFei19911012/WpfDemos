using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSimpleBondPerceiver
/// </summary>
/// <remarks>
///    Create a simple guess of a molecule's
/// topology
///
///
///
/// vtkSimpleBondPerceiver performs a simple check of all interatomic distances
/// and adds a single bond between atoms that are reasonably close. If the
/// interatomic distance is less than the sum of the two atom's covalent radii
/// plus a tolerance, a single bond is added.
///
///
/// @warning
/// This algorithm does not consider valences, hybridization, aromaticity, or
/// anything other than atomic separations. It will not produce anything other
/// than single bonds.
/// </remarks>
public class vtkSimpleBondPerceiver : vtkMoleculeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleBondPerceiver";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSimpleBondPerceiver()
	{
		MRClassNameKey = "class vtkSimpleBondPerceiver";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleBondPerceiver"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSimpleBondPerceiver(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleBondPerceiver_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimpleBondPerceiver New()
	{
		vtkSimpleBondPerceiver result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleBondPerceiver_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleBondPerceiver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSimpleBondPerceiver()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSimpleBondPerceiver_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkSimpleBondPerceiver_GetIsToleranceAbsolute_01(HandleRef pThis);

	/// <summary>
	/// Set/Get if the tolerance is absolute (i.e. added to radius)
	/// or not (i.e. multiplied with radius). Default is true.
	/// </summary>
	public virtual bool GetIsToleranceAbsolute()
	{
		return (vtkSimpleBondPerceiver_GetIsToleranceAbsolute_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleBondPerceiver_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSimpleBondPerceiver_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleBondPerceiver_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSimpleBondPerceiver_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSimpleBondPerceiver_GetTolerance_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance used in the comparisons. (Default: 0.45)
	/// </summary>
	public virtual float GetTolerance()
	{
		return vtkSimpleBondPerceiver_GetTolerance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleBondPerceiver_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSimpleBondPerceiver_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleBondPerceiver_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSimpleBondPerceiver_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleBondPerceiver_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSimpleBondPerceiver NewInstance()
	{
		vtkSimpleBondPerceiver result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleBondPerceiver_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleBondPerceiver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleBondPerceiver_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimpleBondPerceiver SafeDownCast(vtkObjectBase o)
	{
		vtkSimpleBondPerceiver vtkSimpleBondPerceiver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleBondPerceiver_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSimpleBondPerceiver2 = (vtkSimpleBondPerceiver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSimpleBondPerceiver2.Register(null);
			}
		}
		return vtkSimpleBondPerceiver2;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleBondPerceiver_SetIsToleranceAbsolute_10(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the tolerance is absolute (i.e. added to radius)
	/// or not (i.e. multiplied with radius). Default is true.
	/// </summary>
	public virtual void SetIsToleranceAbsolute(bool _arg)
	{
		vtkSimpleBondPerceiver_SetIsToleranceAbsolute_10(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleBondPerceiver_SetTolerance_11(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the tolerance used in the comparisons. (Default: 0.45)
	/// </summary>
	public virtual void SetTolerance(float _arg)
	{
		vtkSimpleBondPerceiver_SetTolerance_11(GetCppThis(), _arg);
	}
}
