using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleAreaSelectHover
/// </summary>
/// <remarks>
///    An interactor style for an area tree view
///
///
/// The vtkInteractorStyleAreaSelectHover specifically works with pipelines
/// that create a hierarchical tree.  Such pipelines will have a vtkAreaLayout
/// filter which must be passed to this interactor style for it to function
/// correctly.
/// This interactor style allows only 2D panning and zooming,
/// rubber band selection and provides a balloon containing the name of the
/// vertex hovered over.
/// </remarks>
public class vtkInteractorStyleAreaSelectHover : vtkInteractorStyleRubberBand2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleAreaSelectHover";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleAreaSelectHover()
	{
		MRClassNameKey = "class vtkInteractorStyleAreaSelectHover";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleAreaSelectHover"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleAreaSelectHover(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleAreaSelectHover_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleAreaSelectHover New()
	{
		vtkInteractorStyleAreaSelectHover result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleAreaSelectHover_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleAreaSelectHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleAreaSelectHover()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleAreaSelectHover_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkInteractorStyleAreaSelectHover_GetHighLightWidth_01(HandleRef pThis);

	/// <summary>
	/// The width of the line around the hovered vertex.
	/// </summary>
	public double GetHighLightWidth()
	{
		return vtkInteractorStyleAreaSelectHover_GetHighLightWidth_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleAreaSelectHover_GetIdAtPos_02(HandleRef pThis, int x, int y);

	/// <summary>
	/// Obtain the tree vertex id at the position specified.
	/// </summary>
	public long GetIdAtPos(int x, int y)
	{
		return vtkInteractorStyleAreaSelectHover_GetIdAtPos_02(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleAreaSelectHover_GetLabelField_03(HandleRef pThis);

	/// <summary>
	/// The name of the field to use when displaying text in the hover balloon.
	/// </summary>
	public virtual string GetLabelField()
	{
		return Marshal.PtrToStringAnsi(vtkInteractorStyleAreaSelectHover_GetLabelField_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleAreaSelectHover_GetLayout_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Must be set to the vtkAreaLayout used to compute the bounds of
	/// each vertex.
	/// </summary>
	public virtual vtkAreaLayout GetLayout()
	{
		vtkAreaLayout vtkAreaLayout2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleAreaSelectHover_GetLayout_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAreaLayout2 = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAreaLayout2.Register(null);
			}
		}
		return vtkAreaLayout2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleAreaSelectHover_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleAreaSelectHover_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleAreaSelectHover_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleAreaSelectHover_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInteractorStyleAreaSelectHover_GetUseRectangularCoordinates_07(HandleRef pThis);

	/// <summary>
	/// Determine whether or not to use rectangular coordinates instead of
	/// polar coordinates.
	/// </summary>
	public virtual bool GetUseRectangularCoordinates()
	{
		return (vtkInteractorStyleAreaSelectHover_GetUseRectangularCoordinates_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleAreaSelectHover_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleAreaSelectHover_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleAreaSelectHover_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleAreaSelectHover_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleAreaSelectHover_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleAreaSelectHover NewInstance()
	{
		vtkInteractorStyleAreaSelectHover result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleAreaSelectHover_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleAreaSelectHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleAreaSelectHover_OnMouseMove_12(HandleRef pThis);

	/// <summary>
	/// Overridden from vtkInteractorStyleImage to provide the desired
	/// interaction behavior.
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleAreaSelectHover_OnMouseMove_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleAreaSelectHover_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleAreaSelectHover SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleAreaSelectHover vtkInteractorStyleAreaSelectHover2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleAreaSelectHover_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleAreaSelectHover2 = (vtkInteractorStyleAreaSelectHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleAreaSelectHover2.Register(null);
			}
		}
		return vtkInteractorStyleAreaSelectHover2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleAreaSelectHover_SetHighLightColor_14(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the color used to highlight the hovered vertex.
	/// </summary>
	public void SetHighLightColor(double r, double g, double b)
	{
		vtkInteractorStyleAreaSelectHover_SetHighLightColor_14(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleAreaSelectHover_SetHighLightWidth_15(HandleRef pThis, double lw);

	/// <summary>
	/// The width of the line around the hovered vertex.
	/// </summary>
	public void SetHighLightWidth(double lw)
	{
		vtkInteractorStyleAreaSelectHover_SetHighLightWidth_15(GetCppThis(), lw);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleAreaSelectHover_SetInteractor_16(HandleRef pThis, HandleRef rwi);

	/// <summary>
	/// Set the interactor that this interactor style works with.
	/// </summary>
	public override void SetInteractor(vtkRenderWindowInteractor rwi)
	{
		vtkInteractorStyleAreaSelectHover_SetInteractor_16(GetCppThis(), rwi?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleAreaSelectHover_SetLabelField_17(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the field to use when displaying text in the hover balloon.
	/// </summary>
	public virtual void SetLabelField(string _arg)
	{
		vtkInteractorStyleAreaSelectHover_SetLabelField_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleAreaSelectHover_SetLayout_18(HandleRef pThis, HandleRef layout);

	/// <summary>
	/// Must be set to the vtkAreaLayout used to compute the bounds of
	/// each vertex.
	/// </summary>
	public void SetLayout(vtkAreaLayout layout)
	{
		vtkInteractorStyleAreaSelectHover_SetLayout_18(GetCppThis(), layout?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleAreaSelectHover_SetUseRectangularCoordinates_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Determine whether or not to use rectangular coordinates instead of
	/// polar coordinates.
	/// </summary>
	public virtual void SetUseRectangularCoordinates(bool _arg)
	{
		vtkInteractorStyleAreaSelectHover_SetUseRectangularCoordinates_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOff_20(HandleRef pThis);

	/// <summary>
	/// Determine whether or not to use rectangular coordinates instead of
	/// polar coordinates.
	/// </summary>
	public virtual void UseRectangularCoordinatesOff()
	{
		vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOn_21(HandleRef pThis);

	/// <summary>
	/// Determine whether or not to use rectangular coordinates instead of
	/// polar coordinates.
	/// </summary>
	public virtual void UseRectangularCoordinatesOn()
	{
		vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOn_21(GetCppThis());
	}
}
