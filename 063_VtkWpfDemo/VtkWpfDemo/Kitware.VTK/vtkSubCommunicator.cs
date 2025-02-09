using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSubCommunicator
/// </summary>
/// <remarks>
///    Provides communication on a process group.
///
///
///
/// This class provides an implementation for communicating on process groups.
/// In general, you should never use this class directly.  Instead, use the
/// vtkMultiProcessController::CreateSubController method.
///
///
/// @bug
/// Because all communication is delegated to the original communicator,
/// any error will report process ids with respect to the original
/// communicator, not this communicator that was actually used.
///
/// </remarks>
/// <seealso>
///
/// vtkCommunicator, vtkMultiProcessController
///
/// @par Thanks:
/// This class was originally written by Kenneth Moreland (kmorelndia.gov)
/// from Sandia National Laboratories.
///
/// </seealso>
public class vtkSubCommunicator : vtkCommunicator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSubCommunicator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSubCommunicator()
	{
		MRClassNameKey = "class vtkSubCommunicator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubCommunicator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSubCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubCommunicator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSubCommunicator New()
	{
		vtkSubCommunicator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubCommunicator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSubCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSubCommunicator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSubCommunicator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubCommunicator_GetGroup_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the group on which communication will happen.
	/// </summary>
	public virtual vtkProcessGroup GetGroup()
	{
		vtkProcessGroup vtkProcessGroup2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubCommunicator_GetGroup_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProcessGroup2 = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProcessGroup2.Register(null);
			}
		}
		return vtkProcessGroup2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSubCommunicator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSubCommunicator_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSubCommunicator_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSubCommunicator_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubCommunicator_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSubCommunicator_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubCommunicator_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSubCommunicator_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubCommunicator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSubCommunicator NewInstance()
	{
		vtkSubCommunicator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubCommunicator_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSubCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubCommunicator_ReceiveVoidArray_08(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

	/// <summary>
	/// Implementation for abstract supercalss.
	/// </summary>
	public override int ReceiveVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
	{
		return vtkSubCommunicator_ReceiveVoidArray_08(GetCppThis(), data, length, type, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubCommunicator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSubCommunicator SafeDownCast(vtkObjectBase o)
	{
		vtkSubCommunicator vtkSubCommunicator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubCommunicator_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSubCommunicator2 = (vtkSubCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSubCommunicator2.Register(null);
			}
		}
		return vtkSubCommunicator2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubCommunicator_SendVoidArray_10(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

	/// <summary>
	/// Implementation for abstract supercalss.
	/// </summary>
	public override int SendVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
	{
		return vtkSubCommunicator_SendVoidArray_10(GetCppThis(), data, length, type, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubCommunicator_SetGroup_11(HandleRef pThis, HandleRef group);

	/// <summary>
	/// Set/get the group on which communication will happen.
	/// </summary>
	public virtual void SetGroup(vtkProcessGroup group)
	{
		vtkSubCommunicator_SetGroup_11(GetCppThis(), group?.GetCppThis() ?? default(HandleRef));
	}
}
