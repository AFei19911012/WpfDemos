using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalDelimitedTextReader
/// </summary>
/// <remarks>
///    reads a delimited ascii or unicode text files and and output a
/// temporal vtkTable.
///
/// This reader requires that FieldDelimiterCharacters is set before
/// the pipeline is executed, otherwise it will produce an empty output.
///
/// A column can be selected as time step indicator using the SetTimeColumnName
/// or SetTimeColumnId functions. If so, for a given time step 's' only the
/// lines where the time step indicator column have the value 's' are present.
/// To control if the time step indicator column should be present in the
/// output, a RemoveTimeStepColumn option is available. If no time step
/// indicator column is given by the user, the whole file it outputted.
///
/// This reader assume the time step column is numeric. A warning is
/// set otherwise. The DetectNumericColumns field is set to on,
/// do not change this field unless you really know what you are
/// doing.
///
/// @see vtkDelimitedTextReader
/// </remarks>
public class vtkTemporalDelimitedTextReader : vtkDelimitedTextReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalDelimitedTextReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalDelimitedTextReader()
	{
		MRClassNameKey = "class vtkTemporalDelimitedTextReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalDelimitedTextReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalDelimitedTextReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalDelimitedTextReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalDelimitedTextReader New()
	{
		vtkTemporalDelimitedTextReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalDelimitedTextReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTemporalDelimitedTextReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalDelimitedTextReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTemporalDelimitedTextReader_GetMTime_01(HandleRef pThis);

	/// <summary>
	/// This mechanism ensures the actual data is only re-read when necessary.
	/// Here, we ensure the GetMTime of this reader stay consistent by returning
	/// the latest between the MTime of this reader and the internal one.
	///
	/// @see InternalModified
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTemporalDelimitedTextReader_GetMTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalDelimitedTextReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalDelimitedTextReader_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalDelimitedTextReader_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalDelimitedTextReader_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTemporalDelimitedTextReader_GetRemoveTimeStepColumn_04(HandleRef pThis);

	/// <summary>
	/// Set the RemoveTimeStepColumn flag
	/// If this boolean is true, the output will not contain the Time step column.
	/// Default to true.
	/// </summary>
	public virtual bool GetRemoveTimeStepColumn()
	{
		return (vtkTemporalDelimitedTextReader_GetRemoveTimeStepColumn_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalDelimitedTextReader_GetTimeColumnId_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the column to use as time indicator.
	/// It the TimeColumnId is equal to -1, the TimeColumnName will be used
	/// instead.
	/// If no column has been chosen using either the TimeColumnId or the
	/// TimeColumnName the whole input file is outputted.
	/// Default to -1.
	/// </summary>
	public virtual int GetTimeColumnId()
	{
		return vtkTemporalDelimitedTextReader_GetTimeColumnId_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkTemporalDelimitedTextReader_GetTimeColumnName_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the column to use as time indicator.
	/// Ignored if TimeColumnId is not equal to -1.
	/// If no column has been chosen using either the TimeColumnId or the
	/// TimeColumnName the whole input file is outputted.
	/// Default to empty string.
	/// </summary>
	public virtual string GetTimeColumnName()
	{
		return vtkTemporalDelimitedTextReader_GetTimeColumnName_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalDelimitedTextReader_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalDelimitedTextReader_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalDelimitedTextReader_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalDelimitedTextReader_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalDelimitedTextReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTemporalDelimitedTextReader NewInstance()
	{
		vtkTemporalDelimitedTextReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalDelimitedTextReader_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalDelimitedTextReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalDelimitedTextReader SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalDelimitedTextReader vtkTemporalDelimitedTextReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalDelimitedTextReader_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalDelimitedTextReader2 = (vtkTemporalDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalDelimitedTextReader2.Register(null);
			}
		}
		return vtkTemporalDelimitedTextReader2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDelimitedTextReader_SetRemoveTimeStepColumn_12(HandleRef pThis, byte rts);

	/// <summary>
	/// Set the RemoveTimeStepColumn flag
	/// If this boolean is true, the output will not contain the Time step column.
	/// Default to true.
	/// </summary>
	public void SetRemoveTimeStepColumn(bool rts)
	{
		vtkTemporalDelimitedTextReader_SetRemoveTimeStepColumn_12(GetCppThis(), (byte)(rts ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDelimitedTextReader_SetTimeColumnId_13(HandleRef pThis, int idx);

	/// <summary>
	/// Get/Set the column to use as time indicator.
	/// It the TimeColumnId is equal to -1, the TimeColumnName will be used
	/// instead.
	/// If no column has been chosen using either the TimeColumnId or the
	/// TimeColumnName the whole input file is outputted.
	/// Default to -1.
	/// </summary>
	public void SetTimeColumnId(int idx)
	{
		vtkTemporalDelimitedTextReader_SetTimeColumnId_13(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalDelimitedTextReader_SetTimeColumnName_14(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set the name of the column to use as time indicator.
	/// Ignored if TimeColumnId is not equal to -1.
	/// If no column has been chosen using either the TimeColumnId or the
	/// TimeColumnName the whole input file is outputted.
	/// Default to empty string.
	/// </summary>
	public void SetTimeColumnName(string name)
	{
		vtkTemporalDelimitedTextReader_SetTimeColumnName_14(GetCppThis(), name);
	}
}
