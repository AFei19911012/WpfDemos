using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkErrorCode
/// </summary>
/// <remarks>
///    superclass for error codes
///
/// vtkErrorCode is an mechanism for (currently) reader object to
/// return errors during reading file.
/// </remarks>
public class vtkErrorCode : WrappedObject
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum ErrorIds
	{
		/// <summary>enum member</summary>
		CannotOpenFileError = 20002,
		/// <summary>enum member</summary>
		FileFormatError = 20005,
		/// <summary>enum member</summary>
		FileNotFoundError = 20001,
		/// <summary>enum member</summary>
		FirstVTKErrorCode = 20000,
		/// <summary>enum member</summary>
		NoError = 0,
		/// <summary>enum member</summary>
		NoFileNameError = 20006,
		/// <summary>enum member</summary>
		OutOfDiskSpaceError = 20007,
		/// <summary>enum member</summary>
		PrematureEndOfFileError = 20004,
		/// <summary>enum member</summary>
		UnknownError = 20008,
		/// <summary>enum member</summary>
		UnrecognizedFileTypeError = 20003,
		/// <summary>enum member</summary>
		UserError = 40000
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkErrorCode";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkErrorCode()
	{
		MRClassNameKey = "class vtkErrorCode";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkErrorCode"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkErrorCode(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkErrorCode_GetErrorCodeFromString_01(string error);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static uint GetErrorCodeFromString(string error)
	{
		return vtkErrorCode_GetErrorCodeFromString_01(error);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkErrorCode_GetLastSystemError_02();

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static uint GetLastSystemError()
	{
		return vtkErrorCode_GetLastSystemError_02();
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkErrorCode_GetStringFromErrorCode_03(uint error);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static string GetStringFromErrorCode(uint error)
	{
		return Marshal.PtrToStringAnsi(vtkErrorCode_GetStringFromErrorCode_03(error));
	}
}
