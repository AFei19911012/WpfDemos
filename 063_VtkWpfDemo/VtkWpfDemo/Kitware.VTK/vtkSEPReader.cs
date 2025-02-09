using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkSEPReader
/// </summary>
/// <remarks>
///  Stanford Exploration Project files reader.
///
/// This reader takes a .H file that points to a .H@ file and contains
/// all the information to interpret the raw data in the  .H@ file.
/// </remarks>
public class vtkSEPReader : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSEPReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSEPReader()
	{
		MRClassNameKey = "class vtkSEPReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSEPReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSEPReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSEPReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSEPReader New()
	{
		vtkSEPReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSEPReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSEPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSEPReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSEPReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkSEPReader_CanReadFile_01(HandleRef pThis, string arg0);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public bool CanReadFile(string arg0)
	{
		return (vtkSEPReader_CanReadFile_01(GetCppThis(), arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSEPReader_GetAllDimensions_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Array containing the name of all dimensions.
	/// Contains ESize elements.
	/// </summary>
	public virtual vtkStringArray GetAllDimensions()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSEPReader_GetAllDimensions_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSEPReader_GetAllRanges_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Array containing the name and the size of all dimensions.
	/// The two first entries are the header. Contains 2*ESize elements.
	/// </summary>
	public virtual vtkStringArray GetAllRanges()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSEPReader_GetAllRanges_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSEPReader_GetDataOrigin_04(HandleRef pThis);

	/// <summary>
	/// @brief Specify extent translator split mode.
	/// Default: vtkExtentTranslator::BLOCK_MODE
	/// </summary>
	public virtual IntPtr GetDataOrigin()
	{
		return vtkSEPReader_GetDataOrigin_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSEPReader_GetDataSpacing_05(HandleRef pThis);

	/// <summary>
	/// @brief Specify extent translator split mode.
	/// Default: vtkExtentTranslator::BLOCK_MODE
	/// </summary>
	public virtual IntPtr GetDataSpacing()
	{
		return vtkSEPReader_GetDataSpacing_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSEPReader_GetExtentSplitMode_06(HandleRef pThis);

	/// <summary>
	/// @brief Specify extent translator split mode.
	/// Default: vtkExtentTranslator::BLOCK_MODE
	/// </summary>
	public virtual int GetExtentSplitMode()
	{
		return vtkSEPReader_GetExtentSplitMode_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSEPReader_GetFileName_07(HandleRef pThis);

	/// <summary>
	/// @brief Specify file name for the SEP Header file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSEPReader_GetFileName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSEPReader_GetFixedDimRange_08(HandleRef pThis);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual int[] GetFixedDimRange()
	{
		IntPtr intPtr = vtkSEPReader_GetFixedDimRange_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_GetFixedDimRange_09(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual void GetFixedDimRange(ref int _arg1, ref int _arg2)
	{
		vtkSEPReader_GetFixedDimRange_09(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_GetFixedDimRange_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual void GetFixedDimRange(IntPtr _arg)
	{
		vtkSEPReader_GetFixedDimRange_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSEPReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSEPReader_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSEPReader_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSEPReader_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSEPReader_GetOutputGridDimension_13(HandleRef pThis);

	/// <summary>
	/// @brief When 2D mode is true, the third dimension is
	/// ignored and the output is in 2D.
	/// </summary>
	public virtual int GetOutputGridDimension()
	{
		return vtkSEPReader_GetOutputGridDimension_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSEPReader_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSEPReader_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSEPReader_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSEPReader_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSEPReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSEPReader NewInstance()
	{
		vtkSEPReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSEPReader_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSEPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSEPReader_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSEPReader SafeDownCast(vtkObjectBase o)
	{
		vtkSEPReader vtkSEPReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSEPReader_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSEPReader2 = (vtkSEPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSEPReader2.Register(null);
			}
		}
		return vtkSEPReader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetExtentSplitMode_19(HandleRef pThis, int _arg);

	/// <summary>
	/// @brief Specify extent translator split mode.
	/// Default: vtkExtentTranslator::BLOCK_MODE
	/// </summary>
	public virtual void SetExtentSplitMode(int _arg)
	{
		vtkSEPReader_SetExtentSplitMode_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetFileName_20(HandleRef pThis, string arg);

	/// <summary>
	/// @brief Specify file name for the SEP Header file.
	/// </summary>
	public virtual void SetFileName(string arg)
	{
		vtkSEPReader_SetFileName_20(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetFixedDimension1_21(HandleRef pThis, string arg);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual void SetFixedDimension1(string arg)
	{
		vtkSEPReader_SetFixedDimension1_21(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetFixedDimension2_22(HandleRef pThis, string arg);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual void SetFixedDimension2(string arg)
	{
		vtkSEPReader_SetFixedDimension2_22(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetFixedDimensionValue1_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual void SetFixedDimensionValue1(int _arg)
	{
		vtkSEPReader_SetFixedDimensionValue1_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetFixedDimensionValue2_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual void SetFixedDimensionValue2(int _arg)
	{
		vtkSEPReader_SetFixedDimensionValue2_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetOutputGridDimension_25(HandleRef pThis, int _arg);

	/// <summary>
	/// @brief When 2D mode is true, the third dimension is
	/// ignored and the output is in 2D.
	/// </summary>
	public virtual void SetOutputGridDimension(int _arg)
	{
		vtkSEPReader_SetOutputGridDimension_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetXDimension_26(HandleRef pThis, string arg);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual void SetXDimension(string arg)
	{
		vtkSEPReader_SetXDimension_26(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetYDimension_27(HandleRef pThis, string arg);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual void SetYDimension(string arg)
	{
		vtkSEPReader_SetYDimension_27(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSEPReader_SetZDimension_28(HandleRef pThis, string arg);

	/// <summary>
	/// Specify the name for each spatial / fixed dimension.
	/// ZDimension is only used for 3D output.
	/// FixedDimension2 is only used for 2D output.
	/// </summary>
	public virtual void SetZDimension(string arg)
	{
		vtkSEPReader_SetZDimension_28(GetCppThis(), arg);
	}
}
