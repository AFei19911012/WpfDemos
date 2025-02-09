using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataObject
/// </summary>
/// <remarks>
///    helper class to get VTK data object types as string and instantiate them
///
/// vtkDataObjectTypes is a helper class that supports conversion between
/// integer types defined in vtkType.h and string names as well as creation
/// of data objects from either integer or string types. This class has
/// to be updated every time a new data type is added to VTK.
/// </remarks>
/// <seealso>
///
/// vtkDataObject
/// </seealso>
public class vtkDataObjectTypes : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectTypes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataObjectTypes()
	{
		MRClassNameKey = "class vtkDataObjectTypes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectTypes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataObjectTypes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTypes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObjectTypes New()
	{
		vtkDataObjectTypes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTypes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObjectTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataObjectTypes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataObjectTypes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObjectTypes_GetClassNameFromTypeId_01(int typeId);

	/// <summary>
	/// Given an int (as defined in vtkType.h) identifier for a class
	/// return it's classname.
	/// </summary>
	public static string GetClassNameFromTypeId(int typeId)
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectTypes_GetClassNameFromTypeId_01(typeId));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTypes_GetCommonBaseTypeId_02(int typeA, int typeB);

	/// <summary>
	/// Given two data types, returns the closest common data type.
	/// If both data types ids are valid, at worse, this will return
	/// `VTK_DATA_OBJECT`. If one of the types is invalid (or unknown),
	/// simply returns the valid (or known) type. If both are invalid, returns -1.
	/// </summary>
	public static int GetCommonBaseTypeId(int typeA, int typeB)
	{
		return vtkDataObjectTypes_GetCommonBaseTypeId_02(typeA, typeB);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectTypes_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataObjectTypes_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectTypes_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataObjectTypes_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTypes_GetTypeIdFromClassName_05(string classname);

	/// <summary>
	/// Given a data object classname, return it's int identified (as
	/// defined in vtkType.h)
	/// </summary>
	public static int GetTypeIdFromClassName(string classname)
	{
		return vtkDataObjectTypes_GetTypeIdFromClassName_05(classname);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTypes_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataObjectTypes_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTypes_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataObjectTypes_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTypes_NewDataObject_09(string classname, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create (New) and return a data object of the given classname.
	/// </summary>
	public static vtkDataObject NewDataObject(string classname)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTypes_NewDataObject_09(classname, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTypes_NewDataObject_10(int typeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create (New) and return a data object of the given type id.
	/// </summary>
	public static vtkDataObject NewDataObject(int typeId)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTypes_NewDataObject_10(typeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTypes_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataObjectTypes NewInstance()
	{
		vtkDataObjectTypes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTypes_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObjectTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTypes_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObjectTypes SafeDownCast(vtkObjectBase o)
	{
		vtkDataObjectTypes vtkDataObjectTypes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTypes_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObjectTypes2 = (vtkDataObjectTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObjectTypes2.Register(null);
			}
		}
		return vtkDataObjectTypes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataObjectTypes_TypeIdIsA_13(int typeId, int targetTypeId);

	/// <summary>
	/// Create (New) and return a data object of the given type id.
	/// </summary>
	public static bool TypeIdIsA(int typeId, int targetTypeId)
	{
		return (vtkDataObjectTypes_TypeIdIsA_13(typeId, targetTypeId) != 0) ? true : false;
	}
}
