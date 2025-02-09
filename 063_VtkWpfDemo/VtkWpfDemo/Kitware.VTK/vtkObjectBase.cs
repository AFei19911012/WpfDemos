using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkObjectBase
/// </summary>
/// <remarks>
///    abstract base class for most VTK objects
///
/// vtkObjectBase is the base class for all reference counted classes
/// in the VTK. These classes include vtkCommand classes, vtkInformationKey
/// classes, and vtkObject classes.
///
/// vtkObjectBase performs reference counting: objects that are
/// reference counted exist as long as another object uses them. Once
/// the last reference to a reference counted object is removed, the
/// object will spontaneously destruct.
///
/// Constructor and destructor of the subclasses of vtkObjectBase
/// should be protected, so that only New() and UnRegister() actually
/// call them. Debug leaks can be used to see if there are any objects
/// left with nonzero reference count.
///
/// @warning
/// Note: Objects of subclasses of vtkObjectBase should always be
/// created with the New() method and deleted with the Delete()
/// method. They cannot be allocated off the stack (i.e., automatic
/// objects) because the constructor is a protected method.
///
/// </remarks>
/// <seealso>
///
/// vtkObject vtkCommand vtkInformationKey
/// </seealso>
public class vtkObjectBase : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkObjectBase";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkObjectBase()
	{
		MRClassNameKey = "class vtkObjectBase";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectBase"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkObjectBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectBase_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an object with Debug turned off, modified time initialized
	/// to zero, and reference counting on.
	/// </summary>
	public static vtkObjectBase New()
	{
		vtkObjectBase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObjectBase_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create an object with Debug turned off, modified time initialized
	/// to zero, and reference counting on.
	/// </summary>
	public vtkObjectBase()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkObjectBase_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectBase_Register_16(HandleRef pThis, HandleRef o);

	/// <summary>
	/// Increase the reference count (mark as used by another object).
	/// </summary>
	public virtual void Register(vtkObjectBase o)
	{
		vtkObjectBase_Register_16(GetCppThis(), o?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectBase_UnRegister_19(HandleRef pThis, HandleRef o);

	/// <summary>
	/// Decrease the reference count (release by another object). This
	/// has the same effect as invoking Delete() (i.e., it reduces the
	/// reference count by 1).
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (GetCallDisposalMethod())
			{
				vtkObjectBase_UnRegister_19(GetCppThis(), default(HandleRef));
				ClearCppThis();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectBase_FastDelete_02(HandleRef pThis);

	/// <summary>
	/// Delete a reference to this object.  This version will not invoke
	/// garbage collection and can potentially leak the object if it is
	/// part of a reference loop.  Use this method only when it is known
	/// that the object has another reference and would not be collected
	/// if a full garbage collection check were done.
	/// </summary>
	public virtual void FastDelete()
	{
		vtkObjectBase_FastDelete_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectBase_GetClassName_03(HandleRef pThis);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public string GetClassName()
	{
		return Marshal.PtrToStringAnsi(vtkObjectBase_GetClassName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectBase_GetClassNameA_04(HandleRef pThis);

	/// <summary>
	/// The object description printed in messages and PrintSelf
	/// output. To be used only for reporting purposes.
	/// </summary>
	public string GetClassNameA()
	{
		return Marshal.PtrToStringAnsi(vtkObjectBase_GetClassNameA_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectBase_GetClassNameW_05(HandleRef pThis);

	/// <summary>
	/// The object description printed in messages and PrintSelf
	/// output. To be used only for reporting purposes.
	/// </summary>
	public string GetClassNameW()
	{
		return Marshal.PtrToStringAnsi(vtkObjectBase_GetClassNameW_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkObjectBase_GetIsInMemkind_06(HandleRef pThis);

	/// <summary>
	/// A local state flag that remembers whether this object lives in
	/// the normal or extended memory space.
	/// </summary>
	public bool GetIsInMemkind()
	{
		return (vtkObjectBase_GetIsInMemkind_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkObjectBase_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string name);

	/// <summary>
	/// Given the name of a base class of this class type, return the distance
	/// of inheritance between this class type and the named class (how many
	/// generations of inheritance are there between this class and the named
	/// class). If the named class is not in this class's inheritance tree, return
	/// a negative value. Valid responses will always be nonnegative. This method
	/// works in combination with vtkTypeMacro found in vtkSetGet.h.
	/// </summary>
	public virtual long GetNumberOfGenerationsFromBase(string name)
	{
		return vtkObjectBase_GetNumberOfGenerationsFromBase_07(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkObjectBase_GetNumberOfGenerationsFromBaseType_08(string name);

	/// <summary>
	/// Given a the name of a base class of this class type, return the distance
	/// of inheritance between this class type and the named class (how many
	/// generations of inheritance are there between this class and the named
	/// class). If the named class is not in this class's inheritance tree, return
	/// a negative value. Valid responses will always be nonnegative. This method
	/// works in combination with vtkTypeMacro found in vtkSetGet.h.
	/// </summary>
	public static long GetNumberOfGenerationsFromBaseType(string name)
	{
		return vtkObjectBase_GetNumberOfGenerationsFromBaseType_08(name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkObjectBase_GetObjectDescription_09(HandleRef pThis);

	/// <summary>
	/// The object description printed in messages and PrintSelf
	/// output. To be used only for reporting purposes.
	/// </summary>
	public virtual string GetObjectDescription()
	{
		return vtkObjectBase_GetObjectDescription_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectBase_GetReferenceCount_10(HandleRef pThis);

	/// <summary>
	/// Return the current reference count of this object.
	/// </summary>
	public int GetReferenceCount()
	{
		return vtkObjectBase_GetReferenceCount_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkObjectBase_GetUsingMemkind_11();

	/// <summary>
	/// A global state flag that controls whether vtkObjects are
	/// constructed in the usual way (the default) or within the extended
	/// memory space.
	/// </summary>
	public static bool GetUsingMemkind()
	{
		return (vtkObjectBase_GetUsingMemkind_11() != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectBase_InitializeObjectBase_12(HandleRef pThis);

	/// <summary>
	/// Create an object with Debug turned off, modified time initialized
	/// to zero, and reference counting on.
	/// </summary>
	public void InitializeObjectBase()
	{
		vtkObjectBase_InitializeObjectBase_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectBase_IsA_13(HandleRef pThis, string name);

	/// <summary>
	/// Return 1 if this class is the same type of (or a subclass of)
	/// the named class. Returns 0 otherwise. This method works in
	/// combination with vtkTypeMacro found in vtkSetGet.h.
	/// </summary>
	public virtual int IsA(string name)
	{
		return vtkObjectBase_IsA_13(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObjectBase_IsTypeOf_14(string name);

	/// <summary>
	/// Return 1 if this class type is the same type of (or a subclass of)
	/// the named class. Returns 0 otherwise. This method works in
	/// combination with vtkTypeMacro found in vtkSetGet.h.
	/// </summary>
	public static int IsTypeOf(string name)
	{
		return vtkObjectBase_IsTypeOf_14(name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectBase_SetMemkindDirectory_17(string directoryname);

	/// <summary>
	/// The name of a directory, ideally mounted -o dax, to memory map an
	/// extended memory space within.
	/// This must be called before any objects are constructed in the extended space.
	/// It can not be changed once setup.
	/// </summary>
	public static void SetMemkindDirectory(string directoryname)
	{
		vtkObjectBase_SetMemkindDirectory_17(directoryname);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectBase_SetReferenceCount_18(HandleRef pThis, int arg0);

	/// <summary>
	/// Sets the reference count. (This is very dangerous, use with care.)
	/// </summary>
	public void SetReferenceCount(int arg0)
	{
		vtkObjectBase_SetReferenceCount_18(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkObjectBase_UsesGarbageCollector_20(HandleRef pThis);

	/// <summary>
	/// Indicate whether the class uses `vtkGarbageCollector` or not.
	///
	/// Most classes will not need to do this, but if the class participates in a
	/// strongly-connected reference count cycle, participation can resolve these
	/// cycles.
	///
	/// If overriding this method to return true, the `ReportReferences` method
	/// should be overridden to report references that may be in cycles.
	/// </summary>
	public virtual bool UsesGarbageCollector()
	{
		return (vtkObjectBase_UsesGarbageCollector_20(GetCppThis()) != 0) ? true : false;
	}
}
