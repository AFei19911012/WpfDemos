using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBrownianPoints
/// </summary>
/// <remarks>
///    assign random vector to points
///
/// vtkBrownianPoints is a filter object that assigns a random vector (i.e.,
/// magnitude and direction) to each point. The minimum and maximum speed
/// values can be controlled by the user.
///
/// </remarks>
/// <seealso>
///
/// vtkRandomAttributeGenerator
/// </seealso>
public class vtkBrownianPoints : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBrownianPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBrownianPoints()
	{
		MRClassNameKey = "class vtkBrownianPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBrownianPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBrownianPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrownianPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create instance with minimum speed 0.0, maximum speed 1.0.
	/// </summary>
	public new static vtkBrownianPoints New()
	{
		vtkBrownianPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrownianPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBrownianPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create instance with minimum speed 0.0, maximum speed 1.0.
	/// </summary>
	public vtkBrownianPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBrownianPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkBrownianPoints_GetMaximumSpeed_01(HandleRef pThis);

	/// <summary>
	/// Set the maximum speed value.
	/// </summary>
	public virtual double GetMaximumSpeed()
	{
		return vtkBrownianPoints_GetMaximumSpeed_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBrownianPoints_GetMaximumSpeedMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set the maximum speed value.
	/// </summary>
	public virtual double GetMaximumSpeedMaxValue()
	{
		return vtkBrownianPoints_GetMaximumSpeedMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBrownianPoints_GetMaximumSpeedMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set the maximum speed value.
	/// </summary>
	public virtual double GetMaximumSpeedMinValue()
	{
		return vtkBrownianPoints_GetMaximumSpeedMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBrownianPoints_GetMinimumSpeed_04(HandleRef pThis);

	/// <summary>
	/// Set the minimum speed value.
	/// </summary>
	public virtual double GetMinimumSpeed()
	{
		return vtkBrownianPoints_GetMinimumSpeed_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBrownianPoints_GetMinimumSpeedMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the minimum speed value.
	/// </summary>
	public virtual double GetMinimumSpeedMaxValue()
	{
		return vtkBrownianPoints_GetMinimumSpeedMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBrownianPoints_GetMinimumSpeedMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the minimum speed value.
	/// </summary>
	public virtual double GetMinimumSpeedMinValue()
	{
		return vtkBrownianPoints_GetMinimumSpeedMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBrownianPoints_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Create instance with minimum speed 0.0, maximum speed 1.0.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBrownianPoints_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBrownianPoints_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Create instance with minimum speed 0.0, maximum speed 1.0.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBrownianPoints_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrownianPoints_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Create instance with minimum speed 0.0, maximum speed 1.0.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBrownianPoints_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrownianPoints_IsTypeOf_10(string type);

	/// <summary>
	/// Create instance with minimum speed 0.0, maximum speed 1.0.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBrownianPoints_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrownianPoints_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create instance with minimum speed 0.0, maximum speed 1.0.
	/// </summary>
	public new vtkBrownianPoints NewInstance()
	{
		vtkBrownianPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrownianPoints_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBrownianPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrownianPoints_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create instance with minimum speed 0.0, maximum speed 1.0.
	/// </summary>
	public new static vtkBrownianPoints SafeDownCast(vtkObjectBase o)
	{
		vtkBrownianPoints vtkBrownianPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrownianPoints_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBrownianPoints2 = (vtkBrownianPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBrownianPoints2.Register(null);
			}
		}
		return vtkBrownianPoints2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrownianPoints_SetMaximumSpeed_14(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the maximum speed value.
	/// </summary>
	public virtual void SetMaximumSpeed(double _arg)
	{
		vtkBrownianPoints_SetMaximumSpeed_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrownianPoints_SetMinimumSpeed_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the minimum speed value.
	/// </summary>
	public virtual void SetMinimumSpeed(double _arg)
	{
		vtkBrownianPoints_SetMinimumSpeed_15(GetCppThis(), _arg);
	}
}
