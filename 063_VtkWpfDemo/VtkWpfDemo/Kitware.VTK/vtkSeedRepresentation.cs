using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSeedRepresentation
/// </summary>
/// <remarks>
///    represent the vtkSeedWidget
///
/// The vtkSeedRepresentation is a superclass for classes representing the
/// vtkSeedWidget. This representation consists of one or more handles
/// (vtkHandleRepresentation) which are used to place and manipulate the
/// points defining the collection of seeds.
///
/// </remarks>
/// <seealso>
///
/// vtkSeedWidget vtkHandleRepresentation vtkSeedRepresentation
/// </seealso>
public class vtkSeedRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the seed points of
	/// the widget to be active.
	/// </summary>
	public enum NearSeed_WrapperEnum
	{
		/// <summary>enum member</summary>
		NearSeed = 1,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSeedRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSeedRepresentation()
	{
		MRClassNameKey = "class vtkSeedRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSeedRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSeedRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public new static vtkSeedRepresentation New()
	{
		vtkSeedRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public vtkSeedRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSeedRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSeedRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkSeedRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkSeedRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedRepresentation_CreateHandle_03(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods specific to vtkSeedRepresentation and which are
	/// invoked from vtkSeedWidget.
	/// </summary>
	public virtual int CreateHandle(IntPtr e)
	{
		return vtkSeedRepresentation_CreateHandle_03(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedRepresentation_GetActiveHandle_04(HandleRef pThis);

	/// <summary>
	/// These are methods specific to vtkSeedRepresentation and which are
	/// invoked from vtkSeedWidget.
	/// </summary>
	public virtual int GetActiveHandle()
	{
		return vtkSeedRepresentation_GetActiveHandle_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_GetActors_05(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkSeedRepresentation_GetActors_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedRepresentation_GetHandleRepresentation_06(HandleRef pThis, uint num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle representations used for a particular seed. A side effect of
	/// this method is that it will create a handle representation in the list of
	/// representations if one has not yet been created.
	/// </summary>
	public vtkHandleRepresentation GetHandleRepresentation(uint num)
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedRepresentation_GetHandleRepresentation_06(GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedRepresentation_GetHandleRepresentation_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the model HandleRepresentation.
	/// </summary>
	public vtkHandleRepresentation GetHandleRepresentation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedRepresentation_GetHandleRepresentation_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSeedRepresentation_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSeedRepresentation_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSeedRepresentation_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSeedRepresentation_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedRepresentation_GetNumberOfSeeds_10(HandleRef pThis);

	/// <summary>
	/// Return the number of seeds (or handles) that have been created.
	/// </summary>
	public int GetNumberOfSeeds()
	{
		return vtkSeedRepresentation_GetNumberOfSeeds_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_GetSeedDisplayPosition_11(HandleRef pThis, uint seedNum, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of seed points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates. The seeds are accessed by a seed
	/// number.
	/// </summary>
	public virtual void GetSeedDisplayPosition(uint seedNum, IntPtr pos)
	{
		vtkSeedRepresentation_GetSeedDisplayPosition_11(GetCppThis(), seedNum, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_GetSeedWorldPosition_12(HandleRef pThis, uint seedNum, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of seed points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates. The seeds are accessed by a seed
	/// number.
	/// </summary>
	public virtual void GetSeedWorldPosition(uint seedNum, IntPtr pos)
	{
		vtkSeedRepresentation_GetSeedWorldPosition_12(GetCppThis(), seedNum, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedRepresentation_GetTolerance_13(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the seed points of
	/// the widget to be active.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkSeedRepresentation_GetTolerance_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedRepresentation_GetToleranceMaxValue_14(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the seed points of
	/// the widget to be active.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkSeedRepresentation_GetToleranceMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedRepresentation_GetToleranceMinValue_15(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the seed points of
	/// the widget to be active.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkSeedRepresentation_GetToleranceMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedRepresentation_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSeedRepresentation_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedRepresentation_IsTypeOf_17(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSeedRepresentation_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedRepresentation_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkSeedRepresentation NewInstance()
	{
		vtkSeedRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedRepresentation_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_RemoveActiveHandle_20(HandleRef pThis);

	/// <summary>
	/// These are methods specific to vtkSeedRepresentation and which are
	/// invoked from vtkSeedWidget.
	/// </summary>
	public virtual void RemoveActiveHandle()
	{
		vtkSeedRepresentation_RemoveActiveHandle_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_RemoveHandle_21(HandleRef pThis, int n);

	/// <summary>
	/// Remove the nth handle.
	/// </summary>
	public virtual void RemoveHandle(int n)
	{
		vtkSeedRepresentation_RemoveHandle_21(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_RemoveLastHandle_22(HandleRef pThis);

	/// <summary>
	/// These are methods specific to vtkSeedRepresentation and which are
	/// invoked from vtkSeedWidget.
	/// </summary>
	public virtual void RemoveLastHandle()
	{
		vtkSeedRepresentation_RemoveLastHandle_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedRepresentation_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkSeedRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkSeedRepresentation vtkSeedRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedRepresentation_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSeedRepresentation2 = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSeedRepresentation2.Register(null);
			}
		}
		return vtkSeedRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_SetActiveHandle_24(HandleRef pThis, int handleId);

	/// <summary>
	/// These are methods specific to vtkSeedRepresentation and which are
	/// invoked from vtkSeedWidget.
	/// </summary>
	public virtual void SetActiveHandle(int handleId)
	{
		vtkSeedRepresentation_SetActiveHandle_24(GetCppThis(), handleId);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_SetHandleRepresentation_25(HandleRef pThis, HandleRef handle);

	/// <summary>
	/// This method is used to specify the type of handle representation to use
	/// for the internal vtkHandleWidgets within vtkSeedWidget.  To use this
	/// method, create a dummy vtkHandleWidget (or subclass), and then invoke
	/// this method with this dummy. Then the vtkSeedRepresentation uses this
	/// dummy to clone vtkHandleWidgets of the same type. Make sure you set the
	/// handle representation before the widget is enabled.
	/// </summary>
	public void SetHandleRepresentation(vtkHandleRepresentation handle)
	{
		vtkSeedRepresentation_SetHandleRepresentation_25(GetCppThis(), handle?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_SetSeedDisplayPosition_26(HandleRef pThis, uint seedNum, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of seed points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates. The seeds are accessed by a seed
	/// number.
	/// </summary>
	public virtual void SetSeedDisplayPosition(uint seedNum, IntPtr pos)
	{
		vtkSeedRepresentation_SetSeedDisplayPosition_26(GetCppThis(), seedNum, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_SetSeedWorldPosition_27(HandleRef pThis, uint seedNum, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of seed points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates. The seeds are accessed by a seed
	/// number.
	/// </summary>
	public virtual void SetSeedWorldPosition(uint seedNum, IntPtr pos)
	{
		vtkSeedRepresentation_SetSeedWorldPosition_27(GetCppThis(), seedNum, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedRepresentation_SetTolerance_28(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels) in
	/// which the cursor is considered near enough to the seed points of
	/// the widget to be active.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkSeedRepresentation_SetTolerance_28(GetCppThis(), _arg);
	}
}
