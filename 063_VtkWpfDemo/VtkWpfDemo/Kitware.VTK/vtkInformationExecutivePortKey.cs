using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformationExecutivePortKey
/// </summary>
/// <remarks>
///    Key for vtkExecutive/Port value pairs.
///
/// vtkInformationExecutivePortKey is used to represent keys in
/// vtkInformation for values that are vtkExecutive instances paired
/// with port numbers.
/// </remarks>
public class vtkInformationExecutivePortKey : vtkInformationKey
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformationExecutivePortKey";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformationExecutivePortKey()
	{
		MRClassNameKey = "class vtkInformationExecutivePortKey";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationExecutivePortKey"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformationExecutivePortKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationExecutivePortKey_Get_01(HandleRef pThis, HandleRef info, HandleRef executive, ref int port);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public void Get(vtkInformation info, vtkExecutive executive, ref int port)
	{
		vtkInformationExecutivePortKey_Get_01(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), executive?.GetCppThis() ?? default(HandleRef), ref port);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationExecutivePortKey_GetExecutive_02(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public vtkExecutive GetExecutive(vtkInformation info)
	{
		vtkExecutive vtkExecutive2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationExecutivePortKey_GetExecutive_02(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExecutive2 = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExecutive2.Register(null);
			}
		}
		return vtkExecutive2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationExecutivePortKey_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformationExecutivePortKey_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationExecutivePortKey_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformationExecutivePortKey_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationExecutivePortKey_GetPort_05(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public int GetPort(vtkInformation info)
	{
		return vtkInformationExecutivePortKey_GetPort_05(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationExecutivePortKey_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformationExecutivePortKey_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationExecutivePortKey_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformationExecutivePortKey_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationExecutivePortKey_MakeKey_08(string name, string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method simply returns a new vtkInformationExecutivePortKey, given a
	/// name and a location. This method is provided for wrappers. Use the
	/// constructor directly from C++ instead.
	/// </summary>
	public static vtkInformationExecutivePortKey MakeKey(string name, string location)
	{
		vtkInformationExecutivePortKey vtkInformationExecutivePortKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationExecutivePortKey_MakeKey_08(name, location, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationExecutivePortKey2 = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationExecutivePortKey2.Register(null);
			}
		}
		return vtkInformationExecutivePortKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationExecutivePortKey_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInformationExecutivePortKey NewInstance()
	{
		vtkInformationExecutivePortKey result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationExecutivePortKey_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationExecutivePortKey_Report_10(HandleRef pThis, HandleRef info, HandleRef collector);

	/// <summary>
	/// Report a reference this key has in the given information object.
	/// </summary>
	public override void Report(vtkInformation info, vtkGarbageCollector collector)
	{
		vtkInformationExecutivePortKey_Report_10(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), collector?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationExecutivePortKey_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformationExecutivePortKey SafeDownCast(vtkObjectBase o)
	{
		vtkInformationExecutivePortKey vtkInformationExecutivePortKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationExecutivePortKey_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationExecutivePortKey2 = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationExecutivePortKey2.Register(null);
			}
		}
		return vtkInformationExecutivePortKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationExecutivePortKey_Set_12(HandleRef pThis, HandleRef info, HandleRef arg1, int arg2);

	/// <summary>
	/// Get/Set the value associated with this key in the given
	/// information object.
	/// </summary>
	public void Set(vtkInformation info, vtkExecutive arg1, int arg2)
	{
		vtkInformationExecutivePortKey_Set_12(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationExecutivePortKey_ShallowCopy_13(HandleRef pThis, HandleRef from, HandleRef to);

	/// <summary>
	/// Copy the entry associated with this key from one information
	/// object to another.  If there is no entry in the first information
	/// object for this key, the value is removed from the second.
	/// </summary>
	public override void ShallowCopy(vtkInformation from, vtkInformation to)
	{
		vtkInformationExecutivePortKey_ShallowCopy_13(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), to?.GetCppThis() ?? default(HandleRef));
	}
}
