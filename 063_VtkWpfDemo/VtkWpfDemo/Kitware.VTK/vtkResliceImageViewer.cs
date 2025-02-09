using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResliceImageViewer
/// </summary>
/// <remarks>
///    Display an image along with a reslice cursor
///
/// This class is similar to vtkImageViewer2. It displays the image along with
/// a two cross hairs for reslicing. The cross hairs may be interactively
/// manipulated and are typically used to reslice two other views of
/// vtkResliceImageViewer. See QtVTKRenderWindows for an example. The reslice
/// cursor is used to perform thin or thick MPR through data. The class can
/// also default to the behaviour of vtkImageViewer2 if the Reslice mode is
/// set to RESLICE_AXIS_ALIGNED.
/// </remarks>
/// <seealso>
///
/// vtkResliceCursor vtkResliceCursorWidget vtkResliceCursorRepresentation
/// </seealso>
public class vtkResliceImageViewer : vtkImageViewer2
{
	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public enum RESLICE_AXIS_ALIGNED_WrapperEnum
	{
		/// <summary>enum member</summary>
		RESLICE_AXIS_ALIGNED,
		/// <summary>enum member</summary>
		RESLICE_OBLIQUE
	}

	/// <summary>
	/// Increment/Decrement slice by 'inc' slices
	/// </summary>
	public enum SliceChangedEvent_WrapperEnum
	{
		/// <summary>enum member</summary>
		SliceChangedEvent = 1001
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResliceImageViewer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResliceImageViewer()
	{
		MRClassNameKey = "class vtkResliceImageViewer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceImageViewer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResliceImageViewer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkResliceImageViewer New()
	{
		vtkResliceImageViewer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public vtkResliceImageViewer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResliceImageViewer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewer_GetInteractor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the render window interactor
	/// </summary>
	public virtual vtkRenderWindowInteractor GetInteractor()
	{
		vtkRenderWindowInteractor vtkRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewer_GetInteractor_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindowInteractor2 = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindowInteractor2.Register(null);
			}
		}
		return vtkRenderWindowInteractor2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewer_GetLookupTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the lookup table
	/// </summary>
	public vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewer_GetLookupTable_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewer_GetMeasurements_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the measurements manager
	/// </summary>
	public virtual vtkResliceImageViewerMeasurements GetMeasurements()
	{
		vtkResliceImageViewerMeasurements vtkResliceImageViewerMeasurements2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewer_GetMeasurements_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceImageViewerMeasurements2 = (vtkResliceImageViewerMeasurements)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceImageViewerMeasurements2.Register(null);
			}
		}
		return vtkResliceImageViewerMeasurements2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceImageViewer_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResliceImageViewer_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceImageViewer_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResliceImageViewer_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewer_GetPointPlacer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the point placer.
	/// </summary>
	public virtual vtkBoundedPlanePointPlacer GetPointPlacer()
	{
		vtkBoundedPlanePointPlacer vtkBoundedPlanePointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewer_GetPointPlacer_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBoundedPlanePointPlacer2 = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBoundedPlanePointPlacer2.Register(null);
			}
		}
		return vtkBoundedPlanePointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewer_GetResliceCursor_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the reslice cursor.
	/// </summary>
	public vtkResliceCursor GetResliceCursor()
	{
		vtkResliceCursor vtkResliceCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewer_GetResliceCursor_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursor2 = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursor2.Register(null);
			}
		}
		return vtkResliceCursor2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewer_GetResliceCursorWidget_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal render window, renderer, image actor, and
	/// image map instances.
	/// </summary>
	public virtual vtkResliceCursorWidget GetResliceCursorWidget()
	{
		vtkResliceCursorWidget vtkResliceCursorWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewer_GetResliceCursorWidget_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorWidget2 = (vtkResliceCursorWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorWidget2.Register(null);
			}
		}
		return vtkResliceCursorWidget2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewer_GetResliceMode_09(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual int GetResliceMode()
	{
		return vtkResliceImageViewer_GetResliceMode_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkResliceImageViewer_GetSliceScrollFactor_10(HandleRef pThis);

	/// <summary>
	/// Define a factor that will be applied in addition to the inter slice spacing when scrolling
	/// image. When the view is in axis aligned ResliceMode, and the factor is not an integer,
	/// then the new value of the slice will be rounded. Otherwise, the factor is applied
	/// normally. Default value is 1.0.
	/// Note that in axis aligned ResliceMode, the factor is applied in local coordinate (i, j, k),
	/// whereas in oblique ResliceMode, the factor is applied in world coordinate (x, y, z)
	/// </summary>
	public virtual double GetSliceScrollFactor()
	{
		return vtkResliceImageViewer_GetSliceScrollFactor_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewer_GetSliceScrollOnMouseWheel_11(HandleRef pThis);

	/// <summary>
	/// Scroll slices on the mouse wheel ? In the case of MPR
	/// view, it moves one "normalized spacing" in the direction of the normal to
	/// the resliced plane, provided the new center will continue to lie within
	/// the volume.
	/// </summary>
	public virtual int GetSliceScrollOnMouseWheel()
	{
		return vtkResliceImageViewer_GetSliceScrollOnMouseWheel_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewer_GetThickMode_12(HandleRef pThis);

	/// <summary>
	/// Switch to / from thick mode
	/// </summary>
	public virtual int GetThickMode()
	{
		return vtkResliceImageViewer_GetThickMode_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_IncrementSlice_13(HandleRef pThis, int inc);

	/// <summary>
	/// Increment/Decrement slice by 'inc' slices
	/// </summary>
	public virtual void IncrementSlice(int inc)
	{
		vtkResliceImageViewer_IncrementSlice_13(GetCppThis(), inc);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewer_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResliceImageViewer_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewer_IsTypeOf_15(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResliceImageViewer_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewer_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkResliceImageViewer NewInstance()
	{
		vtkResliceImageViewer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewer_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_Render_18(HandleRef pThis);

	/// <summary>
	/// Render the resulting image.
	/// </summary>
	public override void Render()
	{
		vtkResliceImageViewer_Render_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_Reset_19(HandleRef pThis);

	/// <summary>
	/// Reset all views back to initial state
	/// </summary>
	public virtual void Reset()
	{
		vtkResliceImageViewer_Reset_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewer_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkResliceImageViewer SafeDownCast(vtkObjectBase o)
	{
		vtkResliceImageViewer vtkResliceImageViewer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewer_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceImageViewer2 = (vtkResliceImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceImageViewer2.Register(null);
			}
		}
		return vtkResliceImageViewer2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetColorLevel_21(HandleRef pThis, double s);

	/// <summary>
	/// Set window and level for mapping pixels to colors.
	/// </summary>
	public override void SetColorLevel(double s)
	{
		vtkResliceImageViewer_SetColorLevel_21(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetColorWindow_22(HandleRef pThis, double s);

	/// <summary>
	/// Set window and level for mapping pixels to colors.
	/// </summary>
	public override void SetColorWindow(double s)
	{
		vtkResliceImageViewer_SetColorWindow_22(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetInputConnection_23(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set/Get the input image to the viewer.
	/// </summary>
	public override void SetInputConnection(vtkAlgorithmOutput input)
	{
		vtkResliceImageViewer_SetInputConnection_23(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetInputData_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the input image to the viewer.
	/// </summary>
	public override void SetInputData(vtkImageData arg0)
	{
		vtkResliceImageViewer_SetInputData_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetLookupTable_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the lookup table
	/// </summary>
	public virtual void SetLookupTable(vtkScalarsToColors arg0)
	{
		vtkResliceImageViewer_SetLookupTable_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetResliceCursor_26(HandleRef pThis, HandleRef rc);

	/// <summary>
	/// Set/Get the reslice cursor.
	/// </summary>
	public void SetResliceCursor(vtkResliceCursor rc)
	{
		vtkResliceImageViewer_SetResliceCursor_26(GetCppThis(), rc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetResliceMode_27(HandleRef pThis, int resliceMode);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetResliceMode(int resliceMode)
	{
		vtkResliceImageViewer_SetResliceMode_27(GetCppThis(), resliceMode);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetResliceModeToAxisAligned_28(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetResliceModeToAxisAligned()
	{
		vtkResliceImageViewer_SetResliceModeToAxisAligned_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetResliceModeToOblique_29(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetResliceModeToOblique()
	{
		vtkResliceImageViewer_SetResliceModeToOblique_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetSliceScrollFactor_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Define a factor that will be applied in addition to the inter slice spacing when scrolling
	/// image. When the view is in axis aligned ResliceMode, and the factor is not an integer,
	/// then the new value of the slice will be rounded. Otherwise, the factor is applied
	/// normally. Default value is 1.0.
	/// Note that in axis aligned ResliceMode, the factor is applied in local coordinate (i, j, k),
	/// whereas in oblique ResliceMode, the factor is applied in world coordinate (x, y, z)
	/// </summary>
	public virtual void SetSliceScrollFactor(double _arg)
	{
		vtkResliceImageViewer_SetSliceScrollFactor_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetSliceScrollOnMouseWheel_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Scroll slices on the mouse wheel ? In the case of MPR
	/// view, it moves one "normalized spacing" in the direction of the normal to
	/// the resliced plane, provided the new center will continue to lie within
	/// the volume.
	/// </summary>
	public virtual void SetSliceScrollOnMouseWheel(int _arg)
	{
		vtkResliceImageViewer_SetSliceScrollOnMouseWheel_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SetThickMode_32(HandleRef pThis, int arg0);

	/// <summary>
	/// Switch to / from thick mode
	/// </summary>
	public virtual void SetThickMode(int arg0)
	{
		vtkResliceImageViewer_SetThickMode_32(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SliceScrollOnMouseWheelOff_33(HandleRef pThis);

	/// <summary>
	/// Scroll slices on the mouse wheel ? In the case of MPR
	/// view, it moves one "normalized spacing" in the direction of the normal to
	/// the resliced plane, provided the new center will continue to lie within
	/// the volume.
	/// </summary>
	public virtual void SliceScrollOnMouseWheelOff()
	{
		vtkResliceImageViewer_SliceScrollOnMouseWheelOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewer_SliceScrollOnMouseWheelOn_34(HandleRef pThis);

	/// <summary>
	/// Scroll slices on the mouse wheel ? In the case of MPR
	/// view, it moves one "normalized spacing" in the direction of the normal to
	/// the resliced plane, provided the new center will continue to lie within
	/// the volume.
	/// </summary>
	public virtual void SliceScrollOnMouseWheelOn()
	{
		vtkResliceImageViewer_SliceScrollOnMouseWheelOn_34(GetCppThis());
	}
}
