using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGLTFWriter
/// </summary>
/// <remarks>
///    export a scene into GLTF 2.0 format.
///
/// vtkGLTFWriter is a concrete subclass of vtkWriter that writes GLTF
/// 2.0 files. Its input is a multiblock dataset as it is produced by
/// the CityGML reader. The dataset contains a list of buildings, a mesh
/// or a point cloud.
///
/// For buildings, each building is made of pieces (polydata), each
/// piece could potentially have a different texture. The mesh input
/// is the same as one building. The point cloud input, is the same as
/// mesh input but with Verts instead of Polys.
///
/// Materials, including textures, are described as fields in the
/// polydata. If InlineData is false, we only refer to textures files
/// referred in the data, otherwise we read the textures and save them
/// encoded in the file.
///
/// </remarks>
/// <seealso>
///
/// vtkCityGMLReader
/// vtkPolyData
/// </seealso>
public class vtkGLTFWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGLTFWriter()
	{
		MRClassNameKey = "class vtkGLTFWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGLTFWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFWriter New()
	{
		vtkGLTFWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGLTFWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGLTFWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFWriter_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify the name of the GLTF file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkGLTFWriter_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFWriter_GetInlineData_02(HandleRef pThis);

	/// <summary>
	/// Should the binary data be included in the json file as a base64
	/// string.
	/// </summary>
	public virtual bool GetInlineData()
	{
		return (vtkGLTFWriter_GetInlineData_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGLTFWriter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFWriter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGLTFWriter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFWriter_GetSaveActivePointColor_05(HandleRef pThis);

	/// <summary>
	/// If true, the writer looks at the active scalar and if it finds a
	/// 3 or 4 component, float, unsigned char or unsigned short it
	/// stores a RGB or RGBA attribute called COLOR_0 in the GLTF
	/// file. The default is false.  Note a float component has to be
	/// bewtween [0, 1] while the unsigned chars and unsigned short are
	/// OpenGL normalized integers (are either between [0, 255] for
	/// unsigned char, they are between [0, 65536] for unsigned short - they
	/// are used to quantize a float between [0, 1]).
	/// </summary>
	public virtual bool GetSaveActivePointColor()
	{
		return (vtkGLTFWriter_GetSaveActivePointColor_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFWriter_GetSaveBatchId_06(HandleRef pThis);

	/// <summary>
	/// It looks for point arrays called
	/// _BATCHID in the data and it saves it in the
	/// GLTF file if found.
	/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
	/// a binary gltf with a mesh that has several objects (buildings).
	/// Objects are indexed from 0 to number of objects - 1, all points
	/// of an objects have the same index. These index values are stored
	/// in _BATCHID
	/// </summary>
	public virtual bool GetSaveBatchId()
	{
		return (vtkGLTFWriter_GetSaveBatchId_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFWriter_GetSaveNormal_07(HandleRef pThis);

	/// <summary>
	/// It looks for the normals point attribute and saves it in the
	/// GLTF file if found with the name NORMAL
	/// Cesium needs this to render buildings correctly
	/// if there is no texture.
	/// </summary>
	public virtual bool GetSaveNormal()
	{
		return (vtkGLTFWriter_GetSaveNormal_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFWriter_GetSaveTextures_08(HandleRef pThis);

	/// <summary>
	/// If true (default) we save textures. We only include a reference to the
	/// texture file unless you want to include the binary data in the json file using
	/// InlineData in which case we have to load the texture in memory and save
	/// it encoded in the json file.
	/// @sa
	/// TextureBaseDirectory
	/// </summary>
	public virtual bool GetSaveTextures()
	{
		return (vtkGLTFWriter_GetSaveTextures_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFWriter_GetTextureBaseDirectory_09(HandleRef pThis);

	/// <summary>
	/// Specify the base directory for texture files.
	/// </summary>
	public virtual string GetTextureBaseDirectory()
	{
		return Marshal.PtrToStringAnsi(vtkGLTFWriter_GetTextureBaseDirectory_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_InlineDataOff_10(HandleRef pThis);

	/// <summary>
	/// Should the binary data be included in the json file as a base64
	/// string.
	/// </summary>
	public virtual void InlineDataOff()
	{
		vtkGLTFWriter_InlineDataOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_InlineDataOn_11(HandleRef pThis);

	/// <summary>
	/// Should the binary data be included in the json file as a base64
	/// string.
	/// </summary>
	public virtual void InlineDataOn()
	{
		vtkGLTFWriter_InlineDataOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFWriter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGLTFWriter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFWriter_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGLTFWriter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFWriter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGLTFWriter NewInstance()
	{
		vtkGLTFWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFWriter_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFWriter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFWriter SafeDownCast(vtkObjectBase o)
	{
		vtkGLTFWriter vtkGLTFWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFWriter_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGLTFWriter2 = (vtkGLTFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGLTFWriter2.Register(null);
			}
		}
		return vtkGLTFWriter2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SaveActivePointColorOff_17(HandleRef pThis);

	/// <summary>
	/// If true, the writer looks at the active scalar and if it finds a
	/// 3 or 4 component, float, unsigned char or unsigned short it
	/// stores a RGB or RGBA attribute called COLOR_0 in the GLTF
	/// file. The default is false.  Note a float component has to be
	/// bewtween [0, 1] while the unsigned chars and unsigned short are
	/// OpenGL normalized integers (are either between [0, 255] for
	/// unsigned char, they are between [0, 65536] for unsigned short - they
	/// are used to quantize a float between [0, 1]).
	/// </summary>
	public virtual void SaveActivePointColorOff()
	{
		vtkGLTFWriter_SaveActivePointColorOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SaveActivePointColorOn_18(HandleRef pThis);

	/// <summary>
	/// If true, the writer looks at the active scalar and if it finds a
	/// 3 or 4 component, float, unsigned char or unsigned short it
	/// stores a RGB or RGBA attribute called COLOR_0 in the GLTF
	/// file. The default is false.  Note a float component has to be
	/// bewtween [0, 1] while the unsigned chars and unsigned short are
	/// OpenGL normalized integers (are either between [0, 255] for
	/// unsigned char, they are between [0, 65536] for unsigned short - they
	/// are used to quantize a float between [0, 1]).
	/// </summary>
	public virtual void SaveActivePointColorOn()
	{
		vtkGLTFWriter_SaveActivePointColorOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SaveBatchIdOff_19(HandleRef pThis);

	/// <summary>
	/// It looks for point arrays called
	/// _BATCHID in the data and it saves it in the
	/// GLTF file if found.
	/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
	/// a binary gltf with a mesh that has several objects (buildings).
	/// Objects are indexed from 0 to number of objects - 1, all points
	/// of an objects have the same index. These index values are stored
	/// in _BATCHID
	/// </summary>
	public virtual void SaveBatchIdOff()
	{
		vtkGLTFWriter_SaveBatchIdOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SaveBatchIdOn_20(HandleRef pThis);

	/// <summary>
	/// It looks for point arrays called
	/// _BATCHID in the data and it saves it in the
	/// GLTF file if found.
	/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
	/// a binary gltf with a mesh that has several objects (buildings).
	/// Objects are indexed from 0 to number of objects - 1, all points
	/// of an objects have the same index. These index values are stored
	/// in _BATCHID
	/// </summary>
	public virtual void SaveBatchIdOn()
	{
		vtkGLTFWriter_SaveBatchIdOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SaveNormalOff_21(HandleRef pThis);

	/// <summary>
	/// It looks for the normals point attribute and saves it in the
	/// GLTF file if found with the name NORMAL
	/// Cesium needs this to render buildings correctly
	/// if there is no texture.
	/// </summary>
	public virtual void SaveNormalOff()
	{
		vtkGLTFWriter_SaveNormalOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SaveNormalOn_22(HandleRef pThis);

	/// <summary>
	/// It looks for the normals point attribute and saves it in the
	/// GLTF file if found with the name NORMAL
	/// Cesium needs this to render buildings correctly
	/// if there is no texture.
	/// </summary>
	public virtual void SaveNormalOn()
	{
		vtkGLTFWriter_SaveNormalOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SaveTexturesOff_23(HandleRef pThis);

	/// <summary>
	/// If true (default) we save textures. We only include a reference to the
	/// texture file unless you want to include the binary data in the json file using
	/// InlineData in which case we have to load the texture in memory and save
	/// it encoded in the json file.
	/// @sa
	/// TextureBaseDirectory
	/// </summary>
	public virtual void SaveTexturesOff()
	{
		vtkGLTFWriter_SaveTexturesOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SaveTexturesOn_24(HandleRef pThis);

	/// <summary>
	/// If true (default) we save textures. We only include a reference to the
	/// texture file unless you want to include the binary data in the json file using
	/// InlineData in which case we have to load the texture in memory and save
	/// it encoded in the json file.
	/// @sa
	/// TextureBaseDirectory
	/// </summary>
	public virtual void SaveTexturesOn()
	{
		vtkGLTFWriter_SaveTexturesOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SetFileName_25(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the GLTF file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkGLTFWriter_SetFileName_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SetInlineData_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Should the binary data be included in the json file as a base64
	/// string.
	/// </summary>
	public virtual void SetInlineData(bool _arg)
	{
		vtkGLTFWriter_SetInlineData_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SetSaveActivePointColor_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, the writer looks at the active scalar and if it finds a
	/// 3 or 4 component, float, unsigned char or unsigned short it
	/// stores a RGB or RGBA attribute called COLOR_0 in the GLTF
	/// file. The default is false.  Note a float component has to be
	/// bewtween [0, 1] while the unsigned chars and unsigned short are
	/// OpenGL normalized integers (are either between [0, 255] for
	/// unsigned char, they are between [0, 65536] for unsigned short - they
	/// are used to quantize a float between [0, 1]).
	/// </summary>
	public virtual void SetSaveActivePointColor(bool _arg)
	{
		vtkGLTFWriter_SetSaveActivePointColor_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SetSaveBatchId_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// It looks for point arrays called
	/// _BATCHID in the data and it saves it in the
	/// GLTF file if found.
	/// _BATCHID is an index used in 3D Tiles b3dm format. This format stores
	/// a binary gltf with a mesh that has several objects (buildings).
	/// Objects are indexed from 0 to number of objects - 1, all points
	/// of an objects have the same index. These index values are stored
	/// in _BATCHID
	/// </summary>
	public virtual void SetSaveBatchId(bool _arg)
	{
		vtkGLTFWriter_SetSaveBatchId_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SetSaveNormal_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// It looks for the normals point attribute and saves it in the
	/// GLTF file if found with the name NORMAL
	/// Cesium needs this to render buildings correctly
	/// if there is no texture.
	/// </summary>
	public virtual void SetSaveNormal(bool _arg)
	{
		vtkGLTFWriter_SetSaveNormal_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SetSaveTextures_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true (default) we save textures. We only include a reference to the
	/// texture file unless you want to include the binary data in the json file using
	/// InlineData in which case we have to load the texture in memory and save
	/// it encoded in the json file.
	/// @sa
	/// TextureBaseDirectory
	/// </summary>
	public virtual void SetSaveTextures(bool _arg)
	{
		vtkGLTFWriter_SetSaveTextures_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFWriter_SetTextureBaseDirectory_31(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the base directory for texture files.
	/// </summary>
	public virtual void SetTextureBaseDirectory(string _arg)
	{
		vtkGLTFWriter_SetTextureBaseDirectory_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkGLTFWriter_WriteToString_32(HandleRef pThis);

	/// <summary>
	/// Write the result to a string instead of a file
	/// </summary>
	public string WriteToString()
	{
		return vtkGLTFWriter_WriteToString_32(GetCppThis());
	}
}
