using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHyperTreeGridMapper
/// </summary>
/// <remarks>
///    map vtkHyperTreeGrid to graphics primitives
///
/// vtkHyperTreeGridMapper is a class that maps polygonal data (i.e., vtkHyperTreeGrid)
/// to graphics primitives. vtkHyperTreeGridMapper serves as a superclass for
/// device-specific poly data mappers, that actually do the mapping to the
/// rendering/graphics hardware/software.
///
/// By default, this class use an Adaptive GeometryFilter that extract only
/// the part of the geometry to render. Be careful as this implies that new
/// render my trigger an update of the pipeline to get the new part of the
/// geometry to render.
///
/// Note: this class has its own module to avoid cyclic dependency between Rendering Core
/// and Filters Hybrid
/// * It need Filters Hybrid for Adaptive2DGeometryFilter
/// * Filters Hybrid need Rendering Core because of Adaptive2DGeometryFilter
/// </remarks>
public class vtkHyperTreeGridMapper : vtkMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHyperTreeGridMapper()
	{
		MRClassNameKey = "class vtkHyperTreeGridMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHyperTreeGridMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridMapper New()
	{
		vtkHyperTreeGridMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHyperTreeGridMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHyperTreeGridMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridMapper_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Fill the input port information objects for this algorithm.  This
	/// is invoked by the first call to GetInputPortInformation for each
	/// port so subclasses can specify what they can handle.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkHyperTreeGridMapper_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridMapper_GetBounds_02(HandleRef pThis);

	/// <summary>
	/// For this mapper, the bounds correspond to the output for the
	/// internal surface filter which may be restricted to the Camera frustum
	/// if UseCameraFrustum is on.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkHyperTreeGridMapper_GetBounds_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridMapper_GetBounds_03(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// For this mapper, the bounds correspond to the output for the
	/// internal surface filter which may be restricted to the Camera frustum
	/// if UseCameraFrustum is on.
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkHyperTreeGridMapper_GetBounds_03(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHyperTreeGridMapper_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridMapper_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHyperTreeGridMapper_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridMapper_GetUseAdaptiveDecimation_06(HandleRef pThis);

	/// <summary>
	/// This boolean control whether or not the mapping should adapt
	/// to the Camera frustum during the rendering. Setting this variable
	/// to true (default) should provide increased performances.
	/// </summary>
	public virtual bool GetUseAdaptiveDecimation()
	{
		return (vtkHyperTreeGridMapper_GetUseAdaptiveDecimation_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridMapper_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHyperTreeGridMapper_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridMapper_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHyperTreeGridMapper_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridMapper_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHyperTreeGridMapper NewInstance()
	{
		vtkHyperTreeGridMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridMapper_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridMapper_Render_11(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// Use the internal PolyData Mapper to do the rendering
	/// of the HTG transformed by the current SurfaceFilter:
	/// * Adaptive2DGeometryFilter if UseCameraFrustum
	/// * GeometryFilter otherwise
	/// </summary>
	public override void Render(vtkRenderer ren, vtkActor act)
	{
		vtkHyperTreeGridMapper_Render_11(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridMapper_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridMapper SafeDownCast(vtkObjectBase o)
	{
		vtkHyperTreeGridMapper vtkHyperTreeGridMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridMapper_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeGridMapper2 = (vtkHyperTreeGridMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeGridMapper2.Register(null);
			}
		}
		return vtkHyperTreeGridMapper2;
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridMapper_SetInputDataObject_13(HandleRef pThis, int port, HandleRef input);

	/// <summary>
	/// Set the connection for the given input port index.  Each input
	/// port of a filter has a specific purpose.  A port may have zero or
	/// more connections and the required number is specified by each
	/// filter.  Setting the connection with this method removes all
	/// other connections from the port.  To add more than one connection
	/// use AddInputConnection().
	/// The input for the connection is the output port of another
	/// filter, which is obtained with GetOutputPort().  Typical usage is
	/// filter2-&gt;SetInputConnection(0, filter1-&gt;GetOutputPort(0)).
	/// </summary>
	public override void SetInputDataObject(int port, vtkDataObject input)
	{
		vtkHyperTreeGridMapper_SetInputDataObject_13(GetCppThis(), port, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridMapper_SetInputDataObject_14(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the connection for the given input port index.  Each input
	/// port of a filter has a specific purpose.  A port may have zero or
	/// more connections and the required number is specified by each
	/// filter.  Setting the connection with this method removes all
	/// other connections from the port.  To add more than one connection
	/// use AddInputConnection().
	/// The input for the connection is the output port of another
	/// filter, which is obtained with GetOutputPort().  Typical usage is
	/// filter2-&gt;SetInputConnection(0, filter1-&gt;GetOutputPort(0)).
	/// </summary>
	public override void SetInputDataObject(vtkDataObject input)
	{
		vtkHyperTreeGridMapper_SetInputDataObject_14(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridMapper_SetUseAdaptiveDecimation_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// This boolean control whether or not the mapping should adapt
	/// to the Camera frustum during the rendering. Setting this variable
	/// to true (default) should provide increased performances.
	/// </summary>
	public virtual void SetUseAdaptiveDecimation(bool _arg)
	{
		vtkHyperTreeGridMapper_SetUseAdaptiveDecimation_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridMapper_UseAdaptiveDecimationOff_16(HandleRef pThis);

	/// <summary>
	/// This boolean control whether or not the mapping should adapt
	/// to the Camera frustum during the rendering. Setting this variable
	/// to true (default) should provide increased performances.
	/// </summary>
	public virtual void UseAdaptiveDecimationOff()
	{
		vtkHyperTreeGridMapper_UseAdaptiveDecimationOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridMapper_UseAdaptiveDecimationOn_17(HandleRef pThis);

	/// <summary>
	/// This boolean control whether or not the mapping should adapt
	/// to the Camera frustum during the rendering. Setting this variable
	/// to true (default) should provide increased performances.
	/// </summary>
	public virtual void UseAdaptiveDecimationOn()
	{
		vtkHyperTreeGridMapper_UseAdaptiveDecimationOn_17(GetCppThis());
	}
}
