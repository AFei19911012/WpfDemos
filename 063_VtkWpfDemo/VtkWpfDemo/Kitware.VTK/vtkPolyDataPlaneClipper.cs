using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataPlaneClipper
/// </summary>
/// <remarks>
///    clip a vtkPolyData with a plane and optionally cap it
///
/// vtkPolyDataPlaneClipper clips an input vtkPolyData with a plane to produce
/// an output vtkPolyData. (Here clipping means extracting cells, or portions
/// of cells, that are on one side of a specified plane.) The input
/// vtkPolyData must consist of convex polygons forming one or more manifold
/// shells (use vtkTriangleFilter to triangulate the input if necessary. Note
/// that if the input cells are non-convex, then the clipping operation will
/// likely produce erroneous results.)
///
/// An optional, second vtkPolyData output may also be generated if either
/// ClippingLoops or Capping is enabled. The clipping loops are a set of lines
/// representing the curve(s) of intersection between the plane and the one or
/// more shells of the input vtkPolyData. If Capping is enabled, then the
/// clipping loops are tessellated to produce a "cap" across the clipped
/// output. The capping option is only available if the input consists of one
/// or more manifold shells. If not, the loop generation will fail and no
/// cap(s) will be generated.
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
/// vtkClipPolyData vtkClipClosedSurface vtkPolyDataPlaneCutter vtkPlaneCutter
/// vtkTriangleFilter vtkCutter
/// </seealso>
public class vtkPolyDataPlaneClipper : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPlaneClipper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataPlaneClipper()
	{
		MRClassNameKey = "class vtkPolyDataPlaneClipper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPlaneClipper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataPlaneClipper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPlaneClipper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new static vtkPolyDataPlaneClipper New()
	{
		vtkPolyDataPlaneClipper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPlaneClipper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataPlaneClipper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public vtkPolyDataPlaneClipper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataPlaneClipper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkPolyDataPlaneClipper_CanFullyProcessDataObject_01(HandleRef arg0);

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
		return (vtkPolyDataPlaneClipper_CanFullyProcessDataObject_01(arg0?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_CappingOff_02(HandleRef pThis);

	/// <summary>
	/// Specify whether to cap the clipped output vtkPolyData. If enabled, a
	/// second vtkPolyData output will be produced that contains the capping
	/// polygons (in vtkPolyData:Polys). Note that the capping operation assumes
	/// that the input to this filter is a manifold shell. If not, no output
	/// will be generated. Note that point data or cell data is not produced on
	/// this second output (because the results of interpolation across the
	/// cap(s) are generally nonsensical).
	/// </summary>
	public virtual void CappingOff()
	{
		vtkPolyDataPlaneClipper_CappingOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_CappingOn_03(HandleRef pThis);

	/// <summary>
	/// Specify whether to cap the clipped output vtkPolyData. If enabled, a
	/// second vtkPolyData output will be produced that contains the capping
	/// polygons (in vtkPolyData:Polys). Note that the capping operation assumes
	/// that the input to this filter is a manifold shell. If not, no output
	/// will be generated. Note that point data or cell data is not produced on
	/// this second output (because the results of interpolation across the
	/// cap(s) are generally nonsensical).
	/// </summary>
	public virtual void CappingOn()
	{
		vtkPolyDataPlaneClipper_CappingOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_ClippingLoopsOff_04(HandleRef pThis);

	/// <summary>
	/// Specify whether to generate clipping loops, i.e., the intersection of
	/// the plane with the input polydata. The generation of clipping loops will
	/// function correctly even if the input vtkPolyData consists of non-closed
	/// shells; however if the shells are not closed, the loops will not be
	/// either. If enabled, a second vtkPolyData output will be produced that
	/// contains the clipping loops (in vtkPolyData::Lines)
	/// </summary>
	public virtual void ClippingLoopsOff()
	{
		vtkPolyDataPlaneClipper_ClippingLoopsOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_ClippingLoopsOn_05(HandleRef pThis);

	/// <summary>
	/// Specify whether to generate clipping loops, i.e., the intersection of
	/// the plane with the input polydata. The generation of clipping loops will
	/// function correctly even if the input vtkPolyData consists of non-closed
	/// shells; however if the shells are not closed, the loops will not be
	/// either. If enabled, a second vtkPolyData output will be produced that
	/// contains the clipping loops (in vtkPolyData::Lines)
	/// </summary>
	public virtual void ClippingLoopsOn()
	{
		vtkPolyDataPlaneClipper_ClippingLoopsOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPolyDataPlaneClipper_GetBatchSize_06(HandleRef pThis);

	/// <summary>
	/// Specify the number of input triangles in a batch, where a batch defines
	/// a subset of the input triangles operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	/// </summary>
	public virtual uint GetBatchSize()
	{
		return vtkPolyDataPlaneClipper_GetBatchSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPolyDataPlaneClipper_GetBatchSizeMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the number of input triangles in a batch, where a batch defines
	/// a subset of the input triangles operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	/// </summary>
	public virtual uint GetBatchSizeMaxValue()
	{
		return vtkPolyDataPlaneClipper_GetBatchSizeMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPolyDataPlaneClipper_GetBatchSizeMinValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the number of input triangles in a batch, where a batch defines
	/// a subset of the input triangles operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	/// </summary>
	public virtual uint GetBatchSizeMinValue()
	{
		return vtkPolyDataPlaneClipper_GetBatchSizeMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPlaneClipper_GetCap_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output dataset representing the clipping loops and capping
	/// polygons.  This output is empty if both ClippingLoops and Capping is
	/// off. Otherwise, if there is an intersection with the clipping plane,
	/// then polyline loops are available from the vtkPolyData::Lines, and the
	/// capping polygons are available from the vtkPolyData::Polys data arrays.
	/// </summary>
	public vtkPolyData GetCap()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPlaneClipper_GetCap_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPlaneClipper_GetCapping_10(HandleRef pThis);

	/// <summary>
	/// Specify whether to cap the clipped output vtkPolyData. If enabled, a
	/// second vtkPolyData output will be produced that contains the capping
	/// polygons (in vtkPolyData:Polys). Note that the capping operation assumes
	/// that the input to this filter is a manifold shell. If not, no output
	/// will be generated. Note that point data or cell data is not produced on
	/// this second output (because the results of interpolation across the
	/// cap(s) are generally nonsensical).
	/// </summary>
	public virtual bool GetCapping()
	{
		return (vtkPolyDataPlaneClipper_GetCapping_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPlaneClipper_GetClippingLoops_11(HandleRef pThis);

	/// <summary>
	/// Specify whether to generate clipping loops, i.e., the intersection of
	/// the plane with the input polydata. The generation of clipping loops will
	/// function correctly even if the input vtkPolyData consists of non-closed
	/// shells; however if the shells are not closed, the loops will not be
	/// either. If enabled, a second vtkPolyData output will be produced that
	/// contains the clipping loops (in vtkPolyData::Lines)
	/// </summary>
	public virtual bool GetClippingLoops()
	{
		return (vtkPolyDataPlaneClipper_GetClippingLoops_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPolyDataPlaneClipper_GetMTime_12(HandleRef pThis);

	/// <summary>
	/// The modified time depends on the delegated clipping plane.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPolyDataPlaneClipper_GetMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataPlaneClipper_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataPlaneClipper_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataPlaneClipper_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataPlaneClipper_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPlaneClipper_GetOutputPointsPrecision_15(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points type. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings. OutputPointsPrecision
	/// is DEFAULT_PRECISION by default.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkPolyDataPlaneClipper_GetOutputPointsPrecision_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataPlaneClipper_GetPassCapPointData_16(HandleRef pThis);

	/// <summary>
	/// Specify whether to pass point data through to the second (Cap) output.
	/// By default this is disabled. This feature is useful in certain situations
	/// when trying to combine the cap with clipped polydata.
	/// </summary>
	public virtual bool GetPassCapPointData()
	{
		return (vtkPolyDataPlaneClipper_GetPassCapPointData_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPlaneClipper_GetPlane_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the clipping. The
	/// definition of the plane used to perform the clipping (i.e., its origin
	/// and normal) is controlled via this instance of vtkPlane.
	/// </summary>
	public virtual vtkPlane GetPlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPlaneClipper_GetPlane_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPolyDataPlaneClipper_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataPlaneClipper_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataPlaneClipper_IsTypeOf_19(string type);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataPlaneClipper_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPlaneClipper_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new vtkPolyDataPlaneClipper NewInstance()
	{
		vtkPolyDataPlaneClipper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPlaneClipper_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataPlaneClipper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_PassCapPointDataOff_22(HandleRef pThis);

	/// <summary>
	/// Specify whether to pass point data through to the second (Cap) output.
	/// By default this is disabled. This feature is useful in certain situations
	/// when trying to combine the cap with clipped polydata.
	/// </summary>
	public virtual void PassCapPointDataOff()
	{
		vtkPolyDataPlaneClipper_PassCapPointDataOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_PassCapPointDataOn_23(HandleRef pThis);

	/// <summary>
	/// Specify whether to pass point data through to the second (Cap) output.
	/// By default this is disabled. This feature is useful in certain situations
	/// when trying to combine the cap with clipped polydata.
	/// </summary>
	public virtual void PassCapPointDataOn()
	{
		vtkPolyDataPlaneClipper_PassCapPointDataOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataPlaneClipper_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction, type, and print methods.
	/// </summary>
	public new static vtkPolyDataPlaneClipper SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataPlaneClipper vtkPolyDataPlaneClipper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataPlaneClipper_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataPlaneClipper2 = (vtkPolyDataPlaneClipper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataPlaneClipper2.Register(null);
			}
		}
		return vtkPolyDataPlaneClipper2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_SetBatchSize_25(HandleRef pThis, uint _arg);

	/// <summary>
	/// Specify the number of input triangles in a batch, where a batch defines
	/// a subset of the input triangles operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	/// </summary>
	public virtual void SetBatchSize(uint _arg)
	{
		vtkPolyDataPlaneClipper_SetBatchSize_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_SetCapping_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether to cap the clipped output vtkPolyData. If enabled, a
	/// second vtkPolyData output will be produced that contains the capping
	/// polygons (in vtkPolyData:Polys). Note that the capping operation assumes
	/// that the input to this filter is a manifold shell. If not, no output
	/// will be generated. Note that point data or cell data is not produced on
	/// this second output (because the results of interpolation across the
	/// cap(s) are generally nonsensical).
	/// </summary>
	public virtual void SetCapping(bool _arg)
	{
		vtkPolyDataPlaneClipper_SetCapping_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_SetClippingLoops_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether to generate clipping loops, i.e., the intersection of
	/// the plane with the input polydata. The generation of clipping loops will
	/// function correctly even if the input vtkPolyData consists of non-closed
	/// shells; however if the shells are not closed, the loops will not be
	/// either. If enabled, a second vtkPolyData output will be produced that
	/// contains the clipping loops (in vtkPolyData::Lines)
	/// </summary>
	public virtual void SetClippingLoops(bool _arg)
	{
		vtkPolyDataPlaneClipper_SetClippingLoops_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_SetOutputPointsPrecision_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points type. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings. OutputPointsPrecision
	/// is DEFAULT_PRECISION by default.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkPolyDataPlaneClipper_SetOutputPointsPrecision_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_SetPassCapPointData_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether to pass point data through to the second (Cap) output.
	/// By default this is disabled. This feature is useful in certain situations
	/// when trying to combine the cap with clipped polydata.
	/// </summary>
	public virtual void SetPassCapPointData(bool _arg)
	{
		vtkPolyDataPlaneClipper_SetPassCapPointData_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataPlaneClipper_SetPlane_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the clipping. The
	/// definition of the plane used to perform the clipping (i.e., its origin
	/// and normal) is controlled via this instance of vtkPlane.
	/// </summary>
	public void SetPlane(vtkPlane arg0)
	{
		vtkPolyDataPlaneClipper_SetPlane_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
