using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDEMReader
/// </summary>
/// <remarks>
///    read a digital elevation model (DEM) file
///
/// vtkDEMReader reads digital elevation files and creates image data.
/// Digital elevation files are produced by the
/// &lt;A HREF="http://www.usgs.gov"&gt;US Geological Survey&lt;/A&gt;.
/// A complete description of the DEM file is located at the USGS site.
/// The reader reads the entire dem file and create a vtkImageData that
/// contains a single scalar component that is the elevation in meters.
/// The spacing is also expressed in meters. A number of get methods
/// provide access to fields on the header.
/// </remarks>
public class vtkDEMReader : vtkImageAlgorithm
{
	/// <summary>
	/// Specify file name of Digital Elevation Model (DEM) file
	/// </summary>
	public enum REFERENCE_ELEVATION_BOUNDS_WrapperEnum
	{
		/// <summary>enum member</summary>
		REFERENCE_ELEVATION_BOUNDS = 1,
		/// <summary>enum member</summary>
		REFERENCE_SEA_LEVEL = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDEMReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDEMReader()
	{
		MRClassNameKey = "class vtkDEMReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDEMReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDEMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDEMReader New()
	{
		vtkDEMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDEMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDEMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDEMReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDEMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetAccuracyCode_01(HandleRef pThis);

	/// <summary>
	/// Accuracy code for elevations. 0=unknown accuracy
	/// </summary>
	public virtual int GetAccuracyCode()
	{
		return vtkDEMReader_GetAccuracyCode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetDEMLevel_02(HandleRef pThis);

	/// <summary>
	/// Code 1=DEM-1, 2=DEM_2, ...
	/// </summary>
	public virtual int GetDEMLevel()
	{
		return vtkDEMReader_GetDEMLevel_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_GetElevationBounds_03(HandleRef pThis);

	/// <summary>
	/// Minimum and maximum elevation for the DEM. The units in the file
	/// are in ElevationUnitOfMeasure. This class converts them to meters.
	/// </summary>
	public virtual float[] GetElevationBounds()
	{
		IntPtr intPtr = vtkDEMReader_GetElevationBounds_03(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDEMReader_GetElevationBounds_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Minimum and maximum elevation for the DEM. The units in the file
	/// are in ElevationUnitOfMeasure. This class converts them to meters.
	/// </summary>
	public virtual void GetElevationBounds(IntPtr data)
	{
		vtkDEMReader_GetElevationBounds_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetElevationPattern_05(HandleRef pThis);

	/// <summary>
	/// Code 1=regular, 2=random, reserved for future use
	/// </summary>
	public virtual int GetElevationPattern()
	{
		return vtkDEMReader_GetElevationPattern_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetElevationReference_06(HandleRef pThis);

	/// <summary>
	/// Specify the elevation origin to use. By default, the elevation origin
	/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
	/// level (i.e., a value of 0.0).
	/// </summary>
	public virtual int GetElevationReference()
	{
		return vtkDEMReader_GetElevationReference_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_GetElevationReferenceAsString_07(HandleRef pThis);

	/// <summary>
	/// Specify the elevation origin to use. By default, the elevation origin
	/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
	/// level (i.e., a value of 0.0).
	/// </summary>
	public string GetElevationReferenceAsString()
	{
		return Marshal.PtrToStringAnsi(vtkDEMReader_GetElevationReferenceAsString_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetElevationReferenceMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the elevation origin to use. By default, the elevation origin
	/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
	/// level (i.e., a value of 0.0).
	/// </summary>
	public virtual int GetElevationReferenceMaxValue()
	{
		return vtkDEMReader_GetElevationReferenceMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetElevationReferenceMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the elevation origin to use. By default, the elevation origin
	/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
	/// level (i.e., a value of 0.0).
	/// </summary>
	public virtual int GetElevationReferenceMinValue()
	{
		return vtkDEMReader_GetElevationReferenceMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetElevationUnitOfMeasure_10(HandleRef pThis);

	/// <summary>
	/// Defining unit of measure for elevation coordinates throughout
	/// the file. 1 = feet, 2 = meters
	/// </summary>
	public virtual int GetElevationUnitOfMeasure()
	{
		return vtkDEMReader_GetElevationUnitOfMeasure_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_GetFileName_11(HandleRef pThis);

	/// <summary>
	/// Specify file name of Digital Elevation Model (DEM) file
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDEMReader_GetFileName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetGroundSystem_12(HandleRef pThis);

	/// <summary>
	/// Ground planimetric reference system
	/// </summary>
	public virtual int GetGroundSystem()
	{
		return vtkDEMReader_GetGroundSystem_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetGroundZone_13(HandleRef pThis);

	/// <summary>
	/// Zone in ground planimetric reference system
	/// </summary>
	public virtual int GetGroundZone()
	{
		return vtkDEMReader_GetGroundZone_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDEMReader_GetLocalRotation_14(HandleRef pThis);

	/// <summary>
	/// Counterclockwise angle (in radians) from the primary axis of the planimetric
	/// reference to the primary axis of the DEM local reference system.
	/// IGNORED BY THIS IMPLEMENTATION.
	/// </summary>
	public virtual float GetLocalRotation()
	{
		return vtkDEMReader_GetLocalRotation_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_GetMapLabel_15(HandleRef pThis);

	/// <summary>
	/// An ASCII description of the map
	/// </summary>
	public virtual string GetMapLabel()
	{
		return Marshal.PtrToStringAnsi(vtkDEMReader_GetMapLabel_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDEMReader_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDEMReader_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDEMReader_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDEMReader_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetPlaneUnitOfMeasure_18(HandleRef pThis);

	/// <summary>
	/// Defining unit of measure for ground planimetric coordinates throughout
	/// the file. 0 = radians, 1 = feet, 2 = meters, 3 = arc-seconds.
	/// </summary>
	public virtual int GetPlaneUnitOfMeasure()
	{
		return vtkDEMReader_GetPlaneUnitOfMeasure_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_GetPolygonSize_19(HandleRef pThis);

	/// <summary>
	/// Number of sides in the polygon which defines the coverage of
	/// the DEM file. Set to 4.
	/// </summary>
	public virtual int GetPolygonSize()
	{
		return vtkDEMReader_GetPolygonSize_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_GetProfileDimension_20(HandleRef pThis);

	/// <summary>
	/// The number of rows and columns in the DEM.
	/// </summary>
	public virtual int[] GetProfileDimension()
	{
		IntPtr intPtr = vtkDEMReader_GetProfileDimension_20(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDEMReader_GetProfileDimension_21(HandleRef pThis, IntPtr data);

	/// <summary>
	/// The number of rows and columns in the DEM.
	/// </summary>
	public virtual void GetProfileDimension(IntPtr data)
	{
		vtkDEMReader_GetProfileDimension_21(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_GetProjectionParameters_22(HandleRef pThis);

	/// <summary>
	/// Map Projection parameters. All are zero.
	/// </summary>
	public virtual float[] GetProjectionParameters()
	{
		IntPtr intPtr = vtkDEMReader_GetProjectionParameters_22(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[5];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDEMReader_GetProjectionParameters_23(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Map Projection parameters. All are zero.
	/// </summary>
	public virtual void GetProjectionParameters(IntPtr data)
	{
		vtkDEMReader_GetProjectionParameters_23(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_GetSpatialResolution_24(HandleRef pThis);

	/// <summary>
	/// DEM spatial resolution for x,y,z. Values are expressed in units of resolution.
	/// Since elevations are read as integers, this permits fractional elevations.
	/// </summary>
	public virtual float[] GetSpatialResolution()
	{
		IntPtr intPtr = vtkDEMReader_GetSpatialResolution_24(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDEMReader_GetSpatialResolution_25(HandleRef pThis, IntPtr data);

	/// <summary>
	/// DEM spatial resolution for x,y,z. Values are expressed in units of resolution.
	/// Since elevations are read as integers, this permits fractional elevations.
	/// </summary>
	public virtual void GetSpatialResolution(IntPtr data)
	{
		vtkDEMReader_GetSpatialResolution_25(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_IsA_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDEMReader_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDEMReader_IsTypeOf_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDEMReader_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDEMReader NewInstance()
	{
		vtkDEMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDEMReader_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDEMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDEMReader_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDEMReader SafeDownCast(vtkObjectBase o)
	{
		vtkDEMReader vtkDEMReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDEMReader_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDEMReader2 = (vtkDEMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDEMReader2.Register(null);
			}
		}
		return vtkDEMReader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDEMReader_SetElevationReference_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the elevation origin to use. By default, the elevation origin
	/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
	/// level (i.e., a value of 0.0).
	/// </summary>
	public virtual void SetElevationReference(int _arg)
	{
		vtkDEMReader_SetElevationReference_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDEMReader_SetElevationReferenceToElevationBounds_32(HandleRef pThis);

	/// <summary>
	/// Specify the elevation origin to use. By default, the elevation origin
	/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
	/// level (i.e., a value of 0.0).
	/// </summary>
	public void SetElevationReferenceToElevationBounds()
	{
		vtkDEMReader_SetElevationReferenceToElevationBounds_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDEMReader_SetElevationReferenceToSeaLevel_33(HandleRef pThis);

	/// <summary>
	/// Specify the elevation origin to use. By default, the elevation origin
	/// is equal to ElevationBounds[0]. A more convenient origin is to use sea
	/// level (i.e., a value of 0.0).
	/// </summary>
	public void SetElevationReferenceToSeaLevel()
	{
		vtkDEMReader_SetElevationReferenceToSeaLevel_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDEMReader_SetFileName_34(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of Digital Elevation Model (DEM) file
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkDEMReader_SetFileName_34(GetCppThis(), _arg);
	}
}
