using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataSetAttributes
/// </summary>
/// <remarks>
///    represent and manipulate attribute data in a dataset
///
/// vtkDataSetAttributes is a class that is used to represent and manipulate
/// attribute data (e.g., scalars, vectors, normals, texture coordinates,
/// tensors, global ids, pedigree ids, and field data).
///
/// This adds to vtkFieldData the ability to pick one of the arrays from the
/// field as the currently active array for each attribute type. In other
/// words, you pick one array to be called "THE" Scalars, and then filters down
/// the pipeline will treat that array specially. For example vtkContourFilter
/// will contour "THE" Scalar array unless a different array is asked for.
///
/// Additionally vtkDataSetAttributes provides methods that filters call to
/// pass data through, copy data into, and interpolate from Fields. PassData
/// passes entire arrays from the source to the destination. Copy passes
/// through some subset of the tuples from the source to the destination.
/// Interpolate interpolates from the chosen tuple(s) in the source data, using
/// the provided weights, to produce new tuples in the destination.
/// Each attribute type has pass, copy and interpolate "copy" flags that
/// can be set in the destination to choose which attribute arrays will be
/// transferred from the source to the destination.
///
/// Finally this class provides a mechanism to determine which attributes a
/// group of sources have in common, and to copy tuples from a source into
/// the destination, for only those attributes that are held by all.
///
/// @warning
/// vtkDataSetAttributes is not in general thread safe due to the use of its
/// vtkFieldData::BasicIterator RequiredArrays data member. The class
/// vtkArrayListTemplate augments vtkDataSetAttributes for thread safety.
///
/// </remarks>
/// <seealso>
///  vtkArrayListTemplate
/// </seealso>
public class vtkDataSetAttributes : vtkFieldData
{
	/// <summary>
	/// Given an integer attribute type, this static method returns a string type
	/// for the attribute (i.e. type = 0: returns "Scalars").
	/// </summary>
	public enum AttributeCopyOperations
	{
		/// <summary>enum member</summary>
		ALLCOPY = 3,
		/// <summary>enum member</summary>
		COPYTUPLE = 0,
		/// <summary>enum member</summary>
		INTERPOLATE = 1,
		/// <summary>enum member</summary>
		PASSDATA = 2
	}

	/// <summary>
	/// Shallow copy of data (i.e., use reference counting).
	/// Ignores the copy flags but preserves them in the output.
	/// </summary>
	public enum AttributeLimitTypes
	{
		/// <summary>enum member</summary>
		EXACT = 1,
		/// <summary>enum member</summary>
		MAX = 0,
		/// <summary>enum member</summary>
		NOLIMIT = 2
	}

	/// <summary>
	/// Shallow copy of data (i.e., use reference counting).
	/// Ignores the copy flags but preserves them in the output.
	/// </summary>
	public enum AttributeTypes
	{
		/// <summary>enum member</summary>
		EDGEFLAG = 7,
		/// <summary>enum member</summary>
		GLOBALIDS = 5,
		/// <summary>enum member</summary>
		HIGHERORDERDEGREES = 10,
		/// <summary>enum member</summary>
		NORMALS = 2,
		/// <summary>enum member</summary>
		NUM_ATTRIBUTES = 11,
		/// <summary>enum member</summary>
		PEDIGREEIDS = 6,
		/// <summary>enum member</summary>
		RATIONALWEIGHTS = 9,
		/// <summary>enum member</summary>
		SCALARS = 0,
		/// <summary>enum member</summary>
		TANGENTS = 8,
		/// <summary>enum member</summary>
		TCOORDS = 3,
		/// <summary>enum member</summary>
		TENSORS = 4,
		/// <summary>enum member</summary>
		VECTORS = 1
	}

	/// <summary>
	/// Shallow copy of data (i.e., use reference counting).
	/// Ignores the copy flags but preserves them in the output.
	/// </summary>
	public enum CellGhostTypes
	{
		/// <summary>enum member</summary>
		DUPLICATECELL = 1,
		/// <summary>enum member</summary>
		EXTERIORCELL = 16,
		/// <summary>enum member</summary>
		HIDDENCELL = 32,
		/// <summary>enum member</summary>
		HIGHCONNECTIVITYCELL = 2,
		/// <summary>enum member</summary>
		LOWCONNECTIVITYCELL = 4,
		/// <summary>enum member</summary>
		REFINEDCELL = 8
	}

