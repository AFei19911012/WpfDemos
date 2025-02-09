using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractPoints
/// </summary>
/// <remarks>
///    extract points within an implicit function
///
///
/// vtkExtractPoints removes points that are either inside or outside of a
/// vtkImplicitFunction. Implicit functions in VTK defined as function of the
/// form f(x,y,z)=c, where values c&lt;=0 are interior values of the implicit
/// function. Typical examples include planes, spheres, cylinders, cones,
/// etc. plus boolean combinations of these functions. (This operation
/// presumes closure on the set, so points on the boundary are also considered
/// to be inside.)
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
/// @warning
/// The vtkExtractEnclosedPoints filter can be used to extract points inside of
/// a volume defined by a manifold, closed polygonal surface. This filter
/// however is much slower than methods based on implicit functions (like this
/// filter).
///
/// </remarks>
/// <seealso>
///
/// vtkExtractEnclosedPoints vtkSelectEnclosedPoints vtkPointCloudFilter
/// vtkRadiusOutlierRemoval vtkStatisticalOutlierRemoval vtkThresholdPoints
/// vtkImplicitFunction vtkExtractGeometry vtkFitImplicitFunction
/// </seealso>
public class vtkExtractPoints : vtkPointCloudFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractPoints()
	{
		MRClassNameKey = "class vtkExtractPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkExtractPoints New()
	{
		vtkExtractPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkExtractPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtractPoints_ExtractInsideOff_01(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract points that are inside of implicit
	/// function (ExtractInside == true) or outside of implicit function
	/// (ExtractInside == false). By default, ExtractInside is true.
	/// </summary>
	public virtual void ExtractInsideOff()
	{
		vtkExtractPoints_ExtractInsideOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPoints_ExtractInsideOn_02(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract points that are inside of implicit
	/// function (ExtractInside == true) or outside of implicit function
	/// (ExtractInside == false). By default, ExtractInside is true.
	/// </summary>
	public virtual void ExtractInsideOn()
	{
		vtkExtractPoints_ExtractInsideOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractPoints_GetExtractInside_03(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to extract points that are inside of implicit
	/// function (ExtractInside == true) or outside of implicit function
	/// (ExtractInside == false). By default, ExtractInside is true.
	/// </summary>
	public virtual bool GetExtractInside()
	{
		return (vtkExtractPoints_GetExtractInside_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPoints_GetImplicitFunction_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function for inside/outside checks.
	/// </summary>
	public virtual vtkImplicitFunction GetImplicitFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPoints_GetImplicitFunction_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkExtractPoints_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Return the MTime taking into account changes to the implicit function
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExtractPoints_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractPoints_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractPoints_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractPoints_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractPoints_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractPoints_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractPoints_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractPoints_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractPoints_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPoints_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkExtractPoints NewInstance()
	{
		vtkExtractPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPoints_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractPoints_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkExtractPoints SafeDownCast(vtkObjectBase o)
	{
		vtkExtractPoints vtkExtractPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractPoints_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractPoints2 = (vtkExtractPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractPoints2.Register(null);
			}
		}
		return vtkExtractPoints2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPoints_SetExtractInside_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// Boolean controls whether to extract points that are inside of implicit
	/// function (ExtractInside == true) or outside of implicit function
	/// (ExtractInside == false). By default, ExtractInside is true.
	/// </summary>
	public virtual void SetExtractInside(bool _arg)
	{
		vtkExtractPoints_SetExtractInside_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractPoints_SetImplicitFunction_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function for inside/outside checks.
	/// </summary>
	public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
	{
		vtkExtractPoints_SetImplicitFunction_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
