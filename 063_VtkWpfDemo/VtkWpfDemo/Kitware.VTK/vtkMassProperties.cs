using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMassProperties
/// </summary>
/// <remarks>
///    estimate volume, area, shape index of triangle mesh
///
/// vtkMassProperties estimates the volume, the surface area, and the
/// normalized shape index of a triangle mesh.  The algorithm
/// implemented here is based on the discrete form of the divergence
/// theorem.  The general assumption here is that the model is of
/// closed surface.  For more details see the following reference
/// (Alyassin A.M. et al, "Evaluation of new algorithms for the
/// interactive measurement of surface area and volume", Med Phys 21(6)
/// 1994.).
///
/// @warning
/// Currently only triangles are processed. Use vtkTriangleFilter to convert
/// any strips or polygons to triangles. If multiple closed objects are
/// defined consider using vtkMultiObjectMassProperties. Alternatively,
/// vtkPolyDataConnectivityFilter can be used to extract connected regions
/// (i.e., objects) one at a time, and then each object can be processed by
/// this filter.
///
/// </remarks>
/// <seealso>
///
/// vtkTriangleFilter vtkMultiObjectMassProperties
/// </seealso>
public class vtkMassProperties : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMassProperties";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMassProperties()
	{
		MRClassNameKey = "class vtkMassProperties";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMassProperties"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMassProperties(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMassProperties_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Constructs with initial values of zero.
	/// </summary>
	public new static vtkMassProperties New()
	{
		vtkMassProperties result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMassProperties_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMassProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Constructs with initial values of zero.
	/// </summary>
	public vtkMassProperties()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMassProperties_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkMassProperties_GetKx_01(HandleRef pThis);

	/// <summary>
	/// Compute and return the weighting factors for the maximum unit
	/// normal component (MUNC).
	/// </summary>
	public double GetKx()
	{
		return vtkMassProperties_GetKx_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetKy_02(HandleRef pThis);

	/// <summary>
	/// Compute and return the weighting factors for the maximum unit
	/// normal component (MUNC).
	/// </summary>
	public double GetKy()
	{
		return vtkMassProperties_GetKy_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetKz_03(HandleRef pThis);

	/// <summary>
	/// Compute and return the weighting factors for the maximum unit
	/// normal component (MUNC).
	/// </summary>
	public double GetKz()
	{
		return vtkMassProperties_GetKz_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetMaxCellArea_04(HandleRef pThis);

	/// <summary>
	/// Compute and return the max cell area.
	/// </summary>
	public double GetMaxCellArea()
	{
		return vtkMassProperties_GetMaxCellArea_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetMinCellArea_05(HandleRef pThis);

	/// <summary>
	/// Compute and return the min cell area.
	/// </summary>
	public double GetMinCellArea()
	{
		return vtkMassProperties_GetMinCellArea_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetNormalizedShapeIndex_06(HandleRef pThis);

	/// <summary>
	/// Compute and return the normalized shape index. This characterizes the
	/// deviation of the shape of an object from a sphere. A sphere's NSI
	/// is one. This number is always &gt;= 1.0.
	/// </summary>
	public double GetNormalizedShapeIndex()
	{
		return vtkMassProperties_GetNormalizedShapeIndex_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMassProperties_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Constructs with initial values of zero.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMassProperties_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMassProperties_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Constructs with initial values of zero.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMassProperties_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetSurfaceArea_09(HandleRef pThis);

	/// <summary>
	/// Compute and return the area.
	/// </summary>
	public double GetSurfaceArea()
	{
		return vtkMassProperties_GetSurfaceArea_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetVolume_10(HandleRef pThis);

	/// <summary>
	/// Compute and return the volume.
	/// </summary>
	public double GetVolume()
	{
		return vtkMassProperties_GetVolume_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetVolumeProjected_11(HandleRef pThis);

	/// <summary>
	/// Compute and return the projected volume.
	/// Typically you should compare this volume to the value returned by GetVolume
	/// if you get an error (GetVolume()-GetVolumeProjected())*10000 that is greater
	/// than GetVolume() this should identify a problem:
	/// * Either the polydata is not closed
	/// * Or the polydata contains triangle that are flipped
	/// </summary>
	public double GetVolumeProjected()
	{
		return vtkMassProperties_GetVolumeProjected_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetVolumeX_12(HandleRef pThis);

	/// <summary>
	/// Compute and return the volume projected on to each axis aligned plane.
	/// </summary>
	public double GetVolumeX()
	{
		return vtkMassProperties_GetVolumeX_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetVolumeY_13(HandleRef pThis);

	/// <summary>
	/// Compute and return the volume projected on to each axis aligned plane.
	/// </summary>
	public double GetVolumeY()
	{
		return vtkMassProperties_GetVolumeY_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMassProperties_GetVolumeZ_14(HandleRef pThis);

	/// <summary>
	/// Compute and return the volume projected on to each axis aligned plane.
	/// </summary>
	public double GetVolumeZ()
	{
		return vtkMassProperties_GetVolumeZ_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMassProperties_IsA_15(HandleRef pThis, string type);

	/// <summary>
	/// Constructs with initial values of zero.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMassProperties_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMassProperties_IsTypeOf_16(string type);

	/// <summary>
	/// Constructs with initial values of zero.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMassProperties_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMassProperties_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Constructs with initial values of zero.
	/// </summary>
	public new vtkMassProperties NewInstance()
	{
		vtkMassProperties result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMassProperties_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMassProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMassProperties_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Constructs with initial values of zero.
	/// </summary>
	public new static vtkMassProperties SafeDownCast(vtkObjectBase o)
	{
		vtkMassProperties vtkMassProperties2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMassProperties_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMassProperties2 = (vtkMassProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMassProperties2.Register(null);
			}
		}
		return vtkMassProperties2;
	}
}
