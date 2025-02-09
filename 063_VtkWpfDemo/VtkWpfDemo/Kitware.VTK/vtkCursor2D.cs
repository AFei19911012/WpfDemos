using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCursor2D
/// </summary>
/// <remarks>
///    generate a 2D cursor representation
///
/// vtkCursor2D is a class that generates a 2D cursor representation.
/// The cursor consists of two intersection axes lines that meet at the
/// cursor focus. Several optional features are available as well. An
/// optional 2D bounding box may be enabled. An inner radius, centered at
/// the focal point, can be set that erases the intersecting lines (e.g.,
/// it leaves a clear area under the focal point so you can see
/// what you are selecting). And finally, an optional point can be
/// enabled located at the focal point. All of these features can be turned
/// on and off independently.
///
/// </remarks>
public class vtkCursor2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCursor2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCursor2D()
	{
		MRClassNameKey = "class vtkCursor2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCursor2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCursor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with model bounds = (-10,10,-10,10), focal point = (0,0),
	/// radius=2, all parts of cursor visible, and wrapping off.
	/// </summary>
	public new static vtkCursor2D New()
	{
		vtkCursor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCursor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCursor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with model bounds = (-10,10,-10,10), focal point = (0,0),
	/// radius=2, all parts of cursor visible, and wrapping off.
	/// </summary>
	public vtkCursor2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCursor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCursor2D_AllOff_01(HandleRef pThis);

	/// <summary>
	/// Turn every part of the cursor on or off.
	/// </summary>
	public void AllOff()
	{
		vtkCursor2D_AllOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_AllOn_02(HandleRef pThis);

	/// <summary>
	/// Turn every part of the cursor on or off.
	/// </summary>
	public void AllOn()
	{
		vtkCursor2D_AllOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_AxesOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe axes.
	/// </summary>
	public virtual void AxesOff()
	{
		vtkCursor2D_AxesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_AxesOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe axes.
	/// </summary>
	public virtual void AxesOn()
	{
		vtkCursor2D_AxesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor2D_GetAxes_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe axes.
	/// </summary>
	public virtual int GetAxes()
	{
		return vtkCursor2D_GetAxes_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor2D_GetFocalPoint_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of cursor focus. If translation mode is on,
	/// then the entire cursor (including bounding box, cursor, and shadows)
	/// is translated. Otherwise, the focal point will either be clamped to the
	/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
	/// that the bounding box is set prior to the focal point.) Note that the
	/// method takes a 3D point but ignores the z-coordinate value.
	/// </summary>
	public virtual double[] GetFocalPoint()
	{
		IntPtr intPtr = vtkCursor2D_GetFocalPoint_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_GetFocalPoint_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the position of cursor focus. If translation mode is on,
	/// then the entire cursor (including bounding box, cursor, and shadows)
	/// is translated. Otherwise, the focal point will either be clamped to the
	/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
	/// that the bounding box is set prior to the focal point.) Note that the
	/// method takes a 3D point but ignores the z-coordinate value.
	/// </summary>
	public virtual void GetFocalPoint(IntPtr data)
	{
		vtkCursor2D_GetFocalPoint_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor2D_GetModelBounds_08(HandleRef pThis);

	/// <summary>
	/// Set / get the bounding box of the 2D cursor. This defines the outline
	/// of the cursor, and where the focal point should lie.
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkCursor2D_GetModelBounds_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_GetModelBounds_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the bounding box of the 2D cursor. This defines the outline
	/// of the cursor, and where the focal point should lie.
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkCursor2D_GetModelBounds_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCursor2D_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCursor2D_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCursor2D_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCursor2D_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor2D_GetOutline_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public virtual int GetOutline()
	{
		return vtkCursor2D_GetOutline_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor2D_GetPoint_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off the point located at the cursor focus.
	/// </summary>
	public virtual int GetPoint()
	{
		return vtkCursor2D_GetPoint_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCursor2D_GetRadius_14(HandleRef pThis);

	/// <summary>
	/// Specify a radius for a circle. This erases the cursor
	/// lines around the focal point.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkCursor2D_GetRadius_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCursor2D_GetRadiusMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Specify a radius for a circle. This erases the cursor
	/// lines around the focal point.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkCursor2D_GetRadiusMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCursor2D_GetRadiusMinValue_16(HandleRef pThis);

	/// <summary>
	/// Specify a radius for a circle. This erases the cursor
	/// lines around the focal point.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkCursor2D_GetRadiusMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor2D_GetTranslationMode_17(HandleRef pThis);

	/// <summary>
	/// Enable/disable the translation mode. If on, changes in cursor position
	/// cause the entire widget to translate along with the cursor.
	/// By default, translation mode is off.
	/// </summary>
	public virtual int GetTranslationMode()
	{
		return vtkCursor2D_GetTranslationMode_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor2D_GetWrap_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off cursor wrapping. If the cursor focus moves outside the
	/// specified bounds, the cursor will either be restrained against the
	/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
	/// </summary>
	public virtual int GetWrap()
	{
		return vtkCursor2D_GetWrap_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor2D_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCursor2D_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor2D_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCursor2D_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor2D_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCursor2D NewInstance()
	{
		vtkCursor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCursor2D_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCursor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_OutlineOff_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public virtual void OutlineOff()
	{
		vtkCursor2D_OutlineOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_OutlineOn_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public virtual void OutlineOn()
	{
		vtkCursor2D_OutlineOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_PointOff_25(HandleRef pThis);

	/// <summary>
	/// Turn on/off the point located at the cursor focus.
	/// </summary>
	public virtual void PointOff()
	{
		vtkCursor2D_PointOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_PointOn_26(HandleRef pThis);

	/// <summary>
	/// Turn on/off the point located at the cursor focus.
	/// </summary>
	public virtual void PointOn()
	{
		vtkCursor2D_PointOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor2D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCursor2D SafeDownCast(vtkObjectBase o)
	{
		vtkCursor2D vtkCursor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCursor2D_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCursor2D2 = (vtkCursor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCursor2D2.Register(null);
			}
		}
		return vtkCursor2D2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetAxes_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the wireframe axes.
	/// </summary>
	public virtual void SetAxes(int _arg)
	{
		vtkCursor2D_SetAxes_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetFocalPoint_29(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the position of cursor focus. If translation mode is on,
	/// then the entire cursor (including bounding box, cursor, and shadows)
	/// is translated. Otherwise, the focal point will either be clamped to the
	/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
	/// that the bounding box is set prior to the focal point.) Note that the
	/// method takes a 3D point but ignores the z-coordinate value.
	/// </summary>
	public void SetFocalPoint(IntPtr x)
	{
		vtkCursor2D_SetFocalPoint_29(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetFocalPoint_30(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of cursor focus. If translation mode is on,
	/// then the entire cursor (including bounding box, cursor, and shadows)
	/// is translated. Otherwise, the focal point will either be clamped to the
	/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
	/// that the bounding box is set prior to the focal point.) Note that the
	/// method takes a 3D point but ignores the z-coordinate value.
	/// </summary>
	public void SetFocalPoint(double x, double y, double z)
	{
		vtkCursor2D_SetFocalPoint_30(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetModelBounds_31(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Set / get the bounding box of the 2D cursor. This defines the outline
	/// of the cursor, and where the focal point should lie.
	/// </summary>
	public void SetModelBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkCursor2D_SetModelBounds_31(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetModelBounds_32(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Set / get the bounding box of the 2D cursor. This defines the outline
	/// of the cursor, and where the focal point should lie.
	/// </summary>
	public void SetModelBounds(IntPtr bounds)
	{
		vtkCursor2D_SetModelBounds_32(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetOutline_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public virtual void SetOutline(int _arg)
	{
		vtkCursor2D_SetOutline_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetPoint_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the point located at the cursor focus.
	/// </summary>
	public virtual void SetPoint(int _arg)
	{
		vtkCursor2D_SetPoint_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetRadius_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a radius for a circle. This erases the cursor
	/// lines around the focal point.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkCursor2D_SetRadius_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetTranslationMode_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the translation mode. If on, changes in cursor position
	/// cause the entire widget to translate along with the cursor.
	/// By default, translation mode is off.
	/// </summary>
	public virtual void SetTranslationMode(int _arg)
	{
		vtkCursor2D_SetTranslationMode_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_SetWrap_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off cursor wrapping. If the cursor focus moves outside the
	/// specified bounds, the cursor will either be restrained against the
	/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
	/// </summary>
	public virtual void SetWrap(int _arg)
	{
		vtkCursor2D_SetWrap_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_TranslationModeOff_38(HandleRef pThis);

	/// <summary>
	/// Enable/disable the translation mode. If on, changes in cursor position
	/// cause the entire widget to translate along with the cursor.
	/// By default, translation mode is off.
	/// </summary>
	public virtual void TranslationModeOff()
	{
		vtkCursor2D_TranslationModeOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_TranslationModeOn_39(HandleRef pThis);

	/// <summary>
	/// Enable/disable the translation mode. If on, changes in cursor position
	/// cause the entire widget to translate along with the cursor.
	/// By default, translation mode is off.
	/// </summary>
	public virtual void TranslationModeOn()
	{
		vtkCursor2D_TranslationModeOn_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_WrapOff_40(HandleRef pThis);

	/// <summary>
	/// Turn on/off cursor wrapping. If the cursor focus moves outside the
	/// specified bounds, the cursor will either be restrained against the
	/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
	/// </summary>
	public virtual void WrapOff()
	{
		vtkCursor2D_WrapOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor2D_WrapOn_41(HandleRef pThis);

	/// <summary>
	/// Turn on/off cursor wrapping. If the cursor focus moves outside the
	/// specified bounds, the cursor will either be restrained against the
	/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
	/// </summary>
	public virtual void WrapOn()
	{
		vtkCursor2D_WrapOn_41(GetCppThis());
	}
}
