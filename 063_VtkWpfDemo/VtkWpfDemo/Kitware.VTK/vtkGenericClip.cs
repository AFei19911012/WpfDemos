using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericClip
/// </summary>
/// <remarks>
///    clip any dataset with an implicit function or scalar data
///
/// vtkGenericClip is a filter that any type of dataset using either
/// any subclass of vtkImplicitFunction, or the input scalar
/// data. Clipping means that it actually "cuts" through the cells of
/// the dataset, returning everything inside of the specified implicit
/// function (or greater than the scalar value) including "pieces" of
/// a cell. (Compare this with vtkExtractGeometry, which pulls out
/// entire, uncut cells.) The output of this filter is an unstructured
/// grid.
///
/// To use this filter, you must decide if you will be clipping with an
/// implicit function, or whether you will be using the input scalar
/// data.  If you want to clip with an implicit function, you must:
/// 1) define an implicit function
/// 2) set it with the SetClipFunction method
/// 3) apply the GenerateClipScalarsOn method
/// If a ClipFunction is not specified, or GenerateClipScalars is off
/// (the default), then the input's scalar data will be used to clip
/// the polydata.
///
/// You can also specify a scalar value, which is used to decide what is
/// inside and outside of the implicit function. You can also reverse the
/// sense of what inside/outside is by setting the InsideOut instance
/// variable. (The clipping algorithm proceeds by computing an implicit
/// function value or using the input scalar data for each point in the
/// dataset. This is compared to the scalar value to determine
/// inside/outside.)
///
/// This filter can be configured to compute a second output. The
/// second output is the part of the cell that is clipped away. Set the
/// GenerateClippedData boolean on if you wish to access this output data.
///
/// This filter has been implemented to operate on generic datasets, rather
/// than the typical vtkDataSet (and subclasses). vtkGenericDataSet is a more
/// complex cousin of vtkDataSet, typically consisting of nonlinear,
/// higher-order cells. To process this type of data, generic cells are
/// automatically tessellated into linear cells prior to isocontouring.
///
/// </remarks>
/// <seealso>
///
/// vtkClipDataSet vtkClipPolyData vtkClipVolume vtkImplicitFunction
/// vtkGenericDataSet
/// </seealso>
public class vtkGenericClip : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericClip";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericClip()
	{
		MRClassNameKey = "class vtkGenericClip";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericClip"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with user-specified implicit function; InsideOut turned off;
	/// value set to 0.0; and generate clip scalars turned off.
	/// </summary>
	public new static vtkGenericClip New()
	{
		vtkGenericClip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with user-specified implicit function; InsideOut turned off;
	/// value set to 0.0; and generate clip scalars turned off.
	/// </summary>
	public vtkGenericClip()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified. The
	/// locator is used to merge coincident points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkGenericClip_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_GenerateClipScalarsOff_02(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual void GenerateClipScalarsOff()
	{
		vtkGenericClip_GenerateClipScalarsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_GenerateClipScalarsOn_03(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual void GenerateClipScalarsOn()
	{
		vtkGenericClip_GenerateClipScalarsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_GenerateClippedOutputOff_04(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual void GenerateClippedOutputOff()
	{
		vtkGenericClip_GenerateClippedOutputOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_GenerateClippedOutputOn_05(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual void GenerateClippedOutputOn()
	{
		vtkGenericClip_GenerateClippedOutputOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericClip_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function with which to perform the
	/// clipping. If you do not define an implicit function,
	/// then the selected input scalar data will be used for clipping.
	/// </summary>
	public virtual vtkImplicitFunction GetClipFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericClip_GetClipFunction_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericClip_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the Clipped output.
	/// </summary>
	public vtkUnstructuredGrid GetClippedOutput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericClip_GetClippedOutput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericClip_GetGenerateClipScalars_08(HandleRef pThis);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual int GetGenerateClipScalars()
	{
		return vtkGenericClip_GetGenerateClipScalars_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericClip_GetGenerateClippedOutput_09(HandleRef pThis);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual int GetGenerateClippedOutput()
	{
		return vtkGenericClip_GetGenerateClippedOutput_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericClip_GetInputScalarsSelection_10(HandleRef pThis);

	/// <summary>
	/// If you want to clip by an arbitrary array, then set its name here.
	/// By default this in nullptr and the filter will use the active scalar array.
	/// </summary>
	public virtual string GetInputScalarsSelection()
	{
		return Marshal.PtrToStringAnsi(vtkGenericClip_GetInputScalarsSelection_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericClip_GetInsideOut_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered
	/// inside the implicit function if its value is greater than the
	/// Value ivar. When InsideOutside is turned on, a vertex is
	/// considered inside the implicit function if its implicit function
	/// value is less than or equal to the Value ivar.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual int GetInsideOut()
	{
		return vtkGenericClip_GetInsideOut_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericClip_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a spatial locator for merging points. By default, an
	/// instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericClip_GetLocator_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGenericClip_GetMTime_13(HandleRef pThis);

	/// <summary>
	/// Return the mtime also considering the locator and clip function.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGenericClip_GetMTime_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericClip_GetMergeTolerance_14(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate primitives. Note that only 3D cells actually use this
	/// instance variable.
	/// </summary>
	public virtual double GetMergeTolerance()
	{
		return vtkGenericClip_GetMergeTolerance_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericClip_GetMergeToleranceMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate primitives. Note that only 3D cells actually use this
	/// instance variable.
	/// </summary>
	public virtual double GetMergeToleranceMaxValue()
	{
		return vtkGenericClip_GetMergeToleranceMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericClip_GetMergeToleranceMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate primitives. Note that only 3D cells actually use this
	/// instance variable.
	/// </summary>
	public virtual double GetMergeToleranceMinValue()
	{
		return vtkGenericClip_GetMergeToleranceMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericClip_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericClip_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericClip_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericClip_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericClip_GetNumberOfOutputs_19(HandleRef pThis);

	/// <summary>
	/// Return the Clipped output.
	/// </summary>
	public virtual int GetNumberOfOutputs()
	{
		return vtkGenericClip_GetNumberOfOutputs_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericClip_GetValue_20(HandleRef pThis);

	/// <summary>
	/// Set the clipping value of the implicit function (if clipping with
	/// implicit function) or scalar value (if clipping with
	/// scalars). The default value is 0.0.
	/// </summary>
	public virtual double GetValue()
	{
		return vtkGenericClip_GetValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_InsideOutOff_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered
	/// inside the implicit function if its value is greater than the
	/// Value ivar. When InsideOutside is turned on, a vertex is
	/// considered inside the implicit function if its implicit function
	/// value is less than or equal to the Value ivar.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual void InsideOutOff()
	{
		vtkGenericClip_InsideOutOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_InsideOutOn_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered
	/// inside the implicit function if its value is greater than the
	/// Value ivar. When InsideOutside is turned on, a vertex is
	/// considered inside the implicit function if its implicit function
	/// value is less than or equal to the Value ivar.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual void InsideOutOn()
	{
		vtkGenericClip_InsideOutOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericClip_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericClip_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericClip_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericClip_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericClip_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericClip NewInstance()
	{
		vtkGenericClip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericClip_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericClip_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericClip SafeDownCast(vtkObjectBase o)
	{
		vtkGenericClip vtkGenericClip2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericClip_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericClip2 = (vtkGenericClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericClip2.Register(null);
			}
		}
		return vtkGenericClip2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_SelectInputScalars_28(HandleRef pThis, string fieldName);

	/// <summary>
	/// If you want to clip by an arbitrary array, then set its name here.
	/// By default this in nullptr and the filter will use the active scalar array.
	/// </summary>
	public void SelectInputScalars(string fieldName)
	{
		vtkGenericClip_SelectInputScalars_28(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_SetClipFunction_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function with which to perform the
	/// clipping. If you do not define an implicit function,
	/// then the selected input scalar data will be used for clipping.
	/// </summary>
	public virtual void SetClipFunction(vtkImplicitFunction arg0)
	{
		vtkGenericClip_SetClipFunction_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_SetGenerateClipScalars_30(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is enabled, then the output scalar values will be
	/// interpolated from the implicit function values, and not the
	/// input scalar data. If you enable this flag but do not provide an
	/// implicit function an error will be reported.
	/// </summary>
	public virtual void SetGenerateClipScalars(int _arg)
	{
		vtkGenericClip_SetGenerateClipScalars_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_SetGenerateClippedOutput_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether a second output is generated. The second output
	/// contains the polygonal data that's been clipped away.
	/// </summary>
	public virtual void SetGenerateClippedOutput(int _arg)
	{
		vtkGenericClip_SetGenerateClippedOutput_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_SetInsideOut_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, a vertex is considered
	/// inside the implicit function if its value is greater than the
	/// Value ivar. When InsideOutside is turned on, a vertex is
	/// considered inside the implicit function if its implicit function
	/// value is less than or equal to the Value ivar.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual void SetInsideOut(int _arg)
	{
		vtkGenericClip_SetInsideOut_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_SetLocator_33(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a spatial locator for merging points. By default, an
	/// instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkGenericClip_SetLocator_33(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_SetMergeTolerance_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tolerance for merging clip intersection points that are near
	/// the vertices of cells. This tolerance is used to prevent the generation
	/// of degenerate primitives. Note that only 3D cells actually use this
	/// instance variable.
	/// </summary>
	public virtual void SetMergeTolerance(double _arg)
	{
		vtkGenericClip_SetMergeTolerance_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericClip_SetValue_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the clipping value of the implicit function (if clipping with
	/// implicit function) or scalar value (if clipping with
	/// scalars). The default value is 0.0.
	/// </summary>
	public virtual void SetValue(double _arg)
	{
		vtkGenericClip_SetValue_35(GetCppThis(), _arg);
	}
}
