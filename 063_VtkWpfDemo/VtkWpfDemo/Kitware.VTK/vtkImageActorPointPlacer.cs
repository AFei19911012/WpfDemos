using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageActorPointPlacer
/// </summary>
/// <remarks>
///    Converts 2D display positions to world positions such that they lie on an ImageActor
///
/// This PointPlacer is used to constrain the placement of points on the
/// supplied image actor. Additionally, you may set bounds to restrict the
/// placement of the points. The placement of points will then be constrained
/// to lie not only on the ImageActor but also within the bounds specified.
/// If no bounds are specified, they may lie anywhere on the supplied ImageActor.
/// </remarks>
public class vtkImageActorPointPlacer : vtkPointPlacer
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageActorPointPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageActorPointPlacer()
	{
		MRClassNameKey = "class vtkImageActorPointPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageActorPointPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageActorPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActorPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkImageActorPointPlacer New()
	{
		vtkImageActorPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageActorPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageActorPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkImageActorPointPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageActorPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageActorPointPlacer_ComputeWorldPosition_01(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given and renderer and a display position in pixels,
	/// find a world position and orientation. In this class
	/// an internal vtkBoundedPlanePointPlacer is used to compute
	/// the world position and orientation. The internal placer
	/// is set to use the plane of the image actor and the bounds
	/// of the image actor as the constraints for placing points.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkImageActorPointPlacer_ComputeWorldPosition_01(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActorPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// This method is identical to the one above since the
	/// reference position is ignored by the bounded plane
	/// point placer.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkImageActorPointPlacer_ComputeWorldPosition_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, refWorldPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActorPointPlacer_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Optionally, you may set bounds to restrict the placement of the points.
	/// The placement of points will then be constrained to lie not only on
	/// the ImageActor but also within the bounds specified. If no bounds are
	/// specified, they may lie anywhere on the supplied ImageActor.
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkImageActorPointPlacer_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActorPointPlacer_GetBounds_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Optionally, you may set bounds to restrict the placement of the points.
	/// The placement of points will then be constrained to lie not only on
	/// the ImageActor but also within the bounds specified. If no bounds are
	/// specified, they may lie anywhere on the supplied ImageActor.
	/// </summary>
	public virtual void GetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkImageActorPointPlacer_GetBounds_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActorPointPlacer_GetBounds_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Optionally, you may set bounds to restrict the placement of the points.
	/// The placement of points will then be constrained to lie not only on
	/// the ImageActor but also within the bounds specified. If no bounds are
	/// specified, they may lie anywhere on the supplied ImageActor.
	/// </summary>
	public virtual void GetBounds(IntPtr _arg)
	{
		vtkImageActorPointPlacer_GetBounds_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActorPointPlacer_GetImageActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get the reference vtkImageActor used to place the points.
	/// An image actor must be set for this placer to work. An internal
	/// bounded plane point placer is created and set to match the bounds
	/// of the displayed image.
	/// </summary>
	public virtual vtkImageActor GetImageActor()
	{
		vtkImageActor vtkImageActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageActorPointPlacer_GetImageActor_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkImageActorPointPlacer_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageActorPointPlacer_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageActorPointPlacer_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageActorPointPlacer_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActorPointPlacer_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageActorPointPlacer_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActorPointPlacer_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageActorPointPlacer_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActorPointPlacer_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkImageActorPointPlacer NewInstance()
	{
		vtkImageActorPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageActorPointPlacer_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageActorPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActorPointPlacer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkImageActorPointPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkImageActorPointPlacer vtkImageActorPointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageActorPointPlacer_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageActorPointPlacer2 = (vtkImageActorPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageActorPointPlacer2.Register(null);
			}
		}
		return vtkImageActorPointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActorPointPlacer_SetBounds_14(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Optionally, you may set bounds to restrict the placement of the points.
	/// The placement of points will then be constrained to lie not only on
	/// the ImageActor but also within the bounds specified. If no bounds are
	/// specified, they may lie anywhere on the supplied ImageActor.
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkImageActorPointPlacer_SetBounds_14(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActorPointPlacer_SetBounds_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Optionally, you may set bounds to restrict the placement of the points.
	/// The placement of points will then be constrained to lie not only on
	/// the ImageActor but also within the bounds specified. If no bounds are
	/// specified, they may lie anywhere on the supplied ImageActor.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkImageActorPointPlacer_SetBounds_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActorPointPlacer_SetImageActor_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get the reference vtkImageActor used to place the points.
	/// An image actor must be set for this placer to work. An internal
	/// bounded plane point placer is created and set to match the bounds
	/// of the displayed image.
	/// </summary>
	public void SetImageActor(vtkImageActor arg0)
	{
		vtkImageActorPointPlacer_SetImageActor_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActorPointPlacer_SetWorldTolerance_17(HandleRef pThis, double tol);

	/// <summary>
	/// Set the world tolerance. This propagates it to the internal
	/// BoundedPlanePointPlacer.
	/// </summary>
	public override void SetWorldTolerance(double tol)
	{
		vtkImageActorPointPlacer_SetWorldTolerance_17(GetCppThis(), tol);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActorPointPlacer_UpdateInternalState_18(HandleRef pThis);

	/// <summary>
	/// A method for configuring the internal placer according
	/// to the constraints of the image actor.
	/// Called by the representation to give the placer a chance
	/// to update itself, which may cause the MTime to change,
	/// which would then cause the representation to update
	/// all of its points
	/// </summary>
	public override int UpdateInternalState()
	{
		return vtkImageActorPointPlacer_UpdateInternalState_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActorPointPlacer_UpdateWorldPosition_19(HandleRef pThis, HandleRef ren, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Update the world position and orientation according the
	/// the current constraints of the placer. Will be called
	/// by the representation when it notices that this placer
	/// has been modified.
	/// </summary>
	public override int UpdateWorldPosition(vtkRenderer ren, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkImageActorPointPlacer_UpdateWorldPosition_19(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActorPointPlacer_ValidateWorldPosition_20(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// This method validates a world position by checking to see
	/// if the world position is valid according to the constraints
	/// of the internal placer (essentially - is this world position
	/// on the image?)
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos)
	{
		return vtkImageActorPointPlacer_ValidateWorldPosition_20(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActorPointPlacer_ValidateWorldPosition_21(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// This method is identical to the one above since the bounded
	/// plane point placer ignores orientation
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkImageActorPointPlacer_ValidateWorldPosition_21(GetCppThis(), worldPos, worldOrient);
	}
}
