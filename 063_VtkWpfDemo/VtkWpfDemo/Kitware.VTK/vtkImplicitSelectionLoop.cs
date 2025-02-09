using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitSelectionLoop
/// </summary>
/// <remarks>
///    implicit function for a selection loop
///
/// vtkImplicitSelectionLoop computes the implicit function value and
/// function gradient for an irregular, cylinder-like object whose cross
/// section is defined by a set of points forming a loop. The loop need
/// not be convex nor its points coplanar. However, the loop must be
/// non-self-intersecting when projected onto the plane defined by the
/// accumulated cross product around the loop (i.e., the axis of the
/// loop). (Alternatively, you can specify the normal to use.)
///
/// The following procedure is used to compute the implicit function
/// value for a point x. Each point of the loop is first projected onto
/// the plane defined by the loop normal. This forms a polygon. Then,
/// to evaluate the implicit function value, inside/outside tests are
/// used to determine if x is inside the polygon, and the distance to
/// the loop boundary is computed (negative values are inside the
/// loop).
///
/// One example application of this implicit function class is to draw a
/// loop on the surface of a mesh, and use the loop to clip or extract
/// cells from within the loop. Remember, the selection loop is "infinite"
/// in length, you can use a plane (in boolean combination) to cap the extent
/// of the selection loop. Another trick is to use a connectivity filter to
/// extract the closest region to a given point (i.e., one of the points used
/// to define the selection loop).
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction vtkImplicitBoolean vtkExtractGeometry vtkClipPolyData
/// vtkConnectivityFilter vtkPolyDataConnectivityFilter
/// </seealso>
public class vtkImplicitSelectionLoop : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitSelectionLoop";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitSelectionLoop()
	{
		MRClassNameKey = "class vtkImplicitSelectionLoop";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitSelectionLoop"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitSelectionLoop(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitSelectionLoop_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with no initial loop.
	/// </summary>
	public new static vtkImplicitSelectionLoop New()
	{
		vtkImplicitSelectionLoop result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitSelectionLoop_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitSelectionLoop)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with no initial loop.
	/// </summary>
	public vtkImplicitSelectionLoop()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitSelectionLoop_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImplicitSelectionLoop_AutomaticNormalGenerationOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic normal generation. By default, the normal is
	/// computed from the accumulated cross product of the edges. You can also
	/// specify the normal to use.
	/// </summary>
	public virtual void AutomaticNormalGenerationOff()
	{
		vtkImplicitSelectionLoop_AutomaticNormalGenerationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSelectionLoop_AutomaticNormalGenerationOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic normal generation. By default, the normal is
	/// computed from the accumulated cross product of the edges. You can also
	/// specify the normal to use.
	/// </summary>
	public virtual void AutomaticNormalGenerationOn()
	{
		vtkImplicitSelectionLoop_AutomaticNormalGenerationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitSelectionLoop_EvaluateFunction_03(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate selection loop returning a signed distance.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitSelectionLoop_EvaluateFunction_03(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSelectionLoop_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr n);

	/// <summary>
	/// Evaluate selection loop returning the gradient.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr n)
	{
		vtkImplicitSelectionLoop_EvaluateGradient_04(GetCppThis(), x, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitSelectionLoop_GetAutomaticNormalGeneration_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic normal generation. By default, the normal is
	/// computed from the accumulated cross product of the edges. You can also
	/// specify the normal to use.
	/// </summary>
	public virtual int GetAutomaticNormalGeneration()
	{
		return vtkImplicitSelectionLoop_GetAutomaticNormalGeneration_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitSelectionLoop_GetLoop_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the array of point coordinates defining the loop. There must
	/// be at least three points used to define a loop.
	/// </summary>
	public virtual vtkPoints GetLoop()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitSelectionLoop_GetLoop_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImplicitSelectionLoop_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Overload GetMTime() because we depend on the Loop
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImplicitSelectionLoop_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitSelectionLoop_GetNormal_08(HandleRef pThis);

	/// <summary>
	/// Set / get the normal used to determine whether a point is inside or outside
	/// the selection loop.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkImplicitSelectionLoop_GetNormal_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSelectionLoop_GetNormal_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the normal used to determine whether a point is inside or outside
	/// the selection loop.
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkImplicitSelectionLoop_GetNormal_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitSelectionLoop_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for printing and type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitSelectionLoop_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitSelectionLoop_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard VTK methods for printing and type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitSelectionLoop_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitSelectionLoop_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for printing and type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitSelectionLoop_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitSelectionLoop_IsTypeOf_13(string type);

	/// <summary>
	/// Standard VTK methods for printing and type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitSelectionLoop_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitSelectionLoop_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for printing and type information.
	/// </summary>
	public new vtkImplicitSelectionLoop NewInstance()
	{
		vtkImplicitSelectionLoop result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitSelectionLoop_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitSelectionLoop)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitSelectionLoop_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for printing and type information.
	/// </summary>
	public new static vtkImplicitSelectionLoop SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitSelectionLoop vtkImplicitSelectionLoop2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitSelectionLoop_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitSelectionLoop2 = (vtkImplicitSelectionLoop)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitSelectionLoop2.Register(null);
			}
		}
		return vtkImplicitSelectionLoop2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSelectionLoop_SetAutomaticNormalGeneration_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off automatic normal generation. By default, the normal is
	/// computed from the accumulated cross product of the edges. You can also
	/// specify the normal to use.
	/// </summary>
	public virtual void SetAutomaticNormalGeneration(int _arg)
	{
		vtkImplicitSelectionLoop_SetAutomaticNormalGeneration_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSelectionLoop_SetLoop_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the array of point coordinates defining the loop. There must
	/// be at least three points used to define a loop.
	/// </summary>
	public virtual void SetLoop(vtkPoints arg0)
	{
		vtkImplicitSelectionLoop_SetLoop_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSelectionLoop_SetNormal_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set / get the normal used to determine whether a point is inside or outside
	/// the selection loop.
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkImplicitSelectionLoop_SetNormal_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSelectionLoop_SetNormal_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the normal used to determine whether a point is inside or outside
	/// the selection loop.
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkImplicitSelectionLoop_SetNormal_20(GetCppThis(), _arg);
	}
}
