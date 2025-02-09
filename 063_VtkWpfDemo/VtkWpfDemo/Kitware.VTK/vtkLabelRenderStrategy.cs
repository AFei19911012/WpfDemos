using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabelRenderStrategy
/// </summary>
/// <remarks>
///    Superclass for label rendering implementations.
///
///
/// These methods should only be called within a mapper.
/// </remarks>
public abstract class vtkLabelRenderStrategy : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabelRenderStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabelRenderStrategy()
	{
		MRClassNameKey = "class vtkLabelRenderStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelRenderStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabelRenderStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelRenderStrategy_ComputeLabelBounds_01(HandleRef pThis, HandleRef tprop, string label, IntPtr bds);

	/// <summary>
	/// Compute the bounds of a label. Must be performed after the renderer is set.
	/// </summary>
	public virtual void ComputeLabelBounds(vtkTextProperty tprop, string label, IntPtr bds)
	{
		vtkLabelRenderStrategy_ComputeLabelBounds_01(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), label, bds);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelRenderStrategy_EndFrame_02(HandleRef pThis);

	/// <summary>
	/// End a rendering frame.
	/// </summary>
	public virtual void EndFrame()
	{
		vtkLabelRenderStrategy_EndFrame_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelRenderStrategy_GetDefaultTextProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the default text property for the strategy.
	/// </summary>
	public virtual vtkTextProperty GetDefaultTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelRenderStrategy_GetDefaultTextProperty_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelRenderStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabelRenderStrategy_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelRenderStrategy_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabelRenderStrategy_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelRenderStrategy_GetRenderer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the renderer associated with this strategy.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelRenderStrategy_GetRenderer_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelRenderStrategy_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabelRenderStrategy_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelRenderStrategy_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabelRenderStrategy_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelRenderStrategy_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabelRenderStrategy NewInstance()
	{
		vtkLabelRenderStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelRenderStrategy_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelRenderStrategy_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this strategy.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLabelRenderStrategy_ReleaseGraphicsResources_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelRenderStrategy_RenderLabel_11(HandleRef pThis, IntPtr x, HandleRef tprop, string label);

	/// <summary>
	/// Render a label at a location in display coordinates.
	/// Must be performed between StartFrame() and EndFrame() calls.
	/// The optional final parameter maxWidth specifies a maximum width for the label.
	/// Longer labels can be shorted with an ellipsis (...). Only renderer strategies
	/// that return true from SupportsBoundedSize must implement this version of th
	/// method.
	/// </summary>
	public virtual void RenderLabel(IntPtr x, vtkTextProperty tprop, string label)
	{
		vtkLabelRenderStrategy_RenderLabel_11(GetCppThis(), x, tprop?.GetCppThis() ?? default(HandleRef), label);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelRenderStrategy_RenderLabel_12(HandleRef pThis, IntPtr x, HandleRef tprop, string label, int arg3);

	/// <summary>
	/// Render a label at a location in display coordinates.
	/// Must be performed between StartFrame() and EndFrame() calls.
	/// The optional final parameter maxWidth specifies a maximum width for the label.
	/// Longer labels can be shorted with an ellipsis (...). Only renderer strategies
	/// that return true from SupportsBoundedSize must implement this version of th
	/// method.
	/// </summary>
	public virtual void RenderLabel(IntPtr x, vtkTextProperty tprop, string label, int arg3)
	{
		vtkLabelRenderStrategy_RenderLabel_12(GetCppThis(), x, tprop?.GetCppThis() ?? default(HandleRef), label, arg3);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelRenderStrategy_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelRenderStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkLabelRenderStrategy vtkLabelRenderStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelRenderStrategy_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelRenderStrategy2 = (vtkLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelRenderStrategy2.Register(null);
			}
		}
		return vtkLabelRenderStrategy2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelRenderStrategy_SetDefaultTextProperty_14(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// Set the default text property for the strategy.
	/// </summary>
	public virtual void SetDefaultTextProperty(vtkTextProperty tprop)
	{
		vtkLabelRenderStrategy_SetDefaultTextProperty_14(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelRenderStrategy_SetRenderer_15(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Set the renderer associated with this strategy.
	/// </summary>
	public virtual void SetRenderer(vtkRenderer ren)
	{
		vtkLabelRenderStrategy_SetRenderer_15(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelRenderStrategy_StartFrame_16(HandleRef pThis);

	/// <summary>
	/// Start a rendering frame. Renderer must be set.
	/// </summary>
	public virtual void StartFrame()
	{
		vtkLabelRenderStrategy_StartFrame_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelRenderStrategy_SupportsBoundedSize_17(HandleRef pThis);

	/// <summary>
	/// Whether the text rendering strategy supports bounded size.
	/// The superclass returns true. Subclasses should override this to
	/// return the appropriate value. Subclasses that return true
	/// from this method should implement the version of RenderLabel()
	/// that takes a maximum size (see RenderLabel()).
	/// </summary>
	public virtual bool SupportsBoundedSize()
	{
		return (vtkLabelRenderStrategy_SupportsBoundedSize_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelRenderStrategy_SupportsRotation_18(HandleRef pThis);

	/// <summary>
	/// Whether the text rendering strategy supports rotation.
	/// The superclass returns true. Subclasses should override this to
	/// return the appropriate value.
	/// </summary>
	public virtual bool SupportsRotation()
	{
		return (vtkLabelRenderStrategy_SupportsRotation_18(GetCppThis()) != 0) ? true : false;
	}
}
