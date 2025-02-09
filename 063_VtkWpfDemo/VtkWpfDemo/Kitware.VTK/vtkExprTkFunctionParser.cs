using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExprTkFunctionParser
/// </summary>
/// <remarks>
///    Parse and evaluate a mathematical expression
///
/// vtkExprTkFunctionParser is a wrapper class of the ExprTK library that takes
/// in a mathematical expression as a char string, parses it, and evaluates it
/// at the specified values of the variables in the input string.
///
/// The detailed documentation of the supported functionality is described in
/// https://github.com/ArashPartow/exprtk. In addition to the documented
/// functionality, the following vector operations have been implemented:
/// 1) cross(v1, v2), cross product of two vectors,
/// 2) mag(v), magnitude of a vector,
/// 3) norm(v), the normalized version of a vector.
///
/// @par Thanks:
/// Arash Partow for implementing the ExprTk library.
/// </remarks>
public class vtkExprTkFunctionParser : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExprTkFunctionParser";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExprTkFunctionParser()
	{
		MRClassNameKey = "class vtkExprTkFunctionParser";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExprTkFunctionParser"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExprTkFunctionParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExprTkFunctionParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExprTkFunctionParser New()
	{
		vtkExprTkFunctionParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExprTkFunctionParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExprTkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExprTkFunctionParser()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExprTkFunctionParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExprTkFunctionParser_GetFunction_01(HandleRef pThis);

	/// <summary>
	/// Set/Get input string to evaluate.
	/// </summary>
	public string GetFunction()
	{
		return Marshal.PtrToStringAnsi(vtkExprTkFunctionParser_GetFunction_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkExprTkFunctionParser_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// Return parser's MTime
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExprTkFunctionParser_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExprTkFunctionParser_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExprTkFunctionParser_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExprTkFunctionParser_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExprTkFunctionParser_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExprTkFunctionParser_GetNumberOfScalarVariables_05(HandleRef pThis);

	/// <summary>
	/// Get the number of scalar variables.
	/// </summary>
	public int GetNumberOfScalarVariables()
	{
		return vtkExprTkFunctionParser_GetNumberOfScalarVariables_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExprTkFunctionParser_GetNumberOfVectorVariables_06(HandleRef pThis);

	/// <summary>
	/// Get the number of vector variables.
	/// </summary>
	public int GetNumberOfVectorVariables()
	{
		return vtkExprTkFunctionParser_GetNumberOfVectorVariables_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExprTkFunctionParser_GetReplaceInvalidValues_07(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual int GetReplaceInvalidValues()
	{
		return vtkExprTkFunctionParser_GetReplaceInvalidValues_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExprTkFunctionParser_GetReplacementValue_08(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual double GetReplacementValue()
	{
		return vtkExprTkFunctionParser_GetReplacementValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExprTkFunctionParser_GetScalarResult_09(HandleRef pThis);

	/// <summary>
	/// Get a scalar result from evaluating the input function.
	///
	/// If ReplaceInvalidValues is not set, then the error value
	/// that will be return is NaN.
	/// </summary>
	public double GetScalarResult()
	{
		return vtkExprTkFunctionParser_GetScalarResult_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExprTkFunctionParser_GetScalarVariableIndex_10(HandleRef pThis, string name);

	/// <summary>
	/// Get scalar variable index or -1 if not found
	/// </summary>
	public int GetScalarVariableIndex(string name)
	{
		return vtkExprTkFunctionParser_GetScalarVariableIndex_10(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkExprTkFunctionParser_GetScalarVariableName_11(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith scalar variable name.
	/// </summary>
	public string GetScalarVariableName(int i)
	{
		return vtkExprTkFunctionParser_GetScalarVariableName_11(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExprTkFunctionParser_GetScalarVariableNeeded_12(HandleRef pThis, int i);

	/// <summary>
	/// Returns whether a scalar variable is needed for the function evaluation.
	/// This is only valid after a successful Parse(). Thus, call GetScalarResult()
	/// or IsScalarResult() or similar method before calling this.
	/// </summary>
	public bool GetScalarVariableNeeded(int i)
	{
		return (vtkExprTkFunctionParser_GetScalarVariableNeeded_12(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExprTkFunctionParser_GetScalarVariableNeeded_13(HandleRef pThis, string variableName);

	/// <summary>
	/// Returns whether a scalar variable is needed for the function evaluation.
	/// This is only valid after a successful Parse(). Thus, call GetScalarResult()
	/// or IsScalarResult() or similar method before calling this.
	/// </summary>
	public bool GetScalarVariableNeeded(string variableName)
	{
		return (vtkExprTkFunctionParser_GetScalarVariableNeeded_13(GetCppThis(), variableName) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExprTkFunctionParser_GetScalarVariableValue_14(HandleRef pThis, string variableName);

	/// <summary>
	/// Get the value of a scalar variable.
	/// </summary>
	public double GetScalarVariableValue(string variableName)
	{
		return vtkExprTkFunctionParser_GetScalarVariableValue_14(GetCppThis(), variableName);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExprTkFunctionParser_GetScalarVariableValue_15(HandleRef pThis, int i);

	/// <summary>
	/// Get the value of a scalar variable.
	/// </summary>
	public double GetScalarVariableValue(int i)
	{
		return vtkExprTkFunctionParser_GetScalarVariableValue_15(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExprTkFunctionParser_GetVectorResult_16(HandleRef pThis);

	/// <summary>
	/// Get a vector result from evaluating the input function.
	///
	/// If ReplaceInvalidValues is not set, then the error value
	/// that will be return is [NaN, NaN, NaN].
	/// </summary>
	public IntPtr GetVectorResult()
	{
		return vtkExprTkFunctionParser_GetVectorResult_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_GetVectorResult_17(HandleRef pThis, IntPtr result);

	/// <summary>
	/// Get a vector result from evaluating the input function.
	///
	/// If ReplaceInvalidValues is not set, then the error value
	/// that will be return is [NaN, NaN, NaN].
	/// </summary>
	public void GetVectorResult(IntPtr result)
	{
		vtkExprTkFunctionParser_GetVectorResult_17(GetCppThis(), result);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExprTkFunctionParser_GetVectorVariableIndex_18(HandleRef pThis, string name);

	/// <summary>
	/// Get scalar variable index or -1 if not found
	/// </summary>
	public int GetVectorVariableIndex(string name)
	{
		return vtkExprTkFunctionParser_GetVectorVariableIndex_18(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkExprTkFunctionParser_GetVectorVariableName_19(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith vector variable name.
	/// </summary>
	public string GetVectorVariableName(int i)
	{
		return vtkExprTkFunctionParser_GetVectorVariableName_19(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExprTkFunctionParser_GetVectorVariableNeeded_20(HandleRef pThis, int i);

	/// <summary>
	/// Returns whether a vector variable is needed for the function evaluation.
	/// This is only valid after a successful Parse(). Thus, call GetVectorResult()
	/// or IsVectorResult() or similar method before calling this.
	/// </summary>
	public bool GetVectorVariableNeeded(int i)
	{
		return (vtkExprTkFunctionParser_GetVectorVariableNeeded_20(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExprTkFunctionParser_GetVectorVariableNeeded_21(HandleRef pThis, string variableName);

	/// <summary>
	/// Returns whether a vector variable is needed for the function evaluation.
	/// This is only valid after a successful Parse(). Thus, call GetVectorResult()
	/// or IsVectorResult() or similar method before calling this.
	/// </summary>
	public bool GetVectorVariableNeeded(string variableName)
	{
		return (vtkExprTkFunctionParser_GetVectorVariableNeeded_21(GetCppThis(), variableName) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExprTkFunctionParser_GetVectorVariableValue_22(HandleRef pThis, string variableName);

	/// <summary>
	/// Get the value of a vector variable.
	/// </summary>
	public IntPtr GetVectorVariableValue(string variableName)
	{
		return vtkExprTkFunctionParser_GetVectorVariableValue_22(GetCppThis(), variableName);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_GetVectorVariableValue_23(HandleRef pThis, string variableName, IntPtr value);

	/// <summary>
	/// Get the value of a vector variable.
	/// </summary>
	public void GetVectorVariableValue(string variableName, IntPtr value)
	{
		vtkExprTkFunctionParser_GetVectorVariableValue_23(GetCppThis(), variableName, value);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExprTkFunctionParser_GetVectorVariableValue_24(HandleRef pThis, int i);

	/// <summary>
	/// Get the value of a vector variable.
	/// </summary>
	public IntPtr GetVectorVariableValue(int i)
	{
		return vtkExprTkFunctionParser_GetVectorVariableValue_24(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_GetVectorVariableValue_25(HandleRef pThis, int i, IntPtr value);

	/// <summary>
	/// Get the value of a vector variable.
	/// </summary>
	public void GetVectorVariableValue(int i, IntPtr value)
	{
		vtkExprTkFunctionParser_GetVectorVariableValue_25(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_InvalidateFunction_26(HandleRef pThis);

	/// <summary>
	/// Allow the user to force the function to be re-parsed
	/// </summary>
	public void InvalidateFunction()
	{
		vtkExprTkFunctionParser_InvalidateFunction_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExprTkFunctionParser_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExprTkFunctionParser_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExprTkFunctionParser_IsScalarResult_28(HandleRef pThis);

	/// <summary>
	/// Check whether the result is a scalar result.  If it isn't, then
	/// either the result is a vector or an error has occurred.
	/// </summary>
	public int IsScalarResult()
	{
		return vtkExprTkFunctionParser_IsScalarResult_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExprTkFunctionParser_IsTypeOf_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExprTkFunctionParser_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExprTkFunctionParser_IsVectorResult_30(HandleRef pThis);

	/// <summary>
	/// Check whether the result is a vector result.  If it isn't, then
	/// either the result is scalar or an error has occurred.
	/// </summary>
	public int IsVectorResult()
	{
		return vtkExprTkFunctionParser_IsVectorResult_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExprTkFunctionParser_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExprTkFunctionParser NewInstance()
	{
		vtkExprTkFunctionParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExprTkFunctionParser_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExprTkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_RemoveAllVariables_33(HandleRef pThis);

	/// <summary>
	/// Remove all the current variables.
	/// </summary>
	public void RemoveAllVariables()
	{
		vtkExprTkFunctionParser_RemoveAllVariables_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_RemoveScalarVariables_34(HandleRef pThis);

	/// <summary>
	/// Remove all the scalar variables.
	/// </summary>
	public void RemoveScalarVariables()
	{
		vtkExprTkFunctionParser_RemoveScalarVariables_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_RemoveVectorVariables_35(HandleRef pThis);

	/// <summary>
	/// Remove all the vector variables.
	/// </summary>
	public void RemoveVectorVariables()
	{
		vtkExprTkFunctionParser_RemoveVectorVariables_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_ReplaceInvalidValuesOff_36(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual void ReplaceInvalidValuesOff()
	{
		vtkExprTkFunctionParser_ReplaceInvalidValuesOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_ReplaceInvalidValuesOn_37(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual void ReplaceInvalidValuesOn()
	{
		vtkExprTkFunctionParser_ReplaceInvalidValuesOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExprTkFunctionParser_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExprTkFunctionParser SafeDownCast(vtkObjectBase o)
	{
		vtkExprTkFunctionParser vtkExprTkFunctionParser2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExprTkFunctionParser_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExprTkFunctionParser2 = (vtkExprTkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExprTkFunctionParser2.Register(null);
			}
		}
		return vtkExprTkFunctionParser2;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkExprTkFunctionParser_SanitizeName_39(string name);

	/// <summary>
	/// Sanitize a label/name to remove spaces, delimiters etc.
	/// Once the label/name is sanitized is can be accepted by the
	/// following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	///
	/// @note taken from vtkSMCoreUtilities
	/// </summary>
	public static string SanitizeName(string name)
	{
		return vtkExprTkFunctionParser_SanitizeName_39(name);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_SetFunction_40(HandleRef pThis, string function);

	/// <summary>
	/// Set/Get input string to evaluate.
	/// </summary>
	public void SetFunction(string function)
	{
		vtkExprTkFunctionParser_SetFunction_40(GetCppThis(), function);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_SetReplaceInvalidValues_41(HandleRef pThis, int _arg);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual void SetReplaceInvalidValues(int _arg)
	{
		vtkExprTkFunctionParser_SetReplaceInvalidValues_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_SetReplacementValue_42(HandleRef pThis, double _arg);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual void SetReplacementValue(double _arg)
	{
		vtkExprTkFunctionParser_SetReplacementValue_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_SetScalarVariableValue_43(HandleRef pThis, string variableName, double value);

	/// <summary>
	/// Set the value of a scalar variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value. If the
	/// variable name is not sanitized, it should be provided in quotes, and
	/// a valid unique string will be used as a replacement by the parser.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void SetScalarVariableValue(string variableName, double value)
	{
		vtkExprTkFunctionParser_SetScalarVariableValue_43(GetCppThis(), variableName, value);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_SetScalarVariableValue_44(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set the value of a scalar variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value. If the
	/// variable name is not sanitized, it should be provided in quotes, and
	/// a valid unique string will be used as a replacement by the parser.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void SetScalarVariableValue(int i, double value)
	{
		vtkExprTkFunctionParser_SetScalarVariableValue_44(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_SetVectorVariableValue_45(HandleRef pThis, string variableName, double xValue, double yValue, double zValue);

	/// <summary>
	/// Set the value of a vector variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value. If the
	/// variable name is not sanitized, it should be provided in quotes, and
	/// a valid unique string will be used as a replacement by the parser.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void SetVectorVariableValue(string variableName, double xValue, double yValue, double zValue)
	{
		vtkExprTkFunctionParser_SetVectorVariableValue_45(GetCppThis(), variableName, xValue, yValue, zValue);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_SetVectorVariableValue_46(HandleRef pThis, string variableName, IntPtr values);

	/// <summary>
	/// Set the value of a vector variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value. If the
	/// variable name is not sanitized, it should be provided in quotes, and
	/// a valid unique string will be used as a replacement by the parser.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void SetVectorVariableValue(string variableName, IntPtr values)
	{
		vtkExprTkFunctionParser_SetVectorVariableValue_46(GetCppThis(), variableName, values);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_SetVectorVariableValue_47(HandleRef pThis, int i, double xValue, double yValue, double zValue);

	/// <summary>
	/// Set the value of a vector variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value. If the
	/// variable name is not sanitized, it should be provided in quotes, and
	/// a valid unique string will be used as a replacement by the parser.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void SetVectorVariableValue(int i, double xValue, double yValue, double zValue)
	{
		vtkExprTkFunctionParser_SetVectorVariableValue_47(GetCppThis(), i, xValue, yValue, zValue);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExprTkFunctionParser_SetVectorVariableValue_48(HandleRef pThis, int i, IntPtr values);

	/// <summary>
	/// Set the value of a vector variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value. If the
	/// variable name is not sanitized, it should be provided in quotes, and
	/// a valid unique string will be used as a replacement by the parser.
	///
	/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
	/// </summary>
	public void SetVectorVariableValue(int i, IntPtr values)
	{
		vtkExprTkFunctionParser_SetVectorVariableValue_48(GetCppThis(), i, values);
	}
}
