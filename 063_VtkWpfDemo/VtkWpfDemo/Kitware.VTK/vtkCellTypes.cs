using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellTypes
/// </summary>
/// <remarks>
///    object provides direct access to cells in vtkCellArray and type information
///
/// This class is a supplemental object to vtkCellArray to allow random access
/// into cells as well as representing cell type information.  The "location"
/// field is the location in the vtkCellArray list in terms of an integer
/// offset.  An integer offset was used instead of a pointer for easy storage
/// and inter-process communication. The type information is defined in the
/// file vtkCellType.h.
///
/// @warning
/// Sometimes this class is used to pass type information independent of the
/// random access (i.e., location) information. For example, see
/// vtkDataSet::GetCellTypes(). If you use the class in this way, you can use
/// a location value of -1.
///
/// </remarks>
/// <seealso>
///
/// vtkCellArray vtkCellLinks
/// </seealso>
public class vtkCellTypes : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellTypes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellTypes()
	{
		MRClassNameKey = "class vtkCellTypes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellTypes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellTypes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellTypes New()
	{
		vtkCellTypes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTypes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCellTypes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellTypes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCellTypes_Allocate_01(HandleRef pThis, long sz, long ext);

	/// <summary>
	/// Allocate memory for this array. Delete old storage only if necessary.
	/// </summary>
	public int Allocate(long sz, long ext)
	{
		return vtkCellTypes_Allocate_01(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypes_DeepCopy_02(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Standard DeepCopy method.  Since this object contains no reference
	/// to other objects, there is no ShallowCopy.
	/// </summary>
	public void DeepCopy(vtkCellTypes src)
	{
		vtkCellTypes_DeepCopy_02(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypes_DeleteCell_03(HandleRef pThis, long cellId);

	/// <summary>
	/// Delete cell by setting to nullptr cell type.
	/// </summary>
	public void DeleteCell(long cellId)
	{
		vtkCellTypes_DeleteCell_03(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkCellTypes_GetActualMemorySize_04(HandleRef pThis);

	/// <summary>
	/// Return the memory in kibibytes (1024 bytes) consumed by this cell type array.
	/// Used to support streaming and reading/writing data. The value
	/// returned is guaranteed to be greater than or equal to the memory
	/// required to actually represent the data represented by this object.
	/// The information returned is valid only after the pipeline has
	/// been updated.
	/// </summary>
	public uint GetActualMemorySize()
	{
		return vtkCellTypes_GetActualMemorySize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypes_GetCellLocationsArray_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Methods for obtaining the arrays representing types and locations.
	/// </summary>
	public vtkIdTypeArray GetCellLocationsArray()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTypes_GetCellLocationsArray_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellTypes_GetCellType_06(HandleRef pThis, long cellId);

	/// <summary>
	/// Return the type of cell.
	/// </summary>
	public byte GetCellType(long cellId)
	{
		return vtkCellTypes_GetCellType_06(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypes_GetCellTypesArray_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Methods for obtaining the arrays representing types and locations.
	/// </summary>
	public vtkUnsignedCharArray GetCellTypesArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTypes_GetCellTypesArray_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypes_GetClassNameFromTypeId_08(int typeId);

	/// <summary>
	/// Given an int (as defined in vtkCellType.h) identifier for a class
	/// return it's classname.
	/// </summary>
	public static string GetClassNameFromTypeId(int typeId)
	{
		return Marshal.PtrToStringAnsi(vtkCellTypes_GetClassNameFromTypeId_08(typeId));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypes_GetDimension_09(byte type);

	/// <summary>
	/// Get the dimension of a cell.
	/// </summary>
	public static int GetDimension(byte type)
	{
		return vtkCellTypes_GetDimension_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTypes_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellTypes_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTypes_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellTypes_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTypes_GetNumberOfTypes_12(HandleRef pThis);

	/// <summary>
	/// Return the number of types in the list.
	/// </summary>
	public long GetNumberOfTypes()
	{
		return vtkCellTypes_GetNumberOfTypes_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypes_GetTypeIdFromClassName_13(string classname);

	/// <summary>
	/// Given a data object classname, return it's int identified (as
	/// defined in vtkCellType.h)
	/// </summary>
	public static int GetTypeIdFromClassName(string classname)
	{
		return vtkCellTypes_GetTypeIdFromClassName_13(classname);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypes_InsertCell_14(HandleRef pThis, long id, byte type, long loc);

	/// <summary>
	/// Add a cell at specified id.
	/// </summary>
	public void InsertCell(long id, byte type, long loc)
	{
		vtkCellTypes_InsertCell_14(GetCppThis(), id, type, loc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTypes_InsertNextCell_15(HandleRef pThis, byte type, long loc);

	/// <summary>
	/// Add a cell to the object in the next available slot.
	/// </summary>
	public long InsertNextCell(byte type, long loc)
	{
		return vtkCellTypes_InsertNextCell_15(GetCppThis(), type, loc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTypes_InsertNextType_16(HandleRef pThis, byte type);

	/// <summary>
	/// Add the type specified to the end of the list. Range checking is performed.
	/// </summary>
	public long InsertNextType(byte type)
	{
		return vtkCellTypes_InsertNextType_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypes_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellTypes_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypes_IsLinear_18(byte type);

	/// <summary>
	/// This convenience method is a fast check to determine if a cell type
	/// represents a linear or nonlinear cell.  This is generally much more
	/// efficient than getting the appropriate vtkCell and checking its IsLinear
	/// method.
	/// </summary>
	public static int IsLinear(byte type)
	{
		return vtkCellTypes_IsLinear_18(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypes_IsType_19(HandleRef pThis, byte type);

	/// <summary>
	/// Return 1 if type specified is contained in list; 0 otherwise.
	/// </summary>
	public int IsType(byte type)
	{
		return vtkCellTypes_IsType_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypes_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellTypes_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypes_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCellTypes NewInstance()
	{
		vtkCellTypes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTypes_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypes_Reset_23(HandleRef pThis);

	/// <summary>
	/// Initialize object without releasing memory.
	/// </summary>
	public void Reset()
	{
		vtkCellTypes_Reset_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypes_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellTypes SafeDownCast(vtkObjectBase o)
	{
		vtkCellTypes vtkCellTypes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTypes_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellTypes2 = (vtkCellTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellTypes2.Register(null);
			}
		}
		return vtkCellTypes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypes_SetCellTypes_25(HandleRef pThis, long ncells, HandleRef cellTypes);

	/// <summary>
	/// Specify a group of cell types.
	/// </summary>
	public void SetCellTypes(long ncells, vtkUnsignedCharArray cellTypes)
	{
		vtkCellTypes_SetCellTypes_25(GetCppThis(), ncells, cellTypes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypes_Squeeze_26(HandleRef pThis);

	/// <summary>
	/// Reclaim any extra memory.
	/// </summary>
	public void Squeeze()
	{
		vtkCellTypes_Squeeze_26(GetCppThis());
	}
}
