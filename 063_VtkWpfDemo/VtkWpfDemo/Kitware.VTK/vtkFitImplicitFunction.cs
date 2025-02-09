using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFitImplicitFunction
/// </summary>
/// <remarks>
///    extract points on the surface of an implicit function
///
///
/// vtkFitImplicitFunction extract points that are on the surface of an
/// implicit function (within some threshold). Implicit functions in VTK are
/// any function of the form f(x,y,z)=c, where values c==0 are considered the
/// surface of the implicit function. Typical examples of implicit functions
/// include planes, spheres, cylinders, cones, etc. plus boolean combinations
/// of these functions. In this implementation, a threshold is used to create
/// a fuzzy region considered "on" the surface. In essence, this is a very
/// poor man's RANSAC algorithm, where the user picks a function on which to
/// fit some points. Thus it is possible to use this filter to define a
/// proposed model and place it into an optimization loop to best fit it to a
/// set of points.
///
/// Note that while any vtkPointSet type can be provided as input, the output is
/// represented by an explicit representation of points via a
/// vtkPolyData. This output polydata will populate its instance of vtkPoints,
/// but no cells will be defined (i.e., no vtkVertex or vtkPolyVertex are
/// contained in the output). Also, after filter execution, the user can
/// request a vtkIdType* map which indicates how the input points were mapped
/// to the output. A value of map[i] (where i is the ith input point) less
/// than 0 means that the ith input point was removed. (See also the
/// superclass documentation for accessing the removed points through the
/// filter's second output.)
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkPointCloudFilter vtkExtractPoints vtkImplicitFunction
/// </seealso>
public class vtkFitImplicitFunction : vtkPointCloudFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFitImplicitFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFitImplicitFunction()
	{
		MRClassNameKey = "class vtkFitImplicitFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFitImplicitFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFitImplicitFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFitImplicitFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkFitImplicitFunction New()
	{
		vtkFitImplicitFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFitImplicitFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFitImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkFitImplicitFunction()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFitImplicitFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFitImplicitFunction_GetImplicitFunction_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function defining a surface on which points
	/// are to be extracted.
	/// </summary>
	public virtual vtkImplicitFunction GetImplicitFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFitImplicitFunction_GetImplicitFunction_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkFitImplicitFunction_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// Return the MTime taking into account changes to the implicit function.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkFitImplicitFunction_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFitImplicitFunction_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFitImplicitFunction_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFitImplicitFunction_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFitImplicitFunction_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFitImplicitFunction_GetThreshold_05(HandleRef pThis);

	/// <summary>
	/// Specify a threshold value which defines a fuzzy extraction surface.
	/// Since in this filter the implicit surface is defined as f(x,y,z)=0;
	/// the extracted points are (-Threshold &lt;= f(x,y,z) &lt; Threshold).
	/// </summary>
	public virtual double GetThreshold()
	{
		return vtkFitImplicitFunction_GetThreshold_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFitImplicitFunction_GetThresholdMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Specify a threshold value which defines a fuzzy extraction surface.
	/// Since in this filter the implicit surface is defined as f(x,y,z)=0;
	/// the extracted points are (-Threshold &lt;= f(x,y,z) &lt; Threshold).
	/// </summary>
	public virtual double GetThresholdMaxValue()
	{
		return vtkFitImplicitFunction_GetThresholdMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFitImplicitFunction_GetThresholdMinValue_07(HandleRef pThis);

	/// <summary>
	/// Specify a threshold value which defines a fuzzy extraction surface.
	/// Since in this filter the implicit surface is defined as f(x,y,z)=0;
	/// the extracted points are (-Threshold &lt;= f(x,y,z) &lt; Threshold).
	/// </summary>
	public virtual double GetThresholdMinValue()
	{
		return vtkFitImplicitFunction_GetThresholdMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFitImplicitFunction_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFitImplicitFunction_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFitImplicitFunction_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFitImplicitFunction_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFitImplicitFunction_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkFitImplicitFunction NewInstance()
	{
		vtkFitImplicitFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFitImplicitFunction_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFitImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFitImplicitFunction_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkFitImplicitFunction SafeDownCast(vtkObjectBase o)
	{
		vtkFitImplicitFunction vtkFitImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFitImplicitFunction_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFitImplicitFunction2 = (vtkFitImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFitImplicitFunction2.Register(null);
			}
		}
		return vtkFitImplicitFunction2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitImplicitFunction_SetImplicitFunction_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function defining a surface on which points
	/// are to be extracted.
	/// </summary>
	public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
	{
		vtkFitImplicitFunction_SetImplicitFunction_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitImplicitFunction_SetThreshold_14(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a threshold value which defines a fuzzy extraction surface.
	/// Since in this filter the implicit surface is defined as f(x,y,z)=0;
	/// the extracted points are (-Threshold &lt;= f(x,y,z) &lt; Threshold).
	/// </summary>
	public virtual void SetThreshold(double _arg)
	{
		vtkFitImplicitFunction_SetThreshold_14(GetCppThis(), _arg);
	}
}
