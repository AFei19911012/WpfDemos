using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractPicker
/// </summary>
/// <remarks>
///    define API for picking subclasses
///
/// vtkAbstractPicker is an abstract superclass that defines a minimal API
/// for its concrete subclasses. The minimum functionality of a picker is
/// to return the x-y-z global coordinate position of a pick (the pick
/// itself is defined in display coordinates).
///
/// The API to this class is to invoke the Pick() method with a selection
/// point (in display coordinates - pixels) and a renderer. Then get the
/// resulting pick position in global coordinates with the GetPickPosition()
/// method.
///
/// vtkPicker fires events during the picking process.  These
/// events are StartPickEvent, PickEvent, and EndPickEvent which are
/// invoked prior to picking, when something is picked, and after all picking
/// candidates have been tested. Note that during the pick process the
/// PickEvent of vtkProp (and its subclasses such as vtkActor) is fired
/// prior to the PickEvent of vtkPicker.
///
/// @warning
/// vtkAbstractPicker and its subclasses will not pick props that are
/// "unpickable" (see vtkProp) or are fully transparent (if transparency
/// is a property of the vtkProp).
///
/// @warning
/// There are two classes of pickers: those that pick using geometric methods
/// (typically a ray cast); and those that use rendering hardware. Geometric
/// methods return more information but are slower. Hardware methods are much
/// faster and return minimal information. Examples of geometric pickers
/// include vtkPicker, vtkCellPicker, and vtkPointPicker. Examples of hardware
/// pickers include vtkWorldPointPicker and vtkPropPicker.
///
/// </remarks>
/// <seealso>
///
/// vtkPropPicker uses hardware acceleration to pick an instance of vtkProp.
/// (This means that 2D and 3D props can be picked, and it's relatively fast.)
/// If you need to pick cells or points, you might wish to use vtkCellPicker
/// or vtkPointPicker. vtkWorldPointPicker is the fastest picker, returning
/// an x-y-z coordinate value using the hardware z-buffer. vtkPicker can be
/// used to pick the bounding box of 3D props.
/// </seealso>
public abstract class vtkAbstractPicker : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractPicker()
	{
		MRClassNameKey = "class vtkAbstractPicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkAbstractPicker_AddPickList_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add an actor to the pick list.
	/// </summary>
	public void AddPickList(vtkProp arg0)
	{
		vtkAbstractPicker_AddPickList_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPicker_DeletePickList_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Delete an actor from the pick list.
	/// </summary>
	public void DeletePickList(vtkProp arg0)
	{
		vtkAbstractPicker_DeletePickList_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPicker_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractPicker_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPicker_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractPicker_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPicker_GetPickFromList_05(HandleRef pThis);

	/// <summary>
	/// Use these methods to control whether to limit the picking to this list
	/// (rather than renderer's actors). Make sure that the pick list contains
	/// actors that referred to by the picker's renderer.
	/// </summary>
	public virtual int GetPickFromList()
	{
		return vtkAbstractPicker_GetPickFromList_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPicker_GetPickList_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the list of actors in the PickList.
	/// </summary>
	public vtkPropCollection GetPickList()
	{
		vtkPropCollection vtkPropCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPicker_GetPickList_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAbstractPicker_GetPickPosition_07(HandleRef pThis);

	/// <summary>
	/// Return position in global coordinates of pick point.
	/// </summary>
	public virtual double[] GetPickPosition()
	{
		IntPtr intPtr = vtkAbstractPicker_GetPickPosition_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPicker_GetPickPosition_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Return position in global coordinates of pick point.
	/// </summary>
	public virtual void GetPickPosition(IntPtr data)
	{
		vtkAbstractPicker_GetPickPosition_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPicker_GetRenderer_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the renderer in which pick event occurred.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPicker_GetRenderer_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPicker_GetSelectionPoint_10(HandleRef pThis);

	/// <summary>
	/// Get the selection point in screen (pixel) coordinates. The third
	/// value is related to z-buffer depth. (Normally should be =0.)
	/// </summary>
	public virtual double[] GetSelectionPoint()
	{
		IntPtr intPtr = vtkAbstractPicker_GetSelectionPoint_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPicker_GetSelectionPoint_11(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get the selection point in screen (pixel) coordinates. The third
	/// value is related to z-buffer depth. (Normally should be =0.)
	/// </summary>
	public virtual void GetSelectionPoint(IntPtr data)
	{
		vtkAbstractPicker_GetSelectionPoint_11(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPicker_InitializePickList_12(HandleRef pThis);

	/// <summary>
	/// Initialize list of actors in pick list.
	/// </summary>
	public void InitializePickList()
	{
		vtkAbstractPicker_InitializePickList_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPicker_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractPicker_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPicker_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractPicker_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPicker_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractPicker NewInstance()
	{
		vtkAbstractPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPicker_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPicker_Pick_16(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

	/// <summary>
	/// Perform pick operation with selection point provided. Normally the
	/// first two values for the selection point are x-y pixel coordinate, and
	/// the third value is =0. Return non-zero if something was successfully
	/// picked.
	/// </summary>
	public virtual int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
	{
		return vtkAbstractPicker_Pick_16(GetCppThis(), selectionX, selectionY, selectionZ, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPicker_Pick_17(HandleRef pThis, IntPtr selectionPt, HandleRef ren);

	/// <summary>
	/// provided. Normally the first two values for the selection point
	/// are x-y pixel coordinate, and the third value is =0. Return
	/// non-zero if something was successfully picked.
	/// </summary>
	public int Pick(IntPtr selectionPt, vtkRenderer ren)
	{
		return vtkAbstractPicker_Pick_17(GetCppThis(), selectionPt, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPicker_Pick3DPoint_18(HandleRef pThis, IntPtr arg0, HandleRef arg1);

	/// <summary>
	/// Perform pick operation with selection point provided. The
	/// selectionPt is in world coordinates.
	/// Return non-zero if something was successfully picked.
	/// </summary>
	public virtual int Pick3DPoint(IntPtr arg0, vtkRenderer arg1)
	{
		return vtkAbstractPicker_Pick3DPoint_18(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPicker_Pick3DRay_19(HandleRef pThis, IntPtr arg0, IntPtr arg1, HandleRef arg2);

	/// <summary>
	/// Perform pick operation with selection point and orientation provided.
	/// The selectionPt is in world coordinates.
	/// Return non-zero if something was successfully picked.
	/// </summary>
	public virtual int Pick3DRay(IntPtr arg0, IntPtr arg1, vtkRenderer arg2)
	{
		return vtkAbstractPicker_Pick3DRay_19(GetCppThis(), arg0, arg1, arg2?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPicker_PickFromListOff_20(HandleRef pThis);

	/// <summary>
	/// Use these methods to control whether to limit the picking to this list
	/// (rather than renderer's actors). Make sure that the pick list contains
	/// actors that referred to by the picker's renderer.
	/// </summary>
	public virtual void PickFromListOff()
	{
		vtkAbstractPicker_PickFromListOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPicker_PickFromListOn_21(HandleRef pThis);

	/// <summary>
	/// Use these methods to control whether to limit the picking to this list
	/// (rather than renderer's actors). Make sure that the pick list contains
	/// actors that referred to by the picker's renderer.
	/// </summary>
	public virtual void PickFromListOn()
	{
		vtkAbstractPicker_PickFromListOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPicker_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractPicker SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractPicker vtkAbstractPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPicker_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPicker2 = (vtkAbstractPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPicker2.Register(null);
			}
		}
		return vtkAbstractPicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPicker_SetPickFromList_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Use these methods to control whether to limit the picking to this list
	/// (rather than renderer's actors). Make sure that the pick list contains
	/// actors that referred to by the picker's renderer.
	/// </summary>
	public virtual void SetPickFromList(int _arg)
	{
		vtkAbstractPicker_SetPickFromList_23(GetCppThis(), _arg);
	}
}
