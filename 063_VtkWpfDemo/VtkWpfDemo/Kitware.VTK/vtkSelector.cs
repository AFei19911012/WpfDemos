using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSelector.h
/// </summary>
/// <remarks>
///    Computes the portion of a dataset which is inside a selection
///
/// This is an abstract superclass for types of selection operations. Subclasses
/// generally only need to override `ComputeSelectedElements`.
/// </remarks>
public abstract class vtkSelector : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSelector";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSelector()
	{
		MRClassNameKey = "class vtkSelector";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelector"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelector_Execute_01(HandleRef pThis, HandleRef input, HandleRef output);

	/// <summary>
	/// Given an input and the vtkSelectionNode passed into the Initialize() method, add to the
	/// output a vtkSignedChar attribute array indicating whether each element is inside (1)
	/// or outside (0) the selection. The attribute (point data or cell data) is determined
	/// by the vtkSelection that owns the vtkSelectionNode set in Initialize(). The insidedness
	/// array is named with the value of InsidednessArrayName. If input is a vtkCompositeDataSet,
	/// the insidedness array is added to each block.
	///
	/// </summary>
	public virtual void Execute(vtkDataObject input, vtkDataObject output)
	{
		vtkSelector_Execute_01(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelector_Finalize_02(HandleRef pThis);

	/// <summary>
	/// Does any cleanup of objects created in Initialize
	/// </summary>
	public virtual void FinalizeWrapper()
	{
		vtkSelector_Finalize_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSelector_GetInsidednessArrayName_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the array to use for the insidedness array to add to
	/// the output in `Execute` call.
	/// </summary>
	public virtual string GetInsidednessArrayName()
	{
		return vtkSelector_GetInsidednessArrayName_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelector_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSelector_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelector_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSelector_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelector_Initialize_06(HandleRef pThis, HandleRef node);

	/// <summary>
	/// Sets the vtkSelectionNode used by this selection operator and initializes
	/// the data structures in the selection operator based on the selection.
	///
	/// (for example in the vtkFrustumSelector this creates the vtkPlanes
	/// implicit function to represent the frustum).
	///
	/// @param node The selection node that determines the behavior of this operator.
	/// </summary>
	public virtual void Initialize(vtkSelectionNode node)
	{
		vtkSelector_Initialize_06(GetCppThis(), node?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelector_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSelector_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelector_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSelector_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelector_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSelector NewInstance()
	{
		vtkSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelector_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelector_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSelector SafeDownCast(vtkObjectBase o)
	{
		vtkSelector vtkSelector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelector_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelector2 = (vtkSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelector2.Register(null);
			}
		}
		return vtkSelector2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelector_SetInsidednessArrayName_11(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the array to use for the insidedness array to add to
	/// the output in `Execute` call.
	/// </summary>
	public virtual void SetInsidednessArrayName(string _arg)
	{
		vtkSelector_SetInsidednessArrayName_11(GetCppThis(), _arg);
	}
}
