using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFreeTypeLabelRenderStrategy
/// </summary>
/// <remarks>
///    Renders labels with freetype
///
///
/// Uses the FreeType to render labels and compute label sizes.
/// This strategy may be used with vtkLabelPlacementMapper.
/// </remarks>
public class vtkFreeTypeLabelRenderStrategy : vtkLabelRenderStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFreeTypeLabelRenderStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFreeTypeLabelRenderStrategy()
	{
		MRClassNameKey = "class vtkFreeTypeLabelRenderStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFreeTypeLabelRenderStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFreeTypeLabelRenderStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFreeTypeLabelRenderStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFreeTypeLabelRenderStrategy New()
	{
		vtkFreeTypeLabelRenderStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFreeTypeLabelRenderStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFreeTypeLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFreeTypeLabelRenderStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFreeTypeLabelRenderStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeLabelRenderStrategy_ComputeLabelBounds_01(HandleRef pThis, HandleRef tprop, string label, IntPtr bds);

	/// <summary>
	/// Compute the bounds of a label. Must be performed after the renderer is set.
	/// </summary>
	public override void ComputeLabelBounds(vtkTextProperty tprop, string label, IntPtr bds)
	{
		vtkFreeTypeLabelRenderStrategy_ComputeLabelBounds_01(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), label, bds);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFreeTypeLabelRenderStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFreeTypeLabelRenderStrategy_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFreeTypeLabelRenderStrategy_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFreeTypeLabelRenderStrategy_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFreeTypeLabelRenderStrategy_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFreeTypeLabelRenderStrategy_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFreeTypeLabelRenderStrategy_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFreeTypeLabelRenderStrategy_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFreeTypeLabelRenderStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFreeTypeLabelRenderStrategy NewInstance()
	{
		vtkFreeTypeLabelRenderStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFreeTypeLabelRenderStrategy_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFreeTypeLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeLabelRenderStrategy_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef window);

	/// <summary>
	/// Release any graphics resources that are being consumed by this strategy.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkFreeTypeLabelRenderStrategy_ReleaseGraphicsResources_08(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeLabelRenderStrategy_RenderLabel_09(HandleRef pThis, IntPtr x, HandleRef tprop, string label);

	/// <summary>
	/// Render a label at a location in world coordinates.
	/// Must be performed between StartFrame() and EndFrame() calls.
	/// </summary>
	public override void RenderLabel(IntPtr x, vtkTextProperty tprop, string label)
	{
		vtkFreeTypeLabelRenderStrategy_RenderLabel_09(GetCppThis(), x, tprop?.GetCppThis() ?? default(HandleRef), label);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFreeTypeLabelRenderStrategy_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFreeTypeLabelRenderStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkFreeTypeLabelRenderStrategy vtkFreeTypeLabelRenderStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFreeTypeLabelRenderStrategy_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFreeTypeLabelRenderStrategy2 = (vtkFreeTypeLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFreeTypeLabelRenderStrategy2.Register(null);
			}
		}
		return vtkFreeTypeLabelRenderStrategy2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFreeTypeLabelRenderStrategy_SupportsBoundedSize_11(HandleRef pThis);

	/// <summary>
	/// The free type render strategy currently does not support bounded size labels.
	/// </summary>
	public override bool SupportsBoundedSize()
	{
		return (vtkFreeTypeLabelRenderStrategy_SupportsBoundedSize_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFreeTypeLabelRenderStrategy_SupportsRotation_12(HandleRef pThis);

	/// <summary>
	/// The free type render strategy currently does not support rotation.
	/// </summary>
	public override bool SupportsRotation()
	{
		return (vtkFreeTypeLabelRenderStrategy_SupportsRotation_12(GetCppThis()) != 0) ? true : false;
	}
}
