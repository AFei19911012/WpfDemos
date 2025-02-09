using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAppendCompositeDataLeaves
/// </summary>
/// <remarks>
///    appends one or more composite datasets with the same structure together into a single
/// output composite dataset
///
/// vtkAppendCompositeDataLeaves is a filter that takes input composite datasets with the same
/// structure: (1) the same number of entries and -- if any children are composites -- the
/// same constraint holds from them; and (2) the same type of dataset at each position.
/// It then creates an output dataset with the same structure whose leaves contain all the
/// cells from the datasets at the corresponding leaves of the input datasets.
///
/// Currently, this filter only supports "appending" of a few types for the leaf
/// nodes and the logic used for each supported data type is as follows:
///
/// \li vtkUnstructuredGrid - appends all unstructured grids from the leaf
///     location on all inputs into a single unstructured grid for the
///     corresponding location in the output composite dataset. PointData and
///     CellData arrays are extracted and appended only if they are available in
///     all datasets.(For example, if one dataset has scalars but another does
///     not, scalars will not be appended.)
///
/// \li vtkPolyData - appends all polydatas from the leaf location on all inputs
///     into a single polydata for the corresponding location in the output
///     composite dataset. PointData and CellData arrays are extracted and
///     appended only if they are available in all datasets.(For example, if one
///     dataset has scalars but another does not, scalars will not be appended.)
///
/// \li vtkImageData/vtkUniformGrid - simply passes the first non-null
///     grid for a particular location to corresponding location in the output.
///
/// \li vtkTable - simply passes the first non-null vtkTable for a particular
///     location to the corresponding location in the output.
///
/// Other types of leaf datasets will be ignored and their positions in the
/// output dataset will be nullptr pointers.
///
/// </remarks>
/// <seealso>
///
/// vtkAppendPolyData vtkAppendFilter
/// </seealso>
public class vtkAppendCompositeDataLeaves : vtkCompositeDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAppendCompositeDataLeaves";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAppendCompositeDataLeaves()
	{
		MRClassNameKey = "class vtkAppendCompositeDataLeaves";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendCompositeDataLeaves"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAppendCompositeDataLeaves(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendCompositeDataLeaves_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendCompositeDataLeaves New()
	{
		vtkAppendCompositeDataLeaves result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendCompositeDataLeaves_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendCompositeDataLeaves)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAppendCompositeDataLeaves()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAppendCompositeDataLeaves_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendCompositeDataLeaves_AppendFieldDataOff_01(HandleRef pThis);

	/// <summary>
	/// Set/get whether the field data of each dataset in the composite dataset is copied to the
	/// output. If AppendFieldData is non-zero, then field data arrays from all the inputs are added to
	/// the output. If there are duplicates, the array on the first input encountered is taken.
	/// </summary>
	public virtual void AppendFieldDataOff()
	{
		vtkAppendCompositeDataLeaves_AppendFieldDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendCompositeDataLeaves_AppendFieldDataOn_02(HandleRef pThis);

	/// <summary>
	/// Set/get whether the field data of each dataset in the composite dataset is copied to the
	/// output. If AppendFieldData is non-zero, then field data arrays from all the inputs are added to
	/// the output. If there are duplicates, the array on the first input encountered is taken.
	/// </summary>
	public virtual void AppendFieldDataOn()
	{
		vtkAppendCompositeDataLeaves_AppendFieldDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendCompositeDataLeaves_GetAppendFieldData_03(HandleRef pThis);

	/// <summary>
	/// Set/get whether the field data of each dataset in the composite dataset is copied to the
	/// output. If AppendFieldData is non-zero, then field data arrays from all the inputs are added to
	/// the output. If there are duplicates, the array on the first input encountered is taken.
	/// </summary>
	public virtual int GetAppendFieldData()
	{
		return vtkAppendCompositeDataLeaves_GetAppendFieldData_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendCompositeDataLeaves_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAppendCompositeDataLeaves_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendCompositeDataLeaves_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAppendCompositeDataLeaves_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendCompositeDataLeaves_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAppendCompositeDataLeaves_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendCompositeDataLeaves_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAppendCompositeDataLeaves_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendCompositeDataLeaves_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAppendCompositeDataLeaves NewInstance()
	{
		vtkAppendCompositeDataLeaves result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendCompositeDataLeaves_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendCompositeDataLeaves)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendCompositeDataLeaves_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendCompositeDataLeaves SafeDownCast(vtkObjectBase o)
	{
		vtkAppendCompositeDataLeaves vtkAppendCompositeDataLeaves2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendCompositeDataLeaves_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAppendCompositeDataLeaves2 = (vtkAppendCompositeDataLeaves)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAppendCompositeDataLeaves2.Register(null);
			}
		}
		return vtkAppendCompositeDataLeaves2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendCompositeDataLeaves_SetAppendFieldData_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether the field data of each dataset in the composite dataset is copied to the
	/// output. If AppendFieldData is non-zero, then field data arrays from all the inputs are added to
	/// the output. If there are duplicates, the array on the first input encountered is taken.
	/// </summary>
	public virtual void SetAppendFieldData(int _arg)
	{
		vtkAppendCompositeDataLeaves_SetAppendFieldData_11(GetCppThis(), _arg);
	}
}
