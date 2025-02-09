using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkScenePicker
/// </summary>
/// <remarks>
///    Picks an entire viewport at one shot.
///
/// The Scene picker, unlike conventional pickers picks an entire viewport at
/// one shot and caches the result, which can be retrieved later.
///    The utility of the class arises during &lt;b&gt;Actor Selection&lt;/b&gt;. Let's
/// say you have a couple of polygonal objects in your scene and you wish to
/// have a status bar that indicates the object your mouse is over. Picking
/// repeatedly every time your mouse moves would be very slow. The
/// scene picker automatically picks your viewport every time the camera is
/// changed and caches the information. Additionally, it observes the
/// vtkRenderWindowInteractor to avoid picking during interaction, so that
/// you still maintain your interactivity. In effect, the picker does an
/// additional pick-render of your scene every time you stop interacting with
/// your scene. As an example, see Rendering/TestScenePicker.
///
/// @warning
/// - Unlike a vtkHoverWidget, this class is not timer based. The hover widget
///   picks a scene when the mouse is over an actor for a specified duration.
/// - This class uses a vtkHardwareSelector under the hood. Hence, it will
///   work only for actors that have opaque geometry and are rendered by a
///   vtkPolyDataMapper.
///
/// </remarks>
/// <seealso>
///
/// vtkHoverWidget vtkHardwareSelector
/// </seealso>
public class vtkScenePicker : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkScenePicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkScenePicker()
	{
		MRClassNameKey = "class vtkScenePicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkScenePicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkScenePicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScenePicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScenePicker New()
	{
		vtkScenePicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScenePicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScenePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkScenePicker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkScenePicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScenePicker_EnableVertexPickingOff_01(HandleRef pThis);

	/// <summary>
	/// Vertex picking (using the method GetVertexId()), required
	/// additional resources and can slow down still render time by
	/// 5-10%. Enabled by default.
	/// </summary>
	public virtual void EnableVertexPickingOff()
	{
		vtkScenePicker_EnableVertexPickingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScenePicker_EnableVertexPickingOn_02(HandleRef pThis);

	/// <summary>
	/// Vertex picking (using the method GetVertexId()), required
	/// additional resources and can slow down still render time by
	/// 5-10%. Enabled by default.
	/// </summary>
	public virtual void EnableVertexPickingOn()
	{
		vtkScenePicker_EnableVertexPickingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScenePicker_GetCellId_03(HandleRef pThis, IntPtr displayPos);

	/// <summary>
	/// Get cell id at the pick position.
	/// Returns -1 if no cell was picked.
	/// Makes sense only after Pick has been called.
	/// </summary>
	public long GetCellId(IntPtr displayPos)
	{
		return vtkScenePicker_GetCellId_03(GetCppThis(), displayPos);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScenePicker_GetEnableVertexPicking_04(HandleRef pThis);

	/// <summary>
	/// Vertex picking (using the method GetVertexId()), required
	/// additional resources and can slow down still render time by
	/// 5-10%. Enabled by default.
	/// </summary>
	public virtual int GetEnableVertexPicking()
	{
		return vtkScenePicker_GetEnableVertexPicking_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScenePicker_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkScenePicker_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScenePicker_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkScenePicker_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScenePicker_GetRenderer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the renderer. Scene picks are restricted to the viewport.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScenePicker_GetRenderer_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScenePicker_GetVertexId_08(HandleRef pThis, IntPtr displayPos);

	/// <summary>
	/// Get cell id at the pick position.
	/// Returns -1 if no cell was picked.
	/// Makes sense only after Pick has been called.
	/// </summary>
	public long GetVertexId(IntPtr displayPos)
	{
		return vtkScenePicker_GetVertexId_08(GetCppThis(), displayPos);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScenePicker_GetViewProp_09(HandleRef pThis, IntPtr displayPos, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get actor at the pick position.
	/// Returns NULL if none.
	/// Makes sense only after Pick has been called.
	/// </summary>
	public vtkProp GetViewProp(IntPtr displayPos)
	{
		vtkProp vtkProp2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScenePicker_GetViewProp_09(GetCppThis(), displayPos, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp2 = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp2.Register(null);
			}
		}
		return vtkProp2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScenePicker_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkScenePicker_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScenePicker_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkScenePicker_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScenePicker_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkScenePicker NewInstance()
	{
		vtkScenePicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScenePicker_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScenePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScenePicker_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScenePicker SafeDownCast(vtkObjectBase o)
	{
		vtkScenePicker vtkScenePicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScenePicker_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScenePicker2 = (vtkScenePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScenePicker2.Register(null);
			}
		}
		return vtkScenePicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScenePicker_SetEnableVertexPicking_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Vertex picking (using the method GetVertexId()), required
	/// additional resources and can slow down still render time by
	/// 5-10%. Enabled by default.
	/// </summary>
	public virtual void SetEnableVertexPicking(int _arg)
	{
		vtkScenePicker_SetEnableVertexPicking_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScenePicker_SetRenderer_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the renderer. Scene picks are restricted to the viewport.
	/// </summary>
	public virtual void SetRenderer(vtkRenderer arg0)
	{
		vtkScenePicker_SetRenderer_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
