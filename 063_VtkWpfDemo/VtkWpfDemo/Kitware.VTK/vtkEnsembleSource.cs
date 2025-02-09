using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEnsembleSource
/// </summary>
/// <remarks>
///    source that manages dataset ensembles
///
/// vtkEnsembleSource manages a collection of data sources in order to
/// represent a dataset ensemble. It has the ability to provide meta-data
/// about the ensemble in the form of a table, using the META_DATA key
/// as well as accept a pipeline request using the UPDATE_MEMBER key.
/// Note that it is expected that all ensemble members produce data of the
/// same type.
/// </remarks>
public class vtkEnsembleSource : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEnsembleSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEnsembleSource()
	{
		MRClassNameKey = "class vtkEnsembleSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnsembleSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEnsembleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnsembleSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEnsembleSource New()
	{
		vtkEnsembleSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnsembleSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEnsembleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEnsembleSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEnsembleSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnsembleSource_AddMember_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add an algorithm (source) that will produce the next ensemble member.
	/// This algorithm will be passed the REQUEST_INFORMATION, REQUEST_UPDATE_EXTENT
	/// and REQUEST_DATA pipeline passes for execution.
	/// </summary>
	public void AddMember(vtkAlgorithm arg0)
	{
		vtkEnsembleSource_AddMember_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkEnsembleSource_GetCurrentMember_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the current ensemble member to process. Note that this data member
	/// will not be used if the UPDATE_MEMBER key is present in the pipeline. Also,
	/// this data member may be removed in the future. Unless it is absolutely necessary
	/// to use this data member, use the UPDATE_MEMBER key instead.
	/// </summary>
	public virtual uint GetCurrentMember()
	{
		return vtkEnsembleSource_GetCurrentMember_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEnsembleSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEnsembleSource_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEnsembleSource_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEnsembleSource_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkEnsembleSource_GetNumberOfMembers_05(HandleRef pThis);

	/// <summary>
	/// Returns the number of ensemble members.
	/// </summary>
	public uint GetNumberOfMembers()
	{
		return vtkEnsembleSource_GetNumberOfMembers_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnsembleSource_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEnsembleSource_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnsembleSource_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEnsembleSource_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnsembleSource_META_DATA_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Meta-data for the ensemble. This is set with SetMetaData.
	/// </summary>
	public static vtkInformationDataObjectMetaDataKey META_DATA()
	{
		vtkInformationDataObjectMetaDataKey vtkInformationDataObjectMetaDataKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnsembleSource_META_DATA_08(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkEnsembleSource_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEnsembleSource NewInstance()
	{
		vtkEnsembleSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnsembleSource_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEnsembleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnsembleSource_RemoveAllMembers_11(HandleRef pThis);

	/// <summary>
	/// Removes all ensemble members.
	/// </summary>
	public void RemoveAllMembers()
	{
		vtkEnsembleSource_RemoveAllMembers_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnsembleSource_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEnsembleSource SafeDownCast(vtkObjectBase o)
	{
		vtkEnsembleSource vtkEnsembleSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnsembleSource_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEnsembleSource2 = (vtkEnsembleSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEnsembleSource2.Register(null);
			}
		}
		return vtkEnsembleSource2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnsembleSource_SetCurrentMember_13(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get the current ensemble member to process. Note that this data member
	/// will not be used if the UPDATE_MEMBER key is present in the pipeline. Also,
	/// this data member may be removed in the future. Unless it is absolutely necessary
	/// to use this data member, use the UPDATE_MEMBER key instead.
	/// </summary>
	public virtual void SetCurrentMember(uint _arg)
	{
		vtkEnsembleSource_SetCurrentMember_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnsembleSource_SetMetaData_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the meta-data that will be propagated downstream. Make sure that this table
	/// has as many rows as the ensemble members and the meta-data for each row matches
	/// the corresponding ensemble source.
	/// </summary>
	public void SetMetaData(vtkTable arg0)
	{
		vtkEnsembleSource_SetMetaData_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnsembleSource_UPDATE_MEMBER_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key used to request a particular ensemble member.
	/// </summary>
	public static vtkInformationIntegerRequestKey UPDATE_MEMBER()
	{
		vtkInformationIntegerRequestKey vtkInformationIntegerRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnsembleSource_UPDATE_MEMBER_15(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerRequestKey2 = (vtkInformationIntegerRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerRequestKey2.Register(null);
			}
		}
		return vtkInformationIntegerRequestKey2;
	}
}
