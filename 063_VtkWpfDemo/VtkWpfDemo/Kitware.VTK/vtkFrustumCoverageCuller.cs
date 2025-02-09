using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFrustumCoverageCuller
/// </summary>
/// <remarks>
///    cull props based on frustum coverage
///
/// vtkFrustumCoverageCuller will cull props based on the coverage in
/// the view frustum. The coverage is computed by enclosing the prop in
/// a bounding sphere, projecting that to the viewing coordinate system, then
/// taking a slice through the view frustum at the center of the sphere. This
/// results in a circle on the plane slice through the view frustum. This
/// circle is enclosed in a squared, and the fraction of the plane slice that
/// this square covers is the coverage. This is a number between 0 and 1.
/// If the number is less than the MinimumCoverage, the allocated render time
/// for that prop is set to zero. If it is greater than the MaximumCoverage,
/// the allocated render time is set to 1.0. In between, a linear ramp is used
/// to convert coverage into allocated render time.
///
/// </remarks>
/// <seealso>
///
/// vtkCuller
/// </seealso>
public class vtkFrustumCoverageCuller : vtkCuller
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFrustumCoverageCuller";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFrustumCoverageCuller()
	{
		MRClassNameKey = "class vtkFrustumCoverageCuller";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrustumCoverageCuller"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFrustumCoverageCuller(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrustumCoverageCuller_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFrustumCoverageCuller New()
	{
		vtkFrustumCoverageCuller result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFrustumCoverageCuller_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFrustumCoverageCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFrustumCoverageCuller()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFrustumCoverageCuller_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFrustumCoverageCuller_GetMaximumCoverage_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum coverage - props with more coverage than this are
	/// given an allocated render time of 1.0 (the maximum)
	/// </summary>
	public virtual double GetMaximumCoverage()
	{
		return vtkFrustumCoverageCuller_GetMaximumCoverage_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFrustumCoverageCuller_GetMinimumCoverage_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum coverage - props with less coverage than this
	/// are given no time to render (they are culled)
	/// </summary>
	public virtual double GetMinimumCoverage()
	{
		return vtkFrustumCoverageCuller_GetMinimumCoverage_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFrustumCoverageCuller_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFrustumCoverageCuller_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFrustumCoverageCuller_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFrustumCoverageCuller_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrustumCoverageCuller_GetSortingStyle_05(HandleRef pThis);

	/// <summary>
	/// Set the sorting style - none, front-to-back or back-to-front
	/// The default is none
	/// </summary>
	public virtual int GetSortingStyle()
	{
		return vtkFrustumCoverageCuller_GetSortingStyle_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrustumCoverageCuller_GetSortingStyleAsString_06(HandleRef pThis);

	/// <summary>
	/// Set the sorting style - none, front-to-back or back-to-front
	/// The default is none
	/// </summary>
	public string GetSortingStyleAsString()
	{
		return Marshal.PtrToStringAnsi(vtkFrustumCoverageCuller_GetSortingStyleAsString_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrustumCoverageCuller_GetSortingStyleMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set the sorting style - none, front-to-back or back-to-front
	/// The default is none
	/// </summary>
	public virtual int GetSortingStyleMaxValue()
	{
		return vtkFrustumCoverageCuller_GetSortingStyleMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrustumCoverageCuller_GetSortingStyleMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set the sorting style - none, front-to-back or back-to-front
	/// The default is none
	/// </summary>
	public virtual int GetSortingStyleMinValue()
	{
		return vtkFrustumCoverageCuller_GetSortingStyleMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrustumCoverageCuller_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFrustumCoverageCuller_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrustumCoverageCuller_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFrustumCoverageCuller_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrustumCoverageCuller_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFrustumCoverageCuller NewInstance()
	{
		vtkFrustumCoverageCuller result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFrustumCoverageCuller_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFrustumCoverageCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrustumCoverageCuller_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFrustumCoverageCuller SafeDownCast(vtkObjectBase o)
	{
		vtkFrustumCoverageCuller vtkFrustumCoverageCuller2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFrustumCoverageCuller_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFrustumCoverageCuller2 = (vtkFrustumCoverageCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFrustumCoverageCuller2.Register(null);
			}
		}
		return vtkFrustumCoverageCuller2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumCoverageCuller_SetMaximumCoverage_14(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the maximum coverage - props with more coverage than this are
	/// given an allocated render time of 1.0 (the maximum)
	/// </summary>
	public virtual void SetMaximumCoverage(double _arg)
	{
		vtkFrustumCoverageCuller_SetMaximumCoverage_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumCoverageCuller_SetMinimumCoverage_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the minimum coverage - props with less coverage than this
	/// are given no time to render (they are culled)
	/// </summary>
	public virtual void SetMinimumCoverage(double _arg)
	{
		vtkFrustumCoverageCuller_SetMinimumCoverage_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumCoverageCuller_SetSortingStyle_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the sorting style - none, front-to-back or back-to-front
	/// The default is none
	/// </summary>
	public virtual void SetSortingStyle(int _arg)
	{
		vtkFrustumCoverageCuller_SetSortingStyle_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumCoverageCuller_SetSortingStyleToBackToFront_17(HandleRef pThis);

	/// <summary>
	/// Set the sorting style - none, front-to-back or back-to-front
	/// The default is none
	/// </summary>
	public void SetSortingStyleToBackToFront()
	{
		vtkFrustumCoverageCuller_SetSortingStyleToBackToFront_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumCoverageCuller_SetSortingStyleToFrontToBack_18(HandleRef pThis);

	/// <summary>
	/// Set the sorting style - none, front-to-back or back-to-front
	/// The default is none
	/// </summary>
	public void SetSortingStyleToFrontToBack()
	{
		vtkFrustumCoverageCuller_SetSortingStyleToFrontToBack_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumCoverageCuller_SetSortingStyleToNone_19(HandleRef pThis);

	/// <summary>
	/// Set the sorting style - none, front-to-back or back-to-front
	/// The default is none
	/// </summary>
	public void SetSortingStyleToNone()
	{
		vtkFrustumCoverageCuller_SetSortingStyleToNone_19(GetCppThis());
	}
}
