using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformationIntegerRequestKey
/// </summary>
/// <remarks>
///    key that can used to request integer values from the pipeline
/// vtkInformationIntegerRequestKey is a vtkInformationIntegerKey that can
/// used to request integer values from upstream. A good example of this is
/// UPDATE_NUMBER_OF_PIECES where downstream can request that upstream provides
/// data partitioned into a certain number of pieces. There are several components
/// that make this work. First, the key will copy itself upstream during
/// REQUEST_UPDATE_EXTENT. Second, after a successful execution, it will stor
/// its value into a data object's information using a specific key defined by
/// its data member DataKey. Third, before execution, it will check if the requested
/// value matched the value in the data object's information. If not, it will ask
/// the pipeline to execute.
///
/// The best way to use this class is to subclass it to set the DataKey data member.
/// This is usually done in the subclass' constructor.
/// </remarks>
public class vtkInformationIntegerRequestKey : vtkInformationIntegerKey
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIntegerRequestKey";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformationIntegerRequestKey()
	{
		MRClassNameKey = "class vtkInformationIntegerRequestKey";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIntegerRequestKey"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformationIntegerRequestKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkInformationIntegerRequestKey_CopyDefaultInformation_01(HandleRef pThis, HandleRef request, HandleRef fromInfo, HandleRef toInfo);

	/// <summary>
	/// Copies the value stored in fromInfo using this key into toInfo
	/// if request has the REQUEST_UPDATE_EXTENT key.
	/// </summary>
	public override void CopyDefaultInformation(vtkInformation request, vtkInformation fromInfo, vtkInformation toInfo)
	{
		vtkInformationIntegerRequestKey_CopyDefaultInformation_01(GetCppThis(), request?.GetCppThis() ?? default(HandleRef), fromInfo?.GetCppThis() ?? default(HandleRef), toInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationIntegerRequestKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformationIntegerRequestKey_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationIntegerRequestKey_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformationIntegerRequestKey_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationIntegerRequestKey_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformationIntegerRequestKey_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationIntegerRequestKey_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformationIntegerRequestKey_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationIntegerRequestKey_MakeKey_06(string name, string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method simply returns a new vtkInformationIntegerRequestKey,
	/// given a name and a location. This method is provided for wrappers. Use
	/// the constructor directly from C++ instead.
	/// </summary>
	public new static vtkInformationIntegerRequestKey MakeKey(string name, string location)
	{
		vtkInformationIntegerRequestKey vtkInformationIntegerRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationIntegerRequestKey_MakeKey_06(name, location, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInformationIntegerRequestKey_NeedToExecute_07(HandleRef pThis, HandleRef pipelineInfo, HandleRef dobjInfo);

	/// <summary>
	/// Returns true if a value of type DataKey does not exist in dobjInfo
	/// or if it is different that the value stored in pipelineInfo using
	/// this key.
	/// </summary>
	public override bool NeedToExecute(vtkInformation pipelineInfo, vtkInformation dobjInfo)
	{
		return (vtkInformationIntegerRequestKey_NeedToExecute_07(GetCppThis(), pipelineInfo?.GetCppThis() ?? default(HandleRef), dobjInfo?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationIntegerRequestKey_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInformationIntegerRequestKey NewInstance()
	{
		vtkInformationIntegerRequestKey result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationIntegerRequestKey_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationIntegerRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationIntegerRequestKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformationIntegerRequestKey SafeDownCast(vtkObjectBase o)
	{
		vtkInformationIntegerRequestKey vtkInformationIntegerRequestKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationIntegerRequestKey_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationIntegerRequestKey_StoreMetaData_10(HandleRef pThis, HandleRef request, HandleRef pipelineInfo, HandleRef dobjInfo);

	/// <summary>
	/// Copies the value stored in pipelineInfo using this key into
	/// dobjInfo.
	/// </summary>
	public override void StoreMetaData(vtkInformation request, vtkInformation pipelineInfo, vtkInformation dobjInfo)
	{
		vtkInformationIntegerRequestKey_StoreMetaData_10(GetCppThis(), request?.GetCppThis() ?? default(HandleRef), pipelineInfo?.GetCppThis() ?? default(HandleRef), dobjInfo?.GetCppThis() ?? default(HandleRef));
	}
}
