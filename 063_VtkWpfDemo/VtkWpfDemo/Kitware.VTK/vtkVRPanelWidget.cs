using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRPanelWidget
/// </summary>
/// <remarks>
///    3D widget to display a panel/billboard
///
/// Handles events for a PanelRepresentation.
///
/// </remarks>
/// <seealso>
///
/// vtkVRPanelRepresentation
/// </seealso>
public class vtkVRPanelWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRPanelWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRPanelWidget()
	{
		MRClassNameKey = "class vtkVRPanelWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRPanelWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRPanelWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRPanelWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkVRPanelWidget New()
	{
		vtkVRPanelWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRPanelWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRPanelWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkVRPanelWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVRPanelWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkVRPanelWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRPanelWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRPanelWidget_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRPanelWidget_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRPanelWidget_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRPanelWidget_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRPanelWidget_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRPanelWidget_IsTypeOf_05(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRPanelWidget_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRPanelWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new vtkVRPanelWidget NewInstance()
	{
		vtkVRPanelWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRPanelWidget_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRPanelWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRPanelWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static vtkVRPanelWidget SafeDownCast(vtkObjectBase o)
	{
		vtkVRPanelWidget vtkVRPanelWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRPanelWidget_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRPanelWidget2 = (vtkVRPanelWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRPanelWidget2.Register(null);
			}
		}
		return vtkVRPanelWidget2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelWidget_SetRepresentation_09(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkVRPanelRepresentation rep)
	{
		vtkVRPanelWidget_SetRepresentation_09(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}
}
