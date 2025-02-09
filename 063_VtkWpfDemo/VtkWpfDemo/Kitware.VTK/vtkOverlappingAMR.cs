using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOverlappingAMR
/// </summary>
/// <remarks>
///    hierarchical dataset of vtkUniformGrids
///
///
/// vtkOverlappingAMR extends vtkUniformGridAMR by exposing access to the
/// amr meta data, which stores all structural information represented
/// by an vtkAMRInformation object
///
/// </remarks>
/// <seealso>
///
/// vtkAMRInformation
/// </seealso>
public class vtkOverlappingAMR : vtkUniformGridAMR
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOverlappingAMR";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOverlappingAMR()
	{
		MRClassNameKey = "class vtkOverlappingAMR";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverlappingAMR"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOverlappingAMR(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOverlappingAMR New()
	{
		vtkOverlappingAMR result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMR_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOverlappingAMR()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOverlappingAMR_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOverlappingAMR_Audit_01(HandleRef pThis);

	/// <summary>
	/// Check whether the data set is internally consistent, e.g.
	/// whether the meta data and actual data blocks match.
	/// Incorrectness will be reported as error messages
	/// </summary>
	public void Audit()
	{
		vtkOverlappingAMR_Audit_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOverlappingAMR_FindGrid_02(HandleRef pThis, IntPtr q, ref uint level, ref uint gridId);

	/// <summary>
	/// Given a point q, find the highest level grid that contains it.
	/// </summary>
	public bool FindGrid(IntPtr q, ref uint level, ref uint gridId)
	{
		return (vtkOverlappingAMR_FindGrid_02(GetCppThis(), q, ref level, ref gridId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_GenerateParentChildInformation_03(HandleRef pThis);

	/// <summary>
	/// Generate the parent/child relationships - needed to be called
	/// before GetParents or GetChildren can be used!
	/// </summary>
	public void GenerateParentChildInformation()
	{
		vtkOverlappingAMR_GenerateParentChildInformation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOverlappingAMR_GetAMRBlockSourceIndex_04(HandleRef pThis, uint level, uint id);

	/// <summary>
	/// Set/Get the source id of a block. The source id is produced by an
	/// AMR source, e.g. a file reader might set this to be a file block id
	/// </summary>
	public int GetAMRBlockSourceIndex(uint level, uint id)
	{
		return vtkOverlappingAMR_GetAMRBlockSourceIndex_04(GetCppThis(), level, id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_GetAMRInfo_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the internal representation of amr meta meta data
	/// </summary>
	public virtual vtkAMRInformation GetAMRInfo()
	{
		vtkAMRInformation vtkAMRInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMR_GetAMRInfo_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRInformation2 = (vtkAMRInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRInformation2.Register(null);
			}
		}
		return vtkAMRInformation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_GetBounds_06(HandleRef pThis, uint level, uint id, IntPtr bb);

	/// <summary>
	/// Returns the bounding information of a data set.
	/// </summary>
	public void GetBounds(uint level, uint id, IntPtr bb)
	{
		vtkOverlappingAMR_GetBounds_06(GetCppThis(), level, id, bb);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_GetBounds_07(HandleRef pThis, IntPtr b);

	/// <summary>
	/// Prints the parents and children of a requested block (Debug Routine)
	/// </summary>
	public new void GetBounds(IntPtr b)
	{
		vtkOverlappingAMR_GetBounds_07(GetCppThis(), b);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_GetChildren_08(HandleRef pThis, uint level, uint index, ref uint numChildren);

	/// <summary>
	/// Return a pointer to Children of a block.  The first entry is the number
	/// of children the block has followed by its children ids in level+1.
	/// If none exits it returns nullptr.
	/// </summary>
	public IntPtr GetChildren(uint level, uint index, ref uint numChildren)
	{
		return vtkOverlappingAMR_GetChildren_08(GetCppThis(), level, index, ref numChildren);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_GetData_09(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkOverlappingAMR GetData(vtkInformation info)
	{
		vtkOverlappingAMR vtkOverlappingAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMR_GetData_09(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOverlappingAMR2 = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOverlappingAMR2.Register(null);
			}
		}
		return vtkOverlappingAMR2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_GetData_10(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkOverlappingAMR GetData(vtkInformationVector v, int i)
	{
		vtkOverlappingAMR vtkOverlappingAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMR_GetData_10(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOverlappingAMR2 = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOverlappingAMR2.Register(null);
			}
		}
		return vtkOverlappingAMR2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOverlappingAMR_GetDataObjectType_11(HandleRef pThis);

	/// <summary>
	/// Return class name of data type (see vtkType.h for definitions).
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkOverlappingAMR_GetDataObjectType_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOverlappingAMR_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Return class name of data type (see vtkType.h for definitions).
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOverlappingAMR_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOverlappingAMR_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Return class name of data type (see vtkType.h for definitions).
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOverlappingAMR_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_GetOrigin_14(HandleRef pThis);

	/// <summary>
	/// Get/Set the global origin of the amr data set
	/// </summary>
	public IntPtr GetOrigin()
	{
		return vtkOverlappingAMR_GetOrigin_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_GetOrigin_15(HandleRef pThis, uint level, uint id, IntPtr origin);

	/// <summary>
	/// Returns the origin of an AMR block
	/// </summary>
	public void GetOrigin(uint level, uint id, IntPtr origin)
	{
		vtkOverlappingAMR_GetOrigin_15(GetCppThis(), level, id, origin);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_GetParents_16(HandleRef pThis, uint level, uint index, ref uint numParents);

	/// <summary>
	/// Return a pointer to Parents of a block.  The first entry is the number
	/// of parents the block has followed by its parent ids in level-1.
	/// If none exits it returns nullptr.
	/// </summary>
	public IntPtr GetParents(uint level, uint index, ref uint numParents)
	{
		return vtkOverlappingAMR_GetParents_16(GetCppThis(), level, index, ref numParents);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOverlappingAMR_GetRefinementRatio_17(HandleRef pThis, uint level);

	/// <summary>
	/// Returns the refinement of a given level.
	/// </summary>
	public int GetRefinementRatio(uint level)
	{
		return vtkOverlappingAMR_GetRefinementRatio_17(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOverlappingAMR_GetRefinementRatio_18(HandleRef pThis, HandleRef iter);

	/// <summary>
	/// Returns the refinement ratio for the position pointed by the iterator.
	/// </summary>
	public int GetRefinementRatio(vtkCompositeDataIterator iter)
	{
		return vtkOverlappingAMR_GetRefinementRatio_18(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_GetSpacing_19(HandleRef pThis, uint level, IntPtr spacing);

	/// <summary>
	/// Get/Set the grid spacing at a given level
	/// </summary>
	public void GetSpacing(uint level, IntPtr spacing)
	{
		vtkOverlappingAMR_GetSpacing_19(GetCppThis(), level, spacing);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOverlappingAMR_HasChildrenInformation_20(HandleRef pThis);

	/// <summary>
	/// Return whether parent child information has been generated
	/// </summary>
	public bool HasChildrenInformation()
	{
		return (vtkOverlappingAMR_HasChildrenInformation_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOverlappingAMR_IsA_21(HandleRef pThis, string type);

	/// <summary>
	/// Return class name of data type (see vtkType.h for definitions).
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOverlappingAMR_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOverlappingAMR_IsTypeOf_22(string type);

	/// <summary>
	/// Return class name of data type (see vtkType.h for definitions).
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOverlappingAMR_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_NUMBER_OF_BLANKED_POINTS_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the origin of an AMR block
	/// </summary>
	public static vtkInformationIdTypeKey NUMBER_OF_BLANKED_POINTS()
	{
		vtkInformationIdTypeKey vtkInformationIdTypeKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMR_NUMBER_OF_BLANKED_POINTS_23(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIdTypeKey2 = (vtkInformationIdTypeKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIdTypeKey2.Register(null);
			}
		}
		return vtkInformationIdTypeKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return class name of data type (see vtkType.h for definitions).
	/// </summary>
	public new vtkOverlappingAMR NewInstance()
	{
		vtkOverlappingAMR result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMR_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_NewIterator_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a new iterator (the iterator has to be deleted by the user).
	/// </summary>
	public override vtkCompositeDataIterator NewIterator()
	{
		vtkCompositeDataIterator vtkCompositeDataIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMR_NewIterator_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOverlappingAMR_PrintParentChildInfo_27(HandleRef pThis, uint level, uint index);

	/// <summary>
	/// Prints the parents and children of a requested block (Debug Routine)
	/// </summary>
	public void PrintParentChildInfo(uint level, uint index)
	{
		vtkOverlappingAMR_PrintParentChildInfo_27(GetCppThis(), level, index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOverlappingAMR_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return class name of data type (see vtkType.h for definitions).
	/// </summary>
	public new static vtkOverlappingAMR SafeDownCast(vtkObjectBase o)
	{
		vtkOverlappingAMR vtkOverlappingAMR2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOverlappingAMR_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOverlappingAMR2 = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOverlappingAMR2.Register(null);
			}
		}
		return vtkOverlappingAMR2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_SetAMRBlockSourceIndex_29(HandleRef pThis, uint level, uint id, int sourceId);

	/// <summary>
	/// Set/Get the source id of a block. The source id is produced by an
	/// AMR source, e.g. a file reader might set this to be a file block id
	/// </summary>
	public void SetAMRBlockSourceIndex(uint level, uint id, int sourceId)
	{
		vtkOverlappingAMR_SetAMRBlockSourceIndex_29(GetCppThis(), level, id, sourceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_SetAMRInfo_30(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get/Set the internal representation of amr meta meta data
	/// </summary>
	public virtual void SetAMRInfo(vtkAMRInformation info)
	{
		vtkOverlappingAMR_SetAMRInfo_30(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_SetOrigin_31(HandleRef pThis, IntPtr origin);

	/// <summary>
	/// Get/Set the global origin of the amr data set
	/// </summary>
	public void SetOrigin(IntPtr origin)
	{
		vtkOverlappingAMR_SetOrigin_31(GetCppThis(), origin);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_SetRefinementRatio_32(HandleRef pThis, uint level, int refRatio);

	/// <summary>
	/// Sets the refinement of a given level. The spacing at level
	/// level+1 is defined as spacing(level+1) = spacing(level)/refRatio(level).
	/// Note that currently, this is not enforced by this class however
	/// some algorithms might not function properly if the spacing in
	/// the blocks (vtkUniformGrid) does not match the one described
	/// by the refinement ratio.
	/// </summary>
	public void SetRefinementRatio(uint level, int refRatio)
	{
		vtkOverlappingAMR_SetRefinementRatio_32(GetCppThis(), level, refRatio);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOverlappingAMR_SetSpacing_33(HandleRef pThis, uint level, IntPtr spacing);

	/// <summary>
	/// Get/Set the grid spacing at a given level
	/// </summary>
	public void SetSpacing(uint level, IntPtr spacing)
	{
		vtkOverlappingAMR_SetSpacing_33(GetCppThis(), level, spacing);
	}
}
