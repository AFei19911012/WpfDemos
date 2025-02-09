using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAnnotationLayers
/// </summary>
/// <remarks>
///    Stores a ordered collection of annotation sets
///
///
/// vtkAnnotationLayers stores a vector of annotation layers. Each layer
/// may contain any number of vtkAnnotation objects. The ordering of the
/// layers introduces a prioritization of annotations. Annotations in
/// higher layers may obscure annotations in lower layers.
/// </remarks>
public class vtkAnnotationLayers : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotationLayers";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAnnotationLayers()
	{
		MRClassNameKey = "class vtkAnnotationLayers";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotationLayers"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAnnotationLayers(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLayers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnnotationLayers New()
	{
		vtkAnnotationLayers result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLayers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAnnotationLayers()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAnnotationLayers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLayers_AddAnnotation_01(HandleRef pThis, HandleRef ann);

	/// <summary>
	/// Add an annotation to a layer.
	/// </summary>
	public void AddAnnotation(vtkAnnotation ann)
	{
		vtkAnnotationLayers_AddAnnotation_01(GetCppThis(), ann?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLayers_DeepCopy_02(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Copy data from another data object into this one,
	/// performing a deep copy of member annotations.
	/// </summary>
	public override void DeepCopy(vtkDataObject other)
	{
		vtkAnnotationLayers_DeepCopy_02(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLayers_GetAnnotation_03(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an annotation from a layer.
	/// </summary>
	public vtkAnnotation GetAnnotation(uint idx)
	{
		vtkAnnotation vtkAnnotation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLayers_GetAnnotation_03(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotation2 = (vtkAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotation2.Register(null);
			}
		}
		return vtkAnnotation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLayers_GetCurrentAnnotation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The current annotation associated with this annotation link.
	/// </summary>
	public virtual vtkAnnotation GetCurrentAnnotation()
	{
		vtkAnnotation vtkAnnotation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLayers_GetCurrentAnnotation_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotation2 = (vtkAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotation2.Register(null);
			}
		}
		return vtkAnnotation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLayers_GetCurrentSelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The current selection associated with this annotation link.
	/// This is simply the selection contained in the current annotation.
	/// </summary>
	public virtual vtkSelection GetCurrentSelection()
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLayers_GetCurrentSelection_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLayers_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a vtkAnnotationLayers stored inside an information object.
	/// </summary>
	public new static vtkAnnotationLayers GetData(vtkInformation info)
	{
		vtkAnnotationLayers vtkAnnotationLayers2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLayers_GetData_06(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotationLayers2 = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotationLayers2.Register(null);
			}
		}
		return vtkAnnotationLayers2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLayers_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a vtkAnnotationLayers stored inside an information object.
	/// </summary>
	public new static vtkAnnotationLayers GetData(vtkInformationVector v, int i)
	{
		vtkAnnotationLayers vtkAnnotationLayers2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLayers_GetData_07(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotationLayers2 = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotationLayers2.Register(null);
			}
		}
		return vtkAnnotationLayers2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnnotationLayers_GetDataObjectType_08(HandleRef pThis);

	/// <summary>
	/// Returns `VTK_ANNOTATION`.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkAnnotationLayers_GetDataObjectType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAnnotationLayers_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// The modified time for this object.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAnnotationLayers_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAnnotationLayers_GetNumberOfAnnotations_10(HandleRef pThis);

	/// <summary>
	/// The number of annotations in a specific layer.
	/// </summary>
	public uint GetNumberOfAnnotations()
	{
		return vtkAnnotationLayers_GetNumberOfAnnotations_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnnotationLayers_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAnnotationLayers_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnnotationLayers_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAnnotationLayers_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLayers_Initialize_13(HandleRef pThis);

	/// <summary>
	/// Initialize the data structure to an empty state.
	/// </summary>
	public override void Initialize()
	{
		vtkAnnotationLayers_Initialize_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnnotationLayers_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAnnotationLayers_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnnotationLayers_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAnnotationLayers_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLayers_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAnnotationLayers NewInstance()
	{
		vtkAnnotationLayers result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLayers_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLayers_RemoveAnnotation_18(HandleRef pThis, HandleRef ann);

	/// <summary>
	/// Remove an annotation from a layer.
	/// </summary>
	public void RemoveAnnotation(vtkAnnotation ann)
	{
		vtkAnnotationLayers_RemoveAnnotation_18(GetCppThis(), ann?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnnotationLayers_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnnotationLayers SafeDownCast(vtkObjectBase o)
	{
		vtkAnnotationLayers vtkAnnotationLayers2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnnotationLayers_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotationLayers2 = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotationLayers2.Register(null);
			}
		}
		return vtkAnnotationLayers2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLayers_SetCurrentAnnotation_20(HandleRef pThis, HandleRef ann);

	/// <summary>
	/// The current annotation associated with this annotation link.
	/// </summary>
	public virtual void SetCurrentAnnotation(vtkAnnotation ann)
	{
		vtkAnnotationLayers_SetCurrentAnnotation_20(GetCppThis(), ann?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLayers_SetCurrentSelection_21(HandleRef pThis, HandleRef sel);

	/// <summary>
	/// The current selection associated with this annotation link.
	/// This is simply the selection contained in the current annotation.
	/// </summary>
	public virtual void SetCurrentSelection(vtkSelection sel)
	{
		vtkAnnotationLayers_SetCurrentSelection_21(GetCppThis(), sel?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnnotationLayers_ShallowCopy_22(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Copy data from another data object into this one
	/// which references the same member annotations.
	/// </summary>
	public override void ShallowCopy(vtkDataObject other)
	{
		vtkAnnotationLayers_ShallowCopy_22(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}
}
