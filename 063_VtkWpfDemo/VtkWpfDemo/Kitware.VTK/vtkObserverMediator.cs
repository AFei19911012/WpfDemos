using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkObserverMediator
/// </summary>
/// <remarks>
///    manage contention for cursors and other resources
///
/// The vtkObserverMediator is a helper class that manages requests for
/// cursor changes from multiple interactor observers (e.g. widgets). It keeps
/// a list of widgets (and their priorities) and their current requests for
/// cursor shape. It then satisfies requests based on widget priority and the
/// relative importance of the request (e.g., a lower priority widget
/// requesting a particular cursor shape will overrule a higher priority
/// widget requesting a default shape).
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractWidget vtkWidgetRepresentation
/// </seealso>
public class vtkObserverMediator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkObserverMediator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkObserverMediator()
	{
		MRClassNameKey = "class vtkObserverMediator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkObserverMediator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkObserverMediator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObserverMediator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkObserverMediator New()
	{
		vtkObserverMediator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObserverMediator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkObserverMediator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkObserverMediator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObserverMediator_GetInteractor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the instance of vtkRenderWindow whose cursor shape is
	/// to be managed.
	/// </summary>
	public virtual vtkRenderWindowInteractor GetInteractor()
	{
		vtkRenderWindowInteractor vtkRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObserverMediator_GetInteractor_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindowInteractor2 = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindowInteractor2.Register(null);
			}
		}
		return vtkRenderWindowInteractor2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkObserverMediator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkObserverMediator_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkObserverMediator_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkObserverMediator_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObserverMediator_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkObserverMediator_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObserverMediator_IsTypeOf_05(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkObserverMediator_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObserverMediator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new vtkObserverMediator NewInstance()
	{
		vtkObserverMediator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObserverMediator_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObserverMediator_RemoveAllCursorShapeRequests_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove all requests for cursor shape from a given interactor.
	/// </summary>
	public void RemoveAllCursorShapeRequests(vtkInteractorObserver arg0)
	{
		vtkObserverMediator_RemoveAllCursorShapeRequests_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObserverMediator_RequestCursorShape_09(HandleRef pThis, HandleRef arg0, int requestedShape);

	/// <summary>
	/// Method used to request a cursor shape. Note that the shape is specified
	/// using one of the integral values determined in vtkRenderWindow.h. The
	/// method returns a non-zero value if the shape was successfully changed.
	/// </summary>
	public int RequestCursorShape(vtkInteractorObserver arg0, int requestedShape)
	{
		return vtkObserverMediator_RequestCursorShape_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), requestedShape);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObserverMediator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static vtkObserverMediator SafeDownCast(vtkObjectBase o)
	{
		vtkObserverMediator vtkObserverMediator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObserverMediator_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObserverMediator2 = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObserverMediator2.Register(null);
			}
		}
		return vtkObserverMediator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObserverMediator_SetInteractor_11(HandleRef pThis, HandleRef iren);

	/// <summary>
	/// Specify the instance of vtkRenderWindow whose cursor shape is
	/// to be managed.
	/// </summary>
	public void SetInteractor(vtkRenderWindowInteractor iren)
	{
		vtkObserverMediator_SetInteractor_11(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef));
	}
}
