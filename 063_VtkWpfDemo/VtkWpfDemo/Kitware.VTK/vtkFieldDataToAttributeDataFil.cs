using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFieldDataToAttributeDataFilter
/// </summary>
/// <remarks>
///    map field data to dataset attribute data
///
/// vtkFieldDataToAttributeDataFilter is a class that maps field data into
/// dataset attributes. The input to this filter is any type of dataset and
/// the output is the same dataset (geometry/topology) with new attribute data
/// (attribute data is passed through if not replaced during filter
/// execution).
///
/// To use this filter you must specify which field data from the input
/// dataset to use. There are three possibilities: the cell field data, the
/// point field data, or the field data associated with the data object
/// superclass. Then you specify which attribute data to create: either cell
/// attribute data or point attribute data.  Finally, you must define how to
/// construct the various attribute data types (e.g., scalars, vectors,
/// normals, etc.) from the arrays and the components of the arrays from the
/// field data. This is done by associating components in the input field with
/// components making up the attribute data. For example, you would specify a
/// scalar with three components (RGB) by assigning components from the field
/// for the R, then G, then B values of the scalars.  You may also have to
/// specify component ranges (for each R-G-B) to make sure that the number of
/// R, G, and B values is the same. Also, you may want to normalize the
/// components which helps distribute the data uniformly.
///
/// This filter is often used in conjunction with
/// vtkDataObjectToDataSetFilter.  vtkDataObjectToDataSetFilter filter
/// generates dataset topology and geometry and passes its input field data
/// along to its output. Then this filter is used to generate the attribute
/// data to go along with the dataset.
///
/// @warning
/// Make sure that the data you extract is consistent. That is, if you have N
/// points, extract N point attributes (scalars, vectors, etc.).
///
/// </remarks>
/// <seealso>
///
/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
/// vtkDataSetAttributes vtkDataArray
/// </seealso>
public class vtkFieldDataToAttributeDataFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFieldDataToAttributeDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFieldDataToAttributeDataFilter()
	{
		MRClassNameKey = "class vtkFieldDataToAttributeDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFieldDataToAttributeDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFieldDataToAttributeDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldDataToAttributeDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with input field set to the data object field, and the
	/// output attribute data set to generate point data.
	/// </summary>
	public new static vtkFieldDataToAttributeDataFilter New()
	{
		vtkFieldDataToAttributeDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldDataToAttributeDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFieldDataToAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with input field set to the data object field, and the
	/// output attribute data set to generate point data.
	/// </summary>
	public vtkFieldDataToAttributeDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFieldDataToAttributeDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkFieldDataToAttributeDataFilter_ConstructArray_01(HandleRef da, int comp, HandleRef fieldArray, int fieldComp, long min, long max, int normalize);

	/// <summary>
	/// Construct a portion of a data array (the comp portion) from another data
	/// array and its component. The variables min and max control the range of
	/// the data to use from the other data array; normalize is a flag that when
	/// set will normalize the data between (0,1).
	/// </summary>
	public static int ConstructArray(vtkDataArray da, int comp, vtkDataArray fieldArray, int fieldComp, long min, long max, int normalize)
	{
		return vtkFieldDataToAttributeDataFilter_ConstructArray_01(da?.GetCppThis() ?? default(HandleRef), comp, fieldArray?.GetCppThis() ?? default(HandleRef), fieldComp, min, max, normalize);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_DefaultNormalizeOff_02(HandleRef pThis);

	/// <summary>
	/// Set the default Normalize() flag for those methods setting a default
	/// Normalize value (e.g., SetScalarComponents).
	/// </summary>
	public virtual void DefaultNormalizeOff()
	{
		vtkFieldDataToAttributeDataFilter_DefaultNormalizeOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_DefaultNormalizeOn_03(HandleRef pThis);

	/// <summary>
	/// Set the default Normalize() flag for those methods setting a default
	/// Normalize value (e.g., SetScalarComponents).
	/// </summary>
	public virtual void DefaultNormalizeOn()
	{
		vtkFieldDataToAttributeDataFilter_DefaultNormalizeOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetDefaultNormalize_04(HandleRef pThis);

	/// <summary>
	/// Set the default Normalize() flag for those methods setting a default
	/// Normalize value (e.g., SetScalarComponents).
	/// </summary>
	public virtual int GetDefaultNormalize()
	{
		return vtkFieldDataToAttributeDataFilter_GetDefaultNormalize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetFieldArray_05(HandleRef fd, string name, int comp, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an array of a particular name from field data and do error checking.
	/// </summary>
	public static vtkDataArray GetFieldArray(vtkFieldData fd, string name, int comp)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldDataToAttributeDataFilter_GetFieldArray_05(fd?.GetCppThis() ?? default(HandleRef), name, comp, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetInputField_06(HandleRef pThis);

	/// <summary>
	/// Specify which field data to use to generate the output attribute
	/// data. There are three choices: the field data associated with the
	/// vtkDataObject superclass; the point field attribute data; and the cell
	/// field attribute data.
	/// </summary>
	public virtual int GetInputField()
	{
		return vtkFieldDataToAttributeDataFilter_GetInputField_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayComponent_07(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the normal
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetNormalComponentArrayComponent(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayComponent_07(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayName_08(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the normal
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public string GetNormalComponentArrayName(int comp)
	{
		return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayName_08(GetCppThis(), comp));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentMaxRange_09(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the normal
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetNormalComponentMaxRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetNormalComponentMaxRange_09(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentMinRange_10(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the normal
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetNormalComponentMinRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetNormalComponentMinRange_10(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentNormalizeFlag_11(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the normal
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetNormalComponentNormalizeFlag(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetNormalComponentNormalizeFlag_11(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFieldDataToAttributeDataFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFieldDataToAttributeDataFilter_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFieldDataToAttributeDataFilter_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFieldDataToAttributeDataFilter_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetOutputAttributeData_14(HandleRef pThis);

	/// <summary>
	/// Specify which attribute data to output: point or cell data attributes.
	/// </summary>
	public virtual int GetOutputAttributeData()
	{
		return vtkFieldDataToAttributeDataFilter_GetOutputAttributeData_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayComponent_15(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the scalar
	/// components.  Note that the parameter comp must lie between (0,4). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetScalarComponentArrayComponent(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayComponent_15(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayName_16(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the scalar
	/// components.  Note that the parameter comp must lie between (0,4). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public string GetScalarComponentArrayName(int comp)
	{
		return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayName_16(GetCppThis(), comp));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentMaxRange_17(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the scalar
	/// components.  Note that the parameter comp must lie between (0,4). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetScalarComponentMaxRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetScalarComponentMaxRange_17(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentMinRange_18(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the scalar
	/// components.  Note that the parameter comp must lie between (0,4). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetScalarComponentMinRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetScalarComponentMinRange_18(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentNormalizeFlag_19(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the scalar
	/// components.  Note that the parameter comp must lie between (0,4). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetScalarComponentNormalizeFlag(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetScalarComponentNormalizeFlag_19(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayComponent_20(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the cell texture coord
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetTCoordComponentArrayComponent(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayComponent_20(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayName_21(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the cell texture coord
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public string GetTCoordComponentArrayName(int comp)
	{
		return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayName_21(GetCppThis(), comp));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentMaxRange_22(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the cell texture coord
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetTCoordComponentMaxRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetTCoordComponentMaxRange_22(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentMinRange_23(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the cell texture coord
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetTCoordComponentMinRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetTCoordComponentMinRange_23(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentNormalizeFlag_24(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the cell texture coord
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetTCoordComponentNormalizeFlag(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetTCoordComponentNormalizeFlag_24(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayComponent_25(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the tensor
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetTensorComponentArrayComponent(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayComponent_25(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayName_26(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the tensor
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public string GetTensorComponentArrayName(int comp)
	{
		return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayName_26(GetCppThis(), comp));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentMaxRange_27(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the tensor
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetTensorComponentMaxRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetTensorComponentMaxRange_27(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentMinRange_28(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the tensor
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetTensorComponentMinRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetTensorComponentMinRange_28(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentNormalizeFlag_29(HandleRef pThis, int comp);

	/// <summary>
	/// Define the components of the field to be used for the tensor
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetTensorComponentNormalizeFlag(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetTensorComponentNormalizeFlag_29(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayComponent_30(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the vector
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetVectorComponentArrayComponent(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayComponent_30(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayName_31(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the vector
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public string GetVectorComponentArrayName(int comp)
	{
		return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayName_31(GetCppThis(), comp));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentMaxRange_32(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the vector
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetVectorComponentMaxRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetVectorComponentMaxRange_32(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentMinRange_33(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the vector
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetVectorComponentMinRange(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetVectorComponentMinRange_33(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentNormalizeFlag_34(HandleRef pThis, int comp);

	/// <summary>
	/// Define the component(s) of the field to be used for the vector
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public int GetVectorComponentNormalizeFlag(int comp)
	{
		return vtkFieldDataToAttributeDataFilter_GetVectorComponentNormalizeFlag_34(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFieldDataToAttributeDataFilter_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFieldDataToAttributeDataFilter_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldDataToAttributeDataFilter_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFieldDataToAttributeDataFilter NewInstance()
	{
		vtkFieldDataToAttributeDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldDataToAttributeDataFilter_NewInstance_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFieldDataToAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldDataToAttributeDataFilter_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFieldDataToAttributeDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkFieldDataToAttributeDataFilter vtkFieldDataToAttributeDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldDataToAttributeDataFilter_SafeDownCast_39(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFieldDataToAttributeDataFilter2 = (vtkFieldDataToAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFieldDataToAttributeDataFilter2.Register(null);
			}
		}
		return vtkFieldDataToAttributeDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetDefaultNormalize_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the default Normalize() flag for those methods setting a default
	/// Normalize value (e.g., SetScalarComponents).
	/// </summary>
	public virtual void SetDefaultNormalize(int _arg)
	{
		vtkFieldDataToAttributeDataFilter_SetDefaultNormalize_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetInputField_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify which field data to use to generate the output attribute
	/// data. There are three choices: the field data associated with the
	/// vtkDataObject superclass; the point field attribute data; and the cell
	/// field attribute data.
	/// </summary>
	public virtual void SetInputField(int _arg)
	{
		vtkFieldDataToAttributeDataFilter_SetInputField_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetInputFieldToCellDataField_42(HandleRef pThis);

	/// <summary>
	/// Specify which field data to use to generate the output attribute
	/// data. There are three choices: the field data associated with the
	/// vtkDataObject superclass; the point field attribute data; and the cell
	/// field attribute data.
	/// </summary>
	public void SetInputFieldToCellDataField()
	{
		vtkFieldDataToAttributeDataFilter_SetInputFieldToCellDataField_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetInputFieldToDataObjectField_43(HandleRef pThis);

	/// <summary>
	/// Specify which field data to use to generate the output attribute
	/// data. There are three choices: the field data associated with the
	/// vtkDataObject superclass; the point field attribute data; and the cell
	/// field attribute data.
	/// </summary>
	public void SetInputFieldToDataObjectField()
	{
		vtkFieldDataToAttributeDataFilter_SetInputFieldToDataObjectField_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetInputFieldToPointDataField_44(HandleRef pThis);

	/// <summary>
	/// Specify which field data to use to generate the output attribute
	/// data. There are three choices: the field data associated with the
	/// vtkDataObject superclass; the point field attribute data; and the cell
	/// field attribute data.
	/// </summary>
	public void SetInputFieldToPointDataField()
	{
		vtkFieldDataToAttributeDataFilter_SetInputFieldToPointDataField_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetNormalComponent_45(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

	/// <summary>
	/// Define the component(s) of the field to be used for the normal
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetNormalComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
	{
		vtkFieldDataToAttributeDataFilter_SetNormalComponent_45(GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetNormalComponent_46(HandleRef pThis, int comp, string arrayName, int arrayComp);

	/// <summary>
	/// Define the component(s) of the field to be used for the normal
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetNormalComponent(int comp, string arrayName, int arrayComp)
	{
		vtkFieldDataToAttributeDataFilter_SetNormalComponent_46(GetCppThis(), comp, arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetOutputAttributeData_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify which attribute data to output: point or cell data attributes.
	/// </summary>
	public virtual void SetOutputAttributeData(int _arg)
	{
		vtkFieldDataToAttributeDataFilter_SetOutputAttributeData_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToCellData_48(HandleRef pThis);

	/// <summary>
	/// Specify which attribute data to output: point or cell data attributes.
	/// </summary>
	public void SetOutputAttributeDataToCellData()
	{
		vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToCellData_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToPointData_49(HandleRef pThis);

	/// <summary>
	/// Specify which attribute data to output: point or cell data attributes.
	/// </summary>
	public void SetOutputAttributeDataToPointData()
	{
		vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToPointData_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetScalarComponent_50(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

	/// <summary>
	/// Define the component(s) of the field to be used for the scalar
	/// components.  Note that the parameter comp must lie between (0,4). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetScalarComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
	{
		vtkFieldDataToAttributeDataFilter_SetScalarComponent_50(GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetScalarComponent_51(HandleRef pThis, int comp, string arrayName, int arrayComp);

	/// <summary>
	/// Define the component(s) of the field to be used for the scalar
	/// components.  Note that the parameter comp must lie between (0,4). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetScalarComponent(int comp, string arrayName, int arrayComp)
	{
		vtkFieldDataToAttributeDataFilter_SetScalarComponent_51(GetCppThis(), comp, arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetTCoordComponent_52(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

	/// <summary>
	/// Define the components of the field to be used for the cell texture coord
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetTCoordComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
	{
		vtkFieldDataToAttributeDataFilter_SetTCoordComponent_52(GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetTCoordComponent_53(HandleRef pThis, int comp, string arrayName, int arrayComp);

	/// <summary>
	/// Define the components of the field to be used for the cell texture coord
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetTCoordComponent(int comp, string arrayName, int arrayComp)
	{
		vtkFieldDataToAttributeDataFilter_SetTCoordComponent_53(GetCppThis(), comp, arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetTensorComponent_54(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

	/// <summary>
	/// Define the components of the field to be used for the tensor
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetTensorComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
	{
		vtkFieldDataToAttributeDataFilter_SetTensorComponent_54(GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetTensorComponent_55(HandleRef pThis, int comp, string arrayName, int arrayComp);

	/// <summary>
	/// Define the components of the field to be used for the tensor
	/// components.  Note that the parameter comp must lie between (0,9). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetTensorComponent(int comp, string arrayName, int arrayComp)
	{
		vtkFieldDataToAttributeDataFilter_SetTensorComponent_55(GetCppThis(), comp, arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetVectorComponent_56(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

	/// <summary>
	/// Define the component(s) of the field to be used for the vector
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetVectorComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
	{
		vtkFieldDataToAttributeDataFilter_SetVectorComponent_56(GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldDataToAttributeDataFilter_SetVectorComponent_57(HandleRef pThis, int comp, string arrayName, int arrayComp);

	/// <summary>
	/// Define the component(s) of the field to be used for the vector
	/// components.  Note that the parameter comp must lie between (0,3). To
	/// define the field component to use you specify an array name and the
	/// component in that array. The (min,max) values are the range of data in
	/// the component you wish to extract.
	/// </summary>
	public void SetVectorComponent(int comp, string arrayName, int arrayComp)
	{
		vtkFieldDataToAttributeDataFilter_SetVectorComponent_57(GetCppThis(), comp, arrayName, arrayComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldDataToAttributeDataFilter_UpdateComponentRange_58(HandleRef da, IntPtr compRange);

	/// <summary>
	/// Update the maximum and minimum component range values. Returns a flag
	/// indicating whether the range was updated.
	/// </summary>
	public static int UpdateComponentRange(vtkDataArray da, IntPtr compRange)
	{
		return vtkFieldDataToAttributeDataFilter_UpdateComponentRange_58(da?.GetCppThis() ?? default(HandleRef), compRange);
	}
}
