using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericEnSightReader
/// </summary>
/// <remarks>
///    class to read any type of EnSight files
///
/// The class vtkGenericEnSightReader allows the user to read an EnSight data
/// set without a priori knowledge of what type of EnSight data set it is.
/// </remarks>
public class vtkGenericEnSightReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public enum FILE_BIG_ENDIAN_WrapperEnum
	{
		/// <summary>enum member</summary>
		FILE_BIG_ENDIAN,
		/// <summary>enum member</summary>
		FILE_LITTLE_ENDIAN,
		/// <summary>enum member</summary>
		FILE_UNKNOWN_ENDIAN
	}

	/// <summary>
	/// Get/Set whether the point or cell array with the given name is to
	/// be read.
	/// </summary>
	public enum FileTypes
	{
		/// <summary>enum member</summary>
		ENSIGHT_6,
		/// <summary>enum member</summary>
		ENSIGHT_6_BINARY,
		/// <summary>enum member</summary>
		ENSIGHT_GOLD,
		/// <summary>enum member</summary>
		ENSIGHT_GOLD_BINARY,
		/// <summary>enum member</summary>
		ENSIGHT_MASTER_SERVER
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericEnSightReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericEnSightReader()
	{
		MRClassNameKey = "class vtkGenericEnSightReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericEnSightReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericEnSightReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericEnSightReader New()
	{
		vtkGenericEnSightReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEnSightReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGenericEnSightReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericEnSightReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_CanReadFile_01(HandleRef pThis, string casefilename);

	/// <summary>
	/// Returns IsEnSightFile() by default, but can be overridden
	/// </summary>
	public virtual int CanReadFile(string casefilename)
	{
		return vtkGenericEnSightReader_CanReadFile_01(GetCppThis(), casefilename);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_DetermineEnSightVersion_02(HandleRef pThis, int quiet);

	/// <summary>
	/// Reads the FORMAT part of the case file to determine whether this is an
	/// EnSight6 or EnSightGold data set.  Returns an identifier listed in
	/// the FileTypes enum or -1 if an error occurred or the file could not
	/// be identified as any EnSight type.
	/// </summary>
	public int DetermineEnSightVersion(int quiet)
	{
		return vtkGenericEnSightReader_DetermineEnSightVersion_02(GetCppThis(), quiet);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGenericEnSightReader_GetApplyTetrahedralize_03(HandleRef pThis);

	/// <summary>
	/// Get/set to ApplyTetrahedralize.
	/// It's used to apply a Tetrahedralize filter to prevent potential non manifold triangles
	/// produced by the ensight solver.
	/// </summary>
	public virtual bool GetApplyTetrahedralize()
	{
		return (vtkGenericEnSightReader_GetApplyTetrahedralize_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetByteOrder_04(HandleRef pThis);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public virtual int GetByteOrder()
	{
		return vtkGenericEnSightReader_GetByteOrder_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetByteOrderAsString_05(HandleRef pThis);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public string GetByteOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGenericEnSightReader_GetByteOrderAsString_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetCaseFileName_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the Case file name.
	/// </summary>
	public virtual string GetCaseFileName()
	{
		return Marshal.PtrToStringAnsi(vtkGenericEnSightReader_GetCaseFileName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetCellArrayName_07(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point or cell array with the given index in
	/// the input.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkGenericEnSightReader_GetCellArrayName_07(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetCellArrayStatus_08(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the point or cell array with the given name is to
	/// be read.
	/// </summary>
	public int GetCellArrayStatus(string name)
	{
		return vtkGenericEnSightReader_GetCellArrayStatus_08(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetCellDataArraySelection_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data array selection tables used to configure which data
	/// arrays are loaded by the reader.
	/// </summary>
	public virtual vtkDataArraySelection GetCellDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEnSightReader_GetCellDataArraySelection_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetComplexDescription_10(HandleRef pThis, int n);

	/// <summary>
	/// Get the nth description for a complex variable.
	/// </summary>
	public string GetComplexDescription(int n)
	{
		return Marshal.PtrToStringAnsi(vtkGenericEnSightReader_GetComplexDescription_10(GetCppThis(), n));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetComplexVariableType_11(HandleRef pThis, int n);

	/// <summary>
	/// Get the variable type of variable n.
	/// </summary>
	public int GetComplexVariableType(int n)
	{
		return vtkGenericEnSightReader_GetComplexVariableType_11(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetDescription_12(HandleRef pThis, int n);

	/// <summary>
	/// Get the nth description for a non-complex variable.
	/// </summary>
	public string GetDescription(int n)
	{
		return Marshal.PtrToStringAnsi(vtkGenericEnSightReader_GetDescription_12(GetCppThis(), n));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetDescription_13(HandleRef pThis, int n, int type);

	/// <summary>
	/// Get the nth description of a particular variable type.  Returns nullptr if no
	/// variable of this type exists in this data set.
	/// SCALAR_PER_NODE = 0; VECTOR_PER_NODE = 1;
	/// TENSOR_SYMM_PER_NODE = 2; SCALAR_PER_ELEMENT = 3;
	/// VECTOR_PER_ELEMENT = 4; TENSOR_SYMM_PER_ELEMENT = 5;
	/// SCALAR_PER_MEASURED_NODE = 6; VECTOR_PER_MEASURED_NODE = 7;
	/// COMPLEX_SCALAR_PER_NODE = 8; COMPLEX_VECTOR_PER_NODE 9;
	/// COMPLEX_SCALAR_PER_ELEMENT = 10; COMPLEX_VECTOR_PER_ELEMENT = 11;
	/// TENSOR_ASYM_PER_NODE = 12; TENSOR_ASYM_PER_ELEMENT = 13;
	/// </summary>
	public string GetDescription(int n, int type)
	{
		return Marshal.PtrToStringAnsi(vtkGenericEnSightReader_GetDescription_13(GetCppThis(), n, type));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetEnSightVersion_14(HandleRef pThis);

	/// <summary>
	/// Get the EnSight file version being read.
	/// </summary>
	public virtual int GetEnSightVersion()
	{
		return vtkGenericEnSightReader_GetEnSightVersion_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetFilePath_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the file path.
	/// </summary>
	public virtual string GetFilePath()
	{
		return Marshal.PtrToStringAnsi(vtkGenericEnSightReader_GetFilePath_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetGeometryFileName_16(HandleRef pThis);

	/// <summary>
	/// Get the Geometry file name. Made public to allow access from
	/// apps requiring detailed info about the Data contents
	/// </summary>
	public virtual string GetGeometryFileName()
	{
		return Marshal.PtrToStringAnsi(vtkGenericEnSightReader_GetGeometryFileName_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGenericEnSightReader_GetMaximumTimeValue_17(HandleRef pThis);

	/// <summary>
	/// Get the minimum or maximum time value for this data set.
	/// </summary>
	public virtual float GetMaximumTimeValue()
	{
		return vtkGenericEnSightReader_GetMaximumTimeValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGenericEnSightReader_GetMinimumTimeValue_18(HandleRef pThis);

	/// <summary>
	/// Get the minimum or maximum time value for this data set.
	/// </summary>
	public virtual float GetMinimumTimeValue()
	{
		return vtkGenericEnSightReader_GetMinimumTimeValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfCellArrays_19(HandleRef pThis);

	/// <summary>
	/// Get the number of point or cell arrays available in the input.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkGenericEnSightReader_GetNumberOfCellArrays_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfComplexScalarsPerElement_20(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfComplexScalarsPerElement()
	{
		return vtkGenericEnSightReader_GetNumberOfComplexScalarsPerElement_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfComplexScalarsPerNode_21(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfComplexScalarsPerNode()
	{
		return vtkGenericEnSightReader_GetNumberOfComplexScalarsPerNode_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfComplexVariables_22(HandleRef pThis);

	/// <summary>
	/// Get the number of variables listed in the case file.
	/// </summary>
	public virtual int GetNumberOfComplexVariables()
	{
		return vtkGenericEnSightReader_GetNumberOfComplexVariables_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfComplexVectorsPerElement_23(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfComplexVectorsPerElement()
	{
		return vtkGenericEnSightReader_GetNumberOfComplexVectorsPerElement_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfComplexVectorsPerNode_24(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfComplexVectorsPerNode()
	{
		return vtkGenericEnSightReader_GetNumberOfComplexVectorsPerNode_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericEnSightReader_GetNumberOfGenerationsFromBase_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericEnSightReader_GetNumberOfGenerationsFromBase_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericEnSightReader_GetNumberOfGenerationsFromBaseType_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericEnSightReader_GetNumberOfGenerationsFromBaseType_26(type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfPointArrays_27(HandleRef pThis);

	/// <summary>
	/// Get the number of point or cell arrays available in the input.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkGenericEnSightReader_GetNumberOfPointArrays_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfScalarsPerElement_28(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfScalarsPerElement()
	{
		return vtkGenericEnSightReader_GetNumberOfScalarsPerElement_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfScalarsPerMeasuredNode_29(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfScalarsPerMeasuredNode()
	{
		return vtkGenericEnSightReader_GetNumberOfScalarsPerMeasuredNode_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfScalarsPerNode_30(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfScalarsPerNode()
	{
		return vtkGenericEnSightReader_GetNumberOfScalarsPerNode_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsAsymPerElement_31(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfTensorsAsymPerElement()
	{
		return vtkGenericEnSightReader_GetNumberOfTensorsAsymPerElement_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsAsymPerNode_32(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfTensorsAsymPerNode()
	{
		return vtkGenericEnSightReader_GetNumberOfTensorsAsymPerNode_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsSymmPerElement_33(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfTensorsSymmPerElement()
	{
		return vtkGenericEnSightReader_GetNumberOfTensorsSymmPerElement_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsSymmPerNode_34(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfTensorsSymmPerNode()
	{
		return vtkGenericEnSightReader_GetNumberOfTensorsSymmPerNode_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfVariables_35(HandleRef pThis);

	/// <summary>
	/// Get the number of variables listed in the case file.
	/// </summary>
	public virtual int GetNumberOfVariables()
	{
		return vtkGenericEnSightReader_GetNumberOfVariables_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfVariables_36(HandleRef pThis, int type);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public int GetNumberOfVariables(int type)
	{
		return vtkGenericEnSightReader_GetNumberOfVariables_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfVectorsPerElement_37(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfVectorsPerElement()
	{
		return vtkGenericEnSightReader_GetNumberOfVectorsPerElement_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfVectorsPerMeasuredNode_38(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfVectorsPerMeasuredNode()
	{
		return vtkGenericEnSightReader_GetNumberOfVectorsPerMeasuredNode_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetNumberOfVectorsPerNode_39(HandleRef pThis);

	/// <summary>
	/// Get the number of variables of a particular type.
	/// </summary>
	public virtual int GetNumberOfVectorsPerNode()
	{
		return vtkGenericEnSightReader_GetNumberOfVectorsPerNode_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetParticleCoordinatesByIndex_40(HandleRef pThis);

	/// <summary>
	/// The MeasuredGeometryFile should list particle coordinates
	/// from 0-&gt;N-1.
	/// If a file is loaded where point Ids are listed from 1-N
	/// the Id to points reference will be wrong and the data
	/// will be generated incorrectly.
	/// Setting ParticleCoordinatesByIndex to true will force
	/// all Id's to increment from 0-&gt;N-1 (relative to their order
	/// in the file) and regardless of the actual Id of the point.
	/// Warning, if the Points are listed in non sequential order
	/// then setting this flag will reorder them.
	/// </summary>
	public virtual int GetParticleCoordinatesByIndex()
	{
		return vtkGenericEnSightReader_GetParticleCoordinatesByIndex_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetPointArrayName_41(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point or cell array with the given index in
	/// the input.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkGenericEnSightReader_GetPointArrayName_41(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetPointArrayStatus_42(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the point or cell array with the given name is to
	/// be read.
	/// </summary>
	public int GetPointArrayStatus(string name)
	{
		return vtkGenericEnSightReader_GetPointArrayStatus_42(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetPointDataArraySelection_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data array selection tables used to configure which data
	/// arrays are loaded by the reader.
	/// </summary>
	public virtual vtkDataArraySelection GetPointDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEnSightReader_GetPointDataArraySelection_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetReadAllVariables_44(HandleRef pThis);

	/// <summary>
	/// Set/get the flag for whether to read all the variables
	/// </summary>
	public virtual int GetReadAllVariables()
	{
		return vtkGenericEnSightReader_GetReadAllVariables_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetReader_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns IsEnSightFile() by default, but can be overridden
	/// </summary>
	public vtkGenericEnSightReader GetReader()
	{
		vtkGenericEnSightReader vtkGenericEnSightReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEnSightReader_GetReader_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericEnSightReader2 = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericEnSightReader2.Register(null);
			}
		}
		return vtkGenericEnSightReader2;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_GetTimeSets_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the time values per time set
	/// </summary>
	public virtual vtkDataArrayCollection GetTimeSets()
	{
		vtkDataArrayCollection vtkDataArrayCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEnSightReader_GetTimeSets_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArrayCollection2 = (vtkDataArrayCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArrayCollection2.Register(null);
			}
		}
		return vtkDataArrayCollection2;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGenericEnSightReader_GetTimeValue_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the time value at which to get the value.
	/// </summary>
	public virtual float GetTimeValue()
	{
		return vtkGenericEnSightReader_GetTimeValue_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_GetVariableType_48(HandleRef pThis, int n);

	/// <summary>
	/// Get the variable type of variable n.
	/// </summary>
	public int GetVariableType(int n)
	{
		return vtkGenericEnSightReader_GetVariableType_48(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_IsA_49(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericEnSightReader_IsA_49(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGenericEnSightReader_IsEnSightFile_50(string casefilename);

	/// <summary>
	/// Returns true if the file pointed to by casefilename appears to be a
	/// valid EnSight case file.
	/// </summary>
	public static bool IsEnSightFile(string casefilename)
	{
		return (vtkGenericEnSightReader_IsEnSightFile_50(casefilename) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericEnSightReader_IsTypeOf_51(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericEnSightReader_IsTypeOf_51(type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_NewInstance_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericEnSightReader NewInstance()
	{
		vtkGenericEnSightReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEnSightReader_NewInstance_53(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_ParticleCoordinatesByIndexOff_54(HandleRef pThis);

	/// <summary>
	/// The MeasuredGeometryFile should list particle coordinates
	/// from 0-&gt;N-1.
	/// If a file is loaded where point Ids are listed from 1-N
	/// the Id to points reference will be wrong and the data
	/// will be generated incorrectly.
	/// Setting ParticleCoordinatesByIndex to true will force
	/// all Id's to increment from 0-&gt;N-1 (relative to their order
	/// in the file) and regardless of the actual Id of the point.
	/// Warning, if the Points are listed in non sequential order
	/// then setting this flag will reorder them.
	/// </summary>
	public virtual void ParticleCoordinatesByIndexOff()
	{
		vtkGenericEnSightReader_ParticleCoordinatesByIndexOff_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_ParticleCoordinatesByIndexOn_55(HandleRef pThis);

	/// <summary>
	/// The MeasuredGeometryFile should list particle coordinates
	/// from 0-&gt;N-1.
	/// If a file is loaded where point Ids are listed from 1-N
	/// the Id to points reference will be wrong and the data
	/// will be generated incorrectly.
	/// Setting ParticleCoordinatesByIndex to true will force
	/// all Id's to increment from 0-&gt;N-1 (relative to their order
	/// in the file) and regardless of the actual Id of the point.
	/// Warning, if the Points are listed in non sequential order
	/// then setting this flag will reorder them.
	/// </summary>
	public virtual void ParticleCoordinatesByIndexOn()
	{
		vtkGenericEnSightReader_ParticleCoordinatesByIndexOn_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_ReadAllVariablesOff_56(HandleRef pThis);

	/// <summary>
	/// Set/get the flag for whether to read all the variables
	/// </summary>
	public virtual void ReadAllVariablesOff()
	{
		vtkGenericEnSightReader_ReadAllVariablesOff_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_ReadAllVariablesOn_57(HandleRef pThis);

	/// <summary>
	/// Set/get the flag for whether to read all the variables
	/// </summary>
	public virtual void ReadAllVariablesOn()
	{
		vtkGenericEnSightReader_ReadAllVariablesOn_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericEnSightReader_SafeDownCast_58(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericEnSightReader SafeDownCast(vtkObjectBase o)
	{
		vtkGenericEnSightReader vtkGenericEnSightReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericEnSightReader_SafeDownCast_58(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericEnSightReader2 = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericEnSightReader2.Register(null);
			}
		}
		return vtkGenericEnSightReader2;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetApplyTetrahedralize_59(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set to ApplyTetrahedralize.
	/// It's used to apply a Tetrahedralize filter to prevent potential non manifold triangles
	/// produced by the ensight solver.
	/// </summary>
	public virtual void SetApplyTetrahedralize(bool _arg)
	{
		vtkGenericEnSightReader_SetApplyTetrahedralize_59(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetByteOrder_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public virtual void SetByteOrder(int _arg)
	{
		vtkGenericEnSightReader_SetByteOrder_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetByteOrderToBigEndian_61(HandleRef pThis);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public void SetByteOrderToBigEndian()
	{
		vtkGenericEnSightReader_SetByteOrderToBigEndian_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetByteOrderToLittleEndian_62(HandleRef pThis);

	/// <summary>
	/// Set the byte order of the file (remember, more Unix workstations
	/// write big endian whereas PCs write little endian). Default is
	/// big endian (since most older PLOT3D files were written by
	/// workstations).
	/// </summary>
	public void SetByteOrderToLittleEndian()
	{
		vtkGenericEnSightReader_SetByteOrderToLittleEndian_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetCaseFileName_63(HandleRef pThis, string fileName);

	/// <summary>
	/// Set/Get the Case file name.
	/// </summary>
	public void SetCaseFileName(string fileName)
	{
		vtkGenericEnSightReader_SetCaseFileName_63(GetCppThis(), fileName);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetCellArrayStatus_64(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the point or cell array with the given name is to
	/// be read.
	/// </summary>
	public void SetCellArrayStatus(string name, int status)
	{
		vtkGenericEnSightReader_SetCellArrayStatus_64(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetFilePath_65(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the file path.
	/// </summary>
	public virtual void SetFilePath(string _arg)
	{
		vtkGenericEnSightReader_SetFilePath_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetParticleCoordinatesByIndex_66(HandleRef pThis, int _arg);

	/// <summary>
	/// The MeasuredGeometryFile should list particle coordinates
	/// from 0-&gt;N-1.
	/// If a file is loaded where point Ids are listed from 1-N
	/// the Id to points reference will be wrong and the data
	/// will be generated incorrectly.
	/// Setting ParticleCoordinatesByIndex to true will force
	/// all Id's to increment from 0-&gt;N-1 (relative to their order
	/// in the file) and regardless of the actual Id of the point.
	/// Warning, if the Points are listed in non sequential order
	/// then setting this flag will reorder them.
	/// </summary>
	public virtual void SetParticleCoordinatesByIndex(int _arg)
	{
		vtkGenericEnSightReader_SetParticleCoordinatesByIndex_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetPointArrayStatus_67(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the point or cell array with the given name is to
	/// be read.
	/// </summary>
	public void SetPointArrayStatus(string name, int status)
	{
		vtkGenericEnSightReader_SetPointArrayStatus_67(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetReadAllVariables_68(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the flag for whether to read all the variables
	/// </summary>
	public virtual void SetReadAllVariables(int _arg)
	{
		vtkGenericEnSightReader_SetReadAllVariables_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericEnSightReader_SetTimeValue_69(HandleRef pThis, float value);

	/// <summary>
	/// Set/Get the time value at which to get the value.
	/// </summary>
	public virtual void SetTimeValue(float value)
	{
		vtkGenericEnSightReader_SetTimeValue_69(GetCppThis(), value);
	}
}
