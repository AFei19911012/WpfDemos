using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCirclePackFrontChainLayoutStrategy
/// </summary>
/// <remarks>
///    layout a vtkTree into packed circles
/// using the front chain algorithm.
///
///
/// vtkCirclePackFrontChainLayoutStrategy assigns circles to each node of the input vtkTree
/// using the front chain algorithm.  The algorithm packs circles by searching a "front
/// chain" of circles around the perimeter of the circles that have already been packed for
/// the current level in the tree hierarchy.  Searching the front chain is in general faster
/// than searching all of the circles that have been packed at the current level.
///
/// WARNING:  The algorithm tends to break down and produce packings with overlapping
/// circles when there is a large difference in the radii of the circles at a given
/// level of the tree hierarchy.  Roughly on the order a 1000:1 ratio of circle radii.
///
/// Please see the following reference for more details on the algorithm.
///
/// Title: "Visualization of large hierarchical data by circle packing"
/// Authors:  Weixin Wang, Hui Wang, Guozhong Dai, Hongan Wang
/// Conference: Proceedings of the SIGCHI conference on Human Factors in computing systems
/// Year: 2006
///
/// </remarks>
public class vtkCirclePackFrontChainLayoutStrategy : vtkCirclePackLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCirclePackFrontChainLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCirclePackFrontChainLayoutStrategy()
	{
		MRClassNameKey = "class vtkCirclePackFrontChainLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCirclePackFrontChainLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCirclePackFrontChainLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackFrontChainLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCirclePackFrontChainLayoutStrategy New()
	{
		vtkCirclePackFrontChainLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCirclePackFrontChainLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCirclePackFrontChainLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCirclePackFrontChainLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCirclePackFrontChainLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCirclePackFrontChainLayoutStrategy_GetHeight_01(HandleRef pThis);

	/// <summary>
	/// Width and Height define the size of the output window that the
	/// circle packing is placed inside.  Defaults to Width 1, Height 1
	/// </summary>
	public virtual int GetHeight()
	{
		return vtkCirclePackFrontChainLayoutStrategy_GetHeight_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCirclePackFrontChainLayoutStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCirclePackFrontChainLayoutStrategy_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCirclePackFrontChainLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCirclePackFrontChainLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCirclePackFrontChainLayoutStrategy_GetWidth_04(HandleRef pThis);

	/// <summary>
	/// Width and Height define the size of the output window that the
	/// circle packing is placed inside.  Defaults to Width 1, Height 1
	/// </summary>
	public virtual int GetWidth()
	{
		return vtkCirclePackFrontChainLayoutStrategy_GetWidth_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCirclePackFrontChainLayoutStrategy_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCirclePackFrontChainLayoutStrategy_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCirclePackFrontChainLayoutStrategy_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCirclePackFrontChainLayoutStrategy_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCirclePackFrontChainLayoutStrategy_Layout_07(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray);

	/// <summary>
	/// Perform the layout of the input tree, and store the circle
	/// bounds of each vertex as a tuple in a data array.
	/// (Xcenter, Ycenter, Radius).
	/// </summary>
	public override void Layout(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray)
	{
		vtkCirclePackFrontChainLayoutStrategy_Layout_07(GetCppThis(), inputTree?.GetCppThis() ?? default(HandleRef), areaArray?.GetCppThis() ?? default(HandleRef), sizeArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackFrontChainLayoutStrategy_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCirclePackFrontChainLayoutStrategy NewInstance()
	{
		vtkCirclePackFrontChainLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCirclePackFrontChainLayoutStrategy_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCirclePackFrontChainLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCirclePackFrontChainLayoutStrategy_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCirclePackFrontChainLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkCirclePackFrontChainLayoutStrategy vtkCirclePackFrontChainLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCirclePackFrontChainLayoutStrategy_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCirclePackFrontChainLayoutStrategy2 = (vtkCirclePackFrontChainLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCirclePackFrontChainLayoutStrategy2.Register(null);
			}
		}
		return vtkCirclePackFrontChainLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCirclePackFrontChainLayoutStrategy_SetHeight_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Width and Height define the size of the output window that the
	/// circle packing is placed inside.  Defaults to Width 1, Height 1
	/// </summary>
	public virtual void SetHeight(int _arg)
	{
		vtkCirclePackFrontChainLayoutStrategy_SetHeight_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCirclePackFrontChainLayoutStrategy_SetWidth_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Width and Height define the size of the output window that the
	/// circle packing is placed inside.  Defaults to Width 1, Height 1
	/// </summary>
	public virtual void SetWidth(int _arg)
	{
		vtkCirclePackFrontChainLayoutStrategy_SetWidth_12(GetCppThis(), _arg);
	}
}
