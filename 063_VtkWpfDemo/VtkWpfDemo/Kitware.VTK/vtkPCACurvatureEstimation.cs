using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPCACurvatureEstimation
/// </summary>
/// <remarks>
///    generate curvature estimates using
/// principal component analysis
///
///
/// vtkPCACurvatureEstimation generates point normals using PCA (principal
/// component analysis).  Basically this estimates a local tangent plane
/// around sample point p by considering a small neighborhood of points
/// around p, and fitting a plane to the neighborhood (via PCA). A good
/// introductory reference is Hoppe's "Surface reconstruction from
/// unorganized points."
///
/// To use this filter, specify a neighborhood size. This may have to be set
/// via experimentation. Optionally a point locator can be specified (instead
/// of the default locator), which is used to accelerate searches around a
/// sample point. Finally, the user should specify how to generate
/// consistently-oriented normals. As computed by PCA, normals may point in
/// +/- orientation, which may not be consistent with neighboring normals.
///
/// The output of this filter is the same as the input except that a normal
/// per point is produced. (Note that these are unit normals.) While any
/// vtkPointSet type can be provided as input, the output is represented by an
/// explicit representation of points via a vtkPolyData. This output polydata
/// will populate its instance of vtkPoints, but no cells will be defined
/// (i.e., no vtkVertex or vtkPolyVertex are contained in the output).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkPCANormalEstimation
/// </seealso>
public class vtkPCACurvatureEstimation : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPCACurvatureEstimation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPCACurvatureEstimation()
	{
		MRClassNameKey = "class vtkPCACurvatureEstimation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCACurvatureEstimation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPCACurvatureEstimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCACurvatureEstimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPCACurvatureEstimation New()
	{
		vtkPCACurvatureEstimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCACurvatureEstimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPCACurvatureEstimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkPCACurvatureEstimation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPCACurvatureEstimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCACurvatureEstimation_GetLocator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// around a sample point.
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCACurvatureEstimation_GetLocator_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPCACurvatureEstimation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPCACurvatureEstimation_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPCACurvatureEstimation_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPCACurvatureEstimation_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCACurvatureEstimation_GetSampleSize_04(HandleRef pThis);

	/// <summary>
	/// For each sampled point, specify the number of the closest, surrounding
	/// points used to estimate the normal (the so called k-neighborhood). By
	/// default 25 points are used. Smaller numbers may speed performance at the
	/// cost of accuracy.
	/// </summary>
	public virtual int GetSampleSize()
	{
		return vtkPCACurvatureEstimation_GetSampleSize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCACurvatureEstimation_GetSampleSizeMaxValue_05(HandleRef pThis);

	/// <summary>
	/// For each sampled point, specify the number of the closest, surrounding
	/// points used to estimate the normal (the so called k-neighborhood). By
	/// default 25 points are used. Smaller numbers may speed performance at the
	/// cost of accuracy.
	/// </summary>
	public virtual int GetSampleSizeMaxValue()
	{
		return vtkPCACurvatureEstimation_GetSampleSizeMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCACurvatureEstimation_GetSampleSizeMinValue_06(HandleRef pThis);

	/// <summary>
	/// For each sampled point, specify the number of the closest, surrounding
	/// points used to estimate the normal (the so called k-neighborhood). By
	/// default 25 points are used. Smaller numbers may speed performance at the
	/// cost of accuracy.
	/// </summary>
	public virtual int GetSampleSizeMinValue()
	{
		return vtkPCACurvatureEstimation_GetSampleSizeMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCACurvatureEstimation_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPCACurvatureEstimation_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCACurvatureEstimation_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPCACurvatureEstimation_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCACurvatureEstimation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkPCACurvatureEstimation NewInstance()
	{
		vtkPCACurvatureEstimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCACurvatureEstimation_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPCACurvatureEstimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCACurvatureEstimation_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPCACurvatureEstimation SafeDownCast(vtkObjectBase o)
	{
		vtkPCACurvatureEstimation vtkPCACurvatureEstimation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCACurvatureEstimation_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPCACurvatureEstimation2 = (vtkPCACurvatureEstimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPCACurvatureEstimation2.Register(null);
			}
		}
		return vtkPCACurvatureEstimation2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCACurvatureEstimation_SetLocator_12(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// around a sample point.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkPCACurvatureEstimation_SetLocator_12(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCACurvatureEstimation_SetSampleSize_13(HandleRef pThis, int _arg);

	/// <summary>
	/// For each sampled point, specify the number of the closest, surrounding
	/// points used to estimate the normal (the so called k-neighborhood). By
	/// default 25 points are used. Smaller numbers may speed performance at the
	/// cost of accuracy.
	/// </summary>
	public virtual void SetSampleSize(int _arg)
	{
		vtkPCACurvatureEstimation_SetSampleSize_13(GetCppThis(), _arg);
	}
}
