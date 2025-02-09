using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkArrayCalculator
/// </summary>
/// <remarks>
///    perform mathematical operations on data in field data arrays
///
/// vtkArrayCalculator performs operations on vectors or scalars in field
/// data arrays.  It uses vtkFunctionParser/vtkExprTkFunctionParser to do
/// the parsing and to evaluate the function for each entry in the input
/// arrays.  The arrays used in a given function must be all in point data
/// or all in cell data. The resulting array will be stored as a field
/// data array.  The result array can either be stored in a new array or
/// it can overwrite an existing array. vtkArrayCalculator can run in
/// parallel using vtkSMPTools.
///
/// The functions that this array calculator understands is:
///
/// standard operations:
/// +
/// -
/// *
/// /
/// ^
/// . (only by vtkFunctionParser)
/// build unit vectors: iHat, jHat, kHat (ie (1,0,0), (0,1,0), (0,0,1))
/// abs
/// acos
/// asin
/// atan
/// ceil
/// cos
/// cosh
/// exp
/// floor
/// ln
/// mag
/// min
/// max
/// norm
/// dot (only by vtkExprTkFunctionParser)
/// cross
/// sign
/// sin
/// sinh
/// sqrt
/// tan
/// tanh
///
/// Note that some of these operations work on scalars, some on vectors, and some on
/// both (e.g., you can multiply a scalar times a vector). The operations are performed
/// tuple-wise (i.e., tuple-by-tuple). The user must specify which arrays to use as
/// vectors and/or scalars, and the name of the output data array.
///
/// </remarks>
/// <seealso>
///
/// For more detailed documentation of the supported functionality see:
/// 1) vtkFunctionParser
/// 2) vtkExprTkFunctionParser (default)
/// </seealso>
public class vtkArrayCalculator : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Enum that includes the types of parsers that can be used.
	/// </summary>
	public enum FunctionParserTypes
	{
		/// <summary>enum member</summary>
		ExprTkFunctionParser = 1,
		/// <summary>enum member</summary>
		FunctionParser = 0,
		/// <summary>enum member</summary>
		NumberOfFunctionParserTypes = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkArrayCalculator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkArrayCalculator()
	{
		MRClassNameKey = "class vtkArrayCalculator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayCalculator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkArrayCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArrayCalculator New()
	{
		vtkArrayCalculator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayCalculator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrayCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkArrayCalculator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkArrayCalculator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkArrayCalculator_AddCoordinateScalarVariable_01(HandleRef pThis, string variableName, int component);

	/// <summary>
	/// Add a variable name, a corresponding array name, and which components of
	/// the array to use. The variable name should be sanitized or in quotes.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void AddCoordinateScalarVariable(string variableName, int component)
	{
		vtkArrayCalculator_AddCoordinateScalarVariable_01(GetCppThis(), variableName, component);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_AddCoordinateVectorVariable_02(HandleRef pThis, string variableName, int component0, int component1, int component2);

	/// <summary>
	/// Add a variable name, a corresponding array name, and which components of
	/// the array to use. The variable name should be sanitized or in quotes.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void AddCoordinateVectorVariable(string variableName, int component0, int component1, int component2)
	{
		vtkArrayCalculator_AddCoordinateVectorVariable_02(GetCppThis(), variableName, component0, component1, component2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_AddScalarArrayName_03(HandleRef pThis, string arrayName, int component);

	/// <summary>
	/// Add an array name to the list of arrays used in the function and specify
	/// which components of the array to use in evaluating the function. The
	/// array name must match the name in the function. If the array name is not
	/// sanitized, the variable name will be the array name enclosed in quotes.
	/// Use AddScalarVariable or AddVectorVariable to use a user defined
	/// variable name.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void AddScalarArrayName(string arrayName, int component)
	{
		vtkArrayCalculator_AddScalarArrayName_03(GetCppThis(), arrayName, component);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_AddScalarVariable_04(HandleRef pThis, string variableName, string arrayName, int component);

	/// <summary>
	/// Add a variable name, a corresponding array name, and which components of
	/// the array to use. The variable name should be sanitized or in quotes.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void AddScalarVariable(string variableName, string arrayName, int component)
	{
		vtkArrayCalculator_AddScalarVariable_04(GetCppThis(), variableName, arrayName, component);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_AddVectorArrayName_05(HandleRef pThis, string arrayName, int component0, int component1, int component2);

	/// <summary>
	/// Add an array name to the list of arrays used in the function and specify
	/// which components of the array to use in evaluating the function. The
	/// array name must match the name in the function. If the array name is not
	/// sanitized, the variable name will be the array name enclosed in quotes.
	/// Use AddScalarVariable or AddVectorVariable to use a user defined
	/// variable name.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void AddVectorArrayName(string arrayName, int component0, int component1, int component2)
	{
		vtkArrayCalculator_AddVectorArrayName_05(GetCppThis(), arrayName, component0, component1, component2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_AddVectorVariable_06(HandleRef pThis, string variableName, string arrayName, int component0, int component1, int component2);

	/// <summary>
	/// Add a variable name, a corresponding array name, and which components of
	/// the array to use. The variable name should be sanitized or in quotes.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void AddVectorVariable(string variableName, string arrayName, int component0, int component1, int component2)
	{
		vtkArrayCalculator_AddVectorVariable_06(GetCppThis(), variableName, arrayName, component0, component1, component2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_CoordinateResultsOff_07(HandleRef pThis);

	/// <summary>
	/// Set whether to output results as coordinates.  ResultArrayName will be
	/// ignored.  Outputting as coordinates is only valid with vector results and
	/// if the AttributeMode is AttributeModeToUsePointData.
	/// If a valid output can't be made, an error will occur.
	/// </summary>
	public virtual void CoordinateResultsOff()
	{
		vtkArrayCalculator_CoordinateResultsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_CoordinateResultsOn_08(HandleRef pThis);

	/// <summary>
	/// Set whether to output results as coordinates.  ResultArrayName will be
	/// ignored.  Outputting as coordinates is only valid with vector results and
	/// if the AttributeMode is AttributeModeToUsePointData.
	/// If a valid output can't be made, an error will occur.
	/// </summary>
	public virtual void CoordinateResultsOn()
	{
		vtkArrayCalculator_CoordinateResultsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayCalculator_GetAttributeType_09(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
	/// on the input data type.  The input value for this function should be one of the
	/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
	/// </summary>
	public virtual int GetAttributeType()
	{
		return vtkArrayCalculator_GetAttributeType_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayCalculator_GetAttributeTypeAsString_10(HandleRef pThis);

	/// <summary>
	/// Returns a string representation of the calculator's AttributeType
	/// </summary>
	public string GetAttributeTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkArrayCalculator_GetAttributeTypeAsString_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayCalculator_GetCoordinateResults_11(HandleRef pThis);

	/// <summary>
	/// Set whether to output results as coordinates.  ResultArrayName will be
	/// ignored.  Outputting as coordinates is only valid with vector results and
	/// if the AttributeMode is AttributeModeToUsePointData.
	/// If a valid output can't be made, an error will occur.
	/// </summary>
	public virtual int GetCoordinateResults()
	{
		return vtkArrayCalculator_GetCoordinateResults_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayCalculator_GetDataSetOutput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the output of the filter downcast to a vtkDataSet or nullptr if the
	/// cast fails.
	/// </summary>
	public vtkDataSet GetDataSetOutput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayCalculator_GetDataSetOutput_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkArrayCalculator_GetFunction_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the function to be evaluated.
	/// </summary>
	public virtual string GetFunction()
	{
		return Marshal.PtrToStringAnsi(vtkArrayCalculator_GetFunction_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern FunctionParserTypes vtkArrayCalculator_GetFunctionParserType_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the FunctionParser type that will be used.
	/// vtkFunctionParser = 0, vtkExprTkFunctionParser = 1. Default is 1.
	/// </summary>
	public virtual FunctionParserTypes GetFunctionParserType()
	{
		return vtkArrayCalculator_GetFunctionParserType_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrayCalculator_GetIgnoreMissingArrays_15(HandleRef pThis);

	/// <summary>
	/// When this option is set, silently ignore datasets where the requested field
	/// data array is not present. When an input array is not present, the result array
	/// will not be generated nor added to the output.
	/// </summary>
	public virtual bool GetIgnoreMissingArrays()
	{
		return (vtkArrayCalculator_GetIgnoreMissingArrays_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrayCalculator_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkArrayCalculator_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrayCalculator_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkArrayCalculator_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayCalculator_GetNumberOfScalarArrays_18(HandleRef pThis);

	/// <summary>
	/// Methods to get information about the current variables.
	/// </summary>
	public int GetNumberOfScalarArrays()
	{
		return vtkArrayCalculator_GetNumberOfScalarArrays_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayCalculator_GetNumberOfVectorArrays_19(HandleRef pThis);

	/// <summary>
	/// Methods to get information about the current variables.
	/// </summary>
	public int GetNumberOfVectorArrays()
	{
		return vtkArrayCalculator_GetNumberOfVectorArrays_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayCalculator_GetReplaceInvalidValues_20(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported.
	/// </summary>
	public virtual int GetReplaceInvalidValues()
	{
		return vtkArrayCalculator_GetReplaceInvalidValues_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkArrayCalculator_GetReplacementValue_21(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported.
	/// </summary>
	public virtual double GetReplacementValue()
	{
		return vtkArrayCalculator_GetReplacementValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayCalculator_GetResultArrayName_22(HandleRef pThis);

	/// <summary>
	/// Set the name of the array in which to store the result of
	/// evaluating this function.  If this is the name of an existing array,
	/// that array will be overwritten.  Otherwise a new array will be
	/// created with the specified name.
	/// </summary>
	public virtual string GetResultArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkArrayCalculator_GetResultArrayName_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayCalculator_GetResultArrayType_23(HandleRef pThis);

	/// <summary>
	/// Type of the result array. It is ignored if CoordinateResults is true.
	/// Initial value is VTK_DOUBLE.
	/// </summary>
	public virtual int GetResultArrayType()
	{
		return vtkArrayCalculator_GetResultArrayType_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrayCalculator_GetResultNormals_24(HandleRef pThis);

	/// <summary>
	/// Set whether to output results as point/cell normals. Outputting as
	/// normals is only valid with vector results. Point or cell normals are
	/// selected using AttributeMode.
	/// </summary>
	public virtual bool GetResultNormals()
	{
		return (vtkArrayCalculator_GetResultNormals_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrayCalculator_GetResultTCoords_25(HandleRef pThis);

	/// <summary>
	/// Set whether to output results as point/cell texture coordinates.
	/// Point or cell texture coordinates are selected using AttributeMode.
	/// 2-component texture coordinates cannot be generated at this time.
	/// </summary>
	public virtual bool GetResultTCoords()
	{
		return (vtkArrayCalculator_GetResultTCoords_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayCalculator_GetScalarArrayName_26(HandleRef pThis, int i);

	/// <summary>
	/// Methods to get information about the current variables.
	/// </summary>
	public string GetScalarArrayName(int i)
	{
		return vtkArrayCalculator_GetScalarArrayName_26(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayCalculator_GetScalarVariableName_27(HandleRef pThis, int i);

	/// <summary>
	/// Methods to get information about the current variables.
	/// </summary>
	public string GetScalarVariableName(int i)
	{
		return vtkArrayCalculator_GetScalarVariableName_27(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayCalculator_GetSelectedScalarComponent_28(HandleRef pThis, int i);

	/// <summary>
	/// Methods to get information about the current variables.
	/// </summary>
	public int GetSelectedScalarComponent(int i)
	{
		return vtkArrayCalculator_GetSelectedScalarComponent_28(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayCalculator_GetVectorArrayName_29(HandleRef pThis, int i);

	/// <summary>
	/// Methods to get information about the current variables.
	/// </summary>
	public string GetVectorArrayName(int i)
	{
		return vtkArrayCalculator_GetVectorArrayName_29(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayCalculator_GetVectorVariableName_30(HandleRef pThis, int i);

	/// <summary>
	/// Methods to get information about the current variables.
	/// </summary>
	public string GetVectorVariableName(int i)
	{
		return vtkArrayCalculator_GetVectorVariableName_30(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_IgnoreMissingArraysOff_31(HandleRef pThis);

	/// <summary>
	/// When this option is set, silently ignore datasets where the requested field
	/// data array is not present. When an input array is not present, the result array
	/// will not be generated nor added to the output.
	/// </summary>
	public virtual void IgnoreMissingArraysOff()
	{
		vtkArrayCalculator_IgnoreMissingArraysOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_IgnoreMissingArraysOn_32(HandleRef pThis);

	/// <summary>
	/// When this option is set, silently ignore datasets where the requested field
	/// data array is not present. When an input array is not present, the result array
	/// will not be generated nor added to the output.
	/// </summary>
	public virtual void IgnoreMissingArraysOn()
	{
		vtkArrayCalculator_IgnoreMissingArraysOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayCalculator_IsA_33(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkArrayCalculator_IsA_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayCalculator_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkArrayCalculator_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayCalculator_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkArrayCalculator NewInstance()
	{
		vtkArrayCalculator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayCalculator_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrayCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_RemoveAllVariables_37(HandleRef pThis);

	/// <summary>
	/// Remove all the variable names and their associated array names.
	/// </summary>
	public void RemoveAllVariables()
	{
		vtkArrayCalculator_RemoveAllVariables_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_RemoveCoordinateScalarVariables_38(HandleRef pThis);

	/// <summary>
	/// Remove all the coordinate variables.
	/// </summary>
	public virtual void RemoveCoordinateScalarVariables()
	{
		vtkArrayCalculator_RemoveCoordinateScalarVariables_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_RemoveCoordinateVectorVariables_39(HandleRef pThis);

	/// <summary>
	/// Remove all the coordinate variables.
	/// </summary>
	public virtual void RemoveCoordinateVectorVariables()
	{
		vtkArrayCalculator_RemoveCoordinateVectorVariables_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_RemoveScalarVariables_40(HandleRef pThis);

	/// <summary>
	/// Remove all the scalar variable names and their associated array names.
	/// </summary>
	public virtual void RemoveScalarVariables()
	{
		vtkArrayCalculator_RemoveScalarVariables_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_RemoveVectorVariables_41(HandleRef pThis);

	/// <summary>
	/// Remove all the scalar variable names and their associated array names.
	/// </summary>
	public virtual void RemoveVectorVariables()
	{
		vtkArrayCalculator_RemoveVectorVariables_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_ReplaceInvalidValuesOff_42(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported.
	/// </summary>
	public virtual void ReplaceInvalidValuesOff()
	{
		vtkArrayCalculator_ReplaceInvalidValuesOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_ReplaceInvalidValuesOn_43(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported.
	/// </summary>
	public virtual void ReplaceInvalidValuesOn()
	{
		vtkArrayCalculator_ReplaceInvalidValuesOn_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_ResultNormalsOff_44(HandleRef pThis);

	/// <summary>
	/// Set whether to output results as point/cell normals. Outputting as
	/// normals is only valid with vector results. Point or cell normals are
	/// selected using AttributeMode.
	/// </summary>
	public virtual void ResultNormalsOff()
	{
		vtkArrayCalculator_ResultNormalsOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_ResultNormalsOn_45(HandleRef pThis);

	/// <summary>
	/// Set whether to output results as point/cell normals. Outputting as
	/// normals is only valid with vector results. Point or cell normals are
	/// selected using AttributeMode.
	/// </summary>
	public virtual void ResultNormalsOn()
	{
		vtkArrayCalculator_ResultNormalsOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_ResultTCoordsOff_46(HandleRef pThis);

	/// <summary>
	/// Set whether to output results as point/cell texture coordinates.
	/// Point or cell texture coordinates are selected using AttributeMode.
	/// 2-component texture coordinates cannot be generated at this time.
	/// </summary>
	public virtual void ResultTCoordsOff()
	{
		vtkArrayCalculator_ResultTCoordsOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_ResultTCoordsOn_47(HandleRef pThis);

	/// <summary>
	/// Set whether to output results as point/cell texture coordinates.
	/// Point or cell texture coordinates are selected using AttributeMode.
	/// 2-component texture coordinates cannot be generated at this time.
	/// </summary>
	public virtual void ResultTCoordsOn()
	{
		vtkArrayCalculator_ResultTCoordsOn_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayCalculator_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArrayCalculator SafeDownCast(vtkObjectBase o)
	{
		vtkArrayCalculator vtkArrayCalculator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayCalculator_SafeDownCast_48(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArrayCalculator2 = (vtkArrayCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArrayCalculator2.Register(null);
			}
		}
		return vtkArrayCalculator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetAttributeType_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
	/// on the input data type.  The input value for this function should be one of the
	/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
	/// </summary>
	public virtual void SetAttributeType(int _arg)
	{
		vtkArrayCalculator_SetAttributeType_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetAttributeTypeToCellData_50(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
	/// on the input data type.  The input value for this function should be one of the
	/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
	/// </summary>
	public void SetAttributeTypeToCellData()
	{
		vtkArrayCalculator_SetAttributeTypeToCellData_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetAttributeTypeToDefault_51(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
	/// on the input data type.  The input value for this function should be one of the
	/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
	/// </summary>
	public void SetAttributeTypeToDefault()
	{
		vtkArrayCalculator_SetAttributeTypeToDefault_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetAttributeTypeToEdgeData_52(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
	/// on the input data type.  The input value for this function should be one of the
	/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
	/// </summary>
	public void SetAttributeTypeToEdgeData()
	{
		vtkArrayCalculator_SetAttributeTypeToEdgeData_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetAttributeTypeToPointData_53(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
	/// on the input data type.  The input value for this function should be one of the
	/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
	/// </summary>
	public void SetAttributeTypeToPointData()
	{
		vtkArrayCalculator_SetAttributeTypeToPointData_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetAttributeTypeToRowData_54(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
	/// on the input data type.  The input value for this function should be one of the
	/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
	/// </summary>
	public void SetAttributeTypeToRowData()
	{
		vtkArrayCalculator_SetAttributeTypeToRowData_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetAttributeTypeToVertexData_55(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
	/// on the input data type.  The input value for this function should be one of the
	/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
	/// </summary>
	public void SetAttributeTypeToVertexData()
	{
		vtkArrayCalculator_SetAttributeTypeToVertexData_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetCoordinateResults_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to output results as coordinates.  ResultArrayName will be
	/// ignored.  Outputting as coordinates is only valid with vector results and
	/// if the AttributeMode is AttributeModeToUsePointData.
	/// If a valid output can't be made, an error will occur.
	/// </summary>
	public virtual void SetCoordinateResults(int _arg)
	{
		vtkArrayCalculator_SetCoordinateResults_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetFunction_57(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the function to be evaluated.
	/// </summary>
	public virtual void SetFunction(string _arg)
	{
		vtkArrayCalculator_SetFunction_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetFunctionParserType_58(HandleRef pThis, FunctionParserTypes _arg);

	/// <summary>
	/// Set/Get the FunctionParser type that will be used.
	/// vtkFunctionParser = 0, vtkExprTkFunctionParser = 1. Default is 1.
	/// </summary>
	public virtual void SetFunctionParserType(FunctionParserTypes _arg)
	{
		vtkArrayCalculator_SetFunctionParserType_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetFunctionParserTypeToExprTkFunctionParser_59(HandleRef pThis);

	/// <summary>
	/// Set/Get the FunctionParser type that will be used.
	/// vtkFunctionParser = 0, vtkExprTkFunctionParser = 1. Default is 1.
	/// </summary>
	public void SetFunctionParserTypeToExprTkFunctionParser()
	{
		vtkArrayCalculator_SetFunctionParserTypeToExprTkFunctionParser_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetFunctionParserTypeToFunctionParser_60(HandleRef pThis);

	/// <summary>
	/// Set/Get the FunctionParser type that will be used.
	/// vtkFunctionParser = 0, vtkExprTkFunctionParser = 1. Default is 1.
	/// </summary>
	public void SetFunctionParserTypeToFunctionParser()
	{
		vtkArrayCalculator_SetFunctionParserTypeToFunctionParser_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetIgnoreMissingArrays_61(HandleRef pThis, byte _arg);

	/// <summary>
	/// When this option is set, silently ignore datasets where the requested field
	/// data array is not present. When an input array is not present, the result array
	/// will not be generated nor added to the output.
	/// </summary>
	public virtual void SetIgnoreMissingArrays(bool _arg)
	{
		vtkArrayCalculator_SetIgnoreMissingArrays_61(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetReplaceInvalidValues_62(HandleRef pThis, int _arg);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported.
	/// </summary>
	public virtual void SetReplaceInvalidValues(int _arg)
	{
		vtkArrayCalculator_SetReplaceInvalidValues_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetReplacementValue_63(HandleRef pThis, double _arg);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported.
	/// </summary>
	public virtual void SetReplacementValue(double _arg)
	{
		vtkArrayCalculator_SetReplacementValue_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetResultArrayName_64(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the array in which to store the result of
	/// evaluating this function.  If this is the name of an existing array,
	/// that array will be overwritten.  Otherwise a new array will be
	/// created with the specified name.
	/// </summary>
	public virtual void SetResultArrayName(string _arg)
	{
		vtkArrayCalculator_SetResultArrayName_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetResultArrayType_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Type of the result array. It is ignored if CoordinateResults is true.
	/// Initial value is VTK_DOUBLE.
	/// </summary>
	public virtual void SetResultArrayType(int _arg)
	{
		vtkArrayCalculator_SetResultArrayType_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetResultNormals_66(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether to output results as point/cell normals. Outputting as
	/// normals is only valid with vector results. Point or cell normals are
	/// selected using AttributeMode.
	/// </summary>
	public virtual void SetResultNormals(bool _arg)
	{
		vtkArrayCalculator_SetResultNormals_66(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayCalculator_SetResultTCoords_67(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether to output results as point/cell texture coordinates.
	/// Point or cell texture coordinates are selected using AttributeMode.
	/// 2-component texture coordinates cannot be generated at this time.
	/// </summary>
	public virtual void SetResultTCoords(bool _arg)
	{
		vtkArrayCalculator_SetResultTCoords_67(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
