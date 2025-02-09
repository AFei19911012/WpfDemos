using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlot3DMetaReader
/// </summary>
/// <remarks>
///    reads meta-files points to PLOT3D files
///
/// The main goal of this reader is to make it easy to read PLOT3D files,
/// specifically time series of PLOT3D files. PLOT3D files can take many
/// different forms based on their content. Unfortunately, it is not a
/// self-describing format therefore the user needs to pass information
/// about the contents of the file to the reader. Normally, this is done
/// by setting a number of member variables. The goal of this reader is
/// to provide a simple format that enable the writer of the PLOT3D file
/// to describe its settings as well as group a number of files as a time
/// series. Note that for binary files, the auto-detect-format option,
/// which is on by default negates the need to specify most other option.
/// However, this reader is still very useful when trying to read file
/// series even for binary files. The format for this meta-file is very simple
/// and is based on JSON (there is no need to know anything about JSON to
/// understand this format). Below is an example with comments (followed by //)
/// that describe the format. Note that the PLOT3D file names are relative
/// to the location of the meta-file unless they start with a leading /.
///
/// \verbatim
/// {
/// "auto-detect-format" : true // Tells the reader to try to figure out the format automatically.
/// Only works
///                             // with binary file. This is on by default, negating the need for
/// most other
///                             // options for binary files (format, byte-order, precision,
/// multi-grid,
///                             // blanking, 2D).
/// "format" : "binary",  // Is this a binary or ascii file, values : binary, ascii
/// "byte-order" : "big", // Byte order for binary files, values : little, big (denoting little or
/// big endian) "precision" : 32,     // Precision of floating point values, can be 32 or 64 (bits)
/// "multi-grid" : false, // Is this a multi-grid file, values: true, false
/// "language" : "C",     // Which language was this file written in, values : C, fortran. This is
///                       // used to determine if an binary PLOT3D file contains byte counts, used by
///                       // Fortran IO routines.
/// "blanking" : false,   // Does this file have blanking information (iblanks), values : true, false
/// "2D" : false,         // Is this a 2D dataset, values : true, false
/// "R" : 8.314,          // The value of the gas constant, default is 1.0. Set this according to the
/// dimensions you use "gamma" : 1.4,        // Ratio of specific heats. Default is 1.4. "functions":
/// [ 110, 200, 201 ],  // Additional derived values to calculate. This is an array of integers
/// formatted
///                                  // as [ value, value, value, ...]
/// "filenames" : [     // List of xyz (geometry) and q (value) file names along with the time
/// values.
///                     // This is an array which contains items in the format:
///                     // {"time" : values, "xyz" : "xyz file name", "q" : "q file name", "function"
/// : "function file name"}
///                     // Note that q and function are optional. Also, you can repeat the same file
/// name for xyz or q
///                     // if they don't change over time. The reader will not read files
/// unnecessarily. { "time" : 3.5, "xyz" : "combxyz.bin", "q" : "combq.1.bin", "function" :
/// "combf.1.bin" }, { "time" : 4.5, "xyz" : "combxyz.bin", "q" : "combq.2.bin", "function" :
/// "combf.2.bin" }
/// ],
/// "function-names" : ["density", "velocity_x", "temperature"]
///                   // list of names of functions in function files
/// }
/// \endverbatim
///
/// This reader leverages vtkMultiBlockPLOT3DReader to do the actual
/// reading so you may want to refer to the documentation of
/// vtkMultiBlockPLOT3DReader about the details of some of these
/// parameters including the function numbers for derived value
/// calculation.
///
/// </remarks>
/// <seealso>
///
/// vtkMultiBlockPLOT3DReader
/// </seealso>
public class vtkPlot3DMetaReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlot3DMetaReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlot3DMetaReader()
	{
		MRClassNameKey = "class vtkPlot3DMetaReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlot3DMetaReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlot3DMetaReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot3DMetaReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlot3DMetaReader New()
	{
		vtkPlot3DMetaReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot3DMetaReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlot3DMetaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPlot3DMetaReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlot3DMetaReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlot3DMetaReader_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the meta PLOT3D filename. See the class documentation for
	/// format details.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkPlot3DMetaReader_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlot3DMetaReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlot3DMetaReader_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlot3DMetaReader_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlot3DMetaReader_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlot3DMetaReader_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlot3DMetaReader_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlot3DMetaReader_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlot3DMetaReader_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot3DMetaReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlot3DMetaReader NewInstance()
	{
		vtkPlot3DMetaReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot3DMetaReader_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlot3DMetaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot3DMetaReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlot3DMetaReader SafeDownCast(vtkObjectBase o)
	{
		vtkPlot3DMetaReader vtkPlot3DMetaReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot3DMetaReader_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlot3DMetaReader2 = (vtkPlot3DMetaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlot3DMetaReader2.Register(null);
			}
		}
		return vtkPlot3DMetaReader2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3DMetaReader_SetFileName_09(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the meta PLOT3D filename. See the class documentation for
	/// format details.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkPlot3DMetaReader_SetFileName_09(GetCppThis(), _arg);
	}
}
