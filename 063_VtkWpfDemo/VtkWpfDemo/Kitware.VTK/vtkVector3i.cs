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
public class vtkVector3i : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVector3i";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVector3i()
	{
		MRClassNameKey = "class vtkVector3i";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVector3i"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVector3i(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern vtkVector3i vtkVector3i_Cross_01(HandleRef pThis, vtkVector3i other);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVector3i Cross(vtkVector3i other)
	{
		return vtkVector3i_Cross_01(GetCppThis(), other);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkVector3i vtkVector3i_Normalized_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVector3i Normalized()
	{
		return vtkVector3i_Normalized_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVector3i_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float z);

	public vtkVector3i(float x, float y, float z)
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVector3i_New(ref mteStatus, ref mteIndex, ref rawRefCount, x, y, z);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}
}
