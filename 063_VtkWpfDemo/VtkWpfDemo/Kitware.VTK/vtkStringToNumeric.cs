using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStringToNumeric
/// </summary>
/// <remarks>
///    Converts string arrays to numeric arrays
///
///
/// vtkStringToNumeric is a filter for converting a string array
/// into a numeric arrays.
/// </remarks>
public class vtkStringToNumeric : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStringToNumeric";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStringToNumeric()
	{
		MRClassNameKey = "class vtkStringToNumeric";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToNumeric"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStringToNumeric(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringToNumeric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStringToNumeric New()
	{
		vtkStringToNumeric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringToNumeric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStringToNumeric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStringToNumeric()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStringToNumeric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertCellDataOff_01(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert point data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertCellDataOff()
	{
		vtkStringToNumeric_ConvertCellDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertCellDataOn_02(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert point data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertCellDataOn()
	{
		vtkStringToNumeric_ConvertCellDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertEdgeDataOff_03(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert edge data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertEdgeDataOff()
	{
		vtkStringToNumeric_ConvertEdgeDataOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertEdgeDataOn_04(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert edge data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertEdgeDataOn()
	{
		vtkStringToNumeric_ConvertEdgeDataOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertFieldDataOff_05(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert field data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertFieldDataOff()
	{
		vtkStringToNumeric_ConvertFieldDataOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertFieldDataOn_06(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert field data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertFieldDataOn()
	{
		vtkStringToNumeric_ConvertFieldDataOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertPointDataOff_07(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert cell data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertPointDataOff()
	{
		vtkStringToNumeric_ConvertPointDataOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertPointDataOn_08(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert cell data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertPointDataOn()
	{
		vtkStringToNumeric_ConvertPointDataOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertRowDataOff_09(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert row data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertRowDataOff()
	{
		vtkStringToNumeric_ConvertRowDataOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertRowDataOn_10(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert row data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertRowDataOn()
	{
		vtkStringToNumeric_ConvertRowDataOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertVertexDataOff_11(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert vertex data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertVertexDataOff()
	{
		vtkStringToNumeric_ConvertVertexDataOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ConvertVertexDataOn_12(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert vertex data arrays.  Default is on.
	/// </summary>
	public virtual void ConvertVertexDataOn()
	{
		vtkStringToNumeric_ConvertVertexDataOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ForceDoubleOff_13(HandleRef pThis);

	/// <summary>
	/// Convert all numeric columns to vtkDoubleArray, even if they
	/// contain only integer values. Default is off.
	/// </summary>
	public virtual void ForceDoubleOff()
	{
		vtkStringToNumeric_ForceDoubleOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_ForceDoubleOn_14(HandleRef pThis);

	/// <summary>
	/// Convert all numeric columns to vtkDoubleArray, even if they
	/// contain only integer values. Default is off.
	/// </summary>
	public virtual void ForceDoubleOn()
	{
		vtkStringToNumeric_ForceDoubleOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStringToNumeric_GetConvertCellData_15(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert point data arrays.  Default is on.
	/// </summary>
	public virtual bool GetConvertCellData()
	{
		return (vtkStringToNumeric_GetConvertCellData_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStringToNumeric_GetConvertEdgeData_16(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert edge data arrays.  Default is on.
	/// </summary>
	public virtual bool GetConvertEdgeData()
	{
		return (vtkStringToNumeric_GetConvertEdgeData_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStringToNumeric_GetConvertFieldData_17(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert field data arrays.  Default is on.
	/// </summary>
	public virtual bool GetConvertFieldData()
	{
		return (vtkStringToNumeric_GetConvertFieldData_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStringToNumeric_GetConvertPointData_18(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert cell data arrays.  Default is on.
	/// </summary>
	public virtual bool GetConvertPointData()
	{
		return (vtkStringToNumeric_GetConvertPointData_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStringToNumeric_GetConvertRowData_19(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert row data arrays.  Default is on.
	/// </summary>
	public virtual bool GetConvertRowData()
	{
		return (vtkStringToNumeric_GetConvertRowData_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStringToNumeric_GetConvertVertexData_20(HandleRef pThis);

	/// <summary>
	/// Whether to detect and convert vertex data arrays.  Default is on.
	/// </summary>
	public virtual bool GetConvertVertexData()
	{
		return (vtkStringToNumeric_GetConvertVertexData_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStringToNumeric_GetDefaultDoubleValue_21(HandleRef pThis);

	/// <summary>
	/// Set the default double value assigned to arrays.  Default is 0.0
	/// </summary>
	public virtual double GetDefaultDoubleValue()
	{
		return vtkStringToNumeric_GetDefaultDoubleValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringToNumeric_GetDefaultIntegerValue_22(HandleRef pThis);

	/// <summary>
	/// Set the default integer value assigned to arrays.  Default is 0.
	/// </summary>
	public virtual int GetDefaultIntegerValue()
	{
		return vtkStringToNumeric_GetDefaultIntegerValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStringToNumeric_GetForceDouble_23(HandleRef pThis);

	/// <summary>
	/// Convert all numeric columns to vtkDoubleArray, even if they
	/// contain only integer values. Default is off.
	/// </summary>
	public virtual bool GetForceDouble()
	{
		return (vtkStringToNumeric_GetForceDouble_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringToNumeric_GetNumberOfGenerationsFromBase_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStringToNumeric_GetNumberOfGenerationsFromBase_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringToNumeric_GetNumberOfGenerationsFromBaseType_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStringToNumeric_GetNumberOfGenerationsFromBaseType_25(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStringToNumeric_GetTrimWhitespacePriorToNumericConversion_26(HandleRef pThis);

	/// <summary>
	/// Whether to trim whitespace from strings prior to conversion to a numeric.
	/// Default is false to preserve backward compatibility.
	///
	/// vtkVariant handles whitespace inconsistently, so trim it before we try to
	/// convert it.  For example:
	///
	/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
	/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
	/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
	///
	/// In these cases, trimming the whitespace gives us the result we expect:
	/// 2.0 and INF respectively.
	/// </summary>
	public virtual bool GetTrimWhitespacePriorToNumericConversion()
	{
		return (vtkStringToNumeric_GetTrimWhitespacePriorToNumericConversion_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringToNumeric_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStringToNumeric_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringToNumeric_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStringToNumeric_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringToNumeric_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStringToNumeric NewInstance()
	{
		vtkStringToNumeric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringToNumeric_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStringToNumeric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringToNumeric_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStringToNumeric SafeDownCast(vtkObjectBase o)
	{
		vtkStringToNumeric vtkStringToNumeric2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringToNumeric_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringToNumeric2 = (vtkStringToNumeric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringToNumeric2.Register(null);
			}
		}
		return vtkStringToNumeric2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetConvertCellData_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to detect and convert point data arrays.  Default is on.
	/// </summary>
	public virtual void SetConvertCellData(bool _arg)
	{
		vtkStringToNumeric_SetConvertCellData_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetConvertEdgeData_33(HandleRef pThis, byte b);

	/// <summary>
	/// Whether to detect and convert edge data arrays.  Default is on.
	/// </summary>
	public virtual void SetConvertEdgeData(bool b)
	{
		vtkStringToNumeric_SetConvertEdgeData_33(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetConvertFieldData_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to detect and convert field data arrays.  Default is on.
	/// </summary>
	public virtual void SetConvertFieldData(bool _arg)
	{
		vtkStringToNumeric_SetConvertFieldData_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetConvertPointData_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to detect and convert cell data arrays.  Default is on.
	/// </summary>
	public virtual void SetConvertPointData(bool _arg)
	{
		vtkStringToNumeric_SetConvertPointData_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetConvertRowData_36(HandleRef pThis, byte b);

	/// <summary>
	/// Whether to detect and convert row data arrays.  Default is on.
	/// </summary>
	public virtual void SetConvertRowData(bool b)
	{
		vtkStringToNumeric_SetConvertRowData_36(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetConvertVertexData_37(HandleRef pThis, byte b);

	/// <summary>
	/// Whether to detect and convert vertex data arrays.  Default is on.
	/// </summary>
	public virtual void SetConvertVertexData(bool b)
	{
		vtkStringToNumeric_SetConvertVertexData_37(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetDefaultDoubleValue_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the default double value assigned to arrays.  Default is 0.0
	/// </summary>
	public virtual void SetDefaultDoubleValue(double _arg)
	{
		vtkStringToNumeric_SetDefaultDoubleValue_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetDefaultIntegerValue_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the default integer value assigned to arrays.  Default is 0.
	/// </summary>
	public virtual void SetDefaultIntegerValue(int _arg)
	{
		vtkStringToNumeric_SetDefaultIntegerValue_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetForceDouble_40(HandleRef pThis, byte _arg);

	/// <summary>
	/// Convert all numeric columns to vtkDoubleArray, even if they
	/// contain only integer values. Default is off.
	/// </summary>
	public virtual void SetForceDouble(bool _arg)
	{
		vtkStringToNumeric_SetForceDouble_40(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_SetTrimWhitespacePriorToNumericConversion_41(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to trim whitespace from strings prior to conversion to a numeric.
	/// Default is false to preserve backward compatibility.
	///
	/// vtkVariant handles whitespace inconsistently, so trim it before we try to
	/// convert it.  For example:
	///
	/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
	/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
	/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
	///
	/// In these cases, trimming the whitespace gives us the result we expect:
	/// 2.0 and INF respectively.
	/// </summary>
	public virtual void SetTrimWhitespacePriorToNumericConversion(bool _arg)
	{
		vtkStringToNumeric_SetTrimWhitespacePriorToNumericConversion_41(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_TrimWhitespacePriorToNumericConversionOff_42(HandleRef pThis);

	/// <summary>
	/// Whether to trim whitespace from strings prior to conversion to a numeric.
	/// Default is false to preserve backward compatibility.
	///
	/// vtkVariant handles whitespace inconsistently, so trim it before we try to
	/// convert it.  For example:
	///
	/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
	/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
	/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
	///
	/// In these cases, trimming the whitespace gives us the result we expect:
	/// 2.0 and INF respectively.
	/// </summary>
	public virtual void TrimWhitespacePriorToNumericConversionOff()
	{
		vtkStringToNumeric_TrimWhitespacePriorToNumericConversionOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToNumeric_TrimWhitespacePriorToNumericConversionOn_43(HandleRef pThis);

	/// <summary>
	/// Whether to trim whitespace from strings prior to conversion to a numeric.
	/// Default is false to preserve backward compatibility.
	///
	/// vtkVariant handles whitespace inconsistently, so trim it before we try to
	/// convert it.  For example:
	///
	/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
	/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
	/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
	///
	/// In these cases, trimming the whitespace gives us the result we expect:
	/// 2.0 and INF respectively.
	/// </summary>
	public virtual void TrimWhitespacePriorToNumericConversionOn()
	{
		vtkStringToNumeric_TrimWhitespacePriorToNumericConversionOn_43(GetCppThis());
	}
}
