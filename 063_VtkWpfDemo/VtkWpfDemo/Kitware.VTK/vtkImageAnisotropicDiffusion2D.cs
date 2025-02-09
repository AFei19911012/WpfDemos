using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageAnisotropicDiffusion2D
/// </summary>
/// <remarks>
///    edge preserving smoothing.
///
///
/// vtkImageAnisotropicDiffusion2D diffuses a 2d image iteratively.
/// The neighborhood of the diffusion is determined by the instance
/// flags. If "Edges" is on the 4 edge connected voxels
/// are included, and if "Corners" is on, the 4 corner connected voxels
/// are included.  "DiffusionFactor" determines how far a pixel value
/// moves toward its neighbors, and is insensitive to the number of
/// neighbors chosen.  The diffusion is anisotropic because it only occurs
/// when a gradient measure is below "GradientThreshold".  Two gradient measures
/// exist and are toggled by the "GradientMagnitudeThreshold" flag.
/// When "GradientMagnitudeThreshold" is on, the magnitude of the gradient,
/// computed by central differences, above "DiffusionThreshold"
/// a voxel is not modified.  The alternative measure examines each
/// neighbor independently.  The gradient between the voxel and the neighbor
/// must be below the "DiffusionThreshold" for diffusion to occur with
/// THAT neighbor.
///
/// </remarks>
/// <seealso>
///
/// vtkImageAnisotropicDiffusion3D
/// </seealso>
public class vtkImageAnisotropicDiffusion2D : vtkImageSpatialAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageAnisotropicDiffusion2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageAnisotropicDiffusion2D()
	{
		MRClassNameKey = "class vtkImageAnisotropicDiffusion2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAnisotropicDiffusion2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageAnisotropicDiffusion2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAnisotropicDiffusion2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageAnisotropicDiffusion2D New()
	{
		vtkImageAnisotropicDiffusion2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAnisotropicDiffusion2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageAnisotropicDiffusion2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageAnisotropicDiffusion2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageAnisotropicDiffusion2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_CornersOff_01(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void CornersOff()
	{
		vtkImageAnisotropicDiffusion2D_CornersOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_CornersOn_02(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void CornersOn()
	{
		vtkImageAnisotropicDiffusion2D_CornersOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_EdgesOff_03(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void EdgesOff()
	{
		vtkImageAnisotropicDiffusion2D_EdgesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_EdgesOn_04(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void EdgesOn()
	{
		vtkImageAnisotropicDiffusion2D_EdgesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_FacesOff_05(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void FacesOff()
	{
		vtkImageAnisotropicDiffusion2D_FacesOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_FacesOn_06(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void FacesOn()
	{
		vtkImageAnisotropicDiffusion2D_FacesOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion2D_GetCorners_07(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual int GetCorners()
	{
		return vtkImageAnisotropicDiffusion2D_GetCorners_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageAnisotropicDiffusion2D_GetDiffusionFactor_08(HandleRef pThis);

	/// <summary>
	/// The diffusion factor specifies how much neighboring pixels effect each other.
	/// No diffusion occurs with a factor of 0, and a diffusion factor of 1 causes
	/// the pixel to become the average of all its neighbors.
	/// </summary>
	public virtual double GetDiffusionFactor()
	{
		return vtkImageAnisotropicDiffusion2D_GetDiffusionFactor_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageAnisotropicDiffusion2D_GetDiffusionThreshold_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the difference threshold that stops diffusion.
	/// when the difference between two pixel is greater than this threshold,
	/// the pixels are not diffused.  This causes diffusion to avoid sharp edges.
	/// If the GradientMagnitudeThreshold is set, then gradient magnitude is used
	/// for comparison instead of pixel differences.
	/// </summary>
	public virtual double GetDiffusionThreshold()
	{
		return vtkImageAnisotropicDiffusion2D_GetDiffusionThreshold_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion2D_GetEdges_10(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual int GetEdges()
	{
		return vtkImageAnisotropicDiffusion2D_GetEdges_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion2D_GetFaces_11(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual int GetFaces()
	{
		return vtkImageAnisotropicDiffusion2D_GetFaces_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion2D_GetGradientMagnitudeThreshold_12(HandleRef pThis);

	/// <summary>
	/// Switch between gradient magnitude threshold and pixel gradient threshold.
	/// </summary>
	public virtual int GetGradientMagnitudeThreshold()
	{
		return vtkImageAnisotropicDiffusion2D_GetGradientMagnitudeThreshold_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageAnisotropicDiffusion2D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageAnisotropicDiffusion2D_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageAnisotropicDiffusion2D_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageAnisotropicDiffusion2D_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion2D_GetNumberOfIterations_15(HandleRef pThis);

	/// <summary>
	/// Get the number of iterations.
	/// </summary>
	public virtual int GetNumberOfIterations()
	{
		return vtkImageAnisotropicDiffusion2D_GetNumberOfIterations_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOff_16(HandleRef pThis);

	/// <summary>
	/// Switch between gradient magnitude threshold and pixel gradient threshold.
	/// </summary>
	public virtual void GradientMagnitudeThresholdOff()
	{
		vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOn_17(HandleRef pThis);

	/// <summary>
	/// Switch between gradient magnitude threshold and pixel gradient threshold.
	/// </summary>
	public virtual void GradientMagnitudeThresholdOn()
	{
		vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion2D_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageAnisotropicDiffusion2D_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion2D_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageAnisotropicDiffusion2D_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAnisotropicDiffusion2D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageAnisotropicDiffusion2D NewInstance()
	{
		vtkImageAnisotropicDiffusion2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAnisotropicDiffusion2D_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageAnisotropicDiffusion2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAnisotropicDiffusion2D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageAnisotropicDiffusion2D SafeDownCast(vtkObjectBase o)
	{
		vtkImageAnisotropicDiffusion2D vtkImageAnisotropicDiffusion2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAnisotropicDiffusion2D_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageAnisotropicDiffusion2D2 = (vtkImageAnisotropicDiffusion2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageAnisotropicDiffusion2D2.Register(null);
			}
		}
		return vtkImageAnisotropicDiffusion2D2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_SetCorners_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void SetCorners(int _arg)
	{
		vtkImageAnisotropicDiffusion2D_SetCorners_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_SetDiffusionFactor_24(HandleRef pThis, double _arg);

	/// <summary>
	/// The diffusion factor specifies how much neighboring pixels effect each other.
	/// No diffusion occurs with a factor of 0, and a diffusion factor of 1 causes
	/// the pixel to become the average of all its neighbors.
	/// </summary>
	public virtual void SetDiffusionFactor(double _arg)
	{
		vtkImageAnisotropicDiffusion2D_SetDiffusionFactor_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_SetDiffusionThreshold_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the difference threshold that stops diffusion.
	/// when the difference between two pixel is greater than this threshold,
	/// the pixels are not diffused.  This causes diffusion to avoid sharp edges.
	/// If the GradientMagnitudeThreshold is set, then gradient magnitude is used
	/// for comparison instead of pixel differences.
	/// </summary>
	public virtual void SetDiffusionThreshold(double _arg)
	{
		vtkImageAnisotropicDiffusion2D_SetDiffusionThreshold_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_SetEdges_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void SetEdges(int _arg)
	{
		vtkImageAnisotropicDiffusion2D_SetEdges_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_SetFaces_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void SetFaces(int _arg)
	{
		vtkImageAnisotropicDiffusion2D_SetFaces_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_SetGradientMagnitudeThreshold_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Switch between gradient magnitude threshold and pixel gradient threshold.
	/// </summary>
	public virtual void SetGradientMagnitudeThreshold(int _arg)
	{
		vtkImageAnisotropicDiffusion2D_SetGradientMagnitudeThreshold_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion2D_SetNumberOfIterations_29(HandleRef pThis, int num);

	/// <summary>
	/// This method sets the number of iterations which also affects the
	/// input neighborhood needed to compute one output pixel.  Each iteration
	/// requires an extra pixel layer on the neighborhood.  This is only relevant
	/// when you are trying to stream or are requesting a sub extent of the "wholeExtent".
	/// </summary>
	public void SetNumberOfIterations(int num)
	{
		vtkImageAnisotropicDiffusion2D_SetNumberOfIterations_29(GetCppThis(), num);
	}
}
