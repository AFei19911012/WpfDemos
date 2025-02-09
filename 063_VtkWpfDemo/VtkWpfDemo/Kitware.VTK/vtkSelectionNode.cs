using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkSelectionNode
/// </summary>
/// <remarks>
///  a node in a vtkSelection the defines the selection criteria.
///
/// vtkSelectionNode helps define the selection criteria in a vtkSelection.
/// vtkSelection can comprise of multiple such vtkSelectionNode instances that
/// help define the selection.
///
/// vtkSelectionNode has two components: a list of properties (stored in a
/// vtkInformation) and a selection list (a vtkAbstractArray subclass). The
/// properties help indicate how to interpret the values specified in a
/// selection-list.
///
/// The properties can be broadly classified into three categories: core,
/// qualifiers, and information. The core properties must be specified other wise the
/// vtkSelectionNode is not considered valid. These are `FIELD_TYPE` and
/// `CONTENT_TYPE`. `FIELD_TYPE` defines what kinds of entities are being selected.
/// Since selections are used to select items in a data-object, these correspond to
/// things like cells, points, nodes, edges, rows, etc. Supported FIELD_TYPE
/// values are defined in `vtkSelectionNode::SelectionField`. `CONTENT_TYPE`
/// defines the how the selection is described. Supported values are
/// `vtkSelectionNode::SelectionContent`. For example, if CONTENT_TYPE is
/// `INDICES`, then selection is described as ids for entities being selected.
/// The ids themselves will be specified using the selection list. Thus, the
/// CONTENT_TYPE dictates what the selection list comprises.
///
/// Qualifiers are used to further qualify the selection criteria. All qualifiers
/// are optional. When present they restrict the selection. For example, when
/// selecting elements from a composite-dataset, the `COMPOSITE_INDEX` qualifier
/// can be specified of limit the selection to a specific dataset (or subtree).
///
/// Information properties are simply for informative purposes and generally used
/// to provide information about the selection when the selection is created. For
/// example, `PIXEL_COUNT` is used to indicate how many screen pixels resulted in
/// creation of this selection node.
///
/// @section SelectionTypes Selection Types
///
/// `CONTENT_TYPE` property is one of the required properties that helps
/// describe how the selection is defined. To set the content type, one can
/// access the properties store using `vtkSelectionNode::GetProperties()` and
/// then set the `CONTENT_TYPE` using the `vtkSelectionNode::CONTENT_TYPE()` key
/// or simply use `vtkSelectionNode::SetContentType`.
///
/// * `vtkSelectionNode::GLOBALIDS`: indicates that the selection is defined
///   using global ids. In VTK data-object, global ids are specified an `vtkIdTypeArray`
///   added to a appropriate `vtkDataSetAttributes` and marked as global-ids
///   using vtkDataSetAttributes API. Since global ids are expected to be unique
///   for that element type over the entire dataset, it's a convenient way of
///   defining selections. For this content-type, the selection list must be
///   a single-component, `vtkIdTypeArray` that lists all the globals ids for
///   the selected elements.
///
/// * `vtkSelectionNode::PEDIGREEIDS`: similar to `GLOBALIDS` except uses
///   pedigree ids instead of global ids.
///
/// * `vtkSelectionNode::VALUES`: this type is used to define a selection based
///   on array values. The selection list specifies the values to be selected.
///   All elements with array values in the selection list are treated as
///   selected. The qualifier COMPONENT_NUMBER is used to indicate which
///   component to use for the checks. Use `-1` for magnitude. Current
///   implementation does not support checking multiple-components or non-exact
///   matches although support for both is conceivable in future.
///   The selection list array name is used to specify the name of the array from
///   the dataset to use for the checks. Thus, for defining a selection for a
///   dataset where all `TEMP` values match those specified in the selection
///   list, ensure that the selection list array's name is set to `TEMP` as well.
///
/// * `vtkSelectionNode::INDICES`: this is similar to global ids except in this
///   case the selection list is simply the VTK element id which is 0-based
///   index of that element in the particular dataset. Often with this type of
///   selection, additional qualifiers such as `COMPOSITE_INDEX`,
///   `BLOCK_SELECTORS`, `PROCESS_ID` etc. are needed to correctly identify the
///   chosen element(s) in case of composite or distributed datasets.
///
/// * `vtkSelectionNode::FRUSTUM`: this type is used to define a frustum in world
///   coordinates that identifies the selected elements. In this case, the
///   selection list is a vtkDoubleArray with 32 values specifying the 8 frustum
///   corners in homogeneous world coordinates.
///
/// * `vtkSelectionNode::LOCATIONS`: this is used to select points (or cells)
///   near (or containing) specified locations. The selection list is a
///   3-component vtkDoubleArray with coordinates for locations of interest.
///
/// * `vtkSelectionNode::THRESHOLDS`: this type is used to define a selection based
///   on array value ranges. This is akin to thresholding. All elements with values in
///   the specified ranges are to be treated as selected. For this content-type,
///   the selection-list is a 2-component `vtkDataArray`-subclass that specifies
///   where each tuple defines the min and max values for a range. The selection
///   list can have multiple tuples to define multiple ranges. Elements with
///   values in any of the specified ranges are treated as selected. The
///   selection list array name is used to specify the name of the array from
///   the dataset to use for the checks. Thus, for defining a selection for a
///   dataset where all `TEMP` values are within a range, ensure that the
///   selection list array's name is set to `TEMP` as well.
///
/// * `vtkSelectionNode::BLOCKS`: this type is used to select blocks in a
///   composite dataset. The term blocks is used loosely here and can correspond
///   to a block in a multiblock dataset or a partition in a partitioned-dataset.
///   The selection list is an integral type vtkDataArray subclass that can be 1-
///   or 2- component. If 1-component, it's interpreted as the composite-index
///   (also called flat index) and can be applied to any composite-dataset to
///   choose specific datasets. If 2-component, it's typically associated with
///   vtkUniformGridAMR or vtkPartitionedDataSetCollection which support 2-tuple
///   indexing to locate a dataset.
///
/// * `vtkSelectionNode::BLOCK_SELECTORS`: this is similar to BLOCKS, however
///   instead of using indices to select datasets, here, the selection list is a
///   vtkStringArray which lists selector expressions to select blocks in the
///   composite dataset. By default, the selector expressions are applied to a
///   vtkDataAssembly generated from the composite dataset that represents its
///   hierarchy (see `vtkDataAssembly::GenerateHierarchy`). However, in case of
///   vtkPartitionedDataSetCollection, one can select any other data assembly
///   associated with the vtkPartitionedDataSetCollection by naming the array
///   with the name of the assembly.
///
///   @note, currently vtkPartitionedDataSetCollection only supports a single
///   vtkDataAssembly but this may change in the future.
///
/// * `vtkSelectionNode::QUERY`: this type is primarily added for ParaView where
///   selection expression is specified as a query string. This is likely to
///   change in the future and hence applications are discouraged from using this
///   type.
///
/// @section Properties Properties
///
/// Following a properties that can be used to qualify the selection.
///
/// * `vtkSelectionNode::EPSILON()`: this is a qualifier that can be used to
///   indicate a fuzz-factor when comparing values for equality. Currently, this
///   is only used with content-type LOCATIONS, however, it can be expanded to
///   other selection types in the future.
///
/// * `vtkSelectionNode::CONTAINING_CELLS()`: this qualifier is intended to be
///   used with field-type `POINT`. When present, it indicates that while the
///   selection criteria selects a collection of points the selection should be
///   formed using cell containing the chosen points.
///
/// * `vtkSelectionNode::CONNECTED_LAYERS()`: a qualifier used to expand the
///   definition of selected elements to connected elements for the specified
///   number of layers. Layers can only be positive to grow the selection.
///
/// * `vtkSelectionNode::CONNECTED_LAYERS_REMOVE_SEED()`: this qualifier indicates
///   that when using a number of CONNECTED_LAYERS &gt;= 1, the initial selection will
///   not be kept.
///
/// * `vtkSelectionNode::CONNECTED_LAYERS_REMOVE_INTERMEDIATE_LAYERS()`: this qualifier
///   indicates that when using a number of CONNECTED_LAYERS &gt;= 2, the intermediate layers
///   will not be kept.
///
/// * `vtkSelectionNode::INVERSE()`: a qualifier that causes the selection to be
///   inverted i.e. all elements not chosen by the criteria are to be treated
///   as selected.
///
/// * `vtkSelectionNode::COMPONENT_NUMBER()`: for VALUES and THRESHOLDS selection
///   types, this qualifier identifies the array component of interest. -1
///   indicates magnitude.
///
/// * `vtkSelectionNode::PROCESS_ID()`: limits the selection to a particular
///   rank in a distributed environment.
///
/// * `vtkSelectionNode::COMPOSITE_INDEX()`: a qualifier used to limit the
///   selection to a specific composite index for a composite-dataset.
///
/// * `vtkSelectionNode::ASSEMBLY_NAME()`, `vtkSelectionNode::SELECTORS()`:
///   similar to composite index, except uses data-assembly and selectors to
///   limit the selection to a subset of nodes in a composite-dataset.
///
/// * `vtkSelectionNode::HIERARCHICAL_LEVEL()`,
///   `vtkSelectionNode::HIERARCHICAL_INDEX()`: similar to composite index, except
///   uses level and index for an AMR dataset so limit the selection to a
///   specific AMR level or dataset.
///
/// Following for properties that are primarily intended to provide additional
/// information when the selection is created.
///
/// * `vtkSelectionNode::ZBUFFER_VALUE()`: an information qualifier representing
///   the z-depth for a particular selection when it was created.
///
/// * `vtkSelectionNode::PIXEL_COUNT()`: a qualifier used to provide a count for
///   the number of pixels that resulted in this selection.
///
/// * `vtkSelectionNode::SOURCE()`, `vtkSelectionNode::SOURCE_ID()`: provides
///   information about data producer or selection originator. The interpretation
///   is very specific to the creator creating the selection and varies greatly
///   with VTK.
///
/// * `vtkSelectionNode::PROP(), `vtkSelectionNode::PROP_ID()`: similar to
///   SOURCE/SOURCE_ID except is used to represent a rendering prop from which
///   the selection was created.
///
/// @warning
/// No SelectionList is created by default. It should be assigned.
///
/// @section SelectionFieldMismatch vtkSelectionNode::SelectionField and
/// vtkDataSetAttribute::AttributeTypes
///
/// Strictly speaking, vtkSelectionNode::SelectionField maps directly to
/// vtkDataSetAttribute::AttributeTypes. However, the two enum values are not
/// identical for historical reasons. Use
/// `vtkSelectionNode::ConvertSelectionFieldToAttributeType` and
/// `vtkSelectionNode::ConvertAttributeTypeToSelectionField` to convert between
/// the two.
/// </remarks>
public class vtkSelectionNode : vtkObject
{
	/// <summary>
	/// Indicate the means by which data is selected.
	/// In some cases this implies the type of data selected.
	/// </summary>
	public enum SelectionContent
	{
		/// <summary>enum member</summary>
		BLOCKS = 7,
		/// <summary>enum member</summary>
		BLOCK_SELECTORS = 8,
		/// <summary>enum member</summary>
		FRUSTUM = 4,
		/// <summary>enum member</summary>
		GLOBALIDS = 0,
		/// <summary>enum member</summary>
		INDICES = 3,
		/// <summary>enum member</summary>
		LOCATIONS = 5,
		/// <summary>enum member</summary>
		NUM_CONTENT_TYPES = 11,
		/// <summary>enum member</summary>
		PEDIGREEIDS = 1,
		/// <summary>enum member</summary>
		QUERY = 9,
		/// <summary>enum member</summary>
		THRESHOLDS = 6,
		/// <summary>enum member</summary>
		USER = 10,
		/// <summary>enum member</summary>
		VALUES = 2
	}

