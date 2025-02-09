using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphLayout
/// </summary>
/// <remarks>
///    layout a graph in 2 or 3 dimensions
///
///
/// This class is a shell for many graph layout strategies which may be set
/// using the SetLayoutStrategy() function.  The layout strategies do the
/// actual work.
///
/// .SECTION Thanks
/// Thanks to Brian Wylie from Sandia National Laboratories for adding incremental
/// layout capabilities.
/// </remarks>
public class vtkGraphLayout : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayout";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphLayout()
	{
		MRClassNameKey = "class vtkGraphLayout";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayout"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphLayout New()
	{
		vtkGraphLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGraphLayout()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGraphLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayout_GetLayoutStrategy_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The layout strategy to use during graph layout.
	/// </summary>
	public virtual vtkGraphLayoutStrategy GetLayoutStrategy()
	{
		vtkGraphLayoutStrategy vtkGraphLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayout_GetLayoutStrategy_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphLayoutStrategy2 = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphLayoutStrategy2.Register(null);
			}
		}
		return vtkGraphLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGraphLayout_GetMTime_02(HandleRef pThis);

	/// <summary>
	/// Get the modification time of the layout algorithm.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGraphLayout_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphLayout_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphLayout_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphLayout_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphLayout_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayout_GetTransform_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Transform the graph vertices after the layout.
	/// </summary>
	public virtual vtkAbstractTransform GetTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayout_GetTransform_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayout_GetUseTransform_06(HandleRef pThis);

	/// <summary>
	/// Whether to use the specified transform after layout.
	/// </summary>
	public virtual bool GetUseTransform()
	{
		return (vtkGraphLayout_GetUseTransform_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGraphLayout_GetZRange_07(HandleRef pThis);

	/// <summary>
	/// Set the ZRange for the output data.
	/// If the initial layout is planar (i.e. all z coordinates are zero),
	/// the coordinates will be evenly spaced from 0.0 to ZRange.
	/// The default is zero, which has no effect.
	/// </summary>
	public virtual double GetZRange()
	{
		return vtkGraphLayout_GetZRange_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayout_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphLayout_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayout_IsLayoutComplete_09(HandleRef pThis);

	/// <summary>
	/// Ask the layout algorithm if the layout is complete
	/// </summary>
	public virtual int IsLayoutComplete()
	{
		return vtkGraphLayout_IsLayoutComplete_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayout_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphLayout_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayout_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraphLayout NewInstance()
	{
		vtkGraphLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayout_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayout_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphLayout SafeDownCast(vtkObjectBase o)
	{
		vtkGraphLayout vtkGraphLayout2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayout_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphLayout2 = (vtkGraphLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphLayout2.Register(null);
			}
		}
		return vtkGraphLayout2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayout_SetLayoutStrategy_14(HandleRef pThis, HandleRef strategy);

	/// <summary>
	/// The layout strategy to use during graph layout.
	/// </summary>
	public void SetLayoutStrategy(vtkGraphLayoutStrategy strategy)
	{
		vtkGraphLayout_SetLayoutStrategy_14(GetCppThis(), strategy?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayout_SetTransform_15(HandleRef pThis, HandleRef t);

	/// <summary>
	/// Transform the graph vertices after the layout.
	/// </summary>
	public virtual void SetTransform(vtkAbstractTransform t)
	{
		vtkGraphLayout_SetTransform_15(GetCppThis(), t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayout_SetUseTransform_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to use the specified transform after layout.
	/// </summary>
	public virtual void SetUseTransform(bool _arg)
	{
		vtkGraphLayout_SetUseTransform_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayout_SetZRange_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the ZRange for the output data.
	/// If the initial layout is planar (i.e. all z coordinates are zero),
	/// the coordinates will be evenly spaced from 0.0 to ZRange.
	/// The default is zero, which has no effect.
	/// </summary>
	public virtual void SetZRange(double _arg)
	{
		vtkGraphLayout_SetZRange_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayout_UseTransformOff_18(HandleRef pThis);

	/// <summary>
	/// Whether to use the specified transform after layout.
	/// </summary>
	public virtual void UseTransformOff()
	{
		vtkGraphLayout_UseTransformOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayout_UseTransformOn_19(HandleRef pThis);

	/// <summary>
	/// Whether to use the specified transform after layout.
	/// </summary>
	public virtual void UseTransformOn()
	{
		vtkGraphLayout_UseTransformOn_19(GetCppThis());
	}
}
