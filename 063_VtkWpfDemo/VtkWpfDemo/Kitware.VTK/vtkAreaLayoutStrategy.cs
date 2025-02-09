using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAreaLayoutStrategy
/// </summary>
/// <remarks>
///    abstract superclass for all area layout strategies
///
///
/// All subclasses of this class perform a area layout on a tree.
/// This involves assigning a region to each vertex in the tree,
/// and placing that information in a data array with four components per
/// tuple representing (innerRadius, outerRadius, startAngle, endAngle).
///
/// Instances of subclasses of this class may be assigned as the layout
/// strategy to vtkAreaLayout
///
/// @par Thanks:
/// Thanks to Jason Shepherd from Sandia National Laboratories
/// for help developing this class.
/// </remarks>
public abstract class vtkAreaLayoutStrategy : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAreaLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAreaLayoutStrategy()
	{
		MRClassNameKey = "class vtkAreaLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAreaLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern long vtkAreaLayoutStrategy_FindVertex_01(HandleRef pThis, HandleRef tree, HandleRef array, IntPtr pnt);

	/// <summary>
	/// Returns the vertex id that contains pnt (or -1 if no one contains it)
	/// </summary>
	public virtual long FindVertex(vtkTree tree, vtkDataArray array, IntPtr pnt)
	{
		return vtkAreaLayoutStrategy_FindVertex_01(GetCppThis(), tree?.GetCppThis() ?? default(HandleRef), array?.GetCppThis() ?? default(HandleRef), pnt);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaLayoutStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAreaLayoutStrategy_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAreaLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAreaLayoutStrategy_GetShrinkPercentage_04(HandleRef pThis);

	/// <summary>
	/// Returns the vertex id that contains pnt (or -1 if no one contains it)
	/// </summary>
	public virtual double GetShrinkPercentage()
	{
		return vtkAreaLayoutStrategy_GetShrinkPercentage_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAreaLayoutStrategy_GetShrinkPercentageMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Returns the vertex id that contains pnt (or -1 if no one contains it)
	/// </summary>
	public virtual double GetShrinkPercentageMaxValue()
	{
		return vtkAreaLayoutStrategy_GetShrinkPercentageMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAreaLayoutStrategy_GetShrinkPercentageMinValue_06(HandleRef pThis);

	/// <summary>
	/// Returns the vertex id that contains pnt (or -1 if no one contains it)
	/// </summary>
	public virtual double GetShrinkPercentageMinValue()
	{
		return vtkAreaLayoutStrategy_GetShrinkPercentageMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaLayoutStrategy_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAreaLayoutStrategy_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaLayoutStrategy_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAreaLayoutStrategy_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayoutStrategy_Layout_09(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray);

	/// <summary>
	/// Perform the layout of the input tree, and store the sector
	/// bounds of each vertex as a tuple in a data array.
	/// For radial layout, this is
	/// (innerRadius, outerRadius, startAngle, endAngle).
	/// For rectangular layout, this is
	/// (xmin, xmax, ymin, ymax).
	///
	/// The sizeArray may be nullptr, or may contain the desired
	/// size of each vertex in the tree.
	/// </summary>
	public virtual void Layout(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray)
	{
		vtkAreaLayoutStrategy_Layout_09(GetCppThis(), inputTree?.GetCppThis() ?? default(HandleRef), areaArray?.GetCppThis() ?? default(HandleRef), sizeArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayoutStrategy_LayoutEdgePoints_10(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray, HandleRef edgeRoutingTree);

	/// <summary>
	/// Perform the layout of the input tree, and store the sector
	/// bounds of each vertex as a tuple in a data array.
	/// For radial layout, this is
	/// (innerRadius, outerRadius, startAngle, endAngle).
	/// For rectangular layout, this is
	/// (xmin, xmax, ymin, ymax).
	///
	/// The sizeArray may be nullptr, or may contain the desired
	/// size of each vertex in the tree.
	/// </summary>
	public virtual void LayoutEdgePoints(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray, vtkTree edgeRoutingTree)
	{
		vtkAreaLayoutStrategy_LayoutEdgePoints_10(GetCppThis(), inputTree?.GetCppThis() ?? default(HandleRef), areaArray?.GetCppThis() ?? default(HandleRef), sizeArray?.GetCppThis() ?? default(HandleRef), edgeRoutingTree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaLayoutStrategy_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAreaLayoutStrategy NewInstance()
	{
		vtkAreaLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaLayoutStrategy_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaLayoutStrategy_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAreaLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkAreaLayoutStrategy vtkAreaLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaLayoutStrategy_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAreaLayoutStrategy2 = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAreaLayoutStrategy2.Register(null);
			}
		}
		return vtkAreaLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayoutStrategy_SetShrinkPercentage_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Returns the vertex id that contains pnt (or -1 if no one contains it)
	/// </summary>
	public virtual void SetShrinkPercentage(double _arg)
	{
		vtkAreaLayoutStrategy_SetShrinkPercentage_13(GetCppThis(), _arg);
	}
}
