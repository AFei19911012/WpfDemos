using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkActor
/// </summary>
/// <remarks>
///    represents an object (geometry &amp; properties) in a rendered scene
///
///
/// vtkActor is used to represent an entity in a rendering scene.  It inherits
/// functions related to the actors position, and orientation from
/// vtkProp3D. The actor also has scaling and maintains a reference to the
/// defining geometry (i.e., the mapper), rendering properties, and possibly a
/// texture map. vtkActor combines these instance variables into one 4x4
/// transformation matrix as follows: [x y z 1] = [x y z 1] Translate(-origin)
/// Scale(scale) Rot(y) Rot(x) Rot (z) Trans(origin) Trans(position)
///
/// </remarks>
/// <seealso>
///
/// vtkProperty vtkTexture vtkMapper vtkAssembly vtkFollower vtkLODActor
/// </seealso>
public class vtkActor : vtkProp3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkActor()
	{
		MRClassNameKey = "class vtkActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates an actor with the following defaults: origin(0,0,0)
	/// position=(0,0,0) scale=(1,1,1) visibility=1 pickable=1 dragable=1
	/// orientation=(0,0,0). No user defined matrix and no texture map.
	/// </summary>
	public new static vtkActor New()
	{
		vtkActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates an actor with the following defaults: origin(0,0,0)
	/// position=(0,0,0) scale=(1,1,1) visibility=1 pickable=1 dragable=1
	/// orientation=(0,0,0). No user defined matrix and no texture map.
	/// </summary>
	public vtkActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkActor_ApplyProperties_01(HandleRef pThis);

	/// <summary>
	/// Apply the current properties to all parts that compose this actor.
	/// This method is overloaded in vtkAssembly to apply the assemblies'
	/// properties to all its parts in a recursive manner. Typically the
	/// use of this method is to set the desired properties in the assembly,
	/// and then push the properties down to the assemblies parts with
	/// ApplyProperties().
	/// </summary>
	public virtual void ApplyProperties()
	{
		vtkActor_ApplyProperties_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_ForceOpaqueOff_02(HandleRef pThis);

	/// <summary>
	/// Force the actor to be treated as opaque or translucent
	/// </summary>
	public virtual void ForceOpaqueOff()
	{
		vtkActor_ForceOpaqueOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_ForceOpaqueOn_03(HandleRef pThis);

	/// <summary>
	/// Force the actor to be treated as opaque or translucent
	/// </summary>
	public virtual void ForceOpaqueOn()
	{
		vtkActor_ForceOpaqueOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_ForceTranslucentOff_04(HandleRef pThis);

	/// <summary>
	/// Force the actor to be treated as opaque or translucent
	/// </summary>
	public virtual void ForceTranslucentOff()
	{
		vtkActor_ForceTranslucentOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_ForceTranslucentOn_05(HandleRef pThis);

	/// <summary>
	/// Force the actor to be treated as opaque or translucent
	/// </summary>
	public virtual void ForceTranslucentOn()
	{
		vtkActor_ForceTranslucentOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_GetActors_06(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkActor_GetActors_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor_GetBackfaceProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the property object that controls this actors backface surface
	/// properties.  This should be an instance of a vtkProperty object. If one
	/// isn't specified, then the front face properties will be used.  Multiple
	/// actors can share one property object.
	/// </summary>
	public virtual vtkProperty GetBackfaceProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor_GetBackfaceProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor_GetBounds_08(HandleRef pThis);

	/// <summary>
	/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
	/// method GetBounds(double bounds[6]) is available from the superclass.)
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkActor_GetBounds_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkActor_GetForceOpaque_09(HandleRef pThis);

	/// <summary>
	/// Force the actor to be treated as opaque or translucent
	/// </summary>
	public virtual bool GetForceOpaque()
	{
		return (vtkActor_GetForceOpaque_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkActor_GetForceTranslucent_10(HandleRef pThis);

	/// <summary>
	/// Force the actor to be treated as opaque or translucent
	/// </summary>
	public virtual bool GetForceTranslucent()
	{
		return (vtkActor_GetForceTranslucent_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkActor_GetMTime_11(HandleRef pThis);

	/// <summary>
	/// Get the actors mtime plus consider its properties and texture if set.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkActor_GetMTime_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor_GetMapper_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the Mapper that this actor is getting its data from.
	/// </summary>
	public virtual vtkMapper GetMapper()
	{
		vtkMapper vtkMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor_GetMapper_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMapper2 = (vtkMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMapper2.Register(null);
			}
		}
		return vtkMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkActor_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkActor_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkActor_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkActor_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor_GetProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the property object that controls this actors surface
	/// properties.  This should be an instance of a vtkProperty object.  Every
	/// actor must have a property associated with it.  If one isn't specified,
	/// then one will be generated automatically. Multiple actors can share one
	/// property object.
	/// </summary>
	public vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor_GetProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkActor_GetRedrawMTime_16(HandleRef pThis);

	/// <summary>
	/// Return the mtime of anything that would cause the rendered image to
	/// appear differently. Usually this involves checking the mtime of the
	/// prop plus anything else it depends on such as properties, textures,
	/// etc.
	/// </summary>
	public override ulong GetRedrawMTime()
	{
		return vtkActor_GetRedrawMTime_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkActor_GetSupportsSelection_17(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Used by vtkHardwareSelector to determine if the prop supports hardware
	/// selection.
	/// </summary>
	public override bool GetSupportsSelection()
	{
		return (vtkActor_GetSupportsSelection_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor_GetTexture_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the texture object to control rendering texture maps.  This will
	/// be a vtkTexture object. An actor does not need to have an associated
	/// texture map and multiple actors can share one texture.
	/// </summary>
	public virtual vtkTexture GetTexture()
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor_GetTexture_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor_HasOpaqueGeometry_19(HandleRef pThis);

	/// <summary>
	/// Does this prop have some opaque/translucent polygonal geometry?
	/// </summary>
	public override int HasOpaqueGeometry()
	{
		return vtkActor_HasOpaqueGeometry_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor_HasTranslucentPolygonalGeometry_20(HandleRef pThis);

	/// <summary>
	/// Does this prop have some opaque/translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkActor_HasTranslucentPolygonalGeometry_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkActor_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkActor_IsRenderingTranslucentPolygonalGeometry_22(HandleRef pThis);

	/// <summary>
	/// allows a prop to update a selections color buffers
	/// Default just forwards to the Mapper
	/// </summary>
	public override bool IsRenderingTranslucentPolygonalGeometry()
	{
		return (vtkActor_IsRenderingTranslucentPolygonalGeometry_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkActor_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor_MakeProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new property suitable for use with this type of Actor.
	/// For example, a vtkMesaActor should create a vtkMesaProperty
	/// in this function.   The default is to just call vtkProperty::New.
	/// </summary>
	public virtual vtkProperty MakeProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor_MakeProperty_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkActor NewInstance()
	{
		vtkActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkActor_ReleaseGraphicsResources_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_Render_28(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// This causes the actor to be rendered. It in turn will render the actor's
	/// property, texture map and then mapper. If a property hasn't been
	/// assigned, then the actor will create one automatically. Note that a side
	/// effect of this method is that the pipeline will be updated.
	/// </summary>
	public virtual void Render(vtkRenderer arg0, vtkMapper arg1)
	{
		vtkActor_Render_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor_RenderOpaqueGeometry_29(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkActor_RenderOpaqueGeometry_29(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor_RenderTranslucentPolygonalGeometry_30(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkActor_RenderTranslucentPolygonalGeometry_30(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkActor SafeDownCast(vtkObjectBase o)
	{
		vtkActor vtkActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2 = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2.Register(null);
			}
		}
		return vtkActor2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_SetBackfaceProperty_32(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Set/Get the property object that controls this actors backface surface
	/// properties.  This should be an instance of a vtkProperty object. If one
	/// isn't specified, then the front face properties will be used.  Multiple
	/// actors can share one property object.
	/// </summary>
	public void SetBackfaceProperty(vtkProperty lut)
	{
		vtkActor_SetBackfaceProperty_32(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_SetForceOpaque_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force the actor to be treated as opaque or translucent
	/// </summary>
	public virtual void SetForceOpaque(bool _arg)
	{
		vtkActor_SetForceOpaque_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_SetForceTranslucent_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force the actor to be treated as opaque or translucent
	/// </summary>
	public virtual void SetForceTranslucent(bool _arg)
	{
		vtkActor_SetForceTranslucent_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_SetIsRenderingTranslucentPolygonalGeometry_35(HandleRef pThis, byte val);

	/// <summary>
	/// allows a prop to update a selections color buffers
	/// Default just forwards to the Mapper
	/// </summary>
	public void SetIsRenderingTranslucentPolygonalGeometry(bool val)
	{
		vtkActor_SetIsRenderingTranslucentPolygonalGeometry_35(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_SetMapper_36(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// This is the method that is used to connect an actor to the end of a
	/// visualization pipeline, i.e. the mapper. This should be a subclass
	/// of vtkMapper. Typically vtkPolyDataMapper and vtkDataSetMapper will
	/// be used.
	/// </summary>
	public virtual void SetMapper(vtkMapper arg0)
	{
		vtkActor_SetMapper_36(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_SetProperty_37(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Set/Get the property object that controls this actors surface
	/// properties.  This should be an instance of a vtkProperty object.  Every
	/// actor must have a property associated with it.  If one isn't specified,
	/// then one will be generated automatically. Multiple actors can share one
	/// property object.
	/// </summary>
	public void SetProperty(vtkProperty lut)
	{
		vtkActor_SetProperty_37(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_SetTexture_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the texture object to control rendering texture maps.  This will
	/// be a vtkTexture object. An actor does not need to have an associated
	/// texture map and multiple actors can share one texture.
	/// </summary>
	public virtual void SetTexture(vtkTexture arg0)
	{
		vtkActor_SetTexture_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor_ShallowCopy_39(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of an actor. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkActor_ShallowCopy_39(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
