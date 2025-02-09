using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkQuadricLODActor
/// </summary>
/// <remarks>
///    a specific level-of-detail strategy using the
/// quadric clustering decimation algorithm
///
/// vtkQuadricLODActor implements a specific strategy for level-of-detail
/// using the vtkQuadricClustering decimation algorithm. It supports only two
/// levels of detail: full resolution and a decimated version. The decimated
/// LOD is generated using a tuned strategy to produce output consistent with
/// the requested interactive frame rate (i.e., the
/// vtkRenderWindowInteractor's DesiredUpdateRate). It also makes use of
/// display lists for performance, and adjusts the vtkQuadricClustering
/// algorithm to take into account the dimensionality of the data (e.g., 2D,
/// x-y surfaces may be binned into n x n x 1 to reduce extra polygons in the
/// z-direction). Finally, the filter may optionally be set in "Static" mode
/// (this works with the vtkMapper::SetStatic() method). `Enabling Static results
/// in a one time execution of the Mapper's pipeline. After that, the pipeline
/// no longer updated (unless manually forced to do so).
///
/// @warning
/// By default the algorithm is set up to pre-compute the LODs. That is, on
/// the first render (whether a full resolution render or interactive render)
/// the LOD is computed. This behavior can be changed so that the LOD
/// construction is deferred until the first interactive render. Either way,
/// when the LOD is constructed, the user may notice a short pause.
///
/// @warning
/// This class can be used as a direct replacement for vtkActor. It may also be
/// used as a replacement for vtkFollower's (the ability to track a camera is
/// provided).
///
/// </remarks>
/// <seealso>
///
/// vtkLODActor vtkQuadricClustering
/// </seealso>
public class vtkQuadricLODActor : vtkActor
{
	/// <summary>
	/// Turn on/off a flag to control whether the underlying pipeline is static.
	/// If static, this means that the data pipeline executes once and then not
	/// again until the user manually modifies this class. By default, Static is
	/// off because trying to debug this is tricky, and you should only use it
	/// when you know what you are doing.
	/// </summary>
	public enum DataConfigurationEnum
	{
		/// <summary>enum member</summary>
		UNKNOWN = 0,
		/// <summary>enum member</summary>
		XLINE = 1,
		/// <summary>enum member</summary>
		XYPLANE = 4,
		/// <summary>enum member</summary>
		XYZVOLUME = 7,
		/// <summary>enum member</summary>
		XZPLANE = 5,
		/// <summary>enum member</summary>
		YLINE = 2,
		/// <summary>enum member</summary>
		YZPLANE = 6,
		/// <summary>enum member</summary>
		ZLINE = 3
	}

