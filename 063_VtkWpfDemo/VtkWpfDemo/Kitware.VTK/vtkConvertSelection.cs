using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConvertSelection
/// </summary>
/// <remarks>
///    Convert a selection from one type to another
///
///
/// vtkConvertSelection converts an input selection from one type to another
/// in the context of a data object being selected. The first input is the
/// selection, while the second input is the data object that the selection
/// relates to.
///
/// </remarks>
/// <seealso>
///
/// vtkSelection vtkSelectionNode vtkExtractSelection vtkExtractSelectedGraph
/// </seealso>
public class vtkConvertSelection : vtkSelectionAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConvertSelection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConvertSelection()
	{
		MRClassNameKey = "class vtkConvertSelection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertSelection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConvertSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConvertSelection New()
	{
		vtkConvertSelection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvertSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkConvertSelection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConvertSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkConvertSelection_AddArrayName_01(HandleRef pThis, string arg0);

	/// <summary>
	/// Convenience methods used by UI
	/// </summary>
	public void AddArrayName(string arg0)
	{
		vtkConvertSelection_AddArrayName_01(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_AllowMissingArrayOff_02(HandleRef pThis);

	/// <summary>
	/// When enabled, not finding expected array will not return an error.
	/// Defaults to OFF.
	/// </summary>
	public virtual void AllowMissingArrayOff()
	{
		vtkConvertSelection_AllowMissingArrayOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_AllowMissingArrayOn_03(HandleRef pThis);

	/// <summary>
	/// When enabled, not finding expected array will not return an error.
	/// Defaults to OFF.
	/// </summary>
	public virtual void AllowMissingArrayOn()
	{
		vtkConvertSelection_AllowMissingArrayOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_ClearArrayNames_04(HandleRef pThis);

	/// <summary>
	/// Convenience methods used by UI
	/// </summary>
	public void ClearArrayNames()
	{
		vtkConvertSelection_ClearArrayNames_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkConvertSelection_GetAllowMissingArray_05(HandleRef pThis);

	/// <summary>
	/// When enabled, not finding expected array will not return an error.
	/// Defaults to OFF.
	/// </summary>
	public virtual bool GetAllowMissingArray()
	{
		return (vtkConvertSelection_GetAllowMissingArray_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_GetArrayName_06(HandleRef pThis);

	/// <summary>
	/// The output array name for value or threshold selections.
	/// </summary>
	public virtual string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkConvertSelection_GetArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_GetArrayNames_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The output array names for value selection.
	/// </summary>
	public virtual vtkStringArray GetArrayNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_GetArrayNames_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvertSelection_GetInputFieldType_08(HandleRef pThis);

	/// <summary>
	/// The input field type.
	/// If this is set to a number other than -1, ignores the input selection
	/// field type and instead assumes that all selection nodes have the
	/// field type specified.
	/// This should be one of the constants defined in vtkSelectionNode.h.
	/// Default is -1.
	/// </summary>
	public virtual int GetInputFieldType()
	{
		return vtkConvertSelection_GetInputFieldType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkConvertSelection_GetMatchAnyValues_09(HandleRef pThis);

	/// <summary>
	/// When on, creates a separate selection node for each array.
	/// Defaults to OFF.
	/// </summary>
	public virtual bool GetMatchAnyValues()
	{
		return (vtkConvertSelection_GetMatchAnyValues_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConvertSelection_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConvertSelection_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConvertSelection_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConvertSelection_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvertSelection_GetOutputType_12(HandleRef pThis);

	/// <summary>
	/// The output selection content type.
	/// This should be one of the constants defined in vtkSelectionNode.h.
	/// </summary>
	public virtual int GetOutputType()
	{
		return vtkConvertSelection_GetOutputType_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_GetSelectedCells_13(HandleRef input, HandleRef data, HandleRef indices);

	/// <summary>
	/// Static methods for easily obtaining selected items from a data object.
	/// The array argument will be filled with the selected items.
	/// </summary>
	public static void GetSelectedCells(vtkSelection input, vtkDataSet data, vtkIdTypeArray indices)
	{
		vtkConvertSelection_GetSelectedCells_13(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), indices?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_GetSelectedEdges_14(HandleRef input, HandleRef data, HandleRef indices);

	/// <summary>
	/// Static methods for easily obtaining selected items from a data object.
	/// The array argument will be filled with the selected items.
	/// </summary>
	public static void GetSelectedEdges(vtkSelection input, vtkGraph data, vtkIdTypeArray indices)
	{
		vtkConvertSelection_GetSelectedEdges_14(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), indices?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_GetSelectedItems_15(HandleRef input, HandleRef data, int fieldType, HandleRef indices);

	/// <summary>
	/// Static generic method for obtaining selected items from a data object.
	/// Other static methods (e.g. GetSelectedVertices) call this one.
	/// </summary>
	public static void GetSelectedItems(vtkSelection input, vtkDataObject data, int fieldType, vtkIdTypeArray indices)
	{
		vtkConvertSelection_GetSelectedItems_15(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), fieldType, indices?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_GetSelectedPoints_16(HandleRef input, HandleRef data, HandleRef indices);

	/// <summary>
	/// Static methods for easily obtaining selected items from a data object.
	/// The array argument will be filled with the selected items.
	/// </summary>
	public static void GetSelectedPoints(vtkSelection input, vtkDataSet data, vtkIdTypeArray indices)
	{
		vtkConvertSelection_GetSelectedPoints_16(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), indices?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_GetSelectedRows_17(HandleRef input, HandleRef data, HandleRef indices);

	/// <summary>
	/// Static methods for easily obtaining selected items from a data object.
	/// The array argument will be filled with the selected items.
	/// </summary>
	public static void GetSelectedRows(vtkSelection input, vtkTable data, vtkIdTypeArray indices)
	{
		vtkConvertSelection_GetSelectedRows_17(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), indices?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_GetSelectedVertices_18(HandleRef input, HandleRef data, HandleRef indices);

	/// <summary>
	/// Static methods for easily obtaining selected items from a data object.
	/// The array argument will be filled with the selected items.
	/// </summary>
	public static void GetSelectedVertices(vtkSelection input, vtkGraph data, vtkIdTypeArray indices)
	{
		vtkConvertSelection_GetSelectedVertices_18(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), indices?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_GetSelectionExtractor_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get a selection extractor used in some conversions to
	/// obtain IDs.
	/// </summary>
	public virtual vtkExtractSelection GetSelectionExtractor()
	{
		vtkExtractSelection vtkExtractSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_GetSelectionExtractor_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractSelection2 = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractSelection2.Register(null);
			}
		}
		return vtkExtractSelection2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvertSelection_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConvertSelection_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvertSelection_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConvertSelection_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_MatchAnyValuesOff_22(HandleRef pThis);

	/// <summary>
	/// When on, creates a separate selection node for each array.
	/// Defaults to OFF.
	/// </summary>
	public virtual void MatchAnyValuesOff()
	{
		vtkConvertSelection_MatchAnyValuesOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_MatchAnyValuesOn_23(HandleRef pThis);

	/// <summary>
	/// When on, creates a separate selection node for each array.
	/// Defaults to OFF.
	/// </summary>
	public virtual void MatchAnyValuesOn()
	{
		vtkConvertSelection_MatchAnyValuesOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkConvertSelection NewInstance()
	{
		vtkConvertSelection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvertSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConvertSelection SafeDownCast(vtkObjectBase o)
	{
		vtkConvertSelection vtkConvertSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConvertSelection2 = (vtkConvertSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConvertSelection2.Register(null);
			}
		}
		return vtkConvertSelection2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_SetAllowMissingArray_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// When enabled, not finding expected array will not return an error.
	/// Defaults to OFF.
	/// </summary>
	public virtual void SetAllowMissingArray(bool _arg)
	{
		vtkConvertSelection_SetAllowMissingArray_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_SetArrayName_28(HandleRef pThis, string arg0);

	/// <summary>
	/// The output array name for value or threshold selections.
	/// </summary>
	public virtual void SetArrayName(string arg0)
	{
		vtkConvertSelection_SetArrayName_28(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_SetArrayNames_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// The output array names for value selection.
	/// </summary>
	public virtual void SetArrayNames(vtkStringArray arg0)
	{
		vtkConvertSelection_SetArrayNames_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_SetDataObjectConnection_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A convenience method for setting the second input (i.e. the data object).
	/// </summary>
	public void SetDataObjectConnection(vtkAlgorithmOutput arg0)
	{
		vtkConvertSelection_SetDataObjectConnection_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_SetInputFieldType_31(HandleRef pThis, int _arg);

	/// <summary>
	/// The input field type.
	/// If this is set to a number other than -1, ignores the input selection
	/// field type and instead assumes that all selection nodes have the
	/// field type specified.
	/// This should be one of the constants defined in vtkSelectionNode.h.
	/// Default is -1.
	/// </summary>
	public virtual void SetInputFieldType(int _arg)
	{
		vtkConvertSelection_SetInputFieldType_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_SetMatchAnyValues_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// When on, creates a separate selection node for each array.
	/// Defaults to OFF.
	/// </summary>
	public virtual void SetMatchAnyValues(bool _arg)
	{
		vtkConvertSelection_SetMatchAnyValues_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_SetOutputType_33(HandleRef pThis, int _arg);

	/// <summary>
	/// The output selection content type.
	/// This should be one of the constants defined in vtkSelectionNode.h.
	/// </summary>
	public virtual void SetOutputType(int _arg)
	{
		vtkConvertSelection_SetOutputType_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertSelection_SetSelectionExtractor_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get a selection extractor used in some conversions to
	/// obtain IDs.
	/// </summary>
	public virtual void SetSelectionExtractor(vtkExtractSelection arg0)
	{
		vtkConvertSelection_SetSelectionExtractor_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_ToGlobalIdSelection_35(HandleRef input, HandleRef data, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static methods for easily converting between selection types.
	/// NOTE: The returned selection pointer IS reference counted,
	/// so be sure to Delete() it when you are done with it.
	/// </summary>
	public static vtkSelection ToGlobalIdSelection(vtkSelection input, vtkDataObject data)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_ToGlobalIdSelection_35(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_ToIndexSelection_36(HandleRef input, HandleRef data, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static methods for easily converting between selection types.
	/// NOTE: The returned selection pointer IS reference counted,
	/// so be sure to Delete() it when you are done with it.
	/// </summary>
	public static vtkSelection ToIndexSelection(vtkSelection input, vtkDataObject data)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_ToIndexSelection_36(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_ToPedigreeIdSelection_37(HandleRef input, HandleRef data, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static methods for easily converting between selection types.
	/// NOTE: The returned selection pointer IS reference counted,
	/// so be sure to Delete() it when you are done with it.
	/// </summary>
	public static vtkSelection ToPedigreeIdSelection(vtkSelection input, vtkDataObject data)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_ToPedigreeIdSelection_37(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_ToSelectionType_38(HandleRef input, HandleRef data, int type, HandleRef arrayNames, int inputFieldType, byte allowMissingArray, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A generic static method for converting selection types.
	/// The type should be an integer constant defined in vtkSelectionNode.h.
	/// </summary>
	public static vtkSelection ToSelectionType(vtkSelection input, vtkDataObject data, int type, vtkStringArray arrayNames, int inputFieldType, bool allowMissingArray)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_ToSelectionType_38(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), type, arrayNames?.GetCppThis() ?? default(HandleRef), inputFieldType, (byte)(allowMissingArray ? 1u : 0u), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_ToValueSelection_39(HandleRef input, HandleRef data, string arrayName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static methods for easily converting between selection types.
	/// NOTE: The returned selection pointer IS reference counted,
	/// so be sure to Delete() it when you are done with it.
	/// </summary>
	public static vtkSelection ToValueSelection(vtkSelection input, vtkDataObject data, string arrayName)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_ToValueSelection_39(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), arrayName, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertSelection_ToValueSelection_40(HandleRef input, HandleRef data, HandleRef arrayNames, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static methods for easily converting between selection types.
	/// NOTE: The returned selection pointer IS reference counted,
	/// so be sure to Delete() it when you are done with it.
	/// </summary>
	public static vtkSelection ToValueSelection(vtkSelection input, vtkDataObject data, vtkStringArray arrayNames)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertSelection_ToValueSelection_40(input?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), arrayNames?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
}
