using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVoxelContoursToSurfaceFilter
/// </summary>
/// <remarks>
///    create surface from contours
///
/// vtkVoxelContoursToSurfaceFilter is a filter that takes contours and
/// produces surfaces. There are some restrictions for the contours:
///
///   - The contours are input as vtkPolyData, with the contours being
///     polys in the vtkPolyData.
///   - The contours lie on XY planes - each contour has a constant Z
///   - The contours are ordered in the polys of the vtkPolyData such
///     that all contours on the first (lowest) XY plane are first, then
///     continuing in order of increasing Z value.
///   - The X, Y and Z coordinates are all integer values.
///   - The desired sampling of the contour data is 1x1x1 - Aspect can
///     be used to control the aspect ratio in the output polygonal
///     dataset.
///
/// This filter takes the contours and produces a structured points
/// dataset of signed floating point number indicating distance from
/// a contour. A contouring filter is then applied to generate 3D
/// surfaces from a stack of 2D contour distance slices. This is
/// done in a streaming fashion so as not to use to much memory.
///
/// </remarks>
/// <seealso>
///
/// vtkPolyDataAlgorithm
/// </seealso>
public class vtkVoxelContoursToSurfaceFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVoxelContoursToSurfaceFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVoxelContoursToSurfaceFilter()
	{
		MRClassNameKey = "class vtkVoxelContoursToSurfaceFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxelContoursToSurfaceFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVoxelContoursToSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVoxelContoursToSurfaceFilter New()
	{
		vtkVoxelContoursToSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelContoursToSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoxelContoursToSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVoxelContoursToSurfaceFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVoxelContoursToSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelContoursToSurfaceFilter_GetMemoryLimitInBytes_01(HandleRef pThis);

	/// <summary>
	/// Set / Get the memory limit in bytes for this filter. This is the limit
	/// of the size of the structured points data set that is created for
	/// intermediate processing. The data will be streamed through this volume
	/// in as many pieces as necessary.
	/// </summary>
	public virtual int GetMemoryLimitInBytes()
	{
		return vtkVoxelContoursToSurfaceFilter_GetMemoryLimitInBytes_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoxelContoursToSurfaceFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVoxelContoursToSurfaceFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoxelContoursToSurfaceFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVoxelContoursToSurfaceFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_GetSpacing_04(HandleRef pThis);

	/// <summary>
	/// Set / Get the memory limit in bytes for this filter. This is the limit
	/// of the size of the structured points data set that is created for
	/// intermediate processing. The data will be streamed through this volume
	/// in as many pieces as necessary.
	/// </summary>
	public virtual double[] GetSpacing()
	{
		IntPtr intPtr = vtkVoxelContoursToSurfaceFilter_GetSpacing_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelContoursToSurfaceFilter_GetSpacing_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / Get the memory limit in bytes for this filter. This is the limit
	/// of the size of the structured points data set that is created for
	/// intermediate processing. The data will be streamed through this volume
	/// in as many pieces as necessary.
	/// </summary>
	public virtual void GetSpacing(IntPtr data)
	{
		vtkVoxelContoursToSurfaceFilter_GetSpacing_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelContoursToSurfaceFilter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVoxelContoursToSurfaceFilter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelContoursToSurfaceFilter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVoxelContoursToSurfaceFilter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVoxelContoursToSurfaceFilter NewInstance()
	{
		vtkVoxelContoursToSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelContoursToSurfaceFilter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoxelContoursToSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVoxelContoursToSurfaceFilter SafeDownCast(vtkObjectBase o)
	{
		vtkVoxelContoursToSurfaceFilter vtkVoxelContoursToSurfaceFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelContoursToSurfaceFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVoxelContoursToSurfaceFilter2 = (vtkVoxelContoursToSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVoxelContoursToSurfaceFilter2.Register(null);
			}
		}
		return vtkVoxelContoursToSurfaceFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelContoursToSurfaceFilter_SetMemoryLimitInBytes_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / Get the memory limit in bytes for this filter. This is the limit
	/// of the size of the structured points data set that is created for
	/// intermediate processing. The data will be streamed through this volume
	/// in as many pieces as necessary.
	/// </summary>
	public virtual void SetMemoryLimitInBytes(int _arg)
	{
		vtkVoxelContoursToSurfaceFilter_SetMemoryLimitInBytes_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelContoursToSurfaceFilter_SetSpacing_12(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set / Get the memory limit in bytes for this filter. This is the limit
	/// of the size of the structured points data set that is created for
	/// intermediate processing. The data will be streamed through this volume
	/// in as many pieces as necessary.
	/// </summary>
	public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkVoxelContoursToSurfaceFilter_SetSpacing_12(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelContoursToSurfaceFilter_SetSpacing_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the memory limit in bytes for this filter. This is the limit
	/// of the size of the structured points data set that is created for
	/// intermediate processing. The data will be streamed through this volume
	/// in as many pieces as necessary.
	/// </summary>
	public virtual void SetSpacing(IntPtr _arg)
	{
		vtkVoxelContoursToSurfaceFilter_SetSpacing_13(GetCppThis(), _arg);
	}
}
