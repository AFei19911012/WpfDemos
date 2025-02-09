using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLUniformGridAMRReader
/// </summary>
/// <remarks>
///    Reader for amr datasets (vtkOverlappingAMR
/// or vtkNonOverlappingAMR).
///
/// vtkXMLUniformGridAMRReader reads the VTK XML data files for all types of amr
/// datasets including vtkOverlappingAMR, vtkNonOverlappingAMR and the legacy
/// vtkHierarchicalBoxDataSet. The reader uses information in the file to
/// determine what type of dataset is actually being read and creates the
/// output-data object accordingly.
///
/// This reader can only read files with version 1.1 or greater.
/// Older versions can be converted to the newer versions using
/// vtkXMLHierarchicalBoxDataFileConverter.
/// </remarks>
public class vtkXMLUniformGridAMRReader : vtkXMLCompositeDataReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUniformGridAMRReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLUniformGridAMRReader()
	{
		MRClassNameKey = "class vtkXMLUniformGridAMRReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUniformGridAMRReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLUniformGridAMRReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUniformGridAMRReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLUniformGridAMRReader New()
	{
		vtkXMLUniformGridAMRReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUniformGridAMRReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLUniformGridAMRReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLUniformGridAMRReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLUniformGridAMRReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkXMLUniformGridAMRReader_GetMaximumLevelsToReadByDefault_01(HandleRef pThis);

	/// <summary>
	/// This reader supports demand-driven heavy data reading i.e. downstream
	/// pipeline can request specific blocks from the AMR using
	/// vtkCompositeDataPipeline::UPDATE_COMPOSITE_INDICES() key in
	/// RequestUpdateExtent() pass. However, when down-stream doesn't provide any
	/// specific keys, the default behavior can be setup to read at-most N levels
	/// by default. The number of levels read can be set using this method.
	/// Set this to 0 to imply no limit. Default is 0.
	/// </summary>
	public virtual uint GetMaximumLevelsToReadByDefault()
	{
		return vtkXMLUniformGridAMRReader_GetMaximumLevelsToReadByDefault_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUniformGridAMRReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLUniformGridAMRReader_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUniformGridAMRReader_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLUniformGridAMRReader_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUniformGridAMRReader_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLUniformGridAMRReader_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUniformGridAMRReader_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLUniformGridAMRReader_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUniformGridAMRReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLUniformGridAMRReader NewInstance()
	{
		vtkXMLUniformGridAMRReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUniformGridAMRReader_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLUniformGridAMRReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUniformGridAMRReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLUniformGridAMRReader SafeDownCast(vtkObjectBase o)
	{
		vtkXMLUniformGridAMRReader vtkXMLUniformGridAMRReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUniformGridAMRReader_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLUniformGridAMRReader2 = (vtkXMLUniformGridAMRReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLUniformGridAMRReader2.Register(null);
			}
		}
		return vtkXMLUniformGridAMRReader2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLUniformGridAMRReader_SetMaximumLevelsToReadByDefault_09(HandleRef pThis, uint _arg);

	/// <summary>
	/// This reader supports demand-driven heavy data reading i.e. downstream
	/// pipeline can request specific blocks from the AMR using
	/// vtkCompositeDataPipeline::UPDATE_COMPOSITE_INDICES() key in
	/// RequestUpdateExtent() pass. However, when down-stream doesn't provide any
	/// specific keys, the default behavior can be setup to read at-most N levels
	/// by default. The number of levels read can be set using this method.
	/// Set this to 0 to imply no limit. Default is 0.
	/// </summary>
	public virtual void SetMaximumLevelsToReadByDefault(uint _arg)
	{
		vtkXMLUniformGridAMRReader_SetMaximumLevelsToReadByDefault_09(GetCppThis(), _arg);
	}
}
