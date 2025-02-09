using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkApplyColors
/// </summary>
/// <remarks>
///    apply colors to a data set.
///
///
/// vtkApplyColors performs a coloring of the dataset using default colors,
/// lookup tables, annotations, and/or a selection. The output is a
/// four-component vtkUnsignedCharArray containing RGBA tuples for each
/// element in the dataset. The first input is the dataset to be colored, which
/// may be a vtkTable, vtkGraph subclass, or vtkDataSet subclass. The API
/// of this algorithm refers to "points" and "cells". For vtkGraph, the
/// "points" refer to the graph vertices and "cells" refer to graph edges.
/// For vtkTable, "points" refer to table rows. For vtkDataSet subclasses, the
/// meaning is obvious.
///
/// The second (optional) input is a vtkAnnotationLayers object, which stores
/// a list of annotation layers, with each layer holding a list of
/// vtkAnnotation objects. The annotation specifies a subset of data along with
/// other properties, including color. For annotations with color properties,
/// this algorithm will use the color to color elements, using a "top one wins"
/// strategy.
///
/// The third (optional) input is a vtkSelection object, meant for specifying
/// the current selection. You can control the color of the selection.
///
/// The algorithm takes two input arrays, specified with
/// SetInputArrayToProcess(0, 0, 0, vtkDataObject::FIELD_ASSOCIATION_POINTS, name)
/// and
/// SetInputArrayToProcess(1, 0, 0, vtkDataObject::FIELD_ASSOCIATION_CELLS, name).
/// These set the point and cell data arrays to use to color the data with
/// the associated lookup table. For vtkGraph, vtkTable inputs, you would use
/// FIELD_ASSOCIATION_VERTICES, FIELD_ASSOCIATION_EDGES, or
/// FIELD_ASSOCIATION_ROWS as appropriate.
///
/// To use the color array generated here, you should do the following:
///
///  mapper-&gt;SetScalarModeToUseCellFieldData();
///  mapper-&gt;SelectColorArray("vtkApplyColors color");
///  mapper-&gt;SetScalarVisibility(true);
///
/// Colors are assigned with the following priorities:
/// &lt;ol&gt;
/// &lt;li&gt; If an item is part of the selection, it is colored with that color.
/// &lt;li&gt; Otherwise, if the item is part of an annotation, it is colored
///      with the color of the final (top) annotation in the set of layers.
/// &lt;li&gt; Otherwise, if the lookup table is used, it is colored using the
///      lookup table color for the data value of the element.
/// &lt;li&gt; Otherwise it will be colored with the default color.
/// &lt;/ol&gt;
///
/// Note: The opacity of an unselected item is defined by the multiplication
/// of default opacity, lookup table opacity, and annotation opacity, where
/// opacity is taken as a number from 0 to 1. So items will never be more opaque
/// than any of these three opacities. Selected items are always given the
/// selection opacity directly.
/// </remarks>
public class vtkApplyColors : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkApplyColors";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkApplyColors()
	{
		MRClassNameKey = "class vtkApplyColors";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkApplyColors"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkApplyColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkApplyColors New()
	{
		vtkApplyColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkApplyColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkApplyColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkApplyColors()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkApplyColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_GetCellColorOutputArrayName_01(HandleRef pThis);

	/// <summary>
	/// The output array name for the cell color RGBA array.
	/// Default is "vtkApplyColors color".
	/// </summary>
	public virtual string GetCellColorOutputArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkApplyColors_GetCellColorOutputArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_GetCellLookupTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The lookup table to use for cell colors. This is only used if
	/// input array 1 is set and UseCellLookupTable is on.
	/// </summary>
	public virtual vtkScalarsToColors GetCellLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkApplyColors_GetCellLookupTable_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_GetDefaultCellColor_03(HandleRef pThis);

	/// <summary>
	/// The default cell color for all unannotated, unselected elements
	/// of the data. This is used if UseCellLookupTable is off.
	/// </summary>
	public virtual double[] GetDefaultCellColor()
	{
		IntPtr intPtr = vtkApplyColors_GetDefaultCellColor_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_GetDefaultCellColor_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The default cell color for all unannotated, unselected elements
	/// of the data. This is used if UseCellLookupTable is off.
	/// </summary>
	public virtual void GetDefaultCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkApplyColors_GetDefaultCellColor_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_GetDefaultCellColor_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The default cell color for all unannotated, unselected elements
	/// of the data. This is used if UseCellLookupTable is off.
	/// </summary>
	public virtual void GetDefaultCellColor(IntPtr _arg)
	{
		vtkApplyColors_GetDefaultCellColor_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkApplyColors_GetDefaultCellOpacity_06(HandleRef pThis);

	/// <summary>
	/// The default cell opacity for all unannotated, unselected elements
	/// of the data. This is used if UseCellLookupTable is off.
	/// </summary>
	public virtual double GetDefaultCellOpacity()
	{
		return vtkApplyColors_GetDefaultCellOpacity_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_GetDefaultPointColor_07(HandleRef pThis);

	/// <summary>
	/// The default point color for all unannotated, unselected elements
	/// of the data. This is used if UsePointLookupTable is off.
	/// </summary>
	public virtual double[] GetDefaultPointColor()
	{
		IntPtr intPtr = vtkApplyColors_GetDefaultPointColor_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_GetDefaultPointColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The default point color for all unannotated, unselected elements
	/// of the data. This is used if UsePointLookupTable is off.
	/// </summary>
	public virtual void GetDefaultPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkApplyColors_GetDefaultPointColor_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_GetDefaultPointColor_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The default point color for all unannotated, unselected elements
	/// of the data. This is used if UsePointLookupTable is off.
	/// </summary>
	public virtual void GetDefaultPointColor(IntPtr _arg)
	{
		vtkApplyColors_GetDefaultPointColor_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkApplyColors_GetDefaultPointOpacity_10(HandleRef pThis);

	/// <summary>
	/// The default point opacity for all unannotated, unselected elements
	/// of the data. This is used if UsePointLookupTable is off.
	/// </summary>
	public virtual double GetDefaultPointOpacity()
	{
		return vtkApplyColors_GetDefaultPointOpacity_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkApplyColors_GetMTime_11(HandleRef pThis);

	/// <summary>
	/// Retrieve the modified time for this filter.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkApplyColors_GetMTime_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkApplyColors_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkApplyColors_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkApplyColors_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkApplyColors_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_GetPointColorOutputArrayName_14(HandleRef pThis);

	/// <summary>
	/// The output array name for the point color RGBA array.
	/// Default is "vtkApplyColors color".
	/// </summary>
	public virtual string GetPointColorOutputArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkApplyColors_GetPointColorOutputArrayName_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_GetPointLookupTable_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The lookup table to use for point colors. This is only used if
	/// input array 0 is set and UsePointLookupTable is on.
	/// </summary>
	public virtual vtkScalarsToColors GetPointLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkApplyColors_GetPointLookupTable_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkApplyColors_GetScaleCellLookupTable_16(HandleRef pThis);

	/// <summary>
	/// If on, uses the range of the data to scale the lookup table range.
	/// Otherwise, uses the range defined in the lookup table.
	/// </summary>
	public virtual bool GetScaleCellLookupTable()
	{
		return (vtkApplyColors_GetScaleCellLookupTable_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkApplyColors_GetScalePointLookupTable_17(HandleRef pThis);

	/// <summary>
	/// If on, uses the range of the data to scale the lookup table range.
	/// Otherwise, uses the range defined in the lookup table.
	/// </summary>
	public virtual bool GetScalePointLookupTable()
	{
		return (vtkApplyColors_GetScalePointLookupTable_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_GetSelectedCellColor_18(HandleRef pThis);

	/// <summary>
	/// The cell color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual double[] GetSelectedCellColor()
	{
		IntPtr intPtr = vtkApplyColors_GetSelectedCellColor_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_GetSelectedCellColor_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The cell color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void GetSelectedCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkApplyColors_GetSelectedCellColor_19(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_GetSelectedCellColor_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The cell color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void GetSelectedCellColor(IntPtr _arg)
	{
		vtkApplyColors_GetSelectedCellColor_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkApplyColors_GetSelectedCellOpacity_21(HandleRef pThis);

	/// <summary>
	/// The cell opacity for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual double GetSelectedCellOpacity()
	{
		return vtkApplyColors_GetSelectedCellOpacity_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_GetSelectedPointColor_22(HandleRef pThis);

	/// <summary>
	/// The point color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual double[] GetSelectedPointColor()
	{
		IntPtr intPtr = vtkApplyColors_GetSelectedPointColor_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_GetSelectedPointColor_23(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The point color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void GetSelectedPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkApplyColors_GetSelectedPointColor_23(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_GetSelectedPointColor_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The point color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void GetSelectedPointColor(IntPtr _arg)
	{
		vtkApplyColors_GetSelectedPointColor_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkApplyColors_GetSelectedPointOpacity_25(HandleRef pThis);

	/// <summary>
	/// The point opacity for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual double GetSelectedPointOpacity()
	{
		return vtkApplyColors_GetSelectedPointOpacity_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkApplyColors_GetUseCellLookupTable_26(HandleRef pThis);

	/// <summary>
	/// If on, uses the cell lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual bool GetUseCellLookupTable()
	{
		return (vtkApplyColors_GetUseCellLookupTable_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkApplyColors_GetUseCurrentAnnotationColor_27(HandleRef pThis);

	/// <summary>
	/// Use the annotation to color the current annotation
	/// (i.e. the current selection). Otherwise use the selection
	/// color attributes of this filter.
	/// </summary>
	public virtual bool GetUseCurrentAnnotationColor()
	{
		return (vtkApplyColors_GetUseCurrentAnnotationColor_27(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkApplyColors_GetUsePointLookupTable_28(HandleRef pThis);

	/// <summary>
	/// If on, uses the point lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual bool GetUsePointLookupTable()
	{
		return (vtkApplyColors_GetUsePointLookupTable_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkApplyColors_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkApplyColors_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkApplyColors_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkApplyColors_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkApplyColors NewInstance()
	{
		vtkApplyColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkApplyColors_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkApplyColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyColors_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkApplyColors SafeDownCast(vtkObjectBase o)
	{
		vtkApplyColors vtkApplyColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkApplyColors_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkApplyColors2 = (vtkApplyColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkApplyColors2.Register(null);
			}
		}
		return vtkApplyColors2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_ScaleCellLookupTableOff_34(HandleRef pThis);

	/// <summary>
	/// If on, uses the range of the data to scale the lookup table range.
	/// Otherwise, uses the range defined in the lookup table.
	/// </summary>
	public virtual void ScaleCellLookupTableOff()
	{
		vtkApplyColors_ScaleCellLookupTableOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_ScaleCellLookupTableOn_35(HandleRef pThis);

	/// <summary>
	/// If on, uses the range of the data to scale the lookup table range.
	/// Otherwise, uses the range defined in the lookup table.
	/// </summary>
	public virtual void ScaleCellLookupTableOn()
	{
		vtkApplyColors_ScaleCellLookupTableOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_ScalePointLookupTableOff_36(HandleRef pThis);

	/// <summary>
	/// If on, uses the range of the data to scale the lookup table range.
	/// Otherwise, uses the range defined in the lookup table.
	/// </summary>
	public virtual void ScalePointLookupTableOff()
	{
		vtkApplyColors_ScalePointLookupTableOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_ScalePointLookupTableOn_37(HandleRef pThis);

	/// <summary>
	/// If on, uses the range of the data to scale the lookup table range.
	/// Otherwise, uses the range defined in the lookup table.
	/// </summary>
	public virtual void ScalePointLookupTableOn()
	{
		vtkApplyColors_ScalePointLookupTableOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetCellColorOutputArrayName_38(HandleRef pThis, string _arg);

	/// <summary>
	/// The output array name for the cell color RGBA array.
	/// Default is "vtkApplyColors color".
	/// </summary>
	public virtual void SetCellColorOutputArrayName(string _arg)
	{
		vtkApplyColors_SetCellColorOutputArrayName_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetCellLookupTable_39(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// The lookup table to use for cell colors. This is only used if
	/// input array 1 is set and UseCellLookupTable is on.
	/// </summary>
	public virtual void SetCellLookupTable(vtkScalarsToColors lut)
	{
		vtkApplyColors_SetCellLookupTable_39(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetDefaultCellColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The default cell color for all unannotated, unselected elements
	/// of the data. This is used if UseCellLookupTable is off.
	/// </summary>
	public virtual void SetDefaultCellColor(double _arg1, double _arg2, double _arg3)
	{
		vtkApplyColors_SetDefaultCellColor_40(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetDefaultCellColor_41(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The default cell color for all unannotated, unselected elements
	/// of the data. This is used if UseCellLookupTable is off.
	/// </summary>
	public virtual void SetDefaultCellColor(IntPtr _arg)
	{
		vtkApplyColors_SetDefaultCellColor_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetDefaultCellOpacity_42(HandleRef pThis, double _arg);

	/// <summary>
	/// The default cell opacity for all unannotated, unselected elements
	/// of the data. This is used if UseCellLookupTable is off.
	/// </summary>
	public virtual void SetDefaultCellOpacity(double _arg)
	{
		vtkApplyColors_SetDefaultCellOpacity_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetDefaultPointColor_43(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The default point color for all unannotated, unselected elements
	/// of the data. This is used if UsePointLookupTable is off.
	/// </summary>
	public virtual void SetDefaultPointColor(double _arg1, double _arg2, double _arg3)
	{
		vtkApplyColors_SetDefaultPointColor_43(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetDefaultPointColor_44(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The default point color for all unannotated, unselected elements
	/// of the data. This is used if UsePointLookupTable is off.
	/// </summary>
	public virtual void SetDefaultPointColor(IntPtr _arg)
	{
		vtkApplyColors_SetDefaultPointColor_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetDefaultPointOpacity_45(HandleRef pThis, double _arg);

	/// <summary>
	/// The default point opacity for all unannotated, unselected elements
	/// of the data. This is used if UsePointLookupTable is off.
	/// </summary>
	public virtual void SetDefaultPointOpacity(double _arg)
	{
		vtkApplyColors_SetDefaultPointOpacity_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetPointColorOutputArrayName_46(HandleRef pThis, string _arg);

	/// <summary>
	/// The output array name for the point color RGBA array.
	/// Default is "vtkApplyColors color".
	/// </summary>
	public virtual void SetPointColorOutputArrayName(string _arg)
	{
		vtkApplyColors_SetPointColorOutputArrayName_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetPointLookupTable_47(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// The lookup table to use for point colors. This is only used if
	/// input array 0 is set and UsePointLookupTable is on.
	/// </summary>
	public virtual void SetPointLookupTable(vtkScalarsToColors lut)
	{
		vtkApplyColors_SetPointLookupTable_47(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetScaleCellLookupTable_48(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, uses the range of the data to scale the lookup table range.
	/// Otherwise, uses the range defined in the lookup table.
	/// </summary>
	public virtual void SetScaleCellLookupTable(bool _arg)
	{
		vtkApplyColors_SetScaleCellLookupTable_48(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetScalePointLookupTable_49(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, uses the range of the data to scale the lookup table range.
	/// Otherwise, uses the range defined in the lookup table.
	/// </summary>
	public virtual void SetScalePointLookupTable(bool _arg)
	{
		vtkApplyColors_SetScalePointLookupTable_49(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetSelectedCellColor_50(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The cell color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void SetSelectedCellColor(double _arg1, double _arg2, double _arg3)
	{
		vtkApplyColors_SetSelectedCellColor_50(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetSelectedCellColor_51(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The cell color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void SetSelectedCellColor(IntPtr _arg)
	{
		vtkApplyColors_SetSelectedCellColor_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetSelectedCellOpacity_52(HandleRef pThis, double _arg);

	/// <summary>
	/// The cell opacity for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void SetSelectedCellOpacity(double _arg)
	{
		vtkApplyColors_SetSelectedCellOpacity_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetSelectedPointColor_53(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The point color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void SetSelectedPointColor(double _arg1, double _arg2, double _arg3)
	{
		vtkApplyColors_SetSelectedPointColor_53(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetSelectedPointColor_54(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The point color for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void SetSelectedPointColor(IntPtr _arg)
	{
		vtkApplyColors_SetSelectedPointColor_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetSelectedPointOpacity_55(HandleRef pThis, double _arg);

	/// <summary>
	/// The point opacity for all selected elements of the data.
	/// This is used if the selection input is available.
	/// </summary>
	public virtual void SetSelectedPointOpacity(double _arg)
	{
		vtkApplyColors_SetSelectedPointOpacity_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetUseCellLookupTable_56(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, uses the cell lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual void SetUseCellLookupTable(bool _arg)
	{
		vtkApplyColors_SetUseCellLookupTable_56(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetUseCurrentAnnotationColor_57(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use the annotation to color the current annotation
	/// (i.e. the current selection). Otherwise use the selection
	/// color attributes of this filter.
	/// </summary>
	public virtual void SetUseCurrentAnnotationColor(bool _arg)
	{
		vtkApplyColors_SetUseCurrentAnnotationColor_57(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_SetUsePointLookupTable_58(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, uses the point lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual void SetUsePointLookupTable(bool _arg)
	{
		vtkApplyColors_SetUsePointLookupTable_58(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_UseCellLookupTableOff_59(HandleRef pThis);

	/// <summary>
	/// If on, uses the cell lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual void UseCellLookupTableOff()
	{
		vtkApplyColors_UseCellLookupTableOff_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_UseCellLookupTableOn_60(HandleRef pThis);

	/// <summary>
	/// If on, uses the cell lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual void UseCellLookupTableOn()
	{
		vtkApplyColors_UseCellLookupTableOn_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_UseCurrentAnnotationColorOff_61(HandleRef pThis);

	/// <summary>
	/// Use the annotation to color the current annotation
	/// (i.e. the current selection). Otherwise use the selection
	/// color attributes of this filter.
	/// </summary>
	public virtual void UseCurrentAnnotationColorOff()
	{
		vtkApplyColors_UseCurrentAnnotationColorOff_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_UseCurrentAnnotationColorOn_62(HandleRef pThis);

	/// <summary>
	/// Use the annotation to color the current annotation
	/// (i.e. the current selection). Otherwise use the selection
	/// color attributes of this filter.
	/// </summary>
	public virtual void UseCurrentAnnotationColorOn()
	{
		vtkApplyColors_UseCurrentAnnotationColorOn_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_UsePointLookupTableOff_63(HandleRef pThis);

	/// <summary>
	/// If on, uses the point lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual void UsePointLookupTableOff()
	{
		vtkApplyColors_UsePointLookupTableOff_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyColors_UsePointLookupTableOn_64(HandleRef pThis);

	/// <summary>
	/// If on, uses the point lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual void UsePointLookupTableOn()
	{
		vtkApplyColors_UsePointLookupTableOn_64(GetCppThis());
	}
}
