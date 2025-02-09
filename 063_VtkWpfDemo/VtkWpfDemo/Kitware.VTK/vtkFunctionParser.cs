using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFunctionParser
/// </summary>
/// <remarks>
///    Parse and evaluate a mathematical expression
///
/// vtkFunctionParser is a class that takes in a mathematical expression as
/// a char string, parses it, and evaluates it at the specified values of
/// the variables in the input string.
///
/// You can use the "if" operator to create conditional expressions
/// such as if ( test, trueresult, falseresult). These evaluate the boolean
/// valued test expression and then evaluate either the trueresult or the
/// falseresult expression to produce a final (scalar or vector valued) value.
/// "test" may contain &lt;,&gt;,=,|,&amp;, and () and all three subexpressions can
/// evaluate arbitrary function operators (ln, cos, +, if, etc)
///
/// @par Thanks:
/// Juha Nieminen (juha.nieminen@gmail.com) for relicensing this branch of the
/// function parser code that this class is based upon under the new BSD license
/// so that it could be used in VTK. Note, the BSD license applies to this
/// version of the function parser only (by permission of the author), and not
/// the original library.
///
/// @par Thanks:
/// Thomas Dunne (thomas.dunne@iwr.uni-heidelberg.de) for adding code for
/// two-parameter-parsing and a few functions (sign, min, max).
///
/// @par Thanks:
/// Sid Sydoriak (sxs@lanl.gov) for adding boolean operations and
/// conditional expressions and for fixing a variety of bugs.
/// </remarks>
public class vtkFunctionParser : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFunctionParser";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFunctionParser()
	{
		MRClassNameKey = "class vtkFunctionParser";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFunctionParser"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFunctionParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFunctionParser New()
	{
		vtkFunctionParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFunctionParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFunctionParser()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFunctionParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkFunctionParser_GetFunction_01(HandleRef pThis);

	/// <summary>
	/// Set/Get input string to evaluate.
	/// </summary>
	public virtual string GetFunction()
	{
		return Marshal.PtrToStringAnsi(vtkFunctionParser_GetFunction_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkFunctionParser_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// Return parser's MTime
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkFunctionParser_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFunctionParser_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFunctionParser_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFunctionParser_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFunctionParser_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionParser_GetNumberOfScalarVariables_05(HandleRef pThis);

	/// <summary>
	/// Get the number of scalar variables.
	/// </summary>
	public int GetNumberOfScalarVariables()
	{
		return vtkFunctionParser_GetNumberOfScalarVariables_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionParser_GetNumberOfVectorVariables_06(HandleRef pThis);

	/// <summary>
	/// Get the number of vector variables.
	/// </summary>
	public int GetNumberOfVectorVariables()
	{
		return vtkFunctionParser_GetNumberOfVectorVariables_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionParser_GetReplaceInvalidValues_07(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual int GetReplaceInvalidValues()
	{
		return vtkFunctionParser_GetReplaceInvalidValues_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFunctionParser_GetReplacementValue_08(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual double GetReplacementValue()
	{
		return vtkFunctionParser_GetReplacementValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFunctionParser_GetScalarResult_09(HandleRef pThis);

	/// <summary>
	/// Get a scalar result from evaluating the input function.
	/// </summary>
	public double GetScalarResult()
	{
		return vtkFunctionParser_GetScalarResult_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionParser_GetScalarVariableIndex_10(HandleRef pThis, string name);

	/// <summary>
	/// Get scalar variable index or -1 if not found
	/// </summary>
	public int GetScalarVariableIndex(string name)
	{
		return vtkFunctionParser_GetScalarVariableIndex_10(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionParser_GetScalarVariableName_11(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith scalar variable name.
	/// </summary>
	public string GetScalarVariableName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkFunctionParser_GetScalarVariableName_11(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFunctionParser_GetScalarVariableNeeded_12(HandleRef pThis, int i);

	/// <summary>
	/// Returns whether a scalar variable is needed for the function evaluation.
	/// This is only valid after a successful Parse(). Thus, call GetScalarResult()
	/// or IsScalarResult() or similar method before calling this.
	/// </summary>
	public bool GetScalarVariableNeeded(int i)
	{
		return (vtkFunctionParser_GetScalarVariableNeeded_12(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFunctionParser_GetScalarVariableNeeded_13(HandleRef pThis, string variableName);

	/// <summary>
	/// Returns whether a scalar variable is needed for the function evaluation.
	/// This is only valid after a successful Parse(). Thus, call GetScalarResult()
	/// or IsScalarResult() or similar method before calling this.
	/// </summary>
	public bool GetScalarVariableNeeded(string variableName)
	{
		return (vtkFunctionParser_GetScalarVariableNeeded_13(GetCppThis(), variableName) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFunctionParser_GetScalarVariableValue_14(HandleRef pThis, string variableName);

	/// <summary>
	/// Get the value of a scalar variable.
	/// </summary>
	public double GetScalarVariableValue(string variableName)
	{
		return vtkFunctionParser_GetScalarVariableValue_14(GetCppThis(), variableName);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFunctionParser_GetScalarVariableValue_15(HandleRef pThis, int i);

	/// <summary>
	/// Get the value of a scalar variable.
	/// </summary>
	public double GetScalarVariableValue(int i)
	{
		return vtkFunctionParser_GetScalarVariableValue_15(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionParser_GetVectorResult_16(HandleRef pThis);

	/// <summary>
	/// Get a vector result from evaluating the input function.
	/// </summary>
	public double[] GetVectorResult()
	{
		IntPtr intPtr = vtkFunctionParser_GetVectorResult_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_GetVectorResult_17(HandleRef pThis, IntPtr result);

	/// <summary>
	/// Get a vector result from evaluating the input function.
	/// </summary>
	public void GetVectorResult(IntPtr result)
	{
		vtkFunctionParser_GetVectorResult_17(GetCppThis(), result);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionParser_GetVectorVariableIndex_18(HandleRef pThis, string name);

	/// <summary>
	/// Get scalar variable index or -1 if not found
	/// </summary>
	public int GetVectorVariableIndex(string name)
	{
		return vtkFunctionParser_GetVectorVariableIndex_18(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionParser_GetVectorVariableName_19(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith vector variable name.
	/// </summary>
	public string GetVectorVariableName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkFunctionParser_GetVectorVariableName_19(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFunctionParser_GetVectorVariableNeeded_20(HandleRef pThis, int i);

	/// <summary>
	/// Returns whether a vector variable is needed for the function evaluation.
	/// This is only valid after a successful Parse(). Thus, call GetVectorResult()
	/// or IsVectorResult() or similar method before calling this.
	/// </summary>
	public bool GetVectorVariableNeeded(int i)
	{
		return (vtkFunctionParser_GetVectorVariableNeeded_20(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFunctionParser_GetVectorVariableNeeded_21(HandleRef pThis, string variableName);

	/// <summary>
	/// Returns whether a vector variable is needed for the function evaluation.
	/// This is only valid after a successful Parse(). Thus, call GetVectorResult()
	/// or IsVectorResult() or similar method before calling this.
	/// </summary>
	public bool GetVectorVariableNeeded(string variableName)
	{
		return (vtkFunctionParser_GetVectorVariableNeeded_21(GetCppThis(), variableName) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionParser_GetVectorVariableValue_22(HandleRef pThis, string variableName);

	/// <summary>
	/// Get the value of a vector variable.
	/// </summary>
	public double[] GetVectorVariableValue(string variableName)
	{
		IntPtr intPtr = vtkFunctionParser_GetVectorVariableValue_22(GetCppThis(), variableName);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_GetVectorVariableValue_23(HandleRef pThis, string variableName, IntPtr value);

	/// <summary>
	/// Get the value of a vector variable.
	/// </summary>
	public void GetVectorVariableValue(string variableName, IntPtr value)
	{
		vtkFunctionParser_GetVectorVariableValue_23(GetCppThis(), variableName, value);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionParser_GetVectorVariableValue_24(HandleRef pThis, int i);

	/// <summary>
	/// Get the value of a vector variable.
	/// </summary>
	public double[] GetVectorVariableValue(int i)
	{
		IntPtr intPtr = vtkFunctionParser_GetVectorVariableValue_24(GetCppThis(), i);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_GetVectorVariableValue_25(HandleRef pThis, int i, IntPtr value);

	/// <summary>
	/// Get the value of a vector variable.
	/// </summary>
	public void GetVectorVariableValue(int i, IntPtr value)
	{
		vtkFunctionParser_GetVectorVariableValue_25(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_InvalidateFunction_26(HandleRef pThis);

	/// <summary>
	/// Allow the user to force the function to be re-parsed
	/// </summary>
	public void InvalidateFunction()
	{
		vtkFunctionParser_InvalidateFunction_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionParser_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFunctionParser_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionParser_IsScalarResult_28(HandleRef pThis);

	/// <summary>
	/// Check whether the result is a scalar result.  If it isn't, then
	/// either the result is a vector or an error has occurred.
	/// </summary>
	public int IsScalarResult()
	{
		return vtkFunctionParser_IsScalarResult_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionParser_IsTypeOf_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFunctionParser_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionParser_IsVectorResult_30(HandleRef pThis);

	/// <summary>
	/// Check whether the result is a vector result.  If it isn't, then
	/// either the result is scalar or an error has occurred.
	/// </summary>
	public int IsVectorResult()
	{
		return vtkFunctionParser_IsVectorResult_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionParser_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFunctionParser NewInstance()
	{
		vtkFunctionParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFunctionParser_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_RemoveAllVariables_33(HandleRef pThis);

	/// <summary>
	/// Remove all the current variables.
	/// </summary>
	public void RemoveAllVariables()
	{
		vtkFunctionParser_RemoveAllVariables_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_RemoveScalarVariables_34(HandleRef pThis);

	/// <summary>
	/// Remove all the scalar variables.
	/// </summary>
	public void RemoveScalarVariables()
	{
		vtkFunctionParser_RemoveScalarVariables_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_RemoveVectorVariables_35(HandleRef pThis);

	/// <summary>
	/// Remove all the vector variables.
	/// </summary>
	public void RemoveVectorVariables()
	{
		vtkFunctionParser_RemoveVectorVariables_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_ReplaceInvalidValuesOff_36(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual void ReplaceInvalidValuesOff()
	{
		vtkFunctionParser_ReplaceInvalidValuesOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_ReplaceInvalidValuesOn_37(HandleRef pThis);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual void ReplaceInvalidValuesOn()
	{
		vtkFunctionParser_ReplaceInvalidValuesOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionParser_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFunctionParser SafeDownCast(vtkObjectBase o)
	{
		vtkFunctionParser vtkFunctionParser2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFunctionParser_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFunctionParser2 = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFunctionParser2.Register(null);
			}
		}
		return vtkFunctionParser2;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_SetFunction_39(HandleRef pThis, string function);

	/// <summary>
	/// Set/Get input string to evaluate.
	/// </summary>
	public void SetFunction(string function)
	{
		vtkFunctionParser_SetFunction_39(GetCppThis(), function);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_SetReplaceInvalidValues_40(HandleRef pThis, int _arg);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual void SetReplaceInvalidValues(int _arg)
	{
		vtkFunctionParser_SetReplaceInvalidValues_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_SetReplacementValue_41(HandleRef pThis, double _arg);

	/// <summary>
	/// When ReplaceInvalidValues is on, all invalid values (such as
	/// sqrt(-2), note that function parser does not handle complex
	/// numbers) will be replaced by ReplacementValue. Otherwise an
	/// error will be reported
	/// </summary>
	public virtual void SetReplacementValue(double _arg)
	{
		vtkFunctionParser_SetReplacementValue_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_SetScalarVariableValue_42(HandleRef pThis, string variableName, double value);

	/// <summary>
	/// Set the value of a scalar variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value.
	/// </summary>
	public void SetScalarVariableValue(string variableName, double value)
	{
		vtkFunctionParser_SetScalarVariableValue_42(GetCppThis(), variableName, value);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_SetScalarVariableValue_43(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set the value of a scalar variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value.
	/// </summary>
	public void SetScalarVariableValue(int i, double value)
	{
		vtkFunctionParser_SetScalarVariableValue_43(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_SetVectorVariableValue_44(HandleRef pThis, string variableName, double xValue, double yValue, double zValue);

	/// <summary>
	/// Set the value of a vector variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value.
	/// </summary>
	public void SetVectorVariableValue(string variableName, double xValue, double yValue, double zValue)
	{
		vtkFunctionParser_SetVectorVariableValue_44(GetCppThis(), variableName, xValue, yValue, zValue);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_SetVectorVariableValue_45(HandleRef pThis, string variableName, IntPtr values);

	/// <summary>
	/// Set the value of a vector variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value.
	/// </summary>
	public void SetVectorVariableValue(string variableName, IntPtr values)
	{
		vtkFunctionParser_SetVectorVariableValue_45(GetCppThis(), variableName, values);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_SetVectorVariableValue_46(HandleRef pThis, int i, double xValue, double yValue, double zValue);

	/// <summary>
	/// Set the value of a vector variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value.
	/// </summary>
	public void SetVectorVariableValue(int i, double xValue, double yValue, double zValue)
	{
		vtkFunctionParser_SetVectorVariableValue_46(GetCppThis(), i, xValue, yValue, zValue);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFunctionParser_SetVectorVariableValue_47(HandleRef pThis, int i, IntPtr values);

	/// <summary>
	/// Set the value of a vector variable.  If a variable with this name
	/// exists, then its value will be set to the new value.  If there is not
	/// already a variable with this name, variableName will be added to the
	/// list of variables, and its value will be set to the new value.
	/// </summary>
	public void SetVectorVariableValue(int i, IntPtr values)
	{
		vtkFunctionParser_SetVectorVariableValue_47(GetCppThis(), i, values);
	}
}
