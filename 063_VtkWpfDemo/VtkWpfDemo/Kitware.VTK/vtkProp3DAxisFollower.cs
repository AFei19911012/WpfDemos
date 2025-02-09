using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProp3DAxisFollower
/// </summary>
/// <remarks>
///    a subclass of vtkProp3DFollower that ensures
/// that data is always parallel to the axis defined by a vtkAxisActor.
///
/// vtkProp3DAxisFollower is a subclass of vtkProp3DFollower that always follows
/// its specified axis. More specifically it will not change its position or
/// scale, but it will continually update its orientation so that it is aligned
/// with the axis and facing at angle to the camera to provide maximum visibility.
/// This is typically used for text labels for 3d plots.
/// </remarks>
/// <seealso>
///
/// vtkFollower vtkAxisFollower vtkProp3DFollower
/// </seealso>
public class vtkProp3DAxisFollower : vtkProp3DFollower
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProp3DAxisFollower";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProp3DAxisFollower()
	{
		MRClassNameKey = "class vtkProp3DAxisFollower";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3DAxisFollower"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProp3DAxisFollower(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DAxisFollower_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a follower with no camera set.
	/// </summary>
	public new static vtkProp3DAxisFollower New()
	{
		vtkProp3DAxisFollower result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DAxisFollower_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a follower with no camera set.
	/// </summary>
	public vtkProp3DAxisFollower()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProp3DAxisFollower_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_AutoCenterOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get state of auto center mode where additional
	/// translation will be added to make sure the underlying
	/// geometry has its pivot point at the center of its bounds.
	/// </summary>
	public virtual void AutoCenterOff()
	{
		vtkProp3DAxisFollower_AutoCenterOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_AutoCenterOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get state of auto center mode where additional
	/// translation will be added to make sure the underlying
	/// geometry has its pivot point at the center of its bounds.
	/// </summary>
	public virtual void AutoCenterOn()
	{
		vtkProp3DAxisFollower_AutoCenterOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp3DAxisFollower_AutoScale_03(HandleRef viewport, HandleRef camera, double screenSize, IntPtr position);

	/// <summary>
	/// Calculate scale factor to maintain same size of a object
	/// on the screen.
	/// </summary>
	public static double AutoScale(vtkViewport viewport, vtkCamera camera, double screenSize, IntPtr position)
	{
		return vtkProp3DAxisFollower_AutoScale_03(viewport?.GetCppThis() ?? default(HandleRef), camera?.GetCppThis() ?? default(HandleRef), screenSize, position);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_ComputeMatrix_04(HandleRef pThis);

	/// <summary>
	/// Generate the matrix based on ivars. This method overloads its superclasses
	/// ComputeMatrix() method due to the special vtkProp3DAxisFollower matrix operations.
	/// </summary>
	public override void ComputeMatrix()
	{
		vtkProp3DAxisFollower_ComputeMatrix_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DAxisFollower_GetAutoCenter_05(HandleRef pThis);

	/// <summary>
	/// Set/Get state of auto center mode where additional
	/// translation will be added to make sure the underlying
	/// geometry has its pivot point at the center of its bounds.
	/// </summary>
	public virtual int GetAutoCenter()
	{
		return vtkProp3DAxisFollower_GetAutoCenter_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DAxisFollower_GetAxis_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set axis that needs to be followed.
	/// </summary>
	public virtual vtkAxisActor GetAxis()
	{
		vtkAxisActor vtkAxisActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DAxisFollower_GetAxis_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisActor2 = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisActor2.Register(null);
			}
		}
		return vtkAxisActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp3DAxisFollower_GetDistanceLODThreshold_07(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
	/// of camera far clip range, actor is not visible.
	/// Default is 0.80.
	/// </summary>
	public virtual double GetDistanceLODThreshold()
	{
		return vtkProp3DAxisFollower_GetDistanceLODThreshold_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp3DAxisFollower_GetDistanceLODThresholdMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
	/// of camera far clip range, actor is not visible.
	/// Default is 0.80.
	/// </summary>
	public virtual double GetDistanceLODThresholdMaxValue()
	{
		return vtkProp3DAxisFollower_GetDistanceLODThresholdMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp3DAxisFollower_GetDistanceLODThresholdMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
	/// of camera far clip range, actor is not visible.
	/// Default is 0.80.
	/// </summary>
	public virtual double GetDistanceLODThresholdMinValue()
	{
		return vtkProp3DAxisFollower_GetDistanceLODThresholdMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DAxisFollower_GetEnableDistanceLOD_10(HandleRef pThis);

	/// <summary>
	/// Enable / disable use of distance based LOD. If enabled the actor
	/// will not be visible at a certain distance from the camera.
	/// Default is false.
	/// </summary>
	public virtual int GetEnableDistanceLOD()
	{
		return vtkProp3DAxisFollower_GetEnableDistanceLOD_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DAxisFollower_GetEnableViewAngleLOD_11(HandleRef pThis);

	/// <summary>
	/// Enable / disable use of view angle based LOD. If enabled the actor
	/// will not be visible at a certain view angle.
	/// Default is true.
	/// </summary>
	public virtual int GetEnableViewAngleLOD()
	{
		return vtkProp3DAxisFollower_GetEnableViewAngleLOD_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp3DAxisFollower_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProp3DAxisFollower_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp3DAxisFollower_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProp3DAxisFollower_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp3DAxisFollower_GetScreenOffset_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired screen vertical offset from the axis.
	/// Convenience method, using a zero horizontal offset
	/// </summary>
	public double GetScreenOffset()
	{
		return vtkProp3DAxisFollower_GetScreenOffset_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DAxisFollower_GetScreenOffsetVector_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// </summary>
	public virtual double[] GetScreenOffsetVector()
	{
		IntPtr intPtr = vtkProp3DAxisFollower_GetScreenOffsetVector_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_GetScreenOffsetVector_16(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// </summary>
	public virtual void GetScreenOffsetVector(ref double _arg1, ref double _arg2)
	{
		vtkProp3DAxisFollower_GetScreenOffsetVector_16(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_GetScreenOffsetVector_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// </summary>
	public virtual void GetScreenOffsetVector(IntPtr _arg)
	{
		vtkProp3DAxisFollower_GetScreenOffsetVector_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp3DAxisFollower_GetViewAngleLODThreshold_18(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
	/// angle to geometry will make the geometry not visible.
	/// Default is 0.34.
	/// </summary>
	public virtual double GetViewAngleLODThreshold()
	{
		return vtkProp3DAxisFollower_GetViewAngleLODThreshold_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp3DAxisFollower_GetViewAngleLODThresholdMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
	/// angle to geometry will make the geometry not visible.
	/// Default is 0.34.
	/// </summary>
	public virtual double GetViewAngleLODThresholdMaxValue()
	{
		return vtkProp3DAxisFollower_GetViewAngleLODThresholdMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp3DAxisFollower_GetViewAngleLODThresholdMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
	/// angle to geometry will make the geometry not visible.
	/// Default is 0.34.
	/// </summary>
	public virtual double GetViewAngleLODThresholdMinValue()
	{
		return vtkProp3DAxisFollower_GetViewAngleLODThresholdMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DAxisFollower_GetViewport_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically.
	/// </summary>
	public virtual vtkViewport GetViewport()
	{
		vtkViewport vtkViewport2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DAxisFollower_GetViewport_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DAxisFollower_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProp3DAxisFollower_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DAxisFollower_IsTypeOf_23(string type);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProp3DAxisFollower_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DAxisFollower_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public new vtkProp3DAxisFollower NewInstance()
	{
		vtkProp3DAxisFollower result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DAxisFollower_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DAxisFollower_RenderOpaqueGeometry_26(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkProp3DAxisFollower_RenderOpaqueGeometry_26(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DAxisFollower_RenderTranslucentPolygonalGeometry_27(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkProp3DAxisFollower_RenderTranslucentPolygonalGeometry_27(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DAxisFollower_RenderVolumetricGeometry_28(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically.
	/// </summary>
	public override int RenderVolumetricGeometry(vtkViewport viewport)
	{
		return vtkProp3DAxisFollower_RenderVolumetricGeometry_28(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DAxisFollower_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public new static vtkProp3DAxisFollower SafeDownCast(vtkObjectBase o)
	{
		vtkProp3DAxisFollower vtkProp3DAxisFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DAxisFollower_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3DAxisFollower2 = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3DAxisFollower2.Register(null);
			}
		}
		return vtkProp3DAxisFollower2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetAutoCenter_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get state of auto center mode where additional
	/// translation will be added to make sure the underlying
	/// geometry has its pivot point at the center of its bounds.
	/// </summary>
	public virtual void SetAutoCenter(int _arg)
	{
		vtkProp3DAxisFollower_SetAutoCenter_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetAxis_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set axis that needs to be followed.
	/// </summary>
	public virtual void SetAxis(vtkAxisActor arg0)
	{
		vtkProp3DAxisFollower_SetAxis_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetDistanceLODThreshold_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
	/// of camera far clip range, actor is not visible.
	/// Default is 0.80.
	/// </summary>
	public virtual void SetDistanceLODThreshold(double _arg)
	{
		vtkProp3DAxisFollower_SetDistanceLODThreshold_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetEnableDistanceLOD_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable / disable use of distance based LOD. If enabled the actor
	/// will not be visible at a certain distance from the camera.
	/// Default is false.
	/// </summary>
	public virtual void SetEnableDistanceLOD(int _arg)
	{
		vtkProp3DAxisFollower_SetEnableDistanceLOD_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetEnableViewAngleLOD_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable / disable use of view angle based LOD. If enabled the actor
	/// will not be visible at a certain view angle.
	/// Default is true.
	/// </summary>
	public virtual void SetEnableViewAngleLOD(int _arg)
	{
		vtkProp3DAxisFollower_SetEnableViewAngleLOD_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetScreenOffset_35(HandleRef pThis, double offset);

	/// <summary>
	/// Set/Get the desired screen vertical offset from the axis.
	/// Convenience method, using a zero horizontal offset
	/// </summary>
	public void SetScreenOffset(double offset)
	{
		vtkProp3DAxisFollower_SetScreenOffset_35(GetCppThis(), offset);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetScreenOffsetVector_36(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// </summary>
	public virtual void SetScreenOffsetVector(double _arg1, double _arg2)
	{
		vtkProp3DAxisFollower_SetScreenOffsetVector_36(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetScreenOffsetVector_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// </summary>
	public void SetScreenOffsetVector(IntPtr _arg)
	{
		vtkProp3DAxisFollower_SetScreenOffsetVector_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetViewAngleLODThreshold_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
	/// angle to geometry will make the geometry not visible.
	/// Default is 0.34.
	/// </summary>
	public virtual void SetViewAngleLODThreshold(double _arg)
	{
		vtkProp3DAxisFollower_SetViewAngleLODThreshold_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_SetViewport_39(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically.
	/// </summary>
	public virtual void SetViewport(vtkViewport viewport)
	{
		vtkProp3DAxisFollower_SetViewport_39(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DAxisFollower_ShallowCopy_40(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of a follower. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkProp3DAxisFollower_ShallowCopy_40(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
