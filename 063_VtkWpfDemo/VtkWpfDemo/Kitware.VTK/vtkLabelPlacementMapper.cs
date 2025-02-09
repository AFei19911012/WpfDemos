using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabelPlacementMapper
/// </summary>
/// <remarks>
///    Places and renders non-overlapping labels.
///
///
/// To use this mapper, first send your data through vtkPointSetToLabelHierarchy,
/// which takes a set of points, associates special arrays to the points (label,
/// priority, etc.), and produces a prioritized spatial tree of labels.
///
/// This mapper then takes that hierarchy (or hierarchies) as input, and every
/// frame will decide which labels and/or icons to place in order of priority,
/// and will render only those labels/icons. A label render strategy is used to
/// render the labels, and can use e.g. FreeType or Qt for rendering.
/// </remarks>
public class vtkLabelPlacementMapper : vtkMapper2D
{
	/// <summary>
	/// Whether to render traversed bounds. Off by default.
	/// </summary>
	public enum LabelShape
	{
		/// <summary>enum member</summary>
		NONE = 0,
		/// <summary>enum member</summary>
		NUMBER_OF_LABEL_SHAPES = 3,
		/// <summary>enum member</summary>
		RECT = 1,
		/// <summary>enum member</summary>
		ROUNDED_RECT = 2
	}

