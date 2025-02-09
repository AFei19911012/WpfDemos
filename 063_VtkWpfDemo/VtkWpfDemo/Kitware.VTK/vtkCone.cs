using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCone
/// </summary>
/// <remarks>
///    implicit function for a cone
///
/// vtkCone computes the implicit function and function gradient for a cone.
/// vtkCone is a concrete implementation of vtkImplicitFunction. The cone vertex
/// is located at the origin with axis of rotation coincident with x-axis. (Use
/// the superclass' vtkImplicitFunction transformation matrix if necessary to
/// reposition.) The angle specifies the angle between the axis of rotation
/// and the side of the cone.
///
/// @warning
/// The cone is infinite in extent. To truncate the cone use the
/// vtkImplicitBoolean in combination with clipping planes.
/// </remarks>
public class vtkCone : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCone";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCone()
	{
		MRClassNameKey = "class vtkCone";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCone"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCone(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCone_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new static vtkCone New()
	{
		vtkCone result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCone_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCone)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public vtkCone()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCone_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCone_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate cone equation.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkCone_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCone_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate cone normal.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkCone_EvaluateGradient_02(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCone_GetAngle_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the cone angle (expressed in degrees).
	/// </summary>
	public virtual double GetAngle()
	{
		return vtkCone_GetAngle_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCone_GetAngleMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the cone angle (expressed in degrees).
	/// </summary>
	public virtual double GetAngleMaxValue()
	{
		return vtkCone_GetAngleMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCone_GetAngleMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the cone angle (expressed in degrees).
	/// </summary>
	public virtual double GetAngleMinValue()
	{
		return vtkCone_GetAngleMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCone_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCone_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCone_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCone_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCone_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCone_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCone_IsTypeOf_09(string type);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCone_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCone_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new vtkCone NewInstance()
	{
		vtkCone result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCone_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCone)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCone_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct cone with angle of 45 degrees.
	/// </summary>
	public new static vtkCone SafeDownCast(vtkObjectBase o)
	{
		vtkCone vtkCone2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCone_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCone2 = (vtkCone)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCone2.Register(null);
			}
		}
		return vtkCone2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCone_SetAngle_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the cone angle (expressed in degrees).
	/// </summary>
	public virtual void SetAngle(double _arg)
	{
		vtkCone_SetAngle_13(GetCppThis(), _arg);
	}
}
