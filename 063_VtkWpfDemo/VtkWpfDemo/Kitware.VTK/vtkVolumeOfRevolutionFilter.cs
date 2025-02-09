using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVolumeOfRevolutionFilter
/// </summary>
/// <remarks>
///    sweep data about a line to create a volume
///
/// vtkVolumeOfRevolutionFilter is a modeling filter. It takes a 2-dimensional
/// dataset as input and generates an unstructured grid on output. The input
/// dataset is swept around the axis of rotation to create dimension-elevated
/// primitives. For example, sweeping a vertex creates a series of lines;
/// sweeping a line creates a series of quads, etc.
///
/// @warning
/// The user must take care to ensure that the axis of revolution does not cross
/// through the geometry, otherwise there will be intersecting cells in the
/// output.
///
/// </remarks>
/// <seealso>
///
/// vtkRotationalExtrusionFilter
/// </seealso>
public class vtkVolumeOfRevolutionFilter : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeOfRevolutionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolumeOfRevolutionFilter()
	{
		MRClassNameKey = "class vtkVolumeOfRevolutionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeOfRevolutionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolumeOfRevolutionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOfRevolutionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create object with sweep angle of 360 degrees, resolution = 12,
	/// axis position (0,0,0) and axis direction (0,0,1).
	/// </summary>
	public new static vtkVolumeOfRevolutionFilter New()
	{
		vtkVolumeOfRevolutionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeOfRevolutionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeOfRevolutionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create object with sweep angle of 360 degrees, resolution = 12,
	/// axis position (0,0,0) and axis direction (0,0,1).
	/// </summary>
	public vtkVolumeOfRevolutionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVolumeOfRevolutionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkVolumeOfRevolutionFilter_GetAxisDirection_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the direction of the axis of revolution.
	/// </summary>
	public virtual double[] GetAxisDirection()
	{
		IntPtr intPtr = vtkVolumeOfRevolutionFilter_GetAxisDirection_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_GetAxisDirection_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the direction of the axis of revolution.
	/// </summary>
	public virtual void GetAxisDirection(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkVolumeOfRevolutionFilter_GetAxisDirection_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_GetAxisDirection_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the direction of the axis of revolution.
	/// </summary>
	public virtual void GetAxisDirection(IntPtr _arg)
	{
		vtkVolumeOfRevolutionFilter_GetAxisDirection_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOfRevolutionFilter_GetAxisPosition_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the axis of revolution.
	/// </summary>
	public virtual double[] GetAxisPosition()
	{
		IntPtr intPtr = vtkVolumeOfRevolutionFilter_GetAxisPosition_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_GetAxisPosition_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the position of the axis of revolution.
	/// </summary>
	public virtual void GetAxisPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkVolumeOfRevolutionFilter_GetAxisPosition_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_GetAxisPosition_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the position of the axis of revolution.
	/// </summary>
	public virtual void GetAxisPosition(IntPtr _arg)
	{
		vtkVolumeOfRevolutionFilter_GetAxisPosition_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeOfRevolutionFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolumeOfRevolutionFilter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeOfRevolutionFilter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolumeOfRevolutionFilter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOfRevolutionFilter_GetOutputPointsPrecision_09(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkVolumeOfRevolutionFilter_GetOutputPointsPrecision_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOfRevolutionFilter_GetOutputPointsPrecisionMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkVolumeOfRevolutionFilter_GetOutputPointsPrecisionMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOfRevolutionFilter_GetOutputPointsPrecisionMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkVolumeOfRevolutionFilter_GetOutputPointsPrecisionMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOfRevolutionFilter_GetResolution_12(HandleRef pThis);

	/// <summary>
	/// Set/Get resolution of sweep operation. Resolution controls the number
	/// of intermediate node points.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkVolumeOfRevolutionFilter_GetResolution_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOfRevolutionFilter_GetResolutionMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get resolution of sweep operation. Resolution controls the number
	/// of intermediate node points.
	/// </summary>
	public virtual int GetResolutionMaxValue()
	{
		return vtkVolumeOfRevolutionFilter_GetResolutionMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOfRevolutionFilter_GetResolutionMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get resolution of sweep operation. Resolution controls the number
	/// of intermediate node points.
	/// </summary>
	public virtual int GetResolutionMinValue()
	{
		return vtkVolumeOfRevolutionFilter_GetResolutionMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeOfRevolutionFilter_GetSweepAngle_15(HandleRef pThis);

	/// <summary>
	/// Set/Get angle of rotation in degrees.
	/// </summary>
	public virtual double GetSweepAngle()
	{
		return vtkVolumeOfRevolutionFilter_GetSweepAngle_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeOfRevolutionFilter_GetSweepAngleMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get angle of rotation in degrees.
	/// </summary>
	public virtual double GetSweepAngleMaxValue()
	{
		return vtkVolumeOfRevolutionFilter_GetSweepAngleMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeOfRevolutionFilter_GetSweepAngleMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set/Get angle of rotation in degrees.
	/// </summary>
	public virtual double GetSweepAngleMinValue()
	{
		return vtkVolumeOfRevolutionFilter_GetSweepAngleMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOfRevolutionFilter_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolumeOfRevolutionFilter_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOfRevolutionFilter_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolumeOfRevolutionFilter_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOfRevolutionFilter_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVolumeOfRevolutionFilter NewInstance()
	{
		vtkVolumeOfRevolutionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeOfRevolutionFilter_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeOfRevolutionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOfRevolutionFilter_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeOfRevolutionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkVolumeOfRevolutionFilter vtkVolumeOfRevolutionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeOfRevolutionFilter_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeOfRevolutionFilter2 = (vtkVolumeOfRevolutionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeOfRevolutionFilter2.Register(null);
			}
		}
		return vtkVolumeOfRevolutionFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_SetAxisDirection_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the direction of the axis of revolution.
	/// </summary>
	public virtual void SetAxisDirection(double _arg1, double _arg2, double _arg3)
	{
		vtkVolumeOfRevolutionFilter_SetAxisDirection_23(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_SetAxisDirection_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the direction of the axis of revolution.
	/// </summary>
	public virtual void SetAxisDirection(IntPtr _arg)
	{
		vtkVolumeOfRevolutionFilter_SetAxisDirection_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_SetAxisPosition_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the position of the axis of revolution.
	/// </summary>
	public virtual void SetAxisPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkVolumeOfRevolutionFilter_SetAxisPosition_25(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_SetAxisPosition_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the position of the axis of revolution.
	/// </summary>
	public virtual void SetAxisPosition(IntPtr _arg)
	{
		vtkVolumeOfRevolutionFilter_SetAxisPosition_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_SetOutputPointsPrecision_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkVolumeOfRevolutionFilter_SetOutputPointsPrecision_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_SetResolution_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get resolution of sweep operation. Resolution controls the number
	/// of intermediate node points.
	/// </summary>
	public virtual void SetResolution(int _arg)
	{
		vtkVolumeOfRevolutionFilter_SetResolution_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOfRevolutionFilter_SetSweepAngle_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get angle of rotation in degrees.
	/// </summary>
	public virtual void SetSweepAngle(double _arg)
	{
		vtkVolumeOfRevolutionFilter_SetSweepAngle_29(GetCppThis(), _arg);
	}
}
