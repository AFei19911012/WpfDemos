using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProjectSphereFilter
/// </summary>
/// <remarks>
///    A filter to 'unroll' a sphere.  The
/// unroll longitude is -180.
///
///
/// </remarks>
public class vtkProjectSphereFilter : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProjectSphereFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProjectSphereFilter()
	{
		MRClassNameKey = "class vtkProjectSphereFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectSphereFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProjectSphereFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectSphereFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProjectSphereFilter New()
	{
		vtkProjectSphereFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectSphereFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectSphereFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProjectSphereFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProjectSphereFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectSphereFilter_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Set the center of the sphere to be split. Default is 0,0,0.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkProjectSphereFilter_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectSphereFilter_GetCenter_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the center of the sphere to be split. Default is 0,0,0.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkProjectSphereFilter_GetCenter_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProjectSphereFilter_GetKeepPolePoints_03(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to keep the cells using a point at
	/// a pole. The default is false.
	/// </summary>
	public virtual bool GetKeepPolePoints()
	{
		return (vtkProjectSphereFilter_GetKeepPolePoints_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectSphereFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProjectSphereFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProjectSphereFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProjectSphereFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProjectSphereFilter_GetTranslateZ_06(HandleRef pThis);

	/// <summary>
	/// Specify whether (true) or not to translate the points in the projected
	/// transformation such that the input point with the smallest
	/// radius is at 0. The default is false.
	/// </summary>
	public virtual bool GetTranslateZ()
	{
		return (vtkProjectSphereFilter_GetTranslateZ_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectSphereFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProjectSphereFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProjectSphereFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProjectSphereFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectSphereFilter_KeepPolePointsOff_09(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to keep the cells using a point at
	/// a pole. The default is false.
	/// </summary>
	public virtual void KeepPolePointsOff()
	{
		vtkProjectSphereFilter_KeepPolePointsOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectSphereFilter_KeepPolePointsOn_10(HandleRef pThis);

	/// <summary>
	/// Specify whether or not to keep the cells using a point at
	/// a pole. The default is false.
	/// </summary>
	public virtual void KeepPolePointsOn()
	{
		vtkProjectSphereFilter_KeepPolePointsOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectSphereFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProjectSphereFilter NewInstance()
	{
		vtkProjectSphereFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectSphereFilter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProjectSphereFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProjectSphereFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProjectSphereFilter SafeDownCast(vtkObjectBase o)
	{
		vtkProjectSphereFilter vtkProjectSphereFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProjectSphereFilter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProjectSphereFilter2 = (vtkProjectSphereFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProjectSphereFilter2.Register(null);
			}
		}
		return vtkProjectSphereFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectSphereFilter_SetCenter_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the center of the sphere to be split. Default is 0,0,0.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkProjectSphereFilter_SetCenter_14(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectSphereFilter_SetCenter_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the center of the sphere to be split. Default is 0,0,0.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkProjectSphereFilter_SetCenter_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectSphereFilter_SetKeepPolePoints_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether or not to keep the cells using a point at
	/// a pole. The default is false.
	/// </summary>
	public virtual void SetKeepPolePoints(bool _arg)
	{
		vtkProjectSphereFilter_SetKeepPolePoints_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectSphereFilter_SetTranslateZ_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether (true) or not to translate the points in the projected
	/// transformation such that the input point with the smallest
	/// radius is at 0. The default is false.
	/// </summary>
	public virtual void SetTranslateZ(bool _arg)
	{
		vtkProjectSphereFilter_SetTranslateZ_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectSphereFilter_TranslateZOff_18(HandleRef pThis);

	/// <summary>
	/// Specify whether (true) or not to translate the points in the projected
	/// transformation such that the input point with the smallest
	/// radius is at 0. The default is false.
	/// </summary>
	public virtual void TranslateZOff()
	{
		vtkProjectSphereFilter_TranslateZOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProjectSphereFilter_TranslateZOn_19(HandleRef pThis);

	/// <summary>
	/// Specify whether (true) or not to translate the points in the projected
	/// transformation such that the input point with the smallest
	/// radius is at 0. The default is false.
	/// </summary>
	public virtual void TranslateZOn()
	{
		vtkProjectSphereFilter_TranslateZOn_19(GetCppThis());
	}
}
