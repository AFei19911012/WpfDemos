using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotPie
/// </summary>
/// <remarks>
///    Class for drawing a Pie diagram.
///
///
/// </remarks>
public class vtkPlotPie : vtkPlot
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotPie";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotPie()
	{
		MRClassNameKey = "class vtkPlotPie";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotPie"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotPie(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotPie_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotPie New()
	{
		vtkPlotPie result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotPie_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotPie)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPlotPie()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotPie_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlotPie_GetColorSeries_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color series used.
	/// </summary>
	public vtkColorSeries GetColorSeries()
	{
		vtkColorSeries vtkColorSeries2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotPie_GetColorSeries_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkColorSeries2 = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkColorSeries2.Register(null);
			}
		}
		return vtkColorSeries2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotPie_GetDimensions_02(HandleRef pThis);

	/// <summary>
	/// Get the dimensions of the pie, elements 0 and 1 are the x and y coordinate
	/// of the bottom corner. Elements 2 and 3 are the width and height.
	/// </summary>
	public virtual int[] GetDimensions()
	{
		IntPtr intPtr = vtkPlotPie_GetDimensions_02(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPie_GetDimensions_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4);

	/// <summary>
	/// Get the dimensions of the pie, elements 0 and 1 are the x and y coordinate
	/// of the bottom corner. Elements 2 and 3 are the width and height.
	/// </summary>
	public virtual void GetDimensions(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4)
	{
		vtkPlotPie_GetDimensions_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPie_GetDimensions_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the dimensions of the pie, elements 0 and 1 are the x and y coordinate
	/// of the bottom corner. Elements 2 and 3 are the width and height.
	/// </summary>
	public virtual void GetDimensions(IntPtr _arg)
	{
		vtkPlotPie_GetDimensions_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotPie_GetNearestPoint_05(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

	/// <summary>
	/// Function to query a plot for the nearest point to the specified coordinate.
	/// Returns the index of the data series with which the point is associated or
	/// -1.
	/// </summary>
	public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
	{
		return vtkPlotPie_GetNearestPoint_05(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), tolerance?.GetCppThis() ?? default(HandleRef), location?.GetCppThis() ?? default(HandleRef), segmentId);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotPie_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotPie_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotPie_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotPie_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotPie_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotPie_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotPie_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotPie_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotPie_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotPie NewInstance()
	{
		vtkPlotPie result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotPie_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotPie)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotPie_Paint_12(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the item.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPlotPie_Paint_12(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotPie_PaintLegend_13(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

	/// <summary>
	/// Paint legend event for the XY plot, called whenever the legend needs the
	/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
	/// corner of the rect (elements 0 and 1) and with width x height (elements 2
	/// and 3). The plot can choose how to fill the space supplied.
	/// </summary>
	public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
	{
		return (vtkPlotPie_PaintLegend_13(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), rect?.GetCppThis() ?? default(HandleRef), legendIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotPie_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotPie SafeDownCast(vtkObjectBase o)
	{
		vtkPlotPie vtkPlotPie2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotPie_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotPie2 = (vtkPlotPie)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotPie2.Register(null);
			}
		}
		return vtkPlotPie2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPie_SetColorSeries_15(HandleRef pThis, HandleRef colorSeries);

	/// <summary>
	/// Set the color series to use for the Pie.
	/// </summary>
	public void SetColorSeries(vtkColorSeries colorSeries)
	{
		vtkPlotPie_SetColorSeries_15(GetCppThis(), colorSeries?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPie_SetDimensions_16(HandleRef pThis, int arg1, int arg2, int arg3, int arg4);

	/// <summary>
	/// Set the dimensions of the pie, arguments 1 and 2 are the x and y coordinate
	/// of the bottom corner. Arguments 3 and 4 are the width and height.
	/// </summary>
	public void SetDimensions(int arg1, int arg2, int arg3, int arg4)
	{
		vtkPlotPie_SetDimensions_16(GetCppThis(), arg1, arg2, arg3, arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPie_SetDimensions_17(HandleRef pThis, IntPtr arg);

	/// <summary>
	/// Set the dimensions of the pie, elements 0 and 1 are the x and y coordinate
	/// of the bottom corner. Elements 2 and 3 are the width and height.
	/// </summary>
	public void SetDimensions(IntPtr arg)
	{
		vtkPlotPie_SetDimensions_17(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotPie_UpdateCache_18(HandleRef pThis);

	/// <summary>
	/// Update the internal cache. Returns true if cache was successfully updated. Default does
	/// nothing.
	/// This method is called by Update() when either the plot's data has changed or
	/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
	/// </summary>
	public override bool UpdateCache()
	{
		return (vtkPlotPie_UpdateCache_18(GetCppThis()) != 0) ? true : false;
	}
}
