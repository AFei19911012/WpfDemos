using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEnSightReader
/// </summary>
/// <remarks>
///    superclass for EnSight file readers
/// </remarks>
public abstract class vtkEnSightReader : vtkGenericEnSightReader
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum ElementTypesList
	{
		/// <summary>enum member</summary>
		BAR2 = 1,
		/// <summary>enum member</summary>
		BAR3 = 2,
		/// <summary>enum member</summary>
		HEXA20 = 14,
		/// <summary>enum member</summary>
		HEXA8 = 13,
		/// <summary>enum member</summary>
		NFACED = 8,
		/// <summary>enum member</summary>
		NSIDED = 3,
		/// <summary>enum member</summary>
		NUMBER_OF_ELEMENT_TYPES = 17,
		/// <summary>enum member</summary>
		PENTA15 = 16,
		/// <summary>enum member</summary>
		PENTA6 = 15,
		/// <summary>enum member</summary>
		POINT = 0,
		/// <summary>enum member</summary>
		PYRAMID13 = 12,
		/// <summary>enum member</summary>
		PYRAMID5 = 11,
		/// <summary>enum member</summary>
		QUAD4 = 6,
		/// <summary>enum member</summary>
		QUAD8 = 7,
		/// <summary>enum member</summary>
		TETRA10 = 10,
		/// <summary>enum member</summary>
		TETRA4 = 9,
		/// <summary>enum member</summary>
		TRIA3 = 4,
		/// <summary>enum member</summary>
		TRIA6 = 5
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum SectionTypeList
	{
		/// <summary>enum member</summary>
		BLOCK = 1,
		/// <summary>enum member</summary>
		COORDINATES = 0,
		/// <summary>enum member</summary>
		ELEMENT = 2
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum VariableTypesList
	{
		/// <summary>enum member</summary>
		COMPLEX_SCALAR_PER_ELEMENT = 10,
		/// <summary>enum member</summary>
		COMPLEX_SCALAR_PER_NODE = 8,
		/// <summary>enum member</summary>
		COMPLEX_VECTOR_PER_ELEMENT = 11,
		/// <summary>enum member</summary>
		COMPLEX_VECTOR_PER_NODE = 9,
		/// <summary>enum member</summary>
		SCALAR_PER_ELEMENT = 3,
		/// <summary>enum member</summary>
		SCALAR_PER_MEASURED_NODE = 6,
		/// <summary>enum member</summary>
		SCALAR_PER_NODE = 0,
		/// <summary>enum member</summary>
		TENSOR_ASYM_PER_ELEMENT = 13,
		/// <summary>enum member</summary>
		TENSOR_ASYM_PER_NODE = 12,
		/// <summary>enum member</summary>
		TENSOR_SYMM_PER_ELEMENT = 5,
		/// <summary>enum member</summary>
		TENSOR_SYMM_PER_NODE = 2,
		/// <summary>enum member</summary>
		VECTOR_PER_ELEMENT = 4,
		/// <summary>enum member</summary>
		VECTOR_PER_MEASURED_NODE = 7,
		/// <summary>enum member</summary>
		VECTOR_PER_NODE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEnSightReader()
	{
		MRClassNameKey = "class vtkEnSightReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEnSightReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightReader_GetMatchFileName_01(HandleRef pThis);

	/// <summary>
	/// Get the Match file name. Made public to allow access from
	/// apps requiring detailed info about the Data contents
	/// </summary>
	public virtual string GetMatchFileName()
	{
		return Marshal.PtrToStringAnsi(vtkEnSightReader_GetMatchFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightReader_GetMeasuredFileName_02(HandleRef pThis);

	/// <summary>
	/// Get the Measured file name. Made public to allow access from
	/// apps requiring detailed info about the Data contents
	/// </summary>
	public virtual string GetMeasuredFileName()
	{
		return Marshal.PtrToStringAnsi(vtkEnSightReader_GetMeasuredFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEnSightReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEnSightReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEnSightReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEnSightReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightReader_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEnSightReader_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightReader_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEnSightReader_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEnSightReader NewInstance()
	{
		vtkEnSightReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSightReader_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOEnSight.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEnSightReader SafeDownCast(vtkObjectBase o)
	{
		vtkEnSightReader vtkEnSightReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSightReader_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEnSightReader2 = (vtkEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEnSightReader2.Register(null);
			}
		}
		return vtkEnSightReader2;
	}
}
