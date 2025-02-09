using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMultiBlockPLOT3DReader
/// </summary>
/// <remarks>
///    read PLOT3D data files
///
/// vtkMultiBlockPLOT3DReader is a reader object that reads PLOT3D formatted
/// files and generates structured grid(s) on output. PLOT3D is a computer
/// graphics program designed to visualize the grids and solutions of
/// computational fluid dynamics. This reader also supports the variant
/// of the PLOT3D format used by NASA's OVERFLOW CFD software, including
/// full support for all Q variables. Please see the "PLOT3D User's Manual"
/// available from NASA Ames Research Center, Moffett Field CA.
///
/// PLOT3D files consist of a grid file (also known as XYZ file), an
/// optional solution file (also known as a Q file), and an optional function
/// file that contains user created data (currently unsupported). The Q file
/// contains solution information as follows: the four parameters free stream
/// mach number (Fsmach), angle of attack (Alpha), Reynolds number (Re), and
/// total integration time (Time). This information is stored in an array
/// called Properties in the FieldData of each output (tuple 0: fsmach, tuple 1:
/// alpha, tuple 2: re, tuple 3: time). In addition, the solution file contains
/// the flow density (scalar), flow momentum (vector), and flow energy (scalar).
///
/// This reader supports a limited form of time series data which are stored
/// as a series of Q files. Using the AddFileName() method provided by the
/// superclass, one can define a file series. For other cases, for example where
/// the XYZ or function files vary over time, use vtkPlot3DMetaReader.
///
/// The reader can generate additional scalars and vectors (or "functions")
/// from this information. To use vtkMultiBlockPLOT3DReader, you must specify the
/// particular function number for the scalar and vector you want to visualize.
/// This implementation of the reader provides the following functions. The
/// scalar functions are:
///    -1  - don't read or compute any scalars
///    100 - density
///    110 - pressure
///    111 - pressure coefficient (requires Overflow file with Gamma)
///    112 - mach number (requires Overflow file with Gamma)
///    113 - sounds speed (requires Overflow file with Gamma)
///    120 - temperature
///    130 - enthalpy
///    140 - internal energy
///    144 - kinetic energy
///    153 - velocity magnitude
///    163 - stagnation energy
///    170 - entropy
///    184 - swirl
///    211 - vorticity magnitude
///
/// The vector functions are:
///    -1  - don't read or compute any vectors
///    200 - velocity
///    201 - vorticity
///    202 - momentum
///    210 - pressure gradient.
///    212 - strain rate
///
/// (Other functions are described in the PLOT3D spec, but only those listed are
/// implemented here.) Note that by default, this reader creates the density
/// scalar (100), stagnation energy (163) and momentum vector (202) as output.
/// (These are just read in from the solution file.) Please note that the validity
/// of computation is a function of this class's gas constants (R, Gamma) and the
/// equations used. They may not be suitable for your computational domain.
///
/// Additionally, you can read other data and associate it as a vtkDataArray
/// into the output's point attribute data. Use the method AddFunction()
/// to list all the functions that you'd like to read. AddFunction() accepts
/// an integer parameter that defines the function number.
///
/// </remarks>
/// <seealso>
///
/// vtkMultiBlockDataSet vtkStructuredGrid vtkPlot3DMetaReader
/// </seealso>
public class vtkMultiBlockPLOT3DReader : vtkParallelReader
{
	/// <summary>
	/// Set/Get the communicator object (we'll use global World controller
	/// if you don't set a different one).
	/// </summary>
	public enum FILE_BIG_ENDIAN_WrapperEnum
	{
		/// <summary>enum member</summary>
		FILE_BIG_ENDIAN,
		/// <summary>enum member</summary>
		FILE_LITTLE_ENDIAN
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockPLOT3DReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiBlockPLOT3DReader()
	{
		MRClassNameKey = "class vtkMultiBlockPLOT3DReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockPLOT3DReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiBlockPLOT3DReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiBlockPLOT3DReader New()
	{
		vtkMultiBlockPLOT3DReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockPLOT3DReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiBlockPLOT3DReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMultiBlockPLOT3DReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMultiBlockPLOT3DReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_AddFunction_01(HandleRef pThis, int functionNumber);

	/// <summary>
	/// Specify additional functions to read. These are placed into the
	/// point data as data arrays. Later on they can be used by labeling
	/// them as scalars, etc.
	/// </summary>
	public void AddFunction(int functionNumber)
	{
		vtkMultiBlockPLOT3DReader_AddFunction_01(GetCppThis(), functionNumber);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_AddFunctionName_02(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the communicator object (we'll use global World controller
	/// if you don't set a different one).
	/// </summary>
	public void AddFunctionName(string name)
	{
		vtkMultiBlockPLOT3DReader_AddFunctionName_02(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_AutoDetectFormatOff_03(HandleRef pThis);

	/// <summary>
	/// When this option is turned on, the reader will try to figure
	/// out the values of various options such as byte order, byte
	/// count etc. automatically. This options works only for binary
	/// files. When it is turned on, the reader should be able to read
	/// most Plot3D files automatically. The default is OFF for backwards
	/// compatibility reasons. For binary files, it is strongly recommended
	/// that you turn on AutoDetectFormat and leave the other file format
	/// related options untouched.
	/// </summary>
	public virtual void AutoDetectFormatOff()
	{
		vtkMultiBlockPLOT3DReader_AutoDetectFormatOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_AutoDetectFormatOn_04(HandleRef pThis);

	/// <summary>
	/// When this option is turned on, the reader will try to figure
	/// out the values of various options such as byte order, byte
	/// count etc. automatically. This options works only for binary
	/// files. When it is turned on, the reader should be able to read
	/// most Plot3D files automatically. The default is OFF for backwards
	/// compatibility reasons. For binary files, it is strongly recommended
	/// that you turn on AutoDetectFormat and leave the other file format
	/// related options untouched.
	/// </summary>
	public virtual void AutoDetectFormatOn()
	{
		vtkMultiBlockPLOT3DReader_AutoDetectFormatOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_BinaryFileOff_05(HandleRef pThis);

	/// <summary>
	/// Is the file to be read written in binary format (as opposed
	/// to ascii).
	/// </summary>
	public virtual void BinaryFileOff()
	{
		vtkMultiBlockPLOT3DReader_BinaryFileOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_BinaryFileOn_06(HandleRef pThis);

	/// <summary>
	/// Is the file to be read written in binary format (as opposed
	/// to ascii).
	/// </summary>
	public virtual void BinaryFileOn()
	{
		vtkMultiBlockPLOT3DReader_BinaryFileOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_CanReadBinaryFile_07(HandleRef pThis, string fname);

	/// <summary>
	/// Return 1 if the reader can read the given file name. Only meaningful
	/// for binary files.
	/// </summary>
	public virtual int CanReadBinaryFile(string fname)
	{
		return vtkMultiBlockPLOT3DReader_CanReadBinaryFile_07(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_DoublePrecisionOff_08(HandleRef pThis);

	/// <summary>
	/// Is this file in double precision or single precision.
	/// This only matters for binary files.
	/// Default is single.
	/// </summary>
	public virtual void DoublePrecisionOff()
	{
		vtkMultiBlockPLOT3DReader_DoublePrecisionOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_DoublePrecisionOn_09(HandleRef pThis);

	/// <summary>
	/// Is this file in double precision or single precision.
	/// This only matters for binary files.
	/// Default is single.
	/// </summary>
	public virtual void DoublePrecisionOn()
	{
		vtkMultiBlockPLOT3DReader_DoublePrecisionOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_ForceReadOff_10(HandleRef pThis);

	/// <summary>
	/// Try to read a binary file even if the file length seems to be
	/// inconsistent with the header information. Use this with caution,
	/// if the file length is not the same as calculated from the header.
	/// either the file is corrupt or the settings are wrong.
	/// </summary>
	public virtual void ForceReadOff()
	{
		vtkMultiBlockPLOT3DReader_ForceReadOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_ForceReadOn_11(HandleRef pThis);

	/// <summary>
	/// Try to read a binary file even if the file length seems to be
	/// inconsistent with the header information. Use this with caution,
	/// if the file length is not the same as calculated from the header.
	/// either the file is corrupt or the settings are wrong.
	/// </summary>
	public virtual void ForceReadOn()
	{
		vtkMultiBlockPLOT3DReader_ForceReadOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetAutoDetectFormat_12(HandleRef pThis);

	/// <summary>
	/// When this option is turned on, the reader will try to figure
	/// out the values of various options such as byte order, byte
	/// count etc. automatically. This options works only for binary
	/// files. When it is turned on, the reader should be able to read
	/// most Plot3D files automatically. The default is OFF for backwards
	/// compatibility reasons. For binary files, it is strongly recommended
	/// that you turn on AutoDetectFormat and leave the other file format
	/// related options untouched.
	/// </summary>
	public virtual int GetAutoDetectFormat()
	{
		return vtkMultiBlockPLOT3DReader_GetAutoDetectFormat_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetBinaryFile_13(HandleRef pThis);

	/// <summary>
	/// Is the file to be read written in binary format (as opposed
	/// to ascii).
	/// </summary>
	public virtual int GetBinaryFile()
	{
		return vtkMultiBlockPLOT3DReader_GetBinaryFile_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetByteOrder_14(HandleRef pThis);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public virtual int GetByteOrder()
	{
		return vtkMultiBlockPLOT3DReader_GetByteOrder_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetByteOrderAsString_15(HandleRef pThis);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public string GetByteOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader_GetByteOrderAsString_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetController_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the communicator object (we'll use global World controller
	/// if you don't set a different one).
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockPLOT3DReader_GetController_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetDoublePrecision_17(HandleRef pThis);

	/// <summary>
	/// Is this file in double precision or single precision.
	/// This only matters for binary files.
	/// Default is single.
	/// </summary>
	public virtual int GetDoublePrecision()
	{
		return vtkMultiBlockPLOT3DReader_GetDoublePrecision_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetFileName_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the PLOT3D geometry filename.
	/// </summary>
	public string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader_GetFileName_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetFileName_19(HandleRef pThis, int i);

	/// <summary>
	/// Set/Get the PLOT3D geometry filename.
	/// </summary>
	public new string GetFileName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader_GetFileName_19(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetForceRead_20(HandleRef pThis);

	/// <summary>
	/// Try to read a binary file even if the file length seems to be
	/// inconsistent with the header information. Use this with caution,
	/// if the file length is not the same as calculated from the header.
	/// either the file is corrupt or the settings are wrong.
	/// </summary>
	public virtual int GetForceRead()
	{
		return vtkMultiBlockPLOT3DReader_GetForceRead_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetFunctionFileName_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the PLOT3D function filename.
	/// </summary>
	public virtual string GetFunctionFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader_GetFunctionFileName_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMultiBlockPLOT3DReader_GetGamma_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of specific heats. Default is 1.4.
	/// </summary>
	public virtual double GetGamma()
	{
		return vtkMultiBlockPLOT3DReader_GetGamma_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetHasByteCount_23(HandleRef pThis);

	/// <summary>
	/// Were the arrays written with leading and trailing byte counts ?
	/// Usually, files written by a fortran program will contain these
	/// byte counts whereas the ones written by C/C++ won't.
	/// </summary>
	public virtual int GetHasByteCount()
	{
		return vtkMultiBlockPLOT3DReader_GetHasByteCount_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetIBlanking_24(HandleRef pThis);

	/// <summary>
	/// Is there iblanking (point visibility) information in the file.
	/// If there is iblanking arrays, these will be read and assigned
	/// to the PointVisibility array of the output.
	/// </summary>
	public virtual int GetIBlanking()
	{
		return vtkMultiBlockPLOT3DReader_GetIBlanking_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetMultiGrid_25(HandleRef pThis);

	/// <summary>
	/// Does the file to be read contain information about number of
	/// grids. In some PLOT3D files, the first value contains the number
	/// of grids (even if there is only 1). If reading such a file,
	/// set this to true.
	/// </summary>
	public virtual int GetMultiGrid()
	{
		return vtkMultiBlockPLOT3DReader_GetMultiGrid_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiBlockPLOT3DReader_GetNumberOfGenerationsFromBase_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiBlockPLOT3DReader_GetNumberOfGenerationsFromBase_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiBlockPLOT3DReader_GetNumberOfGenerationsFromBaseType_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiBlockPLOT3DReader_GetNumberOfGenerationsFromBaseType_27(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetOutput_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkMultiBlockDataSet GetOutput()
	{
		vtkMultiBlockDataSet vtkMultiBlockDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockPLOT3DReader_GetOutput_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiBlockDataSet2 = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiBlockDataSet2.Register(null);
			}
		}
		return vtkMultiBlockDataSet2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetOutput_29(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkMultiBlockDataSet GetOutput(int arg0)
	{
		vtkMultiBlockDataSet vtkMultiBlockDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockPLOT3DReader_GetOutput_29(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiBlockDataSet2 = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiBlockDataSet2.Register(null);
			}
		}
		return vtkMultiBlockDataSet2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMultiBlockPLOT3DReader_GetPreserveIntermediateFunctions_30(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will preserve intermediate computed
	/// quantities that were not explicitly requested e.g. if `VelocityMagnitude` is
	/// enabled, but not `Velocity`, the reader still needs to compute `Velocity`.
	/// If `PreserveIntermediateFunctions` if false, then the output will not have
	/// `Velocity` array, only the requested `VelocityMagnitude`. This is useful to
	/// avoid using up memory for arrays that are not relevant for the analysis.
	/// </summary>
	public virtual bool GetPreserveIntermediateFunctions()
	{
		return (vtkMultiBlockPLOT3DReader_GetPreserveIntermediateFunctions_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetQFileName_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the PLOT3D solution filename. This adds a filename
	/// using the superclass' AddFileName() method. To read a series
	/// of q files, use the AddFileName() interface directly to add
	/// multiple q filenames in the appropriate order. If the files
	/// are of Overflow format, the reader will read the time values
	/// from the files. Otherwise, it will use an integer sequence.
	/// Use a meta reader to support time values for non-Overflow file
	/// sequences.
	/// </summary>
	public string GetQFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader_GetQFileName_31(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMultiBlockPLOT3DReader_GetR_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the gas constant. Default is 1.0.
	/// </summary>
	public virtual double GetR()
	{
		return vtkMultiBlockPLOT3DReader_GetR_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetScalarFunctionNumber_33(HandleRef pThis);

	/// <summary>
	/// Specify the scalar function to extract. If ==(-1), then no scalar
	/// function is extracted.
	/// </summary>
	public virtual int GetScalarFunctionNumber()
	{
		return vtkMultiBlockPLOT3DReader_GetScalarFunctionNumber_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetTwoDimensionalGeometry_34(HandleRef pThis);

	/// <summary>
	/// If only two-dimensional data was written to the file,
	/// turn this on.
	/// </summary>
	public virtual int GetTwoDimensionalGeometry()
	{
		return vtkMultiBlockPLOT3DReader_GetTwoDimensionalGeometry_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_GetVectorFunctionNumber_35(HandleRef pThis);

	/// <summary>
	/// Specify the vector function to extract. If ==(-1), then no vector
	/// function is extracted.
	/// </summary>
	public virtual int GetVectorFunctionNumber()
	{
		return vtkMultiBlockPLOT3DReader_GetVectorFunctionNumber_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetXYZFileName_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the PLOT3D geometry filename.
	/// </summary>
	public virtual string GetXYZFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader_GetXYZFileName_36(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_HasByteCountOff_37(HandleRef pThis);

	/// <summary>
	/// Were the arrays written with leading and trailing byte counts ?
	/// Usually, files written by a fortran program will contain these
	/// byte counts whereas the ones written by C/C++ won't.
	/// </summary>
	public virtual void HasByteCountOff()
	{
		vtkMultiBlockPLOT3DReader_HasByteCountOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_HasByteCountOn_38(HandleRef pThis);

	/// <summary>
	/// Were the arrays written with leading and trailing byte counts ?
	/// Usually, files written by a fortran program will contain these
	/// byte counts whereas the ones written by C/C++ won't.
	/// </summary>
	public virtual void HasByteCountOn()
	{
		vtkMultiBlockPLOT3DReader_HasByteCountOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_IBlankingOff_39(HandleRef pThis);

	/// <summary>
	/// Is there iblanking (point visibility) information in the file.
	/// If there is iblanking arrays, these will be read and assigned
	/// to the PointVisibility array of the output.
	/// </summary>
	public virtual void IBlankingOff()
	{
		vtkMultiBlockPLOT3DReader_IBlankingOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_IBlankingOn_40(HandleRef pThis);

	/// <summary>
	/// Is there iblanking (point visibility) information in the file.
	/// If there is iblanking arrays, these will be read and assigned
	/// to the PointVisibility array of the output.
	/// </summary>
	public virtual void IBlankingOn()
	{
		vtkMultiBlockPLOT3DReader_IBlankingOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_IsA_41(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiBlockPLOT3DReader_IsA_41(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_IsTypeOf_42(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiBlockPLOT3DReader_IsTypeOf_42(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_MultiGridOff_43(HandleRef pThis);

	/// <summary>
	/// Does the file to be read contain information about number of
	/// grids. In some PLOT3D files, the first value contains the number
	/// of grids (even if there is only 1). If reading such a file,
	/// set this to true.
	/// </summary>
	public virtual void MultiGridOff()
	{
		vtkMultiBlockPLOT3DReader_MultiGridOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_MultiGridOn_44(HandleRef pThis);

	/// <summary>
	/// Does the file to be read contain information about number of
	/// grids. In some PLOT3D files, the first value contains the number
	/// of grids (even if there is only 1). If reading such a file,
	/// set this to true.
	/// </summary>
	public virtual void MultiGridOn()
	{
		vtkMultiBlockPLOT3DReader_MultiGridOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMultiBlockPLOT3DReader NewInstance()
	{
		vtkMultiBlockPLOT3DReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockPLOT3DReader_NewInstance_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiBlockPLOT3DReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_PreserveIntermediateFunctionsOff_47(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will preserve intermediate computed
	/// quantities that were not explicitly requested e.g. if `VelocityMagnitude` is
	/// enabled, but not `Velocity`, the reader still needs to compute `Velocity`.
	/// If `PreserveIntermediateFunctions` if false, then the output will not have
	/// `Velocity` array, only the requested `VelocityMagnitude`. This is useful to
	/// avoid using up memory for arrays that are not relevant for the analysis.
	/// </summary>
	public virtual void PreserveIntermediateFunctionsOff()
	{
		vtkMultiBlockPLOT3DReader_PreserveIntermediateFunctionsOff_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_PreserveIntermediateFunctionsOn_48(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will preserve intermediate computed
	/// quantities that were not explicitly requested e.g. if `VelocityMagnitude` is
	/// enabled, but not `Velocity`, the reader still needs to compute `Velocity`.
	/// If `PreserveIntermediateFunctions` if false, then the output will not have
	/// `Velocity` array, only the requested `VelocityMagnitude`. This is useful to
	/// avoid using up memory for arrays that are not relevant for the analysis.
	/// </summary>
	public virtual void PreserveIntermediateFunctionsOn()
	{
		vtkMultiBlockPLOT3DReader_PreserveIntermediateFunctionsOn_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_ReadArrays_49(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// These methods have to be overwritten from superclass
	/// because Plot3D actually uses the XYZ file to read these.
	/// This is not recognized by the superclass which returns
	/// an error when a filename (Q filename) is not set.
	/// </summary>
	public override int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkMultiBlockPLOT3DReader_ReadArrays_49(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_ReadMesh_50(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// These methods have to be overwritten from superclass
	/// because Plot3D actually uses the XYZ file to read these.
	/// This is not recognized by the superclass which returns
	/// an error when a filename (Q filename) is not set.
	/// </summary>
	public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkMultiBlockPLOT3DReader_ReadMesh_50(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_ReadMetaData_51(HandleRef pThis, HandleRef metadata);

	/// <summary>
	/// These methods have to be overwritten from superclass
	/// because Plot3D actually uses the XYZ file to read these.
	/// This is not recognized by the superclass which returns
	/// an error when a filename (Q filename) is not set.
	/// </summary>
	public override int ReadMetaData(vtkInformation metadata)
	{
		return vtkMultiBlockPLOT3DReader_ReadMetaData_51(GetCppThis(), metadata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockPLOT3DReader_ReadPoints_52(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// These methods have to be overwritten from superclass
	/// because Plot3D actually uses the XYZ file to read these.
	/// This is not recognized by the superclass which returns
	/// an error when a filename (Q filename) is not set.
	/// </summary>
	public override int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkMultiBlockPLOT3DReader_ReadPoints_52(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_RemoveAllFunctions_53(HandleRef pThis);

	/// <summary>
	/// Specify additional functions to read. These are placed into the
	/// point data as data arrays. Later on they can be used by labeling
	/// them as scalars, etc.
	/// </summary>
	public void RemoveAllFunctions()
	{
		vtkMultiBlockPLOT3DReader_RemoveAllFunctions_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_RemoveFunction_54(HandleRef pThis, int arg0);

	/// <summary>
	/// Specify additional functions to read. These are placed into the
	/// point data as data arrays. Later on they can be used by labeling
	/// them as scalars, etc.
	/// </summary>
	public void RemoveFunction(int arg0)
	{
		vtkMultiBlockPLOT3DReader_RemoveFunction_54(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockPLOT3DReader_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiBlockPLOT3DReader SafeDownCast(vtkObjectBase o)
	{
		vtkMultiBlockPLOT3DReader vtkMultiBlockPLOT3DReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockPLOT3DReader_SafeDownCast_55(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiBlockPLOT3DReader2 = (vtkMultiBlockPLOT3DReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiBlockPLOT3DReader2.Register(null);
			}
		}
		return vtkMultiBlockPLOT3DReader2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetAutoDetectFormat_56(HandleRef pThis, int _arg);

	/// <summary>
	/// When this option is turned on, the reader will try to figure
	/// out the values of various options such as byte order, byte
	/// count etc. automatically. This options works only for binary
	/// files. When it is turned on, the reader should be able to read
	/// most Plot3D files automatically. The default is OFF for backwards
	/// compatibility reasons. For binary files, it is strongly recommended
	/// that you turn on AutoDetectFormat and leave the other file format
	/// related options untouched.
	/// </summary>
	public virtual void SetAutoDetectFormat(int _arg)
	{
		vtkMultiBlockPLOT3DReader_SetAutoDetectFormat_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetBinaryFile_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Is the file to be read written in binary format (as opposed
	/// to ascii).
	/// </summary>
	public virtual void SetBinaryFile(int _arg)
	{
		vtkMultiBlockPLOT3DReader_SetBinaryFile_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetByteOrder_58(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public virtual void SetByteOrder(int _arg)
	{
		vtkMultiBlockPLOT3DReader_SetByteOrder_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetByteOrderToBigEndian_59(HandleRef pThis);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public void SetByteOrderToBigEndian()
	{
		vtkMultiBlockPLOT3DReader_SetByteOrderToBigEndian_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetByteOrderToLittleEndian_60(HandleRef pThis);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public void SetByteOrderToLittleEndian()
	{
		vtkMultiBlockPLOT3DReader_SetByteOrderToLittleEndian_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetController_61(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Set/Get the communicator object (we'll use global World controller
	/// if you don't set a different one).
	/// </summary>
	public void SetController(vtkMultiProcessController c)
	{
		vtkMultiBlockPLOT3DReader_SetController_61(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetDoublePrecision_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Is this file in double precision or single precision.
	/// This only matters for binary files.
	/// Default is single.
	/// </summary>
	public virtual void SetDoublePrecision(int _arg)
	{
		vtkMultiBlockPLOT3DReader_SetDoublePrecision_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetFileName_63(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the PLOT3D geometry filename.
	/// </summary>
	public void SetFileName(string name)
	{
		vtkMultiBlockPLOT3DReader_SetFileName_63(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetForceRead_64(HandleRef pThis, int _arg);

	/// <summary>
	/// Try to read a binary file even if the file length seems to be
	/// inconsistent with the header information. Use this with caution,
	/// if the file length is not the same as calculated from the header.
	/// either the file is corrupt or the settings are wrong.
	/// </summary>
	public virtual void SetForceRead(int _arg)
	{
		vtkMultiBlockPLOT3DReader_SetForceRead_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetFunctionFileName_65(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the PLOT3D function filename.
	/// </summary>
	public virtual void SetFunctionFileName(string _arg)
	{
		vtkMultiBlockPLOT3DReader_SetFunctionFileName_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetGamma_66(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio of specific heats. Default is 1.4.
	/// </summary>
	public virtual void SetGamma(double _arg)
	{
		vtkMultiBlockPLOT3DReader_SetGamma_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetHasByteCount_67(HandleRef pThis, int _arg);

	/// <summary>
	/// Were the arrays written with leading and trailing byte counts ?
	/// Usually, files written by a fortran program will contain these
	/// byte counts whereas the ones written by C/C++ won't.
	/// </summary>
	public virtual void SetHasByteCount(int _arg)
	{
		vtkMultiBlockPLOT3DReader_SetHasByteCount_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetIBlanking_68(HandleRef pThis, int _arg);

	/// <summary>
	/// Is there iblanking (point visibility) information in the file.
	/// If there is iblanking arrays, these will be read and assigned
	/// to the PointVisibility array of the output.
	/// </summary>
	public virtual void SetIBlanking(int _arg)
	{
		vtkMultiBlockPLOT3DReader_SetIBlanking_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetMultiGrid_69(HandleRef pThis, int _arg);

	/// <summary>
	/// Does the file to be read contain information about number of
	/// grids. In some PLOT3D files, the first value contains the number
	/// of grids (even if there is only 1). If reading such a file,
	/// set this to true.
	/// </summary>
	public virtual void SetMultiGrid(int _arg)
	{
		vtkMultiBlockPLOT3DReader_SetMultiGrid_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetPreserveIntermediateFunctions_70(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default), the reader will preserve intermediate computed
	/// quantities that were not explicitly requested e.g. if `VelocityMagnitude` is
	/// enabled, but not `Velocity`, the reader still needs to compute `Velocity`.
	/// If `PreserveIntermediateFunctions` if false, then the output will not have
	/// `Velocity` array, only the requested `VelocityMagnitude`. This is useful to
	/// avoid using up memory for arrays that are not relevant for the analysis.
	/// </summary>
	public virtual void SetPreserveIntermediateFunctions(bool _arg)
	{
		vtkMultiBlockPLOT3DReader_SetPreserveIntermediateFunctions_70(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetQFileName_71(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the PLOT3D solution filename. This adds a filename
	/// using the superclass' AddFileName() method. To read a series
	/// of q files, use the AddFileName() interface directly to add
	/// multiple q filenames in the appropriate order. If the files
	/// are of Overflow format, the reader will read the time values
	/// from the files. Otherwise, it will use an integer sequence.
	/// Use a meta reader to support time values for non-Overflow file
	/// sequences.
	/// </summary>
	public void SetQFileName(string name)
	{
		vtkMultiBlockPLOT3DReader_SetQFileName_71(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetR_72(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the gas constant. Default is 1.0.
	/// </summary>
	public virtual void SetR(double _arg)
	{
		vtkMultiBlockPLOT3DReader_SetR_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetScalarFunctionNumber_73(HandleRef pThis, int num);

	/// <summary>
	/// Specify the scalar function to extract. If ==(-1), then no scalar
	/// function is extracted.
	/// </summary>
	public void SetScalarFunctionNumber(int num)
	{
		vtkMultiBlockPLOT3DReader_SetScalarFunctionNumber_73(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetTwoDimensionalGeometry_74(HandleRef pThis, int _arg);

	/// <summary>
	/// If only two-dimensional data was written to the file,
	/// turn this on.
	/// </summary>
	public virtual void SetTwoDimensionalGeometry(int _arg)
	{
		vtkMultiBlockPLOT3DReader_SetTwoDimensionalGeometry_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetVectorFunctionNumber_75(HandleRef pThis, int num);

	/// <summary>
	/// Specify the vector function to extract. If ==(-1), then no vector
	/// function is extracted.
	/// </summary>
	public void SetVectorFunctionNumber(int num)
	{
		vtkMultiBlockPLOT3DReader_SetVectorFunctionNumber_75(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_SetXYZFileName_76(HandleRef pThis, string arg0);

	/// <summary>
	/// Set/Get the PLOT3D geometry filename.
	/// </summary>
	public virtual void SetXYZFileName(string arg0)
	{
		vtkMultiBlockPLOT3DReader_SetXYZFileName_76(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOff_77(HandleRef pThis);

	/// <summary>
	/// If only two-dimensional data was written to the file,
	/// turn this on.
	/// </summary>
	public virtual void TwoDimensionalGeometryOff()
	{
		vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOff_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOn_78(HandleRef pThis);

	/// <summary>
	/// If only two-dimensional data was written to the file,
	/// turn this on.
	/// </summary>
	public virtual void TwoDimensionalGeometryOn()
	{
		vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOn_78(GetCppThis());
	}
}
