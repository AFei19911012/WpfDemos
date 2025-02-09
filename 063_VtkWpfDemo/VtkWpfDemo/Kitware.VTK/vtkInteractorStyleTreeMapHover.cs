using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleTreeMapHover
/// </summary>
/// <remarks>
///    An interactor style for a tree map view
///
///
/// The vtkInteractorStyleTreeMapHover specifically works with pipelines
/// that create a tree map.  Such pipelines will have a vtkTreeMapLayout
/// filter and a vtkTreeMapToPolyData filter, both of which must be passed
/// to this interactor style for it to function correctly.
/// This interactor style allows only 2D panning and zooming, and additionally
/// provides a balloon containing the name of the vertex hovered over,
/// and allows the user to highlight a vertex by clicking on it.
/// </remarks>
public class vtkInteractorStyleTreeMapHover : vtkInteractorStyleImage
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTreeMapHover";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleTreeMapHover()
	{
		MRClassNameKey = "class vtkInteractorStyleTreeMapHover";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTreeMapHover"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleTreeMapHover(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTreeMapHover_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleTreeMapHover New()
	{
		vtkInteractorStyleTreeMapHover result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTreeMapHover_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleTreeMapHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleTreeMapHover()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleTreeMapHover_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkInteractorStyleTreeMapHover_GetHighLightWidth_01(HandleRef pThis);

	/// <summary>
	/// The width of the line around the hovered vertex.
	/// </summary>
	public double GetHighLightWidth()
	{
		return vtkInteractorStyleTreeMapHover_GetHighLightWidth_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTreeMapHover_GetLabelField_02(HandleRef pThis);

	/// <summary>
	/// The name of the field to use when displaying text in the hover balloon.
	/// </summary>
	public virtual string GetLabelField()
	{
		return Marshal.PtrToStringAnsi(vtkInteractorStyleTreeMapHover_GetLabelField_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTreeMapHover_GetLayout_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Must be set to the vtkTreeMapLayout used to compute the bounds of each vertex
	/// for the tree map.
	/// </summary>
	public virtual vtkTreeMapLayout GetLayout()
	{
		vtkTreeMapLayout vtkTreeMapLayout2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTreeMapHover_GetLayout_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeMapLayout2 = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeMapLayout2.Register(null);
			}
		}
		return vtkTreeMapLayout2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleTreeMapHover_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleTreeMapHover_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleTreeMapHover_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleTreeMapHover_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInteractorStyleTreeMapHover_GetSelectionWidth_06(HandleRef pThis);

	/// <summary>
	/// The width of the line around the selected vertex.
	/// </summary>
	public double GetSelectionWidth()
	{
		return vtkInteractorStyleTreeMapHover_GetSelectionWidth_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTreeMapHover_GetTreeMapToPolyData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Must be set to the vtkTreeMapToPolyData used to convert the tree map
	/// into polydata.
	/// </summary>
	public virtual vtkTreeMapToPolyData GetTreeMapToPolyData()
	{
		vtkTreeMapToPolyData vtkTreeMapToPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTreeMapHover_GetTreeMapToPolyData_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeMapToPolyData2 = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeMapToPolyData2.Register(null);
			}
		}
		return vtkTreeMapToPolyData2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_HighLightCurrentSelectedItem_08(HandleRef pThis);

	/// <summary>
	/// Highlights a specific vertex.
	/// </summary>
	public void HighLightCurrentSelectedItem()
	{
		vtkInteractorStyleTreeMapHover_HighLightCurrentSelectedItem_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_HighLightItem_09(HandleRef pThis, long id);

	/// <summary>
	/// Highlights a specific vertex.
	/// </summary>
	public void HighLightItem(long id)
	{
		vtkInteractorStyleTreeMapHover_HighLightItem_09(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleTreeMapHover_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleTreeMapHover_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleTreeMapHover_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleTreeMapHover_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTreeMapHover_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleTreeMapHover NewInstance()
	{
		vtkInteractorStyleTreeMapHover result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTreeMapHover_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleTreeMapHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_OnLeftButtonUp_14(HandleRef pThis);

	/// <summary>
	/// Overridden from vtkInteractorStyleImage to provide the desired
	/// interaction behavior.
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleTreeMapHover_OnLeftButtonUp_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_OnMouseMove_15(HandleRef pThis);

	/// <summary>
	/// Overridden from vtkInteractorStyleImage to provide the desired
	/// interaction behavior.
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleTreeMapHover_OnMouseMove_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTreeMapHover_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleTreeMapHover SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleTreeMapHover vtkInteractorStyleTreeMapHover2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTreeMapHover_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleTreeMapHover2 = (vtkInteractorStyleTreeMapHover)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleTreeMapHover2.Register(null);
			}
		}
		return vtkInteractorStyleTreeMapHover2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_SetHighLightColor_17(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the color used to highlight the hovered vertex.
	/// </summary>
	public void SetHighLightColor(double r, double g, double b)
	{
		vtkInteractorStyleTreeMapHover_SetHighLightColor_17(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_SetHighLightWidth_18(HandleRef pThis, double lw);

	/// <summary>
	/// The width of the line around the hovered vertex.
	/// </summary>
	public void SetHighLightWidth(double lw)
	{
		vtkInteractorStyleTreeMapHover_SetHighLightWidth_18(GetCppThis(), lw);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_SetInteractor_19(HandleRef pThis, HandleRef rwi);

	/// <summary>
	/// Highlights a specific vertex.
	/// </summary>
	public override void SetInteractor(vtkRenderWindowInteractor rwi)
	{
		vtkInteractorStyleTreeMapHover_SetInteractor_19(GetCppThis(), rwi?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_SetLabelField_20(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the field to use when displaying text in the hover balloon.
	/// </summary>
	public virtual void SetLabelField(string _arg)
	{
		vtkInteractorStyleTreeMapHover_SetLabelField_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_SetLayout_21(HandleRef pThis, HandleRef layout);

	/// <summary>
	/// Must be set to the vtkTreeMapLayout used to compute the bounds of each vertex
	/// for the tree map.
	/// </summary>
	public void SetLayout(vtkTreeMapLayout layout)
	{
		vtkInteractorStyleTreeMapHover_SetLayout_21(GetCppThis(), layout?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_SetSelectionLightColor_22(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the color used to highlight the selected vertex.
	/// </summary>
	public void SetSelectionLightColor(double r, double g, double b)
	{
		vtkInteractorStyleTreeMapHover_SetSelectionLightColor_22(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_SetSelectionWidth_23(HandleRef pThis, double lw);

	/// <summary>
	/// The width of the line around the selected vertex.
	/// </summary>
	public void SetSelectionWidth(double lw)
	{
		vtkInteractorStyleTreeMapHover_SetSelectionWidth_23(GetCppThis(), lw);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTreeMapHover_SetTreeMapToPolyData_24(HandleRef pThis, HandleRef filter);

	/// <summary>
	/// Must be set to the vtkTreeMapToPolyData used to convert the tree map
	/// into polydata.
	/// </summary>
	public void SetTreeMapToPolyData(vtkTreeMapToPolyData filter)
	{
		vtkInteractorStyleTreeMapHover_SetTreeMapToPolyData_24(GetCppThis(), filter?.GetCppThis() ?? default(HandleRef));
	}
}
