using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageAnisotropicDiffusion3D
/// </summary>
/// <remarks>
///    edge preserving smoothing.
///
///
/// vtkImageAnisotropicDiffusion3D diffuses an volume iteratively.
/// The neighborhood of the diffusion is determined by the instance
/// flags. if "Faces" is on, the 6 voxels adjoined by faces are included
/// in the neighborhood.  If "Edges" is on the 12 edge connected voxels
/// are included, and if "Corners" is on, the 8 corner connected voxels
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
/// vtkImageAnisotropicDiffusion2D
/// </seealso>
public class vtkImageAnisotropicDiffusion3D : vtkImageSpatialAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageAnisotropicDiffusion3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageAnisotropicDiffusion3D()
	{
		MRClassNameKey = "class vtkImageAnisotropicDiffusion3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAnisotropicDiffusion3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageAnisotropicDiffusion3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAnisotropicDiffusion3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageAnisotropicDiffusion3D New()
	{
		vtkImageAnisotropicDiffusion3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAnisotropicDiffusion3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageAnisotropicDiffusion3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageAnisotropicDiffusion3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageAnisotropicDiffusion3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageAnisotropicDiffusion3D_CornersOff_01(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void CornersOff()
	{
		vtkImageAnisotropicDiffusion3D_CornersOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_CornersOn_02(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void CornersOn()
	{
		vtkImageAnisotropicDiffusion3D_CornersOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_EdgesOff_03(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void EdgesOff()
	{
		vtkImageAnisotropicDiffusion3D_EdgesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_EdgesOn_04(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void EdgesOn()
	{
		vtkImageAnisotropicDiffusion3D_EdgesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_FacesOff_05(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void FacesOff()
	{
		vtkImageAnisotropicDiffusion3D_FacesOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_FacesOn_06(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void FacesOn()
	{
		vtkImageAnisotropicDiffusion3D_FacesOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion3D_GetCorners_07(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual int GetCorners()
	{
		return vtkImageAnisotropicDiffusion3D_GetCorners_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageAnisotropicDiffusion3D_GetDiffusionFactor_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the difference factor
	/// </summary>
	public virtual double GetDiffusionFactor()
	{
		return vtkImageAnisotropicDiffusion3D_GetDiffusionFactor_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageAnisotropicDiffusion3D_GetDiffusionThreshold_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the difference threshold that stops diffusion.
	/// when the difference between two pixel is greater than this threshold,
	/// the pixels are not diffused.  This causes diffusion to avoid sharp edges.
	/// If the GradientMagnitudeThreshold is set, then gradient magnitude is used
	/// for comparison instead of pixel differences.
	/// </summary>
	public virtual double GetDiffusionThreshold()
	{
		return vtkImageAnisotropicDiffusion3D_GetDiffusionThreshold_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion3D_GetEdges_10(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual int GetEdges()
	{
		return vtkImageAnisotropicDiffusion3D_GetEdges_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion3D_GetFaces_11(HandleRef pThis);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual int GetFaces()
	{
		return vtkImageAnisotropicDiffusion3D_GetFaces_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion3D_GetGradientMagnitudeThreshold_12(HandleRef pThis);

	/// <summary>
	/// Switch between gradient magnitude threshold and pixel gradient threshold.
	/// </summary>
	public virtual int GetGradientMagnitudeThreshold()
	{
		return vtkImageAnisotropicDiffusion3D_GetGradientMagnitudeThreshold_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageAnisotropicDiffusion3D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageAnisotropicDiffusion3D_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageAnisotropicDiffusion3D_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageAnisotropicDiffusion3D_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion3D_GetNumberOfIterations_15(HandleRef pThis);

	/// <summary>
	/// Get the number of iterations.
	/// </summary>
	public virtual int GetNumberOfIterations()
	{
		return vtkImageAnisotropicDiffusion3D_GetNumberOfIterations_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOff_16(HandleRef pThis);

	/// <summary>
	/// Switch between gradient magnitude threshold and pixel gradient threshold.
	/// </summary>
	public virtual void GradientMagnitudeThresholdOff()
	{
		vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOn_17(HandleRef pThis);

	/// <summary>
	/// Switch between gradient magnitude threshold and pixel gradient threshold.
	/// </summary>
	public virtual void GradientMagnitudeThresholdOn()
	{
		vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion3D_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageAnisotropicDiffusion3D_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAnisotropicDiffusion3D_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageAnisotropicDiffusion3D_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAnisotropicDiffusion3D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageAnisotropicDiffusion3D NewInstance()
	{
		vtkImageAnisotropicDiffusion3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAnisotropicDiffusion3D_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageAnisotropicDiffusion3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAnisotropicDiffusion3D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageAnisotropicDiffusion3D SafeDownCast(vtkObjectBase o)
	{
		vtkImageAnisotropicDiffusion3D vtkImageAnisotropicDiffusion3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAnisotropicDiffusion3D_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageAnisotropicDiffusion3D2 = (vtkImageAnisotropicDiffusion3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageAnisotropicDiffusion3D2.Register(null);
			}
		}
		return vtkImageAnisotropicDiffusion3D2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_SetCorners_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void SetCorners(int _arg)
	{
		vtkImageAnisotropicDiffusion3D_SetCorners_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_SetDiffusionFactor_24(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the difference factor
	/// </summary>
	public virtual void SetDiffusionFactor(double _arg)
	{
		vtkImageAnisotropicDiffusion3D_SetDiffusionFactor_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_SetDiffusionThreshold_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the difference threshold that stops diffusion.
	/// when the difference between two pixel is greater than this threshold,
	/// the pixels are not diffused.  This causes diffusion to avoid sharp edges.
	/// If the GradientMagnitudeThreshold is set, then gradient magnitude is used
	/// for comparison instead of pixel differences.
	/// </summary>
	public virtual void SetDiffusionThreshold(double _arg)
	{
		vtkImageAnisotropicDiffusion3D_SetDiffusionThreshold_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_SetEdges_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void SetEdges(int _arg)
	{
		vtkImageAnisotropicDiffusion3D_SetEdges_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_SetFaces_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Choose neighbors to diffuse (6 faces, 12 edges, 8 corners).
	/// </summary>
	public virtual void SetFaces(int _arg)
	{
		vtkImageAnisotropicDiffusion3D_SetFaces_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_SetGradientMagnitudeThreshold_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Switch between gradient magnitude threshold and pixel gradient threshold.
	/// </summary>
	public virtual void SetGradientMagnitudeThreshold(int _arg)
	{
		vtkImageAnisotropicDiffusion3D_SetGradientMagnitudeThreshold_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAnisotropicDiffusion3D_SetNumberOfIterations_29(HandleRef pThis, int num);

	/// <summary>
	/// This method sets the number of iterations which also affects the
	/// input neighborhood needed to compute one output pixel.  Each iterations
	/// requires an extra pixel layer on the neighborhood.  This is only relevant
	/// when you are trying to stream or are requesting a sub extent of the "wholeExtent".
	/// </summary>
	public void SetNumberOfIterations(int num)
	{
		vtkImageAnisotropicDiffusion3D_SetNumberOfIterations_29(GetCppThis(), num);
	}
}
