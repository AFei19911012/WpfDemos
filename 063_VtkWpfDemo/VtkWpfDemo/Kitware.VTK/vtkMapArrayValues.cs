using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMapArrayValues
/// </summary>
/// <remarks>
///    Map values in an input array to different values in
///   an output array of (possibly) different type.
///
///
/// vtkMapArrayValues allows you to associate certain values of an attribute array
/// (on either a vertex, edge, point, or cell) with different values in a
/// newly created attribute array.
///
/// vtkMapArrayValues manages an internal STL map of vtkVariants that can be added to
/// or cleared. When this filter executes, each "key" is searched for in the
/// input array and the indices of the output array at which there were matches
/// the set to the mapped "value".
///
/// You can control whether the input array values are passed to the output
/// before the mapping occurs (using PassArray) or, if not, what value to set
/// the unmapped indices to (using FillValue).
///
/// One application of this filter is to help address the dirty data problem.
/// For example, using vtkMapArrayValues you could associate the vertex values
/// "Foo, John", "Foo, John.", and "John Foo" with a single entity.
/// </remarks>
public class vtkMapArrayValues : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Get the size of the internal map.
	/// </summary>
	public enum FieldType
	{
		/// <summary>enum member</summary>
		CELL_DATA = 1,
		/// <summary>enum member</summary>
		EDGE_DATA = 3,
		/// <summary>enum member</summary>
		NUM_ATTRIBUTE_LOCS = 5,
		/// <summary>enum member</summary>
		POINT_DATA = 0,
		/// <summary>enum member</summary>
		ROW_DATA = 4,
		/// <summary>enum member</summary>
		VERTEX_DATA = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMapArrayValues";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMapArrayValues()
	{
		MRClassNameKey = "class vtkMapArrayValues";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapArrayValues"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMapArrayValues(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapArrayValues_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMapArrayValues New()
	{
		vtkMapArrayValues result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapArrayValues_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMapArrayValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMapArrayValues()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMapArrayValues_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_AddToMap_01(HandleRef pThis, HandleRef from, HandleRef to);

	/// <summary>
	/// Add to the internal STL map. "from" should be a value in the input array and
	/// "to" should be the new value it gets assigned in the output array.
	/// </summary>
	public void AddToMap(vtkVariant from, vtkVariant to)
	{
		vtkMapArrayValues_AddToMap_01(GetCppThis(), from?.GetCppThis() ?? default(HandleRef), to?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_AddToMap_02(HandleRef pThis, int from, int to);

	/// <summary>
	/// Add to the internal STL map. "from" should be a value in the input array and
	/// "to" should be the new value it gets assigned in the output array.
	/// </summary>
	public void AddToMap(int from, int to)
	{
		vtkMapArrayValues_AddToMap_02(GetCppThis(), from, to);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_AddToMap_03(HandleRef pThis, int from, string to);

	/// <summary>
	/// Add to the internal STL map. "from" should be a value in the input array and
	/// "to" should be the new value it gets assigned in the output array.
	/// </summary>
	public void AddToMap(int from, string to)
	{
		vtkMapArrayValues_AddToMap_03(GetCppThis(), from, to);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_AddToMap_04(HandleRef pThis, string from, int to);

	/// <summary>
	/// Add to the internal STL map. "from" should be a value in the input array and
	/// "to" should be the new value it gets assigned in the output array.
	/// </summary>
	public void AddToMap(string from, int to)
	{
		vtkMapArrayValues_AddToMap_04(GetCppThis(), from, to);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_AddToMap_05(HandleRef pThis, string from, string to);

	/// <summary>
	/// Add to the internal STL map. "from" should be a value in the input array and
	/// "to" should be the new value it gets assigned in the output array.
	/// </summary>
	public void AddToMap(string from, string to)
	{
		vtkMapArrayValues_AddToMap_05(GetCppThis(), from, to);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_ClearMap_06(HandleRef pThis);

	/// <summary>
	/// Clear the internal map.
	/// </summary>
	public void ClearMap()
	{
		vtkMapArrayValues_ClearMap_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapArrayValues_GetFieldType_07(HandleRef pThis);

	/// <summary>
	/// Set/Get where the data is located that is being mapped.
	/// See FieldType enumeration for possible values.
	/// Default is POINT_DATA.
	/// </summary>
	public virtual int GetFieldType()
	{
		return vtkMapArrayValues_GetFieldType_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMapArrayValues_GetFillValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to copy the data from the input array to the output array
	/// before the mapping occurs. If turned off, FillValue is used to initialize
	/// any unmapped array indices. Default is -1.
	/// </summary>
	public virtual double GetFillValue()
	{
		return vtkMapArrayValues_GetFillValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapArrayValues_GetInputArrayName_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the input array. This must be set prior to execution.
	/// </summary>
	public virtual string GetInputArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMapArrayValues_GetInputArrayName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapArrayValues_GetMapSize_10(HandleRef pThis);

	/// <summary>
	/// Get the size of the internal map.
	/// </summary>
	public int GetMapSize()
	{
		return vtkMapArrayValues_GetMapSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMapArrayValues_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMapArrayValues_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMapArrayValues_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMapArrayValues_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapArrayValues_GetOutputArrayName_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the output array. Default is "ArrayMap".
	/// </summary>
	public virtual string GetOutputArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMapArrayValues_GetOutputArrayName_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapArrayValues_GetOutputArrayType_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of the output array. See vtkSetGet.h for possible values.
	/// Default is VTK_INT.
	/// </summary>
	public virtual int GetOutputArrayType()
	{
		return vtkMapArrayValues_GetOutputArrayType_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapArrayValues_GetPassArray_15(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to copy the data from the input array to the output array
	/// before the mapping occurs. If turned off, FillValue is used to initialize
	/// any unmapped array indices. Default is off.
	/// </summary>
	public virtual int GetPassArray()
	{
		return vtkMapArrayValues_GetPassArray_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapArrayValues_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMapArrayValues_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMapArrayValues_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMapArrayValues_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapArrayValues_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMapArrayValues NewInstance()
	{
		vtkMapArrayValues result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapArrayValues_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMapArrayValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_PassArrayOff_20(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to copy the data from the input array to the output array
	/// before the mapping occurs. If turned off, FillValue is used to initialize
	/// any unmapped array indices. Default is off.
	/// </summary>
	public virtual void PassArrayOff()
	{
		vtkMapArrayValues_PassArrayOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_PassArrayOn_21(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to copy the data from the input array to the output array
	/// before the mapping occurs. If turned off, FillValue is used to initialize
	/// any unmapped array indices. Default is off.
	/// </summary>
	public virtual void PassArrayOn()
	{
		vtkMapArrayValues_PassArrayOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMapArrayValues_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMapArrayValues SafeDownCast(vtkObjectBase o)
	{
		vtkMapArrayValues vtkMapArrayValues2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMapArrayValues_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMapArrayValues2 = (vtkMapArrayValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMapArrayValues2.Register(null);
			}
		}
		return vtkMapArrayValues2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_SetFieldType_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get where the data is located that is being mapped.
	/// See FieldType enumeration for possible values.
	/// Default is POINT_DATA.
	/// </summary>
	public virtual void SetFieldType(int _arg)
	{
		vtkMapArrayValues_SetFieldType_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_SetFillValue_24(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get whether to copy the data from the input array to the output array
	/// before the mapping occurs. If turned off, FillValue is used to initialize
	/// any unmapped array indices. Default is -1.
	/// </summary>
	public virtual void SetFillValue(double _arg)
	{
		vtkMapArrayValues_SetFillValue_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_SetInputArrayName_25(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the input array. This must be set prior to execution.
	/// </summary>
	public virtual void SetInputArrayName(string _arg)
	{
		vtkMapArrayValues_SetInputArrayName_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_SetOutputArrayName_26(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the output array. Default is "ArrayMap".
	/// </summary>
	public virtual void SetOutputArrayName(string _arg)
	{
		vtkMapArrayValues_SetOutputArrayName_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_SetOutputArrayType_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the type of the output array. See vtkSetGet.h for possible values.
	/// Default is VTK_INT.
	/// </summary>
	public virtual void SetOutputArrayType(int _arg)
	{
		vtkMapArrayValues_SetOutputArrayType_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMapArrayValues_SetPassArray_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether to copy the data from the input array to the output array
	/// before the mapping occurs. If turned off, FillValue is used to initialize
	/// any unmapped array indices. Default is off.
	/// </summary>
	public virtual void SetPassArray(int _arg)
	{
		vtkMapArrayValues_SetPassArray_28(GetCppThis(), _arg);
	}
}
