using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointPlacer
/// </summary>
/// <remarks>
///    Abstract interface to translate 2D display positions to world coordinates
///
/// Most widgets in VTK have a need to translate of 2D display coordinates (as
/// reported by the RenderWindowInteractor) to 3D world coordinates. This class
/// is an abstraction of this functionality. A few subclasses are listed below:
/// &lt;p&gt;1) vtkFocalPlanePointPlacer: This class converts 2D display positions to
/// world positions such that they lie on the focal plane.
/// &lt;p&gt;2) vtkPolygonalSurfacePointPlacer: Converts 2D display positions to
/// world positions such that they lie on the surface of one or more specified
/// polydatas.
/// &lt;p&gt;3) vtkImageActorPointPlacer: Converts 2D display positions to world
/// positions such that they lie on an ImageActor
/// &lt;p&gt;4) vtkBoundedPlanePointPlacer: Converts 2D display positions to world
/// positions such that they lie within a set of specified bounding planes.
/// &lt;p&gt;5) vtkTerrainDataPointPlacer: Converts 2D display positions to world
/// positions such that they lie on a height field.
/// &lt;p&gt; Point placers provide an extensible framework to specify constraints on
/// points. The methods ComputeWorldPosition, ValidateDisplayPosition and
/// ValidateWorldPosition may be overridden to dictate whether a world or
/// display position is allowed. These classes are currently used by the
/// HandleWidget and the ContourWidget to allow various constraints to be
/// enforced on the placement of their handles.
/// </remarks>
public class vtkPointPlacer : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointPlacer()
	{
		MRClassNameKey = "class vtkPointPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkPointPlacer New()
	{
		vtkPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkPointPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPointPlacer_ComputeWorldPosition_01(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer and a display position in pixel coordinates,
	/// compute the world position and orientation where this point
	/// will be placed. This method is typically used by the
	/// representation to place the point initially. A return value of 1
	/// indicates that constraints of the placer are met.
	/// </summary>
	public virtual int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPointPlacer_ComputeWorldPosition_01(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer, a display position, and a reference world
	/// position, compute the new world position and orientation
	/// of this point. This method is typically used by the
	/// representation to move the point. A return value of 1 indicates that
	/// constraints of the placer are met.
	/// </summary>
	public virtual int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPointPlacer_ComputeWorldPosition_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, refWorldPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointPlacer_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointPlacer_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointPlacer_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointPlacer_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_GetPixelTolerance_05(HandleRef pThis);

	/// <summary>
	/// Set/get the tolerance used when performing computations
	/// in display coordinates.
	/// </summary>
	public virtual int GetPixelTolerance()
	{
		return vtkPointPlacer_GetPixelTolerance_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_GetPixelToleranceMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set/get the tolerance used when performing computations
	/// in display coordinates.
	/// </summary>
	public virtual int GetPixelToleranceMaxValue()
	{
		return vtkPointPlacer_GetPixelToleranceMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_GetPixelToleranceMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set/get the tolerance used when performing computations
	/// in display coordinates.
	/// </summary>
	public virtual int GetPixelToleranceMinValue()
	{
		return vtkPointPlacer_GetPixelToleranceMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointPlacer_GetWorldTolerance_08(HandleRef pThis);

	/// <summary>
	/// Set/get the tolerance used when performing computations
	/// in world coordinates.
	/// </summary>
	public virtual double GetWorldTolerance()
	{
		return vtkPointPlacer_GetWorldTolerance_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointPlacer_GetWorldToleranceMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set/get the tolerance used when performing computations
	/// in world coordinates.
	/// </summary>
	public virtual double GetWorldToleranceMaxValue()
	{
		return vtkPointPlacer_GetWorldToleranceMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointPlacer_GetWorldToleranceMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set/get the tolerance used when performing computations
	/// in world coordinates.
	/// </summary>
	public virtual double GetWorldToleranceMinValue()
	{
		return vtkPointPlacer_GetWorldToleranceMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_IsA_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointPlacer_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_IsTypeOf_12(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointPlacer_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointPlacer_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkPointPlacer NewInstance()
	{
		vtkPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointPlacer_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointPlacer_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkPointPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkPointPlacer vtkPointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointPlacer_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointPlacer2 = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointPlacer2.Register(null);
			}
		}
		return vtkPointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointPlacer_SetPixelTolerance_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the tolerance used when performing computations
	/// in display coordinates.
	/// </summary>
	public virtual void SetPixelTolerance(int _arg)
	{
		vtkPointPlacer_SetPixelTolerance_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointPlacer_SetWorldTolerance_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the tolerance used when performing computations
	/// in world coordinates.
	/// </summary>
	public virtual void SetWorldTolerance(double _arg)
	{
		vtkPointPlacer_SetWorldTolerance_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_UpdateInternalState_18(HandleRef pThis);

	/// <summary>
	/// Called by the representation to give the placer a chance
	/// to update itself.
	/// </summary>
	public virtual int UpdateInternalState()
	{
		return vtkPointPlacer_UpdateInternalState_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_UpdateNodeWorldPosition_19(HandleRef pThis, IntPtr worldPos, long nodePointId);

	/// <summary>
	/// Give the placer a chance to update the node information, if any. Most
	/// placers do not maintain any cached node information.
	/// vtkPolygonalSurfacePointPlacer is one that does. It stores the point
	/// id (id on the surface mesh) on which its drawn. The second argument
	/// may be used to pass that in.
	/// Update world position
	/// </summary>
	public virtual int UpdateNodeWorldPosition(IntPtr worldPos, long nodePointId)
	{
		return vtkPointPlacer_UpdateNodeWorldPosition_19(GetCppThis(), worldPos, nodePointId);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_UpdateWorldPosition_20(HandleRef pThis, HandleRef ren, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a current renderer, world position and orientation,
	/// update them according to the constraints of the placer.
	/// This method is typically used when UpdateContour is called
	/// on the representation, which must be called after changes
	/// are made to the constraints in the placer. A return
	/// value of 1 indicates that the point has been updated. A
	/// return value of 0 indicates that the point could not
	/// be updated and was left alone. By default this is a no-op -
	/// leaving the point as is.
	/// </summary>
	public virtual int UpdateWorldPosition(vtkRenderer ren, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPointPlacer_UpdateWorldPosition_20(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_ValidateDisplayPosition_21(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

	/// <summary>
	/// Given a display position, check the validity of this position.
	/// </summary>
	public virtual int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
	{
		return vtkPointPlacer_ValidateDisplayPosition_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), displayPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_ValidateWorldPosition_22(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// Given a world position check the validity of this
	/// position according to the constraints of the placer.
	/// </summary>
	public virtual int ValidateWorldPosition(IntPtr worldPos)
	{
		return vtkPointPlacer_ValidateWorldPosition_22(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointPlacer_ValidateWorldPosition_23(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a world position and a world orientation,
	/// validate it according to the constraints of the placer.
	/// </summary>
	public virtual int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPointPlacer_ValidateWorldPosition_23(GetCppThis(), worldPos, worldOrient);
	}
}
