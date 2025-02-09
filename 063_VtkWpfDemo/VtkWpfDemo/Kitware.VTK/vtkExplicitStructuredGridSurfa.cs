using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExplicitStructuredGridSurfaceFilter
/// </summary>
/// <remarks>
///    Filter which creates a surface (polydata) from an explicit structured grid.
/// </remarks>
public class vtkExplicitStructuredGridSurfaceFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExplicitStructuredGridSurfaceFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExplicitStructuredGridSurfaceFilter()
	{
		MRClassNameKey = "class vtkExplicitStructuredGridSurfaceFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExplicitStructuredGridSurfaceFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExplicitStructuredGridSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExplicitStructuredGridSurfaceFilter New()
	{
		vtkExplicitStructuredGridSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGridSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExplicitStructuredGridSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExplicitStructuredGridSurfaceFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExplicitStructuredGridSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExplicitStructuredGridSurfaceFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExplicitStructuredGridSurfaceFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExplicitStructuredGridSurfaceFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExplicitStructuredGridSurfaceFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_GetOriginalCellIdsName_03(HandleRef pThis);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to NULL, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual string GetOriginalCellIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkExplicitStructuredGridSurfaceFilter_GetOriginalCellIdsName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_GetOriginalPointIdsName_04(HandleRef pThis);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to NULL, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual string GetOriginalPointIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkExplicitStructuredGridSurfaceFilter_GetOriginalPointIdsName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGridSurfaceFilter_GetPassThroughCellIds_05(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual int GetPassThroughCellIds()
	{
		return vtkExplicitStructuredGridSurfaceFilter_GetPassThroughCellIds_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGridSurfaceFilter_GetPassThroughPointIds_06(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual int GetPassThroughPointIds()
	{
		return vtkExplicitStructuredGridSurfaceFilter_GetPassThroughPointIds_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGridSurfaceFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExplicitStructuredGridSurfaceFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGridSurfaceFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExplicitStructuredGridSurfaceFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExplicitStructuredGridSurfaceFilter NewInstance()
	{
		vtkExplicitStructuredGridSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGridSurfaceFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExplicitStructuredGridSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridSurfaceFilter_PassThroughCellIdsOff_11(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOff()
	{
		vtkExplicitStructuredGridSurfaceFilter_PassThroughCellIdsOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridSurfaceFilter_PassThroughCellIdsOn_12(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOn()
	{
		vtkExplicitStructuredGridSurfaceFilter_PassThroughCellIdsOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridSurfaceFilter_PassThroughPointIdsOff_13(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughPointIdsOff()
	{
		vtkExplicitStructuredGridSurfaceFilter_PassThroughPointIdsOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridSurfaceFilter_PassThroughPointIdsOn_14(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughPointIdsOn()
	{
		vtkExplicitStructuredGridSurfaceFilter_PassThroughPointIdsOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGridSurfaceFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExplicitStructuredGridSurfaceFilter SafeDownCast(vtkObjectBase o)
	{
		vtkExplicitStructuredGridSurfaceFilter vtkExplicitStructuredGridSurfaceFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGridSurfaceFilter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExplicitStructuredGridSurfaceFilter2 = (vtkExplicitStructuredGridSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExplicitStructuredGridSurfaceFilter2.Register(null);
			}
		}
		return vtkExplicitStructuredGridSurfaceFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridSurfaceFilter_SetOriginalCellIdsName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to NULL, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual void SetOriginalCellIdsName(string _arg)
	{
		vtkExplicitStructuredGridSurfaceFilter_SetOriginalCellIdsName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridSurfaceFilter_SetOriginalPointIdsName_17(HandleRef pThis, string _arg);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to NULL, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual void SetOriginalPointIdsName(string _arg)
	{
		vtkExplicitStructuredGridSurfaceFilter_SetOriginalPointIdsName_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridSurfaceFilter_SetPassThroughCellIds_18(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void SetPassThroughCellIds(int _arg)
	{
		vtkExplicitStructuredGridSurfaceFilter_SetPassThroughCellIds_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGridSurfaceFilter_SetPassThroughPointIds_19(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void SetPassThroughPointIds(int _arg)
	{
		vtkExplicitStructuredGridSurfaceFilter_SetPassThroughPointIds_19(GetCppThis(), _arg);
	}
}
