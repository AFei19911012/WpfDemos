using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResliceImageViewerMeasurements
/// </summary>
/// <remarks>
///    Manage measurements on a resliced image
///
/// This class manages measurements on the resliced image. It toggles the
/// the visibility of the measurements based on whether the resliced image
/// is the same orientation as when the measurement was initially placed.
/// </remarks>
/// <seealso>
///
/// vtkResliceCursor vtkResliceCursorWidget vtkResliceCursorRepresentation
/// </seealso>
public class vtkResliceImageViewerMeasurements : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResliceImageViewerMeasurements";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResliceImageViewerMeasurements()
	{
		MRClassNameKey = "class vtkResliceImageViewerMeasurements";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceImageViewerMeasurements"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResliceImageViewerMeasurements(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewerMeasurements_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkResliceImageViewerMeasurements New()
	{
		vtkResliceImageViewerMeasurements result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewerMeasurements_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceImageViewerMeasurements)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public vtkResliceImageViewerMeasurements()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResliceImageViewerMeasurements_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_AddItem_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add / remove a measurement widget
	/// </summary>
	public virtual void AddItem(vtkAbstractWidget arg0)
	{
		vtkResliceImageViewerMeasurements_AddItem_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceImageViewerMeasurements_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResliceImageViewerMeasurements_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceImageViewerMeasurements_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResliceImageViewerMeasurements_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewerMeasurements_GetProcessEvents_04(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual int GetProcessEvents()
	{
		return vtkResliceImageViewerMeasurements_GetProcessEvents_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewerMeasurements_GetProcessEventsMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual int GetProcessEventsMaxValue()
	{
		return vtkResliceImageViewerMeasurements_GetProcessEventsMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewerMeasurements_GetProcessEventsMinValue_06(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual int GetProcessEventsMinValue()
	{
		return vtkResliceImageViewerMeasurements_GetProcessEventsMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewerMeasurements_GetResliceImageViewer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the reslice image viewer. This is automatically done in the class
	/// vtkResliceImageViewer
	/// </summary>
	public virtual vtkResliceImageViewer GetResliceImageViewer()
	{
		vtkResliceImageViewer vtkResliceImageViewer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewerMeasurements_GetResliceImageViewer_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceImageViewer2 = (vtkResliceImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceImageViewer2.Register(null);
			}
		}
		return vtkResliceImageViewer2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkResliceImageViewerMeasurements_GetTolerance_08(HandleRef pThis);

	/// <summary>
	/// Tolerance for Point-in-Plane check
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkResliceImageViewerMeasurements_GetTolerance_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewerMeasurements_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResliceImageViewerMeasurements_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceImageViewerMeasurements_IsTypeOf_10(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResliceImageViewerMeasurements_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewerMeasurements_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkResliceImageViewerMeasurements NewInstance()
	{
		vtkResliceImageViewerMeasurements result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewerMeasurements_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceImageViewerMeasurements)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_ProcessEventsOff_13(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual void ProcessEventsOff()
	{
		vtkResliceImageViewerMeasurements_ProcessEventsOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_ProcessEventsOn_14(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual void ProcessEventsOn()
	{
		vtkResliceImageViewerMeasurements_ProcessEventsOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_RemoveAllItems_15(HandleRef pThis);

	/// <summary>
	/// Add / remove a measurement widget
	/// </summary>
	public virtual void RemoveAllItems()
	{
		vtkResliceImageViewerMeasurements_RemoveAllItems_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_RemoveItem_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add / remove a measurement widget
	/// </summary>
	public virtual void RemoveItem(vtkAbstractWidget arg0)
	{
		vtkResliceImageViewerMeasurements_RemoveItem_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_Render_17(HandleRef pThis);

	/// <summary>
	/// Render the measurements.
	/// </summary>
	public virtual void Render()
	{
		vtkResliceImageViewerMeasurements_Render_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceImageViewerMeasurements_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkResliceImageViewerMeasurements SafeDownCast(vtkObjectBase o)
	{
		vtkResliceImageViewerMeasurements vtkResliceImageViewerMeasurements2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceImageViewerMeasurements_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceImageViewerMeasurements2 = (vtkResliceImageViewerMeasurements)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceImageViewerMeasurements2.Register(null);
			}
		}
		return vtkResliceImageViewerMeasurements2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_SetProcessEvents_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual void SetProcessEvents(int _arg)
	{
		vtkResliceImageViewerMeasurements_SetProcessEvents_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_SetResliceImageViewer_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the reslice image viewer. This is automatically done in the class
	/// vtkResliceImageViewer
	/// </summary>
	public virtual void SetResliceImageViewer(vtkResliceImageViewer arg0)
	{
		vtkResliceImageViewerMeasurements_SetResliceImageViewer_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_SetTolerance_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Tolerance for Point-in-Plane check
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkResliceImageViewerMeasurements_SetTolerance_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceImageViewerMeasurements_Update_22(HandleRef pThis);

	/// <summary>
	/// Update the measurements. This is automatically called when the reslice
	/// cursor's axes are change.
	/// </summary>
	public virtual void Update()
	{
		vtkResliceImageViewerMeasurements_Update_22(GetCppThis());
	}
}
