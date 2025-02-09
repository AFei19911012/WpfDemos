using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformationIntegerVectorKey
/// </summary>
/// <remarks>
///    Key for integer vector values.
///
/// vtkInformationIntegerVectorKey is used to represent keys for integer
/// vector values in vtkInformation.h
/// </remarks>
public class vtkInformationIntegerVectorKey : vtkInformationKey
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIntegerVectorKey";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformationIntegerVectorKey()
	{
		MRClassNameKey = "class vtkInformationIntegerVectorKey";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIntegerVectorKey"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformationIntegerVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkInformationIntegerVectorKey_Append_01(HandleRef pThis, HandleRef info, int value);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public void Append(vtkInformation info, int value)
	{
		vtkInformationIntegerVectorKey_Append_01(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationIntegerVectorKey_Get_02(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public IntPtr Get(vtkInformation info)
	{
		return vtkInformationIntegerVectorKey_Get_02(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationIntegerVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public int Get(vtkInformation info, int idx)
	{
		return vtkInformationIntegerVectorKey_Get_03(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), idx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationIntegerVectorKey_Get_04(HandleRef pThis, HandleRef info, IntPtr value);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public void Get(vtkInformation info, IntPtr value)
	{
		vtkInformationIntegerVectorKey_Get_04(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationIntegerVectorKey_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformationIntegerVectorKey_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationIntegerVectorKey_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformationIntegerVectorKey_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationIntegerVectorKey_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformationIntegerVectorKey_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationIntegerVectorKey_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformationIntegerVectorKey_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationIntegerVectorKey_Length_09(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public int Length(vtkInformation info)
	{
		return vtkInformationIntegerVectorKey_Length_09(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationIntegerVectorKey_MakeKey_10(string name, string location, int length, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method simply returns a new vtkInformationIntegerVectorKey, given a
	/// name, a location and a required length. This method is provided for
	/// wrappers. Use the constructor directly from C++ instead.
	/// </summary>
	public static vtkInformationIntegerVectorKey MakeKey(string name, string location, int length)
	{
		vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationIntegerVectorKey_MakeKey_10(name, location, length, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerVectorKey2 = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerVectorKey2.Register(null);
			}
		}
		return vtkInformationIntegerVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationIntegerVectorKey_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInformationIntegerVectorKey NewInstance()
	{
		vtkInformationIntegerVectorKey result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationIntegerVectorKey_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationIntegerVectorKey_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformationIntegerVectorKey SafeDownCast(vtkObjectBase o)
	{
		vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationIntegerVectorKey_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerVectorKey2 = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerVectorKey2.Register(null);
			}
		}
		return vtkInformationIntegerVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationIntegerVectorKey_Set_13(HandleRef pThis, HandleRef info, IntPtr value, int length);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public void Set(vtkInformation info, IntPtr value, int length)
	{
		vtkInformationIntegerVectorKey_Set_13(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), value, length);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationIntegerVectorKey_Set_14(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public void Set(vtkInformation info)
	{
		vtkInformationIntegerVectorKey_Set_14(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationIntegerVectorKey_ShallowCopy_15(HandleRef pThis, HandleRef from, HandleRef to);

	/// <summary>
	/// Copy the entry associated with this key from one information
	/// object to another.  If there is no entry in the first information
	/// object for this key, the value is removed from the second.
	/// </summary>
	public override void ShallowCopy(vtkInformation from, vtkInformation to)
	{
		vtkInformationIntegerVectorKey_ShallowCopy_15(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), to?.GetCppThis() ?? default(HandleRef));
	}
}
