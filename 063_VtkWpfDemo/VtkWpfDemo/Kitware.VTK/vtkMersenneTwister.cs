using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMersenneTwister
/// </summary>
/// <remarks>
///    Generator for Mersenne Twister pseudorandom numbers
///
/// vtkMersenneTwister is an implementation of the Mersenne Twister pseudorandom
/// number generator. The VTK class is simply a wrapper around an implementation
/// written by M. Matsumoto, T. Nishimura and M. Saito, whose source code can be
/// found at http://www.math.sci.hiroshima-u.ac.jp/~m-mat/MT/DC/dc.html.
///
/// This implementation of the Mersenne Twister facilitates the generation and
/// query from multiple independent pseudorandom sequences. Independent sequences
/// are identified by a unique vtkMersenneTwister::SequenceId, which is either
/// generated upon request or passed into the initialization method. This id is
/// factored into the initialization of the Mersenne Twister's initial state, so
/// two sequences with the same seed and different sequence ids will produce
/// different results. Once a sequence is initialized with an associated sequence
/// id, this id is used to obtain values from the sequence.
///
/// This class, besides generating random sequences in sequential order, can
/// also populate a double array of specified size with a random sequence. It
/// will do so using one or more threads depending on the number of values
/// requested to generate.
/// </remarks>
public class vtkMersenneTwister : vtkRandomSequence
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMersenneTwister";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMersenneTwister()
	{
		MRClassNameKey = "class vtkMersenneTwister";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMersenneTwister"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMersenneTwister(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMersenneTwister_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkMersenneTwister New()
	{
		vtkMersenneTwister result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMersenneTwister_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMersenneTwister)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkMersenneTwister()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMersenneTwister_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkMersenneTwister_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMersenneTwister_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMersenneTwister_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMersenneTwister_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMersenneTwister_GetValue_03(HandleRef pThis, uint id);

	/// <summary>
	/// Current value
	/// \post unit_range: result&gt;=0.0 &amp;&amp; result&lt;=1.0
	/// </summary>
	public virtual double GetValue(uint id)
	{
		return vtkMersenneTwister_GetValue_03(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMersenneTwister_GetValue_04(HandleRef pThis);

	/// <summary>
	/// Current value
	/// \post unit_range: result&gt;=0.0 &amp;&amp; result&lt;=1.0
	/// </summary>
	public override double GetValue()
	{
		return vtkMersenneTwister_GetValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMersenneTwister_Initialize_05(HandleRef pThis, uint seed);

	/// <summary>
	/// Satisfy general API of vtkRandomSequence superclass. Initialize the
	/// sequence with a seed.
	/// </summary>
	public override void Initialize(uint seed)
	{
		vtkMersenneTwister_Initialize_05(GetCppThis(), seed);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkMersenneTwister_InitializeNewSequence_06(HandleRef pThis, uint seed, int p);

	/// <summary>
	/// Initialize a new Mersenne Twister sequence, given a) a \c seed and b) a
	/// Mersenne exponent (p s.t. 2^p-1 is a Mersenne prime). If \c p is not a
	/// usable Mersenne exponent, its value is used to pick one from a list.
	/// The return value is the id for the generated sequence, which is used as a
	/// key to access values of the sequence.
	/// </summary>
	public uint InitializeNewSequence(uint seed, int p)
	{
		return vtkMersenneTwister_InitializeNewSequence_06(GetCppThis(), seed, p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMersenneTwister_InitializeSequence_07(HandleRef pThis, uint id, uint seed, int p);

	/// <summary>
	/// Initialize a sequence as in InitializeNewSequence(), but additionally pass
	/// an id to associate with the new sequence. If a sequence is already
	/// associated with this id, a warning is given and the sequence is reset using
	/// the given parameters.
	/// </summary>
	public void InitializeSequence(uint id, uint seed, int p)
	{
		vtkMersenneTwister_InitializeSequence_07(GetCppThis(), id, seed, p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMersenneTwister_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMersenneTwister_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMersenneTwister_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMersenneTwister_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMersenneTwister_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkMersenneTwister NewInstance()
	{
		vtkMersenneTwister result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMersenneTwister_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMersenneTwister)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMersenneTwister_Next_12(HandleRef pThis, uint id);

	/// <summary>
	/// Move to the next number in random sequence \c id. If no sequence is
	/// associated with this id, a warning is given and a sequence is generated
	/// with default values.
	/// </summary>
	public virtual void Next(uint id)
	{
		vtkMersenneTwister_Next_12(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMersenneTwister_Next_13(HandleRef pThis);

	/// <summary>
	/// Move to the next number in random sequence &lt;0&gt;. If no sequence is
	/// associated with this id, a warning is given and a sequence is generated
	/// with default values.
	/// </summary>
	public override void Next()
	{
		vtkMersenneTwister_Next_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMersenneTwister_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkMersenneTwister SafeDownCast(vtkObjectBase o)
	{
		vtkMersenneTwister vtkMersenneTwister2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMersenneTwister_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMersenneTwister2 = (vtkMersenneTwister)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMersenneTwister2.Register(null);
			}
		}
		return vtkMersenneTwister2;
	}
}
