using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkThinPlateSplineTransform
/// </summary>
/// <remarks>
///    a nonlinear warp transformation
///
/// vtkThinPlateSplineTransform describes a nonlinear warp transform defined
/// by a set of source and target landmarks. Any point on the mesh close to a
/// source landmark will be moved to a place close to the corresponding target
/// landmark. The points in between are interpolated smoothly using
/// Bookstein's Thin Plate Spline algorithm.
///
/// To obtain a correct TPS warp, use the R2LogR kernel if your data is 2D, and
/// the R kernel if your data is 3D. Or you can specify your own RBF. (Hence this
/// class is more general than a pure TPS transform.)
/// @warning
/// 1) The inverse transform is calculated using an iterative method,
/// and is several times more expensive than the forward transform.
/// 2) Whenever you add, subtract, or set points you must call Modified()
/// on the vtkPoints object, or the transformation might not update.
/// 3) Collinear point configurations (except those that lie in the XY plane)
/// result in an unstable transformation. Forward transform can be computed
/// for any configuration by disabling bulk transform regularization.
/// </remarks>
/// <seealso>
///
/// vtkGridTransform vtkGeneralTransform
/// </seealso>
public class vtkThinPlateSplineTransform : vtkWarpTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkThinPlateSplineTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkThinPlateSplineTransform()
	{
		MRClassNameKey = "class vtkThinPlateSplineTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkThinPlateSplineTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkThinPlateSplineTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThinPlateSplineTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThinPlateSplineTransform New()
	{
		vtkThinPlateSplineTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThinPlateSplineTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThinPlateSplineTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkThinPlateSplineTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkThinPlateSplineTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkThinPlateSplineTransform_GetBasis_01(HandleRef pThis);

	/// <summary>
	/// Specify the radial basis function to use.  The default is
	/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
	/// if your data is 3D. Alternatively specify your own basis function,
	/// however this will mean that the transform will no longer be a true
	/// thin-plate spline.
	/// </summary>
	public virtual int GetBasis()
	{
		return vtkThinPlateSplineTransform_GetBasis_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThinPlateSplineTransform_GetBasisAsString_02(HandleRef pThis);

	/// <summary>
	/// Specify the radial basis function to use.  The default is
	/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
	/// if your data is 3D. Alternatively specify your own basis function,
	/// however this will mean that the transform will no longer be a true
	/// thin-plate spline.
	/// </summary>
	public string GetBasisAsString()
	{
		return Marshal.PtrToStringAnsi(vtkThinPlateSplineTransform_GetBasisAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkThinPlateSplineTransform_GetMTime_03(HandleRef pThis);

	/// <summary>
	/// Get the MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkThinPlateSplineTransform_GetMTime_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThinPlateSplineTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkThinPlateSplineTransform_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThinPlateSplineTransform_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkThinPlateSplineTransform_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkThinPlateSplineTransform_GetRegularizeBulkTransform_06(HandleRef pThis);

	/// <summary>
	/// Get/set whether the bulk linear transformation matrix is regularized.
	///
	/// If regularization is enabled: If all landmark points are on the
	/// XY plane then forward and inverse transforms are computed correctly.
	/// For other coplanar configurations, both forward an inverse transform
	/// computation is unstable.
	///
	/// If regularization is disabled: Forward transform is computed correctly
	/// for all point configurations. Inverse transform computation is unstable
	/// if source and/or target points are coplanar.
	///
	/// If landmarks points are not coplanar then this setting has no effect.
	///
	/// The default is true.
	/// </summary>
	public virtual bool GetRegularizeBulkTransform()
	{
		return (vtkThinPlateSplineTransform_GetRegularizeBulkTransform_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkThinPlateSplineTransform_GetSigma_07(HandleRef pThis);

	/// <summary>
	/// Specify the 'stiffness' of the spline. The default is 1.0.
	/// </summary>
	public virtual double GetSigma()
	{
		return vtkThinPlateSplineTransform_GetSigma_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThinPlateSplineTransform_GetSourceLandmarks_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the source landmarks for the warp.  If you add or change the
	/// vtkPoints object, you must call Modified() on it or the transformation
	/// might not update.
	/// </summary>
	public virtual vtkPoints GetSourceLandmarks()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThinPlateSplineTransform_GetSourceLandmarks_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkThinPlateSplineTransform_GetTargetLandmarks_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the target landmarks for the warp.  If you add or change the
	/// vtkPoints object, you must call Modified() on it or the transformation
	/// might not update.
	/// </summary>
	public virtual vtkPoints GetTargetLandmarks()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThinPlateSplineTransform_GetTargetLandmarks_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkThinPlateSplineTransform_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkThinPlateSplineTransform_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThinPlateSplineTransform_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkThinPlateSplineTransform_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThinPlateSplineTransform_MakeTransform_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make another transform of the same type.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThinPlateSplineTransform_MakeTransform_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThinPlateSplineTransform_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkThinPlateSplineTransform NewInstance()
	{
		vtkThinPlateSplineTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThinPlateSplineTransform_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThinPlateSplineTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThinPlateSplineTransform_RegularizeBulkTransformOff_15(HandleRef pThis);

	/// <summary>
	/// Get/set whether the bulk linear transformation matrix is regularized.
	///
	/// If regularization is enabled: If all landmark points are on the
	/// XY plane then forward and inverse transforms are computed correctly.
	/// For other coplanar configurations, both forward an inverse transform
	/// computation is unstable.
	///
	/// If regularization is disabled: Forward transform is computed correctly
	/// for all point configurations. Inverse transform computation is unstable
	/// if source and/or target points are coplanar.
	///
	/// If landmarks points are not coplanar then this setting has no effect.
	///
	/// The default is true.
	/// </summary>
	public virtual void RegularizeBulkTransformOff()
	{
		vtkThinPlateSplineTransform_RegularizeBulkTransformOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThinPlateSplineTransform_RegularizeBulkTransformOn_16(HandleRef pThis);

	/// <summary>
	/// Get/set whether the bulk linear transformation matrix is regularized.
	///
	/// If regularization is enabled: If all landmark points are on the
	/// XY plane then forward and inverse transforms are computed correctly.
	/// For other coplanar configurations, both forward an inverse transform
	/// computation is unstable.
	///
	/// If regularization is disabled: Forward transform is computed correctly
	/// for all point configurations. Inverse transform computation is unstable
	/// if source and/or target points are coplanar.
	///
	/// If landmarks points are not coplanar then this setting has no effect.
	///
	/// The default is true.
	/// </summary>
	public virtual void RegularizeBulkTransformOn()
	{
		vtkThinPlateSplineTransform_RegularizeBulkTransformOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThinPlateSplineTransform_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThinPlateSplineTransform SafeDownCast(vtkObjectBase o)
	{
		vtkThinPlateSplineTransform vtkThinPlateSplineTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThinPlateSplineTransform_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkThinPlateSplineTransform2 = (vtkThinPlateSplineTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkThinPlateSplineTransform2.Register(null);
			}
		}
		return vtkThinPlateSplineTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThinPlateSplineTransform_SetBasis_18(HandleRef pThis, int basis);

	/// <summary>
	/// Specify the radial basis function to use.  The default is
	/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
	/// if your data is 3D. Alternatively specify your own basis function,
	/// however this will mean that the transform will no longer be a true
	/// thin-plate spline.
	/// </summary>
	public void SetBasis(int basis)
	{
		vtkThinPlateSplineTransform_SetBasis_18(GetCppThis(), basis);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThinPlateSplineTransform_SetBasisToR_19(HandleRef pThis);

	/// <summary>
	/// Specify the radial basis function to use.  The default is
	/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
	/// if your data is 3D. Alternatively specify your own basis function,
	/// however this will mean that the transform will no longer be a true
	/// thin-plate spline.
	/// </summary>
	public void SetBasisToR()
	{
		vtkThinPlateSplineTransform_SetBasisToR_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThinPlateSplineTransform_SetBasisToR2LogR_20(HandleRef pThis);

	/// <summary>
	/// Specify the radial basis function to use.  The default is
	/// R2LogR which is appropriate for 2D. Use |R| (SetBasisToR)
	/// if your data is 3D. Alternatively specify your own basis function,
	/// however this will mean that the transform will no longer be a true
	/// thin-plate spline.
	/// </summary>
	public void SetBasisToR2LogR()
	{
		vtkThinPlateSplineTransform_SetBasisToR2LogR_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThinPlateSplineTransform_SetRegularizeBulkTransform_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set whether the bulk linear transformation matrix is regularized.
	///
	/// If regularization is enabled: If all landmark points are on the
	/// XY plane then forward and inverse transforms are computed correctly.
	/// For other coplanar configurations, both forward an inverse transform
	/// computation is unstable.
	///
	/// If regularization is disabled: Forward transform is computed correctly
	/// for all point configurations. Inverse transform computation is unstable
	/// if source and/or target points are coplanar.
	///
	/// If landmarks points are not coplanar then this setting has no effect.
	///
	/// The default is true.
	/// </summary>
	public virtual void SetRegularizeBulkTransform(bool _arg)
	{
		vtkThinPlateSplineTransform_SetRegularizeBulkTransform_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThinPlateSplineTransform_SetSigma_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the 'stiffness' of the spline. The default is 1.0.
	/// </summary>
	public virtual void SetSigma(double _arg)
	{
		vtkThinPlateSplineTransform_SetSigma_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThinPlateSplineTransform_SetSourceLandmarks_23(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Set the source landmarks for the warp.  If you add or change the
	/// vtkPoints object, you must call Modified() on it or the transformation
	/// might not update.
	/// </summary>
	public void SetSourceLandmarks(vtkPoints source)
	{
		vtkThinPlateSplineTransform_SetSourceLandmarks_23(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThinPlateSplineTransform_SetTargetLandmarks_24(HandleRef pThis, HandleRef target);

	/// <summary>
	/// Set the target landmarks for the warp.  If you add or change the
	/// vtkPoints object, you must call Modified() on it or the transformation
	/// might not update.
	/// </summary>
	public void SetTargetLandmarks(vtkPoints target)
	{
		vtkThinPlateSplineTransform_SetTargetLandmarks_24(GetCppThis(), target?.GetCppThis() ?? default(HandleRef));
	}
}
