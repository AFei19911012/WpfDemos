using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInformationVector
/// </summary>
/// <remarks>
///    Store zero or more vtkInformation instances.
///
///
/// vtkInformationVector stores a vector of zero or more vtkInformation
/// objects corresponding to the input or output information for a
/// vtkAlgorithm.  An instance of this class is passed to
/// vtkAlgorithm::ProcessRequest calls.
/// </remarks>
public class vtkInformationVector : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInformationVector";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInformationVector()
	{
		MRClassNameKey = "class vtkInformationVector";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationVector"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInformationVector(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationVector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformationVector New()
	{
		vtkInformationVector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationVector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInformationVector()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInformationVector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationVector_Append_01(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Append/Remove an information object.
	/// </summary>
	public void Append(vtkInformation info)
	{
		vtkInformationVector_Append_01(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationVector_Copy_02(HandleRef pThis, HandleRef from, int deep);

	/// <summary>
	/// Copy all information entries from the given vtkInformation
	/// instance.  Any previously existing entries are removed.  If
	/// deep==1, a deep copy of the information structure is performed (new
	/// instances of any contained vtkInformation and vtkInformationVector
	/// objects are created).
	/// </summary>
	public void Copy(vtkInformationVector from, int deep)
	{
		vtkInformationVector_Copy_02(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationVector_GetInformationObject_03(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the vtkInformation instance stored at the given index in
	/// the vector.  The vector will automatically expand to include the
	/// index given if necessary.  Missing entries in-between will be
	/// filled with empty vtkInformation instances.
	/// </summary>
	public vtkInformation GetInformationObject(int index)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationVector_GetInformationObject_03(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationVector_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInformationVector_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInformationVector_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInformationVector_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationVector_GetNumberOfInformationObjects_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of information objects in the vector.  Setting
	/// the number to larger than the current number will create empty
	/// vtkInformation instances.  Setting the number to smaller than the
	/// current number will remove entries from higher indices.
	/// </summary>
	public int GetNumberOfInformationObjects()
	{
		return vtkInformationVector_GetNumberOfInformationObjects_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationVector_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInformationVector_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInformationVector_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInformationVector_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationVector_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInformationVector NewInstance()
	{
		vtkInformationVector result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationVector_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationVector_Remove_11(HandleRef pThis, HandleRef info);

	/// <summary>
	/// Append/Remove an information object.
	/// </summary>
	public void Remove(vtkInformation info)
	{
		vtkInformationVector_Remove_11(GetCppThis(), info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationVector_Remove_12(HandleRef pThis, int idx);

	/// <summary>
	/// Append/Remove an information object.
	/// </summary>
	public void Remove(int idx)
	{
		vtkInformationVector_Remove_12(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInformationVector_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInformationVector SafeDownCast(vtkObjectBase o)
	{
		vtkInformationVector vtkInformationVector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInformationVector_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationVector2 = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationVector2.Register(null);
			}
		}
		return vtkInformationVector2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationVector_SetInformationObject_14(HandleRef pThis, int index, HandleRef info);

	/// <summary>
	/// Get/Set the vtkInformation instance stored at the given index in
	/// the vector.  The vector will automatically expand to include the
	/// index given if necessary.  Missing entries in-between will be
	/// filled with empty vtkInformation instances.
	/// </summary>
	public void SetInformationObject(int index, vtkInformation info)
	{
		vtkInformationVector_SetInformationObject_14(GetCppThis(), index, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInformationVector_SetNumberOfInformationObjects_15(HandleRef pThis, int n);

	/// <summary>
	/// Get/Set the number of information objects in the vector.  Setting
	/// the number to larger than the current number will create empty
	/// vtkInformation instances.  Setting the number to smaller than the
	/// current number will remove entries from higher indices.
	/// </summary>
	public void SetNumberOfInformationObjects(int n)
	{
		vtkInformationVector_SetNumberOfInformationObjects_15(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInformationVector_UsesGarbageCollector_16(HandleRef pThis);

	/// <summary>
	/// Initiate garbage collection when a reference is removed.
	/// </summary>
	public override bool UsesGarbageCollector()
	{
		return (vtkInformationVector_UsesGarbageCollector_16(GetCppThis()) != 0) ? true : false;
	}
}
