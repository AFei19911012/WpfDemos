using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDijkstraGraphGeodesicPath
/// </summary>
/// <remarks>
///    Dijkstra algorithm to compute the graph geodesic.
///
/// Takes as input a polygonal mesh and performs a single source shortest
/// path calculation. Dijkstra's algorithm is used. The implementation is
/// similar to the one described in Introduction to Algorithms (Second Edition)
/// by Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, and
/// Cliff Stein, published by MIT Press and McGraw-Hill. Some minor
/// enhancement are added though. All vertices are not pushed on the heap
/// at start, instead a front set is maintained. The heap is implemented as
/// a binary heap. The output of the filter is a set of lines describing
/// the shortest path from StartVertex to EndVertex. If a path cannot be found
/// the output will have no lines or points.
///
/// @warning
/// The input polydata must have only triangle cells.
///
/// @par Thanks:
/// The class was contributed by Rasmus Paulsen.
/// www.imm.dtu.dk/~rrp/VTK . Also thanks to Alexandre Gouaillard and Shoaib
/// Ghias for bug fixes and enhancements.
/// </remarks>
public class vtkDijkstraGraphGeodesicPath : vtkGraphGeodesicPath
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDijkstraGraphGeodesicPath";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDijkstraGraphGeodesicPath()
	{
		MRClassNameKey = "class vtkDijkstraGraphGeodesicPath";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDijkstraGraphGeodesicPath"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDijkstraGraphGeodesicPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraGraphGeodesicPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class
	/// </summary>
	public new static vtkDijkstraGraphGeodesicPath New()
	{
		vtkDijkstraGraphGeodesicPath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraGraphGeodesicPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDijkstraGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class
	/// </summary>
	public vtkDijkstraGraphGeodesicPath()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDijkstraGraphGeodesicPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDijkstraGraphGeodesicPath_GetCumulativeWeights_01(HandleRef pThis, HandleRef weights);

	/// <summary>
	/// Fill the array with the cumulative weights.
	/// </summary>
	public virtual void GetCumulativeWeights(vtkDoubleArray weights)
	{
		vtkDijkstraGraphGeodesicPath_GetCumulativeWeights_01(GetCppThis(), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraGraphGeodesicPath_GetIdList_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The vertex ids (of the input polydata) on the shortest path
	/// </summary>
	public virtual vtkIdList GetIdList()
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraGraphGeodesicPath_GetIdList_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdList2 = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdList2.Register(null);
			}
		}
		return vtkIdList2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDijkstraGraphGeodesicPath_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDijkstraGraphGeodesicPath_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDijkstraGraphGeodesicPath_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDijkstraGraphGeodesicPath_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDijkstraGraphGeodesicPath_GetRepelPathFromVertices_05(HandleRef pThis);

	/// <summary>
	/// Use the input point to repel the path by assigning high costs.
	/// </summary>
	public virtual int GetRepelPathFromVertices()
	{
		return vtkDijkstraGraphGeodesicPath_GetRepelPathFromVertices_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraGraphGeodesicPath_GetRepelVertices_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify vtkPoints to use to repel the path from.
	/// </summary>
	public virtual vtkPoints GetRepelVertices()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraGraphGeodesicPath_GetRepelVertices_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDijkstraGraphGeodesicPath_GetStopWhenEndReached_07(HandleRef pThis);

	/// <summary>
	/// Stop when the end vertex is reached
	/// or calculate shortest path to all vertices
	/// </summary>
	public virtual int GetStopWhenEndReached()
	{
		return vtkDijkstraGraphGeodesicPath_GetStopWhenEndReached_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDijkstraGraphGeodesicPath_GetUseScalarWeights_08(HandleRef pThis);

	/// <summary>
	/// Use scalar values in the edge weight (experimental)
	/// </summary>
	public virtual int GetUseScalarWeights()
	{
		return vtkDijkstraGraphGeodesicPath_GetUseScalarWeights_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDijkstraGraphGeodesicPath_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDijkstraGraphGeodesicPath_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDijkstraGraphGeodesicPath_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDijkstraGraphGeodesicPath_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraGraphGeodesicPath_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new vtkDijkstraGraphGeodesicPath NewInstance()
	{
		vtkDijkstraGraphGeodesicPath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraGraphGeodesicPath_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDijkstraGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOff_13(HandleRef pThis);

	/// <summary>
	/// Use the input point to repel the path by assigning high costs.
	/// </summary>
	public virtual void RepelPathFromVerticesOff()
	{
		vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOn_14(HandleRef pThis);

	/// <summary>
	/// Use the input point to repel the path by assigning high costs.
	/// </summary>
	public virtual void RepelPathFromVerticesOn()
	{
		vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDijkstraGraphGeodesicPath_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for printing and determining type information.
	/// </summary>
	public new static vtkDijkstraGraphGeodesicPath SafeDownCast(vtkObjectBase o)
	{
		vtkDijkstraGraphGeodesicPath vtkDijkstraGraphGeodesicPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDijkstraGraphGeodesicPath_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDijkstraGraphGeodesicPath2 = (vtkDijkstraGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDijkstraGraphGeodesicPath2.Register(null);
			}
		}
		return vtkDijkstraGraphGeodesicPath2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_SetRepelPathFromVertices_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Use the input point to repel the path by assigning high costs.
	/// </summary>
	public virtual void SetRepelPathFromVertices(int _arg)
	{
		vtkDijkstraGraphGeodesicPath_SetRepelPathFromVertices_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_SetRepelVertices_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify vtkPoints to use to repel the path from.
	/// </summary>
	public virtual void SetRepelVertices(vtkPoints arg0)
	{
		vtkDijkstraGraphGeodesicPath_SetRepelVertices_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_SetStopWhenEndReached_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Stop when the end vertex is reached
	/// or calculate shortest path to all vertices
	/// </summary>
	public virtual void SetStopWhenEndReached(int _arg)
	{
		vtkDijkstraGraphGeodesicPath_SetStopWhenEndReached_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_SetUseScalarWeights_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Use scalar values in the edge weight (experimental)
	/// </summary>
	public virtual void SetUseScalarWeights(int _arg)
	{
		vtkDijkstraGraphGeodesicPath_SetUseScalarWeights_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOff_20(HandleRef pThis);

	/// <summary>
	/// Stop when the end vertex is reached
	/// or calculate shortest path to all vertices
	/// </summary>
	public virtual void StopWhenEndReachedOff()
	{
		vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOn_21(HandleRef pThis);

	/// <summary>
	/// Stop when the end vertex is reached
	/// or calculate shortest path to all vertices
	/// </summary>
	public virtual void StopWhenEndReachedOn()
	{
		vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_UseScalarWeightsOff_22(HandleRef pThis);

	/// <summary>
	/// Use scalar values in the edge weight (experimental)
	/// </summary>
	public virtual void UseScalarWeightsOff()
	{
		vtkDijkstraGraphGeodesicPath_UseScalarWeightsOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDijkstraGraphGeodesicPath_UseScalarWeightsOn_23(HandleRef pThis);

	/// <summary>
	/// Use scalar values in the edge weight (experimental)
	/// </summary>
	public virtual void UseScalarWeightsOn()
	{
		vtkDijkstraGraphGeodesicPath_UseScalarWeightsOn_23(GetCppThis());
	}
}
