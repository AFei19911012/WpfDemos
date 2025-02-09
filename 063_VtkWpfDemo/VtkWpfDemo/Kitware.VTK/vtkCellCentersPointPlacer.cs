using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellCentersPointPlacer
/// </summary>
/// <remarks>
///    Snaps points at the center of a cell
///
///
/// vtkCellCentersPointPlacer is a class to snap points on the center of cells.
/// The class has 3 modes. In the ParametricCenter mode, it snaps points
/// to the parametric center of the cell (see vtkCell). In CellPointsMean
/// mode, points are snapped to the mean of the points in the cell.
/// In 'None' mode, no snapping is performed. The computed world position
/// is the picked position within the cell.
///
/// @par Usage:
/// The actors that render data and wish to be considered for placement
/// by this placer are added to the list as
/// <code>
/// placer-&gt;AddProp( actor );
/// </code>
///
/// </remarks>
/// <seealso>
///
/// vtkPointPlacer
/// </seealso>
public class vtkCellCentersPointPlacer : vtkPointPlacer
{
	/// <summary>
	/// Modes to change the point placement. Parametric center picks
	/// the parametric center within the cell. CellPointsMean picks
	/// the average of all points in the cell. When the mode is None,
	/// the input point is passed through unmodified. Default is CellPointsMean.
	/// </summary>
	public enum CellPointsMean_WrapperEnum
	{
		/// <summary>enum member</summary>
		CellPointsMean = 1,
		/// <summary>enum member</summary>
		None = 2,
		/// <summary>enum member</summary>
		ParametricCenter = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellCentersPointPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellCentersPointPlacer()
	{
		MRClassNameKey = "class vtkCellCentersPointPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellCentersPointPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellCentersPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellCentersPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkCellCentersPointPlacer New()
	{
		vtkCellCentersPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellCentersPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellCentersPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkCellCentersPointPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellCentersPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCellCentersPointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public virtual void AddProp(vtkProp arg0)
	{
		vtkCellCentersPointPlacer_AddProp_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

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
		return vtkCellCentersPointPlacer_ComputeWorldPosition_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a renderer, a display position, and a reference world
	/// position, compute the new world position and orientation
	/// of this point. This method is typically used by the
	/// representation to move the point.
	/// </summary>
	public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkCellCentersPointPlacer_ComputeWorldPosition_03(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), displayPos, refWorldPos, worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellCentersPointPlacer_GetCellPicker_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the Prop picker.
	/// </summary>
	public virtual vtkCellPicker GetCellPicker()
	{
		vtkCellPicker vtkCellPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellCentersPointPlacer_GetCellPicker_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellPicker2 = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellPicker2.Register(null);
			}
		}
		return vtkCellPicker2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_GetMode_05(HandleRef pThis);

	/// <summary>
	/// Modes to change the point placement. Parametric center picks
	/// the parametric center within the cell. CellPointsMean picks
	/// the average of all points in the cell. When the mode is None,
	/// the input point is passed through unmodified. Default is CellPointsMean.
	/// </summary>
	public virtual int GetMode()
	{
		return vtkCellCentersPointPlacer_GetMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellCentersPointPlacer_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellCentersPointPlacer_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellCentersPointPlacer_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellCentersPointPlacer_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_GetNumberOfProps_08(HandleRef pThis);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public int GetNumberOfProps()
	{
		return vtkCellCentersPointPlacer_GetNumberOfProps_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_HasProp_09(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public int HasProp(vtkProp arg0)
	{
		return vtkCellCentersPointPlacer_HasProp_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellCentersPointPlacer_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellCentersPointPlacer_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellCentersPointPlacer_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkCellCentersPointPlacer NewInstance()
	{
		vtkCellCentersPointPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellCentersPointPlacer_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellCentersPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellCentersPointPlacer_RemoveAllProps_14(HandleRef pThis);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public virtual void RemoveAllProps()
	{
		vtkCellCentersPointPlacer_RemoveAllProps_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellCentersPointPlacer_RemoveViewProp_15(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public virtual void RemoveViewProp(vtkProp prop)
	{
		vtkCellCentersPointPlacer_RemoveViewProp_15(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellCentersPointPlacer_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkCellCentersPointPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkCellCentersPointPlacer vtkCellCentersPointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellCentersPointPlacer_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellCentersPointPlacer2 = (vtkCellCentersPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellCentersPointPlacer2.Register(null);
			}
		}
		return vtkCellCentersPointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellCentersPointPlacer_SetMode_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Modes to change the point placement. Parametric center picks
	/// the parametric center within the cell. CellPointsMean picks
	/// the average of all points in the cell. When the mode is None,
	/// the input point is passed through unmodified. Default is CellPointsMean.
	/// </summary>
	public virtual void SetMode(int _arg)
	{
		vtkCellCentersPointPlacer_SetMode_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_ValidateDisplayPosition_18(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

	/// <summary>
	/// Given a display position, check the validity of this position.
	/// </summary>
	public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
	{
		return vtkCellCentersPointPlacer_ValidateDisplayPosition_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), displayPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_ValidateWorldPosition_19(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// Given a world position check the validity of this
	/// position according to the constraints of the placer
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos)
	{
		return vtkCellCentersPointPlacer_ValidateWorldPosition_19(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellCentersPointPlacer_ValidateWorldPosition_20(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Given a world position and a world orientation,
	/// validate it according to the constraints of the placer.
	/// </summary>
	public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkCellCentersPointPlacer_ValidateWorldPosition_20(GetCppThis(), worldPos, worldOrient);
	}
}
