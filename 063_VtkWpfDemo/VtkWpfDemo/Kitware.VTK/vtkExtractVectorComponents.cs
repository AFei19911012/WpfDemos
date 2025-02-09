using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractVectorComponents
/// </summary>
/// <remarks>
///    extract components of vector as separate scalars
///
/// vtkExtractVectorComponents is a filter that extracts vector components as
/// separate scalars. This is accomplished by creating three different outputs.
/// Each output is the same as the input, except that the scalar values will be
/// one of the three components of the vector. These can be found in the
/// VxComponent, VyComponent, and VzComponent.
/// Alternatively, if the ExtractToFieldData flag is set, the filter will
/// put all the components in the field data. The first component will be
/// the scalar and the others will be non-attribute arrays.
///
/// @warning
/// This filter is unusual in that it creates multiple outputs.
/// If you use the GetOutput() method, you will be retrieving the x vector
/// component.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
/// </remarks>
public class vtkExtractVectorComponents : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractVectorComponents";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractVectorComponents()
	{
		MRClassNameKey = "class vtkExtractVectorComponents";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractVectorComponents"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractVectorComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVectorComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractVectorComponents New()
	{
		vtkExtractVectorComponents result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractVectorComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractVectorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractVectorComponents()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractVectorComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVectorComponents_ExtractToFieldDataOff_01(HandleRef pThis);

	/// <summary>
	/// Determines whether the vector components will be put
	/// in separate outputs or in the first output's field data
	/// </summary>
	public virtual void ExtractToFieldDataOff()
	{
		vtkExtractVectorComponents_ExtractToFieldDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVectorComponents_ExtractToFieldDataOn_02(HandleRef pThis);

	/// <summary>
	/// Determines whether the vector components will be put
	/// in separate outputs or in the first output's field data
	/// </summary>
	public virtual void ExtractToFieldDataOn()
	{
		vtkExtractVectorComponents_ExtractToFieldDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractVectorComponents_GetExtractToFieldData_03(HandleRef pThis);

	/// <summary>
	/// Determines whether the vector components will be put
	/// in separate outputs or in the first output's field data
	/// </summary>
	public virtual int GetExtractToFieldData()
	{
		return vtkExtractVectorComponents_GetExtractToFieldData_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractVectorComponents_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractVectorComponents_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractVectorComponents_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractVectorComponents_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVectorComponents_GetVxComponent_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output dataset representing velocity x-component. If output is
	/// nullptr then input hasn't been set, which is necessary for abstract
	/// objects. (Note: this method returns the same information as the
	/// GetOutput() method with an index of 0.)
	/// </summary>
	public vtkDataSet GetVxComponent()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractVectorComponents_GetVxComponent_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVectorComponents_GetVyComponent_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output dataset representing velocity y-component. If output is
	/// nullptr then input hasn't been set, which is necessary for abstract
	/// objects. (Note: this method returns the same information as the
	/// GetOutput() method with an index of 1.)
	/// Note that if ExtractToFieldData is true, this output will be empty.
	/// </summary>
	public vtkDataSet GetVyComponent()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractVectorComponents_GetVyComponent_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVectorComponents_GetVzComponent_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output dataset representing velocity z-component. If output is
	/// nullptr then input hasn't been set, which is necessary for abstract
	/// objects. (Note: this method returns the same information as the
	/// GetOutput() method with an index of 2.)
	/// Note that if ExtractToFieldData is true, this output will be empty.
	/// </summary>
	public vtkDataSet GetVzComponent()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractVectorComponents_GetVzComponent_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractVectorComponents_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractVectorComponents_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractVectorComponents_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractVectorComponents_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVectorComponents_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractVectorComponents NewInstance()
	{
		vtkExtractVectorComponents result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractVectorComponents_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractVectorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractVectorComponents_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractVectorComponents SafeDownCast(vtkObjectBase o)
	{
		vtkExtractVectorComponents vtkExtractVectorComponents2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractVectorComponents_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractVectorComponents2 = (vtkExtractVectorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractVectorComponents2.Register(null);
			}
		}
		return vtkExtractVectorComponents2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVectorComponents_SetExtractToFieldData_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Determines whether the vector components will be put
	/// in separate outputs or in the first output's field data
	/// </summary>
	public virtual void SetExtractToFieldData(int _arg)
	{
		vtkExtractVectorComponents_SetExtractToFieldData_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractVectorComponents_SetInputData_15(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Specify the input data or filter.
	/// </summary>
	public new virtual void SetInputData(vtkDataSet input)
	{
		vtkExtractVectorComponents_SetInputData_15(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}
}
