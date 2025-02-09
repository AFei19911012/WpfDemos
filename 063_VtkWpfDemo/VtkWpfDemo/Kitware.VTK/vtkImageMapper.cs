using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMapper
/// </summary>
/// <remarks>
///    2D image display
///
/// vtkImageMapper provides 2D image display support for vtk.
/// It is a Mapper2D subclass that can be associated with an Actor2D
/// and placed within a RenderWindow or ImageWindow.
/// The vtkImageMapper is a 2D mapper, which means that it displays images
/// in display coordinates. In display coordinates, one image pixel is
/// always one screen pixel.
///
/// </remarks>
/// <seealso>
///
/// vtkMapper2D vtkActor2D
/// </seealso>
public class vtkImageMapper : vtkMapper2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMapper()
	{
		MRClassNameKey = "class vtkImageMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMapper New()
	{
		vtkImageMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkImageMapper_GetColorLevel_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the level value for window/level
	/// </summary>
	public virtual double GetColorLevel()
	{
		return vtkImageMapper_GetColorLevel_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMapper_GetColorScale_02(HandleRef pThis);

	/// <summary>
	/// Methods used internally for performing the Window/Level mapping.
	/// </summary>
	public double GetColorScale()
	{
		return vtkImageMapper_GetColorScale_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMapper_GetColorShift_03(HandleRef pThis);

	/// <summary>
	/// Methods used internally for performing the Window/Level mapping.
	/// </summary>
	public double GetColorShift()
	{
		return vtkImageMapper_GetColorShift_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMapper_GetColorWindow_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the window value for window/level
	/// </summary>
	public virtual double GetColorWindow()
	{
		return vtkImageMapper_GetColorWindow_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper_GetCustomDisplayExtents_05(HandleRef pThis);

	/// <summary>
	/// The image extents which should be displayed with UseCustomExtents
	/// Note that the Custom extents are x,y only and the zslice is still
	/// applied
	/// </summary>
	public virtual int[] GetCustomDisplayExtents()
	{
		IntPtr intPtr = vtkImageMapper_GetCustomDisplayExtents_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_GetCustomDisplayExtents_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// The image extents which should be displayed with UseCustomExtents
	/// Note that the Custom extents are x,y only and the zslice is still
	/// applied
	/// </summary>
	public virtual void GetCustomDisplayExtents(IntPtr data)
	{
		vtkImageMapper_GetCustomDisplayExtents_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the Input of a filter.
	/// </summary>
	public vtkImageData GetInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper_GetInput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageMapper_GetMTime_08(HandleRef pThis);

	/// <summary>
	/// Override Modifiedtime as we have added a lookuptable
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageMapper_GetMTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMapper_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMapper_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMapper_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMapper_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper_GetRenderToRectangle_11(HandleRef pThis);

	/// <summary>
	/// If RenderToRectangle is set (by default not), then the imagemapper
	/// will render the image into the rectangle supplied by the Actor2D's
	/// PositionCoordinate and Position2Coordinate
	/// </summary>
	public virtual int GetRenderToRectangle()
	{
		return vtkImageMapper_GetRenderToRectangle_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper_GetUseCustomExtents_12(HandleRef pThis);

	/// <summary>
	/// Usually, the entire image is displayed, if UseCustomExtents
	/// is set (by default not), then the region supplied in the
	/// CustomDisplayExtents is used in preference.
	/// Note that the Custom extents are x,y only and the zslice is still
	/// applied
	/// </summary>
	public virtual int GetUseCustomExtents()
	{
		return vtkImageMapper_GetUseCustomExtents_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper_GetWholeZMax_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the current slice number. The axis Z in ZSlice does not
	/// necessarily have any relation to the z axis of the data on disk.
	/// It is simply the axis orthogonal to the x,y, display plane.
	/// GetWholeZMax and Min are convenience methods for obtaining
	/// the number of slices that can be displayed. Again the number
	/// of slices is in reference to the display z axis, which is not
	/// necessarily the z axis on disk. (due to reformatting etc)
	/// </summary>
	public int GetWholeZMax()
	{
		return vtkImageMapper_GetWholeZMax_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper_GetWholeZMin_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the current slice number. The axis Z in ZSlice does not
	/// necessarily have any relation to the z axis of the data on disk.
	/// It is simply the axis orthogonal to the x,y, display plane.
	/// GetWholeZMax and Min are convenience methods for obtaining
	/// the number of slices that can be displayed. Again the number
	/// of slices is in reference to the display z axis, which is not
	/// necessarily the z axis on disk. (due to reformatting etc)
	/// </summary>
	public int GetWholeZMin()
	{
		return vtkImageMapper_GetWholeZMin_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper_GetZSlice_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the current slice number. The axis Z in ZSlice does not
	/// necessarily have any relation to the z axis of the data on disk.
	/// It is simply the axis orthogonal to the x,y, display plane.
	/// GetWholeZMax and Min are convenience methods for obtaining
	/// the number of slices that can be displayed. Again the number
	/// of slices is in reference to the display z axis, which is not
	/// necessarily the z axis on disk. (due to reformatting etc)
	/// </summary>
	public virtual int GetZSlice()
	{
		return vtkImageMapper_GetZSlice_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMapper_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMapper_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMapper NewInstance()
	{
		vtkImageMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_RenderData_20(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

	/// <summary>
	/// Function called by Render to actually draw the image to to the screen
	/// </summary>
	public virtual void RenderData(vtkViewport arg0, vtkImageData arg1, vtkActor2D arg2)
	{
		vtkImageMapper_RenderData_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_RenderStart_21(HandleRef pThis, HandleRef viewport, HandleRef actor);

	/// <summary>
	/// Draw the image to the screen.
	/// </summary>
	public void RenderStart(vtkViewport viewport, vtkActor2D actor)
	{
		vtkImageMapper_RenderStart_21(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), actor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_RenderToRectangleOff_22(HandleRef pThis);

	/// <summary>
	/// If RenderToRectangle is set (by default not), then the imagemapper
	/// will render the image into the rectangle supplied by the Actor2D's
	/// PositionCoordinate and Position2Coordinate
	/// </summary>
	public virtual void RenderToRectangleOff()
	{
		vtkImageMapper_RenderToRectangleOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_RenderToRectangleOn_23(HandleRef pThis);

	/// <summary>
	/// If RenderToRectangle is set (by default not), then the imagemapper
	/// will render the image into the rectangle supplied by the Actor2D's
	/// PositionCoordinate and Position2Coordinate
	/// </summary>
	public virtual void RenderToRectangleOn()
	{
		vtkImageMapper_RenderToRectangleOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMapper SafeDownCast(vtkObjectBase o)
	{
		vtkImageMapper vtkImageMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapper2 = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapper2.Register(null);
			}
		}
		return vtkImageMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_SetColorLevel_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the level value for window/level
	/// </summary>
	public virtual void SetColorLevel(double _arg)
	{
		vtkImageMapper_SetColorLevel_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_SetColorWindow_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the window value for window/level
	/// </summary>
	public virtual void SetColorWindow(double _arg)
	{
		vtkImageMapper_SetColorWindow_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_SetCustomDisplayExtents_27(HandleRef pThis, IntPtr data);

	/// <summary>
	/// The image extents which should be displayed with UseCustomExtents
	/// Note that the Custom extents are x,y only and the zslice is still
	/// applied
	/// </summary>
	public virtual void SetCustomDisplayExtents(IntPtr data)
	{
		vtkImageMapper_SetCustomDisplayExtents_27(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_SetInputData_28(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the Input of a filter.
	/// </summary>
	public virtual void SetInputData(vtkImageData input)
	{
		vtkImageMapper_SetInputData_28(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_SetRenderToRectangle_29(HandleRef pThis, int _arg);

	/// <summary>
	/// If RenderToRectangle is set (by default not), then the imagemapper
	/// will render the image into the rectangle supplied by the Actor2D's
	/// PositionCoordinate and Position2Coordinate
	/// </summary>
	public virtual void SetRenderToRectangle(int _arg)
	{
		vtkImageMapper_SetRenderToRectangle_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_SetUseCustomExtents_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Usually, the entire image is displayed, if UseCustomExtents
	/// is set (by default not), then the region supplied in the
	/// CustomDisplayExtents is used in preference.
	/// Note that the Custom extents are x,y only and the zslice is still
	/// applied
	/// </summary>
	public virtual void SetUseCustomExtents(int _arg)
	{
		vtkImageMapper_SetUseCustomExtents_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_SetZSlice_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the current slice number. The axis Z in ZSlice does not
	/// necessarily have any relation to the z axis of the data on disk.
	/// It is simply the axis orthogonal to the x,y, display plane.
	/// GetWholeZMax and Min are convenience methods for obtaining
	/// the number of slices that can be displayed. Again the number
	/// of slices is in reference to the display z axis, which is not
	/// necessarily the z axis on disk. (due to reformatting etc)
	/// </summary>
	public virtual void SetZSlice(int _arg)
	{
		vtkImageMapper_SetZSlice_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_UseCustomExtentsOff_32(HandleRef pThis);

	/// <summary>
	/// Usually, the entire image is displayed, if UseCustomExtents
	/// is set (by default not), then the region supplied in the
	/// CustomDisplayExtents is used in preference.
	/// Note that the Custom extents are x,y only and the zslice is still
	/// applied
	/// </summary>
	public virtual void UseCustomExtentsOff()
	{
		vtkImageMapper_UseCustomExtentsOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper_UseCustomExtentsOn_33(HandleRef pThis);

	/// <summary>
	/// Usually, the entire image is displayed, if UseCustomExtents
	/// is set (by default not), then the region supplied in the
	/// CustomDisplayExtents is used in preference.
	/// Note that the Custom extents are x,y only and the zslice is still
	/// applied
	/// </summary>
	public virtual void UseCustomExtentsOn()
	{
		vtkImageMapper_UseCustomExtentsOn_33(GetCppThis());
	}
}
