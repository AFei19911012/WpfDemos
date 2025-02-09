using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBalloonRepresentation
/// </summary>
/// <remarks>
///    represent the vtkBalloonWidget
///
/// The vtkBalloonRepresentation is used to represent the vtkBalloonWidget.
/// This representation is defined by two items: a text string and an image.
/// At least one of these two items must be defined, but it is allowable to
/// specify both, or just an image or just text. If both the text and image
/// are specified, then methods are available for positioning the text and
/// image with respect to each other.
///
/// The balloon representation consists of three parts: text, a rectangular
/// frame behind the text, and an image placed next to the frame and sized
/// to match the frame.
///
/// The size of the balloon is ultimately controlled by the text properties
/// (i.e., font size). This representation uses a layout policy as follows.
///
/// If there is just text and no image, then the text properties and padding
/// are used to control the size of the balloon.
///
/// If there is just an image and no text, then the ImageSize[2] member is
/// used to control the image size. (The image will fit into this rectangle,
/// but will not necessarily fill the whole rectangle, i.e., the image is not
/// stretched).
///
/// If there is text and an image, the following approach ia used. First,
/// based on the font size and other related properties (e.g., padding),
/// determine the size of the frame. Second, depending on the layout of the
/// image and text frame, control the size of the neighboring image (since the
/// frame and image share a common edge). However, if this results in an image
/// that is smaller than ImageSize[2], then the image size will be set to
/// ImageSize[2] and the frame will be adjusted accordingly. The text is
/// always placed in the center of the frame if the frame is resized.
///
/// </remarks>
/// <seealso>
///
/// vtkBalloonWidget
/// </seealso>
public class vtkBalloonRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Set/get the image property (relevant only if an image is shown).
	/// </summary>
	public enum ImageBottom_WrapperEnum
	{
		/// <summary>enum member</summary>
		ImageBottom = 2,
		/// <summary>enum member</summary>
		ImageLeft = 0,
		/// <summary>enum member</summary>
		ImageRight = 1,
		/// <summary>enum member</summary>
		ImageTop = 3
	}

	/// <summary>
	/// State is either outside, or inside (on the text portion of the image).
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		OnImage = 2,
		/// <summary>enum member</summary>
		OnText = 1,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBalloonRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBalloonRepresentation()
	{
		MRClassNameKey = "class vtkBalloonRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBalloonRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBalloonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkBalloonRepresentation New()
	{
		vtkBalloonRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkBalloonRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBalloonRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBalloonRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkBalloonRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkBalloonRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_EndWidgetInteraction_03(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void EndWidgetInteraction(IntPtr e)
	{
		vtkBalloonRepresentation_EndWidgetInteraction_03(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_GetBalloonImage_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify/retrieve the image to display in the balloon.
	/// </summary>
	public virtual vtkImageData GetBalloonImage()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonRepresentation_GetBalloonImage_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonRepresentation_GetBalloonLayout_05(HandleRef pThis);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public virtual int GetBalloonLayout()
	{
		return vtkBalloonRepresentation_GetBalloonLayout_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_GetBalloonText_06(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve the text to display in the balloon.
	/// </summary>
	public virtual string GetBalloonText()
	{
		return Marshal.PtrToStringAnsi(vtkBalloonRepresentation_GetBalloonText_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_GetFrameProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the frame property (relevant only if text is shown).
	/// The frame lies behind the text.
	/// </summary>
	public virtual vtkProperty2D GetFrameProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonRepresentation_GetFrameProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_GetImageProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the image property (relevant only if an image is shown).
	/// </summary>
	public virtual vtkProperty2D GetImageProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonRepresentation_GetImageProperty_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_GetImageSize_09(HandleRef pThis);

	/// <summary>
	/// Specify the minimum size for the image. Note that this is a bounding
	/// rectangle, the image will fit inside of it. However, if the balloon
	/// consists of text plus an image, then the image may be bigger than
	/// ImageSize[2] to fit into the balloon frame.
	/// </summary>
	public virtual int[] GetImageSize()
	{
		IntPtr intPtr = vtkBalloonRepresentation_GetImageSize_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_GetImageSize_10(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Specify the minimum size for the image. Note that this is a bounding
	/// rectangle, the image will fit inside of it. However, if the balloon
	/// consists of text plus an image, then the image may be bigger than
	/// ImageSize[2] to fit into the balloon frame.
	/// </summary>
	public virtual void GetImageSize(ref int _arg1, ref int _arg2)
	{
		vtkBalloonRepresentation_GetImageSize_10(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_GetImageSize_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the minimum size for the image. Note that this is a bounding
	/// rectangle, the image will fit inside of it. However, if the balloon
	/// consists of text plus an image, then the image may be bigger than
	/// ImageSize[2] to fit into the balloon frame.
	/// </summary>
	public virtual void GetImageSize(IntPtr _arg)
	{
		vtkBalloonRepresentation_GetImageSize_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBalloonRepresentation_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBalloonRepresentation_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBalloonRepresentation_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBalloonRepresentation_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_GetOffset_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset from the mouse pointer from which to place the
	/// balloon. The representation will try and honor this offset unless there
	/// is a collision with the side of the renderer, in which case the balloon
	/// will be repositioned to lie within the rendering window.
	/// </summary>
	public virtual int[] GetOffset()
	{
		IntPtr intPtr = vtkBalloonRepresentation_GetOffset_14(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_GetOffset_15(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/Get the offset from the mouse pointer from which to place the
	/// balloon. The representation will try and honor this offset unless there
	/// is a collision with the side of the renderer, in which case the balloon
	/// will be repositioned to lie within the rendering window.
	/// </summary>
	public virtual void GetOffset(ref int _arg1, ref int _arg2)
	{
		vtkBalloonRepresentation_GetOffset_15(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_GetOffset_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the offset from the mouse pointer from which to place the
	/// balloon. The representation will try and honor this offset unless there
	/// is a collision with the side of the renderer, in which case the balloon
	/// will be repositioned to lie within the rendering window.
	/// </summary>
	public virtual void GetOffset(IntPtr _arg)
	{
		vtkBalloonRepresentation_GetOffset_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonRepresentation_GetPadding_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding (in pixels) that is used between the text and the
	/// frame.
	/// </summary>
	public virtual int GetPadding()
	{
		return vtkBalloonRepresentation_GetPadding_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonRepresentation_GetPaddingMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding (in pixels) that is used between the text and the
	/// frame.
	/// </summary>
	public virtual int GetPaddingMaxValue()
	{
		return vtkBalloonRepresentation_GetPaddingMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonRepresentation_GetPaddingMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding (in pixels) that is used between the text and the
	/// frame.
	/// </summary>
	public virtual int GetPaddingMinValue()
	{
		return vtkBalloonRepresentation_GetPaddingMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_GetTextProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the text property (relevant only if text is shown).
	/// </summary>
	public virtual vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonRepresentation_GetTextProperty_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonRepresentation_IsA_21(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBalloonRepresentation_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonRepresentation_IsTypeOf_22(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBalloonRepresentation_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkBalloonRepresentation NewInstance()
	{
		vtkBalloonRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonRepresentation_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_ReleaseGraphicsResources_25(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkBalloonRepresentation_ReleaseGraphicsResources_25(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonRepresentation_RenderOverlay_26(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkBalloonRepresentation_RenderOverlay_26(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonRepresentation_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkBalloonRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkBalloonRepresentation vtkBalloonRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonRepresentation_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBalloonRepresentation2 = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBalloonRepresentation2.Register(null);
			}
		}
		return vtkBalloonRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonImage_28(HandleRef pThis, HandleRef img);

	/// <summary>
	/// Specify/retrieve the image to display in the balloon.
	/// </summary>
	public virtual void SetBalloonImage(vtkImageData img)
	{
		vtkBalloonRepresentation_SetBalloonImage_28(GetCppThis(), img?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonLayout_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public virtual void SetBalloonLayout(int _arg)
	{
		vtkBalloonRepresentation_SetBalloonLayout_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageBottom_30(HandleRef pThis);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public void SetBalloonLayoutToImageBottom()
	{
		vtkBalloonRepresentation_SetBalloonLayoutToImageBottom_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageLeft_31(HandleRef pThis);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public void SetBalloonLayoutToImageLeft()
	{
		vtkBalloonRepresentation_SetBalloonLayoutToImageLeft_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageRight_32(HandleRef pThis);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public void SetBalloonLayoutToImageRight()
	{
		vtkBalloonRepresentation_SetBalloonLayoutToImageRight_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageTop_33(HandleRef pThis);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public void SetBalloonLayoutToImageTop()
	{
		vtkBalloonRepresentation_SetBalloonLayoutToImageTop_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextBottom_34(HandleRef pThis);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public void SetBalloonLayoutToTextBottom()
	{
		vtkBalloonRepresentation_SetBalloonLayoutToTextBottom_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextLeft_35(HandleRef pThis);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public void SetBalloonLayoutToTextLeft()
	{
		vtkBalloonRepresentation_SetBalloonLayoutToTextLeft_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextRight_36(HandleRef pThis);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public void SetBalloonLayoutToTextRight()
	{
		vtkBalloonRepresentation_SetBalloonLayoutToTextRight_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextTop_37(HandleRef pThis);

	/// <summary>
	/// Specify the layout of the image and text within the balloon. Note that
	/// there are reduncies in these methods, for example
	/// SetBalloonLayoutToImageLeft() results in the same effect as
	/// SetBalloonLayoutToTextRight(). If only text is specified, or only an
	/// image is specified, then it doesn't matter how the layout is specified.
	/// </summary>
	public void SetBalloonLayoutToTextTop()
	{
		vtkBalloonRepresentation_SetBalloonLayoutToTextTop_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetBalloonText_38(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify/retrieve the text to display in the balloon.
	/// </summary>
	public virtual void SetBalloonText(string _arg)
	{
		vtkBalloonRepresentation_SetBalloonText_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetFrameProperty_39(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/get the frame property (relevant only if text is shown).
	/// The frame lies behind the text.
	/// </summary>
	public virtual void SetFrameProperty(vtkProperty2D p)
	{
		vtkBalloonRepresentation_SetFrameProperty_39(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetImageProperty_40(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/get the image property (relevant only if an image is shown).
	/// </summary>
	public virtual void SetImageProperty(vtkProperty2D p)
	{
		vtkBalloonRepresentation_SetImageProperty_40(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetImageSize_41(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify the minimum size for the image. Note that this is a bounding
	/// rectangle, the image will fit inside of it. However, if the balloon
	/// consists of text plus an image, then the image may be bigger than
	/// ImageSize[2] to fit into the balloon frame.
	/// </summary>
	public virtual void SetImageSize(int _arg1, int _arg2)
	{
		vtkBalloonRepresentation_SetImageSize_41(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetImageSize_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the minimum size for the image. Note that this is a bounding
	/// rectangle, the image will fit inside of it. However, if the balloon
	/// consists of text plus an image, then the image may be bigger than
	/// ImageSize[2] to fit into the balloon frame.
	/// </summary>
	public void SetImageSize(IntPtr _arg)
	{
		vtkBalloonRepresentation_SetImageSize_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetOffset_43(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/Get the offset from the mouse pointer from which to place the
	/// balloon. The representation will try and honor this offset unless there
	/// is a collision with the side of the renderer, in which case the balloon
	/// will be repositioned to lie within the rendering window.
	/// </summary>
	public virtual void SetOffset(int _arg1, int _arg2)
	{
		vtkBalloonRepresentation_SetOffset_43(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetOffset_44(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the offset from the mouse pointer from which to place the
	/// balloon. The representation will try and honor this offset unless there
	/// is a collision with the side of the renderer, in which case the balloon
	/// will be repositioned to lie within the rendering window.
	/// </summary>
	public void SetOffset(IntPtr _arg)
	{
		vtkBalloonRepresentation_SetOffset_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetPadding_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the padding (in pixels) that is used between the text and the
	/// frame.
	/// </summary>
	public virtual void SetPadding(int _arg)
	{
		vtkBalloonRepresentation_SetPadding_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_SetTextProperty_46(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/get the text property (relevant only if text is shown).
	/// </summary>
	public virtual void SetTextProperty(vtkTextProperty p)
	{
		vtkBalloonRepresentation_SetTextProperty_46(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonRepresentation_StartWidgetInteraction_47(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkBalloonRepresentation_StartWidgetInteraction_47(GetCppThis(), e);
	}
}
