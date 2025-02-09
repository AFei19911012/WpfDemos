using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLReader
/// </summary>
/// <remarks>
///    Superclass for VTK's XML format readers.
///
/// vtkXMLReader uses vtkXMLDataParser to parse a
/// &lt;a href="http://www.vtk.org/Wiki/VTK_XML_Formats"&gt;VTK XML&lt;/a&gt; input file.
/// Concrete subclasses then traverse the parsed file structure and extract data.
/// </remarks>
public abstract class vtkXMLReader : vtkAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum FieldType
	{
		/// <summary>enum member</summary>
		CELL_DATA = 1,
		/// <summary>enum member</summary>
		OTHER = 2,
		/// <summary>enum member</summary>
		POINT_DATA = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLReader()
	{
		MRClassNameKey = "class vtkXMLReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_CanReadFile_01(HandleRef pThis, string name);

	/// <summary>
	/// Test whether the file (type) with the given name can be read by this
	/// reader. If the file has a newer version than the reader, we still say
	/// we can read the file type and we fail later, when we try to read the file.
	/// This enables clients (ParaView) to distinguish between failures when we
	/// need to look for another reader and failures when we don't.
	/// </summary>
	public virtual int CanReadFile(string name)
	{
		return vtkXMLReader_CanReadFile_01(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_CopyOutputInformation_02(HandleRef pThis, HandleRef arg0, int arg1);

	/// <summary>
	/// Get/Set whether the point, cell, column or time array with the given name is to
	/// be read.
	/// </summary>
	public virtual void CopyOutputInformation(vtkInformation arg0, int arg1)
	{
		vtkXMLReader_CopyOutputInformation_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetActiveTimeDataArrayName_03(HandleRef pThis);

	/// <summary>
	/// Setter / Getter on ActiveTimeDataArrayName. This string
	/// holds the selected time array name. If set to `nullptr`,
	/// time values are the sequence of positive integers starting at zero.
	/// Default value is `TimeValue` for legacy reasons.
	/// </summary>
	public virtual string GetActiveTimeDataArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLReader_GetActiveTimeDataArrayName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetCellArrayName_04(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point, cell, column or time array with the given index in
	/// the input.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkXMLReader_GetCellArrayName_04(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetCellArrayStatus_05(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the point, cell, column or time array with the given name is to
	/// be read.
	/// </summary>
	public int GetCellArrayStatus(string name)
	{
		return vtkXMLReader_GetCellArrayStatus_05(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetCellDataArraySelection_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkXMLReader_GetCellDataArraySelection_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetColumnArrayName_07(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point, cell, column or time array with the given index in
	/// the input.
	/// </summary>
	public string GetColumnArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkXMLReader_GetColumnArrayName_07(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetColumnArraySelection_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data array selection tables used to configure which data
	/// arrays are loaded by the reader.
	/// </summary>
	public virtual vtkDataArraySelection GetColumnArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLReader_GetColumnArraySelection_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetColumnArrayStatus_09(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the point, cell, column or time array with the given name is to
	/// be read.
	/// </summary>
	public int GetColumnArrayStatus(string name)
	{
		return vtkXMLReader_GetColumnArrayStatus_09(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetFileName_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the input file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLReader_GetFileName_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetNumberOfCellArrays_11(HandleRef pThis);

	/// <summary>
	/// Get the number of point, cell or column arrays available in the input.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkXMLReader_GetNumberOfCellArrays_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetNumberOfColumnArrays_12(HandleRef pThis);

	/// <summary>
	/// Get the number of point, cell or column arrays available in the input.
	/// </summary>
	public int GetNumberOfColumnArrays()
	{
		return vtkXMLReader_GetNumberOfColumnArrays_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLReader_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLReader_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLReader_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLReader_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetNumberOfPointArrays_15(HandleRef pThis);

	/// <summary>
	/// Get the number of point, cell or column arrays available in the input.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkXMLReader_GetNumberOfPointArrays_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetNumberOfTimeDataArrays_16(HandleRef pThis);

	/// <summary>
	/// Getters for time data array candidates.
	/// </summary>
	public int GetNumberOfTimeDataArrays()
	{
		return vtkXMLReader_GetNumberOfTimeDataArrays_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetNumberOfTimeSteps_17(HandleRef pThis);

	/// <summary>
	/// Which TimeStep to read.
	/// </summary>
	public virtual int GetNumberOfTimeSteps()
	{
		return vtkXMLReader_GetNumberOfTimeSteps_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetOutputAsDataSet_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a vtkDataSet pointer.
	/// </summary>
	public vtkDataSet GetOutputAsDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLReader_GetOutputAsDataSet_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetOutputAsDataSet_19(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a vtkDataSet pointer.
	/// </summary>
	public vtkDataSet GetOutputAsDataSet(int index)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLReader_GetOutputAsDataSet_19(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetParserErrorObserver_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the ErrorObserver for the internal xml parser
	/// This is useful for applications that want to catch error messages.
	/// </summary>
	public virtual vtkCommand GetParserErrorObserver()
	{
		vtkCommand vtkCommand2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLReader_GetParserErrorObserver_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCommand2 = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCommand2.Register(null);
			}
		}
		return vtkCommand2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetPointArrayName_21(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point, cell, column or time array with the given index in
	/// the input.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkXMLReader_GetPointArrayName_21(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetPointArrayStatus_22(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the point, cell, column or time array with the given name is to
	/// be read.
	/// </summary>
	public int GetPointArrayStatus(string name)
	{
		return vtkXMLReader_GetPointArrayStatus_22(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetPointDataArraySelection_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkXMLReader_GetPointDataArraySelection_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetReadFromInputString_24(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// </summary>
	public virtual int GetReadFromInputString()
	{
		return vtkXMLReader_GetReadFromInputString_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetReaderErrorObserver_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the ErrorObserver for the internal reader
	/// This is useful for applications that want to catch error messages.
	/// </summary>
	public virtual vtkCommand GetReaderErrorObserver()
	{
		vtkCommand vtkCommand2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLReader_GetReaderErrorObserver_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCommand2 = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCommand2.Register(null);
			}
		}
		return vtkCommand2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetTimeDataArray_26(HandleRef pThis, int idx);

	/// <summary>
	/// Getters for time data array candidates.
	/// </summary>
	public string GetTimeDataArray(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkXMLReader_GetTimeDataArray_26(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetTimeDataStringArray_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Getters for time data array candidates.
	/// </summary>
	public virtual vtkStringArray GetTimeDataStringArray()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLReader_GetTimeDataStringArray_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_GetTimeStep_28(HandleRef pThis);

	/// <summary>
	/// Which TimeStep to read.
	/// </summary>
	public virtual int GetTimeStep()
	{
		return vtkXMLReader_GetTimeStep_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetTimeStepRange_29(HandleRef pThis);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public virtual int[] GetTimeStepRange()
	{
		IntPtr intPtr = vtkXMLReader_GetTimeStepRange_29(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_GetTimeStepRange_30(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
	{
		vtkXMLReader_GetTimeStepRange_30(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_GetTimeStepRange_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public virtual void GetTimeStepRange(IntPtr _arg)
	{
		vtkXMLReader_GetTimeStepRange_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_GetXMLParser_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the internal XML parser. This can be used to access
	/// the XML DOM after RequestInformation() was called.
	/// </summary>
	public vtkXMLDataParser GetXMLParser()
	{
		vtkXMLDataParser vtkXMLDataParser2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLReader_GetXMLParser_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLDataParser2 = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLDataParser2.Register(null);
			}
		}
		return vtkXMLDataParser2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_IsA_33(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLReader_IsA_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLReader_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLReader_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLReader NewInstance()
	{
		vtkXMLReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLReader_NewInstance_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_ReadFromInputStringOff_36(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// </summary>
	public virtual void ReadFromInputStringOff()
	{
		vtkXMLReader_ReadFromInputStringOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_ReadFromInputStringOn_37(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// </summary>
	public virtual void ReadFromInputStringOn()
	{
		vtkXMLReader_ReadFromInputStringOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLReader_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLReader SafeDownCast(vtkObjectBase o)
	{
		vtkXMLReader vtkXMLReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLReader_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLReader2 = (vtkXMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLReader2.Register(null);
			}
		}
		return vtkXMLReader2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetActiveTimeDataArrayName_39(HandleRef pThis, string _arg);

	/// <summary>
	/// Setter / Getter on ActiveTimeDataArrayName. This string
	/// holds the selected time array name. If set to `nullptr`,
	/// time values are the sequence of positive integers starting at zero.
	/// Default value is `TimeValue` for legacy reasons.
	/// </summary>
	public virtual void SetActiveTimeDataArrayName(string _arg)
	{
		vtkXMLReader_SetActiveTimeDataArrayName_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetCellArrayStatus_40(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the point, cell, column or time array with the given name is to
	/// be read.
	/// </summary>
	public void SetCellArrayStatus(string name, int status)
	{
		vtkXMLReader_SetCellArrayStatus_40(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetColumnArrayStatus_41(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the point, cell, column or time array with the given name is to
	/// be read.
	/// </summary>
	public void SetColumnArrayStatus(string name, int status)
	{
		vtkXMLReader_SetColumnArrayStatus_41(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetFileName_42(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the input file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkXMLReader_SetFileName_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetInputString_43(HandleRef pThis, string s);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// </summary>
	public void SetInputString(string s)
	{
		vtkXMLReader_SetInputString_43(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetParserErrorObserver_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get the ErrorObserver for the internal xml parser
	/// This is useful for applications that want to catch error messages.
	/// </summary>
	public void SetParserErrorObserver(vtkCommand arg0)
	{
		vtkXMLReader_SetParserErrorObserver_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetPointArrayStatus_45(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the point, cell, column or time array with the given name is to
	/// be read.
	/// </summary>
	public void SetPointArrayStatus(string name, int status)
	{
		vtkXMLReader_SetPointArrayStatus_45(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetReadFromInputString_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading from an InputString instead of the default, a file.
	/// </summary>
	public virtual void SetReadFromInputString(int _arg)
	{
		vtkXMLReader_SetReadFromInputString_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetReaderErrorObserver_47(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get the ErrorObserver for the internal reader
	/// This is useful for applications that want to catch error messages.
	/// </summary>
	public void SetReaderErrorObserver(vtkCommand arg0)
	{
		vtkXMLReader_SetReaderErrorObserver_47(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetTimeStep_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Which TimeStep to read.
	/// </summary>
	public virtual void SetTimeStep(int _arg)
	{
		vtkXMLReader_SetTimeStep_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetTimeStepRange_49(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public virtual void SetTimeStepRange(int _arg1, int _arg2)
	{
		vtkXMLReader_SetTimeStepRange_49(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLReader_SetTimeStepRange_50(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public void SetTimeStepRange(IntPtr _arg)
	{
		vtkXMLReader_SetTimeStepRange_50(GetCppThis(), _arg);
	}
}
