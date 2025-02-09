using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageDecomposeFilter
/// </summary>
/// <remarks>
///    Filters that execute axes in series.
///
/// This superclass molds the vtkImageIterateFilter superclass so
/// it iterates over the axes.  The filter uses dimensionality to
/// determine how many axes to execute (starting from x).
/// The filter also provides convenience methods for permuting information
/// retrieved from input, output and vtkImageData.
/// </remarks>
public class vtkImageDecomposeFilter : vtkImageIterateFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageDecomposeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageDecomposeFilter()
	{
		MRClassNameKey = "class vtkImageDecomposeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDecomposeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageDecomposeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDecomposeFilter_GetDimensionality_01(HandleRef pThis);

	/// <summary>
	/// Dimensionality is the number of axes which are considered during
	/// execution. To process images dimensionality would be set to 2.
	/// </summary>
	public virtual int GetDimensionality()
	{
		return vtkImageDecomposeFilter_GetDimensionality_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDecomposeFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageDecomposeFilter filter with default
	/// dimensionality 3.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageDecomposeFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDecomposeFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Construct an instance of vtkImageDecomposeFilter filter with default
	/// dimensionality 3.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageDecomposeFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDecomposeFilter_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageDecomposeFilter filter with default
	/// dimensionality 3.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageDecomposeFilter_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDecomposeFilter_IsTypeOf_05(string type);

	/// <summary>
	/// Construct an instance of vtkImageDecomposeFilter filter with default
	/// dimensionality 3.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageDecomposeFilter_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDecomposeFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageDecomposeFilter filter with default
	/// dimensionality 3.
	/// </summary>
	public new vtkImageDecomposeFilter NewInstance()
	{
		vtkImageDecomposeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDecomposeFilter_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDecomposeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDecomposeFilter_PermuteExtent_07(HandleRef pThis, IntPtr extent, ref int min0, ref int max0, ref int min1, ref int max1, ref int min2, ref int max2);

	/// <summary>
	/// Private methods kept public for template execute functions.
	/// </summary>
	public void PermuteExtent(IntPtr extent, ref int min0, ref int max0, ref int min1, ref int max1, ref int min2, ref int max2)
	{
		vtkImageDecomposeFilter_PermuteExtent_07(GetCppThis(), extent, ref min0, ref max0, ref min1, ref max1, ref min2, ref max2);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDecomposeFilter_PermuteIncrements_08(HandleRef pThis, IntPtr increments, ref long inc0, ref long inc1, ref long inc2);

	/// <summary>
	/// Private methods kept public for template execute functions.
	/// </summary>
	public void PermuteIncrements(IntPtr increments, ref long inc0, ref long inc1, ref long inc2)
	{
		vtkImageDecomposeFilter_PermuteIncrements_08(GetCppThis(), increments, ref inc0, ref inc1, ref inc2);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDecomposeFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageDecomposeFilter filter with default
	/// dimensionality 3.
	/// </summary>
	public new static vtkImageDecomposeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkImageDecomposeFilter vtkImageDecomposeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDecomposeFilter_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageDecomposeFilter2 = (vtkImageDecomposeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageDecomposeFilter2.Register(null);
			}
		}
		return vtkImageDecomposeFilter2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDecomposeFilter_SetDimensionality_10(HandleRef pThis, int dim);

	/// <summary>
	/// Dimensionality is the number of axes which are considered during
	/// execution. To process images dimensionality would be set to 2.
	/// </summary>
	public void SetDimensionality(int dim)
	{
		vtkImageDecomposeFilter_SetDimensionality_10(GetCppThis(), dim);
	}
}
