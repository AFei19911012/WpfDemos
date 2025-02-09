using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStackedTreeLayoutStrategy
/// </summary>
/// <remarks>
///    lays out tree in stacked boxes or rings
///
///
/// Performs a tree ring layout or "icicle" layout on a tree.
/// This involves assigning a sector region to each vertex in the tree,
/// and placing that information in a data array with four components per
/// tuple representing (innerRadius, outerRadius, startAngle, endAngle).
///
/// This class may be assigned as the layout strategy to vtkAreaLayout.
///
/// @par Thanks:
/// Thanks to Jason Shepherd from Sandia National Laboratories
/// for help developing this class.
/// </remarks>
public class vtkStackedTreeLayoutStrategy : vtkAreaLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStackedTreeLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStackedTreeLayoutStrategy()
	{
		MRClassNameKey = "class vtkStackedTreeLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStackedTreeLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStackedTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStackedTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStackedTreeLayoutStrategy New()
	{
		vtkStackedTreeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStackedTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStackedTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStackedTreeLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStackedTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkStackedTreeLayoutStrategy_FindVertex_01(HandleRef pThis, HandleRef tree, HandleRef array, IntPtr pnt);

	/// <summary>
	/// Returns the vertex id that contains pnt (or -1 if no one contains it).
	/// </summary>
	public override long FindVertex(vtkTree tree, vtkDataArray array, IntPtr pnt)
	{
		return vtkStackedTreeLayoutStrategy_FindVertex_01(GetCppThis(), tree?.GetCppThis() ?? default(HandleRef), array?.GetCppThis() ?? default(HandleRef), pnt);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStackedTreeLayoutStrategy_GetInteriorLogSpacingValue_02(HandleRef pThis);

	/// <summary>
	/// The spacing of tree levels in the edge routing tree.
	/// Levels near zero give more space
	/// to levels near the root, while levels near one (the default)
	/// create evenly-spaced levels. Levels above one give more space
	/// to levels near the leaves.
	/// </summary>
	public virtual double GetInteriorLogSpacingValue()
	{
		return vtkStackedTreeLayoutStrategy_GetInteriorLogSpacingValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStackedTreeLayoutStrategy_GetInteriorRadius_03(HandleRef pThis);

	/// <summary>
	/// Define the tree ring's interior radius.
	/// </summary>
	public virtual double GetInteriorRadius()
	{
		return vtkStackedTreeLayoutStrategy_GetInteriorRadius_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStackedTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStackedTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStackedTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStackedTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStackedTreeLayoutStrategy_GetReverse_06(HandleRef pThis);

	/// <summary>
	/// Define whether to reverse the order of the tree stacks from
	/// low to high.
	/// </summary>
	public virtual bool GetReverse()
	{
		return (vtkStackedTreeLayoutStrategy_GetReverse_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStackedTreeLayoutStrategy_GetRingThickness_07(HandleRef pThis);

	/// <summary>
	/// Define the thickness of each of the tree rings.
	/// </summary>
	public virtual double GetRingThickness()
	{
		return vtkStackedTreeLayoutStrategy_GetRingThickness_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStackedTreeLayoutStrategy_GetRootEndAngle_08(HandleRef pThis);

	/// <summary>
	/// Define the end angle for the root node.
	/// NOTE: It is assumed that the root end angle is greater than the
	/// root start angle and subtends no more than 360 degrees.
	/// </summary>
	public virtual double GetRootEndAngle()
	{
		return vtkStackedTreeLayoutStrategy_GetRootEndAngle_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStackedTreeLayoutStrategy_GetRootStartAngle_09(HandleRef pThis);

	/// <summary>
	/// Define the start angle for the root node.
	/// NOTE: It is assumed that the root end angle is greater than the
	/// root start angle and subtends no more than 360 degrees.
	/// </summary>
	public virtual double GetRootStartAngle()
	{
		return vtkStackedTreeLayoutStrategy_GetRootStartAngle_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStackedTreeLayoutStrategy_GetUseRectangularCoordinates_10(HandleRef pThis);

	/// <summary>
	/// Define whether or not rectangular coordinates are being used
	/// (as opposed to polar coordinates).
	/// </summary>
	public virtual bool GetUseRectangularCoordinates()
	{
		return (vtkStackedTreeLayoutStrategy_GetUseRectangularCoordinates_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStackedTreeLayoutStrategy_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStackedTreeLayoutStrategy_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStackedTreeLayoutStrategy_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStackedTreeLayoutStrategy_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_Layout_13(HandleRef pThis, HandleRef inputTree, HandleRef sectorArray, HandleRef sizeArray);

	/// <summary>
	/// Perform the layout of the input tree, and store the sector
	/// bounds of each vertex as a tuple
	/// (innerRadius, outerRadius, startAngle, endAngle)
	/// in a data array.
	/// </summary>
	public override void Layout(vtkTree inputTree, vtkDataArray sectorArray, vtkDataArray sizeArray)
	{
		vtkStackedTreeLayoutStrategy_Layout_13(GetCppThis(), inputTree?.GetCppThis() ?? default(HandleRef), sectorArray?.GetCppThis() ?? default(HandleRef), sizeArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_LayoutEdgePoints_14(HandleRef pThis, HandleRef inputTree, HandleRef sectorArray, HandleRef sizeArray, HandleRef edgeRoutingTree);

	/// <summary>
	/// Fill edgeRoutingTree with points suitable for routing edges of
	/// an overlaid graph.
	/// </summary>
	public override void LayoutEdgePoints(vtkTree inputTree, vtkDataArray sectorArray, vtkDataArray sizeArray, vtkTree edgeRoutingTree)
	{
		vtkStackedTreeLayoutStrategy_LayoutEdgePoints_14(GetCppThis(), inputTree?.GetCppThis() ?? default(HandleRef), sectorArray?.GetCppThis() ?? default(HandleRef), sizeArray?.GetCppThis() ?? default(HandleRef), edgeRoutingTree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStackedTreeLayoutStrategy_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStackedTreeLayoutStrategy NewInstance()
	{
		vtkStackedTreeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStackedTreeLayoutStrategy_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStackedTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_ReverseOff_17(HandleRef pThis);

	/// <summary>
	/// Define whether to reverse the order of the tree stacks from
	/// low to high.
	/// </summary>
	public virtual void ReverseOff()
	{
		vtkStackedTreeLayoutStrategy_ReverseOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_ReverseOn_18(HandleRef pThis);

	/// <summary>
	/// Define whether to reverse the order of the tree stacks from
	/// low to high.
	/// </summary>
	public virtual void ReverseOn()
	{
		vtkStackedTreeLayoutStrategy_ReverseOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStackedTreeLayoutStrategy_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStackedTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkStackedTreeLayoutStrategy vtkStackedTreeLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStackedTreeLayoutStrategy_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStackedTreeLayoutStrategy2 = (vtkStackedTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStackedTreeLayoutStrategy2.Register(null);
			}
		}
		return vtkStackedTreeLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_SetInteriorLogSpacingValue_20(HandleRef pThis, double _arg);

	/// <summary>
	/// The spacing of tree levels in the edge routing tree.
	/// Levels near zero give more space
	/// to levels near the root, while levels near one (the default)
	/// create evenly-spaced levels. Levels above one give more space
	/// to levels near the leaves.
	/// </summary>
	public virtual void SetInteriorLogSpacingValue(double _arg)
	{
		vtkStackedTreeLayoutStrategy_SetInteriorLogSpacingValue_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_SetInteriorRadius_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Define the tree ring's interior radius.
	/// </summary>
	public virtual void SetInteriorRadius(double _arg)
	{
		vtkStackedTreeLayoutStrategy_SetInteriorRadius_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_SetReverse_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Define whether to reverse the order of the tree stacks from
	/// low to high.
	/// </summary>
	public virtual void SetReverse(bool _arg)
	{
		vtkStackedTreeLayoutStrategy_SetReverse_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_SetRingThickness_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Define the thickness of each of the tree rings.
	/// </summary>
	public virtual void SetRingThickness(double _arg)
	{
		vtkStackedTreeLayoutStrategy_SetRingThickness_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_SetRootEndAngle_24(HandleRef pThis, double _arg);

	/// <summary>
	/// Define the end angle for the root node.
	/// NOTE: It is assumed that the root end angle is greater than the
	/// root start angle and subtends no more than 360 degrees.
	/// </summary>
	public virtual void SetRootEndAngle(double _arg)
	{
		vtkStackedTreeLayoutStrategy_SetRootEndAngle_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_SetRootStartAngle_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Define the start angle for the root node.
	/// NOTE: It is assumed that the root end angle is greater than the
	/// root start angle and subtends no more than 360 degrees.
	/// </summary>
	public virtual void SetRootStartAngle(double _arg)
	{
		vtkStackedTreeLayoutStrategy_SetRootStartAngle_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_SetUseRectangularCoordinates_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Define whether or not rectangular coordinates are being used
	/// (as opposed to polar coordinates).
	/// </summary>
	public virtual void SetUseRectangularCoordinates(bool _arg)
	{
		vtkStackedTreeLayoutStrategy_SetUseRectangularCoordinates_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOff_27(HandleRef pThis);

	/// <summary>
	/// Define whether or not rectangular coordinates are being used
	/// (as opposed to polar coordinates).
	/// </summary>
	public virtual void UseRectangularCoordinatesOff()
	{
		vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOn_28(HandleRef pThis);

	/// <summary>
	/// Define whether or not rectangular coordinates are being used
	/// (as opposed to polar coordinates).
	/// </summary>
	public virtual void UseRectangularCoordinatesOn()
	{
		vtkStackedTreeLayoutStrategy_UseRectangularCoordinatesOn_28(GetCppThis());
	}
}
