using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIcicleView
/// </summary>
/// <remarks>
///    Displays a tree in a stacked "icicle" view
///
///
/// vtkIcicleView shows a vtkTree in horizontal layers
/// where each vertex in the tree is represented by a bar.
/// Child sectors are below (or above) parent sectors, and may be
/// colored and sized by various parameters.
/// </remarks>
public class vtkIcicleView : vtkTreeAreaView
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIcicleView";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIcicleView()
	{
		MRClassNameKey = "class vtkIcicleView";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIcicleView"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIcicleView(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIcicleView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIcicleView New()
	{
		vtkIcicleView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIcicleView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIcicleView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIcicleView()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIcicleView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkIcicleView_GetLayerThickness_01(HandleRef pThis);

	/// <summary>
	/// Set the thickness of each layer
	/// </summary>
	public virtual double GetLayerThickness()
	{
		return vtkIcicleView_GetLayerThickness_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIcicleView_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIcicleView_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIcicleView_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIcicleView_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIcicleView_GetRootWidth_04(HandleRef pThis);

	/// <summary>
	/// Set the width of the root node
	/// </summary>
	public virtual double GetRootWidth()
	{
		return vtkIcicleView_GetRootWidth_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIcicleView_GetTopToBottom_05(HandleRef pThis);

	/// <summary>
	/// Sets whether the stacks go from top to bottom or bottom to top.
	/// </summary>
	public virtual bool GetTopToBottom()
	{
		return (vtkIcicleView_GetTopToBottom_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIcicleView_GetUseGradientColoring_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off gradient coloring.
	/// </summary>
	public virtual bool GetUseGradientColoring()
	{
		return (vtkIcicleView_GetUseGradientColoring_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIcicleView_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIcicleView_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIcicleView_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIcicleView_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIcicleView_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIcicleView NewInstance()
	{
		vtkIcicleView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIcicleView_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIcicleView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIcicleView_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIcicleView SafeDownCast(vtkObjectBase o)
	{
		vtkIcicleView vtkIcicleView2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIcicleView_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIcicleView2 = (vtkIcicleView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIcicleView2.Register(null);
			}
		}
		return vtkIcicleView2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIcicleView_SetLayerThickness_12(HandleRef pThis, double thickness);

	/// <summary>
	/// Set the thickness of each layer
	/// </summary>
	public virtual void SetLayerThickness(double thickness)
	{
		vtkIcicleView_SetLayerThickness_12(GetCppThis(), thickness);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIcicleView_SetRootWidth_13(HandleRef pThis, double width);

	/// <summary>
	/// Set the width of the root node
	/// </summary>
	public virtual void SetRootWidth(double width)
	{
		vtkIcicleView_SetRootWidth_13(GetCppThis(), width);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIcicleView_SetTopToBottom_14(HandleRef pThis, byte reversed);

	/// <summary>
	/// Sets whether the stacks go from top to bottom or bottom to top.
	/// </summary>
	public virtual void SetTopToBottom(bool reversed)
	{
		vtkIcicleView_SetTopToBottom_14(GetCppThis(), (byte)(reversed ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIcicleView_SetUseGradientColoring_15(HandleRef pThis, byte value);

	/// <summary>
	/// Turn on/off gradient coloring.
	/// </summary>
	public virtual void SetUseGradientColoring(bool value)
	{
		vtkIcicleView_SetUseGradientColoring_15(GetCppThis(), (byte)(value ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIcicleView_TopToBottomOff_16(HandleRef pThis);

	/// <summary>
	/// Sets whether the stacks go from top to bottom or bottom to top.
	/// </summary>
	public virtual void TopToBottomOff()
	{
		vtkIcicleView_TopToBottomOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIcicleView_TopToBottomOn_17(HandleRef pThis);

	/// <summary>
	/// Sets whether the stacks go from top to bottom or bottom to top.
	/// </summary>
	public virtual void TopToBottomOn()
	{
		vtkIcicleView_TopToBottomOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIcicleView_UseGradientColoringOff_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off gradient coloring.
	/// </summary>
	public virtual void UseGradientColoringOff()
	{
		vtkIcicleView_UseGradientColoringOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIcicleView_UseGradientColoringOn_19(HandleRef pThis);

	/// <summary>
	/// Turn on/off gradient coloring.
	/// </summary>
	public virtual void UseGradientColoringOn()
	{
		vtkIcicleView_UseGradientColoringOn_19(GetCppThis());
	}
}
