using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAttributeDataToFieldDataFilter
/// </summary>
/// <remarks>
///    map attribute data to field data
///
/// vtkAttributeDataToFieldDataFilter is a class that maps attribute data into
/// field data. Since this filter is a subclass of vtkDataSetAlgorithm,
/// the output dataset (whose structure is the same as the input dataset),
/// will contain the field data that is generated. The filter will convert
/// point and cell attribute data to field data and assign it as point and
/// cell field data, replacing any point or field data that was there
/// previously. By default, the original non-field point and cell attribute
/// data will be passed to the output of the filter, although you can shut
/// this behavior down.
///
/// @warning
/// Reference counting the underlying data arrays is used to create the field
/// data.  Therefore, no extra memory is utilized.
///
/// @warning
/// The original field data (if any) associated with the point and cell
/// attribute data is placed into the generated fields along with the scalars,
/// vectors, etc.
///
/// </remarks>
/// <seealso>
///
/// vtkFieldData vtkDataObject vtkDataSet vtkFieldDataToAttributeDataFilter
/// </seealso>
public class vtkAttributeDataToFieldDataFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAttributeDataToFieldDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAttributeDataToFieldDataFilter()
	{
		MRClassNameKey = "class vtkAttributeDataToFieldDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributeDataToFieldDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAttributeDataToFieldDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeDataToFieldDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct this object.
	/// </summary>
	public new static vtkAttributeDataToFieldDataFilter New()
	{
		vtkAttributeDataToFieldDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeDataToFieldDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAttributeDataToFieldDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct this object.
	/// </summary>
	public vtkAttributeDataToFieldDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAttributeDataToFieldDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAttributeDataToFieldDataFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAttributeDataToFieldDataFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAttributeDataToFieldDataFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAttributeDataToFieldDataFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeDataToFieldDataFilter_GetPassAttributeData_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the passing of point and cell non-field attribute data to the
	/// output of the filter.
	/// </summary>
	public virtual int GetPassAttributeData()
	{
		return vtkAttributeDataToFieldDataFilter_GetPassAttributeData_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeDataToFieldDataFilter_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAttributeDataToFieldDataFilter_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeDataToFieldDataFilter_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAttributeDataToFieldDataFilter_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeDataToFieldDataFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAttributeDataToFieldDataFilter NewInstance()
	{
		vtkAttributeDataToFieldDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeDataToFieldDataFilter_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAttributeDataToFieldDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeDataToFieldDataFilter_PassAttributeDataOff_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the passing of point and cell non-field attribute data to the
	/// output of the filter.
	/// </summary>
	public virtual void PassAttributeDataOff()
	{
		vtkAttributeDataToFieldDataFilter_PassAttributeDataOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeDataToFieldDataFilter_PassAttributeDataOn_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the passing of point and cell non-field attribute data to the
	/// output of the filter.
	/// </summary>
	public virtual void PassAttributeDataOn()
	{
		vtkAttributeDataToFieldDataFilter_PassAttributeDataOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeDataToFieldDataFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAttributeDataToFieldDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAttributeDataToFieldDataFilter vtkAttributeDataToFieldDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeDataToFieldDataFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAttributeDataToFieldDataFilter2 = (vtkAttributeDataToFieldDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAttributeDataToFieldDataFilter2.Register(null);
			}
		}
		return vtkAttributeDataToFieldDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeDataToFieldDataFilter_SetPassAttributeData_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the passing of point and cell non-field attribute data to the
	/// output of the filter.
	/// </summary>
	public virtual void SetPassAttributeData(int _arg)
	{
		vtkAttributeDataToFieldDataFilter_SetPassAttributeData_11(GetCppThis(), _arg);
	}
}
