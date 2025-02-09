using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkExpandMarkedElements
/// </summary>
/// <remarks>
///  expands marked elements to including adjacent elements.
///
/// vtkExpandMarkedElements is intended to expand selected cells to
/// grow to include adjacent cells. The filter works across all blocks in a
/// composite dataset and across all ranks. Besides cells, the filter can be used
/// to expand selected points instead in which case adjacent points are defined
/// as points on any cell that has the source point as one of its points.
///
/// The selected cells (or points) are indicated by a `vtkSignedCharArray` on
/// cell-data (or point-data). The array can be selected by using
/// `SetInputArrayToProcess(0, 0, 0,...)` (see
/// vtkAlgorithm::SetInputArrayToProcess).
///
/// Currently, the filter only supports expanding marked elements for cells and
/// points.
/// </remarks>
public class vtkExpandMarkedElements : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExpandMarkedElements";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExpandMarkedElements()
	{
		MRClassNameKey = "class vtkExpandMarkedElements";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExpandMarkedElements"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExpandMarkedElements(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExpandMarkedElements_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExpandMarkedElements New()
	{
		vtkExpandMarkedElements result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExpandMarkedElements_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExpandMarkedElements)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExpandMarkedElements()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExpandMarkedElements_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExpandMarkedElements_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the controller to use. By default, is initialized to
	/// `vtkMultiProcessController::GetGlobalController` in the constructor.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExpandMarkedElements_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExpandMarkedElements_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExpandMarkedElements_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExpandMarkedElements_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExpandMarkedElements_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExpandMarkedElements_GetNumberOfLayers_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of layers to expand by.
	/// Default is 2.
	/// </summary>
	public virtual int GetNumberOfLayers()
	{
		return vtkExpandMarkedElements_GetNumberOfLayers_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExpandMarkedElements_GetNumberOfLayersMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of layers to expand by.
	/// Default is 2.
	/// </summary>
	public virtual int GetNumberOfLayersMaxValue()
	{
		return vtkExpandMarkedElements_GetNumberOfLayersMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExpandMarkedElements_GetNumberOfLayersMinValue_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of layers to expand by.
	/// Default is 2.
	/// </summary>
	public virtual int GetNumberOfLayersMinValue()
	{
		return vtkExpandMarkedElements_GetNumberOfLayersMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExpandMarkedElements_GetRemoveIntermediateLayers_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the flag to remove intermediate layers
	/// Default is false.
	/// </summary>
	public virtual bool GetRemoveIntermediateLayers()
	{
		return (vtkExpandMarkedElements_GetRemoveIntermediateLayers_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExpandMarkedElements_GetRemoveSeed_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the flag to remove seed of marked elements.
	/// Default is false.
	/// </summary>
	public virtual bool GetRemoveSeed()
	{
		return (vtkExpandMarkedElements_GetRemoveSeed_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExpandMarkedElements_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExpandMarkedElements_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExpandMarkedElements_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExpandMarkedElements_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExpandMarkedElements_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExpandMarkedElements NewInstance()
	{
		vtkExpandMarkedElements result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExpandMarkedElements_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExpandMarkedElements)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandMarkedElements_RemoveIntermediateLayersOff_13(HandleRef pThis);

	/// <summary>
	/// Get/Set the flag to remove intermediate layers
	/// Default is false.
	/// </summary>
	public virtual void RemoveIntermediateLayersOff()
	{
		vtkExpandMarkedElements_RemoveIntermediateLayersOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandMarkedElements_RemoveIntermediateLayersOn_14(HandleRef pThis);

	/// <summary>
	/// Get/Set the flag to remove intermediate layers
	/// Default is false.
	/// </summary>
	public virtual void RemoveIntermediateLayersOn()
	{
		vtkExpandMarkedElements_RemoveIntermediateLayersOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandMarkedElements_RemoveSeedOff_15(HandleRef pThis);

	/// <summary>
	/// Get/Set the flag to remove seed of marked elements.
	/// Default is false.
	/// </summary>
	public virtual void RemoveSeedOff()
	{
		vtkExpandMarkedElements_RemoveSeedOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandMarkedElements_RemoveSeedOn_16(HandleRef pThis);

	/// <summary>
	/// Get/Set the flag to remove seed of marked elements.
	/// Default is false.
	/// </summary>
	public virtual void RemoveSeedOn()
	{
		vtkExpandMarkedElements_RemoveSeedOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExpandMarkedElements_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExpandMarkedElements SafeDownCast(vtkObjectBase o)
	{
		vtkExpandMarkedElements vtkExpandMarkedElements2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExpandMarkedElements_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExpandMarkedElements2 = (vtkExpandMarkedElements)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExpandMarkedElements2.Register(null);
			}
		}
		return vtkExpandMarkedElements2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandMarkedElements_SetController_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the controller to use. By default, is initialized to
	/// `vtkMultiProcessController::GetGlobalController` in the constructor.
	/// </summary>
	public void SetController(vtkMultiProcessController arg0)
	{
		vtkExpandMarkedElements_SetController_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandMarkedElements_SetNumberOfLayers_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of layers to expand by.
	/// Default is 2.
	/// </summary>
	public virtual void SetNumberOfLayers(int _arg)
	{
		vtkExpandMarkedElements_SetNumberOfLayers_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandMarkedElements_SetRemoveIntermediateLayers_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set the flag to remove intermediate layers
	/// Default is false.
	/// </summary>
	public virtual void SetRemoveIntermediateLayers(bool _arg)
	{
		vtkExpandMarkedElements_SetRemoveIntermediateLayers_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExpandMarkedElements_SetRemoveSeed_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set the flag to remove seed of marked elements.
	/// Default is false.
	/// </summary>
	public virtual void SetRemoveSeed(bool _arg)
	{
		vtkExpandMarkedElements_SetRemoveSeed_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
