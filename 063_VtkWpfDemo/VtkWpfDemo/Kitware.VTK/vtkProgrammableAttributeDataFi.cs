using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProgrammableAttributeDataFilter
/// </summary>
/// <remarks>
///    manipulate attribute (cell and point) data via a user-specified function
///
/// vtkProgrammableAttributeDataFilter is a filter that allows you to write a
/// custom procedure to manipulate attribute data - either point or cell
/// data. For example, you could generate scalars based on a complex formula;
/// convert vectors to normals; compute scalar values as a function of
/// vectors, texture coords, and/or any other point data attribute; and so
/// on. The filter takes multiple inputs (input plus an auxiliary input list),
/// so you can write procedures that combine several dataset point
/// attributes. Note that the output of the filter is the same type
/// (topology/geometry) as the input.
///
/// The filter works as follows. It operates like any other filter (i.e.,
/// checking and managing modified and execution times, processing Update()
/// and Execute() methods, managing release of data, etc.), but the difference
/// is that the Execute() method simply invokes a user-specified function with
/// an optional (void *) argument (typically the "this" pointer in C++). It is
/// also possible to specify a function to delete the argument via
/// ExecuteMethodArgDelete().
///
/// To use the filter, you write a procedure to process the input datasets,
/// process the data, and generate output data. Typically, this means grabbing
/// the input point or cell data (using GetInput() and maybe GetInputList()),
/// operating on it (creating new point and cell attributes such as scalars,
/// vectors, etc.), and then setting the point and/or cell attributes in the
/// output dataset (you'll need to use GetOutput() to access the output).
/// (Note: besides C++, it is possible to do the same thing in Java or
/// other languages that wrap the C++ core.) Remember, proper filter protocol
/// requires that you don't modify the input data - you create new output data
/// from the input.
///
/// @warning
/// This filter operates on any combination of the filter input plus a list of
/// additional inputs (at a minimum you must set the filter input via
/// SetInput()).  It is up to you check whether the input is valid, and to
/// ensure that the output is valid. Also, you have to write the control
/// structure for the traversal and operation on the point and cell attribute
/// data.
///
/// @warning
/// By default the output point and cell data will be copied through from the
/// input point data (using reference counting).  You can control this using
/// the output's CopyAllOff() flag, or by using individual flags for each
/// point data field (i.e., scalars, vectors, etc.)
///
/// @warning
/// The output of this filter is the abstract type vtkDataSet, even if your
/// input is a concrete type like vtkPolyData. Thus you may need to use
/// vtkCastToConcrete to obtain the output as a particular concrete type, or
/// one of the special methods of the superclass (e.g.,
/// vtkDataSetAlgorithm::GetPolyDataOutput) to retrieve output of the
/// correct type.
///
/// @warning
/// The filter correctly manages modified time and network execution in most
/// cases. However, if you change the definition of the filter function,
/// you'll want to send a manual Modified() method to the filter to force it
/// to reexecute.
/// </remarks>
public class vtkProgrammableAttributeDataFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Signature definition for programmable method callbacks. Methods passed to
	/// SetExecuteMethod or SetExecuteMethodArgDelete must conform to this
	/// signature.
	/// The presence of this typedef is useful for reference and for external
	/// analysis tools, but it cannot be used in the method signatures in these
	/// header files themselves because it prevents the internal VTK wrapper
	/// generators from wrapping these methods.
	/// </summary>
	public delegate void ProgrammableMethodCallbackType(IntPtr arg0);

	/// <summary>
	/// Managed/.NET signature for handlers of the SetExecuteMethod callback.
	/// </summary>
	public delegate void ExecuteMethodHandler(IntPtr arg);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableAttributeDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProgrammableAttributeDataFilter()
	{
		MRClassNameKey = "class vtkProgrammableAttributeDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableAttributeDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProgrammableAttributeDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableAttributeDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableAttributeDataFilter New()
	{
		vtkProgrammableAttributeDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableAttributeDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProgrammableAttributeDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProgrammableAttributeDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableAttributeDataFilter_AddInput_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a dataset to the list of data to process.
	/// </summary>
	public void AddInput(vtkDataSet arg0)
	{
		vtkProgrammableAttributeDataFilter_AddInput_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableAttributeDataFilter_GetInputList_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the list of inputs.
	/// </summary>
	public vtkDataSetCollection GetInputList()
	{
		vtkDataSetCollection vtkDataSetCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableAttributeDataFilter_GetInputList_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetCollection2 = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetCollection2.Register(null);
			}
		}
		return vtkDataSetCollection2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableAttributeDataFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProgrammableAttributeDataFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableAttributeDataFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProgrammableAttributeDataFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableAttributeDataFilter_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProgrammableAttributeDataFilter_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableAttributeDataFilter_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProgrammableAttributeDataFilter_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableAttributeDataFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProgrammableAttributeDataFilter NewInstance()
	{
		vtkProgrammableAttributeDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableAttributeDataFilter_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableAttributeDataFilter_RemoveInput_09(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a dataset from the list of data to process.
	/// </summary>
	public void RemoveInput(vtkDataSet arg0)
	{
		vtkProgrammableAttributeDataFilter_RemoveInput_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableAttributeDataFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableAttributeDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkProgrammableAttributeDataFilter vtkProgrammableAttributeDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableAttributeDataFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProgrammableAttributeDataFilter2 = (vtkProgrammableAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProgrammableAttributeDataFilter2.Register(null);
			}
		}
		return vtkProgrammableAttributeDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableAttributeDataFilter_SetExecuteMethod_11(HandleRef pThis, ProgrammableMethodCallbackType f, IntPtr arg);

	/// <summary>
	/// Specify the function to use to operate on the point attribute data. Note
	/// that the function takes a single (void *) argument.
	/// </summary>
	public void SetExecuteMethod(ProgrammableMethodCallbackType f, IntPtr arg)
	{
		vtkProgrammableAttributeDataFilter_SetExecuteMethod_11(GetCppThis(), f, arg);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableAttributeDataFilter_SetExecuteMethodArgDelete_12(HandleRef pThis, ProgrammableMethodCallbackType f);

	/// <summary>
	/// Set the arg delete method. This is used to free user memory.
	/// </summary>
	public void SetExecuteMethodArgDelete(ProgrammableMethodCallbackType f)
	{
		vtkProgrammableAttributeDataFilter_SetExecuteMethodArgDelete_12(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableAttributeDataFilter_SetExecuteMethod(HandleRef pThis, ExecuteMethodHandler handler, IntPtr arg);

	/// <summary>
	/// Specify the function to use to operate on the point attribute data. Note
	/// that the function takes a single (void *) argument.
	/// </summary>
	public void SetExecuteMethod(ExecuteMethodHandler handler, IntPtr arg)
	{
		vtkProgrammableAttributeDataFilter_SetExecuteMethod(GetCppThis(), handler, arg);
	}

	/// <summary>
	/// Specify the function to use to operate on the point attribute data. Note
	/// that the function takes a single (void *) argument.
	/// </summary>
	public void SetExecuteMethod(ExecuteMethodHandler handler)
	{
		vtkProgrammableAttributeDataFilter_SetExecuteMethod(GetCppThis(), handler, IntPtr.Zero);
	}
}
