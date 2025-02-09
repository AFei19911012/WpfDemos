using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTransferAttributes
/// </summary>
/// <remarks>
///    transfer data from a graph representation
/// to a tree representation using direct mapping or pedigree ids.
///
///
/// The filter requires
/// both a vtkGraph and vtkTree as input.  The tree vertices must be a
/// superset of the graph vertices.  A common example is when the graph vertices
/// correspond to the leaves of the tree, but the internal vertices of the tree
/// represent groupings of graph vertices.  The algorithm matches the vertices
/// using the array "PedigreeId".  The user may alternately set the
/// DirectMapping flag to indicate that the two structures must have directly
/// corresponding offsets (i.e. node i in the graph must correspond to node i in
/// the tree).
///
/// </remarks>
public class vtkTransferAttributes : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTransferAttributes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTransferAttributes()
	{
		MRClassNameKey = "class vtkTransferAttributes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransferAttributes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTransferAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransferAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a vtkTransferAttributes object.
	/// Initial values are DirectMapping = false, DefaultValue = 1,
	/// SourceArrayName=0, TargetArrayName = 0,
	/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
	/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// </summary>
	public new static vtkTransferAttributes New()
	{
		vtkTransferAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransferAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransferAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a vtkTransferAttributes object.
	/// Initial values are DirectMapping = false, DefaultValue = 1,
	/// SourceArrayName=0, TargetArrayName = 0,
	/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
	/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// </summary>
	public vtkTransferAttributes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTransferAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransferAttributes_DirectMappingOff_01(HandleRef pThis);

	/// <summary>
	/// If on, uses direct mapping from tree to graph vertices.
	/// If off, both the graph and tree must contain PedigreeId arrays
	/// which are used to match graph and tree vertices.
	/// Default is off.
	/// </summary>
	public virtual void DirectMappingOff()
	{
		vtkTransferAttributes_DirectMappingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransferAttributes_DirectMappingOn_02(HandleRef pThis);

	/// <summary>
	/// If on, uses direct mapping from tree to graph vertices.
	/// If off, both the graph and tree must contain PedigreeId arrays
	/// which are used to match graph and tree vertices.
	/// Default is off.
	/// </summary>
	public virtual void DirectMappingOn()
	{
		vtkTransferAttributes_DirectMappingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransferAttributes_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Set the input type of the algorithm to vtkGraph.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkTransferAttributes_FillInputPortInformation_03(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransferAttributes_GetDefaultValue_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Method to get/set the default value.
	/// </summary>
	public vtkVariant GetDefaultValue()
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransferAttributes_GetDefaultValue_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTransferAttributes_GetDirectMapping_05(HandleRef pThis);

	/// <summary>
	/// If on, uses direct mapping from tree to graph vertices.
	/// If off, both the graph and tree must contain PedigreeId arrays
	/// which are used to match graph and tree vertices.
	/// Default is off.
	/// </summary>
	public virtual bool GetDirectMapping()
	{
		return (vtkTransferAttributes_GetDirectMapping_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransferAttributes_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Create a vtkTransferAttributes object.
	/// Initial values are DirectMapping = false, DefaultValue = 1,
	/// SourceArrayName=0, TargetArrayName = 0,
	/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
	/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTransferAttributes_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransferAttributes_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Create a vtkTransferAttributes object.
	/// Initial values are DirectMapping = false, DefaultValue = 1,
	/// SourceArrayName=0, TargetArrayName = 0,
	/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
	/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTransferAttributes_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransferAttributes_GetSourceArrayName_08(HandleRef pThis);

	/// <summary>
	/// The field name to use for storing the source array.
	/// </summary>
	public virtual string GetSourceArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTransferAttributes_GetSourceArrayName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransferAttributes_GetSourceFieldType_09(HandleRef pThis);

	/// <summary>
	/// The source field type for accessing the source array. Valid values are
	/// those from enum vtkDataObject::FieldAssociations.
	/// </summary>
	public virtual int GetSourceFieldType()
	{
		return vtkTransferAttributes_GetSourceFieldType_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransferAttributes_GetTargetArrayName_10(HandleRef pThis);

	/// <summary>
	/// The field name to use for storing the source array.
	/// </summary>
	public virtual string GetTargetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTransferAttributes_GetTargetArrayName_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransferAttributes_GetTargetFieldType_11(HandleRef pThis);

	/// <summary>
	/// The target field type for accessing the target array. Valid values are
	/// those from enum vtkDataObject::FieldAssociations.
	/// </summary>
	public virtual int GetTargetFieldType()
	{
		return vtkTransferAttributes_GetTargetFieldType_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransferAttributes_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Create a vtkTransferAttributes object.
	/// Initial values are DirectMapping = false, DefaultValue = 1,
	/// SourceArrayName=0, TargetArrayName = 0,
	/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
	/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTransferAttributes_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransferAttributes_IsTypeOf_13(string type);

	/// <summary>
	/// Create a vtkTransferAttributes object.
	/// Initial values are DirectMapping = false, DefaultValue = 1,
	/// SourceArrayName=0, TargetArrayName = 0,
	/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
	/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTransferAttributes_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransferAttributes_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a vtkTransferAttributes object.
	/// Initial values are DirectMapping = false, DefaultValue = 1,
	/// SourceArrayName=0, TargetArrayName = 0,
	/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
	/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// </summary>
	public new vtkTransferAttributes NewInstance()
	{
		vtkTransferAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransferAttributes_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransferAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransferAttributes_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a vtkTransferAttributes object.
	/// Initial values are DirectMapping = false, DefaultValue = 1,
	/// SourceArrayName=0, TargetArrayName = 0,
	/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
	/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
	/// </summary>
	public new static vtkTransferAttributes SafeDownCast(vtkObjectBase o)
	{
		vtkTransferAttributes vtkTransferAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransferAttributes_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransferAttributes2 = (vtkTransferAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransferAttributes2.Register(null);
			}
		}
		return vtkTransferAttributes2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransferAttributes_SetDefaultValue_17(HandleRef pThis, HandleRef value);

	/// <summary>
	/// Method to get/set the default value.
	/// </summary>
	public void SetDefaultValue(vtkVariant value)
	{
		vtkTransferAttributes_SetDefaultValue_17(GetCppThis(), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransferAttributes_SetDirectMapping_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, uses direct mapping from tree to graph vertices.
	/// If off, both the graph and tree must contain PedigreeId arrays
	/// which are used to match graph and tree vertices.
	/// Default is off.
	/// </summary>
	public virtual void SetDirectMapping(bool _arg)
	{
		vtkTransferAttributes_SetDirectMapping_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransferAttributes_SetSourceArrayName_19(HandleRef pThis, string _arg);

	/// <summary>
	/// The field name to use for storing the source array.
	/// </summary>
	public virtual void SetSourceArrayName(string _arg)
	{
		vtkTransferAttributes_SetSourceArrayName_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransferAttributes_SetSourceFieldType_20(HandleRef pThis, int _arg);

	/// <summary>
	/// The source field type for accessing the source array. Valid values are
	/// those from enum vtkDataObject::FieldAssociations.
	/// </summary>
	public virtual void SetSourceFieldType(int _arg)
	{
		vtkTransferAttributes_SetSourceFieldType_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransferAttributes_SetTargetArrayName_21(HandleRef pThis, string _arg);

	/// <summary>
	/// The field name to use for storing the source array.
	/// </summary>
	public virtual void SetTargetArrayName(string _arg)
	{
		vtkTransferAttributes_SetTargetArrayName_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransferAttributes_SetTargetFieldType_22(HandleRef pThis, int _arg);

	/// <summary>
	/// The target field type for accessing the target array. Valid values are
	/// those from enum vtkDataObject::FieldAssociations.
	/// </summary>
	public virtual void SetTargetFieldType(int _arg)
	{
		vtkTransferAttributes_SetTargetFieldType_22(GetCppThis(), _arg);
	}
}
