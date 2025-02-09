using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTDxInteractorStyle
/// </summary>
/// <remarks>
///    provide 3DConnexion device event-driven interface to the rendering window
///
///
/// vtkTDxInteractorStyle is an abstract class defining an event-driven
/// interface to support 3DConnexion device events send by
/// vtkRenderWindowInteractor.
/// vtkRenderWindowInteractor forwards events in a platform independent form to
/// vtkInteractorStyle which can then delegate some processing to
/// vtkTDxInteractorStyle.
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyle vtkRenderWindowInteractor
/// vtkTDxInteractorStyleCamera
/// </seealso>
public class vtkTDxInteractorStyle : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTDxInteractorStyle";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTDxInteractorStyle()
	{
		MRClassNameKey = "class vtkTDxInteractorStyle";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTDxInteractorStyle"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTDxInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkTDxInteractorStyle_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTDxInteractorStyle_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTDxInteractorStyle_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTDxInteractorStyle_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTDxInteractorStyle_GetSettings_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// 3Dconnexion device settings. (sensitivity, individual axis filters).
	/// Initial object is not null.
	/// </summary>
	public virtual vtkTDxInteractorStyleSettings GetSettings()
	{
		vtkTDxInteractorStyleSettings vtkTDxInteractorStyleSettings2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTDxInteractorStyle_GetSettings_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTDxInteractorStyleSettings2 = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTDxInteractorStyleSettings2.Register(null);
			}
		}
		return vtkTDxInteractorStyleSettings2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTDxInteractorStyle_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTDxInteractorStyle_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTDxInteractorStyle_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTDxInteractorStyle_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTDxInteractorStyle_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTDxInteractorStyle NewInstance()
	{
		vtkTDxInteractorStyle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTDxInteractorStyle_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTDxInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyle_OnButtonPressedEvent_07(HandleRef pThis, int button);

	/// <summary>
	/// Action on button pressed event. Default implementation is empty.
	/// </summary>
	public virtual void OnButtonPressedEvent(int button)
	{
		vtkTDxInteractorStyle_OnButtonPressedEvent_07(GetCppThis(), button);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyle_OnButtonReleasedEvent_08(HandleRef pThis, int button);

	/// <summary>
	/// Action on button released event. Default implementation is empty.
	/// </summary>
	public virtual void OnButtonReleasedEvent(int button)
	{
		vtkTDxInteractorStyle_OnButtonReleasedEvent_08(GetCppThis(), button);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyle_ProcessEvent_09(HandleRef pThis, HandleRef renderer, uint arg1, IntPtr calldata);

	/// <summary>
	/// Dispatch the events TDxMotionEvent, TDxButtonPressEvent and
	/// TDxButtonReleaseEvent to OnMotionEvent(), OnButtonPressedEvent() and
	/// OnButtonReleasedEvent() respectively.
	/// It is called by the vtkInteractorStyle.
	/// This method is virtual for convenient but you should really override
	/// the On*Event() methods only.
	/// \pre renderer can be null.
	/// </summary>
	public virtual void ProcessEvent(vtkRenderer renderer, uint arg1, IntPtr calldata)
	{
		vtkTDxInteractorStyle_ProcessEvent_09(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef), arg1, calldata);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTDxInteractorStyle_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTDxInteractorStyle SafeDownCast(vtkObjectBase o)
	{
		vtkTDxInteractorStyle vtkTDxInteractorStyle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTDxInteractorStyle_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTDxInteractorStyle2 = (vtkTDxInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTDxInteractorStyle2.Register(null);
			}
		}
		return vtkTDxInteractorStyle2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTDxInteractorStyle_SetSettings_11(HandleRef pThis, HandleRef settings);

	/// <summary>
	/// 3Dconnexion device settings. (sensitivity, individual axis filters).
	/// Initial object is not null.
	/// </summary>
	public virtual void SetSettings(vtkTDxInteractorStyleSettings settings)
	{
		vtkTDxInteractorStyle_SetSettings_11(GetCppThis(), settings?.GetCppThis() ?? default(HandleRef));
	}
}
