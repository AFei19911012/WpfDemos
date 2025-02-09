using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDepthImageToPointCloud
/// </summary>
/// <remarks>
///    convert a depth image into a point cloud
///
///
/// vtkDepthImageToPointCloud is a filter that acquires its input
/// from a depth image and converts it to point cloud represented as a
/// vtkPolyData. This can then be used in a visualization pipeline.
///
/// The filter takes two input images, one of which is optional. The first
/// image is a (required) depth image containing z-buffer values. The second
/// image is an (optional) scalar image. The information in the z-buffer
/// image, plus a specified camera, is used to generate x-y-z coordinates of
/// the output point cloud (i.e., the points in a vtkPolyData). The second
/// scalar image is (optionally) output as scalars to the output point
/// cloud. Note that the depth image must be a single component image, with
/// values ranging between the near and far clipping range [-1,1].
///
/// Note that if only a single input is provided, then the input is
/// interpreted in one of two ways. First, if the "ZBuffer" point data is
/// provided, then the input image is assumed to be color scalars with the
/// depth data provided in the "ZBuffer" data array. (This is consistent with
/// the vtkRendererSource filter with DepthValues enabled.) Otherwise, the
/// input image is assumed to be a depth image.
///
/// It is (optionally) possible to cull points located on the near and far
/// clipping planes. This may better simulate the generation of a scanned
/// object point cloud.
///
/// @warning
/// For the camera to transform the image depths into a point cloud, this
/// filter makes assumptions about the origin of the depth image (and
/// associated color scalar image). This class performs point by point
/// transformation. The view matrix is used to transform each pixel. IMPORTANT
/// NOTE: The transformation occurs by normalizing the image pixels into the
/// (-1,1) view space (depth values are passed through). The process follows the
/// vtkCoordinate class which is the standard for VTK rendering
/// transformations. Subtle differences in whether the lower left pixel origin
/// are at the center of the pixel versus the lower-left corner of the pixel
/// will make slight differences in how pixels are transformed. (Similarly for
/// the upper right pixel as well). This half pixel difference can cause
/// transformation issues. (The code is commented appropriately.)
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkRendererSource vtkWindowToImageFilter vtkCamera vtkPolyData
/// vtkCoordinate
/// </seealso>
public class vtkDepthImageToPointCloud : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDepthImageToPointCloud";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDepthImageToPointCloud()
	{
		MRClassNameKey = "class vtkDepthImageToPointCloud";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthImageToPointCloud"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDepthImageToPointCloud(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthImageToPointCloud_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static vtkDepthImageToPointCloud New()
	{
		vtkDepthImageToPointCloud result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthImageToPointCloud_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDepthImageToPointCloud)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public vtkDepthImageToPointCloud()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDepthImageToPointCloud_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_CullFarPointsOff_01(HandleRef pThis);

	/// <summary>
	/// Indicate whether to cull points that are located on the far clipping
	/// plane. These typically are points that are part of the background. By
	/// default this is enabled.
	/// </summary>
	public virtual void CullFarPointsOff()
	{
		vtkDepthImageToPointCloud_CullFarPointsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_CullFarPointsOn_02(HandleRef pThis);

	/// <summary>
	/// Indicate whether to cull points that are located on the far clipping
	/// plane. These typically are points that are part of the background. By
	/// default this is enabled.
	/// </summary>
	public virtual void CullFarPointsOn()
	{
		vtkDepthImageToPointCloud_CullFarPointsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_CullNearPointsOff_03(HandleRef pThis);

	/// <summary>
	/// Indicate whether to cull points that are located on the near clipping
	/// plane. These typically are points that are part of the clipped foreground. By
	/// default this is disabled.
	/// </summary>
	public virtual void CullNearPointsOff()
	{
		vtkDepthImageToPointCloud_CullNearPointsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_CullNearPointsOn_04(HandleRef pThis);

	/// <summary>
	/// Indicate whether to cull points that are located on the near clipping
	/// plane. These typically are points that are part of the clipped foreground. By
	/// default this is disabled.
	/// </summary>
	public virtual void CullNearPointsOn()
	{
		vtkDepthImageToPointCloud_CullNearPointsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthImageToPointCloud_GetCamera_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the camera being used to generate the point cloud from the
	/// depth image.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthImageToPointCloud_GetCamera_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDepthImageToPointCloud_GetCullFarPoints_06(HandleRef pThis);

	/// <summary>
	/// Indicate whether to cull points that are located on the far clipping
	/// plane. These typically are points that are part of the background. By
	/// default this is enabled.
	/// </summary>
	public virtual bool GetCullFarPoints()
	{
		return (vtkDepthImageToPointCloud_GetCullFarPoints_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDepthImageToPointCloud_GetCullNearPoints_07(HandleRef pThis);

	/// <summary>
	/// Indicate whether to cull points that are located on the near clipping
	/// plane. These typically are points that are part of the clipped foreground. By
	/// default this is disabled.
	/// </summary>
	public virtual bool GetCullNearPoints()
	{
		return (vtkDepthImageToPointCloud_GetCullNearPoints_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDepthImageToPointCloud_GetMTime_08(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the camera.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDepthImageToPointCloud_GetMTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDepthImageToPointCloud_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDepthImageToPointCloud_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDepthImageToPointCloud_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDepthImageToPointCloud_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthImageToPointCloud_GetOutputPointsPrecision_11(HandleRef pThis);

	/// <summary>
	/// Set the desired precision for the output points.
	/// See vtkAlgorithm::DesiredOutputPrecision for the available choices.
	/// The default is double precision.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkDepthImageToPointCloud_GetOutputPointsPrecision_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDepthImageToPointCloud_GetProduceColorScalars_12(HandleRef pThis);

	/// <summary>
	/// Indicate whether to output color scalar values along with the
	/// point cloud (assuming that the scalar values are available on
	/// input). By default this is enabled.
	/// </summary>
	public virtual bool GetProduceColorScalars()
	{
		return (vtkDepthImageToPointCloud_GetProduceColorScalars_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDepthImageToPointCloud_GetProduceVertexCellArray_13(HandleRef pThis);

	/// <summary>
	/// Indicate whether to output a vertex cell array (i.e., Verts) in the
	/// output point cloud. Some filters require this vertex cells to be
	/// defined in order to execute properly. For example some mappers will
	/// only render points if the vertex cells are defined.
	/// </summary>
	public virtual bool GetProduceVertexCellArray()
	{
		return (vtkDepthImageToPointCloud_GetProduceVertexCellArray_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthImageToPointCloud_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDepthImageToPointCloud_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthImageToPointCloud_IsTypeOf_15(string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDepthImageToPointCloud_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthImageToPointCloud_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new vtkDepthImageToPointCloud NewInstance()
	{
		vtkDepthImageToPointCloud result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthImageToPointCloud_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDepthImageToPointCloud)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_ProduceColorScalarsOff_18(HandleRef pThis);

	/// <summary>
	/// Indicate whether to output color scalar values along with the
	/// point cloud (assuming that the scalar values are available on
	/// input). By default this is enabled.
	/// </summary>
	public virtual void ProduceColorScalarsOff()
	{
		vtkDepthImageToPointCloud_ProduceColorScalarsOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_ProduceColorScalarsOn_19(HandleRef pThis);

	/// <summary>
	/// Indicate whether to output color scalar values along with the
	/// point cloud (assuming that the scalar values are available on
	/// input). By default this is enabled.
	/// </summary>
	public virtual void ProduceColorScalarsOn()
	{
		vtkDepthImageToPointCloud_ProduceColorScalarsOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_ProduceVertexCellArrayOff_20(HandleRef pThis);

	/// <summary>
	/// Indicate whether to output a vertex cell array (i.e., Verts) in the
	/// output point cloud. Some filters require this vertex cells to be
	/// defined in order to execute properly. For example some mappers will
	/// only render points if the vertex cells are defined.
	/// </summary>
	public virtual void ProduceVertexCellArrayOff()
	{
		vtkDepthImageToPointCloud_ProduceVertexCellArrayOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_ProduceVertexCellArrayOn_21(HandleRef pThis);

	/// <summary>
	/// Indicate whether to output a vertex cell array (i.e., Verts) in the
	/// output point cloud. Some filters require this vertex cells to be
	/// defined in order to execute properly. For example some mappers will
	/// only render points if the vertex cells are defined.
	/// </summary>
	public virtual void ProduceVertexCellArrayOn()
	{
		vtkDepthImageToPointCloud_ProduceVertexCellArrayOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthImageToPointCloud_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static vtkDepthImageToPointCloud SafeDownCast(vtkObjectBase o)
	{
		vtkDepthImageToPointCloud vtkDepthImageToPointCloud2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthImageToPointCloud_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDepthImageToPointCloud2 = (vtkDepthImageToPointCloud)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDepthImageToPointCloud2.Register(null);
			}
		}
		return vtkDepthImageToPointCloud2;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_SetCamera_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Indicates what camera was used to generate the depth image. The camera
	/// parameters define a transformation which is used to perform coordinate
	/// conversion into the 3D x-y-z space of the point cloud.
	/// </summary>
	public void SetCamera(vtkCamera arg0)
	{
		vtkDepthImageToPointCloud_SetCamera_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_SetCullFarPoints_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to cull points that are located on the far clipping
	/// plane. These typically are points that are part of the background. By
	/// default this is enabled.
	/// </summary>
	public virtual void SetCullFarPoints(bool _arg)
	{
		vtkDepthImageToPointCloud_SetCullFarPoints_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_SetCullNearPoints_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to cull points that are located on the near clipping
	/// plane. These typically are points that are part of the clipped foreground. By
	/// default this is disabled.
	/// </summary>
	public virtual void SetCullNearPoints(bool _arg)
	{
		vtkDepthImageToPointCloud_SetCullNearPoints_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_SetOutputPointsPrecision_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the desired precision for the output points.
	/// See vtkAlgorithm::DesiredOutputPrecision for the available choices.
	/// The default is double precision.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkDepthImageToPointCloud_SetOutputPointsPrecision_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_SetProduceColorScalars_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to output color scalar values along with the
	/// point cloud (assuming that the scalar values are available on
	/// input). By default this is enabled.
	/// </summary>
	public virtual void SetProduceColorScalars(bool _arg)
	{
		vtkDepthImageToPointCloud_SetProduceColorScalars_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthImageToPointCloud_SetProduceVertexCellArray_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to output a vertex cell array (i.e., Verts) in the
	/// output point cloud. Some filters require this vertex cells to be
	/// defined in order to execute properly. For example some mappers will
	/// only render points if the vertex cells are defined.
	/// </summary>
	public virtual void SetProduceVertexCellArray(bool _arg)
	{
		vtkDepthImageToPointCloud_SetProduceVertexCellArray_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
