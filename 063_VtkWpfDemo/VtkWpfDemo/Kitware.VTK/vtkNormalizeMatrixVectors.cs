using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNormalizeMatrixVectors
/// </summary>
/// <remarks>
///    given a sparse input matrix, produces
/// a sparse output matrix with each vector normalized to unit length with respect
/// to a p-norm (default p=2).
///
/// @par Thanks:
/// </remarks>
/// <seealso>
/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
/// </seealso>
public class vtkNormalizeMatrixVectors : vtkArrayDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNormalizeMatrixVectors";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNormalizeMatrixVectors()
	{
		MRClassNameKey = "class vtkNormalizeMatrixVectors";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNormalizeMatrixVectors"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNormalizeMatrixVectors(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNormalizeMatrixVectors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNormalizeMatrixVectors New()
	{
		vtkNormalizeMatrixVectors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNormalizeMatrixVectors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNormalizeMatrixVectors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNormalizeMatrixVectors()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNormalizeMatrixVectors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkNormalizeMatrixVectors_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNormalizeMatrixVectors_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNormalizeMatrixVectors_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNormalizeMatrixVectors_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNormalizeMatrixVectors_GetPValue_03(HandleRef pThis);

	/// <summary>
	/// Value of p in p-norm normalization, subject to p &gt;= 1.  Default is p=2 (Euclidean norm).
	/// </summary>
	public virtual double GetPValue()
	{
		return vtkNormalizeMatrixVectors_GetPValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNormalizeMatrixVectors_GetVectorDimension_04(HandleRef pThis);

	/// <summary>
	/// Controls whether to normalize row-vectors or column-vectors.  0 = rows, 1 = columns.
	/// </summary>
	public virtual int GetVectorDimension()
	{
		return vtkNormalizeMatrixVectors_GetVectorDimension_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNormalizeMatrixVectors_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNormalizeMatrixVectors_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNormalizeMatrixVectors_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNormalizeMatrixVectors_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNormalizeMatrixVectors_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNormalizeMatrixVectors NewInstance()
	{
		vtkNormalizeMatrixVectors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNormalizeMatrixVectors_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNormalizeMatrixVectors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNormalizeMatrixVectors_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNormalizeMatrixVectors SafeDownCast(vtkObjectBase o)
	{
		vtkNormalizeMatrixVectors vtkNormalizeMatrixVectors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNormalizeMatrixVectors_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNormalizeMatrixVectors2 = (vtkNormalizeMatrixVectors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNormalizeMatrixVectors2.Register(null);
			}
		}
		return vtkNormalizeMatrixVectors2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNormalizeMatrixVectors_SetPValue_10(HandleRef pThis, double _arg);

	/// <summary>
	/// Value of p in p-norm normalization, subject to p &gt;= 1.  Default is p=2 (Euclidean norm).
	/// </summary>
	public virtual void SetPValue(double _arg)
	{
		vtkNormalizeMatrixVectors_SetPValue_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNormalizeMatrixVectors_SetVectorDimension_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Controls whether to normalize row-vectors or column-vectors.  0 = rows, 1 = columns.
	/// </summary>
	public virtual void SetVectorDimension(int _arg)
	{
		vtkNormalizeMatrixVectors_SetVectorDimension_11(GetCppThis(), _arg);
	}
}
