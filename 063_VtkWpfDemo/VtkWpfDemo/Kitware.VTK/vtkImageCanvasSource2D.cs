using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageCanvasSource2D
/// </summary>
/// <remarks>
///    Paints on a canvas
///
/// vtkImageCanvasSource2D is a source that starts as a blank image.
/// you may add to the image with two-dimensional drawing routines.
/// It can paint multi-spectral images.
/// </remarks>
public class vtkImageCanvasSource2D : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageCanvasSource2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageCanvasSource2D()
	{
		MRClassNameKey = "class vtkImageCanvasSource2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCanvasSource2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageCanvasSource2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCanvasSource2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageCanvasSource2D with no data.
	/// </summary>
	public new static vtkImageCanvasSource2D New()
	{
		vtkImageCanvasSource2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCanvasSource2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageCanvasSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an instance of vtkImageCanvasSource2D with no data.
	/// </summary>
	public vtkImageCanvasSource2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageCanvasSource2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_DrawCircle_01(HandleRef pThis, int c0, int c1, double radius);

	/// <summary>
	/// Set the pixels inside the box (min0, max0, min1, max1) to the current
	/// DrawColor
	/// </summary>
	public void DrawCircle(int c0, int c1, double radius)
	{
		vtkImageCanvasSource2D_DrawCircle_01(GetCppThis(), c0, c1, radius);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_DrawImage_02(HandleRef pThis, int x0, int y0, HandleRef i);

	/// <summary>
	/// Draw subimage of the input image in the canvas at position x0 and
	/// y0. The subimage is defined with sx, sy, width, and height.
	/// </summary>
	public void DrawImage(int x0, int y0, vtkImageData i)
	{
		vtkImageCanvasSource2D_DrawImage_02(GetCppThis(), x0, y0, i?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_DrawImage_03(HandleRef pThis, int x0, int y0, HandleRef arg2, int sx, int sy, int width, int height);

	/// <summary>
	/// Draw subimage of the input image in the canvas at position x0 and
	/// y0. The subimage is defined with sx, sy, width, and height.
	/// </summary>
	public void DrawImage(int x0, int y0, vtkImageData arg2, int sx, int sy, int width, int height)
	{
		vtkImageCanvasSource2D_DrawImage_03(GetCppThis(), x0, y0, arg2?.GetCppThis() ?? default(HandleRef), sx, sy, width, height);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_DrawPoint_04(HandleRef pThis, int p0, int p1);

	/// <summary>
	/// Set the pixels inside the box (min0, max0, min1, max1) to the current
	/// DrawColor
	/// </summary>
	public void DrawPoint(int p0, int p1)
	{
		vtkImageCanvasSource2D_DrawPoint_04(GetCppThis(), p0, p1);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_DrawSegment_05(HandleRef pThis, int x0, int y0, int x1, int y1);

	/// <summary>
	/// Set the pixels inside the box (min0, max0, min1, max1) to the current
	/// DrawColor
	/// </summary>
	public void DrawSegment(int x0, int y0, int x1, int y1)
	{
		vtkImageCanvasSource2D_DrawSegment_05(GetCppThis(), x0, y0, x1, y1);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_DrawSegment3D_06(HandleRef pThis, IntPtr p0, IntPtr p1);

	/// <summary>
	/// Set the pixels inside the box (min0, max0, min1, max1) to the current
	/// DrawColor
	/// </summary>
	public void DrawSegment3D(IntPtr p0, IntPtr p1)
	{
		vtkImageCanvasSource2D_DrawSegment3D_06(GetCppThis(), p0, p1);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_DrawSegment3D_07(HandleRef pThis, double x1, double y1, double z1, double x2, double y2, double z2);

	/// <summary>
	/// Set the pixels inside the box (min0, max0, min1, max1) to the current
	/// DrawColor
	/// </summary>
	public void DrawSegment3D(double x1, double y1, double z1, double x2, double y2, double z2)
	{
		vtkImageCanvasSource2D_DrawSegment3D_07(GetCppThis(), x1, y1, z1, x2, y2, z2);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_FillBox_08(HandleRef pThis, int min0, int max0, int min1, int max1);

	/// <summary>
	/// Set the pixels inside the box (min0, max0, min1, max1) to the current
	/// DrawColor
	/// </summary>
	public void FillBox(int min0, int max0, int min1, int max1)
	{
		vtkImageCanvasSource2D_FillBox_08(GetCppThis(), min0, max0, min1, max1);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_FillPixel_09(HandleRef pThis, int x, int y);

	/// <summary>
	/// Fill a colored area with another color. (like connectivity)
	/// All pixels connected (and with the same value) to pixel (x, y)
	/// get replaced by the current "DrawColor".
	/// </summary>
	public void FillPixel(int x, int y)
	{
		vtkImageCanvasSource2D_FillPixel_09(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_FillTriangle_10(HandleRef pThis, int x0, int y0, int x1, int y1, int x2, int y2);

	/// <summary>
	/// Set the pixels inside the box (min0, max0, min1, max1) to the current
	/// DrawColor
	/// </summary>
	public void FillTriangle(int x0, int y0, int x1, int y1, int x2, int y2)
	{
		vtkImageCanvasSource2D_FillTriangle_10(GetCppThis(), x0, y0, x1, y1, x2, y2);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_FillTube_11(HandleRef pThis, int x0, int y0, int x1, int y1, double radius);

	/// <summary>
	/// Set the pixels inside the box (min0, max0, min1, max1) to the current
	/// DrawColor
	/// </summary>
	public void FillTube(int x0, int y0, int x1, int y1, double radius)
	{
		vtkImageCanvasSource2D_FillTube_11(GetCppThis(), x0, y0, x1, y1, radius);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCanvasSource2D_GetDefaultZ_12(HandleRef pThis);

	/// <summary>
	/// The drawing operations can only draw into one 2D XY plane at a time.
	/// If the canvas is a 3D volume, then this z value is used
	/// as the default for 2D operations. The default is 0.
	/// </summary>
	public virtual int GetDefaultZ()
	{
		return vtkImageCanvasSource2D_GetDefaultZ_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCanvasSource2D_GetDrawColor_13(HandleRef pThis);

	/// <summary>
	/// Set/Get DrawColor.  This is the value that is used when filling data
	/// or drawing lines. Default is (0,0,0,0)
	/// </summary>
	public virtual double[] GetDrawColor()
	{
		IntPtr intPtr = vtkImageCanvasSource2D_GetDrawColor_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_GetDrawColor_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set/Get DrawColor.  This is the value that is used when filling data
	/// or drawing lines. Default is (0,0,0,0)
	/// </summary>
	public virtual void GetDrawColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkImageCanvasSource2D_GetDrawColor_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_GetDrawColor_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get DrawColor.  This is the value that is used when filling data
	/// or drawing lines. Default is (0,0,0,0)
	/// </summary>
	public virtual void GetDrawColor(IntPtr _arg)
	{
		vtkImageCanvasSource2D_GetDrawColor_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageCanvasSource2D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageCanvasSource2D with no data.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageCanvasSource2D_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageCanvasSource2D_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	/// Construct an instance of vtkImageCanvasSource2D with no data.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageCanvasSource2D_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCanvasSource2D_GetNumberOfScalarComponents_18(HandleRef pThis);

	/// <summary>
	/// Set the number of scalar components
	/// </summary>
	public virtual int GetNumberOfScalarComponents()
	{
		return vtkImageCanvasSource2D_GetNumberOfScalarComponents_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCanvasSource2D_GetRatio_19(HandleRef pThis);

	/// <summary>
	/// Set/Get Ratio. This is the value that is used to pre-multiply each
	/// (x, y, z) drawing coordinates (including DefaultZ). The default
	/// is (1, 1, 1)
	/// </summary>
	public virtual double[] GetRatio()
	{
		IntPtr intPtr = vtkImageCanvasSource2D_GetRatio_19(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_GetRatio_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get Ratio. This is the value that is used to pre-multiply each
	/// (x, y, z) drawing coordinates (including DefaultZ). The default
	/// is (1, 1, 1)
	/// </summary>
	public virtual void GetRatio(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageCanvasSource2D_GetRatio_20(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_GetRatio_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get Ratio. This is the value that is used to pre-multiply each
	/// (x, y, z) drawing coordinates (including DefaultZ). The default
	/// is (1, 1, 1)
	/// </summary>
	public virtual void GetRatio(IntPtr _arg)
	{
		vtkImageCanvasSource2D_GetRatio_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCanvasSource2D_GetScalarType_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public int GetScalarType()
	{
		return vtkImageCanvasSource2D_GetScalarType_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_InitializeCanvasVolume_23(HandleRef pThis, HandleRef volume);

	/// <summary>
	/// Initialize the canvas with a given volume
	/// </summary>
	public void InitializeCanvasVolume(vtkImageData volume)
	{
		vtkImageCanvasSource2D_InitializeCanvasVolume_23(GetCppThis(), volume?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCanvasSource2D_IsA_24(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageCanvasSource2D with no data.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageCanvasSource2D_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCanvasSource2D_IsTypeOf_25(string type);

	/// <summary>
	/// Construct an instance of vtkImageCanvasSource2D with no data.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageCanvasSource2D_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCanvasSource2D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageCanvasSource2D with no data.
	/// </summary>
	public new vtkImageCanvasSource2D NewInstance()
	{
		vtkImageCanvasSource2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCanvasSource2D_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageCanvasSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCanvasSource2D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageCanvasSource2D with no data.
	/// </summary>
	public new static vtkImageCanvasSource2D SafeDownCast(vtkObjectBase o)
	{
		vtkImageCanvasSource2D vtkImageCanvasSource2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCanvasSource2D_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageCanvasSource2D2 = (vtkImageCanvasSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageCanvasSource2D2.Register(null);
			}
		}
		return vtkImageCanvasSource2D2;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetDefaultZ_29(HandleRef pThis, int _arg);

	/// <summary>
	/// The drawing operations can only draw into one 2D XY plane at a time.
	/// If the canvas is a 3D volume, then this z value is used
	/// as the default for 2D operations. The default is 0.
	/// </summary>
	public virtual void SetDefaultZ(int _arg)
	{
		vtkImageCanvasSource2D_SetDefaultZ_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetDrawColor_30(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set/Get DrawColor.  This is the value that is used when filling data
	/// or drawing lines. Default is (0,0,0,0)
	/// </summary>
	public virtual void SetDrawColor(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkImageCanvasSource2D_SetDrawColor_30(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetDrawColor_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get DrawColor.  This is the value that is used when filling data
	/// or drawing lines. Default is (0,0,0,0)
	/// </summary>
	public virtual void SetDrawColor(IntPtr _arg)
	{
		vtkImageCanvasSource2D_SetDrawColor_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetDrawColor_32(HandleRef pThis, double a);

	/// <summary>
	/// Set DrawColor to (a, 0, 0, 0)
	/// </summary>
	public void SetDrawColor(double a)
	{
		vtkImageCanvasSource2D_SetDrawColor_32(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetDrawColor_33(HandleRef pThis, double a, double b);

	/// <summary>
	/// Set DrawColor to (a, b, 0, 0)
	/// </summary>
	public void SetDrawColor(double a, double b)
	{
		vtkImageCanvasSource2D_SetDrawColor_33(GetCppThis(), a, b);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetDrawColor_34(HandleRef pThis, double a, double b, double c);

	/// <summary>
	/// Set DrawColor to (a, b, c, 0)
	/// </summary>
	public void SetDrawColor(double a, double b, double c)
	{
		vtkImageCanvasSource2D_SetDrawColor_34(GetCppThis(), a, b, c);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetExtent_35(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// These methods set the WholeExtent of the output
	/// It sets the size of the canvas.
	/// Extent is a min max 3D box.  Minimums and maximums are inclusive.
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkImageCanvasSource2D_SetExtent_35(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetExtent_36(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

	/// <summary>
	/// These methods set the WholeExtent of the output
	/// It sets the size of the canvas.
	/// Extent is a min max 3D box.  Minimums and maximums are inclusive.
	/// </summary>
	public void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
	{
		vtkImageCanvasSource2D_SetExtent_36(GetCppThis(), x1, x2, y1, y2, z1, z2);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetNumberOfScalarComponents_37(HandleRef pThis, int i);

	/// <summary>
	/// Set the number of scalar components
	/// </summary>
	public virtual void SetNumberOfScalarComponents(int i)
	{
		vtkImageCanvasSource2D_SetNumberOfScalarComponents_37(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetRatio_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get Ratio. This is the value that is used to pre-multiply each
	/// (x, y, z) drawing coordinates (including DefaultZ). The default
	/// is (1, 1, 1)
	/// </summary>
	public virtual void SetRatio(double _arg1, double _arg2, double _arg3)
	{
		vtkImageCanvasSource2D_SetRatio_38(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetRatio_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get Ratio. This is the value that is used to pre-multiply each
	/// (x, y, z) drawing coordinates (including DefaultZ). The default
	/// is (1, 1, 1)
	/// </summary>
	public virtual void SetRatio(IntPtr _arg)
	{
		vtkImageCanvasSource2D_SetRatio_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarType_40(HandleRef pThis, int arg0);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarType(int arg0)
	{
		vtkImageCanvasSource2D_SetScalarType_40(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToChar_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToChar()
	{
		vtkImageCanvasSource2D_SetScalarTypeToChar_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToDouble_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToDouble()
	{
		vtkImageCanvasSource2D_SetScalarTypeToDouble_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToFloat_43(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToFloat()
	{
		vtkImageCanvasSource2D_SetScalarTypeToFloat_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToInt_44(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToInt()
	{
		vtkImageCanvasSource2D_SetScalarTypeToInt_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToLong_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToLong()
	{
		vtkImageCanvasSource2D_SetScalarTypeToLong_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToShort_46(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToShort()
	{
		vtkImageCanvasSource2D_SetScalarTypeToShort_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedChar_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToUnsignedChar()
	{
		vtkImageCanvasSource2D_SetScalarTypeToUnsignedChar_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedInt_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToUnsignedInt()
	{
		vtkImageCanvasSource2D_SetScalarTypeToUnsignedInt_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedLong_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToUnsignedLong()
	{
		vtkImageCanvasSource2D_SetScalarTypeToUnsignedLong_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedShort_50(HandleRef pThis);

	/// <summary>
	/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
	/// are setting and getting the pipeline scalar type. i.e. they are setting
	/// the type that the image data will be once it has executed. Until the
	/// REQUEST_DATA pass the actual scalars may be of some other type. This is
	/// for backwards compatibility
	/// </summary>
	public void SetScalarTypeToUnsignedShort()
	{
		vtkImageCanvasSource2D_SetScalarTypeToUnsignedShort_50(GetCppThis());
	}
}
