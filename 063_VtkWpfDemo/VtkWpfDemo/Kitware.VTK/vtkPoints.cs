using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPoints
/// </summary>
/// <remarks>
///    represent and manipulate 3D points
///
/// vtkPoints represents 3D points. The data model for vtkPoints is an
/// array of vx-vy-vz triplets accessible by (point or cell) id.
/// </remarks>
public class vtkPoints : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPoints()
	{
		MRClassNameKey = "class vtkPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPoints New()
	{
		vtkPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoints_Allocate_01(HandleRef pThis, long sz, long ext);

	/// <summary>
	/// Allocate initial memory size. ext is no longer used.
	/// </summary>
	public virtual int Allocate(long sz, long ext)
	{
		return vtkPoints_Allocate_01(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_ComputeBounds_02(HandleRef pThis);

	/// <summary>
	/// Determine (xmin,xmax, ymin,ymax, zmin,zmax) bounds of points.
	/// </summary>
	public virtual void ComputeBounds()
	{
		vtkPoints_ComputeBounds_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_DeepCopy_03(HandleRef pThis, HandleRef ad);

	/// <summary>
	/// Different ways to copy data. Shallow copy does reference count (i.e.,
	/// assigns pointers and updates reference count); deep copy runs through
	/// entire data array assigning values.
	/// </summary>
	public virtual void DeepCopy(vtkPoints ad)
	{
		vtkPoints_DeepCopy_03(GetCppThis(), ad?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPoints_GetActualMemorySize_04(HandleRef pThis);

	/// <summary>
	/// Return the memory in kibibytes (1024 bytes) consumed by this attribute data.
	/// Used to support streaming and reading/writing data. The value
	/// returned is guaranteed to be greater than or equal to the
	/// memory required to actually represent the data represented
	/// by this object. The information returned is valid only after
	/// the pipeline has been updated.
	/// </summary>
	public uint GetActualMemorySize()
	{
		return vtkPoints_GetActualMemorySize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// Return the bounds of the points.
	/// </summary>
	public double[] GetBounds()
	{
		IntPtr intPtr = vtkPoints_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_GetBounds_06(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return the bounds of the points.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkPoints_GetBounds_06(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints_GetData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the underlying data array. This function must be implemented
	/// in a concrete subclass to check for consistency. (The tuple size must
	/// match the type of data. For example, 3-tuple data array can be assigned to
	/// a vector, normal, or points object, but not a tensor object, which has a
	/// tuple dimension of 9. Scalars, on the other hand, can have tuple dimension
	/// from 1-4, depending on the type of scalar.)
	/// </summary>
	public vtkDataArray GetData()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoints_GetData_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoints_GetDataType_08(HandleRef pThis);

	/// <summary>
	/// Return the underlying data type. An integer indicating data type is
	/// returned as specified in vtkSetGet.h.
	/// </summary>
	public virtual int GetDataType()
	{
		return vtkPoints_GetDataType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPoints_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// The modified time of the points.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPoints_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPoints_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPoints_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints_GetNumberOfPoints_12(HandleRef pThis);

	/// <summary>
	/// Return number of points in array.
	/// </summary>
	public long GetNumberOfPoints()
	{
		return vtkPoints_GetNumberOfPoints_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints_GetPoint_13(HandleRef pThis, long id);

	/// <summary>
	/// Return a pointer to a double point x[3] for a specific id.
	/// WARNING: Just don't use this error-prone method, the returned pointer
	/// and its values are only valid as long as another method invocation is not
	/// performed. Prefer GetPoint() with the return value in argument.
	/// </summary>
	public double[] GetPoint(long id)
	{
		IntPtr intPtr = vtkPoints_GetPoint_13(GetCppThis(), id);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_GetPoint_14(HandleRef pThis, long id, IntPtr x);

	/// <summary>
	/// Copy point components into user provided array v[3] for specified
	/// id.
	/// </summary>
	public void GetPoint(long id, IntPtr x)
	{
		vtkPoints_GetPoint_14(GetCppThis(), id, x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_GetPoints_15(HandleRef pThis, HandleRef ptId, HandleRef outPoints);

	/// <summary>
	/// Given a list of pt ids, return an array of points.
	/// </summary>
	public void GetPoints(vtkIdList ptId, vtkPoints outPoints)
	{
		vtkPoints_GetPoints_15(GetCppThis(), ptId?.GetCppThis() ?? default(HandleRef), outPoints?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints_GetVoidPointer_16(HandleRef pThis, int id);

	/// <summary>
	/// Return a void pointer. For image pipeline interface and other
	/// special pointer manipulation.
	/// </summary>
	public IntPtr GetVoidPointer(int id)
	{
		return vtkPoints_GetVoidPointer_16(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_Initialize_17(HandleRef pThis);

	/// <summary>
	/// Return object to instantiated state.
	/// </summary>
	public virtual void Initialize()
	{
		vtkPoints_Initialize_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints_InsertNextPoint_18(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Insert point into next available slot. Returns id of slot.
	/// </summary>
	public long InsertNextPoint(IntPtr x)
	{
		return vtkPoints_InsertNextPoint_18(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints_InsertNextPoint_19(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Insert point into next available slot. Returns id of slot.
	/// </summary>
	public long InsertNextPoint(double x, double y, double z)
	{
		return vtkPoints_InsertNextPoint_19(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_InsertPoint_20(HandleRef pThis, long id, IntPtr x);

	/// <summary>
	/// Insert point into object. Range checking performed and memory
	/// allocated as necessary.
	/// </summary>
	public void InsertPoint(long id, IntPtr x)
	{
		vtkPoints_InsertPoint_20(GetCppThis(), id, x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_InsertPoint_21(HandleRef pThis, long id, double x, double y, double z);

	/// <summary>
	/// Insert point into object. Range checking performed and memory
	/// allocated as necessary.
	/// </summary>
	public void InsertPoint(long id, double x, double y, double z)
	{
		vtkPoints_InsertPoint_21(GetCppThis(), id, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_InsertPoints_22(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// Copy the points indexed in srcIds from the source array to the tuple
	/// locations indexed by dstIds in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public void InsertPoints(vtkIdList dstIds, vtkIdList srcIds, vtkPoints source)
	{
		vtkPoints_InsertPoints_22(GetCppThis(), dstIds?.GetCppThis() ?? default(HandleRef), srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_InsertPoints_23(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

	/// <summary>
	/// Copy n consecutive points starting at srcStart from the source array to
	/// this array, starting at the dstStart location.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public void InsertPoints(long dstStart, long n, long srcStart, vtkPoints source)
	{
		vtkPoints_InsertPoints_23(GetCppThis(), dstStart, n, srcStart, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoints_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPoints_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoints_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPoints_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_Modified_26(HandleRef pThis);

	/// <summary>
	/// Update the modification time for this object and its Data.
	/// As this object acts as a shell around a DataArray and
	/// forwards Set methods it needs to forward Modified as well.
	/// </summary>
	public override void Modified()
	{
		vtkPoints_Modified_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints_New_27(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkPoints New(int dataType)
	{
		vtkPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoints_New_27(dataType, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPoints NewInstance()
	{
		vtkPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoints_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_Reset_30(HandleRef pThis);

	/// <summary>
	/// Make object look empty but do not delete memory.
	/// </summary>
	public virtual void Reset()
	{
		vtkPoints_Reset_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoints_Resize_31(HandleRef pThis, long numPoints);

	/// <summary>
	/// Resize the internal array while conserving the data.  Returns 1 if
	/// resizing succeeded and 0 otherwise.
	/// </summary>
	public int Resize(long numPoints)
	{
		return vtkPoints_Resize_31(GetCppThis(), numPoints);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPoints SafeDownCast(vtkObjectBase o)
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoints_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetData_33(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the underlying data array. This function must be implemented
	/// in a concrete subclass to check for consistency. (The tuple size must
	/// match the type of data. For example, 3-tuple data array can be assigned to
	/// a vector, normal, or points object, but not a tensor object, which has a
	/// tuple dimension of 9. Scalars, on the other hand, can have tuple dimension
	/// from 1-4, depending on the type of scalar.)
	/// </summary>
	public virtual void SetData(vtkDataArray arg0)
	{
		vtkPoints_SetData_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataType_34(HandleRef pThis, int dataType);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public virtual void SetDataType(int dataType)
	{
		vtkPoints_SetDataType_34(GetCppThis(), dataType);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToBit_35(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToBit()
	{
		vtkPoints_SetDataTypeToBit_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToChar_36(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToChar()
	{
		vtkPoints_SetDataTypeToChar_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToDouble_37(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToDouble()
	{
		vtkPoints_SetDataTypeToDouble_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToFloat_38(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToFloat()
	{
		vtkPoints_SetDataTypeToFloat_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToInt_39(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToInt()
	{
		vtkPoints_SetDataTypeToInt_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToLong_40(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToLong()
	{
		vtkPoints_SetDataTypeToLong_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToShort_41(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToShort()
	{
		vtkPoints_SetDataTypeToShort_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToUnsignedChar_42(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToUnsignedChar()
	{
		vtkPoints_SetDataTypeToUnsignedChar_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToUnsignedInt_43(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToUnsignedInt()
	{
		vtkPoints_SetDataTypeToUnsignedInt_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToUnsignedLong_44(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToUnsignedLong()
	{
		vtkPoints_SetDataTypeToUnsignedLong_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetDataTypeToUnsignedShort_45(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// Default is VTK_FLOAT.
	/// </summary>
	public void SetDataTypeToUnsignedShort()
	{
		vtkPoints_SetDataTypeToUnsignedShort_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetNumberOfPoints_46(HandleRef pThis, long numPoints);

	/// <summary>
	/// Specify the number of points for this object to hold. Does an
	/// allocation as well as setting the MaxId ivar. Used in conjunction with
	/// SetPoint() method for fast insertion.
	/// </summary>
	public void SetNumberOfPoints(long numPoints)
	{
		vtkPoints_SetNumberOfPoints_46(GetCppThis(), numPoints);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetPoint_47(HandleRef pThis, long id, IntPtr x);

	/// <summary>
	/// Insert point into object. No range checking performed (fast!).
	/// Make sure you use SetNumberOfPoints() to allocate memory prior
	/// to using SetPoint(). You should call Modified() finally after
	/// changing points using this method as it will not do it itself.
	/// </summary>
	public void SetPoint(long id, IntPtr x)
	{
		vtkPoints_SetPoint_47(GetCppThis(), id, x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_SetPoint_48(HandleRef pThis, long id, double x, double y, double z);

	/// <summary>
	/// Insert point into object. No range checking performed (fast!).
	/// Make sure you use SetNumberOfPoints() to allocate memory prior
	/// to using SetPoint(). You should call Modified() finally after
	/// changing points using this method as it will not do it itself.
	/// </summary>
	public void SetPoint(long id, double x, double y, double z)
	{
		vtkPoints_SetPoint_48(GetCppThis(), id, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_ShallowCopy_49(HandleRef pThis, HandleRef ad);

	/// <summary>
	/// Different ways to copy data. Shallow copy does reference count (i.e.,
	/// assigns pointers and updates reference count); deep copy runs through
	/// entire data array assigning values.
	/// </summary>
	public virtual void ShallowCopy(vtkPoints ad)
	{
		vtkPoints_ShallowCopy_49(GetCppThis(), ad?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints_Squeeze_50(HandleRef pThis);

	/// <summary>
	/// Reclaim any extra memory.
	/// </summary>
	public virtual void Squeeze()
	{
		vtkPoints_Squeeze_50(GetCppThis());
	}
}
