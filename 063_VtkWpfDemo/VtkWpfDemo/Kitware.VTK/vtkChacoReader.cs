using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkChacoReader
/// </summary>
/// <remarks>
///    Read a Chaco file and create a vtkUnstructuredGrid.
///
/// vtkChacoReader is an unstructured grid source object that reads Chaco
/// files.  The reader DOES NOT respond to piece requests. Chaco
/// is a graph partitioning package developed at Sandia National Laboratories
/// in the early 1990s.  (http://www.cs.sandia.gov/~bahendr/chaco.html)
///
/// Note that the Chaco "edges" become VTK "cells", and the Chaco
/// "vertices" become VTK "points".
/// </remarks>
public class vtkChacoReader : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkChacoReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkChacoReader()
	{
		MRClassNameKey = "class vtkChacoReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkChacoReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkChacoReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChacoReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChacoReader New()
	{
		vtkChacoReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChacoReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChacoReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkChacoReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkChacoReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_GenerateEdgeWeightArraysOff_01(HandleRef pThis);

	/// <summary>
	/// Each edge in the Chaco file connects two vertices.  The file may
	/// specify one or more weights for each edge.  (The weight for an
	/// edge from vertex A to vertex B equals the weight from B to A.)
	/// Indicate with the following parameter whether this reader should
	/// create a cell array for each weight for every edge.
	/// Default is OFF.
	/// </summary>
	public virtual void GenerateEdgeWeightArraysOff()
	{
		vtkChacoReader_GenerateEdgeWeightArraysOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_GenerateEdgeWeightArraysOn_02(HandleRef pThis);

	/// <summary>
	/// Each edge in the Chaco file connects two vertices.  The file may
	/// specify one or more weights for each edge.  (The weight for an
	/// edge from vertex A to vertex B equals the weight from B to A.)
	/// Indicate with the following parameter whether this reader should
	/// create a cell array for each weight for every edge.
	/// Default is OFF.
	/// </summary>
	public virtual void GenerateEdgeWeightArraysOn()
	{
		vtkChacoReader_GenerateEdgeWeightArraysOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_GenerateGlobalElementIdArrayOff_03(HandleRef pThis);

	/// <summary>
	/// Indicate whether this reader should create a cell array containing
	/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
	/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
	/// Default is ON.
	/// </summary>
	public virtual void GenerateGlobalElementIdArrayOff()
	{
		vtkChacoReader_GenerateGlobalElementIdArrayOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_GenerateGlobalElementIdArrayOn_04(HandleRef pThis);

	/// <summary>
	/// Indicate whether this reader should create a cell array containing
	/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
	/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
	/// Default is ON.
	/// </summary>
	public virtual void GenerateGlobalElementIdArrayOn()
	{
		vtkChacoReader_GenerateGlobalElementIdArrayOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_GenerateGlobalNodeIdArrayOff_05(HandleRef pThis);

	/// <summary>
	/// Indicate whether this reader should create a point array of global IDs for
	/// the points in the output vtkUnstructuredGrid.  These points are the vertices
	/// that were in the Chaco file.  Global point IDs start at "1" for the first
	/// vertex in BaseName.coords and go up from there.
	/// Default is ON.
	/// </summary>
	public virtual void GenerateGlobalNodeIdArrayOff()
	{
		vtkChacoReader_GenerateGlobalNodeIdArrayOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_GenerateGlobalNodeIdArrayOn_06(HandleRef pThis);

	/// <summary>
	/// Indicate whether this reader should create a point array of global IDs for
	/// the points in the output vtkUnstructuredGrid.  These points are the vertices
	/// that were in the Chaco file.  Global point IDs start at "1" for the first
	/// vertex in BaseName.coords and go up from there.
	/// Default is ON.
	/// </summary>
	public virtual void GenerateGlobalNodeIdArrayOn()
	{
		vtkChacoReader_GenerateGlobalNodeIdArrayOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_GenerateVertexWeightArraysOff_07(HandleRef pThis);

	/// <summary>
	/// Indicate whether this reader should create a point array for each
	/// vertex weight in the Chaco file.
	/// Default is OFF.
	/// </summary>
	public virtual void GenerateVertexWeightArraysOff()
	{
		vtkChacoReader_GenerateVertexWeightArraysOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_GenerateVertexWeightArraysOn_08(HandleRef pThis);

	/// <summary>
	/// Indicate whether this reader should create a point array for each
	/// vertex weight in the Chaco file.
	/// Default is OFF.
	/// </summary>
	public virtual void GenerateVertexWeightArraysOn()
	{
		vtkChacoReader_GenerateVertexWeightArraysOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChacoReader_GetBaseName_09(HandleRef pThis);

	/// <summary>
	/// Specify the base name of the Chaco files.  The reader will try to
	/// open BaseName.coords and BaseName.graph.
	/// </summary>
	public virtual string GetBaseName()
	{
		return Marshal.PtrToStringAnsi(vtkChacoReader_GetBaseName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_GetDimensionality_10(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by RequestInformation.
	/// </summary>
	public virtual int GetDimensionality()
	{
		return vtkChacoReader_GetDimensionality_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChacoReader_GetEdgeWeightArrayName_11(HandleRef pThis, int weight);

	/// <summary>
	/// This method returns the name of the selected Edge weight cell
	/// array.  If you did not turn on GenerateEdgeWeightArrays, or
	/// if the weight you requested is invalid, it returns nullptr.
	/// Weights begin at one and go up to NumberOfEdgeWeights.
	/// This is a pointer to our copy of the name, so don't "delete" it.
	/// </summary>
	public string GetEdgeWeightArrayName(int weight)
	{
		return Marshal.PtrToStringAnsi(vtkChacoReader_GetEdgeWeightArrayName_11(GetCppThis(), weight));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_GetGenerateEdgeWeightArrays_12(HandleRef pThis);

	/// <summary>
	/// Each edge in the Chaco file connects two vertices.  The file may
	/// specify one or more weights for each edge.  (The weight for an
	/// edge from vertex A to vertex B equals the weight from B to A.)
	/// Indicate with the following parameter whether this reader should
	/// create a cell array for each weight for every edge.
	/// Default is OFF.
	/// </summary>
	public virtual int GetGenerateEdgeWeightArrays()
	{
		return vtkChacoReader_GetGenerateEdgeWeightArrays_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_GetGenerateGlobalElementIdArray_13(HandleRef pThis);

	/// <summary>
	/// Indicate whether this reader should create a cell array containing
	/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
	/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
	/// Default is ON.
	/// </summary>
	public virtual int GetGenerateGlobalElementIdArray()
	{
		return vtkChacoReader_GetGenerateGlobalElementIdArray_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_GetGenerateGlobalNodeIdArray_14(HandleRef pThis);

	/// <summary>
	/// Indicate whether this reader should create a point array of global IDs for
	/// the points in the output vtkUnstructuredGrid.  These points are the vertices
	/// that were in the Chaco file.  Global point IDs start at "1" for the first
	/// vertex in BaseName.coords and go up from there.
	/// Default is ON.
	/// </summary>
	public virtual int GetGenerateGlobalNodeIdArray()
	{
		return vtkChacoReader_GetGenerateGlobalNodeIdArray_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_GetGenerateVertexWeightArrays_15(HandleRef pThis);

	/// <summary>
	/// Indicate whether this reader should create a point array for each
	/// vertex weight in the Chaco file.
	/// Default is OFF.
	/// </summary>
	public virtual int GetGenerateVertexWeightArrays()
	{
		return vtkChacoReader_GetGenerateVertexWeightArrays_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChacoReader_GetGlobalElementIdArrayName_16();

	/// <summary>
	/// Indicate whether this reader should create a cell array containing
	/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
	/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
	/// Default is ON.
	/// </summary>
	public static string GetGlobalElementIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkChacoReader_GetGlobalElementIdArrayName_16());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChacoReader_GetGlobalNodeIdArrayName_17();

	/// <summary>
	/// Indicate whether this reader should create a point array of global IDs for
	/// the points in the output vtkUnstructuredGrid.  These points are the vertices
	/// that were in the Chaco file.  Global point IDs start at "1" for the first
	/// vertex in BaseName.coords and go up from there.
	/// Default is ON.
	/// </summary>
	public static string GetGlobalNodeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkChacoReader_GetGlobalNodeIdArrayName_17());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_GetNumberOfCellWeightArrays_18(HandleRef pThis);

	/// <summary>
	/// After this filter executes, this method returns the number of
	/// cell arrays that were created to hold the edge weights.  It
	/// is equal to NumberOfEdgeWeights if GenerateEdgeWeightArrays was ON.
	/// </summary>
	public virtual int GetNumberOfCellWeightArrays()
	{
		return vtkChacoReader_GetNumberOfCellWeightArrays_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_GetNumberOfEdgeWeights_19(HandleRef pThis);

	/// <summary>
	/// Returns the number of weights per edge in the Chaco file, whether or
	/// not GenerateEdgeWeightArrays is ON.
	/// </summary>
	public virtual int GetNumberOfEdgeWeights()
	{
		return vtkChacoReader_GetNumberOfEdgeWeights_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChacoReader_GetNumberOfEdges_20(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by RequestInformation.
	/// </summary>
	public virtual long GetNumberOfEdges()
	{
		return vtkChacoReader_GetNumberOfEdges_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChacoReader_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkChacoReader_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChacoReader_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkChacoReader_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_GetNumberOfPointWeightArrays_23(HandleRef pThis);

	/// <summary>
	/// After this filter executes, this method returns the number of
	/// point arrays that were created to hold the vertex weights.  It
	/// is equal to NumberOfVertexWeights if GenerateVertexWeightArrays was ON.
	/// </summary>
	public virtual int GetNumberOfPointWeightArrays()
	{
		return vtkChacoReader_GetNumberOfPointWeightArrays_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_GetNumberOfVertexWeights_24(HandleRef pThis);

	/// <summary>
	/// Returns the number of weights per vertex in the Chaco file, whether or
	/// not GenerateVertexWeightArrays is ON.
	/// </summary>
	public virtual int GetNumberOfVertexWeights()
	{
		return vtkChacoReader_GetNumberOfVertexWeights_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChacoReader_GetNumberOfVertices_25(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by RequestInformation.
	/// </summary>
	public virtual long GetNumberOfVertices()
	{
		return vtkChacoReader_GetNumberOfVertices_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChacoReader_GetVertexWeightArrayName_26(HandleRef pThis, int weight);

	/// <summary>
	/// This method returns the name of the selected Vertex weight point
	/// array.  If you did not turn on GenerateVertexWeightArrays, or
	/// if the weight you requested is invalid, it returns nullptr.
	/// Weights begin at one and go up to NumberOfVertexWeights.
	/// This is a pointer to our copy of the name, so don't "delete" it.
	/// </summary>
	public string GetVertexWeightArrayName(int weight)
	{
		return Marshal.PtrToStringAnsi(vtkChacoReader_GetVertexWeightArrayName_26(GetCppThis(), weight));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkChacoReader_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChacoReader_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkChacoReader_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChacoReader_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkChacoReader NewInstance()
	{
		vtkChacoReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChacoReader_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChacoReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChacoReader_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChacoReader SafeDownCast(vtkObjectBase o)
	{
		vtkChacoReader vtkChacoReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChacoReader_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChacoReader2 = (vtkChacoReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChacoReader2.Register(null);
			}
		}
		return vtkChacoReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_SetBaseName_32(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the base name of the Chaco files.  The reader will try to
	/// open BaseName.coords and BaseName.graph.
	/// </summary>
	public virtual void SetBaseName(string _arg)
	{
		vtkChacoReader_SetBaseName_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_SetGenerateEdgeWeightArrays_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Each edge in the Chaco file connects two vertices.  The file may
	/// specify one or more weights for each edge.  (The weight for an
	/// edge from vertex A to vertex B equals the weight from B to A.)
	/// Indicate with the following parameter whether this reader should
	/// create a cell array for each weight for every edge.
	/// Default is OFF.
	/// </summary>
	public virtual void SetGenerateEdgeWeightArrays(int _arg)
	{
		vtkChacoReader_SetGenerateEdgeWeightArrays_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_SetGenerateGlobalElementIdArray_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether this reader should create a cell array containing
	/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
	/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
	/// Default is ON.
	/// </summary>
	public virtual void SetGenerateGlobalElementIdArray(int _arg)
	{
		vtkChacoReader_SetGenerateGlobalElementIdArray_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_SetGenerateGlobalNodeIdArray_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether this reader should create a point array of global IDs for
	/// the points in the output vtkUnstructuredGrid.  These points are the vertices
	/// that were in the Chaco file.  Global point IDs start at "1" for the first
	/// vertex in BaseName.coords and go up from there.
	/// Default is ON.
	/// </summary>
	public virtual void SetGenerateGlobalNodeIdArray(int _arg)
	{
		vtkChacoReader_SetGenerateGlobalNodeIdArray_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChacoReader_SetGenerateVertexWeightArrays_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether this reader should create a point array for each
	/// vertex weight in the Chaco file.
	/// Default is OFF.
	/// </summary>
	public virtual void SetGenerateVertexWeightArrays(int _arg)
	{
		vtkChacoReader_SetGenerateVertexWeightArrays_36(GetCppThis(), _arg);
	}
}
