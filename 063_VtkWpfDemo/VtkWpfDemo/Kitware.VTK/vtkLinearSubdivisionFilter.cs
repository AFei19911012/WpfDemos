using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLinearSubdivisionFilter
/// </summary>
/// <remarks>
///    generate a subdivision surface using the Linear Scheme
///
/// vtkLinearSubdivisionFilter is a filter that generates output by
/// subdividing its input polydata. Each subdivision iteration create 4
/// new triangles for each triangle in the polydata.
///
/// @par Thanks:
/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
/// from the National Center for Research Resources.
///
/// </remarks>
/// <seealso>
///
/// vtkInterpolatingSubdivisionFilter vtkButterflySubdivisionFilter
/// </seealso>
public class vtkLinearSubdivisionFilter : vtkInterpolatingSubdivisionFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLinearSubdivisionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLinearSubdivisionFilter()
	{
		MRClassNameKey = "class vtkLinearSubdivisionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearSubdivisionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLinearSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearSubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static vtkLinearSubdivisionFilter New()
	{
		vtkLinearSubdivisionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearSubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public vtkLinearSubdivisionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLinearSubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkLinearSubdivisionFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLinearSubdivisionFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLinearSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearSubdivisionFilter_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLinearSubdivisionFilter_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearSubdivisionFilter_IsTypeOf_04(string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLinearSubdivisionFilter_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearSubdivisionFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new vtkLinearSubdivisionFilter NewInstance()
	{
		vtkLinearSubdivisionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearSubdivisionFilter_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearSubdivisionFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static vtkLinearSubdivisionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkLinearSubdivisionFilter vtkLinearSubdivisionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearSubdivisionFilter_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinearSubdivisionFilter2 = (vtkLinearSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinearSubdivisionFilter2.Register(null);
			}
		}
		return vtkLinearSubdivisionFilter2;
	}
}
