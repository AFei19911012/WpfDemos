using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <remarks>
///   Compute Hausdorff distance between two point sets
///
/// This class computes the relative and hausdorff distances from two point
/// sets (input port 0 and input port 1). If no topology is specified (ie.
/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
/// computed between point location. If polys exist (ie triangulation),
/// the TargetDistanceMethod allows for an interpolation of the cells to
/// ensure a better minimal distance exploration.
///
/// The outputs (port 0 and 1) have the same geometry and topology as its
/// respective input port. Two FieldData arrays are added : HausdorffDistance
/// and RelativeDistance. The former is equal on both outputs whereas the
/// latter may differ. A PointData containing the specific point minimal
/// distance is also added to both outputs.
///
/// @author Frederic Commandeur
/// @author Jerome Velut
/// @author LTSI
///
/// @see https://www.vtkjournal.org/browse/publication/839
/// </remarks>
public class vtkHausdorffDistancePointSetFilter : vtkPointSetAlgorithm
{
	/// <summary>
	/// Get the Hausdorff Distance.
	/// </summary>
	public enum DistanceMethod
	{
		/// <summary>enum member</summary>
		POINT_TO_CELL = 1,
		/// <summary>enum member</summary>
		POINT_TO_POINT = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHausdorffDistancePointSetFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHausdorffDistancePointSetFilter()
	{
		MRClassNameKey = "class vtkHausdorffDistancePointSetFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHausdorffDistancePointSetFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHausdorffDistancePointSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHausdorffDistancePointSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static vtkHausdorffDistancePointSetFilter New()
	{
		vtkHausdorffDistancePointSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHausdorffDistancePointSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHausdorffDistancePointSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public vtkHausdorffDistancePointSetFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHausdorffDistancePointSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHausdorffDistancePointSetFilter_GetHausdorffDistance_01(HandleRef pThis);

	/// <summary>
	/// Get the Hausdorff Distance.
	/// </summary>
	public virtual double GetHausdorffDistance()
	{
		return vtkHausdorffDistancePointSetFilter_GetHausdorffDistance_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHausdorffDistancePointSetFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHausdorffDistancePointSetFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHausdorffDistancePointSetFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHausdorffDistancePointSetFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHausdorffDistancePointSetFilter_GetRelativeDistance_04(HandleRef pThis);

	/// <summary>
	/// Get the Relative Distance from A to B and B to A.
	/// </summary>
	public virtual double[] GetRelativeDistance()
	{
		IntPtr intPtr = vtkHausdorffDistancePointSetFilter_GetRelativeDistance_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHausdorffDistancePointSetFilter_GetRelativeDistance_05(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Get the Relative Distance from A to B and B to A.
	/// </summary>
	public virtual void GetRelativeDistance(ref double _arg1, ref double _arg2)
	{
		vtkHausdorffDistancePointSetFilter_GetRelativeDistance_05(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHausdorffDistancePointSetFilter_GetRelativeDistance_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the Relative Distance from A to B and B to A.
	/// </summary>
	public virtual void GetRelativeDistance(IntPtr _arg)
	{
		vtkHausdorffDistancePointSetFilter_GetRelativeDistance_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHausdorffDistancePointSetFilter_GetTargetDistanceMethod_07(HandleRef pThis);

	/// <summary>
	/// Specify the strategy for computing the distance. If no topology is specified (ie.
	/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
	/// computed between point location. If polys exist (i.e. triangulation),
	/// the TargetDistanceMethod allows for an interpolation of the cells to
	/// ensure a better minimal distance exploration.
	///
	/// </summary>
	public virtual int GetTargetDistanceMethod()
	{
		return vtkHausdorffDistancePointSetFilter_GetTargetDistanceMethod_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHausdorffDistancePointSetFilter_GetTargetDistanceMethodAsString_08(HandleRef pThis);

	/// <summary>
	/// Specify the strategy for computing the distance. If no topology is specified (ie.
	/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
	/// computed between point location. If polys exist (i.e. triangulation),
	/// the TargetDistanceMethod allows for an interpolation of the cells to
	/// ensure a better minimal distance exploration.
	///
	/// </summary>
	public string GetTargetDistanceMethodAsString()
	{
		return Marshal.PtrToStringAnsi(vtkHausdorffDistancePointSetFilter_GetTargetDistanceMethodAsString_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHausdorffDistancePointSetFilter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHausdorffDistancePointSetFilter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHausdorffDistancePointSetFilter_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHausdorffDistancePointSetFilter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHausdorffDistancePointSetFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new vtkHausdorffDistancePointSetFilter NewInstance()
	{
		vtkHausdorffDistancePointSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHausdorffDistancePointSetFilter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHausdorffDistancePointSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHausdorffDistancePointSetFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static vtkHausdorffDistancePointSetFilter SafeDownCast(vtkObjectBase o)
	{
		vtkHausdorffDistancePointSetFilter vtkHausdorffDistancePointSetFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHausdorffDistancePointSetFilter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHausdorffDistancePointSetFilter2 = (vtkHausdorffDistancePointSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHausdorffDistancePointSetFilter2.Register(null);
			}
		}
		return vtkHausdorffDistancePointSetFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethod_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the strategy for computing the distance. If no topology is specified (ie.
	/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
	/// computed between point location. If polys exist (i.e. triangulation),
	/// the TargetDistanceMethod allows for an interpolation of the cells to
	/// ensure a better minimal distance exploration.
	///
	/// </summary>
	public virtual void SetTargetDistanceMethod(int _arg)
	{
		vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethod_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethodToPointToCell_15(HandleRef pThis);

	/// <summary>
	/// Specify the strategy for computing the distance. If no topology is specified (ie.
	/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
	/// computed between point location. If polys exist (i.e. triangulation),
	/// the TargetDistanceMethod allows for an interpolation of the cells to
	/// ensure a better minimal distance exploration.
	///
	/// </summary>
	public void SetTargetDistanceMethodToPointToCell()
	{
		vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethodToPointToCell_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethodToPointToPoint_16(HandleRef pThis);

	/// <summary>
	/// Specify the strategy for computing the distance. If no topology is specified (ie.
	/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
	/// computed between point location. If polys exist (i.e. triangulation),
	/// the TargetDistanceMethod allows for an interpolation of the cells to
	/// ensure a better minimal distance exploration.
	///
	/// </summary>
	public void SetTargetDistanceMethodToPointToPoint()
	{
		vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethodToPointToPoint_16(GetCppThis());
	}
}
