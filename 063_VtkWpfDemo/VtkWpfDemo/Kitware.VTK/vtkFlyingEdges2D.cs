using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFlyingEdges2D
/// </summary>
/// <remarks>
///    generate isoline(s) from a structured points (image) dataset
///
/// vtkFlyingEdges2D is a reference implementation of the 2D version of the
/// flying edges algorithm. It is designed to be highly scalable (i.e.,
/// parallelizable) for large data. It implements certain performance
/// optimizations including computational trimming to rapidly eliminate
/// processing of data regions, packed bit representation of case table
/// values, single edge intersection, elimination of point merging, and
/// elimination of any reallocs (due to dynamic data insertion). Note that
/// computational trimming is a method to reduce total computational cost in
/// which partial computational results can be used to eliminate future
/// computations.
///
/// This is a four-pass algorithm. The first pass processes all x-edges and
/// builds x-edge case values (which, when the two x-edges defining a pixel
/// are combined, are equivalent to vertex-based case table except edge-based
/// approaches are separable to parallel computing). Next x-pixel rows are
/// processed to gather information from y-edges (basically to count the
/// number of edge intersections and lines generated). In the third pass a
/// prefix sum is used to count and allocate memory for the output
/// primitives. Finally in the fourth pass output primitives are generated into
/// pre-allocated arrays. This implementation uses pixel cell axes (a x-y dyad
/// located at the pixel origin) to ensure that each edge is intersected at
/// most one time.
///
/// See the paper "Flying Edges: A High-Performance Scalable Isocontouring
/// Algorithm" by Schroeder, Maynard, Geveci. Proc. of LDAV 2015. Chicago, IL.
///
/// @warning
/// This filter is specialized to 2D images. This implementation can produce
/// degenerate line segments (i.e., zero-length line segments).
///
/// @warning
/// If you are interested in extracting segmented regions from a label mask,
/// consider using vtkDiscreteFlyingEdges2D.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkFlyingEdges3D vtkContourFilter vtkSynchronizedTemplates2D
/// vtkMarchingSquares vtkDiscreteFlyingEdges2D
/// </seealso>
public class vtkFlyingEdges2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFlyingEdges2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFlyingEdges2D()
	{
		MRClassNameKey = "class vtkFlyingEdges2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFlyingEdges2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFlyingEdges2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdges2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFlyingEdges2D New()
	{
		vtkFlyingEdges2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdges2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFlyingEdges2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFlyingEdges2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFlyingEdges2D_ComputeScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// Option to set the point scalars of the output.  The scalars will be the
	/// iso value of course.  By default this flag is on.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkFlyingEdges2D_ComputeScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges2D_ComputeScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// Option to set the point scalars of the output.  The scalars will be the
	/// iso value of course.  By default this flag is on.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkFlyingEdges2D_ComputeScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges2D_GenerateValues_03(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkFlyingEdges2D_GenerateValues_03(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges2D_GenerateValues_04(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkFlyingEdges2D_GenerateValues_04(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges2D_GetArrayComponent_05(HandleRef pThis);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkFlyingEdges2D_GetArrayComponent_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges2D_GetComputeScalars_06(HandleRef pThis);

	/// <summary>
	/// Option to set the point scalars of the output.  The scalars will be the
	/// iso value of course.  By default this flag is on.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkFlyingEdges2D_GetComputeScalars_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkFlyingEdges2D_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Because we delegate to vtkContourValues.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkFlyingEdges2D_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlyingEdges2D_GetNumberOfContours_08(HandleRef pThis);

	/// <summary>
	/// Get the number of contours in the list of contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkFlyingEdges2D_GetNumberOfContours_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlyingEdges2D_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFlyingEdges2D_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlyingEdges2D_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFlyingEdges2D_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFlyingEdges2D_GetValue_11(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkFlyingEdges2D_GetValue_11(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdges2D_GetValues_12(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of contour values. There will be
	/// GetNumberOfContours() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkFlyingEdges2D_GetValues_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges2D_GetValues_13(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. There will be
	/// GetNumberOfContours() values in the list. Make sure you allocate
	/// enough memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkFlyingEdges2D_GetValues_13(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges2D_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFlyingEdges2D_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlyingEdges2D_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFlyingEdges2D_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdges2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFlyingEdges2D NewInstance()
	{
		vtkFlyingEdges2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdges2D_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlyingEdges2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFlyingEdges2D SafeDownCast(vtkObjectBase o)
	{
		vtkFlyingEdges2D vtkFlyingEdges2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlyingEdges2D_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFlyingEdges2D2 = (vtkFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFlyingEdges2D2.Register(null);
			}
		}
		return vtkFlyingEdges2D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges2D_SetArrayComponent_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkFlyingEdges2D_SetArrayComponent_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges2D_SetComputeScalars_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Option to set the point scalars of the output.  The scalars will be the
	/// iso value of course.  By default this flag is on.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkFlyingEdges2D_SetComputeScalars_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges2D_SetNumberOfContours_21(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkFlyingEdges2D_SetNumberOfContours_21(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlyingEdges2D_SetValue_22(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular contour value at contour number i. The index i ranges
	/// between 0&lt;=i&lt;NumberOfContours.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkFlyingEdges2D_SetValue_22(GetCppThis(), i, value);
	}
}
