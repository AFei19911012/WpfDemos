using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractSelectedThresholds
/// </summary>
/// <remarks>
///    extract a cells or points from a
/// dataset that have values within a set of thresholds.
///
///
/// vtkExtractSelectedThresholds extracts all cells and points with attribute
/// values that lie within a vtkSelection's THRESHOLD contents. The selecion
/// can specify to threshold a particular array within either the point or cell
/// attribute data of the input. This is similar to vtkThreshold
/// but allows multiple thresholds ranges.
/// This filter adds a scalar array called vtkOriginalCellIds that says what
/// input cell produced each output cell. This is an example of a Pedigree ID
/// which helps to trace back results.
///
/// </remarks>
/// <seealso>
///
/// vtkSelection vtkExtractSelection vtkThreshold
///
/// @deprecated vtkExtractSelectedThresholds is deprecated in VTK 9.2 and will be removed.
/// Use `vtkExtractSelection` instead of `vtkExtractSelectedThresholds`.
///
/// Example using vtkExtractSelectedThresholds:
///
/// vtkNew&lt;vtkExtractSelectedThresholds&gt; selFilter;
/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
///
/// Example using vtkExtractSelection:
///
/// vtkNew&lt;vtkExtractSelection&gt; selFilter;
/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
/// </seealso>
public class vtkExtractSelectedThresholds : vtkExtractSelectionBase
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedThresholds";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractSelectedThresholds()
	{
		MRClassNameKey = "class vtkExtractSelectedThresholds";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedThresholds"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractSelectedThresholds(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedThresholds_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Constructor
	/// </summary>
	public new static vtkExtractSelectedThresholds New()
	{
		vtkExtractSelectedThresholds result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedThresholds_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedThresholds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Constructor
	/// </summary>
	public vtkExtractSelectedThresholds()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractSelectedThresholds_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkExtractSelectedThresholds_EvaluateValue_01(HandleRef scalars, long id, HandleRef lims);

	/// <summary>
	/// Function for determining whether a value in a data array passes
	/// the threshold test(s) provided in lims.  Returns 1 if the value
	/// passes at least one of the threshold tests.
	/// If \c scalars is nullptr, then the id itself is used as the scalar value.
	/// </summary>
	public static int EvaluateValue(vtkDataArray scalars, long id, vtkDataArray lims)
	{
		return vtkExtractSelectedThresholds_EvaluateValue_01(scalars?.GetCppThis() ?? default(HandleRef), id, lims?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedThresholds_EvaluateValue_02(HandleRef array, int array_component_no, long id, HandleRef lims);

	/// <summary>
	/// Same as the other EvaluateValue except that the component to be compared
	/// can be picked using array_component_no (use -1 for magnitude).
	/// If \c scalars is nullptr, then the id itself is used as the scalar value.
	/// </summary>
	public static int EvaluateValue(vtkDataArray array, int array_component_no, long id, vtkDataArray lims)
	{
		return vtkExtractSelectedThresholds_EvaluateValue_02(array?.GetCppThis() ?? default(HandleRef), array_component_no, id, lims?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedThresholds_EvaluateValue_03(HandleRef scalars, long id, HandleRef lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount);

	/// <summary>
	/// Function for determining whether a value in a data array passes
	/// the threshold test(s) provided in lims.  Returns 1 if the value
	/// passes at least one of the threshold tests.  Also returns in
	/// AboveCount, BelowCount and InsideCount the number of tests where
	/// the value was above, below or inside the interval.
	/// If \c scalars is nullptr, then the id itself is used as the scalar value.
	/// </summary>
	public static int EvaluateValue(vtkDataArray scalars, long id, vtkDataArray lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount)
	{
		return vtkExtractSelectedThresholds_EvaluateValue_03(scalars?.GetCppThis() ?? default(HandleRef), id, lims?.GetCppThis() ?? default(HandleRef), AboveCount, BelowCount, InsideCount);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedThresholds_EvaluateValue_04(HandleRef scalars, int array_component_no, long id, HandleRef lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount);

	/// <summary>
	/// Same as the other EvaluateValue except that the component to be compared
	/// can be picked using array_component_no (use -1 for magnitude).
	/// If \c scalars is nullptr, then the id itself is used as the scalar value.
	/// </summary>
	public static int EvaluateValue(vtkDataArray scalars, int array_component_no, long id, vtkDataArray lims, IntPtr AboveCount, IntPtr BelowCount, IntPtr InsideCount)
	{
		return vtkExtractSelectedThresholds_EvaluateValue_04(scalars?.GetCppThis() ?? default(HandleRef), array_component_no, id, lims?.GetCppThis() ?? default(HandleRef), AboveCount, BelowCount, InsideCount);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectedThresholds_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractSelectedThresholds_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectedThresholds_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractSelectedThresholds_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedThresholds_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractSelectedThresholds_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedThresholds_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractSelectedThresholds_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedThresholds_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractSelectedThresholds NewInstance()
	{
		vtkExtractSelectedThresholds result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedThresholds_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedThresholds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedThresholds_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectedThresholds SafeDownCast(vtkObjectBase o)
	{
		vtkExtractSelectedThresholds vtkExtractSelectedThresholds2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedThresholds_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractSelectedThresholds2 = (vtkExtractSelectedThresholds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractSelectedThresholds2.Register(null);
			}
		}
		return vtkExtractSelectedThresholds2;
	}
}
