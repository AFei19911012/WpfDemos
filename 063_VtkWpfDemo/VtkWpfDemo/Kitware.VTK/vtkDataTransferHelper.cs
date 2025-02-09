using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataTransferHelper
/// </summary>
/// <remarks>
///    is a helper class that aids in transferring
///  data between CPU memory and GPU memory.
///
///
///  vtkDataTransferHelper is a helper class that aids in transferring data
///  between the CPU memory and the GPU memory. The data in GPU memory is
///  stored as textures which that in CPU memory is stored as vtkDataArray.
///  vtkDataTransferHelper provides API to transfer only a sub-extent of CPU
///  structured data to/from the GPU.
///
/// </remarks>
/// <seealso>
///
///  vtkPixelBufferObject vtkTextureObject vtkOpenGLExtensionManager
/// </seealso>
public class vtkDataTransferHelper : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataTransferHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataTransferHelper()
	{
		MRClassNameKey = "class vtkDataTransferHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataTransferHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataTransferHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataTransferHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataTransferHelper New()
	{
		vtkDataTransferHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataTransferHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataTransferHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataTransferHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataTransferHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkDataTransferHelper_Download_01(HandleRef pThis);

	/// <summary>
	/// old comment:
	/// Download Extent from GPU data buffer to CPU.
	/// GPU data size must exactly match Extent.
	/// CPU data buffer will be resized to match WholeExtent in which only the
	/// Extent will be filled with the GPU data.
	/// new comment:
	/// Download GPUExtent from GPU texture to CPU vtkDataArray.
	/// If Array is not provided, it will be created with the size of CPUExtent.
	/// But only the tuples covered by GPUExtent will be download. In this case,
	/// if GPUExtent does not cover all GPUExtent, some of the vtkDataArray will
	/// be uninitialized.
	/// Reminder: A=&gt;B &lt;=&gt; !A||B
	/// \pre texture_exists: texture!=0
	/// \pre array_not_empty: array==0 || array-&gt;GetNumberOfTuples()&gt;0
	/// \pre valid_cpu_extent: this-&gt;GetCPUExtentIsValid()
	/// \pre valid_cpu_extent_size: array==0 ||
	/// (CPUExtent[1]-CPUExtent[0]+1)*(CPUExtent[3]-CPUExtent[2]+1)*(CPUExtent[5]-CPUExtent[4]+1)==array-&gt;GetNumberOfTuples()
	/// \pre valid_gpu_extent: this-&gt;GetGPUExtentIsValid()
	/// \pre gpu_extent_in_cpu_extent: CPUExtent[0]&lt;=GPUExtent[0] &amp;&amp; GPUExtent[1]&lt;=CPUExtent[1] &amp;&amp;
	/// CPUExtent[2]&lt;=GPUExtent[2] &amp;&amp; GPUExtent[3]&lt;=CPUExtent[3] &amp;&amp; CPUExtent[4]&lt;=GPUExtent[4] &amp;&amp;
	/// GPUExtent[5]&lt;=CPUExtent[5] \pre gpu_texture_size: !this-&gt;GetTextureExtentIsValid() ||
	/// (GPUExtent[1]-GPUExtent[0]+1)*(GPUExtent[3]-GPUExtent[2]+1)*(GPUExtent[5]-GPUExtent[4]+1)==(TextureExtent[1]-TextureExtent[0]+1)*(TextureExtent[3]-TextureExtent[2]+1)*(TextureExtent[5]-TextureExtent[4]+1)
	/// \pre valid_components: array==0 || array-&gt;GetNumberOfComponents()&lt;=4
	/// \pre components_match: array==0 || (texture-&gt;GetComponents()==array-&gt;GetNumberOfComponents())
	/// </summary>
	public bool Download()
	{
		return (vtkDataTransferHelper_Download_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataTransferHelper_DownloadAsync1_02(HandleRef pThis);

	/// <summary>
	/// Splits the download in two operations
	/// * Asynchronously download from texture memory to PBO (DownloadAsync1()).
	/// * Copy from pbo to user array (DownloadAsync2()).
	/// </summary>
	public bool DownloadAsync1()
	{
		return (vtkDataTransferHelper_DownloadAsync1_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataTransferHelper_DownloadAsync2_03(HandleRef pThis);

	/// <summary>
	/// Splits the download in two operations
	/// * Asynchronously download from texture memory to PBO (DownloadAsync1()).
	/// * Copy from pbo to user array (DownloadAsync2()).
	/// </summary>
	public bool DownloadAsync2()
	{
		return (vtkDataTransferHelper_DownloadAsync2_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataTransferHelper_GetArray_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the CPU data buffer. Initial value is 0.
	/// </summary>
	public virtual vtkDataArray GetArray()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataTransferHelper_GetArray_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataTransferHelper_GetCPUExtent_05(HandleRef pThis);

	/// <summary>
	/// Set the CPU data extent. The extent matches the vtkDataArray size.
	/// If the vtkDataArray comes from an vtkImageData and it is part of the
	/// point data, it is usually the vtkImageData extent.
	/// It can be on cell data too, but in this case it does not match the
	/// vtkImageData extent.
	/// If the vtkDataArray comes from a vtkDataSet, just
	/// set it to a one-dimenstional extent equal to the number of tuples.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual int[] GetCPUExtent()
	{
		IntPtr intPtr = vtkDataTransferHelper_GetCPUExtent_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_GetCPUExtent_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the CPU data extent. The extent matches the vtkDataArray size.
	/// If the vtkDataArray comes from an vtkImageData and it is part of the
	/// point data, it is usually the vtkImageData extent.
	/// It can be on cell data too, but in this case it does not match the
	/// vtkImageData extent.
	/// If the vtkDataArray comes from a vtkDataSet, just
	/// set it to a one-dimenstional extent equal to the number of tuples.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual void GetCPUExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkDataTransferHelper_GetCPUExtent_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_GetCPUExtent_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the CPU data extent. The extent matches the vtkDataArray size.
	/// If the vtkDataArray comes from an vtkImageData and it is part of the
	/// point data, it is usually the vtkImageData extent.
	/// It can be on cell data too, but in this case it does not match the
	/// vtkImageData extent.
	/// If the vtkDataArray comes from a vtkDataSet, just
	/// set it to a one-dimenstional extent equal to the number of tuples.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual void GetCPUExtent(IntPtr _arg)
	{
		vtkDataTransferHelper_GetCPUExtent_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataTransferHelper_GetCPUExtentIsValid_08(HandleRef pThis);

	/// <summary>
	/// Tells if CPUExtent is valid. True if min extent&lt;=max extent.
	/// </summary>
	public bool GetCPUExtentIsValid()
	{
		return (vtkDataTransferHelper_GetCPUExtentIsValid_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataTransferHelper_GetContext_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
	/// This does not increase the reference count of the
	/// context to avoid reference loops.
	/// SetContext() may raise an error if the OpenGL context does not support the
	/// required OpenGL extensions.
	/// </summary>
	public vtkRenderWindow GetContext()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataTransferHelper_GetContext_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataTransferHelper_GetExtentIsValid_10(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Tells if the given extent (6 int) is valid. True if min
	/// extent&lt;=max extent.
	/// \pre extent_exists: extent!=0
	/// </summary>
	public bool GetExtentIsValid(IntPtr extent)
	{
		return (vtkDataTransferHelper_GetExtentIsValid_10(GetCppThis(), extent) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataTransferHelper_GetGPUExtent_11(HandleRef pThis);

	/// <summary>
	/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
	/// This extent matches the size of the data to transfer.
	/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
	/// whereas TextureExtent is 2D) but the number of elements have to match.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual int[] GetGPUExtent()
	{
		IntPtr intPtr = vtkDataTransferHelper_GetGPUExtent_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_GetGPUExtent_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
	/// This extent matches the size of the data to transfer.
	/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
	/// whereas TextureExtent is 2D) but the number of elements have to match.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual void GetGPUExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkDataTransferHelper_GetGPUExtent_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_GetGPUExtent_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
	/// This extent matches the size of the data to transfer.
	/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
	/// whereas TextureExtent is 2D) but the number of elements have to match.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual void GetGPUExtent(IntPtr _arg)
	{
		vtkDataTransferHelper_GetGPUExtent_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataTransferHelper_GetGPUExtentIsValid_14(HandleRef pThis);

	/// <summary>
	/// Tells if GPUExtent is valid. True if min extent&lt;=max extent.
	/// </summary>
	public bool GetGPUExtentIsValid()
	{
		return (vtkDataTransferHelper_GetGPUExtentIsValid_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataTransferHelper_GetMinTextureDimension_15(HandleRef pThis);

	/// <summary>
	/// Define the minimal dimension of the texture regardless of the dimensions
	/// of the TextureExtent. Initial value is 1.
	/// A texture extent can have a given dimension 0D (one value), 1D, 2D or 3D.
	/// By default 0D and 1D are translated into a 1D texture, 2D is translated
	/// into a 2D texture, 3D is translated into a 3D texture. To make life easier
	/// when writing GLSL code and use only one type of sampler (ex: sampler2d),
	/// the default behavior can be changed by forcing a type of texture with
	/// this ivar.
	/// 1: default behavior. Initial value.
	/// 2: force 0D and 1D to be in a 2D texture
	/// 3: force 0D, 1D and 2D texture to be in a 3D texture.
	/// </summary>
	public virtual int GetMinTextureDimension()
	{
		return vtkDataTransferHelper_GetMinTextureDimension_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataTransferHelper_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataTransferHelper_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataTransferHelper_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataTransferHelper_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataTransferHelper_GetShaderSupportsTextureInt_18(HandleRef pThis);

	/// <summary>
	/// Splits the download in two operations
	/// * Asynchronously download from texture memory to PBO (DownloadAsync1()).
	/// * Copy from pbo to user array (DownloadAsync2()).
	/// </summary>
	public bool GetShaderSupportsTextureInt()
	{
		return (vtkDataTransferHelper_GetShaderSupportsTextureInt_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataTransferHelper_GetTextureExtent_19(HandleRef pThis);

	/// <summary>
	/// Set the texture data extent. This is the extent of the texture image that
	/// will receive the data. This extent matches the size of the data to
	/// transfer. If it is set to an invalid extent, GPUExtent is used.
	/// See more comment on GPUExtent.
	/// Initial value is an invalid extent.
	/// </summary>
	public virtual int[] GetTextureExtent()
	{
		IntPtr intPtr = vtkDataTransferHelper_GetTextureExtent_19(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_GetTextureExtent_20(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the texture data extent. This is the extent of the texture image that
	/// will receive the data. This extent matches the size of the data to
	/// transfer. If it is set to an invalid extent, GPUExtent is used.
	/// See more comment on GPUExtent.
	/// Initial value is an invalid extent.
	/// </summary>
	public virtual void GetTextureExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkDataTransferHelper_GetTextureExtent_20(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_GetTextureExtent_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the texture data extent. This is the extent of the texture image that
	/// will receive the data. This extent matches the size of the data to
	/// transfer. If it is set to an invalid extent, GPUExtent is used.
	/// See more comment on GPUExtent.
	/// Initial value is an invalid extent.
	/// </summary>
	public virtual void GetTextureExtent(IntPtr _arg)
	{
		vtkDataTransferHelper_GetTextureExtent_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataTransferHelper_GetTextureExtentIsValid_22(HandleRef pThis);

	/// <summary>
	/// Tells if TextureExtent is valid. True if min extent&lt;=max extent.
	/// </summary>
	public bool GetTextureExtentIsValid()
	{
		return (vtkDataTransferHelper_GetTextureExtentIsValid_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataTransferHelper_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataTransferHelper_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataTransferHelper_IsSupported_24(HandleRef renWin);

	/// <summary>
	/// Returns if the context supports the required extensions.
	/// </summary>
	public static bool IsSupported(vtkRenderWindow renWin)
	{
		return (vtkDataTransferHelper_IsSupported_24(renWin?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataTransferHelper_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataTransferHelper_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataTransferHelper_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataTransferHelper NewInstance()
	{
		vtkDataTransferHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataTransferHelper_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataTransferHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataTransferHelper_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataTransferHelper SafeDownCast(vtkObjectBase o)
	{
		vtkDataTransferHelper vtkDataTransferHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataTransferHelper_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataTransferHelper2 = (vtkDataTransferHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataTransferHelper2.Register(null);
			}
		}
		return vtkDataTransferHelper2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetArray_29(HandleRef pThis, HandleRef array);

	/// <summary>
	/// Get/Set the CPU data buffer. Initial value is 0.
	/// </summary>
	public void SetArray(vtkDataArray array)
	{
		vtkDataTransferHelper_SetArray_29(GetCppThis(), array?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetCPUExtent_30(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set the CPU data extent. The extent matches the vtkDataArray size.
	/// If the vtkDataArray comes from an vtkImageData and it is part of the
	/// point data, it is usually the vtkImageData extent.
	/// It can be on cell data too, but in this case it does not match the
	/// vtkImageData extent.
	/// If the vtkDataArray comes from a vtkDataSet, just
	/// set it to a one-dimenstional extent equal to the number of tuples.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual void SetCPUExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkDataTransferHelper_SetCPUExtent_30(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetCPUExtent_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the CPU data extent. The extent matches the vtkDataArray size.
	/// If the vtkDataArray comes from an vtkImageData and it is part of the
	/// point data, it is usually the vtkImageData extent.
	/// It can be on cell data too, but in this case it does not match the
	/// vtkImageData extent.
	/// If the vtkDataArray comes from a vtkDataSet, just
	/// set it to a one-dimenstional extent equal to the number of tuples.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual void SetCPUExtent(IntPtr _arg)
	{
		vtkDataTransferHelper_SetCPUExtent_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetContext_32(HandleRef pThis, HandleRef context);

	/// <summary>
	/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
	/// This does not increase the reference count of the
	/// context to avoid reference loops.
	/// SetContext() may raise an error if the OpenGL context does not support the
	/// required OpenGL extensions.
	/// </summary>
	public void SetContext(vtkRenderWindow context)
	{
		vtkDataTransferHelper_SetContext_32(GetCppThis(), context?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetGPUExtent_33(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
	/// This extent matches the size of the data to transfer.
	/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
	/// whereas TextureExtent is 2D) but the number of elements have to match.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual void SetGPUExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkDataTransferHelper_SetGPUExtent_33(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetGPUExtent_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the GPU data extent. This is the sub-extent to copy from or to the GPU.
	/// This extent matches the size of the data to transfer.
	/// GPUExtent and TextureExtent don't have to match (GPUExtent can be 1D
	/// whereas TextureExtent is 2D) but the number of elements have to match.
	/// Initial value is (0,0,0,0,0,0), a valid one tuple array.
	/// </summary>
	public virtual void SetGPUExtent(IntPtr _arg)
	{
		vtkDataTransferHelper_SetGPUExtent_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetMinTextureDimension_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Define the minimal dimension of the texture regardless of the dimensions
	/// of the TextureExtent. Initial value is 1.
	/// A texture extent can have a given dimension 0D (one value), 1D, 2D or 3D.
	/// By default 0D and 1D are translated into a 1D texture, 2D is translated
	/// into a 2D texture, 3D is translated into a 3D texture. To make life easier
	/// when writing GLSL code and use only one type of sampler (ex: sampler2d),
	/// the default behavior can be changed by forcing a type of texture with
	/// this ivar.
	/// 1: default behavior. Initial value.
	/// 2: force 0D and 1D to be in a 2D texture
	/// 3: force 0D, 1D and 2D texture to be in a 3D texture.
	/// </summary>
	public virtual void SetMinTextureDimension(int _arg)
	{
		vtkDataTransferHelper_SetMinTextureDimension_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetShaderSupportsTextureInt_36(HandleRef pThis, byte value);

	/// <summary>
	/// Splits the download in two operations
	/// * Asynchronously download from texture memory to PBO (DownloadAsync1()).
	/// * Copy from pbo to user array (DownloadAsync2()).
	/// </summary>
	public void SetShaderSupportsTextureInt(bool value)
	{
		vtkDataTransferHelper_SetShaderSupportsTextureInt_36(GetCppThis(), (byte)(value ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetTextureExtent_37(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set the texture data extent. This is the extent of the texture image that
	/// will receive the data. This extent matches the size of the data to
	/// transfer. If it is set to an invalid extent, GPUExtent is used.
	/// See more comment on GPUExtent.
	/// Initial value is an invalid extent.
	/// </summary>
	public virtual void SetTextureExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkDataTransferHelper_SetTextureExtent_37(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataTransferHelper_SetTextureExtent_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the texture data extent. This is the extent of the texture image that
	/// will receive the data. This extent matches the size of the data to
	/// transfer. If it is set to an invalid extent, GPUExtent is used.
	/// See more comment on GPUExtent.
	/// Initial value is an invalid extent.
	/// </summary>
	public virtual void SetTextureExtent(IntPtr _arg)
	{
		vtkDataTransferHelper_SetTextureExtent_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataTransferHelper_Upload_39(HandleRef pThis, int components, IntPtr componentList);

	/// <summary>
	/// Old comment.
	/// Upload Extent from CPU data buffer to GPU.
	/// The WholeExtent must match the Array size.
	/// New comment.
	/// Upload GPUExtent from CPU vtkDataArray to GPU texture.
	/// It is possible to send a subset of the components or to specify and
	/// order of components or both. If components=0, componentList is ignored
	/// and all components are passed, a texture cannot have more than 4
	/// components.
	/// \pre array_exists: array!=0
	/// \pre array_not_empty: array-&gt;GetNumberOfTuples()&gt;0
	/// \pre valid_cpu_extent: this-&gt;GetCPUExtentIsValid()
	/// \pre valid_cpu_extent_size:
	/// (CPUExtent[1]-CPUExtent[0]+1)*(CPUExtent[3]-CPUExtent[2]+1)*(CPUExtent[5]-CPUExtent[4]+1)==array-&gt;GetNumberOfTuples()
	/// \pre valid_gpu_extent: this-&gt;GetGPUExtentIsValid()
	/// \pre gpu_extent_in_cpu_extent: CPUExtent[0]&lt;=GPUExtent[0] &amp;&amp; GPUExtent[1]&lt;=CPUExtent[1] &amp;&amp;
	/// CPUExtent[2]&lt;=GPUExtent[2] &amp;&amp; GPUExtent[3]&lt;=CPUExtent[3] &amp;&amp; CPUExtent[4]&lt;=GPUExtent[4] &amp;&amp;
	/// GPUExtent[5]&lt;=CPUExtent[5] \pre gpu_texture_size: !this-&gt;GetTextureExtentIsValid() ||
	/// (GPUExtent[1]-GPUExtent[0]+1)*(GPUExtent[3]-GPUExtent[2]+1)*(GPUExtent[5]-GPUExtent[4]+1)==(TextureExtent[1]-TextureExtent[0]+1)*(TextureExtent[3]-TextureExtent[2]+1)*(TextureExtent[5]-TextureExtent[4]+1)
	/// \pre texture_can_exist_or_not: texture==0 || texture!=0
	/// \pre valid_components: (components==0 &amp;&amp; componentList==0 &amp;&amp; array-&gt;GetNumberOfComponents()&lt;=4)
	/// || (components&gt;=1 &amp;&amp; components&lt;=array-&gt;GetNumberOfComponents() &amp;&amp; components&lt;=4 &amp;&amp;
	/// componentList!=0)
	/// </summary>
	public bool Upload(int components, IntPtr componentList)
	{
		return (vtkDataTransferHelper_Upload_39(GetCppThis(), components, componentList) != 0) ? true : false;
	}
}
