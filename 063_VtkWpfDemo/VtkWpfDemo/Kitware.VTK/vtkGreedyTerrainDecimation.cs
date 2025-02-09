using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGreedyTerrainDecimation
/// </summary>
/// <remarks>
///    reduce height field (represented as image) to reduced TIN
///
/// vtkGreedyTerrainDecimation approximates a height field with a triangle
/// mesh (triangulated irregular network - TIN) using a greedy insertion
/// algorithm similar to that described by Garland and Heckbert in their paper
/// "Fast Polygonal Approximations of Terrain and Height Fields" (Technical
/// Report CMU-CS-95-181).  The input to the filter is a height field
/// (represented by a image whose scalar values are height) and the output of
/// the filter is polygonal data consisting of triangles. The number of
/// triangles in the output is reduced in number as compared to a naive
/// tessellation of the input height field. This filter copies point data
/// from the input to the output for those points present in the output.
///
/// An brief description of the algorithm is as follows. The algorithm uses a
/// top-down decimation approach that initially represents the height field
/// with two triangles (whose vertices are at the four corners of the
/// image). These two triangles form a Delaunay triangulation. In an iterative
/// fashion, the point in the image with the greatest error (as compared to
/// the original height field) is injected into the triangulation. (Note that
/// the single point with the greatest error per triangle is identified and
/// placed into a priority queue. As the triangulation is modified, the errors
/// from the deleted triangles are removed from the queue, error values from
/// the new triangles are added.) The point whose error is at the top of the
/// queue is added to the triangulaion modifying it using the standard
/// incremental Delaunay point insertion (see vtkDelaunay2D) algorithm. Points
/// are repeatedly inserted until the appropriate (user-specified) error
/// criterion is met.
///
/// To use this filter, set the input and specify the error measure to be
/// used.  The error measure options are 1) the absolute number of triangles
/// to be produced; 2) a fractional reduction of the mesh (numTris/maxTris)
/// where maxTris is the largest possible number of triangles
/// 2*(dims[0]-1)*(dims[1]-1); 3) an absolute measure on error (maximum
/// difference in height field to reduced TIN); and 4) relative error (the
/// absolute error is normalized by the diagonal of the bounding box of the
/// height field).
///
/// @warning
/// This algorithm requires the entire input dataset to be in memory, hence it
/// may not work for extremely large images. Invoking BoundaryVertexDeletionOff
/// will allow you to stitch together images with matching boundaries.
///
/// @warning
/// The input height image is assumed to be positioned in the x-y plane so the
/// scalar value is the z-coordinate, height value.
///
/// </remarks>
/// <seealso>
///
/// vtkDecimatePro vtkQuadricDecimation vtkQuadricClustering
/// </seealso>
public class vtkGreedyTerrainDecimation : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGreedyTerrainDecimation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGreedyTerrainDecimation()
	{
		MRClassNameKey = "class vtkGreedyTerrainDecimation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGreedyTerrainDecimation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGreedyTerrainDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGreedyTerrainDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkGreedyTerrainDecimation New()
	{
		vtkGreedyTerrainDecimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGreedyTerrainDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGreedyTerrainDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkGreedyTerrainDecimation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGreedyTerrainDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_BoundaryVertexDeletionOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the deletion of vertices on the boundary of a mesh. This
	/// may limit the maximum reduction that may be achieved.
	/// </summary>
	public virtual void BoundaryVertexDeletionOff()
	{
		vtkGreedyTerrainDecimation_BoundaryVertexDeletionOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_BoundaryVertexDeletionOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the deletion of vertices on the boundary of a mesh. This
	/// may limit the maximum reduction that may be achieved.
	/// </summary>
	public virtual void BoundaryVertexDeletionOn()
	{
		vtkGreedyTerrainDecimation_BoundaryVertexDeletionOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Compute normals based on the input image. Off by default.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkGreedyTerrainDecimation_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Compute normals based on the input image. Off by default.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkGreedyTerrainDecimation_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGreedyTerrainDecimation_GetAbsoluteError_05(HandleRef pThis);

	/// <summary>
	/// Specify the absolute error of the mesh; that is, the error in height
	/// between the decimated mesh and the original height field.  You need to
	/// set this value only when the error measure is set to AbsoluteError.
	/// </summary>
	public virtual double GetAbsoluteError()
	{
		return vtkGreedyTerrainDecimation_GetAbsoluteError_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGreedyTerrainDecimation_GetAbsoluteErrorMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the absolute error of the mesh; that is, the error in height
	/// between the decimated mesh and the original height field.  You need to
	/// set this value only when the error measure is set to AbsoluteError.
	/// </summary>
	public virtual double GetAbsoluteErrorMaxValue()
	{
		return vtkGreedyTerrainDecimation_GetAbsoluteErrorMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGreedyTerrainDecimation_GetAbsoluteErrorMinValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the absolute error of the mesh; that is, the error in height
	/// between the decimated mesh and the original height field.  You need to
	/// set this value only when the error measure is set to AbsoluteError.
	/// </summary>
	public virtual double GetAbsoluteErrorMinValue()
	{
		return vtkGreedyTerrainDecimation_GetAbsoluteErrorMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGreedyTerrainDecimation_GetBoundaryVertexDeletion_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the deletion of vertices on the boundary of a mesh. This
	/// may limit the maximum reduction that may be achieved.
	/// </summary>
	public virtual int GetBoundaryVertexDeletion()
	{
		return vtkGreedyTerrainDecimation_GetBoundaryVertexDeletion_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGreedyTerrainDecimation_GetComputeNormals_09(HandleRef pThis);

	/// <summary>
	/// Compute normals based on the input image. Off by default.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkGreedyTerrainDecimation_GetComputeNormals_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGreedyTerrainDecimation_GetErrorMeasure_10(HandleRef pThis);

	/// <summary>
	/// Specify how to terminate the algorithm: either as an absolute number of
	/// triangles, a relative number of triangles (normalized by the full
	/// resolution mesh), an absolute error (in the height field), or relative
	/// error (normalized by the length of the diagonal of the image).
	/// </summary>
	public virtual int GetErrorMeasure()
	{
		return vtkGreedyTerrainDecimation_GetErrorMeasure_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGreedyTerrainDecimation_GetErrorMeasureMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify how to terminate the algorithm: either as an absolute number of
	/// triangles, a relative number of triangles (normalized by the full
	/// resolution mesh), an absolute error (in the height field), or relative
	/// error (normalized by the length of the diagonal of the image).
	/// </summary>
	public virtual int GetErrorMeasureMaxValue()
	{
		return vtkGreedyTerrainDecimation_GetErrorMeasureMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGreedyTerrainDecimation_GetErrorMeasureMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify how to terminate the algorithm: either as an absolute number of
	/// triangles, a relative number of triangles (normalized by the full
	/// resolution mesh), an absolute error (in the height field), or relative
	/// error (normalized by the length of the diagonal of the image).
	/// </summary>
	public virtual int GetErrorMeasureMinValue()
	{
		return vtkGreedyTerrainDecimation_GetErrorMeasureMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGreedyTerrainDecimation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGreedyTerrainDecimation_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGreedyTerrainDecimation_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGreedyTerrainDecimation_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGreedyTerrainDecimation_GetNumberOfTriangles_15(HandleRef pThis);

	/// <summary>
	/// Specify the number of triangles to produce on output. (It is a
	/// good idea to make sure this is less than a tessellated mesh
	/// at full resolution.) You need to set this value only when
	/// the error measure is set to NumberOfTriangles.
	/// </summary>
	public virtual long GetNumberOfTriangles()
	{
		return vtkGreedyTerrainDecimation_GetNumberOfTriangles_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGreedyTerrainDecimation_GetNumberOfTrianglesMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Specify the number of triangles to produce on output. (It is a
	/// good idea to make sure this is less than a tessellated mesh
	/// at full resolution.) You need to set this value only when
	/// the error measure is set to NumberOfTriangles.
	/// </summary>
	public virtual long GetNumberOfTrianglesMaxValue()
	{
		return vtkGreedyTerrainDecimation_GetNumberOfTrianglesMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGreedyTerrainDecimation_GetNumberOfTrianglesMinValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the number of triangles to produce on output. (It is a
	/// good idea to make sure this is less than a tessellated mesh
	/// at full resolution.) You need to set this value only when
	/// the error measure is set to NumberOfTriangles.
	/// </summary>
	public virtual long GetNumberOfTrianglesMinValue()
	{
		return vtkGreedyTerrainDecimation_GetNumberOfTrianglesMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGreedyTerrainDecimation_GetReduction_18(HandleRef pThis);

	/// <summary>
	/// Specify the reduction of the mesh (represented as a fraction).  Note
	/// that a value of 0.10 means a 10% reduction.  You need to set this value
	/// only when the error measure is set to SpecifiedReduction.
	/// </summary>
	public virtual double GetReduction()
	{
		return vtkGreedyTerrainDecimation_GetReduction_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGreedyTerrainDecimation_GetReductionMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the reduction of the mesh (represented as a fraction).  Note
	/// that a value of 0.10 means a 10% reduction.  You need to set this value
	/// only when the error measure is set to SpecifiedReduction.
	/// </summary>
	public virtual double GetReductionMaxValue()
	{
		return vtkGreedyTerrainDecimation_GetReductionMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGreedyTerrainDecimation_GetReductionMinValue_20(HandleRef pThis);

	/// <summary>
	/// Specify the reduction of the mesh (represented as a fraction).  Note
	/// that a value of 0.10 means a 10% reduction.  You need to set this value
	/// only when the error measure is set to SpecifiedReduction.
	/// </summary>
	public virtual double GetReductionMinValue()
	{
		return vtkGreedyTerrainDecimation_GetReductionMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGreedyTerrainDecimation_GetRelativeError_21(HandleRef pThis);

	/// <summary>
	/// Specify the relative error of the mesh; that is, the error in height
	/// between the decimated mesh and the original height field normalized by
	/// the diagonal of the image.  You need to set this value only when the
	/// error measure is set to RelativeError.
	/// </summary>
	public virtual double GetRelativeError()
	{
		return vtkGreedyTerrainDecimation_GetRelativeError_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGreedyTerrainDecimation_GetRelativeErrorMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Specify the relative error of the mesh; that is, the error in height
	/// between the decimated mesh and the original height field normalized by
	/// the diagonal of the image.  You need to set this value only when the
	/// error measure is set to RelativeError.
	/// </summary>
	public virtual double GetRelativeErrorMaxValue()
	{
		return vtkGreedyTerrainDecimation_GetRelativeErrorMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGreedyTerrainDecimation_GetRelativeErrorMinValue_23(HandleRef pThis);

	/// <summary>
	/// Specify the relative error of the mesh; that is, the error in height
	/// between the decimated mesh and the original height field normalized by
	/// the diagonal of the image.  You need to set this value only when the
	/// error measure is set to RelativeError.
	/// </summary>
	public virtual double GetRelativeErrorMinValue()
	{
		return vtkGreedyTerrainDecimation_GetRelativeErrorMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGreedyTerrainDecimation_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGreedyTerrainDecimation_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGreedyTerrainDecimation_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGreedyTerrainDecimation_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGreedyTerrainDecimation_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGreedyTerrainDecimation NewInstance()
	{
		vtkGreedyTerrainDecimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGreedyTerrainDecimation_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGreedyTerrainDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGreedyTerrainDecimation_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGreedyTerrainDecimation SafeDownCast(vtkObjectBase o)
	{
		vtkGreedyTerrainDecimation vtkGreedyTerrainDecimation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGreedyTerrainDecimation_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGreedyTerrainDecimation2 = (vtkGreedyTerrainDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGreedyTerrainDecimation2.Register(null);
			}
		}
		return vtkGreedyTerrainDecimation2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetAbsoluteError_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the absolute error of the mesh; that is, the error in height
	/// between the decimated mesh and the original height field.  You need to
	/// set this value only when the error measure is set to AbsoluteError.
	/// </summary>
	public virtual void SetAbsoluteError(double _arg)
	{
		vtkGreedyTerrainDecimation_SetAbsoluteError_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetBoundaryVertexDeletion_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the deletion of vertices on the boundary of a mesh. This
	/// may limit the maximum reduction that may be achieved.
	/// </summary>
	public virtual void SetBoundaryVertexDeletion(int _arg)
	{
		vtkGreedyTerrainDecimation_SetBoundaryVertexDeletion_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetComputeNormals_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Compute normals based on the input image. Off by default.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkGreedyTerrainDecimation_SetComputeNormals_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasure_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify how to terminate the algorithm: either as an absolute number of
	/// triangles, a relative number of triangles (normalized by the full
	/// resolution mesh), an absolute error (in the height field), or relative
	/// error (normalized by the length of the diagonal of the image).
	/// </summary>
	public virtual void SetErrorMeasure(int _arg)
	{
		vtkGreedyTerrainDecimation_SetErrorMeasure_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToAbsoluteError_33(HandleRef pThis);

	/// <summary>
	/// Specify how to terminate the algorithm: either as an absolute number of
	/// triangles, a relative number of triangles (normalized by the full
	/// resolution mesh), an absolute error (in the height field), or relative
	/// error (normalized by the length of the diagonal of the image).
	/// </summary>
	public void SetErrorMeasureToAbsoluteError()
	{
		vtkGreedyTerrainDecimation_SetErrorMeasureToAbsoluteError_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToNumberOfTriangles_34(HandleRef pThis);

	/// <summary>
	/// Specify how to terminate the algorithm: either as an absolute number of
	/// triangles, a relative number of triangles (normalized by the full
	/// resolution mesh), an absolute error (in the height field), or relative
	/// error (normalized by the length of the diagonal of the image).
	/// </summary>
	public void SetErrorMeasureToNumberOfTriangles()
	{
		vtkGreedyTerrainDecimation_SetErrorMeasureToNumberOfTriangles_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToRelativeError_35(HandleRef pThis);

	/// <summary>
	/// Specify how to terminate the algorithm: either as an absolute number of
	/// triangles, a relative number of triangles (normalized by the full
	/// resolution mesh), an absolute error (in the height field), or relative
	/// error (normalized by the length of the diagonal of the image).
	/// </summary>
	public void SetErrorMeasureToRelativeError()
	{
		vtkGreedyTerrainDecimation_SetErrorMeasureToRelativeError_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToSpecifiedReduction_36(HandleRef pThis);

	/// <summary>
	/// Specify how to terminate the algorithm: either as an absolute number of
	/// triangles, a relative number of triangles (normalized by the full
	/// resolution mesh), an absolute error (in the height field), or relative
	/// error (normalized by the length of the diagonal of the image).
	/// </summary>
	public void SetErrorMeasureToSpecifiedReduction()
	{
		vtkGreedyTerrainDecimation_SetErrorMeasureToSpecifiedReduction_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetNumberOfTriangles_37(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the number of triangles to produce on output. (It is a
	/// good idea to make sure this is less than a tessellated mesh
	/// at full resolution.) You need to set this value only when
	/// the error measure is set to NumberOfTriangles.
	/// </summary>
	public virtual void SetNumberOfTriangles(long _arg)
	{
		vtkGreedyTerrainDecimation_SetNumberOfTriangles_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetReduction_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the reduction of the mesh (represented as a fraction).  Note
	/// that a value of 0.10 means a 10% reduction.  You need to set this value
	/// only when the error measure is set to SpecifiedReduction.
	/// </summary>
	public virtual void SetReduction(double _arg)
	{
		vtkGreedyTerrainDecimation_SetReduction_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGreedyTerrainDecimation_SetRelativeError_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the relative error of the mesh; that is, the error in height
	/// between the decimated mesh and the original height field normalized by
	/// the diagonal of the image.  You need to set this value only when the
	/// error measure is set to RelativeError.
	/// </summary>
	public virtual void SetRelativeError(double _arg)
	{
		vtkGreedyTerrainDecimation_SetRelativeError_39(GetCppThis(), _arg);
	}
}
