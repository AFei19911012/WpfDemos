using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWarpTransform
/// </summary>
/// <remarks>
///    superclass for nonlinear geometric transformations
///
/// vtkWarpTransform provides a generic interface for nonlinear
/// warp transformations.
/// </remarks>
/// <seealso>
///
/// vtkThinPlateSplineTransform vtkGridTransform vtkGeneralTransform
/// </seealso>
public abstract class vtkWarpTransform : vtkAbstractTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWarpTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWarpTransform()
	{
		MRClassNameKey = "class vtkWarpTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWarpTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern int vtkWarpTransform_GetInverseFlag_01(HandleRef pThis);

	/// <summary>
	/// Get the inverse flag of the transformation.  This flag is
	/// set to zero when the transformation is first created, and
	/// is flipped each time Inverse() is called.
	/// </summary>
	public virtual int GetInverseFlag()
	{
		return vtkWarpTransform_GetInverseFlag_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpTransform_GetInverseIterations_02(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of iterations for the inverse
	/// transformation.  The default is 500, but usually only
	/// 2 to 5 iterations are used.  The inversion method
	/// is fairly robust, and it should converge for nearly all smooth
	/// transformations that do not fold back on themselves.
	/// </summary>
	public virtual int GetInverseIterations()
	{
		return vtkWarpTransform_GetInverseIterations_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpTransform_GetInverseTolerance_03(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for inverse transformation.
	/// The default is 0.001.
	/// </summary>
	public virtual double GetInverseTolerance()
	{
		return vtkWarpTransform_GetInverseTolerance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWarpTransform_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpTransform_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWarpTransform_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTransform_InternalTransformPoint_06(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkWarpTransform_InternalTransformPoint_06(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTransform_Inverse_07(HandleRef pThis);

	/// <summary>
	/// Invert the transformation.  Warp transformations are usually
	/// inverted using an iterative technique such as Newton's method.
	/// The inverse transform is usually around five or six times as
	/// computationally expensive as the forward transform.
	/// </summary>
	public override void Inverse()
	{
		vtkWarpTransform_Inverse_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpTransform_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWarpTransform_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpTransform_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWarpTransform_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpTransform_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWarpTransform NewInstance()
	{
		vtkWarpTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpTransform_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWarpTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpTransform_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWarpTransform SafeDownCast(vtkObjectBase o)
	{
		vtkWarpTransform vtkWarpTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpTransform_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWarpTransform2 = (vtkWarpTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWarpTransform2.Register(null);
			}
		}
		return vtkWarpTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTransform_SetInverseIterations_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the maximum number of iterations for the inverse
	/// transformation.  The default is 500, but usually only
	/// 2 to 5 iterations are used.  The inversion method
	/// is fairly robust, and it should converge for nearly all smooth
	/// transformations that do not fold back on themselves.
	/// </summary>
	public virtual void SetInverseIterations(int _arg)
	{
		vtkWarpTransform_SetInverseIterations_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTransform_SetInverseTolerance_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tolerance for inverse transformation.
	/// The default is 0.001.
	/// </summary>
	public virtual void SetInverseTolerance(double _arg)
	{
		vtkWarpTransform_SetInverseTolerance_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTransform_TemplateTransformInverse_14(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Do not use these methods.  They exists only as a work-around for
	/// internal templated functions (I really didn't want to make the
	/// Forward/Inverse methods public, is there a decent work around
	/// for this sort of thing?)
	/// </summary>
	public void TemplateTransformInverse(IntPtr arg0, IntPtr arg1)
	{
		vtkWarpTransform_TemplateTransformInverse_14(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpTransform_TemplateTransformPoint_15(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Do not use these methods.  They exists only as a work-around for
	/// internal templated functions (I really didn't want to make the
	/// Forward/Inverse methods public, is there a decent work around
	/// for this sort of thing?)
	/// </summary>
	public void TemplateTransformPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkWarpTransform_TemplateTransformPoint_15(GetCppThis(), arg0, arg1);
	}
}
