using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotSurface
/// </summary>
/// <remarks>
///    3D surface plot.
///
///
/// 3D surface plot.
///
/// </remarks>
public class vtkPlotSurface : vtkPlot3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotSurface";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotSurface()
	{
		MRClassNameKey = "class vtkPlotSurface";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotSurface"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotSurface New()
	{
		vtkPlotSurface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotSurface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPlotSurface()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotSurface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotSurface_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotSurface_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotSurface_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotSurface_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotSurface_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotSurface_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotSurface_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotSurface_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotSurface_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotSurface NewInstance()
	{
		vtkPlotSurface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotSurface_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotSurface_Paint_07(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the XY plot, called whenever the chart needs to be drawn
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPlotSurface_Paint_07(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotSurface_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotSurface SafeDownCast(vtkObjectBase o)
	{
		vtkPlotSurface vtkPlotSurface2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotSurface_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotSurface2 = (vtkPlotSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotSurface2.Register(null);
			}
		}
		return vtkPlotSurface2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotSurface_SetInputData_09(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the input to the surface plot.
	/// </summary>
	public override void SetInputData(vtkTable input)
	{
		vtkPlotSurface_SetInputData_09(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotSurface_SetInputData_10(HandleRef pThis, HandleRef input, string xName, string yName, string zName);

	/// <summary>
	/// Set the input to the surface plot.
	/// Do not use these versions of SetInputData, as all the parameters
	/// beyond the vtkTable are ignored.
	/// </summary>
	public override void SetInputData(vtkTable input, string xName, string yName, string zName)
	{
		vtkPlotSurface_SetInputData_10(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), xName, yName, zName);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotSurface_SetInputData_11(HandleRef pThis, HandleRef input, string xName, string yName, string zName, string colorName);

	/// <summary>
	/// Set the input to the surface plot.
	/// Do not use these versions of SetInputData, as all the parameters
	/// beyond the vtkTable are ignored.
	/// </summary>
	public override void SetInputData(vtkTable input, string xName, string yName, string zName, string colorName)
	{
		vtkPlotSurface_SetInputData_11(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), xName, yName, zName, colorName);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotSurface_SetInputData_12(HandleRef pThis, HandleRef input, long xColumn, long yColumn, long zColumn);

	/// <summary>
	/// Set the input to the surface plot.
	/// Do not use these versions of SetInputData, as all the parameters
	/// beyond the vtkTable are ignored.
	/// </summary>
	public override void SetInputData(vtkTable input, long xColumn, long yColumn, long zColumn)
	{
		vtkPlotSurface_SetInputData_12(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), xColumn, yColumn, zColumn);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotSurface_SetXRange_13(HandleRef pThis, float min, float max);

	/// <summary>
	/// Set the range of the input data for the X dimension.  By default it is
	/// (1, NumberOfColumns).  Calling this method after SetInputData() results
	/// in recomputation of the plot's data.  Therefore, it is more efficient
	/// to call it before SetInputData() when possible.
	/// </summary>
	public void SetXRange(float min, float max)
	{
		vtkPlotSurface_SetXRange_13(GetCppThis(), min, max);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotSurface_SetYRange_14(HandleRef pThis, float min, float max);

	/// <summary>
	/// Set the range of the input data for the Y dimension.  By default it is
	/// (1, NumberOfRows).  Calling this method after SetInputData() results
	/// in recomputation of the plot's data.  Therefore, it is more efficient
	/// to call it before SetInputData() when possible.
	/// </summary>
	public void SetYRange(float min, float max)
	{
		vtkPlotSurface_SetYRange_14(GetCppThis(), min, max);
	}
}
