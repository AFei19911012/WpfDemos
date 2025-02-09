using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellQuality
/// </summary>
/// <remarks>
///    Calculate functions of quality of the elements of a mesh
///
/// vtkCellQuality computes one or more functions of (geometric) quality for each
/// cell of a mesh.  The per-cell quality is added to the mesh's cell data, in an
/// array named "CellQuality." Cell types not supported by this filter or undefined
/// quality of supported cell types will have an entry of -1.
///
/// @warning
/// Most quadrilateral quality functions are intended for planar quadrilaterals
/// only.  The minimal angle is not, strictly speaking, a quality function, but
/// it is provided because of its usage by many authors.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
/// </remarks>
public class vtkCellQuality : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellQuality";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellQuality()
	{
		MRClassNameKey = "class vtkCellQuality";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellQuality"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellQuality(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellQuality_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellQuality New()
	{
		vtkCellQuality result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellQuality_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCellQuality()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellQuality_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellQuality_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellQuality_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellQuality_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellQuality_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkMeshQuality.QualityMeasureTypes vtkCellQuality_GetQualityMeasure_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public virtual vtkMeshQuality.QualityMeasureTypes GetQualityMeasure()
	{
		return vtkCellQuality_GetQualityMeasure_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCellQuality_GetUndefinedQuality_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the return value for undefined quality. Undefined quality
	/// are qualities that could be addressed by this filter but is not well
	/// defined for the particular geometry of cell in question, e.g. a
	/// volume query for a triangle. Undefined quality will always be undefined.
	/// The default value for UndefinedQuality is -1.
	/// </summary>
	public virtual double GetUndefinedQuality()
	{
		return vtkCellQuality_GetUndefinedQuality_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCellQuality_GetUnsupportedGeometry_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the return value for unsupported geometry. Unsupported geometry
	/// are geometries that are not supported by this filter currently, future
	/// implementation might include support for them. The default value for
	/// UnsupportedGeometry is -1.
	/// </summary>
	public virtual double GetUnsupportedGeometry()
	{
		return vtkCellQuality_GetUnsupportedGeometry_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellQuality_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellQuality_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellQuality_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellQuality_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellQuality_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCellQuality NewInstance()
	{
		vtkCellQuality result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellQuality_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCellQuality_PixelArea_10(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the return value for undefined quality. Undefined quality
	/// are qualities that could be addressed by this filter but is not well
	/// defined for the particular geometry of cell in question, e.g. a
	/// volume query for a triangle. Undefined quality will always be undefined.
	/// The default value for UndefinedQuality is -1.
	/// </summary>
	public double PixelArea(vtkCell arg0)
	{
		return vtkCellQuality_PixelArea_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCellQuality_PolygonArea_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the return value for undefined quality. Undefined quality
	/// are qualities that could be addressed by this filter but is not well
	/// defined for the particular geometry of cell in question, e.g. a
	/// volume query for a triangle. Undefined quality will always be undefined.
	/// The default value for UndefinedQuality is -1.
	/// </summary>
	public double PolygonArea(vtkCell arg0)
	{
		return vtkCellQuality_PolygonArea_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellQuality_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellQuality SafeDownCast(vtkObjectBase o)
	{
		vtkCellQuality vtkCellQuality2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellQuality_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellQuality2 = (vtkCellQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellQuality2.Register(null);
			}
		}
		return vtkCellQuality2;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasure_13(HandleRef pThis, vtkMeshQuality.QualityMeasureTypes _arg);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public virtual void SetQualityMeasure(vtkMeshQuality.QualityMeasureTypes _arg)
	{
		vtkCellQuality_SetQualityMeasure_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasure_14(HandleRef pThis, int measure);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public virtual void SetQualityMeasure(int measure)
	{
		vtkCellQuality_SetQualityMeasure_14(GetCppThis(), measure);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToArea_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToArea()
	{
		vtkCellQuality_SetQualityMeasureToArea_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToAspectFrobenius_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToAspectFrobenius()
	{
		vtkCellQuality_SetQualityMeasureToAspectFrobenius_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToAspectGamma_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToAspectGamma()
	{
		vtkCellQuality_SetQualityMeasureToAspectGamma_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToAspectRatio_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToAspectRatio()
	{
		vtkCellQuality_SetQualityMeasureToAspectRatio_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToCollapseRatio_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToCollapseRatio()
	{
		vtkCellQuality_SetQualityMeasureToCollapseRatio_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToCondition_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToCondition()
	{
		vtkCellQuality_SetQualityMeasureToCondition_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToDiagonal_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToDiagonal()
	{
		vtkCellQuality_SetQualityMeasureToDiagonal_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToDimension_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToDimension()
	{
		vtkCellQuality_SetQualityMeasureToDimension_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToDistortion_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToDistortion()
	{
		vtkCellQuality_SetQualityMeasureToDistortion_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToJacobian_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToJacobian()
	{
		vtkCellQuality_SetQualityMeasureToJacobian_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToMaxAngle_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToMaxAngle()
	{
		vtkCellQuality_SetQualityMeasureToMaxAngle_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToMaxAspectFrobenius_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToMaxAspectFrobenius()
	{
		vtkCellQuality_SetQualityMeasureToMaxAspectFrobenius_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToMaxEdgeRatio_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToMaxEdgeRatio()
	{
		vtkCellQuality_SetQualityMeasureToMaxEdgeRatio_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToMedAspectFrobenius_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToMedAspectFrobenius()
	{
		vtkCellQuality_SetQualityMeasureToMedAspectFrobenius_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToMinAngle_29(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToMinAngle()
	{
		vtkCellQuality_SetQualityMeasureToMinAngle_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToOddy_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToOddy()
	{
		vtkCellQuality_SetQualityMeasureToOddy_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToRadiusRatio_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToRadiusRatio()
	{
		vtkCellQuality_SetQualityMeasureToRadiusRatio_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToRelativeSizeSquared_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToRelativeSizeSquared()
	{
		vtkCellQuality_SetQualityMeasureToRelativeSizeSquared_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToScaledJacobian_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToScaledJacobian()
	{
		vtkCellQuality_SetQualityMeasureToScaledJacobian_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToShape_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToShape()
	{
		vtkCellQuality_SetQualityMeasureToShape_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToShapeAndSize_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToShapeAndSize()
	{
		vtkCellQuality_SetQualityMeasureToShapeAndSize_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToShear_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToShear()
	{
		vtkCellQuality_SetQualityMeasureToShear_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToShearAndSize_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToShearAndSize()
	{
		vtkCellQuality_SetQualityMeasureToShearAndSize_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToSkew_38(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToSkew()
	{
		vtkCellQuality_SetQualityMeasureToSkew_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToStretch_39(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToStretch()
	{
		vtkCellQuality_SetQualityMeasureToStretch_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToTaper_40(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToTaper()
	{
		vtkCellQuality_SetQualityMeasureToTaper_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToVolume_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToVolume()
	{
		vtkCellQuality_SetQualityMeasureToVolume_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetQualityMeasureToWarpage_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of all
	/// supported geometries. For qualities that are not defined for certain
	/// geometries, later program logic ensures that CellQualityNone static
	/// function will be used so that a predefined value is returned for the
	/// request.
	/// There is no default value for this call and valid values include all
	/// possible qualities supported by this class.
	///
	/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
	/// </summary>
	public void SetQualityMeasureToWarpage()
	{
		vtkCellQuality_SetQualityMeasureToWarpage_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetUndefinedQuality_43(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the return value for undefined quality. Undefined quality
	/// are qualities that could be addressed by this filter but is not well
	/// defined for the particular geometry of cell in question, e.g. a
	/// volume query for a triangle. Undefined quality will always be undefined.
	/// The default value for UndefinedQuality is -1.
	/// </summary>
	public virtual void SetUndefinedQuality(double _arg)
	{
		vtkCellQuality_SetUndefinedQuality_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellQuality_SetUnsupportedGeometry_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the return value for unsupported geometry. Unsupported geometry
	/// are geometries that are not supported by this filter currently, future
	/// implementation might include support for them. The default value for
	/// UnsupportedGeometry is -1.
	/// </summary>
	public virtual void SetUnsupportedGeometry(double _arg)
	{
		vtkCellQuality_SetUnsupportedGeometry_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCellQuality_TriangleStripArea_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the return value for undefined quality. Undefined quality
	/// are qualities that could be addressed by this filter but is not well
	/// defined for the particular geometry of cell in question, e.g. a
	/// volume query for a triangle. Undefined quality will always be undefined.
	/// The default value for UndefinedQuality is -1.
	/// </summary>
	public double TriangleStripArea(vtkCell arg0)
	{
		return vtkCellQuality_TriangleStripArea_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
