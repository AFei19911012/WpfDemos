using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNetCDFCAMReader
/// </summary>
/// <remarks>
///    Read unstructured NetCDF CAM files.
///
/// Reads in a NetCDF CAM (Community Atmospheric Model) file and
/// produces and unstructured grid.  The grid is actually unstructured
/// in the X and Y directions and rectilinear in the Z direction. If we
/// read one layer we produce quad cells otherwise we produce hex
/// cells.  The reader requires 2 NetCDF files: the main file has all
/// attributes, the connectivity file has point positions and cell
/// connectivity information.
/// </remarks>
public class vtkNetCDFCAMReader : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Set whether to read a single layer, midpoint layers or interface layers.
	/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
	/// layer will be read in. The NetCDF variables loaded will be the
	/// ones with dimensions (time, ncol).
	/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
	/// on midpoint layers will be read in. These are variables with dimensions
	/// (time, lev, ncol).
	/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
	/// defined on interface layers will be read in. These are variables with
	/// dimensions (time, ilev, ncol).
	/// </summary>
	public enum VerticalDimension
	{
		/// <summary>enum member</summary>
		VERTICAL_DIMENSION_COUNT = 3,
		/// <summary>enum member</summary>
		VERTICAL_DIMENSION_INTERFACE_LAYERS = 2,
		/// <summary>enum member</summary>
		VERTICAL_DIMENSION_MIDPOINT_LAYERS = 1,
		/// <summary>enum member</summary>
		VERTICAL_DIMENSION_SINGLE_LAYER = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFCAMReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNetCDFCAMReader()
	{
		MRClassNameKey = "class vtkNetCDFCAMReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFCAMReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNetCDFCAMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCAMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFCAMReader New()
	{
		vtkNetCDFCAMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFCAMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFCAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNetCDFCAMReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNetCDFCAMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_CanReadFile_01(string fileName);

	/// <summary>
	/// Returns 1 if this file can be read and 0 if the file cannot be read.
	/// Because NetCDF CAM files come in pairs and we only check one of the
	/// files, the result is not definitive.  Invalid files may still return 1
	/// although a valid file will never return 0.
	/// </summary>
	public static int CanReadFile(string fileName)
	{
		return vtkNetCDFCAMReader_CanReadFile_01(fileName);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_DisableAllPointArrays_02(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of variables.
	/// By default, ALL data variables on the nodes are read.
	/// </summary>
	public void DisableAllPointArrays()
	{
		vtkNetCDFCAMReader_DisableAllPointArrays_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_EnableAllPointArrays_03(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of variables.
	/// By default, ALL data variables on the nodes are read.
	/// </summary>
	public void EnableAllPointArrays()
	{
		vtkNetCDFCAMReader_EnableAllPointArrays_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCAMReader_GetConnectivityFileName_04(HandleRef pThis);

	/// <summary>
	/// Returns 1 if this file can be read and 0 if the file cannot be read.
	/// Because NetCDF CAM files come in pairs and we only check one of the
	/// files, the result is not definitive.  Invalid files may still return 1
	/// although a valid file will never return 0.
	/// </summary>
	public virtual string GetConnectivityFileName()
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFCAMReader_GetConnectivityFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCAMReader_GetFileName_05(HandleRef pThis);

	/// <summary>
	/// Returns 1 if this file can be read and 0 if the file cannot be read.
	/// Because NetCDF CAM files come in pairs and we only check one of the
	/// files, the result is not definitive.  Invalid files may still return 1
	/// although a valid file will never return 0.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFCAMReader_GetFileName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_GetInterfaceLayerIndex_06(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual int GetInterfaceLayerIndex()
	{
		return vtkNetCDFCAMReader_GetInterfaceLayerIndex_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCAMReader_GetInterfaceLayersRange_07(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual int[] GetInterfaceLayersRange()
	{
		IntPtr intPtr = vtkNetCDFCAMReader_GetInterfaceLayersRange_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_GetInterfaceLayersRange_08(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void GetInterfaceLayersRange(ref int _arg1, ref int _arg2)
	{
		vtkNetCDFCAMReader_GetInterfaceLayersRange_08(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_GetInterfaceLayersRange_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void GetInterfaceLayersRange(IntPtr _arg)
	{
		vtkNetCDFCAMReader_GetInterfaceLayersRange_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_GetMidpointLayerIndex_10(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual int GetMidpointLayerIndex()
	{
		return vtkNetCDFCAMReader_GetMidpointLayerIndex_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCAMReader_GetMidpointLayersRange_11(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual int[] GetMidpointLayersRange()
	{
		IntPtr intPtr = vtkNetCDFCAMReader_GetMidpointLayersRange_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_GetMidpointLayersRange_12(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void GetMidpointLayersRange(ref int _arg1, ref int _arg2)
	{
		vtkNetCDFCAMReader_GetMidpointLayersRange_12(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_GetMidpointLayersRange_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void GetMidpointLayersRange(IntPtr _arg)
	{
		vtkNetCDFCAMReader_GetMidpointLayersRange_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFCAMReader_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNetCDFCAMReader_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFCAMReader_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNetCDFCAMReader_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_GetNumberOfPointArrays_16(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of variables.
	/// By default, ALL data variables on the nodes are read.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkNetCDFCAMReader_GetNumberOfPointArrays_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCAMReader_GetPointArrayName_17(HandleRef pThis, int index);

	/// <summary>
	/// The following methods allow selective reading of variables.
	/// By default, ALL data variables on the nodes are read.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFCAMReader_GetPointArrayName_17(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_GetPointArrayStatus_18(HandleRef pThis, string name);

	/// <summary>
	/// The following methods allow selective reading of variables.
	/// By default, ALL data variables on the nodes are read.
	/// </summary>
	public int GetPointArrayStatus(string name)
	{
		return vtkNetCDFCAMReader_GetPointArrayStatus_18(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_GetSingleInterfaceLayer_19(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual int GetSingleInterfaceLayer()
	{
		return vtkNetCDFCAMReader_GetSingleInterfaceLayer_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_GetSingleMidpointLayer_20(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual int GetSingleMidpointLayer()
	{
		return vtkNetCDFCAMReader_GetSingleMidpointLayer_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_GetVerticalDimension_21(HandleRef pThis);

	/// <summary>
	/// Set whether to read a single layer, midpoint layers or interface layers.
	/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
	/// layer will be read in. The NetCDF variables loaded will be the
	/// ones with dimensions (time, ncol).
	/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
	/// on midpoint layers will be read in. These are variables with dimensions
	/// (time, lev, ncol).
	/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
	/// defined on interface layers will be read in. These are variables with
	/// dimensions (time, ilev, ncol).
	/// </summary>
	public virtual int GetVerticalDimension()
	{
		return vtkNetCDFCAMReader_GetVerticalDimension_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_GetVerticalDimensionMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set whether to read a single layer, midpoint layers or interface layers.
	/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
	/// layer will be read in. The NetCDF variables loaded will be the
	/// ones with dimensions (time, ncol).
	/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
	/// on midpoint layers will be read in. These are variables with dimensions
	/// (time, lev, ncol).
	/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
	/// defined on interface layers will be read in. These are variables with
	/// dimensions (time, ilev, ncol).
	/// </summary>
	public virtual int GetVerticalDimensionMaxValue()
	{
		return vtkNetCDFCAMReader_GetVerticalDimensionMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_GetVerticalDimensionMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set whether to read a single layer, midpoint layers or interface layers.
	/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
	/// layer will be read in. The NetCDF variables loaded will be the
	/// ones with dimensions (time, ncol).
	/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
	/// on midpoint layers will be read in. These are variables with dimensions
	/// (time, lev, ncol).
	/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
	/// defined on interface layers will be read in. These are variables with
	/// dimensions (time, ilev, ncol).
	/// </summary>
	public virtual int GetVerticalDimensionMinValue()
	{
		return vtkNetCDFCAMReader_GetVerticalDimensionMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNetCDFCAMReader_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFCAMReader_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNetCDFCAMReader_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCAMReader_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNetCDFCAMReader NewInstance()
	{
		vtkNetCDFCAMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFCAMReader_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFCAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFCAMReader_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFCAMReader SafeDownCast(vtkObjectBase o)
	{
		vtkNetCDFCAMReader vtkNetCDFCAMReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFCAMReader_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNetCDFCAMReader2 = (vtkNetCDFCAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNetCDFCAMReader2.Register(null);
			}
		}
		return vtkNetCDFCAMReader2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SetConnectivityFileName_29(HandleRef pThis, string fileName);

	/// <summary>
	/// Returns 1 if this file can be read and 0 if the file cannot be read.
	/// Because NetCDF CAM files come in pairs and we only check one of the
	/// files, the result is not definitive.  Invalid files may still return 1
	/// although a valid file will never return 0.
	/// </summary>
	public void SetConnectivityFileName(string fileName)
	{
		vtkNetCDFCAMReader_SetConnectivityFileName_29(GetCppThis(), fileName);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SetFileName_30(HandleRef pThis, string fileName);

	/// <summary>
	/// Returns 1 if this file can be read and 0 if the file cannot be read.
	/// Because NetCDF CAM files come in pairs and we only check one of the
	/// files, the result is not definitive.  Invalid files may still return 1
	/// although a valid file will never return 0.
	/// </summary>
	public void SetFileName(string fileName)
	{
		vtkNetCDFCAMReader_SetFileName_30(GetCppThis(), fileName);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SetInterfaceLayerIndex_31(HandleRef pThis, int _arg);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void SetInterfaceLayerIndex(int _arg)
	{
		vtkNetCDFCAMReader_SetInterfaceLayerIndex_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SetMidpointLayerIndex_32(HandleRef pThis, int _arg);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void SetMidpointLayerIndex(int _arg)
	{
		vtkNetCDFCAMReader_SetMidpointLayerIndex_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SetPointArrayStatus_33(HandleRef pThis, string name, int status);

	/// <summary>
	/// The following methods allow selective reading of variables.
	/// By default, ALL data variables on the nodes are read.
	/// </summary>
	public void SetPointArrayStatus(string name, int status)
	{
		vtkNetCDFCAMReader_SetPointArrayStatus_33(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SetSingleInterfaceLayer_34(HandleRef pThis, int _arg);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void SetSingleInterfaceLayer(int _arg)
	{
		vtkNetCDFCAMReader_SetSingleInterfaceLayer_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SetSingleMidpointLayer_35(HandleRef pThis, int _arg);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void SetSingleMidpointLayer(int _arg)
	{
		vtkNetCDFCAMReader_SetSingleMidpointLayer_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SetVerticalDimension_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to read a single layer, midpoint layers or interface layers.
	/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
	/// layer will be read in. The NetCDF variables loaded will be the
	/// ones with dimensions (time, ncol).
	/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
	/// on midpoint layers will be read in. These are variables with dimensions
	/// (time, lev, ncol).
	/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
	/// defined on interface layers will be read in. These are variables with
	/// dimensions (time, ilev, ncol).
	/// </summary>
	public virtual void SetVerticalDimension(int _arg)
	{
		vtkNetCDFCAMReader_SetVerticalDimension_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SingleInterfaceLayerOff_37(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void SingleInterfaceLayerOff()
	{
		vtkNetCDFCAMReader_SingleInterfaceLayerOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SingleInterfaceLayerOn_38(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void SingleInterfaceLayerOn()
	{
		vtkNetCDFCAMReader_SingleInterfaceLayerOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SingleMidpointLayerOff_39(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void SingleMidpointLayerOff()
	{
		vtkNetCDFCAMReader_SingleMidpointLayerOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFCAMReader_SingleMidpointLayerOn_40(HandleRef pThis);

	/// <summary>
	/// If SingleXXXLayer is 1, we'll load only the layer specified by
	/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
	/// midpoint layer variables ( which have dimension 'lev') or for
	/// interface layer variables (which have dimension 'ilev').
	/// </summary>
	public virtual void SingleMidpointLayerOn()
	{
		vtkNetCDFCAMReader_SingleMidpointLayerOn_40(GetCppThis());
	}
}
