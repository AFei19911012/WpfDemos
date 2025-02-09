using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContinuousValueWidgetRepresentation
/// </summary>
/// <remarks>
///    provide the representation for a continuous value
///
/// This class is used mainly as a superclass for continuous value widgets
///
/// </remarks>
public abstract class vtkContinuousValueWidgetRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Adjusting = 2,
		/// <summary>enum member</summary>
		Inside = 1,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContinuousValueWidgetRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContinuousValueWidgetRepresentation()
	{
		MRClassNameKey = "class vtkContinuousValueWidgetRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContinuousValueWidgetRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContinuousValueWidgetRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContinuousValueWidgetRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkContinuousValueWidgetRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContinuousValueWidgetRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContinuousValueWidgetRepresentation_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContinuousValueWidgetRepresentation_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContinuousValueWidgetRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkContinuousValueWidgetRepresentation_GetValue_04(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkContinuousValueWidgetRepresentation_GetValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContinuousValueWidgetRepresentation_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContinuousValueWidgetRepresentation_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContinuousValueWidgetRepresentation_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContinuousValueWidgetRepresentation_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContinuousValueWidgetRepresentation_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkContinuousValueWidgetRepresentation NewInstance()
	{
		vtkContinuousValueWidgetRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContinuousValueWidgetRepresentation_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContinuousValueWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContinuousValueWidgetRepresentation_PlaceWidget_08(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkContinuousValueWidgetRepresentation_PlaceWidget_08(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContinuousValueWidgetRepresentation_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkContinuousValueWidgetRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkContinuousValueWidgetRepresentation vtkContinuousValueWidgetRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContinuousValueWidgetRepresentation_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContinuousValueWidgetRepresentation2 = (vtkContinuousValueWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContinuousValueWidgetRepresentation2.Register(null);
			}
		}
		return vtkContinuousValueWidgetRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContinuousValueWidgetRepresentation_SetValue_10(HandleRef pThis, double value);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public virtual void SetValue(double value)
	{
		vtkContinuousValueWidgetRepresentation_SetValue_10(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContinuousValueWidgetRepresentation_StartWidgetInteraction_11(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkContinuousValueWidgetRepresentation_StartWidgetInteraction_11(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContinuousValueWidgetRepresentation_WidgetInteraction_12(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkContinuousValueWidgetRepresentation_WidgetInteraction_12(GetCppThis(), eventPos);
	}
}
