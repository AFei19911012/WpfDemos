using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractEdges
/// </summary>
/// <remarks>
///    extract cell edges from any type of dataset
///
/// vtkExtractEdges is a filter to extract edges from a dataset. Edges
/// are extracted as lines in an output vtkPolyData.
///
/// There are two modes of extraction depending on the data member
/// UseAllPoints, If UseAllPoints is enabled, then the output points contain
/// all of the input points, and the point ids of the output lines (i.e.,
/// edges) remain unchanged from the input point numbering.  If UseAllPoints
/// is disabled (which is the default), then the numbering of the output points
/// may change, and any unused points are omitted from the filter output.
///
/// @warning
/// If present in the filter input, output cell data is produced for the
/// output edges. Since an edge may be used by more than one cell, this is
/// potentially an undefined behavior. To ensure deterministic output, the
/// cell data from the cell with smallest cell id is copied to the output
/// edge.
///
/// </remarks>
/// <seealso>
///
/// vtkFeatureEdges
/// </seealso>
public class vtkExtractEdges : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractEdges";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractEdges()
	{
		MRClassNameKey = "class vtkExtractEdges";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractEdges"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an instance.
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public new static vtkExtractEdges New()
	{
		vtkExtractEdges result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an instance.
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public vtkExtractEdges()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEdges_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkExtractEdges_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractEdges_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default an instance
	/// of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractEdges_GetLocator_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkExtractEdges_GetMTime_03(HandleRef pThis);

	/// <summary>
	/// Return the modified time also considering the locator since it may be
	/// modified independent of this filter.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExtractEdges_GetMTime_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractEdges_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an instance.
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractEdges_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractEdges_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an instance.
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractEdges_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractEdges_GetUseAllPoints_06(HandleRef pThis);

	/// <summary>
	/// Indicates whether all of the points of the input mesh should exist in
	/// the output, i.e., whether point renumbering is permitted. By default,
	/// UseAllPoints is disabled, so that unused points are omitted from the
	/// output.
	/// </summary>
	public virtual bool GetUseAllPoints()
	{
		return (vtkExtractEdges_GetUseAllPoints_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractEdges_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an instance.
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractEdges_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractEdges_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an instance.
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractEdges_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractEdges_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an instance.
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public new vtkExtractEdges NewInstance()
	{
		vtkExtractEdges result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractEdges_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractEdges_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of an instance.
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public new static vtkExtractEdges SafeDownCast(vtkObjectBase o)
	{
		vtkExtractEdges vtkExtractEdges2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractEdges_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractEdges2 = (vtkExtractEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractEdges2.Register(null);
			}
		}
		return vtkExtractEdges2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEdges_SetLocator_12(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default an instance
	/// of vtkMergePoints is used.
	/// </summary>
	public virtual void SetLocator(vtkIncrementalPointLocator _arg)
	{
		vtkExtractEdges_SetLocator_12(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEdges_SetUseAllPoints_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicates whether all of the points of the input mesh should exist in
	/// the output, i.e., whether point renumbering is permitted. By default,
	/// UseAllPoints is disabled, so that unused points are omitted from the
	/// output.
	/// </summary>
	public virtual void SetUseAllPoints(bool _arg)
	{
		vtkExtractEdges_SetUseAllPoints_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEdges_UseAllPointsOff_14(HandleRef pThis);

	/// <summary>
	/// Indicates whether all of the points of the input mesh should exist in
	/// the output, i.e., whether point renumbering is permitted. By default,
	/// UseAllPoints is disabled, so that unused points are omitted from the
	/// output.
	/// </summary>
	public virtual void UseAllPointsOff()
	{
		vtkExtractEdges_UseAllPointsOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractEdges_UseAllPointsOn_15(HandleRef pThis);

	/// <summary>
	/// Indicates whether all of the points of the input mesh should exist in
	/// the output, i.e., whether point renumbering is permitted. By default,
	/// UseAllPoints is disabled, so that unused points are omitted from the
	/// output.
	/// </summary>
	public virtual void UseAllPointsOn()
	{
		vtkExtractEdges_UseAllPointsOn_15(GetCppThis());
	}
}
