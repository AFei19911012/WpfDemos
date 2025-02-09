using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGarbageCollector
/// </summary>
/// <remarks>
///    Detect and break reference loops
///
/// vtkGarbageCollector is used by VTK classes that may be involved in
/// reference counting loops (such as Algorithm &lt;-&gt; Executive).  It
/// detects strongly connected components of the reference graph that
/// have been leaked deletes them.  The garbage collector uses the
/// ReportReferences method to search the reference graph and construct
/// a net reference count for each connected component.  If the net
/// reference count is zero the entire set of objects is deleted.
/// Deleting each component may leak other components, which are then
/// collected recursively.
///
/// To enable garbage collection for a class, add these members:
///
/// <code>
///
///  public:
///   bool UsesGarbageCollector() const override { return true; }
///
///  protected:
///
///   void ReportReferences(vtkGarbageCollector* collector) override
///   {
///     // Report references held by this object that may be in a loop.
///     this-&gt;Superclass::ReportReferences(collector);
///     vtkGarbageCollectorReport(collector, this-&gt;OtherObject, "Other Object");
///   }
/// </code>
///
/// The implementations should be in the .cxx file in practice.
/// It is important that the reference be reported using the real
/// pointer or smart pointer instance that holds the reference.  When
/// collecting the garbage collector will actually set this pointer to
/// nullptr.  The destructor of the class should be written to deal with
/// this.  It is also expected that an invariant is maintained for any
/// reference that is reported.  The variable holding the reference
/// must always either be nullptr or refer to a fully constructed valid
/// object.  Therefore code like "this-&gt;Object-&gt;UnRegister(this)" must
/// be avoided if "this-&gt;Object" is a reported reference because it
/// is possible that the object is deleted before UnRegister returns
/// but then "this-&gt;Object" will be left as a dangling pointer.  Instead
/// use code like
///
/// <code>
///   vtkObjectBase* obj = this-&gt;Object;
///   this-&gt;Object = 0;
///   obj-&gt;UnRegister(this);
/// </code>
///
/// so that the reported reference maintains the invariant.
///
/// If subclassing from a class that already supports garbage
/// collection, one need only provide the ReportReferences method.
/// </remarks>
public class vtkGarbageCollector : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGarbageCollector";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGarbageCollector()
	{
		MRClassNameKey = "class vtkGarbageCollector";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGarbageCollector"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGarbageCollector(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGarbageCollector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGarbageCollector New()
	{
		vtkGarbageCollector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGarbageCollector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGarbageCollector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGarbageCollector()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGarbageCollector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGarbageCollector_Collect_01();

	/// <summary>
	/// Collect immediately using any objects whose collection was
	/// previously deferred as a root for the reference graph walk.
	/// Strongly connected components in the reference graph are
	/// identified.  Those with a net reference count of zero are
	/// deleted.  When a component is deleted it may remove references to
	/// other components that are not part of the same reference loop but
	/// are held by objects in the original component.  These removed
	/// references are handled as any other and their corresponding
	/// checks may be deferred.  This method keeps collecting until no
	/// deferred collection checks remain.
	/// </summary>
	public static void Collect()
	{
		vtkGarbageCollector_Collect_01();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGarbageCollector_Collect_02(HandleRef root);

	/// <summary>
	/// Collect immediately using the given object as the root for a
	/// reference graph walk.  Strongly connected components in the
	/// reference graph are identified.  Those with a net reference count
	/// of zero are deleted.  When a component is deleted it may remove
	/// references to other components that are not part of the same
	/// reference loop but are held by objects in the original component.
	/// These removed references are handled as any other and their
	/// corresponding checks may be deferred.  This method does continue
	/// collecting in this case.
	/// </summary>
	public static void Collect(vtkObjectBase root)
	{
		vtkGarbageCollector_Collect_02(root?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGarbageCollector_DeferredCollectionPop_03();

	/// <summary>
	/// Push/Pop whether to do deferred collection.  Whenever the total
	/// number of pushes exceeds the total number of pops collection will
	/// be deferred.  Code can call the Collect method directly to force
	/// collection.
	/// </summary>
	public static void DeferredCollectionPop()
	{
		vtkGarbageCollector_DeferredCollectionPop_03();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGarbageCollector_DeferredCollectionPush_04();

	/// <summary>
	/// Push/Pop whether to do deferred collection.  Whenever the total
	/// number of pushes exceeds the total number of pops collection will
	/// be deferred.  Code can call the Collect method directly to force
	/// collection.
	/// </summary>
	public static void DeferredCollectionPush()
	{
		vtkGarbageCollector_DeferredCollectionPush_04();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGarbageCollector_GetGlobalDebugFlag_05();

	/// <summary>
	/// Set/Get global garbage collection debugging flag.  When set to true,
	/// all garbage collection checks will produce debugging information.
	/// </summary>
	public static bool GetGlobalDebugFlag()
	{
		return (vtkGarbageCollector_GetGlobalDebugFlag_05() != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGarbageCollector_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGarbageCollector_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGarbageCollector_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGarbageCollector_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGarbageCollector_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGarbageCollector_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGarbageCollector_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGarbageCollector_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGarbageCollector_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGarbageCollector NewInstance()
	{
		vtkGarbageCollector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGarbageCollector_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGarbageCollector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGarbageCollector_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGarbageCollector SafeDownCast(vtkObjectBase o)
	{
		vtkGarbageCollector vtkGarbageCollector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGarbageCollector_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGarbageCollector2 = (vtkGarbageCollector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGarbageCollector2.Register(null);
			}
		}
		return vtkGarbageCollector2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGarbageCollector_SetGlobalDebugFlag_13(byte flag);

	/// <summary>
	/// Set/Get global garbage collection debugging flag.  When set to true,
	/// all garbage collection checks will produce debugging information.
	/// </summary>
	public static void SetGlobalDebugFlag(bool flag)
	{
		vtkGarbageCollector_SetGlobalDebugFlag_13((byte)(flag ? 1u : 0u));
	}
}
