using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractMapper3D
/// </summary>
/// <remarks>
///    abstract class specifies interface to map 3D data
///
/// vtkAbstractMapper3D is an abstract class to specify interface between 3D
/// data and graphics primitives or software rendering techniques. Subclasses
/// of vtkAbstractMapper3D can be used for rendering geometry or rendering
/// volumetric data.
///
/// This class also defines an API to support hardware clipping planes (at most
/// six planes can be defined). It also provides geometric data about the input
/// data it maps, such as the bounding box and center.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractMapper vtkMapper vtkPolyDataMapper vtkVolumeMapper
/// </seealso>
public abstract class vtkAbstractMapper3D : vtkAbstractMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractMapper3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractMapper3D()
	{
		MRClassNameKey = "class vtkAbstractMapper3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractMapper3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractMapper3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkAbstractMapper3D_GetBounds_01(HandleRef pThis);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// Update this-&gt;Bounds as a side effect.
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkAbstractMapper3D_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper3D_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this mapper as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public virtual void GetBounds(IntPtr bounds)
	{
		vtkAbstractMapper3D_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractMapper3D_GetCenter_03(HandleRef pThis);

	/// <summary>
	/// Return the Center of this mapper's data.
	/// </summary>
	public double[] GetCenter()
	{
		IntPtr intPtr = vtkAbstractMapper3D_GetCenter_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper3D_GetCenter_04(HandleRef pThis, IntPtr center);

	/// <summary>
	/// Return the Center of this mapper's data.
	/// </summary>
	public void GetCenter(IntPtr center)
	{
		vtkAbstractMapper3D_GetCenter_04(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractMapper3D_GetClippingPlaneInDataCoords_05(HandleRef pThis, HandleRef propMatrix, int i, IntPtr planeEquation);

	/// <summary>
	/// Get the ith clipping plane as a homogeneous plane equation.
	/// Use GetNumberOfClippingPlanes to get the number of planes.
	/// </summary>
	public void GetClippingPlaneInDataCoords(vtkMatrix4x4 propMatrix, int i, IntPtr planeEquation)
	{
		vtkAbstractMapper3D_GetClippingPlaneInDataCoords_05(GetCppThis(), propMatrix?.GetCppThis() ?? default(HandleRef), i, planeEquation);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAbstractMapper3D_GetLength_06(HandleRef pThis);

	/// <summary>
	/// Return the diagonal length of this mappers bounding box.
	/// </summary>
	public double GetLength()
	{
		return vtkAbstractMapper3D_GetLength_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractMapper3D_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractMapper3D_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractMapper3D_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractMapper3D_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractMapper3D_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractMapper3D_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractMapper3D_IsARayCastMapper_10(HandleRef pThis);

	/// <summary>
	/// Is this a ray cast mapper? A subclass would return 1 if the
	/// ray caster is needed to generate an image from this mapper.
	/// </summary>
	public virtual int IsARayCastMapper()
	{
		return vtkAbstractMapper3D_IsARayCastMapper_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractMapper3D_IsARenderIntoImageMapper_11(HandleRef pThis);

	/// <summary>
	/// Is this a "render into image" mapper? A subclass would return 1 if the
	/// mapper produces an image by rendering into a software image buffer.
	/// </summary>
	public virtual int IsARenderIntoImageMapper()
	{
		return vtkAbstractMapper3D_IsARenderIntoImageMapper_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractMapper3D_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractMapper3D_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractMapper3D_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractMapper3D NewInstance()
	{
		vtkAbstractMapper3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractMapper3D_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractMapper3D_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractMapper3D SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractMapper3D vtkAbstractMapper3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractMapper3D_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractMapper3D2 = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractMapper3D2.Register(null);
			}
		}
		return vtkAbstractMapper3D2;
	}
}
