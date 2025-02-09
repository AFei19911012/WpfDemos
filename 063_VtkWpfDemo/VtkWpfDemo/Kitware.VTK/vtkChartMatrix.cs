using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkChartMatrix
/// </summary>
/// <remarks>
///    container for a matrix of charts.
///
///
/// This class contains a matrix of charts. These charts will be of type
/// vtkChartXY by default, but this can be overridden. The class will manage
/// their layout and object lifetime.
/// </remarks>
public class vtkChartMatrix : vtkAbstractContextItem
{
	/// <summary>
	/// Override this method if you want to customize layout instead of the default.
	/// The returned rect will be in scene coordinates and suitable for a chart element
	/// or chart matrix element.
	/// </summary>
	public enum StretchType
	{
		/// <summary>enum member</summary>
		CUSTOM = 1,
		/// <summary>enum member</summary>
		SCENE = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkChartMatrix";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkChartMatrix()
	{
		MRClassNameKey = "class vtkChartMatrix";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartMatrix"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkChartMatrix(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a new object.
	/// </summary>
	public new static vtkChartMatrix New()
	{
		vtkChartMatrix result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a new object.
	/// </summary>
	public vtkChartMatrix()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkChartMatrix_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkChartMatrix_Allocate_01(HandleRef pThis);

	/// <summary>
	/// Allocate the charts, this will cause any null chart to be allocated.
	/// </summary>
	public virtual void Allocate()
	{
		vtkChartMatrix_Allocate_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_ClearSpecificResizes_02(HandleRef pThis);

	/// <summary>
	/// Set a specific resize that will move the bottom left point of a chart.
	/// </summary>
	public virtual void ClearSpecificResizes()
	{
		vtkChartMatrix_ClearSpecificResizes_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_ComputeCurrentElementSceneRect_03(HandleRef pThis, HandleRef index, HandleRef offset, HandleRef increment, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Override this method if you want to customize layout instead of the default.
	/// The returned rect will be in scene coordinates and suitable for a chart element
	/// or chart matrix element.
	/// </summary>
	public virtual vtkRectf ComputeCurrentElementSceneRect(vtkVector2i index, vtkVector2f offset, vtkVector2f increment)
	{
		vtkRectf result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_ComputeCurrentElementSceneRect_03(GetCppThis(), index?.GetCppThis() ?? default(HandleRef), offset?.GetCppThis() ?? default(HandleRef), increment?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_GetBorders_04(HandleRef pThis, IntPtr borders);

	/// <summary>
	/// Set/get the borders of the chart matrix (space in pixels around each chart).
	/// </summary>
	public virtual void GetBorders(IntPtr borders)
	{
		vtkChartMatrix_GetBorders_04(GetCppThis(), borders);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_GetChart_05(HandleRef pThis, HandleRef position, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the specified chart element, if the element does not exist nullptr will be
	/// returned. If the chart element has not yet been allocated it will be at
	/// this point.
	/// </summary>
	public virtual vtkChart GetChart(vtkVector2i position)
	{
		vtkChart vtkChart2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_GetChart_05(GetCppThis(), position?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChart2 = (vtkChart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChart2.Register(null);
			}
		}
		return vtkChart2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_GetChartIndex_06(HandleRef pThis, HandleRef position, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the position of an element in the matrix at the specified location.
	/// The position should be specified in scene coordinates.
	/// </summary>
	public virtual vtkVector2i GetChartIndex(vtkVector2f position)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_GetChartIndex_06(GetCppThis(), position?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_GetChartMatrix_07(HandleRef pThis, HandleRef position, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the specified chart matrix element. if the element does not exist, nullptr
	/// will be returned. If the element has not yet been allocated it will be at this
	/// point
	/// </summary>
	public virtual vtkChartMatrix GetChartMatrix(vtkVector2i position)
	{
		vtkChartMatrix vtkChartMatrix2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_GetChartMatrix_07(GetCppThis(), position?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChartMatrix2 = (vtkChartMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChartMatrix2.Register(null);
			}
		}
		return vtkChartMatrix2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_GetChartSpan_08(HandleRef pThis, HandleRef position, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the span of the specified element.
	/// </summary>
	public virtual vtkVector2i GetChartSpan(vtkVector2i position)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_GetChartSpan_08(GetCppThis(), position?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern StretchType vtkChartMatrix_GetFillStrategy_09(HandleRef pThis);

	/// <summary>
	/// This specifies whether the chart matrix will fill the entire scene
	/// or instead draw itself in a user provided rectangular subset of the scene.
	/// </summary>
	public StretchType GetFillStrategy()
	{
		return vtkChartMatrix_GetFillStrategy_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkChartMatrix_GetFlatIndex_10(HandleRef pThis, HandleRef index);

	/// <summary>
	/// Get internal 1-D index corresponding to the 2-D element index.
	/// </summary>
	public virtual ulong GetFlatIndex(vtkVector2i index)
	{
		return vtkChartMatrix_GetFlatIndex_10(GetCppThis(), index?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_GetGutter_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the gutter that should be left between the charts in the matrix.
	/// </summary>
	public virtual vtkVector2f GetGutter()
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_GetGutter_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkChartMatrix_GetNumberOfCharts_12(HandleRef pThis);

	/// <summary>
	/// Total number of charts within this chart matrix.
	/// </summary>
	public virtual ulong GetNumberOfCharts()
	{
		return vtkChartMatrix_GetNumberOfCharts_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartMatrix_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkChartMatrix_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartMatrix_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkChartMatrix_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_GetRect_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the rectangular region that this chart matrix will occupy.
	/// Must also set FillStrategy to StretchType::CUSTOM
	/// </summary>
	public virtual vtkRecti GetRect()
	{
		vtkRecti result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_GetRect_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRecti)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_GetSize_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the width and height of the chart matrix.
	/// </summary>
	public virtual vtkVector2i GetSize()
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_GetSize_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_GoToNextElement_17(HandleRef pThis, HandleRef index, HandleRef offset);

	/// <summary>
	/// These methods offer an API to iterate over the layout and obtain
	/// the offset of each child element (chart or chart matrix) within the scene,
	/// the index and the increment b/w each element.
	/// </summary>
	public virtual void GoToNextElement(vtkVector2i index, vtkVector2f offset)
	{
		vtkChartMatrix_GoToNextElement_17(GetCppThis(), index?.GetCppThis() ?? default(HandleRef), offset?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_InitLayoutTraversal_18(HandleRef pThis, HandleRef index, HandleRef offset, HandleRef increment);

	/// <summary>
	/// These methods offer an API to iterate over the layout and obtain
	/// the offset of each child element (chart or chart matrix) within the scene,
	/// the index and the increment b/w each element.
	/// </summary>
	public virtual void InitLayoutTraversal(vtkVector2i index, vtkVector2f offset, vtkVector2f increment)
	{
		vtkChartMatrix_InitLayoutTraversal_18(GetCppThis(), index?.GetCppThis() ?? default(HandleRef), offset?.GetCppThis() ?? default(HandleRef), increment?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartMatrix_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkChartMatrix_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartMatrix_IsDoneWithTraversal_20(HandleRef pThis);

	/// <summary>
	/// These methods offer an API to iterate over the layout and obtain
	/// the offset of each child element (chart or chart matrix) within the scene,
	/// the index and the increment b/w each element.
	/// </summary>
	public virtual bool IsDoneWithTraversal()
	{
		return (vtkChartMatrix_IsDoneWithTraversal_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartMatrix_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkChartMatrix_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_LabelOuter_22(HandleRef pThis, HandleRef leftBottomIdx, HandleRef rightTopIdx);

	/// <summary>
	/// Link all charts in the rectangle from leftBottom to rightTop.
	/// Label only the outer most y-axis and x-axis.
	/// This removes of gutter space between the linked charts.
	/// </summary>
	public virtual void LabelOuter(vtkVector2i leftBottomIdx, vtkVector2i rightTopIdx)
	{
		vtkChartMatrix_LabelOuter_22(GetCppThis(), leftBottomIdx?.GetCppThis() ?? default(HandleRef), rightTopIdx?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_Link_23(HandleRef pThis, HandleRef index1, HandleRef index2, int axis);

	/// <summary>
	/// The chart at index2 will be setup to mimic
	/// axis range of chart at index1 for specified axis.
	/// Note: index is a two dimensional chart index. See vtkChartMatrix::GetChartIndex()
	///       flatIndex is a one dimensional chart index. See vtkChartMatrix::GetFlatIndex()
	/// </summary>
	public virtual void Link(vtkVector2i index1, vtkVector2i index2, int axis)
	{
		vtkChartMatrix_Link_23(GetCppThis(), index1?.GetCppThis() ?? default(HandleRef), index2?.GetCppThis() ?? default(HandleRef), axis);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_Link_24(HandleRef pThis, ref ulong flatIndex1, ref ulong flatIndex2, int axis);

	/// <summary>
	/// The chart at index2 will be setup to mimic
	/// axis range of chart at index1 for specified axis.
	/// Note: index is a two dimensional chart index. See vtkChartMatrix::GetChartIndex()
	///       flatIndex is a one dimensional chart index. See vtkChartMatrix::GetFlatIndex()
	/// </summary>
	public virtual void Link(ref ulong flatIndex1, ref ulong flatIndex2, int axis)
	{
		vtkChartMatrix_Link_24(GetCppThis(), ref flatIndex1, ref flatIndex2, axis);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_LinkAll_25(HandleRef pThis, HandleRef index, int axis);

	/// <summary>
	/// Link a chart to all other charts in this chart matrix for specified axis
	/// </summary>
	public virtual void LinkAll(vtkVector2i index, int axis)
	{
		vtkChartMatrix_LinkAll_25(GetCppThis(), index?.GetCppThis() ?? default(HandleRef), axis);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_LinkAll_26(HandleRef pThis, ref ulong flatIndex, int axis);

	/// <summary>
	/// Link a chart to all other charts in this chart matrix for specified axis
	/// </summary>
	public virtual void LinkAll(ref ulong flatIndex, int axis)
	{
		vtkChartMatrix_LinkAll_26(GetCppThis(), ref flatIndex, axis);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkChartMatrix NewInstance()
	{
		vtkChartMatrix result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartMatrix_Paint_29(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the chart matrix.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkChartMatrix_Paint_29(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_ResetLinkedLayout_30(HandleRef pThis);

	/// <summary>
	/// Unlink every chart from all other charts for a specified axis.
	/// This effectively removes any linkage in the chart matrix.
	/// If vtkChartMatrix::LabelOuter() was used, call ResetLinkedLayout,
	/// sot that the gutters that were removed will
	/// be put back in place.
	/// </summary>
	public virtual void ResetLinkedLayout()
	{
		vtkChartMatrix_ResetLinkedLayout_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_ResetLinks_31(HandleRef pThis, int axis);

	/// <summary>
	/// Unlink every chart from all other charts for a specified axis.
	/// This effectively removes any linkage in the chart matrix.
	/// If vtkChartMatrix::LabelOuter() was used, call ResetLinkedLayout,
	/// sot that the gutters that were removed will
	/// be put back in place.
	/// </summary>
	public virtual void ResetLinks(int axis)
	{
		vtkChartMatrix_ResetLinks_31(GetCppThis(), axis);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartMatrix_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChartMatrix SafeDownCast(vtkObjectBase o)
	{
		vtkChartMatrix vtkChartMatrix2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartMatrix_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChartMatrix2 = (vtkChartMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChartMatrix2.Register(null);
			}
		}
		return vtkChartMatrix2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetBorderBottom_33(HandleRef pThis, int value);

	/// <summary>
	/// Set/get the borders of the chart matrix (space in pixels around each chart).
	/// </summary>
	public void SetBorderBottom(int value)
	{
		vtkChartMatrix_SetBorderBottom_33(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetBorderLeft_34(HandleRef pThis, int value);

	/// <summary>
	/// Set/get the borders of the chart matrix (space in pixels around each chart).
	/// </summary>
	public void SetBorderLeft(int value)
	{
		vtkChartMatrix_SetBorderLeft_34(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetBorderRight_35(HandleRef pThis, int value);

	/// <summary>
	/// Set/get the borders of the chart matrix (space in pixels around each chart).
	/// </summary>
	public void SetBorderRight(int value)
	{
		vtkChartMatrix_SetBorderRight_35(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetBorderTop_36(HandleRef pThis, int value);

	/// <summary>
	/// Set/get the borders of the chart matrix (space in pixels around each chart).
	/// </summary>
	public void SetBorderTop(int value)
	{
		vtkChartMatrix_SetBorderTop_36(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetBorders_37(HandleRef pThis, int left, int bottom, int right, int top);

	/// <summary>
	/// Set/get the borders of the chart matrix (space in pixels around each chart).
	/// </summary>
	public virtual void SetBorders(int left, int bottom, int right, int top)
	{
		vtkChartMatrix_SetBorders_37(GetCppThis(), left, bottom, right, top);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartMatrix_SetChart_38(HandleRef pThis, HandleRef position, HandleRef chart);

	/// <summary>
	/// Set the chart element, note that the chart matrix must be large enough to
	/// accommodate the element being set. Note that this class will take ownership
	/// of the chart object.
	/// \return false if the element cannot be set.
	/// </summary>
	public virtual bool SetChart(vtkVector2i position, vtkChart chart)
	{
		return (vtkChartMatrix_SetChart_38(GetCppThis(), position?.GetCppThis() ?? default(HandleRef), chart?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartMatrix_SetChartMatrix_39(HandleRef pThis, HandleRef position, HandleRef chartMatrix);

	/// <summary>
	/// Set the element at position to a chart matrix,
	/// note that the chart matrix must be large enough to
	/// accommodate the element being set. Note that this class will take ownership
	/// of the chart matrix object.
	/// \return false if the element cannot be set.
	/// </summary>
	public virtual bool SetChartMatrix(vtkVector2i position, vtkChartMatrix chartMatrix)
	{
		return (vtkChartMatrix_SetChartMatrix_39(GetCppThis(), position?.GetCppThis() ?? default(HandleRef), chartMatrix?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartMatrix_SetChartSpan_40(HandleRef pThis, HandleRef position, HandleRef span);

	/// <summary>
	/// Set the span of an element in the matrix. This defaults to 1x1, and cannot
	/// exceed the remaining space in x or y.
	/// \return false If the span is not possible.
	/// </summary>
	public virtual bool SetChartSpan(vtkVector2i position, vtkVector2i span)
	{
		return (vtkChartMatrix_SetChartSpan_40(GetCppThis(), position?.GetCppThis() ?? default(HandleRef), span?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetFillStrategy_41(HandleRef pThis, StretchType _arg);

	/// <summary>
	/// This specifies whether the chart matrix will fill the entire scene
	/// or instead draw itself in a user provided rectangular subset of the scene.
	/// </summary>
	public virtual void SetFillStrategy(StretchType _arg)
	{
		vtkChartMatrix_SetFillStrategy_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetGutter_42(HandleRef pThis, HandleRef gutter);

	/// <summary>
	/// Set the gutter that should be left between the charts in the matrix.
	/// </summary>
	public virtual void SetGutter(vtkVector2f gutter)
	{
		vtkChartMatrix_SetGutter_42(GetCppThis(), gutter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetGutterX_43(HandleRef pThis, float value);

	/// <summary>
	/// Set the gutter that should be left between the charts in the matrix.
	/// </summary>
	public void SetGutterX(float value)
	{
		vtkChartMatrix_SetGutterX_43(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetGutterY_44(HandleRef pThis, float value);

	/// <summary>
	/// Set the gutter that should be left between the charts in the matrix.
	/// </summary>
	public void SetGutterY(float value)
	{
		vtkChartMatrix_SetGutterY_44(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetPadding_45(HandleRef pThis, ref float padding);

	/// <summary>
	/// Set the gutter that should be left between the charts in the matrix.
	/// </summary>
	public virtual void SetPadding(ref float padding)
	{
		vtkChartMatrix_SetPadding_45(GetCppThis(), ref padding);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetRect_46(HandleRef pThis, HandleRef rect);

	/// <summary>
	/// Set the rectangular region that this chart matrix will occupy.
	/// Must also set FillStrategy to StretchType::CUSTOM
	/// </summary>
	public virtual void SetRect(vtkRecti rect)
	{
		vtkChartMatrix_SetRect_46(GetCppThis(), rect?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetSize_47(HandleRef pThis, HandleRef size);

	/// <summary>
	/// Set the width and height of the chart matrix. This will cause an immediate
	/// resize of the chart matrix, the default size is 0x0 (no charts). No chart
	/// objects are created until Allocate is called.
	/// </summary>
	public virtual void SetSize(vtkVector2i size)
	{
		vtkChartMatrix_SetSize_47(GetCppThis(), size?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_SetSpecificResize_48(HandleRef pThis, HandleRef index, HandleRef resize);

	/// <summary>
	/// Set a specific resize that will move the bottom left point of a chart.
	/// </summary>
	public virtual void SetSpecificResize(vtkVector2i index, vtkVector2f resize)
	{
		vtkChartMatrix_SetSpecificResize_48(GetCppThis(), index?.GetCppThis() ?? default(HandleRef), resize?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_Unlink_49(HandleRef pThis, HandleRef index1, HandleRef index2, int axis);

	/// <summary>
	/// Unlink the two charts for specified axis i.e,
	/// Chart at index2 will no longer mimic the axis range of chart at index1
	/// </summary>
	public virtual void Unlink(vtkVector2i index1, vtkVector2i index2, int axis)
	{
		vtkChartMatrix_Unlink_49(GetCppThis(), index1?.GetCppThis() ?? default(HandleRef), index2?.GetCppThis() ?? default(HandleRef), axis);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_Unlink_50(HandleRef pThis, ref ulong flatIndex1, ref ulong flatIndex2, int axis);

	/// <summary>
	/// Unlink the two charts for specified axis i.e,
	/// Chart at index2 will no longer mimic the axis range of chart at index1
	/// </summary>
	public virtual void Unlink(ref ulong flatIndex1, ref ulong flatIndex2, int axis)
	{
		vtkChartMatrix_Unlink_50(GetCppThis(), ref flatIndex1, ref flatIndex2, axis);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_UnlinkAll_51(HandleRef pThis, HandleRef index, int axis);

	/// <summary>
	/// Unlink all charts from given chart for a specified axis.
	/// </summary>
	public virtual void UnlinkAll(vtkVector2i index, int axis)
	{
		vtkChartMatrix_UnlinkAll_51(GetCppThis(), index?.GetCppThis() ?? default(HandleRef), axis);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_UnlinkAll_52(HandleRef pThis, ref ulong flatIndex, int axis);

	/// <summary>
	/// Unlink all charts from given chart for a specified axis.
	/// </summary>
	public virtual void UnlinkAll(ref ulong flatIndex, int axis)
	{
		vtkChartMatrix_UnlinkAll_52(GetCppThis(), ref flatIndex, axis);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartMatrix_Update_53(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// </summary>
	public override void Update()
	{
		vtkChartMatrix_Update_53(GetCppThis());
	}
}
