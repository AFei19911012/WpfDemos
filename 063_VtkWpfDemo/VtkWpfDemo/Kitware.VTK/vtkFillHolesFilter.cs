using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFillHolesFilter
/// </summary>
/// <remarks>
///    identify and fill holes in meshes
///
/// vtkFillHolesFilter is a filter that identifies and fills holes in
/// input vtkPolyData meshes. Holes are identified by locating
/// boundary edges, linking them together into loops, and then
/// triangulating the resulting loops. Note that you can specify
/// an approximate limit to the size of the hole that can be filled.
///
/// @warning
/// Note that any mesh with boundary edges by definition has a
/// topological hole. This even includes a reactangular grid
/// (e.g., the output of vtkPlaneSource). In such situations, if
/// the outer hole is filled, retriangulation of the hole will cause
/// geometric overlap of the mesh. This can be prevented by using
/// the hole size instance variable to prevent the larger holes
/// from being triangulated.
///
/// @warning
/// Note this filter only operates on polygons and triangle strips.
/// Vertices and polylines are passed through untouched.
/// </remarks>
public class vtkFillHolesFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFillHolesFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFillHolesFilter()
	{
		MRClassNameKey = "class vtkFillHolesFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFillHolesFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFillHolesFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFillHolesFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new static vtkFillHolesFilter New()
	{
		vtkFillHolesFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFillHolesFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFillHolesFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public vtkFillHolesFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFillHolesFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkFillHolesFilter_GetHoleSize_01(HandleRef pThis);

	/// <summary>
	/// Specify the maximum hole size to fill. This is represented as a radius
	/// to the bounding circumsphere containing the hole.  Note that this is an
	/// approximate area; the actual area cannot be computed without first
	/// triangulating the hole.
	/// </summary>
	public virtual double GetHoleSize()
	{
		return vtkFillHolesFilter_GetHoleSize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFillHolesFilter_GetHoleSizeMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Specify the maximum hole size to fill. This is represented as a radius
	/// to the bounding circumsphere containing the hole.  Note that this is an
	/// approximate area; the actual area cannot be computed without first
	/// triangulating the hole.
	/// </summary>
	public virtual double GetHoleSizeMaxValue()
	{
		return vtkFillHolesFilter_GetHoleSizeMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFillHolesFilter_GetHoleSizeMinValue_03(HandleRef pThis);

	/// <summary>
	/// Specify the maximum hole size to fill. This is represented as a radius
	/// to the bounding circumsphere containing the hole.  Note that this is an
	/// approximate area; the actual area cannot be computed without first
	/// triangulating the hole.
	/// </summary>
	public virtual double GetHoleSizeMinValue()
	{
		return vtkFillHolesFilter_GetHoleSizeMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFillHolesFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFillHolesFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFillHolesFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFillHolesFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFillHolesFilter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFillHolesFilter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFillHolesFilter_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFillHolesFilter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFillHolesFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new vtkFillHolesFilter NewInstance()
	{
		vtkFillHolesFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFillHolesFilter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFillHolesFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFillHolesFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new static vtkFillHolesFilter SafeDownCast(vtkObjectBase o)
	{
		vtkFillHolesFilter vtkFillHolesFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFillHolesFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFillHolesFilter2 = (vtkFillHolesFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFillHolesFilter2.Register(null);
			}
		}
		return vtkFillHolesFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFillHolesFilter_SetHoleSize_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the maximum hole size to fill. This is represented as a radius
	/// to the bounding circumsphere containing the hole.  Note that this is an
	/// approximate area; the actual area cannot be computed without first
	/// triangulating the hole.
	/// </summary>
	public virtual void SetHoleSize(double _arg)
	{
		vtkFillHolesFilter_SetHoleSize_11(GetCppThis(), _arg);
	}
}
