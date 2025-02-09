using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSplineGraphEdges
/// </summary>
/// <remarks>
///    subsample graph edges to make smooth curves
///
///
/// vtkSplineGraphEdges uses a vtkSpline to make edges into nicely sampled
/// splines. By default, the filter will use an optimized b-spline.
/// Otherwise, it will use a custom vtkSpline instance set by the user.
/// </remarks>
public class vtkSplineGraphEdges : vtkGraphAlgorithm
{
	/// <summary>
	/// If SplineType is CUSTOM, uses this spline.
	/// </summary>
	public enum BSPLINE_WrapperEnum
	{
		/// <summary>enum member</summary>
		BSPLINE,
		/// <summary>enum member</summary>
		CUSTOM
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSplineGraphEdges";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSplineGraphEdges()
	{
		MRClassNameKey = "class vtkSplineGraphEdges";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineGraphEdges"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSplineGraphEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineGraphEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSplineGraphEdges New()
	{
		vtkSplineGraphEdges result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineGraphEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplineGraphEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSplineGraphEdges()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSplineGraphEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplineGraphEdges_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSplineGraphEdges_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplineGraphEdges_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSplineGraphEdges_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplineGraphEdges_GetNumberOfSubdivisions_03(HandleRef pThis);

	/// <summary>
	/// The number of subdivisions in the spline.
	/// </summary>
	public virtual long GetNumberOfSubdivisions()
	{
		return vtkSplineGraphEdges_GetNumberOfSubdivisions_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineGraphEdges_GetSpline_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If SplineType is CUSTOM, uses this spline.
	/// </summary>
	public virtual vtkSpline GetSpline()
	{
		vtkSpline vtkSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineGraphEdges_GetSpline_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpline2 = (vtkSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpline2.Register(null);
			}
		}
		return vtkSpline2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineGraphEdges_GetSplineType_05(HandleRef pThis);

	/// <summary>
	/// Spline type used by the filter.
	/// BSPLINE (0) - Use optimized b-spline (default).
	/// CUSTOM (1) - Use spline set with SetSpline.
	/// </summary>
	public virtual int GetSplineType()
	{
		return vtkSplineGraphEdges_GetSplineType_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineGraphEdges_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSplineGraphEdges_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineGraphEdges_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSplineGraphEdges_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineGraphEdges_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSplineGraphEdges NewInstance()
	{
		vtkSplineGraphEdges result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineGraphEdges_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplineGraphEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineGraphEdges_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSplineGraphEdges SafeDownCast(vtkObjectBase o)
	{
		vtkSplineGraphEdges vtkSplineGraphEdges2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineGraphEdges_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSplineGraphEdges2 = (vtkSplineGraphEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSplineGraphEdges2.Register(null);
			}
		}
		return vtkSplineGraphEdges2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineGraphEdges_SetNumberOfSubdivisions_11(HandleRef pThis, long _arg);

	/// <summary>
	/// The number of subdivisions in the spline.
	/// </summary>
	public virtual void SetNumberOfSubdivisions(long _arg)
	{
		vtkSplineGraphEdges_SetNumberOfSubdivisions_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineGraphEdges_SetSpline_12(HandleRef pThis, HandleRef s);

	/// <summary>
	/// If SplineType is CUSTOM, uses this spline.
	/// </summary>
	public virtual void SetSpline(vtkSpline s)
	{
		vtkSplineGraphEdges_SetSpline_12(GetCppThis(), s?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineGraphEdges_SetSplineType_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Spline type used by the filter.
	/// BSPLINE (0) - Use optimized b-spline (default).
	/// CUSTOM (1) - Use spline set with SetSpline.
	/// </summary>
	public virtual void SetSplineType(int _arg)
	{
		vtkSplineGraphEdges_SetSplineType_13(GetCppThis(), _arg);
	}
}
