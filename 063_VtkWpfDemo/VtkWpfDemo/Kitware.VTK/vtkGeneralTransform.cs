using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGeneralTransform
/// </summary>
/// <remarks>
///    allows operations on any transforms
///
/// vtkGeneralTransform is like vtkTransform and vtkPerspectiveTransform,
/// but it will work with any vtkAbstractTransform as input.  It is
/// not as efficient as the other two, however, because arbitrary
/// transformations cannot be concatenated by matrix multiplication.
/// Transform concatenation is simulated by passing each input point
/// through each transform in turn.
/// </remarks>
/// <seealso>
///
/// vtkTransform vtkPerspectiveTransform
/// </seealso>
public class vtkGeneralTransform : vtkAbstractTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGeneralTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGeneralTransform()
	{
		MRClassNameKey = "class vtkGeneralTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeneralTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGeneralTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeneralTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGeneralTransform New()
	{
		vtkGeneralTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeneralTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeneralTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGeneralTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGeneralTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkGeneralTransform_CircuitCheck_01(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Check for self-reference.  Will return true if concatenating
	/// with the specified transform, setting it to be our inverse,
	/// or setting it to be our input will create a circular reference.
	/// CircuitCheck is automatically called by SetInput(), SetInverse(),
	/// and Concatenate(vtkXTransform *).  Avoid using this function,
	/// it is experimental.
	/// </summary>
	public override int CircuitCheck(vtkAbstractTransform transform)
	{
		return vtkGeneralTransform_CircuitCheck_01(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Concatenate_02(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Concatenates the matrix with the current transformation according
	/// to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Concatenate(vtkMatrix4x4 matrix)
	{
		vtkGeneralTransform_Concatenate_02(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Concatenate_03(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Concatenates the matrix with the current transformation according
	/// to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Concatenate(IntPtr elements)
	{
		vtkGeneralTransform_Concatenate_03(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Concatenate_04(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Concatenate the specified transform with the current transformation
	/// according to PreMultiply or PostMultiply semantics.
	/// The concatenation is pipelined, meaning that if any of the
	/// transformations are changed, even after Concatenate() is called,
	/// those changes will be reflected when you call TransformPoint().
	/// </summary>
	public void Concatenate(vtkAbstractTransform transform)
	{
		vtkGeneralTransform_Concatenate_04(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeneralTransform_GetConcatenatedTransform_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get one of the concatenated transformations as a vtkAbstractTransform.
	/// These transformations are applied, in series, every time the
	/// transformation of a coordinate occurs.  This method is provided
	/// to make it possible to decompose a transformation into its
	/// constituents, for example to save a transformation to a file.
	/// </summary>
	public vtkAbstractTransform GetConcatenatedTransform(int i)
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeneralTransform_GetConcatenatedTransform_05(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeneralTransform_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the input for this transformation.  This will be used as the
	/// base transformation if it is set.  This method allows you to build
	/// a transform pipeline: if the input is modified, then this transformation
	/// will automatically update accordingly.  Note that the InverseFlag,
	/// controlled via Inverse(), determines whether this transformation
	/// will use the Input or the inverse of the Input.
	/// </summary>
	public vtkAbstractTransform GetInput()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeneralTransform_GetInput_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralTransform_GetInverseFlag_07(HandleRef pThis);

	/// <summary>
	/// Get the inverse flag of the transformation.  This controls
	/// whether it is the Input or the inverse of the Input that
	/// is used as the base transformation.  The InverseFlag is
	/// flipped every time Inverse() is called.  The InverseFlag
	/// is off when a transform is first created.
	/// </summary>
	public int GetInverseFlag()
	{
		return vtkGeneralTransform_GetInverseFlag_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGeneralTransform_GetMTime_08(HandleRef pThis);

	/// <summary>
	/// Override GetMTime to account for input and concatenation.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGeneralTransform_GetMTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralTransform_GetNumberOfConcatenatedTransforms_09(HandleRef pThis);

	/// <summary>
	/// Get the total number of transformations that are linked into this
	/// one via Concatenate() operations or via SetInput().
	/// </summary>
	public int GetNumberOfConcatenatedTransforms()
	{
		return vtkGeneralTransform_GetNumberOfConcatenatedTransforms_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeneralTransform_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGeneralTransform_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeneralTransform_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGeneralTransform_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Identity_12(HandleRef pThis);

	/// <summary>
	/// Set this transformation to the identity transformation.  If
	/// the transform has an Input, then the transformation will be
	/// reset so that it is the same as the Input.
	/// </summary>
	public void Identity()
	{
		vtkGeneralTransform_Identity_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_InternalTransformPoint_13(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkGeneralTransform_InternalTransformPoint_13(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Inverse_14(HandleRef pThis);

	/// <summary>
	/// Invert the transformation.  This will also set a flag so that
	/// the transformation will use the inverse of its Input, if an Input
	/// has been set.
	/// </summary>
	public override void Inverse()
	{
		vtkGeneralTransform_Inverse_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralTransform_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGeneralTransform_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralTransform_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGeneralTransform_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeneralTransform_MakeTransform_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make another transform of the same type.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeneralTransform_MakeTransform_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeneralTransform_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGeneralTransform NewInstance()
	{
		vtkGeneralTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeneralTransform_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeneralTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Pop_20(HandleRef pThis);

	/// <summary>
	/// Deletes the transformation on the top of the stack and sets the top
	/// to the next transformation on the stack.
	/// </summary>
	public void Pop()
	{
		vtkGeneralTransform_Pop_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_PostMultiply_21(HandleRef pThis);

	/// <summary>
	/// Sets the internal state of the transform to PostMultiply. All subsequent
	/// operations will occur after those already represented in the
	/// current transformation.  In homogeneous matrix notation, M = A*M where
	/// M is the current transformation matrix and A is the applied matrix.
	/// The default is PreMultiply.
	/// </summary>
	public void PostMultiply()
	{
		vtkGeneralTransform_PostMultiply_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_PreMultiply_22(HandleRef pThis);

	/// <summary>
	/// Sets the internal state of the transform to PreMultiply. All subsequent
	/// operations will occur before those already represented in the
	/// current transformation.  In homogeneous matrix notation, M = M*A where
	/// M is the current transformation matrix and A is the applied matrix.
	/// The default is PreMultiply.
	/// </summary>
	public void PreMultiply()
	{
		vtkGeneralTransform_PreMultiply_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Push_23(HandleRef pThis);

	/// <summary>
	/// Pushes the current transformation onto the transformation stack.
	/// </summary>
	public void Push()
	{
		vtkGeneralTransform_Push_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_RotateWXYZ_24(HandleRef pThis, double angle, double x, double y, double z);

	/// <summary>
	/// Create a rotation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// The angle is in degrees, and (x,y,z) specifies the axis that the
	/// rotation will be performed around.
	/// </summary>
	public void RotateWXYZ(double angle, double x, double y, double z)
	{
		vtkGeneralTransform_RotateWXYZ_24(GetCppThis(), angle, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_RotateWXYZ_25(HandleRef pThis, double angle, IntPtr axis);

	/// <summary>
	/// Create a rotation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// The angle is in degrees, and (x,y,z) specifies the axis that the
	/// rotation will be performed around.
	/// </summary>
	public void RotateWXYZ(double angle, IntPtr axis)
	{
		vtkGeneralTransform_RotateWXYZ_25(GetCppThis(), angle, axis);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_RotateX_26(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix about the X, Y, or Z axis and concatenate
	/// it with the current transformation according to PreMultiply or
	/// PostMultiply semantics.  The angle is expressed in degrees.
	/// </summary>
	public void RotateX(double angle)
	{
		vtkGeneralTransform_RotateX_26(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_RotateY_27(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix about the X, Y, or Z axis and concatenate
	/// it with the current transformation according to PreMultiply or
	/// PostMultiply semantics.  The angle is expressed in degrees.
	/// </summary>
	public void RotateY(double angle)
	{
		vtkGeneralTransform_RotateY_27(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_RotateZ_28(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix about the X, Y, or Z axis and concatenate
	/// it with the current transformation according to PreMultiply or
	/// PostMultiply semantics.  The angle is expressed in degrees.
	/// </summary>
	public void RotateZ(double angle)
	{
		vtkGeneralTransform_RotateZ_28(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeneralTransform_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGeneralTransform SafeDownCast(vtkObjectBase o)
	{
		vtkGeneralTransform vtkGeneralTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeneralTransform_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGeneralTransform2 = (vtkGeneralTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGeneralTransform2.Register(null);
			}
		}
		return vtkGeneralTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Scale_30(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
	/// and concatenate it with the current transformation according to
	/// PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Scale(double x, double y, double z)
	{
		vtkGeneralTransform_Scale_30(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Scale_31(HandleRef pThis, IntPtr s);

	/// <summary>
	/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
	/// and concatenate it with the current transformation according to
	/// PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Scale(IntPtr s)
	{
		vtkGeneralTransform_Scale_31(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_SetInput_32(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the input for this transformation.  This will be used as the
	/// base transformation if it is set.  This method allows you to build
	/// a transform pipeline: if the input is modified, then this transformation
	/// will automatically update accordingly.  Note that the InverseFlag,
	/// controlled via Inverse(), determines whether this transformation
	/// will use the Input or the inverse of the Input.
	/// </summary>
	public void SetInput(vtkAbstractTransform input)
	{
		vtkGeneralTransform_SetInput_32(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Translate_33(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Create a translation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Translate(double x, double y, double z)
	{
		vtkGeneralTransform_Translate_33(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralTransform_Translate_34(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Create a translation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Translate(IntPtr x)
	{
		vtkGeneralTransform_Translate_34(GetCppThis(), x);
	}
}
