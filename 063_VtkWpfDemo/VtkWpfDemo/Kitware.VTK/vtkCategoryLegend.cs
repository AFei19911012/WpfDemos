using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCategoryLegend
/// </summary>
/// <remarks>
///    Legend item to display categorical data.
///
/// vtkCategoryLegend will display a label and color patch for each value
/// in a categorical data set.  To use this class, you must first populate
/// a vtkScalarsToColors by using the SetAnnotation() method.  The other
/// input to this class is a vtkVariantArray.  This should contain the
/// annotated values from the vtkScalarsToColors that you wish to include
/// within the legend.
/// </remarks>
public class vtkCategoryLegend : vtkChartLegend
{
	/// <summary>
	/// Enum of legend orientation types
	/// </summary>
	public enum HORIZONTAL_WrapperEnum
	{
		/// <summary>enum member</summary>
		HORIZONTAL = 1,
		/// <summary>enum member</summary>
		VERTICAL = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCategoryLegend";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCategoryLegend()
	{
		MRClassNameKey = "class vtkCategoryLegend";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCategoryLegend"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCategoryLegend(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCategoryLegend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCategoryLegend New()
	{
		vtkCategoryLegend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCategoryLegend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCategoryLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCategoryLegend()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCategoryLegend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCategoryLegend_GetBoundingRect_01(HandleRef pThis, HandleRef painter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute and return the lower left corner of this legend, along
	/// with its width and height.
	/// </summary>
	public override vtkRectf GetBoundingRect(vtkContext2D painter)
	{
		vtkRectf result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCategoryLegend_GetBoundingRect_01(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCategoryLegend_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCategoryLegend_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCategoryLegend_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCategoryLegend_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkCategoryLegend_GetOutlierLabel_04(HandleRef pThis);

	/// <summary>
	/// Get/set the label to use for outlier data.
	/// </summary>
	public virtual string GetOutlierLabel()
	{
		return vtkCategoryLegend_GetOutlierLabel_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCategoryLegend_GetScalarsToColors_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the vtkScalarsToColors used to draw this legend.
	/// Since this legend represents categorical data, this
	/// vtkScalarsToColors must have been populated using SetAnnotation().
	/// </summary>
	public virtual vtkScalarsToColors GetScalarsToColors()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCategoryLegend_GetScalarsToColors_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkCategoryLegend_GetTitle_06(HandleRef pThis);

	/// <summary>
	/// Get/set the title text of the legend.
	/// </summary>
	public virtual string GetTitle()
	{
		return vtkCategoryLegend_GetTitle_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCategoryLegend_GetValues_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the array of values that will be represented by this legend.
	/// This array must contain distinct annotated values from the ScalarsToColors.
	/// Each value in this array will be drawn as a separate entry within this
	/// legend.
	/// </summary>
	public virtual vtkVariantArray GetValues()
	{
		vtkVariantArray vtkVariantArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCategoryLegend_GetValues_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVariantArray2 = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVariantArray2.Register(null);
			}
		}
		return vtkVariantArray2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCategoryLegend_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCategoryLegend_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCategoryLegend_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCategoryLegend_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCategoryLegend_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCategoryLegend NewInstance()
	{
		vtkCategoryLegend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCategoryLegend_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCategoryLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCategoryLegend_Paint_12(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint the legend into a rectangle defined by the bounds.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkCategoryLegend_Paint_12(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCategoryLegend_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCategoryLegend SafeDownCast(vtkObjectBase o)
	{
		vtkCategoryLegend vtkCategoryLegend2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCategoryLegend_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCategoryLegend2 = (vtkCategoryLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCategoryLegend2.Register(null);
			}
		}
		return vtkCategoryLegend2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCategoryLegend_SetOutlierLabel_14(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/set the label to use for outlier data.
	/// </summary>
	public virtual void SetOutlierLabel(string _arg)
	{
		vtkCategoryLegend_SetOutlierLabel_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCategoryLegend_SetScalarsToColors_15(HandleRef pThis, HandleRef stc);

	/// <summary>
	/// Get/Set the vtkScalarsToColors used to draw this legend.
	/// Since this legend represents categorical data, this
	/// vtkScalarsToColors must have been populated using SetAnnotation().
	/// </summary>
	public virtual void SetScalarsToColors(vtkScalarsToColors stc)
	{
		vtkCategoryLegend_SetScalarsToColors_15(GetCppThis(), stc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCategoryLegend_SetTitle_16(HandleRef pThis, string title);

	/// <summary>
	/// Get/set the title text of the legend.
	/// </summary>
	public virtual void SetTitle(string title)
	{
		vtkCategoryLegend_SetTitle_16(GetCppThis(), title);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCategoryLegend_SetValues_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the array of values that will be represented by this legend.
	/// This array must contain distinct annotated values from the ScalarsToColors.
	/// Each value in this array will be drawn as a separate entry within this
	/// legend.
	/// </summary>
	public virtual void SetValues(vtkVariantArray arg0)
	{
		vtkCategoryLegend_SetValues_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
