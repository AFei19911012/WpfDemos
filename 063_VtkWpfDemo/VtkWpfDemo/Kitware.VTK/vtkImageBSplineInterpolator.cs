using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageBSplineInterpolator
/// </summary>
/// <remarks>
///    perform b-spline interpolation on images
///
/// vtkImageBSplineInterpolator can be used to perform b-spline interpolation
/// on images that have been filtered with vtkImageBSplineCoefficients.  The
/// b-spline interpolants provide the maximum possible degree of continuity
/// for a given kernel size, but require that the image data be pre-filtered
/// to generate b-spline coefficients before the interpolation is performed.
/// Interpolating data that has not been pre-filtered will give incorrect
/// results.
/// </remarks>
/// <seealso>
///
/// vtkImageReslice vtkImageBSplineCoefficients vtkBSplineTransform
/// @par Thanks:
/// This class was written by David Gobbi at the Seaman Family MR Research
/// Centre, Foothills Medical Centre, Calgary, Alberta.
/// DG Gobbi and YP Starreveld,
/// "Uniform B-Splines for the VTK Imaging Pipeline,"
/// VTK Journal, 2011,
/// http://hdl.handle.net/10380/3252
/// </seealso>
public class vtkImageBSplineInterpolator : vtkAbstractImageInterpolator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageBSplineInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageBSplineInterpolator()
	{
		MRClassNameKey = "class vtkImageBSplineInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageBSplineInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageBSplineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBSplineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageBSplineInterpolator New()
	{
		vtkImageBSplineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBSplineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageBSplineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageBSplineInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageBSplineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineInterpolator_ComputeSupportSize_01(HandleRef pThis, IntPtr matrix, IntPtr size);

	/// <summary>
	/// Get the support size for use in computing update extents.  If the data
	/// will be sampled on a regular grid, then pass a matrix describing the
	/// structured coordinate transformation between the output and the input.
	/// Otherwise, pass nullptr as the matrix to retrieve the full kernel size.
	/// </summary>
	public override void ComputeSupportSize(IntPtr matrix, IntPtr size)
	{
		vtkImageBSplineInterpolator_ComputeSupportSize_01(GetCppThis(), matrix, size);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageBSplineInterpolator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageBSplineInterpolator_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageBSplineInterpolator_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageBSplineInterpolator_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineInterpolator_GetSplineDegree_04(HandleRef pThis);

	/// <summary>
	/// Set the degree of the spline polynomial.  The default value is 3,
	/// and the maximum is 9.  The data must be pre-filtered for the same
	/// degree of polynomial with vtkImageBSplineCoefficients.
	/// </summary>
	public int GetSplineDegree()
	{
		return vtkImageBSplineInterpolator_GetSplineDegree_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineInterpolator_GetSplineDegreeMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the degree of the spline polynomial.  The default value is 3,
	/// and the maximum is 9.  The data must be pre-filtered for the same
	/// degree of polynomial with vtkImageBSplineCoefficients.
	/// </summary>
	public int GetSplineDegreeMaxValue()
	{
		return vtkImageBSplineInterpolator_GetSplineDegreeMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineInterpolator_GetSplineDegreeMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the degree of the spline polynomial.  The default value is 3,
	/// and the maximum is 9.  The data must be pre-filtered for the same
	/// degree of polynomial with vtkImageBSplineCoefficients.
	/// </summary>
	public int GetSplineDegreeMinValue()
	{
		return vtkImageBSplineInterpolator_GetSplineDegreeMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineInterpolator_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageBSplineInterpolator_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageBSplineInterpolator_IsSeparable_08(HandleRef pThis);

	/// <summary>
	/// Returns true if the interpolator supports weight precomputation.
	/// This will always return true for this interpolator.
	/// </summary>
	public override bool IsSeparable()
	{
		return (vtkImageBSplineInterpolator_IsSeparable_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineInterpolator_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageBSplineInterpolator_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBSplineInterpolator_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageBSplineInterpolator NewInstance()
	{
		vtkImageBSplineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBSplineInterpolator_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageBSplineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBSplineInterpolator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageBSplineInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkImageBSplineInterpolator vtkImageBSplineInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBSplineInterpolator_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageBSplineInterpolator2 = (vtkImageBSplineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageBSplineInterpolator2.Register(null);
			}
		}
		return vtkImageBSplineInterpolator2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineInterpolator_SetSplineDegree_13(HandleRef pThis, int degree);

	/// <summary>
	/// Set the degree of the spline polynomial.  The default value is 3,
	/// and the maximum is 9.  The data must be pre-filtered for the same
	/// degree of polynomial with vtkImageBSplineCoefficients.
	/// </summary>
	public void SetSplineDegree(int degree)
	{
		vtkImageBSplineInterpolator_SetSplineDegree_13(GetCppThis(), degree);
	}
}
