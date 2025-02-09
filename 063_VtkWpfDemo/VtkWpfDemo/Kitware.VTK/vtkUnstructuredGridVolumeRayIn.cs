using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridVolumeRayIntegrator
/// </summary>
/// <remarks>
///    a superclass for volume ray integration functions
///
///
///
/// vtkUnstructuredGridVolumeRayIntegrator is a superclass for ray
/// integration functions that can be used within a
/// vtkUnstructuredGridVolumeRayCastMapper.
///
/// </remarks>
/// <seealso>
///
/// vtkUnstructuredGridVolumeRayCastMapper
/// vtkUnstructuredGridVolumeRayCastFunction
/// </seealso>
public abstract class vtkUnstructuredGridVolumeRayIntegrator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayIntegrator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridVolumeRayIntegrator()
	{
		MRClassNameKey = "class vtkUnstructuredGridVolumeRayIntegrator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayIntegrator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridVolumeRayIntegrator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayIntegrator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridVolumeRayIntegrator_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeRayIntegrator_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridVolumeRayIntegrator_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayIntegrator_Initialize_03(HandleRef pThis, HandleRef volume, HandleRef scalars);

	/// <summary>
	/// Set up the integrator with the given properties and scalars.
	/// </summary>
	public virtual void Initialize(vtkVolume volume, vtkDataArray scalars)
	{
		vtkUnstructuredGridVolumeRayIntegrator_Initialize_03(GetCppThis(), volume?.GetCppThis() ?? default(HandleRef), scalars?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeRayIntegrator_Integrate_04(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

	/// <summary>
	/// Given a set of intersections (defined by the three arrays), compute
	/// the piecewise integration of the array in front to back order.
	/// /c intersectionLengths holds the lengths of each piecewise segment.
	/// /c nearIntersections and /c farIntersections hold the scalar values at
	/// the front and back of each segment.  /c color should contain the RGBA
	/// value of the volume in front of the segments passed in, and the result
	/// will be placed back into /c color.
	/// </summary>
	public virtual void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
	{
		vtkUnstructuredGridVolumeRayIntegrator_Integrate_04(GetCppThis(), intersectionLengths?.GetCppThis() ?? default(HandleRef), nearIntersections?.GetCppThis() ?? default(HandleRef), farIntersections?.GetCppThis() ?? default(HandleRef), color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayIntegrator_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridVolumeRayIntegrator_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeRayIntegrator_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridVolumeRayIntegrator_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayIntegrator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridVolumeRayIntegrator NewInstance()
	{
		vtkUnstructuredGridVolumeRayIntegrator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayIntegrator_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeRayIntegrator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridVolumeRayIntegrator SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeRayIntegrator_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayIntegrator2 = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayIntegrator2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayIntegrator2;
	}
}
