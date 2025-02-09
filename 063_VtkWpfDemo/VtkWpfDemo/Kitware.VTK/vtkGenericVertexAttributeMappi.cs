using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericVertexAttributeMapping
/// </summary>
/// <remarks>
///    stores mapping for data arrays to
/// generic vertex attributes.
///
/// vtkGenericVertexAttributeMapping stores mapping between data arrays and
/// generic vertex attributes. It is used by vtkPainterPolyDataMapper to pass the
/// mappings to the painter which rendering the attributes.
/// @par Thanks:
/// Support for generic vertex attributes in VTK was contributed in
/// collaboration with Stephane Ploix at EDF.
/// </remarks>
public class vtkGenericVertexAttributeMapping : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericVertexAttributeMapping";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericVertexAttributeMapping()
	{
		MRClassNameKey = "class vtkGenericVertexAttributeMapping";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericVertexAttributeMapping"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericVertexAttributeMapping(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericVertexAttributeMapping_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericVertexAttributeMapping New()
	{
		vtkGenericVertexAttributeMapping result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericVertexAttributeMapping_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericVertexAttributeMapping)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGenericVertexAttributeMapping()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericVertexAttributeMapping_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGenericVertexAttributeMapping_AddMapping_01(HandleRef pThis, string attributeName, string arrayName, int fieldAssociation, int component);

	/// <summary>
	/// Select a data array from the point/cell data
	/// and map it to a generic vertex attribute.
	/// Note that indices change when a mapping is added/removed.
	/// </summary>
	public void AddMapping(string attributeName, string arrayName, int fieldAssociation, int component)
	{
		vtkGenericVertexAttributeMapping_AddMapping_01(GetCppThis(), attributeName, arrayName, fieldAssociation, component);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericVertexAttributeMapping_AddMapping_02(HandleRef pThis, int unit, string arrayName, int fieldAssociation, int component);

	/// <summary>
	/// Select a data array and use it as multitexture texture
	/// coordinates.
	/// Note the texture unit parameter should correspond to the texture
	/// unit set on the texture.
	/// </summary>
	public void AddMapping(int unit, string arrayName, int fieldAssociation, int component)
	{
		vtkGenericVertexAttributeMapping_AddMapping_02(GetCppThis(), unit, arrayName, fieldAssociation, component);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericVertexAttributeMapping_GetArrayName_03(HandleRef pThis, uint index);

	/// <summary>
	/// Get the array name at the given index.
	/// </summary>
	public string GetArrayName(uint index)
	{
		return Marshal.PtrToStringAnsi(vtkGenericVertexAttributeMapping_GetArrayName_03(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericVertexAttributeMapping_GetAttributeName_04(HandleRef pThis, uint index);

	/// <summary>
	/// Get the attribute name at the given index.
	/// </summary>
	public string GetAttributeName(uint index)
	{
		return Marshal.PtrToStringAnsi(vtkGenericVertexAttributeMapping_GetAttributeName_04(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericVertexAttributeMapping_GetComponent_05(HandleRef pThis, uint index);

	/// <summary>
	/// Get the component no. at the given index.
	/// </summary>
	public int GetComponent(uint index)
	{
		return vtkGenericVertexAttributeMapping_GetComponent_05(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericVertexAttributeMapping_GetFieldAssociation_06(HandleRef pThis, uint index);

	/// <summary>
	/// Get the field association at the given index.
	/// </summary>
	public int GetFieldAssociation(uint index)
	{
		return vtkGenericVertexAttributeMapping_GetFieldAssociation_06(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericVertexAttributeMapping_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericVertexAttributeMapping_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericVertexAttributeMapping_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericVertexAttributeMapping_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkGenericVertexAttributeMapping_GetNumberOfMappings_09(HandleRef pThis);

	/// <summary>
	/// Get number of mappings.
	/// </summary>
	public uint GetNumberOfMappings()
	{
		return vtkGenericVertexAttributeMapping_GetNumberOfMappings_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericVertexAttributeMapping_GetTextureUnit_10(HandleRef pThis, uint index);

	/// <summary>
	/// Get the component no. at the given index.
	/// </summary>
	public int GetTextureUnit(uint index)
	{
		return vtkGenericVertexAttributeMapping_GetTextureUnit_10(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericVertexAttributeMapping_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericVertexAttributeMapping_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericVertexAttributeMapping_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericVertexAttributeMapping_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericVertexAttributeMapping_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericVertexAttributeMapping NewInstance()
	{
		vtkGenericVertexAttributeMapping result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericVertexAttributeMapping_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericVertexAttributeMapping)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericVertexAttributeMapping_RemoveAllMappings_15(HandleRef pThis);

	/// <summary>
	/// Remove all mappings.
	/// </summary>
	public void RemoveAllMappings()
	{
		vtkGenericVertexAttributeMapping_RemoveAllMappings_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGenericVertexAttributeMapping_RemoveMapping_16(HandleRef pThis, string attributeName);

	/// <summary>
	/// Remove a vertex attribute mapping.
	/// </summary>
	public bool RemoveMapping(string attributeName)
	{
		return (vtkGenericVertexAttributeMapping_RemoveMapping_16(GetCppThis(), attributeName) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericVertexAttributeMapping_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericVertexAttributeMapping SafeDownCast(vtkObjectBase o)
	{
		vtkGenericVertexAttributeMapping vtkGenericVertexAttributeMapping2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericVertexAttributeMapping_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericVertexAttributeMapping2 = (vtkGenericVertexAttributeMapping)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericVertexAttributeMapping2.Register(null);
			}
		}
		return vtkGenericVertexAttributeMapping2;
	}
}
