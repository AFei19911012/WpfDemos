using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRadiusOutlierRemoval
/// </summary>
/// <remarks>
///    remove isolated points
///
///
/// vtkRadiusOutlierRemoval removes isolated points; i.e., those points that
/// have few neighbors within a specified radius. The user must specify the
/// radius defining the local region, as well as the isolation threshold
/// (i.e., number of neighboring points required for the point to be
/// considered isolated). Optionally, users can specify a point locator to
/// accelerate local neighborhood search operations. (By default a
/// vtkStaticPointLocator will be created.)
///
/// Note that while any vtkPointSet type can be provided as input, the output
/// is represented by an explicit representation of points via a
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
/// vtkPointCloudFilter vtkStatisticalOutlierRemoval vtkExtractPoints
/// vtkThresholdPoints vtkImplicitFunction
/// </seealso>
public class vtkRadiusOutlierRemoval : vtkPointCloudFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRadiusOutlierRemoval";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRadiusOutlierRemoval()
	{
		MRClassNameKey = "class vtkRadiusOutlierRemoval";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRadiusOutlierRemoval"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRadiusOutlierRemoval(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRadiusOutlierRemoval_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkRadiusOutlierRemoval New()
	{
		vtkRadiusOutlierRemoval result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRadiusOutlierRemoval_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRadiusOutlierRemoval)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkRadiusOutlierRemoval()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRadiusOutlierRemoval_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRadiusOutlierRemoval_GetLocator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate near a
	/// specified interpolation position.
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRadiusOutlierRemoval_GetLocator_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRadiusOutlierRemoval_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRadiusOutlierRemoval_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRadiusOutlierRemoval_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRadiusOutlierRemoval_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRadiusOutlierRemoval_GetNumberOfNeighbors_04(HandleRef pThis);

	/// <summary>
	/// Specify the number of neighbors that a point must have, within
	/// the specified radius, for the point to not be considered isolated.
	/// </summary>
	public virtual int GetNumberOfNeighbors()
	{
		return vtkRadiusOutlierRemoval_GetNumberOfNeighbors_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRadiusOutlierRemoval_GetNumberOfNeighborsMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the number of neighbors that a point must have, within
	/// the specified radius, for the point to not be considered isolated.
	/// </summary>
	public virtual int GetNumberOfNeighborsMaxValue()
	{
		return vtkRadiusOutlierRemoval_GetNumberOfNeighborsMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRadiusOutlierRemoval_GetNumberOfNeighborsMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the number of neighbors that a point must have, within
	/// the specified radius, for the point to not be considered isolated.
	/// </summary>
	public virtual int GetNumberOfNeighborsMinValue()
	{
		return vtkRadiusOutlierRemoval_GetNumberOfNeighborsMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRadiusOutlierRemoval_GetRadius_07(HandleRef pThis);

	/// <summary>
	/// Specify the local search radius.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkRadiusOutlierRemoval_GetRadius_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRadiusOutlierRemoval_GetRadiusMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the local search radius.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkRadiusOutlierRemoval_GetRadiusMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRadiusOutlierRemoval_GetRadiusMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the local search radius.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkRadiusOutlierRemoval_GetRadiusMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRadiusOutlierRemoval_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRadiusOutlierRemoval_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRadiusOutlierRemoval_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRadiusOutlierRemoval_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRadiusOutlierRemoval_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkRadiusOutlierRemoval NewInstance()
	{
		vtkRadiusOutlierRemoval result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRadiusOutlierRemoval_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRadiusOutlierRemoval)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRadiusOutlierRemoval_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkRadiusOutlierRemoval SafeDownCast(vtkObjectBase o)
	{
		vtkRadiusOutlierRemoval vtkRadiusOutlierRemoval2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRadiusOutlierRemoval_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRadiusOutlierRemoval2 = (vtkRadiusOutlierRemoval)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRadiusOutlierRemoval2.Register(null);
			}
		}
		return vtkRadiusOutlierRemoval2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRadiusOutlierRemoval_SetLocator_15(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate near a
	/// specified interpolation position.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkRadiusOutlierRemoval_SetLocator_15(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRadiusOutlierRemoval_SetNumberOfNeighbors_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of neighbors that a point must have, within
	/// the specified radius, for the point to not be considered isolated.
	/// </summary>
	public virtual void SetNumberOfNeighbors(int _arg)
	{
		vtkRadiusOutlierRemoval_SetNumberOfNeighbors_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRadiusOutlierRemoval_SetRadius_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the local search radius.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkRadiusOutlierRemoval_SetRadius_17(GetCppThis(), _arg);
	}
}
