using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCesium3DTilesWriter
/// </summary>
/// <remarks>
///    Writes a dataset into 3D Tiles format.
///
///
/// Valid inputs include the vtkMultiBlockDataSet (as created by
/// vtkCityGMLReader) storing 3D buidlings, vtkPointSet storing a point
/// cloud or vtkPolyData for storing a mesh.
///
/// </remarks>
public class vtkCesium3DTilesWriter : vtkWriter
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum InputType
	{
		/// <summary>enum member</summary>
		Buildings = 0,
		/// <summary>enum member</summary>
		Mesh = 2,
		/// <summary>enum member</summary>
		Points = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCesium3DTilesWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCesium3DTilesWriter()
	{
		MRClassNameKey = "class vtkCesium3DTilesWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCesium3DTilesWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCesium3DTilesWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesium3DTilesWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCesium3DTilesWriter New()
	{
		vtkCesium3DTilesWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCesium3DTilesWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCesium3DTilesWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCesium3DTilesWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCesium3DTilesWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_ContentGLTFOff_01(HandleRef pThis);

	/// <summary>
	/// What is the file type used to save tiles. If ContentGLTF is false
	/// (the default) we use B3DM for Buildings or Mesh and PNTS for
	/// PointCloud otherwise  we use GLB (3DTILES_content_gltf
	/// extension).  If the file type is B3DM or GLB, external programs are
	/// needed to convert GLTF -&gt; GLB -&gt; B3DM.
	///
	/// </summary>
	public virtual void ContentGLTFOff()
	{
		vtkCesium3DTilesWriter_ContentGLTFOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_ContentGLTFOn_02(HandleRef pThis);

	/// <summary>
	/// What is the file type used to save tiles. If ContentGLTF is false
	/// (the default) we use B3DM for Buildings or Mesh and PNTS for
	/// PointCloud otherwise  we use GLB (3DTILES_content_gltf
	/// extension).  If the file type is B3DM or GLB, external programs are
	/// needed to convert GLTF -&gt; GLB -&gt; B3DM.
	///
	/// </summary>
	public virtual void ContentGLTFOn()
	{
		vtkCesium3DTilesWriter_ContentGLTFOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesium3DTilesWriter_GetCRS_03(HandleRef pThis);

	/// <summary>
	/// Set the coordinate reference system (CRS) also known as spatial reference system (SRC),
	/// such as EPSG:2263. This string can also be a proj string such as
	/// "+proj=utm +zone=17 +datum=WGS84"
	/// </summary>
	public virtual string GetCRS()
	{
		return Marshal.PtrToStringAnsi(vtkCesium3DTilesWriter_GetCRS_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCesium3DTilesWriter_GetContentGLTF_04(HandleRef pThis);

	/// <summary>
	/// What is the file type used to save tiles. If ContentGLTF is false
	/// (the default) we use B3DM for Buildings or Mesh and PNTS for
	/// PointCloud otherwise  we use GLB (3DTILES_content_gltf
	/// extension).  If the file type is B3DM or GLB, external programs are
	/// needed to convert GLTF -&gt; GLB -&gt; B3DM.
	///
	/// </summary>
	public virtual bool GetContentGLTF()
	{
		return (vtkCesium3DTilesWriter_GetContentGLTF_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesium3DTilesWriter_GetDirectoryName_05(HandleRef pThis);

	/// <summary>
	/// Accessor for name of the directory where Cesium3DTiles data is written
	/// </summary>
	public virtual string GetDirectoryName()
	{
		return Marshal.PtrToStringAnsi(vtkCesium3DTilesWriter_GetDirectoryName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCesium3DTilesWriter_GetInputType_06(HandleRef pThis);

	/// <summary>
	/// Input is Buildings, Points or Mesh.
	/// </summary>
	public virtual int GetInputType()
	{
		return vtkCesium3DTilesWriter_GetInputType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCesium3DTilesWriter_GetMergeTilePolyData_07(HandleRef pThis);

	/// <summary>
	/// Merge all meshes in each tile to end up with one mesh per tile.
	/// Default is false which means that we expect an external program to merge
	/// the meshes in each tile to improve performance (such as meshoptimizer).
	/// otherwise we merge the polydata in VTK.
	/// @see
	/// https://meshoptimizer.org/
	/// </summary>
	public virtual bool GetMergeTilePolyData()
	{
		return (vtkCesium3DTilesWriter_GetMergeTilePolyData_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCesium3DTilesWriter_GetNumberOfFeaturesPerTile_08(HandleRef pThis);

	/// <summary>
	/// Maximum number of buildings per tile in case of buildings input or
	/// the number of points per tile in case of point cloud input. Default is 100.
	/// </summary>
	public virtual int GetNumberOfFeaturesPerTile()
	{
		return vtkCesium3DTilesWriter_GetNumberOfFeaturesPerTile_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCesium3DTilesWriter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCesium3DTilesWriter_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCesium3DTilesWriter_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCesium3DTilesWriter_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesium3DTilesWriter_GetOffset_11(HandleRef pThis);

	/// <summary>
	/// Data coordinates are relative to this origin. To get the actual
	/// coordinates data has to be translated with the Offset.
	/// </summary>
	public virtual double[] GetOffset()
	{
		IntPtr intPtr = vtkCesium3DTilesWriter_GetOffset_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_GetOffset_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Data coordinates are relative to this origin. To get the actual
	/// coordinates data has to be translated with the Offset.
	/// </summary>
	public virtual void GetOffset(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCesium3DTilesWriter_GetOffset_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_GetOffset_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Data coordinates are relative to this origin. To get the actual
	/// coordinates data has to be translated with the Offset.
	/// </summary>
	public virtual void GetOffset(IntPtr _arg)
	{
		vtkCesium3DTilesWriter_GetOffset_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCesium3DTilesWriter_GetSaveTextures_14(HandleRef pThis);

	/// <summary>
	/// Save textures as part of the 3D Tiles dataset. Default true.
	/// Otherwise save only the mesh.
	/// </summary>
	public virtual bool GetSaveTextures()
	{
		return (vtkCesium3DTilesWriter_GetSaveTextures_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCesium3DTilesWriter_GetSaveTiles_15(HandleRef pThis);

	/// <summary>
	/// Save the tiles (B3DMs) as part of the 3D Tiles dataset. Default true.
	/// Otherwise save only the tileset (JSON) file. This is mainly used for
	/// debugging. Default true.
	/// </summary>
	public virtual bool GetSaveTiles()
	{
		return (vtkCesium3DTilesWriter_GetSaveTiles_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesium3DTilesWriter_GetTextureBaseDirectory_16(HandleRef pThis);

	/// <summary>
	/// Path used to prefix all texture paths stored as fields in the input data.
	/// @see vtkCityGMLReader
	/// </summary>
	public virtual string GetTextureBaseDirectory()
	{
		return Marshal.PtrToStringAnsi(vtkCesium3DTilesWriter_GetTextureBaseDirectory_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCesium3DTilesWriter_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCesium3DTilesWriter_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCesium3DTilesWriter_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCesium3DTilesWriter_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_MergeTilePolyDataOff_19(HandleRef pThis);

	/// <summary>
	/// Merge all meshes in each tile to end up with one mesh per tile.
	/// Default is false which means that we expect an external program to merge
	/// the meshes in each tile to improve performance (such as meshoptimizer).
	/// otherwise we merge the polydata in VTK.
	/// @see
	/// https://meshoptimizer.org/
	/// </summary>
	public virtual void MergeTilePolyDataOff()
	{
		vtkCesium3DTilesWriter_MergeTilePolyDataOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_MergeTilePolyDataOn_20(HandleRef pThis);

	/// <summary>
	/// Merge all meshes in each tile to end up with one mesh per tile.
	/// Default is false which means that we expect an external program to merge
	/// the meshes in each tile to improve performance (such as meshoptimizer).
	/// otherwise we merge the polydata in VTK.
	/// @see
	/// https://meshoptimizer.org/
	/// </summary>
	public virtual void MergeTilePolyDataOn()
	{
		vtkCesium3DTilesWriter_MergeTilePolyDataOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesium3DTilesWriter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCesium3DTilesWriter NewInstance()
	{
		vtkCesium3DTilesWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCesium3DTilesWriter_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCesium3DTilesWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCesium3DTilesWriter_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCesium3DTilesWriter SafeDownCast(vtkObjectBase o)
	{
		vtkCesium3DTilesWriter vtkCesium3DTilesWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCesium3DTilesWriter_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCesium3DTilesWriter2 = (vtkCesium3DTilesWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCesium3DTilesWriter2.Register(null);
			}
		}
		return vtkCesium3DTilesWriter2;
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SaveTexturesOff_24(HandleRef pThis);

	/// <summary>
	/// Save textures as part of the 3D Tiles dataset. Default true.
	/// Otherwise save only the mesh.
	/// </summary>
	public virtual void SaveTexturesOff()
	{
		vtkCesium3DTilesWriter_SaveTexturesOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SaveTexturesOn_25(HandleRef pThis);

	/// <summary>
	/// Save textures as part of the 3D Tiles dataset. Default true.
	/// Otherwise save only the mesh.
	/// </summary>
	public virtual void SaveTexturesOn()
	{
		vtkCesium3DTilesWriter_SaveTexturesOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SaveTilesOff_26(HandleRef pThis);

	/// <summary>
	/// Save the tiles (B3DMs) as part of the 3D Tiles dataset. Default true.
	/// Otherwise save only the tileset (JSON) file. This is mainly used for
	/// debugging. Default true.
	/// </summary>
	public virtual void SaveTilesOff()
	{
		vtkCesium3DTilesWriter_SaveTilesOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SaveTilesOn_27(HandleRef pThis);

	/// <summary>
	/// Save the tiles (B3DMs) as part of the 3D Tiles dataset. Default true.
	/// Otherwise save only the tileset (JSON) file. This is mainly used for
	/// debugging. Default true.
	/// </summary>
	public virtual void SaveTilesOn()
	{
		vtkCesium3DTilesWriter_SaveTilesOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetCRS_28(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the coordinate reference system (CRS) also known as spatial reference system (SRC),
	/// such as EPSG:2263. This string can also be a proj string such as
	/// "+proj=utm +zone=17 +datum=WGS84"
	/// </summary>
	public virtual void SetCRS(string _arg)
	{
		vtkCesium3DTilesWriter_SetCRS_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetContentGLTF_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// What is the file type used to save tiles. If ContentGLTF is false
	/// (the default) we use B3DM for Buildings or Mesh and PNTS for
	/// PointCloud otherwise  we use GLB (3DTILES_content_gltf
	/// extension).  If the file type is B3DM or GLB, external programs are
	/// needed to convert GLTF -&gt; GLB -&gt; B3DM.
	///
	/// </summary>
	public virtual void SetContentGLTF(bool _arg)
	{
		vtkCesium3DTilesWriter_SetContentGLTF_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetDirectoryName_30(HandleRef pThis, string _arg);

	/// <summary>
	/// Accessor for name of the directory where Cesium3DTiles data is written
	/// </summary>
	public virtual void SetDirectoryName(string _arg)
	{
		vtkCesium3DTilesWriter_SetDirectoryName_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetInputType_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Input is Buildings, Points or Mesh.
	/// </summary>
	public virtual void SetInputType(int _arg)
	{
		vtkCesium3DTilesWriter_SetInputType_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetMergeTilePolyData_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Merge all meshes in each tile to end up with one mesh per tile.
	/// Default is false which means that we expect an external program to merge
	/// the meshes in each tile to improve performance (such as meshoptimizer).
	/// otherwise we merge the polydata in VTK.
	/// @see
	/// https://meshoptimizer.org/
	/// </summary>
	public virtual void SetMergeTilePolyData(bool _arg)
	{
		vtkCesium3DTilesWriter_SetMergeTilePolyData_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetNumberOfFeaturesPerTile_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Maximum number of buildings per tile in case of buildings input or
	/// the number of points per tile in case of point cloud input. Default is 100.
	/// </summary>
	public virtual void SetNumberOfFeaturesPerTile(int _arg)
	{
		vtkCesium3DTilesWriter_SetNumberOfFeaturesPerTile_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetOffset_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Data coordinates are relative to this origin. To get the actual
	/// coordinates data has to be translated with the Offset.
	/// </summary>
	public virtual void SetOffset(double _arg1, double _arg2, double _arg3)
	{
		vtkCesium3DTilesWriter_SetOffset_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetOffset_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Data coordinates are relative to this origin. To get the actual
	/// coordinates data has to be translated with the Offset.
	/// </summary>
	public virtual void SetOffset(IntPtr _arg)
	{
		vtkCesium3DTilesWriter_SetOffset_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetSaveTextures_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Save textures as part of the 3D Tiles dataset. Default true.
	/// Otherwise save only the mesh.
	/// </summary>
	public virtual void SetSaveTextures(bool _arg)
	{
		vtkCesium3DTilesWriter_SetSaveTextures_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetSaveTiles_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// Save the tiles (B3DMs) as part of the 3D Tiles dataset. Default true.
	/// Otherwise save only the tileset (JSON) file. This is mainly used for
	/// debugging. Default true.
	/// </summary>
	public virtual void SetSaveTiles(bool _arg)
	{
		vtkCesium3DTilesWriter_SetSaveTiles_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCesium3DTilesWriter_SetTextureBaseDirectory_38(HandleRef pThis, string _arg);

	/// <summary>
	/// Path used to prefix all texture paths stored as fields in the input data.
	/// @see vtkCityGMLReader
	/// </summary>
	public virtual void SetTextureBaseDirectory(string _arg)
	{
		vtkCesium3DTilesWriter_SetTextureBaseDirectory_38(GetCppThis(), _arg);
	}
}
