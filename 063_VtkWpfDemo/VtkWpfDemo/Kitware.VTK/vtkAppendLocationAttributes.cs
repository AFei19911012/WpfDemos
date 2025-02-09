using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAppendLocationAttributes
/// </summary>
/// <remarks>
///    add point locations to point data and/or cell centers cell data, respectively
///
/// vtkAppendLocationAttributes is a filter that takes as input any dataset and
/// optionally adds points as point data and optionally adds cell center locations as
/// cell data in the output. The center of a cell is its parametric center, not necessarily
/// the geometric or bounding box center. Point and cell attributes in the input can optionally
/// be copied to the output.
///
/// @note
/// Empty cells will have their center set to (0, 0, 0).
///
/// </remarks>
/// <seealso>
///
/// vtkCellCenters
/// </seealso>
public class vtkAppendLocationAttributes : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAppendLocationAttributes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAppendLocationAttributes()
	{
		MRClassNameKey = "class vtkAppendLocationAttributes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendLocationAttributes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAppendLocationAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendLocationAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendLocationAttributes New()
	{
		vtkAppendLocationAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendLocationAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendLocationAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAppendLocationAttributes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAppendLocationAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendLocationAttributes_AppendCellCentersOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether input cell center locations should be saved as a cell data array.
	/// Default is `true` i.e. the cell centers will be propagated as a cell data array named
	/// "CellCenters".
	/// </summary>
	public virtual void AppendCellCentersOff()
	{
		vtkAppendLocationAttributes_AppendCellCentersOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendLocationAttributes_AppendCellCentersOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether input cell center locations should be saved as a cell data array.
	/// Default is `true` i.e. the cell centers will be propagated as a cell data array named
	/// "CellCenters".
	/// </summary>
	public virtual void AppendCellCentersOn()
	{
		vtkAppendLocationAttributes_AppendCellCentersOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendLocationAttributes_AppendPointLocationsOff_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether input point locations should be saved as a point data array.
	/// Default is `true` i.e. the points will be propagated as a point data array named
	/// "PointLocations".
	/// </summary>
	public virtual void AppendPointLocationsOff()
	{
		vtkAppendLocationAttributes_AppendPointLocationsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendLocationAttributes_AppendPointLocationsOn_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether input point locations should be saved as a point data array.
	/// Default is `true` i.e. the points will be propagated as a point data array named
	/// "PointLocations".
	/// </summary>
	public virtual void AppendPointLocationsOn()
	{
		vtkAppendLocationAttributes_AppendPointLocationsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAppendLocationAttributes_GetAppendCellCenters_05(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether input cell center locations should be saved as a cell data array.
	/// Default is `true` i.e. the cell centers will be propagated as a cell data array named
	/// "CellCenters".
	/// </summary>
	public virtual bool GetAppendCellCenters()
	{
		return (vtkAppendLocationAttributes_GetAppendCellCenters_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAppendLocationAttributes_GetAppendPointLocations_06(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether input point locations should be saved as a point data array.
	/// Default is `true` i.e. the points will be propagated as a point data array named
	/// "PointLocations".
	/// </summary>
	public virtual bool GetAppendPointLocations()
	{
		return (vtkAppendLocationAttributes_GetAppendPointLocations_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendLocationAttributes_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAppendLocationAttributes_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendLocationAttributes_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAppendLocationAttributes_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendLocationAttributes_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAppendLocationAttributes_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendLocationAttributes_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAppendLocationAttributes_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendLocationAttributes_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAppendLocationAttributes NewInstance()
	{
		vtkAppendLocationAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendLocationAttributes_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendLocationAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendLocationAttributes_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendLocationAttributes SafeDownCast(vtkObjectBase o)
	{
		vtkAppendLocationAttributes vtkAppendLocationAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendLocationAttributes_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAppendLocationAttributes2 = (vtkAppendLocationAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAppendLocationAttributes2.Register(null);
			}
		}
		return vtkAppendLocationAttributes2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendLocationAttributes_SetAppendCellCenters_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable whether input cell center locations should be saved as a cell data array.
	/// Default is `true` i.e. the cell centers will be propagated as a cell data array named
	/// "CellCenters".
	/// </summary>
	public virtual void SetAppendCellCenters(bool _arg)
	{
		vtkAppendLocationAttributes_SetAppendCellCenters_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendLocationAttributes_SetAppendPointLocations_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable whether input point locations should be saved as a point data array.
	/// Default is `true` i.e. the points will be propagated as a point data array named
	/// "PointLocations".
	/// </summary>
	public virtual void SetAppendPointLocations(bool _arg)
	{
		vtkAppendLocationAttributes_SetAppendPointLocations_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
