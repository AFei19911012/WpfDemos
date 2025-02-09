using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConeLayoutStrategy
/// </summary>
/// <remarks>
///    produce a cone-tree layout for a forest
///
/// vtkConeLayoutStrategy positions the nodes of a tree(forest) in 3D
/// space based on the cone-tree approach first described by
/// Robertson, Mackinlay and Card in Proc. CHI'91.  This
/// implementation incorporates refinements to the layout
/// developed by Carriere and Kazman, and by Auber.
///
/// The input graph must be a forest (i.e. a set of trees, or a
/// single tree); in the case of a forest, the input will be
/// converted to a single tree by introducing a new root node,
/// and connecting each root in the input forest to the meta-root.
/// The tree is then laid out, after which the meta-root is removed.
///
/// The cones are positioned so that children lie in planes parallel
/// to the X-Y plane, with the axis of cones parallel to Z, and
/// with Z coordinate increasing with distance of nodes from the root.
///
/// @par Thanks:
/// Thanks to David Duke from the University of Leeds for providing this
/// implementation.
/// </remarks>
public class vtkConeLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConeLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConeLayoutStrategy()
	{
		MRClassNameKey = "class vtkConeLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConeLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConeLayoutStrategy New()
	{
		vtkConeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkConeLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkConeLayoutStrategy_CompressionOff_01(HandleRef pThis);

	/// <summary>
	/// Determine if layout should be compressed, i.e. the
	/// layout puts children closer together, possibly allowing
	/// sub-trees to overlap.  This is useful if the tree is
	/// actually the spanning tree of a graph.  For "real" trees,
	/// non-compressed layout is best, and is the default.
	/// </summary>
	public virtual void CompressionOff()
	{
		vtkConeLayoutStrategy_CompressionOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeLayoutStrategy_CompressionOn_02(HandleRef pThis);

	/// <summary>
	/// Determine if layout should be compressed, i.e. the
	/// layout puts children closer together, possibly allowing
	/// sub-trees to overlap.  This is useful if the tree is
	/// actually the spanning tree of a graph.  For "real" trees,
	/// non-compressed layout is best, and is the default.
	/// </summary>
	public virtual void CompressionOn()
	{
		vtkConeLayoutStrategy_CompressionOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkConeLayoutStrategy_GetCompactness_03(HandleRef pThis);

	/// <summary>
	/// Determine the compactness, the ratio between the
	/// average width of a cone in the tree, and the
	/// height of the cone.  The default setting is 0.75
	/// which (empirically) seems reasonable, but this
	/// will need adapting depending on the data.
	/// </summary>
	public virtual float GetCompactness()
	{
		return vtkConeLayoutStrategy_GetCompactness_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeLayoutStrategy_GetCompression_04(HandleRef pThis);

	/// <summary>
	/// Determine if layout should be compressed, i.e. the
	/// layout puts children closer together, possibly allowing
	/// sub-trees to overlap.  This is useful if the tree is
	/// actually the spanning tree of a graph.  For "real" trees,
	/// non-compressed layout is best, and is the default.
	/// </summary>
	public virtual int GetCompression()
	{
		return vtkConeLayoutStrategy_GetCompression_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConeLayoutStrategy_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConeLayoutStrategy_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConeLayoutStrategy_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConeLayoutStrategy_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkConeLayoutStrategy_GetSpacing_07(HandleRef pThis);

	/// <summary>
	/// Set the spacing parameter that affects space between
	/// layers of the tree.  If compression is on, Spacing is the
	/// actual distance between layers.  If compression is off,
	/// actual distance also includes a factor of the compactness
	/// and maximum cone radius.
	/// </summary>
	public virtual float GetSpacing()
	{
		return vtkConeLayoutStrategy_GetSpacing_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeLayoutStrategy_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConeLayoutStrategy_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConeLayoutStrategy_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConeLayoutStrategy_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeLayoutStrategy_Layout_10(HandleRef pThis);

	/// <summary>
	/// Perform the layout.
	/// </summary>
	public override void Layout()
	{
		vtkConeLayoutStrategy_Layout_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConeLayoutStrategy_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkConeLayoutStrategy NewInstance()
	{
		vtkConeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConeLayoutStrategy_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConeLayoutStrategy_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConeLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkConeLayoutStrategy vtkConeLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConeLayoutStrategy_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConeLayoutStrategy2 = (vtkConeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConeLayoutStrategy2.Register(null);
			}
		}
		return vtkConeLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeLayoutStrategy_SetCompactness_14(HandleRef pThis, float _arg);

	/// <summary>
	/// Determine the compactness, the ratio between the
	/// average width of a cone in the tree, and the
	/// height of the cone.  The default setting is 0.75
	/// which (empirically) seems reasonable, but this
	/// will need adapting depending on the data.
	/// </summary>
	public virtual void SetCompactness(float _arg)
	{
		vtkConeLayoutStrategy_SetCompactness_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeLayoutStrategy_SetCompression_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Determine if layout should be compressed, i.e. the
	/// layout puts children closer together, possibly allowing
	/// sub-trees to overlap.  This is useful if the tree is
	/// actually the spanning tree of a graph.  For "real" trees,
	/// non-compressed layout is best, and is the default.
	/// </summary>
	public virtual void SetCompression(int _arg)
	{
		vtkConeLayoutStrategy_SetCompression_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConeLayoutStrategy_SetSpacing_16(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the spacing parameter that affects space between
	/// layers of the tree.  If compression is on, Spacing is the
	/// actual distance between layers.  If compression is off,
	/// actual distance also includes a factor of the compactness
	/// and maximum cone radius.
	/// </summary>
	public virtual void SetSpacing(float _arg)
	{
		vtkConeLayoutStrategy_SetSpacing_16(GetCppThis(), _arg);
	}
}
