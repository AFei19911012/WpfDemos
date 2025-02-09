using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabelPlacer
/// </summary>
/// <remarks>
///    place a prioritized hierarchy of labels in screen space
///
///
/// &lt;b&gt;This class is deprecated and will be removed from VTK in a future
/// release. Use vtkLabelPlacementMapper instead.&lt;/b&gt;
///
/// This should probably be a mapper unto itself (given that
/// the polydata output could be large and will realistically
/// always be iterated over exactly once before being tossed
/// for the next frame of the render).
///
/// In any event, it takes as input one (or more, eventually)
/// vtkLabelHierarchies that represent prioritized lists of
/// labels sorted by their placement in space. As output, it
/// provides vtkPolyData containing only VTK_QUAD cells, each
/// representing a single label from the input. Each quadrilateral
/// has cell data indicating what label in the input it
/// corresponds to (via an array named "LabelId").
/// </remarks>
public class vtkLabelPlacer : vtkPolyDataAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum LabelGravity
	{
		/// <summary>enum member</summary>
		BaselineCenter = 34,
		/// <summary>enum member</summary>
		BaselineLeft = 18,
		/// <summary>enum member</summary>
		BaselineRight = 66,
		/// <summary>enum member</summary>
		CenterCenter = 36,
		/// <summary>enum member</summary>
		CenterLeft = 20,
		/// <summary>enum member</summary>
		CenterRight = 68,
		/// <summary>enum member</summary>
		HorizontalBitMask = 112,
		/// <summary>enum member</summary>
		HorizontalCenterBit = 32,
		/// <summary>enum member</summary>
		HorizontalLeftBit = 16,
		/// <summary>enum member</summary>
		HorizontalRightBit = 64,
		/// <summary>enum member</summary>
		LowerCenter = 33,
		/// <summary>enum member</summary>
		LowerLeft = 17,
		/// <summary>enum member</summary>
		LowerRight = 65,
		/// <summary>enum member</summary>
		UpperCenter = 40,
		/// <summary>enum member</summary>
		UpperLeft = 24,
		/// <summary>enum member</summary>
		UpperRight = 72,
		/// <summary>enum member</summary>
		VerticalBaselineBit = 2,
		/// <summary>enum member</summary>
		VerticalBitMask = 15,
		/// <summary>enum member</summary>
		VerticalBottomBit = 1,
		/// <summary>enum member</summary>
		VerticalCenterBit = 4,
		/// <summary>enum member</summary>
		VerticalTopBit = 8
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum OutputCoordinates
	{
		/// <summary>enum member</summary>
		DISPLAY = 1,
		/// <summary>enum member</summary>
		WORLD = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabelPlacer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabelPlacer()
	{
		MRClassNameKey = "class vtkLabelPlacer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelPlacer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabelPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelPlacer New()
	{
		vtkLabelPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLabelPlacer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLabelPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLabelPlacer_GeneratePerturbedLabelSpokesOff_01(HandleRef pThis);

	/// <summary>
	/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
	/// for being coincident with other anchor point coordinates.
	/// </summary>
	public virtual void GeneratePerturbedLabelSpokesOff()
	{
		vtkLabelPlacer_GeneratePerturbedLabelSpokesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_GeneratePerturbedLabelSpokesOn_02(HandleRef pThis);

	/// <summary>
	/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
	/// for being coincident with other anchor point coordinates.
	/// </summary>
	public virtual void GeneratePerturbedLabelSpokesOn()
	{
		vtkLabelPlacer_GeneratePerturbedLabelSpokesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacer_GetAnchorTransform_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkCoordinate GetAnchorTransform()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacer_GetAnchorTransform_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkLabelPlacer_GetGeneratePerturbedLabelSpokes_04(HandleRef pThis);

	/// <summary>
	/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
	/// for being coincident with other anchor point coordinates.
	/// </summary>
	public virtual bool GetGeneratePerturbedLabelSpokes()
	{
		return (vtkLabelPlacer_GetGeneratePerturbedLabelSpokes_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacer_GetGravity_05(HandleRef pThis);

	/// <summary>
	/// The placement of the label relative to the anchor point.
	/// </summary>
	public virtual int GetGravity()
	{
		return vtkLabelPlacer_GetGravity_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacer_GetIteratorType_06(HandleRef pThis);

	/// <summary>
	/// The type of iterator used when traversing the labels.
	/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT.
	/// </summary>
	public virtual int GetIteratorType()
	{
		return vtkLabelPlacer_GetIteratorType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkLabelPlacer_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// The type of iterator used when traversing the labels.
	/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkLabelPlacer_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacer_GetMaximumLabelFraction_08(HandleRef pThis);

	/// <summary>
	/// The maximum amount of screen space labels can take up before placement
	/// terminates.
	/// </summary>
	public virtual double GetMaximumLabelFraction()
	{
		return vtkLabelPlacer_GetMaximumLabelFraction_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacer_GetMaximumLabelFractionMaxValue_09(HandleRef pThis);

	/// <summary>
	/// The maximum amount of screen space labels can take up before placement
	/// terminates.
	/// </summary>
	public virtual double GetMaximumLabelFractionMaxValue()
	{
		return vtkLabelPlacer_GetMaximumLabelFractionMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLabelPlacer_GetMaximumLabelFractionMinValue_10(HandleRef pThis);

	/// <summary>
	/// The maximum amount of screen space labels can take up before placement
	/// terminates.
	/// </summary>
	public virtual double GetMaximumLabelFractionMinValue()
	{
		return vtkLabelPlacer_GetMaximumLabelFractionMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelPlacer_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabelPlacer_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelPlacer_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabelPlacer_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacer_GetOutputCoordinateSystem_13(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public virtual int GetOutputCoordinateSystem()
	{
		return vtkLabelPlacer_GetOutputCoordinateSystem_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacer_GetOutputCoordinateSystemMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public virtual int GetOutputCoordinateSystemMaxValue()
	{
		return vtkLabelPlacer_GetOutputCoordinateSystemMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacer_GetOutputCoordinateSystemMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public virtual int GetOutputCoordinateSystemMinValue()
	{
		return vtkLabelPlacer_GetOutputCoordinateSystemMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelPlacer_GetOutputTraversedBounds_16(HandleRef pThis);

	/// <summary>
	/// In the second output, output the geometry of the traversed octree nodes.
	/// </summary>
	public virtual bool GetOutputTraversedBounds()
	{
		return (vtkLabelPlacer_GetOutputTraversedBounds_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelPlacer_GetPositionsAsNormals_17(HandleRef pThis);

	/// <summary>
	/// Use label anchor point coordinates as normal vectors and eliminate those
	/// pointing away from the camera. Valid only when points are on a sphere
	/// centered at the origin (such as a 3D geographic view). Off by default.
	/// </summary>
	public virtual bool GetPositionsAsNormals()
	{
		return (vtkLabelPlacer_GetPositionsAsNormals_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacer_GetRenderer_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacer_GetRenderer_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelPlacer_GetUseDepthBuffer_19(HandleRef pThis);

	/// <summary>
	/// Use the depth buffer to test each label to see if it should not be displayed if
	/// it would be occluded by other objects in the scene. Off by default.
	/// </summary>
	public virtual bool GetUseDepthBuffer()
	{
		return (vtkLabelPlacer_GetUseDepthBuffer_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacer_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabelPlacer_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelPlacer_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabelPlacer_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacer_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabelPlacer NewInstance()
	{
		vtkLabelPlacer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacer_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_OutputCoordinateSystemDisplay_24(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public void OutputCoordinateSystemDisplay()
	{
		vtkLabelPlacer_OutputCoordinateSystemDisplay_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_OutputCoordinateSystemWorld_25(HandleRef pThis);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public void OutputCoordinateSystemWorld()
	{
		vtkLabelPlacer_OutputCoordinateSystemWorld_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_OutputTraversedBoundsOff_26(HandleRef pThis);

	/// <summary>
	/// In the second output, output the geometry of the traversed octree nodes.
	/// </summary>
	public virtual void OutputTraversedBoundsOff()
	{
		vtkLabelPlacer_OutputTraversedBoundsOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_OutputTraversedBoundsOn_27(HandleRef pThis);

	/// <summary>
	/// In the second output, output the geometry of the traversed octree nodes.
	/// </summary>
	public virtual void OutputTraversedBoundsOn()
	{
		vtkLabelPlacer_OutputTraversedBoundsOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_PositionsAsNormalsOff_28(HandleRef pThis);

	/// <summary>
	/// Use label anchor point coordinates as normal vectors and eliminate those
	/// pointing away from the camera. Valid only when points are on a sphere
	/// centered at the origin (such as a 3D geographic view). Off by default.
	/// </summary>
	public virtual void PositionsAsNormalsOff()
	{
		vtkLabelPlacer_PositionsAsNormalsOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_PositionsAsNormalsOn_29(HandleRef pThis);

	/// <summary>
	/// Use label anchor point coordinates as normal vectors and eliminate those
	/// pointing away from the camera. Valid only when points are on a sphere
	/// centered at the origin (such as a 3D geographic view). Off by default.
	/// </summary>
	public virtual void PositionsAsNormalsOn()
	{
		vtkLabelPlacer_PositionsAsNormalsOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelPlacer_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelPlacer SafeDownCast(vtkObjectBase o)
	{
		vtkLabelPlacer vtkLabelPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelPlacer_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelPlacer2 = (vtkLabelPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelPlacer2.Register(null);
			}
		}
		return vtkLabelPlacer2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_SetGeneratePerturbedLabelSpokes_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable drawing spokes (lines) to anchor point coordinates that were perturbed
	/// for being coincident with other anchor point coordinates.
	/// </summary>
	public virtual void SetGeneratePerturbedLabelSpokes(bool _arg)
	{
		vtkLabelPlacer_SetGeneratePerturbedLabelSpokes_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_SetGravity_32(HandleRef pThis, int gravity);

	/// <summary>
	/// The placement of the label relative to the anchor point.
	/// </summary>
	public virtual void SetGravity(int gravity)
	{
		vtkLabelPlacer_SetGravity_32(GetCppThis(), gravity);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_SetIteratorType_33(HandleRef pThis, int _arg);

	/// <summary>
	/// The type of iterator used when traversing the labels.
	/// May be vtkLabelHierarchy::FRUSTUM or vtkLabelHierarchy::FULL_SORT.
	/// </summary>
	public virtual void SetIteratorType(int _arg)
	{
		vtkLabelPlacer_SetIteratorType_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_SetMaximumLabelFraction_34(HandleRef pThis, double _arg);

	/// <summary>
	/// The maximum amount of screen space labels can take up before placement
	/// terminates.
	/// </summary>
	public virtual void SetMaximumLabelFraction(double _arg)
	{
		vtkLabelPlacer_SetMaximumLabelFraction_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_SetOutputCoordinateSystem_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the coordinate system used for output labels.
	/// The output datasets may have point coordinates reported in the world space or display space.
	/// </summary>
	public virtual void SetOutputCoordinateSystem(int _arg)
	{
		vtkLabelPlacer_SetOutputCoordinateSystem_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_SetOutputTraversedBounds_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// In the second output, output the geometry of the traversed octree nodes.
	/// </summary>
	public virtual void SetOutputTraversedBounds(bool _arg)
	{
		vtkLabelPlacer_SetOutputTraversedBounds_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_SetPositionsAsNormals_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use label anchor point coordinates as normal vectors and eliminate those
	/// pointing away from the camera. Valid only when points are on a sphere
	/// centered at the origin (such as a 3D geographic view). Off by default.
	/// </summary>
	public virtual void SetPositionsAsNormals(bool _arg)
	{
		vtkLabelPlacer_SetPositionsAsNormals_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_SetRenderer_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetRenderer(vtkRenderer arg0)
	{
		vtkLabelPlacer_SetRenderer_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_SetUseDepthBuffer_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use the depth buffer to test each label to see if it should not be displayed if
	/// it would be occluded by other objects in the scene. Off by default.
	/// </summary>
	public virtual void SetUseDepthBuffer(bool _arg)
	{
		vtkLabelPlacer_SetUseDepthBuffer_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_UseDepthBufferOff_40(HandleRef pThis);

	/// <summary>
	/// Use the depth buffer to test each label to see if it should not be displayed if
	/// it would be occluded by other objects in the scene. Off by default.
	/// </summary>
	public virtual void UseDepthBufferOff()
	{
		vtkLabelPlacer_UseDepthBufferOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelPlacer_UseDepthBufferOn_41(HandleRef pThis);

	/// <summary>
	/// Use the depth buffer to test each label to see if it should not be displayed if
	/// it would be occluded by other objects in the scene. Off by default.
	/// </summary>
	public virtual void UseDepthBufferOn()
	{
		vtkLabelPlacer_UseDepthBufferOn_41(GetCppThis());
	}
}
