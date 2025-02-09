using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUncertaintyTubeFilter
/// </summary>
/// <remarks>
///    generate uncertainty tubes along a polyline
///
/// vtkUncertaintyTubeFilter is a filter that generates ellipsoidal (in cross
/// section) tubes that follows a polyline. The input is a vtkPolyData with
/// polylines that have associated vector point data. The vector data represents
/// the uncertainty of the polyline in the x-y-z directions.
///
/// @warning
/// The vector uncertainty values define an axis-aligned ellipsoid at each
/// polyline point. The uncertainty tubes can be envisioned as the
/// interpolation of these ellipsoids between the points defining the
/// polyline (or rather, the interpolation of the cross section of the
/// ellipsoids along the polyline).
///
/// </remarks>
/// <seealso>
///
/// vtkTensorGlyph vtkStreamTracer
/// </seealso>
public class vtkUncertaintyTubeFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUncertaintyTubeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUncertaintyTubeFilter()
	{
		MRClassNameKey = "class vtkUncertaintyTubeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUncertaintyTubeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUncertaintyTubeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUncertaintyTubeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Object factory method to instantiate this class.
	/// </summary>
	public new static vtkUncertaintyTubeFilter New()
	{
		vtkUncertaintyTubeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUncertaintyTubeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUncertaintyTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Object factory method to instantiate this class.
	/// </summary>
	public vtkUncertaintyTubeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUncertaintyTubeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkUncertaintyTubeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for printing and obtaining type information for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUncertaintyTubeFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUncertaintyTubeFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for printing and obtaining type information for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUncertaintyTubeFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUncertaintyTubeFilter_GetNumberOfSides_03(HandleRef pThis);

	/// <summary>
	/// Set / get the number of sides for the tube. At a minimum,
	/// the number of sides is 3.
	/// </summary>
	public virtual int GetNumberOfSides()
	{
		return vtkUncertaintyTubeFilter_GetNumberOfSides_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUncertaintyTubeFilter_GetNumberOfSidesMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set / get the number of sides for the tube. At a minimum,
	/// the number of sides is 3.
	/// </summary>
	public virtual int GetNumberOfSidesMaxValue()
	{
		return vtkUncertaintyTubeFilter_GetNumberOfSidesMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUncertaintyTubeFilter_GetNumberOfSidesMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set / get the number of sides for the tube. At a minimum,
	/// the number of sides is 3.
	/// </summary>
	public virtual int GetNumberOfSidesMinValue()
	{
		return vtkUncertaintyTubeFilter_GetNumberOfSidesMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUncertaintyTubeFilter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for printing and obtaining type information for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUncertaintyTubeFilter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUncertaintyTubeFilter_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for printing and obtaining type information for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUncertaintyTubeFilter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUncertaintyTubeFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for printing and obtaining type information for instances of this class.
	/// </summary>
	public new vtkUncertaintyTubeFilter NewInstance()
	{
		vtkUncertaintyTubeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUncertaintyTubeFilter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUncertaintyTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUncertaintyTubeFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for printing and obtaining type information for instances of this class.
	/// </summary>
	public new static vtkUncertaintyTubeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkUncertaintyTubeFilter vtkUncertaintyTubeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUncertaintyTubeFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUncertaintyTubeFilter2 = (vtkUncertaintyTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUncertaintyTubeFilter2.Register(null);
			}
		}
		return vtkUncertaintyTubeFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUncertaintyTubeFilter_SetNumberOfSides_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / get the number of sides for the tube. At a minimum,
	/// the number of sides is 3.
	/// </summary>
	public virtual void SetNumberOfSides(int _arg)
	{
		vtkUncertaintyTubeFilter_SetNumberOfSides_11(GetCppThis(), _arg);
	}
}
