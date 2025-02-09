using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformationKey
/// </summary>
/// <remarks>
///    Superclass for vtkInformation keys.
///
/// vtkInformationKey is the superclass for all keys used to access the
/// map represented by vtkInformation.  The vtkInformation::Set and
/// vtkInformation::Get methods of vtkInformation are accessed by
/// information keys.  A key is a pointer to an instance of a subclass
/// of vtkInformationKey.  The type of the subclass determines the
/// overload of Set/Get that is selected.  This ensures that the type
/// of value stored in a vtkInformation instance corresponding to a
/// given key matches the type expected for that key.
/// </remarks>
public abstract class vtkInformationKey : vtkObjectBase
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformationKey";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformationKey()
	{
		MRClassNameKey = "class vtkInformationKey";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationKey"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformationKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationKey_Register_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Prevent normal vtkObject reference counting behavior.
	/// </summary>
	public override void Register(vtkObjectBase arg0)
	{
		vtkInformationKey_Register_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationKey_UnRegister_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Prevent normal vtkObject reference counting behavior.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (GetCallDisposalMethod())
			{
				vtkInformationKey_UnRegister_19(GetCppThis(), default(HandleRef));
				ClearCppThis();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationKey_CopyDefaultInformation_01(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

	/// <summary>
	/// This function is only relevant when the pertaining key
	/// is used in a VTK pipeline. By overwriting this method, a
	/// key can decide if/how to copy itself downstream or upstream
	/// during a particular pipeline pass. For example, meta-data keys
	/// can copy themselves during REQUEST_INFORMATION whereas request
	/// keys can copy themselves during REQUEST_UPDATE_EXTENT.
	/// </summary>
	public virtual void CopyDefaultInformation(vtkInformation arg0, vtkInformation arg1, vtkInformation arg2)
	{
		vtkInformationKey_CopyDefaultInformation_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationKey_DeepCopy_02(HandleRef pThis, HandleRef from, HandleRef to);

	/// <summary>
	/// Duplicate (new instance created) the entry associated with this key from
	/// one information object to another (new instances of any contained
	/// vtkInformation and vtkInformationVector objects are created).
	/// Default implementation simply calls ShallowCopy().
	/// </summary>
	public virtual void DeepCopy(vtkInformation from, vtkInformation to)
	{
		vtkInformationKey_DeepCopy_02(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), to?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationKey_GetLocation_03(HandleRef pThis);

	/// <summary>
	/// Get the location of the key.  This is the name of the class in
	/// which the key is defined.
	/// </summary>
	public string GetLocation()
	{
		return Marshal.PtrToStringAnsi(vtkInformationKey_GetLocation_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationKey_GetName_04(HandleRef pThis);

	/// <summary>
	/// Get the name of the key.  This is not the type of the key, but
	/// the name of the key instance.
	/// </summary>
	public string GetName()
	{
		return Marshal.PtrToStringAnsi(vtkInformationKey_GetName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationKey_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformationKey_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationKey_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformationKey_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationKey_Has_07(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Check whether this key appears in the given information object.
	/// </summary>
	public virtual int Has(vtkInformation info)
	{
		return vtkInformationKey_Has_07(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationKey_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformationKey_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationKey_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformationKey_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInformationKey_NeedToExecute_10(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// This function is only relevant when the pertaining key
	/// is used in a VTK pipeline. Specific keys that handle
	/// pipeline data requests (for example, UPDATE_PIECE_NUMBER)
	/// can overwrite this method to notify the pipeline that a
	/// a filter should be (re-)executed because what is in
	/// the current output is different that what is being requested
	/// by the key. For example, DATA_PIECE_NUMBER != UPDATE_PIECE_NUMBER.
	/// </summary>
	public virtual bool NeedToExecute(vtkInformation arg0, vtkInformation arg1)
	{
		return (vtkInformationKey_NeedToExecute_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationKey_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInformationKey NewInstance()
	{
		vtkInformationKey result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationKey_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationKey_Print_12(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Print the key's value in an information object to a stream.
	/// </summary>
	public void Print(vtkInformation info)
	{
		vtkInformationKey_Print_12(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationKey_Remove_14(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Remove this key from the given information object.
	/// </summary>
	public virtual void Remove(vtkInformation info)
	{
		vtkInformationKey_Remove_14(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationKey_Report_15(HandleRef pThis, HandleRef info, HandleRef collector);

	/// <summary>
	/// Report a reference this key has in the given information object.
	/// </summary>
	public virtual void Report(vtkInformation info, vtkGarbageCollector collector)
	{
		vtkInformationKey_Report_15(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), collector?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationKey_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkInformationKey SafeDownCast(vtkObjectBase o)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationKey_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationKey_ShallowCopy_17(HandleRef pThis, HandleRef from, HandleRef to);

	/// <summary>
	/// Copy the entry associated with this key from one information
	/// object to another.  If there is no entry in the first information
	/// object for this key, the value is removed from the second.
	/// </summary>
	public virtual void ShallowCopy(vtkInformation from, vtkInformation to)
	{
		vtkInformationKey_ShallowCopy_17(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), to?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationKey_StoreMetaData_18(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

	/// <summary>
	/// This function is only relevant when the pertaining key
	/// is used in a VTK pipeline. Specific keys that handle
	/// pipeline data requests (for example, UPDATE_PIECE_NUMBER)
	/// can overwrite this method to store in the data information
	/// meta-data about the request that led to the current filter
	/// execution. This meta-data can later be used to compare what
	/// is being requested to decide whether the filter needs to
	/// re-execute. For example, a filter may store the current
	/// UPDATE_PIECE_NUMBER in the data object's information as
	/// the DATA_PIECE_NUMBER. DATA_PIECE_NUMBER can later be compared
	/// to a new UPDATA_PIECE_NUMBER to decide whether a filter should
	/// re-execute.
	/// </summary>
	public virtual void StoreMetaData(vtkInformation arg0, vtkInformation arg1, vtkInformation arg2)
	{
		vtkInformationKey_StoreMetaData_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2?.GetCppThis() ?? default(HandleRef));
	}
}
