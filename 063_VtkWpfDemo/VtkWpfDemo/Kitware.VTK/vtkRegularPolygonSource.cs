using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRegularPolygonSource
/// </summary>
/// <remarks>
///    create a regular, n-sided polygon and/or polyline
///
/// vtkRegularPolygonSource is a source object that creates a single n-sided polygon and/or
/// polyline. The polygon is centered at a specified point, orthogonal to
/// a specified normal, and with a circumscribing radius set by the user. The user can
/// also specify the number of sides of the polygon ranging from [3,N].
///
/// This object can be used for seeding streamlines or defining regions for clipping/cutting.
/// </remarks>
public class vtkRegularPolygonSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRegularPolygonSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRegularPolygonSource()
	{
		MRClassNameKey = "class vtkRegularPolygonSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRegularPolygonSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRegularPolygonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRegularPolygonSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new static vtkRegularPolygonSource New()
	{
		vtkRegularPolygonSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRegularPolygonSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRegularPolygonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public vtkRegularPolygonSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRegularPolygonSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRegularPolygonSource_GeneratePolygonOff_01(HandleRef pThis);

	/// <summary>
	/// Control whether a polygon is produced. By default, GeneratePolygon is enabled.
	/// </summary>
	public virtual void GeneratePolygonOff()
	{
		vtkRegularPolygonSource_GeneratePolygonOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_GeneratePolygonOn_02(HandleRef pThis);

	/// <summary>
	/// Control whether a polygon is produced. By default, GeneratePolygon is enabled.
	/// </summary>
	public virtual void GeneratePolygonOn()
	{
		vtkRegularPolygonSource_GeneratePolygonOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_GeneratePolylineOff_03(HandleRef pThis);

	/// <summary>
	/// Control whether a polyline is produced. By default, GeneratePolyline is enabled.
	/// </summary>
	public virtual void GeneratePolylineOff()
	{
		vtkRegularPolygonSource_GeneratePolylineOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_GeneratePolylineOn_04(HandleRef pThis);

	/// <summary>
	/// Control whether a polyline is produced. By default, GeneratePolyline is enabled.
	/// </summary>
	public virtual void GeneratePolylineOn()
	{
		vtkRegularPolygonSource_GeneratePolylineOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRegularPolygonSource_GetCenter_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the center of the polygon. By default, the center is set at the
	/// origin (0,0,0).
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkRegularPolygonSource_GetCenter_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_GetCenter_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the center of the polygon. By default, the center is set at the
	/// origin (0,0,0).
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkRegularPolygonSource_GetCenter_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRegularPolygonSource_GetGeneratePolygon_07(HandleRef pThis);

	/// <summary>
	/// Control whether a polygon is produced. By default, GeneratePolygon is enabled.
	/// </summary>
	public virtual int GetGeneratePolygon()
	{
		return vtkRegularPolygonSource_GetGeneratePolygon_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRegularPolygonSource_GetGeneratePolyline_08(HandleRef pThis);

	/// <summary>
	/// Control whether a polyline is produced. By default, GeneratePolyline is enabled.
	/// </summary>
	public virtual int GetGeneratePolyline()
	{
		return vtkRegularPolygonSource_GetGeneratePolyline_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRegularPolygonSource_GetNormal_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the normal to the polygon. The ordering of the polygon will be
	/// counter-clockwise around the normal (i.e., using the right-hand rule).
	/// By default, the normal is set to (0,0,1).
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkRegularPolygonSource_GetNormal_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_GetNormal_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the normal to the polygon. The ordering of the polygon will be
	/// counter-clockwise around the normal (i.e., using the right-hand rule).
	/// By default, the normal is set to (0,0,1).
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkRegularPolygonSource_GetNormal_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRegularPolygonSource_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRegularPolygonSource_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRegularPolygonSource_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRegularPolygonSource_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRegularPolygonSource_GetNumberOfSides_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of sides of the polygon. By default, the number of sides
	/// is set to six.
	/// </summary>
	public virtual int GetNumberOfSides()
	{
		return vtkRegularPolygonSource_GetNumberOfSides_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRegularPolygonSource_GetNumberOfSidesMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of sides of the polygon. By default, the number of sides
	/// is set to six.
	/// </summary>
	public virtual int GetNumberOfSidesMaxValue()
	{
		return vtkRegularPolygonSource_GetNumberOfSidesMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRegularPolygonSource_GetNumberOfSidesMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of sides of the polygon. By default, the number of sides
	/// is set to six.
	/// </summary>
	public virtual int GetNumberOfSidesMinValue()
	{
		return vtkRegularPolygonSource_GetNumberOfSidesMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRegularPolygonSource_GetOutputPointsPrecision_16(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkRegularPolygonSource_GetOutputPointsPrecision_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRegularPolygonSource_GetRadius_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the radius of the polygon. By default, the radius is set to 0.5.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkRegularPolygonSource_GetRadius_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRegularPolygonSource_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRegularPolygonSource_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRegularPolygonSource_IsTypeOf_19(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRegularPolygonSource_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRegularPolygonSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new vtkRegularPolygonSource NewInstance()
	{
		vtkRegularPolygonSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRegularPolygonSource_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRegularPolygonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRegularPolygonSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new static vtkRegularPolygonSource SafeDownCast(vtkObjectBase o)
	{
		vtkRegularPolygonSource vtkRegularPolygonSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRegularPolygonSource_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRegularPolygonSource2 = (vtkRegularPolygonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRegularPolygonSource2.Register(null);
			}
		}
		return vtkRegularPolygonSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_SetCenter_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the center of the polygon. By default, the center is set at the
	/// origin (0,0,0).
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkRegularPolygonSource_SetCenter_23(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_SetCenter_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the center of the polygon. By default, the center is set at the
	/// origin (0,0,0).
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkRegularPolygonSource_SetCenter_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_SetGeneratePolygon_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether a polygon is produced. By default, GeneratePolygon is enabled.
	/// </summary>
	public virtual void SetGeneratePolygon(int _arg)
	{
		vtkRegularPolygonSource_SetGeneratePolygon_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_SetGeneratePolyline_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether a polyline is produced. By default, GeneratePolyline is enabled.
	/// </summary>
	public virtual void SetGeneratePolyline(int _arg)
	{
		vtkRegularPolygonSource_SetGeneratePolyline_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_SetNormal_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the normal to the polygon. The ordering of the polygon will be
	/// counter-clockwise around the normal (i.e., using the right-hand rule).
	/// By default, the normal is set to (0,0,1).
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkRegularPolygonSource_SetNormal_27(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_SetNormal_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the normal to the polygon. The ordering of the polygon will be
	/// counter-clockwise around the normal (i.e., using the right-hand rule).
	/// By default, the normal is set to (0,0,1).
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkRegularPolygonSource_SetNormal_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_SetNumberOfSides_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of sides of the polygon. By default, the number of sides
	/// is set to six.
	/// </summary>
	public virtual void SetNumberOfSides(int _arg)
	{
		vtkRegularPolygonSource_SetNumberOfSides_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkRegularPolygonSource_SetOutputPointsPrecision_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRegularPolygonSource_SetRadius_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the radius of the polygon. By default, the radius is set to 0.5.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkRegularPolygonSource_SetRadius_31(GetCppThis(), _arg);
	}
}
