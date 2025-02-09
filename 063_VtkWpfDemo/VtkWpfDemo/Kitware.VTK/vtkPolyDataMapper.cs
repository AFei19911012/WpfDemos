using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataMapper
/// </summary>
/// <remarks>
///    map vtkPolyData to graphics primitives
///
/// vtkPolyDataMapper is a class that maps polygonal data (i.e., vtkPolyData)
/// to graphics primitives. vtkPolyDataMapper serves as a superclass for
/// device-specific poly data mappers, that actually do the mapping to the
/// rendering/graphics hardware/software.
/// </remarks>
public class vtkPolyDataMapper : vtkMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataMapper()
	{
		MRClassNameKey = "class vtkPolyDataMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataMapper New()
	{
		vtkPolyDataMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPolyDataMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper_GetBounds_01(HandleRef pThis);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkPolyDataMapper_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkPolyDataMapper_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper_GetGhostLevel_03(HandleRef pThis);

	/// <summary>
	/// Set the number of ghost cells to return.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkPolyDataMapper_GetGhostLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the input data to map.
	/// </summary>
	public new vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper_GetInput_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataMapper_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataMapper_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataMapper_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataMapper_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper_GetNumberOfPieces_07(HandleRef pThis);

	/// <summary>
	/// If you want only a part of the data, specify by setting the piece.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkPolyDataMapper_GetNumberOfPieces_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper_GetNumberOfSubPieces_08(HandleRef pThis);

	/// <summary>
	/// If you want only a part of the data, specify by setting the piece.
	/// </summary>
	public virtual int GetNumberOfSubPieces()
	{
		return vtkPolyDataMapper_GetNumberOfSubPieces_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper_GetPiece_09(HandleRef pThis);

	/// <summary>
	/// If you want only a part of the data, specify by setting the piece.
	/// </summary>
	public virtual int GetPiece()
	{
		return vtkPolyDataMapper_GetPiece_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataMapper_GetSeamlessU_10(HandleRef pThis);

	/// <summary>
	/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
	/// texture coordinates (u,v).
	///
	/// @note Implementation taken from the work of Marco Tarini:
	/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
	/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
	/// </summary>
	public virtual bool GetSeamlessU()
	{
		return (vtkPolyDataMapper_GetSeamlessU_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyDataMapper_GetSeamlessV_11(HandleRef pThis);

	/// <summary>
	/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
	/// texture coordinates (u,v).
	///
	/// @note Implementation taken from the work of Marco Tarini:
	/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
	/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
	/// </summary>
	public virtual bool GetSeamlessV()
	{
		return (vtkPolyDataMapper_GetSeamlessV_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataMapper_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataMapper_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_MapDataArrayToMultiTextureAttribute_14(HandleRef pThis, string textureName, string dataArrayName, int fieldAssociation, int componentno);

	/// <summary>
	/// Select a data array from the point/cell data
	/// and map it to a generic vertex attribute.
	/// vertexAttributeName is the name of the vertex attribute.
	/// dataArrayName is the name of the data array.
	/// fieldAssociation indicates when the data array is a point data array or
	/// cell data array (vtkDataObject::FIELD_ASSOCIATION_POINTS or
	/// (vtkDataObject::FIELD_ASSOCIATION_CELLS).
	/// componentno indicates which component from the data array must be passed as
	/// the attribute. If -1, then all components are passed.
	/// Currently only point data is supported.
	/// </summary>
	public virtual void MapDataArrayToMultiTextureAttribute(string textureName, string dataArrayName, int fieldAssociation, int componentno)
	{
		vtkPolyDataMapper_MapDataArrayToMultiTextureAttribute_14(GetCppThis(), textureName, dataArrayName, fieldAssociation, componentno);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_MapDataArrayToVertexAttribute_15(HandleRef pThis, string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno);

	/// <summary>
	/// Select a data array from the point/cell data
	/// and map it to a generic vertex attribute.
	/// vertexAttributeName is the name of the vertex attribute.
	/// dataArrayName is the name of the data array.
	/// fieldAssociation indicates when the data array is a point data array or
	/// cell data array (vtkDataObject::FIELD_ASSOCIATION_POINTS or
	/// (vtkDataObject::FIELD_ASSOCIATION_CELLS).
	/// componentno indicates which component from the data array must be passed as
	/// the attribute. If -1, then all components are passed.
	/// Currently only point data is supported.
	/// </summary>
	public virtual void MapDataArrayToVertexAttribute(string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno)
	{
		vtkPolyDataMapper_MapDataArrayToVertexAttribute_15(GetCppThis(), vertexAttributeName, dataArrayName, fieldAssociation, componentno);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolyDataMapper NewInstance()
	{
		vtkPolyDataMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_RemoveAllVertexAttributeMappings_18(HandleRef pThis);

	/// <summary>
	/// Remove all vertex attributes.
	/// </summary>
	public virtual void RemoveAllVertexAttributeMappings()
	{
		vtkPolyDataMapper_RemoveAllVertexAttributeMappings_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_RemoveVertexAttributeMapping_19(HandleRef pThis, string vertexAttributeName);

	/// <summary>
	/// Remove a vertex attribute mapping.
	/// </summary>
	public virtual void RemoveVertexAttributeMapping(string vertexAttributeName)
	{
		vtkPolyDataMapper_RemoveVertexAttributeMapping_19(GetCppThis(), vertexAttributeName);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_Render_20(HandleRef pThis, HandleRef ren, HandleRef act);

	/// <summary>
	/// This calls RenderPiece (in a for loop if streaming is necessary).
	/// </summary>
	public override void Render(vtkRenderer ren, vtkActor act)
	{
		vtkPolyDataMapper_Render_20(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), act?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_RenderPiece_21(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Implemented by sub classes. Actual rendering is done here.
	/// </summary>
	public virtual void RenderPiece(vtkRenderer arg0, vtkActor arg1)
	{
		vtkPolyDataMapper_RenderPiece_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataMapper_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataMapper SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataMapper vtkPolyDataMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataMapper_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataMapper2 = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataMapper2.Register(null);
			}
		}
		return vtkPolyDataMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SeamlessUOff_23(HandleRef pThis);

	/// <summary>
	/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
	/// texture coordinates (u,v).
	///
	/// @note Implementation taken from the work of Marco Tarini:
	/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
	/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
	/// </summary>
	public virtual void SeamlessUOff()
	{
		vtkPolyDataMapper_SeamlessUOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SeamlessUOn_24(HandleRef pThis);

	/// <summary>
	/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
	/// texture coordinates (u,v).
	///
	/// @note Implementation taken from the work of Marco Tarini:
	/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
	/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
	/// </summary>
	public virtual void SeamlessUOn()
	{
		vtkPolyDataMapper_SeamlessUOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SeamlessVOff_25(HandleRef pThis);

	/// <summary>
	/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
	/// texture coordinates (u,v).
	///
	/// @note Implementation taken from the work of Marco Tarini:
	/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
	/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
	/// </summary>
	public virtual void SeamlessVOff()
	{
		vtkPolyDataMapper_SeamlessVOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SeamlessVOn_26(HandleRef pThis);

	/// <summary>
	/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
	/// texture coordinates (u,v).
	///
	/// @note Implementation taken from the work of Marco Tarini:
	/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
	/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
	/// </summary>
	public virtual void SeamlessVOn()
	{
		vtkPolyDataMapper_SeamlessVOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SetGhostLevel_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of ghost cells to return.
	/// </summary>
	public virtual void SetGhostLevel(int _arg)
	{
		vtkPolyDataMapper_SetGhostLevel_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SetInputData_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the input data to map.
	/// </summary>
	public void SetInputData(vtkPolyData arg0)
	{
		vtkPolyDataMapper_SetInputData_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SetNumberOfPieces_29(HandleRef pThis, int _arg);

	/// <summary>
	/// If you want only a part of the data, specify by setting the piece.
	/// </summary>
	public virtual void SetNumberOfPieces(int _arg)
	{
		vtkPolyDataMapper_SetNumberOfPieces_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SetNumberOfSubPieces_30(HandleRef pThis, int _arg);

	/// <summary>
	/// If you want only a part of the data, specify by setting the piece.
	/// </summary>
	public virtual void SetNumberOfSubPieces(int _arg)
	{
		vtkPolyDataMapper_SetNumberOfSubPieces_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SetPiece_31(HandleRef pThis, int _arg);

	/// <summary>
	/// If you want only a part of the data, specify by setting the piece.
	/// </summary>
	public virtual void SetPiece(int _arg)
	{
		vtkPolyDataMapper_SetPiece_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SetSeamlessU_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
	/// texture coordinates (u,v).
	///
	/// @note Implementation taken from the work of Marco Tarini:
	/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
	/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
	/// </summary>
	public virtual void SetSeamlessU(bool _arg)
	{
		vtkPolyDataMapper_SetSeamlessU_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_SetSeamlessV_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Accessors / Mutators for handling seams on wrapping surfaces. Letters U and V stand for
	/// texture coordinates (u,v).
	///
	/// @note Implementation taken from the work of Marco Tarini:
	/// Cylindrical and Toroidal Parameterizations Without Vertex Seams
	/// Journal of Graphics Tools, 2012, number 3, volume 16, pages 144-150.
	/// </summary>
	public virtual void SetSeamlessV(bool _arg)
	{
		vtkPolyDataMapper_SetSeamlessV_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_ShallowCopy_34(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Make a shallow copy of this mapper.
	/// </summary>
	public override void ShallowCopy(vtkAbstractMapper m)
	{
		vtkPolyDataMapper_ShallowCopy_34(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_Update_35(HandleRef pThis, int port);

	/// <summary>
	/// Bring this algorithm's outputs up-to-date.
	/// </summary>
	public override void Update(int port)
	{
		vtkPolyDataMapper_Update_35(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataMapper_Update_36(HandleRef pThis);

	/// <summary>
	/// Bring this algorithm's outputs up-to-date.
	/// </summary>
	public override void Update()
	{
		vtkPolyDataMapper_Update_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper_Update_37(HandleRef pThis, int port, HandleRef requests);

	/// <summary>
	/// Bring this algorithm's outputs up-to-date.
	/// </summary>
	public override int Update(int port, vtkInformationVector requests)
	{
		return vtkPolyDataMapper_Update_37(GetCppThis(), port, requests?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataMapper_Update_38(HandleRef pThis, HandleRef requests);

	/// <summary>
	/// Bring this algorithm's outputs up-to-date.
	/// </summary>
	public override int Update(vtkInformation requests)
	{
		return vtkPolyDataMapper_Update_38(GetCppThis(), requests?.GetCppThis() ?? default(HandleRef));
	}
}