	/// <summary>
	/// Controls whether cell, point, or field data determine what is inside and out.
	/// The default is CELL.
	/// Vertex and edge types are also available for graph classes.
	/// GetFieldType() returns -1 if the field type is not set.
	/// </summary>
	public enum SelectionField
	{
		/// <summary>enum member</summary>
		CELL = 0,
		/// <summary>enum member</summary>
		EDGE = 4,
		/// <summary>enum member</summary>
		FIELD = 2,
		/// <summary>enum member</summary>
		NUM_FIELD_TYPES = 6,
		/// <summary>enum member</summary>
		POINT = 1,
		/// <summary>enum member</summary>
		ROW = 5,
		/// <summary>enum member</summary>
		VERTEX = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSelectionNode";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSelectionNode()
	{
		MRClassNameKey = "class vtkSelectionNode";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectionNode"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSelectionNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSelectionNode New()
	{
		vtkSelectionNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSelectionNode()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSelectionNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_ASSEMBLY_NAME_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Keys for selector-based identification of
	/// blocks to choose from a composite dataset. `ASSEMBLY_NAME` identifies the
	/// name for the assembly to use and `SELECTORS` provide a list of node
	/// selectors applied to the chosen assembly.
	///
	/// Use `vtkDataAssemblyUtilities::HierarchyName` as the assembly name
	/// to use the data hierarchy
	/// </summary>
	public static vtkInformationStringKey ASSEMBLY_NAME()
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_ASSEMBLY_NAME_01(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringKey2 = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringKey2.Register(null);
			}
		}
		return vtkInformationStringKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_COMPONENT_NUMBER_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When ContentType==THRESHOLDS  or ContentType==VALUES
	/// i.e. threshold and value based selections, it is
	/// possible pick the component number using this key. If none is specified,
	/// the 0th component is used. If any number less than 0 is specified, then
	/// the magnitude is used.
	/// </summary>
	public static vtkInformationIntegerKey COMPONENT_NUMBER()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_COMPONENT_NUMBER_02(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_COMPOSITE_INDEX_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Used to identify a node in composite datasets.
	/// </summary>
	public static vtkInformationIntegerKey COMPOSITE_INDEX()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_COMPOSITE_INDEX_03(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_CONNECTED_LAYERS_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When specified, this indicates how many layers of *connected* elements
	/// in addition to those chosen explicitly are being selected. Currently,
	/// this is only supported for cells and points.
	/// </summary>
	public static vtkInformationIntegerKey CONNECTED_LAYERS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_CONNECTED_LAYERS_04(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_CONNECTED_LAYERS_REMOVE_INTERMEDIATE_LAYERS_05(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When specified and also using CONNECTED_LAYERS(), this indicates
	/// if the intermediate layers should be kept or not.
	/// </summary>
	public static vtkInformationIntegerKey CONNECTED_LAYERS_REMOVE_INTERMEDIATE_LAYERS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_CONNECTED_LAYERS_REMOVE_INTERMEDIATE_LAYERS_05(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_CONNECTED_LAYERS_REMOVE_SEED_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When specified and also using CONNECTED_LAYERS(), this indicates
	/// if the initial selection should be kept or not.
	/// </summary>
	public static vtkInformationIntegerKey CONNECTED_LAYERS_REMOVE_SEED()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_CONNECTED_LAYERS_REMOVE_SEED_06(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_CONTAINING_CELLS_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This flag tells the extraction filter, when FIELD_TYPE==POINT, that
	/// it should also extract the cells that contain any of the extracted points.
	/// </summary>
	public static vtkInformationIntegerKey CONTAINING_CELLS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_CONTAINING_CELLS_07(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_CONTENT_TYPE_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the (primary) property that describes the content of a selection
	/// node's data. This key takes on values from the SelectionContent enum.
	/// GetContentType() returns -1 if the content type is not set.
	///
	/// \sa vtkSelectionNode::SelectionContent
	/// </summary>
	public static vtkInformationIntegerKey CONTENT_TYPE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_CONTENT_TYPE_08(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionNode_ConvertAttributeTypeToSelectionField_09(int val);

	/// <summary>
	/// Methods to convert vtkSelectionNode::SelectionField to
	/// vtkDataSetAttribute::AttributeTypes and vice-versa.
	/// </summary>
	public static int ConvertAttributeTypeToSelectionField(int val)
	{
		return vtkSelectionNode_ConvertAttributeTypeToSelectionField_09(val);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionNode_ConvertSelectionFieldToAttributeType_10(int val);

	/// <summary>
	/// Methods to convert vtkSelectionNode::SelectionField to
	/// vtkDataSetAttribute::AttributeTypes and vice-versa.
	/// </summary>
	public static int ConvertSelectionFieldToAttributeType(int val)
	{
		return vtkSelectionNode_ConvertSelectionFieldToAttributeType_10(val);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_DeepCopy_11(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Copy properties, selection list and children of the input.
	/// </summary>
	public virtual void DeepCopy(vtkSelectionNode src)
	{
		vtkSelectionNode_DeepCopy_11(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_EPSILON_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// For location selection of points, if distance is greater than this reject.
	/// </summary>
	public static vtkInformationDoubleKey EPSILON()
	{
		vtkInformationDoubleKey vtkInformationDoubleKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_EPSILON_12(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleKey2 = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleKey2.Register(null);
			}
		}
		return vtkInformationDoubleKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSelectionNode_EqualProperties_13(HandleRef pThis, HandleRef other, byte fullcompare);

	/// <summary>
	/// Compares Properties of self and other to ensure that they are exactly same.
	/// </summary>
	public bool EqualProperties(vtkSelectionNode other, bool fullcompare)
	{
		return (vtkSelectionNode_EqualProperties_13(GetCppThis(), other?.GetCppThis() ?? default(HandleRef), (byte)(fullcompare ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_FIELD_TYPE_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Controls whether cell, point, or field data determine what is inside and out.
	/// The default is CELL.
	/// Vertex and edge types are also available for graph classes.
	/// GetFieldType() returns -1 if the field type is not set.
	/// </summary>
	public static vtkInformationIntegerKey FIELD_TYPE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_FIELD_TYPE_14(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionNode_GetContentType_15(HandleRef pThis);

	/// <summary>
	/// Get or set the content type of the selection.
	/// This is the same as setting the CONTENT_TYPE() key on the property.
	/// </summary>
	public virtual int GetContentType()
	{
		return vtkSelectionNode_GetContentType_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_GetContentTypeAsString_16(int type);

	/// <summary>
	/// Get the content type as a string.
	/// </summary>
	public static string GetContentTypeAsString(int type)
	{
		return Marshal.PtrToStringAnsi(vtkSelectionNode_GetContentTypeAsString_16(type));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionNode_GetFieldType_17(HandleRef pThis);

	/// <summary>
	/// Get or set the field type of the selection.
	/// This is the same as setting the FIELD_TYPE() key on the property.
	/// </summary>
	public virtual int GetFieldType()
	{
		return vtkSelectionNode_GetFieldType_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_GetFieldTypeAsString_18(int type);

	/// <summary>
	/// Get the field type as a string.
	/// </summary>
	public static string GetFieldTypeAsString(int type)
	{
		return Marshal.PtrToStringAnsi(vtkSelectionNode_GetFieldTypeAsString_18(type));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionNode_GetFieldTypeFromString_19(string type);

	/// <summary>
	/// Get field type from string. Returns NUM_FIELD_TYPES if not found.
	/// </summary>
	public static int GetFieldTypeFromString(string type)
	{
		return vtkSelectionNode_GetFieldTypeFromString_19(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSelectionNode_GetMTime_20(HandleRef pThis);

	/// <summary>
	/// Return the MTime taking into account changes to the properties
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSelectionNode_GetMTime_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectionNode_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSelectionNode_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelectionNode_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSelectionNode_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_GetProperties_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the property map.
	/// </summary>
	public virtual vtkInformation GetProperties()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_GetProperties_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_GetQueryString_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the query expression string.
	/// </summary>
	public virtual string GetQueryString()
	{
		return Marshal.PtrToStringAnsi(vtkSelectionNode_GetQueryString_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_GetSelectionData_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Sets the selection table.
	/// </summary>
	public virtual vtkDataSetAttributes GetSelectionData()
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_GetSelectionData_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetAttributes2 = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetAttributes2.Register(null);
			}
		}
		return vtkDataSetAttributes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_GetSelectionList_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the selection list. The selection list is the container
	/// that stores values that indicate the selected items. What these values
	/// correspond to depends on the `ContentType`. `ContentType` may also dictate
	/// the type and form of the selection list array.
	/// </summary>
	public virtual vtkAbstractArray GetSelectionList()
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_GetSelectionList_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_HIERARCHICAL_INDEX_27(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Used to identify a dataset in a hiererchical box dataset.
	/// </summary>
	public static vtkInformationIntegerKey HIERARCHICAL_INDEX()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_HIERARCHICAL_INDEX_27(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_HIERARCHICAL_LEVEL_28(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Used to identify a dataset in a hiererchical box dataset.
	/// </summary>
	public static vtkInformationIntegerKey HIERARCHICAL_LEVEL()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_HIERARCHICAL_LEVEL_28(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_INVERSE_29(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This flag tells the extraction filter to exclude the selection.
	/// </summary>
	public static vtkInformationIntegerKey INVERSE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_INVERSE_29(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_Initialize_30(HandleRef pThis);

	/// <summary>
	/// Restore data object to initial state,
	/// </summary>
	public virtual void Initialize()
	{
		vtkSelectionNode_Initialize_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionNode_IsA_31(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSelectionNode_IsA_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelectionNode_IsTypeOf_32(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSelectionNode_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSelectionNode NewInstance()
	{
		vtkSelectionNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_PIXEL_COUNT_35(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A helper for visible cell selector, this is the number of pixels covered
	/// by the actor whose cells are listed in the selection.
	/// </summary>
	public static vtkInformationIntegerKey PIXEL_COUNT()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_PIXEL_COUNT_35(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_PROCESS_ID_36(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Process id the selection is on.
	/// </summary>
	public static vtkInformationIntegerKey PROCESS_ID()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_PROCESS_ID_36(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_PROP_37(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Pointer to the prop the selection belongs to.
	/// </summary>
	public static vtkInformationObjectBaseKey PROP()
	{
		vtkInformationObjectBaseKey vtkInformationObjectBaseKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_PROP_37(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseKey2 = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_PROP_ID_38(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// ID of the prop the selection belongs to. What
	/// ID means is application specific.
	/// </summary>
	public static vtkInformationIntegerKey PROP_ID()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_PROP_ID_38(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_SELECTORS_39(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Keys for selector-based identification of
	/// blocks to choose from a composite dataset. `ASSEMBLY_NAME` identifies the
	/// name for the assembly to use and `SELECTORS` provide a list of node
	/// selectors applied to the chosen assembly.
	///
	/// Use `vtkDataAssemblyUtilities::HierarchyName` as the assembly name
	/// to use the data hierarchy
	/// </summary>
	public static vtkInformationStringVectorKey SELECTORS()
	{
		vtkInformationStringVectorKey vtkInformationStringVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_SELECTORS_39(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringVectorKey2 = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringVectorKey2.Register(null);
			}
		}
		return vtkInformationStringVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_SOURCE_40(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Pointer to the data or algorithm the selection belongs to.
	/// </summary>
	public static vtkInformationObjectBaseKey SOURCE()
	{
		vtkInformationObjectBaseKey vtkInformationObjectBaseKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_SOURCE_40(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseKey2 = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_SOURCE_ID_41(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// ID of the data or algorithm the selection belongs to. What
	/// ID means is application specific.
	/// </summary>
	public static vtkInformationIntegerKey SOURCE_ID()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_SOURCE_ID_41(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSelectionNode SafeDownCast(vtkObjectBase o)
	{
		vtkSelectionNode vtkSelectionNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelectionNode2 = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelectionNode2.Register(null);
			}
		}
		return vtkSelectionNode2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_SetContentType_43(HandleRef pThis, int type);

	/// <summary>
	/// Get or set the content type of the selection.
	/// This is the same as setting the CONTENT_TYPE() key on the property.
	/// </summary>
	public virtual void SetContentType(int type)
	{
		vtkSelectionNode_SetContentType_43(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_SetFieldType_44(HandleRef pThis, int type);

	/// <summary>
	/// Get or set the field type of the selection.
	/// This is the same as setting the FIELD_TYPE() key on the property.
	/// </summary>
	public virtual void SetFieldType(int type)
	{
		vtkSelectionNode_SetFieldType_44(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_SetQueryString_45(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the query expression string.
	/// </summary>
	public virtual void SetQueryString(string _arg)
	{
		vtkSelectionNode_SetQueryString_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_SetSelectionData_46(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Sets the selection table.
	/// </summary>
	public virtual void SetSelectionData(vtkDataSetAttributes data)
	{
		vtkSelectionNode_SetSelectionData_46(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_SetSelectionList_47(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the selection list. The selection list is the container
	/// that stores values that indicate the selected items. What these values
	/// correspond to depends on the `ContentType`. `ContentType` may also dictate
	/// the type and form of the selection list array.
	/// </summary>
	public virtual void SetSelectionList(vtkAbstractArray arg0)
	{
		vtkSelectionNode_SetSelectionList_47(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_ShallowCopy_48(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Copy properties, selection list and children of the input.
	/// This is a shallow copy: selection lists and pointers in the
	/// properties are passed by reference.
	/// </summary>
	public virtual void ShallowCopy(vtkSelectionNode src)
	{
		vtkSelectionNode_ShallowCopy_48(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_SubtractSelectionList_49(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Subtracts the items in the selection list, other, from this selection list.
	/// Assumes that both selections have identical properties (i.e., test with EqualProperties
	/// before using).
	/// </summary>
	public void SubtractSelectionList(vtkSelectionNode other)
	{
		vtkSelectionNode_SubtractSelectionList_49(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelectionNode_UnionSelectionList_50(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Merges the selection list between self and the other. Assumes that both has
	/// identical properties.
	/// </summary>
	public void UnionSelectionList(vtkSelectionNode other)
	{
		vtkSelectionNode_UnionSelectionList_50(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelectionNode_ZBUFFER_VALUE_51(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If present, closest zbuffer value of this selection
	/// </summary>
	public static vtkInformationDoubleKey ZBUFFER_VALUE()
	{
		vtkInformationDoubleKey vtkInformationDoubleKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelectionNode_ZBUFFER_VALUE_51(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleKey2 = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleKey2.Register(null);
			}
		}
		return vtkInformationDoubleKey2;
	}
}
