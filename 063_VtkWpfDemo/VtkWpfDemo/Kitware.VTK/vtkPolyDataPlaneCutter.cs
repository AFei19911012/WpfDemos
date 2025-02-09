using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataPlaneCutter
/// </summary>
/// <remarks>
///    threaded (high-performance) cutting of a vtkPolyData with a plane
///
/// vtkPolyDataPlaneCutter cuts an input vtkPolyData with a plane to produce
/// an output vtkPolyData. (Here cutting means slicing through the polydata to
/// generates lines of intersection.) The input vtkPolyData must consist of
/// convex polygons - vertices, lines, and triangle strips are ignored. (Note:
/// use vtkTriangleFilter to triangulate non-convex input polygons if
/// necessary. If the input cells are non-convex, then the cutting operation
/// will likely produce erroneous results.)
///
/// The main difference between this filter and other cutting filters is that
/// vtkPolyDataPlaneCutter is tuned for performance on vtkPolyData with convex
/// polygonal cells.
///
/// @warning
/// The method CanFullyProcessDataObject() is available to see whether the
/// input data can be successfully processed by this filter. Use this method
/// sparingly because it can be slow.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkPlaneCutter vtkCutter vtkPolyDataPlaneClipper
/// </seealso>
public class vtkPolyDataPlaneCutter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPlaneCutter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataPlaneCutter()
	{
		MRClassNameKey = "class vtkPolyDataPlaneCutter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPlaneCutter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new static vtkPolyDataPlaneCutter New()
	{
		vtkPolyDataPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public vtkPolyDataPlaneCutter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkPolyDataPlaneCutter_CanFullyProcessDataObject_01(HandleRef arg0);

	/// <summary>
	/// This helper method can be used to determine the if the input vtkPolyData
	/// contains convex polygonal cells, and therefore is suitable for
	/// processing by this filter. (The name of the method is consistent with
	/// other filters that perform similar operations.) This method returns true
	/// when the input contains only polygons (i.e., no verts, lines, or
	/// triangle strips); and each polygon is convex. It returns false
	/// otherwise.
	/// </summary>
	public static bool CanFullyProcessDataObject(vtkDataObject arg0)
	{
		return (vtkPolyDataPlaneCutter_CanFullyProcessDataObject_01(arg0?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneCutter_ComputeNormalsOff_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normals are associated with the output points. By
	/// default the computation of normals is disabled.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkPolyDataPlaneCutter_ComputeNormalsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneCutter_ComputeNormalsOn_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normals are associated with the output points. By
	/// default the computation of normals is disabled.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkPolyDataPlaneCutter_ComputeNormalsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPolyDataPlaneCutter_GetBatchSize_04(HandleRef pThis);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload). By default,
	/// the batch size is 10,000 cells.
	/// </summary>
	public virtual uint GetBatchSize()
	{
		return vtkPolyDataPlaneCutter_GetBatchSize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPolyDataPlaneCutter_GetBatchSizeMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload). By default,
	/// the batch size is 10,000 cells.
	/// </summary>
	public virtual uint GetBatchSizeMaxValue()
	{
		return vtkPolyDataPlaneCutter_GetBatchSizeMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPolyDataPlaneCutter_GetBatchSizeMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload). By default,
	/// the batch size is 10,000 cells.
	/// </summary>
	public virtual uint GetBatchSizeMinValue()
	{
		return vtkPolyDataPlaneCutter_GetBatchSizeMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPlaneCutter_GetComputeNormals_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normals are associated with the output points. By
	/// default the computation of normals is disabled.
	/// </summary>
	public virtual bool GetComputeNormals()
	{
		return (vtkPolyDataPlaneCutter_GetComputeNormals_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPlaneCutter_GetInterpolateAttributes_08(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate attribute data. By default this is
	/// enabled. Note that both cell data and point data is interpolated and
	/// output.
	/// </summary>
	public virtual bool GetInterpolateAttributes()
	{
		return (vtkPolyDataPlaneCutter_GetInterpolateAttributes_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPolyDataPlaneCutter_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// The modified time depends on the delegated cutting plane.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPolyDataPlaneCutter_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataPlaneCutter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataPlaneCutter_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataPlaneCutter_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataPlaneCutter_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPlaneCutter_GetOutputPointsPrecision_12(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points type. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings. OutputPointsPrecision
	/// is DEFAULT_PRECISION by default.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkPolyDataPlaneCutter_GetOutputPointsPrecision_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPlaneCutter_GetPlane_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the cutting. The
	/// definition of the plane used to perform the cutting (i.e., its origin
	/// and normal) is controlled via this instance of vtkPlane.
	/// </summary>
	public virtual vtkPlane GetPlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPlaneCutter_GetPlane_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneCutter_InterpolateAttributesOff_14(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate attribute data. By default this is
	/// enabled. Note that both cell data and point data is interpolated and
	/// output.
	/// </summary>
	public virtual void InterpolateAttributesOff()
	{
		vtkPolyDataPlaneCutter_InterpolateAttributesOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneCutter_InterpolateAttributesOn_15(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate attribute data. By default this is
	/// enabled. Note that both cell data and point data is interpolated and
	/// output.
	/// </summary>
	public virtual void InterpolateAttributesOn()
	{
		vtkPolyDataPlaneCutter_InterpolateAttributesOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPlaneCutter_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataPlaneCutter_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPlaneCutter_IsTypeOf_17(string type);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataPlaneCutter_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPlaneCutter_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new vtkPolyDataPlaneCutter NewInstance()
	{
		vtkPolyDataPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPlaneCutter_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPlaneCutter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new static vtkPolyDataPlaneCutter SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataPlaneCutter vtkPolyDataPlaneCutter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPlaneCutter_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataPlaneCutter2 = (vtkPolyDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataPlaneCutter2.Register(null);
			}
		}
		return vtkPolyDataPlaneCutter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneCutter_SetBatchSize_21(HandleRef pThis, uint _arg);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload). By default,
	/// the batch size is 10,000 cells.
	/// </summary>
	public virtual void SetBatchSize(uint _arg)
	{
		vtkPolyDataPlaneCutter_SetBatchSize_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneCutter_SetComputeNormals_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normals are associated with the output points. By
	/// default the computation of normals is disabled.
	/// </summary>
	public virtual void SetComputeNormals(bool _arg)
	{
		vtkPolyDataPlaneCutter_SetComputeNormals_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneCutter_SetInterpolateAttributes_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to interpolate attribute data. By default this is
	/// enabled. Note that both cell data and point data is interpolated and
	/// output.
	/// </summary>
	public virtual void SetInterpolateAttributes(bool _arg)
	{
		vtkPolyDataPlaneCutter_SetInterpolateAttributes_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneCutter_SetOutputPointsPrecision_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points type. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings. OutputPointsPrecision
	/// is DEFAULT_PRECISION by default.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkPolyDataPlaneCutter_SetOutputPointsPrecision_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneCutter_SetPlane_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the cutting. The
	/// definition of the plane used to perform the cutting (i.e., its origin
	/// and normal) is controlled via this instance of vtkPlane.
	/// </summary>
	public void SetPlane(vtkPlane arg0)
	{
		vtkPolyDataPlaneCutter_SetPlane_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
