using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRSliceFilter
///
///
///  A concrete instance of vtkOverlappingAMRAlgorithm which implements
///  functionality for extracting slices from AMR data. Unlike the conventional
///  slice filter, the output of this filter is a 2-D AMR dataset itself.
/// </summary>
public class vtkAMRSliceFilter : vtkOverlappingAMRAlgorithm
{
	/// <summary>
	/// Tags to identify normals along the X, Y and Z directions.
	/// </summary>
	public enum NormalTag
	{
		/// <summary>enum member</summary>
		X_NORMAL = 1,
		/// <summary>enum member</summary>
		Y_NORMAL = 2,
		/// <summary>enum member</summary>
		Z_NORMAL = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRSliceFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRSliceFilter()
	{
		MRClassNameKey = "class vtkAMRSliceFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRSliceFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRSliceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRSliceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRSliceFilter New()
	{
		vtkAMRSliceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRSliceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRSliceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAMRSliceFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAMRSliceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRSliceFilter_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Set/Get a multiprocess controller for paralle processing.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkAMRSliceFilter_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRSliceFilter_FillOutputPortInformation_02(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Set/Get a multiprocess controller for paralle processing.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual int FillOutputPortInformation(int port, vtkInformation info)
	{
		return vtkAMRSliceFilter_FillOutputPortInformation_02(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRSliceFilter_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a multiprocess controller for paralle processing.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRSliceFilter_GetController_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAMRSliceFilter_GetMaxResolution_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum resolution used in this instance.
	/// </summary>
	public virtual uint GetMaxResolution()
	{
		return vtkAMRSliceFilter_GetMaxResolution_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRSliceFilter_GetNormal_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the Axis normal. The accpetable values are defined in the
	/// NormalTag enum.
	/// </summary>
	public virtual int GetNormal()
	{
		return vtkAMRSliceFilter_GetNormal_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRSliceFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRSliceFilter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRSliceFilter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRSliceFilter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAMRSliceFilter_GetOffsetFromOrigin_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset-from-origin of the slicing plane.
	/// </summary>
	public virtual double GetOffsetFromOrigin()
	{
		return vtkAMRSliceFilter_GetOffsetFromOrigin_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRSliceFilter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRSliceFilter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRSliceFilter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRSliceFilter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRSliceFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMRSliceFilter NewInstance()
	{
		vtkAMRSliceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRSliceFilter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRSliceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRSliceFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRSliceFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAMRSliceFilter vtkAMRSliceFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRSliceFilter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRSliceFilter2 = (vtkAMRSliceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRSliceFilter2.Register(null);
			}
		}
		return vtkAMRSliceFilter2;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRSliceFilter_SetController_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get a multiprocess controller for paralle processing.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkAMRSliceFilter_SetController_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRSliceFilter_SetMaxResolution_15(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get the maximum resolution used in this instance.
	/// </summary>
	public virtual void SetMaxResolution(uint _arg)
	{
		vtkAMRSliceFilter_SetMaxResolution_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRSliceFilter_SetNormal_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the Axis normal. The accpetable values are defined in the
	/// NormalTag enum.
	/// </summary>
	public virtual void SetNormal(int _arg)
	{
		vtkAMRSliceFilter_SetNormal_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRSliceFilter_SetOffsetFromOrigin_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the offset-from-origin of the slicing plane.
	/// </summary>
	public virtual void SetOffsetFromOrigin(double _arg)
	{
		vtkAMRSliceFilter_SetOffsetFromOrigin_17(GetCppThis(), _arg);
	}
}