	/// <summary>
	/// Shallow copy of data (i.e., use reference counting).
	/// Ignores the copy flags but preserves them in the output.
	/// </summary>
	public enum PointGhostTypes
	{
		/// <summary>enum member</summary>
		DUPLICATEPOINT = 1,
		/// <summary>enum member</summary>
		HIDDENPOINT
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetAttributes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataSetAttributes()
	{
		MRClassNameKey = "class vtkDataSetAttributes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetAttributes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataSetAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with copying turned on for all data.
	/// </summary>
	public new static vtkDataSetAttributes New()
	{
		vtkDataSetAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with copying turned on for all data.
	/// </summary>
	public vtkDataSetAttributes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataSetAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataSetAttributes_CopyAllOff_01(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public override void CopyAllOff(int ctype)
	{
		vtkDataSetAttributes_CopyAllOff_01(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyAllOn_02(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public override void CopyAllOn(int ctype)
	{
		vtkDataSetAttributes_CopyAllOn_02(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyAllocate_03(HandleRef pThis, HandleRef pd, long sze, long ext);

	/// <summary>
	/// Allocates point data for point-by-point (or cell-by-cell) copy operation.
	/// If sze=0, then use the input DataSetAttributes to create (i.e., find
	/// initial size of) new objects; otherwise use the sze variable.
	/// Note that pd HAS to be the vtkDataSetAttributes object which
	/// will later be used with CopyData. If this is not the case,
	/// consider using the alternative forms of CopyAllocate and CopyData.
	/// ext is no longer used.
	/// If shallowCopyArrays is true, input arrays are copied to the output
	/// instead of new ones being allocated.
	/// </summary>
	public void CopyAllocate(vtkDataSetAttributes pd, long sze, long ext)
	{
		vtkDataSetAttributes_CopyAllocate_03(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef), sze, ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyAllocate_04(HandleRef pThis, HandleRef pd, long sze, long ext, int shallowCopyArrays);

	/// <summary>
	/// Allocates point data for point-by-point (or cell-by-cell) copy operation.
	/// If sze=0, then use the input DataSetAttributes to create (i.e., find
	/// initial size of) new objects; otherwise use the sze variable.
	/// Note that pd HAS to be the vtkDataSetAttributes object which
	/// will later be used with CopyData. If this is not the case,
	/// consider using the alternative forms of CopyAllocate and CopyData.
	/// ext is no longer used.
	/// If shallowCopyArrays is true, input arrays are copied to the output
	/// instead of new ones being allocated.
	/// </summary>
	public void CopyAllocate(vtkDataSetAttributes pd, long sze, long ext, int shallowCopyArrays)
	{
		vtkDataSetAttributes_CopyAllocate_04(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef), sze, ext, shallowCopyArrays);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyAllocate_05(HandleRef pThis, vtkDataSetAttributesFieldList list, long sze, long ext);

	/// <summary>
	/// A special form of CopyAllocate() to be used with FieldLists. Use it
	/// when you are copying data from a set of vtkDataSetAttributes.
	/// </summary>
	public void CopyAllocate(vtkDataSetAttributesFieldList list, long sze, long ext)
	{
		vtkDataSetAttributes_CopyAllocate_05(GetCppThis(), list, sze, ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyData_06(HandleRef pThis, HandleRef fromPd, long fromId, long toId);

	/// <summary>
	/// Copy the attribute data from one id to another. Make sure CopyAllocate()
	/// has been invoked before using this method. When copying a field,
	/// the following copying rules are
	/// followed: 1) Check if a field is an attribute, if yes and if there
	/// is a COPYTUPLE copy flag for that attribute (on or off), obey the flag
	/// for that attribute, ignore (2) and (3), 2) if there is a copy field for
	/// that field (on or off), obey the flag, ignore (3) 3) obey
	/// CopyAllOn/Off
	///
	/// @warning This method is prone to compile-time ambiguity when called using `0` parameters.
	/// To fix the ambiguity, please replace `0` by `vtkIdType(0)`.
	/// </summary>
	public void CopyData(vtkDataSetAttributes fromPd, long fromId, long toId)
	{
		vtkDataSetAttributes_CopyData_06(GetCppThis(), fromPd?.GetCppThis() ?? default(HandleRef), fromId, toId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyData_07(HandleRef pThis, HandleRef fromPd, HandleRef fromIds, HandleRef toIds);

	/// <summary>
	/// Copy the attribute data from one id to another. Make sure CopyAllocate()
	/// has been invoked before using this method. When copying a field,
	/// the following copying rules are
	/// followed: 1) Check if a field is an attribute, if yes and if there
	/// is a COPYTUPLE copy flag for that attribute (on or off), obey the flag
	/// for that attribute, ignore (2) and (3), 2) if there is a copy field for
	/// that field (on or off), obey the flag, ignore (3) 3) obey
	/// CopyAllOn/Off
	///
	/// @warning This method is prone to compile-time ambiguity when called using `0` parameters.
	/// To fix the ambiguity, please replace `0` by `vtkIdType(0)`.
	/// </summary>
	public void CopyData(vtkDataSetAttributes fromPd, vtkIdList fromIds, vtkIdList toIds)
	{
		vtkDataSetAttributes_CopyData_07(GetCppThis(), fromPd?.GetCppThis() ?? default(HandleRef), fromIds?.GetCppThis() ?? default(HandleRef), toIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyData_08(HandleRef pThis, HandleRef fromPd, HandleRef fromIds, long destStartId);

	/// <summary>
	/// Copy the attribute data from one id to another. Make sure CopyAllocate()
	/// has been invoked before using this method. When copying a field,
	/// the following copying rules are
	/// followed: 1) Check if a field is an attribute, if yes and if there
	/// is a COPYTUPLE copy flag for that attribute (on or off), obey the flag
	/// for that attribute, ignore (2) and (3), 2) if there is a copy field for
	/// that field (on or off), obey the flag, ignore (3) 3) obey
	/// CopyAllOn/Off
	///
	/// @warning This method is prone to compile-time ambiguity when called using `0` parameters.
	/// To fix the ambiguity, please replace `0` by `vtkIdType(0)`.
	/// </summary>
	public void CopyData(vtkDataSetAttributes fromPd, vtkIdList fromIds, long destStartId)
	{
		vtkDataSetAttributes_CopyData_08(GetCppThis(), fromPd?.GetCppThis() ?? default(HandleRef), fromIds?.GetCppThis() ?? default(HandleRef), destStartId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyData_09(HandleRef pThis, HandleRef fromPd, long dstStart, long n, long srcStart);

	/// <summary>
	/// Copy n consecutive attributes starting at srcStart from fromPd to this
	/// container, starting at the dstStart location.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public void CopyData(vtkDataSetAttributes fromPd, long dstStart, long n, long srcStart)
	{
		vtkDataSetAttributes_CopyData_09(GetCppThis(), fromPd?.GetCppThis() ?? default(HandleRef), dstStart, n, srcStart);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyData_10(HandleRef pThis, vtkDataSetAttributesFieldList list, HandleRef dsa, int idx, long fromId, long toId);

	/// <summary>
	/// Special forms of CopyData() to be used with FieldLists. Use it when
	/// you are copying data from a set of vtkDataSetAttributes. Make sure
	/// that you have called the special form of CopyAllocate that accepts
	/// FieldLists.
	/// </summary>
	public void CopyData(vtkDataSetAttributesFieldList list, vtkDataSetAttributes dsa, int idx, long fromId, long toId)
	{
		vtkDataSetAttributes_CopyData_10(GetCppThis(), list, dsa?.GetCppThis() ?? default(HandleRef), idx, fromId, toId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyData_11(HandleRef pThis, vtkDataSetAttributesFieldList list, HandleRef dsa, int idx, long dstStart, long n, long srcStart);

	/// <summary>
	/// Special forms of CopyData() to be used with FieldLists. Use it when
	/// you are copying data from a set of vtkDataSetAttributes. Make sure
	/// that you have called the special form of CopyAllocate that accepts
	/// FieldLists.
	/// </summary>
	public void CopyData(vtkDataSetAttributesFieldList list, vtkDataSetAttributes dsa, int idx, long dstStart, long n, long srcStart)
	{
		vtkDataSetAttributes_CopyData_11(GetCppThis(), list, dsa?.GetCppThis() ?? default(HandleRef), idx, dstStart, n, srcStart);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyGlobalIdsOff_12(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyGlobalIdsOff()
	{
		vtkDataSetAttributes_CopyGlobalIdsOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyGlobalIdsOn_13(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyGlobalIdsOn()
	{
		vtkDataSetAttributes_CopyGlobalIdsOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyHigherOrderDegreesOff_14(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyHigherOrderDegreesOff()
	{
		vtkDataSetAttributes_CopyHigherOrderDegreesOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyHigherOrderDegreesOn_15(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyHigherOrderDegreesOn()
	{
		vtkDataSetAttributes_CopyHigherOrderDegreesOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyNormalsOff_16(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyNormalsOff()
	{
		vtkDataSetAttributes_CopyNormalsOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyNormalsOn_17(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyNormalsOn()
	{
		vtkDataSetAttributes_CopyNormalsOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyPedigreeIdsOff_18(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyPedigreeIdsOff()
	{
		vtkDataSetAttributes_CopyPedigreeIdsOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyPedigreeIdsOn_19(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyPedigreeIdsOn()
	{
		vtkDataSetAttributes_CopyPedigreeIdsOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyRationalWeightsOff_20(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyRationalWeightsOff()
	{
		vtkDataSetAttributes_CopyRationalWeightsOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyRationalWeightsOn_21(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyRationalWeightsOn()
	{
		vtkDataSetAttributes_CopyRationalWeightsOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyScalarsOff_22(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyScalarsOff()
	{
		vtkDataSetAttributes_CopyScalarsOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyScalarsOn_23(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyScalarsOn()
	{
		vtkDataSetAttributes_CopyScalarsOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyStructuredData_24(HandleRef pThis, HandleRef inDsa, IntPtr inExt, IntPtr outExt, byte setSize);

	/// <summary>
	/// This method is used to copy data arrays in images.
	/// You should call CopyAllocate or SetupForCopy before
	/// calling this method. If setSize is true, this method
	/// will set the size of the output arrays according to
	/// the output extent. This is required when CopyAllocate()
	/// was used to setup output arrays.
	/// </summary>
	public void CopyStructuredData(vtkDataSetAttributes inDsa, IntPtr inExt, IntPtr outExt, bool setSize)
	{
		vtkDataSetAttributes_CopyStructuredData_24(GetCppThis(), inDsa?.GetCppThis() ?? default(HandleRef), inExt, outExt, (byte)(setSize ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyTCoordsOff_25(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyTCoordsOff()
	{
		vtkDataSetAttributes_CopyTCoordsOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyTCoordsOn_26(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyTCoordsOn()
	{
		vtkDataSetAttributes_CopyTCoordsOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyTangentsOff_27(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyTangentsOff()
	{
		vtkDataSetAttributes_CopyTangentsOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyTangentsOn_28(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyTangentsOn()
	{
		vtkDataSetAttributes_CopyTangentsOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyTensorsOff_29(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyTensorsOff()
	{
		vtkDataSetAttributes_CopyTensorsOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyTensorsOn_30(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyTensorsOn()
	{
		vtkDataSetAttributes_CopyTensorsOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyTuple_31(HandleRef pThis, HandleRef fromData, HandleRef toData, long fromId, long toId);

	/// <summary>
	/// Copy a tuple (or set of tuples) of data from one data array to another.
	/// This method assumes that the fromData and toData objects are of the
	/// same type, and have the same number of components. This is true if you
	/// invoke CopyAllocate() or InterpolateAllocate().
	/// </summary>
	public void CopyTuple(vtkAbstractArray fromData, vtkAbstractArray toData, long fromId, long toId)
	{
		vtkDataSetAttributes_CopyTuple_31(GetCppThis(), fromData?.GetCppThis() ?? default(HandleRef), toData?.GetCppThis() ?? default(HandleRef), fromId, toId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyTuples_32(HandleRef pThis, HandleRef fromData, HandleRef toData, HandleRef fromIds, HandleRef toIds);

	/// <summary>
	/// Copy a tuple (or set of tuples) of data from one data array to another.
	/// This method assumes that the fromData and toData objects are of the
	/// same type, and have the same number of components. This is true if you
	/// invoke CopyAllocate() or InterpolateAllocate().
	/// </summary>
	public void CopyTuples(vtkAbstractArray fromData, vtkAbstractArray toData, vtkIdList fromIds, vtkIdList toIds)
	{
		vtkDataSetAttributes_CopyTuples_32(GetCppThis(), fromData?.GetCppThis() ?? default(HandleRef), toData?.GetCppThis() ?? default(HandleRef), fromIds?.GetCppThis() ?? default(HandleRef), toIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyTuples_33(HandleRef pThis, HandleRef fromData, HandleRef toData, long dstStart, long n, long srcStart);

	/// <summary>
	/// Copy a tuple (or set of tuples) of data from one data array to another.
	/// This method assumes that the fromData and toData objects are of the
	/// same type, and have the same number of components. This is true if you
	/// invoke CopyAllocate() or InterpolateAllocate().
	/// </summary>
	public void CopyTuples(vtkAbstractArray fromData, vtkAbstractArray toData, long dstStart, long n, long srcStart)
	{
		vtkDataSetAttributes_CopyTuples_33(GetCppThis(), fromData?.GetCppThis() ?? default(HandleRef), toData?.GetCppThis() ?? default(HandleRef), dstStart, n, srcStart);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyVectorsOff_34(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyVectorsOff()
	{
		vtkDataSetAttributes_CopyVectorsOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_CopyVectorsOn_35(HandleRef pThis);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public virtual void CopyVectorsOn()
	{
		vtkDataSetAttributes_CopyVectorsOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_DeepCopy_36(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Deep copy of data (i.e., create new data arrays and
	/// copy from input data).
	/// Ignores the copy flags but preserves them in the output.
	/// </summary>
	public override void DeepCopy(vtkFieldData pd)
	{
		vtkDataSetAttributes_DeepCopy_36(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_ExtendedNew_37(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with copying turned on for all data.
	/// </summary>
	public new static vtkDataSetAttributes ExtendedNew()
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_ExtendedNew_37(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataSetAttributes_GetAbstractAttribute_38(HandleRef pThis, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an attribute given the attribute type
	/// (see vtkDataSetAttributes::AttributeTypes).
	/// This is the same as GetAttribute(), except that the returned array
	/// is a vtkAbstractArray instead of vtkDataArray.
	/// Some attributes (such as PEDIGREEIDS) may not be vtkDataArray subclass.
	/// </summary>
	public vtkAbstractArray GetAbstractAttribute(int attributeType)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetAbstractAttribute_38(GetCppThis(), attributeType, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataSetAttributes_GetAttribute_39(HandleRef pThis, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an attribute given the attribute type
	/// (see vtkDataSetAttributes::AttributeTypes).
	/// Some attributes (such as PEDIGREEIDS) may not be vtkDataArray subclass,
	/// so in that case use GetAbstractAttribute().
	/// </summary>
	public vtkDataArray GetAttribute(int attributeType)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetAttribute_39(GetCppThis(), attributeType, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_GetAttributeIndices_40(HandleRef pThis, IntPtr indexArray);

	/// <summary>
	/// Get the field data array indices corresponding to scalars,
	/// vectors, tensors, etc.  The given buffer must be at least
	/// NUM_ATTRIBUTES elements big.
	/// </summary>
	public void GetAttributeIndices(IntPtr indexArray)
	{
		vtkDataSetAttributes_GetAttributeIndices_40(GetCppThis(), indexArray);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetAttributeTypeAsString_41(int attributeType);

	/// <summary>
	/// Given an integer attribute type, this static method returns a string type
	/// for the attribute (i.e. type = 0: returns "Scalars").
	/// </summary>
	public static string GetAttributeTypeAsString(int attributeType)
	{
		return Marshal.PtrToStringAnsi(vtkDataSetAttributes_GetAttributeTypeAsString_41(attributeType));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyAttribute_42(HandleRef pThis, int index, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyAttribute(int index, int ctype)
	{
		return vtkDataSetAttributes_GetCopyAttribute_42(GetCppThis(), index, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyGlobalIds_43(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyGlobalIds(int ctype)
	{
		return vtkDataSetAttributes_GetCopyGlobalIds_43(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyHigherOrderDegrees_44(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyHigherOrderDegrees(int ctype)
	{
		return vtkDataSetAttributes_GetCopyHigherOrderDegrees_44(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyNormals_45(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyNormals(int ctype)
	{
		return vtkDataSetAttributes_GetCopyNormals_45(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyPedigreeIds_46(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyPedigreeIds(int ctype)
	{
		return vtkDataSetAttributes_GetCopyPedigreeIds_46(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyRationalWeights_47(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyRationalWeights(int ctype)
	{
		return vtkDataSetAttributes_GetCopyRationalWeights_47(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyScalars_48(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyScalars(int ctype)
	{
		return vtkDataSetAttributes_GetCopyScalars_48(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyTCoords_49(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyTCoords(int ctype)
	{
		return vtkDataSetAttributes_GetCopyTCoords_49(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyTangents_50(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyTangents(int ctype)
	{
		return vtkDataSetAttributes_GetCopyTangents_50(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyTensors_51(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyTensors(int ctype)
	{
		return vtkDataSetAttributes_GetCopyTensors_51(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_GetCopyVectors_52(HandleRef pThis, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public int GetCopyVectors(int ctype)
	{
		return vtkDataSetAttributes_GetCopyVectors_52(GetCppThis(), ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetGlobalIds_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the global id data.
	/// </summary>
	public vtkDataArray GetGlobalIds()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetGlobalIds_53(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetGlobalIds_54(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkDataArray GetGlobalIds(string name)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetGlobalIds_54(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetHigherOrderDegrees_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the rational degrees data.
	/// </summary>
	public vtkDataArray GetHigherOrderDegrees()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetHigherOrderDegrees_55(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetHigherOrderDegrees_56(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkDataArray GetHigherOrderDegrees(string name)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetHigherOrderDegrees_56(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetLongAttributeTypeAsString_57(int attributeType);

	/// <summary>
	/// Given an integer attribute type, this static method returns a string type
	/// for the attribute (i.e. type = 0: returns "Scalars").
	/// </summary>
	public static string GetLongAttributeTypeAsString(int attributeType)
	{
		return Marshal.PtrToStringAnsi(vtkDataSetAttributes_GetLongAttributeTypeAsString_57(attributeType));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetNormals_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the normal data.
	/// </summary>
	public vtkDataArray GetNormals()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetNormals_58(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetNormals_59(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkDataArray GetNormals(string name)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetNormals_59(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetAttributes_GetNumberOfGenerationsFromBase_60(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with copying turned on for all data.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataSetAttributes_GetNumberOfGenerationsFromBase_60(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetAttributes_GetNumberOfGenerationsFromBaseType_61(string type);

	/// <summary>
	/// Construct object with copying turned on for all data.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataSetAttributes_GetNumberOfGenerationsFromBaseType_61(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetPedigreeIds_62(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the pedigree id data.
	/// </summary>
	public vtkAbstractArray GetPedigreeIds()
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetPedigreeIds_62(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataSetAttributes_GetPedigreeIds_63(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkAbstractArray GetPedigreeIds(string name)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetPedigreeIds_63(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataSetAttributes_GetRationalWeights_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the rational weights data.
	/// </summary>
	public vtkDataArray GetRationalWeights()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetRationalWeights_64(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetRationalWeights_65(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkDataArray GetRationalWeights(string name)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetRationalWeights_65(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetScalars_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the scalar data.
	/// </summary>
	public vtkDataArray GetScalars()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetScalars_66(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetScalars_67(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkDataArray GetScalars(string name)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetScalars_67(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetTCoords_68(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the texture coordinate data.
	/// </summary>
	public vtkDataArray GetTCoords()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetTCoords_68(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetTCoords_69(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkDataArray GetTCoords(string name)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetTCoords_69(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetTangents_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the tangent data.
	/// </summary>
	public vtkDataArray GetTangents()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetTangents_70(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetTangents_71(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkDataArray GetTangents(string name)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetTangents_71(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetTensors_72(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tensor data.
	/// </summary>
	public vtkDataArray GetTensors()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetTensors_72(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetTensors_73(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkDataArray GetTensors(string name)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetTensors_73(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetVectors_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the vector data.
	/// </summary>
	public vtkDataArray GetVectors()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetVectors_74(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GetVectors_75(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the string is nullptr or empty, calls the alternate method
	/// of the same name (that takes no parameters).
	/// Otherwise, it will look for an array with the correct name.
	/// If one exists, it is returned. Otherwise, nullptr is returned.
	/// </summary>
	public vtkDataArray GetVectors(string name)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_GetVectors_75(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_GhostArrayName_76();

	/// <summary>
	/// Shallow copy of data (i.e., use reference counting).
	/// Ignores the copy flags but preserves them in the output.
	/// </summary>
	public static string GhostArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDataSetAttributes_GhostArrayName_76());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_Initialize_77(HandleRef pThis);

	/// <summary>
	/// Initialize all of the object's data to nullptr
	/// Also, clear the copy flags.
	/// </summary>
	public override void Initialize()
	{
		vtkDataSetAttributes_Initialize_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_InterpolateAllocate_78(HandleRef pThis, HandleRef pd, long sze, long ext);

	/// <summary>
	/// Initialize point interpolation method.
	/// Note that pd HAS to be the vtkDataSetAttributes object which
	/// will later be used with InterpolatePoint or InterpolateEdge.
	/// ext is no longer used.
	/// If shallowCopyArrays is true, input arrays are copied to the output
	/// instead of new ones being allocated.
	/// </summary>
	public void InterpolateAllocate(vtkDataSetAttributes pd, long sze, long ext)
	{
		vtkDataSetAttributes_InterpolateAllocate_78(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef), sze, ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_InterpolateAllocate_79(HandleRef pThis, HandleRef pd, long sze, long ext, int shallowCopyArrays);

	/// <summary>
	/// Initialize point interpolation method.
	/// Note that pd HAS to be the vtkDataSetAttributes object which
	/// will later be used with InterpolatePoint or InterpolateEdge.
	/// ext is no longer used.
	/// If shallowCopyArrays is true, input arrays are copied to the output
	/// instead of new ones being allocated.
	/// </summary>
	public void InterpolateAllocate(vtkDataSetAttributes pd, long sze, long ext, int shallowCopyArrays)
	{
		vtkDataSetAttributes_InterpolateAllocate_79(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef), sze, ext, shallowCopyArrays);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_InterpolateAllocate_80(HandleRef pThis, vtkDataSetAttributesFieldList list, long sze, long ext);

	/// <summary>
	/// A special form of InterpolateAllocate() to be used with FieldLists. Use it
	/// when you are interpolating data from a set of vtkDataSetAttributes.
	/// \c Warning: This does not copy the Information object associated with
	/// each data array. This behavior may change in the future.
	/// </summary>
	public void InterpolateAllocate(vtkDataSetAttributesFieldList list, long sze, long ext)
	{
		vtkDataSetAttributes_InterpolateAllocate_80(GetCppThis(), list, sze, ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_InterpolateEdge_81(HandleRef pThis, HandleRef fromPd, long toId, long p1, long p2, double t);

	/// <summary>
	/// Interpolate data from the two points p1,p2 (forming an edge) and an
	/// interpolation factor, t, along the edge. The weight ranges from (0,1),
	/// with t=0 located at p1. Make sure that the method InterpolateAllocate()
	/// has been invoked before using this method.
	/// If the INTERPOLATION copy flag is set to 0 for an array, interpolation
	/// is prevented. If the flag is set to 1, weighted interpolation occurs.
	/// If the flag is set to 2, nearest neighbor interpolation is used.
	/// </summary>
	public void InterpolateEdge(vtkDataSetAttributes fromPd, long toId, long p1, long p2, double t)
	{
		vtkDataSetAttributes_InterpolateEdge_81(GetCppThis(), fromPd?.GetCppThis() ?? default(HandleRef), toId, p1, p2, t);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_InterpolatePoint_82(HandleRef pThis, HandleRef fromPd, long toId, HandleRef ids, IntPtr weights);

	/// <summary>
	/// Interpolate data set attributes from other data set attributes
	/// given cell or point ids and associated interpolation weights.
	/// If the INTERPOLATION copy flag is set to 0 for an array, interpolation
	/// is prevented. If the flag is set to 1, weighted interpolation occurs.
	/// If the flag is set to 2, nearest neighbor interpolation is used.
	/// </summary>
	public void InterpolatePoint(vtkDataSetAttributes fromPd, long toId, vtkIdList ids, IntPtr weights)
	{
		vtkDataSetAttributes_InterpolatePoint_82(GetCppThis(), fromPd?.GetCppThis() ?? default(HandleRef), toId, ids?.GetCppThis() ?? default(HandleRef), weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_InterpolatePoint_83(HandleRef pThis, vtkDataSetAttributesFieldList list, HandleRef fromPd, int idx, long toId, HandleRef ids, IntPtr weights);

	/// <summary>
	/// Interpolate data set attributes from other data set attributes
	/// given cell or point ids and associated interpolation weights.
	/// Make sure that special form of InterpolateAllocate() that accepts
	/// FieldList has been used.
	/// </summary>
	public void InterpolatePoint(vtkDataSetAttributesFieldList list, vtkDataSetAttributes fromPd, int idx, long toId, vtkIdList ids, IntPtr weights)
	{
		vtkDataSetAttributes_InterpolatePoint_83(GetCppThis(), list, fromPd?.GetCppThis() ?? default(HandleRef), idx, toId, ids?.GetCppThis() ?? default(HandleRef), weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_InterpolateTime_84(HandleRef pThis, HandleRef from1, HandleRef from2, long id, double t);

	/// <summary>
	/// Interpolate data from the same id (point or cell) at different points
	/// in time (parameter t). Two input data set attributes objects are input.
	/// The parameter t lies between (0&lt;=t&lt;=1). IMPORTANT: it is assumed that
	/// the number of attributes and number of components is the same for both
	/// from1 and from2, and the type of data for from1 and from2 are the same.
	/// Make sure that the method InterpolateAllocate() has been invoked before
	/// using this method.
	/// If the INTERPOLATION copy flag is set to 0 for an array, interpolation
	/// is prevented. If the flag is set to 1, weighted interpolation occurs.
	/// If the flag is set to 2, nearest neighbor interpolation is used.
	/// </summary>
	public void InterpolateTime(vtkDataSetAttributes from1, vtkDataSetAttributes from2, long id, double t)
	{
		vtkDataSetAttributes_InterpolateTime_84(GetCppThis(), from1?.GetCppThis() ?? default(HandleRef), from2?.GetCppThis() ?? default(HandleRef), id, t);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_IsA_85(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with copying turned on for all data.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataSetAttributes_IsA_85(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_IsArrayAnAttribute_86(HandleRef pThis, int idx);

	/// <summary>
	/// Determine whether a data array of index idx is considered a data set
	/// attribute (i.e., scalar, vector, tensor, etc). Return less-than zero
	/// if it is, otherwise an index 0&lt;=idx&lt;NUM_ATTRIBUTES to indicate
	/// which attribute.
	/// </summary>
	public int IsArrayAnAttribute(int idx)
	{
		return vtkDataSetAttributes_IsArrayAnAttribute_86(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_IsTypeOf_87(string type);

	/// <summary>
	/// Construct object with copying turned on for all data.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataSetAttributes_IsTypeOf_87(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_NewInstance_89(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with copying turned on for all data.
	/// </summary>
	public new vtkDataSetAttributes NewInstance()
	{
		vtkDataSetAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_NewInstance_89(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_PassData_90(HandleRef pThis, HandleRef fd);

	/// <summary>
	/// Pass entire arrays of input data through to output. Obey the "copy"
	/// flags. When passing a field, the following copying rules are
	/// followed: 1) Check if a field is an attribute, if yes and if there
	/// is a PASSDATA copy flag for that attribute (on or off), obey the flag
	/// for that attribute, ignore (2) and (3), 2) if there is a copy field for
	/// that field (on or off), obey the flag, ignore (3) 3) obey
	/// CopyAllOn/Off
	/// </summary>
	public override void PassData(vtkFieldData fd)
	{
		vtkDataSetAttributes_PassData_90(GetCppThis(), fd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_RemoveArray_91(HandleRef pThis, int index);

	/// <summary>
	/// Remove an array (with the given index) from the list of arrays.
	/// Does nothing if the index is out of range.
	/// </summary>
	public override void RemoveArray(int index)
	{
		vtkDataSetAttributes_RemoveArray_91(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetAttributes_SafeDownCast_92(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with copying turned on for all data.
	/// </summary>
	public new static vtkDataSetAttributes SafeDownCast(vtkObjectBase o)
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetAttributes_SafeDownCast_92(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDataSetAttributes_SetActiveAttribute_93(HandleRef pThis, string name, int attributeType);

	/// <summary>
	/// Make the array with the given name the active attribute.
	/// Attribute types are:
	/// vtkDataSetAttributes::SCALARS = 0
	/// vtkDataSetAttributes::VECTORS = 1
	/// vtkDataSetAttributes::NORMALS = 2
	/// vtkDataSetAttributes::TCOORDS = 3
	/// vtkDataSetAttributes::TENSORS = 4
	/// vtkDataSetAttributes::GLOBALIDS = 5
	/// vtkDataSetAttributes::PEDIGREEIDS = 6
	/// vtkDataSetAttributes::EDGEFLAG = 7
	/// vtkDataSetAttributes::TANGENTS = 8
	/// Returns the index of the array if successful, -1 if the array
	/// is not in the list of arrays.
	/// </summary>
	public int SetActiveAttribute(string name, int attributeType)
	{
		return vtkDataSetAttributes_SetActiveAttribute_93(GetCppThis(), name, attributeType);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveAttribute_94(HandleRef pThis, int index, int attributeType);

	/// <summary>
	/// Make the array with the given index the active attribute.
	/// Returns the index of the array if successful, -1 if the array
	/// is not in the list of arrays.
	/// </summary>
	public int SetActiveAttribute(int index, int attributeType)
	{
		return vtkDataSetAttributes_SetActiveAttribute_94(GetCppThis(), index, attributeType);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveGlobalIds_95(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the global id data.
	/// </summary>
	public int SetActiveGlobalIds(string name)
	{
		return vtkDataSetAttributes_SetActiveGlobalIds_95(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveHigherOrderDegrees_96(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the rational degrees data.
	/// </summary>
	public int SetActiveHigherOrderDegrees(string name)
	{
		return vtkDataSetAttributes_SetActiveHigherOrderDegrees_96(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveNormals_97(HandleRef pThis, string name);

	/// <summary>
	/// Set/get the normal data.
	/// </summary>
	public int SetActiveNormals(string name)
	{
		return vtkDataSetAttributes_SetActiveNormals_97(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActivePedigreeIds_98(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the pedigree id data.
	/// </summary>
	public int SetActivePedigreeIds(string name)
	{
		return vtkDataSetAttributes_SetActivePedigreeIds_98(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveRationalWeights_99(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the rational weights data.
	/// </summary>
	public int SetActiveRationalWeights(string name)
	{
		return vtkDataSetAttributes_SetActiveRationalWeights_99(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveScalars_100(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the scalar data.
	/// </summary>
	public int SetActiveScalars(string name)
	{
		return vtkDataSetAttributes_SetActiveScalars_100(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveTCoords_101(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the texture coordinate data.
	/// </summary>
	public int SetActiveTCoords(string name)
	{
		return vtkDataSetAttributes_SetActiveTCoords_101(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveTangents_102(HandleRef pThis, string name);

	/// <summary>
	/// Set/get the tangent data.
	/// </summary>
	public int SetActiveTangents(string name)
	{
		return vtkDataSetAttributes_SetActiveTangents_102(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveTensors_103(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the tensor data.
	/// </summary>
	public int SetActiveTensors(string name)
	{
		return vtkDataSetAttributes_SetActiveTensors_103(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetActiveVectors_104(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get the vector data.
	/// </summary>
	public int SetActiveVectors(string name)
	{
		return vtkDataSetAttributes_SetActiveVectors_104(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetAttribute_105(HandleRef pThis, HandleRef aa, int attributeType);

	/// <summary>
	/// Set an array to use as the given attribute type (i.e.,
	/// vtkDataSetAttributes::SCALAR, vtkDataSetAttributes::VECTOR,
	/// vtkDataSetAttributes::TENSOR, etc.). If this attribute was
	/// previously set to another array, that array is removed from the
	/// vtkDataSetAttributes object and the array aa is used as the
	/// attribute.
	///
	/// Returns the index of aa within the vtkDataSetAttributes object
	/// (i.e., the index to pass to the method GetArray(int) to obtain
	/// aa) if the attribute was set to aa successfully. If aa was
	/// already set as the given attributeType, returns the index of
	/// aa.
	///
	/// Returns -1 in the following cases:
	///
	/// - aa is nullptr (used to unset an attribute; not an error indicator)
	/// - aa is not a subclass of vtkDataArray, unless the attributeType
	/// is vtkDataSetAttributes::PEDIGREEIDS (error indicator)
	/// - aa has a number of components incompatible with the attribute type
	/// (error indicator)
	/// </summary>
	public int SetAttribute(vtkAbstractArray aa, int attributeType)
	{
		return vtkDataSetAttributes_SetAttribute_105(GetCppThis(), aa?.GetCppThis() ?? default(HandleRef), attributeType);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyAttribute_106(HandleRef pThis, int index, int value, int ctype);

	/// <summary>
	/// Turn on/off the copying of attribute data.
	/// ctype is one of the AttributeCopyOperations, and controls copy,
	/// interpolate and passdata behavior.
	/// For set, ctype=ALLCOPY means set all three flags to the same value.
	/// For get, ctype=ALLCOPY returns true only if all three flags are true.
	///
	/// During copying, interpolation and passdata, the following rules are
	/// followed for each array:
	/// 1. If the copy/interpolate/pass flag for an attribute is set (on or off),
	/// it is applied. This overrides rules 2 and 3.
	/// 2. If the copy flag for an array is set (on or off), it is applied
	/// This overrides rule 3.
	/// 3. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array
	///
	/// For interpolation, the flag values can be as follows:
	/// 0: Do not interpolate.
	/// 1: Weighted interpolation.
	/// 2: Nearest neighbor interpolation.
	/// </summary>
	public void SetCopyAttribute(int index, int value, int ctype)
	{
		vtkDataSetAttributes_SetCopyAttribute_106(GetCppThis(), index, value, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyGlobalIds_107(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyGlobalIds(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyGlobalIds_107(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyHigherOrderDegrees_108(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyHigherOrderDegrees(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyHigherOrderDegrees_108(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyNormals_109(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyNormals(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyNormals_109(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyPedigreeIds_110(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyPedigreeIds(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyPedigreeIds_110(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyRationalWeights_111(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyRationalWeights(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyRationalWeights_111(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyScalars_112(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyScalars(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyScalars_112(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyTCoords_113(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyTCoords(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyTCoords_113(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyTangents_114(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyTangents(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyTangents_114(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyTensors_115(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyTensors(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyTensors_115(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetCopyVectors_116(HandleRef pThis, int i, int ctype);

	/// <summary>
	/// Get the attribute copy flag for copy operation \c ctype of attribute
	/// \c index.
	/// </summary>
	public void SetCopyVectors(int i, int ctype)
	{
		vtkDataSetAttributes_SetCopyVectors_116(GetCppThis(), i, ctype);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetGlobalIds_117(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/Get the global id data.
	/// </summary>
	public int SetGlobalIds(vtkDataArray da)
	{
		return vtkDataSetAttributes_SetGlobalIds_117(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetHigherOrderDegrees_118(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/Get the rational degrees data.
	/// </summary>
	public int SetHigherOrderDegrees(vtkDataArray da)
	{
		return vtkDataSetAttributes_SetHigherOrderDegrees_118(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetNormals_119(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/get the normal data.
	/// </summary>
	public int SetNormals(vtkDataArray da)
	{
		return vtkDataSetAttributes_SetNormals_119(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetPedigreeIds_120(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/Get the pedigree id data.
	/// </summary>
	public int SetPedigreeIds(vtkAbstractArray da)
	{
		return vtkDataSetAttributes_SetPedigreeIds_120(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetRationalWeights_121(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/Get the rational weights data.
	/// </summary>
	public int SetRationalWeights(vtkDataArray da)
	{
		return vtkDataSetAttributes_SetRationalWeights_121(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetScalars_122(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/Get the scalar data.
	/// </summary>
	public int SetScalars(vtkDataArray da)
	{
		return vtkDataSetAttributes_SetScalars_122(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetTCoords_123(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/Get the texture coordinate data.
	/// </summary>
	public int SetTCoords(vtkDataArray da)
	{
		return vtkDataSetAttributes_SetTCoords_123(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetTangents_124(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/get the tangent data.
	/// </summary>
	public int SetTangents(vtkDataArray da)
	{
		return vtkDataSetAttributes_SetTangents_124(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetTensors_125(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/Get the tensor data.
	/// </summary>
	public int SetTensors(vtkDataArray da)
	{
		return vtkDataSetAttributes_SetTensors_125(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributes_SetVectors_126(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Set/Get the vector data.
	/// </summary>
	public int SetVectors(vtkDataArray da)
	{
		return vtkDataSetAttributes_SetVectors_126(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_SetupForCopy_127(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Create a mapping between the input attributes and this object
	/// so that methods like CopyData() and CopyStructuredData()
	/// can be called. This method assumes that this object has the
	/// same arrays as the input and that they are ordered the same
	/// way (same array indices).
	/// </summary>
	public void SetupForCopy(vtkDataSetAttributes pd)
	{
		vtkDataSetAttributes_SetupForCopy_127(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_ShallowCopy_128(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Shallow copy of data (i.e., use reference counting).
	/// Ignores the copy flags but preserves them in the output.
	/// </summary>
	public override void ShallowCopy(vtkFieldData pd)
	{
		vtkDataSetAttributes_ShallowCopy_128(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributes_Update_129(HandleRef pThis);

	/// <summary>
	/// Attributes have a chance to bring themselves up to date; right
	/// now this is ignored.
	/// </summary>
	public virtual void Update()
	{
		vtkDataSetAttributes_Update_129(GetCppThis());
	}
}
