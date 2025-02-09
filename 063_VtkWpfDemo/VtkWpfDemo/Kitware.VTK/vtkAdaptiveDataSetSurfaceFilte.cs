using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAdaptiveDataSetSurfaceFilter
/// </summary>
/// <remarks>
///    Adaptively extract dataset surface
///
/// vtkAdaptiveDataSetSurfaceFilter uses view and dataset properties to
/// create the outside surface mesh with the minimum minimorum of facets
/// @warning
/// Only implemented currently for 2-dimensional vtkHyperTreeGrid objects
/// </remarks>
/// <seealso>
///
/// vtkHyperTreeGrid vtkDataSetSurfaceFilter
/// @par Thanks:
/// This class was written by Guenole Harel and Jacques-Bernard Lekien, 2014
/// This class was rewritten by Philippe Pebay, 2016
/// This class was modified by Rogeli Grima, 2016
/// This work was supported by Commissariat a l'Energie Atomique (CEA/DIF)
/// CEA, DAM, DIF, F-91297 Arpajon, France.
/// </seealso>
public class vtkAdaptiveDataSetSurfaceFilter : vtkGeometryFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAdaptiveDataSetSurfaceFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAdaptiveDataSetSurfaceFilter()
	{
		MRClassNameKey = "class vtkAdaptiveDataSetSurfaceFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdaptiveDataSetSurfaceFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAdaptiveDataSetSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdaptiveDataSetSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAdaptiveDataSetSurfaceFilter New()
	{
		vtkAdaptiveDataSetSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdaptiveDataSetSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAdaptiveDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAdaptiveDataSetSurfaceFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAdaptiveDataSetSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkAdaptiveDataSetSurfaceFilter_GetBBSelection_01(HandleRef pThis);

	/// <summary>
	/// Set/Get for active the bounding box selection viewport (default false)
	/// JB C'est un facteur supplementaire d'acceleration possible
	/// JB uniquement si l'on ne peut faire de rotation dans la vue.
	/// </summary>
	public virtual bool GetBBSelection()
	{
		return (vtkAdaptiveDataSetSurfaceFilter_GetBBSelection_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAdaptiveDataSetSurfaceFilter_GetCircleSelection_02(HandleRef pThis);

	/// <summary>
	/// Set/Get for active the circle selection viewport (default true)
	/// </summary>
	public virtual bool GetCircleSelection()
	{
		return (vtkAdaptiveDataSetSurfaceFilter_GetCircleSelection_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAdaptiveDataSetSurfaceFilter_GetDynamicDecimateLevelMax_03(HandleRef pThis);

	/// <summary>
	/// JB Set/Get reduit de autant le niveau max de profondeur, calcule
	/// JB dynamiquement a parcourir dans la
	/// JB representation HTG. (defaut 0)
	/// </summary>
	public virtual int GetDynamicDecimateLevelMax()
	{
		return vtkAdaptiveDataSetSurfaceFilter_GetDynamicDecimateLevelMax_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAdaptiveDataSetSurfaceFilter_GetFixedLevelMax_04(HandleRef pThis);

	/// <summary>
	/// Set/Get for forced a fixed the level max (lost dynamicity) (default -1)
	/// </summary>
	public virtual int GetFixedLevelMax()
	{
		return vtkAdaptiveDataSetSurfaceFilter_GetFixedLevelMax_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAdaptiveDataSetSurfaceFilter_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Get the mtime of this object.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAdaptiveDataSetSurfaceFilter_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveDataSetSurfaceFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAdaptiveDataSetSurfaceFilter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveDataSetSurfaceFilter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAdaptiveDataSetSurfaceFilter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdaptiveDataSetSurfaceFilter_GetRenderer_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the renderer attached to this adaptive surface extractor
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdaptiveDataSetSurfaceFilter_GetRenderer_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAdaptiveDataSetSurfaceFilter_GetScale_09(HandleRef pThis);

	/// <summary>
	/// JB Set/Get the scale factor influence le calcul de l'adaptive view.
	/// JB Pour un raffinement de 2, donner Scale=2*X revient a faire un
	/// JB appel a DynamicDecimateLevelMax avec la valeur X. (defaut 1)
	/// </summary>
	public virtual double GetScale()
	{
		return vtkAdaptiveDataSetSurfaceFilter_GetScale_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAdaptiveDataSetSurfaceFilter_GetViewPointDepend_10(HandleRef pThis);

	/// <summary>
	/// JB Activation de la dependance au point de vue. Par defaut a True.
	/// </summary>
	public virtual bool GetViewPointDepend()
	{
		return (vtkAdaptiveDataSetSurfaceFilter_GetViewPointDepend_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAdaptiveDataSetSurfaceFilter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAdaptiveDataSetSurfaceFilter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAdaptiveDataSetSurfaceFilter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAdaptiveDataSetSurfaceFilter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdaptiveDataSetSurfaceFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAdaptiveDataSetSurfaceFilter NewInstance()
	{
		vtkAdaptiveDataSetSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdaptiveDataSetSurfaceFilter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAdaptiveDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdaptiveDataSetSurfaceFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAdaptiveDataSetSurfaceFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAdaptiveDataSetSurfaceFilter vtkAdaptiveDataSetSurfaceFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdaptiveDataSetSurfaceFilter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAdaptiveDataSetSurfaceFilter2 = (vtkAdaptiveDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAdaptiveDataSetSurfaceFilter2.Register(null);
			}
		}
		return vtkAdaptiveDataSetSurfaceFilter2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetBBSelection_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get for active the bounding box selection viewport (default false)
	/// JB C'est un facteur supplementaire d'acceleration possible
	/// JB uniquement si l'on ne peut faire de rotation dans la vue.
	/// </summary>
	public virtual void SetBBSelection(bool _arg)
	{
		vtkAdaptiveDataSetSurfaceFilter_SetBBSelection_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetCircleSelection_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get for active the circle selection viewport (default true)
	/// </summary>
	public virtual void SetCircleSelection(bool _arg)
	{
		vtkAdaptiveDataSetSurfaceFilter_SetCircleSelection_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetDynamicDecimateLevelMax_18(HandleRef pThis, int _arg);

	/// <summary>
	/// JB Set/Get reduit de autant le niveau max de profondeur, calcule
	/// JB dynamiquement a parcourir dans la
	/// JB representation HTG. (defaut 0)
	/// </summary>
	public virtual void SetDynamicDecimateLevelMax(int _arg)
	{
		vtkAdaptiveDataSetSurfaceFilter_SetDynamicDecimateLevelMax_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetFixedLevelMax_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get for forced a fixed the level max (lost dynamicity) (default -1)
	/// </summary>
	public virtual void SetFixedLevelMax(int _arg)
	{
		vtkAdaptiveDataSetSurfaceFilter_SetFixedLevelMax_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetRenderer_20(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Set/Get the renderer attached to this adaptive surface extractor
	/// </summary>
	public void SetRenderer(vtkRenderer ren)
	{
		vtkAdaptiveDataSetSurfaceFilter_SetRenderer_20(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetScale_21(HandleRef pThis, double _arg);

	/// <summary>
	/// JB Set/Get the scale factor influence le calcul de l'adaptive view.
	/// JB Pour un raffinement de 2, donner Scale=2*X revient a faire un
	/// JB appel a DynamicDecimateLevelMax avec la valeur X. (defaut 1)
	/// </summary>
	public virtual void SetScale(double _arg)
	{
		vtkAdaptiveDataSetSurfaceFilter_SetScale_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetViewPointDepend_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// JB Activation de la dependance au point de vue. Par defaut a True.
	/// </summary>
	public virtual void SetViewPointDepend(bool _arg)
	{
		vtkAdaptiveDataSetSurfaceFilter_SetViewPointDepend_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
