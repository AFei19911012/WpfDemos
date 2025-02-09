using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSubdivisionFilter
/// </summary>
/// <remarks>
///    base class for subvision filters
///
/// vtkSubdivisionFilter is an abstract class that defines
/// the protocol for subdivision surface filters.
///
/// </remarks>
public class vtkSubdivisionFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSubdivisionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSubdivisionFilter()
	{
		MRClassNameKey = "class vtkSubdivisionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubdivisionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubdivisionFilter_CheckForTrianglesOff_01(HandleRef pThis);

	/// <summary>
	/// Set/get CheckForTriangles
	/// Should subdivision check that the dataset only contains triangles?
	/// Default is On (1).
	/// </summary>
	public virtual void CheckForTrianglesOff()
	{
		vtkSubdivisionFilter_CheckForTrianglesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubdivisionFilter_CheckForTrianglesOn_02(HandleRef pThis);

	/// <summary>
	/// Set/get CheckForTriangles
	/// Should subdivision check that the dataset only contains triangles?
	/// Default is On (1).
	/// </summary>
	public virtual void CheckForTrianglesOn()
	{
		vtkSubdivisionFilter_CheckForTrianglesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubdivisionFilter_GetCheckForTriangles_03(HandleRef pThis);

	/// <summary>
	/// Set/get CheckForTriangles
	/// Should subdivision check that the dataset only contains triangles?
	/// Default is On (1).
	/// </summary>
	public virtual int GetCheckForTriangles()
	{
		return vtkSubdivisionFilter_GetCheckForTriangles_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubdivisionFilter_GetCheckForTrianglesMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set/get CheckForTriangles
	/// Should subdivision check that the dataset only contains triangles?
	/// Default is On (1).
	/// </summary>
	public virtual int GetCheckForTrianglesMaxValue()
	{
		return vtkSubdivisionFilter_GetCheckForTrianglesMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubdivisionFilter_GetCheckForTrianglesMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set/get CheckForTriangles
	/// Should subdivision check that the dataset only contains triangles?
	/// Default is On (1).
	/// </summary>
	public virtual int GetCheckForTrianglesMinValue()
	{
		return vtkSubdivisionFilter_GetCheckForTrianglesMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSubdivisionFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSubdivisionFilter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSubdivisionFilter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSubdivisionFilter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubdivisionFilter_GetNumberOfSubdivisions_08(HandleRef pThis);

	/// <summary>
	/// Set/get the number of subdivisions.
	/// Default is 1.
	/// </summary>
	public virtual int GetNumberOfSubdivisions()
	{
		return vtkSubdivisionFilter_GetNumberOfSubdivisions_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubdivisionFilter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSubdivisionFilter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubdivisionFilter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSubdivisionFilter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubdivisionFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSubdivisionFilter NewInstance()
	{
		vtkSubdivisionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubdivisionFilter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubdivisionFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSubdivisionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSubdivisionFilter vtkSubdivisionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubdivisionFilter_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSubdivisionFilter2 = (vtkSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSubdivisionFilter2.Register(null);
			}
		}
		return vtkSubdivisionFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubdivisionFilter_SetCheckForTriangles_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get CheckForTriangles
	/// Should subdivision check that the dataset only contains triangles?
	/// Default is On (1).
	/// </summary>
	public virtual void SetCheckForTriangles(int _arg)
	{
		vtkSubdivisionFilter_SetCheckForTriangles_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubdivisionFilter_SetNumberOfSubdivisions_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the number of subdivisions.
	/// Default is 1.
	/// </summary>
	public virtual void SetNumberOfSubdivisions(int _arg)
	{
		vtkSubdivisionFilter_SetNumberOfSubdivisions_14(GetCppThis(), _arg);
	}
}
