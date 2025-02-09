using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// Get/Set if the filter should look for lines in input cells and convert them
/// into bonds.
/// default is ON.
/// </summary>
public class vtkPointSetToMoleculeFilter : vtkMoleculeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetToMoleculeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointSetToMoleculeFilter()
	{
		MRClassNameKey = "class vtkPointSetToMoleculeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetToMoleculeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointSetToMoleculeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToMoleculeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkPointSetToMoleculeFilter New()
	{
		vtkPointSetToMoleculeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToMoleculeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSetToMoleculeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkPointSetToMoleculeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointSetToMoleculeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointSetToMoleculeFilter_ConvertLinesIntoBondsOff_01(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should look for lines in input cells and convert them
	/// into bonds.
	/// default is ON.
	/// </summary>
	public virtual void ConvertLinesIntoBondsOff()
	{
		vtkPointSetToMoleculeFilter_ConvertLinesIntoBondsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToMoleculeFilter_ConvertLinesIntoBondsOn_02(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should look for lines in input cells and convert them
	/// into bonds.
	/// default is ON.
	/// </summary>
	public virtual void ConvertLinesIntoBondsOn()
	{
		vtkPointSetToMoleculeFilter_ConvertLinesIntoBondsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSetToMoleculeFilter_GetConvertLinesIntoBonds_03(HandleRef pThis);

	/// <summary>
	/// Get/Set if the filter should look for lines in input cells and convert them
	/// into bonds.
	/// default is ON.
	/// </summary>
	public virtual bool GetConvertLinesIntoBonds()
	{
		return (vtkPointSetToMoleculeFilter_GetConvertLinesIntoBonds_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetToMoleculeFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointSetToMoleculeFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetToMoleculeFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointSetToMoleculeFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToMoleculeFilter_IsA_06(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkPointSetToMoleculeFilter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToMoleculeFilter_IsTypeOf_07(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkPointSetToMoleculeFilter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToMoleculeFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkPointSetToMoleculeFilter NewInstance()
	{
		vtkPointSetToMoleculeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToMoleculeFilter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSetToMoleculeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToMoleculeFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkPointSetToMoleculeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPointSetToMoleculeFilter vtkPointSetToMoleculeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToMoleculeFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSetToMoleculeFilter2 = (vtkPointSetToMoleculeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSetToMoleculeFilter2.Register(null);
			}
		}
		return vtkPointSetToMoleculeFilter2;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToMoleculeFilter_SetConvertLinesIntoBonds_11(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set if the filter should look for lines in input cells and convert them
	/// into bonds.
	/// default is ON.
	/// </summary>
	public virtual void SetConvertLinesIntoBonds(bool _arg)
	{
		vtkPointSetToMoleculeFilter_SetConvertLinesIntoBonds_11(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
