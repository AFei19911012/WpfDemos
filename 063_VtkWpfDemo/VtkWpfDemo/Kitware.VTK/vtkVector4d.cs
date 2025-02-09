using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVector
/// </summary>
/// <remarks>
///    templated base type for storage of vectors.
///
///
/// This class is a templated data type for storing and manipulating fixed size
/// vectors, which can be used to represent two and three dimensional points. The
/// memory layout is a contiguous array of the specified type, such that a
/// float[2] can be cast to a vtkVector2f and manipulated. Also a float[6] could
/// be cast and used as a vtkVector2f[3].
/// </remarks>
public class vtkVector4d : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVector4d";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVector4d()
	{
		MRClassNameKey = "class vtkVector4d";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVector4d"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVector4d(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkVector4d vtkVector4d_Normalized_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVector4d Normalized()
	{
		return vtkVector4d_Normalized_01(GetCppThis());
	}
}
