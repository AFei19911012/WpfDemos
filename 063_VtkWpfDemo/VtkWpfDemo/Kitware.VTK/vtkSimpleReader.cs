using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSimpleReader
/// </summary>
/// <remarks>
///    Superclass for algorithms that are not time or parallel aware
///
/// </remarks>
public abstract class vtkSimpleReader : vtkReaderAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSimpleReader()
	{
		MRClassNameKey = "class vtkSimpleReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSimpleReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleReader_AddFileName_01(HandleRef pThis, string fname);

	/// <summary>
	/// Add a filename to be read. Since this superclass handles
	/// file series to support time, multiple filenames can be added.
	/// Note that the time values are either integers growing sequentially,
	/// or are obtained from individual files as supported by the subclass.
	/// </summary>
	public void AddFileName(string fname)
	{
		vtkSimpleReader_AddFileName_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleReader_ClearFileNames_02(HandleRef pThis);

	/// <summary>
	/// Removes all filenames stored by the reader.
	/// </summary>
	public void ClearFileNames()
	{
		vtkSimpleReader_ClearFileNames_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleReader_GetCurrentFileName_03(HandleRef pThis);

	/// <summary>
	/// Returns the filename that was last loaded by the reader.
	/// This is set internally in ReadMesh()
	/// </summary>
	public string GetCurrentFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSimpleReader_GetCurrentFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleReader_GetFileName_04(HandleRef pThis, int i);

	/// <summary>
	/// Returns a particular filename stored by the reader.
	/// </summary>
	public string GetFileName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkSimpleReader_GetFileName_04(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_GetNumberOfFileNames_05(HandleRef pThis);

	/// <summary>
	/// Returns the number of filenames stored by the reader.
	/// </summary>
	public int GetNumberOfFileNames()
	{
		return vtkSimpleReader_GetNumberOfFileNames_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSimpleReader_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleReader_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSimpleReader_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSimpleReader_GetTimeValue_08(HandleRef pThis, string fname);

	/// <summary>
	/// A subclass can override this method to provide an actual
	/// time value for a given file (this method is called for
	/// each filename stored by the reader). If time values is not
	/// available, the subclass does not have to override. This
	/// will return vtkMath::NaN() if no time value is present
	/// in the file.
	/// </summary>
	public virtual double GetTimeValue(string fname)
	{
		return vtkSimpleReader_GetTimeValue_08(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSimpleReader_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSimpleReader_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSimpleReader NewInstance()
	{
		vtkSimpleReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleReader_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_ReadArrays_12(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// This is the superclass API overridden by this class
	/// to provide time support internally. Subclasses should
	/// not normally have to override these methods.
	/// </summary>
	public override int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkSimpleReader_ReadArrays_12(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_ReadArraysSimple_13(HandleRef pThis, string fname, HandleRef output);

	/// <summary>
	/// A method that needs to be override by the subclass to provide
	/// data arrays. Note that the filename is passed to this
	/// method and should be used by the subclass. The subclass directly
	/// adds data arrays to the provided data object.
	/// </summary>
	public virtual int ReadArraysSimple(string fname, vtkDataObject output)
	{
		return vtkSimpleReader_ReadArraysSimple_13(GetCppThis(), fname, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_ReadMesh_14(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// This is the superclass API overridden by this class
	/// to provide time support internally. Subclasses should
	/// not normally have to override these methods.
	/// </summary>
	public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkSimpleReader_ReadMesh_14(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_ReadMeshSimple_15(HandleRef pThis, string fname, HandleRef output);

	/// <summary>
	/// A method that needs to be override by the subclass to provide
	/// the mesh (topology). Note that the filename is passed to this
	/// method and should be used by the subclass. The subclass directly
	/// adds the structure/topology to the provided data object.
	/// </summary>
	public virtual int ReadMeshSimple(string fname, vtkDataObject output)
	{
		return vtkSimpleReader_ReadMeshSimple_15(GetCppThis(), fname, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_ReadMetaData_16(HandleRef pThis, HandleRef metadata);

	/// <summary>
	/// This is the superclass API overridden by this class
	/// to provide time support internally. Subclasses should
	/// not normally have to override these methods.
	/// </summary>
	public override int ReadMetaData(vtkInformation metadata)
	{
		return vtkSimpleReader_ReadMetaData_16(GetCppThis(), metadata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_ReadMetaDataSimple_17(HandleRef pThis, string arg0, HandleRef arg1);

	/// <summary>
	/// A subclass can override this method to provide meta data
	/// specific to a particular file. In order for this method
	/// to be called, HasTemporalMetaData has to be set to true.
	/// </summary>
	public virtual int ReadMetaDataSimple(string arg0, vtkInformation arg1)
	{
		return vtkSimpleReader_ReadMetaDataSimple_17(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_ReadPoints_18(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// This is the superclass API overridden by this class
	/// to provide time support internally. Subclasses should
	/// not normally have to override these methods.
	/// </summary>
	public override int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkSimpleReader_ReadPoints_18(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_ReadPointsSimple_19(HandleRef pThis, string fname, HandleRef output);

	/// <summary>
	/// A method that needs to be override by the subclass to provide
	/// the point coordinates. Note that the filename is passed to this
	/// method and should be used by the subclass. The subclass directly
	/// adds the coordinates to the provided data object.
	/// </summary>
	public virtual int ReadPointsSimple(string fname, vtkDataObject output)
	{
		return vtkSimpleReader_ReadPointsSimple_19(GetCppThis(), fname, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleReader_ReadTimeDependentMetaData_20(HandleRef pThis, int timestep, HandleRef metadata);

	/// <summary>
	/// This is the superclass API overridden by this class
	/// to provide time support internally. Subclasses should
	/// not normally have to override these methods.
	/// </summary>
	public override int ReadTimeDependentMetaData(int timestep, vtkInformation metadata)
	{
		return vtkSimpleReader_ReadTimeDependentMetaData_20(GetCppThis(), timestep, metadata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleReader_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimpleReader SafeDownCast(vtkObjectBase o)
	{
		vtkSimpleReader vtkSimpleReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleReader_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSimpleReader2 = (vtkSimpleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSimpleReader2.Register(null);
			}
		}
		return vtkSimpleReader2;
	}
}
