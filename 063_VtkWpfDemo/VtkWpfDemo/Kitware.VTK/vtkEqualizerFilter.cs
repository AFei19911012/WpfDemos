using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkEqualizerFilter
/// </summary>
/// <remarks>
///  implements an algorithm for digital signal processing
///
/// The vtkEqualizerFilter implements an algorithm that selectively corrects the signal amplitude
/// depending on the frequency characteristics.
/// </remarks>
public class vtkEqualizerFilter : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEqualizerFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEqualizerFilter()
	{
		MRClassNameKey = "class vtkEqualizerFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEqualizerFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEqualizerFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEqualizerFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEqualizerFilter New()
	{
		vtkEqualizerFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEqualizerFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEqualizerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEqualizerFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEqualizerFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkEqualizerFilter_GetAllColumns_01(HandleRef pThis);

	/// <summary>
	/// Set / Get a flag to process all columns of the table.
	/// If set to true, all columns of the table will be used. The "SetArray()" method will have no
	/// effect.
	/// Default value is: false
	/// </summary>
	public virtual bool GetAllColumns()
	{
		return (vtkEqualizerFilter_GetAllColumns_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEqualizerFilter_GetArray_02(HandleRef pThis);

	/// <summary>
	/// Set / Get the name of the column from which the data array is taken
	/// </summary>
	public virtual string GetArray()
	{
		return Marshal.PtrToStringAnsi(vtkEqualizerFilter_GetArray_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEqualizerFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEqualizerFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEqualizerFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEqualizerFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkEqualizerFilter_GetPoints_05(HandleRef pThis);

	/// <summary>
	/// Set / Get anchor points in the following format
	/// "P1x,P1y;P2x,P2y; ... PNx,PNy;"
	/// Default value is an empty string
	/// </summary>
	public string GetPoints()
	{
		return vtkEqualizerFilter_GetPoints_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEqualizerFilter_GetSamplingFrequency_06(HandleRef pThis);

	/// <summary>
	/// Set / Get the sampling frequency of the original signal in Hz
	/// Default value is: 1000
	/// </summary>
	public virtual int GetSamplingFrequency()
	{
		return vtkEqualizerFilter_GetSamplingFrequency_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEqualizerFilter_GetSpectrumGain_07(HandleRef pThis);

	/// <summary>
	/// Set / Get the spectrum gain in dB
	/// Default value is: 0
	/// </summary>
	public virtual int GetSpectrumGain()
	{
		return vtkEqualizerFilter_GetSpectrumGain_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEqualizerFilter_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEqualizerFilter_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEqualizerFilter_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEqualizerFilter_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEqualizerFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEqualizerFilter NewInstance()
	{
		vtkEqualizerFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEqualizerFilter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEqualizerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEqualizerFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEqualizerFilter SafeDownCast(vtkObjectBase o)
	{
		vtkEqualizerFilter vtkEqualizerFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEqualizerFilter_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEqualizerFilter2 = (vtkEqualizerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEqualizerFilter2.Register(null);
			}
		}
		return vtkEqualizerFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEqualizerFilter_SetAllColumns_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set / Get a flag to process all columns of the table.
	/// If set to true, all columns of the table will be used. The "SetArray()" method will have no
	/// effect.
	/// Default value is: false
	/// </summary>
	public virtual void SetAllColumns(bool _arg)
	{
		vtkEqualizerFilter_SetAllColumns_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEqualizerFilter_SetArray_14(HandleRef pThis, string arg);

	/// <summary>
	/// Set / Get the name of the column from which the data array is taken
	/// </summary>
	public virtual void SetArray(string arg)
	{
		vtkEqualizerFilter_SetArray_14(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEqualizerFilter_SetPoints_15(HandleRef pThis, string points);

	/// <summary>
	/// Set / Get anchor points in the following format
	/// "P1x,P1y;P2x,P2y; ... PNx,PNy;"
	/// Default value is an empty string
	/// </summary>
	public void SetPoints(string points)
	{
		vtkEqualizerFilter_SetPoints_15(GetCppThis(), points);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEqualizerFilter_SetSamplingFrequency_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / Get the sampling frequency of the original signal in Hz
	/// Default value is: 1000
	/// </summary>
	public virtual void SetSamplingFrequency(int _arg)
	{
		vtkEqualizerFilter_SetSamplingFrequency_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEqualizerFilter_SetSpectrumGain_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / Get the spectrum gain in dB
	/// Default value is: 0
	/// </summary>
	public virtual void SetSpectrumGain(int _arg)
	{
		vtkEqualizerFilter_SetSpectrumGain_17(GetCppThis(), _arg);
	}
}
