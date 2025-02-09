using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProgrammableFilter
/// </summary>
/// <remarks>
///    a user-programmable filter
///
/// vtkProgrammableFilter is a filter that can be programmed by the user.  To
/// use the filter you define a function that retrieves input of the correct
/// type, creates data, and then manipulates the output of the filter.  Using
/// this filter avoids the need for subclassing - and the function can be
/// defined in an interpreter wrapper language such as Java.
///
/// The trickiest part of using this filter is that the input and output
/// methods are unusual and cannot be compile-time type checked. Instead, as a
/// user of this filter it is your responsibility to set and get the correct
/// input and output types.
///
/// @warning
/// The filter correctly manages modified time and network execution in most
/// cases. However, if you change the definition of the filter function,
/// you'll want to send a manual Modified() method to the filter to force it
/// to reexecute.
///
/// </remarks>
/// <seealso>
///
/// vtkProgrammablePointDataFilter vtkProgrammableSource
/// </seealso>
public class vtkProgrammableFilter : vtkPassInputTypeAlgorithm
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
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProgrammableFilter()
	{
		MRClassNameKey = "class vtkProgrammableFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProgrammableFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableFilter New()
	{
		vtkProgrammableFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProgrammableFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProgrammableFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkProgrammableFilter_CopyArraysOff_01(HandleRef pThis);

	/// <summary>
	/// When CopyArrays is true, all arrays are copied to the output
	/// iff input and output are of the same type. False by default.
	/// </summary>
	public virtual void CopyArraysOff()
	{
		vtkProgrammableFilter_CopyArraysOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableFilter_CopyArraysOn_02(HandleRef pThis);

	/// <summary>
	/// When CopyArrays is true, all arrays are copied to the output
	/// iff input and output are of the same type. False by default.
	/// </summary>
	public virtual void CopyArraysOn()
	{
		vtkProgrammableFilter_CopyArraysOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProgrammableFilter_GetCopyArrays_03(HandleRef pThis);

	/// <summary>
	/// When CopyArrays is true, all arrays are copied to the output
	/// iff input and output are of the same type. False by default.
	/// </summary>
	public virtual bool GetCopyArrays()
	{
		return (vtkProgrammableFilter_GetCopyArrays_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_GetGraphInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a concrete type. This method is typically used by the
	/// writer of the filter function to get the input as a particular type (i.e.,
	/// it essentially does type casting). It is the users responsibility to know
	/// the correct type of the input data.
	/// </summary>
	public vtkGraph GetGraphInput()
	{
		vtkGraph vtkGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_GetGraphInput_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraph2 = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraph2.Register(null);
			}
		}
		return vtkGraph2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_GetMoleculeInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a concrete type. This method is typically used by the
	/// writer of the filter function to get the input as a particular type (i.e.,
	/// it essentially does type casting). It is the users responsibility to know
	/// the correct type of the input data.
	/// </summary>
	public vtkMolecule GetMoleculeInput()
	{
		vtkMolecule vtkMolecule2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_GetMoleculeInput_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMolecule2 = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMolecule2.Register(null);
			}
		}
		return vtkMolecule2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProgrammableFilter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableFilter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProgrammableFilter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_GetPolyDataInput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a concrete type. This method is typically used by the
	/// writer of the filter function to get the input as a particular type (i.e.,
	/// it essentially does type casting). It is the users responsibility to know
	/// the correct type of the input data.
	/// </summary>
	public vtkPolyData GetPolyDataInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_GetPolyDataInput_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_GetRectilinearGridInput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a concrete type. This method is typically used by the
	/// writer of the filter function to get the input as a particular type (i.e.,
	/// it essentially does type casting). It is the users responsibility to know
	/// the correct type of the input data.
	/// </summary>
	public vtkRectilinearGrid GetRectilinearGridInput()
	{
		vtkRectilinearGrid vtkRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_GetRectilinearGridInput_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGrid2 = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGrid2.Register(null);
			}
		}
		return vtkRectilinearGrid2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_GetStructuredGridInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a concrete type. This method is typically used by the
	/// writer of the filter function to get the input as a particular type (i.e.,
	/// it essentially does type casting). It is the users responsibility to know
	/// the correct type of the input data.
	/// </summary>
	public vtkStructuredGrid GetStructuredGridInput()
	{
		vtkStructuredGrid vtkStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_GetStructuredGridInput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGrid2 = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGrid2.Register(null);
			}
		}
		return vtkStructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_GetStructuredPointsInput_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a concrete type. This method is typically used by the
	/// writer of the filter function to get the input as a particular type (i.e.,
	/// it essentially does type casting). It is the users responsibility to know
	/// the correct type of the input data.
	/// </summary>
	public vtkStructuredPoints GetStructuredPointsInput()
	{
		vtkStructuredPoints vtkStructuredPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_GetStructuredPointsInput_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredPoints2 = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredPoints2.Register(null);
			}
		}
		return vtkStructuredPoints2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_GetTableInput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a concrete type. This method is typically used by the
	/// writer of the filter function to get the input as a particular type (i.e.,
	/// it essentially does type casting). It is the users responsibility to know
	/// the correct type of the input data.
	/// </summary>
	public vtkTable GetTableInput()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_GetTableInput_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_GetUnstructuredGridInput_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a concrete type. This method is typically used by the
	/// writer of the filter function to get the input as a particular type (i.e.,
	/// it essentially does type casting). It is the users responsibility to know
	/// the correct type of the input data.
	/// </summary>
	public vtkUnstructuredGrid GetUnstructuredGridInput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_GetUnstructuredGridInput_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableFilter_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProgrammableFilter_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableFilter_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProgrammableFilter_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProgrammableFilter NewInstance()
	{
		vtkProgrammableFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableFilter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableFilter SafeDownCast(vtkObjectBase o)
	{
		vtkProgrammableFilter vtkProgrammableFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableFilter_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProgrammableFilter2 = (vtkProgrammableFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProgrammableFilter2.Register(null);
			}
		}
		return vtkProgrammableFilter2;
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableFilter_SetCopyArrays_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// When CopyArrays is true, all arrays are copied to the output
	/// iff input and output are of the same type. False by default.
	/// </summary>
	public virtual void SetCopyArrays(bool _arg)
	{
		vtkProgrammableFilter_SetCopyArrays_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableFilter_SetExecuteMethod_20(HandleRef pThis, ProgrammableMethodCallbackType f, IntPtr arg);

	/// <summary>
	/// Specify the function to use to operate on the point attribute data. Note
	/// that the function takes a single (void *) argument.
	/// </summary>
	public void SetExecuteMethod(ProgrammableMethodCallbackType f, IntPtr arg)
	{
		vtkProgrammableFilter_SetExecuteMethod_20(GetCppThis(), f, arg);
	}

	[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableFilter_SetExecuteMethodArgDelete_21(HandleRef pThis, ProgrammableMethodCallbackType f);

	/// <summary>
	/// Set the arg delete method. This is used to free user memory.
	/// </summary>
	public void SetExecuteMethodArgDelete(ProgrammableMethodCallbackType f)
	{
		vtkProgrammableFilter_SetExecuteMethodArgDelete_21(GetCppThis(), f);
	}
}
