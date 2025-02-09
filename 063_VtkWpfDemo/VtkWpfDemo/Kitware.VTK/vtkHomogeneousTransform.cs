using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHomogeneousTransform
/// </summary>
/// <remarks>
///    superclass for homogeneous transformations
///
/// vtkHomogeneousTransform provides a generic interface for homogeneous
/// transformations, i.e. transformations which can be represented by
/// multiplying a 4x4 matrix with a homogeneous coordinate.
/// </remarks>
/// <seealso>
///
/// vtkPerspectiveTransform vtkLinearTransform vtkIdentityTransform
/// </seealso>
public abstract class vtkHomogeneousTransform : vtkAbstractTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHomogeneousTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHomogeneousTransform()
	{
		MRClassNameKey = "class vtkHomogeneousTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHomogeneousTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHomogeneousTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkHomogeneousTransform_GetHomogeneousInverse_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Just like GetInverse(), but includes typecast to vtkHomogeneousTransform.
	/// </summary>
	public vtkHomogeneousTransform GetHomogeneousInverse()
	{
		vtkHomogeneousTransform vtkHomogeneousTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHomogeneousTransform_GetHomogeneousInverse_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHomogeneousTransform2 = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHomogeneousTransform2.Register(null);
			}
		}
		return vtkHomogeneousTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHomogeneousTransform_GetMatrix_02(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Get a copy of the internal transformation matrix.  The
	/// transform is Updated first, to guarantee that the matrix
	/// is valid.
	/// </summary>
	public void GetMatrix(vtkMatrix4x4 m)
	{
		vtkHomogeneousTransform_GetMatrix_02(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHomogeneousTransform_GetMatrix_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to an internal vtkMatrix4x4 that represents
	/// the transformation.  An Update() is called on the transform
	/// to ensure that the matrix is up-to-date when you get it.
	/// You should not store the matrix pointer anywhere because it
	/// might become stale.
	/// </summary>
	public vtkMatrix4x4 GetMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHomogeneousTransform_GetMatrix_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHomogeneousTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHomogeneousTransform_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHomogeneousTransform_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHomogeneousTransform_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHomogeneousTransform_InternalTransformPoint_06(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkHomogeneousTransform_InternalTransformPoint_06(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHomogeneousTransform_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHomogeneousTransform_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHomogeneousTransform_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHomogeneousTransform_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHomogeneousTransform_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHomogeneousTransform NewInstance()
	{
		vtkHomogeneousTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHomogeneousTransform_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHomogeneousTransform_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHomogeneousTransform SafeDownCast(vtkObjectBase o)
	{
		vtkHomogeneousTransform vtkHomogeneousTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHomogeneousTransform_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHomogeneousTransform2 = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHomogeneousTransform2.Register(null);
			}
		}
		return vtkHomogeneousTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHomogeneousTransform_TransformPoints_11(HandleRef pThis, HandleRef inPts, HandleRef outPts);

	/// <summary>
	/// Apply the transformation to a series of points, and append the
	/// results to outPts.
	/// </summary>
	public override void TransformPoints(vtkPoints inPts, vtkPoints outPts)
	{
		vtkHomogeneousTransform_TransformPoints_11(GetCppThis(), inPts?.GetCppThis() ?? default(HandleRef), outPts?.GetCppThis() ?? default(HandleRef));
	}
}
