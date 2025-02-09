using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAngularPeriodicFilter
/// </summary>
/// <remarks>
///    A filter to produce mapped angular periodic
/// multiblock dataset from a single block, by rotation.
///
///
/// Generate angular periodic dataset by rotating points, vectors and tensors
/// data arrays from an original data array.
/// The generated dataset is of the same type than the input (float or double).
/// To compute the rotation this filter needs
/// i) a number of periods, which can be the maximum, i.e. a full period,
/// ii) an angle, which can be fetched from a field data array in radian or directly
/// in degrees; iii) the axis (X, Y or Z) and the center of rotation.
/// Point coordinates are transformed, as well as all vectors (3-components) and
/// tensors (9 components) in points and cell data arrays.
/// The generated multiblock will have the same tree architecture than the input,
/// except transformed leaves are replaced by a vtkMultipieceDataSet.
/// Supported input leaf dataset type are: vtkPolyData, vtkStructuredGrid
/// and vtkUnstructuredGrid. Other data objects are rotated using the
/// transform filter (at a high cost!).
/// </remarks>
public class vtkAngularPeriodicFilter : vtkPeriodicFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAngularPeriodicFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAngularPeriodicFilter()
	{
		MRClassNameKey = "class vtkAngularPeriodicFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngularPeriodicFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAngularPeriodicFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngularPeriodicFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAngularPeriodicFilter New()
	{
		vtkAngularPeriodicFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngularPeriodicFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAngularPeriodicFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAngularPeriodicFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAngularPeriodicFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_ComputeRotationsOnTheFlyOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the rotated array values should be computed
	/// on-the-fly (default), which is compute-intensive, or the arrays should be
	/// explicitly generated and stored, at the cost of using more memory.
	/// </summary>
	public virtual void ComputeRotationsOnTheFlyOff()
	{
		vtkAngularPeriodicFilter_ComputeRotationsOnTheFlyOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_ComputeRotationsOnTheFlyOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the rotated array values should be computed
	/// on-the-fly (default), which is compute-intensive, or the arrays should be
	/// explicitly generated and stored, at the cost of using more memory.
	/// </summary>
	public virtual void ComputeRotationsOnTheFlyOn()
	{
		vtkAngularPeriodicFilter_ComputeRotationsOnTheFlyOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngularPeriodicFilter_GetCenter_03(HandleRef pThis);

	/// <summary>
	/// Set/Get Rotation Center
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkAngularPeriodicFilter_GetCenter_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_GetCenter_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get Rotation Center
	/// </summary>
	public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAngularPeriodicFilter_GetCenter_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_GetCenter_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get Rotation Center
	/// </summary>
	public virtual void GetCenter(IntPtr _arg)
	{
		vtkAngularPeriodicFilter_GetCenter_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAngularPeriodicFilter_GetComputeRotationsOnTheFly_06(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the rotated array values should be computed
	/// on-the-fly (default), which is compute-intensive, or the arrays should be
	/// explicitly generated and stored, at the cost of using more memory.
	/// </summary>
	public virtual bool GetComputeRotationsOnTheFly()
	{
		return (vtkAngularPeriodicFilter_GetComputeRotationsOnTheFly_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngularPeriodicFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAngularPeriodicFilter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngularPeriodicFilter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAngularPeriodicFilter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAngularPeriodicFilter_GetRotationAngle_09(HandleRef pThis);

	/// <summary>
	/// Set/Get Rotation angle, in degrees.
	/// Used only with VTK_ROTATION_MODE_DIRECT_ANGLE.
	/// Default is 180.
	/// </summary>
	public virtual double GetRotationAngle()
	{
		return vtkAngularPeriodicFilter_GetRotationAngle_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngularPeriodicFilter_GetRotationArrayName_10(HandleRef pThis);

	/// <summary>
	/// Set/Get Name of array to get the angle from.
	/// Used only with VTK_ROTATION_MODE_ARRAY_VALUE.
	/// </summary>
	public virtual string GetRotationArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAngularPeriodicFilter_GetRotationArrayName_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngularPeriodicFilter_GetRotationAxis_11(HandleRef pThis);

	/// <summary>
	/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
	/// </summary>
	public virtual int GetRotationAxis()
	{
		return vtkAngularPeriodicFilter_GetRotationAxis_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngularPeriodicFilter_GetRotationAxisMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
	/// </summary>
	public virtual int GetRotationAxisMaxValue()
	{
		return vtkAngularPeriodicFilter_GetRotationAxisMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngularPeriodicFilter_GetRotationAxisMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
	/// </summary>
	public virtual int GetRotationAxisMinValue()
	{
		return vtkAngularPeriodicFilter_GetRotationAxisMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngularPeriodicFilter_GetRotationMode_14(HandleRef pThis);

	/// <summary>
	/// Set/Get The rotation mode.
	/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
	/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
	/// </summary>
	public virtual int GetRotationMode()
	{
		return vtkAngularPeriodicFilter_GetRotationMode_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngularPeriodicFilter_GetRotationModeMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get The rotation mode.
	/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
	/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
	/// </summary>
	public virtual int GetRotationModeMaxValue()
	{
		return vtkAngularPeriodicFilter_GetRotationModeMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngularPeriodicFilter_GetRotationModeMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get The rotation mode.
	/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
	/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
	/// </summary>
	public virtual int GetRotationModeMinValue()
	{
		return vtkAngularPeriodicFilter_GetRotationModeMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngularPeriodicFilter_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAngularPeriodicFilter_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngularPeriodicFilter_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAngularPeriodicFilter_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngularPeriodicFilter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAngularPeriodicFilter NewInstance()
	{
		vtkAngularPeriodicFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngularPeriodicFilter_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAngularPeriodicFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngularPeriodicFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAngularPeriodicFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAngularPeriodicFilter vtkAngularPeriodicFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngularPeriodicFilter_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAngularPeriodicFilter2 = (vtkAngularPeriodicFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAngularPeriodicFilter2.Register(null);
			}
		}
		return vtkAngularPeriodicFilter2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetCenter_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get Rotation Center
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkAngularPeriodicFilter_SetCenter_22(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetCenter_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get Rotation Center
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkAngularPeriodicFilter_SetCenter_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetComputeRotationsOnTheFly_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether the rotated array values should be computed
	/// on-the-fly (default), which is compute-intensive, or the arrays should be
	/// explicitly generated and stored, at the cost of using more memory.
	/// </summary>
	public virtual void SetComputeRotationsOnTheFly(bool _arg)
	{
		vtkAngularPeriodicFilter_SetComputeRotationsOnTheFly_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetRotationAngle_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get Rotation angle, in degrees.
	/// Used only with VTK_ROTATION_MODE_DIRECT_ANGLE.
	/// Default is 180.
	/// </summary>
	public virtual void SetRotationAngle(double _arg)
	{
		vtkAngularPeriodicFilter_SetRotationAngle_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetRotationArrayName_26(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get Name of array to get the angle from.
	/// Used only with VTK_ROTATION_MODE_ARRAY_VALUE.
	/// </summary>
	public virtual void SetRotationArrayName(string _arg)
	{
		vtkAngularPeriodicFilter_SetRotationArrayName_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetRotationAxis_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
	/// </summary>
	public virtual void SetRotationAxis(int _arg)
	{
		vtkAngularPeriodicFilter_SetRotationAxis_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetRotationAxisToX_28(HandleRef pThis);

	/// <summary>
	/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
	/// </summary>
	public void SetRotationAxisToX()
	{
		vtkAngularPeriodicFilter_SetRotationAxisToX_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetRotationAxisToY_29(HandleRef pThis);

	/// <summary>
	/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
	/// </summary>
	public void SetRotationAxisToY()
	{
		vtkAngularPeriodicFilter_SetRotationAxisToY_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetRotationAxisToZ_30(HandleRef pThis);

	/// <summary>
	/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
	/// </summary>
	public void SetRotationAxisToZ()
	{
		vtkAngularPeriodicFilter_SetRotationAxisToZ_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetRotationMode_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get The rotation mode.
	/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
	/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
	/// </summary>
	public virtual void SetRotationMode(int _arg)
	{
		vtkAngularPeriodicFilter_SetRotationMode_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetRotationModeToArrayValue_32(HandleRef pThis);

	/// <summary>
	/// Set/Get The rotation mode.
	/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
	/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
	/// </summary>
	public void SetRotationModeToArrayValue()
	{
		vtkAngularPeriodicFilter_SetRotationModeToArrayValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngularPeriodicFilter_SetRotationModeToDirectAngle_33(HandleRef pThis);

	/// <summary>
	/// Set/Get The rotation mode.
	/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
	/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
	/// </summary>
	public void SetRotationModeToDirectAngle()
	{
		vtkAngularPeriodicFilter_SetRotationModeToDirectAngle_33(GetCppThis());
	}
}
