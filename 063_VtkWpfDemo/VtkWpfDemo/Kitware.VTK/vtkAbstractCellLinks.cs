using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractCellLinks
/// </summary>
/// <remarks>
///    an abstract base class for classes that build
/// topological links from points to cells
///
/// vtkAbstractCellLinks is a family of supplemental objects to vtkCellArray and
/// vtkCellTypes, enabling fast access from points to the cells using the
/// points. vtkAbstractCellLinks is an array of links, each link representing a
/// list of cell ids using a particular point. The information provided by
/// this object can be used to determine neighbors and construct other local
/// topological information.
///
/// </remarks>
/// <seealso>
///
/// vtkCellLinks vtkStaticCellLinks vtkStaticCellLinksTemplate
/// </seealso>
public abstract class vtkAbstractCellLinks : vtkObject
{
	/// <summary>
	/// Standard DeepCopy method.  Since this object contains no reference
	/// to other objects, there is no ShallowCopy.
	/// </summary>
	public enum CellLinksTypes
	{
		/// <summary>enum member</summary>
		CELL_LINKS = 1,
		/// <summary>enum member</summary>
		LINKS_NOT_DEFINED = 0,
		/// <summary>enum member</summary>
		STATIC_CELL_LINKS_IDTYPE = 4,
		/// <summary>enum member</summary>
		STATIC_CELL_LINKS_SPECIALIZED = 5,
		/// <summary>enum member</summary>
		STATIC_CELL_LINKS_UINT = 3,
		/// <summary>enum member</summary>
		STATIC_CELL_LINKS_USHORT = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractCellLinks";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractCellLinks()
	{
		MRClassNameKey = "class vtkAbstractCellLinks";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractCellLinks"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractCellLinks(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLinks_BuildLinks_01(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Build the link list array. All subclasses must implement this method.
	/// </summary>
	public virtual void BuildLinks(vtkDataSet data)
	{
		vtkAbstractCellLinks_BuildLinks_01(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLinks_ComputeType_02(long maxPtId, long maxCellId, HandleRef ca);

	/// <summary>
	/// Based on the input (i.e., number of points, number of cells, and length
	/// of connectivity array) this helper method returns the integral type to
	/// use when instantiating cell link-related classes in order to properly
	/// represent the data.  The return value is one of the types
	/// defined in the enum CellLinksType enum defined previously. Subclasses
	/// may choose to instantiate themselves with different integral types for
	/// performance and/or memory reasons. This method is useful when instantiating
	/// a vtkStaticCellLinksTemplate; when instantiating a vtkCellLinks the class
	/// is hardwired for vtkIdType.
	/// </summary>
	public static int ComputeType(long maxPtId, long maxCellId, vtkCellArray ca)
	{
		return vtkAbstractCellLinks_ComputeType_02(maxPtId, maxCellId, ca?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLinks_DeepCopy_03(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Standard DeepCopy method.  Since this object contains no reference
	/// to other objects, there is no ShallowCopy.
	/// </summary>
	public virtual void DeepCopy(vtkAbstractCellLinks src)
	{
		vtkAbstractCellLinks_DeepCopy_03(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAbstractCellLinks_GetActualMemorySize_04(HandleRef pThis);

	/// <summary>
	/// Return the memory in kibibytes (1024 bytes) consumed by this cell links array.
	/// Used to support streaming and reading/writing data. The value
	/// returned is guaranteed to be greater than or equal to the memory
	/// required to actually represent the data represented by this object.
	/// The information returned is valid only after the pipeline has
	/// been updated.
	/// </summary>
	public virtual uint GetActualMemorySize()
	{
		return vtkAbstractCellLinks_GetActualMemorySize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLinks_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractCellLinks_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLinks_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractCellLinks_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractCellLinks_GetSequentialProcessing_07(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the link building
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual bool GetSequentialProcessing()
	{
		return (vtkAbstractCellLinks_GetSequentialProcessing_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLinks_GetType_08(HandleRef pThis);

	/// <summary>
	/// Return the type of locator (see enum above).
	/// </summary>
	public int GetTypeWrapper()
	{
		return vtkAbstractCellLinks_GetType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLinks_Initialize_09(HandleRef pThis);

	/// <summary>
	/// Release memory and revert to empty state.
	/// </summary>
	public virtual void Initialize()
	{
		vtkAbstractCellLinks_Initialize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLinks_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractCellLinks_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLinks_IsTypeOf_11(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractCellLinks_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractCellLinks_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new vtkAbstractCellLinks NewInstance()
	{
		vtkAbstractCellLinks result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractCellLinks_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLinks_Reset_13(HandleRef pThis);

	/// <summary>
	/// Reset to a state of no entries without freeing the memory.
	/// </summary>
	public virtual void Reset()
	{
		vtkAbstractCellLinks_Reset_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractCellLinks_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static vtkAbstractCellLinks SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractCellLinks vtkAbstractCellLinks2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractCellLinks_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractCellLinks2 = (vtkAbstractCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractCellLinks2.Register(null);
			}
		}
		return vtkAbstractCellLinks2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLinks_SelectCells_15(HandleRef pThis, IntPtr minMaxDegree, IntPtr cellSelection);

	/// <summary>
	/// Select all cells with a point degree in the range [minDegree,maxDegree).
	/// The degree is the number of cells using a point. The selection is
	/// indicated through the provided unsigned char array, with a non-zero
	/// value indicates selection. The memory allocated for cellSelection must
	/// be the maximum cell id referenced in the links.
	/// </summary>
	public virtual void SelectCells(IntPtr minMaxDegree, IntPtr cellSelection)
	{
		vtkAbstractCellLinks_SelectCells_15(GetCppThis(), minMaxDegree, cellSelection);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLinks_SequentialProcessingOff_16(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the link building
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SequentialProcessingOff()
	{
		vtkAbstractCellLinks_SequentialProcessingOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLinks_SequentialProcessingOn_17(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the link building
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SequentialProcessingOn()
	{
		vtkAbstractCellLinks_SequentialProcessingOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLinks_SetSequentialProcessing_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the link building
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SetSequentialProcessing(bool _arg)
	{
		vtkAbstractCellLinks_SetSequentialProcessing_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLinks_Squeeze_19(HandleRef pThis);

	/// <summary>
	/// Reclaim any unused memory.
	/// </summary>
	public virtual void Squeeze()
	{
		vtkAbstractCellLinks_Squeeze_19(GetCppThis());
	}
}
