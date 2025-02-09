using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAppendPoints
/// </summary>
/// <remarks>
///    appends points of one or more vtkPolyData data sets
///
///
/// vtkAppendPoints is a filter that appends the points and associated data
/// of one or more polygonal (vtkPolyData) datasets. This filter can optionally
/// add a new array marking the input index that the point came from.
///
/// </remarks>
/// <seealso>
///
/// vtkAppendFilter vtkAppendPolyData
/// </seealso>
public class vtkAppendPoints : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAppendPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAppendPoints()
	{
		MRClassNameKey = "class vtkAppendPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAppendPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendPoints New()
	{
		vtkAppendPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAppendPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAppendPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAppendPoints_GetInputIdArrayName_01(HandleRef pThis);

	/// <summary>
	/// Sets the output array name to fill with the input connection index
	/// for each point. This provides a way to trace a point back to a
	/// particular input. If this is nullptr (the default), the array is not generated.
	/// </summary>
	public virtual string GetInputIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAppendPoints_GetInputIdArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendPoints_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAppendPoints_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendPoints_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAppendPoints_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendPoints_GetOutputPointsPrecision_04(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output type. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings. If the desired precision is
	/// DEFAULT_PRECISION and any of the inputs are double precision, then the
	/// output precision will be double precision. Otherwise, if the desired
	/// precision is DEFAULT_PRECISION and all the inputs are single precision,
	/// then the output will be single precision.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkAppendPoints_GetOutputPointsPrecision_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendPoints_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAppendPoints_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendPoints_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAppendPoints_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendPoints_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAppendPoints NewInstance()
	{
		vtkAppendPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendPoints_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendPoints_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendPoints SafeDownCast(vtkObjectBase o)
	{
		vtkAppendPoints vtkAppendPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendPoints_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAppendPoints2 = (vtkAppendPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAppendPoints2.Register(null);
			}
		}
		return vtkAppendPoints2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPoints_SetInputIdArrayName_10(HandleRef pThis, string _arg);

	/// <summary>
	/// Sets the output array name to fill with the input connection index
	/// for each point. This provides a way to trace a point back to a
	/// particular input. If this is nullptr (the default), the array is not generated.
	/// </summary>
	public virtual void SetInputIdArrayName(string _arg)
	{
		vtkAppendPoints_SetInputIdArrayName_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPoints_SetOutputPointsPrecision_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output type. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings. If the desired precision is
	/// DEFAULT_PRECISION and any of the inputs are double precision, then the
	/// output precision will be double precision. Otherwise, if the desired
	/// precision is DEFAULT_PRECISION and all the inputs are single precision,
	/// then the output will be single precision.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkAppendPoints_SetOutputPointsPrecision_11(GetCppThis(), _arg);
	}
}
