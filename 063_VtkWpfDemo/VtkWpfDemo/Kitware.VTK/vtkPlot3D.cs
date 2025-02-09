using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlot3D
/// </summary>
/// <remarks>
///    Abstract class for 3D plots.
///
///
/// The base class for all plot types used in vtkChart derived charts.
///
/// </remarks>
/// <seealso>
///
/// vtkPlot3DPoints vtkPlot3DLine vtkPlot3DBar vtkChart vtkChartXY
/// </seealso>
public class vtkPlot3D : vtkContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlot3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlot3D()
	{
		MRClassNameKey = "class vtkPlot3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlot3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlot3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot3D_GetChart_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/set the chart for this plot.
	/// </summary>
	public virtual vtkChartXYZ GetChart()
	{
		vtkChartXYZ vtkChartXYZ2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot3D_GetChart_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChartXYZ2 = (vtkChartXYZ)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChartXYZ2.Register(null);
			}
		}
		return vtkChartXYZ2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlot3D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlot3D_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlot3D_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlot3D_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot3D_GetPen_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws (out)lines.
	/// </summary>
	public vtkPen GetPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot3D_GetPen_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPen2 = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPen2.Register(null);
			}
		}
		return vtkPen2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot3D_GetSelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the selection array for the plot.
	/// </summary>
	public virtual vtkIdTypeArray GetSelection()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot3D_GetSelection_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot3D_GetSelectionPen_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws (out)lines.
	/// </summary>
	public vtkPen GetSelectionPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot3D_GetSelectionPen_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPen2 = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPen2.Register(null);
			}
		}
		return vtkPen2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlot3D_GetXAxisLabel_07(HandleRef pThis);

	/// <summary>
	/// Get the label for the X axis.
	/// </summary>
	public string GetXAxisLabel()
	{
		return vtkPlot3D_GetXAxisLabel_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlot3D_GetYAxisLabel_08(HandleRef pThis);

	/// <summary>
	/// Get the label for the Y axis.
	/// </summary>
	public string GetYAxisLabel()
	{
		return vtkPlot3D_GetYAxisLabel_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlot3D_GetZAxisLabel_09(HandleRef pThis);

	/// <summary>
	/// Get the label for the Z axis.
	/// </summary>
	public string GetZAxisLabel()
	{
		return vtkPlot3D_GetZAxisLabel_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlot3D_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlot3D_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlot3D_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlot3D_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot3D_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlot3D NewInstance()
	{
		vtkPlot3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot3D_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlot3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot3D_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlot3D SafeDownCast(vtkObjectBase o)
	{
		vtkPlot3D vtkPlot3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot3D_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlot3D2 = (vtkPlot3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlot3D2.Register(null);
			}
		}
		return vtkPlot3D2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3D_SetChart_14(HandleRef pThis, HandleRef chart);

	/// <summary>
	/// Get/set the chart for this plot.
	/// </summary>
	public virtual void SetChart(vtkChartXYZ chart)
	{
		vtkPlot3D_SetChart_14(GetCppThis(), chart?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3D_SetColors_15(HandleRef pThis, HandleRef colorArr);

	/// <summary>
	/// Set the color of each point in the plot.  The input is a single component
	/// scalar array.  The values of this array will be passed through a lookup
	/// table to generate the color for each data point in the plot.
	/// </summary>
	public virtual void SetColors(vtkDataArray colorArr)
	{
		vtkPlot3D_SetColors_15(GetCppThis(), colorArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3D_SetInputData_16(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the input to the plot.
	/// </summary>
	public virtual void SetInputData(vtkTable input)
	{
		vtkPlot3D_SetInputData_16(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3D_SetInputData_17(HandleRef pThis, HandleRef input, string xName, string yName, string zName);

	/// <summary>
	/// Set the input to the plot.
	/// </summary>
	public virtual void SetInputData(vtkTable input, string xName, string yName, string zName)
	{
		vtkPlot3D_SetInputData_17(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), xName, yName, zName);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3D_SetInputData_18(HandleRef pThis, HandleRef input, string xName, string yName, string zName, string colorName);

	/// <summary>
	/// Set the input to the plot.
	/// </summary>
	public virtual void SetInputData(vtkTable input, string xName, string yName, string zName, string colorName)
	{
		vtkPlot3D_SetInputData_18(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), xName, yName, zName, colorName);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3D_SetInputData_19(HandleRef pThis, HandleRef input, long xColumn, long yColumn, long zColumn);

	/// <summary>
	/// Set the input to the plot.
	/// </summary>
	public virtual void SetInputData(vtkTable input, long xColumn, long yColumn, long zColumn)
	{
		vtkPlot3D_SetInputData_19(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), xColumn, yColumn, zColumn);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3D_SetPen_20(HandleRef pThis, HandleRef pen);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws (out)lines.
	/// </summary>
	public void SetPen(vtkPen pen)
	{
		vtkPlot3D_SetPen_20(GetCppThis(), pen?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3D_SetSelection_21(HandleRef pThis, HandleRef id);

	/// <summary>
	/// Set/get the selection array for the plot.
	/// </summary>
	public virtual void SetSelection(vtkIdTypeArray id)
	{
		vtkPlot3D_SetSelection_21(GetCppThis(), id?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot3D_SetSelectionPen_22(HandleRef pThis, HandleRef pen);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws (out)lines.
	/// </summary>
	public void SetSelectionPen(vtkPen pen)
	{
		vtkPlot3D_SetSelectionPen_22(GetCppThis(), pen?.GetCppThis() ?? default(HandleRef));
	}
}
