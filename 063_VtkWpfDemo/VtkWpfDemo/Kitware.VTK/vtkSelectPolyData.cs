using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSelectPolyData
/// </summary>
/// <remarks>
///    select portion of polygonal mesh; generate selection scalars
///
/// vtkSelectPolyData is a filter that selects polygonal data based on
/// defining a "loop" and indicating the region inside of the loop. The
/// mesh within the loop consists of complete cells (the cells are not
/// cut). Alternatively, this filter can be used to generate scalars.
/// These scalar values, which are a distance measure to the loop, can
/// be used to clip, contour. or extract data (i.e., anything that an
/// implicit function can do).
///
/// The loop is defined by an array of x-y-z point coordinates.
/// (Coordinates should be in the same coordinate space as the input
/// polygonal data.) The loop can be concave and non-planar, but not
/// self-intersecting. The input to the filter is a polygonal mesh
/// (only surface primitives such as triangle strips and polygons); the
/// output is either a) a portion of the original mesh laying within
/// the selection loop (GenerateSelectionScalarsOff); or b) the same
/// polygonal mesh with the addition of scalar values
/// (GenerateSelectionScalarsOn).
///
/// The algorithm works as follows. For each point coordinate in the
/// loop, the closest point in the mesh is found. The result is a loop
/// of closest point ids from the mesh. Then, the edges in the mesh
/// connecting the closest points (and laying along the lines forming
/// the loop) are found. Edges between the points can be searched using
/// one of these methods:
/// A) Greedy edge tracking.
/// At the current point, the mesh edge oriented in the
/// direction of and whose end point is closest to the line is
/// chosen. The edge is followed to the new end point, and the
/// procedure is repeated. This process continues until the entire loop
/// has been created. This method is simple and fast but heuristic,
/// and edge search can randomly fail ("Can't follow edge" error)
/// even for simple, flawless meshes when edge search arrives to a point
/// from where there is no edge pointing towards the next loop point.
/// B) Dijkstra shortest path. This method guarantees to find the shortest
/// path between the loop points.
///
/// By default the greedy edge tracking method is used to preserve
/// backward compatibility, but generally the Dijkstra shortest path
/// method is recommended due to its robustness.
///
/// To determine what portion of the mesh is inside and outside of the
/// loop, three options are possible. 1) the smallest connected region,
/// 2) the largest connected region, and 3) the connected region
/// closest to a user specified point. (Set the ivar SelectionMode.)
///
/// Once the loop is computed as above, the GenerateSelectionScalars
/// controls the output of the filter. If on, then scalar values are
/// generated based on distance to the loop lines. Otherwise, the cells
/// laying inside the selection loop are output. By default, the mesh
/// laying within the loop is output; however, if InsideOut is on, then
/// the portion of the mesh laying outside of the loop is output.
///
/// The filter can be configured to generate the unselected portions of
/// the mesh as output by setting GenerateUnselectedOutput. Use the
/// method GetUnselectedOutput to access this output. (Note: this flag
/// is pertinent only when GenerateSelectionScalars is off.)
///
/// @warning
/// Make sure that the points you pick are on a connected surface. If
/// not, then the filter will generate an empty or partial result. Also,
/// self-intersecting loops will generate unpredictable results.
///
/// @warning
/// During processing of the data, non-triangular cells are converted to
/// triangles if GenerateSelectionScalars is off.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitSelectionLoop
/// </seealso>
public class vtkSelectPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSelectPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSelectPolyData()
	{
		MRClassNameKey = "class vtkSelectPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSelectPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with InsideOut turned off, and
	/// GenerateSelectionScalars turned off. The unselected output
	/// is not generated, and the inside mode is the smallest region.
	/// </summary>
	public new static vtkSelectPolyData New()
	{
		vtkSelectPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with InsideOut turned off, and
	/// GenerateSelectionScalars turned off. The unselected output
	/// is not generated, and the inside mode is the smallest region.
	/// </summary>
	public vtkSelectPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSelectPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSelectPolyData_GenerateSelectionScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag to control behavior of the filter. If
	/// GenerateSelectionScalars is on, then the output of the filter
	/// is the same as the input, except that scalars are generated.
	/// If off, the filter outputs the cells laying inside the loop, and
	/// does not generate scalars.
	/// </summary>
	public virtual void GenerateSelectionScalarsOff()
	{
		vtkSelectPolyData_GenerateSelectionScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_GenerateSelectionScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag to control behavior of the filter. If
	/// GenerateSelectionScalars is on, then the output of the filter
	/// is the same as the input, except that scalars are generated.
	/// If off, the filter outputs the cells laying inside the loop, and
	/// does not generate scalars.
	/// </summary>
	public virtual void GenerateSelectionScalarsOn()
	{
		vtkSelectPolyData_GenerateSelectionScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_GenerateUnselectedOutputOff_03(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's not been selected.
	/// </summary>
	public virtual void GenerateUnselectedOutputOff()
	{
		vtkSelectPolyData_GenerateUnselectedOutputOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_GenerateUnselectedOutputOn_04(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's not been selected.
	/// </summary>
	public virtual void GenerateUnselectedOutputOn()
	{
		vtkSelectPolyData_GenerateUnselectedOutputOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_GetClosestPoint_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the point used in SelectionModeToClosestPointRegion.
	/// </summary>
	public virtual double[] GetClosestPoint()
	{
		IntPtr intPtr = vtkSelectPolyData_GetClosestPoint_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_GetClosestPoint_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the point used in SelectionModeToClosestPointRegion.
	/// </summary>
	public virtual void GetClosestPoint(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkSelectPolyData_GetClosestPoint_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_GetClosestPoint_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the point used in SelectionModeToClosestPointRegion.
	/// </summary>
	public virtual void GetClosestPoint(IntPtr _arg)
	{
		vtkSelectPolyData_GetClosestPoint_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_GetEdgeSearchMode_08(HandleRef pThis);

	/// <summary>
	/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
	/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
	/// shortest path between loop points.
	/// If the algorithm fails with "Can't follow edge" error then switch to
	/// Dijkstra method.
	/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
	/// </summary>
	public virtual int GetEdgeSearchMode()
	{
		return vtkSelectPolyData_GetEdgeSearchMode_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_GetEdgeSearchModeAsString_09(HandleRef pThis);

	/// <summary>
	/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
	/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
	/// shortest path between loop points.
	/// If the algorithm fails with "Can't follow edge" error then switch to
	/// Dijkstra method.
	/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
	/// </summary>
	public string GetEdgeSearchModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkSelectPolyData_GetEdgeSearchModeAsString_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_GetEdgeSearchModeMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
	/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
	/// shortest path between loop points.
	/// If the algorithm fails with "Can't follow edge" error then switch to
	/// Dijkstra method.
	/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
	/// </summary>
	public virtual int GetEdgeSearchModeMaxValue()
	{
		return vtkSelectPolyData_GetEdgeSearchModeMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_GetEdgeSearchModeMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
	/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
	/// shortest path between loop points.
	/// If the algorithm fails with "Can't follow edge" error then switch to
	/// Dijkstra method.
	/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
	/// </summary>
	public virtual int GetEdgeSearchModeMinValue()
	{
		return vtkSelectPolyData_GetEdgeSearchModeMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_GetGenerateSelectionScalars_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag to control behavior of the filter. If
	/// GenerateSelectionScalars is on, then the output of the filter
	/// is the same as the input, except that scalars are generated.
	/// If off, the filter outputs the cells laying inside the loop, and
	/// does not generate scalars.
	/// </summary>
	public virtual int GetGenerateSelectionScalars()
	{
		return vtkSelectPolyData_GetGenerateSelectionScalars_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_GetGenerateUnselectedOutput_13(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's not been selected.
	/// </summary>
	public virtual int GetGenerateUnselectedOutput()
	{
		return vtkSelectPolyData_GetGenerateUnselectedOutput_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_GetInsideOut_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, the mesh within the loop is
	/// extracted. When on, the mesh outside the loop is extracted.
	/// </summary>
	public virtual int GetInsideOut()
	{
		return vtkSelectPolyData_GetInsideOut_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_GetLoop_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the array of point coordinates defining the loop. There must
	/// be at least three points used to define a loop.
	/// </summary>
	public virtual vtkPoints GetLoop()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectPolyData_GetLoop_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSelectPolyData_GetMTime_16(HandleRef pThis);

	/// <summary>
	/// Return the (mesh) edges of the selection region.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSelectPolyData_GetMTime_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectPolyData_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object with InsideOut turned off, and
	/// GenerateSelectionScalars turned off. The unselected output
	/// is not generated, and the inside mode is the smallest region.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSelectPolyData_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectPolyData_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	/// Instantiate object with InsideOut turned off, and
	/// GenerateSelectionScalars turned off. The unselected output
	/// is not generated, and the inside mode is the smallest region.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSelectPolyData_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_GetSelectionEdges_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the (mesh) edges of the selection region.
	/// </summary>
	public vtkPolyData GetSelectionEdges()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectPolyData_GetSelectionEdges_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_GetSelectionMode_20(HandleRef pThis);

	/// <summary>
	/// Control how inside/outside of loop is defined.
	/// </summary>
	public virtual int GetSelectionMode()
	{
		return vtkSelectPolyData_GetSelectionMode_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_GetSelectionModeAsString_21(HandleRef pThis);

	/// <summary>
	/// Control how inside/outside of loop is defined.
	/// </summary>
	public string GetSelectionModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkSelectPolyData_GetSelectionModeAsString_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_GetSelectionModeMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Control how inside/outside of loop is defined.
	/// </summary>
	public virtual int GetSelectionModeMaxValue()
	{
		return vtkSelectPolyData_GetSelectionModeMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_GetSelectionModeMinValue_23(HandleRef pThis);

	/// <summary>
	/// Control how inside/outside of loop is defined.
	/// </summary>
	public virtual int GetSelectionModeMinValue()
	{
		return vtkSelectPolyData_GetSelectionModeMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_GetSelectionScalarsArrayName_24(HandleRef pThis);

	/// <summary>
	/// Name of the Selection Scalars array. Default is "Selection".
	/// </summary>
	public virtual string GetSelectionScalarsArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkSelectPolyData_GetSelectionScalarsArrayName_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_GetUnselectedOutput_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return output that hasn't been selected (if GenreateUnselectedOutput is
	/// enabled).
	/// </summary>
	public vtkPolyData GetUnselectedOutput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectPolyData_GetUnselectedOutput_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_GetUnselectedOutputPort_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return output port that hasn't been selected (if GenreateUnselectedOutput is
	/// enabled).
	/// </summary>
	public vtkAlgorithmOutput GetUnselectedOutputPort()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectPolyData_GetUnselectedOutputPort_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_InsideOutOff_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, the mesh within the loop is
	/// extracted. When on, the mesh outside the loop is extracted.
	/// </summary>
	public virtual void InsideOutOff()
	{
		vtkSelectPolyData_InsideOutOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_InsideOutOn_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, the mesh within the loop is
	/// extracted. When on, the mesh outside the loop is extracted.
	/// </summary>
	public virtual void InsideOutOn()
	{
		vtkSelectPolyData_InsideOutOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_IsA_29(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object with InsideOut turned off, and
	/// GenerateSelectionScalars turned off. The unselected output
	/// is not generated, and the inside mode is the smallest region.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSelectPolyData_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectPolyData_IsTypeOf_30(string type);

	/// <summary>
	/// Instantiate object with InsideOut turned off, and
	/// GenerateSelectionScalars turned off. The unselected output
	/// is not generated, and the inside mode is the smallest region.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSelectPolyData_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with InsideOut turned off, and
	/// GenerateSelectionScalars turned off. The unselected output
	/// is not generated, and the inside mode is the smallest region.
	/// </summary>
	public new vtkSelectPolyData NewInstance()
	{
		vtkSelectPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectPolyData_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectPolyData_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with InsideOut turned off, and
	/// GenerateSelectionScalars turned off. The unselected output
	/// is not generated, and the inside mode is the smallest region.
	/// </summary>
	public new static vtkSelectPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkSelectPolyData vtkSelectPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectPolyData_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelectPolyData2 = (vtkSelectPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelectPolyData2.Register(null);
			}
		}
		return vtkSelectPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetClosestPoint_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the point used in SelectionModeToClosestPointRegion.
	/// </summary>
	public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkSelectPolyData_SetClosestPoint_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetClosestPoint_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the point used in SelectionModeToClosestPointRegion.
	/// </summary>
	public virtual void SetClosestPoint(IntPtr _arg)
	{
		vtkSelectPolyData_SetClosestPoint_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetEdgeSearchMode_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
	/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
	/// shortest path between loop points.
	/// If the algorithm fails with "Can't follow edge" error then switch to
	/// Dijkstra method.
	/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
	/// </summary>
	public virtual void SetEdgeSearchMode(int _arg)
	{
		vtkSelectPolyData_SetEdgeSearchMode_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetEdgeSearchModeToDijkstra_37(HandleRef pThis);

	/// <summary>
	/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
	/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
	/// shortest path between loop points.
	/// If the algorithm fails with "Can't follow edge" error then switch to
	/// Dijkstra method.
	/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
	/// </summary>
	public void SetEdgeSearchModeToDijkstra()
	{
		vtkSelectPolyData_SetEdgeSearchModeToDijkstra_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetEdgeSearchModeToGreedy_38(HandleRef pThis);

	/// <summary>
	/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
	/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
	/// shortest path between loop points.
	/// If the algorithm fails with "Can't follow edge" error then switch to
	/// Dijkstra method.
	/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
	/// </summary>
	public void SetEdgeSearchModeToGreedy()
	{
		vtkSelectPolyData_SetEdgeSearchModeToGreedy_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetGenerateSelectionScalars_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag to control behavior of the filter. If
	/// GenerateSelectionScalars is on, then the output of the filter
	/// is the same as the input, except that scalars are generated.
	/// If off, the filter outputs the cells laying inside the loop, and
	/// does not generate scalars.
	/// </summary>
	public virtual void SetGenerateSelectionScalars(int _arg)
	{
		vtkSelectPolyData_SetGenerateSelectionScalars_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetGenerateUnselectedOutput_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's not been selected.
	/// </summary>
	public virtual void SetGenerateUnselectedOutput(int _arg)
	{
		vtkSelectPolyData_SetGenerateUnselectedOutput_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetInsideOut_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, the mesh within the loop is
	/// extracted. When on, the mesh outside the loop is extracted.
	/// </summary>
	public virtual void SetInsideOut(int _arg)
	{
		vtkSelectPolyData_SetInsideOut_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetLoop_42(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the array of point coordinates defining the loop. There must
	/// be at least three points used to define a loop.
	/// </summary>
	public virtual void SetLoop(vtkPoints arg0)
	{
		vtkSelectPolyData_SetLoop_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetSelectionMode_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how inside/outside of loop is defined.
	/// </summary>
	public virtual void SetSelectionMode(int _arg)
	{
		vtkSelectPolyData_SetSelectionMode_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetSelectionModeToClosestPointRegion_44(HandleRef pThis);

	/// <summary>
	/// Control how inside/outside of loop is defined.
	/// </summary>
	public void SetSelectionModeToClosestPointRegion()
	{
		vtkSelectPolyData_SetSelectionModeToClosestPointRegion_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetSelectionModeToLargestRegion_45(HandleRef pThis);

	/// <summary>
	/// Control how inside/outside of loop is defined.
	/// </summary>
	public void SetSelectionModeToLargestRegion()
	{
		vtkSelectPolyData_SetSelectionModeToLargestRegion_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetSelectionModeToSmallestRegion_46(HandleRef pThis);

	/// <summary>
	/// Control how inside/outside of loop is defined.
	/// </summary>
	public void SetSelectionModeToSmallestRegion()
	{
		vtkSelectPolyData_SetSelectionModeToSmallestRegion_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectPolyData_SetSelectionScalarsArrayName_47(HandleRef pThis, string _arg);

	/// <summary>
	/// Name of the Selection Scalars array. Default is "Selection".
	/// </summary>
	public virtual void SetSelectionScalarsArrayName(string _arg)
	{
		vtkSelectPolyData_SetSelectionScalarsArrayName_47(GetCppThis(), _arg);
	}
}
