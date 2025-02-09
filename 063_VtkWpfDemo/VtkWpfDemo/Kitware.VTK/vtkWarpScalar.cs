using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWarpScalar
/// </summary>
/// <remarks>
///    deform geometry with scalar data
///
/// vtkWarpScalar is a filter that modifies point coordinates by moving
/// points along point normals by the scalar amount times the scale factor.
/// Useful for creating carpet or x-y-z plots.
///
/// If normals are not present in data, the Normal instance variable will
/// be used as the direction along which to warp the geometry. If normals are
/// present but you would like to use the Normal instance variable, set the
/// UseNormal boolean to true.
///
/// If XYPlane boolean is set true, then the z-value is considered to be
/// a scalar value (still scaled by scale factor), and the displacement is
/// along the z-axis. If scalars are also present, these are copied through
/// and can be used to color the surface.
///
/// Note that the filter passes both its point data and cell data to
/// its output, except for normals, since these are distorted by the
/// warping.
/// </remarks>
public class vtkWarpScalar : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWarpScalar";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWarpScalar()
	{
		MRClassNameKey = "class vtkWarpScalar";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpScalar"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWarpScalar(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpScalar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new static vtkWarpScalar New()
	{
		vtkWarpScalar result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpScalar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWarpScalar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public vtkWarpScalar()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWarpScalar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkWarpScalar_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Set/Get for a property flag that makes the filter include the input data set in the output and
	/// connects the output surface to the input surface through "side walls" effectively making a
	/// single grid enclosing a volume.
	///
	/// In order to use this functionality correctly, the input must be a two dimensional surface and
	/// cannot be 3D.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkWarpScalar_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_GenerateEnclosureOff_02(HandleRef pThis);

	/// <summary>
	/// Set/Get for a property flag that makes the filter include the input data set in the output and
	/// connects the output surface to the input surface through "side walls" effectively making a
	/// single grid enclosing a volume.
	///
	/// In order to use this functionality correctly, the input must be a two dimensional surface and
	/// cannot be 3D.
	/// </summary>
	public virtual void GenerateEnclosureOff()
	{
		vtkWarpScalar_GenerateEnclosureOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_GenerateEnclosureOn_03(HandleRef pThis);

	/// <summary>
	/// Set/Get for a property flag that makes the filter include the input data set in the output and
	/// connects the output surface to the input surface through "side walls" effectively making a
	/// single grid enclosing a volume.
	///
	/// In order to use this functionality correctly, the input must be a two dimensional surface and
	/// cannot be 3D.
	/// </summary>
	public virtual void GenerateEnclosureOn()
	{
		vtkWarpScalar_GenerateEnclosureOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWarpScalar_GetGenerateEnclosure_04(HandleRef pThis);

	/// <summary>
	/// Set/Get for a property flag that makes the filter include the input data set in the output and
	/// connects the output surface to the input surface through "side walls" effectively making a
	/// single grid enclosing a volume.
	///
	/// In order to use this functionality correctly, the input must be a two dimensional surface and
	/// cannot be 3D.
	/// </summary>
	public virtual bool GetGenerateEnclosure()
	{
		return (vtkWarpScalar_GetGenerateEnclosure_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpScalar_GetNormal_05(HandleRef pThis);

	/// <summary>
	/// Normal (i.e., direction) along which to warp geometry. Only used
	/// if UseNormal boolean set to true or no normals available in data.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkWarpScalar_GetNormal_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_GetNormal_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Normal (i.e., direction) along which to warp geometry. Only used
	/// if UseNormal boolean set to true or no normals available in data.
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkWarpScalar_GetNormal_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpScalar_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWarpScalar_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpScalar_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWarpScalar_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpScalar_GetOutputPointsPrecision_09(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points type. By default
	/// (DEFAULT_PRECISION) the output type is SINGLE_PRECISION, otherwise it is
	/// either SINGLE_PRECISION or DOUBLE_PRECISION as specified by the user.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkWarpScalar_GetOutputPointsPrecision_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpScalar_GetScaleFactor_10(HandleRef pThis);

	/// <summary>
	/// Specify value to scale displacement.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkWarpScalar_GetScaleFactor_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpScalar_GetUseNormal_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off use of user specified normal. If on, data normals
	/// will be ignored and instance variable Normal will be used instead.
	/// </summary>
	public virtual int GetUseNormal()
	{
		return vtkWarpScalar_GetUseNormal_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpScalar_GetXYPlane_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag specifying that input data is x-y plane. If x-y plane,
	/// then the z value is used to warp the surface in the z-axis direction
	/// (times the scale factor) and scalars are used to color the surface.
	/// </summary>
	public virtual int GetXYPlane()
	{
		return vtkWarpScalar_GetXYPlane_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpScalar_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWarpScalar_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpScalar_IsTypeOf_14(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWarpScalar_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpScalar_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new vtkWarpScalar NewInstance()
	{
		vtkWarpScalar result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpScalar_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWarpScalar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpScalar_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information,
	/// and printing.
	/// </summary>
	public new static vtkWarpScalar SafeDownCast(vtkObjectBase o)
	{
		vtkWarpScalar vtkWarpScalar2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpScalar_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWarpScalar2 = (vtkWarpScalar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWarpScalar2.Register(null);
			}
		}
		return vtkWarpScalar2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_SetGenerateEnclosure_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get for a property flag that makes the filter include the input data set in the output and
	/// connects the output surface to the input surface through "side walls" effectively making a
	/// single grid enclosing a volume.
	///
	/// In order to use this functionality correctly, the input must be a two dimensional surface and
	/// cannot be 3D.
	/// </summary>
	public virtual void SetGenerateEnclosure(bool _arg)
	{
		vtkWarpScalar_SetGenerateEnclosure_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_SetNormal_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Normal (i.e., direction) along which to warp geometry. Only used
	/// if UseNormal boolean set to true or no normals available in data.
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkWarpScalar_SetNormal_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_SetNormal_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Normal (i.e., direction) along which to warp geometry. Only used
	/// if UseNormal boolean set to true or no normals available in data.
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkWarpScalar_SetNormal_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_SetOutputPointsPrecision_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points type. By default
	/// (DEFAULT_PRECISION) the output type is SINGLE_PRECISION, otherwise it is
	/// either SINGLE_PRECISION or DOUBLE_PRECISION as specified by the user.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkWarpScalar_SetOutputPointsPrecision_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_SetScaleFactor_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify value to scale displacement.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkWarpScalar_SetScaleFactor_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_SetUseNormal_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off use of user specified normal. If on, data normals
	/// will be ignored and instance variable Normal will be used instead.
	/// </summary>
	public virtual void SetUseNormal(int _arg)
	{
		vtkWarpScalar_SetUseNormal_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_SetXYPlane_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off flag specifying that input data is x-y plane. If x-y plane,
	/// then the z value is used to warp the surface in the z-axis direction
	/// (times the scale factor) and scalars are used to color the surface.
	/// </summary>
	public virtual void SetXYPlane(int _arg)
	{
		vtkWarpScalar_SetXYPlane_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_UseNormalOff_25(HandleRef pThis);

	/// <summary>
	/// Turn on/off use of user specified normal. If on, data normals
	/// will be ignored and instance variable Normal will be used instead.
	/// </summary>
	public virtual void UseNormalOff()
	{
		vtkWarpScalar_UseNormalOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_UseNormalOn_26(HandleRef pThis);

	/// <summary>
	/// Turn on/off use of user specified normal. If on, data normals
	/// will be ignored and instance variable Normal will be used instead.
	/// </summary>
	public virtual void UseNormalOn()
	{
		vtkWarpScalar_UseNormalOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_XYPlaneOff_27(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag specifying that input data is x-y plane. If x-y plane,
	/// then the z value is used to warp the surface in the z-axis direction
	/// (times the scale factor) and scalars are used to color the surface.
	/// </summary>
	public virtual void XYPlaneOff()
	{
		vtkWarpScalar_XYPlaneOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpScalar_XYPlaneOn_28(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag specifying that input data is x-y plane. If x-y plane,
	/// then the z value is used to warp the surface in the z-axis direction
	/// (times the scale factor) and scalars are used to color the surface.
	/// </summary>
	public virtual void XYPlaneOn()
	{
		vtkWarpScalar_XYPlaneOn_28(GetCppThis());
	}
}
