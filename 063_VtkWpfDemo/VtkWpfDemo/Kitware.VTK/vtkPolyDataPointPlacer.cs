using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataPointPlacer
/// </summary>
/// <remarks>
///    Base class to place points given constraints on polygonal data
///
///
/// vtkPolyDataPointPlacer is a base class to place points on the surface of
/// polygonal data.
///
/// @par Usage:
/// The actors that render polygonal data and wish to be considered
/// for placement by this placer are added to the list as
/// <code>
/// placer-&gt;AddProp( polyDataActor );
/// </code>
///
/// </remarks>
/// <seealso>
///
/// vtkPolygonalSurfacePointPlacer
/// </seealso>
public class vtkPolyDataPointPlacer : vtkPointPlacer
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPointPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataPointPlacer()
	{
		MRClassNameKey = "class vtkPolyDataPointPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPointPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkPolyDataPointPlacer New()
	{
		vtkPolyDataPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkPolyDataPointPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPolyDataPointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public virtual void AddProp(vtkProp arg0)
	{
		vtkPolyDataPointPlacer_AddProp_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer and a display position in pixel coordinates,
	/// compute the world position and orientation where this point
	/// will be placed. This method is typically used by the
	/// representation to place the point initially.
	/// For the Terrain point placer this computes world points that
	/// lie at the specified height above the terrain.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPolyDataPointPlacer_ComputeWorldPosition_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer, a display position, and a reference world
	/// position, compute the new world position and orientation
	/// of this point. This method is typically used by the
	/// representation to move the point.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPolyDataPointPlacer_ComputeWorldPosition_03(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, refWorldPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataPointPlacer_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataPointPlacer_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataPointPlacer_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataPointPlacer_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointPlacer_GetNumberOfProps_06(HandleRef pThis);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public int GetNumberOfProps()
	{
		return vtkPolyDataPointPlacer_GetNumberOfProps_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPointPlacer_GetPropPicker_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the Prop picker.
	/// </summary>
	public virtual vtkPropPicker GetPropPicker()
	{
		vtkPropPicker vtkPropPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPointPlacer_GetPropPicker_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPropPicker2 = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPropPicker2.Register(null);
			}
		}
		return vtkPropPicker2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointPlacer_HasProp_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public int HasProp(vtkProp arg0)
	{
		return vtkPolyDataPointPlacer_HasProp_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointPlacer_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataPointPlacer_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointPlacer_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataPointPlacer_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPointPlacer_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkPolyDataPointPlacer NewInstance()
	{
		vtkPolyDataPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPointPlacer_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointPlacer_RemoveAllProps_13(HandleRef pThis);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public virtual void RemoveAllProps()
	{
		vtkPolyDataPointPlacer_RemoveAllProps_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointPlacer_RemoveViewProp_14(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public virtual void RemoveViewProp(vtkProp prop)
	{
		vtkPolyDataPointPlacer_RemoveViewProp_14(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPointPlacer_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkPolyDataPointPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataPointPlacer vtkPolyDataPointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPointPlacer_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataPointPlacer2 = (vtkPolyDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataPointPlacer2.Register(null);
			}
		}
		return vtkPolyDataPointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointPlacer_ValidateDisplayPosition_16(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

	/// <summary>
	/// Given a display position, check the validity of this position.
	/// </summary>
	public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
	{
		return vtkPolyDataPointPlacer_ValidateDisplayPosition_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), displayPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointPlacer_ValidateWorldPosition_17(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// Given a world position check the validity of this
	/// position according to the constraints of the placer
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos)
	{
		return vtkPolyDataPointPlacer_ValidateWorldPosition_17(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointPlacer_ValidateWorldPosition_18(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a world position and a world orientation,
	/// validate it according to the constraints of the placer.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkPolyDataPointPlacer_ValidateWorldPosition_18(GetCppThis(), worldPos, worldOrient);
	}
}
