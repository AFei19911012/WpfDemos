using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGeoProjection
/// </summary>
/// <remarks>
///    Represent a projection from a sphere to a plane
///
///
/// This class uses the PROJ.4 library to represent geographic coordinate
/// projections.
/// </remarks>
public class vtkGeoProjection : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGeoProjection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGeoProjection()
	{
		MRClassNameKey = "class vtkGeoProjection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoProjection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGeoProjection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGeoProjection New()
	{
		vtkGeoProjection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoProjection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGeoProjection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGeoProjection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGeoProjection_ClearOptionalParameters_01(HandleRef pThis);

	/// <summary>
	/// Clear all optional parameters
	/// </summary>
	public void ClearOptionalParameters()
	{
		vtkGeoProjection_ClearOptionalParameters_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGeoProjection_GetCentralMeridian_02(HandleRef pThis);

	/// <summary>
	/// Set/get the longitude which corresponds to the central meridian of the projection.
	/// This defaults to 0, the Greenwich Meridian.
	/// </summary>
	public virtual double GetCentralMeridian()
	{
		return vtkGeoProjection_GetCentralMeridian_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_GetDescription_03(HandleRef pThis);

	/// <summary>
	/// Get the description of a projection.
	/// This will return nullptr if the projection name is invalid.
	/// </summary>
	public string GetDescription()
	{
		return Marshal.PtrToStringAnsi(vtkGeoProjection_GetDescription_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoProjection_GetIndex_04(HandleRef pThis);

	/// <summary>
	/// Return the index of the current projection's type in the list of all projection types.
	/// On error, this will return -1. On success, it returns a number in [0,GetNumberOfProjections()[.
	/// </summary>
	public int GetIndex()
	{
		return vtkGeoProjection_GetIndex_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_GetName_05(HandleRef pThis);

	/// <summary>
	/// Set/get the short name describing the projection you wish to use.
	/// This defaults to "latlong".
	/// To get a list of valid values, use the GetNumberOfProjections() and
	/// GetProjectionName(int) static methods.
	/// </summary>
	public virtual string GetName()
	{
		return Marshal.PtrToStringAnsi(vtkGeoProjection_GetName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeoProjection_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGeoProjection_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeoProjection_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGeoProjection_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoProjection_GetNumberOfOptionalParameters_08(HandleRef pThis);

	/// <summary>
	/// Return the number of optional parameters
	/// </summary>
	public int GetNumberOfOptionalParameters()
	{
		return vtkGeoProjection_GetNumberOfOptionalParameters_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoProjection_GetNumberOfProjections_09();

	/// <summary>
	/// Returns the number of projections that this class offers.
	/// </summary>
	public static int GetNumberOfProjections()
	{
		return vtkGeoProjection_GetNumberOfProjections_09();
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_GetOptionalParameterKey_10(HandleRef pThis, int index);

	/// <summary>
	/// Return the number of optional parameters
	/// </summary>
	public string GetOptionalParameterKey(int index)
	{
		return Marshal.PtrToStringAnsi(vtkGeoProjection_GetOptionalParameterKey_10(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_GetOptionalParameterValue_11(HandleRef pThis, int index);

	/// <summary>
	/// Return the number of optional parameters
	/// </summary>
	public string GetOptionalParameterValue(int index)
	{
		return Marshal.PtrToStringAnsi(vtkGeoProjection_GetOptionalParameterValue_11(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_GetPROJ4String_12(HandleRef pThis);

	/// <summary>
	/// Set/Get/Clear projection string in PROJ.4 format.
	/// This is a special case alternative to setting the projection name and
	/// specifying parameters.
	///
	/// \note If the PROJ4String is not empty, it supercedes the other parameters
	/// and is used explicitly to instantiate the `projPJ` projection object.
	/// </summary>
	public virtual string GetPROJ4String()
	{
		return Marshal.PtrToStringAnsi(vtkGeoProjection_GetPROJ4String_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_GetProjectionDescription_13(int projection);

	/// <summary>
	/// Returns a description of one of the projections supported by this class.
	/// @param projection the index of a projection, must be in [0,GetNumberOfProjections()[.
	/// </summary>
	public static string GetProjectionDescription(int projection)
	{
		return Marshal.PtrToStringAnsi(vtkGeoProjection_GetProjectionDescription_13(projection));
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_GetProjectionName_14(int projection);

	/// <summary>
	/// Returns the name of one of the projections supported by this class.
	/// You can pass these strings to SetName(char*).
	/// @param projection the index of a projection, must be in [0,GetNumberOfProjections()[.
	/// </summary>
	public static string GetProjectionName(int projection)
	{
		return Marshal.PtrToStringAnsi(vtkGeoProjection_GetProjectionName_14(projection));
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoProjection_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGeoProjection_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeoProjection_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGeoProjection_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGeoProjection NewInstance()
	{
		vtkGeoProjection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoProjection_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoProjection_RemoveOptionalParameter_19(HandleRef pThis, string arg0);

	/// <summary>
	/// Remove an optional parameter to the projection that will be computed
	/// </summary>
	public void RemoveOptionalParameter(string arg0)
	{
		vtkGeoProjection_RemoveOptionalParameter_19(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeoProjection_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGeoProjection SafeDownCast(vtkObjectBase o)
	{
		vtkGeoProjection vtkGeoProjection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeoProjection_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGeoProjection_SetCentralMeridian_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the longitude which corresponds to the central meridian of the projection.
	/// This defaults to 0, the Greenwich Meridian.
	/// </summary>
	public virtual void SetCentralMeridian(double _arg)
	{
		vtkGeoProjection_SetCentralMeridian_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoProjection_SetName_22(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the short name describing the projection you wish to use.
	/// This defaults to "latlong".
	/// To get a list of valid values, use the GetNumberOfProjections() and
	/// GetProjectionName(int) static methods.
	/// </summary>
	public virtual void SetName(string _arg)
	{
		vtkGeoProjection_SetName_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoProjection_SetOptionalParameter_23(HandleRef pThis, string key, string value);

	/// <summary>
	/// Add an optional parameter to the projection that will be computed or
	/// replace it if already present.
	/// </summary>
	public void SetOptionalParameter(string key, string value)
	{
		vtkGeoProjection_SetOptionalParameter_23(GetCppThis(), key, value);
	}

	[DllImport("Kitware.VTK.GeovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeoProjection_SetPROJ4String_24(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get/Clear projection string in PROJ.4 format.
	/// This is a special case alternative to setting the projection name and
	/// specifying parameters.
	///
	/// \note If the PROJ4String is not empty, it supercedes the other parameters
	/// and is used explicitly to instantiate the `projPJ` projection object.
	/// </summary>
	public virtual void SetPROJ4String(string _arg)
	{
		vtkGeoProjection_SetPROJ4String_24(GetCppThis(), _arg);
	}
}
