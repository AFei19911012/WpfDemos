using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSortFieldData
/// </summary>
/// <remarks>
///    provides a method for sorting field data
///
///
/// vtkSortFieldData is used to sort data, based on its value, or with an
/// associated key, into either ascending or descending order. This is useful
/// for operations like selection, or analysis, when evaluating and processing
/// data.
///
/// This class, which extends the base functionality of vtkSortDataArray,
/// is used to sort field data and its various subclasses (vtkFieldData,
/// vtkDataSetAttributes, vtkPointData, vtkCellData, etc.)
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly on
/// multi-core machines.
///
/// @warning
/// The sort methods below are static, hence the sorting methods can be
/// used without instantiating the class. All methods are thread safe.
///
/// </remarks>
/// <seealso>
///
/// vtkSortDataArray
/// </seealso>
public class vtkSortFieldData : vtkSortDataArray
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSortFieldData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSortFieldData()
	{
		MRClassNameKey = "class vtkSortFieldData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSortFieldData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSortFieldData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFieldData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new static vtkSortFieldData New()
	{
		vtkSortFieldData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortFieldData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSortFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public vtkSortFieldData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSortFieldData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSortFieldData_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSortFieldData_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSortFieldData_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSortFieldData_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortFieldData_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSortFieldData_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortFieldData_IsTypeOf_04(string type);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSortFieldData_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFieldData_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new vtkSortFieldData NewInstance()
	{
		vtkSortFieldData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortFieldData_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSortFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFieldData_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new static vtkSortFieldData SafeDownCast(vtkObjectBase o)
	{
		vtkSortFieldData vtkSortFieldData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortFieldData_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSortFieldData2 = (vtkSortFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSortFieldData2.Register(null);
			}
		}
		return vtkSortFieldData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFieldData_Sort_08(HandleRef fd, string arrayName, int k, int returnIndices);

	/// <summary>
	/// Given field data (and derived classes such as point data and cell data),
	/// sort all the arrays in the field data given an array and a component
	/// number k from that array. In other words, if an array has n components,
	/// the kth component is used to sort the array and all of the other arrays
	/// in the field data.  Also note that the user can indicate whether the
	/// function returns the sort indices (returnIndices=1). If the indices are
	/// returned, then the user takes ownership of the data and must delete
	/// it. Note that the indices are in sorted (ascending) order, and indicate
	/// the final sorted position of the sort. So for example indices[0]=10
	/// indicates that the original data in position 10 in the field, was moved
	/// to position 0 after the sort. By default, returnIndices=0. (Other notes:
	/// if any array is not the same length as the sorting array, then it will
	/// be skipped and not sorted.)
	/// </summary>
	public static IntPtr Sort(vtkFieldData fd, string arrayName, int k, int returnIndices)
	{
		return vtkSortFieldData_Sort_08(fd?.GetCppThis() ?? default(HandleRef), arrayName, k, returnIndices);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortFieldData_Sort_09(HandleRef fd, string arrayName, int k, int returnIndices, int dir);

	/// <summary>
	/// Given field data (and derived classes such as point data and cell data),
	/// sort all the arrays in the field data given an array and a component
	/// number k from that array. In other words, if an array has n components,
	/// the kth component is used to sort the array and all of the other arrays
	/// in the field data.  The order of the sorted data is goven by dir: dir=0
	/// means sort in ascending order; dir=1 means sort in descending
	/// order. Also note that the user can indicate whether the function returns
	/// the sort indices (returnIndices=1). If the indices are returned, then
	/// the user takes ownership of the data and must delete it. Note that the
	/// indices are always in sorted (ascending) order, and indicate the final
	/// sorted position of the sort. So for example indices[0]=10 indicates that
	/// the original data in position 10 in the field, was moved to position 0
	/// after the sort (i.e., position 0 is the smallest value). However, if
	/// sort direction dir=1, the indices do not change but the final shuffle of
	/// the data is in reverse order (note idx[n-1] for n keys is the largest
	/// value). By default, returnIndices=0. (Other notes: if any array is not
	/// the same length as the sorting array, then it will be skipped and not
	/// sorted.)
	/// </summary>
	public static IntPtr Sort(vtkFieldData fd, string arrayName, int k, int returnIndices, int dir)
	{
		return vtkSortFieldData_Sort_09(fd?.GetCppThis() ?? default(HandleRef), arrayName, k, returnIndices, dir);
	}
}
