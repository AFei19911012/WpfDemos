using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLookupTableWithEnabling
/// </summary>
/// <remarks>
///    A lookup table that allows for an
/// optional array to be provided that specifies which scalars to "enable" and
/// which to "disable".
///
///
/// vtkLookupTableWithEnabling "disables" or "grays out" output colors
/// based on whether the given value in EnabledArray is "0" or not.
///
///
/// @warning
/// You must set the EnabledArray before MapScalars() is called.
/// Indices of EnabledArray must map directly to those of the array passed
/// to MapScalars().
///
/// </remarks>
public class vtkLookupTableWithEnabling : vtkLookupTable
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLookupTableWithEnabling";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLookupTableWithEnabling()
	{
		MRClassNameKey = "class vtkLookupTableWithEnabling";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLookupTableWithEnabling"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLookupTableWithEnabling(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTableWithEnabling_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLookupTableWithEnabling New()
	{
		vtkLookupTableWithEnabling result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLookupTableWithEnabling_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLookupTableWithEnabling)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLookupTableWithEnabling()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLookupTableWithEnabling_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTableWithEnabling_DisableColor_01(HandleRef pThis, byte r, byte g, byte b, IntPtr rd, IntPtr gd, IntPtr bd);

	/// <summary>
	/// A convenience method for taking a color and desaturating it.
	/// </summary>
	public virtual void DisableColor(byte r, byte g, byte b, IntPtr rd, IntPtr gd, IntPtr bd)
	{
		vtkLookupTableWithEnabling_DisableColor_01(GetCppThis(), r, g, b, rd, gd, bd);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTableWithEnabling_GetEnabledArray_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This must be set before MapScalars() is called.
	/// Indices of this array must map directly to those in the scalars array
	/// passed to MapScalars().
	/// Values of 0 in the array indicate the color should be desaturatated.
	/// </summary>
	public virtual vtkDataArray GetEnabledArray()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLookupTableWithEnabling_GetEnabledArray_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTableWithEnabling_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLookupTableWithEnabling_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTableWithEnabling_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLookupTableWithEnabling_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTableWithEnabling_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLookupTableWithEnabling_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTableWithEnabling_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLookupTableWithEnabling_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTableWithEnabling_MapScalarsThroughTable2_07(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

	/// <summary>
	/// Map a set of scalars through the lookup table.
	/// </summary>
	public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
	{
		vtkLookupTableWithEnabling_MapScalarsThroughTable2_07(GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTableWithEnabling_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLookupTableWithEnabling NewInstance()
	{
		vtkLookupTableWithEnabling result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLookupTableWithEnabling_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLookupTableWithEnabling)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTableWithEnabling_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLookupTableWithEnabling SafeDownCast(vtkObjectBase o)
	{
		vtkLookupTableWithEnabling vtkLookupTableWithEnabling2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLookupTableWithEnabling_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLookupTableWithEnabling2 = (vtkLookupTableWithEnabling)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLookupTableWithEnabling2.Register(null);
			}
		}
		return vtkLookupTableWithEnabling2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTableWithEnabling_SetEnabledArray_11(HandleRef pThis, HandleRef enabledArray);

	/// <summary>
	/// This must be set before MapScalars() is called.
	/// Indices of this array must map directly to those in the scalars array
	/// passed to MapScalars().
	/// Values of 0 in the array indicate the color should be desaturatated.
	/// </summary>
	public virtual void SetEnabledArray(vtkDataArray enabledArray)
	{
		vtkLookupTableWithEnabling_SetEnabledArray_11(GetCppThis(), enabledArray?.GetCppThis() ?? default(HandleRef));
	}
}
