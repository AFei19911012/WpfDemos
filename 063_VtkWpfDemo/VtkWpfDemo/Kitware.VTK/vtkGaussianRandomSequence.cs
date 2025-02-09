using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGaussianRandomSequence
/// </summary>
/// <remarks>
///    Gaussian sequence of pseudo random numbers
///
/// vtkGaussianRandomSequence is a sequence of pseudo random numbers
/// distributed according to the Gaussian/normal distribution (mean=0 and
/// standard deviation=1)
///
/// This is just an interface.
/// </remarks>
public abstract class vtkGaussianRandomSequence : vtkRandomSequence
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianRandomSequence";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGaussianRandomSequence()
	{
		MRClassNameKey = "class vtkGaussianRandomSequence";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianRandomSequence"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGaussianRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianRandomSequence_GetNextScaledValue_01(HandleRef pThis, double mean, double standardDeviation);

	/// <summary>
	/// Return the next value in the sequence given the mean and standard
	/// deviation of the Gaussian.
	///
	/// \see vtkGaussianRandomSequence::GetScaledValue
	/// </summary>
	public double GetNextScaledValue(double mean, double standardDeviation)
	{
		return vtkGaussianRandomSequence_GetNextScaledValue_01(GetCppThis(), mean, standardDeviation);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGaussianRandomSequence_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGaussianRandomSequence_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGaussianRandomSequence_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGaussianRandomSequence_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianRandomSequence_GetScaledValue_04(HandleRef pThis, double mean, double standardDeviation);

	/// <summary>
	/// Convenient method to return a value given the mean and standard deviation
	/// of the Gaussian distribution from the Gaussian distribution of mean=0
	/// and standard deviation=1.0. There is an initial implementation that can
	/// be overridden by a subclass.
	/// </summary>
	public virtual double GetScaledValue(double mean, double standardDeviation)
	{
		return vtkGaussianRandomSequence_GetScaledValue_04(GetCppThis(), mean, standardDeviation);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianRandomSequence_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGaussianRandomSequence_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianRandomSequence_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGaussianRandomSequence_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianRandomSequence_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkGaussianRandomSequence NewInstance()
	{
		vtkGaussianRandomSequence result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGaussianRandomSequence_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGaussianRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianRandomSequence_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkGaussianRandomSequence SafeDownCast(vtkObjectBase o)
	{
		vtkGaussianRandomSequence vtkGaussianRandomSequence2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGaussianRandomSequence_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGaussianRandomSequence2 = (vtkGaussianRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGaussianRandomSequence2.Register(null);
			}
		}
		return vtkGaussianRandomSequence2;
	}
}
