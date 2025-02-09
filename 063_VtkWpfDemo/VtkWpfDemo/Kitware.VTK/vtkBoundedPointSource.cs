using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBoundedPointSource
/// </summary>
/// <remarks>
///    create a random cloud of points within a
/// specified bounding box
///
///
/// vtkBoundedPointSource is a source object that creates a user-specified
/// number of points within a specified bounding box. The points are scattered
/// randomly throughout the box. Optionally, the user can produce a
/// vtkPolyVertex cell as well as random scalar values within a specified
/// range. The class is typically used for debugging and testing, as well as
/// seeding streamlines.
/// </remarks>
public class vtkBoundedPointSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBoundedPointSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBoundedPointSource()
	{
		MRClassNameKey = "class vtkBoundedPointSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoundedPointSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBoundedPointSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPointSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new static vtkBoundedPointSource New()
	{
		vtkBoundedPointSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoundedPointSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoundedPointSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public vtkBoundedPointSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBoundedPointSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPointSource_GetBounds_01(HandleRef pThis);

	/// <summary>
	/// Set the bounding box for the point distribution. By default the bounds is
	/// (-1,1,-1,1,-1,1).
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkBoundedPointSource_GetBounds_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_GetBounds_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the bounding box for the point distribution. By default the bounds is
	/// (-1,1,-1,1,-1,1).
	/// </summary>
	public virtual void GetBounds(IntPtr data)
	{
		vtkBoundedPointSource_GetBounds_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoundedPointSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBoundedPointSource_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoundedPointSource_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBoundedPointSource_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoundedPointSource_GetNumberOfPoints_05(HandleRef pThis);

	/// <summary>
	/// Set the number of points to generate.
	/// </summary>
	public virtual long GetNumberOfPoints()
	{
		return vtkBoundedPointSource_GetNumberOfPoints_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoundedPointSource_GetNumberOfPointsMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set the number of points to generate.
	/// </summary>
	public virtual long GetNumberOfPointsMaxValue()
	{
		return vtkBoundedPointSource_GetNumberOfPointsMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoundedPointSource_GetNumberOfPointsMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set the number of points to generate.
	/// </summary>
	public virtual long GetNumberOfPointsMinValue()
	{
		return vtkBoundedPointSource_GetNumberOfPointsMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPointSource_GetOutputPointsPrecision_08(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkBoundedPointSource_GetOutputPointsPrecision_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBoundedPointSource_GetProduceCellOutput_09(HandleRef pThis);

	/// <summary>
	/// Indicate whether to produce a vtkPolyVertex cell to go along with the
	/// output vtkPoints generated. By default a cell is NOT produced. Some filters
	/// do not need the vtkPolyVertex which just consumes a lot of memory.
	/// </summary>
	public virtual bool GetProduceCellOutput()
	{
		return (vtkBoundedPointSource_GetProduceCellOutput_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBoundedPointSource_GetProduceRandomScalars_10(HandleRef pThis);

	/// <summary>
	/// Indicate whether to produce random point scalars in the output. By default
	/// this is off.
	/// </summary>
	public virtual bool GetProduceRandomScalars()
	{
		return (vtkBoundedPointSource_GetProduceRandomScalars_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPointSource_GetScalarRange_11(HandleRef pThis);

	/// <summary>
	/// Set the range in which the random scalars should be produced. By default the
	/// scalar range is (0,1).
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkBoundedPointSource_GetScalarRange_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_GetScalarRange_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the range in which the random scalars should be produced. By default the
	/// scalar range is (0,1).
	/// </summary>
	public virtual void GetScalarRange(IntPtr data)
	{
		vtkBoundedPointSource_GetScalarRange_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPointSource_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBoundedPointSource_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoundedPointSource_IsTypeOf_14(string type);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBoundedPointSource_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPointSource_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new vtkBoundedPointSource NewInstance()
	{
		vtkBoundedPointSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoundedPointSource_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoundedPointSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_ProduceCellOutputOff_17(HandleRef pThis);

	/// <summary>
	/// Indicate whether to produce a vtkPolyVertex cell to go along with the
	/// output vtkPoints generated. By default a cell is NOT produced. Some filters
	/// do not need the vtkPolyVertex which just consumes a lot of memory.
	/// </summary>
	public virtual void ProduceCellOutputOff()
	{
		vtkBoundedPointSource_ProduceCellOutputOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_ProduceCellOutputOn_18(HandleRef pThis);

	/// <summary>
	/// Indicate whether to produce a vtkPolyVertex cell to go along with the
	/// output vtkPoints generated. By default a cell is NOT produced. Some filters
	/// do not need the vtkPolyVertex which just consumes a lot of memory.
	/// </summary>
	public virtual void ProduceCellOutputOn()
	{
		vtkBoundedPointSource_ProduceCellOutputOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_ProduceRandomScalarsOff_19(HandleRef pThis);

	/// <summary>
	/// Indicate whether to produce random point scalars in the output. By default
	/// this is off.
	/// </summary>
	public virtual void ProduceRandomScalarsOff()
	{
		vtkBoundedPointSource_ProduceRandomScalarsOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_ProduceRandomScalarsOn_20(HandleRef pThis);

	/// <summary>
	/// Indicate whether to produce random point scalars in the output. By default
	/// this is off.
	/// </summary>
	public virtual void ProduceRandomScalarsOn()
	{
		vtkBoundedPointSource_ProduceRandomScalarsOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoundedPointSource_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information and printing.
	/// </summary>
	public new static vtkBoundedPointSource SafeDownCast(vtkObjectBase o)
	{
		vtkBoundedPointSource vtkBoundedPointSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoundedPointSource_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBoundedPointSource2 = (vtkBoundedPointSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBoundedPointSource2.Register(null);
			}
		}
		return vtkBoundedPointSource2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_SetBounds_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set the bounding box for the point distribution. By default the bounds is
	/// (-1,1,-1,1,-1,1).
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkBoundedPointSource_SetBounds_22(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_SetBounds_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the bounding box for the point distribution. By default the bounds is
	/// (-1,1,-1,1,-1,1).
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkBoundedPointSource_SetBounds_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_SetNumberOfPoints_24(HandleRef pThis, long _arg);

	/// <summary>
	/// Set the number of points to generate.
	/// </summary>
	public virtual void SetNumberOfPoints(long _arg)
	{
		vtkBoundedPointSource_SetNumberOfPoints_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_SetOutputPointsPrecision_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkBoundedPointSource_SetOutputPointsPrecision_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_SetProduceCellOutput_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to produce a vtkPolyVertex cell to go along with the
	/// output vtkPoints generated. By default a cell is NOT produced. Some filters
	/// do not need the vtkPolyVertex which just consumes a lot of memory.
	/// </summary>
	public virtual void SetProduceCellOutput(bool _arg)
	{
		vtkBoundedPointSource_SetProduceCellOutput_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_SetProduceRandomScalars_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to produce random point scalars in the output. By default
	/// this is off.
	/// </summary>
	public virtual void SetProduceRandomScalars(bool _arg)
	{
		vtkBoundedPointSource_SetProduceRandomScalars_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_SetScalarRange_28(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the range in which the random scalars should be produced. By default the
	/// scalar range is (0,1).
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkBoundedPointSource_SetScalarRange_28(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoundedPointSource_SetScalarRange_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range in which the random scalars should be produced. By default the
	/// scalar range is (0,1).
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkBoundedPointSource_SetScalarRange_29(GetCppThis(), _arg);
	}
}
