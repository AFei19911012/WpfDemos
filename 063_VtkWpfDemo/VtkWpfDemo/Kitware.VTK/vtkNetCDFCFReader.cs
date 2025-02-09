using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNetCDFCFReader
///
///
///
/// Reads netCDF files that follow the CF convention.  Details on this convention
/// can be found at &lt;http://cf-pcmdi.llnl.gov/&gt;.
///
/// </summary>
public class vtkNetCDFCFReader : vtkNetCDFReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFCFReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNetCDFCFReader()
	{
		MRClassNameKey = "class vtkNetCDFCFReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFCFReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNetCDFCFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFCFReader New()
	{
		vtkNetCDFCFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFCFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFCFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNetCDFCFReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNetCDFCFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCFReader_CanReadFile_01(string filename);

	/// <summary>
	/// Returns true if the given file can be read.
	/// </summary>
	public static int CanReadFile(string filename)
	{
		return vtkNetCDFCFReader_CanReadFile_01(filename);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFCFReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNetCDFCFReader_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFCFReader_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNetCDFCFReader_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCFReader_GetOutputType_04(HandleRef pThis);

	/// <summary>
	/// Set/get the data type of the output.  The index used is taken from the list
	/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
	/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
	/// addition you can set the type to -1 (the default), and this reader will
	/// pick the data type best suited for the dimensions being read.
	/// </summary>
	public virtual int GetOutputType()
	{
		return vtkNetCDFCFReader_GetOutputType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCFReader_GetSphericalCoordinates_05(HandleRef pThis);

	/// <summary>
	/// If on (the default), then 3D data with latitude/longitude dimensions
	/// will be read in as curvilinear data shaped like spherical coordinates.
	/// If false, then the data will always be read in Cartesian coordinates.
	/// </summary>
	public virtual int GetSphericalCoordinates()
	{
		return vtkNetCDFCFReader_GetSphericalCoordinates_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNetCDFCFReader_GetVerticalBias_06(HandleRef pThis);

	/// <summary>
	/// The scale and bias of the vertical component of spherical coordinates.  It
	/// is common to write the vertical component with respect to something other
	/// than the center of the sphere (for example, the surface).  In this case, it
	/// might be necessary to scale and/or bias the vertical height.  The height
	/// will become height*scale + bias.  Keep in mind that if the positive
	/// attribute of the vertical dimension is down, then the height is negated.
	/// By default the scale is 1 and the bias is 0 (that is, no change).  The
	/// scaling will be adjusted if it results in invalid (negative) vertical
	/// values.
	/// </summary>
	public virtual double GetVerticalBias()
	{
		return vtkNetCDFCFReader_GetVerticalBias_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNetCDFCFReader_GetVerticalScale_07(HandleRef pThis);

	/// <summary>
	/// The scale and bias of the vertical component of spherical coordinates.  It
	/// is common to write the vertical component with respect to something other
	/// than the center of the sphere (for example, the surface).  In this case, it
	/// might be necessary to scale and/or bias the vertical height.  The height
	/// will become height*scale + bias.  Keep in mind that if the positive
	/// attribute of the vertical dimension is down, then the height is negated.
	/// By default the scale is 1 and the bias is 0 (that is, no change).  The
	/// scaling will be adjusted if it results in invalid (negative) vertical
	/// values.
	/// </summary>
	public virtual double GetVerticalScale()
	{
		return vtkNetCDFCFReader_GetVerticalScale_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCFReader_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNetCDFCFReader_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCFReader_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNetCDFCFReader_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCFReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNetCDFCFReader NewInstance()
	{
		vtkNetCDFCFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFCFReader_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFCFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCFReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFCFReader SafeDownCast(vtkObjectBase o)
	{
		vtkNetCDFCFReader vtkNetCDFCFReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFCFReader_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNetCDFCFReader2 = (vtkNetCDFCFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNetCDFCFReader2.Register(null);
			}
		}
		return vtkNetCDFCFReader2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SetOutputType_13(HandleRef pThis, int type);

	/// <summary>
	/// Set/get the data type of the output.  The index used is taken from the list
	/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
	/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
	/// addition you can set the type to -1 (the default), and this reader will
	/// pick the data type best suited for the dimensions being read.
	/// </summary>
	public virtual void SetOutputType(int type)
	{
		vtkNetCDFCFReader_SetOutputType_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SetOutputTypeToAutomatic_14(HandleRef pThis);

	/// <summary>
	/// Set/get the data type of the output.  The index used is taken from the list
	/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
	/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
	/// addition you can set the type to -1 (the default), and this reader will
	/// pick the data type best suited for the dimensions being read.
	/// </summary>
	public void SetOutputTypeToAutomatic()
	{
		vtkNetCDFCFReader_SetOutputTypeToAutomatic_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SetOutputTypeToImage_15(HandleRef pThis);

	/// <summary>
	/// Set/get the data type of the output.  The index used is taken from the list
	/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
	/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
	/// addition you can set the type to -1 (the default), and this reader will
	/// pick the data type best suited for the dimensions being read.
	/// </summary>
	public void SetOutputTypeToImage()
	{
		vtkNetCDFCFReader_SetOutputTypeToImage_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SetOutputTypeToRectilinear_16(HandleRef pThis);

	/// <summary>
	/// Set/get the data type of the output.  The index used is taken from the list
	/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
	/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
	/// addition you can set the type to -1 (the default), and this reader will
	/// pick the data type best suited for the dimensions being read.
	/// </summary>
	public void SetOutputTypeToRectilinear()
	{
		vtkNetCDFCFReader_SetOutputTypeToRectilinear_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SetOutputTypeToStructured_17(HandleRef pThis);

	/// <summary>
	/// Set/get the data type of the output.  The index used is taken from the list
	/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
	/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
	/// addition you can set the type to -1 (the default), and this reader will
	/// pick the data type best suited for the dimensions being read.
	/// </summary>
	public void SetOutputTypeToStructured()
	{
		vtkNetCDFCFReader_SetOutputTypeToStructured_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SetOutputTypeToUnstructured_18(HandleRef pThis);

	/// <summary>
	/// Set/get the data type of the output.  The index used is taken from the list
	/// of VTK data types in vtkType.h.  Valid types are VTK_IMAGE_DATA,
	/// VTK_RECTILINEAR_GRID, VTK_STRUCTURED_GRID, and VTK_UNSTRUCTURED_GRID.  In
	/// addition you can set the type to -1 (the default), and this reader will
	/// pick the data type best suited for the dimensions being read.
	/// </summary>
	public void SetOutputTypeToUnstructured()
	{
		vtkNetCDFCFReader_SetOutputTypeToUnstructured_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SetSphericalCoordinates_19(HandleRef pThis, int _arg);

	/// <summary>
	/// If on (the default), then 3D data with latitude/longitude dimensions
	/// will be read in as curvilinear data shaped like spherical coordinates.
	/// If false, then the data will always be read in Cartesian coordinates.
	/// </summary>
	public virtual void SetSphericalCoordinates(int _arg)
	{
		vtkNetCDFCFReader_SetSphericalCoordinates_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SetVerticalBias_20(HandleRef pThis, double _arg);

	/// <summary>
	/// The scale and bias of the vertical component of spherical coordinates.  It
	/// is common to write the vertical component with respect to something other
	/// than the center of the sphere (for example, the surface).  In this case, it
	/// might be necessary to scale and/or bias the vertical height.  The height
	/// will become height*scale + bias.  Keep in mind that if the positive
	/// attribute of the vertical dimension is down, then the height is negated.
	/// By default the scale is 1 and the bias is 0 (that is, no change).  The
	/// scaling will be adjusted if it results in invalid (negative) vertical
	/// values.
	/// </summary>
	public virtual void SetVerticalBias(double _arg)
	{
		vtkNetCDFCFReader_SetVerticalBias_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SetVerticalScale_21(HandleRef pThis, double _arg);

	/// <summary>
	/// The scale and bias of the vertical component of spherical coordinates.  It
	/// is common to write the vertical component with respect to something other
	/// than the center of the sphere (for example, the surface).  In this case, it
	/// might be necessary to scale and/or bias the vertical height.  The height
	/// will become height*scale + bias.  Keep in mind that if the positive
	/// attribute of the vertical dimension is down, then the height is negated.
	/// By default the scale is 1 and the bias is 0 (that is, no change).  The
	/// scaling will be adjusted if it results in invalid (negative) vertical
	/// values.
	/// </summary>
	public virtual void SetVerticalScale(double _arg)
	{
		vtkNetCDFCFReader_SetVerticalScale_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SphericalCoordinatesOff_22(HandleRef pThis);

	/// <summary>
	/// If on (the default), then 3D data with latitude/longitude dimensions
	/// will be read in as curvilinear data shaped like spherical coordinates.
	/// If false, then the data will always be read in Cartesian coordinates.
	/// </summary>
	public virtual void SphericalCoordinatesOff()
	{
		vtkNetCDFCFReader_SphericalCoordinatesOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFReader_SphericalCoordinatesOn_23(HandleRef pThis);

	/// <summary>
	/// If on (the default), then 3D data with latitude/longitude dimensions
	/// will be read in as curvilinear data shaped like spherical coordinates.
	/// If false, then the data will always be read in Cartesian coordinates.
	/// </summary>
	public virtual void SphericalCoordinatesOn()
	{
		vtkNetCDFCFReader_SphericalCoordinatesOn_23(GetCppThis());
	}
}
