using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointSetToOctreeImageFilter
/// </summary>
/// <remarks>
///    convert a point set to an octree image
///
/// vtkPointSetToOctreeImageFilter is a filter that converts a vtkPointSet to an
/// a vtkPartitionedDataset with one vtkImageData with a number of points per cell target.
///
/// The reason we output a vtkPartitionedDataset is because the WHOLE_EXTENT needs to be dynamic.
///
/// The scalars of the vtkImageData are an octree unsigned char cell data array. Each bit of the
/// unsigned char indicates if the point-set had a point close to one of the 8 corners of the cell.
///
/// It can optionally also output a cell data array based on an input point-data scalar array by
/// setting SetInputArrayToProcess. This array will have 1 or many components that represent
/// different functions i.e. last value, min, max, count, sum, mean.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///  vtkOctreeImageToPointSetFilter
/// </seealso>
public class vtkPointSetToOctreeImageFilter : vtkPartitionedDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetToOctreeImageFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointSetToOctreeImageFilter()
	{
		MRClassNameKey = "class vtkPointSetToOctreeImageFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetToOctreeImageFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointSetToOctreeImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToOctreeImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointSetToOctreeImageFilter New()
	{
		vtkPointSetToOctreeImageFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToOctreeImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSetToOctreeImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPointSetToOctreeImageFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointSetToOctreeImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeCountOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get if the count of the values for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void ComputeCountOff()
	{
		vtkPointSetToOctreeImageFilter_ComputeCountOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeCountOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get if the count of the values for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void ComputeCountOn()
	{
		vtkPointSetToOctreeImageFilter_ComputeCountOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeLastValueOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get if the last value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	///
	/// Note: Because multithreading is employed the last value computation is not deterministic.
	/// </summary>
	public virtual void ComputeLastValueOff()
	{
		vtkPointSetToOctreeImageFilter_ComputeLastValueOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeLastValueOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get if the last value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	///
	/// Note: Because multithreading is employed the last value computation is not deterministic.
	/// </summary>
	public virtual void ComputeLastValueOn()
	{
		vtkPointSetToOctreeImageFilter_ComputeLastValueOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeMaxOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get if the max value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void ComputeMaxOff()
	{
		vtkPointSetToOctreeImageFilter_ComputeMaxOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeMaxOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get if the max value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void ComputeMaxOn()
	{
		vtkPointSetToOctreeImageFilter_ComputeMaxOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeMeanOff_07(HandleRef pThis);

	/// <summary>
	/// Set/Get if the mean value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	///
	/// Note: if ComputeMean is true, the sum and count will be computed regardless if they are on or
	/// not.
	/// </summary>
	public virtual void ComputeMeanOff()
	{
		vtkPointSetToOctreeImageFilter_ComputeMeanOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeMeanOn_08(HandleRef pThis);

	/// <summary>
	/// Set/Get if the mean value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	///
	/// Note: if ComputeMean is true, the sum and count will be computed regardless if they are on or
	/// not.
	/// </summary>
	public virtual void ComputeMeanOn()
	{
		vtkPointSetToOctreeImageFilter_ComputeMeanOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeMinOff_09(HandleRef pThis);

	/// <summary>
	/// Set/Get if the min value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void ComputeMinOff()
	{
		vtkPointSetToOctreeImageFilter_ComputeMinOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeMinOn_10(HandleRef pThis);

	/// <summary>
	/// Set/Get if the min value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void ComputeMinOn()
	{
		vtkPointSetToOctreeImageFilter_ComputeMinOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeSumOff_11(HandleRef pThis);

	/// <summary>
	/// Set/Get if the sum of the values for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void ComputeSumOff()
	{
		vtkPointSetToOctreeImageFilter_ComputeSumOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ComputeSumOn_12(HandleRef pThis);

	/// <summary>
	/// Set/Get if the sum of the values for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void ComputeSumOn()
	{
		vtkPointSetToOctreeImageFilter_ComputeSumOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeCount_13(HandleRef pThis);

	/// <summary>
	/// Set/Get if the count of the values for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual bool GetComputeCount()
	{
		return (vtkPointSetToOctreeImageFilter_GetComputeCount_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeLastValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get if the last value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	///
	/// Note: Because multithreading is employed the last value computation is not deterministic.
	/// </summary>
	public virtual bool GetComputeLastValue()
	{
		return (vtkPointSetToOctreeImageFilter_GetComputeLastValue_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeMax_15(HandleRef pThis);

	/// <summary>
	/// Set/Get if the max value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual bool GetComputeMax()
	{
		return (vtkPointSetToOctreeImageFilter_GetComputeMax_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeMean_16(HandleRef pThis);

	/// <summary>
	/// Set/Get if the mean value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	///
	/// Note: if ComputeMean is true, the sum and count will be computed regardless if they are on or
	/// not.
	/// </summary>
	public virtual bool GetComputeMean()
	{
		return (vtkPointSetToOctreeImageFilter_GetComputeMean_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeMin_17(HandleRef pThis);

	/// <summary>
	/// Set/Get if the min value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual bool GetComputeMin()
	{
		return (vtkPointSetToOctreeImageFilter_GetComputeMin_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSetToOctreeImageFilter_GetComputeSum_18(HandleRef pThis);

	/// <summary>
	/// Set/Get if the sum of the values for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual bool GetComputeSum()
	{
		return (vtkPointSetToOctreeImageFilter_GetComputeSum_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetToOctreeImageFilter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointSetToOctreeImageFilter_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetToOctreeImageFilter_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointSetToOctreeImageFilter_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCell_21(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each cell of the output image.
	/// This data member is used to determine the number dimensions of the output image.
	///
	/// The default is 1.
	/// </summary>
	public virtual int GetNumberOfPointsPerCell()
	{
		return vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCell_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCellMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each cell of the output image.
	/// This data member is used to determine the number dimensions of the output image.
	///
	/// The default is 1.
	/// </summary>
	public virtual int GetNumberOfPointsPerCellMaxValue()
	{
		return vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCellMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCellMinValue_23(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each cell of the output image.
	/// This data member is used to determine the number dimensions of the output image.
	///
	/// The default is 1.
	/// </summary>
	public virtual int GetNumberOfPointsPerCellMinValue()
	{
		return vtkPointSetToOctreeImageFilter_GetNumberOfPointsPerCellMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSetToOctreeImageFilter_GetProcessInputPointArray_24(HandleRef pThis);

	/// <summary>
	/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a point data array, will
	/// be processed.
	///
	/// The default is off.
	/// </summary>
	public virtual bool GetProcessInputPointArray()
	{
		return (vtkPointSetToOctreeImageFilter_GetProcessInputPointArray_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToOctreeImageFilter_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointSetToOctreeImageFilter_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetToOctreeImageFilter_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointSetToOctreeImageFilter_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToOctreeImageFilter_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPointSetToOctreeImageFilter NewInstance()
	{
		vtkPointSetToOctreeImageFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToOctreeImageFilter_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSetToOctreeImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ProcessInputPointArrayOff_29(HandleRef pThis);

	/// <summary>
	/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a point data array, will
	/// be processed.
	///
	/// The default is off.
	/// </summary>
	public virtual void ProcessInputPointArrayOff()
	{
		vtkPointSetToOctreeImageFilter_ProcessInputPointArrayOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_ProcessInputPointArrayOn_30(HandleRef pThis);

	/// <summary>
	/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a point data array, will
	/// be processed.
	///
	/// The default is off.
	/// </summary>
	public virtual void ProcessInputPointArrayOn()
	{
		vtkPointSetToOctreeImageFilter_ProcessInputPointArrayOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetToOctreeImageFilter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointSetToOctreeImageFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPointSetToOctreeImageFilter vtkPointSetToOctreeImageFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetToOctreeImageFilter_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSetToOctreeImageFilter2 = (vtkPointSetToOctreeImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSetToOctreeImageFilter2.Register(null);
			}
		}
		return vtkPointSetToOctreeImageFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_SetComputeCount_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the count of the values for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void SetComputeCount(bool _arg)
	{
		vtkPointSetToOctreeImageFilter_SetComputeCount_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_SetComputeLastValue_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the last value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	///
	/// Note: Because multithreading is employed the last value computation is not deterministic.
	/// </summary>
	public virtual void SetComputeLastValue(bool _arg)
	{
		vtkPointSetToOctreeImageFilter_SetComputeLastValue_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_SetComputeMax_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the max value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void SetComputeMax(bool _arg)
	{
		vtkPointSetToOctreeImageFilter_SetComputeMax_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_SetComputeMean_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the mean value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	///
	/// Note: if ComputeMean is true, the sum and count will be computed regardless if they are on or
	/// not.
	/// </summary>
	public virtual void SetComputeMean(bool _arg)
	{
		vtkPointSetToOctreeImageFilter_SetComputeMean_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_SetComputeMin_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the min value for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void SetComputeMin(bool _arg)
	{
		vtkPointSetToOctreeImageFilter_SetComputeMin_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_SetComputeSum_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the sum of the values for each cell id of the point data array will be computed.
	///
	/// The default is false.
	/// </summary>
	public virtual void SetComputeSum(bool _arg)
	{
		vtkPointSetToOctreeImageFilter_SetComputeSum_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_SetNumberOfPointsPerCell_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the average number of points in each cell of the output image.
	/// This data member is used to determine the number dimensions of the output image.
	///
	/// The default is 1.
	/// </summary>
	public virtual void SetNumberOfPointsPerCell(int _arg)
	{
		vtkPointSetToOctreeImageFilter_SetNumberOfPointsPerCell_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetToOctreeImageFilter_SetProcessInputPointArray_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a point data array, will
	/// be processed.
	///
	/// The default is off.
	/// </summary>
	public virtual void SetProcessInputPointArray(bool _arg)
	{
		vtkPointSetToOctreeImageFilter_SetProcessInputPointArray_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
