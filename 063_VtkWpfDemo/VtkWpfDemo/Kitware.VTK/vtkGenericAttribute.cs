using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericAttribute
/// </summary>
/// <remarks>
///    abstract class defined API for attribute data
///
/// vtkGenericAttribute is an abstract class that defines an API for attribute
/// data. Attribute data is data associated with the topology or geometry of
/// a dataset (i.e., points, cells, etc.). vtkGenericAttribute is part of the
/// adaptor framework (see GenericFiltering/README.html).
///
/// vtkGenericAttribute provides a more general interface to attribute data
/// than its counterpart vtkDataArray (which assumes a linear, contiguous
/// array). It adopts an iterator interface, and allows attributes to be
/// associated with points, edges, faces, or edges.
/// </remarks>
public abstract class vtkGenericAttribute : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericAttribute";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericAttribute()
	{
		MRClassNameKey = "class vtkGenericAttribute";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericAttribute"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericAttribute(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttribute_DeepCopy_01(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Recursive duplication of `other' in `this'.
	/// \pre other_exists: other!=0
	/// \pre not_self: other!=this
	/// </summary>
	public virtual void DeepCopy(vtkGenericAttribute other)
	{
		vtkGenericAttribute_DeepCopy_01(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkGenericAttribute_GetActualMemorySize_02(HandleRef pThis);

	/// <summary>
	/// Size in kibibytes (1024 bytes) taken by the attribute.
	/// </summary>
	public virtual uint GetActualMemorySize()
	{
		return vtkGenericAttribute_GetActualMemorySize_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttribute_GetCentering_03(HandleRef pThis);

	/// <summary>
	/// Is the attribute centered either on points, cells or boundaries?
	/// \post valid_result: (result==vtkPointCentered)||(result==vtkCellCentered)
	/// </summary>
	public virtual int GetCentering()
	{
		return vtkGenericAttribute_GetCentering_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttribute_GetComponent_04(HandleRef pThis, int i, HandleRef c, IntPtr values);

	/// <summary>
	/// Put component `i' of the attribute at all points of cell `c' in `values'.
	/// \pre valid_component: (i&gt;=0) &amp;&amp; (i&lt;GetNumberOfComponents())
	/// \pre c_exists: c!=0
	/// \pre c_valid: !c-&gt;IsAtEnd()
	/// \pre values_exist: values!=0
	/// \pre valid_values: sizeof(values)&gt;=c-&gt;GetCell()-&gt;GetNumberOfPoints()
	/// </summary>
	public virtual void GetComponent(int i, vtkGenericCellIterator c, IntPtr values)
	{
		vtkGenericAttribute_GetComponent_04(GetCppThis(), i, c?.GetCppThis() ?? default(HandleRef), values);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericAttribute_GetComponent_05(HandleRef pThis, int i, HandleRef p);

	/// <summary>
	/// Value of the component `i' of the attribute at position `p'.
	/// \pre valid_component: (i&gt;=0) &amp;&amp; (i&lt;GetNumberOfComponents())
	/// \pre p_exists: p!=0
	/// \pre p_valid: !p-&gt;IsAtEnd()
	/// </summary>
	public virtual double GetComponent(int i, vtkGenericPointIterator p)
	{
		return vtkGenericAttribute_GetComponent_05(GetCppThis(), i, p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttribute_GetComponentType_06(HandleRef pThis);

	/// <summary>
	/// Type of the components of the attribute: int, float, double
	/// \post valid_result: (result==VTK_BIT)           ||(result==VTK_CHAR)
	/// ||(result==VTK_UNSIGNED_CHAR) ||(result==VTK_SHORT)
	/// ||(result==VTK_UNSIGNED_SHORT)||(result==VTK_INT)
	/// ||(result==VTK_UNSIGNED_INT)  ||(result==VTK_LONG)
	/// ||(result==VTK_UNSIGNED_LONG) ||(result==VTK_FLOAT)
	/// ||(result==VTK_DOUBLE)        ||(result==VTK_ID_TYPE)
	/// </summary>
	public virtual int GetComponentType()
	{
		return vtkGenericAttribute_GetComponentType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericAttribute_GetMaxNorm_07(HandleRef pThis);

	/// <summary>
	/// Return the maximum euclidean norm for the tuples.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual double GetMaxNorm()
	{
		return vtkGenericAttribute_GetMaxNorm_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttribute_GetName_08(HandleRef pThis);

	/// <summary>
	/// Name of the attribute. (e.g. "velocity")
	/// \post result_may_not_exist: result!=0 || result==0
	/// </summary>
	public virtual string GetName()
	{
		return Marshal.PtrToStringAnsi(vtkGenericAttribute_GetName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttribute_GetNumberOfComponents_09(HandleRef pThis);

	/// <summary>
	/// Dimension of the attribute. (1 for scalar, 3 for velocity)
	/// \post positive_result: result&gt;=0
	/// \post GetType()==VTK_SCALARS implies result==1
	/// \post (GetType()==VTK_VECTORS||(GetType()==VTK_NORMALS)||(GetType()==VTK_TCOORDS) implies
	/// result==3 \post GetType()==VTK_TENSORS implies result==6
	/// </summary>
	public virtual int GetNumberOfComponents()
	{
		return vtkGenericAttribute_GetNumberOfComponents_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericAttribute_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericAttribute_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericAttribute_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericAttribute_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttribute_GetRange_12(HandleRef pThis, int component);

	/// <summary>
	/// Range of the attribute component `component'. If `component'==-1, it
	/// returns the range of the magnitude (euclidean norm).
	/// It returns double, even if GetType()==VTK_INT.
	/// NOT THREAD SAFE
	/// \pre valid_component: (component&gt;=-1)&amp;&amp;(component&lt;GetNumberOfComponents())
	/// \post result_exists: result!=0
	/// </summary>
	public virtual IntPtr GetRange(int component)
	{
		return vtkGenericAttribute_GetRange_12(GetCppThis(), component);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttribute_GetRange_13(HandleRef pThis, int component, IntPtr range);

	/// <summary>
	/// Range of the attribute component `component'. If `component'==-1, it
	/// returns the range of the magnitude (euclidean norm).
	/// THREAD SAFE
	/// \pre valid_component: (component&gt;=-1)&amp;&amp;(component&lt;GetNumberOfComponents())
	/// </summary>
	public virtual void GetRange(int component, IntPtr range)
	{
		vtkGenericAttribute_GetRange_13(GetCppThis(), component, range);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericAttribute_GetSize_14(HandleRef pThis);

	/// <summary>
	/// Number of tuples.
	/// \post valid_result: result&gt;=0
	/// </summary>
	public virtual long GetSize()
	{
		return vtkGenericAttribute_GetSize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttribute_GetTuple_15(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Attribute at all points of cell `c'.
	/// \pre c_exists: c!=0
	/// \pre c_valid: !c-&gt;IsAtEnd()
	/// \post result_exists: result!=0
	/// \post valid_result: sizeof(result)==GetNumberOfComponents()*c-&gt;GetCell()-&gt;GetNumberOfPoints()
	/// </summary>
	public virtual IntPtr GetTuple(vtkGenericAdaptorCell c)
	{
		return vtkGenericAttribute_GetTuple_15(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttribute_GetTuple_16(HandleRef pThis, HandleRef c, IntPtr tuple);

	/// <summary>
	/// Put attribute at all points of cell `c' in `tuple'.
	/// \pre c_exists: c!=0
	/// \pre c_valid: !c-&gt;IsAtEnd()
	/// \pre tuple_exists: tuple!=0
	/// \pre valid_tuple: sizeof(tuple)&gt;=GetNumberOfComponents()*c-&gt;GetCell()-&gt;GetNumberOfPoints()
	/// </summary>
	public virtual void GetTuple(vtkGenericAdaptorCell c, IntPtr tuple)
	{
		vtkGenericAttribute_GetTuple_16(GetCppThis(), c?.GetCppThis() ?? default(HandleRef), tuple);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttribute_GetTuple_17(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Attribute at all points of cell `c'.
	/// \pre c_exists: c!=0
	/// \pre c_valid: !c-&gt;IsAtEnd()
	/// \post result_exists: result!=0
	/// \post valid_result: sizeof(result)==GetNumberOfComponents()*c-&gt;GetCell()-&gt;GetNumberOfPoints()
	/// </summary>
	public virtual IntPtr GetTuple(vtkGenericCellIterator c)
	{
		return vtkGenericAttribute_GetTuple_17(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttribute_GetTuple_18(HandleRef pThis, HandleRef c, IntPtr tuple);

	/// <summary>
	/// Put attribute at all points of cell `c' in `tuple'.
	/// \pre c_exists: c!=0
	/// \pre c_valid: !c-&gt;IsAtEnd()
	/// \pre tuple_exists: tuple!=0
	/// \pre valid_tuple: sizeof(tuple)&gt;=GetNumberOfComponents()*c-&gt;GetCell()-&gt;GetNumberOfPoints()
	/// </summary>
	public virtual void GetTuple(vtkGenericCellIterator c, IntPtr tuple)
	{
		vtkGenericAttribute_GetTuple_18(GetCppThis(), c?.GetCppThis() ?? default(HandleRef), tuple);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttribute_GetTuple_19(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Value of the attribute at position `p'.
	/// \pre p_exists: p!=0
	/// \pre p_valid: !p-&gt;IsAtEnd()
	/// \post result_exists: result!=0
	/// \post valid_result_size: sizeof(result)==GetNumberOfComponents()
	/// </summary>
	public virtual IntPtr GetTuple(vtkGenericPointIterator p)
	{
		return vtkGenericAttribute_GetTuple_19(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttribute_GetTuple_20(HandleRef pThis, HandleRef p, IntPtr tuple);

	/// <summary>
	/// Put the value of the attribute at position `p' into `tuple'.
	/// \pre p_exists: p!=0
	/// \pre p_valid: !p-&gt;IsAtEnd()
	/// \pre tuple_exists: tuple!=0
	/// \pre valid_tuple_size: sizeof(tuple)&gt;=GetNumberOfComponents()
	/// </summary>
	public virtual void GetTuple(vtkGenericPointIterator p, IntPtr tuple)
	{
		vtkGenericAttribute_GetTuple_20(GetCppThis(), p?.GetCppThis() ?? default(HandleRef), tuple);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttribute_GetType_21(HandleRef pThis);

	/// <summary>
	/// Type of the attribute: scalar, vector, normal, texture coordinate, tensor
	/// \post valid_result: (result==vtkDataSetAttributes::SCALARS)
	/// ||(result==vtkDataSetAttributes::VECTORS)
	/// ||(result==vtkDataSetAttributes::NORMALS)
	/// ||(result==vtkDataSetAttributes::TCOORDS)
	/// ||(result==vtkDataSetAttributes::TENSORS)
	/// </summary>
	public virtual int GetTypeWrapper()
	{
		return vtkGenericAttribute_GetType_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttribute_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericAttribute_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttribute_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericAttribute_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttribute_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericAttribute NewInstance()
	{
		vtkGenericAttribute result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericAttribute_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttribute_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericAttribute SafeDownCast(vtkObjectBase o)
	{
		vtkGenericAttribute vtkGenericAttribute2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericAttribute_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAttribute2 = (vtkGenericAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAttribute2.Register(null);
			}
		}
		return vtkGenericAttribute2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttribute_ShallowCopy_26(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Update `this' using fields of `other'.
	/// \pre other_exists: other!=0
	/// \pre not_self: other!=this
	/// </summary>
	public virtual void ShallowCopy(vtkGenericAttribute other)
	{
		vtkGenericAttribute_ShallowCopy_26(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}
}
