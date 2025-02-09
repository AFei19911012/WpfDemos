using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageBSplineCoefficients
/// </summary>
/// <remarks>
///    convert image to b-spline knots
///
/// vtkImageBSplineCoefficients prepares an image for b-spline
/// interpolation by converting the image values into b-spline
/// knot coefficients.  It is a necessary pre-filtering step
/// before applying b-spline interpolation with vtkImageReslice.
///
/// This class is based on code provided by Philippe Thevenaz of
/// EPFL, Lausanne, Switzerland.  Please acknowledge his contribution
/// by citing the following paper:
/// [1] P. Thevenaz, T. Blu, M. Unser, "Interpolation Revisited,"
///     IEEE Transactions on Medical Imaging 19(7):739-758, 2000.
///
/// The clamped boundary condition (which is the default) is taken
/// from code presented in the following paper:
/// [2] D. Ruijters, P. Thevenaz,
///     "GPU Prefilter for Accurate Cubic B-spline Interpolation,"
///     The Computer Journal, doi: 10.1093/comjnl/bxq086, 2010.
///
/// @par Thanks:
/// This class was written by David Gobbi at the Seaman Family MR Research
/// Centre, Foothills Medical Centre, Calgary, Alberta.
/// DG Gobbi and YP Starreveld,
/// "Uniform B-Splines for the VTK Imaging Pipeline,"
/// VTK Journal, 2011,
/// http://hdl.handle.net/10380/3252
/// </remarks>
public class vtkImageBSplineCoefficients : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageBSplineCoefficients";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageBSplineCoefficients()
	{
		MRClassNameKey = "class vtkImageBSplineCoefficients";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageBSplineCoefficients"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageBSplineCoefficients(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBSplineCoefficients_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageBSplineCoefficients New()
	{
		vtkImageBSplineCoefficients result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBSplineCoefficients_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageBSplineCoefficients)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageBSplineCoefficients()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageBSplineCoefficients_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageBSplineCoefficients_BypassOff_01(HandleRef pThis);

	/// <summary>
	/// Bypass the filter, do not do any processing.  If this is on,
	/// then the output data will reference the input data directly,
	/// and the output type will be the same as the input type.  This
	/// is useful a downstream filter sometimes uses b-spline interpolation
	/// and sometimes uses other forms of interpolation.
	/// </summary>
	public virtual void BypassOff()
	{
		vtkImageBSplineCoefficients_BypassOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_BypassOn_02(HandleRef pThis);

	/// <summary>
	/// Bypass the filter, do not do any processing.  If this is on,
	/// then the output data will reference the input data directly,
	/// and the output type will be the same as the input type.  This
	/// is useful a downstream filter sometimes uses b-spline interpolation
	/// and sometimes uses other forms of interpolation.
	/// </summary>
	public virtual void BypassOn()
	{
		vtkImageBSplineCoefficients_BypassOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_CheckBounds_03(HandleRef pThis, IntPtr point);

	/// <summary>
	/// Check a point against the image bounds.  Return 0 if out of bounds,
	/// and 1 if inside bounds.  Calling Evaluate on a point outside the
	/// bounds will not generate an error, but the value returned will
	/// depend on the BorderMode.
	/// </summary>
	public int CheckBounds(IntPtr point)
	{
		return vtkImageBSplineCoefficients_CheckBounds_03(GetCppThis(), point);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_Evaluate_04(HandleRef pThis, IntPtr point, IntPtr value);

	/// <summary>
	/// Interpolate a value from the image.  You must call Update() before
	/// calling this method for the first time.  The first signature can
	/// return multiple components, while the second signature is for use
	/// on single-component images.
	/// </summary>
	public void Evaluate(IntPtr point, IntPtr value)
	{
		vtkImageBSplineCoefficients_Evaluate_04(GetCppThis(), point, value);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageBSplineCoefficients_Evaluate_05(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Interpolate a value from the image.  You must call Update() before
	/// calling this method for the first time.  The first signature can
	/// return multiple components, while the second signature is for use
	/// on single-component images.
	/// </summary>
	public double Evaluate(double x, double y, double z)
	{
		return vtkImageBSplineCoefficients_Evaluate_05(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageBSplineCoefficients_Evaluate_06(HandleRef pThis, IntPtr point);

	/// <summary>
	/// Interpolate a value from the image.  You must call Update() before
	/// calling this method for the first time.  The first signature can
	/// return multiple components, while the second signature is for use
	/// on single-component images.
	/// </summary>
	public double Evaluate(IntPtr point)
	{
		return vtkImageBSplineCoefficients_Evaluate_06(GetCppThis(), point);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkImageBorderMode vtkImageBSplineCoefficients_GetBorderMode_07(HandleRef pThis);

	/// <summary>
	/// Set the border mode.  The filter that is used to create the
	/// coefficients must repeat the image somehow to make a theoritically
	/// infinite input.  The default is to clamp values that are off the
	/// edge of the image, to the value at the closest point on the edge.
	/// The other ways of virtually extending the image are to produce
	/// mirrored copies, which results in optimal smoothness at the boundary,
	/// or to repeat the image, which results in a cyclic or periodic spline.
	/// </summary>
	public virtual vtkImageBorderMode GetBorderMode()
	{
		return vtkImageBSplineCoefficients_GetBorderMode_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBSplineCoefficients_GetBorderModeAsString_08(HandleRef pThis);

	/// <summary>
	/// Set the border mode.  The filter that is used to create the
	/// coefficients must repeat the image somehow to make a theoritically
	/// infinite input.  The default is to clamp values that are off the
	/// edge of the image, to the value at the closest point on the edge.
	/// The other ways of virtually extending the image are to produce
	/// mirrored copies, which results in optimal smoothness at the boundary,
	/// or to repeat the image, which results in a cyclic or periodic spline.
	/// </summary>
	public string GetBorderModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageBSplineCoefficients_GetBorderModeAsString_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkImageBorderMode vtkImageBSplineCoefficients_GetBorderModeMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set the border mode.  The filter that is used to create the
	/// coefficients must repeat the image somehow to make a theoritically
	/// infinite input.  The default is to clamp values that are off the
	/// edge of the image, to the value at the closest point on the edge.
	/// The other ways of virtually extending the image are to produce
	/// mirrored copies, which results in optimal smoothness at the boundary,
	/// or to repeat the image, which results in a cyclic or periodic spline.
	/// </summary>
	public virtual vtkImageBorderMode GetBorderModeMaxValue()
	{
		return vtkImageBSplineCoefficients_GetBorderModeMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkImageBorderMode vtkImageBSplineCoefficients_GetBorderModeMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set the border mode.  The filter that is used to create the
	/// coefficients must repeat the image somehow to make a theoritically
	/// infinite input.  The default is to clamp values that are off the
	/// edge of the image, to the value at the closest point on the edge.
	/// The other ways of virtually extending the image are to produce
	/// mirrored copies, which results in optimal smoothness at the boundary,
	/// or to repeat the image, which results in a cyclic or periodic spline.
	/// </summary>
	public virtual vtkImageBorderMode GetBorderModeMinValue()
	{
		return vtkImageBSplineCoefficients_GetBorderModeMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_GetBypass_11(HandleRef pThis);

	/// <summary>
	/// Bypass the filter, do not do any processing.  If this is on,
	/// then the output data will reference the input data directly,
	/// and the output type will be the same as the input type.  This
	/// is useful a downstream filter sometimes uses b-spline interpolation
	/// and sometimes uses other forms of interpolation.
	/// </summary>
	public virtual int GetBypass()
	{
		return vtkImageBSplineCoefficients_GetBypass_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageBSplineCoefficients_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageBSplineCoefficients_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageBSplineCoefficients_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageBSplineCoefficients_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_GetOutputScalarType_14(HandleRef pThis);

	/// <summary>
	/// Set the scalar type of the output.  Default is float.
	/// Floating-point output is used to avoid overflow, since the
	/// range of the output values is larger than the input values.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkImageBSplineCoefficients_GetOutputScalarType_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBSplineCoefficients_GetOutputScalarTypeAsString_15(HandleRef pThis);

	/// <summary>
	/// Set the scalar type of the output.  Default is float.
	/// Floating-point output is used to avoid overflow, since the
	/// range of the output values is larger than the input values.
	/// </summary>
	public string GetOutputScalarTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageBSplineCoefficients_GetOutputScalarTypeAsString_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_GetOutputScalarTypeMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set the scalar type of the output.  Default is float.
	/// Floating-point output is used to avoid overflow, since the
	/// range of the output values is larger than the input values.
	/// </summary>
	public virtual int GetOutputScalarTypeMaxValue()
	{
		return vtkImageBSplineCoefficients_GetOutputScalarTypeMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_GetOutputScalarTypeMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set the scalar type of the output.  Default is float.
	/// Floating-point output is used to avoid overflow, since the
	/// range of the output values is larger than the input values.
	/// </summary>
	public virtual int GetOutputScalarTypeMinValue()
	{
		return vtkImageBSplineCoefficients_GetOutputScalarTypeMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_GetSplineDegree_18(HandleRef pThis);

	/// <summary>
	/// Set the degree of the spline polynomial.  The default value is 3,
	/// and the maximum is 9.
	/// </summary>
	public virtual int GetSplineDegree()
	{
		return vtkImageBSplineCoefficients_GetSplineDegree_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_GetSplineDegreeMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set the degree of the spline polynomial.  The default value is 3,
	/// and the maximum is 9.
	/// </summary>
	public virtual int GetSplineDegreeMaxValue()
	{
		return vtkImageBSplineCoefficients_GetSplineDegreeMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_GetSplineDegreeMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set the degree of the spline polynomial.  The default value is 3,
	/// and the maximum is 9.
	/// </summary>
	public virtual int GetSplineDegreeMinValue()
	{
		return vtkImageBSplineCoefficients_GetSplineDegreeMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageBSplineCoefficients_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBSplineCoefficients_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageBSplineCoefficients_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBSplineCoefficients_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageBSplineCoefficients NewInstance()
	{
		vtkImageBSplineCoefficients result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBSplineCoefficients_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageBSplineCoefficients)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBSplineCoefficients_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageBSplineCoefficients SafeDownCast(vtkObjectBase o)
	{
		vtkImageBSplineCoefficients vtkImageBSplineCoefficients2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBSplineCoefficients_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageBSplineCoefficients2 = (vtkImageBSplineCoefficients)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageBSplineCoefficients2.Register(null);
			}
		}
		return vtkImageBSplineCoefficients2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_SetBorderMode_26(HandleRef pThis, vtkImageBorderMode _arg);

	/// <summary>
	/// Set the border mode.  The filter that is used to create the
	/// coefficients must repeat the image somehow to make a theoritically
	/// infinite input.  The default is to clamp values that are off the
	/// edge of the image, to the value at the closest point on the edge.
	/// The other ways of virtually extending the image are to produce
	/// mirrored copies, which results in optimal smoothness at the boundary,
	/// or to repeat the image, which results in a cyclic or periodic spline.
	/// </summary>
	public virtual void SetBorderMode(vtkImageBorderMode _arg)
	{
		vtkImageBSplineCoefficients_SetBorderMode_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_SetBorderModeToClamp_27(HandleRef pThis);

	/// <summary>
	/// Set the border mode.  The filter that is used to create the
	/// coefficients must repeat the image somehow to make a theoritically
	/// infinite input.  The default is to clamp values that are off the
	/// edge of the image, to the value at the closest point on the edge.
	/// The other ways of virtually extending the image are to produce
	/// mirrored copies, which results in optimal smoothness at the boundary,
	/// or to repeat the image, which results in a cyclic or periodic spline.
	/// </summary>
	public void SetBorderModeToClamp()
	{
		vtkImageBSplineCoefficients_SetBorderModeToClamp_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_SetBorderModeToMirror_28(HandleRef pThis);

	/// <summary>
	/// Set the border mode.  The filter that is used to create the
	/// coefficients must repeat the image somehow to make a theoritically
	/// infinite input.  The default is to clamp values that are off the
	/// edge of the image, to the value at the closest point on the edge.
	/// The other ways of virtually extending the image are to produce
	/// mirrored copies, which results in optimal smoothness at the boundary,
	/// or to repeat the image, which results in a cyclic or periodic spline.
	/// </summary>
	public void SetBorderModeToMirror()
	{
		vtkImageBSplineCoefficients_SetBorderModeToMirror_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_SetBorderModeToRepeat_29(HandleRef pThis);

	/// <summary>
	/// Set the border mode.  The filter that is used to create the
	/// coefficients must repeat the image somehow to make a theoritically
	/// infinite input.  The default is to clamp values that are off the
	/// edge of the image, to the value at the closest point on the edge.
	/// The other ways of virtually extending the image are to produce
	/// mirrored copies, which results in optimal smoothness at the boundary,
	/// or to repeat the image, which results in a cyclic or periodic spline.
	/// </summary>
	public void SetBorderModeToRepeat()
	{
		vtkImageBSplineCoefficients_SetBorderModeToRepeat_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_SetBypass_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Bypass the filter, do not do any processing.  If this is on,
	/// then the output data will reference the input data directly,
	/// and the output type will be the same as the input type.  This
	/// is useful a downstream filter sometimes uses b-spline interpolation
	/// and sometimes uses other forms of interpolation.
	/// </summary>
	public virtual void SetBypass(int _arg)
	{
		vtkImageBSplineCoefficients_SetBypass_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_SetOutputScalarType_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the scalar type of the output.  Default is float.
	/// Floating-point output is used to avoid overflow, since the
	/// range of the output values is larger than the input values.
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkImageBSplineCoefficients_SetOutputScalarType_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_SetOutputScalarTypeToDouble_32(HandleRef pThis);

	/// <summary>
	/// Set the scalar type of the output.  Default is float.
	/// Floating-point output is used to avoid overflow, since the
	/// range of the output values is larger than the input values.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkImageBSplineCoefficients_SetOutputScalarTypeToDouble_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_SetOutputScalarTypeToFloat_33(HandleRef pThis);

	/// <summary>
	/// Set the scalar type of the output.  Default is float.
	/// Floating-point output is used to avoid overflow, since the
	/// range of the output values is larger than the input values.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkImageBSplineCoefficients_SetOutputScalarTypeToFloat_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBSplineCoefficients_SetSplineDegree_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the degree of the spline polynomial.  The default value is 3,
	/// and the maximum is 9.
	/// </summary>
	public virtual void SetSplineDegree(int _arg)
	{
		vtkImageBSplineCoefficients_SetSplineDegree_34(GetCppThis(), _arg);
	}
}
