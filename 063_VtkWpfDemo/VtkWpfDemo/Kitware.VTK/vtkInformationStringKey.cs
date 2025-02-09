using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformationStringKey
/// </summary>
/// <remarks>
///    Key for string values in vtkInformation.
///
/// vtkInformationStringKey is used to represent keys for string values
/// in vtkInformation.
/// </remarks>
public class vtkInformationStringKey : vtkInformationKey
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformationStringKey";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformationStringKey()
	{
		MRClassNameKey = "class vtkInformationStringKey";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationStringKey"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformationStringKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkInformationStringKey_Get_01(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public string Get(vtkInformation info)
	{
		return Marshal.PtrToStringAnsi(vtkInformationStringKey_Get_01(GetCppThis(), info?.GetCppThis() ?? default(HandleRef)));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationStringKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformationStringKey_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationStringKey_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformationStringKey_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationStringKey_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformationStringKey_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationStringKey_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformationStringKey_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationStringKey_MakeKey_06(string name, string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method simply returns a new vtkInformationStringKey, given a
	/// name and a location. This method is provided for wrappers. Use the
	/// constructor directly from C++ instead.
	/// </summary>
	public static vtkInformationStringKey MakeKey(string name, string location)
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationStringKey_MakeKey_06(name, location, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringKey2 = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringKey2.Register(null);
			}
		}
		return vtkInformationStringKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationStringKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInformationStringKey NewInstance()
	{
		vtkInformationStringKey result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationStringKey_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationStringKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformationStringKey SafeDownCast(vtkObjectBase o)
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationStringKey_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringKey2 = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringKey2.Register(null);
			}
		}
		return vtkInformationStringKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationStringKey_Set_09(HandleRef pThis, HandleRef info, string arg1);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public void Set(vtkInformation info, string arg1)
	{
		vtkInformationStringKey_Set_09(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), arg1);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationStringKey_ShallowCopy_10(HandleRef pThis, HandleRef from, HandleRef to);

	/// <summary>
	/// Copy the entry associated with this key from one information
	/// object to another.  If there is no entry in the first information
	/// object for this key, the value is removed from the second.
	/// </summary>
	public override void ShallowCopy(vtkInformation from, vtkInformation to)
	{
		vtkInformationStringKey_ShallowCopy_10(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), to?.GetCppThis() ?? default(HandleRef));
	}
}
