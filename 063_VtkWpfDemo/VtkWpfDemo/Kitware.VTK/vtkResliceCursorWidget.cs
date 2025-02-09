using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResliceCursorWidget
/// </summary>
/// <remarks>
///    represent a reslice cursor
///
/// This class represents a reslice cursor that can be used to
/// perform interactive thick slab MPR's through data. It
/// consists of two cross sectional hairs, with an optional thickness. The
/// hairs may have a hole in the center. These may be translated or rotated
/// independent of each other in the view. The result is used to reslice
/// the data along these cross sections. This allows the user to perform
/// multi-planar thin or thick reformat of the data on an image view, rather
/// than a 3D view. The class internally uses vtkImageSlabReslice
/// or vtkImageReslice depending on the modes in vtkResliceCursor to
/// do its reslicing. The slab thickness is set interactively from
/// the widget. The slab resolution (ie the number of blend points) is
/// set as the minimum spacing along any dimension from the dataset.
/// </remarks>
/// <seealso>
///
/// vtkImageSlabReslice vtkResliceCursorLineRepresentation
/// vtkResliceCursor
/// </seealso>
public class vtkResliceCursorWidget : vtkAbstractWidget
{
	/// <summary>
	/// Events
	/// </summary>
	public enum ResetCursorEvent_WrapperEnum
	{
		/// <summary>enum member</summary>
		ResetCursorEvent = 1058,
		/// <summary>enum member</summary>
		ResliceAxesChangedEvent = 1056,
		/// <summary>enum member</summary>
		ResliceThicknessChangedEvent = 1057,
		/// <summary>enum member</summary>
		WindowLevelEvent = 1055
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResliceCursorWidget()
	{
		MRClassNameKey = "class vtkResliceCursorWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResliceCursorWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkResliceCursorWidget New()
	{
		vtkResliceCursorWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkResliceCursorWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResliceCursorWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkResliceCursorWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkResliceCursorWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorWidget_GetManageWindowLevel_02(HandleRef pThis);

	/// <summary>
	/// Also perform window level ?
	/// </summary>
	public virtual int GetManageWindowLevel()
	{
		return vtkResliceCursorWidget_GetManageWindowLevel_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResliceCursorWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResliceCursorWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorWidget_GetResliceCursorRepresentation_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkResliceCursorRepresentation.
	/// </summary>
	public vtkResliceCursorRepresentation GetResliceCursorRepresentation()
	{
		vtkResliceCursorRepresentation vtkResliceCursorRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorWidget_GetResliceCursorRepresentation_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorRepresentation2 = (vtkResliceCursorRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorRepresentation2.Register(null);
			}
		}
		return vtkResliceCursorRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorWidget_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResliceCursorWidget_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorWidget_IsTypeOf_07(string type);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResliceCursorWidget_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorWidget_ManageWindowLevelOff_08(HandleRef pThis);

	/// <summary>
	/// Also perform window level ?
	/// </summary>
	public virtual void ManageWindowLevelOff()
	{
		vtkResliceCursorWidget_ManageWindowLevelOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorWidget_ManageWindowLevelOn_09(HandleRef pThis);

	/// <summary>
	/// Also perform window level ?
	/// </summary>
	public virtual void ManageWindowLevelOn()
	{
		vtkResliceCursorWidget_ManageWindowLevelOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorWidget_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public new vtkResliceCursorWidget NewInstance()
	{
		vtkResliceCursorWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorWidget_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorWidget_ResetResliceCursor_12(HandleRef pThis);

	/// <summary>
	/// Reset the cursor back to its initial state
	/// </summary>
	public virtual void ResetResliceCursor()
	{
		vtkResliceCursorWidget_ResetResliceCursor_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorWidget_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public new static vtkResliceCursorWidget SafeDownCast(vtkObjectBase o)
	{
		vtkResliceCursorWidget vtkResliceCursorWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorWidget_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorWidget2 = (vtkResliceCursorWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorWidget2.Register(null);
			}
		}
		return vtkResliceCursorWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorWidget_SetEnabled_14(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods for activiating this widget. This implementation extends the
	/// superclasses' in order to resize the widget handles due to a render
	/// start event.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkResliceCursorWidget_SetEnabled_14(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorWidget_SetManageWindowLevel_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Also perform window level ?
	/// </summary>
	public virtual void SetManageWindowLevel(int _arg)
	{
		vtkResliceCursorWidget_SetManageWindowLevel_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorWidget_SetRepresentation_16(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkResliceCursorRepresentation r)
	{
		vtkResliceCursorWidget_SetRepresentation_16(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}
}
