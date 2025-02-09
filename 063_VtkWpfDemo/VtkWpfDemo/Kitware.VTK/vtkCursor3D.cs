using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCursor3D
/// </summary>
/// <remarks>
///    generate a 3D cursor representation
///
/// vtkCursor3D is an object that generates a 3D representation of a cursor.
/// The cursor consists of a wireframe bounding box, three intersecting
/// axes lines that meet at the cursor focus, and "shadows" or projections
/// of the axes against the sides of the bounding box. Each of these
/// components can be turned on/off.
///
/// This filter generates two output datasets. The first (Output) is just the
/// geometric representation of the cursor. The second (Focus) is a single
/// point at the focal point.
/// </remarks>
public class vtkCursor3D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCursor3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCursor3D()
	{
		MRClassNameKey = "class vtkCursor3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCursor3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCursor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with model bounds = (-1,1,-1,1,-1,1), focal point = (0,0,0),
	/// all parts of cursor visible, and wrapping off.
	/// </summary>
	public new static vtkCursor3D New()
	{
		vtkCursor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCursor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with model bounds = (-1,1,-1,1,-1,1), focal point = (0,0,0),
	/// all parts of cursor visible, and wrapping off.
	/// </summary>
	public vtkCursor3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCursor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCursor3D_AllOff_01(HandleRef pThis);

	/// <summary>
	/// Turn every part of the 3D cursor on or off.
	/// </summary>
	public void AllOff()
	{
		vtkCursor3D_AllOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_AllOn_02(HandleRef pThis);

	/// <summary>
	/// Turn every part of the 3D cursor on or off.
	/// </summary>
	public void AllOn()
	{
		vtkCursor3D_AllOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_AxesOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe axes.
	/// </summary>
	public virtual void AxesOff()
	{
		vtkCursor3D_AxesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_AxesOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe axes.
	/// </summary>
	public virtual void AxesOn()
	{
		vtkCursor3D_AxesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor3D_GetAxes_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe axes.
	/// </summary>
	public virtual int GetAxes()
	{
		return vtkCursor3D_GetAxes_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor3D_GetFocalPoint_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of cursor focus. If translation mode is on,
	/// then the entire cursor (including bounding box, cursor, and shadows)
	/// is translated. Otherwise, the focal point will either be clamped to the
	/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
	/// that the bounding box is set prior to the focal point.)
	/// </summary>
	public virtual double[] GetFocalPoint()
	{
		IntPtr intPtr = vtkCursor3D_GetFocalPoint_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_GetFocalPoint_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the position of cursor focus. If translation mode is on,
	/// then the entire cursor (including bounding box, cursor, and shadows)
	/// is translated. Otherwise, the focal point will either be clamped to the
	/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
	/// that the bounding box is set prior to the focal point.)
	/// </summary>
	public virtual void GetFocalPoint(IntPtr data)
	{
		vtkCursor3D_GetFocalPoint_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor3D_GetFocus_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the focus for this filter.
	/// </summary>
	public vtkPolyData GetFocus()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCursor3D_GetFocus_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor3D_GetModelBounds_09(HandleRef pThis);

	/// <summary>
	/// Set / get the boundary of the 3D cursor.
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkCursor3D_GetModelBounds_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_GetModelBounds_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the boundary of the 3D cursor.
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkCursor3D_GetModelBounds_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCursor3D_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCursor3D_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCursor3D_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCursor3D_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor3D_GetOutline_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public virtual int GetOutline()
	{
		return vtkCursor3D_GetOutline_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor3D_GetTranslationMode_14(HandleRef pThis);

	/// <summary>
	/// Enable/disable the translation mode. If on, changes in cursor position
	/// cause the entire widget to translate along with the cursor.
	/// By default, translation mode is off.
	/// </summary>
	public virtual int GetTranslationMode()
	{
		return vtkCursor3D_GetTranslationMode_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor3D_GetWrap_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off cursor wrapping. If the cursor focus moves outside the
	/// specified bounds, the cursor will either be restrained against the
	/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
	/// </summary>
	public virtual int GetWrap()
	{
		return vtkCursor3D_GetWrap_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor3D_GetXShadows_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public virtual int GetXShadows()
	{
		return vtkCursor3D_GetXShadows_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor3D_GetYShadows_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public virtual int GetYShadows()
	{
		return vtkCursor3D_GetYShadows_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor3D_GetZShadows_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public virtual int GetZShadows()
	{
		return vtkCursor3D_GetZShadows_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor3D_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCursor3D_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCursor3D_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCursor3D_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor3D_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCursor3D NewInstance()
	{
		vtkCursor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCursor3D_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_OutlineOff_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public virtual void OutlineOff()
	{
		vtkCursor3D_OutlineOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_OutlineOn_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public virtual void OutlineOn()
	{
		vtkCursor3D_OutlineOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCursor3D_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCursor3D SafeDownCast(vtkObjectBase o)
	{
		vtkCursor3D vtkCursor3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCursor3D_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCursor3D2 = (vtkCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCursor3D2.Register(null);
			}
		}
		return vtkCursor3D2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetAxes_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the wireframe axes.
	/// </summary>
	public virtual void SetAxes(int _arg)
	{
		vtkCursor3D_SetAxes_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetFocalPoint_27(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the position of cursor focus. If translation mode is on,
	/// then the entire cursor (including bounding box, cursor, and shadows)
	/// is translated. Otherwise, the focal point will either be clamped to the
	/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
	/// that the bounding box is set prior to the focal point.)
	/// </summary>
	public void SetFocalPoint(IntPtr x)
	{
		vtkCursor3D_SetFocalPoint_27(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetFocalPoint_28(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of cursor focus. If translation mode is on,
	/// then the entire cursor (including bounding box, cursor, and shadows)
	/// is translated. Otherwise, the focal point will either be clamped to the
	/// bounding box, or wrapped, if Wrap is on. (Note: this behavior requires
	/// that the bounding box is set prior to the focal point.)
	/// </summary>
	public void SetFocalPoint(double x, double y, double z)
	{
		vtkCursor3D_SetFocalPoint_28(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetModelBounds_29(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Set / get the boundary of the 3D cursor.
	/// </summary>
	public void SetModelBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkCursor3D_SetModelBounds_29(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetModelBounds_30(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Set / get the boundary of the 3D cursor.
	/// </summary>
	public void SetModelBounds(IntPtr bounds)
	{
		vtkCursor3D_SetModelBounds_30(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetOutline_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public virtual void SetOutline(int _arg)
	{
		vtkCursor3D_SetOutline_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetTranslationMode_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the translation mode. If on, changes in cursor position
	/// cause the entire widget to translate along with the cursor.
	/// By default, translation mode is off.
	/// </summary>
	public virtual void SetTranslationMode(int _arg)
	{
		vtkCursor3D_SetTranslationMode_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetWrap_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off cursor wrapping. If the cursor focus moves outside the
	/// specified bounds, the cursor will either be restrained against the
	/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
	/// </summary>
	public virtual void SetWrap(int _arg)
	{
		vtkCursor3D_SetWrap_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetXShadows_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public virtual void SetXShadows(int _arg)
	{
		vtkCursor3D_SetXShadows_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetYShadows_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public virtual void SetYShadows(int _arg)
	{
		vtkCursor3D_SetYShadows_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_SetZShadows_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public virtual void SetZShadows(int _arg)
	{
		vtkCursor3D_SetZShadows_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_TranslationModeOff_37(HandleRef pThis);

	/// <summary>
	/// Enable/disable the translation mode. If on, changes in cursor position
	/// cause the entire widget to translate along with the cursor.
	/// By default, translation mode is off.
	/// </summary>
	public virtual void TranslationModeOff()
	{
		vtkCursor3D_TranslationModeOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_TranslationModeOn_38(HandleRef pThis);

	/// <summary>
	/// Enable/disable the translation mode. If on, changes in cursor position
	/// cause the entire widget to translate along with the cursor.
	/// By default, translation mode is off.
	/// </summary>
	public virtual void TranslationModeOn()
	{
		vtkCursor3D_TranslationModeOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_WrapOff_39(HandleRef pThis);

	/// <summary>
	/// Turn on/off cursor wrapping. If the cursor focus moves outside the
	/// specified bounds, the cursor will either be restrained against the
	/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
	/// </summary>
	public virtual void WrapOff()
	{
		vtkCursor3D_WrapOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_WrapOn_40(HandleRef pThis);

	/// <summary>
	/// Turn on/off cursor wrapping. If the cursor focus moves outside the
	/// specified bounds, the cursor will either be restrained against the
	/// nearest "wall" (Wrap=off), or it will wrap around (Wrap=on).
	/// </summary>
	public virtual void WrapOn()
	{
		vtkCursor3D_WrapOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_XShadowsOff_41(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public virtual void XShadowsOff()
	{
		vtkCursor3D_XShadowsOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_XShadowsOn_42(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public virtual void XShadowsOn()
	{
		vtkCursor3D_XShadowsOn_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_YShadowsOff_43(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public virtual void YShadowsOff()
	{
		vtkCursor3D_YShadowsOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_YShadowsOn_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public virtual void YShadowsOn()
	{
		vtkCursor3D_YShadowsOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_ZShadowsOff_45(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public virtual void ZShadowsOff()
	{
		vtkCursor3D_ZShadowsOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCursor3D_ZShadowsOn_46(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public virtual void ZShadowsOn()
	{
		vtkCursor3D_ZShadowsOn_46(GetCppThis());
	}
}
