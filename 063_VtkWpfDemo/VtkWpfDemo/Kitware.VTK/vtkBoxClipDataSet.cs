using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBoxClipDataSet
/// </summary>
/// <remarks>
///    clip an unstructured grid
///
///
/// Clipping means that is actually 'cuts' through the cells of the dataset,
/// returning tetrahedral cells inside of the box.
/// The output of this filter is an unstructured grid.
///
/// This filter can be configured to compute a second output. The
/// second output is the part of the cell that is clipped away. Set the
/// GenerateClippedData boolean on if you wish to access this output data.
///
/// The vtkBoxClipDataSet will triangulate all types of 3D cells (i.e, create tetrahedra).
/// This is necessary to preserve compatibility across face neighbors.
///
/// To use this filter,you can decide if you will be clipping with a box or a hexahedral box.
/// 1) Set orientation
///    if(SetOrientation(0)): box (parallel with coordinate axis)
///       SetBoxClip(xmin,xmax,ymin,ymax,zmin,zmax)
///    if(SetOrientation(1)): hexahedral box (Default)
///       SetBoxClip(n[0],o[0],n[1],o[1],n[2],o[2],n[3],o[3],n[4],o[4],n[5],o[5])
///       PlaneNormal[] normal of each plane
///       PlanePoint[] point on the plane
/// 2) Apply the GenerateClipScalarsOn()
/// 3) Execute clipping  Update();
/// </remarks>
public class vtkBoxClipDataSet : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBoxClipDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBoxClipDataSet()
	{
		MRClassNameKey = "class vtkBoxClipDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxClipDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBoxClipDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxClipDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Constructor of the clipping box. The initial box is (0,1,0,1,0,1).
	/// The hexahedral box and the parallel box parameters are set to match this
	/// box.
	/// </summary>
	public new static vtkBoxClipDataSet New()
	{
		vtkBoxClipDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxClipDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Constructor of the clipping box. The initial box is (0,1,0,1,0,1).
	/// The hexahedral box and the parallel box parameters are set to match this
	/// box.
	/// </summary>
	public vtkBoxClipDataSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBoxClipDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_CellGrid_01(HandleRef pThis, long typeobj, long npts, IntPtr cellIds, HandleRef newCellArray);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void CellGrid(long typeobj, long npts, IntPtr cellIds, vtkCellArray newCellArray)
	{
		vtkBoxClipDataSet_CellGrid_01(GetCppThis(), typeobj, npts, cellIds, newCellArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_ClipBox_02(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void ClipBox(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
	{
		vtkBoxClipDataSet_ClipBox_02(GetCppThis(), newPoints?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), tets?.GetCppThis() ?? default(HandleRef), inPD?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), inCD?.GetCppThis() ?? default(HandleRef), cellId, outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_ClipBox0D_03(HandleRef pThis, HandleRef cell, HandleRef locator, HandleRef verts, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void ClipBox0D(vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
	{
		vtkBoxClipDataSet_ClipBox0D_03(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), inPD?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), inCD?.GetCppThis() ?? default(HandleRef), cellId, outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_ClipBox1D_04(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef lines, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void ClipBox1D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
	{
		vtkBoxClipDataSet_ClipBox1D_04(GetCppThis(), newPoints?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), inPD?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), inCD?.GetCppThis() ?? default(HandleRef), cellId, outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_ClipBox2D_05(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void ClipBox2D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
	{
		vtkBoxClipDataSet_ClipBox2D_05(GetCppThis(), newPoints?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), tets?.GetCppThis() ?? default(HandleRef), inPD?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), inCD?.GetCppThis() ?? default(HandleRef), cellId, outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_ClipHexahedron_06(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void ClipHexahedron(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
	{
		vtkBoxClipDataSet_ClipHexahedron_06(GetCppThis(), newPoints?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), tets?.GetCppThis() ?? default(HandleRef), inPD?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), inCD?.GetCppThis() ?? default(HandleRef), cellId, outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_ClipHexahedron0D_07(HandleRef pThis, HandleRef cell, HandleRef locator, HandleRef verts, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void ClipHexahedron0D(vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
	{
		vtkBoxClipDataSet_ClipHexahedron0D_07(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), inPD?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), inCD?.GetCppThis() ?? default(HandleRef), cellId, outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_ClipHexahedron1D_08(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef lines, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void ClipHexahedron1D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
	{
		vtkBoxClipDataSet_ClipHexahedron1D_08(GetCppThis(), newPoints?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), inPD?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), inCD?.GetCppThis() ?? default(HandleRef), cellId, outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_ClipHexahedron2D_09(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void ClipHexahedron2D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
	{
		vtkBoxClipDataSet_ClipHexahedron2D_09(GetCppThis(), newPoints?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), tets?.GetCppThis() ?? default(HandleRef), inPD?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), inCD?.GetCppThis() ?? default(HandleRef), cellId, outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_CreateDefaultLocator_10(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified. The
	/// locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkBoxClipDataSet_CreateDefaultLocator_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_CreateTetra_11(HandleRef pThis, long npts, IntPtr cellIds, HandleRef newCellArray);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void CreateTetra(long npts, IntPtr cellIds, vtkCellArray newCellArray)
	{
		vtkBoxClipDataSet_CreateTetra_11(GetCppThis(), npts, cellIds, newCellArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_GenerateClipScalarsOff_12(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated, and not the input scalar data.
	/// </summary>
	public virtual void GenerateClipScalarsOff()
	{
		vtkBoxClipDataSet_GenerateClipScalarsOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_GenerateClipScalarsOn_13(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated, and not the input scalar data.
	/// </summary>
	public virtual void GenerateClipScalarsOn()
	{
		vtkBoxClipDataSet_GenerateClipScalarsOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_GenerateClippedOutputOff_14(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual void GenerateClippedOutputOff()
	{
		vtkBoxClipDataSet_GenerateClippedOutputOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_GenerateClippedOutputOn_15(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual void GenerateClippedOutputOn()
	{
		vtkBoxClipDataSet_GenerateClippedOutputOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxClipDataSet_GetClippedOutput_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the Clipped output.
	/// </summary>
	public vtkUnstructuredGrid GetClippedOutput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxClipDataSet_GetClippedOutput_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxClipDataSet_GetGenerateClipScalars_17(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated, and not the input scalar data.
	/// </summary>
	public virtual int GetGenerateClipScalars()
	{
		return vtkBoxClipDataSet_GetGenerateClipScalars_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxClipDataSet_GetGenerateClippedOutput_18(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual int GetGenerateClippedOutput()
	{
		return vtkBoxClipDataSet_GetGenerateClippedOutput_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxClipDataSet_GetLocator_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a spatial locator for merging points. By default, an
	/// instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxClipDataSet_GetLocator_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkBoxClipDataSet_GetMTime_20(HandleRef pThis);

	/// <summary>
	/// Return the mtime also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkBoxClipDataSet_GetMTime_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxClipDataSet_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBoxClipDataSet_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxClipDataSet_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBoxClipDataSet_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxClipDataSet_GetNumberOfOutputs_23(HandleRef pThis);

	/// <summary>
	/// Return the Clipped output.
	/// </summary>
	public virtual int GetNumberOfOutputs()
	{
		return vtkBoxClipDataSet_GetNumberOfOutputs_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkBoxClipDataSet_GetOrientation_24(HandleRef pThis);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public virtual uint GetOrientation()
	{
		return vtkBoxClipDataSet_GetOrientation_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_InterpolateEdge_25(HandleRef attributes, long toId, long fromId1, long fromId2, double t);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public static void InterpolateEdge(vtkDataSetAttributes attributes, long toId, long fromId1, long fromId2, double t)
	{
		vtkBoxClipDataSet_InterpolateEdge_25(attributes?.GetCppThis() ?? default(HandleRef), toId, fromId1, fromId2, t);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxClipDataSet_IsA_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBoxClipDataSet_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxClipDataSet_IsTypeOf_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBoxClipDataSet_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_MinEdgeF_28(HandleRef pThis, IntPtr id_v, IntPtr cellIds, IntPtr edgF);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void MinEdgeF(IntPtr id_v, IntPtr cellIds, IntPtr edgF)
	{
		vtkBoxClipDataSet_MinEdgeF_28(GetCppThis(), id_v, cellIds, edgF);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxClipDataSet_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBoxClipDataSet NewInstance()
	{
		vtkBoxClipDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxClipDataSet_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_PyramidToTetra_31(HandleRef pThis, IntPtr pyramId, IntPtr cellIds, HandleRef newCellArray);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void PyramidToTetra(IntPtr pyramId, IntPtr cellIds, vtkCellArray newCellArray)
	{
		vtkBoxClipDataSet_PyramidToTetra_31(GetCppThis(), pyramId, cellIds, newCellArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxClipDataSet_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBoxClipDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkBoxClipDataSet vtkBoxClipDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxClipDataSet_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBoxClipDataSet2 = (vtkBoxClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBoxClipDataSet2.Register(null);
			}
		}
		return vtkBoxClipDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_SetBoxClip_33(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Specify the Box with which to perform the clipping.
	/// If the box is not parallel to axis, you need to especify
	/// normal vector of each plane and a point on the plane.
	/// </summary>
	public void SetBoxClip(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkBoxClipDataSet_SetBoxClip_33(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_SetBoxClip_34(HandleRef pThis, IntPtr n0, IntPtr o0, IntPtr n1, IntPtr o1, IntPtr n2, IntPtr o2, IntPtr n3, IntPtr o3, IntPtr n4, IntPtr o4, IntPtr n5, IntPtr o5);

	/// <summary>
	/// Specify the Box with which to perform the clipping.
	/// If the box is not parallel to axis, you need to especify
	/// normal vector of each plane and a point on the plane.
	/// </summary>
	public void SetBoxClip(IntPtr n0, IntPtr o0, IntPtr n1, IntPtr o1, IntPtr n2, IntPtr o2, IntPtr n3, IntPtr o3, IntPtr n4, IntPtr o4, IntPtr n5, IntPtr o5)
	{
		vtkBoxClipDataSet_SetBoxClip_34(GetCppThis(), n0, o0, n1, o1, n2, o2, n3, o3, n4, o4, n5, o5);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_SetGenerateClipScalars_35(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated, and not the input scalar data.
	/// </summary>
	public virtual void SetGenerateClipScalars(int _arg)
	{
		vtkBoxClipDataSet_SetGenerateClipScalars_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_SetGenerateClippedOutput_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual void SetGenerateClippedOutput(int _arg)
	{
		vtkBoxClipDataSet_SetGenerateClippedOutput_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_SetLocator_37(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a spatial locator for merging points. By default, an
	/// instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkBoxClipDataSet_SetLocator_37(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_SetOrientation_38(HandleRef pThis, uint _arg);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public virtual void SetOrientation(uint _arg)
	{
		vtkBoxClipDataSet_SetOrientation_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxClipDataSet_WedgeToTetra_39(HandleRef pThis, IntPtr wedgeId, IntPtr cellIds, HandleRef newCellArray);

	/// <summary>
	/// Tells if clipping happens with a box parallel with coordinate axis
	/// (0) or with an hexahedral box (1). Initial value is 1.
	/// </summary>
	public void WedgeToTetra(IntPtr wedgeId, IntPtr cellIds, vtkCellArray newCellArray)
	{
		vtkBoxClipDataSet_WedgeToTetra_39(GetCppThis(), wedgeId, cellIds, newCellArray?.GetCppThis() ?? default(HandleRef));
	}
}
