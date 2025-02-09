using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAxisFollower
/// </summary>
/// <remarks>
///    a subclass of vtkFollower that ensures that
/// data is always parallel to the axis defined by a vtkAxisActor.
///
/// vtkAxisFollower is a subclass of vtkFollower that always follows its
/// specified axis. More specifically it will not change its position or scale,
/// but it will continually update its orientation so that it is aligned with
/// the axis and facing at angle to the camera to provide maximum visibility.
/// This is typically used for text labels for 3d plots.
/// </remarks>
/// <seealso>
///
/// vtkActor vtkFollower vtkCamera vtkAxisActor vtkCubeAxesActor
/// </seealso>
public class vtkAxisFollower : vtkFollower
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAxisFollower";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAxisFollower()
	{
		MRClassNameKey = "class vtkAxisFollower";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisFollower"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAxisFollower(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisFollower_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a follower with no camera set
	/// </summary>
	public new static vtkAxisFollower New()
	{
		vtkAxisFollower result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisFollower_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a follower with no camera set
	/// </summary>
	public vtkAxisFollower()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAxisFollower_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAxisFollower_AutoCenterOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get state of auto center mode where additional
	/// translation will be added to make sure the underlying
	/// geometry has its pivot point at the center of its bounds.
	/// </summary>
	public virtual void AutoCenterOff()
	{
		vtkAxisFollower_AutoCenterOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_AutoCenterOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get state of auto center mode where additional
	/// translation will be added to make sure the underlying
	/// geometry has its pivot point at the center of its bounds.
	/// </summary>
	public virtual void AutoCenterOn()
	{
		vtkAxisFollower_AutoCenterOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisFollower_AutoScale_03(HandleRef viewport, HandleRef camera, double screenSize, IntPtr position);

	/// <summary>
	/// Calculate scale factor to maintain same size of a object
	/// on the screen.
	/// </summary>
	public static double AutoScale(vtkViewport viewport, vtkCamera camera, double screenSize, IntPtr position)
	{
		return vtkAxisFollower_AutoScale_03(viewport?.GetCppThis() ?? default(HandleRef), camera?.GetCppThis() ?? default(HandleRef), screenSize, position);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_ComputeMatrix_04(HandleRef pThis);

	/// <summary>
	/// Overridden to disable this function, and use ComputeTransformMatrix instead, as
	/// we need a renderer to compute the transform matrix
	/// </summary>
	public override void ComputeMatrix()
	{
		vtkAxisFollower_ComputeMatrix_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_ComputeTransformMatrix_05(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Generate the matrix based on ivars. This method overloads its superclasses
	/// ComputeMatrix() method due to the special vtkFollower matrix operations.
	/// </summary>
	public virtual void ComputeTransformMatrix(vtkRenderer ren)
	{
		vtkAxisFollower_ComputeTransformMatrix_05(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisFollower_GetAutoCenter_06(HandleRef pThis);

	/// <summary>
	/// Set/Get state of auto center mode where additional
	/// translation will be added to make sure the underlying
	/// geometry has its pivot point at the center of its bounds.
	/// </summary>
	public virtual int GetAutoCenter()
	{
		return vtkAxisFollower_GetAutoCenter_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisFollower_GetAxis_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set axis that needs to be followed.
	/// </summary>
	public virtual vtkAxisActor GetAxis()
	{
		vtkAxisActor vtkAxisActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisFollower_GetAxis_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkAxisFollower_GetDistanceLODThreshold_08(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
	/// of camera far clip range, actor is not visible.
	/// Default is 0.80.
	/// </summary>
	public virtual double GetDistanceLODThreshold()
	{
		return vtkAxisFollower_GetDistanceLODThreshold_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisFollower_GetDistanceLODThresholdMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
	/// of camera far clip range, actor is not visible.
	/// Default is 0.80.
	/// </summary>
	public virtual double GetDistanceLODThresholdMaxValue()
	{
		return vtkAxisFollower_GetDistanceLODThresholdMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisFollower_GetDistanceLODThresholdMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
	/// of camera far clip range, actor is not visible.
	/// Default is 0.80.
	/// </summary>
	public virtual double GetDistanceLODThresholdMinValue()
	{
		return vtkAxisFollower_GetDistanceLODThresholdMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisFollower_GetEnableDistanceLOD_11(HandleRef pThis);

	/// <summary>
	/// Enable / disable use of distance based LOD. If enabled the actor
	/// will not be visible at a certain distance from the camera.
	/// Default is false.
	/// </summary>
	public virtual int GetEnableDistanceLOD()
	{
		return vtkAxisFollower_GetEnableDistanceLOD_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisFollower_GetEnableViewAngleLOD_12(HandleRef pThis);

	/// <summary>
	/// Enable / disable use of view angle based LOD. If enabled the actor
	/// will not be visible at a certain view angle.
	/// Default is true.
	/// </summary>
	public virtual int GetEnableViewAngleLOD()
	{
		return vtkAxisFollower_GetEnableViewAngleLOD_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxisFollower_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAxisFollower_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAxisFollower_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAxisFollower_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisFollower_GetScreenOffset_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// Convenience method, using a zero horizontal offset
	/// </summary>
	public double GetScreenOffset()
	{
		return vtkAxisFollower_GetScreenOffset_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisFollower_GetScreenOffsetVector_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// first component is horizontal, second is vertical.
	/// </summary>
	public virtual double[] GetScreenOffsetVector()
	{
		IntPtr intPtr = vtkAxisFollower_GetScreenOffsetVector_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_GetScreenOffsetVector_17(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// first component is horizontal, second is vertical.
	/// </summary>
	public virtual void GetScreenOffsetVector(ref double _arg1, ref double _arg2)
	{
		vtkAxisFollower_GetScreenOffsetVector_17(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_GetScreenOffsetVector_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// first component is horizontal, second is vertical.
	/// </summary>
	public virtual void GetScreenOffsetVector(IntPtr _arg)
	{
		vtkAxisFollower_GetScreenOffsetVector_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisFollower_GetViewAngleLODThreshold_19(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
	/// angle to geometry will make the geometry not visible.
	/// Default is 0.34.
	/// </summary>
	public virtual double GetViewAngleLODThreshold()
	{
		return vtkAxisFollower_GetViewAngleLODThreshold_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisFollower_GetViewAngleLODThresholdMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
	/// angle to geometry will make the geometry not visible.
	/// Default is 0.34.
	/// </summary>
	public virtual double GetViewAngleLODThresholdMaxValue()
	{
		return vtkAxisFollower_GetViewAngleLODThresholdMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAxisFollower_GetViewAngleLODThresholdMinValue_21(HandleRef pThis);

	/// <summary>
	/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
	/// angle to geometry will make the geometry not visible.
	/// Default is 0.34.
	/// </summary>
	public virtual double GetViewAngleLODThresholdMinValue()
	{
		return vtkAxisFollower_GetViewAngleLODThresholdMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisFollower_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAxisFollower_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAxisFollower_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAxisFollower_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisFollower_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAxisFollower NewInstance()
	{
		vtkAxisFollower result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisFollower_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_Render_26(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically.
	/// </summary>
	public override void Render(vtkRenderer ren)
	{
		vtkAxisFollower_Render_26(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAxisFollower_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAxisFollower SafeDownCast(vtkObjectBase o)
	{
		vtkAxisFollower vtkAxisFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAxisFollower_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisFollower2 = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisFollower2.Register(null);
			}
		}
		return vtkAxisFollower2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_SetAutoCenter_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get state of auto center mode where additional
	/// translation will be added to make sure the underlying
	/// geometry has its pivot point at the center of its bounds.
	/// </summary>
	public virtual void SetAutoCenter(int _arg)
	{
		vtkAxisFollower_SetAutoCenter_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_SetAxis_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set axis that needs to be followed.
	/// </summary>
	public virtual void SetAxis(vtkAxisActor arg0)
	{
		vtkAxisFollower_SetAxis_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_SetDistanceLODThreshold_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
	/// of camera far clip range, actor is not visible.
	/// Default is 0.80.
	/// </summary>
	public virtual void SetDistanceLODThreshold(double _arg)
	{
		vtkAxisFollower_SetDistanceLODThreshold_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_SetEnableDistanceLOD_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable / disable use of distance based LOD. If enabled the actor
	/// will not be visible at a certain distance from the camera.
	/// Default is false.
	/// </summary>
	public virtual void SetEnableDistanceLOD(int _arg)
	{
		vtkAxisFollower_SetEnableDistanceLOD_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_SetEnableViewAngleLOD_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable / disable use of view angle based LOD. If enabled the actor
	/// will not be visible at a certain view angle.
	/// Default is true.
	/// </summary>
	public virtual void SetEnableViewAngleLOD(int _arg)
	{
		vtkAxisFollower_SetEnableViewAngleLOD_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_SetScreenOffset_33(HandleRef pThis, double offset);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// Convenience method, using a zero horizontal offset
	/// </summary>
	public void SetScreenOffset(double offset)
	{
		vtkAxisFollower_SetScreenOffset_33(GetCppThis(), offset);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_SetScreenOffsetVector_34(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// first component is horizontal, second is vertical.
	/// </summary>
	public virtual void SetScreenOffsetVector(double _arg1, double _arg2)
	{
		vtkAxisFollower_SetScreenOffsetVector_34(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_SetScreenOffsetVector_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the desired screen offset from the axis.
	/// first component is horizontal, second is vertical.
	/// </summary>
	public void SetScreenOffsetVector(IntPtr _arg)
	{
		vtkAxisFollower_SetScreenOffsetVector_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_SetViewAngleLODThreshold_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
	/// angle to geometry will make the geometry not visible.
	/// Default is 0.34.
	/// </summary>
	public virtual void SetViewAngleLODThreshold(double _arg)
	{
		vtkAxisFollower_SetViewAngleLODThreshold_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAxisFollower_ShallowCopy_37(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of a follower. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkAxisFollower_ShallowCopy_37(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
