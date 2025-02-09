using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractSelectionBase
/// </summary>
/// <remarks>
///    abstract base class for all extract selection
/// filters.
///
/// vtkExtractSelectionBase is an abstract base class for all extract selection
/// filters. It defines some properties common to all extract selection filters.
/// </remarks>
public class vtkExtractSelectionBase : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectionBase";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractSelectionBase()
	{
		MRClassNameKey = "class vtkExtractSelectionBase";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectionBase"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractSelectionBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectionBase_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractSelectionBase_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectionBase_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractSelectionBase_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectionBase_GetPreserveTopology_03(HandleRef pThis);

	/// <summary>
	/// This flag tells the extraction filter not to convert the selected
	/// output into an unstructured grid, but instead to produce a vtkInsidedness
	/// array and add it to the input dataset. Default value is false(0).
	/// </summary>
	public virtual int GetPreserveTopology()
	{
		return vtkExtractSelectionBase_GetPreserveTopology_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectionBase_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractSelectionBase_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectionBase_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractSelectionBase_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectionBase_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractSelectionBase NewInstance()
	{
		vtkExtractSelectionBase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectionBase_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectionBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectionBase_PreserveTopologyOff_07(HandleRef pThis);

	/// <summary>
	/// This flag tells the extraction filter not to convert the selected
	/// output into an unstructured grid, but instead to produce a vtkInsidedness
	/// array and add it to the input dataset. Default value is false(0).
	/// </summary>
	public virtual void PreserveTopologyOff()
	{
		vtkExtractSelectionBase_PreserveTopologyOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectionBase_PreserveTopologyOn_08(HandleRef pThis);

	/// <summary>
	/// This flag tells the extraction filter not to convert the selected
	/// output into an unstructured grid, but instead to produce a vtkInsidedness
	/// array and add it to the input dataset. Default value is false(0).
	/// </summary>
	public virtual void PreserveTopologyOn()
	{
		vtkExtractSelectionBase_PreserveTopologyOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectionBase_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectionBase SafeDownCast(vtkObjectBase o)
	{
		vtkExtractSelectionBase vtkExtractSelectionBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectionBase_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractSelectionBase2 = (vtkExtractSelectionBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractSelectionBase2.Register(null);
			}
		}
		return vtkExtractSelectionBase2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectionBase_SetPreserveTopology_10(HandleRef pThis, int _arg);

	/// <summary>
	/// This flag tells the extraction filter not to convert the selected
	/// output into an unstructured grid, but instead to produce a vtkInsidedness
	/// array and add it to the input dataset. Default value is false(0).
	/// </summary>
	public virtual void SetPreserveTopology(int _arg)
	{
		vtkExtractSelectionBase_SetPreserveTopology_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectionBase_SetSelectionConnection_11(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Convenience method to specify the selection connection (2nd input
	/// port)
	/// </summary>
	public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
	{
		vtkExtractSelectionBase_SetSelectionConnection_11(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}
}
