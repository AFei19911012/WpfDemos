using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCubeSource
/// </summary>
/// <remarks>
///    create a polygonal representation of a cube
///
/// vtkCubeSource creates a cube centered at origin. The cube is represented
/// with four-sided polygons. It is possible to specify the length, width,
/// and height of the cube independently.
/// </remarks>
public class vtkCubeSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCubeSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCubeSource()
	{
		MRClassNameKey = "class vtkCubeSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubeSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCubeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCubeSource New()
	{
		vtkCubeSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCubeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCubeSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCubeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_GetBounds_01(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Convenience methods allows creation of cube by specifying bounding box.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkCubeSource_GetBounds_01(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeSource_GetCenter_02(HandleRef pThis);

	/// <summary>
	/// Set the center of the cube.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkCubeSource_GetCenter_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_GetCenter_03(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the center of the cube.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkCubeSource_GetCenter_03(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCubeSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCubeSource_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCubeSource_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCubeSource_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeSource_GetOutputPointsPrecision_06(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkCubeSource_GetOutputPointsPrecision_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeSource_GetXLength_07(HandleRef pThis);

	/// <summary>
	/// Set the length of the cube in the x-direction.
	/// </summary>
	public virtual double GetXLength()
	{
		return vtkCubeSource_GetXLength_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeSource_GetXLengthMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set the length of the cube in the x-direction.
	/// </summary>
	public virtual double GetXLengthMaxValue()
	{
		return vtkCubeSource_GetXLengthMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeSource_GetXLengthMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set the length of the cube in the x-direction.
	/// </summary>
	public virtual double GetXLengthMinValue()
	{
		return vtkCubeSource_GetXLengthMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeSource_GetYLength_10(HandleRef pThis);

	/// <summary>
	/// Set the length of the cube in the y-direction.
	/// </summary>
	public virtual double GetYLength()
	{
		return vtkCubeSource_GetYLength_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeSource_GetYLengthMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set the length of the cube in the y-direction.
	/// </summary>
	public virtual double GetYLengthMaxValue()
	{
		return vtkCubeSource_GetYLengthMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeSource_GetYLengthMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set the length of the cube in the y-direction.
	/// </summary>
	public virtual double GetYLengthMinValue()
	{
		return vtkCubeSource_GetYLengthMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeSource_GetZLength_13(HandleRef pThis);

	/// <summary>
	/// Set the length of the cube in the z-direction.
	/// </summary>
	public virtual double GetZLength()
	{
		return vtkCubeSource_GetZLength_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeSource_GetZLengthMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set the length of the cube in the z-direction.
	/// </summary>
	public virtual double GetZLengthMaxValue()
	{
		return vtkCubeSource_GetZLengthMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCubeSource_GetZLengthMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set the length of the cube in the z-direction.
	/// </summary>
	public virtual double GetZLengthMinValue()
	{
		return vtkCubeSource_GetZLengthMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeSource_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCubeSource_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCubeSource_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCubeSource_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeSource_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCubeSource NewInstance()
	{
		vtkCubeSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeSource_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCubeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCubeSource_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCubeSource SafeDownCast(vtkObjectBase o)
	{
		vtkCubeSource vtkCubeSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCubeSource_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCubeSource2 = (vtkCubeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCubeSource2.Register(null);
			}
		}
		return vtkCubeSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_SetBounds_21(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Convenience methods allows creation of cube by specifying bounding box.
	/// </summary>
	public void SetBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkCubeSource_SetBounds_21(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_SetBounds_22(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Convenience methods allows creation of cube by specifying bounding box.
	/// </summary>
	public void SetBounds(IntPtr bounds)
	{
		vtkCubeSource_SetBounds_22(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_SetCenter_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the center of the cube.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkCubeSource_SetCenter_23(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_SetCenter_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the center of the cube.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkCubeSource_SetCenter_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_SetOutputPointsPrecision_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkCubeSource_SetOutputPointsPrecision_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_SetXLength_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the length of the cube in the x-direction.
	/// </summary>
	public virtual void SetXLength(double _arg)
	{
		vtkCubeSource_SetXLength_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_SetYLength_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the length of the cube in the y-direction.
	/// </summary>
	public virtual void SetYLength(double _arg)
	{
		vtkCubeSource_SetYLength_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCubeSource_SetZLength_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the length of the cube in the z-direction.
	/// </summary>
	public virtual void SetZLength(double _arg)
	{
		vtkCubeSource_SetZLength_28(GetCppThis(), _arg);
	}
}
