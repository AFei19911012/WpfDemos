using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompositeDataDisplayAttributes
/// </summary>
/// <remarks>
///    Rendering attributes for a multi-block dataset.
///
/// The vtkCompositeDataDisplayAttributes class stores display attributes
/// for individual blocks in a multi-block dataset. It uses the actual data
/// block's pointer as a key (vtkDataObject*).
///
/// @warning It is considered unsafe to dereference key pointers at any time,
/// they should only serve as keys to access the internal map.
/// </remarks>
public class vtkCompositeDataDisplayAttributes : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataDisplayAttributes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositeDataDisplayAttributes()
	{
		MRClassNameKey = "class vtkCompositeDataDisplayAttributes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataDisplayAttributes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositeDataDisplayAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataDisplayAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataDisplayAttributes New()
	{
		vtkCompositeDataDisplayAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataDisplayAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCompositeDataDisplayAttributes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompositeDataDisplayAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCompositeDataDisplayAttributes_ComputeVisibleBounds_01(HandleRef cda, HandleRef dobj, IntPtr bounds);

	/// <summary>
	/// If the input \a dobj is a vtkCompositeDataSet, we will loop over the
	/// hierarchy recursively starting from initial index 0 and use only visible
	/// blocks, which is specified in the vtkCompositeDataDisplayAttributes \a cda,
	/// to compute the \a bounds.
	/// </summary>
	public static void ComputeVisibleBounds(vtkCompositeDataDisplayAttributes cda, vtkDataObject dobj, IntPtr bounds)
	{
		vtkCompositeDataDisplayAttributes_ComputeVisibleBounds_01(cda?.GetCppThis() ?? default(HandleRef), dobj?.GetCppThis() ?? default(HandleRef), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataDisplayAttributes_DataObjectFromIndex_02(uint flat_index, HandleRef parent_obj, uint current_flat_index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the DataObject corresponding to the node with index flat_index under
	/// parent_obj. Traverses the entire hierarchy recursively.
	/// </summary>
	public static vtkDataObject DataObjectFromIndex(uint flat_index, vtkDataObject parent_obj, uint current_flat_index)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataDisplayAttributes_DataObjectFromIndex_02(flat_index, parent_obj?.GetCppThis() ?? default(HandleRef), current_flat_index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_GetBlockColor_03(HandleRef pThis, HandleRef data_object, IntPtr color);

	/// <summary>
	/// Set/get the color for the block with \p data_object.
	/// </summary>
	public void GetBlockColor(vtkDataObject data_object, IntPtr color)
	{
		vtkCompositeDataDisplayAttributes_GetBlockColor_03(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef), color);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataDisplayAttributes_GetBlockColor_04(HandleRef pThis, HandleRef data_object, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the color for the block with \p data_object.
	/// </summary>
	public vtkColor3d GetBlockColor(vtkDataObject data_object)
	{
		vtkColor3d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataDisplayAttributes_GetBlockColor_04(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor3d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkCompositeDataDisplayAttributes_GetBlockMaterial_05(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Set/get the material for the block with data_object.
	/// Only rendering backends that support advanced materials need to respect these.
	/// </summary>
	public string GetBlockMaterial(vtkDataObject data_object)
	{
		return vtkCompositeDataDisplayAttributes_GetBlockMaterial_05(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompositeDataDisplayAttributes_GetBlockOpacity_06(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Set/get the opacity for the block with data_object.
	/// </summary>
	public double GetBlockOpacity(vtkDataObject data_object)
	{
		return vtkCompositeDataDisplayAttributes_GetBlockOpacity_06(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_GetBlockPickability_07(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Set/get the pickability for the block with \p data_object.
	/// </summary>
	public bool GetBlockPickability(vtkDataObject data_object)
	{
		return (vtkCompositeDataDisplayAttributes_GetBlockPickability_07(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_GetBlockVisibility_08(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Set/get the visibility for the block with \p data_object.
	/// </summary>
	public bool GetBlockVisibility(vtkDataObject data_object)
	{
		return (vtkCompositeDataDisplayAttributes_GetBlockVisibility_08(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataDisplayAttributes_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositeDataDisplayAttributes_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataDisplayAttributes_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositeDataDisplayAttributes_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockColor_11(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Returns true if the block with the given \p data_object has a color.
	/// </summary>
	public bool HasBlockColor(vtkDataObject data_object)
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockColor_11(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockColors_12(HandleRef pThis);

	/// <summary>
	/// Returns true if any block has any block color is set.
	/// </summary>
	public bool HasBlockColors()
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockColors_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockMaterial_13(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Returns true if the block with data_object has an material set.
	/// </summary>
	public bool HasBlockMaterial(vtkDataObject data_object)
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockMaterial_13(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockMaterials_14(HandleRef pThis);

	/// <summary>
	/// Returns true if any block has an material set.
	/// </summary>
	public bool HasBlockMaterials()
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockMaterials_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockOpacities_15(HandleRef pThis);

	/// <summary>
	/// Returns true if any block has an opacity set.
	/// </summary>
	public bool HasBlockOpacities()
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockOpacities_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockOpacity_16(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Returns true if the block with data_object has an opacity set.
	/// </summary>
	public bool HasBlockOpacity(vtkDataObject data_object)
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockOpacity_16(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockPickabilities_17(HandleRef pThis);

	/// <summary>
	/// Returns true if any block has any block pickability is set.
	/// </summary>
	public bool HasBlockPickabilities()
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockPickabilities_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockPickability_18(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Returns true if the block with the given data_object has a pickability
	/// set.
	/// </summary>
	public bool HasBlockPickability(vtkDataObject data_object)
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockPickability_18(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockVisibilities_19(HandleRef pThis);

	/// <summary>
	/// Returns true if any block has any block visibility is set.
	/// </summary>
	public bool HasBlockVisibilities()
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockVisibilities_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockVisibility_20(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Returns true if the block with the given data_object has a visibility
	/// set.
	/// </summary>
	public bool HasBlockVisibility(vtkDataObject data_object)
	{
		return (vtkCompositeDataDisplayAttributes_HasBlockVisibility_20(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataDisplayAttributes_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositeDataDisplayAttributes_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataDisplayAttributes_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositeDataDisplayAttributes_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataDisplayAttributes_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCompositeDataDisplayAttributes NewInstance()
	{
		vtkCompositeDataDisplayAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataDisplayAttributes_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockColor_25(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Removes the block color for the block with \p data_object.
	/// </summary>
	public void RemoveBlockColor(vtkDataObject data_object)
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockColor_25(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockColors_26(HandleRef pThis);

	/// <summary>
	/// Removes all block colors.
	/// </summary>
	public void RemoveBlockColors()
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockColors_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockMaterial_27(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Removes the set material for the block with data_object.
	/// </summary>
	public void RemoveBlockMaterial(vtkDataObject data_object)
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockMaterial_27(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockMaterials_28(HandleRef pThis);

	/// <summary>
	/// Removes all block materialss.
	/// </summary>
	public void RemoveBlockMaterials()
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockMaterials_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockOpacities_29(HandleRef pThis);

	/// <summary>
	/// Removes all block opacities.
	/// </summary>
	public void RemoveBlockOpacities()
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockOpacities_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockOpacity_30(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Removes the set opacity for the block with data_object.
	/// </summary>
	public void RemoveBlockOpacity(vtkDataObject data_object)
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockOpacity_30(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockPickabilities_31(HandleRef pThis);

	/// <summary>
	/// Removes all block pickability flags. This effectively sets the pickability
	/// for all blocks to true.
	/// </summary>
	public void RemoveBlockPickabilities()
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockPickabilities_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockPickability_32(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Removes the block pickability flag for the block with data_object.
	/// </summary>
	public void RemoveBlockPickability(vtkDataObject data_object)
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockPickability_32(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockVisibilities_33(HandleRef pThis);

	/// <summary>
	/// Removes all block visibility flags. This effectively sets the visibility
	/// for all blocks to true.
	/// </summary>
	public void RemoveBlockVisibilities()
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockVisibilities_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockVisibility_34(HandleRef pThis, HandleRef data_object);

	/// <summary>
	/// Removes the block visibility flag for the block with data_object.
	/// </summary>
	public void RemoveBlockVisibility(vtkDataObject data_object)
	{
		vtkCompositeDataDisplayAttributes_RemoveBlockVisibility_34(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataDisplayAttributes_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataDisplayAttributes SafeDownCast(vtkObjectBase o)
	{
		vtkCompositeDataDisplayAttributes vtkCompositeDataDisplayAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataDisplayAttributes_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataDisplayAttributes2 = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataDisplayAttributes2.Register(null);
			}
		}
		return vtkCompositeDataDisplayAttributes2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_SetBlockColor_36(HandleRef pThis, HandleRef data_object, IntPtr color);

	/// <summary>
	/// Set/get the color for the block with \p data_object.
	/// </summary>
	public void SetBlockColor(vtkDataObject data_object, IntPtr color)
	{
		vtkCompositeDataDisplayAttributes_SetBlockColor_36(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef), color);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_SetBlockMaterial_37(HandleRef pThis, HandleRef data_object, string material);

	/// <summary>
	/// Set/get the material for the block with data_object.
	/// Only rendering backends that support advanced materials need to respect these.
	/// </summary>
	public void SetBlockMaterial(vtkDataObject data_object, string material)
	{
		vtkCompositeDataDisplayAttributes_SetBlockMaterial_37(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef), material);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_SetBlockOpacity_38(HandleRef pThis, HandleRef data_object, double opacity);

	/// <summary>
	/// Set/get the opacity for the block with data_object.
	/// </summary>
	public void SetBlockOpacity(vtkDataObject data_object, double opacity)
	{
		vtkCompositeDataDisplayAttributes_SetBlockOpacity_38(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef), opacity);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_SetBlockPickability_39(HandleRef pThis, HandleRef data_object, byte visible);

	/// <summary>
	/// Set/get the pickability for the block with \p data_object.
	/// </summary>
	public void SetBlockPickability(vtkDataObject data_object, bool visible)
	{
		vtkCompositeDataDisplayAttributes_SetBlockPickability_39(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef), (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributes_SetBlockVisibility_40(HandleRef pThis, HandleRef data_object, byte visible);

	/// <summary>
	/// Set/get the visibility for the block with \p data_object.
	/// </summary>
	public void SetBlockVisibility(vtkDataObject data_object, bool visible)
	{
		vtkCompositeDataDisplayAttributes_SetBlockVisibility_40(GetCppThis(), data_object?.GetCppThis() ?? default(HandleRef), (byte)(visible ? 1u : 0u));
	}
}
/// <summary>
///    vtkCompositeDataDisplayAttributesLegacy
/// </summary>
/// <remarks>
///    rendering attributes for a
/// multi-block dataset.
///
/// The vtkCompositeDataDisplayAttributesLegacy class stores display attributes
/// for individual blocks in a multi-block dataset. Attributes are mapped to
/// blocks through their flat-index; This is the mechanism used in legacy
/// OpenGL classes.
/// </remarks>
public class vtkCompositeDataDisplayAttributesLegacy : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataDisplayAttributesLegacy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositeDataDisplayAttributesLegacy()
	{
		MRClassNameKey = "class vtkCompositeDataDisplayAttributesLegacy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataDisplayAttributesLegacy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositeDataDisplayAttributesLegacy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataDisplayAttributesLegacy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataDisplayAttributesLegacy New()
	{
		vtkCompositeDataDisplayAttributesLegacy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataDisplayAttributesLegacy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataDisplayAttributesLegacy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCompositeDataDisplayAttributesLegacy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompositeDataDisplayAttributesLegacy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_ComputeVisibleBounds_01(HandleRef cda, HandleRef dobj, IntPtr bounds);

	/// <summary>
	/// Removes all block opacities.
	/// </summary>
	public static void ComputeVisibleBounds(vtkCompositeDataDisplayAttributesLegacy cda, vtkDataObject dobj, IntPtr bounds)
	{
		vtkCompositeDataDisplayAttributesLegacy_ComputeVisibleBounds_01(cda?.GetCppThis() ?? default(HandleRef), dobj?.GetCppThis() ?? default(HandleRef), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_GetBlockColor_02(HandleRef pThis, uint flat_index, IntPtr color);

	/// <summary>
	/// Set/get the color for the block with \p flat_index.
	/// </summary>
	public void GetBlockColor(uint flat_index, IntPtr color)
	{
		vtkCompositeDataDisplayAttributesLegacy_GetBlockColor_02(GetCppThis(), flat_index, color);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataDisplayAttributesLegacy_GetBlockColor_03(HandleRef pThis, uint flat_index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the color for the block with \p flat_index.
	/// </summary>
	public vtkColor3d GetBlockColor(uint flat_index)
	{
		vtkColor3d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataDisplayAttributesLegacy_GetBlockColor_03(GetCppThis(), flat_index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor3d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompositeDataDisplayAttributesLegacy_GetBlockOpacity_04(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Set/get the opacity for the block with flat_index.
	/// </summary>
	public double GetBlockOpacity(uint flat_index)
	{
		return vtkCompositeDataDisplayAttributesLegacy_GetBlockOpacity_04(GetCppThis(), flat_index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_GetBlockPickability_05(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Set/get the visibility for the block with \p flat_index.
	/// </summary>
	public bool GetBlockPickability(uint flat_index)
	{
		return (vtkCompositeDataDisplayAttributesLegacy_GetBlockPickability_05(GetCppThis(), flat_index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_GetBlockVisibility_06(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Set/get the visibility for the block with \p flat_index.
	/// </summary>
	public bool GetBlockVisibility(uint flat_index)
	{
		return (vtkCompositeDataDisplayAttributesLegacy_GetBlockVisibility_06(GetCppThis(), flat_index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataDisplayAttributesLegacy_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositeDataDisplayAttributesLegacy_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataDisplayAttributesLegacy_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositeDataDisplayAttributesLegacy_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockColor_09(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Returns true if the block with the given \p flat_index has a color.
	/// </summary>
	public bool HasBlockColor(uint flat_index)
	{
		return (vtkCompositeDataDisplayAttributesLegacy_HasBlockColor_09(GetCppThis(), flat_index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockColors_10(HandleRef pThis);

	/// <summary>
	/// Returns true if any block has any block color is set.
	/// </summary>
	public bool HasBlockColors()
	{
		return (vtkCompositeDataDisplayAttributesLegacy_HasBlockColors_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockOpacities_11(HandleRef pThis);

	/// <summary>
	/// Returns true if any block has an opacity set.
	/// </summary>
	public bool HasBlockOpacities()
	{
		return (vtkCompositeDataDisplayAttributesLegacy_HasBlockOpacities_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockOpacity_12(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Returns true if the block with flat_index has an opacity set.
	/// </summary>
	public bool HasBlockOpacity(uint flat_index)
	{
		return (vtkCompositeDataDisplayAttributesLegacy_HasBlockOpacity_12(GetCppThis(), flat_index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockPickabilities_13(HandleRef pThis);

	/// <summary>
	/// Returns true if any block has any block visibility is set.
	/// </summary>
	public bool HasBlockPickabilities()
	{
		return (vtkCompositeDataDisplayAttributesLegacy_HasBlockPickabilities_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockPickability_14(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Returns true if the block with the given flat_index has a visibility
	/// set.
	/// </summary>
	public bool HasBlockPickability(uint flat_index)
	{
		return (vtkCompositeDataDisplayAttributesLegacy_HasBlockPickability_14(GetCppThis(), flat_index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockVisibilities_15(HandleRef pThis);

	/// <summary>
	/// Returns true if any block has any block visibility is set.
	/// </summary>
	public bool HasBlockVisibilities()
	{
		return (vtkCompositeDataDisplayAttributesLegacy_HasBlockVisibilities_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockVisibility_16(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Returns true if the block with the given flat_index has a visibility
	/// set.
	/// </summary>
	public bool HasBlockVisibility(uint flat_index)
	{
		return (vtkCompositeDataDisplayAttributesLegacy_HasBlockVisibility_16(GetCppThis(), flat_index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataDisplayAttributesLegacy_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositeDataDisplayAttributesLegacy_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataDisplayAttributesLegacy_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositeDataDisplayAttributesLegacy_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataDisplayAttributesLegacy_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCompositeDataDisplayAttributesLegacy NewInstance()
	{
		vtkCompositeDataDisplayAttributesLegacy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataDisplayAttributesLegacy_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataDisplayAttributesLegacy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockColor_21(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Removes the block color for the block with \p flat_index.
	/// </summary>
	public void RemoveBlockColor(uint flat_index)
	{
		vtkCompositeDataDisplayAttributesLegacy_RemoveBlockColor_21(GetCppThis(), flat_index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockColors_22(HandleRef pThis);

	/// <summary>
	/// Removes all block colors.
	/// </summary>
	public void RemoveBlockColors()
	{
		vtkCompositeDataDisplayAttributesLegacy_RemoveBlockColors_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockOpacities_23(HandleRef pThis);

	/// <summary>
	/// Removes all block opacities.
	/// </summary>
	public void RemoveBlockOpacities()
	{
		vtkCompositeDataDisplayAttributesLegacy_RemoveBlockOpacities_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockOpacity_24(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Removes the set opacity for the block with flat_index.
	/// </summary>
	public void RemoveBlockOpacity(uint flat_index)
	{
		vtkCompositeDataDisplayAttributesLegacy_RemoveBlockOpacity_24(GetCppThis(), flat_index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockPickabilities_25(HandleRef pThis);

	/// <summary>
	/// Removes all block visibility flags. The effectively sets the visibility
	/// for all blocks to true.
	/// </summary>
	public void RemoveBlockPickabilities()
	{
		vtkCompositeDataDisplayAttributesLegacy_RemoveBlockPickabilities_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockPickability_26(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Removes the block visibility flag for the block with flat_index.
	/// </summary>
	public void RemoveBlockPickability(uint flat_index)
	{
		vtkCompositeDataDisplayAttributesLegacy_RemoveBlockPickability_26(GetCppThis(), flat_index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockVisibilities_27(HandleRef pThis);

	/// <summary>
	/// Removes all block visibility flags. The effectively sets the visibility
	/// for all blocks to true.
	/// </summary>
	public void RemoveBlockVisibilities()
	{
		vtkCompositeDataDisplayAttributesLegacy_RemoveBlockVisibilities_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockVisibility_28(HandleRef pThis, uint flat_index);

	/// <summary>
	/// Removes the block visibility flag for the block with flat_index.
	/// </summary>
	public void RemoveBlockVisibility(uint flat_index)
	{
		vtkCompositeDataDisplayAttributesLegacy_RemoveBlockVisibility_28(GetCppThis(), flat_index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataDisplayAttributesLegacy_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataDisplayAttributesLegacy SafeDownCast(vtkObjectBase o)
	{
		vtkCompositeDataDisplayAttributesLegacy vtkCompositeDataDisplayAttributesLegacy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataDisplayAttributesLegacy_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataDisplayAttributesLegacy2 = (vtkCompositeDataDisplayAttributesLegacy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataDisplayAttributesLegacy2.Register(null);
			}
		}
		return vtkCompositeDataDisplayAttributesLegacy2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_SetBlockColor_30(HandleRef pThis, uint flat_index, IntPtr color);

	/// <summary>
	/// Set/get the color for the block with \p flat_index.
	/// </summary>
	public void SetBlockColor(uint flat_index, IntPtr color)
	{
		vtkCompositeDataDisplayAttributesLegacy_SetBlockColor_30(GetCppThis(), flat_index, color);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_SetBlockOpacity_31(HandleRef pThis, uint flat_index, double opacity);

	/// <summary>
	/// Set/get the opacity for the block with flat_index.
	/// </summary>
	public void SetBlockOpacity(uint flat_index, double opacity)
	{
		vtkCompositeDataDisplayAttributesLegacy_SetBlockOpacity_31(GetCppThis(), flat_index, opacity);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_SetBlockPickability_32(HandleRef pThis, uint flat_index, byte visible);

	/// <summary>
	/// Set/get the visibility for the block with \p flat_index.
	/// </summary>
	public void SetBlockPickability(uint flat_index, bool visible)
	{
		vtkCompositeDataDisplayAttributesLegacy_SetBlockPickability_32(GetCppThis(), flat_index, (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataDisplayAttributesLegacy_SetBlockVisibility_33(HandleRef pThis, uint flat_index, byte visible);

	/// <summary>
	/// Set/get the visibility for the block with \p flat_index.
	/// </summary>
	public void SetBlockVisibility(uint flat_index, bool visible)
	{
		vtkCompositeDataDisplayAttributesLegacy_SetBlockVisibility_33(GetCppThis(), flat_index, (byte)(visible ? 1u : 0u));
	}
}
