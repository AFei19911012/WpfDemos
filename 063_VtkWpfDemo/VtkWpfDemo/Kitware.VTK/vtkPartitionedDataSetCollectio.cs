using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkPartitionedDataSetCollectionAlgorithm
/// </summary>
/// <remarks>
///  Superclass for algorithms that produce vtkPartitionedDataSetCollectionAlgorithm
///
/// vtkPartitionedDataSetCollectionAlgorithm is intended as a superclass for algorithms that
/// produce a vtkPartitionedDataSetCollection.
/// </remarks>
public class vtkPartitionedDataSetCollectionAlgorithm : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSetCollectionAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPartitionedDataSetCollectionAlgorithm()
	{
		MRClassNameKey = "class vtkPartitionedDataSetCollectionAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSetCollectionAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPartitionedDataSetCollectionAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionedDataSetCollectionAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPartitionedDataSetCollectionAlgorithm_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionedDataSetCollectionAlgorithm_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPartitionedDataSetCollectionAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollectionAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for the specified output port.
	/// </summary>
	public vtkPartitionedDataSetCollection GetOutput()
	{
		vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollectionAlgorithm_GetOutput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSetCollection2 = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSetCollection2.Register(null);
			}
		}
		return vtkPartitionedDataSetCollection2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollectionAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for the specified output port.
	/// </summary>
	public vtkPartitionedDataSetCollection GetOutput(int arg0)
	{
		vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollectionAlgorithm_GetOutput_04(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSetCollection2 = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSetCollection2.Register(null);
			}
		}
		return vtkPartitionedDataSetCollection2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollectionAlgorithm_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPartitionedDataSetCollectionAlgorithm_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollectionAlgorithm_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPartitionedDataSetCollectionAlgorithm_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollectionAlgorithm_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPartitionedDataSetCollectionAlgorithm NewInstance()
	{
		vtkPartitionedDataSetCollectionAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollectionAlgorithm_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionedDataSetCollectionAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollectionAlgorithm_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionedDataSetCollectionAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkPartitionedDataSetCollectionAlgorithm vtkPartitionedDataSetCollectionAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollectionAlgorithm_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSetCollectionAlgorithm2 = (vtkPartitionedDataSetCollectionAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSetCollectionAlgorithm2.Register(null);
			}
		}
		return vtkPartitionedDataSetCollectionAlgorithm2;
	}
}
/// <summary>
///  vtkPartitionedDataSetCollectionSource
/// </summary>
/// <remarks>
///  a source that produces a vtkPartitionedDataSetCollection.
///
/// vtkPartitionedDataSetCollection generates a vtkPartitionedDataSetCollection
/// for testing purposes. It uses vtkParametricFunctionSource internally to
/// generate different types of surfaces for each partitioned dataset in the
/// collection. Each partitioned dataset is split among ranks in an even fashion.
/// Thus the number of partitions per rank for a partitioned dataset are always
/// different.
/// </remarks>
public class vtkPartitionedDataSetCollectionSource : vtkPartitionedDataSetCollectionAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSetCollectionSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPartitionedDataSetCollectionSource()
	{
		MRClassNameKey = "class vtkPartitionedDataSetCollectionSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSetCollectionSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPartitionedDataSetCollectionSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollectionSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionedDataSetCollectionSource New()
	{
		vtkPartitionedDataSetCollectionSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollectionSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionedDataSetCollectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPartitionedDataSetCollectionSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPartitionedDataSetCollectionSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionedDataSetCollectionSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPartitionedDataSetCollectionSource_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionedDataSetCollectionSource_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPartitionedDataSetCollectionSource_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollectionSource_GetNumberOfShapes_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of partitioned datasets in the collection.
	/// </summary>
	public virtual int GetNumberOfShapes()
	{
		return vtkPartitionedDataSetCollectionSource_GetNumberOfShapes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollectionSource_GetNumberOfShapesMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of partitioned datasets in the collection.
	/// </summary>
	public virtual int GetNumberOfShapesMaxValue()
	{
		return vtkPartitionedDataSetCollectionSource_GetNumberOfShapesMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollectionSource_GetNumberOfShapesMinValue_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of partitioned datasets in the collection.
	/// </summary>
	public virtual int GetNumberOfShapesMinValue()
	{
		return vtkPartitionedDataSetCollectionSource_GetNumberOfShapesMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollectionSource_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPartitionedDataSetCollectionSource_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollectionSource_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPartitionedDataSetCollectionSource_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollectionSource_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPartitionedDataSetCollectionSource NewInstance()
	{
		vtkPartitionedDataSetCollectionSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollectionSource_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionedDataSetCollectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollectionSource_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionedDataSetCollectionSource SafeDownCast(vtkObjectBase o)
	{
		vtkPartitionedDataSetCollectionSource vtkPartitionedDataSetCollectionSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollectionSource_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSetCollectionSource2 = (vtkPartitionedDataSetCollectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSetCollectionSource2.Register(null);
			}
		}
		return vtkPartitionedDataSetCollectionSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollectionSource_SetNumberOfShapes_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of partitioned datasets in the collection.
	/// </summary>
	public virtual void SetNumberOfShapes(int _arg)
	{
		vtkPartitionedDataSetCollectionSource_SetNumberOfShapes_11(GetCppThis(), _arg);
	}
}
/// <summary>
///    vtkPartitionedDataSetCollection
/// </summary>
/// <remarks>
///    Composite dataset that groups datasets as a collection.
///
/// vtkPartitionedDataSetCollection is a vtkCompositeDataSet that stores
/// a collection of non-null vtkPartitionedDataSets. These items can represent
/// different concepts depending on the context. For example, they can
/// represent region of different materials in a simulation or parts in
/// an assembly. It is not requires that items have anything in common.
/// For example, they can have completely different point or cell arrays.
/// </remarks>
public class vtkPartitionedDataSetCollection : vtkDataObjectTree
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSetCollection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPartitionedDataSetCollection()
	{
		MRClassNameKey = "class vtkPartitionedDataSetCollection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSetCollection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPartitionedDataSetCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionedDataSetCollection New()
	{
		vtkPartitionedDataSetCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPartitionedDataSetCollection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPartitionedDataSetCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPartitionedDataSetCollection_CopyStructure_01(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Overridden to handle vtkDataAssembly.
	/// </summary>
	public override void CopyStructure(vtkCompositeDataSet input)
	{
		vtkPartitionedDataSetCollection_CopyStructure_01(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollection_DeepCopy_02(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Overridden to handle vtkDataAssembly.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkPartitionedDataSetCollection_DeepCopy_02(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPartitionedDataSetCollection_GetCompositeIndex_03(HandleRef pThis, uint idx);

	/// <summary>
	/// Returns the composite index (sometimes referred to as the flat-index) for
	/// either a partitioned dataset or a specific partition in a partitioned
	/// dataset.
	/// </summary>
	public uint GetCompositeIndex(uint idx)
	{
		return vtkPartitionedDataSetCollection_GetCompositeIndex_03(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPartitionedDataSetCollection_GetCompositeIndex_04(HandleRef pThis, uint idx, uint partition);

	/// <summary>
	/// Returns the composite index (sometimes referred to as the flat-index) for
	/// either a partitioned dataset or a specific partition in a partitioned
	/// dataset.
	/// </summary>
	public uint GetCompositeIndex(uint idx, uint partition)
	{
		return vtkPartitionedDataSetCollection_GetCompositeIndex_04(GetCppThis(), idx, partition);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_GetData_05(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPartitionedDataSetCollection GetData(vtkInformation info)
	{
		vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_GetData_05(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSetCollection2 = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSetCollection2.Register(null);
			}
		}
		return vtkPartitionedDataSetCollection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_GetData_06(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPartitionedDataSetCollection GetData(vtkInformationVector v, int i)
	{
		vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_GetData_06(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSetCollection2 = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSetCollection2.Register(null);
			}
		}
		return vtkPartitionedDataSetCollection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_GetDataAssembly_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// DataAssembly provides a way to define hierarchical organization of
	/// partitioned-datasets. These methods provide access to the data assembly
	/// instances associated, if any.
	/// </summary>
	public virtual vtkDataAssembly GetDataAssembly()
	{
		vtkDataAssembly vtkDataAssembly2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_GetDataAssembly_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataAssembly2 = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataAssembly2.Register(null);
			}
		}
		return vtkDataAssembly2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollection_GetDataObjectType_08(HandleRef pThis);

	/// <summary>
	/// Return class name of data type (see vtkType.h for
	/// definitions).
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkPartitionedDataSetCollection_GetDataObjectType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPartitionedDataSetCollection_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// Overridden to include DataAssembly MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPartitionedDataSetCollection_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_GetMetaData_10(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the meta-data for the block. If none is already present, a new
	/// vtkInformation object will be allocated. Use HasMetaData to avoid
	/// allocating vtkInformation objects.
	/// </summary>
	public vtkInformation GetMetaData(uint idx)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_GetMetaData_10(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_GetMetaData_11(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Unhiding superclass method.
	/// </summary>
	public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_GetMetaData_11(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionedDataSetCollection_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPartitionedDataSetCollection_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionedDataSetCollection_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPartitionedDataSetCollection_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPartitionedDataSetCollection_GetNumberOfPartitionedDataSets_14(HandleRef pThis);

	/// <summary>
	/// Returns the number of blocks.
	/// </summary>
	public uint GetNumberOfPartitionedDataSets()
	{
		return vtkPartitionedDataSetCollection_GetNumberOfPartitionedDataSets_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPartitionedDataSetCollection_GetNumberOfPartitions_15(HandleRef pThis, uint idx);

	/// <summary>
	/// Returns the number of partitions in a partitioned dataset at the given index.
	/// </summary>
	public uint GetNumberOfPartitions(uint idx)
	{
		return vtkPartitionedDataSetCollection_GetNumberOfPartitions_15(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_GetPartition_16(HandleRef pThis, uint idx, uint partition, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// API to get/set partitions using a tuple index.
	/// </summary>
	public vtkDataSet GetPartition(uint idx, uint partition)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_GetPartition_16(GetCppThis(), idx, partition, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_GetPartitionAsDataObject_17(HandleRef pThis, uint idx, uint partition, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// API to get/set partitions using a tuple index.
	/// </summary>
	public vtkDataObject GetPartitionAsDataObject(uint idx, uint partition)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_GetPartitionAsDataObject_17(GetCppThis(), idx, partition, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPartitionedDataSetCollection_GetPartitionedDataSet_18(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the block at the given index. It is recommended that one uses the
	/// iterators to iterate over composite datasets rather than using this API.
	/// </summary>
	public vtkPartitionedDataSet GetPartitionedDataSet(uint idx)
	{
		vtkPartitionedDataSet vtkPartitionedDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_GetPartitionedDataSet_18(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSet2 = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSet2.Register(null);
			}
		}
		return vtkPartitionedDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollection_HasMetaData_19(HandleRef pThis, uint idx);

	/// <summary>
	/// Returns true if meta-data is available for a given block.
	/// </summary>
	public int HasMetaData(uint idx)
	{
		return vtkPartitionedDataSetCollection_HasMetaData_19(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollection_HasMetaData_20(HandleRef pThis, HandleRef iter);

	/// <summary>
	/// Unhiding superclass method.
	/// </summary>
	public override int HasMetaData(vtkCompositeDataIterator iter)
	{
		return vtkPartitionedDataSetCollection_HasMetaData_20(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollection_Initialize_21(HandleRef pThis);

	/// <summary>
	/// Overridden to handle vtkDataAssembly.
	/// </summary>
	public override void Initialize()
	{
		vtkPartitionedDataSetCollection_Initialize_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollection_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPartitionedDataSetCollection_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSetCollection_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPartitionedDataSetCollection_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPartitionedDataSetCollection NewInstance()
	{
		vtkPartitionedDataSetCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollection_RemovePartitionedDataSet_26(HandleRef pThis, uint idx);

	/// <summary>
	/// Remove the given block from the dataset.
	/// </summary>
	public void RemovePartitionedDataSet(uint idx)
	{
		vtkPartitionedDataSetCollection_RemovePartitionedDataSet_26(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSetCollection_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionedDataSetCollection SafeDownCast(vtkObjectBase o)
	{
		vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSetCollection_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSetCollection2 = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSetCollection2.Register(null);
			}
		}
		return vtkPartitionedDataSetCollection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollection_SetDataAssembly_28(HandleRef pThis, HandleRef assembly);

	/// <summary>
	/// DataAssembly provides a way to define hierarchical organization of
	/// partitioned-datasets. These methods provide access to the data assembly
	/// instances associated, if any.
	/// </summary>
	public void SetDataAssembly(vtkDataAssembly assembly)
	{
		vtkPartitionedDataSetCollection_SetDataAssembly_28(GetCppThis(), assembly?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollection_SetNumberOfPartitionedDataSets_29(HandleRef pThis, uint numDataSets);

	/// <summary>
	/// Set the number of blocks. This will cause allocation if the new number of
	/// blocks is greater than the current size. All new blocks are initialized to
	/// with empty `vtkPartitionedDataSetCollection` instances.
	/// </summary>
	public void SetNumberOfPartitionedDataSets(uint numDataSets)
	{
		vtkPartitionedDataSetCollection_SetNumberOfPartitionedDataSets_29(GetCppThis(), numDataSets);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollection_SetNumberOfPartitions_30(HandleRef pThis, uint idx, uint numPartitions);

	/// <summary>
	/// Set number of partitions at a given index. Note, this will call
	/// `SetNumberOfPartitionedDataSets` if needed to grow the collection.
	/// </summary>
	public void SetNumberOfPartitions(uint idx, uint numPartitions)
	{
		vtkPartitionedDataSetCollection_SetNumberOfPartitions_30(GetCppThis(), idx, numPartitions);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollection_SetPartition_31(HandleRef pThis, uint idx, uint partition, HandleRef arg2);

	/// <summary>
	/// API to get/set partitions using a tuple index.
	/// </summary>
	public void SetPartition(uint idx, uint partition, vtkDataObject arg2)
	{
		vtkPartitionedDataSetCollection_SetPartition_31(GetCppThis(), idx, partition, arg2?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollection_SetPartitionedDataSet_32(HandleRef pThis, uint idx, HandleRef dataset);

	/// <summary>
	/// Sets the data object as the given block. The total number of blocks will
	/// be resized to fit the requested block no.
	///
	/// @remark `dataset` cannot be nullptr.
	/// </summary>
	public void SetPartitionedDataSet(uint idx, vtkPartitionedDataSet dataset)
	{
		vtkPartitionedDataSetCollection_SetPartitionedDataSet_32(GetCppThis(), idx, dataset?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSetCollection_ShallowCopy_33(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Overridden to handle vtkDataAssembly.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkPartitionedDataSetCollection_ShallowCopy_33(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}
}
