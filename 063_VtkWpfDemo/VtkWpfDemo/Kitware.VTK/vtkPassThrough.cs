using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkPassThrough
/// </summary>
/// <remarks>
///  Pass input input data through to the output
///
/// vtkPassThrough simply passes input data to the output. By default, the input
/// is shallow-copied (using `vtkDataObject::ShallowCopy`). If `DeepCopyInput` is true,
/// then the input is deep-copied (using `vtkDataObject::DeepCopy`).
///
/// The output type is always the same as the input object type.
/// </remarks>
public class vtkPassThrough : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPassThrough";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPassThrough()
	{
		MRClassNameKey = "class vtkPassThrough";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassThrough"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPassThrough(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPassThrough_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPassThrough New()
	{
		vtkPassThrough result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPassThrough_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPassThrough)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPassThrough()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPassThrough_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassThrough_AllowNullInputOff_01(HandleRef pThis);

	/// <summary>
	/// Allow the filter to execute without error when no input connection is
	/// specified. In this case, and empty vtkPolyData dataset will be created.
	/// By default, this setting is false.
	/// @{
	/// </summary>
	public virtual void AllowNullInputOff()
	{
		vtkPassThrough_AllowNullInputOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassThrough_AllowNullInputOn_02(HandleRef pThis);

	/// <summary>
	/// Allow the filter to execute without error when no input connection is
	/// specified. In this case, and empty vtkPolyData dataset will be created.
	/// By default, this setting is false.
	/// @{
	/// </summary>
	public virtual void AllowNullInputOn()
	{
		vtkPassThrough_AllowNullInputOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassThrough_DeepCopyInputOff_03(HandleRef pThis);

	/// <summary>
	/// Whether or not to deep copy the input. This can be useful if you
	/// want to create a copy of a data object. You can then disconnect
	/// this filter's input connections and it will act like a source.
	/// Defaults to OFF.
	/// </summary>
	public virtual void DeepCopyInputOff()
	{
		vtkPassThrough_DeepCopyInputOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassThrough_DeepCopyInputOn_04(HandleRef pThis);

	/// <summary>
	/// Whether or not to deep copy the input. This can be useful if you
	/// want to create a copy of a data object. You can then disconnect
	/// this filter's input connections and it will act like a source.
	/// Defaults to OFF.
	/// </summary>
	public virtual void DeepCopyInputOn()
	{
		vtkPassThrough_DeepCopyInputOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPassThrough_FillInputPortInformation_05(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Specify the first input port as optional
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkPassThrough_FillInputPortInformation_05(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPassThrough_GetAllowNullInput_06(HandleRef pThis);

	/// <summary>
	/// Allow the filter to execute without error when no input connection is
	/// specified. In this case, and empty vtkPolyData dataset will be created.
	/// By default, this setting is false.
	/// @{
	/// </summary>
	public virtual bool GetAllowNullInput()
	{
		return (vtkPassThrough_GetAllowNullInput_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPassThrough_GetDeepCopyInput_07(HandleRef pThis);

	/// <summary>
	/// Whether or not to deep copy the input. This can be useful if you
	/// want to create a copy of a data object. You can then disconnect
	/// this filter's input connections and it will act like a source.
	/// Defaults to OFF.
	/// </summary>
	public virtual int GetDeepCopyInput()
	{
		return vtkPassThrough_GetDeepCopyInput_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPassThrough_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPassThrough_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPassThrough_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPassThrough_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPassThrough_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPassThrough_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPassThrough_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPassThrough_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPassThrough_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPassThrough NewInstance()
	{
		vtkPassThrough result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPassThrough_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPassThrough)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPassThrough_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPassThrough SafeDownCast(vtkObjectBase o)
	{
		vtkPassThrough vtkPassThrough2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPassThrough_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPassThrough2 = (vtkPassThrough)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPassThrough2.Register(null);
			}
		}
		return vtkPassThrough2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassThrough_SetAllowNullInput_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Allow the filter to execute without error when no input connection is
	/// specified. In this case, and empty vtkPolyData dataset will be created.
	/// By default, this setting is false.
	/// @{
	/// </summary>
	public virtual void SetAllowNullInput(bool _arg)
	{
		vtkPassThrough_SetAllowNullInput_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassThrough_SetDeepCopyInput_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Whether or not to deep copy the input. This can be useful if you
	/// want to create a copy of a data object. You can then disconnect
	/// this filter's input connections and it will act like a source.
	/// Defaults to OFF.
	/// </summary>
	public virtual void SetDeepCopyInput(int _arg)
	{
		vtkPassThrough_SetDeepCopyInput_16(GetCppThis(), _arg);
	}
}
