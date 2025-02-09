using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageCroppingRegionsWidget
/// </summary>
/// <remarks>
///    widget for cropping an image
///
/// This widget displays a set of axis aligned lines that can be interactively
/// manipulated to crop a volume. The region to be cropped away is displayed
/// in a different highlight. Much like the vtkVolumeMapper, this widget
/// supports 27 possible configurations of cropping planes. (See
/// CroppingRegionFlags). If a volume mapper is set, the cropping planes
/// are directly propagated to the volume mapper. The widget invokes a
/// CroppingPlanesPositionChangedEvent when the position of any of the
/// cropping planes is changed. The widget also invokes an InteractionEvent
/// in response to user interaction.
/// </remarks>
public class vtkImageCroppingRegionsWidget : vtk3DWidget
{
	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public enum SLICE_ORIENTATION_XY_WrapperEnum
	{
		/// <summary>enum member</summary>
		SLICE_ORIENTATION_XY = 2,
		/// <summary>enum member</summary>
		SLICE_ORIENTATION_XZ = 1,
		/// <summary>enum member</summary>
		SLICE_ORIENTATION_YZ = 0
	}

	/// <summary>
	/// Events invoked by this widget
	/// </summary>
	public enum WidgetEventIds
	{
		/// <summary>enum member</summary>
		CroppingPlanesPositionChangedEvent = 10050
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageCroppingRegionsWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageCroppingRegionsWidget()
	{
		MRClassNameKey = "class vtkImageCroppingRegionsWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCroppingRegionsWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageCroppingRegionsWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCroppingRegionsWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkImageCroppingRegionsWidget New()
	{
		vtkImageCroppingRegionsWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCroppingRegionsWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageCroppingRegionsWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public vtkImageCroppingRegionsWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageCroppingRegionsWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageCroppingRegionsWidget_GetCroppingRegionFlags_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the cropping region flags
	/// </summary>
	public virtual int GetCroppingRegionFlags()
	{
		return vtkImageCroppingRegionsWidget_GetCroppingRegionFlags_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCroppingRegionsWidget_GetLine1Color_02(HandleRef pThis);

	/// <summary>
	/// Set/Get line 1 color
	/// </summary>
	public virtual IntPtr GetLine1Color()
	{
		return vtkImageCroppingRegionsWidget_GetLine1Color_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_GetLine1Color_03(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set/Get line 1 color
	/// </summary>
	public virtual void GetLine1Color(IntPtr rgb)
	{
		vtkImageCroppingRegionsWidget_GetLine1Color_03(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCroppingRegionsWidget_GetLine2Color_04(HandleRef pThis);

	/// <summary>
	/// Set/Get line 2 color
	/// </summary>
	public virtual IntPtr GetLine2Color()
	{
		return vtkImageCroppingRegionsWidget_GetLine2Color_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_GetLine2Color_05(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set/Get line 2 color
	/// </summary>
	public virtual void GetLine2Color(IntPtr rgb)
	{
		vtkImageCroppingRegionsWidget_GetLine2Color_05(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCroppingRegionsWidget_GetLine3Color_06(HandleRef pThis);

	/// <summary>
	/// Set/Get line 3 color
	/// </summary>
	public virtual IntPtr GetLine3Color()
	{
		return vtkImageCroppingRegionsWidget_GetLine3Color_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_GetLine3Color_07(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set/Get line 3 color
	/// </summary>
	public virtual void GetLine3Color(IntPtr rgb)
	{
		vtkImageCroppingRegionsWidget_GetLine3Color_07(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCroppingRegionsWidget_GetLine4Color_08(HandleRef pThis);

	/// <summary>
	/// Set/Get line 4 color
	/// </summary>
	public virtual IntPtr GetLine4Color()
	{
		return vtkImageCroppingRegionsWidget_GetLine4Color_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_GetLine4Color_09(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set/Get line 4 color
	/// </summary>
	public virtual void GetLine4Color(IntPtr rgb)
	{
		vtkImageCroppingRegionsWidget_GetLine4Color_09(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageCroppingRegionsWidget_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageCroppingRegionsWidget_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageCroppingRegionsWidget_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageCroppingRegionsWidget_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCroppingRegionsWidget_GetPlanePositions_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the plane positions that represent the cropped region.
	/// </summary>
	public virtual double[] GetPlanePositions()
	{
		IntPtr intPtr = vtkImageCroppingRegionsWidget_GetPlanePositions_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_GetPlanePositions_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Set/Get the plane positions that represent the cropped region.
	/// </summary>
	public virtual void GetPlanePositions(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkImageCroppingRegionsWidget_GetPlanePositions_13(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_GetPlanePositions_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the plane positions that represent the cropped region.
	/// </summary>
	public virtual void GetPlanePositions(IntPtr _arg)
	{
		vtkImageCroppingRegionsWidget_GetPlanePositions_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCroppingRegionsWidget_GetSlice_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the slice number
	/// </summary>
	public virtual int GetSlice()
	{
		return vtkImageCroppingRegionsWidget_GetSlice_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCroppingRegionsWidget_GetSliceOrientation_16(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual int GetSliceOrientation()
	{
		return vtkImageCroppingRegionsWidget_GetSliceOrientation_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCroppingRegionsWidget_GetVolumeMapper_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the input volume mapper
	/// Update the widget according to its mapper
	/// </summary>
	public virtual vtkVolumeMapper GetVolumeMapper()
	{
		vtkVolumeMapper vtkVolumeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCroppingRegionsWidget_GetVolumeMapper_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeMapper2 = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeMapper2.Register(null);
			}
		}
		return vtkVolumeMapper2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCroppingRegionsWidget_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageCroppingRegionsWidget_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCroppingRegionsWidget_IsTypeOf_19(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageCroppingRegionsWidget_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_MoveHorizontalLine_20(HandleRef pThis);

	/// <summary>
	/// Callbacks for user interaction.
	/// </summary>
	public void MoveHorizontalLine()
	{
		vtkImageCroppingRegionsWidget_MoveHorizontalLine_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_MoveIntersectingLines_21(HandleRef pThis);

	/// <summary>
	/// Callbacks for user interaction.
	/// </summary>
	public void MoveIntersectingLines()
	{
		vtkImageCroppingRegionsWidget_MoveIntersectingLines_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_MoveVerticalLine_22(HandleRef pThis);

	/// <summary>
	/// Callbacks for user interaction.
	/// </summary>
	public void MoveVerticalLine()
	{
		vtkImageCroppingRegionsWidget_MoveVerticalLine_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCroppingRegionsWidget_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkImageCroppingRegionsWidget NewInstance()
	{
		vtkImageCroppingRegionsWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCroppingRegionsWidget_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageCroppingRegionsWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_OnButtonPress_25(HandleRef pThis);

	/// <summary>
	/// Callbacks for user interaction.
	/// </summary>
	public void OnButtonPress()
	{
		vtkImageCroppingRegionsWidget_OnButtonPress_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_OnButtonRelease_26(HandleRef pThis);

	/// <summary>
	/// Callbacks for user interaction.
	/// </summary>
	public void OnButtonRelease()
	{
		vtkImageCroppingRegionsWidget_OnButtonRelease_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_OnMouseMove_27(HandleRef pThis);

	/// <summary>
	/// Callbacks for user interaction.
	/// </summary>
	public void OnMouseMove()
	{
		vtkImageCroppingRegionsWidget_OnMouseMove_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_PlaceWidget_28(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Place/Adjust widget within bounds
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkImageCroppingRegionsWidget_PlaceWidget_28(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCroppingRegionsWidget_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkImageCroppingRegionsWidget SafeDownCast(vtkObjectBase o)
	{
		vtkImageCroppingRegionsWidget vtkImageCroppingRegionsWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCroppingRegionsWidget_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageCroppingRegionsWidget2 = (vtkImageCroppingRegionsWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageCroppingRegionsWidget2.Register(null);
			}
		}
		return vtkImageCroppingRegionsWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetCroppingRegionFlags_30(HandleRef pThis, int flags);

	/// <summary>
	/// Set/Get the cropping region flags
	/// </summary>
	public virtual void SetCroppingRegionFlags(int flags)
	{
		vtkImageCroppingRegionsWidget_SetCroppingRegionFlags_30(GetCppThis(), flags);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetEnabled_31(HandleRef pThis, int enabling);

	/// <summary>
	/// Enable/disable the widget
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkImageCroppingRegionsWidget_SetEnabled_31(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetLine1Color_32(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set/Get line 1 color
	/// </summary>
	public virtual void SetLine1Color(double r, double g, double b)
	{
		vtkImageCroppingRegionsWidget_SetLine1Color_32(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetLine1Color_33(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set/Get line 1 color
	/// </summary>
	public virtual void SetLine1Color(IntPtr rgb)
	{
		vtkImageCroppingRegionsWidget_SetLine1Color_33(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetLine2Color_34(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set/Get line 2 color
	/// </summary>
	public virtual void SetLine2Color(double r, double g, double b)
	{
		vtkImageCroppingRegionsWidget_SetLine2Color_34(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetLine2Color_35(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set/Get line 2 color
	/// </summary>
	public virtual void SetLine2Color(IntPtr rgb)
	{
		vtkImageCroppingRegionsWidget_SetLine2Color_35(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetLine3Color_36(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set/Get line 3 color
	/// </summary>
	public virtual void SetLine3Color(double r, double g, double b)
	{
		vtkImageCroppingRegionsWidget_SetLine3Color_36(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetLine3Color_37(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set/Get line 3 color
	/// </summary>
	public virtual void SetLine3Color(IntPtr rgb)
	{
		vtkImageCroppingRegionsWidget_SetLine3Color_37(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetLine4Color_38(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set/Get line 4 color
	/// </summary>
	public virtual void SetLine4Color(double r, double g, double b)
	{
		vtkImageCroppingRegionsWidget_SetLine4Color_38(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetLine4Color_39(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set/Get line 4 color
	/// </summary>
	public virtual void SetLine4Color(IntPtr rgb)
	{
		vtkImageCroppingRegionsWidget_SetLine4Color_39(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetPlanePositions_40(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set/Get the plane positions that represent the cropped region.
	/// </summary>
	public virtual void SetPlanePositions(IntPtr pos)
	{
		vtkImageCroppingRegionsWidget_SetPlanePositions_40(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetPlanePositions_41(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Set/Get the plane positions that represent the cropped region.
	/// </summary>
	public virtual void SetPlanePositions(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkImageCroppingRegionsWidget_SetPlanePositions_41(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetSlice_42(HandleRef pThis, int num);

	/// <summary>
	/// Set/Get the slice number
	/// </summary>
	public virtual void SetSlice(int num)
	{
		vtkImageCroppingRegionsWidget_SetSlice_42(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetSliceOrientation_43(HandleRef pThis, int orientation);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetSliceOrientation(int orientation)
	{
		vtkImageCroppingRegionsWidget_SetSliceOrientation_43(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetSliceOrientationToXY_44(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetSliceOrientationToXY()
	{
		vtkImageCroppingRegionsWidget_SetSliceOrientationToXY_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetSliceOrientationToXZ_45(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetSliceOrientationToXZ()
	{
		vtkImageCroppingRegionsWidget_SetSliceOrientationToXZ_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetSliceOrientationToYZ_46(HandleRef pThis);

	/// <summary>
	/// Set/get the slice orientation
	/// </summary>
	public virtual void SetSliceOrientationToYZ()
	{
		vtkImageCroppingRegionsWidget_SetSliceOrientationToYZ_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_SetVolumeMapper_47(HandleRef pThis, HandleRef mapper);

	/// <summary>
	/// Set/Get the input volume mapper
	/// Update the widget according to its mapper
	/// </summary>
	public virtual void SetVolumeMapper(vtkVolumeMapper mapper)
	{
		vtkImageCroppingRegionsWidget_SetVolumeMapper_47(GetCppThis(), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_UpdateAccordingToInput_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the input volume mapper
	/// Update the widget according to its mapper
	/// </summary>
	public virtual void UpdateAccordingToInput()
	{
		vtkImageCroppingRegionsWidget_UpdateAccordingToInput_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCroppingRegionsWidget_UpdateCursorIcon_49(HandleRef pThis);

	/// <summary>
	/// Callbacks for user interaction.
	/// </summary>
	public void UpdateCursorIcon()
	{
		vtkImageCroppingRegionsWidget_UpdateCursorIcon_49(GetCppThis());
	}
}
