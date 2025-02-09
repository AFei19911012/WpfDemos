using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRandomPool
/// </summary>
/// <remarks>
///    convenience class to quickly generate a pool of random numbers
///
/// vtkRandomPool generates random numbers, and can do so using
/// multithreading.  It supports parallel applications where generating random
/// numbers on the fly is difficult (i.e., non-deterministic). Also, it can be
/// used to populate vtkDataArrays in an efficient manner. By default it uses
/// an instance of vtkMersenneTwister to generate random sequences, but any
/// subclass of vtkRandomSequence may be used. It also supports simple methods
/// to generate, access, and pass random memory pools between objects.
///
/// In threaded applications, these class may be conveniently used to
/// pre-generate a sequence of random numbers, followed by the use of
/// deterministic accessor methods to produce random sequences without
/// problems etc. due to unpredictable work load and order of thread
/// execution.
///
/// @warning
/// The class uses vtkMultiThreader if the size of the pool is larger than
/// the specified chunk size. Also, vtkSMPTools may be used to scale the
/// components in the method PopulateDataArray().
/// </remarks>
public class vtkRandomPool : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRandomPool";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRandomPool()
	{
		MRClassNameKey = "class vtkRandomPool";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomPool"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRandomPool(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomPool_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkRandomPool New()
	{
		vtkRandomPool result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomPool_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRandomPool)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkRandomPool()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRandomPool_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRandomPool_GeneratePool_01(HandleRef pThis);

	/// <summary>
	/// These methods provide access to the raw random pool as a double
	/// array. The size of the array is Size*NumberOfComponents. Each x value
	/// ranges between (0&lt;=x&lt;=1). The class will generate the pool as necessary
	/// (a modified time for generation is maintained). Also a method is
	/// available for getting the value at the ith pool position and compNum
	/// component. Finally, note that the GetValue() method uses modulo
	/// reduction to ensure that the request remains inside of the pool. Two
	/// forms are provided, the first assumes NumberOfComponents=1; the second
	/// allows access to a particular component. The GetPool() and GetValue()
	/// methods should only be called after GeneratePool() has been invoked;
	/// </summary>
	public IntPtr GeneratePool()
	{
		return vtkRandomPool_GeneratePool_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetChunkSize_02(HandleRef pThis);

	/// <summary>
	/// Specify the work chunk size at which point multithreading kicks in. For small
	/// memory pools &lt; ChunkSize, no threading is used. Larger pools are computed using
	/// vtkMultiThreader.
	/// </summary>
	public virtual long GetChunkSize()
	{
		return vtkRandomPool_GetChunkSize_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetChunkSizeMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Specify the work chunk size at which point multithreading kicks in. For small
	/// memory pools &lt; ChunkSize, no threading is used. Larger pools are computed using
	/// vtkMultiThreader.
	/// </summary>
	public virtual long GetChunkSizeMaxValue()
	{
		return vtkRandomPool_GetChunkSizeMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetChunkSizeMinValue_04(HandleRef pThis);

	/// <summary>
	/// Specify the work chunk size at which point multithreading kicks in. For small
	/// memory pools &lt; ChunkSize, no threading is used. Larger pools are computed using
	/// vtkMultiThreader.
	/// </summary>
	public virtual long GetChunkSizeMinValue()
	{
		return vtkRandomPool_GetChunkSizeMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetNumberOfComponents_05(HandleRef pThis);

	/// <summary>
	/// Methods to set and get the number of components in the pool. This is a
	/// convenience capability and can be used to interface with
	/// vtkDataArrays. By default the number of components is =1.
	/// </summary>
	public virtual long GetNumberOfComponents()
	{
		return vtkRandomPool_GetNumberOfComponents_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetNumberOfComponentsMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Methods to set and get the number of components in the pool. This is a
	/// convenience capability and can be used to interface with
	/// vtkDataArrays. By default the number of components is =1.
	/// </summary>
	public virtual long GetNumberOfComponentsMaxValue()
	{
		return vtkRandomPool_GetNumberOfComponentsMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetNumberOfComponentsMinValue_07(HandleRef pThis);

	/// <summary>
	/// Methods to set and get the number of components in the pool. This is a
	/// convenience capability and can be used to interface with
	/// vtkDataArrays. By default the number of components is =1.
	/// </summary>
	public virtual long GetNumberOfComponentsMinValue()
	{
		return vtkRandomPool_GetNumberOfComponentsMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRandomPool_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRandomPool_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomPool_GetPool_10(HandleRef pThis);

	/// <summary>
	/// These methods provide access to the raw random pool as a double
	/// array. The size of the array is Size*NumberOfComponents. Each x value
	/// ranges between (0&lt;=x&lt;=1). The class will generate the pool as necessary
	/// (a modified time for generation is maintained). Also a method is
	/// available for getting the value at the ith pool position and compNum
	/// component. Finally, note that the GetValue() method uses modulo
	/// reduction to ensure that the request remains inside of the pool. Two
	/// forms are provided, the first assumes NumberOfComponents=1; the second
	/// allows access to a particular component. The GetPool() and GetValue()
	/// methods should only be called after GeneratePool() has been invoked;
	/// </summary>
	public IntPtr GetPool()
	{
		return vtkRandomPool_GetPool_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomPool_GetSequence_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the random sequence generator used to produce the random pool.
	/// By default vtkMersenneTwister is used.
	/// </summary>
	public virtual vtkRandomSequence GetSequence()
	{
		vtkRandomSequence vtkRandomSequence2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomPool_GetSequence_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkRandomPool_GetSize_12(HandleRef pThis);

	/// <summary>
	/// Methods to set and get the size of the pool. The size must be specified
	/// before invoking GeneratePool(). Note the number of components will
	/// affect the total size (allocated memory is Size*NumberOfComponents).
	/// </summary>
	public virtual long GetSize()
	{
		return vtkRandomPool_GetSize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetSizeMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Methods to set and get the size of the pool. The size must be specified
	/// before invoking GeneratePool(). Note the number of components will
	/// affect the total size (allocated memory is Size*NumberOfComponents).
	/// </summary>
	public virtual long GetSizeMaxValue()
	{
		return vtkRandomPool_GetSizeMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetSizeMinValue_14(HandleRef pThis);

	/// <summary>
	/// Methods to set and get the size of the pool. The size must be specified
	/// before invoking GeneratePool(). Note the number of components will
	/// affect the total size (allocated memory is Size*NumberOfComponents).
	/// </summary>
	public virtual long GetSizeMinValue()
	{
		return vtkRandomPool_GetSizeMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomPool_GetTotalSize_15(HandleRef pThis);

	/// <summary>
	/// This convenience method returns the total size of the memory pool, i.e.,
	/// Size*NumberOfComponents.
	/// </summary>
	public long GetTotalSize()
	{
		return vtkRandomPool_GetTotalSize_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRandomPool_GetValue_16(HandleRef pThis, long i);

	/// <summary>
	/// These methods provide access to the raw random pool as a double
	/// array. The size of the array is Size*NumberOfComponents. Each x value
	/// ranges between (0&lt;=x&lt;=1). The class will generate the pool as necessary
	/// (a modified time for generation is maintained). Also a method is
	/// available for getting the value at the ith pool position and compNum
	/// component. Finally, note that the GetValue() method uses modulo
	/// reduction to ensure that the request remains inside of the pool. Two
	/// forms are provided, the first assumes NumberOfComponents=1; the second
	/// allows access to a particular component. The GetPool() and GetValue()
	/// methods should only be called after GeneratePool() has been invoked;
	/// </summary>
	public double GetValue(long i)
	{
		return vtkRandomPool_GetValue_16(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRandomPool_GetValue_17(HandleRef pThis, long i, int compNum);

	/// <summary>
	/// These methods provide access to the raw random pool as a double
	/// array. The size of the array is Size*NumberOfComponents. Each x value
	/// ranges between (0&lt;=x&lt;=1). The class will generate the pool as necessary
	/// (a modified time for generation is maintained). Also a method is
	/// available for getting the value at the ith pool position and compNum
	/// component. Finally, note that the GetValue() method uses modulo
	/// reduction to ensure that the request remains inside of the pool. Two
	/// forms are provided, the first assumes NumberOfComponents=1; the second
	/// allows access to a particular component. The GetPool() and GetValue()
	/// methods should only be called after GeneratePool() has been invoked;
	/// </summary>
	public double GetValue(long i, int compNum)
	{
		return vtkRandomPool_GetValue_17(GetCppThis(), i, compNum);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomPool_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRandomPool_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomPool_IsTypeOf_19(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRandomPool_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomPool_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkRandomPool NewInstance()
	{
		vtkRandomPool result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomPool_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRandomPool)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomPool_PopulateDataArray_22(HandleRef pThis, HandleRef da, double minRange, double maxRange);

	/// <summary>
	/// Methods to populate data arrays of various types with values within a
	/// specified (min,max) range. Note that compNumber is used to specify the
	/// range for a particular component; otherwise all generated components are
	/// within the (min,max) range specified. (Thus it is possible to make
	/// multiple calls to generate random numbers for each component with
	/// different ranges.) Internally the type of the data array passed in is
	/// used to cast to the appropriate type. Also the size and number of
	/// components of the vtkDataArray controls the total number of random
	/// numbers generated; so the input data array should be pre-allocated with
	/// (SetNumberOfComponents, SetNumberOfTuples).
	/// </summary>
	public void PopulateDataArray(vtkDataArray da, double minRange, double maxRange)
	{
		vtkRandomPool_PopulateDataArray_22(GetCppThis(), da?.GetCppThis() ?? default(HandleRef), minRange, maxRange);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomPool_PopulateDataArray_23(HandleRef pThis, HandleRef da, int compNumber, double minRange, double maxRange);

	/// <summary>
	/// Methods to populate data arrays of various types with values within a
	/// specified (min,max) range. Note that compNumber is used to specify the
	/// range for a particular component; otherwise all generated components are
	/// within the (min,max) range specified. (Thus it is possible to make
	/// multiple calls to generate random numbers for each component with
	/// different ranges.) Internally the type of the data array passed in is
	/// used to cast to the appropriate type. Also the size and number of
	/// components of the vtkDataArray controls the total number of random
	/// numbers generated; so the input data array should be pre-allocated with
	/// (SetNumberOfComponents, SetNumberOfTuples).
	/// </summary>
	public void PopulateDataArray(vtkDataArray da, int compNumber, double minRange, double maxRange)
	{
		vtkRandomPool_PopulateDataArray_23(GetCppThis(), da?.GetCppThis() ?? default(HandleRef), compNumber, minRange, maxRange);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomPool_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkRandomPool SafeDownCast(vtkObjectBase o)
	{
		vtkRandomPool vtkRandomPool2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomPool_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRandomPool2 = (vtkRandomPool)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRandomPool2.Register(null);
			}
		}
		return vtkRandomPool2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomPool_SetChunkSize_25(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the work chunk size at which point multithreading kicks in. For small
	/// memory pools &lt; ChunkSize, no threading is used. Larger pools are computed using
	/// vtkMultiThreader.
	/// </summary>
	public virtual void SetChunkSize(long _arg)
	{
		vtkRandomPool_SetChunkSize_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomPool_SetNumberOfComponents_26(HandleRef pThis, long _arg);

	/// <summary>
	/// Methods to set and get the number of components in the pool. This is a
	/// convenience capability and can be used to interface with
	/// vtkDataArrays. By default the number of components is =1.
	/// </summary>
	public virtual void SetNumberOfComponents(long _arg)
	{
		vtkRandomPool_SetNumberOfComponents_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomPool_SetSequence_27(HandleRef pThis, HandleRef seq);

	/// <summary>
	/// Specify the random sequence generator used to produce the random pool.
	/// By default vtkMersenneTwister is used.
	/// </summary>
	public virtual void SetSequence(vtkRandomSequence seq)
	{
		vtkRandomPool_SetSequence_27(GetCppThis(), seq?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomPool_SetSize_28(HandleRef pThis, long _arg);

	/// <summary>
	/// Methods to set and get the size of the pool. The size must be specified
	/// before invoking GeneratePool(). Note the number of components will
	/// affect the total size (allocated memory is Size*NumberOfComponents).
	/// </summary>
	public virtual void SetSize(long _arg)
	{
		vtkRandomPool_SetSize_28(GetCppThis(), _arg);
	}
}
