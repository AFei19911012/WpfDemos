using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPath
/// </summary>
/// <remarks>
///    concrete dataset representing a path defined by Bezier
/// curves.
///
/// vtkPath provides a container for paths composed of line segments,
/// 2nd-order (quadratic) and 3rd-order (cubic) Bezier curves.
/// </remarks>
public class vtkPath : vtkPointSet
{
	/// <summary>
	/// Enumeration of recognized control point types:
	/// - MOVE_TO: Point defining the origin of a new segment, not connected to
	/// the previous point.
	/// - LINE_TO: Draw a line from the previous point to the current one
	/// - CONIC_CURVE: 2nd order (conic/quadratic) point. Must appear
	/// in sets of 2, e.g. (0,0) MOVE_TO (0,1) CONIC_CURVE (1,2) CONIC_CURVE
	/// defines a quadratic Bezier curve that passes through (0,0) and (1,2)
	/// using (0,1) as a control (off) point.
	/// - CUBIC_CURVE: 3rd order (cubic) control point. Must appear in sets of
	/// 3, e.g. (0,0) MOVE_TO (0,1) CUBIC_CURVE (1,2) CUBIC_CURVE (4,0)
	/// CUBIC_CURVE defines a cubic Bezier curve that passes through (0,0)
	/// and (4,0), using (0,1) and (1,2) as control (off) points.
	/// </summary>
	public enum ControlPointType
	{
		/// <summary>enum member</summary>
		CONIC_CURVE = 2,
		/// <summary>enum member</summary>
		CUBIC_CURVE = 3,
		/// <summary>enum member</summary>
		LINE_TO = 1,
		/// <summary>enum member</summary>
		MOVE_TO = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPath";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPath()
	{
		MRClassNameKey = "class vtkPath";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPath"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPath New()
	{
		vtkPath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPath()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPath_Allocate_01(HandleRef pThis, long size, int extSize);

	/// <summary>
	/// Method allocates initial storage for points. Use this method before the
	/// method vtkPath::InsertNextPoint().
	/// </summary>
	public void Allocate(long size, int extSize)
	{
		vtkPath_Allocate_01(GetCppThis(), size, extSize);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPath_GetCell_02(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// vtkPath doesn't use cells. These methods return trivial values.
	/// </summary>
	public override vtkCell GetCell(long arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPath_GetCell_02(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPath_GetCell_03(HandleRef pThis, long arg0, HandleRef arg1);

	/// <summary>
	/// vtkPath doesn't use cells. These methods return trivial values.
	/// </summary>
	public override void GetCell(long arg0, vtkGenericCell arg1)
	{
		vtkPath_GetCell_03(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPath_GetCellPoints_04(HandleRef pThis, long arg0, HandleRef ptIds);

	/// <summary>
	/// vtkPath doesn't use cells, this method just clears ptIds.
	/// </summary>
	public override void GetCellPoints(long arg0, vtkIdList ptIds)
	{
		vtkPath_GetCellPoints_04(GetCppThis(), arg0, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPath_GetCellType_05(HandleRef pThis, long arg0);

	/// <summary>
	/// vtkPath doesn't use cells. These methods return trivial values.
	/// </summary>
	public override int GetCellType(long arg0)
	{
		return vtkPath_GetCellType_05(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPath_GetCodes_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the array of control point codes:
	/// </summary>
	public vtkIntArray GetCodes()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPath_GetCodes_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPath_GetData_07(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPath GetData(vtkInformation info)
	{
		vtkPath vtkPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPath_GetData_07(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPath2 = (vtkPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPath2.Register(null);
			}
		}
		return vtkPath2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPath_GetData_08(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPath GetData(vtkInformationVector v, int i)
	{
		vtkPath vtkPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPath_GetData_08(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPath2 = (vtkPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPath2.Register(null);
			}
		}
		return vtkPath2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPath_GetDataObjectType_09(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkPath_GetDataObjectType_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPath_GetMaxCellSize_10(HandleRef pThis);

	/// <summary>
	/// Return the maximum cell size in this poly data.
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkPath_GetMaxCellSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPath_GetNumberOfCells_11(HandleRef pThis);

	/// <summary>
	/// vtkPath doesn't use cells. These methods return trivial values.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkPath_GetNumberOfCells_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPath_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPath_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPath_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPath_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPath_GetPointCells_14(HandleRef pThis, long ptId, HandleRef cellIds);

	/// <summary>
	/// vtkPath doesn't use cells, this method just clears cellIds.
	/// </summary>
	public override void GetPointCells(long ptId, vtkIdList cellIds)
	{
		vtkPath_GetPointCells_14(GetCppThis(), ptId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPath_InsertNextPoint_15(HandleRef pThis, IntPtr pts, int code);

	/// <summary>
	/// Insert the next control point in the path.
	/// </summary>
	public void InsertNextPoint(IntPtr pts, int code)
	{
		vtkPath_InsertNextPoint_15(GetCppThis(), pts, code);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPath_InsertNextPoint_16(HandleRef pThis, double x, double y, double z, int code);

	/// <summary>
	/// Insert the next control point in the path.
	/// </summary>
	public void InsertNextPoint(double x, double y, double z, int code)
	{
		vtkPath_InsertNextPoint_16(GetCppThis(), x, y, z, code);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPath_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPath_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPath_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPath_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPath_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPath NewInstance()
	{
		vtkPath result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPath_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPath_Reset_21(HandleRef pThis);

	/// <summary>
	/// Begin inserting data all over again. Memory is not freed but otherwise
	/// objects are returned to their initial state.
	/// </summary>
	public void Reset()
	{
		vtkPath_Reset_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPath_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPath SafeDownCast(vtkObjectBase o)
	{
		vtkPath vtkPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPath_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPath2 = (vtkPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPath2.Register(null);
			}
		}
		return vtkPath2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPath_SetCodes_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the array of control point codes:
	/// </summary>
	public void SetCodes(vtkIntArray arg0)
	{
		vtkPath_SetCodes_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
