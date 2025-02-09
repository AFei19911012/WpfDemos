using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataPointSampler
/// </summary>
/// <remarks>
///    generate points from vtkPolyData
///
/// vtkPolyDataPointSampler generates points from input vtkPolyData. The
/// filter has two modes of operation: random point generation, or regular
/// point generation. In random generation mode, points are generated in each
/// polygonal entity using a random approach. In regular generation mode, the
/// points are placed approximately a specified distance apart. Optionally,
/// the points attributes can be interpolated from the generating vertices,
/// edges, and polygons.
///
/// In regular point generation mode, this filter functions as follows. First,
/// it regurgitates all input points, then it samples all lines, plus edges
/// associated with the input polygons and triangle strips to produce edge
/// points. Finally, the interiors of polygons and triangle strips are
/// subsampled to produce points. All of these operations can be enabled or
/// disabled separately. Note that this algorithm only approximately generates
/// points the specified distance apart. Generally the point density is finer
/// than requested.
///
/// In random point generation mode, this filter functions as follows. First,
/// it randomly regurgitates all input points (if enabled), then it randomly
/// samples all lines, plus edges associated with the input polygons and
/// triangle strips to produce edge points (if enabled). Finally, the
/// interiors of polygons and triangle strips are randomly subsampled to
/// produce points. All of these operations can be enabled or disabled
/// separately. Note that this algorithm only approximately generates points
/// the specified distance apart. Generally the point density is finer than
/// requested. Also note that the result is not truly random due to the
/// constraints of the mesh construction.
///
/// @warning
/// Although this algorithm processes general polygons. it does so by performing
/// a fan triangulation. This may produce poor results, especially for concave
/// polygons. For better results, use a triangle filter to pre-tesselate
/// polygons.
///
/// @warning
/// In random point generation mode, producing random edges and vertex points
/// from polygons and triangle strips is less random than is typically
/// desirable. You may wish to disable vertex and edge point generation for a
/// result that is closer to random.
///
/// @warning
/// Point generation can be useful in a variety of applications. For example,
/// generating seed points for glyphing or streamline generation. Another
/// useful application is generating points for implicit modeling. In many
/// cases implicit models can be more efficiently generated from points than
/// from polygons or other primitives.
///
/// @warning
/// When sampling polygons of five sides or more, the polygon is triangulated.
/// This can result in variations in point density near tessellation boundaries.
///
/// </remarks>
/// <seealso>
///
/// vtkTriangleFilter vtkImplicitModeller
/// </seealso>
public class vtkPolyDataPointSampler : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Specify how points are to be generated.
	/// </summary>
	public enum RANDOM_GENERATION_WrapperEnum
	{
		/// <summary>enum member</summary>
		RANDOM_GENERATION = 1,
		/// <summary>enum member</summary>
		REGULAR_GENERATION = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPointSampler";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataPointSampler()
	{
		MRClassNameKey = "class vtkPolyDataPointSampler";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPointSampler"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataPointSampler(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPointSampler_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkPolyDataPointSampler New()
	{
		vtkPolyDataPointSampler result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPointSampler_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataPointSampler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkPolyDataPointSampler()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataPointSampler_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_GenerateEdgePointsOff_01(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell edges should
	/// be sampled to produce output points. The default is true.
	/// </summary>
	public virtual void GenerateEdgePointsOff()
	{
		vtkPolyDataPointSampler_GenerateEdgePointsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_GenerateEdgePointsOn_02(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell edges should
	/// be sampled to produce output points. The default is true.
	/// </summary>
	public virtual void GenerateEdgePointsOn()
	{
		vtkPolyDataPointSampler_GenerateEdgePointsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_GenerateInteriorPointsOff_03(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell interiors should
	/// be sampled to produce output points. The default is true.
	/// </summary>
	public virtual void GenerateInteriorPointsOff()
	{
		vtkPolyDataPointSampler_GenerateInteriorPointsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_GenerateInteriorPointsOn_04(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell interiors should
	/// be sampled to produce output points. The default is true.
	/// </summary>
	public virtual void GenerateInteriorPointsOn()
	{
		vtkPolyDataPointSampler_GenerateInteriorPointsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_GenerateVertexPointsOff_05(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell vertex points should
	/// be output.
	/// </summary>
	public virtual void GenerateVertexPointsOff()
	{
		vtkPolyDataPointSampler_GenerateVertexPointsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_GenerateVertexPointsOn_06(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell vertex points should
	/// be output.
	/// </summary>
	public virtual void GenerateVertexPointsOn()
	{
		vtkPolyDataPointSampler_GenerateVertexPointsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_GenerateVerticesOff_07(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell vertices should
	/// be generated. Cell vertices are useful if you actually want to display
	/// the points (that is, for each point generated, a vertex is generated).
	/// Recall that VTK only renders vertices and not points.  The default is
	/// true.
	/// </summary>
	public virtual void GenerateVerticesOff()
	{
		vtkPolyDataPointSampler_GenerateVerticesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_GenerateVerticesOn_08(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell vertices should
	/// be generated. Cell vertices are useful if you actually want to display
	/// the points (that is, for each point generated, a vertex is generated).
	/// Recall that VTK only renders vertices and not points.  The default is
	/// true.
	/// </summary>
	public virtual void GenerateVerticesOn()
	{
		vtkPolyDataPointSampler_GenerateVerticesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataPointSampler_GetDistance_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the approximate distance between points. This is an absolute
	/// distance measure. The default is 0.01.
	/// </summary>
	public virtual double GetDistance()
	{
		return vtkPolyDataPointSampler_GetDistance_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataPointSampler_GetDistanceMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the approximate distance between points. This is an absolute
	/// distance measure. The default is 0.01.
	/// </summary>
	public virtual double GetDistanceMaxValue()
	{
		return vtkPolyDataPointSampler_GetDistanceMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataPointSampler_GetDistanceMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the approximate distance between points. This is an absolute
	/// distance measure. The default is 0.01.
	/// </summary>
	public virtual double GetDistanceMinValue()
	{
		return vtkPolyDataPointSampler_GetDistanceMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPointSampler_GetGenerateEdgePoints_12(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell edges should
	/// be sampled to produce output points. The default is true.
	/// </summary>
	public virtual bool GetGenerateEdgePoints()
	{
		return (vtkPolyDataPointSampler_GetGenerateEdgePoints_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPointSampler_GetGenerateInteriorPoints_13(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell interiors should
	/// be sampled to produce output points. The default is true.
	/// </summary>
	public virtual bool GetGenerateInteriorPoints()
	{
		return (vtkPolyDataPointSampler_GetGenerateInteriorPoints_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPointSampler_GetGenerateVertexPoints_14(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell vertex points should
	/// be output.
	/// </summary>
	public virtual bool GetGenerateVertexPoints()
	{
		return (vtkPolyDataPointSampler_GetGenerateVertexPoints_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPointSampler_GetGenerateVertices_15(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell vertices should
	/// be generated. Cell vertices are useful if you actually want to display
	/// the points (that is, for each point generated, a vertex is generated).
	/// Recall that VTK only renders vertices and not points.  The default is
	/// true.
	/// </summary>
	public virtual bool GetGenerateVertices()
	{
		return (vtkPolyDataPointSampler_GetGenerateVertices_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPointSampler_GetInterpolatePointData_16(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether point data should be
	/// interpolated onto the newly generated points. If enabled, points
	/// generated from existing vertices will carry the vertex point data;
	/// points generated from edges will interpolate point data along each edge;
	/// and interior point data (inside triangles, polygons cells) will be
	/// interpolated from the cell vertices. By default this is off.
	/// </summary>
	public virtual bool GetInterpolatePointData()
	{
		return (vtkPolyDataPointSampler_GetInterpolatePointData_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataPointSampler_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataPointSampler_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataPointSampler_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	/// Standard macros for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataPointSampler_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointSampler_GetPointGenerationMode_19(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve the type of point generation: either regular point
	/// generation or random point generation. By default, regular point
	/// generation is used.
	/// </summary>
	public virtual int GetPointGenerationMode()
	{
		return vtkPolyDataPointSampler_GetPointGenerationMode_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointSampler_GetPointGenerationModeMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve the type of point generation: either regular point
	/// generation or random point generation. By default, regular point
	/// generation is used.
	/// </summary>
	public virtual int GetPointGenerationModeMaxValue()
	{
		return vtkPolyDataPointSampler_GetPointGenerationModeMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointSampler_GetPointGenerationModeMinValue_21(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve the type of point generation: either regular point
	/// generation or random point generation. By default, regular point
	/// generation is used.
	/// </summary>
	public virtual int GetPointGenerationModeMinValue()
	{
		return vtkPolyDataPointSampler_GetPointGenerationModeMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_InterpolatePointDataOff_22(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether point data should be
	/// interpolated onto the newly generated points. If enabled, points
	/// generated from existing vertices will carry the vertex point data;
	/// points generated from edges will interpolate point data along each edge;
	/// and interior point data (inside triangles, polygons cells) will be
	/// interpolated from the cell vertices. By default this is off.
	/// </summary>
	public virtual void InterpolatePointDataOff()
	{
		vtkPolyDataPointSampler_InterpolatePointDataOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_InterpolatePointDataOn_23(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether point data should be
	/// interpolated onto the newly generated points. If enabled, points
	/// generated from existing vertices will carry the vertex point data;
	/// points generated from edges will interpolate point data along each edge;
	/// and interior point data (inside triangles, polygons cells) will be
	/// interpolated from the cell vertices. By default this is off.
	/// </summary>
	public virtual void InterpolatePointDataOn()
	{
		vtkPolyDataPointSampler_InterpolatePointDataOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointSampler_IsA_24(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataPointSampler_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPointSampler_IsTypeOf_25(string type);

	/// <summary>
	/// Standard macros for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataPointSampler_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPointSampler_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros for type information and printing.
	/// </summary>
	public new vtkPolyDataPointSampler NewInstance()
	{
		vtkPolyDataPointSampler result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPointSampler_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataPointSampler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPointSampler_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros for type information and printing.
	/// </summary>
	public new static vtkPolyDataPointSampler SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataPointSampler vtkPolyDataPointSampler2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPointSampler_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataPointSampler2 = (vtkPolyDataPointSampler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataPointSampler2.Register(null);
			}
		}
		return vtkPolyDataPointSampler2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_SetDistance_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the approximate distance between points. This is an absolute
	/// distance measure. The default is 0.01.
	/// </summary>
	public virtual void SetDistance(double _arg)
	{
		vtkPolyDataPointSampler_SetDistance_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_SetGenerateEdgePoints_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell edges should
	/// be sampled to produce output points. The default is true.
	/// </summary>
	public virtual void SetGenerateEdgePoints(bool _arg)
	{
		vtkPolyDataPointSampler_SetGenerateEdgePoints_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_SetGenerateInteriorPoints_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell interiors should
	/// be sampled to produce output points. The default is true.
	/// </summary>
	public virtual void SetGenerateInteriorPoints(bool _arg)
	{
		vtkPolyDataPointSampler_SetGenerateInteriorPoints_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_SetGenerateVertexPoints_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell vertex points should
	/// be output.
	/// </summary>
	public virtual void SetGenerateVertexPoints(bool _arg)
	{
		vtkPolyDataPointSampler_SetGenerateVertexPoints_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_SetGenerateVertices_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether cell vertices should
	/// be generated. Cell vertices are useful if you actually want to display
	/// the points (that is, for each point generated, a vertex is generated).
	/// Recall that VTK only renders vertices and not points.  The default is
	/// true.
	/// </summary>
	public virtual void SetGenerateVertices(bool _arg)
	{
		vtkPolyDataPointSampler_SetGenerateVertices_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_SetInterpolatePointData_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify/retrieve a boolean flag indicating whether point data should be
	/// interpolated onto the newly generated points. If enabled, points
	/// generated from existing vertices will carry the vertex point data;
	/// points generated from edges will interpolate point data along each edge;
	/// and interior point data (inside triangles, polygons cells) will be
	/// interpolated from the cell vertices. By default this is off.
	/// </summary>
	public virtual void SetInterpolatePointData(bool _arg)
	{
		vtkPolyDataPointSampler_SetInterpolatePointData_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_SetPointGenerationMode_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify/retrieve the type of point generation: either regular point
	/// generation or random point generation. By default, regular point
	/// generation is used.
	/// </summary>
	public virtual void SetPointGenerationMode(int _arg)
	{
		vtkPolyDataPointSampler_SetPointGenerationMode_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_SetPointGenerationModeToRandom_36(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve the type of point generation: either regular point
	/// generation or random point generation. By default, regular point
	/// generation is used.
	/// </summary>
	public void SetPointGenerationModeToRandom()
	{
		vtkPolyDataPointSampler_SetPointGenerationModeToRandom_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPointSampler_SetPointGenerationModeToRegular_37(HandleRef pThis);

	/// <summary>
	/// Specify/retrieve the type of point generation: either regular point
	/// generation or random point generation. By default, regular point
	/// generation is used.
	/// </summary>
	public void SetPointGenerationModeToRegular()
	{
		vtkPolyDataPointSampler_SetPointGenerationModeToRegular_37(GetCppThis());
	}
}
