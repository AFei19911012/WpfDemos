using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOrientedPolygonalHandleRepresentation3D
/// </summary>
/// <remarks>
///    represent a user defined handle geometry in 3D while maintaining a fixed orientation
/// w.r.t the camera.
///
/// This class serves as the geometrical representation of a vtkHandleWidget.
/// The handle can be represented by an arbitrary polygonal data (vtkPolyData),
/// set via SetHandle(vtkPolyData *). The actual position of the handle
/// will be initially assumed to be (0,0,0). You can specify an offset from
/// this position if desired. This class differs from
/// vtkPolygonalHandleRepresentation3D in that the handle will always remain
/// front facing, ie it maintains a fixed orientation with respect to the
/// camera. This is done by using vtkFollowers internally to render the actors.
/// </remarks>
/// <seealso>
///
/// vtkPolygonalHandleRepresentation3D vtkHandleRepresentation vtkHandleWidget
/// </seealso>
public class vtkOrientedPolygonalHandleRepresentation3D : vtkAbstractPolygonalHandleRepresentation3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOrientedPolygonalHandleRepresentation3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOrientedPolygonalHandleRepresentation3D()
	{
		MRClassNameKey = "class vtkOrientedPolygonalHandleRepresentation3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientedPolygonalHandleRepresentation3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOrientedPolygonalHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedPolygonalHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkOrientedPolygonalHandleRepresentation3D New()
	{
		vtkOrientedPolygonalHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedPolygonalHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrientedPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkOrientedPolygonalHandleRepresentation3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOrientedPolygonalHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkOrientedPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOrientedPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrientedPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOrientedPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedPolygonalHandleRepresentation3D_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOrientedPolygonalHandleRepresentation3D_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedPolygonalHandleRepresentation3D_IsTypeOf_04(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOrientedPolygonalHandleRepresentation3D_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedPolygonalHandleRepresentation3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkOrientedPolygonalHandleRepresentation3D NewInstance()
	{
		vtkOrientedPolygonalHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedPolygonalHandleRepresentation3D_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrientedPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedPolygonalHandleRepresentation3D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkOrientedPolygonalHandleRepresentation3D SafeDownCast(vtkObjectBase o)
	{
		vtkOrientedPolygonalHandleRepresentation3D vtkOrientedPolygonalHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedPolygonalHandleRepresentation3D_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOrientedPolygonalHandleRepresentation3D2 = (vtkOrientedPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOrientedPolygonalHandleRepresentation3D2.Register(null);
			}
		}
		return vtkOrientedPolygonalHandleRepresentation3D2;
	}
}
