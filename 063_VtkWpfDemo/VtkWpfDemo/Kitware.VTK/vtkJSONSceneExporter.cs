using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkJSONSceneExporter
/// </summary>
/// <remarks>
///    Export the content of a vtkRenderWindow into a directory with
///          a JSON meta file describing the scene along with the http datasets
///
/// @warning
/// This writer assume LittleEndian by default. Additional work should be done to properly
/// handle endianness.
/// </remarks>
public class vtkJSONSceneExporter : vtkExporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkJSONSceneExporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkJSONSceneExporter()
	{
		MRClassNameKey = "class vtkJSONSceneExporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkJSONSceneExporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkJSONSceneExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONSceneExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJSONSceneExporter New()
	{
		vtkJSONSceneExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONSceneExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJSONSceneExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkJSONSceneExporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkJSONSceneExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkJSONSceneExporter_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify file name of vtk data file to write.
	/// This correspond to the root directory of the data to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkJSONSceneExporter_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJSONSceneExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkJSONSceneExporter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJSONSceneExporter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkJSONSceneExporter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkJSONSceneExporter_GetPolyLODsBaseSize_04(HandleRef pThis);

	/// <summary>
	/// The base size to be used for poly LODs. The poly LODs will stop
	/// being written out when one is smaller than this size, or if the
	/// difference in the sizes of the two most recent LODs is less
	/// than 5%.
	/// Default is 100 KB. Units are in bytes.
	/// </summary>
	public virtual ulong GetPolyLODsBaseSize()
	{
		return vtkJSONSceneExporter_GetPolyLODsBaseSize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONSceneExporter_GetPolyLODsBaseUrl_05(HandleRef pThis);

	/// <summary>
	/// The base URL to be used for poly LODs.
	/// Default is nullptr.
	/// </summary>
	public virtual string GetPolyLODsBaseUrl()
	{
		return Marshal.PtrToStringAnsi(vtkJSONSceneExporter_GetPolyLODsBaseUrl_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkJSONSceneExporter_GetTextureLODsBaseSize_06(HandleRef pThis);

	/// <summary>
	/// The base size to be used for texture LODs. The texture LODs will
	/// stop being written out when one is smaller than this size.
	/// Default is 100 KB. Units are in bytes.
	/// </summary>
	public virtual ulong GetTextureLODsBaseSize()
	{
		return vtkJSONSceneExporter_GetTextureLODsBaseSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONSceneExporter_GetTextureLODsBaseUrl_07(HandleRef pThis);

	/// <summary>
	/// The base URL to be used for texture LODs.
	/// Default is nullptr.
	/// </summary>
	public virtual string GetTextureLODsBaseUrl()
	{
		return Marshal.PtrToStringAnsi(vtkJSONSceneExporter_GetTextureLODsBaseUrl_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkJSONSceneExporter_GetWritePolyLODs_08(HandleRef pThis);

	/// <summary>
	/// Whether or not to write poly LODs.
	/// This will write out the poly LOD sources in a series of decreasing
	/// resolution data sets, which are intended to be uploaded to the
	/// web. vtkQuadricCluster is used to decrease the resolution of the
	/// poly data. Each will be approximately 1/4 the size of the previous
	/// one (unless certain errors occur, and then the defaults for quadric
	/// clustering will be used, which will produce an unknown size). The
	/// files will stop being written out when one is smaller than the
	/// PolyLODsBaseSize, or if the difference in the sizes of the two
	/// most recent LODs is less than 5%. The smallest LOD will be written
	/// into the vtkjs file, rather than with the rest of the LODs.
	/// Default is false.
	/// </summary>
	public virtual bool GetWritePolyLODs()
	{
		return (vtkJSONSceneExporter_GetWritePolyLODs_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkJSONSceneExporter_GetWriteTextureLODs_09(HandleRef pThis);

	/// <summary>
	/// Whether or not to write texture LODs.
	/// This will write out the textures in a series of decreasing
	/// resolution JPEG files, which are intended to be uploaded to the
	/// web. Each file will be 1/4 the size of the previous one. The files
	/// will stop being written out when one is smaller than the
	/// TextureLODsBaseSize.
	/// Default is false.
	/// </summary>
	public virtual bool GetWriteTextureLODs()
	{
		return (vtkJSONSceneExporter_GetWriteTextureLODs_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkJSONSceneExporter_GetWriteTextures_10(HandleRef pThis);

	/// <summary>
	/// Whether or not to write textures.
	/// Textures will be written in JPEG format.
	/// Default is false.
	/// </summary>
	public virtual bool GetWriteTextures()
	{
		return (vtkJSONSceneExporter_GetWriteTextures_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJSONSceneExporter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkJSONSceneExporter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJSONSceneExporter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkJSONSceneExporter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONSceneExporter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkJSONSceneExporter NewInstance()
	{
		vtkJSONSceneExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONSceneExporter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJSONSceneExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONSceneExporter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJSONSceneExporter SafeDownCast(vtkObjectBase o)
	{
		vtkJSONSceneExporter vtkJSONSceneExporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONSceneExporter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkJSONSceneExporter2 = (vtkJSONSceneExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkJSONSceneExporter2.Register(null);
			}
		}
		return vtkJSONSceneExporter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONSceneExporter_SetFileName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of vtk data file to write.
	/// This correspond to the root directory of the data to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkJSONSceneExporter_SetFileName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONSceneExporter_SetPolyLODsBaseSize_17(HandleRef pThis, ulong _arg);

	/// <summary>
	/// The base size to be used for poly LODs. The poly LODs will stop
	/// being written out when one is smaller than this size, or if the
	/// difference in the sizes of the two most recent LODs is less
	/// than 5%.
	/// Default is 100 KB. Units are in bytes.
	/// </summary>
	public virtual void SetPolyLODsBaseSize(ulong _arg)
	{
		vtkJSONSceneExporter_SetPolyLODsBaseSize_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONSceneExporter_SetPolyLODsBaseUrl_18(HandleRef pThis, string _arg);

	/// <summary>
	/// The base URL to be used for poly LODs.
	/// Default is nullptr.
	/// </summary>
	public virtual void SetPolyLODsBaseUrl(string _arg)
	{
		vtkJSONSceneExporter_SetPolyLODsBaseUrl_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONSceneExporter_SetTextureLODsBaseSize_19(HandleRef pThis, ulong _arg);

	/// <summary>
	/// The base size to be used for texture LODs. The texture LODs will
	/// stop being written out when one is smaller than this size.
	/// Default is 100 KB. Units are in bytes.
	/// </summary>
	public virtual void SetTextureLODsBaseSize(ulong _arg)
	{
		vtkJSONSceneExporter_SetTextureLODsBaseSize_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONSceneExporter_SetTextureLODsBaseUrl_20(HandleRef pThis, string _arg);

	/// <summary>
	/// The base URL to be used for texture LODs.
	/// Default is nullptr.
	/// </summary>
	public virtual void SetTextureLODsBaseUrl(string _arg)
	{
		vtkJSONSceneExporter_SetTextureLODsBaseUrl_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONSceneExporter_SetWritePolyLODs_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether or not to write poly LODs.
	/// This will write out the poly LOD sources in a series of decreasing
	/// resolution data sets, which are intended to be uploaded to the
	/// web. vtkQuadricCluster is used to decrease the resolution of the
	/// poly data. Each will be approximately 1/4 the size of the previous
	/// one (unless certain errors occur, and then the defaults for quadric
	/// clustering will be used, which will produce an unknown size). The
	/// files will stop being written out when one is smaller than the
	/// PolyLODsBaseSize, or if the difference in the sizes of the two
	/// most recent LODs is less than 5%. The smallest LOD will be written
	/// into the vtkjs file, rather than with the rest of the LODs.
	/// Default is false.
	/// </summary>
	public virtual void SetWritePolyLODs(bool _arg)
	{
		vtkJSONSceneExporter_SetWritePolyLODs_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONSceneExporter_SetWriteTextureLODs_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether or not to write texture LODs.
	/// This will write out the textures in a series of decreasing
	/// resolution JPEG files, which are intended to be uploaded to the
	/// web. Each file will be 1/4 the size of the previous one. The files
	/// will stop being written out when one is smaller than the
	/// TextureLODsBaseSize.
	/// Default is false.
	/// </summary>
	public virtual void SetWriteTextureLODs(bool _arg)
	{
		vtkJSONSceneExporter_SetWriteTextureLODs_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONSceneExporter_SetWriteTextures_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether or not to write textures.
	/// Textures will be written in JPEG format.
	/// Default is false.
	/// </summary>
	public virtual void SetWriteTextures(bool _arg)
	{
		vtkJSONSceneExporter_SetWriteTextures_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
