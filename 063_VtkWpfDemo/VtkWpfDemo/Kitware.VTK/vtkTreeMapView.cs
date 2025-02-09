using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeMapView
/// </summary>
/// <remarks>
///    Displays a tree as a tree map.
///
///
/// vtkTreeMapView shows a vtkTree in a tree map, where each vertex in the
/// tree is represented by a box.  Child boxes are contained within the
/// parent box, and may be colored and sized by various parameters.
/// </remarks>
public class vtkTreeMapView : vtkTreeAreaView
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapView";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeMapView()
	{
		MRClassNameKey = "class vtkTreeMapView";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapView"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeMapView(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeMapView New()
	{
		vtkTreeMapView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeMapView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeMapView()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeMapView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapView_GetFontSizeRange_01(HandleRef pThis, IntPtr range);

	/// <summary>
	/// The sizes of the fonts used for labeling.
	/// </summary>
	public virtual void GetFontSizeRange(IntPtr range)
	{
		vtkTreeMapView_GetFontSizeRange_01(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeMapView_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeMapView_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeMapView_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeMapView_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeMapView_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeMapView_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeMapView_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeMapView_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapView_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeMapView NewInstance()
	{
		vtkTreeMapView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapView_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeMapView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeMapView_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeMapView SafeDownCast(vtkObjectBase o)
	{
		vtkTreeMapView vtkTreeMapView2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeMapView_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeMapView2 = (vtkTreeMapView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeMapView2.Register(null);
			}
		}
		return vtkTreeMapView2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapView_SetFontSizeRange_09(HandleRef pThis, int maxSize, int minSize, int delta);

	/// <summary>
	/// The sizes of the fonts used for labeling.
	/// </summary>
	public virtual void SetFontSizeRange(int maxSize, int minSize, int delta)
	{
		vtkTreeMapView_SetFontSizeRange_09(GetCppThis(), maxSize, minSize, delta);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapView_SetLayoutStrategy_10(HandleRef pThis, HandleRef s);

	/// <summary>
	/// Sets the treemap layout strategy
	/// </summary>
	public override void SetLayoutStrategy(vtkAreaLayoutStrategy s)
	{
		vtkTreeMapView_SetLayoutStrategy_10(GetCppThis(), s?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapView_SetLayoutStrategy_11(HandleRef pThis, string name);

	/// <summary>
	/// Sets the treemap layout strategy
	/// </summary>
	public virtual void SetLayoutStrategy(string name)
	{
		vtkTreeMapView_SetLayoutStrategy_11(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapView_SetLayoutStrategyToBox_12(HandleRef pThis);

	/// <summary>
	/// Sets the treemap layout strategy
	/// </summary>
	public virtual void SetLayoutStrategyToBox()
	{
		vtkTreeMapView_SetLayoutStrategyToBox_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapView_SetLayoutStrategyToSliceAndDice_13(HandleRef pThis);

	/// <summary>
	/// Sets the treemap layout strategy
	/// </summary>
	public virtual void SetLayoutStrategyToSliceAndDice()
	{
		vtkTreeMapView_SetLayoutStrategyToSliceAndDice_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeMapView_SetLayoutStrategyToSquarify_14(HandleRef pThis);

	/// <summary>
	/// Sets the treemap layout strategy
	/// </summary>
	public virtual void SetLayoutStrategyToSquarify()
	{
		vtkTreeMapView_SetLayoutStrategyToSquarify_14(GetCppThis());
	}
}
