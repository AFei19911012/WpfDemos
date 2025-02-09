using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStripper
/// </summary>
/// <remarks>
///    create triangle strips and/or poly-lines
///
///
/// vtkStripper is a filter that generates triangle strips and/or poly-lines
/// from input polygons, triangle strips, and lines. Input polygons are
/// assembled into triangle strips only if they are triangles; other types of
/// polygons are passed through to the output and not stripped. (Use
/// vtkTriangleFilter to triangulate non-triangular polygons prior to running
/// this filter if you need to strip all the data.) The filter will pass
/// through (to the output) vertices if they are present in the input
/// polydata. Also note that if triangle strips or polylines are defined in
/// the input they are passed through and not joined nor extended. (If you wish
/// to strip these use vtkTriangleFilter to fragment the input into triangles
/// and lines prior to running vtkStripper.)
///
/// The ivar MaximumLength can be used to control the maximum
/// allowable triangle strip and poly-line length.
///
/// By default, this filter discards any cell data associated with the input.
/// Thus is because the cell structure changes and and the old cell data
/// is no longer valid. When PassCellDataAsFieldData flag is set,
/// the cell data is passed as FieldData to the output using the following rule:
/// 1) for every cell in the output that is not a triangle strip,
///    the cell data is inserted once per cell in the output field data.
/// 2) for every triangle strip cell in the output:
///    ii) 1 tuple is inserted for every point(j|j&gt;=2) in the strip.
///    This is the cell data for the cell formed by (j-2, j-1, j) in
///    the input.
/// The field data order is same as cell data i.e. (verts,line,polys,tsrips).
///
/// If there is a ghost cell array in the input, the ghost array is discarded.
/// Any cell tagged as ghost is skipped when stripping. Ghost points are kept.
///
/// @warning
/// If triangle strips or poly-lines exist in the input data they will
/// be passed through to the output data. This filter will only construct
/// triangle strips if triangle polygons are available; and will only
/// construct poly-lines if lines are available.
///
/// </remarks>
/// <seealso>
///
/// vtkTriangleFilter
/// </seealso>
public class vtkStripper : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStripper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStripper()
	{
		MRClassNameKey = "class vtkStripper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStripper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStripper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStripper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with MaximumLength set to 1000.
	/// </summary>
	public new static vtkStripper New()
	{
		vtkStripper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStripper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStripper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with MaximumLength set to 1000.
	/// </summary>
	public vtkStripper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStripper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkStripper_GetJoinContiguousSegments_01(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal segments will be joined if they are
	/// contiguous. This is useful after slicing a surface. The default
	/// is off.
	/// </summary>
	public virtual int GetJoinContiguousSegments()
	{
		return vtkStripper_GetJoinContiguousSegments_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStripper_GetMaximumLength_02(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of triangles in a triangle strip,
	/// and/or the maximum number of lines in a poly-line.
	/// </summary>
	public virtual int GetMaximumLength()
	{
		return vtkStripper_GetMaximumLength_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStripper_GetMaximumLengthMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of triangles in a triangle strip,
	/// and/or the maximum number of lines in a poly-line.
	/// </summary>
	public virtual int GetMaximumLengthMaxValue()
	{
		return vtkStripper_GetMaximumLengthMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStripper_GetMaximumLengthMinValue_04(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of triangles in a triangle strip,
	/// and/or the maximum number of lines in a poly-line.
	/// </summary>
	public virtual int GetMaximumLengthMinValue()
	{
		return vtkStripper_GetMaximumLengthMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStripper_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStripper_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStripper_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStripper_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStripper_GetPassCellDataAsFieldData_07(HandleRef pThis);

	/// <summary>
	/// Enable/Disable passing of the CellData in the input to
	/// the output as FieldData. Note the field data is transformed.
	/// </summary>
	public virtual int GetPassCellDataAsFieldData()
	{
		return vtkStripper_GetPassCellDataAsFieldData_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStripper_GetPassThroughCellIds_08(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual int GetPassThroughCellIds()
	{
		return vtkStripper_GetPassThroughCellIds_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStripper_GetPassThroughPointIds_09(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a pointdata array that
	/// holds the point index of the original vertex that produced each output
	/// vertex. This is useful for picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual int GetPassThroughPointIds()
	{
		return vtkStripper_GetPassThroughPointIds_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStripper_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStripper_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStripper_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStripper_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_JoinContiguousSegmentsOff_12(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal segments will be joined if they are
	/// contiguous. This is useful after slicing a surface. The default
	/// is off.
	/// </summary>
	public virtual void JoinContiguousSegmentsOff()
	{
		vtkStripper_JoinContiguousSegmentsOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_JoinContiguousSegmentsOn_13(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal segments will be joined if they are
	/// contiguous. This is useful after slicing a surface. The default
	/// is off.
	/// </summary>
	public virtual void JoinContiguousSegmentsOn()
	{
		vtkStripper_JoinContiguousSegmentsOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStripper_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStripper NewInstance()
	{
		vtkStripper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStripper_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStripper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_PassCellDataAsFieldDataOff_16(HandleRef pThis);

	/// <summary>
	/// Enable/Disable passing of the CellData in the input to
	/// the output as FieldData. Note the field data is transformed.
	/// </summary>
	public virtual void PassCellDataAsFieldDataOff()
	{
		vtkStripper_PassCellDataAsFieldDataOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_PassCellDataAsFieldDataOn_17(HandleRef pThis);

	/// <summary>
	/// Enable/Disable passing of the CellData in the input to
	/// the output as FieldData. Note the field data is transformed.
	/// </summary>
	public virtual void PassCellDataAsFieldDataOn()
	{
		vtkStripper_PassCellDataAsFieldDataOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_PassThroughCellIdsOff_18(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOff()
	{
		vtkStripper_PassThroughCellIdsOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_PassThroughCellIdsOn_19(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOn()
	{
		vtkStripper_PassThroughCellIdsOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_PassThroughPointIdsOff_20(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a pointdata array that
	/// holds the point index of the original vertex that produced each output
	/// vertex. This is useful for picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughPointIdsOff()
	{
		vtkStripper_PassThroughPointIdsOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_PassThroughPointIdsOn_21(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a pointdata array that
	/// holds the point index of the original vertex that produced each output
	/// vertex. This is useful for picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughPointIdsOn()
	{
		vtkStripper_PassThroughPointIdsOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStripper_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStripper SafeDownCast(vtkObjectBase o)
	{
		vtkStripper vtkStripper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStripper_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStripper2 = (vtkStripper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStripper2.Register(null);
			}
		}
		return vtkStripper2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_SetJoinContiguousSegments_23(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal segments will be joined if they are
	/// contiguous. This is useful after slicing a surface. The default
	/// is off.
	/// </summary>
	public virtual void SetJoinContiguousSegments(int _arg)
	{
		vtkStripper_SetJoinContiguousSegments_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_SetMaximumLength_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the maximum number of triangles in a triangle strip,
	/// and/or the maximum number of lines in a poly-line.
	/// </summary>
	public virtual void SetMaximumLength(int _arg)
	{
		vtkStripper_SetMaximumLength_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_SetPassCellDataAsFieldData_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable passing of the CellData in the input to
	/// the output as FieldData. Note the field data is transformed.
	/// </summary>
	public virtual void SetPassCellDataAsFieldData(int _arg)
	{
		vtkStripper_SetPassCellDataAsFieldData_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_SetPassThroughCellIds_26(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void SetPassThroughCellIds(int _arg)
	{
		vtkStripper_SetPassThroughCellIds_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStripper_SetPassThroughPointIds_27(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a pointdata array that
	/// holds the point index of the original vertex that produced each output
	/// vertex. This is useful for picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void SetPassThroughPointIds(int _arg)
	{
		vtkStripper_SetPassThroughPointIds_27(GetCppThis(), _arg);
	}
}
