using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkViewport
/// </summary>
/// <remarks>
///    abstract specification for Viewports
///
/// vtkViewport provides an abstract specification for Viewports. A Viewport
/// is an object that controls the rendering process for objects. Rendering
/// is the process of converting geometry, a specification for lights, and
/// a camera view into an image. vtkViewport also performs coordinate
/// transformation between world coordinates, view coordinates (the computer
/// graphics rendering coordinate system), and display coordinates (the
/// actual screen coordinates on the display device). Certain advanced
/// rendering features such as two-sided lighting can also be controlled.
///
/// </remarks>
/// <seealso>
///
/// vtkWindow vtkRenderer
/// </seealso>
public abstract class vtkViewport : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkViewport";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkViewport()
	{
		MRClassNameKey = "class vtkViewport";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewport"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkViewport(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_AddActor2D_01(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Add/Remove different types of props to the renderer.
	/// These methods are all synonyms to AddViewProp and RemoveViewProp.
	/// They are here for convenience and backwards compatibility.
	/// </summary>
	public void AddActor2D(vtkProp p)
	{
		vtkViewport_AddActor2D_01(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_AddViewProp_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a prop to the list of props. Does nothing if the prop is
	/// already present. Prop is the superclass of all actors, volumes,
	/// 2D actors, composite props etc.
	/// </summary>
	public void AddViewProp(vtkProp arg0)
	{
		vtkViewport_AddViewProp_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_ComputeAspect_03(HandleRef pThis);

	/// <summary>
	/// Set the aspect ratio of the rendered image. This is computed
	/// automatically and should not be set by the user.
	/// </summary>
	public virtual void ComputeAspect()
	{
		vtkViewport_ComputeAspect_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_DisplayToLocalDisplay_04(HandleRef pThis, ref double x, ref double y);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void DisplayToLocalDisplay(ref double x, ref double y)
	{
		vtkViewport_DisplayToLocalDisplay_04(GetCppThis(), ref x, ref y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_DisplayToNormalizedDisplay_05(HandleRef pThis, ref double u, ref double v);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void DisplayToNormalizedDisplay(ref double u, ref double v)
	{
		vtkViewport_DisplayToNormalizedDisplay_05(GetCppThis(), ref u, ref v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_DisplayToView_06(HandleRef pThis);

	/// <summary>
	/// Convert display coordinates to view coordinates.
	/// </summary>
	public virtual void DisplayToView()
	{
		vtkViewport_DisplayToView_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_DisplayToWorld_07(HandleRef pThis);

	/// <summary>
	/// Convert display (or screen) coordinates to world coordinates.
	/// </summary>
	public void DisplayToWorld()
	{
		vtkViewport_DisplayToWorld_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetActors2D_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add/Remove different types of props to the renderer.
	/// These methods are all synonyms to AddViewProp and RemoveViewProp.
	/// They are here for convenience and backwards compatibility.
	/// </summary>
	public vtkActor2DCollection GetActors2D()
	{
		vtkActor2DCollection vtkActor2DCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_GetActors2D_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2DCollection2 = (vtkActor2DCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2DCollection2.Register(null);
			}
		}
		return vtkActor2DCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetAspect_09(HandleRef pThis);

	/// <summary>
	/// Set the aspect ratio of the rendered image. This is computed
	/// automatically and should not be set by the user.
	/// </summary>
	public virtual double[] GetAspect()
	{
		IntPtr intPtr = vtkViewport_GetAspect_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetAspect_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the aspect ratio of the rendered image. This is computed
	/// automatically and should not be set by the user.
	/// </summary>
	public virtual void GetAspect(IntPtr data)
	{
		vtkViewport_GetAspect_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetBackground_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the background color of the rendering screen using an rgb color
	/// specification.
	/// </summary>
	public virtual double[] GetBackground()
	{
		IntPtr intPtr = vtkViewport_GetBackground_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetBackground_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the background color of the rendering screen using an rgb color
	/// specification.
	/// </summary>
	public virtual void GetBackground(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewport_GetBackground_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetBackground_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the background color of the rendering screen using an rgb color
	/// specification.
	/// </summary>
	public virtual void GetBackground(IntPtr _arg)
	{
		vtkViewport_GetBackground_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetBackground2_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the second background color of the rendering screen
	/// for gradient backgrounds using an rgb color specification.
	/// </summary>
	public virtual double[] GetBackground2()
	{
		IntPtr intPtr = vtkViewport_GetBackground2_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetBackground2_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the second background color of the rendering screen
	/// for gradient backgrounds using an rgb color specification.
	/// </summary>
	public virtual void GetBackground2(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewport_GetBackground2_15(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetBackground2_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the second background color of the rendering screen
	/// for gradient backgrounds using an rgb color specification.
	/// </summary>
	public virtual void GetBackground2(IntPtr _arg)
	{
		vtkViewport_GetBackground2_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetBackgroundAlpha_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the alpha value used to fill the background with.
	/// By default, this is set to 0.0.
	/// </summary>
	public virtual double GetBackgroundAlpha()
	{
		return vtkViewport_GetBackgroundAlpha_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetBackgroundAlphaMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the alpha value used to fill the background with.
	/// By default, this is set to 0.0.
	/// </summary>
	public virtual double GetBackgroundAlphaMaxValue()
	{
		return vtkViewport_GetBackgroundAlphaMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetBackgroundAlphaMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the alpha value used to fill the background with.
	/// By default, this is set to 0.0.
	/// </summary>
	public virtual double GetBackgroundAlphaMinValue()
	{
		return vtkViewport_GetBackgroundAlphaMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetCenter_20(HandleRef pThis);

	/// <summary>
	/// Return the center of this viewport in display coordinates.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkViewport_GetCenter_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetDisplayPoint_21(HandleRef pThis);

	/// <summary>
	/// Set/get a point location in display (or screen) coordinates.
	/// The lower left corner of the window is the origin and y increases
	/// as you go up the screen.
	/// </summary>
	public virtual double[] GetDisplayPoint()
	{
		IntPtr intPtr = vtkViewport_GetDisplayPoint_21(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetDisplayPoint_22(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/get a point location in display (or screen) coordinates.
	/// The lower left corner of the window is the origin and y increases
	/// as you go up the screen.
	/// </summary>
	public virtual void GetDisplayPoint(IntPtr data)
	{
		vtkViewport_GetDisplayPoint_22(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetEnvironmentalBG_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the constant environmental color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual double[] GetEnvironmentalBG()
	{
		IntPtr intPtr = vtkViewport_GetEnvironmentalBG_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetEnvironmentalBG_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the constant environmental color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual void GetEnvironmentalBG(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewport_GetEnvironmentalBG_24(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetEnvironmentalBG_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the constant environmental color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual void GetEnvironmentalBG(IntPtr _arg)
	{
		vtkViewport_GetEnvironmentalBG_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetEnvironmentalBG2_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the second environmental gradient color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual double[] GetEnvironmentalBG2()
	{
		IntPtr intPtr = vtkViewport_GetEnvironmentalBG2_26(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetEnvironmentalBG2_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the second environmental gradient color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual void GetEnvironmentalBG2(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewport_GetEnvironmentalBG2_27(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetEnvironmentalBG2_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the second environmental gradient color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual void GetEnvironmentalBG2(IntPtr _arg)
	{
		vtkViewport_GetEnvironmentalBG2_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkViewport_GetGradientBackground_29(HandleRef pThis);

	/// <summary>
	/// Set/Get whether this viewport should have a gradient background
	/// using the Background (bottom) and Background2 (top) colors.
	/// Default is off.
	/// </summary>
	public virtual bool GetGradientBackground()
	{
		return (vtkViewport_GetGradientBackground_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkViewport_GetGradientEnvironmentalBG_30(HandleRef pThis);

	/// <summary>
	/// Set/Get whether this viewport should enable the gradient environment
	/// using the EnvironmentalBG (bottom) and EnvironmentalBG2 (top) colors.
	/// Note this is currently ignored outside of RayTracing.
	/// Default is off.
	/// </summary>
	public virtual bool GetGradientEnvironmentalBG()
	{
		return (vtkViewport_GetGradientEnvironmentalBG_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkViewport_GetNumberOfGenerationsFromBase_31(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkViewport_GetNumberOfGenerationsFromBase_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkViewport_GetNumberOfGenerationsFromBaseType_32(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkViewport_GetNumberOfGenerationsFromBaseType_32(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetOrigin_33(HandleRef pThis);

	/// <summary>
	/// Get the size and origin of the viewport in display coordinates. Note:
	/// if the window has not yet been realized, GetSize() and GetOrigin()
	/// return (0,0).
	/// </summary>
	public virtual int[] GetOrigin()
	{
		IntPtr intPtr = vtkViewport_GetOrigin_33(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetPickHeight_34(HandleRef pThis);

	/// <summary>
	/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
	/// it's that same as selectionX and selectionY).
	/// </summary>
	public double GetPickHeight()
	{
		return vtkViewport_GetPickHeight_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetPickResultProps_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
	/// it's that same as selectionX and selectionY).
	/// </summary>
	public virtual vtkPropCollection GetPickResultProps()
	{
		vtkPropCollection vtkPropCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_GetPickResultProps_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPropCollection2 = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPropCollection2.Register(null);
			}
		}
		return vtkPropCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetPickWidth_36(HandleRef pThis);

	/// <summary>
	/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
	/// it's that same as selectionX and selectionY).
	/// </summary>
	public double GetPickWidth()
	{
		return vtkViewport_GetPickWidth_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetPickX_37(HandleRef pThis);

	/// <summary>
	/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
	/// it's that same as selectionX and selectionY).
	/// </summary>
	public double GetPickX()
	{
		return vtkViewport_GetPickX_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetPickX1_38(HandleRef pThis);

	/// <summary>
	/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
	/// it's that same as selectionX and selectionY).
	/// </summary>
	public double GetPickX1()
	{
		return vtkViewport_GetPickX1_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetPickX2_39(HandleRef pThis);

	/// <summary>
	/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
	/// it's that same as selectionX and selectionY).
	/// </summary>
	public double GetPickX2()
	{
		return vtkViewport_GetPickX2_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetPickY_40(HandleRef pThis);

	/// <summary>
	/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
	/// it's that same as selectionX and selectionY).
	/// </summary>
	public double GetPickY()
	{
		return vtkViewport_GetPickY_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetPickY1_41(HandleRef pThis);

	/// <summary>
	/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
	/// it's that same as selectionX and selectionY).
	/// </summary>
	public double GetPickY1()
	{
		return vtkViewport_GetPickY1_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetPickY2_42(HandleRef pThis);

	/// <summary>
	/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
	/// it's that same as selectionX and selectionY).
	/// </summary>
	public double GetPickY2()
	{
		return vtkViewport_GetPickY2_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewport_GetPickedZ_43(HandleRef pThis);

	/// <summary>
	/// Return the Z value for the last picked Prop.
	/// </summary>
	public virtual double GetPickedZ()
	{
		return vtkViewport_GetPickedZ_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetPixelAspect_44(HandleRef pThis);

	/// <summary>
	/// Set the aspect ratio of a pixel in the rendered image.
	/// This factor permits the image to rendered anisotropically
	/// (i.e., stretched in one direction or the other).
	/// </summary>
	public virtual double[] GetPixelAspect()
	{
		IntPtr intPtr = vtkViewport_GetPixelAspect_44(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetPixelAspect_45(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the aspect ratio of a pixel in the rendered image.
	/// This factor permits the image to rendered anisotropically
	/// (i.e., stretched in one direction or the other).
	/// </summary>
	public virtual void GetPixelAspect(IntPtr data)
	{
		vtkViewport_GetPixelAspect_45(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetSize_46(HandleRef pThis);

	/// <summary>
	/// Get the size and origin of the viewport in display coordinates. Note:
	/// if the window has not yet been realized, GetSize() and GetOrigin()
	/// return (0,0).
	/// </summary>
	public virtual int[] GetSize()
	{
		IntPtr intPtr = vtkViewport_GetSize_46(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetTiledSize_47(HandleRef pThis, IntPtr width, IntPtr height);

	/// <summary>
	/// Get the size and origin of the viewport in display coordinates. Note:
	/// if the window has not yet been realized, GetSize() and GetOrigin()
	/// return (0,0).
	/// </summary>
	public void GetTiledSize(IntPtr width, IntPtr height)
	{
		vtkViewport_GetTiledSize_47(GetCppThis(), width, height);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetTiledSizeAndOrigin_48(HandleRef pThis, IntPtr width, IntPtr height, IntPtr lowerLeftX, IntPtr lowerLeftY);

	/// <summary>
	/// Get the size and origin of the viewport in display coordinates. Note:
	/// if the window has not yet been realized, GetSize() and GetOrigin()
	/// return (0,0).
	/// </summary>
	public virtual void GetTiledSizeAndOrigin(IntPtr width, IntPtr height, IntPtr lowerLeftX, IntPtr lowerLeftY)
	{
		vtkViewport_GetTiledSizeAndOrigin_48(GetCppThis(), width, height, lowerLeftX, lowerLeftY);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetVTKWindow_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkWindow that owns this vtkViewport.
	/// </summary>
	public virtual vtkWindow GetVTKWindow()
	{
		vtkWindow vtkWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_GetVTKWindow_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWindow2 = (vtkWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWindow2.Register(null);
			}
		}
		return vtkWindow2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetViewPoint_50(HandleRef pThis);

	/// <summary>
	/// Specify a point location in view coordinates. The origin is in the
	/// middle of the viewport and it extends from -1 to 1 in all three
	/// dimensions.
	/// </summary>
	public virtual double[] GetViewPoint()
	{
		IntPtr intPtr = vtkViewport_GetViewPoint_50(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetViewPoint_51(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point location in view coordinates. The origin is in the
	/// middle of the viewport and it extends from -1 to 1 in all three
	/// dimensions.
	/// </summary>
	public virtual void GetViewPoint(IntPtr data)
	{
		vtkViewport_GetViewPoint_51(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetViewProps_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return any props in this viewport.
	/// </summary>
	public vtkPropCollection GetViewProps()
	{
		vtkPropCollection vtkPropCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_GetViewProps_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPropCollection2 = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPropCollection2.Register(null);
			}
		}
		return vtkPropCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetViewport_53(HandleRef pThis);

	/// <summary>
	/// Specify the viewport for the Viewport to draw in the rendering window.
	/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
	/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
	/// </summary>
	public virtual double[] GetViewport()
	{
		IntPtr intPtr = vtkViewport_GetViewport_53(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetViewport_54(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the viewport for the Viewport to draw in the rendering window.
	/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
	/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
	/// </summary>
	public virtual void GetViewport(IntPtr data)
	{
		vtkViewport_GetViewport_54(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_GetWorldPoint_55(HandleRef pThis);

	/// <summary>
	/// Specify a point location in world coordinates. This method takes
	/// homogeneous coordinates.
	/// </summary>
	public virtual double[] GetWorldPoint()
	{
		IntPtr intPtr = vtkViewport_GetWorldPoint_55(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GetWorldPoint_56(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point location in world coordinates. This method takes
	/// homogeneous coordinates.
	/// </summary>
	public virtual void GetWorldPoint(IntPtr data)
	{
		vtkViewport_GetWorldPoint_56(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GradientBackgroundOff_57(HandleRef pThis);

	/// <summary>
	/// Set/Get whether this viewport should have a gradient background
	/// using the Background (bottom) and Background2 (top) colors.
	/// Default is off.
	/// </summary>
	public virtual void GradientBackgroundOff()
	{
		vtkViewport_GradientBackgroundOff_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GradientBackgroundOn_58(HandleRef pThis);

	/// <summary>
	/// Set/Get whether this viewport should have a gradient background
	/// using the Background (bottom) and Background2 (top) colors.
	/// Default is off.
	/// </summary>
	public virtual void GradientBackgroundOn()
	{
		vtkViewport_GradientBackgroundOn_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GradientEnvironmentalBGOff_59(HandleRef pThis);

	/// <summary>
	/// Set/Get whether this viewport should enable the gradient environment
	/// using the EnvironmentalBG (bottom) and EnvironmentalBG2 (top) colors.
	/// Note this is currently ignored outside of RayTracing.
	/// Default is off.
	/// </summary>
	public virtual void GradientEnvironmentalBGOff()
	{
		vtkViewport_GradientEnvironmentalBGOff_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_GradientEnvironmentalBGOn_60(HandleRef pThis);

	/// <summary>
	/// Set/Get whether this viewport should enable the gradient environment
	/// using the EnvironmentalBG (bottom) and EnvironmentalBG2 (top) colors.
	/// Note this is currently ignored outside of RayTracing.
	/// Default is off.
	/// </summary>
	public virtual void GradientEnvironmentalBGOn()
	{
		vtkViewport_GradientEnvironmentalBGOn_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewport_HasViewProp_61(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Query if a prop is in the list of props.
	/// </summary>
	public int HasViewProp(vtkProp arg0)
	{
		return vtkViewport_HasViewProp_61(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewport_IsA_62(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkViewport_IsA_62(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewport_IsInViewport_63(HandleRef pThis, int x, int y);

	/// <summary>
	/// Is a given display point in this Viewport's viewport.
	/// </summary>
	public virtual int IsInViewport(int x, int y)
	{
		return vtkViewport_IsInViewport_63(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewport_IsTypeOf_64(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkViewport_IsTypeOf_64(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_LocalDisplayToDisplay_65(HandleRef pThis, ref double x, ref double y);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void LocalDisplayToDisplay(ref double x, ref double y)
	{
		vtkViewport_LocalDisplayToDisplay_65(GetCppThis(), ref x, ref y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_NewInstance_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkViewport NewInstance()
	{
		vtkViewport result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_NewInstance_66(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkViewport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_NormalizedDisplayToDisplay_67(HandleRef pThis, ref double u, ref double v);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void NormalizedDisplayToDisplay(ref double u, ref double v)
	{
		vtkViewport_NormalizedDisplayToDisplay_67(GetCppThis(), ref u, ref v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_NormalizedDisplayToViewport_68(HandleRef pThis, ref double x, ref double y);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void NormalizedDisplayToViewport(ref double x, ref double y)
	{
		vtkViewport_NormalizedDisplayToViewport_68(GetCppThis(), ref x, ref y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_NormalizedViewportToView_69(HandleRef pThis, ref double x, ref double y, ref double z);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void NormalizedViewportToView(ref double x, ref double y, ref double z)
	{
		vtkViewport_NormalizedViewportToView_69(GetCppThis(), ref x, ref y, ref z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_NormalizedViewportToViewport_70(HandleRef pThis, ref double u, ref double v);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void NormalizedViewportToViewport(ref double u, ref double v)
	{
		vtkViewport_NormalizedViewportToViewport_70(GetCppThis(), ref u, ref v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_PickProp_71(HandleRef pThis, double selectionX, double selectionY, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the Prop that has the highest z value at the given x, y position
	/// in the viewport.  Basically, the top most prop that renders the pixel at
	/// selectionX, selectionY will be returned.  If no Props are there NULL is
	/// returned.  This method selects from the Viewports Prop list.
	/// </summary>
	public virtual vtkAssemblyPath PickProp(double selectionX, double selectionY)
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_PickProp_71(GetCppThis(), selectionX, selectionY, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_PickProp_72(HandleRef pThis, double selectionX1, double selectionY1, double selectionX2, double selectionY2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the Prop that has the highest z value at the given x1, y1
	/// and x2,y2 positions in the viewport.  Basically, the top most prop that
	/// renders the pixel at selectionX1, selectionY1, selectionX2, selectionY2
	/// will be returned.  If no Props are there NULL is returned.  This method
	/// selects from the Viewports Prop list.
	/// </summary>
	public virtual vtkAssemblyPath PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_PickProp_72(GetCppThis(), selectionX1, selectionY1, selectionX2, selectionY2, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_PickPropFrom_73(HandleRef pThis, double selectionX, double selectionY, HandleRef arg2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Same as PickProp with two arguments, but selects from the given
	/// collection of Props instead of the Renderers props.  Make sure
	/// the Props in the collection are in this renderer.
	/// </summary>
	public vtkAssemblyPath PickPropFrom(double selectionX, double selectionY, vtkPropCollection arg2)
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_PickPropFrom_73(GetCppThis(), selectionX, selectionY, arg2?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_PickPropFrom_74(HandleRef pThis, double selectionX1, double selectionY1, double selectionX2, double selectionY2, HandleRef arg4, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Same as PickProp with four arguments, but selects from the given
	/// collection of Props instead of the Renderers props.  Make sure
	/// the Props in the collection are in this renderer.
	/// </summary>
	public vtkAssemblyPath PickPropFrom(double selectionX1, double selectionY1, double selectionX2, double selectionY2, vtkPropCollection arg4)
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_PickPropFrom_74(GetCppThis(), selectionX1, selectionY1, selectionX2, selectionY2, arg4?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_PoseToView_75(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void PoseToView(ref double arg0, ref double arg1, ref double arg2)
	{
		vtkViewport_PoseToView_75(GetCppThis(), ref arg0, ref arg1, ref arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_PoseToWorld_76(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void PoseToWorld(ref double arg0, ref double arg1, ref double arg2)
	{
		vtkViewport_PoseToWorld_76(GetCppThis(), ref arg0, ref arg1, ref arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_RemoveActor2D_77(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Add/Remove different types of props to the renderer.
	/// These methods are all synonyms to AddViewProp and RemoveViewProp.
	/// They are here for convenience and backwards compatibility.
	/// </summary>
	public void RemoveActor2D(vtkProp p)
	{
		vtkViewport_RemoveActor2D_77(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_RemoveAllViewProps_78(HandleRef pThis);

	/// <summary>
	/// Remove all props from the list of props.
	/// </summary>
	public void RemoveAllViewProps()
	{
		vtkViewport_RemoveAllViewProps_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_RemoveViewProp_79(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a prop from the list of props. Does nothing if the prop
	/// is not already present or if the parameter is NULL.
	/// </summary>
	public void RemoveViewProp(vtkProp arg0)
	{
		vtkViewport_RemoveViewProp_79(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewport_SafeDownCast_80(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkViewport SafeDownCast(vtkObjectBase o)
	{
		vtkViewport vtkViewport2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewport_SafeDownCast_80(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewport2 = (vtkViewport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewport2.Register(null);
			}
		}
		return vtkViewport2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetAspect_81(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the aspect ratio of the rendered image. This is computed
	/// automatically and should not be set by the user.
	/// </summary>
	public virtual void SetAspect(double _arg1, double _arg2)
	{
		vtkViewport_SetAspect_81(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetAspect_82(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the aspect ratio of the rendered image. This is computed
	/// automatically and should not be set by the user.
	/// </summary>
	public void SetAspect(IntPtr _arg)
	{
		vtkViewport_SetAspect_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetBackground_83(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the background color of the rendering screen using an rgb color
	/// specification.
	/// </summary>
	public virtual void SetBackground(double _arg1, double _arg2, double _arg3)
	{
		vtkViewport_SetBackground_83(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetBackground_84(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the background color of the rendering screen using an rgb color
	/// specification.
	/// </summary>
	public virtual void SetBackground(IntPtr _arg)
	{
		vtkViewport_SetBackground_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetBackground2_85(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the second background color of the rendering screen
	/// for gradient backgrounds using an rgb color specification.
	/// </summary>
	public virtual void SetBackground2(double _arg1, double _arg2, double _arg3)
	{
		vtkViewport_SetBackground2_85(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetBackground2_86(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the second background color of the rendering screen
	/// for gradient backgrounds using an rgb color specification.
	/// </summary>
	public virtual void SetBackground2(IntPtr _arg)
	{
		vtkViewport_SetBackground2_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetBackgroundAlpha_87(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the alpha value used to fill the background with.
	/// By default, this is set to 0.0.
	/// </summary>
	public virtual void SetBackgroundAlpha(double _arg)
	{
		vtkViewport_SetBackgroundAlpha_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetDisplayPoint_88(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get a point location in display (or screen) coordinates.
	/// The lower left corner of the window is the origin and y increases
	/// as you go up the screen.
	/// </summary>
	public virtual void SetDisplayPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkViewport_SetDisplayPoint_88(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetDisplayPoint_89(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get a point location in display (or screen) coordinates.
	/// The lower left corner of the window is the origin and y increases
	/// as you go up the screen.
	/// </summary>
	public virtual void SetDisplayPoint(IntPtr _arg)
	{
		vtkViewport_SetDisplayPoint_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetEnvironmentalBG_90(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the constant environmental color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual void SetEnvironmentalBG(double _arg1, double _arg2, double _arg3)
	{
		vtkViewport_SetEnvironmentalBG_90(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetEnvironmentalBG_91(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the constant environmental color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual void SetEnvironmentalBG(IntPtr _arg)
	{
		vtkViewport_SetEnvironmentalBG_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetEnvironmentalBG2_92(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the second environmental gradient color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual void SetEnvironmentalBG2(double _arg1, double _arg2, double _arg3)
	{
		vtkViewport_SetEnvironmentalBG2_92(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetEnvironmentalBG2_93(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the second environmental gradient color using an rgb color specification.
	/// Note this is currently ignored outside of RayTracing.
	/// </summary>
	public virtual void SetEnvironmentalBG2(IntPtr _arg)
	{
		vtkViewport_SetEnvironmentalBG2_93(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetGradientBackground_94(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether this viewport should have a gradient background
	/// using the Background (bottom) and Background2 (top) colors.
	/// Default is off.
	/// </summary>
	public virtual void SetGradientBackground(bool _arg)
	{
		vtkViewport_SetGradientBackground_94(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetGradientEnvironmentalBG_95(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether this viewport should enable the gradient environment
	/// using the EnvironmentalBG (bottom) and EnvironmentalBG2 (top) colors.
	/// Note this is currently ignored outside of RayTracing.
	/// Default is off.
	/// </summary>
	public virtual void SetGradientEnvironmentalBG(bool _arg)
	{
		vtkViewport_SetGradientEnvironmentalBG_95(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetPixelAspect_96(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the aspect ratio of a pixel in the rendered image.
	/// This factor permits the image to rendered anisotropically
	/// (i.e., stretched in one direction or the other).
	/// </summary>
	public virtual void SetPixelAspect(double _arg1, double _arg2)
	{
		vtkViewport_SetPixelAspect_96(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetPixelAspect_97(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the aspect ratio of a pixel in the rendered image.
	/// This factor permits the image to rendered anisotropically
	/// (i.e., stretched in one direction or the other).
	/// </summary>
	public void SetPixelAspect(IntPtr _arg)
	{
		vtkViewport_SetPixelAspect_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetViewPoint_98(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a point location in view coordinates. The origin is in the
	/// middle of the viewport and it extends from -1 to 1 in all three
	/// dimensions.
	/// </summary>
	public virtual void SetViewPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkViewport_SetViewPoint_98(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetViewPoint_99(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a point location in view coordinates. The origin is in the
	/// middle of the viewport and it extends from -1 to 1 in all three
	/// dimensions.
	/// </summary>
	public virtual void SetViewPoint(IntPtr _arg)
	{
		vtkViewport_SetViewPoint_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetViewport_100(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Specify the viewport for the Viewport to draw in the rendering window.
	/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
	/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
	/// </summary>
	public virtual void SetViewport(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkViewport_SetViewport_100(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetViewport_101(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the viewport for the Viewport to draw in the rendering window.
	/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
	/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
	/// </summary>
	public virtual void SetViewport(IntPtr _arg)
	{
		vtkViewport_SetViewport_101(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetWorldPoint_102(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Specify a point location in world coordinates. This method takes
	/// homogeneous coordinates.
	/// </summary>
	public virtual void SetWorldPoint(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkViewport_SetWorldPoint_102(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_SetWorldPoint_103(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a point location in world coordinates. This method takes
	/// homogeneous coordinates.
	/// </summary>
	public virtual void SetWorldPoint(IntPtr _arg)
	{
		vtkViewport_SetWorldPoint_103(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_ViewToDisplay_104(HandleRef pThis);

	/// <summary>
	/// Convert view coordinates to display coordinates.
	/// </summary>
	public virtual void ViewToDisplay()
	{
		vtkViewport_ViewToDisplay_104(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_ViewToDisplay_105(HandleRef pThis, ref double x, ref double y, ref double z);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void ViewToDisplay(ref double x, ref double y, ref double z)
	{
		vtkViewport_ViewToDisplay_105(GetCppThis(), ref x, ref y, ref z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_ViewToNormalizedViewport_106(HandleRef pThis, ref double x, ref double y, ref double z);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void ViewToNormalizedViewport(ref double x, ref double y, ref double z)
	{
		vtkViewport_ViewToNormalizedViewport_106(GetCppThis(), ref x, ref y, ref z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_ViewToPose_107(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void ViewToPose(ref double arg0, ref double arg1, ref double arg2)
	{
		vtkViewport_ViewToPose_107(GetCppThis(), ref arg0, ref arg1, ref arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_ViewToWorld_108(HandleRef pThis);

	/// <summary>
	/// Convert view point coordinates to world coordinates.
	/// </summary>
	public virtual void ViewToWorld()
	{
		vtkViewport_ViewToWorld_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_ViewToWorld_109(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void ViewToWorld(ref double arg0, ref double arg1, ref double arg2)
	{
		vtkViewport_ViewToWorld_109(GetCppThis(), ref arg0, ref arg1, ref arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_ViewportToNormalizedDisplay_110(HandleRef pThis, ref double x, ref double y);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void ViewportToNormalizedDisplay(ref double x, ref double y)
	{
		vtkViewport_ViewportToNormalizedDisplay_110(GetCppThis(), ref x, ref y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_ViewportToNormalizedViewport_111(HandleRef pThis, ref double u, ref double v);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void ViewportToNormalizedViewport(ref double u, ref double v)
	{
		vtkViewport_ViewportToNormalizedViewport_111(GetCppThis(), ref u, ref v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_WorldToDisplay_112(HandleRef pThis);

	/// <summary>
	/// Convert world point coordinates to display (or screen) coordinates.
	/// </summary>
	public void WorldToDisplay()
	{
		vtkViewport_WorldToDisplay_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_WorldToDisplay_113(HandleRef pThis, ref double x, ref double y, ref double z);

	/// <summary>
	/// Convert world point coordinates to display (or screen) coordinates.
	/// </summary>
	public void WorldToDisplay(ref double x, ref double y, ref double z)
	{
		vtkViewport_WorldToDisplay_113(GetCppThis(), ref x, ref y, ref z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_WorldToPose_114(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void WorldToPose(ref double arg0, ref double arg1, ref double arg2)
	{
		vtkViewport_WorldToPose_114(GetCppThis(), ref arg0, ref arg1, ref arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_WorldToView_115(HandleRef pThis);

	/// <summary>
	/// Convert world point coordinates to view coordinates.
	/// </summary>
	public virtual void WorldToView()
	{
		vtkViewport_WorldToView_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewport_WorldToView_116(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

	/// <summary>
	/// These methods map from one coordinate system to another.
	/// They are primarily used by the vtkCoordinate object and
	/// are often strung together. These methods return valid information
	/// only if the window has been realized (e.g., GetSize() returns
	/// something other than (0,0)).
	/// </summary>
	public virtual void WorldToView(ref double arg0, ref double arg1, ref double arg2)
	{
		vtkViewport_WorldToView_116(GetCppThis(), ref arg0, ref arg1, ref arg2);
	}
}
