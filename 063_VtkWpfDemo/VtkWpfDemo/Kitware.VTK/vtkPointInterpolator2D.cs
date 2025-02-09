using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointInterpolator2D
/// </summary>
/// <remarks>
///    interpolate point cloud attribute data
/// onto x-y plane using various kernels
///
///
/// vtkPointInterpolator2D probes a point cloud Pc (the filter Source) with a
/// set of points P (the filter Input), interpolating the data values from Pc
/// onto P. Note however that the descriptive phrase "point cloud" is a
/// misnomer: Pc can be represented by any vtkDataSet type, with the points of
/// the dataset forming Pc. Similarly, the output P can also be represented by
/// any vtkDataSet type; and the topology/geometry structure of P is passed
/// through to the output along with the newly interpolated arrays. However,
/// this filter presumes that P lies on a plane z=0.0, thus z-coordinates
/// are set accordingly during the interpolation process.
///
/// The optional boolean flag InterpolateZ is provided for convenience. In
/// effect it turns the source z coordinates into an additional array that is
/// interpolated onto the output data. For example, if the source is a x-y-z
/// LIDAR point cloud, then z can be interpolated onto the output dataset as a
/// vertical elevation(z-coordinate).
///
/// A key input to this filter is the specification of the interpolation
/// kernel, and the parameters which control the associated interpolation
/// process. Interpolation kernels include Voronoi, Gaussian, Shepard, and SPH
/// (smoothed particle hydrodynamics), with additional kernels to be added in
/// the future. See vtkPointInterpolator for more information.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// @warning
/// For widely spaced points in Pc, or when p is located outside the bounding
/// region of Pc, the interpolation may behave badly and the interpolation
/// process will adapt as necessary to produce output. For example, if the N
/// closest points within R are requested to interpolate p, if N=0 then the
/// interpolation will switch to a different strategy (which can be controlled
/// as in the NullPointsStrategy).
///
/// </remarks>
/// <seealso>
///
/// vtkPointInterpolator
/// </seealso>
public class vtkPointInterpolator2D : vtkPointInterpolator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointInterpolator2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointInterpolator2D()
	{
		MRClassNameKey = "class vtkPointInterpolator2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointInterpolator2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointInterpolator2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkPointInterpolator2D New()
	{
		vtkPointInterpolator2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointInterpolator2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointInterpolator2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public vtkPointInterpolator2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointInterpolator2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointInterpolator2D_GetInterpolateZ_01(HandleRef pThis);

	/// <summary>
	/// Specify whether to take the z-coordinate values of the source points as
	/// attributes to be interpolated. This is in addition to any other point
	/// attribute data associated with the source. By default this is enabled.
	/// </summary>
	public virtual bool GetInterpolateZ()
	{
		return (vtkPointInterpolator2D_GetInterpolateZ_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointInterpolator2D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointInterpolator2D_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointInterpolator2D_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointInterpolator2D_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPointInterpolator2D_GetZArrayName_04(HandleRef pThis);

	/// <summary>
	/// Specify the name of the output array containing z values. This method is
	/// only applicable when InterpolateZ is enabled. By default the output
	/// array name is "Elevation".
	/// </summary>
	public virtual string GetZArrayName()
	{
		return vtkPointInterpolator2D_GetZArrayName_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator2D_InterpolateZOff_05(HandleRef pThis);

	/// <summary>
	/// Specify whether to take the z-coordinate values of the source points as
	/// attributes to be interpolated. This is in addition to any other point
	/// attribute data associated with the source. By default this is enabled.
	/// </summary>
	public virtual void InterpolateZOff()
	{
		vtkPointInterpolator2D_InterpolateZOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator2D_InterpolateZOn_06(HandleRef pThis);

	/// <summary>
	/// Specify whether to take the z-coordinate values of the source points as
	/// attributes to be interpolated. This is in addition to any other point
	/// attribute data associated with the source. By default this is enabled.
	/// </summary>
	public virtual void InterpolateZOn()
	{
		vtkPointInterpolator2D_InterpolateZOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointInterpolator2D_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointInterpolator2D_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointInterpolator2D_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointInterpolator2D_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator2D_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new vtkPointInterpolator2D NewInstance()
	{
		vtkPointInterpolator2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointInterpolator2D_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointInterpolator2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator2D_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkPointInterpolator2D SafeDownCast(vtkObjectBase o)
	{
		vtkPointInterpolator2D vtkPointInterpolator2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointInterpolator2D_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointInterpolator2D2 = (vtkPointInterpolator2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointInterpolator2D2.Register(null);
			}
		}
		return vtkPointInterpolator2D2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator2D_SetInterpolateZ_12(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether to take the z-coordinate values of the source points as
	/// attributes to be interpolated. This is in addition to any other point
	/// attribute data associated with the source. By default this is enabled.
	/// </summary>
	public virtual void SetInterpolateZ(bool _arg)
	{
		vtkPointInterpolator2D_SetInterpolateZ_12(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator2D_SetZArrayName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the output array containing z values. This method is
	/// only applicable when InterpolateZ is enabled. By default the output
	/// array name is "Elevation".
	/// </summary>
	public virtual void SetZArrayName(string _arg)
	{
		vtkPointInterpolator2D_SetZArrayName_13(GetCppThis(), _arg);
	}
}
