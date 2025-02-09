using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEncodedGradientEstimator
/// </summary>
/// <remarks>
///    Superclass for gradient estimation
///
/// vtkEncodedGradientEstimator is an abstract superclass for gradient
/// estimation. It takes a scalar input of vtkImageData, computes
/// a gradient value for every point, and encodes this value into a
/// three byte value (2 for direction, 1 for magnitude) using the
/// vtkDirectionEncoder. The direction encoder is defaulted to a
/// vtkRecursiveSphereDirectionEncoder, but can be overridden with the
/// SetDirectionEncoder method. The scale and the bias values for the gradient
/// magnitude are used to convert it into a one byte value according to
/// v = m*scale + bias where m is the magnitude and v is the resulting
/// one byte value.
/// </remarks>
/// <seealso>
///
/// vtkFiniteDifferenceGradientEstimator vtkDirectionEncoder
/// </seealso>
public abstract class vtkEncodedGradientEstimator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEncodedGradientEstimator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEncodedGradientEstimator()
	{
		MRClassNameKey = "class vtkEncodedGradientEstimator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEncodedGradientEstimator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEncodedGradientEstimator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_BoundsClipOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on / off the bounding of the normal computation by
	/// the this-&gt;Bounds bounding box
	/// </summary>
	public virtual void BoundsClipOff()
	{
		vtkEncodedGradientEstimator_BoundsClipOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_BoundsClipOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on / off the bounding of the normal computation by
	/// the this-&gt;Bounds bounding box
	/// </summary>
	public virtual void BoundsClipOn()
	{
		vtkEncodedGradientEstimator_BoundsClipOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_ComputeGradientMagnitudesOff_03(HandleRef pThis);

	/// <summary>
	/// If you don't want to compute gradient magnitudes (but you
	/// do want normals for shading) this can be used. Be careful - if
	/// if you a non-constant gradient magnitude transfer function and
	/// you turn this on, it may crash
	/// </summary>
	public virtual void ComputeGradientMagnitudesOff()
	{
		vtkEncodedGradientEstimator_ComputeGradientMagnitudesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_ComputeGradientMagnitudesOn_04(HandleRef pThis);

	/// <summary>
	/// If you don't want to compute gradient magnitudes (but you
	/// do want normals for shading) this can be used. Be careful - if
	/// if you a non-constant gradient magnitude transfer function and
	/// you turn this on, it may crash
	/// </summary>
	public virtual void ComputeGradientMagnitudesOn()
	{
		vtkEncodedGradientEstimator_ComputeGradientMagnitudesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_CylinderClipOff_05(HandleRef pThis);

	/// <summary>
	/// If the data in each slice is only contained within a circle circumscribed
	/// within the slice, and the slice is square, then don't compute anything
	/// outside the circle. This circle through the slices forms a cylinder.
	/// </summary>
	public virtual void CylinderClipOff()
	{
		vtkEncodedGradientEstimator_CylinderClipOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_CylinderClipOn_06(HandleRef pThis);

	/// <summary>
	/// If the data in each slice is only contained within a circle circumscribed
	/// within the slice, and the slice is square, then don't compute anything
	/// outside the circle. This circle through the slices forms a cylinder.
	/// </summary>
	public virtual void CylinderClipOn()
	{
		vtkEncodedGradientEstimator_CylinderClipOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_GetBounds_07(HandleRef pThis);

	/// <summary>
	/// Set / Get the bounds of the computation (used if
	/// this-&gt;ComputationBounds is 1.) The bounds are specified
	/// xmin, xmax, ymin, ymax, zmin, zmax.
	/// </summary>
	public virtual int[] GetBounds()
	{
		IntPtr intPtr = vtkEncodedGradientEstimator_GetBounds_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_GetBounds_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / Get the bounds of the computation (used if
	/// this-&gt;ComputationBounds is 1.) The bounds are specified
	/// xmin, xmax, ymin, ymax, zmin, zmax.
	/// </summary>
	public virtual void GetBounds(IntPtr data)
	{
		vtkEncodedGradientEstimator_GetBounds_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetBoundsClip_09(HandleRef pThis);

	/// <summary>
	/// Turn on / off the bounding of the normal computation by
	/// the this-&gt;Bounds bounding box
	/// </summary>
	public virtual int GetBoundsClip()
	{
		return vtkEncodedGradientEstimator_GetBoundsClip_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetBoundsClipMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Turn on / off the bounding of the normal computation by
	/// the this-&gt;Bounds bounding box
	/// </summary>
	public virtual int GetBoundsClipMaxValue()
	{
		return vtkEncodedGradientEstimator_GetBoundsClipMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetBoundsClipMinValue_11(HandleRef pThis);

	/// <summary>
	/// Turn on / off the bounding of the normal computation by
	/// the this-&gt;Bounds bounding box
	/// </summary>
	public virtual int GetBoundsClipMinValue()
	{
		return vtkEncodedGradientEstimator_GetBoundsClipMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_GetCircleLimits_12(HandleRef pThis);

	/// <summary>
	/// Get the time required for the last update in seconds or cpu seconds
	/// </summary>
	public IntPtr GetCircleLimits()
	{
		return vtkEncodedGradientEstimator_GetCircleLimits_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetComputeGradientMagnitudes_13(HandleRef pThis);

	/// <summary>
	/// If you don't want to compute gradient magnitudes (but you
	/// do want normals for shading) this can be used. Be careful - if
	/// if you a non-constant gradient magnitude transfer function and
	/// you turn this on, it may crash
	/// </summary>
	public virtual int GetComputeGradientMagnitudes()
	{
		return vtkEncodedGradientEstimator_GetComputeGradientMagnitudes_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetCylinderClip_14(HandleRef pThis);

	/// <summary>
	/// If the data in each slice is only contained within a circle circumscribed
	/// within the slice, and the slice is square, then don't compute anything
	/// outside the circle. This circle through the slices forms a cylinder.
	/// </summary>
	public virtual int GetCylinderClip()
	{
		return vtkEncodedGradientEstimator_GetCylinderClip_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_GetDirectionEncoder_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / Get the direction encoder used to encode normal directions
	/// to fit within two bytes
	/// </summary>
	public virtual vtkDirectionEncoder GetDirectionEncoder()
	{
		vtkDirectionEncoder vtkDirectionEncoder2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEncodedGradientEstimator_GetDirectionEncoder_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDirectionEncoder2 = (vtkDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDirectionEncoder2.Register(null);
			}
		}
		return vtkDirectionEncoder2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetEncodedNormalIndex_16(HandleRef pThis, long xyzIndex);

	/// <summary>
	/// Get the encoded normal at an x,y,z location in the volume
	/// </summary>
	public int GetEncodedNormalIndex(long xyzIndex)
	{
		return vtkEncodedGradientEstimator_GetEncodedNormalIndex_16(GetCppThis(), xyzIndex);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetEncodedNormalIndex_17(HandleRef pThis, int xIndex, int yIndex, int zIndex);

	/// <summary>
	/// Get the encoded normal at an x,y,z location in the volume
	/// </summary>
	public int GetEncodedNormalIndex(int xIndex, int yIndex, int zIndex)
	{
		return vtkEncodedGradientEstimator_GetEncodedNormalIndex_17(GetCppThis(), xIndex, yIndex, zIndex);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_GetEncodedNormals_18(HandleRef pThis);

	/// <summary>
	/// Get the encoded normals.
	/// </summary>
	public IntPtr GetEncodedNormals()
	{
		return vtkEncodedGradientEstimator_GetEncodedNormals_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientEstimator_GetGradientMagnitudeBias_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the scale and bias for the gradient magnitude
	/// </summary>
	public virtual float GetGradientMagnitudeBias()
	{
		return vtkEncodedGradientEstimator_GetGradientMagnitudeBias_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientEstimator_GetGradientMagnitudeScale_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the scale and bias for the gradient magnitude
	/// </summary>
	public virtual float GetGradientMagnitudeScale()
	{
		return vtkEncodedGradientEstimator_GetGradientMagnitudeScale_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_GetGradientMagnitudes_21(HandleRef pThis);

	/// <summary>
	/// Get the gradient magnitudes
	/// </summary>
	public IntPtr GetGradientMagnitudes()
	{
		return vtkEncodedGradientEstimator_GetGradientMagnitudes_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_GetInputAspect_22(HandleRef pThis);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual float[] GetInputAspect()
	{
		IntPtr intPtr = vtkEncodedGradientEstimator_GetInputAspect_22(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_GetInputAspect_23(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual void GetInputAspect(IntPtr data)
	{
		vtkEncodedGradientEstimator_GetInputAspect_23(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_GetInputData_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the scalar input for which the normals will be
	/// calculated. Note that this call does not setup a pipeline
	/// connection. vtkEncodedGradientEstimator is not an algorithm
	/// and does not update its input. If you are directly using this
	/// class, you may need to manually update the algorithm that produces
	/// this data object.
	/// </summary>
	public virtual vtkImageData GetInputData()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEncodedGradientEstimator_GetInputData_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_GetInputSize_25(HandleRef pThis);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual int[] GetInputSize()
	{
		IntPtr intPtr = vtkEncodedGradientEstimator_GetInputSize_25(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_GetInputSize_26(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual void GetInputSize(IntPtr data)
	{
		vtkEncodedGradientEstimator_GetInputSize_26(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientEstimator_GetLastUpdateTimeInCPUSeconds_27(HandleRef pThis);

	/// <summary>
	/// Get the time required for the last update in seconds or cpu seconds
	/// </summary>
	public virtual float GetLastUpdateTimeInCPUSeconds()
	{
		return vtkEncodedGradientEstimator_GetLastUpdateTimeInCPUSeconds_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientEstimator_GetLastUpdateTimeInSeconds_28(HandleRef pThis);

	/// <summary>
	/// Get the time required for the last update in seconds or cpu seconds
	/// </summary>
	public virtual float GetLastUpdateTimeInSeconds()
	{
		return vtkEncodedGradientEstimator_GetLastUpdateTimeInSeconds_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEncodedGradientEstimator_GetNumberOfGenerationsFromBase_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEncodedGradientEstimator_GetNumberOfGenerationsFromBase_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEncodedGradientEstimator_GetNumberOfGenerationsFromBaseType_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEncodedGradientEstimator_GetNumberOfGenerationsFromBaseType_30(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetNumberOfThreads_31(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of threads to create when encoding normals
	/// This defaults to the number of available processors on the machine
	/// </summary>
	public virtual int GetNumberOfThreads()
	{
		return vtkEncodedGradientEstimator_GetNumberOfThreads_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetNumberOfThreadsMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of threads to create when encoding normals
	/// This defaults to the number of available processors on the machine
	/// </summary>
	public virtual int GetNumberOfThreadsMaxValue()
	{
		return vtkEncodedGradientEstimator_GetNumberOfThreadsMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetNumberOfThreadsMinValue_33(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of threads to create when encoding normals
	/// This defaults to the number of available processors on the machine
	/// </summary>
	public virtual int GetNumberOfThreadsMinValue()
	{
		return vtkEncodedGradientEstimator_GetNumberOfThreadsMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetUseCylinderClip_34(HandleRef pThis);

	/// <summary>
	/// Get the time required for the last update in seconds or cpu seconds
	/// </summary>
	public virtual int GetUseCylinderClip()
	{
		return vtkEncodedGradientEstimator_GetUseCylinderClip_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkEncodedGradientEstimator_GetZeroNormalThreshold_35(HandleRef pThis);

	/// <summary>
	/// Set / Get the ZeroNormalThreshold - this defines the minimum magnitude
	/// of a gradient that is considered sufficient to define a
	/// direction. Gradients with magnitudes at or less than this value are given
	/// a "zero normal" index. These are handled specially in the shader,
	/// and you can set the intensity of light for these zero normals in
	/// the gradient shader.
	/// </summary>
	public virtual float GetZeroNormalThreshold()
	{
		return vtkEncodedGradientEstimator_GetZeroNormalThreshold_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetZeroPad_36(HandleRef pThis);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual int GetZeroPad()
	{
		return vtkEncodedGradientEstimator_GetZeroPad_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetZeroPadMaxValue_37(HandleRef pThis);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual int GetZeroPadMaxValue()
	{
		return vtkEncodedGradientEstimator_GetZeroPadMaxValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_GetZeroPadMinValue_38(HandleRef pThis);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual int GetZeroPadMinValue()
	{
		return vtkEncodedGradientEstimator_GetZeroPadMinValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_IsA_39(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEncodedGradientEstimator_IsA_39(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEncodedGradientEstimator_IsTypeOf_40(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEncodedGradientEstimator_IsTypeOf_40(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEncodedGradientEstimator NewInstance()
	{
		vtkEncodedGradientEstimator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEncodedGradientEstimator_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEncodedGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEncodedGradientEstimator_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEncodedGradientEstimator SafeDownCast(vtkObjectBase o)
	{
		vtkEncodedGradientEstimator vtkEncodedGradientEstimator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEncodedGradientEstimator_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEncodedGradientEstimator2 = (vtkEncodedGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEncodedGradientEstimator2.Register(null);
			}
		}
		return vtkEncodedGradientEstimator2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetBounds_43(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set / Get the bounds of the computation (used if
	/// this-&gt;ComputationBounds is 1.) The bounds are specified
	/// xmin, xmax, ymin, ymax, zmin, zmax.
	/// </summary>
	public virtual void SetBounds(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkEncodedGradientEstimator_SetBounds_43(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetBounds_44(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the bounds of the computation (used if
	/// this-&gt;ComputationBounds is 1.) The bounds are specified
	/// xmin, xmax, ymin, ymax, zmin, zmax.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkEncodedGradientEstimator_SetBounds_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetBoundsClip_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on / off the bounding of the normal computation by
	/// the this-&gt;Bounds bounding box
	/// </summary>
	public virtual void SetBoundsClip(int _arg)
	{
		vtkEncodedGradientEstimator_SetBoundsClip_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetComputeGradientMagnitudes_46(HandleRef pThis, int _arg);

	/// <summary>
	/// If you don't want to compute gradient magnitudes (but you
	/// do want normals for shading) this can be used. Be careful - if
	/// if you a non-constant gradient magnitude transfer function and
	/// you turn this on, it may crash
	/// </summary>
	public virtual void SetComputeGradientMagnitudes(int _arg)
	{
		vtkEncodedGradientEstimator_SetComputeGradientMagnitudes_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetCylinderClip_47(HandleRef pThis, int _arg);

	/// <summary>
	/// If the data in each slice is only contained within a circle circumscribed
	/// within the slice, and the slice is square, then don't compute anything
	/// outside the circle. This circle through the slices forms a cylinder.
	/// </summary>
	public virtual void SetCylinderClip(int _arg)
	{
		vtkEncodedGradientEstimator_SetCylinderClip_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetDirectionEncoder_48(HandleRef pThis, HandleRef direnc);

	/// <summary>
	/// Set / Get the direction encoder used to encode normal directions
	/// to fit within two bytes
	/// </summary>
	public void SetDirectionEncoder(vtkDirectionEncoder direnc)
	{
		vtkEncodedGradientEstimator_SetDirectionEncoder_48(GetCppThis(), direnc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetGradientMagnitudeBias_49(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the scale and bias for the gradient magnitude
	/// </summary>
	public virtual void SetGradientMagnitudeBias(float _arg)
	{
		vtkEncodedGradientEstimator_SetGradientMagnitudeBias_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetGradientMagnitudeScale_50(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the scale and bias for the gradient magnitude
	/// </summary>
	public virtual void SetGradientMagnitudeScale(float _arg)
	{
		vtkEncodedGradientEstimator_SetGradientMagnitudeScale_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetInputData_51(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the scalar input for which the normals will be
	/// calculated. Note that this call does not setup a pipeline
	/// connection. vtkEncodedGradientEstimator is not an algorithm
	/// and does not update its input. If you are directly using this
	/// class, you may need to manually update the algorithm that produces
	/// this data object.
	/// </summary>
	public virtual void SetInputData(vtkImageData arg0)
	{
		vtkEncodedGradientEstimator_SetInputData_51(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetNumberOfThreads_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of threads to create when encoding normals
	/// This defaults to the number of available processors on the machine
	/// </summary>
	public virtual void SetNumberOfThreads(int _arg)
	{
		vtkEncodedGradientEstimator_SetNumberOfThreads_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetZeroNormalThreshold_53(HandleRef pThis, float v);

	/// <summary>
	/// Set / Get the ZeroNormalThreshold - this defines the minimum magnitude
	/// of a gradient that is considered sufficient to define a
	/// direction. Gradients with magnitudes at or less than this value are given
	/// a "zero normal" index. These are handled specially in the shader,
	/// and you can set the intensity of light for these zero normals in
	/// the gradient shader.
	/// </summary>
	public void SetZeroNormalThreshold(float v)
	{
		vtkEncodedGradientEstimator_SetZeroNormalThreshold_53(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_SetZeroPad_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual void SetZeroPad(int _arg)
	{
		vtkEncodedGradientEstimator_SetZeroPad_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_Update_55(HandleRef pThis);

	/// <summary>
	/// Recompute the encoded normals and gradient magnitudes.
	/// </summary>
	public void Update()
	{
		vtkEncodedGradientEstimator_Update_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_ZeroPadOff_56(HandleRef pThis);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual void ZeroPadOff()
	{
		vtkEncodedGradientEstimator_ZeroPadOff_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEncodedGradientEstimator_ZeroPadOn_57(HandleRef pThis);

	/// <summary>
	/// Assume that the data value outside the volume is zero when
	/// computing normals.
	/// </summary>
	public virtual void ZeroPadOn()
	{
		vtkEncodedGradientEstimator_ZeroPadOn_57(GetCppThis());
	}
}
