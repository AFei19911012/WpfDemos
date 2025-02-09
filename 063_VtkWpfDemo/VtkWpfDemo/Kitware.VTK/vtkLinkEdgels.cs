using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLinkEdgels
/// </summary>
/// <remarks>
///    links edgels together to form digital curves.
///
/// vtkLinkEdgels links edgels into digital curves which are then stored
/// as polylines. The algorithm works one pixel at a time only looking at
/// its immediate neighbors. There is a GradientThreshold that can be set
/// that eliminates any pixels with a smaller gradient value. This can
/// be used as the lower threshold of a two value edgel thresholding.
///
/// For the remaining edgels, links are first tried for the four
/// connected neighbors.  A successful neighbor will satisfy three
/// tests. First both edgels must be above the gradient
/// threshold. Second, the difference between the orientation between
/// the two edgels (Alpha) and each edgels orientation (Phi) must be
/// less than LinkThreshold. Third, the difference between the two
/// edgels Phi values must be less than PhiThreshold.
/// The most successful link is selected. The measure is simply the
/// sum of the three angle differences (actually stored as the sum of
/// the cosines). If none of the four connect neighbors succeeds, then
/// the eight connect neighbors are examined using the same method.
///
/// This filter requires gradient information so you will need to use
/// a vtkImageGradient at some point prior to this filter.  Typically
/// a vtkNonMaximumSuppression filter is also used. vtkThresholdEdgels
/// can be used to complete the two value edgel thresholding as used
/// in a Canny edge detector. The vtkSubpixelPositionEdgels filter
/// can also be used after this filter to adjust the edgel locations.
///
/// </remarks>
/// <seealso>
///
/// vtkImageData vtkImageGradient vtkImageNonMaximumSuppression
/// </seealso>
public class vtkLinkEdgels : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLinkEdgels";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLinkEdgels()
	{
		MRClassNameKey = "class vtkLinkEdgels";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinkEdgels"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLinkEdgels(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinkEdgels_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct instance of vtkLinkEdgels with GradientThreshold set to
	/// 0.1, PhiThreshold set to 90 degrees and LinkThreshold set to 90 degrees.
	/// </summary>
	public new static vtkLinkEdgels New()
	{
		vtkLinkEdgels result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinkEdgels_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinkEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct instance of vtkLinkEdgels with GradientThreshold set to
	/// 0.1, PhiThreshold set to 90 degrees and LinkThreshold set to 90 degrees.
	/// </summary>
	public vtkLinkEdgels()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLinkEdgels_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkLinkEdgels_GetGradientThreshold_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the threshold for image gradient thresholding.
	/// </summary>
	public virtual double GetGradientThreshold()
	{
		return vtkLinkEdgels_GetGradientThreshold_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLinkEdgels_GetLinkThreshold_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the threshold for Phi vs. Alpha link thresholding.
	/// </summary>
	public virtual double GetLinkThreshold()
	{
		return vtkLinkEdgels_GetLinkThreshold_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinkEdgels_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLinkEdgels_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinkEdgels_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLinkEdgels_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLinkEdgels_GetPhiThreshold_05(HandleRef pThis);

	/// <summary>
	/// Set/get the threshold for Phi vs. Phi link thresholding.
	/// </summary>
	public virtual double GetPhiThreshold()
	{
		return vtkLinkEdgels_GetPhiThreshold_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinkEdgels_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLinkEdgels_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinkEdgels_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLinkEdgels_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinkEdgels_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLinkEdgels NewInstance()
	{
		vtkLinkEdgels result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinkEdgels_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinkEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinkEdgels_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLinkEdgels SafeDownCast(vtkObjectBase o)
	{
		vtkLinkEdgels vtkLinkEdgels2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinkEdgels_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinkEdgels2 = (vtkLinkEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinkEdgels2.Register(null);
			}
		}
		return vtkLinkEdgels2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinkEdgels_SetGradientThreshold_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the threshold for image gradient thresholding.
	/// </summary>
	public virtual void SetGradientThreshold(double _arg)
	{
		vtkLinkEdgels_SetGradientThreshold_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinkEdgels_SetLinkThreshold_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the threshold for Phi vs. Alpha link thresholding.
	/// </summary>
	public virtual void SetLinkThreshold(double _arg)
	{
		vtkLinkEdgels_SetLinkThreshold_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinkEdgels_SetPhiThreshold_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the threshold for Phi vs. Phi link thresholding.
	/// </summary>
	public virtual void SetPhiThreshold(double _arg)
	{
		vtkLinkEdgels_SetPhiThreshold_13(GetCppThis(), _arg);
	}
}
