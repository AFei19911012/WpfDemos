using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageExport
/// </summary>
/// <remarks>
///    Export VTK images to third-party systems.
///
/// vtkImageExport provides a way of exporting image data at the end
/// of a pipeline to a third-party system or to a simple C array.
/// Applications can use this to get direct access to the image data
/// in memory.  A callback interface is provided to allow connection
/// of the VTK pipeline to a third-party pipeline.  This interface
/// conforms to the interface of vtkImageImport.
/// In Python it is possible to use this class to write the image data
/// into a python string that has been pre-allocated to be the correct
/// size.
/// </remarks>
/// <seealso>
///
/// vtkImageImport
/// </seealso>
public class vtkImageExport : vtkImageAlgorithm
{
	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate IntPtr BufferPointerCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate IntPtr DataExtentCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate IntPtr DirectionCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate int NumberOfComponentsCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate IntPtr OriginCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate int PipelineModifiedCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate void PropagateUpdateExtentCallbackType(IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate IntPtr ScalarTypeCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate IntPtr SpacingCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate void UpdateDataCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate void UpdateInformationCallbackType(IntPtr arg0);

	/// <summary>
	/// These are function pointer types for the pipeline connection
	/// callbacks.  See further documentation in vtkImageImport.h.
	/// </summary>
	public delegate IntPtr WholeExtentCallbackType(IntPtr arg0);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageExport";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageExport()
	{
		MRClassNameKey = "class vtkImageExport";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageExport"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageExport(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageExport New()
	{
		vtkImageExport result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageExport_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageExport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageExport()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageExport_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageExport_Export_01(HandleRef pThis);

	/// <summary>
	/// The main interface: update the pipeline and export the image
	/// to the memory pointed to by SetExportVoidPointer().  You can
	/// also specify a void pointer when you call Export().
	/// </summary>
	public void Export()
	{
		vtkImageExport_Export_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_Export_02(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// The main interface: update the pipeline and export the image
	/// to the memory pointed to by SetExportVoidPointer().  You can
	/// also specify a void pointer when you call Export().
	/// </summary>
	public virtual void Export(IntPtr arg0)
	{
		vtkImageExport_Export_02(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern BufferPointerCallbackType vtkImageExport_GetBufferPointerCallback_03(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public BufferPointerCallbackType GetBufferPointerCallback()
	{
		return vtkImageExport_GetBufferPointerCallback_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetCallbackUserData_04(HandleRef pThis);

	/// <summary>
	/// Get the user data that should be passed to the callback functions.
	/// </summary>
	public IntPtr GetCallbackUserData()
	{
		return vtkImageExport_GetCallbackUserData_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_GetDataDimensions_05(HandleRef pThis, IntPtr ptr);

	/// <summary>
	/// Get the (x,y,z) index dimensions of the data.  Please note
	/// that C arrays are indexed in decreasing order, i.e. array[z][y][x].
	/// </summary>
	public void GetDataDimensions(IntPtr ptr)
	{
		vtkImageExport_GetDataDimensions_05(GetCppThis(), ptr);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetDataDimensions_06(HandleRef pThis);

	/// <summary>
	/// Get the (x,y,z) index dimensions of the data.  Please note
	/// that C arrays are indexed in decreasing order, i.e. array[z][y][x].
	/// </summary>
	public int[] GetDataDimensions()
	{
		IntPtr intPtr = vtkImageExport_GetDataDimensions_06(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetDataDirection_07(HandleRef pThis);

	/// <summary>
	/// Get miscellaneous additional information about the data.
	/// </summary>
	public IntPtr GetDataDirection()
	{
		return vtkImageExport_GetDataDirection_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_GetDataDirection_08(HandleRef pThis, IntPtr ptr);

	/// <summary>
	/// Get miscellaneous additional information about the data.
	/// </summary>
	public void GetDataDirection(IntPtr ptr)
	{
		vtkImageExport_GetDataDirection_08(GetCppThis(), ptr);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetDataExtent_09(HandleRef pThis);

	/// <summary>
	/// Get miscellaneous additional information about the data.
	/// </summary>
	public int[] GetDataExtent()
	{
		IntPtr intPtr = vtkImageExport_GetDataExtent_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_GetDataExtent_10(HandleRef pThis, IntPtr ptr);

	/// <summary>
	/// Get miscellaneous additional information about the data.
	/// </summary>
	public void GetDataExtent(IntPtr ptr)
	{
		vtkImageExport_GetDataExtent_10(GetCppThis(), ptr);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DataExtentCallbackType vtkImageExport_GetDataExtentCallback_11(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public DataExtentCallbackType GetDataExtentCallback()
	{
		return vtkImageExport_GetDataExtentCallback_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageExport_GetDataMemorySize_12(HandleRef pThis);

	/// <summary>
	/// Get the number of bytes required for the output C array.
	/// </summary>
	public long GetDataMemorySize()
	{
		return vtkImageExport_GetDataMemorySize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageExport_GetDataNumberOfScalarComponents_13(HandleRef pThis);

	/// <summary>
	/// Get the number of scalar components of the data.  Please note that
	/// when you index into a C array, the scalar component index comes
	/// last, i.e. array[z][y][x][c].
	/// </summary>
	public int GetDataNumberOfScalarComponents()
	{
		return vtkImageExport_GetDataNumberOfScalarComponents_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetDataOrigin_14(HandleRef pThis);

	/// <summary>
	/// Get miscellaneous additional information about the data.
	/// </summary>
	public double[] GetDataOrigin()
	{
		IntPtr intPtr = vtkImageExport_GetDataOrigin_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_GetDataOrigin_15(HandleRef pThis, IntPtr ptr);

	/// <summary>
	/// Get miscellaneous additional information about the data.
	/// </summary>
	public void GetDataOrigin(IntPtr ptr)
	{
		vtkImageExport_GetDataOrigin_15(GetCppThis(), ptr);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageExport_GetDataScalarType_16(HandleRef pThis);

	/// <summary>
	/// Get the scalar type of the data.  The scalar type of the C array
	/// must match the scalar type of the data.
	/// </summary>
	public int GetDataScalarType()
	{
		return vtkImageExport_GetDataScalarType_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetDataScalarTypeAsString_17(HandleRef pThis);

	/// <summary>
	/// Get the scalar type of the data.  The scalar type of the C array
	/// must match the scalar type of the data.
	/// </summary>
	public string GetDataScalarTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageExport_GetDataScalarTypeAsString_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetDataSpacing_18(HandleRef pThis);

	/// <summary>
	/// Get miscellaneous additional information about the data.
	/// </summary>
	public double[] GetDataSpacing()
	{
		IntPtr intPtr = vtkImageExport_GetDataSpacing_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_GetDataSpacing_19(HandleRef pThis, IntPtr ptr);

	/// <summary>
	/// Get miscellaneous additional information about the data.
	/// </summary>
	public void GetDataSpacing(IntPtr ptr)
	{
		vtkImageExport_GetDataSpacing_19(GetCppThis(), ptr);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DirectionCallbackType vtkImageExport_GetDirectionCallback_20(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public DirectionCallbackType GetDirectionCallback()
	{
		return vtkImageExport_GetDirectionCallback_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetExportVoidPointer_21(HandleRef pThis);

	/// <summary>
	/// Set the void pointer of the C array to export the data to.
	/// From python, you can specify a pointer to a string that is
	/// large enough to hold the data.
	/// </summary>
	public IntPtr GetExportVoidPointer()
	{
		return vtkImageExport_GetExportVoidPointer_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageExport_GetImageLowerLeft_22(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the data goes to the exported memory starting
	/// in the lower left corner or upper left corner.  Default: On.
	/// When this flag is Off, the image will be flipped vertically
	/// before it is exported.
	/// WARNING: this flag is used only with the Export() method,
	/// it is ignored by GetPointerToData().
	/// </summary>
	public virtual int GetImageLowerLeft()
	{
		return vtkImageExport_GetImageLowerLeft_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetInput_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input object from the image pipeline.
	/// </summary>
	public new vtkImageData GetInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageExport_GetInput_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern NumberOfComponentsCallbackType vtkImageExport_GetNumberOfComponentsCallback_24(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public NumberOfComponentsCallbackType GetNumberOfComponentsCallback()
	{
		return vtkImageExport_GetNumberOfComponentsCallback_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageExport_GetNumberOfGenerationsFromBase_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageExport_GetNumberOfGenerationsFromBase_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageExport_GetNumberOfGenerationsFromBaseType_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageExport_GetNumberOfGenerationsFromBaseType_26(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DirectionCallbackType vtkImageExport_GetOriginCallback_27(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public DirectionCallbackType GetOriginCallback()
	{
		return vtkImageExport_GetOriginCallback_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern NumberOfComponentsCallbackType vtkImageExport_GetPipelineModifiedCallback_28(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public NumberOfComponentsCallbackType GetPipelineModifiedCallback()
	{
		return vtkImageExport_GetPipelineModifiedCallback_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_GetPointerToData_29(HandleRef pThis);

	/// <summary>
	/// An alternative to Export(): Use with caution.   Update the
	/// pipeline and return a pointer to the image memory.  The
	/// pointer is only valid until the next time that the pipeline
	/// is updated.
	/// WARNING: This method ignores the ImageLowerLeft flag.
	/// </summary>
	public IntPtr GetPointerToData()
	{
		return vtkImageExport_GetPointerToData_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern PropagateUpdateExtentCallbackType vtkImageExport_GetPropagateUpdateExtentCallback_30(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public PropagateUpdateExtentCallbackType GetPropagateUpdateExtentCallback()
	{
		return vtkImageExport_GetPropagateUpdateExtentCallback_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ScalarTypeCallbackType vtkImageExport_GetScalarTypeCallback_31(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public ScalarTypeCallbackType GetScalarTypeCallback()
	{
		return vtkImageExport_GetScalarTypeCallback_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DirectionCallbackType vtkImageExport_GetSpacingCallback_32(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public DirectionCallbackType GetSpacingCallback()
	{
		return vtkImageExport_GetSpacingCallback_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern UpdateDataCallbackType vtkImageExport_GetUpdateDataCallback_33(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public UpdateDataCallbackType GetUpdateDataCallback()
	{
		return vtkImageExport_GetUpdateDataCallback_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern UpdateDataCallbackType vtkImageExport_GetUpdateInformationCallback_34(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public UpdateDataCallbackType GetUpdateInformationCallback()
	{
		return vtkImageExport_GetUpdateInformationCallback_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DataExtentCallbackType vtkImageExport_GetWholeExtentCallback_35(HandleRef pThis);

	/// <summary>
	/// Get pointers to the pipeline interface callbacks.
	/// </summary>
	public DataExtentCallbackType GetWholeExtentCallback()
	{
		return vtkImageExport_GetWholeExtentCallback_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_ImageLowerLeftOff_36(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the data goes to the exported memory starting
	/// in the lower left corner or upper left corner.  Default: On.
	/// When this flag is Off, the image will be flipped vertically
	/// before it is exported.
	/// WARNING: this flag is used only with the Export() method,
	/// it is ignored by GetPointerToData().
	/// </summary>
	public virtual void ImageLowerLeftOff()
	{
		vtkImageExport_ImageLowerLeftOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_ImageLowerLeftOn_37(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the data goes to the exported memory starting
	/// in the lower left corner or upper left corner.  Default: On.
	/// When this flag is Off, the image will be flipped vertically
	/// before it is exported.
	/// WARNING: this flag is used only with the Export() method,
	/// it is ignored by GetPointerToData().
	/// </summary>
	public virtual void ImageLowerLeftOn()
	{
		vtkImageExport_ImageLowerLeftOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageExport_IsA_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageExport_IsA_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageExport_IsTypeOf_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageExport_IsTypeOf_39(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageExport NewInstance()
	{
		vtkImageExport result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageExport_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageExport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageExport_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageExport SafeDownCast(vtkObjectBase o)
	{
		vtkImageExport vtkImageExport2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageExport_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageExport2 = (vtkImageExport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageExport2.Register(null);
			}
		}
		return vtkImageExport2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_SetExportVoidPointer_43(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set the void pointer of the C array to export the data to.
	/// From python, you can specify a pointer to a string that is
	/// large enough to hold the data.
	/// </summary>
	public void SetExportVoidPointer(IntPtr arg0)
	{
		vtkImageExport_SetExportVoidPointer_43(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageExport_SetImageLowerLeft_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether the data goes to the exported memory starting
	/// in the lower left corner or upper left corner.  Default: On.
	/// When this flag is Off, the image will be flipped vertically
	/// before it is exported.
	/// WARNING: this flag is used only with the Export() method,
	/// it is ignored by GetPointerToData().
	/// </summary>
	public virtual void SetImageLowerLeft(int _arg)
	{
		vtkImageExport_SetImageLowerLeft_44(GetCppThis(), _arg);
	}
}
