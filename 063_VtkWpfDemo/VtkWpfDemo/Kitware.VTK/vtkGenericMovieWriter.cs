using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericMovieWriter
/// </summary>
/// <remarks>
///    an abstract movie writer class.
///
/// vtkGenericMovieWriter is the abstract base class for several movie
/// writers. The input type is a vtkImageData. The Start() method will
/// open and create the file, the Write() method will output a frame to
/// the file (i.e. the contents of the vtkImageData), End() will finalize
/// and close the file.
/// </remarks>
/// <seealso>
///
/// vtkAVIWriter
/// </seealso>
public abstract class vtkGenericMovieWriter : vtkImageAlgorithm
{
	/// <summary>
	/// Converts vtkErrorCodes and vtkGenericMovieWriter errors to strings.
	/// </summary>
	public enum MovieWriterErrorIds
	{
		/// <summary>enum member</summary>
		CanNotCompress = 40003,
		/// <summary>enum member</summary>
		CanNotFormat = 40004,
		/// <summary>enum member</summary>
		ChangedResolutionError = 40005,
		/// <summary>enum member</summary>
		InitError = 40001,
		/// <summary>enum member</summary>
		NoInputError = 40002,
		/// <summary>enum member</summary>
		UserError = 40000
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericMovieWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericMovieWriter()
	{
		MRClassNameKey = "class vtkGenericMovieWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericMovieWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericMovieWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericMovieWriter_End_01(HandleRef pThis);

	/// <summary>
	/// These methods start writing an Movie file, write a frame to the file
	/// and then end the writing process.
	/// </summary>
	public virtual void End()
	{
		vtkGenericMovieWriter_End_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericMovieWriter_GetError_02(HandleRef pThis);

	/// <summary>
	/// Was there an error on the last write performed?
	/// </summary>
	public virtual int GetError()
	{
		return vtkGenericMovieWriter_GetError_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericMovieWriter_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Specify file name of avi file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkGenericMovieWriter_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericMovieWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericMovieWriter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericMovieWriter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericMovieWriter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericMovieWriter_GetStringFromErrorCode_06(uint error);

	/// <summary>
	/// Converts vtkErrorCodes and vtkGenericMovieWriter errors to strings.
	/// </summary>
	public static string GetStringFromErrorCode(uint error)
	{
		return Marshal.PtrToStringAnsi(vtkGenericMovieWriter_GetStringFromErrorCode_06(error));
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericMovieWriter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericMovieWriter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericMovieWriter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericMovieWriter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericMovieWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericMovieWriter NewInstance()
	{
		vtkGenericMovieWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericMovieWriter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericMovieWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericMovieWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericMovieWriter SafeDownCast(vtkObjectBase o)
	{
		vtkGenericMovieWriter vtkGenericMovieWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericMovieWriter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericMovieWriter2 = (vtkGenericMovieWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericMovieWriter2.Register(null);
			}
		}
		return vtkGenericMovieWriter2;
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericMovieWriter_SetFileName_11(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of avi file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkGenericMovieWriter_SetFileName_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericMovieWriter_Start_12(HandleRef pThis);

	/// <summary>
	/// These methods start writing an Movie file, write a frame to the file
	/// and then end the writing process.
	/// </summary>
	public virtual void Start()
	{
		vtkGenericMovieWriter_Start_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericMovieWriter_Write_13(HandleRef pThis);

	/// <summary>
	/// These methods start writing an Movie file, write a frame to the file
	/// and then end the writing process.
	/// </summary>
	public virtual void Write()
	{
		vtkGenericMovieWriter_Write_13(GetCppThis());
	}
}
