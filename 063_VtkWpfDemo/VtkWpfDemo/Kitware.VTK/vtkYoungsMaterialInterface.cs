using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkYoungsMaterialInterface
/// </summary>
/// <remarks>
///    reconstructs material interfaces
///
///
/// Reconstructs material interfaces from a mesh containing mixed cells (where several materials are
/// mixed) this implementation is based on the youngs algorithm, generalized to arbitrary cell types
/// and works on both 2D and 3D meshes. the main advantage of the youngs algorithm is it guarantees
/// the material volume correctness. for 2D meshes, the AxisSymetric flag allows to switch between a
/// pure 2D (planar) algorithm and an axis symmetric 2D algorithm handling volumes of revolution.
///
/// @par Thanks:
/// This file is part of the generalized Youngs material interface reconstruction algorithm
/// contributed by &lt;br&gt; CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt;
/// BP12, F-91297 Arpajon, France. &lt;br&gt;
/// Implementation by Thierry Carrard (thierry.carrard@cea.fr)
/// Modification by Philippe Pebay (philippe.pebay@kitware.com)
/// </remarks>
public class vtkYoungsMaterialInterface : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// select blocks to be processed for each described material.
	/// </summary>
	public enum MAX_CELL_POINTS_WrapperEnum
	{
		/// <summary>enum member</summary>
		MAX_CELL_POINTS = 0x100
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkYoungsMaterialInterface";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkYoungsMaterialInterface()
	{
		MRClassNameKey = "class vtkYoungsMaterialInterface";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkYoungsMaterialInterface"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkYoungsMaterialInterface(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkYoungsMaterialInterface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkYoungsMaterialInterface New()
	{
		vtkYoungsMaterialInterface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkYoungsMaterialInterface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkYoungsMaterialInterface()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkYoungsMaterialInterface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_AddMaterialBlockMapping_01(HandleRef pThis, int b);

	/// <summary>
	/// select blocks to be processed for each described material.
	/// </summary>
	public virtual void AddMaterialBlockMapping(int b)
	{
		vtkYoungsMaterialInterface_AddMaterialBlockMapping_01(GetCppThis(), b);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_AxisSymetricOff_02(HandleRef pThis);

	/// <summary>
	/// Turns on/off AxisSymetric computation of 2D interfaces.
	/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
	/// </summary>
	public virtual void AxisSymetricOff()
	{
		vtkYoungsMaterialInterface_AxisSymetricOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_AxisSymetricOn_03(HandleRef pThis);

	/// <summary>
	/// Turns on/off AxisSymetric computation of 2D interfaces.
	/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
	/// </summary>
	public virtual void AxisSymetricOn()
	{
		vtkYoungsMaterialInterface_AxisSymetricOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_FillMaterialOff_04(HandleRef pThis);

	/// <summary>
	/// When FillMaterial is set to 1, the volume containing material is output and not only the
	/// interface surface.
	/// </summary>
	public virtual void FillMaterialOff()
	{
		vtkYoungsMaterialInterface_FillMaterialOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_FillMaterialOn_05(HandleRef pThis);

	/// <summary>
	/// When FillMaterial is set to 1, the volume containing material is output and not only the
	/// interface surface.
	/// </summary>
	public virtual void FillMaterialOn()
	{
		vtkYoungsMaterialInterface_FillMaterialOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_GetAxisSymetric_06(HandleRef pThis);

	/// <summary>
	/// Turns on/off AxisSymetric computation of 2D interfaces.
	/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
	/// </summary>
	public virtual int GetAxisSymetric()
	{
		return vtkYoungsMaterialInterface_GetAxisSymetric_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_GetFillMaterial_07(HandleRef pThis);

	/// <summary>
	/// When FillMaterial is set to 1, the volume containing material is output and not only the
	/// interface surface.
	/// </summary>
	public virtual int GetFillMaterial()
	{
		return vtkYoungsMaterialInterface_GetFillMaterial_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_GetInverseNormal_08(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the normal vector has to be flipped.
	/// </summary>
	public virtual int GetInverseNormal()
	{
		return vtkYoungsMaterialInterface_GetInverseNormal_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_GetNumberOfDomains_09(HandleRef pThis);

	/// <summary>
	/// Only meaningful for LOVE software. returns the maximum number of blocks containing the same
	/// material
	/// </summary>
	public virtual int GetNumberOfDomains()
	{
		return vtkYoungsMaterialInterface_GetNumberOfDomains_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkYoungsMaterialInterface_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkYoungsMaterialInterface_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkYoungsMaterialInterface_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkYoungsMaterialInterface_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_GetNumberOfMaterials_12(HandleRef pThis);

	/// <summary>
	/// Sets/Gets the number of materials.
	/// </summary>
	public virtual int GetNumberOfMaterials()
	{
		return vtkYoungsMaterialInterface_GetNumberOfMaterials_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_GetOnionPeel_13(HandleRef pThis);

	/// <summary>
	/// Set/Get OnionPeel flag. if this flag is on, the normal vector of the first
	/// material (which depends on material ordering) is used for all materials.
	/// </summary>
	public virtual int GetOnionPeel()
	{
		return vtkYoungsMaterialInterface_GetOnionPeel_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_GetReverseMaterialOrder_14(HandleRef pThis);

	/// <summary>
	/// If this flag is on, material order in reversed.
	/// Otherwise, materials are sorted in ascending order depending on the given ordering array.
	/// </summary>
	public virtual int GetReverseMaterialOrder()
	{
		return vtkYoungsMaterialInterface_GetReverseMaterialOrder_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkYoungsMaterialInterface_GetUseAllBlocks_15(HandleRef pThis);

	/// <summary>
	/// Set/Get whether all material blocks should be used, irrespective of the material block mapping.
	/// </summary>
	public virtual bool GetUseAllBlocks()
	{
		return (vtkYoungsMaterialInterface_GetUseAllBlocks_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_GetUseFractionAsDistance_16(HandleRef pThis);

	/// <summary>
	/// when UseFractionAsDistance is true, the volume fraction is interpreted as the distance
	/// of the cutting plane from the origin.
	/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
	/// </summary>
	public virtual int GetUseFractionAsDistance()
	{
		return vtkYoungsMaterialInterface_GetUseFractionAsDistance_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkYoungsMaterialInterface_GetVolumeFractionRange_17(HandleRef pThis);

	/// <summary>
	/// Set/Get minimum and maximum volume fraction value. if a material fills a volume above the
	/// minimum value, the material is considered to be void. if a material fills a volume fraction
	/// beyond the maximum value it is considered as filling the whole volume.
	/// </summary>
	public virtual double[] GetVolumeFractionRange()
	{
		IntPtr intPtr = vtkYoungsMaterialInterface_GetVolumeFractionRange_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_GetVolumeFractionRange_18(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get minimum and maximum volume fraction value. if a material fills a volume above the
	/// minimum value, the material is considered to be void. if a material fills a volume fraction
	/// beyond the maximum value it is considered as filling the whole volume.
	/// </summary>
	public virtual void GetVolumeFractionRange(IntPtr data)
	{
		vtkYoungsMaterialInterface_GetVolumeFractionRange_18(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_InverseNormalOff_19(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the normal vector has to be flipped.
	/// </summary>
	public virtual void InverseNormalOff()
	{
		vtkYoungsMaterialInterface_InverseNormalOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_InverseNormalOn_20(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the normal vector has to be flipped.
	/// </summary>
	public virtual void InverseNormalOn()
	{
		vtkYoungsMaterialInterface_InverseNormalOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkYoungsMaterialInterface_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkYoungsMaterialInterface_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkYoungsMaterialInterface_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkYoungsMaterialInterface_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkYoungsMaterialInterface NewInstance()
	{
		vtkYoungsMaterialInterface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkYoungsMaterialInterface_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_OnionPeelOff_25(HandleRef pThis);

	/// <summary>
	/// Set/Get OnionPeel flag. if this flag is on, the normal vector of the first
	/// material (which depends on material ordering) is used for all materials.
	/// </summary>
	public virtual void OnionPeelOff()
	{
		vtkYoungsMaterialInterface_OnionPeelOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_OnionPeelOn_26(HandleRef pThis);

	/// <summary>
	/// Set/Get OnionPeel flag. if this flag is on, the normal vector of the first
	/// material (which depends on material ordering) is used for all materials.
	/// </summary>
	public virtual void OnionPeelOn()
	{
		vtkYoungsMaterialInterface_OnionPeelOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_RemoveAllMaterialBlockMappings_27(HandleRef pThis);

	/// <summary>
	/// select blocks to be processed for each described material.
	/// </summary>
	public virtual void RemoveAllMaterialBlockMappings()
	{
		vtkYoungsMaterialInterface_RemoveAllMaterialBlockMappings_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_RemoveAllMaterials_28(HandleRef pThis);

	/// <summary>
	/// Removes all materials previously added.
	/// </summary>
	public virtual void RemoveAllMaterials()
	{
		vtkYoungsMaterialInterface_RemoveAllMaterials_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_ReverseMaterialOrderOff_29(HandleRef pThis);

	/// <summary>
	/// If this flag is on, material order in reversed.
	/// Otherwise, materials are sorted in ascending order depending on the given ordering array.
	/// </summary>
	public virtual void ReverseMaterialOrderOff()
	{
		vtkYoungsMaterialInterface_ReverseMaterialOrderOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_ReverseMaterialOrderOn_30(HandleRef pThis);

	/// <summary>
	/// If this flag is on, material order in reversed.
	/// Otherwise, materials are sorted in ascending order depending on the given ordering array.
	/// </summary>
	public virtual void ReverseMaterialOrderOn()
	{
		vtkYoungsMaterialInterface_ReverseMaterialOrderOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkYoungsMaterialInterface_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkYoungsMaterialInterface SafeDownCast(vtkObjectBase o)
	{
		vtkYoungsMaterialInterface vtkYoungsMaterialInterface2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkYoungsMaterialInterface_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkYoungsMaterialInterface2 = (vtkYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkYoungsMaterialInterface2.Register(null);
			}
		}
		return vtkYoungsMaterialInterface2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetAxisSymetric_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Turns on/off AxisSymetric computation of 2D interfaces.
	/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
	/// </summary>
	public virtual void SetAxisSymetric(int _arg)
	{
		vtkYoungsMaterialInterface_SetAxisSymetric_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetFillMaterial_33(HandleRef pThis, int _arg);

	/// <summary>
	/// When FillMaterial is set to 1, the volume containing material is output and not only the
	/// interface surface.
	/// </summary>
	public virtual void SetFillMaterial(int _arg)
	{
		vtkYoungsMaterialInterface_SetFillMaterial_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetInverseNormal_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether the normal vector has to be flipped.
	/// </summary>
	public virtual void SetInverseNormal(int _arg)
	{
		vtkYoungsMaterialInterface_SetInverseNormal_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetMaterialArrays_35(HandleRef pThis, int i, string volume, string normalX, string normalY, string normalZ, string ordering);

	/// <summary>
	/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
	/// Each parameter name a cell array.
	/// </summary>
	public virtual void SetMaterialArrays(int i, string volume, string normalX, string normalY, string normalZ, string ordering)
	{
		vtkYoungsMaterialInterface_SetMaterialArrays_35(GetCppThis(), i, volume, normalX, normalY, normalZ, ordering);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetMaterialArrays_36(HandleRef pThis, int i, string volume, string normal, string ordering);

	/// <summary>
	/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
	/// Each parameter name a cell array.
	/// </summary>
	public virtual void SetMaterialArrays(int i, string volume, string normal, string ordering)
	{
		vtkYoungsMaterialInterface_SetMaterialArrays_36(GetCppThis(), i, volume, normal, ordering);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetMaterialNormalArray_37(HandleRef pThis, int i, string normal);

	/// <summary>
	/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
	/// Each parameter name a cell array.
	/// </summary>
	public virtual void SetMaterialNormalArray(int i, string normal)
	{
		vtkYoungsMaterialInterface_SetMaterialNormalArray_37(GetCppThis(), i, normal);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetMaterialNormalArray_38(HandleRef pThis, string volume, string normal);

	/// <summary>
	/// Alternative API for associating Normal and Ordering arrays to materials
	/// identified by its volume-fraction array.
	/// Note that these mappings are cleared by a call to RemoveAllMaterials() but
	/// not by SetNumberOfMaterials().
	/// If one uses the SetMaterial*Array(int, ...) API to set the normal or
	/// ordering arrays, then that supersedes the values set using this API.
	/// </summary>
	public virtual void SetMaterialNormalArray(string volume, string normal)
	{
		vtkYoungsMaterialInterface_SetMaterialNormalArray_38(GetCppThis(), volume, normal);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetMaterialOrderingArray_39(HandleRef pThis, int i, string ordering);

	/// <summary>
	/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
	/// Each parameter name a cell array.
	/// </summary>
	public virtual void SetMaterialOrderingArray(int i, string ordering)
	{
		vtkYoungsMaterialInterface_SetMaterialOrderingArray_39(GetCppThis(), i, ordering);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetMaterialOrderingArray_40(HandleRef pThis, string volume, string ordering);

	/// <summary>
	/// Alternative API for associating Normal and Ordering arrays to materials
	/// identified by its volume-fraction array.
	/// Note that these mappings are cleared by a call to RemoveAllMaterials() but
	/// not by SetNumberOfMaterials().
	/// If one uses the SetMaterial*Array(int, ...) API to set the normal or
	/// ordering arrays, then that supersedes the values set using this API.
	/// </summary>
	public virtual void SetMaterialOrderingArray(string volume, string ordering)
	{
		vtkYoungsMaterialInterface_SetMaterialOrderingArray_40(GetCppThis(), volume, ordering);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetMaterialVolumeFractionArray_41(HandleRef pThis, int i, string volume);

	/// <summary>
	/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
	/// Each parameter name a cell array.
	/// </summary>
	public virtual void SetMaterialVolumeFractionArray(int i, string volume)
	{
		vtkYoungsMaterialInterface_SetMaterialVolumeFractionArray_41(GetCppThis(), i, volume);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetNumberOfMaterials_42(HandleRef pThis, int n);

	/// <summary>
	/// Sets/Gets the number of materials.
	/// </summary>
	public virtual void SetNumberOfMaterials(int n)
	{
		vtkYoungsMaterialInterface_SetNumberOfMaterials_42(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetOnionPeel_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get OnionPeel flag. if this flag is on, the normal vector of the first
	/// material (which depends on material ordering) is used for all materials.
	/// </summary>
	public virtual void SetOnionPeel(int _arg)
	{
		vtkYoungsMaterialInterface_SetOnionPeel_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetReverseMaterialOrder_44(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is on, material order in reversed.
	/// Otherwise, materials are sorted in ascending order depending on the given ordering array.
	/// </summary>
	public virtual void SetReverseMaterialOrder(int _arg)
	{
		vtkYoungsMaterialInterface_SetReverseMaterialOrder_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetUseAllBlocks_45(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether all material blocks should be used, irrespective of the material block mapping.
	/// </summary>
	public virtual void SetUseAllBlocks(bool _arg)
	{
		vtkYoungsMaterialInterface_SetUseAllBlocks_45(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetUseFractionAsDistance_46(HandleRef pThis, int _arg);

	/// <summary>
	/// when UseFractionAsDistance is true, the volume fraction is interpreted as the distance
	/// of the cutting plane from the origin.
	/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
	/// </summary>
	public virtual void SetUseFractionAsDistance(int _arg)
	{
		vtkYoungsMaterialInterface_SetUseFractionAsDistance_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetVolumeFractionRange_47(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set/Get minimum and maximum volume fraction value. if a material fills a volume above the
	/// minimum value, the material is considered to be void. if a material fills a volume fraction
	/// beyond the maximum value it is considered as filling the whole volume.
	/// </summary>
	public virtual void SetVolumeFractionRange(double _arg1, double _arg2)
	{
		vtkYoungsMaterialInterface_SetVolumeFractionRange_47(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_SetVolumeFractionRange_48(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get minimum and maximum volume fraction value. if a material fills a volume above the
	/// minimum value, the material is considered to be void. if a material fills a volume fraction
	/// beyond the maximum value it is considered as filling the whole volume.
	/// </summary>
	public void SetVolumeFractionRange(IntPtr _arg)
	{
		vtkYoungsMaterialInterface_SetVolumeFractionRange_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_UseAllBlocksOff_49(HandleRef pThis);

	/// <summary>
	/// Set/Get whether all material blocks should be used, irrespective of the material block mapping.
	/// </summary>
	public virtual void UseAllBlocksOff()
	{
		vtkYoungsMaterialInterface_UseAllBlocksOff_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_UseAllBlocksOn_50(HandleRef pThis);

	/// <summary>
	/// Set/Get whether all material blocks should be used, irrespective of the material block mapping.
	/// </summary>
	public virtual void UseAllBlocksOn()
	{
		vtkYoungsMaterialInterface_UseAllBlocksOn_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_UseFractionAsDistanceOff_51(HandleRef pThis);

	/// <summary>
	/// when UseFractionAsDistance is true, the volume fraction is interpreted as the distance
	/// of the cutting plane from the origin.
	/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
	/// </summary>
	public virtual void UseFractionAsDistanceOff()
	{
		vtkYoungsMaterialInterface_UseFractionAsDistanceOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkYoungsMaterialInterface_UseFractionAsDistanceOn_52(HandleRef pThis);

	/// <summary>
	/// when UseFractionAsDistance is true, the volume fraction is interpreted as the distance
	/// of the cutting plane from the origin.
	/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
	/// </summary>
	public virtual void UseFractionAsDistanceOn()
	{
		vtkYoungsMaterialInterface_UseFractionAsDistanceOn_52(GetCppThis());
	}
}
