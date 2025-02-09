using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSampleImplicitFunctionFilter
/// </summary>
/// <remarks>
///    sample an implicit function over a dataset,
/// generating scalar values and optional gradient vectors
///
///
/// vtkSampleImplicitFunctionFilter is a filter that evaluates an implicit function and
/// (optional) gradients at each point in an input vtkDataSet. The output
/// of the filter are new scalar values (the function values) and the
/// optional vector (function gradient) array.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkSampleFunction vtkImplicitModeller
/// </seealso>
public class vtkSampleImplicitFunctionFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSampleImplicitFunctionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSampleImplicitFunctionFilter()
	{
		MRClassNameKey = "class vtkSampleImplicitFunctionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSampleImplicitFunctionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSampleImplicitFunctionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleImplicitFunctionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type information, and print methods.
	/// </summary>
	public new static vtkSampleImplicitFunctionFilter New()
	{
		vtkSampleImplicitFunctionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSampleImplicitFunctionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSampleImplicitFunctionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard instantiation, type information, and print methods.
	/// </summary>
	public vtkSampleImplicitFunctionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSampleImplicitFunctionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSampleImplicitFunctionFilter_ComputeGradientsOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of gradients.
	/// </summary>
	public virtual void ComputeGradientsOff()
	{
		vtkSampleImplicitFunctionFilter_ComputeGradientsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleImplicitFunctionFilter_ComputeGradientsOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of gradients.
	/// </summary>
	public virtual void ComputeGradientsOn()
	{
		vtkSampleImplicitFunctionFilter_ComputeGradientsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSampleImplicitFunctionFilter_GetComputeGradients_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of gradients.
	/// </summary>
	public virtual int GetComputeGradients()
	{
		return vtkSampleImplicitFunctionFilter_GetComputeGradients_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleImplicitFunctionFilter_GetGradientArrayName_04(HandleRef pThis);

	/// <summary>
	/// Set/get the gradient array name for this data set. The initial value is
	/// "Implicit gradients".
	/// </summary>
	public virtual string GetGradientArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkSampleImplicitFunctionFilter_GetGradientArrayName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleImplicitFunctionFilter_GetImplicitFunction_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function to use to generate data.
	/// </summary>
	public virtual vtkImplicitFunction GetImplicitFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSampleImplicitFunctionFilter_GetImplicitFunction_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSampleImplicitFunctionFilter_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Return the MTime also taking into account the implicit function.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSampleImplicitFunctionFilter_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSampleImplicitFunctionFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiation, type information, and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSampleImplicitFunctionFilter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSampleImplicitFunctionFilter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard instantiation, type information, and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSampleImplicitFunctionFilter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleImplicitFunctionFilter_GetScalarArrayName_09(HandleRef pThis);

	/// <summary>
	/// Set/get the scalar array name for this data set. The initial value is
	/// "Implicit scalars".
	/// </summary>
	public virtual string GetScalarArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkSampleImplicitFunctionFilter_GetScalarArrayName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSampleImplicitFunctionFilter_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiation, type information, and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSampleImplicitFunctionFilter_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSampleImplicitFunctionFilter_IsTypeOf_11(string type);

	/// <summary>
	/// Standard instantiation, type information, and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSampleImplicitFunctionFilter_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleImplicitFunctionFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type information, and print methods.
	/// </summary>
	public new vtkSampleImplicitFunctionFilter NewInstance()
	{
		vtkSampleImplicitFunctionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSampleImplicitFunctionFilter_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSampleImplicitFunctionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleImplicitFunctionFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type information, and print methods.
	/// </summary>
	public new static vtkSampleImplicitFunctionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSampleImplicitFunctionFilter vtkSampleImplicitFunctionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSampleImplicitFunctionFilter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSampleImplicitFunctionFilter2 = (vtkSampleImplicitFunctionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSampleImplicitFunctionFilter2.Register(null);
			}
		}
		return vtkSampleImplicitFunctionFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleImplicitFunctionFilter_SetComputeGradients_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the computation of gradients.
	/// </summary>
	public virtual void SetComputeGradients(int _arg)
	{
		vtkSampleImplicitFunctionFilter_SetComputeGradients_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleImplicitFunctionFilter_SetGradientArrayName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the gradient array name for this data set. The initial value is
	/// "Implicit gradients".
	/// </summary>
	public virtual void SetGradientArrayName(string _arg)
	{
		vtkSampleImplicitFunctionFilter_SetGradientArrayName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleImplicitFunctionFilter_SetImplicitFunction_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function to use to generate data.
	/// </summary>
	public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
	{
		vtkSampleImplicitFunctionFilter_SetImplicitFunction_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleImplicitFunctionFilter_SetScalarArrayName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the scalar array name for this data set. The initial value is
	/// "Implicit scalars".
	/// </summary>
	public virtual void SetScalarArrayName(string _arg)
	{
		vtkSampleImplicitFunctionFilter_SetScalarArrayName_18(GetCppThis(), _arg);
	}
}
