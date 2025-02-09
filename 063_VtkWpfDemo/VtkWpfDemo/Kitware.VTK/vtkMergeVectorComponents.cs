using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMergeVectorComponents
/// </summary>
/// <remarks>
///    merge components of many single-component arrays into one vector
///
/// vtkMergeVectorComponents is a filter that merges three single-component arrays
/// into one vector. This is accomplished by creating one output vector with
/// 3 components. The type of the output vector is vtkDoubleArray. The user
/// needs to define the names of the single-component arrays and the attribute-type
/// of the arrays, i.e. point-data or cell-data.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
/// </remarks>
public class vtkMergeVectorComponents : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMergeVectorComponents";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMergeVectorComponents()
	{
		MRClassNameKey = "class vtkMergeVectorComponents";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeVectorComponents"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMergeVectorComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeVectorComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeVectorComponents New()
	{
		vtkMergeVectorComponents result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeVectorComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeVectorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMergeVectorComponents()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMergeVectorComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkMergeVectorComponents_GetAttributeType_01(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets). The default value is vtkDataObject::POINT. The input value for
	/// this function should be either vtkDataObject::POINT or vtkDataObject::CELL.
	/// </summary>
	public virtual int GetAttributeType()
	{
		return vtkMergeVectorComponents_GetAttributeType_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeVectorComponents_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMergeVectorComponents_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeVectorComponents_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMergeVectorComponents_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeVectorComponents_GetOutputVectorName_04(HandleRef pThis);

	/// <summary>
	/// Set the name of the output combination vector. If name is undefined, the output vector will
	/// be named, "combinationVector".
	/// </summary>
	public virtual string GetOutputVectorName()
	{
		return Marshal.PtrToStringAnsi(vtkMergeVectorComponents_GetOutputVectorName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeVectorComponents_GetXArrayName_05(HandleRef pThis);

	/// <summary>
	/// Set the name of the array to use as the X component of the combination vector
	/// </summary>
	public virtual string GetXArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMergeVectorComponents_GetXArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeVectorComponents_GetYArrayName_06(HandleRef pThis);

	/// <summary>
	/// Set the name of the array to use as the Y component of the combination vector
	/// </summary>
	public virtual string GetYArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMergeVectorComponents_GetYArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeVectorComponents_GetZArrayName_07(HandleRef pThis);

	/// <summary>
	/// Set the name of the array to use as the Z attribute of the combination vector
	/// </summary>
	public virtual string GetZArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMergeVectorComponents_GetZArrayName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeVectorComponents_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMergeVectorComponents_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeVectorComponents_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMergeVectorComponents_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeVectorComponents_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMergeVectorComponents NewInstance()
	{
		vtkMergeVectorComponents result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeVectorComponents_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeVectorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeVectorComponents_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeVectorComponents SafeDownCast(vtkObjectBase o)
	{
		vtkMergeVectorComponents vtkMergeVectorComponents2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeVectorComponents_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMergeVectorComponents2 = (vtkMergeVectorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMergeVectorComponents2.Register(null);
			}
		}
		return vtkMergeVectorComponents2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeVectorComponents_SetAttributeType_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets). The default value is vtkDataObject::POINT. The input value for
	/// this function should be either vtkDataObject::POINT or vtkDataObject::CELL.
	/// </summary>
	public virtual void SetAttributeType(int _arg)
	{
		vtkMergeVectorComponents_SetAttributeType_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeVectorComponents_SetAttributeTypeToCellData_14(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets). The default value is vtkDataObject::POINT. The input value for
	/// this function should be either vtkDataObject::POINT or vtkDataObject::CELL.
	/// </summary>
	public void SetAttributeTypeToCellData()
	{
		vtkMergeVectorComponents_SetAttributeTypeToCellData_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeVectorComponents_SetAttributeTypeToPointData_15(HandleRef pThis);

	/// <summary>
	/// Control which AttributeType the filter operates on (point data or cell data
	/// for vtkDataSets). The default value is vtkDataObject::POINT. The input value for
	/// this function should be either vtkDataObject::POINT or vtkDataObject::CELL.
	/// </summary>
	public void SetAttributeTypeToPointData()
	{
		vtkMergeVectorComponents_SetAttributeTypeToPointData_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeVectorComponents_SetOutputVectorName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the output combination vector. If name is undefined, the output vector will
	/// be named, "combinationVector".
	/// </summary>
	public virtual void SetOutputVectorName(string _arg)
	{
		vtkMergeVectorComponents_SetOutputVectorName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeVectorComponents_SetXArrayName_17(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the array to use as the X component of the combination vector
	/// </summary>
	public virtual void SetXArrayName(string _arg)
	{
		vtkMergeVectorComponents_SetXArrayName_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeVectorComponents_SetYArrayName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the array to use as the Y component of the combination vector
	/// </summary>
	public virtual void SetYArrayName(string _arg)
	{
		vtkMergeVectorComponents_SetYArrayName_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeVectorComponents_SetZArrayName_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the array to use as the Z attribute of the combination vector
	/// </summary>
	public virtual void SetZArrayName(string _arg)
	{
		vtkMergeVectorComponents_SetZArrayName_19(GetCppThis(), _arg);
	}
}
