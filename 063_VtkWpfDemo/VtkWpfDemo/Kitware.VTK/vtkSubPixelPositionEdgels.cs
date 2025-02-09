using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSubPixelPositionEdgels
/// </summary>
/// <remarks>
///    adjust edgel locations based on gradients.
///
/// vtkSubPixelPositionEdgels is a filter that takes a series of linked
/// edgels (digital curves) and gradient maps as input. It then adjusts
/// the edgel locations based on the gradient data. Specifically, the
/// algorithm first determines the neighboring gradient magnitudes of
/// an edgel using simple interpolation of its neighbors. It then fits
/// the following three data points: negative gradient direction
/// gradient magnitude, edgel gradient magnitude and positive gradient
/// direction gradient magnitude to a quadratic function. It then
/// solves this quadratic to find the maximum gradient location along
/// the gradient orientation.  It then modifies the edgels location
/// along the gradient orientation to the calculated maximum
/// location. This algorithm does not adjust an edgel in the direction
/// orthogonal to its gradient vector.
///
/// </remarks>
/// <seealso>
///
/// vtkImageData vtkImageGradient vtkLinkEdgels
/// </seealso>
public class vtkSubPixelPositionEdgels : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSubPixelPositionEdgels";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSubPixelPositionEdgels()
	{
		MRClassNameKey = "class vtkSubPixelPositionEdgels";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubPixelPositionEdgels"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSubPixelPositionEdgels(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubPixelPositionEdgels_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSubPixelPositionEdgels New()
	{
		vtkSubPixelPositionEdgels result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubPixelPositionEdgels_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSubPixelPositionEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSubPixelPositionEdgels()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSubPixelPositionEdgels_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSubPixelPositionEdgels_GetGradMaps_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the gradient data for doing the position adjustments.
	/// </summary>
	public vtkStructuredPoints GetGradMaps()
	{
		vtkStructuredPoints vtkStructuredPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubPixelPositionEdgels_GetGradMaps_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredPoints2 = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredPoints2.Register(null);
			}
		}
		return vtkStructuredPoints2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSubPixelPositionEdgels_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSubPixelPositionEdgels_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSubPixelPositionEdgels_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSubPixelPositionEdgels_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubPixelPositionEdgels_GetTargetFlag_04(HandleRef pThis);

	/// <summary>
	/// These methods can make the positioning look for a target scalar value
	/// instead of looking for a maximum.
	/// </summary>
	public virtual int GetTargetFlag()
	{
		return vtkSubPixelPositionEdgels_GetTargetFlag_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSubPixelPositionEdgels_GetTargetValue_05(HandleRef pThis);

	/// <summary>
	/// These methods can make the positioning look for a target scalar value
	/// instead of looking for a maximum.
	/// </summary>
	public virtual double GetTargetValue()
	{
		return vtkSubPixelPositionEdgels_GetTargetValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubPixelPositionEdgels_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSubPixelPositionEdgels_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubPixelPositionEdgels_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSubPixelPositionEdgels_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubPixelPositionEdgels_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSubPixelPositionEdgels NewInstance()
	{
		vtkSubPixelPositionEdgels result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubPixelPositionEdgels_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSubPixelPositionEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubPixelPositionEdgels_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSubPixelPositionEdgels SafeDownCast(vtkObjectBase o)
	{
		vtkSubPixelPositionEdgels vtkSubPixelPositionEdgels2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubPixelPositionEdgels_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSubPixelPositionEdgels2 = (vtkSubPixelPositionEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSubPixelPositionEdgels2.Register(null);
			}
		}
		return vtkSubPixelPositionEdgels2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubPixelPositionEdgels_SetGradMapsData_11(HandleRef pThis, HandleRef gm);

	/// <summary>
	/// Set/Get the gradient data for doing the position adjustments.
	/// </summary>
	public void SetGradMapsData(vtkStructuredPoints gm)
	{
		vtkSubPixelPositionEdgels_SetGradMapsData_11(GetCppThis(), gm?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubPixelPositionEdgels_SetTargetFlag_12(HandleRef pThis, int _arg);

	/// <summary>
	/// These methods can make the positioning look for a target scalar value
	/// instead of looking for a maximum.
	/// </summary>
	public virtual void SetTargetFlag(int _arg)
	{
		vtkSubPixelPositionEdgels_SetTargetFlag_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubPixelPositionEdgels_SetTargetValue_13(HandleRef pThis, double _arg);

	/// <summary>
	/// These methods can make the positioning look for a target scalar value
	/// instead of looking for a maximum.
	/// </summary>
	public virtual void SetTargetValue(double _arg)
	{
		vtkSubPixelPositionEdgels_SetTargetValue_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubPixelPositionEdgels_TargetFlagOff_14(HandleRef pThis);

	/// <summary>
	/// These methods can make the positioning look for a target scalar value
	/// instead of looking for a maximum.
	/// </summary>
	public virtual void TargetFlagOff()
	{
		vtkSubPixelPositionEdgels_TargetFlagOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubPixelPositionEdgels_TargetFlagOn_15(HandleRef pThis);

	/// <summary>
	/// These methods can make the positioning look for a target scalar value
	/// instead of looking for a maximum.
	/// </summary>
	public virtual void TargetFlagOn()
	{
		vtkSubPixelPositionEdgels_TargetFlagOn_15(GetCppThis());
	}
}
