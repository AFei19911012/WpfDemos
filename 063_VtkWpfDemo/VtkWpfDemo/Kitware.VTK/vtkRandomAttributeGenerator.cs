using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRandomAttributeGenerator
/// </summary>
/// <remarks>
///    generate and create random data attributes
///
/// vtkRandomAttributeGenerator is a filter that creates random attributes
/// including scalars, vectors, normals, tensors, texture coordinates and/or
/// general data arrays. These attributes can be generated as point data, cell
/// data or general field data. The generation of each component is normalized
/// between a user-specified minimum and maximum value.
///
/// This filter provides that capability to specify the data type of the
/// attributes, the range for each of the components, and the number of
/// components. Note, however, that this flexibility only goes so far because
/// some attributes (e.g., normals, vectors and tensors) are fixed in the
/// number of components, and in the case of normals and tensors, are
/// constrained in the values that some of the components can take (i.e.,
/// normals have magnitude one, and tensors are symmetric).
///
/// @warning
/// In general this class is used for debugging or testing purposes.
///
/// @warning
/// It is possible to generate multiple attributes simultaneously.
///
/// @warning
/// By default, no data is generated. Make sure to enable the generation of
/// some attributes if you want this filter to affect the output. Also note
/// that this filter passes through input geometry, topology and attributes.
/// Newly created attributes may replace attribute data that would have
/// otherwise been passed through.
///
/// </remarks>
/// <seealso>
///
/// vtkBrownianPoints
/// </seealso>
public class vtkRandomAttributeGenerator : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRandomAttributeGenerator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRandomAttributeGenerator()
	{
		MRClassNameKey = "class vtkRandomAttributeGenerator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomAttributeGenerator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRandomAttributeGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomAttributeGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtkRandomAttributeGenerator New()
	{
		vtkRandomAttributeGenerator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomAttributeGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRandomAttributeGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public vtkRandomAttributeGenerator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRandomAttributeGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRandomAttributeGenerator_AttributesConstantPerBlockOff_01(HandleRef pThis);

	/// <summary>
	/// Indicate that the generated attributes are
	/// constant within a block. This can be used to highlight
	/// blocks in a composite dataset.
	/// </summary>
	public virtual void AttributesConstantPerBlockOff()
	{
		vtkRandomAttributeGenerator_AttributesConstantPerBlockOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_AttributesConstantPerBlockOn_02(HandleRef pThis);

	/// <summary>
	/// Indicate that the generated attributes are
	/// constant within a block. This can be used to highlight
	/// blocks in a composite dataset.
	/// </summary>
	public virtual void AttributesConstantPerBlockOn()
	{
		vtkRandomAttributeGenerator_AttributesConstantPerBlockOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateAllCellDataOff_03(HandleRef pThis);

	/// <summary>
	/// Convenience methods for generating data: all data, all point data, or all cell data.
	/// For example, if all data is enabled, then all point, cell and field data is generated.
	/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
	/// and a data array are produced.
	/// </summary>
	public void GenerateAllCellDataOff()
	{
		vtkRandomAttributeGenerator_GenerateAllCellDataOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateAllCellDataOn_04(HandleRef pThis);

	/// <summary>
	/// Convenience methods for generating data: all data, all point data, or all cell data.
	/// For example, if all data is enabled, then all point, cell and field data is generated.
	/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
	/// and a data array are produced.
	/// </summary>
	public void GenerateAllCellDataOn()
	{
		vtkRandomAttributeGenerator_GenerateAllCellDataOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateAllDataOff_05(HandleRef pThis);

	/// <summary>
	/// Convenience methods for generating data: all data, all point data, or all cell data.
	/// For example, if all data is enabled, then all point, cell and field data is generated.
	/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
	/// and a data array are produced.
	/// </summary>
	public void GenerateAllDataOff()
	{
		vtkRandomAttributeGenerator_GenerateAllDataOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateAllDataOn_06(HandleRef pThis);

	/// <summary>
	/// Convenience methods for generating data: all data, all point data, or all cell data.
	/// For example, if all data is enabled, then all point, cell and field data is generated.
	/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
	/// and a data array are produced.
	/// </summary>
	public void GenerateAllDataOn()
	{
		vtkRandomAttributeGenerator_GenerateAllDataOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateAllPointDataOff_07(HandleRef pThis);

	/// <summary>
	/// Convenience methods for generating data: all data, all point data, or all cell data.
	/// For example, if all data is enabled, then all point, cell and field data is generated.
	/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
	/// and a data array are produced.
	/// </summary>
	public void GenerateAllPointDataOff()
	{
		vtkRandomAttributeGenerator_GenerateAllPointDataOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateAllPointDataOn_08(HandleRef pThis);

	/// <summary>
	/// Convenience methods for generating data: all data, all point data, or all cell data.
	/// For example, if all data is enabled, then all point, cell and field data is generated.
	/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
	/// and a data array are produced.
	/// </summary>
	public void GenerateAllPointDataOn()
	{
		vtkRandomAttributeGenerator_GenerateAllPointDataOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellArrayOff_09(HandleRef pThis);

	/// <summary>
	/// Indicate that an arbitrary cell array is to be generated. The array is
	/// added to the cell data but is not labeled as one of scalars, vectors,
	/// normals, tensors, or texture coordinates array (i.e., AddArray() is
	/// used). Note that the specified number of components is used to create
	/// the array.
	/// </summary>
	public virtual void GenerateCellArrayOff()
	{
		vtkRandomAttributeGenerator_GenerateCellArrayOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellArrayOn_10(HandleRef pThis);

	/// <summary>
	/// Indicate that an arbitrary cell array is to be generated. The array is
	/// added to the cell data but is not labeled as one of scalars, vectors,
	/// normals, tensors, or texture coordinates array (i.e., AddArray() is
	/// used). Note that the specified number of components is used to create
	/// the array.
	/// </summary>
	public virtual void GenerateCellArrayOn()
	{
		vtkRandomAttributeGenerator_GenerateCellArrayOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellNormalsOff_11(HandleRef pThis);

	/// <summary>
	/// Indicate that cell normals are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void GenerateCellNormalsOff()
	{
		vtkRandomAttributeGenerator_GenerateCellNormalsOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellNormalsOn_12(HandleRef pThis);

	/// <summary>
	/// Indicate that cell normals are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void GenerateCellNormalsOn()
	{
		vtkRandomAttributeGenerator_GenerateCellNormalsOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellScalarsOff_13(HandleRef pThis);

	/// <summary>
	/// Indicate that cell scalars are to be generated. Note that the specified
	/// number of components is used to create the scalar.
	/// </summary>
	public virtual void GenerateCellScalarsOff()
	{
		vtkRandomAttributeGenerator_GenerateCellScalarsOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellScalarsOn_14(HandleRef pThis);

	/// <summary>
	/// Indicate that cell scalars are to be generated. Note that the specified
	/// number of components is used to create the scalar.
	/// </summary>
	public virtual void GenerateCellScalarsOn()
	{
		vtkRandomAttributeGenerator_GenerateCellScalarsOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellTCoordsOff_15(HandleRef pThis);

	/// <summary>
	/// Indicate that cell texture coordinates are to be generated. Note that
	/// the specified number of components is used to create the texture
	/// coordinates (but must range between one and three).
	/// </summary>
	public virtual void GenerateCellTCoordsOff()
	{
		vtkRandomAttributeGenerator_GenerateCellTCoordsOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellTCoordsOn_16(HandleRef pThis);

	/// <summary>
	/// Indicate that cell texture coordinates are to be generated. Note that
	/// the specified number of components is used to create the texture
	/// coordinates (but must range between one and three).
	/// </summary>
	public virtual void GenerateCellTCoordsOn()
	{
		vtkRandomAttributeGenerator_GenerateCellTCoordsOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellTensorsOff_17(HandleRef pThis);

	/// <summary>
	/// Indicate that cell tensors are to be generated. Note that the
	/// number of components is always equal to nine.
	/// </summary>
	public virtual void GenerateCellTensorsOff()
	{
		vtkRandomAttributeGenerator_GenerateCellTensorsOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellTensorsOn_18(HandleRef pThis);

	/// <summary>
	/// Indicate that cell tensors are to be generated. Note that the
	/// number of components is always equal to nine.
	/// </summary>
	public virtual void GenerateCellTensorsOn()
	{
		vtkRandomAttributeGenerator_GenerateCellTensorsOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellVectorsOff_19(HandleRef pThis);

	/// <summary>
	/// Indicate that cell vectors are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void GenerateCellVectorsOff()
	{
		vtkRandomAttributeGenerator_GenerateCellVectorsOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateCellVectorsOn_20(HandleRef pThis);

	/// <summary>
	/// Indicate that cell vectors are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void GenerateCellVectorsOn()
	{
		vtkRandomAttributeGenerator_GenerateCellVectorsOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateFieldArrayOff_21(HandleRef pThis);

	/// <summary>
	/// Indicate that an arbitrary field data array is to be generated. Note
	/// that the specified number of components is used to create the scalar.
	/// </summary>
	public virtual void GenerateFieldArrayOff()
	{
		vtkRandomAttributeGenerator_GenerateFieldArrayOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GenerateFieldArrayOn_22(HandleRef pThis);

	/// <summary>
	/// Indicate that an arbitrary field data array is to be generated. Note
	/// that the specified number of components is used to create the scalar.
	/// </summary>
	public virtual void GenerateFieldArrayOn()
	{
		vtkRandomAttributeGenerator_GenerateFieldArrayOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointArrayOff_23(HandleRef pThis);

	/// <summary>
	/// Indicate that an arbitrary point array is to be generated. The array is
	/// added to the points data but is not labeled as one of scalars, vectors,
	/// normals, tensors, or texture coordinates (i.e., AddArray() is
	/// used). Note that the specified number of components is used to create
	/// the array.
	/// </summary>
	public virtual void GeneratePointArrayOff()
	{
		vtkRandomAttributeGenerator_GeneratePointArrayOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointArrayOn_24(HandleRef pThis);

	/// <summary>
	/// Indicate that an arbitrary point array is to be generated. The array is
	/// added to the points data but is not labeled as one of scalars, vectors,
	/// normals, tensors, or texture coordinates (i.e., AddArray() is
	/// used). Note that the specified number of components is used to create
	/// the array.
	/// </summary>
	public virtual void GeneratePointArrayOn()
	{
		vtkRandomAttributeGenerator_GeneratePointArrayOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointNormalsOff_25(HandleRef pThis);

	/// <summary>
	/// Indicate that point normals are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void GeneratePointNormalsOff()
	{
		vtkRandomAttributeGenerator_GeneratePointNormalsOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointNormalsOn_26(HandleRef pThis);

	/// <summary>
	/// Indicate that point normals are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void GeneratePointNormalsOn()
	{
		vtkRandomAttributeGenerator_GeneratePointNormalsOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointScalarsOff_27(HandleRef pThis);

	/// <summary>
	/// Indicate that point scalars are to be generated. Note that the specified
	/// number of components is used to create the scalar.
	/// </summary>
	public virtual void GeneratePointScalarsOff()
	{
		vtkRandomAttributeGenerator_GeneratePointScalarsOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointScalarsOn_28(HandleRef pThis);

	/// <summary>
	/// Indicate that point scalars are to be generated. Note that the specified
	/// number of components is used to create the scalar.
	/// </summary>
	public virtual void GeneratePointScalarsOn()
	{
		vtkRandomAttributeGenerator_GeneratePointScalarsOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointTCoordsOff_29(HandleRef pThis);

	/// <summary>
	/// Indicate that point texture coordinates are to be generated. Note that
	/// the specified number of components is used to create the texture
	/// coordinates (but must range between one and three).
	/// </summary>
	public virtual void GeneratePointTCoordsOff()
	{
		vtkRandomAttributeGenerator_GeneratePointTCoordsOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointTCoordsOn_30(HandleRef pThis);

	/// <summary>
	/// Indicate that point texture coordinates are to be generated. Note that
	/// the specified number of components is used to create the texture
	/// coordinates (but must range between one and three).
	/// </summary>
	public virtual void GeneratePointTCoordsOn()
	{
		vtkRandomAttributeGenerator_GeneratePointTCoordsOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointTensorsOff_31(HandleRef pThis);

	/// <summary>
	/// Indicate that point tensors are to be generated. Note that the
	/// number of components is always equal to nine.
	/// </summary>
	public virtual void GeneratePointTensorsOff()
	{
		vtkRandomAttributeGenerator_GeneratePointTensorsOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointTensorsOn_32(HandleRef pThis);

	/// <summary>
	/// Indicate that point tensors are to be generated. Note that the
	/// number of components is always equal to nine.
	/// </summary>
	public virtual void GeneratePointTensorsOn()
	{
		vtkRandomAttributeGenerator_GeneratePointTensorsOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointVectorsOff_33(HandleRef pThis);

	/// <summary>
	/// Indicate that point vectors are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void GeneratePointVectorsOff()
	{
		vtkRandomAttributeGenerator_GeneratePointVectorsOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_GeneratePointVectorsOn_34(HandleRef pThis);

	/// <summary>
	/// Indicate that point vectors are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void GeneratePointVectorsOn()
	{
		vtkRandomAttributeGenerator_GeneratePointVectorsOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRandomAttributeGenerator_GetAttributesConstantPerBlock_35(HandleRef pThis);

	/// <summary>
	/// Indicate that the generated attributes are
	/// constant within a block. This can be used to highlight
	/// blocks in a composite dataset.
	/// </summary>
	public virtual bool GetAttributesConstantPerBlock()
	{
		return (vtkRandomAttributeGenerator_GetAttributesConstantPerBlock_35(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetDataType_36(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public virtual int GetDataType()
	{
		return vtkRandomAttributeGenerator_GetDataType_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGenerateCellArray_37(HandleRef pThis);

	/// <summary>
	/// Indicate that an arbitrary cell array is to be generated. The array is
	/// added to the cell data but is not labeled as one of scalars, vectors,
	/// normals, tensors, or texture coordinates array (i.e., AddArray() is
	/// used). Note that the specified number of components is used to create
	/// the array.
	/// </summary>
	public virtual int GetGenerateCellArray()
	{
		return vtkRandomAttributeGenerator_GetGenerateCellArray_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGenerateCellNormals_38(HandleRef pThis);

	/// <summary>
	/// Indicate that cell normals are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual int GetGenerateCellNormals()
	{
		return vtkRandomAttributeGenerator_GetGenerateCellNormals_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGenerateCellScalars_39(HandleRef pThis);

	/// <summary>
	/// Indicate that cell scalars are to be generated. Note that the specified
	/// number of components is used to create the scalar.
	/// </summary>
	public virtual int GetGenerateCellScalars()
	{
		return vtkRandomAttributeGenerator_GetGenerateCellScalars_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGenerateCellTCoords_40(HandleRef pThis);

	/// <summary>
	/// Indicate that cell texture coordinates are to be generated. Note that
	/// the specified number of components is used to create the texture
	/// coordinates (but must range between one and three).
	/// </summary>
	public virtual int GetGenerateCellTCoords()
	{
		return vtkRandomAttributeGenerator_GetGenerateCellTCoords_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGenerateCellTensors_41(HandleRef pThis);

	/// <summary>
	/// Indicate that cell tensors are to be generated. Note that the
	/// number of components is always equal to nine.
	/// </summary>
	public virtual int GetGenerateCellTensors()
	{
		return vtkRandomAttributeGenerator_GetGenerateCellTensors_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGenerateCellVectors_42(HandleRef pThis);

	/// <summary>
	/// Indicate that cell vectors are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual int GetGenerateCellVectors()
	{
		return vtkRandomAttributeGenerator_GetGenerateCellVectors_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGenerateFieldArray_43(HandleRef pThis);

	/// <summary>
	/// Indicate that an arbitrary field data array is to be generated. Note
	/// that the specified number of components is used to create the scalar.
	/// </summary>
	public virtual int GetGenerateFieldArray()
	{
		return vtkRandomAttributeGenerator_GetGenerateFieldArray_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGeneratePointArray_44(HandleRef pThis);

	/// <summary>
	/// Indicate that an arbitrary point array is to be generated. The array is
	/// added to the points data but is not labeled as one of scalars, vectors,
	/// normals, tensors, or texture coordinates (i.e., AddArray() is
	/// used). Note that the specified number of components is used to create
	/// the array.
	/// </summary>
	public virtual int GetGeneratePointArray()
	{
		return vtkRandomAttributeGenerator_GetGeneratePointArray_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGeneratePointNormals_45(HandleRef pThis);

	/// <summary>
	/// Indicate that point normals are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual int GetGeneratePointNormals()
	{
		return vtkRandomAttributeGenerator_GetGeneratePointNormals_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGeneratePointScalars_46(HandleRef pThis);

	/// <summary>
	/// Indicate that point scalars are to be generated. Note that the specified
	/// number of components is used to create the scalar.
	/// </summary>
	public virtual int GetGeneratePointScalars()
	{
		return vtkRandomAttributeGenerator_GetGeneratePointScalars_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGeneratePointTCoords_47(HandleRef pThis);

	/// <summary>
	/// Indicate that point texture coordinates are to be generated. Note that
	/// the specified number of components is used to create the texture
	/// coordinates (but must range between one and three).
	/// </summary>
	public virtual int GetGeneratePointTCoords()
	{
		return vtkRandomAttributeGenerator_GetGeneratePointTCoords_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGeneratePointTensors_48(HandleRef pThis);

	/// <summary>
	/// Indicate that point tensors are to be generated. Note that the
	/// number of components is always equal to nine.
	/// </summary>
	public virtual int GetGeneratePointTensors()
	{
		return vtkRandomAttributeGenerator_GetGeneratePointTensors_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetGeneratePointVectors_49(HandleRef pThis);

	/// <summary>
	/// Indicate that point vectors are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual int GetGeneratePointVectors()
	{
		return vtkRandomAttributeGenerator_GetGeneratePointVectors_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRandomAttributeGenerator_GetMaximumComponentValue_50(HandleRef pThis);

	/// <summary>
	/// Set the maximum component value. This applies to all data that is generated,
	/// although normals and tensors have internal constraints that must be
	/// observed.
	/// </summary>
	public virtual double GetMaximumComponentValue()
	{
		return vtkRandomAttributeGenerator_GetMaximumComponentValue_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRandomAttributeGenerator_GetMinimumComponentValue_51(HandleRef pThis);

	/// <summary>
	/// Set the minimum component value. This applies to all data that is generated,
	/// although normals and tensors have internal constraints that must be
	/// observed.
	/// </summary>
	public virtual double GetMinimumComponentValue()
	{
		return vtkRandomAttributeGenerator_GetMinimumComponentValue_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetNumberOfComponents_52(HandleRef pThis);

	/// <summary>
	/// Specify the number of components to generate. This value only applies to those
	/// attribute types that take a variable number of components. For example, a vector
	/// is only three components so the number of components is not applicable; whereas
	/// a scalar may support multiple, varying number of components.
	/// </summary>
	public virtual int GetNumberOfComponents()
	{
		return vtkRandomAttributeGenerator_GetNumberOfComponents_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetNumberOfComponentsMaxValue_53(HandleRef pThis);

	/// <summary>
	/// Specify the number of components to generate. This value only applies to those
	/// attribute types that take a variable number of components. For example, a vector
	/// is only three components so the number of components is not applicable; whereas
	/// a scalar may support multiple, varying number of components.
	/// </summary>
	public virtual int GetNumberOfComponentsMaxValue()
	{
		return vtkRandomAttributeGenerator_GetNumberOfComponentsMaxValue_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_GetNumberOfComponentsMinValue_54(HandleRef pThis);

	/// <summary>
	/// Specify the number of components to generate. This value only applies to those
	/// attribute types that take a variable number of components. For example, a vector
	/// is only three components so the number of components is not applicable; whereas
	/// a scalar may support multiple, varying number of components.
	/// </summary>
	public virtual int GetNumberOfComponentsMinValue()
	{
		return vtkRandomAttributeGenerator_GetNumberOfComponentsMinValue_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomAttributeGenerator_GetNumberOfGenerationsFromBase_55(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRandomAttributeGenerator_GetNumberOfGenerationsFromBase_55(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomAttributeGenerator_GetNumberOfGenerationsFromBaseType_56(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRandomAttributeGenerator_GetNumberOfGenerationsFromBaseType_56(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomAttributeGenerator_GetNumberOfTuples_57(HandleRef pThis);

	/// <summary>
	/// Specify the number of tuples to generate. This value only applies when creating
	/// general field data. In all other cases (i.e., point data or cell data), the number
	/// of tuples is controlled by the number of points and cells, respectively.
	/// </summary>
	public virtual long GetNumberOfTuples()
	{
		return vtkRandomAttributeGenerator_GetNumberOfTuples_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomAttributeGenerator_GetNumberOfTuplesMaxValue_58(HandleRef pThis);

	/// <summary>
	/// Specify the number of tuples to generate. This value only applies when creating
	/// general field data. In all other cases (i.e., point data or cell data), the number
	/// of tuples is controlled by the number of points and cells, respectively.
	/// </summary>
	public virtual long GetNumberOfTuplesMaxValue()
	{
		return vtkRandomAttributeGenerator_GetNumberOfTuplesMaxValue_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomAttributeGenerator_GetNumberOfTuplesMinValue_59(HandleRef pThis);

	/// <summary>
	/// Specify the number of tuples to generate. This value only applies when creating
	/// general field data. In all other cases (i.e., point data or cell data), the number
	/// of tuples is controlled by the number of points and cells, respectively.
	/// </summary>
	public virtual long GetNumberOfTuplesMinValue()
	{
		return vtkRandomAttributeGenerator_GetNumberOfTuplesMinValue_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_IsA_60(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRandomAttributeGenerator_IsA_60(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomAttributeGenerator_IsTypeOf_61(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRandomAttributeGenerator_IsTypeOf_61(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomAttributeGenerator_NewInstance_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new vtkRandomAttributeGenerator NewInstance()
	{
		vtkRandomAttributeGenerator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomAttributeGenerator_NewInstance_63(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRandomAttributeGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomAttributeGenerator_SafeDownCast_64(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtkRandomAttributeGenerator SafeDownCast(vtkObjectBase o)
	{
		vtkRandomAttributeGenerator vtkRandomAttributeGenerator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomAttributeGenerator_SafeDownCast_64(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRandomAttributeGenerator2 = (vtkRandomAttributeGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRandomAttributeGenerator2.Register(null);
			}
		}
		return vtkRandomAttributeGenerator2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetAttributesConstantPerBlock_65(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate that the generated attributes are
	/// constant within a block. This can be used to highlight
	/// blocks in a composite dataset.
	/// </summary>
	public virtual void SetAttributesConstantPerBlock(bool _arg)
	{
		vtkRandomAttributeGenerator_SetAttributesConstantPerBlock_65(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetComponentRange_66(HandleRef pThis, double minimumValue, double maximumValue);

	/// <summary>
	/// Set the minimum component value. This applies to all data that is generated,
	/// although normals and tensors have internal constraints that must be
	/// observed.
	/// </summary>
	public void SetComponentRange(double minimumValue, double maximumValue)
	{
		vtkRandomAttributeGenerator_SetComponentRange_66(GetCppThis(), minimumValue, maximumValue);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataType_67(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public virtual void SetDataType(int _arg)
	{
		vtkRandomAttributeGenerator_SetDataType_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToBit_68(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToBit()
	{
		vtkRandomAttributeGenerator_SetDataTypeToBit_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToChar_69(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToChar()
	{
		vtkRandomAttributeGenerator_SetDataTypeToChar_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToDouble_70(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToDouble()
	{
		vtkRandomAttributeGenerator_SetDataTypeToDouble_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToFloat_71(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToFloat()
	{
		vtkRandomAttributeGenerator_SetDataTypeToFloat_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToIdType_72(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToIdType()
	{
		vtkRandomAttributeGenerator_SetDataTypeToIdType_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToInt_73(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToInt()
	{
		vtkRandomAttributeGenerator_SetDataTypeToInt_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToLong_74(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToLong()
	{
		vtkRandomAttributeGenerator_SetDataTypeToLong_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToLongLong_75(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToLongLong()
	{
		vtkRandomAttributeGenerator_SetDataTypeToLongLong_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToShort_76(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToShort()
	{
		vtkRandomAttributeGenerator_SetDataTypeToShort_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedChar_77(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToUnsignedChar()
	{
		vtkRandomAttributeGenerator_SetDataTypeToUnsignedChar_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedInt_78(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToUnsignedInt()
	{
		vtkRandomAttributeGenerator_SetDataTypeToUnsignedInt_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedLong_79(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToUnsignedLong()
	{
		vtkRandomAttributeGenerator_SetDataTypeToUnsignedLong_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedLongLong_80(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToUnsignedLongLong()
	{
		vtkRandomAttributeGenerator_SetDataTypeToUnsignedLongLong_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedShort_81(HandleRef pThis);

	/// <summary>
	/// Specify the type of array to create (all components of this array are of this
	/// type). This holds true for all arrays that are created.
	/// </summary>
	public void SetDataTypeToUnsignedShort()
	{
		vtkRandomAttributeGenerator_SetDataTypeToUnsignedShort_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGenerateCellArray_82(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that an arbitrary cell array is to be generated. The array is
	/// added to the cell data but is not labeled as one of scalars, vectors,
	/// normals, tensors, or texture coordinates array (i.e., AddArray() is
	/// used). Note that the specified number of components is used to create
	/// the array.
	/// </summary>
	public virtual void SetGenerateCellArray(int _arg)
	{
		vtkRandomAttributeGenerator_SetGenerateCellArray_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGenerateCellNormals_83(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that cell normals are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void SetGenerateCellNormals(int _arg)
	{
		vtkRandomAttributeGenerator_SetGenerateCellNormals_83(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGenerateCellScalars_84(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that cell scalars are to be generated. Note that the specified
	/// number of components is used to create the scalar.
	/// </summary>
	public virtual void SetGenerateCellScalars(int _arg)
	{
		vtkRandomAttributeGenerator_SetGenerateCellScalars_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGenerateCellTCoords_85(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that cell texture coordinates are to be generated. Note that
	/// the specified number of components is used to create the texture
	/// coordinates (but must range between one and three).
	/// </summary>
	public virtual void SetGenerateCellTCoords(int _arg)
	{
		vtkRandomAttributeGenerator_SetGenerateCellTCoords_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGenerateCellTensors_86(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that cell tensors are to be generated. Note that the
	/// number of components is always equal to nine.
	/// </summary>
	public virtual void SetGenerateCellTensors(int _arg)
	{
		vtkRandomAttributeGenerator_SetGenerateCellTensors_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGenerateCellVectors_87(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that cell vectors are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void SetGenerateCellVectors(int _arg)
	{
		vtkRandomAttributeGenerator_SetGenerateCellVectors_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGenerateFieldArray_88(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that an arbitrary field data array is to be generated. Note
	/// that the specified number of components is used to create the scalar.
	/// </summary>
	public virtual void SetGenerateFieldArray(int _arg)
	{
		vtkRandomAttributeGenerator_SetGenerateFieldArray_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGeneratePointArray_89(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that an arbitrary point array is to be generated. The array is
	/// added to the points data but is not labeled as one of scalars, vectors,
	/// normals, tensors, or texture coordinates (i.e., AddArray() is
	/// used). Note that the specified number of components is used to create
	/// the array.
	/// </summary>
	public virtual void SetGeneratePointArray(int _arg)
	{
		vtkRandomAttributeGenerator_SetGeneratePointArray_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGeneratePointNormals_90(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that point normals are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void SetGeneratePointNormals(int _arg)
	{
		vtkRandomAttributeGenerator_SetGeneratePointNormals_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGeneratePointScalars_91(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that point scalars are to be generated. Note that the specified
	/// number of components is used to create the scalar.
	/// </summary>
	public virtual void SetGeneratePointScalars(int _arg)
	{
		vtkRandomAttributeGenerator_SetGeneratePointScalars_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGeneratePointTCoords_92(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that point texture coordinates are to be generated. Note that
	/// the specified number of components is used to create the texture
	/// coordinates (but must range between one and three).
	/// </summary>
	public virtual void SetGeneratePointTCoords(int _arg)
	{
		vtkRandomAttributeGenerator_SetGeneratePointTCoords_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGeneratePointTensors_93(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that point tensors are to be generated. Note that the
	/// number of components is always equal to nine.
	/// </summary>
	public virtual void SetGeneratePointTensors(int _arg)
	{
		vtkRandomAttributeGenerator_SetGeneratePointTensors_93(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetGeneratePointVectors_94(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate that point vectors are to be generated. Note that the
	/// number of components is always equal to three.
	/// </summary>
	public virtual void SetGeneratePointVectors(int _arg)
	{
		vtkRandomAttributeGenerator_SetGeneratePointVectors_94(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetMaximumComponentValue_95(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the maximum component value. This applies to all data that is generated,
	/// although normals and tensors have internal constraints that must be
	/// observed.
	/// </summary>
	public virtual void SetMaximumComponentValue(double _arg)
	{
		vtkRandomAttributeGenerator_SetMaximumComponentValue_95(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetMinimumComponentValue_96(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the minimum component value. This applies to all data that is generated,
	/// although normals and tensors have internal constraints that must be
	/// observed.
	/// </summary>
	public virtual void SetMinimumComponentValue(double _arg)
	{
		vtkRandomAttributeGenerator_SetMinimumComponentValue_96(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetNumberOfComponents_97(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of components to generate. This value only applies to those
	/// attribute types that take a variable number of components. For example, a vector
	/// is only three components so the number of components is not applicable; whereas
	/// a scalar may support multiple, varying number of components.
	/// </summary>
	public virtual void SetNumberOfComponents(int _arg)
	{
		vtkRandomAttributeGenerator_SetNumberOfComponents_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomAttributeGenerator_SetNumberOfTuples_98(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the number of tuples to generate. This value only applies when creating
	/// general field data. In all other cases (i.e., point data or cell data), the number
	/// of tuples is controlled by the number of points and cells, respectively.
	/// </summary>
	public virtual void SetNumberOfTuples(long _arg)
	{
		vtkRandomAttributeGenerator_SetNumberOfTuples_98(GetCppThis(), _arg);
	}
}
