using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitProjectOnPlaneDistance
///
/// This class receive a plannar polygon as input. Given a point, it can
/// evaluate the L0 or L2 norm between the projection of this point on the plan
/// of the polygon and the polygon itself.
///
/// An interesting use of this class is to enable the L0 norm and evaluate the
/// "projected distance" between every vertex of a mesh and the given plannar polygon.
/// As a result, all the vertices that project onto the polygon will correspond to the
/// value 0 and other ones will receive the value 1.
/// From there, we can use a clip to keep only the part of the mesh "below" the polygon.
///
/// TLDR: This filter allows to clip using the extrusion of any plannar polygon.
/// </summary>
public class vtkImplicitProjectOnPlaneDistance : vtkImplicitFunction
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum NormType
	{
		/// <summary>enum member</summary>
		L0 = 0,
		/// <summary>enum member</summary>
		L2 = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitProjectOnPlaneDistance";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitProjectOnPlaneDistance()
	{
		MRClassNameKey = "class vtkImplicitProjectOnPlaneDistance";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitProjectOnPlaneDistance"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitProjectOnPlaneDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitProjectOnPlaneDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitProjectOnPlaneDistance New()
	{
		vtkImplicitProjectOnPlaneDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitProjectOnPlaneDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitProjectOnPlaneDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImplicitProjectOnPlaneDistance()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitProjectOnPlaneDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitProjectOnPlaneDistance_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Project x onto the plane defined by the Input polydata and evaluate the
	/// distance to the geometry defined by the Input polydata.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitProjectOnPlaneDistance_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitProjectOnPlaneDistance_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate function gradient of nearest triangle to point x[3].
	/// WARNING: not implemented as it is of no use in this context.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkImplicitProjectOnPlaneDistance_EvaluateGradient_02(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitProjectOnPlaneDistance_GetLocator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the Locator used by to compute the distance.
	/// A vtkStaticCellLocator is provided by default if
	/// none is given by the user.
	/// </summary>
	public virtual vtkAbstractCellLocator GetLocator()
	{
		vtkAbstractCellLocator vtkAbstractCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitProjectOnPlaneDistance_GetLocator_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractCellLocator2 = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractCellLocator2.Register(null);
			}
		}
		return vtkAbstractCellLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImplicitProjectOnPlaneDistance_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the Input dependency.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImplicitProjectOnPlaneDistance_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern NormType vtkImplicitProjectOnPlaneDistance_GetNorm_05(HandleRef pThis);

	/// <summary>
	/// Set the norm to use:
	/// L0: 0 when the projection is inside the input polygon, 1 otherwise
	/// L2: Euclidean distance between the projection and the polygon (default)
	/// </summary>
	public NormType GetNorm()
	{
		return vtkImplicitProjectOnPlaneDistance_GetNorm_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitProjectOnPlaneDistance_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitProjectOnPlaneDistance_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitProjectOnPlaneDistance_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitProjectOnPlaneDistance_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitProjectOnPlaneDistance_GetTolerance_08(HandleRef pThis);

	/// <summary>
	/// Set/get the tolerance used for the locator.
	/// Default is 0.01.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkImplicitProjectOnPlaneDistance_GetTolerance_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitProjectOnPlaneDistance_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitProjectOnPlaneDistance_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitProjectOnPlaneDistance_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitProjectOnPlaneDistance_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitProjectOnPlaneDistance_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitProjectOnPlaneDistance NewInstance()
	{
		vtkImplicitProjectOnPlaneDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitProjectOnPlaneDistance_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitProjectOnPlaneDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitProjectOnPlaneDistance_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitProjectOnPlaneDistance SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitProjectOnPlaneDistance vtkImplicitProjectOnPlaneDistance2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitProjectOnPlaneDistance_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitProjectOnPlaneDistance2 = (vtkImplicitProjectOnPlaneDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitProjectOnPlaneDistance2.Register(null);
			}
		}
		return vtkImplicitProjectOnPlaneDistance2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitProjectOnPlaneDistance_SetInput_14(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the input vtkPolyData used for the implicit function
	/// evaluation. This polydata needs to be planar.
	/// </summary>
	public void SetInput(vtkPolyData input)
	{
		vtkImplicitProjectOnPlaneDistance_SetInput_14(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitProjectOnPlaneDistance_SetLocator_15(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set/get the Locator used by to compute the distance.
	/// A vtkStaticCellLocator is provided by default if
	/// none is given by the user.
	/// </summary>
	public virtual void SetLocator(vtkAbstractCellLocator _arg)
	{
		vtkImplicitProjectOnPlaneDistance_SetLocator_15(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitProjectOnPlaneDistance_SetNorm_16(HandleRef pThis, NormType n);

	/// <summary>
	/// Set the norm to use:
	/// L0: 0 when the projection is inside the input polygon, 1 otherwise
	/// L2: Euclidean distance between the projection and the polygon (default)
	/// </summary>
	public void SetNorm(NormType n)
	{
		vtkImplicitProjectOnPlaneDistance_SetNorm_16(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitProjectOnPlaneDistance_SetNorm_17(HandleRef pThis, int n);

	/// <summary>
	/// Set the norm to use:
	/// L0: 0 when the projection is inside the input polygon, 1 otherwise
	/// L2: Euclidean distance between the projection and the polygon (default)
	/// </summary>
	public void SetNorm(int n)
	{
		vtkImplicitProjectOnPlaneDistance_SetNorm_17(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitProjectOnPlaneDistance_SetTolerance_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the tolerance used for the locator.
	/// Default is 0.01.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkImplicitProjectOnPlaneDistance_SetTolerance_18(GetCppThis(), _arg);
	}
}