	/// <summary>
	/// This class will create a vtkQuadricClustering algorithm automatically.
	/// However, if you would like to specify the filter to use, or to access it
	/// and configure it, these method provide access to the filter.
	/// </summary>
	public enum PropTypeEnum
	{
		/// <summary>enum member</summary>
		ACTOR = 1,
		/// <summary>enum member</summary>
		FOLLOWER = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkQuadricLODActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkQuadricLODActor()
	{
		MRClassNameKey = "class vtkQuadricLODActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadricLODActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkQuadricLODActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricLODActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a vtkQuadricLODActor.
	/// </summary>
	public new static vtkQuadricLODActor New()
	{
		vtkQuadricLODActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricLODActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadricLODActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a vtkQuadricLODActor.
	/// </summary>
	public vtkQuadricLODActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkQuadricLODActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_DeferLODConstructionOff_01(HandleRef pThis);

	/// <summary>
	/// Specify whether to build the LOD immediately (i.e., on the first render)
	/// or to wait until the LOD is requested in a subsequent render. By default,
	/// LOD construction is not deferred (DeferLODConstruction is false).
	/// </summary>
	public virtual void DeferLODConstructionOff()
	{
		vtkQuadricLODActor_DeferLODConstructionOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_DeferLODConstructionOn_02(HandleRef pThis);

	/// <summary>
	/// Specify whether to build the LOD immediately (i.e., on the first render)
	/// or to wait until the LOD is requested in a subsequent render. By default,
	/// LOD construction is not deferred (DeferLODConstruction is false).
	/// </summary>
	public virtual void DeferLODConstructionOn()
	{
		vtkQuadricLODActor_DeferLODConstructionOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricLODActor_GetCamera_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the camera to follow. This method is only applicable when the
	/// prop type is set to a vtkFollower.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricLODActor_GetCamera_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricLODActor_GetCollapseDimensionRatio_04(HandleRef pThis);

	/// <summary>
	/// If the data configuration is set to UNKNOWN, this class attempts to
	/// figure out the dimensionality of the data using CollapseDimensionRatio.
	/// This ivar is the ratio of short edge of the input bounding box to its
	/// long edge, which is then used to collapse the data dimension (and set the
	/// quadric bin size in that direction to one). By default, this value is 0.05.
	/// </summary>
	public virtual double GetCollapseDimensionRatio()
	{
		return vtkQuadricLODActor_GetCollapseDimensionRatio_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricLODActor_GetCollapseDimensionRatioMaxValue_05(HandleRef pThis);

	/// <summary>
	/// If the data configuration is set to UNKNOWN, this class attempts to
	/// figure out the dimensionality of the data using CollapseDimensionRatio.
	/// This ivar is the ratio of short edge of the input bounding box to its
	/// long edge, which is then used to collapse the data dimension (and set the
	/// quadric bin size in that direction to one). By default, this value is 0.05.
	/// </summary>
	public virtual double GetCollapseDimensionRatioMaxValue()
	{
		return vtkQuadricLODActor_GetCollapseDimensionRatioMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricLODActor_GetCollapseDimensionRatioMinValue_06(HandleRef pThis);

	/// <summary>
	/// If the data configuration is set to UNKNOWN, this class attempts to
	/// figure out the dimensionality of the data using CollapseDimensionRatio.
	/// This ivar is the ratio of short edge of the input bounding box to its
	/// long edge, which is then used to collapse the data dimension (and set the
	/// quadric bin size in that direction to one). By default, this value is 0.05.
	/// </summary>
	public virtual double GetCollapseDimensionRatioMinValue()
	{
		return vtkQuadricLODActor_GetCollapseDimensionRatioMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_GetDataConfiguration_07(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public virtual int GetDataConfiguration()
	{
		return vtkQuadricLODActor_GetDataConfiguration_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_GetDataConfigurationMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public virtual int GetDataConfigurationMaxValue()
	{
		return vtkQuadricLODActor_GetDataConfigurationMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_GetDataConfigurationMinValue_09(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public virtual int GetDataConfigurationMinValue()
	{
		return vtkQuadricLODActor_GetDataConfigurationMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_GetDeferLODConstruction_10(HandleRef pThis);

	/// <summary>
	/// Specify whether to build the LOD immediately (i.e., on the first render)
	/// or to wait until the LOD is requested in a subsequent render. By default,
	/// LOD construction is not deferred (DeferLODConstruction is false).
	/// </summary>
	public virtual int GetDeferLODConstruction()
	{
		return vtkQuadricLODActor_GetDeferLODConstruction_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricLODActor_GetLODFilter_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This class will create a vtkQuadricClustering algorithm automatically.
	/// However, if you would like to specify the filter to use, or to access it
	/// and configure it, these method provide access to the filter.
	/// </summary>
	public virtual vtkQuadricClustering GetLODFilter()
	{
		vtkQuadricClustering vtkQuadricClustering2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricLODActor_GetLODFilter_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuadricClustering2 = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuadricClustering2.Register(null);
			}
		}
		return vtkQuadricClustering2;
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadricLODActor_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard class methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkQuadricLODActor_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadricLODActor_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard class methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkQuadricLODActor_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_GetPropType_14(HandleRef pThis);

	/// <summary>
	/// Indicate that this actor is actually a follower.
	/// By default, the prop type is a vtkActor.
	/// </summary>
	public virtual int GetPropType()
	{
		return vtkQuadricLODActor_GetPropType_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_GetPropTypeMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Indicate that this actor is actually a follower.
	/// By default, the prop type is a vtkActor.
	/// </summary>
	public virtual int GetPropTypeMaxValue()
	{
		return vtkQuadricLODActor_GetPropTypeMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_GetPropTypeMinValue_16(HandleRef pThis);

	/// <summary>
	/// Indicate that this actor is actually a follower.
	/// By default, the prop type is a vtkActor.
	/// </summary>
	public virtual int GetPropTypeMinValue()
	{
		return vtkQuadricLODActor_GetPropTypeMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_GetStatic_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag to control whether the underlying pipeline is static.
	/// If static, this means that the data pipeline executes once and then not
	/// again until the user manually modifies this class. By default, Static is
	/// off because trying to debug this is tricky, and you should only use it
	/// when you know what you are doing.
	/// </summary>
	public virtual int GetStatic()
	{
		return vtkQuadricLODActor_GetStatic_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard class methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkQuadricLODActor_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricLODActor_IsTypeOf_19(string type);

	/// <summary>
	/// Standard class methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkQuadricLODActor_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricLODActor_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard class methods.
	/// </summary>
	public new vtkQuadricLODActor NewInstance()
	{
		vtkQuadricLODActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricLODActor_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadricLODActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_ReleaseGraphicsResources_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkQuadricLODActor_ReleaseGraphicsResources_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_Render_23(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// This causes the actor to be rendered. Depending on the frame rate request,
	/// it will use either a full resolution render or an interactive render (i.e.,
	/// it will use the decimated geometry).
	/// </summary>
	public override void Render(vtkRenderer arg0, vtkMapper arg1)
	{
		vtkQuadricLODActor_Render_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricLODActor_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard class methods.
	/// </summary>
	public new static vtkQuadricLODActor SafeDownCast(vtkObjectBase o)
	{
		vtkQuadricLODActor vtkQuadricLODActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricLODActor_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuadricLODActor2 = (vtkQuadricLODActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuadricLODActor2.Register(null);
			}
		}
		return vtkQuadricLODActor2;
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetCamera_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the camera to follow. This method is only applicable when the
	/// prop type is set to a vtkFollower.
	/// </summary>
	public void SetCamera(vtkCamera arg0)
	{
		vtkQuadricLODActor_SetCamera_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetCollapseDimensionRatio_26(HandleRef pThis, double _arg);

	/// <summary>
	/// If the data configuration is set to UNKNOWN, this class attempts to
	/// figure out the dimensionality of the data using CollapseDimensionRatio.
	/// This ivar is the ratio of short edge of the input bounding box to its
	/// long edge, which is then used to collapse the data dimension (and set the
	/// quadric bin size in that direction to one). By default, this value is 0.05.
	/// </summary>
	public virtual void SetCollapseDimensionRatio(double _arg)
	{
		vtkQuadricLODActor_SetCollapseDimensionRatio_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDataConfiguration_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public virtual void SetDataConfiguration(int _arg)
	{
		vtkQuadricLODActor_SetDataConfiguration_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDataConfigurationToUnknown_28(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public void SetDataConfigurationToUnknown()
	{
		vtkQuadricLODActor_SetDataConfigurationToUnknown_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDataConfigurationToXLine_29(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public void SetDataConfigurationToXLine()
	{
		vtkQuadricLODActor_SetDataConfigurationToXLine_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDataConfigurationToXYPlane_30(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public void SetDataConfigurationToXYPlane()
	{
		vtkQuadricLODActor_SetDataConfigurationToXYPlane_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDataConfigurationToXYZVolume_31(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public void SetDataConfigurationToXYZVolume()
	{
		vtkQuadricLODActor_SetDataConfigurationToXYZVolume_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDataConfigurationToXZPlane_32(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public void SetDataConfigurationToXZPlane()
	{
		vtkQuadricLODActor_SetDataConfigurationToXZPlane_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDataConfigurationToYLine_33(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public void SetDataConfigurationToYLine()
	{
		vtkQuadricLODActor_SetDataConfigurationToYLine_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDataConfigurationToYZPlane_34(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public void SetDataConfigurationToYZPlane()
	{
		vtkQuadricLODActor_SetDataConfigurationToYZPlane_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDataConfigurationToZLine_35(HandleRef pThis);

	/// <summary>
	/// Force the binning of the quadric clustering according to application
	/// knowledge relative to the dimension of the data. For example, if you
	/// know your data lies in a 2D x-y plane, the performance of the quadric
	/// clustering algorithm can be greatly improved by indicating this (i.e.,
	/// the number of resulting triangles, and the quality of the decimation
	/// version is better). Setting this parameter forces the binning to be
	/// configured consistent with the dimnesionality of the data, and the
	/// collapse dimension ratio is ignored. Specifying the value of
	/// DataConfiguration to UNKNOWN (the default value) means that the class
	/// will attempt to figure the dimension of the class automatically using
	/// the CollapseDimensionRatio ivar.
	/// </summary>
	public void SetDataConfigurationToZLine()
	{
		vtkQuadricLODActor_SetDataConfigurationToZLine_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetDeferLODConstruction_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to build the LOD immediately (i.e., on the first render)
	/// or to wait until the LOD is requested in a subsequent render. By default,
	/// LOD construction is not deferred (DeferLODConstruction is false).
	/// </summary>
	public virtual void SetDeferLODConstruction(int _arg)
	{
		vtkQuadricLODActor_SetDeferLODConstruction_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetLODFilter_37(HandleRef pThis, HandleRef lodFilter);

	/// <summary>
	/// This class will create a vtkQuadricClustering algorithm automatically.
	/// However, if you would like to specify the filter to use, or to access it
	/// and configure it, these method provide access to the filter.
	/// </summary>
	public void SetLODFilter(vtkQuadricClustering lodFilter)
	{
		vtkQuadricLODActor_SetLODFilter_37(GetCppThis(), lodFilter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetPropType_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that this actor is actually a follower.
	/// By default, the prop type is a vtkActor.
	/// </summary>
	public virtual void SetPropType(int _arg)
	{
		vtkQuadricLODActor_SetPropType_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetPropTypeToActor_39(HandleRef pThis);

	/// <summary>
	/// Indicate that this actor is actually a follower.
	/// By default, the prop type is a vtkActor.
	/// </summary>
	public void SetPropTypeToActor()
	{
		vtkQuadricLODActor_SetPropTypeToActor_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetPropTypeToFollower_40(HandleRef pThis);

	/// <summary>
	/// Indicate that this actor is actually a follower.
	/// By default, the prop type is a vtkActor.
	/// </summary>
	public void SetPropTypeToFollower()
	{
		vtkQuadricLODActor_SetPropTypeToFollower_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_SetStatic_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off a flag to control whether the underlying pipeline is static.
	/// If static, this means that the data pipeline executes once and then not
	/// again until the user manually modifies this class. By default, Static is
	/// off because trying to debug this is tricky, and you should only use it
	/// when you know what you are doing.
	/// </summary>
	public virtual void SetStatic(int _arg)
	{
		vtkQuadricLODActor_SetStatic_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_ShallowCopy_42(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of an LOD actor. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkQuadricLODActor_ShallowCopy_42(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_StaticOff_43(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag to control whether the underlying pipeline is static.
	/// If static, this means that the data pipeline executes once and then not
	/// again until the user manually modifies this class. By default, Static is
	/// off because trying to debug this is tricky, and you should only use it
	/// when you know what you are doing.
	/// </summary>
	public virtual void StaticOff()
	{
		vtkQuadricLODActor_StaticOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLOD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricLODActor_StaticOn_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag to control whether the underlying pipeline is static.
	/// If static, this means that the data pipeline executes once and then not
	/// again until the user manually modifies this class. By default, Static is
	/// off because trying to debug this is tricky, and you should only use it
	/// when you know what you are doing.
	/// </summary>
	public virtual void StaticOn()
	{
		vtkQuadricLODActor_StaticOn_44(GetCppThis());
	}
}
