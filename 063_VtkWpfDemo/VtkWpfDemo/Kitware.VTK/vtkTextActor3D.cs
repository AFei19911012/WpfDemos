using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextActor3D
/// </summary>
/// <remarks>
///    An actor that displays text.
///
/// The input text is rendered into a buffer, which in turn is used as a
/// texture applied onto a quad (a vtkImageActor is used under the hood).
/// @warning
/// This class is experimental at the moment.
/// - The orientation is not optimized, the quad should be oriented, not
///   the text itself when it is rendered in the buffer (we end up with
///   excessively big textures for 45 degrees angles).
///   This will be fixed first.
/// - No checking is done at the moment regarding hardware texture size limits.
///
/// </remarks>
/// <seealso>
///
/// vtkProp3D
/// </seealso>
public class vtkTextActor3D : vtkProp3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextActor3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextActor3D()
	{
		MRClassNameKey = "class vtkTextActor3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextActor3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextActor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextActor3D New()
	{
		vtkTextActor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextActor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTextActor3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextActor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTextActor3D_ForceOpaqueOff_01(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void ForceOpaqueOff()
	{
		vtkTextActor3D_ForceOpaqueOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_ForceOpaqueOn_02(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void ForceOpaqueOn()
	{
		vtkTextActor3D_ForceOpaqueOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_ForceTranslucentOff_03(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void ForceTranslucentOff()
	{
		vtkTextActor3D_ForceTranslucentOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_ForceTranslucentOn_04(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void ForceTranslucentOn()
	{
		vtkTextActor3D_ForceTranslucentOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor3D_GetBoundingBox_05(HandleRef pThis, IntPtr bbox);

	/// <summary>
	/// Get the vtkTextRenderer-derived bounding box for the given vtkTextProperty
	/// and text string str.  Results are returned in the four element bbox int
	/// array.  This call can be used for sizing other elements.
	/// </summary>
	public int GetBoundingBox(IntPtr bbox)
	{
		return vtkTextActor3D_GetBoundingBox_05(GetCppThis(), bbox);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor3D_GetBounds_06(HandleRef pThis);

	/// <summary>
	/// Get the bounds for this Prop3D as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkTextActor3D_GetBounds_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_GetBounds_07(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this Prop3D as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkTextActor3D_GetBounds_07(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTextActor3D_GetForceOpaque_08(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual bool GetForceOpaque()
	{
		return (vtkTextActor3D_GetForceOpaque_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTextActor3D_GetForceTranslucent_09(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual bool GetForceTranslucent()
	{
		return (vtkTextActor3D_GetForceTranslucent_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor3D_GetInput_10(HandleRef pThis);

	/// <summary>
	/// Set the text string to be displayed.
	/// </summary>
	public virtual string GetInput()
	{
		return Marshal.PtrToStringAnsi(vtkTextActor3D_GetInput_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextActor3D_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextActor3D_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextActor3D_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextActor3D_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor3D_GetRenderedDPI_13();

	/// <summary>
	/// Since a 3D text actor is not pixel-aligned and positioned in 3D space,
	/// the text is rendered at a constant DPI, rather than using the current
	/// window DPI. This static method returns the DPI value used to produce the
	/// text images.
	/// </summary>
	public static int GetRenderedDPI()
	{
		return vtkTextActor3D_GetRenderedDPI_13();
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor3D_GetTextProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextActor3D_GetTextProperty_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor3D_HasTranslucentPolygonalGeometry_15(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkTextActor3D_HasTranslucentPolygonalGeometry_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor3D_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextActor3D_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor3D_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextActor3D_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor3D_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextActor3D NewInstance()
	{
		vtkTextActor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextActor3D_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkTextActor3D_ReleaseGraphicsResources_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor3D_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the text actor to the screen.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkTextActor3D_RenderOpaqueGeometry_21(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor3D_RenderOverlay_22(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the text actor to the screen.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkTextActor3D_RenderOverlay_22(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor3D_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the text actor to the screen.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkTextActor3D_RenderTranslucentPolygonalGeometry_23(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor3D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextActor3D SafeDownCast(vtkObjectBase o)
	{
		vtkTextActor3D vtkTextActor3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextActor3D_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextActor3D2 = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextActor3D2.Register(null);
			}
		}
		return vtkTextActor3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_SetForceOpaque_25(HandleRef pThis, byte opaque);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void SetForceOpaque(bool opaque)
	{
		vtkTextActor3D_SetForceOpaque_25(GetCppThis(), (byte)(opaque ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_SetForceTranslucent_26(HandleRef pThis, byte trans);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void SetForceTranslucent(bool trans)
	{
		vtkTextActor3D_SetForceTranslucent_26(GetCppThis(), (byte)(trans ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_SetInput_27(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the text string to be displayed.
	/// </summary>
	public virtual void SetInput(string _arg)
	{
		vtkTextActor3D_SetInput_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_SetTextProperty_28(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual void SetTextProperty(vtkTextProperty p)
	{
		vtkTextActor3D_SetTextProperty_28(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor3D_ShallowCopy_29(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this text actor. Overloads the virtual
	/// vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkTextActor3D_ShallowCopy_29(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
