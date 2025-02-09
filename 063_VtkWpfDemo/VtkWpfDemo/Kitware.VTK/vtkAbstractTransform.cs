using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractTransform
/// </summary>
/// <remarks>
///    superclass for all geometric transformations
///
/// vtkAbstractTransform is the superclass for all VTK geometric
/// transformations.  The VTK transform hierarchy is split into two
/// major branches: warp transformations and homogeneous (including linear)
/// transformations.  The latter can be represented in terms of a 4x4
/// transformation matrix, the former cannot.
/// &lt;p&gt;Transformations can be pipelined through two mechanisms:
/// &lt;p&gt;1) GetInverse() returns the pipelined
/// inverse of a transformation i.e. if you modify the original transform,
/// any transform previously returned by the GetInverse() method will
/// automatically update itself according to the change.
/// &lt;p&gt;2) You can do pipelined concatenation of transformations through
/// the vtkGeneralTransform class, the vtkPerspectiveTransform class,
/// or the vtkTransform class.
/// </remarks>
/// <seealso>
///
/// vtkGeneralTransform vtkWarpTransform vtkHomogeneousTransform
/// vtkLinearTransform vtkIdentityTransform
/// vtkTransformPolyDataFilter vtkTransformFilter vtkImageReslice
/// vtkImplicitFunction
/// </seealso>
public abstract class vtkAbstractTransform : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractTransform()
	{
		MRClassNameKey = "class vtkAbstractTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractTransform_UnRegister_31(HandleRef pThis, HandleRef O);

	/// <summary>
	/// Needs a special UnRegister() implementation to avoid
	/// circular references.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (GetCallDisposalMethod())
			{
				vtkAbstractTransform_UnRegister_31(GetCppThis(), default(HandleRef));
				ClearCppThis();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractTransform_CircuitCheck_01(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Check for self-reference.  Will return true if concatenating
	/// with the specified transform, setting it to be our inverse,
	/// or setting it to be our input will create a circular reference.
	/// CircuitCheck is automatically called by SetInput(), SetInverse(),
	/// and Concatenate(vtkXTransform *).  Avoid using this function,
	/// it is experimental.
	/// </summary>
	public virtual int CircuitCheck(vtkAbstractTransform transform)
	{
		return vtkAbstractTransform_CircuitCheck_01(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractTransform_DeepCopy_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Copy this transform from another of the same type.
	/// </summary>
	public void DeepCopy(vtkAbstractTransform arg0)
	{
		vtkAbstractTransform_DeepCopy_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_GetInverse_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the inverse of this transform.  If you modify this transform,
	/// the returned inverse transform will automatically update.  If you
	/// want the inverse of a vtkTransform, you might want to use
	/// GetLinearInverse() instead which will type cast the result from
	/// vtkAbstractTransform to vtkLinearTransform.
	/// </summary>
	public vtkAbstractTransform GetInverse()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractTransform_GetInverse_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkAbstractTransform_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Override GetMTime necessary because of inverse transforms.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAbstractTransform_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractTransform_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractTransform_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractTransform_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractTransform_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractTransform_InternalTransformPoint_07(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public virtual void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkAbstractTransform_InternalTransformPoint_07(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractTransform_Inverse_08(HandleRef pThis);

	/// <summary>
	/// Invert the transformation.
	/// </summary>
	public virtual void Inverse()
	{
		vtkAbstractTransform_Inverse_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractTransform_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractTransform_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractTransform_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractTransform_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_MakeTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make another transform of the same type.
	/// </summary>
	public virtual vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractTransform_MakeTransform_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractTransform NewInstance()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractTransform_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractTransform SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractTransform_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAbstractTransform_SetInverse_14(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Set a transformation that this transform will be the inverse of.
	/// This transform will automatically update to agree with the
	/// inverse transform that you set.
	/// </summary>
	public void SetInverse(vtkAbstractTransform transform)
	{
		vtkAbstractTransform_SetInverse_14(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformDoubleNormalAtPoint_15(HandleRef pThis, IntPtr point, IntPtr normal);

	/// <summary>
	/// Apply the transformation to a double-precision normal at the specified
	/// vertex.  If the transformation is a vtkLinearTransform, you can use
	/// TransformDoubleNormal() instead.
	/// </summary>
	public double[] TransformDoubleNormalAtPoint(IntPtr point, IntPtr normal)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformDoubleNormalAtPoint_15(GetCppThis(), point, normal);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformDoublePoint_16(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Apply the transformation to a double-precision (x,y,z) coordinate.
	/// Use this if you are programming in Python or Java.
	/// </summary>
	public double[] TransformDoublePoint(double x, double y, double z)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformDoublePoint_16(GetCppThis(), x, y, z);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformDoublePoint_17(HandleRef pThis, IntPtr point);

	/// <summary>
	/// Apply the transformation to a double-precision (x,y,z) coordinate.
	/// Use this if you are programming in Python or Java.
	/// </summary>
	public double[] TransformDoublePoint(IntPtr point)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformDoublePoint_17(GetCppThis(), point);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformDoubleVectorAtPoint_18(HandleRef pThis, IntPtr point, IntPtr vector);

	/// <summary>
	/// Apply the transformation to a double-precision vector at the specified
	/// vertex.  If the transformation is a vtkLinearTransform, you can use
	/// TransformDoubleVector() instead.
	/// </summary>
	public double[] TransformDoubleVectorAtPoint(IntPtr point, IntPtr vector)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformDoubleVectorAtPoint_18(GetCppThis(), point, vector);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformFloatNormalAtPoint_19(HandleRef pThis, IntPtr point, IntPtr normal);

	/// <summary>
	/// Apply the transformation to a single-precision normal at the specified
	/// vertex.  If the transformation is a vtkLinearTransform, you can use
	/// TransformFloatNormal() instead.
	/// </summary>
	public float[] TransformFloatNormalAtPoint(IntPtr point, IntPtr normal)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformFloatNormalAtPoint_19(GetCppThis(), point, normal);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformFloatPoint_20(HandleRef pThis, float x, float y, float z);

	/// <summary>
	/// Apply the transformation to an (x,y,z) coordinate.
	/// Use this if you are programming in Python or Java.
	/// </summary>
	public float[] TransformFloatPoint(float x, float y, float z)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformFloatPoint_20(GetCppThis(), x, y, z);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformFloatPoint_21(HandleRef pThis, IntPtr point);

	/// <summary>
	/// Apply the transformation to an (x,y,z) coordinate.
	/// Use this if you are programming in Python or Java.
	/// </summary>
	public float[] TransformFloatPoint(IntPtr point)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformFloatPoint_21(GetCppThis(), point);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformFloatVectorAtPoint_22(HandleRef pThis, IntPtr point, IntPtr vector);

	/// <summary>
	/// Apply the transformation to a single-precision vector at the specified
	/// vertex.  If the transformation is a vtkLinearTransform, you can use
	/// TransformFloatVector() instead.
	/// </summary>
	public float[] TransformFloatVectorAtPoint(IntPtr point, IntPtr vector)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformFloatVectorAtPoint_22(GetCppThis(), point, vector);
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractTransform_TransformNormalAtPoint_23(HandleRef pThis, IntPtr point, IntPtr arg1, IntPtr arg2);

	/// <summary>
	/// Apply the transformation to a normal at the specified vertex.  If the
	/// transformation is a vtkLinearTransform, you can use TransformNormal()
	/// instead.
	/// </summary>
	public void TransformNormalAtPoint(IntPtr point, IntPtr arg1, IntPtr arg2)
	{
		vtkAbstractTransform_TransformNormalAtPoint_23(GetCppThis(), point, arg1, arg2);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformNormalAtPoint_24(HandleRef pThis, IntPtr point, IntPtr normal);

	/// <summary>
	/// Apply the transformation to a normal at the specified vertex.  If the
	/// transformation is a vtkLinearTransform, you can use TransformNormal()
	/// instead.
	/// </summary>
	public double[] TransformNormalAtPoint(IntPtr point, IntPtr normal)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformNormalAtPoint_24(GetCppThis(), point, normal);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractTransform_TransformPoint_25(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Apply the transformation to a coordinate.  You can use the same
	/// array to store both the input and output point.
	/// </summary>
	public void TransformPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkAbstractTransform_TransformPoint_25(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformPoint_26(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Apply the transformation to a double-precision coordinate.
	/// Use this if you are programming in Python or Java.
	/// </summary>
	public double[] TransformPoint(double x, double y, double z)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformPoint_26(GetCppThis(), x, y, z);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformPoint_27(HandleRef pThis, IntPtr point);

	/// <summary>
	/// Apply the transformation to a double-precision coordinate.
	/// Use this if you are programming in Python or Java.
	/// </summary>
	public double[] TransformPoint(IntPtr point)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformPoint_27(GetCppThis(), point);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractTransform_TransformPoints_28(HandleRef pThis, HandleRef inPts, HandleRef outPts);

	/// <summary>
	/// Apply the transformation to a series of points, and append the
	/// results to outPts.
	/// </summary>
	public virtual void TransformPoints(vtkPoints inPts, vtkPoints outPts)
	{
		vtkAbstractTransform_TransformPoints_28(GetCppThis(), inPts?.GetCppThis() ?? default(HandleRef), outPts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractTransform_TransformVectorAtPoint_29(HandleRef pThis, IntPtr point, IntPtr arg1, IntPtr arg2);

	/// <summary>
	/// Apply the transformation to a vector at the specified vertex.  If the
	/// transformation is a vtkLinearTransform, you can use TransformVector()
	/// instead.
	/// </summary>
	public void TransformVectorAtPoint(IntPtr point, IntPtr arg1, IntPtr arg2)
	{
		vtkAbstractTransform_TransformVectorAtPoint_29(GetCppThis(), point, arg1, arg2);
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractTransform_TransformVectorAtPoint_30(HandleRef pThis, IntPtr point, IntPtr vector);

	/// <summary>
	/// Apply the transformation to a vector at the specified vertex.  If the
	/// transformation is a vtkLinearTransform, you can use TransformVector()
	/// instead.
	/// </summary>
	public double[] TransformVectorAtPoint(IntPtr point, IntPtr vector)
	{
		IntPtr intPtr = vtkAbstractTransform_TransformVectorAtPoint_30(GetCppThis(), point, vector);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractTransform_Update_32(HandleRef pThis);

	/// <summary>
	/// Update the transform to account for any changes which
	/// have been made.  You do not have to call this method
	/// yourself, it is called automatically whenever the
	/// transform needs an update.
	/// </summary>
	public void Update()
	{
		vtkAbstractTransform_Update_32(GetCppThis());
	}
}
