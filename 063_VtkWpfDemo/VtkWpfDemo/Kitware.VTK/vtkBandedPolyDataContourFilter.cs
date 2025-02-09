using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBandedPolyDataContourFilter
/// </summary>
/// <remarks>
///    generate filled contours for vtkPolyData
///
/// vtkBandedPolyDataContourFilter is a filter that takes as input vtkPolyData
/// and produces as output filled contours (also represented as vtkPolyData).
/// Filled contours are bands of cells that all have the same cell scalar
/// value, and can therefore be colored the same. The method is also referred
/// to as filled contour generation.
///
/// To use this filter you must specify one or more contour values.  You can
/// either use the method SetValue() to specify each contour value, or use
/// GenerateValues() to generate a series of evenly spaced contours.  Each
/// contour value divides (or clips) the data into two pieces, values below
/// the contour value, and values above it. The scalar values of each
/// band correspond to the specified contour value.  Note that if the first and
/// last contour values are not the minimum/maximum contour range, then two
/// extra contour values are added corresponding to the minimum and maximum
/// range values. These extra contour bands can be prevented from being output
/// by turning clipping on.
///
/// </remarks>
/// <seealso>
///
/// vtkClipDataSet vtkClipPolyData vtkClipVolume vtkContourFilter
///
/// </seealso>
public class vtkBandedPolyDataContourFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBandedPolyDataContourFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBandedPolyDataContourFilter()
	{
		MRClassNameKey = "class vtkBandedPolyDataContourFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBandedPolyDataContourFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBandedPolyDataContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBandedPolyDataContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with no contours defined.
	/// </summary>
	public new static vtkBandedPolyDataContourFilter New()
	{
		vtkBandedPolyDataContourFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBandedPolyDataContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBandedPolyDataContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with no contours defined.
	/// </summary>
	public vtkBandedPolyDataContourFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBandedPolyDataContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_ClippingOff_01(HandleRef pThis);

	/// <summary>
	/// Indicate whether to clip outside the range specified by the user.
	/// (The range is contour value[0] to contour value[numContours-1].)
	/// Clipping means all cells outside of the range specified are not
	/// sent to the output.
	/// </summary>
	public virtual void ClippingOff()
	{
		vtkBandedPolyDataContourFilter_ClippingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_ClippingOn_02(HandleRef pThis);

	/// <summary>
	/// Indicate whether to clip outside the range specified by the user.
	/// (The range is contour value[0] to contour value[numContours-1].)
	/// Clipping means all cells outside of the range specified are not
	/// sent to the output.
	/// </summary>
	public virtual void ClippingOn()
	{
		vtkBandedPolyDataContourFilter_ClippingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_GenerateContourEdgesOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag to control whether contour edges are generated.
	/// Contour edges are the edges between bands. If enabled, they are
	/// generated from polygons/triangle strips and placed into the second
	/// output (the ContourEdgesOutput).
	/// </summary>
	public virtual void GenerateContourEdgesOff()
	{
		vtkBandedPolyDataContourFilter_GenerateContourEdgesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_GenerateContourEdgesOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag to control whether contour edges are generated.
	/// Contour edges are the edges between bands. If enabled, they are
	/// generated from polygons/triangle strips and placed into the second
	/// output (the ContourEdgesOutput).
	/// </summary>
	public virtual void GenerateContourEdgesOn()
	{
		vtkBandedPolyDataContourFilter_GenerateContourEdgesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_GenerateValues_05(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Methods to set / get contour values. A single value at a time can be
	/// set with SetValue(). Multiple contour values can be set with
	/// GenerateValues(). Note that GenerateValues() generates n values
	/// inclusive of the start and end range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkBandedPolyDataContourFilter_GenerateValues_05(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_GenerateValues_06(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Methods to set / get contour values. A single value at a time can be
	/// set with SetValue(). Multiple contour values can be set with
	/// GenerateValues(). Note that GenerateValues() generates n values
	/// inclusive of the start and end range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkBandedPolyDataContourFilter_GenerateValues_06(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBandedPolyDataContourFilter_GetClipTolerance_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the clip tolerance. Warning: setting this too large will
	/// certainly cause numerical issues. Change from the default value
	/// of FLT_EPSILON at your own risk. The actual internal clip tolerance
	/// is computed by multiplying ClipTolerance by the scalar range.
	/// </summary>
	public virtual double GetClipTolerance()
	{
		return vtkBandedPolyDataContourFilter_GetClipTolerance_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandedPolyDataContourFilter_GetClipping_08(HandleRef pThis);

	/// <summary>
	/// Indicate whether to clip outside the range specified by the user.
	/// (The range is contour value[0] to contour value[numContours-1].)
	/// Clipping means all cells outside of the range specified are not
	/// sent to the output.
	/// </summary>
	public virtual int GetClipping()
	{
		return vtkBandedPolyDataContourFilter_GetClipping_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandedPolyDataContourFilter_GetComponent_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the component to use of an input scalars array with more than one
	/// component. Default is 0.
	/// </summary>
	public virtual int GetComponent()
	{
		return vtkBandedPolyDataContourFilter_GetComponent_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBandedPolyDataContourFilter_GetContourEdgesOutput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the second output which contains the edges dividing the contour
	/// bands. This output is empty unless GenerateContourEdges is enabled.
	/// </summary>
	public vtkPolyData GetContourEdgesOutput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBandedPolyDataContourFilter_GetContourEdgesOutput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandedPolyDataContourFilter_GetGenerateContourEdges_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag to control whether contour edges are generated.
	/// Contour edges are the edges between bands. If enabled, they are
	/// generated from polygons/triangle strips and placed into the second
	/// output (the ContourEdgesOutput).
	/// </summary>
	public virtual int GetGenerateContourEdges()
	{
		return vtkBandedPolyDataContourFilter_GetGenerateContourEdges_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkBandedPolyDataContourFilter_GetMTime_12(HandleRef pThis);

	/// <summary>
	/// Overload GetMTime because we delegate to vtkContourValues so its
	/// modified time must be taken into account.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkBandedPolyDataContourFilter_GetMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBandedPolyDataContourFilter_GetNumberOfContours_13(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values. A single value at a time can be
	/// set with SetValue(). Multiple contour values can be set with
	/// GenerateValues(). Note that GenerateValues() generates n values
	/// inclusive of the start and end range values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkBandedPolyDataContourFilter_GetNumberOfContours_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBandedPolyDataContourFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBandedPolyDataContourFilter_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBandedPolyDataContourFilter_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBandedPolyDataContourFilter_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandedPolyDataContourFilter_GetScalarMode_16(HandleRef pThis);

	/// <summary>
	/// Control whether the cell scalars are output as an integer index or
	/// a scalar value. If an index, the index refers to the bands produced
	/// by the clipping range. If a value, then a scalar value which is a
	/// value between clip values is used.
	/// </summary>
	public virtual int GetScalarMode()
	{
		return vtkBandedPolyDataContourFilter_GetScalarMode_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandedPolyDataContourFilter_GetScalarModeMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Control whether the cell scalars are output as an integer index or
	/// a scalar value. If an index, the index refers to the bands produced
	/// by the clipping range. If a value, then a scalar value which is a
	/// value between clip values is used.
	/// </summary>
	public virtual int GetScalarModeMaxValue()
	{
		return vtkBandedPolyDataContourFilter_GetScalarModeMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandedPolyDataContourFilter_GetScalarModeMinValue_18(HandleRef pThis);

	/// <summary>
	/// Control whether the cell scalars are output as an integer index or
	/// a scalar value. If an index, the index refers to the bands produced
	/// by the clipping range. If a value, then a scalar value which is a
	/// value between clip values is used.
	/// </summary>
	public virtual int GetScalarModeMinValue()
	{
		return vtkBandedPolyDataContourFilter_GetScalarModeMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBandedPolyDataContourFilter_GetValue_19(HandleRef pThis, int i);

	/// <summary>
	/// Methods to set / get contour values. A single value at a time can be
	/// set with SetValue(). Multiple contour values can be set with
	/// GenerateValues(). Note that GenerateValues() generates n values
	/// inclusive of the start and end range values.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkBandedPolyDataContourFilter_GetValue_19(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBandedPolyDataContourFilter_GetValues_20(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values. A single value at a time can be
	/// set with SetValue(). Multiple contour values can be set with
	/// GenerateValues(). Note that GenerateValues() generates n values
	/// inclusive of the start and end range values.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkBandedPolyDataContourFilter_GetValues_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_GetValues_21(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Methods to set / get contour values. A single value at a time can be
	/// set with SetValue(). Multiple contour values can be set with
	/// GenerateValues(). Note that GenerateValues() generates n values
	/// inclusive of the start and end range values.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkBandedPolyDataContourFilter_GetValues_21(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandedPolyDataContourFilter_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBandedPolyDataContourFilter_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandedPolyDataContourFilter_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBandedPolyDataContourFilter_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBandedPolyDataContourFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBandedPolyDataContourFilter NewInstance()
	{
		vtkBandedPolyDataContourFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBandedPolyDataContourFilter_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBandedPolyDataContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBandedPolyDataContourFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBandedPolyDataContourFilter SafeDownCast(vtkObjectBase o)
	{
		vtkBandedPolyDataContourFilter vtkBandedPolyDataContourFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBandedPolyDataContourFilter_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBandedPolyDataContourFilter2 = (vtkBandedPolyDataContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBandedPolyDataContourFilter2.Register(null);
			}
		}
		return vtkBandedPolyDataContourFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_SetClipTolerance_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the clip tolerance. Warning: setting this too large will
	/// certainly cause numerical issues. Change from the default value
	/// of FLT_EPSILON at your own risk. The actual internal clip tolerance
	/// is computed by multiplying ClipTolerance by the scalar range.
	/// </summary>
	public virtual void SetClipTolerance(double _arg)
	{
		vtkBandedPolyDataContourFilter_SetClipTolerance_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_SetClipping_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to clip outside the range specified by the user.
	/// (The range is contour value[0] to contour value[numContours-1].)
	/// Clipping means all cells outside of the range specified are not
	/// sent to the output.
	/// </summary>
	public virtual void SetClipping(int _arg)
	{
		vtkBandedPolyDataContourFilter_SetClipping_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_SetComponent_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the component to use of an input scalars array with more than one
	/// component. Default is 0.
	/// </summary>
	public virtual void SetComponent(int _arg)
	{
		vtkBandedPolyDataContourFilter_SetComponent_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_SetGenerateContourEdges_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off a flag to control whether contour edges are generated.
	/// Contour edges are the edges between bands. If enabled, they are
	/// generated from polygons/triangle strips and placed into the second
	/// output (the ContourEdgesOutput).
	/// </summary>
	public virtual void SetGenerateContourEdges(int _arg)
	{
		vtkBandedPolyDataContourFilter_SetGenerateContourEdges_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_SetNumberOfContours_31(HandleRef pThis, int number);

	/// <summary>
	/// Methods to set / get contour values. A single value at a time can be
	/// set with SetValue(). Multiple contour values can be set with
	/// GenerateValues(). Note that GenerateValues() generates n values
	/// inclusive of the start and end range values.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkBandedPolyDataContourFilter_SetNumberOfContours_31(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_SetScalarMode_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether the cell scalars are output as an integer index or
	/// a scalar value. If an index, the index refers to the bands produced
	/// by the clipping range. If a value, then a scalar value which is a
	/// value between clip values is used.
	/// </summary>
	public virtual void SetScalarMode(int _arg)
	{
		vtkBandedPolyDataContourFilter_SetScalarMode_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_SetScalarModeToIndex_33(HandleRef pThis);

	/// <summary>
	/// Control whether the cell scalars are output as an integer index or
	/// a scalar value. If an index, the index refers to the bands produced
	/// by the clipping range. If a value, then a scalar value which is a
	/// value between clip values is used.
	/// </summary>
	public void SetScalarModeToIndex()
	{
		vtkBandedPolyDataContourFilter_SetScalarModeToIndex_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_SetScalarModeToValue_34(HandleRef pThis);

	/// <summary>
	/// Control whether the cell scalars are output as an integer index or
	/// a scalar value. If an index, the index refers to the bands produced
	/// by the clipping range. If a value, then a scalar value which is a
	/// value between clip values is used.
	/// </summary>
	public void SetScalarModeToValue()
	{
		vtkBandedPolyDataContourFilter_SetScalarModeToValue_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandedPolyDataContourFilter_SetValue_35(HandleRef pThis, int i, double value);

	/// <summary>
	/// Methods to set / get contour values. A single value at a time can be
	/// set with SetValue(). Multiple contour values can be set with
	/// GenerateValues(). Note that GenerateValues() generates n values
	/// inclusive of the start and end range values.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkBandedPolyDataContourFilter_SetValue_35(GetCppThis(), i, value);
	}
}
