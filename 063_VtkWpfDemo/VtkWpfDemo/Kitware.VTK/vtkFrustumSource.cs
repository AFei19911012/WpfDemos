using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFrustumSource
/// </summary>
/// <remarks>
///    create a polygonal representation of a frustum
///
/// vtkFrustumSource creates a frustum defines by a set of planes. The frustum
/// is represented with four-sided polygons. It is possible to specify extra
/// lines to better visualize the field of view.
///
/// @par Usage:
/// Typical use consists of 3 steps:
/// 1. get the planes coefficients from a vtkCamera with
/// vtkCamera::GetFrustumPlanes()
/// 2. initialize the planes with vtkPlanes::SetFrustumPlanes() with the planes
/// coefficients
/// 3. pass the vtkPlanes to a vtkFrustumSource.
/// </remarks>
public class vtkFrustumSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFrustumSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFrustumSource()
	{
		MRClassNameKey = "class vtkFrustumSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrustumSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFrustumSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrustumSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFrustumSource New()
	{
		vtkFrustumSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFrustumSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFrustumSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFrustumSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFrustumSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkFrustumSource_GetLinesLength_01(HandleRef pThis);

	/// <summary>
	/// Length of the extra lines. This a strictly positive value.
	/// Initial value is 1.0.
	/// </summary>
	public virtual double GetLinesLength()
	{
		return vtkFrustumSource_GetLinesLength_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkFrustumSource_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// Modified GetMTime because of Planes.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkFrustumSource_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFrustumSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFrustumSource_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFrustumSource_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFrustumSource_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrustumSource_GetOutputPointsPrecision_05(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkFrustumSource_GetOutputPointsPrecision_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrustumSource_GetPlanes_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the 6 planes defining the frustum. Initial value is nullptr.
	/// The 6 planes are defined in this order: left,right,bottom,top,far,near.
	/// If Planes==nullptr or if Planes-&gt;GetNumberOfPlanes()!=6 when RequestData()
	/// is called, an error message will be emitted and RequestData() will
	/// return right away.
	/// </summary>
	public virtual vtkPlanes GetPlanes()
	{
		vtkPlanes vtkPlanes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFrustumSource_GetPlanes_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlanes2 = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlanes2.Register(null);
			}
		}
		return vtkPlanes2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFrustumSource_GetShowLines_07(HandleRef pThis);

	/// <summary>
	/// Tells if some extra lines will be generated. Initial value is true.
	/// </summary>
	public virtual bool GetShowLines()
	{
		return (vtkFrustumSource_GetShowLines_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrustumSource_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFrustumSource_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFrustumSource_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFrustumSource_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrustumSource_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFrustumSource NewInstance()
	{
		vtkFrustumSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFrustumSource_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFrustumSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFrustumSource_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFrustumSource SafeDownCast(vtkObjectBase o)
	{
		vtkFrustumSource vtkFrustumSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFrustumSource_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFrustumSource2 = (vtkFrustumSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFrustumSource2.Register(null);
			}
		}
		return vtkFrustumSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumSource_SetLinesLength_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Length of the extra lines. This a strictly positive value.
	/// Initial value is 1.0.
	/// </summary>
	public virtual void SetLinesLength(double _arg)
	{
		vtkFrustumSource_SetLinesLength_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumSource_SetOutputPointsPrecision_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkFrustumSource_SetOutputPointsPrecision_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumSource_SetPlanes_15(HandleRef pThis, HandleRef planes);

	/// <summary>
	/// Set the 6 planes defining the frustum.
	/// </summary>
	public virtual void SetPlanes(vtkPlanes planes)
	{
		vtkFrustumSource_SetPlanes_15(GetCppThis(), planes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumSource_SetShowLines_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Tells if some extra lines will be generated. Initial value is true.
	/// </summary>
	public virtual void SetShowLines(bool _arg)
	{
		vtkFrustumSource_SetShowLines_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumSource_ShowLinesOff_17(HandleRef pThis);

	/// <summary>
	/// Tells if some extra lines will be generated. Initial value is true.
	/// </summary>
	public virtual void ShowLinesOff()
	{
		vtkFrustumSource_ShowLinesOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFrustumSource_ShowLinesOn_18(HandleRef pThis);

	/// <summary>
	/// Tells if some extra lines will be generated. Initial value is true.
	/// </summary>
	public virtual void ShowLinesOn()
	{
		vtkFrustumSource_ShowLinesOn_18(GetCppThis());
	}
}
