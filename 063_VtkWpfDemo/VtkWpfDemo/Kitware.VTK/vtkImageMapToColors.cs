using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMapToColors
/// </summary>
/// <remarks>
///    map the input image through a lookup table
///
/// The vtkImageMapToColors filter will take an input image of any valid
/// scalar type, and map the first component of the image through a
/// lookup table.  The result is an image of type VTK_UNSIGNED_CHAR.
/// If the lookup table is not set, or is set to nullptr, then the input
/// data will be passed through if it is already of type VTK_UNSIGNED_CHAR.
///
/// </remarks>
/// <seealso>
///
/// vtkLookupTable vtkScalarsToColors
/// </seealso>
public class vtkImageMapToColors : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapToColors";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMapToColors()
	{
		MRClassNameKey = "class vtkImageMapToColors";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapToColors"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMapToColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapToColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMapToColors New()
	{
		vtkImageMapToColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapToColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageMapToColors()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageMapToColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapToColors_GetActiveComponent_01(HandleRef pThis);

	/// <summary>
	/// Set the component to map for multi-component images (default: 0)
	/// </summary>
	public virtual int GetActiveComponent()
	{
		return vtkImageMapToColors_GetActiveComponent_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapToColors_GetLookupTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the lookup table.
	/// </summary>
	public virtual vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapToColors_GetLookupTable_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageMapToColors_GetMTime_03(HandleRef pThis);

	/// <summary>
	/// We need to check the modified time of the lookup table too.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageMapToColors_GetMTime_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapToColors_GetNaNColor_04(HandleRef pThis);

	/// <summary>
	/// Set/Get Color that should be used in case of UnMatching
	/// data.
	/// </summary>
	public virtual byte[] GetNaNColor()
	{
		IntPtr intPtr = vtkImageMapToColors_GetNaNColor_04(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_GetNaNColor_05(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3, ref byte _arg4);

	/// <summary>
	/// Set/Get Color that should be used in case of UnMatching
	/// data.
	/// </summary>
	public virtual void GetNaNColor(ref byte _arg1, ref byte _arg2, ref byte _arg3, ref byte _arg4)
	{
		vtkImageMapToColors_GetNaNColor_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_GetNaNColor_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get Color that should be used in case of UnMatching
	/// data.
	/// </summary>
	public virtual void GetNaNColor(IntPtr _arg)
	{
		vtkImageMapToColors_GetNaNColor_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMapToColors_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMapToColors_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMapToColors_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMapToColors_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapToColors_GetOutputFormat_09(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public virtual int GetOutputFormat()
	{
		return vtkImageMapToColors_GetOutputFormat_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapToColors_GetPassAlphaToOutput_10(HandleRef pThis);

	/// <summary>
	/// Use the alpha component of the input when computing the alpha component
	/// of the output (useful when converting monochrome+alpha data to RGBA)
	/// </summary>
	public virtual int GetPassAlphaToOutput()
	{
		return vtkImageMapToColors_GetPassAlphaToOutput_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapToColors_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMapToColors_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapToColors_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMapToColors_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapToColors_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMapToColors NewInstance()
	{
		vtkImageMapToColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapToColors_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_PassAlphaToOutputOff_15(HandleRef pThis);

	/// <summary>
	/// Use the alpha component of the input when computing the alpha component
	/// of the output (useful when converting monochrome+alpha data to RGBA)
	/// </summary>
	public virtual void PassAlphaToOutputOff()
	{
		vtkImageMapToColors_PassAlphaToOutputOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_PassAlphaToOutputOn_16(HandleRef pThis);

	/// <summary>
	/// Use the alpha component of the input when computing the alpha component
	/// of the output (useful when converting monochrome+alpha data to RGBA)
	/// </summary>
	public virtual void PassAlphaToOutputOn()
	{
		vtkImageMapToColors_PassAlphaToOutputOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapToColors_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMapToColors SafeDownCast(vtkObjectBase o)
	{
		vtkImageMapToColors vtkImageMapToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapToColors_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapToColors2 = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapToColors2.Register(null);
			}
		}
		return vtkImageMapToColors2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetActiveComponent_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the component to map for multi-component images (default: 0)
	/// </summary>
	public virtual void SetActiveComponent(int _arg)
	{
		vtkImageMapToColors_SetActiveComponent_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetLookupTable_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the lookup table.
	/// </summary>
	public virtual void SetLookupTable(vtkScalarsToColors arg0)
	{
		vtkImageMapToColors_SetLookupTable_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetNaNColor_20(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3, byte _arg4);

	/// <summary>
	/// Set/Get Color that should be used in case of UnMatching
	/// data.
	/// </summary>
	public virtual void SetNaNColor(byte _arg1, byte _arg2, byte _arg3, byte _arg4)
	{
		vtkImageMapToColors_SetNaNColor_20(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetNaNColor_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get Color that should be used in case of UnMatching
	/// data.
	/// </summary>
	public virtual void SetNaNColor(IntPtr _arg)
	{
		vtkImageMapToColors_SetNaNColor_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetOutputFormat_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public virtual void SetOutputFormat(int _arg)
	{
		vtkImageMapToColors_SetOutputFormat_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetOutputFormatToLuminance_23(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public void SetOutputFormatToLuminance()
	{
		vtkImageMapToColors_SetOutputFormatToLuminance_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetOutputFormatToLuminanceAlpha_24(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public void SetOutputFormatToLuminanceAlpha()
	{
		vtkImageMapToColors_SetOutputFormatToLuminanceAlpha_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetOutputFormatToRGB_25(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public void SetOutputFormatToRGB()
	{
		vtkImageMapToColors_SetOutputFormatToRGB_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetOutputFormatToRGBA_26(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public void SetOutputFormatToRGBA()
	{
		vtkImageMapToColors_SetOutputFormatToRGBA_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToColors_SetPassAlphaToOutput_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Use the alpha component of the input when computing the alpha component
	/// of the output (useful when converting monochrome+alpha data to RGBA)
	/// </summary>
	public virtual void SetPassAlphaToOutput(int _arg)
	{
		vtkImageMapToColors_SetPassAlphaToOutput_27(GetCppThis(), _arg);
	}
}
