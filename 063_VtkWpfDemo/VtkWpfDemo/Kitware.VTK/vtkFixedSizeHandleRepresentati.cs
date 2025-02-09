using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFixedSizeHandleRepresentation
/// </summary>
/// <remarks>
///    A marker that has the same size in pixels.
///
///
/// This class is a concrete implementation of vtkHandleRepresentation. It is
/// meant to be used as a representation for vtkHandleWidget. Unlike the other
/// representations, this can maintain a constant size in pixels, regardless of
/// the camera zoom parameters. The size in pixels may be set via
/// SetHandleSizeInPixels. This representation renders the markers as spherical
/// blobs in 3D space with the width as specified above, defaults to 10 pixels.
/// The handles will have the same size in pixels, give or take a certain
/// tolerance, as specified by SetHandleSizeToleranceInPixels. The tolerance
/// defaults to half a pixel. PointPlacers may be used to specify constraints on
/// the placement of markers. For instance a vtkPolygonalSurfacePointPlacer
/// will constrain placement of these spherical handles to a surface mesh.
///
/// </remarks>
/// <seealso>
///
/// vtkHandleRepresentation vtkHandleWidget
/// </seealso>
public class vtkFixedSizeHandleRepresentation3D : vtkPolygonalHandleRepresentation3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFixedSizeHandleRepresentation3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFixedSizeHandleRepresentation3D()
	{
		MRClassNameKey = "class vtkFixedSizeHandleRepresentation3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedSizeHandleRepresentation3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFixedSizeHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedSizeHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkFixedSizeHandleRepresentation3D New()
	{
		vtkFixedSizeHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedSizeHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedSizeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkFixedSizeHandleRepresentation3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFixedSizeHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkFixedSizeHandleRepresentation3D_GetHandleSizeInPixels_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the required handle size in pixels. Defaults to a width of
	/// 10 pixels.
	/// </summary>
	public virtual double GetHandleSizeInPixels()
	{
		return vtkFixedSizeHandleRepresentation3D_GetHandleSizeInPixels_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFixedSizeHandleRepresentation3D_GetHandleSizeToleranceInPixels_02(HandleRef pThis);

	/// <summary>
	/// Specify the acceptable handle size tolerance. During each render, the
	/// handle 3D source will be updated to automatically match a display size
	/// as specified by HandleSizeInPixels. This update will be done if the
	/// handle size is larger than a tolerance. Default value of this
	/// tolerance is half a pixel.
	/// </summary>
	public virtual double GetHandleSizeToleranceInPixels()
	{
		return vtkFixedSizeHandleRepresentation3D_GetHandleSizeToleranceInPixels_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedSizeHandleRepresentation3D_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtk methods
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFixedSizeHandleRepresentation3D_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedSizeHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard vtk methods
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFixedSizeHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedSizeHandleRepresentation3D_GetSphereSource_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the object used to render the spherical handle marker
	/// </summary>
	public virtual vtkSphereSource GetSphereSource()
	{
		vtkSphereSource vtkSphereSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedSizeHandleRepresentation3D_GetSphereSource_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereSource2 = (vtkSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereSource2.Register(null);
			}
		}
		return vtkSphereSource2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedSizeHandleRepresentation3D_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtk methods
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFixedSizeHandleRepresentation3D_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedSizeHandleRepresentation3D_IsTypeOf_07(string type);

	/// <summary>
	/// Standard vtk methods
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFixedSizeHandleRepresentation3D_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedSizeHandleRepresentation3D_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtk methods
	/// </summary>
	public new vtkFixedSizeHandleRepresentation3D NewInstance()
	{
		vtkFixedSizeHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedSizeHandleRepresentation3D_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedSizeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedSizeHandleRepresentation3D_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtk methods
	/// </summary>
	public new static vtkFixedSizeHandleRepresentation3D SafeDownCast(vtkObjectBase o)
	{
		vtkFixedSizeHandleRepresentation3D vtkFixedSizeHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedSizeHandleRepresentation3D_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedSizeHandleRepresentation3D2 = (vtkFixedSizeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedSizeHandleRepresentation3D2.Register(null);
			}
		}
		return vtkFixedSizeHandleRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedSizeHandleRepresentation3D_SetHandleSizeInPixels_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the required handle size in pixels. Defaults to a width of
	/// 10 pixels.
	/// </summary>
	public virtual void SetHandleSizeInPixels(double _arg)
	{
		vtkFixedSizeHandleRepresentation3D_SetHandleSizeInPixels_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedSizeHandleRepresentation3D_SetHandleSizeToleranceInPixels_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the acceptable handle size tolerance. During each render, the
	/// handle 3D source will be updated to automatically match a display size
	/// as specified by HandleSizeInPixels. This update will be done if the
	/// handle size is larger than a tolerance. Default value of this
	/// tolerance is half a pixel.
	/// </summary>
	public virtual void SetHandleSizeToleranceInPixels(double _arg)
	{
		vtkFixedSizeHandleRepresentation3D_SetHandleSizeToleranceInPixels_12(GetCppThis(), _arg);
	}
}
