using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractTensorComponents
/// </summary>
/// <remarks>
///    extract parts of tensor and create a scalar, vector, normal, or texture coordinates.
///
/// vtkExtractTensorComponents is a filter that extracts components of a
/// tensor to create a scalar, vector, normal, and/or texture coords. For
/// example, if the tensor contains components of stress, then you could
/// extract the normal stress in the x-direction as a scalar (i.e., tensor
/// component (0,0)).
///
/// To use this filter, you must set some boolean flags to control
/// which data is extracted from the tensors, and whether you want to
/// pass the tensor data through to the output. Also, you must specify
/// the tensor component(s) for each type of data you want to
/// extract. The tensor component(s) is(are) specified using matrix notation
/// into a 3x3 matrix. That is, use the (row,column) address to specify
/// a particular tensor component; and if the data you are extracting
/// requires more than one component, use a list of addresses. (Note
/// that the addresses are 0-offset -&gt; (0,0) specifies the upper left
/// corner of the tensor.)
///
/// There are two optional methods to extract scalar data. You can
/// extract the determinant of the tensor, or you can extract the
/// effective stress of the tensor. These require that the ivar
/// ExtractScalars is on, and the appropriate scalar extraction mode is
/// set.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorWidget vtkTensorGlyph vtkPointSmoothingFilter
/// vtkHyperStreamline
/// </seealso>
public class vtkExtractTensorComponents : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractTensorComponents";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractTensorComponents()
	{
		MRClassNameKey = "class vtkExtractTensorComponents";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractTensorComponents"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractTensorComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTensorComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object to extract nothing and to not pass tensor data
	/// through the pipeline.
	/// </summary>
	public new static vtkExtractTensorComponents New()
	{
		vtkExtractTensorComponents result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractTensorComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractTensorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object to extract nothing and to not pass tensor data
	/// through the pipeline.
	/// </summary>
	public vtkExtractTensorComponents()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractTensorComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ExtractNormalsOff_01(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether normal data is extracted from tensor.
	/// </summary>
	public virtual void ExtractNormalsOff()
	{
		vtkExtractTensorComponents_ExtractNormalsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ExtractNormalsOn_02(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether normal data is extracted from tensor.
	/// </summary>
	public virtual void ExtractNormalsOn()
	{
		vtkExtractTensorComponents_ExtractNormalsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ExtractScalarsOff_03(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether scalar data is extracted from the tensors.
	/// </summary>
	public virtual void ExtractScalarsOff()
	{
		vtkExtractTensorComponents_ExtractScalarsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ExtractScalarsOn_04(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether scalar data is extracted from the tensors.
	/// </summary>
	public virtual void ExtractScalarsOn()
	{
		vtkExtractTensorComponents_ExtractScalarsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ExtractTCoordsOff_05(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether texture coordinates are extracted from tensor.
	/// </summary>
	public virtual void ExtractTCoordsOff()
	{
		vtkExtractTensorComponents_ExtractTCoordsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ExtractTCoordsOn_06(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether texture coordinates are extracted from tensor.
	/// </summary>
	public virtual void ExtractTCoordsOn()
	{
		vtkExtractTensorComponents_ExtractTCoordsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ExtractVectorsOff_07(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether vector data is extracted from tensor.
	/// </summary>
	public virtual void ExtractVectorsOff()
	{
		vtkExtractTensorComponents_ExtractVectorsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ExtractVectorsOn_08(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether vector data is extracted from tensor.
	/// </summary>
	public virtual void ExtractVectorsOn()
	{
		vtkExtractTensorComponents_ExtractVectorsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetExtractNormals_09(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether normal data is extracted from tensor.
	/// </summary>
	public virtual int GetExtractNormals()
	{
		return vtkExtractTensorComponents_GetExtractNormals_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetExtractScalars_10(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether scalar data is extracted from the tensors.
	/// </summary>
	public virtual int GetExtractScalars()
	{
		return vtkExtractTensorComponents_GetExtractScalars_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetExtractTCoords_11(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether texture coordinates are extracted from tensor.
	/// </summary>
	public virtual int GetExtractTCoords()
	{
		return vtkExtractTensorComponents_GetExtractTCoords_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetExtractVectors_12(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether vector data is extracted from tensor.
	/// </summary>
	public virtual int GetExtractVectors()
	{
		return vtkExtractTensorComponents_GetExtractVectors_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTensorComponents_GetNormalComponents_13(HandleRef pThis);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector.
	/// </summary>
	public virtual int[] GetNormalComponents()
	{
		IntPtr intPtr = vtkExtractTensorComponents_GetNormalComponents_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_GetNormalComponents_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector.
	/// </summary>
	public virtual void GetNormalComponents(IntPtr data)
	{
		vtkExtractTensorComponents_GetNormalComponents_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetNormalizeNormals_15(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether normal vector is converted to unit normal
	/// after extraction.
	/// </summary>
	public virtual int GetNormalizeNormals()
	{
		return vtkExtractTensorComponents_GetNormalizeNormals_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractTensorComponents_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractTensorComponents_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractTensorComponents_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractTensorComponents_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetNumberOfTCoords_18(HandleRef pThis);

	/// <summary>
	/// Set the dimension of the texture coordinates to extract.
	/// </summary>
	public virtual int GetNumberOfTCoords()
	{
		return vtkExtractTensorComponents_GetNumberOfTCoords_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetNumberOfTCoordsMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set the dimension of the texture coordinates to extract.
	/// </summary>
	public virtual int GetNumberOfTCoordsMaxValue()
	{
		return vtkExtractTensorComponents_GetNumberOfTCoordsMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetNumberOfTCoordsMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set the dimension of the texture coordinates to extract.
	/// </summary>
	public virtual int GetNumberOfTCoordsMinValue()
	{
		return vtkExtractTensorComponents_GetNumberOfTCoordsMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetOutputPrecision_21(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings. Note that any data that
	/// is simply passed through the filter to its output retains its input
	/// type, only newly created data added to the output is affected by this
	/// flag. By default the output type is the same as the input tensor type.
	/// </summary>
	public virtual int GetOutputPrecision()
	{
		return vtkExtractTensorComponents_GetOutputPrecision_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetPassTensorsToOutput_22(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether tensor data is passed through to the output.
	/// </summary>
	public virtual int GetPassTensorsToOutput()
	{
		return vtkExtractTensorComponents_GetPassTensorsToOutput_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTensorComponents_GetScalarComponents_23(HandleRef pThis);

	/// <summary>
	/// Specify the (row,column) tensor component to extract as a scalar.
	/// </summary>
	public virtual int[] GetScalarComponents()
	{
		IntPtr intPtr = vtkExtractTensorComponents_GetScalarComponents_23(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_GetScalarComponents_24(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the (row,column) tensor component to extract as a scalar.
	/// </summary>
	public virtual void GetScalarComponents(IntPtr data)
	{
		vtkExtractTensorComponents_GetScalarComponents_24(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_GetScalarMode_25(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public virtual int GetScalarMode()
	{
		return vtkExtractTensorComponents_GetScalarMode_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTensorComponents_GetTCoordComponents_26(HandleRef pThis);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector. Up to NumberOfTCoords
	/// components are extracted.
	/// </summary>
	public virtual int[] GetTCoordComponents()
	{
		IntPtr intPtr = vtkExtractTensorComponents_GetTCoordComponents_26(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_GetTCoordComponents_27(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector. Up to NumberOfTCoords
	/// components are extracted.
	/// </summary>
	public virtual void GetTCoordComponents(IntPtr data)
	{
		vtkExtractTensorComponents_GetTCoordComponents_27(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTensorComponents_GetVectorComponents_28(HandleRef pThis);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector.
	/// </summary>
	public virtual int[] GetVectorComponents()
	{
		IntPtr intPtr = vtkExtractTensorComponents_GetVectorComponents_28(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_GetVectorComponents_29(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector.
	/// </summary>
	public virtual void GetVectorComponents(IntPtr data)
	{
		vtkExtractTensorComponents_GetVectorComponents_29(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_IsA_30(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractTensorComponents_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTensorComponents_IsTypeOf_31(string type);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractTensorComponents_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTensorComponents_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public new vtkExtractTensorComponents NewInstance()
	{
		vtkExtractTensorComponents result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractTensorComponents_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractTensorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_NormalizeNormalsOff_34(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether normal vector is converted to unit normal
	/// after extraction.
	/// </summary>
	public virtual void NormalizeNormalsOff()
	{
		vtkExtractTensorComponents_NormalizeNormalsOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_NormalizeNormalsOn_35(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether normal vector is converted to unit normal
	/// after extraction.
	/// </summary>
	public virtual void NormalizeNormalsOn()
	{
		vtkExtractTensorComponents_NormalizeNormalsOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_PassTensorsToOutputOff_36(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether tensor data is passed through to the output.
	/// </summary>
	public virtual void PassTensorsToOutputOff()
	{
		vtkExtractTensorComponents_PassTensorsToOutputOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_PassTensorsToOutputOn_37(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether tensor data is passed through to the output.
	/// </summary>
	public virtual void PassTensorsToOutputOn()
	{
		vtkExtractTensorComponents_PassTensorsToOutputOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTensorComponents_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information, and printing.
	/// </summary>
	public new static vtkExtractTensorComponents SafeDownCast(vtkObjectBase o)
	{
		vtkExtractTensorComponents vtkExtractTensorComponents2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractTensorComponents_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractTensorComponents2 = (vtkExtractTensorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractTensorComponents2.Register(null);
			}
		}
		return vtkExtractTensorComponents2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ScalarIsComponent_39(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void ScalarIsComponent()
	{
		vtkExtractTensorComponents_ScalarIsComponent_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ScalarIsDeterminant_40(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void ScalarIsDeterminant()
	{
		vtkExtractTensorComponents_ScalarIsDeterminant_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ScalarIsEffectiveStress_41(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void ScalarIsEffectiveStress()
	{
		vtkExtractTensorComponents_ScalarIsEffectiveStress_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ScalarIsNonNegativeDeterminant_42(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void ScalarIsNonNegativeDeterminant()
	{
		vtkExtractTensorComponents_ScalarIsNonNegativeDeterminant_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_ScalarIsTrace_43(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void ScalarIsTrace()
	{
		vtkExtractTensorComponents_ScalarIsTrace_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetExtractNormals_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether normal data is extracted from tensor.
	/// </summary>
	public virtual void SetExtractNormals(int _arg)
	{
		vtkExtractTensorComponents_SetExtractNormals_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetExtractScalars_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether scalar data is extracted from the tensors.
	/// </summary>
	public virtual void SetExtractScalars(int _arg)
	{
		vtkExtractTensorComponents_SetExtractScalars_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetExtractTCoords_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether texture coordinates are extracted from tensor.
	/// </summary>
	public virtual void SetExtractTCoords(int _arg)
	{
		vtkExtractTensorComponents_SetExtractTCoords_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetExtractVectors_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether vector data is extracted from tensor.
	/// </summary>
	public virtual void SetExtractVectors(int _arg)
	{
		vtkExtractTensorComponents_SetExtractVectors_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetNormalComponents_48(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector.
	/// </summary>
	public virtual void SetNormalComponents(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkExtractTensorComponents_SetNormalComponents_48(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetNormalComponents_49(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector.
	/// </summary>
	public virtual void SetNormalComponents(IntPtr _arg)
	{
		vtkExtractTensorComponents_SetNormalComponents_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetNormalizeNormals_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether normal vector is converted to unit normal
	/// after extraction.
	/// </summary>
	public virtual void SetNormalizeNormals(int _arg)
	{
		vtkExtractTensorComponents_SetNormalizeNormals_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetNumberOfTCoords_51(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the dimension of the texture coordinates to extract.
	/// </summary>
	public virtual void SetNumberOfTCoords(int _arg)
	{
		vtkExtractTensorComponents_SetNumberOfTCoords_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetOutputPrecision_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings. Note that any data that
	/// is simply passed through the filter to its output retains its input
	/// type, only newly created data added to the output is affected by this
	/// flag. By default the output type is the same as the input tensor type.
	/// </summary>
	public virtual void SetOutputPrecision(int _arg)
	{
		vtkExtractTensorComponents_SetOutputPrecision_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetPassTensorsToOutput_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether tensor data is passed through to the output.
	/// </summary>
	public virtual void SetPassTensorsToOutput(int _arg)
	{
		vtkExtractTensorComponents_SetPassTensorsToOutput_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetScalarComponents_54(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify the (row,column) tensor component to extract as a scalar.
	/// </summary>
	public virtual void SetScalarComponents(int _arg1, int _arg2)
	{
		vtkExtractTensorComponents_SetScalarComponents_54(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetScalarComponents_55(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the (row,column) tensor component to extract as a scalar.
	/// </summary>
	public void SetScalarComponents(IntPtr _arg)
	{
		vtkExtractTensorComponents_SetScalarComponents_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetScalarMode_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public virtual void SetScalarMode(int _arg)
	{
		vtkExtractTensorComponents_SetScalarMode_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetScalarModeToComponent_57(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void SetScalarModeToComponent()
	{
		vtkExtractTensorComponents_SetScalarModeToComponent_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetScalarModeToDeterminant_58(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void SetScalarModeToDeterminant()
	{
		vtkExtractTensorComponents_SetScalarModeToDeterminant_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetScalarModeToEffectiveStress_59(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void SetScalarModeToEffectiveStress()
	{
		vtkExtractTensorComponents_SetScalarModeToEffectiveStress_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetScalarModeToNonNegativeDeterminant_60(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void SetScalarModeToNonNegativeDeterminant()
	{
		vtkExtractTensorComponents_SetScalarModeToNonNegativeDeterminant_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetScalarModeToTrace_61(HandleRef pThis);

	/// <summary>
	/// Specify how to extract the scalar. You can extract it as one of the
	/// components of the tensor, as effective stress, as the determinant of the
	/// tensor, a non-negative determinant, or the trace of the tensor
	/// matrix. If you extract a component make sure that you set the
	/// ScalarComponents ivar.
	/// </summary>
	public void SetScalarModeToTrace()
	{
		vtkExtractTensorComponents_SetScalarModeToTrace_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetTCoordComponents_62(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector. Up to NumberOfTCoords
	/// components are extracted.
	/// </summary>
	public virtual void SetTCoordComponents(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkExtractTensorComponents_SetTCoordComponents_62(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetTCoordComponents_63(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector. Up to NumberOfTCoords
	/// components are extracted.
	/// </summary>
	public virtual void SetTCoordComponents(IntPtr _arg)
	{
		vtkExtractTensorComponents_SetTCoordComponents_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetVectorComponents_64(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector.
	/// </summary>
	public virtual void SetVectorComponents(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkExtractTensorComponents_SetVectorComponents_64(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTensorComponents_SetVectorComponents_65(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
	/// components to extract as a vector.
	/// </summary>
	public virtual void SetVectorComponents(IntPtr _arg)
	{
		vtkExtractTensorComponents_SetVectorComponents_65(GetCppThis(), _arg);
	}
}
