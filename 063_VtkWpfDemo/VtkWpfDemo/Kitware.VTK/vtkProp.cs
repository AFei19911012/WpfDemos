using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProp
/// </summary>
/// <remarks>
///    abstract superclass for all actors, volumes and annotations
///
/// vtkProp is an abstract superclass for any objects that can exist in a
/// rendered scene (either 2D or 3D). Instances of vtkProp may respond to
/// various render methods (e.g., RenderOpaqueGeometry()). vtkProp also
/// defines the API for picking, LOD manipulation, and common instance
/// variables that control visibility, picking, and dragging.
/// </remarks>
/// <seealso>
///
/// vtkActor2D vtkActor vtkVolume vtkProp3D
/// </seealso>
public class vtkProp : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProp";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProp()
	{
		MRClassNameKey = "class vtkProp";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProp(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_AddConsumer_01(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Add or remove or get or check a consumer,
	/// </summary>
	public void AddConsumer(vtkObject c)
	{
		vtkProp_AddConsumer_01(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_AddEstimatedRenderTime_02(HandleRef pThis, double t, HandleRef arg1);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// This method is intended to allow the renderer to add to the
	/// EstimatedRenderTime in props that require information that
	/// the renderer has in order to do this. For example, props
	/// that are rendered with a ray casting method do not know
	/// themselves how long it took for them to render. We don't want to
	/// cause a this-&gt;Modified() when we set this value since it is not
	/// really a modification to the object. (For example, we don't want
	/// to rebuild matrices at every render because the estimated render time
	/// is changing)
	/// </summary>
	public virtual void AddEstimatedRenderTime(double t, vtkViewport arg1)
	{
		vtkProp_AddEstimatedRenderTime_02(GetCppThis(), t, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_BuildPaths_03(HandleRef pThis, HandleRef paths, HandleRef path);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Used to construct assembly paths and perform part traversal.
	/// </summary>
	public virtual void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
	{
		vtkProp_BuildPaths_03(GetCppThis(), paths?.GetCppThis() ?? default(HandleRef), path?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_DragableOff_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the dragable instance variable. This determines if
	/// an Prop, once picked, can be dragged (translated) through space.
	/// This is typically done through an interactive mouse interface.
	/// This does not affect methods such as SetPosition, which will continue
	/// to work.  It is just intended to prevent some vtkProp'ss from being
	/// dragged from within a user interface.
	/// Initial value is true.
	/// </summary>
	public virtual void DragableOff()
	{
		vtkProp_DragableOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_DragableOn_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the dragable instance variable. This determines if
	/// an Prop, once picked, can be dragged (translated) through space.
	/// This is typically done through an interactive mouse interface.
	/// This does not affect methods such as SetPosition, which will continue
	/// to work.  It is just intended to prevent some vtkProp'ss from being
	/// dragged from within a user interface.
	/// Initial value is true.
	/// </summary>
	public virtual void DragableOn()
	{
		vtkProp_DragableOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_GeneralTextureTransform_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Optional Key Indicating the texture transform for general texture mapping
	/// Old OpenGL was a state machine where you would push or pop
	/// items. The new OpenGL design is more mapper centric. Some
	/// classes push a texture and then assume a mapper will use it.
	/// The new design wants explicit communication of when a texture
	/// is being used.  This key can be used to pass that information
	/// down to a mapper.
	/// </summary>
	public static vtkInformationDoubleVectorKey GeneralTextureTransform()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp_GeneralTextureTransform_06(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_GeneralTextureUnit_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Optional Key Indicating the texture unit for general texture mapping
	/// Old OpenGL was a state machine where you would push or pop
	/// items. The new OpenGL design is more mapper centric. Some
	/// classes push a texture and then assume a mapper will use it.
	/// The new design wants explicit communication of when a texture
	/// is being used.  This key can be used to pass that information
	/// down to a mapper.
	/// </summary>
	public static vtkInformationIntegerKey GeneralTextureUnit()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp_GeneralTextureUnit_07(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_GetActors_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public virtual void GetActors(vtkPropCollection arg0)
	{
		vtkProp_GetActors_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_GetActors2D_09(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public virtual void GetActors2D(vtkPropCollection arg0)
	{
		vtkProp_GetActors2D_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp_GetAllocatedRenderTime_10(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public virtual double GetAllocatedRenderTime()
	{
		return vtkProp_GetAllocatedRenderTime_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_GetBounds_11(HandleRef pThis);

	/// <summary>
	/// Get the bounds for this Prop as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// in world coordinates. NULL means that the bounds are not defined.
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkProp_GetBounds_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_GetConsumer_12(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add or remove or get or check a consumer,
	/// </summary>
	public vtkObject GetConsumer(int i)
	{
		vtkObject vtkObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp_GetConsumer_12(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObject2 = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObject2.Register(null);
			}
		}
		return vtkObject2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_GetDragable_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the dragable instance variable. This determines if
	/// an Prop, once picked, can be dragged (translated) through space.
	/// This is typically done through an interactive mouse interface.
	/// This does not affect methods such as SetPosition, which will continue
	/// to work.  It is just intended to prevent some vtkProp'ss from being
	/// dragged from within a user interface.
	/// Initial value is true.
	/// </summary>
	public virtual int GetDragable()
	{
		return vtkProp_GetDragable_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp_GetEstimatedRenderTime_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// The EstimatedRenderTime may be used to select between different props,
	/// for example in LODProp it is used to select the level-of-detail.
	/// The value is returned in seconds. For simple geometry the accuracy may
	/// not be great due to buffering. For ray casting, which is already
	/// multi-resolution, the current resolution of the image is factored into
	/// the time. We need the viewport for viewing parameters that affect timing.
	/// The no-arguments version simply returns the value of the variable with
	/// no estimation.
	/// </summary>
	public virtual double GetEstimatedRenderTime(vtkViewport arg0)
	{
		return vtkProp_GetEstimatedRenderTime_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp_GetEstimatedRenderTime_15(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// The EstimatedRenderTime may be used to select between different props,
	/// for example in LODProp it is used to select the level-of-detail.
	/// The value is returned in seconds. For simple geometry the accuracy may
	/// not be great due to buffering. For ray casting, which is already
	/// multi-resolution, the current resolution of the image is factored into
	/// the time. We need the viewport for viewing parameters that affect timing.
	/// The no-arguments version simply returns the value of the variable with
	/// no estimation.
	/// </summary>
	public virtual double GetEstimatedRenderTime()
	{
		return vtkProp_GetEstimatedRenderTime_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_GetMatrix_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// These methods are used by subclasses to place a matrix (if any) in the
	/// prop prior to rendering. Generally used only for picking. See vtkProp3D
	/// for more information.
	/// </summary>
	public virtual vtkMatrix4x4 GetMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp_GetMatrix_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_GetNextPath_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// vtkProp and its subclasses can be picked by subclasses of
	/// vtkAbstractPicker (e.g., vtkPropPicker). The following methods interface
	/// with the picking classes and return "pick paths". A pick path is a
	/// hierarchical, ordered list of props that form an assembly.  Most often,
	/// when a vtkProp is picked, its path consists of a single node (i.e., the
	/// prop). However, classes like vtkAssembly and vtkPropAssembly can return
	/// more than one path, each path being several layers deep. (See
	/// vtkAssemblyPath for more information.)  To use these methods - first
	/// invoke InitPathTraversal() followed by repeated calls to GetNextPath().
	/// GetNextPath() returns a NULL pointer when the list is exhausted.
	/// </summary>
	public virtual vtkAssemblyPath GetNextPath()
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp_GetNextPath_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_GetNumberOfConsumers_18(HandleRef pThis);

	/// <summary>
	/// Get the number of consumers
	/// </summary>
	public virtual int GetNumberOfConsumers()
	{
		return vtkProp_GetNumberOfConsumers_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProp_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProp_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_GetNumberOfPaths_21(HandleRef pThis);

	/// <summary>
	/// vtkProp and its subclasses can be picked by subclasses of
	/// vtkAbstractPicker (e.g., vtkPropPicker). The following methods interface
	/// with the picking classes and return "pick paths". A pick path is a
	/// hierarchical, ordered list of props that form an assembly.  Most often,
	/// when a vtkProp is picked, its path consists of a single node (i.e., the
	/// prop). However, classes like vtkAssembly and vtkPropAssembly can return
	/// more than one path, each path being several layers deep. (See
	/// vtkAssemblyPath for more information.)  To use these methods - first
	/// invoke InitPathTraversal() followed by repeated calls to GetNextPath().
	/// GetNextPath() returns a NULL pointer when the list is exhausted.
	/// </summary>
	public virtual int GetNumberOfPaths()
	{
		return vtkProp_GetNumberOfPaths_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_GetPickable_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the pickable instance variable.  This determines if the vtkProp
	/// can be picked (typically using the mouse). Also see dragable.
	/// Initial value is true.
	/// </summary>
	public virtual int GetPickable()
	{
		return vtkProp_GetPickable_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_GetPropertyKeys_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get property keys. Property keys can be digest by some rendering
	/// passes.
	/// For instance, the user may mark a prop as a shadow caster for a
	/// shadow mapping render pass. Keys are documented in render pass classes.
	/// Initial value is NULL.
	/// </summary>
	public virtual vtkInformation GetPropertyKeys()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp_GetPropertyKeys_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkProp_GetRedrawMTime_24(HandleRef pThis);

	/// <summary>
	/// Return the mtime of anything that would cause the rendered image to
	/// appear differently. Usually this involves checking the mtime of the
	/// prop plus anything else it depends on such as properties, textures
	/// etc.
	/// </summary>
	public virtual ulong GetRedrawMTime()
	{
		return vtkProp_GetRedrawMTime_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp_GetRenderTimeMultiplier_25(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Get/Set the multiplier for the render time. This is used
	/// for culling and is a number between 0 and 1. It is used
	/// to create the allocated render time value.
	/// </summary>
	public virtual double GetRenderTimeMultiplier()
	{
		return vtkProp_GetRenderTimeMultiplier_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_GetShaderProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the shader property.
	/// </summary>
	public virtual vtkShaderProperty GetShaderProperty()
	{
		vtkShaderProperty vtkShaderProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp_GetShaderProperty_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShaderProperty2 = (vtkShaderProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShaderProperty2.Register(null);
			}
		}
		return vtkShaderProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProp_GetSupportsSelection_27(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Used by vtkHardwareSelector to determine if the prop supports hardware
	/// selection.
	/// </summary>
	public virtual bool GetSupportsSelection()
	{
		return (vtkProp_GetSupportsSelection_27(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProp_GetUseBounds_28(HandleRef pThis);

	/// <summary>
	/// In case the Visibility flag is true, tell if the bounds of this prop
	/// should be taken into account or ignored during the computation of other
	/// bounding boxes, like in vtkRenderer::ResetCamera().
	/// Initial value is true.
	/// </summary>
	public virtual bool GetUseBounds()
	{
		return (vtkProp_GetUseBounds_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_GetVisibility_29(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of this vtkProp. Initial value is true.
	/// </summary>
	public virtual int GetVisibility()
	{
		return vtkProp_GetVisibility_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_GetVolumes_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public virtual void GetVolumes(vtkPropCollection arg0)
	{
		vtkProp_GetVolumes_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProp_HasKeys_31(HandleRef pThis, HandleRef requiredKeys);

	/// <summary>
	/// Tells if the prop has all the required keys.
	/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
	/// </summary>
	public virtual bool HasKeys(vtkInformation requiredKeys)
	{
		return (vtkProp_HasKeys_31(GetCppThis(), requiredKeys?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_HasOpaqueGeometry_32(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// Does this prop have some opaque geometry?
	/// This method is called during the rendering process to know if there is
	/// some opaque geometry. A simple prop that has some
	/// opaque geometry will return true. A composite prop (like
	/// vtkAssembly) that has at least one sub-prop that has some opaque
	/// polygonal geometry will return true.
	/// Default implementation return true.
	/// </summary>
	public virtual int HasOpaqueGeometry()
	{
		return vtkProp_HasOpaqueGeometry_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_HasTranslucentPolygonalGeometry_33(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// Does this prop have some translucent polygonal geometry?
	/// This method is called during the rendering process to know if there is
	/// some translucent polygonal geometry. A simple prop that has some
	/// translucent polygonal geometry will return true. A composite prop (like
	/// vtkAssembly) that has at least one sub-prop that has some translucent
	/// polygonal geometry will return true.
	/// Default implementation return false.
	/// </summary>
	public virtual int HasTranslucentPolygonalGeometry()
	{
		return vtkProp_HasTranslucentPolygonalGeometry_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_InitPathTraversal_34(HandleRef pThis);

	/// <summary>
	/// vtkProp and its subclasses can be picked by subclasses of
	/// vtkAbstractPicker (e.g., vtkPropPicker). The following methods interface
	/// with the picking classes and return "pick paths". A pick path is a
	/// hierarchical, ordered list of props that form an assembly.  Most often,
	/// when a vtkProp is picked, its path consists of a single node (i.e., the
	/// prop). However, classes like vtkAssembly and vtkPropAssembly can return
	/// more than one path, each path being several layers deep. (See
	/// vtkAssemblyPath for more information.)  To use these methods - first
	/// invoke InitPathTraversal() followed by repeated calls to GetNextPath().
	/// GetNextPath() returns a NULL pointer when the list is exhausted.
	/// </summary>
	public virtual void InitPathTraversal()
	{
		vtkProp_InitPathTraversal_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProp_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_IsConsumer_36(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Add or remove or get or check a consumer,
	/// </summary>
	public int IsConsumer(vtkObject c)
	{
		return vtkProp_IsConsumer_36(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProp_IsRenderingTranslucentPolygonalGeometry_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the shader property.
	/// </summary>
	public virtual bool IsRenderingTranslucentPolygonalGeometry()
	{
		return (vtkProp_IsRenderingTranslucentPolygonalGeometry_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_IsTypeOf_38(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProp_IsTypeOf_38(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProp NewInstance()
	{
		vtkProp result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp_NewInstance_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_Pick_40(HandleRef pThis);

	/// <summary>
	/// Method fires PickEvent if the prop is picked.
	/// </summary>
	public virtual void Pick()
	{
		vtkProp_Pick_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_PickableOff_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the pickable instance variable.  This determines if the vtkProp
	/// can be picked (typically using the mouse). Also see dragable.
	/// Initial value is true.
	/// </summary>
	public virtual void PickableOff()
	{
		vtkProp_PickableOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_PickableOn_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the pickable instance variable.  This determines if the vtkProp
	/// can be picked (typically using the mouse). Also see dragable.
	/// Initial value is true.
	/// </summary>
	public virtual void PickableOn()
	{
		vtkProp_PickableOn_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_PokeMatrix_43(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are used by subclasses to place a matrix (if any) in the
	/// prop prior to rendering. Generally used only for picking. See vtkProp3D
	/// for more information.
	/// </summary>
	public virtual void PokeMatrix(vtkMatrix4x4 arg0)
	{
		vtkProp_PokeMatrix_43(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkProp_ReleaseGraphicsResources_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_RemoveConsumer_45(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Add or remove or get or check a consumer,
	/// </summary>
	public void RemoveConsumer(vtkObject c)
	{
		vtkProp_RemoveConsumer_45(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProp_RenderFilteredOpaqueGeometry_46(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

	/// <summary>
	/// Render the opaque geometry only if the prop has all the requiredKeys.
	/// This is recursive for composite props like vtkAssembly.
	/// An implementation is provided in vtkProp but each composite prop
	/// must override it.
	/// It returns if the rendering was performed.
	/// \pre v_exists: v!=0
	/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
	/// </summary>
	public virtual bool RenderFilteredOpaqueGeometry(vtkViewport v, vtkInformation requiredKeys)
	{
		return (vtkProp_RenderFilteredOpaqueGeometry_46(GetCppThis(), v?.GetCppThis() ?? default(HandleRef), requiredKeys?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProp_RenderFilteredOverlay_47(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

	/// <summary>
	/// Render in the overlay of the viewport only if the prop has all the
	/// requiredKeys.
	/// This is recursive for composite props like vtkAssembly.
	/// An implementation is provided in vtkProp but each composite prop
	/// must override it.
	/// It returns if the rendering was performed.
	/// \pre v_exists: v!=0
	/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
	/// </summary>
	public virtual bool RenderFilteredOverlay(vtkViewport v, vtkInformation requiredKeys)
	{
		return (vtkProp_RenderFilteredOverlay_47(GetCppThis(), v?.GetCppThis() ?? default(HandleRef), requiredKeys?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProp_RenderFilteredTranslucentPolygonalGeometry_48(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

	/// <summary>
	/// Render the translucent polygonal geometry only if the prop has all the
	/// requiredKeys.
	/// This is recursive for composite props like vtkAssembly.
	/// An implementation is provided in vtkProp but each composite prop
	/// must override it.
	/// It returns if the rendering was performed.
	/// \pre v_exists: v!=0
	/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
	/// </summary>
	public virtual bool RenderFilteredTranslucentPolygonalGeometry(vtkViewport v, vtkInformation requiredKeys)
	{
		return (vtkProp_RenderFilteredTranslucentPolygonalGeometry_48(GetCppThis(), v?.GetCppThis() ?? default(HandleRef), requiredKeys?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProp_RenderFilteredVolumetricGeometry_49(HandleRef pThis, HandleRef v, HandleRef requiredKeys);

	/// <summary>
	/// Render the volumetric geometry only if the prop has all the
	/// requiredKeys.
	/// This is recursive for composite props like vtkAssembly.
	/// An implementation is provided in vtkProp but each composite prop
	/// must override it.
	/// It returns if the rendering was performed.
	/// \pre v_exists: v!=0
	/// \pre keys_can_be_null: requiredKeys==0 || requiredKeys!=0
	/// </summary>
	public virtual bool RenderFilteredVolumetricGeometry(vtkViewport v, vtkInformation requiredKeys)
	{
		return (vtkProp_RenderFilteredVolumetricGeometry_49(GetCppThis(), v?.GetCppThis() ?? default(HandleRef), requiredKeys?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_RenderOpaqueGeometry_50(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// All concrete subclasses must be able to render themselves.
	/// There are four key render methods in vtk and they correspond
	/// to four different points in the rendering cycle. Any given
	/// prop may implement one or more of these methods.
	/// The first method is intended for rendering all opaque geometry. The
	/// second method is intended for rendering all translucent polygonal
	/// geometry. The third one is intended for rendering all translucent
	/// volumetric geometry. Most of the volume rendering mappers draw their
	/// results during this third method.
	/// The last method is to render any 2D annotation or overlays.
	/// Each of these methods return an integer value indicating
	/// whether or not this render method was applied to this data.
	/// </summary>
	public virtual int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkProp_RenderOpaqueGeometry_50(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_RenderOverlay_51(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// All concrete subclasses must be able to render themselves.
	/// There are four key render methods in vtk and they correspond
	/// to four different points in the rendering cycle. Any given
	/// prop may implement one or more of these methods.
	/// The first method is intended for rendering all opaque geometry. The
	/// second method is intended for rendering all translucent polygonal
	/// geometry. The third one is intended for rendering all translucent
	/// volumetric geometry. Most of the volume rendering mappers draw their
	/// results during this third method.
	/// The last method is to render any 2D annotation or overlays.
	/// Each of these methods return an integer value indicating
	/// whether or not this render method was applied to this data.
	/// </summary>
	public virtual int RenderOverlay(vtkViewport arg0)
	{
		return vtkProp_RenderOverlay_51(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_RenderTranslucentPolygonalGeometry_52(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// All concrete subclasses must be able to render themselves.
	/// There are four key render methods in vtk and they correspond
	/// to four different points in the rendering cycle. Any given
	/// prop may implement one or more of these methods.
	/// The first method is intended for rendering all opaque geometry. The
	/// second method is intended for rendering all translucent polygonal
	/// geometry. The third one is intended for rendering all translucent
	/// volumetric geometry. Most of the volume rendering mappers draw their
	/// results during this third method.
	/// The last method is to render any 2D annotation or overlays.
	/// Each of these methods return an integer value indicating
	/// whether or not this render method was applied to this data.
	/// </summary>
	public virtual int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkProp_RenderTranslucentPolygonalGeometry_52(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp_RenderVolumetricGeometry_53(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// All concrete subclasses must be able to render themselves.
	/// There are four key render methods in vtk and they correspond
	/// to four different points in the rendering cycle. Any given
	/// prop may implement one or more of these methods.
	/// The first method is intended for rendering all opaque geometry. The
	/// second method is intended for rendering all translucent polygonal
	/// geometry. The third one is intended for rendering all translucent
	/// volumetric geometry. Most of the volume rendering mappers draw their
	/// results during this third method.
	/// The last method is to render any 2D annotation or overlays.
	/// Each of these methods return an integer value indicating
	/// whether or not this render method was applied to this data.
	/// </summary>
	public virtual int RenderVolumetricGeometry(vtkViewport arg0)
	{
		return vtkProp_RenderVolumetricGeometry_53(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_RestoreEstimatedRenderTime_54(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// When the EstimatedRenderTime is first set to 0.0 (in the
	/// SetAllocatedRenderTime method) the old value is saved. This
	/// method is used to restore that old value should the render be
	/// aborted.
	/// </summary>
	public virtual void RestoreEstimatedRenderTime()
	{
		vtkProp_RestoreEstimatedRenderTime_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProp SafeDownCast(vtkObjectBase o)
	{
		vtkProp vtkProp2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp_SafeDownCast_55(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkProp_SetAllocatedRenderTime_56(HandleRef pThis, double t, HandleRef arg1);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// The renderer may use the allocated rendering time to determine
	/// how to render this actor. Therefore it might need the information
	/// provided in the viewport.
	/// A side effect of this method is to reset the EstimatedRenderTime to
	/// 0.0. This way, each of the ways that this prop may be rendered can
	/// be timed and added together into this value.
	/// </summary>
	public virtual void SetAllocatedRenderTime(double t, vtkViewport arg1)
	{
		vtkProp_SetAllocatedRenderTime_56(GetCppThis(), t, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_SetDragable_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the value of the dragable instance variable. This determines if
	/// an Prop, once picked, can be dragged (translated) through space.
	/// This is typically done through an interactive mouse interface.
	/// This does not affect methods such as SetPosition, which will continue
	/// to work.  It is just intended to prevent some vtkProp'ss from being
	/// dragged from within a user interface.
	/// Initial value is true.
	/// </summary>
	public virtual void SetDragable(int _arg)
	{
		vtkProp_SetDragable_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_SetEstimatedRenderTime_58(HandleRef pThis, double t);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THESE METHODS OUTSIDE OF THE RENDERING PROCESS
	/// This method is used by, for example, the vtkLODProp3D in order to
	/// initialize the estimated render time at start-up to some user defined
	/// value.
	/// </summary>
	public virtual void SetEstimatedRenderTime(double t)
	{
		vtkProp_SetEstimatedRenderTime_58(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_SetPickable_59(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the pickable instance variable.  This determines if the vtkProp
	/// can be picked (typically using the mouse). Also see dragable.
	/// Initial value is true.
	/// </summary>
	public virtual void SetPickable(int _arg)
	{
		vtkProp_SetPickable_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_SetPropertyKeys_60(HandleRef pThis, HandleRef keys);

	/// <summary>
	/// Set/Get property keys. Property keys can be digest by some rendering
	/// passes.
	/// For instance, the user may mark a prop as a shadow caster for a
	/// shadow mapping render pass. Keys are documented in render pass classes.
	/// Initial value is NULL.
	/// </summary>
	public virtual void SetPropertyKeys(vtkInformation keys)
	{
		vtkProp_SetPropertyKeys_60(GetCppThis(), keys?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_SetRenderTimeMultiplier_61(HandleRef pThis, double t);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Get/Set the multiplier for the render time. This is used
	/// for culling and is a number between 0 and 1. It is used
	/// to create the allocated render time value.
	/// </summary>
	public void SetRenderTimeMultiplier(double t)
	{
		vtkProp_SetRenderTimeMultiplier_61(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_SetShaderProperty_62(HandleRef pThis, HandleRef property);

	/// <summary>
	/// Set/Get the shader property.
	/// </summary>
	public virtual void SetShaderProperty(vtkShaderProperty property)
	{
		vtkProp_SetShaderProperty_62(GetCppThis(), property?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_SetUseBounds_63(HandleRef pThis, byte _arg);

	/// <summary>
	/// In case the Visibility flag is true, tell if the bounds of this prop
	/// should be taken into account or ignored during the computation of other
	/// bounding boxes, like in vtkRenderer::ResetCamera().
	/// Initial value is true.
	/// </summary>
	public virtual void SetUseBounds(bool _arg)
	{
		vtkProp_SetUseBounds_63(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_SetVisibility_64(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get visibility of this vtkProp. Initial value is true.
	/// </summary>
	public virtual void SetVisibility(int _arg)
	{
		vtkProp_SetVisibility_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_ShallowCopy_65(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this vtkProp.
	/// </summary>
	public virtual void ShallowCopy(vtkProp prop)
	{
		vtkProp_ShallowCopy_65(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_UseBoundsOff_66(HandleRef pThis);

	/// <summary>
	/// In case the Visibility flag is true, tell if the bounds of this prop
	/// should be taken into account or ignored during the computation of other
	/// bounding boxes, like in vtkRenderer::ResetCamera().
	/// Initial value is true.
	/// </summary>
	public virtual void UseBoundsOff()
	{
		vtkProp_UseBoundsOff_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_UseBoundsOn_67(HandleRef pThis);

	/// <summary>
	/// In case the Visibility flag is true, tell if the bounds of this prop
	/// should be taken into account or ignored during the computation of other
	/// bounding boxes, like in vtkRenderer::ResetCamera().
	/// Initial value is true.
	/// </summary>
	public virtual void UseBoundsOn()
	{
		vtkProp_UseBoundsOn_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_VisibilityOff_68(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of this vtkProp. Initial value is true.
	/// </summary>
	public virtual void VisibilityOff()
	{
		vtkProp_VisibilityOff_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp_VisibilityOn_69(HandleRef pThis);

	/// <summary>
	/// Set/Get visibility of this vtkProp. Initial value is true.
	/// </summary>
	public virtual void VisibilityOn()
	{
		vtkProp_VisibilityOn_69(GetCppThis());
	}
}
