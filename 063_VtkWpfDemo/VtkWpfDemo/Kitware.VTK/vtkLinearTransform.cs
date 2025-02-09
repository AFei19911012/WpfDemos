using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLinearTransform
/// </summary>
/// <remarks>
///    abstract superclass for linear transformations
///
/// vtkLinearTransform provides a generic interface for linear
/// (affine or 12 degree-of-freedom) geometric transformations.
///
/// @warning
/// Portions of this class (i.e., when transforming arrays of points and/or
/// associated attributes such as normals and vectors) has been threaded with
/// vtkSMPTools. Using TBB or other non-sequential type (set in the CMake
/// variable VTK_SMP_IMPLEMENTATION_TYPE) may improve performance
/// significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkTransform vtkIdentityTransform
/// </seealso>
public abstract class vtkLinearTransform : vtkHomogeneousTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLinearTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLinearTransform()
	{
		MRClassNameKey = "class vtkLinearTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLinearTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkLinearTransform_GetLinearInverse_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Just like GetInverse, but it includes a typecast to
	/// vtkLinearTransform.
	/// </summary>
	public vtkLinearTransform GetLinearInverse()
	{
		vtkLinearTransform vtkLinearTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearTransform_GetLinearInverse_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkLinearTransform_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLinearTransform_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearTransform_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLinearTransform_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransform_InternalTransformNormal_04(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public virtual void InternalTransformNormal(IntPtr arg0, IntPtr arg1)
	{
		vtkLinearTransform_InternalTransformNormal_04(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransform_InternalTransformPoint_05(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkLinearTransform_InternalTransformPoint_05(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransform_InternalTransformVector_06(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public virtual void InternalTransformVector(IntPtr arg0, IntPtr arg1)
	{
		vtkLinearTransform_InternalTransformVector_06(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearTransform_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLinearTransform_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearTransform_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLinearTransform_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLinearTransform NewInstance()
	{
		vtkLinearTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearTransform_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLinearTransform SafeDownCast(vtkObjectBase o)
	{
		vtkLinearTransform vtkLinearTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearTransform_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLinearTransform_TransformDoubleNormal_11(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Apply the transformation to a double-precision (x,y,z) normal.
	/// Use this if you are programming in python or Java.
	/// </summary>
	public double[] TransformDoubleNormal(double x, double y, double z)
	{
		IntPtr intPtr = vtkLinearTransform_TransformDoubleNormal_11(GetCppThis(), x, y, z);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformDoubleNormal_12(HandleRef pThis, IntPtr normal);

	/// <summary>
	/// Apply the transformation to a double-precision (x,y,z) normal.
	/// Use this if you are programming in python or Java.
	/// </summary>
	public double[] TransformDoubleNormal(IntPtr normal)
	{
		IntPtr intPtr = vtkLinearTransform_TransformDoubleNormal_12(GetCppThis(), normal);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformDoubleVector_13(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Apply the transformation to a double-precision (x,y,z) vector.
	/// Use this if you are programming in python or Java.
	/// </summary>
	public double[] TransformDoubleVector(double x, double y, double z)
	{
		IntPtr intPtr = vtkLinearTransform_TransformDoubleVector_13(GetCppThis(), x, y, z);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformDoubleVector_14(HandleRef pThis, IntPtr vec);

	/// <summary>
	/// Apply the transformation to a double-precision (x,y,z) vector.
	/// Use this if you are programming in python or Java.
	/// </summary>
	public double[] TransformDoubleVector(IntPtr vec)
	{
		IntPtr intPtr = vtkLinearTransform_TransformDoubleVector_14(GetCppThis(), vec);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformFloatNormal_15(HandleRef pThis, float x, float y, float z);

	/// <summary>
	/// Apply the transformation to an (x,y,z) normal.
	/// Use this if you are programming in python or Java.
	/// </summary>
	public float[] TransformFloatNormal(float x, float y, float z)
	{
		IntPtr intPtr = vtkLinearTransform_TransformFloatNormal_15(GetCppThis(), x, y, z);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformFloatNormal_16(HandleRef pThis, IntPtr normal);

	/// <summary>
	/// Apply the transformation to an (x,y,z) normal.
	/// Use this if you are programming in python or Java.
	/// </summary>
	public float[] TransformFloatNormal(IntPtr normal)
	{
		IntPtr intPtr = vtkLinearTransform_TransformFloatNormal_16(GetCppThis(), normal);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformFloatVector_17(HandleRef pThis, float x, float y, float z);

	/// <summary>
	/// Apply the transformation to an (x,y,z) vector.
	/// Use this if you are programming in python or Java.
	/// </summary>
	public float[] TransformFloatVector(float x, float y, float z)
	{
		IntPtr intPtr = vtkLinearTransform_TransformFloatVector_17(GetCppThis(), x, y, z);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformFloatVector_18(HandleRef pThis, IntPtr vec);

	/// <summary>
	/// Apply the transformation to an (x,y,z) vector.
	/// Use this if you are programming in python or Java.
	/// </summary>
	public float[] TransformFloatVector(IntPtr vec)
	{
		IntPtr intPtr = vtkLinearTransform_TransformFloatVector_18(GetCppThis(), vec);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransform_TransformNormal_19(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Apply the transformation to a normal.
	/// You can use the same array to store both the input and output.
	/// </summary>
	public void TransformNormal(IntPtr arg0, IntPtr arg1)
	{
		vtkLinearTransform_TransformNormal_19(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformNormal_20(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Synonymous with TransformDoubleNormal(x,y,z).
	/// Use this if you are programming in python or Java.
	/// </summary>
	public double[] TransformNormal(double x, double y, double z)
	{
		IntPtr intPtr = vtkLinearTransform_TransformNormal_20(GetCppThis(), x, y, z);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformNormal_21(HandleRef pThis, IntPtr normal);

	/// <summary>
	/// Synonymous with TransformDoubleNormal(x,y,z).
	/// Use this if you are programming in python or Java.
	/// </summary>
	public double[] TransformNormal(IntPtr normal)
	{
		IntPtr intPtr = vtkLinearTransform_TransformNormal_21(GetCppThis(), normal);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransform_TransformNormals_22(HandleRef pThis, HandleRef inNms, HandleRef outNms);

	/// <summary>
	/// Apply the transformation to a series of normals, and append the
	/// results to outNms.
	/// </summary>
	public virtual void TransformNormals(vtkDataArray inNms, vtkDataArray outNms)
	{
		vtkLinearTransform_TransformNormals_22(GetCppThis(), inNms?.GetCppThis() ?? default(HandleRef), outNms?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransform_TransformPoints_23(HandleRef pThis, HandleRef inPts, HandleRef outPts);

	/// <summary>
	/// Apply the transformation to a series of points, and append the
	/// results to outPts.
	/// </summary>
	public override void TransformPoints(vtkPoints inPts, vtkPoints outPts)
	{
		vtkLinearTransform_TransformPoints_23(GetCppThis(), inPts?.GetCppThis() ?? default(HandleRef), outPts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformVector_24(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Synonymous with TransformDoubleVector(x,y,z).
	/// Use this if you are programming in python or Java.
	/// </summary>
	public double[] TransformVector(double x, double y, double z)
	{
		IntPtr intPtr = vtkLinearTransform_TransformVector_24(GetCppThis(), x, y, z);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransform_TransformVector_25(HandleRef pThis, IntPtr normal);

	/// <summary>
	/// Synonymous with TransformDoubleVector(x,y,z).
	/// Use this if you are programming in python or Java.
	/// </summary>
	public double[] TransformVector(IntPtr normal)
	{
		IntPtr intPtr = vtkLinearTransform_TransformVector_25(GetCppThis(), normal);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransform_TransformVector_26(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Apply the transformation to a vector.
	/// You can use the same array to store both the input and output.
	/// </summary>
	public void TransformVector(IntPtr arg0, IntPtr arg1)
	{
		vtkLinearTransform_TransformVector_26(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransform_TransformVectors_27(HandleRef pThis, HandleRef inVrs, HandleRef outVrs);

	/// <summary>
	/// Apply the transformation to a series of vectors, and append the
	/// results to outVrs.
	/// </summary>
	public virtual void TransformVectors(vtkDataArray inVrs, vtkDataArray outVrs)
	{
		vtkLinearTransform_TransformVectors_27(GetCppThis(), inVrs?.GetCppThis() ?? default(HandleRef), outVrs?.GetCppThis() ?? default(HandleRef));
	}
}
