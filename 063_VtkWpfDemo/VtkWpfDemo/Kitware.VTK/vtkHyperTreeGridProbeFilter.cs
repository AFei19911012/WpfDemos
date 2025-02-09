using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHyperTreeGridProbeFilter
/// </summary>
/// <remarks>
///    Probe a vtkHyperTreeGrid
///
/// Heavily modeled after the vtkProbeFilter, this class
///  is meant to be used to probe vtkHyperTreeGrid objects.
///
/// </remarks>
public class vtkHyperTreeGridProbeFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridProbeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHyperTreeGridProbeFilter()
	{
		MRClassNameKey = "class vtkHyperTreeGridProbeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridProbeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHyperTreeGridProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridProbeFilter New()
	{
		vtkHyperTreeGridProbeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridProbeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHyperTreeGridProbeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHyperTreeGridProbeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkHyperTreeGridProbeFilter_GetComputeTolerance_01(HandleRef pThis);

	/// <summary>
	/// Get/Set wether or not to compute the tolerance automatically for
	/// when finding points in the HTG source. If false use the tolerance
	/// from SetTolerance .
	///
	/// Default is true
	/// </summary>
	public virtual bool GetComputeTolerance()
	{
		return (vtkHyperTreeGridProbeFilter_GetComputeTolerance_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridProbeFilter_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and get the locator object
	/// </summary>
	public virtual vtkHyperTreeGridLocator GetLocator()
	{
		vtkHyperTreeGridLocator vtkHyperTreeGridLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridProbeFilter_GetLocator_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeGridLocator2 = (vtkHyperTreeGridLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeGridLocator2.Register(null);
			}
		}
		return vtkHyperTreeGridLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHyperTreeGridProbeFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridProbeFilter_GetPassCellArrays_05(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual bool GetPassCellArrays()
	{
		return (vtkHyperTreeGridProbeFilter_GetPassCellArrays_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridProbeFilter_GetPassFieldArrays_06(HandleRef pThis);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual bool GetPassFieldArrays()
	{
		return (vtkHyperTreeGridProbeFilter_GetPassFieldArrays_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridProbeFilter_GetPassPointArrays_07(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual bool GetPassPointArrays()
	{
		return (vtkHyperTreeGridProbeFilter_GetPassPointArrays_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperTreeGridProbeFilter_GetTolerance_08(HandleRef pThis);

	/// <summary>
	/// Get/Set tolerance used when finding points in the HTG source.
	/// Overriden when ComputeTolerance == true.
	///
	/// Default is 0.0
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkHyperTreeGridProbeFilter_GetTolerance_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkHyperTreeGridProbeFilter_GetValidPointMaskArrayName_09(HandleRef pThis);

	/// <summary>
	/// Returns the name of the char array added to the output with values 1 for
	/// valid points and 0 for invalid points.
	/// Set to "vtkValidPointMask" by default.
	/// </summary>
	public virtual string GetValidPointMaskArrayName()
	{
		return vtkHyperTreeGridProbeFilter_GetValidPointMaskArrayName_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridProbeFilter_GetValidPoints_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the list of point ids in the output that contain attribute data
	/// from the source.
	/// </summary>
	public vtkIdTypeArray GetValidPoints()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridProbeFilter_GetValidPoints_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridProbeFilter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHyperTreeGridProbeFilter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridProbeFilter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHyperTreeGridProbeFilter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridProbeFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHyperTreeGridProbeFilter NewInstance()
	{
		vtkHyperTreeGridProbeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridProbeFilter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_PassCellArraysOff_15(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual void PassCellArraysOff()
	{
		vtkHyperTreeGridProbeFilter_PassCellArraysOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_PassCellArraysOn_16(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual void PassCellArraysOn()
	{
		vtkHyperTreeGridProbeFilter_PassCellArraysOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_PassFieldArraysOff_17(HandleRef pThis);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOff()
	{
		vtkHyperTreeGridProbeFilter_PassFieldArraysOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_PassFieldArraysOn_18(HandleRef pThis);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOn()
	{
		vtkHyperTreeGridProbeFilter_PassFieldArraysOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_PassPointArraysOff_19(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual void PassPointArraysOff()
	{
		vtkHyperTreeGridProbeFilter_PassPointArraysOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_PassPointArraysOn_20(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual void PassPointArraysOn()
	{
		vtkHyperTreeGridProbeFilter_PassPointArraysOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridProbeFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridProbeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkHyperTreeGridProbeFilter vtkHyperTreeGridProbeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridProbeFilter_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeGridProbeFilter2 = (vtkHyperTreeGridProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeGridProbeFilter2.Register(null);
			}
		}
		return vtkHyperTreeGridProbeFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_SetComputeTolerance_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set wether or not to compute the tolerance automatically for
	/// when finding points in the HTG source. If false use the tolerance
	/// from SetTolerance .
	///
	/// Default is true
	/// </summary>
	public virtual void SetComputeTolerance(bool _arg)
	{
		vtkHyperTreeGridProbeFilter_SetComputeTolerance_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_SetLocator_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set and get the locator object
	/// </summary>
	public virtual void SetLocator(vtkHyperTreeGridLocator arg0)
	{
		vtkHyperTreeGridProbeFilter_SetLocator_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_SetPassCellArrays_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual void SetPassCellArrays(bool _arg)
	{
		vtkHyperTreeGridProbeFilter_SetPassCellArrays_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_SetPassFieldArrays_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual void SetPassFieldArrays(bool _arg)
	{
		vtkHyperTreeGridProbeFilter_SetPassFieldArrays_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_SetPassPointArrays_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual void SetPassPointArrays(bool _arg)
	{
		vtkHyperTreeGridProbeFilter_SetPassPointArrays_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_SetSourceConnection_27(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the data set that will be probed at the input points.
	/// The Input gives the geometry (the points and cells) for the output,
	/// while the Source is probed (interpolated) to generate the scalars,
	/// vectors, etc. for the output points based on the point locations.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkHyperTreeGridProbeFilter_SetSourceConnection_27(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_SetTolerance_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set tolerance used when finding points in the HTG source.
	/// Overriden when ComputeTolerance == true.
	///
	/// Default is 0.0
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkHyperTreeGridProbeFilter_SetTolerance_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridProbeFilter_SetValidPointMaskArrayName_29(HandleRef pThis, string _arg);

	/// <summary>
	/// Returns the name of the char array added to the output with values 1 for
	/// valid points and 0 for invalid points.
	/// Set to "vtkValidPointMask" by default.
	/// </summary>
	public virtual void SetValidPointMaskArrayName(string _arg)
	{
		vtkHyperTreeGridProbeFilter_SetValidPointMaskArrayName_29(GetCppThis(), _arg);
	}
}
