using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCheckerboardRepresentation
/// </summary>
/// <remarks>
///    represent the vtkCheckerboardWidget
///
/// The vtkCheckerboardRepresentation is used to implement the representation of
/// the vtkCheckerboardWidget. The user can adjust the number of divisions in
/// each of the i-j directions in a 2D image. A frame appears around the
/// vtkImageActor with sliders along each side of the frame. The user can
/// interactively adjust the sliders to the desired number of checkerboard
/// subdivisions. The representation uses four instances of
/// vtkSliderRepresentation3D to implement itself.
///
/// </remarks>
/// <seealso>
///
/// vtkCheckerboardWidget vtkImageCheckerboard vtkImageActor vtkSliderWidget
/// vtkRectilinearWipeWidget
/// </seealso>
public class vtkCheckerboardRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Specify the offset of the ends of the sliders (on the boundary edges of
	/// the image) from the corner of the image. The offset is expressed as a
	/// normalized fraction of the border edges.
	/// </summary>
	public enum BottomSlider_WrapperEnum
	{
		/// <summary>enum member</summary>
		BottomSlider = 2,
		/// <summary>enum member</summary>
		LeftSlider = 3,
		/// <summary>enum member</summary>
		RightSlider = 1,
		/// <summary>enum member</summary>
		TopSlider = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCheckerboardRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCheckerboardRepresentation()
	{
		MRClassNameKey = "class vtkCheckerboardRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCheckerboardRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCheckerboardRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public new static vtkCheckerboardRepresentation New()
	{
		vtkCheckerboardRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public vtkCheckerboardRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCheckerboardRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCheckerboardRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods required by superclass.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkCheckerboardRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_GetActors_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods required by superclass.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkCheckerboardRepresentation_GetActors_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardRepresentation_GetBottomRepresentation_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and get the instances of vtkSliderRepresentation used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public virtual vtkSliderRepresentation3D GetBottomRepresentation()
	{
		vtkSliderRepresentation3D vtkSliderRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardRepresentation_GetBottomRepresentation_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliderRepresentation3D2 = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliderRepresentation3D2.Register(null);
			}
		}
		return vtkSliderRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardRepresentation_GetCheckerboard_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an instance of vtkImageCheckerboard to manipulate.
	/// </summary>
	public virtual vtkImageCheckerboard GetCheckerboard()
	{
		vtkImageCheckerboard vtkImageCheckerboard2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardRepresentation_GetCheckerboard_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageCheckerboard2 = (vtkImageCheckerboard)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageCheckerboard2.Register(null);
			}
		}
		return vtkImageCheckerboard2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardRepresentation_GetCornerOffset_05(HandleRef pThis);

	/// <summary>
	/// Specify the offset of the ends of the sliders (on the boundary edges of
	/// the image) from the corner of the image. The offset is expressed as a
	/// normalized fraction of the border edges.
	/// </summary>
	public virtual double GetCornerOffset()
	{
		return vtkCheckerboardRepresentation_GetCornerOffset_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardRepresentation_GetCornerOffsetMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the offset of the ends of the sliders (on the boundary edges of
	/// the image) from the corner of the image. The offset is expressed as a
	/// normalized fraction of the border edges.
	/// </summary>
	public virtual double GetCornerOffsetMaxValue()
	{
		return vtkCheckerboardRepresentation_GetCornerOffsetMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardRepresentation_GetCornerOffsetMinValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the offset of the ends of the sliders (on the boundary edges of
	/// the image) from the corner of the image. The offset is expressed as a
	/// normalized fraction of the border edges.
	/// </summary>
	public virtual double GetCornerOffsetMinValue()
	{
		return vtkCheckerboardRepresentation_GetCornerOffsetMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardRepresentation_GetImageActor_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an instance of vtkImageActor to decorate.
	/// </summary>
	public virtual vtkImageActor GetImageActor()
	{
		vtkImageActor vtkImageActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardRepresentation_GetImageActor_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageActor2 = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageActor2.Register(null);
			}
		}
		return vtkImageActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardRepresentation_GetLeftRepresentation_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and get the instances of vtkSliderRepresentation used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public virtual vtkSliderRepresentation3D GetLeftRepresentation()
	{
		vtkSliderRepresentation3D vtkSliderRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardRepresentation_GetLeftRepresentation_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliderRepresentation3D2 = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliderRepresentation3D2.Register(null);
			}
		}
		return vtkSliderRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCheckerboardRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCheckerboardRepresentation_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCheckerboardRepresentation_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCheckerboardRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardRepresentation_GetRightRepresentation_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and get the instances of vtkSliderRepresentation used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public virtual vtkSliderRepresentation3D GetRightRepresentation()
	{
		vtkSliderRepresentation3D vtkSliderRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardRepresentation_GetRightRepresentation_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliderRepresentation3D2 = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliderRepresentation3D2.Register(null);
			}
		}
		return vtkSliderRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardRepresentation_GetTopRepresentation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and get the instances of vtkSliderRepresentation used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public virtual vtkSliderRepresentation3D GetTopRepresentation()
	{
		vtkSliderRepresentation3D vtkSliderRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardRepresentation_GetTopRepresentation_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliderRepresentation3D2 = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliderRepresentation3D2.Register(null);
			}
		}
		return vtkSliderRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardRepresentation_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

	/// <summary>
	/// Methods required by superclass.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCheckerboardRepresentation_HasTranslucentPolygonalGeometry_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardRepresentation_IsA_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCheckerboardRepresentation_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardRepresentation_IsTypeOf_16(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCheckerboardRepresentation_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardRepresentation_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkCheckerboardRepresentation NewInstance()
	{
		vtkCheckerboardRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardRepresentation_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkCheckerboardRepresentation_ReleaseGraphicsResources_19(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardRepresentation_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by superclass.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkCheckerboardRepresentation_RenderOpaqueGeometry_20(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardRepresentation_RenderOverlay_21(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by superclass.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkCheckerboardRepresentation_RenderOverlay_21(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardRepresentation_RenderTranslucentPolygonalGeometry_22(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by superclass.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkCheckerboardRepresentation_RenderTranslucentPolygonalGeometry_22(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardRepresentation_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkCheckerboardRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkCheckerboardRepresentation vtkCheckerboardRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardRepresentation_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCheckerboardRepresentation2 = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCheckerboardRepresentation2.Register(null);
			}
		}
		return vtkCheckerboardRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_SetBottomRepresentation_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set and get the instances of vtkSliderRepresentation used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public void SetBottomRepresentation(vtkSliderRepresentation3D arg0)
	{
		vtkCheckerboardRepresentation_SetBottomRepresentation_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_SetCheckerboard_25(HandleRef pThis, HandleRef chkrbrd);

	/// <summary>
	/// Specify an instance of vtkImageCheckerboard to manipulate.
	/// </summary>
	public void SetCheckerboard(vtkImageCheckerboard chkrbrd)
	{
		vtkCheckerboardRepresentation_SetCheckerboard_25(GetCppThis(), chkrbrd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_SetCornerOffset_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the offset of the ends of the sliders (on the boundary edges of
	/// the image) from the corner of the image. The offset is expressed as a
	/// normalized fraction of the border edges.
	/// </summary>
	public virtual void SetCornerOffset(double _arg)
	{
		vtkCheckerboardRepresentation_SetCornerOffset_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_SetImageActor_27(HandleRef pThis, HandleRef imageActor);

	/// <summary>
	/// Specify an instance of vtkImageActor to decorate.
	/// </summary>
	public void SetImageActor(vtkImageActor imageActor)
	{
		vtkCheckerboardRepresentation_SetImageActor_27(GetCppThis(), imageActor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_SetLeftRepresentation_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set and get the instances of vtkSliderRepresentation used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public void SetLeftRepresentation(vtkSliderRepresentation3D arg0)
	{
		vtkCheckerboardRepresentation_SetLeftRepresentation_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_SetRightRepresentation_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set and get the instances of vtkSliderRepresentation used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public void SetRightRepresentation(vtkSliderRepresentation3D arg0)
	{
		vtkCheckerboardRepresentation_SetRightRepresentation_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_SetTopRepresentation_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set and get the instances of vtkSliderRepresentation used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public void SetTopRepresentation(vtkSliderRepresentation3D arg0)
	{
		vtkCheckerboardRepresentation_SetTopRepresentation_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardRepresentation_SliderValueChanged_31(HandleRef pThis, int sliderNum);

	/// <summary>
	/// This method is invoked by the vtkCheckerboardWidget() when a value of some
	/// slider has changed.
	/// </summary>
	public void SliderValueChanged(int sliderNum)
	{
		vtkCheckerboardRepresentation_SliderValueChanged_31(GetCppThis(), sliderNum);
	}
}
