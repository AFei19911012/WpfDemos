using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBlankStructuredGrid
/// </summary>
/// <remarks>
///    translate point attribute data into a blanking field
///
///
/// vtkBlankStructuredGrid is a filter that sets the blanking field in a
/// vtkStructuredGrid dataset. The blanking field is set by examining a
/// specified point attribute data array (e.g., scalars) and converting
/// values in the data array to either a "1" (visible) or "0" (blanked) value
/// in the blanking array. The values to be blanked are specified by giving
/// a min/max range. All data values in the data array indicated and laying
/// within the range specified (inclusive on both ends) are translated to
/// a "off" blanking value.
///
/// </remarks>
/// <seealso>
///
/// vtkStructuredGrid
/// </seealso>
public class vtkBlankStructuredGrid : vtkStructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBlankStructuredGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBlankStructuredGrid()
	{
		MRClassNameKey = "class vtkBlankStructuredGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlankStructuredGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBlankStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlankStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBlankStructuredGrid New()
	{
		vtkBlankStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlankStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBlankStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBlankStructuredGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBlankStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBlankStructuredGrid_GetArrayId_01(HandleRef pThis);

	/// <summary>
	/// Specify the data array id to use to generate the blanking
	/// field. Alternatively, you can specify the array name. (If both are set,
	/// the array name takes precedence.)
	/// </summary>
	public virtual int GetArrayId()
	{
		return vtkBlankStructuredGrid_GetArrayId_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlankStructuredGrid_GetArrayName_02(HandleRef pThis);

	/// <summary>
	/// Specify the data array name to use to generate the blanking
	/// field. Alternatively, you can specify the array id. (If both are set,
	/// the array name takes precedence.)
	/// </summary>
	public virtual string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkBlankStructuredGrid_GetArrayName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBlankStructuredGrid_GetComponent_03(HandleRef pThis);

	/// <summary>
	/// Specify the component in the data array to use to generate the blanking
	/// field.
	/// </summary>
	public virtual int GetComponent()
	{
		return vtkBlankStructuredGrid_GetComponent_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBlankStructuredGrid_GetComponentMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Specify the component in the data array to use to generate the blanking
	/// field.
	/// </summary>
	public virtual int GetComponentMaxValue()
	{
		return vtkBlankStructuredGrid_GetComponentMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBlankStructuredGrid_GetComponentMinValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the component in the data array to use to generate the blanking
	/// field.
	/// </summary>
	public virtual int GetComponentMinValue()
	{
		return vtkBlankStructuredGrid_GetComponentMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBlankStructuredGrid_GetMaxBlankingValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the upper data value in the data array specified which will be
	/// converted into a "blank" (or off) value in the blanking array.
	/// </summary>
	public virtual double GetMaxBlankingValue()
	{
		return vtkBlankStructuredGrid_GetMaxBlankingValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBlankStructuredGrid_GetMinBlankingValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the lower data value in the data array specified which will be
	/// converted into a "blank" (or off) value in the blanking array.
	/// </summary>
	public virtual double GetMinBlankingValue()
	{
		return vtkBlankStructuredGrid_GetMinBlankingValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBlankStructuredGrid_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBlankStructuredGrid_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBlankStructuredGrid_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBlankStructuredGrid_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBlankStructuredGrid_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBlankStructuredGrid_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBlankStructuredGrid_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBlankStructuredGrid_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlankStructuredGrid_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBlankStructuredGrid NewInstance()
	{
		vtkBlankStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlankStructuredGrid_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBlankStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlankStructuredGrid_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBlankStructuredGrid SafeDownCast(vtkObjectBase o)
	{
		vtkBlankStructuredGrid vtkBlankStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlankStructuredGrid_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBlankStructuredGrid2 = (vtkBlankStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBlankStructuredGrid2.Register(null);
			}
		}
		return vtkBlankStructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlankStructuredGrid_SetArrayId_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the data array id to use to generate the blanking
	/// field. Alternatively, you can specify the array name. (If both are set,
	/// the array name takes precedence.)
	/// </summary>
	public virtual void SetArrayId(int _arg)
	{
		vtkBlankStructuredGrid_SetArrayId_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlankStructuredGrid_SetArrayName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the data array name to use to generate the blanking
	/// field. Alternatively, you can specify the array id. (If both are set,
	/// the array name takes precedence.)
	/// </summary>
	public virtual void SetArrayName(string _arg)
	{
		vtkBlankStructuredGrid_SetArrayName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlankStructuredGrid_SetComponent_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the component in the data array to use to generate the blanking
	/// field.
	/// </summary>
	public virtual void SetComponent(int _arg)
	{
		vtkBlankStructuredGrid_SetComponent_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlankStructuredGrid_SetMaxBlankingValue_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the upper data value in the data array specified which will be
	/// converted into a "blank" (or off) value in the blanking array.
	/// </summary>
	public virtual void SetMaxBlankingValue(double _arg)
	{
		vtkBlankStructuredGrid_SetMaxBlankingValue_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlankStructuredGrid_SetMinBlankingValue_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the lower data value in the data array specified which will be
	/// converted into a "blank" (or off) value in the blanking array.
	/// </summary>
	public virtual void SetMinBlankingValue(double _arg)
	{
		vtkBlankStructuredGrid_SetMinBlankingValue_19(GetCppThis(), _arg);
	}
}
