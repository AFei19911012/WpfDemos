using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPanoramicProjectionPass
/// </summary>
/// <remarks>
///    Render pass that render the scene in a cubemap and project
/// these six renderings to a single quad.
/// There are currently two different projections implemented (Equirectangular and Azimuthal).
/// This pass can be used to produce images that can be visualize with specific devices that re-maps
/// the distorted image to a panoramic view (for instance VR headsets, domes, panoramic screens)
///
/// Note that it is often necessary to disable frustum cullers in order to render
/// properly objects that are behind the camera.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderPass
/// </seealso>
public class vtkPanoramicProjectionPass : vtkImageProcessingPass
{
	/// <summary>
	/// Enumeration of projection types.
	/// </summary>
	public enum Azimuthal_WrapperEnum
	{
		/// <summary>enum member</summary>
		Azimuthal = 2,
		/// <summary>enum member</summary>
		Equirectangular = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPanoramicProjectionPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPanoramicProjectionPass()
	{
		MRClassNameKey = "class vtkPanoramicProjectionPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPanoramicProjectionPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPanoramicProjectionPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPanoramicProjectionPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPanoramicProjectionPass New()
	{
		vtkPanoramicProjectionPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPanoramicProjectionPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPanoramicProjectionPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPanoramicProjectionPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPanoramicProjectionPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPanoramicProjectionPass_GetAngle_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the vertical angle of projection.
	/// 180 degrees is a half sphere, 360 degrees is a full sphere,
	/// but any values in the range (90;360) can be set.
	/// Default is 180 degrees.
	/// </summary>
	public virtual double GetAngle()
	{
		return vtkPanoramicProjectionPass_GetAngle_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPanoramicProjectionPass_GetAngleMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the vertical angle of projection.
	/// 180 degrees is a half sphere, 360 degrees is a full sphere,
	/// but any values in the range (90;360) can be set.
	/// Default is 180 degrees.
	/// </summary>
	public virtual double GetAngleMaxValue()
	{
		return vtkPanoramicProjectionPass_GetAngleMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPanoramicProjectionPass_GetAngleMinValue_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the vertical angle of projection.
	/// 180 degrees is a half sphere, 360 degrees is a full sphere,
	/// but any values in the range (90;360) can be set.
	/// Default is 180 degrees.
	/// </summary>
	public virtual double GetAngleMinValue()
	{
		return vtkPanoramicProjectionPass_GetAngleMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPanoramicProjectionPass_GetCubeResolution_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the cubemap textures resolution used to render (offscreen) all directions.
	/// Default is 300.
	/// </summary>
	public virtual uint GetCubeResolution()
	{
		return vtkPanoramicProjectionPass_GetCubeResolution_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPanoramicProjectionPass_GetInterpolate_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the interpolation mode.
	/// If true, the projection of the cubemap use hardware interpolation.
	/// Default is off.
	/// </summary>
	public virtual bool GetInterpolate()
	{
		return (vtkPanoramicProjectionPass_GetInterpolate_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPanoramicProjectionPass_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPanoramicProjectionPass_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPanoramicProjectionPass_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPanoramicProjectionPass_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPanoramicProjectionPass_GetProjectionType_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of projection.
	/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
	/// horizontal straight lines.
	/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
	/// view direction. This projection produces a fisheye effect.
	/// Default is Equirectangular.
	/// </summary>
	public virtual int GetProjectionType()
	{
		return vtkPanoramicProjectionPass_GetProjectionType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPanoramicProjectionPass_GetProjectionTypeMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of projection.
	/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
	/// horizontal straight lines.
	/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
	/// view direction. This projection produces a fisheye effect.
	/// Default is Equirectangular.
	/// </summary>
	public virtual int GetProjectionTypeMaxValue()
	{
		return vtkPanoramicProjectionPass_GetProjectionTypeMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPanoramicProjectionPass_GetProjectionTypeMinValue_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of projection.
	/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
	/// horizontal straight lines.
	/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
	/// view direction. This projection produces a fisheye effect.
	/// Default is Equirectangular.
	/// </summary>
	public virtual int GetProjectionTypeMinValue()
	{
		return vtkPanoramicProjectionPass_GetProjectionTypeMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPanoramicProjectionPass_InterpolateOff_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the interpolation mode.
	/// If true, the projection of the cubemap use hardware interpolation.
	/// Default is off.
	/// </summary>
	public virtual void InterpolateOff()
	{
		vtkPanoramicProjectionPass_InterpolateOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPanoramicProjectionPass_InterpolateOn_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the interpolation mode.
	/// If true, the projection of the cubemap use hardware interpolation.
	/// Default is off.
	/// </summary>
	public virtual void InterpolateOn()
	{
		vtkPanoramicProjectionPass_InterpolateOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPanoramicProjectionPass_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPanoramicProjectionPass_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPanoramicProjectionPass_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPanoramicProjectionPass_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPanoramicProjectionPass_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPanoramicProjectionPass NewInstance()
	{
		vtkPanoramicProjectionPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPanoramicProjectionPass_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPanoramicProjectionPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPanoramicProjectionPass_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Release graphics resources and ask components to release their own resources.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkPanoramicProjectionPass_ReleaseGraphicsResources_17(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPanoramicProjectionPass_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPanoramicProjectionPass SafeDownCast(vtkObjectBase o)
	{
		vtkPanoramicProjectionPass vtkPanoramicProjectionPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPanoramicProjectionPass_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPanoramicProjectionPass2 = (vtkPanoramicProjectionPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPanoramicProjectionPass2.Register(null);
			}
		}
		return vtkPanoramicProjectionPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPanoramicProjectionPass_SetAngle_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the vertical angle of projection.
	/// 180 degrees is a half sphere, 360 degrees is a full sphere,
	/// but any values in the range (90;360) can be set.
	/// Default is 180 degrees.
	/// </summary>
	public virtual void SetAngle(double _arg)
	{
		vtkPanoramicProjectionPass_SetAngle_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPanoramicProjectionPass_SetCubeResolution_20(HandleRef pThis, uint _arg);

	/// <summary>
	/// Get/Set the cubemap textures resolution used to render (offscreen) all directions.
	/// Default is 300.
	/// </summary>
	public virtual void SetCubeResolution(uint _arg)
	{
		vtkPanoramicProjectionPass_SetCubeResolution_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPanoramicProjectionPass_SetInterpolate_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set the interpolation mode.
	/// If true, the projection of the cubemap use hardware interpolation.
	/// Default is off.
	/// </summary>
	public virtual void SetInterpolate(bool _arg)
	{
		vtkPanoramicProjectionPass_SetInterpolate_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPanoramicProjectionPass_SetProjectionType_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the type of projection.
	/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
	/// horizontal straight lines.
	/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
	/// view direction. This projection produces a fisheye effect.
	/// Default is Equirectangular.
	/// </summary>
	public virtual void SetProjectionType(int _arg)
	{
		vtkPanoramicProjectionPass_SetProjectionType_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPanoramicProjectionPass_SetProjectionTypeToAzimuthal_23(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of projection.
	/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
	/// horizontal straight lines.
	/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
	/// view direction. This projection produces a fisheye effect.
	/// Default is Equirectangular.
	/// </summary>
	public void SetProjectionTypeToAzimuthal()
	{
		vtkPanoramicProjectionPass_SetProjectionTypeToAzimuthal_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPanoramicProjectionPass_SetProjectionTypeToEquirectangular_24(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of projection.
	/// Equirectangular projection maps meridians to vertical straight lines and circles of latitude to
	/// horizontal straight lines.
	/// Azimuthal equidistant projection maps all points of the scene based on their distance to the
	/// view direction. This projection produces a fisheye effect.
	/// Default is Equirectangular.
	/// </summary>
	public void SetProjectionTypeToEquirectangular()
	{
		vtkPanoramicProjectionPass_SetProjectionTypeToEquirectangular_24(GetCppThis());
	}
}
