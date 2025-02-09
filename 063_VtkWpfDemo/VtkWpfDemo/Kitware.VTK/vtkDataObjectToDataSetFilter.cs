using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataObjectToDataSetFilter
/// </summary>
/// <remarks>
///    map field data to concrete dataset
///
/// vtkDataObjectToDataSetFilter is an class that maps a data object (i.e., a field)
/// into a concrete dataset, i.e., gives structure to the field by defining a
/// geometry and topology.
///
/// To use this filter you associate components in the input field data with
/// portions of the output dataset. (A component is an array of values from
/// the field.) For example, you would specify x-y-z points by assigning
/// components from the field for the x, then y, then z values of the points.
/// You may also have to specify component ranges (for each z-y-z) to make
/// sure that the number of x, y, and z values is the same. Also, you may
/// want to normalize the components which helps distribute the data
/// uniformly. Once you've setup the filter to combine all the pieces of
/// data into a specified dataset (the geometry, topology, point and cell
/// data attributes), the various output methods (e.g., GetPolyData()) are
/// used to retrieve the final product.
///
/// This filter is often used in conjunction with
/// vtkFieldDataToAttributeDataFilter.  vtkFieldDataToAttributeDataFilter
/// takes field data and transforms it into attribute data (e.g., point and
/// cell data attributes such as scalars and vectors).  To do this, use this
/// filter which constructs a concrete dataset and passes the input data
/// object field data to its output. and then use
/// vtkFieldDataToAttributeDataFilter to generate the attribute data associated
/// with the dataset.
///
/// @warning
/// Make sure that the data you extract is consistent. That is, if you have N
/// points, extract N x, y, and z components. Also, all the information
/// necessary to define a dataset must be given. For example, vtkPolyData
/// requires points at a minimum; vtkStructuredPoints requires setting the
/// dimensions; vtkStructuredGrid requires defining points and dimensions;
/// vtkUnstructuredGrid requires setting points; and vtkRectilinearGrid
/// requires that you define the x, y, and z-coordinate arrays (by specifying
/// points) as well as the dimensions.
///
/// @warning
/// If you wish to create a dataset of just points (i.e., unstructured points
/// dataset), create vtkPolyData consisting of points. There will be no cells
/// in such a dataset.
///
/// </remarks>
/// <seealso>
///
/// vtkDataObject vtkFieldData vtkDataSet vtkPolyData vtkStructuredPoints
/// vtkStructuredGrid vtkUnstructuredGrid vtkRectilinearGrid
/// vtkDataSetAttributes vtkDataArray
/// </seealso>
public class vtkDataObjectToDataSetFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectToDataSetFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataObjectToDataSetFilter()
	{
		MRClassNameKey = "class vtkDataObjectToDataSetFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectToDataSetFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataObjectToDataSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObjectToDataSetFilter New()
	{
		vtkDataObjectToDataSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObjectToDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataObjectToDataSetFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataObjectToDataSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataObjectToDataSetFilter_DefaultNormalizeOff_01(HandleRef pThis);

	/// <summary>
	/// Set the default Normalize() flag for those methods setting a default
	/// Normalize value (e.g., SetPointComponent).
	/// </summary>
	public virtual void DefaultNormalizeOff()
	{
		vtkDataObjectToDataSetFilter_DefaultNormalizeOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_DefaultNormalizeOn_02(HandleRef pThis);

	/// <summary>
	/// Set the default Normalize() flag for those methods setting a default
	/// Normalize value (e.g., SetPointComponent).
	/// </summary>
	public virtual void DefaultNormalizeOn()
	{
		vtkDataObjectToDataSetFilter_DefaultNormalizeOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayComponent_03(HandleRef pThis);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public int GetCellConnectivityComponentArrayComponent()
	{
		return vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayComponent_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayName_04(HandleRef pThis);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public string GetCellConnectivityComponentArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMaxRange_05(HandleRef pThis);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public int GetCellConnectivityComponentMaxRange()
	{
		return vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMaxRange_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMinRange_06(HandleRef pThis);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public int GetCellConnectivityComponentMinRange()
	{
		return vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMinRange_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayComponent_07(HandleRef pThis);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public int GetCellTypeComponentArrayComponent()
	{
		return vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayComponent_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayName_08(HandleRef pThis);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public string GetCellTypeComponentArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetCellTypeComponentMaxRange_09(HandleRef pThis);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public int GetCellTypeComponentMaxRange()
	{
		return vtkDataObjectToDataSetFilter_GetCellTypeComponentMaxRange_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetCellTypeComponentMinRange_10(HandleRef pThis);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public int GetCellTypeComponentMinRange()
	{
		return vtkDataObjectToDataSetFilter_GetCellTypeComponentMinRange_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetDataSetType_11(HandleRef pThis);

	/// <summary>
	/// Control what type of data is generated for output.
	/// </summary>
	public virtual int GetDataSetType()
	{
		return vtkDataObjectToDataSetFilter_GetDataSetType_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetDefaultNormalize_12(HandleRef pThis);

	/// <summary>
	/// Set the default Normalize() flag for those methods setting a default
	/// Normalize value (e.g., SetPointComponent).
	/// </summary>
	public virtual int GetDefaultNormalize()
	{
		return vtkDataObjectToDataSetFilter_GetDefaultNormalize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetDimensions_13(HandleRef pThis);

	/// <summary>
	/// Specify the dimensions to use if generating a dataset that requires
	/// dimensions specification (vtkStructuredPoints, vtkStructuredGrid,
	/// vtkRectilinearGrid).
	/// </summary>
	public virtual int[] GetDimensions()
	{
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetDimensions_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_GetDimensions_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the dimensions to use if generating a dataset that requires
	/// dimensions specification (vtkStructuredPoints, vtkStructuredGrid,
	/// vtkRectilinearGrid).
	/// </summary>
	public virtual void GetDimensions(IntPtr data)
	{
		vtkDataObjectToDataSetFilter_GetDimensions_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetInput_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to the filter.
	/// </summary>
	public new vtkDataObject GetInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetInput_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetLinesComponentArrayComponent_16(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetLinesComponentArrayComponent()
	{
		return vtkDataObjectToDataSetFilter_GetLinesComponentArrayComponent_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetLinesComponentArrayName_17(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public string GetLinesComponentArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter_GetLinesComponentArrayName_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetLinesComponentMaxRange_18(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetLinesComponentMaxRange()
	{
		return vtkDataObjectToDataSetFilter_GetLinesComponentMaxRange_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetLinesComponentMinRange_19(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetLinesComponentMinRange()
	{
		return vtkDataObjectToDataSetFilter_GetLinesComponentMinRange_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectToDataSetFilter_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataObjectToDataSetFilter_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectToDataSetFilter_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataObjectToDataSetFilter_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetOrigin_22(HandleRef pThis);

	/// <summary>
	/// Specify the origin to use if generating a dataset whose origin
	/// can be set (i.e., a vtkStructuredPoints dataset).
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetOrigin_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_GetOrigin_23(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the origin to use if generating a dataset whose origin
	/// can be set (i.e., a vtkStructuredPoints dataset).
	/// </summary>
	public virtual void GetOrigin(IntPtr data)
	{
		vtkDataObjectToDataSetFilter_GetOrigin_23(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetOutput_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output in different forms. The particular method invoked
	/// should be consistent with the SetDataSetType() method. (Note:
	/// GetOutput() will always return a type consistent with
	/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
	/// aborted due to inconsistent data.)
	/// </summary>
	public new vtkDataSet GetOutput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetOutput_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetOutput_25(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output in different forms. The particular method invoked
	/// should be consistent with the SetDataSetType() method. (Note:
	/// GetOutput() will always return a type consistent with
	/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
	/// aborted due to inconsistent data.)
	/// </summary>
	public new vtkDataSet GetOutput(int idx)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetOutput_25(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentArrayComponent_26(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component of the field to be used for the x, y, and z values
	/// of the points. Note that the parameter comp must lie between (0,2) and
	/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
	/// the field component to use you can specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract. (This method should be used for
	/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
	/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
	/// provided which does not require setting the (min,max) component range or
	/// the normalize flag (normalize is set to DefaulatNormalize value).
	/// </summary>
	public int GetPointComponentArrayComponent(int comp)
	{
		return vtkDataObjectToDataSetFilter_GetPointComponentArrayComponent_26(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetPointComponentArrayName_27(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component of the field to be used for the x, y, and z values
	/// of the points. Note that the parameter comp must lie between (0,2) and
	/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
	/// the field component to use you can specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract. (This method should be used for
	/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
	/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
	/// provided which does not require setting the (min,max) component range or
	/// the normalize flag (normalize is set to DefaulatNormalize value).
	/// </summary>
	public string GetPointComponentArrayName(int comp)
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter_GetPointComponentArrayName_27(GetCppThis(), comp));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentMaxRange_28(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component of the field to be used for the x, y, and z values
	/// of the points. Note that the parameter comp must lie between (0,2) and
	/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
	/// the field component to use you can specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract. (This method should be used for
	/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
	/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
	/// provided which does not require setting the (min,max) component range or
	/// the normalize flag (normalize is set to DefaulatNormalize value).
	/// </summary>
	public int GetPointComponentMaxRange(int comp)
	{
		return vtkDataObjectToDataSetFilter_GetPointComponentMaxRange_28(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentMinRange_29(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component of the field to be used for the x, y, and z values
	/// of the points. Note that the parameter comp must lie between (0,2) and
	/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
	/// the field component to use you can specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract. (This method should be used for
	/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
	/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
	/// provided which does not require setting the (min,max) component range or
	/// the normalize flag (normalize is set to DefaulatNormalize value).
	/// </summary>
	public int GetPointComponentMinRange(int comp)
	{
		return vtkDataObjectToDataSetFilter_GetPointComponentMinRange_29(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentNormailzeFlag_30(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component of the field to be used for the x, y, and z values
	/// of the points. Note that the parameter comp must lie between (0,2) and
	/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
	/// the field component to use you can specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract. (This method should be used for
	/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
	/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
	/// provided which does not require setting the (min,max) component range or
	/// the normalize flag (normalize is set to DefaulatNormalize value).
	/// </summary>
	public int GetPointComponentNormailzeFlag(int comp)
	{
		return vtkDataObjectToDataSetFilter_GetPointComponentNormailzeFlag_30(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetPolyDataOutput_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output in different forms. The particular method invoked
	/// should be consistent with the SetDataSetType() method. (Note:
	/// GetOutput() will always return a type consistent with
	/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
	/// aborted due to inconsistent data.)
	/// </summary>
	public new vtkPolyData GetPolyDataOutput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetPolyDataOutput_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetPolysComponentArrayComponent_32(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetPolysComponentArrayComponent()
	{
		return vtkDataObjectToDataSetFilter_GetPolysComponentArrayComponent_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetPolysComponentArrayName_33(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public string GetPolysComponentArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter_GetPolysComponentArrayName_33(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetPolysComponentMaxRange_34(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetPolysComponentMaxRange()
	{
		return vtkDataObjectToDataSetFilter_GetPolysComponentMaxRange_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetPolysComponentMinRange_35(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetPolysComponentMinRange()
	{
		return vtkDataObjectToDataSetFilter_GetPolysComponentMinRange_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetRectilinearGridOutput_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output in different forms. The particular method invoked
	/// should be consistent with the SetDataSetType() method. (Note:
	/// GetOutput() will always return a type consistent with
	/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
	/// aborted due to inconsistent data.)
	/// </summary>
	public new vtkRectilinearGrid GetRectilinearGridOutput()
	{
		vtkRectilinearGrid vtkRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetRectilinearGridOutput_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGrid2 = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGrid2.Register(null);
			}
		}
		return vtkRectilinearGrid2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetSpacing_37(HandleRef pThis);

	/// <summary>
	/// Specify the spacing to use if generating a dataset whose spacing
	/// can be set (i.e., a vtkStructuredPoints dataset).
	/// </summary>
	public virtual double[] GetSpacing()
	{
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetSpacing_37(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_GetSpacing_38(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the spacing to use if generating a dataset whose spacing
	/// can be set (i.e., a vtkStructuredPoints dataset).
	/// </summary>
	public virtual void GetSpacing(IntPtr data)
	{
		vtkDataObjectToDataSetFilter_GetSpacing_38(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetStripsComponentArrayComponent_39(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetStripsComponentArrayComponent()
	{
		return vtkDataObjectToDataSetFilter_GetStripsComponentArrayComponent_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetStripsComponentArrayName_40(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public string GetStripsComponentArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter_GetStripsComponentArrayName_40(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetStripsComponentMaxRange_41(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetStripsComponentMaxRange()
	{
		return vtkDataObjectToDataSetFilter_GetStripsComponentMaxRange_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetStripsComponentMinRange_42(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetStripsComponentMinRange()
	{
		return vtkDataObjectToDataSetFilter_GetStripsComponentMinRange_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetStructuredGridOutput_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output in different forms. The particular method invoked
	/// should be consistent with the SetDataSetType() method. (Note:
	/// GetOutput() will always return a type consistent with
	/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
	/// aborted due to inconsistent data.)
	/// </summary>
	public new vtkStructuredGrid GetStructuredGridOutput()
	{
		vtkStructuredGrid vtkStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetStructuredGridOutput_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGrid2 = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGrid2.Register(null);
			}
		}
		return vtkStructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetStructuredPointsOutput_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output in different forms. The particular method invoked
	/// should be consistent with the SetDataSetType() method. (Note:
	/// GetOutput() will always return a type consistent with
	/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
	/// aborted due to inconsistent data.)
	/// </summary>
	public new vtkStructuredPoints GetStructuredPointsOutput()
	{
		vtkStructuredPoints vtkStructuredPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetStructuredPointsOutput_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredPoints2 = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredPoints2.Register(null);
			}
		}
		return vtkStructuredPoints2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetUnstructuredGridOutput_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output in different forms. The particular method invoked
	/// should be consistent with the SetDataSetType() method. (Note:
	/// GetOutput() will always return a type consistent with
	/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
	/// aborted due to inconsistent data.)
	/// </summary>
	public new vtkUnstructuredGrid GetUnstructuredGridOutput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_GetUnstructuredGridOutput_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetVertsComponentArrayComponent_46(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetVertsComponentArrayComponent()
	{
		return vtkDataObjectToDataSetFilter_GetVertsComponentArrayComponent_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_GetVertsComponentArrayName_47(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public string GetVertsComponentArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter_GetVertsComponentArrayName_47(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetVertsComponentMaxRange_48(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetVertsComponentMaxRange()
	{
		return vtkDataObjectToDataSetFilter_GetVertsComponentMaxRange_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_GetVertsComponentMinRange_49(HandleRef pThis);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public int GetVertsComponentMinRange()
	{
		return vtkDataObjectToDataSetFilter_GetVertsComponentMinRange_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_IsA_50(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataObjectToDataSetFilter_IsA_50(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectToDataSetFilter_IsTypeOf_51(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataObjectToDataSetFilter_IsTypeOf_51(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_NewInstance_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataObjectToDataSetFilter NewInstance()
	{
		vtkDataObjectToDataSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_NewInstance_53(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObjectToDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectToDataSetFilter_SafeDownCast_54(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObjectToDataSetFilter SafeDownCast(vtkObjectBase o)
	{
		vtkDataObjectToDataSetFilter vtkDataObjectToDataSetFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectToDataSetFilter_SafeDownCast_54(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObjectToDataSetFilter2 = (vtkDataObjectToDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObjectToDataSetFilter2.Register(null);
			}
		}
		return vtkDataObjectToDataSetFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_55(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public void SetCellConnectivityComponent(string arrayName, int arrayComp, int min, int max)
	{
		vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_55(GetCppThis(), arrayName, arrayComp, min, max);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_56(HandleRef pThis, string arrayName, int arrayComp);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public void SetCellConnectivityComponent(string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_56(GetCppThis(), arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetCellTypeComponent_57(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public void SetCellTypeComponent(string arrayName, int arrayComp, int min, int max)
	{
		vtkDataObjectToDataSetFilter_SetCellTypeComponent_57(GetCppThis(), arrayName, arrayComp, min, max);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetCellTypeComponent_58(HandleRef pThis, string arrayName, int arrayComp);

	/// <summary>
	/// Define cell types and cell connectivity when creating unstructured grid
	/// data.  These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of cell types (an integer value per cell), and another
	/// array consisting (for each cell) of a number of points per cell, and
	/// then the cell connectivity. (This is the vtk file format described in
	/// in the textbook or User's Guide.)
	/// </summary>
	public void SetCellTypeComponent(string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetCellTypeComponent_58(GetCppThis(), arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDataSetType_59(HandleRef pThis, int arg0);

	/// <summary>
	/// Control what type of data is generated for output.
	/// </summary>
	public void SetDataSetType(int arg0)
	{
		vtkDataObjectToDataSetFilter_SetDataSetType_59(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToPolyData_60(HandleRef pThis);

	/// <summary>
	/// Control what type of data is generated for output.
	/// </summary>
	public void SetDataSetTypeToPolyData()
	{
		vtkDataObjectToDataSetFilter_SetDataSetTypeToPolyData_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToRectilinearGrid_61(HandleRef pThis);

	/// <summary>
	/// Control what type of data is generated for output.
	/// </summary>
	public void SetDataSetTypeToRectilinearGrid()
	{
		vtkDataObjectToDataSetFilter_SetDataSetTypeToRectilinearGrid_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredGrid_62(HandleRef pThis);

	/// <summary>
	/// Control what type of data is generated for output.
	/// </summary>
	public void SetDataSetTypeToStructuredGrid()
	{
		vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredGrid_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredPoints_63(HandleRef pThis);

	/// <summary>
	/// Control what type of data is generated for output.
	/// </summary>
	public void SetDataSetTypeToStructuredPoints()
	{
		vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredPoints_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToUnstructuredGrid_64(HandleRef pThis);

	/// <summary>
	/// Control what type of data is generated for output.
	/// </summary>
	public void SetDataSetTypeToUnstructuredGrid()
	{
		vtkDataObjectToDataSetFilter_SetDataSetTypeToUnstructuredGrid_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDefaultNormalize_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the default Normalize() flag for those methods setting a default
	/// Normalize value (e.g., SetPointComponent).
	/// </summary>
	public virtual void SetDefaultNormalize(int _arg)
	{
		vtkDataObjectToDataSetFilter_SetDefaultNormalize_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDimensions_66(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Specify the dimensions to use if generating a dataset that requires
	/// dimensions specification (vtkStructuredPoints, vtkStructuredGrid,
	/// vtkRectilinearGrid).
	/// </summary>
	public virtual void SetDimensions(int _arg1, int _arg2, int _arg3)
	{
		vtkDataObjectToDataSetFilter_SetDimensions_66(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDimensions_67(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the dimensions to use if generating a dataset that requires
	/// dimensions specification (vtkStructuredPoints, vtkStructuredGrid,
	/// vtkRectilinearGrid).
	/// </summary>
	public virtual void SetDimensions(IntPtr _arg)
	{
		vtkDataObjectToDataSetFilter_SetDimensions_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDimensionsComponent_68(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

	/// <summary>
	/// Alternative methods to specify the dimensions, spacing, and origin for those
	/// datasets requiring this information. You need to specify the name of an array;
	/// the component of the array, and the range of the array (min,max). These methods
	/// will override the information given by the previous methods.
	/// </summary>
	public void SetDimensionsComponent(string arrayName, int arrayComp, int min, int max)
	{
		vtkDataObjectToDataSetFilter_SetDimensionsComponent_68(GetCppThis(), arrayName, arrayComp, min, max);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetDimensionsComponent_69(HandleRef pThis, string arrayName, int arrayComp);

	/// <summary>
	/// Alternative methods to specify the dimensions, spacing, and origin for those
	/// datasets requiring this information. You need to specify the name of an array;
	/// the component of the array, and the range of the array (min,max). These methods
	/// will override the information given by the previous methods.
	/// </summary>
	public void SetDimensionsComponent(string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetDimensionsComponent_69(GetCppThis(), arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetLinesComponent_70(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public void SetLinesComponent(string arrayName, int arrayComp, int min, int max)
	{
		vtkDataObjectToDataSetFilter_SetLinesComponent_70(GetCppThis(), arrayName, arrayComp, min, max);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetLinesComponent_71(HandleRef pThis, string arrayName, int arrayComp);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public void SetLinesComponent(string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetLinesComponent_71(GetCppThis(), arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetOrigin_72(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the origin to use if generating a dataset whose origin
	/// can be set (i.e., a vtkStructuredPoints dataset).
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkDataObjectToDataSetFilter_SetOrigin_72(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetOrigin_73(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the origin to use if generating a dataset whose origin
	/// can be set (i.e., a vtkStructuredPoints dataset).
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkDataObjectToDataSetFilter_SetOrigin_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetOriginComponent_74(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

	/// <summary>
	/// Alternative methods to specify the dimensions, spacing, and origin for those
	/// datasets requiring this information. You need to specify the name of an array;
	/// the component of the array, and the range of the array (min,max). These methods
	/// will override the information given by the previous methods.
	/// </summary>
	public void SetOriginComponent(string arrayName, int arrayComp, int min, int max)
	{
		vtkDataObjectToDataSetFilter_SetOriginComponent_74(GetCppThis(), arrayName, arrayComp, min, max);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetOriginComponent_75(HandleRef pThis, string arrayName, int arrayComp);

	/// <summary>
	/// Alternative methods to specify the dimensions, spacing, and origin for those
	/// datasets requiring this information. You need to specify the name of an array;
	/// the component of the array, and the range of the array (min,max). These methods
	/// will override the information given by the previous methods.
	/// </summary>
	public void SetOriginComponent(string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetOriginComponent_75(GetCppThis(), arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetPointComponent_76(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

	/// <summary>
	/// Define the component of the field to be used for the x, y, and z values
	/// of the points. Note that the parameter comp must lie between (0,2) and
	/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
	/// the field component to use you can specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract. (This method should be used for
	/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
	/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
	/// provided which does not require setting the (min,max) component range or
	/// the normalize flag (normalize is set to DefaulatNormalize value).
	/// </summary>
	public void SetPointComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
	{
		vtkDataObjectToDataSetFilter_SetPointComponent_76(GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetPointComponent_77(HandleRef pThis, int comp, string arrayName, int arrayComp);

	/// <summary>
	/// Define the component of the field to be used for the x, y, and z values
	/// of the points. Note that the parameter comp must lie between (0,2) and
	/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
	/// the field component to use you can specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract. (This method should be used for
	/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
	/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
	/// provided which does not require setting the (min,max) component range or
	/// the normalize flag (normalize is set to DefaulatNormalize value).
	/// </summary>
	public void SetPointComponent(int comp, string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetPointComponent_77(GetCppThis(), comp, arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetPolysComponent_78(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public void SetPolysComponent(string arrayName, int arrayComp, int min, int max)
	{
		vtkDataObjectToDataSetFilter_SetPolysComponent_78(GetCppThis(), arrayName, arrayComp, min, max);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetPolysComponent_79(HandleRef pThis, string arrayName, int arrayComp);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public void SetPolysComponent(string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetPolysComponent_79(GetCppThis(), arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetSpacing_80(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the spacing to use if generating a dataset whose spacing
	/// can be set (i.e., a vtkStructuredPoints dataset).
	/// </summary>
	public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkDataObjectToDataSetFilter_SetSpacing_80(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetSpacing_81(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the spacing to use if generating a dataset whose spacing
	/// can be set (i.e., a vtkStructuredPoints dataset).
	/// </summary>
	public virtual void SetSpacing(IntPtr _arg)
	{
		vtkDataObjectToDataSetFilter_SetSpacing_81(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetSpacingComponent_82(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

	/// <summary>
	/// Alternative methods to specify the dimensions, spacing, and origin for those
	/// datasets requiring this information. You need to specify the name of an array;
	/// the component of the array, and the range of the array (min,max). These methods
	/// will override the information given by the previous methods.
	/// </summary>
	public void SetSpacingComponent(string arrayName, int arrayComp, int min, int max)
	{
		vtkDataObjectToDataSetFilter_SetSpacingComponent_82(GetCppThis(), arrayName, arrayComp, min, max);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetSpacingComponent_83(HandleRef pThis, string arrayName, int arrayComp);

	/// <summary>
	/// Alternative methods to specify the dimensions, spacing, and origin for those
	/// datasets requiring this information. You need to specify the name of an array;
	/// the component of the array, and the range of the array (min,max). These methods
	/// will override the information given by the previous methods.
	/// </summary>
	public void SetSpacingComponent(string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetSpacingComponent_83(GetCppThis(), arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetStripsComponent_84(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public void SetStripsComponent(string arrayName, int arrayComp, int min, int max)
	{
		vtkDataObjectToDataSetFilter_SetStripsComponent_84(GetCppThis(), arrayName, arrayComp, min, max);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetStripsComponent_85(HandleRef pThis, string arrayName, int arrayComp);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public void SetStripsComponent(string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetStripsComponent_85(GetCppThis(), arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetVertsComponent_86(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public void SetVertsComponent(string arrayName, int arrayComp, int min, int max)
	{
		vtkDataObjectToDataSetFilter_SetVertsComponent_86(GetCppThis(), arrayName, arrayComp, min, max);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectToDataSetFilter_SetVertsComponent_87(HandleRef pThis, string arrayName, int arrayComp);

	/// <summary>
	/// Define cell connectivity when creating vtkPolyData. You can define
	/// vertices, lines, polygons, and/or triangle strips via these methods.
	/// These methods are similar to those for defining points, except
	/// that no normalization of the data is possible. Basically, you need to
	/// define an array of values that (for each cell) includes the number of
	/// points per cell, and then the cell connectivity. (This is the vtk file
	/// format described in the textbook or User's Guide.)
	/// </summary>
	public void SetVertsComponent(string arrayName, int arrayComp)
	{
		vtkDataObjectToDataSetFilter_SetVertsComponent_87(GetCppThis(), arrayName, arrayComp);
	}
}
