using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKdTreePointLocator
/// </summary>
/// <remarks>
///    class to quickly locate points in 3-space
///
/// vtkKdTreePointLocator is a wrapper class that derives from
/// vtkAbstractPointLocator and calls the search functions in vtkKdTree.
///
/// </remarks>
/// <seealso>
///
/// vtkKdTree
/// </seealso>
public class vtkKdTreePointLocator : vtkAbstractPointLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKdTreePointLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKdTreePointLocator()
	{
		MRClassNameKey = "class vtkKdTreePointLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdTreePointLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKdTreePointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTreePointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKdTreePointLocator New()
	{
		vtkKdTreePointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTreePointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKdTreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkKdTreePointLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKdTreePointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkKdTreePointLocator_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// See vtkLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void BuildLocator()
	{
		vtkKdTreePointLocator_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreePointLocator_FindClosestNPoints_02(HandleRef pThis, int N, IntPtr x, HandleRef result);

	/// <summary>
	/// Find the closest N points to a position. This returns the closest
	/// N points to a position. A faster method could be created that returned
	/// N close points to a position, but necessarily the exact N closest.
	/// The returned points are sorted from closest to farthest.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
	{
		vtkKdTreePointLocator_FindClosestNPoints_02(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTreePointLocator_FindClosestPoint_03(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a position x, return the id of the point closest to it. Alternative
	/// method requires separate x-y-z values.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override long FindClosestPoint(IntPtr x)
	{
		return vtkKdTreePointLocator_FindClosestPoint_03(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTreePointLocator_FindClosestPointWithinRadius_04(HandleRef pThis, double radius, IntPtr x, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point
	/// closest to the point in that radius.
	/// dist2 returns the squared distance to the point.
	/// </summary>
	public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
	{
		return vtkKdTreePointLocator_FindClosestPointWithinRadius_04(GetCppThis(), radius, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreePointLocator_FindPointsWithinRadius_05(HandleRef pThis, double R, IntPtr x, HandleRef result);

	/// <summary>
	/// Find all points within a specified radius R of position x.
	/// The result is not sorted in any specific manner.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
	{
		vtkKdTreePointLocator_FindPointsWithinRadius_05(GetCppThis(), R, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreePointLocator_ForceBuildLocator_06(HandleRef pThis);

	/// <summary>
	/// See vtkLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkKdTreePointLocator_ForceBuildLocator_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreePointLocator_FreeSearchStructure_07(HandleRef pThis);

	/// <summary>
	/// See vtkLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkKdTreePointLocator_FreeSearchStructure_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTreePointLocator_GenerateRepresentation_08(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// See vtkLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkKdTreePointLocator_GenerateRepresentation_08(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTreePointLocator_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKdTreePointLocator_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTreePointLocator_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKdTreePointLocator_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTreePointLocator_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKdTreePointLocator_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTreePointLocator_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKdTreePointLocator_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTreePointLocator_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKdTreePointLocator NewInstance()
	{
		vtkKdTreePointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTreePointLocator_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKdTreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTreePointLocator_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKdTreePointLocator SafeDownCast(vtkObjectBase o)
	{
		vtkKdTreePointLocator vtkKdTreePointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTreePointLocator_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKdTreePointLocator2 = (vtkKdTreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKdTreePointLocator2.Register(null);
			}
		}
		return vtkKdTreePointLocator2;
	}
}
