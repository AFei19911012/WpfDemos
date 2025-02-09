using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPCANormalEstimation
/// </summary>
/// <remarks>
///    generate point normals using local tangent planes
///
///
/// vtkPCANormalEstimation generates point normals using PCA (principal
/// component analysis).  Basically this estimates a local tangent plane
/// around each sample point p by considering a small neighborhood of points
/// around p, and fitting a plane to the neighborhood (via PCA). A good
/// introductory reference is Hoppe's "Surface reconstruction from
/// unorganized points."
///
/// To use this filter, specify a neighborhood size. This may have to be set
/// via experimentation. In addition, the user may optionally specify a point
/// locator (instead of the default locator), which is used to accelerate
/// searches around the sample point. Finally, the user should specify how to
/// generate consistently-oriented normals. As computed by PCA, normals may
/// point in arbitrary +/- orientation, which may not be consistent with
/// neighboring normals. There are three methods to address normal
/// consistency: 1) leave the normals as computed, 2) adjust the +/- sign of
/// the normals so that the normals all point towards a specified point, and
/// 3) perform a traversal of the point cloud and flip neighboring normals so
/// that they are mutually consistent.
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
/// vtkPCACurvatureEstimation
/// </seealso>
public class vtkPCANormalEstimation : vtkPolyDataAlgorithm
{
	/// <summary>
	/// This enum is used to control how normals oriented is controlled.
	/// </summary>
	public enum Style
	{
		/// <summary>enum member</summary>
		AS_COMPUTED = 0,
		/// <summary>enum member</summary>
		GRAPH_TRAVERSAL = 3,
		/// <summary>enum member</summary>
		POINT = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPCANormalEstimation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPCANormalEstimation()
	{
		MRClassNameKey = "class vtkPCANormalEstimation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCANormalEstimation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPCANormalEstimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCANormalEstimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPCANormalEstimation New()
	{
		vtkPCANormalEstimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCANormalEstimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPCANormalEstimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkPCANormalEstimation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPCANormalEstimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPCANormalEstimation_FlipNormalsOff_01(HandleRef pThis);

	/// <summary>
	/// The normal orientation can be flipped by enabling this flag.
	/// </summary>
	public virtual void FlipNormalsOff()
	{
		vtkPCANormalEstimation_FlipNormalsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_FlipNormalsOn_02(HandleRef pThis);

	/// <summary>
	/// The normal orientation can be flipped by enabling this flag.
	/// </summary>
	public virtual void FlipNormalsOn()
	{
		vtkPCANormalEstimation_FlipNormalsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPCANormalEstimation_GetFlipNormals_03(HandleRef pThis);

	/// <summary>
	/// The normal orientation can be flipped by enabling this flag.
	/// </summary>
	public virtual bool GetFlipNormals()
	{
		return (vtkPCANormalEstimation_GetFlipNormals_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCANormalEstimation_GetLocator_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPCANormalEstimation_GetLocator_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPCANormalEstimation_GetNormalOrientation_05(HandleRef pThis);

	/// <summary>
	/// Configure how the filter addresses consistency in normal
	/// oreientation. When initially computed using PCA, a point normal may
	/// point in the + or - direction, which may not be consistent with
	/// neighboring points. To address this, various strategies have been used
	/// to create consistent normals. The simplest approach is to do nothing
	/// (AsComputed). Another simple approach is to flip the normal based on its
	/// direction with respect to a specified point (i.e., point normals will
	/// point towrads the specified point). Finally, a full traversal of points
	/// across the graph of neighboring, connected points produces the best
	/// results but is computationally expensive.
	/// </summary>
	public virtual int GetNormalOrientation()
	{
		return vtkPCANormalEstimation_GetNormalOrientation_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPCANormalEstimation_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPCANormalEstimation_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPCANormalEstimation_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPCANormalEstimation_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCANormalEstimation_GetOrientationPoint_08(HandleRef pThis);

	/// <summary>
	/// If the normal orientation is to be consistent with a specified
	/// direction, then an orientation point should be set. The sign of the
	/// normals will be modified so that they point towards this point. By
	/// default, the specified orientation point is (0,0,0).
	/// </summary>
	public virtual double[] GetOrientationPoint()
	{
		IntPtr intPtr = vtkPCANormalEstimation_GetOrientationPoint_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_GetOrientationPoint_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// If the normal orientation is to be consistent with a specified
	/// direction, then an orientation point should be set. The sign of the
	/// normals will be modified so that they point towards this point. By
	/// default, the specified orientation point is (0,0,0).
	/// </summary>
	public virtual void GetOrientationPoint(IntPtr data)
	{
		vtkPCANormalEstimation_GetOrientationPoint_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCANormalEstimation_GetSampleSize_10(HandleRef pThis);

	/// <summary>
	/// For each sampled point, specify the number of the closest, surrounding
	/// points used to estimate the normal (the so called k-neighborhood). By
	/// default 25 points are used. Smaller numbers may speed performance at the
	/// cost of accuracy.
	/// </summary>
	public virtual int GetSampleSize()
	{
		return vtkPCANormalEstimation_GetSampleSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCANormalEstimation_GetSampleSizeMaxValue_11(HandleRef pThis);

	/// <summary>
	/// For each sampled point, specify the number of the closest, surrounding
	/// points used to estimate the normal (the so called k-neighborhood). By
	/// default 25 points are used. Smaller numbers may speed performance at the
	/// cost of accuracy.
	/// </summary>
	public virtual int GetSampleSizeMaxValue()
	{
		return vtkPCANormalEstimation_GetSampleSizeMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCANormalEstimation_GetSampleSizeMinValue_12(HandleRef pThis);

	/// <summary>
	/// For each sampled point, specify the number of the closest, surrounding
	/// points used to estimate the normal (the so called k-neighborhood). By
	/// default 25 points are used. Smaller numbers may speed performance at the
	/// cost of accuracy.
	/// </summary>
	public virtual int GetSampleSizeMinValue()
	{
		return vtkPCANormalEstimation_GetSampleSizeMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCANormalEstimation_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPCANormalEstimation_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCANormalEstimation_IsTypeOf_14(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPCANormalEstimation_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCANormalEstimation_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkPCANormalEstimation NewInstance()
	{
		vtkPCANormalEstimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCANormalEstimation_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPCANormalEstimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCANormalEstimation_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPCANormalEstimation SafeDownCast(vtkObjectBase o)
	{
		vtkPCANormalEstimation vtkPCANormalEstimation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCANormalEstimation_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPCANormalEstimation2 = (vtkPCANormalEstimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPCANormalEstimation2.Register(null);
			}
		}
		return vtkPCANormalEstimation2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_SetFlipNormals_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// The normal orientation can be flipped by enabling this flag.
	/// </summary>
	public virtual void SetFlipNormals(bool _arg)
	{
		vtkPCANormalEstimation_SetFlipNormals_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_SetLocator_19(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// around a sample point.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkPCANormalEstimation_SetLocator_19(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_SetNormalOrientation_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Configure how the filter addresses consistency in normal
	/// oreientation. When initially computed using PCA, a point normal may
	/// point in the + or - direction, which may not be consistent with
	/// neighboring points. To address this, various strategies have been used
	/// to create consistent normals. The simplest approach is to do nothing
	/// (AsComputed). Another simple approach is to flip the normal based on its
	/// direction with respect to a specified point (i.e., point normals will
	/// point towrads the specified point). Finally, a full traversal of points
	/// across the graph of neighboring, connected points produces the best
	/// results but is computationally expensive.
	/// </summary>
	public virtual void SetNormalOrientation(int _arg)
	{
		vtkPCANormalEstimation_SetNormalOrientation_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_SetNormalOrientationToAsComputed_21(HandleRef pThis);

	/// <summary>
	/// Configure how the filter addresses consistency in normal
	/// oreientation. When initially computed using PCA, a point normal may
	/// point in the + or - direction, which may not be consistent with
	/// neighboring points. To address this, various strategies have been used
	/// to create consistent normals. The simplest approach is to do nothing
	/// (AsComputed). Another simple approach is to flip the normal based on its
	/// direction with respect to a specified point (i.e., point normals will
	/// point towrads the specified point). Finally, a full traversal of points
	/// across the graph of neighboring, connected points produces the best
	/// results but is computationally expensive.
	/// </summary>
	public void SetNormalOrientationToAsComputed()
	{
		vtkPCANormalEstimation_SetNormalOrientationToAsComputed_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_SetNormalOrientationToGraphTraversal_22(HandleRef pThis);

	/// <summary>
	/// Configure how the filter addresses consistency in normal
	/// oreientation. When initially computed using PCA, a point normal may
	/// point in the + or - direction, which may not be consistent with
	/// neighboring points. To address this, various strategies have been used
	/// to create consistent normals. The simplest approach is to do nothing
	/// (AsComputed). Another simple approach is to flip the normal based on its
	/// direction with respect to a specified point (i.e., point normals will
	/// point towrads the specified point). Finally, a full traversal of points
	/// across the graph of neighboring, connected points produces the best
	/// results but is computationally expensive.
	/// </summary>
	public void SetNormalOrientationToGraphTraversal()
	{
		vtkPCANormalEstimation_SetNormalOrientationToGraphTraversal_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_SetNormalOrientationToPoint_23(HandleRef pThis);

	/// <summary>
	/// Configure how the filter addresses consistency in normal
	/// oreientation. When initially computed using PCA, a point normal may
	/// point in the + or - direction, which may not be consistent with
	/// neighboring points. To address this, various strategies have been used
	/// to create consistent normals. The simplest approach is to do nothing
	/// (AsComputed). Another simple approach is to flip the normal based on its
	/// direction with respect to a specified point (i.e., point normals will
	/// point towrads the specified point). Finally, a full traversal of points
	/// across the graph of neighboring, connected points produces the best
	/// results but is computationally expensive.
	/// </summary>
	public void SetNormalOrientationToPoint()
	{
		vtkPCANormalEstimation_SetNormalOrientationToPoint_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_SetOrientationPoint_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// If the normal orientation is to be consistent with a specified
	/// direction, then an orientation point should be set. The sign of the
	/// normals will be modified so that they point towards this point. By
	/// default, the specified orientation point is (0,0,0).
	/// </summary>
	public virtual void SetOrientationPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkPCANormalEstimation_SetOrientationPoint_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_SetOrientationPoint_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// If the normal orientation is to be consistent with a specified
	/// direction, then an orientation point should be set. The sign of the
	/// normals will be modified so that they point towards this point. By
	/// default, the specified orientation point is (0,0,0).
	/// </summary>
	public virtual void SetOrientationPoint(IntPtr _arg)
	{
		vtkPCANormalEstimation_SetOrientationPoint_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCANormalEstimation_SetSampleSize_26(HandleRef pThis, int _arg);

	/// <summary>
	/// For each sampled point, specify the number of the closest, surrounding
	/// points used to estimate the normal (the so called k-neighborhood). By
	/// default 25 points are used. Smaller numbers may speed performance at the
	/// cost of accuracy.
	/// </summary>
	public virtual void SetSampleSize(int _arg)
	{
		vtkPCANormalEstimation_SetSampleSize_26(GetCppThis(), _arg);
	}
}
