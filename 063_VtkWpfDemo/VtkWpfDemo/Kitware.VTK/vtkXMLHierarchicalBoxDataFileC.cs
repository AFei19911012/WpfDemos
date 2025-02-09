using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLHierarchicalBoxDataFileConverter
/// </summary>
/// <remarks>
///    converts older *.vth, *.vthb
/// files to newer format.
///
/// vtkXMLHierarchicalBoxDataFileConverter is a utility class to convert v0.1 and
/// v1.0 of the VTK XML hierarchical file format to the v1.1. Users can then use
/// vtkXMLUniformGridAMRReader to read the dataset into VTK.
/// </remarks>
public class vtkXMLHierarchicalBoxDataFileConverter : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLHierarchicalBoxDataFileConverter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLHierarchicalBoxDataFileConverter()
	{
		MRClassNameKey = "class vtkXMLHierarchicalBoxDataFileConverter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLHierarchicalBoxDataFileConverter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLHierarchicalBoxDataFileConverter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLHierarchicalBoxDataFileConverter New()
	{
		vtkXMLHierarchicalBoxDataFileConverter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLHierarchicalBoxDataFileConverter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLHierarchicalBoxDataFileConverter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLHierarchicalBoxDataFileConverter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLHierarchicalBoxDataFileConverter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLHierarchicalBoxDataFileConverter_Convert_01(HandleRef pThis);

	/// <summary>
	/// Converts the input file to new format and writes out the output file.
	/// </summary>
	public bool Convert()
	{
		return (vtkXMLHierarchicalBoxDataFileConverter_Convert_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_GetInputFileName_02(HandleRef pThis);

	/// <summary>
	/// Set the input filename.
	/// </summary>
	public virtual string GetInputFileName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLHierarchicalBoxDataFileConverter_GetInputFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLHierarchicalBoxDataFileConverter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLHierarchicalBoxDataFileConverter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLHierarchicalBoxDataFileConverter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLHierarchicalBoxDataFileConverter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_GetOutputFileName_05(HandleRef pThis);

	/// <summary>
	/// Set the output filename.
	/// </summary>
	public virtual string GetOutputFileName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLHierarchicalBoxDataFileConverter_GetOutputFileName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLHierarchicalBoxDataFileConverter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLHierarchicalBoxDataFileConverter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLHierarchicalBoxDataFileConverter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLHierarchicalBoxDataFileConverter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLHierarchicalBoxDataFileConverter NewInstance()
	{
		vtkXMLHierarchicalBoxDataFileConverter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLHierarchicalBoxDataFileConverter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLHierarchicalBoxDataFileConverter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLHierarchicalBoxDataFileConverter SafeDownCast(vtkObjectBase o)
	{
		vtkXMLHierarchicalBoxDataFileConverter vtkXMLHierarchicalBoxDataFileConverter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLHierarchicalBoxDataFileConverter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLHierarchicalBoxDataFileConverter2 = (vtkXMLHierarchicalBoxDataFileConverter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLHierarchicalBoxDataFileConverter2.Register(null);
			}
		}
		return vtkXMLHierarchicalBoxDataFileConverter2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLHierarchicalBoxDataFileConverter_SetInputFileName_11(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the input filename.
	/// </summary>
	public virtual void SetInputFileName(string _arg)
	{
		vtkXMLHierarchicalBoxDataFileConverter_SetInputFileName_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLHierarchicalBoxDataFileConverter_SetOutputFileName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the output filename.
	/// </summary>
	public virtual void SetOutputFileName(string _arg)
	{
		vtkXMLHierarchicalBoxDataFileConverter_SetOutputFileName_12(GetCppThis(), _arg);
	}
}
