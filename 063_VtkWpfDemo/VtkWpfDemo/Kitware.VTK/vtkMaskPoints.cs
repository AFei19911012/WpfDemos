using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMaskPoints
/// </summary>
/// <remarks>
///    selectively filter points
///
/// vtkMaskPoints is a filter that passes through points and point attributes
/// from input dataset. (Other geometry is not passed through.) It is
/// possible to mask every nth point, and to specify an initial offset
/// to begin masking from.
/// It is possible to also generate different random selections
/// (jittered strides, real random samples, and spatially stratified
/// random samples) from the input data.
/// The filter can also generate vertices (topological
/// primitives) as well as points. This is useful because vertices are
/// rendered while points are not.
/// </remarks>
public class vtkMaskPoints : vtkPolyDataAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum DistributionType
	{
		/// <summary>enum member</summary>
		RANDOMIZED_ID_STRIDES,
		/// <summary>enum member</summary>
		RANDOM_SAMPLING,
		/// <summary>enum member</summary>
		SPATIALLY_STRATIFIED,
		/// <summary>enum member</summary>
		UNIFORM_SPATIAL_BOUNDS,
		/// <summary>enum member</summary>
		UNIFORM_SPATIAL_SURFACE,
		/// <summary>enum member</summary>
		UNIFORM_SPATIAL_VOLUME
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMaskPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMaskPoints()
	{
		MRClassNameKey = "class vtkMaskPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMaskPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMaskPoints New()
	{
		vtkMaskPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMaskPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMaskPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMaskPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_GenerateVerticesOff_01(HandleRef pThis);

	/// <summary>
	/// Generate output polydata vertices as well as points. A useful
	/// convenience method because vertices are drawn (they are topology) while
	/// points are not (they are geometry). By default this method is off.
	/// </summary>
	public virtual void GenerateVerticesOff()
	{
		vtkMaskPoints_GenerateVerticesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_GenerateVerticesOn_02(HandleRef pThis);

	/// <summary>
	/// Generate output polydata vertices as well as points. A useful
	/// convenience method because vertices are drawn (they are topology) while
	/// points are not (they are geometry). By default this method is off.
	/// </summary>
	public virtual void GenerateVerticesOn()
	{
		vtkMaskPoints_GenerateVerticesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMaskPoints_GetGenerateVertices_03(HandleRef pThis);

	/// <summary>
	/// Generate output polydata vertices as well as points. A useful
	/// convenience method because vertices are drawn (they are topology) while
	/// points are not (they are geometry). By default this method is off.
	/// </summary>
	public virtual bool GetGenerateVertices()
	{
		return (vtkMaskPoints_GetGenerateVertices_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPoints_GetMaximumNumberOfPoints_04(HandleRef pThis);

	/// <summary>
	/// Limit the number of points that can be passed through (i.e.,
	/// sets the output sample size).
	/// </summary>
	public virtual long GetMaximumNumberOfPoints()
	{
		return vtkMaskPoints_GetMaximumNumberOfPoints_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPoints_GetMaximumNumberOfPointsMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Limit the number of points that can be passed through (i.e.,
	/// sets the output sample size).
	/// </summary>
	public virtual long GetMaximumNumberOfPointsMaxValue()
	{
		return vtkMaskPoints_GetMaximumNumberOfPointsMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPoints_GetMaximumNumberOfPointsMinValue_06(HandleRef pThis);

	/// <summary>
	/// Limit the number of points that can be passed through (i.e.,
	/// sets the output sample size).
	/// </summary>
	public virtual long GetMaximumNumberOfPointsMinValue()
	{
		return vtkMaskPoints_GetMaximumNumberOfPointsMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPoints_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMaskPoints_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPoints_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMaskPoints_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPoints_GetOffset_09(HandleRef pThis);

	/// <summary>
	/// Start sampling with this point. Ignored by certain random modes.
	/// </summary>
	public virtual long GetOffset()
	{
		return vtkMaskPoints_GetOffset_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPoints_GetOffsetMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Start sampling with this point. Ignored by certain random modes.
	/// </summary>
	public virtual long GetOffsetMaxValue()
	{
		return vtkMaskPoints_GetOffsetMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskPoints_GetOffsetMinValue_11(HandleRef pThis);

	/// <summary>
	/// Start sampling with this point. Ignored by certain random modes.
	/// </summary>
	public virtual long GetOffsetMinValue()
	{
		return vtkMaskPoints_GetOffsetMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_GetOnRatio_12(HandleRef pThis);

	/// <summary>
	/// Turn on every nth point (strided sampling), ignored by random modes.
	/// </summary>
	public virtual int GetOnRatio()
	{
		return vtkMaskPoints_GetOnRatio_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_GetOnRatioMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Turn on every nth point (strided sampling), ignored by random modes.
	/// </summary>
	public virtual int GetOnRatioMaxValue()
	{
		return vtkMaskPoints_GetOnRatioMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_GetOnRatioMinValue_14(HandleRef pThis);

	/// <summary>
	/// Turn on every nth point (strided sampling), ignored by random modes.
	/// </summary>
	public virtual int GetOnRatioMinValue()
	{
		return vtkMaskPoints_GetOnRatioMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_GetOutputPointsPrecision_15(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkMaskPoints_GetOutputPointsPrecision_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMaskPoints_GetProportionalMaximumNumberOfPoints_16(HandleRef pThis);

	/// <summary>
	/// THIS ONLY WORKS WITH THE PARALLEL IMPLEMENTATION vtkPMaskPoints RUNNING
	/// IN PARALLEL.
	/// NOTHING WILL CHANGE IF THIS IS NOT THE PARALLEL vtkPMaskPoints.
	/// Determines whether maximum number of points is taken per processor
	/// (default) or if the maximum number of points is proportionally
	/// taken across processors (i.e., number of points per
	/// processor = points on a processor * maximum number of points /
	/// total points across all processors).  In the first case,
	/// the total number of points = maximum number of points *
	/// number of processors.  In the second case, the total number of
	/// points = maximum number of points.
	/// </summary>
	public virtual bool GetProportionalMaximumNumberOfPoints()
	{
		return (vtkMaskPoints_GetProportionalMaximumNumberOfPoints_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMaskPoints_GetRandomMode_17(HandleRef pThis);

	/// <summary>
	/// Special flag causes randomization of point selection.
	/// </summary>
	public virtual bool GetRandomMode()
	{
		return (vtkMaskPoints_GetRandomMode_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_GetRandomModeType_18(HandleRef pThis);

	/// <summary>
	/// Special mode selector that switches between random mode types.
	/// 0 - randomized strides: randomly strides through the data (default);
	/// fairly certain that this is not a statistically random sample
	/// because the output depends on the order of the input and
	/// the input points do not have an equal chance to appear in the output
	/// (plus Vitter's incremental random algorithms are more complex
	/// than this, while not a proof it is good indication this isn't
	/// a statistically random sample - the closest would be algorithm S)
	/// 1 - random sample: create a statistically random sample using Vitter's
	/// incremental algorithm D without A described in Vitter
	/// "Faster Mthods for Random Sampling", Communications of the ACM
	/// Volume 27, Issue 7, 1984
	/// (OnRatio and Offset are ignored) O(sample size)
	/// 2 - spatially stratified random sample: create a spatially
	/// stratified random sample using the first method described in
	/// Woodring et al. "In-situ Sampling of a Large-Scale Particle
	/// Simulation for Interactive Visualization and Analysis",
	/// Computer Graphics Forum, 2011 (EuroVis 2011).
	/// (OnRatio and Offset are ignored) O(N log N)
	/// 3 - spatially uniform (bound based): point randomly sampled
	/// using a point locator and random positions inside the bounds
	/// of the data set.
	/// 4 - spatially uniform (surface based): points randomly sampled
	/// via an inverse transform on surface area of each cell.
	/// Note that 3D cells are ignored.
	/// 5 - spatially uniform (volume based): points randomly sampled via an
	/// inverse transform on volume area of each cell.
	/// Note that 2D cells are ignored.
	/// </summary>
	public virtual int GetRandomModeType()
	{
		return vtkMaskPoints_GetRandomModeType_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_GetRandomModeTypeMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Special mode selector that switches between random mode types.
	/// 0 - randomized strides: randomly strides through the data (default);
	/// fairly certain that this is not a statistically random sample
	/// because the output depends on the order of the input and
	/// the input points do not have an equal chance to appear in the output
	/// (plus Vitter's incremental random algorithms are more complex
	/// than this, while not a proof it is good indication this isn't
	/// a statistically random sample - the closest would be algorithm S)
	/// 1 - random sample: create a statistically random sample using Vitter's
	/// incremental algorithm D without A described in Vitter
	/// "Faster Mthods for Random Sampling", Communications of the ACM
	/// Volume 27, Issue 7, 1984
	/// (OnRatio and Offset are ignored) O(sample size)
	/// 2 - spatially stratified random sample: create a spatially
	/// stratified random sample using the first method described in
	/// Woodring et al. "In-situ Sampling of a Large-Scale Particle
	/// Simulation for Interactive Visualization and Analysis",
	/// Computer Graphics Forum, 2011 (EuroVis 2011).
	/// (OnRatio and Offset are ignored) O(N log N)
	/// 3 - spatially uniform (bound based): point randomly sampled
	/// using a point locator and random positions inside the bounds
	/// of the data set.
	/// 4 - spatially uniform (surface based): points randomly sampled
	/// via an inverse transform on surface area of each cell.
	/// Note that 3D cells are ignored.
	/// 5 - spatially uniform (volume based): points randomly sampled via an
	/// inverse transform on volume area of each cell.
	/// Note that 2D cells are ignored.
	/// </summary>
	public virtual int GetRandomModeTypeMaxValue()
	{
		return vtkMaskPoints_GetRandomModeTypeMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_GetRandomModeTypeMinValue_20(HandleRef pThis);

	/// <summary>
	/// Special mode selector that switches between random mode types.
	/// 0 - randomized strides: randomly strides through the data (default);
	/// fairly certain that this is not a statistically random sample
	/// because the output depends on the order of the input and
	/// the input points do not have an equal chance to appear in the output
	/// (plus Vitter's incremental random algorithms are more complex
	/// than this, while not a proof it is good indication this isn't
	/// a statistically random sample - the closest would be algorithm S)
	/// 1 - random sample: create a statistically random sample using Vitter's
	/// incremental algorithm D without A described in Vitter
	/// "Faster Mthods for Random Sampling", Communications of the ACM
	/// Volume 27, Issue 7, 1984
	/// (OnRatio and Offset are ignored) O(sample size)
	/// 2 - spatially stratified random sample: create a spatially
	/// stratified random sample using the first method described in
	/// Woodring et al. "In-situ Sampling of a Large-Scale Particle
	/// Simulation for Interactive Visualization and Analysis",
	/// Computer Graphics Forum, 2011 (EuroVis 2011).
	/// (OnRatio and Offset are ignored) O(N log N)
	/// 3 - spatially uniform (bound based): point randomly sampled
	/// using a point locator and random positions inside the bounds
	/// of the data set.
	/// 4 - spatially uniform (surface based): points randomly sampled
	/// via an inverse transform on surface area of each cell.
	/// Note that 3D cells are ignored.
	/// 5 - spatially uniform (volume based): points randomly sampled via an
	/// inverse transform on volume area of each cell.
	/// Note that 2D cells are ignored.
	/// </summary>
	public virtual int GetRandomModeTypeMinValue()
	{
		return vtkMaskPoints_GetRandomModeTypeMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_GetRandomSeed_21(HandleRef pThis);

	/// <summary>
	/// Set/Get Seed used for generating a spatially uniform distributions.
	/// default is 1.
	/// </summary>
	public virtual int GetRandomSeed()
	{
		return vtkMaskPoints_GetRandomSeed_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMaskPoints_GetSingleVertexPerCell_22(HandleRef pThis);

	/// <summary>
	/// When vertex generation is enabled, by default vertices are produced
	/// as multi-vertex cells (more than one per cell), if you wish to have
	/// a single vertex per cell, enable this flag.
	/// </summary>
	public virtual bool GetSingleVertexPerCell()
	{
		return (vtkMaskPoints_GetSingleVertexPerCell_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMaskPoints_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskPoints_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMaskPoints_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskPoints_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMaskPoints NewInstance()
	{
		vtkMaskPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskPoints_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMaskPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_ProportionalMaximumNumberOfPointsOff_27(HandleRef pThis);

	/// <summary>
	/// THIS ONLY WORKS WITH THE PARALLEL IMPLEMENTATION vtkPMaskPoints RUNNING
	/// IN PARALLEL.
	/// NOTHING WILL CHANGE IF THIS IS NOT THE PARALLEL vtkPMaskPoints.
	/// Determines whether maximum number of points is taken per processor
	/// (default) or if the maximum number of points is proportionally
	/// taken across processors (i.e., number of points per
	/// processor = points on a processor * maximum number of points /
	/// total points across all processors).  In the first case,
	/// the total number of points = maximum number of points *
	/// number of processors.  In the second case, the total number of
	/// points = maximum number of points.
	/// </summary>
	public virtual void ProportionalMaximumNumberOfPointsOff()
	{
		vtkMaskPoints_ProportionalMaximumNumberOfPointsOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_ProportionalMaximumNumberOfPointsOn_28(HandleRef pThis);

	/// <summary>
	/// THIS ONLY WORKS WITH THE PARALLEL IMPLEMENTATION vtkPMaskPoints RUNNING
	/// IN PARALLEL.
	/// NOTHING WILL CHANGE IF THIS IS NOT THE PARALLEL vtkPMaskPoints.
	/// Determines whether maximum number of points is taken per processor
	/// (default) or if the maximum number of points is proportionally
	/// taken across processors (i.e., number of points per
	/// processor = points on a processor * maximum number of points /
	/// total points across all processors).  In the first case,
	/// the total number of points = maximum number of points *
	/// number of processors.  In the second case, the total number of
	/// points = maximum number of points.
	/// </summary>
	public virtual void ProportionalMaximumNumberOfPointsOn()
	{
		vtkMaskPoints_ProportionalMaximumNumberOfPointsOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_RandomModeOff_29(HandleRef pThis);

	/// <summary>
	/// Special flag causes randomization of point selection.
	/// </summary>
	public virtual void RandomModeOff()
	{
		vtkMaskPoints_RandomModeOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_RandomModeOn_30(HandleRef pThis);

	/// <summary>
	/// Special flag causes randomization of point selection.
	/// </summary>
	public virtual void RandomModeOn()
	{
		vtkMaskPoints_RandomModeOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskPoints_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMaskPoints SafeDownCast(vtkObjectBase o)
	{
		vtkMaskPoints vtkMaskPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskPoints_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMaskPoints2 = (vtkMaskPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMaskPoints2.Register(null);
			}
		}
		return vtkMaskPoints2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetGenerateVertices_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Generate output polydata vertices as well as points. A useful
	/// convenience method because vertices are drawn (they are topology) while
	/// points are not (they are geometry). By default this method is off.
	/// </summary>
	public virtual void SetGenerateVertices(bool _arg)
	{
		vtkMaskPoints_SetGenerateVertices_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetMaximumNumberOfPoints_33(HandleRef pThis, long _arg);

	/// <summary>
	/// Limit the number of points that can be passed through (i.e.,
	/// sets the output sample size).
	/// </summary>
	public virtual void SetMaximumNumberOfPoints(long _arg)
	{
		vtkMaskPoints_SetMaximumNumberOfPoints_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetOffset_34(HandleRef pThis, long _arg);

	/// <summary>
	/// Start sampling with this point. Ignored by certain random modes.
	/// </summary>
	public virtual void SetOffset(long _arg)
	{
		vtkMaskPoints_SetOffset_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetOnRatio_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on every nth point (strided sampling), ignored by random modes.
	/// </summary>
	public virtual void SetOnRatio(int _arg)
	{
		vtkMaskPoints_SetOnRatio_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetOutputPointsPrecision_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkMaskPoints_SetOutputPointsPrecision_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetProportionalMaximumNumberOfPoints_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// THIS ONLY WORKS WITH THE PARALLEL IMPLEMENTATION vtkPMaskPoints RUNNING
	/// IN PARALLEL.
	/// NOTHING WILL CHANGE IF THIS IS NOT THE PARALLEL vtkPMaskPoints.
	/// Determines whether maximum number of points is taken per processor
	/// (default) or if the maximum number of points is proportionally
	/// taken across processors (i.e., number of points per
	/// processor = points on a processor * maximum number of points /
	/// total points across all processors).  In the first case,
	/// the total number of points = maximum number of points *
	/// number of processors.  In the second case, the total number of
	/// points = maximum number of points.
	/// </summary>
	public virtual void SetProportionalMaximumNumberOfPoints(bool _arg)
	{
		vtkMaskPoints_SetProportionalMaximumNumberOfPoints_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetRandomMode_38(HandleRef pThis, byte _arg);

	/// <summary>
	/// Special flag causes randomization of point selection.
	/// </summary>
	public virtual void SetRandomMode(bool _arg)
	{
		vtkMaskPoints_SetRandomMode_38(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetRandomModeType_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Special mode selector that switches between random mode types.
	/// 0 - randomized strides: randomly strides through the data (default);
	/// fairly certain that this is not a statistically random sample
	/// because the output depends on the order of the input and
	/// the input points do not have an equal chance to appear in the output
	/// (plus Vitter's incremental random algorithms are more complex
	/// than this, while not a proof it is good indication this isn't
	/// a statistically random sample - the closest would be algorithm S)
	/// 1 - random sample: create a statistically random sample using Vitter's
	/// incremental algorithm D without A described in Vitter
	/// "Faster Mthods for Random Sampling", Communications of the ACM
	/// Volume 27, Issue 7, 1984
	/// (OnRatio and Offset are ignored) O(sample size)
	/// 2 - spatially stratified random sample: create a spatially
	/// stratified random sample using the first method described in
	/// Woodring et al. "In-situ Sampling of a Large-Scale Particle
	/// Simulation for Interactive Visualization and Analysis",
	/// Computer Graphics Forum, 2011 (EuroVis 2011).
	/// (OnRatio and Offset are ignored) O(N log N)
	/// 3 - spatially uniform (bound based): point randomly sampled
	/// using a point locator and random positions inside the bounds
	/// of the data set.
	/// 4 - spatially uniform (surface based): points randomly sampled
	/// via an inverse transform on surface area of each cell.
	/// Note that 3D cells are ignored.
	/// 5 - spatially uniform (volume based): points randomly sampled via an
	/// inverse transform on volume area of each cell.
	/// Note that 2D cells are ignored.
	/// </summary>
	public virtual void SetRandomModeType(int _arg)
	{
		vtkMaskPoints_SetRandomModeType_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetRandomSeed_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get Seed used for generating a spatially uniform distributions.
	/// default is 1.
	/// </summary>
	public virtual void SetRandomSeed(int _arg)
	{
		vtkMaskPoints_SetRandomSeed_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SetSingleVertexPerCell_41(HandleRef pThis, byte _arg);

	/// <summary>
	/// When vertex generation is enabled, by default vertices are produced
	/// as multi-vertex cells (more than one per cell), if you wish to have
	/// a single vertex per cell, enable this flag.
	/// </summary>
	public virtual void SetSingleVertexPerCell(bool _arg)
	{
		vtkMaskPoints_SetSingleVertexPerCell_41(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SingleVertexPerCellOff_42(HandleRef pThis);

	/// <summary>
	/// When vertex generation is enabled, by default vertices are produced
	/// as multi-vertex cells (more than one per cell), if you wish to have
	/// a single vertex per cell, enable this flag.
	/// </summary>
	public virtual void SingleVertexPerCellOff()
	{
		vtkMaskPoints_SingleVertexPerCellOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskPoints_SingleVertexPerCellOn_43(HandleRef pThis);

	/// <summary>
	/// When vertex generation is enabled, by default vertices are produced
	/// as multi-vertex cells (more than one per cell), if you wish to have
	/// a single vertex per cell, enable this flag.
	/// </summary>
	public virtual void SingleVertexPerCellOn()
	{
		vtkMaskPoints_SingleVertexPerCellOn_43(GetCppThis());
	}
}
