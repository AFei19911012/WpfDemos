using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProgrammableDataObjectSource
/// </summary>
/// <remarks>
///    generate source data object via a user-specified function
///
/// vtkProgrammableDataObjectSource is a source object that is programmable by
/// the user. The output of the filter is a data object (vtkDataObject) which
/// represents data via an instance of field data. To use this object, you
/// must specify a function that creates the output.
///
/// Example use of this filter includes reading tabular data and encoding it
/// as vtkFieldData. You can then use filters like vtkDataObjectToDataSetFilter
/// to convert the data object to a dataset and then visualize it.  Another
/// important use of this class is that it allows users of interpreters (e.g.,
/// Java) the ability to write source objects without having to
/// recompile C++ code or generate new libraries.
///
/// </remarks>
/// <seealso>
///
/// vtkProgrammableFilter vtkProgrammableAttributeDataFilter
/// vtkProgrammableSource vtkDataObjectToDataSetFilter
/// </seealso>
public class vtkProgrammableDataObjectSource : vtkDataObjectAlgorithm
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableDataObjectSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProgrammableDataObjectSource()
	{
		MRClassNameKey = "class vtkProgrammableDataObjectSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableDataObjectSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProgrammableDataObjectSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableDataObjectSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableDataObjectSource New()
	{
		vtkProgrammableDataObjectSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableDataObjectSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableDataObjectSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProgrammableDataObjectSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProgrammableDataObjectSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkProgrammableDataObjectSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProgrammableDataObjectSource_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgrammableDataObjectSource_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProgrammableDataObjectSource_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableDataObjectSource_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProgrammableDataObjectSource_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgrammableDataObjectSource_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProgrammableDataObjectSource_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableDataObjectSource_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProgrammableDataObjectSource NewInstance()
	{
		vtkProgrammableDataObjectSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableDataObjectSource_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgrammableDataObjectSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgrammableDataObjectSource_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProgrammableDataObjectSource SafeDownCast(vtkObjectBase o)
	{
		vtkProgrammableDataObjectSource vtkProgrammableDataObjectSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgrammableDataObjectSource_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProgrammableDataObjectSource2 = (vtkProgrammableDataObjectSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProgrammableDataObjectSource2.Register(null);
			}
		}
		return vtkProgrammableDataObjectSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableDataObjectSource_SetExecuteMethod_08(HandleRef pThis, ProgrammableMethodCallbackType f, IntPtr arg);

	/// <summary>
	/// Specify the function to use to generate the output data object. Note
	/// that the function takes a single (void *) argument.
	/// </summary>
	public void SetExecuteMethod(ProgrammableMethodCallbackType f, IntPtr arg)
	{
		vtkProgrammableDataObjectSource_SetExecuteMethod_08(GetCppThis(), f, arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgrammableDataObjectSource_SetExecuteMethodArgDelete_09(HandleRef pThis, ProgrammableMethodCallbackType f);

	/// <summary>
	/// Set the arg delete method. This is used to free user memory.
	/// </summary>
	public void SetExecuteMethodArgDelete(ProgrammableMethodCallbackType f)
	{
		vtkProgrammableDataObjectSource_SetExecuteMethodArgDelete_09(GetCppThis(), f);
	}
}
