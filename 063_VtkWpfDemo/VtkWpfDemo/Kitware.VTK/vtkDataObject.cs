using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataObject
/// </summary>
/// <remarks>
///    general representation of visualization data
///
/// vtkDataObject is an general representation of visualization data. It serves
/// to encapsulate instance variables and methods for visualization network
/// execution, as well as representing data consisting of a field (i.e., just
/// an unstructured pile of data). This is to be compared with a vtkDataSet,
/// which is data with geometric and/or topological structure.
///
/// vtkDataObjects are used to represent arbitrary repositories of data via the
/// vtkFieldData instance variable. These data must be eventually mapped into a
/// concrete subclass of vtkDataSet before they can actually be displayed.
///
/// </remarks>
/// <seealso>
///
/// vtkDataSet vtkFieldData vtkDataObjectToDataSetFilter
/// vtkFieldDataToAttributeDataFilter
/// </seealso>
public class vtkDataObject : vtkObject
{
	/// <summary>
	/// Possible attribute types.
	/// POINT_THEN_CELL is provided for consistency with FieldAssociations.
	/// </summary>
	public enum AttributeTypes
	{
		/// <summary>enum member</summary>
		CELL = 1,
		/// <summary>enum member</summary>
		EDGE = 5,
		/// <summary>enum member</summary>
		FIELD = 2,
		/// <summary>enum member</summary>
		NUMBER_OF_ATTRIBUTE_TYPES = 7,
		/// <summary>enum member</summary>
		POINT = 0,
		/// <summary>enum member</summary>
		POINT_THEN_CELL = 3,
		/// <summary>enum member</summary>
		ROW = 6,
		/// <summary>enum member</summary>
		VERTEX = 4
	}

	/// <summary>
	/// Possible values for the FIELD_ASSOCIATION information entry.
	/// </summary>
	public enum FieldAssociations
	{
		/// <summary>enum member</summary>
		FIELD_ASSOCIATION_CELLS = 1,
		/// <summary>enum member</summary>
		FIELD_ASSOCIATION_EDGES = 5,
		/// <summary>enum member</summary>
		FIELD_ASSOCIATION_NONE = 2,
		/// <summary>enum member</summary>
		FIELD_ASSOCIATION_POINTS = 0,
		/// <summary>enum member</summary>
		FIELD_ASSOCIATION_POINTS_THEN_CELLS = 3,
		/// <summary>enum member</summary>
		FIELD_ASSOCIATION_ROWS = 6,
		/// <summary>enum member</summary>
		FIELD_ASSOCIATION_VERTICES = 4,
		/// <summary>enum member</summary>
		NUMBER_OF_ASSOCIATIONS = 7
	}

