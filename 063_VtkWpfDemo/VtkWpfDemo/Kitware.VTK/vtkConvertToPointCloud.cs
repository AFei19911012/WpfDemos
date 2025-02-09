using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConvertToPointCloud
/// </summary>
/// <remarks>
///    Convert any dataset to a point cloud
///
/// This class convert any input dataset into a polydata point cloud
/// containing the same points and point data and either no cells, a single poly vertex cell
/// or as many vertex cell as they are points.
///
/// </remarks>
public class vtkConvertToPointCloud : vtkPolyDataAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum CellGeneration
	{
		/// <summary>enum member</summary>
		NO_CELLS,
		/// <summary>enum member</summary>
		POLYVERTEX_CELL,
		/// <summary>enum member</summary>
		VERTEX_CELLS
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConvertToPointCloud";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConvertToPointCloud()
	{
		MRClassNameKey = "class vtkConvertToPointCloud";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertToPointCloud"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConvertToPointCloud(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertToPointCloud_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConvertToPointCloud New()
	{
		vtkConvertToPointCloud result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertToPointCloud_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvertToPointCloud)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkConvertToPointCloud()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConvertToPointCloud_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvertToPointCloud_GetCellGenerationMode_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the cell generation mode.
	/// Available modes are:
	/// - NO_CELLS:
	/// No cells are generated
	/// - POLYVERTEX_CELL:
	/// A single polyvertex cell is generated (default)
	/// - VERTEX_CELLS:
	/// One vertex cell by point, not efficient to generate
	/// </summary>
	public virtual int GetCellGenerationMode()
	{
		return vtkConvertToPointCloud_GetCellGenerationMode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConvertToPointCloud_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConvertToPointCloud_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConvertToPointCloud_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConvertToPointCloud_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvertToPointCloud_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConvertToPointCloud_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvertToPointCloud_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConvertToPointCloud_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertToPointCloud_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkConvertToPointCloud NewInstance()
	{
		vtkConvertToPointCloud result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertToPointCloud_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvertToPointCloud)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvertToPointCloud_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConvertToPointCloud SafeDownCast(vtkObjectBase o)
	{
		vtkConvertToPointCloud vtkConvertToPointCloud2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvertToPointCloud_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConvertToPointCloud2 = (vtkConvertToPointCloud)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConvertToPointCloud2.Register(null);
			}
		}
		return vtkConvertToPointCloud2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvertToPointCloud_SetCellGenerationMode_09(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the cell generation mode.
	/// Available modes are:
	/// - NO_CELLS:
	/// No cells are generated
	/// - POLYVERTEX_CELL:
	/// A single polyvertex cell is generated (default)
	/// - VERTEX_CELLS:
	/// One vertex cell by point, not efficient to generate
	/// </summary>
	public virtual void SetCellGenerationMode(int _arg)
	{
		vtkConvertToPointCloud_SetCellGenerationMode_09(GetCppThis(), _arg);
	}
}
