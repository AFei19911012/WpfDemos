using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractSelectedPolyDataIds
/// </summary>
/// <remarks>
///    extract a list of cells from a polydata
///
/// vtkExtractSelectedPolyDataIds extracts all cells in vtkSelection from a
/// vtkPolyData.
///
/// </remarks>
/// <seealso>
///
/// vtkSelection
///
/// @deprecated vtkExtractSelectedPolyDataIds is deprecated in VTK 9.2 and will be removed.
/// Use `vtkExtractSelection` instead of `vtkExtractSelectedPolyDataIds`.
///
/// Example using vtkExtractSelectedPolyDataIds:
///
/// vtkNew&lt;vtkExtractSelectedPolyDataIds&gt; selFilter;
/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
///
/// Example using vtkExtractSelection:
///
/// vtkNew&lt;vtkExtractSelection&gt; selFilter;
/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
///
/// convert selFilter's output from vtkUnstructuredGrid to vtkPolydata
/// </seealso>
public class vtkExtractSelectedPolyDataIds : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedPolyDataIds";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractSelectedPolyDataIds()
	{
		MRClassNameKey = "class vtkExtractSelectedPolyDataIds";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedPolyDataIds"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractSelectedPolyDataIds(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedPolyDataIds_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectedPolyDataIds New()
	{
		vtkExtractSelectedPolyDataIds result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedPolyDataIds_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedPolyDataIds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractSelectedPolyDataIds()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractSelectedPolyDataIds_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkExtractSelectedPolyDataIds_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractSelectedPolyDataIds_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectedPolyDataIds_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractSelectedPolyDataIds_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedPolyDataIds_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractSelectedPolyDataIds_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedPolyDataIds_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractSelectedPolyDataIds_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedPolyDataIds_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractSelectedPolyDataIds NewInstance()
	{
		vtkExtractSelectedPolyDataIds result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedPolyDataIds_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedPolyDataIds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedPolyDataIds_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectedPolyDataIds SafeDownCast(vtkObjectBase o)
	{
		vtkExtractSelectedPolyDataIds vtkExtractSelectedPolyDataIds2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedPolyDataIds_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractSelectedPolyDataIds2 = (vtkExtractSelectedPolyDataIds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractSelectedPolyDataIds2.Register(null);
			}
		}
		return vtkExtractSelectedPolyDataIds2;
	}
}
