using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMapper3D
/// </summary>
/// <remarks>
///    abstract class for mapping images to the screen
///
/// vtkImageMapper3D is a mapper that will draw a 2D image, or a slice
/// of a 3D image.  The slice plane can be set automatically follow the
/// camera, so that it slices through the focal point and faces the camera.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
/// <seealso>
///
/// vtkImage vtkImageProperty vtkImageResliceMapper vtkImageSliceMapper
/// </seealso>
public abstract class vtkImageMapper3D : vtkAbstractMapper3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapper3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMapper3D()
	{
		MRClassNameKey = "class vtkImageMapper3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapper3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMapper3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkImageMapper3D_BackgroundOff_01(HandleRef pThis);

	/// <summary>
	/// Instead of rendering only to the image border, render out
	/// to the viewport boundary with the background color.  The
	/// background color will be the lowest color on the lookup
	/// table that is being used for the image.
	/// </summary>
	public virtual void BackgroundOff()
	{
		vtkImageMapper3D_BackgroundOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_BackgroundOn_02(HandleRef pThis);

	/// <summary>
	/// Instead of rendering only to the image border, render out
	/// to the viewport boundary with the background color.  The
	/// background color will be the lowest color on the lookup
	/// table that is being used for the image.
	/// </summary>
	public virtual void BackgroundOn()
	{
		vtkImageMapper3D_BackgroundOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_BorderOff_03(HandleRef pThis);

	/// <summary>
	/// Instead of displaying the image only out to the image
	/// bounds, include a half-voxel border around the image.
	/// Within this border, the image values will be extrapolated
	/// rather than interpolated.
	/// </summary>
	public virtual void BorderOff()
	{
		vtkImageMapper3D_BorderOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_BorderOn_04(HandleRef pThis);

	/// <summary>
	/// Instead of displaying the image only out to the image
	/// bounds, include a half-voxel border around the image.
	/// Within this border, the image values will be extrapolated
	/// rather than interpolated.
	/// </summary>
	public virtual void BorderOn()
	{
		vtkImageMapper3D_BorderOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_GetBackground_05(HandleRef pThis);

	/// <summary>
	/// Instead of rendering only to the image border, render out
	/// to the viewport boundary with the background color.  The
	/// background color will be the lowest color on the lookup
	/// table that is being used for the image.
	/// </summary>
	public virtual int GetBackground()
	{
		return vtkImageMapper3D_GetBackground_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_GetBorder_06(HandleRef pThis);

	/// <summary>
	/// Instead of displaying the image only out to the image
	/// bounds, include a half-voxel border around the image.
	/// Within this border, the image values will be extrapolated
	/// rather than interpolated.
	/// </summary>
	public virtual int GetBorder()
	{
		return vtkImageMapper3D_GetBorder_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper3D_GetDataObjectInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The input data for this mapper.
	/// </summary>
	public vtkDataObject GetDataObjectInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper3D_GetDataObjectInput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper3D_GetDataSetInput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The input data for this mapper.
	/// </summary>
	public vtkDataSet GetDataSetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper3D_GetDataSetInput_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_GetIndexBounds_09(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Turn on streaming, to pull the minimum amount of data from the input.
	/// Streaming decreases the memory required to display large images, since
	/// only one slice will be pulled through the input pipeline if only
	/// one slice is mapped to the screen.  The default behavior is to pull
	/// the full 3D input extent through the input pipeline, but to do this
	/// only when the input data changes.  The default behavior results in
	/// much faster follow-up renders when the input data is static.
	/// </summary>
	public virtual void GetIndexBounds(IntPtr extent)
	{
		vtkImageMapper3D_GetIndexBounds_09(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper3D_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The input data for this mapper.
	/// </summary>
	public vtkImageData GetInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper3D_GetInput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMapper3D_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMapper3D_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMapper3D_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMapper3D_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_GetNumberOfThreads_13(HandleRef pThis);

	/// <summary>
	/// The number of threads to create when rendering.
	/// </summary>
	public virtual int GetNumberOfThreads()
	{
		return vtkImageMapper3D_GetNumberOfThreads_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_GetNumberOfThreadsMaxValue_14(HandleRef pThis);

	/// <summary>
	/// The number of threads to create when rendering.
	/// </summary>
	public virtual int GetNumberOfThreadsMaxValue()
	{
		return vtkImageMapper3D_GetNumberOfThreadsMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_GetNumberOfThreadsMinValue_15(HandleRef pThis);

	/// <summary>
	/// The number of threads to create when rendering.
	/// </summary>
	public virtual int GetNumberOfThreadsMinValue()
	{
		return vtkImageMapper3D_GetNumberOfThreadsMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_GetSliceAtFocalPoint_16(HandleRef pThis);

	/// <summary>
	/// Automatically set the slice position to the camera focal point.
	/// This provides a convenient way to interact with the image, since
	/// most Interactors directly control the camera.
	/// </summary>
	public virtual int GetSliceAtFocalPoint()
	{
		return vtkImageMapper3D_GetSliceAtFocalPoint_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_GetSliceFacesCamera_17(HandleRef pThis);

	/// <summary>
	/// Automatically set the slice orientation so that it faces the camera.
	/// This provides a convenient way to interact with the image, since
	/// most Interactors directly control the camera.
	/// </summary>
	public virtual int GetSliceFacesCamera()
	{
		return vtkImageMapper3D_GetSliceFacesCamera_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper3D_GetSlicePlane_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A plane that describes what slice of the input is being
	/// rendered by the mapper.  This plane is in world coordinates,
	/// not data coordinates.  Before using this plane, call Update
	/// or UpdateInformation to make sure the plane is up-to-date.
	/// These methods are automatically called by Render.
	/// </summary>
	public virtual vtkPlane GetSlicePlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper3D_GetSlicePlane_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlane2 = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlane2.Register(null);
			}
		}
		return vtkPlane2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_GetSlicePlaneInDataCoords_19(HandleRef pThis, HandleRef propMatrix, IntPtr plane);

	/// <summary>
	/// Get the plane as a homogeneous 4-vector that gives the plane
	/// equation coefficients.  The prop3D matrix must be provided so
	/// that the plane can be converted to data coords.
	/// </summary>
	public virtual void GetSlicePlaneInDataCoords(vtkMatrix4x4 propMatrix, IntPtr plane)
	{
		vtkImageMapper3D_GetSlicePlaneInDataCoords_19(GetCppThis(), propMatrix?.GetCppThis() ?? default(HandleRef), plane);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_GetStreaming_20(HandleRef pThis);

	/// <summary>
	/// Turn on streaming, to pull the minimum amount of data from the input.
	/// Streaming decreases the memory required to display large images, since
	/// only one slice will be pulled through the input pipeline if only
	/// one slice is mapped to the screen.  The default behavior is to pull
	/// the full 3D input extent through the input pipeline, but to do this
	/// only when the input data changes.  The default behavior results in
	/// much faster follow-up renders when the input data is static.
	/// </summary>
	public virtual int GetStreaming()
	{
		return vtkImageMapper3D_GetStreaming_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMapper3D_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapper3D_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMapper3D_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper3D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMapper3D NewInstance()
	{
		vtkImageMapper3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper3D_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by
	/// this mapper.  The parameter window is used to determine
	/// which graphic resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkImageMapper3D_ReleaseGraphicsResources_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_Render_25(HandleRef pThis, HandleRef renderer, HandleRef prop);

	/// <summary>
	/// This should only be called by the renderer.
	/// </summary>
	public virtual void Render(vtkRenderer renderer, vtkImageSlice prop)
	{
		vtkImageMapper3D_Render_25(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapper3D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMapper3D SafeDownCast(vtkObjectBase o)
	{
		vtkImageMapper3D vtkImageMapper3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapper3D_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapper3D2 = (vtkImageMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapper3D2.Register(null);
			}
		}
		return vtkImageMapper3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SetBackground_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Instead of rendering only to the image border, render out
	/// to the viewport boundary with the background color.  The
	/// background color will be the lowest color on the lookup
	/// table that is being used for the image.
	/// </summary>
	public virtual void SetBackground(int _arg)
	{
		vtkImageMapper3D_SetBackground_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SetBorder_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Instead of displaying the image only out to the image
	/// bounds, include a half-voxel border around the image.
	/// Within this border, the image values will be extrapolated
	/// rather than interpolated.
	/// </summary>
	public virtual void SetBorder(int _arg)
	{
		vtkImageMapper3D_SetBorder_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SetInputData_29(HandleRef pThis, HandleRef input);

	/// <summary>
	/// The input data for this mapper.
	/// </summary>
	public void SetInputData(vtkImageData input)
	{
		vtkImageMapper3D_SetInputData_29(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SetNumberOfThreads_30(HandleRef pThis, int _arg);

	/// <summary>
	/// The number of threads to create when rendering.
	/// </summary>
	public virtual void SetNumberOfThreads(int _arg)
	{
		vtkImageMapper3D_SetNumberOfThreads_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SetSliceAtFocalPoint_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Automatically set the slice position to the camera focal point.
	/// This provides a convenient way to interact with the image, since
	/// most Interactors directly control the camera.
	/// </summary>
	public virtual void SetSliceAtFocalPoint(int _arg)
	{
		vtkImageMapper3D_SetSliceAtFocalPoint_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SetSliceFacesCamera_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Automatically set the slice orientation so that it faces the camera.
	/// This provides a convenient way to interact with the image, since
	/// most Interactors directly control the camera.
	/// </summary>
	public virtual void SetSliceFacesCamera(int _arg)
	{
		vtkImageMapper3D_SetSliceFacesCamera_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SetStreaming_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on streaming, to pull the minimum amount of data from the input.
	/// Streaming decreases the memory required to display large images, since
	/// only one slice will be pulled through the input pipeline if only
	/// one slice is mapped to the screen.  The default behavior is to pull
	/// the full 3D input extent through the input pipeline, but to do this
	/// only when the input data changes.  The default behavior results in
	/// much faster follow-up renders when the input data is static.
	/// </summary>
	public virtual void SetStreaming(int _arg)
	{
		vtkImageMapper3D_SetStreaming_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SliceAtFocalPointOff_34(HandleRef pThis);

	/// <summary>
	/// Automatically set the slice position to the camera focal point.
	/// This provides a convenient way to interact with the image, since
	/// most Interactors directly control the camera.
	/// </summary>
	public virtual void SliceAtFocalPointOff()
	{
		vtkImageMapper3D_SliceAtFocalPointOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SliceAtFocalPointOn_35(HandleRef pThis);

	/// <summary>
	/// Automatically set the slice position to the camera focal point.
	/// This provides a convenient way to interact with the image, since
	/// most Interactors directly control the camera.
	/// </summary>
	public virtual void SliceAtFocalPointOn()
	{
		vtkImageMapper3D_SliceAtFocalPointOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SliceFacesCameraOff_36(HandleRef pThis);

	/// <summary>
	/// Automatically set the slice orientation so that it faces the camera.
	/// This provides a convenient way to interact with the image, since
	/// most Interactors directly control the camera.
	/// </summary>
	public virtual void SliceFacesCameraOff()
	{
		vtkImageMapper3D_SliceFacesCameraOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_SliceFacesCameraOn_37(HandleRef pThis);

	/// <summary>
	/// Automatically set the slice orientation so that it faces the camera.
	/// This provides a convenient way to interact with the image, since
	/// most Interactors directly control the camera.
	/// </summary>
	public virtual void SliceFacesCameraOn()
	{
		vtkImageMapper3D_SliceFacesCameraOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_StreamingOff_38(HandleRef pThis);

	/// <summary>
	/// Turn on streaming, to pull the minimum amount of data from the input.
	/// Streaming decreases the memory required to display large images, since
	/// only one slice will be pulled through the input pipeline if only
	/// one slice is mapped to the screen.  The default behavior is to pull
	/// the full 3D input extent through the input pipeline, but to do this
	/// only when the input data changes.  The default behavior results in
	/// much faster follow-up renders when the input data is static.
	/// </summary>
	public virtual void StreamingOff()
	{
		vtkImageMapper3D_StreamingOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapper3D_StreamingOn_39(HandleRef pThis);

	/// <summary>
	/// Turn on streaming, to pull the minimum amount of data from the input.
	/// Streaming decreases the memory required to display large images, since
	/// only one slice will be pulled through the input pipeline if only
	/// one slice is mapped to the screen.  The default behavior is to pull
	/// the full 3D input extent through the input pipeline, but to do this
	/// only when the input data changes.  The default behavior results in
	/// much faster follow-up renders when the input data is static.
	/// </summary>
	public virtual void StreamingOn()
	{
		vtkImageMapper3D_StreamingOn_39(GetCppThis());
	}
}
