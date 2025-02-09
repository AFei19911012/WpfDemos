using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalDataSetCache
/// </summary>
/// <remarks>
///    cache time steps
///
/// vtkTemporalDataSetCache cache time step requests of a temporal dataset,
/// when cached data is requested it is returned using a shallow copy.
/// @par Thanks:
/// Ken Martin (Kitware) and John Bidiscombe of
/// CSCS - Swiss National Supercomputing Centre
/// for creating and contributing this class.
/// For related material, please refer to :
/// John Biddiscombe, Berk Geveci, Ken Martin, Kenneth Moreland, David Thompson,
/// "Time Dependent Processing in a Parallel Pipeline Architecture",
/// IEEE Visualization 2007.
/// </remarks>
public class vtkTemporalDataSetCache : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalDataSetCache";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalDataSetCache()
	{
		MRClassNameKey = "class vtkTemporalDataSetCache";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalDataSetCache"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalDataSetCache(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalDataSetCache_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalDataSetCache New()
	{
		vtkTemporalDataSetCache result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalDataSetCache_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalDataSetCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTemporalDataSetCache()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalDataSetCache_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDataSetCache_CacheInMemkindOff_01(HandleRef pThis);

	/// <summary>
	/// Tells the filter that it should store the dataobjects it holds in memkind
	/// extended memory space rather than in normal memory space.
	/// </summary>
	public virtual void CacheInMemkindOff()
	{
		vtkTemporalDataSetCache_CacheInMemkindOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDataSetCache_CacheInMemkindOn_02(HandleRef pThis);

	/// <summary>
	/// Tells the filter that it should store the dataobjects it holds in memkind
	/// extended memory space rather than in normal memory space.
	/// </summary>
	public virtual void CacheInMemkindOn()
	{
		vtkTemporalDataSetCache_CacheInMemkindOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTemporalDataSetCache_GetCacheInMemkind_03(HandleRef pThis);

	/// <summary>
	/// Tells the filter that it should store the dataobjects it holds in memkind
	/// extended memory space rather than in normal memory space.
	/// </summary>
	public virtual bool GetCacheInMemkind()
	{
		return (vtkTemporalDataSetCache_GetCacheInMemkind_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalDataSetCache_GetCacheSize_04(HandleRef pThis);

	/// <summary>
	/// This is the maximum number of time steps that can be retained in memory.
	/// it defaults to 10.
	/// </summary>
	public virtual int GetCacheSize()
	{
		return vtkTemporalDataSetCache_GetCacheSize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTemporalDataSetCache_GetIsASource_05(HandleRef pThis);

	/// <summary>
	/// Tells the filter that needs to act as a pipeline source rather than a midpipline filter. In
	/// that situation it needs to react differently in a few cases.
	/// </summary>
	public virtual bool GetIsASource()
	{
		return (vtkTemporalDataSetCache_GetIsASource_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalDataSetCache_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalDataSetCache_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalDataSetCache_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalDataSetCache_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalDataSetCache_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalDataSetCache_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDataSetCache_IsASourceOff_09(HandleRef pThis);

	/// <summary>
	/// Tells the filter that needs to act as a pipeline source rather than a midpipline filter. In
	/// that situation it needs to react differently in a few cases.
	/// </summary>
	public virtual void IsASourceOff()
	{
		vtkTemporalDataSetCache_IsASourceOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDataSetCache_IsASourceOn_10(HandleRef pThis);

	/// <summary>
	/// Tells the filter that needs to act as a pipeline source rather than a midpipline filter. In
	/// that situation it needs to react differently in a few cases.
	/// </summary>
	public virtual void IsASourceOn()
	{
		vtkTemporalDataSetCache_IsASourceOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalDataSetCache_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalDataSetCache_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalDataSetCache_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTemporalDataSetCache NewInstance()
	{
		vtkTemporalDataSetCache result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalDataSetCache_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalDataSetCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalDataSetCache_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalDataSetCache SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalDataSetCache vtkTemporalDataSetCache2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalDataSetCache_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalDataSetCache2 = (vtkTemporalDataSetCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalDataSetCache2.Register(null);
			}
		}
		return vtkTemporalDataSetCache2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDataSetCache_SetCacheInMemkind_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Tells the filter that it should store the dataobjects it holds in memkind
	/// extended memory space rather than in normal memory space.
	/// </summary>
	public virtual void SetCacheInMemkind(bool _arg)
	{
		vtkTemporalDataSetCache_SetCacheInMemkind_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDataSetCache_SetCacheSize_16(HandleRef pThis, int size);

	/// <summary>
	/// This is the maximum number of time steps that can be retained in memory.
	/// it defaults to 10.
	/// </summary>
	public void SetCacheSize(int size)
	{
		vtkTemporalDataSetCache_SetCacheSize_16(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDataSetCache_SetIsASource_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Tells the filter that needs to act as a pipeline source rather than a midpipline filter. In
	/// that situation it needs to react differently in a few cases.
	/// </summary>
	public virtual void SetIsASource(bool _arg)
	{
		vtkTemporalDataSetCache_SetIsASource_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
