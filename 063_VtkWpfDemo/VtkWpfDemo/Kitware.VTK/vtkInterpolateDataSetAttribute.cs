using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInterpolateDataSetAttributes
/// </summary>
/// <remarks>
///    interpolate scalars, vectors, etc. and other dataset attributes
///
/// vtkInterpolateDataSetAttributes is a filter that interpolates data set
/// attribute values between input data sets. The input to the filter
/// must be datasets of the same type, same number of cells, and same
/// number of points. The output of the filter is a data set of the same
/// type as the input dataset and whose attribute values have been
/// interpolated at the parametric value specified.
///
/// The filter is used by specifying two or more input data sets (total of N),
/// and a parametric value t (0 &lt;= t &lt;= N-1). The output will contain
/// interpolated data set attributes common to all input data sets. (For
/// example, if one input has scalars and vectors, and another has just
/// scalars, then only scalars will be interpolated and output.)
/// </remarks>
public class vtkInterpolateDataSetAttributes : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolateDataSetAttributes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInterpolateDataSetAttributes()
	{
		MRClassNameKey = "class vtkInterpolateDataSetAttributes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolateDataSetAttributes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInterpolateDataSetAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInterpolateDataSetAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInterpolateDataSetAttributes New()
	{
		vtkInterpolateDataSetAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInterpolateDataSetAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInterpolateDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInterpolateDataSetAttributes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInterpolateDataSetAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkInterpolateDataSetAttributes_GetInputList_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the list of inputs to this filter.
	/// </summary>
	public vtkDataSetCollection GetInputList()
	{
		vtkDataSetCollection vtkDataSetCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInterpolateDataSetAttributes_GetInputList_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetCollection2 = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetCollection2.Register(null);
			}
		}
		return vtkDataSetCollection2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInterpolateDataSetAttributes_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInterpolateDataSetAttributes_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInterpolateDataSetAttributes_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInterpolateDataSetAttributes_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInterpolateDataSetAttributes_GetT_04(HandleRef pThis);

	/// <summary>
	/// Specify interpolation parameter t.
	/// </summary>
	public virtual double GetT()
	{
		return vtkInterpolateDataSetAttributes_GetT_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInterpolateDataSetAttributes_GetTMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify interpolation parameter t.
	/// </summary>
	public virtual double GetTMaxValue()
	{
		return vtkInterpolateDataSetAttributes_GetTMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInterpolateDataSetAttributes_GetTMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify interpolation parameter t.
	/// </summary>
	public virtual double GetTMinValue()
	{
		return vtkInterpolateDataSetAttributes_GetTMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInterpolateDataSetAttributes_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInterpolateDataSetAttributes_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInterpolateDataSetAttributes_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInterpolateDataSetAttributes_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInterpolateDataSetAttributes_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInterpolateDataSetAttributes NewInstance()
	{
		vtkInterpolateDataSetAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInterpolateDataSetAttributes_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInterpolateDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInterpolateDataSetAttributes_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInterpolateDataSetAttributes SafeDownCast(vtkObjectBase o)
	{
		vtkInterpolateDataSetAttributes vtkInterpolateDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInterpolateDataSetAttributes_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInterpolateDataSetAttributes2 = (vtkInterpolateDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInterpolateDataSetAttributes2.Register(null);
			}
		}
		return vtkInterpolateDataSetAttributes2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInterpolateDataSetAttributes_SetT_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify interpolation parameter t.
	/// </summary>
	public virtual void SetT(double _arg)
	{
		vtkInterpolateDataSetAttributes_SetT_12(GetCppThis(), _arg);
	}
}
