using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// Struct used to return information about a pixel location.
/// </summary>
public abstract class vtkHardwareSelector : vtkObject
{
	/// <summary>
	/// returns the prop associated with a ID. This is valid only until
	/// ReleasePixBuffers() gets called.
	/// </summary>
	public enum PassTypes
	{
		/// <summary>enum member</summary>
		ACTOR_PASS = 0,
		/// <summary>enum member</summary>
		CELL_ID_HIGH24 = 6,
		/// <summary>enum member</summary>
		CELL_ID_LOW24 = 5,
		/// <summary>enum member</summary>
		COMPOSITE_INDEX_PASS = 1,
		/// <summary>enum member</summary>
		MAX_KNOWN_PASS = 6,
		/// <summary>enum member</summary>
		MIN_KNOWN_PASS = 0,
		/// <summary>enum member</summary>
		POINT_ID_HIGH24 = 3,
		/// <summary>enum member</summary>
		POINT_ID_LOW24 = 2,
		/// <summary>enum member</summary>
		PROCESS_PASS = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHardwareSelector";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHardwareSelector()
	{
		MRClassNameKey = "class vtkHardwareSelector";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHardwareSelector"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHardwareSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Struct used to return information about a pixel location.
	/// </summary>
	public new static vtkHardwareSelector New()
	{
		vtkHardwareSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Struct used to return information about a pixel location.
	/// </summary>
	public vtkHardwareSelector()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHardwareSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkHardwareSelector_BeginRenderProp_01(HandleRef pThis);

	/// <summary>
	/// Called by the mapper before and after rendering each prop.
	/// </summary>
	public virtual void BeginRenderProp()
	{
		vtkHardwareSelector_BeginRenderProp_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHardwareSelector_CaptureBuffers_02(HandleRef pThis);

	/// <summary>
	/// It is possible to use the vtkHardwareSelector for a custom picking. (Look
	/// at vtkScenePicker). In that case instead of Select() on can use
	/// CaptureBuffers() to render the selection buffers and then get information
	/// about pixel locations suing GetPixelInformation(). Use ClearBuffers() to
	/// clear buffers after one's done with the scene.
	/// The optional final parameter maxDist will look for a cell within the specified
	/// number of pixels from display_position. When using the overload with the
	/// optional \c selected_position argument, selected_position is filled with
	/// the position for which the PixelInformation is being returned. This is
	/// useful when maxDist &gt; 0 to determine which position's pixel information is
	/// was returned.
	/// </summary>
	public virtual bool CaptureBuffers()
	{
		return (vtkHardwareSelector_CaptureBuffers_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_ClearBuffers_03(HandleRef pThis);

	/// <summary>
	/// It is possible to use the vtkHardwareSelector for a custom picking. (Look
	/// at vtkScenePicker). In that case instead of Select() on can use
	/// CaptureBuffers() to render the selection buffers and then get information
	/// about pixel locations suing GetPixelInformation(). Use ClearBuffers() to
	/// clear buffers after one's done with the scene.
	/// The optional final parameter maxDist will look for a cell within the specified
	/// number of pixels from display_position. When using the overload with the
	/// optional \c selected_position argument, selected_position is filled with
	/// the position for which the PixelInformation is being returned. This is
	/// useful when maxDist &gt; 0 to determine which position's pixel information is
	/// was returned.
	/// </summary>
	public void ClearBuffers()
	{
		vtkHardwareSelector_ClearBuffers_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_Convert_04(long id, IntPtr tcoord);

	/// <summary>
	/// Convert a PassTypes enum value to a human readable string.
	/// </summary>
	public static void Convert(long id, IntPtr tcoord)
	{
		vtkHardwareSelector_Convert_04(id, tcoord);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_EndRenderProp_05(HandleRef pThis);

	/// <summary>
	/// Called by the mapper before and after rendering each prop.
	/// </summary>
	public virtual void EndRenderProp()
	{
		vtkHardwareSelector_EndRenderProp_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GeneratePolygonSelection_06(HandleRef pThis, IntPtr polygonPoints, long count, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Generates the vtkSelection from pixel buffers.
	/// Same as GenerateSelection, except this one use a polygon, instead
	/// of a rectangle region, and select elements inside the polygon.
	/// NOTE: The CaptureBuffers() needs to be called first.
	/// </summary>
	public virtual vtkSelection GeneratePolygonSelection(IntPtr polygonPoints, long count)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_GeneratePolygonSelection_06(GetCppThis(), polygonPoints, count, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GenerateSelection_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Generates the vtkSelection from pixel buffers.
	/// Requires that CaptureBuffers() has already been called.
	/// Optionally you may pass a screen region (xmin, ymin, xmax, ymax)
	/// to generate a selection from. The region must be a subregion
	/// of the region specified by SetArea(), otherwise it will be
	/// clipped to that region.
	/// </summary>
	public virtual vtkSelection GenerateSelection()
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_GenerateSelection_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GenerateSelection_08(HandleRef pThis, IntPtr r, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Generates the vtkSelection from pixel buffers.
	/// Requires that CaptureBuffers() has already been called.
	/// Optionally you may pass a screen region (xmin, ymin, xmax, ymax)
	/// to generate a selection from. The region must be a subregion
	/// of the region specified by SetArea(), otherwise it will be
	/// clipped to that region.
	/// </summary>
	public virtual vtkSelection GenerateSelection(IntPtr r)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_GenerateSelection_08(GetCppThis(), r, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GenerateSelection_09(HandleRef pThis, uint x1, uint y1, uint x2, uint y2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Generates the vtkSelection from pixel buffers.
	/// Requires that CaptureBuffers() has already been called.
	/// Optionally you may pass a screen region (xmin, ymin, xmax, ymax)
	/// to generate a selection from. The region must be a subregion
	/// of the region specified by SetArea(), otherwise it will be
	/// clipped to that region.
	/// </summary>
	public virtual vtkSelection GenerateSelection(uint x1, uint y1, uint x2, uint y2)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_GenerateSelection_09(GetCppThis(), x1, y1, x2, y2, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHardwareSelector_GetActorPassOnly_10(HandleRef pThis);

	/// <summary>
	/// Get/Set to only do the actor pass. If true all other passes will be
	/// skipped resulting in a faster pick.
	/// </summary>
	public virtual bool GetActorPassOnly()
	{
		return (vtkHardwareSelector_GetActorPassOnly_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GetArea_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
	/// </summary>
	public virtual uint[] GetArea()
	{
		IntPtr intPtr = vtkHardwareSelector_GetArea_11(GetCppThis());
		uint[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new uint[4];
			int[] array2 = new int[4];
			Marshal.Copy(intPtr, array2, 0, array.Length);
			for (int i = 0; i < 4; i++)
			{
				array[i] = (uint)array2[i];
			}
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_GetArea_12(HandleRef pThis, ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4);

	/// <summary>
	/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
	/// </summary>
	public virtual void GetArea(ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4)
	{
		vtkHardwareSelector_GetArea_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_GetArea_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
	/// </summary>
	public virtual void GetArea(IntPtr _arg)
	{
		vtkHardwareSelector_GetArea_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHardwareSelector_GetCaptureZValues_14(HandleRef pThis);

	/// <summary>
	/// Get/Set to capture the zvalue. If true the closest zvalue is
	/// stored for each prop that is in the selection. ZValue in this
	/// case is the value from the zbuffer which can be used in
	/// coordinate conversions
	/// </summary>
	public virtual bool GetCaptureZValues()
	{
		return (vtkHardwareSelector_GetCaptureZValues_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwareSelector_GetCurrentPass_15(HandleRef pThis);

	/// <summary>
	/// Get the current pass number.
	/// </summary>
	public virtual int GetCurrentPass()
	{
		return vtkHardwareSelector_GetCurrentPass_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwareSelector_GetFieldAssociation_16(HandleRef pThis);

	/// <summary>
	/// Set the field type to select. Valid values are
	/// \li vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// \li vtkDataObject::FIELD_ASSOCIATION_CELLS
	/// \li vtkDataObject::FIELD_ASSOCIATION_VERTICES
	/// \li vtkDataObject::FIELD_ASSOCIATION_EDGES
	/// \li vtkDataObject::FIELD_ASSOCIATION_ROWS
	/// Currently only FIELD_ASSOCIATION_POINTS and FIELD_ASSOCIATION_CELLS are
	/// supported.
	/// </summary>
	public virtual int GetFieldAssociation()
	{
		return vtkHardwareSelector_GetFieldAssociation_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHardwareSelector_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	/// Struct used to return information about a pixel location.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHardwareSelector_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHardwareSelector_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	/// Struct used to return information about a pixel location.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHardwareSelector_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GetPixelBuffer_19(HandleRef pThis, int passNo);

	/// <summary>
	/// It is possible to use the vtkHardwareSelector for a custom picking. (Look
	/// at vtkScenePicker). In that case instead of Select() on can use
	/// CaptureBuffers() to render the selection buffers and then get information
	/// about pixel locations suing GetPixelInformation(). Use ClearBuffers() to
	/// clear buffers after one's done with the scene.
	/// The optional final parameter maxDist will look for a cell within the specified
	/// number of pixels from display_position. When using the overload with the
	/// optional \c selected_position argument, selected_position is filled with
	/// the position for which the PixelInformation is being returned. This is
	/// useful when maxDist &gt; 0 to determine which position's pixel information is
	/// was returned.
	/// </summary>
	public IntPtr GetPixelBuffer(int passNo)
	{
		return vtkHardwareSelector_GetPixelBuffer_19(GetCppThis(), passNo);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwareSelector_GetProcessID_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the process id. If process id &lt; 0 (default -1), then the
	/// PROCESS_PASS is not rendered.
	/// </summary>
	public virtual int GetProcessID()
	{
		return vtkHardwareSelector_GetProcessID_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GetPropColorValue_21(HandleRef pThis);

	/// <summary>
	/// Get/Set the color to be used by the prop when drawing
	/// </summary>
	public virtual float[] GetPropColorValue()
	{
		IntPtr intPtr = vtkHardwareSelector_GetPropColorValue_21(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_GetPropColorValue_22(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3);

	/// <summary>
	/// Get/Set the color to be used by the prop when drawing
	/// </summary>
	public virtual void GetPropColorValue(ref float _arg1, ref float _arg2, ref float _arg3)
	{
		vtkHardwareSelector_GetPropColorValue_22(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_GetPropColorValue_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the color to be used by the prop when drawing
	/// </summary>
	public virtual void GetPropColorValue(IntPtr _arg)
	{
		vtkHardwareSelector_GetPropColorValue_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GetPropFromID_24(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// returns the prop associated with a ID. This is valid only until
	/// ReleasePixBuffers() gets called.
	/// </summary>
	public vtkProp GetPropFromID(int id)
	{
		vtkProp vtkProp2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_GetPropFromID_24(GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp2 = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp2.Register(null);
			}
		}
		return vtkProp2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GetRawPixelBuffer_25(HandleRef pThis, int passNo);

	/// <summary>
	/// It is possible to use the vtkHardwareSelector for a custom picking. (Look
	/// at vtkScenePicker). In that case instead of Select() on can use
	/// CaptureBuffers() to render the selection buffers and then get information
	/// about pixel locations suing GetPixelInformation(). Use ClearBuffers() to
	/// clear buffers after one's done with the scene.
	/// The optional final parameter maxDist will look for a cell within the specified
	/// number of pixels from display_position. When using the overload with the
	/// optional \c selected_position argument, selected_position is filled with
	/// the position for which the PixelInformation is being returned. This is
	/// useful when maxDist &gt; 0 to determine which position's pixel information is
	/// was returned.
	/// </summary>
	public IntPtr GetRawPixelBuffer(int passNo)
	{
		return vtkHardwareSelector_GetRawPixelBuffer_25(GetCppThis(), passNo);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_GetRenderer_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the renderer to perform the selection on.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_GetRenderer_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHardwareSelector_GetUseProcessIdFromData_27(HandleRef pThis);

	/// <summary>
	/// In some parallel rendering setups, the process id for elements must be
	/// obtained from the data itself, rather than the rendering process' id. In
	/// that case, set this flag to ON (default OFF).
	/// </summary>
	public virtual bool GetUseProcessIdFromData()
	{
		return (vtkHardwareSelector_GetUseProcessIdFromData_27(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHardwareSelector_HasHighCellIds_28(HandleRef pThis);

	/// <summary>
	/// Convert a PassTypes enum value to a human readable string.
	/// </summary>
	public bool HasHighCellIds()
	{
		return (vtkHardwareSelector_HasHighCellIds_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHardwareSelector_HasHighPointIds_29(HandleRef pThis);

	/// <summary>
	/// Convert a PassTypes enum value to a human readable string.
	/// </summary>
	public bool HasHighPointIds()
	{
		return (vtkHardwareSelector_HasHighPointIds_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwareSelector_IsA_30(HandleRef pThis, string type);

	/// <summary>
	/// Struct used to return information about a pixel location.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHardwareSelector_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHardwareSelector_IsTypeOf_31(string type);

	/// <summary>
	/// Struct used to return information about a pixel location.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHardwareSelector_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Struct used to return information about a pixel location.
	/// </summary>
	public new vtkHardwareSelector NewInstance()
	{
		vtkHardwareSelector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkHardwareSelector_PassTypeToString_34(HandleRef pThis, PassTypes type);

	/// <summary>
	/// Convert a PassTypes enum value to a human readable string.
	/// </summary>
	public string PassTypeToString(PassTypes type)
	{
		return vtkHardwareSelector_PassTypeToString_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_RenderCompositeIndex_35(HandleRef pThis, uint index);

	/// <summary>
	/// Called by any vtkMapper or vtkProp subclass to render a composite-index.
	/// Currently indices &gt;= 0xffffff are not supported.
	/// </summary>
	public virtual void RenderCompositeIndex(uint index)
	{
		vtkHardwareSelector_RenderCompositeIndex_35(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_RenderProcessId_36(HandleRef pThis, uint processid);

	/// <summary>
	/// Called by any vtkMapper or subclass to render process id. This has any
	/// effect when this-&gt;UseProcessIdFromData is true.
	/// </summary>
	public virtual void RenderProcessId(uint processid)
	{
		vtkHardwareSelector_RenderProcessId_36(GetCppThis(), processid);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Struct used to return information about a pixel location.
	/// </summary>
	public new static vtkHardwareSelector SafeDownCast(vtkObjectBase o)
	{
		vtkHardwareSelector vtkHardwareSelector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHardwareSelector2 = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHardwareSelector2.Register(null);
			}
		}
		return vtkHardwareSelector2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SavePixelBuffer_38(HandleRef pThis, int passNo);

	/// <summary>
	/// Convert a PassTypes enum value to a human readable string.
	/// </summary>
	public virtual void SavePixelBuffer(int passNo)
	{
		vtkHardwareSelector_SavePixelBuffer_38(GetCppThis(), passNo);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHardwareSelector_Select_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Perform the selection. Returns a new instance of vtkSelection containing
	/// the selection on success.
	/// </summary>
	public vtkSelection Select()
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHardwareSelector_Select_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetActorPassOnly_40(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set to only do the actor pass. If true all other passes will be
	/// skipped resulting in a faster pick.
	/// </summary>
	public virtual void SetActorPassOnly(bool _arg)
	{
		vtkHardwareSelector_SetActorPassOnly_40(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetArea_41(HandleRef pThis, uint _arg1, uint _arg2, uint _arg3, uint _arg4);

	/// <summary>
	/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
	/// </summary>
	public virtual void SetArea(uint _arg1, uint _arg2, uint _arg3, uint _arg4)
	{
		vtkHardwareSelector_SetArea_41(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetArea_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the area to select as (xmin, ymin, xmax, ymax).
	/// </summary>
	public virtual void SetArea(IntPtr _arg)
	{
		vtkHardwareSelector_SetArea_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetCaptureZValues_43(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set to capture the zvalue. If true the closest zvalue is
	/// stored for each prop that is in the selection. ZValue in this
	/// case is the value from the zbuffer which can be used in
	/// coordinate conversions
	/// </summary>
	public virtual void SetCaptureZValues(bool _arg)
	{
		vtkHardwareSelector_SetCaptureZValues_43(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetFieldAssociation_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the field type to select. Valid values are
	/// \li vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// \li vtkDataObject::FIELD_ASSOCIATION_CELLS
	/// \li vtkDataObject::FIELD_ASSOCIATION_VERTICES
	/// \li vtkDataObject::FIELD_ASSOCIATION_EDGES
	/// \li vtkDataObject::FIELD_ASSOCIATION_ROWS
	/// Currently only FIELD_ASSOCIATION_POINTS and FIELD_ASSOCIATION_CELLS are
	/// supported.
	/// </summary>
	public virtual void SetFieldAssociation(int _arg)
	{
		vtkHardwareSelector_SetFieldAssociation_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetProcessID_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the process id. If process id &lt; 0 (default -1), then the
	/// PROCESS_PASS is not rendered.
	/// </summary>
	public virtual void SetProcessID(int _arg)
	{
		vtkHardwareSelector_SetProcessID_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetPropColorValue_46(HandleRef pThis, float _arg1, float _arg2, float _arg3);

	/// <summary>
	/// Get/Set the color to be used by the prop when drawing
	/// </summary>
	public virtual void SetPropColorValue(float _arg1, float _arg2, float _arg3)
	{
		vtkHardwareSelector_SetPropColorValue_46(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetPropColorValue_47(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the color to be used by the prop when drawing
	/// </summary>
	public virtual void SetPropColorValue(IntPtr _arg)
	{
		vtkHardwareSelector_SetPropColorValue_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetPropColorValue_48(HandleRef pThis, long val);

	/// <summary>
	/// Get/Set the color to be used by the prop when drawing
	/// </summary>
	public void SetPropColorValue(long val)
	{
		vtkHardwareSelector_SetPropColorValue_48(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetRenderer_49(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the renderer to perform the selection on.
	/// </summary>
	public virtual void SetRenderer(vtkRenderer arg0)
	{
		vtkHardwareSelector_SetRenderer_49(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_SetUseProcessIdFromData_50(HandleRef pThis, byte _arg);

	/// <summary>
	/// In some parallel rendering setups, the process id for elements must be
	/// obtained from the data itself, rather than the rendering process' id. In
	/// that case, set this flag to ON (default OFF).
	/// </summary>
	public virtual void SetUseProcessIdFromData(bool _arg)
	{
		vtkHardwareSelector_SetUseProcessIdFromData_50(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_UpdateMaximumCellId_51(HandleRef pThis, long attribid);

	/// <summary>
	/// Called by any vtkMapper or vtkProp subclass to indicate the
	/// maximum cell or point attribute ID it uses. These values are
	/// used for determining if the POINT_ID_HIGH or CELL_ID_HIGH
	/// passes are required.
	/// </summary>
	public virtual void UpdateMaximumCellId(long attribid)
	{
		vtkHardwareSelector_UpdateMaximumCellId_51(GetCppThis(), attribid);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHardwareSelector_UpdateMaximumPointId_52(HandleRef pThis, long attribid);

	/// <summary>
	/// Called by any vtkMapper or vtkProp subclass to indicate the
	/// maximum cell or point attribute ID it uses. These values are
	/// used for determining if the POINT_ID_HIGH or CELL_ID_HIGH
	/// passes are required.
	/// </summary>
	public virtual void UpdateMaximumPointId(long attribid)
	{
		vtkHardwareSelector_UpdateMaximumPointId_52(GetCppThis(), attribid);
	}
}
