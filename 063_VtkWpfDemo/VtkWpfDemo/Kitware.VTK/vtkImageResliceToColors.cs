using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageResliceToColors
/// </summary>
/// <remarks>
///    Reslice and produce color scalars.
///
/// vtkImageResliceToColors is an extension of vtkImageReslice that
/// produces color scalars.  It should be provided with a lookup table
/// that defines the output colors and the desired range of input values
/// to map to those colors.  If the input has multiple components, then
/// you should use the SetVectorMode() method of the lookup table to
/// specify how the vectors will be colored.  If no lookup table is
/// provided, then the input must already be color scalars, but they
/// will be converted to the specified output format.
/// </remarks>
/// <seealso>
///
/// vtkImageMapToColors
/// </seealso>
public class vtkImageResliceToColors : vtkImageReslice
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageResliceToColors";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageResliceToColors()
	{
		MRClassNameKey = "class vtkImageResliceToColors";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageResliceToColors"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageResliceToColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceToColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageResliceToColors New()
	{
		vtkImageResliceToColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResliceToColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageResliceToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageResliceToColors()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageResliceToColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageResliceToColors_BypassOff_01(HandleRef pThis);

	/// <summary>
	/// Bypass the color mapping operation and output the scalar
	/// values directly.  The output values will be float, rather
	/// than the input data type.
	/// </summary>
	public void BypassOff()
	{
		vtkImageResliceToColors_BypassOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceToColors_BypassOn_02(HandleRef pThis);

	/// <summary>
	/// Bypass the color mapping operation and output the scalar
	/// values directly.  The output values will be float, rather
	/// than the input data type.
	/// </summary>
	public void BypassOn()
	{
		vtkImageResliceToColors_BypassOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceToColors_GetBypass_03(HandleRef pThis);

	/// <summary>
	/// Bypass the color mapping operation and output the scalar
	/// values directly.  The output values will be float, rather
	/// than the input data type.
	/// </summary>
	public int GetBypass()
	{
		return vtkImageResliceToColors_GetBypass_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceToColors_GetLookupTable_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a lookup table to apply to the data.  Use the Range,
	/// VectorMode, and VectorComponents of the table to control
	/// the mapping of the input data to colors.  If any output
	/// voxel is transformed to a point outside the input volume,
	/// then that voxel will be set to the BackgroundColor.
	/// </summary>
	public virtual vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResliceToColors_GetLookupTable_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkImageResliceToColors_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// When determining the modified time of the filter,
	/// this checks the modified time of the transform and matrix.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageResliceToColors_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageResliceToColors_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageResliceToColors_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageResliceToColors_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageResliceToColors_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceToColors_GetOutputFormat_08(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public virtual int GetOutputFormat()
	{
		return vtkImageResliceToColors_GetOutputFormat_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceToColors_GetOutputFormatMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public virtual int GetOutputFormatMaxValue()
	{
		return vtkImageResliceToColors_GetOutputFormatMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceToColors_GetOutputFormatMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public virtual int GetOutputFormatMinValue()
	{
		return vtkImageResliceToColors_GetOutputFormatMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceToColors_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageResliceToColors_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceToColors_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageResliceToColors_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceToColors_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageResliceToColors NewInstance()
	{
		vtkImageResliceToColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResliceToColors_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageResliceToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceToColors_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageResliceToColors SafeDownCast(vtkObjectBase o)
	{
		vtkImageResliceToColors vtkImageResliceToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResliceToColors_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageResliceToColors2 = (vtkImageResliceToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageResliceToColors2.Register(null);
			}
		}
		return vtkImageResliceToColors2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceToColors_SetBypass_16(HandleRef pThis, int bypass);

	/// <summary>
	/// Bypass the color mapping operation and output the scalar
	/// values directly.  The output values will be float, rather
	/// than the input data type.
	/// </summary>
	public void SetBypass(int bypass)
	{
		vtkImageResliceToColors_SetBypass_16(GetCppThis(), bypass);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceToColors_SetLookupTable_17(HandleRef pThis, HandleRef table);

	/// <summary>
	/// Set a lookup table to apply to the data.  Use the Range,
	/// VectorMode, and VectorComponents of the table to control
	/// the mapping of the input data to colors.  If any output
	/// voxel is transformed to a point outside the input volume,
	/// then that voxel will be set to the BackgroundColor.
	/// </summary>
	public virtual void SetLookupTable(vtkScalarsToColors table)
	{
		vtkImageResliceToColors_SetLookupTable_17(GetCppThis(), table?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceToColors_SetOutputFormat_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public virtual void SetOutputFormat(int _arg)
	{
		vtkImageResliceToColors_SetOutputFormat_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceToColors_SetOutputFormatToLuminance_19(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public void SetOutputFormatToLuminance()
	{
		vtkImageResliceToColors_SetOutputFormatToLuminance_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceToColors_SetOutputFormatToLuminanceAlpha_20(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public void SetOutputFormatToLuminanceAlpha()
	{
		vtkImageResliceToColors_SetOutputFormatToLuminanceAlpha_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceToColors_SetOutputFormatToRGB_21(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public void SetOutputFormatToRGB()
	{
		vtkImageResliceToColors_SetOutputFormatToRGB_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceToColors_SetOutputFormatToRGBA_22(HandleRef pThis);

	/// <summary>
	/// Set the output format, the default is RGBA.
	/// </summary>
	public void SetOutputFormatToRGBA()
	{
		vtkImageResliceToColors_SetOutputFormatToRGBA_22(GetCppThis());
	}
}
