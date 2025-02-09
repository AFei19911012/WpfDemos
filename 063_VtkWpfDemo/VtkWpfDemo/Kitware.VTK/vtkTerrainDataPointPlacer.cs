using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTerrainDataPointPlacer
/// </summary>
/// <remarks>
///    Place points on terrain data
///
///
/// vtkTerrainDataPointPlacer dictates the placement of points on height field
/// data. The class takes as input the list of props that represent the terrain
/// in a rendered scene. A height offset can be specified to dicatate the
/// placement of points at a certain height above the surface.
///
/// @par Usage:
/// A typical usage of this class is as follows:
/// <code>
/// pointPlacer-&gt;AddProp(demActor);    // the actor(s) containing the terrain.
/// rep-&gt;SetPointPlacer(pointPlacer);
/// pointPlacer-&gt;SetHeightOffset( 100 );
/// </code>
///
/// </remarks>
/// <seealso>
///
/// vtkPointPlacer vtkTerrainContourLineInterpolator
/// </seealso>
public class vtkTerrainDataPointPlacer : vtkPointPlacer
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTerrainDataPointPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTerrainDataPointPlacer()
	{
		MRClassNameKey = "class vtkTerrainDataPointPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTerrainDataPointPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTerrainDataPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTerrainDataPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkTerrainDataPointPlacer New()
	{
		vtkTerrainDataPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTerrainDataPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTerrainDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkTerrainDataPointPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTerrainDataPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTerrainDataPointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public virtual void AddProp(vtkProp arg0)
	{
		vtkTerrainDataPointPlacer_AddProp_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainDataPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

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
		return vtkTerrainDataPointPlacer_ComputeWorldPosition_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainDataPointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer, a display position, and a reference world
	/// position, compute the new world position and orientation
	/// of this point. This method is typically used by the
	/// representation to move the point.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkTerrainDataPointPlacer_ComputeWorldPosition_03(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, refWorldPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTerrainDataPointPlacer_GetHeightOffset_04(HandleRef pThis);

	/// <summary>
	/// This is the height above (or below) the terrain that the dictated
	/// point should be placed. Positive values indicate distances above the
	/// terrain; negative values indicate distances below the terrain. The
	/// default is 0.0.
	/// </summary>
	public virtual double GetHeightOffset()
	{
		return vtkTerrainDataPointPlacer_GetHeightOffset_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTerrainDataPointPlacer_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTerrainDataPointPlacer_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTerrainDataPointPlacer_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTerrainDataPointPlacer_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTerrainDataPointPlacer_GetPropPicker_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the Prop picker.
	/// </summary>
	public virtual vtkPropPicker GetPropPicker()
	{
		vtkPropPicker vtkPropPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTerrainDataPointPlacer_GetPropPicker_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTerrainDataPointPlacer_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTerrainDataPointPlacer_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainDataPointPlacer_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTerrainDataPointPlacer_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTerrainDataPointPlacer_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkTerrainDataPointPlacer NewInstance()
	{
		vtkTerrainDataPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTerrainDataPointPlacer_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTerrainDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTerrainDataPointPlacer_RemoveAllProps_12(HandleRef pThis);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public virtual void RemoveAllProps()
	{
		vtkTerrainDataPointPlacer_RemoveAllProps_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTerrainDataPointPlacer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkTerrainDataPointPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkTerrainDataPointPlacer vtkTerrainDataPointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTerrainDataPointPlacer_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTerrainDataPointPlacer2 = (vtkTerrainDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTerrainDataPointPlacer2.Register(null);
			}
		}
		return vtkTerrainDataPointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTerrainDataPointPlacer_SetHeightOffset_14(HandleRef pThis, double _arg);

	/// <summary>
	/// This is the height above (or below) the terrain that the dictated
	/// point should be placed. Positive values indicate distances above the
	/// terrain; negative values indicate distances below the terrain. The
	/// default is 0.0.
	/// </summary>
	public virtual void SetHeightOffset(double _arg)
	{
		vtkTerrainDataPointPlacer_SetHeightOffset_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainDataPointPlacer_ValidateDisplayPosition_15(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

	/// <summary>
	/// Given a display position, check the validity of this position.
	/// </summary>
	public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
	{
		return vtkTerrainDataPointPlacer_ValidateDisplayPosition_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), displayPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainDataPointPlacer_ValidateWorldPosition_16(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// Given a world position check the validity of this
	/// position according to the constraints of the placer
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos)
	{
		return vtkTerrainDataPointPlacer_ValidateWorldPosition_16(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTerrainDataPointPlacer_ValidateWorldPosition_17(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a world position and a world orientation,
	/// validate it according to the constraints of the placer.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkTerrainDataPointPlacer_ValidateWorldPosition_17(GetCppThis(), worldPos, worldOrient);
	}
}
