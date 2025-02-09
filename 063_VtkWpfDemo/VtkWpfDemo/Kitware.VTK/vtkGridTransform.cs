using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGridTransform
/// </summary>
/// <remarks>
///    a nonlinear warp transformation
///
/// vtkGridTransform describes a nonlinear warp transformation as a set
/// of displacement vectors sampled along a uniform 3D grid.
/// @warning
/// The inverse grid transform is calculated using an iterative method,
/// and is several times more expensive than the forward transform.
/// </remarks>
/// <seealso>
///
/// vtkThinPlateSplineTransform vtkGeneralTransform vtkTransformToGrid
/// </seealso>
public class vtkGridTransform : vtkWarpTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGridTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGridTransform()
	{
		MRClassNameKey = "class vtkGridTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGridTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGridTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGridTransform New()
	{
		vtkGridTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGridTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGridTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGridTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGridTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridTransform_GetDisplacementGrid_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the grid transform (the grid transform must have three
	/// components for displacement in x, y, and z respectively).
	/// The vtkGridTransform class will never modify the data.
	/// Note that SetDisplacementGridData() does not setup a pipeline
	/// connection whereas SetDisplacementGridConnection does.
	/// </summary>
	public virtual vtkImageData GetDisplacementGrid()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGridTransform_GetDisplacementGrid_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGridTransform_GetDisplacementScale_02(HandleRef pThis);

	/// <summary>
	/// Set scale factor to be applied to the displacements.
	/// This is used primarily for grids which contain integer
	/// data types.  Default: 1
	/// </summary>
	public virtual double GetDisplacementScale()
	{
		return vtkGridTransform_GetDisplacementScale_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGridTransform_GetDisplacementShift_03(HandleRef pThis);

	/// <summary>
	/// Set a shift to be applied to the displacements.  The shift
	/// is applied after the scale, i.e. x = scale*y + shift.
	/// Default: 0
	/// </summary>
	public virtual double GetDisplacementShift()
	{
		return vtkGridTransform_GetDisplacementShift_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridTransform_GetInterpolationMode_04(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for sampling the grid.  Higher-order
	/// interpolation allows you to use a sparser grid.
	/// Default: Linear.
	/// </summary>
	public virtual int GetInterpolationMode()
	{
		return vtkGridTransform_GetInterpolationMode_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridTransform_GetInterpolationModeAsString_05(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for sampling the grid.  Higher-order
	/// interpolation allows you to use a sparser grid.
	/// Default: Linear.
	/// </summary>
	public string GetInterpolationModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGridTransform_GetInterpolationModeAsString_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGridTransform_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Get the MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGridTransform_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGridTransform_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGridTransform_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGridTransform_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGridTransform_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridTransform_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGridTransform_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGridTransform_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGridTransform_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridTransform_MakeTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make another transform of the same type.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGridTransform_MakeTransform_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridTransform_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGridTransform NewInstance()
	{
		vtkGridTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGridTransform_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGridTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGridTransform_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGridTransform SafeDownCast(vtkObjectBase o)
	{
		vtkGridTransform vtkGridTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGridTransform_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGridTransform2 = (vtkGridTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGridTransform2.Register(null);
			}
		}
		return vtkGridTransform2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridTransform_SetDisplacementGridConnection_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the grid transform (the grid transform must have three
	/// components for displacement in x, y, and z respectively).
	/// The vtkGridTransform class will never modify the data.
	/// Note that SetDisplacementGridData() does not setup a pipeline
	/// connection whereas SetDisplacementGridConnection does.
	/// </summary>
	public virtual void SetDisplacementGridConnection(vtkAlgorithmOutput arg0)
	{
		vtkGridTransform_SetDisplacementGridConnection_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridTransform_SetDisplacementGridData_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the grid transform (the grid transform must have three
	/// components for displacement in x, y, and z respectively).
	/// The vtkGridTransform class will never modify the data.
	/// Note that SetDisplacementGridData() does not setup a pipeline
	/// connection whereas SetDisplacementGridConnection does.
	/// </summary>
	public virtual void SetDisplacementGridData(vtkImageData arg0)
	{
		vtkGridTransform_SetDisplacementGridData_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridTransform_SetDisplacementScale_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set scale factor to be applied to the displacements.
	/// This is used primarily for grids which contain integer
	/// data types.  Default: 1
	/// </summary>
	public virtual void SetDisplacementScale(double _arg)
	{
		vtkGridTransform_SetDisplacementScale_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridTransform_SetDisplacementShift_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set a shift to be applied to the displacements.  The shift
	/// is applied after the scale, i.e. x = scale*y + shift.
	/// Default: 0
	/// </summary>
	public virtual void SetDisplacementShift(double _arg)
	{
		vtkGridTransform_SetDisplacementShift_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridTransform_SetInterpolationMode_19(HandleRef pThis, int mode);

	/// <summary>
	/// Set interpolation mode for sampling the grid.  Higher-order
	/// interpolation allows you to use a sparser grid.
	/// Default: Linear.
	/// </summary>
	public void SetInterpolationMode(int mode)
	{
		vtkGridTransform_SetInterpolationMode_19(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridTransform_SetInterpolationModeToCubic_20(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for sampling the grid.  Higher-order
	/// interpolation allows you to use a sparser grid.
	/// Default: Linear.
	/// </summary>
	public void SetInterpolationModeToCubic()
	{
		vtkGridTransform_SetInterpolationModeToCubic_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridTransform_SetInterpolationModeToLinear_21(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for sampling the grid.  Higher-order
	/// interpolation allows you to use a sparser grid.
	/// Default: Linear.
	/// </summary>
	public void SetInterpolationModeToLinear()
	{
		vtkGridTransform_SetInterpolationModeToLinear_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGridTransform_SetInterpolationModeToNearestNeighbor_22(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for sampling the grid.  Higher-order
	/// interpolation allows you to use a sparser grid.
	/// Default: Linear.
	/// </summary>
	public void SetInterpolationModeToNearestNeighbor()
	{
		vtkGridTransform_SetInterpolationModeToNearestNeighbor_22(GetCppThis());
	}
}
