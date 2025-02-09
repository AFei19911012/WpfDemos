using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSelectVisiblePoints
/// </summary>
/// <remarks>
///    extract points that are visible (based on z-buffer calculation)
///
/// vtkSelectVisiblePoints is a filter that selects points based on
/// whether they are visible or not. Visibility is determined by
/// accessing the z-buffer of a rendering window. (The position of each
/// input point is converted into display coordinates, and then the
/// z-value at that point is obtained. If within the user-specified
/// tolerance, the point is considered visible.)
///
/// Points that are visible (or if the ivar SelectInvisible is on,
/// invisible points) are passed to the output. Associated data
/// attributes are passed to the output as well.
///
/// This filter also allows you to specify a rectangular window in display
/// (pixel) coordinates in which the visible points must lie. This can be
/// used as a sort of local "brushing" operation to select just data within
/// a window.
///
///
/// @warning
/// You must carefully synchronize the execution of this filter. The
/// filter refers to a renderer, which is modified every time a render
/// occurs. Therefore, the filter is always out of date, and always
/// executes. You may have to perform two rendering passes, or if you
/// are using this filter in conjunction with vtkLabeledDataMapper,
/// things work out because 2D rendering occurs after the 3D rendering.
/// </remarks>
public class vtkSelectVisiblePoints : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSelectVisiblePoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSelectVisiblePoints()
	{
		MRClassNameKey = "class vtkSelectVisiblePoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectVisiblePoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSelectVisiblePoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectVisiblePoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with no renderer; window selection turned off;
	/// tolerance set to 0.01; and select invisible off.
	/// </summary>
	public new static vtkSelectVisiblePoints New()
	{
		vtkSelectVisiblePoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectVisiblePoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectVisiblePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with no renderer; window selection turned off;
	/// tolerance set to 0.01; and select invisible off.
	/// </summary>
	public vtkSelectVisiblePoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSelectVisiblePoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSelectVisiblePoints_GetMTime_01(HandleRef pThis);

	/// <summary>
	/// Return MTime also considering the renderer.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSelectVisiblePoints_GetMTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectVisiblePoints_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSelectVisiblePoints_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectVisiblePoints_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSelectVisiblePoints_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectVisiblePoints_GetRenderer_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the renderer in which the visibility computation is to be
	/// performed.
	/// </summary>
	public vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectVisiblePoints_GetRenderer_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectVisiblePoints_GetSelectInvisible_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which enables inverse selection; i.e., invisible points
	/// are selected.
	/// </summary>
	public virtual int GetSelectInvisible()
	{
		return vtkSelectVisiblePoints_GetSelectInvisible_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectVisiblePoints_GetSelection_06(HandleRef pThis);

	/// <summary>
	/// Specify the selection window in display coordinates. You must specify
	/// a rectangular region using (xmin,xmax,ymin,ymax).
	/// </summary>
	public virtual int[] GetSelection()
	{
		IntPtr intPtr = vtkSelectVisiblePoints_GetSelection_06(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_GetSelection_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the selection window in display coordinates. You must specify
	/// a rectangular region using (xmin,xmax,ymin,ymax).
	/// </summary>
	public virtual void GetSelection(IntPtr data)
	{
		vtkSelectVisiblePoints_GetSelection_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectVisiblePoints_GetSelectionWindow_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which enables selection in a rectangular display
	/// region.
	/// </summary>
	public virtual int GetSelectionWindow()
	{
		return vtkSelectVisiblePoints_GetSelectionWindow_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSelectVisiblePoints_GetTolerance_09(HandleRef pThis);

	/// <summary>
	/// Set/Get a tolerance in normalized display coordinate system
	/// to use to determine whether a point is visible. A
	/// tolerance is usually required because the conversion from world space
	/// to display space during rendering introduces numerical round-off.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkSelectVisiblePoints_GetTolerance_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSelectVisiblePoints_GetToleranceMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get a tolerance in normalized display coordinate system
	/// to use to determine whether a point is visible. A
	/// tolerance is usually required because the conversion from world space
	/// to display space during rendering introduces numerical round-off.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkSelectVisiblePoints_GetToleranceMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSelectVisiblePoints_GetToleranceMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get a tolerance in normalized display coordinate system
	/// to use to determine whether a point is visible. A
	/// tolerance is usually required because the conversion from world space
	/// to display space during rendering introduces numerical round-off.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkSelectVisiblePoints_GetToleranceMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSelectVisiblePoints_GetToleranceWorld_12(HandleRef pThis);

	/// <summary>
	/// Set/Get a tolerance in world coordinate system
	/// to use to determine whether a point is visible.
	/// This allows determining visibility of small spheroid objects
	/// (such as glyphs) with known size in world coordinates.
	/// By default it is set to 0.
	/// </summary>
	public virtual double GetToleranceWorld()
	{
		return vtkSelectVisiblePoints_GetToleranceWorld_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSelectVisiblePoints_GetToleranceWorldMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get a tolerance in world coordinate system
	/// to use to determine whether a point is visible.
	/// This allows determining visibility of small spheroid objects
	/// (such as glyphs) with known size in world coordinates.
	/// By default it is set to 0.
	/// </summary>
	public virtual double GetToleranceWorldMaxValue()
	{
		return vtkSelectVisiblePoints_GetToleranceWorldMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSelectVisiblePoints_GetToleranceWorldMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get a tolerance in world coordinate system
	/// to use to determine whether a point is visible.
	/// This allows determining visibility of small spheroid objects
	/// (such as glyphs) with known size in world coordinates.
	/// By default it is set to 0.
	/// </summary>
	public virtual double GetToleranceWorldMinValue()
	{
		return vtkSelectVisiblePoints_GetToleranceWorldMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectVisiblePoints_Initialize_15(HandleRef pThis, byte getZbuff);

	/// <summary>
	/// Requires the renderer to be set. Populates the composite perspective transform
	/// and returns a pointer to the Z-buffer (that must be deleted) if getZbuff is set.
	/// </summary>
	public IntPtr Initialize(bool getZbuff)
	{
		return vtkSelectVisiblePoints_Initialize_15(GetCppThis(), (byte)(getZbuff ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectVisiblePoints_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSelectVisiblePoints_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSelectVisiblePoints_IsPointOccluded_17(HandleRef pThis, IntPtr x, IntPtr zPtr);

	/// <summary>
	/// Tests if a point x is being occluded or not against the Z-Buffer array passed in by
	/// zPtr. Call Initialize before calling this method.
	/// </summary>
	public bool IsPointOccluded(IntPtr x, IntPtr zPtr)
	{
		return (vtkSelectVisiblePoints_IsPointOccluded_17(GetCppThis(), x, zPtr) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectVisiblePoints_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSelectVisiblePoints_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectVisiblePoints_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSelectVisiblePoints NewInstance()
	{
		vtkSelectVisiblePoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectVisiblePoints_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectVisiblePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectVisiblePoints_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSelectVisiblePoints SafeDownCast(vtkObjectBase o)
	{
		vtkSelectVisiblePoints vtkSelectVisiblePoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectVisiblePoints_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelectVisiblePoints2 = (vtkSelectVisiblePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelectVisiblePoints2.Register(null);
			}
		}
		return vtkSelectVisiblePoints2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SelectInvisibleOff_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which enables inverse selection; i.e., invisible points
	/// are selected.
	/// </summary>
	public virtual void SelectInvisibleOff()
	{
		vtkSelectVisiblePoints_SelectInvisibleOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SelectInvisibleOn_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which enables inverse selection; i.e., invisible points
	/// are selected.
	/// </summary>
	public virtual void SelectInvisibleOn()
	{
		vtkSelectVisiblePoints_SelectInvisibleOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SelectionWindowOff_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which enables selection in a rectangular display
	/// region.
	/// </summary>
	public virtual void SelectionWindowOff()
	{
		vtkSelectVisiblePoints_SelectionWindowOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SelectionWindowOn_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which enables selection in a rectangular display
	/// region.
	/// </summary>
	public virtual void SelectionWindowOn()
	{
		vtkSelectVisiblePoints_SelectionWindowOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SetRenderer_26(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Specify the renderer in which the visibility computation is to be
	/// performed.
	/// </summary>
	public void SetRenderer(vtkRenderer ren)
	{
		vtkSelectVisiblePoints_SetRenderer_26(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SetSelectInvisible_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which enables inverse selection; i.e., invisible points
	/// are selected.
	/// </summary>
	public virtual void SetSelectInvisible(int _arg)
	{
		vtkSelectVisiblePoints_SetSelectInvisible_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SetSelection_28(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4);

	/// <summary>
	/// Specify the selection window in display coordinates. You must specify
	/// a rectangular region using (xmin,xmax,ymin,ymax).
	/// </summary>
	public virtual void SetSelection(int _arg1, int _arg2, int _arg3, int _arg4)
	{
		vtkSelectVisiblePoints_SetSelection_28(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SetSelection_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the selection window in display coordinates. You must specify
	/// a rectangular region using (xmin,xmax,ymin,ymax).
	/// </summary>
	public virtual void SetSelection(IntPtr _arg)
	{
		vtkSelectVisiblePoints_SetSelection_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SetSelectionWindow_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which enables selection in a rectangular display
	/// region.
	/// </summary>
	public virtual void SetSelectionWindow(int _arg)
	{
		vtkSelectVisiblePoints_SetSelectionWindow_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SetTolerance_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get a tolerance in normalized display coordinate system
	/// to use to determine whether a point is visible. A
	/// tolerance is usually required because the conversion from world space
	/// to display space during rendering introduces numerical round-off.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkSelectVisiblePoints_SetTolerance_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectVisiblePoints_SetToleranceWorld_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get a tolerance in world coordinate system
	/// to use to determine whether a point is visible.
	/// This allows determining visibility of small spheroid objects
	/// (such as glyphs) with known size in world coordinates.
	/// By default it is set to 0.
	/// </summary>
	public virtual void SetToleranceWorld(double _arg)
	{
		vtkSelectVisiblePoints_SetToleranceWorld_32(GetCppThis(), _arg);
	}
}
