using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitFunction
/// </summary>
/// <remarks>
///    abstract interface for implicit functions
///
/// vtkImplicitFunction specifies an abstract interface for implicit
/// functions. Implicit functions are real valued functions defined in 3D
/// space, w = F(x,y,z). Two primitive operations are required: the ability to
/// evaluate the function, and the function gradient at a given point. The
/// implicit function divides space into three regions: on the surface
/// (F(x,y,z)=w), outside of the surface (F(x,y,z)&gt;c), and inside the
/// surface (F(x,y,z)&lt;c). (When c is zero, positive values are outside,
/// negative values are inside, and zero is on the surface. Note also
/// that the function gradient points from inside to outside.)
///
/// Implicit functions are very powerful. It is possible to represent almost
/// any type of geometry with the level sets w = const, especially if you use
/// boolean combinations of implicit functions (see vtkImplicitBoolean).
///
/// vtkImplicitFunction provides a mechanism to transform the implicit
/// function(s) via a vtkAbstractTransform.  This capability can be used to
/// translate, orient, scale, or warp implicit functions.  For example,
/// a sphere implicit function can be transformed into an oriented ellipse.
///
/// @warning
/// The transformation transforms a point into the space of the implicit
/// function (i.e., the model space). Typically we want to transform the
/// implicit model into world coordinates. In this case the inverse of the
/// transformation is required.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractTransform vtkSphere vtkCylinder vtkImplicitBoolean vtkPlane
/// vtkPlanes vtkQuadric vtkImplicitVolume vtkSampleFunction vtkCutter
/// vtkClipPolyData
/// </seealso>
public abstract class vtkImplicitFunction : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitFunction()
	{
		MRClassNameKey = "class vtkImplicitFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitFunction_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate function at position x-y-z and return value.  You should
	/// generally not call this method directly, you should use
	/// FunctionValue() instead.  This method must be implemented by
	/// any derived class.
	/// </summary>
	public virtual double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitFunction_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitFunction_EvaluateFunction_02(HandleRef pThis, HandleRef input, HandleRef output);

	/// <summary>
	/// Evaluate function at position x-y-z and return value.  You should
	/// generally not call this method directly, you should use
	/// FunctionValue() instead.  This method must be implemented by
	/// any derived class.
	/// </summary>
	public virtual void EvaluateFunction(vtkDataArray input, vtkDataArray output)
	{
		vtkImplicitFunction_EvaluateFunction_02(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitFunction_EvaluateFunction_03(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Evaluate function at position x-y-z and return value.  You should
	/// generally not call this method directly, you should use
	/// FunctionValue() instead.  This method must be implemented by
	/// any derived class.
	/// </summary>
	public virtual double EvaluateFunction(double x, double y, double z)
	{
		return vtkImplicitFunction_EvaluateFunction_03(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitFunction_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate function gradient at position x-y-z and pass back vector.
	/// You should generally not call this method directly, you should use
	/// FunctionGradient() instead.  This method must be implemented by
	/// any derived class.
	/// </summary>
	public virtual void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkImplicitFunction_EvaluateGradient_04(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitFunction_FunctionGradient_05(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate function gradient at position x-y-z and pass back vector. Point
	/// x[3] is transformed through transform (if provided).
	/// </summary>
	public void FunctionGradient(IntPtr x, IntPtr g)
	{
		vtkImplicitFunction_FunctionGradient_05(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitFunction_FunctionGradient_06(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate function gradient at position x-y-z and pass back vector. Point
	/// x[3] is transformed through transform (if provided).
	/// </summary>
	public double[] FunctionGradient(IntPtr x)
	{
		IntPtr intPtr = vtkImplicitFunction_FunctionGradient_06(GetCppThis(), x);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitFunction_FunctionGradient_07(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Evaluate function gradient at position x-y-z and pass back vector. Point
	/// x[3] is transformed through transform (if provided).
	/// </summary>
	public double[] FunctionGradient(double x, double y, double z)
	{
		IntPtr intPtr = vtkImplicitFunction_FunctionGradient_07(GetCppThis(), x, y, z);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitFunction_FunctionValue_08(HandleRef pThis, HandleRef input, HandleRef output);

	/// <summary>
	/// Evaluate function at position x-y-z and return value. Point x[3] is
	/// transformed through transform (if provided).
	/// </summary>
	public virtual void FunctionValue(vtkDataArray input, vtkDataArray output)
	{
		vtkImplicitFunction_FunctionValue_08(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitFunction_FunctionValue_09(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate function at position x-y-z and return value. Point x[3] is
	/// transformed through transform (if provided).
	/// </summary>
	public double FunctionValue(IntPtr x)
	{
		return vtkImplicitFunction_FunctionValue_09(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitFunction_FunctionValue_10(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Evaluate function at position x-y-z and return value. Point x[3] is
	/// transformed through transform (if provided).
	/// </summary>
	public double FunctionValue(double x, double y, double z)
	{
		return vtkImplicitFunction_FunctionValue_10(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImplicitFunction_GetMTime_11(HandleRef pThis);

	/// <summary>
	/// Overload standard modified time function. If Transform is modified,
	/// then this object is modified as well.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImplicitFunction_GetMTime_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitFunction_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitFunction_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitFunction_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitFunction_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitFunction_GetTransform_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a transformation to apply to input points before
	/// executing the implicit function.
	/// </summary>
	public virtual vtkAbstractTransform GetTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitFunction_GetTransform_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitFunction_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitFunction_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitFunction_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitFunction_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitFunction_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitFunction NewInstance()
	{
		vtkImplicitFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitFunction_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitFunction_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitFunction SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitFunction_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitFunction_SetTransform_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get a transformation to apply to input points before
	/// executing the implicit function.
	/// </summary>
	public virtual void SetTransform(vtkAbstractTransform arg0)
	{
		vtkImplicitFunction_SetTransform_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitFunction_SetTransform_20(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Set/Get a transformation to apply to input points before
	/// executing the implicit function.
	/// </summary>
	public virtual void SetTransform(IntPtr elements)
	{
		vtkImplicitFunction_SetTransform_20(GetCppThis(), elements);
	}
}
