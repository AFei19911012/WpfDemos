using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTimeSource
/// </summary>
/// <remarks>
///    creates a simple time varying data set.
///
/// Creates a small easily understood time varying data set for testing.
/// The output is a vtkUntructuredGrid in which the point and cell values vary
/// over time in a sin wave. The analytic ivar controls whether the output
/// corresponds to a step function over time or is continuous.
/// The X and Y Amplitude ivars make the output move in the X and Y directions
/// over time. The Growing ivar makes the number of cells in the output grow
/// and then shrink over time.
/// </remarks>
public class vtkTimeSourceExample : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTimeSourceExample";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTimeSourceExample()
	{
		MRClassNameKey = "class vtkTimeSourceExample";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimeSourceExample"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTimeSourceExample(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimeSourceExample_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTimeSourceExample New()
	{
		vtkTimeSourceExample result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTimeSourceExample_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTimeSourceExample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTimeSourceExample()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTimeSourceExample_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTimeSourceExample_AnalyticOff_01(HandleRef pThis);

	/// <summary>
	/// When off (the default) this source produces a discrete set of values.
	/// When on, this source produces a value analytically for any queried time.
	/// </summary>
	public virtual void AnalyticOff()
	{
		vtkTimeSourceExample_AnalyticOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimeSourceExample_AnalyticOn_02(HandleRef pThis);

	/// <summary>
	/// When off (the default) this source produces a discrete set of values.
	/// When on, this source produces a value analytically for any queried time.
	/// </summary>
	public virtual void AnalyticOn()
	{
		vtkTimeSourceExample_AnalyticOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimeSourceExample_GetAnalytic_03(HandleRef pThis);

	/// <summary>
	/// When off (the default) this source produces a discrete set of values.
	/// When on, this source produces a value analytically for any queried time.
	/// </summary>
	public virtual int GetAnalytic()
	{
		return vtkTimeSourceExample_GetAnalytic_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimeSourceExample_GetAnalyticMaxValue_04(HandleRef pThis);

	/// <summary>
	/// When off (the default) this source produces a discrete set of values.
	/// When on, this source produces a value analytically for any queried time.
	/// </summary>
	public virtual int GetAnalyticMaxValue()
	{
		return vtkTimeSourceExample_GetAnalyticMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimeSourceExample_GetAnalyticMinValue_05(HandleRef pThis);

	/// <summary>
	/// When off (the default) this source produces a discrete set of values.
	/// When on, this source produces a value analytically for any queried time.
	/// </summary>
	public virtual int GetAnalyticMinValue()
	{
		return vtkTimeSourceExample_GetAnalyticMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimeSourceExample_GetGrowing_06(HandleRef pThis);

	/// <summary>
	/// When off (the default) this produces a single cell data set.
	/// When on the number of cells (in the Y direction) grows
	/// and shrinks over time along a hat function.
	/// </summary>
	public virtual int GetGrowing()
	{
		return vtkTimeSourceExample_GetGrowing_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimeSourceExample_GetGrowingMaxValue_07(HandleRef pThis);

	/// <summary>
	/// When off (the default) this produces a single cell data set.
	/// When on the number of cells (in the Y direction) grows
	/// and shrinks over time along a hat function.
	/// </summary>
	public virtual int GetGrowingMaxValue()
	{
		return vtkTimeSourceExample_GetGrowingMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimeSourceExample_GetGrowingMinValue_08(HandleRef pThis);

	/// <summary>
	/// When off (the default) this produces a single cell data set.
	/// When on the number of cells (in the Y direction) grows
	/// and shrinks over time along a hat function.
	/// </summary>
	public virtual int GetGrowingMinValue()
	{
		return vtkTimeSourceExample_GetGrowingMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTimeSourceExample_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTimeSourceExample_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTimeSourceExample_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTimeSourceExample_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTimeSourceExample_GetXAmplitude_11(HandleRef pThis);

	/// <summary>
	/// When 0.0 (the default) this produces a data set that is stationary.
	/// When on the data set moves in the X/Y plane over a sin wave over time,
	/// amplified by the value.
	/// </summary>
	public virtual double GetXAmplitude()
	{
		return vtkTimeSourceExample_GetXAmplitude_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTimeSourceExample_GetYAmplitude_12(HandleRef pThis);

	/// <summary>
	/// When 0.0 (the default) this produces a data set that is stationary.
	/// When on the data set moves in the X/Y plane over a sin wave over time,
	/// amplified by the value.
	/// </summary>
	public virtual double GetYAmplitude()
	{
		return vtkTimeSourceExample_GetYAmplitude_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimeSourceExample_GrowingOff_13(HandleRef pThis);

	/// <summary>
	/// When off (the default) this produces a single cell data set.
	/// When on the number of cells (in the Y direction) grows
	/// and shrinks over time along a hat function.
	/// </summary>
	public virtual void GrowingOff()
	{
		vtkTimeSourceExample_GrowingOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimeSourceExample_GrowingOn_14(HandleRef pThis);

	/// <summary>
	/// When off (the default) this produces a single cell data set.
	/// When on the number of cells (in the Y direction) grows
	/// and shrinks over time along a hat function.
	/// </summary>
	public virtual void GrowingOn()
	{
		vtkTimeSourceExample_GrowingOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimeSourceExample_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTimeSourceExample_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimeSourceExample_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTimeSourceExample_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimeSourceExample_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTimeSourceExample NewInstance()
	{
		vtkTimeSourceExample result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTimeSourceExample_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTimeSourceExample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimeSourceExample_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTimeSourceExample SafeDownCast(vtkObjectBase o)
	{
		vtkTimeSourceExample vtkTimeSourceExample2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTimeSourceExample_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTimeSourceExample2 = (vtkTimeSourceExample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTimeSourceExample2.Register(null);
			}
		}
		return vtkTimeSourceExample2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimeSourceExample_SetAnalytic_20(HandleRef pThis, int _arg);

	/// <summary>
	/// When off (the default) this source produces a discrete set of values.
	/// When on, this source produces a value analytically for any queried time.
	/// </summary>
	public virtual void SetAnalytic(int _arg)
	{
		vtkTimeSourceExample_SetAnalytic_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimeSourceExample_SetGrowing_21(HandleRef pThis, int _arg);

	/// <summary>
	/// When off (the default) this produces a single cell data set.
	/// When on the number of cells (in the Y direction) grows
	/// and shrinks over time along a hat function.
	/// </summary>
	public virtual void SetGrowing(int _arg)
	{
		vtkTimeSourceExample_SetGrowing_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimeSourceExample_SetXAmplitude_22(HandleRef pThis, double _arg);

	/// <summary>
	/// When 0.0 (the default) this produces a data set that is stationary.
	/// When on the data set moves in the X/Y plane over a sin wave over time,
	/// amplified by the value.
	/// </summary>
	public virtual void SetXAmplitude(double _arg)
	{
		vtkTimeSourceExample_SetXAmplitude_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimeSourceExample_SetYAmplitude_23(HandleRef pThis, double _arg);

	/// <summary>
	/// When 0.0 (the default) this produces a data set that is stationary.
	/// When on the data set moves in the X/Y plane over a sin wave over time,
	/// amplified by the value.
	/// </summary>
	public virtual void SetYAmplitude(double _arg)
	{
		vtkTimeSourceExample_SetYAmplitude_23(GetCppThis(), _arg);
	}
}
