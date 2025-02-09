using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHeatmapItem
/// </summary>
/// <remarks>
///    A 2D graphics item for rendering a heatmap
///
///
/// This item draws a heatmap as a part of a vtkContextScene.
///
/// .SEE ALSO
/// vtkTable
/// </remarks>
public class vtkHeatmapItem : vtkContextItem
{
	/// <summary>
	/// Enum for Orientation.
	/// </summary>
	public enum DOWN_TO_UP_WrapperEnum
	{
		/// <summary>enum member</summary>
		DOWN_TO_UP = 3,
		/// <summary>enum member</summary>
		LEFT_TO_RIGHT = 0,
		/// <summary>enum member</summary>
		RIGHT_TO_LEFT = 2,
		/// <summary>enum member</summary>
		UP_TO_DOWN = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHeatmapItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHeatmapItem()
	{
		MRClassNameKey = "class vtkHeatmapItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHeatmapItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHeatmapItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeatmapItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHeatmapItem New()
	{
		vtkHeatmapItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHeatmapItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHeatmapItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHeatmapItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHeatmapItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this item as (Xmin,Xmax,Ymin,Ymax).
	/// </summary>
	public virtual void GetBounds(IntPtr bounds)
	{
		vtkHeatmapItem_GetBounds_01(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHeatmapItem_GetCellHeight_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the height of the cells in our heatmap.
	/// Default is 18 pixels.
	/// </summary>
	public virtual double GetCellHeight()
	{
		return vtkHeatmapItem_GetCellHeight_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHeatmapItem_GetCellWidth_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the width of the cells in our heatmap.
	/// Default is 36 pixels.
	/// </summary>
	public virtual double GetCellWidth()
	{
		return vtkHeatmapItem_GetCellWidth_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkHeatmapItem_GetColumnLabelWidth_04(HandleRef pThis);

	/// <summary>
	/// Get the width of the largest row or column label drawn by this
	/// heatmap.
	/// </summary>
	public virtual float GetColumnLabelWidth()
	{
		return vtkHeatmapItem_GetColumnLabelWidth_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkHeatmapItem_GetNameColumn_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the column that specifies the name
	/// of this table's rows.  By default, we assume this
	/// column will be named "name".  If no such column can be
	/// found, we then assume that the 1st column in the table
	/// names the rows.
	/// </summary>
	public virtual string GetNameColumn()
	{
		return vtkHeatmapItem_GetNameColumn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHeatmapItem_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHeatmapItem_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHeatmapItem_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHeatmapItem_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHeatmapItem_GetOrientation_08(HandleRef pThis);

	/// <summary>
	/// Get the current heatmap orientation.
	/// </summary>
	public int GetOrientation()
	{
		return vtkHeatmapItem_GetOrientation_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeatmapItem_GetPosition_09(HandleRef pThis);

	/// <summary>
	/// Get position of the heatmap.
	/// </summary>
	public virtual float[] GetPosition()
	{
		IntPtr intPtr = vtkHeatmapItem_GetPosition_09(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_GetPosition_10(HandleRef pThis, ref float _arg1, ref float _arg2);

	/// <summary>
	/// Get position of the heatmap.
	/// </summary>
	public virtual void GetPosition(ref float _arg1, ref float _arg2)
	{
		vtkHeatmapItem_GetPosition_10(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_GetPosition_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get position of the heatmap.
	/// </summary>
	public virtual void GetPosition(IntPtr _arg)
	{
		vtkHeatmapItem_GetPosition_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeatmapItem_GetPositionVector_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get position of the heatmap.
	/// </summary>
	public vtkVector2f GetPositionVector()
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHeatmapItem_GetPositionVector_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkHeatmapItem_GetRowLabelWidth_13(HandleRef pThis);

	/// <summary>
	/// Get the width of the largest row or column label drawn by this
	/// heatmap.
	/// </summary>
	public virtual float GetRowLabelWidth()
	{
		return vtkHeatmapItem_GetRowLabelWidth_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeatmapItem_GetRowNames_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the table that this item draws.
	/// </summary>
	public vtkStringArray GetRowNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHeatmapItem_GetRowNames_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeatmapItem_GetTable_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the table that this item draws.
	/// </summary>
	public vtkTable GetTable()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHeatmapItem_GetTable_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHeatmapItem_GetTextAngleForOrientation_16(HandleRef pThis, int orientation);

	/// <summary>
	/// Get the angle that row labels should be rotated for the corresponding
	/// heatmap orientation.  For the default orientation (LEFT_TO_RIGHT), this
	/// is 0 degrees.
	/// </summary>
	public double GetTextAngleForOrientation(int orientation)
	{
		return vtkHeatmapItem_GetTextAngleForOrientation_16(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHeatmapItem_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHeatmapItem_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHeatmapItem_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHeatmapItem_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_MarkRowAsBlank_19(HandleRef pThis, string rowName);

	/// <summary>
	/// Mark a row as blank, meaning that no cells will be drawn for it.
	/// Used by vtkTreeHeatmapItem to represent missing data.
	/// </summary>
	public void MarkRowAsBlank(string rowName)
	{
		vtkHeatmapItem_MarkRowAsBlank_19(GetCppThis(), rowName);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeatmapItem_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHeatmapItem NewInstance()
	{
		vtkHeatmapItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHeatmapItem_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHeatmapItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHeatmapItem_Paint_22(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paints the table as a heatmap.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkHeatmapItem_Paint_22(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeatmapItem_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHeatmapItem SafeDownCast(vtkObjectBase o)
	{
		vtkHeatmapItem vtkHeatmapItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHeatmapItem_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHeatmapItem2 = (vtkHeatmapItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHeatmapItem2.Register(null);
			}
		}
		return vtkHeatmapItem2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_SetCellHeight_24(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the height of the cells in our heatmap.
	/// Default is 18 pixels.
	/// </summary>
	public virtual void SetCellHeight(double _arg)
	{
		vtkHeatmapItem_SetCellHeight_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_SetCellWidth_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the width of the cells in our heatmap.
	/// Default is 36 pixels.
	/// </summary>
	public virtual void SetCellWidth(double _arg)
	{
		vtkHeatmapItem_SetCellWidth_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_SetNameColumn_26(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the column that specifies the name
	/// of this table's rows.  By default, we assume this
	/// column will be named "name".  If no such column can be
	/// found, we then assume that the 1st column in the table
	/// names the rows.
	/// </summary>
	public virtual void SetNameColumn(string _arg)
	{
		vtkHeatmapItem_SetNameColumn_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_SetOrientation_27(HandleRef pThis, int orientation);

	/// <summary>
	/// Set which way the table should face within the visualization.
	/// </summary>
	public void SetOrientation(int orientation)
	{
		vtkHeatmapItem_SetOrientation_27(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_SetPosition_28(HandleRef pThis, float _arg1, float _arg2);

	/// <summary>
	/// Set the position of the heatmap.
	/// </summary>
	public virtual void SetPosition(float _arg1, float _arg2)
	{
		vtkHeatmapItem_SetPosition_28(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_SetPosition_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the position of the heatmap.
	/// </summary>
	public void SetPosition(IntPtr _arg)
	{
		vtkHeatmapItem_SetPosition_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_SetPosition_30(HandleRef pThis, HandleRef pos);

	/// <summary>
	/// Set the position of the heatmap.
	/// </summary>
	public void SetPosition(vtkVector2f pos)
	{
		vtkHeatmapItem_SetPosition_30(GetCppThis(), pos?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeatmapItem_SetTable_31(HandleRef pThis, HandleRef table);

	/// <summary>
	/// Set the table that this item draws.  The first column of the table
	/// must contain the names of the rows.
	/// </summary>
	public virtual void SetTable(vtkTable table)
	{
		vtkHeatmapItem_SetTable_31(GetCppThis(), table?.GetCppThis() ?? default(HandleRef));
	}
}
