using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRIBExporter
/// </summary>
/// <remarks>
///    export a scene into RenderMan RIB format.
///
/// vtkRIBExporter is a concrete subclass of vtkExporter that writes a
/// Renderman .RIB files. The input specifies a vtkRenderWindow. All
/// visible actors and lights will be included in the rib file. The
/// following file naming conventions apply:
///   rib file - FilePrefix.rib
///   image file created by RenderMan - FilePrefix.tif
///   texture files - TexturePrefix_0xADDR_MTIME.tif
/// This object does NOT generate an image file. The user must run either
/// RenderMan or a RenderMan emulator like Blue Moon Ray Tracer (BMRT).
/// vtk properties are convert to Renderman shaders as follows:
///   Normal property, no texture map - plastic.sl
///   Normal property with texture map - txtplastic.sl
/// These two shaders must be compiled by the rendering package being
/// used.  vtkRIBExporter also supports custom shaders. The shaders are
/// written using the Renderman Shading Language. See "The Renderman
/// Companion", ISBN 0-201-50868, 1989 for details on writing shaders.
/// vtkRIBProperty specifies the declarations and parameter settings for
/// custom shaders.
///
/// </remarks>
/// <seealso>
///
/// vtkExporter vtkRIBProperty vtkRIBLight
/// </seealso>
public class vtkRIBExporter : vtkExporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRIBExporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRIBExporter()
	{
		MRClassNameKey = "class vtkRIBExporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRIBExporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRIBExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRIBExporter New()
	{
		vtkRIBExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRIBExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRIBExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRIBExporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRIBExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_BackgroundOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the background flag. Default is 0 (off).
	/// If set, the rib file will contain an
	/// image shader that will use the renderer window's background
	/// color. Normally, RenderMan does generate backgrounds. Backgrounds are
	/// composited into the scene with the tiffcomp program that comes with
	/// Pixar's RenderMan Toolkit.  In fact, Pixar's Renderman will accept an
	/// image shader but only sets the alpha of the background. Images created
	/// this way will still have a black background but contain an alpha of 1
	/// at all pixels and CANNOT be subsequently composited with other images
	/// using tiffcomp.  However, other RenderMan compliant renderers like
	/// Blue Moon Ray Tracing (BMRT) do allow image shaders and properly set
	/// the background color. If this sounds too confusing, use the following
	/// rules: If you are using Pixar's Renderman, leave the Background
	/// off. Otherwise, try setting BackGroundOn and see if you get the
	/// desired results.
	/// </summary>
	public virtual void BackgroundOff()
	{
		vtkRIBExporter_BackgroundOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_BackgroundOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the background flag. Default is 0 (off).
	/// If set, the rib file will contain an
	/// image shader that will use the renderer window's background
	/// color. Normally, RenderMan does generate backgrounds. Backgrounds are
	/// composited into the scene with the tiffcomp program that comes with
	/// Pixar's RenderMan Toolkit.  In fact, Pixar's Renderman will accept an
	/// image shader but only sets the alpha of the background. Images created
	/// this way will still have a black background but contain an alpha of 1
	/// at all pixels and CANNOT be subsequently composited with other images
	/// using tiffcomp.  However, other RenderMan compliant renderers like
	/// Blue Moon Ray Tracing (BMRT) do allow image shaders and properly set
	/// the background color. If this sounds too confusing, use the following
	/// rules: If you are using Pixar's Renderman, leave the Background
	/// off. Otherwise, try setting BackGroundOn and see if you get the
	/// desired results.
	/// </summary>
	public virtual void BackgroundOn()
	{
		vtkRIBExporter_BackgroundOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_ExportArraysOff_03(HandleRef pThis);

	/// <summary>
	/// Set or get the ExportArrays. If ExportArrays is set, then
	/// all point data, field data, and cell data arrays will get
	/// exported together with polygons. Default is Off (0).
	/// </summary>
	public virtual void ExportArraysOff()
	{
		vtkRIBExporter_ExportArraysOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_ExportArraysOn_04(HandleRef pThis);

	/// <summary>
	/// Set or get the ExportArrays. If ExportArrays is set, then
	/// all point data, field data, and cell data arrays will get
	/// exported together with polygons. Default is Off (0).
	/// </summary>
	public virtual void ExportArraysOn()
	{
		vtkRIBExporter_ExportArraysOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRIBExporter_GetBackground_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the background flag. Default is 0 (off).
	/// If set, the rib file will contain an
	/// image shader that will use the renderer window's background
	/// color. Normally, RenderMan does generate backgrounds. Backgrounds are
	/// composited into the scene with the tiffcomp program that comes with
	/// Pixar's RenderMan Toolkit.  In fact, Pixar's Renderman will accept an
	/// image shader but only sets the alpha of the background. Images created
	/// this way will still have a black background but contain an alpha of 1
	/// at all pixels and CANNOT be subsequently composited with other images
	/// using tiffcomp.  However, other RenderMan compliant renderers like
	/// Blue Moon Ray Tracing (BMRT) do allow image shaders and properly set
	/// the background color. If this sounds too confusing, use the following
	/// rules: If you are using Pixar's Renderman, leave the Background
	/// off. Otherwise, try setting BackGroundOn and see if you get the
	/// desired results.
	/// </summary>
	public virtual int GetBackground()
	{
		return vtkRIBExporter_GetBackground_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRIBExporter_GetExportArrays_06(HandleRef pThis);

	/// <summary>
	/// Set or get the ExportArrays. If ExportArrays is set, then
	/// all point data, field data, and cell data arrays will get
	/// exported together with polygons. Default is Off (0).
	/// </summary>
	public virtual int GetExportArrays()
	{
		return vtkRIBExporter_GetExportArrays_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRIBExporter_GetExportArraysMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set or get the ExportArrays. If ExportArrays is set, then
	/// all point data, field data, and cell data arrays will get
	/// exported together with polygons. Default is Off (0).
	/// </summary>
	public virtual int GetExportArraysMaxValue()
	{
		return vtkRIBExporter_GetExportArraysMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRIBExporter_GetExportArraysMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set or get the ExportArrays. If ExportArrays is set, then
	/// all point data, field data, and cell data arrays will get
	/// exported together with polygons. Default is Off (0).
	/// </summary>
	public virtual int GetExportArraysMinValue()
	{
		return vtkRIBExporter_GetExportArraysMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBExporter_GetFilePrefix_09(HandleRef pThis);

	/// <summary>
	/// Specify the prefix of the files to write out. The resulting file names
	/// will have .rib appended to them.
	/// </summary>
	public virtual string GetFilePrefix()
	{
		return Marshal.PtrToStringAnsi(vtkRIBExporter_GetFilePrefix_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRIBExporter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRIBExporter_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRIBExporter_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRIBExporter_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBExporter_GetPixelSamples_12(HandleRef pThis);

	/// <summary>
	/// Specify the sampling rate for the rendering. Default is 2 2.
	/// </summary>
	public virtual int[] GetPixelSamples()
	{
		IntPtr intPtr = vtkRIBExporter_GetPixelSamples_12(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_GetPixelSamples_13(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the sampling rate for the rendering. Default is 2 2.
	/// </summary>
	public virtual void GetPixelSamples(IntPtr data)
	{
		vtkRIBExporter_GetPixelSamples_13(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBExporter_GetSize_14(HandleRef pThis);

	/// <summary>
	/// Specify the size of the image for RenderMan. If none is specified, the
	/// size of the render window will be used.
	/// </summary>
	public virtual int[] GetSize()
	{
		IntPtr intPtr = vtkRIBExporter_GetSize_14(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_GetSize_15(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the size of the image for RenderMan. If none is specified, the
	/// size of the render window will be used.
	/// </summary>
	public virtual void GetSize(IntPtr data)
	{
		vtkRIBExporter_GetSize_15(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBExporter_GetTexturePrefix_16(HandleRef pThis);

	/// <summary>
	/// Specify the prefix of any generated texture files.
	/// </summary>
	public virtual string GetTexturePrefix()
	{
		return Marshal.PtrToStringAnsi(vtkRIBExporter_GetTexturePrefix_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRIBExporter_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRIBExporter_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRIBExporter_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRIBExporter_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBExporter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRIBExporter NewInstance()
	{
		vtkRIBExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRIBExporter_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRIBExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBExporter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRIBExporter SafeDownCast(vtkObjectBase o)
	{
		vtkRIBExporter vtkRIBExporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRIBExporter_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRIBExporter2 = (vtkRIBExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRIBExporter2.Register(null);
			}
		}
		return vtkRIBExporter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_SetBackground_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the background flag. Default is 0 (off).
	/// If set, the rib file will contain an
	/// image shader that will use the renderer window's background
	/// color. Normally, RenderMan does generate backgrounds. Backgrounds are
	/// composited into the scene with the tiffcomp program that comes with
	/// Pixar's RenderMan Toolkit.  In fact, Pixar's Renderman will accept an
	/// image shader but only sets the alpha of the background. Images created
	/// this way will still have a black background but contain an alpha of 1
	/// at all pixels and CANNOT be subsequently composited with other images
	/// using tiffcomp.  However, other RenderMan compliant renderers like
	/// Blue Moon Ray Tracing (BMRT) do allow image shaders and properly set
	/// the background color. If this sounds too confusing, use the following
	/// rules: If you are using Pixar's Renderman, leave the Background
	/// off. Otherwise, try setting BackGroundOn and see if you get the
	/// desired results.
	/// </summary>
	public virtual void SetBackground(int _arg)
	{
		vtkRIBExporter_SetBackground_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_SetExportArrays_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set or get the ExportArrays. If ExportArrays is set, then
	/// all point data, field data, and cell data arrays will get
	/// exported together with polygons. Default is Off (0).
	/// </summary>
	public virtual void SetExportArrays(int _arg)
	{
		vtkRIBExporter_SetExportArrays_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_SetFilePrefix_24(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the prefix of the files to write out. The resulting file names
	/// will have .rib appended to them.
	/// </summary>
	public virtual void SetFilePrefix(string _arg)
	{
		vtkRIBExporter_SetFilePrefix_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_SetPixelSamples_25(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify the sampling rate for the rendering. Default is 2 2.
	/// </summary>
	public virtual void SetPixelSamples(int _arg1, int _arg2)
	{
		vtkRIBExporter_SetPixelSamples_25(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_SetPixelSamples_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the sampling rate for the rendering. Default is 2 2.
	/// </summary>
	public void SetPixelSamples(IntPtr _arg)
	{
		vtkRIBExporter_SetPixelSamples_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_SetSize_27(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify the size of the image for RenderMan. If none is specified, the
	/// size of the render window will be used.
	/// </summary>
	public virtual void SetSize(int _arg1, int _arg2)
	{
		vtkRIBExporter_SetSize_27(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_SetSize_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the size of the image for RenderMan. If none is specified, the
	/// size of the render window will be used.
	/// </summary>
	public void SetSize(IntPtr _arg)
	{
		vtkRIBExporter_SetSize_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBExporter_SetTexturePrefix_29(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the prefix of any generated texture files.
	/// </summary>
	public virtual void SetTexturePrefix(string _arg)
	{
		vtkRIBExporter_SetTexturePrefix_29(GetCppThis(), _arg);
	}
}
