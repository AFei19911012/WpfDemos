using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAnnotationLink
/// </summary>
/// <remarks>
///    An algorithm for linking annotations among objects
///
/// vtkAnnotationLink is a simple source filter which outputs the
/// vtkAnnotationLayers object stored internally.  Multiple objects may share
/// the same annotation link filter and connect it to an internal pipeline so
/// that if one object changes the annotation set, it will be pulled into all
/// the other objects when their pipelines update.
///
/// The shared vtkAnnotationLayers object (a collection of annotations) is
/// shallow copied to output port 0.
///
/// vtkAnnotationLink can also store a set of domain maps. A domain map is
/// simply a table associating values between domains. The domain of each
/// column is defined by the array name of the column. The domain maps are
/// sent to a multi-block dataset in output port 1.
///
/// Output ports 0 and 1 can be set as input ports 0 and 1 to
/// vtkConvertSelectionDomain, which can use the domain maps to convert the
/// domains of selections in the vtkAnnotationLayers to match a particular
/// data object (set as port 2 on vtkConvertSelectionDomain).
///
/// The shared vtkAnnotationLayers object also stores a "current selection"
/// normally interpreted as the interactive selection of an application.
/// As a convenience, this selection is sent to output port 2 so that it
/// can be connected to pipelines requiring a vtkSelection.
/// </remarks>
public class vtkAnnotationLink : vtkAnnotationLayersAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotationLink";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAnnotationLink()
	{
		MRClassNameKey = "class vtkAnnotationLink";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotationLink"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAnnotationLink(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLink_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnnotationLink New()
	{
		vtkAnnotationLink result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLink_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAnnotationLink()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAnnotationLink_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLink_AddDomainMap_01(HandleRef pThis, HandleRef map);

	/// <summary>
	/// The domain mappings.
	/// </summary>
	public void AddDomainMap(vtkTable map)
	{
		vtkAnnotationLink_AddDomainMap_01(GetCppThis(), map?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLink_GetAnnotationLayers_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The annotations to be shared.
	/// </summary>
	public virtual vtkAnnotationLayers GetAnnotationLayers()
	{
		vtkAnnotationLayers vtkAnnotationLayers2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLink_GetAnnotationLayers_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotationLayers2 = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotationLayers2.Register(null);
			}
		}
		return vtkAnnotationLayers2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLink_GetCurrentSelection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set or get the current selection in the annotation layers.
	/// </summary>
	public virtual vtkSelection GetCurrentSelection()
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLink_GetCurrentSelection_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLink_GetDomainMap_04(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The domain mappings.
	/// </summary>
	public vtkTable GetDomainMap(int i)
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLink_GetDomainMap_04(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAnnotationLink_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Get the mtime of this object.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAnnotationLink_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnnotationLink_GetNumberOfDomainMaps_06(HandleRef pThis);

	/// <summary>
	/// The domain mappings.
	/// </summary>
	public int GetNumberOfDomainMaps()
	{
		return vtkAnnotationLink_GetNumberOfDomainMaps_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnnotationLink_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAnnotationLink_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnnotationLink_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAnnotationLink_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnnotationLink_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAnnotationLink_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnnotationLink_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAnnotationLink_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLink_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAnnotationLink NewInstance()
	{
		vtkAnnotationLink result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLink_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLink_RemoveAllDomainMaps_13(HandleRef pThis);

	/// <summary>
	/// The domain mappings.
	/// </summary>
	public void RemoveAllDomainMaps()
	{
		vtkAnnotationLink_RemoveAllDomainMaps_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLink_RemoveDomainMap_14(HandleRef pThis, HandleRef map);

	/// <summary>
	/// The domain mappings.
	/// </summary>
	public void RemoveDomainMap(vtkTable map)
	{
		vtkAnnotationLink_RemoveDomainMap_14(GetCppThis(), map?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLink_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnnotationLink SafeDownCast(vtkObjectBase o)
	{
		vtkAnnotationLink vtkAnnotationLink2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLink_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotationLink2 = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotationLink2.Register(null);
			}
		}
		return vtkAnnotationLink2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLink_SetAnnotationLayers_16(HandleRef pThis, HandleRef layers);

	/// <summary>
	/// The annotations to be shared.
	/// </summary>
	public virtual void SetAnnotationLayers(vtkAnnotationLayers layers)
	{
		vtkAnnotationLink_SetAnnotationLayers_16(GetCppThis(), layers?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLink_SetCurrentSelection_17(HandleRef pThis, HandleRef sel);

	/// <summary>
	/// Set or get the current selection in the annotation layers.
	/// </summary>
	public virtual void SetCurrentSelection(vtkSelection sel)
	{
		vtkAnnotationLink_SetCurrentSelection_17(GetCppThis(), sel?.GetCppThis() ?? default(HandleRef));
	}
}
