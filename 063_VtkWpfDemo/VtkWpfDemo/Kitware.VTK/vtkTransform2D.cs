using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTransform2D
/// </summary>
/// <remarks>
///    describes linear transformations via a 3x3 matrix
///
/// A vtkTransform2D can be used to describe the full range of linear (also
/// known as affine) coordinate transformations in two dimensions,
/// which are internally represented as a 3x3 homogeneous transformation
/// matrix.  When you create a new vtkTransform2D, it is always initialized
/// to the identity transformation.
///
/// All multiplicitive operations (Translate, Rotate, Scale, etc) are
/// post-multiplied in this class (i.e. add them in the reverse of the order
/// that they should be applied).
///
/// This class performs all of its operations in a right handed
/// coordinate system with right handed rotations. Some other graphics
/// libraries use left handed coordinate systems and rotations.
/// </remarks>
public class vtkTransform2D : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTransform2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTransform2D()
	{
		MRClassNameKey = "class vtkTransform2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransform2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTransform2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransform2D New()
	{
		vtkTransform2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTransform2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTransform2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTransform2D_GetInverse_01(HandleRef pThis, HandleRef inverse);

	/// <summary>
	/// Return a matrix which is the inverse of the current transformation
	/// matrix.
	/// </summary>
	public void GetInverse(vtkMatrix3x3 inverse)
	{
		vtkTransform2D_GetInverse_01(GetCppThis(), inverse?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTransform2D_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// Override GetMTime to account for input and concatenation.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTransform2D_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform2D_GetMatrix_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the underlying 3x3 matrix.
	/// </summary>
	public virtual vtkMatrix3x3 GetMatrix()
	{
		vtkMatrix3x3 vtkMatrix3x4 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform2D_GetMatrix_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix3x4 = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix3x4.Register(null);
			}
		}
		return vtkMatrix3x4;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_GetMatrix_04(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Get the underlying 3x3 matrix.
	/// </summary>
	public void GetMatrix(vtkMatrix3x3 matrix)
	{
		vtkTransform2D_GetMatrix_04(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransform2D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTransform2D_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransform2D_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTransform2D_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_GetPosition_07(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Return the position from the current transformation matrix as an array
	/// of two floating point numbers. This is simply returning the translation
	/// component of the 3x3 matrix.
	/// </summary>
	public void GetPosition(IntPtr pos)
	{
		vtkTransform2D_GetPosition_07(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_GetScale_08(HandleRef pThis, IntPtr scale);

	/// <summary>
	/// Return the x and y scale from the current transformation matrix as an array
	/// of two floating point numbers. This is simply returning the scale
	/// component of the 3x3 matrix.
	/// </summary>
	public void GetScale(IntPtr scale)
	{
		vtkTransform2D_GetScale_08(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_GetTranspose_09(HandleRef pThis, HandleRef transpose);

	/// <summary>
	/// Return a matrix which is the transpose of the current transformation
	/// matrix.  This is equivalent to the inverse if and only if the
	/// transformation is a pure rotation with no translation or scale.
	/// </summary>
	public void GetTranspose(vtkMatrix3x3 transpose)
	{
		vtkTransform2D_GetTranspose_09(GetCppThis(), transpose?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_Identity_10(HandleRef pThis);

	/// <summary>
	/// Set the transformation to the identity transformation.
	/// </summary>
	public void Identity()
	{
		vtkTransform2D_Identity_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_Inverse_11(HandleRef pThis);

	/// <summary>
	/// Invert the transformation.
	/// </summary>
	public void Inverse()
	{
		vtkTransform2D_Inverse_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_InverseTransformPoints_12(HandleRef pThis, IntPtr inPts, IntPtr outPts, int n);

	/// <summary>
	/// Apply the transformation to a series of points, and append the
	/// results to outPts. Where n is the number of points, and the float pointers
	/// are of length 2*n.
	/// </summary>
	public void InverseTransformPoints(IntPtr inPts, IntPtr outPts, int n)
	{
		vtkTransform2D_InverseTransformPoints_12(GetCppThis(), inPts, outPts, n);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_InverseTransformPoints_13(HandleRef pThis, HandleRef inPts, HandleRef outPts);

	/// <summary>
	/// Apply the transformation to a series of points, and append the
	/// results to outPts.
	/// </summary>
	public void InverseTransformPoints(vtkPoints2D inPts, vtkPoints2D outPts)
	{
		vtkTransform2D_InverseTransformPoints_13(GetCppThis(), inPts?.GetCppThis() ?? default(HandleRef), outPts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransform2D_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTransform2D_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransform2D_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTransform2D_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_MultiplyPoint_16(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Use this method only if you wish to compute the transformation in
	/// homogeneous (x,y,w) coordinates, otherwise use TransformPoint().
	/// This method calls this-&gt;GetMatrix()-&gt;MultiplyPoint().
	/// </summary>
	public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkTransform2D_MultiplyPoint_16(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform2D_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTransform2D NewInstance()
	{
		vtkTransform2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform2D_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_Rotate_19(HandleRef pThis, double angle);

	/// <summary>
	/// Create a rotation matrix and concatenate it with the current
	/// transformation. The angle is in degrees.
	/// </summary>
	public void Rotate(double angle)
	{
		vtkTransform2D_Rotate_19(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransform2D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransform2D SafeDownCast(vtkObjectBase o)
	{
		vtkTransform2D vtkTransform2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransform2D_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2D2 = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2D2.Register(null);
			}
		}
		return vtkTransform2D2;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_Scale_21(HandleRef pThis, double x, double y);

	/// <summary>
	/// Create a scale matrix (i.e. set the diagonal elements to x, y)
	/// and concatenate it with the current transformation.
	/// </summary>
	public void Scale(double x, double y)
	{
		vtkTransform2D_Scale_21(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_Scale_22(HandleRef pThis, IntPtr s);

	/// <summary>
	/// Create a scale matrix (i.e. set the diagonal elements to x, y)
	/// and concatenate it with the current transformation.
	/// </summary>
	public void Scale(IntPtr s)
	{
		vtkTransform2D_Scale_22(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_SetMatrix_23(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Set the current matrix directly.
	/// </summary>
	public void SetMatrix(vtkMatrix3x3 matrix)
	{
		vtkTransform2D_SetMatrix_23(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_SetMatrix_24(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Set the current matrix directly.
	/// </summary>
	public void SetMatrix(IntPtr elements)
	{
		vtkTransform2D_SetMatrix_24(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_TransformPoints_25(HandleRef pThis, IntPtr inPts, IntPtr outPts, int n);

	/// <summary>
	/// Apply the transformation to a series of points, and append the
	/// results to outPts. Where n is the number of points, and the float pointers
	/// are of length 2*n.
	/// </summary>
	public void TransformPoints(IntPtr inPts, IntPtr outPts, int n)
	{
		vtkTransform2D_TransformPoints_25(GetCppThis(), inPts, outPts, n);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_TransformPoints_26(HandleRef pThis, HandleRef inPts, HandleRef outPts);

	/// <summary>
	/// Apply the transformation to a series of points, and append the
	/// results to outPts.
	/// </summary>
	public void TransformPoints(vtkPoints2D inPts, vtkPoints2D outPts)
	{
		vtkTransform2D_TransformPoints_26(GetCppThis(), inPts?.GetCppThis() ?? default(HandleRef), outPts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_Translate_27(HandleRef pThis, double x, double y);

	/// <summary>
	/// Create a translation matrix and concatenate it with the current
	/// transformation.
	/// </summary>
	public void Translate(double x, double y)
	{
		vtkTransform2D_Translate_27(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransform2D_Translate_28(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Create a translation matrix and concatenate it with the current
	/// transformation.
	/// </summary>
	public void Translate(IntPtr x)
	{
		vtkTransform2D_Translate_28(GetCppThis(), x);
	}
}
