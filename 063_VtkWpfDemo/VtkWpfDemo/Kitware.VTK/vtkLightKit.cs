using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLightKit
/// </summary>
/// <remarks>
///    a simple but quality lighting kit
///
/// vtkLightKit is designed to make general purpose lighting of vtk
/// scenes simple, flexible, and attractive (or at least not horribly
/// ugly without significant effort).  Use a LightKit when you want
/// more control over your lighting than you can get with the default
/// vtk light, which is a headlight located at the camera. (HeadLights
/// are very simple to use, but they don't show the shape of objects very
/// well, don't give a good sense of "up" and "down", and don't evenly
/// light the object.)
///
/// A LightKit consists of three lights, a key light, a fill light, and
/// a headlight.  The main light is the key light.  It is usually
/// positioned so that it appears like an overhead light (like the sun,
/// or a ceiling light).  It is generally positioned to shine down on the
/// scene from about a 45 degree angle vertically and at least a little
/// offset side to side.  The key light usually at least about twice as
/// bright as the total of all other lights in the scene to provide good
/// modeling of object features.
///
/// The other lights in the kit (the fill light, headlight, and a pair of
/// back lights) are weaker sources that provide extra
/// illumination to fill in the spots that the key light misses.  The
/// fill light is usually positioned across from or opposite from the
/// key light (though still on the same side of the object as the
/// camera) in order to simulate diffuse reflections from other objects
/// in the scene.  The headlight, always located at the position of the
/// camera, reduces the contrast between areas lit by the key and fill
/// light. The two back lights, one on the left of the object as seen
/// from the observer and one on the right, fill on the high-contrast
/// areas behind the object.  To enforce the relationship between the
/// different lights, the intensity of the fill, back and headlights
/// are set as a ratio to the key light brightness.  Thus, the
/// brightness of all the lights in the scene can be changed by
/// changing the key light intensity.
///
/// All lights are directional lights (infinitely far away with no
/// falloff).  Lights move with the camera.
///
/// For simplicity, the position of lights in the LightKit can only be
/// specified using angles: the elevation (latitude) and azimuth
/// (longitude) of each light with respect to the camera, expressed in
/// degrees.  (Lights always shine on the camera's lookat point.) For
/// example, a light at (elevation=0, azimuth=0) is located at the
/// camera (a headlight).  A light at (elevation=90, azimuth=0) is
/// above the lookat point, shining down.  Negative azimuth values move
/// the lights clockwise as seen above, positive values
/// counter-clockwise.  So, a light at (elevation=45, azimuth=-20) is
/// above and in front of the object and shining slightly from the left
/// side.
///
/// vtkLightKit limits the colors that can be assigned to any light to
/// those of incandescent sources such as light bulbs and sunlight.  It
/// defines a special color spectrum called "warmth" from which light
/// colors can be chosen, where 0 is cold blue, 0.5 is neutral white,
/// and 1 is deep sunset red.  Colors close to 0.5 are "cool whites" and
/// "warm whites," respectively.
///
/// Since colors far from white on the warmth scale appear less bright,
/// key-to-fill and key-to-headlight ratios are skewed by
/// key, fill, and headlight colors.  If the flag MaintainLuminance
/// is set, vtkLightKit will attempt to compensate for these perceptual
/// differences by increasing the brightness of more saturated colors.
///
/// A LightKit is not explicitly part of the vtk pipeline.  Rather, it
/// is a composite object that controls the behavior of lights using a
/// unified user interface.  Every time a parameter of vtkLightKit is
/// adjusted, the properties of its lights are modified.
///
/// @par Credits:
/// vtkLightKit was originally written and contributed to vtk by
/// Michael Halle (mhalle@bwh.harvard.edu) at the Surgical Planning
/// Lab, Brigham and Women's Hospital.
/// </remarks>
public class vtkLightKit : vtkObject
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum LightKitSubType
	{
		/// <summary>enum member</summary>
		Azimuth = 3,
		/// <summary>enum member</summary>
		Elevation = 2,
		/// <summary>enum member</summary>
		Intensity = 1,
		/// <summary>enum member</summary>
		KBRatio = 5,
		/// <summary>enum member</summary>
		KFRatio = 4,
		/// <summary>enum member</summary>
		KHRatio = 6,
		/// <summary>enum member</summary>
		Warmth = 0
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum LightKitType
	{
		/// <summary>enum member</summary>
		TBackLight = 2,
		/// <summary>enum member</summary>
		TFillLight = 1,
		/// <summary>enum member</summary>
		THeadLight = 3,
		/// <summary>enum member</summary>
		TKeyLight = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLightKit";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLightKit()
	{
		MRClassNameKey = "class vtkLightKit";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightKit"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLightKit(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLightKit New()
	{
		vtkLightKit result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightKit_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLightKit)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLightKit()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLightKit_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLightKit_AddLightsToRenderer_01(HandleRef pThis, HandleRef renderer);

	/// <summary>
	/// Add lights to, or remove lights from, a renderer.
	/// Lights may be added to more than one renderer, if desired.
	/// </summary>
	public void AddLightsToRenderer(vtkRenderer renderer)
	{
		vtkLightKit_AddLightsToRenderer_01(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_DeepCopy_02(HandleRef pThis, HandleRef kit);

	/// <summary>
	/// Add lights to, or remove lights from, a renderer.
	/// Lights may be added to more than one renderer, if desired.
	/// </summary>
	public void DeepCopy(vtkLightKit kit)
	{
		vtkLightKit_DeepCopy_02(GetCppThis(), kit?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetBackLightAngle_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public virtual double[] GetBackLightAngle()
	{
		IntPtr intPtr = vtkLightKit_GetBackLightAngle_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_GetBackLightAngle_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public virtual void GetBackLightAngle(IntPtr data)
	{
		vtkLightKit_GetBackLightAngle_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetBackLightAzimuth_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public double GetBackLightAzimuth()
	{
		return vtkLightKit_GetBackLightAzimuth_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetBackLightColor_06(HandleRef pThis);

	/// <summary>
	/// Returns the floating-point RGB values of each of the light's color.
	/// </summary>
	public virtual double[] GetBackLightColor()
	{
		IntPtr intPtr = vtkLightKit_GetBackLightColor_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_GetBackLightColor_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Returns the floating-point RGB values of each of the light's color.
	/// </summary>
	public virtual void GetBackLightColor(IntPtr data)
	{
		vtkLightKit_GetBackLightColor_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetBackLightElevation_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public double GetBackLightElevation()
	{
		return vtkLightKit_GetBackLightElevation_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetBackLightWarmth_09(HandleRef pThis);

	/// <summary>
	/// Set the warmth of each the lights.  Warmth is a parameter that
	/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
	/// blue sky), 1 is "warm" (the red of a very red sunset, or the
	/// embers of a campfire), and 0.5 is a neutral white.  The warmth
	/// scale is non-linear. Warmth values close to 0.5 are subtly
	/// "warmer" or "cooler," much like a warmer tungsten incandescent
	/// bulb, a cooler halogen, or daylight (cooler still).  Moving
	/// further away from 0.5, colors become more quickly varying towards
	/// blues and reds.  With regards to aesthetics, extremes of warmth
	/// should be used sparingly.
	/// </summary>
	public virtual double GetBackLightWarmth()
	{
		return vtkLightKit_GetBackLightWarmth_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetFillLightAngle_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public virtual double[] GetFillLightAngle()
	{
		IntPtr intPtr = vtkLightKit_GetFillLightAngle_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_GetFillLightAngle_11(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public virtual void GetFillLightAngle(IntPtr data)
	{
		vtkLightKit_GetFillLightAngle_11(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetFillLightAzimuth_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public double GetFillLightAzimuth()
	{
		return vtkLightKit_GetFillLightAzimuth_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetFillLightColor_13(HandleRef pThis);

	/// <summary>
	/// Returns the floating-point RGB values of each of the light's color.
	/// </summary>
	public virtual double[] GetFillLightColor()
	{
		IntPtr intPtr = vtkLightKit_GetFillLightColor_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_GetFillLightColor_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Returns the floating-point RGB values of each of the light's color.
	/// </summary>
	public virtual void GetFillLightColor(IntPtr data)
	{
		vtkLightKit_GetFillLightColor_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetFillLightElevation_15(HandleRef pThis);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public double GetFillLightElevation()
	{
		return vtkLightKit_GetFillLightElevation_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetFillLightWarmth_16(HandleRef pThis);

	/// <summary>
	/// Set the warmth of each the lights.  Warmth is a parameter that
	/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
	/// blue sky), 1 is "warm" (the red of a very red sunset, or the
	/// embers of a campfire), and 0.5 is a neutral white.  The warmth
	/// scale is non-linear. Warmth values close to 0.5 are subtly
	/// "warmer" or "cooler," much like a warmer tungsten incandescent
	/// bulb, a cooler halogen, or daylight (cooler still).  Moving
	/// further away from 0.5, colors become more quickly varying towards
	/// blues and reds.  With regards to aesthetics, extremes of warmth
	/// should be used sparingly.
	/// </summary>
	public virtual double GetFillLightWarmth()
	{
		return vtkLightKit_GetFillLightWarmth_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetHeadLightColor_17(HandleRef pThis);

	/// <summary>
	/// Returns the floating-point RGB values of each of the light's color.
	/// </summary>
	public virtual double[] GetHeadLightColor()
	{
		IntPtr intPtr = vtkLightKit_GetHeadLightColor_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_GetHeadLightColor_18(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Returns the floating-point RGB values of each of the light's color.
	/// </summary>
	public virtual void GetHeadLightColor(IntPtr data)
	{
		vtkLightKit_GetHeadLightColor_18(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetHeadLightWarmth_19(HandleRef pThis);

	/// <summary>
	/// Set the warmth of each the lights.  Warmth is a parameter that
	/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
	/// blue sky), 1 is "warm" (the red of a very red sunset, or the
	/// embers of a campfire), and 0.5 is a neutral white.  The warmth
	/// scale is non-linear. Warmth values close to 0.5 are subtly
	/// "warmer" or "cooler," much like a warmer tungsten incandescent
	/// bulb, a cooler halogen, or daylight (cooler still).  Moving
	/// further away from 0.5, colors become more quickly varying towards
	/// blues and reds.  With regards to aesthetics, extremes of warmth
	/// should be used sparingly.
	/// </summary>
	public virtual double GetHeadLightWarmth()
	{
		return vtkLightKit_GetHeadLightWarmth_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetKeyLightAngle_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public virtual double[] GetKeyLightAngle()
	{
		IntPtr intPtr = vtkLightKit_GetKeyLightAngle_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_GetKeyLightAngle_21(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public virtual void GetKeyLightAngle(IntPtr data)
	{
		vtkLightKit_GetKeyLightAngle_21(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyLightAzimuth_22(HandleRef pThis);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public double GetKeyLightAzimuth()
	{
		return vtkLightKit_GetKeyLightAzimuth_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetKeyLightColor_23(HandleRef pThis);

	/// <summary>
	/// Returns the floating-point RGB values of each of the light's color.
	/// </summary>
	public virtual double[] GetKeyLightColor()
	{
		IntPtr intPtr = vtkLightKit_GetKeyLightColor_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_GetKeyLightColor_24(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Returns the floating-point RGB values of each of the light's color.
	/// </summary>
	public virtual void GetKeyLightColor(IntPtr data)
	{
		vtkLightKit_GetKeyLightColor_24(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyLightElevation_25(HandleRef pThis);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public double GetKeyLightElevation()
	{
		return vtkLightKit_GetKeyLightElevation_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyLightIntensity_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the intensity of the key light.  The key light is the
	/// brightest light in the scene.  The intensities of the other two
	/// lights are ratios of the key light's intensity.
	/// </summary>
	public virtual double GetKeyLightIntensity()
	{
		return vtkLightKit_GetKeyLightIntensity_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyLightWarmth_27(HandleRef pThis);

	/// <summary>
	/// Set the warmth of each the lights.  Warmth is a parameter that
	/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
	/// blue sky), 1 is "warm" (the red of a very red sunset, or the
	/// embers of a campfire), and 0.5 is a neutral white.  The warmth
	/// scale is non-linear. Warmth values close to 0.5 are subtly
	/// "warmer" or "cooler," much like a warmer tungsten incandescent
	/// bulb, a cooler halogen, or daylight (cooler still).  Moving
	/// further away from 0.5, colors become more quickly varying towards
	/// blues and reds.  With regards to aesthetics, extremes of warmth
	/// should be used sparingly.
	/// </summary>
	public virtual double GetKeyLightWarmth()
	{
		return vtkLightKit_GetKeyLightWarmth_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyToBackRatio_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the key-to-back light ratio.  This ratio controls
	/// how bright the back lights are compared to the key light: larger
	/// values correspond to dimmer back lights.  The back lights fill
	/// in the remaining high-contrast regions behind the object.
	/// Values between 2 and 10 are good.
	/// </summary>
	public virtual double GetKeyToBackRatio()
	{
		return vtkLightKit_GetKeyToBackRatio_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyToBackRatioMaxValue_29(HandleRef pThis);

	/// <summary>
	/// Set/Get the key-to-back light ratio.  This ratio controls
	/// how bright the back lights are compared to the key light: larger
	/// values correspond to dimmer back lights.  The back lights fill
	/// in the remaining high-contrast regions behind the object.
	/// Values between 2 and 10 are good.
	/// </summary>
	public virtual double GetKeyToBackRatioMaxValue()
	{
		return vtkLightKit_GetKeyToBackRatioMaxValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyToBackRatioMinValue_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the key-to-back light ratio.  This ratio controls
	/// how bright the back lights are compared to the key light: larger
	/// values correspond to dimmer back lights.  The back lights fill
	/// in the remaining high-contrast regions behind the object.
	/// Values between 2 and 10 are good.
	/// </summary>
	public virtual double GetKeyToBackRatioMinValue()
	{
		return vtkLightKit_GetKeyToBackRatioMinValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyToFillRatio_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the key-to-fill ratio.  This ratio controls
	/// how bright the fill light is compared to the key light: larger
	/// values correspond to a dimmer fill light.  The purpose of the
	/// fill light is to light parts of the object not lit by the key
	/// light, while still maintaining contrast.  This type of lighting
	/// may correspond to indirect illumination from the key light, bounced
	/// off a wall, floor, or other object.  The fill light should never
	/// be brighter than the key light:  a good range for the key-to-fill
	/// ratio is between 2 and 10.
	/// </summary>
	public virtual double GetKeyToFillRatio()
	{
		return vtkLightKit_GetKeyToFillRatio_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyToFillRatioMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the key-to-fill ratio.  This ratio controls
	/// how bright the fill light is compared to the key light: larger
	/// values correspond to a dimmer fill light.  The purpose of the
	/// fill light is to light parts of the object not lit by the key
	/// light, while still maintaining contrast.  This type of lighting
	/// may correspond to indirect illumination from the key light, bounced
	/// off a wall, floor, or other object.  The fill light should never
	/// be brighter than the key light:  a good range for the key-to-fill
	/// ratio is between 2 and 10.
	/// </summary>
	public virtual double GetKeyToFillRatioMaxValue()
	{
		return vtkLightKit_GetKeyToFillRatioMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyToFillRatioMinValue_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the key-to-fill ratio.  This ratio controls
	/// how bright the fill light is compared to the key light: larger
	/// values correspond to a dimmer fill light.  The purpose of the
	/// fill light is to light parts of the object not lit by the key
	/// light, while still maintaining contrast.  This type of lighting
	/// may correspond to indirect illumination from the key light, bounced
	/// off a wall, floor, or other object.  The fill light should never
	/// be brighter than the key light:  a good range for the key-to-fill
	/// ratio is between 2 and 10.
	/// </summary>
	public virtual double GetKeyToFillRatioMinValue()
	{
		return vtkLightKit_GetKeyToFillRatioMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyToHeadRatio_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the key-to-headlight ratio.  Similar to the key-to-fill
	/// ratio, this ratio controls how bright the headlight light is
	/// compared to the key light: larger values correspond to a dimmer
	/// headlight light.  The headlight is special kind of fill light,
	/// lighting only the parts of the object that the camera can see.
	/// As such, a headlight tends to reduce the contrast of a scene.  It
	/// can be used to fill in "shadows" of the object missed by the key
	/// and fill lights.  The headlight should always be significantly
	/// dimmer than the key light:  ratios of 2 to 15 are typical.
	/// </summary>
	public virtual double GetKeyToHeadRatio()
	{
		return vtkLightKit_GetKeyToHeadRatio_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyToHeadRatioMaxValue_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the key-to-headlight ratio.  Similar to the key-to-fill
	/// ratio, this ratio controls how bright the headlight light is
	/// compared to the key light: larger values correspond to a dimmer
	/// headlight light.  The headlight is special kind of fill light,
	/// lighting only the parts of the object that the camera can see.
	/// As such, a headlight tends to reduce the contrast of a scene.  It
	/// can be used to fill in "shadows" of the object missed by the key
	/// and fill lights.  The headlight should always be significantly
	/// dimmer than the key light:  ratios of 2 to 15 are typical.
	/// </summary>
	public virtual double GetKeyToHeadRatioMaxValue()
	{
		return vtkLightKit_GetKeyToHeadRatioMaxValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLightKit_GetKeyToHeadRatioMinValue_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the key-to-headlight ratio.  Similar to the key-to-fill
	/// ratio, this ratio controls how bright the headlight light is
	/// compared to the key light: larger values correspond to a dimmer
	/// headlight light.  The headlight is special kind of fill light,
	/// lighting only the parts of the object that the camera can see.
	/// As such, a headlight tends to reduce the contrast of a scene.  It
	/// can be used to fill in "shadows" of the object missed by the key
	/// and fill lights.  The headlight should always be significantly
	/// dimmer than the key light:  ratios of 2 to 15 are typical.
	/// </summary>
	public virtual double GetKeyToHeadRatioMinValue()
	{
		return vtkLightKit_GetKeyToHeadRatioMinValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightKit_GetMaintainLuminance_37(HandleRef pThis);

	/// <summary>
	/// If MaintainLuminance is set, the LightKit will attempt to maintain
	/// the apparent intensity of lights based on their perceptual brightnesses.
	/// By default, MaintainLuminance is off.
	/// </summary>
	public virtual int GetMaintainLuminance()
	{
		return vtkLightKit_GetMaintainLuminance_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLightKit_GetNumberOfGenerationsFromBase_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLightKit_GetNumberOfGenerationsFromBase_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLightKit_GetNumberOfGenerationsFromBaseType_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLightKit_GetNumberOfGenerationsFromBaseType_39(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetShortStringFromSubType_40(int subtype);

	/// <summary>
	/// Helper method to go from a enum subtype to a string subtype
	/// The difference from GetStringFromSubType is that it returns
	/// a shorter strings (useful for GUI with minimum space)
	/// </summary>
	public static string GetShortStringFromSubType(int subtype)
	{
		return Marshal.PtrToStringAnsi(vtkLightKit_GetShortStringFromSubType_40(subtype));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetStringFromSubType_41(int type);

	/// <summary>
	/// Helper method to go from a enum subtype to a string subtype
	/// </summary>
	public static string GetStringFromSubType(int type)
	{
		return Marshal.PtrToStringAnsi(vtkLightKit_GetStringFromSubType_41(type));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_GetStringFromType_42(int type);

	/// <summary>
	/// Helper method to go from a enum type to a string type
	/// </summary>
	public static string GetStringFromType(int type)
	{
		return Marshal.PtrToStringAnsi(vtkLightKit_GetStringFromType_42(type));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern LightKitSubType vtkLightKit_GetSubType_43(LightKitType type, int i);

	/// <summary>
	/// Return the possible subtype from a given type. You have to pass
	/// in a number i [0,3] no check is done.
	/// </summary>
	public static LightKitSubType GetSubType(LightKitType type, int i)
	{
		return vtkLightKit_GetSubType_43(type, i);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightKit_IsA_44(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLightKit_IsA_44(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLightKit_IsTypeOf_45(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLightKit_IsTypeOf_45(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_MaintainLuminanceOff_46(HandleRef pThis);

	/// <summary>
	/// If MaintainLuminance is set, the LightKit will attempt to maintain
	/// the apparent intensity of lights based on their perceptual brightnesses.
	/// By default, MaintainLuminance is off.
	/// </summary>
	public virtual void MaintainLuminanceOff()
	{
		vtkLightKit_MaintainLuminanceOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_MaintainLuminanceOn_47(HandleRef pThis);

	/// <summary>
	/// If MaintainLuminance is set, the LightKit will attempt to maintain
	/// the apparent intensity of lights based on their perceptual brightnesses.
	/// By default, MaintainLuminance is off.
	/// </summary>
	public virtual void MaintainLuminanceOn()
	{
		vtkLightKit_MaintainLuminanceOn_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_Modified_48(HandleRef pThis);

	/// <summary>
	/// Add lights to, or remove lights from, a renderer.
	/// Lights may be added to more than one renderer, if desired.
	/// </summary>
	public override void Modified()
	{
		vtkLightKit_Modified_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_NewInstance_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLightKit NewInstance()
	{
		vtkLightKit result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightKit_NewInstance_50(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLightKit)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_RemoveLightsFromRenderer_51(HandleRef pThis, HandleRef renderer);

	/// <summary>
	/// Add lights to, or remove lights from, a renderer.
	/// Lights may be added to more than one renderer, if desired.
	/// </summary>
	public void RemoveLightsFromRenderer(vtkRenderer renderer)
	{
		vtkLightKit_RemoveLightsFromRenderer_51(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLightKit_SafeDownCast_52(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLightKit SafeDownCast(vtkObjectBase o)
	{
		vtkLightKit vtkLightKit2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLightKit_SafeDownCast_52(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLightKit2 = (vtkLightKit)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLightKit2.Register(null);
			}
		}
		return vtkLightKit2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetBackLightAngle_53(HandleRef pThis, double elevation, double azimuth);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetBackLightAngle(double elevation, double azimuth)
	{
		vtkLightKit_SetBackLightAngle_53(GetCppThis(), elevation, azimuth);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetBackLightAngle_54(HandleRef pThis, IntPtr angle);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetBackLightAngle(IntPtr angle)
	{
		vtkLightKit_SetBackLightAngle_54(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetBackLightAzimuth_55(HandleRef pThis, double x);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetBackLightAzimuth(double x)
	{
		vtkLightKit_SetBackLightAzimuth_55(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetBackLightElevation_56(HandleRef pThis, double x);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetBackLightElevation(double x)
	{
		vtkLightKit_SetBackLightElevation_56(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetBackLightWarmth_57(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the warmth of each the lights.  Warmth is a parameter that
	/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
	/// blue sky), 1 is "warm" (the red of a very red sunset, or the
	/// embers of a campfire), and 0.5 is a neutral white.  The warmth
	/// scale is non-linear. Warmth values close to 0.5 are subtly
	/// "warmer" or "cooler," much like a warmer tungsten incandescent
	/// bulb, a cooler halogen, or daylight (cooler still).  Moving
	/// further away from 0.5, colors become more quickly varying towards
	/// blues and reds.  With regards to aesthetics, extremes of warmth
	/// should be used sparingly.
	/// </summary>
	public virtual void SetBackLightWarmth(double _arg)
	{
		vtkLightKit_SetBackLightWarmth_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetFillLightAngle_58(HandleRef pThis, double elevation, double azimuth);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetFillLightAngle(double elevation, double azimuth)
	{
		vtkLightKit_SetFillLightAngle_58(GetCppThis(), elevation, azimuth);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetFillLightAngle_59(HandleRef pThis, IntPtr angle);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetFillLightAngle(IntPtr angle)
	{
		vtkLightKit_SetFillLightAngle_59(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetFillLightAzimuth_60(HandleRef pThis, double x);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetFillLightAzimuth(double x)
	{
		vtkLightKit_SetFillLightAzimuth_60(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetFillLightElevation_61(HandleRef pThis, double x);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetFillLightElevation(double x)
	{
		vtkLightKit_SetFillLightElevation_61(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetFillLightWarmth_62(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the warmth of each the lights.  Warmth is a parameter that
	/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
	/// blue sky), 1 is "warm" (the red of a very red sunset, or the
	/// embers of a campfire), and 0.5 is a neutral white.  The warmth
	/// scale is non-linear. Warmth values close to 0.5 are subtly
	/// "warmer" or "cooler," much like a warmer tungsten incandescent
	/// bulb, a cooler halogen, or daylight (cooler still).  Moving
	/// further away from 0.5, colors become more quickly varying towards
	/// blues and reds.  With regards to aesthetics, extremes of warmth
	/// should be used sparingly.
	/// </summary>
	public virtual void SetFillLightWarmth(double _arg)
	{
		vtkLightKit_SetFillLightWarmth_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetHeadLightWarmth_63(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the warmth of each the lights.  Warmth is a parameter that
	/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
	/// blue sky), 1 is "warm" (the red of a very red sunset, or the
	/// embers of a campfire), and 0.5 is a neutral white.  The warmth
	/// scale is non-linear. Warmth values close to 0.5 are subtly
	/// "warmer" or "cooler," much like a warmer tungsten incandescent
	/// bulb, a cooler halogen, or daylight (cooler still).  Moving
	/// further away from 0.5, colors become more quickly varying towards
	/// blues and reds.  With regards to aesthetics, extremes of warmth
	/// should be used sparingly.
	/// </summary>
	public virtual void SetHeadLightWarmth(double _arg)
	{
		vtkLightKit_SetHeadLightWarmth_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetKeyLightAngle_64(HandleRef pThis, double elevation, double azimuth);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetKeyLightAngle(double elevation, double azimuth)
	{
		vtkLightKit_SetKeyLightAngle_64(GetCppThis(), elevation, azimuth);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetKeyLightAngle_65(HandleRef pThis, IntPtr angle);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetKeyLightAngle(IntPtr angle)
	{
		vtkLightKit_SetKeyLightAngle_65(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetKeyLightAzimuth_66(HandleRef pThis, double x);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetKeyLightAzimuth(double x)
	{
		vtkLightKit_SetKeyLightAzimuth_66(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetKeyLightElevation_67(HandleRef pThis, double x);

	/// <summary>
	/// Get/Set the position of the key, fill, and back lights
	/// using angular methods.  Elevation corresponds to latitude,
	/// azimuth to longitude.  It is recommended that the key light
	/// always be on the viewer's side of the object and above the
	/// object, while the fill light generally lights the part of the object
	/// not lit by the fill light.  The headlight, which is always located
	/// at the viewer, can then be used to reduce the contrast in the image.
	/// There are a pair of back lights.  They are located at the same
	/// elevation and at opposing azimuths (ie, one to the left, and one to
	/// the right).  They are generally set at the equator (elevation = 0),
	/// and at approximately 120 degrees (lighting from each side and behind).
	/// </summary>
	public void SetKeyLightElevation(double x)
	{
		vtkLightKit_SetKeyLightElevation_67(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetKeyLightIntensity_68(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the intensity of the key light.  The key light is the
	/// brightest light in the scene.  The intensities of the other two
	/// lights are ratios of the key light's intensity.
	/// </summary>
	public virtual void SetKeyLightIntensity(double _arg)
	{
		vtkLightKit_SetKeyLightIntensity_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetKeyLightWarmth_69(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the warmth of each the lights.  Warmth is a parameter that
	/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
	/// blue sky), 1 is "warm" (the red of a very red sunset, or the
	/// embers of a campfire), and 0.5 is a neutral white.  The warmth
	/// scale is non-linear. Warmth values close to 0.5 are subtly
	/// "warmer" or "cooler," much like a warmer tungsten incandescent
	/// bulb, a cooler halogen, or daylight (cooler still).  Moving
	/// further away from 0.5, colors become more quickly varying towards
	/// blues and reds.  With regards to aesthetics, extremes of warmth
	/// should be used sparingly.
	/// </summary>
	public virtual void SetKeyLightWarmth(double _arg)
	{
		vtkLightKit_SetKeyLightWarmth_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetKeyToBackRatio_70(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the key-to-back light ratio.  This ratio controls
	/// how bright the back lights are compared to the key light: larger
	/// values correspond to dimmer back lights.  The back lights fill
	/// in the remaining high-contrast regions behind the object.
	/// Values between 2 and 10 are good.
	/// </summary>
	public virtual void SetKeyToBackRatio(double _arg)
	{
		vtkLightKit_SetKeyToBackRatio_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetKeyToFillRatio_71(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the key-to-fill ratio.  This ratio controls
	/// how bright the fill light is compared to the key light: larger
	/// values correspond to a dimmer fill light.  The purpose of the
	/// fill light is to light parts of the object not lit by the key
	/// light, while still maintaining contrast.  This type of lighting
	/// may correspond to indirect illumination from the key light, bounced
	/// off a wall, floor, or other object.  The fill light should never
	/// be brighter than the key light:  a good range for the key-to-fill
	/// ratio is between 2 and 10.
	/// </summary>
	public virtual void SetKeyToFillRatio(double _arg)
	{
		vtkLightKit_SetKeyToFillRatio_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetKeyToHeadRatio_72(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the key-to-headlight ratio.  Similar to the key-to-fill
	/// ratio, this ratio controls how bright the headlight light is
	/// compared to the key light: larger values correspond to a dimmer
	/// headlight light.  The headlight is special kind of fill light,
	/// lighting only the parts of the object that the camera can see.
	/// As such, a headlight tends to reduce the contrast of a scene.  It
	/// can be used to fill in "shadows" of the object missed by the key
	/// and fill lights.  The headlight should always be significantly
	/// dimmer than the key light:  ratios of 2 to 15 are typical.
	/// </summary>
	public virtual void SetKeyToHeadRatio(double _arg)
	{
		vtkLightKit_SetKeyToHeadRatio_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_SetMaintainLuminance_73(HandleRef pThis, int _arg);

	/// <summary>
	/// If MaintainLuminance is set, the LightKit will attempt to maintain
	/// the apparent intensity of lights based on their perceptual brightnesses.
	/// By default, MaintainLuminance is off.
	/// </summary>
	public virtual void SetMaintainLuminance(int _arg)
	{
		vtkLightKit_SetMaintainLuminance_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLightKit_Update_74(HandleRef pThis);

	/// <summary>
	/// Add lights to, or remove lights from, a renderer.
	/// Lights may be added to more than one renderer, if desired.
	/// </summary>
	public void Update()
	{
		vtkLightKit_Update_74(GetCppThis());
	}
}
