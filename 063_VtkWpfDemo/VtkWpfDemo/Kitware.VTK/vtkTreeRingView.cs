using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeRingView
/// </summary>
/// <remarks>
///    Displays a tree in concentric rings.
///
///
/// Accepts a graph and a hierarchy - currently
/// a tree - and provides a hierarchy-aware display.  Currently, this means
/// displaying the hierarchy using a tree ring layout, then rendering the graph
/// vertices as leaves of the tree with curved graph edges between leaves.
///
/// .SEE ALSO
/// vtkGraphLayoutView
///
/// @par Thanks:
/// Thanks to Jason Shepherd for implementing this class
/// </remarks>
public class vtkTreeRingView : vtkTreeAreaView
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeRingView";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeRingView()
	{
		MRClassNameKey = "class vtkTreeRingView";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeRingView"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeRingView(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeRingView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeRingView New()
	{
		vtkTreeRingView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeRingView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeRingView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeRingView()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeRingView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeRingView_GetInteriorLogSpacingValue_01(HandleRef pThis);

	/// <summary>
	/// Set the log spacing factor for the invisible interior tree
	/// used for routing edges of the overlaid graph.
	/// </summary>
	public virtual double GetInteriorLogSpacingValue()
	{
		return vtkTreeRingView_GetInteriorLogSpacingValue_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeRingView_GetInteriorRadius_02(HandleRef pThis);

	/// <summary>
	/// Set the interior radius of the tree
	/// (i.e. the size of the "hole" in the center).
	/// </summary>
	public virtual double GetInteriorRadius()
	{
		return vtkTreeRingView_GetInteriorRadius_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeRingView_GetLayerThickness_03(HandleRef pThis);

	/// <summary>
	/// Set the thickness of each layer.
	/// </summary>
	public virtual double GetLayerThickness()
	{
		return vtkTreeRingView_GetLayerThickness_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeRingView_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeRingView_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeRingView_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeRingView_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeRingView_GetRootAtCenter_06(HandleRef pThis);

	/// <summary>
	/// Sets whether the root is at the center or around the outside.
	/// </summary>
	public virtual bool GetRootAtCenter()
	{
		return (vtkTreeRingView_GetRootAtCenter_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeRingView_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeRingView_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeRingView_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeRingView_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeRingView_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeRingView NewInstance()
	{
		vtkTreeRingView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeRingView_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeRingView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeRingView_RootAtCenterOff_11(HandleRef pThis);

	/// <summary>
	/// Sets whether the root is at the center or around the outside.
	/// </summary>
	public virtual void RootAtCenterOff()
	{
		vtkTreeRingView_RootAtCenterOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeRingView_RootAtCenterOn_12(HandleRef pThis);

	/// <summary>
	/// Sets whether the root is at the center or around the outside.
	/// </summary>
	public virtual void RootAtCenterOn()
	{
		vtkTreeRingView_RootAtCenterOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeRingView_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeRingView SafeDownCast(vtkObjectBase o)
	{
		vtkTreeRingView vtkTreeRingView2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeRingView_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeRingView2 = (vtkTreeRingView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeRingView2.Register(null);
			}
		}
		return vtkTreeRingView2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeRingView_SetInteriorLogSpacingValue_14(HandleRef pThis, double value);

	/// <summary>
	/// Set the log spacing factor for the invisible interior tree
	/// used for routing edges of the overlaid graph.
	/// </summary>
	public virtual void SetInteriorLogSpacingValue(double value)
	{
		vtkTreeRingView_SetInteriorLogSpacingValue_14(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeRingView_SetInteriorRadius_15(HandleRef pThis, double rad);

	/// <summary>
	/// Set the interior radius of the tree
	/// (i.e. the size of the "hole" in the center).
	/// </summary>
	public virtual void SetInteriorRadius(double rad)
	{
		vtkTreeRingView_SetInteriorRadius_15(GetCppThis(), rad);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeRingView_SetLayerThickness_16(HandleRef pThis, double thickness);

	/// <summary>
	/// Set the thickness of each layer.
	/// </summary>
	public virtual void SetLayerThickness(double thickness)
	{
		vtkTreeRingView_SetLayerThickness_16(GetCppThis(), thickness);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeRingView_SetRootAngles_17(HandleRef pThis, double start, double end);

	/// <summary>
	/// Set the root angles for laying out the hierarchy.
	/// </summary>
	public void SetRootAngles(double start, double end)
	{
		vtkTreeRingView_SetRootAngles_17(GetCppThis(), start, end);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeRingView_SetRootAtCenter_18(HandleRef pThis, byte center);

	/// <summary>
	/// Sets whether the root is at the center or around the outside.
	/// </summary>
	public virtual void SetRootAtCenter(bool center)
	{
		vtkTreeRingView_SetRootAtCenter_18(GetCppThis(), (byte)(center ? 1u : 0u));
	}
}
