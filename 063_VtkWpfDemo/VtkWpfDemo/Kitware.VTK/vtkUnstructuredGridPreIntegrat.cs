using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridPreIntegration
/// </summary>
/// <remarks>
///    performs ray integration with pre-integration tables.
///
///
///
/// vtkUnstructuredGridPreIntegration performs ray integration by looking
/// into a precomputed table.  The result should be equivalent to that
/// computed by vtkUnstructuredGridLinearRayIntegrator and
/// vtkUnstructuredGridPartialPreIntegration, but faster than either one.
/// The pre-integration algorithm was first introduced by Roettger, Kraus,
/// and Ertl in "Hardware-Accelerated Volume And Isosurface Rendering Based
/// On Cell-Projection."
///
/// Due to table size limitations, a table can only be indexed by
/// independent scalars.  Thus, dependent scalars are not supported.
///
/// </remarks>
public class vtkUnstructuredGridPreIntegration : vtkUnstructuredGridVolumeRayIntegrator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridPreIntegration";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridPreIntegration()
	{
		MRClassNameKey = "class vtkUnstructuredGridPreIntegration";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridPreIntegration"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridPreIntegration(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPreIntegration_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridPreIntegration New()
	{
		vtkUnstructuredGridPreIntegration result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridPreIntegration_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUnstructuredGridPreIntegration()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridPreIntegration_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridPreIntegration_GetIncrementalPreIntegration_01(HandleRef pThis);

	/// <summary>
	/// Get/set whether to use incremental pre-integration (by default it's
	/// on).  Incremental pre-integration is much faster but can introduce
	/// error due to numerical imprecision.  Under most circumstances, the
	/// error is not noticeable.
	/// </summary>
	public virtual int GetIncrementalPreIntegration()
	{
		return vtkUnstructuredGridPreIntegration_GetIncrementalPreIntegration_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetIndexedTableEntry_02(HandleRef pThis, int scalar_front_index, int scalar_back_index, int length_index, int component);

	/// <summary>
	/// Like GetTableEntry, except the inputs are scaled indices into the table
	/// rather than than the actual scalar and length values.  Use GetTableEntry
	/// unless you are really sure you know what you are doing.
	/// </summary>
	public IntPtr GetIndexedTableEntry(int scalar_front_index, int scalar_back_index, int length_index, int component)
	{
		return vtkUnstructuredGridPreIntegration_GetIndexedTableEntry_02(GetCppThis(), scalar_front_index, scalar_back_index, length_index, component);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthResolution_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the integration table built.
	/// </summary>
	public virtual int GetIntegrationTableLengthResolution()
	{
		return vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthResolution_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthScale_04(HandleRef pThis);

	/// <summary>
	/// Get how an integration table is indexed.
	/// </summary>
	public virtual double GetIntegrationTableLengthScale()
	{
		return vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthScale_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarResolution_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the integration table built.
	/// </summary>
	public virtual int GetIntegrationTableScalarResolution()
	{
		return vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarResolution_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarScale_06(HandleRef pThis, int component);

	/// <summary>
	/// Get how an integration table is indexed.
	/// </summary>
	public virtual double GetIntegrationTableScalarScale(int component)
	{
		return vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarScale_06(GetCppThis(), component);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarShift_07(HandleRef pThis, int component);

	/// <summary>
	/// Get how an integration table is indexed.
	/// </summary>
	public virtual double GetIntegrationTableScalarShift(int component)
	{
		return vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarShift_07(GetCppThis(), component);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetIntegrator_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The class used to fill the pre integration table.  By default, a
	/// vtkUnstructuredGridPartialPreIntegration is built.
	/// </summary>
	public virtual vtkUnstructuredGridVolumeRayIntegrator GetIntegrator()
	{
		vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridPreIntegration_GetIntegrator_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayIntegrator2 = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayIntegrator2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayIntegrator2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridPreIntegration_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridPreIntegration_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridPreIntegration_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridPreIntegration_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetPreIntegrationTable_11(HandleRef pThis, int component);

	/// <summary>
	/// Get the partial pre-integration table for the given scalar component.
	/// The tables are built when Initialize is called.  A segment of length d
	/// with a front scalar of sf and a back scalar of sb is referenced in the
	/// resulting table as 4 * ((l * \c IntegrationTableLengthScale) * \c
	/// IntegrationTableScalarResolution * \c IntegrationTableScalarResolution
	/// + (sb * \c IntegrationTableScalarScale + \c
	/// IntegrationTableScalarShift) * \c IntegrationTableScalarResolution
	/// + (sf * \c IntegrationTableScalarScale + \c
	/// IntegrationTableScalarShift)).
	/// </summary>
	public virtual IntPtr GetPreIntegrationTable(int component)
	{
		return vtkUnstructuredGridPreIntegration_GetPreIntegrationTable_11(GetCppThis(), component);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetTableEntry_12(HandleRef pThis, double scalar_front, double scalar_back, double length, int component);

	/// <summary>
	/// Get an entry (RGBA) in one of the pre-integration tables.  The tables
	/// are built when Initialize is called.
	/// </summary>
	public IntPtr GetTableEntry(double scalar_front, double scalar_back, double length, int component)
	{
		return vtkUnstructuredGridPreIntegration_GetTableEntry_12(GetCppThis(), scalar_front, scalar_back, length, component);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOff_13(HandleRef pThis);

	/// <summary>
	/// Get/set whether to use incremental pre-integration (by default it's
	/// on).  Incremental pre-integration is much faster but can introduce
	/// error due to numerical imprecision.  Under most circumstances, the
	/// error is not noticeable.
	/// </summary>
	public virtual void IncrementalPreIntegrationOff()
	{
		vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOn_14(HandleRef pThis);

	/// <summary>
	/// Get/set whether to use incremental pre-integration (by default it's
	/// on).  Incremental pre-integration is much faster but can introduce
	/// error due to numerical imprecision.  Under most circumstances, the
	/// error is not noticeable.
	/// </summary>
	public virtual void IncrementalPreIntegrationOn()
	{
		vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPreIntegration_Initialize_15(HandleRef pThis, HandleRef volume, HandleRef scalars);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Initialize(vtkVolume volume, vtkDataArray scalars)
	{
		vtkUnstructuredGridPreIntegration_Initialize_15(GetCppThis(), volume?.GetCppThis() ?? default(HandleRef), scalars?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPreIntegration_Integrate_16(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
	{
		vtkUnstructuredGridPreIntegration_Integrate_16(GetCppThis(), intersectionLengths?.GetCppThis() ?? default(HandleRef), nearIntersections?.GetCppThis() ?? default(HandleRef), farIntersections?.GetCppThis() ?? default(HandleRef), color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridPreIntegration_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridPreIntegration_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridPreIntegration_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridPreIntegration_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPreIntegration_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridPreIntegration NewInstance()
	{
		vtkUnstructuredGridPreIntegration result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridPreIntegration_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPreIntegration_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridPreIntegration SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridPreIntegration vtkUnstructuredGridPreIntegration2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridPreIntegration_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridPreIntegration2 = (vtkUnstructuredGridPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridPreIntegration2.Register(null);
			}
		}
		return vtkUnstructuredGridPreIntegration2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPreIntegration_SetIncrementalPreIntegration_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/set whether to use incremental pre-integration (by default it's
	/// on).  Incremental pre-integration is much faster but can introduce
	/// error due to numerical imprecision.  Under most circumstances, the
	/// error is not noticeable.
	/// </summary>
	public virtual void SetIncrementalPreIntegration(int _arg)
	{
		vtkUnstructuredGridPreIntegration_SetIncrementalPreIntegration_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPreIntegration_SetIntegrationTableLengthResolution_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the size of the integration table built.
	/// </summary>
	public virtual void SetIntegrationTableLengthResolution(int _arg)
	{
		vtkUnstructuredGridPreIntegration_SetIntegrationTableLengthResolution_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPreIntegration_SetIntegrationTableScalarResolution_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the size of the integration table built.
	/// </summary>
	public virtual void SetIntegrationTableScalarResolution(int _arg)
	{
		vtkUnstructuredGridPreIntegration_SetIntegrationTableScalarResolution_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPreIntegration_SetIntegrator_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// The class used to fill the pre integration table.  By default, a
	/// vtkUnstructuredGridPartialPreIntegration is built.
	/// </summary>
	public virtual void SetIntegrator(vtkUnstructuredGridVolumeRayIntegrator arg0)
	{
		vtkUnstructuredGridPreIntegration_SetIntegrator_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
