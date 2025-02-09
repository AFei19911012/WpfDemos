using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIterativeClosestPointTransform
/// </summary>
/// <remarks>
///    Implementation of the ICP algorithm.
///
/// Match two surfaces using the iterative closest point (ICP) algorithm.
/// The core of the algorithm is to match each vertex in one surface with
/// the closest surface point on the other, then apply the transformation
/// that modify one surface to best match the other (in a least square sense).
/// This has to be iterated to get proper convergence of the surfaces.
/// @attention
/// Use vtkTransformPolyDataFilter to apply the resulting ICP transform to
/// your data. You might also set it to your actor's user transform.
/// @attention
/// This class makes use of vtkLandmarkTransform internally to compute the
/// best fit. Use the GetLandmarkTransform member to get a pointer to that
/// transform and set its parameters. You might, for example, constrain the
/// number of degrees of freedom of the solution (i.e. rigid body, similarity,
/// etc.) by checking the vtkLandmarkTransform documentation for its SetMode
/// member.
/// </remarks>
/// <seealso>
///
/// vtkLandmarkTransform
/// </seealso>
public class vtkIterativeClosestPointTransform : vtkLinearTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIterativeClosestPointTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIterativeClosestPointTransform()
	{
		MRClassNameKey = "class vtkIterativeClosestPointTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIterativeClosestPointTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIterativeClosestPointTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIterativeClosestPointTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIterativeClosestPointTransform New()
	{
		vtkIterativeClosestPointTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIterativeClosestPointTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIterativeClosestPointTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIterativeClosestPointTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIterativeClosestPointTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_CheckMeanDistanceOff_01(HandleRef pThis);

	/// <summary>
	/// Force the algorithm to check the mean distance between two iterations.
	/// Default is Off.
	/// </summary>
	public virtual void CheckMeanDistanceOff()
	{
		vtkIterativeClosestPointTransform_CheckMeanDistanceOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_CheckMeanDistanceOn_02(HandleRef pThis);

	/// <summary>
	/// Force the algorithm to check the mean distance between two iterations.
	/// Default is Off.
	/// </summary>
	public virtual void CheckMeanDistanceOn()
	{
		vtkIterativeClosestPointTransform_CheckMeanDistanceOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_GetCheckMeanDistance_03(HandleRef pThis);

	/// <summary>
	/// Force the algorithm to check the mean distance between two iterations.
	/// Default is Off.
	/// </summary>
	public virtual int GetCheckMeanDistance()
	{
		return vtkIterativeClosestPointTransform_GetCheckMeanDistance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIterativeClosestPointTransform_GetLandmarkTransform_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal landmark transform. Use it to constrain the number of
	/// degrees of freedom of the solution (i.e. rigid body, similarity, etc.).
	/// </summary>
	public virtual vtkLandmarkTransform GetLandmarkTransform()
	{
		vtkLandmarkTransform vtkLandmarkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIterativeClosestPointTransform_GetLandmarkTransform_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIterativeClosestPointTransform_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a spatial locator for speeding up the search process.
	/// An instance of vtkCellLocator is used by default.
	/// </summary>
	public virtual vtkCellLocator GetLocator()
	{
		vtkCellLocator vtkCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIterativeClosestPointTransform_GetLocator_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellLocator2 = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellLocator2.Register(null);
			}
		}
		return vtkCellLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIterativeClosestPointTransform_GetMaximumMeanDistance_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum mean distance between two iteration. If the mean
	/// distance is lower than this, the convergence stops. The default
	/// is 0.01.
	/// </summary>
	public virtual double GetMaximumMeanDistance()
	{
		return vtkIterativeClosestPointTransform_GetMaximumMeanDistance_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_GetMaximumNumberOfIterations_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations. Default is 50.
	/// </summary>
	public virtual int GetMaximumNumberOfIterations()
	{
		return vtkIterativeClosestPointTransform_GetMaximumNumberOfIterations_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_GetMaximumNumberOfLandmarks_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of landmarks sampled in your dataset.
	/// If your dataset is dense, then you will typically not need all the
	/// points to compute the ICP transform. The default is 200.
	/// </summary>
	public virtual int GetMaximumNumberOfLandmarks()
	{
		return vtkIterativeClosestPointTransform_GetMaximumNumberOfLandmarks_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIterativeClosestPointTransform_GetMeanDistance_09(HandleRef pThis);

	/// <summary>
	/// Get the mean distance between the last two iterations.
	/// </summary>
	public virtual double GetMeanDistance()
	{
		return vtkIterativeClosestPointTransform_GetMeanDistance_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_GetMeanDistanceMode_10(HandleRef pThis);

	/// <summary>
	/// Specify the mean distance mode. This mode expresses how the mean
	/// distance is computed. The RMS mode is the square root of the average
	/// of the sum of squares of the closest point distances. The Absolute
	/// Value mode is the mean of the sum of absolute values of the closest
	/// point distances. The default is VTK_ICP_MODE_RMS
	/// </summary>
	public virtual int GetMeanDistanceMode()
	{
		return vtkIterativeClosestPointTransform_GetMeanDistanceMode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIterativeClosestPointTransform_GetMeanDistanceModeAsString_11(HandleRef pThis);

	/// <summary>
	/// Specify the mean distance mode. This mode expresses how the mean
	/// distance is computed. The RMS mode is the square root of the average
	/// of the sum of squares of the closest point distances. The Absolute
	/// Value mode is the mean of the sum of absolute values of the closest
	/// point distances. The default is VTK_ICP_MODE_RMS
	/// </summary>
	public string GetMeanDistanceModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkIterativeClosestPointTransform_GetMeanDistanceModeAsString_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_GetMeanDistanceModeMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the mean distance mode. This mode expresses how the mean
	/// distance is computed. The RMS mode is the square root of the average
	/// of the sum of squares of the closest point distances. The Absolute
	/// Value mode is the mean of the sum of absolute values of the closest
	/// point distances. The default is VTK_ICP_MODE_RMS
	/// </summary>
	public virtual int GetMeanDistanceModeMaxValue()
	{
		return vtkIterativeClosestPointTransform_GetMeanDistanceModeMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_GetMeanDistanceModeMinValue_13(HandleRef pThis);

	/// <summary>
	/// Specify the mean distance mode. This mode expresses how the mean
	/// distance is computed. The RMS mode is the square root of the average
	/// of the sum of squares of the closest point distances. The Absolute
	/// Value mode is the mean of the sum of absolute values of the closest
	/// point distances. The default is VTK_ICP_MODE_RMS
	/// </summary>
	public virtual int GetMeanDistanceModeMinValue()
	{
		return vtkIterativeClosestPointTransform_GetMeanDistanceModeMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIterativeClosestPointTransform_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIterativeClosestPointTransform_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIterativeClosestPointTransform_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIterativeClosestPointTransform_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_GetNumberOfIterations_16(HandleRef pThis);

	/// <summary>
	/// Get the number of iterations since the last update
	/// </summary>
	public virtual int GetNumberOfIterations()
	{
		return vtkIterativeClosestPointTransform_GetNumberOfIterations_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIterativeClosestPointTransform_GetSource_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source and target data sets.
	/// </summary>
	public virtual vtkDataSet GetSource()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIterativeClosestPointTransform_GetSource_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_GetStartByMatchingCentroids_18(HandleRef pThis);

	/// <summary>
	/// Starts the process by translating source centroid to target centroid.
	/// The default is Off.
	/// </summary>
	public virtual int GetStartByMatchingCentroids()
	{
		return vtkIterativeClosestPointTransform_GetStartByMatchingCentroids_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIterativeClosestPointTransform_GetTarget_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source and target data sets.
	/// </summary>
	public virtual vtkDataSet GetTarget()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIterativeClosestPointTransform_GetTarget_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_Inverse_20(HandleRef pThis);

	/// <summary>
	/// Invert the transformation.  This is done by switching the
	/// source and target.
	/// </summary>
	public override void Inverse()
	{
		vtkIterativeClosestPointTransform_Inverse_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIterativeClosestPointTransform_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIterativeClosestPointTransform_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIterativeClosestPointTransform_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIterativeClosestPointTransform_MakeTransform_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make another transform of the same type.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIterativeClosestPointTransform_MakeTransform_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIterativeClosestPointTransform_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIterativeClosestPointTransform NewInstance()
	{
		vtkIterativeClosestPointTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIterativeClosestPointTransform_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIterativeClosestPointTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIterativeClosestPointTransform_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIterativeClosestPointTransform SafeDownCast(vtkObjectBase o)
	{
		vtkIterativeClosestPointTransform vtkIterativeClosestPointTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIterativeClosestPointTransform_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIterativeClosestPointTransform2 = (vtkIterativeClosestPointTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIterativeClosestPointTransform2.Register(null);
			}
		}
		return vtkIterativeClosestPointTransform2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetCheckMeanDistance_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the algorithm to check the mean distance between two iterations.
	/// Default is Off.
	/// </summary>
	public virtual void SetCheckMeanDistance(int _arg)
	{
		vtkIterativeClosestPointTransform_SetCheckMeanDistance_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetLocator_28(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set/Get a spatial locator for speeding up the search process.
	/// An instance of vtkCellLocator is used by default.
	/// </summary>
	public void SetLocator(vtkCellLocator locator)
	{
		vtkIterativeClosestPointTransform_SetLocator_28(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetMaximumMeanDistance_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the maximum mean distance between two iteration. If the mean
	/// distance is lower than this, the convergence stops. The default
	/// is 0.01.
	/// </summary>
	public virtual void SetMaximumMeanDistance(double _arg)
	{
		vtkIterativeClosestPointTransform_SetMaximumMeanDistance_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetMaximumNumberOfIterations_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of iterations. Default is 50.
	/// </summary>
	public virtual void SetMaximumNumberOfIterations(int _arg)
	{
		vtkIterativeClosestPointTransform_SetMaximumNumberOfIterations_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetMaximumNumberOfLandmarks_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of landmarks sampled in your dataset.
	/// If your dataset is dense, then you will typically not need all the
	/// points to compute the ICP transform. The default is 200.
	/// </summary>
	public virtual void SetMaximumNumberOfLandmarks(int _arg)
	{
		vtkIterativeClosestPointTransform_SetMaximumNumberOfLandmarks_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetMeanDistanceMode_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the mean distance mode. This mode expresses how the mean
	/// distance is computed. The RMS mode is the square root of the average
	/// of the sum of squares of the closest point distances. The Absolute
	/// Value mode is the mean of the sum of absolute values of the closest
	/// point distances. The default is VTK_ICP_MODE_RMS
	/// </summary>
	public virtual void SetMeanDistanceMode(int _arg)
	{
		vtkIterativeClosestPointTransform_SetMeanDistanceMode_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetMeanDistanceModeToAbsoluteValue_33(HandleRef pThis);

	/// <summary>
	/// Specify the mean distance mode. This mode expresses how the mean
	/// distance is computed. The RMS mode is the square root of the average
	/// of the sum of squares of the closest point distances. The Absolute
	/// Value mode is the mean of the sum of absolute values of the closest
	/// point distances. The default is VTK_ICP_MODE_RMS
	/// </summary>
	public void SetMeanDistanceModeToAbsoluteValue()
	{
		vtkIterativeClosestPointTransform_SetMeanDistanceModeToAbsoluteValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetMeanDistanceModeToRMS_34(HandleRef pThis);

	/// <summary>
	/// Specify the mean distance mode. This mode expresses how the mean
	/// distance is computed. The RMS mode is the square root of the average
	/// of the sum of squares of the closest point distances. The Absolute
	/// Value mode is the mean of the sum of absolute values of the closest
	/// point distances. The default is VTK_ICP_MODE_RMS
	/// </summary>
	public void SetMeanDistanceModeToRMS()
	{
		vtkIterativeClosestPointTransform_SetMeanDistanceModeToRMS_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetSource_35(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the source and target data sets.
	/// </summary>
	public void SetSource(vtkDataSet source)
	{
		vtkIterativeClosestPointTransform_SetSource_35(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetStartByMatchingCentroids_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Starts the process by translating source centroid to target centroid.
	/// The default is Off.
	/// </summary>
	public virtual void SetStartByMatchingCentroids(int _arg)
	{
		vtkIterativeClosestPointTransform_SetStartByMatchingCentroids_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_SetTarget_37(HandleRef pThis, HandleRef target);

	/// <summary>
	/// Specify the source and target data sets.
	/// </summary>
	public void SetTarget(vtkDataSet target)
	{
		vtkIterativeClosestPointTransform_SetTarget_37(GetCppThis(), target?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_StartByMatchingCentroidsOff_38(HandleRef pThis);

	/// <summary>
	/// Starts the process by translating source centroid to target centroid.
	/// The default is Off.
	/// </summary>
	public virtual void StartByMatchingCentroidsOff()
	{
		vtkIterativeClosestPointTransform_StartByMatchingCentroidsOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIterativeClosestPointTransform_StartByMatchingCentroidsOn_39(HandleRef pThis);

	/// <summary>
	/// Starts the process by translating source centroid to target centroid.
	/// The default is Off.
	/// </summary>
	public virtual void StartByMatchingCentroidsOn()
	{
		vtkIterativeClosestPointTransform_StartByMatchingCentroidsOn_39(GetCppThis());
	}
}
