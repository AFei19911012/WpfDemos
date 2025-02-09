using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractHierarchicalBins
/// </summary>
/// <remarks>
///    manipulate the output of
/// vtkHierarchicalBinningFilter
///
///
/// vtkExtractHierarchicalBins enables users to extract data from the output
/// of vtkHierarchicalBinningFilter. Points at a particular level, or at a
/// level and bin number, can be filtered to the output. To perform these
/// operations, the output must contain points sorted into bins (the
/// vtkPoints), with offsets pointing to the beginning of each bin (a
/// vtkFieldData array named "BinOffsets").
///
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkFiltersPointsFilter vtkRadiusOutlierRemoval vtkStatisticalOutlierRemoval
/// vtkThresholdPoints vtkImplicitFunction vtkExtractGeometry
/// vtkFitImplicitFunction
/// </seealso>
public class vtkExtractHierarchicalBins : vtkPointCloudFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractHierarchicalBins";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractHierarchicalBins()
	{
		MRClassNameKey = "class vtkExtractHierarchicalBins";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractHierarchicalBins"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractHierarchicalBins(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHierarchicalBins_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkExtractHierarchicalBins New()
	{
		vtkExtractHierarchicalBins result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHierarchicalBins_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractHierarchicalBins)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkExtractHierarchicalBins()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractHierarchicalBins_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHierarchicalBins_GetBin_01(HandleRef pThis);

	/// <summary>
	/// Specify the bin number to extract. If a non-negative value, then the
	/// points from the bin number specified are extracted. If negative, then
	/// entire levels of points are extacted (assuming the Level is
	/// non-negative). Note that the bin tree is flattened, a particular bin
	/// number may refer to a bin on any level. Note that requesting a bin
	/// greater than the associated vtkHierarchicalBinningFilter will clamp the
	/// bin to the maximum possible bin of the binning filter.
	/// </summary>
	public virtual int GetBin()
	{
		return vtkExtractHierarchicalBins_GetBin_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHierarchicalBins_GetBinningFilter_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the vtkHierarchicalBinningFilter to query for relevant
	/// information. Make sure that this filter has executed prior to the execution of
	/// this filter. (This is generally a safe bet if connected in a pipeline.)
	/// </summary>
	public virtual vtkHierarchicalBinningFilter GetBinningFilter()
	{
		vtkHierarchicalBinningFilter vtkHierarchicalBinningFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHierarchicalBins_GetBinningFilter_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHierarchicalBinningFilter2 = (vtkHierarchicalBinningFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHierarchicalBinningFilter2.Register(null);
			}
		}
		return vtkHierarchicalBinningFilter2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHierarchicalBins_GetLevel_03(HandleRef pThis);

	/// <summary>
	/// Specify the level to extract. If non-negative, with a negative bin
	/// number, then all points at this level are extracted and sent to the
	/// output. If negative, then the points from the specified bin are sent to
	/// the output. If both the level and bin number are negative values, then
	/// the input is sent to the output. By default the 0th level is
	/// extracted. Note that requesting a level greater than the associated
	/// vtkHierarchicalBinningFilter will clamp the level to the maximum
	/// possible level of the binning filter.
	/// </summary>
	public virtual int GetLevel()
	{
		return vtkExtractHierarchicalBins_GetLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractHierarchicalBins_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractHierarchicalBins_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractHierarchicalBins_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractHierarchicalBins_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHierarchicalBins_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractHierarchicalBins_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHierarchicalBins_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractHierarchicalBins_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHierarchicalBins_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkExtractHierarchicalBins NewInstance()
	{
		vtkExtractHierarchicalBins result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHierarchicalBins_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractHierarchicalBins)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHierarchicalBins_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkExtractHierarchicalBins SafeDownCast(vtkObjectBase o)
	{
		vtkExtractHierarchicalBins vtkExtractHierarchicalBins2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHierarchicalBins_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractHierarchicalBins2 = (vtkExtractHierarchicalBins)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractHierarchicalBins2.Register(null);
			}
		}
		return vtkExtractHierarchicalBins2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHierarchicalBins_SetBin_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the bin number to extract. If a non-negative value, then the
	/// points from the bin number specified are extracted. If negative, then
	/// entire levels of points are extacted (assuming the Level is
	/// non-negative). Note that the bin tree is flattened, a particular bin
	/// number may refer to a bin on any level. Note that requesting a bin
	/// greater than the associated vtkHierarchicalBinningFilter will clamp the
	/// bin to the maximum possible bin of the binning filter.
	/// </summary>
	public virtual void SetBin(int _arg)
	{
		vtkExtractHierarchicalBins_SetBin_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHierarchicalBins_SetBinningFilter_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the vtkHierarchicalBinningFilter to query for relevant
	/// information. Make sure that this filter has executed prior to the execution of
	/// this filter. (This is generally a safe bet if connected in a pipeline.)
	/// </summary>
	public virtual void SetBinningFilter(vtkHierarchicalBinningFilter arg0)
	{
		vtkExtractHierarchicalBins_SetBinningFilter_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHierarchicalBins_SetLevel_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the level to extract. If non-negative, with a negative bin
	/// number, then all points at this level are extracted and sent to the
	/// output. If negative, then the points from the specified bin are sent to
	/// the output. If both the level and bin number are negative values, then
	/// the input is sent to the output. By default the 0th level is
	/// extracted. Note that requesting a level greater than the associated
	/// vtkHierarchicalBinningFilter will clamp the level to the maximum
	/// possible level of the binning filter.
	/// </summary>
	public virtual void SetLevel(int _arg)
	{
		vtkExtractHierarchicalBins_SetLevel_13(GetCppThis(), _arg);
	}
}
