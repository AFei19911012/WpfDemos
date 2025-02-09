using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDynamic2DLabelMapper
/// </summary>
/// <remarks>
///    draw text labels at 2D dataset points
///
/// vtkDynamic2DLabelMapper is a mapper that renders text at dataset
/// points such that the labels do not overlap.
/// Various items can be labeled including point ids, scalars,
/// vectors, normals, texture coordinates, tensors, and field data components.
/// This mapper assumes that the points are located on the x-y plane
/// and that the camera remains perpendicular to that plane with a y-up
/// axis (this can be constrained using vtkImageInteractor).
/// On the first render, the mapper computes the visiblility of all labels
/// at all scales, and queries this information on successive renders.
/// This causes the first render to be much slower. The visibility algorithm
/// is a greedy approach based on the point id, so the label for a point
/// will be drawn unless the label for a point with lower id overlaps it.
///
/// @warning
/// Use this filter in combination with vtkSelectVisiblePoints if you want
/// to label only points that are visible. If you want to label cells rather
/// than points, use the filter vtkCellCenters to generate points at the
/// center of the cells. Also, you can use the class vtkIdFilter to
/// generate ids as scalars or field data, which can then be labeled.
///
/// </remarks>
/// <seealso>
///
/// vtkLabeledDataMapper
///
/// @par Thanks:
/// This algorithm was developed in the paper
/// Ken Been and Chee Yap. Dynamic Map Labeling. IEEE Transactions on
/// Visualization and Computer Graphics, Vol. 12, No. 5, 2006. pp. 773-780.
/// </seealso>
public class vtkDynamic2DLabelMapper : vtkLabeledDataMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDynamic2DLabelMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDynamic2DLabelMapper()
	{
		MRClassNameKey = "class vtkDynamic2DLabelMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDynamic2DLabelMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDynamic2DLabelMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDynamic2DLabelMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new static vtkDynamic2DLabelMapper New()
	{
		vtkDynamic2DLabelMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDynamic2DLabelMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDynamic2DLabelMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public vtkDynamic2DLabelMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDynamic2DLabelMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDynamic2DLabelMapper_GetLabelHeightPadding_01(HandleRef pThis);

	/// <summary>
	/// Set the label height padding as a percentage. The percentage
	/// is a percentage of your label height.
	/// Default is 50%.
	/// </summary>
	public virtual float GetLabelHeightPadding()
	{
		return vtkDynamic2DLabelMapper_GetLabelHeightPadding_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDynamic2DLabelMapper_GetLabelWidthPadding_02(HandleRef pThis);

	/// <summary>
	/// Set the label width padding as a percentage. The percentage
	/// is a percentage of your label ^height^ (yes, not a typo).
	/// Default is 50%.
	/// </summary>
	public virtual float GetLabelWidthPadding()
	{
		return vtkDynamic2DLabelMapper_GetLabelWidthPadding_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDynamic2DLabelMapper_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDynamic2DLabelMapper_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDynamic2DLabelMapper_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDynamic2DLabelMapper_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDynamic2DLabelMapper_GetReversePriority_05(HandleRef pThis);

	/// <summary>
	/// Whether to reverse the priority order (i.e. low values have high priority).
	/// Default is off.
	/// </summary>
	public virtual bool GetReversePriority()
	{
		return (vtkDynamic2DLabelMapper_GetReversePriority_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDynamic2DLabelMapper_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDynamic2DLabelMapper_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDynamic2DLabelMapper_IsTypeOf_07(string type);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDynamic2DLabelMapper_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDynamic2DLabelMapper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new vtkDynamic2DLabelMapper NewInstance()
	{
		vtkDynamic2DLabelMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDynamic2DLabelMapper_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDynamic2DLabelMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDynamic2DLabelMapper_RenderOpaqueGeometry_10(HandleRef pThis, HandleRef viewport, HandleRef actor);

	/// <summary>
	/// Draw non-overlapping labels to the screen.
	/// </summary>
	public override void RenderOpaqueGeometry(vtkViewport viewport, vtkActor2D actor)
	{
		vtkDynamic2DLabelMapper_RenderOpaqueGeometry_10(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), actor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDynamic2DLabelMapper_RenderOverlay_11(HandleRef pThis, HandleRef viewport, HandleRef actor);

	/// <summary>
	/// Draw non-overlapping labels to the screen.
	/// </summary>
	public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
	{
		vtkDynamic2DLabelMapper_RenderOverlay_11(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), actor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDynamic2DLabelMapper_ReversePriorityOff_12(HandleRef pThis);

	/// <summary>
	/// Whether to reverse the priority order (i.e. low values have high priority).
	/// Default is off.
	/// </summary>
	public virtual void ReversePriorityOff()
	{
		vtkDynamic2DLabelMapper_ReversePriorityOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDynamic2DLabelMapper_ReversePriorityOn_13(HandleRef pThis);

	/// <summary>
	/// Whether to reverse the priority order (i.e. low values have high priority).
	/// Default is off.
	/// </summary>
	public virtual void ReversePriorityOn()
	{
		vtkDynamic2DLabelMapper_ReversePriorityOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDynamic2DLabelMapper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with %%-#6.3g label format. By default, point ids
	/// are labeled.
	/// </summary>
	public new static vtkDynamic2DLabelMapper SafeDownCast(vtkObjectBase o)
	{
		vtkDynamic2DLabelMapper vtkDynamic2DLabelMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDynamic2DLabelMapper_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDynamic2DLabelMapper2 = (vtkDynamic2DLabelMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDynamic2DLabelMapper2.Register(null);
			}
		}
		return vtkDynamic2DLabelMapper2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDynamic2DLabelMapper_SetLabelHeightPadding_15(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the label height padding as a percentage. The percentage
	/// is a percentage of your label height.
	/// Default is 50%.
	/// </summary>
	public virtual void SetLabelHeightPadding(float _arg)
	{
		vtkDynamic2DLabelMapper_SetLabelHeightPadding_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDynamic2DLabelMapper_SetLabelWidthPadding_16(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the label width padding as a percentage. The percentage
	/// is a percentage of your label ^height^ (yes, not a typo).
	/// Default is 50%.
	/// </summary>
	public virtual void SetLabelWidthPadding(float _arg)
	{
		vtkDynamic2DLabelMapper_SetLabelWidthPadding_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDynamic2DLabelMapper_SetPriorityArrayName_17(HandleRef pThis, string name);

	/// <summary>
	/// Set the points array name to use to give priority to labels.
	/// Defaults to "priority".
	/// </summary>
	public void SetPriorityArrayName(string name)
	{
		vtkDynamic2DLabelMapper_SetPriorityArrayName_17(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDynamic2DLabelMapper_SetReversePriority_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to reverse the priority order (i.e. low values have high priority).
	/// Default is off.
	/// </summary>
	public virtual void SetReversePriority(bool _arg)
	{
		vtkDynamic2DLabelMapper_SetReversePriority_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
