using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAreaLayout
/// </summary>
/// <remarks>
///    layout a vtkTree into a tree map
///
///
/// vtkAreaLayout assigns sector regions to each vertex in the tree,
/// creating a tree ring.  The data is added as a data array with four
/// components per tuple representing the location and size of the
/// sector using the format (StartAngle, EndAngle, innerRadius, outerRadius).
///
/// This algorithm relies on a helper class to perform the actual layout.
/// This helper class is a subclass of vtkAreaLayoutStrategy.
///
/// @par Thanks:
/// Thanks to Jason Shepherd from Sandia National Laboratories
/// for help developing this class.
/// </remarks>
public class vtkAreaLayout : vtkTreeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAreaLayout";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAreaLayout()
	{
		MRClassNameKey = "class vtkAreaLayout";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaLayout"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAreaLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAreaLayout New()
	{
		vtkAreaLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAreaLayout()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAreaLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayout_EdgeRoutingPointsOff_01(HandleRef pThis);

	/// <summary>
	/// Whether to output a second output tree with vertex locations
	/// appropriate for routing bundled edges. Default is on.
	/// </summary>
	public virtual void EdgeRoutingPointsOff()
	{
		vtkAreaLayout_EdgeRoutingPointsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayout_EdgeRoutingPointsOn_02(HandleRef pThis);

	/// <summary>
	/// Whether to output a second output tree with vertex locations
	/// appropriate for routing bundled edges. Default is on.
	/// </summary>
	public virtual void EdgeRoutingPointsOn()
	{
		vtkAreaLayout_EdgeRoutingPointsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaLayout_FindVertex_03(HandleRef pThis, IntPtr pnt);

	/// <summary>
	/// Get the vertex whose area contains the point, or return -1
	/// if no vertex area covers the point.
	/// </summary>
	public long FindVertex(IntPtr pnt)
	{
		return vtkAreaLayout_FindVertex_03(GetCppThis(), pnt);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaLayout_GetAreaArrayName_04(HandleRef pThis);

	/// <summary>
	/// The name for the array created for the area for each vertex.
	/// The rectangles are stored in a quadruple float array
	/// (startAngle, endAngle, innerRadius, outerRadius).
	/// For rectangular layouts, this is (minx, maxx, miny, maxy).
	/// </summary>
	public virtual string GetAreaArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAreaLayout_GetAreaArrayName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayout_GetBoundingArea_05(HandleRef pThis, long id, IntPtr sinfo);

	/// <summary>
	/// The bounding area information for a certain vertex id.
	/// </summary>
	public void GetBoundingArea(long id, IntPtr sinfo)
	{
		vtkAreaLayout_GetBoundingArea_05(GetCppThis(), id, sinfo);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAreaLayout_GetEdgeRoutingPoints_06(HandleRef pThis);

	/// <summary>
	/// Whether to output a second output tree with vertex locations
	/// appropriate for routing bundled edges. Default is on.
	/// </summary>
	public virtual bool GetEdgeRoutingPoints()
	{
		return (vtkAreaLayout_GetEdgeRoutingPoints_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaLayout_GetLayoutStrategy_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The strategy to use when laying out the tree map.
	/// </summary>
	public virtual vtkAreaLayoutStrategy GetLayoutStrategy()
	{
		vtkAreaLayoutStrategy vtkAreaLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaLayout_GetLayoutStrategy_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAreaLayoutStrategy2 = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAreaLayoutStrategy2.Register(null);
			}
		}
		return vtkAreaLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAreaLayout_GetMTime_08(HandleRef pThis);

	/// <summary>
	/// Get the modification time of the layout algorithm.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAreaLayout_GetMTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaLayout_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAreaLayout_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAreaLayout_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAreaLayout_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaLayout_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAreaLayout_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAreaLayout_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAreaLayout_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaLayout_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAreaLayout NewInstance()
	{
		vtkAreaLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaLayout_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAreaLayout_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAreaLayout SafeDownCast(vtkObjectBase o)
	{
		vtkAreaLayout vtkAreaLayout2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAreaLayout_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAreaLayout2 = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAreaLayout2.Register(null);
			}
		}
		return vtkAreaLayout2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayout_SetAreaArrayName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// The name for the array created for the area for each vertex.
	/// The rectangles are stored in a quadruple float array
	/// (startAngle, endAngle, innerRadius, outerRadius).
	/// For rectangular layouts, this is (minx, maxx, miny, maxy).
	/// </summary>
	public virtual void SetAreaArrayName(string _arg)
	{
		vtkAreaLayout_SetAreaArrayName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayout_SetEdgeRoutingPoints_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to output a second output tree with vertex locations
	/// appropriate for routing bundled edges. Default is on.
	/// </summary>
	public virtual void SetEdgeRoutingPoints(bool _arg)
	{
		vtkAreaLayout_SetEdgeRoutingPoints_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayout_SetLayoutStrategy_18(HandleRef pThis, HandleRef strategy);

	/// <summary>
	/// The strategy to use when laying out the tree map.
	/// </summary>
	public void SetLayoutStrategy(vtkAreaLayoutStrategy strategy)
	{
		vtkAreaLayout_SetLayoutStrategy_18(GetCppThis(), strategy?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAreaLayout_SetSizeArrayName_19(HandleRef pThis, string name);

	/// <summary>
	/// The array name to use for retrieving the relative size of each vertex.
	/// If this array is not found, use constant size for each vertex.
	/// </summary>
	public virtual void SetSizeArrayName(string name)
	{
		vtkAreaLayout_SetSizeArrayName_19(GetCppThis(), name);
	}
}
