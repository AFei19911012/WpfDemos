using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabeledTreeMapDataMapper
/// </summary>
/// <remarks>
///    draw text labels on a tree map
///
///
/// vtkLabeledTreeMapDataMapper is a mapper that renders text on a tree map.
/// A tree map is a vtkTree with an associated 4-tuple array
/// used for storing the boundary rectangle for each vertex in the tree.
/// The user must specify the array name used for storing the rectangles.
///
/// The mapper iterates through the tree and attempts and renders a label
/// inside the vertex's rectangle as long as the following conditions hold:
/// 1. The vertex level is within the range of levels specified for labeling.
/// 2. The label can fully fit inside its box.
/// 3. The label does not overlap an ancestor's label.
///
/// </remarks>
/// <seealso>
///
/// vtkLabeledDataMapper
///
/// @par Thanks:
/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
/// Sandia National Laboratories for their help in developing this class.
/// </seealso>
public class vtkLabeledTreeMapDataMapper : vtkLabeledDataMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledTreeMapDataMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabeledTreeMapDataMapper()
	{
		MRClassNameKey = "class vtkLabeledTreeMapDataMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledTreeMapDataMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabeledTreeMapDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledTreeMapDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabeledTreeMapDataMapper New()
	{
		vtkLabeledTreeMapDataMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledTreeMapDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabeledTreeMapDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLabeledTreeMapDataMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLabeledTreeMapDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLabeledTreeMapDataMapper_GetChildMotion_01(HandleRef pThis);

	/// <summary>
	/// Indicates if the label can be moved by its ancestors
	/// </summary>
	public virtual int GetChildMotion()
	{
		return vtkLabeledTreeMapDataMapper_GetChildMotion_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledTreeMapDataMapper_GetClipTextMode_02(HandleRef pThis);

	/// <summary>
	/// Indicates if the label can be displayed clipped by the Window
	/// mode = 0 - ok to clip labels
	/// 1 - auto center labels w/r to the area of the vertex's clipped region
	/// </summary>
	public virtual int GetClipTextMode()
	{
		return vtkLabeledTreeMapDataMapper_GetClipTextMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledTreeMapDataMapper_GetDynamicLevel_03(HandleRef pThis);

	/// <summary>
	/// Indicates at which level labeling should be dynamic
	/// </summary>
	public virtual int GetDynamicLevel()
	{
		return vtkLabeledTreeMapDataMapper_GetDynamicLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_GetFontSizeRange_04(HandleRef pThis, IntPtr range);

	/// <summary>
	/// The range of font sizes to use when rendering the labels.
	/// </summary>
	public void GetFontSizeRange(IntPtr range)
	{
		vtkLabeledTreeMapDataMapper_GetFontSizeRange_04(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledTreeMapDataMapper_GetInputTree_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The input to this filter.
	/// </summary>
	public virtual vtkTree GetInputTree()
	{
		vtkTree vtkTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledTreeMapDataMapper_GetInputTree_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTree2 = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTree2.Register(null);
			}
		}
		return vtkTree2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_GetLevelRange_06(HandleRef pThis, IntPtr range);

	/// <summary>
	/// The range of levels to attempt to label.
	/// The level of a vertex is the length of the path to the root
	/// (the root has level 0).
	/// </summary>
	public void GetLevelRange(IntPtr range)
	{
		vtkLabeledTreeMapDataMapper_GetLevelRange_06(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabeledTreeMapDataMapper_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabeledTreeMapDataMapper_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabeledTreeMapDataMapper_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabeledTreeMapDataMapper_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledTreeMapDataMapper_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabeledTreeMapDataMapper_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabeledTreeMapDataMapper_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabeledTreeMapDataMapper_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledTreeMapDataMapper_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabeledTreeMapDataMapper NewInstance()
	{
		vtkLabeledTreeMapDataMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledTreeMapDataMapper_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabeledTreeMapDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLabeledTreeMapDataMapper_ReleaseGraphicsResources_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_RenderOpaqueGeometry_14(HandleRef pThis, HandleRef viewport, HandleRef actor);

	/// <summary>
	/// Draw the text to the screen at each input point.
	/// </summary>
	public override void RenderOpaqueGeometry(vtkViewport viewport, vtkActor2D actor)
	{
		vtkLabeledTreeMapDataMapper_RenderOpaqueGeometry_14(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), actor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_RenderOverlay_15(HandleRef pThis, HandleRef viewport, HandleRef actor);

	/// <summary>
	/// Draw the text to the screen at each input point.
	/// </summary>
	public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
	{
		vtkLabeledTreeMapDataMapper_RenderOverlay_15(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), actor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabeledTreeMapDataMapper_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabeledTreeMapDataMapper SafeDownCast(vtkObjectBase o)
	{
		vtkLabeledTreeMapDataMapper vtkLabeledTreeMapDataMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabeledTreeMapDataMapper_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabeledTreeMapDataMapper2 = (vtkLabeledTreeMapDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabeledTreeMapDataMapper2.Register(null);
			}
		}
		return vtkLabeledTreeMapDataMapper2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_SetChildMotion_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicates if the label can be moved by its ancestors
	/// </summary>
	public virtual void SetChildMotion(int _arg)
	{
		vtkLabeledTreeMapDataMapper_SetChildMotion_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_SetClipTextMode_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicates if the label can be displayed clipped by the Window
	/// mode = 0 - ok to clip labels
	/// 1 - auto center labels w/r to the area of the vertex's clipped region
	/// </summary>
	public virtual void SetClipTextMode(int _arg)
	{
		vtkLabeledTreeMapDataMapper_SetClipTextMode_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_SetDynamicLevel_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicates at which level labeling should be dynamic
	/// </summary>
	public virtual void SetDynamicLevel(int _arg)
	{
		vtkLabeledTreeMapDataMapper_SetDynamicLevel_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_SetFontSizeRange_20(HandleRef pThis, int maxSize, int minSize, int delta);

	/// <summary>
	/// The range of font sizes to use when rendering the labels.
	/// </summary>
	public void SetFontSizeRange(int maxSize, int minSize, int delta)
	{
		vtkLabeledTreeMapDataMapper_SetFontSizeRange_20(GetCppThis(), maxSize, minSize, delta);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_SetLevelRange_21(HandleRef pThis, int startLevel, int endLevel);

	/// <summary>
	/// The range of levels to attempt to label.
	/// The level of a vertex is the length of the path to the root
	/// (the root has level 0).
	/// </summary>
	public void SetLevelRange(int startLevel, int endLevel)
	{
		vtkLabeledTreeMapDataMapper_SetLevelRange_21(GetCppThis(), startLevel, endLevel);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabeledTreeMapDataMapper_SetRectanglesArrayName_22(HandleRef pThis, string name);

	/// <summary>
	/// The name of the 4-tuple array used for
	/// </summary>
	public virtual void SetRectanglesArrayName(string name)
	{
		vtkLabeledTreeMapDataMapper_SetRectanglesArrayName_22(GetCppThis(), name);
	}
}
