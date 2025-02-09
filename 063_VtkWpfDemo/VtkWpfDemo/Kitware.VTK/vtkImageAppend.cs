using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageAppend
/// </summary>
/// <remarks>
///    Collects data from multiple inputs into one image.
///
/// vtkImageAppend takes the components from multiple inputs and merges
/// them into one output. The output images are append along the "AppendAxis".
/// Except for the append axis, all inputs must have the same extent.
/// All inputs must have the same number of scalar components.
/// A future extension might be to pad or clip inputs to have the same extent.
/// The output has the same origin and spacing as the first input.
/// The origin and spacing of all other inputs are ignored.  All inputs
/// must have the same scalar type.
/// </remarks>
public class vtkImageAppend : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageAppend";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageAppend()
	{
		MRClassNameKey = "class vtkImageAppend";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAppend"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageAppend(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAppend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageAppend New()
	{
		vtkImageAppend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAppend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageAppend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageAppend()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageAppend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageAppend_GetAppendAxis_01(HandleRef pThis);

	/// <summary>
	/// This axis is expanded to hold the multiple images.
	/// The default AppendAxis is the X axis.
	/// If you want to create a volue from a series of XY images, then you should
	/// set the AppendAxis to 2 (Z axis).
	/// </summary>
	public virtual int GetAppendAxis()
	{
		return vtkImageAppend_GetAppendAxis_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAppend_GetInput_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkImageAppend_GetInput_02(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImageAppend_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkImageAppend_GetInput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkImageAppend_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageAppend_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageAppend_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageAppend_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAppend_GetNumberOfInputs_06(HandleRef pThis);

	/// <summary>
	/// Get the number of inputs to this filter. This method is only for
	/// support of old-style pipeline connections.  When writing new code
	/// you should use vtkAlgorithm::GetNumberOfInputConnections(0).
	/// </summary>
	public int GetNumberOfInputs()
	{
		return vtkImageAppend_GetNumberOfInputs_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAppend_GetPreserveExtents_07(HandleRef pThis);

	/// <summary>
	/// By default "PreserveExtents" is off and the append axis is used.
	/// When "PreseveExtents" is on, the extent of the inputs is used to
	/// place the image in the output.  The whole extent of the output is
	/// the union of the input whole extents.  Any portion of the
	/// output not covered by the inputs is set to zero.  The origin and
	/// spacing is taken from the first input.
	/// </summary>
	public virtual int GetPreserveExtents()
	{
		return vtkImageAppend_GetPreserveExtents_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAppend_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageAppend_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAppend_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageAppend_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAppend_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageAppend NewInstance()
	{
		vtkImageAppend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAppend_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageAppend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAppend_PreserveExtentsOff_12(HandleRef pThis);

	/// <summary>
	/// By default "PreserveExtents" is off and the append axis is used.
	/// When "PreseveExtents" is on, the extent of the inputs is used to
	/// place the image in the output.  The whole extent of the output is
	/// the union of the input whole extents.  Any portion of the
	/// output not covered by the inputs is set to zero.  The origin and
	/// spacing is taken from the first input.
	/// </summary>
	public virtual void PreserveExtentsOff()
	{
		vtkImageAppend_PreserveExtentsOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAppend_PreserveExtentsOn_13(HandleRef pThis);

	/// <summary>
	/// By default "PreserveExtents" is off and the append axis is used.
	/// When "PreseveExtents" is on, the extent of the inputs is used to
	/// place the image in the output.  The whole extent of the output is
	/// the union of the input whole extents.  Any portion of the
	/// output not covered by the inputs is set to zero.  The origin and
	/// spacing is taken from the first input.
	/// </summary>
	public virtual void PreserveExtentsOn()
	{
		vtkImageAppend_PreserveExtentsOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAppend_ReplaceNthInputConnection_14(HandleRef pThis, int idx, HandleRef input);

	/// <summary>
	/// Replace one of the input connections with a new input.  You can
	/// only replace input connections that you previously created with
	/// AddInputConnection() or, in the case of the first input,
	/// with SetInputConnection().
	/// </summary>
	public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
	{
		vtkImageAppend_ReplaceNthInputConnection_14(GetCppThis(), idx, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAppend_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageAppend SafeDownCast(vtkObjectBase o)
	{
		vtkImageAppend vtkImageAppend2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAppend_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageAppend2 = (vtkImageAppend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageAppend2.Register(null);
			}
		}
		return vtkImageAppend2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAppend_SetAppendAxis_16(HandleRef pThis, int _arg);

	/// <summary>
	/// This axis is expanded to hold the multiple images.
	/// The default AppendAxis is the X axis.
	/// If you want to create a volue from a series of XY images, then you should
	/// set the AppendAxis to 2 (Z axis).
	/// </summary>
	public virtual void SetAppendAxis(int _arg)
	{
		vtkImageAppend_SetAppendAxis_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAppend_SetInputData_17(HandleRef pThis, int idx, HandleRef input);

	/// <summary>
	/// Assign a data object as input. Note that this method does not
	/// establish a pipeline connection. Use SetInputConnection() to
	/// setup a pipeline connection.
	/// </summary>
	public new void SetInputData(int idx, vtkDataObject input)
	{
		vtkImageAppend_SetInputData_17(GetCppThis(), idx, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAppend_SetInputData_18(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Assign a data object as input. Note that this method does not
	/// establish a pipeline connection. Use SetInputConnection() to
	/// setup a pipeline connection.
	/// </summary>
	public new void SetInputData(vtkDataObject input)
	{
		vtkImageAppend_SetInputData_18(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAppend_SetPreserveExtents_19(HandleRef pThis, int _arg);

	/// <summary>
	/// By default "PreserveExtents" is off and the append axis is used.
	/// When "PreseveExtents" is on, the extent of the inputs is used to
	/// place the image in the output.  The whole extent of the output is
	/// the union of the input whole extents.  Any portion of the
	/// output not covered by the inputs is set to zero.  The origin and
	/// spacing is taken from the first input.
	/// </summary>
	public virtual void SetPreserveExtents(int _arg)
	{
		vtkImageAppend_SetPreserveExtents_19(GetCppThis(), _arg);
	}
}
