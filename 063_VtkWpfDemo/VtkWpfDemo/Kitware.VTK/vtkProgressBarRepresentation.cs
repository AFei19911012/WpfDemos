using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProgressBarRepresentation
/// </summary>
/// <remarks>
///    represent a vtkProgressBarWidget
///
/// This class is used to represent a vtkProgressBarWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkProgressBarWidget
/// </seealso>
public class vtkProgressBarRepresentation : vtkBorderRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProgressBarRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProgressBarRepresentation()
	{
		MRClassNameKey = "class vtkProgressBarRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgressBarRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProgressBarRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgressBarRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkProgressBarRepresentation New()
	{
		vtkProgressBarRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgressBarRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgressBarRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkProgressBarRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProgressBarRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Satisfy the superclasses' API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkProgressBarRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_DrawBackgroundOff_02(HandleRef pThis);

	/// <summary>
	/// Set/Get background visibility
	/// Default is off
	/// </summary>
	public virtual void DrawBackgroundOff()
	{
		vtkProgressBarRepresentation_DrawBackgroundOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_DrawBackgroundOn_03(HandleRef pThis);

	/// <summary>
	/// Set/Get background visibility
	/// Default is off
	/// </summary>
	public virtual void DrawBackgroundOn()
	{
		vtkProgressBarRepresentation_DrawBackgroundOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_DrawFrameOff_04(HandleRef pThis);

	/// <summary>
	/// Set/Get frame visibility
	/// default is on
	/// </summary>
	public virtual void DrawFrameOff()
	{
		vtkProgressBarRepresentation_DrawFrameOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_DrawFrameOn_05(HandleRef pThis);

	/// <summary>
	/// Set/Get frame visibility
	/// default is on
	/// </summary>
	public virtual void DrawFrameOn()
	{
		vtkProgressBarRepresentation_DrawFrameOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_GetActors2D_06(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkProgressBarRepresentation_GetActors2D_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgressBarRepresentation_GetBackgroundColor_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the background color
	/// Default is white
	/// </summary>
	public virtual double[] GetBackgroundColor()
	{
		IntPtr intPtr = vtkProgressBarRepresentation_GetBackgroundColor_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_GetBackgroundColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the background color
	/// Default is white
	/// </summary>
	public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProgressBarRepresentation_GetBackgroundColor_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_GetBackgroundColor_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the background color
	/// Default is white
	/// </summary>
	public virtual void GetBackgroundColor(IntPtr _arg)
	{
		vtkProgressBarRepresentation_GetBackgroundColor_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProgressBarRepresentation_GetDrawBackground_10(HandleRef pThis);

	/// <summary>
	/// Set/Get background visibility
	/// Default is off
	/// </summary>
	public virtual bool GetDrawBackground()
	{
		return (vtkProgressBarRepresentation_GetDrawBackground_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProgressBarRepresentation_GetDrawFrame_11(HandleRef pThis);

	/// <summary>
	/// Set/Get frame visibility
	/// default is on
	/// </summary>
	public virtual bool GetDrawFrame()
	{
		return (vtkProgressBarRepresentation_GetDrawFrame_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgressBarRepresentation_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProgressBarRepresentation_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProgressBarRepresentation_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProgressBarRepresentation_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgressBarRepresentation_GetPadding_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the border and the progressbar.
	/// The padding is expressed in percentage of the border box size
	/// default is 0.017,0.1
	/// </summary>
	public virtual double[] GetPadding()
	{
		IntPtr intPtr = vtkProgressBarRepresentation_GetPadding_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_GetPadding_15(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/Get the padding between the border and the progressbar.
	/// The padding is expressed in percentage of the border box size
	/// default is 0.017,0.1
	/// </summary>
	public virtual void GetPadding(ref double _arg1, ref double _arg2)
	{
		vtkProgressBarRepresentation_GetPadding_15(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_GetPadding_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the padding between the border and the progressbar.
	/// The padding is expressed in percentage of the border box size
	/// default is 0.017,0.1
	/// </summary>
	public virtual void GetPadding(IntPtr _arg)
	{
		vtkProgressBarRepresentation_GetPadding_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgressBarRepresentation_GetProgressBarColor_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the progress bar color
	/// Default is pure green
	/// </summary>
	public virtual double[] GetProgressBarColor()
	{
		IntPtr intPtr = vtkProgressBarRepresentation_GetProgressBarColor_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_GetProgressBarColor_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the progress bar color
	/// Default is pure green
	/// </summary>
	public virtual void GetProgressBarColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProgressBarRepresentation_GetProgressBarColor_18(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_GetProgressBarColor_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the progress bar color
	/// Default is pure green
	/// </summary>
	public virtual void GetProgressBarColor(IntPtr _arg)
	{
		vtkProgressBarRepresentation_GetProgressBarColor_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProgressBarRepresentation_GetProgressRate_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the progress rate of the progress bar, between 0 and 1
	/// default is 0
	/// </summary>
	public virtual double GetProgressRate()
	{
		return vtkProgressBarRepresentation_GetProgressRate_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProgressBarRepresentation_GetProgressRateMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the progress rate of the progress bar, between 0 and 1
	/// default is 0
	/// </summary>
	public virtual double GetProgressRateMaxValue()
	{
		return vtkProgressBarRepresentation_GetProgressRateMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProgressBarRepresentation_GetProgressRateMinValue_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the progress rate of the progress bar, between 0 and 1
	/// default is 0
	/// </summary>
	public virtual double GetProgressRateMinValue()
	{
		return vtkProgressBarRepresentation_GetProgressRateMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgressBarRepresentation_GetProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// By obtaining this property you can specify the properties of the
	/// representation.
	/// </summary>
	public virtual vtkProperty2D GetProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgressBarRepresentation_GetProperty_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgressBarRepresentation_HasTranslucentPolygonalGeometry_24(HandleRef pThis);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkProgressBarRepresentation_HasTranslucentPolygonalGeometry_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgressBarRepresentation_IsA_25(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProgressBarRepresentation_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgressBarRepresentation_IsTypeOf_26(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProgressBarRepresentation_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgressBarRepresentation_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new vtkProgressBarRepresentation NewInstance()
	{
		vtkProgressBarRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgressBarRepresentation_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProgressBarRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_ReleaseGraphicsResources_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkProgressBarRepresentation_ReleaseGraphicsResources_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgressBarRepresentation_RenderOpaqueGeometry_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkProgressBarRepresentation_RenderOpaqueGeometry_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgressBarRepresentation_RenderOverlay_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkProgressBarRepresentation_RenderOverlay_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProgressBarRepresentation_RenderTranslucentPolygonalGeometry_32(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkProgressBarRepresentation_RenderTranslucentPolygonalGeometry_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProgressBarRepresentation_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static vtkProgressBarRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkProgressBarRepresentation vtkProgressBarRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProgressBarRepresentation_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProgressBarRepresentation2 = (vtkProgressBarRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProgressBarRepresentation2.Register(null);
			}
		}
		return vtkProgressBarRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_SetBackgroundColor_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the background color
	/// Default is white
	/// </summary>
	public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
	{
		vtkProgressBarRepresentation_SetBackgroundColor_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_SetBackgroundColor_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the background color
	/// Default is white
	/// </summary>
	public virtual void SetBackgroundColor(IntPtr _arg)
	{
		vtkProgressBarRepresentation_SetBackgroundColor_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_SetDrawBackground_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get background visibility
	/// Default is off
	/// </summary>
	public virtual void SetDrawBackground(bool _arg)
	{
		vtkProgressBarRepresentation_SetDrawBackground_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_SetDrawFrame_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get frame visibility
	/// default is on
	/// </summary>
	public virtual void SetDrawFrame(bool _arg)
	{
		vtkProgressBarRepresentation_SetDrawFrame_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_SetPadding_38(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set/Get the padding between the border and the progressbar.
	/// The padding is expressed in percentage of the border box size
	/// default is 0.017,0.1
	/// </summary>
	public virtual void SetPadding(double _arg1, double _arg2)
	{
		vtkProgressBarRepresentation_SetPadding_38(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_SetPadding_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the padding between the border and the progressbar.
	/// The padding is expressed in percentage of the border box size
	/// default is 0.017,0.1
	/// </summary>
	public void SetPadding(IntPtr _arg)
	{
		vtkProgressBarRepresentation_SetPadding_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_SetProgressBarColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the progress bar color
	/// Default is pure green
	/// </summary>
	public virtual void SetProgressBarColor(double _arg1, double _arg2, double _arg3)
	{
		vtkProgressBarRepresentation_SetProgressBarColor_40(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_SetProgressBarColor_41(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the progress bar color
	/// Default is pure green
	/// </summary>
	public virtual void SetProgressBarColor(IntPtr _arg)
	{
		vtkProgressBarRepresentation_SetProgressBarColor_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProgressBarRepresentation_SetProgressRate_42(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the progress rate of the progress bar, between 0 and 1
	/// default is 0
	/// </summary>
	public virtual void SetProgressRate(double _arg)
	{
		vtkProgressBarRepresentation_SetProgressRate_42(GetCppThis(), _arg);
	}
}
