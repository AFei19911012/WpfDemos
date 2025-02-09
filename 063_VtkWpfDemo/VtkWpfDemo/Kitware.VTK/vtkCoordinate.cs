using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCoordinate
/// </summary>
/// <remarks>
///    perform coordinate transformation, and represent position, in a variety of vtk
/// coordinate systems
///
/// vtkCoordinate represents position in a variety of coordinate systems, and
/// converts position to other coordinate systems. It also supports relative
/// positioning, so you can create a cascade of vtkCoordinate objects (no loops
/// please!) that refer to each other. The typical usage of this object is
/// to set the coordinate system in which to represent a position (e.g.,
/// SetCoordinateSystemToNormalizedDisplay()), set the value of the coordinate
/// (e.g., SetValue()), and then invoke the appropriate method to convert to
/// another coordinate system (e.g., GetComputedWorldValue()).
///
/// The coordinate systems in vtk are as follows:
/// &lt;PRE&gt;
///   DISPLAY -             x-y pixel values in window
///      0, 0 is the lower left of the first pixel,
///      size, size is the upper right of the last pixel
///   NORMALIZED DISPLAY -  x-y (0,1) normalized values
///      0, 0 is the lower left of the first pixel,
///      1, 1 is the upper right of the last pixel
///   VIEWPORT -            x-y pixel values in viewport
///      0, 0 is the lower left of the first pixel,
///      size, size is the upper right of the last pixel
///   NORMALIZED VIEWPORT - x-y (0,1) normalized value in viewport
///      0, 0 is the lower left of the first pixel,
///      1, 1 is the upper right of the last pixel
///   VIEW -                x-y-z (-1,1) values in pose coordinates. (z is depth)
///   POSE -                world coords translated and rotated to the camera
///                         position and view direction
///   WORLD -               x-y-z global coordinate values
///   USERDEFINED -         x-y-z in User defined space
/// &lt;/PRE&gt;
///
/// If you cascade vtkCoordinate objects, you refer to another vtkCoordinate
/// object which in turn can refer to others, and so on. This allows you to
/// create composite groups of things like vtkActor2D that are positioned
/// relative to one another. Note that in cascaded sequences, each
/// vtkCoordinate object may be specified in different coordinate systems!
///
/// </remarks>
/// <seealso>
///
/// vtkActor2D vtkScalarBarActor
/// </seealso>
public class vtkCoordinate : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCoordinate";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCoordinate()
	{
		MRClassNameKey = "class vtkCoordinate";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoordinate"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCoordinate(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates an instance of this class with the following defaults:
	/// value of  (0,0,0) in world coordinates.
	/// </summary>
	public new static vtkCoordinate New()
	{
		vtkCoordinate result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinate_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates an instance of this class with the following defaults:
	/// value of  (0,0,0) in world coordinates.
	/// </summary>
	public vtkCoordinate()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCoordinate_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetComputedDisplayValue_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Return the computed value in a specified coordinate system.
	/// </summary>
	public int[] GetComputedDisplayValue(vtkViewport arg0)
	{
		IntPtr intPtr = vtkCoordinate_GetComputedDisplayValue_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetComputedDoubleDisplayValue_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Return the computed value in a specified coordinate system.
	/// </summary>
	public double[] GetComputedDoubleDisplayValue(vtkViewport arg0)
	{
		IntPtr intPtr = vtkCoordinate_GetComputedDoubleDisplayValue_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetComputedDoubleViewportValue_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Return the computed value in a specified coordinate system.
	/// </summary>
	public double[] GetComputedDoubleViewportValue(vtkViewport arg0)
	{
		IntPtr intPtr = vtkCoordinate_GetComputedDoubleViewportValue_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetComputedLocalDisplayValue_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Return the computed value in a specified coordinate system.
	/// </summary>
	public int[] GetComputedLocalDisplayValue(vtkViewport arg0)
	{
		IntPtr intPtr = vtkCoordinate_GetComputedLocalDisplayValue_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetComputedUserDefinedValue_05(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// GetComputedUserDefinedValue() is to be used only when
	/// the coordinate system is VTK_USERDEFINED. The user
	/// must subclass vtkCoordinate and override this function,
	/// when set as the TransformCoordinate in 2D-Mappers, the user
	/// can customize display of 2D polygons
	/// </summary>
	public virtual IntPtr GetComputedUserDefinedValue(vtkViewport arg0)
	{
		return vtkCoordinate_GetComputedUserDefinedValue_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetComputedValue_06(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// GetComputedValue() will return either World, Viewport or
	/// Display based on what has been set as the coordinate system.
	/// This is good for objects like vtkLineSource, where the
	/// user might want to use them as World or Viewport coordinates.
	/// </summary>
	public IntPtr GetComputedValue(vtkViewport arg0)
	{
		return vtkCoordinate_GetComputedValue_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetComputedViewportValue_07(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Return the computed value in a specified coordinate system.
	/// </summary>
	public int[] GetComputedViewportValue(vtkViewport arg0)
	{
		IntPtr intPtr = vtkCoordinate_GetComputedViewportValue_07(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetComputedWorldValue_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Return the computed value in a specified coordinate system.
	/// </summary>
	public double[] GetComputedWorldValue(vtkViewport arg0)
	{
		IntPtr intPtr = vtkCoordinate_GetComputedWorldValue_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinate_GetCoordinateSystem_09(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public virtual int GetCoordinateSystem()
	{
		return vtkCoordinate_GetCoordinateSystem_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetCoordinateSystemAsString_10(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public string GetCoordinateSystemAsString()
	{
		return Marshal.PtrToStringAnsi(vtkCoordinate_GetCoordinateSystemAsString_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCoordinate_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCoordinate_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCoordinate_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCoordinate_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetReferenceCoordinate_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If this coordinate is relative to another coordinate,
	/// then specify that coordinate as the ReferenceCoordinate.
	/// If this is NULL the coordinate is assumed to be absolute.
	/// </summary>
	public virtual vtkCoordinate GetReferenceCoordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinate_GetReferenceCoordinate_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetValue_14(HandleRef pThis);

	/// <summary>
	/// Set/get the value of this coordinate. This can be thought of as
	/// the position of this coordinate in its coordinate system.
	/// </summary>
	public virtual double[] GetValue()
	{
		IntPtr intPtr = vtkCoordinate_GetValue_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_GetValue_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get the value of this coordinate. This can be thought of as
	/// the position of this coordinate in its coordinate system.
	/// </summary>
	public virtual void GetValue(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCoordinate_GetValue_15(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_GetValue_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the value of this coordinate. This can be thought of as
	/// the position of this coordinate in its coordinate system.
	/// </summary>
	public virtual void GetValue(IntPtr _arg)
	{
		vtkCoordinate_GetValue_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_GetViewport_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If you want this coordinate to be relative to a specific
	/// vtkViewport (vtkRenderer) then you can specify that here.
	/// NOTE: this is a raw pointer, not a weak pointer nor a reference counted
	/// object, to avoid reference cycle loop between rendering classes and filter
	/// classes.
	/// </summary>
	public virtual vtkViewport GetViewport()
	{
		vtkViewport vtkViewport2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinate_GetViewport_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCoordinate_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCoordinate_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinate_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCoordinate_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCoordinate NewInstance()
	{
		vtkCoordinate result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinate_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinate_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCoordinate SafeDownCast(vtkObjectBase o)
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinate_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetCoordinateSystem_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public virtual void SetCoordinateSystem(int _arg)
	{
		vtkCoordinate_SetCoordinateSystem_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetCoordinateSystemToDisplay_24(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public void SetCoordinateSystemToDisplay()
	{
		vtkCoordinate_SetCoordinateSystemToDisplay_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetCoordinateSystemToNormalizedDisplay_25(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public void SetCoordinateSystemToNormalizedDisplay()
	{
		vtkCoordinate_SetCoordinateSystemToNormalizedDisplay_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetCoordinateSystemToNormalizedViewport_26(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public void SetCoordinateSystemToNormalizedViewport()
	{
		vtkCoordinate_SetCoordinateSystemToNormalizedViewport_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetCoordinateSystemToPose_27(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public void SetCoordinateSystemToPose()
	{
		vtkCoordinate_SetCoordinateSystemToPose_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetCoordinateSystemToView_28(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public void SetCoordinateSystemToView()
	{
		vtkCoordinate_SetCoordinateSystemToView_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetCoordinateSystemToViewport_29(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public void SetCoordinateSystemToViewport()
	{
		vtkCoordinate_SetCoordinateSystemToViewport_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetCoordinateSystemToWorld_30(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system which this coordinate
	/// is defined in. The options are Display, Normalized Display,
	/// Viewport, Normalized Viewport, View, and World.
	/// </summary>
	public void SetCoordinateSystemToWorld()
	{
		vtkCoordinate_SetCoordinateSystemToWorld_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetReferenceCoordinate_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// If this coordinate is relative to another coordinate,
	/// then specify that coordinate as the ReferenceCoordinate.
	/// If this is NULL the coordinate is assumed to be absolute.
	/// </summary>
	public virtual void SetReferenceCoordinate(vtkCoordinate arg0)
	{
		vtkCoordinate_SetReferenceCoordinate_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetValue_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get the value of this coordinate. This can be thought of as
	/// the position of this coordinate in its coordinate system.
	/// </summary>
	public virtual void SetValue(double _arg1, double _arg2, double _arg3)
	{
		vtkCoordinate_SetValue_32(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetValue_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the value of this coordinate. This can be thought of as
	/// the position of this coordinate in its coordinate system.
	/// </summary>
	public virtual void SetValue(IntPtr _arg)
	{
		vtkCoordinate_SetValue_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetValue_34(HandleRef pThis, double a, double b);

	/// <summary>
	/// Set/get the value of this coordinate. This can be thought of as
	/// the position of this coordinate in its coordinate system.
	/// </summary>
	public void SetValue(double a, double b)
	{
		vtkCoordinate_SetValue_34(GetCppThis(), a, b);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinate_SetViewport_35(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// If you want this coordinate to be relative to a specific
	/// vtkViewport (vtkRenderer) then you can specify that here.
	/// NOTE: this is a raw pointer, not a weak pointer nor a reference counted
	/// object, to avoid reference cycle loop between rendering classes and filter
	/// classes.
	/// </summary>
	public void SetViewport(vtkViewport viewport)
	{
		vtkCoordinate_SetViewport_35(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}
}
