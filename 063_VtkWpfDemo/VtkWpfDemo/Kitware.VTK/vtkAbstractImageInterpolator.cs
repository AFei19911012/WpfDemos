using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractImageInterpolator
/// </summary>
/// <remarks>
///    interpolate data values from images
///
/// vtkAbstractImageInterpolator provides an abstract interface for
/// interpolating image data.  You specify the data set you want to
/// interpolate values from, then call Interpolate(x,y,z) to interpolate
/// the data.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
/// <seealso>
///
/// vtkImageReslice vtkImageInterpolator vtkImageSincInterpolator
/// </seealso>
public abstract class vtkAbstractImageInterpolator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractImageInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractImageInterpolator()
	{
		MRClassNameKey = "class vtkAbstractImageInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractImageInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractImageInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractImageInterpolator_CheckBoundsIJK_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Check an x,y,z point to see if it is within the bounds for the
	/// structured coords of the image.  This is meant to be called prior
	/// to InterpolateIJK.  The bounds that are checked against are the input
	/// image extent plus the tolerance.
	/// </summary>
	public bool CheckBoundsIJK(IntPtr x)
	{
		return (vtkAbstractImageInterpolator_CheckBoundsIJK_01(GetCppThis(), x) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractImageInterpolator_ComputeNumberOfComponents_02(HandleRef pThis, int inputComponents);

	/// <summary>
	/// Compute the number of output components based on the ComponentOffset,
	/// ComponentCount, and the number of components in the input data.
	/// </summary>
	public int ComputeNumberOfComponents(int inputComponents)
	{
		return vtkAbstractImageInterpolator_ComputeNumberOfComponents_02(GetCppThis(), inputComponents);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_ComputeSupportSize_03(HandleRef pThis, IntPtr matrix, IntPtr support);

	/// <summary>
	/// Get the support size for use in computing update extents.  If the data
	/// will be sampled on a regular grid, then pass a matrix describing the
	/// structured coordinate transformation between the output and the input.
	/// Otherwise, pass nullptr as the matrix to retrieve the full kernel size.
	/// </summary>
	public virtual void ComputeSupportSize(IntPtr matrix, IntPtr support)
	{
		vtkAbstractImageInterpolator_ComputeSupportSize_03(GetCppThis(), matrix, support);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_DeepCopy_04(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// Copy the interpolator.  It is possible to duplicate an interpolator
	/// by calling NewInstance() followed by DeepCopy().
	/// </summary>
	public void DeepCopy(vtkAbstractImageInterpolator obj)
	{
		vtkAbstractImageInterpolator_DeepCopy_04(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkImageBorderMode vtkAbstractImageInterpolator_GetBorderMode_05(HandleRef pThis);

	/// <summary>
	/// The border mode (default: clamp).  This controls how out-of-bounds
	/// lookups are handled, i.e. how data will be extrapolated beyond the
	/// bounds of the image.  The default is to clamp the lookup point to the
	/// bounds.  The other modes wrap around to the opposite boundary, or
	/// mirror the image at the boundary.
	/// </summary>
	public vtkImageBorderMode GetBorderMode()
	{
		return vtkAbstractImageInterpolator_GetBorderMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractImageInterpolator_GetBorderModeAsString_06(HandleRef pThis);

	/// <summary>
	/// The border mode (default: clamp).  This controls how out-of-bounds
	/// lookups are handled, i.e. how data will be extrapolated beyond the
	/// bounds of the image.  The default is to clamp the lookup point to the
	/// bounds.  The other modes wrap around to the opposite boundary, or
	/// mirror the image at the boundary.
	/// </summary>
	public string GetBorderModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkAbstractImageInterpolator_GetBorderModeAsString_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractImageInterpolator_GetComponentCount_07(HandleRef pThis);

	/// <summary>
	/// This method specifies the number of components to extract.  The default
	/// value is -1, which extracts all available components.  When the
	/// interpolation is performed, this will be clamped to the number of
	/// available components.
	/// </summary>
	public int GetComponentCount()
	{
		return vtkAbstractImageInterpolator_GetComponentCount_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractImageInterpolator_GetComponentOffset_08(HandleRef pThis);

	/// <summary>
	/// This method specifies which component of the input will be interpolated,
	/// or if ComponentCount is also set, it specifies the first component.
	/// When the interpolation is performed, it will be clamped to the number
	/// of available components.
	/// </summary>
	public int GetComponentOffset()
	{
		return vtkAbstractImageInterpolator_GetComponentOffset_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractImageInterpolator_GetExtent_09(HandleRef pThis);

	/// <summary>
	/// Get the extent of the data being interpolated.
	/// </summary>
	public virtual int[] GetExtent()
	{
		IntPtr intPtr = vtkAbstractImageInterpolator_GetExtent_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_GetExtent_10(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Get the extent of the data being interpolated.
	/// </summary>
	public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkAbstractImageInterpolator_GetExtent_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_GetExtent_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the extent of the data being interpolated.
	/// </summary>
	public virtual void GetExtent(IntPtr _arg)
	{
		vtkAbstractImageInterpolator_GetExtent_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractImageInterpolator_GetNumberOfComponents_12(HandleRef pThis);

	/// <summary>
	/// Get the number of components that will be returned when Interpolate()
	/// is called.  This is only valid after initialization.  Before then, use
	/// ComputeNumberOfComponents instead.
	/// </summary>
	public int GetNumberOfComponents()
	{
		return vtkAbstractImageInterpolator_GetNumberOfComponents_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractImageInterpolator_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractImageInterpolator_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractImageInterpolator_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractImageInterpolator_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractImageInterpolator_GetOrigin_15(HandleRef pThis);

	/// <summary>
	/// Get the origin of the data being interpolated.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkAbstractImageInterpolator_GetOrigin_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_GetOrigin_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the origin of the data being interpolated.
	/// </summary>
	public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAbstractImageInterpolator_GetOrigin_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_GetOrigin_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the origin of the data being interpolated.
	/// </summary>
	public virtual void GetOrigin(IntPtr _arg)
	{
		vtkAbstractImageInterpolator_GetOrigin_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAbstractImageInterpolator_GetOutValue_18(HandleRef pThis);

	/// <summary>
	/// The value to return when the point is out of bounds.
	/// </summary>
	public double GetOutValue()
	{
		return vtkAbstractImageInterpolator_GetOutValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractImageInterpolator_GetSlidingWindow_19(HandleRef pThis);

	/// <summary>
	/// Enable sliding window for separable kernels.
	/// When this is enabled, the interpolator will cache partial sums in
	/// in order to accelerate the computation.  It only makes sense to do
	/// this if the interpolator is used by calling InterpolateRow() while
	/// incrementing first the Y, and then the Z index with every call.
	/// </summary>
	public bool GetSlidingWindow()
	{
		return (vtkAbstractImageInterpolator_GetSlidingWindow_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractImageInterpolator_GetSpacing_20(HandleRef pThis);

	/// <summary>
	/// Get the spacing of the data being interpolated.
	/// </summary>
	public virtual double[] GetSpacing()
	{
		IntPtr intPtr = vtkAbstractImageInterpolator_GetSpacing_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_GetSpacing_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the spacing of the data being interpolated.
	/// </summary>
	public virtual void GetSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAbstractImageInterpolator_GetSpacing_21(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_GetSpacing_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the spacing of the data being interpolated.
	/// </summary>
	public virtual void GetSpacing(IntPtr _arg)
	{
		vtkAbstractImageInterpolator_GetSpacing_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAbstractImageInterpolator_GetTolerance_23(HandleRef pThis);

	/// <summary>
	/// The tolerance to apply when checking whether a point is out of bounds.
	/// This is a fractional distance relative to the voxel size, so a tolerance
	/// of 1 expands the bounds by one voxel.
	/// </summary>
	public double GetTolerance()
	{
		return vtkAbstractImageInterpolator_GetTolerance_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_Initialize_24(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Initialize the interpolator with the data that you wish to interpolate.
	/// </summary>
	public virtual void Initialize(vtkDataObject data)
	{
		vtkAbstractImageInterpolator_Initialize_24(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAbstractImageInterpolator_Interpolate_25(HandleRef pThis, double x, double y, double z, int component);

	/// <summary>
	/// Get the result of interpolating the specified component of the input
	/// data, which should be set to zero if there is only one component.
	/// If the point is not within the bounds of the data set, then OutValue
	/// will be returned.  This method is primarily meant for use by the
	/// wrapper languages.
	/// </summary>
	public double Interpolate(double x, double y, double z, int component)
	{
		return vtkAbstractImageInterpolator_Interpolate_25(GetCppThis(), x, y, z, component);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractImageInterpolator_Interpolate_26(HandleRef pThis, IntPtr point, IntPtr value);

	/// <summary>
	/// Sample the input data. This is an inline method that calls the
	/// function that performs the appropriate interpolation for the
	/// data type.  If the point is not within the bounds of the data set,
	/// then the return value is false, and each component will be set to
	/// the OutValue.
	/// </summary>
	public bool Interpolate(IntPtr point, IntPtr value)
	{
		return (vtkAbstractImageInterpolator_Interpolate_26(GetCppThis(), point, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_InterpolateIJK_27(HandleRef pThis, IntPtr point, IntPtr value);

	/// <summary>
	/// A version of Interpolate that takes structured coords instead of data
	/// coords.  Structured coords are the data coords after subtracting the
	/// Origin and dividing by the Spacing.
	/// </summary>
	public void InterpolateIJK(IntPtr point, IntPtr value)
	{
		vtkAbstractImageInterpolator_InterpolateIJK_27(GetCppThis(), point, value);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractImageInterpolator_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractImageInterpolator_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractImageInterpolator_IsSeparable_29(HandleRef pThis);

	/// <summary>
	/// True if the interpolation is separable, which means that the weights
	/// can be precomputed in order to accelerate the interpolation.  Any
	/// interpolator which is separable will implement the methods
	/// PrecomputeWeightsForExtent and InterpolateRow
	/// </summary>
	public virtual bool IsSeparable()
	{
		return (vtkAbstractImageInterpolator_IsSeparable_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractImageInterpolator_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractImageInterpolator_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractImageInterpolator_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractImageInterpolator NewInstance()
	{
		vtkAbstractImageInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractImageInterpolator_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractImageInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_ReleaseData_32(HandleRef pThis);

	/// <summary>
	/// Release any data stored by the interpolator.
	/// </summary>
	public virtual void ReleaseData()
	{
		vtkAbstractImageInterpolator_ReleaseData_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractImageInterpolator_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractImageInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractImageInterpolator vtkAbstractImageInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractImageInterpolator_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractImageInterpolator2 = (vtkAbstractImageInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractImageInterpolator2.Register(null);
			}
		}
		return vtkAbstractImageInterpolator2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SetBorderMode_34(HandleRef pThis, vtkImageBorderMode mode);

	/// <summary>
	/// The border mode (default: clamp).  This controls how out-of-bounds
	/// lookups are handled, i.e. how data will be extrapolated beyond the
	/// bounds of the image.  The default is to clamp the lookup point to the
	/// bounds.  The other modes wrap around to the opposite boundary, or
	/// mirror the image at the boundary.
	/// </summary>
	public void SetBorderMode(vtkImageBorderMode mode)
	{
		vtkAbstractImageInterpolator_SetBorderMode_34(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SetBorderModeToClamp_35(HandleRef pThis);

	/// <summary>
	/// The border mode (default: clamp).  This controls how out-of-bounds
	/// lookups are handled, i.e. how data will be extrapolated beyond the
	/// bounds of the image.  The default is to clamp the lookup point to the
	/// bounds.  The other modes wrap around to the opposite boundary, or
	/// mirror the image at the boundary.
	/// </summary>
	public void SetBorderModeToClamp()
	{
		vtkAbstractImageInterpolator_SetBorderModeToClamp_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SetBorderModeToMirror_36(HandleRef pThis);

	/// <summary>
	/// The border mode (default: clamp).  This controls how out-of-bounds
	/// lookups are handled, i.e. how data will be extrapolated beyond the
	/// bounds of the image.  The default is to clamp the lookup point to the
	/// bounds.  The other modes wrap around to the opposite boundary, or
	/// mirror the image at the boundary.
	/// </summary>
	public void SetBorderModeToMirror()
	{
		vtkAbstractImageInterpolator_SetBorderModeToMirror_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SetBorderModeToRepeat_37(HandleRef pThis);

	/// <summary>
	/// The border mode (default: clamp).  This controls how out-of-bounds
	/// lookups are handled, i.e. how data will be extrapolated beyond the
	/// bounds of the image.  The default is to clamp the lookup point to the
	/// bounds.  The other modes wrap around to the opposite boundary, or
	/// mirror the image at the boundary.
	/// </summary>
	public void SetBorderModeToRepeat()
	{
		vtkAbstractImageInterpolator_SetBorderModeToRepeat_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SetComponentCount_38(HandleRef pThis, int count);

	/// <summary>
	/// This method specifies the number of components to extract.  The default
	/// value is -1, which extracts all available components.  When the
	/// interpolation is performed, this will be clamped to the number of
	/// available components.
	/// </summary>
	public void SetComponentCount(int count)
	{
		vtkAbstractImageInterpolator_SetComponentCount_38(GetCppThis(), count);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SetComponentOffset_39(HandleRef pThis, int offset);

	/// <summary>
	/// This method specifies which component of the input will be interpolated,
	/// or if ComponentCount is also set, it specifies the first component.
	/// When the interpolation is performed, it will be clamped to the number
	/// of available components.
	/// </summary>
	public void SetComponentOffset(int offset)
	{
		vtkAbstractImageInterpolator_SetComponentOffset_39(GetCppThis(), offset);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SetOutValue_40(HandleRef pThis, double outValue);

	/// <summary>
	/// The value to return when the point is out of bounds.
	/// </summary>
	public void SetOutValue(double outValue)
	{
		vtkAbstractImageInterpolator_SetOutValue_40(GetCppThis(), outValue);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SetSlidingWindow_41(HandleRef pThis, byte x);

	/// <summary>
	/// Enable sliding window for separable kernels.
	/// When this is enabled, the interpolator will cache partial sums in
	/// in order to accelerate the computation.  It only makes sense to do
	/// this if the interpolator is used by calling InterpolateRow() while
	/// incrementing first the Y, and then the Z index with every call.
	/// </summary>
	public void SetSlidingWindow(bool x)
	{
		vtkAbstractImageInterpolator_SetSlidingWindow_41(GetCppThis(), (byte)(x ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SetTolerance_42(HandleRef pThis, double tol);

	/// <summary>
	/// The tolerance to apply when checking whether a point is out of bounds.
	/// This is a fractional distance relative to the voxel size, so a tolerance
	/// of 1 expands the bounds by one voxel.
	/// </summary>
	public void SetTolerance(double tol)
	{
		vtkAbstractImageInterpolator_SetTolerance_42(GetCppThis(), tol);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SlidingWindowOff_43(HandleRef pThis);

	/// <summary>
	/// Enable sliding window for separable kernels.
	/// When this is enabled, the interpolator will cache partial sums in
	/// in order to accelerate the computation.  It only makes sense to do
	/// this if the interpolator is used by calling InterpolateRow() while
	/// incrementing first the Y, and then the Z index with every call.
	/// </summary>
	public void SlidingWindowOff()
	{
		vtkAbstractImageInterpolator_SlidingWindowOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_SlidingWindowOn_44(HandleRef pThis);

	/// <summary>
	/// Enable sliding window for separable kernels.
	/// When this is enabled, the interpolator will cache partial sums in
	/// in order to accelerate the computation.  It only makes sense to do
	/// this if the interpolator is used by calling InterpolateRow() while
	/// incrementing first the Y, and then the Z index with every call.
	/// </summary>
	public void SlidingWindowOn()
	{
		vtkAbstractImageInterpolator_SlidingWindowOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractImageInterpolator_Update_45(HandleRef pThis);

	/// <summary>
	/// Update the interpolator.  If the interpolator has been modified by
	/// a Set method since Initialize() was called, you must call this method
	/// to update the interpolator before you can use it.
	/// </summary>
	public virtual void Update()
	{
		vtkAbstractImageInterpolator_Update_45(GetCppThis());
	}
}
