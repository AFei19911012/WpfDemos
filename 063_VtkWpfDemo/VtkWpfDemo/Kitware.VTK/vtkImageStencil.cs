using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageStencil
/// </summary>
/// <remarks>
///    combine images via a cookie-cutter operation
///
/// vtkImageStencil will combine two images together using a stencil.
/// The stencil should be provided in the form of a vtkImageStencilData,
/// </remarks>
public class vtkImageStencil : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencil";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageStencil()
	{
		MRClassNameKey = "class vtkImageStencil";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencil"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStencil New()
	{
		vtkImageStencil result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageStencil()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencil_GetBackgroundColor_01(HandleRef pThis);

	/// <summary>
	/// Set the default color to use when the second input is not set.
	/// This is like SetBackgroundValue, but for multi-component images.
	/// </summary>
	public virtual double[] GetBackgroundColor()
	{
		IntPtr intPtr = vtkImageStencil_GetBackgroundColor_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_GetBackgroundColor_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set the default color to use when the second input is not set.
	/// This is like SetBackgroundValue, but for multi-component images.
	/// </summary>
	public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkImageStencil_GetBackgroundColor_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_GetBackgroundColor_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the default color to use when the second input is not set.
	/// This is like SetBackgroundValue, but for multi-component images.
	/// </summary>
	public virtual void GetBackgroundColor(IntPtr _arg)
	{
		vtkImageStencil_GetBackgroundColor_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencil_GetBackgroundInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the second input.  This image will be used for the 'outside' of the
	/// stencil.  If not set, the output voxels will be filled with
	/// BackgroundValue instead.
	/// </summary>
	public vtkImageData GetBackgroundInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencil_GetBackgroundInput_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageStencil_GetBackgroundValue_05(HandleRef pThis);

	/// <summary>
	/// Set the default output value to use when the second input is not set.
	/// </summary>
	public double GetBackgroundValue()
	{
		return vtkImageStencil_GetBackgroundValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStencil_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageStencil_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStencil_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageStencil_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencil_GetReverseStencil_08(HandleRef pThis);

	/// <summary>
	/// Reverse the stencil.
	/// </summary>
	public virtual int GetReverseStencil()
	{
		return vtkImageStencil_GetReverseStencil_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencil_GetStencil_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the stencil to use.  The stencil can be created
	/// from a vtkImplicitFunction or a vtkPolyData. This
	/// function does not setup a pipeline connection.
	/// </summary>
	public vtkImageStencilData GetStencil()
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencil_GetStencil_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencil_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageStencil_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencil_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageStencil_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencil_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageStencil NewInstance()
	{
		vtkImageStencil result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencil_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_ReverseStencilOff_14(HandleRef pThis);

	/// <summary>
	/// Reverse the stencil.
	/// </summary>
	public virtual void ReverseStencilOff()
	{
		vtkImageStencil_ReverseStencilOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_ReverseStencilOn_15(HandleRef pThis);

	/// <summary>
	/// Reverse the stencil.
	/// </summary>
	public virtual void ReverseStencilOn()
	{
		vtkImageStencil_ReverseStencilOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencil_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStencil SafeDownCast(vtkObjectBase o)
	{
		vtkImageStencil vtkImageStencil2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencil_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencil2 = (vtkImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencil2.Register(null);
			}
		}
		return vtkImageStencil2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_SetBackgroundColor_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set the default color to use when the second input is not set.
	/// This is like SetBackgroundValue, but for multi-component images.
	/// </summary>
	public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkImageStencil_SetBackgroundColor_17(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_SetBackgroundColor_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the default color to use when the second input is not set.
	/// This is like SetBackgroundValue, but for multi-component images.
	/// </summary>
	public virtual void SetBackgroundColor(IntPtr _arg)
	{
		vtkImageStencil_SetBackgroundColor_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_SetBackgroundInputData_19(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the second input.  This image will be used for the 'outside' of the
	/// stencil.  If not set, the output voxels will be filled with
	/// BackgroundValue instead.
	/// </summary>
	public virtual void SetBackgroundInputData(vtkImageData input)
	{
		vtkImageStencil_SetBackgroundInputData_19(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_SetBackgroundValue_20(HandleRef pThis, double val);

	/// <summary>
	/// Set the default output value to use when the second input is not set.
	/// </summary>
	public void SetBackgroundValue(double val)
	{
		vtkImageStencil_SetBackgroundValue_20(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_SetReverseStencil_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Reverse the stencil.
	/// </summary>
	public virtual void SetReverseStencil(int _arg)
	{
		vtkImageStencil_SetReverseStencil_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_SetStencilConnection_22(HandleRef pThis, HandleRef outputPort);

	/// <summary>
	/// Specify the stencil to use. This sets up a pipeline connection.
	/// </summary>
	public void SetStencilConnection(vtkAlgorithmOutput outputPort)
	{
		vtkImageStencil_SetStencilConnection_22(GetCppThis(), outputPort?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencil_SetStencilData_23(HandleRef pThis, HandleRef stencil);

	/// <summary>
	/// Specify the stencil to use.  The stencil can be created
	/// from a vtkImplicitFunction or a vtkPolyData. This
	/// function does not setup a pipeline connection.
	/// </summary>
	public virtual void SetStencilData(vtkImageStencilData stencil)
	{
		vtkImageStencil_SetStencilData_23(GetCppThis(), stencil?.GetCppThis() ?? default(HandleRef));
	}
}
