using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkObjectFactory
/// </summary>
/// <remarks>
///    abstract base class for vtkObjectFactories
///
/// vtkObjectFactory is used to create vtk objects.   The base class
/// vtkObjectFactory contains a static method CreateInstance which is used
/// to create vtk objects from the list of registered vtkObjectFactory
/// sub-classes.   The first time CreateInstance is called, all dll's or shared
/// libraries in the environment variable VTK_AUTOLOAD_PATH are loaded into
/// the current process.   The C functions vtkLoad, and vtkGetFactoryVersion are
/// called on each dll.  To implement these functions in a shared library or
/// dll, use the macro:
/// VTK_FACTORY_INTERFACE_IMPLEMENT.
/// VTK_AUTOLOAD_PATH is an environment variable
/// containing a colon separated (semi-colon on win32) list of paths.
///
/// The vtkObjectFactory can be use to override the creation of any object
/// in VTK with a sub-class of that object.  The factories can be registered
/// either at run time with the VTK_AUTOLOAD_PATH, or at compile time
/// with the vtkObjectFactory::RegisterFactory method.
///
/// </remarks>
public abstract class vtkObjectFactory : vtkObject
{
	/// <summary>
	/// This returns the path to a dynamically loaded factory.
	/// </summary>
	public delegate IntPtr CreateFunction();

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkObjectFactory";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkObjectFactory()
	{
		MRClassNameKey = "class vtkObjectFactory";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectFactory"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkObjectFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkObjectFactory_CreateAllInstance_01(string vtkclassname, HandleRef retList);

	/// <summary>
	/// Create all possible instances of the named vtk object.
	/// Each registered vtkObjectFactory will be asked, and the
	/// result will be stored in the user allocated vtkCollection
	/// passed in to the function.
	/// </summary>
	public static void CreateAllInstance(string vtkclassname, vtkCollection retList)
	{
		vtkObjectFactory_CreateAllInstance_01(vtkclassname, retList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_CreateInstance_02(string vtkclassname, byte isAbstract, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create and return an instance of the named vtk object.
	/// Each loaded vtkObjectFactory will be asked in the order
	/// the factory was in the VTK_AUTOLOAD_PATH.  After the
	/// first factory returns the object no other factories are asked.
	/// isAbstract is no longer used. This method calls
	/// vtkObjectBase::InitializeObjectBase() on the instance when the
	/// return value is non-nullptr.
	/// </summary>
	public static vtkObject CreateInstance(string vtkclassname, bool isAbstract)
	{
		vtkObject result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObjectFactory_CreateInstance_02(vtkclassname, (byte)(isAbstract ? 1u : 0u), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectFactory_Disable_03(HandleRef pThis, string className);

	/// <summary>
	/// Set all enable flags for the given class to 0.  This will
	/// mean that the factory will stop producing class with the given
	/// name.
	/// </summary>
	public virtual void Disable(string className)
	{
		vtkObjectFactory_Disable_03(GetCppThis(), className);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_GetClassOverrideName_04(HandleRef pThis, int index);

	/// <summary>
	/// Return the name of a class override at the given index.
	/// </summary>
	public virtual string GetClassOverrideName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkObjectFactory_GetClassOverrideName_04(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_GetClassOverrideWithName_05(HandleRef pThis, int index);

	/// <summary>
	/// Return the name of the class that will override the class
	/// at the given index
	/// </summary>
	public virtual string GetClassOverrideWithName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkObjectFactory_GetClassOverrideWithName_05(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_GetDescription_06(HandleRef pThis);

	/// <summary>
	/// Return a descriptive string describing the factory.
	/// </summary>
	public virtual string GetDescription()
	{
		return Marshal.PtrToStringAnsi(vtkObjectFactory_GetDescription_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectFactory_GetEnableFlag_07(HandleRef pThis, int index);

	/// <summary>
	/// Return the enable flag for the class at the given index.
	/// </summary>
	public virtual int GetEnableFlag(int index)
	{
		return vtkObjectFactory_GetEnableFlag_07(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectFactory_GetEnableFlag_08(HandleRef pThis, string className, string subclassName);

	/// <summary>
	/// Set and Get the Enable flag for the specific override of className.
	/// if subclassName is null, then it is ignored.
	/// </summary>
	public virtual int GetEnableFlag(string className, string subclassName)
	{
		return vtkObjectFactory_GetEnableFlag_08(GetCppThis(), className, subclassName);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_GetLibraryPath_09(HandleRef pThis);

	/// <summary>
	/// This returns the path to a dynamically loaded factory.
	/// </summary>
	public virtual string GetLibraryPath()
	{
		return Marshal.PtrToStringAnsi(vtkObjectFactory_GetLibraryPath_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkObjectFactory_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Set the enable flag for a given named class subclass pair
	/// for all registered factories.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkObjectFactory_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkObjectFactory_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Set the enable flag for a given named class subclass pair
	/// for all registered factories.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkObjectFactory_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectFactory_GetNumberOfOverrides_12(HandleRef pThis);

	/// <summary>
	/// Return number of overrides this factory can create.
	/// </summary>
	public virtual int GetNumberOfOverrides()
	{
		return vtkObjectFactory_GetNumberOfOverrides_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_GetOverrideDescription_13(HandleRef pThis, int index);

	/// <summary>
	/// Return the description for a the class override at the given
	/// index.
	/// </summary>
	public virtual string GetOverrideDescription(int index)
	{
		return Marshal.PtrToStringAnsi(vtkObjectFactory_GetOverrideDescription_13(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectFactory_GetOverrideInformation_14(string name, HandleRef arg1);

	/// <summary>
	/// Fill the given collection with all the overrides for
	/// the class with the given name.
	/// </summary>
	public static void GetOverrideInformation(string name, vtkOverrideInformationCollection arg1)
	{
		vtkObjectFactory_GetOverrideInformation_14(name, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_GetRegisteredFactories_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the list of all registered factories.  This is NOT a copy,
	/// do not remove items from this list!
	/// </summary>
	public static vtkObjectFactoryCollection GetRegisteredFactories()
	{
		vtkObjectFactoryCollection vtkObjectFactoryCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObjectFactory_GetRegisteredFactories_15(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObjectFactoryCollection2 = (vtkObjectFactoryCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObjectFactoryCollection2.Register(null);
			}
		}
		return vtkObjectFactoryCollection2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_GetVTKSourceVersion_16(HandleRef pThis);

	/// <summary>
	/// All sub-classes of vtkObjectFactory should must return the version of
	/// VTK they were built with.  This should be implemented with the macro
	/// VTK_SOURCE_VERSION and NOT a call to vtkVersion::GetVTKSourceVersion.
	/// As the version needs to be compiled into the file as a string constant.
	/// This is critical to determine possible incompatible dynamic factory loads.
	/// </summary>
	public virtual string GetVTKSourceVersion()
	{
		return Marshal.PtrToStringAnsi(vtkObjectFactory_GetVTKSourceVersion_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectFactory_HasOverride_17(HandleRef pThis, string className);

	/// <summary>
	/// Return 1 if this factory overrides the given class name, 0 otherwise.
	/// </summary>
	public virtual int HasOverride(string className)
	{
		return vtkObjectFactory_HasOverride_17(GetCppThis(), className);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectFactory_HasOverride_18(HandleRef pThis, string className, string subclassName);

	/// <summary>
	/// Return 1 if this factory overrides the given class name, 0 otherwise.
	/// </summary>
	public virtual int HasOverride(string className, string subclassName)
	{
		return vtkObjectFactory_HasOverride_18(GetCppThis(), className, subclassName);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectFactory_HasOverrideAny_19(string className);

	/// <summary>
	/// return 1 if one of the registered factories
	/// overrides the given class name
	/// </summary>
	public static int HasOverrideAny(string className)
	{
		return vtkObjectFactory_HasOverrideAny_19(className);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectFactory_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Set the enable flag for a given named class subclass pair
	/// for all registered factories.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkObjectFactory_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectFactory_IsTypeOf_21(string type);

	/// <summary>
	/// Set the enable flag for a given named class subclass pair
	/// for all registered factories.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkObjectFactory_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the enable flag for a given named class subclass pair
	/// for all registered factories.
	/// </summary>
	public new vtkObjectFactory NewInstance()
	{
		vtkObjectFactory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObjectFactory_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkObjectFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectFactory_ReHash_23();

	/// <summary>
	/// Re-check the VTK_AUTOLOAD_PATH for new factory libraries.
	/// This calls UnRegisterAll before re-loading
	/// </summary>
	public static void ReHash()
	{
		vtkObjectFactory_ReHash_23();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectFactory_RegisterFactory_24(HandleRef arg0);

	/// <summary>
	/// Register a factory so it can be used to create vtk objects
	/// </summary>
	public static void RegisterFactory(vtkObjectFactory arg0)
	{
		vtkObjectFactory_RegisterFactory_24(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectFactory_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the enable flag for a given named class subclass pair
	/// for all registered factories.
	/// </summary>
	public new static vtkObjectFactory SafeDownCast(vtkObjectBase o)
	{
		vtkObjectFactory vtkObjectFactory2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObjectFactory_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObjectFactory2 = (vtkObjectFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObjectFactory2.Register(null);
			}
		}
		return vtkObjectFactory2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectFactory_SetAllEnableFlags_26(int flag, string className);

	/// <summary>
	/// Set the enable flag for a given named class for all registered
	/// factories.
	/// </summary>
	public static void SetAllEnableFlags(int flag, string className)
	{
		vtkObjectFactory_SetAllEnableFlags_26(flag, className);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectFactory_SetAllEnableFlags_27(int flag, string className, string subclassName);

	/// <summary>
	/// Set the enable flag for a given named class subclass pair
	/// for all registered factories.
	/// </summary>
	public static void SetAllEnableFlags(int flag, string className, string subclassName)
	{
		vtkObjectFactory_SetAllEnableFlags_27(flag, className, subclassName);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectFactory_SetEnableFlag_28(HandleRef pThis, int flag, string className, string subclassName);

	/// <summary>
	/// Set and Get the Enable flag for the specific override of className.
	/// if subclassName is null, then it is ignored.
	/// </summary>
	public virtual void SetEnableFlag(int flag, string className, string subclassName)
	{
		vtkObjectFactory_SetEnableFlag_28(GetCppThis(), flag, className, subclassName);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectFactory_UnRegisterAllFactories_29();

	/// <summary>
	/// Unregister all factories
	/// </summary>
	public static void UnRegisterAllFactories()
	{
		vtkObjectFactory_UnRegisterAllFactories_29();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectFactory_UnRegisterFactory_30(HandleRef arg0);

	/// <summary>
	/// Remove a factory from the list of registered factories
	/// </summary>
	public static void UnRegisterFactory(vtkObjectFactory arg0)
	{
		vtkObjectFactory_UnRegisterFactory_30(arg0?.GetCppThis() ?? default(HandleRef));
	}
}
