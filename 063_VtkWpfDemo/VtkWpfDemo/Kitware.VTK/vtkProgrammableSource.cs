using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProgrammableSource
/// </summary>
/// <remarks>
///    generate source dataset via a user-specified function
///
/// vtkProgrammableSource is a source object that is programmable by the
/// user. To use this object, you must specify a function that creates the
/// output.  It is possible to generate an output dataset of any (concrete)
/// type; it is up to the function to properly initialize and define the
/// output. Typically, you use one of the methods to get a concrete output
/// type (e.g., GetPolyDataOutput() or GetStructuredPointsOutput()), and
/// then manipulate the output in the user-specified function.
///
/// Example use of this include writing a function to read a data file or
/// interface to another system. (You might want to do this in favor of
/// deriving a new class.) Another important use of this class is that it
/// allows users of interpreters (e.g., Java) the ability to write
/// source objects without having to recompile C++ code or generate new
/// libraries.
/// </remarks>
/// <seealso>
///
/// vtkProgrammableFilter vtkProgrammableAttributeDataFilter
/// vtkProgrammableDataObjectSource
/// </seealso>
public class vtkProgrammableSource : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Signature definition for programmable method callbacks. Methods passed
	/// to SetExecuteMethod, SetExecuteMethodArgDelete or
	/// SetRequestInformationMethod must conform to this signature.
	/// The presence of this typedef is useful for reference and for external
	/// analysis tools, but it cannot be used in the method signatures in these
	/// header files themselves because it prevents the internal VTK wrapper
	/// generators from wrapping these methods.
	/// </summary>
	public delegate void ProgrammableMethodCallbackType(IntPtr arg0);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProgrammableSource()
	{
		MRClassNameKey = "class vtkProgrammableSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProgrammableSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableSource New()
	{
		vtkProgrammableSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProgrammableSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProgrammableSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_GetGraphOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a concrete type. This method is typically used by the
	/// writer of the source function to get the output as a particular type
	/// (i.e., it essentially does type casting). It is the users responsibility
	/// to know the correct type of the output data.
	/// </summary>
	public vtkGraph GetGraphOutput()
	{
		vtkGraph vtkGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_GetGraphOutput_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_GetMoleculeOutput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a concrete type. This method is typically used by the
	/// writer of the source function to get the output as a particular type
	/// (i.e., it essentially does type casting). It is the users responsibility
	/// to know the correct type of the output data.
	/// </summary>
	public vtkMolecule GetMoleculeOutput()
	{
		vtkMolecule vtkMolecule2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_GetMoleculeOutput_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProgrammableSource_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableSource_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProgrammableSource_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_GetPolyDataOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a concrete type. This method is typically used by the
	/// writer of the source function to get the output as a particular type
	/// (i.e., it essentially does type casting). It is the users responsibility
	/// to know the correct type of the output data.
	/// </summary>
	public vtkPolyData GetPolyDataOutput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_GetPolyDataOutput_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_GetRectilinearGridOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a concrete type. This method is typically used by the
	/// writer of the source function to get the output as a particular type
	/// (i.e., it essentially does type casting). It is the users responsibility
	/// to know the correct type of the output data.
	/// </summary>
	public vtkRectilinearGrid GetRectilinearGridOutput()
	{
		vtkRectilinearGrid vtkRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_GetRectilinearGridOutput_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_GetStructuredGridOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a concrete type. This method is typically used by the
	/// writer of the source function to get the output as a particular type
	/// (i.e., it essentially does type casting). It is the users responsibility
	/// to know the correct type of the output data.
	/// </summary>
	public vtkStructuredGrid GetStructuredGridOutput()
	{
		vtkStructuredGrid vtkStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_GetStructuredGridOutput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_GetStructuredPointsOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a concrete type. This method is typically used by the
	/// writer of the source function to get the output as a particular type
	/// (i.e., it essentially does type casting). It is the users responsibility
	/// to know the correct type of the output data.
	/// </summary>
	public vtkStructuredPoints GetStructuredPointsOutput()
	{
		vtkStructuredPoints vtkStructuredPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_GetStructuredPointsOutput_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_GetTableOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a concrete type. This method is typically used by the
	/// writer of the source function to get the output as a particular type
	/// (i.e., it essentially does type casting). It is the users responsibility
	/// to know the correct type of the output data.
	/// </summary>
	public vtkTable GetTableOutput()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_GetTableOutput_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_GetUnstructuredGridOutput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a concrete type. This method is typically used by the
	/// writer of the source function to get the output as a particular type
	/// (i.e., it essentially does type casting). It is the users responsibility
	/// to know the correct type of the output data.
	/// </summary>
	public vtkUnstructuredGrid GetUnstructuredGridOutput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_GetUnstructuredGridOutput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableSource_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProgrammableSource_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableSource_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProgrammableSource_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProgrammableSource NewInstance()
	{
		vtkProgrammableSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableSource_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableSource SafeDownCast(vtkObjectBase o)
	{
		vtkProgrammableSource vtkProgrammableSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableSource_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProgrammableSource2 = (vtkProgrammableSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProgrammableSource2.Register(null);
			}
		}
		return vtkProgrammableSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableSource_SetExecuteMethod_16(HandleRef pThis, ProgrammableMethodCallbackType f, IntPtr arg);

	/// <summary>
	/// Specify the function to use to generate the source data. Note
	/// that the function takes a single (void *) argument.
	/// </summary>
	public void SetExecuteMethod(ProgrammableMethodCallbackType f, IntPtr arg)
	{
		vtkProgrammableSource_SetExecuteMethod_16(GetCppThis(), f, arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableSource_SetExecuteMethodArgDelete_17(HandleRef pThis, ProgrammableMethodCallbackType f);

	/// <summary>
	/// Set the arg delete method. This is used to free user memory.
	/// </summary>
	public void SetExecuteMethodArgDelete(ProgrammableMethodCallbackType f)
	{
		vtkProgrammableSource_SetExecuteMethodArgDelete_17(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableSource_SetRequestInformationMethod_18(HandleRef pThis, ProgrammableMethodCallbackType f);

	/// <summary>
	/// Specify the function to use to fill in information about the source data.
	/// </summary>
	public void SetRequestInformationMethod(ProgrammableMethodCallbackType f)
	{
		vtkProgrammableSource_SetRequestInformationMethod_18(GetCppThis(), f);
	}
}
