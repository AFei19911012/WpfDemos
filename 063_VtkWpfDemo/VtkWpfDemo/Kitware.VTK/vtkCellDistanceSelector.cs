using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellDistanceSelector
/// </summary>
/// <remarks>
///    select neighbor cells up to a distance
///
///
/// This filter grows an input selection by iteratively selecting neighbor
/// cells (a neighbor cell is a cell that shares a vertex/edge/face), up to
/// a given topological distance to the selected neighborhood (number of times
/// we add neighbor cells).
/// This filter takes a vtkSelection and a vtkCompositeDataSet as inputs.
/// It outputs a vtkSelection identifying all the selected cells.
///
/// @par Thanks:
/// This file has been initially developed in the frame of CEA's Love visualization software
/// development &lt;br&gt; CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt; BP12,
/// F-91297 Arpajon, France. &lt;br&gt; Modified and integrated into VTK, Kitware SAS 2012 Implementation
/// by Thierry Carrard and Philippe Pebay
/// </remarks>
public class vtkCellDistanceSelector : vtkSelectionAlgorithm
{
	/// <summary>
	/// enumeration values to specify input port types
	/// </summary>
	public enum InputPorts
	{
		/// <summary>enum member</summary>
		INPUT_MESH,
		/// <summary>enum member</summary>
		INPUT_SELECTION
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellDistanceSelector";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellDistanceSelector()
	{
		MRClassNameKey = "class vtkCellDistanceSelector";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellDistanceSelector"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellDistanceSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDistanceSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellDistanceSelector New()
	{
		vtkCellDistanceSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellDistanceSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellDistanceSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCellDistanceSelector()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellDistanceSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_AddIntermediateOff_01(HandleRef pThis);

	/// <summary>
	/// If set, intermediate cells (between seed cells and the selection boundary) will be included in
	/// the final selection
	/// </summary>
	public virtual void AddIntermediateOff()
	{
		vtkCellDistanceSelector_AddIntermediateOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_AddIntermediateOn_02(HandleRef pThis);

	/// <summary>
	/// If set, intermediate cells (between seed cells and the selection boundary) will be included in
	/// the final selection
	/// </summary>
	public virtual void AddIntermediateOn()
	{
		vtkCellDistanceSelector_AddIntermediateOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDistanceSelector_GetAddIntermediate_03(HandleRef pThis);

	/// <summary>
	/// If set, intermediate cells (between seed cells and the selection boundary) will be included in
	/// the final selection
	/// </summary>
	public virtual int GetAddIntermediate()
	{
		return vtkCellDistanceSelector_GetAddIntermediate_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDistanceSelector_GetDistance_04(HandleRef pThis);

	/// <summary>
	/// Tells how far (in term of topological distance) away from seed cells to expand the selection
	/// </summary>
	public virtual int GetDistance()
	{
		return vtkCellDistanceSelector_GetDistance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDistanceSelector_GetIncludeSeed_05(HandleRef pThis);

	/// <summary>
	/// If set, seed cells passed with SetSeedCells will be included in the final selection
	/// </summary>
	public virtual int GetIncludeSeed()
	{
		return vtkCellDistanceSelector_GetIncludeSeed_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellDistanceSelector_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellDistanceSelector_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellDistanceSelector_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellDistanceSelector_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_IncludeSeedOff_08(HandleRef pThis);

	/// <summary>
	/// If set, seed cells passed with SetSeedCells will be included in the final selection
	/// </summary>
	public virtual void IncludeSeedOff()
	{
		vtkCellDistanceSelector_IncludeSeedOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_IncludeSeedOn_09(HandleRef pThis);

	/// <summary>
	/// If set, seed cells passed with SetSeedCells will be included in the final selection
	/// </summary>
	public virtual void IncludeSeedOn()
	{
		vtkCellDistanceSelector_IncludeSeedOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDistanceSelector_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellDistanceSelector_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDistanceSelector_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellDistanceSelector_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDistanceSelector_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCellDistanceSelector NewInstance()
	{
		vtkCellDistanceSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellDistanceSelector_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellDistanceSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDistanceSelector_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellDistanceSelector SafeDownCast(vtkObjectBase o)
	{
		vtkCellDistanceSelector vtkCellDistanceSelector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellDistanceSelector_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellDistanceSelector2 = (vtkCellDistanceSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellDistanceSelector2.Register(null);
			}
		}
		return vtkCellDistanceSelector2;
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_SetAddIntermediate_15(HandleRef pThis, int _arg);

	/// <summary>
	/// If set, intermediate cells (between seed cells and the selection boundary) will be included in
	/// the final selection
	/// </summary>
	public virtual void SetAddIntermediate(int _arg)
	{
		vtkCellDistanceSelector_SetAddIntermediate_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_SetDistance_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Tells how far (in term of topological distance) away from seed cells to expand the selection
	/// </summary>
	public virtual void SetDistance(int _arg)
	{
		vtkCellDistanceSelector_SetDistance_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_SetIncludeSeed_17(HandleRef pThis, int _arg);

	/// <summary>
	/// If set, seed cells passed with SetSeedCells will be included in the final selection
	/// </summary>
	public virtual void SetIncludeSeed(int _arg)
	{
		vtkCellDistanceSelector_SetIncludeSeed_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_SetInputMesh_18(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// A convenience method to set the input data object
	/// </summary>
	public void SetInputMesh(vtkDataObject obj)
	{
		vtkCellDistanceSelector_SetInputMesh_18(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_SetInputMeshConnection_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A convenience method to set the data object input connection to the producer output
	/// </summary>
	public void SetInputMeshConnection(vtkAlgorithmOutput arg0)
	{
		vtkCellDistanceSelector_SetInputMeshConnection_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_SetInputSelection_20(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// A convenience method to set the input selection
	/// </summary>
	public void SetInputSelection(vtkSelection obj)
	{
		vtkCellDistanceSelector_SetInputSelection_20(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDistanceSelector_SetInputSelectionConnection_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A convenience method to set the selection input connection to the producer output
	/// </summary>
	public void SetInputSelectionConnection(vtkAlgorithmOutput arg0)
	{
		vtkCellDistanceSelector_SetInputSelectionConnection_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
