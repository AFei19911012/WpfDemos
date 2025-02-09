using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLPolyDataMapper
/// </summary>
/// <remarks>
///    PolyDataMapper using OpenGL to render.
///
/// PolyDataMapper that uses a OpenGL to do the actual rendering.
/// </remarks>
public class vtkOpenGLPolyDataMapper : vtkPolyDataMapper
{
	/// <summary>
	/// Allow the shader code to set the point size (with gl_PointSize variable)
	/// instead of using the one defined by the property. Note that this flag is
	/// not available on OpenGLES as the feature is enabled by default. With
	/// OpenGL, the feature is turned off by default.
	/// Warning: on MacOS, enabling the feature result in non point drawing
	/// if the shaders do not set the point size.
	/// </summary>
	public enum PrimitiveTypes
	{
		/// <summary>enum member</summary>
		PrimitiveEnd = 5,
		/// <summary>enum member</summary>
		PrimitiveLines = 1,
		/// <summary>enum member</summary>
		PrimitivePoints = 0,
		/// <summary>enum member</summary>
		PrimitiveStart = 0,
		/// <summary>enum member</summary>
		PrimitiveTriStrips = 3,
		/// <summary>enum member</summary>
		PrimitiveTris = 2,
		/// <summary>enum member</summary>
		PrimitiveVertices = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLPolyDataMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLPolyDataMapper()
	{
		MRClassNameKey = "class vtkOpenGLPolyDataMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLPolyDataMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLPolyDataMapper New()
	{
		vtkOpenGLPolyDataMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLPolyDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLPolyDataMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLPolyDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLPolyDataMapper_GetCellIdArrayName_01(HandleRef pThis);

	/// <summary>
	/// By default, this class uses the dataset's point and cell ids during
	/// rendering. However, one can override those by specifying cell and point
	/// data arrays to use instead. Currently, only vtkIdType array is supported.
	/// Set to NULL string (default) to use the point ids instead.
	/// </summary>
	public virtual string GetCellIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkOpenGLPolyDataMapper_GetCellIdArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLPolyDataMapper_GetCompositeIdArrayName_02(HandleRef pThis);

	/// <summary>
	/// Generally, this class can render the composite id when iterating
	/// over composite datasets. However in some cases (as in AMR), the rendered
	/// structure may not correspond to the input data, in which case we need
	/// to provide a cell array that can be used to render in the composite id in
	/// selection passes. Set to NULL (default) to not override the composite id
	/// color set by vtkCompositePainter if any.
	/// The array *MUST* be a cell array and of type vtkUnsignedIntArray.
	/// </summary>
	public virtual string GetCompositeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkOpenGLPolyDataMapper_GetCompositeIdArrayName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLPolyDataMapper_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLPolyDataMapper_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLPolyDataMapper_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLPolyDataMapper_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLPolyDataMapper_GetPauseShiftScale_05(HandleRef pThis);

	/// <summary>
	///
	/// For large datasets, re-uploading the VBO during user interaction
	/// can cause stutters in the framerate. Interactors can use this
	/// method to force UpdateCameraShiftScale to return immediately
	/// (without changes) while users are zooming/rotating/etc. and then
	/// re-enable shift-scale just before a still render.
	///
	/// This setting has no effect unless the shift-scale method is set
	/// to NEAR_PLANE_SHIFT_SCALE or FOCAL_POINT_SHIFT_SCALE.
	///
	/// Changing this setting does **not** mark the mapper as modified as
	/// that would force a VBO upload – defeating its own purpose.
	/// </summary>
	public virtual bool GetPauseShiftScale()
	{
		return (vtkOpenGLPolyDataMapper_GetPauseShiftScale_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLPolyDataMapper_GetPointIdArrayName_06(HandleRef pThis);

	/// <summary>
	/// By default, this class uses the dataset's point and cell ids during
	/// rendering. However, one can override those by specifying cell and point
	/// data arrays to use instead. Currently, only vtkIdType array is supported.
	/// Set to NULL string (default) to use the point ids instead.
	/// </summary>
	public virtual string GetPointIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkOpenGLPolyDataMapper_GetPointIdArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLPolyDataMapper_GetPopulateSelectionSettings_07(HandleRef pThis);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual int GetPopulateSelectionSettings()
	{
		return vtkOpenGLPolyDataMapper_GetPopulateSelectionSettings_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLPolyDataMapper_GetProcessIdArrayName_08(HandleRef pThis);

	/// <summary>
	/// If this class should override the process id using a data-array,
	/// set this variable to the name of the array to use. It must be a
	/// point-array.
	/// </summary>
	public virtual string GetProcessIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkOpenGLPolyDataMapper_GetProcessIdArrayName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLPolyDataMapper_GetSupportsSelection_09(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Used by vtkHardwareSelector to determine if the prop supports hardware
	/// selection.
	/// </summary>
	public override bool GetSupportsSelection()
	{
		return (vtkOpenGLPolyDataMapper_GetSupportsSelection_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLPolyDataMapper_GetUseProgramPointSize_10(HandleRef pThis);

	/// <summary>
	/// Allow the shader code to set the point size (with gl_PointSize variable)
	/// instead of using the one defined by the property. Note that this flag is
	/// not available on OpenGLES as the feature is enabled by default. With
	/// OpenGL, the feature is turned off by default.
	/// Warning: on MacOS, enabling the feature result in non point drawing
	/// if the shaders do not set the point size.
	/// </summary>
	public virtual bool GetUseProgramPointSize()
	{
		return (vtkOpenGLPolyDataMapper_GetUseProgramPointSize_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLPolyDataMapper_GetVBOShiftScaleMethod_11(HandleRef pThis);

	/// <summary>
	///   the VBO's shift+scale transform.
	/// </summary>
	public virtual int GetVBOShiftScaleMethod()
	{
		return vtkOpenGLPolyDataMapper_GetVBOShiftScaleMethod_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLPolyDataMapper_GetVBOs_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make a shallow copy of this mapper.
	/// </summary>
	public virtual vtkOpenGLVertexBufferObjectGroup GetVBOs()
	{
		vtkOpenGLVertexBufferObjectGroup vtkOpenGLVertexBufferObjectGroup2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLPolyDataMapper_GetVBOs_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLVertexBufferObjectGroup2 = (vtkOpenGLVertexBufferObjectGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLVertexBufferObjectGroup2.Register(null);
			}
		}
		return vtkOpenGLVertexBufferObjectGroup2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLPolyDataMapper_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLPolyDataMapper_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLPolyDataMapper_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLPolyDataMapper_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_MapDataArrayToMultiTextureAttribute_15(HandleRef pThis, string tname, string dataArrayName, int fieldAssociation, int componentno);

	/// <summary>
	/// Select a data array from the point/cell data
	/// and map it to a generic vertex attribute.
	/// vertexAttributeName is the name of the vertex attribute.
	/// dataArrayName is the name of the data array.
	/// fieldAssociation indicates when the data array is a point data array or
	/// cell data array (vtkDataObject::FIELD_ASSOCIATION_POINTS or
	/// (vtkDataObject::FIELD_ASSOCIATION_CELLS).
	/// componentno indicates which component from the data array must be passed as
	/// the attribute. If -1, then all components are passed.
	/// </summary>
	public override void MapDataArrayToMultiTextureAttribute(string tname, string dataArrayName, int fieldAssociation, int componentno)
	{
		vtkOpenGLPolyDataMapper_MapDataArrayToMultiTextureAttribute_15(GetCppThis(), tname, dataArrayName, fieldAssociation, componentno);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_MapDataArrayToVertexAttribute_16(HandleRef pThis, string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno);

	/// <summary>
	/// Select a data array from the point/cell data
	/// and map it to a generic vertex attribute.
	/// vertexAttributeName is the name of the vertex attribute.
	/// dataArrayName is the name of the data array.
	/// fieldAssociation indicates when the data array is a point data array or
	/// cell data array (vtkDataObject::FIELD_ASSOCIATION_POINTS or
	/// (vtkDataObject::FIELD_ASSOCIATION_CELLS).
	/// componentno indicates which component from the data array must be passed as
	/// the attribute. If -1, then all components are passed.
	/// </summary>
	public override void MapDataArrayToVertexAttribute(string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno)
	{
		vtkOpenGLPolyDataMapper_MapDataArrayToVertexAttribute_16(GetCppThis(), vertexAttributeName, dataArrayName, fieldAssociation, componentno);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLPolyDataMapper_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLPolyDataMapper NewInstance()
	{
		vtkOpenGLPolyDataMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLPolyDataMapper_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_PauseShiftScaleOff_19(HandleRef pThis);

	/// <summary>
	///
	/// For large datasets, re-uploading the VBO during user interaction
	/// can cause stutters in the framerate. Interactors can use this
	/// method to force UpdateCameraShiftScale to return immediately
	/// (without changes) while users are zooming/rotating/etc. and then
	/// re-enable shift-scale just before a still render.
	///
	/// This setting has no effect unless the shift-scale method is set
	/// to NEAR_PLANE_SHIFT_SCALE or FOCAL_POINT_SHIFT_SCALE.
	///
	/// Changing this setting does **not** mark the mapper as modified as
	/// that would force a VBO upload – defeating its own purpose.
	/// </summary>
	public virtual void PauseShiftScaleOff()
	{
		vtkOpenGLPolyDataMapper_PauseShiftScaleOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_PauseShiftScaleOn_20(HandleRef pThis);

	/// <summary>
	///
	/// For large datasets, re-uploading the VBO during user interaction
	/// can cause stutters in the framerate. Interactors can use this
	/// method to force UpdateCameraShiftScale to return immediately
	/// (without changes) while users are zooming/rotating/etc. and then
	/// re-enable shift-scale just before a still render.
	///
	/// This setting has no effect unless the shift-scale method is set
	/// to NEAR_PLANE_SHIFT_SCALE or FOCAL_POINT_SHIFT_SCALE.
	///
	/// Changing this setting does **not** mark the mapper as modified as
	/// that would force a VBO upload – defeating its own purpose.
	/// </summary>
	public virtual void PauseShiftScaleOn()
	{
		vtkOpenGLPolyDataMapper_PauseShiftScaleOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkOpenGLPolyDataMapper_ReleaseGraphicsResources_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_RemoveAllVertexAttributeMappings_22(HandleRef pThis);

	/// <summary>
	/// Remove all vertex attributes.
	/// </summary>
	public override void RemoveAllVertexAttributeMappings()
	{
		vtkOpenGLPolyDataMapper_RemoveAllVertexAttributeMappings_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_RemoveVertexAttributeMapping_23(HandleRef pThis, string vertexAttributeName);

	/// <summary>
	/// Remove a vertex attribute mapping.
	/// </summary>
	public override void RemoveVertexAttributeMapping(string vertexAttributeName)
	{
		vtkOpenGLPolyDataMapper_RemoveVertexAttributeMapping_23(GetCppThis(), vertexAttributeName);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_RenderPiece_24(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// Implemented by sub classes. Actual rendering is done here.
	/// </summary>
	public override void RenderPiece(vtkRenderer ren, vtkActor act)
	{
		vtkOpenGLPolyDataMapper_RenderPiece_24(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_RenderPieceDraw_25(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// Implemented by sub classes. Actual rendering is done here.
	/// </summary>
	public virtual void RenderPieceDraw(vtkRenderer ren, vtkActor act)
	{
		vtkOpenGLPolyDataMapper_RenderPieceDraw_25(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_RenderPieceFinish_26(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// Implemented by sub classes. Actual rendering is done here.
	/// </summary>
	public virtual void RenderPieceFinish(vtkRenderer ren, vtkActor act)
	{
		vtkOpenGLPolyDataMapper_RenderPieceFinish_26(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_RenderPieceStart_27(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// Implemented by sub classes. Actual rendering is done here.
	/// </summary>
	public virtual void RenderPieceStart(vtkRenderer ren, vtkActor act)
	{
		vtkOpenGLPolyDataMapper_RenderPieceStart_27(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLPolyDataMapper_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLPolyDataMapper SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLPolyDataMapper vtkOpenGLPolyDataMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLPolyDataMapper_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLPolyDataMapper2 = (vtkOpenGLPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLPolyDataMapper2.Register(null);
			}
		}
		return vtkOpenGLPolyDataMapper2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_SetCellIdArrayName_29(HandleRef pThis, string _arg);

	/// <summary>
	/// By default, this class uses the dataset's point and cell ids during
	/// rendering. However, one can override those by specifying cell and point
	/// data arrays to use instead. Currently, only vtkIdType array is supported.
	/// Set to NULL string (default) to use the point ids instead.
	/// </summary>
	public virtual void SetCellIdArrayName(string _arg)
	{
		vtkOpenGLPolyDataMapper_SetCellIdArrayName_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_SetCompositeIdArrayName_30(HandleRef pThis, string _arg);

	/// <summary>
	/// Generally, this class can render the composite id when iterating
	/// over composite datasets. However in some cases (as in AMR), the rendered
	/// structure may not correspond to the input data, in which case we need
	/// to provide a cell array that can be used to render in the composite id in
	/// selection passes. Set to NULL (default) to not override the composite id
	/// color set by vtkCompositePainter if any.
	/// The array *MUST* be a cell array and of type vtkUnsignedIntArray.
	/// </summary>
	public virtual void SetCompositeIdArrayName(string _arg)
	{
		vtkOpenGLPolyDataMapper_SetCompositeIdArrayName_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_SetPauseShiftScale_31(HandleRef pThis, byte pauseShiftScale);

	/// <summary>
	///
	/// For large datasets, re-uploading the VBO during user interaction
	/// can cause stutters in the framerate. Interactors can use this
	/// method to force UpdateCameraShiftScale to return immediately
	/// (without changes) while users are zooming/rotating/etc. and then
	/// re-enable shift-scale just before a still render.
	///
	/// This setting has no effect unless the shift-scale method is set
	/// to NEAR_PLANE_SHIFT_SCALE or FOCAL_POINT_SHIFT_SCALE.
	///
	/// Changing this setting does **not** mark the mapper as modified as
	/// that would force a VBO upload – defeating its own purpose.
	/// </summary>
	public virtual void SetPauseShiftScale(bool pauseShiftScale)
	{
		vtkOpenGLPolyDataMapper_SetPauseShiftScale_31(GetCppThis(), (byte)(pauseShiftScale ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_SetPointIdArrayName_32(HandleRef pThis, string _arg);

	/// <summary>
	/// By default, this class uses the dataset's point and cell ids during
	/// rendering. However, one can override those by specifying cell and point
	/// data arrays to use instead. Currently, only vtkIdType array is supported.
	/// Set to NULL string (default) to use the point ids instead.
	/// </summary>
	public virtual void SetPointIdArrayName(string _arg)
	{
		vtkOpenGLPolyDataMapper_SetPointIdArrayName_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_SetPopulateSelectionSettings_33(HandleRef pThis, int v);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public void SetPopulateSelectionSettings(int v)
	{
		vtkOpenGLPolyDataMapper_SetPopulateSelectionSettings_33(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_SetProcessIdArrayName_34(HandleRef pThis, string _arg);

	/// <summary>
	/// If this class should override the process id using a data-array,
	/// set this variable to the name of the array to use. It must be a
	/// point-array.
	/// </summary>
	public virtual void SetProcessIdArrayName(string _arg)
	{
		vtkOpenGLPolyDataMapper_SetProcessIdArrayName_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_SetUseProgramPointSize_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Allow the shader code to set the point size (with gl_PointSize variable)
	/// instead of using the one defined by the property. Note that this flag is
	/// not available on OpenGLES as the feature is enabled by default. With
	/// OpenGL, the feature is turned off by default.
	/// Warning: on MacOS, enabling the feature result in non point drawing
	/// if the shaders do not set the point size.
	/// </summary>
	public virtual void SetUseProgramPointSize(bool _arg)
	{
		vtkOpenGLPolyDataMapper_SetUseProgramPointSize_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_SetVBOShiftScaleMethod_36(HandleRef pThis, int m);

	/// <summary>
	///   the VBO's shift+scale transform.
	/// </summary>
	public virtual void SetVBOShiftScaleMethod(int m)
	{
		vtkOpenGLPolyDataMapper_SetVBOShiftScaleMethod_36(GetCppThis(), m);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_ShallowCopy_37(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Make a shallow copy of this mapper.
	/// </summary>
	public override void ShallowCopy(vtkAbstractMapper m)
	{
		vtkOpenGLPolyDataMapper_ShallowCopy_37(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_UseProgramPointSizeOff_38(HandleRef pThis);

	/// <summary>
	/// Allow the shader code to set the point size (with gl_PointSize variable)
	/// instead of using the one defined by the property. Note that this flag is
	/// not available on OpenGLES as the feature is enabled by default. With
	/// OpenGL, the feature is turned off by default.
	/// Warning: on MacOS, enabling the feature result in non point drawing
	/// if the shaders do not set the point size.
	/// </summary>
	public virtual void UseProgramPointSizeOff()
	{
		vtkOpenGLPolyDataMapper_UseProgramPointSizeOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLPolyDataMapper_UseProgramPointSizeOn_39(HandleRef pThis);

	/// <summary>
	/// Allow the shader code to set the point size (with gl_PointSize variable)
	/// instead of using the one defined by the property. Note that this flag is
	/// not available on OpenGLES as the feature is enabled by default. With
	/// OpenGL, the feature is turned off by default.
	/// Warning: on MacOS, enabling the feature result in non point drawing
	/// if the shaders do not set the point size.
	/// </summary>
	public virtual void UseProgramPointSizeOn()
	{
		vtkOpenGLPolyDataMapper_UseProgramPointSizeOn_39(GetCppThis());
	}
}
