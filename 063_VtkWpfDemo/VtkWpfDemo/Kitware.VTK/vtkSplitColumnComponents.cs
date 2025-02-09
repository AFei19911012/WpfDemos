using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSplitColumnComponents
/// </summary>
/// <remarks>
///    split multicomponent table columns
///
///
/// Splits any columns in a table that have more than one component into
/// individual columns. Single component columns are passed through without
/// any data duplication.
/// NamingMode can be used to control how columns with multiple components are
/// labelled in the output, e.g., if column names "Points" had three components
/// this column would be split into "Points (0)", "Points (1)", and Points (2)"
/// when NamingMode is NUMBERS_WITH_PARENS, into Points_0, Points_1, and Points_2
/// when NamingMode is NUMBERS_WITH_UNDERSCORES, into "Points (X)", "Points (Y)",
/// and "Points (Z)" when NamingMode is NAMES_WITH_PARENS, and into Points_X,
/// Points_Y, and Points_Z when NamingMode is NAMES_WITH_UNDERSCORES.
/// </remarks>
public class vtkSplitColumnComponents : vtkTableAlgorithm
{
	/// <summary>
	/// If on this filter will calculate an additional magnitude column for all
	/// columns it splits with two or more components.
	/// Default is on.
	/// </summary>
	public enum NAMES_WITH_PARENS_WrapperEnum
	{
		/// <summary>enum member</summary>
		NAMES_WITH_PARENS = 1,
		/// <summary>enum member</summary>
		NAMES_WITH_UNDERSCORES = 3,
		/// <summary>enum member</summary>
		NUMBERS_WITH_PARENS = 0,
		/// <summary>enum member</summary>
		NUMBERS_WITH_UNDERSCORES = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSplitColumnComponents";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSplitColumnComponents()
	{
		MRClassNameKey = "class vtkSplitColumnComponents";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplitColumnComponents"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSplitColumnComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitColumnComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSplitColumnComponents New()
	{
		vtkSplitColumnComponents result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitColumnComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplitColumnComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSplitColumnComponents()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSplitColumnComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSplitColumnComponents_CalculateMagnitudesOff_01(HandleRef pThis);

	/// <summary>
	/// If on this filter will calculate an additional magnitude column for all
	/// columns it splits with two or more components.
	/// Default is on.
	/// </summary>
	public virtual void CalculateMagnitudesOff()
	{
		vtkSplitColumnComponents_CalculateMagnitudesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitColumnComponents_CalculateMagnitudesOn_02(HandleRef pThis);

	/// <summary>
	/// If on this filter will calculate an additional magnitude column for all
	/// columns it splits with two or more components.
	/// Default is on.
	/// </summary>
	public virtual void CalculateMagnitudesOn()
	{
		vtkSplitColumnComponents_CalculateMagnitudesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSplitColumnComponents_GetCalculateMagnitudes_03(HandleRef pThis);

	/// <summary>
	/// If on this filter will calculate an additional magnitude column for all
	/// columns it splits with two or more components.
	/// Default is on.
	/// </summary>
	public virtual bool GetCalculateMagnitudes()
	{
		return (vtkSplitColumnComponents_GetCalculateMagnitudes_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplitColumnComponents_GetNamingMode_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the array naming mode.
	/// Description is NUMBERS_WITH_PARENS.
	/// </summary>
	public virtual int GetNamingMode()
	{
		return vtkSplitColumnComponents_GetNamingMode_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplitColumnComponents_GetNamingModeMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the array naming mode.
	/// Description is NUMBERS_WITH_PARENS.
	/// </summary>
	public virtual int GetNamingModeMaxValue()
	{
		return vtkSplitColumnComponents_GetNamingModeMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplitColumnComponents_GetNamingModeMinValue_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the array naming mode.
	/// Description is NUMBERS_WITH_PARENS.
	/// </summary>
	public virtual int GetNamingModeMinValue()
	{
		return vtkSplitColumnComponents_GetNamingModeMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplitColumnComponents_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSplitColumnComponents_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplitColumnComponents_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSplitColumnComponents_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplitColumnComponents_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSplitColumnComponents_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplitColumnComponents_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSplitColumnComponents_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitColumnComponents_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSplitColumnComponents NewInstance()
	{
		vtkSplitColumnComponents result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitColumnComponents_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplitColumnComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitColumnComponents_ORIGINAL_ARRAY_NAME_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// These are keys that get added to each output array to make it easier for
	/// downstream filters to know which output array were extracted from which
	/// input array.
	///
	/// If either of these keys are missing, then the array was not extracted at
	/// all.
	///
	/// `ORIGINAL_COMPONENT_NUMBER` of -1 indicates magnitude.
	/// </summary>
	public static vtkInformationStringKey ORIGINAL_ARRAY_NAME()
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitColumnComponents_ORIGINAL_ARRAY_NAME_13(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringKey2 = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringKey2.Register(null);
			}
		}
		return vtkInformationStringKey2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitColumnComponents_ORIGINAL_COMPONENT_NUMBER_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// These are keys that get added to each output array to make it easier for
	/// downstream filters to know which output array were extracted from which
	/// input array.
	///
	/// If either of these keys are missing, then the array was not extracted at
	/// all.
	///
	/// `ORIGINAL_COMPONENT_NUMBER` of -1 indicates magnitude.
	/// </summary>
	public static vtkInformationIntegerKey ORIGINAL_COMPONENT_NUMBER()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitColumnComponents_ORIGINAL_COMPONENT_NUMBER_14(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitColumnComponents_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSplitColumnComponents SafeDownCast(vtkObjectBase o)
	{
		vtkSplitColumnComponents vtkSplitColumnComponents2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitColumnComponents_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSplitColumnComponents2 = (vtkSplitColumnComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSplitColumnComponents2.Register(null);
			}
		}
		return vtkSplitColumnComponents2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitColumnComponents_SetCalculateMagnitudes_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on this filter will calculate an additional magnitude column for all
	/// columns it splits with two or more components.
	/// Default is on.
	/// </summary>
	public virtual void SetCalculateMagnitudes(bool _arg)
	{
		vtkSplitColumnComponents_SetCalculateMagnitudes_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitColumnComponents_SetNamingMode_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the array naming mode.
	/// Description is NUMBERS_WITH_PARENS.
	/// </summary>
	public virtual void SetNamingMode(int _arg)
	{
		vtkSplitColumnComponents_SetNamingMode_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitColumnComponents_SetNamingModeToNamesWithParens_18(HandleRef pThis);

	/// <summary>
	/// Get/Set the array naming mode.
	/// Description is NUMBERS_WITH_PARENS.
	/// </summary>
	public void SetNamingModeToNamesWithParens()
	{
		vtkSplitColumnComponents_SetNamingModeToNamesWithParens_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitColumnComponents_SetNamingModeToNamesWithUnderscores_19(HandleRef pThis);

	/// <summary>
	/// Get/Set the array naming mode.
	/// Description is NUMBERS_WITH_PARENS.
	/// </summary>
	public void SetNamingModeToNamesWithUnderscores()
	{
		vtkSplitColumnComponents_SetNamingModeToNamesWithUnderscores_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitColumnComponents_SetNamingModeToNumberWithParens_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the array naming mode.
	/// Description is NUMBERS_WITH_PARENS.
	/// </summary>
	public void SetNamingModeToNumberWithParens()
	{
		vtkSplitColumnComponents_SetNamingModeToNumberWithParens_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitColumnComponents_SetNamingModeToNumberWithUnderscores_21(HandleRef pThis);

	/// <summary>
	/// Get/Set the array naming mode.
	/// Description is NUMBERS_WITH_PARENS.
	/// </summary>
	public void SetNamingModeToNumberWithUnderscores()
	{
		vtkSplitColumnComponents_SetNamingModeToNumberWithUnderscores_21(GetCppThis());
	}
}
