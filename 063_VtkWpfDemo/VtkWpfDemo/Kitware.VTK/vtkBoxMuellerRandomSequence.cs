using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBoxMuellerRandomSequence
/// </summary>
/// <remarks>
///    Gaussian sequence of pseudo random numbers implemented with the Box-Mueller transform
///
/// vtkGaussianRandomSequence is a sequence of pseudo random numbers
/// distributed according to the Gaussian/normal distribution (mean=0 and
/// standard deviation=1).
///
/// It based is calculation from a uniformly distributed pseudo random sequence.
/// The initial sequence is a vtkMinimalStandardRandomSequence.
/// </remarks>
public class vtkBoxMuellerRandomSequence : vtkGaussianRandomSequence
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBoxMuellerRandomSequence";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBoxMuellerRandomSequence()
	{
		MRClassNameKey = "class vtkBoxMuellerRandomSequence";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxMuellerRandomSequence"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBoxMuellerRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxMuellerRandomSequence_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkBoxMuellerRandomSequence New()
	{
		vtkBoxMuellerRandomSequence result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxMuellerRandomSequence_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxMuellerRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkBoxMuellerRandomSequence()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBoxMuellerRandomSequence_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxMuellerRandomSequence_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBoxMuellerRandomSequence_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxMuellerRandomSequence_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBoxMuellerRandomSequence_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxMuellerRandomSequence_GetUniformSequence_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the uniformly distributed sequence of random numbers.
	/// </summary>
	public vtkRandomSequence GetUniformSequence()
	{
		vtkRandomSequence vtkRandomSequence2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxMuellerRandomSequence_GetUniformSequence_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRandomSequence2 = (vtkRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRandomSequence2.Register(null);
			}
		}
		return vtkRandomSequence2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBoxMuellerRandomSequence_GetValue_04(HandleRef pThis);

	/// <summary>
	/// Current value.
	/// </summary>
	public override double GetValue()
	{
		return vtkBoxMuellerRandomSequence_GetValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxMuellerRandomSequence_Initialize_05(HandleRef pThis, uint arg0);

	/// <summary>
	/// Satisfy general API of vtkRandomSequence superclass. Initialize the
	/// sequence with a seed.
	/// </summary>
	public override void Initialize(uint arg0)
	{
		vtkBoxMuellerRandomSequence_Initialize_05(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxMuellerRandomSequence_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBoxMuellerRandomSequence_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxMuellerRandomSequence_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBoxMuellerRandomSequence_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxMuellerRandomSequence_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkBoxMuellerRandomSequence NewInstance()
	{
		vtkBoxMuellerRandomSequence result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxMuellerRandomSequence_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxMuellerRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxMuellerRandomSequence_Next_10(HandleRef pThis);

	/// <summary>
	/// Move to the next number in the random sequence.
	/// </summary>
	public override void Next()
	{
		vtkBoxMuellerRandomSequence_Next_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxMuellerRandomSequence_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkBoxMuellerRandomSequence SafeDownCast(vtkObjectBase o)
	{
		vtkBoxMuellerRandomSequence vtkBoxMuellerRandomSequence2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxMuellerRandomSequence_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBoxMuellerRandomSequence2 = (vtkBoxMuellerRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBoxMuellerRandomSequence2.Register(null);
			}
		}
		return vtkBoxMuellerRandomSequence2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxMuellerRandomSequence_SetUniformSequence_12(HandleRef pThis, HandleRef uniformSequence);

	/// <summary>
	/// Set the uniformly distributed sequence of random numbers.
	/// Default is a .
	/// </summary>
	public void SetUniformSequence(vtkRandomSequence uniformSequence)
	{
		vtkBoxMuellerRandomSequence_SetUniformSequence_12(GetCppThis(), uniformSequence?.GetCppThis() ?? default(HandleRef));
	}
}
