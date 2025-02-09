using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTransform
/// </summary>
/// <remarks>
///    describes linear transformations via a 4x4 matrix
///
/// A vtkTransform can be used to describe the full range of linear (also
/// known as affine) coordinate transformations in three dimensions,
/// which are internally represented as a 4x4 homogeneous transformation
/// matrix.  When you create a new vtkTransform, it is always initialized
/// to the identity transformation.
/// &lt;P&gt;The SetInput() method allows you to set another transform,
/// instead of the identity transform, to be the base transformation.
/// There is a pipeline mechanism to ensure that when the input is
/// modified, the current transformation will be updated accordingly.
/// This pipeline mechanism is also supported by the Concatenate() method.
/// &lt;P&gt;Most of the methods for manipulating this transformation,
/// e.g. Translate, Rotate, and Concatenate, can operate in either
/// PreMultiply (the default) or PostMultiply mode.  In PreMultiply
/// mode, the translation, concatenation, etc. will occur before any
/// transformations which are represented by the current matrix.  In
/// PostMultiply mode, the additional transformation will occur after
/// any transformations represented by the current matrix.
/// &lt;P&gt;This class performs all of its operations in a right handed
/// coordinate system with right handed rotations. Some other graphics
/// libraries use left handed coordinate systems and rotations.
/// </remarks>
/// <seealso>
///
/// vtkPerspectiveTransform vtkGeneralTransform vtkMatrix4x4
/// vtkTransformCollection vtkTransformFilter vtkTransformPolyDataFilter
/// vtkImageReslice
/// </seealso>
public class vtkTransform : vtkLinearTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTransform()
	{
		MRClassNameKey = "class vtkTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransform New()
	{
		vtkTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTransform_CircuitCheck_01(HandleRef pThis, HandleRef transform);

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
		return vtkTransform_CircuitCheck_01(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Concatenate_02(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Concatenates the matrix with the current transformation according
	/// to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Concatenate(vtkMatrix4x4 matrix)
	{
		vtkTransform_Concatenate_02(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Concatenate_03(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Concatenates the matrix with the current transformation according
	/// to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Concatenate(IntPtr elements)
	{
		vtkTransform_Concatenate_03(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Concatenate_04(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Concatenate the specified transform with the current transformation
	/// according to PreMultiply or PostMultiply semantics.
	/// The concatenation is pipelined, meaning that if any of the
	/// transformations are changed, even after Concatenate() is called,
	/// those changes will be reflected when you call TransformPoint().
	/// </summary>
	public void Concatenate(vtkLinearTransform transform)
	{
		vtkTransform_Concatenate_04(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_GetConcatenatedTransform_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get one of the concatenated transformations as a vtkAbstractTransform.
	/// These transformations are applied, in series, every time the
	/// transformation of a coordinate occurs.  This method is provided
	/// to make it possible to decompose a transformation into its
	/// constituents, for example to save a transformation to a file.
	/// </summary>
	public vtkLinearTransform GetConcatenatedTransform(int i)
	{
		vtkLinearTransform vtkLinearTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform_GetConcatenatedTransform_05(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinearTransform2 = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinearTransform2.Register(null);
			}
		}
		return vtkLinearTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the input for this transformation.  This will be used as the
	/// base transformation if it is set.  This method allows you to build
	/// a transform pipeline: if the input is modified, then this transformation
	/// will automatically update accordingly.  Note that the InverseFlag,
	/// controlled via Inverse(), determines whether this transformation
	/// will use the Input or the inverse of the Input.
	/// </summary>
	public vtkLinearTransform GetInput()
	{
		vtkLinearTransform vtkLinearTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform_GetInput_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinearTransform2 = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinearTransform2.Register(null);
			}
		}
		return vtkLinearTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_GetInverse_07(HandleRef pThis, HandleRef inverse);

	/// <summary>
	/// Return a matrix which is the inverse of the current transformation
	/// matrix.
	/// </summary>
	public void GetInverse(vtkMatrix4x4 inverse)
	{
		vtkTransform_GetInverse_07(GetCppThis(), inverse?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_GetInverse_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Check for self-reference.  Will return true if concatenating
	/// with the specified transform, setting it to be our inverse,
	/// or setting it to be our input will create a circular reference.
	/// CircuitCheck is automatically called by SetInput(), SetInverse(),
	/// and Concatenate(vtkXTransform *).  Avoid using this function,
	/// it is experimental.
	/// </summary>
	public new vtkAbstractTransform GetInverse()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform_GetInverse_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTransform_GetInverseFlag_09(HandleRef pThis);

	/// <summary>
	/// Get the inverse flag of the transformation.  This controls
	/// whether it is the Input or the inverse of the Input that
	/// is used as the base transformation.  The InverseFlag is
	/// flipped every time Inverse() is called.  The InverseFlag
	/// is off when a transform is first created.
	/// </summary>
	public int GetInverseFlag()
	{
		return vtkTransform_GetInverseFlag_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTransform_GetMTime_10(HandleRef pThis);

	/// <summary>
	/// Override GetMTime to account for input and concatenation.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTransform_GetMTime_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransform_GetNumberOfConcatenatedTransforms_11(HandleRef pThis);

	/// <summary>
	/// Get the total number of transformations that are linked into this
	/// one via Concatenate() operations or via SetInput().
	/// </summary>
	public int GetNumberOfConcatenatedTransforms()
	{
		return vtkTransform_GetNumberOfConcatenatedTransforms_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransform_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTransform_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransform_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTransform_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_GetOrientation_14(HandleRef pThis, IntPtr orient);

	/// <summary>
	/// Get the x, y, z orientation angles from the transformation matrix as an
	/// array of three floating point values.
	/// </summary>
	public void GetOrientation(IntPtr orient)
	{
		vtkTransform_GetOrientation_14(GetCppThis(), orient);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_GetOrientation_15(HandleRef pThis);

	/// <summary>
	/// Get the x, y, z orientation angles from the transformation matrix as an
	/// array of three floating point values.
	/// </summary>
	public double[] GetOrientation()
	{
		IntPtr intPtr = vtkTransform_GetOrientation_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_GetOrientation_16(IntPtr orient, HandleRef matrix);

	/// <summary>
	/// Convenience function to get the x, y, z orientation angles from
	/// a transformation matrix as an array of three floating point values.
	/// </summary>
	public static void GetOrientation(IntPtr orient, vtkMatrix4x4 matrix)
	{
		vtkTransform_GetOrientation_16(orient, matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_GetOrientationWXYZ_17(HandleRef pThis, IntPtr wxyz);

	/// <summary>
	/// Return the wxyz angle+axis representing the current orientation.
	/// The angle is in degrees and the axis is a unit vector.
	/// </summary>
	public void GetOrientationWXYZ(IntPtr wxyz)
	{
		vtkTransform_GetOrientationWXYZ_17(GetCppThis(), wxyz);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_GetOrientationWXYZ_18(HandleRef pThis);

	/// <summary>
	/// Return the wxyz angle+axis representing the current orientation.
	/// The angle is in degrees and the axis is a unit vector.
	/// </summary>
	public double[] GetOrientationWXYZ()
	{
		IntPtr intPtr = vtkTransform_GetOrientationWXYZ_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_GetPosition_19(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Return the position from the current transformation matrix as an array
	/// of three floating point numbers. This is simply returning the translation
	/// component of the 4x4 matrix.
	/// </summary>
	public void GetPosition(IntPtr pos)
	{
		vtkTransform_GetPosition_19(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_GetPosition_20(HandleRef pThis);

	/// <summary>
	/// Return the position from the current transformation matrix as an array
	/// of three floating point numbers. This is simply returning the translation
	/// component of the 4x4 matrix.
	/// </summary>
	public double[] GetPosition()
	{
		IntPtr intPtr = vtkTransform_GetPosition_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_GetScale_21(HandleRef pThis, IntPtr scale);

	/// <summary>
	/// Return the scale factors of the current transformation matrix as
	/// an array of three float numbers.  These scale factors are not necessarily
	/// about the x, y, and z axes unless unless the scale transformation was
	/// applied before any rotations.
	/// </summary>
	public void GetScale(IntPtr scale)
	{
		vtkTransform_GetScale_21(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_GetScale_22(HandleRef pThis);

	/// <summary>
	/// Return the scale factors of the current transformation matrix as
	/// an array of three float numbers.  These scale factors are not necessarily
	/// about the x, y, and z axes unless unless the scale transformation was
	/// applied before any rotations.
	/// </summary>
	public double[] GetScale()
	{
		IntPtr intPtr = vtkTransform_GetScale_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_GetTranspose_23(HandleRef pThis, HandleRef transpose);

	/// <summary>
	/// Return a matrix which is the transpose of the current transformation
	/// matrix.  This is equivalent to the inverse if and only if the
	/// transformation is a pure rotation with no translation or scale.
	/// </summary>
	public void GetTranspose(vtkMatrix4x4 transpose)
	{
		vtkTransform_GetTranspose_23(GetCppThis(), transpose?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Identity_24(HandleRef pThis);

	/// <summary>
	/// Set the transformation to the identity transformation.  If
	/// the transform has an Input, then the transformation will be
	/// reset so that it is the same as the Input.
	/// </summary>
	public void Identity()
	{
		vtkTransform_Identity_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Inverse_25(HandleRef pThis);

	/// <summary>
	/// Invert the transformation.  This will also set a flag so that
	/// the transformation will use the inverse of its Input, if an Input
	/// has been set.
	/// </summary>
	public override void Inverse()
	{
		vtkTransform_Inverse_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransform_IsA_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTransform_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransform_IsTypeOf_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTransform_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_MakeTransform_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make a new transform of the same type.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform_MakeTransform_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_MultiplyPoint_29(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Use this method only if you wish to compute the transformation in
	/// homogeneous (x,y,z,w) coordinates, otherwise use TransformPoint().
	/// This method calls this-&gt;GetMatrix()-&gt;MultiplyPoint().
	/// </summary>
	public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkTransform_MultiplyPoint_29(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTransform NewInstance()
	{
		vtkTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Pop_32(HandleRef pThis);

	/// <summary>
	/// Deletes the transformation on the top of the stack and sets the top
	/// to the next transformation on the stack.
	/// </summary>
	public void Pop()
	{
		vtkTransform_Pop_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_PostMultiply_33(HandleRef pThis);

	/// <summary>
	/// Sets the internal state of the transform to PostMultiply. All subsequent
	/// operations will occur after those already represented in the
	/// current transformation.  In homogeneous matrix notation, M = A*M where
	/// M is the current transformation matrix and A is the applied matrix.
	/// The default is PreMultiply.
	/// </summary>
	public void PostMultiply()
	{
		vtkTransform_PostMultiply_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_PreMultiply_34(HandleRef pThis);

	/// <summary>
	/// Sets the internal state of the transform to PreMultiply. All subsequent
	/// operations will occur before those already represented in the
	/// current transformation.  In homogeneous matrix notation, M = M*A where
	/// M is the current transformation matrix and A is the applied matrix.
	/// The default is PreMultiply.
	/// </summary>
	public void PreMultiply()
	{
		vtkTransform_PreMultiply_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Push_35(HandleRef pThis);

	/// <summary>
	/// Pushes the current transformation onto the transformation stack.
	/// </summary>
	public void Push()
	{
		vtkTransform_Push_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_RotateWXYZ_36(HandleRef pThis, double angle, double x, double y, double z);

	/// <summary>
	/// Create a rotation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// The angle is in degrees, and (x,y,z) specifies the axis that the
	/// rotation will be performed around.
	/// </summary>
	public void RotateWXYZ(double angle, double x, double y, double z)
	{
		vtkTransform_RotateWXYZ_36(GetCppThis(), angle, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_RotateWXYZ_37(HandleRef pThis, double angle, IntPtr axis);

	/// <summary>
	/// Create a rotation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// The angle is in degrees, and (x,y,z) specifies the axis that the
	/// rotation will be performed around.
	/// </summary>
	public void RotateWXYZ(double angle, IntPtr axis)
	{
		vtkTransform_RotateWXYZ_37(GetCppThis(), angle, axis);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_RotateX_38(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix about the X, Y, or Z axis and concatenate
	/// it with the current transformation according to PreMultiply or
	/// PostMultiply semantics.  The angle is expressed in degrees.
	/// </summary>
	public void RotateX(double angle)
	{
		vtkTransform_RotateX_38(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_RotateY_39(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix about the X, Y, or Z axis and concatenate
	/// it with the current transformation according to PreMultiply or
	/// PostMultiply semantics.  The angle is expressed in degrees.
	/// </summary>
	public void RotateY(double angle)
	{
		vtkTransform_RotateY_39(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_RotateZ_40(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix about the X, Y, or Z axis and concatenate
	/// it with the current transformation according to PreMultiply or
	/// PostMultiply semantics.  The angle is expressed in degrees.
	/// </summary>
	public void RotateZ(double angle)
	{
		vtkTransform_RotateZ_40(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransform SafeDownCast(vtkObjectBase o)
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform_SafeDownCast_41(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Scale_42(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
	/// and concatenate it with the current transformation according to
	/// PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Scale(double x, double y, double z)
	{
		vtkTransform_Scale_42(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Scale_43(HandleRef pThis, IntPtr s);

	/// <summary>
	/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
	/// and concatenate it with the current transformation according to
	/// PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Scale(IntPtr s)
	{
		vtkTransform_Scale_43(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_SetInput_44(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the input for this transformation.  This will be used as the
	/// base transformation if it is set.  This method allows you to build
	/// a transform pipeline: if the input is modified, then this transformation
	/// will automatically update accordingly.  Note that the InverseFlag,
	/// controlled via Inverse(), determines whether this transformation
	/// will use the Input or the inverse of the Input.
	/// </summary>
	public void SetInput(vtkLinearTransform input)
	{
		vtkTransform_SetInput_44(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_SetMatrix_45(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Set the current matrix directly. Note: First, the current
	/// matrix is set to the identity, then the input matrix is concatenated.
	/// </summary>
	public void SetMatrix(vtkMatrix4x4 matrix)
	{
		vtkTransform_SetMatrix_45(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_SetMatrix_46(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Set the current matrix directly. Note: First, the current
	/// matrix is set to the identity, then the input matrix is concatenated.
	/// </summary>
	public void SetMatrix(IntPtr elements)
	{
		vtkTransform_SetMatrix_46(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Translate_47(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Create a translation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Translate(double x, double y, double z)
	{
		vtkTransform_Translate_47(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform_Translate_48(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Create a translation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Translate(IntPtr x)
	{
		vtkTransform_Translate_48(GetCppThis(), x);
	}
}
