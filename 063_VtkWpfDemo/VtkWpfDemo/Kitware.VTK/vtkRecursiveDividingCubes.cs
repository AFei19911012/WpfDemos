using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRecursiveDividingCubes
/// </summary>
/// <remarks>
///    create points laying on isosurface (using recursive approach)
///
/// vtkRecursiveDividingCubes is a filter that generates points laying on a
/// surface of constant scalar value (i.e., an isosurface). Dense point
/// clouds (i.e., at screen resolution) will appear as a surface. Less dense
/// clouds can be used as a source to generate streamlines or to generate
/// "transparent" surfaces.
///
/// This implementation differs from vtkDividingCubes in that it uses a
/// recursive procedure. In many cases this can result in generating
/// more points than the procedural implementation of vtkDividingCubes. This is
/// because the recursive procedure divides voxels by multiples of powers of
/// two. This can over-constrain subdivision. One of the advantages of the
/// recursive technique is that the recursion is terminated earlier, which in
/// some cases can be more efficient.
///
/// </remarks>
/// <seealso>
///
/// vtkDividingCubes vtkContourFilter vtkMarchingCubes
/// </seealso>
public class vtkRecursiveDividingCubes : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRecursiveDividingCubes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRecursiveDividingCubes()
	{
		MRClassNameKey = "class vtkRecursiveDividingCubes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRecursiveDividingCubes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRecursiveDividingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRecursiveDividingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRecursiveDividingCubes New()
	{
		vtkRecursiveDividingCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRecursiveDividingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRecursiveDividingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRecursiveDividingCubes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRecursiveDividingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkRecursiveDividingCubes_GetDistance_01(HandleRef pThis);

	/// <summary>
	/// Specify sub-voxel size at which to generate point.
	/// </summary>
	public virtual double GetDistance()
	{
		return vtkRecursiveDividingCubes_GetDistance_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRecursiveDividingCubes_GetDistanceMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Specify sub-voxel size at which to generate point.
	/// </summary>
	public virtual double GetDistanceMaxValue()
	{
		return vtkRecursiveDividingCubes_GetDistanceMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRecursiveDividingCubes_GetDistanceMinValue_03(HandleRef pThis);

	/// <summary>
	/// Specify sub-voxel size at which to generate point.
	/// </summary>
	public virtual double GetDistanceMinValue()
	{
		return vtkRecursiveDividingCubes_GetDistanceMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveDividingCubes_GetIncrement_04(HandleRef pThis);

	/// <summary>
	/// Every "Increment" point is added to the list of points. This parameter, if
	/// set to a large value, can be used to limit the number of points while
	/// retaining good accuracy.
	/// </summary>
	public virtual int GetIncrement()
	{
		return vtkRecursiveDividingCubes_GetIncrement_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveDividingCubes_GetIncrementMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Every "Increment" point is added to the list of points. This parameter, if
	/// set to a large value, can be used to limit the number of points while
	/// retaining good accuracy.
	/// </summary>
	public virtual int GetIncrementMaxValue()
	{
		return vtkRecursiveDividingCubes_GetIncrementMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveDividingCubes_GetIncrementMinValue_06(HandleRef pThis);

	/// <summary>
	/// Every "Increment" point is added to the list of points. This parameter, if
	/// set to a large value, can be used to limit the number of points while
	/// retaining good accuracy.
	/// </summary>
	public virtual int GetIncrementMinValue()
	{
		return vtkRecursiveDividingCubes_GetIncrementMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRecursiveDividingCubes_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRecursiveDividingCubes_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRecursiveDividingCubes_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRecursiveDividingCubes_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRecursiveDividingCubes_GetValue_09(HandleRef pThis);

	/// <summary>
	/// Set isosurface value.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkRecursiveDividingCubes_GetValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveDividingCubes_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRecursiveDividingCubes_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRecursiveDividingCubes_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRecursiveDividingCubes_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRecursiveDividingCubes_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRecursiveDividingCubes NewInstance()
	{
		vtkRecursiveDividingCubes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRecursiveDividingCubes_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRecursiveDividingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRecursiveDividingCubes_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRecursiveDividingCubes SafeDownCast(vtkObjectBase o)
	{
		vtkRecursiveDividingCubes vtkRecursiveDividingCubes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRecursiveDividingCubes_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRecursiveDividingCubes2 = (vtkRecursiveDividingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRecursiveDividingCubes2.Register(null);
			}
		}
		return vtkRecursiveDividingCubes2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRecursiveDividingCubes_SetDistance_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify sub-voxel size at which to generate point.
	/// </summary>
	public virtual void SetDistance(double _arg)
	{
		vtkRecursiveDividingCubes_SetDistance_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRecursiveDividingCubes_SetIncrement_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Every "Increment" point is added to the list of points. This parameter, if
	/// set to a large value, can be used to limit the number of points while
	/// retaining good accuracy.
	/// </summary>
	public virtual void SetIncrement(int _arg)
	{
		vtkRecursiveDividingCubes_SetIncrement_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRecursiveDividingCubes_SetValue_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set isosurface value.
	/// </summary>
	public virtual void SetValue(double _arg)
	{
		vtkRecursiveDividingCubes_SetValue_17(GetCppThis(), _arg);
	}
}
