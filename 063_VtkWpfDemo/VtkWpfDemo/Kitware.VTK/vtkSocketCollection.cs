using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSocketCollection
/// </summary>
/// <remarks>
///     a collection for sockets.
///
/// Apart from being vtkCollection subclass for sockets, this class
/// provides means to wait for activity on all the sockets in the
/// collection simultaneously.
/// </remarks>
public class vtkSocketCollection : vtkCollection
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSocketCollection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSocketCollection()
	{
		MRClassNameKey = "class vtkSocketCollection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocketCollection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSocketCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSocketCollection New()
	{
		vtkSocketCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSocketCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSocketCollection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSocketCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCollection_AddItem_01(HandleRef pThis, HandleRef soc);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void AddItem(vtkSocket soc)
	{
		vtkSocketCollection_AddItem_01(GetCppThis(), soc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketCollection_GetLastSelectedSocket_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the socket selected during the last SelectSockets(), if any.
	/// nullptr otherwise.
	/// </summary>
	public vtkSocket GetLastSelectedSocket()
	{
		vtkSocket vtkSocket2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketCollection_GetLastSelectedSocket_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSocket2 = (vtkSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSocket2.Register(null);
			}
		}
		return vtkSocket2;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSocketCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSocketCollection_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSocketCollection_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSocketCollection_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCollection_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSocketCollection_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCollection_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSocketCollection_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSocketCollection NewInstance()
	{
		vtkSocketCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketCollection_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSocketCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCollection_RemoveAllItems_09(HandleRef pThis);

	/// <summary>
	/// Overridden to unset SelectedSocket.
	/// </summary>
	public new void RemoveAllItems()
	{
		vtkSocketCollection_RemoveAllItems_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCollection_RemoveItem_10(HandleRef pThis, int i);

	/// <summary>
	/// Overridden to unset SelectedSocket.
	/// </summary>
	public new void RemoveItem(int i)
	{
		vtkSocketCollection_RemoveItem_10(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCollection_RemoveItem_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Overridden to unset SelectedSocket.
	/// </summary>
	public new void RemoveItem(vtkObject arg0)
	{
		vtkSocketCollection_RemoveItem_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCollection_ReplaceItem_12(HandleRef pThis, int i, HandleRef arg1);

	/// <summary>
	/// Overridden to unset SelectedSocket.
	/// </summary>
	public new void ReplaceItem(int i, vtkObject arg1)
	{
		vtkSocketCollection_ReplaceItem_12(GetCppThis(), i, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketCollection_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSocketCollection SafeDownCast(vtkObjectBase o)
	{
		vtkSocketCollection vtkSocketCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketCollection_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSocketCollection2 = (vtkSocketCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSocketCollection2.Register(null);
			}
		}
		return vtkSocketCollection2;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCollection_SelectSockets_14(HandleRef pThis, uint msec);

	/// <summary>
	/// Select all Connected sockets in the collection. If msec is specified,
	/// it timesout after msec milliseconds on inactivity.
	/// Returns 0 on timeout, -1 on error; 1 is a socket was selected.
	/// The selected socket can be retrieved by GetLastSelectedSocket().
	/// </summary>
	public int SelectSockets(uint msec)
	{
		return vtkSocketCollection_SelectSockets_14(GetCppThis(), msec);
	}
}
