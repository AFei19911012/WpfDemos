using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSLACReader
///
///
///
/// A reader for a data format used by Omega3p, Tau3p, and several other tools
/// used at the Standford Linear Accelerator Center (SLAC).  The underlying
/// format uses netCDF to store arrays, but also imposes several conventions
/// to form an unstructured grid of elements.
///
/// </summary>
public class vtkSLACReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Simple class used internally for holding midpoint information.
	/// </summary>
	public enum NUM_OUTPUTS_WrapperEnum
	{
		/// <summary>enum member</summary>
		NUM_OUTPUTS = 2,
		/// <summary>enum member</summary>
		SURFACE_OUTPUT = 0,
		/// <summary>enum member</summary>
		VOLUME_OUTPUT = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSLACReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSLACReader()
	{
		MRClassNameKey = "class vtkSLACReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSLACReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSLACReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSLACReader New()
	{
		vtkSLACReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSLACReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSLACReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSLACReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_AddModeFileName_01(HandleRef pThis, string fname);

	/// <summary>
	/// There may be one mode file (usually for actual modes) or multiple mode
	/// files (which usually actually represent time series).  These methods
	/// set and clear the list of mode files (which can be a single mode file).
	/// </summary>
	public virtual void AddModeFileName(string fname)
	{
		vtkSLACReader_AddModeFileName_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACReader_CanReadFile_02(string filename);

	/// <summary>
	/// Returns true if the given file can be read by this reader.
	/// </summary>
	public static int CanReadFile(string filename)
	{
		return vtkSLACReader_CanReadFile_02(filename);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_GetFrequencyScales_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// NOTE: This is not thread-safe.
	/// </summary>
	public virtual vtkDoubleArray GetFrequencyScales()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACReader_GetFrequencyScales_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_GetMeshFileName_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetMeshFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSLACReader_GetMeshFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_GetModeFileName_05(HandleRef pThis, uint idx);

	/// <summary>
	/// There may be one mode file (usually for actual modes) or multiple mode
	/// files (which usually actually represent time series).  These methods
	/// set and clear the list of mode files (which can be a single mode file).
	/// </summary>
	public virtual string GetModeFileName(uint idx)
	{
		return Marshal.PtrToStringAnsi(vtkSLACReader_GetModeFileName_05(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSLACReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSLACReader_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSLACReader_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSLACReader_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkSLACReader_GetNumberOfModeFileNames_08(HandleRef pThis);

	/// <summary>
	/// There may be one mode file (usually for actual modes) or multiple mode
	/// files (which usually actually represent time series).  These methods
	/// set and clear the list of mode files (which can be a single mode file).
	/// </summary>
	public virtual uint GetNumberOfModeFileNames()
	{
		return vtkSLACReader_GetNumberOfModeFileNames_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACReader_GetNumberOfVariableArrays_09(HandleRef pThis);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual int GetNumberOfVariableArrays()
	{
		return vtkSLACReader_GetNumberOfVariableArrays_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_GetPhaseShifts_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// NOTE: This is not thread-safe.
	/// </summary>
	public virtual vtkDoubleArray GetPhaseShifts()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACReader_GetPhaseShifts_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACReader_GetReadExternalSurface_11(HandleRef pThis);

	/// <summary>
	/// If on, reads the external surfaces of the data set.  Set to on by default.
	/// </summary>
	public virtual int GetReadExternalSurface()
	{
		return vtkSLACReader_GetReadExternalSurface_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACReader_GetReadInternalVolume_12(HandleRef pThis);

	/// <summary>
	/// If on, reads the internal volume of the data set.  Set to off by default.
	/// </summary>
	public virtual int GetReadInternalVolume()
	{
		return vtkSLACReader_GetReadInternalVolume_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACReader_GetReadMidpoints_13(HandleRef pThis);

	/// <summary>
	/// If on, reads midpoint information for external surfaces and builds
	/// quadratic surface triangles.  Set to on by default.
	/// </summary>
	public virtual int GetReadMidpoints()
	{
		return vtkSLACReader_GetReadMidpoints_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_GetVariableArrayName_14(HandleRef pThis, int index);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual string GetVariableArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkSLACReader_GetVariableArrayName_14(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACReader_GetVariableArrayStatus_15(HandleRef pThis, string name);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual int GetVariableArrayStatus(string name)
	{
		return vtkSLACReader_GetVariableArrayStatus_15(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_IS_EXTERNAL_SURFACE_16(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This key is attached to the metadata information of all data sets in the
	/// output that are part of the external surface.
	/// </summary>
	public static vtkInformationIntegerKey IS_EXTERNAL_SURFACE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACReader_IS_EXTERNAL_SURFACE_16(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_IS_INTERNAL_VOLUME_17(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This key is attached to the metadata information of all data sets in the
	/// output that are part of the internal volume.
	/// </summary>
	public static vtkInformationIntegerKey IS_INTERNAL_VOLUME()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACReader_IS_INTERNAL_VOLUME_17(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACReader_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSLACReader_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACReader_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSLACReader_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSLACReader NewInstance()
	{
		vtkSLACReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACReader_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSLACReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_POINTS_22(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// All the data sets stored in the multiblock output share the same point
	/// data.  For convenience, the point coordinates (vtkPoints) and point data
	/// (vtkPointData) are saved under these keys in the vtkInformation of the
	/// output data set.
	/// </summary>
	public static vtkInformationObjectBaseKey POINTS()
	{
		vtkInformationObjectBaseKey vtkInformationObjectBaseKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACReader_POINTS_22(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseKey2 = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseKey2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_POINT_DATA_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// All the data sets stored in the multiblock output share the same point
	/// data.  For convenience, the point coordinates (vtkPoints) and point data
	/// (vtkPointData) are saved under these keys in the vtkInformation of the
	/// output data set.
	/// </summary>
	public static vtkInformationObjectBaseKey POINT_DATA()
	{
		vtkInformationObjectBaseKey vtkInformationObjectBaseKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACReader_POINT_DATA_23(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseKey2 = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseKey2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_ReadExternalSurfaceOff_24(HandleRef pThis);

	/// <summary>
	/// If on, reads the external surfaces of the data set.  Set to on by default.
	/// </summary>
	public virtual void ReadExternalSurfaceOff()
	{
		vtkSLACReader_ReadExternalSurfaceOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_ReadExternalSurfaceOn_25(HandleRef pThis);

	/// <summary>
	/// If on, reads the external surfaces of the data set.  Set to on by default.
	/// </summary>
	public virtual void ReadExternalSurfaceOn()
	{
		vtkSLACReader_ReadExternalSurfaceOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_ReadInternalVolumeOff_26(HandleRef pThis);

	/// <summary>
	/// If on, reads the internal volume of the data set.  Set to off by default.
	/// </summary>
	public virtual void ReadInternalVolumeOff()
	{
		vtkSLACReader_ReadInternalVolumeOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_ReadInternalVolumeOn_27(HandleRef pThis);

	/// <summary>
	/// If on, reads the internal volume of the data set.  Set to off by default.
	/// </summary>
	public virtual void ReadInternalVolumeOn()
	{
		vtkSLACReader_ReadInternalVolumeOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_ReadMidpointsOff_28(HandleRef pThis);

	/// <summary>
	/// If on, reads midpoint information for external surfaces and builds
	/// quadratic surface triangles.  Set to on by default.
	/// </summary>
	public virtual void ReadMidpointsOff()
	{
		vtkSLACReader_ReadMidpointsOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_ReadMidpointsOn_29(HandleRef pThis);

	/// <summary>
	/// If on, reads midpoint information for external surfaces and builds
	/// quadratic surface triangles.  Set to on by default.
	/// </summary>
	public virtual void ReadMidpointsOn()
	{
		vtkSLACReader_ReadMidpointsOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_RemoveAllModeFileNames_30(HandleRef pThis);

	/// <summary>
	/// There may be one mode file (usually for actual modes) or multiple mode
	/// files (which usually actually represent time series).  These methods
	/// set and clear the list of mode files (which can be a single mode file).
	/// </summary>
	public virtual void RemoveAllModeFileNames()
	{
		vtkSLACReader_RemoveAllModeFileNames_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_ResetFrequencyScales_31(HandleRef pThis);

	/// <summary>
	/// Sets the scale factor for each mode. Each scale factor is reset to 1.
	/// </summary>
	public virtual void ResetFrequencyScales()
	{
		vtkSLACReader_ResetFrequencyScales_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_ResetPhaseShifts_32(HandleRef pThis);

	/// <summary>
	/// Sets the phase offset for each mode. Each shift is reset to 0.
	/// </summary>
	public virtual void ResetPhaseShifts()
	{
		vtkSLACReader_ResetPhaseShifts_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACReader_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSLACReader SafeDownCast(vtkObjectBase o)
	{
		vtkSLACReader vtkSLACReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACReader_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSLACReader2 = (vtkSLACReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSLACReader2.Register(null);
			}
		}
		return vtkSLACReader2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_SetFrequencyScale_34(HandleRef pThis, int index, double scale);

	/// <summary>
	/// Sets the scale factor for each mode. Each scale factor is reset to 1.
	/// </summary>
	public virtual void SetFrequencyScale(int index, double scale)
	{
		vtkSLACReader_SetFrequencyScale_34(GetCppThis(), index, scale);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_SetMeshFileName_35(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetMeshFileName(string _arg)
	{
		vtkSLACReader_SetMeshFileName_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_SetPhaseShift_36(HandleRef pThis, int index, double shift);

	/// <summary>
	/// Sets the phase offset for each mode. Each shift is reset to 0.
	/// </summary>
	public virtual void SetPhaseShift(int index, double shift)
	{
		vtkSLACReader_SetPhaseShift_36(GetCppThis(), index, shift);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_SetReadExternalSurface_37(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, reads the external surfaces of the data set.  Set to on by default.
	/// </summary>
	public virtual void SetReadExternalSurface(int _arg)
	{
		vtkSLACReader_SetReadExternalSurface_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_SetReadInternalVolume_38(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, reads the internal volume of the data set.  Set to off by default.
	/// </summary>
	public virtual void SetReadInternalVolume(int _arg)
	{
		vtkSLACReader_SetReadInternalVolume_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_SetReadMidpoints_39(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, reads midpoint information for external surfaces and builds
	/// quadratic surface triangles.  Set to on by default.
	/// </summary>
	public virtual void SetReadMidpoints(int _arg)
	{
		vtkSLACReader_SetReadMidpoints_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACReader_SetVariableArrayStatus_40(HandleRef pThis, string name, int status);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual void SetVariableArrayStatus(string name, int status)
	{
		vtkSLACReader_SetVariableArrayStatus_40(GetCppThis(), name, status);
	}
}
