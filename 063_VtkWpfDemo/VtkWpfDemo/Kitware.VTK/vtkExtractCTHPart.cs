using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractCTHPart
/// </summary>
/// <remarks>
///    Generates surface of a CTH volume fraction.
///
/// vtkExtractCTHPart is a filter that is specialized for creating
/// visualizations for a CTH simulation. CTH datasets comprise of either
/// vtkNonOverlappingAMR or a multiblock of non-overlapping rectilinear grids
/// with cell-data. Certain cell-arrays in the dataset identify the fraction of
/// a particular material present in a given cell. This goal with this filter is
/// to extract a surface contour demarcating the surface where the volume
/// fraction for a particular material is equal to the user chosen value.
///
/// To achieve that, this filter first converts the cell-data to point-data and
/// then simply apply vtkContourFilter filter to extract the contour.
///
/// vtkExtractCTHPart also provides the user with an option to clip the resultant
/// contour using a vtkPlane. Internally, it uses vtkClipClosedSurface to clip
/// the contour using the vtkPlane provided.
///
/// The output of this filter is a vtkMultiBlockDataSet with one block
/// corresponding to each volume-fraction array requested. Each block itself is a
/// vtkPolyData for the contour generated on the current process (which may be
/// null, for processes where no contour is generated).
/// </remarks>
public class vtkExtractCTHPart : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCTHPart";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractCTHPart()
	{
		MRClassNameKey = "class vtkExtractCTHPart";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCTHPart"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractCTHPart(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCTHPart_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractCTHPart New()
	{
		vtkExtractCTHPart result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCTHPart_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractCTHPart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractCTHPart()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractCTHPart_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_AddVolumeArrayName_01(HandleRef pThis, string arg0);

	/// <summary>
	/// Select cell-data arrays (volume-fraction arrays) to contour with.
	/// </summary>
	public void AddVolumeArrayName(string arg0)
	{
		vtkExtractCTHPart_AddVolumeArrayName_01(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_CappingOff_02(HandleRef pThis);

	/// <summary>
	/// On by default, enables logic to cap the material volume.
	/// </summary>
	public virtual void CappingOff()
	{
		vtkExtractCTHPart_CappingOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_CappingOn_03(HandleRef pThis);

	/// <summary>
	/// On by default, enables logic to cap the material volume.
	/// </summary>
	public virtual void CappingOn()
	{
		vtkExtractCTHPart_CappingOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_GenerateSolidGeometryOff_04(HandleRef pThis);

	/// <summary>
	/// Generate solid geometry as results instead of 2D contours.
	/// When set to true, GenerateTriangles flag will be ignored.
	/// False by default.
	/// </summary>
	public virtual void GenerateSolidGeometryOff()
	{
		vtkExtractCTHPart_GenerateSolidGeometryOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_GenerateSolidGeometryOn_05(HandleRef pThis);

	/// <summary>
	/// Generate solid geometry as results instead of 2D contours.
	/// When set to true, GenerateTriangles flag will be ignored.
	/// False by default.
	/// </summary>
	public virtual void GenerateSolidGeometryOn()
	{
		vtkExtractCTHPart_GenerateSolidGeometryOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_GenerateTrianglesOff_06(HandleRef pThis);

	/// <summary>
	/// Triangulate results. When set to false, the internal cut and contour filters
	/// are told not to triangulate results if possible. true by default.
	/// </summary>
	public virtual void GenerateTrianglesOff()
	{
		vtkExtractCTHPart_GenerateTrianglesOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_GenerateTrianglesOn_07(HandleRef pThis);

	/// <summary>
	/// Triangulate results. When set to false, the internal cut and contour filters
	/// are told not to triangulate results if possible. true by default.
	/// </summary>
	public virtual void GenerateTrianglesOn()
	{
		vtkExtractCTHPart_GenerateTrianglesOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractCTHPart_GetCapping_08(HandleRef pThis);

	/// <summary>
	/// On by default, enables logic to cap the material volume.
	/// </summary>
	public virtual bool GetCapping()
	{
		return (vtkExtractCTHPart_GetCapping_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCTHPart_GetClipPlane_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set, get or manipulate the implicit clipping plane.
	/// </summary>
	public virtual vtkPlane GetClipPlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCTHPart_GetClipPlane_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlane2 = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlane2.Register(null);
			}
		}
		return vtkPlane2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCTHPart_GetController_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the parallel controller. By default, the value returned by
	/// vtkMultiBlockDataSetAlgorithm::GetGlobalController() when the object is
	/// instantiated is used.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCTHPart_GetController_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractCTHPart_GetGenerateSolidGeometry_11(HandleRef pThis);

	/// <summary>
	/// Generate solid geometry as results instead of 2D contours.
	/// When set to true, GenerateTriangles flag will be ignored.
	/// False by default.
	/// </summary>
	public virtual bool GetGenerateSolidGeometry()
	{
		return (vtkExtractCTHPart_GetGenerateSolidGeometry_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractCTHPart_GetGenerateTriangles_12(HandleRef pThis);

	/// <summary>
	/// Triangulate results. When set to false, the internal cut and contour filters
	/// are told not to triangulate results if possible. true by default.
	/// </summary>
	public virtual bool GetGenerateTriangles()
	{
		return (vtkExtractCTHPart_GetGenerateTriangles_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkExtractCTHPart_GetMTime_13(HandleRef pThis);

	/// <summary>
	/// Look at clip plane to compute MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExtractCTHPart_GetMTime_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractCTHPart_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractCTHPart_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractCTHPart_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractCTHPart_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCTHPart_GetNumberOfVolumeArrayNames_16(HandleRef pThis);

	/// <summary>
	/// Select cell-data arrays (volume-fraction arrays) to contour with.
	/// </summary>
	public int GetNumberOfVolumeArrayNames()
	{
		return vtkExtractCTHPart_GetNumberOfVolumeArrayNames_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractCTHPart_GetRemoveGhostCells_17(HandleRef pThis);

	/// <summary>
	/// When set to false, the output surfaces will not hide contours extracted from
	/// ghost cells. This results in overlapping contours but overcomes holes.
	/// Default is set to true.
	/// </summary>
	public virtual bool GetRemoveGhostCells()
	{
		return (vtkExtractCTHPart_GetRemoveGhostCells_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCTHPart_GetVolumeArrayName_18(HandleRef pThis, int idx);

	/// <summary>
	/// Select cell-data arrays (volume-fraction arrays) to contour with.
	/// </summary>
	public string GetVolumeArrayName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkExtractCTHPart_GetVolumeArrayName_18(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractCTHPart_GetVolumeFractionSurfaceValue_19(HandleRef pThis);

	/// <summary>
	/// Set and get the volume fraction surface value. This value should be
	/// between 0 and 1
	/// </summary>
	public virtual double GetVolumeFractionSurfaceValue()
	{
		return vtkExtractCTHPart_GetVolumeFractionSurfaceValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractCTHPart_GetVolumeFractionSurfaceValueMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Set and get the volume fraction surface value. This value should be
	/// between 0 and 1
	/// </summary>
	public virtual double GetVolumeFractionSurfaceValueMaxValue()
	{
		return vtkExtractCTHPart_GetVolumeFractionSurfaceValueMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractCTHPart_GetVolumeFractionSurfaceValueMinValue_21(HandleRef pThis);

	/// <summary>
	/// Set and get the volume fraction surface value. This value should be
	/// between 0 and 1
	/// </summary>
	public virtual double GetVolumeFractionSurfaceValueMinValue()
	{
		return vtkExtractCTHPart_GetVolumeFractionSurfaceValueMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCTHPart_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractCTHPart_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCTHPart_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractCTHPart_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCTHPart_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractCTHPart NewInstance()
	{
		vtkExtractCTHPart result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCTHPart_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractCTHPart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_RemoveGhostCellsOff_26(HandleRef pThis);

	/// <summary>
	/// When set to false, the output surfaces will not hide contours extracted from
	/// ghost cells. This results in overlapping contours but overcomes holes.
	/// Default is set to true.
	/// </summary>
	public virtual void RemoveGhostCellsOff()
	{
		vtkExtractCTHPart_RemoveGhostCellsOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_RemoveGhostCellsOn_27(HandleRef pThis);

	/// <summary>
	/// When set to false, the output surfaces will not hide contours extracted from
	/// ghost cells. This results in overlapping contours but overcomes holes.
	/// Default is set to true.
	/// </summary>
	public virtual void RemoveGhostCellsOn()
	{
		vtkExtractCTHPart_RemoveGhostCellsOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_RemoveVolumeArrayNames_28(HandleRef pThis);

	/// <summary>
	/// Select cell-data arrays (volume-fraction arrays) to contour with.
	/// </summary>
	public void RemoveVolumeArrayNames()
	{
		vtkExtractCTHPart_RemoveVolumeArrayNames_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCTHPart_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractCTHPart SafeDownCast(vtkObjectBase o)
	{
		vtkExtractCTHPart vtkExtractCTHPart2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCTHPart_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractCTHPart2 = (vtkExtractCTHPart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractCTHPart2.Register(null);
			}
		}
		return vtkExtractCTHPart2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_SetCapping_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// On by default, enables logic to cap the material volume.
	/// </summary>
	public virtual void SetCapping(bool _arg)
	{
		vtkExtractCTHPart_SetCapping_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_SetClipPlane_31(HandleRef pThis, HandleRef clipPlane);

	/// <summary>
	/// Set, get or manipulate the implicit clipping plane.
	/// </summary>
	public void SetClipPlane(vtkPlane clipPlane)
	{
		vtkExtractCTHPart_SetClipPlane_31(GetCppThis(), clipPlane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_SetController_32(HandleRef pThis, HandleRef controller);

	/// <summary>
	/// Get/Set the parallel controller. By default, the value returned by
	/// vtkMultiBlockDataSetAlgorithm::GetGlobalController() when the object is
	/// instantiated is used.
	/// </summary>
	public void SetController(vtkMultiProcessController controller)
	{
		vtkExtractCTHPart_SetController_32(GetCppThis(), controller?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_SetGenerateSolidGeometry_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Generate solid geometry as results instead of 2D contours.
	/// When set to true, GenerateTriangles flag will be ignored.
	/// False by default.
	/// </summary>
	public virtual void SetGenerateSolidGeometry(bool _arg)
	{
		vtkExtractCTHPart_SetGenerateSolidGeometry_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_SetGenerateTriangles_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Triangulate results. When set to false, the internal cut and contour filters
	/// are told not to triangulate results if possible. true by default.
	/// </summary>
	public virtual void SetGenerateTriangles(bool _arg)
	{
		vtkExtractCTHPart_SetGenerateTriangles_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_SetRemoveGhostCells_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to false, the output surfaces will not hide contours extracted from
	/// ghost cells. This results in overlapping contours but overcomes holes.
	/// Default is set to true.
	/// </summary>
	public virtual void SetRemoveGhostCells(bool _arg)
	{
		vtkExtractCTHPart_SetRemoveGhostCells_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCTHPart_SetVolumeFractionSurfaceValue_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Set and get the volume fraction surface value. This value should be
	/// between 0 and 1
	/// </summary>
	public virtual void SetVolumeFractionSurfaceValue(double _arg)
	{
		vtkExtractCTHPart_SetVolumeFractionSurfaceValue_36(GetCppThis(), _arg);
	}
}
