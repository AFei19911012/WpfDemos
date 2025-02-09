using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGeoTransform
/// </summary>
/// <remarks>
///    A transformation between two geographic coordinate systems
///
/// This class takes two geographic projections and transforms point
/// coordinates between them.
/// </remarks>
public class vtkGeoTransform : vtkAbstractTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGeoTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGeoTransform()
	{
		MRClassNameKey = "class vtkGeoTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGeoTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGeoTransform New()
	{
		vtkGeoTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeoTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGeoTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGeoTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoTransform_ComputeUTMZone_01(double lon, double lat);

	/// <summary>
	/// Computes Universal Transverse Mercator (UTM) zone given the
	/// longitude and latitude of the point.
	/// It correctly computes the zones in the two exception areas.
	/// It returns an integer between 1 and 60 for valid long lat, or 0 otherwise.
	///
	/// </summary>
	public static int ComputeUTMZone(double lon, double lat)
	{
		return vtkGeoTransform_ComputeUTMZone_01(lon, lat);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoTransform_ComputeUTMZone_02(IntPtr lonlat);

	/// <summary>
	/// Computes Universal Transverse Mercator (UTM) zone given the
	/// longitude and latitude of the point.
	/// It correctly computes the zones in the two exception areas.
	/// It returns an integer between 1 and 60 for valid long lat, or 0 otherwise.
	///
	/// </summary>
	public static int ComputeUTMZone(IntPtr lonlat)
	{
		return vtkGeoTransform_ComputeUTMZone_02(lonlat);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoTransform_GetDestinationProjection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The target geographic projection.
	/// </summary>
	public virtual vtkGeoProjection GetDestinationProjection()
	{
		vtkGeoProjection vtkGeoProjection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoTransform_GetDestinationProjection_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGeoProjection2 = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGeoProjection2.Register(null);
			}
		}
		return vtkGeoProjection2;
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeoTransform_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGeoTransform_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeoTransform_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGeoTransform_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoTransform_GetSourceProjection_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The source geographic projection.
	/// </summary>
	public virtual vtkGeoProjection GetSourceProjection()
	{
		vtkGeoProjection vtkGeoProjection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoTransform_GetSourceProjection_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGeoProjection2 = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGeoProjection2.Register(null);
			}
		}
		return vtkGeoProjection2;
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoTransform_InternalTransformPoint_07(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// This will calculate the transformation without calling Update.
	/// Meant for use only within other VTK classes.
	/// </summary>
	public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkGeoTransform_InternalTransformPoint_07(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoTransform_Inverse_08(HandleRef pThis);

	/// <summary>
	/// Invert the transformation.
	/// </summary>
	public override void Inverse()
	{
		vtkGeoTransform_Inverse_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoTransform_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGeoTransform_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoTransform_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGeoTransform_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoTransform_MakeTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make another transform of the same type.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoTransform_MakeTransform_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoTransform_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGeoTransform NewInstance()
	{
		vtkGeoTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoTransform_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeoTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoTransform_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGeoTransform SafeDownCast(vtkObjectBase o)
	{
		vtkGeoTransform vtkGeoTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoTransform_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGeoTransform2 = (vtkGeoTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGeoTransform2.Register(null);
			}
		}
		return vtkGeoTransform2;
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoTransform_SetDestinationProjection_15(HandleRef pThis, HandleRef dest);

	/// <summary>
	/// The target geographic projection.
	/// </summary>
	public void SetDestinationProjection(vtkGeoProjection dest)
	{
		vtkGeoTransform_SetDestinationProjection_15(GetCppThis(), dest?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoTransform_SetSourceProjection_16(HandleRef pThis, HandleRef source);

	/// <summary>
	/// The source geographic projection.
	/// </summary>
	public void SetSourceProjection(vtkGeoProjection source)
	{
		vtkGeoTransform_SetSourceProjection_16(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoTransform_TransformPoints_17(HandleRef pThis, HandleRef src, HandleRef dst);

	/// <summary>
	/// Transform many points at once.
	/// </summary>
	public override void TransformPoints(vtkPoints src, vtkPoints dst)
	{
		vtkGeoTransform_TransformPoints_17(GetCppThis(), src?.GetCppThis() ?? default(HandleRef), dst?.GetCppThis() ?? default(HandleRef));
	}
}
