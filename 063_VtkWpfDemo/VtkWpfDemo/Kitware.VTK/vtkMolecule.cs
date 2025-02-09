using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMolecule
/// </summary>
/// <remarks>
///    class describing a molecule
///
///
///
/// vtkMolecule and the convenience classes vtkAtom and vtkBond
/// describe the geometry and connectivity of a molecule. The molecule
/// can be constructed using the AppendAtom() and AppendBond() methods in one
/// of two ways; either by fully specifying the atom/bond in a single
/// call, or by incrementally setting the various attributes using the
/// convenience vtkAtom and vtkBond classes:
///
/// Single call:
/// <code>
/// vtkMolecule *mol = vtkMolecule::New();
/// vtkAtom h1 = mol-&gt;AppendAtom(1, 0.0, 0.0, -0.5);
/// vtkAtom h2 = mol-&gt;AppendAtom(1, 0.0, 0.0,  0.5);
/// vtkBond b  = mol-&gt;AppendBond(h1, h2, 1);
/// </code>
///
/// Incremental:
/// <code>
/// vtkMolecule *mol = vtkMolecule::New();
///
/// vtkAtom h1 = mol-&gt;AppendAtom();
/// h1.SetAtomicNumber(1);
/// h1.SetPosition(0.0, 0.0, -0.5);
///
/// vtkAtom h2 = mol-&gt;AppendAtom();
/// h2.SetAtomicNumber(1);
/// vtkVector3d displacement (0.0, 0.0, 1.0);
/// h2.SetPosition(h1.GetPositionAsVector3d() + displacement);
///
/// vtkBond b  = mol-&gt;AppendBond(h1, h2, 1);
/// </code>
///
/// Both of the above methods will produce the same molecule, two
/// hydrogens connected with a 1.0 Angstrom single bond, aligned to the
/// z-axis. The second example also demonstrates the use of VTK's
/// vtkVector class, which is fully supported by the Chemistry kit.
///
/// The vtkMolecule object is intended to be used with the
/// vtkMoleculeMapper class for visualizing molecular structure using
/// common rendering techniques.
///
/// \warning While direct use of the underlying vtkUndirectedGraph
/// structure is possible due to vtkMolecule's public inheritance, this
/// should not be relied upon and may change in the future.
///
/// </remarks>
/// <seealso>
///
/// vtkAtom vtkBond vtkMoleculeMapper vtkPeriodicTable
/// </seealso>
public class vtkMolecule : vtkUndirectedGraph
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMolecule";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMolecule()
	{
		MRClassNameKey = "class vtkMolecule";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMolecule"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMolecule(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMolecule New()
	{
		vtkMolecule result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMolecule()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMolecule_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkMolecule_AllocateAtomGhostArray_01(HandleRef pThis);

	/// <summary>
	/// Allocate ghost array for atoms.
	/// </summary>
	public void AllocateAtomGhostArray()
	{
		vtkMolecule_AllocateAtomGhostArray_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_AllocateBondGhostArray_02(HandleRef pThis);

	/// <summary>
	/// Allocate ghost array for bonds.
	/// </summary>
	public void AllocateBondGhostArray()
	{
		vtkMolecule_AllocateBondGhostArray_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMolecule_CheckedDeepCopy_03(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Performs the same operation as DeepCopy(),
	/// but instead of reporting an error for an incompatible graph,
	/// returns false.
	/// </summary>
	public override bool CheckedDeepCopy(vtkGraph g)
	{
		return (vtkMolecule_CheckedDeepCopy_03(GetCppThis(), g?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMolecule_CheckedShallowCopy_04(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Performs the same operation as ShallowCopy(),
	/// but instead of reporting an error for an incompatible graph,
	/// returns false.
	/// </summary>
	public override bool CheckedShallowCopy(vtkGraph g)
	{
		return (vtkMolecule_CheckedShallowCopy_04(GetCppThis(), g?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_ClearLattice_05(HandleRef pThis);

	/// <summary>
	/// Remove any unit cell lattice information from the molecule.
	/// </summary>
	public void ClearLattice()
	{
		vtkMolecule_ClearLattice_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_DeepCopy_06(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// Deep copies the data object into this molecule.
	/// </summary>
	public override void DeepCopy(vtkDataObject obj)
	{
		vtkMolecule_DeepCopy_06(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_DeepCopyAttributes_07(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Deep copies attributes (i.e. everything besides atoms and bonds) from
	/// @a m into @a this.
	/// </summary>
	public virtual void DeepCopyAttributes(vtkMolecule m)
	{
		vtkMolecule_DeepCopyAttributes_07(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_DeepCopyStructure_08(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Deep copies the atoms and bonds from @a m into @a this.
	/// </summary>
	public virtual void DeepCopyStructure(vtkMolecule m)
	{
		vtkMolecule_DeepCopyStructure_08(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkMolecule_GetActualMemorySize_09(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kibibytes (1024 bytes). This number
	/// is valid only after the pipeline has updated. The memory size
	/// returned is guaranteed to be greater than or equal to the
	/// memory required to represent the data (e.g., extra space in
	/// arrays, etc. are not included in the return value).
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkMolecule_GetActualMemorySize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkMolecule_GetAtomAtomicNumber_10(HandleRef pThis, long atomId);

	/// <summary>
	/// Return the atomic number of the atom with the specified id.
	/// </summary>
	public ushort GetAtomAtomicNumber(long atomId)
	{
		return vtkMolecule_GetAtomAtomicNumber_10(GetCppThis(), atomId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetAtomData_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the VertexData of the underlying graph
	/// </summary>
	public vtkDataSetAttributes GetAtomData()
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetAtomData_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetAttributes2 = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetAttributes2.Register(null);
			}
		}
		return vtkDataSetAttributes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetAtomGhostArray_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the array that defines the ghost type of each atom.
	/// </summary>
	public vtkUnsignedCharArray GetAtomGhostArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetAtomGhostArray_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetAtomPosition_13(HandleRef pThis, long atomId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the position of the atom with the specified id.
	/// </summary>
	public vtkVector3f GetAtomPosition(long atomId)
	{
		vtkVector3f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetAtomPosition_13(GetCppThis(), atomId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector3f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_GetAtomPosition_14(HandleRef pThis, long atomId, IntPtr pos);

	/// <summary>
	/// Get the position of the atom with the specified id.
	/// </summary>
	public void GetAtomPosition(long atomId, IntPtr pos)
	{
		vtkMolecule_GetAtomPosition_14(GetCppThis(), atomId, pos);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetAtomicNumberArray_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the raw arrays used in this vtkMolecule instance
	/// </summary>
	public vtkUnsignedShortArray GetAtomicNumberArray()
	{
		vtkUnsignedShortArray vtkUnsignedShortArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetAtomicNumberArray_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedShortArray2 = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedShortArray2.Register(null);
			}
		}
		return vtkUnsignedShortArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetAtomicNumberArrayName_16(HandleRef pThis);

	/// <summary>
	/// Get/Set the atomic number array name.
	/// </summary>
	public virtual string GetAtomicNumberArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMolecule_GetAtomicNumberArrayName_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetAtomicPositionArray_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the raw arrays used in this vtkMolecule instance
	/// </summary>
	public vtkPoints GetAtomicPositionArray()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetAtomicPositionArray_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetBondData_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the EdgeData of the underlying graph
	/// </summary>
	public vtkDataSetAttributes GetBondData()
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetBondData_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetAttributes2 = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetAttributes2.Register(null);
			}
		}
		return vtkDataSetAttributes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetBondGhostArray_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the array that defines the ghost type of each bond.
	/// </summary>
	public vtkUnsignedCharArray GetBondGhostArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetBondGhostArray_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMolecule_GetBondId_20(HandleRef pThis, long a, long b);

	/// <summary>
	/// Return the edge id from the underlying graph.
	/// </summary>
	public long GetBondId(long a, long b)
	{
		return vtkMolecule_GetBondId_20(GetCppThis(), a, b);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMolecule_GetBondLength_21(HandleRef pThis, long bondId);

	/// <summary>
	/// Get the bond length of the bond with the specified id
	///
	/// \note If the associated vtkBond object is already available,
	/// vtkBond::GetBondLength is potentially much faster than this
	/// function, as a list of all bonds may need to be constructed to
	/// locate the appropriate bond.
	/// \sa UpdateBondList()
	/// </summary>
	public double GetBondLength(long bondId)
	{
		return vtkMolecule_GetBondLength_21(GetCppThis(), bondId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkMolecule_GetBondOrder_22(HandleRef pThis, long bondId);

	/// <summary>
	/// Get/Set the bond order of the bond with the specified id
	/// </summary>
	public ushort GetBondOrder(long bondId)
	{
		return vtkMolecule_GetBondOrder_22(GetCppThis(), bondId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetBondOrdersArray_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the raw arrays used in this vtkMolecule instance
	/// </summary>
	public vtkUnsignedShortArray GetBondOrdersArray()
	{
		vtkUnsignedShortArray vtkUnsignedShortArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetBondOrdersArray_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedShortArray2 = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedShortArray2.Register(null);
			}
		}
		return vtkUnsignedShortArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetBondOrdersArrayName_24(HandleRef pThis);

	/// <summary>
	/// Get/Set the bond orders array name.
	/// </summary>
	public virtual string GetBondOrdersArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMolecule_GetBondOrdersArrayName_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetData_25(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a molecule from an information vector.
	/// </summary>
	public new static vtkMolecule GetData(vtkInformation info)
	{
		vtkMolecule vtkMolecule2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetData_25(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMolecule2 = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMolecule2.Register(null);
			}
		}
		return vtkMolecule2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetData_26(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a molecule from an information vector.
	/// </summary>
	public new static vtkMolecule GetData(vtkInformationVector v, int i)
	{
		vtkMolecule vtkMolecule2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetData_26(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMolecule2 = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMolecule2.Register(null);
			}
		}
		return vtkMolecule2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMolecule_GetDataObjectType_27(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkMolecule_GetDataObjectType_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetElectronicData_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the AbstractElectronicData-subclassed object for this molecule.
	/// </summary>
	public virtual vtkAbstractElectronicData GetElectronicData()
	{
		vtkAbstractElectronicData vtkAbstractElectronicData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetElectronicData_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractElectronicData2 = (vtkAbstractElectronicData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractElectronicData2.Register(null);
			}
		}
		return vtkAbstractElectronicData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetLattice_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the unit cell lattice vectors. The matrix is stored using a row-major
	/// layout, with the vectors encoded as columns. Will return nullptr if no
	/// unit cell information is available.
	/// @sa GetLatticeOrigin
	/// </summary>
	public vtkMatrix3x3 GetLattice()
	{
		vtkMatrix3x3 vtkMatrix3x4 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetLattice_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix3x4 = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix3x4.Register(null);
			}
		}
		return vtkMatrix3x4;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_GetLattice_30(HandleRef pThis, HandleRef a, HandleRef b, HandleRef c);

	/// <summary>
	/// Get the unit cell lattice vectors, and optionally, the origin.
	/// </summary>
	public void GetLattice(vtkVector3d a, vtkVector3d b, vtkVector3d c)
	{
		vtkMolecule_GetLattice_30(GetCppThis(), a?.GetCppThis() ?? default(HandleRef), b?.GetCppThis() ?? default(HandleRef), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_GetLattice_31(HandleRef pThis, HandleRef a, HandleRef b, HandleRef c, HandleRef origin);

	/// <summary>
	/// Get the unit cell lattice vectors, and optionally, the origin.
	/// </summary>
	public void GetLattice(vtkVector3d a, vtkVector3d b, vtkVector3d c, vtkVector3d origin)
	{
		vtkMolecule_GetLattice_31(GetCppThis(), a?.GetCppThis() ?? default(HandleRef), b?.GetCppThis() ?? default(HandleRef), c?.GetCppThis() ?? default(HandleRef), origin?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_GetLatticeOrigin_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the unit cell origin (for rendering purposes).
	/// </summary>
	public virtual vtkVector3d GetLatticeOrigin()
	{
		vtkVector3d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_GetLatticeOrigin_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMolecule_GetNumberOfAtoms_33(HandleRef pThis);

	/// <summary>
	/// Return the number of atoms in the molecule.
	/// </summary>
	public long GetNumberOfAtoms()
	{
		return vtkMolecule_GetNumberOfAtoms_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMolecule_GetNumberOfBonds_34(HandleRef pThis);

	/// <summary>
	/// Return the number of bonds in the molecule.
	/// </summary>
	public long GetNumberOfBonds()
	{
		return vtkMolecule_GetNumberOfBonds_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMolecule_GetNumberOfGenerationsFromBase_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMolecule_GetNumberOfGenerationsFromBase_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMolecule_GetNumberOfGenerationsFromBaseType_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMolecule_GetNumberOfGenerationsFromBaseType_36(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMolecule_HasLattice_37(HandleRef pThis);

	/// <summary>
	/// Return true if a unit cell lattice is defined.
	/// </summary>
	public bool HasLattice()
	{
		return (vtkMolecule_HasLattice_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_Initialize_38(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Initialize()
	{
		vtkMolecule_Initialize_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMolecule_Initialize_39(HandleRef pThis, HandleRef atomPositions, HandleRef atomicNumberArray, HandleRef atomData);

	/// <summary>
	/// Initialize a molecule with an atom per input point.
	/// Parameters atomPositions and atomicNumberArray should have the same size.
	/// </summary>
	public int Initialize(vtkPoints atomPositions, vtkDataArray atomicNumberArray, vtkDataSetAttributes atomData)
	{
		return vtkMolecule_Initialize_39(GetCppThis(), atomPositions?.GetCppThis() ?? default(HandleRef), atomicNumberArray?.GetCppThis() ?? default(HandleRef), atomData?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMolecule_Initialize_40(HandleRef pThis, HandleRef atomPositions, HandleRef atomData);

	/// <summary>
	/// Overloads Initialize method.
	/// </summary>
	public int Initialize(vtkPoints atomPositions, vtkDataSetAttributes atomData)
	{
		return vtkMolecule_Initialize_40(GetCppThis(), atomPositions?.GetCppThis() ?? default(HandleRef), atomData?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMolecule_Initialize_41(HandleRef pThis, HandleRef molecule);

	/// <summary>
	/// Use input molecule points, atomic number and atomic data to initialize the new molecule.
	/// </summary>
	public int Initialize(vtkMolecule molecule)
	{
		return vtkMolecule_Initialize_41(GetCppThis(), molecule?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMolecule_IsA_42(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMolecule_IsA_42(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMolecule_IsTypeOf_43(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMolecule_IsTypeOf_43(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_NewInstance_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMolecule NewInstance()
	{
		vtkMolecule result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_NewInstance_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMolecule_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMolecule SafeDownCast(vtkObjectBase o)
	{
		vtkMolecule vtkMolecule2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMolecule_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMolecule2 = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMolecule2.Register(null);
			}
		}
		return vtkMolecule2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetAtomAtomicNumber_47(HandleRef pThis, long atomId, ushort atomicNum);

	/// <summary>
	/// Set the atomic number of the atom with the specified id.
	/// </summary>
	public void SetAtomAtomicNumber(long atomId, ushort atomicNum)
	{
		vtkMolecule_SetAtomAtomicNumber_47(GetCppThis(), atomId, atomicNum);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetAtomPosition_48(HandleRef pThis, long atomId, HandleRef pos);

	/// <summary>
	/// Set the position of the atom with the specified id.
	/// </summary>
	public void SetAtomPosition(long atomId, vtkVector3f pos)
	{
		vtkMolecule_SetAtomPosition_48(GetCppThis(), atomId, pos?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetAtomPosition_49(HandleRef pThis, long atomId, double x, double y, double z);

	/// <summary>
	/// Set the position of the atom with the specified id.
	/// </summary>
	public void SetAtomPosition(long atomId, double x, double y, double z)
	{
		vtkMolecule_SetAtomPosition_49(GetCppThis(), atomId, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetAtomPosition_50(HandleRef pThis, long atomId, IntPtr pos);

	/// <summary>
	/// Set the position of the atom with the specified id.
	/// </summary>
	public void SetAtomPosition(long atomId, IntPtr pos)
	{
		vtkMolecule_SetAtomPosition_50(GetCppThis(), atomId, pos);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetAtomicNumberArrayName_51(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the atomic number array name.
	/// </summary>
	public virtual void SetAtomicNumberArrayName(string _arg)
	{
		vtkMolecule_SetAtomicNumberArrayName_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetBondOrder_52(HandleRef pThis, long bondId, ushort order);

	/// <summary>
	/// Get/Set the bond order of the bond with the specified id
	/// </summary>
	public void SetBondOrder(long bondId, ushort order)
	{
		vtkMolecule_SetBondOrder_52(GetCppThis(), bondId, order);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetBondOrdersArrayName_53(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the bond orders array name.
	/// </summary>
	public virtual void SetBondOrdersArrayName(string _arg)
	{
		vtkMolecule_SetBondOrdersArrayName_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetElectronicData_54(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the AbstractElectronicData-subclassed object for this molecule.
	/// </summary>
	public virtual void SetElectronicData(vtkAbstractElectronicData arg0)
	{
		vtkMolecule_SetElectronicData_54(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetLattice_55(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// The unit cell vectors. The matrix is stored using a row-major layout, with
	/// the vectors encoded as columns.
	/// </summary>
	public void SetLattice(vtkMatrix3x3 matrix)
	{
		vtkMolecule_SetLattice_55(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetLattice_56(HandleRef pThis, HandleRef a, HandleRef b, HandleRef c);

	/// <summary>
	/// The unit cell vectors. The matrix is stored using a row-major layout, with
	/// the vectors encoded as columns.
	/// </summary>
	public void SetLattice(vtkVector3d a, vtkVector3d b, vtkVector3d c)
	{
		vtkMolecule_SetLattice_56(GetCppThis(), a?.GetCppThis() ?? default(HandleRef), b?.GetCppThis() ?? default(HandleRef), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_SetLatticeOrigin_57(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Get the unit cell origin (for rendering purposes).
	/// </summary>
	public virtual void SetLatticeOrigin(vtkVector3d _arg)
	{
		vtkMolecule_SetLatticeOrigin_57(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_ShallowCopy_58(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// Shallow copies the data object into this molecule.
	/// </summary>
	public override void ShallowCopy(vtkDataObject obj)
	{
		vtkMolecule_ShallowCopy_58(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_ShallowCopyAttributes_59(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Shallow copies attributes (i.e. everything besides atoms and bonds) from
	/// @a m into @a this.
	/// </summary>
	public virtual void ShallowCopyAttributes(vtkMolecule m)
	{
		vtkMolecule_ShallowCopyAttributes_59(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMolecule_ShallowCopyStructure_60(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Shallow copies the atoms and bonds from @a m into @a this.
	/// </summary>
	public virtual void ShallowCopyStructure(vtkMolecule m)
	{
		vtkMolecule_ShallowCopyStructure_60(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}
}
