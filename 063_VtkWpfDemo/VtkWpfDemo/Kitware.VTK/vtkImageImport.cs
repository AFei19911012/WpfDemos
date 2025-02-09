using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageImport
/// </summary>
/// <remarks>
///    Import data from a C array.
///
/// vtkImageImport provides methods needed to import image data from a source
/// independent of VTK, such as a simple C array or a third-party pipeline.
/// Note that the VTK convention is for the image voxel index (0,0,0) to be
/// the lower-left corner of the image, while most 2D image formats use
/// the upper-left corner.  You can use vtkImageFlip to correct the
/// orientation after the image has been loaded into VTK.
/// Note that is also possible to import the raw data from a Python string
/// instead of from a C array. The array applies on scalar point data only, not
/// on cell data.
/// </remarks>
/// <seealso>
///
/// vtkImageExport
/// </seealso>
public class vtkImageImport : vtkImageAlgorithm
{
	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate IntPtr BufferPointerCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate IntPtr DataExtentCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate IntPtr DirectionCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate int NumberOfComponentsCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate IntPtr OriginCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate int PipelineModifiedCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate void PropagateUpdateExtentCallbackType(IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate IntPtr ScalarTypeCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate IntPtr SpacingCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate void UpdateDataCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate void UpdateInformationCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation on each individual callback.
	/// </summary>
	public delegate IntPtr WholeExtentCallbackType(IntPtr arg0);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageImport";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageImport()
	{
		MRClassNameKey = "class vtkImageImport";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageImport"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageImport(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageImport New()
	{
		vtkImageImport result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageImport_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageImport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageImport()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageImport_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_CopyImportVoidPointer_01(HandleRef pThis, IntPtr ptr, long size);

	/// <summary>
	/// Import data and make an internal copy of it.  If you do not want
	/// VTK to copy the data, then use SetImportVoidPointer instead (do
	/// not use both).  Give the size of the data array in bytes.
	/// </summary>
	public void CopyImportVoidPointer(IntPtr ptr, long size)
	{
		vtkImageImport_CopyImportVoidPointer_01(GetCppThis(), ptr, size);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern BufferPointerCallbackType vtkImageImport_GetBufferPointerCallback_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for getting a pointer to the data buffer of
	/// an image from a third-party pipeline.  The callback should return
	/// a pointer to the beginning of the buffer.  The extent of the
	/// buffer should be set with the DataExtentCallback.
	/// </summary>
	public virtual BufferPointerCallbackType GetBufferPointerCallback()
	{
		return vtkImageImport_GetBufferPointerCallback_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_GetCallbackUserData_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the user data which will be passed as the first argument
	/// to all of the third-party pipeline callbacks.
	/// </summary>
	public virtual IntPtr GetCallbackUserData()
	{
		return vtkImageImport_GetCallbackUserData_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_GetDataDirection_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the direction of the data, i.e. the 3x3 matrix to rotate
	/// the coordinates from index space (ijk) to physical space (xyz).
	/// Default: Identity Matrix (1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0)
	/// </summary>
	public virtual double[] GetDataDirection()
	{
		IntPtr intPtr = vtkImageImport_GetDataDirection_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[9];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_GetDataDirection_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the direction of the data, i.e. the 3x3 matrix to rotate
	/// the coordinates from index space (ijk) to physical space (xyz).
	/// Default: Identity Matrix (1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0)
	/// </summary>
	public virtual void GetDataDirection(IntPtr data)
	{
		vtkImageImport_GetDataDirection_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_GetDataExtent_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the extent of the data buffer.  The dimensions of your data
	/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
	/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
	/// (0,width-1, 0,height-1, 0,0).
	/// </summary>
	public virtual int[] GetDataExtent()
	{
		IntPtr intPtr = vtkImageImport_GetDataExtent_06(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_GetDataExtent_07(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Get/Set the extent of the data buffer.  The dimensions of your data
	/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
	/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
	/// (0,width-1, 0,height-1, 0,0).
	/// </summary>
	public virtual void GetDataExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageImport_GetDataExtent_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_GetDataExtent_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the extent of the data buffer.  The dimensions of your data
	/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
	/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
	/// (0,width-1, 0,height-1, 0,0).
	/// </summary>
	public virtual void GetDataExtent(IntPtr _arg)
	{
		vtkImageImport_GetDataExtent_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DataExtentCallbackType vtkImageImport_GetDataExtentCallback_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for getting the data extent of the input
	/// image from a third-party pipeline.  The callback should return a
	/// vector of six integers describing the extent of the buffered
	/// portion of the image (x1 x2 y1 y2 z1 z2).  The buffer location
	/// should be set with the BufferPointerCallback.
	/// </summary>
	public virtual DataExtentCallbackType GetDataExtentCallback()
	{
		return vtkImageImport_GetDataExtentCallback_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_GetDataOrigin_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
	/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
	/// </summary>
	public virtual double[] GetDataOrigin()
	{
		IntPtr intPtr = vtkImageImport_GetDataOrigin_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_GetDataOrigin_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
	/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageImport_GetDataOrigin_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_GetDataOrigin_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
	/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void GetDataOrigin(IntPtr _arg)
	{
		vtkImageImport_GetDataOrigin_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageImport_GetDataScalarType_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.  This is used
	/// as the scalar type of the Output.  Default: Short.
	/// </summary>
	public virtual int GetDataScalarType()
	{
		return vtkImageImport_GetDataScalarType_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_GetDataScalarTypeAsString_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.  This is used
	/// as the scalar type of the Output.  Default: Short.
	/// </summary>
	public string GetDataScalarTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageImport_GetDataScalarTypeAsString_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_GetDataSpacing_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the spacing (typically in mm) between image voxels.
	/// Default: (1.0, 1.0, 1.0).
	/// </summary>
	public virtual double[] GetDataSpacing()
	{
		IntPtr intPtr = vtkImageImport_GetDataSpacing_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_GetDataSpacing_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the spacing (typically in mm) between image voxels.
	/// Default: (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageImport_GetDataSpacing_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_GetDataSpacing_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the spacing (typically in mm) between image voxels.
	/// Default: (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void GetDataSpacing(IntPtr _arg)
	{
		vtkImageImport_GetDataSpacing_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DirectionCallbackType vtkImageImport_GetDirectionCallback_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for getting the direction of the input image
	/// from a third-party pipeline.  The callback should return a vector
	/// of nine double values describing the rotation from ijk to xyz.
	/// </summary>
	public virtual DirectionCallbackType GetDirectionCallback()
	{
		return vtkImageImport_GetDirectionCallback_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_GetImportVoidPointer_19(HandleRef pThis);

	/// <summary>
	/// Set the pointer from which the image data is imported.  VTK will
	/// not make its own copy of the data, it will access the data directly
	/// from the supplied array.  VTK will not attempt to delete the data
	/// nor modify the data.
	/// </summary>
	public IntPtr GetImportVoidPointer()
	{
		return vtkImageImport_GetImportVoidPointer_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern NumberOfComponentsCallbackType vtkImageImport_GetNumberOfComponentsCallback_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for getting the number of components of the
	/// input image from a third-party pipeline.  The callback should
	/// return an integer with the number of components.
	/// </summary>
	public virtual NumberOfComponentsCallbackType GetNumberOfComponentsCallback()
	{
		return vtkImageImport_GetNumberOfComponentsCallback_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageImport_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageImport_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageImport_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageImport_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageImport_GetNumberOfScalarComponents_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of scalar components, for RGB images this must be 3.
	/// Default: 1.
	/// </summary>
	public virtual int GetNumberOfScalarComponents()
	{
		return vtkImageImport_GetNumberOfScalarComponents_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DirectionCallbackType vtkImageImport_GetOriginCallback_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for getting the origin of the input image
	/// from a third-party pipeline.  The callback should return a vector
	/// of three double values describing the origin (x0 y0 z0).
	/// </summary>
	public virtual DirectionCallbackType GetOriginCallback()
	{
		return vtkImageImport_GetOriginCallback_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern NumberOfComponentsCallbackType vtkImageImport_GetPipelineModifiedCallback_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for checking whether the third-party
	/// pipeline has been modified since the last invocation of the
	/// callback.  The callback should return 1 for modified, and 0 for
	/// not modified.  The first call should always return modified.
	/// </summary>
	public virtual NumberOfComponentsCallbackType GetPipelineModifiedCallback()
	{
		return vtkImageImport_GetPipelineModifiedCallback_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern PropagateUpdateExtentCallbackType vtkImageImport_GetPropagateUpdateExtentCallback_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for propagating the pipeline update extent
	/// to a third-party pipeline.  The callback should take a vector of
	/// six integers describing the extent.  This should cause the
	/// third-party pipeline to provide data which contains at least this
	/// extent after the next UpdateData callback.
	/// </summary>
	public virtual PropagateUpdateExtentCallbackType GetPropagateUpdateExtentCallback()
	{
		return vtkImageImport_GetPropagateUpdateExtentCallback_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_GetScalarArrayName_27(HandleRef pThis);

	/// <summary>
	/// Set/get the scalar array name for this data set. Initial value is
	/// "scalars".
	/// </summary>
	public virtual string GetScalarArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkImageImport_GetScalarArrayName_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ScalarTypeCallbackType vtkImageImport_GetScalarTypeCallback_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for getting the scalar value type of the
	/// input image from a third-party pipeline.  The callback should
	/// return a string with the name of the type.
	/// </summary>
	public virtual ScalarTypeCallbackType GetScalarTypeCallback()
	{
		return vtkImageImport_GetScalarTypeCallback_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DirectionCallbackType vtkImageImport_GetSpacingCallback_29(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for getting the spacing of the input image
	/// from a third-party pipeline.  The callback should return a vector
	/// of three double values describing the spacing (dx dy dz).
	/// </summary>
	public virtual DirectionCallbackType GetSpacingCallback()
	{
		return vtkImageImport_GetSpacingCallback_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern UpdateDataCallbackType vtkImageImport_GetUpdateDataCallback_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for propagating UpdateData calls to a
	/// third-party pipeline.  The callback should make sure the
	/// third-party pipeline is up to date.
	/// </summary>
	public virtual UpdateDataCallbackType GetUpdateDataCallback()
	{
		return vtkImageImport_GetUpdateDataCallback_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern UpdateDataCallbackType vtkImageImport_GetUpdateInformationCallback_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for propagating UpdateInformation calls to a
	/// third-party pipeline.  The callback should make sure that the
	/// third-party pipeline information is up to date.
	/// </summary>
	public virtual UpdateDataCallbackType GetUpdateInformationCallback()
	{
		return vtkImageImport_GetUpdateInformationCallback_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_GetWholeExtent_32(HandleRef pThis);

	/// <summary>
	/// Get/Set the whole extent of the image.  This is the largest possible
	/// extent.  Set the DataExtent to the extent of the image in the buffer
	/// pointed to by the ImportVoidPointer.
	/// </summary>
	public virtual int[] GetWholeExtent()
	{
		IntPtr intPtr = vtkImageImport_GetWholeExtent_32(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_GetWholeExtent_33(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Get/Set the whole extent of the image.  This is the largest possible
	/// extent.  Set the DataExtent to the extent of the image in the buffer
	/// pointed to by the ImportVoidPointer.
	/// </summary>
	public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageImport_GetWholeExtent_33(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_GetWholeExtent_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the whole extent of the image.  This is the largest possible
	/// extent.  Set the DataExtent to the extent of the image in the buffer
	/// pointed to by the ImportVoidPointer.
	/// </summary>
	public virtual void GetWholeExtent(IntPtr _arg)
	{
		vtkImageImport_GetWholeExtent_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DataExtentCallbackType vtkImageImport_GetWholeExtentCallback_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the callback for getting the whole extent of the input
	/// image from a third-party pipeline.  The callback should return a
	/// vector of six integers describing the extent of the whole image
	/// (x1 x2 y1 y2 z1 z2).
	/// </summary>
	public virtual DataExtentCallbackType GetWholeExtentCallback()
	{
		return vtkImageImport_GetWholeExtentCallback_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_InvokeExecuteDataCallbacks_36(HandleRef pThis);

	/// <summary>
	/// Invoke the appropriate callbacks
	/// </summary>
	public void InvokeExecuteDataCallbacks()
	{
		vtkImageImport_InvokeExecuteDataCallbacks_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_InvokeExecuteInformationCallbacks_37(HandleRef pThis);

	/// <summary>
	/// Invoke the appropriate callbacks
	/// </summary>
	public void InvokeExecuteInformationCallbacks()
	{
		vtkImageImport_InvokeExecuteInformationCallbacks_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageImport_InvokePipelineModifiedCallbacks_38(HandleRef pThis);

	/// <summary>
	/// Invoke the appropriate callbacks
	/// </summary>
	public int InvokePipelineModifiedCallbacks()
	{
		return vtkImageImport_InvokePipelineModifiedCallbacks_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_InvokeUpdateInformationCallbacks_39(HandleRef pThis);

	/// <summary>
	/// Invoke the appropriate callbacks
	/// </summary>
	public void InvokeUpdateInformationCallbacks()
	{
		vtkImageImport_InvokeUpdateInformationCallbacks_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageImport_IsA_40(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageImport_IsA_40(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageImport_IsTypeOf_41(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageImport_IsTypeOf_41(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_LegacyCheckWholeExtent_42(HandleRef pThis);

	/// <summary>
	/// Invoke the appropriate callbacks
	/// </summary>
	public void LegacyCheckWholeExtent()
	{
		vtkImageImport_LegacyCheckWholeExtent_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageImport NewInstance()
	{
		vtkImageImport result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageImport_NewInstance_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageImport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageImport_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageImport SafeDownCast(vtkObjectBase o)
	{
		vtkImageImport vtkImageImport2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageImport_SafeDownCast_45(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageImport2 = (vtkImageImport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageImport2.Register(null);
			}
		}
		return vtkImageImport2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetBufferPointerCallback_46(HandleRef pThis, BufferPointerCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for getting a pointer to the data buffer of
	/// an image from a third-party pipeline.  The callback should return
	/// a pointer to the beginning of the buffer.  The extent of the
	/// buffer should be set with the DataExtentCallback.
	/// </summary>
	public virtual void SetBufferPointerCallback(BufferPointerCallbackType _arg)
	{
		vtkImageImport_SetBufferPointerCallback_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetCallbackUserData_47(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the user data which will be passed as the first argument
	/// to all of the third-party pipeline callbacks.
	/// </summary>
	public virtual void SetCallbackUserData(IntPtr _arg)
	{
		vtkImageImport_SetCallbackUserData_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataDirection_48(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the direction of the data, i.e. the 3x3 matrix to rotate
	/// the coordinates from index space (ijk) to physical space (xyz).
	/// Default: Identity Matrix (1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0)
	/// </summary>
	public virtual void SetDataDirection(IntPtr data)
	{
		vtkImageImport_SetDataDirection_48(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataExtent_49(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Get/Set the extent of the data buffer.  The dimensions of your data
	/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
	/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
	/// (0,width-1, 0,height-1, 0,0).
	/// </summary>
	public virtual void SetDataExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkImageImport_SetDataExtent_49(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataExtent_50(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the extent of the data buffer.  The dimensions of your data
	/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
	/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
	/// (0,width-1, 0,height-1, 0,0).
	/// </summary>
	public virtual void SetDataExtent(IntPtr _arg)
	{
		vtkImageImport_SetDataExtent_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataExtentCallback_51(HandleRef pThis, DataExtentCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for getting the data extent of the input
	/// image from a third-party pipeline.  The callback should return a
	/// vector of six integers describing the extent of the buffered
	/// portion of the image (x1 x2 y1 y2 z1 z2).  The buffer location
	/// should be set with the BufferPointerCallback.
	/// </summary>
	public virtual void SetDataExtentCallback(DataExtentCallbackType _arg)
	{
		vtkImageImport_SetDataExtentCallback_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataExtentToWholeExtent_52(HandleRef pThis);

	/// <summary>
	/// Get/Set the extent of the data buffer.  The dimensions of your data
	/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
	/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
	/// (0,width-1, 0,height-1, 0,0).
	/// </summary>
	public void SetDataExtentToWholeExtent()
	{
		vtkImageImport_SetDataExtentToWholeExtent_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataOrigin_53(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
	/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkImageImport_SetDataOrigin_53(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataOrigin_54(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
	/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void SetDataOrigin(IntPtr _arg)
	{
		vtkImageImport_SetDataOrigin_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataScalarType_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.  This is used
	/// as the scalar type of the Output.  Default: Short.
	/// </summary>
	public virtual void SetDataScalarType(int _arg)
	{
		vtkImageImport_SetDataScalarType_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataScalarTypeToDouble_56(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.  This is used
	/// as the scalar type of the Output.  Default: Short.
	/// </summary>
	public void SetDataScalarTypeToDouble()
	{
		vtkImageImport_SetDataScalarTypeToDouble_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataScalarTypeToFloat_57(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.  This is used
	/// as the scalar type of the Output.  Default: Short.
	/// </summary>
	public void SetDataScalarTypeToFloat()
	{
		vtkImageImport_SetDataScalarTypeToFloat_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataScalarTypeToInt_58(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.  This is used
	/// as the scalar type of the Output.  Default: Short.
	/// </summary>
	public void SetDataScalarTypeToInt()
	{
		vtkImageImport_SetDataScalarTypeToInt_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataScalarTypeToShort_59(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.  This is used
	/// as the scalar type of the Output.  Default: Short.
	/// </summary>
	public void SetDataScalarTypeToShort()
	{
		vtkImageImport_SetDataScalarTypeToShort_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataScalarTypeToUnsignedChar_60(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.  This is used
	/// as the scalar type of the Output.  Default: Short.
	/// </summary>
	public void SetDataScalarTypeToUnsignedChar()
	{
		vtkImageImport_SetDataScalarTypeToUnsignedChar_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataScalarTypeToUnsignedShort_61(HandleRef pThis);

	/// <summary>
	/// Set/Get the data type of pixels in the imported data.  This is used
	/// as the scalar type of the Output.  Default: Short.
	/// </summary>
	public void SetDataScalarTypeToUnsignedShort()
	{
		vtkImageImport_SetDataScalarTypeToUnsignedShort_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataSpacing_62(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the spacing (typically in mm) between image voxels.
	/// Default: (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkImageImport_SetDataSpacing_62(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDataSpacing_63(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the spacing (typically in mm) between image voxels.
	/// Default: (1.0, 1.0, 1.0).
	/// </summary>
	public virtual void SetDataSpacing(IntPtr _arg)
	{
		vtkImageImport_SetDataSpacing_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetDirectionCallback_64(HandleRef pThis, DirectionCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for getting the direction of the input image
	/// from a third-party pipeline.  The callback should return a vector
	/// of nine double values describing the rotation from ijk to xyz.
	/// </summary>
	public virtual void SetDirectionCallback(DirectionCallbackType _arg)
	{
		vtkImageImport_SetDirectionCallback_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetImportVoidPointer_65(HandleRef pThis, IntPtr ptr);

	/// <summary>
	/// Set the pointer from which the image data is imported.  VTK will
	/// not make its own copy of the data, it will access the data directly
	/// from the supplied array.  VTK will not attempt to delete the data
	/// nor modify the data.
	/// </summary>
	public void SetImportVoidPointer(IntPtr ptr)
	{
		vtkImageImport_SetImportVoidPointer_65(GetCppThis(), ptr);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetImportVoidPointer_66(HandleRef pThis, IntPtr ptr, int save);

	/// <summary>
	/// Set the pointer from which the image data is imported.  Set save to 1
	/// (the default) unless you want VTK to delete the array via C++ delete
	/// when the vtkImageImport object is deallocated.  VTK will not make its
	/// own copy of the data, it will access the data directly from the
	/// supplied array.
	/// </summary>
	public void SetImportVoidPointer(IntPtr ptr, int save)
	{
		vtkImageImport_SetImportVoidPointer_66(GetCppThis(), ptr, save);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetNumberOfComponentsCallback_67(HandleRef pThis, NumberOfComponentsCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for getting the number of components of the
	/// input image from a third-party pipeline.  The callback should
	/// return an integer with the number of components.
	/// </summary>
	public virtual void SetNumberOfComponentsCallback(NumberOfComponentsCallbackType _arg)
	{
		vtkImageImport_SetNumberOfComponentsCallback_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetNumberOfScalarComponents_68(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of scalar components, for RGB images this must be 3.
	/// Default: 1.
	/// </summary>
	public virtual void SetNumberOfScalarComponents(int _arg)
	{
		vtkImageImport_SetNumberOfScalarComponents_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetOriginCallback_69(HandleRef pThis, DirectionCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for getting the origin of the input image
	/// from a third-party pipeline.  The callback should return a vector
	/// of three double values describing the origin (x0 y0 z0).
	/// </summary>
	public virtual void SetOriginCallback(DirectionCallbackType _arg)
	{
		vtkImageImport_SetOriginCallback_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetPipelineModifiedCallback_70(HandleRef pThis, NumberOfComponentsCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for checking whether the third-party
	/// pipeline has been modified since the last invocation of the
	/// callback.  The callback should return 1 for modified, and 0 for
	/// not modified.  The first call should always return modified.
	/// </summary>
	public virtual void SetPipelineModifiedCallback(NumberOfComponentsCallbackType _arg)
	{
		vtkImageImport_SetPipelineModifiedCallback_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetPropagateUpdateExtentCallback_71(HandleRef pThis, PropagateUpdateExtentCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for propagating the pipeline update extent
	/// to a third-party pipeline.  The callback should take a vector of
	/// six integers describing the extent.  This should cause the
	/// third-party pipeline to provide data which contains at least this
	/// extent after the next UpdateData callback.
	/// </summary>
	public virtual void SetPropagateUpdateExtentCallback(PropagateUpdateExtentCallbackType _arg)
	{
		vtkImageImport_SetPropagateUpdateExtentCallback_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetScalarArrayName_72(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the scalar array name for this data set. Initial value is
	/// "scalars".
	/// </summary>
	public virtual void SetScalarArrayName(string _arg)
	{
		vtkImageImport_SetScalarArrayName_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetScalarTypeCallback_73(HandleRef pThis, ScalarTypeCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for getting the scalar value type of the
	/// input image from a third-party pipeline.  The callback should
	/// return a string with the name of the type.
	/// </summary>
	public virtual void SetScalarTypeCallback(ScalarTypeCallbackType _arg)
	{
		vtkImageImport_SetScalarTypeCallback_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetSpacingCallback_74(HandleRef pThis, DirectionCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for getting the spacing of the input image
	/// from a third-party pipeline.  The callback should return a vector
	/// of three double values describing the spacing (dx dy dz).
	/// </summary>
	public virtual void SetSpacingCallback(DirectionCallbackType _arg)
	{
		vtkImageImport_SetSpacingCallback_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetUpdateDataCallback_75(HandleRef pThis, UpdateDataCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for propagating UpdateData calls to a
	/// third-party pipeline.  The callback should make sure the
	/// third-party pipeline is up to date.
	/// </summary>
	public virtual void SetUpdateDataCallback(UpdateDataCallbackType _arg)
	{
		vtkImageImport_SetUpdateDataCallback_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetUpdateInformationCallback_76(HandleRef pThis, UpdateDataCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for propagating UpdateInformation calls to a
	/// third-party pipeline.  The callback should make sure that the
	/// third-party pipeline information is up to date.
	/// </summary>
	public virtual void SetUpdateInformationCallback(UpdateDataCallbackType _arg)
	{
		vtkImageImport_SetUpdateInformationCallback_76(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetWholeExtent_77(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Get/Set the whole extent of the image.  This is the largest possible
	/// extent.  Set the DataExtent to the extent of the image in the buffer
	/// pointed to by the ImportVoidPointer.
	/// </summary>
	public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkImageImport_SetWholeExtent_77(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetWholeExtent_78(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the whole extent of the image.  This is the largest possible
	/// extent.  Set the DataExtent to the extent of the image in the buffer
	/// pointed to by the ImportVoidPointer.
	/// </summary>
	public virtual void SetWholeExtent(IntPtr _arg)
	{
		vtkImageImport_SetWholeExtent_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageImport_SetWholeExtentCallback_79(HandleRef pThis, DataExtentCallbackType _arg);

	/// <summary>
	/// Set/Get the callback for getting the whole extent of the input
	/// image from a third-party pipeline.  The callback should return a
	/// vector of six integers describing the extent of the whole image
	/// (x1 x2 y1 y2 z1 z2).
	/// </summary>
	public virtual void SetWholeExtentCallback(DataExtentCallbackType _arg)
	{
		vtkImageImport_SetWholeExtentCallback_79(GetCppThis(), _arg);
	}
}