	/// <summary>
	/// The shape of the label background, should be one of the
	/// values in the LabelShape enumeration.
	/// </summary>
	public enum LabelStyle
	{
		/// <summary>enum member</summary>
		FILLED = 0,
		/// <summary>enum member</summary>
		NUMBER_OF_LABEL_STYLES = 2,
		/// <summary>enum member</summary>
		OUTLINE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabelPlacementMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabelPlacementMapper()
	{
		MRClassNameKey = "class vtkLabelPlacementMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelPlacementMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabelPlacementMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacementMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelPlacementMapper New()
	{
		vtkLabelPlacementMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacementMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelPlacementMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLabelPlacementMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLabelPlacementMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOff_01(HandleRef pThis);

	/// <summary>
	/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
	/// for being coincident with other anchor point coordinates.
	/// </summary>
	public virtual void GeneratePerturbedLabelSpokesOff()
	{
		vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOn_02(HandleRef pThis);

	/// <summary>
	/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
	/// for being coincident with other anchor point coordinates.
	/// </summary>
	public virtual void GeneratePerturbedLabelSpokesOn()
	{
		vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacementMapper_GetAnchorTransform_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the transform for the anchor points.
	/// </summary>
	public virtual vtkCoordinate GetAnchorTransform()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacementMapper_GetAnchorTransform_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacementMapper_GetBackgroundColor_04(HandleRef pThis);

	/// <summary>
	/// The color of the background shape.
	/// </summary>
	public virtual double[] GetBackgroundColor()
	{
		IntPtr intPtr = vtkLabelPlacementMapper_GetBackgroundColor_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_GetBackgroundColor_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The color of the background shape.
	/// </summary>
	public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkLabelPlacementMapper_GetBackgroundColor_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_GetBackgroundColor_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color of the background shape.
	/// </summary>
	public virtual void GetBackgroundColor(IntPtr _arg)
	{
		vtkLabelPlacementMapper_GetBackgroundColor_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacementMapper_GetBackgroundOpacity_07(HandleRef pThis);

	/// <summary>
	/// The opacity of the background shape.
	/// </summary>
	public virtual double GetBackgroundOpacity()
	{
		return vtkLabelPlacementMapper_GetBackgroundOpacity_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacementMapper_GetBackgroundOpacityMaxValue_08(HandleRef pThis);

	/// <summary>
	/// The opacity of the background shape.
	/// </summary>
	public virtual double GetBackgroundOpacityMaxValue()
	{
		return vtkLabelPlacementMapper_GetBackgroundOpacityMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacementMapper_GetBackgroundOpacityMinValue_09(HandleRef pThis);

	/// <summary>
	/// The opacity of the background shape.
	/// </summary>
	public virtual double GetBackgroundOpacityMinValue()
	{
		return vtkLabelPlacementMapper_GetBackgroundOpacityMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelPlacementMapper_GetGeneratePerturbedLabelSpokes_10(HandleRef pThis);

	/// <summary>
	/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
	/// for being coincident with other anchor point coordinates.
	/// </summary>
	public virtual bool GetGeneratePerturbedLabelSpokes()
	{
		return (vtkLabelPlacementMapper_GetGeneratePerturbedLabelSpokes_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacementMapper_GetIteratorType_11(HandleRef pThis);

	/// <summary>
	/// The type of iterator used when traversing the labels.
	/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT
	/// </summary>
	public virtual int GetIteratorType()
	{
		return vtkLabelPlacementMapper_GetIteratorType_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacementMapper_GetMargin_12(HandleRef pThis);

	/// <summary>
	/// The size of the margin on the label background shape.
	/// Default is 5.
	/// </summary>
	public virtual double GetMargin()
	{
		return vtkLabelPlacementMapper_GetMargin_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacementMapper_GetMaximumLabelFraction_13(HandleRef pThis);

	/// <summary>
	/// The maximum fraction of the screen that the labels may cover.
	/// Label placement stops when this fraction is reached.
	/// </summary>
	public virtual double GetMaximumLabelFraction()
	{
		return vtkLabelPlacementMapper_GetMaximumLabelFraction_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacementMapper_GetMaximumLabelFractionMaxValue_14(HandleRef pThis);

	/// <summary>
	/// The maximum fraction of the screen that the labels may cover.
	/// Label placement stops when this fraction is reached.
	/// </summary>
	public virtual double GetMaximumLabelFractionMaxValue()
	{
		return vtkLabelPlacementMapper_GetMaximumLabelFractionMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacementMapper_GetMaximumLabelFractionMinValue_15(HandleRef pThis);

	/// <summary>
	/// The maximum fraction of the screen that the labels may cover.
	/// Label placement stops when this fraction is reached.
	/// </summary>
	public virtual double GetMaximumLabelFractionMinValue()
	{
		return vtkLabelPlacementMapper_GetMaximumLabelFractionMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelPlacementMapper_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabelPlacementMapper_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelPlacementMapper_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabelPlacementMapper_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelPlacementMapper_GetOutputTraversedBounds_18(HandleRef pThis);

	/// <summary>
	/// Whether to render traversed bounds. Off by default.
	/// </summary>
	public virtual bool GetOutputTraversedBounds()
	{
		return (vtkLabelPlacementMapper_GetOutputTraversedBounds_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelPlacementMapper_GetPlaceAllLabels_19(HandleRef pThis);

	/// <summary>
	/// Tells the placer to place every label regardless of overlap.
	/// Off by default.
	/// </summary>
	public virtual bool GetPlaceAllLabels()
	{
		return (vtkLabelPlacementMapper_GetPlaceAllLabels_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelPlacementMapper_GetPositionsAsNormals_20(HandleRef pThis);

	/// <summary>
	/// Use label anchor point coordinates as normal vectors and eliminate those
	/// pointing away from the camera. Valid only when points are on a sphere
	/// centered at the origin (such as a 3D geographic view). Off by default.
	/// </summary>
	public virtual bool GetPositionsAsNormals()
	{
		return (vtkLabelPlacementMapper_GetPositionsAsNormals_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacementMapper_GetRenderStrategy_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the label rendering strategy.
	/// </summary>
	public virtual vtkLabelRenderStrategy GetRenderStrategy()
	{
		vtkLabelRenderStrategy vtkLabelRenderStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacementMapper_GetRenderStrategy_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelRenderStrategy2 = (vtkLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelRenderStrategy2.Register(null);
			}
		}
		return vtkLabelRenderStrategy2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacementMapper_GetShape_22(HandleRef pThis);

	/// <summary>
	/// The shape of the label background, should be one of the
	/// values in the LabelShape enumeration.
	/// </summary>
	public virtual int GetShape()
	{
		return vtkLabelPlacementMapper_GetShape_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacementMapper_GetShapeMaxValue_23(HandleRef pThis);

	/// <summary>
	/// The shape of the label background, should be one of the
	/// values in the LabelShape enumeration.
	/// </summary>
	public virtual int GetShapeMaxValue()
	{
		return vtkLabelPlacementMapper_GetShapeMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacementMapper_GetShapeMinValue_24(HandleRef pThis);

	/// <summary>
	/// The shape of the label background, should be one of the
	/// values in the LabelShape enumeration.
	/// </summary>
	public virtual int GetShapeMinValue()
	{
		return vtkLabelPlacementMapper_GetShapeMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacementMapper_GetStyle_25(HandleRef pThis);

	/// <summary>
	/// The style of the label background shape, should be one of the
	/// values in the LabelStyle enumeration.
	/// </summary>
	public virtual int GetStyle()
	{
		return vtkLabelPlacementMapper_GetStyle_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacementMapper_GetStyleMaxValue_26(HandleRef pThis);

	/// <summary>
	/// The style of the label background shape, should be one of the
	/// values in the LabelStyle enumeration.
	/// </summary>
	public virtual int GetStyleMaxValue()
	{
		return vtkLabelPlacementMapper_GetStyleMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacementMapper_GetStyleMinValue_27(HandleRef pThis);

	/// <summary>
	/// The style of the label background shape, should be one of the
	/// values in the LabelStyle enumeration.
	/// </summary>
	public virtual int GetStyleMinValue()
	{
		return vtkLabelPlacementMapper_GetStyleMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelPlacementMapper_GetUseDepthBuffer_28(HandleRef pThis);

	/// <summary>
	/// Use the depth buffer to test each label to see if it should not be displayed if
	/// it would be occluded by other objects in the scene. Off by default.
	/// </summary>
	public virtual bool GetUseDepthBuffer()
	{
		return (vtkLabelPlacementMapper_GetUseDepthBuffer_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacementMapper_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabelPlacementMapper_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacementMapper_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabelPlacementMapper_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacementMapper_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabelPlacementMapper NewInstance()
	{
		vtkLabelPlacementMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacementMapper_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelPlacementMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_OutputTraversedBoundsOff_33(HandleRef pThis);

	/// <summary>
	/// Whether to render traversed bounds. Off by default.
	/// </summary>
	public virtual void OutputTraversedBoundsOff()
	{
		vtkLabelPlacementMapper_OutputTraversedBoundsOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_OutputTraversedBoundsOn_34(HandleRef pThis);

	/// <summary>
	/// Whether to render traversed bounds. Off by default.
	/// </summary>
	public virtual void OutputTraversedBoundsOn()
	{
		vtkLabelPlacementMapper_OutputTraversedBoundsOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_PlaceAllLabelsOff_35(HandleRef pThis);

	/// <summary>
	/// Tells the placer to place every label regardless of overlap.
	/// Off by default.
	/// </summary>
	public virtual void PlaceAllLabelsOff()
	{
		vtkLabelPlacementMapper_PlaceAllLabelsOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_PlaceAllLabelsOn_36(HandleRef pThis);

	/// <summary>
	/// Tells the placer to place every label regardless of overlap.
	/// Off by default.
	/// </summary>
	public virtual void PlaceAllLabelsOn()
	{
		vtkLabelPlacementMapper_PlaceAllLabelsOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_PositionsAsNormalsOff_37(HandleRef pThis);

	/// <summary>
	/// Use label anchor point coordinates as normal vectors and eliminate those
	/// pointing away from the camera. Valid only when points are on a sphere
	/// centered at the origin (such as a 3D geographic view). Off by default.
	/// </summary>
	public virtual void PositionsAsNormalsOff()
	{
		vtkLabelPlacementMapper_PositionsAsNormalsOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_PositionsAsNormalsOn_38(HandleRef pThis);

	/// <summary>
	/// Use label anchor point coordinates as normal vectors and eliminate those
	/// pointing away from the camera. Valid only when points are on a sphere
	/// centered at the origin (such as a 3D geographic view). Off by default.
	/// </summary>
	public virtual void PositionsAsNormalsOn()
	{
		vtkLabelPlacementMapper_PositionsAsNormalsOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_ReleaseGraphicsResources_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLabelPlacementMapper_ReleaseGraphicsResources_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_RenderOverlay_40(HandleRef pThis, HandleRef viewport, HandleRef actor);

	/// <summary>
	/// Draw non-overlapping labels to the screen.
	/// </summary>
	public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
	{
		vtkLabelPlacementMapper_RenderOverlay_40(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), actor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacementMapper_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelPlacementMapper SafeDownCast(vtkObjectBase o)
	{
		vtkLabelPlacementMapper vtkLabelPlacementMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacementMapper_SafeDownCast_41(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelPlacementMapper2 = (vtkLabelPlacementMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelPlacementMapper2.Register(null);
			}
		}
		return vtkLabelPlacementMapper2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetBackgroundColor_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The color of the background shape.
	/// </summary>
	public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
	{
		vtkLabelPlacementMapper_SetBackgroundColor_42(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetBackgroundColor_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color of the background shape.
	/// </summary>
	public virtual void SetBackgroundColor(IntPtr _arg)
	{
		vtkLabelPlacementMapper_SetBackgroundColor_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetBackgroundOpacity_44(HandleRef pThis, double _arg);

	/// <summary>
	/// The opacity of the background shape.
	/// </summary>
	public virtual void SetBackgroundOpacity(double _arg)
	{
		vtkLabelPlacementMapper_SetBackgroundOpacity_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetGeneratePerturbedLabelSpokes_45(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
	/// for being coincident with other anchor point coordinates.
	/// </summary>
	public virtual void SetGeneratePerturbedLabelSpokes(bool _arg)
	{
		vtkLabelPlacementMapper_SetGeneratePerturbedLabelSpokes_45(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetIteratorType_46(HandleRef pThis, int _arg);

	/// <summary>
	/// The type of iterator used when traversing the labels.
	/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT
	/// </summary>
	public virtual void SetIteratorType(int _arg)
	{
		vtkLabelPlacementMapper_SetIteratorType_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetMargin_47(HandleRef pThis, double _arg);

	/// <summary>
	/// The size of the margin on the label background shape.
	/// Default is 5.
	/// </summary>
	public virtual void SetMargin(double _arg)
	{
		vtkLabelPlacementMapper_SetMargin_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetMaximumLabelFraction_48(HandleRef pThis, double _arg);

	/// <summary>
	/// The maximum fraction of the screen that the labels may cover.
	/// Label placement stops when this fraction is reached.
	/// </summary>
	public virtual void SetMaximumLabelFraction(double _arg)
	{
		vtkLabelPlacementMapper_SetMaximumLabelFraction_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetOutputTraversedBounds_49(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to render traversed bounds. Off by default.
	/// </summary>
	public virtual void SetOutputTraversedBounds(bool _arg)
	{
		vtkLabelPlacementMapper_SetOutputTraversedBounds_49(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetPlaceAllLabels_50(HandleRef pThis, byte _arg);

	/// <summary>
	/// Tells the placer to place every label regardless of overlap.
	/// Off by default.
	/// </summary>
	public virtual void SetPlaceAllLabels(bool _arg)
	{
		vtkLabelPlacementMapper_SetPlaceAllLabels_50(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetPositionsAsNormals_51(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use label anchor point coordinates as normal vectors and eliminate those
	/// pointing away from the camera. Valid only when points are on a sphere
	/// centered at the origin (such as a 3D geographic view). Off by default.
	/// </summary>
	public virtual void SetPositionsAsNormals(bool _arg)
	{
		vtkLabelPlacementMapper_SetPositionsAsNormals_51(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetRenderStrategy_52(HandleRef pThis, HandleRef s);

	/// <summary>
	/// Set the label rendering strategy.
	/// </summary>
	public virtual void SetRenderStrategy(vtkLabelRenderStrategy s)
	{
		vtkLabelPlacementMapper_SetRenderStrategy_52(GetCppThis(), s?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetShape_53(HandleRef pThis, int _arg);

	/// <summary>
	/// The shape of the label background, should be one of the
	/// values in the LabelShape enumeration.
	/// </summary>
	public virtual void SetShape(int _arg)
	{
		vtkLabelPlacementMapper_SetShape_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetShapeToNone_54(HandleRef pThis);

	/// <summary>
	/// The shape of the label background, should be one of the
	/// values in the LabelShape enumeration.
	/// </summary>
	public virtual void SetShapeToNone()
	{
		vtkLabelPlacementMapper_SetShapeToNone_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetShapeToRect_55(HandleRef pThis);

	/// <summary>
	/// The shape of the label background, should be one of the
	/// values in the LabelShape enumeration.
	/// </summary>
	public virtual void SetShapeToRect()
	{
		vtkLabelPlacementMapper_SetShapeToRect_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetShapeToRoundedRect_56(HandleRef pThis);

	/// <summary>
	/// The shape of the label background, should be one of the
	/// values in the LabelShape enumeration.
	/// </summary>
	public virtual void SetShapeToRoundedRect()
	{
		vtkLabelPlacementMapper_SetShapeToRoundedRect_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetStyle_57(HandleRef pThis, int _arg);

	/// <summary>
	/// The style of the label background shape, should be one of the
	/// values in the LabelStyle enumeration.
	/// </summary>
	public virtual void SetStyle(int _arg)
	{
		vtkLabelPlacementMapper_SetStyle_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetStyleToFilled_58(HandleRef pThis);

	/// <summary>
	/// The style of the label background shape, should be one of the
	/// values in the LabelStyle enumeration.
	/// </summary>
	public virtual void SetStyleToFilled()
	{
		vtkLabelPlacementMapper_SetStyleToFilled_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetStyleToOutline_59(HandleRef pThis);

	/// <summary>
	/// The style of the label background shape, should be one of the
	/// values in the LabelStyle enumeration.
	/// </summary>
	public virtual void SetStyleToOutline()
	{
		vtkLabelPlacementMapper_SetStyleToOutline_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_SetUseDepthBuffer_60(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use the depth buffer to test each label to see if it should not be displayed if
	/// it would be occluded by other objects in the scene. Off by default.
	/// </summary>
	public virtual void SetUseDepthBuffer(bool _arg)
	{
		vtkLabelPlacementMapper_SetUseDepthBuffer_60(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_UseDepthBufferOff_61(HandleRef pThis);

	/// <summary>
	/// Use the depth buffer to test each label to see if it should not be displayed if
	/// it would be occluded by other objects in the scene. Off by default.
	/// </summary>
	public virtual void UseDepthBufferOff()
	{
		vtkLabelPlacementMapper_UseDepthBufferOff_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacementMapper_UseDepthBufferOn_62(HandleRef pThis);

	/// <summary>
	/// Use the depth buffer to test each label to see if it should not be displayed if
	/// it would be occluded by other objects in the scene. Off by default.
	/// </summary>
	public virtual void UseDepthBufferOn()
	{
		vtkLabelPlacementMapper_UseDepthBufferOn_62(GetCppThis());
	}
}
