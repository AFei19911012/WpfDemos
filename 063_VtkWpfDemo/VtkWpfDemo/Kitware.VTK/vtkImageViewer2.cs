using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageViewer2
/// </summary>
/// <remarks>
///    Display a 2D image.
///
/// vtkImageViewer2 is a convenience class for displaying a 2D image.  It
/// packages up the functionality found in vtkRenderWindow, vtkRenderer,
/// vtkImageActor and vtkImageMapToWindowLevelColors into a single easy to use
/// class.  This class also creates an image interactor style
/// (vtkInteractorStyleImage) that allows zooming and panning of images, and
/// supports interactive window/level operations on the image. Note that
/// vtkImageViewer2 is simply a wrapper around these classes.
///
/// vtkImageViewer2 uses the 3D rendering and texture mapping engine
/// to draw an image on a plane.  This allows for rapid rendering,
/// zooming, and panning. The image is placed in the 3D scene at a
/// depth based on the z-coordinate of the particular image slice. Each
/// call to SetSlice() changes the image data (slice) displayed AND
/// changes the depth of the displayed slice in the 3D scene. This can
/// be controlled by the AutoAdjustCameraClippingRange ivar of the
/// InteractorStyle member.
///
/// It is possible to mix images and geometry, using the methods:
///
/// viewer-&gt;SetInputConnection( imageSource-&gt;GetOutputPort() );
/// // or viewer-&gt;SetInputData ( image );
/// viewer-&gt;GetRenderer()-&gt;AddActor( myActor );
///
/// This can be used to annotate an image with a PolyData of "edges" or
/// or highlight sections of an image or display a 3D isosurface
/// with a slice from the volume, etc. Any portions of your geometry
/// that are in front of the displayed slice will be visible; any
/// portions of your geometry that are behind the displayed slice will
/// be obscured. A more general framework (with respect to viewing
/// direction) for achieving this effect is provided by the
/// vtkImagePlaneWidget .
///
/// Note that pressing 'r' will reset the window/level and pressing
/// shift+'r' or control+'r' will reset the camera.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderWindow vtkRenderer vtkImageActor vtkImageMapToWindowLevelColors
/// </seealso>
public class vtkImageViewer2 : vtkObject
{
	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public enum SLICE_ORIENTATION_XY_WrapperEnum
	{
		/// <summary>enum member</summary>
		SLICE_ORIENTATION_XY = 2,
		/// <summary>enum member</summary>
		SLICE_ORIENTATION_XZ = 1,
		/// <summary>enum member</summary>
		SLICE_ORIENTATION_YZ = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageViewer2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageViewer2()
	{
		MRClassNameKey = "class vtkImageViewer2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageViewer2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageViewer2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageViewer2 New()
	{
		vtkImageViewer2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageViewer2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageViewer2()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageViewer2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkImageViewer2_GetColorLevel_01(HandleRef pThis);

	/// <summary>
	/// Set window and level for mapping pixels to colors.
	/// </summary>
	public virtual double GetColorLevel()
	{
		return vtkImageViewer2_GetColorLevel_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageViewer2_GetColorWindow_02(HandleRef pThis);

	/// <summary>
	/// Set window and level for mapping pixels to colors.
	/// </summary>
	public virtual double GetColorWindow()
	{
		return vtkImageViewer2_GetColorWindow_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetImageActor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal render window, renderer, image actor, and
	/// image map instances.
	/// </summary>
	public virtual vtkImageActor GetImageActor()
	{
		vtkImageActor vtkImageActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer2_GetImageActor_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the input image to the viewer.
	/// </summary>
	public virtual vtkImageData GetInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer2_GetInput_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetInteractorStyle_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal render window, renderer, image actor, and
	/// image map instances.
	/// </summary>
	public virtual vtkInteractorStyleImage GetInteractorStyle()
	{
		vtkInteractorStyleImage vtkInteractorStyleImage2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer2_GetInteractorStyle_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleImage2 = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleImage2.Register(null);
			}
		}
		return vtkInteractorStyleImage2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageViewer2_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageViewer2_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageViewer2_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageViewer2_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer2_GetOffScreenRendering_08(HandleRef pThis);

	/// <summary>
	/// Create a window in memory instead of on the screen. This may not
	/// be supported for every type of window and on some windows you may
	/// need to invoke this prior to the first render.
	/// </summary>
	public virtual int GetOffScreenRendering()
	{
		return vtkImageViewer2_GetOffScreenRendering_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetPosition_09(HandleRef pThis);

	/// <summary>
	/// Get the position (x and y) of the rendering window in
	/// screen coordinates (in pixels).
	/// </summary>
	public virtual IntPtr GetPosition()
	{
		return vtkImageViewer2_GetPosition_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetRenderWindow_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal render window, renderer, image actor, and
	/// image map instances.
	/// </summary>
	public virtual vtkRenderWindow GetRenderWindow()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer2_GetRenderWindow_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetRenderer_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal render window, renderer, image actor, and
	/// image map instances.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer2_GetRenderer_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetSize_12(HandleRef pThis);

	/// <summary>
	/// Get the size (width and height) of the rendering window in
	/// screen coordinates (in pixels).
	/// </summary>
	public virtual IntPtr GetSize()
	{
		return vtkImageViewer2_GetSize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer2_GetSlice_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the current slice to display (depending on the orientation
	/// this can be in X, Y or Z).
	/// </summary>
	public virtual int GetSlice()
	{
		return vtkImageViewer2_GetSlice_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer2_GetSliceMax_14(HandleRef pThis);

	/// <summary>
	/// Return the minimum and maximum slice values (depending on the orientation
	/// this can be in X, Y or Z).
	/// </summary>
	public virtual int GetSliceMax()
	{
		return vtkImageViewer2_GetSliceMax_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer2_GetSliceMin_15(HandleRef pThis);

	/// <summary>
	/// Return the minimum and maximum slice values (depending on the orientation
	/// this can be in X, Y or Z).
	/// </summary>
	public virtual int GetSliceMin()
	{
		return vtkImageViewer2_GetSliceMin_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer2_GetSliceOrientation_16(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual int GetSliceOrientation()
	{
		return vtkImageViewer2_GetSliceOrientation_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_GetSliceRange_17(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Return the minimum and maximum slice values (depending on the orientation
	/// this can be in X, Y or Z).
	/// </summary>
	public virtual void GetSliceRange(IntPtr range)
	{
		vtkImageViewer2_GetSliceRange_17(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_GetSliceRange_18(HandleRef pThis, ref int min, ref int max);

	/// <summary>
	/// Return the minimum and maximum slice values (depending on the orientation
	/// this can be in X, Y or Z).
	/// </summary>
	public virtual void GetSliceRange(ref int min, ref int max)
	{
		vtkImageViewer2_GetSliceRange_18(GetCppThis(), ref min, ref max);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetSliceRange_19(HandleRef pThis);

	/// <summary>
	/// Return the minimum and maximum slice values (depending on the orientation
	/// this can be in X, Y or Z).
	/// </summary>
	public virtual IntPtr GetSliceRange()
	{
		return vtkImageViewer2_GetSliceRange_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetWindowLevel_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal render window, renderer, image actor, and
	/// image map instances.
	/// </summary>
	public virtual vtkImageMapToWindowLevelColors GetWindowLevel()
	{
		vtkImageMapToWindowLevelColors vtkImageMapToWindowLevelColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer2_GetWindowLevel_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapToWindowLevelColors2 = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapToWindowLevelColors2.Register(null);
			}
		}
		return vtkImageMapToWindowLevelColors2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_GetWindowName_21(HandleRef pThis);

	/// <summary>
	/// Get the name of rendering window.
	/// </summary>
	public virtual string GetWindowName()
	{
		return Marshal.PtrToStringAnsi(vtkImageViewer2_GetWindowName_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer2_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageViewer2_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer2_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageViewer2_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageViewer2 NewInstance()
	{
		vtkImageViewer2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer2_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageViewer2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_OffScreenRenderingOff_26(HandleRef pThis);

	/// <summary>
	/// Create a window in memory instead of on the screen. This may not
	/// be supported for every type of window and on some windows you may
	/// need to invoke this prior to the first render.
	/// </summary>
	public virtual void OffScreenRenderingOff()
	{
		vtkImageViewer2_OffScreenRenderingOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_OffScreenRenderingOn_27(HandleRef pThis);

	/// <summary>
	/// Create a window in memory instead of on the screen. This may not
	/// be supported for every type of window and on some windows you may
	/// need to invoke this prior to the first render.
	/// </summary>
	public virtual void OffScreenRenderingOn()
	{
		vtkImageViewer2_OffScreenRenderingOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_Render_28(HandleRef pThis);

	/// <summary>
	/// Render the resulting image.
	/// </summary>
	public virtual void Render()
	{
		vtkImageViewer2_Render_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer2_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageViewer2 SafeDownCast(vtkObjectBase o)
	{
		vtkImageViewer2 vtkImageViewer3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer2_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageViewer3 = (vtkImageViewer2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageViewer3.Register(null);
			}
		}
		return vtkImageViewer3;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetColorLevel_30(HandleRef pThis, double s);

	/// <summary>
	/// Set window and level for mapping pixels to colors.
	/// </summary>
	public virtual void SetColorLevel(double s)
	{
		vtkImageViewer2_SetColorLevel_30(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetColorWindow_31(HandleRef pThis, double s);

	/// <summary>
	/// Set window and level for mapping pixels to colors.
	/// </summary>
	public virtual void SetColorWindow(double s)
	{
		vtkImageViewer2_SetColorWindow_31(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetDisplayId_32(HandleRef pThis, IntPtr a);

	/// <summary>
	/// These are here when using a Tk window.
	/// </summary>
	public virtual void SetDisplayId(IntPtr a)
	{
		vtkImageViewer2_SetDisplayId_32(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetInputConnection_33(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set/Get the input image to the viewer.
	/// </summary>
	public virtual void SetInputConnection(vtkAlgorithmOutput input)
	{
		vtkImageViewer2_SetInputConnection_33(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetInputData_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the input image to the viewer.
	/// </summary>
	public virtual void SetInputData(vtkImageData arg0)
	{
		vtkImageViewer2_SetInputData_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetOffScreenRendering_35(HandleRef pThis, int arg0);

	/// <summary>
	/// Create a window in memory instead of on the screen. This may not
	/// be supported for every type of window and on some windows you may
	/// need to invoke this prior to the first render.
	/// </summary>
	public virtual void SetOffScreenRendering(int arg0)
	{
		vtkImageViewer2_SetOffScreenRendering_35(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetParentId_36(HandleRef pThis, IntPtr a);

	/// <summary>
	/// These are here when using a Tk window.
	/// </summary>
	public virtual void SetParentId(IntPtr a)
	{
		vtkImageViewer2_SetParentId_36(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetPosition_37(HandleRef pThis, int x, int y);

	/// <summary>
	/// Set the position (x and y) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	/// </summary>
	public virtual void SetPosition(int x, int y)
	{
		vtkImageViewer2_SetPosition_37(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetPosition_38(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the position (x and y) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	/// </summary>
	public virtual void SetPosition(IntPtr a)
	{
		vtkImageViewer2_SetPosition_38(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetRenderWindow_39(HandleRef pThis, HandleRef arg);

	/// <summary>
	/// Set your own renderwindow and renderer
	/// </summary>
	public virtual void SetRenderWindow(vtkRenderWindow arg)
	{
		vtkImageViewer2_SetRenderWindow_39(GetCppThis(), arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetRenderer_40(HandleRef pThis, HandleRef arg);

	/// <summary>
	/// Set your own renderwindow and renderer
	/// </summary>
	public virtual void SetRenderer(vtkRenderer arg)
	{
		vtkImageViewer2_SetRenderer_40(GetCppThis(), arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetSize_41(HandleRef pThis, int width, int height);

	/// <summary>
	/// Set the size (width and height) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public virtual void SetSize(int width, int height)
	{
		vtkImageViewer2_SetSize_41(GetCppThis(), width, height);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetSize_42(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the size (width and height) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public virtual void SetSize(IntPtr a)
	{
		vtkImageViewer2_SetSize_42(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetSlice_43(HandleRef pThis, int s);

	/// <summary>
	/// Set/Get the current slice to display (depending on the orientation
	/// this can be in X, Y or Z).
	/// </summary>
	public virtual void SetSlice(int s)
	{
		vtkImageViewer2_SetSlice_43(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetSliceOrientation_44(HandleRef pThis, int orientation);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetSliceOrientation(int orientation)
	{
		vtkImageViewer2_SetSliceOrientation_44(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetSliceOrientationToXY_45(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetSliceOrientationToXY()
	{
		vtkImageViewer2_SetSliceOrientationToXY_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetSliceOrientationToXZ_46(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetSliceOrientationToXZ()
	{
		vtkImageViewer2_SetSliceOrientationToXZ_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetSliceOrientationToYZ_47(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetSliceOrientationToYZ()
	{
		vtkImageViewer2_SetSliceOrientationToYZ_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetWindowId_48(HandleRef pThis, IntPtr a);

	/// <summary>
	/// These are here when using a Tk window.
	/// </summary>
	public virtual void SetWindowId(IntPtr a)
	{
		vtkImageViewer2_SetWindowId_48(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_SetupInteractor_49(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Attach an interactor for the internal render window.
	/// </summary>
	public virtual void SetupInteractor(vtkRenderWindowInteractor arg0)
	{
		vtkImageViewer2_SetupInteractor_49(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer2_UpdateDisplayExtent_50(HandleRef pThis);

	/// <summary>
	/// Update the display extent manually so that the proper slice for the
	/// given orientation is displayed. It will also try to set a
	/// reasonable camera clipping range.
	/// This method is called automatically when the Input is changed, but
	/// most of the time the input of this class is likely to remain the same,
	/// i.e. connected to the output of a filter, or an image reader. When the
	/// input of this filter or reader itself is changed, an error message might
	/// be displayed since the current display extent is probably outside
	/// the new whole extent. Calling this method will ensure that the display
	/// extent is reset properly.
	/// </summary>
	public virtual void UpdateDisplayExtent()
	{
		vtkImageViewer2_UpdateDisplayExtent_50(GetCppThis());
	}
}
