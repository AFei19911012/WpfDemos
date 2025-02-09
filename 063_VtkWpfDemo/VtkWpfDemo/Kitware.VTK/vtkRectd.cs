using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRect
/// </summary>
/// <remarks>
///    templated base type for storage of 2D rectangles.
///
///
/// This class is a templated data type for storing and manipulating rectangles.
/// The memory layout is a contiguous array of the specified type, such that a
/// float[4] can be cast to a vtkRectf and manipulated. Also a float[12] could
/// be cast and used as a vtkRectf[3].
/// </remarks>
public class vtkRectd : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectd";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectd()
	{
		MRClassNameKey = "class vtkRectd";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectd"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectd(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkRectd_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float width, float height);

	public vtkRectd(float x, float y, float width, float height)
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectd_New(ref mteStatus, ref mteIndex, ref rawRefCount, x, y, width, height);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectd_GetX(HandleRef pThis);

	public double GetX()
	{
		return vtkRectd_GetX(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectd_GetY(HandleRef pThis);

	public double GetY()
	{
		return vtkRectd_GetY(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectd_GetWidth(HandleRef pThis);

	public double GetWidth()
	{
		return vtkRectd_GetWidth(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectd_GetHeight(HandleRef pThis);

	public double GetHeight()
	{
		return vtkRectd_GetHeight(GetCppThis());
	}
}
