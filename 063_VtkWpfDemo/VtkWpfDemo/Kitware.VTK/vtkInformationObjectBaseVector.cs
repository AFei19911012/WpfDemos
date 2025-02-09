using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformationObjectBaseVectorKey
/// </summary>
/// <remarks>
///    Key for vtkObjectBase vector values.
///
/// vtkInformationObjectBaseVectorKey is used to represent keys for double
/// vector values in vtkInformation.h. NOTE the interface in this key differs
/// from that in other similar keys because of our internal use of smart
/// pointers.
/// </remarks>
public class vtkInformationObjectBaseVectorKey : vtkInformationKey
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformationObjectBaseVectorKey";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformationObjectBaseVectorKey()
	{
		MRClassNameKey = "class vtkInformationObjectBaseVectorKey";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationObjectBaseVectorKey"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformationObjectBaseVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationObjectBaseVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef value);

	/// <summary>
	/// Put the value on the back of the vector, with ref counting.
	/// </summary>
	public void Append(vtkInformation info, vtkObjectBase value)
	{
		vtkInformationObjectBaseVectorKey_Append_01(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationObjectBaseVectorKey_Clear_02(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Clear the vector.
	/// </summary>
	public void Clear(vtkInformation info)
	{
		vtkInformationObjectBaseVectorKey_Clear_02(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationObjectBaseVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkObjectBase at a specific location in the vector.
	/// </summary>
	public vtkObjectBase Get(vtkInformation info, int idx)
	{
		vtkObjectBase vtkObjectBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationObjectBaseVectorKey_Get_03(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObjectBase2 = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObjectBase2.Register(null);
			}
		}
		return vtkObjectBase2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationObjectBaseVectorKey_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformationObjectBaseVectorKey_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationObjectBaseVectorKey_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformationObjectBaseVectorKey_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationObjectBaseVectorKey_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformationObjectBaseVectorKey_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationObjectBaseVectorKey_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformationObjectBaseVectorKey_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationObjectBaseVectorKey_Length_08(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get the vector's length.
	/// </summary>
	public int Length(vtkInformation info)
	{
		return vtkInformationObjectBaseVectorKey_Length_08(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationObjectBaseVectorKey_MakeKey_09(string name, string location, string requiredClass, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method simply returns a new vtkInformationObjectBaseVectorKey, given a
	/// name, location and optionally a required class (a classname to restrict
	/// which class types can be set with this key). This method is provided
	/// for wrappers. Use the constructor directly from C++ instead.
	/// </summary>
	public static vtkInformationObjectBaseVectorKey MakeKey(string name, string location, string requiredClass)
	{
		vtkInformationObjectBaseVectorKey vtkInformationObjectBaseVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationObjectBaseVectorKey_MakeKey_09(name, location, requiredClass, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseVectorKey2 = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseVectorKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationObjectBaseVectorKey_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInformationObjectBaseVectorKey NewInstance()
	{
		vtkInformationObjectBaseVectorKey result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationObjectBaseVectorKey_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationObjectBaseVectorKey_Remove_11(HandleRef pThis, HandleRef info, HandleRef val);

	/// <summary>
	/// Remove all instances of val from the list. If using the indexed overload,
	/// the object at the specified position is removed.
	/// </summary>
	public void Remove(vtkInformation info, vtkObjectBase val)
	{
		vtkInformationObjectBaseVectorKey_Remove_11(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), val?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationObjectBaseVectorKey_Remove_12(HandleRef pThis, HandleRef info, int idx);

	/// <summary>
	/// Remove all instances of val from the list. If using the indexed overload,
	/// the object at the specified position is removed.
	/// </summary>
	public void Remove(vtkInformation info, int idx)
	{
		vtkInformationObjectBaseVectorKey_Remove_12(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), idx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationObjectBaseVectorKey_Resize_13(HandleRef pThis, HandleRef info, int size);

	/// <summary>
	/// Resize (extend) the vector to hold size objects. Any new elements
	/// created will be null initialized.
	/// </summary>
	public void Resize(vtkInformation info, int size)
	{
		vtkInformationObjectBaseVectorKey_Resize_13(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), size);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationObjectBaseVectorKey_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformationObjectBaseVectorKey SafeDownCast(vtkObjectBase o)
	{
		vtkInformationObjectBaseVectorKey vtkInformationObjectBaseVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationObjectBaseVectorKey_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseVectorKey2 = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseVectorKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationObjectBaseVectorKey_Set_15(HandleRef pThis, HandleRef info, HandleRef value, int i);

	/// <summary>
	/// Set element i of the vector to value. Resizes the vector
	/// if needed.
	/// </summary>
	public void Set(vtkInformation info, vtkObjectBase value, int i)
	{
		vtkInformationObjectBaseVectorKey_Set_15(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef), i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationObjectBaseVectorKey_ShallowCopy_16(HandleRef pThis, HandleRef source, HandleRef dest);

	/// <summary>
	/// Copy the entry associated with this key from one information
	/// object to another.  If there is no entry in the first information
	/// object for this key, the value is removed from the second.
	/// </summary>
	public override void ShallowCopy(vtkInformation source, vtkInformation dest)
	{
		vtkInformationObjectBaseVectorKey_ShallowCopy_16(GetCppThis(), source?.GetCppThis() ?? default(HandleRef), dest?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationObjectBaseVectorKey_Size_17(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get the vector's length.
	/// </summary>
	public int Size(vtkInformation info)
	{
		return vtkInformationObjectBaseVectorKey_Size_17(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}
}
