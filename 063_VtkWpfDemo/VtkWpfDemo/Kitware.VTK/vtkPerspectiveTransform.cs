using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPerspectiveTransform
/// </summary>
/// <remarks>
///    describes a 4x4 matrix transformation
///
/// A vtkPerspectiveTransform can be used to describe the full range of
/// homogeneous transformations.  It was designed in particular
/// to describe a camera-view of a scene.
/// &lt;P&gt;The order in which you set up the display coordinates (via
/// AdjustZBuffer() and AdjustViewport()), the projection (via Perspective(),
/// Frustum(), or Ortho()) and the camera view (via SetupCamera()) are
/// important.  If the transform is in PreMultiply mode, which is the
/// default, set the Viewport and ZBuffer first, then the projection, and
/// finally the camera view.  Once the view is set up, the Translate
/// and Rotate methods can be used to move the camera around in world
/// coordinates.  If the Oblique() or Stereo() methods are used, they
/// should be called just before SetupCamera().
/// &lt;P&gt;In PostMultiply mode, you must perform all transformations
/// in the opposite order.  This is necessary, for example, if you
/// already have a perspective transformation set up but must adjust
/// the viewport.  Another example is if you have a view transformation,
/// and wish to perform translations and rotations in the camera's
/// coordinate system rather than in world coordinates.
/// &lt;P&gt;The SetInput and Concatenate methods can be used to create
/// a transformation pipeline with vtkPerspectiveTransform.  See vtkTransform
/// for more information on the transformation pipeline.
/// </remarks>
/// <seealso>
///
/// vtkGeneralTransform vtkTransform vtkMatrix4x4 vtkCamera
/// </seealso>
public class vtkPerspectiveTransform : vtkHomogeneousTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPerspectiveTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPerspectiveTransform()
	{
		MRClassNameKey = "class vtkPerspectiveTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPerspectiveTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPerspectiveTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerspectiveTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPerspectiveTransform New()
	{
		vtkPerspectiveTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerspectiveTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPerspectiveTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPerspectiveTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPerspectiveTransform_AdjustViewport_01(HandleRef pThis, double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax);

	/// <summary>
	/// Perform an adjustment to the viewport coordinates.  By default Ortho,
	/// Frustum, and Perspective provide a window of ([-1,+1],[-1,+1]).
	/// In PreMultiply mode, you call this method before calling Ortho, Frustum,
	/// or Perspective.  In PostMultiply mode you can call it after.  Note
	/// that if you must apply both AdjustZBuffer and AdjustViewport, it
	/// makes no difference which order you apply them in.
	/// </summary>
	public void AdjustViewport(double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax)
	{
		vtkPerspectiveTransform_AdjustViewport_01(GetCppThis(), oldXMin, oldXMax, oldYMin, oldYMax, newXMin, newXMax, newYMin, newYMax);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_AdjustZBuffer_02(HandleRef pThis, double oldNearZ, double oldFarZ, double newNearZ, double newFarZ);

	/// <summary>
	/// Perform an adjustment to the Z-Buffer range that the near and far
	/// clipping planes map to.  By default Ortho, Frustum, and Perspective
	/// map the near clipping plane to -1 and the far clipping plane to +1.
	/// In PreMultiply mode, you call this method before calling Ortho, Frustum,
	/// or Perspective.  In PostMultiply mode you can call it after.
	/// </summary>
	public void AdjustZBuffer(double oldNearZ, double oldFarZ, double newNearZ, double newFarZ)
	{
		vtkPerspectiveTransform_AdjustZBuffer_02(GetCppThis(), oldNearZ, oldFarZ, newNearZ, newFarZ);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPerspectiveTransform_CircuitCheck_03(HandleRef pThis, HandleRef transform);

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
		return vtkPerspectiveTransform_CircuitCheck_03(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Concatenate_04(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Concatenates the matrix with the current transformation according
	/// to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Concatenate(vtkMatrix4x4 matrix)
	{
		vtkPerspectiveTransform_Concatenate_04(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Concatenate_05(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Concatenates the matrix with the current transformation according
	/// to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Concatenate(IntPtr elements)
	{
		vtkPerspectiveTransform_Concatenate_05(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Concatenate_06(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Concatenate the specified transform with the current transformation
	/// according to PreMultiply or PostMultiply semantics.
	/// The concatenation is pipelined, meaning that if any of the
	/// transformations are changed, even after Concatenate() is called,
	/// those changes will be reflected when you call TransformPoint().
	/// </summary>
	public void Concatenate(vtkHomogeneousTransform transform)
	{
		vtkPerspectiveTransform_Concatenate_06(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Frustum_07(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double znear, double zfar);

	/// <summary>
	/// Create an perspective projection matrix and concatenate it by the
	/// current transformation.  The matrix maps a frustum with a back
	/// plane at -zfar and a front plane at -znear with extent
	/// [xmin,xmax],[ymin,ymax] to [-1,+1], [-1,+1], [+1,-1].
	/// </summary>
	public void Frustum(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
	{
		vtkPerspectiveTransform_Frustum_07(GetCppThis(), xmin, xmax, ymin, ymax, znear, zfar);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerspectiveTransform_GetConcatenatedTransform_08(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get one of the concatenated transformations as a vtkAbstractTransform.
	/// These transformations are applied, in series, every time the
	/// transformation of a coordinate occurs.  This method is provided
	/// to make it possible to decompose a transformation into its
	/// constituents, for example to save a transformation to a file.
	/// </summary>
	public vtkHomogeneousTransform GetConcatenatedTransform(int i)
	{
		vtkHomogeneousTransform vtkHomogeneousTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerspectiveTransform_GetConcatenatedTransform_08(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPerspectiveTransform_GetInput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the input for this transformation.  This will be used as the
	/// base transformation if it is set.  This method allows you to build
	/// a transform pipeline: if the input is modified, then this transformation
	/// will automatically update accordingly.  Note that the InverseFlag,
	/// controlled via Inverse(), determines whether this transformation
	/// will use the Input or the inverse of the Input.
	/// </summary>
	public vtkHomogeneousTransform GetInput()
	{
		vtkHomogeneousTransform vtkHomogeneousTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerspectiveTransform_GetInput_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPerspectiveTransform_GetInverseFlag_10(HandleRef pThis);

	/// <summary>
	/// Get the inverse flag of the transformation.  This controls
	/// whether it is the Input or the inverse of the Input that
	/// is used as the base transformation.  The InverseFlag is
	/// flipped every time Inverse() is called.  The InverseFlag
	/// is off when a transform is first created.
	/// </summary>
	public int GetInverseFlag()
	{
		return vtkPerspectiveTransform_GetInverseFlag_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPerspectiveTransform_GetMTime_11(HandleRef pThis);

	/// <summary>
	/// Override GetMTime to account for input and concatenation.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPerspectiveTransform_GetMTime_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPerspectiveTransform_GetNumberOfConcatenatedTransforms_12(HandleRef pThis);

	/// <summary>
	/// Get the total number of transformations that are linked into this
	/// one via Concatenate() operations or via SetInput().
	/// </summary>
	public int GetNumberOfConcatenatedTransforms()
	{
		return vtkPerspectiveTransform_GetNumberOfConcatenatedTransforms_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPerspectiveTransform_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPerspectiveTransform_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPerspectiveTransform_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPerspectiveTransform_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Identity_15(HandleRef pThis);

	/// <summary>
	/// Set this transformation to the identity transformation.  If
	/// the transform has an Input, then the transformation will be
	/// reset so that it is the same as the Input.
	/// </summary>
	public void Identity()
	{
		vtkPerspectiveTransform_Identity_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Inverse_16(HandleRef pThis);

	/// <summary>
	/// Invert the transformation.  This will also set a flag so that
	/// the transformation will use the inverse of its Input, if an Input
	/// has been set.
	/// </summary>
	public override void Inverse()
	{
		vtkPerspectiveTransform_Inverse_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPerspectiveTransform_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPerspectiveTransform_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPerspectiveTransform_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPerspectiveTransform_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerspectiveTransform_MakeTransform_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make a new transform of the same type -- you are responsible for
	/// deleting the transform when you are done with it.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerspectiveTransform_MakeTransform_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerspectiveTransform_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPerspectiveTransform NewInstance()
	{
		vtkPerspectiveTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerspectiveTransform_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Ortho_22(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double znear, double zfar);

	/// <summary>
	/// Create an orthogonal projection matrix and concatenate it by the
	/// current transformation.  The matrix maps [xmin,xmax], [ymin,ymax],
	/// [-znear,-zfar] to [-1,+1], [-1,+1], [+1,-1].
	/// </summary>
	public void Ortho(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
	{
		vtkPerspectiveTransform_Ortho_22(GetCppThis(), xmin, xmax, ymin, ymax, znear, zfar);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Perspective_23(HandleRef pThis, double angle, double aspect, double znear, double zfar);

	/// <summary>
	/// Create a perspective projection matrix by specifying the view angle
	/// (this angle is in the y direction), the aspect ratio, and the near
	/// and far clipping range.  The projection matrix is concatenated
	/// with the current transformation.  This method works via Frustum.
	/// </summary>
	public void Perspective(double angle, double aspect, double znear, double zfar)
	{
		vtkPerspectiveTransform_Perspective_23(GetCppThis(), angle, aspect, znear, zfar);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Pop_24(HandleRef pThis);

	/// <summary>
	/// Deletes the transformation on the top of the stack and sets the top
	/// to the next transformation on the stack.
	/// </summary>
	public void Pop()
	{
		vtkPerspectiveTransform_Pop_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_PostMultiply_25(HandleRef pThis);

	/// <summary>
	/// Sets the internal state of the transform to PostMultiply. All subsequent
	/// operations will occur after those already represented in the
	/// current transformation.  In homogeneous matrix notation, M = A*M where
	/// M is the current transformation matrix and A is the applied matrix.
	/// The default is PreMultiply.
	/// </summary>
	public void PostMultiply()
	{
		vtkPerspectiveTransform_PostMultiply_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_PreMultiply_26(HandleRef pThis);

	/// <summary>
	/// Sets the internal state of the transform to PreMultiply. All subsequent
	/// operations will occur before those already represented in the
	/// current transformation.  In homogeneous matrix notation, M = M*A where
	/// M is the current transformation matrix and A is the applied matrix.
	/// The default is PreMultiply.
	/// </summary>
	public void PreMultiply()
	{
		vtkPerspectiveTransform_PreMultiply_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Push_27(HandleRef pThis);

	/// <summary>
	/// Pushes the current transformation onto the transformation stack.
	/// </summary>
	public void Push()
	{
		vtkPerspectiveTransform_Push_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_RotateWXYZ_28(HandleRef pThis, double angle, double x, double y, double z);

	/// <summary>
	/// Create a rotation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// The angle is in degrees, and (x,y,z) specifies the axis that the
	/// rotation will be performed around.
	/// </summary>
	public void RotateWXYZ(double angle, double x, double y, double z)
	{
		vtkPerspectiveTransform_RotateWXYZ_28(GetCppThis(), angle, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_RotateWXYZ_29(HandleRef pThis, double angle, IntPtr axis);

	/// <summary>
	/// Create a rotation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// The angle is in degrees, and (x,y,z) specifies the axis that the
	/// rotation will be performed around.
	/// </summary>
	public void RotateWXYZ(double angle, IntPtr axis)
	{
		vtkPerspectiveTransform_RotateWXYZ_29(GetCppThis(), angle, axis);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_RotateX_30(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix about the X, Y, or Z axis and concatenate
	/// it with the current transformation according to PreMultiply or
	/// PostMultiply semantics.  The angle is expressed in degrees.
	/// </summary>
	public void RotateX(double angle)
	{
		vtkPerspectiveTransform_RotateX_30(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_RotateY_31(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix about the X, Y, or Z axis and concatenate
	/// it with the current transformation according to PreMultiply or
	/// PostMultiply semantics.  The angle is expressed in degrees.
	/// </summary>
	public void RotateY(double angle)
	{
		vtkPerspectiveTransform_RotateY_31(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_RotateZ_32(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix about the X, Y, or Z axis and concatenate
	/// it with the current transformation according to PreMultiply or
	/// PostMultiply semantics.  The angle is expressed in degrees.
	/// </summary>
	public void RotateZ(double angle)
	{
		vtkPerspectiveTransform_RotateZ_32(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPerspectiveTransform_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPerspectiveTransform SafeDownCast(vtkObjectBase o)
	{
		vtkPerspectiveTransform vtkPerspectiveTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPerspectiveTransform_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPerspectiveTransform2 = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPerspectiveTransform2.Register(null);
			}
		}
		return vtkPerspectiveTransform2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Scale_34(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
	/// and concatenate it with the current transformation according to
	/// PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Scale(double x, double y, double z)
	{
		vtkPerspectiveTransform_Scale_34(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Scale_35(HandleRef pThis, IntPtr s);

	/// <summary>
	/// Create a scale matrix (i.e. set the diagonal elements to x, y, z)
	/// and concatenate it with the current transformation according to
	/// PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Scale(IntPtr s)
	{
		vtkPerspectiveTransform_Scale_35(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_SetInput_36(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the input for this transformation.  This will be used as the
	/// base transformation if it is set.  This method allows you to build
	/// a transform pipeline: if the input is modified, then this transformation
	/// will automatically update accordingly.  Note that the InverseFlag,
	/// controlled via Inverse(), determines whether this transformation
	/// will use the Input or the inverse of the Input.
	/// </summary>
	public void SetInput(vtkHomogeneousTransform input)
	{
		vtkPerspectiveTransform_SetInput_36(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_SetMatrix_37(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Set the current matrix directly.  This actually calls Identity(),
	/// followed by Concatenate(matrix).
	/// </summary>
	public void SetMatrix(vtkMatrix4x4 matrix)
	{
		vtkPerspectiveTransform_SetMatrix_37(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_SetMatrix_38(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Set the current matrix directly.  This actually calls Identity(),
	/// followed by Concatenate(matrix).
	/// </summary>
	public void SetMatrix(IntPtr elements)
	{
		vtkPerspectiveTransform_SetMatrix_38(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_SetupCamera_39(HandleRef pThis, IntPtr position, IntPtr focalpoint, IntPtr viewup);

	/// <summary>
	/// Set a view transformation matrix for the camera (this matrix does
	/// not contain any perspective) and concatenate it with the current
	/// transformation.
	/// </summary>
	public void SetupCamera(IntPtr position, IntPtr focalpoint, IntPtr viewup)
	{
		vtkPerspectiveTransform_SetupCamera_39(GetCppThis(), position, focalpoint, viewup);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_SetupCamera_40(HandleRef pThis, double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2);

	/// <summary>
	/// Set a view transformation matrix for the camera (this matrix does
	/// not contain any perspective) and concatenate it with the current
	/// transformation.
	/// </summary>
	public void SetupCamera(double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2)
	{
		vtkPerspectiveTransform_SetupCamera_40(GetCppThis(), p0, p1, p2, fp0, fp1, fp2, vup0, vup1, vup2);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Shear_41(HandleRef pThis, double dxdz, double dydz, double zplane);

	/// <summary>
	/// Create a shear transformation about a plane at distance z from
	/// the camera.  The values dxdz (i.e. dx/dz) and dydz specify the
	/// amount of shear in the x and y directions.  The 'zplane' specifies
	/// the distance from the camera to the plane at which the shear
	/// causes zero displacement.  Generally you want this plane to be the
	/// focal plane.
	/// This transformation can be used in combination with Ortho to create
	/// an oblique projection.  It can also be used in combination with
	/// Perspective to provide correct stereo views when the eye is at
	/// arbitrary but known positions relative to the center of a flat
	/// viewing screen.
	/// </summary>
	public void Shear(double dxdz, double dydz, double zplane)
	{
		vtkPerspectiveTransform_Shear_41(GetCppThis(), dxdz, dydz, zplane);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Stereo_42(HandleRef pThis, double angle, double focaldistance);

	/// <summary>
	/// Create a stereo shear matrix and concatenate it with the
	/// current transformation.  This can be applied in conjunction with either a
	/// perspective transformation (via Frustum or Projection) or an
	/// orthographic projection.  You must specify the distance from
	/// the camera plane to the focal plane, and the angle between
	/// the distance vector and the eye.  The angle should be negative
	/// for the left eye, and positive for the right.  This method
	/// works via Oblique.
	/// </summary>
	public void Stereo(double angle, double focaldistance)
	{
		vtkPerspectiveTransform_Stereo_42(GetCppThis(), angle, focaldistance);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Translate_43(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Create a translation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Translate(double x, double y, double z)
	{
		vtkPerspectiveTransform_Translate_43(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPerspectiveTransform_Translate_44(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Create a translation matrix and concatenate it with the current
	/// transformation according to PreMultiply or PostMultiply semantics.
	/// </summary>
	public void Translate(IntPtr x)
	{
		vtkPerspectiveTransform_Translate_44(GetCppThis(), x);
	}
}
