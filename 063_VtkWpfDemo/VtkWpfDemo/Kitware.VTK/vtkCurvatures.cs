using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCurvatures
/// </summary>
/// <remarks>
///    compute curvatures (Gauss and mean) of a Polydata object
///
/// vtkCurvatures takes a polydata input and computes the curvature of the
/// mesh at each point. Four possible methods of computation are available :
///
/// Gauss Curvature discrete Gauss curvature (\f$ K \f$),
/// \f$K_v = 2\pi-n_vf_v(\alpha)\f$, where \f$K_v\f$ is the curvature
/// at vertex \f$v\f$, \f$n_v\f$ the facet neighbours of the vertex \f$v\f$
/// and \f$f_v(\alpha)\f$ is the angle of \f$f\f$ at vertex \f$v\f$.
/// The contribution of every facet is for the moment weighted by the
/// (area of each facet)/3 The units of Gaussian Curvature are \f$m^{-2}\f$.
///
/// Mean Curvature \f$H_v = \overline{H_e}\f$, where \f$\overline{H_e}\f$ is
/// the average over the edge neighbours of \f$H_e\f$.
/// \f$H_e = l(e)*\alpha(e)\f$ where \f$e\f$ is an edge, \f$l\f$ is the length
/// and \f$\alpha\f$ is the dihederal angle such that
/// \f$-\pi &lt; \alpha &lt; \pi\f$. This means that the surface is assumed to
/// be orientable and the computation creates the orientation. The units of
/// Mean Curvature are \f$m^{-1}\f$.
///
/// Maximum (\f$k_{max}\f$) and Minimum (\f$k_{min}\f$) Principal Curvatures
///  are \f$k_{max} = H + \sqrt{H^2 - K}\f$ and
/// \f$k_{min} = H - \sqrt{H^2 - K}\f$.
/// Excepting spherical and planar surfaces which have equal
/// principal curvatures, the curvature at a point on a surface varies with
/// the direction one "sets off" from the point. For all directions, the
/// curvature will pass through two extrema: a minimum (\f$k_{min}\f$) and a
/// maximum (\f$k_{max}\f$) which occur at mutually orthogonal directions
/// to each other.
///
/// The sign of the Gauss curvature is a geometric ivariant, it should be
/// positive when the surface looks like a sphere, negative when it looks
/// like a saddle, however, the sign of the Mean curvature is not, it depends
/// on the convention for normals, This code assumes that normals point
/// outwards (ie from the surface of a sphere outwards). If a given mesh
/// produces curvatures of opposite senses then the flag InvertMeanCurvature
///  can be set and the Curvature reported by the Mean calculation will
/// be inverted.
///
/// For a little more information see
/// &lt;a href="https://public.kitware.com/pipermail/vtkusers/2002-July/012198.html"
/// &gt;Computing curvature of a surface&lt;/a&gt;
///
/// @par Thanks:
/// &lt;a href="https://en.wikipedia.org/wiki/Philip_Batchelor"&gt;Philip Batchelor&lt;/a&gt;
/// for creating and contributing the class and Andrew Maclean for cleanups and
/// fixes. Thanks also to John Biddiscombe for adding the class and
/// Goodwin Lawlor for contributing a patch to calculate principal curvatures
///
/// </remarks>
public class vtkCurvatures : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCurvatures";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCurvatures()
	{
		MRClassNameKey = "class vtkCurvatures";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCurvatures"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCurvatures(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurvatures_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with curvature type set to Gauss
	/// </summary>
	public new static vtkCurvatures New()
	{
		vtkCurvatures result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurvatures_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCurvatures)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with curvature type set to Gauss
	/// </summary>
	public vtkCurvatures()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCurvatures_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurvatures_GetCurvatureType_01(HandleRef pThis);

	/// <summary>
	/// Set/Get Curvature type
	/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
	/// DataArray "Gauss_Curvature"
	/// VTK_CURVATURE_MEAN : Mean curvature, stored as
	/// DataArray "Mean_Curvature"
	/// </summary>
	public virtual int GetCurvatureType()
	{
		return vtkCurvatures_GetCurvatureType_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurvatures_GetInvertMeanCurvature_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which inverts the mean curvature calculation for
	/// meshes with inward pointing normals (default false)
	/// </summary>
	public virtual int GetInvertMeanCurvature()
	{
		return vtkCurvatures_GetInvertMeanCurvature_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCurvatures_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCurvatures_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCurvatures_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCurvatures_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurvatures_InvertMeanCurvatureOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which inverts the mean curvature calculation for
	/// meshes with inward pointing normals (default false)
	/// </summary>
	public virtual void InvertMeanCurvatureOff()
	{
		vtkCurvatures_InvertMeanCurvatureOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurvatures_InvertMeanCurvatureOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which inverts the mean curvature calculation for
	/// meshes with inward pointing normals (default false)
	/// </summary>
	public virtual void InvertMeanCurvatureOn()
	{
		vtkCurvatures_InvertMeanCurvatureOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurvatures_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCurvatures_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurvatures_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCurvatures_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurvatures_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCurvatures NewInstance()
	{
		vtkCurvatures result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurvatures_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCurvatures)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurvatures_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCurvatures SafeDownCast(vtkObjectBase o)
	{
		vtkCurvatures vtkCurvatures2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurvatures_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCurvatures2 = (vtkCurvatures)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCurvatures2.Register(null);
			}
		}
		return vtkCurvatures2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurvatures_SetCurvatureType_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get Curvature type
	/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
	/// DataArray "Gauss_Curvature"
	/// VTK_CURVATURE_MEAN : Mean curvature, stored as
	/// DataArray "Mean_Curvature"
	/// </summary>
	public virtual void SetCurvatureType(int _arg)
	{
		vtkCurvatures_SetCurvatureType_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurvatures_SetCurvatureTypeToGaussian_13(HandleRef pThis);

	/// <summary>
	/// Set/Get Curvature type
	/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
	/// DataArray "Gauss_Curvature"
	/// VTK_CURVATURE_MEAN : Mean curvature, stored as
	/// DataArray "Mean_Curvature"
	/// </summary>
	public void SetCurvatureTypeToGaussian()
	{
		vtkCurvatures_SetCurvatureTypeToGaussian_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurvatures_SetCurvatureTypeToMaximum_14(HandleRef pThis);

	/// <summary>
	/// Set/Get Curvature type
	/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
	/// DataArray "Gauss_Curvature"
	/// VTK_CURVATURE_MEAN : Mean curvature, stored as
	/// DataArray "Mean_Curvature"
	/// </summary>
	public void SetCurvatureTypeToMaximum()
	{
		vtkCurvatures_SetCurvatureTypeToMaximum_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurvatures_SetCurvatureTypeToMean_15(HandleRef pThis);

	/// <summary>
	/// Set/Get Curvature type
	/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
	/// DataArray "Gauss_Curvature"
	/// VTK_CURVATURE_MEAN : Mean curvature, stored as
	/// DataArray "Mean_Curvature"
	/// </summary>
	public void SetCurvatureTypeToMean()
	{
		vtkCurvatures_SetCurvatureTypeToMean_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurvatures_SetCurvatureTypeToMinimum_16(HandleRef pThis);

	/// <summary>
	/// Set/Get Curvature type
	/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
	/// DataArray "Gauss_Curvature"
	/// VTK_CURVATURE_MEAN : Mean curvature, stored as
	/// DataArray "Mean_Curvature"
	/// </summary>
	public void SetCurvatureTypeToMinimum()
	{
		vtkCurvatures_SetCurvatureTypeToMinimum_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurvatures_SetInvertMeanCurvature_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which inverts the mean curvature calculation for
	/// meshes with inward pointing normals (default false)
	/// </summary>
	public virtual void SetInvertMeanCurvature(int _arg)
	{
		vtkCurvatures_SetInvertMeanCurvature_17(GetCppThis(), _arg);
	}
}
