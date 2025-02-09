using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMatrixMathFilter
/// </summary>
/// <remarks>
///    Calculate functions of quality of the elements
///  of a mesh
///
///
/// vtkMatrixMathFilter computes one or more functions of mathematical quality for the
/// cells or points in a mesh. The per-cell or per-point quality is added to the
/// mesh's cell data or point data, in an array with names varied with different
/// quality being queried. Note this filter always assume the data associate with
/// the cells or points are 3 by 3 matrix.
/// </remarks>
public class vtkMatrixMathFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMatrixMathFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMatrixMathFilter()
	{
		MRClassNameKey = "class vtkMatrixMathFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrixMathFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMatrixMathFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrixMathFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMatrixMathFilter New()
	{
		vtkMatrixMathFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrixMathFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMatrixMathFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrixMathFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMatrixMathFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMatrixMathFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMatrixMathFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMatrixMathFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMatrixMathFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMatrixMathFilter_GetOperation_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of query.
	/// </summary>
	public virtual int GetOperation()
	{
		return vtkMatrixMathFilter_GetOperation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMatrixMathFilter_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMatrixMathFilter_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMatrixMathFilter_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMatrixMathFilter_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrixMathFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMatrixMathFilter NewInstance()
	{
		vtkMatrixMathFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrixMathFilter_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMatrixMathFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrixMathFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMatrixMathFilter SafeDownCast(vtkObjectBase o)
	{
		vtkMatrixMathFilter vtkMatrixMathFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrixMathFilter_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrixMathFilter2 = (vtkMatrixMathFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrixMathFilter2.Register(null);
			}
		}
		return vtkMatrixMathFilter2;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrixMathFilter_SetOperation_09(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of query.
	/// </summary>
	public virtual void SetOperation(int _arg)
	{
		vtkMatrixMathFilter_SetOperation_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrixMathFilter_SetOperationToDeterminant_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of query.
	/// </summary>
	public void SetOperationToDeterminant()
	{
		vtkMatrixMathFilter_SetOperationToDeterminant_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrixMathFilter_SetOperationToEigenvalue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of query.
	/// </summary>
	public void SetOperationToEigenvalue()
	{
		vtkMatrixMathFilter_SetOperationToEigenvalue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrixMathFilter_SetOperationToEigenvector_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of query.
	/// </summary>
	public void SetOperationToEigenvector()
	{
		vtkMatrixMathFilter_SetOperationToEigenvector_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrixMathFilter_SetOperationToInverse_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of query.
	/// </summary>
	public void SetOperationToInverse()
	{
		vtkMatrixMathFilter_SetOperationToInverse_13(GetCppThis());
	}
}
