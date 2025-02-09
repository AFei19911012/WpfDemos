using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// \class vtkMultiBlockVolumeMapper
/// \brief Mapper to render volumes defined as vtkMultiBlockDataSet.
///
/// vtkMultiBlockVolumeMapper renders vtkMultiBlockDataSet instances containing
/// vtkImageData blocks (all of the blocks are expected to be vtkImageData). Bounds
/// containing the full set of blocks are computed so that vtkRenderer can adjust the
/// clipping planes appropriately.
///
/// This mapper creates an instance of vtkSmartVolumeMapper per block to which
/// it defers the actual rendering.  At render time, blocks (mappers) are sorted
/// back-to-front and each block is rendered independently.  It attempts to load all
/// of the blocks at the same time but tries to catch allocation errors in which case
/// it falls back to using a single mapper instance and reloading data for each block.
///
/// Jittering is used to alleviate seam artifacts at the block edges due to the
/// discontinuous resolution between blocks.  Jittering is enabled by default.
/// Jittering is only supported in GPURenderMode.
///
/// </summary>
public class vtkMultiBlockVolumeMapper : vtkVolumeMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockVolumeMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiBlockVolumeMapper()
	{
		MRClassNameKey = "class vtkMultiBlockVolumeMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockVolumeMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiBlockVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockVolumeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiBlockVolumeMapper New()
	{
		vtkMultiBlockVolumeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockVolumeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiBlockVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMultiBlockVolumeMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMultiBlockVolumeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockVolumeMapper_GetBounds_01(HandleRef pThis);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkMultiBlockVolumeMapper_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMultiBlockVolumeMapper_GetGlobalIlluminationReach_02(HandleRef pThis);

	/// <summary>
	/// @copydoc vtkSmartVolumeMapper::SetGlobalIlluminationReach(float)
	/// </summary>
	public virtual float GetGlobalIlluminationReach()
	{
		return vtkMultiBlockVolumeMapper_GetGlobalIlluminationReach_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiBlockVolumeMapper_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiBlockVolumeMapper_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiBlockVolumeMapper_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiBlockVolumeMapper_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockVolumeMapper_GetVectorComponent_05(HandleRef pThis);

	/// <summary>
	/// VectorMode interface exposed from vtkSmartVolumeMapper.
	/// </summary>
	public virtual int GetVectorComponent()
	{
		return vtkMultiBlockVolumeMapper_GetVectorComponent_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockVolumeMapper_GetVectorMode_06(HandleRef pThis);

	/// <summary>
	/// VectorMode interface exposed from vtkSmartVolumeMapper.
	/// </summary>
	public virtual int GetVectorMode()
	{
		return vtkMultiBlockVolumeMapper_GetVectorMode_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMultiBlockVolumeMapper_GetVolumetricScatteringBlending_07(HandleRef pThis);

	/// <summary>
	/// @copydoc vtkSmartVolumeMapper::SetVolumetricScatteringBlending(float)
	/// </summary>
	public virtual float GetVolumetricScatteringBlending()
	{
		return vtkMultiBlockVolumeMapper_GetVolumetricScatteringBlending_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockVolumeMapper_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiBlockVolumeMapper_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockVolumeMapper_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiBlockVolumeMapper_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockVolumeMapper_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMultiBlockVolumeMapper NewInstance()
	{
		vtkMultiBlockVolumeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockVolumeMapper_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiBlockVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_ReleaseGraphicsResources_12(HandleRef pThis, HandleRef window);

	/// <summary>
	/// \warning Internal method - not intended for general use, do
	/// NOT use this method outside of the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkMultiBlockVolumeMapper_ReleaseGraphicsResources_12(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_Render_13(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	/// Render the current dataset.
	///
	/// \warning Internal method - not intended for general use, do
	/// NOT use this method outside of the rendering process.
	/// </summary>
	public override void Render(vtkRenderer ren, vtkVolume vol)
	{
		vtkMultiBlockVolumeMapper_Render_13(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockVolumeMapper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiBlockVolumeMapper SafeDownCast(vtkObjectBase o)
	{
		vtkMultiBlockVolumeMapper vtkMultiBlockVolumeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockVolumeMapper_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiBlockVolumeMapper2 = (vtkMultiBlockVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiBlockVolumeMapper2.Register(null);
			}
		}
		return vtkMultiBlockVolumeMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SelectScalarArray_15(HandleRef pThis, int arrayNum);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override void SelectScalarArray(int arrayNum)
	{
		vtkMultiBlockVolumeMapper_SelectScalarArray_15(GetCppThis(), arrayNum);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SelectScalarArray_16(HandleRef pThis, string arrayName);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override void SelectScalarArray(string arrayName)
	{
		vtkMultiBlockVolumeMapper_SelectScalarArray_16(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetArrayAccessMode_17(HandleRef pThis, int accessMode);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override void SetArrayAccessMode(int accessMode)
	{
		vtkMultiBlockVolumeMapper_SetArrayAccessMode_17(GetCppThis(), accessMode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetBlendMode_18(HandleRef pThis, int mode);

	/// <summary>
	/// Blending mode API from vtkVolumeMapper
	/// \sa vtkVolumeMapper::SetBlendMode
	/// </summary>
	public override void SetBlendMode(int mode)
	{
		vtkMultiBlockVolumeMapper_SetBlendMode_18(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetComputeNormalFromOpacity_19(HandleRef pThis, byte val);

	/// <summary>
	/// ComputeNormalFromOpacity exposed
	/// \sa vtkVolumeMapper::SetComputeNormalFromOpacity
	/// </summary>
	public override void SetComputeNormalFromOpacity(bool val)
	{
		vtkMultiBlockVolumeMapper_SetComputeNormalFromOpacity_19(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetCropping_20(HandleRef pThis, int mode);

	/// <summary>
	/// Cropping API from vtkVolumeMapper
	/// \sa vtkVolumeMapper::SetCropping
	/// </summary>
	public override void SetCropping(int mode)
	{
		vtkMultiBlockVolumeMapper_SetCropping_20(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetCroppingRegionFlags_21(HandleRef pThis, int mode);

	/// <summary>
	/// \sa vtkVolumeMapper::SetCroppingRegionFlags
	/// </summary>
	public override void SetCroppingRegionFlags(int mode)
	{
		vtkMultiBlockVolumeMapper_SetCroppingRegionFlags_21(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetCroppingRegionPlanes_22(HandleRef pThis, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6);

	/// <summary>
	/// \sa vtkVolumeMapper::SetCroppingRegionPlanes
	/// </summary>
	public override void SetCroppingRegionPlanes(double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
	{
		vtkMultiBlockVolumeMapper_SetCroppingRegionPlanes_22(GetCppThis(), arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetCroppingRegionPlanes_23(HandleRef pThis, IntPtr planes);

	/// <summary>
	/// \sa vtkVolumeMapper::SetCroppingRegionPlanes
	/// </summary>
	public override void SetCroppingRegionPlanes(IntPtr planes)
	{
		vtkMultiBlockVolumeMapper_SetCroppingRegionPlanes_23(GetCppThis(), planes);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetGlobalIlluminationReach_24(HandleRef pThis, float val);

	/// <summary>
	/// @copydoc vtkSmartVolumeMapper::SetGlobalIlluminationReach(float)
	/// </summary>
	public void SetGlobalIlluminationReach(float val)
	{
		vtkMultiBlockVolumeMapper_SetGlobalIlluminationReach_24(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetRequestedRenderMode_25(HandleRef pThis, int arg0);

	/// <summary>
	/// Forwarded to internal vtkSmartVolumeMappers used.
	/// @sa vtkSmartVolumeMapper::SetRequestedRenderMode.
	/// </summary>
	public void SetRequestedRenderMode(int arg0)
	{
		vtkMultiBlockVolumeMapper_SetRequestedRenderMode_25(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetScalarMode_26(HandleRef pThis, int ScalarMode);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override void SetScalarMode(int ScalarMode)
	{
		vtkMultiBlockVolumeMapper_SetScalarMode_26(GetCppThis(), ScalarMode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetTransfer2DYAxisArray_27(HandleRef pThis, string a);

	/// <summary>
	/// \sa vtkSmartVolumeMapper::SetTransfer2DYAxisArray
	/// </summary>
	public void SetTransfer2DYAxisArray(string a)
	{
		vtkMultiBlockVolumeMapper_SetTransfer2DYAxisArray_27(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetVectorComponent_28(HandleRef pThis, int component);

	/// <summary>
	/// VectorMode interface exposed from vtkSmartVolumeMapper.
	/// </summary>
	public void SetVectorComponent(int component)
	{
		vtkMultiBlockVolumeMapper_SetVectorComponent_28(GetCppThis(), component);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetVectorMode_29(HandleRef pThis, int mode);

	/// <summary>
	/// VectorMode interface exposed from vtkSmartVolumeMapper.
	/// </summary>
	public void SetVectorMode(int mode)
	{
		vtkMultiBlockVolumeMapper_SetVectorMode_29(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockVolumeMapper_SetVolumetricScatteringBlending_30(HandleRef pThis, float val);

	/// <summary>
	/// @copydoc vtkSmartVolumeMapper::SetVolumetricScatteringBlending(float)
	/// </summary>
	public void SetVolumetricScatteringBlending(float val)
	{
		vtkMultiBlockVolumeMapper_SetVolumetricScatteringBlending_30(GetCppThis(), val);
	}
}
