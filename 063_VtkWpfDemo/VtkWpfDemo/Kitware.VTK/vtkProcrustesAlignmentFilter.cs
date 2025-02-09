using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProcrustesAlignmentFilter
/// </summary>
/// <remarks>
///    aligns a set of pointsets together
///
///
/// vtkProcrustesAlignmentFilter is a filter that takes a set of pointsets
/// (any object derived from vtkPointSet) and aligns them in a least-squares
/// sense to their mutual mean. The algorithm is iterated until convergence,
/// as the mean must be recomputed after each alignment.
///
/// vtkProcrustesAlignmentFilter requires a vtkMultiBlock input consisting
/// of vtkPointSets as first level children.
///
/// The default (in vtkLandmarkTransform) is for a similarity alignment.
/// For a rigid-body alignment (to build a 'size-and-shape' model) use:
///
///    GetLandmarkTransform()-&gt;SetModeToRigidBody().
///
/// Affine alignments are not normally used but are left in for completeness:
///
///    GetLandmarkTransform()-&gt;SetModeToAffine().
///
/// vtkProcrustesAlignmentFilter is an implementation of:
///
///    J.C. Gower (1975)
///    Generalized Procrustes Analysis. Psychometrika, 40:33-51.
///
/// @warning
/// All of the input pointsets must have the same number of points.
///
/// @par Thanks:
/// Tim Hutton and Rasmus Paulsen who developed and contributed this class
///
/// </remarks>
/// <seealso>
///
/// vtkLandmarkTransform
/// </seealso>
public class vtkProcrustesAlignmentFilter : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProcrustesAlignmentFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProcrustesAlignmentFilter()
	{
		MRClassNameKey = "class vtkProcrustesAlignmentFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcrustesAlignmentFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProcrustesAlignmentFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcrustesAlignmentFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates with similarity transform.
	/// </summary>
	public new static vtkProcrustesAlignmentFilter New()
	{
		vtkProcrustesAlignmentFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcrustesAlignmentFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProcrustesAlignmentFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates with similarity transform.
	/// </summary>
	public vtkProcrustesAlignmentFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProcrustesAlignmentFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcrustesAlignmentFilter_GetLandmarkTransform_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal landmark transform. Use it to constrain the number of
	/// degrees of freedom of the alignment (i.e. rigid body, similarity, etc.).
	/// The default is a similarity alignment.
	/// </summary>
	public virtual vtkLandmarkTransform GetLandmarkTransform()
	{
		vtkLandmarkTransform vtkLandmarkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcrustesAlignmentFilter_GetLandmarkTransform_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLandmarkTransform2 = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLandmarkTransform2.Register(null);
			}
		}
		return vtkLandmarkTransform2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcrustesAlignmentFilter_GetMeanPoints_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the estimated mean point cloud
	/// </summary>
	public virtual vtkPoints GetMeanPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcrustesAlignmentFilter_GetMeanPoints_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProcrustesAlignmentFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProcrustesAlignmentFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProcrustesAlignmentFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProcrustesAlignmentFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcrustesAlignmentFilter_GetOutputPointsPrecision_05(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings. If the desired precision is
	/// DEFAULT_PRECISION and any of the inputs are double precision, then the
	/// mean points will be double precision. Otherwise, if the desired
	/// precision is DEFAULT_PRECISION and all the inputs are single precision,
	/// then the mean points will be single precision.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkProcrustesAlignmentFilter_GetOutputPointsPrecision_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProcrustesAlignmentFilter_GetStartFromCentroid_06(HandleRef pThis);

	/// <summary>
	/// When on, the initial alignment is to the centroid
	/// of the cohort curves.  When off, the alignment is to the
	/// centroid of the first input.  Default is off for
	/// backward compatibility.
	/// </summary>
	public virtual bool GetStartFromCentroid()
	{
		return (vtkProcrustesAlignmentFilter_GetStartFromCentroid_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcrustesAlignmentFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProcrustesAlignmentFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcrustesAlignmentFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProcrustesAlignmentFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcrustesAlignmentFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProcrustesAlignmentFilter NewInstance()
	{
		vtkProcrustesAlignmentFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcrustesAlignmentFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProcrustesAlignmentFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcrustesAlignmentFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProcrustesAlignmentFilter SafeDownCast(vtkObjectBase o)
	{
		vtkProcrustesAlignmentFilter vtkProcrustesAlignmentFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcrustesAlignmentFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProcrustesAlignmentFilter2 = (vtkProcrustesAlignmentFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProcrustesAlignmentFilter2.Register(null);
			}
		}
		return vtkProcrustesAlignmentFilter2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcrustesAlignmentFilter_SetOutputPointsPrecision_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings. If the desired precision is
	/// DEFAULT_PRECISION and any of the inputs are double precision, then the
	/// mean points will be double precision. Otherwise, if the desired
	/// precision is DEFAULT_PRECISION and all the inputs are single precision,
	/// then the mean points will be single precision.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkProcrustesAlignmentFilter_SetOutputPointsPrecision_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcrustesAlignmentFilter_SetStartFromCentroid_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// When on, the initial alignment is to the centroid
	/// of the cohort curves.  When off, the alignment is to the
	/// centroid of the first input.  Default is off for
	/// backward compatibility.
	/// </summary>
	public virtual void SetStartFromCentroid(bool _arg)
	{
		vtkProcrustesAlignmentFilter_SetStartFromCentroid_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcrustesAlignmentFilter_StartFromCentroidOff_14(HandleRef pThis);

	/// <summary>
	/// When on, the initial alignment is to the centroid
	/// of the cohort curves.  When off, the alignment is to the
	/// centroid of the first input.  Default is off for
	/// backward compatibility.
	/// </summary>
	public virtual void StartFromCentroidOff()
	{
		vtkProcrustesAlignmentFilter_StartFromCentroidOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcrustesAlignmentFilter_StartFromCentroidOn_15(HandleRef pThis);

	/// <summary>
	/// When on, the initial alignment is to the centroid
	/// of the cohort curves.  When off, the alignment is to the
	/// centroid of the first input.  Default is off for
	/// backward compatibility.
	/// </summary>
	public virtual void StartFromCentroidOn()
	{
		vtkProcrustesAlignmentFilter_StartFromCentroidOn_15(GetCppThis());
	}
}
