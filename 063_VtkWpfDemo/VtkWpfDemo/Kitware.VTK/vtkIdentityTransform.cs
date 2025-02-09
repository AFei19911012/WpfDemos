using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIdentityTransform
/// </summary>
/// <remarks>
///    a transform that doesn't do anything
///
/// vtkIdentityTransform is a transformation which will simply pass coordinate
/// data unchanged.  All other transform types can also do this, however,
/// the vtkIdentityTransform does so with much greater efficiency.
/// </remarks>
/// <seealso>
///
/// vtkLinearTransform
/// </seealso>
public class vtkIdentityTransform : vtkLinearTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIdentityTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIdentityTransform()
	{
		MRClassNameKey = "class vtkIdentityTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdentityTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIdentityTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdentityTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIdentityTransform New()
	{
		vtkIdentityTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdentityTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIdentityTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIdentityTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIdentityTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkIdentityTransform_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIdentityTransform_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdentityTransform_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIdentityTransform_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdentityTransform_InternalTransformNormal_03(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public override void InternalTransformNormal(IntPtr arg0, IntPtr arg1)
	{
		vtkIdentityTransform_InternalTransformNormal_03(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdentityTransform_InternalTransformPoint_04(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkIdentityTransform_InternalTransformPoint_04(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdentityTransform_InternalTransformVector_05(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public override void InternalTransformVector(IntPtr arg0, IntPtr arg1)
	{
		vtkIdentityTransform_InternalTransformVector_05(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdentityTransform_Inverse_06(HandleRef pThis);

	/// <summary>
	/// Apply the transformation to a combination of points, normals
	/// and vectors.
	/// </summary>
	public override void Inverse()
	{
		vtkIdentityTransform_Inverse_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIdentityTransform_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIdentityTransform_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIdentityTransform_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIdentityTransform_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdentityTransform_MakeTransform_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make a transform of the same type.  This will actually
	/// return the same transform.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdentityTransform_MakeTransform_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdentityTransform_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIdentityTransform NewInstance()
	{
		vtkIdentityTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdentityTransform_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIdentityTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdentityTransform_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIdentityTransform SafeDownCast(vtkObjectBase o)
	{
		vtkIdentityTransform vtkIdentityTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdentityTransform_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdentityTransform2 = (vtkIdentityTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdentityTransform2.Register(null);
			}
		}
		return vtkIdentityTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdentityTransform_TransformNormals_13(HandleRef pThis, HandleRef inNms, HandleRef outNms);

	/// <summary>
	/// Apply the transformation to a series of normals, and append the
	/// results to outNms.
	/// </summary>
	public override void TransformNormals(vtkDataArray inNms, vtkDataArray outNms)
	{
		vtkIdentityTransform_TransformNormals_13(GetCppThis(), inNms?.GetCppThis() ?? default(HandleRef), outNms?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdentityTransform_TransformPoints_14(HandleRef pThis, HandleRef inPts, HandleRef outPts);

	/// <summary>
	/// Apply the transformation to a series of points, and append the
	/// results to outPts.
	/// </summary>
	public override void TransformPoints(vtkPoints inPts, vtkPoints outPts)
	{
		vtkIdentityTransform_TransformPoints_14(GetCppThis(), inPts?.GetCppThis() ?? default(HandleRef), outPts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdentityTransform_TransformVectors_15(HandleRef pThis, HandleRef inVrs, HandleRef outVrs);

	/// <summary>
	/// Apply the transformation to a series of vectors, and append the
	/// results to outVrs.
	/// </summary>
	public override void TransformVectors(vtkDataArray inVrs, vtkDataArray outVrs)
	{
		vtkIdentityTransform_TransformVectors_15(GetCppThis(), inVrs?.GetCppThis() ?? default(HandleRef), outVrs?.GetCppThis() ?? default(HandleRef));
	}
}
