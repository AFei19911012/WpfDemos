using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// Instantiate this class.
/// </summary>
public class vtkFocalPlanePointPlacer : vtkPointPlacer
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFocalPlanePointPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFocalPlanePointPlacer()
	{
		MRClassNameKey = "class vtkFocalPlanePointPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFocalPlanePointPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFocalPlanePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFocalPlanePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkFocalPlanePointPlacer New()
	{
		vtkFocalPlanePointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFocalPlanePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFocalPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkFocalPlanePointPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFocalPlanePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkFocalPlanePointPlacer_ComputeWorldPosition_01(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkFocalPlanePointPlacer_ComputeWorldPosition_01(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlanePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer, a display position, and a reference
	/// world position, compute a new world position. The
	/// orientation will be the standard coordinate axes, and the
	/// computed world position will be created by projecting
	/// the display point onto a plane that is parallel to
	/// the focal plane and runs through the reference world
	/// position. This method is typically used to move existing
	/// points.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkFocalPlanePointPlacer_ComputeWorldPosition_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, refWorldPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFocalPlanePointPlacer_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFocalPlanePointPlacer_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFocalPlanePointPlacer_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFocalPlanePointPlacer_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFocalPlanePointPlacer_GetOffset_05(HandleRef pThis);

	/// <summary>
	/// Optionally specify a signed offset from the focal plane for the points to
	/// be placed at.  If negative, the constraint plane is offset closer to the
	/// camera. If positive, its further away from the camera.
	/// </summary>
	public virtual double GetOffset()
	{
		return vtkFocalPlanePointPlacer_GetOffset_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFocalPlanePointPlacer_GetPointBounds_06(HandleRef pThis);

	/// <summary>
	/// Optionally Restrict the points to a set of bounds. The placer will
	/// invalidate points outside these bounds.
	/// </summary>
	public virtual double[] GetPointBounds()
	{
		IntPtr intPtr = vtkFocalPlanePointPlacer_GetPointBounds_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFocalPlanePointPlacer_GetPointBounds_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Optionally Restrict the points to a set of bounds. The placer will
	/// invalidate points outside these bounds.
	/// </summary>
	public virtual void GetPointBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkFocalPlanePointPlacer_GetPointBounds_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFocalPlanePointPlacer_GetPointBounds_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Optionally Restrict the points to a set of bounds. The placer will
	/// invalidate points outside these bounds.
	/// </summary>
	public virtual void GetPointBounds(IntPtr _arg)
	{
		vtkFocalPlanePointPlacer_GetPointBounds_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlanePointPlacer_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFocalPlanePointPlacer_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlanePointPlacer_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFocalPlanePointPlacer_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFocalPlanePointPlacer_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkFocalPlanePointPlacer NewInstance()
	{
		vtkFocalPlanePointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFocalPlanePointPlacer_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFocalPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFocalPlanePointPlacer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkFocalPlanePointPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkFocalPlanePointPlacer vtkFocalPlanePointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFocalPlanePointPlacer_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFocalPlanePointPlacer2 = (vtkFocalPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFocalPlanePointPlacer2.Register(null);
			}
		}
		return vtkFocalPlanePointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFocalPlanePointPlacer_SetOffset_14(HandleRef pThis, double _arg);

	/// <summary>
	/// Optionally specify a signed offset from the focal plane for the points to
	/// be placed at.  If negative, the constraint plane is offset closer to the
	/// camera. If positive, its further away from the camera.
	/// </summary>
	public virtual void SetOffset(double _arg)
	{
		vtkFocalPlanePointPlacer_SetOffset_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFocalPlanePointPlacer_SetPointBounds_15(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Optionally Restrict the points to a set of bounds. The placer will
	/// invalidate points outside these bounds.
	/// </summary>
	public virtual void SetPointBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkFocalPlanePointPlacer_SetPointBounds_15(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFocalPlanePointPlacer_SetPointBounds_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Optionally Restrict the points to a set of bounds. The placer will
	/// invalidate points outside these bounds.
	/// </summary>
	public virtual void SetPointBounds(IntPtr _arg)
	{
		vtkFocalPlanePointPlacer_SetPointBounds_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlanePointPlacer_ValidateWorldPosition_17(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// Validate a world position. All world positions
	/// are valid so these methods always return 1.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos)
	{
		return vtkFocalPlanePointPlacer_ValidateWorldPosition_17(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFocalPlanePointPlacer_ValidateWorldPosition_18(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Validate a world position. All world positions
	/// are valid so these methods always return 1.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkFocalPlanePointPlacer_ValidateWorldPosition_18(GetCppThis(), worldPos, worldOrient);
	}
}
