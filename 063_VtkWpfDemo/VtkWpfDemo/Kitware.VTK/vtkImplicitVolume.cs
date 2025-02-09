using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitVolume
/// </summary>
/// <remarks>
///    treat a volume as if it were an implicit function
///
/// vtkImplicitVolume treats a volume (e.g., structured point dataset)
/// as if it were an implicit function. This means it computes a function
/// value and gradient. vtkImplicitVolume is a concrete implementation of
/// vtkImplicitFunction.
///
/// vtkImplicitDataSet computes the function (at the point x) by performing
/// cell interpolation. That is, it finds the cell containing x, and then
/// uses the cell's interpolation functions to compute an interpolated
/// scalar value at x. (A similar approach is used to find the
/// gradient, if requested.) Points outside of the dataset are assigned
/// the value of the ivar OutValue, and the gradient value OutGradient.
///
/// @warning
/// The input volume data is only updated when GetMTime() is called.
/// Works for 3D structured points datasets, 0D-2D datasets won't work properly.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction vtkImplicitDataSet vtkClipPolyData vtkCutter
/// vtkImplicitWindowFunction
/// </seealso>
public class vtkImplicitVolume : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitVolume";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitVolume()
	{
		MRClassNameKey = "class vtkImplicitVolume";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitVolume"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an vtkImplicitVolume with no initial volume; the OutValue
	/// set to a large negative number; and the OutGradient set to (0,0,1).
	/// </summary>
	public new static vtkImplicitVolume New()
	{
		vtkImplicitVolume result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an vtkImplicitVolume with no initial volume; the OutValue
	/// set to a large negative number; and the OutGradient set to (0,0,1).
	/// </summary>
	public vtkImplicitVolume()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitVolume_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate the ImplicitVolume. This returns the interpolated scalar value
	/// at x[3].
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitVolume_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitVolume_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

	/// <summary>
	/// Evaluate ImplicitVolume gradient.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr n)
	{
		vtkImplicitVolume_EvaluateGradient_02(GetCppThis(), x, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImplicitVolume_GetMTime_03(HandleRef pThis);

	/// <summary>
	/// Returns the mtime also considering the volume.  This also calls Update
	/// on the volume, and it therefore must be called before the function is
	/// evaluated.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImplicitVolume_GetMTime_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitVolume_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitVolume_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitVolume_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitVolume_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitVolume_GetOutGradient_06(HandleRef pThis);

	/// <summary>
	/// Set the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual double[] GetOutGradient()
	{
		IntPtr intPtr = vtkImplicitVolume_GetOutGradient_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitVolume_GetOutGradient_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual void GetOutGradient(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImplicitVolume_GetOutGradient_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitVolume_GetOutGradient_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual void GetOutGradient(IntPtr _arg)
	{
		vtkImplicitVolume_GetOutGradient_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitVolume_GetOutValue_09(HandleRef pThis);

	/// <summary>
	/// Set the function value to use for points outside of the dataset.
	/// </summary>
	public virtual double GetOutValue()
	{
		return vtkImplicitVolume_GetOutValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitVolume_GetVolume_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the volume for the implicit function.
	/// </summary>
	public virtual vtkImageData GetVolume()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitVolume_GetVolume_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitVolume_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitVolume_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitVolume_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitVolume_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitVolume_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitVolume NewInstance()
	{
		vtkImplicitVolume result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitVolume_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitVolume_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitVolume SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitVolume vtkImplicitVolume2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitVolume_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitVolume2 = (vtkImplicitVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitVolume2.Register(null);
			}
		}
		return vtkImplicitVolume2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitVolume_SetOutGradient_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual void SetOutGradient(double _arg1, double _arg2, double _arg3)
	{
		vtkImplicitVolume_SetOutGradient_16(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitVolume_SetOutGradient_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual void SetOutGradient(IntPtr _arg)
	{
		vtkImplicitVolume_SetOutGradient_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitVolume_SetOutValue_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the function value to use for points outside of the dataset.
	/// </summary>
	public virtual void SetOutValue(double _arg)
	{
		vtkImplicitVolume_SetOutValue_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitVolume_SetVolume_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the volume for the implicit function.
	/// </summary>
	public virtual void SetVolume(vtkImageData arg0)
	{
		vtkImplicitVolume_SetVolume_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
