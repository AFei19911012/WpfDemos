using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGlyph3DMapper
/// </summary>
/// <remarks>
///    vtkGlyph3D on the GPU.
///
/// Do the same job than vtkGlyph3D but on the GPU. For this reason, it is
/// a mapper not a vtkPolyDataAlgorithm. Also, some methods of vtkGlyph3D
/// don't make sense in vtkGlyph3DMapper: GeneratePointIds, old-style
/// SetSource, PointIdsName, IsPointVisible.
///
/// </remarks>
/// <seealso>
///
/// vtkGlyph3D
/// </seealso>
public class vtkGlyph3DMapper : vtkMapper
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum ArrayIndexes
	{
		/// <summary>enum member</summary>
		MASK = 2,
		/// <summary>enum member</summary>
		ORIENTATION = 3,
		/// <summary>enum member</summary>
		SCALE = 0,
		/// <summary>enum member</summary>
		SELECTIONID = 4,
		/// <summary>enum member</summary>
		SOURCE_INDEX = 1
	}

	/// <summary>
	/// Orientation mode indicates if the OrientationArray provides the direction
	/// vector for the orientation or the rotations around each axes. Default is
	/// DIRECTION
	/// </summary>
	public enum OrientationModes
	{
		/// <summary>enum member</summary>
		DIRECTION = 0,
		/// <summary>enum member</summary>
		QUATERNION = 2,
		/// <summary>enum member</summary>
		ROTATION = 1
	}

	/// <summary>
	/// Specify scale factor to scale object by. This is used only when Scaling is
	/// On.
	/// </summary>
	public enum ScaleModes
	{
		/// <summary>enum member</summary>
		NO_DATA_SCALING = 0,
		/// <summary>enum member</summary>
		SCALE_BY_COMPONENTS = 2,
		/// <summary>enum member</summary>
		SCALE_BY_MAGNITUDE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGlyph3DMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGlyph3DMapper()
	{
		MRClassNameKey = "class vtkGlyph3DMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyph3DMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGlyph3DMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGlyph3DMapper New()
	{
		vtkGlyph3DMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3DMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGlyph3DMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGlyph3DMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_ClampingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off clamping of data values to scale with to the specified range.
	/// </summary>
	public virtual void ClampingOff()
	{
		vtkGlyph3DMapper_ClampingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_ClampingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off clamping of data values to scale with to the specified range.
	/// </summary>
	public virtual void ClampingOn()
	{
		vtkGlyph3DMapper_ClampingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_GetBlockAttributes_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When the input data object (not the source) is composite data,
	/// it is possible to control visibility and pickability on a per-block
	/// basis by passing the mapper a vtkCompositeDataDisplayAttributes instance.
	/// The color and opacity in the display-attributes instance are ignored
	/// for now. By default, the mapper does not own a display-attributes
	/// instance. The value of BlockAttributes has no effect when the input
	/// is a poly-data object.
	/// </summary>
	public virtual vtkCompositeDataDisplayAttributes GetBlockAttributes()
	{
		vtkCompositeDataDisplayAttributes vtkCompositeDataDisplayAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3DMapper_GetBlockAttributes_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataDisplayAttributes2 = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataDisplayAttributes2.Register(null);
			}
		}
		return vtkCompositeDataDisplayAttributes2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_GetBounds_04(HandleRef pThis);

	/// <summary>
	/// Redefined to take into account the bounds of the scaled glyphs.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkGlyph3DMapper_GetBounds_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_GetBounds_05(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Same as superclass. Appear again to stop warnings about hidden method.
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkGlyph3DMapper_GetBounds_05(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetClamping_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off clamping of data values to scale with to the specified range.
	/// </summary>
	public virtual bool GetClamping()
	{
		return (vtkGlyph3DMapper_GetClamping_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetCullingAndLOD_07(HandleRef pThis);

	/// <summary>
	/// Enable or disable frustum culling and LOD of the instances.
	/// When enabled, an OpenGL driver supporting GL_ARB_gpu_shader5 extension is mandatory.
	/// </summary>
	public virtual bool GetCullingAndLOD()
	{
		return (vtkGlyph3DMapper_GetCullingAndLOD_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetLODColoring_08(HandleRef pThis);

	/// <summary>
	/// Enable LOD coloring. It can be useful to configure properly the LODs.
	/// Each LOD have a unique color, based on its index.
	/// </summary>
	public virtual bool GetLODColoring()
	{
		return (vtkGlyph3DMapper_GetLODColoring_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetMasking_09(HandleRef pThis);

	/// <summary>
	/// Tells the mapper to skip glyphing input points that haves false values
	/// in the mask array. If there is no mask array (id access mode is set
	/// and there is no such id, or array name access mode is set and
	/// the there is no such name), masking is silently ignored.
	/// A mask array is a vtkBitArray with only one component.
	/// Initial value is false.
	/// </summary>
	public virtual bool GetMasking()
	{
		return (vtkGlyph3DMapper_GetMasking_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlyph3DMapper_GetMaxNumberOfLOD_10(HandleRef pThis);

	/// <summary>
	/// Get the maximum number of LOD. OpenGL context must be bound.
	/// The maximum number of LOD depends on GPU capabilities.
	/// This method is intended to be reimplemented in inherited classes, current implementation
	/// always returns zero.
	/// </summary>
	public virtual long GetMaxNumberOfLOD()
	{
		return vtkGlyph3DMapper_GetMaxNumberOfLOD_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlyph3DMapper_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGlyph3DMapper_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlyph3DMapper_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGlyph3DMapper_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetOrient_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off orienting of input geometry.
	/// When turned on, the orientation array specified
	/// using SetOrientationArray() will be used.
	/// </summary>
	public virtual bool GetOrient()
	{
		return (vtkGlyph3DMapper_GetOrient_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3DMapper_GetOrientationMode_14(HandleRef pThis);

	/// <summary>
	/// Orientation mode indicates if the OrientationArray provides the direction
	/// vector for the orientation or the rotations around each axes. Default is
	/// DIRECTION
	/// </summary>
	public virtual int GetOrientationMode()
	{
		return vtkGlyph3DMapper_GetOrientationMode_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_GetOrientationModeAsString_15(HandleRef pThis);

	/// <summary>
	/// Orientation mode indicates if the OrientationArray provides the direction
	/// vector for the orientation or the rotations around each axes. Default is
	/// DIRECTION
	/// </summary>
	public string GetOrientationModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGlyph3DMapper_GetOrientationModeAsString_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3DMapper_GetOrientationModeMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Orientation mode indicates if the OrientationArray provides the direction
	/// vector for the orientation or the rotations around each axes. Default is
	/// DIRECTION
	/// </summary>
	public virtual int GetOrientationModeMaxValue()
	{
		return vtkGlyph3DMapper_GetOrientationModeMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3DMapper_GetOrientationModeMinValue_17(HandleRef pThis);

	/// <summary>
	/// Orientation mode indicates if the OrientationArray provides the direction
	/// vector for the orientation or the rotations around each axes. Default is
	/// DIRECTION
	/// </summary>
	public virtual int GetOrientationModeMinValue()
	{
		return vtkGlyph3DMapper_GetOrientationModeMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_GetRange_18(HandleRef pThis);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public virtual double[] GetRange()
	{
		IntPtr intPtr = vtkGlyph3DMapper_GetRange_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_GetRange_19(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public virtual void GetRange(IntPtr data)
	{
		vtkGlyph3DMapper_GetRange_19(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGlyph3DMapper_GetScaleFactor_20(HandleRef pThis);

	/// <summary>
	/// Specify scale factor to scale object by. This is used only when Scaling is
	/// On.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkGlyph3DMapper_GetScaleFactor_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3DMapper_GetScaleMode_21(HandleRef pThis);

	/// <summary>
	/// Either scale by individual components (SCALE_BY_COMPONENTS) or magnitude
	/// (SCALE_BY_MAGNITUDE) of the chosen array to SCALE with or disable scaling
	/// using data array all together (NO_DATA_SCALING). Default is
	/// NO_DATA_SCALING.
	/// </summary>
	public virtual int GetScaleMode()
	{
		return vtkGlyph3DMapper_GetScaleMode_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_GetScaleModeAsString_22(HandleRef pThis);

	/// <summary>
	/// Specify scale factor to scale object by. This is used only when Scaling is
	/// On.
	/// </summary>
	public string GetScaleModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGlyph3DMapper_GetScaleModeAsString_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetScaling_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of source geometry. When turned on, ScaleFactor
	/// controls the scale applied. To scale with some data array, ScaleMode should
	/// be set accordingly.
	/// </summary>
	public virtual bool GetScaling()
	{
		return (vtkGlyph3DMapper_GetScaling_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkGlyph3DMapper_GetSelectionColorId_24(HandleRef pThis);

	/// <summary>
	/// For selection by color id mode (not for end-user, called by
	/// vtkGlyphSelectionRenderMode). 0 is reserved for miss. it has to
	/// start at 1. Initial value is 1.
	/// </summary>
	public virtual uint GetSelectionColorId()
	{
		return vtkGlyph3DMapper_GetSelectionColorId_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_GetSource_25(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to a source object at a specified table location.
	/// </summary>
	public vtkPolyData GetSource(int idx)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3DMapper_GetSource_25(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetSourceIndexing_26(HandleRef pThis);

	/// <summary>
	/// Enable/disable indexing into table of the glyph sources. When disabled,
	/// only the 1st source input will be used to generate the glyph. Otherwise the
	/// source index array will be used to select the glyph source. The source
	/// index array can be specified using SetSourceIndexArray().
	/// </summary>
	public virtual bool GetSourceIndexing()
	{
		return (vtkGlyph3DMapper_GetSourceIndexing_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_GetSourceTableTree_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method to get the source table tree, if it exists.
	/// </summary>
	public vtkDataObjectTree GetSourceTableTree()
	{
		vtkDataObjectTree vtkDataObjectTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3DMapper_GetSourceTableTree_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObjectTree2 = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObjectTree2.Register(null);
			}
		}
		return vtkDataObjectTree2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetSupportsSelection_28(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Used by vtkHardwareSelector to determine if the prop supports hardware
	/// selection.
	/// </summary>
	public override bool GetSupportsSelection()
	{
		return (vtkGlyph3DMapper_GetSupportsSelection_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetUseSelectionIds_29(HandleRef pThis);

	/// <summary>
	/// Turn on/off custom selection ids. If enabled, the id values set with
	/// SetSelectionIdArray are returned from pick events.
	/// </summary>
	public virtual bool GetUseSelectionIds()
	{
		return (vtkGlyph3DMapper_GetUseSelectionIds_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGlyph3DMapper_GetUseSourceTableTree_30(HandleRef pThis);

	/// <summary>
	/// If true, and the glyph source dataset is a subclass of vtkDataObjectTree,
	/// the top-level members of the tree will be mapped to the glyph source table
	/// used for SourceIndexing.
	/// </summary>
	public virtual bool GetUseSourceTableTree()
	{
		return (vtkGlyph3DMapper_GetUseSourceTableTree_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3DMapper_IsA_31(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGlyph3DMapper_IsA_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyph3DMapper_IsTypeOf_32(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGlyph3DMapper_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_MaskingOff_33(HandleRef pThis);

	/// <summary>
	/// Tells the mapper to skip glyphing input points that haves false values
	/// in the mask array. If there is no mask array (id access mode is set
	/// and there is no such id, or array name access mode is set and
	/// the there is no such name), masking is silently ignored.
	/// A mask array is a vtkBitArray with only one component.
	/// Initial value is false.
	/// </summary>
	public virtual void MaskingOff()
	{
		vtkGlyph3DMapper_MaskingOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_MaskingOn_34(HandleRef pThis);

	/// <summary>
	/// Tells the mapper to skip glyphing input points that haves false values
	/// in the mask array. If there is no mask array (id access mode is set
	/// and there is no such id, or array name access mode is set and
	/// the there is no such name), masking is silently ignored.
	/// A mask array is a vtkBitArray with only one component.
	/// Initial value is false.
	/// </summary>
	public virtual void MaskingOn()
	{
		vtkGlyph3DMapper_MaskingOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGlyph3DMapper NewInstance()
	{
		vtkGlyph3DMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3DMapper_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_OrientOff_37(HandleRef pThis);

	/// <summary>
	/// Turn on/off orienting of input geometry.
	/// When turned on, the orientation array specified
	/// using SetOrientationArray() will be used.
	/// </summary>
	public virtual void OrientOff()
	{
		vtkGlyph3DMapper_OrientOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_OrientOn_38(HandleRef pThis);

	/// <summary>
	/// Turn on/off orienting of input geometry.
	/// When turned on, the orientation array specified
	/// using SetOrientationArray() will be used.
	/// </summary>
	public virtual void OrientOn()
	{
		vtkGlyph3DMapper_OrientOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_Render_39(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// All the work is done is derived classes.
	/// </summary>
	public override void Render(vtkRenderer ren, vtkActor act)
	{
		vtkGlyph3DMapper_Render_39(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyph3DMapper_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGlyph3DMapper SafeDownCast(vtkObjectBase o)
	{
		vtkGlyph3DMapper vtkGlyph3DMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyph3DMapper_SafeDownCast_40(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGlyph3DMapper2 = (vtkGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGlyph3DMapper2.Register(null);
			}
		}
		return vtkGlyph3DMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_ScalingOff_41(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of source geometry. When turned on, ScaleFactor
	/// controls the scale applied. To scale with some data array, ScaleMode should
	/// be set accordingly.
	/// </summary>
	public virtual void ScalingOff()
	{
		vtkGlyph3DMapper_ScalingOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_ScalingOn_42(HandleRef pThis);

	/// <summary>
	/// Turn on/off scaling of source geometry. When turned on, ScaleFactor
	/// controls the scale applied. To scale with some data array, ScaleMode should
	/// be set accordingly.
	/// </summary>
	public virtual void ScalingOn()
	{
		vtkGlyph3DMapper_ScalingOn_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetBlockAttributes_43(HandleRef pThis, HandleRef attr);

	/// <summary>
	/// When the input data object (not the source) is composite data,
	/// it is possible to control visibility and pickability on a per-block
	/// basis by passing the mapper a vtkCompositeDataDisplayAttributes instance.
	/// The color and opacity in the display-attributes instance are ignored
	/// for now. By default, the mapper does not own a display-attributes
	/// instance. The value of BlockAttributes has no effect when the input
	/// is a poly-data object.
	/// </summary>
	public virtual void SetBlockAttributes(vtkCompositeDataDisplayAttributes attr)
	{
		vtkGlyph3DMapper_SetBlockAttributes_43(GetCppThis(), attr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetClamping_44(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off clamping of data values to scale with to the specified range.
	/// </summary>
	public virtual void SetClamping(bool _arg)
	{
		vtkGlyph3DMapper_SetClamping_44(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetCullingAndLOD_45(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable or disable frustum culling and LOD of the instances.
	/// When enabled, an OpenGL driver supporting GL_ARB_gpu_shader5 extension is mandatory.
	/// </summary>
	public virtual void SetCullingAndLOD(bool _arg)
	{
		vtkGlyph3DMapper_SetCullingAndLOD_45(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetInputData_46(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Assign a data object as input. Note that this method does not
	/// establish a pipeline connection. Use SetInputConnection() to
	/// setup a pipeline connection.
	/// </summary>
	public void SetInputData(vtkDataObject arg0)
	{
		vtkGlyph3DMapper_SetInputData_46(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetLODColoring_47(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable LOD coloring. It can be useful to configure properly the LODs.
	/// Each LOD have a unique color, based on its index.
	/// </summary>
	public virtual void SetLODColoring(bool _arg)
	{
		vtkGlyph3DMapper_SetLODColoring_47(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetLODDistanceAndTargetReduction_48(HandleRef pThis, long arg0, float arg1, float arg2);

	/// <summary>
	/// Configure LODs. Culling must be enabled.
	/// distance have to be a positive value, it is the distance to the camera scaled by
	/// the instanced geometry bounding box.
	/// targetReduction have to be between 0 and 1, 0 disable decimation, 1 draw a point.
	/// This method is intended to be reimplemented in inherited classes, current implementation
	/// does nothing.
	///
	/// @sa vtkDecimatePro::SetTargetReduction
	/// </summary>
	public virtual void SetLODDistanceAndTargetReduction(long arg0, float arg1, float arg2)
	{
		vtkGlyph3DMapper_SetLODDistanceAndTargetReduction_48(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetMaskArray_49(HandleRef pThis, string maskarrayname);

	/// <summary>
	/// Set the name of the point array to use as a mask for generating the glyphs.
	/// This is a convenience method. The same effect can be achieved by using
	/// SetInputArrayToProcess(vtkGlyph3DMapper::MASK, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, maskarrayname)
	/// </summary>
	public void SetMaskArray(string maskarrayname)
	{
		vtkGlyph3DMapper_SetMaskArray_49(GetCppThis(), maskarrayname);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetMaskArray_50(HandleRef pThis, int fieldAttributeType);

	/// <summary>
	/// Set the point attribute to use as a mask for generating the glyphs.
	/// \c fieldAttributeType is one of the following:
	/// \li vtkDataSetAttributes::SCALARS
	/// \li vtkDataSetAttributes::VECTORS
	/// \li vtkDataSetAttributes::NORMALS
	/// \li vtkDataSetAttributes::TCOORDS
	/// \li vtkDataSetAttributes::TENSORS
	/// This is a convenience method. The same effect can be achieved by using
	/// SetInputArrayToProcess(vtkGlyph3DMapper::MASK, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType)
	/// </summary>
	public void SetMaskArray(int fieldAttributeType)
	{
		vtkGlyph3DMapper_SetMaskArray_50(GetCppThis(), fieldAttributeType);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetMasking_51(HandleRef pThis, byte _arg);

	/// <summary>
	/// Tells the mapper to skip glyphing input points that haves false values
	/// in the mask array. If there is no mask array (id access mode is set
	/// and there is no such id, or array name access mode is set and
	/// the there is no such name), masking is silently ignored.
	/// A mask array is a vtkBitArray with only one component.
	/// Initial value is false.
	/// </summary>
	public virtual void SetMasking(bool _arg)
	{
		vtkGlyph3DMapper_SetMasking_51(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetNumberOfLOD_52(HandleRef pThis, long arg0);

	/// <summary>
	/// Set the number of LOD.
	/// This method is intended to be reimplemented in inherited classes, current implementation
	/// does nothing.
	/// </summary>
	public virtual void SetNumberOfLOD(long arg0)
	{
		vtkGlyph3DMapper_SetNumberOfLOD_52(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetOrient_53(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off orienting of input geometry.
	/// When turned on, the orientation array specified
	/// using SetOrientationArray() will be used.
	/// </summary>
	public virtual void SetOrient(bool _arg)
	{
		vtkGlyph3DMapper_SetOrient_53(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetOrientationArray_54(HandleRef pThis, string orientationarrayname);

	/// <summary>
	/// Tells the mapper to use an orientation array if Orient is true.
	/// An orientation array is a vtkDataArray with 3 components. The first
	/// component is the angle of rotation along the X axis. The second
	/// component is the angle of rotation along the Y axis. The third
	/// component is the angle of rotation along the Z axis. Orientation is
	/// specified in X,Y,Z order but the rotations are performed in Z,X an Y.
	/// This definition is compliant with SetOrientation method on vtkProp3D.
	/// By using vector or normal there is a degree of freedom or rotation
	/// left (underconstrained). With the orientation array, there is no degree of
	/// freedom left.
	/// This is convenience method. The same effect can be achieved by using
	/// SetInputArrayToProcess(vtkGlyph3DMapper::ORIENTATION, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, orientationarrayname);
	/// </summary>
	public void SetOrientationArray(string orientationarrayname)
	{
		vtkGlyph3DMapper_SetOrientationArray_54(GetCppThis(), orientationarrayname);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetOrientationArray_55(HandleRef pThis, int fieldAttributeType);

	/// <summary>
	/// Tells the mapper to use an orientation array if Orient is true.
	/// An orientation array is a vtkDataArray with 3 components. The first
	/// component is the angle of rotation along the X axis. The second
	/// component is the angle of rotation along the Y axis. The third
	/// component is the angle of rotation along the Z axis. Orientation is
	/// specified in X,Y,Z order but the rotations are performed in Z,X an Y.
	/// This definition is compliant with SetOrientation method on vtkProp3D.
	/// By using vector or normal there is a degree of freedom or rotation
	/// left (underconstrained). With the orientation array, there is no degree of
	/// freedom left.
	/// \c fieldAttributeType is one of the following:
	/// \li vtkDataSetAttributes::SCALARS
	/// \li vtkDataSetAttributes::VECTORS
	/// \li vtkDataSetAttributes::NORMALS
	/// \li vtkDataSetAttributes::TCOORDS
	/// \li vtkDataSetAttributes::TENSORS
	/// This is convenience method. The same effect can be achieved by using
	/// SetInputArrayToProcess(vtkGlyph3DMapper::ORIENTATION, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType);
	/// </summary>
	public void SetOrientationArray(int fieldAttributeType)
	{
		vtkGlyph3DMapper_SetOrientationArray_55(GetCppThis(), fieldAttributeType);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetOrientationMode_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Orientation mode indicates if the OrientationArray provides the direction
	/// vector for the orientation or the rotations around each axes. Default is
	/// DIRECTION
	/// </summary>
	public virtual void SetOrientationMode(int _arg)
	{
		vtkGlyph3DMapper_SetOrientationMode_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetOrientationModeToDirection_57(HandleRef pThis);

	/// <summary>
	/// Orientation mode indicates if the OrientationArray provides the direction
	/// vector for the orientation or the rotations around each axes. Default is
	/// DIRECTION
	/// </summary>
	public void SetOrientationModeToDirection()
	{
		vtkGlyph3DMapper_SetOrientationModeToDirection_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetOrientationModeToQuaternion_58(HandleRef pThis);

	/// <summary>
	/// Orientation mode indicates if the OrientationArray provides the direction
	/// vector for the orientation or the rotations around each axes. Default is
	/// DIRECTION
	/// </summary>
	public void SetOrientationModeToQuaternion()
	{
		vtkGlyph3DMapper_SetOrientationModeToQuaternion_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetOrientationModeToRotation_59(HandleRef pThis);

	/// <summary>
	/// Orientation mode indicates if the OrientationArray provides the direction
	/// vector for the orientation or the rotations around each axes. Default is
	/// DIRECTION
	/// </summary>
	public void SetOrientationModeToRotation()
	{
		vtkGlyph3DMapper_SetOrientationModeToRotation_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetRange_60(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public virtual void SetRange(double _arg1, double _arg2)
	{
		vtkGlyph3DMapper_SetRange_60(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetRange_61(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify range to map scalar values into.
	/// </summary>
	public void SetRange(IntPtr _arg)
	{
		vtkGlyph3DMapper_SetRange_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetScaleArray_62(HandleRef pThis, string scalarsarrayname);

	/// <summary>
	/// Convenience method to set the array to scale with. This is same as calling
	/// SetInputArrayToProcess(vtkGlyph3DMapper::SCALE, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, scalarsarrayname).
	/// </summary>
	public void SetScaleArray(string scalarsarrayname)
	{
		vtkGlyph3DMapper_SetScaleArray_62(GetCppThis(), scalarsarrayname);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetScaleArray_63(HandleRef pThis, int fieldAttributeType);

	/// <summary>
	/// Convenience method to set the array to scale with. This is same as calling
	/// SetInputArrayToProcess(vtkGlyph3DMapper::SCALE, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType).
	/// </summary>
	public void SetScaleArray(int fieldAttributeType)
	{
		vtkGlyph3DMapper_SetScaleArray_63(GetCppThis(), fieldAttributeType);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetScaleFactor_64(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify scale factor to scale object by. This is used only when Scaling is
	/// On.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkGlyph3DMapper_SetScaleFactor_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetScaleMode_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Either scale by individual components (SCALE_BY_COMPONENTS) or magnitude
	/// (SCALE_BY_MAGNITUDE) of the chosen array to SCALE with or disable scaling
	/// using data array all together (NO_DATA_SCALING). Default is
	/// NO_DATA_SCALING.
	/// </summary>
	public virtual void SetScaleMode(int _arg)
	{
		vtkGlyph3DMapper_SetScaleMode_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetScaleModeToNoDataScaling_66(HandleRef pThis);

	/// <summary>
	/// Specify scale factor to scale object by. This is used only when Scaling is
	/// On.
	/// </summary>
	public void SetScaleModeToNoDataScaling()
	{
		vtkGlyph3DMapper_SetScaleModeToNoDataScaling_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetScaleModeToScaleByMagnitude_67(HandleRef pThis);

	/// <summary>
	/// Specify scale factor to scale object by. This is used only when Scaling is
	/// On.
	/// </summary>
	public void SetScaleModeToScaleByMagnitude()
	{
		vtkGlyph3DMapper_SetScaleModeToScaleByMagnitude_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetScaleModeToScaleByVectorComponents_68(HandleRef pThis);

	/// <summary>
	/// Specify scale factor to scale object by. This is used only when Scaling is
	/// On.
	/// </summary>
	public void SetScaleModeToScaleByVectorComponents()
	{
		vtkGlyph3DMapper_SetScaleModeToScaleByVectorComponents_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetScaling_69(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off scaling of source geometry. When turned on, ScaleFactor
	/// controls the scale applied. To scale with some data array, ScaleMode should
	/// be set accordingly.
	/// </summary>
	public virtual void SetScaling(bool _arg)
	{
		vtkGlyph3DMapper_SetScaling_69(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSelectionColorId_70(HandleRef pThis, uint _arg);

	/// <summary>
	/// For selection by color id mode (not for end-user, called by
	/// vtkGlyphSelectionRenderMode). 0 is reserved for miss. it has to
	/// start at 1. Initial value is 1.
	/// </summary>
	public virtual void SetSelectionColorId(uint _arg)
	{
		vtkGlyph3DMapper_SetSelectionColorId_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSelectionIdArray_71(HandleRef pThis, string selectionIdArrayName);

	/// <summary>
	/// Convenience method to set the array used for selection IDs. This is same
	/// as calling
	/// SetInputArrayToProcess(vtkGlyph3DMapper::SELECTIONID, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, selectionidarrayname).
	///
	/// If no selection id array is specified, the index of the glyph point is
	/// used.
	/// </summary>
	public void SetSelectionIdArray(string selectionIdArrayName)
	{
		vtkGlyph3DMapper_SetSelectionIdArray_71(GetCppThis(), selectionIdArrayName);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSelectionIdArray_72(HandleRef pThis, int fieldAttributeType);

	/// <summary>
	/// Convenience method to set the array used for selection IDs. This is same
	/// as calling
	/// SetInputArrayToProcess(vtkGlyph3DMapper::SELECTIONID, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType).
	///
	/// If no selection id array is specified, the index of the glyph point is
	/// used.
	/// </summary>
	public void SetSelectionIdArray(int fieldAttributeType)
	{
		vtkGlyph3DMapper_SetSelectionIdArray_72(GetCppThis(), fieldAttributeType);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSourceConnection_73(HandleRef pThis, int idx, HandleRef algOutput);

	/// <summary>
	/// Specify a source object at a specified table location. New style.
	/// Source connection is stored in port 1. This method is equivalent
	/// to SetInputConnection(1, id, outputPort).
	/// </summary>
	public void SetSourceConnection(int idx, vtkAlgorithmOutput algOutput)
	{
		vtkGlyph3DMapper_SetSourceConnection_73(GetCppThis(), idx, algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSourceConnection_74(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify a source object at a specified table location. New style.
	/// Source connection is stored in port 1. This method is equivalent
	/// to SetInputConnection(1, id, outputPort).
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkGlyph3DMapper_SetSourceConnection_74(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSourceData_75(HandleRef pThis, int idx, HandleRef pd);

	/// <summary>
	/// Specify a source object at a specified table location.
	/// </summary>
	public void SetSourceData(int idx, vtkPolyData pd)
	{
		vtkGlyph3DMapper_SetSourceData_75(GetCppThis(), idx, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSourceData_76(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Set the source to use for he glyph.
	/// Note that this method does not connect the pipeline. The algorithm will
	/// work on the input data as it is without updating the producer of the data.
	/// See SetSourceConnection for connecting the pipeline.
	/// </summary>
	public void SetSourceData(vtkPolyData pd)
	{
		vtkGlyph3DMapper_SetSourceData_76(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSourceIndexArray_77(HandleRef pThis, string arrayname);

	/// <summary>
	/// Convenience method to set the array to use as index within the sources.
	/// This is same as calling
	/// SetInputArrayToProcess(vtkGlyph3DMapper::SOURCE_INDEX, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, arrayname).
	/// </summary>
	public void SetSourceIndexArray(string arrayname)
	{
		vtkGlyph3DMapper_SetSourceIndexArray_77(GetCppThis(), arrayname);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSourceIndexArray_78(HandleRef pThis, int fieldAttributeType);

	/// <summary>
	/// Convenience method to set the array to use as index within the sources.
	/// This is same as calling
	/// SetInputArrayToProcess(vtkGlyph3DMapper::SOURCE_INDEX, 0, 0,
	/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType).
	/// </summary>
	public void SetSourceIndexArray(int fieldAttributeType)
	{
		vtkGlyph3DMapper_SetSourceIndexArray_78(GetCppThis(), fieldAttributeType);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSourceIndexing_79(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable indexing into table of the glyph sources. When disabled,
	/// only the 1st source input will be used to generate the glyph. Otherwise the
	/// source index array will be used to select the glyph source. The source
	/// index array can be specified using SetSourceIndexArray().
	/// </summary>
	public virtual void SetSourceIndexing(bool _arg)
	{
		vtkGlyph3DMapper_SetSourceIndexing_79(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetSourceTableTree_80(HandleRef pThis, HandleRef tree);

	/// <summary>
	/// Specify a data object tree that will be used for the source table. Requires
	/// UseSourceTableTree to be true. The top-level nodes of the tree are mapped
	/// to the source data inputs.
	///
	/// Must only contain vtkPolyData instances on the OpenGL backend. May contain
	/// vtkCompositeDataSets with vtkPolyData leaves on OpenGL2.
	/// </summary>
	public void SetSourceTableTree(vtkDataObjectTree tree)
	{
		vtkGlyph3DMapper_SetSourceTableTree_80(GetCppThis(), tree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetUseSelectionIds_81(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off custom selection ids. If enabled, the id values set with
	/// SetSelectionIdArray are returned from pick events.
	/// </summary>
	public virtual void SetUseSelectionIds(bool _arg)
	{
		vtkGlyph3DMapper_SetUseSelectionIds_81(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SetUseSourceTableTree_82(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, and the glyph source dataset is a subclass of vtkDataObjectTree,
	/// the top-level members of the tree will be mapped to the glyph source table
	/// used for SourceIndexing.
	/// </summary>
	public virtual void SetUseSourceTableTree(bool _arg)
	{
		vtkGlyph3DMapper_SetUseSourceTableTree_82(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SourceIndexingOff_83(HandleRef pThis);

	/// <summary>
	/// Enable/disable indexing into table of the glyph sources. When disabled,
	/// only the 1st source input will be used to generate the glyph. Otherwise the
	/// source index array will be used to select the glyph source. The source
	/// index array can be specified using SetSourceIndexArray().
	/// </summary>
	public virtual void SourceIndexingOff()
	{
		vtkGlyph3DMapper_SourceIndexingOff_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_SourceIndexingOn_84(HandleRef pThis);

	/// <summary>
	/// Enable/disable indexing into table of the glyph sources. When disabled,
	/// only the 1st source input will be used to generate the glyph. Otherwise the
	/// source index array will be used to select the glyph source. The source
	/// index array can be specified using SetSourceIndexArray().
	/// </summary>
	public virtual void SourceIndexingOn()
	{
		vtkGlyph3DMapper_SourceIndexingOn_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_UseSelectionIdsOff_85(HandleRef pThis);

	/// <summary>
	/// Turn on/off custom selection ids. If enabled, the id values set with
	/// SetSelectionIdArray are returned from pick events.
	/// </summary>
	public virtual void UseSelectionIdsOff()
	{
		vtkGlyph3DMapper_UseSelectionIdsOff_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_UseSelectionIdsOn_86(HandleRef pThis);

	/// <summary>
	/// Turn on/off custom selection ids. If enabled, the id values set with
	/// SetSelectionIdArray are returned from pick events.
	/// </summary>
	public virtual void UseSelectionIdsOn()
	{
		vtkGlyph3DMapper_UseSelectionIdsOn_86(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_UseSourceTableTreeOff_87(HandleRef pThis);

	/// <summary>
	/// If true, and the glyph source dataset is a subclass of vtkDataObjectTree,
	/// the top-level members of the tree will be mapped to the glyph source table
	/// used for SourceIndexing.
	/// </summary>
	public virtual void UseSourceTableTreeOff()
	{
		vtkGlyph3DMapper_UseSourceTableTreeOff_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyph3DMapper_UseSourceTableTreeOn_88(HandleRef pThis);

	/// <summary>
	/// If true, and the glyph source dataset is a subclass of vtkDataObjectTree,
	/// the top-level members of the tree will be mapped to the glyph source table
	/// used for SourceIndexing.
	/// </summary>
	public virtual void UseSourceTableTreeOn()
	{
		vtkGlyph3DMapper_UseSourceTableTreeOn_88(GetCppThis());
	}
}
