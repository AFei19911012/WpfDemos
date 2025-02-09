using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMatrix4x4
/// </summary>
/// <remarks>
///    represent and manipulate 4x4 transformation matrices
///
/// vtkMatrix4x4 is a class to represent and manipulate 4x4 matrices.
/// Specifically, it is designed to work on 4x4 transformation matrices
/// found in 3D rendering using homogeneous coordinates [x y z w].
/// Many of the methods take an array of 16 doubles in row-major format.
/// Note that OpenGL stores matrices in column-major format, so the matrix
/// contents must be transposed when they are moved between OpenGL and VTK.
/// </remarks>
/// <seealso>
///
/// vtkTransform
/// </seealso>
public class vtkMatrix4x4 : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMatrix4x4";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMatrix4x4()
	{
		MRClassNameKey = "class vtkMatrix4x4";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrix4x4"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMatrix4x4(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix4x4_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a 4x4 identity matrix.
	/// </summary>
	public new static vtkMatrix4x4 New()
	{
		vtkMatrix4x4 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrix4x4_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a 4x4 identity matrix.
	/// </summary>
	public vtkMatrix4x4()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMatrix4x4_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Adjoint_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Compute adjoint of the matrix and put it into out.
	/// </summary>
	public void Adjoint(vtkMatrix4x4 arg0, vtkMatrix4x4 arg1)
	{
		vtkMatrix4x4_Adjoint_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Adjoint_02(IntPtr inElements, IntPtr outElements);

	/// <summary>
	/// Compute adjoint of the matrix and put it into out.
	/// </summary>
	public static void Adjoint(IntPtr inElements, IntPtr outElements)
	{
		vtkMatrix4x4_Adjoint_02(inElements, outElements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_DeepCopy_03(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Set the elements of the matrix to the same values as the elements
	/// of the given source matrix.
	/// </summary>
	public void DeepCopy(vtkMatrix4x4 source)
	{
		vtkMatrix4x4_DeepCopy_03(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_DeepCopy_04(IntPtr destination, HandleRef source);

	/// <summary>
	/// Set the elements of the given destination buffer to the same values
	/// as the elements of the given source matrix.
	/// </summary>
	public static void DeepCopy(IntPtr destination, vtkMatrix4x4 source)
	{
		vtkMatrix4x4_DeepCopy_04(destination, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_DeepCopy_05(IntPtr destination, IntPtr source);

	/// <summary>
	/// Copies the given source buffer to the given destination buffer.
	/// The memory ranges must not overlap.  Does not affect any matrix.
	/// </summary>
	public static void DeepCopy(IntPtr destination, IntPtr source)
	{
		vtkMatrix4x4_DeepCopy_05(destination, source);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_DeepCopy_06(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Non-static member function. Assigns *to* the matrix *from*
	/// the given elements array.
	/// </summary>
	public void DeepCopy(IntPtr elements)
	{
		vtkMatrix4x4_DeepCopy_06(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMatrix4x4_Determinant_07(HandleRef pThis);

	/// <summary>
	/// Compute the determinant of the matrix and return it.
	/// </summary>
	public double Determinant()
	{
		return vtkMatrix4x4_Determinant_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMatrix4x4_Determinant_08(IntPtr elements);

	/// <summary>
	/// Compute the determinant of the matrix and return it.
	/// </summary>
	public static double Determinant(IntPtr elements)
	{
		return vtkMatrix4x4_Determinant_08(elements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix4x4_GetData_09(HandleRef pThis);

	/// <summary>
	/// Returns the raw double array holding the matrix.
	/// </summary>
	public IntPtr GetData()
	{
		return vtkMatrix4x4_GetData_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMatrix4x4_GetElement_10(HandleRef pThis, int i, int j);

	/// <summary>
	/// Returns the element i,j from the matrix.
	/// </summary>
	public double GetElement(int i, int j)
	{
		return vtkMatrix4x4_GetElement_10(GetCppThis(), i, j);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMatrix4x4_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Construct a 4x4 identity matrix.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMatrix4x4_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMatrix4x4_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Construct a 4x4 identity matrix.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMatrix4x4_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Identity_13(HandleRef pThis);

	/// <summary>
	/// Set equal to Identity matrix
	/// </summary>
	public void Identity()
	{
		vtkMatrix4x4_Identity_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Identity_14(IntPtr elements);

	/// <summary>
	/// Set equal to Identity matrix
	/// </summary>
	public static void Identity(IntPtr elements)
	{
		vtkMatrix4x4_Identity_14(elements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Invert_15(HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
	/// Academic Press, 1990).
	/// </summary>
	public static void Invert(vtkMatrix4x4 arg0, vtkMatrix4x4 arg1)
	{
		vtkMatrix4x4_Invert_15(arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Invert_16(HandleRef pThis);

	/// <summary>
	/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
	/// Academic Press, 1990).
	/// </summary>
	public void Invert()
	{
		vtkMatrix4x4_Invert_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Invert_17(IntPtr inElements, IntPtr outElements);

	/// <summary>
	/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
	/// Academic Press, 1990).
	/// </summary>
	public static void Invert(IntPtr inElements, IntPtr outElements)
	{
		vtkMatrix4x4_Invert_17(inElements, outElements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMatrix4x4_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Construct a 4x4 identity matrix.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMatrix4x4_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMatrix4x4_IsIdentity_19(HandleRef pThis);

	/// <summary>
	/// Returns true if this matrix is equal to the identity matrix.
	/// </summary>
	public bool IsIdentity()
	{
		return (vtkMatrix4x4_IsIdentity_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMatrix4x4_IsTypeOf_20(string type);

	/// <summary>
	/// Construct a 4x4 identity matrix.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMatrix4x4_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_MatrixFromRotation_21(double angle, double x, double y, double z, HandleRef result);

	/// <summary>
	/// Construct a matrix from a rotation
	/// </summary>
	public static void MatrixFromRotation(double angle, double x, double y, double z, vtkMatrix4x4 result)
	{
		vtkMatrix4x4_MatrixFromRotation_21(angle, x, y, z, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_MatrixFromRotation_22(double angle, double x, double y, double z, IntPtr matrix);

	/// <summary>
	/// Construct a matrix from a rotation
	/// </summary>
	public static void MatrixFromRotation(double angle, double x, double y, double z, IntPtr matrix)
	{
		vtkMatrix4x4_MatrixFromRotation_22(angle, x, y, z, matrix);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Multiply4x4_23(HandleRef a, HandleRef b, HandleRef c);

	/// <summary>
	/// Multiplies matrices a and b and stores the result in c.
	/// </summary>
	public static void Multiply4x4(vtkMatrix4x4 a, vtkMatrix4x4 b, vtkMatrix4x4 c)
	{
		vtkMatrix4x4_Multiply4x4_23(a?.GetCppThis() ?? default(HandleRef), b?.GetCppThis() ?? default(HandleRef), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Multiply4x4_24(IntPtr a, IntPtr b, IntPtr c);

	/// <summary>
	/// Multiplies matrices a and b and stores the result in c.
	/// </summary>
	public static void Multiply4x4(IntPtr a, IntPtr b, IntPtr c)
	{
		vtkMatrix4x4_Multiply4x4_24(a, b, c);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_MultiplyAndTranspose4x4_25(IntPtr a, IntPtr b, IntPtr c);

	/// <summary>
	/// Multiplies matrices a and b and stores the result in c.
	/// </summary>
	public static void MultiplyAndTranspose4x4(IntPtr a, IntPtr b, IntPtr c)
	{
		vtkMatrix4x4_MultiplyAndTranspose4x4_25(a, b, c);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix4x4_MultiplyDoublePoint_26(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// For use in Java or Python.
	/// </summary>
	public double[] MultiplyDoublePoint(IntPtr arg0)
	{
		IntPtr intPtr = vtkMatrix4x4_MultiplyDoublePoint_26(GetCppThis(), arg0);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix4x4_MultiplyFloatPoint_27(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// For use in Java or Python.
	/// </summary>
	public float[] MultiplyFloatPoint(IntPtr arg0)
	{
		IntPtr intPtr = vtkMatrix4x4_MultiplyFloatPoint_27(GetCppThis(), arg0);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_MultiplyPoint_28(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Multiply a homogeneous coordinate by this matrix, i.e. out = A*in.
	/// The in[4] and out[4] can be the same array.
	/// </summary>
	public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkMatrix4x4_MultiplyPoint_28(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_MultiplyPoint_29(IntPtr elements, IntPtr arg1, IntPtr arg2);

	/// <summary>
	/// Multiply a homogeneous coordinate by this matrix, i.e. out = A*in.
	/// The in[4] and out[4] can be the same array.
	/// </summary>
	public static void MultiplyPoint(IntPtr elements, IntPtr arg1, IntPtr arg2)
	{
		vtkMatrix4x4_MultiplyPoint_29(elements, arg1, arg2);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix4x4_MultiplyPoint_30(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// For use in Java or Python.
	/// </summary>
	public float[] MultiplyPoint(IntPtr arg0)
	{
		IntPtr intPtr = vtkMatrix4x4_MultiplyPoint_30(GetCppThis(), arg0);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix4x4_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a 4x4 identity matrix.
	/// </summary>
	public new vtkMatrix4x4 NewInstance()
	{
		vtkMatrix4x4 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrix4x4_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_PoseToMatrix_33(IntPtr pos, IntPtr ori, HandleRef mat);

	/// <summary>
	/// Given an orientation and position this function will fill in a matrix
	/// representing the transformation from the pose to whatever space the pose was
	/// defined in. For example if the position and orientation are in world
	/// coordinates then this method would set the matrix to be PoseToWorld
	/// </summary>
	public static void PoseToMatrix(IntPtr pos, IntPtr ori, vtkMatrix4x4 mat)
	{
		vtkMatrix4x4_PoseToMatrix_33(pos, ori, mat?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix4x4_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a 4x4 identity matrix.
	/// </summary>
	public new static vtkMatrix4x4 SafeDownCast(vtkObjectBase o)
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrix4x4_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_SetElement_35(HandleRef pThis, int i, int j, double value);

	/// <summary>
	/// Sets the element i,j in the matrix.
	/// </summary>
	public void SetElement(int i, int j, double value)
	{
		vtkMatrix4x4_SetElement_35(GetCppThis(), i, j, value);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Transpose_36(HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Transpose the matrix and put it into out.
	/// </summary>
	public static void Transpose(vtkMatrix4x4 arg0, vtkMatrix4x4 arg1)
	{
		vtkMatrix4x4_Transpose_36(arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Transpose_37(HandleRef pThis);

	/// <summary>
	/// Transpose the matrix and put it into out.
	/// </summary>
	public void Transpose()
	{
		vtkMatrix4x4_Transpose_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Transpose_38(IntPtr inElements, IntPtr outElements);

	/// <summary>
	/// Transpose the matrix and put it into out.
	/// </summary>
	public static void Transpose(IntPtr inElements, IntPtr outElements)
	{
		vtkMatrix4x4_Transpose_38(inElements, outElements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Zero_39(HandleRef pThis);

	/// <summary>
	/// Set all of the elements to zero.
	/// </summary>
	public void Zero()
	{
		vtkMatrix4x4_Zero_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix4x4_Zero_40(IntPtr elements);

	/// <summary>
	/// Set all of the elements to zero.
	/// </summary>
	public static void Zero(IntPtr elements)
	{
		vtkMatrix4x4_Zero_40(elements);
	}
}
