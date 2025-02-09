using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDiscreteFlyingEdgesClipper2D
/// </summary>
/// <remarks>
///    generate filled regions from segmented 2D image data
///
/// vtkDiscreteFlyingEdgesClipper2D creates filled polygons from a label map
/// (e.g., segmented image) using a variation of the flying edges algorithm
/// adapted for 2D clipping. The input is a 2D image where each pixel is
/// labeled (integer labels are preferred to real values), and the output data
/// is polygonal data representing labeled regions. (Note that on output each
/// region [corresponding to a different contour value] may share points on a
/// shared boundary.)
///
/// While this filter is similar to a contouring operation, label maps do not
/// provide continuous function values meaning that usual interpolation along
/// edges is not possible. Instead, when the edge endpoints are labeled in
/// differing regions, the edge is split at its midpoint. In addition, besides
/// producing intersection points at the mid-point of edges, the filter may
/// also generate points interior to the pixel cells. For example, if the four
/// vertices of a pixel cell are labeled with different regions, then an
/// interior point is created and four rectangular "regions" are produced.
///
/// Note that one nice feature of this filter is that algorithm execution
/// occurs only one time no matter the number of contour values. In many
/// contouring-like algorithms, each separate contour value requires an
/// additional algorithm execution with a new contour value. So in this filter
/// large numbers of contour values do not significantly affect overall speed.
///
/// @warning This filter is specialized to 2D images.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkSurfaceNets2D vtkDiscreteFlyingEdges2D vtkDiscreteMarchingCubes
/// vtkContourLoopExtraction vtkFlyingEdges2D vtkFlyingEdges3D
/// </seealso>
public class vtkDiscreteFlyingEdgesClipper2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDiscreteFlyingEdgesClipper2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDiscreteFlyingEdgesClipper2D()
	{
		MRClassNameKey = "class vtkDiscreteFlyingEdgesClipper2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscreteFlyingEdgesClipper2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDiscreteFlyingEdgesClipper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdgesClipper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static vtkDiscreteFlyingEdgesClipper2D New()
	{
		vtkDiscreteFlyingEdgesClipper2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteFlyingEdgesClipper2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscreteFlyingEdgesClipper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public vtkDiscreteFlyingEdgesClipper2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDiscreteFlyingEdgesClipper2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDiscreteFlyingEdgesClipper2D_ComputeScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// Option to set the cell scalars of the output. The scalars will be the
	/// contour values. By default this flag is on.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkDiscreteFlyingEdgesClipper2D_ComputeScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdgesClipper2D_ComputeScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// Option to set the cell scalars of the output. The scalars will be the
	/// contour values. By default this flag is on.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkDiscreteFlyingEdgesClipper2D_ComputeScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdgesClipper2D_GenerateValues_03(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between the specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkDiscreteFlyingEdgesClipper2D_GenerateValues_03(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdgesClipper2D_GenerateValues_04(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between the specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkDiscreteFlyingEdgesClipper2D_GenerateValues_04(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdgesClipper2D_GetArrayComponent_05(HandleRef pThis);

	/// <summary>
	/// Set/get which component of a multi-component scalar array to contour on;
	/// defaults to 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkDiscreteFlyingEdgesClipper2D_GetArrayComponent_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdgesClipper2D_GetComputeScalars_06(HandleRef pThis);

	/// <summary>
	/// Option to set the cell scalars of the output. The scalars will be the
	/// contour values. By default this flag is on.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkDiscreteFlyingEdgesClipper2D_GetComputeScalars_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDiscreteFlyingEdgesClipper2D_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// The modified time is a function of the contour values because we delegate to
	/// vtkContourValues.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDiscreteFlyingEdgesClipper2D_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteFlyingEdgesClipper2D_GetNumberOfContours_08(HandleRef pThis);

	/// <summary>
	/// Get the number of contours in the list of contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkDiscreteFlyingEdgesClipper2D_GetNumberOfContours_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteFlyingEdgesClipper2D_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDiscreteFlyingEdgesClipper2D_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscreteFlyingEdgesClipper2D_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDiscreteFlyingEdgesClipper2D_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiscreteFlyingEdgesClipper2D_GetValue_11(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkDiscreteFlyingEdgesClipper2D_GetValue_11(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdgesClipper2D_GetValues_12(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of contour values. There will be
	/// GetNumberOfContours() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkDiscreteFlyingEdgesClipper2D_GetValues_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdgesClipper2D_GetValues_13(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. There will be
	/// GetNumberOfContours() values in the list. Make sure you allocate
	/// enough memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkDiscreteFlyingEdgesClipper2D_GetValues_13(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdgesClipper2D_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDiscreteFlyingEdgesClipper2D_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscreteFlyingEdgesClipper2D_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDiscreteFlyingEdgesClipper2D_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdgesClipper2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new vtkDiscreteFlyingEdgesClipper2D NewInstance()
	{
		vtkDiscreteFlyingEdgesClipper2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteFlyingEdgesClipper2D_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscreteFlyingEdgesClipper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscreteFlyingEdgesClipper2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static vtkDiscreteFlyingEdgesClipper2D SafeDownCast(vtkObjectBase o)
	{
		vtkDiscreteFlyingEdgesClipper2D vtkDiscreteFlyingEdgesClipper2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscreteFlyingEdgesClipper2D_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDiscreteFlyingEdgesClipper2D2 = (vtkDiscreteFlyingEdgesClipper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDiscreteFlyingEdgesClipper2D2.Register(null);
			}
		}
		return vtkDiscreteFlyingEdgesClipper2D2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdgesClipper2D_SetArrayComponent_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of a multi-component scalar array to contour on;
	/// defaults to 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkDiscreteFlyingEdgesClipper2D_SetArrayComponent_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdgesClipper2D_SetComputeScalars_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Option to set the cell scalars of the output. The scalars will be the
	/// contour values. By default this flag is on.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkDiscreteFlyingEdgesClipper2D_SetComputeScalars_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdgesClipper2D_SetNumberOfContours_21(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkDiscreteFlyingEdgesClipper2D_SetNumberOfContours_21(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscreteFlyingEdgesClipper2D_SetValue_22(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular contour value at contour number i. The index i ranges
	/// between 0 &lt;= i &lt;NumberOfContours. (Note: while contour values are
	/// expressed as doubles, the underlying scalar data may be a different
	/// type. During execution the contour values are static cast to the type of
	/// the scalar values.)
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkDiscreteFlyingEdgesClipper2D_SetValue_22(GetCppThis(), i, value);
	}
}
