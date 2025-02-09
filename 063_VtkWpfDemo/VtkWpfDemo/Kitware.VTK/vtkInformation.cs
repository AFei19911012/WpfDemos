using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformation
/// </summary>
/// <remarks>
///    Store vtkAlgorithm input/output information.
///
/// vtkInformation represents information and/or data for one input or
/// one output of a vtkAlgorithm.  It maps from keys to values of
/// several data types.  Instances of this class are collected in
/// vtkInformationVector instances and passed to
/// vtkAlgorithm::ProcessRequest calls.  The information and
/// data referenced by the instance on a particular input or output
/// define the request made to the vtkAlgorithm instance.
/// </remarks>
public class vtkInformation : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformation()
	{
		MRClassNameKey = "class vtkInformation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformation New()
	{
		vtkInformation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInformation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInformation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_01(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationVariantVectorKey key, vtkVariant value)
	{
		vtkInformation_Append_01(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_02(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationKey value)
	{
		vtkInformation_Append_02(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_03(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationDataObjectKey value)
	{
		vtkInformation_Append_03(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_04(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationDoubleKey value)
	{
		vtkInformation_Append_04(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_05(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationDoubleVectorKey value)
	{
		vtkInformation_Append_05(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_06(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationInformationKey value)
	{
		vtkInformation_Append_06(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_07(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationInformationVectorKey value)
	{
		vtkInformation_Append_07(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_08(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationIntegerKey value)
	{
		vtkInformation_Append_08(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_09(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationIntegerVectorKey value)
	{
		vtkInformation_Append_09(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_10(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationStringKey value)
	{
		vtkInformation_Append_10(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_11(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationStringVectorKey value)
	{
		vtkInformation_Append_11(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_12(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationObjectBaseKey value)
	{
		vtkInformation_Append_12(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_13(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationKeyVectorKey key, vtkInformationUnsignedLongKey value)
	{
		vtkInformation_Append_13(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_14(HandleRef pThis, HandleRef key, HandleRef data);

	/// <summary>
	/// Manipulate a ObjectBaseVector entry.
	/// </summary>
	public void Append(vtkInformationObjectBaseVectorKey key, vtkObjectBase data)
	{
		vtkInformation_Append_14(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_15(HandleRef pThis, HandleRef from, int deep);

	/// <summary>
	/// Append all information entries from the given vtkInformation
	/// instance. If deep==1, a deep copy of the information structure is performed
	/// (new instances of any contained vtkInformation and vtkInformationVector
	/// objects are created).
	/// </summary>
	public void Append(vtkInformation from, int deep)
	{
		vtkInformation_Append_15(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_16(HandleRef pThis, HandleRef key, int value);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationIntegerVectorKey key, int value)
	{
		vtkInformation_Append_16(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_17(HandleRef pThis, HandleRef key, string value);

	/// <summary>
	/// Get/Set a string-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationStringVectorKey key, string value)
	{
		vtkInformation_Append_17(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Append_18(HandleRef pThis, HandleRef key, double value);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public void Append(vtkInformationDoubleVectorKey key, double value)
	{
		vtkInformation_Append_18(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_19(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationKey value)
	{
		vtkInformation_AppendUnique_19(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_20(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationDataObjectKey value)
	{
		vtkInformation_AppendUnique_20(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_21(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationDoubleKey value)
	{
		vtkInformation_AppendUnique_21(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_22(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationDoubleVectorKey value)
	{
		vtkInformation_AppendUnique_22(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_23(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationInformationKey value)
	{
		vtkInformation_AppendUnique_23(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_24(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationInformationVectorKey value)
	{
		vtkInformation_AppendUnique_24(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_25(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationIntegerKey value)
	{
		vtkInformation_AppendUnique_25(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_26(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationIntegerVectorKey value)
	{
		vtkInformation_AppendUnique_26(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_27(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationStringKey value)
	{
		vtkInformation_AppendUnique_27(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_28(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationStringVectorKey value)
	{
		vtkInformation_AppendUnique_28(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_29(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationObjectBaseKey value)
	{
		vtkInformation_AppendUnique_29(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_AppendUnique_30(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationUnsignedLongKey value)
	{
		vtkInformation_AppendUnique_30(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Clear_31(HandleRef pThis);

	/// <summary>
	/// Clear all information entries.
	/// </summary>
	public void Clear()
	{
		vtkInformation_Clear_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Copy_32(HandleRef pThis, HandleRef from, int deep);

	/// <summary>
	/// Copy all information entries from the given vtkInformation
	/// instance.  Any previously existing entries are removed.  If
	/// deep==1, a deep copy of the information structure is performed (new
	/// instances of any contained vtkInformation and vtkInformationVector
	/// objects are created).
	/// </summary>
	public void Copy(vtkInformation from, int deep)
	{
		vtkInformation_Copy_32(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntries_33(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Use the given key to lookup a list of other keys in the given
	/// information object.  The key/value pairs associated with these
	/// other keys will be copied.  If deep==1, a deep copy of the
	/// information structure is performed.
	/// </summary>
	public void CopyEntries(vtkInformation from, vtkInformationKeyVectorKey key, int deep)
	{
		vtkInformation_CopyEntries_33(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_34(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationKey key, int deep)
	{
		vtkInformation_CopyEntry_34(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_35(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationDataObjectKey key, int deep)
	{
		vtkInformation_CopyEntry_35(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_36(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationDoubleVectorKey key, int deep)
	{
		vtkInformation_CopyEntry_36(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_37(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationVariantKey key, int deep)
	{
		vtkInformation_CopyEntry_37(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_38(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationVariantVectorKey key, int deep)
	{
		vtkInformation_CopyEntry_38(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_39(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationInformationKey key, int deep)
	{
		vtkInformation_CopyEntry_39(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_40(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationInformationVectorKey key, int deep)
	{
		vtkInformation_CopyEntry_40(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_41(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationIntegerKey key, int deep)
	{
		vtkInformation_CopyEntry_41(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_42(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationIntegerVectorKey key, int deep)
	{
		vtkInformation_CopyEntry_42(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_43(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationObjectBaseVectorKey key, int deep)
	{
		vtkInformation_CopyEntry_43(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_44(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationRequestKey key, int deep)
	{
		vtkInformation_CopyEntry_44(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_45(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationStringKey key, int deep)
	{
		vtkInformation_CopyEntry_45(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_46(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationStringVectorKey key, int deep)
	{
		vtkInformation_CopyEntry_46(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_CopyEntry_47(HandleRef pThis, HandleRef from, HandleRef key, int deep);

	/// <summary>
	/// Copy the key/value pair associated with the given key in the
	/// given information object.  If deep=1, a deep copy of the information
	/// structure is performed (new instances of any contained vtkInformation and
	/// vtkInformationVector objects are created).
	/// </summary>
	public void CopyEntry(vtkInformation from, vtkInformationUnsignedLongKey key, int deep)
	{
		vtkInformation_CopyEntry_47(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), key?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_48(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public vtkVariant Get(vtkInformationVariantVectorKey key)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_Get_48(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_49(HandleRef pThis, HandleRef key, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public vtkVariant Get(vtkInformationVariantVectorKey key, int idx)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_Get_49(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Get_50(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public void Get(vtkInformationVariantVectorKey key, vtkVariant value)
	{
		vtkInformation_Get_50(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_51(HandleRef pThis, HandleRef key, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public vtkInformationKey Get(vtkInformationKeyVectorKey key, int idx)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_Get_51(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_52(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a string-valued entry.
	/// </summary>
	public string Get(vtkInformationStringKey key)
	{
		return Marshal.PtrToStringAnsi(vtkInformation_Get_52(GetCppThis(), key?.GetCppThis() ?? default(HandleRef)));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_53(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set an entry storing another vtkInformation instance.
	/// </summary>
	public vtkInformation Get(vtkInformationInformationKey key)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_Get_53(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_54(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set an entry storing a vtkInformationVector instance.
	/// </summary>
	public vtkInformationVector Get(vtkInformationInformationVectorKey key)
	{
		vtkInformationVector vtkInformationVector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_Get_54(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationVector2 = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationVector2.Register(null);
			}
		}
		return vtkInformationVector2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_55(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set an entry storing a vtkObjectBase instance.
	/// </summary>
	public vtkObjectBase Get(vtkInformationObjectBaseKey key)
	{
		vtkObjectBase vtkObjectBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_Get_55(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObjectBase2 = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObjectBase2.Register(null);
			}
		}
		return vtkObjectBase2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_56(HandleRef pThis, HandleRef key, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Manipulate a ObjectBaseVector entry.
	/// </summary>
	public vtkObjectBase Get(vtkInformationObjectBaseVectorKey key, int idx)
	{
		vtkObjectBase vtkObjectBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_Get_56(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObjectBase2 = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObjectBase2.Register(null);
			}
		}
		return vtkObjectBase2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_57(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set an entry storing a vtkDataObject instance.
	/// </summary>
	public vtkDataObject Get(vtkInformationDataObjectKey key)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_Get_57(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Get_58(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-valued entry.
	/// </summary>
	public int Get(vtkInformationIntegerKey key)
	{
		return vtkInformation_Get_58(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformation_Get_59(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a vtkIdType-valued entry.
	/// </summary>
	public long Get(vtkInformationIdTypeKey key)
	{
		return vtkInformation_Get_59(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInformation_Get_60(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an double-valued entry.
	/// </summary>
	public double Get(vtkInformationDoubleKey key)
	{
		return vtkInformation_Get_60(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_61(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set an variant-valued entry.
	/// </summary>
	public vtkVariant Get(vtkInformationVariantKey key)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_Get_61(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_62(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public IntPtr Get(vtkInformationIntegerVectorKey key)
	{
		return vtkInformation_Get_62(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Get_63(HandleRef pThis, HandleRef key, int idx);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public int Get(vtkInformationIntegerVectorKey key, int idx)
	{
		return vtkInformation_Get_63(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), idx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Get_64(HandleRef pThis, HandleRef key, IntPtr value);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public void Get(vtkInformationIntegerVectorKey key, IntPtr value)
	{
		vtkInformation_Get_64(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_65(HandleRef pThis, HandleRef key, int idx);

	/// <summary>
	/// Get/Set a string-vector-valued entry.
	/// </summary>
	public string Get(vtkInformationStringVectorKey key, int idx)
	{
		return Marshal.PtrToStringAnsi(vtkInformation_Get_65(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), idx));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_66(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-pointer-valued entry.
	/// </summary>
	public IntPtr Get(vtkInformationIntegerPointerKey key)
	{
		return vtkInformation_Get_66(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Get_67(HandleRef pThis, HandleRef key, IntPtr value);

	/// <summary>
	/// Get/Set an integer-pointer-valued entry.
	/// </summary>
	public void Get(vtkInformationIntegerPointerKey key, IntPtr value)
	{
		vtkInformation_Get_67(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkInformation_Get_68(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an unsigned-long-valued entry.
	/// </summary>
	public uint Get(vtkInformationUnsignedLongKey key)
	{
		return vtkInformation_Get_68(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_Get_69(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public IntPtr Get(vtkInformationDoubleVectorKey key)
	{
		return vtkInformation_Get_69(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInformation_Get_70(HandleRef pThis, HandleRef key, int idx);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public double Get(vtkInformationDoubleVectorKey key, int idx)
	{
		return vtkInformation_Get_70(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), idx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Get_71(HandleRef pThis, HandleRef key, IntPtr value);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public void Get(vtkInformationDoubleVectorKey key, IntPtr value)
	{
		vtkInformation_Get_71(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_72(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationDataObjectKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_72(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_73(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationDoubleKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_73(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_74(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationDoubleVectorKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_74(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_75(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationInformationKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_75(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_76(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationInformationVectorKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_76(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_77(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationIntegerKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_77(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_78(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationIntegerVectorKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_78(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_79(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationRequestKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_79(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_80(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationStringKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_80(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_81(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationStringVectorKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_81(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_82(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_82(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_83(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationUnsignedLongKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_83(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_84(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationVariantKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_84(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetKey_85(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Upcast the given key instance.
	/// </summary>
	public static vtkInformationKey GetKey(vtkInformationVariantVectorKey key)
	{
		vtkInformationKey vtkInformationKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetKey_85(key?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationKey2 = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationKey2.Register(null);
			}
		}
		return vtkInformationKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformation_GetNumberOfGenerationsFromBase_86(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformation_GetNumberOfGenerationsFromBase_86(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformation_GetNumberOfGenerationsFromBaseType_87(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformation_GetNumberOfGenerationsFromBaseType_87(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_GetNumberOfKeys_88(HandleRef pThis);

	/// <summary>
	/// Return the number of keys in this information object (as would be returned
	/// by iterating over the keys).
	/// </summary>
	public int GetNumberOfKeys()
	{
		return vtkInformation_GetNumberOfKeys_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_GetRequest_89(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the Request ivar
	/// </summary>
	public vtkInformationRequestKey GetRequest()
	{
		vtkInformationRequestKey vtkInformationRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_GetRequest_89(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationRequestKey2 = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationRequestKey2.Register(null);
			}
		}
		return vtkInformationRequestKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_90(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public int Has(vtkInformationDoubleVectorKey key)
	{
		return vtkInformation_Has_90(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_91(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public int Has(vtkInformationVariantVectorKey key)
	{
		return vtkInformation_Has_91(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_92(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public int Has(vtkInformationKeyVectorKey key)
	{
		return vtkInformation_Has_92(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_93(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a string-valued entry.
	/// </summary>
	public int Has(vtkInformationStringKey key)
	{
		return vtkInformation_Has_93(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_94(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an entry storing another vtkInformation instance.
	/// </summary>
	public int Has(vtkInformationInformationKey key)
	{
		return vtkInformation_Has_94(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_95(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an entry storing a vtkInformationVector instance.
	/// </summary>
	public int Has(vtkInformationInformationVectorKey key)
	{
		return vtkInformation_Has_95(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_96(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an entry storing a vtkObjectBase instance.
	/// </summary>
	public int Has(vtkInformationObjectBaseKey key)
	{
		return vtkInformation_Has_96(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_97(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Manipulate a ObjectBaseVector entry.
	/// </summary>
	public int Has(vtkInformationObjectBaseVectorKey key)
	{
		return vtkInformation_Has_97(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_98(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an entry storing a vtkDataObject instance.
	/// </summary>
	public int Has(vtkInformationDataObjectKey key)
	{
		return vtkInformation_Has_98(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_99(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Check whether the given key appears in this information object.
	/// </summary>
	public int Has(vtkInformationKey key)
	{
		return vtkInformation_Has_99(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_100(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a request-valued entry.
	/// </summary>
	public int Has(vtkInformationRequestKey key)
	{
		return vtkInformation_Has_100(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_101(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-valued entry.
	/// </summary>
	public int Has(vtkInformationIntegerKey key)
	{
		return vtkInformation_Has_101(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_102(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a vtkIdType-valued entry.
	/// </summary>
	public int Has(vtkInformationIdTypeKey key)
	{
		return vtkInformation_Has_102(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_103(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an double-valued entry.
	/// </summary>
	public int Has(vtkInformationDoubleKey key)
	{
		return vtkInformation_Has_103(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_104(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an variant-valued entry.
	/// </summary>
	public int Has(vtkInformationVariantKey key)
	{
		return vtkInformation_Has_104(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_105(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public int Has(vtkInformationIntegerVectorKey key)
	{
		return vtkInformation_Has_105(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_106(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a string-vector-valued entry.
	/// </summary>
	public int Has(vtkInformationStringVectorKey key)
	{
		return vtkInformation_Has_106(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_107(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-pointer-valued entry.
	/// </summary>
	public int Has(vtkInformationIntegerPointerKey key)
	{
		return vtkInformation_Has_107(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Has_108(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an unsigned-long-valued entry.
	/// </summary>
	public int Has(vtkInformationUnsignedLongKey key)
	{
		return vtkInformation_Has_108(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_IsA_109(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformation_IsA_109(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_IsTypeOf_110(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformation_IsTypeOf_110(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Length_111(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public int Length(vtkInformationDoubleVectorKey key)
	{
		return vtkInformation_Length_111(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Length_112(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public int Length(vtkInformationVariantVectorKey key)
	{
		return vtkInformation_Length_112(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Length_113(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public int Length(vtkInformationKeyVectorKey key)
	{
		return vtkInformation_Length_113(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Length_114(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Manipulate a ObjectBaseVector entry.
	/// </summary>
	public int Length(vtkInformationObjectBaseVectorKey key)
	{
		return vtkInformation_Length_114(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Length_115(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public int Length(vtkInformationIntegerVectorKey key)
	{
		return vtkInformation_Length_115(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Length_116(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a string-vector-valued entry.
	/// </summary>
	public int Length(vtkInformationStringVectorKey key)
	{
		return vtkInformation_Length_116(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformation_Length_117(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-pointer-valued entry.
	/// </summary>
	public int Length(vtkInformationIntegerPointerKey key)
	{
		return vtkInformation_Length_117(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Modified_118(HandleRef pThis);

	/// <summary>
	/// Modified signature with no arguments that calls Modified
	/// on vtkObject superclass.
	/// </summary>
	public override void Modified()
	{
		vtkInformation_Modified_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Modified_119(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Modified signature that takes an information key as an argument.
	/// Sets the new MTime and invokes a modified event with the
	/// information key as call data.
	/// </summary>
	public void Modified(vtkInformationKey key)
	{
		vtkInformation_Modified_119(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_NewInstance_121(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInformation NewInstance()
	{
		vtkInformation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_NewInstance_121(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_122(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public void Remove(vtkInformationDoubleVectorKey key)
	{
		vtkInformation_Remove_122(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_123(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public void Remove(vtkInformationVariantVectorKey key)
	{
		vtkInformation_Remove_123(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_124(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Remove(vtkInformationKeyVectorKey key, vtkInformationKey value)
	{
		vtkInformation_Remove_124(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_125(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an InformationKey-vector-valued entry.
	/// </summary>
	public void Remove(vtkInformationKeyVectorKey key)
	{
		vtkInformation_Remove_125(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_126(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a string-valued entry.
	/// </summary>
	public void Remove(vtkInformationStringKey key)
	{
		vtkInformation_Remove_126(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_127(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an entry storing another vtkInformation instance.
	/// </summary>
	public void Remove(vtkInformationInformationKey key)
	{
		vtkInformation_Remove_127(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_128(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an entry storing a vtkInformationVector instance.
	/// </summary>
	public void Remove(vtkInformationInformationVectorKey key)
	{
		vtkInformation_Remove_128(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_129(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an entry storing a vtkObjectBase instance.
	/// </summary>
	public void Remove(vtkInformationObjectBaseKey key)
	{
		vtkInformation_Remove_129(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_130(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Manipulate a ObjectBaseVector entry.
	/// </summary>
	public void Remove(vtkInformationObjectBaseVectorKey key)
	{
		vtkInformation_Remove_130(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_131(HandleRef pThis, HandleRef key, HandleRef objectToRemove);

	/// <summary>
	/// Manipulate a ObjectBaseVector entry.
	/// </summary>
	public void Remove(vtkInformationObjectBaseVectorKey key, vtkObjectBase objectToRemove)
	{
		vtkInformation_Remove_131(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), objectToRemove?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_132(HandleRef pThis, HandleRef key, int indexToRemove);

	/// <summary>
	/// Manipulate a ObjectBaseVector entry.
	/// </summary>
	public void Remove(vtkInformationObjectBaseVectorKey key, int indexToRemove)
	{
		vtkInformation_Remove_132(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), indexToRemove);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_133(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an entry storing a vtkDataObject instance.
	/// </summary>
	public void Remove(vtkInformationDataObjectKey key)
	{
		vtkInformation_Remove_133(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_134(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Remove the given key and its data from this information object.
	/// </summary>
	public void Remove(vtkInformationKey key)
	{
		vtkInformation_Remove_134(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_135(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a request-valued entry.
	/// </summary>
	public void Remove(vtkInformationRequestKey key)
	{
		vtkInformation_Remove_135(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_136(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-valued entry.
	/// </summary>
	public void Remove(vtkInformationIntegerKey key)
	{
		vtkInformation_Remove_136(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_137(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a vtkIdType-valued entry.
	/// </summary>
	public void Remove(vtkInformationIdTypeKey key)
	{
		vtkInformation_Remove_137(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_138(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an double-valued entry.
	/// </summary>
	public void Remove(vtkInformationDoubleKey key)
	{
		vtkInformation_Remove_138(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_139(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an variant-valued entry.
	/// </summary>
	public void Remove(vtkInformationVariantKey key)
	{
		vtkInformation_Remove_139(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_140(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public void Remove(vtkInformationIntegerVectorKey key)
	{
		vtkInformation_Remove_140(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_141(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a string-vector-valued entry.
	/// </summary>
	public void Remove(vtkInformationStringVectorKey key)
	{
		vtkInformation_Remove_141(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_142(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an integer-pointer-valued entry.
	/// </summary>
	public void Remove(vtkInformationIntegerPointerKey key)
	{
		vtkInformation_Remove_142(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Remove_143(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set an unsigned-long-valued entry.
	/// </summary>
	public void Remove(vtkInformationUnsignedLongKey key)
	{
		vtkInformation_Remove_143(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformation_SafeDownCast_144(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformation SafeDownCast(vtkObjectBase o)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformation_SafeDownCast_144(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_145(HandleRef pThis, HandleRef key, HandleRef value, int length);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationVariantVectorKey key, vtkVariant value, int length)
	{
		vtkInformation_Set_145(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef), length);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_146(HandleRef pThis, HandleRef key, HandleRef value1, HandleRef value2, HandleRef value3);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationVariantVectorKey key, vtkVariant value1, vtkVariant value2, vtkVariant value3)
	{
		vtkInformation_Set_146(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value1?.GetCppThis() ?? default(HandleRef), value2?.GetCppThis() ?? default(HandleRef), value3?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_147(HandleRef pThis, HandleRef key, HandleRef value1, HandleRef value2, HandleRef value3, HandleRef value4, HandleRef value5, HandleRef value6);

	/// <summary>
	/// Get/Set an variant-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationVariantVectorKey key, vtkVariant value1, vtkVariant value2, vtkVariant value3, vtkVariant value4, vtkVariant value5, vtkVariant value6)
	{
		vtkInformation_Set_147(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value1?.GetCppThis() ?? default(HandleRef), value2?.GetCppThis() ?? default(HandleRef), value3?.GetCppThis() ?? default(HandleRef), value4?.GetCppThis() ?? default(HandleRef), value5?.GetCppThis() ?? default(HandleRef), value6?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_148(HandleRef pThis, HandleRef key, string arg1);

	/// <summary>
	/// Get/Set a string-valued entry.
	/// </summary>
	public void Set(vtkInformationStringKey key, string arg1)
	{
		vtkInformation_Set_148(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), arg1);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_149(HandleRef pThis, HandleRef key, HandleRef arg1);

	/// <summary>
	/// Get/Set an entry storing another vtkInformation instance.
	/// </summary>
	public void Set(vtkInformationInformationKey key, vtkInformation arg1)
	{
		vtkInformation_Set_149(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_150(HandleRef pThis, HandleRef key, HandleRef arg1);

	/// <summary>
	/// Get/Set an entry storing a vtkInformationVector instance.
	/// </summary>
	public void Set(vtkInformationInformationVectorKey key, vtkInformationVector arg1)
	{
		vtkInformation_Set_150(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_151(HandleRef pThis, HandleRef key, HandleRef arg1);

	/// <summary>
	/// Get/Set an entry storing a vtkObjectBase instance.
	/// </summary>
	public void Set(vtkInformationObjectBaseKey key, vtkObjectBase arg1)
	{
		vtkInformation_Set_151(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_152(HandleRef pThis, HandleRef key, HandleRef value, int idx);

	/// <summary>
	/// Manipulate a ObjectBaseVector entry.
	/// </summary>
	public void Set(vtkInformationObjectBaseVectorKey key, vtkObjectBase value, int idx)
	{
		vtkInformation_Set_152(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef), idx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_153(HandleRef pThis, HandleRef key, HandleRef arg1);

	/// <summary>
	/// Get/Set an entry storing a vtkDataObject instance.
	/// </summary>
	public void Set(vtkInformationDataObjectKey key, vtkDataObject arg1)
	{
		vtkInformation_Set_153(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_154(HandleRef pThis, HandleRef key);

	/// <summary>
	/// Get/Set a request-valued entry.
	/// </summary>
	public void Set(vtkInformationRequestKey key)
	{
		vtkInformation_Set_154(GetCppThis(), key?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_155(HandleRef pThis, HandleRef key, int value);

	/// <summary>
	/// Get/Set an integer-valued entry.
	/// </summary>
	public void Set(vtkInformationIntegerKey key, int value)
	{
		vtkInformation_Set_155(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_156(HandleRef pThis, HandleRef key, long value);

	/// <summary>
	/// Get/Set a vtkIdType-valued entry.
	/// </summary>
	public void Set(vtkInformationIdTypeKey key, long value)
	{
		vtkInformation_Set_156(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_157(HandleRef pThis, HandleRef key, double value);

	/// <summary>
	/// Get/Set an double-valued entry.
	/// </summary>
	public void Set(vtkInformationDoubleKey key, double value)
	{
		vtkInformation_Set_157(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_158(HandleRef pThis, HandleRef key, HandleRef value);

	/// <summary>
	/// Get/Set an variant-valued entry.
	/// </summary>
	public void Set(vtkInformationVariantKey key, vtkVariant value)
	{
		vtkInformation_Set_158(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_159(HandleRef pThis, HandleRef key, IntPtr value, int length);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationIntegerVectorKey key, IntPtr value, int length)
	{
		vtkInformation_Set_159(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value, length);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_160(HandleRef pThis, HandleRef key, int value1, int value2, int value3);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationIntegerVectorKey key, int value1, int value2, int value3)
	{
		vtkInformation_Set_160(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value1, value2, value3);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_161(HandleRef pThis, HandleRef key, int value1, int value2, int value3, int value4, int value5, int value6);

	/// <summary>
	/// Get/Set an integer-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationIntegerVectorKey key, int value1, int value2, int value3, int value4, int value5, int value6)
	{
		vtkInformation_Set_161(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value1, value2, value3, value4, value5, value6);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_162(HandleRef pThis, HandleRef key, string value, int idx);

	/// <summary>
	/// Get/Set a string-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationStringVectorKey key, string value, int idx)
	{
		vtkInformation_Set_162(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value, idx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_163(HandleRef pThis, HandleRef key, IntPtr value, int length);

	/// <summary>
	/// Get/Set an integer-pointer-valued entry.
	/// </summary>
	public void Set(vtkInformationIntegerPointerKey key, IntPtr value, int length)
	{
		vtkInformation_Set_163(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value, length);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_164(HandleRef pThis, HandleRef key, uint value);

	/// <summary>
	/// Get/Set an unsigned-long-valued entry.
	/// </summary>
	public void Set(vtkInformationUnsignedLongKey key, uint value)
	{
		vtkInformation_Set_164(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_165(HandleRef pThis, HandleRef key, IntPtr value, int length);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationDoubleVectorKey key, IntPtr value, int length)
	{
		vtkInformation_Set_165(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value, length);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_166(HandleRef pThis, HandleRef key, double value1, double value2, double value3);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationDoubleVectorKey key, double value1, double value2, double value3)
	{
		vtkInformation_Set_166(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value1, value2, value3);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_Set_167(HandleRef pThis, HandleRef key, double value1, double value2, double value3, double value4, double value5, double value6);

	/// <summary>
	/// Get/Set an double-vector-valued entry.
	/// </summary>
	public void Set(vtkInformationDoubleVectorKey key, double value1, double value2, double value3, double value4, double value5, double value6)
	{
		vtkInformation_Set_167(GetCppThis(), key?.GetCppThis() ?? default(HandleRef), value1, value2, value3, value4, value5, value6);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformation_SetRequest_168(HandleRef pThis, HandleRef request);

	/// <summary>
	/// Get/Set the Request ivar
	/// </summary>
	public void SetRequest(vtkInformationRequestKey request)
	{
		vtkInformation_SetRequest_168(GetCppThis(), request?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInformation_UsesGarbageCollector_169(HandleRef pThis);

	/// <summary>
	/// Initiate garbage collection when a reference is removed.
	/// </summary>
	public override bool UsesGarbageCollector()
	{
		return (vtkInformation_UsesGarbageCollector_169(GetCppThis()) != 0) ? true : false;
	}
}
