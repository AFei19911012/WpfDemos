using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParallelCoordinatesView
/// </summary>
/// <remarks>
///    view to be used with vtkParallelCoordinatesRepresentation
///
///
///
/// This class manages interaction with the vtkParallelCoordinatesRepresentation.  There are
/// two inspection modes: axis manipulation and line selection.  In axis manipulation mode,
/// PC axes can be dragged and reordered with the LMB, axis ranges can be increased/decreased
/// by dragging up/down with the LMB, and RMB controls zoom and pan.
///
/// In line selection mode, there are three subclasses of selections: lasso, angle, and
/// function selection.  Lasso selection lets the user brush a line and select all PC lines
/// that pass nearby.  Angle selection lets the user draw a representative line between axes
/// and select all lines that have similar orientation.  Function selection lets the user
/// draw two representative lines between a pair of axes and select all lines that match
/// the linear interpolation of those lines.
///
/// There are several self-explanatory operators for combining selections: ADD, SUBTRACT
/// REPLACE, and INTERSECT.
/// </remarks>
public class vtkParallelCoordinatesView : vtkRenderView
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum VTK_BRUSH_ANGLE_WrapperEnum
	{
		/// <summary>enum member</summary>
		VTK_BRUSH_ANGLE = 1,
		/// <summary>enum member</summary>
		VTK_BRUSH_AXISTHRESHOLD = 3,
		/// <summary>enum member</summary>
		VTK_BRUSH_FUNCTION = 2,
		/// <summary>enum member</summary>
		VTK_BRUSH_LASSO = 0,
		/// <summary>enum member</summary>
		VTK_BRUSH_MODECOUNT = 4
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum VTK_BRUSHOPERATOR_ADD_WrapperEnum
	{
		/// <summary>enum member</summary>
		VTK_BRUSHOPERATOR_ADD = 0,
		/// <summary>enum member</summary>
		VTK_BRUSHOPERATOR_INTERSECT = 2,
		/// <summary>enum member</summary>
		VTK_BRUSHOPERATOR_MODECOUNT = 4,
		/// <summary>enum member</summary>
		VTK_BRUSHOPERATOR_REPLACE = 3,
		/// <summary>enum member</summary>
		VTK_BRUSHOPERATOR_SUBTRACT = 1
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum VTK_INSPECT_MANIPULATE_AXES_WrapperEnum
	{
		/// <summary>enum member</summary>
		VTK_INSPECT_MANIPULATE_AXES = 0,
		/// <summary>enum member</summary>
		VTK_INSPECT_MODECOUNT = 2,
		/// <summary>enum member</summary>
		VTK_INSPECT_SELECT_DATA = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesView";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParallelCoordinatesView()
	{
		MRClassNameKey = "class vtkParallelCoordinatesView";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesView"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParallelCoordinatesView(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelCoordinatesView New()
	{
		vtkParallelCoordinatesView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkParallelCoordinatesView()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParallelCoordinatesView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParallelCoordinatesView_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void ApplyViewTheme(vtkViewTheme theme)
	{
		vtkParallelCoordinatesView_ApplyViewTheme_01(GetCppThis(), theme?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesView_GetBrushMode_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetBrushMode()
	{
		return vtkParallelCoordinatesView_GetBrushMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesView_GetBrushOperator_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetBrushOperator()
	{
		return vtkParallelCoordinatesView_GetBrushOperator_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesView_GetCurrentBrushClass_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetCurrentBrushClass()
	{
		return vtkParallelCoordinatesView_GetCurrentBrushClass_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesView_GetInspectMode_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetInspectMode()
	{
		return vtkParallelCoordinatesView_GetInspectMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesView_GetMaximumNumberOfBrushPoints_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetMaximumNumberOfBrushPoints()
	{
		return vtkParallelCoordinatesView_GetMaximumNumberOfBrushPoints_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelCoordinatesView_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParallelCoordinatesView_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelCoordinatesView_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParallelCoordinatesView_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesView_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParallelCoordinatesView_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesView_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParallelCoordinatesView_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesView_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParallelCoordinatesView NewInstance()
	{
		vtkParallelCoordinatesView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesView_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesView_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelCoordinatesView SafeDownCast(vtkObjectBase o)
	{
		vtkParallelCoordinatesView vtkParallelCoordinatesView2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesView_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelCoordinatesView2 = (vtkParallelCoordinatesView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelCoordinatesView2.Register(null);
			}
		}
		return vtkParallelCoordinatesView2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushMode_14(HandleRef pThis, int arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushMode(int arg0)
	{
		vtkParallelCoordinatesView_SetBrushMode_14(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushModeToAngle_15(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushModeToAngle()
	{
		vtkParallelCoordinatesView_SetBrushModeToAngle_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushModeToAxisThreshold_16(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushModeToAxisThreshold()
	{
		vtkParallelCoordinatesView_SetBrushModeToAxisThreshold_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushModeToFunction_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushModeToFunction()
	{
		vtkParallelCoordinatesView_SetBrushModeToFunction_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushModeToLasso_18(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushModeToLasso()
	{
		vtkParallelCoordinatesView_SetBrushModeToLasso_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushOperator_19(HandleRef pThis, int arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushOperator(int arg0)
	{
		vtkParallelCoordinatesView_SetBrushOperator_19(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToAdd_20(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushOperatorToAdd()
	{
		vtkParallelCoordinatesView_SetBrushOperatorToAdd_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToIntersect_21(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushOperatorToIntersect()
	{
		vtkParallelCoordinatesView_SetBrushOperatorToIntersect_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToReplace_22(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushOperatorToReplace()
	{
		vtkParallelCoordinatesView_SetBrushOperatorToReplace_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToSubtract_23(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBrushOperatorToSubtract()
	{
		vtkParallelCoordinatesView_SetBrushOperatorToSubtract_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetCurrentBrushClass_24(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetCurrentBrushClass(int _arg)
	{
		vtkParallelCoordinatesView_SetCurrentBrushClass_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetInpsectModeToSelectData_25(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInpsectModeToSelectData()
	{
		vtkParallelCoordinatesView_SetInpsectModeToSelectData_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetInspectMode_26(HandleRef pThis, int arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInspectMode(int arg0)
	{
		vtkParallelCoordinatesView_SetInspectMode_26(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetInspectModeToManipulateAxes_27(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInspectModeToManipulateAxes()
	{
		vtkParallelCoordinatesView_SetInspectModeToManipulateAxes_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesView_SetMaximumNumberOfBrushPoints_28(HandleRef pThis, int arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMaximumNumberOfBrushPoints(int arg0)
	{
		vtkParallelCoordinatesView_SetMaximumNumberOfBrushPoints_28(GetCppThis(), arg0);
	}
}
