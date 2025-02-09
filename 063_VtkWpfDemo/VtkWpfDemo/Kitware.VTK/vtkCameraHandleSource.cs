using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCameraHandleSource
/// </summary>
/// <remarks>
///    handle source used to represent one camera.
///
/// vtkCameraHandleSource is deriving vtkHandleSource interface.
/// This handle represents a camera pointing in the focal point direction.
/// Its position and size can be modified.
/// If the directional parameter is set to true,
/// the camera is represented by one big arrow in the focal point direction
/// and one smaller pointing in the view up direction.
/// Else, the camera is only displayed as a simple sphere.
/// </remarks>
public class vtkCameraHandleSource : vtkHandleSource
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCameraHandleSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCameraHandleSource()
	{
		MRClassNameKey = "class vtkCameraHandleSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraHandleSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCameraHandleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraHandleSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCameraHandleSource New()
	{
		vtkCameraHandleSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraHandleSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraHandleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCameraHandleSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCameraHandleSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCameraHandleSource_GetDirection_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the direction of the camera handle.
	/// The direction is used in case the camera handle is
	/// represented as two arrows (when this-&gt;Directional = true).
	/// </summary>
	public override IntPtr GetDirection()
	{
		return vtkCameraHandleSource_GetDirection_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraHandleSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCameraHandleSource_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraHandleSource_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCameraHandleSource_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraHandleSource_GetPosition_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the camera handle.
	/// </summary>
	public override IntPtr GetPosition()
	{
		return vtkCameraHandleSource_GetPosition_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraHandleSource_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCameraHandleSource_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraHandleSource_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCameraHandleSource_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraHandleSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCameraHandleSource NewInstance()
	{
		vtkCameraHandleSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraHandleSource_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraHandleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraHandleSource_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCameraHandleSource SafeDownCast(vtkObjectBase o)
	{
		vtkCameraHandleSource vtkCameraHandleSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraHandleSource_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCameraHandleSource2 = (vtkCameraHandleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCameraHandleSource2.Register(null);
			}
		}
		return vtkCameraHandleSource2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraHandleSource_SetCamera_10(HandleRef pThis, HandleRef cam);

	/// <summary>
	/// Set the camera represented by this handle.
	/// The camera can't be set to nullptr.
	/// </summary>
	public void SetCamera(vtkCamera cam)
	{
		vtkCameraHandleSource_SetCamera_10(GetCppThis(), cam?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraHandleSource_SetDirection_11(HandleRef pThis, double xTarget, double yTarget, double zTarget);

	/// <summary>
	/// Set/Get the direction of the camera handle.
	/// The direction is used in case the camera handle is
	/// represented as two arrows (when this-&gt;Directional = true).
	/// </summary>
	public override void SetDirection(double xTarget, double yTarget, double zTarget)
	{
		vtkCameraHandleSource_SetDirection_11(GetCppThis(), xTarget, yTarget, zTarget);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraHandleSource_SetPosition_12(HandleRef pThis, double xPos, double yPos, double zPos);

	/// <summary>
	/// Set/Get the position of the camera handle.
	/// </summary>
	public override void SetPosition(double xPos, double yPos, double zPos)
	{
		vtkCameraHandleSource_SetPosition_12(GetCppThis(), xPos, yPos, zPos);
	}
}
