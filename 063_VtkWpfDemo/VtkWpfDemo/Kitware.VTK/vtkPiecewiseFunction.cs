using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPiecewiseFunction
/// </summary>
/// <remarks>
///    Defines a 1D piecewise function.
///
///
/// Defines a piecewise function mapping. This mapping allows the addition
/// of control points, and allows the user to control the function between
/// the control points. A piecewise hermite curve is used between control
/// points, based on the sharpness and midpoint parameters. A sharpness of
/// 0 yields a piecewise linear function and a sharpness of 1 yields a
/// piecewise constant function. The midpoint is the normalized distance
/// between control points at which the curve reaches the median Y value.
/// The midpoint and sharpness values specified when adding a node are used
/// to control the transition to the next node (the last node's values are
/// ignored) Outside the range of nodes, the values are 0 if Clamping is off,
/// or the nearest node point if Clamping is on. Using the legacy methods for
/// adding points  (which do not have Sharpness and Midpoint parameters)
/// will default to Midpoint = 0.5 (halfway between the control points) and
/// Sharpness = 0.0 (linear).
/// </remarks>
public class vtkPiecewiseFunction : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPiecewiseFunction()
	{
		MRClassNameKey = "class vtkPiecewiseFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPiecewiseFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPiecewiseFunction New()
	{
		vtkPiecewiseFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewiseFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPiecewiseFunction()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPiecewiseFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_AddPoint_01(HandleRef pThis, double x, double y);

	/// <summary>
	/// Add points to the function. If a duplicate point is added
	/// then the previous point is removed unless
	/// AllowDuplicateScalars is set to true
	/// Return the index of the point (0 based), or -1 on error.
	/// </summary>
	public int AddPoint(double x, double y)
	{
		return vtkPiecewiseFunction_AddPoint_01(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_AddPoint_02(HandleRef pThis, double x, double y, double midpoint, double sharpness);

	/// <summary>
	/// Add points to the function. If a duplicate point is added
	/// then the previous point is removed unless
	/// AllowDuplicateScalars is set to true
	/// Return the index of the point (0 based), or -1 on error.
	/// </summary>
	public int AddPoint(double x, double y, double midpoint, double sharpness)
	{
		return vtkPiecewiseFunction_AddPoint_02(GetCppThis(), x, y, midpoint, sharpness);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_AddSegment_03(HandleRef pThis, double x1, double y1, double x2, double y2);

	/// <summary>
	/// Add a line segment to the function. All points defined between the
	/// two points specified are removed from the function.
	/// To specify the sharpness and midpoint values, use AddPoint method instead.
	/// </summary>
	public void AddSegment(double x1, double y1, double x2, double y2)
	{
		vtkPiecewiseFunction_AddSegment_03(GetCppThis(), x1, y1, x2, y2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_AdjustRange_04(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Remove all points out of the new range, and make sure there is a point
	/// at each end of that range.
	/// Return 1 on success, 0 otherwise.
	/// </summary>
	public int AdjustRange(IntPtr range)
	{
		return vtkPiecewiseFunction_AdjustRange_04(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_AllowDuplicateScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Toggle whether to allow duplicate scalar values in the piecewise
	/// function (off by default).
	/// </summary>
	public virtual void AllowDuplicateScalarsOff()
	{
		vtkPiecewiseFunction_AllowDuplicateScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_AllowDuplicateScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Toggle whether to allow duplicate scalar values in the piecewise
	/// function (off by default).
	/// </summary>
	public virtual void AllowDuplicateScalarsOn()
	{
		vtkPiecewiseFunction_AllowDuplicateScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_BuildFunctionFromTable_07(HandleRef pThis, double x1, double x2, int size, IntPtr table, int stride);

	/// <summary>
	/// Constructs a piecewise function from a table.  Function range is
	/// is set to [x1, x2], function size is set to size, and function points
	/// are regularly spaced between x1 and x2.  Parameter "stride" is
	/// is step through the input table.
	/// </summary>
	public void BuildFunctionFromTable(double x1, double x2, int size, IntPtr table, int stride)
	{
		vtkPiecewiseFunction_BuildFunctionFromTable_07(GetCppThis(), x1, x2, size, table, stride);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_ClampingOff_08(HandleRef pThis);

	/// <summary>
	/// When zero range clamping is Off, GetValue() returns 0.0 when a
	/// value is requested outside of the points specified.
	/// When zero range clamping is On, GetValue() returns the value at
	/// the value at the lowest point for a request below all points
	/// specified and returns the value at the highest point for a request
	/// above all points specified. On is the default.
	/// </summary>
	public virtual void ClampingOff()
	{
		vtkPiecewiseFunction_ClampingOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_ClampingOn_09(HandleRef pThis);

	/// <summary>
	/// When zero range clamping is Off, GetValue() returns 0.0 when a
	/// value is requested outside of the points specified.
	/// When zero range clamping is On, GetValue() returns the value at
	/// the value at the lowest point for a request below all points
	/// specified and returns the value at the highest point for a request
	/// above all points specified. On is the default.
	/// </summary>
	public virtual void ClampingOn()
	{
		vtkPiecewiseFunction_ClampingOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_DeepCopy_10(HandleRef pThis, HandleRef f);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void DeepCopy(vtkDataObject f)
	{
		vtkPiecewiseFunction_DeepCopy_10(GetCppThis(), f?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_EstimateMinNumberOfSamples_11(HandleRef pThis, ref double x1, ref double x2);

	/// <summary>
	/// Estimates the minimum size of a table such that it would correctly sample this function.
	/// The returned value should be passed as parameter 'n' when calling GetTable().
	/// </summary>
	public int EstimateMinNumberOfSamples(ref double x1, ref double x2)
	{
		return vtkPiecewiseFunction_EstimateMinNumberOfSamples_11(GetCppThis(), ref x1, ref x2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_FillFromDataPointer_12(HandleRef pThis, int arg0, IntPtr arg1);

	/// <summary>
	/// Returns a pointer to the data stored in the table.
	/// Fills from a pointer to data stored in a similar table. These are
	/// legacy methods which will be maintained for compatibility - however,
	/// note that the vtkPiecewiseFunction no longer stores the nodes
	/// in a double array internally.
	/// </summary>
	public void FillFromDataPointer(int arg0, IntPtr arg1)
	{
		vtkPiecewiseFunction_FillFromDataPointer_12(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_GetAllowDuplicateScalars_13(HandleRef pThis);

	/// <summary>
	/// Toggle whether to allow duplicate scalar values in the piecewise
	/// function (off by default).
	/// </summary>
	public virtual int GetAllowDuplicateScalars()
	{
		return vtkPiecewiseFunction_GetAllowDuplicateScalars_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_GetClamping_14(HandleRef pThis);

	/// <summary>
	/// When zero range clamping is Off, GetValue() returns 0.0 when a
	/// value is requested outside of the points specified.
	/// When zero range clamping is On, GetValue() returns the value at
	/// the value at the lowest point for a request below all points
	/// specified and returns the value at the highest point for a request
	/// above all points specified. On is the default.
	/// </summary>
	public virtual int GetClamping()
	{
		return vtkPiecewiseFunction_GetClamping_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseFunction_GetData_15(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPiecewiseFunction GetData(vtkInformation info)
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewiseFunction_GetData_15(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseFunction_GetData_16(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPiecewiseFunction GetData(vtkInformationVector v, int i)
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewiseFunction_GetData_16(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_GetDataObjectType_17(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkPiecewiseFunction_GetDataObjectType_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseFunction_GetDataPointer_18(HandleRef pThis);

	/// <summary>
	/// Returns a pointer to the data stored in the table.
	/// Fills from a pointer to data stored in a similar table. These are
	/// legacy methods which will be maintained for compatibility - however,
	/// note that the vtkPiecewiseFunction no longer stores the nodes
	/// in a double array internally.
	/// </summary>
	public IntPtr GetDataPointer()
	{
		return vtkPiecewiseFunction_GetDataPointer_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPiecewiseFunction_GetFirstNonZeroValue_19(HandleRef pThis);

	/// <summary>
	/// Returns the first point location which precedes a non-zero segment of the
	/// function. Note that the value at this point may be zero.
	/// </summary>
	public double GetFirstNonZeroValue()
	{
		return vtkPiecewiseFunction_GetFirstNonZeroValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_GetNodeValue_20(HandleRef pThis, int index, IntPtr val);

	/// <summary>
	/// For the node specified by index, set/get the
	/// location (X), value (Y), midpoint, and sharpness
	/// values at the node. Returns -1 if the index is
	/// out of range, returns 1 otherwise.
	/// </summary>
	public int GetNodeValue(int index, IntPtr val)
	{
		return vtkPiecewiseFunction_GetNodeValue_20(GetCppThis(), index, val);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPiecewiseFunction_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPiecewiseFunction_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPiecewiseFunction_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPiecewiseFunction_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseFunction_GetRange_23(HandleRef pThis);

	/// <summary>
	/// Returns the min and max node locations of the function.
	/// </summary>
	public virtual double[] GetRange()
	{
		IntPtr intPtr = vtkPiecewiseFunction_GetRange_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_GetRange_24(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Returns the min and max node locations of the function.
	/// </summary>
	public virtual void GetRange(ref double _arg1, ref double _arg2)
	{
		vtkPiecewiseFunction_GetRange_24(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_GetRange_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Returns the min and max node locations of the function.
	/// </summary>
	public virtual void GetRange(IntPtr _arg)
	{
		vtkPiecewiseFunction_GetRange_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_GetSize_26(HandleRef pThis);

	/// <summary>
	/// Get the number of points used to specify the function
	/// </summary>
	public int GetSize()
	{
		return vtkPiecewiseFunction_GetSize_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_GetTable_27(HandleRef pThis, double x1, double x2, int size, IntPtr table, int stride, int logIncrements);

	/// <summary>
	/// Fills in an array of function values evaluated at regular intervals.
	/// Parameter "stride" is used to step through the output "table". If
	/// logIncrements is true, the intervals between entries will be constant in
	/// logarithmic space.
	/// </summary>
	public void GetTable(double x1, double x2, int size, IntPtr table, int stride, int logIncrements)
	{
		vtkPiecewiseFunction_GetTable_27(GetCppThis(), x1, x2, size, table, stride, logIncrements);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseFunction_GetType_28(HandleRef pThis);

	/// <summary>
	/// Return the type of function:
	/// Function Types:
	/// 0 : Constant        (No change in slope between end points)
	/// 1 : NonDecreasing   (Always increasing or zero slope)
	/// 2 : NonIncreasing   (Always decreasing or zero slope)
	/// 3 : Varied          (Contains both decreasing and increasing slopes)
	/// </summary>
	public string GetTypeWrapper()
	{
		return Marshal.PtrToStringAnsi(vtkPiecewiseFunction_GetType_28(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPiecewiseFunction_GetUseLogScale_29(HandleRef pThis);

	/// <summary>
	/// Interpolate between the control points in base-10 logrithmic space.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual bool GetUseLogScale()
	{
		return (vtkPiecewiseFunction_GetUseLogScale_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPiecewiseFunction_GetValue_30(HandleRef pThis, double x);

	/// <summary>
	/// Returns the value of the function at the specified location using
	/// the specified interpolation.
	/// </summary>
	public double GetValue(double x)
	{
		return vtkPiecewiseFunction_GetValue_30(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_Initialize_31(HandleRef pThis);

	/// <summary>
	/// Clears out the current function. A newly created vtkPiecewiseFunction
	/// is already initialized, so there is no need to call this method which
	/// in turn simply calls RemoveAllPoints()
	/// </summary>
	public override void Initialize()
	{
		vtkPiecewiseFunction_Initialize_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_IsA_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPiecewiseFunction_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_IsTypeOf_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPiecewiseFunction_IsTypeOf_33(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseFunction_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPiecewiseFunction NewInstance()
	{
		vtkPiecewiseFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewiseFunction_NewInstance_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_RemoveAllPoints_36(HandleRef pThis);

	/// <summary>
	/// Removes all points from the function.
	/// </summary>
	public void RemoveAllPoints()
	{
		vtkPiecewiseFunction_RemoveAllPoints_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_RemovePoint_37(HandleRef pThis, double x);

	/// <summary>
	/// Remove the first point found at the given x location
	/// Return the index of the remove point if any, -1 otherwise
	/// </summary>
	public int RemovePoint(double x)
	{
		return vtkPiecewiseFunction_RemovePoint_37(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_RemovePoint_38(HandleRef pThis, double x, double y);

	/// <summary>
	/// Remove the first point found at the given x and y location
	/// Return the index of the remove point if any, -1 otherwise
	/// </summary>
	public int RemovePoint(double x, double y)
	{
		return vtkPiecewiseFunction_RemovePoint_38(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPiecewiseFunction_RemovePointByIndex_39(HandleRef pThis, ulong id);

	/// <summary>
	/// Remove a point from the function at a given id
	/// Return true if point has been found and removed, false other wise
	/// </summary>
	public bool RemovePointByIndex(ulong id)
	{
		return (vtkPiecewiseFunction_RemovePointByIndex_39(GetCppThis(), id) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseFunction_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPiecewiseFunction SafeDownCast(vtkObjectBase o)
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewiseFunction_SafeDownCast_40(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_SetAllowDuplicateScalars_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Toggle whether to allow duplicate scalar values in the piecewise
	/// function (off by default).
	/// </summary>
	public virtual void SetAllowDuplicateScalars(int _arg)
	{
		vtkPiecewiseFunction_SetAllowDuplicateScalars_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_SetClamping_42(HandleRef pThis, int _arg);

	/// <summary>
	/// When zero range clamping is Off, GetValue() returns 0.0 when a
	/// value is requested outside of the points specified.
	/// When zero range clamping is On, GetValue() returns the value at
	/// the value at the lowest point for a request below all points
	/// specified and returns the value at the highest point for a request
	/// above all points specified. On is the default.
	/// </summary>
	public virtual void SetClamping(int _arg)
	{
		vtkPiecewiseFunction_SetClamping_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseFunction_SetNodeValue_43(HandleRef pThis, int index, IntPtr val);

	/// <summary>
	/// For the node specified by index, set/get the
	/// location (X), value (Y), midpoint, and sharpness
	/// values at the node. Returns -1 if the index is
	/// out of range, returns 1 otherwise.
	/// </summary>
	public int SetNodeValue(int index, IntPtr val)
	{
		return vtkPiecewiseFunction_SetNodeValue_43(GetCppThis(), index, val);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_SetUseLogScale_44(HandleRef pThis, byte _arg);

	/// <summary>
	/// Interpolate between the control points in base-10 logrithmic space.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual void SetUseLogScale(bool _arg)
	{
		vtkPiecewiseFunction_SetUseLogScale_44(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_ShallowCopy_45(HandleRef pThis, HandleRef f);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void ShallowCopy(vtkDataObject f)
	{
		vtkPiecewiseFunction_ShallowCopy_45(GetCppThis(), f?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_UseLogScaleOff_46(HandleRef pThis);

	/// <summary>
	/// Interpolate between the control points in base-10 logrithmic space.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual void UseLogScaleOff()
	{
		vtkPiecewiseFunction_UseLogScaleOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseFunction_UseLogScaleOn_47(HandleRef pThis);

	/// <summary>
	/// Interpolate between the control points in base-10 logrithmic space.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual void UseLogScaleOn()
	{
		vtkPiecewiseFunction_UseLogScaleOn_47(GetCppThis());
	}
}
