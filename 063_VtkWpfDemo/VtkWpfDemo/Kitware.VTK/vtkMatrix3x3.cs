using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMatrix3x3
/// </summary>
/// <remarks>
///    represent and manipulate 3x3 transformation matrices
///
/// vtkMatrix3x3 is a class to represent and manipulate 3x3 matrices.
/// Specifically, it is designed to work on 3x3 transformation matrices
/// found in 2D rendering using homogeneous coordinates [x y w].
///
/// </remarks>
/// <seealso>
///
/// vtkTransform2D
/// </seealso>
public class vtkMatrix3x3 : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMatrix3x3";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMatrix3x3()
	{
		MRClassNameKey = "class vtkMatrix3x3";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrix3x3"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMatrix3x3(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix3x3_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a 3x3 identity matrix.
	/// </summary>
	public new static vtkMatrix3x3 New()
	{
		vtkMatrix3x3 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrix3x3_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a 3x3 identity matrix.
	/// </summary>
	public vtkMatrix3x3()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMatrix3x3_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkMatrix3x3_Adjoint_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Compute adjoint of the matrix and put it into out.
	/// </summary>
	public void Adjoint(vtkMatrix3x3 arg0, vtkMatrix3x3 arg1)
	{
		vtkMatrix3x3_Adjoint_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Adjoint_02(IntPtr inElements, IntPtr outElements);

	/// <summary>
	/// Compute adjoint of the matrix and put it into out.
	/// </summary>
	public static void Adjoint(IntPtr inElements, IntPtr outElements)
	{
		vtkMatrix3x3_Adjoint_02(inElements, outElements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_DeepCopy_03(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Set the elements of the matrix to the same values as the elements
	/// of the source Matrix.
	/// </summary>
	public void DeepCopy(vtkMatrix3x3 source)
	{
		vtkMatrix3x3_DeepCopy_03(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_DeepCopy_04(IntPtr elements, HandleRef source);

	/// <summary>
	/// Set the elements of the matrix to the same values as the elements
	/// of the source Matrix.
	/// </summary>
	public static void DeepCopy(IntPtr elements, vtkMatrix3x3 source)
	{
		vtkMatrix3x3_DeepCopy_04(elements, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_DeepCopy_05(IntPtr elements, IntPtr newElements);

	/// <summary>
	/// Set the elements of the matrix to the same values as the elements
	/// of the source Matrix.
	/// </summary>
	public static void DeepCopy(IntPtr elements, IntPtr newElements)
	{
		vtkMatrix3x3_DeepCopy_05(elements, newElements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_DeepCopy_06(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Non-static member function. Assigns *from* elements array
	/// </summary>
	public void DeepCopy(IntPtr elements)
	{
		vtkMatrix3x3_DeepCopy_06(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMatrix3x3_Determinant_07(HandleRef pThis);

	/// <summary>
	/// Compute the determinant of the matrix and return it.
	/// </summary>
	public double Determinant()
	{
		return vtkMatrix3x3_Determinant_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMatrix3x3_Determinant_08(IntPtr elements);

	/// <summary>
	/// Compute the determinant of the matrix and return it.
	/// </summary>
	public static double Determinant(IntPtr elements)
	{
		return vtkMatrix3x3_Determinant_08(elements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix3x3_GetData_09(HandleRef pThis);

	/// <summary>
	/// Return a pointer to the first element of the matrix (double[9]).
	/// </summary>
	public IntPtr GetData()
	{
		return vtkMatrix3x3_GetData_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMatrix3x3_GetElement_10(HandleRef pThis, int i, int j);

	/// <summary>
	/// Returns the element i,j from the matrix.
	/// </summary>
	public double GetElement(int i, int j)
	{
		return vtkMatrix3x3_GetElement_10(GetCppThis(), i, j);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMatrix3x3_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Construct a 3x3 identity matrix.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMatrix3x3_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMatrix3x3_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Construct a 3x3 identity matrix.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMatrix3x3_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Identity_13(HandleRef pThis);

	/// <summary>
	/// Set equal to Identity matrix
	/// </summary>
	public void Identity()
	{
		vtkMatrix3x3_Identity_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Identity_14(IntPtr elements);

	/// <summary>
	/// Set equal to Identity matrix
	/// </summary>
	public static void Identity(IntPtr elements)
	{
		vtkMatrix3x3_Identity_14(elements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Invert_15(HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
	/// Academic Press, 1990).
	/// </summary>
	public static void Invert(vtkMatrix3x3 arg0, vtkMatrix3x3 arg1)
	{
		vtkMatrix3x3_Invert_15(arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Invert_16(HandleRef pThis);

	/// <summary>
	/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
	/// Academic Press, 1990).
	/// </summary>
	public void Invert()
	{
		vtkMatrix3x3_Invert_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Invert_17(IntPtr inElements, IntPtr outElements);

	/// <summary>
	/// Matrix Inversion (adapted from Richard Carling in "Graphics Gems,"
	/// Academic Press, 1990).
	/// </summary>
	public static void Invert(IntPtr inElements, IntPtr outElements)
	{
		vtkMatrix3x3_Invert_17(inElements, outElements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMatrix3x3_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Construct a 3x3 identity matrix.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMatrix3x3_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMatrix3x3_IsIdentity_19(HandleRef pThis);

	/// <summary>
	/// Returns the element i,j from the matrix.
	/// </summary>
	public bool IsIdentity()
	{
		return (vtkMatrix3x3_IsIdentity_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMatrix3x3_IsTypeOf_20(string type);

	/// <summary>
	/// Construct a 3x3 identity matrix.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMatrix3x3_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Multiply3x3_21(HandleRef a, HandleRef b, HandleRef c);

	/// <summary>
	/// Multiplies matrices a and b and stores the result in c (c=a*b).
	/// </summary>
	public static void Multiply3x3(vtkMatrix3x3 a, vtkMatrix3x3 b, vtkMatrix3x3 c)
	{
		vtkMatrix3x3_Multiply3x3_21(a?.GetCppThis() ?? default(HandleRef), b?.GetCppThis() ?? default(HandleRef), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Multiply3x3_22(IntPtr a, IntPtr b, IntPtr c);

	/// <summary>
	/// Multiplies matrices a and b and stores the result in c (c=a*b).
	/// </summary>
	public static void Multiply3x3(IntPtr a, IntPtr b, IntPtr c)
	{
		vtkMatrix3x3_Multiply3x3_22(a, b, c);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_MultiplyPoint_23(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Multiply a homogeneous coordinate by this matrix, i.e. out = A*in.
	/// The in[3] and out[3] can be the same array.
	/// </summary>
	public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkMatrix3x3_MultiplyPoint_23(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_MultiplyPoint_24(IntPtr elements, IntPtr arg1, IntPtr arg2);

	/// <summary>
	/// Multiply a homogeneous coordinate by this matrix, i.e. out = A*in.
	/// The in[3] and out[3] can be the same array.
	/// </summary>
	public static void MultiplyPoint(IntPtr elements, IntPtr arg1, IntPtr arg2)
	{
		vtkMatrix3x3_MultiplyPoint_24(elements, arg1, arg2);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix3x3_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a 3x3 identity matrix.
	/// </summary>
	public new vtkMatrix3x3 NewInstance()
	{
		vtkMatrix3x3 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrix3x3_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMatrix3x3_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a 3x3 identity matrix.
	/// </summary>
	public new static vtkMatrix3x3 SafeDownCast(vtkObjectBase o)
	{
		vtkMatrix3x3 vtkMatrix3x4 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMatrix3x3_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_SetElement_28(HandleRef pThis, int i, int j, double value);

	/// <summary>
	/// Sets the element i,j in the matrix.
	/// </summary>
	public void SetElement(int i, int j, double value)
	{
		vtkMatrix3x3_SetElement_28(GetCppThis(), i, j, value);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Transpose_29(HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Transpose the matrix and put it into out.
	/// </summary>
	public static void Transpose(vtkMatrix3x3 arg0, vtkMatrix3x3 arg1)
	{
		vtkMatrix3x3_Transpose_29(arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Transpose_30(HandleRef pThis);

	/// <summary>
	/// Transpose the matrix and put it into out.
	/// </summary>
	public void Transpose()
	{
		vtkMatrix3x3_Transpose_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Transpose_31(IntPtr inElements, IntPtr outElements);

	/// <summary>
	/// Transpose the matrix and put it into out.
	/// </summary>
	public static void Transpose(IntPtr inElements, IntPtr outElements)
	{
		vtkMatrix3x3_Transpose_31(inElements, outElements);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Zero_32(HandleRef pThis);

	/// <summary>
	/// Set all of the elements to zero.
	/// </summary>
	public void Zero()
	{
		vtkMatrix3x3_Zero_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMatrix3x3_Zero_33(IntPtr elements);

	/// <summary>
	/// Set all of the elements to zero.
	/// </summary>
	public static void Zero(IntPtr elements)
	{
		vtkMatrix3x3_Zero_33(elements);
	}
}
