using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTriangleFilter
/// </summary>
/// <remarks>
///    convert input polygons and strips to triangles
///
/// vtkTriangleFilter generates triangles from input polygons and triangle
/// strips.  It also generates line segments from polylines unless PassLines
/// is off, and generates individual vertex cells from vtkVertex point lists
/// unless PassVerts is off.
/// </remarks>
public class vtkTriangleFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTriangleFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTriangleFilter()
	{
		MRClassNameKey = "class vtkTriangleFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangleFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTriangleFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangleFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTriangleFilter New()
	{
		vtkTriangleFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangleFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTriangleFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTriangleFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkTriangleFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTriangleFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTriangleFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTriangleFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangleFilter_GetPassLines_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off passing lines through filter (default: on).
	/// If this is on, then the input polylines will be broken
	/// into line segments.  If it is off, then the input lines
	/// will be ignored and the output will have no lines.
	/// </summary>
	public virtual int GetPassLines()
	{
		return vtkTriangleFilter_GetPassLines_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangleFilter_GetPassVerts_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off passing vertices through filter (default: on).
	/// If this is on, then the input vertex cells will be broken
	/// into individual vertex cells (one point per cell).  If it
	/// is off, the input vertex cells will be ignored.
	/// </summary>
	public virtual int GetPassVerts()
	{
		return vtkTriangleFilter_GetPassVerts_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTriangleFilter_GetTolerance_05(HandleRef pThis);

	/// <summary>
	/// Optionally specify the polygon triangulation tolerance to use.  This
	/// simply passes the tolerance to the internal vtkPolygon::Tolerance used
	/// for triangulation of polygons.  This is for advanced usage, and
	/// generally does not need to be set unless tessellation of n-sided
	/// polygons with n&gt;4 is required, and special accuracy requirements are
	/// needed.  Note that by default if a value &lt;=0 is specified, then the
	/// default vtkPolygon::Tolerance is used.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkTriangleFilter_GetTolerance_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangleFilter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTriangleFilter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangleFilter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTriangleFilter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangleFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTriangleFilter NewInstance()
	{
		vtkTriangleFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangleFilter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangleFilter_PassLinesOff_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off passing lines through filter (default: on).
	/// If this is on, then the input polylines will be broken
	/// into line segments.  If it is off, then the input lines
	/// will be ignored and the output will have no lines.
	/// </summary>
	public virtual void PassLinesOff()
	{
		vtkTriangleFilter_PassLinesOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangleFilter_PassLinesOn_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off passing lines through filter (default: on).
	/// If this is on, then the input polylines will be broken
	/// into line segments.  If it is off, then the input lines
	/// will be ignored and the output will have no lines.
	/// </summary>
	public virtual void PassLinesOn()
	{
		vtkTriangleFilter_PassLinesOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangleFilter_PassVertsOff_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off passing vertices through filter (default: on).
	/// If this is on, then the input vertex cells will be broken
	/// into individual vertex cells (one point per cell).  If it
	/// is off, the input vertex cells will be ignored.
	/// </summary>
	public virtual void PassVertsOff()
	{
		vtkTriangleFilter_PassVertsOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangleFilter_PassVertsOn_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off passing vertices through filter (default: on).
	/// If this is on, then the input vertex cells will be broken
	/// into individual vertex cells (one point per cell).  If it
	/// is off, the input vertex cells will be ignored.
	/// </summary>
	public virtual void PassVertsOn()
	{
		vtkTriangleFilter_PassVertsOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangleFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTriangleFilter SafeDownCast(vtkObjectBase o)
	{
		vtkTriangleFilter vtkTriangleFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangleFilter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTriangleFilter2 = (vtkTriangleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTriangleFilter2.Register(null);
			}
		}
		return vtkTriangleFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangleFilter_SetPassLines_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off passing lines through filter (default: on).
	/// If this is on, then the input polylines will be broken
	/// into line segments.  If it is off, then the input lines
	/// will be ignored and the output will have no lines.
	/// </summary>
	public virtual void SetPassLines(int _arg)
	{
		vtkTriangleFilter_SetPassLines_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangleFilter_SetPassVerts_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off passing vertices through filter (default: on).
	/// If this is on, then the input vertex cells will be broken
	/// into individual vertex cells (one point per cell).  If it
	/// is off, the input vertex cells will be ignored.
	/// </summary>
	public virtual void SetPassVerts(int _arg)
	{
		vtkTriangleFilter_SetPassVerts_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangleFilter_SetTolerance_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Optionally specify the polygon triangulation tolerance to use.  This
	/// simply passes the tolerance to the internal vtkPolygon::Tolerance used
	/// for triangulation of polygons.  This is for advanced usage, and
	/// generally does not need to be set unless tessellation of n-sided
	/// polygons with n&gt;4 is required, and special accuracy requirements are
	/// needed.  Note that by default if a value &lt;=0 is specified, then the
	/// default vtkPolygon::Tolerance is used.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkTriangleFilter_SetTolerance_17(GetCppThis(), _arg);
	}
}
