using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVariant
/// </summary>
/// <remarks>
///    A atomic type representing the union of many types
///
///
///
/// @par Thanks:
/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
/// Sandia National Laboratories for their help in developing this class.
/// </remarks>
public class vtkVariant : WrappedObject
{
	/// <summary>
	/// Get the type of the variant as a string.
	/// </summary>
	public enum StringFormatting
	{
		/// <summary>enum member</summary>
		DEFAULT_FORMATTING,
		/// <summary>enum member</summary>
		FIXED_FORMATTING,
		/// <summary>enum member</summary>
		SCIENTIFIC_FORMATTING
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVariant";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVariant()
	{
		MRClassNameKey = "class vtkVariant";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVariant"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVariant(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVariant_GetType_01(HandleRef pThis);

	/// <summary>
	/// Get the type of the variant.
	/// </summary>
	public uint GetTypeWrapper()
	{
		return vtkVariant_GetType_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariant_GetTypeAsString_02(HandleRef pThis);

	/// <summary>
	/// Get the type of the variant as a string.
	/// </summary>
	public string GetTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkVariant_GetTypeAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsArray_03(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is a VTK array (i.e. a subclass of vtkAbstractArray).
	/// </summary>
	public bool IsArray()
	{
		return (vtkVariant_IsArray_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsChar_04(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is an char.
	/// </summary>
	public bool IsChar()
	{
		return (vtkVariant_IsChar_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsDouble_05(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is a double.
	/// </summary>
	public bool IsDouble()
	{
		return (vtkVariant_IsDouble_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsEqual_06(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Determines whether two variants have the same value. They do
	/// not need to be storing exactly the same type to have the same
	/// value.  In practice you don't need to use this method: just use
	/// operator== instead.  If you want precise equality down to the bit
	/// level use the following idiom:
	///
	/// vtkVariantStrictEquality comparator;
	/// bool variantsEqual = comparator(firstVariant, secondVariant);
	/// </summary>
	public bool IsEqual(vtkVariant other)
	{
		return (vtkVariant_IsEqual_06(GetCppThis(), other?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsFloat_07(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is a float.
	/// </summary>
	public bool IsFloat()
	{
		return (vtkVariant_IsFloat_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsInt_08(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is an int.
	/// </summary>
	public bool IsInt()
	{
		return (vtkVariant_IsInt_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsLong_09(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is an long.
	/// </summary>
	public bool IsLong()
	{
		return (vtkVariant_IsLong_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsLongLong_10(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is long long.
	/// </summary>
	public bool IsLongLong()
	{
		return (vtkVariant_IsLongLong_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsNumeric_11(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is any numeric type.
	/// </summary>
	public bool IsNumeric()
	{
		return (vtkVariant_IsNumeric_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsShort_12(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is an short.
	/// </summary>
	public bool IsShort()
	{
		return (vtkVariant_IsShort_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsSignedChar_13(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is an signed char.
	/// </summary>
	public bool IsSignedChar()
	{
		return (vtkVariant_IsSignedChar_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsString_14(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is a string.
	/// </summary>
	public bool IsString()
	{
		return (vtkVariant_IsString_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsUnsignedChar_15(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is an unsigned char.
	/// </summary>
	public bool IsUnsignedChar()
	{
		return (vtkVariant_IsUnsignedChar_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsUnsignedInt_16(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is an unsigned int.
	/// </summary>
	public bool IsUnsignedInt()
	{
		return (vtkVariant_IsUnsignedInt_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsUnsignedLong_17(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is an unsigned long.
	/// </summary>
	public bool IsUnsignedLong()
	{
		return (vtkVariant_IsUnsignedLong_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsUnsignedLongLong_18(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is unsigned long long.
	/// </summary>
	public bool IsUnsignedLongLong()
	{
		return (vtkVariant_IsUnsignedLongLong_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsUnsignedShort_19(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is an unsigned short.
	/// </summary>
	public bool IsUnsignedShort()
	{
		return (vtkVariant_IsUnsignedShort_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsVTKObject_20(HandleRef pThis);

	/// <summary>
	/// Get whether the variant is a VTK object pointer.
	/// </summary>
	public bool IsVTKObject()
	{
		return (vtkVariant_IsVTKObject_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_IsValid_21(HandleRef pThis);

	/// <summary>
	/// Get whether the variant value is valid.
	/// </summary>
	public bool IsValid()
	{
		return (vtkVariant_IsValid_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariant_ToArray_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the array, or nullptr if not of that type.
	/// </summary>
	public vtkAbstractArray ToArray()
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVariant_ToArray_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkVariant_ToChar_23(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public sbyte ToChar(IntPtr valid)
	{
		return vtkVariant_ToChar_23(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkVariant_ToChar_24(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public sbyte ToChar()
	{
		return vtkVariant_ToChar_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVariant_ToDouble_25(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public double ToDouble(IntPtr valid)
	{
		return vtkVariant_ToDouble_25(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVariant_ToDouble_26(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public double ToDouble()
	{
		return vtkVariant_ToDouble_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkVariant_ToFloat_27(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public float ToFloat(IntPtr valid)
	{
		return vtkVariant_ToFloat_27(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkVariant_ToFloat_28(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public float ToFloat()
	{
		return vtkVariant_ToFloat_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariant_ToInt_29(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public int ToInt(IntPtr valid)
	{
		return vtkVariant_ToInt_29(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariant_ToInt_30(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public int ToInt()
	{
		return vtkVariant_ToInt_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariant_ToLong_31(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public int ToLong(IntPtr valid)
	{
		return vtkVariant_ToLong_31(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariant_ToLong_32(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public int ToLong()
	{
		return vtkVariant_ToLong_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariant_ToLongLong_33(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public long ToLongLong(IntPtr valid)
	{
		return vtkVariant_ToLongLong_33(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariant_ToLongLong_34(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public long ToLongLong()
	{
		return vtkVariant_ToLongLong_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern short vtkVariant_ToShort_35(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public short ToShort(IntPtr valid)
	{
		return vtkVariant_ToShort_35(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern short vtkVariant_ToShort_36(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public short ToShort()
	{
		return vtkVariant_ToShort_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkVariant_ToSignedChar_37(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public sbyte ToSignedChar(IntPtr valid)
	{
		return vtkVariant_ToSignedChar_37(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkVariant_ToSignedChar_38(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public sbyte ToSignedChar()
	{
		return vtkVariant_ToSignedChar_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkVariant_ToString_39(HandleRef pThis, int formatting, int precision);

	/// <summary>
	/// Convert the variant to a string.
	/// Set the formatting argument to either DEFAULT_FORMATTING, FIXED_FORMATTING,
	/// SCIENTIFIC_FORMATTING to control the formatting. Set the precision
	/// argument to control the precision of the output. These two parameters have no effect when the
	/// variant is not a floating-point value or an array of floating-point values.
	/// See the std doc for more information.
	/// </summary>
	public string ToStringWrapper(int formatting, int precision)
	{
		return vtkVariant_ToString_39(GetCppThis(), formatting, precision);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariant_ToTypeInt64_40(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public long ToTypeInt64(IntPtr valid)
	{
		return vtkVariant_ToTypeInt64_40(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariant_ToTypeInt64_41(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public long ToTypeInt64()
	{
		return vtkVariant_ToTypeInt64_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVariant_ToTypeUInt64_42(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public ulong ToTypeUInt64(IntPtr valid)
	{
		return vtkVariant_ToTypeUInt64_42(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVariant_ToTypeUInt64_43(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public ulong ToTypeUInt64()
	{
		return vtkVariant_ToTypeUInt64_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_ToUnsignedChar_44(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public byte ToUnsignedChar(IntPtr valid)
	{
		return vtkVariant_ToUnsignedChar_44(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVariant_ToUnsignedChar_45(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public byte ToUnsignedChar()
	{
		return vtkVariant_ToUnsignedChar_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVariant_ToUnsignedInt_46(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public uint ToUnsignedInt(IntPtr valid)
	{
		return vtkVariant_ToUnsignedInt_46(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVariant_ToUnsignedInt_47(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public uint ToUnsignedInt()
	{
		return vtkVariant_ToUnsignedInt_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVariant_ToUnsignedLong_48(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public uint ToUnsignedLong(IntPtr valid)
	{
		return vtkVariant_ToUnsignedLong_48(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVariant_ToUnsignedLong_49(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public uint ToUnsignedLong()
	{
		return vtkVariant_ToUnsignedLong_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVariant_ToUnsignedLongLong_50(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public ulong ToUnsignedLongLong(IntPtr valid)
	{
		return vtkVariant_ToUnsignedLongLong_50(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVariant_ToUnsignedLongLong_51(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public ulong ToUnsignedLongLong()
	{
		return vtkVariant_ToUnsignedLongLong_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkVariant_ToUnsignedShort_52(HandleRef pThis, IntPtr valid);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public ushort ToUnsignedShort(IntPtr valid)
	{
		return vtkVariant_ToUnsignedShort_52(GetCppThis(), valid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkVariant_ToUnsignedShort_53(HandleRef pThis);

	/// <summary>
	/// Convert the variant to a numeric type:
	/// If it holds a numeric, cast to the appropriate type.
	/// If it holds a string, attempt to convert the string to the appropriate type;
	/// set the valid flag to false when the conversion fails.
	/// If it holds an array type, cast the first value of the array
	/// to the appropriate type.
	/// Fail if it holds a VTK object which is not an array.
	/// </summary>
	public ushort ToUnsignedShort()
	{
		return vtkVariant_ToUnsignedShort_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariant_ToVTKObject_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the VTK object, or nullptr if not of that type.
	/// </summary>
	public vtkObjectBase ToVTKObject()
	{
		vtkObjectBase vtkObjectBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVariant_ToVTKObject_54(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObjectBase2 = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObjectBase2.Register(null);
			}
		}
		return vtkObjectBase2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariant_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float v);

	public vtkVariant(float v)
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVariant_New(ref mteStatus, ref mteIndex, ref rawRefCount, v);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}
}
