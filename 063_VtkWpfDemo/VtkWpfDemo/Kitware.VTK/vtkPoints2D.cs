using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPoints2D
/// </summary>
/// <remarks>
///    represent and manipulate 2D points
///
/// vtkPoints2D represents 2D points. The data model for vtkPoints2D is an
/// array of vx-vy doublets accessible by (point or cell) id.
/// </remarks>
public class vtkPoints2D : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPoints2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPoints2D()
	{
		MRClassNameKey = "class vtkPoints2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPoints2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPoints2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPoints2D New()
	{
		vtkPoints2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoints2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPoints2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPoints2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPoints2D_Allocate_01(HandleRef pThis, long sz, long ext);

	/// <summary>
	/// Allocate initial memory size. ext is no longer used.
	/// </summary>
	public virtual int Allocate(long sz, long ext)
	{
		return vtkPoints2D_Allocate_01(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_ComputeBounds_02(HandleRef pThis);

	/// <summary>
	/// Determine (xmin,xmax, ymin,ymax) bounds of points.
	/// </summary>
	public virtual void ComputeBounds()
	{
		vtkPoints2D_ComputeBounds_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_DeepCopy_03(HandleRef pThis, HandleRef ad);

	/// <summary>
	/// Different ways to copy data. Shallow copy does reference count (i.e.,
	/// assigns pointers and updates reference count); deep copy runs through
	/// entire data array assigning values.
	/// </summary>
	public virtual void DeepCopy(vtkPoints2D ad)
	{
		vtkPoints2D_DeepCopy_03(GetCppThis(), ad?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPoints2D_GetActualMemorySize_04(HandleRef pThis);

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
		return vtkPoints2D_GetActualMemorySize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints2D_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// Return the bounds of the points.
	/// </summary>
	public double[] GetBounds()
	{
		IntPtr intPtr = vtkPoints2D_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_GetBounds_06(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return the bounds of the points.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkPoints2D_GetBounds_06(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints2D_GetData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPoints2D_GetData_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPoints2D_GetDataType_08(HandleRef pThis);

	/// <summary>
	/// Return the underlying data type. An integer indicating data type is
	/// returned as specified in vtkSetGet.h.
	/// </summary>
	public virtual int GetDataType()
	{
		return vtkPoints2D_GetDataType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints2D_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPoints2D_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints2D_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPoints2D_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints2D_GetNumberOfPoints_11(HandleRef pThis);

	/// <summary>
	/// Return number of points in array.
	/// </summary>
	public long GetNumberOfPoints()
	{
		return vtkPoints2D_GetNumberOfPoints_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints2D_GetPoint_12(HandleRef pThis, long id);

	/// <summary>
	/// Return a pointer to a double point x[2] for a specific id.
	/// WARNING: Just don't use this error-prone method, the returned pointer
	/// and its values are only valid as long as another method invocation is not
	/// performed. Prefer GetPoint() with the return value in argument.
	/// </summary>
	public double[] GetPoint(long id)
	{
		IntPtr intPtr = vtkPoints2D_GetPoint_12(GetCppThis(), id);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_GetPoint_13(HandleRef pThis, long id, IntPtr x);

	/// <summary>
	/// Copy point components into user provided array v[2] for specified id.
	/// </summary>
	public void GetPoint(long id, IntPtr x)
	{
		vtkPoints2D_GetPoint_13(GetCppThis(), id, x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_GetPoints_14(HandleRef pThis, HandleRef ptId, HandleRef fp);

	/// <summary>
	/// Given a list of pt ids, return an array of points.
	/// </summary>
	public void GetPoints(vtkIdList ptId, vtkPoints2D fp)
	{
		vtkPoints2D_GetPoints_14(GetCppThis(), ptId?.GetCppThis() ?? default(HandleRef), fp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints2D_GetVoidPointer_15(HandleRef pThis, int id);

	/// <summary>
	/// Return a void pointer. For image pipeline interface and other
	/// special pointer manipulation.
	/// </summary>
	public IntPtr GetVoidPointer(int id)
	{
		return vtkPoints2D_GetVoidPointer_15(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_Initialize_16(HandleRef pThis);

	/// <summary>
	/// Return object to instantiated state.
	/// </summary>
	public virtual void Initialize()
	{
		vtkPoints2D_Initialize_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints2D_InsertNextPoint_17(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Insert point into next available slot. Returns id of slot.
	/// </summary>
	public long InsertNextPoint(IntPtr x)
	{
		return vtkPoints2D_InsertNextPoint_17(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoints2D_InsertNextPoint_18(HandleRef pThis, double x, double y);

	/// <summary>
	/// Insert point into next available slot. Returns id of slot.
	/// </summary>
	public long InsertNextPoint(double x, double y)
	{
		return vtkPoints2D_InsertNextPoint_18(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_InsertPoint_19(HandleRef pThis, long id, IntPtr x);

	/// <summary>
	/// Insert point into object. Range checking performed and memory
	/// allocated as necessary.
	/// </summary>
	public void InsertPoint(long id, IntPtr x)
	{
		vtkPoints2D_InsertPoint_19(GetCppThis(), id, x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_InsertPoint_20(HandleRef pThis, long id, double x, double y);

	/// <summary>
	/// Insert point into object. Range checking performed and memory
	/// allocated as necessary.
	/// </summary>
	public void InsertPoint(long id, double x, double y)
	{
		vtkPoints2D_InsertPoint_20(GetCppThis(), id, x, y);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoints2D_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPoints2D_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoints2D_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPoints2D_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints2D_New_23(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkPoints2D New(int dataType)
	{
		vtkPoints2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoints2D_New_23(dataType, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints2D_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPoints2D NewInstance()
	{
		vtkPoints2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoints2D_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_RemovePoint_26(HandleRef pThis, long id);

	/// <summary>
	/// Remove point described by its id
	/// </summary>
	public void RemovePoint(long id)
	{
		vtkPoints2D_RemovePoint_26(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_Reset_27(HandleRef pThis);

	/// <summary>
	/// Make object look empty but do not delete memory.
	/// </summary>
	public virtual void Reset()
	{
		vtkPoints2D_Reset_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoints2D_Resize_28(HandleRef pThis, long numPoints);

	/// <summary>
	/// Resize the internal array while conserving the data.  Returns 1 if
	/// resizing succeeded and 0 otherwise.
	/// </summary>
	public int Resize(long numPoints)
	{
		return vtkPoints2D_Resize_28(GetCppThis(), numPoints);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoints2D_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPoints2D SafeDownCast(vtkObjectBase o)
	{
		vtkPoints2D vtkPoints2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoints2D_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2D2 = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2D2.Register(null);
			}
		}
		return vtkPoints2D2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetData_30(HandleRef pThis, HandleRef arg0);

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
		vtkPoints2D_SetData_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataType_31(HandleRef pThis, int dataType);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public virtual void SetDataType(int dataType)
	{
		vtkPoints2D_SetDataType_31(GetCppThis(), dataType);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToBit_32(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToBit()
	{
		vtkPoints2D_SetDataTypeToBit_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToChar_33(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToChar()
	{
		vtkPoints2D_SetDataTypeToChar_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToDouble_34(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToDouble()
	{
		vtkPoints2D_SetDataTypeToDouble_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToFloat_35(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToFloat()
	{
		vtkPoints2D_SetDataTypeToFloat_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToInt_36(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToInt()
	{
		vtkPoints2D_SetDataTypeToInt_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToLong_37(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToLong()
	{
		vtkPoints2D_SetDataTypeToLong_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToShort_38(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToShort()
	{
		vtkPoints2D_SetDataTypeToShort_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToUnsignedChar_39(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToUnsignedChar()
	{
		vtkPoints2D_SetDataTypeToUnsignedChar_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToUnsignedInt_40(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToUnsignedInt()
	{
		vtkPoints2D_SetDataTypeToUnsignedInt_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToUnsignedLong_41(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToUnsignedLong()
	{
		vtkPoints2D_SetDataTypeToUnsignedLong_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetDataTypeToUnsignedShort_42(HandleRef pThis);

	/// <summary>
	/// Specify the underlying data type of the object.
	/// </summary>
	public void SetDataTypeToUnsignedShort()
	{
		vtkPoints2D_SetDataTypeToUnsignedShort_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetNumberOfPoints_43(HandleRef pThis, long numPoints);

	/// <summary>
	/// Specify the number of points for this object to hold. Does an
	/// allocation as well as setting the MaxId ivar. Used in conjunction with
	/// SetPoint() method for fast insertion.
	/// </summary>
	public void SetNumberOfPoints(long numPoints)
	{
		vtkPoints2D_SetNumberOfPoints_43(GetCppThis(), numPoints);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetPoint_44(HandleRef pThis, long id, IntPtr x);

	/// <summary>
	/// Insert point into object. No range checking performed (fast!).
	/// Make sure you use SetNumberOfPoints() to allocate memory prior
	/// to using SetPoint().
	/// </summary>
	public void SetPoint(long id, IntPtr x)
	{
		vtkPoints2D_SetPoint_44(GetCppThis(), id, x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_SetPoint_45(HandleRef pThis, long id, double x, double y);

	/// <summary>
	/// Insert point into object. No range checking performed (fast!).
	/// Make sure you use SetNumberOfPoints() to allocate memory prior
	/// to using SetPoint().
	/// </summary>
	public void SetPoint(long id, double x, double y)
	{
		vtkPoints2D_SetPoint_45(GetCppThis(), id, x, y);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_ShallowCopy_46(HandleRef pThis, HandleRef ad);

	/// <summary>
	/// Different ways to copy data. Shallow copy does reference count (i.e.,
	/// assigns pointers and updates reference count); deep copy runs through
	/// entire data array assigning values.
	/// </summary>
	public virtual void ShallowCopy(vtkPoints2D ad)
	{
		vtkPoints2D_ShallowCopy_46(GetCppThis(), ad?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoints2D_Squeeze_47(HandleRef pThis);

	/// <summary>
	/// Reclaim any extra memory.
	/// </summary>
	public virtual void Squeeze()
	{
		vtkPoints2D_Squeeze_47(GetCppThis());
	}
}
