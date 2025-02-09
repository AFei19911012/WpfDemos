using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProteinRibbonFilter
/// </summary>
/// <remarks>
///    generates protein ribbons
///
/// vtkProteinRibbonFilter is a polydata algorithm that generates protein
/// ribbons.
/// </remarks>
public class vtkProteinRibbonFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProteinRibbonFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProteinRibbonFilter()
	{
		MRClassNameKey = "class vtkProteinRibbonFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProteinRibbonFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProteinRibbonFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProteinRibbonFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProteinRibbonFilter New()
	{
		vtkProteinRibbonFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProteinRibbonFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProteinRibbonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProteinRibbonFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProteinRibbonFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern float vtkProteinRibbonFilter_GetCoilWidth_01(HandleRef pThis);

	/// <summary>
	/// Width of the ribbon coil. Default is 0.3.
	/// </summary>
	public virtual float GetCoilWidth()
	{
		return vtkProteinRibbonFilter_GetCoilWidth_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProteinRibbonFilter_GetDrawSmallMoleculesAsSpheres_02(HandleRef pThis);

	/// <summary>
	/// If enabled, small molecules (HETATMs) are drawn as spheres. Default is true.
	/// </summary>
	public virtual bool GetDrawSmallMoleculesAsSpheres()
	{
		return (vtkProteinRibbonFilter_GetDrawSmallMoleculesAsSpheres_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProteinRibbonFilter_GetHelixWidth_03(HandleRef pThis);

	/// <summary>
	/// Width of the helix part of the ribbon. Default is 1.3.
	/// </summary>
	public virtual float GetHelixWidth()
	{
		return vtkProteinRibbonFilter_GetHelixWidth_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProteinRibbonFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProteinRibbonFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProteinRibbonFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProteinRibbonFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProteinRibbonFilter_GetSphereResolution_06(HandleRef pThis);

	/// <summary>
	/// Resolution of the spheres for small molecules. Default is 20.
	/// </summary>
	public virtual int GetSphereResolution()
	{
		return vtkProteinRibbonFilter_GetSphereResolution_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProteinRibbonFilter_GetSubdivideFactor_07(HandleRef pThis);

	/// <summary>
	/// Smoothing factor of the ribbon. Default is 20.
	/// </summary>
	public virtual int GetSubdivideFactor()
	{
		return vtkProteinRibbonFilter_GetSubdivideFactor_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProteinRibbonFilter_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProteinRibbonFilter_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProteinRibbonFilter_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProteinRibbonFilter_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProteinRibbonFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProteinRibbonFilter NewInstance()
	{
		vtkProteinRibbonFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProteinRibbonFilter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProteinRibbonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProteinRibbonFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProteinRibbonFilter SafeDownCast(vtkObjectBase o)
	{
		vtkProteinRibbonFilter vtkProteinRibbonFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProteinRibbonFilter_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProteinRibbonFilter2 = (vtkProteinRibbonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProteinRibbonFilter2.Register(null);
			}
		}
		return vtkProteinRibbonFilter2;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProteinRibbonFilter_SetCoilWidth_13(HandleRef pThis, float _arg);

	/// <summary>
	/// Width of the ribbon coil. Default is 0.3.
	/// </summary>
	public virtual void SetCoilWidth(float _arg)
	{
		vtkProteinRibbonFilter_SetCoilWidth_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProteinRibbonFilter_SetDrawSmallMoleculesAsSpheres_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// If enabled, small molecules (HETATMs) are drawn as spheres. Default is true.
	/// </summary>
	public virtual void SetDrawSmallMoleculesAsSpheres(bool _arg)
	{
		vtkProteinRibbonFilter_SetDrawSmallMoleculesAsSpheres_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProteinRibbonFilter_SetHelixWidth_15(HandleRef pThis, float _arg);

	/// <summary>
	/// Width of the helix part of the ribbon. Default is 1.3.
	/// </summary>
	public virtual void SetHelixWidth(float _arg)
	{
		vtkProteinRibbonFilter_SetHelixWidth_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProteinRibbonFilter_SetSphereResolution_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Resolution of the spheres for small molecules. Default is 20.
	/// </summary>
	public virtual void SetSphereResolution(int _arg)
	{
		vtkProteinRibbonFilter_SetSphereResolution_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProteinRibbonFilter_SetSubdivideFactor_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Smoothing factor of the ribbon. Default is 20.
	/// </summary>
	public virtual void SetSubdivideFactor(int _arg)
	{
		vtkProteinRibbonFilter_SetSubdivideFactor_17(GetCppThis(), _arg);
	}
}
