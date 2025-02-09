using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVolume
/// </summary>
/// <remarks>
///    represents a volume (data &amp; properties) in a rendered scene
///
///
/// vtkVolume is used to represent a volumetric entity in a rendering scene.
/// It inherits functions related to the volume's position, orientation and
/// origin from vtkProp3D. The volume maintains a reference to the
/// volumetric data (i.e., the volume mapper). The volume also contains a
/// reference to a volume property which contains all common volume rendering
/// parameters.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractVolumeMapper vtkVolumeProperty vtkProp3D
/// </seealso>
public class vtkVolume : vtkProp3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolume";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolume()
	{
		MRClassNameKey = "class vtkVolume";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolume"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a Volume with the following defaults: origin(0,0,0)
	/// position=(0,0,0) scale=1 visibility=1 pickable=1 dragable=1
	/// orientation=(0,0,0).
	/// </summary>
	public new static vtkVolume New()
	{
		vtkVolume result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a Volume with the following defaults: origin(0,0,0)
	/// position=(0,0,0) scale=1 visibility=1 pickable=1 dragable=1
	/// orientation=(0,0,0).
	/// </summary>
	public vtkVolume()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern float vtkVolume_GetArraySize_01(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public float GetArraySize()
	{
		return vtkVolume_GetArraySize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetBounds_02(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkVolume_GetBounds_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume_GetBounds_03(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkVolume_GetBounds_03(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetCorrectedScalarOpacityArray_04(HandleRef pThis, int arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetCorrectedScalarOpacityArray(int arg0)
	{
		return vtkVolume_GetCorrectedScalarOpacityArray_04(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetCorrectedScalarOpacityArray_05(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetCorrectedScalarOpacityArray()
	{
		return vtkVolume_GetCorrectedScalarOpacityArray_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetGradientOpacityArray_06(HandleRef pThis, int arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetGradientOpacityArray(int arg0)
	{
		return vtkVolume_GetGradientOpacityArray_06(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetGradientOpacityArray_07(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetGradientOpacityArray()
	{
		return vtkVolume_GetGradientOpacityArray_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkVolume_GetGradientOpacityConstant_08(HandleRef pThis, int arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public float GetGradientOpacityConstant(int arg0)
	{
		return vtkVolume_GetGradientOpacityConstant_08(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkVolume_GetGradientOpacityConstant_09(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public float GetGradientOpacityConstant()
	{
		return vtkVolume_GetGradientOpacityConstant_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetGrayArray_10(HandleRef pThis, int arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetGrayArray(int arg0)
	{
		return vtkVolume_GetGrayArray_10(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetGrayArray_11(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetGrayArray()
	{
		return vtkVolume_GetGrayArray_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVolume_GetMTime_12(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the property etc.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkVolume_GetMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetMapper_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the volume mapper.
	/// </summary>
	public virtual vtkAbstractVolumeMapper GetMapper()
	{
		vtkAbstractVolumeMapper vtkAbstractVolumeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume_GetMapper_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractVolumeMapper2 = (vtkAbstractVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractVolumeMapper2.Register(null);
			}
		}
		return vtkAbstractVolumeMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolume_GetMaxXBound_14(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMaxXBound()
	{
		return vtkVolume_GetMaxXBound_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolume_GetMaxYBound_15(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMaxYBound()
	{
		return vtkVolume_GetMaxYBound_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolume_GetMaxZBound_16(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMaxZBound()
	{
		return vtkVolume_GetMaxZBound_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolume_GetMinXBound_17(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMinXBound()
	{
		return vtkVolume_GetMinXBound_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolume_GetMinYBound_18(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMinYBound()
	{
		return vtkVolume_GetMinYBound_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolume_GetMinZBound_19(HandleRef pThis);

	/// <summary>
	/// Get the bounds - either all six at once
	/// (xmin, xmax, ymin, ymax, zmin, zmax) or one at a time.
	/// </summary>
	public double GetMinZBound()
	{
		return vtkVolume_GetMinZBound_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolume_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolume_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolume_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolume_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the volume property.
	/// </summary>
	public virtual vtkVolumeProperty GetProperty()
	{
		vtkVolumeProperty vtkVolumeProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume_GetProperty_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeProperty2 = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeProperty2.Register(null);
			}
		}
		return vtkVolumeProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetRGBArray_23(HandleRef pThis, int arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetRGBArray(int arg0)
	{
		return vtkVolume_GetRGBArray_23(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetRGBArray_24(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetRGBArray()
	{
		return vtkVolume_GetRGBArray_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVolume_GetRedrawMTime_25(HandleRef pThis);

	/// <summary>
	/// Return the mtime of anything that would cause the rendered image to
	/// appear differently. Usually this involves checking the mtime of the
	/// prop plus anything else it depends on such as properties, mappers,
	/// etc.
	/// </summary>
	public override ulong GetRedrawMTime()
	{
		return vtkVolume_GetRedrawMTime_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetScalarOpacityArray_26(HandleRef pThis, int arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetScalarOpacityArray(int arg0)
	{
		return vtkVolume_GetScalarOpacityArray_26(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_GetScalarOpacityArray_27(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public IntPtr GetScalarOpacityArray()
	{
		return vtkVolume_GetScalarOpacityArray_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVolume_GetSupportsSelection_28(HandleRef pThis);

	/// <summary>
	/// Used by vtkHardwareSelector to determine if the prop supports hardware
	/// selection.
	///
	/// @warning INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public override bool GetSupportsSelection()
	{
		return (vtkVolume_GetSupportsSelection_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume_GetVolumes_29(HandleRef pThis, HandleRef vc);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. This method
	/// is used in that process.
	/// </summary>
	public override void GetVolumes(vtkPropCollection vc)
	{
		vtkVolume_GetVolumes_29(GetCppThis(), vc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolume_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolume_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolume_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolume_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVolume NewInstance()
	{
		vtkVolume result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume_ReleaseGraphicsResources_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this volume.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkVolume_ReleaseGraphicsResources_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolume_RenderVolumetricGeometry_35(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Support the standard render methods.
	/// Depending on the mapper type, the volume may be rendered using
	/// this method (FRAMEBUFFER volume such as texture mapping will
	/// be rendered this way)
	/// </summary>
	public override int RenderVolumetricGeometry(vtkViewport viewport)
	{
		return vtkVolume_RenderVolumetricGeometry_35(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolume SafeDownCast(vtkObjectBase o)
	{
		vtkVolume vtkVolume2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolume2 = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolume2.Register(null);
			}
		}
		return vtkVolume2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume_SetMapper_37(HandleRef pThis, HandleRef mapper);

	/// <summary>
	/// Set/Get the volume mapper.
	/// </summary>
	public void SetMapper(vtkAbstractVolumeMapper mapper)
	{
		vtkVolume_SetMapper_37(GetCppThis(), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume_SetProperty_38(HandleRef pThis, HandleRef property);

	/// <summary>
	/// Set/Get the volume property.
	/// </summary>
	public virtual void SetProperty(vtkVolumeProperty property)
	{
		vtkVolume_SetProperty_38(GetCppThis(), property?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume_ShallowCopy_39(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this vtkVolume. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkVolume_ShallowCopy_39(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume_Update_40(HandleRef pThis);

	/// <summary>
	/// Update the volume rendering pipeline by updating the volume mapper
	/// </summary>
	public void Update()
	{
		vtkVolume_Update_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume_UpdateScalarOpacityforSampleSize_41(HandleRef pThis, HandleRef ren, float sample_distance);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public void UpdateScalarOpacityforSampleSize(vtkRenderer ren, float sample_distance)
	{
		vtkVolume_UpdateScalarOpacityforSampleSize_41(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), sample_distance);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume_UpdateTransferFunctions_42(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// </summary>
	public void UpdateTransferFunctions(vtkRenderer ren)
	{
		vtkVolume_UpdateTransferFunctions_42(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}
}
