using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageLogic
/// </summary>
/// <remarks>
///    And, or, xor, nand, nor, not.
///
/// vtkImageLogic implements basic logic operations.
/// SetOperation is used to select the filter's behavior.
/// The filter can take two or one input. Inputs must have the same type.
/// </remarks>
public class vtkImageLogic : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageLogic";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageLogic()
	{
		MRClassNameKey = "class vtkImageLogic";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageLogic"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageLogic(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageLogic_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageLogic New()
	{
		vtkImageLogic result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageLogic_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageLogic)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageLogic()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageLogic_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkImageLogic_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageLogic_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageLogic_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageLogic_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageLogic_GetOperation_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public virtual int GetOperation()
	{
		return vtkImageLogic_GetOperation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageLogic_GetOutputTrueValue_04(HandleRef pThis);

	/// <summary>
	/// Set the value to use for true in the output.
	/// </summary>
	public virtual double GetOutputTrueValue()
	{
		return vtkImageLogic_GetOutputTrueValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageLogic_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageLogic_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageLogic_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageLogic_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageLogic_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageLogic NewInstance()
	{
		vtkImageLogic result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageLogic_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageLogic)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageLogic_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageLogic SafeDownCast(vtkObjectBase o)
	{
		vtkImageLogic vtkImageLogic2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageLogic_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageLogic2 = (vtkImageLogic)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageLogic2.Register(null);
			}
		}
		return vtkImageLogic2;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetInput1Data_10(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the Input1 of this filter.
	/// </summary>
	public virtual void SetInput1Data(vtkDataObject input)
	{
		vtkImageLogic_SetInput1Data_10(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetInput2Data_11(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the Input2 of this filter.
	/// </summary>
	public virtual void SetInput2Data(vtkDataObject input)
	{
		vtkImageLogic_SetInput2Data_11(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetOperation_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public virtual void SetOperation(int _arg)
	{
		vtkImageLogic_SetOperation_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetOperationToAnd_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public void SetOperationToAnd()
	{
		vtkImageLogic_SetOperationToAnd_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetOperationToNand_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public void SetOperationToNand()
	{
		vtkImageLogic_SetOperationToNand_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetOperationToNor_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public void SetOperationToNor()
	{
		vtkImageLogic_SetOperationToNor_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetOperationToNot_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public void SetOperationToNot()
	{
		vtkImageLogic_SetOperationToNot_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetOperationToOr_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public void SetOperationToOr()
	{
		vtkImageLogic_SetOperationToOr_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetOperationToXor_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the Operation to perform.
	/// </summary>
	public void SetOperationToXor()
	{
		vtkImageLogic_SetOperationToXor_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageLogic_SetOutputTrueValue_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the value to use for true in the output.
	/// </summary>
	public virtual void SetOutputTrueValue(double _arg)
	{
		vtkImageLogic_SetOutputTrueValue_19(GetCppThis(), _arg);
	}
}
