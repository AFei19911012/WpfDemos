using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMeasurementCubeHandleRepresentation3D
/// </summary>
/// <remarks>
///    represent a unit cube for measuring/comparing to data.
///
/// </remarks>
/// <seealso>
///
/// vtkPolygonalHandleRepresentation3D vtkHandleRepresentation vtkHandleWidget
/// </seealso>
public class vtkMeasurementCubeHandleRepresentation3D : vtkHandleRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMeasurementCubeHandleRepresentation3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMeasurementCubeHandleRepresentation3D()
	{
		MRClassNameKey = "class vtkMeasurementCubeHandleRepresentation3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMeasurementCubeHandleRepresentation3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMeasurementCubeHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkMeasurementCubeHandleRepresentation3D New()
	{
		vtkMeasurementCubeHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMeasurementCubeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkMeasurementCubeHandleRepresentation3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMeasurementCubeHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_AdaptiveScalingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off adaptive scaling for the cube.
	/// </summary>
	public virtual void AdaptiveScalingOff()
	{
		vtkMeasurementCubeHandleRepresentation3D_AdaptiveScalingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_AdaptiveScalingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off adaptive scaling for the cube.
	/// </summary>
	public virtual void AdaptiveScalingOn()
	{
		vtkMeasurementCubeHandleRepresentation3D_AdaptiveScalingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_BuildRepresentation_03(HandleRef pThis);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkMeasurementCubeHandleRepresentation3D_BuildRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkMeasurementCubeHandleRepresentation3D_ComputeInteractionState_04(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_DeepCopy_05(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void DeepCopy(vtkProp prop)
	{
		vtkMeasurementCubeHandleRepresentation3D_DeepCopy_05(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_GetActors_06(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkMeasurementCubeHandleRepresentation3D_GetActors_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetAdaptiveScaling_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off adaptive scaling for the cube.
	/// </summary>
	public virtual int GetAdaptiveScaling()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetAdaptiveScaling_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetBounds_08(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D_GetBounds_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetHandle_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle polydata.
	/// </summary>
	public vtkPolyData GetHandle()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D_GetHandle_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetHandleVisibility_10(HandleRef pThis);

	/// <summary>
	/// Toggle the visibility of the handle on and off
	/// </summary>
	public virtual int GetHandleVisibility()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetHandleVisibility_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetLabelText_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the label text actor
	/// </summary>
	public virtual vtkBillboardTextActor3D GetLabelText()
	{
		vtkBillboardTextActor3D vtkBillboardTextActor3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D_GetLabelText_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBillboardTextActor3D2 = (vtkBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBillboardTextActor3D2.Register(null);
			}
		}
		return vtkBillboardTextActor3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetLabelTextInput_12(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual string GetLabelTextInput()
	{
		return Marshal.PtrToStringAnsi(vtkMeasurementCubeHandleRepresentation3D_GetLabelTextInput_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetLabelVisibility_13(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual int GetLabelVisibility()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetLabelVisibility_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetLengthUnit_14(HandleRef pThis);

	/// <summary>
	/// Set the label for the unit of length of a side of the cube.
	/// </summary>
	public virtual string GetLengthUnit()
	{
		return Marshal.PtrToStringAnsi(vtkMeasurementCubeHandleRepresentation3D_GetLengthUnit_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetMaxRelativeCubeScreenArea_15(HandleRef pThis);

	/// <summary>
	/// Set the min/max cube representational area relative to the render window
	/// area. If adaptive scaling is on and the cube's image is outside of these
	/// bounds, the cube is adaptively scaled. The max and min relative cube sizes
	/// are clamped between 1. and 1.e-6, and MaxRelativeubeSize must be more than
	/// \c RescaleFactor greater than MinRelativeCubeScreenArea.
	/// </summary>
	public virtual double GetMaxRelativeCubeScreenArea()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetMaxRelativeCubeScreenArea_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetMinRelativeCubeScreenArea_16(HandleRef pThis);

	/// <summary>
	/// Set the min/max cube representational area relative to the render window
	/// area. If adaptive scaling is on and the cube's image is outside of these
	/// bounds, the cube is adaptively scaled. The max and min relative cube sizes
	/// are clamped between 1. and 1.e-6, and MaxRelativeubeSize must be more than
	/// \c RescaleFactor greater than MinRelativeCubeScreenArea.
	/// </summary>
	public virtual double GetMinRelativeCubeScreenArea()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetMinRelativeCubeScreenArea_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMeasurementCubeHandleRepresentation3D_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMeasurementCubeHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public virtual vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D_GetProperty_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactor_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the rescaling increment for the cube. This value is applied to
	/// each dimension, so volume scaling = std::pow(RescaleFactor, 3).
	/// </summary>
	public virtual double GetRescaleFactor()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactor_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactorMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the rescaling increment for the cube. This value is applied to
	/// each dimension, so volume scaling = std::pow(RescaleFactor, 3).
	/// </summary>
	public virtual double GetRescaleFactorMaxValue()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactorMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactorMinValue_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the rescaling increment for the cube. This value is applied to
	/// each dimension, so volume scaling = std::pow(RescaleFactor, 3).
	/// </summary>
	public virtual double GetRescaleFactorMinValue()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactorMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetSelectedLabelVisibility_23(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual int GetSelectedLabelVisibility()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetSelectedLabelVisibility_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetSelectedProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public virtual vtkProperty GetSelectedProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D_GetSelectedProperty_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetSideLength_25(HandleRef pThis);

	/// <summary>
	/// Set the length of a side of the cube (default is 1).
	/// </summary>
	public virtual double GetSideLength()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetSideLength_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetSmoothMotion_26(HandleRef pThis);

	/// <summary>
	/// Turn on/off smooth motion of the handle. See the documentation of
	/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
	/// in certain applications the user may want to turn it off. For instance
	/// when using certain specific PointPlacer's with the representation such
	/// as the vtkCellCentersPointPlacer, which causes the representation to
	/// snap to the center of cells. In such cases, inherent restrictions on
	/// handle placement might conflict with a request for smooth motion of the
	/// handles.
	/// </summary>
	public virtual int GetSmoothMotion()
	{
		return vtkMeasurementCubeHandleRepresentation3D_GetSmoothMotion_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetTransform_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the transform used to transform the generic handle polydata before
	/// placing it in the render window
	/// </summary>
	public virtual vtkAbstractTransform GetTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D_GetTransform_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_HandleVisibilityOff_28(HandleRef pThis);

	/// <summary>
	/// Toggle the visibility of the handle on and off
	/// </summary>
	public virtual void HandleVisibilityOff()
	{
		vtkMeasurementCubeHandleRepresentation3D_HandleVisibilityOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_HandleVisibilityOn_29(HandleRef pThis);

	/// <summary>
	/// Toggle the visibility of the handle on and off
	/// </summary>
	public virtual void HandleVisibilityOn()
	{
		vtkMeasurementCubeHandleRepresentation3D_HandleVisibilityOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_HasTranslucentPolygonalGeometry_30(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkMeasurementCubeHandleRepresentation3D_HasTranslucentPolygonalGeometry_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_Highlight_31(HandleRef pThis, int highlight);

	/// <summary>
	/// Toggle highlighting (used when the cube is selected).
	/// </summary>
	public override void Highlight(int highlight)
	{
		vtkMeasurementCubeHandleRepresentation3D_Highlight_31(GetCppThis(), highlight);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_IsA_32(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMeasurementCubeHandleRepresentation3D_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_IsTypeOf_33(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMeasurementCubeHandleRepresentation3D_IsTypeOf_33(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_LabelVisibilityOff_34(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkMeasurementCubeHandleRepresentation3D_LabelVisibilityOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_LabelVisibilityOn_35(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkMeasurementCubeHandleRepresentation3D_LabelVisibilityOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkMeasurementCubeHandleRepresentation3D NewInstance()
	{
		vtkMeasurementCubeHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D_NewInstance_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMeasurementCubeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_RegisterPickers_38(HandleRef pThis);

	/// <summary>
	/// Set the label for the unit of length of a side of the cube.
	/// </summary>
	public override void RegisterPickers()
	{
		vtkMeasurementCubeHandleRepresentation3D_RegisterPickers_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_ReleaseGraphicsResources_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkMeasurementCubeHandleRepresentation3D_ReleaseGraphicsResources_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_RenderOpaqueGeometry_40(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkMeasurementCubeHandleRepresentation3D_RenderOpaqueGeometry_40(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeasurementCubeHandleRepresentation3D_RenderTranslucentPolygonalGeometry_41(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkMeasurementCubeHandleRepresentation3D_RenderTranslucentPolygonalGeometry_41(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkMeasurementCubeHandleRepresentation3D SafeDownCast(vtkObjectBase o)
	{
		vtkMeasurementCubeHandleRepresentation3D vtkMeasurementCubeHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMeasurementCubeHandleRepresentation3D2 = (vtkMeasurementCubeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMeasurementCubeHandleRepresentation3D2.Register(null);
			}
		}
		return vtkMeasurementCubeHandleRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SelectedLabelVisibilityOff_43(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void SelectedLabelVisibilityOff()
	{
		vtkMeasurementCubeHandleRepresentation3D_SelectedLabelVisibilityOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SelectedLabelVisibilityOn_44(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void SelectedLabelVisibilityOn()
	{
		vtkMeasurementCubeHandleRepresentation3D_SelectedLabelVisibilityOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetAdaptiveScaling_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off adaptive scaling for the cube.
	/// </summary>
	public virtual void SetAdaptiveScaling(int _arg)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetAdaptiveScaling_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetDisplayPosition_46(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set the position of the point in world and display coordinates.
	/// </summary>
	public override void SetDisplayPosition(IntPtr p)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetDisplayPosition_46(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetHandleVisibility_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Toggle the visibility of the handle on and off
	/// </summary>
	public virtual void SetHandleVisibility(int _arg)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetHandleVisibility_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetLabelTextInput_48(HandleRef pThis, string label);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void SetLabelTextInput(string label)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetLabelTextInput_48(GetCppThis(), label);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetLabelVisibility_49(HandleRef pThis, int _arg);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void SetLabelVisibility(int _arg)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetLabelVisibility_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetLengthUnit_50(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the label for the unit of length of a side of the cube.
	/// </summary>
	public virtual void SetLengthUnit(string _arg)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetLengthUnit_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetMaxRelativeCubeScreenArea_51(HandleRef pThis, double arg0);

	/// <summary>
	/// Set the min/max cube representational area relative to the render window
	/// area. If adaptive scaling is on and the cube's image is outside of these
	/// bounds, the cube is adaptively scaled. The max and min relative cube sizes
	/// are clamped between 1. and 1.e-6, and MaxRelativeubeSize must be more than
	/// \c RescaleFactor greater than MinRelativeCubeScreenArea.
	/// </summary>
	public void SetMaxRelativeCubeScreenArea(double arg0)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetMaxRelativeCubeScreenArea_51(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetMinRelativeCubeScreenArea_52(HandleRef pThis, double arg0);

	/// <summary>
	/// Set the min/max cube representational area relative to the render window
	/// area. If adaptive scaling is on and the cube's image is outside of these
	/// bounds, the cube is adaptively scaled. The max and min relative cube sizes
	/// are clamped between 1. and 1.e-6, and MaxRelativeubeSize must be more than
	/// \c RescaleFactor greater than MinRelativeCubeScreenArea.
	/// </summary>
	public void SetMinRelativeCubeScreenArea(double arg0)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetMinRelativeCubeScreenArea_52(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetProperty_53(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public void SetProperty(vtkProperty arg0)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetProperty_53(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetRescaleFactor_54(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the rescaling increment for the cube. This value is applied to
	/// each dimension, so volume scaling = std::pow(RescaleFactor, 3).
	/// </summary>
	public virtual void SetRescaleFactor(double _arg)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetRescaleFactor_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetSelectedLabelVisibility_55(HandleRef pThis, int _arg);

	/// <summary>
	/// A label may be associated with the cube. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void SetSelectedLabelVisibility(int _arg)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetSelectedLabelVisibility_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetSelectedProperty_56(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public void SetSelectedProperty(vtkProperty arg0)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetSelectedProperty_56(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetSideLength_57(HandleRef pThis, double arg0);

	/// <summary>
	/// Set the length of a side of the cube (default is 1).
	/// </summary>
	public void SetSideLength(double arg0)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetSideLength_57(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetSmoothMotion_58(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off smooth motion of the handle. See the documentation of
	/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
	/// in certain applications the user may want to turn it off. For instance
	/// when using certain specific PointPlacer's with the representation such
	/// as the vtkCellCentersPointPlacer, which causes the representation to
	/// snap to the center of cells. In such cases, inherent restrictions on
	/// handle placement might conflict with a request for smooth motion of the
	/// handles.
	/// </summary>
	public virtual void SetSmoothMotion(int _arg)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetSmoothMotion_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetWorldPosition_59(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set the position of the point in world and display coordinates.
	/// </summary>
	public override void SetWorldPosition(IntPtr p)
	{
		vtkMeasurementCubeHandleRepresentation3D_SetWorldPosition_59(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_ShallowCopy_60(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkMeasurementCubeHandleRepresentation3D_ShallowCopy_60(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SmoothMotionOff_61(HandleRef pThis);

	/// <summary>
	/// Turn on/off smooth motion of the handle. See the documentation of
	/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
	/// in certain applications the user may want to turn it off. For instance
	/// when using certain specific PointPlacer's with the representation such
	/// as the vtkCellCentersPointPlacer, which causes the representation to
	/// snap to the center of cells. In such cases, inherent restrictions on
	/// handle placement might conflict with a request for smooth motion of the
	/// handles.
	/// </summary>
	public virtual void SmoothMotionOff()
	{
		vtkMeasurementCubeHandleRepresentation3D_SmoothMotionOff_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_SmoothMotionOn_62(HandleRef pThis);

	/// <summary>
	/// Turn on/off smooth motion of the handle. See the documentation of
	/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
	/// in certain applications the user may want to turn it off. For instance
	/// when using certain specific PointPlacer's with the representation such
	/// as the vtkCellCentersPointPlacer, which causes the representation to
	/// snap to the center of cells. In such cases, inherent restrictions on
	/// handle placement might conflict with a request for smooth motion of the
	/// handles.
	/// </summary>
	public virtual void SmoothMotionOn()
	{
		vtkMeasurementCubeHandleRepresentation3D_SmoothMotionOn_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_StartWidgetInteraction_63(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkMeasurementCubeHandleRepresentation3D_StartWidgetInteraction_63(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeasurementCubeHandleRepresentation3D_WidgetInteraction_64(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkMeasurementCubeHandleRepresentation3D_WidgetInteraction_64(GetCppThis(), eventPos);
	}
}
