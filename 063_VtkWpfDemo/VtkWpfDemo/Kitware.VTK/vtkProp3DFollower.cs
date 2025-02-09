using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProp3DFollower
/// </summary>
/// <remarks>
///    a vtkProp3D that always faces the camera
///
/// vtkProp3DFollower is a type of vtkProp3D that always faces the camera.
/// More specifically it will not change its position or scale,
/// but it will continually update its orientation so that it is right side
/// up and facing the camera. This is typically used for complex billboards
/// or props that need to face the viewer at all times.
///
/// Note: All of the transformations that can be made to a vtkProp3D will take
/// effect with the follower. Thus, if you change the orientation of the
/// follower by 90 degrees, then it will follow the camera, but be off by 90
/// degrees.
///
/// </remarks>
/// <seealso>
///
/// vtkFollower vtkProp3D vtkCamera vtkProp3DAxisFollower
/// </seealso>
public class vtkProp3DFollower : vtkProp3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProp3DFollower";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProp3DFollower()
	{
		MRClassNameKey = "class vtkProp3DFollower";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3DFollower"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProp3DFollower(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DFollower_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a follower with no camera set.
	/// </summary>
	public new static vtkProp3DFollower New()
	{
		vtkProp3DFollower result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DFollower_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProp3DFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a follower with no camera set.
	/// </summary>
	public vtkProp3DFollower()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProp3DFollower_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkProp3DFollower_ComputeMatrix_01(HandleRef pThis);

	/// <summary>
	/// Generate the matrix based on ivars. This method overloads its superclasses
	/// ComputeMatrix() method due to the special vtkProp3DFollower matrix operations.
	/// </summary>
	public override void ComputeMatrix()
	{
		vtkProp3DFollower_ComputeMatrix_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DFollower_GetBounds_02(HandleRef pThis);

	/// <summary>
	/// Return the bounds of this vtkProp3D.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkProp3DFollower_GetBounds_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DFollower_GetCamera_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the camera to follow. If this is not set, then the follower
	/// won't know what to follow and will act like a normal vtkProp3D.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DFollower_GetCamera_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DFollower_GetNextPath_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Overload vtkProp's method for setting up assembly paths. See
	/// the documentation for vtkProp.
	/// </summary>
	public override vtkAssemblyPath GetNextPath()
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DFollower_GetNextPath_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp3DFollower_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProp3DFollower_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp3DFollower_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProp3DFollower_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DFollower_GetProp3D_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the vtkProp3D to control (i.e., face the camera).
	/// </summary>
	public virtual vtkProp3D GetProp3D()
	{
		vtkProp3D vtkProp3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DFollower_GetProp3D_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3D2 = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3D2.Register(null);
			}
		}
		return vtkProp3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DFollower_HasTranslucentPolygonalGeometry_08(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkProp3DFollower_HasTranslucentPolygonalGeometry_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DFollower_InitPathTraversal_09(HandleRef pThis);

	/// <summary>
	/// Overload vtkProp's method for setting up assembly paths. See
	/// the documentation for vtkProp.
	/// </summary>
	public override void InitPathTraversal()
	{
		vtkProp3DFollower_InitPathTraversal_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DFollower_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProp3DFollower_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DFollower_IsTypeOf_11(string type);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProp3DFollower_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DFollower_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public new vtkProp3DFollower NewInstance()
	{
		vtkProp3DFollower result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DFollower_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProp3DFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DFollower_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources associated with this vtkProp3DFollower.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkProp3DFollower_ReleaseGraphicsResources_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DFollower_RenderOpaqueGeometry_15(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkProp3DFollower_RenderOpaqueGeometry_15(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DFollower_RenderTranslucentPolygonalGeometry_16(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkProp3DFollower_RenderTranslucentPolygonalGeometry_16(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3DFollower_RenderVolumetricGeometry_17(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically.
	/// </summary>
	public override int RenderVolumetricGeometry(vtkViewport viewport)
	{
		return vtkProp3DFollower_RenderVolumetricGeometry_17(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3DFollower_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for type and printing.
	/// </summary>
	public new static vtkProp3DFollower SafeDownCast(vtkObjectBase o)
	{
		vtkProp3DFollower vtkProp3DFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3DFollower_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3DFollower2 = (vtkProp3DFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3DFollower2.Register(null);
			}
		}
		return vtkProp3DFollower2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DFollower_SetCamera_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the camera to follow. If this is not set, then the follower
	/// won't know what to follow and will act like a normal vtkProp3D.
	/// </summary>
	public virtual void SetCamera(vtkCamera arg0)
	{
		vtkProp3DFollower_SetCamera_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DFollower_SetProp3D_20(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Set/Get the vtkProp3D to control (i.e., face the camera).
	/// </summary>
	public virtual void SetProp3D(vtkProp3D prop)
	{
		vtkProp3DFollower_SetProp3D_20(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3DFollower_ShallowCopy_21(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of a follower. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkProp3DFollower_ShallowCopy_21(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
