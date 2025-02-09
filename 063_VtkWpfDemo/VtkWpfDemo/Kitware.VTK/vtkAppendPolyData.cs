using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAppendPolyData
/// </summary>
/// <remarks>
///    appends one or more polygonal datasets together
///
///
/// vtkAppendPolyData is a filter that appends one of more polygonal datasets
/// into a single polygonal dataset. All geometry is extracted and appended,
/// but point and cell attributes (i.e., scalars, vectors, normals) are
/// extracted and appended only if all datasets have the point and/or cell
/// attributes available.  (For example, if one dataset has point scalars but
/// another does not, point scalars will not be appended.)
///
/// @warning
/// The related filter vtkRemovePolyData enables the subtraction, or removal
/// of the cells of a vtkPolyData. Hence vtkRemovePolyData functions like the
/// inverse operation to vtkAppendPolyData.
///
/// </remarks>
/// <seealso>
///
/// vtkAppendFilter vtkRemovePolyData
/// </seealso>
public class vtkAppendPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAppendPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAppendPolyData()
	{
		MRClassNameKey = "class vtkAppendPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAppendPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendPolyData New()
	{
		vtkAppendPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAppendPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAppendPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAppendPolyData_AddInputData_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a dataset to the list of data to append. Should not be
	/// used when UserManagedInputs is true, use SetInputByNumber instead.
	/// </summary>
	public void AddInputData(vtkPolyData arg0)
	{
		vtkAppendPolyData_AddInputData_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendPolyData_GetInput_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get any input of this filter.
	/// </summary>
	public new vtkPolyData GetInput(int idx)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendPolyData_GetInput_02(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAppendPolyData_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get any input of this filter.
	/// </summary>
	public new vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendPolyData_GetInput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkAppendPolyData_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAppendPolyData_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendPolyData_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAppendPolyData_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendPolyData_GetOutputPointsPrecision_06(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkAppendPolyData_GetOutputPointsPrecision_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendPolyData_GetParallelStreaming_07(HandleRef pThis);

	/// <summary>
	/// ParallelStreaming is for a particular application.
	/// It causes this filter to ask for a different piece
	/// from each of its inputs.  If all the inputs are the same,
	/// then the output of this append filter is the whole dataset
	/// pieced back together.  Duplicate points are create
	/// along the seams.  The purpose of this feature is to get
	/// data parallelism at a course scale.  Each of the inputs
	/// can be generated in a different process at the same time.
	/// </summary>
	public virtual int GetParallelStreaming()
	{
		return vtkAppendPolyData_GetParallelStreaming_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendPolyData_GetUserManagedInputs_08(HandleRef pThis);

	/// <summary>
	/// UserManagedInputs allows the user to set inputs by number instead of
	/// using the AddInput/RemoveInput functions. Calls to
	/// SetNumberOfInputs/SetInputConnectionByNumber should not be mixed with calls
	/// to AddInput/RemoveInput. By default, UserManagedInputs is false.
	/// </summary>
	public virtual int GetUserManagedInputs()
	{
		return vtkAppendPolyData_GetUserManagedInputs_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendPolyData_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAppendPolyData_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendPolyData_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAppendPolyData_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendPolyData_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAppendPolyData NewInstance()
	{
		vtkAppendPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendPolyData_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_ParallelStreamingOff_13(HandleRef pThis);

	/// <summary>
	/// ParallelStreaming is for a particular application.
	/// It causes this filter to ask for a different piece
	/// from each of its inputs.  If all the inputs are the same,
	/// then the output of this append filter is the whole dataset
	/// pieced back together.  Duplicate points are create
	/// along the seams.  The purpose of this feature is to get
	/// data parallelism at a course scale.  Each of the inputs
	/// can be generated in a different process at the same time.
	/// </summary>
	public virtual void ParallelStreamingOff()
	{
		vtkAppendPolyData_ParallelStreamingOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_ParallelStreamingOn_14(HandleRef pThis);

	/// <summary>
	/// ParallelStreaming is for a particular application.
	/// It causes this filter to ask for a different piece
	/// from each of its inputs.  If all the inputs are the same,
	/// then the output of this append filter is the whole dataset
	/// pieced back together.  Duplicate points are create
	/// along the seams.  The purpose of this feature is to get
	/// data parallelism at a course scale.  Each of the inputs
	/// can be generated in a different process at the same time.
	/// </summary>
	public virtual void ParallelStreamingOn()
	{
		vtkAppendPolyData_ParallelStreamingOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_RemoveInputData_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a dataset from the list of data to append. Should not be
	/// used when UserManagedInputs is true, use SetInputByNumber (nullptr) instead.
	/// </summary>
	public void RemoveInputData(vtkPolyData arg0)
	{
		vtkAppendPolyData_RemoveInputData_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendPolyData_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkAppendPolyData vtkAppendPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendPolyData_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAppendPolyData2 = (vtkAppendPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAppendPolyData2.Register(null);
			}
		}
		return vtkAppendPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_SetInputConnectionByNumber_17(HandleRef pThis, int num, HandleRef input);

	/// <summary>
	/// Directly set(allocate) number of inputs, should only be used
	/// when UserManagedInputs is true.
	/// </summary>
	public void SetInputConnectionByNumber(int num, vtkAlgorithmOutput input)
	{
		vtkAppendPolyData_SetInputConnectionByNumber_17(GetCppThis(), num, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_SetInputDataByNumber_18(HandleRef pThis, int num, HandleRef ds);

	/// <summary>
	/// Directly set(allocate) number of inputs, should only be used
	/// when UserManagedInputs is true.
	/// </summary>
	public void SetInputDataByNumber(int num, vtkPolyData ds)
	{
		vtkAppendPolyData_SetInputDataByNumber_18(GetCppThis(), num, ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_SetNumberOfInputs_19(HandleRef pThis, int num);

	/// <summary>
	/// Directly set(allocate) number of inputs, should only be used
	/// when UserManagedInputs is true.
	/// </summary>
	public void SetNumberOfInputs(int num)
	{
		vtkAppendPolyData_SetNumberOfInputs_19(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_SetOutputPointsPrecision_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkAppendPolyData_SetOutputPointsPrecision_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_SetParallelStreaming_21(HandleRef pThis, int _arg);

	/// <summary>
	/// ParallelStreaming is for a particular application.
	/// It causes this filter to ask for a different piece
	/// from each of its inputs.  If all the inputs are the same,
	/// then the output of this append filter is the whole dataset
	/// pieced back together.  Duplicate points are create
	/// along the seams.  The purpose of this feature is to get
	/// data parallelism at a course scale.  Each of the inputs
	/// can be generated in a different process at the same time.
	/// </summary>
	public virtual void SetParallelStreaming(int _arg)
	{
		vtkAppendPolyData_SetParallelStreaming_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_SetUserManagedInputs_22(HandleRef pThis, int _arg);

	/// <summary>
	/// UserManagedInputs allows the user to set inputs by number instead of
	/// using the AddInput/RemoveInput functions. Calls to
	/// SetNumberOfInputs/SetInputConnectionByNumber should not be mixed with calls
	/// to AddInput/RemoveInput. By default, UserManagedInputs is false.
	/// </summary>
	public virtual void SetUserManagedInputs(int _arg)
	{
		vtkAppendPolyData_SetUserManagedInputs_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_UserManagedInputsOff_23(HandleRef pThis);

	/// <summary>
	/// UserManagedInputs allows the user to set inputs by number instead of
	/// using the AddInput/RemoveInput functions. Calls to
	/// SetNumberOfInputs/SetInputConnectionByNumber should not be mixed with calls
	/// to AddInput/RemoveInput. By default, UserManagedInputs is false.
	/// </summary>
	public virtual void UserManagedInputsOff()
	{
		vtkAppendPolyData_UserManagedInputsOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendPolyData_UserManagedInputsOn_24(HandleRef pThis);

	/// <summary>
	/// UserManagedInputs allows the user to set inputs by number instead of
	/// using the AddInput/RemoveInput functions. Calls to
	/// SetNumberOfInputs/SetInputConnectionByNumber should not be mixed with calls
	/// to AddInput/RemoveInput. By default, UserManagedInputs is false.
	/// </summary>
	public virtual void UserManagedInputsOn()
	{
		vtkAppendPolyData_UserManagedInputsOn_24(GetCppThis());
	}
}
