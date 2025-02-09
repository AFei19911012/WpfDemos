using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformationDataObjectMetaDataKey
/// </summary>
/// <remarks>
///    key used to define meta-data of type vtkDataObject
/// vtkInformationDataObjectMetaDataKey is a vtkInformationDataObjectKey
/// that (shallow) copies itself downstream during the REQUEST_INFORMATION pass. Hence
/// it can be used to provide meta-data of type vtkDataObject or any subclass.
/// </remarks>
public class vtkInformationDataObjectMetaDataKey : vtkInformationDataObjectKey
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformationDataObjectMetaDataKey";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformationDataObjectMetaDataKey()
	{
		MRClassNameKey = "class vtkInformationDataObjectMetaDataKey";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationDataObjectMetaDataKey"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformationDataObjectMetaDataKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkInformationDataObjectMetaDataKey_CopyDefaultInformation_01(HandleRef pThis, HandleRef request, HandleRef fromInfo, HandleRef toInfo);

	/// <summary>
	/// Simply shallow copies the key from fromInfo to toInfo if request
	/// has the REQUEST_INFORMATION() key.
	/// This is used by the pipeline to propagate this key downstream.
	/// </summary>
	public override void CopyDefaultInformation(vtkInformation request, vtkInformation fromInfo, vtkInformation toInfo)
	{
		vtkInformationDataObjectMetaDataKey_CopyDefaultInformation_01(GetCppThis(), request?.GetCppThis() ?? default(HandleRef), fromInfo?.GetCppThis() ?? default(HandleRef), toInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationDataObjectMetaDataKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformationDataObjectMetaDataKey_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationDataObjectMetaDataKey_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformationDataObjectMetaDataKey_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationDataObjectMetaDataKey_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformationDataObjectMetaDataKey_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationDataObjectMetaDataKey_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformationDataObjectMetaDataKey_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationDataObjectMetaDataKey_MakeKey_06(string name, string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method simply returns a new vtkInformationDataObjectMetaDataKey, given a
	/// name and a location. This method is provided for wrappers. Use the
	/// constructor directly from C++ instead.
	/// </summary>
	public new static vtkInformationDataObjectMetaDataKey MakeKey(string name, string location)
	{
		vtkInformationDataObjectMetaDataKey vtkInformationDataObjectMetaDataKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationDataObjectMetaDataKey_MakeKey_06(name, location, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDataObjectMetaDataKey2 = (vtkInformationDataObjectMetaDataKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDataObjectMetaDataKey2.Register(null);
			}
		}
		return vtkInformationDataObjectMetaDataKey2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationDataObjectMetaDataKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInformationDataObjectMetaDataKey NewInstance()
	{
		vtkInformationDataObjectMetaDataKey result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationDataObjectMetaDataKey_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationDataObjectMetaDataKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationDataObjectMetaDataKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformationDataObjectMetaDataKey SafeDownCast(vtkObjectBase o)
	{
		vtkInformationDataObjectMetaDataKey vtkInformationDataObjectMetaDataKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationDataObjectMetaDataKey_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDataObjectMetaDataKey2 = (vtkInformationDataObjectMetaDataKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDataObjectMetaDataKey2.Register(null);
			}
		}
		return vtkInformationDataObjectMetaDataKey2;
	}
}
