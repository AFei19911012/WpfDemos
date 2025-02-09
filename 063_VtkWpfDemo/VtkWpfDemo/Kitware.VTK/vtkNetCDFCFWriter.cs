using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNetCDFCFWriter
///
/// Writes netCDF files that follow the CF convention.  Details on this convention
/// can be found at &lt;http://cfconventions.org/&gt;
/// </summary>
public class vtkNetCDFCFWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFCFWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNetCDFCFWriter()
	{
		MRClassNameKey = "class vtkNetCDFCFWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFCFWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNetCDFCFWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCFWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFCFWriter New()
	{
		vtkNetCDFCFWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFCFWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFCFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNetCDFCFWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNetCDFCFWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkNetCDFCFWriter_AddGridMappingAttribute_01(HandleRef pThis, string name, string value);

	/// <summary>
	/// Add/clear attributes that define the grid mapping (or the coordinate
	/// reference system (CRS))
	///
	/// \verbatim
	/// To obtain the correct CF conventions attribute names and values
	/// when knowing the EPSG code use projinfo &lt;epsg_code&gt; This will
	/// print the WKT string. From that you can get the attribute names
	/// and values you need for CF convention.. The WKT attribute names
	/// are fairly close to CF convention attribute names.  The following
	/// link also helps with the conversion.
	/// &lt;a
	/// href="https://github.com/cf-convention/cf-conventions/wiki/Mapping-from-CF-Grid-Mapping-Attributes-to-CRS-WKT-Elements"&gt;CF
	/// Grid Mapping to WKT&lt;/a&gt; See also &lt;a
	/// href="http://cfconventions.org/Data/cf-conventions/cf-conventions-1.9/cf-conventions.html#appendix-grid-mappings"&gt;CF
	/// Grid Mapping&lt;/a&gt; for the attributes needed for each projection.
	/// \endverbatim
	/// </summary>
	public void AddGridMappingAttribute(string name, string value)
	{
		vtkNetCDFCFWriter_AddGridMappingAttribute_01(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFWriter_AddGridMappingAttribute_02(HandleRef pThis, string name, double value);

	/// <summary>
	/// Add/clear attributes that define the grid mapping (or the coordinate
	/// reference system (CRS))
	///
	/// \verbatim
	/// To obtain the correct CF conventions attribute names and values
	/// when knowing the EPSG code use projinfo &lt;epsg_code&gt; This will
	/// print the WKT string. From that you can get the attribute names
	/// and values you need for CF convention.. The WKT attribute names
	/// are fairly close to CF convention attribute names.  The following
	/// link also helps with the conversion.
	/// &lt;a
	/// href="https://github.com/cf-convention/cf-conventions/wiki/Mapping-from-CF-Grid-Mapping-Attributes-to-CRS-WKT-Elements"&gt;CF
	/// Grid Mapping to WKT&lt;/a&gt; See also &lt;a
	/// href="http://cfconventions.org/Data/cf-conventions/cf-conventions-1.9/cf-conventions.html#appendix-grid-mappings"&gt;CF
	/// Grid Mapping&lt;/a&gt; for the attributes needed for each projection.
	/// \endverbatim
	/// </summary>
	public void AddGridMappingAttribute(string name, double value)
	{
		vtkNetCDFCFWriter_AddGridMappingAttribute_02(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFWriter_ClearGridMappingAttributes_03(HandleRef pThis);

	/// <summary>
	/// Add/clear attributes that define the grid mapping (or the coordinate
	/// reference system (CRS))
	///
	/// \verbatim
	/// To obtain the correct CF conventions attribute names and values
	/// when knowing the EPSG code use projinfo &lt;epsg_code&gt; This will
	/// print the WKT string. From that you can get the attribute names
	/// and values you need for CF convention.. The WKT attribute names
	/// are fairly close to CF convention attribute names.  The following
	/// link also helps with the conversion.
	/// &lt;a
	/// href="https://github.com/cf-convention/cf-conventions/wiki/Mapping-from-CF-Grid-Mapping-Attributes-to-CRS-WKT-Elements"&gt;CF
	/// Grid Mapping to WKT&lt;/a&gt; See also &lt;a
	/// href="http://cfconventions.org/Data/cf-conventions/cf-conventions-1.9/cf-conventions.html#appendix-grid-mappings"&gt;CF
	/// Grid Mapping&lt;/a&gt; for the attributes needed for each projection.
	/// \endverbatim
	/// </summary>
	public void ClearGridMappingAttributes()
	{
		vtkNetCDFCFWriter_ClearGridMappingAttributes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFWriter_FillBlankedAttributesOff_04(HandleRef pThis);

	/// <summary>
	/// If true, before writing to the file it fills all blanked cells and points in
	/// the attribute arrays with the fill value for the type. Default is false.
	/// </summary>
	public virtual void FillBlankedAttributesOff()
	{
		vtkNetCDFCFWriter_FillBlankedAttributesOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFWriter_FillBlankedAttributesOn_05(HandleRef pThis);

	/// <summary>
	/// If true, before writing to the file it fills all blanked cells and points in
	/// the attribute arrays with the fill value for the type. Default is false.
	/// </summary>
	public virtual void FillBlankedAttributesOn()
	{
		vtkNetCDFCFWriter_FillBlankedAttributesOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCFWriter_GetAttributeType_06(HandleRef pThis);

	/// <summary>
	/// Only arrays of this attribute type are saved in the file. (vtkDataObject::POINT or CELL).
	/// Saving only one type of arrays avoids issues with conflicting array names
	/// between points and cells. Default is vtkDataObject::POINT
	/// </summary>
	public virtual int GetAttributeType()
	{
		return vtkNetCDFCFWriter_GetAttributeType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCFWriter_GetCellArrayNamePostfix_07(HandleRef pThis);

	/// <summary>
	/// VTK allows point and cell arrays with the same name, but NetCDF does not.
	/// This string is appended to a cell array name if it conflicts with a point
	/// array name when it is saved in a NetCDF file. Default is _c.
	///
	/// </summary>
	public virtual string GetCellArrayNamePostfix()
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFCFWriter_GetCellArrayNamePostfix_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCFWriter_GetFileName_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the file name of the file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFCFWriter_GetFileName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkNetCDFCFWriter_GetFillBlankedAttributes_09(HandleRef pThis);

	/// <summary>
	/// If true, before writing to the file it fills all blanked cells and points in
	/// the attribute arrays with the fill value for the type. Default is false.
	/// </summary>
	public virtual bool GetFillBlankedAttributes()
	{
		return (vtkNetCDFCFWriter_GetFillBlankedAttributes_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCFWriter_GetFillValue_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the FillValue for all array. Care must be taken to make sure
	/// the value fits in the value type of each array.
	/// Fill value has the same meaning as blanking in VTK but it is stored in
	/// the data array. This is stored in the NetCDF file.
	/// </summary>
	public virtual int GetFillValue()
	{
		return vtkNetCDFCFWriter_GetFillValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFCFWriter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNetCDFCFWriter_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFCFWriter_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNetCDFCFWriter_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCFWriter_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNetCDFCFWriter_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCFWriter_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNetCDFCFWriter_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCFWriter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNetCDFCFWriter NewInstance()
	{
		vtkNetCDFCFWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFCFWriter_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFCFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCFWriter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFCFWriter SafeDownCast(vtkObjectBase o)
	{
		vtkNetCDFCFWriter vtkNetCDFCFWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFCFWriter_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNetCDFCFWriter2 = (vtkNetCDFCFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNetCDFCFWriter2.Register(null);
			}
		}
		return vtkNetCDFCFWriter2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFWriter_SetAttributeType_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Only arrays of this attribute type are saved in the file. (vtkDataObject::POINT or CELL).
	/// Saving only one type of arrays avoids issues with conflicting array names
	/// between points and cells. Default is vtkDataObject::POINT
	/// </summary>
	public virtual void SetAttributeType(int _arg)
	{
		vtkNetCDFCFWriter_SetAttributeType_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFWriter_SetCellArrayNamePostfix_19(HandleRef pThis, string _arg);

	/// <summary>
	/// VTK allows point and cell arrays with the same name, but NetCDF does not.
	/// This string is appended to a cell array name if it conflicts with a point
	/// array name when it is saved in a NetCDF file. Default is _c.
	///
	/// </summary>
	public virtual void SetCellArrayNamePostfix(string _arg)
	{
		vtkNetCDFCFWriter_SetCellArrayNamePostfix_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFWriter_SetFileName_20(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the file name of the file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkNetCDFCFWriter_SetFileName_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFWriter_SetFillBlankedAttributes_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, before writing to the file it fills all blanked cells and points in
	/// the attribute arrays with the fill value for the type. Default is false.
	/// </summary>
	public virtual void SetFillBlankedAttributes(bool _arg)
	{
		vtkNetCDFCFWriter_SetFillBlankedAttributes_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCFWriter_SetFillValue_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the FillValue for all array. Care must be taken to make sure
	/// the value fits in the value type of each array.
	/// Fill value has the same meaning as blanking in VTK but it is stored in
	/// the data array. This is stored in the NetCDF file.
	/// </summary>
	public virtual void SetFillValue(int _arg)
	{
		vtkNetCDFCFWriter_SetFillValue_22(GetCppThis(), _arg);
	}
}
