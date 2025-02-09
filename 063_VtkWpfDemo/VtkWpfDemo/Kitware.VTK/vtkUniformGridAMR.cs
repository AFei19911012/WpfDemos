using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUniformGridAMR
/// </summary>
/// <remarks>
///    a concrete implementation of vtkCompositeDataSet
///
/// vtkUniformGridAMR is an AMR (hierarchical) composite dataset that holds vtkUniformGrids.
///
/// </remarks>
/// <seealso>
///
/// vtkUniformGridAMRDataIterator
/// </seealso>
public class vtkUniformGridAMR : vtkCompositeDataSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGridAMR";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUniformGridAMR()
	{
		MRClassNameKey = "class vtkUniformGridAMR";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGridAMR"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUniformGridAMR(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMR_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUniformGridAMR New()
	{
		vtkUniformGridAMR result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMR_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUniformGridAMR()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUniformGridAMR_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_CopyStructure_01(HandleRef pThis, HandleRef src);

	/// <summary>
	/// CopyStructure.
	/// </summary>
	public override void CopyStructure(vtkCompositeDataSet src)
	{
		vtkUniformGridAMR_CopyStructure_01(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_DeepCopy_02(HandleRef pThis, HandleRef src);

	/// <summary>
	/// DeepCopy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkUniformGridAMR_DeepCopy_02(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_GetBounds_03(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the (min/max) bounds of the AMR domain.
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkUniformGridAMR_GetBounds_03(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMR_GetBounds_04(HandleRef pThis);

	/// <summary>
	/// Get the (min/max) bounds of the AMR domain.
	/// </summary>
	public IntPtr GetBounds()
	{
		return vtkUniformGridAMR_GetBounds_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridAMR_GetCompositeIndex_05(HandleRef pThis, uint level, uint index);

	/// <summary>
	/// Retrieves the composite index associated with the data at the given
	/// (level,index) pair.
	/// </summary>
	public int GetCompositeIndex(uint level, uint index)
	{
		return vtkUniformGridAMR_GetCompositeIndex_05(GetCppThis(), level, index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMR_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkUniformGridAMR GetData(vtkInformation info)
	{
		vtkUniformGridAMR vtkUniformGridAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMR_GetData_06(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGridAMR2 = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGridAMR2.Register(null);
			}
		}
		return vtkUniformGridAMR2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMR_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkUniformGridAMR GetData(vtkInformationVector v, int i)
	{
		vtkUniformGridAMR vtkUniformGridAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMR_GetData_07(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGridAMR2 = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGridAMR2.Register(null);
			}
		}
		return vtkUniformGridAMR2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridAMR_GetDataObjectType_08(HandleRef pThis);

	/// <summary>
	/// Return class name of data type (see vtkType.h for definitions).
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkUniformGridAMR_GetDataObjectType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMR_GetDataSet_09(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data set pointed to by iter
	/// </summary>
	public override vtkDataObject GetDataSet(vtkCompositeDataIterator iter)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMR_GetDataSet_09(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMR_GetDataSet_10(HandleRef pThis, uint level, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data set using the (level, index) pair.
	/// </summary>
	public vtkUniformGrid GetDataSet(uint level, uint idx)
	{
		vtkUniformGrid vtkUniformGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMR_GetDataSet_10(GetCppThis(), level, idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGrid2 = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGrid2.Register(null);
			}
		}
		return vtkUniformGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridAMR_GetGridDescription_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the data description of this uniform grid instance,
	/// e.g. VTK_XYZ_GRID
	/// </summary>
	public int GetGridDescription()
	{
		return vtkUniformGridAMR_GetGridDescription_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_GetLevelAndIndex_12(HandleRef pThis, uint compositeIdx, ref uint level, ref uint idx);

	/// <summary>
	/// Given the compositeIdx (as set by SetCompositeIdx) this method returns the
	/// corresponding level and dataset index within the level.
	/// </summary>
	public void GetLevelAndIndex(uint compositeIdx, ref uint level, ref uint idx)
	{
		vtkUniformGridAMR_GetLevelAndIndex_12(GetCppThis(), compositeIdx, ref level, ref idx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_GetMax_13(HandleRef pThis, IntPtr max);

	/// <summary>
	/// Get the (min/max) bounds of the AMR domain.
	/// </summary>
	public void GetMax(IntPtr max)
	{
		vtkUniformGridAMR_GetMax_13(GetCppThis(), max);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_GetMin_14(HandleRef pThis, IntPtr min);

	/// <summary>
	/// Get the (min/max) bounds of the AMR domain.
	/// </summary>
	public void GetMin(IntPtr min)
	{
		vtkUniformGridAMR_GetMin_14(GetCppThis(), min);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkUniformGridAMR_GetNumberOfDataSets_15(HandleRef pThis, uint level);

	/// <summary>
	/// Get the number of datasets at the given level, including null blocks
	/// </summary>
	public uint GetNumberOfDataSets(uint level)
	{
		return vtkUniformGridAMR_GetNumberOfDataSets_15(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniformGridAMR_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUniformGridAMR_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniformGridAMR_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUniformGridAMR_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkUniformGridAMR_GetNumberOfLevels_18(HandleRef pThis);

	/// <summary>
	/// Get number of levels.
	/// </summary>
	public uint GetNumberOfLevels()
	{
		return vtkUniformGridAMR_GetNumberOfLevels_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkUniformGridAMR_GetTotalNumberOfBlocks_19(HandleRef pThis);

	/// <summary>
	/// Get the total number of blocks, including nullptr blocks
	/// </summary>
	public virtual uint GetTotalNumberOfBlocks()
	{
		return vtkUniformGridAMR_GetTotalNumberOfBlocks_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_Initialize_20(HandleRef pThis);

	/// <summary>
	/// Restore data object to initial state.
	/// </summary>
	public override void Initialize()
	{
		vtkUniformGridAMR_Initialize_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_Initialize_21(HandleRef pThis, int numLevels, IntPtr blocksPerLevel);

	/// <summary>
	/// Initialize the AMR with a specified number of levels and the blocks per level.
	/// </summary>
	public virtual void Initialize(int numLevels, IntPtr blocksPerLevel)
	{
		vtkUniformGridAMR_Initialize_21(GetCppThis(), numLevels, blocksPerLevel);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridAMR_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUniformGridAMR_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridAMR_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUniformGridAMR_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMR_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUniformGridAMR NewInstance()
	{
		vtkUniformGridAMR result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMR_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMR_NewIterator_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a new iterator (the iterator has to be deleted by the user).
	/// </summary>
	public override vtkCompositeDataIterator NewIterator()
	{
		vtkCompositeDataIterator vtkCompositeDataIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMR_NewIterator_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataIterator2 = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataIterator2.Register(null);
			}
		}
		return vtkCompositeDataIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_RecursiveShallowCopy_27(HandleRef pThis, HandleRef src);

	/// <summary>
	/// ShallowCopy.
	/// </summary>
	public override void RecursiveShallowCopy(vtkDataObject src)
	{
		vtkUniformGridAMR_RecursiveShallowCopy_27(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMR_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUniformGridAMR SafeDownCast(vtkObjectBase o)
	{
		vtkUniformGridAMR vtkUniformGridAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMR_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGridAMR2 = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGridAMR2.Register(null);
			}
		}
		return vtkUniformGridAMR2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_SetDataSet_29(HandleRef pThis, HandleRef iter, HandleRef dataObj);

	/// <summary>
	/// Overriding superclass method.
	/// </summary>
	public override void SetDataSet(vtkCompositeDataIterator iter, vtkDataObject dataObj)
	{
		vtkUniformGridAMR_SetDataSet_29(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), dataObj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_SetDataSet_30(HandleRef pThis, uint level, uint idx, HandleRef grid);

	/// <summary>
	/// At the passed in level, set grid as the idx'th block at that level. idx must be less
	/// than the number of data sets at that level
	/// </summary>
	public virtual void SetDataSet(uint level, uint idx, vtkUniformGrid grid)
	{
		vtkUniformGridAMR_SetDataSet_30(GetCppThis(), level, idx, grid?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_SetGridDescription_31(HandleRef pThis, int gridDescription);

	/// <summary>
	/// Set/Get the data description of this uniform grid instance,
	/// e.g. VTK_XYZ_GRID
	/// </summary>
	public void SetGridDescription(int gridDescription)
	{
		vtkUniformGridAMR_SetGridDescription_31(GetCppThis(), gridDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMR_ShallowCopy_32(HandleRef pThis, HandleRef src);

	/// <summary>
	/// ShallowCopy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkUniformGridAMR_ShallowCopy_32(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}
}
