using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextSource
/// </summary>
/// <remarks>
///    create polygonal text
///
/// vtkTextSource converts a text string into polygons.  This way you can
/// insert text into your renderings. It uses the 9x15 font from X Windows.
/// You can specify if you want the background to be drawn or not. The
/// characters are formed by scan converting the raster font into
/// quadrilaterals. Colors are assigned to the letters using scalar data.
/// To set the color of the characters with the source's actor property, set
/// BackingOff on the text source and ScalarVisibilityOff on the associated
/// vtkPolyDataMapper. Then, the color can be set using the associated actor's
/// property.
///
/// vtkVectorText generates higher quality polygonal representations of
/// characters.
///
/// </remarks>
/// <seealso>
///
/// vtkVectorText
/// </seealso>
public class vtkTextSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextSource()
	{
		MRClassNameKey = "class vtkTextSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with no string set and backing enabled.
	/// </summary>
	public new static vtkTextSource New()
	{
		vtkTextSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with no string set and backing enabled.
	/// </summary>
	public vtkTextSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_BackingOff_01(HandleRef pThis);

	/// <summary>
	/// Controls whether or not a background is drawn with the text.
	/// </summary>
	public virtual void BackingOff()
	{
		vtkTextSource_BackingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_BackingOn_02(HandleRef pThis);

	/// <summary>
	/// Controls whether or not a background is drawn with the text.
	/// </summary>
	public virtual void BackingOn()
	{
		vtkTextSource_BackingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextSource_GetBackgroundColor_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the background color. Default is black (0,0,0). Alpha is always 1.
	/// </summary>
	public virtual double[] GetBackgroundColor()
	{
		IntPtr intPtr = vtkTextSource_GetBackgroundColor_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_GetBackgroundColor_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the background color. Default is black (0,0,0). Alpha is always 1.
	/// </summary>
	public virtual void GetBackgroundColor(IntPtr data)
	{
		vtkTextSource_GetBackgroundColor_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextSource_GetBacking_05(HandleRef pThis);

	/// <summary>
	/// Controls whether or not a background is drawn with the text.
	/// </summary>
	public virtual int GetBacking()
	{
		return vtkTextSource_GetBacking_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextSource_GetForegroundColor_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the foreground color. Default is white (1,1,1). ALpha is always 1.
	/// </summary>
	public virtual double[] GetForegroundColor()
	{
		IntPtr intPtr = vtkTextSource_GetForegroundColor_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_GetForegroundColor_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the foreground color. Default is white (1,1,1). ALpha is always 1.
	/// </summary>
	public virtual void GetForegroundColor(IntPtr data)
	{
		vtkTextSource_GetForegroundColor_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextSource_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextSource_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextSource_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextSource_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextSource_GetOutputPointsPrecision_10(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkTextSource_GetOutputPointsPrecision_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextSource_GetText_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the text to be drawn.
	/// </summary>
	public virtual string GetText()
	{
		return Marshal.PtrToStringAnsi(vtkTextSource_GetText_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextSource_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextSource_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextSource_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextSource_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextSource NewInstance()
	{
		vtkTextSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextSource_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextSource SafeDownCast(vtkObjectBase o)
	{
		vtkTextSource vtkTextSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextSource_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextSource2 = (vtkTextSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextSource2.Register(null);
			}
		}
		return vtkTextSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_SetBackgroundColor_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the background color. Default is black (0,0,0). Alpha is always 1.
	/// </summary>
	public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
	{
		vtkTextSource_SetBackgroundColor_17(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_SetBackgroundColor_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the background color. Default is black (0,0,0). Alpha is always 1.
	/// </summary>
	public virtual void SetBackgroundColor(IntPtr _arg)
	{
		vtkTextSource_SetBackgroundColor_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_SetBacking_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Controls whether or not a background is drawn with the text.
	/// </summary>
	public virtual void SetBacking(int _arg)
	{
		vtkTextSource_SetBacking_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_SetForegroundColor_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the foreground color. Default is white (1,1,1). ALpha is always 1.
	/// </summary>
	public virtual void SetForegroundColor(double _arg1, double _arg2, double _arg3)
	{
		vtkTextSource_SetForegroundColor_20(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_SetForegroundColor_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the foreground color. Default is white (1,1,1). ALpha is always 1.
	/// </summary>
	public virtual void SetForegroundColor(IntPtr _arg)
	{
		vtkTextSource_SetForegroundColor_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_SetOutputPointsPrecision_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkTextSource_SetOutputPointsPrecision_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextSource_SetText_23(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the text to be drawn.
	/// </summary>
	public virtual void SetText(string _arg)
	{
		vtkTextSource_SetText_23(GetCppThis(), _arg);
	}
}
