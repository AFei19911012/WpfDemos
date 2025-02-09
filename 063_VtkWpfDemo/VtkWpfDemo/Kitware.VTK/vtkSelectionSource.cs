using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSelectionSource
/// </summary>
/// <remarks>
///    Generate selection from given set of ids
///
/// vtkSelectionSource generates a vtkSelection from a set of
/// (piece id, cell id) pairs. It will only generate the selection values
/// that match UPDATE_PIECE_NUMBER (i.e. piece == UPDATE_PIECE_NUMBER).
/// vtkSelectionSource can generate a vtkSelection with one or many
/// vtkSelectionNodes.
///
/// To generate only one vtkSelectionNode, use the functions which don't pass a nodeId
/// to set/get the node information. To generate more than one vtkSelectionNode, use the
/// SetNumberOfNodes/RemoveNode to manipulate the number of nodes,
/// and use the functions that pass the nodeId to set the node information
/// The different nodes can have different contentType per node but the
/// fieldType/elementType is common across all nodes.
///
/// To define the relation between the nodes you can use SetExpression. If non-empty,
/// the expression is a boolean expression that defines how the selection nodes present
/// in the selection are to be combined together to form the selection. If no expression
/// is specified and there are multiple selection nodes, then the default
/// expression simply combines all the selection nodes using an `or` operator.
///
/// User-supplied, application-specific selections (with a ContentType of
/// vtkSelectionNode::USER) are not supported.
/// </remarks>
public class vtkSelectionSource : vtkSelectionAlgorithm
{
	/// <summary>
	/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
	///
	/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
	/// vtkSelectionNode::SelectionField.
	///
	/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
	/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
	/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
	/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
	///
	/// The default is FIELD_TYPE.
	/// </summary>
	public enum FieldTypeOptions
	{
		/// <summary>enum member</summary>
		ELEMENT_TYPE = 1,
		/// <summary>enum member</summary>
		FIELD_TYPE = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSelectionSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSelectionSource()
	{
		MRClassNameKey = "class vtkSelectionSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectionSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSelectionSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSelectionSource New()
	{
		vtkSelectionSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSelectionSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSelectionSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddBlock_01(HandleRef pThis, uint nodeId, long block);

	/// <summary>
	/// Add the flat-index/composite index for a block.
	/// </summary>
	public void AddBlock(uint nodeId, long block)
	{
		vtkSelectionSource_AddBlock_01(GetCppThis(), nodeId, block);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddBlock_02(HandleRef pThis, long blockno);

	/// <summary>
	/// Add the flat-index/composite index for a block.
	/// </summary>
	public void AddBlock(long blockno)
	{
		vtkSelectionSource_AddBlock_02(GetCppThis(), blockno);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddBlockSelector_03(HandleRef pThis, uint nodeId, string block);

	/// <summary>
	/// Add/Remove block-selectors to make selections with
	/// vtkSelectionNode::BLOCK_SELECTORS as the content-type.
	/// </summary>
	public void AddBlockSelector(uint nodeId, string block)
	{
		vtkSelectionSource_AddBlockSelector_03(GetCppThis(), nodeId, block);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddBlockSelector_04(HandleRef pThis, string selector);

	/// <summary>
	/// Add/Remove block-selectors to make selections with
	/// vtkSelectionNode::BLOCK_SELECTORS as the content-type.
	/// </summary>
	public void AddBlockSelector(string selector)
	{
		vtkSelectionSource_AddBlockSelector_04(GetCppThis(), selector);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddID_05(HandleRef pThis, uint nodeId, long piece, long id);

	/// <summary>
	/// Add a (piece, id) to the selection set. The source will generate
	/// only the ids for which piece == UPDATE_PIECE_NUMBER.
	/// If piece == -1, the id applies to all pieces.
	/// </summary>
	public void AddID(uint nodeId, long piece, long id)
	{
		vtkSelectionSource_AddID_05(GetCppThis(), nodeId, piece, id);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddID_06(HandleRef pThis, long piece, long id);

	/// <summary>
	/// Add a (piece, id) to the selection set. The source will generate
	/// only the ids for which piece == UPDATE_PIECE_NUMBER.
	/// If piece == -1, the id applies to all pieces.
	/// </summary>
	public void AddID(long piece, long id)
	{
		vtkSelectionSource_AddID_06(GetCppThis(), piece, id);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddLocation_07(HandleRef pThis, uint nodeId, double x, double y, double z);

	/// <summary>
	/// Add a point in world space to probe at.
	/// </summary>
	public void AddLocation(uint nodeId, double x, double y, double z)
	{
		vtkSelectionSource_AddLocation_07(GetCppThis(), nodeId, x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddLocation_08(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Add a point in world space to probe at.
	/// </summary>
	public void AddLocation(double x, double y, double z)
	{
		vtkSelectionSource_AddLocation_08(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddSelector_09(HandleRef pThis, uint nodeId, string selector);

	/// <summary>
	/// For selector-based selection qualification. Note, this should not
	/// be confused with block-selectors used to select blocks using selectors.
	/// These here are qualifiers i.e. they limit the selected items.
	/// </summary>
	public void AddSelector(uint nodeId, string selector)
	{
		vtkSelectionSource_AddSelector_09(GetCppThis(), nodeId, selector);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddSelector_10(HandleRef pThis, string selector);

	/// <summary>
	/// For selector-based selection qualification. Note, this should not
	/// be confused with block-selectors used to select blocks using selectors.
	/// These here are qualifiers i.e. they limit the selected items.
	/// </summary>
	public void AddSelector(string selector)
	{
		vtkSelectionSource_AddSelector_10(GetCppThis(), selector);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddStringID_11(HandleRef pThis, uint nodeId, long piece, string id);

	/// <summary>
	/// Add a (piece, id) to the selection set. The source will generate
	/// only the ids for which piece == UPDATE_PIECE_NUMBER.
	/// If piece == -1, the id applies to all pieces.
	/// </summary>
	public void AddStringID(uint nodeId, long piece, string id)
	{
		vtkSelectionSource_AddStringID_11(GetCppThis(), nodeId, piece, id);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddStringID_12(HandleRef pThis, long piece, string id);

	/// <summary>
	/// Add a (piece, id) to the selection set. The source will generate
	/// only the ids for which piece == UPDATE_PIECE_NUMBER.
	/// If piece == -1, the id applies to all pieces.
	/// </summary>
	public void AddStringID(long piece, string id)
	{
		vtkSelectionSource_AddStringID_12(GetCppThis(), piece, id);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddThreshold_13(HandleRef pThis, uint nodeId, double min, double max);

	/// <summary>
	/// Add a value range to threshold within.
	/// </summary>
	public void AddThreshold(uint nodeId, double min, double max)
	{
		vtkSelectionSource_AddThreshold_13(GetCppThis(), nodeId, min, max);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_AddThreshold_14(HandleRef pThis, double min, double max);

	/// <summary>
	/// Add a value range to threshold within.
	/// </summary>
	public void AddThreshold(double min, double max)
	{
		vtkSelectionSource_AddThreshold_14(GetCppThis(), min, max);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetArrayComponent_15(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the component number for the array specified by ArrayName.
	///
	/// The default is component 0. Use -1 for magnitude.
	/// </summary>
	public int GetArrayComponent(uint nodeId)
	{
		return vtkSelectionSource_GetArrayComponent_15(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetArrayComponent_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the component number for the array specified by ArrayName.
	///
	/// The default is component 0. Use -1 for magnitude.
	/// </summary>
	public int GetArrayComponent()
	{
		return vtkSelectionSource_GetArrayComponent_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_GetArrayName_17(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Get/Set the name used for the SelectionList in the generated
	/// vtkSelectionNode.
	/// </summary>
	public string GetArrayName(uint nodeId)
	{
		return Marshal.PtrToStringAnsi(vtkSelectionSource_GetArrayName_17(GetCppThis(), nodeId));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_GetArrayName_18(HandleRef pThis);

	/// <summary>
	/// Get/Set the name used for the SelectionList in the generated
	/// vtkSelectionNode.
	/// </summary>
	public string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkSelectionSource_GetArrayName_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_GetAssemblyName_19(HandleRef pThis, uint nodeId);

	/// <summary>
	/// For selector-based selection qualification. Note, this should not
	/// be confused with block-selectors used to select blocks using selectors.
	/// These here are qualifiers i.e. they limit the selected items.
	/// </summary>
	public string GetAssemblyName(uint nodeId)
	{
		return Marshal.PtrToStringAnsi(vtkSelectionSource_GetAssemblyName_19(GetCppThis(), nodeId));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_GetAssemblyName_20(HandleRef pThis);

	/// <summary>
	/// For selector-based selection qualification. Note, this should not
	/// be confused with block-selectors used to select blocks using selectors.
	/// These here are qualifiers i.e. they limit the selected items.
	/// </summary>
	public string GetAssemblyName()
	{
		return Marshal.PtrToStringAnsi(vtkSelectionSource_GetAssemblyName_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetCompositeIndex_21(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the CompositeIndex.
	/// If CompositeIndex &lt; 0 then COMPOSITE_INDEX() is not added to the output.
	///
	/// The default is -1.
	/// </summary>
	public int GetCompositeIndex(uint nodeId)
	{
		return vtkSelectionSource_GetCompositeIndex_21(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetCompositeIndex_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the CompositeIndex.
	/// If CompositeIndex &lt; 0 then COMPOSITE_INDEX() is not added to the output.
	///
	/// The default is -1.
	/// </summary>
	public int GetCompositeIndex()
	{
		return vtkSelectionSource_GetCompositeIndex_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetContainingCells_23(HandleRef pThis, uint nodeId);

	/// <summary>
	/// When extracting by points, extract the cells that contain the
	/// passing points.
	///
	/// The default is false.
	/// </summary>
	public int GetContainingCells(uint nodeId)
	{
		return vtkSelectionSource_GetContainingCells_23(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetContainingCells_24(HandleRef pThis);

	/// <summary>
	/// When extracting by points, extract the cells that contain the
	/// passing points.
	///
	/// The default is false.
	/// </summary>
	public int GetContainingCells()
	{
		return vtkSelectionSource_GetContainingCells_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetContentType_25(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the content type.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionContent.
	///
	/// The default is vtkSelectionNode::SelectionContent::INDICES.
	/// </summary>
	public int GetContentType(uint nodeId)
	{
		return vtkSelectionSource_GetContentType_25(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetContentType_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the content type.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionContent.
	///
	/// The default is vtkSelectionNode::SelectionContent::INDICES.
	/// </summary>
	public int GetContentType()
	{
		return vtkSelectionSource_GetContentType_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetContentTypeMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the content type.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionContent.
	///
	/// The default is vtkSelectionNode::SelectionContent::INDICES.
	/// </summary>
	public int GetContentTypeMaxValue()
	{
		return vtkSelectionSource_GetContentTypeMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetContentTypeMinValue_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the content type.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionContent.
	///
	/// The default is vtkSelectionNode::SelectionContent::INDICES.
	/// </summary>
	public int GetContentTypeMinValue()
	{
		return vtkSelectionSource_GetContentTypeMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetElementType_29(HandleRef pThis);

	/// <summary>
	/// Set/Get which types of elements are being selected.
	/// Accepted values are defined in `vtkDataObject::AttributeTypes`. Note,
	/// `vtkDataObject::FIELD` and `vtkDataObject::POINT_THEN_CELL` are not
	/// supported.
	///
	/// The default is vtkDataObject::AttributeTypes::Cell.
	/// </summary>
	public virtual int GetElementType()
	{
		return vtkSelectionSource_GetElementType_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetElementTypeMaxValue_30(HandleRef pThis);

	/// <summary>
	/// Set/Get which types of elements are being selected.
	/// Accepted values are defined in `vtkDataObject::AttributeTypes`. Note,
	/// `vtkDataObject::FIELD` and `vtkDataObject::POINT_THEN_CELL` are not
	/// supported.
	///
	/// The default is vtkDataObject::AttributeTypes::Cell.
	/// </summary>
	public virtual int GetElementTypeMaxValue()
	{
		return vtkSelectionSource_GetElementTypeMaxValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetElementTypeMinValue_31(HandleRef pThis);

	/// <summary>
	/// Set/Get which types of elements are being selected.
	/// Accepted values are defined in `vtkDataObject::AttributeTypes`. Note,
	/// `vtkDataObject::FIELD` and `vtkDataObject::POINT_THEN_CELL` are not
	/// supported.
	///
	/// The default is vtkDataObject::AttributeTypes::Cell.
	/// </summary>
	public virtual int GetElementTypeMinValue()
	{
		return vtkSelectionSource_GetElementTypeMinValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_GetExpression_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the expression that defines the boolean expression to combine the
	/// selection nodes. Expression consists of node name identifiers, `|` for
	/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
	/// and parenthesis `(` and `)`. If you want to set the expression, be sure to
	/// define the node names. If no expression is specified and there are multiple
	/// selection nodes, then the default expression simply combines all the selection
	/// nodes using an `or` operator.
	///
	/// `SetExpression` does not validate the expression. It will be validated in
	/// `internally.
	/// </summary>
	public virtual string GetExpression()
	{
		return Marshal.PtrToStringAnsi(vtkSelectionSource_GetExpression_32(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetFieldType_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the field type for the generated selection.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionField.
	///
	/// The default is vtkSelectionNode::SelectionField::CELL.
	/// </summary>
	public virtual int GetFieldType()
	{
		return vtkSelectionSource_GetFieldType_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetFieldTypeMaxValue_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the field type for the generated selection.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionField.
	///
	/// The default is vtkSelectionNode::SelectionField::CELL.
	/// </summary>
	public virtual int GetFieldTypeMaxValue()
	{
		return vtkSelectionSource_GetFieldTypeMaxValue_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetFieldTypeMinValue_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the field type for the generated selection.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionField.
	///
	/// The default is vtkSelectionNode::SelectionField::CELL.
	/// </summary>
	public virtual int GetFieldTypeMinValue()
	{
		return vtkSelectionSource_GetFieldTypeMinValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetFieldTypeOption_36(HandleRef pThis);

	/// <summary>
	/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
	///
	/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
	/// vtkSelectionNode::SelectionField.
	///
	/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
	/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
	/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
	/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
	///
	/// The default is FIELD_TYPE.
	/// </summary>
	public virtual int GetFieldTypeOption()
	{
		return vtkSelectionSource_GetFieldTypeOption_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetFieldTypeOptionMaxValue_37(HandleRef pThis);

	/// <summary>
	/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
	///
	/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
	/// vtkSelectionNode::SelectionField.
	///
	/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
	/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
	/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
	/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
	///
	/// The default is FIELD_TYPE.
	/// </summary>
	public virtual int GetFieldTypeOptionMaxValue()
	{
		return vtkSelectionSource_GetFieldTypeOptionMaxValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetFieldTypeOptionMinValue_38(HandleRef pThis);

	/// <summary>
	/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
	///
	/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
	/// vtkSelectionNode::SelectionField.
	///
	/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
	/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
	/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
	/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
	///
	/// The default is FIELD_TYPE.
	/// </summary>
	public virtual int GetFieldTypeOptionMinValue()
	{
		return vtkSelectionSource_GetFieldTypeOptionMinValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetHierarchicalIndex_39(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the Hierarchical/HierarchicalIndex.
	/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
	/// and HIERARCHICAL_INDEX() keys are not added to the output.
	///
	/// The default for both is -1.
	/// </summary>
	public int GetHierarchicalIndex(uint nodeId)
	{
		return vtkSelectionSource_GetHierarchicalIndex_39(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetHierarchicalIndex_40(HandleRef pThis);

	/// <summary>
	/// Set/Get the Hierarchical/HierarchicalIndex.
	/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
	/// and HIERARCHICAL_INDEX() keys are not added to the output.
	///
	/// The default for both is -1.
	/// </summary>
	public int GetHierarchicalIndex()
	{
		return vtkSelectionSource_GetHierarchicalIndex_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetHierarchicalLevel_41(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the Hierarchical/HierarchicalIndex.
	/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
	/// and HIERARCHICAL_INDEX() keys are not added to the output.
	///
	/// The default for both is -1.
	/// </summary>
	public int GetHierarchicalLevel(uint nodeId)
	{
		return vtkSelectionSource_GetHierarchicalLevel_41(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetHierarchicalLevel_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the Hierarchical/HierarchicalIndex.
	/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
	/// and HIERARCHICAL_INDEX() keys are not added to the output.
	///
	/// The default for both is -1.
	/// </summary>
	public int GetHierarchicalLevel()
	{
		return vtkSelectionSource_GetHierarchicalLevel_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetInverse_43(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Determines whether the selection describes what to include or exclude.
	///
	/// The Default is 0, meaning include.
	/// </summary>
	public int GetInverse(uint nodeId)
	{
		return vtkSelectionSource_GetInverse_43(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetInverse_44(HandleRef pThis);

	/// <summary>
	/// Determines whether the selection describes what to include or exclude.
	///
	/// The Default is 0, meaning include.
	/// </summary>
	public int GetInverse()
	{
		return vtkSelectionSource_GetInverse_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_GetNodeName_45(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the node name.
	///
	/// If you want to set the Expression, be sure to define the node names.
	///
	/// If the node name is not defined, a default node name is created atomically
	/// at each execution of the filter to guarantee uniqueness. GetNodeName()
	/// will return a non-empty name only if you have defined it before.
	/// </summary>
	public string GetNodeName(uint nodeId)
	{
		return Marshal.PtrToStringAnsi(vtkSelectionSource_GetNodeName_45(GetCppThis(), nodeId));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_GetNodeName_46(HandleRef pThis);

	/// <summary>
	/// Set/Get the node name.
	///
	/// If you want to set the Expression, be sure to define the node names.
	///
	/// If the node name is not defined, a default node name is created atomically
	/// at each execution of the filter to guarantee uniqueness. GetNodeName()
	/// will return a non-empty name only if you have defined it before.
	/// </summary>
	public string GetNodeName()
	{
		return Marshal.PtrToStringAnsi(vtkSelectionSource_GetNodeName_46(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectionSource_GetNumberOfGenerationsFromBase_47(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSelectionSource_GetNumberOfGenerationsFromBase_47(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectionSource_GetNumberOfGenerationsFromBaseType_48(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSelectionSource_GetNumberOfGenerationsFromBaseType_48(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetNumberOfLayers_49(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the number of layers to extract connected to the selected elements.
	///
	/// The default is 0.
	/// </summary>
	public int GetNumberOfLayers(uint nodeId)
	{
		return vtkSelectionSource_GetNumberOfLayers_49(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetNumberOfLayers_50(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of layers to extract connected to the selected elements.
	///
	/// The default is 0.
	/// </summary>
	public int GetNumberOfLayers()
	{
		return vtkSelectionSource_GetNumberOfLayers_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetNumberOfLayersMaxValue_51(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of layers to extract connected to the selected elements.
	///
	/// The default is 0.
	/// </summary>
	public int GetNumberOfLayersMaxValue()
	{
		return vtkSelectionSource_GetNumberOfLayersMaxValue_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetNumberOfLayersMinValue_52(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of layers to extract connected to the selected elements.
	///
	/// The default is 0.
	/// </summary>
	public int GetNumberOfLayersMinValue()
	{
		return vtkSelectionSource_GetNumberOfLayersMinValue_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkSelectionSource_GetNumberOfNodes_53(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of nodes that will be created for the generated selection.
	///
	/// The default is 1.
	/// </summary>
	public uint GetNumberOfNodes()
	{
		return vtkSelectionSource_GetNumberOfNodes_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetProcessID_54(HandleRef pThis);

	/// <summary>
	/// Set/Get which process to limit the selection to. `-1` is treated as
	/// all processes.
	///
	/// The default is -1.
	/// </summary>
	public virtual int GetProcessID()
	{
		return vtkSelectionSource_GetProcessID_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetProcessIDMaxValue_55(HandleRef pThis);

	/// <summary>
	/// Set/Get which process to limit the selection to. `-1` is treated as
	/// all processes.
	///
	/// The default is -1.
	/// </summary>
	public virtual int GetProcessIDMaxValue()
	{
		return vtkSelectionSource_GetProcessIDMaxValue_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_GetProcessIDMinValue_56(HandleRef pThis);

	/// <summary>
	/// Set/Get which process to limit the selection to. `-1` is treated as
	/// all processes.
	///
	/// The default is -1.
	/// </summary>
	public virtual int GetProcessIDMinValue()
	{
		return vtkSelectionSource_GetProcessIDMinValue_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_GetQueryString_57(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the query expression string.
	/// </summary>
	public string GetQueryString(uint nodeId)
	{
		return Marshal.PtrToStringAnsi(vtkSelectionSource_GetQueryString_57(GetCppThis(), nodeId));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_GetQueryString_58(HandleRef pThis);

	/// <summary>
	/// Set/Get the query expression string.
	/// </summary>
	public string GetQueryString()
	{
		return Marshal.PtrToStringAnsi(vtkSelectionSource_GetQueryString_58(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSelectionSource_GetRemoveIntermediateLayers_59(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the number of layers related flag to remove intermediate layers
	///
	/// The default is false.
	/// </summary>
	public bool GetRemoveIntermediateLayers(uint nodeId)
	{
		return (vtkSelectionSource_GetRemoveIntermediateLayers_59(GetCppThis(), nodeId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSelectionSource_GetRemoveIntermediateLayers_60(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of layers related flag to remove intermediate layers
	///
	/// The default is false.
	/// </summary>
	public bool GetRemoveIntermediateLayers()
	{
		return (vtkSelectionSource_GetRemoveIntermediateLayers_60(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSelectionSource_GetRemoveSeed_61(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Set/Get the number of layers related flag to remove seed selection
	///
	/// The default is false.
	/// </summary>
	public bool GetRemoveSeed(uint nodeId)
	{
		return (vtkSelectionSource_GetRemoveSeed_61(GetCppThis(), nodeId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSelectionSource_GetRemoveSeed_62(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of layers related flag to remove seed selection
	///
	/// The default is false.
	/// </summary>
	public bool GetRemoveSeed()
	{
		return (vtkSelectionSource_GetRemoveSeed_62(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_IsA_63(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSelectionSource_IsA_63(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionSource_IsTypeOf_64(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSelectionSource_IsTypeOf_64(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_NewInstance_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSelectionSource NewInstance()
	{
		vtkSelectionSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionSource_NewInstance_66(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllBlockSelectors_67(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Add/Remove block-selectors to make selections with
	/// vtkSelectionNode::BLOCK_SELECTORS as the content-type.
	/// </summary>
	public void RemoveAllBlockSelectors(uint nodeId)
	{
		vtkSelectionSource_RemoveAllBlockSelectors_67(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllBlockSelectors_68(HandleRef pThis);

	/// <summary>
	/// Add/Remove block-selectors to make selections with
	/// vtkSelectionNode::BLOCK_SELECTORS as the content-type.
	/// </summary>
	public void RemoveAllBlockSelectors()
	{
		vtkSelectionSource_RemoveAllBlockSelectors_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllBlocks_69(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Remove all blocks added with AddBlock.
	/// </summary>
	public void RemoveAllBlocks(uint nodeId)
	{
		vtkSelectionSource_RemoveAllBlocks_69(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllBlocks_70(HandleRef pThis);

	/// <summary>
	/// Remove all blocks added with AddBlock.
	/// </summary>
	public void RemoveAllBlocks()
	{
		vtkSelectionSource_RemoveAllBlocks_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllIDs_71(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Removes all IDs.
	/// </summary>
	public void RemoveAllIDs(uint nodeId)
	{
		vtkSelectionSource_RemoveAllIDs_71(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllIDs_72(HandleRef pThis);

	/// <summary>
	/// Removes all IDs.
	/// </summary>
	public void RemoveAllIDs()
	{
		vtkSelectionSource_RemoveAllIDs_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllLocations_73(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Remove all locations added with AddLocation.
	/// </summary>
	public void RemoveAllLocations(uint nodeId)
	{
		vtkSelectionSource_RemoveAllLocations_73(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllLocations_74(HandleRef pThis);

	/// <summary>
	/// Remove all locations added with AddLocation.
	/// </summary>
	public void RemoveAllLocations()
	{
		vtkSelectionSource_RemoveAllLocations_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllNodes_75(HandleRef pThis);

	/// <summary>
	/// Remove all selection nodes.
	/// </summary>
	public virtual void RemoveAllNodes()
	{
		vtkSelectionSource_RemoveAllNodes_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllSelectors_76(HandleRef pThis, uint nodeId);

	/// <summary>
	/// For selector-based selection qualification. Note, this should not
	/// be confused with block-selectors used to select blocks using selectors.
	/// These here are qualifiers i.e. they limit the selected items.
	/// </summary>
	public void RemoveAllSelectors(uint nodeId)
	{
		vtkSelectionSource_RemoveAllSelectors_76(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllSelectors_77(HandleRef pThis);

	/// <summary>
	/// For selector-based selection qualification. Note, this should not
	/// be confused with block-selectors used to select blocks using selectors.
	/// These here are qualifiers i.e. they limit the selected items.
	/// </summary>
	public void RemoveAllSelectors()
	{
		vtkSelectionSource_RemoveAllSelectors_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllStringIDs_78(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Removes all IDs.
	/// </summary>
	public void RemoveAllStringIDs(uint nodeId)
	{
		vtkSelectionSource_RemoveAllStringIDs_78(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllStringIDs_79(HandleRef pThis);

	/// <summary>
	/// Removes all IDs.
	/// </summary>
	public void RemoveAllStringIDs()
	{
		vtkSelectionSource_RemoveAllStringIDs_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllThresholds_80(HandleRef pThis, uint nodeId);

	/// <summary>
	/// Remove all thresholds added with AddThreshold.
	/// </summary>
	public void RemoveAllThresholds(uint nodeId)
	{
		vtkSelectionSource_RemoveAllThresholds_80(GetCppThis(), nodeId);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveAllThresholds_81(HandleRef pThis);

	/// <summary>
	/// Remove all thresholds added with AddThreshold.
	/// </summary>
	public void RemoveAllThresholds()
	{
		vtkSelectionSource_RemoveAllThresholds_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveNode_82(HandleRef pThis, uint idx);

	/// <summary>
	/// Remove a selection node.
	/// </summary>
	public void RemoveNode(uint idx)
	{
		vtkSelectionSource_RemoveNode_82(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_RemoveNode_83(HandleRef pThis, string name);

	/// <summary>
	/// Remove a selection node.
	/// </summary>
	public void RemoveNode(string name)
	{
		vtkSelectionSource_RemoveNode_83(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionSource_SafeDownCast_84(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSelectionSource SafeDownCast(vtkObjectBase o)
	{
		vtkSelectionSource vtkSelectionSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionSource_SafeDownCast_84(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelectionSource2 = (vtkSelectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelectionSource2.Register(null);
			}
		}
		return vtkSelectionSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetArrayComponent_85(HandleRef pThis, uint nodeId, int component);

	/// <summary>
	/// Set/Get the component number for the array specified by ArrayName.
	///
	/// The default is component 0. Use -1 for magnitude.
	/// </summary>
	public void SetArrayComponent(uint nodeId, int component)
	{
		vtkSelectionSource_SetArrayComponent_85(GetCppThis(), nodeId, component);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetArrayComponent_86(HandleRef pThis, int component);

	/// <summary>
	/// Set/Get the component number for the array specified by ArrayName.
	///
	/// The default is component 0. Use -1 for magnitude.
	/// </summary>
	public void SetArrayComponent(int component)
	{
		vtkSelectionSource_SetArrayComponent_86(GetCppThis(), component);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetArrayName_87(HandleRef pThis, uint nodeId, string name);

	/// <summary>
	/// Get/Set the name used for the SelectionList in the generated
	/// vtkSelectionNode.
	/// </summary>
	public void SetArrayName(uint nodeId, string name)
	{
		vtkSelectionSource_SetArrayName_87(GetCppThis(), nodeId, name);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetArrayName_88(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set the name used for the SelectionList in the generated
	/// vtkSelectionNode.
	/// </summary>
	public void SetArrayName(string name)
	{
		vtkSelectionSource_SetArrayName_88(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetAssemblyName_89(HandleRef pThis, uint nodeId, string name);

	/// <summary>
	/// For selector-based selection qualification. Note, this should not
	/// be confused with block-selectors used to select blocks using selectors.
	/// These here are qualifiers i.e. they limit the selected items.
	/// </summary>
	public void SetAssemblyName(uint nodeId, string name)
	{
		vtkSelectionSource_SetAssemblyName_89(GetCppThis(), nodeId, name);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetAssemblyName_90(HandleRef pThis, string name);

	/// <summary>
	/// For selector-based selection qualification. Note, this should not
	/// be confused with block-selectors used to select blocks using selectors.
	/// These here are qualifiers i.e. they limit the selected items.
	/// </summary>
	public void SetAssemblyName(string name)
	{
		vtkSelectionSource_SetAssemblyName_90(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetCompositeIndex_91(HandleRef pThis, uint nodeId, int index);

	/// <summary>
	/// Set/Get the CompositeIndex.
	/// If CompositeIndex &lt; 0 then COMPOSITE_INDEX() is not added to the output.
	///
	/// The default is -1.
	/// </summary>
	public void SetCompositeIndex(uint nodeId, int index)
	{
		vtkSelectionSource_SetCompositeIndex_91(GetCppThis(), nodeId, index);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetCompositeIndex_92(HandleRef pThis, int compositeIndex);

	/// <summary>
	/// Set/Get the CompositeIndex.
	/// If CompositeIndex &lt; 0 then COMPOSITE_INDEX() is not added to the output.
	///
	/// The default is -1.
	/// </summary>
	public void SetCompositeIndex(int compositeIndex)
	{
		vtkSelectionSource_SetCompositeIndex_92(GetCppThis(), compositeIndex);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetContainingCells_93(HandleRef pThis, uint nodeId, int containingCells);

	/// <summary>
	/// When extracting by points, extract the cells that contain the
	/// passing points.
	///
	/// The default is false.
	/// </summary>
	public void SetContainingCells(uint nodeId, int containingCells)
	{
		vtkSelectionSource_SetContainingCells_93(GetCppThis(), nodeId, containingCells);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetContainingCells_94(HandleRef pThis, int containingCells);

	/// <summary>
	/// When extracting by points, extract the cells that contain the
	/// passing points.
	///
	/// The default is false.
	/// </summary>
	public void SetContainingCells(int containingCells)
	{
		vtkSelectionSource_SetContainingCells_94(GetCppThis(), containingCells);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetContentType_95(HandleRef pThis, uint nodeId, int type);

	/// <summary>
	/// Set/Get the content type.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionContent.
	///
	/// The default is vtkSelectionNode::SelectionContent::INDICES.
	/// </summary>
	public void SetContentType(uint nodeId, int type)
	{
		vtkSelectionSource_SetContentType_95(GetCppThis(), nodeId, type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetContentType_96(HandleRef pThis, int contentType);

	/// <summary>
	/// Set/Get the content type.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionContent.
	///
	/// The default is vtkSelectionNode::SelectionContent::INDICES.
	/// </summary>
	public void SetContentType(int contentType)
	{
		vtkSelectionSource_SetContentType_96(GetCppThis(), contentType);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetElementType_97(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get which types of elements are being selected.
	/// Accepted values are defined in `vtkDataObject::AttributeTypes`. Note,
	/// `vtkDataObject::FIELD` and `vtkDataObject::POINT_THEN_CELL` are not
	/// supported.
	///
	/// The default is vtkDataObject::AttributeTypes::Cell.
	/// </summary>
	public virtual void SetElementType(int _arg)
	{
		vtkSelectionSource_SetElementType_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetExpression_98(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get the expression that defines the boolean expression to combine the
	/// selection nodes. Expression consists of node name identifiers, `|` for
	/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
	/// and parenthesis `(` and `)`. If you want to set the expression, be sure to
	/// define the node names. If no expression is specified and there are multiple
	/// selection nodes, then the default expression simply combines all the selection
	/// nodes using an `or` operator.
	///
	/// `SetExpression` does not validate the expression. It will be validated in
	/// `internally.
	/// </summary>
	public virtual void SetExpression(string arg)
	{
		vtkSelectionSource_SetExpression_98(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetFieldType_99(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the field type for the generated selection.
	/// Possible values are as defined by
	/// vtkSelectionNode::SelectionField.
	///
	/// The default is vtkSelectionNode::SelectionField::CELL.
	/// </summary>
	public virtual void SetFieldType(int _arg)
	{
		vtkSelectionSource_SetFieldType_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetFieldTypeOption_100(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
	///
	/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
	/// vtkSelectionNode::SelectionField.
	///
	/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
	/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
	/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
	/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
	///
	/// The default is FIELD_TYPE.
	/// </summary>
	public virtual void SetFieldTypeOption(int _arg)
	{
		vtkSelectionSource_SetFieldTypeOption_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetFieldTypeOptionToElementType_101(HandleRef pThis);

	/// <summary>
	/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
	///
	/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
	/// vtkSelectionNode::SelectionField.
	///
	/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
	/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
	/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
	/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
	///
	/// The default is FIELD_TYPE.
	/// </summary>
	public virtual void SetFieldTypeOptionToElementType()
	{
		vtkSelectionSource_SetFieldTypeOptionToElementType_101(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetFieldTypeOptionToFieldType_102(HandleRef pThis);

	/// <summary>
	/// Set/Get FieldTypeOption which is used to specify the selection field type for the selection.
	///
	/// If FIELD_TYPE is defined, set FieldType using accepted values as defined in
	/// vtkSelectionNode::SelectionField.
	///
	/// If ELEMENT_TYPE is defined, set ElementType using accepted values as defined in
	/// `vtkDataObject::AttributeTypes`. Note, `vtkDataObject::FIELD` and
	/// `vtkDataObject::POINT_THEN_CELL` are not supported. ELEMENT_TYPE will be converted
	/// to FIELD_TYPE, internally, since vtkSelectionNode only accepts FIELD_TYPE.
	///
	/// The default is FIELD_TYPE.
	/// </summary>
	public virtual void SetFieldTypeOptionToFieldType()
	{
		vtkSelectionSource_SetFieldTypeOptionToFieldType_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetFrustum_103(HandleRef pThis, uint nodeId, IntPtr vertices);

	/// <summary>
	/// Set a frustum to choose within.
	/// </summary>
	public void SetFrustum(uint nodeId, IntPtr vertices)
	{
		vtkSelectionSource_SetFrustum_103(GetCppThis(), nodeId, vertices);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetFrustum_104(HandleRef pThis, IntPtr vertices);

	/// <summary>
	/// Set a frustum to choose within.
	/// </summary>
	public void SetFrustum(IntPtr vertices)
	{
		vtkSelectionSource_SetFrustum_104(GetCppThis(), vertices);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetHierarchicalIndex_105(HandleRef pThis, uint nodeId, int index);

	/// <summary>
	/// Set/Get the Hierarchical/HierarchicalIndex.
	/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
	/// and HIERARCHICAL_INDEX() keys are not added to the output.
	///
	/// The default for both is -1.
	/// </summary>
	public void SetHierarchicalIndex(uint nodeId, int index)
	{
		vtkSelectionSource_SetHierarchicalIndex_105(GetCppThis(), nodeId, index);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetHierarchicalIndex_106(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the Hierarchical/HierarchicalIndex.
	/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
	/// and HIERARCHICAL_INDEX() keys are not added to the output.
	///
	/// The default for both is -1.
	/// </summary>
	public void SetHierarchicalIndex(int index)
	{
		vtkSelectionSource_SetHierarchicalIndex_106(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetHierarchicalLevel_107(HandleRef pThis, uint nodeId, int level);

	/// <summary>
	/// Set/Get the Hierarchical/HierarchicalIndex.
	/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
	/// and HIERARCHICAL_INDEX() keys are not added to the output.
	///
	/// The default for both is -1.
	/// </summary>
	public void SetHierarchicalLevel(uint nodeId, int level)
	{
		vtkSelectionSource_SetHierarchicalLevel_107(GetCppThis(), nodeId, level);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetHierarchicalLevel_108(HandleRef pThis, int level);

	/// <summary>
	/// Set/Get the Hierarchical/HierarchicalIndex.
	/// If HierarchicalLevel or HierarchicalIndex &lt; 0 , then HIERARCHICAL_LEVEL()
	/// and HIERARCHICAL_INDEX() keys are not added to the output.
	///
	/// The default for both is -1.
	/// </summary>
	public void SetHierarchicalLevel(int level)
	{
		vtkSelectionSource_SetHierarchicalLevel_108(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetInverse_109(HandleRef pThis, uint nodeId, int inverse);

	/// <summary>
	/// Determines whether the selection describes what to include or exclude.
	///
	/// The Default is 0, meaning include.
	/// </summary>
	public void SetInverse(uint nodeId, int inverse)
	{
		vtkSelectionSource_SetInverse_109(GetCppThis(), nodeId, inverse);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetInverse_110(HandleRef pThis, int inverse);

	/// <summary>
	/// Determines whether the selection describes what to include or exclude.
	///
	/// The Default is 0, meaning include.
	/// </summary>
	public void SetInverse(int inverse)
	{
		vtkSelectionSource_SetInverse_110(GetCppThis(), inverse);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetNodeName_111(HandleRef pThis, uint nodeId, string name);

	/// <summary>
	/// Set/Get the node name.
	///
	/// If you want to set the Expression, be sure to define the node names.
	///
	/// If the node name is not defined, a default node name is created atomically
	/// at each execution of the filter to guarantee uniqueness. GetNodeName()
	/// will return a non-empty name only if you have defined it before.
	/// </summary>
	public void SetNodeName(uint nodeId, string name)
	{
		vtkSelectionSource_SetNodeName_111(GetCppThis(), nodeId, name);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetNodeName_112(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the node name.
	///
	/// If you want to set the Expression, be sure to define the node names.
	///
	/// If the node name is not defined, a default node name is created atomically
	/// at each execution of the filter to guarantee uniqueness. GetNodeName()
	/// will return a non-empty name only if you have defined it before.
	/// </summary>
	public void SetNodeName(string name)
	{
		vtkSelectionSource_SetNodeName_112(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetNumberOfLayers_113(HandleRef pThis, uint nodeId, int numberOfLayers);

	/// <summary>
	/// Set/Get the number of layers to extract connected to the selected elements.
	///
	/// The default is 0.
	/// </summary>
	public void SetNumberOfLayers(uint nodeId, int numberOfLayers)
	{
		vtkSelectionSource_SetNumberOfLayers_113(GetCppThis(), nodeId, numberOfLayers);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetNumberOfLayers_114(HandleRef pThis, int numberOfLayers);

	/// <summary>
	/// Set/Get the number of layers to extract connected to the selected elements.
	///
	/// The default is 0.
	/// </summary>
	public void SetNumberOfLayers(int numberOfLayers)
	{
		vtkSelectionSource_SetNumberOfLayers_114(GetCppThis(), numberOfLayers);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetNumberOfNodes_115(HandleRef pThis, uint numberOfNodes);

	/// <summary>
	/// Set/Get the number of nodes that will be created for the generated selection.
	///
	/// The default is 1.
	/// </summary>
	public void SetNumberOfNodes(uint numberOfNodes)
	{
		vtkSelectionSource_SetNumberOfNodes_115(GetCppThis(), numberOfNodes);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetProcessID_116(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get which process to limit the selection to. `-1` is treated as
	/// all processes.
	///
	/// The default is -1.
	/// </summary>
	public virtual void SetProcessID(int _arg)
	{
		vtkSelectionSource_SetProcessID_116(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetQueryString_117(HandleRef pThis, uint nodeId, string queryString);

	/// <summary>
	/// Set/Get the query expression string.
	/// </summary>
	public void SetQueryString(uint nodeId, string queryString)
	{
		vtkSelectionSource_SetQueryString_117(GetCppThis(), nodeId, queryString);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetQueryString_118(HandleRef pThis, string query);

	/// <summary>
	/// Set/Get the query expression string.
	/// </summary>
	public void SetQueryString(string query)
	{
		vtkSelectionSource_SetQueryString_118(GetCppThis(), query);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetRemoveIntermediateLayers_119(HandleRef pThis, uint nodeId, byte RemoveIntermediateLayers);

	/// <summary>
	/// Set/Get the number of layers related flag to remove intermediate layers
	///
	/// The default is false.
	/// </summary>
	public void SetRemoveIntermediateLayers(uint nodeId, bool RemoveIntermediateLayers)
	{
		vtkSelectionSource_SetRemoveIntermediateLayers_119(GetCppThis(), nodeId, (byte)(RemoveIntermediateLayers ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetRemoveIntermediateLayers_120(HandleRef pThis, byte RemoveIntermediateLayers);

	/// <summary>
	/// Set/Get the number of layers related flag to remove intermediate layers
	///
	/// The default is false.
	/// </summary>
	public void SetRemoveIntermediateLayers(bool RemoveIntermediateLayers)
	{
		vtkSelectionSource_SetRemoveIntermediateLayers_120(GetCppThis(), (byte)(RemoveIntermediateLayers ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetRemoveSeed_121(HandleRef pThis, uint nodeId, byte RemoveSeed);

	/// <summary>
	/// Set/Get the number of layers related flag to remove seed selection
	///
	/// The default is false.
	/// </summary>
	public void SetRemoveSeed(uint nodeId, bool RemoveSeed)
	{
		vtkSelectionSource_SetRemoveSeed_121(GetCppThis(), nodeId, (byte)(RemoveSeed ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionSource_SetRemoveSeed_122(HandleRef pThis, byte RemoveSeed);

	/// <summary>
	/// Set/Get the number of layers related flag to remove seed selection
	///
	/// The default is false.
	/// </summary>
	public void SetRemoveSeed(bool RemoveSeed)
	{
		vtkSelectionSource_SetRemoveSeed_122(GetCppThis(), (byte)(RemoveSeed ? 1u : 0u));
	}
}
