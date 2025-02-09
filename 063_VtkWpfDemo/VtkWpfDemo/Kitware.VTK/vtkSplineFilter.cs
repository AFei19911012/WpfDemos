using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSplineFilter
/// </summary>
/// <remarks>
///    generate uniformly subdivided polylines from a set of input polyline using a vtkSpline
///
/// vtkSplineFilter is a filter that generates an output polylines from an
/// input set of polylines. The polylines are uniformly subdivided and produced
/// with the help of a vtkSpline class that the user can specify (by default a
/// vtkCardinalSpline is used). The number of subdivisions of the line can be
/// controlled in several ways. The user can either specify the number of
/// subdivisions or a length of each subdivision can be provided (and the
/// class will figure out how many subdivisions is required over the whole
/// polyline). The maximum number of subdivisions can also be set.
///
/// The output of this filter is a polyline per input polyline (or line). New
/// points and texture coordinates are created. Point data is interpolated and
/// cell data passed on. Any polylines with less than two points, or who have
/// coincident points, are ignored.
///
/// </remarks>
/// <seealso>
///
/// vtkRibbonFilter vtkTubeFilter
/// </seealso>
public class vtkSplineFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSplineFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSplineFilter()
	{
		MRClassNameKey = "class vtkSplineFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSplineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct the class with no limit on the number of subdivisions
	/// and using an instance of vtkCardinalSpline to perform interpolation.
	/// </summary>
	public new static vtkSplineFilter New()
	{
		vtkSplineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct the class with no limit on the number of subdivisions
	/// and using an instance of vtkCardinalSpline to perform interpolation.
	/// </summary>
	public vtkSplineFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSplineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSplineFilter_GetGenerateTCoords_01(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the output polyline. The texture coordinates
	/// can be generated in three ways: a normalized (0,1) generation;
	/// based on the length (divided by the texture length); and by using
	/// the input scalar values.
	/// </summary>
	public virtual int GetGenerateTCoords()
	{
		return vtkSplineFilter_GetGenerateTCoords_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineFilter_GetGenerateTCoordsAsString_02(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the output polyline. The texture coordinates
	/// can be generated in three ways: a normalized (0,1) generation;
	/// based on the length (divided by the texture length); and by using
	/// the input scalar values.
	/// </summary>
	public string GetGenerateTCoordsAsString()
	{
		return Marshal.PtrToStringAnsi(vtkSplineFilter_GetGenerateTCoordsAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetGenerateTCoordsMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the output polyline. The texture coordinates
	/// can be generated in three ways: a normalized (0,1) generation;
	/// based on the length (divided by the texture length); and by using
	/// the input scalar values.
	/// </summary>
	public virtual int GetGenerateTCoordsMaxValue()
	{
		return vtkSplineFilter_GetGenerateTCoordsMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetGenerateTCoordsMinValue_04(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the output polyline. The texture coordinates
	/// can be generated in three ways: a normalized (0,1) generation;
	/// based on the length (divided by the texture length); and by using
	/// the input scalar values.
	/// </summary>
	public virtual int GetGenerateTCoordsMinValue()
	{
		return vtkSplineFilter_GetGenerateTCoordsMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSplineFilter_GetLength_05(HandleRef pThis);

	/// <summary>
	/// Control the number of subdivisions that are created for the
	/// polyline based on an absolute length. The length of the spline
	/// is divided by this length to determine the number of subdivisions.
	/// </summary>
	public virtual double GetLength()
	{
		return vtkSplineFilter_GetLength_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSplineFilter_GetLengthMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Control the number of subdivisions that are created for the
	/// polyline based on an absolute length. The length of the spline
	/// is divided by this length to determine the number of subdivisions.
	/// </summary>
	public virtual double GetLengthMaxValue()
	{
		return vtkSplineFilter_GetLengthMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSplineFilter_GetLengthMinValue_07(HandleRef pThis);

	/// <summary>
	/// Control the number of subdivisions that are created for the
	/// polyline based on an absolute length. The length of the spline
	/// is divided by this length to determine the number of subdivisions.
	/// </summary>
	public virtual double GetLengthMinValue()
	{
		return vtkSplineFilter_GetLengthMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetMaximumNumberOfSubdivisions_08(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of subdivisions that are created for each
	/// polyline.
	/// </summary>
	public virtual int GetMaximumNumberOfSubdivisions()
	{
		return vtkSplineFilter_GetMaximumNumberOfSubdivisions_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetMaximumNumberOfSubdivisionsMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of subdivisions that are created for each
	/// polyline.
	/// </summary>
	public virtual int GetMaximumNumberOfSubdivisionsMaxValue()
	{
		return vtkSplineFilter_GetMaximumNumberOfSubdivisionsMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetMaximumNumberOfSubdivisionsMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of subdivisions that are created for each
	/// polyline.
	/// </summary>
	public virtual int GetMaximumNumberOfSubdivisionsMinValue()
	{
		return vtkSplineFilter_GetMaximumNumberOfSubdivisionsMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplineFilter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSplineFilter_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplineFilter_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSplineFilter_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetNumberOfSubdivisions_13(HandleRef pThis);

	/// <summary>
	/// Set the number of subdivisions that are created for the
	/// polyline. This method only has effect if Subdivisions is set
	/// to SetSubdivisionsToSpecify().
	/// </summary>
	public virtual int GetNumberOfSubdivisions()
	{
		return vtkSplineFilter_GetNumberOfSubdivisions_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetNumberOfSubdivisionsMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set the number of subdivisions that are created for the
	/// polyline. This method only has effect if Subdivisions is set
	/// to SetSubdivisionsToSpecify().
	/// </summary>
	public virtual int GetNumberOfSubdivisionsMaxValue()
	{
		return vtkSplineFilter_GetNumberOfSubdivisionsMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetNumberOfSubdivisionsMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set the number of subdivisions that are created for the
	/// polyline. This method only has effect if Subdivisions is set
	/// to SetSubdivisionsToSpecify().
	/// </summary>
	public virtual int GetNumberOfSubdivisionsMinValue()
	{
		return vtkSplineFilter_GetNumberOfSubdivisionsMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineFilter_GetSpline_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an instance of vtkSpline to use to perform the interpolation.
	/// </summary>
	public virtual vtkSpline GetSpline()
	{
		vtkSpline vtkSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineFilter_GetSpline_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpline2 = (vtkSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpline2.Register(null);
			}
		}
		return vtkSpline2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetSubdivide_17(HandleRef pThis);

	/// <summary>
	/// Specify how the number of subdivisions is determined.
	/// </summary>
	public virtual int GetSubdivide()
	{
		return vtkSplineFilter_GetSubdivide_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineFilter_GetSubdivideAsString_18(HandleRef pThis);

	/// <summary>
	/// Specify how the number of subdivisions is determined.
	/// </summary>
	public string GetSubdivideAsString()
	{
		return Marshal.PtrToStringAnsi(vtkSplineFilter_GetSubdivideAsString_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetSubdivideMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Specify how the number of subdivisions is determined.
	/// </summary>
	public virtual int GetSubdivideMaxValue()
	{
		return vtkSplineFilter_GetSubdivideMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_GetSubdivideMinValue_20(HandleRef pThis);

	/// <summary>
	/// Specify how the number of subdivisions is determined.
	/// </summary>
	public virtual int GetSubdivideMinValue()
	{
		return vtkSplineFilter_GetSubdivideMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSplineFilter_GetTextureLength_21(HandleRef pThis);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space.
	/// </summary>
	public virtual double GetTextureLength()
	{
		return vtkSplineFilter_GetTextureLength_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSplineFilter_GetTextureLengthMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space.
	/// </summary>
	public virtual double GetTextureLengthMaxValue()
	{
		return vtkSplineFilter_GetTextureLengthMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSplineFilter_GetTextureLengthMinValue_23(HandleRef pThis);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space.
	/// </summary>
	public virtual double GetTextureLengthMinValue()
	{
		return vtkSplineFilter_GetTextureLengthMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSplineFilter_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineFilter_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSplineFilter_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineFilter_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSplineFilter NewInstance()
	{
		vtkSplineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineFilter_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineFilter_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSplineFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSplineFilter vtkSplineFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineFilter_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSplineFilter2 = (vtkSplineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSplineFilter2.Register(null);
			}
		}
		return vtkSplineFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetGenerateTCoords_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the output polyline. The texture coordinates
	/// can be generated in three ways: a normalized (0,1) generation;
	/// based on the length (divided by the texture length); and by using
	/// the input scalar values.
	/// </summary>
	public virtual void SetGenerateTCoords(int _arg)
	{
		vtkSplineFilter_SetGenerateTCoords_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetGenerateTCoordsToNormalizedLength_30(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the output polyline. The texture coordinates
	/// can be generated in three ways: a normalized (0,1) generation;
	/// based on the length (divided by the texture length); and by using
	/// the input scalar values.
	/// </summary>
	public void SetGenerateTCoordsToNormalizedLength()
	{
		vtkSplineFilter_SetGenerateTCoordsToNormalizedLength_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetGenerateTCoordsToOff_31(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the output polyline. The texture coordinates
	/// can be generated in three ways: a normalized (0,1) generation;
	/// based on the length (divided by the texture length); and by using
	/// the input scalar values.
	/// </summary>
	public void SetGenerateTCoordsToOff()
	{
		vtkSplineFilter_SetGenerateTCoordsToOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetGenerateTCoordsToUseLength_32(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the output polyline. The texture coordinates
	/// can be generated in three ways: a normalized (0,1) generation;
	/// based on the length (divided by the texture length); and by using
	/// the input scalar values.
	/// </summary>
	public void SetGenerateTCoordsToUseLength()
	{
		vtkSplineFilter_SetGenerateTCoordsToUseLength_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetGenerateTCoordsToUseScalars_33(HandleRef pThis);

	/// <summary>
	/// Control whether and how texture coordinates are produced. This is
	/// useful for striping the output polyline. The texture coordinates
	/// can be generated in three ways: a normalized (0,1) generation;
	/// based on the length (divided by the texture length); and by using
	/// the input scalar values.
	/// </summary>
	public void SetGenerateTCoordsToUseScalars()
	{
		vtkSplineFilter_SetGenerateTCoordsToUseScalars_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetLength_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Control the number of subdivisions that are created for the
	/// polyline based on an absolute length. The length of the spline
	/// is divided by this length to determine the number of subdivisions.
	/// </summary>
	public virtual void SetLength(double _arg)
	{
		vtkSplineFilter_SetLength_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetMaximumNumberOfSubdivisions_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the maximum number of subdivisions that are created for each
	/// polyline.
	/// </summary>
	public virtual void SetMaximumNumberOfSubdivisions(int _arg)
	{
		vtkSplineFilter_SetMaximumNumberOfSubdivisions_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetNumberOfSubdivisions_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of subdivisions that are created for the
	/// polyline. This method only has effect if Subdivisions is set
	/// to SetSubdivisionsToSpecify().
	/// </summary>
	public virtual void SetNumberOfSubdivisions(int _arg)
	{
		vtkSplineFilter_SetNumberOfSubdivisions_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetSpline_37(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify an instance of vtkSpline to use to perform the interpolation.
	/// </summary>
	public virtual void SetSpline(vtkSpline arg0)
	{
		vtkSplineFilter_SetSpline_37(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetSubdivide_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify how the number of subdivisions is determined.
	/// </summary>
	public virtual void SetSubdivide(int _arg)
	{
		vtkSplineFilter_SetSubdivide_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetSubdivideToLength_39(HandleRef pThis);

	/// <summary>
	/// Specify how the number of subdivisions is determined.
	/// </summary>
	public void SetSubdivideToLength()
	{
		vtkSplineFilter_SetSubdivideToLength_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetSubdivideToSpecified_40(HandleRef pThis);

	/// <summary>
	/// Specify how the number of subdivisions is determined.
	/// </summary>
	public void SetSubdivideToSpecified()
	{
		vtkSplineFilter_SetSubdivideToSpecified_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineFilter_SetTextureLength_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Control the conversion of units during the texture coordinates
	/// calculation. The TextureLength indicates what length (whether
	/// calculated from scalars or length) is mapped to the [0,1)
	/// texture space.
	/// </summary>
	public virtual void SetTextureLength(double _arg)
	{
		vtkSplineFilter_SetTextureLength_41(GetCppThis(), _arg);
	}
}
