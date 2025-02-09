using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformationQuadratureSchemeDefinitionVectorKey
/// </summary>
/// <remarks>
///    Key for vtkQuadratureSchemeDefinition vector values.
///
/// vtkInformationQuadratureSchemeDefinitionVectorKey is used to represent keys for double
/// vector values in vtkInformation.h. NOTE the interface in this key differs
/// from that in other similar keys because of our internal use of smart
/// pointers.
/// </remarks>
public class vtkInformationQuadratureSchemeDefinitionVectorKey : vtkInformationKey
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformationQuadratureSchemeDefinitionVectorKey";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformationQuadratureSchemeDefinitionVectorKey()
	{
		MRClassNameKey = "class vtkInformationQuadratureSchemeDefinitionVectorKey";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationQuadratureSchemeDefinitionVectorKey"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformationQuadratureSchemeDefinitionVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef value);

	/// <summary>
	/// Put the value on the back of the vector, with reference counting.
	/// </summary>
	public void Append(vtkInformation info, vtkQuadratureSchemeDefinition value)
	{
		vtkInformationQuadratureSchemeDefinitionVectorKey_Append_01(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Clear_02(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Clear the vector.
	/// </summary>
	public void Clear(vtkInformation info)
	{
		vtkInformationQuadratureSchemeDefinitionVectorKey_Clear_02(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_DeepCopy_03(HandleRef pThis, HandleRef from, HandleRef to);

	/// <summary>
	/// Copy the entry associated with this key from one information
	/// object to another.  If there is no entry in the first information
	/// object for this key, the value is removed from the second.
	/// </summary>
	public override void DeepCopy(vtkInformation from, vtkInformation to)
	{
		vtkInformationQuadratureSchemeDefinitionVectorKey_DeepCopy_03(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), to?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationQuadratureSchemeDefinitionVectorKey_Get_04(HandleRef pThis, HandleRef info, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkQuadratureSchemeDefinition at a specific location in the vector.
	/// </summary>
	public vtkQuadratureSchemeDefinition Get(vtkInformation info, int idx)
	{
		vtkQuadratureSchemeDefinition vtkQuadratureSchemeDefinition2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationQuadratureSchemeDefinitionVectorKey_Get_04(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuadratureSchemeDefinition2 = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuadratureSchemeDefinition2.Register(null);
			}
		}
		return vtkQuadratureSchemeDefinition2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationQuadratureSchemeDefinitionVectorKey_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformationQuadratureSchemeDefinitionVectorKey_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationQuadratureSchemeDefinitionVectorKey_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformationQuadratureSchemeDefinitionVectorKey_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformationQuadratureSchemeDefinitionVectorKey_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformationQuadratureSchemeDefinitionVectorKey_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_Length_09(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get the vector's length.
	/// </summary>
	public int Length(vtkInformation info)
	{
		return vtkInformationQuadratureSchemeDefinitionVectorKey_Length_09(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationQuadratureSchemeDefinitionVectorKey_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInformationQuadratureSchemeDefinitionVectorKey NewInstance()
	{
		vtkInformationQuadratureSchemeDefinitionVectorKey result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationQuadratureSchemeDefinitionVectorKey_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationQuadratureSchemeDefinitionVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Resize_11(HandleRef pThis, HandleRef info, int n);

	/// <summary>
	/// Resize (extend) the vector to hold n objects. Any new elements
	/// created will be null initialized.
	/// </summary>
	public void Resize(vtkInformation info, int n)
	{
		vtkInformationQuadratureSchemeDefinitionVectorKey_Resize_11(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_RestoreState_12(HandleRef pThis, HandleRef info, HandleRef element);

	/// <summary>
	/// Load key/value pairs from an XML state representation created
	/// with SaveState. Duplicate keys will generate a fatal error.
	/// </summary>
	public int RestoreState(vtkInformation info, vtkXMLDataElement element)
	{
		return vtkInformationQuadratureSchemeDefinitionVectorKey_RestoreState_12(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), element?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationQuadratureSchemeDefinitionVectorKey_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformationQuadratureSchemeDefinitionVectorKey SafeDownCast(vtkObjectBase o)
	{
		vtkInformationQuadratureSchemeDefinitionVectorKey vtkInformationQuadratureSchemeDefinitionVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationQuadratureSchemeDefinitionVectorKey_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey2 = (vtkInformationQuadratureSchemeDefinitionVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationQuadratureSchemeDefinitionVectorKey2.Register(null);
			}
		}
		return vtkInformationQuadratureSchemeDefinitionVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_SaveState_14(HandleRef pThis, HandleRef info, HandleRef element);

	/// <summary>
	/// Generate an XML representation of the object. Each
	/// key/value pair will be nested in the resulting XML hierarchy.
	/// The element passed in is assumed to be empty.
	/// </summary>
	public int SaveState(vtkInformation info, vtkXMLDataElement element)
	{
		return vtkInformationQuadratureSchemeDefinitionVectorKey_SaveState_14(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), element?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Set_15(HandleRef pThis, HandleRef info, HandleRef value, int i);

	/// <summary>
	/// Set element i of the vector to value. Resizes the vector
	/// if needed.
	/// </summary>
	public void Set(vtkInformation info, vtkQuadratureSchemeDefinition value, int i)
	{
		vtkInformationQuadratureSchemeDefinitionVectorKey_Set_15(GetCppThis(), info?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef), i);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_ShallowCopy_16(HandleRef pThis, HandleRef from, HandleRef to);

	/// <summary>
	/// Copy the entry associated with this key from one information
	/// object to another.  If there is no entry in the first information
	/// object for this key, the value is removed from the second.
	/// </summary>
	public override void ShallowCopy(vtkInformation from, vtkInformation to)
	{
		vtkInformationQuadratureSchemeDefinitionVectorKey_ShallowCopy_16(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), to?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_Size_17(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Get the vector's length.
	/// </summary>
	public int Size(vtkInformation info)
	{
		return vtkInformationQuadratureSchemeDefinitionVectorKey_Size_17(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}
}
