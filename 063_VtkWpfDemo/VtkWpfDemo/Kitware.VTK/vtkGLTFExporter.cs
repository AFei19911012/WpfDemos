using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGLTFExporter
/// </summary>
/// <remarks>
///    export a scene into GLTF 2.0 format.
///
/// vtkGLTFExporter is a concrete subclass of vtkExporter that writes GLTF 2.0
/// files. It currently only supports a very small subset of what VTK can do
/// including polygonal meshes with optional vertex colors. Over time the class
/// can be expanded to support more and more of what VTK renders.
///
/// It should be noted that gltf is a format for rendering data. As such
/// it stores what the VTK scene renders as, not the underlying data. For
/// example it currently does not support quads or higher sided polygons
/// although VTK does. As such taking an exported gltf file and then selecting
/// wireframe in a viewer will give all triangles where VTK's rendering
/// would correctly draw the original polygons. etc.
///
/// </remarks>
/// <seealso>
///
/// vtkExporter
/// </seealso>
public class vtkGLTFExporter : vtkExporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFExporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGLTFExporter()
	{
		MRClassNameKey = "class vtkGLTFExporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFExporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGLTFExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFExporter New()
	{
		vtkGLTFExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGLTFExporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGLTFExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkGLTFExporter_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify the name of the GLTF file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkGLTFExporter_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFExporter_GetInlineData_02(HandleRef pThis);

	/// <summary>
	/// Should the binary data be included in the json file as a base64
	/// string.
	/// </summary>
	public virtual bool GetInlineData()
	{
		return (vtkGLTFExporter_GetInlineData_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFExporter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGLTFExporter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFExporter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGLTFExporter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFExporter_GetSaveBatchId_05(HandleRef pThis);

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
		return (vtkGLTFExporter_GetSaveBatchId_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFExporter_GetSaveNormal_06(HandleRef pThis);

	/// <summary>
	/// It looks for a point array called
	/// NORMAL in the data and it saves it in the
	/// GLTF file if found.
	/// NORMAL is the vertex normal. Cesium needs this to render buildings correctly
	/// if there is no texture.
	/// </summary>
	public virtual bool GetSaveNormal()
	{
		return (vtkGLTFExporter_GetSaveNormal_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_InlineDataOff_07(HandleRef pThis);

	/// <summary>
	/// Should the binary data be included in the json file as a base64
	/// string.
	/// </summary>
	public virtual void InlineDataOff()
	{
		vtkGLTFExporter_InlineDataOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_InlineDataOn_08(HandleRef pThis);

	/// <summary>
	/// Should the binary data be included in the json file as a base64
	/// string.
	/// </summary>
	public virtual void InlineDataOn()
	{
		vtkGLTFExporter_InlineDataOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFExporter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGLTFExporter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFExporter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGLTFExporter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFExporter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGLTFExporter NewInstance()
	{
		vtkGLTFExporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFExporter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFExporter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFExporter SafeDownCast(vtkObjectBase o)
	{
		vtkGLTFExporter vtkGLTFExporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFExporter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGLTFExporter2 = (vtkGLTFExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGLTFExporter2.Register(null);
			}
		}
		return vtkGLTFExporter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_SaveBatchIdOff_14(HandleRef pThis);

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
		vtkGLTFExporter_SaveBatchIdOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_SaveBatchIdOn_15(HandleRef pThis);

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
		vtkGLTFExporter_SaveBatchIdOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_SaveNormalOff_16(HandleRef pThis);

	/// <summary>
	/// It looks for a point array called
	/// NORMAL in the data and it saves it in the
	/// GLTF file if found.
	/// NORMAL is the vertex normal. Cesium needs this to render buildings correctly
	/// if there is no texture.
	/// </summary>
	public virtual void SaveNormalOff()
	{
		vtkGLTFExporter_SaveNormalOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_SaveNormalOn_17(HandleRef pThis);

	/// <summary>
	/// It looks for a point array called
	/// NORMAL in the data and it saves it in the
	/// GLTF file if found.
	/// NORMAL is the vertex normal. Cesium needs this to render buildings correctly
	/// if there is no texture.
	/// </summary>
	public virtual void SaveNormalOn()
	{
		vtkGLTFExporter_SaveNormalOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_SetFileName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the GLTF file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkGLTFExporter_SetFileName_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_SetInlineData_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Should the binary data be included in the json file as a base64
	/// string.
	/// </summary>
	public virtual void SetInlineData(bool _arg)
	{
		vtkGLTFExporter_SetInlineData_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_SetSaveBatchId_20(HandleRef pThis, byte _arg);

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
		vtkGLTFExporter_SetSaveBatchId_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFExporter_SetSaveNormal_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// It looks for a point array called
	/// NORMAL in the data and it saves it in the
	/// GLTF file if found.
	/// NORMAL is the vertex normal. Cesium needs this to render buildings correctly
	/// if there is no texture.
	/// </summary>
	public virtual void SetSaveNormal(bool _arg)
	{
		vtkGLTFExporter_SetSaveNormal_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkGLTFExporter_WriteToString_22(HandleRef pThis);

	/// <summary>
	/// Write the result to a string instead of a file
	/// </summary>
	public string WriteToString()
	{
		return vtkGLTFExporter_WriteToString_22(GetCppThis());
	}
}
