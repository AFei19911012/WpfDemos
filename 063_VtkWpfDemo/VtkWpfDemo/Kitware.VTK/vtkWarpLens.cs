using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWarpLens
/// </summary>
/// <remarks>
///    deform geometry by applying lens distortion
///
/// vtkWarpLens is a filter that modifies point coordinates by moving
/// in accord with a lens distortion model.
/// </remarks>
public class vtkWarpLens : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWarpLens";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWarpLens()
	{
		MRClassNameKey = "class vtkWarpLens";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpLens"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWarpLens(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpLens_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWarpLens New()
	{
		vtkWarpLens result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpLens_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWarpLens)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWarpLens()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWarpLens_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkWarpLens_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Specify the image width / height in pixels
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkWarpLens_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpLens_GetCenter_02(HandleRef pThis);

	/// <summary>
	/// Specify the center of radial distortion in pixels.
	/// This is obsoleted by newer instance variables.
	/// </summary>
	public double[] GetCenter()
	{
		IntPtr intPtr = vtkWarpLens_GetCenter_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpLens_GetFormatHeight_03(HandleRef pThis);

	/// <summary>
	/// Specify the imager format width / height in mm
	/// </summary>
	public virtual double GetFormatHeight()
	{
		return vtkWarpLens_GetFormatHeight_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpLens_GetFormatWidth_04(HandleRef pThis);

	/// <summary>
	/// Specify the imager format width / height in mm
	/// </summary>
	public virtual double GetFormatWidth()
	{
		return vtkWarpLens_GetFormatWidth_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpLens_GetImageHeight_05(HandleRef pThis);

	/// <summary>
	/// Specify the image width / height in pixels
	/// </summary>
	public virtual int GetImageHeight()
	{
		return vtkWarpLens_GetImageHeight_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpLens_GetImageWidth_06(HandleRef pThis);

	/// <summary>
	/// Specify the image width / height in pixels
	/// </summary>
	public virtual int GetImageWidth()
	{
		return vtkWarpLens_GetImageWidth_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpLens_GetK1_07(HandleRef pThis);

	/// <summary>
	/// Specify the symmetric radial distortion parameters for the lens
	/// </summary>
	public virtual double GetK1()
	{
		return vtkWarpLens_GetK1_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpLens_GetK2_08(HandleRef pThis);

	/// <summary>
	/// Specify the symmetric radial distortion parameters for the lens
	/// </summary>
	public virtual double GetK2()
	{
		return vtkWarpLens_GetK2_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpLens_GetKappa_09(HandleRef pThis);

	/// <summary>
	/// Specify second order symmetric radial lens distortion parameter.
	/// This is obsoleted by newer instance variables.
	/// </summary>
	public double GetKappa()
	{
		return vtkWarpLens_GetKappa_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpLens_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWarpLens_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWarpLens_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWarpLens_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpLens_GetP1_12(HandleRef pThis);

	/// <summary>
	/// Specify the decentering distortion parameters for the lens
	/// </summary>
	public virtual double GetP1()
	{
		return vtkWarpLens_GetP1_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWarpLens_GetP2_13(HandleRef pThis);

	/// <summary>
	/// Specify the decentering distortion parameters for the lens
	/// </summary>
	public virtual double GetP2()
	{
		return vtkWarpLens_GetP2_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpLens_GetPrincipalPoint_14(HandleRef pThis);

	/// <summary>
	/// Specify the calibrated principal point of the camera/lens
	/// </summary>
	public virtual double[] GetPrincipalPoint()
	{
		IntPtr intPtr = vtkWarpLens_GetPrincipalPoint_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_GetPrincipalPoint_15(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the calibrated principal point of the camera/lens
	/// </summary>
	public virtual void GetPrincipalPoint(IntPtr data)
	{
		vtkWarpLens_GetPrincipalPoint_15(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpLens_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWarpLens_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWarpLens_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWarpLens_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpLens_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWarpLens NewInstance()
	{
		vtkWarpLens result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpLens_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWarpLens)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWarpLens_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWarpLens SafeDownCast(vtkObjectBase o)
	{
		vtkWarpLens vtkWarpLens2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWarpLens_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWarpLens2 = (vtkWarpLens)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWarpLens2.Register(null);
			}
		}
		return vtkWarpLens2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetCenter_21(HandleRef pThis, double centerX, double centerY);

	/// <summary>
	/// Specify the center of radial distortion in pixels.
	/// This is obsoleted by newer instance variables.
	/// </summary>
	public void SetCenter(double centerX, double centerY)
	{
		vtkWarpLens_SetCenter_21(GetCppThis(), centerX, centerY);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetFormatHeight_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the imager format width / height in mm
	/// </summary>
	public virtual void SetFormatHeight(double _arg)
	{
		vtkWarpLens_SetFormatHeight_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetFormatWidth_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the imager format width / height in mm
	/// </summary>
	public virtual void SetFormatWidth(double _arg)
	{
		vtkWarpLens_SetFormatWidth_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetImageHeight_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the image width / height in pixels
	/// </summary>
	public virtual void SetImageHeight(int _arg)
	{
		vtkWarpLens_SetImageHeight_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetImageWidth_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the image width / height in pixels
	/// </summary>
	public virtual void SetImageWidth(int _arg)
	{
		vtkWarpLens_SetImageWidth_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetK1_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the symmetric radial distortion parameters for the lens
	/// </summary>
	public virtual void SetK1(double _arg)
	{
		vtkWarpLens_SetK1_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetK2_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the symmetric radial distortion parameters for the lens
	/// </summary>
	public virtual void SetK2(double _arg)
	{
		vtkWarpLens_SetK2_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetKappa_28(HandleRef pThis, double kappa);

	/// <summary>
	/// Specify second order symmetric radial lens distortion parameter.
	/// This is obsoleted by newer instance variables.
	/// </summary>
	public void SetKappa(double kappa)
	{
		vtkWarpLens_SetKappa_28(GetCppThis(), kappa);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetP1_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the decentering distortion parameters for the lens
	/// </summary>
	public virtual void SetP1(double _arg)
	{
		vtkWarpLens_SetP1_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetP2_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the decentering distortion parameters for the lens
	/// </summary>
	public virtual void SetP2(double _arg)
	{
		vtkWarpLens_SetP2_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetPrincipalPoint_31(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify the calibrated principal point of the camera/lens
	/// </summary>
	public virtual void SetPrincipalPoint(double _arg1, double _arg2)
	{
		vtkWarpLens_SetPrincipalPoint_31(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWarpLens_SetPrincipalPoint_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the calibrated principal point of the camera/lens
	/// </summary>
	public void SetPrincipalPoint(IntPtr _arg)
	{
		vtkWarpLens_SetPrincipalPoint_32(GetCppThis(), _arg);
	}
}
