using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIconGlyphFilter
/// </summary>
/// <remarks>
///    Filter that generates a polydata consisting of
/// quads with texture coordinates referring to a set of icons within a sheet
/// of icons.
///
/// vtkIconGlyphFilter takes in a vtkPointSet where each point corresponds to
/// the center of an icon. Scalar integer data must also be set to give each
/// point an icon index. This index is a zero based row major index into an
/// image that contains a grid of icons (each icon is the same size). You must
/// also specify 1) the size of the icon in the icon sheet (in pixels), 2) the
/// size of the icon sheet (in pixels), and 3) the display size of each icon
/// (again in display coordinates, or pixels).
///
/// Various other parameters are used to control how this data is combined. If
/// UseIconSize is true then the DisplaySize is ignored. If PassScalars is true,
/// then the scalar index information is passed to the output. Also, there is an
/// optional IconScale array which, if UseIconScaling is on, will scale each icon
/// independently.
///
/// </remarks>
/// <seealso>
///
/// vtkPolyDataAlgorithm vtkGlyph3D vtkGlyph2D
/// </seealso>
public class vtkIconGlyphFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIconGlyphFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIconGlyphFilter()
	{
		MRClassNameKey = "class vtkIconGlyphFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIconGlyphFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIconGlyphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIconGlyphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkIconGlyphFilter New()
	{
		vtkIconGlyphFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIconGlyphFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIconGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public vtkIconGlyphFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIconGlyphFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkIconGlyphFilter_GetDisplaySize_01(HandleRef pThis);

	/// <summary>
	/// Specify the Width and Height, in pixels, of the size of the icon when it
	/// is rendered. By default, the IconSize is used to set the display size
	/// (i.e., UseIconSize is true by default). Note that assumes that
	/// IconScaling is disabled, or if enabled, the scale of a particular icon
	/// is 1.
	/// </summary>
	public virtual int[] GetDisplaySize()
	{
		IntPtr intPtr = vtkIconGlyphFilter_GetDisplaySize_01(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_GetDisplaySize_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the Width and Height, in pixels, of the size of the icon when it
	/// is rendered. By default, the IconSize is used to set the display size
	/// (i.e., UseIconSize is true by default). Note that assumes that
	/// IconScaling is disabled, or if enabled, the scale of a particular icon
	/// is 1.
	/// </summary>
	public virtual void GetDisplaySize(IntPtr data)
	{
		vtkIconGlyphFilter_GetDisplaySize_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIconGlyphFilter_GetGravity_03(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public virtual int GetGravity()
	{
		return vtkIconGlyphFilter_GetGravity_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIconGlyphFilter_GetIconScaling_04(HandleRef pThis);

	/// <summary>
	/// Specify how to specify individual icons. By default, icon scaling
	/// is off, but if it is on, then the filter looks for an array named
	/// "IconScale" to control individual icon size.
	/// </summary>
	public virtual int GetIconScaling()
	{
		return vtkIconGlyphFilter_GetIconScaling_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIconGlyphFilter_GetIconSheetSize_05(HandleRef pThis);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public virtual int[] GetIconSheetSize()
	{
		IntPtr intPtr = vtkIconGlyphFilter_GetIconSheetSize_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_GetIconSheetSize_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public virtual void GetIconSheetSize(IntPtr data)
	{
		vtkIconGlyphFilter_GetIconSheetSize_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIconGlyphFilter_GetIconSize_07(HandleRef pThis);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public virtual int[] GetIconSize()
	{
		IntPtr intPtr = vtkIconGlyphFilter_GetIconSize_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_GetIconSize_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public virtual void GetIconSize(IntPtr data)
	{
		vtkIconGlyphFilter_GetIconSize_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIconGlyphFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIconGlyphFilter_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIconGlyphFilter_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIconGlyphFilter_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIconGlyphFilter_GetOffset_11(HandleRef pThis);

	/// <summary>
	/// Specify an offset (in pixels or display coordinates) that offsets the icons
	/// from their generating points.
	/// </summary>
	public virtual int[] GetOffset()
	{
		IntPtr intPtr = vtkIconGlyphFilter_GetOffset_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_GetOffset_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify an offset (in pixels or display coordinates) that offsets the icons
	/// from their generating points.
	/// </summary>
	public virtual void GetOffset(IntPtr data)
	{
		vtkIconGlyphFilter_GetOffset_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIconGlyphFilter_GetPassScalars_13(HandleRef pThis);

	/// <summary>
	/// Specify whether to pass the scalar icon index to the output. By
	/// default this is not passed since it can affect color during the
	/// rendering process. Note that all other point data is passed to
	/// the output regardless of the value of this flag.
	/// </summary>
	public virtual bool GetPassScalars()
	{
		return (vtkIconGlyphFilter_GetPassScalars_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIconGlyphFilter_GetUseIconSize_14(HandleRef pThis);

	/// <summary>
	/// Specify whether the Quad generated to place the icon on will be either
	/// the dimensions specified by IconSize or the DisplaySize.
	/// </summary>
	public virtual bool GetUseIconSize()
	{
		return (vtkIconGlyphFilter_GetUseIconSize_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIconGlyphFilter_IsA_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIconGlyphFilter_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIconGlyphFilter_IsTypeOf_16(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIconGlyphFilter_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIconGlyphFilter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkIconGlyphFilter NewInstance()
	{
		vtkIconGlyphFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIconGlyphFilter_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIconGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_PassScalarsOff_19(HandleRef pThis);

	/// <summary>
	/// Specify whether to pass the scalar icon index to the output. By
	/// default this is not passed since it can affect color during the
	/// rendering process. Note that all other point data is passed to
	/// the output regardless of the value of this flag.
	/// </summary>
	public virtual void PassScalarsOff()
	{
		vtkIconGlyphFilter_PassScalarsOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_PassScalarsOn_20(HandleRef pThis);

	/// <summary>
	/// Specify whether to pass the scalar icon index to the output. By
	/// default this is not passed since it can affect color during the
	/// rendering process. Note that all other point data is passed to
	/// the output regardless of the value of this flag.
	/// </summary>
	public virtual void PassScalarsOn()
	{
		vtkIconGlyphFilter_PassScalarsOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIconGlyphFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkIconGlyphFilter SafeDownCast(vtkObjectBase o)
	{
		vtkIconGlyphFilter vtkIconGlyphFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIconGlyphFilter_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIconGlyphFilter2 = (vtkIconGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIconGlyphFilter2.Register(null);
			}
		}
		return vtkIconGlyphFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetDisplaySize_22(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify the Width and Height, in pixels, of the size of the icon when it
	/// is rendered. By default, the IconSize is used to set the display size
	/// (i.e., UseIconSize is true by default). Note that assumes that
	/// IconScaling is disabled, or if enabled, the scale of a particular icon
	/// is 1.
	/// </summary>
	public virtual void SetDisplaySize(int _arg1, int _arg2)
	{
		vtkIconGlyphFilter_SetDisplaySize_22(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetDisplaySize_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the Width and Height, in pixels, of the size of the icon when it
	/// is rendered. By default, the IconSize is used to set the display size
	/// (i.e., UseIconSize is true by default). Note that assumes that
	/// IconScaling is disabled, or if enabled, the scale of a particular icon
	/// is 1.
	/// </summary>
	public void SetDisplaySize(IntPtr _arg)
	{
		vtkIconGlyphFilter_SetDisplaySize_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravity_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public virtual void SetGravity(int _arg)
	{
		vtkIconGlyphFilter_SetGravity_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravityToBottomCenter_25(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public void SetGravityToBottomCenter()
	{
		vtkIconGlyphFilter_SetGravityToBottomCenter_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravityToBottomLeft_26(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public void SetGravityToBottomLeft()
	{
		vtkIconGlyphFilter_SetGravityToBottomLeft_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravityToBottomRight_27(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public void SetGravityToBottomRight()
	{
		vtkIconGlyphFilter_SetGravityToBottomRight_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravityToCenterCenter_28(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public void SetGravityToCenterCenter()
	{
		vtkIconGlyphFilter_SetGravityToCenterCenter_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravityToCenterLeft_29(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public void SetGravityToCenterLeft()
	{
		vtkIconGlyphFilter_SetGravityToCenterLeft_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravityToCenterRight_30(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public void SetGravityToCenterRight()
	{
		vtkIconGlyphFilter_SetGravityToCenterRight_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravityToTopCenter_31(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public void SetGravityToTopCenter()
	{
		vtkIconGlyphFilter_SetGravityToTopCenter_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravityToTopLeft_32(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public void SetGravityToTopLeft()
	{
		vtkIconGlyphFilter_SetGravityToTopLeft_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetGravityToTopRight_33(HandleRef pThis);

	/// <summary>
	/// Specify if the input points define the center of the icon quad or one of
	/// top right corner, top center, top left corner, center right, center, center
	/// center left, bottom right corner, bottom center or bottom left corner.
	/// </summary>
	public void SetGravityToTopRight()
	{
		vtkIconGlyphFilter_SetGravityToTopRight_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetIconScaling_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify how to specify individual icons. By default, icon scaling
	/// is off, but if it is on, then the filter looks for an array named
	/// "IconScale" to control individual icon size.
	/// </summary>
	public virtual void SetIconScaling(int _arg)
	{
		vtkIconGlyphFilter_SetIconScaling_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetIconScalingToScalingArray_35(HandleRef pThis);

	/// <summary>
	/// Specify how to specify individual icons. By default, icon scaling
	/// is off, but if it is on, then the filter looks for an array named
	/// "IconScale" to control individual icon size.
	/// </summary>
	public void SetIconScalingToScalingArray()
	{
		vtkIconGlyphFilter_SetIconScalingToScalingArray_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetIconScalingToScalingOff_36(HandleRef pThis);

	/// <summary>
	/// Specify how to specify individual icons. By default, icon scaling
	/// is off, but if it is on, then the filter looks for an array named
	/// "IconScale" to control individual icon size.
	/// </summary>
	public void SetIconScalingToScalingOff()
	{
		vtkIconGlyphFilter_SetIconScalingToScalingOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetIconSheetSize_37(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public virtual void SetIconSheetSize(int _arg1, int _arg2)
	{
		vtkIconGlyphFilter_SetIconSheetSize_37(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetIconSheetSize_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public void SetIconSheetSize(IntPtr _arg)
	{
		vtkIconGlyphFilter_SetIconSheetSize_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetIconSize_39(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public virtual void SetIconSize(int _arg1, int _arg2)
	{
		vtkIconGlyphFilter_SetIconSize_39(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetIconSize_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
	/// </summary>
	public void SetIconSize(IntPtr _arg)
	{
		vtkIconGlyphFilter_SetIconSize_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetOffset_41(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify an offset (in pixels or display coordinates) that offsets the icons
	/// from their generating points.
	/// </summary>
	public virtual void SetOffset(int _arg1, int _arg2)
	{
		vtkIconGlyphFilter_SetOffset_41(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetOffset_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify an offset (in pixels or display coordinates) that offsets the icons
	/// from their generating points.
	/// </summary>
	public void SetOffset(IntPtr _arg)
	{
		vtkIconGlyphFilter_SetOffset_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetPassScalars_43(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether to pass the scalar icon index to the output. By
	/// default this is not passed since it can affect color during the
	/// rendering process. Note that all other point data is passed to
	/// the output regardless of the value of this flag.
	/// </summary>
	public virtual void SetPassScalars(bool _arg)
	{
		vtkIconGlyphFilter_SetPassScalars_43(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_SetUseIconSize_44(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether the Quad generated to place the icon on will be either
	/// the dimensions specified by IconSize or the DisplaySize.
	/// </summary>
	public virtual void SetUseIconSize(bool _arg)
	{
		vtkIconGlyphFilter_SetUseIconSize_44(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_UseIconSizeOff_45(HandleRef pThis);

	/// <summary>
	/// Specify whether the Quad generated to place the icon on will be either
	/// the dimensions specified by IconSize or the DisplaySize.
	/// </summary>
	public virtual void UseIconSizeOff()
	{
		vtkIconGlyphFilter_UseIconSizeOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIconGlyphFilter_UseIconSizeOn_46(HandleRef pThis);

	/// <summary>
	/// Specify whether the Quad generated to place the icon on will be either
	/// the dimensions specified by IconSize or the DisplaySize.
	/// </summary>
	public virtual void UseIconSizeOn()
	{
		vtkIconGlyphFilter_UseIconSizeOn_46(GetCppThis());
	}
}
