using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMathematics
/// </summary>
/// <remarks>
///    Add, subtract, multiply, divide, invert, sin,
/// cos, exp, log.
///
/// vtkImageMathematics implements basic mathematic operations SetOperation is
/// used to select the filters behavior.  The filter can take two or one
/// input.
/// </remarks>
public class vtkImageMathematics : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMathematics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMathematics()
	{
		MRClassNameKey = "class vtkImageMathematics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMathematics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMathematics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMathematics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMathematics New()
	{
		vtkImageMathematics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMathematics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMathematics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageMathematics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageMathematics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_DivideByZeroToCOff_01(HandleRef pThis);

	/// <summary>
	/// How to handle divide by zero. Default is 0.
	/// </summary>
	public virtual void DivideByZeroToCOff()
	{
		vtkImageMathematics_DivideByZeroToCOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_DivideByZeroToCOn_02(HandleRef pThis);

	/// <summary>
	/// How to handle divide by zero. Default is 0.
	/// </summary>
	public virtual void DivideByZeroToCOn()
	{
		vtkImageMathematics_DivideByZeroToCOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMathematics_GetConstantC_03(HandleRef pThis);

	/// <summary>
	/// A constant used by some operations (typically additive). Default is 0.
	/// </summary>
	public virtual double GetConstantC()
	{
		return vtkImageMathematics_GetConstantC_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMathematics_GetConstantK_04(HandleRef pThis);

	/// <summary>
	/// A constant used by some operations (typically multiplicative). Default is 1.
	/// </summary>
	public virtual double GetConstantK()
	{
		return vtkImageMathematics_GetConstantK_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMathematics_GetDivideByZeroToC_05(HandleRef pThis);

	/// <summary>
	/// How to handle divide by zero. Default is 0.
	/// </summary>
	public virtual int GetDivideByZeroToC()
	{
		return vtkImageMathematics_GetDivideByZeroToC_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMathematics_GetInput_06(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get one input to this filter. This method is only for support of
	/// old-style pipeline connections.  When writing new code you should
	/// use vtkAlgorithm::GetInputConnection(0, num).
	/// </summary>
	public new vtkDataObject GetInput(int idx)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMathematics_GetInput_06(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMathematics_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get one input to this filter. This method is only for support of
	/// old-style pipeline connections.  When writing new code you should
	/// use vtkAlgorithm::GetInputConnection(0, num).
	/// </summary>
	public new vtkDataObject GetInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMathematics_GetInput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMathematics_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMathematics_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMathematics_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMathematics_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMathematics_GetNumberOfInputs_10(HandleRef pThis);

	/// <summary>
	/// Get the number of inputs to this filter. This method is only for
	/// support of old-style pipeline connections.  When writing new code
	/// you should use vtkAlgorithm::GetNumberOfInputConnections(0).
	/// </summary>
	public int GetNumberOfInputs()
	{
		return vtkImageMathematics_GetNumberOfInputs_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMathematics_GetOperation_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public virtual int GetOperation()
	{
		return vtkImageMathematics_GetOperation_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMathematics_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMathematics_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMathematics_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMathematics_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMathematics_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMathematics NewInstance()
	{
		vtkImageMathematics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMathematics_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMathematics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_ReplaceNthInputConnection_16(HandleRef pThis, int idx, HandleRef input);

	/// <summary>
	/// Replace one of the input connections with a new input.  You can
	/// only replace input connections that you previously created with
	/// AddInputConnection() or, in the case of the first input,
	/// with SetInputConnection().
	/// </summary>
	public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
	{
		vtkImageMathematics_ReplaceNthInputConnection_16(GetCppThis(), idx, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMathematics_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMathematics SafeDownCast(vtkObjectBase o)
	{
		vtkImageMathematics vtkImageMathematics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMathematics_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMathematics2 = (vtkImageMathematics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMathematics2.Register(null);
			}
		}
		return vtkImageMathematics2;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetConstantC_18(HandleRef pThis, double _arg);

	/// <summary>
	/// A constant used by some operations (typically additive). Default is 0.
	/// </summary>
	public virtual void SetConstantC(double _arg)
	{
		vtkImageMathematics_SetConstantC_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetConstantK_19(HandleRef pThis, double _arg);

	/// <summary>
	/// A constant used by some operations (typically multiplicative). Default is 1.
	/// </summary>
	public virtual void SetConstantK(double _arg)
	{
		vtkImageMathematics_SetConstantK_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetDivideByZeroToC_20(HandleRef pThis, int _arg);

	/// <summary>
	/// How to handle divide by zero. Default is 0.
	/// </summary>
	public virtual void SetDivideByZeroToC(int _arg)
	{
		vtkImageMathematics_SetDivideByZeroToC_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetInput1Data_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the inputs to this filter. For some operations, the second input
	/// is not used.
	/// </summary>
	public virtual void SetInput1Data(vtkDataObject arg0)
	{
		vtkImageMathematics_SetInput1Data_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetInput2Data_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the inputs to this filter. For some operations, the second input
	/// is not used.
	/// </summary>
	public virtual void SetInput2Data(vtkDataObject arg0)
	{
		vtkImageMathematics_SetInput2Data_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetInputConnection_23(HandleRef pThis, int idx, HandleRef input);

	/// <summary>
	/// Set the inputs to this filter. For some operations, the second input
	/// is not used.
	/// </summary>
	public override void SetInputConnection(int idx, vtkAlgorithmOutput input)
	{
		vtkImageMathematics_SetInputConnection_23(GetCppThis(), idx, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetInputConnection_24(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the inputs to this filter. For some operations, the second input
	/// is not used.
	/// </summary>
	public override void SetInputConnection(vtkAlgorithmOutput input)
	{
		vtkImageMathematics_SetInputConnection_24(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetInputData_25(HandleRef pThis, int idx, HandleRef input);

	/// <summary>
	/// Assign a data object as input. Note that this method does not
	/// establish a pipeline connection. Use SetInputConnection() to
	/// setup a pipeline connection.
	/// </summary>
	public new void SetInputData(int idx, vtkDataObject input)
	{
		vtkImageMathematics_SetInputData_25(GetCppThis(), idx, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetInputData_26(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Assign a data object as input. Note that this method does not
	/// establish a pipeline connection. Use SetInputConnection() to
	/// setup a pipeline connection.
	/// </summary>
	public new void SetInputData(vtkDataObject input)
	{
		vtkImageMathematics_SetInputData_26(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperation_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public virtual void SetOperation(int _arg)
	{
		vtkImageMathematics_SetOperation_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToATAN_28(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the arctangent of the corresponding pixel
	/// in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToATAN()
	{
		vtkImageMathematics_SetOperationToATAN_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToATAN2_29(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the arctangent of the corresponding pixel
	/// in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToATAN2()
	{
		vtkImageMathematics_SetOperationToATAN2_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToAbsoluteValue_30(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the absolute value of the corresponding pixel
	/// in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToAbsoluteValue()
	{
		vtkImageMathematics_SetOperationToAbsoluteValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToAdd_31(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the sum of the corresponding pixels
	/// in Input1 and Input2.
	/// </summary>
	public void SetOperationToAdd()
	{
		vtkImageMathematics_SetOperationToAdd_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToAddConstant_32(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the product of ConstantC with the
	/// corresponding pixel in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToAddConstant()
	{
		vtkImageMathematics_SetOperationToAddConstant_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToComplexMultiply_33(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the quotient of the corresponding pixels
	/// in Input1 and Input2 (Output = Input1 / Input2).
	/// </summary>
	public void SetOperationToComplexMultiply()
	{
		vtkImageMathematics_SetOperationToComplexMultiply_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToConjugate_34(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the quotient of the corresponding pixels
	/// in Input1 and Input2 (Output = Input1 / Input2).
	/// </summary>
	public void SetOperationToConjugate()
	{
		vtkImageMathematics_SetOperationToConjugate_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToCos_35(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the cosine of the corresponding pixel
	/// in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToCos()
	{
		vtkImageMathematics_SetOperationToCos_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToDivide_36(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the quotient of the corresponding pixels
	/// in Input1 and Input2 (Output = Input1 / Input2).
	/// </summary>
	public void SetOperationToDivide()
	{
		vtkImageMathematics_SetOperationToDivide_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToExp_37(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the exponential of the corresponding pixel
	/// in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToExp()
	{
		vtkImageMathematics_SetOperationToExp_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToInvert_38(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to 1 over the corresponding pixel
	/// in Input1 and Input2 (output = 1 / Input1). Input2 is not used.
	/// </summary>
	public void SetOperationToInvert()
	{
		vtkImageMathematics_SetOperationToInvert_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToLog_39(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the log of the corresponding pixel
	/// in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToLog()
	{
		vtkImageMathematics_SetOperationToLog_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToMax_40(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the maximum of the corresponding pixels
	/// in Input1 and Input2. (Output = max(Input1, Input2))
	/// </summary>
	public void SetOperationToMax()
	{
		vtkImageMathematics_SetOperationToMax_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToMin_41(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the minimum of the corresponding pixels
	/// in Input1 and Input2. (Output = min(Input1, Input2))
	/// </summary>
	public void SetOperationToMin()
	{
		vtkImageMathematics_SetOperationToMin_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToMultiply_42(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the product of the corresponding pixels
	/// in Input1 and Input2.
	/// </summary>
	public void SetOperationToMultiply()
	{
		vtkImageMathematics_SetOperationToMultiply_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToMultiplyByK_43(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the product of ConstantK with the
	/// corresponding pixel in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToMultiplyByK()
	{
		vtkImageMathematics_SetOperationToMultiplyByK_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToReplaceCByK_44(HandleRef pThis);

	/// <summary>
	/// Find every pixel in Input1 that equals ConstantC and set the corresponding pixels
	/// in the Output to ConstantK. Input2 is not used.
	/// </summary>
	public void SetOperationToReplaceCByK()
	{
		vtkImageMathematics_SetOperationToReplaceCByK_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToSin_45(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the sine of the corresponding pixel
	/// in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToSin()
	{
		vtkImageMathematics_SetOperationToSin_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToSquare_46(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the square of the corresponding pixel
	/// in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToSquare()
	{
		vtkImageMathematics_SetOperationToSquare_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToSquareRoot_47(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the square root of the corresponding pixel
	/// in Input1. Input2 is not used.
	/// </summary>
	public void SetOperationToSquareRoot()
	{
		vtkImageMathematics_SetOperationToSquareRoot_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMathematics_SetOperationToSubtract_48(HandleRef pThis);

	/// <summary>
	/// Set each pixel in the output image to the difference of the corresponding pixels
	/// in Input1 and Input2 (output = Input1 - Input2).
	/// </summary>
	public void SetOperationToSubtract()
	{
		vtkImageMathematics_SetOperationToSubtract_48(GetCppThis());
	}
}
