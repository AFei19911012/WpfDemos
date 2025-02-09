using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkThresholdPoints
/// </summary>
/// <remarks>
///    extracts points whose scalar value satisfies threshold criterion
///
/// vtkThresholdPoints is a filter that extracts points from a dataset that
/// satisfy a threshold criterion. The criterion can take three forms:
/// 1) greater than a particular value; 2) less than a particular value; or
/// 3) between a particular value. The output of the filter is polygonal data.
///
/// </remarks>
/// <seealso>
///
/// vtkThreshold vtkSelectEnclosedPoints vtkExtractEnclosedPoints
/// </seealso>
public class vtkThresholdPoints : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkThresholdPoints()
	{
		MRClassNameKey = "class vtkThresholdPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkThresholdPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThresholdPoints New()
	{
		vtkThresholdPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThresholdPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkThresholdPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkThresholdPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdPoints_GetInputArrayComponent_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the component to threshold. Set this to a value greater than the number of
	/// components in the selected data array to threshold by magnitude.
	/// </summary>
	public virtual int GetInputArrayComponent()
	{
		return vtkThresholdPoints_GetInputArrayComponent_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkThresholdPoints_GetLowerThreshold_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the lower threshold.
	/// </summary>
	public virtual double GetLowerThreshold()
	{
		return vtkThresholdPoints_GetLowerThreshold_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThresholdPoints_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkThresholdPoints_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThresholdPoints_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkThresholdPoints_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdPoints_GetOutputPointsPrecision_05(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkThresholdPoints_GetOutputPointsPrecision_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkThresholdPoints_GetUpperThreshold_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the upper threshold.
	/// </summary>
	public virtual double GetUpperThreshold()
	{
		return vtkThresholdPoints_GetUpperThreshold_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdPoints_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkThresholdPoints_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdPoints_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkThresholdPoints_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdPoints_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkThresholdPoints NewInstance()
	{
		vtkThresholdPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdPoints_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThresholdPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdPoints_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThresholdPoints SafeDownCast(vtkObjectBase o)
	{
		vtkThresholdPoints vtkThresholdPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdPoints_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkThresholdPoints2 = (vtkThresholdPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkThresholdPoints2.Register(null);
			}
		}
		return vtkThresholdPoints2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdPoints_SetInputArrayComponent_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the component to threshold. Set this to a value greater than the number of
	/// components in the selected data array to threshold by magnitude.
	/// </summary>
	public virtual void SetInputArrayComponent(int _arg)
	{
		vtkThresholdPoints_SetInputArrayComponent_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdPoints_SetLowerThreshold_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the lower threshold.
	/// </summary>
	public virtual void SetLowerThreshold(double _arg)
	{
		vtkThresholdPoints_SetLowerThreshold_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdPoints_SetOutputPointsPrecision_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkThresholdPoints_SetOutputPointsPrecision_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdPoints_SetUpperThreshold_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the upper threshold.
	/// </summary>
	public virtual void SetUpperThreshold(double _arg)
	{
		vtkThresholdPoints_SetUpperThreshold_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdPoints_ThresholdBetween_16(HandleRef pThis, double lower, double upper);

	/// <summary>
	/// Criterion is cells whose scalars are between lower and upper thresholds
	/// (inclusive of the end values).
	/// </summary>
	public void ThresholdBetween(double lower, double upper)
	{
		vtkThresholdPoints_ThresholdBetween_16(GetCppThis(), lower, upper);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdPoints_ThresholdByLower_17(HandleRef pThis, double lower);

	/// <summary>
	/// Criterion is cells whose scalars are less or equal to lower threshold.
	/// </summary>
	public void ThresholdByLower(double lower)
	{
		vtkThresholdPoints_ThresholdByLower_17(GetCppThis(), lower);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdPoints_ThresholdByUpper_18(HandleRef pThis, double upper);

	/// <summary>
	/// Criterion is cells whose scalars are greater or equal to upper threshold.
	/// </summary>
	public void ThresholdByUpper(double upper)
	{
		vtkThresholdPoints_ThresholdByUpper_18(GetCppThis(), upper);
	}
}