	/// <summary>
	/// Possible values for the FIELD_OPERATION information entry.
	/// </summary>
	public enum FieldOperations
	{
		/// <summary>enum member</summary>
		FIELD_OPERATION_MODIFIED = 2,
		/// <summary>enum member</summary>
		FIELD_OPERATION_PRESERVED = 0,
		/// <summary>enum member</summary>
		FIELD_OPERATION_REINTERPOLATED = 1,
		/// <summary>enum member</summary>
		FIELD_OPERATION_REMOVED = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataObject";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataObject()
	{
		MRClassNameKey = "class vtkDataObject";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObject"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObject New()
	{
		vtkDataObject result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataObject()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_ALL_PIECES_EXTENT_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerVectorKey ALL_PIECES_EXTENT()
	{
		vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_ALL_PIECES_EXTENT_01(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerVectorKey2 = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerVectorKey2.Register(null);
			}
		}
		return vtkInformationIntegerVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_BOUNDING_BOX_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationDoubleVectorKey BOUNDING_BOX()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_BOUNDING_BOX_02(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_CELL_DATA_VECTOR_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationInformationVectorKey CELL_DATA_VECTOR()
	{
		vtkInformationInformationVectorKey vtkInformationInformationVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_CELL_DATA_VECTOR_03(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationInformationVectorKey2 = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationInformationVectorKey2.Register(null);
			}
		}
		return vtkInformationInformationVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_CopyInformationFromPipeline_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Copy from the pipeline information to the data object's own information.
	/// Called right before the main execution pass.
	/// </summary>
	public virtual void CopyInformationFromPipeline(vtkInformation arg0)
	{
		vtkDataObject_CopyInformationFromPipeline_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_CopyInformationToPipeline_05(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Copy information from this data object to the pipeline information.
	/// This is used by the vtkTrivialProducer that is created when someone
	/// calls SetInputData() to connect a data object to a pipeline.
	/// </summary>
	public virtual void CopyInformationToPipeline(vtkInformation arg0)
	{
		vtkDataObject_CopyInformationToPipeline_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_Crop_06(HandleRef pThis, IntPtr updateExtent);

	/// <summary>
	/// This method crops the data object (if necessary) so that the extent
	/// matches the update extent.
	/// </summary>
	public virtual void Crop(IntPtr updateExtent)
	{
		vtkDataObject_Crop_06(GetCppThis(), updateExtent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_DATA_EXTENT_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerPointerKey DATA_EXTENT()
	{
		vtkInformationIntegerPointerKey vtkInformationIntegerPointerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_DATA_EXTENT_07(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerPointerKey2 = (vtkInformationIntegerPointerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerPointerKey2.Register(null);
			}
		}
		return vtkInformationIntegerPointerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_DATA_EXTENT_TYPE_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey DATA_EXTENT_TYPE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_DATA_EXTENT_TYPE_08(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey DATA_NUMBER_OF_GHOST_LEVELS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_09(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_DATA_NUMBER_OF_PIECES_10(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey DATA_NUMBER_OF_PIECES()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_DATA_NUMBER_OF_PIECES_10(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_DATA_OBJECT_11(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationDataObjectKey DATA_OBJECT()
	{
		vtkInformationDataObjectKey vtkInformationDataObjectKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_DATA_OBJECT_11(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDataObjectKey2 = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDataObjectKey2.Register(null);
			}
		}
		return vtkInformationDataObjectKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_DATA_PIECE_NUMBER_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey DATA_PIECE_NUMBER()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_DATA_PIECE_NUMBER_12(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_DATA_TIME_STEP_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationDoubleKey DATA_TIME_STEP()
	{
		vtkInformationDoubleKey vtkInformationDoubleKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_DATA_TIME_STEP_13(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_DATA_TYPE_NAME_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationStringKey DATA_TYPE_NAME()
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_DATA_TYPE_NAME_14(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_DIRECTION_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationDoubleVectorKey DIRECTION()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_DIRECTION_15(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_DataHasBeenGenerated_16(HandleRef pThis);

	/// <summary>
	/// This method is called by the source when it executes to generate data.
	/// It is sort of the opposite of ReleaseData.
	/// It sets the DataReleased flag to 0, and sets a new UpdateTime.
	/// </summary>
	public void DataHasBeenGenerated()
	{
		vtkDataObject_DataHasBeenGenerated_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_DeepCopy_17(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.  These copy the data, but not any of the
	/// pipeline connections.
	/// </summary>
	public virtual void DeepCopy(vtkDataObject src)
	{
		vtkDataObject_DeepCopy_17(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_EDGE_DATA_VECTOR_18(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationInformationVectorKey EDGE_DATA_VECTOR()
	{
		vtkInformationInformationVectorKey vtkInformationInformationVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_EDGE_DATA_VECTOR_18(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationInformationVectorKey2 = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationInformationVectorKey2.Register(null);
			}
		}
		return vtkInformationInformationVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_19(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey FIELD_ACTIVE_ATTRIBUTE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_19(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_FIELD_ARRAY_TYPE_20(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey FIELD_ARRAY_TYPE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_FIELD_ARRAY_TYPE_20(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_FIELD_ASSOCIATION_21(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey FIELD_ASSOCIATION()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_FIELD_ASSOCIATION_21(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_FIELD_ATTRIBUTE_TYPE_22(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey FIELD_ATTRIBUTE_TYPE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_FIELD_ATTRIBUTE_TYPE_22(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_FIELD_NAME_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationStringKey FIELD_NAME()
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_FIELD_NAME_23(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_24(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey FIELD_NUMBER_OF_COMPONENTS()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_24(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_FIELD_NUMBER_OF_TUPLES_25(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey FIELD_NUMBER_OF_TUPLES()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_FIELD_NUMBER_OF_TUPLES_25(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_FIELD_OPERATION_26(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerKey FIELD_OPERATION()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_FIELD_OPERATION_26(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_FIELD_RANGE_27(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationDoubleVectorKey FIELD_RANGE()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_FIELD_RANGE_27(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_GetActiveFieldInformation_28(HandleRef info, int fieldAssociation, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the information object within the input information object's
	/// field data corresponding to the specified association
	/// (FIELD_ASSOCIATION_POINTS or FIELD_ASSOCIATION_CELLS) and attribute
	/// (SCALARS, VECTORS, NORMALS, TCOORDS, or TENSORS)
	/// </summary>
	public static vtkInformation GetActiveFieldInformation(vtkInformation info, int fieldAssociation, int attributeType)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_GetActiveFieldInformation_28(info?.GetCppThis() ?? default(HandleRef), fieldAssociation, attributeType, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkDataObject_GetActualMemorySize_29(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kibibytes (1024 bytes). This number
	/// is valid only after the pipeline has updated. The memory size
	/// returned is guaranteed to be greater than or equal to the
	/// memory required to represent the data (e.g., extra space in
	/// arrays, etc. are not included in the return value).
	/// </summary>
	public virtual uint GetActualMemorySize()
	{
		return vtkDataObject_GetActualMemorySize_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_GetAssociationTypeAsString_30(int associationType);

	/// <summary>
	/// Given an integer association type, this static method returns a string type
	/// for the attribute (i.e. associationType = 0: returns "Points").
	/// </summary>
	public static string GetAssociationTypeAsString(int associationType)
	{
		return Marshal.PtrToStringAnsi(vtkDataObject_GetAssociationTypeAsString_30(associationType));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObject_GetAssociationTypeFromString_31(string associationName);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static int GetAssociationTypeFromString(string associationName)
	{
		return vtkDataObject_GetAssociationTypeFromString_31(associationName);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObject_GetAttributeTypeForArray_32(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Retrieves the attribute type that an array came from.
	/// This is useful for obtaining which attribute type a input array
	/// to an algorithm came from (retrieved from GetInputAbstractArrayToProcesss).
	/// </summary>
	public virtual int GetAttributeTypeForArray(vtkAbstractArray arr)
	{
		return vtkDataObject_GetAttributeTypeForArray_32(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_GetAttributes_33(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the attributes of the data object of the specified
	/// attribute type. The type may be:
	/// &lt;ul&gt;
	/// &lt;li&gt;POINT  - Defined in vtkDataSet subclasses.
	/// &lt;li&gt;CELL   - Defined in vtkDataSet subclasses.
	/// &lt;li&gt;VERTEX - Defined in vtkGraph subclasses.
	/// &lt;li&gt;EDGE   - Defined in vtkGraph subclasses.
	/// &lt;li&gt;ROW    - Defined in vtkTable.
	/// &lt;/ul&gt;
	/// The other attribute type, FIELD, will return nullptr since
	/// field data is stored as a vtkFieldData instance, not a
	/// vtkDataSetAttributes instance. To retrieve field data, use
	/// GetAttributesAsFieldData.
	///
	/// @warning This method NEEDS to be
	/// overridden in subclasses to work as documented.
	/// If not, it returns nullptr for any type but FIELD.
	/// </summary>
	public virtual vtkDataSetAttributes GetAttributes(int type)
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_GetAttributes_33(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObject_GetAttributesAsFieldData_34(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the attributes of the data object as a vtkFieldData.
	/// This returns non-null values in all the same cases as GetAttributes,
	/// in addition to the case of FIELD, which will return the field data
	/// for any vtkDataObject subclass.
	/// </summary>
	public virtual vtkFieldData GetAttributesAsFieldData(int type)
	{
		vtkFieldData vtkFieldData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_GetAttributesAsFieldData_34(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFieldData2 = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFieldData2.Register(null);
			}
		}
		return vtkFieldData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_GetData_35(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public static vtkDataObject GetData(vtkInformation info)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_GetData_35(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_GetData_36(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public static vtkDataObject GetData(vtkInformationVector v, int i)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_GetData_36(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObject_GetDataObjectType_37(HandleRef pThis);

	/// <summary>
	/// Return class name of data type. This is one of VTK_STRUCTURED_GRID,
	/// VTK_STRUCTURED_POINTS, VTK_UNSTRUCTURED_GRID, VTK_POLY_DATA, or
	/// VTK_RECTILINEAR_GRID (see vtkSetGet.h for definitions).
	/// THIS METHOD IS THREAD SAFE
	/// </summary>
	public virtual int GetDataObjectType()
	{
		return vtkDataObject_GetDataObjectType_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObject_GetDataReleased_38(HandleRef pThis);

	/// <summary>
	/// Get the flag indicating the data has been released.
	/// </summary>
	public virtual int GetDataReleased()
	{
		return vtkDataObject_GetDataReleased_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObject_GetExtentType_39(HandleRef pThis);

	/// <summary>
	/// The ExtentType will be left as VTK_PIECES_EXTENT for data objects
	/// such as vtkPolyData and vtkUnstructuredGrid. The ExtentType will be
	/// changed to VTK_3D_EXTENT for data objects with 3D structure such as
	/// vtkImageData (and its subclass vtkStructuredPoints), vtkRectilinearGrid,
	/// and vtkStructuredGrid. The default is the have an extent in pieces,
	/// with only one piece (no streaming possible).
	/// </summary>
	public virtual int GetExtentType()
	{
		return vtkDataObject_GetExtentType_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_GetFieldData_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Assign or retrieve a general field data to this data object.
	/// </summary>
	public virtual vtkFieldData GetFieldData()
	{
		vtkFieldData vtkFieldData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_GetFieldData_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFieldData2 = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFieldData2.Register(null);
			}
		}
		return vtkFieldData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_GetGhostArray_41(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ghost arrays of the data object of the specified
	/// attribute type. The type may be:
	/// &lt;ul&gt;
	/// &lt;li&gt;POINT    - Defined in vtkDataSet subclasses
	/// &lt;li&gt;CELL   - Defined in vtkDataSet subclasses.
	/// &lt;/ul&gt;
	/// The other attribute types, will return nullptr since
	/// ghosts arrays are not defined for now outside of
	/// point or cell.
	/// </summary>
	public virtual vtkUnsignedCharArray GetGhostArray(int type)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_GetGhostArray_41(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObject_GetGlobalReleaseDataFlag_42();

	/// <summary>
	/// Turn on/off flag to control whether every object releases its data
	/// after being used by a filter.
	/// </summary>
	public static int GetGlobalReleaseDataFlag()
	{
		return vtkDataObject_GetGlobalReleaseDataFlag_42();
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_GetInformation_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the information object associated with this data object.
	/// </summary>
	public virtual vtkInformation GetInformation()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_GetInformation_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkDataObject_GetMTime_44(HandleRef pThis);

	/// <summary>
	/// Data objects are composite objects and need to check each part for MTime.
	/// The information object also needs to be considered.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDataObject_GetMTime_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_GetNamedFieldInformation_45(HandleRef info, int fieldAssociation, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the information object within the input information object's
	/// field data corresponding to the specified association
	/// (FIELD_ASSOCIATION_POINTS or FIELD_ASSOCIATION_CELLS) and name.
	/// </summary>
	public static vtkInformation GetNamedFieldInformation(vtkInformation info, int fieldAssociation, string name)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_GetNamedFieldInformation_45(info?.GetCppThis() ?? default(HandleRef), fieldAssociation, name, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDataObject_GetNumberOfElements_46(HandleRef pThis, int type);

	/// <summary>
	/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
	/// </summary>
	public virtual long GetNumberOfElements(int type)
	{
		return vtkDataObject_GetNumberOfElements_46(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObject_GetNumberOfGenerationsFromBase_47(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataObject_GetNumberOfGenerationsFromBase_47(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObject_GetNumberOfGenerationsFromBaseType_48(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataObject_GetNumberOfGenerationsFromBaseType_48(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDataObject_GetUpdateTime_49(HandleRef pThis);

	/// <summary>
	/// Used by Threaded ports to determine if they should initiate an
	/// asynchronous update (still in development).
	/// </summary>
	public ulong GetUpdateTime()
	{
		return vtkDataObject_GetUpdateTime_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_GlobalReleaseDataFlagOff_50(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether every object releases its data
	/// after being used by a filter.
	/// </summary>
	public void GlobalReleaseDataFlagOff()
	{
		vtkDataObject_GlobalReleaseDataFlagOff_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_GlobalReleaseDataFlagOn_51(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether every object releases its data
	/// after being used by a filter.
	/// </summary>
	public void GlobalReleaseDataFlagOn()
	{
		vtkDataObject_GlobalReleaseDataFlagOn_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_Initialize_52(HandleRef pThis);

	/// <summary>
	/// Restore data object to initial state,
	/// </summary>
	public virtual void Initialize()
	{
		vtkDataObject_Initialize_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObject_IsA_53(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataObject_IsA_53(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObject_IsTypeOf_54(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataObject_IsTypeOf_54(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_NewInstance_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataObject NewInstance()
	{
		vtkDataObject result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_NewInstance_56(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_ORIGIN_57(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationDoubleVectorKey ORIGIN()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_ORIGIN_57(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_PIECE_EXTENT_58(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationIntegerVectorKey PIECE_EXTENT()
	{
		vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_PIECE_EXTENT_58(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerVectorKey2 = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerVectorKey2.Register(null);
			}
		}
		return vtkInformationIntegerVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_POINT_DATA_VECTOR_59(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationInformationVectorKey POINT_DATA_VECTOR()
	{
		vtkInformationInformationVectorKey vtkInformationInformationVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_POINT_DATA_VECTOR_59(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationInformationVectorKey2 = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationInformationVectorKey2.Register(null);
			}
		}
		return vtkInformationInformationVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_PrepareForNewData_60(HandleRef pThis);

	/// <summary>
	/// make the output data ready for new data to be inserted. For most
	/// objects we just call Initialize. But for vtkImageData we leave the old
	/// data in case the memory can be reused.
	/// </summary>
	public virtual void PrepareForNewData()
	{
		vtkDataObject_PrepareForNewData_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_ReleaseData_61(HandleRef pThis);

	/// <summary>
	/// Release data back to system to conserve memory resource. Used during
	/// visualization network execution.  Releasing this data does not make
	/// down-stream data invalid.
	/// </summary>
	public void ReleaseData()
	{
		vtkDataObject_ReleaseData_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_RemoveNamedFieldInformation_62(HandleRef info, int fieldAssociation, string name);

	/// <summary>
	/// Remove the info associated with an array
	/// </summary>
	public static void RemoveNamedFieldInformation(vtkInformation info, int fieldAssociation, string name)
	{
		vtkDataObject_RemoveNamedFieldInformation_62(info?.GetCppThis() ?? default(HandleRef), fieldAssociation, name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_SIL_63(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationDataObjectKey SIL()
	{
		vtkInformationDataObjectKey vtkInformationDataObjectKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_SIL_63(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDataObjectKey2 = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDataObjectKey2.Register(null);
			}
		}
		return vtkInformationDataObjectKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_SPACING_64(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationDoubleVectorKey SPACING()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_SPACING_64(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_SafeDownCast_65(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObject SafeDownCast(vtkObjectBase o)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_SafeDownCast_65(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_SetActiveAttribute_66(HandleRef info, int fieldAssociation, string attributeName, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the named array to be the active field for the specified type
	/// (SCALARS, VECTORS, NORMALS, TCOORDS, or TENSORS) and association
	/// (FIELD_ASSOCIATION_POINTS or FIELD_ASSOCIATION_CELLS).  Returns the
	/// active field information object and creates on entry if one not found.
	/// </summary>
	public static vtkInformation SetActiveAttribute(vtkInformation info, int fieldAssociation, string attributeName, int attributeType)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_SetActiveAttribute_66(info?.GetCppThis() ?? default(HandleRef), fieldAssociation, attributeName, attributeType, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataObject_SetActiveAttributeInfo_67(HandleRef info, int fieldAssociation, int attributeType, string name, int arrayType, int numComponents, int numTuples);

	/// <summary>
	/// Set the name, array type, number of components, and number of tuples
	/// within the passed information object for the active attribute of type
	/// attributeType (in specified association, FIELD_ASSOCIATION_POINTS or
	/// FIELD_ASSOCIATION_CELLS).  If there is not an active attribute of the
	/// specified type, an entry in the information object is created.  If
	/// arrayType, numComponents, or numTuples equal to -1, or name=nullptr the
	/// value is not changed.
	/// </summary>
	public static void SetActiveAttributeInfo(vtkInformation info, int fieldAssociation, int attributeType, string name, int arrayType, int numComponents, int numTuples)
	{
		vtkDataObject_SetActiveAttributeInfo_67(info?.GetCppThis() ?? default(HandleRef), fieldAssociation, attributeType, name, arrayType, numComponents, numTuples);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_SetFieldData_68(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Assign or retrieve a general field data to this data object.
	/// </summary>
	public virtual void SetFieldData(vtkFieldData arg0)
	{
		vtkDataObject_SetFieldData_68(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_SetGlobalReleaseDataFlag_69(int val);

	/// <summary>
	/// Turn on/off flag to control whether every object releases its data
	/// after being used by a filter.
	/// </summary>
	public static void SetGlobalReleaseDataFlag(int val)
	{
		vtkDataObject_SetGlobalReleaseDataFlag_69(val);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_SetInformation_70(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the information object associated with this data object.
	/// </summary>
	public virtual void SetInformation(vtkInformation arg0)
	{
		vtkDataObject_SetInformation_70(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_SetPointDataActiveScalarInfo_71(HandleRef info, int arrayType, int numComponents);

	/// <summary>
	/// Convenience version of previous method for use (primarily) by the Imaging
	/// filters. If arrayType or numComponents == -1, the value is not changed.
	/// </summary>
	public static void SetPointDataActiveScalarInfo(vtkInformation info, int arrayType, int numComponents)
	{
		vtkDataObject_SetPointDataActiveScalarInfo_71(info?.GetCppThis() ?? default(HandleRef), arrayType, numComponents);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObject_ShallowCopy_72(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.  These copy the data, but not any of the
	/// pipeline connections.
	/// </summary>
	public virtual void ShallowCopy(vtkDataObject src)
	{
		vtkDataObject_ShallowCopy_72(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObject_VERTEX_DATA_VECTOR_73(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a string association name, this static method returns an integer association type
	/// for the attribute (i.e. associationName = "Points": returns 0).
	/// </summary>
	public static vtkInformationInformationVectorKey VERTEX_DATA_VECTOR()
	{
		vtkInformationInformationVectorKey vtkInformationInformationVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObject_VERTEX_DATA_VECTOR_73(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationInformationVectorKey2 = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationInformationVectorKey2.Register(null);
			}
		}
		return vtkInformationInformationVectorKey2;
	}
}
