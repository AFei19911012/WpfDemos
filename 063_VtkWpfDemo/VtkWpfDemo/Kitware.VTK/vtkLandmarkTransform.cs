using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLandmarkTransform
/// </summary>
/// <remarks>
///    a linear transform specified by two corresponding point sets
///
/// A vtkLandmarkTransform is defined by two sets of landmarks, the
/// transform computed gives the best fit mapping one onto the other, in a
/// least squares sense. The indices are taken to correspond, so point 1
/// in the first set will get mapped close to point 1 in the second set,
/// etc. Call SetSourceLandmarks and SetTargetLandmarks to specify the two
/// sets of landmarks, ensure they have the same number of points.
/// @warning
/// Whenever you add, subtract, or set points you must call Modified()
/// on the vtkPoints object, or the transformation might not update.
/// </remarks>
/// <seealso>
///
/// vtkLinearTransform
/// </seealso>
public class vtkLandmarkTransform : vtkLinearTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLandmarkTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLandmarkTransform()
	{
		MRClassNameKey = "class vtkLandmarkTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLandmarkTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLandmarkTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLandmarkTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLandmarkTransform New()
	{
		vtkLandmarkTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLandmarkTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLandmarkTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLandmarkTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkLandmarkTransform_GetMTime_01(HandleRef pThis);

	/// <summary>
	/// Get the MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkLandmarkTransform_GetMTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLandmarkTransform_GetMode_02(HandleRef pThis);

	/// <summary>
	/// Get the current transformation mode.
	/// </summary>
	public virtual int GetMode()
	{
		return vtkLandmarkTransform_GetMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLandmarkTransform_GetModeAsString_03(HandleRef pThis);

	/// <summary>
	/// Get the current transformation mode.
	/// </summary>
	public string GetModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkLandmarkTransform_GetModeAsString_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLandmarkTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLandmarkTransform_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLandmarkTransform_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLandmarkTransform_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLandmarkTransform_GetSourceLandmarks_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source and target landmark sets. The two sets must have
	/// the same number of points.  If you add or change points in these objects,
	/// you must call Modified() on them or the transformation might not update.
	/// </summary>
	public virtual vtkPoints GetSourceLandmarks()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLandmarkTransform_GetSourceLandmarks_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLandmarkTransform_GetTargetLandmarks_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source and target landmark sets. The two sets must have
	/// the same number of points.  If you add or change points in these objects,
	/// you must call Modified() on them or the transformation might not update.
	/// </summary>
	public virtual vtkPoints GetTargetLandmarks()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLandmarkTransform_GetTargetLandmarks_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLandmarkTransform_Inverse_08(HandleRef pThis);

	/// <summary>
	/// Invert the transformation.  This is done by switching the
	/// source and target landmarks.
	/// </summary>
	public override void Inverse()
	{
		vtkLandmarkTransform_Inverse_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLandmarkTransform_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLandmarkTransform_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLandmarkTransform_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLandmarkTransform_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLandmarkTransform_MakeTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make another transform of the same type.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLandmarkTransform_MakeTransform_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLandmarkTransform_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLandmarkTransform NewInstance()
	{
		vtkLandmarkTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLandmarkTransform_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLandmarkTransform_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLandmarkTransform SafeDownCast(vtkObjectBase o)
	{
		vtkLandmarkTransform vtkLandmarkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLandmarkTransform_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLandmarkTransform_SetMode_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of degrees of freedom to constrain the solution to.
	/// Rigidbody (VTK_LANDMARK_RIGIDBODY): rotation and translation only.
	/// Similarity (VTK_LANDMARK_SIMILARITY): rotation, translation and
	/// isotropic scaling.
	/// Affine (VTK_LANDMARK_AFFINE): collinearity is preserved.
	/// Ratios of distances along a line are preserved.
	/// The default is similarity.
	/// </summary>
	public virtual void SetMode(int _arg)
	{
		vtkLandmarkTransform_SetMode_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLandmarkTransform_SetModeToAffine_16(HandleRef pThis);

	/// <summary>
	/// Set the number of degrees of freedom to constrain the solution to.
	/// Rigidbody (VTK_LANDMARK_RIGIDBODY): rotation and translation only.
	/// Similarity (VTK_LANDMARK_SIMILARITY): rotation, translation and
	/// isotropic scaling.
	/// Affine (VTK_LANDMARK_AFFINE): collinearity is preserved.
	/// Ratios of distances along a line are preserved.
	/// The default is similarity.
	/// </summary>
	public void SetModeToAffine()
	{
		vtkLandmarkTransform_SetModeToAffine_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLandmarkTransform_SetModeToRigidBody_17(HandleRef pThis);

	/// <summary>
	/// Set the number of degrees of freedom to constrain the solution to.
	/// Rigidbody (VTK_LANDMARK_RIGIDBODY): rotation and translation only.
	/// Similarity (VTK_LANDMARK_SIMILARITY): rotation, translation and
	/// isotropic scaling.
	/// Affine (VTK_LANDMARK_AFFINE): collinearity is preserved.
	/// Ratios of distances along a line are preserved.
	/// The default is similarity.
	/// </summary>
	public void SetModeToRigidBody()
	{
		vtkLandmarkTransform_SetModeToRigidBody_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLandmarkTransform_SetModeToSimilarity_18(HandleRef pThis);

	/// <summary>
	/// Set the number of degrees of freedom to constrain the solution to.
	/// Rigidbody (VTK_LANDMARK_RIGIDBODY): rotation and translation only.
	/// Similarity (VTK_LANDMARK_SIMILARITY): rotation, translation and
	/// isotropic scaling.
	/// Affine (VTK_LANDMARK_AFFINE): collinearity is preserved.
	/// Ratios of distances along a line are preserved.
	/// The default is similarity.
	/// </summary>
	public void SetModeToSimilarity()
	{
		vtkLandmarkTransform_SetModeToSimilarity_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLandmarkTransform_SetSourceLandmarks_19(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the source and target landmark sets. The two sets must have
	/// the same number of points.  If you add or change points in these objects,
	/// you must call Modified() on them or the transformation might not update.
	/// </summary>
	public void SetSourceLandmarks(vtkPoints source)
	{
		vtkLandmarkTransform_SetSourceLandmarks_19(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLandmarkTransform_SetTargetLandmarks_20(HandleRef pThis, HandleRef target);

	/// <summary>
	/// Specify the source and target landmark sets. The two sets must have
	/// the same number of points.  If you add or change points in these objects,
	/// you must call Modified() on them or the transformation might not update.
	/// </summary>
	public void SetTargetLandmarks(vtkPoints target)
	{
		vtkLandmarkTransform_SetTargetLandmarks_20(GetCppThis(), target?.GetCppThis() ?? default(HandleRef));
	}
}
