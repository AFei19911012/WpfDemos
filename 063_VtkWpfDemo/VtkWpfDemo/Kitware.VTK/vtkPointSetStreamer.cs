using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointSetStreamer
/// </summary>
/// <remarks>
///    stream points as buckets
///
/// vtkPointSetStreamer is a filter that sorts points into buckets and it returns the points
/// included in the chosen bucket. The bucket is chosen by setting the BucketId. The purpose
/// of this class is to allow streaming of points. The bucket size is determined by the
/// NumberOfPointsPerBucket.
///
/// The typical usage is to call this filter the first time to perform the sorting and get the points
/// in the first bucket and then to call it again to get the points in the remaining buckets. The
/// sorting is performed only the first time, assuming that the dataset or NumberOfPointsPerBucket
/// don't change. The number of buckets can be obtained by calling GetNumberOfBuckets.
///
/// </remarks>
/// <seealso>
///  vtkPointSetToOctreeImageFilter vtkStaticPointLocator
/// </seealso>
public class vtkPointSetStreamer : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetStreamer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointSetStreamer()
	{
		MRClassNameKey = "class vtkPointSetStreamer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetStreamer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointSetStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetStreamer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointSetStreamer New()
	{
		vtkPointSetStreamer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetStreamer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSetStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPointSetStreamer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointSetStreamer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointSetStreamer_CreateVerticesCellArrayOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get if a cell array of vertices will be created.
	///
	/// The default is on.
	/// </summary>
	public virtual void CreateVerticesCellArrayOff()
	{
		vtkPointSetStreamer_CreateVerticesCellArrayOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetStreamer_CreateVerticesCellArrayOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get if a cell array of vertices will be created.
	///
	/// The default is on.
	/// </summary>
	public virtual void CreateVerticesCellArrayOn()
	{
		vtkPointSetStreamer_CreateVerticesCellArrayOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetStreamer_GetBucketId_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the bucket id to stream.
	/// This data member is used to determine the number of buckets.
	///
	/// The default is 0.
	/// </summary>
	public virtual long GetBucketId()
	{
		return vtkPointSetStreamer_GetBucketId_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetStreamer_GetBucketIdMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the bucket id to stream.
	/// This data member is used to determine the number of buckets.
	///
	/// The default is 0.
	/// </summary>
	public virtual long GetBucketIdMaxValue()
	{
		return vtkPointSetStreamer_GetBucketIdMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetStreamer_GetBucketIdMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the bucket id to stream.
	/// This data member is used to determine the number of buckets.
	///
	/// The default is 0.
	/// </summary>
	public virtual long GetBucketIdMinValue()
	{
		return vtkPointSetStreamer_GetBucketIdMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSetStreamer_GetCreateVerticesCellArray_06(HandleRef pThis);

	/// <summary>
	/// Set/Get if a cell array of vertices will be created.
	///
	/// The default is on.
	/// </summary>
	public virtual bool GetCreateVerticesCellArray()
	{
		return (vtkPointSetStreamer_GetCreateVerticesCellArray_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetStreamer_GetNumberOfBuckets_07(HandleRef pThis);

	/// <summary>
	/// Get the number of buckets.
	///
	/// Note: This method must be called after the first pass.
	/// </summary>
	public virtual long GetNumberOfBuckets()
	{
		return vtkPointSetStreamer_GetNumberOfBuckets_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetStreamer_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointSetStreamer_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSetStreamer_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointSetStreamer_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetStreamer_GetNumberOfPointsPerBucket_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the average number of points in each bucket.
	/// This data member is used to determine the number of buckets.
	///
	/// The default is 1.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucket()
	{
		return vtkPointSetStreamer_GetNumberOfPointsPerBucket_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetStreamer_GetNumberOfPointsPerBucketMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the average number of points in each bucket.
	/// This data member is used to determine the number of buckets.
	///
	/// The default is 1.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucketMaxValue()
	{
		return vtkPointSetStreamer_GetNumberOfPointsPerBucketMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetStreamer_GetNumberOfPointsPerBucketMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the average number of points in each bucket.
	/// This data member is used to determine the number of buckets.
	///
	/// The default is 1.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucketMinValue()
	{
		return vtkPointSetStreamer_GetNumberOfPointsPerBucketMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetStreamer_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointSetStreamer_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSetStreamer_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointSetStreamer_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetStreamer_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPointSetStreamer NewInstance()
	{
		vtkPointSetStreamer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetStreamer_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSetStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSetStreamer_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointSetStreamer SafeDownCast(vtkObjectBase o)
	{
		vtkPointSetStreamer vtkPointSetStreamer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSetStreamer_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSetStreamer2 = (vtkPointSetStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSetStreamer2.Register(null);
			}
		}
		return vtkPointSetStreamer2;
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetStreamer_SetBucketId_18(HandleRef pThis, long _arg);

	/// <summary>
	/// Set/Get the bucket id to stream.
	/// This data member is used to determine the number of buckets.
	///
	/// The default is 0.
	/// </summary>
	public virtual void SetBucketId(long _arg)
	{
		vtkPointSetStreamer_SetBucketId_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetStreamer_SetCreateVerticesCellArray_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if a cell array of vertices will be created.
	///
	/// The default is on.
	/// </summary>
	public virtual void SetCreateVerticesCellArray(bool _arg)
	{
		vtkPointSetStreamer_SetCreateVerticesCellArray_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSetStreamer_SetNumberOfPointsPerBucket_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the average number of points in each bucket.
	/// This data member is used to determine the number of buckets.
	///
	/// The default is 1.
	/// </summary>
	public virtual void SetNumberOfPointsPerBucket(int _arg)
	{
		vtkPointSetStreamer_SetNumberOfPointsPerBucket_20(GetCppThis(), _arg);
	}
}
