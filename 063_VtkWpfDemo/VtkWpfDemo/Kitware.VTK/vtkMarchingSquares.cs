using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMarchingSquares
/// </summary>
/// <remarks>
///    generate isoline(s) from structured points set
///
/// vtkMarchingSquares is a filter that takes as input a structured points set
/// and generates on output one or more isolines.  One or more contour values
/// must be specified to generate the isolines.  Alternatively, you can specify
/// a min/max scalar range and the number of contours to generate a series of
/// evenly spaced contour values.
///
/// To generate contour lines the input data must be of topological dimension 2
/// (i.e., an image). If not, you can use the ImageRange ivar to select an
/// image plane from an input volume. This avoids having to extract a plane first
/// (using vtkExtractSubVolume).  The filter deals with this by first
/// trying to use the input data directly, and if not a 2D image, then uses the
/// ImageRange ivar to reduce it to an image.
///
/// @warning
/// This filter is specialized to images. If you are interested in
/// contouring other types of data, use the general vtkContourFilter.
/// </remarks>
/// <seealso>
///
/// vtkContourFilter vtkMarchingCubes vtkSliceCubes vtkDividingCubes
/// </seealso>
public class vtkMarchingSquares : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMarchingSquares";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMarchingSquares()
	{
		MRClassNameKey = "class vtkMarchingSquares";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarchingSquares"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMarchingSquares(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingSquares_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMarchingSquares New()
	{
		vtkMarchingSquares result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarchingSquares_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMarchingSquares)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMarchingSquares()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMarchingSquares_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified.
	/// The locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkMarchingSquares_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_GenerateValues_02(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkMarchingSquares_GenerateValues_02(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_GenerateValues_03(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkMarchingSquares_GenerateValues_03(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingSquares_GetImageRange_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the i-j-k index range which define a plane on which to generate
	/// contour lines. Using this ivar it is possible to input a 3D volume
	/// directly and then generate contour lines on one of the i-j-k planes, or
	/// a portion of a plane.
	/// </summary>
	public virtual int[] GetImageRange()
	{
		IntPtr intPtr = vtkMarchingSquares_GetImageRange_04(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_GetImageRange_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the i-j-k index range which define a plane on which to generate
	/// contour lines. Using this ivar it is possible to input a 3D volume
	/// directly and then generate contour lines on one of the i-j-k planes, or
	/// a portion of a plane.
	/// </summary>
	public virtual void GetImageRange(IntPtr data)
	{
		vtkMarchingSquares_GetImageRange_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingSquares_GetLocator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Because we delegate to vtkContourValues
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarchingSquares_GetLocator_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMarchingSquares_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Because we delegate to vtkContourValues
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkMarchingSquares_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMarchingSquares_GetNumberOfContours_08(HandleRef pThis);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkMarchingSquares_GetNumberOfContours_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMarchingSquares_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMarchingSquares_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMarchingSquares_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMarchingSquares_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMarchingSquares_GetValue_11(HandleRef pThis, int i);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public double GetValue(int i)
	{
		return vtkMarchingSquares_GetValue_11(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingSquares_GetValues_12(HandleRef pThis);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkMarchingSquares_GetValues_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_GetValues_13(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkMarchingSquares_GetValues_13(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMarchingSquares_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMarchingSquares_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMarchingSquares_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMarchingSquares_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingSquares_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMarchingSquares NewInstance()
	{
		vtkMarchingSquares result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarchingSquares_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMarchingSquares)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMarchingSquares_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMarchingSquares SafeDownCast(vtkObjectBase o)
	{
		vtkMarchingSquares vtkMarchingSquares2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMarchingSquares_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMarchingSquares2 = (vtkMarchingSquares)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMarchingSquares2.Register(null);
			}
		}
		return vtkMarchingSquares2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_SetImageRange_19(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the i-j-k index range which define a plane on which to generate
	/// contour lines. Using this ivar it is possible to input a 3D volume
	/// directly and then generate contour lines on one of the i-j-k planes, or
	/// a portion of a plane.
	/// </summary>
	public virtual void SetImageRange(IntPtr data)
	{
		vtkMarchingSquares_SetImageRange_19(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_SetImageRange_20(HandleRef pThis, int imin, int imax, int jmin, int jmax, int kmin, int kmax);

	/// <summary>
	/// Set/Get the i-j-k index range which define a plane on which to generate
	/// contour lines. Using this ivar it is possible to input a 3D volume
	/// directly and then generate contour lines on one of the i-j-k planes, or
	/// a portion of a plane.
	/// </summary>
	public void SetImageRange(int imin, int imax, int jmin, int jmax, int kmin, int kmax)
	{
		vtkMarchingSquares_SetImageRange_20(GetCppThis(), imin, imax, jmin, jmax, kmin, kmax);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_SetLocator_21(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Because we delegate to vtkContourValues
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkMarchingSquares_SetLocator_21(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_SetNumberOfContours_22(HandleRef pThis, int number);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkMarchingSquares_SetNumberOfContours_22(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMarchingSquares_SetValue_23(HandleRef pThis, int i, double value);

	/// <summary>
	/// Methods to set contour values
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkMarchingSquares_SetValue_23(GetCppThis(), i, value);
	}
}
