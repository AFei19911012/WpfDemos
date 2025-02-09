using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataSetRegionSurfaceFilter
/// </summary>
/// <remarks>
///    Extract surface of materials.
///
/// This filter extracts surfaces of materials such that a surface
/// could have a material on each side of it. It also stores a
/// mapping of the original cells and their sides back to the original grid
/// so that we can output boundary information for those cells given
/// only surfaces.
/// </remarks>
public class vtkDataSetRegionSurfaceFilter : vtkDataSetSurfaceFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetRegionSurfaceFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataSetRegionSurfaceFilter()
	{
		MRClassNameKey = "class vtkDataSetRegionSurfaceFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetRegionSurfaceFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataSetRegionSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetRegionSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataSetRegionSurfaceFilter New()
	{
		vtkDataSetRegionSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetRegionSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetRegionSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataSetRegionSurfaceFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataSetRegionSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetInterfaceIDsName_01(HandleRef pThis);

	/// <summary>
	/// The name of the field array that has material interface type identifiers in it
	/// Default is "interface_ids"
	/// </summary>
	public virtual string GetInterfaceIDsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter_GetInterfaceIDsName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetMaterialIDsName_02(HandleRef pThis);

	/// <summary>
	/// The name of the field array that has material type identifiers in it
	/// Default is "material_ids"
	/// </summary>
	public virtual string GetMaterialIDsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter_GetMaterialIDsName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetMaterialPIDsName_03(HandleRef pThis);

	/// <summary>
	/// The name of the output field array that records parent materials of each interface
	/// Default is "material_ancestors"
	/// </summary>
	public virtual string GetMaterialPIDsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter_GetMaterialPIDsName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetMaterialPropertiesName_04(HandleRef pThis);

	/// <summary>
	/// The name of the field array that has characteristics of each material
	/// Default is "material_properties"
	/// </summary>
	public virtual string GetMaterialPropertiesName()
	{
		return Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter_GetMaterialPropertiesName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetRegionSurfaceFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataSetRegionSurfaceFilter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetRegionSurfaceFilter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataSetRegionSurfaceFilter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetRegionArrayName_07(HandleRef pThis);

	/// <summary>
	/// The name of the cell based array that we use to extract interfaces from
	/// Default is "Regions"
	/// </summary>
	public virtual string GetRegionArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter_GetRegionArrayName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataSetRegionSurfaceFilter_GetSingleSided_08(HandleRef pThis);

	/// <summary>
	/// Whether to return single sided material interfaces or double sided
	/// Default is single
	/// </summary>
	public virtual bool GetSingleSided()
	{
		return (vtkDataSetRegionSurfaceFilter_GetSingleSided_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetRegionSurfaceFilter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataSetRegionSurfaceFilter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetRegionSurfaceFilter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataSetRegionSurfaceFilter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetRegionSurfaceFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataSetRegionSurfaceFilter NewInstance()
	{
		vtkDataSetRegionSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetRegionSurfaceFilter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetRegionSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetRegionSurfaceFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataSetRegionSurfaceFilter SafeDownCast(vtkObjectBase o)
	{
		vtkDataSetRegionSurfaceFilter vtkDataSetRegionSurfaceFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetRegionSurfaceFilter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetRegionSurfaceFilter2 = (vtkDataSetRegionSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetRegionSurfaceFilter2.Register(null);
			}
		}
		return vtkDataSetRegionSurfaceFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetRegionSurfaceFilter_SetInterfaceIDsName_14(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the field array that has material interface type identifiers in it
	/// Default is "interface_ids"
	/// </summary>
	public virtual void SetInterfaceIDsName(string _arg)
	{
		vtkDataSetRegionSurfaceFilter_SetInterfaceIDsName_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetRegionSurfaceFilter_SetMaterialIDsName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the field array that has material type identifiers in it
	/// Default is "material_ids"
	/// </summary>
	public virtual void SetMaterialIDsName(string _arg)
	{
		vtkDataSetRegionSurfaceFilter_SetMaterialIDsName_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetRegionSurfaceFilter_SetMaterialPIDsName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the output field array that records parent materials of each interface
	/// Default is "material_ancestors"
	/// </summary>
	public virtual void SetMaterialPIDsName(string _arg)
	{
		vtkDataSetRegionSurfaceFilter_SetMaterialPIDsName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetRegionSurfaceFilter_SetMaterialPropertiesName_17(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the field array that has characteristics of each material
	/// Default is "material_properties"
	/// </summary>
	public virtual void SetMaterialPropertiesName(string _arg)
	{
		vtkDataSetRegionSurfaceFilter_SetMaterialPropertiesName_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetRegionSurfaceFilter_SetRegionArrayName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the cell based array that we use to extract interfaces from
	/// Default is "Regions"
	/// </summary>
	public virtual void SetRegionArrayName(string _arg)
	{
		vtkDataSetRegionSurfaceFilter_SetRegionArrayName_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetRegionSurfaceFilter_SetSingleSided_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to return single sided material interfaces or double sided
	/// Default is single
	/// </summary>
	public virtual void SetSingleSided(bool _arg)
	{
		vtkDataSetRegionSurfaceFilter_SetSingleSided_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetRegionSurfaceFilter_UnstructuredGridExecute_20(HandleRef pThis, HandleRef input, HandleRef output);

	/// <summary>
	/// The name of the cell based array that we use to extract interfaces from
	/// Default is "Regions"
	/// </summary>
	public override int UnstructuredGridExecute(vtkDataSet input, vtkPolyData output)
	{
		return vtkDataSetRegionSurfaceFilter_UnstructuredGridExecute_20(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}
}
