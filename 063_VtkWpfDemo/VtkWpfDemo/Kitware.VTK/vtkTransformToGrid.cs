using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTransformToGrid
/// </summary>
/// <remarks>
///    create a grid for a vtkGridTransform
///
/// vtkTransformToGrid takes any transform as input and produces a grid
/// for use by a vtkGridTransform.  This can be used, for example, to
/// invert a grid transform, concatenate two grid transforms, or to
/// convert a thin plate spline transform into a grid transform.
/// </remarks>
/// <seealso>
///
/// vtkGridTransform vtkThinPlateSplineTransform vtkAbstractTransform
/// </seealso>
public class vtkTransformToGrid : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTransformToGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTransformToGrid()
	{
		MRClassNameKey = "class vtkTransformToGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformToGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTransformToGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformToGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransformToGrid New()
	{
		vtkTransformToGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformToGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformToGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTransformToGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTransformToGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkTransformToGrid_GetDisplacementScale_01(HandleRef pThis);

	/// <summary>
	/// Get the scale and shift to convert integer grid elements into
	/// real values:  dx = scale*di + shift.  If the grid is of double type,
	/// then scale = 1 and shift = 0.
	/// </summary>
	public double GetDisplacementScale()
	{
		return vtkTransformToGrid_GetDisplacementScale_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTransformToGrid_GetDisplacementShift_02(HandleRef pThis);

	/// <summary>
	/// Get the scale and shift to convert integer grid elements into
	/// real values:  dx = scale*di + shift.  If the grid is of double type,
	/// then scale = 1 and shift = 0.
	/// </summary>
	public double GetDisplacementShift()
	{
		return vtkTransformToGrid_GetDisplacementShift_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformToGrid_GetGridExtent_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the extent of the grid.
	/// </summary>
	public virtual int[] GetGridExtent()
	{
		IntPtr intPtr = vtkTransformToGrid_GetGridExtent_03(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_GetGridExtent_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Get/Set the extent of the grid.
	/// </summary>
	public virtual void GetGridExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkTransformToGrid_GetGridExtent_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_GetGridExtent_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the extent of the grid.
	/// </summary>
	public virtual void GetGridExtent(IntPtr _arg)
	{
		vtkTransformToGrid_GetGridExtent_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformToGrid_GetGridOrigin_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the origin of the grid.
	/// </summary>
	public virtual double[] GetGridOrigin()
	{
		IntPtr intPtr = vtkTransformToGrid_GetGridOrigin_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_GetGridOrigin_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get/Set the origin of the grid.
	/// </summary>
	public virtual void GetGridOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkTransformToGrid_GetGridOrigin_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_GetGridOrigin_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the origin of the grid.
	/// </summary>
	public virtual void GetGridOrigin(IntPtr _arg)
	{
		vtkTransformToGrid_GetGridOrigin_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformToGrid_GetGridScalarType_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the scalar type of the grid.  The default is float.
	/// </summary>
	public virtual int GetGridScalarType()
	{
		return vtkTransformToGrid_GetGridScalarType_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformToGrid_GetGridSpacing_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the spacing between samples in the grid.
	/// </summary>
	public virtual double[] GetGridSpacing()
	{
		IntPtr intPtr = vtkTransformToGrid_GetGridSpacing_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_GetGridSpacing_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get/Set the spacing between samples in the grid.
	/// </summary>
	public virtual void GetGridSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkTransformToGrid_GetGridSpacing_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_GetGridSpacing_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the spacing between samples in the grid.
	/// </summary>
	public virtual void GetGridSpacing(IntPtr _arg)
	{
		vtkTransformToGrid_GetGridSpacing_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformToGrid_GetInput_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the transform which will be converted into a grid.
	/// </summary>
	public virtual vtkAbstractTransform GetInput()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformToGrid_GetInput_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformToGrid_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTransformToGrid_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformToGrid_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTransformToGrid_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformToGrid_GetOutput_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkImageData GetOutput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformToGrid_GetOutput_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTransformToGrid_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTransformToGrid_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformToGrid_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTransformToGrid_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformToGrid_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTransformToGrid NewInstance()
	{
		vtkTransformToGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformToGrid_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformToGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformToGrid_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransformToGrid SafeDownCast(vtkObjectBase o)
	{
		vtkTransformToGrid vtkTransformToGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformToGrid_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransformToGrid2 = (vtkTransformToGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransformToGrid2.Register(null);
			}
		}
		return vtkTransformToGrid2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridExtent_22(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Get/Set the extent of the grid.
	/// </summary>
	public virtual void SetGridExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkTransformToGrid_SetGridExtent_22(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridExtent_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the extent of the grid.
	/// </summary>
	public virtual void SetGridExtent(IntPtr _arg)
	{
		vtkTransformToGrid_SetGridExtent_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridOrigin_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get/Set the origin of the grid.
	/// </summary>
	public virtual void SetGridOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkTransformToGrid_SetGridOrigin_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridOrigin_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the origin of the grid.
	/// </summary>
	public virtual void SetGridOrigin(IntPtr _arg)
	{
		vtkTransformToGrid_SetGridOrigin_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridScalarType_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the scalar type of the grid.  The default is float.
	/// </summary>
	public virtual void SetGridScalarType(int _arg)
	{
		vtkTransformToGrid_SetGridScalarType_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridScalarTypeToChar_27(HandleRef pThis);

	/// <summary>
	/// Get/Set the scalar type of the grid.  The default is float.
	/// </summary>
	public void SetGridScalarTypeToChar()
	{
		vtkTransformToGrid_SetGridScalarTypeToChar_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridScalarTypeToDouble_28(HandleRef pThis);

	/// <summary>
	/// Get/Set the scalar type of the grid.  The default is float.
	/// </summary>
	public void SetGridScalarTypeToDouble()
	{
		vtkTransformToGrid_SetGridScalarTypeToDouble_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridScalarTypeToFloat_29(HandleRef pThis);

	/// <summary>
	/// Get/Set the scalar type of the grid.  The default is float.
	/// </summary>
	public void SetGridScalarTypeToFloat()
	{
		vtkTransformToGrid_SetGridScalarTypeToFloat_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridScalarTypeToShort_30(HandleRef pThis);

	/// <summary>
	/// Get/Set the scalar type of the grid.  The default is float.
	/// </summary>
	public void SetGridScalarTypeToShort()
	{
		vtkTransformToGrid_SetGridScalarTypeToShort_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridScalarTypeToUnsignedChar_31(HandleRef pThis);

	/// <summary>
	/// Get/Set the scalar type of the grid.  The default is float.
	/// </summary>
	public void SetGridScalarTypeToUnsignedChar()
	{
		vtkTransformToGrid_SetGridScalarTypeToUnsignedChar_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridScalarTypeToUnsignedShort_32(HandleRef pThis);

	/// <summary>
	/// Get/Set the scalar type of the grid.  The default is float.
	/// </summary>
	public void SetGridScalarTypeToUnsignedShort()
	{
		vtkTransformToGrid_SetGridScalarTypeToUnsignedShort_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridSpacing_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get/Set the spacing between samples in the grid.
	/// </summary>
	public virtual void SetGridSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkTransformToGrid_SetGridSpacing_33(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetGridSpacing_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the spacing between samples in the grid.
	/// </summary>
	public virtual void SetGridSpacing(IntPtr _arg)
	{
		vtkTransformToGrid_SetGridSpacing_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformToGrid_SetInput_35(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the transform which will be converted into a grid.
	/// </summary>
	public virtual void SetInput(vtkAbstractTransform arg0)
	{
		vtkTransformToGrid_SetInput_35(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
