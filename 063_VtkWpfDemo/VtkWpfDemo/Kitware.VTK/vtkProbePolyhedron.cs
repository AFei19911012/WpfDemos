using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProbePolyhedron
/// </summary>
/// <remarks>
///    probe/interpolate data values in the interior,
/// exterior or of the surface of a closed, manifold polyhedron
///
/// vtkProbePolyhedron is a filter that computes point attributes (e.g.,
/// scalars, vectors, etc.) at specified point positions. The filter has two
/// inputs: the Input and Source. The Source geometric structure is passed
/// through the filter. The point attributes are computed at the Input point
/// positions by interpolating into the source data. In this filter, the
/// Source is always a closed, non-self-intersecting, polyhedral mesh. For
/// example, we can compute data values on a plane (plane specified as Input)
/// from a triangle mesh (e.g., output of marching cubes).
///
/// This filter can be used to resample data from a mesh onto a different
/// dataset type. For example, a polyhedral mesh (vtkPolyData) can be probed
/// with a volume (three-dimensional vtkImageData), and then volume rendering
/// techniques can be used to visualize the results. Another example: a line
/// or curve can be used to probe a mesh to produce x-y plots along that line or
/// curve.
///
/// @warning
/// Note that cell data is not interpolated from the source. If you need cell data,
/// you can always use vtkPointDataToCellData and/or vtkCellDataToPointData in
/// various combinations.
///
/// @warning
/// Note that the filter interpolates from a mesh to points interior, exterior
/// or on the surface of the mesh. This process is necessarily an
/// approximation. Currently the approach of Mean Value Coordinates is used,
/// but this filter may be extended in the future to use other methods.
///
///
/// </remarks>
/// <seealso>
///
/// vtkProbeFilter vtkMeanValueCoordinatesInterpolator vtkPolyhedron
/// </seealso>
public class vtkProbePolyhedron : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProbePolyhedron";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProbePolyhedron()
	{
		MRClassNameKey = "class vtkProbePolyhedron";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProbePolyhedron"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProbePolyhedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbePolyhedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new static vtkProbePolyhedron New()
	{
		vtkProbePolyhedron result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbePolyhedron_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProbePolyhedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public vtkProbePolyhedron()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProbePolyhedron_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkProbePolyhedron_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProbePolyhedron_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProbePolyhedron_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProbePolyhedron_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbePolyhedron_GetProbeCellData_03(HandleRef pThis);

	/// <summary>
	/// Specify whether to probe (and hence produce) cell data. The
	/// interpolated point data of the source will produce the output
	/// cell data (output cells are passed from the input cells). Note
	/// that the probing of the input uses the centers of the cells as
	/// the probe position.
	/// </summary>
	public virtual int GetProbeCellData()
	{
		return vtkProbePolyhedron_GetProbeCellData_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbePolyhedron_GetProbePointData_04(HandleRef pThis);

	/// <summary>
	/// Specify whether to probe (and hence produce) point data. The
	/// interpolated point data of the source will produce the output
	/// point data (output points are passed from the input points).
	/// </summary>
	public virtual int GetProbePointData()
	{
		return vtkProbePolyhedron_GetProbePointData_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbePolyhedron_GetSource_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the point locations used to probe input. Any geometry
	/// can be used.
	/// </summary>
	public vtkPolyData GetSource()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbePolyhedron_GetSource_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkProbePolyhedron_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProbePolyhedron_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbePolyhedron_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProbePolyhedron_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbePolyhedron_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new vtkProbePolyhedron NewInstance()
	{
		vtkProbePolyhedron result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbePolyhedron_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProbePolyhedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbePolyhedron_ProbeCellDataOff_10(HandleRef pThis);

	/// <summary>
	/// Specify whether to probe (and hence produce) cell data. The
	/// interpolated point data of the source will produce the output
	/// cell data (output cells are passed from the input cells). Note
	/// that the probing of the input uses the centers of the cells as
	/// the probe position.
	/// </summary>
	public virtual void ProbeCellDataOff()
	{
		vtkProbePolyhedron_ProbeCellDataOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbePolyhedron_ProbeCellDataOn_11(HandleRef pThis);

	/// <summary>
	/// Specify whether to probe (and hence produce) cell data. The
	/// interpolated point data of the source will produce the output
	/// cell data (output cells are passed from the input cells). Note
	/// that the probing of the input uses the centers of the cells as
	/// the probe position.
	/// </summary>
	public virtual void ProbeCellDataOn()
	{
		vtkProbePolyhedron_ProbeCellDataOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbePolyhedron_ProbePointDataOff_12(HandleRef pThis);

	/// <summary>
	/// Specify whether to probe (and hence produce) point data. The
	/// interpolated point data of the source will produce the output
	/// point data (output points are passed from the input points).
	/// </summary>
	public virtual void ProbePointDataOff()
	{
		vtkProbePolyhedron_ProbePointDataOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbePolyhedron_ProbePointDataOn_13(HandleRef pThis);

	/// <summary>
	/// Specify whether to probe (and hence produce) point data. The
	/// interpolated point data of the source will produce the output
	/// point data (output points are passed from the input points).
	/// </summary>
	public virtual void ProbePointDataOn()
	{
		vtkProbePolyhedron_ProbePointDataOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbePolyhedron_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiable (i.e., concrete) class.
	/// </summary>
	public new static vtkProbePolyhedron SafeDownCast(vtkObjectBase o)
	{
		vtkProbePolyhedron vtkProbePolyhedron2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbePolyhedron_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProbePolyhedron2 = (vtkProbePolyhedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProbePolyhedron2.Register(null);
			}
		}
		return vtkProbePolyhedron2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbePolyhedron_SetProbeCellData_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to probe (and hence produce) cell data. The
	/// interpolated point data of the source will produce the output
	/// cell data (output cells are passed from the input cells). Note
	/// that the probing of the input uses the centers of the cells as
	/// the probe position.
	/// </summary>
	public virtual void SetProbeCellData(int _arg)
	{
		vtkProbePolyhedron_SetProbeCellData_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbePolyhedron_SetProbePointData_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to probe (and hence produce) point data. The
	/// interpolated point data of the source will produce the output
	/// point data (output points are passed from the input points).
	/// </summary>
	public virtual void SetProbePointData(int _arg)
	{
		vtkProbePolyhedron_SetProbePointData_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbePolyhedron_SetSourceConnection_17(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the point locations used to probe input. Any geometry
	/// can be used. New style. Equivalent to SetInputConnection(1, algOutput).
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkProbePolyhedron_SetSourceConnection_17(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProbePolyhedron_SetSourceData_18(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the point locations used to probe input. Any geometry
	/// can be used.
	/// </summary>
	public void SetSourceData(vtkPolyData source)
	{
		vtkProbePolyhedron_SetSourceData_18(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}
}
