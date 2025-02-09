using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkQuadricDecimation
/// </summary>
/// <remarks>
///    reduce the number of triangles in a mesh
///
/// vtkQuadricDecimation is a filter to reduce the number of triangles in
/// a triangle mesh, forming a good approximation to the original geometry.
/// The input to vtkQuadricDecimation is a vtkPolyData object, and only
/// triangles are treated. If you desire to decimate polygonal meshes, first
/// triangulate the polygons with vtkTriangleFilter.
///
/// The algorithm is based on repeated edge collapses until the requested mesh
/// reduction is achieved. Edges are placed in a priority queue based on the
/// "cost" to delete the edge. The cost is an approximate measure of error
/// (distance to the original surface)--described by the so-called quadric
/// error measure. The quadric error measure is associated with each vertex of
/// the mesh and represents a matrix of planes incident on that vertex. The
/// distance of the planes to the vertex is the error in the position of the
/// vertex (originally the vertex error iz zero). As edges are deleted, the
/// quadric error measure associated with the two end points of the edge are
/// summed (this combines the plane equations) and an optimal collapse point
/// can be computed. Edges connected to the collapse point are then reinserted
/// into the queue after computing the new cost to delete them. The process
/// continues until the desired reduction level is reached or topological
/// constraints prevent further reduction. Note that this basic algorithm can
/// be extended to higher dimensions by
/// taking into account variation in attributes (i.e., scalars, vectors, and
/// so on).
///
/// This paper is based on the work of Garland and Heckbert who first
/// presented the quadric error measure at Siggraph '97 "Surface
/// Simplification Using Quadric Error Metrics". For details of the algorithm
/// Michael Garland's Ph.D. thesis is also recommended. Hughues Hoppe's Vis
/// '99 paper, "New Quadric Metric for Simplifying Meshes with Appearance
/// Attributes" is also a good take on the subject especially as it pertains
/// to the error metric applied to attributes.
///
/// @par Thanks:
/// Thanks to Bradley Lowekamp of the National Library of Medicine/NIH for
/// contributing this class.
/// </remarks>
public class vtkQuadricDecimation : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkQuadricDecimation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkQuadricDecimation()
	{
		MRClassNameKey = "class vtkQuadricDecimation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadricDecimation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkQuadricDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuadricDecimation New()
	{
		vtkQuadricDecimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadricDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkQuadricDecimation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkQuadricDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkQuadricDecimation_AttributeErrorMetricOff_01(HandleRef pThis);

	/// <summary>
	/// Decide whether to include data attributes in the error metric. If off,
	/// then only geometric error is used to control the decimation. By default
	/// the attribute errors are off.
	/// </summary>
	public virtual void AttributeErrorMetricOff()
	{
		vtkQuadricDecimation_AttributeErrorMetricOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_AttributeErrorMetricOn_02(HandleRef pThis);

	/// <summary>
	/// Decide whether to include data attributes in the error metric. If off,
	/// then only geometric error is used to control the decimation. By default
	/// the attribute errors are off.
	/// </summary>
	public virtual void AttributeErrorMetricOn()
	{
		vtkQuadricDecimation_AttributeErrorMetricOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricDecimation_GetActualReduction_03(HandleRef pThis);

	/// <summary>
	/// Get the actual reduction. This value is only valid after the
	/// filter has executed.
	/// </summary>
	public virtual double GetActualReduction()
	{
		return vtkQuadricDecimation_GetActualReduction_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricDecimation_GetAttributeErrorMetric_04(HandleRef pThis);

	/// <summary>
	/// Decide whether to include data attributes in the error metric. If off,
	/// then only geometric error is used to control the decimation. By default
	/// the attribute errors are off.
	/// </summary>
	public virtual int GetAttributeErrorMetric()
	{
		return vtkQuadricDecimation_GetAttributeErrorMetric_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricDecimation_GetNormalsAttribute_05(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual int GetNormalsAttribute()
	{
		return vtkQuadricDecimation_GetNormalsAttribute_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricDecimation_GetNormalsWeight_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual double GetNormalsWeight()
	{
		return vtkQuadricDecimation_GetNormalsWeight_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadricDecimation_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkQuadricDecimation_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadricDecimation_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkQuadricDecimation_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricDecimation_GetScalarsAttribute_09(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual int GetScalarsAttribute()
	{
		return vtkQuadricDecimation_GetScalarsAttribute_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricDecimation_GetScalarsWeight_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual double GetScalarsWeight()
	{
		return vtkQuadricDecimation_GetScalarsWeight_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricDecimation_GetTCoordsAttribute_11(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual int GetTCoordsAttribute()
	{
		return vtkQuadricDecimation_GetTCoordsAttribute_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricDecimation_GetTCoordsWeight_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual double GetTCoordsWeight()
	{
		return vtkQuadricDecimation_GetTCoordsWeight_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricDecimation_GetTargetReduction_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired reduction (expressed as a fraction of the original
	/// number of triangles). The actual reduction may be less depending on
	/// triangulation and topological constraints.
	/// </summary>
	public virtual double GetTargetReduction()
	{
		return vtkQuadricDecimation_GetTargetReduction_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricDecimation_GetTargetReductionMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired reduction (expressed as a fraction of the original
	/// number of triangles). The actual reduction may be less depending on
	/// triangulation and topological constraints.
	/// </summary>
	public virtual double GetTargetReductionMaxValue()
	{
		return vtkQuadricDecimation_GetTargetReductionMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricDecimation_GetTargetReductionMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired reduction (expressed as a fraction of the original
	/// number of triangles). The actual reduction may be less depending on
	/// triangulation and topological constraints.
	/// </summary>
	public virtual double GetTargetReductionMinValue()
	{
		return vtkQuadricDecimation_GetTargetReductionMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricDecimation_GetTensorsAttribute_16(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual int GetTensorsAttribute()
	{
		return vtkQuadricDecimation_GetTensorsAttribute_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricDecimation_GetTensorsWeight_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual double GetTensorsWeight()
	{
		return vtkQuadricDecimation_GetTensorsWeight_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricDecimation_GetVectorsAttribute_18(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual int GetVectorsAttribute()
	{
		return vtkQuadricDecimation_GetVectorsAttribute_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricDecimation_GetVectorsWeight_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual double GetVectorsWeight()
	{
		return vtkQuadricDecimation_GetVectorsWeight_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricDecimation_GetVolumePreservation_20(HandleRef pThis);

	/// <summary>
	/// Decide whether to activate volume preservation which greatly reduces errors
	/// in triangle normal direction. If off, volume preservation is disabled and
	/// if AttributeErrorMetric is active, these errors can be large.
	/// By default VolumePreservation is off
	/// the attribute errors are off.
	/// </summary>
	public virtual int GetVolumePreservation()
	{
		return vtkQuadricDecimation_GetVolumePreservation_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricDecimation_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkQuadricDecimation_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricDecimation_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkQuadricDecimation_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricDecimation_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkQuadricDecimation NewInstance()
	{
		vtkQuadricDecimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricDecimation_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadricDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_NormalsAttributeOff_25(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void NormalsAttributeOff()
	{
		vtkQuadricDecimation_NormalsAttributeOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_NormalsAttributeOn_26(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void NormalsAttributeOn()
	{
		vtkQuadricDecimation_NormalsAttributeOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricDecimation_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuadricDecimation SafeDownCast(vtkObjectBase o)
	{
		vtkQuadricDecimation vtkQuadricDecimation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricDecimation_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuadricDecimation2 = (vtkQuadricDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuadricDecimation2.Register(null);
			}
		}
		return vtkQuadricDecimation2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_ScalarsAttributeOff_28(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void ScalarsAttributeOff()
	{
		vtkQuadricDecimation_ScalarsAttributeOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_ScalarsAttributeOn_29(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void ScalarsAttributeOn()
	{
		vtkQuadricDecimation_ScalarsAttributeOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetAttributeErrorMetric_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Decide whether to include data attributes in the error metric. If off,
	/// then only geometric error is used to control the decimation. By default
	/// the attribute errors are off.
	/// </summary>
	public virtual void SetAttributeErrorMetric(int _arg)
	{
		vtkQuadricDecimation_SetAttributeErrorMetric_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetNormalsAttribute_31(HandleRef pThis, int _arg);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void SetNormalsAttribute(int _arg)
	{
		vtkQuadricDecimation_SetNormalsAttribute_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetNormalsWeight_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual void SetNormalsWeight(double _arg)
	{
		vtkQuadricDecimation_SetNormalsWeight_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetScalarsAttribute_33(HandleRef pThis, int _arg);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void SetScalarsAttribute(int _arg)
	{
		vtkQuadricDecimation_SetScalarsAttribute_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetScalarsWeight_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual void SetScalarsWeight(double _arg)
	{
		vtkQuadricDecimation_SetScalarsWeight_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetTCoordsAttribute_35(HandleRef pThis, int _arg);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void SetTCoordsAttribute(int _arg)
	{
		vtkQuadricDecimation_SetTCoordsAttribute_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetTCoordsWeight_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual void SetTCoordsWeight(double _arg)
	{
		vtkQuadricDecimation_SetTCoordsWeight_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetTargetReduction_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the desired reduction (expressed as a fraction of the original
	/// number of triangles). The actual reduction may be less depending on
	/// triangulation and topological constraints.
	/// </summary>
	public virtual void SetTargetReduction(double _arg)
	{
		vtkQuadricDecimation_SetTargetReduction_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetTensorsAttribute_38(HandleRef pThis, int _arg);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void SetTensorsAttribute(int _arg)
	{
		vtkQuadricDecimation_SetTensorsAttribute_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetTensorsWeight_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual void SetTensorsWeight(double _arg)
	{
		vtkQuadricDecimation_SetTensorsWeight_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetVectorsAttribute_40(HandleRef pThis, int _arg);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void SetVectorsAttribute(int _arg)
	{
		vtkQuadricDecimation_SetVectorsAttribute_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetVectorsWeight_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling weight contribution of the attribute. These
	/// values are used to weight the contribution of the attributes
	/// towards the error metric.
	/// </summary>
	public virtual void SetVectorsWeight(double _arg)
	{
		vtkQuadricDecimation_SetVectorsWeight_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_SetVolumePreservation_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Decide whether to activate volume preservation which greatly reduces errors
	/// in triangle normal direction. If off, volume preservation is disabled and
	/// if AttributeErrorMetric is active, these errors can be large.
	/// By default VolumePreservation is off
	/// the attribute errors are off.
	/// </summary>
	public virtual void SetVolumePreservation(int _arg)
	{
		vtkQuadricDecimation_SetVolumePreservation_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_TCoordsAttributeOff_43(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void TCoordsAttributeOff()
	{
		vtkQuadricDecimation_TCoordsAttributeOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_TCoordsAttributeOn_44(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void TCoordsAttributeOn()
	{
		vtkQuadricDecimation_TCoordsAttributeOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_TensorsAttributeOff_45(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void TensorsAttributeOff()
	{
		vtkQuadricDecimation_TensorsAttributeOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_TensorsAttributeOn_46(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void TensorsAttributeOn()
	{
		vtkQuadricDecimation_TensorsAttributeOn_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_VectorsAttributeOff_47(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void VectorsAttributeOff()
	{
		vtkQuadricDecimation_VectorsAttributeOff_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_VectorsAttributeOn_48(HandleRef pThis);

	/// <summary>
	/// If attribute errors are to be included in the metric (i.e.,
	/// AttributeErrorMetric is on), then the following flags control which
	/// attributes are to be included in the error calculation. By default all
	/// of these are on.
	/// </summary>
	public virtual void VectorsAttributeOn()
	{
		vtkQuadricDecimation_VectorsAttributeOn_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_VolumePreservationOff_49(HandleRef pThis);

	/// <summary>
	/// Decide whether to activate volume preservation which greatly reduces errors
	/// in triangle normal direction. If off, volume preservation is disabled and
	/// if AttributeErrorMetric is active, these errors can be large.
	/// By default VolumePreservation is off
	/// the attribute errors are off.
	/// </summary>
	public virtual void VolumePreservationOff()
	{
		vtkQuadricDecimation_VolumePreservationOff_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricDecimation_VolumePreservationOn_50(HandleRef pThis);

	/// <summary>
	/// Decide whether to activate volume preservation which greatly reduces errors
	/// in triangle normal direction. If off, volume preservation is disabled and
	/// if AttributeErrorMetric is active, these errors can be large.
	/// By default VolumePreservation is off
	/// the attribute errors are off.
	/// </summary>
	public virtual void VolumePreservationOn()
	{
		vtkQuadricDecimation_VolumePreservationOn_50(GetCppThis());
	}
}
