using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDiscreteFlyingEdges2D
/// </summary>
/// <remarks>
///    generate isoline(s) from 2D image data
///
/// vtkDiscreteFlyingEdges2D creates output representations of label maps
/// (e.g., segmented images) using a variation of the flying edges
/// algorithm. The input is a 2D image where each point is labeled (integer
/// labels are preferred to real values), and the output data is polygonal
/// data representing labeled regions. (Note that on output each region
/// [corresponding to a different contour value] is represented independently;
/// i.e., points are not shared between regions even if they are coincident.)
///
/// @warning
/// This filter is specialized to 2D images. This implementation can produce
/// degenerate line segments (i.e., zero-length line segments).
///
/// @warning
/// Use vtkContourLoopExtraction if you wish to create polygons from the line
/// segments.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkDiscreteMarchingCubes vtkContourLoopExtraction
/// </seealso>
public class vtkDiscreteFlyingEdges2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDiscreteFlyingEdges2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDiscreteFlyingEdges2D()
	{
		MRClassNameKey = "class vtkDiscreteFlyingEdges2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscreteFlyingEdges2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDiscreteFlyingEdges2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdges2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static vtkDiscreteFlyingEdges2D New()
	{
		vtkDiscreteFlyingEdges2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteFlyingEdges2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscreteFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public vtkDiscreteFlyingEdges2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDiscreteFlyingEdges2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDiscreteFlyingEdges2D_ComputeScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// Option to set the point scalars of the output.  The scalars will be the
	/// label values.  By default this flag is on.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkDiscreteFlyingEdges2D_ComputeScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges2D_ComputeScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// Option to set the point scalars of the output.  The scalars will be the
	/// label values.  By default this flag is on.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkDiscreteFlyingEdges2D_ComputeScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges2D_GenerateValues_03(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkDiscreteFlyingEdges2D_GenerateValues_03(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges2D_GenerateValues_04(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkDiscreteFlyingEdges2D_GenerateValues_04(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges2D_GetArrayComponent_05(HandleRef pThis);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkDiscreteFlyingEdges2D_GetArrayComponent_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges2D_GetComputeScalars_06(HandleRef pThis);

	/// <summary>
	/// Option to set the point scalars of the output.  The scalars will be the
	/// label values.  By default this flag is on.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkDiscreteFlyingEdges2D_GetComputeScalars_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDiscreteFlyingEdges2D_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Because we delegate to vtkContourValues.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDiscreteFlyingEdges2D_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteFlyingEdges2D_GetNumberOfContours_08(HandleRef pThis);

	/// <summary>
	/// Get the number of contours in the list of contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkDiscreteFlyingEdges2D_GetNumberOfContours_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteFlyingEdges2D_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDiscreteFlyingEdges2D_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteFlyingEdges2D_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDiscreteFlyingEdges2D_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiscreteFlyingEdges2D_GetValue_11(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkDiscreteFlyingEdges2D_GetValue_11(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdges2D_GetValues_12(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of contour values. There will be
	/// GetNumberOfContours() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkDiscreteFlyingEdges2D_GetValues_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges2D_GetValues_13(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. There will be
	/// GetNumberOfContours() values in the list. Make sure you allocate
	/// enough memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkDiscreteFlyingEdges2D_GetValues_13(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges2D_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDiscreteFlyingEdges2D_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdges2D_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDiscreteFlyingEdges2D_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdges2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new vtkDiscreteFlyingEdges2D NewInstance()
	{
		vtkDiscreteFlyingEdges2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteFlyingEdges2D_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscreteFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdges2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static vtkDiscreteFlyingEdges2D SafeDownCast(vtkObjectBase o)
	{
		vtkDiscreteFlyingEdges2D vtkDiscreteFlyingEdges2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteFlyingEdges2D_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDiscreteFlyingEdges2D2 = (vtkDiscreteFlyingEdges2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDiscreteFlyingEdges2D2.Register(null);
			}
		}
		return vtkDiscreteFlyingEdges2D2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges2D_SetArrayComponent_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of the scalar array to contour on; defaults to 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkDiscreteFlyingEdges2D_SetArrayComponent_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges2D_SetComputeScalars_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Option to set the point scalars of the output.  The scalars will be the
	/// label values.  By default this flag is on.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkDiscreteFlyingEdges2D_SetComputeScalars_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges2D_SetNumberOfContours_21(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkDiscreteFlyingEdges2D_SetNumberOfContours_21(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdges2D_SetValue_22(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular contour value at contour number i. The index i ranges
	/// between 0&lt;=i&lt;NumberOfContours.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkDiscreteFlyingEdges2D_SetValue_22(GetCppThis(), i, value);
	}
}
