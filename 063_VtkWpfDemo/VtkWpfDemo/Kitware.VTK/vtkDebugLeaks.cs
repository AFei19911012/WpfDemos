using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkDebugLeaks
/// </summary>
/// <remarks>
///  identify memory leaks at program termination
/// vtkDebugLeaks is used to report memory leaks at the exit of the program. It
/// uses vtkObjectBase::InitializeObjectBase() (called via vtkObjectFactory
/// macros) to intercept the construction of all VTK objects. It uses the
/// UnRegisterInternal method of vtkObjectBase to intercept the destruction of
/// all objects.
///
/// If not using the vtkObjectFactory macros to implement New(), be sure to call
/// vtkObjectBase::InitializeObjectBase() explicitly on the constructed
/// instance. The rule of thumb is that wherever "new [some vtkObjectBase
/// subclass]" is called, vtkObjectBase::InitializeObjectBase() must be called
/// as well.
///
/// There are exceptions to this:
///
/// - vtkCommand subclasses traditionally do not fully participate in
/// vtkDebugLeaks registration, likely because they typically do not use
/// vtkTypeMacro to configure GetClassName. InitializeObjectBase should not be
/// called on vtkCommand subclasses, and all such classes will be automatically
/// registered with vtkDebugLeaks as "vtkCommand or subclass".
///
/// - vtkInformationKey subclasses are not reference counted. They are allocated
/// statically and registered automatically with a singleton "manager" instance.
/// The manager ensures that all keys are cleaned up before exiting, and
/// registration/deregistration with vtkDebugLeaks is bypassed.
///
/// A table of object name to number of instances is kept. At the exit of the
/// program if there are still VTK objects around it will print them out. To
/// enable this class add the flag -DVTK_DEBUG_LEAKS to the compile line, and
/// rebuild vtkObject and vtkObjectFactory.
/// </remarks>
public class vtkDebugLeaks : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDebugLeaks";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDebugLeaks()
	{
		MRClassNameKey = "class vtkDebugLeaks";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDebugLeaks"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDebugLeaks(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDebugLeaks_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDebugLeaks New()
	{
		vtkDebugLeaks result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDebugLeaks_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDebugLeaks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDebugLeaks()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDebugLeaks_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDebugLeaks_ConstructClass_01(HandleRef arg0);

	/// <summary>
	/// Call this when creating a class.
	/// </summary>
	public static void ConstructClass(vtkObjectBase arg0)
	{
		vtkDebugLeaks_ConstructClass_01(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDebugLeaks_ConstructClass_02(string className);

	/// <summary>
	/// Call this when creating a vtkCommand or subclasses.
	/// </summary>
	public static void ConstructClass(string className)
	{
		vtkDebugLeaks_ConstructClass_02(className);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDebugLeaks_DestructClass_03(HandleRef arg0);

	/// <summary>
	/// Call this when deleting a class.
	/// </summary>
	public static void DestructClass(vtkObjectBase arg0)
	{
		vtkDebugLeaks_DestructClass_03(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDebugLeaks_DestructClass_04(string className);

	/// <summary>
	/// Call this when deleting vtkCommand or a subclass.
	/// </summary>
	public static void DestructClass(string className)
	{
		vtkDebugLeaks_DestructClass_04(className);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDebugLeaks_GetExitError_05();

	/// <summary>
	/// Get/Set flag for exiting with an error when leaks are present.
	/// Default is on when VTK_DEBUG_LEAKS is on and off otherwise.
	/// </summary>
	public static int GetExitError()
	{
		return vtkDebugLeaks_GetExitError_05();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDebugLeaks_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDebugLeaks_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDebugLeaks_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDebugLeaks_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDebugLeaks_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDebugLeaks_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDebugLeaks_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDebugLeaks_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDebugLeaks_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDebugLeaks NewInstance()
	{
		vtkDebugLeaks result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDebugLeaks_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDebugLeaks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDebugLeaks_PrintCurrentLeaks_12();

	/// <summary>
	/// Print all the values in the table.  Returns non-zero if there
	/// were leaks.
	/// </summary>
	public static int PrintCurrentLeaks()
	{
		return vtkDebugLeaks_PrintCurrentLeaks_12();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDebugLeaks_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDebugLeaks SafeDownCast(vtkObjectBase o)
	{
		vtkDebugLeaks vtkDebugLeaks2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDebugLeaks_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDebugLeaks2 = (vtkDebugLeaks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDebugLeaks2.Register(null);
			}
		}
		return vtkDebugLeaks2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDebugLeaks_SetExitError_14(int arg0);

	/// <summary>
	/// Get/Set flag for exiting with an error when leaks are present.
	/// Default is on when VTK_DEBUG_LEAKS is on and off otherwise.
	/// </summary>
	public static void SetExitError(int arg0)
	{
		vtkDebugLeaks_SetExitError_14(arg0);
	}
}
