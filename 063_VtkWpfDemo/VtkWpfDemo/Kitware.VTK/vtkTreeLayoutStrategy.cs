using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeLayoutStrategy
/// </summary>
/// <remarks>
///    hierarchical layout
///
///
/// Assigns points to the nodes of a tree in either a standard or radial layout.
/// The standard layout places each level on a horizontal line, while the
/// radial layout places each level on a concentric circle.
/// You may specify the sweep angle of the tree which constrains the tree
/// to be contained within a wedge. Also, you may indicate the log scale of
/// the tree, which diminishes the length of arcs at lower levels of the tree.
/// Values near zero give a large proportion of the space to the tree levels
/// near the root, while values near one give nearly equal proportions of space
/// to all tree levels.
///
/// The user may also specify an array to use to indicate the distance from the
/// root, either vertically (for standard layout) or radially
/// (for radial layout).  You specify this with SetDistanceArrayName().
///
/// If the input is not a tree but a general graph, this strategy first extracts
/// a tree from the graph using a breadth-first search starting at vertex ID 0.
/// </remarks>
public class vtkTreeLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeLayoutStrategy()
	{
		MRClassNameKey = "class vtkTreeLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeLayoutStrategy New()
	{
		vtkTreeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkTreeLayoutStrategy_GetAngle_01(HandleRef pThis);

	/// <summary>
	/// The sweep angle of the tree.
	/// For a standard tree layout, this should be between 0 and 180.
	/// For a radial tree layout, this can be between 0 and 360.
	/// </summary>
	public virtual double GetAngle()
	{
		return vtkTreeLayoutStrategy_GetAngle_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeLayoutStrategy_GetAngleMaxValue_02(HandleRef pThis);

	/// <summary>
	/// The sweep angle of the tree.
	/// For a standard tree layout, this should be between 0 and 180.
	/// For a radial tree layout, this can be between 0 and 360.
	/// </summary>
	public virtual double GetAngleMaxValue()
	{
		return vtkTreeLayoutStrategy_GetAngleMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeLayoutStrategy_GetAngleMinValue_03(HandleRef pThis);

	/// <summary>
	/// The sweep angle of the tree.
	/// For a standard tree layout, this should be between 0 and 180.
	/// For a radial tree layout, this can be between 0 and 360.
	/// </summary>
	public virtual double GetAngleMinValue()
	{
		return vtkTreeLayoutStrategy_GetAngleMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeLayoutStrategy_GetDistanceArrayName_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the array to use to determine the distance from the
	/// root.
	/// </summary>
	public virtual string GetDistanceArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeLayoutStrategy_GetDistanceArrayName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeLayoutStrategy_GetLeafSpacing_05(HandleRef pThis);

	/// <summary>
	/// The spacing of leaves.  Levels near one evenly space leaves
	/// with no gaps between subtrees.  Levels near zero creates
	/// large gaps between subtrees.
	/// </summary>
	public virtual double GetLeafSpacing()
	{
		return vtkTreeLayoutStrategy_GetLeafSpacing_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeLayoutStrategy_GetLeafSpacingMaxValue_06(HandleRef pThis);

	/// <summary>
	/// The spacing of leaves.  Levels near one evenly space leaves
	/// with no gaps between subtrees.  Levels near zero creates
	/// large gaps between subtrees.
	/// </summary>
	public virtual double GetLeafSpacingMaxValue()
	{
		return vtkTreeLayoutStrategy_GetLeafSpacingMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeLayoutStrategy_GetLeafSpacingMinValue_07(HandleRef pThis);

	/// <summary>
	/// The spacing of leaves.  Levels near one evenly space leaves
	/// with no gaps between subtrees.  Levels near zero creates
	/// large gaps between subtrees.
	/// </summary>
	public virtual double GetLeafSpacingMinValue()
	{
		return vtkTreeLayoutStrategy_GetLeafSpacingMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeLayoutStrategy_GetLogSpacingValue_08(HandleRef pThis);

	/// <summary>
	/// The spacing of tree levels. Levels near zero give more space
	/// to levels near the root, while levels near one (the default)
	/// create evenly-spaced levels. Levels above one give more space
	/// to levels near the leaves.
	/// </summary>
	public virtual double GetLogSpacingValue()
	{
		return vtkTreeLayoutStrategy_GetLogSpacingValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeLayoutStrategy_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeLayoutStrategy_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeLayoutStrategy_GetRadial_11(HandleRef pThis);

	/// <summary>
	/// If set, the tree is laid out with levels on concentric circles
	/// around the root. If unset (default), the tree is laid out with
	/// levels on horizontal lines.
	/// </summary>
	public virtual bool GetRadial()
	{
		return (vtkTreeLayoutStrategy_GetRadial_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeLayoutStrategy_GetReverseEdges_12(HandleRef pThis);

	/// <summary>
	/// If set and the input is not a tree but a general graph, the filter
	/// will reverse the edges on the graph before extracting a tree using
	/// breadth first search.
	/// </summary>
	public virtual bool GetReverseEdges()
	{
		return (vtkTreeLayoutStrategy_GetReverseEdges_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeLayoutStrategy_GetRotation_13(HandleRef pThis);

	/// <summary>
	/// The amount of counter-clockwise rotation to apply after the
	/// layout.
	/// </summary>
	public virtual double GetRotation()
	{
		return vtkTreeLayoutStrategy_GetRotation_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeLayoutStrategy_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeLayoutStrategy_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeLayoutStrategy_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeLayoutStrategy_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_Layout_16(HandleRef pThis);

	/// <summary>
	/// Perform the tree layout.
	/// </summary>
	public override void Layout()
	{
		vtkTreeLayoutStrategy_Layout_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeLayoutStrategy_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeLayoutStrategy NewInstance()
	{
		vtkTreeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeLayoutStrategy_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_RadialOff_19(HandleRef pThis);

	/// <summary>
	/// If set, the tree is laid out with levels on concentric circles
	/// around the root. If unset (default), the tree is laid out with
	/// levels on horizontal lines.
	/// </summary>
	public virtual void RadialOff()
	{
		vtkTreeLayoutStrategy_RadialOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_RadialOn_20(HandleRef pThis);

	/// <summary>
	/// If set, the tree is laid out with levels on concentric circles
	/// around the root. If unset (default), the tree is laid out with
	/// levels on horizontal lines.
	/// </summary>
	public virtual void RadialOn()
	{
		vtkTreeLayoutStrategy_RadialOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_ReverseEdgesOff_21(HandleRef pThis);

	/// <summary>
	/// If set and the input is not a tree but a general graph, the filter
	/// will reverse the edges on the graph before extracting a tree using
	/// breadth first search.
	/// </summary>
	public virtual void ReverseEdgesOff()
	{
		vtkTreeLayoutStrategy_ReverseEdgesOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_ReverseEdgesOn_22(HandleRef pThis);

	/// <summary>
	/// If set and the input is not a tree but a general graph, the filter
	/// will reverse the edges on the graph before extracting a tree using
	/// breadth first search.
	/// </summary>
	public virtual void ReverseEdgesOn()
	{
		vtkTreeLayoutStrategy_ReverseEdgesOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeLayoutStrategy_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkTreeLayoutStrategy vtkTreeLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeLayoutStrategy_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeLayoutStrategy2 = (vtkTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeLayoutStrategy2.Register(null);
			}
		}
		return vtkTreeLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_SetAngle_24(HandleRef pThis, double _arg);

	/// <summary>
	/// The sweep angle of the tree.
	/// For a standard tree layout, this should be between 0 and 180.
	/// For a radial tree layout, this can be between 0 and 360.
	/// </summary>
	public virtual void SetAngle(double _arg)
	{
		vtkTreeLayoutStrategy_SetAngle_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_SetDistanceArrayName_25(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the array to use to determine the distance from the
	/// root.
	/// </summary>
	public virtual void SetDistanceArrayName(string _arg)
	{
		vtkTreeLayoutStrategy_SetDistanceArrayName_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_SetLeafSpacing_26(HandleRef pThis, double _arg);

	/// <summary>
	/// The spacing of leaves.  Levels near one evenly space leaves
	/// with no gaps between subtrees.  Levels near zero creates
	/// large gaps between subtrees.
	/// </summary>
	public virtual void SetLeafSpacing(double _arg)
	{
		vtkTreeLayoutStrategy_SetLeafSpacing_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_SetLogSpacingValue_27(HandleRef pThis, double _arg);

	/// <summary>
	/// The spacing of tree levels. Levels near zero give more space
	/// to levels near the root, while levels near one (the default)
	/// create evenly-spaced levels. Levels above one give more space
	/// to levels near the leaves.
	/// </summary>
	public virtual void SetLogSpacingValue(double _arg)
	{
		vtkTreeLayoutStrategy_SetLogSpacingValue_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_SetRadial_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set, the tree is laid out with levels on concentric circles
	/// around the root. If unset (default), the tree is laid out with
	/// levels on horizontal lines.
	/// </summary>
	public virtual void SetRadial(bool _arg)
	{
		vtkTreeLayoutStrategy_SetRadial_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_SetReverseEdges_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set and the input is not a tree but a general graph, the filter
	/// will reverse the edges on the graph before extracting a tree using
	/// breadth first search.
	/// </summary>
	public virtual void SetReverseEdges(bool _arg)
	{
		vtkTreeLayoutStrategy_SetReverseEdges_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeLayoutStrategy_SetRotation_30(HandleRef pThis, double _arg);

	/// <summary>
	/// The amount of counter-clockwise rotation to apply after the
	/// layout.
	/// </summary>
	public virtual void SetRotation(double _arg)
	{
		vtkTreeLayoutStrategy_SetRotation_30(GetCppThis(), _arg);
	}
}
