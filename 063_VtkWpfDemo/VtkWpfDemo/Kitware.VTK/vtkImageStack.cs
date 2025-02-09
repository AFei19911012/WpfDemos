using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageStack
/// </summary>
/// <remarks>
///    manages a stack of composited images
///
/// vtkImageStack manages the compositing of a set of images. Each image
/// is assigned a layer number through its property object, and it is
/// this layer number that determines the compositing order: images with
/// a higher layer number are drawn over top of images with a lower layer
/// number.  The image stack has a SetActiveLayer method for controlling
/// which layer to use for interaction and picking.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
/// <seealso>
///
/// vtkImageMapper3D vtkImageProperty vtkProp3D
/// </seealso>
public class vtkImageStack : vtkImageSlice
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageStack";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageStack()
	{
		MRClassNameKey = "class vtkImageStack";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStack"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageStack(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStack_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStack New()
	{
		vtkImageStack result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStack_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStack)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageStack()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageStack_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStack_AddImage_01(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Add an image to the stack.  If the image is already present, then
	/// this method will do nothing.
	/// </summary>
	public void AddImage(vtkImageSlice prop)
	{
		vtkImageStack_AddImage_01(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStack_BuildPaths_02(HandleRef pThis, HandleRef paths, HandleRef path);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Used to construct assembly paths and perform part traversal.
	/// </summary>
	public override void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
	{
		vtkImageStack_BuildPaths_02(GetCppThis(), paths?.GetCppThis() ?? default(HandleRef), path?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStack_GetActiveImage_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the active image.  This will be the topmost image whose
	/// LayerNumber is the ActiveLayer.  If no image matches, then NULL
	/// will be returned.
	/// </summary>
	public vtkImageSlice GetActiveImage()
	{
		vtkImageSlice vtkImageSlice2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStack_GetActiveImage_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSlice2 = (vtkImageSlice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSlice2.Register(null);
			}
		}
		return vtkImageSlice2;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStack_GetActiveLayer_04(HandleRef pThis);

	/// <summary>
	/// Set the active layer number.  This is the layer that will be
	/// used for picking and interaction.
	/// </summary>
	public int GetActiveLayer()
	{
		return vtkImageStack_GetActiveLayer_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStack_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// Get the combined bounds of all of the images.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkImageStack_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStack_GetBounds_06(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the combined bounds of all of the images.
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkImageStack_GetBounds_06(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStack_GetImages_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the list of images as a vtkImageSliceCollection.
	/// </summary>
	public vtkImageSliceCollection GetImages()
	{
		vtkImageSliceCollection vtkImageSliceCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStack_GetImages_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSliceCollection2 = (vtkImageSliceCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSliceCollection2.Register(null);
			}
		}
		return vtkImageSliceCollection2;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStack_GetImages_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors, volumes, and images. These
	/// methods are used in that process.
	/// </summary>
	public new void GetImages(vtkPropCollection arg0)
	{
		vtkImageStack_GetImages_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageStack_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// Return the max MTime of all the images.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageStack_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStack_GetMapper_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the mapper for the currently active image.
	/// </summary>
	public override vtkImageMapper3D GetMapper()
	{
		vtkImageMapper3D vtkImageMapper3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStack_GetMapper_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapper3D2 = (vtkImageMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapper3D2.Register(null);
			}
		}
		return vtkImageMapper3D2;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStack_GetNextPath_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Methods for traversing the stack as if it was an assembly.
	/// The traversal only gives the view prop for the active layer.
	/// </summary>
	public override vtkAssemblyPath GetNextPath()
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStack_GetNextPath_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStack_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageStack_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStack_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageStack_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStack_GetNumberOfPaths_14(HandleRef pThis);

	/// <summary>
	/// Methods for traversing the stack as if it was an assembly.
	/// The traversal only gives the view prop for the active layer.
	/// </summary>
	public override int GetNumberOfPaths()
	{
		return vtkImageStack_GetNumberOfPaths_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStack_GetProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property for the currently active image.
	/// </summary>
	public override vtkImageProperty GetProperty()
	{
		vtkImageProperty vtkImageProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStack_GetProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageProperty2 = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageProperty2.Register(null);
			}
		}
		return vtkImageProperty2;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageStack_GetRedrawMTime_16(HandleRef pThis);

	/// <summary>
	/// Return the mtime of anything that would cause the rendered image to
	/// appear differently. Usually this involves checking the mtime of the
	/// prop plus anything else it depends on such as properties, mappers,
	/// etc.
	/// </summary>
	public override ulong GetRedrawMTime()
	{
		return vtkImageStack_GetRedrawMTime_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStack_HasImage_17(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Check if an image is present.  The returned value is one or zero.
	/// </summary>
	public int HasImage(vtkImageSlice prop)
	{
		return vtkImageStack_HasImage_17(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStack_HasTranslucentPolygonalGeometry_18(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkImageStack_HasTranslucentPolygonalGeometry_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStack_InitPathTraversal_19(HandleRef pThis);

	/// <summary>
	/// Methods for traversing the stack as if it was an assembly.
	/// The traversal only gives the view prop for the active layer.
	/// </summary>
	public override void InitPathTraversal()
	{
		vtkImageStack_InitPathTraversal_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStack_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageStack_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStack_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageStack_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStack_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageStack NewInstance()
	{
		vtkImageStack result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStack_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStack)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStack_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Release any resources held by this prop.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkImageStack_ReleaseGraphicsResources_24(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStack_RemoveImage_25(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Remove an image from the stack.  If the image is not present, then
	/// this method will do nothing.
	/// </summary>
	public void RemoveImage(vtkImageSlice prop)
	{
		vtkImageStack_RemoveImage_25(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStack_RenderOpaqueGeometry_26(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkImageStack_RenderOpaqueGeometry_26(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStack_RenderOverlay_27(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkImageStack_RenderOverlay_27(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStack_RenderTranslucentPolygonalGeometry_28(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkImageStack_RenderTranslucentPolygonalGeometry_28(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStack_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStack SafeDownCast(vtkObjectBase o)
	{
		vtkImageStack vtkImageStack2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStack_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStack2 = (vtkImageStack)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStack2.Register(null);
			}
		}
		return vtkImageStack2;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStack_SetActiveLayer_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the active layer number.  This is the layer that will be
	/// used for picking and interaction.
	/// </summary>
	public virtual void SetActiveLayer(int _arg)
	{
		vtkImageStack_SetActiveLayer_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStack_ShallowCopy_31(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this prop. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkImageStack_ShallowCopy_31(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
