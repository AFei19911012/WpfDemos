using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkColorLegend
/// </summary>
/// <remarks>
///    Legend item to display vtkScalarsToColors.
///
/// vtkColorLegend is an item that will display the vtkScalarsToColors
/// using a 1D texture, and a vtkAxis to show both the color and numerical range.
/// </remarks>
public class vtkColorLegend : vtkChartLegend
{
	/// <summary>
	/// Enum of legend orientation types
	/// </summary>
	public enum HORIZONTAL_WrapperEnum
	{
		/// <summary>enum member</summary>
		HORIZONTAL = 1,
		/// <summary>enum member</summary>
		VERTICAL = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkColorLegend";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkColorLegend()
	{
		MRClassNameKey = "class vtkColorLegend";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorLegend"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkColorLegend(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorLegend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkColorLegend New()
	{
		vtkColorLegend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorLegend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColorLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkColorLegend()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkColorLegend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkColorLegend_DrawBorderOff_01(HandleRef pThis);

	/// <summary>
	/// Toggle whether or not a border should be drawn around this legend.
	/// The default behavior is to not draw a border.
	/// </summary>
	public virtual void DrawBorderOff()
	{
		vtkColorLegend_DrawBorderOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_DrawBorderOn_02(HandleRef pThis);

	/// <summary>
	/// Toggle whether or not a border should be drawn around this legend.
	/// The default behavior is to not draw a border.
	/// </summary>
	public virtual void DrawBorderOn()
	{
		vtkColorLegend_DrawBorderOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorLegend_GetBoundingRect_03(HandleRef pThis, HandleRef painter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Request the space the legend requires to be drawn. This is returned as a
	/// vtkRect4f, with the corner being the offset from Point, and the width/
	/// height being the total width/height required by the axis. In order to
	/// ensure the numbers are correct, Update() should be called first.
	/// </summary>
	public override vtkRectf GetBoundingRect(vtkContext2D painter)
	{
		vtkRectf result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorLegend_GetBoundingRect_03(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_GetBounds_04(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Bounds of the item, by default (0, 1, 0, 1) but it mainly depends on the
	/// range of the vtkScalarsToColors function.
	/// </summary>
	public virtual void GetBounds(IntPtr bounds)
	{
		vtkColorLegend_GetBounds_04(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkColorLegend_GetDrawBorder_05(HandleRef pThis);

	/// <summary>
	/// Toggle whether or not a border should be drawn around this legend.
	/// The default behavior is to not draw a border.
	/// </summary>
	public virtual bool GetDrawBorder()
	{
		return (vtkColorLegend_GetDrawBorder_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorLegend_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkColorLegend_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorLegend_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkColorLegend_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorLegend_GetOrientation_08(HandleRef pThis);

	/// <summary>
	/// Set/get the orientation of the legend.
	/// Valid orientations are VERTICAL (default) and HORIZONTAL.
	/// </summary>
	public virtual int GetOrientation()
	{
		return vtkColorLegend_GetOrientation_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorLegend_GetPosition_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the origin, width, and height of the scalar bar drawn by this
	/// legend.
	/// </summary>
	public virtual vtkRectf GetPosition()
	{
		vtkRectf result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorLegend_GetPosition_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkColorLegend_GetTitle_10(HandleRef pThis);

	/// <summary>
	/// Get/set the title text of the legend.
	/// </summary>
	public virtual string GetTitle()
	{
		return vtkColorLegend_GetTitle_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorLegend_GetTransferFunction_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the transfer function that is used to draw the scalar bar
	/// within this legend.
	/// </summary>
	public virtual vtkScalarsToColors GetTransferFunction()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorLegend_GetTransferFunction_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorLegend_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkColorLegend_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorLegend_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkColorLegend_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorLegend_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkColorLegend NewInstance()
	{
		vtkColorLegend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorLegend_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColorLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkColorLegend_Paint_16(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint the texture into a rectangle defined by the bounds. If
	/// MaskAboveCurve is true and a shape has been provided by a subclass, it
	/// draws the texture into the shape
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkColorLegend_Paint_16(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorLegend_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkColorLegend SafeDownCast(vtkObjectBase o)
	{
		vtkColorLegend vtkColorLegend2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorLegend_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkColorLegend2 = (vtkColorLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkColorLegend2.Register(null);
			}
		}
		return vtkColorLegend2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_SetDrawBorder_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Toggle whether or not a border should be drawn around this legend.
	/// The default behavior is to not draw a border.
	/// </summary>
	public virtual void SetDrawBorder(bool _arg)
	{
		vtkColorLegend_SetDrawBorder_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_SetOrientation_19(HandleRef pThis, int orientation);

	/// <summary>
	/// Set/get the orientation of the legend.
	/// Valid orientations are VERTICAL (default) and HORIZONTAL.
	/// </summary>
	public virtual void SetOrientation(int orientation)
	{
		vtkColorLegend_SetOrientation_19(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_SetPoint_20(HandleRef pThis, float x, float y);

	/// <summary>
	/// Set the point this legend is anchored to.
	/// </summary>
	public override void SetPoint(float x, float y)
	{
		vtkColorLegend_SetPoint_20(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_SetPosition_21(HandleRef pThis, HandleRef pos);

	/// <summary>
	/// Set the origin, width, and height of the scalar bar drawn by this legend.
	/// This method overrides the anchor point, as well as any horizontal and
	/// vertical alignment that has been set for this legend.  If this is a
	/// problem for you, use SetPoint() and SetTextureSize() instead.
	/// </summary>
	public virtual void SetPosition(vtkRectf pos)
	{
		vtkColorLegend_SetPosition_21(GetCppThis(), pos?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_SetTextureSize_22(HandleRef pThis, float w, float h);

	/// <summary>
	/// Set the size of the scalar bar drawn by this legend.
	/// </summary>
	public virtual void SetTextureSize(float w, float h)
	{
		vtkColorLegend_SetTextureSize_22(GetCppThis(), w, h);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_SetTitle_23(HandleRef pThis, string title);

	/// <summary>
	/// Get/set the title text of the legend.
	/// </summary>
	public virtual void SetTitle(string title)
	{
		vtkColorLegend_SetTitle_23(GetCppThis(), title);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_SetTransferFunction_24(HandleRef pThis, HandleRef transfer);

	/// <summary>
	/// Set/Get the transfer function that is used to draw the scalar bar
	/// within this legend.
	/// </summary>
	public virtual void SetTransferFunction(vtkScalarsToColors transfer)
	{
		vtkColorLegend_SetTransferFunction_24(GetCppThis(), transfer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorLegend_Update_25(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// The scene should take care of calling this on all items before their
	/// Paint function is invoked.
	/// </summary>
	public override void Update()
	{
		vtkColorLegend_Update_25(GetCppThis());
	}
}
