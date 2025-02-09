using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRandomSequence
/// </summary>
/// <remarks>
///    Generate a sequence of random numbers.
///
/// vtkRandomSequence defines the interface of any sequence of random numbers.
///
/// At this level of abstraction, there is no assumption about the distribution
/// of the numbers or about the quality of the sequence of numbers to be
/// statistically independent. There is no assumption about the range of values.
///
/// To the question about why a random "sequence" class instead of a random
/// "generator" class or to a random "number" class?, see the OOSC book:
/// "Object-Oriented Software Construction", 2nd Edition, by Bertrand Meyer.
/// chapter 23, "Principles of class design", "Pseudo-random number
/// generators: a design exercise", page 754--755.
/// </remarks>
public abstract class vtkRandomSequence : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRandomSequence";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRandomSequence()
	{
		MRClassNameKey = "class vtkRandomSequence";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomSequence"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern double vtkRandomSequence_GetNextValue_01(HandleRef pThis);

	/// <summary>
	/// Advance the sequence and return the new value.
	/// </summary>
	public double GetNextValue()
	{
		return vtkRandomSequence_GetNextValue_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomSequence_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRandomSequence_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomSequence_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRandomSequence_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRandomSequence_GetValue_04(HandleRef pThis);

	/// <summary>
	/// Return the current value.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkRandomSequence_GetValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomSequence_Initialize_05(HandleRef pThis, uint seed);

	/// <summary>
	/// Initialize the sequence with a seed.
	/// </summary>
	public virtual void Initialize(uint seed)
	{
		vtkRandomSequence_Initialize_05(GetCppThis(), seed);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomSequence_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRandomSequence_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomSequence_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRandomSequence_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomSequence_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkRandomSequence NewInstance()
	{
		vtkRandomSequence result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomSequence_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomSequence_Next_09(HandleRef pThis);

	/// <summary>
	/// Move to the next number in the random sequence.
	/// </summary>
	public virtual void Next()
	{
		vtkRandomSequence_Next_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomSequence_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkRandomSequence SafeDownCast(vtkObjectBase o)
	{
		vtkRandomSequence vtkRandomSequence2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomSequence_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
}
