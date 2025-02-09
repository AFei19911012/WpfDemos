using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageSlice
/// </summary>
/// <remarks>
///    represents an image in a 3D scene
///
/// vtkImageSlice is used to represent an image in a 3D scene.  It displays
/// the image either as a slice or as a projection from the camera's
/// perspective. Adjusting the position and orientation of the slice
/// is done by adjusting the focal point and direction of the camera,
/// or alternatively the slice can be set manually in vtkImageMapper3D.
/// The lookup table and window/level are set in vtkImageProperty.
/// Prop3D methods such as SetPosition() and RotateWXYZ() change the
/// position and orientation of the data with respect to VTK world
/// coordinates.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
/// <seealso>
///
/// vtkImageMapper3D vtkImageProperty vtkProp3D
/// </seealso>
public class vtkImageSlice : vtkProp3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageSlice";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageSlice()
	{
		MRClassNameKey = "class vtkImageSlice";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSlice"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageSlice(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlice_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates an Image with the following defaults: origin(0,0,0)
	/// position=(0,0,0) scale=1 visibility=1 pickable=1 dragable=1
	/// orientation=(0,0,0).
	/// </summary>
	public new static vtkImageSlice New()
	{
		vtkImageSlice result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlice_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSlice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates an Image with the following defaults: origin(0,0,0)
	/// position=(0,0,0) scale=1 visibility=1 pickable=1 dragable=1
	/// orientation=(0,0,0).
	/// </summary>
	public vtkImageSlice()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageSlice_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageSlice_ForceTranslucentOff_01(HandleRef pThis);

	/// <summary>
	/// Force the actor to be treated as translucent.
	/// </summary>
	public virtual void ForceTranslucentOff()
	{
		vtkImageSlice_ForceTranslucentOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_ForceTranslucentOn_02(HandleRef pThis);

	/// <summary>
	/// Force the actor to be treated as translucent.
	/// </summary>
	public virtual void ForceTranslucentOn()
	{
		vtkImageSlice_ForceTranslucentOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlice_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkImageSlice_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_GetBounds_04(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkImageSlice_GetBounds_04(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageSlice_GetForceTranslucent_05(HandleRef pThis);

	/// <summary>
	/// Force the actor to be treated as translucent.
	/// </summary>
	public virtual bool GetForceTranslucent()
	{
		return (vtkImageSlice_GetForceTranslucent_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_GetImages_06(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors, volumes, and images. These
	/// methods are used in that process.
	/// </summary>
	public void GetImages(vtkPropCollection arg0)
	{
		vtkImageSlice_GetImages_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageSlice_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the property etc.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageSlice_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlice_GetMapper_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the mapper.
	/// </summary>
	public virtual vtkImageMapper3D GetMapper()
	{
		vtkImageMapper3D vtkImageMapper3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlice_GetMapper_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSlice_GetMaxXBound_09(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMaxXBound()
	{
		return vtkImageSlice_GetMaxXBound_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSlice_GetMaxYBound_10(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMaxYBound()
	{
		return vtkImageSlice_GetMaxYBound_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSlice_GetMaxZBound_11(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMaxZBound()
	{
		return vtkImageSlice_GetMaxZBound_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSlice_GetMinXBound_12(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMinXBound()
	{
		return vtkImageSlice_GetMinXBound_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSlice_GetMinYBound_13(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMinYBound()
	{
		return vtkImageSlice_GetMinYBound_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSlice_GetMinZBound_14(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMinZBound()
	{
		return vtkImageSlice_GetMinZBound_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSlice_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageSlice_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSlice_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageSlice_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlice_GetProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the image display properties.
	/// </summary>
	public virtual vtkImageProperty GetProperty()
	{
		vtkImageProperty vtkImageProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlice_GetProperty_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageSlice_GetRedrawMTime_18(HandleRef pThis);

	/// <summary>
	/// Return the mtime of anything that would cause the rendered image to
	/// appear differently. Usually this involves checking the mtime of the
	/// prop plus anything else it depends on such as properties, mappers,
	/// etc.
	/// </summary>
	public override ulong GetRedrawMTime()
	{
		return vtkImageSlice_GetRedrawMTime_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlice_HasTranslucentPolygonalGeometry_19(HandleRef pThis);

	/// <summary>
	/// Internal method, should only be used by rendering.
	/// This method will always return 0 unless ForceTranslucent is On.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkImageSlice_HasTranslucentPolygonalGeometry_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlice_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageSlice_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlice_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageSlice_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlice_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageSlice NewInstance()
	{
		vtkImageSlice result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlice_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSlice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Release any resources held by this prop.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkImageSlice_ReleaseGraphicsResources_24(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_Render_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// This causes the image and its mapper to be rendered. Note that a side
	/// effect of this method is that the pipeline will be updated.
	/// </summary>
	public virtual void Render(vtkRenderer arg0)
	{
		vtkImageSlice_Render_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlice_RenderOpaqueGeometry_26(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkImageSlice_RenderOpaqueGeometry_26(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlice_RenderOverlay_27(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkImageSlice_RenderOverlay_27(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSlice_RenderTranslucentPolygonalGeometry_28(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkImageSlice_RenderTranslucentPolygonalGeometry_28(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSlice_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSlice SafeDownCast(vtkObjectBase o)
	{
		vtkImageSlice vtkImageSlice2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSlice_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_SetForceTranslucent_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force the actor to be treated as translucent.
	/// </summary>
	public virtual void SetForceTranslucent(bool _arg)
	{
		vtkImageSlice_SetForceTranslucent_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_SetMapper_31(HandleRef pThis, HandleRef mapper);

	/// <summary>
	/// Set/Get the mapper.
	/// </summary>
	public void SetMapper(vtkImageMapper3D mapper)
	{
		vtkImageSlice_SetMapper_31(GetCppThis(), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_SetProperty_32(HandleRef pThis, HandleRef property);

	/// <summary>
	/// Set/Get the image display properties.
	/// </summary>
	public void SetProperty(vtkImageProperty property)
	{
		vtkImageSlice_SetProperty_32(GetCppThis(), property?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_SetStackedImagePass_33(HandleRef pThis, int pass);

	/// <summary>
	/// For stacked image rendering, set the pass.  The first pass
	/// renders just the backing polygon, the second pass renders
	/// the image, and the third pass renders the depth buffer.
	/// Set to -1 to render all of these in the same pass.
	/// </summary>
	public void SetStackedImagePass(int pass)
	{
		vtkImageSlice_SetStackedImagePass_33(GetCppThis(), pass);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_ShallowCopy_34(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this vtkImageSlice. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkImageSlice_ShallowCopy_34(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSlice_Update_35(HandleRef pThis);

	/// <summary>
	/// Update the rendering pipeline by updating the ImageMapper
	/// </summary>
	public void Update()
	{
		vtkImageSlice_Update_35(GetCppThis());
	}
}
