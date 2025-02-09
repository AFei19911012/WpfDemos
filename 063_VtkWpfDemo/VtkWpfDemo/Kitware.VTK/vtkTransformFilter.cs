using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTransformFilter
/// </summary>
/// <remarks>
///    transform points and associated normals and vectors
///
/// vtkTransformFilter is a filter to transform point coordinates, and
/// associated point normals and vectors, as well as cell normals and vectors.
/// Transformed data array will be stored in a float array or a double array.
/// Other point and cell data are passed through the filter, unless
/// TransformAllInputVectors is set to true, in this case all other 3
/// components arrays from point and cell data will be transformed as well.
///
/// An alternative method of transformation is to use vtkActor's methods
/// to scale, rotate, and translate objects. The difference between the
/// two methods is that vtkActor's transformation simply effects where
/// objects are rendered (via the graphics pipeline), whereas
/// vtkTransformFilter actually modifies point coordinates in the
/// visualization pipeline. This is necessary for some objects
/// (e.g., vtkProbeFilter) that require point coordinates as input.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractTransform vtkTransformPolyDataFilter vtkActor
/// </seealso>
public class vtkTransformFilter : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTransformFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTransformFilter()
	{
		MRClassNameKey = "class vtkTransformFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTransformFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkTransformFilter New()
	{
		vtkTransformFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public vtkTransformFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTransformFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTransformFilter_GetMTime_01(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the transform.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTransformFilter_GetMTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTransformFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTransformFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformFilter_GetOutputPointsPrecision_04(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkTransformFilter_GetOutputPointsPrecision_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformFilter_GetTransform_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the transform object used to transform points.
	/// </summary>
	public virtual vtkAbstractTransform GetTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformFilter_GetTransform_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTransformFilter_GetTransformAllInputVectors_06(HandleRef pThis);

	/// <summary>
	/// If off (the default), only Vectors and Normals will be transformed.  If
	/// on, all 3-component data arrays (treated as 3D vectors) will be
	/// transformed, while other non-3-component data arrays will be passed
	/// through to the output unchanged.
	/// </summary>
	public virtual bool GetTransformAllInputVectors()
	{
		return (vtkTransformFilter_GetTransformAllInputVectors_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTransformFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformFilter_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTransformFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new vtkTransformFilter NewInstance()
	{
		vtkTransformFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkTransformFilter SafeDownCast(vtkObjectBase o)
	{
		vtkTransformFilter vtkTransformFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransformFilter2 = (vtkTransformFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransformFilter2.Register(null);
			}
		}
		return vtkTransformFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformFilter_SetOutputPointsPrecision_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkTransformFilter_SetOutputPointsPrecision_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformFilter_SetTransform_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the transform object used to transform points.
	/// </summary>
	public virtual void SetTransform(vtkAbstractTransform arg0)
	{
		vtkTransformFilter_SetTransform_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformFilter_SetTransformAllInputVectors_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// If off (the default), only Vectors and Normals will be transformed.  If
	/// on, all 3-component data arrays (treated as 3D vectors) will be
	/// transformed, while other non-3-component data arrays will be passed
	/// through to the output unchanged.
	/// </summary>
	public virtual void SetTransformAllInputVectors(bool _arg)
	{
		vtkTransformFilter_SetTransformAllInputVectors_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformFilter_TransformAllInputVectorsOff_15(HandleRef pThis);

	/// <summary>
	/// If off (the default), only Vectors and Normals will be transformed.  If
	/// on, all 3-component data arrays (treated as 3D vectors) will be
	/// transformed, while other non-3-component data arrays will be passed
	/// through to the output unchanged.
	/// </summary>
	public virtual void TransformAllInputVectorsOff()
	{
		vtkTransformFilter_TransformAllInputVectorsOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformFilter_TransformAllInputVectorsOn_16(HandleRef pThis);

	/// <summary>
	/// If off (the default), only Vectors and Normals will be transformed.  If
	/// on, all 3-component data arrays (treated as 3D vectors) will be
	/// transformed, while other non-3-component data arrays will be passed
	/// through to the output unchanged.
	/// </summary>
	public virtual void TransformAllInputVectorsOn()
	{
		vtkTransformFilter_TransformAllInputVectorsOn_16(GetCppThis());
	}
}
