using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBlockItem
/// </summary>
/// <remarks>
///    a vtkContextItem that draws a block (optional label).
///
/// This is a vtkContextItem that can be placed into a vtkContextScene. It draws
/// a block of the given dimensions, and reacts to mouse events.
///
/// vtkBlockItem can also be used to render label in the scene. The label
/// properties can be set using `vtkTextProperty` accessed via
/// `GetLabelProperties`.
///
/// </remarks>
public class vtkBlockItem : vtkContextItem
{
	/// <summary>
	/// When set to true, the dimensions for the block are computed automatically
	/// using the anchor point, alignment at the size of the label.
	/// Otherwise the `Dimensions` are used.
	///
	/// Default is false i.e `Dimensions` will be used.
	/// </summary>
	public enum BOTTOM_WrapperEnum
	{
		/// <summary>enum member</summary>
		BOTTOM = 4,
		/// <summary>enum member</summary>
		CENTER = 1,
		/// <summary>enum member</summary>
		CUSTOM = 5,
		/// <summary>enum member</summary>
		LEFT = 0,
		/// <summary>enum member</summary>
		RIGHT = 2,
		/// <summary>enum member</summary>
		TOP = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBlockItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBlockItem()
	{
		MRClassNameKey = "class vtkBlockItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlockItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBlockItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBlockItem New()
	{
		vtkBlockItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlockItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBlockItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBlockItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBlockItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_AutoComputeDimensionsOff_01(HandleRef pThis);

	/// <summary>
	/// When set to true, the dimensions for the block are computed automatically
	/// using the anchor point, alignment at the size of the label.
	/// Otherwise the `Dimensions` are used.
	///
	/// Default is false i.e `Dimensions` will be used.
	/// </summary>
	public virtual void AutoComputeDimensionsOff()
	{
		vtkBlockItem_AutoComputeDimensionsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_AutoComputeDimensionsOn_02(HandleRef pThis);

	/// <summary>
	/// When set to true, the dimensions for the block are computed automatically
	/// using the anchor point, alignment at the size of the label.
	/// Otherwise the `Dimensions` are used.
	///
	/// Default is false i.e `Dimensions` will be used.
	/// </summary>
	public virtual void AutoComputeDimensionsOn()
	{
		vtkBlockItem_AutoComputeDimensionsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBlockItem_GetAutoComputeDimensions_03(HandleRef pThis);

	/// <summary>
	/// When set to true, the dimensions for the block are computed automatically
	/// using the anchor point, alignment at the size of the label.
	/// Otherwise the `Dimensions` are used.
	///
	/// Default is false i.e `Dimensions` will be used.
	/// </summary>
	public virtual bool GetAutoComputeDimensions()
	{
		return (vtkBlockItem_GetAutoComputeDimensions_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_GetBrush_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the brush used to draw the block item background.
	/// </summary>
	public virtual vtkBrush GetBrush()
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlockItem_GetBrush_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBrush2 = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBrush2.Register(null);
			}
		}
		return vtkBrush2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_GetDimensions_05(HandleRef pThis);

	/// <summary>
	/// Get the dimensions of the block, elements 0 and 1 are the x and y
	/// coordinate of the bottom corner. Elements 2 and 3 are the width and
	/// height.
	/// Initial value is (0,0,0,0)
	/// </summary>
	public virtual float[] GetDimensions()
	{
		IntPtr intPtr = vtkBlockItem_GetDimensions_05(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_GetDimensions_06(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

	/// <summary>
	/// Get the dimensions of the block, elements 0 and 1 are the x and y
	/// coordinate of the bottom corner. Elements 2 and 3 are the width and
	/// height.
	/// Initial value is (0,0,0,0)
	/// </summary>
	public virtual void GetDimensions(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
	{
		vtkBlockItem_GetDimensions_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_GetDimensions_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the dimensions of the block, elements 0 and 1 are the x and y
	/// coordinate of the bottom corner. Elements 2 and 3 are the width and
	/// height.
	/// Initial value is (0,0,0,0)
	/// </summary>
	public virtual void GetDimensions(IntPtr _arg)
	{
		vtkBlockItem_GetDimensions_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBlockItem_GetHorizontalAlignment_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the horizontal alignment of the legend to the point specified.
	/// Valid values are LEFT, CENTER and RIGHT.
	/// </summary>
	public virtual int GetHorizontalAlignment()
	{
		return vtkBlockItem_GetHorizontalAlignment_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkBlockItem_GetLabel_09(HandleRef pThis);

	/// <summary>
	/// Get the block label.
	/// </summary>
	public virtual string GetLabel()
	{
		return vtkBlockItem_GetLabel_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_GetLabelProperties_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Provides access to the vtkTextProperty object that controls the way the
	/// label is rendered.
	/// </summary>
	public virtual vtkTextProperty GetLabelProperties()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlockItem_GetLabelProperties_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_GetMargins_11(HandleRef pThis);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the margins from the edge of
	/// the viewport to use when placing the block based on HorizontalAlignment and
	/// VerticalAlignment preferences.
	/// </summary>
	public virtual int[] GetMargins()
	{
		IntPtr intPtr = vtkBlockItem_GetMargins_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_GetMargins_12(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the margins from the edge of
	/// the viewport to use when placing the block based on HorizontalAlignment and
	/// VerticalAlignment preferences.
	/// </summary>
	public virtual void GetMargins(ref int _arg1, ref int _arg2)
	{
		vtkBlockItem_GetMargins_12(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_GetMargins_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the margins from the edge of
	/// the viewport to use when placing the block based on HorizontalAlignment and
	/// VerticalAlignment preferences.
	/// </summary>
	public virtual void GetMargins(IntPtr _arg)
	{
		vtkBlockItem_GetMargins_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_GetMouseOverBrush_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the brush used to draw the block item background when the
	/// item is "hit" i.e. interaction is enabled and the mouse is over the block.
	/// </summary>
	public virtual vtkBrush GetMouseOverBrush()
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlockItem_GetMouseOverBrush_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBrush2 = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBrush2.Register(null);
			}
		}
		return vtkBrush2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBlockItem_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBlockItem_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBlockItem_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBlockItem_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_GetPadding_17(HandleRef pThis);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the padding for the label
	/// within the block.
	///
	/// Default is (5, 5).
	/// </summary>
	public virtual int[] GetPadding()
	{
		IntPtr intPtr = vtkBlockItem_GetPadding_17(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_GetPadding_18(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the padding for the label
	/// within the block.
	///
	/// Default is (5, 5).
	/// </summary>
	public virtual void GetPadding(ref int _arg1, ref int _arg2)
	{
		vtkBlockItem_GetPadding_18(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_GetPadding_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the padding for the label
	/// within the block.
	///
	/// Default is (5, 5).
	/// </summary>
	public virtual void GetPadding(IntPtr _arg)
	{
		vtkBlockItem_GetPadding_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_GetPen_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get pen used to draw the block item outline.
	/// </summary>
	public virtual vtkPen GetPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlockItem_GetPen_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBlockItem_GetVerticalAlignment_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertical alignment of the legend to the point specified.
	/// Valid values are TOP, CENTER and BOTTOM.
	/// </summary>
	public virtual int GetVerticalAlignment()
	{
		return vtkBlockItem_GetVerticalAlignment_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBlockItem_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBlockItem_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBlockItem_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBlockItem_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBlockItem NewInstance()
	{
		vtkBlockItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlockItem_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBlockItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBlockItem_Paint_26(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the item.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkBlockItem_Paint_26(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBlockItem_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBlockItem SafeDownCast(vtkObjectBase o)
	{
		vtkBlockItem vtkBlockItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBlockItem_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBlockItem2 = (vtkBlockItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBlockItem2.Register(null);
			}
		}
		return vtkBlockItem2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetAutoComputeDimensions_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true, the dimensions for the block are computed automatically
	/// using the anchor point, alignment at the size of the label.
	/// Otherwise the `Dimensions` are used.
	///
	/// Default is false i.e `Dimensions` will be used.
	/// </summary>
	public virtual void SetAutoComputeDimensions(bool _arg)
	{
		vtkBlockItem_SetAutoComputeDimensions_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetDimensions_29(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

	/// <summary>
	/// Set the dimensions of the block, elements 0 and 1 are the x and y
	/// coordinate of the bottom corner. Elements 2 and 3 are the width and
	/// height.
	/// Initial value is (0,0,0,0).
	/// </summary>
	public virtual void SetDimensions(float _arg1, float _arg2, float _arg3, float _arg4)
	{
		vtkBlockItem_SetDimensions_29(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetDimensions_30(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the dimensions of the block, elements 0 and 1 are the x and y
	/// coordinate of the bottom corner. Elements 2 and 3 are the width and
	/// height.
	/// Initial value is (0,0,0,0).
	/// </summary>
	public virtual void SetDimensions(IntPtr _arg)
	{
		vtkBlockItem_SetDimensions_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetHorizontalAlignment_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the horizontal alignment of the legend to the point specified.
	/// Valid values are LEFT, CENTER and RIGHT.
	/// </summary>
	public virtual void SetHorizontalAlignment(int _arg)
	{
		vtkBlockItem_SetHorizontalAlignment_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetLabel_32(HandleRef pThis, string label);

	/// <summary>
	/// Set the block label.
	/// </summary>
	public virtual void SetLabel(string label)
	{
		vtkBlockItem_SetLabel_32(GetCppThis(), label);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetLabelProperties_33(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Provides access to the vtkTextProperty object that controls the way the
	/// label is rendered.
	/// </summary>
	public void SetLabelProperties(vtkTextProperty arg0)
	{
		vtkBlockItem_SetLabelProperties_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetMargins_34(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the margins from the edge of
	/// the viewport to use when placing the block based on HorizontalAlignment and
	/// VerticalAlignment preferences.
	/// </summary>
	public virtual void SetMargins(int _arg1, int _arg2)
	{
		vtkBlockItem_SetMargins_34(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetMargins_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the margins from the edge of
	/// the viewport to use when placing the block based on HorizontalAlignment and
	/// VerticalAlignment preferences.
	/// </summary>
	public void SetMargins(IntPtr _arg)
	{
		vtkBlockItem_SetMargins_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetPadding_36(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the padding for the label
	/// within the block.
	///
	/// Default is (5, 5).
	/// </summary>
	public virtual void SetPadding(int _arg1, int _arg2)
	{
		vtkBlockItem_SetPadding_36(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetPadding_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// When AutoComputeDimensions is true, these are the padding for the label
	/// within the block.
	///
	/// Default is (5, 5).
	/// </summary>
	public void SetPadding(IntPtr _arg)
	{
		vtkBlockItem_SetPadding_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBlockItem_SetVerticalAlignment_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the vertical alignment of the legend to the point specified.
	/// Valid values are TOP, CENTER and BOTTOM.
	/// </summary>
	public virtual void SetVerticalAlignment(int _arg)
	{
		vtkBlockItem_SetVerticalAlignment_38(GetCppThis(), _arg);
	}
}
