using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataSetToDataObjectFilter
/// </summary>
/// <remarks>
///    map dataset into data object (i.e., a field)
///
/// vtkDataSetToDataObjectFilter is an class that transforms a dataset into
/// data object (i.e., a field). The field will have labeled data arrays
/// corresponding to the topology, geometry, field data, and point and cell
/// attribute data.
///
/// You can control what portions of the dataset are converted into the
/// output data object's field data. The instance variables Geometry,
/// Topology, FieldData, PointData, and CellData are flags that control
/// whether the dataset's geometry (e.g., points, spacing, origin);
/// topology (e.g., cell connectivity, dimensions); the field data
/// associated with the dataset's superclass data object; the dataset's
/// point data attributes; and the dataset's cell data attributes. (Note:
/// the data attributes include scalars, vectors, tensors, normals, texture
/// coordinates, and field data.)
///
/// The names used to create the field data are as follows. For vtkPolyData,
/// "Points", "Verts", "Lines", "Polys", and "Strips". For vtkUnstructuredGrid,
/// "Cells" and "CellTypes". For vtkStructuredPoints, "Dimensions", "Spacing",
/// and "Origin". For vtkStructuredGrid, "Points" and "Dimensions". For
/// vtkRectilinearGrid, "XCoordinates", "YCoordinates", and "ZCoordinates".
/// for point attribute data, "PointScalars", "PointVectors", etc. For cell
/// attribute data, "CellScalars", "CellVectors", etc. Field data arrays retain
/// their original name.
///
/// </remarks>
/// <seealso>
///
/// vtkDataObject vtkFieldData vtkDataObjectToDataSetFilter
/// </seealso>
public class vtkDataSetToDataObjectFilter : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetToDataObjectFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataSetToDataObjectFilter()
	{
		MRClassNameKey = "class vtkDataSetToDataObjectFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetToDataObjectFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataSetToDataObjectFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetToDataObjectFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object to transform all data into a data object.
	/// </summary>
	public new static vtkDataSetToDataObjectFilter New()
	{
		vtkDataSetToDataObjectFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetToDataObjectFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetToDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object to transform all data into a data object.
	/// </summary>
	public vtkDataSetToDataObjectFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataSetToDataObjectFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataSetToDataObjectFilter_CellDataOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset cell data to a data object.
	/// </summary>
	public virtual void CellDataOff()
	{
		vtkDataSetToDataObjectFilter_CellDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_CellDataOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset cell data to a data object.
	/// </summary>
	public virtual void CellDataOn()
	{
		vtkDataSetToDataObjectFilter_CellDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_FieldDataOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset field data to a data object.
	/// </summary>
	public virtual void FieldDataOff()
	{
		vtkDataSetToDataObjectFilter_FieldDataOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_FieldDataOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset field data to a data object.
	/// </summary>
	public virtual void FieldDataOn()
	{
		vtkDataSetToDataObjectFilter_FieldDataOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_GeometryOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset geometry to a data object.
	/// </summary>
	public virtual void GeometryOff()
	{
		vtkDataSetToDataObjectFilter_GeometryOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_GeometryOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset geometry to a data object.
	/// </summary>
	public virtual void GeometryOn()
	{
		vtkDataSetToDataObjectFilter_GeometryOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetToDataObjectFilter_GetCellData_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset cell data to a data object.
	/// </summary>
	public virtual int GetCellData()
	{
		return vtkDataSetToDataObjectFilter_GetCellData_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetToDataObjectFilter_GetFieldData_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset field data to a data object.
	/// </summary>
	public virtual int GetFieldData()
	{
		return vtkDataSetToDataObjectFilter_GetFieldData_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetToDataObjectFilter_GetGeometry_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset geometry to a data object.
	/// </summary>
	public virtual int GetGeometry()
	{
		return vtkDataSetToDataObjectFilter_GetGeometry_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetToDataObjectFilter_GetLegacyTopology_10(HandleRef pThis);

	/// <summary>
	/// If LegacyTopology and Topology are both true, print out the legacy topology
	/// arrays. Default is true.
	/// </summary>
	public virtual int GetLegacyTopology()
	{
		return vtkDataSetToDataObjectFilter_GetLegacyTopology_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetToDataObjectFilter_GetModernTopology_11(HandleRef pThis);

	/// <summary>
	/// If ModernTopology and Topology are both true, print out the modern topology
	/// arrays. Default is true.
	/// </summary>
	public virtual int GetModernTopology()
	{
		return vtkDataSetToDataObjectFilter_GetModernTopology_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetToDataObjectFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataSetToDataObjectFilter_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetToDataObjectFilter_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataSetToDataObjectFilter_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetToDataObjectFilter_GetPointData_14(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset point data to a data object.
	/// </summary>
	public virtual int GetPointData()
	{
		return vtkDataSetToDataObjectFilter_GetPointData_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetToDataObjectFilter_GetTopology_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset topology to a data object.
	/// </summary>
	public virtual int GetTopology()
	{
		return vtkDataSetToDataObjectFilter_GetTopology_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetToDataObjectFilter_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataSetToDataObjectFilter_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetToDataObjectFilter_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataSetToDataObjectFilter_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_LegacyTopologyOff_18(HandleRef pThis);

	/// <summary>
	/// If LegacyTopology and Topology are both true, print out the legacy topology
	/// arrays. Default is true.
	/// </summary>
	public virtual void LegacyTopologyOff()
	{
		vtkDataSetToDataObjectFilter_LegacyTopologyOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_LegacyTopologyOn_19(HandleRef pThis);

	/// <summary>
	/// If LegacyTopology and Topology are both true, print out the legacy topology
	/// arrays. Default is true.
	/// </summary>
	public virtual void LegacyTopologyOn()
	{
		vtkDataSetToDataObjectFilter_LegacyTopologyOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_ModernTopologyOff_20(HandleRef pThis);

	/// <summary>
	/// If ModernTopology and Topology are both true, print out the modern topology
	/// arrays. Default is true.
	/// </summary>
	public virtual void ModernTopologyOff()
	{
		vtkDataSetToDataObjectFilter_ModernTopologyOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_ModernTopologyOn_21(HandleRef pThis);

	/// <summary>
	/// If ModernTopology and Topology are both true, print out the modern topology
	/// arrays. Default is true.
	/// </summary>
	public virtual void ModernTopologyOn()
	{
		vtkDataSetToDataObjectFilter_ModernTopologyOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetToDataObjectFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataSetToDataObjectFilter NewInstance()
	{
		vtkDataSetToDataObjectFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetToDataObjectFilter_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetToDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_PointDataOff_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset point data to a data object.
	/// </summary>
	public virtual void PointDataOff()
	{
		vtkDataSetToDataObjectFilter_PointDataOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_PointDataOn_25(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset point data to a data object.
	/// </summary>
	public virtual void PointDataOn()
	{
		vtkDataSetToDataObjectFilter_PointDataOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetToDataObjectFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataSetToDataObjectFilter SafeDownCast(vtkObjectBase o)
	{
		vtkDataSetToDataObjectFilter vtkDataSetToDataObjectFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetToDataObjectFilter_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetToDataObjectFilter2 = (vtkDataSetToDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetToDataObjectFilter2.Register(null);
			}
		}
		return vtkDataSetToDataObjectFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_SetCellData_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the conversion of dataset cell data to a data object.
	/// </summary>
	public virtual void SetCellData(int _arg)
	{
		vtkDataSetToDataObjectFilter_SetCellData_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_SetFieldData_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the conversion of dataset field data to a data object.
	/// </summary>
	public virtual void SetFieldData(int _arg)
	{
		vtkDataSetToDataObjectFilter_SetFieldData_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_SetGeometry_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the conversion of dataset geometry to a data object.
	/// </summary>
	public virtual void SetGeometry(int _arg)
	{
		vtkDataSetToDataObjectFilter_SetGeometry_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_SetLegacyTopology_30(HandleRef pThis, int _arg);

	/// <summary>
	/// If LegacyTopology and Topology are both true, print out the legacy topology
	/// arrays. Default is true.
	/// </summary>
	public virtual void SetLegacyTopology(int _arg)
	{
		vtkDataSetToDataObjectFilter_SetLegacyTopology_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_SetModernTopology_31(HandleRef pThis, int _arg);

	/// <summary>
	/// If ModernTopology and Topology are both true, print out the modern topology
	/// arrays. Default is true.
	/// </summary>
	public virtual void SetModernTopology(int _arg)
	{
		vtkDataSetToDataObjectFilter_SetModernTopology_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_SetPointData_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the conversion of dataset point data to a data object.
	/// </summary>
	public virtual void SetPointData(int _arg)
	{
		vtkDataSetToDataObjectFilter_SetPointData_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_SetTopology_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the conversion of dataset topology to a data object.
	/// </summary>
	public virtual void SetTopology(int _arg)
	{
		vtkDataSetToDataObjectFilter_SetTopology_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_TopologyOff_34(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset topology to a data object.
	/// </summary>
	public virtual void TopologyOff()
	{
		vtkDataSetToDataObjectFilter_TopologyOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetToDataObjectFilter_TopologyOn_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off the conversion of dataset topology to a data object.
	/// </summary>
	public virtual void TopologyOn()
	{
		vtkDataSetToDataObjectFilter_TopologyOn_35(GetCppThis());
	}
}
