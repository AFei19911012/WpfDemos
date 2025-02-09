using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDiagonalMatrixSource
/// </summary>
/// <remarks>
///    generates a sparse or dense square matrix
/// with user-specified values for the diagonal, superdiagonal, and subdiagonal.
///
/// @par Thanks:
/// </remarks>
/// <seealso>
/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
/// </seealso>
public class vtkDiagonalMatrixSource : vtkArrayDataAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum StorageType
	{
		/// <summary>enum member</summary>
		DENSE,
		/// <summary>enum member</summary>
		SPARSE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDiagonalMatrixSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDiagonalMatrixSource()
	{
		MRClassNameKey = "class vtkDiagonalMatrixSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiagonalMatrixSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDiagonalMatrixSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiagonalMatrixSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDiagonalMatrixSource New()
	{
		vtkDiagonalMatrixSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiagonalMatrixSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiagonalMatrixSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDiagonalMatrixSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDiagonalMatrixSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiagonalMatrixSource_GetArrayType_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetArrayType()
	{
		return vtkDiagonalMatrixSource_GetArrayType_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiagonalMatrixSource_GetColumnLabel_02(HandleRef pThis);

	/// <summary>
	/// Controls the output matrix column dimension label.
	/// Default: "columns"
	/// </summary>
	public virtual string GetColumnLabel()
	{
		return Marshal.PtrToStringAnsi(vtkDiagonalMatrixSource_GetColumnLabel_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiagonalMatrixSource_GetDiagonal_03(HandleRef pThis);

	/// <summary>
	/// Stores the value that will be assigned to diagonal elements (default: 1)
	/// </summary>
	public virtual double GetDiagonal()
	{
		return vtkDiagonalMatrixSource_GetDiagonal_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiagonalMatrixSource_GetExtents_04(HandleRef pThis);

	/// <summary>
	/// Stores the extents of the output matrix (which is square)
	/// </summary>
	public virtual long GetExtents()
	{
		return vtkDiagonalMatrixSource_GetExtents_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiagonalMatrixSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDiagonalMatrixSource_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiagonalMatrixSource_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDiagonalMatrixSource_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiagonalMatrixSource_GetRowLabel_07(HandleRef pThis);

	/// <summary>
	/// Controls the output matrix row dimension label.
	/// Default: "rows"
	/// </summary>
	public virtual string GetRowLabel()
	{
		return Marshal.PtrToStringAnsi(vtkDiagonalMatrixSource_GetRowLabel_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiagonalMatrixSource_GetSubDiagonal_08(HandleRef pThis);

	/// <summary>
	/// Stores the value that will be assigned to subdiagonal elements (default: 0)
	/// </summary>
	public virtual double GetSubDiagonal()
	{
		return vtkDiagonalMatrixSource_GetSubDiagonal_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiagonalMatrixSource_GetSuperDiagonal_09(HandleRef pThis);

	/// <summary>
	/// Stores the value that will be assigned to superdiagonal elements (default: 0)
	/// </summary>
	public virtual double GetSuperDiagonal()
	{
		return vtkDiagonalMatrixSource_GetSuperDiagonal_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiagonalMatrixSource_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDiagonalMatrixSource_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiagonalMatrixSource_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDiagonalMatrixSource_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiagonalMatrixSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDiagonalMatrixSource NewInstance()
	{
		vtkDiagonalMatrixSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiagonalMatrixSource_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiagonalMatrixSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiagonalMatrixSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDiagonalMatrixSource SafeDownCast(vtkObjectBase o)
	{
		vtkDiagonalMatrixSource vtkDiagonalMatrixSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiagonalMatrixSource_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDiagonalMatrixSource2 = (vtkDiagonalMatrixSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDiagonalMatrixSource2.Register(null);
			}
		}
		return vtkDiagonalMatrixSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiagonalMatrixSource_SetArrayType_15(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetArrayType(int _arg)
	{
		vtkDiagonalMatrixSource_SetArrayType_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiagonalMatrixSource_SetColumnLabel_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Controls the output matrix column dimension label.
	/// Default: "columns"
	/// </summary>
	public virtual void SetColumnLabel(string _arg)
	{
		vtkDiagonalMatrixSource_SetColumnLabel_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiagonalMatrixSource_SetDiagonal_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Stores the value that will be assigned to diagonal elements (default: 1)
	/// </summary>
	public virtual void SetDiagonal(double _arg)
	{
		vtkDiagonalMatrixSource_SetDiagonal_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiagonalMatrixSource_SetExtents_18(HandleRef pThis, long _arg);

	/// <summary>
	/// Stores the extents of the output matrix (which is square)
	/// </summary>
	public virtual void SetExtents(long _arg)
	{
		vtkDiagonalMatrixSource_SetExtents_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiagonalMatrixSource_SetRowLabel_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Controls the output matrix row dimension label.
	/// Default: "rows"
	/// </summary>
	public virtual void SetRowLabel(string _arg)
	{
		vtkDiagonalMatrixSource_SetRowLabel_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiagonalMatrixSource_SetSubDiagonal_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Stores the value that will be assigned to subdiagonal elements (default: 0)
	/// </summary>
	public virtual void SetSubDiagonal(double _arg)
	{
		vtkDiagonalMatrixSource_SetSubDiagonal_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiagonalMatrixSource_SetSuperDiagonal_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Stores the value that will be assigned to superdiagonal elements (default: 0)
	/// </summary>
	public virtual void SetSuperDiagonal(double _arg)
	{
		vtkDiagonalMatrixSource_SetSuperDiagonal_21(GetCppThis(), _arg);
	}
}
