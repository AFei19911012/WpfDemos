using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// \class vtkMultiBlockUnstructuredGridVolumeMapper
/// \brief Mapper to render volumes defined as vtkMultiBlockDataSet.
///
/// </summary>
public class vtkMultiBlockUnstructuredGridVolumeMapper : vtkUnstructuredGridVolumeMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockUnstructuredGridVolumeMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiBlockUnstructuredGridVolumeMapper()
	{
		MRClassNameKey = "class vtkMultiBlockUnstructuredGridVolumeMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockUnstructuredGridVolumeMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiBlockUnstructuredGridVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockUnstructuredGridVolumeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiBlockUnstructuredGridVolumeMapper New()
	{
		vtkMultiBlockUnstructuredGridVolumeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockUnstructuredGridVolumeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiBlockUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMultiBlockUnstructuredGridVolumeMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMultiBlockUnstructuredGridVolumeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkMultiBlockUnstructuredGridVolumeMapper_GetBounds_01(HandleRef pThis);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkMultiBlockUnstructuredGridVolumeMapper_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiBlockUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiBlockUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiBlockUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiBlockUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMultiBlockUnstructuredGridVolumeMapper_GetUseFloatingPointFrameBuffer_04(HandleRef pThis);

	/// <summary>
	/// Set/get whether to use floating-point rendering buffers rather
	/// than the default.
	/// \sa vtkOpenGLProjectedTetrahedraMapper::setusefloatingpointframebuffer
	/// </summary>
	public virtual bool GetUseFloatingPointFrameBuffer()
	{
		return (vtkMultiBlockUnstructuredGridVolumeMapper_GetUseFloatingPointFrameBuffer_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockUnstructuredGridVolumeMapper_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiBlockUnstructuredGridVolumeMapper_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockUnstructuredGridVolumeMapper_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiBlockUnstructuredGridVolumeMapper_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockUnstructuredGridVolumeMapper_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMultiBlockUnstructuredGridVolumeMapper NewInstance()
	{
		vtkMultiBlockUnstructuredGridVolumeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockUnstructuredGridVolumeMapper_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiBlockUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef window);

	/// <summary>
	/// \warning Internal method - not intended for general use, do
	/// NOT use this method outside of the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkMultiBlockUnstructuredGridVolumeMapper_ReleaseGraphicsResources_09(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_Render_10(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	/// Render the current dataset.
	///
	/// \warning Internal method - not intended for general use, do
	/// NOT use this method outside of the rendering process.
	/// </summary>
	public override void Render(vtkRenderer ren, vtkVolume vol)
	{
		vtkMultiBlockUnstructuredGridVolumeMapper_Render_10(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockUnstructuredGridVolumeMapper_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiBlockUnstructuredGridVolumeMapper SafeDownCast(vtkObjectBase o)
	{
		vtkMultiBlockUnstructuredGridVolumeMapper vtkMultiBlockUnstructuredGridVolumeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockUnstructuredGridVolumeMapper_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiBlockUnstructuredGridVolumeMapper2 = (vtkMultiBlockUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiBlockUnstructuredGridVolumeMapper2.Register(null);
			}
		}
		return vtkMultiBlockUnstructuredGridVolumeMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SelectScalarArray_12(HandleRef pThis, int arrayNum);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override void SelectScalarArray(int arrayNum)
	{
		vtkMultiBlockUnstructuredGridVolumeMapper_SelectScalarArray_12(GetCppThis(), arrayNum);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SelectScalarArray_13(HandleRef pThis, string arrayName);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override void SelectScalarArray(string arrayName)
	{
		vtkMultiBlockUnstructuredGridVolumeMapper_SelectScalarArray_13(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SetArrayAccessMode_14(HandleRef pThis, int accessMode);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override void SetArrayAccessMode(int accessMode)
	{
		vtkMultiBlockUnstructuredGridVolumeMapper_SetArrayAccessMode_14(GetCppThis(), accessMode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SetBlendMode_15(HandleRef pThis, int mode);

	/// <summary>
	/// blending mode api from vtkUnstructuredGridVolumemapper
	/// \sa vtkvolumemapper::setblendmode
	/// </summary>
	public override void SetBlendMode(int mode)
	{
		vtkMultiBlockUnstructuredGridVolumeMapper_SetBlendMode_15(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SetScalarMode_16(HandleRef pThis, int ScalarMode);

	/// <summary>
	///  \brief API Superclass
	///  \sa vtkAbstractVolumeMapper
	/// </summary>
	public override void SetScalarMode(int ScalarMode)
	{
		vtkMultiBlockUnstructuredGridVolumeMapper_SetScalarMode_16(GetCppThis(), ScalarMode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockUnstructuredGridVolumeMapper_SetUseFloatingPointFrameBuffer_17(HandleRef pThis, byte use);

	/// <summary>
	/// Set/get whether to use floating-point rendering buffers rather
	/// than the default.
	/// \sa vtkOpenGLProjectedTetrahedraMapper::setusefloatingpointframebuffer
	/// </summary>
	public void SetUseFloatingPointFrameBuffer(bool use)
	{
		vtkMultiBlockUnstructuredGridVolumeMapper_SetUseFloatingPointFrameBuffer_17(GetCppThis(), (byte)(use ? 1u : 0u));
	}
}
