using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRemovePolyData
/// </summary>
/// <remarks>
///    Removes vtkPolyData cells from an input vtkPolyData
///
/// vtkRemovePolyData is a filter that removes cells from an input vtkPolyData
/// (defined in the first input #0), and produces an output vtkPolyData (which
/// may be empty).  The cells to remove are specified in the following ways:
/// 1) a list of cell ids can be provided; 2) a list of point ids can be
/// provided - any cell using one or more of the points indicated is removed;
/// and 3) one or more additional vtkPolyData inputs can be provided -
/// matching cells are deleted. These three methods can be used in combination
/// if desired. Point and cell attribute data associated with the remaining
/// cells are copied to the output.
///
/// @warning
/// The filter vtkAppendPolyData enables appending multiple input
/// vtkPolyData's together. So vtkAppendPolyData functions as an
/// approximate inverse operation to vtkRemovePolyData.
///
/// @warning
/// The output point type is the same as the (first) input point type.
///
/// </remarks>
/// <seealso>
///
/// vtkAppendPolyData
/// </seealso>
public class vtkRemovePolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRemovePolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRemovePolyData()
	{
		MRClassNameKey = "class vtkRemovePolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemovePolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRemovePolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemovePolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, obtain information, and print information.
	///
	/// </summary>
	public new static vtkRemovePolyData New()
	{
		vtkRemovePolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemovePolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRemovePolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods to instantiate, obtain information, and print information.
	///
	/// </summary>
	public vtkRemovePolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRemovePolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRemovePolyData_ExactMatchOff_01(HandleRef pThis);

	/// <summary>
	/// ExactMatch controls how the matching of cells when additional input
	/// vtkPolyDatas are provided. When ExactMatch is enabled, then if any
	/// input0 cell Ci uses all of the point ids in cells specified in inputs
	/// [1,N) Cn, and the number of point ids in Ci == Cn, then a match occurs
	/// and the cell is marked for deletion. Without ExactMatch enabled, if Ci
	/// uses all of the points in Cn, even though the cell connectivity list
	/// sizes are not the same size, a match occurs. This can be used to perform
	/// tricks like marking all of the cells that use a point or edge to be
	/// deleted. ExactMatch is disabled by default since it takes a extra
	/// computation time.
	/// </summary>
	public virtual void ExactMatchOff()
	{
		vtkRemovePolyData_ExactMatchOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRemovePolyData_ExactMatchOn_02(HandleRef pThis);

	/// <summary>
	/// ExactMatch controls how the matching of cells when additional input
	/// vtkPolyDatas are provided. When ExactMatch is enabled, then if any
	/// input0 cell Ci uses all of the point ids in cells specified in inputs
	/// [1,N) Cn, and the number of point ids in Ci == Cn, then a match occurs
	/// and the cell is marked for deletion. Without ExactMatch enabled, if Ci
	/// uses all of the points in Cn, even though the cell connectivity list
	/// sizes are not the same size, a match occurs. This can be used to perform
	/// tricks like marking all of the cells that use a point or edge to be
	/// deleted. ExactMatch is disabled by default since it takes a extra
	/// computation time.
	/// </summary>
	public virtual void ExactMatchOn()
	{
		vtkRemovePolyData_ExactMatchOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemovePolyData_GetCellIds_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the list of cell ids to delete. These are cell ids of the input
	/// polydata - note that polydata with mixed cell types (e.g., verts, lines,
	/// polys, and/or strips), the cell ids begin with the vertex cells, then
	/// line cells, then polygonal cells, and finally triangle strips.
	/// </summary>
	public virtual vtkIdTypeArray GetCellIds()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemovePolyData_GetCellIds_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRemovePolyData_GetExactMatch_04(HandleRef pThis);

	/// <summary>
	/// ExactMatch controls how the matching of cells when additional input
	/// vtkPolyDatas are provided. When ExactMatch is enabled, then if any
	/// input0 cell Ci uses all of the point ids in cells specified in inputs
	/// [1,N) Cn, and the number of point ids in Ci == Cn, then a match occurs
	/// and the cell is marked for deletion. Without ExactMatch enabled, if Ci
	/// uses all of the points in Cn, even though the cell connectivity list
	/// sizes are not the same size, a match occurs. This can be used to perform
	/// tricks like marking all of the cells that use a point or edge to be
	/// deleted. ExactMatch is disabled by default since it takes a extra
	/// computation time.
	/// </summary>
	public virtual bool GetExactMatch()
	{
		return (vtkRemovePolyData_GetExactMatch_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemovePolyData_GetInput_05(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get any input of this filter.
	/// </summary>
	public new vtkPolyData GetInput(int idx)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemovePolyData_GetInput_05(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemovePolyData_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get any input of this filter.
	/// </summary>
	public new vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemovePolyData_GetInput_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRemovePolyData_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, obtain information, and print information.
	///
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRemovePolyData_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRemovePolyData_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods to instantiate, obtain information, and print information.
	///
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRemovePolyData_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemovePolyData_GetPointIds_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the list of points ids to delete. Any cells using any of the
	/// points listed are removed.
	/// </summary>
	public virtual vtkIdTypeArray GetPointIds()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemovePolyData_GetPointIds_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRemovePolyData_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, obtain information, and print information.
	///
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRemovePolyData_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRemovePolyData_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods to instantiate, obtain information, and print information.
	///
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRemovePolyData_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemovePolyData_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, obtain information, and print information.
	///
	/// </summary>
	public new vtkRemovePolyData NewInstance()
	{
		vtkRemovePolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemovePolyData_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRemovePolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRemovePolyData_RemoveInputData_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a vtkPolyData dataset from the list of data.
	/// </summary>
	public void RemoveInputData(vtkPolyData arg0)
	{
		vtkRemovePolyData_RemoveInputData_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRemovePolyData_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, obtain information, and print information.
	///
	/// </summary>
	public new static vtkRemovePolyData SafeDownCast(vtkObjectBase o)
	{
		vtkRemovePolyData vtkRemovePolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRemovePolyData_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRemovePolyData2 = (vtkRemovePolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRemovePolyData2.Register(null);
			}
		}
		return vtkRemovePolyData2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRemovePolyData_SetCellIds_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the list of cell ids to delete. These are cell ids of the input
	/// polydata - note that polydata with mixed cell types (e.g., verts, lines,
	/// polys, and/or strips), the cell ids begin with the vertex cells, then
	/// line cells, then polygonal cells, and finally triangle strips.
	/// </summary>
	public void SetCellIds(vtkIdTypeArray arg0)
	{
		vtkRemovePolyData_SetCellIds_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRemovePolyData_SetExactMatch_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// ExactMatch controls how the matching of cells when additional input
	/// vtkPolyDatas are provided. When ExactMatch is enabled, then if any
	/// input0 cell Ci uses all of the point ids in cells specified in inputs
	/// [1,N) Cn, and the number of point ids in Ci == Cn, then a match occurs
	/// and the cell is marked for deletion. Without ExactMatch enabled, if Ci
	/// uses all of the points in Cn, even though the cell connectivity list
	/// sizes are not the same size, a match occurs. This can be used to perform
	/// tricks like marking all of the cells that use a point or edge to be
	/// deleted. ExactMatch is disabled by default since it takes a extra
	/// computation time.
	/// </summary>
	public virtual void SetExactMatch(bool _arg)
	{
		vtkRemovePolyData_SetExactMatch_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRemovePolyData_SetPointIds_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the list of points ids to delete. Any cells using any of the
	/// points listed are removed.
	/// </summary>
	public void SetPointIds(vtkIdTypeArray arg0)
	{
		vtkRemovePolyData_SetPointIds_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
